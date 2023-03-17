Partial Class CNWG060
    Inherits System.Web.UI.Page
    Protected WithEvents btn_Normal As System.Web.UI.WebControls.Button
    Protected WithEvents btn_Course As System.Web.UI.WebControls.Button

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
    Private L_BtnPrev As Boolean
    Private L_Iframe As String
    Private L_BtnBack As Boolean
    Private L_SubFlg As Boolean

    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '------------------------------
        ' セッション状態確認
        '------------------------------
        If IsNothing(Session("TP")) Then
            L_Func = New TP2920()
            If Not L_Func.GF_Initialize() Then
                Response.Redirect("./TP2990.html?CNWG060(Page_Load-1)")
                Exit Sub
            End If
            Session("TP") = L_Func
        Else
            L_Func = Session("TP")
        End If

        L_BtnPrev = False
        L_Iframe = "0"
        L_BtnBack = False
        L_SubFlg = False

        Me.ViewState("REG_GOODSCD") = L_Func.GF_GetAppInfo("REG_GOODSCD")       'お会計
        Me.ViewState("OPEN_GOODSCD") = L_Func.GF_GetAppInfo("OPEN_GOODSCD")     'お通し

        '------------------------------
        ' ポストバック時は処理対象外
        '------------------------------
        If IsPostBack Then
            Exit Sub
        End If

        '------------------------------
        ' 遷移ﾊﾟﾗﾒﾀにより表示項目設定
        '------------------------------
        Call LF_SetMainMenuBtn()

        btn_back.Attributes.Add("ONCLICK", "parent.fWinClose();")
        btn_true.Attributes.Add("ONCLICK", "__doPostBack('btn_true','Click');")

        txt_Seat.Text = Request.QueryString("SEATID") & "番席"
        lbl_status.Text = "空席"
        txt_Msg.Text = ""
        lbl_MenuNM.Text = LF_GetMenuName()
        txt_Main.Text = L_Func.GF_GetAppInfo("FREE_MENU_NM") & "メインコース"
        txt_Sub.Text = ""
        txt_number1.Text = ""
        txt_number2.Text = ""
        txt_unit1.Text = "【        人】"
        txt_unit2.Text = "【        人】"
        tbl_Confirm.Visible = False
        lbl_Confirm.Visible = False
        btn_true.Visible = False
        btn_false.Visible = False

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メインメニュー一覧 表示処理
    ' 　機能概要：
    ' --------------------------------------------------------------------------------
    Public Function LF_SetMainMenuBtn() As Object

        LF_SetMainMenuBtn = Nothing

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim lngPage As Long
        Dim lngRead As Long

        '------------------------------
        ' 初期値設定
        '------------------------------
        lngCnt = 0
        lngPage = 0
        strSQL = ""

        '初期化
        btn_MMenu1.Visible = True
        btn_MMenu2.Visible = True
        btn_MMenu3.Visible = True
        btn_MMenuID1.Visible = True
        btn_MMenuID2.Visible = True
        btn_MMenuID3.Visible = True
        btn_SMenu1.Visible = False
        btn_SMenu2.Visible = False
        btn_SMenuID1.Visible = False
        btn_SMenuID2.Visible = False
        btn_SGOODSCD1.Visible = False
        btn_SGOODSCD2.Visible = False
        txt_number1.Visible = False
        txt_number2.Visible = False
        txt_unit1.Visible = False
        txt_unit2.Visible = False
        txt_Sub.Visible = False

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
        lngRead = (lngPage - 1) * 3

        '------------------------------
        ' メニューデータ取得
        '------------------------------
        '宴会メインメニュー取得
        strSQL = strSQL & "SELECT MAX(TPM170.MENUID) AS MENUID,"
        strSQL = strSQL & "       TPM170.MENUNM"
        strSQL = strSQL & "  FROM TPM170"
        strSQL = strSQL & " WHERE TPM170.ENABLED = '1'"
        strSQL = strSQL & " GROUP BY TPM170.MENUNM"
        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG060(LF_SetMainMenuBtn-1)")
            Exit Function
        End If

        '------------------------------
        ' メニュー一覧部出力
        '------------------------------
        Try
            If objData.Tables("com").Rows.Count = 0 Then
                Exit Function '抽出結果０件時は、何も行わない
            End If

            Call LF_SetMoveBtn(objData.Tables("com").Rows.Count)

            For lngCnt = 0 To 2
                If lngRead < CLng(objData.Tables("com").Rows.Count) Then
                    If Not Session("TP").GF_GetRows(objData, lngRead, objRows) Then
                        Response.Redirect("./TP2990.html?CNWG060(LF_SetMainMenuBtn-2)")
                        Exit Function
                    End If

                    Select Case lngCnt
                        Case 0
                            btn_MMenu1.Text = Trim$(objRows("MENUNM"))
                            btn_MMenuID1.Text = Trim$(objRows("MENUID"))
                            If Me.ViewState("DRINK_MENUID") = Trim$(objRows("MENUID")) Then
                                L_SubFlg = True

                                'ボタン色反転
                                btn_MMenu1.BackColor = Color.Pink
                                btn_MMenu2.BackColor = Color.Empty
                                btn_MMenu3.BackColor = Color.Empty
                            End If
                        Case 1
                            btn_MMenu2.Text = Trim$(objRows("MENUNM"))
                            btn_MMenuID2.Text = Trim$(objRows("MENUID"))
                            If Me.ViewState("DRINK_MENUID") = Trim$(objRows("MENUID")) Then
                                L_SubFlg = True

                                'ボタン色反転
                                btn_MMenu1.BackColor = Color.Empty
                                btn_MMenu2.BackColor = Color.Pink
                                btn_MMenu3.BackColor = Color.Empty
                            End If
                        Case 2
                            btn_MMenu3.Text = Trim$(objRows("MENUNM"))
                            btn_MMenuID3.Text = Trim$(objRows("MENUID"))
                            If Me.ViewState("DRINK_MENUID") = Trim$(objRows("MENUID")) Then
                                L_SubFlg = True

                                'ボタン色反転
                                btn_MMenu1.BackColor = Color.Empty
                                btn_MMenu2.BackColor = Color.Empty
                                btn_MMenu3.BackColor = Color.Pink
                            End If
                    End Select

                    lngRead = lngRead + 1
                Else
                    Select Case lngCnt
                        Case 0
                            btn_MMenu1.Visible = False
                            btn_MMenuID1.Visible = False
                        Case 1
                            btn_MMenu2.Visible = False
                            btn_MMenuID2.Visible = False
                        Case 2
                            btn_MMenu3.Visible = False
                            btn_MMenuID3.Visible = False
                    End Select
                End If
            Next

            If L_SubFlg Then
                Call LF_SetSubMenuBtn()
            End If

        Catch
            Response.Redirect("./TP2990.html?CNWG060(LF_SetMainMenuBtn-3)")
            Exit Function
        End Try

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：サブメニュー一覧 表示処理
    ' 　機能概要：
    ' --------------------------------------------------------------------------------
    Public Function LF_SetSubMenuBtn() As Object

        LF_SetSubMenuBtn = Nothing

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim blnCnt As Boolean

        '------------------------------
        ' 初期値設定
        '------------------------------
        lngCnt = 0
        strSQL = ""
        blnCnt = False

        '初期化
        btn_SMenu1.Visible = False
        btn_SMenu2.Visible = False
        btn_SMenuID1.Visible = False
        btn_SMenuID2.Visible = False
        btn_SGOODSCD1.Visible = False
        btn_SGOODSCD2.Visible = False
        txt_number1.Visible = False
        txt_number2.Visible = False
        txt_unit1.Visible = False
        txt_unit2.Visible = False
        txt_Sub.Visible = False

        '------------------------------
        ' メニューデータ取得
        '------------------------------
        '宴会サブメニュー取得
        strSQL = strSQL & " SELECT DISTINCT"
        strSQL = strSQL & "        TPM170.MENUID,"
        strSQL = strSQL & "        TPM170.MENUNM,"
        strSQL = strSQL & "        TPM170.SUB1GOODSCD,"
        strSQL = strSQL & "        TPM170.SUB1ENABLED,"
        strSQL = strSQL & "        (SELECT TPM010.GOODSNMJ FROM TPM010 WHERE TPM010.GOODSCD = TPM170.SUB1GOODSCD) AS SUB1NMJ,"
        strSQL = strSQL & "        (SELECT TPM010.GOODSNMJ2 FROM TPM010 WHERE TPM010.GOODSCD = TPM170.SUB1GOODSCD) AS SUB1NMJ2,"
        strSQL = strSQL & "        TPM170.SUB2GOODSCD,"
        strSQL = strSQL & "        TPM170.SUB2ENABLED,"
        strSQL = strSQL & "        (SELECT TPM010.GOODSNMJ FROM TPM010 WHERE TPM010.GOODSCD = TPM170.SUB2GOODSCD) AS SUB2NMJ,"
        strSQL = strSQL & "        (SELECT TPM010.GOODSNMJ2 FROM TPM010 WHERE TPM010.GOODSCD = TPM170.SUB2GOODSCD) AS SUB2NMJ2"
        strSQL = strSQL & "        FROM TPM010, TPM170"
        strSQL = strSQL & " WHERE  TPM170.GROUPCD = '0000'"
        strSQL = strSQL & "   AND  TPM170.MENUID = '" & Me.ViewState("DRINK_MENUID") & "'"
        strSQL = strSQL & "   AND (TPM170.SUB1GOODSCD = TPM010.GOODSCD"
        strSQL = strSQL & "    OR  TPM170.SUB2GOODSCD = TPM010.GOODSCD)"
        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG060(LF_SetSubMenuBtn-1)")
            Exit Function
        End If

        '------------------------------
        ' メニュー一覧部出力
        '------------------------------
        Try
            If objData.Tables("com").Rows.Count = 0 Then
                Exit Function '抽出結果０件時は、何も行わない
            End If

            If 0 < CLng(objData.Tables("com").Rows.Count) Then
                If Not Session("TP").GF_GetRows(objData, 0, objRows) Then
                    Response.Redirect("./TP2990.html?CNWG060(LF_SetSubMenuBtn-2)")
                    Exit Function
                End If

                If Len(Trim$(objRows("SUB1GOODSCD"))) <> 0 And Trim$(objRows("SUB1ENABLED")) = "1" Then
                    btn_SMenu1.Visible = True
                    btn_SMenuID1.Visible = True
                    btn_SGOODSCD1.Visible = True
                    txt_number1.Visible = True
                    txt_unit1.Visible = True
                    txt_Sub.Visible = True
                    txt_Sub.Text = L_Func.GF_GetAppInfo("FREE_MENU_NM") & "サブコース"
                    btn_SMenu1.Text = Trim$(objRows("SUB1NMJ")) & ControlChars.NewLine & Trim$(objRows("SUB1NMJ2"))
                    btn_SMenuID1.Text = Trim$(objRows("MENUID"))
                    btn_SGOODSCD1.Text = Trim$(objRows("SUB1GOODSCD"))

                    blnCnt = True
                End If

                If Len(Trim$(objRows("SUB2GOODSCD"))) <> 0 And Trim$(objRows("SUB2ENABLED")) = "1" Then
                    txt_Sub.Text = L_Func.GF_GetAppInfo("FREE_MENU_NM") & "サブコース"

                    If blnCnt Then
                        btn_SMenu2.Visible = True
                        btn_SMenuID2.Visible = True
                        btn_SGOODSCD2.Visible = True
                        txt_number2.Visible = True
                        txt_unit2.Visible = True
                        txt_Sub.Visible = True
                        btn_SMenu2.Text = Trim$(objRows("SUB2NMJ")) & ControlChars.NewLine & Trim$(objRows("SUB2NMJ2"))
                        btn_SMenuID2.Text = Trim$(objRows("MENUID"))
                        btn_SGOODSCD2.Text = Trim$(objRows("SUB2GOODSCD"))
                    Else
                        btn_SMenu1.Visible = True
                        btn_SMenuID1.Visible = True
                        btn_SGOODSCD1.Visible = True
                        txt_number1.Visible = True
                        txt_unit1.Visible = True
                        txt_Sub.Visible = True
                        btn_SMenu1.Text = Trim$(objRows("SUB2NMJ")) & ControlChars.NewLine & Trim$(objRows("SUB2NMJ2"))
                        btn_SMenuID1.Text = Trim$(objRows("MENUID"))
                        btn_SGOODSCD1.Text = Trim$(objRows("SUB2GOODSCD"))
                    End If
                End If
            Else
                txt_Msg.Text = "【メニュー登録エラー】このサブメニューは使用できません"
            End If

        Catch
            Response.Redirect("./TP2990.html?CNWG060(LF_SetSubMenuBtn-3)")
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

        'ボタン色反転(初期値設定)
        btn_MMenu1.BackColor = Color.Empty
        btn_MMenu2.BackColor = Color.Empty
        btn_MMenu3.BackColor = Color.Empty

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
        lngRead = (lngPage - 1) * 3

        '------------------------------
        ' ページ遷移有無判定
        '------------------------------
        blnNext = False
        blnPrev = False
        If (((lngPage - 1) * 3) + 3) < pMENUCNT Then
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
        Call LF_SetMainMenuBtn()

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
        Call LF_SetMainMenuBtn()

    End Sub

    '' **************************************************
    ''  機能概要：[メインメニュー１]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_MMenu1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_MMenu1.Click

        'ボタン色反転
        btn_MMenu1.BackColor = Color.Pink
        btn_MMenu2.BackColor = Color.Empty
        btn_MMenu3.BackColor = Color.Empty

        Me.ViewState("DRINK_MENUID") = btn_MMenuID1.Text
        Me.ViewState("DRINK_GOODSCD") = ""

        txt_number1.Text = ""
        txt_number2.Text = ""

        Call LF_SetSubMenuBtn()

    End Sub

    '' **************************************************
    ''  機能概要：[メインメニュー２]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_MMenu2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_MMenu2.Click

        'ボタン色反転
        btn_MMenu1.BackColor = Color.Empty
        btn_MMenu2.BackColor = Color.Pink
        btn_MMenu3.BackColor = Color.Empty

        Me.ViewState("DRINK_MENUID") = btn_MMenuID2.Text
        Me.ViewState("DRINK_GOODSCD") = ""

        txt_number1.Text = ""
        txt_number2.Text = ""

        Call LF_SetSubMenuBtn()

    End Sub

    '' **************************************************
    ''  機能概要：[メインメニュー３]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_MMenu3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_MMenu3.Click

        'ボタン色反転
        btn_MMenu1.BackColor = Color.Empty
        btn_MMenu2.BackColor = Color.Empty
        btn_MMenu3.BackColor = Color.Pink

        Me.ViewState("DRINK_MENUID") = btn_MMenuID3.Text
        Me.ViewState("DRINK_GOODSCD") = ""

        txt_number1.Text = ""
        txt_number2.Text = ""

        Call LF_SetSubMenuBtn()

    End Sub

    '' **************************************************
    ''  機能概要：[サブメニュー１]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_SMenu1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_SMenu1.Click

        L_Iframe = "1"

        Me.ViewState("DRINK_GOODSCD") = btn_SGOODSCD1.Text

        Call LF_SetSubMenuBtn()

    End Sub

    '' **************************************************
    ''  機能概要：[サブメニュー２]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_SMenu2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_SMenu2.Click

        L_Iframe = "2"

        Me.ViewState("DRINK_GOODSCD") = btn_SGOODSCD2.Text

        Call LF_SetSubMenuBtn()

    End Sub

    '' **************************************************
    ''  機能概要：[決定]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_Set_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Set.Click
        'インナーフレーム表示時は各種ボタンプロテクト
        Call LS_ButtonProtect()

        btn_true.Visible = True
        btn_false.Visible = True
        tbl_Confirm.Visible = True
        lbl_Confirm.Visible = True
        lbl_Confirm.Text = "お通しします。よろしいですか？"
    End Sub

    '' **************************************************
    ''  機能概要：[戻る]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_Prev2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Prev2.Click
        L_BtnPrev = True
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
            Response.Redirect("./TP2990.html?CNWG060(LF_GetOrderStatus-1)")
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If
        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG060(LF_GetOrderStatus-2)")
            Exit Function
        End If

        LF_GetOrderStatus = Trim$(objRow("ORDERSTATUS"))
        Me.ViewState("ORDERSTATUS") = LF_GetOrderStatus

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG060(LF_GetOrderStatus-3)")
        Exit Function
    End Function

    '' **************************************************
    ''  機能概要：<body>にonLoadイベントを出力する。
    ''  引    数：
    ''  戻 り 値：
    '' **************************************************
    Public Sub OnInitBody()
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        strSQL = ""
        strSQL = strSQL & "SELECT POSITION FROM TPM050"
        strSQL = strSQL & "       WHERE TERMKIND = 'TC9'"
        strSQL = strSQL & "         AND TERMID = '" & Trim$(Request.UserHostAddress) & "'"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG060(OnInitBody-1)")
            Exit Sub
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Sub
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG060(OnInitBody-2)")
            Exit Sub
        End If

        If L_BtnBack Then
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
    End Sub

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
            Response.Redirect("./TP2990.html?CNWG060(LF_GetMenuName-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG060(LF_GetMenuName-2)")
            Exit Function
        End If

        LF_GetMenuName = Trim$(objRow("MENUNM"))
    End Function

    Public Sub LS_IframeWrite()
        Dim strHTML As String
        strHTML = ""

        If Not L_Iframe = "0" Then
            strHTML = "<iframe src=""CNWG070.aspx?SMenu=" & L_Iframe
            strHTML = strHTML & """ id=""F_CNWG060"" height=""430"" width=""470"" align=""middle"" style=""Z-INDEX: 200; LEFT: 85px; POSITION: absolute; TOP: 122px"" frameBorder=""1"" scrolling=""no""></iframe>"
        End If

        Response.Write(strHTML)
    End Sub

    Private Sub LS_ButtonProtect()
        'インナーフレーム表示時は各種ボタンプロテクト
        btn_MMenu1.Attributes("ONCLICK") = "return false"
        btn_MMenu2.Attributes("ONCLICK") = "return false"
        btn_MMenu3.Attributes("ONCLICK") = "return false"
        btn_SMenu1.Attributes("ONCLICK") = "return false"
        btn_SMenu2.Attributes("ONCLICK") = "return false"
        btn_Prev.Attributes("ONCLICK") = "return false"
        btn_Next.Attributes("ONCLICK") = "return false"
        btn_Set.Attributes("ONCLICK") = "return false"
        btn_Prev2.Attributes("ONCLICK") = "return false"
        btn_back.Attributes("ONCLICK") = "return false"
    End Sub

    Private Sub LS_ButtonNotProtect()
        'インナーフレーム表示時は各種ボタン非プロテクト
        btn_MMenu1.Attributes("ONCLICK") = "return true"
        btn_MMenu2.Attributes("ONCLICK") = "return true"
        btn_MMenu3.Attributes("ONCLICK") = "return true"
        btn_SMenu1.Attributes("ONCLICK") = "return true"
        btn_SMenu2.Attributes("ONCLICK") = "return true"
        btn_Prev.Attributes("ONCLICK") = "return true"
        btn_Next.Attributes("ONCLICK") = "return true"
        btn_Set.Attributes("ONCLICK") = "return true"
        btn_Prev2.Attributes("ONCLICK") = "return true"
        btn_back.Attributes("ONCLICK") = "parent.fWinClose();"
    End Sub

    Private Sub btn_true_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_true.Click
        Dim i As Integer        '' 繰返しカウンタ
        Dim strTERMID As String = Nothing '' 端末識別ID
        Dim lngORDERNO As Long  '' オーダー連番
        Dim lngPERSONNUMBER1 As Long  '' 人数(飲み放題メニュー１)
        Dim lngPERSONNUMBER2 As Long  '' 人数(飲み放題メニュー２)

        '人数未入力の場合は0を設定
        If Len(Trim$(txt_number1.Text)) <> 0 Then
            lngPERSONNUMBER1 = CLng(Trim$(txt_number1.Text))
        Else
            lngPERSONNUMBER1 = 0
        End If

        If Len(Trim$(txt_number2.Text)) <> 0 Then
            lngPERSONNUMBER2 = CLng(Trim$(txt_number2.Text))
        Else
            lngPERSONNUMBER2 = 0
        End If

        '人数がゼロはだめ
        If lngPERSONNUMBER1 = 0 And lngPERSONNUMBER2 = 0 Then
            txt_Msg.Text = "【入力エラー】人数を設定して下さい。"
            btn_true.Visible = False
            btn_false.Visible = False
            tbl_Confirm.Visible = False
            lbl_Confirm.Visible = False

            'インナーフレーム表示時は各種ボタン非プロテクト
            Call LS_ButtonNotProtect()

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
        For i = 0 To 12
            If CheckSTNsend() Then
                Exit For
            End If

            If i <> 12 Then
                Sleep(1000)
            Else
                txt_Msg.Text = "お会計を済ませてください。"
                btn_true.Visible = False
                btn_false.Visible = False
                tbl_Confirm.Visible = False
                lbl_Confirm.Visible = False

                'インナーフレーム表示時は各種ボタン非プロテクト
                Call LS_ButtonNotProtect()

                Exit Sub
            End If
        Next i

        '座席番号管理マスタ更新（TPM050）
        Call LF_SetSQLTPM050()

        '宴会メニュー登録（TPM010,TPM011）
        Call LF_SetSQLTPD010_2(strTERMID, lngORDERNO, Request.QueryString("GOODSCD"), lngPERSONNUMBER1 + lngPERSONNUMBER2)

        '飲み放題メニュー１登録（TPM010,TPM011）
        Call LF_SetSQLTPD010_2(strTERMID, lngORDERNO, btn_SGOODSCD1.Text, lngPERSONNUMBER1)

        '飲み放題メニュー２登録（TPM010,TPM011）
        Call LF_SetSQLTPD010_2(strTERMID, lngORDERNO, btn_SGOODSCD2.Text, lngPERSONNUMBER2)

        txt_Msg.Text = "お通しを受付ました。"

        btn_Set.Enabled = False
        btn_true.Visible = False
        btn_false.Visible = False
        tbl_Confirm.Visible = False
        lbl_Confirm.Visible = False

        L_BtnBack = True
    End Sub

    Private Sub btn_false_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_false.Click
        'インナーフレーム表示時は各種ボタン非プロテクト
        Call LS_ButtonNotProtect()

        btn_true.Visible = False
        btn_false.Visible = False
        tbl_Confirm.Visible = False
        lbl_Confirm.Visible = False
    End Sub

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
            Response.Redirect("./TP2990.html?CNWG060(LF_GetOrderNo_1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG060(LF_GetOrderNo_3)")
            Exit Function
        End If

        LF_GetOrderNo = CLng(objRow("ORDERNO"))
    End Function

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
            Response.Redirect("./TP2990.html?CNWG060(LF_GetTermID-1)")
            Exit Function
        End If

        If objDataSet.Tables("com").Rows.Count <= pINDEX Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objDataSet, pINDEX, objDataRow) Then
            Response.Redirect("./TP2990.html?CNWG060(LF_GetTermID-2)")
            Exit Function
        End If

        pTERMID = Trim$(objDataRow("TERMID"))
        LF_GetTermID = True
    End Function

    Private Function LF_SetSQLTPD010(ByVal pTERMID As String, ByVal pORDERNO As Long) As Object

        LF_SetSQLTPD010 = Nothing

        Dim strSQL As String
        Dim datNow As Date
        Dim lngPERSONNUMBER As Long

        datNow = Now

        If Len(Trim$(txt_number1.Text)) <> 0 Then
            lngPERSONNUMBER = CLng(Trim$(txt_number1.Text))
        Else
            lngPERSONNUMBER = 0
        End If

        If Len(Trim$(txt_number2.Text)) <> 0 Then
            lngPERSONNUMBER = lngPERSONNUMBER + CLng(Trim$(txt_number2.Text))
        End If

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPD010 VALUES("
        strSQL = strSQL & "'" & RSet(Request.QueryString("SEATID"), 5) & "', "                  '座席番号
        strSQL = strSQL & pORDERNO & ", "                                                       'オーダー連番
        strSQL = strSQL & "'" & pTERMID & "', "                                                 '端末識別ID
        strSQL = strSQL & "'" & Trim$(Me.ViewState("OPEN_GOODSCD")) & "', "                     '商品ID
        strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                                  '商品選択日時
        strSQL = strSQL & "0, "                                                                 '注文受付日時
        strSQL = strSQL & "0, "                                                                 'ステーション配信日時
        strSQL = strSQL & "0, "                                                                 '数量
        strSQL = strSQL & "'00', "                                                              '指示ステータス位置１
        strSQL = strSQL & "'000', "                                                             'SCPｺｰﾄﾞ１
        strSQL = strSQL & "'0000', "                                                            'SCPﾒﾆｭｰ１
        strSQL = strSQL & "0, "                                                                 'SCP数量１
        strSQL = strSQL & "'00', "                                                              '指示ステータス位置２
        strSQL = strSQL & "'000', "                                                             'SCPｺｰﾄﾞ２
        strSQL = strSQL & "'0000', "                                                            'SCPﾒﾆｭｰ２
        strSQL = strSQL & "0, "                                                                 'SCP数量２
        strSQL = strSQL & "'00', "                                                              '指示ステータス位置３
        strSQL = strSQL & "'000', "                                                             'SCPｺｰﾄﾞ３
        strSQL = strSQL & "'0000', "                                                            'SCPﾒﾆｭｰ３
        strSQL = strSQL & "0, "                                                                 'SCP数量３
        strSQL = strSQL & "'00', "                                                              '指示ステータス位置４
        strSQL = strSQL & "'000', "                                                             'SCPｺｰﾄﾞ４
        strSQL = strSQL & "'0000', "                                                            'SCPﾒﾆｭｰ４
        strSQL = strSQL & "0, "                                                                 'SCP数量４
        strSQL = strSQL & "'0', "                                                               'オーダー種別
        strSQL = strSQL & "'0', "                                                               '商品分類
        strSQL = strSQL & "'00', "                                                              '注文フラグ
        strSQL = strSQL & "'000.000.000.000', "                                                 '厨房端末識別ID
        strSQL = strSQL & lngPERSONNUMBER & ", "                                                'お通し人数
        strSQL = strSQL & "'CNWG001', "                                                          '更新者
        strSQL = strSQL & "GETDATE())"                                                          '更新日

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
        strSQL = strSQL & "'" & RSet(Request.QueryString("SEATID"), 5) & "', "                  '座席番号
        strSQL = strSQL & pORDERNO & ", "                                                       'オーダー連番
        strSQL = strSQL & "'" & pTERMID & "', "                                                 '端末識別ID
        strSQL = strSQL & "'" & Trim$(Me.ViewState("OPEN_GOODSCD")) & "', "                     '商品ID
        strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                                  '商品選択日時
        strSQL = strSQL & "0, "                                                                 '注文受付日時
        strSQL = strSQL & "0, "                                                                 'ステーション配信日時
        strSQL = strSQL & "0, "                                                                 '数量
        strSQL = strSQL & "'00', "                                                              '指示ステータス位置１
        strSQL = strSQL & "'000', "                                                             'SCPｺｰﾄﾞ１
        strSQL = strSQL & "'0000', "                                                            'SCPﾒﾆｭｰ１
        strSQL = strSQL & "0, "                                                                 'SCP数量１
        strSQL = strSQL & "'00', "                                                              '指示ステータス位置２
        strSQL = strSQL & "'000', "                                                             'SCPｺｰﾄﾞ２
        strSQL = strSQL & "'0000', "                                                            'SCPﾒﾆｭｰ２
        strSQL = strSQL & "0, "                                                                 'SCP数量２
        strSQL = strSQL & "'00', "                                                              '指示ステータス位置３
        strSQL = strSQL & "'000', "                                                             'SCPｺｰﾄﾞ３
        strSQL = strSQL & "'0000', "                                                            'SCPﾒﾆｭｰ３
        strSQL = strSQL & "0, "                                                                 'SCP数量３
        strSQL = strSQL & "'00', "                                                              '指示ステータス位置４
        strSQL = strSQL & "'000', "                                                             'SCPｺｰﾄﾞ４
        strSQL = strSQL & "'0000', "                                                            'SCPﾒﾆｭｰ４
        strSQL = strSQL & "0, "                                                                 'SCP数量４
        strSQL = strSQL & "'0', "                                                               'オーダー種別
        strSQL = strSQL & "'0', "                                                               '商品分類
        strSQL = strSQL & "'00', "                                                              '注文フラグ
        strSQL = strSQL & "'000.000.000.000', "                                                 '厨房端末識別ID
        strSQL = strSQL & lngPERSONNUMBER & ", "                                                'お通し人数
        strSQL = strSQL & "'0', "                                                               '出力先プリンタ
        strSQL = strSQL & "'CNWG001', "                                                          '更新者
        strSQL = strSQL & "GETDATE())"                                                          '更新日

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
        Response.Redirect("./TP2990.html?CNWG060(LF_SetSQLTPD010)")
        Exit Function
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

    Private Function LF_SetSQLTPM050() As Object

        LF_SetSQLTPM050 = Nothing

        Dim strSQL As String

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050"
        strSQL = strSQL & " SET ORDERSTATUS = '1',"                                     '端末状態フラグ
        strSQL = strSQL & "     SPMENU = '" & Request.QueryString("MENUID") & "',"      '指定メニューＩＤ
        strSQL = strSQL & "     SPMENU2 = '" & btn_SMenuID1.Text & "',"                 '指定メニューＩＤ２
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
        Response.Redirect("./TP2990.html?CNWG060(LF_SetSQLTPM050)")
        Exit Function
    End Function

    Private Function LF_SetSQLTPD010_2(ByVal pTERMID As String, ByVal pORDERNO As Long, ByVal pGOODSCD As String, ByVal pQUANTITY As Long) As Object

        LF_SetSQLTPD010_2 = Nothing

        Dim strSQL As String
        Dim datNow As Date
        Dim KCPNO() As String = Nothing
        Dim lngCnt As Long

        datNow = Now

        If Len(pGOODSCD) <> 0 And Len(pQUANTITY) <> 0 Then
            If pGOODSCD <> "0000" And pQUANTITY <> 0 Then
                'TPD011(INSERT文)
                strSQL = ""
                strSQL = strSQL & "INSERT INTO TPD010 VALUES("
                strSQL = strSQL & "'" & RSet(Request.QueryString("SEATID"), 5) & "', "      '座席番号
                strSQL = strSQL & pORDERNO & ", "                                           'オーダー連番
                strSQL = strSQL & "'" & pTERMID & "', "                                     '端末識別ID
                strSQL = strSQL & "'" & pGOODSCD & "', "                                    '商品ID
                strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                      '商品選択日時
                strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                      '注文受付日時
                strSQL = strSQL & "0, "                                                     'ステーション配信日時
                strSQL = strSQL & pQUANTITY & ", "                                          '数量
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

                If Not LF_GetKCPNO(Trim$(btn_SGOODSCD1.Text), KCPNO) Then
                    Exit Function
                End If
                For lngCnt = 0 To KCPNO.Length - 1
                    'TPD011(INSERT文)
                    strSQL = ""
                    strSQL = strSQL & "INSERT INTO TPD011 VALUES("
                    strSQL = strSQL & "'" & RSet(Request.QueryString("SEATID"), 5) & "', "      '座席番号
                    strSQL = strSQL & pORDERNO & ", "                                           'オーダー連番
                    strSQL = strSQL & "'" & pTERMID & "', "                                     '端末識別ID
                    strSQL = strSQL & "'" & pGOODSCD & "', "                                    '商品ID
                    strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                      '商品選択日時
                    strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                      '注文受付日時
                    strSQL = strSQL & "0, "                                                     'ステーション配信日時
                    strSQL = strSQL & pQUANTITY & ", "                                          '数量
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
        Response.Redirect("./TP2990.html?CNWG060(LF_SetSQLTPD010)")
        Exit Function
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
