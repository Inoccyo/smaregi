' --------------------------------------------------------------------------------
' �@�@�@�@�\�FCrossNavi - �I�v�V�����o�^���
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2006.06.13 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------
Public Class CNL1720
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
    Friend WithEvents tlb_Btn As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents grd_ItemList As System.Windows.Forms.DataGrid
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_ItemCode As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_TPGoodsNM As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_HTLNM2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_HTLNM1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_OptNo As System.Windows.Forms.Label
    Friend WithEvents txt_Guide As System.Windows.Forms.TextBox
    Friend WithEvents chk_UnUse As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Use As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_SelRow As System.Windows.Forms.TextBox
    Friend WithEvents txt_CNT As System.Windows.Forms.TextBox
    Friend WithEvents txt_HTLNM2_2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_HTLNM1_2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_TPGoodsNM2 As System.Windows.Forms.TextBox
    Friend WithEvents chk_UnUse2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Use2 As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_ItemCode2 As System.Windows.Forms.Label
    Friend WithEvents txt_HTLNM2_3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_HTLNM1_3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_TPGoodsNM3 As System.Windows.Forms.TextBox
    Friend WithEvents chk_UnUse3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Use3 As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_ItemCode3 As System.Windows.Forms.Label
    Friend WithEvents txt_CNT2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_CNT3 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CNL1720))
        Me.tlb_Btn = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.grd_ItemList = New System.Windows.Forms.DataGrid()
        Me.stb_Msg = New System.Windows.Forms.StatusBar()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_Guide = New System.Windows.Forms.TextBox()
        Me.lbl_OptNo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_TPGoodsNM = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_ItemCode = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_HTLNM2 = New System.Windows.Forms.TextBox()
        Me.txt_HTLNM1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chk_UnUse = New System.Windows.Forms.CheckBox()
        Me.chk_Use = New System.Windows.Forms.CheckBox()
        Me.txt_CNT = New System.Windows.Forms.TextBox()
        Me.txt_SelRow = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_HTLNM2_2 = New System.Windows.Forms.TextBox()
        Me.txt_HTLNM1_2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_TPGoodsNM2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chk_UnUse2 = New System.Windows.Forms.CheckBox()
        Me.chk_Use2 = New System.Windows.Forms.CheckBox()
        Me.lbl_ItemCode2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_CNT2 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_HTLNM2_3 = New System.Windows.Forms.TextBox()
        Me.txt_HTLNM1_3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_TPGoodsNM3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chk_UnUse3 = New System.Windows.Forms.CheckBox()
        Me.chk_Use3 = New System.Windows.Forms.CheckBox()
        Me.lbl_ItemCode3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_CNT3 = New System.Windows.Forms.TextBox()
        CType(Me.grd_ItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlb_Btn
        '
        Me.tlb_Btn.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1})
        Me.tlb_Btn.ButtonSize = New System.Drawing.Size(160, 48)
        Me.tlb_Btn.Divider = False
        Me.tlb_Btn.Dock = System.Windows.Forms.DockStyle.None
        Me.tlb_Btn.DropDownArrows = True
        Me.tlb_Btn.ImageList = Me.ImageList2
        Me.tlb_Btn.Location = New System.Drawing.Point(8, 8)
        Me.tlb_Btn.Name = "tlb_Btn"
        Me.tlb_Btn.ShowToolTips = True
        Me.tlb_Btn.Size = New System.Drawing.Size(160, 49)
        Me.tlb_Btn.TabIndex = 1
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 0
        Me.ToolBarButton1.Text = "�V�����I�v�V�������쐬����"
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem4, Me.MenuItem2})
        Me.MenuItem1.Text = "�t�@�C��(&F)"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "�ۑ�(&S)"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "�I��(&E)"
        '
        'grd_ItemList
        '
        Me.grd_ItemList.CaptionFont = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_ItemList.CaptionText = "�� �I�v�V�������"
        Me.grd_ItemList.DataMember = ""
        Me.grd_ItemList.Font = New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_ItemList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_ItemList.Location = New System.Drawing.Point(8, 64)
        Me.grd_ItemList.Name = "grd_ItemList"
        Me.grd_ItemList.Size = New System.Drawing.Size(728, 592)
        Me.grd_ItemList.TabIndex = 4
        Me.grd_ItemList.TabStop = False
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 665)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(1016, 24)
        Me.stb_Msg.TabIndex = 174
        Me.stb_Msg.Text = "StatusBar1"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(80, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 24)
        Me.Label13.TabIndex = 254
        Me.Label13.Text = "�K�C�_���X"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.txt_Guide, Me.Label13, Me.lbl_OptNo, Me.Label3})
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(744, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 80)
        Me.GroupBox2.TabIndex = 251
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "�K�C�_���X"
        '
        'txt_Guide
        '
        Me.txt_Guide.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Guide.Location = New System.Drawing.Point(80, 48)
        Me.txt_Guide.Name = "txt_Guide"
        Me.txt_Guide.Size = New System.Drawing.Size(176, 22)
        Me.txt_Guide.TabIndex = 255
        Me.txt_Guide.Text = "�m�m�m�m�m�m�m�m�m�m"
        '
        'lbl_OptNo
        '
        Me.lbl_OptNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_OptNo.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_OptNo.Location = New System.Drawing.Point(8, 48)
        Me.lbl_OptNo.Name = "lbl_OptNo"
        Me.lbl_OptNo.Size = New System.Drawing.Size(72, 24)
        Me.lbl_OptNo.TabIndex = 227
        Me.lbl_OptNo.Text = "NNN"
        Me.lbl_OptNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 226
        Me.Label3.Text = "��߼�݇�"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txt_TPGoodsNM, Me.Label6, Me.lbl_ItemCode, Me.Label18, Me.txt_HTLNM2, Me.txt_HTLNM1, Me.Label5, Me.Label8, Me.chk_UnUse, Me.chk_Use, Me.txt_CNT, Me.txt_SelRow})
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(744, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 168)
        Me.GroupBox1.TabIndex = 255
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "���t���j���[���P"
        '
        'txt_TPGoodsNM
        '
        Me.txt_TPGoodsNM.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_TPGoodsNM.Location = New System.Drawing.Point(80, 48)
        Me.txt_TPGoodsNM.Name = "txt_TPGoodsNM"
        Me.txt_TPGoodsNM.Size = New System.Drawing.Size(176, 22)
        Me.txt_TPGoodsNM.TabIndex = 218
        Me.txt_TPGoodsNM.Text = "�m�m�m�m�m�m�m�m�m�m"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(80, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 24)
        Me.Label6.TabIndex = 220
        Me.Label6.Text = "�p�l���\�����i��"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_ItemCode
        '
        Me.lbl_ItemCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ItemCode.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_ItemCode.Location = New System.Drawing.Point(8, 48)
        Me.lbl_ItemCode.Name = "lbl_ItemCode"
        Me.lbl_ItemCode.Size = New System.Drawing.Size(72, 24)
        Me.lbl_ItemCode.TabIndex = 212
        Me.lbl_ItemCode.Text = "9999"
        Me.lbl_ItemCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(8, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 24)
        Me.Label18.TabIndex = 209
        Me.Label18.Text = "���i�ԍ�"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_HTLNM2
        '
        Me.txt_HTLNM2.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_HTLNM2.Location = New System.Drawing.Point(168, 136)
        Me.txt_HTLNM2.Name = "txt_HTLNM2"
        Me.txt_HTLNM2.Size = New System.Drawing.Size(88, 22)
        Me.txt_HTLNM2.TabIndex = 222
        Me.txt_HTLNM2.Text = "NNNNNN"
        '
        'txt_HTLNM1
        '
        Me.txt_HTLNM1.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_HTLNM1.Location = New System.Drawing.Point(80, 136)
        Me.txt_HTLNM1.Name = "txt_HTLNM1"
        Me.txt_HTLNM1.Size = New System.Drawing.Size(88, 22)
        Me.txt_HTLNM1.TabIndex = 221
        Me.txt_HTLNM1.Text = "NNNNNN"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(8, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 24)
        Me.Label5.TabIndex = 224
        Me.Label5.Text = "HTL����"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(8, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(248, 24)
        Me.Label8.TabIndex = 217
        Me.Label8.Text = "���t���j���[ �g�p�I�v�V����"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chk_UnUse
        '
        Me.chk_UnUse.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_UnUse.Location = New System.Drawing.Point(138, 104)
        Me.chk_UnUse.Name = "chk_UnUse"
        Me.chk_UnUse.Size = New System.Drawing.Size(112, 24)
        Me.chk_UnUse.TabIndex = 216
        Me.chk_UnUse.Text = "�u�g�p���Ȃ��v"
        '
        'chk_Use
        '
        Me.chk_Use.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_Use.Location = New System.Drawing.Point(10, 104)
        Me.chk_Use.Name = "chk_Use"
        Me.chk_Use.Size = New System.Drawing.Size(128, 24)
        Me.chk_Use.TabIndex = 215
        Me.chk_Use.Text = "�u�g�p����v"
        '
        'txt_CNT
        '
        Me.txt_CNT.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_CNT.Location = New System.Drawing.Point(144, 16)
        Me.txt_CNT.Name = "txt_CNT"
        Me.txt_CNT.Size = New System.Drawing.Size(48, 22)
        Me.txt_CNT.TabIndex = 226
        Me.txt_CNT.Text = "TextBox1"
        '
        'txt_SelRow
        '
        Me.txt_SelRow.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_SelRow.Location = New System.Drawing.Point(64, 16)
        Me.txt_SelRow.Name = "txt_SelRow"
        Me.txt_SelRow.Size = New System.Drawing.Size(48, 22)
        Me.txt_SelRow.TabIndex = 156
        Me.txt_SelRow.Text = "TextBox1"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(176, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(560, 24)
        Me.Label4.TabIndex = 256
        Me.Label4.Text = "�I�v�V�������@001�`035�F�ʏ�I�v�V�����A 036�`040�F�^�C�~���O�I�v�V�����A 041�`050�F���i"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3, Me.GroupBox4})
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 672)
        Me.Panel1.TabIndex = 257
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.txt_HTLNM2_2, Me.txt_HTLNM1_2, Me.Label2, Me.txt_TPGoodsNM2, Me.Label10, Me.Label11, Me.chk_UnUse2, Me.chk_Use2, Me.lbl_ItemCode2, Me.Label15, Me.txt_CNT2})
        Me.GroupBox3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(744, 304)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(264, 168)
        Me.GroupBox3.TabIndex = 256
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "���t���j���[���Q"
        '
        'txt_HTLNM2_2
        '
        Me.txt_HTLNM2_2.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_HTLNM2_2.Location = New System.Drawing.Point(168, 136)
        Me.txt_HTLNM2_2.Name = "txt_HTLNM2_2"
        Me.txt_HTLNM2_2.Size = New System.Drawing.Size(88, 22)
        Me.txt_HTLNM2_2.TabIndex = 222
        Me.txt_HTLNM2_2.Text = "NNNNNN"
        '
        'txt_HTLNM1_2
        '
        Me.txt_HTLNM1_2.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_HTLNM1_2.Location = New System.Drawing.Point(80, 136)
        Me.txt_HTLNM1_2.Name = "txt_HTLNM1_2"
        Me.txt_HTLNM1_2.Size = New System.Drawing.Size(88, 22)
        Me.txt_HTLNM1_2.TabIndex = 221
        Me.txt_HTLNM1_2.Text = "NNNNNN"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(8, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 224
        Me.Label2.Text = "HTL����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_TPGoodsNM2
        '
        Me.txt_TPGoodsNM2.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_TPGoodsNM2.Location = New System.Drawing.Point(80, 48)
        Me.txt_TPGoodsNM2.Name = "txt_TPGoodsNM2"
        Me.txt_TPGoodsNM2.Size = New System.Drawing.Size(176, 22)
        Me.txt_TPGoodsNM2.TabIndex = 218
        Me.txt_TPGoodsNM2.Text = "�m�m�m�m�m�m�m�m�m�m"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(80, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 24)
        Me.Label10.TabIndex = 220
        Me.Label10.Text = "�p�l���\�����i��"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(8, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(248, 24)
        Me.Label11.TabIndex = 217
        Me.Label11.Text = "���t���j���[ �g�p�I�v�V����"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chk_UnUse2
        '
        Me.chk_UnUse2.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_UnUse2.Location = New System.Drawing.Point(138, 104)
        Me.chk_UnUse2.Name = "chk_UnUse2"
        Me.chk_UnUse2.Size = New System.Drawing.Size(112, 24)
        Me.chk_UnUse2.TabIndex = 216
        Me.chk_UnUse2.Text = "�u�g�p���Ȃ��v"
        '
        'chk_Use2
        '
        Me.chk_Use2.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_Use2.Location = New System.Drawing.Point(10, 104)
        Me.chk_Use2.Name = "chk_Use2"
        Me.chk_Use2.Size = New System.Drawing.Size(128, 24)
        Me.chk_Use2.TabIndex = 215
        Me.chk_Use2.Text = "�u�g�p����v"
        '
        'lbl_ItemCode2
        '
        Me.lbl_ItemCode2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ItemCode2.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_ItemCode2.Location = New System.Drawing.Point(8, 48)
        Me.lbl_ItemCode2.Name = "lbl_ItemCode2"
        Me.lbl_ItemCode2.Size = New System.Drawing.Size(72, 24)
        Me.lbl_ItemCode2.TabIndex = 212
        Me.lbl_ItemCode2.Text = "9999"
        Me.lbl_ItemCode2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(8, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 24)
        Me.Label15.TabIndex = 209
        Me.Label15.Text = "���i�ԍ�"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_CNT2
        '
        Me.txt_CNT2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_CNT2.Location = New System.Drawing.Point(144, 16)
        Me.txt_CNT2.Name = "txt_CNT2"
        Me.txt_CNT2.Size = New System.Drawing.Size(48, 22)
        Me.txt_CNT2.TabIndex = 226
        Me.txt_CNT2.Text = "TextBox1"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.txt_HTLNM2_3, Me.txt_HTLNM1_3, Me.Label1, Me.txt_TPGoodsNM3, Me.Label7, Me.Label9, Me.chk_UnUse3, Me.chk_Use3, Me.lbl_ItemCode3, Me.Label16, Me.txt_CNT3})
        Me.GroupBox4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(744, 488)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(264, 168)
        Me.GroupBox4.TabIndex = 256
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "���t���j���[���R"
        '
        'txt_HTLNM2_3
        '
        Me.txt_HTLNM2_3.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_HTLNM2_3.Location = New System.Drawing.Point(168, 136)
        Me.txt_HTLNM2_3.Name = "txt_HTLNM2_3"
        Me.txt_HTLNM2_3.Size = New System.Drawing.Size(88, 22)
        Me.txt_HTLNM2_3.TabIndex = 222
        Me.txt_HTLNM2_3.Text = "NNNNNN"
        '
        'txt_HTLNM1_3
        '
        Me.txt_HTLNM1_3.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_HTLNM1_3.Location = New System.Drawing.Point(80, 136)
        Me.txt_HTLNM1_3.Name = "txt_HTLNM1_3"
        Me.txt_HTLNM1_3.Size = New System.Drawing.Size(88, 22)
        Me.txt_HTLNM1_3.TabIndex = 221
        Me.txt_HTLNM1_3.Text = "NNNNNN"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(8, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 224
        Me.Label1.Text = "HTL����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_TPGoodsNM3
        '
        Me.txt_TPGoodsNM3.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_TPGoodsNM3.Location = New System.Drawing.Point(80, 48)
        Me.txt_TPGoodsNM3.Name = "txt_TPGoodsNM3"
        Me.txt_TPGoodsNM3.Size = New System.Drawing.Size(176, 22)
        Me.txt_TPGoodsNM3.TabIndex = 218
        Me.txt_TPGoodsNM3.Text = "�m�m�m�m�m�m�m�m�m�m"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(80, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 24)
        Me.Label7.TabIndex = 220
        Me.Label7.Text = "�p�l���\�����i��"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(8, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(248, 24)
        Me.Label9.TabIndex = 217
        Me.Label9.Text = "���t���j���[ �g�p�I�v�V����"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chk_UnUse3
        '
        Me.chk_UnUse3.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_UnUse3.Location = New System.Drawing.Point(138, 104)
        Me.chk_UnUse3.Name = "chk_UnUse3"
        Me.chk_UnUse3.Size = New System.Drawing.Size(112, 24)
        Me.chk_UnUse3.TabIndex = 216
        Me.chk_UnUse3.Text = "�u�g�p���Ȃ��v"
        '
        'chk_Use3
        '
        Me.chk_Use3.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_Use3.Location = New System.Drawing.Point(10, 104)
        Me.chk_Use3.Name = "chk_Use3"
        Me.chk_Use3.Size = New System.Drawing.Size(128, 24)
        Me.chk_Use3.TabIndex = 215
        Me.chk_Use3.Text = "�u�g�p����v"
        '
        'lbl_ItemCode3
        '
        Me.lbl_ItemCode3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ItemCode3.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_ItemCode3.Location = New System.Drawing.Point(8, 48)
        Me.lbl_ItemCode3.Name = "lbl_ItemCode3"
        Me.lbl_ItemCode3.Size = New System.Drawing.Size(72, 24)
        Me.lbl_ItemCode3.TabIndex = 212
        Me.lbl_ItemCode3.Text = "9999"
        Me.lbl_ItemCode3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(8, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 24)
        Me.Label16.TabIndex = 209
        Me.Label16.Text = "���i�ԍ�"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_CNT3
        '
        Me.txt_CNT3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_CNT3.Location = New System.Drawing.Point(144, 16)
        Me.txt_CNT3.Name = "txt_CNT3"
        Me.txt_CNT3.Size = New System.Drawing.Size(48, 22)
        Me.txt_CNT3.TabIndex = 226
        Me.txt_CNT3.Text = "TextBox1"
        '
        'CNL1720
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1016, 689)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.GroupBox2, Me.stb_Msg, Me.grd_ItemList, Me.tlb_Btn, Me.GroupBox1, Me.Panel1})
        Me.Menu = Me.MainMenu1
        Me.Name = "CNL1720"
        Me.Text = "CNL1720"
        CType(Me.grd_ItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Structure typItemInfo
        Dim strGROUPCD As String
        Dim strGROUPINFO As String
        Dim strGROUPIMAGE As String
        Dim strPRICEDISP As String
        Dim blnSPFLG As Boolean
    End Structure

    Private L_blnEditFlg As Boolean

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���ǂݍ��ݎ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2006.06.13 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub CNL1720_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As New CNL1810()

        Try
            '------------------------------
            ' �N���X�e�[�^�X�\��
            '------------------------------
            objForm.Show()
            objForm.lbl_Msg.Text = "�N���������ł��B���΂炭���҂���������..."
            objForm.TopMost = True
            System.Windows.Forms.Application.DoEvents()

            '------------------------------
            ' �t�H�[�����̐ݒ�
            '------------------------------
            Me.Text = GF_FormText(" - �I�v�V�����o�^���")
            Me.TopMost = True

            objForm.Close()

            '------------------------------
            ' �t�H�[������������
            '------------------------------
            Call LS_Initialize()

            '------------------------------
            ' �g�����U�N�V�����J�n
            '------------------------------
            If Not GF_BeginTrans() Then
                Exit Sub
            End If

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1720_Load")

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�����\������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_Initialize()
        '------------------------------
        ' �t�H�[������������
        '------------------------------
        lbl_OptNo.Text = ""          '�I�v�V������
        txt_Guide.Text = ""          '�K�C�_���X
        lbl_ItemCode.Text = ""       '���i�ԍ�(1�s��)
        lbl_ItemCode2.Text = ""      '���i�ԍ�(2�s��)
        lbl_ItemCode3.Text = ""      '���i�ԍ�(3�s��)

        L_blnEditFlg = False

        txt_CNT.Visible = False      '�I��ԍ�(1�s��)
        txt_CNT2.Visible = False     '�I��ԍ�(2�s��)
        txt_CNT3.Visible = False     '�I��ԍ�(3�s��)
        txt_SelRow.Visible = False
        txt_SelRow.Clear()

        txt_TPGoodsNM.Clear()        '�^�b�`�p�l���\�����i���P(1�s��)
        txt_TPGoodsNM2.Clear()       '�^�b�`�p�l���\�����i���P(2�s��)
        txt_TPGoodsNM2.Clear()       '�^�b�`�p�l���\�����i���P(3�s��)
        txt_HTLNM1.Clear()           'HTL���̂P(1�s��)
        txt_HTLNM2.Clear()           'HTL���̂Q(1�s��)
        txt_HTLNM1_2.Clear()         'HTL���̂P(2�s��)
        txt_HTLNM2_2.Clear()         'HTL���̂Q(2�s��)
        txt_HTLNM1_3.Clear()         'HTL���̂P(3�s��)
        txt_HTLNM2_3.Clear()         'HTL���̂Q(3�s��)

        '------------------------------
        ' ���i�ꗗ�O���b�h����
        '------------------------------
        Call LS_GridSetup()

        ' �g�s�k�p���̍��ڕ\������
        If GF_GetAppInfo("HTLNMUSE") = GC_TRUE Then
            Label5.Visible = True
            Label2.Visible = True
            Label1.Visible = True
            txt_HTLNM1.Visible = True
            txt_HTLNM2.Visible = True
            txt_HTLNM1_2.Visible = True
            txt_HTLNM2_2.Visible = True
            txt_HTLNM1_3.Visible = True
            txt_HTLNM2_3.Visible = True
        Else
            Label5.Visible = False
            Label2.Visible = False
            Label1.Visible = False
            txt_HTLNM1.Visible = False
            txt_HTLNM2.Visible = False
            txt_HTLNM1_2.Visible = False
            txt_HTLNM2_2.Visible = False
            txt_HTLNM1_3.Visible = False
            txt_HTLNM2_3.Visible = False
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_Initialize")

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�o�^�ς݃I�v�V�������ꗗ�O���b�h �����ݒ菈��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2006.06.13 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_GridSetup()
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objTs As New DataGridTableStyle()  ' �V����DataGridTableStyle�̍쐬
        Dim udtGridCol(40) As typGridColumn
        Dim lngCnt As Long
        Dim dtsData As New DataSet()
        Dim dtsList As DataSet
        Dim objTable As DataTable
        Dim objRow As DataRow = Nothing

        Try
            '------------------------------
            ' �e�[�u���X�^�C����`
            '------------------------------
            With objTs
                .MappingName = "ITEMLIST"      ' �}�b�v�����w��
                .PreferredRowHeight = 65       ' �W���s�����w��
            End With

            '------------------------------
            ' �e���ڑ�����`
            '------------------------------
            With udtGridCol(0)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "SCPNO"
                .strHeadText = "��"
                .blnAllowNull = False
                .lngWidth = 45
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(1)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GUIDE"
                .strHeadText = "�K�C�_���X"
                .blnAllowNull = False
                .lngWidth = 180
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With

            With udtGridCol(2)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "OPTION1"
                .strHeadText = "���t���j���[�P"
                .blnAllowNull = False
                .lngWidth = 160
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With
            With udtGridCol(3)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "OPTION2"
                .strHeadText = "���t���j���[�Q"
                .blnAllowNull = False
                .lngWidth = 160
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With
            With udtGridCol(4)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "OPTION3"
                .strHeadText = "���t���j���[�R"
                .blnAllowNull = False
                .lngWidth = 160
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With

            ' --- �ȉ��A�B������ ---
            With udtGridCol(5)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSCD_1"
                .strHeadText = "���t���j���[�P(���i�R�[�h)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With
            With udtGridCol(6)
                .intType = CNL1920.COLUMN_TYPE.CHECK_STYLE
                .strMapName = "USEFLG_1"
                .strHeadText = "���t���j���[�P(�g�p�t���O)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(7)
                .intType = CNL1920.COLUMN_TYPE.CHECK_STYLE
                .strMapName = "UNUSEFLG_1"
                .strHeadText = "���t���j���[�P(���g�p�t���O)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(8)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "BUMONCD_1"
                .strHeadText = "���t���j���[�P(����R�[�h)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(9)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSNMJ3_1"
                .strHeadText = "���t���j���[�P(�o�n�r���i��)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(10)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSNMJ_1"
                .strHeadText = "���t���j���[�P(�^�b�`�p�l���\�����i��)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(11)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSNMJ2_1"
                .strHeadText = "���t���j���[�P(�^�b�`�p�l���\�����i���Q)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(12)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSNMJ4_1"
                .strHeadText = "���t���j���[�P(�j�b�o�󎚏��i��)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(13)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "HTLNM1_1"
                .strHeadText = "���t���j���[�P(HTL���̂P)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(14)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "HTLNM2_1"
                .strHeadText = "���t���j���[�P(HTL���̂Q)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(15)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "CNT_1"
                .strHeadText = "���t���j���[�P(�J�E���g�F�P)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(16)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "UPDFLG_1"
                .strHeadText = "���t���j���[�P(�X�V�t���O)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(17)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSCD_2"
                .strHeadText = "���t���j���[�Q(���i�R�[�h)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With
            With udtGridCol(18)
                .intType = CNL1920.COLUMN_TYPE.CHECK_STYLE
                .strMapName = "USEFLG_2"
                .strHeadText = "���t���j���[�Q(�g�p�t���O)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(19)
                .intType = CNL1920.COLUMN_TYPE.CHECK_STYLE
                .strMapName = "UNUSEFLG_2"
                .strHeadText = "���t���j���[�Q(���g�p�t���O)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(20)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "BUMONCD_2"
                .strHeadText = "���t���j���[�Q(����R�[�h)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(21)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSNMJ3_2"
                .strHeadText = "���t���j���[�Q(�o�n�r���i��)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(22)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSNMJ_2"
                .strHeadText = "���t���j���[�Q(�^�b�`�p�l���\�����i��)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(23)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSNMJ2_2"
                .strHeadText = "���t���j���[�Q(�^�b�`�p�l���\�����i���Q)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(24)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSNMJ4_2"
                .strHeadText = "���t���j���[�Q(�j�b�o�󎚏��i��)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(25)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "HTLNM1_2"
                .strHeadText = "���t���j���[�Q(HTL���̂P)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(26)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "HTLNM2_2"
                .strHeadText = "���t���j���[�Q(HTL���̂Q)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(27)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "CNT_2"
                .strHeadText = "���t���j���[�Q(�J�E���g�F�Q)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(28)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "UPDFLG_2"
                .strHeadText = "���t���j���[�Q(�X�V�t���O)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(29)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSCD_3"
                .strHeadText = "���t���j���[�R(���i�R�[�h)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With
            With udtGridCol(30)
                .intType = CNL1920.COLUMN_TYPE.CHECK_STYLE
                .strMapName = "USEFLG_3"
                .strHeadText = "���t���j���[�R(�g�p�t���O)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(31)
                .intType = CNL1920.COLUMN_TYPE.CHECK_STYLE
                .strMapName = "UNUSEFLG_3"
                .strHeadText = "���t���j���[�R(���g�p�t���O)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(32)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "BUMONCD_3"
                .strHeadText = "���t���j���[�R(����R�[�h)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(33)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSNMJ3_3"
                .strHeadText = "���t���j���[�R(�o�n�r���i��)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(34)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSNMJ_3"
                .strHeadText = "���t���j���[�R(�^�b�`�p�l���\�����i��)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(35)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSNMJ2_3"
                .strHeadText = "���t���j���[�R(�^�b�`�p�l���\�����i���Q)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(36)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSNMJ4_3"
                .strHeadText = "���t���j���[�R(�j�b�o�󎚏��i��)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(37)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "HTLNM1_3"
                .strHeadText = "���t���j���[�R(HTL���̂P)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(38)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "HTLNM2_3"
                .strHeadText = "���t���j���[�R(HTL���̂Q)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(39)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "CNT_3"
                .strHeadText = "���t���j���[�R(�J�E���g�F�R)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(40)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "UPDFLG_3"
                .strHeadText = "���t���j���[�R(�X�V�t���O)"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            ' ----------------------

            For lngCnt = 0 To UBound(udtGridCol)                ' �e���`���e�[�u���X�^�C���ɒǉ�
                Call GS_GridAddColumn(udtGridCol(lngCnt), objTs)
            Next
            objTs.AllowSorting = False                          ' �񌩏o���N���b�N�ɂ��\�[�g���֎~
            objTs.RowHeadersVisible = False

            With grd_ItemList
                .TableStyles.Clear()
                .TableStyles.Add(objTs)                         ' �e�[�u���X�^�C����DataGrid�ɒǉ�
                .ReadOnly = False                               ' �ҏW�֎~
            End With

            '------------------------------
            ' �O���b�h����
            '------------------------------
            dtsList = New DataSet("ItemList")
            objTable = New DataTable("ITEMLIST")
            For lngCnt = 0 To UBound(udtGridCol)
                Call GS_GridAddTable(udtGridCol(lngCnt), objTable)
            Next

            '------------------------------
            ' �f�[�^�l�ݒ�
            '------------------------------
            Call LS_SetItemGrid(objTable, udtGridCol)

            dtsList.Tables.Add(objTable)                        ' �e�[�u����DataSet�ɒǉ�����

            Dim ds As DataSet = CType(dtsList, DataSet)
            Dim cm As CurrencyManager = CType(BindingContext(dtsList, "ItemList"), CurrencyManager)
            Dim dv As DataView = CType(cm.List, DataView)
            dv.AllowNew = False
            grd_ItemList.DataSource = dv                        ' DataSet�ƃe�[�u����DataGrid�ɐڑ�����

            Dim objCell As DataGridCell
            objCell.ColumnNumber = 2
            objCell.RowNumber = 0
            grd_ItemList.CurrentCell = objCell

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GridSetup")

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�o�^�ςݏ��i�ꗗ�O���b�h �\���l�ݒ菈��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2006.06.13 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetItemGrid(ByVal pTable As DataTable, ByVal pGridCols() As typGridColumn)
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objWRow As DataRow = Nothing
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strOTKCP(2) As String
        Dim strDefCD As String

        '------------------------------
        ' �ݒ�f�[�^�擾
        '------------------------------
        If Not LF_GetTPM100(objData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            objRows = pTable.NewRow

            '------------------------------
            ' ���j���[�e�[�u���I�[�v��
            '------------------------------
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objWRow) Then
                    Exit Sub
                End If

                '�ݒ肷��I�v�V�����f�[�^�̃f�t�H���g���i�R�[�h���擾
                strDefCD = LF_DelZero(Trim$(objWRow("SCPNO")))
                strDefCD = CStr(9000 + (3 * (CLng(strDefCD) - 1)) + CLng(Trim$(objWRow("CNT"))))

                If Trim$(objWRow("GOODSCD")) = strDefCD Then
                    Select Case Trim$(objWRow("CNT"))
                        Case "1"
                            objRows(pGridCols(0).strMapName) = Trim$(objWRow("SCPNO"))
                            objRows(pGridCols(1).strMapName) = Trim$(objWRow("GUIDE"))
                            objRows(pGridCols(2).strMapName) = LF_ItemColEdit(Trim$(objWRow("GOODSCD")), _
                                                                      RTrim$(objWRow("GOODSNMJ")), _
                                                                      RTrim$(objWRow("GOODSNMJ2")))
                            objRows(pGridCols(5).strMapName) = Trim$(objWRow("GOODSCD"))
                            objRows(pGridCols(6).strMapName) = IIf(Trim$(objWRow("SELLFLG")) = "0", True, False)
                            objRows(pGridCols(7).strMapName) = IIf(Trim$(objWRow("SELLFLG")) = "1", True, False)
                            objRows(pGridCols(8).strMapName) = RTrim$(objWRow("BUMONCD"))
                            objRows(pGridCols(9).strMapName) = RTrim$(objWRow("GOODSNMJ3"))
                            objRows(pGridCols(10).strMapName) = RTrim$(objWRow("GOODSNMJ"))
                            objRows(pGridCols(11).strMapName) = RTrim$(objWRow("GOODSNMJ2"))
                            objRows(pGridCols(12).strMapName) = RTrim$(objWRow("GOODSNMJ4"))
                            objRows(pGridCols(13).strMapName) = RTrim$(objWRow("HTLNM1"))
                            objRows(pGridCols(14).strMapName) = RTrim$(objWRow("HTLNM2"))
                            objRows(pGridCols(15).strMapName) = Trim$(objWRow("CNT"))
                            objRows(pGridCols(16).strMapName) = GC_FALSE

                        Case "2"
                            objRows(pGridCols(3).strMapName) = LF_ItemColEdit(Trim$(objWRow("GOODSCD")), _
                                                                      RTrim$(objWRow("GOODSNMJ")), _
                                                                      RTrim$(objWRow("GOODSNMJ2")))
                            objRows(pGridCols(17).strMapName) = Trim$(objWRow("GOODSCD"))
                            objRows(pGridCols(18).strMapName) = IIf(Trim$(objWRow("SELLFLG")) = "0", True, False)
                            objRows(pGridCols(19).strMapName) = IIf(Trim$(objWRow("SELLFLG")) = "1", True, False)
                            objRows(pGridCols(20).strMapName) = RTrim$(objWRow("BUMONCD"))
                            objRows(pGridCols(21).strMapName) = RTrim$(objWRow("GOODSNMJ3"))
                            objRows(pGridCols(22).strMapName) = RTrim$(objWRow("GOODSNMJ"))
                            objRows(pGridCols(23).strMapName) = RTrim$(objWRow("GOODSNMJ2"))
                            objRows(pGridCols(24).strMapName) = RTrim$(objWRow("GOODSNMJ4"))
                            objRows(pGridCols(25).strMapName) = RTrim$(objWRow("HTLNM1"))
                            objRows(pGridCols(26).strMapName) = RTrim$(objWRow("HTLNM2"))
                            objRows(pGridCols(27).strMapName) = Trim$(objWRow("CNT"))
                            objRows(pGridCols(28).strMapName) = GC_FALSE

                        Case Else
                            objRows(pGridCols(4).strMapName) = LF_ItemColEdit(Trim$(objWRow("GOODSCD")), _
                                                                      RTrim$(objWRow("GOODSNMJ")), _
                                                                      RTrim$(objWRow("GOODSNMJ2")))
                            objRows(pGridCols(29).strMapName) = Trim$(objWRow("GOODSCD"))
                            objRows(pGridCols(30).strMapName) = IIf(Trim$(objWRow("SELLFLG")) = "0", True, False)
                            objRows(pGridCols(31).strMapName) = IIf(Trim$(objWRow("SELLFLG")) = "1", True, False)
                            objRows(pGridCols(32).strMapName) = RTrim$(objWRow("BUMONCD"))
                            objRows(pGridCols(33).strMapName) = RTrim$(objWRow("GOODSNMJ3"))
                            objRows(pGridCols(34).strMapName) = RTrim$(objWRow("GOODSNMJ"))
                            objRows(pGridCols(35).strMapName) = RTrim$(objWRow("GOODSNMJ2"))
                            objRows(pGridCols(36).strMapName) = RTrim$(objWRow("GOODSNMJ4"))
                            objRows(pGridCols(37).strMapName) = RTrim$(objWRow("HTLNM1"))
                            objRows(pGridCols(38).strMapName) = RTrim$(objWRow("HTLNM2"))
                            objRows(pGridCols(39).strMapName) = Trim$(objWRow("CNT"))
                            objRows(pGridCols(40).strMapName) = GC_FALSE

                            pTable.Rows.Add(objRows)
                            objRows = pTable.NewRow
                    End Select

                Else
                    Select Case Trim$(objWRow("CNT"))
                        Case "1"
                            objRows(pGridCols(0).strMapName) = Trim$(objWRow("SCPNO"))
                            objRows(pGridCols(1).strMapName) = Trim$(objWRow("GUIDE"))
                            objRows(pGridCols(2).strMapName) = strDefCD
                            objRows(pGridCols(5).strMapName) = strDefCD
                            objRows(pGridCols(6).strMapName) = False
                            objRows(pGridCols(7).strMapName) = True
                            objRows(pGridCols(8).strMapName) = GF_GetBumon()
                            objRows(pGridCols(9).strMapName) = ""
                            objRows(pGridCols(10).strMapName) = ""
                            objRows(pGridCols(11).strMapName) = ""
                            objRows(pGridCols(12).strMapName) = ""
                            objRows(pGridCols(13).strMapName) = ""
                            objRows(pGridCols(14).strMapName) = ""
                            objRows(pGridCols(15).strMapName) = Trim$(objWRow("CNT"))
                            objRows(pGridCols(16).strMapName) = GC_FALSE

                        Case "2"
                            objRows(pGridCols(3).strMapName) = strDefCD
                            objRows(pGridCols(17).strMapName) = strDefCD
                            objRows(pGridCols(18).strMapName) = False
                            objRows(pGridCols(19).strMapName) = True
                            objRows(pGridCols(20).strMapName) = GF_GetBumon()
                            objRows(pGridCols(21).strMapName) = ""
                            objRows(pGridCols(22).strMapName) = ""
                            objRows(pGridCols(23).strMapName) = ""
                            objRows(pGridCols(24).strMapName) = ""
                            objRows(pGridCols(25).strMapName) = ""
                            objRows(pGridCols(26).strMapName) = ""
                            objRows(pGridCols(27).strMapName) = Trim$(objWRow("CNT"))
                            objRows(pGridCols(28).strMapName) = GC_FALSE

                        Case Else
                            objRows(pGridCols(4).strMapName) = strDefCD
                            objRows(pGridCols(29).strMapName) = strDefCD
                            objRows(pGridCols(30).strMapName) = False
                            objRows(pGridCols(31).strMapName) = True
                            objRows(pGridCols(32).strMapName) = GF_GetBumon()
                            objRows(pGridCols(33).strMapName) = ""
                            objRows(pGridCols(34).strMapName) = ""
                            objRows(pGridCols(35).strMapName) = ""
                            objRows(pGridCols(36).strMapName) = ""
                            objRows(pGridCols(37).strMapName) = ""
                            objRows(pGridCols(38).strMapName) = ""
                            objRows(pGridCols(39).strMapName) = Trim$(objWRow("CNT"))
                            objRows(pGridCols(40).strMapName) = GC_FALSE

                            pTable.Rows.Add(objRows)
                            objRows = pTable.NewRow
                    End Select

                End If

                lngCnt = lngCnt + 1
            End While
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetItemGrid")

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���i�}�X�^�擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2006.06.13 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM010(ByVal pGOODSCD As String, ByVal pROW As Integer, ByVal pCOL As Integer) As Boolean
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM010 = False

        '------------------------------
        ' ���i�}�X�^�S���擾
        '------------------------------
        Try
            strSQL = ""
            strSQL = strSQL & "SELECT TPM010.*"
            strSQL = strSQL & "  FROM TPM010"
            strSQL = strSQL & " WHERE TPM010.GOODSCD = '" & pGOODSCD & "'"

        Catch
            Exit Function
        End Try

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count > 0 Then
            If Not GF_GetRows(objData, 0, objRow) Then
                Exit Function
            End If

            '���i�ԍ�
            grd_ItemList(pROW, 5 + (12 * (pCOL - 2))) = Trim$(objRow("GOODSCD"))

            '�g�p�I�v�V����
            grd_ItemList(pROW, 6 + (12 * (pCOL - 2))) = IIf(Trim$(objRow("SELLFLG")) = "0", True, False)
            grd_ItemList(pROW, 7 + (12 * (pCOL - 2))) = IIf(Trim$(objRow("SELLFLG")) = "1", True, False)

            grd_ItemList(pROW, 8 + (12 * (pCOL - 2))) = RTrim$(objRow("BUMONCD"))

            '�o�n�r���i��
            grd_ItemList(pROW, 9 + (12 * (pCOL - 2))) = RTrim$(objRow("GOODSNMJ3"))

            '�^�b�`�p�l���\�����i��(�P�s��)
            grd_ItemList(pROW, 10 + (12 * (pCOL - 2))) = RTrim$(objRow("GOODSNMJ"))

            '�^�b�`�p�l���\�����i��(�Q�s��)
            grd_ItemList(pROW, 11 + (12 * (pCOL - 2))) = RTrim$(objRow("GOODSNMJ2"))

            '�j�b�o�󎚏��i��
            grd_ItemList(pROW, 12 + (12 * (pCOL - 2))) = RTrim$(objRow("GOODSNMJ4"))

            '�g�s�k����(�P�s��)
            grd_ItemList(pROW, 13 + (12 * (pCOL - 2))) = RTrim$(objRow("HTLNM1"))

            '�g�s�k����(�Q�s��)
            grd_ItemList(pROW, 14 + (12 * (pCOL - 2))) = RTrim$(objRow("HTLNM2"))

            '�r�b�o�ʒu
            If pCOL = 2 Then
                grd_ItemList(pROW, 15 + (12 * (pCOL - 2))) = "1"

            ElseIf pCOL = 3 Then
                grd_ItemList(pROW, 15 + (12 * (pCOL - 2))) = "2"

            Else
                grd_ItemList(pROW, 15 + (12 * (pCOL - 2))) = "3"

            End If

            '�X�V�t���O
            grd_ItemList(pROW, 16 + (12 * (pCOL - 2))) = GC_FALSE

        Else
            '------------------------------
            ' �ԋp�l�ݒ�
            '------------------------------
            LF_GetTPM010 = True

        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetTPM010 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�r�b�o�}�X�^�擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2006.06.13 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM100(ByVal pData As DataSet) As Boolean
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM100 = False

        '------------------------------
        ' ���i�}�X�^�S���擾
        '------------------------------
        Try
            strSQL = ""
            strSQL = strSQL & "SELECT TPM100.SCPNO,"
            strSQL = strSQL & "       TPM100.GUIDE,"
            strSQL = strSQL & "       TPM100.GOODSCD1 AS GOODSCD,"
            strSQL = strSQL & "       TPM010.GOODSNMJ,"
            strSQL = strSQL & "       TPM010.GOODSNMJ2,"
            strSQL = strSQL & "       TPM010.GOODSNMJ3,"
            strSQL = strSQL & "       TPM010.GOODSNMJ4,"
            strSQL = strSQL & "       TPM010.SELLFLG,"
            strSQL = strSQL & "       TPM010.BUMONCD,"
            strSQL = strSQL & "       TPM010.HTLNM1,"
            strSQL = strSQL & "       TPM010.HTLNM2,"
            strSQL = strSQL & "       '1' AS CNT"
            strSQL = strSQL & "  FROM TPM100 LEFT JOIN TPM010 ON TPM100.GOODSCD1 = TPM010.GOODSCD"
            strSQL = strSQL & "                              AND TPM100.GOODSCD1 <> '0000'"
            strSQL = strSQL & " UNION "
            strSQL = strSQL & "SELECT TPM100.SCPNO,"
            strSQL = strSQL & "       TPM100.GUIDE,"
            strSQL = strSQL & "       TPM100.GOODSCD2 AS GOODSCD,"
            strSQL = strSQL & "       TPM010.GOODSNMJ,"
            strSQL = strSQL & "       TPM010.GOODSNMJ2,"
            strSQL = strSQL & "       TPM010.GOODSNMJ3,"
            strSQL = strSQL & "       TPM010.GOODSNMJ4,"
            strSQL = strSQL & "       TPM010.SELLFLG,"
            strSQL = strSQL & "       TPM010.BUMONCD,"
            strSQL = strSQL & "       TPM010.HTLNM1,"
            strSQL = strSQL & "       TPM010.HTLNM2,"
            strSQL = strSQL & "       '2' AS CNT"
            strSQL = strSQL & "  FROM TPM100 LEFT JOIN TPM010 ON TPM100.GOODSCD2 = TPM010.GOODSCD"
            strSQL = strSQL & "                              AND TPM100.GOODSCD2 <> '0000'"
            strSQL = strSQL & " UNION "
            strSQL = strSQL & "SELECT TPM100.SCPNO,"
            strSQL = strSQL & "       TPM100.GUIDE,"
            strSQL = strSQL & "       TPM100.GOODSCD3 AS GOODSCD,"
            strSQL = strSQL & "       TPM010.GOODSNMJ,"
            strSQL = strSQL & "       TPM010.GOODSNMJ2,"
            strSQL = strSQL & "       TPM010.GOODSNMJ3,"
            strSQL = strSQL & "       TPM010.GOODSNMJ4,"
            strSQL = strSQL & "       TPM010.SELLFLG,"
            strSQL = strSQL & "       TPM010.BUMONCD,"
            strSQL = strSQL & "       TPM010.HTLNM1,"
            strSQL = strSQL & "       TPM010.HTLNM2,"
            strSQL = strSQL & "       '3' AS CNT"
            strSQL = strSQL & "  FROM TPM100 LEFT JOIN TPM010 ON TPM100.GOODSCD3 = TPM010.GOODSCD"
            strSQL = strSQL & "                              AND TPM100.GOODSCD3 <> '0000'"
            strSQL = strSQL & " ORDER BY SCPNO, CNT"

        Catch
            Exit Function
        End Try

        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetTPM100 = True

    End Function

    Private Function LF_DelZero(ByVal pStr As String) As String
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngCnt As Long
        Dim strScpNo As String

        strScpNo = Trim$(pStr)

        '�ϐ��̐擪������"0"���߂���Ă���ꍇ�͍폜
        For lngCnt = 0 To Len(Trim$(pStr))
            If strScpNo.Substring(0, 1) = "0" Then
                strScpNo = strScpNo.Remove(0, 1)
            Else
                Exit For
            End If
        Next

        LF_DelZero = strScpNo

    End Function

    Private Function LF_ItemColEdit(ByVal pGOODSCD As String, ByVal pTPNM As String, ByVal pTPNM2 As String) As String
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strWork As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_ItemColEdit = ""
        strWork = ""

        '------------------------------
        ' �\���l�ҏW
        '------------------------------
        strWork = strWork & RTrim$(pGOODSCD) & vbCrLf          ' ���i�R�[�h
        strWork = strWork & vbCrLf
        strWork = strWork & Space(1) & RTrim$(pTPNM) & vbCrLf  ' �^�b�`�p�l���\�����i��
        strWork = strWork & Space(1) & RTrim$(pTPNM2)

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_ItemColEdit = strWork

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�o�^�ςݏ��i�ꗗ�O���b�h����i�s�I����Ԑ���j
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2006.06.13 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub grd_ItemList_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_ItemList.CurrentCellChanged
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngCnt As Long

        '------------------------------
        ' �s�I����Ԑ���
        '------------------------------
        Try
            With grd_ItemList
                If GF_GetRowCnt(grd_ItemList) < 0 Then Exit Sub

                For lngCnt = 0 To GF_GetRowCnt(grd_ItemList) - 1
                    .UnSelect(lngCnt)
                Next

                txt_SelRow.Text = .CurrentCell.RowNumber

                Call LS_ShowCurrentItem(.CurrentCell.RowNumber)         ' �I���s�̓��e���A���͗̈�֓]�L����
                .CurrentCell = New DataGridCell(.CurrentCell.RowNumber, 5)
                .Select(.CurrentCell.RowNumber)

            End With
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("grd_ItemList_CurrentCellChanged")

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�o�^�ς݃I�v�V�����ꗗ�O���b�h���e �]�L����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2006.06.13 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_ShowCurrentItem(ByVal pRow As Integer)
        Try
            '�I�v�V�����m�n
            lbl_OptNo.Text = grd_ItemList(pRow, 0)

            '�K�C�_���X
            txt_Guide.Text = grd_ItemList(pRow, 1)

            '�f�[�^�̗L���`�F�b�N
            If Trim$(grd_ItemList(pRow, 10)) = "" And Trim$(grd_ItemList(pRow, 16)) = GC_FALSE Then
                If Not LF_GetTPM010(grd_ItemList(pRow, 5), pRow, 2) Then
                    GoTo SYSTEM_ERROR
                End If
            End If

            '���i�ԍ�
            lbl_ItemCode.Text = grd_ItemList(pRow, 5)

            '���t���j���[ �g�p�I�v�V����
            chk_Use.Checked = grd_ItemList(pRow, 6)
            chk_UnUse.Checked = grd_ItemList(pRow, 7)

            '�^�b�`�p�l���\�����i��(�P�s��)
            txt_TPGoodsNM.Text = grd_ItemList(pRow, 10)

            '�g�s�k����(�P�s��)
            txt_HTLNM1.Text = grd_ItemList(pRow, 13)

            '�g�s�k����(�Q�s��)
            txt_HTLNM2.Text = grd_ItemList(pRow, 14)

            '�r�b�o�ʒu(�l�F1)
            txt_CNT.Text = grd_ItemList(pRow, 15)

            '�f�[�^�̗L���`�F�b�N
            If Trim$(grd_ItemList(pRow, 22)) = "" And Trim$(grd_ItemList(pRow, 28)) = GC_FALSE Then
                If Not LF_GetTPM010(grd_ItemList(pRow, 17), pRow, 3) Then
                    GoTo SYSTEM_ERROR
                End If
            End If

            '���i�ԍ�
            lbl_ItemCode2.Text = grd_ItemList(pRow, 17)

            '���t���j���[ �g�p�I�v�V����
            chk_Use2.Checked = grd_ItemList(pRow, 18)
            chk_UnUse2.Checked = grd_ItemList(pRow, 19)

            '�^�b�`�p�l���\�����i��(�P�s��)
            txt_TPGoodsNM2.Text = grd_ItemList(pRow, 22)

            '�g�s�k����(�P�s��)
            txt_HTLNM1_2.Text = grd_ItemList(pRow, 25)

            '�g�s�k����(�Q�s��)
            txt_HTLNM2_2.Text = grd_ItemList(pRow, 26)

            '�r�b�o�ʒu(�l�F2)
            txt_CNT2.Text = grd_ItemList(pRow, 27)

            '�f�[�^�̗L���`�F�b�N
            If Trim$(grd_ItemList(pRow, 34)) = "" And Trim$(grd_ItemList(pRow, 40)) = GC_FALSE Then
                If Not LF_GetTPM010(grd_ItemList(pRow, 29), pRow, 4) Then
                    GoTo SYSTEM_ERROR
                End If
            End If

            '���i�ԍ�
            lbl_ItemCode3.Text = grd_ItemList(pRow, 29)

            '���t���j���[ �g�p�I�v�V����
            chk_Use3.Checked = grd_ItemList(pRow, 30)
            chk_UnUse3.Checked = grd_ItemList(pRow, 31)

            '�^�b�`�p�l���\�����i��(�P�s��)
            txt_TPGoodsNM3.Text = grd_ItemList(pRow, 34)

            '�g�s�k����(�P�s��)
            txt_HTLNM1_3.Text = grd_ItemList(pRow, 37)

            '�g�s�k����(�Q�s��)
            txt_HTLNM2_3.Text = grd_ItemList(pRow, 38)

            '�r�b�o�ʒu(�l�F3)
            txt_CNT3.Text = grd_ItemList(pRow, 39)

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_ShowCurrentItem")

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�I�v�V�����ǉ��{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2006.06.13 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub tlb_Btn_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlb_Btn.ButtonClick
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As Form = Nothing

        objForm = New CNL1721()

        objForm.ShowDialog()
        Select Case objForm.DialogResult
            Case DialogResult.OK
                ' �t�H�[������������
                Call LS_Initialize()

                L_blnEditFlg = True
            Case DialogResult.Cancel
                ' �������Ȃ�
            Case Else
                GoTo SYSTEM_ERROR
        End Select

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("tlb_Btn_ButtonClick")

    End Sub

    Private Sub txt_Guide_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Guide.TextChanged
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngST As Long

        If txt_Guide.Modified = False Then Exit Sub
        lngST = txt_Guide.SelectionStart
            ' 2014-05-12 2�o�C�g������������
        'txt_Guide.Text = StrConv(txt_Guide.Text, VbStrConv.Wide)
        If lngST >= 0 Then txt_Guide.SelectionStart = lngST

        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(txt_Guide.Text) > 20 Then
            txt_Guide.Text = GF_MidB(txt_Guide.Text, 1, 20)
            txt_Guide.SelectionStart = GF_LenB(txt_Guide.Text)
        End If

        Call LS_WriteRetItemInfo()

        '�X�V�t���O�P
        grd_ItemList(CInt(txt_SelRow.Text), 16) = GC_TRUE
    End Sub

    Private Sub chk_Use_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Use.Click
        '--- �u�g�p����v�u�g�p���Ȃ��v�͈���̂݃`�F�b�N��
        If chk_Use.Checked = True And chk_UnUse.Checked = True Then
            chk_UnUse.Checked = False
        End If

        '--- �u�g�p����v�u�g�p���Ȃ��v�͗����̖��`�F�b�N�s��
        If chk_Use.Checked = False And chk_UnUse.Checked = False Then
            chk_UnUse.Checked = True
        End If

        Call LS_WriteRetItemInfo()

        '�X�V�t���O�P
        grd_ItemList(CInt(txt_SelRow.Text), 16) = GC_TRUE
    End Sub

    Private Sub chk_Use2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Use2.Click
        '--- �u�g�p����v�u�g�p���Ȃ��v�͈���̂݃`�F�b�N��
        If chk_Use2.Checked = True And chk_UnUse2.Checked = True Then
            chk_UnUse2.Checked = False
        End If

        '--- �u�g�p����v�u�g�p���Ȃ��v�͗����̖��`�F�b�N�s��
        If chk_Use2.Checked = False And chk_UnUse2.Checked = False Then
            chk_UnUse2.Checked = True
        End If

        Call LS_WriteRetItemInfo()

        '�X�V�t���O�Q
        grd_ItemList(CInt(txt_SelRow.Text), 28) = GC_TRUE
    End Sub

    Private Sub chk_Use3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Use3.Click
        '--- �u�g�p����v�u�g�p���Ȃ��v�͈���̂݃`�F�b�N��
        If chk_Use3.Checked = True And chk_UnUse3.Checked = True Then
            chk_UnUse3.Checked = False
        End If

        '--- �u�g�p����v�u�g�p���Ȃ��v�͗����̖��`�F�b�N�s��
        If chk_Use3.Checked = False And chk_UnUse3.Checked = False Then
            chk_UnUse3.Checked = True
        End If

        Call LS_WriteRetItemInfo()

        '�X�V�t���O�R
        grd_ItemList(CInt(txt_SelRow.Text), 40) = GC_TRUE
    End Sub

    Private Sub chk_UnUse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_UnUse.Click
        '--- �u�g�p����v�u�g�p���Ȃ��v�͈���̂݃`�F�b�N��
        If chk_Use.Checked = True And chk_UnUse.Checked = True Then
            chk_Use.Checked = False
        End If

        '--- �u�g�p����v�u�g�p���Ȃ��v�͗����̖��`�F�b�N�s��
        If chk_Use.Checked = False And chk_UnUse.Checked = False Then
            chk_Use.Checked = True
        End If

        Call LS_WriteRetItemInfo()

        '�X�V�t���O�P
        grd_ItemList(CInt(txt_SelRow.Text), 16) = GC_TRUE
    End Sub

    Private Sub chk_UnUse2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_UnUse2.Click
        '--- �u�g�p����v�u�g�p���Ȃ��v�͈���̂݃`�F�b�N��
        If chk_Use2.Checked = True And chk_UnUse2.Checked = True Then
            chk_Use2.Checked = False
        End If

        '--- �u�g�p����v�u�g�p���Ȃ��v�͗����̖��`�F�b�N�s��
        If chk_Use2.Checked = False And chk_UnUse2.Checked = False Then
            chk_Use2.Checked = True
        End If

        Call LS_WriteRetItemInfo()

        '�X�V�t���O�Q
        grd_ItemList(CInt(txt_SelRow.Text), 28) = GC_TRUE
    End Sub

    Private Sub chk_UnUse3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_UnUse3.Click
        '--- �u�g�p����v�u�g�p���Ȃ��v�͈���̂݃`�F�b�N��
        If chk_Use3.Checked = True And chk_UnUse3.Checked = True Then
            chk_Use3.Checked = False
        End If

        '--- �u�g�p����v�u�g�p���Ȃ��v�͗����̖��`�F�b�N�s��
        If chk_Use3.Checked = False And chk_UnUse3.Checked = False Then
            chk_Use3.Checked = True
        End If

        Call LS_WriteRetItemInfo()

        '�X�V�t���O�R
        grd_ItemList(CInt(txt_SelRow.Text), 40) = GC_TRUE
    End Sub

    Private Sub txt_TPGoodsNM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TPGoodsNM.TextChanged
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngST As Long

        If txt_TPGoodsNM.Modified = False Then Exit Sub
        lngST = txt_TPGoodsNM.SelectionStart
            ' 2014-05-12 2�o�C�g������������
        'txt_TPGoodsNM.Text = StrConv(txt_TPGoodsNM.Text, VbStrConv.Wide)
        If lngST >= 0 Then txt_TPGoodsNM.SelectionStart = lngST

        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(txt_TPGoodsNM.Text) > 20 Then
            txt_TPGoodsNM.Text = GF_MidB(txt_TPGoodsNM.Text, 1, 20)
            txt_TPGoodsNM.SelectionStart = GF_LenB(txt_TPGoodsNM.Text)
        End If

        Call LS_WriteRetItemInfo()

        '�X�V�t���O�P
        grd_ItemList(CInt(txt_SelRow.Text), 16) = GC_TRUE
    End Sub

    Private Sub txt_TPGoodsNM2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TPGoodsNM2.TextChanged
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngST As Long

        If txt_TPGoodsNM2.Modified = False Then Exit Sub
        lngST = txt_TPGoodsNM2.SelectionStart
            ' 2014-05-12 2�o�C�g������������
        'txt_TPGoodsNM2.Text = StrConv(txt_TPGoodsNM2.Text, VbStrConv.Wide)
        If lngST >= 0 Then txt_TPGoodsNM2.SelectionStart = lngST

        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(txt_TPGoodsNM2.Text) > 20 Then
            txt_TPGoodsNM2.Text = GF_MidB(txt_TPGoodsNM2.Text, 1, 20)
            txt_TPGoodsNM2.SelectionStart = GF_LenB(txt_TPGoodsNM2.Text)
        End If

        Call LS_WriteRetItemInfo()

        '�X�V�t���O�Q
        grd_ItemList(CInt(txt_SelRow.Text), 28) = GC_TRUE
    End Sub

    Private Sub txt_TPGoodsNM3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TPGoodsNM3.TextChanged
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngST As Long

        If txt_TPGoodsNM3.Modified = False Then Exit Sub
        lngST = txt_TPGoodsNM3.SelectionStart
            ' 2014-05-12 2�o�C�g������������
        'txt_TPGoodsNM3.Text = StrConv(txt_TPGoodsNM3.Text, VbStrConv.Wide)
        If lngST >= 0 Then txt_TPGoodsNM3.SelectionStart = lngST

        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(txt_TPGoodsNM3.Text) > 20 Then
            txt_TPGoodsNM3.Text = GF_MidB(txt_TPGoodsNM3.Text, 1, 20)
            txt_TPGoodsNM3.SelectionStart = GF_LenB(txt_TPGoodsNM3.Text)
        End If

        Call LS_WriteRetItemInfo()

        '�X�V�t���O�R
        grd_ItemList(CInt(txt_SelRow.Text), 40) = GC_TRUE
    End Sub

    Private Sub txt_HTLNM1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_HTLNM1.TextChanged
        If txt_HTLNM1.Modified = False Then Exit Sub

        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(txt_HTLNM1.Text) > 5 Then
            txt_HTLNM1.Text = GF_MidB(txt_HTLNM1.Text, 1, 5)
            txt_HTLNM1.SelectionStart = GF_LenB(txt_HTLNM1.Text)
        End If

        Call LS_WriteRetItemInfo()

        '�X�V�t���O�P
        grd_ItemList(CInt(txt_SelRow.Text), 16) = GC_TRUE
    End Sub

    Private Sub txt_HTLNM2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_HTLNM2.TextChanged
        If txt_HTLNM2.Modified = False Then Exit Sub

        If GF_LenB(txt_HTLNM2.Text) > 5 Then
            txt_HTLNM2.Text = GF_MidB(txt_HTLNM2.Text, 1, 5)
            txt_HTLNM2.SelectionStart = GF_LenB(txt_HTLNM2.Text)
        End If

        Call LS_WriteRetItemInfo()

        '�X�V�t���O�P
        grd_ItemList(CInt(txt_SelRow.Text), 16) = GC_TRUE
    End Sub

    Private Sub txt_HTLNM1_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_HTLNM1_2.TextChanged
        If txt_HTLNM1_2.Modified = False Then Exit Sub

        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(txt_HTLNM1_2.Text) > 5 Then
            txt_HTLNM1_2.Text = GF_MidB(txt_HTLNM1_2.Text, 1, 5)
            txt_HTLNM1_2.SelectionStart = GF_LenB(txt_HTLNM1_2.Text)
        End If

        Call LS_WriteRetItemInfo()

        '�X�V�t���O�Q
        grd_ItemList(CInt(txt_SelRow.Text), 28) = GC_TRUE
    End Sub

    Private Sub txt_HTLNM2_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_HTLNM2_2.TextChanged
        If txt_HTLNM2_2.Modified = False Then Exit Sub

        If GF_LenB(txt_HTLNM2_2.Text) > 5 Then
            txt_HTLNM2_2.Text = GF_MidB(txt_HTLNM2_2.Text, 1, 5)
            txt_HTLNM2_2.SelectionStart = GF_LenB(txt_HTLNM2_2.Text)
        End If

        Call LS_WriteRetItemInfo()

        '�X�V�t���O�Q
        grd_ItemList(CInt(txt_SelRow.Text), 28) = GC_TRUE
    End Sub

    Private Sub txt_HTLNM1_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_HTLNM1_3.TextChanged
        If txt_HTLNM1_3.Modified = False Then Exit Sub

        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(txt_HTLNM1_3.Text) > 5 Then
            txt_HTLNM1_3.Text = GF_MidB(txt_HTLNM1_3.Text, 1, 5)
            txt_HTLNM1_3.SelectionStart = GF_LenB(txt_HTLNM1_3.Text)
        End If

        Call LS_WriteRetItemInfo()

        '�X�V�t���O�R
        grd_ItemList(CInt(txt_SelRow.Text), 40) = GC_TRUE
    End Sub

    Private Sub txt_HTLNM2_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_HTLNM2_3.TextChanged
        If txt_HTLNM2_3.Modified = False Then Exit Sub

        If GF_LenB(txt_HTLNM2_3.Text) > 5 Then
            txt_HTLNM2_3.Text = GF_MidB(txt_HTLNM2_3.Text, 1, 5)
            txt_HTLNM2_3.SelectionStart = GF_LenB(txt_HTLNM2_3.Text)
        End If

        Call LS_WriteRetItemInfo()

        '�X�V�t���O�R
        grd_ItemList(CInt(txt_SelRow.Text), 40) = GC_TRUE
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�I�v�V���������͓��e�����߂�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2006.06.13 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_WriteRetItemInfo()
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCell As DataGridCell = grd_ItemList.CurrentCell

        If objCell.RowNumber = -1 Then Exit Sub
        If Len(Trim$(txt_SelRow.Text)) = 0 Or Not IsNumeric(txt_SelRow.Text) Then Exit Sub

        Try
            '�K�C�_���X
            grd_ItemList(CInt(txt_SelRow.Text), 1) = txt_Guide.Text

            '���t���j���[ �g�p�I�v�V����
            grd_ItemList(CInt(txt_SelRow.Text), 6) = chk_Use.Checked
            grd_ItemList(CInt(txt_SelRow.Text), 7) = chk_UnUse.Checked

            '�^�b�`�p�l���\�����i��(�P�s��)
            grd_ItemList(CInt(txt_SelRow.Text), 10) = txt_TPGoodsNM.Text

            '�g�s�k����(�P�s��)
            grd_ItemList(CInt(txt_SelRow.Text), 13) = txt_HTLNM1.Text

            '�g�s�k����(�Q�s��)
            grd_ItemList(CInt(txt_SelRow.Text), 14) = txt_HTLNM2.Text

            '���t���j���[�P
            If chk_Use.Checked Then
                grd_ItemList(CInt(txt_SelRow.Text), 2) = LF_ItemColEdit(grd_ItemList(CInt(txt_SelRow.Text), 5), _
                                                                        grd_ItemList(CInt(txt_SelRow.Text), 10), _
                                                                        grd_ItemList(CInt(txt_SelRow.Text), 11))
            Else
                grd_ItemList(CInt(txt_SelRow.Text), 2) = LF_ItemColEdit(grd_ItemList(CInt(txt_SelRow.Text), 5), _
                                                                        "", _
                                                                        "")
            End If

            '���t���j���[ �g�p�I�v�V����
            grd_ItemList(CInt(txt_SelRow.Text), 18) = chk_Use2.Checked
            grd_ItemList(CInt(txt_SelRow.Text), 19) = chk_UnUse2.Checked

            '�^�b�`�p�l���\�����i��(�P�s��)
            grd_ItemList(CInt(txt_SelRow.Text), 22) = txt_TPGoodsNM2.Text

            '�g�s�k����(�P�s��)
            grd_ItemList(CInt(txt_SelRow.Text), 25) = txt_HTLNM1_2.Text

            '�g�s�k����(�Q�s��)
            grd_ItemList(CInt(txt_SelRow.Text), 26) = txt_HTLNM2_2.Text

            '���t���j���[�Q
            If chk_Use2.Checked Then
                grd_ItemList(CInt(txt_SelRow.Text), 3) = LF_ItemColEdit(grd_ItemList(CInt(txt_SelRow.Text), 17), _
                                                                        grd_ItemList(CInt(txt_SelRow.Text), 22), _
                                                                        grd_ItemList(CInt(txt_SelRow.Text), 23))
            Else
                grd_ItemList(CInt(txt_SelRow.Text), 3) = LF_ItemColEdit(grd_ItemList(CInt(txt_SelRow.Text), 17), _
                                                                        "", _
                                                                        "")
            End If

            '���t���j���[ �g�p�I�v�V����
            grd_ItemList(CInt(txt_SelRow.Text), 30) = chk_Use3.Checked
            grd_ItemList(CInt(txt_SelRow.Text), 31) = chk_UnUse3.Checked

            '�^�b�`�p�l���\�����i��(�P�s��)
            grd_ItemList(CInt(txt_SelRow.Text), 34) = txt_TPGoodsNM3.Text

            '�g�s�k����(�P�s��)
            grd_ItemList(CInt(txt_SelRow.Text), 37) = txt_HTLNM1_3.Text

            '�g�s�k����(�Q�s��)
            grd_ItemList(CInt(txt_SelRow.Text), 38) = txt_HTLNM2_3.Text

            '���t���j���[�R
            If chk_Use3.Checked Then
                grd_ItemList(CInt(txt_SelRow.Text), 4) = LF_ItemColEdit(grd_ItemList(CInt(txt_SelRow.Text), 29), _
                                                                        grd_ItemList(CInt(txt_SelRow.Text), 34), _
                                                                        grd_ItemList(CInt(txt_SelRow.Text), 35))
            Else
                grd_ItemList(CInt(txt_SelRow.Text), 4) = LF_ItemColEdit(grd_ItemList(CInt(txt_SelRow.Text), 29), _
                                                                        "", _
                                                                        "")
            End If

            L_blnEditFlg = True
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_WriteRetItemInfo")

    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Call LS_CommitCheck()
        Call LS_SaveData()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���N���[�Y������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub CNL1720_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Call LS_CommitCheck()
        e.Cancel = Not LF_ChkSave(True)

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ۑ��v�ۊm�F����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_ChkSave(ByVal pChkMode As Boolean) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objRet As MsgBoxResult

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_ChkSave = False

        '------------------------------
        ' �ۑ������v�۔���
        '------------------------------
        If L_blnEditFlg Then                                                ' �ҏW�X�V�L���t���O����
            If pChkMode Then
                objRet = GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNoCancel)
            Else
                objRet = GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNo)
            End If

            Select Case objRet
                Case MsgBoxResult.Yes
                    Call LS_SaveData()

                    '------------------------------
                    ' �g�����U�N�V�����m��
                    '------------------------------
                    If Not GF_CommitTrans() Then
                        Call GF_RollbackTrans()
                        GoTo SYSTEM_ERROR
                    End If

                    '' �r�s�m�f�[�^�o�͏���
                    If Trim$(GF_GetAppInfo("SYS_TYPE")) = "2" Or Trim$(GF_GetAppInfo("SYS_TYPE")) = "3" Then
                        '-- FUMENU���݃`�F�b�N(OES_MENUTBL)
                        If Not System.IO.File.Exists(Trim$(GF_GetAppInfo("OES_PATH")) & "\" & Trim$(GF_GetAppInfo("OES_MENUTBL"))) Then
                            GF_Msg("", "FUMENU �p�X���m�F���Ă�������", MsgBoxStyle.OKOnly)
                            LF_ChkSave = True
                            Exit Function
                        End If
                        '--- FUMENU�X�V
                        If GF_PutFUMENUData() = False Then
                            Exit Function
                        End If

                        '-- FSCP���݃`�F�b�N(OES_SCPTBL)
                        If Not System.IO.File.Exists(Trim$(GF_GetAppInfo("OES_PATH")) & "\" & Trim$(GF_GetAppInfo("OES_SCPTBL"))) Then
                            GF_Msg("", "FSCP �p�X���m�F���Ă�������", MsgBoxStyle.OkOnly)
                            LF_ChkSave = True
                            Exit Function
                        End If
                        '--- FSCP�X�V
                        If GF_PutFSCPData() = False Then
                            Exit Function
                        End If
                    End If

                    L_blnEditFlg = False

                Case MsgBoxResult.No
                    '------------------------------
                    ' �g�����U�N�V�����L�����Z��
                    '------------------------------
                    If Not GF_RollbackTrans() Then
                        GoTo SYSTEM_ERROR
                    End If

                    L_blnEditFlg = False

                Case MsgBoxResult.Cancel

                    LF_ChkSave = False

                    Exit Function
            End Select

        Else

            '------------------------------
            ' �g�����U�N�V�����m��
            '------------------------------
            If Not GF_CommitTrans() Then
                Call GF_RollbackTrans()
                GoTo SYSTEM_ERROR
            End If

        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_ChkSave = True

        Exit Function

SYSTEM_ERROR:
        Call GS_ErrorTerm("LF_ChkSave")
    End Function

    Private Sub LS_CommitCheck()
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCell As DataGridCell
        Dim lngCnt As Long

        lngCnt = grd_ItemList.CurrentCell.RowNumber
        If lngCnt = 0 Or lngCnt <> (GF_GetRowCnt(grd_ItemList) - 1) Then
            objCell.RowNumber = GF_GetRowCnt(grd_ItemList) - 1
        Else
            objCell.RowNumber = 0
        End If
        objCell.ColumnNumber = 41
        grd_ItemList.CurrentCell = objCell

        With objCell
            .ColumnNumber = 41
            .RowNumber = lngCnt
        End With
        grd_ItemList.CurrentCell = objCell

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�f�[�^�ۑ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2006.06.13 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_SaveData()
        Me.Cursor = Cursors.WaitCursor

        If Not LF_UpdTPM010() Then   ' ���i�}�X�^�X�V����
            GoTo SYSTEM_ERROR
        End If

        If Not LF_UpdTPM100() Then   ' �r�b�o�}�X�^�X�V����
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �g�����U�N�V�����m��
        '------------------------------
        If Not GF_CommitTrans() Then
            Call GF_RollbackTrans()
            GoTo SYSTEM_ERROR
        End If

        L_blnEditFlg = False

        Me.Cursor = Cursors.Default

        '------------------------------
        ' �g�����U�N�V�����J�n
        '------------------------------
        If Not GF_BeginTrans() Then
            GoTo SYSTEM_ERROR
        End If

        Exit Sub

SYSTEM_ERROR:
        Me.Cursor = Cursors.Default
        Call GS_ErrorTerm("LS_SaveData")

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���i�����͓��e�����߂�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2006.06.13 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM010() As Boolean
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim lngCnt As Long
        Dim objData As New DataSet()
        Dim lngCnt2 As Long

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM010 = False

        '------------------------------
        ' �X�V����
        '------------------------------
        With grd_ItemList
            For lngCnt = 0 To GF_GetRowCnt(grd_ItemList) - 1

                For lngCnt2 = 5 To 29
                    If grd_ItemList(lngCnt, lngCnt2 + 11) = GC_TRUE Then  ' �ύX�̂��������s�̂ݍX�V�ΏۂƂ���
                        ' �X�V�O�����]�Y�����R�[�h�L���`�F�b�N(TPM010)
                        strSQL = ""
                        strSQL = strSQL & "SELECT TPM010.*"
                        strSQL = strSQL & "  FROM TPM010"
                        strSQL = strSQL & " WHERE TPM010.GOODSCD = '" & grd_ItemList(lngCnt, lngCnt2) & "'"

                        If Not GF_GetData(strSQL, objData) Then
                            Exit Function
                        End If

                        If objData.Tables("com").Rows.Count > 0 Then
                            '���i�}�X�^�X�V(TPM010)
                            strSQL = ""
                            strSQL = strSQL & "UPDATE TPM010"

                            If Len(Trim$(grd_ItemList(lngCnt, lngCnt2 + 5))) = 0 Then
                                strSQL = strSQL & "   SET TPM010.GOODSNMJ  = '" & Space(10) & "',"
                            Else
                                strSQL = strSQL & "   SET TPM010.GOODSNMJ  = '" & RTrim$(grd_ItemList(lngCnt, lngCnt2 + 5)) & "',"
                            End If

                            If Len(Trim$(grd_ItemList(lngCnt, lngCnt2 + 6))) = 0 Then
                                strSQL = strSQL & "   TPM010.GOODSNMJ2 = '" & Space(10) & "',"
                            Else
                                strSQL = strSQL & "   TPM010.GOODSNMJ2 = '" & RTrim$(grd_ItemList(lngCnt, lngCnt2 + 6)) & "',"
                            End If

                            ' �^�b�`�p�l���\�����i���������͂��j�b�o�󎚏��i������\���̏ꍇ�͂j�b�o�󎚏��i���𖄂߂Ȃ�
                            If Len(Trim$(grd_ItemList(lngCnt, lngCnt2 + 5))) = 0 Or GF_GetAppInfo("KCPUSE") = GC_FALSE Then
                                strSQL = strSQL & "   TPM010.GOODSNMJ4 = '" & Space(10) & "',"
                            Else
                                strSQL = strSQL & "   TPM010.GOODSNMJ4 = '" & RTrim$(grd_ItemList(lngCnt, lngCnt2 + 5)) & "',"
                            End If

                            strSQL = strSQL & "       TPM010.SELLFLG   = '" & IIf(grd_ItemList(lngCnt, lngCnt2 + 1) = True, "0", "1") & "',"

                            If Len(Trim$(grd_ItemList(lngCnt, lngCnt2 + 8))) = 0 Then
                                strSQL = strSQL & "   TPM010.HTLNM1    = '" & Space(5) & "',"
                            Else
                                strSQL = strSQL & "   TPM010.HTLNM1    = '" & Trim$(grd_ItemList(lngCnt, lngCnt2 + 8)) & "',"
                            End If

                            If Len(Trim$(grd_ItemList(lngCnt, lngCnt2 + 9))) = 0 Then
                                strSQL = strSQL & "   TPM010.HTLNM2    = '" & Space(5) & "',"
                            Else
                                strSQL = strSQL & "   TPM010.HTLNM2    = '" & Trim$(grd_ItemList(lngCnt, lngCnt2 + 9)) & "',"
                            End If

                            strSQL = strSQL & "       TPM010.BUMONCD     = '" & grd_ItemList(lngCnt, lngCnt2 + 3) & "',"
                            strSQL = strSQL & "       TPM010.GENERATEFLG = '1',"
                            strSQL = strSQL & "       TPM010.UPDID       = '" & GC_UPDID & "',"
                            strSQL = strSQL & "       TPM010.UPDYMD      = '" & Now & "'"
                            strSQL = strSQL & " WHERE TPM010.GOODSCD     = '" & grd_ItemList(lngCnt, lngCnt2) & "'"

                            If Not GF_UpdData(strSQL) Then
                                Call GF_RollbackTrans()
                                Exit Function
                            End If

                        Else
                            '���i�}�X�^�o�^(TPM010)
                            strSQL = ""
                            strSQL = strSQL & "INSERT INTO TPM010 VALUES("
                            strSQL = strSQL & "'" & grd_ItemList(lngCnt, lngCnt2) & "',"                             ' GOODSCD
                            strSQL = strSQL & "'" & grd_ItemList(lngCnt, lngCnt2 + 5) & "',"                         ' GOODSNMJ
                            strSQL = strSQL & "'" & grd_ItemList(lngCnt, lngCnt2 + 6) & "',"                         ' GOODSNMJ2
                            strSQL = strSQL & "'�R�����g�I�v�V����',"                                                ' GOODSNMJ3
                            ' �j�b�o�󎚏��i������\���̏ꍇ�͂j�b�o�󎚏��i���𖄂߂Ȃ�
                            If GF_GetAppInfo("KCPUSE") = GC_TRUE Then                                                ' GOODSNMJ4
                                strSQL = strSQL & "'" & grd_ItemList(lngCnt, lngCnt2 + 5) & "',"
                            Else
                                strSQL = strSQL & "'" & Space(10) & "',"
                            End If
                            strSQL = strSQL & "'" & Space(180) & "',"                                                ' JEXPNOTEJ
                            strSQL = strSQL & "'" & Space(100) & "',"                                                ' IMAGEDATA
                            strSQL = strSQL & "0,"                                                                   ' PRICE
                            strSQL = strSQL & "'" & Space(5) & "',"                                                  ' UNITJ
                            strSQL = strSQL & "'" & IIf(grd_ItemList(lngCnt, lngCnt2 + 1) = True, "0", "1") & "',"   ' SELLFLG
                            strSQL = strSQL & "'000',"                                                               ' SCPNO01
                            strSQL = strSQL & "'000',"                                                               ' SCPNO02
                            strSQL = strSQL & "'000',"                                                               ' SCPNO03
                            strSQL = strSQL & "'000',"                                                               ' SCPNO04
                            strSQL = strSQL & "'000',"                                                               ' SCPNO05
                            strSQL = strSQL & "'000',"                                                               ' SCPNO06
                            strSQL = strSQL & "'000',"                                                               ' SCPNO07
                            strSQL = strSQL & "'000',"                                                               ' SCPNO08
                            strSQL = strSQL & "'000',"                                                               ' SCPNO09
                            strSQL = strSQL & "'000',"                                                               ' SCPNO10
                            strSQL = strSQL & "'000',"                                                               ' SCPNO11
                            strSQL = strSQL & "'000',"                                                               ' SCPNO12
                            strSQL = strSQL & "'1',"                                                                 ' STATUS
                            strSQL = strSQL & "'3',"                                                                 ' GOODSKIND
                            strSQL = strSQL & "'" & grd_ItemList(lngCnt, lngCnt2 + 3) & "',"                         ' BUMONCD
                            strSQL = strSQL & "'00000000000000000000000000000000',"                                  ' KCPSTATUS
                            strSQL = strSQL & "'1',"                                                                 ' GENERATEFLG
                            strSQL = strSQL & "'" & grd_ItemList(lngCnt, lngCnt2 + 8) & "',"                         ' HTLNM1
                            strSQL = strSQL & "'" & grd_ItemList(lngCnt, lngCnt2 + 9) & "',"                         ' HTLNM2
                            strSQL = strSQL & "'0',"                                                                 ' SPFLG
                            strSQL = strSQL & "'0',"                                                                 ' NEWFLG
                            strSQL = strSQL & "'" & GC_UPDID & "',"                                                  ' UPDID
                            strSQL = strSQL & "'" & Now & "')"                                                       ' UPDYMD

                            If Not GF_UpdData(strSQL) Then
                                Exit Function
                            End If
                        End If

                    End If

                    lngCnt2 = lngCnt2 + 11  '12���J�E���g�A�b�v���s������
                Next

            Next

        End With

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM010 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���i�����͓��e�����߂�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2006.06.13 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM100() As Boolean
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim lngCnt As Long

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM100 = False

        '------------------------------
        ' �X�V����
        '------------------------------
        With grd_ItemList
            For lngCnt = 0 To GF_GetRowCnt(grd_ItemList) - 1
                If grd_ItemList(lngCnt, 16) = GC_TRUE Or _
                    grd_ItemList(lngCnt, 28) = GC_TRUE Or _
                    grd_ItemList(lngCnt, 40) = GC_TRUE Then ' �ύX�̂��������s�̂ݍX�V�ΏۂƂ���

                    ' �X�V����(TPM100)
                    strSQL = ""
                    strSQL = strSQL & "UPDATE TPM100"
                    strSQL = strSQL & "   SET TPM100.GUIDE = '" & grd_ItemList(lngCnt, 1) & "',"       ' GUIDE

                    ' ���t���j���[�P�u�g�p����v�Ƀ`�F�b�N������ꍇ�̂ݐݒ�
                    If grd_ItemList(lngCnt, 6) Then
                        strSQL = strSQL & "   TPM100.GOODSCD1 = '" & grd_ItemList(lngCnt, 5) & "',"    ' GOODSCD1
                    Else
                        strSQL = strSQL & "   TPM100.GOODSCD1 = '0000',"                               ' GOODSCD1
                    End If

                    ' ���t���j���[�Q�u�g�p����v�Ƀ`�F�b�N������ꍇ�̂ݐݒ�
                    If grd_ItemList(lngCnt, 18) Then
                        strSQL = strSQL & "   TPM100.GOODSCD2 = '" & grd_ItemList(lngCnt, 17) & "',"   ' GOODSCD2
                    Else
                        strSQL = strSQL & "   TPM100.GOODSCD2 = '0000',"                               ' GOODSCD2
                    End If

                    ' ���t���j���[�R�u�g�p����v�Ƀ`�F�b�N������ꍇ�̂ݐݒ�
                    If grd_ItemList(lngCnt, 30) Then
                        strSQL = strSQL & "   TPM100.GOODSCD3 = '" & grd_ItemList(lngCnt, 29) & "',"   ' GOODSCD3
                    Else
                        strSQL = strSQL & "   TPM100.GOODSCD3 = '0000',"                               ' GOODSCD3
                    End If

                    strSQL = strSQL & "       TPM100.UPDYMD = '" & Now & "'"                           ' UPDYMD
                    strSQL = strSQL & " WHERE TPM100.SCPNO  = '" & grd_ItemList(lngCnt, 0) & "'"       ' SCPNO

                    If Not GF_UpdData(strSQL) Then
                        Call GF_RollbackTrans()
                        Exit Function
                    End If

                End If
            Next

        End With

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM100 = True

    End Function

End Class
