' --------------------------------------------------------------------------------
' �@�@�@�@�\�FCrossNavi - �I�v�V�����V�K�ǉ����
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------
Public Class CNL2061
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Guide As System.Windows.Forms.TextBox
    Friend WithEvents chk_Option As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btn_Cancel = New System.Windows.Forms.Button
        Me.btn_OK = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Guide = New System.Windows.Forms.TextBox
        Me.chk_Option = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Cancel.Location = New System.Drawing.Point(205, 181)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(72, 32)
        Me.btn_Cancel.TabIndex = 2
        Me.btn_Cancel.Text = "�L�����Z��"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_OK
        '
        Me.btn_OK.BackColor = System.Drawing.SystemColors.Control
        Me.btn_OK.Location = New System.Drawing.Point(125, 181)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(72, 32)
        Me.btn_OK.TabIndex = 1
        Me.btn_OK.Text = "����"
        Me.btn_OK.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "�� �I�v�V����������͂��Ă�������"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "�� �K�C�_���X������͂��Ă�������"
        '
        'txt_Guide
        '
        Me.txt_Guide.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Guide.Location = New System.Drawing.Point(64, 138)
        Me.txt_Guide.Name = "txt_Guide"
        Me.txt_Guide.Size = New System.Drawing.Size(320, 22)
        Me.txt_Guide.TabIndex = 5
        Me.txt_Guide.Text = "txt_Guide"
        '
        'chk_Option
        '
        Me.chk_Option.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_Option.FormattingEnabled = True
        Me.chk_Option.Items.AddRange(New Object() {"---", "001", "002", "003", "004", "005", "006", "007", "008", "009", "010", "011", "012", "013", "014", "015", "016", "017", "018", "019", "020", "021", "022", "023", "024", "025", "026", "027", "028", "029", "030", "031", "032", "033", "034", "035", "041", "042", "043", "044", "045", "046", "047", "048", "049", "050", "051", "052", "053", "054", "055", "056", "057", "058", "059", "060", "061", "062", "063", "064", "065", "066", "067", "068", "069", "070", "071", "072", "073", "074", "075", "076", "077", "078", "079", "080", "081", "082", "083", "084", "085", "086", "087", "088", "089", "090", "091", "092", "093", "094", "095", "096", "097", "098", "099", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150"})
        Me.chk_Option.Location = New System.Drawing.Point(65, 37)
        Me.chk_Option.Name = "chk_Option"
        Me.chk_Option.Size = New System.Drawing.Size(116, 23)
        Me.chk_Option.TabIndex = 6
        Me.chk_Option.Text = "chk_Option"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "001�`035 �F �ʏ�I�v�V����"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "041�`050 �F ���i(���ʃI�v�V����)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "101�`150 �F �Z�b�g�I�v�V����"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(203, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 12)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "051�`100 �F �T�u�R�����g"
        '
        'CNL2061
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(416, 222)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chk_Option)
        Me.Controls.Add(Me.txt_Guide)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CNL2061"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CNL2061"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub CNL2061_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �t�H�[��������
        '------------------------------
        Me.Text = GF_FormText()
        chk_Option.SelectedIndex = 0
        txt_Guide.Clear()

    End Sub

    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click

        '------------------------------
        ' �����̓`�F�b�N
        '------------------------------
        If chk_Option.SelectedIndex = 0 Then
            Call GF_Msg("", Replace(GF_GetMsg("E09"), "@@@", "�I�v�V������"), MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            chk_Option.Select()
            Exit Sub
        End If

        If Len(Trim$(txt_Guide.Text)) = 0 Then
            Call GF_Msg("", Replace(GF_GetMsg("E09"), "@@@", "�K�C�_���X��"), MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            txt_Guide.Select()
            Exit Sub
        End If

        '------------------------------
        ' ����I�v�V���������݃`�F�b�N
        '------------------------------
        Select Case LF_GetTPM100_1(chk_Option.SelectedItem)
            Case CNL1920.FuncResult.CancelEnd
                ' �d���G���[ 
                Call GF_Msg("", "�I�v�V�������y" & chk_Option.SelectedItem & "�z�͊��ɓo�^����Ă��܂��B" & vbCrLf & "�ēx�A�I�����ĉ������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                Exit Sub

            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        '------------------------------
        ' ����K�C�_���X���݃`�F�b�N
        '------------------------------
        Select Case LF_GetTPM100_2(Trim$(txt_Guide.Text))
            Case CNL1920.FuncResult.CancelEnd
                ' ���݂���̂ŁA�G���[ 
                Call GF_Msg("", "���Ɂy" & Trim$(txt_Guide.Text) & "�z�����݂��邽�߁A�g�p�ł��܂���B" & vbCrLf & "���̃K�C�_���X������͂��ĉ������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                Exit Sub

            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        '------------------------------
        ' �I�v�V�������R�[�h�ǉ�����
        '------------------------------
        If Not LF_InsTPM100(chk_Option.SelectedItem, Trim$(txt_Guide.Text)) Then
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

    Private Sub txt_Guide_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Guide.TextChanged

        If txt_Guide.Modified = True Then
            Dim lngST As Long

            lngST = txt_Guide.SelectionStart
        ' 2014-04-25 2�o�C�g������������
            'txt_Guide.Text = StrConv(txt_Guide.Text, VbStrConv.Wide)

            If lngST >= 0 Then
                txt_Guide.SelectionStart = lngST
            End If

            '------------------------------
            ' ���͒�����
            '------------------------------
            If GF_LenB(txt_Guide.Text) > 20 Then
                txt_Guide.Text = GF_MidB(txt_Guide.Text, 1, 20)
                txt_Guide.SelectionStart = GF_LenB(txt_Guide.Text)
                Exit Sub
            End If
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F����I�v�V���������݃`�F�b�N����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2004.05.31 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM100_1(ByVal pScpNo As String) As FuncResult

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM100_1 = CNL1920.FuncResult.UnusualEnd

        strSQL = ""
        strSQL = strSQL & "SELECT SCPNO"
        strSQL = strSQL & "  FROM TPM100"
        strSQL = strSQL & " WHERE SCPNO = '" & pScpNo & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        If objData.Tables("com").Rows.Count = 0 Then
            LF_GetTPM100_1 = CNL1920.FuncResult.NormalEnd
        Else
            LF_GetTPM100_1 = CNL1920.FuncResult.CancelEnd
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F����K�C�_���X���݃`�F�b�N����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2004.05.31 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM100_2(ByVal pGuideNM As String) As FuncResult

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
        strSQL = strSQL & "SELECT SCPNO"
        strSQL = strSQL & "  FROM TPM100"
        strSQL = strSQL & " WHERE GUIDE = '" & pGuideNM & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        If objData.Tables("com").Rows.Count = 0 Then
            LF_GetTPM100_2 = CNL1920.FuncResult.NormalEnd
        Else
            LF_GetTPM100_2 = CNL1920.FuncResult.CancelEnd
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�r�b�o�}�X�^�ǉ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2004.05.31 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_InsTPM100(ByVal pScpNo As String, ByVal pGuideNM As String) As Boolean

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_InsTPM100 = False

        If Not GF_InTPM100(pScpNo, pGuideNM) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_InsTPM100 = True

    End Function
End Class
