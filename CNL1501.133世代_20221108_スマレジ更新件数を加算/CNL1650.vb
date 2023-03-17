Public Class CNL1650
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
    Friend WithEvents obj_View As AxSHDocVw.AxWebBrowser
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CNL1650))
        Me.obj_View = New AxSHDocVw.AxWebBrowser()
        CType(Me.obj_View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'obj_View
        '
        Me.obj_View.Enabled = True
        Me.obj_View.Location = New System.Drawing.Point(8, 8)
        Me.obj_View.OcxState = CType(resources.GetObject("obj_View.OcxState"), System.Windows.Forms.AxHost.State)
        Me.obj_View.Size = New System.Drawing.Size(1024, 768)
        Me.obj_View.TabIndex = 0
        '
        'CNL1650
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1040, 782)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.obj_View})
        Me.Name = "CNL1650"
        Me.Text = "CNL1650"
        CType(Me.obj_View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CNL1650_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strAlias As String

        '------------------------------
        ' �G�C���A�X���擾
        '------------------------------
        strAlias = GF_GetAppInfo("PREV_STARTUP")
        If Len(Trim$(strAlias)) = 0 Then
            GoTo SYSTEM_ERROR
        End If

        If Trim$(strAlias) = "/TPM001/TPM010.aspx" Then

        ElseIf Trim$(strAlias) = "/TPP001/TPP010.aspx" Then

            Me.Width = 824
            Me.Height = 648

            obj_View.Width = 800
            obj_View.Height = 600

        End If


        '------------------------------
        ' �t�H�[���Z�b�g�A�b�v
        '------------------------------
        Me.Text = GF_FormText(" - �q�Ȓ[���v���r���[")
        obj_View.Navigate("http://localhost" & strAlias)

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1650_Load")
    End Sub
End Class
