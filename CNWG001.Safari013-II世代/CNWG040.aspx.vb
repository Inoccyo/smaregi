Partial Class CNWG040
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
    Private L_ChgPage1 As Boolean '通常お通し判定フラグ
    Private L_ChgPage2 As Boolean '飲み放題お通し判定フラグ

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '------------------------------
        ' セッション状態確認
        '------------------------------
        If IsNothing(Session("TP")) Then
            L_Func = New TP2920()
            If Not L_Func.GF_Initialize() Then
                Response.Redirect("./TP2990.html?CNWG040(Page_Load-1)")
                Exit Sub
            End If
            Session("TP") = L_Func
        Else
            L_Func = Session("TP")
        End If

        L_ChgPage1 = False
        L_ChgPage2 = False

        'ボタン色初期化
        btn_Menu1.BackColor = Color.Empty
        btn_Menu2.BackColor = Color.Empty
        btn_Menu3.BackColor = Color.Empty
        btn_Menu4.BackColor = Color.Empty
        btn_Menu5.BackColor = Color.Empty

        '------------------------------
        ' ポストバック時は処理対象外
        '------------------------------
        If IsPostBack Then
            Exit Sub
        End If

        Me.ViewState("MENUID") = Request.QueryString("MENUID")
        Me.ViewState("GOODSCD") = Request.QueryString("GOODSCD")

        '------------------------------
        ' 遷移ﾊﾟﾗﾒﾀにより表示項目設定
        '------------------------------
        Call LF_SetTopBtn()

        btn_back.Attributes.Add("ONCLICK", "parent.fWinClose();")

        txt_Seat.Text = Request.QueryString("SEATID") & "番席"
        lbl_status.Text = "空席"
        txt_Msg.Text = ""

    End Sub

    Private Function LF_SetTopBtn() As Object

        LF_SetTopBtn = Nothing

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim intcnt As Long

        '------------------------------
        ' 通常メニューデータ件数取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT '0000' AS GOODSCD,"
        strSQL = strSQL & "       MAX(TPM060.MENUID) AS DISPMENUID,"
        strSQL = strSQL & "       TPM060.MENUNM"
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " GROUP BY TPM060.MENUNM"
        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG040(LF_SetTopBtn-1)")
            Exit Function
        End If

        intcnt = objData.Tables("com").Rows.Count

        '------------------------------
        ' コースメニューデータ件数取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        strSQL = strSQL & "       TPM180.DISPMENUID,"
        strSQL = strSQL & "       (SELECT TPM010.GOODSNMJ + TPM010.GOODSNMJ2 FROM TPM010 WHERE TPM010.GOODSCD = TPM180.GOODSCD) AS MENUNM"
        strSQL = strSQL & "  FROM TPM010, TPM180"
        strSQL = strSQL & " WHERE TPM010.GOODSCD = TPM180.GOODSCD"
        strSQL = strSQL & "   AND TPM010.SELLFLG = '0'"
        objData = New DataSet()
        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG040(LF_SetTopBtn-2)")
            Exit Function
        End If

        intcnt = intcnt + objData.Tables("com").Rows.Count

        Call LF_SetMoveBtn(intcnt)

        Call LF_SetMiddleBtn()

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニュー一覧 表示処理
    ' 　機能概要：
    ' --------------------------------------------------------------------------------
    Public Function LF_SetMiddleBtn() As Object

        LF_SetMiddleBtn = Nothing

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim objData2 As New DataSet()
        Dim objRows2 As DataRow = Nothing
        Dim lngCnt As Long
        Dim lngCnt2 As Long
        Dim lngPage As Long
        Dim lngRead As Long
        Dim lngRead2 As Long
        Dim strCourse As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        lngCnt = 0
        lngCnt2 = 0
        lngPage = 0
        lngRead2 = 0
        strCourse = ""
        strSQL = ""

        '初期化
        btn_Menu1.Visible = True
        btn_Menu2.Visible = True
        btn_Menu3.Visible = True
        btn_Menu4.Visible = True
        btn_Menu5.Visible = True
        btn_MenuID1.Visible = True
        btn_MenuID2.Visible = True
        btn_MenuID3.Visible = True
        btn_MenuID4.Visible = True
        btn_MenuID5.Visible = True
        btn_GOODSCD1.Visible = True
        btn_GOODSCD2.Visible = True
        btn_GOODSCD3.Visible = True
        btn_GOODSCD4.Visible = True
        btn_GOODSCD5.Visible = True
        btn_FreeDrinkMenuID1.Visible = True
        btn_FreeDrinkMenuID2.Visible = True
        btn_FreeDrinkMenuID3.Visible = True
        btn_FreeDrinkMenuID4.Visible = True
        btn_FreeDrinkMenuID5.Visible = True
        '---飲み放題ボタンの使用不可---------
        'btn_Drink.Enabled = True
        btn_Drink.Enabled = False
        '------------------------------------
        btn_Drink.Text = L_Func.GF_GetAppInfo("FREE_MENU_NM")

        '------------------------------
        ' 表示ページ番号判定
        '------------------------------
        If Len(Me.ViewState("PAGE")) = 0 Then
            lngPage = 1
        Else
            If Not IsNumeric(Me.ViewState("PAGE")) Then
                lngPage = 1
            Else
                lngPage = CLng(Me.ViewState("PAGE"))
            End If
        End If
        lngRead = (lngPage - 1) * 5

        '通常メニュー取得
        strSQL = strSQL & "SELECT '0000' AS GOODSCD,"
        strSQL = strSQL & "       MAX(TPM060.MENUID) AS DISPMENUID,"
        strSQL = strSQL & "       '000' As FREEDRINKMENUID,"
        strSQL = strSQL & "       TPM060.MENUNM"
        strSQL = strSQL & "  FROM TPM060"
        '（飲み放題連携している場合はリアルタイム転送データ対象外）
        If L_Func.GF_GetAppInfo("SYS_TYPE") = "2" Then
            strSQL = strSQL & " WHERE SUBSTRING(TPM060.MENUID,1,1) <> 'R'"
        End If
        strSQL = strSQL & " GROUP BY TPM060.MENUNM"

        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG040(LF_SetMiddleBtn-1)")
            Exit Function
        End If

        'Else
        'コースメニュー取得
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        strSQL = strSQL & "       TPM180.DISPMENUID,"
        strSQL = strSQL & "       TPM180.FREEDRINKMENUID,"
        strSQL = strSQL & "       (SELECT TPM010.GOODSNMJ + TPM010.GOODSNMJ2 FROM TPM010 WHERE TPM010.GOODSCD = TPM180.GOODSCD) AS MENUNM"
        strSQL = strSQL & "  FROM TPM010, TPM180"
        strSQL = strSQL & " WHERE TPM010.GOODSCD = TPM180.GOODSCD"
        strSQL = strSQL & "   AND TPM010.SELLFLG = '0'"
        'End If
        If Not Session("TP").GF_GetData(strSQL, objData2) Then
            Response.Redirect("./TP2990.html?CNWG040(LF_SetMiddleBtn-1)")
            Exit Function
        End If



        '------------------------------
        ' メニュー一覧部出力
        '------------------------------
        Try

            For lngCnt = 0 To 4


                If lngRead < CLng(objData.Tables("com").Rows.Count) Then

                    If Not Session("TP").GF_GetRows(objData, lngRead, objRows) Then
                        Response.Redirect("./TP2990.html?CNWG040(LF_SetMiddleBtn-2)")
                        Exit Function
                    End If

                    Select Case lngCnt
                        Case 0
                            btn_Menu1.Text = Trim$(objRows("MENUNM"))
                            btn_MenuID1.Text = Trim$(objRows("DISPMENUID"))
                            btn_GOODSCD1.Text = Trim$(objRows("GOODSCD"))
                            btn_FreeDrinkMenuID1.Text = Trim$(objRows("FREEDRINKMENUID"))
                            If Me.ViewState("MENUID") = Trim$(objRows("DISPMENUID")) And Me.ViewState("GOODSCD") = Trim$(objRows("GOODSCD")) Then
                                'ボタン色反転
                                btn_Menu1.BackColor = Color.Pink
                                Call btn_click(1) '(2006.05.30) XX放題対応
                            End If
                        Case 1
                            btn_Menu2.Text = Trim$(objRows("MENUNM"))
                            btn_MenuID2.Text = Trim$(objRows("DISPMENUID"))
                            btn_GOODSCD2.Text = Trim$(objRows("GOODSCD"))
                            btn_FreeDrinkMenuID2.Text = Trim$(objRows("FREEDRINKMENUID"))
                            If Me.ViewState("MENUID") = Trim$(objRows("DISPMENUID")) And Me.ViewState("GOODSCD") = Trim$(objRows("GOODSCD")) Then
                                'ボタン色反転
                                btn_Menu2.BackColor = Color.Pink
                                Call btn_click(2) '(2006.05.30) XX放題対応
                            End If
                        Case 2
                            btn_Menu3.Text = Trim$(objRows("MENUNM"))
                            btn_MenuID3.Text = Trim$(objRows("DISPMENUID"))
                            btn_GOODSCD3.Text = Trim$(objRows("GOODSCD"))
                            btn_FreeDrinkMenuID3.Text = Trim$(objRows("FREEDRINKMENUID"))
                            If Me.ViewState("MENUID") = Trim$(objRows("DISPMENUID")) And Me.ViewState("GOODSCD") = Trim$(objRows("GOODSCD")) Then
                                'ボタン色反転
                                btn_Menu3.BackColor = Color.Pink
                                Call btn_click(3) '(2006.05.30) XX放題対応
                            End If
                        Case 3
                            btn_Menu4.Text = Trim$(objRows("MENUNM"))
                            btn_MenuID4.Text = Trim$(objRows("DISPMENUID"))
                            btn_GOODSCD4.Text = Trim$(objRows("GOODSCD"))
                            btn_FreeDrinkMenuID4.Text = Trim$(objRows("FREEDRINKMENUID"))
                            If Me.ViewState("MENUID") = Trim$(objRows("DISPMENUID")) And Me.ViewState("GOODSCD") = Trim$(objRows("GOODSCD")) Then
                                'ボタン色反転
                                btn_Menu4.BackColor = Color.Pink
                                Call btn_click(4) '(2006.05.30) XX放題対応
                            End If
                        Case 4
                            btn_Menu5.Text = Trim$(objRows("MENUNM"))
                            btn_MenuID5.Text = Trim$(objRows("DISPMENUID"))
                            btn_GOODSCD5.Text = Trim$(objRows("GOODSCD"))
                            btn_FreeDrinkMenuID5.Text = Trim$(objRows("FREEDRINKMENUID"))
                            If Me.ViewState("MENUID") = Trim$(objRows("DISPMENUID")) And Me.ViewState("GOODSCD") = Trim$(objRows("GOODSCD")) Then
                                'ボタン色反転
                                btn_Menu5.BackColor = Color.Pink
                                Call btn_click(5) '(2006.05.30) XX放題対応
                            End If
                    End Select

                    lngRead = lngRead + 1
                Else

                    If lngRead2 < CLng(objData2.Tables("com").Rows.Count) Then

                        If Not Session("TP").GF_GetRows(objData2, lngCnt2, objRows2) Then
                            Response.Redirect("./TP2990.html?CNWG040(LF_SetMiddleBtn-2)")
                            Exit Function
                        End If

                        Select Case lngCnt
                            Case 0
                                btn_Menu1.Text = Trim$(objRows2("MENUNM"))
                                btn_MenuID1.Text = Trim$(objRows2("DISPMENUID"))
                                btn_GOODSCD1.Text = Trim$(objRows2("GOODSCD"))
                                btn_FreeDrinkMenuID1.Text = Trim$(objRows2("FREEDRINKMENUID"))
                                lbl_Menu1.Text = "コース"
                                If Me.ViewState("MENUID") = Trim$(objRows2("DISPMENUID")) And Me.ViewState("GOODSCD") = Trim$(objRows2("GOODSCD")) Then
                                    'ボタン色反転
                                    btn_Menu1.BackColor = Color.Pink
                                    Call btn_click(1) '(2006.05.30) XX放題対応
                                End If
                            Case 1
                                btn_Menu2.Text = Trim$(objRows2("MENUNM"))
                                btn_MenuID2.Text = Trim$(objRows2("DISPMENUID"))
                                btn_GOODSCD2.Text = Trim$(objRows2("GOODSCD"))
                                btn_FreeDrinkMenuID2.Text = Trim$(objRows2("FREEDRINKMENUID"))
                                lbl_Menu2.Text = "コース"
                                If Me.ViewState("MENUID") = Trim$(objRows2("DISPMENUID")) And Me.ViewState("GOODSCD") = Trim$(objRows2("GOODSCD")) Then
                                    'ボタン色反転
                                    btn_Menu2.BackColor = Color.Pink
                                    Call btn_click(2) '(2006.05.30) XX放題対応
                                End If
                            Case 2
                                btn_Menu3.Text = Trim$(objRows2("MENUNM"))
                                btn_MenuID3.Text = Trim$(objRows2("DISPMENUID"))
                                btn_GOODSCD3.Text = Trim$(objRows2("GOODSCD"))
                                btn_FreeDrinkMenuID3.Text = Trim$(objRows2("FREEDRINKMENUID"))
                                lbl_Menu3.Text = "コース"
                                If Me.ViewState("MENUID") = Trim$(objRows2("DISPMENUID")) And Me.ViewState("GOODSCD") = Trim$(objRows2("GOODSCD")) Then
                                    'ボタン色反転
                                    btn_Menu3.BackColor = Color.Pink
                                    Call btn_click(3) '(2006.05.30) XX放題対応
                                End If
                            Case 3
                                btn_Menu4.Text = Trim$(objRows2("MENUNM"))
                                btn_MenuID4.Text = Trim$(objRows2("DISPMENUID"))
                                btn_GOODSCD4.Text = Trim$(objRows2("GOODSCD"))
                                btn_FreeDrinkMenuID4.Text = Trim$(objRows2("FREEDRINKMENUID"))
                                lbl_Menu4.Text = "コース"
                                If Me.ViewState("MENUID") = Trim$(objRows2("DISPMENUID")) And Me.ViewState("GOODSCD") = Trim$(objRows2("GOODSCD")) Then
                                    'ボタン色反転
                                    btn_Menu4.BackColor = Color.Pink
                                    Call btn_click(4) '(2006.05.30) XX放題対応
                                End If
                            Case 4
                                btn_Menu5.Text = Trim$(objRows2("MENUNM"))
                                btn_MenuID5.Text = Trim$(objRows2("DISPMENUID"))
                                btn_GOODSCD5.Text = Trim$(objRows2("GOODSCD"))
                                btn_FreeDrinkMenuID5.Text = Trim$(objRows2("FREEDRINKMENUID"))
                                lbl_Menu5.Text = "コース"
                                If Me.ViewState("MENUID") = Trim$(objRows2("DISPMENUID")) And Me.ViewState("GOODSCD") = Trim$(objRows2("GOODSCD")) Then
                                    'ボタン色反転
                                    btn_Menu5.BackColor = Color.Pink
                                    Call btn_click(5) '(2006.05.30) XX放題対応
                                End If

                        End Select
                        lngRead2 = lngRead2 + 1
                        lngCnt2 = lngCnt2 + 1

                    Else
                        Select Case lngCnt
                            Case 0
                                btn_Menu1.Visible = False
                                btn_MenuID1.Visible = False
                                btn_GOODSCD1.Visible = False
                                btn_FreeDrinkMenuID1.Visible = False
                                lbl_Menu1.Visible = False
                            Case 1
                                btn_Menu2.Visible = False
                                btn_MenuID2.Visible = False
                                btn_GOODSCD2.Visible = False
                                btn_FreeDrinkMenuID2.Visible = False
                                lbl_Menu2.Visible = False
                            Case 2
                                btn_Menu3.Visible = False
                                btn_MenuID3.Visible = False
                                btn_GOODSCD3.Visible = False
                                btn_FreeDrinkMenuID3.Visible = False
                                lbl_Menu3.Visible = False
                            Case 3
                                btn_Menu4.Visible = False
                                btn_MenuID4.Visible = False
                                btn_GOODSCD4.Visible = False
                                btn_FreeDrinkMenuID4.Visible = False
                                lbl_Menu4.Visible = False
                            Case 4
                                btn_Menu5.Visible = False
                                btn_MenuID5.Visible = False
                                btn_GOODSCD5.Visible = False
                                btn_FreeDrinkMenuID5.Visible = False
                                lbl_Menu5.Visible = False
                        End Select

                    End If
                End If

            Next

        Catch
            Response.Redirect("./TP2990.html?CNWG040(LF_SetMiddleBtn-3)")
            Exit Function
        End Try


    End Function

    Private Function LF_SetMoveBtn(ByVal pMENUCNT As Long) As Boolean
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngPage As Long
        Dim lngRead As Long
        Dim blnNext As Boolean
        Dim blnPrev As Boolean

        LF_SetMoveBtn = False

        '------------------------------
        ' 表示ページ番号判定
        '------------------------------
        If Len(Me.ViewState("PAGE")) = 0 Then
            lngPage = 1
            Me.ViewState("PAGE") = lngPage
        Else
            If Not IsNumeric(Me.ViewState("PAGE")) Then
                lngPage = 1
            Else
                lngPage = CLng(Me.ViewState("PAGE"))
            End If
        End If
        lngRead = (lngPage - 1) * 5

        '------------------------------
        ' ページ遷移有無判定
        '------------------------------
        blnNext = False
        blnPrev = False
        If (((lngPage - 1) * 5) + 5) < pMENUCNT Then
            blnNext = True
        End If
        If lngPage > 1 Then
            blnPrev = True
        End If

        '------------------------------
        ' 次ページボタン表示
        '------------------------------
        If blnNext Then
            btn_Next.Visible = True
        Else
            btn_Next.Visible = False
        End If

        '------------------------------
        ' 前ページボタン表示
        '------------------------------
        If blnPrev Then
            btn_Prev.Visible = True
        Else
            btn_Prev.Visible = False
        End If

        LF_SetMoveBtn = True

    End Function

    '' **************************************************
    ''  機能概要：[前ページ]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_Prev_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Prev.Click

        Me.ViewState("PAGE") = CLng(Me.ViewState("PAGE")) - 1

        '------------------------------
        ' 遷移ﾊﾟﾗﾒﾀにより表示項目設定
        '------------------------------
        Call LF_SetTopBtn()

    End Sub

    '' **************************************************
    ''  機能概要：[次ページ]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_Next_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Next.Click

        Me.ViewState("PAGE") = CLng(Me.ViewState("PAGE")) + 1

        '------------------------------
        ' 遷移ﾊﾟﾗﾒﾀにより表示項目設定
        '------------------------------
        Call LF_SetTopBtn()

    End Sub

    '' **************************************************
    ''  機能概要：[メニュー１]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_Menu1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Menu1.Click

        'ボタン色反転
        Call btn_click(1)

    End Sub

    '' **************************************************
    ''  機能概要：[メニュー２]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_Menu2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Menu2.Click

        'ボタン色反転
        Call btn_click(2)

    End Sub

    '' **************************************************
    ''  機能概要：[メニュー３]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_Menu3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Menu3.Click

        'ボタン色反転
        Call btn_click(3)

    End Sub

    '' **************************************************
    ''  機能概要：[メニュー４]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_Menu4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Menu4.Click

        'ボタン色反転
        Call btn_click(4)

    End Sub

    '' **************************************************
    ''  機能概要：[メニュー５]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_Menu5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Menu5.Click

        'ボタン色反転
        Call btn_click(5)

    End Sub

    '' **************************************************
    ''  機能概要：[お通し]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_Set_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Set.Click

        ' 入力チェック
        Call LF_GetOrderStatus()
        If Trim$(Me.ViewState("ORDERSTATUS")) = "2" Then
            If Len(Me.ViewState("MENUID")) = 0 Then
                txt_Msg.Text = "【入力エラー】メニューを設定して下さい。"
                Exit Sub
            End If
        Else
            txt_Msg.Text = "【入力エラー】既にお通し済みです"
            Exit Sub
        End If

        L_ChgPage1 = True
    End Sub

    '' **************************************************
    ''  機能概要：[飲み放題]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_Drink_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Drink.Click

        ' 入力チェック
        Call LF_GetOrderStatus()
        If Trim$(Me.ViewState("ORDERSTATUS")) = "2" Then
            If Len(Me.ViewState("MENUID")) = 0 Then
                txt_Msg.Text = "【入力エラー】メニューを設定して下さい。"
                Exit Sub
            End If
        Else
            txt_Msg.Text = "【入力エラー】既にお通し済みです"
            Exit Sub
        End If

        L_ChgPage2 = True
    End Sub

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
        strSQL = strSQL & "   OR    TERMKIND = 'TCA'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCB' )"
        strSQL = strSQL & " ORDER BY ORDERSTATUS"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG040(LF_GetOrderStatus-1)")
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If
        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG040(LF_GetOrderStatus-2)")
            Exit Function
        End If

        LF_GetOrderStatus = Trim$(objRow("ORDERSTATUS"))
        Me.ViewState("ORDERSTATUS") = LF_GetOrderStatus

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG040(LF_GetOrderStatus-3)")
        Exit Function
    End Function

    '' **************************************************
    ''  機能概要：<body>にonLoadイベントを出力する。
    ''  引    数：
    ''  戻 り 値：
    '' **************************************************
    Public Sub OnInitBody()
        Dim strURL As String
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        strSQL = ""
        strSQL = strSQL & "SELECT POSITION FROM TPM050"
        strSQL = strSQL & "       WHERE TERMKIND = 'TC9'"
        strSQL = strSQL & "         AND TERMID = '" & Trim$(Request.UserHostAddress) & "'"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG040(LF_CheckOrderStatus-1)")
            Exit Sub
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Sub
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG040(LF_CheckOrderStatus-2)")
            Exit Sub
        End If

        strURL = ""
        If L_ChgPage1 Then
            strURL = "CNWG050"
        ElseIf L_ChgPage2 Then
            strURL = "CNWG060"
        End If

        If Len(Trim$(strURL)) > 0 Then
            Select Case objRow("POSITION").ToString
                Case "20"
                    Response.Write("onLoad='fChgPage(""" & strURL & """, " & Trim(Request.QueryString("SEATID")) & ", """ & Me.ViewState("MENUID") & """, """ & Me.ViewState("COURSE") & """, """ & Me.ViewState("GOODSCD") & """);'")
                Case "21"
                    Response.Write("onLoad='fChgPage2(""" & strURL & """, " & Trim(Request.QueryString("SEATID")) & ", """ & Me.ViewState("MENUID") & """, """ & Me.ViewState("COURSE") & """, """ & Me.ViewState("GOODSCD") & """);'")
            End Select
        End If
    End Sub

    Private Function btn_click(ByVal btn_nmber As Long) As Object

        btn_click = Nothing

        Select Case btn_nmber

            Case 1
                'ボタン色反転
                btn_Menu1.BackColor = Color.Pink
                btn_Menu2.BackColor = Color.Empty
                btn_Menu3.BackColor = Color.Empty
                btn_Menu4.BackColor = Color.Empty
                btn_Menu5.BackColor = Color.Empty

                Me.ViewState("MENUID") = btn_MenuID1.Text
                Me.ViewState("MENUNM") = btn_Menu1.Text
                Me.ViewState("GOODSCD") = btn_GOODSCD1.Text

            Case 2
                'ボタン色反転
                btn_Menu1.BackColor = Color.Empty
                btn_Menu2.BackColor = Color.Pink
                btn_Menu3.BackColor = Color.Empty
                btn_Menu4.BackColor = Color.Empty
                btn_Menu5.BackColor = Color.Empty

                Me.ViewState("MENUID") = btn_MenuID2.Text
                Me.ViewState("MENUNM") = btn_Menu2.Text
                Me.ViewState("GOODSCD") = btn_GOODSCD2.Text

            Case 3
                'ボタン色反転
                btn_Menu1.BackColor = Color.Empty
                btn_Menu2.BackColor = Color.Empty
                btn_Menu3.BackColor = Color.Pink
                btn_Menu4.BackColor = Color.Empty
                btn_Menu5.BackColor = Color.Empty

                Me.ViewState("MENUID") = btn_MenuID3.Text
                Me.ViewState("MENUNM") = btn_Menu3.Text
                Me.ViewState("GOODSCD") = btn_GOODSCD3.Text

            Case 4
                'ボタン色反転
                btn_Menu1.BackColor = Color.Empty
                btn_Menu2.BackColor = Color.Empty
                btn_Menu3.BackColor = Color.Empty
                btn_Menu4.BackColor = Color.Pink
                btn_Menu5.BackColor = Color.Empty

                Me.ViewState("MENUID") = btn_MenuID4.Text
                Me.ViewState("MENUNM") = btn_Menu4.Text
                Me.ViewState("GOODSCD") = btn_GOODSCD4.Text

            Case 5
                btn_Menu1.BackColor = Color.Empty
                btn_Menu2.BackColor = Color.Empty
                btn_Menu3.BackColor = Color.Empty
                btn_Menu4.BackColor = Color.Empty
                btn_Menu5.BackColor = Color.Pink

                Me.ViewState("MENUID") = btn_MenuID5.Text
                Me.ViewState("MENUNM") = btn_Menu5.Text
                Me.ViewState("GOODSCD") = btn_GOODSCD5.Text

        End Select
    End Function

End Class
