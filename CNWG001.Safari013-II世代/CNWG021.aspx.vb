Partial Class CNWG021
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
    Private strOrderStatus As String
    Private Const SessionMsgName As String = "CNWG001.Msg"   '各画面のメッセージセッション変数名と同一である必要があります

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' ページを初期化する ユーザー コードをここに挿入します。

        '------------------------------
        ' セッション状態確認
        '------------------------------
        If IsNothing(Session("TP")) Then
            L_Func = New TP2920()
            If Not L_Func.GF_Initialize() Then
                Response.Redirect("./TP2990.html?CNWG020(Page_Load-1)")
                Exit Sub
            End If
            Session("TP") = L_Func
        Else
            L_Func = Session("TP")
        End If

        'If Request.QueryString("NOJUMP") <> "1" Then
        '    Call LF_ChgDspPage()
        'End If

        Me.ViewState("REG_GOODSCD") = L_Func.GF_GetAppInfo("REG_GOODSCD")       'お会計
        Me.ViewState("OPEN_GOODSCD") = L_Func.GF_GetAppInfo("OPEN_GOODSCD")     'お通し
        Me.ViewState("CALL_GOODSCD") = L_Func.GF_GetAppInfo("CALL_GOODSCD")
        Me.ViewState("ALERT_TIME4") = L_Func.GF_GetAppInfo("ALERT_TIME4")       'メニュー切替機能(コースの警告表示前時間)
        Me.ViewState("TPG_FLG") = L_Func.GF_GetAppInfo("TPG_FLG")
        Me.ViewState("ESPRO_KCPNO") = L_Func.GF_GetAppInfo("ESPRO_KCPNO")       '表示機連動用にORDERSTATUS追加　6：呼出中、7：会計中、8：呼出確認済、9：会計確認済

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

        '終了状態の時、CNWAへ遷移
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim strSQL As String

        strSQL = ""
        strSQL = strSQL & "SELECT CLMODE FROM TPM040"
        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG020(PageWrite-1)")
            Exit Sub
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Response.Redirect("./TP2990.html?CNWG020(PageWrite-2)")
            Exit Sub
        End If
        If Not Session("TP").GF_GetRows(objData, 0, objRows) Then
            Response.Redirect("./TP2990.html?CNWG020(PageWrite-3)")
            Exit Sub
        End If
        If Trim$(objRows("CLMODE")) = "1" Then
            Response.Redirect("/CNWA001/CNWA010.aspx")
            Exit Sub
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
        table_1.BackColor = System.Drawing.Color.White
        table_2.BackColor = System.Drawing.Color.White
        table_3.BackColor = System.Drawing.Color.White
        table_4.BackColor = System.Drawing.Color.White
        table_5.BackColor = System.Drawing.Color.White
        table_6.BackColor = System.Drawing.Color.White
        table_7.BackColor = System.Drawing.Color.White
        table_8.BackColor = System.Drawing.Color.White
        table_9.BackColor = System.Drawing.Color.White
        table_10.BackColor = System.Drawing.Color.White
        table_11.BackColor = System.Drawing.Color.White
        table_12.BackColor = System.Drawing.Color.White
        table_13.BackColor = System.Drawing.Color.White
        table_14.BackColor = System.Drawing.Color.White
        table_15.BackColor = System.Drawing.Color.White
        table_16.BackColor = System.Drawing.Color.White
        table_17.BackColor = System.Drawing.Color.White
        table_18.BackColor = System.Drawing.Color.White
        table_19.BackColor = System.Drawing.Color.White
        table_20.BackColor = System.Drawing.Color.White
        table_21.BackColor = System.Drawing.Color.White
        table_22.BackColor = System.Drawing.Color.White
        table_23.BackColor = System.Drawing.Color.White
        table_24.BackColor = System.Drawing.Color.White
        table_25.BackColor = System.Drawing.Color.White
        table_26.BackColor = System.Drawing.Color.White
        table_27.BackColor = System.Drawing.Color.White
        'table_28.BackColor = System.Drawing.Color.White
        'table_29.BackColor = System.Drawing.Color.White
        'table_30.BackColor = System.Drawing.Color.White
        'table_31.BackColor = System.Drawing.Color.White
        'table_32.BackColor = System.Drawing.Color.White
        'table_33.BackColor = System.Drawing.Color.White
        'table_34.BackColor = System.Drawing.Color.White
        'table_35.BackColor = System.Drawing.Color.White
        'table_36.BackColor = System.Drawing.Color.White
        'table_37.BackColor = System.Drawing.Color.White
        'table_38.BackColor = System.Drawing.Color.White
        'table_39.BackColor = System.Drawing.Color.White

        '全てのボタン文字を表示しない
        btn_table1.Text = ""
        btn_table2.Text = ""
        btn_table3.Text = ""
        btn_table4.Text = ""
        btn_table5.Text = ""
        btn_table6.Text = ""
        btn_table7.Text = ""
        btn_table8.Text = ""
        btn_table9.Text = ""
        btn_table10.Text = ""
        btn_table11.Text = ""
        btn_table12.Text = ""
        btn_table13.Text = ""
        btn_table14.Text = ""
        btn_table15.Text = ""
        btn_table16.Text = ""
        btn_table17.Text = ""
        btn_table18.Text = ""
        btn_table19.Text = ""
        btn_table20.Text = ""
        btn_table21.Text = ""
        btn_table22.Text = ""
        btn_table23.Text = ""
        btn_table24.Text = ""
        btn_table25.Text = ""
        btn_table26.Text = ""
        btn_table27.Text = ""
        'btn_table28.Text = ""
        'btn_table30.Text = ""
        'btn_table31.Text = ""
        'btn_table32.Text = ""
        'btn_table33.Text = ""
        'btn_table34.Text = ""
        'btn_table35.Text = ""
        'btn_table36.Text = ""
        'btn_table37.Text = ""
        'btn_table38.Text = ""
        'btn_table39.Text = ""

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
        table_1.BackColor = System.Drawing.Color.White
        table_2.BackColor = System.Drawing.Color.White
        table_3.BackColor = System.Drawing.Color.White
        table_4.BackColor = System.Drawing.Color.White
        table_5.BackColor = System.Drawing.Color.White
        table_6.BackColor = System.Drawing.Color.White
        table_7.BackColor = System.Drawing.Color.White
        table_8.BackColor = System.Drawing.Color.White
        table_9.BackColor = System.Drawing.Color.White
        table_10.BackColor = System.Drawing.Color.White
        table_11.BackColor = System.Drawing.Color.White
        table_12.BackColor = System.Drawing.Color.White
        table_13.BackColor = System.Drawing.Color.White
        table_14.BackColor = System.Drawing.Color.White
        table_15.BackColor = System.Drawing.Color.White
        table_16.BackColor = System.Drawing.Color.White
        table_17.BackColor = System.Drawing.Color.White
        table_18.BackColor = System.Drawing.Color.White
        table_19.BackColor = System.Drawing.Color.White
        table_20.BackColor = System.Drawing.Color.White
        table_21.BackColor = System.Drawing.Color.White
        table_22.BackColor = System.Drawing.Color.White
        table_23.BackColor = System.Drawing.Color.White
        table_24.BackColor = System.Drawing.Color.White
        table_25.BackColor = System.Drawing.Color.White
        table_26.BackColor = System.Drawing.Color.White
        table_27.BackColor = System.Drawing.Color.White
        'table_28.BackColor = System.Drawing.Color.White
        'table_29.BackColor = System.Drawing.Color.White
        'table_30.BackColor = System.Drawing.Color.White
        'table_31.BackColor = System.Drawing.Color.White
        'table_32.BackColor = System.Drawing.Color.White
        'table_33.BackColor = System.Drawing.Color.White
        'table_34.BackColor = System.Drawing.Color.White
        'table_35.BackColor = System.Drawing.Color.White
        'table_36.BackColor = System.Drawing.Color.White
        'table_37.BackColor = System.Drawing.Color.White
        'table_38.BackColor = System.Drawing.Color.White
        'table_39.BackColor = System.Drawing.Color.White

        '全てのボタンを非表示にする
        btn_table1.Visible = False
        btn_table2.Visible = False
        btn_table3.Visible = False
        btn_table4.Visible = False
        btn_table5.Visible = False
        btn_table6.Visible = False
        btn_table7.Visible = False
        btn_table8.Visible = False
        btn_table9.Visible = False
        btn_table10.Visible = False
        btn_table11.Visible = False
        btn_table12.Visible = False
        btn_table13.Visible = False
        btn_table14.Visible = False
        btn_table15.Visible = False
        btn_table16.Visible = False
        btn_table17.Visible = False
        btn_table18.Visible = False
        btn_table19.Visible = False
        btn_table20.Visible = False
        btn_table21.Visible = False
        btn_table22.Visible = False
        btn_table23.Visible = False
        btn_table24.Visible = False
        btn_table25.Visible = False
        btn_table26.Visible = False
        btn_table27.Visible = False
        'btn_table28.Visible = False
        'btn_table29.Visible = False
        'btn_table30.Visible = False
        'btn_table31.Visible = False
        'btn_table32.Visible = False
        'btn_table33.Visible = False
        'btn_table34.Visible = False
        'btn_table35.Visible = False
        'btn_table36.Visible = False
        'btn_table37.Visible = False
        'btn_table38.Visible = False
        'btn_table39.Visible = False
        call1.Visible = False
        call2.Visible = False
        call3.Visible = False
        call4.Visible = False
        call5.Visible = False
        call6.Visible = False

        '表示項目制御
        btn_back.Visible = False
        btn_cancel.Visible = False
        btn_refresh.Text = "更新"
        txt_Pos.Visible = False
        If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            lbl_call.Visible = True
        End If

    End Function

    Public Function LF_SetForm(ByVal pstrMode As String) As Object

        LF_SetForm = Nothing

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim i As Integer
        Dim intCnt As Integer
        Dim objButton As System.Web.UI.WebControls.Button = Nothing
        Dim objHdnButton As System.Web.UI.WebControls.Button = Nothing
        Dim objTable As System.Web.UI.WebControls.Table = Nothing
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


            'TP<「POSITION」と各ボタンの紐付け
            Select Case objRow("POSITION").ToString
                Case "11"
                    objButton = btn_table1
                    objHdnButton = hdn_btn_table1
                    objTable = table_1
                    FlgPotision = True
                Case "12"
                    objButton = btn_table2
                    objHdnButton = hdn_btn_table2
                    objTable = table_2
                    FlgPotision = True
                Case "13"
                    objButton = btn_table3
                    objHdnButton = hdn_btn_table3
                    objTable = table_3
                    FlgPotision = True
                Case "14"
                    objButton = btn_table4
                    objHdnButton = hdn_btn_table4
                    objTable = table_4
                    FlgPotision = True
                Case "15"
                    objButton = btn_table5
                    objHdnButton = hdn_btn_table5
                    objTable = table_5
                    FlgPotision = True
                Case "16"
                    objButton = btn_table6
                    objHdnButton = hdn_btn_table6
                    objTable = table_6
                    FlgPotision = True
                Case "17"
                    objButton = btn_table7
                    objHdnButton = hdn_btn_table7
                    objTable = table_7
                    FlgPotision = True
                Case "18"
                    objButton = btn_table8
                    objHdnButton = hdn_btn_table8
                    objTable = table_8
                    FlgPotision = True
                Case "19"
                    objButton = btn_table9
                    objHdnButton = hdn_btn_table9
                    objTable = table_9
                    FlgPotision = True
                Case "20"
                    objButton = btn_table10
                    objHdnButton = hdn_btn_table10
                    objTable = table_10
                    FlgPotision = True
                Case "21"
                    objButton = btn_table11
                    objHdnButton = hdn_btn_table11
                    objTable = table_11
                    FlgPotision = True
                Case "22"
                    objButton = btn_table12
                    objHdnButton = hdn_btn_table12
                    objTable = table_12
                    FlgPotision = True
                Case "23"
                    objButton = btn_table13
                    objHdnButton = hdn_btn_table13
                    objTable = table_13
                    FlgPotision = True
                Case "24"
                    objButton = btn_table14
                    objHdnButton = hdn_btn_table14
                    objTable = table_14
                    FlgPotision = True
                Case "25"
                    objButton = btn_table15
                    objHdnButton = hdn_btn_table15
                    objTable = table_15
                    FlgPotision = True
                Case "26"
                    objButton = btn_table16
                    objHdnButton = hdn_btn_table16
                    objTable = table_16
                    FlgPotision = True
                Case "27"
                    objButton = btn_table17
                    objHdnButton = hdn_btn_table17
                    objTable = table_17
                    FlgPotision = True
                Case "28"
                    objButton = btn_table18
                    objHdnButton = hdn_btn_table18
                    objTable = table_18
                    FlgPotision = True
                Case "29"
                    objButton = btn_table19
                    objHdnButton = hdn_btn_table19
                    objTable = table_19
                    FlgPotision = True
                Case "30"
                    objButton = btn_table20
                    objHdnButton = hdn_btn_table20
                    objTable = table_20
                    FlgPotision = True
                Case "31"
                    objButton = btn_table21
                    objHdnButton = hdn_btn_table21
                    objTable = table_21
                    FlgPotision = True
                Case "32"
                    objButton = btn_table22
                    objHdnButton = hdn_btn_table22
                    objTable = table_22
                    FlgPotision = True
                Case "33"
                    objButton = btn_table23
                    objHdnButton = hdn_btn_table23
                    objTable = table_23
                    FlgPotision = True
                Case "34"
                    objButton = btn_table24
                    objHdnButton = hdn_btn_table24
                    objTable = table_24
                    FlgPotision = True
                Case "35"
                    objButton = btn_table25
                    objHdnButton = hdn_btn_table25
                    objTable = table_25
                    FlgPotision = True
                Case "36"
                    objButton = btn_table26
                    objHdnButton = hdn_btn_table26
                    objTable = table_26
                    FlgPotision = True
                Case "37"
                    objButton = btn_table27
                    objHdnButton = hdn_btn_table27
                    objTable = table_27
                    FlgPotision = True
                    'Case "38"
                    '    objButton = btn_table28
                    '    objHdnButton = hdn_btn_table28
                    '    objTable = table_28
                    '    FlgPotision = True
                    'Case "39"
                    '    objButton = btn_table29
                    '    objHdnButton = hdn_btn_table29
                    '    objTable = table_29
                    '    FlgPotision = True
                    'Case "40"
                    '    objButton = btn_table30
                    '    objHdnButton = hdn_btn_table30
                    '    objTable = table_30
                    '    FlgPotision = True
                    'Case "41"
                    '    objButton = btn_table31
                    '    objHdnButton = hdn_btn_table31
                    '    objTable = table_31
                    '    FlgPotision = True
                    'Case "42"
                    '    objButton = btn_table32
                    '    objHdnButton = hdn_btn_table32
                    '    objTable = table_32
                    '    FlgPotision = True
                    'Case "43"
                    '    objButton = btn_table33
                    '    objHdnButton = hdn_btn_table33
                    '    objTable = table_33
                    '    FlgPotision = True
                    'Case "44"
                    '    objButton = btn_table34
                    '    objHdnButton = hdn_btn_table34
                    '    objTable = table_34
                    '    FlgPotision = True
                    'Case "45"
                    '    objButton = btn_table35
                    '    objHdnButton = hdn_btn_table35
                    '    objTable = table_35
                    '    FlgPotision = True
                    'Case "46"
                    '    objButton = btn_table36
                    '    objHdnButton = hdn_btn_table36
                    '    objTable = table_36
                    '    FlgPotision = True
                    'Case "47"
                    '    objButton = btn_table37
                    '    objHdnButton = hdn_btn_table37
                    '    objTable = table_37
                    '    FlgPotision = True
                    'Case "48"
                    '    objButton = btn_table38
                    '    objHdnButton = hdn_btn_table38
                    '    objTable = table_38
                    '    FlgPotision = True
                    'Case "49"
                    '    objButton = btn_table39
                    '    objHdnButton = hdn_btn_table39
                    '    objTable = table_39
                    '    FlgPotision = True
                Case Else

            End Select

            'ボタン、テーブルの表示内容（色など）設定
            If Trim$(pstrMode) = "0" Then
                '客席状況確認画面
                If FlgPotision = True Then
                    Call LF_SetButton(objButton, objTable, objHdnButton, objRow("SEATID"), Trim$(objRow("ORDERSTATUS")), Trim$(objRow("SEATCOLOR")))
                End If
            Else
                '端末設定画面からの遷移時
                objButton.Text = Trim$(objRow("SEATID"))
                objHdnButton.Text = Trim$(objRow("SEATID"))
            End If

        Next

        If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_DispStaff()
        End If

        'メッセージ初期化
        If Session(SessionMsgName) = "" Then
            txt_Msg.Text = ""
        Else
            txt_Msg.Text = Session(SessionMsgName).ToString
            Session(SessionMsgName) = ""
        End If

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG020(LF_SetForm)")
        Exit Function
    End Function

    Private Function LF_SetButton(ByVal objButton As System.Web.UI.WebControls.Button, _
                                  ByVal objTable As System.Web.UI.WebControls.Table, _
                                  ByVal objHdnButton As System.Web.UI.WebControls.Button, _
                                  ByVal strSeatID As String, _
                                  ByVal strOrderStatus As String, _
                                  ByVal strColor As String) As Object

        LF_SetButton = Nothing

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
                        .ForeColor = System.Drawing.Color.Black
                    End If
                End If

                If Trim$(strOrderStatus) = "5" Then
                    .Text = Trim$(strSeatID) & vbCrLf & "(会計)"
                    .BackColor = System.Drawing.Color.Black
                    .ForeColor = System.Drawing.Color.White
                Else
                    .Text = Trim$(strSeatID) & vbCrLf & "(" & StayTime & "分)"

                    '表示機オプション
                    If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" And LS_DispCustomer(strSeatID) Then
                        .Text = Trim$(strSeatID) & vbCrLf & "(呼出)"
                        .ForeColor = System.Drawing.Color.Black
                        .BackColor = System.Drawing.Color.AliceBlue
                    End If

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
                    '白
                    .BackColor = System.Drawing.Color.White
                Case "1"
                    '青
                    .BackColor = System.Drawing.Color.Blue
                Case "2"
                    'ピンク
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
                    .BackColor = System.Drawing.Color.AliceBlue
                Case "8"
                    '黒色
                    .BackColor = System.Drawing.Color.Black
                Case "9"
                    '水色
                    .BackColor = System.Drawing.Color.Aqua
                Case Else
                    'オリーブ
                    .BackColor = System.Drawing.Color.Olive
            End Select

        End With

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
                strHTML = strHTML & """ id=""F_CNWG020"" height=""168"" width=""1024"" align=""middle"" style=""Z-INDEX: 600; LEFT: 0px; POSITION: absolute; TOP: 600px"" frameBorder=""1"" scrolling=""no""></iframe>"
            Else
                Call LF_GetMenu(strMenuID, strGoodsCD)
                strHTML = "<iframe src=""CNWG050.aspx?SEATID="
                strHTML = strHTML & L_Seat.Text
                strHTML = strHTML & "&MENUID=" & strMenuID
                strHTML = strHTML & "&GOODSCD=" & strGoodsCD
                strHTML = strHTML & """ id=""F_CNWG020"" height=""168"" width=""1024"" align=""middle"" style=""Z-INDEX: 600; LEFT: 0px; POSITION: absolute; TOP: 600px"" frameBorder=""1"" scrolling=""no""></iframe>"
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
            Response.Redirect("./TP2990.html?CNWG020(LF_GetMenu_1)")
            Exit Sub
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetMenu_2)")
            Exit Sub
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetMenu_3)")
            Exit Sub
        End If

        strMenuID = objRow("MENUID")
        strGoodsCD = objRow("GOODSCD")

    End Sub
    Private Sub btn_table1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table1.Click
        L_Seat = hdn_btn_table1
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table1
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "11"
            LS_SelectTablePos(btn_table1)
        End If
    End Sub
    Private Sub btn_table2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table2.Click
        L_Seat = hdn_btn_table2
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table2
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "12"
            LS_SelectTablePos(btn_table2)
        End If
    End Sub
    Private Sub btn_table3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table3.Click
        L_Seat = hdn_btn_table3
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table3
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "13"
            LS_SelectTablePos(btn_table3)
        End If
    End Sub
    Private Sub btn_table4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table4.Click
        L_Seat = hdn_btn_table4
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table4
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "14"
            LS_SelectTablePos(btn_table4)
        End If
    End Sub
    Private Sub btn_table5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table5.Click
        L_Seat = hdn_btn_table5
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table5
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "15"
            LS_SelectTablePos(btn_table5)
        End If
    End Sub
    Private Sub btn_table6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table6.Click
        L_Seat = hdn_btn_table6
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table6
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "16"
            LS_SelectTablePos(btn_table6)
        End If
    End Sub
    Private Sub btn_table7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table7.Click
        L_Seat = hdn_btn_table7
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table7
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "17"
            LS_SelectTablePos(btn_table7)
        End If
    End Sub
    Private Sub btn_table8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table8.Click
        L_Seat = hdn_btn_table8
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table8
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "18"
            LS_SelectTablePos(btn_table8)
        End If
    End Sub
    Private Sub btn_table9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table9.Click
        L_Seat = hdn_btn_table9
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table9
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "19"
            LS_SelectTablePos(btn_table9)
        End If
    End Sub
    Private Sub btn_table10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table10.Click
        L_Seat = hdn_btn_table10
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table10
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "20"
            LS_SelectTablePos(btn_table10)
        End If
    End Sub
    Private Sub btn_table11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table11.Click
        L_Seat = hdn_btn_table11
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table11
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "21"
            LS_SelectTablePos(btn_table11)
        End If
    End Sub
    Private Sub btn_table12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table12.Click
        L_Seat = hdn_btn_table12
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table12
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "22"
            LS_SelectTablePos(btn_table12)
        End If
    End Sub
    Private Sub btn_table13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table13.Click
        L_Seat = hdn_btn_table13
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table13
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "23"
            LS_SelectTablePos(btn_table13)
        End If
    End Sub
    Private Sub btn_table14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table14.Click
        L_Seat = hdn_btn_table14
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table14
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "24"
            LS_SelectTablePos(btn_table14)
        End If
    End Sub
    Private Sub btn_table15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table15.Click
        L_Seat = hdn_btn_table15
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table15
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "25"
            LS_SelectTablePos(btn_table15)
        End If
    End Sub
    Private Sub btn_table16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table16.Click
        L_Seat = hdn_btn_table16
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table16
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "26"
            LS_SelectTablePos(btn_table16)
        End If
    End Sub
    Private Sub btn_table17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table17.Click
        L_Seat = hdn_btn_table17
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table17
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "27"
            LS_SelectTablePos(btn_table17)
        End If
    End Sub
    Private Sub btn_table18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table18.Click
        L_Seat = hdn_btn_table18
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table18
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "28"
            LS_SelectTablePos(btn_table18)
        End If
    End Sub
    Private Sub btn_table19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table19.Click
        L_Seat = hdn_btn_table19
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table19
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "29"
            LS_SelectTablePos(btn_table19)
        End If
    End Sub
    Private Sub btn_table20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table20.Click
        L_Seat = hdn_btn_table20
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table20
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "30"
            LS_SelectTablePos(btn_table20)
        End If
    End Sub
    Private Sub btn_table21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table21.Click
        L_Seat = hdn_btn_table21
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table21
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "31"
            LS_SelectTablePos(btn_table21)
        End If
    End Sub
    Private Sub btn_table22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table22.Click
        L_Seat = hdn_btn_table22
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table22
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "32"
            LS_SelectTablePos(btn_table22)
        End If
    End Sub
    Private Sub btn_table23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table23.Click
        L_Seat = hdn_btn_table23
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table23
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "33"
            LS_SelectTablePos(btn_table23)
        End If
    End Sub
    Private Sub btn_table24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table24.Click
        L_Seat = hdn_btn_table24
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table24
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "34"
            LS_SelectTablePos(btn_table24)
        End If
    End Sub
    Private Sub btn_table25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table25.Click
        L_Seat = hdn_btn_table25
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table25
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "35"
            LS_SelectTablePos(btn_table25)
        End If
    End Sub
    Private Sub btn_table26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table26.Click
        L_Seat = hdn_btn_table26
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table26
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "36"
            LS_SelectTablePos(btn_table26)
        End If
    End Sub
    Private Sub btn_table27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table27.Click
        L_Seat = hdn_btn_table27
        strOrderStatus = LF_GetOrderStatus()
        If Trim$(strOrderStatus) = "5" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Exit Sub
        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub
        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
            '精算連動無し、お通し処理
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If
        If Trim$(Request.QueryString("MODE")) = "" Then
            L_Iframe = "1"
            L_Seat = hdn_btn_table27
            'インナーフレーム表示時はボタンプロテクト
            Call LS_ButtonProtect()
        Else
            txt_Pos.Text = "37"
            LS_SelectTablePos(btn_table27)
        End If
    End Sub
    'Private Sub btn_table28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table28.Click
    '    L_Seat = hdn_btn_table28
    '    strOrderStatus = LF_GetOrderStatus()
    '    If Trim$(strOrderStatus) = "5" Then
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetDefaultForm() 'ボタン初期化
    '        Call LF_SetForm("0")
    '        '表示機オプション
    '        If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '            Call LS_Update_TPD500(L_Seat.Text, "2")
    '        End If
    '        Exit Sub
    '    ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '        Call LS_Update_TPD500(L_Seat.Text, "1")
    '        Exit Sub
    '    ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
    '        '精算連動無し、お通し処理
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetSQLTPD010(L_Seat.Text)
    '        Call LF_SetDefaultForm()
    '        Call LF_SetForm("0")
    '        Exit Sub
    '    End If
    '    If Trim$(Request.QueryString("MODE")) = "" Then
    '        L_Iframe = "1"
    '        L_Seat = hdn_btn_table28
    '        'インナーフレーム表示時はボタンプロテクト
    '        Call LS_ButtonProtect()
    '    Else
    '        txt_Pos.Text = "38"
    '        LS_SelectTablePos(btn_table28)
    '    End If
    'End Sub
    'Private Sub btn_table29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table29.Click
    '    L_Seat = hdn_btn_table29
    '    strOrderStatus = LF_GetOrderStatus()
    '    If Trim$(strOrderStatus) = "5" Then
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetDefaultForm() 'ボタン初期化
    '        Call LF_SetForm("0")
    '        '表示機オプション
    '        If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '            Call LS_Update_TPD500(L_Seat.Text, "2")
    '        End If
    '        Exit Sub
    '    ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '        Call LS_Update_TPD500(L_Seat.Text, "1")
    '        Exit Sub
    '    ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
    '        '精算連動無し、お通し処理
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetSQLTPD010(L_Seat.Text)
    '        Call LF_SetDefaultForm()
    '        Call LF_SetForm("0")
    '        Exit Sub
    '    End If
    '    If Trim$(Request.QueryString("MODE")) = "" Then
    '        L_Iframe = "1"
    '        L_Seat = hdn_btn_table29
    '        'インナーフレーム表示時はボタンプロテクト
    '        Call LS_ButtonProtect()
    '    Else
    '        txt_Pos.Text = "39"
    '        LS_SelectTablePos(btn_table29)
    '    End If
    'End Sub
    'Private Sub btn_table30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table30.Click
    '    L_Seat = hdn_btn_table30
    '    strOrderStatus = LF_GetOrderStatus()
    '    If Trim$(strOrderStatus) = "5" Then
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetDefaultForm() 'ボタン初期化
    '        Call LF_SetForm("0")
    '        '表示機オプション
    '        If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '            Call LS_Update_TPD500(L_Seat.Text, "2")
    '        End If
    '        Exit Sub
    '    ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '        Call LS_Update_TPD500(L_Seat.Text, "1")
    '        Exit Sub
    '    ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
    '        '精算連動無し、お通し処理
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetSQLTPD010(L_Seat.Text)
    '        Call LF_SetDefaultForm()
    '        Call LF_SetForm("0")
    '        Exit Sub
    '    End If
    '    If Trim$(Request.QueryString("MODE")) = "" Then
    '        L_Iframe = "1"
    '        L_Seat = hdn_btn_table30
    '        'インナーフレーム表示時はボタンプロテクト
    '        Call LS_ButtonProtect()
    '    Else
    '        txt_Pos.Text = "40"
    '        LS_SelectTablePos(btn_table30)
    '    End If
    'End Sub
    'Private Sub btn_table31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table31.Click
    '    L_Seat = hdn_btn_table31
    '    strOrderStatus = LF_GetOrderStatus()
    '    If Trim$(strOrderStatus) = "5" Then
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetDefaultForm() 'ボタン初期化
    '        Call LF_SetForm("0")
    '        '表示機オプション
    '        If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '            Call LS_Update_TPD500(L_Seat.Text, "2")
    '        End If
    '        Exit Sub
    '    ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '        Call LS_Update_TPD500(L_Seat.Text, "1")
    '        Exit Sub
    '    ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
    '        '精算連動無し、お通し処理
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetSQLTPD010(L_Seat.Text)
    '        Call LF_SetDefaultForm()
    '        Call LF_SetForm("0")
    '        Exit Sub
    '    End If
    '    If Trim$(Request.QueryString("MODE")) = "" Then
    '        L_Iframe = "1"
    '        L_Seat = hdn_btn_table31
    '        'インナーフレーム表示時はボタンプロテクト
    '        Call LS_ButtonProtect()
    '    Else
    '        txt_Pos.Text = "41"
    '        LS_SelectTablePos(btn_table31)
    '    End If
    'End Sub
    'Private Sub btn_table32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table32.Click
    '    L_Seat = hdn_btn_table32
    '    strOrderStatus = LF_GetOrderStatus()
    '    If Trim$(strOrderStatus) = "5" Then
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetDefaultForm() 'ボタン初期化
    '        Call LF_SetForm("0")
    '        '表示機オプション
    '        If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '            Call LS_Update_TPD500(L_Seat.Text, "2")
    '        End If
    '        Exit Sub
    '    ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '        Call LS_Update_TPD500(L_Seat.Text, "1")
    '        Exit Sub
    '    ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
    '        '精算連動無し、お通し処理
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetSQLTPD010(L_Seat.Text)
    '        Call LF_SetDefaultForm()
    '        Call LF_SetForm("0")
    '        Exit Sub
    '    End If
    '    If Trim$(Request.QueryString("MODE")) = "" Then
    '        L_Iframe = "1"
    '        L_Seat = hdn_btn_table32
    '        'インナーフレーム表示時はボタンプロテクト
    '        Call LS_ButtonProtect()
    '    Else
    '        txt_Pos.Text = "42"
    '        LS_SelectTablePos(btn_table32)
    '    End If
    'End Sub
    'Private Sub btn_table33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table33.Click
    '    L_Seat = hdn_btn_table33
    '    strOrderStatus = LF_GetOrderStatus()
    '    If Trim$(strOrderStatus) = "5" Then
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetDefaultForm() 'ボタン初期化
    '        Call LF_SetForm("0")
    '        '表示機オプション
    '        If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '            Call LS_Update_TPD500(L_Seat.Text, "2")
    '        End If
    '        Exit Sub
    '    ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '        Call LS_Update_TPD500(L_Seat.Text, "1")
    '        Exit Sub
    '    ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
    '        '精算連動無し、お通し処理
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetSQLTPD010(L_Seat.Text)
    '        Call LF_SetDefaultForm()
    '        Call LF_SetForm("0")
    '        Exit Sub
    '    End If
    '    If Trim$(Request.QueryString("MODE")) = "" Then
    '        L_Iframe = "1"
    '        L_Seat = hdn_btn_table33
    '        'インナーフレーム表示時はボタンプロテクト
    '        Call LS_ButtonProtect()
    '    Else
    '        txt_Pos.Text = "43"
    '        LS_SelectTablePos(btn_table33)
    '    End If
    'End Sub
    'Private Sub btn_table34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table34.Click
    '    L_Seat = hdn_btn_table34
    '    strOrderStatus = LF_GetOrderStatus()
    '    If Trim$(strOrderStatus) = "5" Then
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetDefaultForm() 'ボタン初期化
    '        Call LF_SetForm("0")
    '        '表示機オプション
    '        If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '            Call LS_Update_TPD500(L_Seat.Text, "2")
    '        End If
    '        Exit Sub
    '    ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '        Call LS_Update_TPD500(L_Seat.Text, "1")
    '        Exit Sub
    '    ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
    '        '精算連動無し、お通し処理
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetSQLTPD010(L_Seat.Text)
    '        Call LF_SetDefaultForm()
    '        Call LF_SetForm("0")
    '        Exit Sub
    '    End If
    '    If Trim$(Request.QueryString("MODE")) = "" Then
    '        L_Iframe = "1"
    '        L_Seat = hdn_btn_table34
    '        'インナーフレーム表示時はボタンプロテクト
    '        Call LS_ButtonProtect()
    '    Else
    '        txt_Pos.Text = "44"
    '        LS_SelectTablePos(btn_table34)
    '    End If
    'End Sub
    'Private Sub btn_table35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table35.Click
    '    L_Seat = hdn_btn_table35
    '    strOrderStatus = LF_GetOrderStatus()
    '    If Trim$(strOrderStatus) = "5" Then
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetDefaultForm() 'ボタン初期化
    '        Call LF_SetForm("0")
    '        '表示機オプション
    '        If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '            Call LS_Update_TPD500(L_Seat.Text, "2")
    '        End If
    '        Exit Sub
    '    ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '        Call LS_Update_TPD500(L_Seat.Text, "1")
    '        Exit Sub
    '    ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
    '        '精算連動無し、お通し処理
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetSQLTPD010(L_Seat.Text)
    '        Call LF_SetDefaultForm()
    '        Call LF_SetForm("0")
    '        Exit Sub
    '    End If
    '    If Trim$(Request.QueryString("MODE")) = "" Then
    '        L_Iframe = "1"
    '        L_Seat = hdn_btn_table35
    '        'インナーフレーム表示時はボタンプロテクト
    '        Call LS_ButtonProtect()
    '    Else
    '        txt_Pos.Text = "45"
    '        LS_SelectTablePos(btn_table35)
    '    End If
    'End Sub
    'Private Sub btn_table36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table36.Click
    '    L_Seat = hdn_btn_table36
    '    strOrderStatus = LF_GetOrderStatus()
    '    If Trim$(strOrderStatus) = "5" Then
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetDefaultForm() 'ボタン初期化
    '        Call LF_SetForm("0")
    '        '表示機オプション
    '        If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '            Call LS_Update_TPD500(L_Seat.Text, "2")
    '        End If
    '        Exit Sub
    '    ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '        Call LS_Update_TPD500(L_Seat.Text, "1")
    '        Exit Sub
    '    ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
    '        '精算連動無し、お通し処理
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetSQLTPD010(L_Seat.Text)
    '        Call LF_SetDefaultForm()
    '        Call LF_SetForm("0")
    '        Exit Sub
    '    End If
    '    If Trim$(Request.QueryString("MODE")) = "" Then
    '        L_Iframe = "1"
    '        L_Seat = hdn_btn_table36
    '        'インナーフレーム表示時はボタンプロテクト
    '        Call LS_ButtonProtect()
    '    Else
    '        txt_Pos.Text = "46"
    '        LS_SelectTablePos(btn_table36)
    '    End If
    'End Sub
    'Private Sub btn_table37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table37.Click
    '    L_Seat = hdn_btn_table37
    '    strOrderStatus = LF_GetOrderStatus()
    '    If Trim$(strOrderStatus) = "5" Then
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetDefaultForm() 'ボタン初期化
    '        Call LF_SetForm("0")
    '        '表示機オプション
    '        If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '            Call LS_Update_TPD500(L_Seat.Text, "2")
    '        End If
    '        Exit Sub
    '    ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '        Call LS_Update_TPD500(L_Seat.Text, "1")
    '        Exit Sub
    '    ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
    '        '精算連動無し、お通し処理
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetSQLTPD010(L_Seat.Text)
    '        Call LF_SetDefaultForm()
    '        Call LF_SetForm("0")
    '        Exit Sub
    '    End If
    '    If Trim$(Request.QueryString("MODE")) = "" Then
    '        L_Iframe = "1"
    '        L_Seat = hdn_btn_table37
    '        'インナーフレーム表示時はボタンプロテクト
    '        Call LS_ButtonProtect()
    '    Else
    '        txt_Pos.Text = "47"
    '        LS_SelectTablePos(btn_table37)
    '    End If
    'End Sub
    'Private Sub btn_table38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table38.Click
    '    L_Seat = hdn_btn_table38
    '    strOrderStatus = LF_GetOrderStatus()
    '    If Trim$(strOrderStatus) = "5" Then
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetDefaultForm() 'ボタン初期化
    '        Call LF_SetForm("0")
    '        '表示機オプション
    '        If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '            Call LS_Update_TPD500(L_Seat.Text, "2")
    '        End If
    '        Exit Sub
    '    ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '        Call LS_Update_TPD500(L_Seat.Text, "1")
    '        Exit Sub
    '    ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
    '        '精算連動無し、お通し処理
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetSQLTPD010(L_Seat.Text)
    '        Call LF_SetDefaultForm()
    '        Call LF_SetForm("0")
    '        Exit Sub
    '    End If
    '    If Trim$(Request.QueryString("MODE")) = "" Then
    '        L_Iframe = "1"
    '        L_Seat = hdn_btn_table38
    '        'インナーフレーム表示時はボタンプロテクト
    '        Call LS_ButtonProtect()
    '    Else
    '        txt_Pos.Text = "48"
    '        LS_SelectTablePos(btn_table38)
    '    End If
    'End Sub
    'Private Sub btn_table39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table39.Click
    '    L_Seat = hdn_btn_table39
    '    strOrderStatus = LF_GetOrderStatus()
    '    If Trim$(strOrderStatus) = "5" Then
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetDefaultForm() 'ボタン初期化
    '        Call LF_SetForm("0")
    '        '表示機オプション
    '        If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '            Call LS_Update_TPD500(L_Seat.Text, "2")
    '        End If
    '        Exit Sub
    '    ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
    '        Call LS_Update_TPD500(L_Seat.Text, "1")
    '        Exit Sub
    '    ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" Then
    '        '精算連動無し、お通し処理
    '        Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
    '        Call LF_SetSQLTPD010(L_Seat.Text)
    '        Call LF_SetDefaultForm()
    '        Call LF_SetForm("0")
    '        Exit Sub
    '    End If
    '    If Trim$(Request.QueryString("MODE")) = "" Then
    '        L_Iframe = "1"
    '        L_Seat = hdn_btn_table39
    '        'インナーフレーム表示時はボタンプロテクト
    '        Call LS_ButtonProtect()
    '    Else
    '        txt_Pos.Text = "49"
    '        LS_SelectTablePos(btn_table39)
    '    End If
    'End Sub
    Private Function LF_ParaPos() As Object

        LF_ParaPos = Nothing

        Dim objButton As System.Web.UI.WebControls.Button

        If Trim$(Request.QueryString("POS")) <> "" Then
            Select Case Trim$(Request.QueryString("POS"))
                Case "11"
                    objButton = btn_table1
                Case "12"
                    objButton = btn_table2
                Case "13"
                    objButton = btn_table3
                Case "14"
                    objButton = btn_table4
                Case "15"
                    objButton = btn_table5
                Case "16"
                    objButton = btn_table6
                Case "17"
                    objButton = btn_table7
                Case "18"
                    objButton = btn_table8
                Case "19"
                    objButton = btn_table9
                Case "20"
                    objButton = btn_table10
                Case "21"
                    objButton = btn_table11
                Case "22"
                    objButton = btn_table12
                Case "23"
                    objButton = btn_table13
                Case "24"
                    objButton = btn_table14
                Case "25"
                    objButton = btn_table15
                Case "26"
                    objButton = btn_table16
                Case "27"
                    objButton = btn_table17
                Case "28"
                    objButton = btn_table18
                Case "29"
                    objButton = btn_table19
                Case "30"
                    objButton = btn_table20
                Case "31"
                    objButton = btn_table21
                Case "32"
                    objButton = btn_table22
                Case "33"
                    objButton = btn_table23
                Case "34"
                    objButton = btn_table24
                Case "35"
                    objButton = btn_table25
                Case "36"
                    objButton = btn_table26
                Case "37"
                    objButton = btn_table27
                    'Case "38"
                    '    objButton = btn_table28
                    'Case "39"
                    '    objButton = btn_table29
                    'Case "40"
                    '    objButton = btn_table30
                    'Case "41"
                    '    objButton = btn_table31
                    'Case "42"
                    '    objButton = btn_table32
                    'Case "43"
                    '    objButton = btn_table33
                    'Case "44"
                    '    objButton = btn_table34
                    'Case "45"
                    '    objButton = btn_table35
                    'Case "46"
                    '    objButton = btn_table36
                    'Case "47"
                    '    objButton = btn_table37
                    'Case "48"
                    '    objButton = btn_table38
                    'Case "49"
                    '    objButton = btn_table39
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
        btn_table6.BackColor = System.Drawing.Color.Empty
        btn_table7.BackColor = System.Drawing.Color.Empty
        btn_table8.BackColor = System.Drawing.Color.Empty
        btn_table9.BackColor = System.Drawing.Color.Empty
        btn_table10.BackColor = System.Drawing.Color.Empty
        btn_table11.BackColor = System.Drawing.Color.Empty
        btn_table12.BackColor = System.Drawing.Color.Empty
        btn_table13.BackColor = System.Drawing.Color.Empty
        btn_table14.BackColor = System.Drawing.Color.Empty
        btn_table15.BackColor = System.Drawing.Color.Empty
        btn_table16.BackColor = System.Drawing.Color.Empty
        btn_table17.BackColor = System.Drawing.Color.Empty
        btn_table18.BackColor = System.Drawing.Color.Empty
        btn_table19.BackColor = System.Drawing.Color.Empty
        btn_table20.BackColor = System.Drawing.Color.Empty
        btn_table22.BackColor = System.Drawing.Color.Empty
        btn_table23.BackColor = System.Drawing.Color.Empty
        btn_table24.BackColor = System.Drawing.Color.Empty
        btn_table25.BackColor = System.Drawing.Color.Empty
        btn_table26.BackColor = System.Drawing.Color.Empty
        btn_table27.BackColor = System.Drawing.Color.Empty
        'btn_table28.BackColor = System.Drawing.Color.Empty
        'btn_table29.BackColor = System.Drawing.Color.Empty
        'btn_table30.BackColor = System.Drawing.Color.Empty
        'btn_table31.BackColor = System.Drawing.Color.Empty
        'btn_table32.BackColor = System.Drawing.Color.Empty
        'btn_table33.BackColor = System.Drawing.Color.Empty
        'btn_table34.BackColor = System.Drawing.Color.Empty
        'btn_table35.BackColor = System.Drawing.Color.Empty
        'btn_table36.BackColor = System.Drawing.Color.Empty
        'btn_table37.BackColor = System.Drawing.Color.Empty
        'btn_table38.BackColor = System.Drawing.Color.Empty
        'btn_table39.BackColor = System.Drawing.Color.Empty
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
        btn_table6.Attributes("ONCLICK") = "return false"
        btn_table7.Attributes("ONCLICK") = "return false"
        btn_table8.Attributes("ONCLICK") = "return false"
        btn_table9.Attributes("ONCLICK") = "return false"
        btn_table10.Attributes("ONCLICK") = "return false"
        btn_table11.Attributes("ONCLICK") = "return false"
        btn_table12.Attributes("ONCLICK") = "return false"
        btn_table13.Attributes("ONCLICK") = "return false"
        btn_table14.Attributes("ONCLICK") = "return false"
        btn_table15.Attributes("ONCLICK") = "return false"
        btn_table16.Attributes("ONCLICK") = "return false"
        btn_table17.Attributes("ONCLICK") = "return false"
        btn_table18.Attributes("ONCLICK") = "return false"
        btn_table19.Attributes("ONCLICK") = "return false"
        btn_table20.Attributes("ONCLICK") = "return false"
        btn_table21.Attributes("ONCLICK") = "return false"
        btn_table22.Attributes("ONCLICK") = "return false"
        btn_table23.Attributes("ONCLICK") = "return false"
        btn_table24.Attributes("ONCLICK") = "return false"
        btn_table25.Attributes("ONCLICK") = "return false"
        btn_table26.Attributes("ONCLICK") = "return false"
        btn_table27.Attributes("ONCLICK") = "return false"
        'btn_table28.Attributes("ONCLICK") = "return false"
        'btn_table29.Attributes("ONCLICK") = "return false"
        'btn_table30.Attributes("ONCLICK") = "return false"
        'btn_table31.Attributes("ONCLICK") = "return false"
        'btn_table32.Attributes("ONCLICK") = "return false"
        'btn_table33.Attributes("ONCLICK") = "return false"
        'btn_table34.Attributes("ONCLICK") = "return false"
        'btn_table35.Attributes("ONCLICK") = "return false"
        'btn_table36.Attributes("ONCLICK") = "return false"
        'btn_table37.Attributes("ONCLICK") = "return false"
        'btn_table38.Attributes("ONCLICK") = "return false"
        'btn_table39.Attributes("ONCLICK") = "return false"
        'btn_refresh.Attributes("ONCLICK") = "return false"

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
            Response.Redirect("./TP2990.html?CNWG020(LF_GetOrderStatus-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetOrderStatus-2)")
            Exit Function
        End If

        LF_GetOrderStatus = Trim$(objRow("ORDERSTATUS"))

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG020(LF_GetOrderStatus-3)")
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
        Response.Redirect("./TP2990.html?CNWG020(LF_GetMenuID)")
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
            Response.Redirect("./TP2990.html?CNWG020(LF_GetStayTime-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetStayTime-2)")
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
    Public Function GF_Check_SPMENU2() As String

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
            Response.Redirect("./TP2990.html?CNWG020(GF_Check_SPMENU2-1)")
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
            Response.Redirect("./TP2990.html?CNWG020(LF_Check_AlertTime-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_Check_AlertTime-2)")
            Exit Function
        End If

        AlertTime = 0
        AlertTime = objRow("FREEDRINKTIME") - Me.ViewState("ALERT_TIME4")       '警告開始時間

        If AlertTime <= pStayTime Then                                          '警告開始時間と経過時間の比較

            If objRow("FREEDRINKTIME") <= pStayTime Then                        '終了時間と経過時間の比較

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
            Response.Redirect("./TP2990.html?CNWG020(LF_CheckOrderStatus-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_CheckOrderStatus-2)")
            Exit Function
        End If

        LF_CheckOrderStatus = objRow("ORDERSTATUS")
    End Function

    Private Function LF_ChgDspPage() As Object

        LF_ChgDspPage = Nothing

        Dim strSQL As String
        Dim strHTML As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        strSQL = ""
        strSQL = strSQL & "SELECT SEATID"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE TERMID = '" & Trim$(Request.UserHostAddress) & "'"
        strSQL = strSQL & "    AND TERMKIND = 'TC9'"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_CheckOrderStatus-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_CheckOrderStatus-2)")
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050 SET TPM050.POSITION = '" & Trim$(objRow("SEATID")) & "'"
        strSQL = strSQL & "       WHERE TERMKIND = 'TC9'"
        strSQL = strSQL & "         AND TERMID = '" & Trim$(Request.UserHostAddress) & "'"

        If Not L_Func.GF_BeginTrans Then
            Exit Function
        End If

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Function
        End If

        If Not L_Func.GF_CommitTrans Then
            Call L_Func.GF_RollbackTrans()
        End If

        strHTML = ""

        Select Case Trim$(objRow("SEATID"))
            Case "20"
                Exit Function
            Case "21"
                strHTML = "./CNWG021.aspx"
        End Select

        Response.Redirect(strHTML)

    End Function

    Private Sub btn_TPJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TPJ.Click

    End Sub

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
            Response.Redirect("./TP2990.html?CNWG020(LF_CheckOrderStatus-1)")
            Exit Sub
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Sub
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_CheckOrderStatus-2)")
            Exit Sub
        End If

        Select Case Trim$(objRow("POSITION"))
            Case "20"
                strPAGENO = "21"
            Case "21"
                strPAGENO = "20"
            Case Else
                strPAGENO = "21"
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
                strHTML = "./CNWG020.aspx"
            Case "21"
                strHTML = "./CNWG021.aspx?NOJUMP=1"
            Case Else
                strHTML = "./CNWG020.aspx"
        End Select

        Response.Redirect(strHTML)

    End Sub


    Public Function BTN_WRITE() As Object

        BTN_WRITE = Nothing

        Dim strHTML As String = Nothing
        Dim MyTermKind As String = Nothing

        If Not LF_GetTermKind(Request.UserHostAddress, MyTermKind) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_BTN_WRITE-1)")
            Exit Function
        End If

        If L_Func.GF_GetAppInfo("TPJ_ENABLE") <> 1 Then
            If MyTermKind <> "TCQ" Then
                strHTML = strHTML & "<TD ALIGN='middle'>"
                strHTML = strHTML & "<INPUT TYPE='button' VALUE='注文' Style='FONT-SIZE:16pt; WIDTH:90px; HEIGHT:35px; LEFT:820px; POSITION: absolute; TOP: 704px' onClick='fChangeKyakuAP();' ID=""btn_TPJ"" NAME=""btn_TPJ"">"
                strHTML = strHTML & "</TD>"
            End If
        End If

        If MyTermKind = "TCQ" Then
            strHTML = strHTML & "<TD ALIGN='middle'>"
            strHTML = strHTML & "<INPUT TYPE='button' VALUE='戻る' Style='FONT-SIZE:16pt; WIDTH:90px; HEIGHT:35px; LEFT:880px; POSITION: absolute; TOP: 704px' onClick = 'fChangeTPQ();' ID=""btn_back"" NAME=""btn_back"">"
            strHTML = strHTML & "</TD>"
        End If

        Response.Write(strHTML)

    End Function

    Private Function LF_SetSQLTPM050(ByVal OrderStatus As String, Optional ByVal pSeatID As String = "") As Object

        LF_SetSQLTPM050 = Nothing

        Dim strSQL As String
        Dim strMenuID As String = Nothing
        Dim strGoodsCD As String = Nothing

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050"

        If OrderStatus <> "2" Then

            strSQL = strSQL & " SET ORDERSTATUS = '2',"     '空席状態
            strSQL = strSQL & "     SPMENU      = '000',"                                    '指定メニューＩＤ　
            strSQL = strSQL & "     SPMENU2     = '000',"                                    '指定メニューＩＤ　
            strSQL = strSQL & "     HISTORYFLG  = '0',"                                      'ヒストリーフラグ　
        Else
            Call LF_GetMenu(strMenuID, strGoodsCD)
            'お通し処理（お通し状態に更新）
            strSQL = strSQL & " SET ORDERSTATUS = '1',"                                      '端末状態フラグ
            strSQL = strSQL & "     SPMENU      = '" & strMenuID & "',"  '指定メニューＩＤ　
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
        Response.Redirect("./TP2990.html?CNWG020(LF_SetSQLTPM050)")
        Exit Function
    End Function

    Private Function LF_SetSQLTPD010(ByVal SEATID As String) As Object

        LF_SetSQLTPD010 = Nothing

        Dim strSQL As String
        Dim datNow As Date
        Dim OrderNo As Long
        Dim TERMID As String

        datNow = Now
        OrderNo = LF_GetOrderNo(SEATID)
        TERMID = LF_GetTermID(SEATID)

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
        Response.Redirect("./TP2990.html?CNWG020(LF_SetSQLTPD010)")
        Exit Function
    End Function

    Private Function LF_GetTermID(ByVal SEATID As String) As String
        Dim strSQL As String        '' SQL実行文字列
        Dim objDataSet As DataSet   '' DataSetオブジェクト
        Dim objDataRow As DataRow = Nothing   '' DataRowオブジェクト

        LF_GetTermID = ""

        strSQL = ""
        strSQL = strSQL & "SELECT TERMID"
        strSQL = strSQL & " FROM TPM050"
        strSQL = strSQL & " WHERE SEATID = '" & RSet(SEATID, 5) & "'"
        strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCA'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCB') "
        strSQL = strSQL & " ORDER BY TERMID"

        objDataSet = New DataSet()
        If Not L_Func.GF_GetData(strSQL, objDataSet) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetTermID-1)")
            Exit Function
        End If

        If objDataSet.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objDataSet, 0, objDataRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetTermID-2)")
            Exit Function
        End If

        LF_GetTermID = Trim$(objDataRow("TERMID"))
    End Function

    Private Function LF_GetOrderNo(ByVal strSEATID As String) As Long
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetOrderNo = 0

        strSQL = ""
        strSQL = strSQL & "SELECT ORDERNO"
        strSQL = strSQL & "  FROM TPD010"
        strSQL = strSQL & " WHERE SEATID ='" & RSet(strSEATID, 5) & "'"
        strSQL = strSQL & " ORDER BY SELECTTIME DESC"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetOrderNo_1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetOrderNo_3)")
            Exit Function
        End If

        LF_GetOrderNo = CLng(objRow("ORDERNO")) + 1
    End Function

    Private Function LF_updTPD011(ByVal SEATID As String) As Object

        LF_updTPD011 = Nothing

        Dim strSQL As String
        Dim objData As New DataSet()

        strSQL = ""
        strSQL = strSQL & "UPDATE TPD011 SET ORDERFLG = '11'"
        strSQL = strSQL & " WHERE GOODSCD IN(" & Me.ViewState("CALL_GOODSCD") & ", " & Me.ViewState("REG_GOODSCD") & ")"
        strSQL = strSQL & "   AND TRANSTIME <> '0'"
        strSQL = strSQL & "   AND ORDERFLG NOT IN('11', '12')"
        strSQL = strSQL & "   AND KCPNO = '" & Me.ViewState("ESPRO_KCPNO") & "'"
        strSQL = strSQL & "   AND SEATID = '" & SEATID & "'"

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
SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG020(LF_updTPD011)")
    End Function

    Private Function LF_updTPM050(ByVal SEATID As String, ByVal ORDERSTAUTS As String) As Object

        LF_updTPM050 = Nothing

        Dim strSQL As String
        Dim objData As New DataSet()

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050"
        If ORDERSTAUTS = "6" Then
            strSQL = strSQL & "   SET ORDERSTATUS = '8'"
        ElseIf ORDERSTAUTS = "7" Then
            strSQL = strSQL & "   SET ORDERSTATUS = '9'"
        Else
            Exit Function
        End If

        strSQL = strSQL & " WHERE SEATID = '" & RSet(SEATID, 5) & "'"

        strSQL = strSQL & " AND TERMKIND IN ('TC0', 'TCA', 'TCB')"

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
        Response.Redirect("./TP2990.html?CNWG020(LF_updTPM050")
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：客席ボタン不可用、透明画像出力処理
    ' --------------------------------------------------------------------------------
    Public Sub ClearWrite()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim MyTermKind As String = Nothing

        '-----------------------------
        '自端末TERMKIND取得
        '-----------------------------
        If Not LF_GetTermKind(Request.UserHostAddress, MyTermKind) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_BTN_WRITE-1)")
            Exit Sub
        End If

        If MyTermKind = "TCQ" Then
            If L_Func.GF_GetAppInfo("SEAT_ENABLE") = 0 Then
                Response.Write("<div style=""Z-INDEX: 500; LEFT: 0px; POSITION: absolute; TOP: 50px""><img src=""./gif/SVGA64.gif"" width=1000 height=615></div>")
            End If
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：自端末TERMKIND取得
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTermKind(ByVal pIPAddr As String, ByRef pTermNo As String) As Boolean

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        '初期値設定
        '------------------------------
        LF_GetTermKind = False

        '------------------------------
        ' 自端末番号取得処理
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM050.TERMKIND"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE TPM050.TERMID   = '" & pIPAddr & "'"
        If Not L_Func.GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If
        If Not L_Func.GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pTermNo = Trim$(objRows("TERMKIND"))
        LF_GetTermKind = True

    End Function
    Private Sub call1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles call1.Click
        Call LS_Update_TPD500(call1.Text, "3", orderstatus1.Text)
    End Sub
    Private Sub call2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles call2.Click
        Call LS_Update_TPD500(call2.Text, "3", orderstatus2.Text)
    End Sub
    Private Sub call3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles call3.Click
        Call LS_Update_TPD500(call3.Text, "3", orderstatus3.Text)
    End Sub
    Private Sub call4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles call4.Click
        Call LS_Update_TPD500(call4.Text, "3", orderstatus4.Text)
    End Sub
    Private Sub call5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles call5.Click
        Call LS_Update_TPD500(call5.Text, "3", orderstatus5.Text)
    End Sub
    Private Sub call6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles call6.Click
        Call LS_Update_TPD500(call6.Text, "3", orderstatus6.Text)
    End Sub
    Private Sub LS_Update_TPD500(ByVal SEATID As String, ByVal ORDERFLG As String, Optional ByVal ORDERTIME As String = "")
        Dim strSQL As String
        strSQL = ""
        strSQL = strSQL & "UPDATE TPD500 SET"
        strSQL = strSQL & " TRANSTIME = '" & Format$(Now, "yyyyMMddHHmmss") & "',"
        'strSQL = strSQL & " ORDERSTATUS = '1',"
        strSQL = strSQL & " UPDID = 'CNWG001',"
        strSQL = strSQL & " UPDYMD = '" & Now & "'"
        strSQL = strSQL & " WHERE TRANSTIME = '0'"

        If ORDERTIME <> "" Then
            strSQL = strSQL & "   AND ORDERTIME = '" & ORDERTIME & "'"
        Else
            strSQL = strSQL & "   AND SEATID = '" & RSet(SEATID, 5) & "'"
        End If

        If ORDERFLG = "1" Then
            '客席　呼出消し込み
            strSQL = strSQL & "   AND ORDERFLG = '01'"
        ElseIf ORDERFLG = "2" Then
            '客席　会計消し込み
            strSQL = strSQL & "   AND ORDERFLG = '02'"
        ElseIf ORDERFLG = "3" Then
            '厨房　消し込み
            strSQL = strSQL & "   AND ORDERFLG IN ('11', '12')"
        End If
        strSQL = strSQL & "   AND ORDERSTATUS IN ('0', '1', '4')"

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
        Call LF_SetDefaultForm()
        Call LF_SetForm("0")
    End Sub
    Private Function LS_DispCustomer(ByVal strSEATID As String) As Boolean

        Dim strSQL As String
        Dim objData As New DataSet()

        LS_DispCustomer = False

        strSQL = ""
        strSQL = strSQL & "SELECT SEATID, ORDERFLG FROM TPD500"
        strSQL = strSQL & " WHERE SEATID = '" & RSet(strSEATID, 5) & "'"
        strSQL = strSQL & "   AND ORDERFLG = '01'"
        strSQL = strSQL & "   AND TRANSTIME = '0'"
        strSQL = strSQL & "   AND ORDERSTATUS IN ('0', '2')"
        strSQL = strSQL & " ORDER BY ORDERTIME"

        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        Else
            LS_DispCustomer = True
        End If

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG010(LS_DispCustomer)")
        Exit Function
    End Function
    Private Sub LS_DispStaff()

        Dim strSQL As String
        Dim i As Integer = 0
        Dim objData As New DataSet()
        Dim objRow As DataRow

        strSQL = ""
        strSQL = strSQL & "SELECT SEATID, ORDERFLG, ORDERTIME FROM TPD500"
        strSQL = strSQL & " WHERE ORDERFLG IN ('11', '12')"
        strSQL = strSQL & "   AND TRANSTIME = '0'"
        strSQL = strSQL & "   AND ORDERSTATUS IN ('0', '2')"
        strSQL = strSQL & " ORDER BY ORDERTIME"

        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Exit Sub
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Sub
        End If

        objRow = Nothing

        For i = 0 To objData.Tables("com").Rows.Count - 1

            If Not Session("TP").GF_GetRows(objData, i, objRow) Then
                GoTo SYSTEM_ERROR
            End If

            Select Case i
                Case 0
                    call1.Visible = True
                    call1.Text = Trim$(objRow("SEATID"))
                    call1.ForeColor = Color.Black
                    orderstatus1.Text = Trim$(objRow("ORDERTIME"))
                    If objRow("ORDERFLG") = "12" Then
                        call1.Text = "TO"
                        call1.ForeColor = Color.Red
                    End If
                Case 1
                    call2.Visible = True
                    call2.Text = Trim$(objRow("SEATID"))
                    call2.ForeColor = Color.Black
                    orderstatus2.Text = Trim$(objRow("ORDERTIME"))
                    If objRow("ORDERFLG") = "12" Then
                        call2.Text = "TO"
                        call2.ForeColor = Color.Red
                    End If
                Case 2
                    call3.Visible = True
                    call3.Text = Trim$(objRow("SEATID"))
                    call3.ForeColor = Color.Black
                    orderstatus3.Text = Trim$(objRow("ORDERTIME"))
                    If objRow("ORDERFLG") = "12" Then
                        call3.Text = "TO"
                        call3.ForeColor = Color.Red
                    End If
                Case 3
                    call4.Visible = True
                    call4.Text = Trim$(objRow("SEATID"))
                    call4.ForeColor = Color.Black
                    orderstatus4.Text = Trim$(objRow("ORDERTIME"))
                    If objRow("ORDERFLG") = "12" Then
                        call4.Text = "TO"
                        call4.ForeColor = Color.Red
                    End If
                Case 4
                    call5.Visible = True
                    call5.Text = Trim$(objRow("SEATID"))
                    call5.ForeColor = Color.Black
                    orderstatus5.Text = Trim$(objRow("ORDERTIME"))
                    If objRow("ORDERFLG") = "12" Then
                        call5.Text = "TO"
                        call5.ForeColor = Color.Red
                    End If
                Case 5
                    call6.Visible = True
                    call6.Text = Trim$(objRow("SEATID"))
                    call6.ForeColor = Color.Black
                    orderstatus6.Text = Trim$(objRow("ORDERTIME"))
                    If objRow("ORDERFLG") = "12" Then
                        call6.Text = "TO"
                        call6.ForeColor = Color.Red
                    End If
                Case Else
                    Exit Sub
            End Select

        Next

        Exit Sub

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWC010(LS_GetTPD500)")
        Exit Sub
    End Sub
End Class
