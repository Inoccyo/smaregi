Partial Class CNWG022
    Inherits System.Web.UI.Page
    Protected WithEvents btn_table1_status As System.Web.UI.WebControls.Label
    Protected WithEvents btn_table2_status As System.Web.UI.WebControls.Label
    Protected WithEvents btn_table3_status As System.Web.UI.WebControls.Label
    Protected WithEvents btn_table4_status As System.Web.UI.WebControls.Label
    Protected WithEvents btn_table5_status As System.Web.UI.WebControls.Label

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

    Private L_Iframe As String
    Private L_Seat As System.Web.UI.WebControls.Button
    Private L_Func As TP2920
    Private L_Yobi As String

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' ページを初期化する ユーザー コードをここに挿入します。

        '------------------------------
        ' セッション状態確認
        '------------------------------
        If IsNothing(Session("TP")) Then
            L_Func = New TP2920()
            If Not L_Func.GF_Initialize() Then
                Response.Redirect("./TP2990.html?CNWG022(Page_Load-1)")
                Exit Sub
            End If
            Session("TP") = L_Func
        Else
            L_Func = Session("TP")
        End If

        ' お会計コード、お通しコードをTPM090から取得
        Me.ViewState("REG_GOODSCD") = L_Func.GF_GetAppInfo("REG_GOODSCD")       'お会計
        Me.ViewState("OPEN_GOODSCD") = L_Func.GF_GetAppInfo("OPEN_GOODSCD")     'お通し
        Me.ViewState("ALERT_TIME4") = L_Func.GF_GetAppInfo("ALERT_TIME4")       'メニュー切替機能(コースの警告表示前時間)

        If Trim$(Request.QueryString("MODE")) = "" Then
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")

        Else
            '端末設定画面からの遷移時
            Call LF_SetCNWGForm()
            Call LF_SetForm("1")
            Call LF_ParaPos()
            btn_refresh.Attributes("ONCLICK") = "fSetValue();"
            btn_back.Attributes("ONCLICK") = "fWinClosePos();"
        End If

        '------------------------------
        ' ポストバック時は処理対象外
        '------------------------------
        If IsPostBack Then
            Exit Sub
        End If

    End Sub

    Private Function LF_SetCNWGForm() As Object

        LF_SetCNWGForm = Nothing

        '端末設定画面からの遷移時
        '全てのテーブルの色を未設定にする
        table_1.BackColor = System.Drawing.Color.AliceBlue
        table_2.BackColor = System.Drawing.Color.AliceBlue
        table_3.BackColor = System.Drawing.Color.AliceBlue
        table_4.BackColor = System.Drawing.Color.AliceBlue
        table_5.BackColor = System.Drawing.Color.AliceBlue

        '全てのボタン文字を表示しない
        btn_table1.Text = ""
        btn_table2.Text = ""
        btn_table3.Text = ""
        btn_table4.Text = ""
        btn_table5.Text = ""

        '表示項目制御
        btn_back.Visible = True
        btn_cancel.Visible = True
        btn_refresh.Text = "設定"
        txt_Pos.Visible = True
        txt_Pos.Text = ""

        '遷移してきたテーブル位置
        txt_Pos.Text = Trim$(Request.QueryString("POS"))

    End Function

    Private Function LF_SetDefaultForm() As Object

        LF_SetDefaultForm = Nothing

        '全てのテーブルの色を未設定にする
        table_1.BackColor = System.Drawing.Color.AliceBlue
        table_2.BackColor = System.Drawing.Color.AliceBlue
        table_3.BackColor = System.Drawing.Color.AliceBlue
        table_4.BackColor = System.Drawing.Color.AliceBlue
        table_5.BackColor = System.Drawing.Color.AliceBlue

        '全てのボタンを非表示にする
        btn_table1.Visible = False
        btn_table2.Visible = False
        btn_table3.Visible = False
        btn_table4.Visible = False
        btn_table5.Visible = False

        '表示項目制御
        btn_back.Visible = False
        btn_cancel.Visible = False
        btn_refresh.Text = "更新"
        txt_Pos.Visible = False

    End Function

    Public Function LF_SetForm(ByVal pstrMode As String) As Object

        LF_SetForm = Nothing

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim i As Integer
        Dim intCnt As Integer
        Dim objButton As System.Web.UI.WebControls.Button = Nothing
        Dim objTable As System.Web.UI.WebControls.Table = Nothing
        Dim objHdnButton As System.Web.UI.WebControls.Button = Nothing  ' --- まいもん寿司 滞留時間表示対応 追加 ---
        Dim FlgPotision As Boolean

        'TPM050を検索し、客席に設定されている端末を表示
        strSQL = ""
        strSQL = strSQL & "SELECT SEATID, ORDERSTATUS, SEATCOLOR, POSITION"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE TERMKIND = 'TC0' or TERMKIND = 'TCA' or TERMKIND = 'TCB'"
        strSQL = strSQL & " ORDER BY POSITION, ORDERSTATUS DESC"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
            Exit Function
        End If

        intCnt = objData.Tables("com").Rows.Count

        If intCnt = 0 Then
            Exit Function
        End If
        For i = 0 To intCnt - 1
            If Not L_Func.GF_GetRows(objData, i, objRow) Then
                GoTo SYSTEM_ERROR
            End If

            FlgPotision = False

            Select Case objRow("POSITION").ToString
                Case "16"
                    objButton = btn_table1
                    objHdnButton = hdn_btn_table1  ' --- 滞留時間表示対応 追加 ---
                    objTable = table_1
                    FlgPotision = True
                Case "17"
                    objButton = btn_table2
                    objHdnButton = hdn_btn_table2  ' --- 滞留時間表示対応 追加 ---
                    objTable = table_2
                    FlgPotision = True
                Case "18"
                    objButton = btn_table3
                    objHdnButton = hdn_btn_table3  ' --- 滞留時間表示対応 追加 ---
                    objTable = table_3
                    FlgPotision = True
                Case "19"
                    objButton = btn_table4
                    objHdnButton = hdn_btn_table4  ' --- 滞留時間表示対応 追加 ---
                    objTable = table_4
                    FlgPotision = True
                Case "20"
                    objButton = btn_table5
                    objHdnButton = hdn_btn_table5  ' --- 滞留時間表示対応 追加 ---
                    objTable = table_5
                    FlgPotision = True

                Case Else

            End Select

            'ボタン、テーブルの表示内容（色など）設定
            If Trim$(pstrMode) = "0" Then
                '客席状況確認画面
                If FlgPotision = True Then
                    Call LF_SetButton(objButton, objTable, objHdnButton, objRow("SEATID"), Trim$(objRow("ORDERSTATUS")), Trim$(objRow("SEATCOLOR")))  ' --- 滞留時間表示対応 変更 ---
                End If
            Else
                '端末設定画面からの遷移時
                objButton.Text = Trim$(objRow("SEATID"))
                objHdnButton.Text = Trim$(objRow("SEATID"))  ' --- 滞留時間表示対応 追加 ---
            End If

        Next


        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG022(LF_SetForm)")
        Exit Function
    End Function

    Private Function LF_SetButton(ByVal objButton As System.Web.UI.WebControls.Button, _
                                  ByVal objTable As System.Web.UI.WebControls.Table, _
                                  ByVal objHdnButton As System.Web.UI.WebControls.Button, _
                                  ByVal strSeatID As String, _
                                  ByVal strOrderStatus As String, _
                                  ByVal strColor As String) As Object  ' --- 滞留時間表示対応 変更 ---

        LF_SetButton = Nothing

        ' --- 滞留時間表示対応 追加 ---
        Dim StayTime As Long
        Dim OTOOSHI_TIME1 As Long
        Dim OTOOSHI_TIME2 As Long
        Dim OTOOSHI_TIME3 As Long
        Dim objData As New DataSet()

        'ボタンいろいろ設定
        With objButton

            'ボタン表示文字設定
            .Visible = True
            If Trim$(strOrderStatus) <> "2" Then

                StayTime = LF_GetStayTime(strSeatID)

                If LF_GetMenuID(strSeatID) Then
                    OTOOSHI_TIME1 = CLng(L_Func.GF_GetAppInfo("OTOOSHI_TIME4"))
                    OTOOSHI_TIME2 = CLng(L_Func.GF_GetAppInfo("OTOOSHI_TIME5"))
                    OTOOSHI_TIME3 = CLng(L_Func.GF_GetAppInfo("OTOOSHI_TIME6"))

                    If StayTime >= OTOOSHI_TIME1 Then
                        .BackColor = System.Drawing.Color.PaleTurquoise
                        .ForeColor = System.Drawing.Color.Black
                    End If

                    If StayTime > OTOOSHI_TIME2 Then
                        .BackColor = System.Drawing.Color.DeepSkyBlue
                        .ForeColor = System.Drawing.Color.White
                    End If

                    If StayTime > OTOOSHI_TIME3 Then
                        .BackColor = System.Drawing.Color.Blue
                        .ForeColor = System.Drawing.Color.White
                    End If
                Else
                    OTOOSHI_TIME1 = CLng(L_Func.GF_GetAppInfo("OTOOSHI_TIME1"))
                    OTOOSHI_TIME2 = CLng(L_Func.GF_GetAppInfo("OTOOSHI_TIME2"))
                    OTOOSHI_TIME3 = CLng(L_Func.GF_GetAppInfo("OTOOSHI_TIME3"))

                    If StayTime >= OTOOSHI_TIME1 Then
                        .BackColor = System.Drawing.Color.Pink
                        .ForeColor = System.Drawing.Color.Black
                    End If

                    If StayTime > OTOOSHI_TIME2 Then
                        .BackColor = System.Drawing.Color.HotPink
                        .ForeColor = System.Drawing.Color.Black
                    End If

                    If StayTime > OTOOSHI_TIME3 Then
                        .BackColor = System.Drawing.Color.Red
                        .ForeColor = System.Drawing.Color.White
                    End If
                End If

                'ボタン表示文字設定
                .Text = Trim$(strSeatID) & vbCrLf & "(" & StayTime & "分)"

                If Trim$(strOrderStatus) = "5" Then
                    .Text = Trim$(strSeatID) & vbCrLf & "ｾｯﾄ中"
                    .BackColor = System.Drawing.Color.Black
                    .ForeColor = System.Drawing.Color.White
                End If

            Else
                '空席の場合、ボタン色（グレー）
                .BackColor = System.Drawing.Color.WhiteSmoke
                .ForeColor = System.Drawing.Color.Black

                'ボタン表示文字設定
                .Text = Trim$(strSeatID)
            End If

        End With

        'テーブルの設定
        With objTable
            Select Case Trim$(strColor)
                Case "0"
                    'ピンク
                    .BackColor = System.Drawing.Color.Pink
                Case "1"
                    '青
                    .BackColor = System.Drawing.Color.Blue
                Case "2"
                    '赤
                    .BackColor = System.Drawing.Color.Red
                Case "3"
                    '紫
                    .BackColor = System.Drawing.Color.Purple
                Case "4"
                    'オレンジ
                    .BackColor = System.Drawing.Color.Orange
                Case "5"
                    '緑
                    .BackColor = System.Drawing.Color.Lime
                Case "6"
                    '黄色
                    .BackColor = System.Drawing.Color.Yellow
                Case "7"
                    '白色
                    .BackColor = System.Drawing.Color.White
                Case "8"
                    '黒色
                    .BackColor = System.Drawing.Color.Black
                Case "9"
                    '水色
                    .BackColor = System.Drawing.Color.Aqua
                Case Else
                    'オリーブ色
                    .BackColor = System.Drawing.Color.Olive
            End Select

        End With

        ' --- 滞留時間表示対応 追加 ---
        'HIDDENボタンの設定
        With objHdnButton
            'ボタン表示文字設定
            .Text = Trim$(strSeatID)
        End With

    End Function

    Public Sub LS_IframeWrite()

        Dim strHTML As String
        Dim strMenuID As String = Nothing
        Dim strGoodsCD As String = Nothing

        strHTML = ""

        If Len(Trim$(L_Iframe)) > 0 Then

            If Trim$(LF_GetOrderStatus) <> "2" Then
                strHTML = "<iframe src=""CNWG030.aspx?SEATID="
                strHTML = strHTML & L_Seat.Text
                strHTML = strHTML & "&BTN_STATUS="
                strHTML = strHTML & ViewState("BTN_STATUS" & L_Seat.Text)
                strHTML = strHTML & "&AlertMin=" & ViewState("AlertMin")
                strHTML = strHTML & """ id=""F_CNWG021"" height=""275"" width=""640"" align=""middle"" style=""Z-INDEX: 200; LEFT: 183px; POSITION: absolute; TOP: 180px"" frameBorder=""1"" scrolling=""no""></iframe>"
            Else
                Call LF_GetMenu(strMenuID, strGoodsCD)
                strHTML = "<iframe src=""CNWG050.aspx?SEATID="
                strHTML = strHTML & L_Seat.Text
                strHTML = strHTML & "&MENUID=" & strMenuID
                strHTML = strHTML & "&GOODSCD=" & strGoodsCD
                strHTML = strHTML & """ id=""F_CNWG021"" height=""675"" width=""640"" align=""middle"" style=""Z-INDEX: 200; LEFT: 183px; POSITION: absolute; TOP: 60px"" frameBorder=""1"" scrolling=""no""></iframe>"
            End If

        End If

        Response.Write(strHTML)

    End Sub

    ' 1項目のみ必要データを抽出する。
    ' (メニューID、GOODSCD(0000)を取得)
    Private Sub LF_GetMenu(ByRef strMenuID As String, ByRef strGoodsCD As String)

        Dim strSQL As String = Nothing
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        strSQL = strSQL & "SELECT '0000' AS GOODSCD,"
        strSQL = strSQL & "       DEFMENUID AS MENUID"
        strSQL = strSQL & "  FROM TPM040"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG022(LF_GetMenu_1)")
            Exit Sub
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Response.Redirect("./TP2990.html?CNWG022(LF_GetMenu_2)")
            Exit Sub
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG022(LF_GetMenu_3)")
            Exit Sub
        End If

        strMenuID = objRow("MENUID")
        strGoodsCD = objRow("GOODSCD")

    End Sub

    Private Sub btn_table1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table1.Click

        L_Seat = hdn_btn_table1
        If Trim$(LF_GetOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table1  ' --- 滞留時間表示対応 変更 ---
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "11"
            LS_SelectTablePos(btn_table1)
        End If

    End Sub

    Private Sub btn_table2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table2.Click

        L_Seat = hdn_btn_table2
        If Trim$(LF_GetOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table2  ' --- 滞留時間表示対応 変更 ---
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "12"
            LS_SelectTablePos(btn_table2)
        End If

    End Sub

    Private Sub btn_table3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table3.Click

        L_Seat = hdn_btn_table3
        If Trim$(LF_GetOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table3  ' --- 滞留時間表示対応 変更 ---
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "13"
            LS_SelectTablePos(btn_table3)
        End If

    End Sub

    Private Sub btn_table4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table4.Click

        L_Seat = hdn_btn_table4
        If Trim$(LF_GetOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table4  ' --- 滞留時間表示対応 変更 ---
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "14"
            LS_SelectTablePos(btn_table4)
        End If

    End Sub

    Private Sub btn_table5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table5.Click

        L_Seat = hdn_btn_table5
        If Trim$(LF_GetOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table5  ' --- 滞留時間表示対応 変更 ---
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "15"
            LS_SelectTablePos(btn_table5)
        End If

    End Sub

    Private Function LF_ParaPos() As Object

        LF_ParaPos = Nothing

        Dim objButton As System.Web.UI.WebControls.Button = Nothing

        If Trim$(Request.QueryString("POS")) <> "" Then
            Select Case Trim$(Request.QueryString("POS"))
                Case "16"
                    objButton = btn_table1
                Case "17"
                    objButton = btn_table2
                Case "18"
                    objButton = btn_table3
                Case "19"
                    objButton = btn_table4
                Case "20"
                    objButton = btn_table5
                Case "21"
                    'objButton = btn_table6
                Case "22"
                    'objButton = btn_table7
                Case "23"
                    'objButton = btn_table8
                Case "24"
                    'objButton = btn_table9
                Case "25"
                    'objButton = btn_table10
                Case Else
                    Exit Function
            End Select

            LS_SelectTablePos(objButton)

        End If

    End Function

    Private Sub LS_SelectTablePos(ByVal objButton As System.Web.UI.WebControls.Button)

        btn_table1.BackColor = System.Drawing.Color.Empty
        btn_table2.BackColor = System.Drawing.Color.Empty
        btn_table3.BackColor = System.Drawing.Color.Empty
        btn_table4.BackColor = System.Drawing.Color.Empty
        btn_table5.BackColor = System.Drawing.Color.Empty

        If objButton Is btn_cancel = False Then
            objButton.BackColor = System.Drawing.Color.Red
        End If

    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_Pos.Text = ""
        LS_SelectTablePos(btn_cancel)
    End Sub

    Private Sub LS_ButtonProtect()

        btn_table1.Attributes("ONCLICK") = "return false"
        btn_table2.Attributes("ONCLICK") = "return false"
        btn_table3.Attributes("ONCLICK") = "return false"
        btn_table4.Attributes("ONCLICK") = "return false"
        btn_table5.Attributes("ONCLICK") = "return false"

        btn_refresh.Attributes("ONCLICK") = "return false"

    End Sub

    Private Function LF_GetOrderStatus() As String
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetOrderStatus = ""

        strSQL = ""
        strSQL = strSQL & "SELECT ORDERSTATUS"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE SEATID = '" & RSet(L_Seat.Text, 5) & "'"
        strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCA'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCB' )"
        strSQL = strSQL & " ORDER BY ORDERSTATUS"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG022(LF_GetOrderStatus-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG022(LF_GetOrderStatus-2)")
            Exit Function
        End If

        LF_GetOrderStatus = Trim$(objRow("ORDERSTATUS"))

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG022(LF_GetOrderStatus-3)")
        Exit Function
    End Function

    Private Function LF_GetMenuID(ByVal pSeatID As String) As Boolean
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetMenuID = False

        strSQL = ""
        strSQL = strSQL & "SELECT TOP 1"
        strSQL = strSQL & "       TPM050.TERMID,"
        strSQL = strSQL & "       TPD010.ORDERNO,"
        strSQL = strSQL & "       TPD010.SELECTTIME"
        strSQL = strSQL & "  FROM TPD010, TPM050"
        strSQL = strSQL & " WHERE TPM050.SEATID = '" & pSeatID & "'"
        strSQL = strSQL & "   AND TPM050.SEATID = TPD010.SEATID"
        strSQL = strSQL & "   AND TPM050.TERMKIND IN ('TC0', 'TCA', 'TCB')"
        strSQL = strSQL & " ORDER BY TPD010.SELECTTIME DESC"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Exit Function
        End If


        strSQL = ""
        strSQL = strSQL & "SELECT TPD010.GOODSCD,"
        strSQL = strSQL & "       TPM180.DISPMENUID,"
        strSQL = strSQL & "       TPM180.FREEDRINKMENUID"
        strSQL = strSQL & "  FROM TPD010, TPM180"
        strSQL = strSQL & " WHERE TPD010.GOODSCD = TPM180.GOODSCD"
        strSQL = strSQL & "   AND TPD010.SEATID = '" & pSeatID & "'"
        strSQL = strSQL & "   AND TPD010.ORDERNO = '" & objRow("ORDERNO") & "'"
        strSQL = strSQL & "   AND TPD010.TERMID = '" & objRow("TERMID") & "'"

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

        If Len(objRow("GOODSCD")) > 0 Then
            LF_GetMenuID = True
        End If

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG022(LF_GetMenuID)")
        Exit Function
    End Function

    Private Function LF_GetStayTime(ByVal strSeatID As String) As Long
        Dim StayTime As Long
        Dim OrderTime As Date
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim Year As String
        Dim Month As String
        Dim Day As String
        Dim Hour As String
        Dim Minute As String
        Dim Second As String

        LF_GetStayTime = 0

        strSQL = ""
        strSQL = strSQL & "SELECT SELECTTIME"
        strSQL = strSQL & "  FROM TPD010"
        strSQL = strSQL & " WHERE SEATID  = '" & strSeatID & "'"
        strSQL = strSQL & "   AND GOODSCD = '" & Trim$(Me.ViewState("OPEN_GOODSCD")) & "'"
        strSQL = strSQL & " ORDER BY SELECTTIME DESC"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG022(LF_GetStayTime-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG022(LF_GetStayTime-2)")
            Exit Function
        End If

        Year = Mid(CStr(Trim$(objRow("SELECTTIME"))), 1, 4)
        Month = Mid(CStr(Trim$(objRow("SELECTTIME"))), 5, 2)
        Day = Mid(CStr(Trim$(objRow("SELECTTIME"))), 7, 2)
        Hour = Mid(CStr(Trim$(objRow("SELECTTIME"))), 9, 2)
        Minute = Mid(CStr(Trim$(objRow("SELECTTIME"))), 11, 2)
        Second = Mid(CStr(Trim$(objRow("SELECTTIME"))), 13, 2)

        OrderTime = CDate(Trim$(Format(Year & "/" & Month & "/" & Day & " " & Hour & ":" & Minute & ":" & Second)))
        StayTime = CLng(DateDiff(DateInterval.Minute, OrderTime, Now))

        LF_GetStayTime = StayTime
    End Function


    'SPMENUに設定済みの場合、コース時間と滞留時間チェック
    Public Function GF_Check_SPMENU2() As Object

        GF_Check_SPMENU2 = Nothing

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim intcnt As Integer

        strSQL = ""
        strSQL = strSQL & "SELECT SEATID,"
        strSQL = strSQL & "       SPMENU2,"
        strSQL = strSQL & "       POSITION"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE ORDERSTATUS <> '2'"
        strSQL = strSQL & "   AND SPMENU2 <> '000'"
        strSQL = strSQL & "   AND TERMKIND IN ('TC0', 'TCA', 'TCB')"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG022(GF_Check_SPMENU2-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        For intcnt = 0 To objData.Tables("com").Rows.Count - 1
            If Not L_Func.GF_GetRows(objData, intcnt, objRow) Then
                Exit Function
            End If

            Call LF_Check_AlertTime(LF_GetStayTime(objRow("SEATID")), objRow("SPMENU2"), objRow("SEATID"), objRow("POSITION"))
        Next intcnt
    End Function

    '滞留時間とコース時間をチェック
    Private Function LF_Check_AlertTime(ByVal pStayTime As String, ByVal pSPMENU2 As String, ByVal strSeatID As String, ByVal pPOSITION As String) As Object

        LF_Check_AlertTime = Nothing

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim AlertTime As Long
        Dim AlertMin As Long

        strSQL = ""
        strSQL = strSQL & "SELECT FREEDRINKTIME"
        strSQL = strSQL & "  FROM TPM170"
        strSQL = strSQL & " WHERE MENUID = '" & pSPMENU2 & "'"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG022(LF_Check_AlertTime-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG022(LF_Check_AlertTime-2)")
            Exit Function
        End If

        AlertTime = 0
        AlertTime = objRow("FREEDRINKTIME") - Me.ViewState("ALERT_TIME4")       '警告開始時間

        If AlertTime <= pStayTime Then                                          '警告開始時間と経過時間の比較

            If objRow("FREEDRINKTIME") <= pStayTime Then                        '終了時間と経過時間の比較
                '終了メッセージステータスセット
                ViewState("BTN_STATUS" & Trim$(strSeatID)) = "2"

            Else
                '確認メッセージステータスセット　１、３
                AlertMin = objRow("FREEDRINKTIME") - pStayTime
                ViewState("AlertMin") = AlertMin

                If LF_CheckOrderStatus(strSeatID) = "3" Then  'ステータス３なら通過
                    Exit Function
                End If

                ViewState("BTN_STATUS" & Trim$(strSeatID)) = "1"

            End If

            strSQL = ""
            strSQL = strSQL & " fAlert(" & pPOSITION & ");"

            Response.Write(strSQL)
        End If
    End Function

    Private Function LF_CheckOrderStatus(ByVal strSeatID As String) As String
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_CheckOrderStatus = ""

        strSQL = ""
        strSQL = strSQL & "SELECT ORDERSTATUS"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE SEATID = '" & strSeatID & "'"
        strSQL = strSQL & "   AND TERMKIND IN ('TC0', 'TCA', 'TCB')"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG022(LF_CheckOrderStatus-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG022(LF_CheckOrderStatus-2)")
            Exit Function
        End If

        LF_CheckOrderStatus = objRow("ORDERSTATUS")
    End Function
    ' ---------------------------------------------------------------

    Private Sub btn_Change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Change.Click
        Dim strSQL As String
        Dim strHTML As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim strPAGENO As String

        strSQL = ""
        strSQL = strSQL & "SELECT POSITION FROM TPM050"
        strSQL = strSQL & "       WHERE TERMKIND = 'TC9'"
        strSQL = strSQL & "         AND TERMID = '" & Trim$(Request.UserHostAddress) & "'"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG022(btn_Change_Click-1)")
            Exit Sub
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Sub
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG022(btn_Change_Click-2)")
            Exit Sub
        End If

        Select Case Trim$(objRow("POSITION"))
            Case "20"
                strPAGENO = "21"
            Case "21"
                strPAGENO = "22"
            Case "22"
                strPAGENO = "20"
            Case Else
                strPAGENO = "22"
        End Select

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050 SET TPM050.POSITION = '" & strPAGENO & "'"
        strSQL = strSQL & "       WHERE TERMKIND = 'TC9'"
        strSQL = strSQL & "         AND TERMID = '" & Trim$(Request.UserHostAddress) & "'"

        If Not L_Func.GF_BeginTrans Then
            Exit Sub
        End If

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Sub
        End If

        If Not L_Func.GF_CommitTrans Then
            Call L_Func.GF_RollbackTrans()
        End If

        Select Case strPAGENO
            Case "20"
                strHTML = "./CNWG021.aspx"
            Case "21"
                strHTML = "./CNWG022.aspx"
            Case "22"
                strHTML = "./CNWG020.aspx"
            Case Else
                strHTML = "./CNWG020.aspx"
        End Select

        Response.Redirect(strHTML)
    End Sub

    Public Function BTN_WRITE() As Object

        BTN_WRITE = Nothing

        Dim strSQL As String = Nothing

        strSQL = strSQL & "<TD ALIGN='middle'>"
        strSQL = strSQL & "<INPUT TYPE='button' VALUE='注文' Style='FONT-SIZE:12pt; WIDTH:122px; HEIGHT:50px; LEFT:511px; POSITION: absolute; TOP: 668px' onClick='fChangeKyakuAP();' ID=""btn_TPJ"" NAME=""btn_TPJ"">"
        strSQL = strSQL & "</TD>"

        Response.Write(strSQL)

    End Function

    Private Function LF_SetSQLTPM050(Optional ByVal pSeatID As String = "") As Object

        LF_SetSQLTPM050 = Nothing

        Dim strSQL As String

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050"

        If Me.ViewState("ORDERSTATUS") <> "2" Then

            strSQL = strSQL & " SET ORDERSTATUS = '2',"     '空席状態
            strSQL = strSQL & "     SPMENU      = '000',"                                    '指定メニューＩＤ　複数箇所出し機能対応
            strSQL = strSQL & "     SPMENU2     = '000',"                                    '指定メニューＩＤ　メニュー切替機能対応
            strSQL = strSQL & "     HISTORYFLG  = '0',"                                      'ヒストリーフラグ　マイナス伝票画面起動時は注文履歴参照不可能とする
        Else
            'お通し処理（お通し状態に更新）
            strSQL = strSQL & " SET ORDERSTATUS = '1',"                                      '端末状態フラグ
            strSQL = strSQL & "     SPMENU      = '" & Request.QueryString("MENUID") & "',"  '指定メニューＩＤ　複数箇所出し機能対応
        End If
        strSQL = strSQL & "  UPDID  = 'CNWG001',"                                             '更新者
        strSQL = strSQL & "  UPDYMD = GETDATE()"                                             '更新日
        strSQL = strSQL & " WHERE SEATID = '" & RSet(pSeatID, 5) & "'"
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
        Response.Redirect("./TP2990.html?CNWG022(LF_SetSQLTPM050)")
        Exit Function
    End Function

End Class
