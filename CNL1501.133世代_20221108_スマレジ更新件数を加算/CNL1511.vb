Public Class CNL1511
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
    Friend WithEvents lst_TransMenu As System.Windows.Forms.ListBox
    Friend WithEvents btn_OK As System.Windows.Forms.Button
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Trans1 As System.Windows.Forms.Button
    Friend WithEvents btn_Trans2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lst_TransMenu = New System.Windows.Forms.ListBox()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Trans1 = New System.Windows.Forms.Button()
        Me.btn_Trans2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lst_TransMenu
        '
        Me.lst_TransMenu.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lst_TransMenu.ItemHeight = 15
        Me.lst_TransMenu.Location = New System.Drawing.Point(8, 80)
        Me.lst_TransMenu.Name = "lst_TransMenu"
        Me.lst_TransMenu.Size = New System.Drawing.Size(280, 184)
        Me.lst_TransMenu.TabIndex = 0
        '
        'btn_OK
        '
        Me.btn_OK.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_OK.Location = New System.Drawing.Point(104, 272)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(88, 24)
        Me.btn_OK.TabIndex = 1
        Me.btn_OK.Text = "OK"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(200, 272)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(88, 24)
        Me.btn_Cancel.TabIndex = 2
        Me.btn_Cancel.Text = "�L�����Z��"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "�� �ǂ̃��j���[��]�����܂����H"
        '
        'btn_Trans1
        '
        Me.btn_Trans1.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Trans1.Location = New System.Drawing.Point(8, 32)
        Me.btn_Trans1.Name = "btn_Trans1"
        Me.btn_Trans1.Size = New System.Drawing.Size(140, 40)
        Me.btn_Trans1.TabIndex = 5
        Me.btn_Trans1.Text = "���j���[���X�V����"
        '
        'btn_Trans2
        '
        Me.btn_Trans2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Trans2.Location = New System.Drawing.Point(148, 32)
        Me.btn_Trans2.Name = "btn_Trans2"
        Me.btn_Trans2.Size = New System.Drawing.Size(140, 40)
        Me.btn_Trans2.TabIndex = 6
        Me.btn_Trans2.Text = "���j���[��ǉ��]������"
        '
        'CNL1511
        '
        Me.AcceptButton = Me.btn_OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(292, 303)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btn_Trans2, Me.btn_Trans1, Me.Label1, Me.btn_Cancel, Me.btn_OK, Me.lst_TransMenu})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CNL1511"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNL1511"
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' --------------------------------------------------------------------------------
    ' �t�H�[��������`
    ' --------------------------------------------------------------------------------
    Public G_MenuID() As String                                             ' �����]�����j���[�h�c�Q
    Public G_RMenuID() As String                                            ' ���A���^�C���]�����j���[�h�c�Q
    Public G_CNL1511Ret As String                                            ' �]�������Ώۃ��j���[�h�c(�ԋp�l)
    Public G_CNL1511Mode As String                                           ' �]�������敪(�ԋp�l)
    Private L_Mode As typTransMode

    Private Enum typTransMode
        RealTimeTransfar = 0
        SubDataTransfar = 1
    End Enum

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���ǂݍ��ݎ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.12.09 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub CNL1511_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            '------------------------------
            ' �t�H�[�����̐ݒ�
            '------------------------------
            Me.Text = GF_FormText(" - �������j���[�]��")

            '------------------------------
            ' ����������
            '------------------------------
            lst_TransMenu.Items.Clear()
            G_CNL1511Ret = ""
            Call LS_ModeChg(typTransMode.RealTimeTransfar)

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1511_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�]���Ώۃ��j���[�I�𑀍�C�x���g�n���h��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.12.09 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click
        Call LF_SubTransData()
    End Sub
    Private Sub lst_TransMenu_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lst_TransMenu.DoubleClick
        Call LF_SubTransData()
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�����]���f�[�^�����^�]������ �m�F���b�Z�[�W�\��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.12.09 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LF_SubTransData()

        If lst_TransMenu.SelectedIndex = -1 Then Exit Sub

        If GF_Msg("", "�y " & Trim$(GF_LstGetString(lst_TransMenu, lst_TransMenu.SelectedIndex)) & " �z��]�����܂��B" & vbCrLf & "��낵���ł����H", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If
        G_CNL1511Ret = Trim$(GF_LstGetCode(lst_TransMenu, lst_TransMenu.SelectedIndex))
        G_CNL1511Mode = CStr(L_Mode)
        Me.Close()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LF_SubTransData")
    End Sub

    Private Sub btn_Trans1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Trans1.Click
        Call LS_ModeChg(typTransMode.RealTimeTransfar)
    End Sub

    Private Sub btn_Trans2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Trans2.Click
        Call LS_ModeChg(typTransMode.SubDataTransfar)
    End Sub

    Private Sub LS_ModeChg(ByVal pMode As typTransMode)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngCnt As Long
        Dim strWork() As String

        Try
            Select Case pMode
                Case typTransMode.RealTimeTransfar
                    btn_Trans1.BackColor = Color.PaleGreen
                    btn_Trans2.BackColor = Color.FromKnownColor(KnownColor.Control)

                    lst_TransMenu.Items.Clear()
                    If G_RMenuID.Length <> 0 Then
                        If Len(Trim$(G_RMenuID(0))) <> 0 Then
                            For lngCnt = 0 To UBound(G_RMenuID)
                                strWork = Split(G_RMenuID(lngCnt), vbTab)
                                Call GS_SetListBox(lst_TransMenu, strWork(1), strWork(0))
                            Next
                        End If
                    End If

                Case typTransMode.SubDataTransfar
                    btn_Trans1.BackColor = Color.FromKnownColor(KnownColor.Control)
                    btn_Trans2.BackColor = Color.PaleGreen

                    lst_TransMenu.Items.Clear()
                    If G_MenuID.Length <> 0 Then
                        If Len(Trim$(G_MenuID(0))) <> 0 Then
                            For lngCnt = 0 To UBound(G_MenuID)
                                strWork = Split(G_MenuID(lngCnt), vbTab)
                                Call GS_SetListBox(lst_TransMenu, strWork(1), strWork(0))
                            Next
                        End If
                    End If

                Case Else
                    GoTo SYSTEM_ERROR
            End Select
            L_Mode = pMode
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_ModeChg")
    End Sub

End Class
