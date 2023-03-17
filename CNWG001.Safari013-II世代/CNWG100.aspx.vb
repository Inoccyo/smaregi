Partial Class CNWG100
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
    Private L_Com As CNWG490

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' セッション状態確認
        '------------------------------
        Try
            If IsNothing(Session("TP")) Then
                L_Func = New TP2920()
                If Not L_Func.GF_Initialize Then
                    Response.Redirect("./TP2990.html?CNWG100(Page_Load-1)")
                    Exit Sub
                End If
                Session.Add("TP", L_Func)
            Else
                L_Func = Session.Item("TP")
            End If
            L_Com = New CNWG490()
            L_Com.G_2920 = L_Func

            Me.ViewState.Add("MSGCD", "")
            Me.ViewState.Add("GOODSCD", "")

            If IsPostBack Then
                Exit Sub
            End If

            lbl_head.Text = "品切れ解除する商品を選択して下さい"

            Me.ViewState.Add("PAGE", "1")
            Me.ViewState.Add("ITMCD", "")
            Call LS_FormSetup()

        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG100(Page_Load-2)")
        Exit Sub
    End Sub

    Private Sub LS_FormSetup()

        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim lngBCnt As Long
        Dim strGoodsCD As String

        If Not LF_GetTPD030(objData) Then
            GoTo SYSTEM_ERROR
        End If

        '品切れ4パターン対応　2013.10.28
        If Not LF_GetTPD031(objData) Then
            GoTo SYSTEM_ERROR
        End If
        If Not LF_GetTPD032(objData) Then
            GoTo SYSTEM_ERROR
        End If
        If Not LF_GetTPD033(objData) Then
            GoTo SYSTEM_ERROR
        End If

        btn_1.Visible = False
        btn_2.Visible = False
        btn_3.Visible = False
        btn_4.Visible = False
        btn_5.Visible = False
        btn_6.Visible = False
        btn_7.Visible = False
        btn_8.Visible = False
        btn_9.Visible = False
        btn_10.Visible = False

        lngCnt = 10 * (CLng(Me.ViewState.Item("PAGE")) - 1)
        lngBCnt = 0
        strGoodsCD = ""
        While lngCnt < objData.Tables("com").Rows.Count
            If Not L_Func.GF_GetRows(objData, lngCnt, objRows) Then
                GoTo SYSTEM_ERROR
            End If

            Select Case lngBCnt + 1
                Case 1
                    btn_1.Text = Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2"))
                    btn_1.Visible = True
                    If L_Com.GF_LenB(btn_1.Text) > 26 Then
                        btn_1.Font.Size = FontUnit.Small
                    Else
                        btn_1.Font.Size = FontUnit.XLarge
                    End If
                Case 2
                    btn_2.Text = Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2"))
                    btn_2.Visible = True
                    If L_Com.GF_LenB(btn_2.Text) > 26 Then
                        btn_2.Font.Size = FontUnit.Small
                    Else
                        btn_2.Font.Size = FontUnit.XLarge
                    End If
                Case 3
                    btn_3.Text = Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2"))
                    btn_3.Visible = True
                    If L_Com.GF_LenB(btn_3.Text) > 26 Then
                        btn_3.Font.Size = FontUnit.Small
                    Else
                        btn_3.Font.Size = FontUnit.XLarge
                    End If
                Case 4
                    btn_4.Text = Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2"))
                    btn_4.Visible = True
                    If L_Com.GF_LenB(btn_4.Text) > 26 Then
                        btn_4.Font.Size = FontUnit.Small
                    Else
                        btn_4.Font.Size = FontUnit.XLarge
                    End If
                Case 5
                    btn_5.Text = Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2"))
                    btn_5.Visible = True
                    If L_Com.GF_LenB(btn_5.Text) > 26 Then
                        btn_5.Font.Size = FontUnit.Small
                    Else
                        btn_5.Font.Size = FontUnit.XLarge
                    End If
                Case 6
                    btn_6.Text = Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2"))
                    btn_6.Visible = True
                    If L_Com.GF_LenB(btn_6.Text) > 26 Then
                        btn_6.Font.Size = FontUnit.Small
                    Else
                        btn_6.Font.Size = FontUnit.XLarge
                    End If
                Case 7
                    btn_7.Text = Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2"))
                    btn_7.Visible = True
                    If L_Com.GF_LenB(btn_7.Text) > 26 Then
                        btn_7.Font.Size = FontUnit.Small
                    Else
                        btn_7.Font.Size = FontUnit.XLarge
                    End If
                Case 8
                    btn_8.Text = Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2"))
                    btn_8.Visible = True
                    If L_Com.GF_LenB(btn_8.Text) > 26 Then
                        btn_8.Font.Size = FontUnit.Small
                    Else
                        btn_8.Font.Size = FontUnit.XLarge
                    End If
                Case 9
                    btn_9.Text = Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2"))
                    btn_9.Visible = True
                    If L_Com.GF_LenB(btn_9.Text) > 26 Then
                        btn_9.Font.Size = FontUnit.Small
                    Else
                        btn_9.Font.Size = FontUnit.XLarge
                    End If
                Case 10
                    btn_10.Text = Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2"))
                    btn_10.Visible = True
                    If L_Com.GF_LenB(btn_10.Text) > 26 Then
                        btn_10.Font.Size = FontUnit.Small
                    Else
                        btn_10.Font.Size = FontUnit.XLarge
                    End If
                Case Else
                    Exit While
            End Select
            If lngBCnt <> 0 Then
                strGoodsCD = strGoodsCD & ","
            End If
            strGoodsCD = strGoodsCD & Trim$(objRows("GOODSCD"))

            lngCnt = lngCnt + 1
            lngBCnt = lngBCnt + 1
        End While

        If lngCnt >= objData.Tables("com").Rows.Count Then
            ' 次の10件を非表示
            btn_Next.Enabled = False
        Else
            btn_Next.Enabled = True
        End If
        If CLng(Me.ViewState.Item("PAGE")) = 1 Then
            ' 前の10件を非表示
            btn_Prev.Enabled = False
        Else
            btn_Prev.Enabled = True
        End If
        Me.ViewState.Item("ITMCD") = strGoodsCD

        Exit Sub

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG100(LS_FormSetup)")
        Exit Sub
    End Sub

    Private Function LF_GetTPD030(ByVal pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPD030 = False

        '------------------------------
        ' 品切れ情報取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        strSQL = strSQL & "       TPM010.GOODSCD"
        strSQL = strSQL & "  FROM TPM010, TPD030"
        strSQL = strSQL & " WHERE TPM010.GOODSCD = TPD030.GOODSCD"
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"
        If Not L_Func.GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPD030 = True

    End Function

    Private Function LF_GetTPD031(ByVal pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPD031 = False

        '------------------------------
        ' 品切れ情報取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        strSQL = strSQL & "       TPM010.GOODSCD"
        strSQL = strSQL & "  FROM TPM010, TPD031"
        strSQL = strSQL & " WHERE TPM010.GOODSCD = TPD031.GOODSCD"
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"
        If Not L_Func.GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPD031 = True

    End Function

    Private Function LF_GetTPD032(ByVal pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPD032 = False

        '------------------------------
        ' 品切れ情報取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        strSQL = strSQL & "       TPM010.GOODSCD"
        strSQL = strSQL & "  FROM TPM010, TPD032"
        strSQL = strSQL & " WHERE TPM010.GOODSCD = TPD032.GOODSCD"
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"
        If Not L_Func.GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPD032 = True

    End Function

    Private Function LF_GetTPD033(ByVal pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPD033 = False

        '------------------------------
        ' 品切れ情報取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        strSQL = strSQL & "       TPM010.GOODSCD"
        strSQL = strSQL & "  FROM TPM010, TPD033"
        strSQL = strSQL & " WHERE TPM010.GOODSCD = TPD033.GOODSCD"
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"
        If Not L_Func.GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPD033 = True

    End Function

    Public Sub GS_BodyWrite()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strHTML As String

        '------------------------------
        ' <BODY>タグ出力処理
        '------------------------------
        strHTML = ""
        strHTML = strHTML & Space(1) & "BGCOLOR='#e5decc' TOPMARGIN='10'"
        strHTML = strHTML & " onLoad='"

        If Len(Trim$(Me.ViewState.Item("MSGCD"))) <> 0 Then
            strHTML = strHTML & " fMsg(""" & Trim$(Me.ViewState.Item("MSGCD")) & """, """ & Trim$(Me.ViewState.Item("GOODSCD")) & """);"
        End If
        strHTML = strHTML & "'"

        Response.Write(strHTML)

    End Sub

    Private Sub btn_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_1.Click
        Call LS_UpdTPD030(0)
    End Sub

    Private Sub btn_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_2.Click
        Call LS_UpdTPD030(1)
    End Sub

    Private Sub btn_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_3.Click
        Call LS_UpdTPD030(2)
    End Sub

    Private Sub btn_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_4.Click
        Call LS_UpdTPD030(3)
    End Sub

    Private Sub btn_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_5.Click
        Call LS_UpdTPD030(4)
    End Sub

    Private Sub btn_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_6.Click
        Call LS_UpdTPD030(5)
    End Sub

    Private Sub btn_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_7.Click
        Call LS_UpdTPD030(6)
    End Sub

    Private Sub btn_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_8.Click
        Call LS_UpdTPD030(7)
    End Sub

    Private Sub btn_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_9.Click
        Call LS_UpdTPD030(8)
    End Sub

    Private Sub btn_10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_10.Click
        Call LS_UpdTPD030(9)
    End Sub

    Private Sub LS_UpdTPD030(ByVal pNum As Integer)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strWork() As String

        '------------------------------
        ' 品切れ解除処理
        '------------------------------
        strWork = Split(Trim$(Me.ViewState.Item("ITMCD")), ",")
        Select Case L_Com.GF_SetSoldOut(Trim$(strWork(pNum)), CNWG490.SoldOutKind.OnSale)
            Case 0                                                          ' 正常登録処理完了
                ' 「ＮＮＮＮＮＮＮＮＮＮ」を品切れ解除しました
                Me.ViewState.Item("MSGCD") = "K04"

            Case 1                                                          ' データ異常(登録済み)
                ' 既に品切れ解除済みです
                Me.ViewState.Item("MSGCD") = "K05"

            Case 2
                ' 登録されていない商品コードです
                Me.ViewState.Item("MSGCD") = "K03"

            Case Else                                                       ' システム異常
                GoTo SYSTEM_ERROR
        End Select
        Me.ViewState.Item("GOODSCD") = Trim$(strWork(pNum))

        If CLng(Trim$(Me.ViewState.Item("PAGE"))) <> 1 And _
           strWork.GetUpperBound(0) = 0 Then
            Me.ViewState.Item("PAGE") = CLng(Me.ViewState.Item("PAGE")) - 1
        End If

        Call LS_FormSetup()

        Exit Sub

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG100(LS_UpdTPD030)")
        Exit Sub
    End Sub

    Private Sub btn_Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Prev.Click

        Me.ViewState.Item("PAGE") = CLng(Me.ViewState.Item("PAGE")) - 1
        Call LS_FormSetup()

    End Sub

    Private Sub btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Next.Click

        Me.ViewState.Item("PAGE") = CLng(Me.ViewState.Item("PAGE")) + 1
        Call LS_FormSetup()

    End Sub
End Class
