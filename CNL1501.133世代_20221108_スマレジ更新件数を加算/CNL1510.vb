' --------------------------------------------------------------------------------
' �@�@�@�@�\�F�X�ܓ����V�X�e�� - �N���C�A���g�����e�i���X(���j���[���)
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------

Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Http
Imports TP1901.ServiceCls

Public Class CNL1510
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Menu10 As System.Windows.Forms.Button
    Friend WithEvents btn_Menu9 As System.Windows.Forms.Button
    Friend WithEvents btn_Menu6 As System.Windows.Forms.Button
    Friend WithEvents btn_Menu4 As System.Windows.Forms.Button
    Friend WithEvents btn_Menu1 As System.Windows.Forms.Button
    Friend WithEvents btn_Menu3 As System.Windows.Forms.Button
    Friend WithEvents btn_Menu2 As System.Windows.Forms.Button
    Friend WithEvents btn_Menu5 As System.Windows.Forms.Button
    Friend WithEvents btn_Menu8 As System.Windows.Forms.Button
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_MenuChg As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_AdvChg As System.Windows.Forms.ComboBox
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents btn_Menu11 As System.Windows.Forms.Button
    Friend WithEvents btn_Menu7 As System.Windows.Forms.Button
    Friend WithEvents btn_Menu12 As System.Windows.Forms.Button
    Friend WithEvents btn_Menu13 As System.Windows.Forms.Button
    Friend WithEvents btn_Menu14 As System.Windows.Forms.Button
    Friend WithEvents btn_Menu15 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.stb_Msg = New System.Windows.Forms.StatusBar()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_Menu13 = New System.Windows.Forms.Button()
        Me.btn_Menu11 = New System.Windows.Forms.Button()
        Me.btn_Menu10 = New System.Windows.Forms.Button()
        Me.btn_Menu9 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Menu15 = New System.Windows.Forms.Button()
        Me.btn_Menu14 = New System.Windows.Forms.Button()
        Me.btn_Menu12 = New System.Windows.Forms.Button()
        Me.btn_Menu7 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbo_MenuChg = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbo_AdvChg = New System.Windows.Forms.ComboBox()
        Me.btn_Menu6 = New System.Windows.Forms.Button()
        Me.btn_Menu4 = New System.Windows.Forms.Button()
        Me.btn_Menu1 = New System.Windows.Forms.Button()
        Me.btn_Menu3 = New System.Windows.Forms.Button()
        Me.btn_Menu2 = New System.Windows.Forms.Button()
        Me.btn_Menu5 = New System.Windows.Forms.Button()
        Me.btn_Menu8 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 537)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(864, 24)
        Me.stb_Msg.TabIndex = 0
        Me.stb_Msg.Text = "StatusBar1"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "�t�@�C��(&F)"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "�I��"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox2, Me.GroupBox1})
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(864, 536)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.btn_Menu13, Me.btn_Menu11, Me.btn_Menu10, Me.btn_Menu9})
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 416)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(824, 104)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "�V�X�e���@�����e�i���X"
        '
        'btn_Menu13
        '
        Me.btn_Menu13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Menu13.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Menu13.Location = New System.Drawing.Point(616, 32)
        Me.btn_Menu13.Name = "btn_Menu13"
        Me.btn_Menu13.Size = New System.Drawing.Size(184, 48)
        Me.btn_Menu13.TabIndex = 16
        Me.btn_Menu13.Text = "���㑬��"
        '
        'btn_Menu11
        '
        Me.btn_Menu11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Menu11.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Menu11.Location = New System.Drawing.Point(416, 32)
        Me.btn_Menu11.Name = "btn_Menu11"
        Me.btn_Menu11.Size = New System.Drawing.Size(184, 48)
        Me.btn_Menu11.TabIndex = 15
        Me.btn_Menu11.Text = "�L�b�`���v�����^ ���X�g"
        '
        'btn_Menu10
        '
        Me.btn_Menu10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Menu10.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Menu10.Location = New System.Drawing.Point(216, 32)
        Me.btn_Menu10.Name = "btn_Menu10"
        Me.btn_Menu10.Size = New System.Drawing.Size(184, 48)
        Me.btn_Menu10.TabIndex = 14
        Me.btn_Menu10.Text = "���j���[�`�F�b�N ���X�g"
        '
        'btn_Menu9
        '
        Me.btn_Menu9.Enabled = False
        Me.btn_Menu9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Menu9.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Menu9.Location = New System.Drawing.Point(16, 32)
        Me.btn_Menu9.Name = "btn_Menu9"
        Me.btn_Menu9.Size = New System.Drawing.Size(184, 48)
        Me.btn_Menu9.TabIndex = 13
        Me.btn_Menu9.Text = "�o�b�N�A�b�v�E���J�o��"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btn_Menu15, Me.btn_Menu14, Me.btn_Menu12, Me.btn_Menu7, Me.GroupBox3, Me.GroupBox4, Me.btn_Menu6, Me.btn_Menu4, Me.btn_Menu1, Me.btn_Menu3, Me.btn_Menu2, Me.btn_Menu5, Me.btn_Menu8})
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(824, 384)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "���j���[�f�[�^���쐬���܂�"
        '
        'btn_Menu15
        '
        Me.btn_Menu15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Menu15.Location = New System.Drawing.Point(560, 176)
        Me.btn_Menu15.Name = "btn_Menu15"
        Me.btn_Menu15.Size = New System.Drawing.Size(248, 48)
        Me.btn_Menu15.TabIndex = 13
        Me.btn_Menu15.Text = "�I�v�V�����o�^"
        '
        'btn_Menu14
        '
        Me.btn_Menu14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Menu14.Location = New System.Drawing.Point(288, 176)
        Me.btn_Menu14.Name = "btn_Menu14"
        Me.btn_Menu14.Size = New System.Drawing.Size(248, 48)
        Me.btn_Menu14.TabIndex = 8
        Me.btn_Menu14.Text = "����^���ݕ���ݒ�"
        '
        'btn_Menu12
        '
        Me.btn_Menu12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Menu12.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Menu12.Location = New System.Drawing.Point(16, 176)
        Me.btn_Menu12.Name = "btn_Menu12"
        Me.btn_Menu12.Size = New System.Drawing.Size(248, 48)
        Me.btn_Menu12.TabIndex = 7
        Me.btn_Menu12.Text = "�^�b�`�p�l�� �v���r���["
        '
        'btn_Menu7
        '
        Me.btn_Menu7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Menu7.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Menu7.Location = New System.Drawing.Point(288, 112)
        Me.btn_Menu7.Name = "btn_Menu7"
        Me.btn_Menu7.Size = New System.Drawing.Size(248, 48)
        Me.btn_Menu7.TabIndex = 5
        Me.btn_Menu7.Text = "�������ߏ��i�o�^"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbo_MenuChg})
        Me.GroupBox3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 304)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 56)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "�W�����j���[���w�肵�ĉ�����"
        '
        'cbo_MenuChg
        '
        Me.cbo_MenuChg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_MenuChg.Location = New System.Drawing.Point(16, 24)
        Me.cbo_MenuChg.Name = "cbo_MenuChg"
        Me.cbo_MenuChg.Size = New System.Drawing.Size(224, 23)
        Me.cbo_MenuChg.TabIndex = 10
        Me.cbo_MenuChg.Text = "ComboBox1"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbo_AdvChg})
        Me.GroupBox4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(288, 304)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(248, 56)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "�W���L�����w�肵�ĉ�����"
        '
        'cbo_AdvChg
        '
        Me.cbo_AdvChg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_AdvChg.Location = New System.Drawing.Point(16, 24)
        Me.cbo_AdvChg.Name = "cbo_AdvChg"
        Me.cbo_AdvChg.Size = New System.Drawing.Size(224, 23)
        Me.cbo_AdvChg.TabIndex = 11
        Me.cbo_AdvChg.Text = "ComboBox2"
        '
        'btn_Menu6
        '
        Me.btn_Menu6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Menu6.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Menu6.Location = New System.Drawing.Point(560, 112)
        Me.btn_Menu6.Name = "btn_Menu6"
        Me.btn_Menu6.Size = New System.Drawing.Size(248, 48)
        Me.btn_Menu6.TabIndex = 6
        Me.btn_Menu6.Text = "��ʑ̍فE�t�H���g�ݒ�"
        '
        'btn_Menu4
        '
        Me.btn_Menu4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Menu4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Menu4.Location = New System.Drawing.Point(560, 48)
        Me.btn_Menu4.Name = "btn_Menu4"
        Me.btn_Menu4.Size = New System.Drawing.Size(248, 48)
        Me.btn_Menu4.TabIndex = 3
        Me.btn_Menu4.Text = "���j���[�o�^"
        '
        'btn_Menu1
        '
        Me.btn_Menu1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Menu1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Menu1.Location = New System.Drawing.Point(16, 240)
        Me.btn_Menu1.Name = "btn_Menu1"
        Me.btn_Menu1.Size = New System.Drawing.Size(248, 48)
        Me.btn_Menu1.TabIndex = 9
        Me.btn_Menu1.Text = "�o�n�r���j���[�f�[�^ ��荞��"
        '
        'btn_Menu3
        '
        Me.btn_Menu3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Menu3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Menu3.Location = New System.Drawing.Point(288, 48)
        Me.btn_Menu3.Name = "btn_Menu3"
        Me.btn_Menu3.Size = New System.Drawing.Size(248, 48)
        Me.btn_Menu3.TabIndex = 2
        Me.btn_Menu3.Text = "���i�W�������o�^"
        '
        'btn_Menu2
        '
        Me.btn_Menu2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Menu2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Menu2.Location = New System.Drawing.Point(16, 48)
        Me.btn_Menu2.Name = "btn_Menu2"
        Me.btn_Menu2.Size = New System.Drawing.Size(248, 48)
        Me.btn_Menu2.TabIndex = 1
        Me.btn_Menu2.Text = "���i�o�^"
        '
        'btn_Menu5
        '
        Me.btn_Menu5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Menu5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Menu5.Location = New System.Drawing.Point(16, 112)
        Me.btn_Menu5.Name = "btn_Menu5"
        Me.btn_Menu5.Size = New System.Drawing.Size(248, 48)
        Me.btn_Menu5.TabIndex = 4
        Me.btn_Menu5.Text = "�L���摜�쐬"
        '
        'btn_Menu8
        '
        Me.btn_Menu8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Menu8.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Menu8.Location = New System.Drawing.Point(560, 312)
        Me.btn_Menu8.Name = "btn_Menu8"
        Me.btn_Menu8.Size = New System.Drawing.Size(248, 48)
        Me.btn_Menu8.TabIndex = 12
        Me.btn_Menu8.Text = "���j���[�f�[�^�]��"
        '
        'CNL1510
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(864, 561)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel1, Me.stb_Msg})
        Me.Menu = Me.MainMenu1
        Me.Name = "CNL1510"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���ǂݍ��ݎ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub CNL1510_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        'Dim objChannel As HttpChannel
        Dim strSVHTTPUrl As String

        Try
            '------------------------------
            ' �t�H�[�����̐ݒ�
            '------------------------------
            Me.Text = GF_FormText(" - ���C�����j���[")

            '------------------------------
            ' ����������
            '------------------------------
            Call GS_StatusSetup(stb_Msg)                                    ' �X�e�[�^�X�o�[������
            cbo_MenuChg.DropDownStyle = ComboBoxStyle.DropDownList
            cbo_AdvChg.DropDownStyle = ComboBoxStyle.DropDownList

            ' --- (2004.07.20) �����꒚ �����Ή� ---------------------------
            'btn_Menu1.Visible = False
            Dim strBtnVisible As String
            strBtnVisible = System.Configuration.ConfigurationManager.AppSettings("TECDATA Import")
            If Trim$(strBtnVisible) = "1" Then
                btn_Menu1.Enabled = True
            Else
                btn_Menu1.Enabled = False
            End If
            ' --------------------------------------------------------------

            ' --- (2004.11.12) ��������a��X�����Ή� ----------------------
            Dim strBtnVisible2 As String
            strBtnVisible2 = System.Configuration.ConfigurationManager.AppSettings("Preview")
            If Trim$(strBtnVisible2) = "1" Then
                btn_Menu12.Enabled = True
            Else
                btn_Menu12.Enabled = False
            End If
            ' --------------------------------------------------------------

            '--- (2006.05.23) SYS_TYPE = "2"�A��z���� �̂݁u���ݕ���v�{�^���L�� ----
            If GF_GetAppInfo("SYS_TYPE") = "2" And GF_GetAppInfo("PRICE_TYPE") = "1" Then
                btn_Menu14.Enabled = True
                btn_Menu14.Text = "����^" & GF_GetAppInfo("FREE_MENU_NM") & "�ݒ�"
            Else
                btn_Menu14.Enabled = False
            End If
            '---------------------------------------------------------------

            '--- (2006.06.20) �I�v�V�����o�^���L���̏ꍇ�̂݁u�I�v�V�����o�^�v�{�^���L�� ----
            If GF_GetAppInfo("OPTIONWIN_TYPE") = "1" Then
                btn_Menu15.Enabled = True
            Else
                btn_Menu15.Enabled = False
            End If
            '---------------------------------------------------------------

            '------------------------------
            ' ���j���[/�L���ؑփR���{�ݒ�
            '------------------------------
            Call LS_MenuCmbSetup()
            Call LS_AdvCmbSetup()

            '------------------------------
            ' �Ǘ��}�X�^��茻���ݒ�
            '------------------------------
            Call LS_SetStatus()

            '------------------------------
            ' �T�[�o�ʐM�|�[�g �n�o�d�m
            '------------------------------
            Dim objChannel As New HttpChannel(0)                            ' HTTP�`�����l����p�ӂ���
            strSVHTTPUrl = "http://" & GF_GetAppInfo("SV_IPADDR") & ":" & GF_GetAppInfo("SV_HTTP_PORT") & "/tpuri"
            ChannelServices.RegisterChannel(objChannel, False)
            RemotingConfiguration.RegisterWellKnownClientType( _
                GetType(TP1901.ServiceCls), _
                strSVHTTPUrl)                                               ' �����[�g�T�[�o�[�ւ̐ڑ���p�ӂ���

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1510_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�ؑփR���{�ݒ菈��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_MenuCmbSetup()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' ���j���[���X�g�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM060.MENUID,"
        strSQL = strSQL & "       TPM060.MENUNM"
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " GROUP BY TPM060.MENUID,"
        strSQL = strSQL & "          TPM060.MENUNM"
        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' ���j���[�I���R���{�ݒ�
        '------------------------------
        Try
            cbo_MenuChg.Items.Clear()
            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    GoTo SYSTEM_ERROR
                End If
                Call GS_CboItemSet(cbo_MenuChg, Trim$(objRows("MENUNM")), Trim$(objRows("MENUID")))

                lngCnt = lngCnt + 1
            End While
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_MenuCmbSetup")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�ؑփR���{�ݒ菈��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_AdvCmbSetup()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' �L�����X�g�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM080.ADVGRP_ID,"
        strSQL = strSQL & "       TPM080.ADVGRP_NM"
        strSQL = strSQL & "  FROM TPM080"
        strSQL = strSQL & " GROUP BY TPM080.ADVGRP_ID,"
        strSQL = strSQL & "          TPM080.ADVGRP_NM"
        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �L���I���R���{�ݒ�
        '------------------------------
        Try
            cbo_AdvChg.Items.Clear()
            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    GoTo SYSTEM_ERROR
                End If
                Call GS_CboItemSet(cbo_AdvChg, Trim$(objRows("ADVGRP_NM")), Trim$(objRows("ADVGRP_ID")))

                lngCnt = lngCnt + 1
            End While
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AdvCmbSetup")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���ݐݒ�l �\������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetStatus()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM040.DEFMENUID,"
        strSQL = strSQL & "       TPM040.DEFADVID,"
        strSQL = strSQL & "       TPM040.CLMODE"
        strSQL = strSQL & "  FROM TPM040"
        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            GoTo SYSTEM_ERROR
        End If
        If Not GF_GetRows(objData, 0, objRows) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' ���ݐݒ�l �\������
        '------------------------------
        Try
            Call GS_CboChgSel(cbo_MenuChg, Trim$(objRows("DEFMENUID")))
            Call LS_ChkNoListItem(cbo_MenuChg, Trim$(objRows("DEFMENUID")), "DEFMENUID")
            Call GS_CboChgSel(cbo_AdvChg, Trim$(objRows("DEFADVID")))
            Call LS_ChkNoListItem(cbo_AdvChg, Trim$(objRows("DEFADVID")), "DEFADVID")
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetStatus")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ݒ�l���ݖ����̏ꍇ�̖���������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_ChkNoListItem(ByVal pObj As ComboBox, ByVal pCode As String, ByVal pSetColNm As String)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim strWork As String
        Dim lngCnt As Long
        Dim blnFound As Boolean

        Try
            blnFound = False
            For lngCnt = 0 To pObj.Items.Count - 1
                strWork = GF_CboGetCode(pObj, lngCnt)
                If strWork = pCode Then
                    blnFound = True
                    Exit For
                End If
            Next

            If Not blnFound Then
                strSQL = ""
                strSQL = strSQL & "UPDATE TPM040 SET TPM040." & pSetColNm & " = '" & Space(1) & "'"

                If Not GF_BeginTrans() Then
                    GoTo SYSTEM_ERROR
                End If
                If Not GF_UpdData(strSQL) Then
                    GoTo SYSTEM_ERROR
                End If
                If Not GF_CommitTrans() Then
                    GoTo SYSTEM_ERROR
                End If
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GF_RollbackTrans()
        Call GS_ErrorTerm("LS_ChkNoListItem")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�{�^���i�P�j����������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Menu1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Menu1.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As Form = Nothing

        '------------------------------
        ' ���j���[��`�t�@�C�����݃`�F�b�N
        '------------------------------
        If System.IO.Directory.Exists(GF_GetAppInfo("OES_PATH")) = False Then
            Call GF_Msg("", "�o�n�r�V�X�e�����j���[�f�[�^�̃t�H���_�����o���邱�Ƃ��ł��܂���", MsgBoxStyle.OKOnly, MsgBoxStyle.Critical)
            Exit Sub
        End If

        '------------------------------
        ' �o�n�r�f�[�^�z���ʕ\��
        '------------------------------
        objForm = New CNL1520()
        Me.Enabled = False                                                  ' --- (2003.12.04) �d���N���h�~ ---
        objForm.ShowDialog()
        Me.Enabled = True                                                   ' --- (2003.12.04) �d���N���h�~ ---
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Menu1_Click")
    End Sub

    Private Sub btn_Menu2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Menu2.Click

        ' --- (2004.02.02) �����敪�ǉ��Ή� --------------------------------
        ''------------------------------
        '' �����ϐ���`
        ''------------------------------
        'Dim objForm As Form
        ''------------------------------
        '' �o�n�r�f�[�^�z���ʕ\��
        ''------------------------------
        'objForm = New CNL1530()
        'Me.Enabled = False                                                  ' --- (2003.12.04) �d���N���h�~ ---
        'objForm.ShowDialog()
        'Me.Enabled = True                                                   ' --- (2003.12.04) �d���N���h�~ ---

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As New CNL1530()

        '------------------------------
        ' �o�n�r�f�[�^�z���ʕ\��
        '------------------------------
        Me.Enabled = False
        With objForm
            .pProcKind = CNL1530.PROC_KIND.GooodsEdit
            .ShowDialog()
        End With
        Me.Enabled = True
        ' ------------------------------------------------------------------
    End Sub

    Private Sub btn_Menu3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Menu3.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As Form

        '------------------------------
        ' �o�n�r�f�[�^�z���ʕ\��
        '------------------------------
        objForm = New CNL1540()
        Me.Enabled = False                                                  ' --- (2003.12.04) �d���N���h�~ ---
        objForm.ShowDialog()
        Me.Enabled = True                                                   ' --- (2003.12.04) �d���N���h�~ ---

    End Sub

    Private Sub btn_Menu4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Menu4.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As Form = Nothing

        '------------------------------
        ' �o�n�r�f�[�^�z���ʕ\��
        '------------------------------
        objForm = New CNL1550()
        Me.Enabled = False                                                  ' --- (2003.12.04) �d���N���h�~ ---
        objForm.ShowDialog()
        Me.Enabled = True                                                   ' --- (2003.12.04) �d���N���h�~ ---

        '------------------------------
        ' ���j���[�ؑփR���{�Đ���
        '------------------------------
        Call LS_MenuCmbSetup()
        Call LS_SetStatus()

    End Sub

    Private Sub btn_Menu5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Menu5.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As Form = Nothing

        '------------------------------
        ' �o�n�r�f�[�^�z���ʕ\��
        '------------------------------
        objForm = New CNL1560()
        Me.Enabled = False                                                  ' --- (2003.12.04) �d���N���h�~ ---
        objForm.ShowDialog()
        Me.Enabled = True                                                   ' --- (2003.12.04) �d���N���h�~ ---

        '------------------------------
        ' �L���ؑփR���{�Đ���
        '------------------------------
        Call LS_AdvCmbSetup()
        Call LS_SetStatus()

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�ؑփR���{ �I����ԕω�������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub cbo_MenuChg_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_MenuChg.SelectionChangeCommitted

        If Not GF_BeginTrans() Then
            GoTo SYSTEM_ERROR
        End If
        If Not LF_UpdTPM040_1() Then
            GoTo SYSTEM_ERROR
        End If
        If Not GF_CommitTrans() Then
            GoTo SYSTEM_ERROR
        End If
        Exit Sub

SYSTEM_ERROR:
        Call GF_RollbackTrans()
        Call GS_ErrorTerm("cbo_MenuChg_SelectionChangeCommitted")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���ؑփR���{ �I����ԕω�������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub cbo_AdvChg_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_AdvChg.SelectionChangeCommitted

        If Not GF_BeginTrans() Then
            GoTo SYSTEM_ERROR
        End If
        If Not LF_UpdTPM040_2() Then
            GoTo SYSTEM_ERROR
        End If
        If Not GF_CommitTrans() Then
            GoTo SYSTEM_ERROR
        End If
        Exit Sub

SYSTEM_ERROR:
        Call GF_RollbackTrans()
        Call GS_ErrorTerm("cbo_MenuChg_SelectionChangeCommitted")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�V�X�e���Ǘ��}�X�^ �X�V�����i�P�j - ���j���[�ؑ֏���
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM040_1() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM040_1 = False

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^ �X�V
        '------------------------------
        Try
            strSQL = ""
            strSQL = strSQL & "UPDATE TPM040"
            strSQL = strSQL & "   SET TPM040.DEFMENUID = '" & Trim$(GF_CboGetCode(cbo_MenuChg, cbo_MenuChg.SelectedIndex)) & "',"
            strSQL = strSQL & "       UPDID = '" & GC_UPDID & "',"
            strSQL = strSQL & "       UPDYMD = '" & Now & "'"
        Catch
            Exit Function
        End Try
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If
        Debug.WriteLine("TPM040.DEFMENUID = " & Trim$(GF_CboGetCode(cbo_MenuChg, cbo_MenuChg.SelectedIndex)) & "�ōX�V")

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM040_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�V�X�e���Ǘ��}�X�^ �X�V�����i�Q�j - �L���ؑ֏���
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM040_2() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM040_2 = False

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^�X�V
        '------------------------------
        Try
            strSQL = ""
            strSQL = strSQL & "UPDATE TPM040"
            strSQL = strSQL & "   SET TPM040.DEFADVID = '" & Trim$(GF_CboGetCode(cbo_AdvChg, cbo_AdvChg.SelectedIndex)) & "',"
            strSQL = strSQL & "       UPDID = '" & GC_UPDID & "',"
            strSQL = strSQL & "       UPDYMD = '" & Now & "'"
        Catch
            Exit Function
        End Try
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If
        Debug.WriteLine("TPM040.DEFADVID = " & Trim$(GF_CboGetCode(cbo_AdvChg, cbo_AdvChg.SelectedIndex)) & "�ōX�V")

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM040_2 = True

    End Function

    Private Sub btn_Menu8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Menu8.Click

        Me.Enabled = False                                                  ' --- (2003.12.04) �d���N���h�~ ---

        ' --- (2003.12.04) �d�������h�~�̂��߁A�������e���T�u���W���[���� --
        '------------------------------
        ' ���j���[�f�[�^�]������
        '------------------------------
        ' --- (2003.12.10) ���쐫����̂��߁A�ʃv���V�[�W���ɕύX ----------
        'Call LS_TransMenuData()
        Call LS_TransModeSelect()
        ' ------------------------------------------------------------------
        ' ------------------------------------------------------------------
        Me.Enabled = True                                                   ' --- (2003.12.04) �d���N���h�~ ---

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�f�[�^�]������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.12.04 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    '--- (2006.05.15) �����ύX 
    '    Private Sub LS_TransMenuData(ByVal pSendPath As String, ByVal pStnUse As Boolean)
    Private Sub LS_TransMenuData(ByVal pSendPath As String)

        '------------------------------
        ' ���O�m�F����
        '------------------------------
        If cbo_MenuChg.SelectedIndex = -1 Then
            Call GF_Msg("", "�W�����j���[��I�����ĉ�����", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
            cbo_MenuChg.Select()
            Exit Sub
        End If
        If cbo_AdvChg.SelectedIndex = -1 Then
            Call GF_Msg("", "�W���L����I�����ĉ�����", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
            cbo_AdvChg.Select()
            Exit Sub
        End If

        Select Case LF_ChkMenu()
            Case CNL1920.FuncResult.CancelEnd
                Exit Sub
            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        '------------------------------
        ' �m�F���b�Z�[�W�\��
        '------------------------------
        If GF_Msg("", "���j���[�f�[�^���T�[�o�^�X�e�[�V�����֔z�M���܂��B��낵���ł����H", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        '---(2005.10.05) ���������C�Ή�-------------------------
        ''------------------------------
        '' �X�e�[�V�����f�[�^�o�́^�z�M
        ''------------------------------
        'If pStnUse = True Then
        '    stb_Msg.Panels(0).Text = "�X�e�[�V�����ւ̃f�[�^�z�M�������ł�..."
        '    If Not LF_PutTECData() Then
        '        Call GF_Msg("", _
        '                    "�X�e�[�V�����ւ̃��j���[�f�[�^�z�M�Ɏ��s���܂����B" & vbCrLf & "�ݒ�̌������y�сA�X�e�[�V�����̓d���A�l�b�g���[�N��Ԃ��m�F���ĉ������B", _
        '                    MsgBoxStyle.OKOnly, _
        '                    MsgBoxStyle.Exclamation)
        '        stb_Msg.Panels(0).Text = ""
        '        Exit Sub
        '    End If
        '    stb_Msg.Panels(0).Text = ""
        'End If
        '-----------------------------------------------------

        '------------------------------
        ' ���j���[�摜�ꊇ��������
        '------------------------------
        If Not GF_CreateMenuImage("I05") Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �T�[�o�^�f�[�^�]������
        '------------------------------
        Try
            ' --- (��) ----------------------------------------------------------------------------
            ' �T�[�o�@��̓]����t�H���_���A�N���A����B
            ' �A���A�]����t�H���_���̂��폜���Ȃ����߁A���ʊ֐� GS_DelFiles() �͎g�p���Ă��Ȃ��B
            ' -------------------------------------------------------------------------------------
            Call LS_DelFile(pSendPath)
            If Not GF_Backup("Send to Server", pSendPath, "I06") Then
                GoTo SYSTEM_ERROR
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        '------------------------------
        ' �f�[�^������/CL�f�[�^�]��
        '------------------------------
        Call LS_DataChange(True)

        '------------------------------
        ' �I�����b�Z�[�W�\��
        '------------------------------
        Call GF_Msg("I07", "", MsgBoxStyle.OKOnly, MsgBoxStyle.Information)

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_TransMenuData")
    End Sub

    Private Sub LS_DataChange(ByVal pProcKind As Boolean)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strFileWK As String
        Dim strSendNM As String
        Dim strWork() As String
        Dim lngFileCnt As Long
        Dim objStatus As New CNL1810()

        Try
            lngFileCnt = 0
            If pProcKind = True Then
                lngFileCnt = lngFileCnt + System.IO.Directory.GetFiles(g_udtAppConfig.strOMImgPath, "*.*").GetLength(0)
                lngFileCnt = lngFileCnt + System.IO.Directory.GetFiles(g_udtAppConfig.strOMImgPath2, "*.*").GetLength(0)
                '�X�V 2006/03/10 8�C���`�Ή�
                lngFileCnt = lngFileCnt + System.IO.Directory.GetFiles(g_udtAppConfig.strOMImgPath3, "*.*").GetLength(0)
            End If
            lngFileCnt = lngFileCnt + System.IO.Directory.GetFiles(g_udtAppConfig.strNMImgPath, "*.*").GetLength(0)
            lngFileCnt = lngFileCnt + System.IO.Directory.GetFiles(g_udtAppConfig.strNMImgPath2, "*.*").GetLength(0)
            '�X�V 2006/03/10 8�C���`�Ή�
            lngFileCnt = lngFileCnt + System.IO.Directory.GetFiles(g_udtAppConfig.strNMImgPath3, "*.*").GetLength(0)

            objStatus.Show()                                                    ' �i���X�e�[�^�X�t�H�[���\��
            With objStatus
                .lbl_Msg.Text = "���j���[�f�[�^�̐����㏈�����s���Ă��܂�..."
                .pgs_Status.Minimum = 0
                .pgs_Status.Maximum = lngFileCnt
                .pgs_Status.Value = 0
                .TopMost = True
            End With
            System.Windows.Forms.Application.DoEvents()

            '------------------------------
            ' �������摜�t�H���_�N���A
            '------------------------------
            If pProcKind Then
                For Each strFileWK In System.IO.Directory.GetFiles(g_udtAppConfig.strOMImgPath, "*.*")
                    System.IO.File.SetAttributes(strFileWK, IO.FileAttributes.Normal)
                    System.IO.File.Delete(strFileWK)
                    objStatus.pgs_Status.Value = objStatus.pgs_Status.Value + 1
                Next
                For Each strFileWK In System.IO.Directory.GetFiles(g_udtAppConfig.strOMImgPath2, "*.*")
                    System.IO.File.SetAttributes(strFileWK, IO.FileAttributes.Normal)
                    System.IO.File.Delete(strFileWK)
                    objStatus.pgs_Status.Value = objStatus.pgs_Status.Value + 1
                Next
                For Each strFileWK In System.IO.Directory.GetFiles(g_udtAppConfig.strOMImgPath3, "*.*")
                    System.IO.File.SetAttributes(strFileWK, IO.FileAttributes.Normal)
                    System.IO.File.Delete(strFileWK)
                    objStatus.pgs_Status.Value = objStatus.pgs_Status.Value + 1
                Next
            End If

            '------------------------------
            ' ������^Preview�摜�]��
            '------------------------------
            For Each strFileWK In System.IO.Directory.GetFiles(g_udtAppConfig.strNMImgPath, "*.*")
                strWork = Split(strFileWK, "\")
                strSendNM = g_udtAppConfig.strMenuImgPath & "\" & strWork(UBound(strWork))
                If System.IO.File.Exists(strSendNM) = False Then
                    System.IO.File.Copy(strFileWK, strSendNM)
                End If

                strSendNM = g_udtAppConfig.strOMImgPath & "\" & strWork(UBound(strWork))
                If System.IO.File.Exists(strSendNM) = False Then
                    System.IO.File.Move(strFileWK, strSendNM)
                Else
                    System.IO.File.SetAttributes(strFileWK, IO.FileAttributes.Normal)
                    System.IO.File.Delete(strFileWK)
                End If
                objStatus.pgs_Status.Value = objStatus.pgs_Status.Value + 1
            Next

            For Each strFileWK In System.IO.Directory.GetFiles(g_udtAppConfig.strNMImgPath2, "*.*")
                strWork = Split(strFileWK, "\")
                strSendNM = g_udtAppConfig.strMenuImgPath2 & "\" & strWork(UBound(strWork))
                If System.IO.File.Exists(strSendNM) = False Then
                    System.IO.File.Copy(strFileWK, strSendNM)
                End If

                strSendNM = g_udtAppConfig.strOMImgPath2 & "\" & strWork(UBound(strWork))
                If System.IO.File.Exists(strSendNM) = False Then
                    System.IO.File.Move(strFileWK, strSendNM)
                Else
                    System.IO.File.SetAttributes(strFileWK, IO.FileAttributes.Normal)
                    System.IO.File.Delete(strFileWK)
                End If
                objStatus.pgs_Status.Value = objStatus.pgs_Status.Value + 1
            Next

            '-----------------------------------------
            ' �X�V 2006/03/10 �W�C���`�Ή�
            '-----------------------------------------
            For Each strFileWK In System.IO.Directory.GetFiles(g_udtAppConfig.strNMImgPath3, "*.*")
                strWork = Split(strFileWK, "\")
                strSendNM = g_udtAppConfig.strMenuImgPath3 & "\" & strWork(UBound(strWork))
                If System.IO.File.Exists(strSendNM) = False Then
                    System.IO.File.Copy(strFileWK, strSendNM)
                End If

                strSendNM = g_udtAppConfig.strOMImgPath3 & "\" & strWork(UBound(strWork))
                If System.IO.File.Exists(strSendNM) = False Then
                    System.IO.File.Move(strFileWK, strSendNM)
                Else
                    System.IO.File.SetAttributes(strFileWK, IO.FileAttributes.Normal)
                    System.IO.File.Delete(strFileWK)
                End If
                objStatus.pgs_Status.Value = objStatus.pgs_Status.Value + 1
            Next

            objStatus.Close()
            objStatus.Dispose()

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_DataChange")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�f�[�^�`�F�b�N����
    ' �@�@�\�T�v�F�����ΏۂƂ��郁�j���[�f�[�^�̗L���������؂���
    ' �@���@�@���F
    ' �@�� �� �l�FCNL1920.FuncResult.NormalEnd  : �n�j�f�[�^
    '             CNL1920.FuncResult.CancelEnd  : �m�f�f�[�^
    '             CNL1920.FuncResult.UnusualEnd : �ُ�I��
    ' �@���@�@���F2003.11.20 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_ChkMenu() As FuncResult
        ' �y�`�F�b�N���e�z
        ' �P�D�S�Ẵ��j���[�ɁA�P�ȏ�̃W�����������蓖�Ă��Ă��邩
        ' �Q�D�e���j���[�̒��Ɋ܂܂��A�����ꂩ�̃W�������ɗL���ȏ��i�R�[�h���Œ�P�ȏ゠�邩

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim objData2 As New DataSet()
        Dim objRows2 As DataRow = Nothing
        Dim lngCnt2 As Long
        Dim objData3 As New DataSet()
        Dim blnFound As Boolean

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_ChkMenu = CNL1920.FuncResult.UnusualEnd

        '------------------------------
        ' ���j���[�h�c���X�g�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM060.MENUID,"
        strSQL = strSQL & "       TPM060.MENUNM"
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " WHERE TPM060.GROUPCD = 'J000'"
        strSQL = strSQL & "   AND TPM060.ENABLED = '" & GC_TRUE & "'"
        strSQL = strSQL & " GROUP BY TPM060.MENUID,"
        strSQL = strSQL & "          TPM060.MENUNM"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If
        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "SELECT TPM060.GROUPCD,"
            strSQL = strSQL & "       TPM020.GROUPNM"
            strSQL = strSQL & "  FROM TPM060,"
            strSQL = strSQL & "       TPM020"
            strSQL = strSQL & " WHERE TPM060.GROUPCD <> 'J000'"
            strSQL = strSQL & "   AND TPM060.GROUPCD = TPM020.GROUPCD"
            strSQL = strSQL & "   AND TPM020.GOODSCD = '0000'"
            strSQL = strSQL & "   AND TPM060.ENABLED = '" & GC_TRUE & "'"
            strSQL = strSQL & "   AND TPM060.MENUID  = '" & Trim$(objRows("MENUID")) & "'"
            objData2 = New DataSet()
            If Not GF_GetData(strSQL, objData2) Then
                Exit Function
            End If
            If objData2.Tables("com").Rows.Count = 0 Then
                ' �W�������������������
                Call GF_Msg("", "���j���[�y" & Trim$(objRows("MENUNM")) & "�z�ɃW���������ݒ肳��Ă��܂���", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
                GoTo DATA_ERROR
            End If

            lngCnt2 = 0
            blnFound = False
            While lngCnt2 < objData2.Tables("com").Rows.Count
                If Not GF_GetRows(objData2, lngCnt2, objRows2) Then
                    Exit Function
                End If

                strSQL = ""
                strSQL = strSQL & "SELECT TPM010.GOODSCD"
                strSQL = strSQL & "  FROM TPM010,"
                strSQL = strSQL & "       TPM020"
                strSQL = strSQL & " WHERE TPM020.GROUPCD = '" & Trim$(objRows2("GROUPCD")) & "'"
                strSQL = strSQL & "   AND TPM020.GOODSCD = TPM010.GOODSCD"
                strSQL = strSQL & "   AND TPM020.GOODSCD <> '0000'"
                objData3 = New DataSet()
                If Not GF_GetData(strSQL, objData3) Then
                    Exit Function
                End If

                If objData3.Tables("com").Rows.Count <> 0 Then
                    blnFound = True
                End If

                lngCnt2 = lngCnt2 + 1
            End While

            If blnFound = False Then
                '  ���j���[�ɐݒ肳��Ă���W�������ɗL���Ȃ��̂������������
                Call GF_Msg("", "���j���[�y " & Trim$(objRows("MENUNM")) & " �z�ɐݒ肳��Ă���S�ẴW�������ɁA���i���o�^����Ă��܂���", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
                GoTo DATA_ERROR
            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_ChkMenu = CNL1920.FuncResult.NormalEnd
        Exit Function

DATA_ERROR:
        LF_ChkMenu = CNL1920.FuncResult.CancelEnd
        Exit Function
    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F����f�B���N�g���ȍ~���A�S�č폜����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_DelFile(ByVal pFolder As String)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strFiles() As String
        Dim strFile As String
        Dim strSubFld() As String
        Dim strFld As String

        Try
            '------------------------------
            ' �S�t�@�C���擾 �� �폜
            '------------------------------
            strFiles = System.IO.Directory.GetFiles(pFolder, "*.*")
            For Each strFile In strFiles
                System.IO.File.SetAttributes(strFile, IO.FileAttributes.Normal)
                System.IO.File.Delete(strFile)
            Next

            '------------------------------
            ' �S�T�u�t�H���_�擾
            '------------------------------
            strSubFld = System.IO.Directory.GetDirectories(pFolder)
            For Each strFld In strSubFld
                Call GS_DelFiles(strFld)
            Next
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_DelFile")
    End Sub

    Private Sub btn_Menu9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Menu9.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As Form = Nothing

        '------------------------------
        ' �o�n�r�f�[�^�z���ʕ\��
        '------------------------------
        objForm = New CNL1600()
        Me.Enabled = False                                                  ' --- (2003.12.04) �d���N���h�~ ---
        objForm.ShowDialog()
        Me.Enabled = True                                                   ' --- (2003.12.04) �d���N���h�~ ---

        '------------------------------
        ' ���j���[/�L���ؑփR���{�ݒ�
        '------------------------------
        Call LS_MenuCmbSetup()
        Call LS_AdvCmbSetup()

        '------------------------------
        ' �Ǘ��}�X�^��茻���ݒ�
        '------------------------------
        Call LS_SetStatus()

    End Sub

    Private Sub btn_Menu10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Menu10.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As Form = Nothing

        '------------------------------
        ' �o�n�r�f�[�^�z���ʕ\��
        '------------------------------
        objForm = New CNL1610()
        Me.Enabled = False                                                  ' --- (2003.12.04) �d���N���h�~ ---
        objForm.ShowDialog()
        Me.Enabled = True                                                   ' --- (2003.12.04) �d���N���h�~ ---

    End Sub

    Private Sub btn_Menu6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Menu6.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As Form = Nothing

        '------------------------------
        ' �o�n�r�f�[�^�z���ʕ\��
        '------------------------------
        objForm = New CNL1570()
        Me.Enabled = False                                                  ' --- (2003.12.04) �d���N���h�~ ---
        objForm.ShowDialog()
        Me.Enabled = True                                                   ' --- (2003.12.04) �d���N���h�~ ---

    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub

    ' ======================================================================
    ' --- (2003.12.09) ���j���[���A���֑ؑΉ�                            ---
    ' ======================================================================
    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�T�[�o�^�c�a�T�[�o�ڑ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.12.09 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_SVDBConnect() As Boolean
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strConnect As String
        Dim strDBSVNM As String
        Dim strDBSVDBNM As String
        Dim strDBSVUID As String
        Dim strDBSVPASS As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_SVDBConnect = False
        strDBSVNM = GF_GetAppInfo("SVDB_NM")
        strDBSVDBNM = GF_GetAppInfo("SVDB_DBNM")
        strDBSVUID = GF_GetAppInfo("SVDB_UID")
        strDBSVPASS = GF_GetAppInfo("SVDB_PASSWD")

        '------------------------------
        ' �ڑ������񐶐�
        '------------------------------
        strConnect = "data source=" & Trim$(strDBSVNM) & ";" & _
                     "initial catalog=" & Trim$(strDBSVDBNM) & ";" & _
                     "user id=" & Trim$(strDBSVUID) & ";" & _
                     "password=" & Trim$(strDBSVPASS) & ";"

        '------------------------------
        ' �ڑ�����
        '------------------------------
        Try
            G_objSVConnect = New SqlClient.SqlConnection(strConnect)
            G_objSVConnect.Open()
        Catch
            GoTo SYSTEM_ERROR
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_SVDBConnect = True

        Exit Function

SYSTEM_ERROR:
        LF_SVDBConnect = False
        Exit Function
    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�T�[�o���c�a�ǂݍ��ݏ���(�f�[�^�Z�b�g����)
    ' �@�@�\�T�v�F���͈������A�f�[�^�Z�b�g�𐶐����܂��B�܂��A���֐��̏o�͈�����
    '�@�@�@�@�@ �@comGetRows()�֐����g�p���邱�ƂŎQ�Ƃ��邱�Ƃ��ł��܂��B
    ' �@���@�@���FpstrSQL          �Q�Ƃr�p�k��
    '�@�@�@�@�@ �FpSqlDataReader   �Q�ƌ���
    ' �@�� �� �l�F[True] ���� / [False] ���s
    ' �@���@�@���F2003.12.09 SORUN �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_SVGetData(ByVal pstrSQL As String, _
                                  ByRef pdstData As DataSet) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objAdapter As SqlClient.SqlDataAdapter

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_SVGetData = False

        '------------------------------
        ' �c�a���o����
        '------------------------------
        Try
            objAdapter = New SqlClient.SqlDataAdapter(pstrSQL, G_objSVConnect)
            objAdapter.Fill(pdstData, "com")
        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_SVGetData = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�������j���[�f�[�^�]������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.12.04 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    'Private Sub LS_TransMenuData2(ByVal pSendPath As String, ByVal pSVTPM060 As DataSet, ByVal pStnUse As Boolean)
    '---(2006.05.15) 
    'Private Sub LS_TransMenuData2(ByVal pSendPath As String, ByVal pSVTPM060 As DataSet, ByVal pStnUse As Boolean, ByVal pSVTPM010 As DataSet)
    Private Sub LS_TransMenuData2(ByVal pSendPath As String, ByVal pSVTPM060 As DataSet, ByVal pSVTPM010 As DataSet)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim lngCnt As Long
        Dim objData As New DataSet()
        Dim objData2 As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim objForm As New CNL1511()
        Dim strRMenuID As String = Nothing
        Dim objCSCls As TP1901.ServiceCls

        '------------------------------
        ' ���O�m�F����
        '------------------------------
        Select Case LF_ChkMenu()                                            ' --- (2003.11.20) ���j���[�f�[�^�̗L�������`�F�b�N���� ---
            Case CNL1920.FuncResult.CancelEnd
                Exit Sub
            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        '------------------------------
        ' ���A���^�C���]�����j���[�h�c
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM060.MENUID,"
        strSQL = strSQL & "       TPM060.MENUNM"
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " WHERE TPM060.MENUID IN ("
        lngCnt = 0
        While lngCnt < pSVTPM060.Tables("com").Rows.Count
            If Not GF_GetRows(pSVTPM060, lngCnt, objRows) Then
                GoTo SYSTEM_ERROR
            End If
            If lngCnt <> 0 Then
                strSQL = strSQL & ","
            End If
            strSQL = strSQL & "'" & Trim$(objRows("MENUID")) & "'"
            lngCnt = lngCnt + 1
        End While
        strSQL = strSQL & ")"
        strSQL = strSQL & " GROUP BY TPM060.MENUID,"
        strSQL = strSQL & "          TPM060.MENUNM"
        strSQL = strSQL & " ORDER BY TPM060.MENUID"
        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �����]�����j���[�h�c�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM060.MENUID, TPM060.MENUNM"
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " WHERE TPM060.MENUID NOT IN("
        lngCnt = 0
        While lngCnt < pSVTPM060.Tables("com").Rows.Count
            If Not GF_GetRows(pSVTPM060, lngCnt, objRows) Then
                GoTo SYSTEM_ERROR
            End If
            If lngCnt <> 0 Then
                strSQL = strSQL & ","
            End If
            strSQL = strSQL & "'" & Trim$(objRows("MENUID")) & "'"
            lngCnt = lngCnt + 1
        End While
        strSQL = strSQL & ")"
        strSQL = strSQL & " GROUP BY TPM060.MENUID, TPM060.MENUNM"
        strSQL = strSQL & " ORDER BY TPM060.MENUID"
        If Not GF_GetData(strSQL, objData2) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �]���\���j���[���`�F�b�N
        '------------------------------
        If objData.Tables("com").Rows.Count = 0 And _
           objData2.Tables("com").Rows.Count = 0 Then
            Call GF_Msg("", "�]���ł��郁�j���[������܂���B" & _
                            vbCrLf & _
                            "���j���[��V���ɍ쐬���A�ēx���������s���ĉ������B", _
                            MsgBoxStyle.OKOnly, _
                            MsgBoxStyle.Information)
            GoTo OTHER_ERROR
        End If

        '------------------------------
        ' �]���Ώۃ��j���[�I����ʕ\��
        '------------------------------
        lngCnt = 0
        Erase objForm.G_RMenuID
        Erase objForm.G_MenuID
        ReDim objForm.G_RMenuID(objData.Tables("com").Rows.Count - 1)
        ReDim objForm.G_MenuID(objData2.Tables("com").Rows.Count - 1)

        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                GoTo SYSTEM_ERROR
            End If
            objForm.G_RMenuID(lngCnt) = Trim$(objRows("MENUID")) & vbTab & Trim$(objRows("MENUNM"))
            lngCnt = lngCnt + 1
        End While

        lngCnt = 0
        While lngCnt < objData2.Tables("com").Rows.Count
            If Not GF_GetRows(objData2, lngCnt, objRows) Then
                GoTo SYSTEM_ERROR
            End If
            objForm.G_MenuID(lngCnt) = Trim$(objRows("MENUID")) & vbTab & Trim$(objRows("MENUNM"))
            lngCnt = lngCnt + 1
        End While
        objForm.ShowDialog()                                                ' �I����ʕ\��
        If Len(Trim$(objForm.G_CNL1511Ret)) = 0 Then
            GoTo OTHER_ERROR
        End If

        '------------------------------
        ' �����j���[�h�c�擾����
        '------------------------------
        If Trim$(objForm.G_CNL1511Mode) = "0" Then
            strRMenuID = ""
            Select Case LF_GetRTMenuID(pSVTPM060, strRMenuID)
                Case CNL1920.FuncResult.NormalEnd
                    If Len(Trim$(strRMenuID)) = 0 Then
                        GoTo SYSTEM_ERROR
                    End If
                Case CNL1920.FuncResult.CancelEnd
                    '--- (2006.01.23) �\�����b�Z�[�W�ύX --------------------------------------
                    '--------------------------------------------------------------------------
                    Call GF_Msg("", "�T�[�o�[���̋Ɩ����I��������ԂŁA������x���Ȃ����Ă��������B", MsgBoxStyle.OKOnly, MsgBoxStyle.Information)
                    'Call GF_Msg("", "���A���^�C���X�V�\�񐔂�������ɒB���܂���" & vbCrLf & "����ȏ�X�V�]�����s�Ȃ����Ƃ͂ł��܂���", MsgBoxStyle.OKOnly, MsgBoxStyle.Information)
                    '--------------------------------------------------------------------------
                    GoTo OTHER_ERROR
                Case Else
                    GoTo SYSTEM_ERROR
            End Select
        End If

        '------------------------------
        ' �X�e�[�V�����f�[�^�o�́^�z�M
        '------------------------------
        '-- (2006.05.15)
        'If pStnUse = True Then

        '    ' --- (2005.10.05) ���������C�Ή� --------------------------------
        '    '' �����ŁA������ pSVTPM010 �ƁA�N���C�A���g���TPM010���r���āA
        '    ''�s��v������� True �^���S��v�Ȃ�� False ��ԋp����֐��ɂ��A������s��
        '    'If LF_ChkTPM010Diff(pSVTPM010, blnStnDLL) = False Then
        '    '    GoTo SYSTEM_ERROR
        '    'End If
        '    'If blnStnDLL Then
        '    '    If GF_Msg("", "�n���f�B�̖����c�k�k���K�v�ɂȂ�܂��B" & vbCrLf & "���s���܂����H", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
        '    '        stb_Msg.Panels(0).Text = "�X�e�[�V�����ւ̃f�[�^�z�M�������ł�..."
        '    '        If Not LF_PutTECData() Then
        '    '            Call GF_Msg("", _
        '    '                        "�X�e�[�V�����ւ̃��j���[�f�[�^�z�M�Ɏ��s���܂����B" & vbCrLf & "�ݒ�̌������y�сA�X�e�[�V�����̓d���A�l�b�g���[�N��Ԃ��m�F���ĉ������B", _
        '    '                        MsgBoxStyle.OKOnly, _
        '    '                        MsgBoxStyle.Exclamation)
        '    '            stb_Msg.Panels(0).Text = ""
        '    '            GoTo OTHER_ERROR
        '    '        End If
        '    '        stb_Msg.Panels(0).Text = ""
        '    '    Else
        '    '        GoTo OTHER_ERROR
        '    '    End If
        '    'End If
        '    ' --------------------------------------------------------------
        'End If

        '------------------------------
        ' ���j���[�摜�ꊇ��������
        '------------------------------
        Select Case Trim$(objForm.G_CNL1511Mode)
            Case "0"                                                        ' ���A���^�C���]������

                '------------------------------
                ' �T�[�o�֏����J�n��񑗐M
                '------------------------------
                objCSCls = New TP1901.ServiceCls()
                Call objCSCls.CallServer(PROC_MSG.PROC_START, "", "")

                '------------------------------
                ' �摜�ꊇ��������
                '------------------------------
                If Not GF_CreateMenuImage("I05", Trim$(objForm.G_CNL1511Ret), CNL1910.typCreateMode.RealTimeTransfar, strRMenuID) Then
                    Call objCSCls.CallServer(PROC_MSG.PROC_ERRORSTOP, "", "")
                    GoTo SYSTEM_ERROR
                End If

                '------------------------------
                ' �T�[�o�]������
                '------------------------------
                Call LS_DelFile(pSendPath)
                If Not LF_PutMenuData(pSendPath, Trim$(objForm.G_CNL1511Ret), strRMenuID) Then
                    Call objCSCls.CallServer(PROC_MSG.PROC_ERRORSTOP, "", "")
                    GoTo SYSTEM_ERROR
                End If

                '------------------------------
                ' �T�[�o�֏����I����񑗐M
                '------------------------------
                Call objCSCls.CallServer(PROC_MSG.PROC_END, Trim$(objForm.G_CNL1511Ret), strRMenuID)
                objCSCls = Nothing

            Case "1"                                                        ' �����f�[�^�]������

                '------------------------------
                ' �摜�ꊇ��������
                '------------------------------
                If Not GF_CreateMenuImage("I05", Trim$(objForm.G_CNL1511Ret), CNL1910.typCreateMode.SubDataTransfar) Then
                    GoTo SYSTEM_ERROR
                End If

                '------------------------------
                ' �T�[�o�]������
                '------------------------------
                Call LS_DelFile(pSendPath)
                If Not LF_PutMenuData(pSendPath, Trim$(objForm.G_CNL1511Ret)) Then
                    GoTo SYSTEM_ERROR
                End If

            Case Else
                GoTo SYSTEM_ERROR
        End Select

        '------------------------------
        ' �f�[�^������/CL�f�[�^�]��
        '------------------------------
        Call LS_DataChange(False)

        '------------------------------
        ' �I�����b�Z�[�W�\��
        '------------------------------
        Call GF_Msg("I07", "", MsgBoxStyle.OKOnly, MsgBoxStyle.Information)

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_TransMenuData2")
        Exit Sub
OTHER_ERROR:
        Exit Sub
    End Sub

    ' --- (2004.10.05) ���n��Q���C ----------------------------------------
    Private Function LF_ChkTPM010Diff(ByVal pSVTPM010 As DataSet, ByRef pResult As Boolean) As Boolean

        ' �s��v������� True �^���S��v�Ȃ�� False ��ԋp
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim objRows2 As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_ChkTPM010Diff = False
        pResult = False

        '------------------------------
        ' �N���C�A���g���TPM010�S���擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        strSQL = strSQL & "       TPM010.GOODSNMJ3,"
        strSQL = strSQL & "       TPM010.GOODSNMJ4,"
        strSQL = strSQL & "       TPM010.SCPNO01,"
        strSQL = strSQL & "       TPM010.SCPNO02,"
        strSQL = strSQL & "       TPM010.SCPNO03,"
        strSQL = strSQL & "       TPM010.SCPNO04,"
        strSQL = strSQL & "       TPM010.SCPNO05,"
        strSQL = strSQL & "       TPM010.SCPNO06,"
        strSQL = strSQL & "       TPM010.SCPNO07,"
        strSQL = strSQL & "       TPM010.SCPNO08,"
        strSQL = strSQL & "       TPM010.SCPNO09,"
        strSQL = strSQL & "       TPM010.SCPNO10,"
        strSQL = strSQL & "       TPM010.SCPNO11,"
        strSQL = strSQL & "       TPM010.SCPNO12,"
        strSQL = strSQL & "       TPM010.KCPSTATUS,"
        strSQL = strSQL & "       TPM010.HTLNM1,"
        strSQL = strSQL & "       TPM010.HTLNM2,"
        '�X�V 2006/03/10 DB�ǉ����ڕ�
        strSQL = strSQL & "       TPM010.SPFLG,"
        strSQL = strSQL & "       TPM010.NEWFLG"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"
        objData = New DataSet()
        If GF_GetData(strSQL, objData) = False Then
            Exit Function
        End If

        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count
            If GF_GetRows(objData, lngCnt, objRows) = False Then
                Exit Function
            End If
            If GF_GetRows(pSVTPM010, lngCnt, objRows2) = False Then
                Exit Function
            End If

            '------------------------------
            ' �s��v�`�F�b�N
            '------------------------------
            If Trim$(objRows("GOODSNMJ")) <> Trim$(objRows2("GOODSNMJ")) Then
                'MsgBox("GOODSNMJ �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("GOODSNMJ2")) <> Trim$(objRows2("GOODSNMJ2")) Then
                'MsgBox("GOODSNMJ2 �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("GOODSNMJ3")) <> Trim$(objRows2("GOODSNMJ3")) Then
                'MsgBox("GOODSNMJ3 �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("GOODSNMJ4")) <> Trim$(objRows2("GOODSNMJ4")) Then
                'MsgBox("GOODSNMJ4 �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("SCPNO01")) <> Trim$(objRows2("SCPNO01")) Then
                'MsgBox("SCPNO01 �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("SCPNO02")) <> Trim$(objRows2("SCPNO02")) Then
                'MsgBox("SCPNO02 �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("SCPNO03")) <> Trim$(objRows2("SCPNO03")) Then
                'MsgBox("SCPNO03 �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("SCPNO04")) <> Trim$(objRows2("SCPNO04")) Then
                'MsgBox("SCPNO04 �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("SCPNO05")) <> Trim$(objRows2("SCPNO05")) Then
                'MsgBox("SCPNO05 �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("SCPNO06")) <> Trim$(objRows2("SCPNO06")) Then
                'MsgBox("SCPNO06 �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("SCPNO07")) <> Trim$(objRows2("SCPNO07")) Then
                'MsgBox("SCPNO07 �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("SCPNO08")) <> Trim$(objRows2("SCPNO08")) Then
                'MsgBox("SCPNO08 �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("SCPNO09")) <> Trim$(objRows2("SCPNO09")) Then
                'MsgBox("SCPNO09 �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("SCPNO10")) <> Trim$(objRows2("SCPNO10")) Then
                'MsgBox("SCPNO10 �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("SCPNO11")) <> Trim$(objRows2("SCPNO11")) Then
                'MsgBox("SCPNO11 �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("SCPNO12")) <> Trim$(objRows2("SCPNO12")) Then
                'MsgBox("SCPNO12 �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("KCPSTATUS")) <> Trim$(objRows2("KCPSTATUS")) Then
                'MsgBox("KCPSTATUS �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("HTLNM1")) <> Trim$(objRows2("HTLNM1")) Then
                'MsgBox("HTLNM1 �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("HTLNM2")) <> Trim$(objRows2("HTLNM2")) Then
                'MsgBox("HTLNM2 �ŕs��v�@���i����[" & objRows("GOODSNMJ") & "]")
                pResult = True
                Exit While
            End If
            '---------------------------------------
            '�X�V 2006/03/10 �c�a���ڒǉ���
            '---------------------------------------
            If Trim$(objRows("SPFLG")) <> Trim$(objRows2("SPFLG")) Then
                'MsgBox("SPFLG �ŕs��v�@���i����[" & objRows("SPFLG") & "]")
                pResult = True
                Exit While
            End If
            If Trim$(objRows("NEWFLG")) <> Trim$(objRows2("NEWFLG")) Then
                'MsgBox("NEWFLG �ŕs��v�@���i����[" & objRows("NEWFLG") & "]")
                pResult = True
                Exit While
            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_ChkTPM010Diff = True

    End Function
    ' ----------------------------------------------------------------------

    Private Function LF_GetRTMenuID(ByVal pSVTPM060 As DataSet, ByRef pMenuID As String) As FuncResult

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strRMenu() As String = Nothing
        Dim lngRMenu As Long
        Dim strWork As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetRTMenuID = CNL1920.FuncResult.UnusualEnd

        '------------------------------
        ' ���j���[��`�e�[�u���擾
        '------------------------------
        lngCnt = 0
        lngRMenu = 0
        While lngCnt < pSVTPM060.Tables("com").Rows.Count
            If Not GF_GetRows(pSVTPM060, lngCnt, objRows) Then
                Exit Function
            End If

            If Mid$(Trim$(objRows("MENUID")), 1, 1) = "R" Then
                ReDim Preserve strRMenu(lngRMenu)
                strRMenu(lngRMenu) = Trim$(objRows("MENUID"))
                lngRMenu = lngRMenu + 1
            End If

            lngCnt = lngCnt + 1
        End While

        If IsNothing(strRMenu) Then
            pMenuID = "R00"
            GoTo EXIT_FUNC
        End If
        If Mid$(strRMenu(UBound(strRMenu)), 2, 2) = "99" Then
            ' �󂫔Ԍ���
            lngCnt = 0
            For Each strWork In strRMenu
                If lngCnt <> CLng(Mid$(strWork, 2, 2)) Then
                    pMenuID = "R" & Format$(lngCnt, "00")
                    GoTo EXIT_FUNC
                End If
                lngCnt = lngCnt + 1
            Next
            LF_GetRTMenuID = CNL1920.FuncResult.CancelEnd
            pMenuID = ""
            Exit Function

        Else
            ' �ŏI�̔Ԓl + 1 ��ԋp
            pMenuID = "R" & Format$(CLng(Mid$(strRMenu(UBound(strRMenu)), 2, 2)) + 1, "00")
        End If

EXIT_FUNC:
        LF_GetRTMenuID = CNL1920.FuncResult.NormalEnd

    End Function

    Private Function LF_PutMenuData(ByVal pSendPath As String, ByVal pTargetMID As String, Optional ByVal pRMenuID As String = "") As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strTBLPath As String
        Dim strITMPath As String
        Dim strGNRPath As String
        Dim strMNUPath As String
        '------------------------------
        '�X�V 2006/03/10 8�C���`�Ή�
        '------------------------------
        Dim strMNUPath2 As String
        Dim strMNUPath3 As String
        Dim strSourcePath As String
        Dim objStatus As New CNL1810()
        Dim objLog As System.IO.StreamWriter

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_PutMenuData = False
        strTBLPath = pSendPath & "\" & CNL1910.LC_TBLBK_PATH
        strITMPath = pSendPath & "\" & CNL1910.LC_ITMBK_PATH
        strGNRPath = pSendPath & "\" & CNL1910.LC_GRPBK_PATH
        strMNUPath = pSendPath & "\" & CNL1910.LC_MNUBK_PATH
        strMNUPath2 = pSendPath & "\" & CNL1910.LC_MNUBK2_PATH
        strMNUPath3 = pSendPath & "\" & CNL1910.LC_MNUBK3_PATH

        objStatus.Show()                                                    ' �i���X�e�[�^�X�t�H�[���\��
        With objStatus
            .lbl_Msg.Text = "���j���[�f�[�^�]�����ł��B���΂炭���҂���������..."
            .pgs_Status.Minimum = 0
            '.pgs_Status.Maximum = 100
            '�X�V 2006/03/10 �i���X�e�[�^�X�o�[�ő�l�ύX�i8�C���`�ǉ��ɔ����j
            .pgs_Status.Maximum = 120
            .pgs_Status.Value = 0
            .TopMost = True
        End With
        System.Windows.Forms.Application.DoEvents()

        '------------------------------
        ' �e�e�[�u���b�r�u�����]��
        '------------------------------
        If System.IO.Directory.Exists(strTBLPath) = False Then              ' �]����p�X�m��
            System.IO.Directory.CreateDirectory(strTBLPath)
        End If
        If Not LF_TBL2CSV(strTBLPath, "TPM010") Then
            objStatus.Close()
            Exit Function
        End If
        objStatus.pgs_Status.Value = 10
        If Not LF_TBL2CSV(strTBLPath, "TPM100") Then
            objStatus.Close()
            Exit Function
        End If
        objStatus.pgs_Status.Value = objStatus.pgs_Status.Value + 10
        If Not LF_TBL2CSV(strTBLPath, "TPM020") Then
            objStatus.Close()
            Exit Function
        End If
        objStatus.pgs_Status.Value = objStatus.pgs_Status.Value + 10
        If Not LF_TBL2CSV2(strTBLPath, pTargetMID, IIf(Len(Trim$(pRMenuID)) = 0, pTargetMID, pRMenuID)) Then
            objStatus.Close()
            Exit Function
        End If
        '--- (2006.02.07) TPM150�ǉ� ----------------------------------------------------------------------------------------------
        If Not LF_TBL2CSV3(strTBLPath, pTargetMID, IIf(Len(Trim$(pRMenuID)) = 0, pTargetMID, pRMenuID)) Then
            objStatus.Close()
            Exit Function
        End If
        '--------------------------------------------------------------------------------------------------------------------------
        '--- (2006.04.26) ���ݕ���p�e�[�u���ǉ� ----------------------------------------------------------------------------------
        If Not LF_TBL2CSV(strTBLPath, "TPM160") Then
            objStatus.Close()
            Exit Function
        End If
        If Not LF_TBL2CSV(strTBLPath, "TPM170") Then
            objStatus.Close()
            Exit Function
        End If
        If Not LF_TBL2CSV(strTBLPath, "TPM180") Then
            objStatus.Close()
            Exit Function
        End If
        '--------------------------------------------------------------------------------------------------------------------------
        objStatus.pgs_Status.Value = objStatus.pgs_Status.Value + 10
        If Not LF_TBL2CSV(strTBLPath, "TPD020", "TPD020.MENUID = '" & IIf(Len(Trim$(pRMenuID)) = 0, pTargetMID, pRMenuID) & "' OR TPD020.MENUID = '" & Space(3) & "'") Then
            objStatus.Close()
            Exit Function
        End If
        objStatus.pgs_Status.Value = objStatus.pgs_Status.Value + 10
        If Not LF_TBL2CSV(strTBLPath, "TPD025", "TPD025.MENUID = '" & IIf(Len(Trim$(pRMenuID)) = 0, pTargetMID, pRMenuID) & "' OR TPD025.MENUID = '" & Space(3) & "'") Then
            objStatus.Close()
            Exit Function
        End If
        objStatus.pgs_Status.Value = objStatus.pgs_Status.Value + 10
        '---------------------------------------------------
        '�X�V 2006/03/10 8�C���`�Ή�
        '---------------------------------------------------
        If Not LF_TBL2CSV(strTBLPath, "TPD026", "TPD026.MENUID = '" & IIf(Len(Trim$(pRMenuID)) = 0, pTargetMID, pRMenuID) & "' OR TPD026.MENUID = '" & Space(3) & "'") Then
            objStatus.Close()
            Exit Function
        End If
        objStatus.pgs_Status.Value = objStatus.pgs_Status.Value + 10

        '------------------------------
        ' ���i�摜�]��
        '------------------------------
        strSourcePath = GF_GetAppInfo("ITEM_PATH")
        If Len(Trim$(strSourcePath)) = 0 Then Exit Function
        If Not LF_SubImageCopy(strSourcePath, strITMPath) Then
            objStatus.Close()
            Exit Function
        End If
        objStatus.pgs_Status.Value = objStatus.pgs_Status.Value + 10

        '------------------------------
        ' �W�������摜�]��
        '------------------------------
        strSourcePath = GF_GetAppInfo("GROUP_PATH")
        If Len(Trim$(strSourcePath)) = 0 Then Exit Function
        If Not LF_SubImageCopy(strSourcePath, strGNRPath) Then
            objStatus.Close()
            Exit Function
        End If
        objStatus.pgs_Status.Value = objStatus.pgs_Status.Value + 10

        '------------------------------
        ' ���j���[�����摜�]��(�����̂�)
        '------------------------------
        strSourcePath = GF_GetAppInfo("NMIMG")
        If Len(Trim$(strSourcePath)) = 0 Then Exit Function
        If Not LF_SubImageCopy(strSourcePath, strMNUPath, "*.*") Then
            objStatus.Close()
            Exit Function
        End If
        objStatus.pgs_Status.Value = objStatus.pgs_Status.Value + 10

        strSourcePath = GF_GetAppInfo("NMIMG2")
        If Len(Trim$(strSourcePath)) = 0 Then Exit Function
        If Not LF_SubImageCopy(strSourcePath, strMNUPath2, "*.*") Then
            objStatus.Close()
            Exit Function
        End If
        objStatus.pgs_Status.Value = objStatus.pgs_Status.Value + 10

        strSourcePath = GF_GetAppInfo("NMIMG3")
        If Len(Trim$(strSourcePath)) = 0 Then Exit Function
        If Not LF_SubImageCopy(strSourcePath, strMNUPath3, "*.*") Then
            objStatus.Close()
            Exit Function
        End If
        objStatus.pgs_Status.Value = objStatus.pgs_Status.Value + 10


        objStatus.Close()

        '------------------------------
        ' ���O�t�@�C���o��
        '------------------------------
        objLog = New System.IO.StreamWriter(pSendPath & "\" & GC_BKLOG_NM, False, System.Text.Encoding.Default)
        With objLog
            .Write(Now & vbTab & "SUB_SEND" & vbTab & g_udtAppConfig.strAppVersion)
            .Close()
        End With

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_PutMenuData = True

    End Function

    Private Function LF_TBL2CSV(ByVal pPutPath As String, ByVal pTBLNM As String, Optional ByVal pWHERE As String = "") As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strCol As String
        Dim strCSV As String
        Dim strPutNM As String
        Dim objSW As System.IO.StreamWriter
        Dim lngColCnt As Long

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_TBL2CSV = False
        strPutNM = pPutPath & "\" & pTBLNM & ".txt"

        '------------------------------
        ' �o�͂b�r�u�t�@�C���I�[�v��
        '------------------------------
        If System.IO.File.Exists(strPutNM) = True Then
            System.IO.File.SetAttributes(strPutNM, IO.FileAttributes.Normal)
            System.IO.File.Delete(strPutNM)
        End If
        objSW = New System.IO.StreamWriter(strPutNM, True, System.Text.Encoding.Default)
        objSW.BaseStream.Seek(0, IO.SeekOrigin.End)

        '------------------------------
        ' �Ώۃe�[�u���擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM " & pTBLNM
        If Len(Trim(pWHERE)) <> 0 Then
            strSQL = strSQL & " WHERE " & pWHERE
        End If
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If

            strCSV = ""
            lngColCnt = 0
            For Each strCol In objRows.ItemArray
                If lngColCnt <> 0 Then
                    strCSV = strCSV & vbTab
                End If
                If Len(Trim$(strCol)) = 0 Then
                    strCol = Space(1)
                End If
                strCSV = strCSV & strCol
                lngColCnt = lngColCnt + 1
            Next
            objSW.WriteLine(strCSV)
            lngCnt = lngCnt + 1
        End While

        objSW.Close()

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_TBL2CSV = True

    End Function

    Private Function LF_TBL2CSV2(ByVal pPutPath As String, ByVal pOrgMenuID As String, ByVal pRMenuID As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strCol As String
        Dim strCSV As String
        Dim strPutNM As String
        Dim objSW As System.IO.StreamWriter

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_TBL2CSV2 = False
        strPutNM = pPutPath & "\TPM060.txt"

        '------------------------------
        ' �o�͂b�r�u�t�@�C���I�[�v��
        '------------------------------
        If System.IO.File.Exists(strPutNM) = True Then
            System.IO.File.SetAttributes(strPutNM, IO.FileAttributes.Normal)
            System.IO.File.Delete(strPutNM)
        End If
        objSW = New System.IO.StreamWriter(strPutNM, True, System.Text.Encoding.Default)
        objSW.BaseStream.Seek(0, IO.SeekOrigin.End)

        '------------------------------
        ' �Ώۃe�[�u���擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT '" & pRMenuID & "',"
        strSQL = strSQL & "       TPM060.MENUNM,"
        strSQL = strSQL & "       TPM060.MENUGRPID,"
        strSQL = strSQL & "       TPM060.MENUGRPNM,"
        strSQL = strSQL & "       TPM060.MENUSTYLE,"
        strSQL = strSQL & "       TPM060.GROUPCD,"
        strSQL = strSQL & "       TPM060.DISPORDER,"
        strSQL = strSQL & "       TPM060.PRICEDISP,"
        strSQL = strSQL & "       TPM060.GROUPKBN,"
        strSQL = strSQL & "       TPM060.ENABLED,"
        strSQL = strSQL & "       TPM060.UPDID,"
        strSQL = strSQL & "       TPM060.UPDYMD"
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " WHERE TPM060.MENUID = '" & pOrgMenuID & "'"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If

            strCSV = ""
            For Each strCol In objRows.ItemArray
                If Len(Trim$(strCSV)) <> 0 Then
                    strCSV = strCSV & vbTab
                End If
                strCSV = strCSV & strCol
            Next
            objSW.WriteLine(strCSV)
            lngCnt = lngCnt + 1
        End While

        objSW.Close()

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_TBL2CSV2 = True

    End Function

    Private Function LF_TBL2CSV3(ByVal pPutPath As String, ByVal pOrgMenuID As String, ByVal pRMenuID As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strCol As String
        Dim strCSV As String
        Dim strPutNM As String
        Dim objSW As System.IO.StreamWriter

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_TBL2CSV3 = False
        strPutNM = pPutPath & "\TPM150.txt"

        '------------------------------
        ' �o�͂b�r�u�t�@�C���I�[�v��
        '------------------------------
        If System.IO.File.Exists(strPutNM) = True Then
            System.IO.File.SetAttributes(strPutNM, IO.FileAttributes.Normal)
            System.IO.File.Delete(strPutNM)
        End If
        objSW = New System.IO.StreamWriter(strPutNM, True, System.Text.Encoding.Default)
        objSW.BaseStream.Seek(0, IO.SeekOrigin.End)

        '------------------------------
        ' �Ώۃe�[�u���擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT '" & pRMenuID & "',"
        strSQL = strSQL & "       TPM150.MENUGRPID,"
        strSQL = strSQL & "       TPM150.POSCNT,"
        strSQL = strSQL & "       TPM150.TERMTYPE,"
        strSQL = strSQL & "       TPM150.POSX1,"
        strSQL = strSQL & "       TPM150.POSY1,"
        strSQL = strSQL & "       TPM150.POSX2,"
        strSQL = strSQL & "       TPM150.POSY2,"
        strSQL = strSQL & "       TPM150.GROUPCD,"
        strSQL = strSQL & "       TPM150.IMAGEFILE,"
        strSQL = strSQL & "       TPM150.UPDID,"
        strSQL = strSQL & "       TPM150.UPDYMD"
        strSQL = strSQL & "  FROM TPM150"
        strSQL = strSQL & " WHERE TPM150.MENUID = '" & pOrgMenuID & "'"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If

            strCSV = ""
            For Each strCol In objRows.ItemArray
                If Len(Trim$(strCSV)) <> 0 Then
                    strCSV = strCSV & vbTab
                End If
                strCSV = strCSV & strCol
            Next
            objSW.WriteLine(strCSV)
            lngCnt = lngCnt + 1
        End While

        objSW.Close()

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_TBL2CSV3 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�@�C���]������
    ' �@�@�\�T�v�F�ȗ�
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_SubImageCopy(ByVal pSourceFld As String, _
                                     ByVal pTargetFld As String, _
                                     Optional ByVal pMaskStr As String = "") As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strFile As String
        Dim strWork() As String
        Dim strTFile As String
        Dim lngCnt As Long
        Dim strMask As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_SubImageCopy = False
        lngCnt = 0

        Try
            '------------------------------
            ' �]����t�H���_���݃`�F�b�N
            '------------------------------
            If System.IO.Directory.Exists(pTargetFld) = False Then
                System.IO.Directory.CreateDirectory(pTargetFld)
            End If

            '------------------------------
            ' �]�����t�H���_���݃`�F�b�N
            '------------------------------
            If System.IO.Directory.Exists(pSourceFld) = False Then
                Exit Function
            End If

            '------------------------------
            ' �t�@�C���]������
            '------------------------------
            If Len(Trim$(pMaskStr)) = 0 Then
                strMask = "*.*"
            Else
                strMask = pMaskStr
            End If

            For Each strFile In System.IO.Directory.GetFiles(pSourceFld, strMask)
                strWork = Split(strFile, "\")
                strTFile = pTargetFld & "\" & strWork(UBound(strWork))
                If System.IO.File.Exists(strTFile) = True Then                  ' �]����ɁA����t�@�C���������݂����ꍇ�͍폜����
                    System.IO.File.SetAttributes(strTFile, IO.FileAttributes.Normal)
                    System.IO.File.Delete(strTFile)
                End If
                System.IO.File.Copy(strFile, strTFile)
                lngCnt = lngCnt + 1
            Next

        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_SubImageCopy = True
    End Function

    Private Function LF_StnLinkEnabled(ByRef pEnabled As Boolean) As Boolean
        ' (��) ���o�������� 'TT%' �ɂ���
        '      �@��敪(TERMKIND)�́A�Q�o�C�g�ڂ� "T" �́A����TEC�А��i���w��

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_StnLinkEnabled = False
        pEnabled = False

        '------------------------------
        ' �֘A�@��}�X�^�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT COUNT(*) AS CNT"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE TPM050.TERMKIND LIKE 'TT%'"
        If Not LF_SVGetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If
        If Not GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        If CLng(objRows("CNT")) = 0 Then
            pEnabled = False
        Else
            pEnabled = True
        End If
        LF_StnLinkEnabled = True

    End Function

    Private Sub LS_TransModeSelect()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSendPath As String
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        'Dim blnStnUse As Boolean               '2006.05.15 �p�~
        Dim objData2 As New DataSet()                                       ' 2004.10.05 ���n��Q���C

        '------------------------------
        ' �L���摜�e�ʃ`�F�b�N
        '------------------------------
        Select Case GF_AllAdvChk()
            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
            Case CNL1920.FuncResult.CancelEnd
                Exit Sub
        End Select

        '------------------------------
        ' �]����p�X�擾
        '------------------------------
        strSendPath = GF_GetAppInfo("SEND_PATH")
        If Len(Trim$(strSendPath)) = 0 Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �]����p�X���݃`�F�b�N
        '------------------------------
        If Not System.IO.Directory.Exists(strSendPath) Then
            Call GF_Msg("", "�]����t�H���_�����o�ł��܂���B�l�b�g���[�N�̐ݒ蓙���������Ă��������B", MsgBoxStyle.OKOnly, MsgBoxStyle.Critical)
            Exit Sub
        End If

        '------------------------------
        ' �T�[�o���c�a�T�[�o�ڑ�����
        '------------------------------
        If Not LF_SVDBConnect() Then
            Call GF_Msg("", _
                        "�T�[�o�֐ڑ��ł��܂���ł����B�ݒ���������ĉ������B", _
                        MsgBoxStyle.OKOnly, _
                        MsgBoxStyle.Exclamation)
            GoTo OTHER_ERROR
        End If

        '------------------------------
        ' �X�e�[�V�����g�p�L���m�F
        '------------------------------
        '--- (2006.03.07) �p�����^�ύX -------------------------------------
        '--- (2006.05.15) �p�~
        'blnStnUse = IIf(GF_GetAppInfo("STSHAISHIN") = "0", True, False)
        'If Not LF_StnLinkEnabled(blnStnUse) Then
        '    GoTo OTHER_ERROR
        'End If
        '-------------------------------------------------------------------

        '------------------------------
        ' �T�[�o���I���^�I�t������
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM040.CLMODE"
        strSQL = strSQL & "  FROM TPM040"
        If Not LF_SVGetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            GoTo SYSTEM_ERROR
        End If
        If Not GF_GetRows(objData, 0, objRows) Then
            GoTo SYSTEM_ERROR
        End If
        If Trim$(objRows("CLMODE")) = GC_FALSE Then                         ' �T�[�o�F�I�t���C�����i�ꊇ�]�����[�h�j
            G_objSVConnect.Close()                                          ' �T�[�o���c�a�ڑ����
            G_objSVConnect.Dispose()

            '------------------------------
            ' �S�̈ꊇ�]������
            '------------------------------
            '--- (2006.05.15) �����ύX----------------------------------
            Call LS_TransMenuData(strSendPath)
            'Call LS_TransMenuData(strSendPath, blnStnUse)
            '-----------------------------------------------------------
        Else                                                                ' �T�[�o�F�I�����C�����i�����]�����[�h�j
            '------------------------------
            ' �T�[�o�����j���[�}�X�^�擾
            '------------------------------

            '2008.1.15 ���A���^�C���]���֎~�J�X�^�}�C�Y
            Call GF_Msg("", "�T�[�o�J�n���͓]���ł��܂���B�T�[�o���I���ɂ��A�ēx���s���Ă��������B", MsgBoxStyle.OKOnly, MsgBoxStyle.Critical)
            Exit Sub

            strSQL = ""
            strSQL = strSQL & "SELECT TPM060.MENUID"
            strSQL = strSQL & "  FROM TPM060"
            strSQL = strSQL & " GROUP BY TPM060.MENUID"
            strSQL = strSQL & " ORDER BY TPM060.MENUID"
            objData = New DataSet()
            If Not LF_SVGetData(strSQL, objData) Then
                GoTo SYSTEM_ERROR
            End If

            ' --- (2004.10.05) ���n��Q���C --------------------------------
            strSQL = ""
            strSQL = strSQL & "SELECT TPM010.GOODSNMJ,"
            strSQL = strSQL & "       TPM010.GOODSNMJ2,"
            strSQL = strSQL & "       TPM010.GOODSNMJ3,"
            strSQL = strSQL & "       TPM010.GOODSNMJ4,"
            strSQL = strSQL & "       TPM010.SCPNO01,"
            strSQL = strSQL & "       TPM010.SCPNO02,"
            strSQL = strSQL & "       TPM010.SCPNO03,"
            strSQL = strSQL & "       TPM010.SCPNO04,"
            strSQL = strSQL & "       TPM010.SCPNO05,"
            strSQL = strSQL & "       TPM010.SCPNO06,"
            strSQL = strSQL & "       TPM010.SCPNO07,"
            strSQL = strSQL & "       TPM010.SCPNO08,"
            strSQL = strSQL & "       TPM010.SCPNO09,"
            strSQL = strSQL & "       TPM010.SCPNO10,"
            strSQL = strSQL & "       TPM010.SCPNO11,"
            strSQL = strSQL & "       TPM010.SCPNO12,"
            strSQL = strSQL & "       TPM010.KCPSTATUS,"
            strSQL = strSQL & "       TPM010.HTLNM1,"
            strSQL = strSQL & "       TPM010.HTLNM2,"
            '�X�V 2006/03/10 8�C���`�Ή�
            strSQL = strSQL & "       TPM010.SPFLG,"
            strSQL = strSQL & "       TPM010.NEWFLG"
            strSQL = strSQL & "  FROM TPM010"
            strSQL = strSQL & " ORDER BY TPM010.GOODSCD"
            objData2 = New DataSet()
            If Not LF_SVGetData(strSQL, objData2) Then
                GoTo SYSTEM_ERROR
            End If
            ' --------------------------------------------------------------

            G_objSVConnect.Close()                                          ' �T�[�o���c�a�ڑ����
            G_objSVConnect.Dispose()

            If objData.Tables("com").Rows.Count = 0 Then
                Call GF_Msg("", _
                            "�T�[�o��ɉғ����Ă��郁�j���[������܂���B" & _
                            vbCrLf & _
                            "���j���[�f�[�^�]�����s���ĉ������B", _
                            MsgBoxStyle.OKOnly, _
                            MsgBoxStyle.Information)
                GoTo OTHER_ERROR
            End If

            '------------------------------
            ' �����]������
            '------------------------------
            '--- (2006.05.15) �����ύX ----------------------------------------------
            Call LS_TransMenuData2(strSendPath, objData, objData2)
            'Call LS_TransMenuData2(strSendPath, objData, blnStnUse, objData2)
            '------------------------------------------------------------------------
        End If

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_TransModeSelect")

OTHER_ERROR:
        G_objSVConnect.Close()                                              ' �T�[�o���c�a�ڑ����
        G_objSVConnect.Dispose()
    End Sub


    Private Sub btn_Menu11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Menu11.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As Form = Nothing

        '------------------------------
        ' �o�n�r�f�[�^�z���ʕ\��
        '------------------------------
        objForm = New CNL1630()
        Me.Enabled = False                                                  ' --- (2003.12.04) �d���N���h�~ ---
        objForm.ShowDialog()
        Me.Enabled = True                                                   ' --- (2003.12.04) �d���N���h�~ ---

    End Sub

    Private Sub btn_Menu7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Menu7.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As New CNL1530()

        '------------------------------
        ' �o�n�r�f�[�^�z���ʕ\��
        '------------------------------
        Me.Enabled = False
        With objForm
            .pProcKind = CNL1530.PROC_KIND.RecommendationEdit
            .ShowDialog()
        End With
        Me.Enabled = True

    End Sub

    Private Sub btn_Menu12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Menu12.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As New CNL1650()

        '------------------------------
        ' ���O�m�F����
        '------------------------------
        If cbo_MenuChg.SelectedIndex = -1 Then
            Call GF_Msg("", "�W�����j���[��I�����ĉ�����", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
            cbo_MenuChg.Select()
            Exit Sub
        End If
        If cbo_AdvChg.SelectedIndex = -1 Then
            Call GF_Msg("", "�W���L����I�����ĉ�����", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
            cbo_AdvChg.Select()
            Exit Sub
        End If

        Select Case LF_ChkMenu()
            Case CNL1920.FuncResult.CancelEnd
                Exit Sub
            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        '------------------------------
        ' �m�F���b�Z�[�W�\��
        '------------------------------
        If GF_Msg("", _
                  "�v���r���[�\�����s���܂��B��낵���ł����H" & vbCrLf & _
                  "�i�T�[�o�ւ̃��j���[�]�������͍s���܂���j", _
                  MsgBoxStyle.YesNo, _
                  MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        '------------------------------
        ' ���j���[�摜�ꊇ��������
        '------------------------------
        If Not GF_CreateMenuImage("I09") Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �f�[�^������/CL�f�[�^�]��
        '------------------------------
        Call LS_DataChange(True)

        '------------------------------
        ' �v���r���[��ʕ\��
        '------------------------------
        With objForm
            .StartPosition = FormStartPosition.CenterScreen
            .FormBorderStyle = FormBorderStyle.FixedDialog
            .ShowInTaskbar = False
            .MaximizeBox = False
            .MinimizeBox = False
            .ControlBox = True
            .MaximumSize = .Size
            .ShowDialog()
        End With

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Menu12_Click")
    End Sub

    Private Function LF_PutTECData() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSTNDLL As String
        Dim strSTNDLLAP As String
        Dim intProc As Integer
        Dim strFile As String
        Dim strWork() As String
        Dim objFile As System.IO.StreamReader
        Dim strLine As String
        Dim strTarget As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_PutTECData = False

        Try
            '------------------------------
            ' �X�e�[�V�����z�M�`�o���݊m�F
            '------------------------------
            strSTNDLL = GF_GetAppInfo("STNDLL_PATH")
            strSTNDLLAP = GF_GetAppInfo("STNDLL_APNM")
            If Not System.IO.File.Exists(strSTNDLL & "\" & strSTNDLLAP) Then
                Exit Function
            End If

            '------------------------------
            ' �f�[�^�z�M�p�X�փR�s�[
            '------------------------------
            If System.IO.Directory.Exists(GC_STNDLL_PATH) = False Then
                System.IO.Directory.CreateDirectory(GC_STNDLL_PATH)
            End If

            For Each strFile In System.IO.Directory.GetFiles(GF_GetAppInfo("OES_PATH"))
                strWork = Split(strFile, "\")
                strTarget = GC_STNDLL_PATH & "\" & strWork(strWork.GetUpperBound(0))

                If System.IO.File.Exists(strTarget) = True Then
                    System.IO.File.SetAttributes(strTarget, IO.FileAttributes.Normal)
                    System.IO.File.Delete(strTarget)
                End If
                System.IO.File.Copy(strFile, strTarget)
            Next

            '------------------------------
            ' �X�e�[�V�����c�k�k����
            '------------------------------
            intProc = Shell(strSTNDLL & "\" & strSTNDLLAP, AppWinStyle.Hide, True, -1)
            If intProc <> 0 Then
                Exit Function
            End If

            '------------------------------
            ' ���O�t�@�C���Q��(���ʔ���)
            '------------------------------
            If intProc = 0 Then
                objFile = New System.IO.StreamReader(strSTNDLL & "\LOG\TP1401.LOG", System.Text.Encoding.Default)
                strLine = objFile.ReadLine
                While Not strLine Is Nothing
                    If strLine.IndexOf("SetDataLoad") <> -1 Then
                        If strLine.IndexOf("OPOS_SUCCESS") = -1 Then
                            objFile.Close()
                            LF_PutTECData = False
                            Exit Function
                        End If
                        Exit While
                    End If
                    strLine = objFile.ReadLine
                End While
                objFile.Close()
            End If
        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_PutTECData = True

    End Function

    Private Sub btn_Menu13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Menu13.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As Form = Nothing

        '------------------------------
        ' �o�n�r�f�[�^�z���ʕ\��
        '------------------------------
        objForm = New CNL1660()
        Me.Enabled = False                                                  ' --- (2003.12.04) �d���N���h�~ ---
        objForm.ShowDialog()
        Me.Enabled = True                                                   ' --- (2003.12.04) �d���N���h�~ ---

    End Sub

    Private Sub btn_Menu14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Menu14.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As Form = Nothing

        '------------------------------
        '���ݕ����ʕ\��
        '------------------------------
        objForm = New CNL1580()
        Me.Enabled = False
        objForm.ShowDialog()
        Me.Enabled = True

    End Sub

    Private Sub btn_Menu15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Menu15.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As Form = Nothing

        '------------------------------
        '���ݕ����ʕ\��
        '------------------------------
        objForm = New CNL1720()
        Me.Enabled = False
        objForm.ShowDialog()
        Me.Enabled = True

    End Sub
End Class
