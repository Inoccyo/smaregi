Partial Class CNWG101
    Inherits System.Web.UI.Page

#Region " Web �t�H�[�� �f�U�C�i�Ő������ꂽ�R�[�h "

    '���̌Ăяo���� Web �t�H�[�� �f�U�C�i�ŕK�v�ł��B
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        ' CODEGEN: ���̃��\�b�h�Ăяo���� Web �t�H�[�� �f�U�C�i�ŕK�v�ł��B
        ' �R�[�h �G�f�B�^���g���ĕύX���Ȃ��ł��������B
        InitializeComponent()
    End Sub

#End Region

    Private L_Func As TP2920
    Private L_Com As CNWG490

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �Z�b�V������Ԋm�F
        '------------------------------
        Try
            If IsNothing(Session("TP")) Then
                L_Func = New TP2920()
                If Not L_Func.GF_Initialize Then
                    Response.Redirect("./TP2990.html?CNWG101(Page_Load-1)")
                    Exit Sub
                End If
                Session.Add("TP", L_Func)
            Else
                L_Func = Session.Item("TP")
            End If
            L_Com = New CNWG490()
            L_Com.G_2920 = L_Func

            If IsPostBack = True Then
                Exit Sub
            End If

            '------------------------------
            ' ���b�Z�[�W�����\��
            '------------------------------
            lbl_Msg.Text = L_Func.GF_GetMsg(Trim$(Request.QueryString("MSGCD")))
            If Len(Trim$(Request.QueryString("GOODSCD"))) <> 0 Then
                Call LF_GetGoodsNM(Trim$(Request.QueryString("GOODSCD")))
            Else
                lbl_GoodsNM1.Text = ""
                lbl_GoodsNM2.Text = ""
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG101(Page_Load-2)")
        Exit Sub
    End Sub

    Private Sub LF_GetGoodsNM(ByVal pGoodsCD As String)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing


        '------------------------------
        ' ���i���擾����
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " WHERE TPM010.GOODSCD = '" & pGoodsCD & "'"
        If Not L_Func.GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            lbl_GoodsNM1.Text = ""
            lbl_GoodsNM2.Text = ""
            Exit Sub
        End If
        If Not L_Func.GF_GetRows(objData, 0, objRows) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' ���̐ݒ�
        '------------------------------
        If L_Com.GF_LenB(Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2"))) < 30 Then
            lbl_GoodsNM1.Text = "�u&nbsp;" & Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2")) & "&nbsp;�v"
            lbl_GoodsNM2.Text = ""
        Else
            lbl_GoodsNM1.Text = "�u&nbsp;" & Trim$(objRows("GOODSNMJ"))
            lbl_GoodsNM2.Text = "&nbsp;&nbsp;" & Trim$(objRows("GOODSNMJ2")) & "&nbsp;�v"
        End If

        Exit Sub

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG101(LF_GetGoodsNM)")
        Exit Sub
    End Sub


End Class
