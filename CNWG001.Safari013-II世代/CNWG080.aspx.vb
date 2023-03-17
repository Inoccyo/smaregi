Partial Class CNWG080
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
    Private L_Seat As System.Web.UI.WebControls.Button
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
                Response.Redirect("./TP2990.html?CNWG080(Page_Load-1)")
                Exit Sub
            End If
            Session("TP") = L_Func
        Else
            L_Func = Session("TP")
        End If

        L_BtnBack = False

        '------------------------------
        ' 初期設定
        '------------------------------
        Call btn_protect()
        Call LF_SetDefaultForm()
        Call LF_SetForm()

        '------------------------------
        ' ポストバック時は処理対象外
        '------------------------------
        If IsPostBack Then
            Exit Sub
        End If

        Session(SessionMsgName) = ""
        lbl_head.Text = L_Func.GF_GetAppInfo2("SEAT_CLOSURE_MSG") & "行う座席番号を選択して下さい"

        If Request.QueryString("UPDID") <> Nothing Then
            LS_UpdSeatStatus(Request.QueryString("UPDID"))
        End If

    End Sub

    Private Sub btn_protect()
        btn_table1.Attributes.Add("ONCLICK", "return noBack();")
        btn_table2.Attributes.Add("ONCLICK", "return noBack();")
        btn_table3.Attributes.Add("ONCLICK", "return noBack();")
        btn_table4.Attributes.Add("ONCLICK", "return noBack();")
        btn_table5.Attributes.Add("ONCLICK", "return noBack();")
        btn_table6.Attributes.Add("ONCLICK", "return noBack();")
        btn_table7.Attributes.Add("ONCLICK", "return noBack();")
        btn_table8.Attributes.Add("ONCLICK", "return noBack();")
        btn_table9.Attributes.Add("ONCLICK", "return noBack();")
        btn_table10.Attributes.Add("ONCLICK", "return noBack();")
        btn_table11.Attributes.Add("ONCLICK", "return noBack();")
        btn_table12.Attributes.Add("ONCLICK", "return noBack();")
        btn_table13.Attributes.Add("ONCLICK", "return noBack();")
        btn_table14.Attributes.Add("ONCLICK", "return noBack();")
        btn_table15.Attributes.Add("ONCLICK", "return noBack();")
        btn_table16.Attributes.Add("ONCLICK", "return noBack();")
        btn_table17.Attributes.Add("ONCLICK", "return noBack();")
        btn_table18.Attributes.Add("ONCLICK", "return noBack();")
        btn_table19.Attributes.Add("ONCLICK", "return noBack();")
        btn_table20.Attributes.Add("ONCLICK", "return noBack();")
        btn_table21.Attributes.Add("ONCLICK", "return noBack();")
        btn_table22.Attributes.Add("ONCLICK", "return noBack();")
        btn_table23.Attributes.Add("ONCLICK", "return noBack();")
        btn_table24.Attributes.Add("ONCLICK", "return noBack();")
        btn_table25.Attributes.Add("ONCLICK", "return noBack();")
        btn_table26.Attributes.Add("ONCLICK", "return noBack();")
        btn_table27.Attributes.Add("ONCLICK", "return noBack();")
        btn_table28.Attributes.Add("ONCLICK", "return noBack();")
        btn_table29.Attributes.Add("ONCLICK", "return noBack();")
        btn_table30.Attributes.Add("ONCLICK", "return noBack();")
        btn_table31.Attributes.Add("ONCLICK", "return noBack();")
        btn_table32.Attributes.Add("ONCLICK", "return noBack();")
        btn_table33.Attributes.Add("ONCLICK", "return noBack();")
        btn_table34.Attributes.Add("ONCLICK", "return noBack();")
        btn_table35.Attributes.Add("ONCLICK", "return noBack();")
        btn_table36.Attributes.Add("ONCLICK", "return noBack();")
        btn_table37.Attributes.Add("ONCLICK", "return noBack();")
        btn_table38.Attributes.Add("ONCLICK", "return noBack();")
        btn_table39.Attributes.Add("ONCLICK", "return noBack();")
        btn_table40.Attributes.Add("ONCLICK", "return noBack();")
    End Sub

    Private Function LF_SetDefaultForm() As Object

        LF_SetDefaultForm = Nothing

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
        btn_table28.Visible = False
        btn_table29.Visible = False
        btn_table30.Visible = False
        btn_table31.Visible = False
        btn_table32.Visible = False
        btn_table33.Visible = False
        btn_table34.Visible = False
        btn_table35.Visible = False
        btn_table36.Visible = False
        btn_table37.Visible = False
        btn_table38.Visible = False
        btn_table39.Visible = False
        btn_table40.Visible = False

    End Function

    Public Function LF_SetForm() As Object

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
        strSQL = strSQL & "SELECT SEATID, ORDERSTATUS"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE TERMKIND IN ('TC0','TCA')"
        strSQL = strSQL & "   AND ORDERSTATUS = '2'"
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

            Select Case i + 1
                Case 1
                    objButton = btn_table1
                    objHdnButton = hdn_btn_table1
                    FlgPotision = True
                Case 2
                    objButton = btn_table2
                    objHdnButton = hdn_btn_table2
                    FlgPotision = True
                Case 3
                    objButton = btn_table3
                    objHdnButton = hdn_btn_table3
                    FlgPotision = True
                Case 4
                    objButton = btn_table4
                    objHdnButton = hdn_btn_table4
                    FlgPotision = True
                Case 5
                    objButton = btn_table5
                    objHdnButton = hdn_btn_table5
                    FlgPotision = True
                Case 6
                    objButton = btn_table6
                    objHdnButton = hdn_btn_table6
                    FlgPotision = True
                Case 7
                    objButton = btn_table7
                    objHdnButton = hdn_btn_table7
                    FlgPotision = True
                Case 8
                    objButton = btn_table8
                    objHdnButton = hdn_btn_table8
                    FlgPotision = True
                Case 9
                    objButton = btn_table9
                    objHdnButton = hdn_btn_table9
                    FlgPotision = True
                Case 10
                    objButton = btn_table10
                    objHdnButton = hdn_btn_table10
                    FlgPotision = True
                Case 11
                    objButton = btn_table11
                    objHdnButton = hdn_btn_table11
                    FlgPotision = True
                Case 12
                    objButton = btn_table12
                    objHdnButton = hdn_btn_table12
                    FlgPotision = True
                Case 13
                    objButton = btn_table13
                    objHdnButton = hdn_btn_table13
                    FlgPotision = True
                Case 14
                    objButton = btn_table14
                    objHdnButton = hdn_btn_table14
                    FlgPotision = True
                Case 15
                    objButton = btn_table15
                    objHdnButton = hdn_btn_table15
                    FlgPotision = True
                Case 16
                    objButton = btn_table16
                    objHdnButton = hdn_btn_table16
                    FlgPotision = True
                Case 17
                    objButton = btn_table17
                    objHdnButton = hdn_btn_table17
                    FlgPotision = True
                Case 18
                    objButton = btn_table18
                    objHdnButton = hdn_btn_table18
                    FlgPotision = True
                Case 19
                    objButton = btn_table19
                    objHdnButton = hdn_btn_table19
                    FlgPotision = True
                Case 20
                    objButton = btn_table20
                    objHdnButton = hdn_btn_table20
                    FlgPotision = True
                Case 21
                    objButton = btn_table21
                    objHdnButton = hdn_btn_table21
                    FlgPotision = True
                Case 22
                    objButton = btn_table22
                    objHdnButton = hdn_btn_table22
                    FlgPotision = True
                Case 23
                    objButton = btn_table23
                    objHdnButton = hdn_btn_table23
                    FlgPotision = True
                Case 24
                    objButton = btn_table24
                    objHdnButton = hdn_btn_table24
                    FlgPotision = True
                Case 25
                    objButton = btn_table25
                    objHdnButton = hdn_btn_table25
                    FlgPotision = True
                Case 26
                    objButton = btn_table26
                    objHdnButton = hdn_btn_table26
                    FlgPotision = True
                Case 27
                    objButton = btn_table27
                    objHdnButton = hdn_btn_table27
                    FlgPotision = True
                Case 28
                    objButton = btn_table28
                    objHdnButton = hdn_btn_table28
                    FlgPotision = True
                Case 29
                    objButton = btn_table29
                    objHdnButton = hdn_btn_table29
                    FlgPotision = True
                Case 30
                    objButton = btn_table30
                    objHdnButton = hdn_btn_table30
                    FlgPotision = True
                Case 31
                    objButton = btn_table31
                    objHdnButton = hdn_btn_table31
                    FlgPotision = True
                Case 32
                    objButton = btn_table32
                    objHdnButton = hdn_btn_table32
                    FlgPotision = True
                Case 33
                    objButton = btn_table33
                    objHdnButton = hdn_btn_table33
                    FlgPotision = True
                Case 34
                    objButton = btn_table34
                    objHdnButton = hdn_btn_table34
                    FlgPotision = True
                Case 35
                    objButton = btn_table35
                    objHdnButton = hdn_btn_table35
                    FlgPotision = True
                Case 36
                    objButton = btn_table36
                    objHdnButton = hdn_btn_table36
                    FlgPotision = True
                Case 37
                    objButton = btn_table37
                    objHdnButton = hdn_btn_table37
                    FlgPotision = True
                Case 38
                    objButton = btn_table38
                    objHdnButton = hdn_btn_table38
                    FlgPotision = True
                Case 39
                    objButton = btn_table39
                    objHdnButton = hdn_btn_table39
                    FlgPotision = True
                Case 40
                    objButton = btn_table40
                    objHdnButton = hdn_btn_table40
                    FlgPotision = True
                Case Else

            End Select

            If FlgPotision = True Then
                Call LF_SetButton(objButton, objTable, objHdnButton, objRow("SEATID"), Trim$(objRow("ORDERSTATUS")))
            End If
        Next

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG020(LF_SetForm)")
        Exit Function
    End Function

    Private Function LF_SetButton(ByVal objButton As System.Web.UI.WebControls.Button, _
                                   ByVal objTable As System.Web.UI.WebControls.Table, _
                                   ByVal objHdnButton As System.Web.UI.WebControls.Button, _
                                   ByVal strSeatID As String, _
                                   ByVal strOrderStatus As String) As Object

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

                OTOOSHI_TIME1 = CLng(L_Func.GF_GetAppInfo("OTOOSHI_TIME1"))
                OTOOSHI_TIME2 = CLng(L_Func.GF_GetAppInfo("OTOOSHI_TIME2"))
                OTOOSHI_TIME3 = CLng(L_Func.GF_GetAppInfo("OTOOSHI_TIME3"))

                If StayTime >= OTOOSHI_TIME1 Then
                    If L_Func.GF_ChkSeatSeting(strSeatID) = False Then
                        .BackColor = System.Drawing.Color.Yellow
                        .ForeColor = System.Drawing.Color.Black
                    Else
                        .BackColor = System.Drawing.Color.Pink
                        .ForeColor = System.Drawing.Color.Black
                    End If
                End If

                If StayTime > OTOOSHI_TIME2 Then
                    If L_Func.GF_ChkSeatSeting(strSeatID) = False Then
                        .BackColor = System.Drawing.Color.Yellow
                        .ForeColor = System.Drawing.Color.Black
                    Else
                        .BackColor = System.Drawing.Color.Pink
                        .ForeColor = System.Drawing.Color.Black
                    End If
                End If

                If StayTime > OTOOSHI_TIME3 Then
                    If L_Func.GF_ChkSeatSeting(strSeatID) = False Then
                        .BackColor = System.Drawing.Color.Yellow
                        .ForeColor = System.Drawing.Color.Black
                    Else
                        .BackColor = System.Drawing.Color.Pink
                        .ForeColor = System.Drawing.Color.Black
                    End If
                End If


                If Trim$(strOrderStatus) = "5" Then
                    .Text = Trim$(strSeatID) & vbCrLf & "(会計)"
                    .BackColor = System.Drawing.Color.Black
                    .ForeColor = System.Drawing.Color.White


                ElseIf Trim$(strOrderStatus) = "A" Then
                    .Text = Trim$(strSeatID) & vbCrLf & "(会計)"
                    .BackColor = System.Drawing.Color.Blue
                    .ForeColor = System.Drawing.Color.White

                ElseIf Trim$(strOrderStatus) = "C" Then
                    .Text = Trim$(strSeatID) & vbCrLf & "(" & L_Func.GF_GetAppInfo2("SEAT_CLOSURE_MSG") & ")"
                    .BackColor = Color.FromName(L_Func.GF_GetAppInfo2("SEAT_CLOSURE_COLOR1"))
                    .ForeColor = Color.FromName(L_Func.GF_GetAppInfo2("SEAT_CLOSURE_COLOR2"))

                Else
                    .Text = Trim$(strSeatID) & vbCrLf & "(" & StayTime & "分)"
                End If

            Else
                '空席の場合、ボタン色（グレー）
                .BackColor = System.Drawing.Color.WhiteSmoke
                .ForeColor = System.Drawing.Color.Black

                'ボタン表示文字設定
                .Text = Trim$(strSeatID)
            End If

        End With

        With objHdnButton
            'ボタン表示文字設定
            .Text = Trim$(strSeatID)
        End With

    End Function

    '******************************
    '2013.3 新規作成
    'IOS6.0対応
    '******************************
    Private Sub LS_UpdSeatStatus(ByVal pPOSITION As String)
        Dim strOrderStatus As String
        Dim strSQL As String
        Dim strMes As String

        Select Case pPOSITION
            Case "11"
                L_Seat = hdn_btn_table1
            Case "12"
                L_Seat = hdn_btn_table2
            Case "13"
                L_Seat = hdn_btn_table3
            Case "14"
                L_Seat = hdn_btn_table4
            Case "15"
                L_Seat = hdn_btn_table5
            Case "16"
                L_Seat = hdn_btn_table6
            Case "17"
                L_Seat = hdn_btn_table7
            Case "18"
                L_Seat = hdn_btn_table8
            Case "19"
                L_Seat = hdn_btn_table9
            Case "20"
                L_Seat = hdn_btn_table10
            Case "21"
                L_Seat = hdn_btn_table11
            Case "22"
                L_Seat = hdn_btn_table12
            Case "23"
                L_Seat = hdn_btn_table13
            Case "24"
                L_Seat = hdn_btn_table14
            Case "25"
                L_Seat = hdn_btn_table15
            Case "26"
                L_Seat = hdn_btn_table16
            Case "27"
                L_Seat = hdn_btn_table17
            Case "28"
                L_Seat = hdn_btn_table18
            Case "29"
                L_Seat = hdn_btn_table19
            Case "30"
                L_Seat = hdn_btn_table20
            Case "31"
                L_Seat = hdn_btn_table21
            Case "32"
                L_Seat = hdn_btn_table22
            Case "33"
                L_Seat = hdn_btn_table23
            Case "34"
                L_Seat = hdn_btn_table24
            Case "35"
                L_Seat = hdn_btn_table25
            Case "36"
                L_Seat = hdn_btn_table26
            Case "37"
                L_Seat = hdn_btn_table27
            Case "38"
                L_Seat = hdn_btn_table28
            Case "39"
                L_Seat = hdn_btn_table29
            Case "40"
                L_Seat = hdn_btn_table30
            Case "41"
                L_Seat = hdn_btn_table31
            Case "42"
                L_Seat = hdn_btn_table32
            Case "43"
                L_Seat = hdn_btn_table33
            Case "44"
                L_Seat = hdn_btn_table34
            Case "45"
                L_Seat = hdn_btn_table35
            Case "46"
                L_Seat = hdn_btn_table36
            Case "47"
                L_Seat = hdn_btn_table37
            Case "48"
                L_Seat = hdn_btn_table38
            Case "49"
                L_Seat = hdn_btn_table39
            Case "50"
                L_Seat = hdn_btn_table40
            Case Else
        End Select

        strOrderStatus = LF_GetOrderStatus()

        If Trim$(strOrderStatus) = "2" Then

            '閉鎖メッセージ取得
            strMes = L_Func.GF_GetAppInfo2("SEAT_CLOSURE_MSG")

            '客席状態更新
            strSQL = ""
            strSQL = strSQL & "UPDATE TPM050"
            strSQL = strSQL & " SET ORDERSTATUS = 'C',"                                     '端末状態フラグ
            strSQL = strSQL & "     UPDID = 'CNWG050',"                                      '更新者
            strSQL = strSQL & "     UPDYMD = GETDATE()"                                     '更新日
            strSQL = strSQL & " WHERE SEATID = '" & RSet(L_Seat.Text, 5) & "'"
            strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
            strSQL = strSQL & "   OR    TERMKIND = 'TCA'"
            strSQL = strSQL & "   OR    TERMKIND = 'TCB' )"

            If Not L_Func.GF_BeginTrans Then
                Session(SessionMsgName) = "【" & L_Seat.Text & "番席】の" & strMes & "処理に失敗しました。"
                Exit Sub
            End If

            If Not L_Func.GF_UpdData(strSQL) Then
                Call L_Func.GF_RollbackTrans()
                Session(SessionMsgName) = "【" & L_Seat.Text & "番席】の" & strMes & "処理に失敗しました。"
                Exit Sub
            End If

            If Not L_Func.GF_CommitTrans Then
                Call L_Func.GF_RollbackTrans()
                Session(SessionMsgName) = "【" & L_Seat.Text & "番席】の" & strMes & "処理に失敗しました。"
                Exit Sub
            End If

            Session(SessionMsgName) = "【" & L_Seat.Text & "番席】の" & strMes & "処理行いました。"

            L_BtnBack = True

        End If

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

    Public Sub OnInitBody()

        'マイナス伝票ボタン押下されていない場合
        If L_BtnBack Then
            Response.Write("onLoad='parent.fWinClose();'")
        End If
    End Sub

End Class
