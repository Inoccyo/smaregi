Public Class CNL1532
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_OK As System.Windows.Forms.Button
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents rdo_Sel1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Sel2 As System.Windows.Forms.RadioButton
    Friend WithEvents chk_OverWrite As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.rdo_Sel1 = New System.Windows.Forms.RadioButton()
        Me.rdo_Sel2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.chk_OverWrite = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdo_Sel1
        '
        Me.rdo_Sel1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Sel1.Location = New System.Drawing.Point(24, 32)
        Me.rdo_Sel1.Name = "rdo_Sel1"
        Me.rdo_Sel1.Size = New System.Drawing.Size(248, 24)
        Me.rdo_Sel1.TabIndex = 2
        Me.rdo_Sel1.Text = "���݁A�I�𒆂̏��i���̂ݑΏ�"
        '
        'rdo_Sel2
        '
        Me.rdo_Sel2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Sel2.Location = New System.Drawing.Point(24, 56)
        Me.rdo_Sel2.Name = "rdo_Sel2"
        Me.rdo_Sel2.Size = New System.Drawing.Size(248, 24)
        Me.rdo_Sel2.TabIndex = 3
        Me.rdo_Sel2.Text = "�S�Ă̏��i����Ώ�"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.rdo_Sel2, Me.rdo_Sel1})
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 88)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "�� �����Ώ۔͈͂�I�����ĉ�����"
        '
        'btn_OK
        '
        Me.btn_OK.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_OK.Location = New System.Drawing.Point(112, 136)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(88, 24)
        Me.btn_OK.TabIndex = 5
        Me.btn_OK.Text = "OK"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(208, 136)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(88, 24)
        Me.btn_Cancel.TabIndex = 6
        Me.btn_Cancel.Text = "�L�����Z��"
        '
        'chk_OverWrite
        '
        Me.chk_OverWrite.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_OverWrite.Location = New System.Drawing.Point(72, 104)
        Me.chk_OverWrite.Name = "chk_OverWrite"
        Me.chk_OverWrite.Size = New System.Drawing.Size(240, 24)
        Me.chk_OverWrite.TabIndex = 4
        Me.chk_OverWrite.Text = "�摜���ݒ�̏��i���̂ݑΏ�"
        '
        'CNL1532
        '
        Me.AcceptButton = Me.btn_OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(304, 163)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chk_OverWrite, Me.btn_Cancel, Me.btn_OK, Me.GroupBox1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CNL1532"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CNL1532"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Enum ProcRange
        CurrentOnly = 0
        AllRecord = 1
        Cancel = 9
    End Enum
    Public G_Args As ProcRange
    Public G_ShowOWChk As Boolean

    Private Sub CNL1532_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = GF_FormText(" - �����͈͎w��")

        G_Args = ProcRange.Cancel
        rdo_Sel1.Checked = True
        rdo_Sel2.Checked = False
        chk_OverWrite.Checked = True
        chk_OverWrite.Visible = G_ShowOWChk

    End Sub

    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click
        G_Args = IIf(rdo_Sel1.Checked, ProcRange.CurrentOnly, ProcRange.AllRecord)
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        G_Args = ProcRange.Cancel
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_OverWrite.CheckedChanged

    End Sub
End Class
