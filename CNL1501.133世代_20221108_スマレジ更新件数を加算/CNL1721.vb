Public Class CNL1721
    Inherits System.Windows.Forms.Form

#Region " Windows �t�H�[�� �f�U�C�i�Ő������ꂽ�R�[�h "

    Public Sub New()
        MyBase.New()

        ' ���̌Ăяo���� Windows �t�H�[�� �f�U�C�i�ŕK�v�ł��B
        InitializeComponent()

        ' InitializeComponent() �Ăяo���̌�ɏ�������ǉ����܂��B

    End Sub

    ' Form �� dispose ���I�[�o�[���C�h���ăR���|�[�l���g�ꗗ���������܂��B
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Windows �t�H�[�� �f�U�C�i�ŕK�v�ł��B
    Private components As System.ComponentModel.IContainer

    ' ���� : �ȉ��̃v���V�[�W���́AWindows �t�H�[�� �f�U�C�i�ŕK�v�ł��B
    ' Windows �t�H�[�� �f�U�C�i���g���ĕύX���Ă��������B  
    ' �R�[�h �G�f�B�^�͎g�p���Ȃ��ł��������B
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_OK As System.Windows.Forms.Button
    Friend WithEvents txt_Title As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.txt_Title = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(336, 73)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(72, 32)
        Me.btn_Cancel.TabIndex = 2
        Me.btn_Cancel.Text = "�L�����Z��"
        '
        'btn_OK
        '
        Me.btn_OK.Location = New System.Drawing.Point(256, 73)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(72, 32)
        Me.btn_OK.TabIndex = 1
        Me.btn_OK.Text = "����"
        '
        'txt_Title
        '
        Me.txt_Title.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Title.Location = New System.Drawing.Point(24, 33)
        Me.txt_Title.Name = "txt_Title"
        Me.txt_Title.Size = New System.Drawing.Size(360, 22)
        Me.txt_Title.TabIndex = 0
        Me.txt_Title.Text = "txt_Title"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "�� �I�v�V�����̃K�C�_���X������͂��ĉ�����"
        '
        'CNL1721
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(414, 115)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btn_Cancel, Me.btn_OK, Me.txt_Title, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CNL1721"
        Me.Text = "CNL1721"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CNL1721_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �t�H�[��������
        '------------------------------
        Me.Text = GF_FormText()
        txt_Title.Clear()

    End Sub

    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click

        '------------------------------
        ' �����̓`�F�b�N
        '------------------------------
        If Len(Trim$(txt_Title.Text)) = 0 Then
            Call GF_Msg("E01", "", MsgBoxStyle.OKOnly, MsgBoxStyle.Critical)
            txt_Title.Select()
            Exit Sub
        End If

        ' ���ꖼ�̂̃��j���[�����ɑ��݂��Ă���ꍇ�́A�G���[���b�Z�[�W��\�����āA�����𒆒f������
        Select Case LF_GetTPM100(Trim$(txt_Title.Text))
            Case CNL1920.FuncResult.CancelEnd
                ' ���݂���̂ŁA�G���[ 
                Call GF_Msg("", "���Ɂy" & Trim$(txt_Title.Text) & "�z�����݂��邽�߁A�g�p�ł��܂���B" & vbCrLf & "���̃K�C�_���X������͂��ĉ������B", MsgBoxStyle.OKOnly, MsgBoxStyle.Critical)
                Exit Sub

            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        ' �I�v�V�����o�^�G���A�����ɖ��܂��Ă���ꍇ�́A�G���[���b�Z�[�W��\�����āA�����𒆒f������
        Select Case LF_GetTPM100_2()
            Case CNL1920.FuncResult.CancelEnd
                ' ���݂���̂ŁA�G���[ 
                Call GF_Msg("", "�I�v�V�����o�^�G���A�̏���l�ɒB���Ă��܂��B" & vbCrLf & "���g�p�G���A��������Ă����p�������B", MsgBoxStyle.OKOnly, MsgBoxStyle.Critical)
                Exit Sub

            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        '------------------------------
        ' ���j���[���R�[�h�ǉ�����
        '------------------------------
        If Not LF_InsertNewOption() Then
            GoTo SYSTEM_ERROR
        End If

        With Me
            .DialogResult = DialogResult.OK
            .Close()
        End With

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_OK_Click")

    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        With Me
            .DialogResult = DialogResult.Cancel
            .Close()
        End With
    End Sub

    Private Sub txt_Title_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Title.TextChanged

        If txt_Title.Modified = True Then
            Dim lngST As Long
            lngST = txt_Title.SelectionStart
            ' 2014-05-12 2�o�C�g������������
            'txt_Title.Text = StrConv(txt_Title.Text, VbStrConv.Wide)
            If lngST >= 0 Then txt_Title.SelectionStart = lngST

            '------------------------------
            ' ���͒�����
            '------------------------------
            If GF_LenB(txt_Title.Text) > 20 Then
                txt_Title.Text = GF_MidB(txt_Title.Text, 1, 20)
                txt_Title.SelectionStart = GF_LenB(txt_Title.Text)
                Exit Sub
            End If
        End If

    End Sub

    Private Function LF_GetTPM100(ByVal pGuideNM As String) As FuncResult
        '** ���͂��ꂽ�K�C�_���X���̂̑��݃`�F�b�N

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM100 = CNL1920.FuncResult.UnusualEnd

        strSQL = ""
        strSQL = strSQL & "SELECT TPM100.SCPNO"
        strSQL = strSQL & "  FROM TPM100"
        strSQL = strSQL & " WHERE TPM100.GUIDE = '" & pGuideNM & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        If objData.Tables("com").Rows.Count = 0 Then
            LF_GetTPM100 = CNL1920.FuncResult.NormalEnd
        Else
            LF_GetTPM100 = CNL1920.FuncResult.CancelEnd
        End If

    End Function

    Private Function LF_InsertNewOption() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSCPNO As String = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_InsertNewOption = False

        ' �r�b�o�m�n�̔�
        If Not GF_GetSCPNO(strSCPNO) Then
            Exit Function
        End If

        ' �I�v�V�����������i�}�X�^(TPM010)�A�r�b�o�}�X�^(TPM100)�ɓo�^
        If Not GF_InTPM100(strSCPNO, Trim$(txt_Title.Text)) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_InsertNewOption = True

    End Function

    Private Function LF_GetTPM100_2() As FuncResult
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM100_2 = CNL1920.FuncResult.UnusualEnd

        strSQL = ""
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM TPM100"
        strSQL = strSQL & " WHERE SCPNO >= '001'"
        strSQL = strSQL & "   AND SCPNO <= '035'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        If objData.Tables("com").Rows.Count >= 35 Then
            LF_GetTPM100_2 = CNL1920.FuncResult.CancelEnd
        Else
            LF_GetTPM100_2 = CNL1920.FuncResult.NormalEnd
        End If
    End Function

End Class
