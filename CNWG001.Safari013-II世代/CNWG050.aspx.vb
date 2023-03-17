Partial Class CNWG050
    Inherits System.Web.UI.Page

#Region " Web フォーム デザイナで生成されたコード "

    'この呼び出しは Web フォーム デザイナで必要です。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        ' CODEGEN: このメソッド呼び出しは Web フォーム デザイナで必要です。
        ' コード エディタを使って変更しないでください。
        InitializeComponent()
    End Sub

#End Region

    Private L_Func As TP2920
    'Private Session("L_BtnBack") As Boolean
    Private L_BtnPrev As Boolean
    Private Const SessionMsgName As String = "CNWG001.Msg"

    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '------------------------------
        ' セッション状態確認
        '------------------------------
        If IsNothing(Session("TP")) Then
            L_Func = New TP2920()
            If Not L_Func.GF_Initialize() Then
                Response.Redirect("./TP2990.html?CNWG050(Page_Load-1)")
                Exit Sub
            End If
            Session("TP") = L_Func
        Else
            L_Func = Session("TP")
        End If

        Me.ViewState.Add("MENUIMG_PATH", L_Func.GF_GetAppInfo("MENUIMG_PATH"))
        Me.ViewState.Add("IMGSET", L_Func.GF_GetImageSet())

        L_BtnPrev = False

        ' (2005.12.27) まいもん寿司 対応　　お会計コード、お通しコードをTPM090から取得
        Me.ViewState("REG_GOODSCD") = L_Func.GF_GetAppInfo("REG_GOODSCD")       'お会計
        Me.ViewState("OPEN_GOODSCD") = L_Func.GF_GetAppInfo("OPEN_GOODSCD")     'お通し

        btn_Set.Attributes("ONCLICK") = "return false;"

        '（2019.3.26）TEC連動以外　お通しパネル人数入力
        Me.ViewState("TPG_FLG") = L_Func.GF_GetAppInfo("TPG_FLG")
        Me.ViewState("CNWG_INPUT_NUMBER") = L_Func.GF_GetAppInfo3("CNWG_INPUT_NUMBER")

        '------------------------------
        ' ポストバック時は処理対象外
        '------------------------------
        If IsPostBack Then
            Exit Sub
        End If

        Session(SessionMsgName) = ""

        'btn_back.Attributes.Add("ONCLICK", "parent.fWinClose();")
        txt_Seat.Text = Request.QueryString("SEATID") & "番席"

        '------------------------------
        ' 遷移ﾊﾟﾗﾒﾀにより表示項目設定
        '------------------------------
        Call LF_SetForm()

        '決定ボタンクリック時
        Session("L_BtnBack") = False
        If Trim$(Request.QueryString("SUBMITID")) = "btn_Set" Then
            txt_number.Text = Trim$(Request.QueryString("NUMBER"))
            LS_SetClick()
        End If
    End Sub

    Private Function LF_SetForm(Optional ByVal pNext As Boolean = False) As Object

        LF_SetForm = Nothing

        '空席
        btn_0.Visible = True
        btn_1.Visible = True
        btn_2.Visible = True
        btn_3.Visible = True
        btn_4.Visible = True
        btn_5.Visible = True
        btn_6.Visible = True
        btn_7.Visible = True
        btn_8.Visible = True
        btn_9.Visible = True
        btn_cls.Visible = True

        txt_number.Text = "1"
    End Function

    ''' <summary>
    ''' 決定ボタン処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LS_SetClick()

        Dim i As Integer        '' 繰返しカウンタ
        Dim strTERMID As String = Nothing '' 端末識別ID
        Dim lngORDERNO As Long  '' オーダー連番

        'お通し処理の場合、人数未入力はだめ
        If Trim$(txt_number.Text) = "" Then
            Session(SessionMsgName) = "【入力エラー】人数を設定して下さい。"
            Exit Sub
        End If

        'お通し処理の場合、人数がゼロはだめ
        If CInt(Trim$(txt_number.Text)) = 0 Then
            Session(SessionMsgName) = "【入力エラー】人数を設定して下さい。"
            Exit Sub
        End If

        'オーダー状況テーブル登録（TPD010）
        If Not CheckTPD010() Then
            '未お通しの場合
            lngORDERNO = LF_GetOrderNo() + 1
            For i = 0 To 10
                If Not LF_GetTermID(i, strTERMID) Then
                    Exit For
                End If
                Call LF_SetSQLTPD010(strTERMID, lngORDERNO)
            Next
        Else
            'お通し済の場合
            lngORDERNO = LF_GetOrderNo()
            For i = 0 To 10
                If Not LF_GetTermID(i, strTERMID) Then
                    Exit For
                End If
            Next
        End If

        ' 顧客ファイルが作成されたかどうかを確認する。
        If Me.ViewState("TPG_FLG") = "0" And Me.ViewState("CNWG_INPUT_NUMBER") = "0" Then
            'TEC連動(SYS_TYPE = 2)の場合
            Dim intSTN_TIMER As Integer
            intSTN_TIMER = Session("TP").GF_GetAppInfo("STN_TIMER")

            For i = 0 To intSTN_TIMER
                If CheckSTNsend() Then
                    Exit For
                End If

                If i <> intSTN_TIMER Then
                    Sleep(1000)
                Else
                    Session(SessionMsgName) = "お会計を済ませてください。"
                    Session("L_BtnBack") = True
                    Exit Sub
                End If
            Next i
        End If


        '座席番号管理マスタ更新（TPM050）
        Call LF_SetSQLTPM050()

        '宴会メニュー登録（TPM010,TPM011）
        Call LF_SetSQLTPD010_2(strTERMID, lngORDERNO, "1")

        Session(SessionMsgName) = "お通しを受付けました。"

        btn_Set.Enabled = False

        Session("L_BtnBack") = True
    End Sub

    Private Function LF_SetSQLTPD010(ByVal pTERMID As String, ByVal pORDERNO As Long) As Object

        LF_SetSQLTPD010 = Nothing

        Dim strSQL As String
        Dim datNow As Date

        datNow = Now

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPD010 VALUES("
        strSQL = strSQL & "'" & RSet(Request.QueryString("SEATID"), 5) & "', "          '座席番号
        strSQL = strSQL & pORDERNO & ", "                                               'オーダー連番
        strSQL = strSQL & "'" & pTERMID & "', "                                         '端末識別ID
        strSQL = strSQL & "'" & Trim$(Me.ViewState("OPEN_GOODSCD")) & "', "             '商品ID
        strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                          '商品選択日時
        strSQL = strSQL & "0, "                                                         '注文受付日時
        strSQL = strSQL & "0, "                                                         'ステーション配信日時
        strSQL = strSQL & "0, "                                                         '数量
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置１
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ１
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ１
        strSQL = strSQL & "0, "                                                         'SCP数量１
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置２
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ２
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ２
        strSQL = strSQL & "0, "                                                         'SCP数量２
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置３
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ３
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ３
        strSQL = strSQL & "0, "                                                         'SCP数量３
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置４
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ４
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ４
        strSQL = strSQL & "0, "                                                         'SCP数量４
        strSQL = strSQL & "'0', "                                                       'オーダー種別
        strSQL = strSQL & "'0', "                                                       '商品分類
        strSQL = strSQL & "'00', "                                                      '注文フラグ
        strSQL = strSQL & "'000.000.000.000', "                                         '厨房端末識別ID
        strSQL = strSQL & CLng(Trim$(txt_number.Text)) & ", "                           'お通し人数
        strSQL = strSQL & "'CNWG001', "                                                  '更新者
        strSQL = strSQL & "GETDATE())"                                                  '更新日

        If Not L_Func.GF_BeginTrans Then
            GoTo SYSTEM_ERROR
        End If

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Function
        End If

        If Not L_Func.GF_CommitTrans Then
            Call L_Func.GF_RollbackTrans()
            GoTo SYSTEM_ERROR
        End If

        'TPD011(INSERT文)
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPD011 VALUES("
        strSQL = strSQL & "'" & RSet(Request.QueryString("SEATID"), 5) & "', "          '座席番号
        strSQL = strSQL & pORDERNO & ", "                                               'オーダー連番
        strSQL = strSQL & "'" & pTERMID & "', "                                         '端末識別ID
        strSQL = strSQL & "'" & Trim$(Me.ViewState("OPEN_GOODSCD")) & "', "             '商品ID
        strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                          '商品選択日時
        strSQL = strSQL & "0, "                                                         '注文受付日時
        strSQL = strSQL & "0, "                                                         'ステーション配信日時
        strSQL = strSQL & "0, "                                                         '数量
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置１
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ１
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ１
        strSQL = strSQL & "0, "                                                         'SCP数量１
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置２
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ２
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ２
        strSQL = strSQL & "0, "                                                         'SCP数量２
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置３
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ３
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ３
        strSQL = strSQL & "0, "                                                         'SCP数量３
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置４
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ４
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ４
        strSQL = strSQL & "0, "                                                         'SCP数量４
        strSQL = strSQL & "'0', "                                                       'オーダー種別
        strSQL = strSQL & "'0', "                                                       '商品分類
        strSQL = strSQL & "'00', "                                                      '注文フラグ
        strSQL = strSQL & "'000.000.000.000', "                                         '厨房端末識別ID
        strSQL = strSQL & CLng(Trim$(txt_number.Text)) & ", "                           'お通し人数
        strSQL = strSQL & "'0', "                                                       '出力先プリンタ
        strSQL = strSQL & "'CNWG001', "                                                  '更新者
        strSQL = strSQL & "GETDATE())"                                                  '更新日

        If Not L_Func.GF_BeginTrans Then
            GoTo SYSTEM_ERROR
        End If

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Function
        End If

        If Not L_Func.GF_CommitTrans Then
            Call L_Func.GF_RollbackTrans()
            GoTo SYSTEM_ERROR
        End If

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG050(LF_SetSQLTPD010)")
        Exit Function
    End Function

    Private Function LF_SetSQLTPM050() As Object

        LF_SetSQLTPM050 = Nothing

        Dim strSQL As String
        Dim strDrinkMENUID As String

        '*--2014.05.20　統一版対応に伴う不要マスタ コメント化(起因：LF_LANオーダーテキスト発行_B Error!! ODBC--呼び出しが失敗 ErrNum:3146"対処）

        '*--TPM180廃止　((START))
        '飲み放題付き宴会コース注文時対応(コースメニューマスタ(TPM180)検索)
        'If Len(LF_GetDrinkMenuID()) <> 0 Then
        '    strDrinkMENUID = Trim$(LF_GetDrinkMenuID())
        'Else
        '*--TPM180廃止　((end))

        strDrinkMENUID = "000"

        'End If

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050"
        strSQL = strSQL & " SET ORDERSTATUS = '1',"                                     '端末状態フラグ
        strSQL = strSQL & "     SPMENU = '" & Request.QueryString("MENUID") & "',"      '指定メニューＩＤ
        strSQL = strSQL & "     SPMENU2 = '" & strDrinkMENUID & "',"                    '指定メニューＩＤ２
        strSQL = strSQL & "     UPDID = 'CNWG001',"                                      '更新者
        strSQL = strSQL & "     UPDYMD = GETDATE()"                                     '更新日
        strSQL = strSQL & " WHERE SEATID = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
        strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCA'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCB' )"

        If Not L_Func.GF_BeginTrans Then
            GoTo SYSTEM_ERROR
        End If

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Function
        End If

        If Not L_Func.GF_CommitTrans Then
            Call L_Func.GF_RollbackTrans()
            GoTo SYSTEM_ERROR
        End If

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG050(LF_SetSQLTPM050)")
        Exit Function
    End Function

    Private Sub LF_SetSQLTPD050()

        Dim strSQL As String

        strSQL = ""
        strSQL = strSQL & "UPDATE TPD050"
        strSQL = strSQL & " SET D1 = '0', "
        strSQL = strSQL & "     D2 = '0', "
        strSQL = strSQL & "     D3 = '0', "
        strSQL = strSQL & "     D4 = '0', "
        strSQL = strSQL & "     D5 = '0', "
        strSQL = strSQL & "     D6 = '0', "
        strSQL = strSQL & "     D7 = '0', "
        strSQL = strSQL & "     D8 = '0', "
        strSQL = strSQL & "     D9 = '0', "
        strSQL = strSQL & "     D10 = '0' "
        strSQL = strSQL & "  UPDID  = 'CNWG050',"    '更新者
        strSQL = strSQL & "  UPDYMD = GETDATE()"     '更新日
        strSQL = strSQL & " WHERE SEATID = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
        strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCA' "
        strSQL = strSQL & "   OR    TERMKIND = 'TCB' )"

        If Not L_Func.GF_BeginTrans Then
            GoTo SYSTEM_ERROR
        End If

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Sub
        End If

        If Not L_Func.GF_CommitTrans Then
            Call L_Func.GF_RollbackTrans()
            GoTo SYSTEM_ERROR
        End If

        Exit Sub

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG050(LF_SetSQLTPD050)")
        Exit Sub
    End Sub

    Private Function LF_GetDrinkMenuID() As String
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetDrinkMenuID = ""

        strSQL = ""
        strSQL = strSQL & "SELECT TPM180.GOODSCD,"                            '商品コード
        strSQL = strSQL & "       TPM180.DISPMENUID,"                         'タッチパネル表示メニュー
        strSQL = strSQL & "       TPM180.FREEDRINKMENUID"                     '飲み放題メニュー
        strSQL = strSQL & "  FROM TPM010, TPM180"
        strSQL = strSQL & " WHERE TPM010.GOODSCD = TPM180.GOODSCD"
        strSQL = strSQL & "   AND TPM180.GOODSCD = '" & Request.QueryString("GOODSCD") & "'"
        strSQL = strSQL & "   AND TPM180.DISPMENUID = '" & Request.QueryString("MENUID") & "'"
        strSQL = strSQL & "   AND TPM010.SELLFLG = '0'"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG050(LF_GetDrinkMenuID)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Exit Function
        End If

        LF_GetDrinkMenuID = Trim$(objRow("FREEDRINKMENUID"))
    End Function


    Private Function LF_GetOrderNo() As Long
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetOrderNo = 0

        strSQL = ""
        strSQL = strSQL & "SELECT ORDERNO, SELECTTIME"
        strSQL = strSQL & "  FROM TPD010"
        strSQL = strSQL & " WHERE SEATID ='" & RSet(Request.QueryString("SEATID"), 5) & "'"
        strSQL = strSQL & " ORDER BY SELECTTIME DESC"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG050(LF_GetOrderNo_1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG050(LF_GetOrderNo_3)")
            Exit Function
        End If

        LF_GetOrderNo = CLng(objRow("ORDERNO"))
    End Function

    '' **************************************************
    ''  機能概要：お通し商品(商品コード：9998)を作成するかどうかを確認する。
    ''  引    数：
    ''  戻 り 値：True  お通し商品は作成済である。
    ''            False お通し商品は未作成である。なので、作成対象である。
    '' **************************************************
    Private Function CheckTPD010() As Boolean
        Dim strSQL As String    '' SQL実行文字列
        Dim objData As DataSet  '' 取得した内容
        Dim objRow As DataRow = Nothing   '' 指定した位置の内容

        CheckTPD010 = False
        '' ------------------------------
        '' SQL実行文字列を生成する
        '' ------------------------------
        strSQL = "SELECT GOODSCD"
        strSQL = strSQL & " FROM TPD010"
        strSQL = strSQL & " WHERE SEATID='" & RSet(Request.QueryString("SEATID"), 5) & "'"
        strSQL = strSQL & " AND (GOODSCD='" & Trim$(Me.ViewState("OPEN_GOODSCD")) & "' OR GOODSCD='" & Trim$(Me.ViewState("REG_GOODSCD")) & "')"
        strSQL = strSQL & " ORDER BY ORDERNO DESC,GOODSCD DESC"
        '' ------------------------------
        '' 取得した先頭の商品がお通し商品(商品コード：9998)であれば、作成済であると判断する
        '' ------------------------------
        objData = New DataSet()

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Exit Function
        End If

        If Trim$(objRow("GOODSCD")) = Trim$(Me.ViewState("OPEN_GOODSCD")) Then
            CheckTPD010 = True
        End If
    End Function

    '' **************************************************
    ''  機能概要：お通し商品(商品コード：9998)がステーションに送信されたかを判断する。
    ''  引    数：
    ''  戻 り 値：True  ステーションには送信された。
    ''            False ステーションには未だ送信されていない。
    '' **************************************************
    Private Function CheckSTNsend() As Boolean
        Dim strSQL As String    '' SQL実行文字列
        Dim objData As DataSet  '' 取得した内容
        Dim objRow As DataRow = Nothing   '' 指定した位置の内容

        CheckSTNsend = False
        '' ------------------------------
        '' SQL実行文字列を生成する
        '' ------------------------------
        strSQL = "SELECT TRANSTIME"
        strSQL = strSQL & " FROM TPD010"
        strSQL = strSQL & " WHERE SEATID='" & RSet(Request.QueryString("SEATID"), 5) & "'"
        strSQL = strSQL & " AND GOODSCD='" & Trim$(Me.ViewState("OPEN_GOODSCD")) & "'"
        strSQL = strSQL & " ORDER BY ORDERNO DESC"
        '' ------------------------------
        '' 取得した先頭の商品がお通し商品(商品コード：9998)であれば、作成済であると判断する
        '' ------------------------------
        objData = New DataSet()

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Exit Function
        End If

        If CLng(objRow("TRANSTIME")) > 0 Then
            CheckSTNsend = True
        End If
    End Function

    Public Sub OnInitBody()
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        strSQL = ""
        strSQL = strSQL & "SELECT POSITION FROM TPM050"
        strSQL = strSQL & "       WHERE TERMKIND = 'TC9'"
        strSQL = strSQL & "         AND TERMID = '" & Trim$(Request.UserHostAddress) & "'"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG050(LF_CheckOrderStatus-1)")
            Exit Sub
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Sub
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG050(LF_CheckOrderStatus-2)")
            Exit Sub
        End If

        If Session("L_BtnBack") Then
            Response.Write("onLoad='parent.fWinClose();'")
        Else
            If L_BtnPrev Then
                Select Case objRow("POSITION").ToString
                    Case "20"
                        Response.Write("onLoad='fChgPage(" & Trim(Request.QueryString("SEATID")) & ", """ & Trim(Request.QueryString("MENUID")) & """, """ & Trim(Request.QueryString("COURSE")) & """, """ & Trim(Request.QueryString("GOODSCD")) & """);'")
                    Case "21"
                        Response.Write("onLoad='fChgPage2(" & Trim(Request.QueryString("SEATID")) & ", """ & Trim(Request.QueryString("MENUID")) & """, """ & Trim(Request.QueryString("COURSE")) & """, """ & Trim(Request.QueryString("GOODSCD")) & """);'")
                End Select
            End If
        End If
        ''201111
        'Response.Write("onLoad='fSetMessage(""" & Session("msg") & """);'")

    End Sub

    '' **************************************************
    ''  機能概要：座席番号に対する端末識別IDを取得する。
    ''  引    数：pINDEX    (I) 0から始まる項番
    ''            pTERMID   (O) 端末識別ID
    ''  戻 り 値：True  指定行の端末識別IDが取得できた。
    ''            False 指定行の端末識別IDは存在しないか、取得に失敗した。
    '' **************************************************
    Private Function LF_GetTermID(ByVal pINDEX As Long, ByRef pTERMID As String) As Boolean
        Dim strSQL As String        '' SQL実行文字列
        Dim objDataSet As DataSet   '' DataSetオブジェクト
        Dim objDataRow As DataRow = Nothing   '' DataRowオブジェクト

        LF_GetTermID = False

        strSQL = "SELECT TERMID"
        strSQL = strSQL & " FROM TPM050"
        strSQL = strSQL & " WHERE SEATID = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
        strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCA'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCB') "
        strSQL = strSQL & " ORDER BY TERMID"

        objDataSet = New DataSet()
        If Not L_Func.GF_GetData(strSQL, objDataSet) Then
            Response.Redirect("./TP2990.html?CNWG050(LF_GetTermID-1)")
            Exit Function
        End If

        If objDataSet.Tables("com").Rows.Count <= pINDEX Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objDataSet, pINDEX, objDataRow) Then
            Response.Redirect("./TP2990.html?CNWG050(LF_GetTermID-2)")
            Exit Function
        End If

        pTERMID = Trim$(objDataRow("TERMID"))
        LF_GetTermID = True
    End Function

    Private Function LF_GetMenuName() As String
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetMenuName = ""

        strSQL = ""
        If Request.QueryString("GOODSCD") = "0000" Then
            strSQL = strSQL & "SELECT TPM060.MENUNM"
            strSQL = strSQL & "  FROM TPM060"
            strSQL = strSQL & " WHERE TPM060.MENUID = '" & Request.QueryString("MENUID") & "'"
            strSQL = strSQL & " ORDER BY TPM060.MENUID DESC"
        Else
            strSQL = strSQL & "SELECT (SELECT TPM010.GOODSNMJ + TPM010.GOODSNMJ2 FROM TPM010 WHERE TPM010.GOODSCD = TPM180.GOODSCD) AS MENUNM"
            strSQL = strSQL & "  FROM TPM010, TPM180"
            strSQL = strSQL & " WHERE TPM180.GOODSCD = '" & Request.QueryString("GOODSCD") & "'"
            strSQL = strSQL & "   AND TPM180.DISPMENUID = '" & Request.QueryString("MENUID") & "'"
            strSQL = strSQL & "   AND TPM010.SELLFLG = '0'"
        End If

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG050(LF_GetMenuName-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG050(LF_GetMenuName-2)")
            Exit Function
        End If

        LF_GetMenuName = Trim$(objRow("MENUNM"))
    End Function

    Private Sub LS_ButtonProtect()
        'インナーフレーム表示時は各種ボタンプロテクト
        btn_0.Attributes("ONCLICK") = "return false"
        btn_1.Attributes("ONCLICK") = "return false"
        btn_2.Attributes("ONCLICK") = "return false"
        btn_3.Attributes("ONCLICK") = "return false"
        btn_4.Attributes("ONCLICK") = "return false"
        btn_5.Attributes("ONCLICK") = "return false"
        btn_6.Attributes("ONCLICK") = "return false"
        btn_7.Attributes("ONCLICK") = "return false"
        btn_8.Attributes("ONCLICK") = "return false"
        btn_9.Attributes("ONCLICK") = "return false"
        btn_cls.Attributes("ONCLICK") = "return false"
        'btn_Set.Attributes("ONCLICK") = "return false"
        'btn_back.Attributes("ONCLICK") = "return false"
    End Sub

    Private Sub LS_ButtonNotProtect()
        'インナーフレーム表示時は各種ボタン非プロテクト
        btn_0.Attributes("ONCLICK") = "return true"
        btn_1.Attributes("ONCLICK") = "return true"
        btn_2.Attributes("ONCLICK") = "return true"
        btn_3.Attributes("ONCLICK") = "return true"
        btn_4.Attributes("ONCLICK") = "return true"
        btn_5.Attributes("ONCLICK") = "return true"
        btn_6.Attributes("ONCLICK") = "return true"
        btn_7.Attributes("ONCLICK") = "return true"
        btn_8.Attributes("ONCLICK") = "return true"
        btn_9.Attributes("ONCLICK") = "return true"
        btn_cls.Attributes("ONCLICK") = "return true"
        'btn_Set.Attributes("ONCLICK") = "return true"
        'btn_back.Attributes("ONCLICK") = "parent.fWinClose();"
    End Sub

    Private Function LF_SetSQLTPD010_2(ByVal pTERMID As String, ByVal pORDERNO As Long, ByVal pCNT As String) As Object

        LF_SetSQLTPD010_2 = Nothing

        Dim strSQL As String
        Dim datNow As Date
        Dim KCPNO() As String = Nothing
        Dim lngCnt As Long
        Dim strSUBGOODSCD As String

        datNow = Now

        '飲み放題メニュー登録の場合はSUBMENUID取得
        strSUBGOODSCD = ""
        If pCNT = 1 Then
            strSUBGOODSCD = Request.QueryString("GOODSCD")
        ElseIf pCNT = 2 Then
            strSUBGOODSCD = LF_GetSubGoodsCD()
        End If

        If Len(strSUBGOODSCD) <> 0 And Len(Trim$(txt_number.Text)) <> 0 Then
            If strSUBGOODSCD <> "0000" And Trim$(txt_number.Text) <> 0 Then
                'TPD011(INSERT文)
                strSQL = ""
                strSQL = strSQL & "INSERT INTO TPD010 VALUES("
                strSQL = strSQL & "'" & RSet(Request.QueryString("SEATID"), 5) & "', "      '座席番号
                strSQL = strSQL & pORDERNO & ", "                                           'オーダー連番
                strSQL = strSQL & "'" & pTERMID & "', "                                     '端末識別ID
                strSQL = strSQL & "'" & strSUBGOODSCD & "', "                               '商品ID
                strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                      '商品選択日時
                strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                      '注文受付日時
                strSQL = strSQL & "0, "                                                     'ステーション配信日時
                strSQL = strSQL & Trim$(txt_number.Text) & ", "                             '数量
                strSQL = strSQL & "'00', "                                                  '指示ステータス位置１
                strSQL = strSQL & "'000', "                                                 'SCPｺｰﾄﾞ１
                strSQL = strSQL & "'0000', "                                                'SCPﾒﾆｭｰ１
                strSQL = strSQL & "0, "                                                     'SCP数量１
                strSQL = strSQL & "'00', "                                                  '指示ステータス位置２
                strSQL = strSQL & "'000', "                                                 'SCPｺｰﾄﾞ２
                strSQL = strSQL & "'0000', "                                                'SCPﾒﾆｭｰ２
                strSQL = strSQL & "0, "                                                     'SCP数量２
                strSQL = strSQL & "'00', "                                                  '指示ステータス位置３
                strSQL = strSQL & "'000', "                                                 'SCPｺｰﾄﾞ３
                strSQL = strSQL & "'0000', "                                                'SCPﾒﾆｭｰ３
                strSQL = strSQL & "0, "                                                     'SCP数量３
                strSQL = strSQL & "'00', "                                                  '指示ステータス位置４
                strSQL = strSQL & "'000', "                                                 'SCPｺｰﾄﾞ４
                strSQL = strSQL & "'0000', "                                                'SCPﾒﾆｭｰ４
                strSQL = strSQL & "0, "                                                     'SCP数量４
                strSQL = strSQL & "'0', "                                                   'オーダー種別
                strSQL = strSQL & "'1', "                                                   '商品分類
                strSQL = strSQL & "'00', "                                                  '注文フラグ
                strSQL = strSQL & "'" & Space(15) & "',"                                    '厨房端末識別ID
                strSQL = strSQL & "0, "                                                     'お通し人数
                strSQL = strSQL & "'CNWG001', "                                              '更新者
                strSQL = strSQL & "GETDATE())"                                              '更新日

                If Not L_Func.GF_BeginTrans Then
                    GoTo SYSTEM_ERROR
                End If

                If Not L_Func.GF_UpdData(strSQL) Then
                    Call L_Func.GF_RollbackTrans()
                    Exit Function
                End If

                If Not L_Func.GF_CommitTrans Then
                    Call L_Func.GF_RollbackTrans()
                    GoTo SYSTEM_ERROR
                End If

                If Not LF_GetKCPNO(strSUBGOODSCD, KCPNO) Then
                    Exit Function
                End If
                For lngCnt = 0 To KCPNO.Length - 1
                    'TPD011(INSERT文)
                    strSQL = ""
                    strSQL = strSQL & "INSERT INTO TPD011 VALUES("
                    strSQL = strSQL & "'" & RSet(Request.QueryString("SEATID"), 5) & "', "      '座席番号
                    strSQL = strSQL & pORDERNO & ", "                                           'オーダー連番
                    strSQL = strSQL & "'" & pTERMID & "', "                                     '端末識別ID
                    strSQL = strSQL & "'" & strSUBGOODSCD & "', "                               '商品ID
                    strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                      '商品選択日時
                    strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                      '注文受付日時
                    strSQL = strSQL & "0, "                                                     'ステーション配信日時
                    strSQL = strSQL & Trim$(txt_number.Text) & ", "                             '数量
                    strSQL = strSQL & "'00', "                                                  '指示ステータス位置１
                    strSQL = strSQL & "'000', "                                                 'SCPｺｰﾄﾞ１
                    strSQL = strSQL & "'0000', "                                                'SCPﾒﾆｭｰ１
                    strSQL = strSQL & "0, "                                                     'SCP数量１
                    strSQL = strSQL & "'00', "                                                  '指示ステータス位置２
                    strSQL = strSQL & "'000', "                                                 'SCPｺｰﾄﾞ２
                    strSQL = strSQL & "'0000', "                                                'SCPﾒﾆｭｰ２
                    strSQL = strSQL & "0, "                                                     'SCP数量２
                    strSQL = strSQL & "'00', "                                                  '指示ステータス位置３
                    strSQL = strSQL & "'000', "                                                 'SCPｺｰﾄﾞ３
                    strSQL = strSQL & "'0000', "                                                'SCPﾒﾆｭｰ３
                    strSQL = strSQL & "0, "                                                     'SCP数量３
                    strSQL = strSQL & "'00', "                                                  '指示ステータス位置４
                    strSQL = strSQL & "'000', "                                                 'SCPｺｰﾄﾞ４
                    strSQL = strSQL & "'0000', "                                                'SCPﾒﾆｭｰ４
                    strSQL = strSQL & "0, "                                                     'SCP数量４
                    strSQL = strSQL & "'0', "                                                   'オーダー種別
                    strSQL = strSQL & "'1', "                                                   '商品分類
                    strSQL = strSQL & "'00', "                                                  '注文フラグ
                    strSQL = strSQL & "'" & Space(15) & "',"                                    '厨房端末識別ID
                    strSQL = strSQL & "0, "                                                     'お通し人数
                    strSQL = strSQL & "'" & KCPNO(lngCnt) & "',"                                '出力先プリンタ
                    strSQL = strSQL & "'CNWG001', "                                              '更新者
                    strSQL = strSQL & "GETDATE())"                                              '更新日

                    If Not L_Func.GF_BeginTrans Then
                        GoTo SYSTEM_ERROR
                    End If

                    If Not L_Func.GF_UpdData(strSQL) Then
                        Call L_Func.GF_RollbackTrans()
                        Exit Function
                    End If

                    If Not L_Func.GF_CommitTrans Then
                        Call L_Func.GF_RollbackTrans()
                        GoTo SYSTEM_ERROR
                    End If
                Next
            End If
        End If

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG050(LF_SetSQLTPD010_2)")
        Exit Function
    End Function

    Private Function LF_GetSubGoodsCD() As String
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetSubGoodsCD = ""

        strSQL = ""
        strSQL = strSQL & "SELECT TPM180.GOODSCD,"                        '商品コード
        strSQL = strSQL & "       TPM180.DISPMENUID,"                     'タッチパネル表示メニュー
        strSQL = strSQL & "       TPM180.FREEDRINKMENUID,"                '飲み放題メニュー
        strSQL = strSQL & "       TPM170.SUB1GOODSCD,"                    'サブメニュー１商品コード
        strSQL = strSQL & "       TPM170.SUB1ENABLED,"                    'サブメニュー１有効フラグ
        strSQL = strSQL & "       TPM170.SUB2GOODSCD,"                    'サブメニュー２商品コード
        strSQL = strSQL & "       TPM170.SUB2ENABLED"                     'サブメニュー１有効フラグ
        strSQL = strSQL & "  FROM TPM170, TPM180"
        strSQL = strSQL & " WHERE TPM180.GOODSCD = '" & Request.QueryString("GOODSCD") & "'"
        strSQL = strSQL & "   AND TPM180.DISPMENUID = '" & Request.QueryString("MENUID") & "'"
        strSQL = strSQL & "   AND TPM170.MENUID = TPM180.FREEDRINKMENUID"
        strSQL = strSQL & "   AND TPM170.GROUPCD = '0000'"
        strSQL = strSQL & "   AND TPM170.ENABLED = '1'"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG050(LF_GetDrinkMenuID)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Exit Function
        End If

        If Trim$(objRow("SUB1ENABLED")) = "1" Then
            LF_GetSubGoodsCD = Trim$(objRow("SUB1GOODSCD"))
        ElseIf Trim$(objRow("SUB2ENABLED")) = "1" Then
            LF_GetSubGoodsCD = Trim$(objRow("SUB2GOODSCD"))
        Else
            '該当データなし
            LF_GetSubGoodsCD = ""
        End If
    End Function

    Private Function LF_GetKCPNO(ByVal pGOODSCD As String, ByRef pKCPNO() As String) As Boolean
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim strKCPSTATUS As String
        Dim lngCnt As Long
        Dim intI As Integer
        Dim intJ As Integer
        Dim intK As Integer
        Dim blnFound As Boolean

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetKCPNO = False
        blnFound = False

        strSQL = ""
        strSQL = strSQL & "SELECT KCPSTATUS"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " WHERE GOODSCD = '" & pGOODSCD & "'"

        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count > 0 Then
            If Not Session("TP").GF_GetRows(objData, 0, objRow) Then
                Exit Function
            End If
        End If
        strKCPSTATUS = objRow("KCPSTATUS")

        '------------------------------
        ' ＫＣＰステータス列生成
        '------------------------------
        Try
            intK = 0
            lngCnt = 1
            For intI = 1 To 4
                For intJ = 8 * intI To 8 * (intI - 1) + 1 Step -1
                    If Mid$(strKCPSTATUS, CInt(lngCnt), 1) = 1 Then
                        ReDim Preserve pKCPNO(intK)
                        pKCPNO(intK) = CStr(intJ)
                        intK = intK + 1
                    End If
                    lngCnt = lngCnt + 1
                Next
            Next
            If intK = 0 Then
                ReDim Preserve pKCPNO(intK)
                pKCPNO(intK) = "0"
            End If
        Catch
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetKCPNO = True
    End Function

End Class
