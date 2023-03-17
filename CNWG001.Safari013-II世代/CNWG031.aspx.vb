Partial Class CNWG031
    Inherits System.Web.UI.Page

    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

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
    Private L_AddScript As String

    Public Sub BodyWrite()
        'BODYタグ書き出し
        Dim strReload As String

        strReload = "onLoad='" & L_AddScript & "'"

        Response.Write("<BODY MS_POSITIONING='GridLayout'" & _
                     " topmargin='0' leftmargin='0' bottommargin='0' rightmargin='0' onselectstart=""return false"" " & _
                     strReload & ">")
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' セッション状態確認
        '------------------------------
        Try
            If IsNothing(Session("TP")) Then
                L_Func = New TP2920()
                If Not L_Func.GF_Initialize Then
                    Response.Redirect("./TP2990.html?CNWG031(Page_Load-1)")
                    Exit Sub
                End If
                Session.Add("TP", L_Func)
            Else
                L_Func = Session.Item("TP")
            End If

            L_AddScript = ""
            lbl_Msg1.Text = ""
            lbl_Msg2.Text = ""
            lbl_Msg3.Text = ""

            If IsPostBack = True Then
                Exit Sub
            End If

            L_AddScript = "document.F_CNWG031.btn_Dummy.click();"

            lbl_Msg2.Text = "しばらくお待ち下さい"
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG031(Page_Load-2)")
        Exit Sub
    End Sub

    Private Sub btn_Dummy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Dummy.Click
        Dim strSQL As String
        Dim objdata As New DataSet()
        Dim objRow As DataRow = Nothing

        '------------------------------
        ' 注文履歴問い合わせ
        '------------------------------
        If LS_HistoryRef() Then
            'TPD250内存在チェック
            strSQL = ""
            strSQL = strSQL & "SELECT *"
            strSQL = strSQL & "  FROM TPD250"
            strSQL = strSQL & " WHERE SEATID = '" & GF_PadSpc(Trim$(Request.QueryString("SEATID")), 5) & "'"

            If Not Session("TP").GF_GetData(strSQL, objdata) Then
                Response.Redirect("./TP2990.html?CNWG031(btn_Dummy_Click-1)")
                Exit Sub
            End If

            '数量チェック
            If objdata.Tables("com").Rows.Count > 0 Then
                If Not Session("TP").GF_GetRows(objdata, 0, objrow) Then
                    Exit Sub
                End If
                'ダミー領域に表示客席番号を追加
                L_AddScript = "fSetValue(""../CNWL001/CNWL020.aspx""," & Trim$(Request.QueryString("SEATID")) & ");"
            Else
                lbl_Msg2.Text = "入力した客席番号のご注文情報はありません。"
                L_AddScript = "setTimeout(""parent.fWinClose();"",3000);"
            End If
        End If
    End Sub

    Private Function LS_HistoryRef() As Boolean
        Dim strSQL As String
        Dim i As Long
        Dim strTERMID As String = Nothing
        Dim strORDERSTATUS As String = Nothing
        '--- マイナス伝票画面起動時は注文履歴参照不可能とする ---
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        '--------------------------------------------------------

        LS_HistoryRef = False

        '客席番号有無チェック処理
        If GetTERMID(strTERMID, strORDERSTATUS) Then
            If strORDERSTATUS = "2" Then
                lbl_Msg2.Text = "入力した客席番号はお通しされてません。"
                L_AddScript = "setTimeout(""parent.fWinClose();"",3000);"
                Exit Function
            End If
        Else
            lbl_Msg2.Text = "入力した客席番号は存在しません。"
            L_AddScript = "setTimeout(""parent.fWinClose();"",3000);"
            Exit Function
        End If

        '--- マイナス伝票画面起動時は注文履歴参照不可能とする ---
        strSQL = ""
        strSQL = strSQL & "SELECT HISTORYFLG"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE TERMID = '" & strTERMID & "'"

        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG031(LS_HistoryRef-1)")
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Response.Redirect("./TP2990.html?CNWG031(LS_HistoryRef-2)")
            Exit Function
        End If
        If Not Session("TP").GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG031(LS_HistoryRef-3)")
            Exit Function
        End If
        If objRow("HISTORYFLG") = "2" Then
            Sleep(3000) '3秒スリープ
            lbl_Msg1.Text = "他のパネルから指定した客席の"
            lbl_Msg2.Text = "マイナス伝票を処理しています。"
            lbl_Msg3.Text = "暫くしてから再度お願いします。"
            L_AddScript = "setTimeout(""parent.fWinClose();"",3000);"

            Exit Function
        End If
        '----------------------------------------------------------

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050"
        strSQL = strSQL & "   SET HISTORYFLG = '1'"
        strSQL = strSQL & " WHERE TERMID     = '" & strTERMID & "'"

        If Not Session("TP").GF_BeginTrans Then
            Exit Function
        End If
        If Not Session("TP").GF_UpdData(strSQL) Then
            Call Session("TP").GF_RollbackTrans()
            Exit Function
        End If
        If Not Session("TP").GF_CommitTrans Then
            Call Session("TP").GF_RollbackTrans()
            Exit Function
        End If

        For i = 0 To 12
            If CheckSTNsend(strTERMID) = True Then
                'ステーション応答有の場合
                LS_HistoryRef = True
                Exit For
            Else
                'ステーション応答無の場合
                If i <> 12 Then
                    Sleep(1000)
                Else
                    lbl_Msg2.Text = "混雑中のため暫くしてから再度お願いします。"
                    L_AddScript = "setTimeout(""parent.fWinClose();"",3000);"
                    Exit Function
                End If
            End If
        Next i
    End Function

    Private Function GetTERMID(ByRef pTermId As String, ByRef pOrderStatus As String) As Boolean
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        GetTERMID = False
        pTermId = ""
        pOrderStatus = ""

        strSQL = ""
        strSQL = strSQL & "SELECT TERMID,"
        strSQL = strSQL & "       ORDERSTATUS"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE SEATID   = '" & GF_PadSpc(Trim$(Request.QueryString("SEATID")), 5) & "'"
        strSQL = strSQL & "   AND TERMKIND IN ('TC0', 'TCA', 'TCB')"

        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG031(GetTERMID-1)")
            Exit Function
        End If

        If Not objData.Tables("com").Rows.Count = 0 Then
            If Not Session("TP").GF_GetRows(objData, 0, objRow) Then
                Response.Redirect("./TP2990.html?CNWG031(GetTERMID-2)")
                Exit Function
            End If

            GetTERMID = True
            pTermId = objRow("TERMID")
            pOrderStatus = objRow("ORDERSTATUS")
        End If
    End Function

    Private Function CheckSTNsend(ByVal pTermId As String) As Boolean
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        CheckSTNsend = False

        strSQL = ""
        strSQL = strSQL & "SELECT HISTORYFLG"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE TERMID = '" & pTermId & "'"

        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG031(CheckSTNsend-1)")
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Response.Redirect("./TP2990.html?CNWG031(CheckSTNsend-2)")
            Exit Function
        End If
        If Not Session("TP").GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG031(CheckSTNsend-3)")
            Exit Function
        End If
        If objRow("HISTORYFLG") = "0" Then
            '--- マイナス伝票画面起動時は注文履歴参照不可能とする ---
            strSQL = ""
            strSQL = strSQL & "UPDATE TPM050"
            strSQL = strSQL & "   SET HISTORYFLG = '2'"
            strSQL = strSQL & " WHERE TERMID     = '" & pTermId & "'"

            If Not Session("TP").GF_BeginTrans Then
                Exit Function
            End If
            If Not Session("TP").GF_UpdData(strSQL) Then
                Call Session("TP").GF_RollbackTrans()
                Exit Function
            End If
            If Not Session("TP").GF_CommitTrans Then
                Call Session("TP").GF_RollbackTrans()
                Exit Function
            End If
            '---------------------------------------------------------

            CheckSTNsend = True
        End If
    End Function

    Private Function GF_PadSpc(ByVal pStr As String, ByVal Length As Long) As String
        GF_PadSpc = Space(Length - Len(Trim$(pStr))) & Trim$(pStr)
    End Function

End Class
