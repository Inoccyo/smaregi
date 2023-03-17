Partial Class CNWG030
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
    Private L_Iframe As String
    Private L_SelectTime As Long
    Private L_Onclick As String
    Private L_BtnBack As Boolean
    Private L_Setbtn As Boolean
    Private LC_ADD_NUMBER As Long = 800
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Private Const SessionMsgName As String = "CNWG001.Msg"

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' セッション状態確認
        '------------------------------
        If IsNothing(Session("TP")) Then
            L_Func = New TP2920()
            If Not L_Func.GF_Initialize() Then
                Response.Redirect("./TP2990.html?CNWG030(Page_Load-1)")
                Exit Sub
            End If
            Session("TP") = L_Func
        Else
            L_Func = Session("TP")
        End If

        Me.ViewState.Add( _
         "MENUIMG_PATH", _
         L_Func.GF_GetAppInfo("MENUIMG_PATH") _
        )
        Me.ViewState.Add( _
         "IMGSET", _
         L_Func.GF_GetImageSet() _
        )

        L_BtnBack = False

        ' お会計コード、お通しコードをTPM090から取得
        Me.ViewState("REG_GOODSCD") = L_Func.GF_GetAppInfo("REG_GOODSCD")       'お会計
        Me.ViewState("OPEN_GOODSCD") = L_Func.GF_GetAppInfo("OPEN_GOODSCD")     'お通し

        '------------------------------
        ' ポストバック時は処理対象外
        '------------------------------
        If IsPostBack Then
            Exit Sub
        End If

        Session("SEATID") = Request.QueryString("SEATID")

        Session(SessionMsgName) = ""

        'btn_back.Attributes.Add("ONCLICK", "parent.fWinClose();")
        btn_Set.Attributes.Add("ONCLICK", "FFrame();")

        Session(SessionMsgName) = ""
        txt_Seat.Text = Request.QueryString("SEATID") & "番席"

        '------------------------------
        ' 遷移ﾊﾟﾗﾒﾀにより表示項目設定
        '------------------------------
        Call LF_SetForm()

        'お会計ボタンクリック時
        If Trim$(Request.QueryString("SUBMITID")) = "btn_Set" Then
            LS_SetClick()
        ElseIf Trim$(Request.QueryString("SUBMITID")) = "btn_minus" Then
            LF_MinusAction()
        End If
    End Sub

    Private Function LF_SetForm(Optional ByVal pNext As Boolean = False) As Object

        LF_SetForm = Nothing

        '座席移動機能追加
        If L_Func.GF_GetAppInfo("TABLECHG_FLG") = "0" Then
            btn_TblChg.Visible = False
        End If

        If Trim$(LF_GetOrderStatus) <> "2" Then

            'コース名表示　2013.10.29
            Call LS_CMENU()

            If Request.QueryString("BTN_STATUS") = "1" Then
                lbl_disp.Text = "コース終了" & Request.QueryString("AlertMin") & "分前です"
                txt_number.Visible = False
                txt_unit.Visible = False
                btn_Set.Visible = False
                btn_minus.Text = "閉じる"
                btn_back.Visible = False
                Exit Function
            ElseIf Request.QueryString("BTN_STATUS") = "2" Then
                lbl_disp.Text = L_Func.GF_GetAppInfo("FREE_MENU_NM") & "時間終了です。<BR>標準メニューに切り替えます。"
                txt_number.Visible = False
                txt_unit.Visible = False
                btn_Set.Text = "はい"
                btn_minus.Visible = False
                btn_back.Text = "いいえ"
                Exit Function
            Else
                lbl_disp.Visible = False
            End If

            'お通し済み
            txt_number.Visible = False
            txt_unit.Visible = False
            btn_Set.Text = "お会計"
            '商品が注文されている場合はボタン表示
            ' コメント解除
            If LF_GetPrice() <> "0" Then
                btn_minus.Visible = True
                If L_Func.GF_GetAppInfo("TPG_FLG") = "1" Then
                    btn_minus.Visible = False
                End If
            Else
                btn_minus.Visible = False
            End If
            '座席移動機能追加
            If L_Func.GF_GetAppInfo("TABLECHG_FLG") = "0" Then
                btn_TblChg.Visible = True
            Else
                btn_TblChg.Visible = False
            End If

        Else
            '空席

            If Trim$(Request.QueryString("YOBI")) = "TRUE" Then
                If pNext = False Then
                    ' 相席設定（１／２）
                    lbl_disp.Visible = False
                    btn_Set.Text = "次へ"
                    txt_unit.Visible = True
                    txt_unit.Text = "番"
                Else
                    ' 相席設定（２／２）
                    lbl_disp.Visible = False
                    btn_Set.Text = "お通し"
                    txt_unit.Visible = True
                    txt_unit.Text = "人"
                    txt_Seat.Text = Me.ViewState.Item("SEATNO") & "番席"
                End If
            Else
                lbl_disp.Visible = False
                btn_Set.Text = "お通し"
            End If

        End If

    End Function

    Private Function LF_GetPrice() As Long

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim strTERMID As String = Nothing       '端末識別ID

        LF_GetPrice = 0

        If Not LF_GetTermID(0, strTERMID) Then
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "SELECT ISNULL(SUM(TPM.PRICE * TPD.QUANTITY),0) AS TOTALPRICE"
        strSQL = strSQL & "  FROM TPM010 AS TPM, TPD010 AS TPD"
        ' 合計金額抽出方法変更対応
        strSQL = strSQL & " WHERE  TPD.TERMID = '" & strTERMID & "'"
        strSQL = strSQL & "   AND  TPM.GOODSCD = TPD.GOODSCD"
        strSQL = strSQL & "   AND  TPD.SELECTTIME <> 0"
        strSQL = strSQL & "   AND  TPD.ORDERTIME <> 0"
        strSQL = strSQL & "   AND (TPD.ORDERFLG = '" & Session("TP").GC_ORDER_SELECT & "'"
        strSQL = strSQL & "    OR  TPD.ORDERFLG = '" & Session("TP").GC_ORDER_SELECT_1 & "')"
        strSQL = strSQL & "   AND  TPD.ORDERNO = " & LF_GetOrderNo()

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG030(LF_GetPrice_1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG030(LF_GetPrice_2)")
            Exit Function
        End If

        LF_GetPrice = CLng(Trim$(objRow("TOTALPRICE")))

    End Function

    Private Function LF_GetTimeNumber() As String

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetTimeNumber = ""

        strSQL = ""
        strSQL = strSQL & "SELECT SELECTTIME, PERSONNUMBER"
        strSQL = strSQL & "  FROM TPD010"
        strSQL = strSQL & " WHERE SEATID = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
        ' お通しコードをTPM090から取得
        strSQL = strSQL & "   AND GOODSCD = '" & Trim$(Me.ViewState("OPEN_GOODSCD")) & "'"
        strSQL = strSQL & " ORDER BY SELECTTIME DESC"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG030(LF_GetTimeNumber_1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG030(LF_GetTime-Number_2)")
            Exit Function
        End If

        L_SelectTime = CLng(Trim$(objRow("SELECTTIME")))
        LF_GetTimeNumber = objRow("PERSONNUMBER") & "人 " & _
                           Mid(CStr(Trim$(objRow("SELECTTIME"))), 9, 2) & ":" & Mid(CStr(Trim$(objRow("SELECTTIME"))), 11, 2)

    End Function

    Private Function LF_GetOrderStatus() As String

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetOrderStatus = ""

        strSQL = ""
        strSQL = strSQL & "SELECT ORDERSTATUS"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE SEATID = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
        strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCA' "
        strSQL = strSQL & "   OR    TERMKIND = 'TCB' )"
        strSQL = strSQL & " ORDER BY ORDERSTATUS"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG030(LF_GetOrderStatus_1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG030(LF_GetOrderStatus_2)")
            Exit Function
        End If

        LF_GetOrderStatus = Trim$(objRow("ORDERSTATUS"))
        Me.ViewState("ORDERSTATUS") = LF_GetOrderStatus

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG030(LF_GetOrderStatus)")
        Exit Function
    End Function

    ''' <summary>
    ''' お会計ボタン処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LS_SetClick()

        L_BtnBack = True

        Dim lngSeatNo As Long
        Dim blnExt As Boolean

        'コース終了メッセージ確認時、メニュコードを消して終了
        If Request.QueryString("BTN_STATUS") = "2" Then
            Call LF_UpdTPM050_3()
            L_BtnBack = True
            Exit Sub
        End If

        If Trim$(Request.QueryString("YOBI")) = "TRUE" And _
           Trim$(Me.ViewState.Item("ORDERSTATUS")) = "2" Then
            If Len(Trim$(Me.ViewState.Item("SEATNO"))) = 0 Then
                ' 入力チェック
                If Len(Trim$(txt_number.Text)) = 0 Then
                    Session(SessionMsgName) = "座席番号を設定して下さい"
                    Exit Sub
                End If
                If CLng(txt_number.Text) < 1 Then
                    Session(SessionMsgName) = "座席番号を設定して下さい"
                    Exit Sub
                End If

                ' 存在しない座席番号はエラーとする
                Call LF_ChkExtSeat(Trim$(txt_number.Text), blnExt)
                If blnExt = False Then
                    Session(SessionMsgName) = "存在しない座席番号です"
                    Exit Sub
                End If

                ' 上桁に、特定の文字又は数値を付加する
                lngSeatNo = CLng(Trim$(txt_number.Text)) + LC_ADD_NUMBER

                ' 既に相席済みのものはエラーとする
                Call LF_ChkExtSeat_2(CStr(lngSeatNo), blnExt)
                If blnExt Then
                    Session(SessionMsgName) = "既に相席設定されています"
                    Exit Sub
                End If

                Session(SessionMsgName) = ""

                Me.ViewState.Add("SEATNO", CStr(lngSeatNo))
                txt_number.Text = ""
                Call LF_SetForm(True)
                Exit Sub
            End If
        End If

        Dim i As Integer        '' 繰返しカウンタ
        Dim strTERMID As String = Nothing '' 端末識別ID
        Dim lngORDERNO As Long  '' オーダー連番

        If Me.ViewState("ORDERSTATUS") = "2" Then
            'お通し処理の場合、人数未入力はだめ
            If Trim$(txt_number.Text) = "" Then
                Session(SessionMsgName) = "人数を設定して下さい。"
                Exit Sub
            End If

            'お通し処理の場合、人数がゼロはだめ
            If CInt(Trim$(txt_number.Text)) = 0 Then
                Session(SessionMsgName) = "人数を設定して下さい。"
                Exit Sub
            End If
        End If

        ' 予備端末レコードの座席番号を、相席端末として座席番号を変更する
        If Trim$(Request.QueryString("YOBI")) = "TRUE" And _
           Me.ViewState("ORDERSTATUS") = "2" Then
            If Not LF_UpdTPM050_1() Then
                Response.Redirect("./TP2990.html?CNWG030(btn_true_Click_1)")
                Exit Sub
            End If
        End If

        'オーダー状況テーブル登録（TPD010）
        If Me.ViewState("ORDERSTATUS") <> "2" Then
            lngORDERNO = LF_GetOrderNo()
            For i = 0 To 10
                If Not LF_GetTermID(i, strTERMID) Then
                    Exit For
                End If
                Call LF_SetSQLTPD010(strTERMID, lngORDERNO)
            Next i
        Else
            If Trim$(Request.QueryString("YOBI")) = "TRUE" Then
                If Not CheckTPD010(Me.ViewState.Item("SEATNO")) Then
                    lngORDERNO = LF_GetOrderNo(Me.ViewState.Item("SEATNO")) + 1
                    For i = 0 To 10
                        If Not LF_GetTermID(i, strTERMID, Me.ViewState.Item("SEATNO")) Then
                            Exit For
                        End If
                        Call LF_SetSQLTPD010(strTERMID, lngORDERNO, Me.ViewState.Item("SEATNO"))
                    Next
                End If
            Else
                If Not CheckTPD010(Request.QueryString("SEATID")) Then
                    lngORDERNO = LF_GetOrderNo() + 1
                    For i = 0 To 10
                        If Not LF_GetTermID(i, strTERMID) Then
                            Exit For
                        End If
                        Call LF_SetSQLTPD010(strTERMID, lngORDERNO)
                    Next
                End If
            End If
        End If

        'お会計の時、TRANSTIMEがゼロのデータを更新
        If Me.ViewState("ORDERSTATUS") <> "2" Then
            If Trim$(Request.QueryString("YOBI")) = "TRUE" Then
                Call LF_SetTransTime(Me.ViewState.Item("SEATNO"))
            Else
                Call LF_SetTransTime()
            End If
        End If

        ' お通しの時、顧客ファイルが作成されたかどうかを確認する。
        Dim intSTN_TIMER As Integer
        intSTN_TIMER = Session("TP").GF_GetAppInfo("STN_TIMER")

        If Me.ViewState("ORDERSTATUS") = "2" Then
            For i = 0 To intSTN_TIMER

                If CheckSTNsend(IIf(Trim$(Request.QueryString("YOBI")) = "TRUE", Me.ViewState.Item("SEATNO"), "")) Then
                    Exit For
                End If

                If i <> intSTN_TIMER Then
                    Sleep(1000)
                Else
                    Session(SessionMsgName) = "お会計を済ませてください。"

                    ' 相席端末レコードの座席番号を、予備端末として元の座席番号に変更する
                    If Trim$(Request.QueryString("YOBI")) = "TRUE" Then
                        If Not LF_UpdTPM050_2(RSet(Me.ViewState.Item("SEATNO"), 5)) Then
                            Response.Redirect("./TP2990.html?CNWG030(btn_true_Click_3)")
                            Exit Sub
                        End If
                    End If

                    Exit Sub
                End If
            Next i
        End If

        '座席番号管理マスタ更新（TPM050）
        Call LF_SetSQLTPM050(IIf(Trim$(Request.QueryString("YOBI")) = "TRUE", Me.ViewState.Item("SEATNO"), ""))

        '座席拡張テーブル更新（TPD050）食べ飲み放題対応
        Call LF_SetSQLTPD050(IIf(Trim$(Request.QueryString("YOBI")) = "TRUE", Me.ViewState.Item("SEATNO"), ""))

        If Me.ViewState("ORDERSTATUS") <> "2" Then
            'お会計処理
            Session(SessionMsgName) = "【" & Request.QueryString("SEATID") & "番席】" & "お会計を受付ました。"
            If L_Func.GF_GetAppInfo("SEAT_DISTRIBUTION") = "0" Then
                Call LF_Seatcancel(Request.QueryString("SEATID"))
            End If

            ' 相席端末レコードの座席番号を、予備端末として座席番号を変更する
            If Trim$(Request.QueryString("YOBI")) = "TRUE" Then
                If Not LF_UpdTPM050_2(Request.QueryString("SEATID")) Then
                    Response.Redirect("./TP2990.html?CNWG030(btn_true_Click_2)")
                    Exit Sub
                End If
            End If

        Else
            'お通し処理
            Session(SessionMsgName) = "【" & Request.QueryString("SEATID") & "番席】" & "お通しを受付ました。"
        End If

        ' 2016.09.27 ｸﾚｽｺ北陸 田代
        If L_Func.GF_GetAppInfo3("SOBA_FLG") = "1" Then
            Call LF_SetSQLTPD010_C(Request.QueryString("SEATID"))
        End If
        ' 2016.09.27 ｸﾚｽｺ北陸 田代

        btn_Set.Enabled = False
    End Sub

    Private Function LF_SetTransTime(Optional ByVal pSeatID As String = "") As Object

        LF_SetTransTime = Nothing

        Dim strSQL As String
        'レシート再印字　2014.1.16
        Dim objData As DataSet
        Dim objRow As DataRow = Nothing
        Dim UpdFlg As String
        Dim strTERMID As String = ""

        '------------------------------
        ' スマレジ連携
        '------------------------------
        If Session("TP").GF_GetAppInfo("SMAREGI_FLG") = "1" Then
            'スマレジ連携有り
            If Not LF_GetTermID(0, strTERMID) Then
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPD052("
            strSQL = strSQL & "       TRANID"
            strSQL = strSQL & "     , TRANKBN"
            strSQL = strSQL & "     , SEATID"
            strSQL = strSQL & "     , ORDERNO"
            strSQL = strSQL & "     , TERMID"
            strSQL = strSQL & "     , GOODSCD"
            strSQL = strSQL & "     , SELECTTIME"
            strSQL = strSQL & "     , ORDERTIME"
            strSQL = strSQL & "     , TRANSTIME"
            strSQL = strSQL & "     , QUANTITY"
            strSQL = strSQL & "     , ORDERKIND"
            strSQL = strSQL & "     , GOODSKIND"
            strSQL = strSQL & "     , ORDERFLG"
            strSQL = strSQL & "     , PERSONNUMBER"
            strSQL = strSQL & "     , TAXKIND"
            strSQL = strSQL & "     , UPDID"
            strSQL = strSQL & "     , UPDYMD"
            strSQL = strSQL & ")"
            strSQL = strSQL & "SELECT '" & GetMaxTranNo() & "'"
            strSQL = strSQL & "     , '0'"
            strSQL = strSQL & "     , TPD010.SEATID"
            strSQL = strSQL & "     , TPD010.ORDERNO"
            strSQL = strSQL & "     , TPD010.TERMID"
            strSQL = strSQL & "     , TPD010.GOODSCD"
            strSQL = strSQL & "     , TPD010.SELECTTIME"
            strSQL = strSQL & "     , TPD010.ORDERTIME"
            strSQL = strSQL & "     , TPD010.TRANSTIME"
            strSQL = strSQL & "     , TPD010.QUANTITY"
            strSQL = strSQL & "     , TPD010.ORDERKIND"
            strSQL = strSQL & "     , TPD010.GOODSKIND"
            strSQL = strSQL & "     , TPD010.ORDERFLG"
            strSQL = strSQL & "     , TPD010.PERSONNUMBER"
            strSQL = strSQL & "     , ISNULL(TPM320.TAXKIND, 0) AS TAXKIND"
            strSQL = strSQL & "     , 'SYSTEM'"
            strSQL = strSQL & "     , '" & Now() & "'"
            strSQL = strSQL & "  FROM TPD010 LEFT JOIN TPM320 ON TPD010.GOODSCD = TPM320.GOODSCD"
            strSQL = strSQL & " WHERE SEATID    = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
            strSQL = strSQL & "   AND ORDERNO   = " & LF_GetOrderNo()
            strSQL = strSQL & "   AND TERMID    = '" & Session("TP").GF_GetVirtualTermID(strTERMID) & "'"
            strSQL = strSQL & "   AND SELECTTIME <> 0"
            strSQL = strSQL & "   AND ORDERTIME  <> 0"
            strSQL = strSQL & "   AND TRANSTIME  <> 0"
            strSQL = strSQL & "   AND ORDERFLG IN ('" & Session("TP").GC_ORDER_SELECT & "', '" & Session("TP").GC_ORDER_SELECT_1 & "', '" & Session("TP").GC_ORDER_MINUS & "')"

            'トランザクション処理
            If Not Session("TP").GF_BeginTrans Then
                Exit Function
            End If

            '更新処理
            If Not Session("TP").GF_UpdData(strSQL) Then
                Call Session("TP").GF_RollbackTrans()
                Exit Function
            End If

            'コミット処理
            If Not Session("TP").GF_CommitTrans Then
                Call Session("TP").GF_RollbackTrans()
                Exit Function
            End If

        Else
            'スマレジ連携無し
            '何もしない
        End If

        'TPD050.M8に設定されたレシート印字フラグを取得
        strSQL = ""
        strSQL = strSQL & "SELECT M8"
        strSQL = strSQL & "  FROM TPD050"
        strSQL = strSQL & " WHERE TPD050.SEATID   = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
        strSQL = strSQL & "   AND TPD050.TERMKIND IN ('TC0', 'TCA', 'TCB')"

        objData = New DataSet()
        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not Session("TP").GF_GetRows(objData, 0, objRow) Then
            Exit Function
        End If

        UpdFlg = Trim$(objRow("M8"))

        strSQL = ""
        strSQL = strSQL & "UPDATE TPD010"
        strSQL = strSQL & "   SET ORDERFLG  = '" & Session("TP").GC_ORDER_HISTDEL & "'"

        If Len(Trim$(pSeatID)) = 0 Then
            strSQL = strSQL & " WHERE SEATID    = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
        Else
            strSQL = strSQL & " WHERE SEATID    = '" & RSet(pSeatID, 5) & "'"
        End If

        strSQL = strSQL & "   AND(ORDERTIME = 0"
        strSQL = strSQL & "    OR TRANSTIME = 0)"
        strSQL = strSQL & "   AND(ORDERFLG  = '00' OR ORDERFLG  = '01' OR ORDERFLG  = '40')"
        strSQL = strSQL & "   AND ORDERNO   = " & LF_GetOrderNo()

        ' エラー時、処理続行
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

        'レシート印字対象時は、ORDERFLGの更新を行わない
        If Session("TP").GF_GetAppInfo("RECEIPT_PRINTING") = 1 Or (Session("TP").GF_GetAppInfo("RECEIPT_PRINTING") = 0 And UpdFlg = "0") Or Session("TP").GF_GetAppInfo("PRICE_TYPE") = "1" Then

            strSQL = ""
            strSQL = strSQL & "UPDATE TPD010"
            strSQL = strSQL & "   SET ORDERFLG  = '" & Session("TP").GC_ORDER_KAIKEI & "'"
            If Len(Trim$(pSeatID)) = 0 Then
                strSQL = strSQL & " WHERE SEATID    = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
            Else
                strSQL = strSQL & " WHERE SEATID    = '" & RSet(pSeatID, 5) & "'"
            End If

            strSQL = strSQL & "   AND(ORDERFLG  = '00' OR ORDERFLG  = '01' OR ORDERFLG  = '40')"
            strSQL = strSQL & "   AND ORDERNO   = " & LF_GetOrderNo()

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
        End If

        'TPD011(UPDATE文)
        strSQL = ""
        strSQL = strSQL & "UPDATE TPD011"
        strSQL = strSQL & "   SET ORDERFLG  = '" & Session("TP").GC_ORDER_HISTDEL & "'"
        If Len(Trim$(pSeatID)) = 0 Then
            strSQL = strSQL & " WHERE SEATID    = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
        Else
            strSQL = strSQL & " WHERE SEATID    = '" & RSet(pSeatID, 5) & "'"
        End If
        strSQL = strSQL & "   AND(ORDERTIME = 0"
        strSQL = strSQL & "    OR TRANSTIME = 0)"
        strSQL = strSQL & "   AND(ORDERFLG  = '00' OR ORDERFLG  = '01' OR ORDERFLG  = '40')"
        strSQL = strSQL & "   AND ORDERNO   = " & LF_GetOrderNo()
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

        strSQL = ""
        strSQL = strSQL & "UPDATE TPD011"
        strSQL = strSQL & "   SET ORDERFLG  = '" & Session("TP").GC_ORDER_KAIKEI & "'"
        If Len(Trim$(pSeatID)) = 0 Then
            strSQL = strSQL & " WHERE SEATID    = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
        Else
            strSQL = strSQL & " WHERE SEATID    = '" & RSet(pSeatID, 5) & "'"
        End If
        strSQL = strSQL & "   AND(ORDERFLG  = '00' OR ORDERFLG  = '01' OR ORDERFLG  = '40')"
        strSQL = strSQL & "   AND ORDERNO   = " & LF_GetOrderNo()
        If Not L_Func.GF_BeginTrans Then
            GoTo SYSTEM_ERROR
        End If

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Function
        End If

        ' UPDATE文発行(TPD050)
        strSQL = ""
        strSQL = strSQL & "UPDATE TPD050"
        strSQL = strSQL & "   SET D1 = '0', D3 = '0', D4 = '0'"
        If Len(Trim$(pSeatID)) = 0 Then
            strSQL = strSQL & " WHERE SEATID    = '" & RSet(Session("SEATID"), 5) & "'"
        Else
            strSQL = strSQL & " WHERE SEATID    = '" & RSet(pSeatID, 5) & "'"
        End If
        strSQL = strSQL & "   AND TERMKIND IN ('TC0', 'TCA', 'TCB')"

        If Not Session("TP").GF_UpdData(strSQL) Then
            Call Session("TP").GF_RollbackTrans()
            Exit Function
        End If

        ' UPDATE文発行(TPD051)
        strSQL = ""
        strSQL = strSQL & "UPDATE TPD051"
        strSQL = strSQL & " SET D1 = '0', "
        strSQL = strSQL & "     D2 = '0', "
        strSQL = strSQL & "     D3 = '0', "
        strSQL = strSQL & "     D4 = '0', "
        strSQL = strSQL & "     D5 = '0', "
        strSQL = strSQL & "     D6 = '0', "
        strSQL = strSQL & "     D7 = '0', "
        strSQL = strSQL & "     D8 = '0', "
        strSQL = strSQL & "     D9 = '0', "
        strSQL = strSQL & "     D10 = '0', "
        strSQL = strSQL & "     D11 = '0', "
        strSQL = strSQL & "     D12 = '0', "
        strSQL = strSQL & "     D13 = '0', "
        strSQL = strSQL & "     D14 = '0', "
        strSQL = strSQL & "     D15 = '0', "
        strSQL = strSQL & "     D16 = '0', "
        strSQL = strSQL & "     D17 = '0', "
        strSQL = strSQL & "     D18 = '0', "
        strSQL = strSQL & "     D19 = '0', "
        strSQL = strSQL & "     D20 = '0', "
        strSQL = strSQL & "     D21 = '0', "
        strSQL = strSQL & "     D22 = '0', "
        strSQL = strSQL & "     D23 = '0', "
        strSQL = strSQL & "     D24 = '0', "
        strSQL = strSQL & "     D25 = '0', "
        strSQL = strSQL & "     D26 = '0', "
        strSQL = strSQL & "     D27 = '0', "
        strSQL = strSQL & "     D28 = '0', "
        strSQL = strSQL & "     D29 = '0', "
        strSQL = strSQL & "     D30 = '0', "
        strSQL = strSQL & "  UPDID  = 'CNWH150',"    '更新者
        strSQL = strSQL & "  UPDYMD = GETDATE()"     '更新日
        If Len(Trim$(pSeatID)) = 0 Then
            strSQL = strSQL & " WHERE SEATID    = '" & RSet(Session("SEATID"), 5) & "'"
        Else
            strSQL = strSQL & " WHERE SEATID    = '" & RSet(pSeatID, 5) & "'"
        End If
        strSQL = strSQL & "   AND TERMKIND IN ('TC0', 'TCA', 'TCB')"

        If Not Session("TP").GF_UpdData(strSQL) Then
            Call Session("TP").GF_RollbackTrans()
            Exit Function
        End If

        If Session("TP").GF_GetAppInfo2("CNWH_GAMEFLG") = "1" Then

            '当たりデータ出力先設定
            Select Case CStr(Session("TP").GF_GetAppInfo2("CNWH_GAMEOUTPUT"))
                Case "0"    'ガチャ出力の場合
                    ' UPDATE文発行(TPD510)
                    strSQL = ""
                    strSQL = strSQL & "UPDATE TPD510"
                    strSQL = strSQL & "   SET TRANSTIME = '" & Format$(Now, "yyyyMMddHHmmss") & "'"
                    If Len(Trim$(pSeatID)) = 0 Then
                        strSQL = strSQL & " WHERE SEATID    = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
                    Else
                        strSQL = strSQL & " WHERE SEATID    = '" & RSet(pSeatID, 5) & "'"
                    End If
                    strSQL = strSQL & "   AND TRANSTIME = '0'"

                    If Not Session("TP").GF_UpdData(strSQL) Then
                        Call Session("TP").GF_RollbackTrans()
                        Exit Function
                    End If

                Case "1"    'パネル・KCP出力の場合

                Case Else   'その他の場合
                    Exit Function

            End Select

        End If

        If Not L_Func.GF_CommitTrans Then
            Call L_Func.GF_RollbackTrans()
            GoTo SYSTEM_ERROR
        End If

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG030(LF_SetTransTime)")
        Exit Function
    End Function

    Private Function LF_SetSQLTPD010(ByVal pTERMID As String, ByVal pORDERNO As Long, Optional ByVal pSeatID As String = "") As Object

        LF_SetSQLTPD010 = Nothing

        Dim strSQL As String
        Dim datNow As Date

        datNow = Now

        If Not L_Func.GF_BeginTrans Then
            GoTo SYSTEM_ERROR
        End If

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPD010 VALUES("

        If Len(Trim$(pSeatID)) = 0 Then
            strSQL = strSQL & "'" & RSet(Request.QueryString("SEATID"), 5) & "', "                  '座席番号
        Else
            strSQL = strSQL & "'" & RSet(pSeatID, 5) & "', "
        End If

        If Me.ViewState("ORDERSTATUS") <> "2" Then                                       'オーダー連番
            strSQL = strSQL & pORDERNO & ", "
        Else
            'お通し処理
            strSQL = strSQL & pORDERNO & ", "
        End If
        strSQL = strSQL & "'" & pTERMID & "', "                                         '端末識別ID
        If Me.ViewState("ORDERSTATUS") <> "2" Then                                       '商品ID
            'お会計処理
            strSQL = strSQL & "'" & Trim$(Me.ViewState("REG_GOODSCD")) & "', "          'コードをTPM090から取得
        Else
            'お通し処理
            strSQL = strSQL & "'" & Trim$(Me.ViewState("OPEN_GOODSCD")) & "', "         'コードをTPM090から取得
        End If
        strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","
        If Me.ViewState("ORDERSTATUS") <> "2" Then
            'お会計処理
            strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","
            strSQL = strSQL & "0,"                                                       ' お会計処理時、配信日時を設定しない
        Else
            'お通し処理
            strSQL = strSQL & "0, "                                                     '注文受付日時
            strSQL = strSQL & "0, "                                                     'ステーション配信日時
            strSQL = strSQL & "0, "                                                     'ステーション配信日時2
            strSQL = strSQL & "0, "                                                     'ステーション配信日時3
        End If
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
        If Me.ViewState("ORDERSTATUS") <> "2" Then                                       'お通し人数
            'お会計処理
            strSQL = strSQL & "0, "
        Else
            'お通し処理
            strSQL = strSQL & CLng(Trim$(txt_number.Text)) & ", "
        End If
        strSQL = strSQL & "'CNWG001', "                                                    '更新者
        strSQL = strSQL & "GETDATE())"                                                    '更新日

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Function
        End If

        'TPD011(INSERT文)
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPD011 VALUES("
        strSQL = strSQL & "'" & RSet(Request.QueryString("SEATID"), 5) & "', "          '座席番号
        If Me.ViewState("ORDERSTATUS") <> "2" Then                                       'オーダー連番
            'お会計処理
            strSQL = strSQL & pORDERNO & ", "
        Else
            'お通し処理
            strSQL = strSQL & pORDERNO & ", "
        End If
        strSQL = strSQL & "'" & pTERMID & "', "                                         '端末識別ID
        If Me.ViewState("ORDERSTATUS") <> "2" Then                                       '商品ID
            'お会計処理
            strSQL = strSQL & "'" & Trim$(Me.ViewState("REG_GOODSCD")) & "', "          'コードをTPM090から取得
        Else
            'お通し処理
            strSQL = strSQL & "'" & Trim$(Me.ViewState("OPEN_GOODSCD")) & "', "         'コードをTPM090から取得
        End If
        strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                          '商品選択日時
        If Me.ViewState("ORDERSTATUS") <> "2" Then
            'お会計処理
            strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                      '注文受付日時
            strSQL = strSQL & "0,"                                                      'ステーション配信日時
        Else
            'お通し処理
            strSQL = strSQL & "0, "                                                     '注文受付日時
            strSQL = strSQL & "0, "                                                     'ステーション配信日時
        End If
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
        If Me.ViewState("ORDERSTATUS") <> "2" Then                                       'お通し人数
            'お会計処理
            strSQL = strSQL & "0, "
        Else
            'お通し処理
            strSQL = strSQL & CLng(Trim$(txt_number.Text)) & ", "
        End If
        strSQL = strSQL & "'0', "                                                       '出力先プリンタ
        strSQL = strSQL & "'CNWG001', "                                                  '更新者
        strSQL = strSQL & "GETDATE())"                                                  '更新日

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
        Response.Redirect("./TP2990.html?CNWG030(LF_SetSQLTPD010)")
        Exit Function
    End Function

    Private Function LF_SetSQLTPM050(Optional ByVal pSeatID As String = "") As Object

        LF_SetSQLTPM050 = Nothing

        Dim strSQL As String

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050"
        If Me.ViewState("ORDERSTATUS") <> "2" Then
            'お会計処理（空席状態に更新）
            ' 2016.09.27 ｸﾚｽｺ北陸 田代
            If L_Func.GF_GetAppInfo3("SOBA_FLG") = "1" Then
                strSQL = strSQL & " SET ORDERSTATUS = '1',"     'お通し状態
            ElseIf L_Func.GF_GetAppInfo("SET_FLG") = "1" Then
                strSQL = strSQL & " SET ORDERSTATUS = '5',"     'セット状態
            Else
                strSQL = strSQL & " SET ORDERSTATUS = '2',"     '空席状態
            End If
            'If L_Func.GF_GetAppInfo("SET_FLG") = "1" Then
            '    strSQL = strSQL & " SET ORDERSTATUS = '5',"     'セット状態
            'Else
            '    strSQL = strSQL & " SET ORDERSTATUS = '2',"     '空席状態
            'End If
            ' 2016.09.27 ｸﾚｽｺ北陸 田代
            '端末状態フラグ
            strSQL = strSQL & "     SPMENU      = '000',"                                    '指定メニューＩＤ 複数箇所出し機能対応
            strSQL = strSQL & "     SPMENU2     = '000',"                                    '指定メニューＩＤ メニュー切替機能対応
            strSQL = strSQL & "     HISTORYFLG  = '0',"                                      'ヒストリーフラグ マイナス伝票画面起動時は注文履歴参照不可能とする
        Else
            'お通し処理（お通し状態に更新）
            strSQL = strSQL & " SET ORDERSTATUS = '1',"                                      '端末状態フラグ
            strSQL = strSQL & "     SPMENU      = '" & Request.QueryString("MENUID") & "',"  '指定メニューＩＤ 複数箇所出し機能対応
        End If
        strSQL = strSQL & "  UPDID  = 'CNWG001',"                                             '更新者
        strSQL = strSQL & "  UPDYMD = GETDATE()"                                             '更新日

        If Len(Trim$(pSeatID)) = 0 Then
            strSQL = strSQL & " WHERE SEATID = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
        Else
            strSQL = strSQL & " WHERE SEATID = '" & RSet(pSeatID, 5) & "'"
        End If

        strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCA' "
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
        Response.Redirect("./TP2990.html?CNWG030(LF_SetSQLTPM050)")
        Exit Function
    End Function

    ''' <summary>
    ''' 食べ飲み放題対応 閉局時に座席拡張テーブル初期化
    ''' </summary>
    ''' <param name="pSeatID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_SetSQLTPD050(Optional ByVal pSeatID As String = "") As Object

        LF_SetSQLTPD050 = Nothing

        Dim strSQL As String

        strSQL = ""
        strSQL = strSQL & "UPDATE TPD050"
        strSQL = strSQL & " SET D6 = '0', "
        strSQL = strSQL & "     D7 = '0', "
        strSQL = strSQL & "     D8 = '0', "
        strSQL = strSQL & "  UPDID  = 'CNWT401',"    '更新者
        strSQL = strSQL & "  UPDYMD = GETDATE()"     '更新日
        If Len(Trim$(pSeatID)) = 0 Then
            strSQL = strSQL & " WHERE SEATID = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
        Else
            strSQL = strSQL & " WHERE SEATID = '" & RSet(pSeatID, 5) & "'"
        End If

        strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCA' "
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
        Response.Redirect("./TP2990.html?CNWT401(LF_SetSQLTPD050)")
        Exit Function
    End Function

    Private Function LF_ExecSQL(ByVal strSQL As String) As Object

        LF_ExecSQL = Nothing

        If Not L_Func.GF_BeginTrans Then
            GoTo SYSTEM_ERROR
        End If

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            GoTo SYSTEM_ERROR
        End If

        If Not L_Func.GF_CommitTrans Then
            Call L_Func.GF_RollbackTrans()
            GoTo SYSTEM_ERROR
        End If

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG030(LF_ExecSQL)")
        Exit Function
    End Function

    Private Function LF_GetOrderNo(Optional ByVal pSeatID As String = "") As Long

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetOrderNo = 0

        strSQL = ""
        strSQL = strSQL & "SELECT ORDERNO, SELECTTIME"
        strSQL = strSQL & "  FROM TPD010"
        If Len(Trim$(pSeatID)) = 0 Then
            strSQL = strSQL & " WHERE SEATID ='" & RSet(Request.QueryString("SEATID"), 5) & "'"
        Else
            strSQL = strSQL & " WHERE SEATID ='" & RSet(pSeatID, 5) & "'"
        End If
        strSQL = strSQL & " ORDER BY SELECTTIME DESC"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG030(LF_GetOrderNo_1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG030(LF_GetOrderNo_3)")
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
    Private Function CheckTPD010(ByVal pSeatID As String) As Boolean
        Dim strSQL As String    '' SQL実行文字列
        Dim objData As DataSet  '' 取得した内容
        Dim objRow As DataRow = Nothing   '' 指定した位置の内容

        CheckTPD010 = False
        '' ------------------------------
        '' SQL実行文字列を生成する
        '' ------------------------------
        strSQL = "SELECT GOODSCD"
        strSQL = strSQL & " FROM TPD010"
        strSQL = strSQL & " WHERE SEATID='" & RSet(pSeatID, 5) & "'"
        ' お通し・お会計コードをTPM090から取得
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

        ' お通しコードをTPM090から取得 -----------------------
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
    Private Function CheckSTNsend(Optional ByVal pSeatID As String = "") As Boolean
        Dim strSQL As String    '' SQL実行文字列
        Dim objData As DataSet  '' 取得した内容
        Dim objRow As DataRow = Nothing   '' 指定した位置の内容

        CheckSTNsend = False
        '' ------------------------------
        '' SQL実行文字列を生成する
        '' ------------------------------
        strSQL = "SELECT TRANSTIME"
        strSQL = strSQL & " FROM TPD010"

        If Len(Trim$(pSeatID)) = 0 Then
            strSQL = strSQL & " WHERE SEATID='" & RSet(Request.QueryString("SEATID"), 5) & "'"
        Else
            strSQL = strSQL & " WHERE SEATID='" & RSet(pSeatID, 5) & "'"
        End If

        ' まいもん寿司　お通しコードをTPM090から取得
        strSQL = strSQL & " AND GOODSCD='" & Trim$(Me.ViewState("OPEN_GOODSCD")) & "'"
        strSQL = strSQL & " ORDER BY ORDERNO DESC"
        ' 取得した先頭の商品がお通し商品(商品コード：9998)であれば、作成済であると判断する
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

    Private Sub LF_MinusAction()

        'コース終了メッセージ確認時、メニュコードを消して終了
        If Request.QueryString("BTN_STATUS") = "1" Then
            Call LF_UpdORDERSTATUS()
            L_BtnBack = True
            Exit Sub
        End If

        L_Setbtn = True
    End Sub


    '  機能概要：[商品取消]ボタン押下イベント●●
    Private Sub btn_minus_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_minus.Click

        'コース終了メッセージ確認時、メニュコードを消して終了
        If Request.QueryString("BTN_STATUS") = "1" Then
            Call LF_UpdORDERSTATUS()
            L_BtnBack = True
            Exit Sub
        End If

        L_Setbtn = True
    End Sub

    Public Sub OnInitBody()     'CrossNavi修正無し
        If L_Setbtn Then
            'マイナス伝票ボタン押下判定
            Response.Write("onload='fminus(" & Request.QueryString("SEATID") & ")'")
        Else
            'マイナス伝票ボタン押下されていない場合
            If L_BtnBack Then
                Response.Write("onLoad='parent.fWinClose();'")
            End If
        End If
    End Sub

    '  機能概要：座席番号に対する端末識別IDを取得する。
    Private Function LF_GetTermID(ByVal pINDEX As Long, ByRef pTERMID As String, Optional ByVal pSeatID As String = "") As Boolean

        Dim strSQL As String        '' SQL実行文字列
        Dim objDataSet As DataSet   '' DataSetオブジェクト
        Dim objDataRow As DataRow = Nothing   '' DataRowオブジェクト

        LF_GetTermID = False

        strSQL = "SELECT TERMID"
        strSQL = strSQL & " FROM TPM050"

        If Len(Trim$(pSeatID)) = 0 Then
            strSQL = strSQL & " WHERE SEATID = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
        Else
            strSQL = strSQL & " WHERE SEATID = '" & RSet(pSeatID, 5) & "'"
        End If

        '更新 2006/03/03 8インチ対応
        strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR   TERMKIND = 'TCA' "
        strSQL = strSQL & "   OR   TERMKIND = 'TCB') "
        strSQL = strSQL & " ORDER BY TERMID"

        objDataSet = New DataSet()
        If Not L_Func.GF_GetData(strSQL, objDataSet) Then
            Response.Redirect("./TP2990.html?CNWG030(LF_GetTermID_1)")
            Exit Function
        End If

        If objDataSet.Tables("com").Rows.Count <= pINDEX Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objDataSet, pINDEX, objDataRow) Then
            Response.Redirect("./TP2990.html?CNWG030(LF_GetTermID_2)")
            Exit Function
        End If

        pTERMID = Trim$(objDataRow("TERMID"))
        LF_GetTermID = True

    End Function

    Private Function LF_UpdTPM050_1() As Boolean

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        LF_UpdTPM050_1 = False

        strSQL = ""
        strSQL = strSQL & "SELECT TPM050.DEFAULTKCP,"
        strSQL = strSQL & "       TPM050.SEATCOLOR"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE TPM050.SEATID     = '" & RSet(CStr(CLng(Me.ViewState.Item("SEATNO")) - LC_ADD_NUMBER), 5) & "'"
        strSQL = strSQL & "   AND ( TPM050.TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TPM050.TERMKIND = 'TCA'"
        strSQL = strSQL & "   OR    TPM050.TERMKIND = 'TCB' )"
        strSQL = strSQL & "   AND TPM050.VSEATID  = '00000'"
        If Not L_Func.GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count <> 1 Then
            Exit Function
        End If
        If Not L_Func.GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050"
        strSQL = strSQL & "   SET TPM050.SEATID     = '" & RSet(Me.ViewState.Item("SEATNO"), 5) & "',"
        strSQL = strSQL & "       TPM050.DEFAULTKCP = '" & Trim$(objRows("DEFAULTKCP")) & "',"
        strSQL = strSQL & "       TPM050.SEATCOLOR  = '" & Trim$(objRows("SEATCOLOR")) & "',"
        strSQL = strSQL & "       TPM050.UPDID  = 'CNWG001',"
        strSQL = strSQL & "       TPM050.UPDYMD = getDate()"
        strSQL = strSQL & " WHERE TPM050.SEATID = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
        Call LF_ExecSQL(strSQL)

        LF_UpdTPM050_1 = True

    End Function

    Private Function LF_UpdTPM050_2(ByVal pSeatID As String) As Boolean

        Dim strSQL As String

        LF_UpdTPM050_2 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050"
        strSQL = strSQL & "   SET TPM050.SEATID     = TPM050.VSEATID,"
        strSQL = strSQL & "       TPM050.DEFAULTKCP = '00',"
        strSQL = strSQL & "       TPM050.SEATCOLOR  = '7',"
        strSQL = strSQL & "       TPM050.UPDID  = 'CNWG001',"
        strSQL = strSQL & "       TPM050.UPDYMD = getDate()"
        strSQL = strSQL & " WHERE TPM050.SEATID = '" & RSet(pSeatID, 5) & "'"
        Call LF_ExecSQL(strSQL)

        LF_UpdTPM050_2 = True

    End Function

    Private Function LF_ChkExtSeat(ByVal pSeatNo As String, ByRef pExt As Boolean) As Boolean

        Dim strSQL As String
        Dim objData As New DataSet()

        LF_ChkExtSeat = False

        strSQL = ""
        strSQL = strSQL & "SELECT TPM050.SEATID"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE TPM050.SEATID   = '" & RSet(pSeatNo, 5) & "'"
        strSQL = strSQL & "   AND ( TPM050.TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TPM050.TERMKIND = 'TCA'"
        strSQL = strSQL & "   OR    TPM050.TERMKIND = 'TCB' )"
        If Not L_Func.GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            pExt = False
        Else
            pExt = True
        End If

        LF_ChkExtSeat = True

    End Function
    Private Function LF_ChkExtSeat_2(ByVal pSeatNo As String, ByRef pExt As Boolean) As Boolean

        Dim strSQL As String
        Dim objData As New DataSet()

        LF_ChkExtSeat_2 = False

        strSQL = ""
        strSQL = strSQL & "SELECT TPM050.SEATID"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE TPM050.SEATID   = '" & RSet(pSeatNo, 5) & "'"
        strSQL = strSQL & "   AND ( TPM050.TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TPM050.TERMKIND = 'TCA' "
        strSQL = strSQL & "   OR    TPM050.TERMKIND = 'TCB' )"
        strSQL = strSQL & "   AND TPM050.ORDERSTATUS = '1'"
        If Not L_Func.GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            pExt = False
        Else
            pExt = True
        End If

        LF_ChkExtSeat_2 = True

    End Function

    '終了メッセージ表示後、標準メニューに切り替え
    Private Function LF_UpdTPM050_3() As Object

        LF_UpdTPM050_3 = Nothing

        Dim strSQL As String

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050"
        strSQL = strSQL & "   SET SPMENU      = '000',"
        strSQL = strSQL & "       SPMENU2     = '000',"
        strSQL = strSQL & "       ORDERSTATUS = '4'"
        strSQL = strSQL & " WHERE SEATID      = '" & RSet(Trim$(Request.QueryString("SEATID")), 5) & "'"
        strSQL = strSQL & "   AND TERMKIND IN ('TC0', 'TCA', 'TCB')"

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
        Response.Redirect("./TP2990.html?CNWG030(LF_UpdTPM050_3)")
        Exit Function

    End Function

    '警告メッセージ表示後、オーダーステータスを３に更新
    'ORDERSTATUS=3　警告メッセージ表示、終了メッセージ表示待ち状態
    Private Function LF_UpdORDERSTATUS() As Object

        LF_UpdORDERSTATUS = Nothing

        Dim strSQL As String

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050"
        strSQL = strSQL & "   SET ORDERSTATUS = '3'"
        strSQL = strSQL & " WHERE SEATID = '" & RSet(Trim$(Request.QueryString("SEATID")), 5) & "'"
        strSQL = strSQL & "   AND TERMKIND IN ('TC0', 'TCA', 'TCB')"

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
        Response.Redirect("./TP2990.html?CNWG030(LF_UpdORDERSTATUS)")
        Exit Function

    End Function

    Private Sub LS_CMENU()

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim strSQL2 As String
        Dim objData2 As New DataSet()
        Dim objRow2 As DataRow = Nothing
        Dim strSQL3 As String
        Dim objData3 As New DataSet()
        Dim objRow3 As DataRow = Nothing
        Dim FreeMenuCD() As String

        strSQL = ""
        strSQL = strSQL & "SELECT SPMENU2"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE SEATID = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
        strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCA' "
        strSQL = strSQL & "   OR    TERMKIND = 'TCB' )"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG030(LF_CMENU_1)")
            Exit Sub
        End If
        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG030(LF_CMENU_2)")
            Exit Sub
        End If

        If Trim$(objRow("SPMENU2")) = "000" Then     'SPMENU2が000の時、何も表示しない
            lbl_menu.Visible = False
            lbl_course.Visible = False
            lbl_LastOrder_End.Visible = False
            lbl_Course_End.Visible = False
        Else
            lbl_menu.Text = ""
            lbl_course.Text = ""
            lbl_LastOrder_End.Text = ""
            lbl_Course_End.Text = ""


            strSQL2 = ""
            strSQL2 = strSQL2 & "SELECT TPM060.MENUNM"
            strSQL2 = strSQL2 & "  FROM TPM060"
            strSQL2 = strSQL2 & " WHERE MENUID = '" & Trim$(objRow("SPMENU2")) & "'"
            strSQL2 = strSQL2 & " GROUP BY  TPM060.MENUNM"

            If Not L_Func.GF_GetData(strSQL2, objData2) Then
                Response.Redirect("./TP2990.html?CNWG030(LF_CMENU_3)")
                Exit Sub
            End If
            If Not L_Func.GF_GetRows(objData2, 0, objRow2) Then
                Response.Redirect("./TP2990.html?CNWG030(LF_CMENU_4)")
                Exit Sub
            End If

            lbl_menu.Text = "メニュー【" & Trim$(objRow2("MENUNM")) & "】"

            '放題コース取得
            strSQL3 = ""
            strSQL3 = strSQL3 & "SELECT TPD050.D8"
            strSQL3 = strSQL3 & "  FROM TPD050"
            strSQL3 = strSQL3 & " WHERE SEATID = '" & RSet(Request.QueryString("SEATID"), 5) & "'"
            strSQL3 = strSQL3 & "   AND TERMKIND IN ('TCA','TCB','TC0')"

            If Not L_Func.GF_GetData(strSQL3, objData3) Then
                Response.Redirect("./TP2990.html?CNWG030(LF_CMENU_3)")
                Exit Sub
            End If
            If Not L_Func.GF_GetRows(objData3, 0, objRow3) Then
                Response.Redirect("./TP2990.html?CNWG030(LF_CMENU_4)")
                Exit Sub
            End If

            FreeMenuCD = Split(objRow3("D8"), ",")

            strSQL3 = ""
            strSQL3 = strSQL3 & "SELECT TPM010.GOODSNMJ + TPM010.GOODSNMJ2 AS GOODSNMJ"
            strSQL3 = strSQL3 & "  FROM TPM010"
            strSQL3 = strSQL3 & " WHERE GOODSCD = '" & FreeMenuCD(0) & "'"

            objData3 = New DataSet()
            objRow3 = Nothing
            If Not L_Func.GF_GetData(strSQL3, objData3) Then
                Response.Redirect("./TP2990.html?CNWG030(LF_CMENU_3)")
                Exit Sub
            End If
            If Not L_Func.GF_GetRows(objData3, 0, objRow3) Then
                Response.Redirect("./TP2990.html?CNWG030(LF_CMENU_4)")
                Exit Sub
            End If

            lbl_course.Text = "コース　【" & objRow3("GOODSNMJ") & "】"

        End If

        If LF_GetTimeLimit(RSet(Request.QueryString("SEATID"), 5)) = "" Then
            lbl_Course_End.Text = "コース終了"
            lbl_Course_End.ForeColor = Color.Red
        Else
            lbl_Course_End.Text = "コース終了までまで あと" & LF_GetTimeLimit(RSet(Request.QueryString("SEATID"), 5)) & "分"
        End If

        If LF_GetTimeLimit_LO(RSet(Request.QueryString("SEATID"), 5)) = "" Then
            lbl_LastOrder_End.Text = "ラストオーダー終了"
            lbl_LastOrder_End.ForeColor = Color.Red
        Else
            lbl_LastOrder_End.Text = "ラストオーダーまで あと" & LF_GetTimeLimit_LO(RSet(Request.QueryString("SEATID"), 5)) & "分"
        End If

        'If objData.Tables("com").Rows.Count = 0 Then
        '    Exit Sub
        'End If


        Exit Sub

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG030(LF_CMENU)")
        Exit Sub

    End Sub

    ''' <summary>
    ''' 残り時間取得（分）
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_GetTimeLimit(ByVal pSeatID As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        Dim StartTime As DateTime
        Dim FreeTime As Integer
        Dim FreeTimeZan As Integer

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTimeLimit = ""

        '------------------------------
        ' 座席拡張テーブル取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT D6,D7,D8"
        strSQL = strSQL & "  FROM TPD050"
        strSQL = strSQL & " WHERE SEATID = '" & pSeatID & "'"
        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If
        If Not Session("TP").GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        Try
            StartTime = DateTime.ParseExact(objRows("D6").ToString, "yyyyMMddHHmmss", Nothing)
            FreeTime = CInt(objRows("D7").ToString)

            If System.DateTime.Now > StartTime.AddMinutes(FreeTime) Then
                Exit Function
            Else
                Dim ts As TimeSpan = StartTime.AddMinutes(FreeTime) - System.DateTime.Now

                FreeTimeZan = ts.TotalMinutes

                If FreeTimeZan = 0 Then
                    FreeTimeZan = 1
                End If
            End If

        Catch ex As Exception
            Exit Function
        End Try

        LF_GetTimeLimit &= FreeTimeZan.ToString

    End Function

    ''' <summary>
    ''' 残り時間取得（分）
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_GetTimeLimit_LO(ByVal pSeatID As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        Dim StartTime As DateTime
        Dim FreeTime As Integer
        Dim FreeTimeZan As Integer
        Dim FreeCourses As String = ""
        Dim LastCallTime As Integer

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTimeLimit_LO = ""

        '------------------------------
        ' 座席拡張テーブル取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT D6,D7,D8"
        strSQL = strSQL & "  FROM TPD050"
        strSQL = strSQL & " WHERE SEATID = '" & pSeatID & "'"
        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If
        If Not Session("TP").GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        Try
            StartTime = DateTime.ParseExact(objRows("D6").ToString, "yyyyMMddHHmmss", Nothing)
            FreeTime = CInt(objRows("D7").ToString)
            FreeCourses = objRows("D8").ToString

            '------------------------------
            ' ラストオーダー時間取得
            '------------------------------
            LastCallTime = FreeTime - LF_GetLastCallTime(FreeCourses)

            'If System.DateTime.Now > StartTime.AddMinutes(FreeTime) Then
            If System.DateTime.Now > StartTime.AddMinutes(LastCallTime) Then
                Exit Function
            Else
                'Dim ts As TimeSpan = StartTime.AddMinutes(FreeTime) - System.DateTime.Now
                Dim ts As TimeSpan = StartTime.AddMinutes(LastCallTime) - System.DateTime.Now

                FreeTimeZan = ts.TotalMinutes

                If FreeTimeZan = 0 Then
                    FreeTimeZan = 1
                End If
            End If

        Catch ex As Exception
            Exit Function
        End Try

        LF_GetTimeLimit_LO &= FreeTimeZan.ToString

    End Function

    ' **************************************************
    '	機能概要：放題商品のラストオーダーの最大値を
    '	引	  数：登録中の飲み放題商品コード一覧
    '	戻 り 値：オーダー連番の最大値
    ' **************************************************
    Private Function LF_GetLastCallTime(ByVal pFreeCourse As String) As Integer
        Dim strSQL As String = Nothing '' SQL実行文字列
        Dim objData As DataSet '' キャッシュ情報
        Dim objRow As DataRow = Nothing '' 指定行情報

        LF_GetLastCallTime = 1
        '' ------------------------------
        '' 登録中放題商品のラストオーダー時刻の
        '' ------------------------------
        strSQL = "SELECT MAX(LASTCALLTIME) AS LASTCALLTIME"
        strSQL = strSQL & " FROM TPM300"
        strSQL = strSQL & " WHERE FREECOURSEGOODSCD IN (" & pFreeCourse & ")"

        objData = New DataSet()
        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count < 1 Then
            Exit Function
        End If

        If Not Session("TP").GF_GetRows(objData, 0, objRow) Then
            Exit Function
        End If

        LF_GetLastCallTime = Trim$(objRow("LASTCALLTIME"))
    End Function

    '配席パネルの座席解除

    Private Sub LF_Seatcancel(ByVal pSeatID As String)

        Dim strSQL As String
        Dim VtermID As String


        '清掃中判定有の場合はここでは処理を行わない
        If L_Func.GF_GetAppInfo("SET_FLG") = "1" Then
            Exit Sub
        Else

            '自端末のIPアドレス取得
            VtermID = L_Func.GF_GetRealTermID_SEATID(pSeatID)

            '固定席・開局、座席設定同時に行う場合は処理対象外
            If L_Func.GF_GetSeatFlg(VtermID) = "F" And L_Func.GF_GetAppInfo2("FIXED_SEAT_OPENFLG") = "0" Then
                Exit Sub
            End If

            strSQL = ""
            strSQL = strSQL & "UPDATE TPM051"
            strSQL = strSQL & "   SET TPM051.VIRTUALTERMID = ' ',"
            strSQL = strSQL & "       TPM051.UPDID         = 'CNWG030',"
            strSQL = strSQL & "       TPM051.UPDYMD        = '" & Now() & "'"
            strSQL = strSQL & " WHERE REALTERMID ='" & VtermID & "'"


            If Not Session("TP").GF_BeginTrans Then
                Exit Sub
            End If
            If Not Session("TP").GF_UpdData(strSQL) Then
                Call Session("TP").GF_RollbackTrans()
                Exit Sub
            End If
            If Not Session("TP").GF_CommitTrans Then
                Call Session("TP").GF_RollbackTrans()
                Exit Sub
            End If
        End If
    End Sub

    ' 2016.09.27 ｸﾚｽｺ北陸 田代
    Private Function LF_SetSQLTPD010_C(ByVal SEATID As String) As Object

        LF_SetSQLTPD010_C = Nothing

        Dim strSQL As String
        Dim datNow As Date
        Dim OrderNo As Long
        Dim TERMID As String = ""

        datNow = Now
        OrderNo = LF_GetOrderNo(SEATID) + 1

        For i As Integer = 0 To 10
            If Not LF_GetTermID(i, TERMID) Then
                Exit For
            End If
        Next

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPD010 VALUES("
        strSQL = strSQL & "'" & RSet(SEATID, 5) & "', "                                 '座席番号
        strSQL = strSQL & OrderNo & ", "                                  'オーダー連番
        strSQL = strSQL & "'" & TERMID & "', "                                         '端末識別ID
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
        strSQL = strSQL & "0, "                                                         'お通し人数
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
        strSQL = strSQL & "'" & RSet(SEATID, 5) & "', "          '座席番号
        strSQL = strSQL & OrderNo & ", "                                               'オーダー連番
        strSQL = strSQL & "'" & TERMID & "', "                                         '端末識別ID
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
        strSQL = strSQL & "0, "                                                         'お通し人数
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
        Response.Redirect("./TP2990.html?CNWT040(LF_SetSQLTPD010)")
        Exit Function
    End Function
    ' 2016.09.27 ｸﾚｽｺ北陸 田代

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetMaxTranNo() As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String                ' SQL実行文字列
        Dim objDataSet As DataSet           ' SQL実行結果
        Dim objDataRow As DataRow = Nothing ' 取得行の情報

        '------------------------------
        ' 初期値設定
        '------------------------------
        GetMaxTranNo = "1"
        objDataSet = New DataSet()

        strSQL = ""
        strSQL = strSQL & "SELECT MAX(TRANID) AS TRANID"
        strSQL = strSQL & "  FROM TPD052"
        strSQL = strSQL & " GROUP BY TRANID"
        strSQL = strSQL & " ORDER BY TRANID DESC"

        If Not Session("TP").GF_GetData(strSQL, objDataSet) Then
            Exit Function
        End If

        If Not Session("TP").GF_GetRows(objDataSet, 0, objDataRow) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        GetMaxTranNo = CStr(CLng(objDataRow("TRANID") + 1))

    End Function

End Class
