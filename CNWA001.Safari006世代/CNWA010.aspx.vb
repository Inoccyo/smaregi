Partial Class CNWA010
    Inherits System.Web.UI.Page
    Protected WithEvents txt_pos As System.Web.UI.WebControls.TextBox

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
    Private L_Addscript As String
    Private Const LC_Floor_15 As String = "TC0"
    Private Const LC_Floor_12 As String = "TCA"
    Private Const LC_Floor_8 As String = "TCB"
    Private Const LC_Kitchen As String = "TC7"
    Private Const LC_Hanaita As String = "TCQ"
    Private Const LC_Contrl As String = "TC9"
    Private Const LC_Handy As String = "TCT"
    Private Const LC_Hyoujiki As String = "TC1"
    Private Const LC_Hakken As String = "TCS"
    Private Const LC_Tag As String = "TCU"
    ' --- (2018.12.20) 特急レーン連携 --------------
    Private Const LC_Hassha As String = "TCV"
    ' --- (2018.12.20) 特急レーン連携 --------------
    Private Const LC_Dishup As String = "TCV"
    ' --- (2019.03.24) デシャップ --------------
    ' --- (2019.05.23) 入店管理対応 --------------
    Private Const LC_Control2 As String = "TCG"
    ' --- (2019.05.23) 入店管理対応 --------------
    Private L_IframeMode As String
    Private L_IframeRet As String
    Private L_IframePos As String

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' ページを初期化する ユーザー コードをここに挿入します。

        '------------------------------
        ' セッション状態確認
        '------------------------------
        If IsNothing(Session("TP")) Then
            L_Func = New TP2920()
            If Not L_Func.GF_Initialize() Then
                Response.Redirect("./TP2990.html?CNWA010(Page_Load-1)")
                Exit Sub
            End If
            Session("TP") = L_Func
        Else
            L_Func = Session("TP")
        End If

        '------------------------------
        ' IPアドレス取得
        '------------------------------
        lbl_IP.Text = Request.UserHostAddress

        '端末区分をViewStateに設定
        Me.ViewState("TERMKIND") = LF_CheckTermKind()

        Select Case Me.ViewState("TERMKIND").ToString
            Case LC_Contrl
                lbl_status.Text = "座席管理"
                lbl_SeatName.Text = "座席"
            Case LC_Floor_15
                lbl_status.Text = "客席画面（WXGA）"
                lbl_SeatName.Text = "座席"
            Case LC_Floor_12
                lbl_status.Text = "客席画面（XGA）"
                lbl_SeatName.Text = "座席"
            Case LC_Floor_8
                lbl_status.Text = "テイクアウト"
                lbl_SeatName.Text = "端末"
            Case LC_Kitchen
                lbl_status.Text = "厨房パネル"
                lbl_SeatName.Text = "端末"
            Case LC_Hanaita
                lbl_status.Text = "厨房パネル"
                lbl_SeatName.Text = "端末"
            Case LC_Handy
                lbl_status.Text = "ハンディーターミナル"
                lbl_SeatName.Text = "端末"
            Case LC_Hyoujiki
                lbl_status.Text = "呼出表示機"
                lbl_SeatName.Text = "端末"
            Case LC_Hakken
                lbl_status.Text = "発券機"
                lbl_SeatName.Text = "端末"
            Case LC_Tag
                lbl_status.Text = "タグ書き込みパネル"
                lbl_SeatName.Text = "端末"
                ' --- (2019.03.24) デシャップ --------------
                ' --- (2018.12.20) 特急レーン連携 --------------
                'Case LC_Hassha
                '    lbl_status.Text = "レーン発車パネル"
                '    lbl_SeatName.Text = "端末"
                ' --- (2018.12.20) 特急レーン連携 --------------
                ' --- (2019.03.24) デシャップ --------------
            Case LC_Dishup
                lbl_status.Text = "発車パネル"
                lbl_SeatName.Text = "端末"
                ' --- (2019.03.24) デシャップ --------------
                ' --- (2019.05.23) 入店管理対応 --------------
            Case LC_Control2
                lbl_status.Text = "座席入店管理"
                lbl_SeatName.Text = "端末"
                ' --- (2019.05.23) 入店管理対応 --------------

            Case Else
                lbl_status.Text = ""
                lbl_SeatName.Text = ""
        End Select

        If LF_CheckCLMode() = "0" Then
            '--- 開始状態の場合 ---------------

            Select Case LF_CheckTermKind()
                Case LC_Contrl
                    L_Addscript = L_Addscript & " onLoad=""FStart(" & CInt(Trim$(L_Func.GF_GetAppInfo("TPA001_TIMER"))) & _
                                                  ",'" & Me.ViewState("TERMKIND") & "');"
                Case LC_Floor_15
                    L_Addscript = L_Addscript & " onLoad=""FStart(" & CInt(Trim$(L_Func.GF_GetAppInfo("TPA001_TIMER"))) & _
                                                  ",'" & Me.ViewState("TERMKIND") & "');"
                Case LC_Floor_12
                    L_Addscript = L_Addscript & " onLoad=""FStart(" & CInt(Trim$(L_Func.GF_GetAppInfo("TPA001_TIMER"))) & _
                                                  ",'" & Me.ViewState("TERMKIND") & "');"
                Case LC_Floor_8
                    L_Addscript = L_Addscript & " onLoad=""FStart(" & CInt(Trim$(L_Func.GF_GetAppInfo("TPA001_TIMER"))) & _
                                                  ",'" & Me.ViewState("TERMKIND") & "');"
                Case LC_Kitchen
                    L_Addscript = L_Addscript & " onLoad=""FStart(" & CInt(Trim$(L_Func.GF_GetAppInfo("TPA001_TIMER"))) & _
                                                  ",'" & Me.ViewState("TERMKIND") & "');"
                Case LC_Hanaita
                    L_Addscript = L_Addscript & " onLoad=""FStart(" & CInt(Trim$(L_Func.GF_GetAppInfo("TPA001_TIMER"))) & _
                                                  ",'" & Me.ViewState("TERMKIND") & "');"
                Case LC_Handy
                    L_Addscript = L_Addscript & " onLoad=""FStart(" & CInt(Trim$(L_Func.GF_GetAppInfo("TPA001_TIMER"))) & _
                                                  ",'" & Me.ViewState("TERMKIND") & "');"
                Case LC_Hyoujiki
                    L_Addscript = L_Addscript & " onLoad=""FStart(" & CInt(Trim$(L_Func.GF_GetAppInfo("TPA001_TIMER"))) & _
                                                  ",'" & Me.ViewState("TERMKIND") & "');"
                Case LC_Hakken
                    L_Addscript = L_Addscript & " onLoad=""FStart(" & CInt(Trim$(L_Func.GF_GetAppInfo("TPA001_TIMER"))) & _
                                                  ",'" & Me.ViewState("TERMKIND") & "');"
                Case LC_Tag
                    L_Addscript = L_Addscript & " onLoad=""FStart(" & CInt(Trim$(L_Func.GF_GetAppInfo("TPA001_TIMER"))) & _
                                                  ",'" & Me.ViewState("TERMKIND") & "');"
                    ' --- (2018.12.20) 特急レーン連携 --------------
                Case LC_Hassha
                    L_Addscript = L_Addscript & " onLoad=""FStart(" & CInt(Trim$(L_Func.GF_GetAppInfo("TPA001_TIMER"))) & _
                                                  ",'" & Me.ViewState("TERMKIND") & "');"
                    ' --- (2018.12.20) 特急レーン連携 --------------
                    ' --- (2019.05.23) 入店管理対応 --------------
                Case LC_Control2
                    L_Addscript = L_Addscript & " onLoad=""FStart(" & CInt(Trim$(L_Func.GF_GetAppInfo("TPA001_TIMER"))) & _
                                                  ",'" & Me.ViewState("TERMKIND") & "');"
                    ' --- (2019.05.23) 入店管理対応 --------------
                Case Else
                    '新規設定の場合
            End Select

        Else
            '終了状態では30秒毎に自動遷移を追加
            L_Addscript = L_Addscript & " onLoad=""FStart('30000', '');"

        End If

        '座席番号取得
        lbl_SeatId.Text = LF_CheckSeatId()

        '座席番号取得
        If Len(Trim$(Session("TP").GF_GetAppInfo("TPA001_FLG"))) = 0 Then
            Response.Redirect("./TP2990.html?CNWA010(Page_Load-2)")
            Exit Sub
        End If

        ' IPアドレス表示設定
        Dim CNWA001flg As Integer

        CNWA001flg = CInt(Trim(L_Func.GF_GetAppInfo("TPA001_FLG").ToString))
        If CNWA001flg = 0 Then
            pnl_IP.Visible = False
        ElseIf CNWA001flg = 1 Then
            pnl_IP.Visible = True
        End If

        Exit Sub

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWA010(Page_Load)")
        Exit Sub
    End Sub

    Private Function LF_CheckTermKind() As String
        'TPM050に登録済みの端末を取得
        '端末別設定の初期表示を決定（前回設定値をデフォルト表示）
        '再起動ボタンによる遷移先を決定

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow

        LF_CheckTermKind = ""

        strSQL = ""
        strSQL = strSQL & "SELECT TERMKIND"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE TERMID = '" & Trim$(lbl_IP.Text) & "'"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            LF_CheckTermKind = "0"
            Me.ViewState("TPM050Exist") = "0"
            Exit Function
        Else
            Me.ViewState("TPM050Exist") = "1"
        End If

        objRow = Nothing
        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            GoTo SYSTEM_ERROR
        End If

        LF_CheckTermKind = Trim$(objRow("TERMKIND"))

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWA010(LF_CheckTermKind)")
        Exit Function
    End Function

    Private Function LF_CheckSeatId() As String
        'TPM050に登録済みの端末を取得

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow
        Dim strSeatid As String

        LF_CheckSeatId = ""

        '配席機能修正
        If Len(Trim$(L_Func.GF_GetSeatFlg(Request.UserHostAddress))) = 0 Then

            strSQL = ""
            strSQL = strSQL & "SELECT SEATID"
            strSQL = strSQL & "  FROM TPM050"
            strSQL = strSQL & " WHERE TERMID = '" & Trim$(lbl_IP.Text) & "'"


            If Not L_Func.GF_GetData(strSQL, objData) Then
                Exit Function
            End If

            If objData.Tables("com").Rows.Count = 0 Then
                LF_CheckSeatId = ""
                Me.ViewState("TPM050Exist") = "0"
                Exit Function
            Else
                Me.ViewState("TPM050Exist") = "1"
            End If

            objRow = Nothing
            If Not L_Func.GF_GetRows(objData, 0, objRow) Then
                GoTo SYSTEM_ERROR
            End If

            LF_CheckSeatId = Trim$(objRow("SEATID"))
        Else

            strSeatid = Trim$(L_Func.GF_GetSeatid(Request.UserHostAddress))
            If strSeatid = "" Then
                LF_CheckSeatId = "座席未設定"
            Else
                LF_CheckSeatId = strSeatid
            End If
        End If

        'TPD240消去---------------------------------
        If lbl_status.Text = "厨房パネル" Then

            Dim strDel As String

            strDel = ""
            strDel = strDel & " DELETE FROM TPD240"
            strDel = strDel & " WHERE TERMNO = '" & Trim$(LF_CheckSeatId) & "'"

            If Not Session("TP").GF_UpdData(strDel) Then
                Call Session("TP").GF_RollbackTrans()
                Exit Function
            End If

            '-----------------------------
            ' コミット処理 
            '-----------------------------
            If Not Session("TP").GF_CommitTrans Then
                Call Session("TP").GF_RollbackTrans()
                Exit Function
            End If

        End If
        '---------------------------------

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWA011(LF_CheckSeatId)")
        Exit Function
    End Function

    Private Function LF_CheckCLMode() As String

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow

        LF_CheckCLMode = ""

        strSQL = ""
        strSQL = strSQL & "SELECT CLMODE"
        strSQL = strSQL & "  FROM TPM040"
        If Not L_Func.GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        objRow = Nothing
        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            GoTo SYSTEM_ERROR
        End If

        LF_CheckCLMode = Trim$(objRow("CLMODE"))

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWA010(LF_CheckCLMode)")
        Exit Function
    End Function

    Private Sub btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Next.Click

        '端末再起動

        Dim strSQL As String

        '端末区分が選択されていない場合、ページ遷移は発生しない
        If Me.ViewState("TERMKIND") = "0" Then
            Exit Sub
        End If

        'TPM050に存在しない場合、ページ遷移は発生しない。
        strSQL = ""
        strSQL = strSQL & "SELECT * FROM TPM050"
        strSQL = strSQL & " WHERE TERMID = '" & Trim$(lbl_IP.Text) & "'"
        If LF_RecCnt(strSQL) = 0 Then
            Exit Sub
        End If

        'CLMODE="1"（終了状態）の場合、ページ遷移は発生しない
        If LF_CheckCLMode() = "1" Then
            Exit Sub
        End If

        'ページ遷移
        Select Case LF_CheckTermKind()
            Case LC_Contrl
                Response.Redirect("/CNWG001/CNWG010.aspx")
                Exit Sub
            Case LC_Floor_15
                Response.Redirect("/TPI001/TPI010.aspx")
                Exit Sub
            Case LC_Floor_12
                If L_Func.GF_GetAppInfo2("MULTI_LING_USE") = "0" Then
                    Response.Redirect("/CNWH001/CNWH010.aspx")
                Else
                    Response.Redirect("/CNWC002/CNWC010.aspx")
                End If
                Exit Sub
            Case LC_Floor_8
                Response.Redirect("/CNWH002/CNWH010.aspx")
                Exit Sub
            Case LC_Kitchen
                Response.Redirect("/CNWQ002/CNWQ030.aspx")
                Exit Sub
            Case LC_Hanaita
                If L_Func.GF_GetAppInfo3("CNWQ003_1") = "0" Then
                    Response.Redirect("/CNWQ001/CNWQ030.aspx")
                Else
                    Response.Redirect("/CNWQ003/CNWQ030.aspx")
                End If
                Exit Sub
            Case LC_Handy
                Response.Redirect("/CNWT001/CNWT010.aspx")
                Exit Sub
            Case LC_Hyoujiki
                Response.Redirect("/CNWC001/CNWC010.aspx")
                Exit Sub
            Case LC_Hakken
                Response.Redirect("/CNWS001/CNWS010.aspx")
                Exit Sub
            Case LC_Tag
                Response.Redirect("/CNWQ003/CNWQ030.aspx")
                Exit Sub
                ' --- (2018.12.20) 特急レーン連携 --------------
            Case LC_Hassha
                Response.Redirect("/CNWU001/CNWU030.aspx")
                Exit Sub
                ' --- (2018.12.20) 特急レーン連携 --------------
                ' --- (2019.05.23) 入店管理対応 --------------
            Case LC_Control2
                Response.Redirect("/CNWG002/CNWG010.aspx")
                Exit Sub
                ' --- (2019.05.23) 入店管理対応 --------------
            Case Else
                Exit Sub
        End Select

    End Sub

    Private Function LF_RecCnt(ByVal pstrsql As String) As Long

        Dim objData As New DataSet()

        If Not L_Func.GF_GetData(pstrsql, objData) Then
            GoTo SYSTEM_ERROR
        End If

        LF_RecCnt = objData.Tables("com").Rows.Count

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWA010(LF_RecCnt)")
        Exit Function
    End Function

    Public Sub LS_BodyWrite()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strHTML As String
        Dim int1 As Integer
        Dim int2 As Integer

        '------------------------------
        ' <BODY>タグ出力処理
        '------------------------------
        strHTML = ""

        Select Case Me.ViewState("TERMKIND").ToString

            Case LC_Floor_12
                int1 = 800
                int2 = 600
            Case LC_Floor_8
                int1 = 640
                int2 = 480
            Case LC_Handy
                int1 = 960
                int2 = 640
                'Case LC_Hyoujiki
                '    int1 = 1280
                '    int2 = 768
            Case Else
                int1 = 1024
                int2 = 748
        End Select

        strHTML = strHTML & "<body scroll=""no"" align=""center"" width=""" & int1 & """ height=""" & int2 & """ background=""gif/background.jpg"""" MS_POSITIONING=""GridLayout"""
        If L_Addscript <> "" Then
            strHTML = strHTML & L_Addscript
        End If
        strHTML = strHTML & """"
        strHTML = strHTML & ">"

        Response.Write(strHTML)

    End Sub

    Public Sub LS_IframeWrite()

        Dim strHTML As String

        strHTML = ""

        'テンキー画面表示の場合のみ<IFRAME>タグ出力
        If Trim$(L_IframeMode) <> "" Then
            If Trim$(L_IframeMode) <> "4" Then
                strHTML = "<IFRAME style=""Z-INDEX: 202; LEFT: 150px; VISIBILITY: visible; POSITION: absolute; TOP: 125px"" name=""F_CNWE001"" height=""390px"" width=""520px"" src=""/CNWE001/CNWE010.aspx?"
                strHTML = strHTML & "MODE=" & L_IframeMode
                strHTML = strHTML & "&RET=" & L_IframeRet
            Else
                strHTML = "<IFRAME style=""Z-INDEX: 202; LEFT: 150px; VISIBILITY: visible; POSITION: absolute; TOP: 125px"" name=""F_CNWE001"" height=""390px"" width=""520px"" src=""/CNWE001/CNWE020.aspx?"
                strHTML = strHTML & "RET=" & L_IframeRet
            End If
            strHTML = strHTML & """ frameBorder=""yes"" width=""500"" scrolling=""no"" height=""425""></IFRAME>"
        Else
            If Trim$(L_IframePos) <> "" Then
                strHTML = "<IFRAME style=""Z-INDEX: 202; LEFT: 0px; VISIBILITY: visible; POSITION: absolute; TOP: 0px"" name=""F_TPB001"" height=""100%"" width=""102%"" src=""/TPB001/TPB010.aspx?"
                strHTML = strHTML & "MODE=1&RET=txt_pos&POS=" & Trim$(txt_pos.Text)
                strHTML = strHTML & """ frameBorder=""no"" width=""500"" scrolling=""no"" height=""425""></IFRAME>"
            End If
            strHTML = strHTML & "<IFRAME style=""Z-INDEX: 202; LEFT: 150px; VISIBILITY: hidden; POSITION: absolute; TOP: 125px"" name=""F_CNWE001"" height=""390px"" width=""520px"""
            strHTML = strHTML & """ frameBorder=""yes"" width=""500"" scrolling=""no"" height=""425""></IFRAME>"
        End If

        Response.Write(strHTML)

    End Sub

    Public Sub JSWrite()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strOutput As String

        '------------------------------
        ' JavaScript
        '------------------------------
        strOutput = ""
        strOutput = strOutput & "<SCRIPT LANGUAGE='JavaScript'>" & vbCrLf
        strOutput = strOutput & "function fTimerReload(termkind){ " & vbCrLf
        strOutput = strOutput & "   switch(termkind){ " & vbCrLf
        If L_Func.GF_GetAppInfo2("MULTI_LING_USE") = "0" Then
            strOutput = strOutput & " 	    case ""TCA"":location.href = ""/CNWH001/CNWH010.aspx"";break;" & vbCrLf
        Else
            strOutput = strOutput & " 	    case ""TCA"":location.href = ""/CNWC002/CNWC010.aspx"";break;" & vbCrLf
        End If
        strOutput = strOutput & "       case ""TCB"":location.href = ""/CNWH002/CNWH010.aspx"";break;" & vbCrLf
        strOutput = strOutput & "   	case ""TC0"":location.href = ""/CNWI001/CNWI010.aspx"";break;" & vbCrLf
        strOutput = strOutput & "       case ""TC1"":location.href = ""/CNWC001/CNWC010.aspx"";break;" & vbCrLf
        strOutput = strOutput & "       case ""TC2"":location.href = ""/CNWC002/CNWC010.aspx"";break;" & vbCrLf
        strOutput = strOutput & " 		case ""TC3"":location.href = ""/CNWC003/CNWC010.aspx"";break;" & vbCrLf
        strOutput = strOutput & "		case ""TC4"":location.href = ""/CNWC004/CNWC010.aspx"";break;" & vbCrLf
        strOutput = strOutput & "		case ""TC5"":location.href = ""/CNWC005/CNWC010.aspx"";break;" & vbCrLf
        strOutput = strOutput & " 	    case ""TC6"":location.href = ""/CNWC006/CNWC010.aspx"";break;" & vbCrLf
        strOutput = strOutput & "       case ""TC6"":location.href = ""/CNWC007/CNWC010.aspx"";break;" & vbCrLf
        strOutput = strOutput & "       case ""TC7"":location.href = ""/CNWQ002/CNWQ030.aspx"";break;" & vbCrLf
        strOutput = strOutput & "       case ""TC8"":location.href = ""/CNWD008/CNWD030.aspx"";break;" & vbCrLf
        strOutput = strOutput & "       case ""TC9"":location.href = ""/CNWG001/CNWG010.aspx"";break;" & vbCrLf
        If L_Func.GF_GetAppInfo3("CNWQ003_1") = "0" Then
            strOutput = strOutput & "       case ""TCQ"":location.href = ""/CNWQ001/CNWQ030.aspx"";break;" & vbCrLf
        Else
            strOutput = strOutput & "       case ""TCQ"":location.href = ""/CNWQ003/CNWQ030.aspx"";break;" & vbCrLf
        End If
        strOutput = strOutput & "       case ""TCT"":location.href = ""/CNWT001/CNWT010.aspx"";break;" & vbCrLf
        strOutput = strOutput & "       case ""TCS"":location.href = ""/CNWS001/CNWS010.aspx"";break;" & vbCrLf
        strOutput = strOutput & "       case ""TCU"":location.href = ""/CNWQ003/CNWQ030.aspx"";break;" & vbCrLf
        ' --- (2018.12.20) 特急レーン連携 --------------
        strOutput = strOutput & "       case ""TCV"":location.href = ""/CNWU001/CNWU030.aspx"";break;" & vbCrLf
        ' --- (2018.12.20) 特急レーン連携 --------------
        ' --- (2019.05.23) 入店管理対応 --------------
        strOutput = strOutput & "       case ""TCG"":location.href = ""/CNWG002/CNWG010.aspx"";break;" & vbCrLf
        ' --- (2019.05.23) 入店管理対応 --------------
        strOutput = strOutput & "       default:location.href = ""./CNWA010.aspx"";break;" & vbCrLf
        strOutput = strOutput & "   }" & vbCrLf
        strOutput = strOutput & "} " & vbCrLf

        strOutput = strOutput & "</SCRIPT>" & vbCrLf

        Response.Write(strOutput)

    End Sub
End Class
