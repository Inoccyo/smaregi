' --------------------------------------------------------------------------------
' �@�@�@�@�\�F�X�ܓ����V�X�e�� - ��ʑَ̍w����
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------
Public Class CNL1570
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
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_TaxRates As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_StoreInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Comment As System.Windows.Forms.TextBox
    Friend WithEvents pic_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents btn_FldSel As System.Windows.Forms.Button
    Friend WithEvents rdo_Comment As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Logo As System.Windows.Forms.RadioButton
    Friend WithEvents txt_PicName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_JFont As System.Windows.Forms.Label
    Friend WithEvents btn_FontSel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_Call_Hide As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Call_Show As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_Kaikei_Hide As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Kaikei_Show As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_Warikan_Hide As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Warikan_Show As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_Hide As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Show As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbo_Pattern As System.Windows.Forms.ComboBox
    Friend WithEvents chk_Logo As System.Windows.Forms.CheckBox
    Friend WithEvents btn_MsgEdit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CNL1570))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_MsgEdit = New System.Windows.Forms.Button()
        Me.chk_Logo = New System.Windows.Forms.CheckBox()
        Me.cbo_Pattern = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_TaxRates = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_StoreInfo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_Comment = New System.Windows.Forms.TextBox()
        Me.pic_Logo = New System.Windows.Forms.PictureBox()
        Me.btn_FldSel = New System.Windows.Forms.Button()
        Me.rdo_Comment = New System.Windows.Forms.RadioButton()
        Me.rdo_Logo = New System.Windows.Forms.RadioButton()
        Me.txt_PicName = New System.Windows.Forms.TextBox()
        Me.lbl_JFont = New System.Windows.Forms.Label()
        Me.btn_FontSel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdo_Call_Hide = New System.Windows.Forms.RadioButton()
        Me.rdo_Call_Show = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rdo_Kaikei_Hide = New System.Windows.Forms.RadioButton()
        Me.rdo_Kaikei_Show = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdo_Warikan_Hide = New System.Windows.Forms.RadioButton()
        Me.rdo_Warikan_Show = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdo_Hide = New System.Windows.Forms.RadioButton()
        Me.rdo_Show = New System.Windows.Forms.RadioButton()
        Me.stb_Msg = New System.Windows.Forms.StatusBar()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4})
        Me.MenuItem1.Text = "�t�@�C��(&F)"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "�ۑ�"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "�I��"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btn_MsgEdit, Me.chk_Logo, Me.cbo_Pattern, Me.Label7, Me.Label6, Me.txt_TaxRates, Me.Label5, Me.txt_StoreInfo, Me.Label4, Me.Label3, Me.Label2, Me.GroupBox1, Me.lbl_JFont, Me.btn_FontSel, Me.Label1, Me.GroupBox3, Me.GroupBox5, Me.GroupBox4, Me.GroupBox2})
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 488)
        Me.Panel1.TabIndex = 0
        '
        'btn_MsgEdit
        '
        Me.btn_MsgEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_MsgEdit.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_MsgEdit.Location = New System.Drawing.Point(29, 450)
        Me.btn_MsgEdit.Name = "btn_MsgEdit"
        Me.btn_MsgEdit.Size = New System.Drawing.Size(419, 23)
        Me.btn_MsgEdit.TabIndex = 215
        Me.btn_MsgEdit.Text = "�� �q�Ȓ[���֑��M���郁�b�Z�[�W��ҏW���܂�"
        Me.btn_MsgEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chk_Logo
        '
        Me.chk_Logo.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_Logo.Location = New System.Drawing.Point(320, 80)
        Me.chk_Logo.Name = "chk_Logo"
        Me.chk_Logo.Size = New System.Drawing.Size(128, 24)
        Me.chk_Logo.TabIndex = 2
        Me.chk_Logo.Text = "�X���\������"
        '
        'cbo_Pattern
        '
        Me.cbo_Pattern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Pattern.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_Pattern.Location = New System.Drawing.Point(296, 416)
        Me.cbo_Pattern.Name = "cbo_Pattern"
        Me.cbo_Pattern.Size = New System.Drawing.Size(152, 23)
        Me.cbo_Pattern.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 424)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(248, 16)
        Me.Label7.TabIndex = 213
        Me.Label7.Text = "�� ��ʑ̍كp�^�[���̐ݒ���s���܂�"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(816, 432)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 16)
        Me.Label6.TabIndex = 212
        Me.Label6.Text = "��"
        Me.Label6.Visible = False
        '
        'txt_TaxRates
        '
        Me.txt_TaxRates.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_TaxRates.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_TaxRates.Location = New System.Drawing.Point(768, 424)
        Me.txt_TaxRates.Name = "txt_TaxRates"
        Me.txt_TaxRates.Size = New System.Drawing.Size(40, 22)
        Me.txt_TaxRates.TabIndex = 14
        Me.txt_TaxRates.Text = "TextBox1"
        Me.txt_TaxRates.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_TaxRates.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(488, 432)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 16)
        Me.Label5.TabIndex = 210
        Me.Label5.Text = "�� ����ŗ��̐ݒ���s���܂�"
        Me.Label5.Visible = False
        '
        'txt_StoreInfo
        '
        Me.txt_StoreInfo.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_StoreInfo.Location = New System.Drawing.Point(522, 40)
        Me.txt_StoreInfo.Multiline = True
        Me.txt_StoreInfo.Name = "txt_StoreInfo"
        Me.txt_StoreInfo.Size = New System.Drawing.Size(320, 96)
        Me.txt_StoreInfo.TabIndex = 9
        Me.txt_StoreInfo.Text = "TextBox1"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(490, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 23)
        Me.Label4.TabIndex = 208
        Me.Label4.Text = "�� �X�܏��̐ݒ���s���܂�"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(490, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 16)
        Me.Label3.TabIndex = 207
        Me.Label3.Text = "�� �e��{�^���̕\���L����ݒ肵�܂�"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 16)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "�� �X��X�y�[�X�̕\���ݒ���s���܂�"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txt_Comment, Me.pic_Logo, Me.btn_FldSel, Me.rdo_Comment, Me.rdo_Logo, Me.txt_PicName})
        Me.GroupBox1.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(58, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 296)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "�\���ݒ�"
        '
        'txt_Comment
        '
        Me.txt_Comment.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Comment.Location = New System.Drawing.Point(64, 208)
        Me.txt_Comment.Multiline = True
        Me.txt_Comment.Name = "txt_Comment"
        Me.txt_Comment.Size = New System.Drawing.Size(304, 72)
        Me.txt_Comment.TabIndex = 7
        Me.txt_Comment.Text = "TextBox2"
        '
        'pic_Logo
        '
        Me.pic_Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_Logo.Image = CType(resources.GetObject("pic_Logo.Image"), System.Drawing.Bitmap)
        Me.pic_Logo.Location = New System.Drawing.Point(64, 48)
        Me.pic_Logo.Name = "pic_Logo"
        Me.pic_Logo.Size = New System.Drawing.Size(304, 120)
        Me.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pic_Logo.TabIndex = 6
        Me.pic_Logo.TabStop = False
        '
        'btn_FldSel
        '
        Me.btn_FldSel.Font = New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_FldSel.Location = New System.Drawing.Point(256, 16)
        Me.btn_FldSel.Name = "btn_FldSel"
        Me.btn_FldSel.Size = New System.Drawing.Size(112, 24)
        Me.btn_FldSel.TabIndex = 5
        Me.btn_FldSel.Text = "�摜��I������"
        '
        'rdo_Comment
        '
        Me.rdo_Comment.Location = New System.Drawing.Point(24, 184)
        Me.rdo_Comment.Name = "rdo_Comment"
        Me.rdo_Comment.Size = New System.Drawing.Size(184, 24)
        Me.rdo_Comment.TabIndex = 6
        Me.rdo_Comment.Text = "�e�L�X�g��\������"
        '
        'rdo_Logo
        '
        Me.rdo_Logo.Location = New System.Drawing.Point(24, 16)
        Me.rdo_Logo.Name = "rdo_Logo"
        Me.rdo_Logo.Size = New System.Drawing.Size(184, 24)
        Me.rdo_Logo.TabIndex = 4
        Me.rdo_Logo.Text = "���X�̃��S��\������"
        '
        'txt_PicName
        '
        Me.txt_PicName.Location = New System.Drawing.Point(32, 48)
        Me.txt_PicName.Name = "txt_PicName"
        Me.txt_PicName.Size = New System.Drawing.Size(24, 22)
        Me.txt_PicName.TabIndex = 193
        Me.txt_PicName.Text = "TextBox1"
        '
        'lbl_JFont
        '
        Me.lbl_JFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_JFont.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_JFont.Location = New System.Drawing.Point(58, 40)
        Me.lbl_JFont.Name = "lbl_JFont"
        Me.lbl_JFont.Size = New System.Drawing.Size(328, 24)
        Me.lbl_JFont.TabIndex = 204
        Me.lbl_JFont.Text = "Label15"
        '
        'btn_FontSel
        '
        Me.btn_FontSel.Location = New System.Drawing.Point(394, 40)
        Me.btn_FontSel.Name = "btn_FontSel"
        Me.btn_FontSel.Size = New System.Drawing.Size(56, 24)
        Me.btn_FontSel.TabIndex = 0
        Me.btn_FontSel.Text = "�I��"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 16)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "�� �W���t�H���g���w�肵�ĉ�����"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.rdo_Call_Hide, Me.rdo_Call_Show})
        Me.GroupBox3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(522, 232)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(320, 56)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "�w�ďo�x�{�^���̕\���L��"
        '
        'rdo_Call_Hide
        '
        Me.rdo_Call_Hide.Location = New System.Drawing.Point(176, 24)
        Me.rdo_Call_Hide.Name = "rdo_Call_Hide"
        Me.rdo_Call_Hide.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Call_Hide.TabIndex = 3
        Me.rdo_Call_Hide.Text = "�\�����Ȃ�"
        '
        'rdo_Call_Show
        '
        Me.rdo_Call_Show.Location = New System.Drawing.Point(48, 24)
        Me.rdo_Call_Show.Name = "rdo_Call_Show"
        Me.rdo_Call_Show.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Call_Show.TabIndex = 2
        Me.rdo_Call_Show.Text = "�\������"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.AddRange(New System.Windows.Forms.Control() {Me.rdo_Kaikei_Hide, Me.rdo_Kaikei_Show})
        Me.GroupBox5.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(522, 168)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(320, 56)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "�w����v�x�{�^���̕\���L��"
        '
        'rdo_Kaikei_Hide
        '
        Me.rdo_Kaikei_Hide.Location = New System.Drawing.Point(176, 24)
        Me.rdo_Kaikei_Hide.Name = "rdo_Kaikei_Hide"
        Me.rdo_Kaikei_Hide.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Kaikei_Hide.TabIndex = 1
        Me.rdo_Kaikei_Hide.Text = "�\�����Ȃ�"
        '
        'rdo_Kaikei_Show
        '
        Me.rdo_Kaikei_Show.Location = New System.Drawing.Point(48, 24)
        Me.rdo_Kaikei_Show.Name = "rdo_Kaikei_Show"
        Me.rdo_Kaikei_Show.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Kaikei_Show.TabIndex = 0
        Me.rdo_Kaikei_Show.Text = "�\������"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.rdo_Warikan_Hide, Me.rdo_Warikan_Show})
        Me.GroupBox4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(522, 360)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(320, 56)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "�w�����x�{�^���̕\���L��"
        '
        'rdo_Warikan_Hide
        '
        Me.rdo_Warikan_Hide.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Warikan_Hide.Location = New System.Drawing.Point(176, 24)
        Me.rdo_Warikan_Hide.Name = "rdo_Warikan_Hide"
        Me.rdo_Warikan_Hide.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Warikan_Hide.TabIndex = 1
        Me.rdo_Warikan_Hide.Text = "�\�����Ȃ�"
        '
        'rdo_Warikan_Show
        '
        Me.rdo_Warikan_Show.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Warikan_Show.Location = New System.Drawing.Point(48, 24)
        Me.rdo_Warikan_Show.Name = "rdo_Warikan_Show"
        Me.rdo_Warikan_Show.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Warikan_Show.TabIndex = 0
        Me.rdo_Warikan_Show.Text = "�\������"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.rdo_Hide, Me.rdo_Show})
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(522, 296)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 56)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "���v���ڂ̕\���L��"
        '
        'rdo_Hide
        '
        Me.rdo_Hide.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Hide.Location = New System.Drawing.Point(176, 24)
        Me.rdo_Hide.Name = "rdo_Hide"
        Me.rdo_Hide.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Hide.TabIndex = 1
        Me.rdo_Hide.Text = "�\�����Ȃ�"
        '
        'rdo_Show
        '
        Me.rdo_Show.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Show.Location = New System.Drawing.Point(48, 24)
        Me.rdo_Show.Name = "rdo_Show"
        Me.rdo_Show.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Show.TabIndex = 0
        Me.rdo_Show.Text = "�\������"
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 489)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(880, 24)
        Me.stb_Msg.TabIndex = 1
        Me.stb_Msg.Text = "StatusBar1"
        '
        'CNL1570
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(880, 513)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.stb_Msg, Me.Panel1})
        Me.Menu = Me.MainMenu1
        Me.Name = "CNL1570"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNL1570"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' --------------------------------------------------------------------------------
    ' ���W���[�����萔��`
    ' --------------------------------------------------------------------------------
    Private Const LC_FONTSIZE As Long = 16

    ' --------------------------------------------------------------------------------
    ' ���W���[�����ϐ���`
    ' --------------------------------------------------------------------------------
    Private L_objFont As Font
    Private L_blnEdit As Boolean
    Private L_ProcFlg As Boolean

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���ǂݍ��ݎ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub CNL1570_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �t�H�[�����̐ݒ�
        '------------------------------
        Me.Text = GF_FormText(" - ��ʑ̍فE�t�H���g�ݒ�")

        '------------------------------
        ' ����������
        '------------------------------
        Call GS_StatusSetup(stb_Msg)                                        ' �X�e�[�^�X�o�[������
        txt_PicName.Visible = False
        pic_Logo.Image = Nothing

        '------------------------------
        ' ��ʑ̍كp�^�[���R���{ �ݒ�
        '------------------------------
        Call LS_SetPatternCmb()

        '------------------------------
        ' ���s�ݒ�l �\������
        '------------------------------
        Call LS_SetStatus()

        L_blnEdit = False

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1570_Load")
    End Sub

    Private Sub LS_SetPatternCmb()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        cbo_Pattern.Items.Clear()

        strSQL = ""
        strSQL = strSQL & "SELECT TPM070.IMAGESET"
        strSQL = strSQL & "  FROM TPM070"
        strSQL = strSQL & " GROUP BY TPM070.IMAGESET"
        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                GoTo SYSTEM_ERROR
            End If
            ' 2014-05-12 2�o�C�g������������
            'Call GS_CboItemSet(cbo_Pattern, "�̍كp�^�[��" & StrConv(CStr(lngCnt + 1), VbStrConv.Wide), Trim$(objRows("IMAGESET")))
            Call GS_CboItemSet(cbo_Pattern, "�̍كp�^�[��" & CStr(lngCnt + 1), Trim$(objRows("IMAGESET")))
            lngCnt = lngCnt + 1
        End While

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetPatternCmb")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�V�X�e���Ǘ��}�X�^ �擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM040(ByRef pData As DataSet) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM040 = False

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^ �擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM TPM040"
        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If
        If pData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetTPM040 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���s�ݒ�l �\������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetStatus()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim objFile As System.IO.FileStream
        Dim strLogo As String

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^�擾
        '------------------------------
        If Not LF_GetTPM040(objData) Then
            GoTo SYSTEM_ERROR
        End If
        If Not GF_GetRows(objData, 0, objRows) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' ���s�ݒ�l �\������
        '------------------------------
        Try
            '------------------------------
            ' �W���t�H���g�ݒ�
            '------------------------------
            L_objFont = New Font(Trim$(objRows("JFONT")), LC_FONTSIZE)
            Call LS_SetFont(L_objFont)

            '------------------------------
            ' �X�܃��S�X�y�[�X�ݒ�
            '------------------------------
            If Len(Trim$(objRows("LOGO"))) <> 0 Then
                Call LS_SetRadio(rdo_Logo, True)
                Call LS_SetRadio(rdo_Comment, False)

                strLogo = GF_GetAppInfo("STOREMARK_V") & "\" & Trim$(objRows("LOGO"))
                If Not System.IO.File.Exists(strLogo) Then
                    Call GF_Msg("", "�X�܃��S�̃C���[�W�t�@�C�������݂��܂���", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
                Else
                    objFile = New System.IO.FileStream(GF_GetAppInfo("STOREMARK_V") & "\" & Trim$(objRows("LOGO")), IO.FileMode.Open, IO.FileAccess.Read)
                    pic_Logo.Image = System.Drawing.Image.FromStream(objFile)
                    objFile.Close()
                End If
                txt_Comment.Text = ""
                txt_PicName.Text = GF_GetAppInfo("STOREMARK_V") & "\" & Trim$(objRows("LOGO"))
            Else
                Call LS_SetRadio(rdo_Logo, False)
                Call LS_SetRadio(rdo_Comment, True)

                pic_Logo.Image = Nothing
                txt_Comment.Text = Trim$(objRows("COMMENT"))
                txt_PicName.Text = ""
            End If

            L_ProcFlg = True
            If Trim$(objRows("LOGO_VIEW")) = GC_TRUE Then
                chk_Logo.Checked = True
            Else
                chk_Logo.Checked = False
            End If
            L_ProcFlg = False

            '------------------------------
            ' �X�܏��ݒ�
            '------------------------------
            txt_StoreInfo.Text = Replace(Trim$(objRows("STOREINFO")), "<BR>", vbCrLf)

            '------------------------------
            ' �ŗ��ݒ�
            '------------------------------
            txt_TaxRates.Text = Trim$(objRows("TAXRATES"))

            '------------------------------
            ' �ŗ��ݒ�
            '------------------------------
            GS_CboChgSel(cbo_Pattern, Trim$(objRows("IMAGESET")))

            '------------------------------
            ' �e��{�^�����\���ݒ�
            '------------------------------
            If Trim$(objRows("SUBTOTAL")) = GC_TRUE Then
                Call LS_SetRadio(rdo_Show, True)
                Call LS_SetRadio(rdo_Hide, False)
            Else
                Call LS_SetRadio(rdo_Show, False)
                Call LS_SetRadio(rdo_Hide, True)
            End If
            If Trim$(objRows("CALL_FLG")) = GC_TRUE Then
                Call LS_SetRadio(rdo_Call_Show, True)
                Call LS_SetRadio(rdo_Call_Hide, False)
            Else
                Call LS_SetRadio(rdo_Call_Show, False)
                Call LS_SetRadio(rdo_Call_Hide, True)
            End If
            If Trim$(objRows("KAIKEI_FLG")) = GC_TRUE Then
                Call LS_SetRadio(rdo_Kaikei_Show, True)
                Call LS_SetRadio(rdo_Kaikei_Hide, False)
            Else
                Call LS_SetRadio(rdo_Kaikei_Show, False)
                Call LS_SetRadio(rdo_Kaikei_Hide, True)
            End If
            If Trim$(objRows("WARIKAN_FLG")) = GC_TRUE Then
                Call LS_SetRadio(rdo_Warikan_Show, True)
                Call LS_SetRadio(rdo_Warikan_Hide, False)
            Else
                Call LS_SetRadio(rdo_Warikan_Show, False)
                Call LS_SetRadio(rdo_Warikan_Hide, True)
            End If

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetStatus")
    End Sub

    Private Sub LS_SetFont(ByVal pFont As Font)
        With lbl_JFont
            .Text = pFont.Name
            .Font = pFont
        End With
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H���g�I���_�C�A���O�\������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_ShowFontDialog(ByRef pFont As Font) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objFontDialog As New FontDialog()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_ShowFontDialog = False

        '------------------------------
        ' �t�H���g�I���_�C�A���O�\��
        '------------------------------
        With objFontDialog
            .Font = pFont
            .MaxSize = 16
            .MinSize = 16
            .FontMustExist = True
            .AllowVerticalFonts = True
            .ShowColor = False
            .ShowEffects = False
            .FixedPitchOnly = False
            .AllowVectorFonts = True

            If .ShowDialog <> DialogResult.Cancel Then
                pFont = .Font
            Else
                Exit Function
            End If
        End With

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_ShowFontDialog = True

    End Function

    Private Function LF_OpenFileDialog() As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_OpenFileDialog = ""

        With OpenFileDialog1
            .CheckFileExists = True
            .RestoreDirectory = True
            .Filter = "�S�Ẵt�@�C��(*.*)|*.*|JPEG�`��(*.jpg)|*.jpg|gif�`��(*.gif)|*.gif"
            .FilterIndex = 2

            '------------------------------
            ' �I���摜�t�@�C���\��
            '------------------------------
            If .ShowDialog = DialogResult.OK Then
                LF_OpenFileDialog = .FileName
            End If
        End With

    End Function

    Private Sub LS_SetRadio(ByVal pObj As RadioButton, ByVal pChecked As Boolean)
        L_ProcFlg = True
        pObj.Checked = pChecked
        L_ProcFlg = False
    End Sub


    Private Sub CNL1570_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objRet As MsgBoxResult

        '------------------------------
        ' �X�V�����m�F
        '------------------------------
        If L_blnEdit Then
            objRet = GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNoCancel)
            Select Case objRet
                Case MsgBoxResult.Yes
                    If Not GF_BeginTrans() Then                             ' �g�����U�N�V�����J�n
                        GoTo SYSTEM_ERROR
                    End If
                    If Not LF_UpdTPM040() Then                              ' �X�V����
                        GoTo SYSTEM_ERROR
                    End If
                    If Not GF_CommitTrans() Then                            ' �g�����U�N�V�����m��
                        GoTo SYSTEM_ERROR
                    End If
                    If Not LF_DelUnuseFile() Then                           ' ���g�p�摜�t�@�C���K�x�[�W
                        GoTo SYSTEM_ERROR
                    End If

                Case MsgBoxResult.No

                Case MsgBoxResult.Cancel
                    e.Cancel = True
            End Select
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GF_RollbackTrans()
        Call GS_ErrorTerm("CNL1570_Closing")
    End Sub

    Private Function LF_UpdTPM040() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objFile As System.IO.FileInfo = Nothing
        Dim strFile As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM040 = False

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^ �X�V
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM040"
        strSQL = strSQL & "   SET TPM040.JFONT       = '" & L_objFont.Name & "',"
        If rdo_Logo.Checked Then
            ' --- �t�@�C���]������ --------------------------------------------------------------
            Try
                objFile = New System.IO.FileInfo(txt_PicName.Text)
                If objFile.DirectoryName <> GF_GetAppInfo("STOREMARK_V") Then
                    strFile = GF_GetAppInfo("STOREMARK_V") & "\" & objFile.Name
                    ' �]����ɓ���t�@�C�������݂���ꍇ�́A�㏑���̂��߁A��x�폜����
                    If System.IO.File.Exists(strFile) Then
                        System.IO.File.SetAttributes(strFile, IO.FileAttributes.Normal)
                        System.IO.File.Delete(strFile)
                    End If
                    System.IO.File.Copy(txt_PicName.Text, strFile)
                End If
            Catch
                Exit Function
            End Try
            ' -----------------------------------------------------------------------------------
            strSQL = strSQL & "       TPM040.LOGO        = '" & objFile.Name & "',"
            strSQL = strSQL & "       TPM040.COMMENT     = '" & Space(50) & "',"
        Else
            strSQL = strSQL & "       TPM040.LOGO        = '" & Space(50) & "',"
            strSQL = strSQL & "       TPM040.COMMENT     = '" & GF_RepQuo(Trim$(txt_Comment.Text)) & "',"
        End If
        strSQL = strSQL & "       TPM040.SUBTOTAL    = '" & IIf(rdo_Show.Checked, GC_TRUE, GC_FALSE) & "',"
        strSQL = strSQL & "       TPM040.IMAGESET    = '" & Trim$(GF_CboGetCode(cbo_Pattern, cbo_Pattern.SelectedIndex)) & "',"
        strSQL = strSQL & "       TPM040.STOREINFO   = '" & IIf(Len(Trim$(txt_StoreInfo.Text)) = 0, Space(1), GF_RepQuo(Replace(txt_StoreInfo.Text, vbCrLf, "<BR>"))) & "',"
        strSQL = strSQL & "       TPM040.CALL_FLG    = '" & IIf(rdo_Call_Show.Checked, GC_TRUE, GC_FALSE) & "',"
        strSQL = strSQL & "       TPM040.KAIKEI_FLG  = '" & IIf(rdo_Kaikei_Show.Checked, GC_TRUE, GC_FALSE) & "',"
        strSQL = strSQL & "       TPM040.WARIKAN_FLG = '" & IIf(rdo_Warikan_Show.Checked, GC_TRUE, GC_FALSE) & "',"
        strSQL = strSQL & "       TPM040.TAXRATES    = " & IIf(Len(Trim$(txt_TaxRates.Text)) = 0, 0, Trim$(txt_TaxRates.Text)) & ","
        strSQL = strSQL & "       TPM040.LOGO_VIEW   = '" & IIf(chk_Logo.Checked, GC_TRUE, GC_FALSE) & "'"

        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM040 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�X�܃��S�摜�t�H���_�� ���g�p�摜�t�@�C���폜����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_DelUnuseFile() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String = Nothing
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strUFile() As String = Nothing
        Dim strFile As String = Nothing
        Dim strItemPath As String = Nothing
        Dim strWork As String = Nothing
        Dim blnFound As Boolean
        Dim objFileInfo As System.IO.FileInfo = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_DelUnuseFile = False

        '------------------------------
        ' �g�p���摜�t�@�C���ꗗ�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM040.LOGO"
        strSQL = strSQL & "  FROM TPM040"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If
            ReDim Preserve strUFile(lngCnt)
            strUFile(lngCnt) = Trim$(objRows("LOGO"))

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' �摜�t�@�C���g�p������
        '------------------------------
        strItemPath = GF_GetAppInfo("STOREMARK_V")
        For Each strFile In System.IO.Directory.GetFiles(strItemPath)
            blnFound = False
            If Not IsNothing(strUFile) Then
                objFileInfo = New System.IO.FileInfo(strFile)
                For Each strWork In strUFile
                    If objFileInfo.Name = strWork Then
                        blnFound = True
                    End If
                Next
                objFileInfo = Nothing
            End If

            '------------------------------
            ' ���g�p�t�@�C���ł���΍폜
            '------------------------------
            If Not blnFound Then
                Call System.IO.File.SetAttributes(strFile, IO.FileAttributes.Normal)
                Call System.IO.File.Delete(strFile)
                Debug.WriteLine(strFile)
            End If

        Next

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_DelUnuseFile = True

    End Function

    Private Sub LS_RadioCheckChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        L_blnEdit = True
    End Sub

    Private Sub txt_TaxRates_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_TaxRates.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub cbo_Pattern_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_Pattern.SelectionChangeCommitted
        L_blnEdit = True
    End Sub

    Private Sub btn_FontSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FontSel.Click
        If LF_ShowFontDialog(L_objFont) Then
            Call LS_SetFont(L_objFont)
            L_blnEdit = True
        End If
    End Sub

    Private Sub btn_FldSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FldSel.Click
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objFile As System.IO.FileStream
        Dim strFile As String

        '------------------------------
        ' �_�C�A���O�\��
        '------------------------------
        Try
            strFile = LF_OpenFileDialog()
            If Len(Trim$(strFile)) <> 0 Then
                objFile = New System.IO.FileStream(strFile, IO.FileMode.Open, IO.FileAccess.Read)
                pic_Logo.Image = System.Drawing.Image.FromStream(objFile)
                objFile.Close()
                txt_PicName.Text = strFile

                L_blnEdit = True
                Call LS_SetRadio(rdo_Logo, True)
                Call LS_SetRadio(rdo_Comment, False)
            End If

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_FldSel_Click")
    End Sub

    Private Sub rdo_Logo_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Logo.CheckedChanged
        If L_ProcFlg = True Then Exit Sub

        Dim objFile As System.IO.FileStream
        Dim strFile As String

        If pic_Logo.Image Is Nothing Then
            strFile = LF_OpenFileDialog()
            If Len(Trim$(strFile)) <> 0 Then
                objFile = New System.IO.FileStream(strFile, IO.FileMode.Open, IO.FileAccess.Read)
                pic_Logo.Image = System.Drawing.Image.FromStream(objFile)
                objFile.Close()
                txt_PicName.Text = strFile

                L_blnEdit = True
            Else
                Call LS_SetRadio(rdo_Logo, False)
                Call LS_SetRadio(rdo_Comment, True)
            End If
        End If
    End Sub

    Private Sub rdo_Comment_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Comment.CheckedChanged
        If L_ProcFlg = True Then Exit Sub
        L_blnEdit = True
    End Sub

    Private Sub txt_Comment_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Comment.TextChanged

        If txt_Comment.Modified = False Then Exit Sub
        Try
            ' 2014-05-12 2�o�C�g������������
            'txt_Comment.Text = StrConv(txt_Comment.Text, VbStrConv.Wide)
            txt_Comment.SelectionStart = GF_LenB(txt_Comment.Text)

            Call LS_SetRadio(rdo_Logo, False)
            Call LS_SetRadio(rdo_Comment, True)
            L_blnEdit = True
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_Comment_TextChanged")
    End Sub

    Private Sub txt_StoreInfo_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_StoreInfo.TextChanged
        If txt_StoreInfo.Modified = False Then Exit Sub
        L_blnEdit = True
    End Sub

    Private Sub txt_TaxRates_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TaxRates.TextChanged
        If txt_TaxRates.Modified = False Then Exit Sub
        ' --- (2003.12.02) ���͒�����������ǉ� ----------------------------
        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(txt_TaxRates.Text) > 2 Then
            txt_TaxRates.Text = GF_MidB(txt_TaxRates.Text, 1, 2)
            txt_TaxRates.SelectionStart = GF_LenB(txt_TaxRates.Text)
            Exit Sub
        End If
        ' ------------------------------------------------------------------
        L_blnEdit = True
    End Sub

    Private Sub rdo_Kaikei_Show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Kaikei_Show.CheckedChanged
        If L_ProcFlg Then Exit Sub
        L_blnEdit = True
    End Sub

    Private Sub rdo_Kaikei_Hide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Kaikei_Hide.CheckedChanged
        If L_ProcFlg Then Exit Sub
        L_blnEdit = True
    End Sub

    Private Sub rdo_Call_Show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Call_Show.CheckedChanged
        If L_ProcFlg Then Exit Sub
        L_blnEdit = True
    End Sub

    Private Sub rdo_Call_Hide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Call_Hide.CheckedChanged
        If L_ProcFlg Then Exit Sub
        L_blnEdit = True
    End Sub

    Private Sub rdo_Show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Show.CheckedChanged
        If L_ProcFlg Then Exit Sub
        L_blnEdit = True
    End Sub

    Private Sub rdo_Hide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Hide.CheckedChanged
        If L_ProcFlg Then Exit Sub
        L_blnEdit = True
    End Sub

    Private Sub rdo_Warikan_Show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Warikan_Show.CheckedChanged
        If L_ProcFlg Then Exit Sub
        L_blnEdit = True
    End Sub

    Private Sub rdo_Warikan_Hide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Warikan_Hide.CheckedChanged
        If L_ProcFlg Then Exit Sub
        L_blnEdit = True
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click

        If L_blnEdit Then
            If Not GF_BeginTrans() Then                                     ' �g�����U�N�V�����J�n
                GoTo SYSTEM_ERROR
            End If
            If Not LF_UpdTPM040() Then                                      ' �X�V����
                GoTo SYSTEM_ERROR
            End If
            If Not GF_CommitTrans() Then                                    ' �g�����U�N�V�����m��
                GoTo SYSTEM_ERROR
            End If
            If Not LF_DelUnuseFile() Then                                   ' ���g�p�摜�t�@�C���K�x�[�W
                GoTo SYSTEM_ERROR
            End If

            L_blnEdit = False
        End If

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("MenuItem2_Click")
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Me.Close()
    End Sub

    Private Sub chk_Logo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Logo.CheckedChanged
        If L_ProcFlg Then Exit Sub
        L_blnEdit = True
    End Sub

    Private Sub btn_MsgEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MsgEdit.Click

        Dim objForm As Form = Nothing
        objForm = New CNL1571()

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

    End Sub
End Class
