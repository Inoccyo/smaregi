' --------------------------------------------------------------------------------
' �@�@�@�@�\�F�X�ܓ����V�X�e�� - �T�[�o�����e�i���X(���j���[�o�^���)
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------

Public Class CNL1550
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageList3 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents lsv_ItemGrp As System.Windows.Forms.ListView
    Friend WithEvents lsv_MenuGrp As System.Windows.Forms.ListView
    Friend WithEvents txt_MenuTitle As System.Windows.Forms.TextBox
    Friend WithEvents trv_Menu As System.Windows.Forms.TreeView
    Friend WithEvents tlb_Btn As System.Windows.Forms.ToolBar
    Friend WithEvents lst_TreeKey As System.Windows.Forms.ListBox
    Friend WithEvents lst_MenuGrp As System.Windows.Forms.ListBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_MenuPic As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chk_Price As System.Windows.Forms.CheckBox
    Friend WithEvents chk_ShowGenr As System.Windows.Forms.CheckBox
    Friend WithEvents cbo_Style As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_Pat As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "�ɂ���", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "�h�����N", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "��������", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "�W�������`", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "�W�������a", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "�W�������b", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CNL1550))
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "���Z�~", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "��Z�Z�~", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "��Z�Z�~", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "��l�Z�~", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "�񔪁Z�~", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "�O��Z�~", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "�l�Z�Z�~", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "�l���Z�~", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "�ܘZ�Z�~", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lsv_ItemGrp = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lsv_MenuGrp = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_MenuTitle = New System.Windows.Forms.TextBox()
        Me.stb_Msg = New System.Windows.Forms.StatusBar()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.trv_Menu = New System.Windows.Forms.TreeView()
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.tlb_Btn = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton()
        Me.lst_TreeKey = New System.Windows.Forms.ListBox()
        Me.lst_MenuGrp = New System.Windows.Forms.ListBox()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_MenuPic = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chk_Price = New System.Windows.Forms.CheckBox()
        Me.chk_ShowGenr = New System.Windows.Forms.CheckBox()
        Me.cbo_Style = New System.Windows.Forms.ComboBox()
        Me.cbo_Pat = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(520, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 24)
        Me.Label3.TabIndex = 174
        Me.Label3.Text = "�� ���i�W������"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lsv_ItemGrp
        '
        Me.lsv_ItemGrp.AllowDrop = True
        Me.lsv_ItemGrp.Font = New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_ItemGrp.FullRowSelect = True
        ListViewItem1.StateImageIndex = 0
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.StateImageIndex = 0
        ListViewItem4.StateImageIndex = 0
        ListViewItem5.StateImageIndex = 0
        ListViewItem6.StateImageIndex = 0
        Me.lsv_ItemGrp.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6})
        Me.lsv_ItemGrp.LargeImageList = Me.ImageList1
        Me.lsv_ItemGrp.Location = New System.Drawing.Point(520, 272)
        Me.lsv_ItemGrp.MultiSelect = False
        Me.lsv_ItemGrp.Name = "lsv_ItemGrp"
        Me.lsv_ItemGrp.Size = New System.Drawing.Size(488, 384)
        Me.lsv_ItemGrp.TabIndex = 10
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(44, 42)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'lsv_MenuGrp
        '
        Me.lsv_MenuGrp.Alignment = System.Windows.Forms.ListViewAlignment.Default
        Me.lsv_MenuGrp.AllowDrop = True
        Me.lsv_MenuGrp.Font = New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_MenuGrp.FullRowSelect = True
        ListViewItem7.StateImageIndex = 0
        ListViewItem8.StateImageIndex = 0
        ListViewItem9.StateImageIndex = 0
        ListViewItem10.StateImageIndex = 0
        ListViewItem11.StateImageIndex = 0
        ListViewItem12.StateImageIndex = 0
        ListViewItem13.StateImageIndex = 0
        ListViewItem14.StateImageIndex = 0
        ListViewItem15.StateImageIndex = 0
        Me.lsv_MenuGrp.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15})
        Me.lsv_MenuGrp.LargeImageList = Me.ImageList1
        Me.lsv_MenuGrp.Location = New System.Drawing.Point(24, 360)
        Me.lsv_MenuGrp.MultiSelect = False
        Me.lsv_MenuGrp.Name = "lsv_MenuGrp"
        Me.lsv_MenuGrp.Size = New System.Drawing.Size(480, 296)
        Me.lsv_MenuGrp.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(512, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1, 640)
        Me.Label1.TabIndex = 218
        '
        'txt_MenuTitle
        '
        Me.txt_MenuTitle.Font = New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_MenuTitle.Location = New System.Drawing.Point(112, 24)
        Me.txt_MenuTitle.Name = "txt_MenuTitle"
        Me.txt_MenuTitle.Size = New System.Drawing.Size(360, 20)
        Me.txt_MenuTitle.TabIndex = 4
        Me.txt_MenuTitle.Text = ""
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 667)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(1018, 24)
        Me.stb_Msg.TabIndex = 221
        Me.stb_Msg.Text = "StatusBar1"
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 243
        Me.Label2.Text = "���j���[�^�C�g��"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'trv_Menu
        '
        Me.trv_Menu.CheckBoxes = True
        Me.trv_Menu.Font = New System.Drawing.Font("�l�r �S�V�b�N", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.trv_Menu.ImageList = Me.ImageList3
        Me.trv_Menu.Indent = 25
        Me.trv_Menu.Location = New System.Drawing.Point(24, 64)
        Me.trv_Menu.Name = "trv_Menu"
        Me.trv_Menu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("���j���[�P", New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("�����"), New System.Windows.Forms.TreeNode("�ׁE������"), New System.Windows.Forms.TreeNode("�芪��"), New System.Windows.Forms.TreeNode("��i����"), New System.Windows.Forms.TreeNode("�h�����N"), New System.Windows.Forms.TreeNode("���ݒ�"), New System.Windows.Forms.TreeNode("���ݒ�"), New System.Windows.Forms.TreeNode("���ݒ�"), New System.Windows.Forms.TreeNode("�m�[�h0"), New System.Windows.Forms.TreeNode("�m�[�h1")})})
        Me.trv_Menu.Size = New System.Drawing.Size(480, 264)
        Me.trv_Menu.TabIndex = 1
        '
        'ImageList3
        '
        Me.ImageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList3.ImageSize = New System.Drawing.Size(22, 22)
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        '
        'tlb_Btn
        '
        Me.tlb_Btn.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton3})
        Me.tlb_Btn.ButtonSize = New System.Drawing.Size(160, 47)
        Me.tlb_Btn.Divider = False
        Me.tlb_Btn.Dock = System.Windows.Forms.DockStyle.None
        Me.tlb_Btn.DropDownArrows = True
        Me.tlb_Btn.ImageList = Me.ImageList2
        Me.tlb_Btn.Location = New System.Drawing.Point(24, 8)
        Me.tlb_Btn.Name = "tlb_Btn"
        Me.tlb_Btn.ShowToolTips = True
        Me.tlb_Btn.Size = New System.Drawing.Size(480, 48)
        Me.tlb_Btn.TabIndex = 0
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 0
        Me.ToolBarButton1.Text = "�V�������j���[�����"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 1
        Me.ToolBarButton2.Text = "���j���[���R�s�[����"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 2
        Me.ToolBarButton3.Text = "���j���[���폜����"
        '
        'lst_TreeKey
        '
        Me.lst_TreeKey.ItemHeight = 12
        Me.lst_TreeKey.Location = New System.Drawing.Point(0, 120)
        Me.lst_TreeKey.Name = "lst_TreeKey"
        Me.lst_TreeKey.Size = New System.Drawing.Size(24, 208)
        Me.lst_TreeKey.TabIndex = 248
        '
        'lst_MenuGrp
        '
        Me.lst_MenuGrp.ItemHeight = 12
        Me.lst_MenuGrp.Location = New System.Drawing.Point(0, 544)
        Me.lst_MenuGrp.Name = "lst_MenuGrp"
        Me.lst_MenuGrp.Size = New System.Drawing.Size(16, 64)
        Me.lst_MenuGrp.TabIndex = 249
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
        Me.MenuItem2.Text = "�ۑ�(&S)"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "�I��(&E)"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.GroupBox1, Me.lst_MenuGrp, Me.tlb_Btn, Me.Label3, Me.lsv_ItemGrp, Me.Label1, Me.trv_Menu, Me.lst_TreeKey, Me.lsv_MenuGrp})
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 255
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 24)
        Me.Label4.TabIndex = 256
        Me.Label4.Text = "�� ���i�W������"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox2, Me.Label2, Me.txt_MenuTitle})
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(520, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 232)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "���j���[�O���[�v���"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.btn_MenuPic, Me.Label5, Me.Label13, Me.chk_Price, Me.chk_ShowGenr, Me.cbo_Style, Me.cbo_Pat})
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(32, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 136)
        Me.GroupBox2.TabIndex = 250
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "��ʕ\�����@��I�����ĉ�����"
        '
        'btn_MenuPic
        '
        Me.btn_MenuPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_MenuPic.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_MenuPic.Location = New System.Drawing.Point(256, 96)
        Me.btn_MenuPic.Name = "btn_MenuPic"
        Me.btn_MenuPic.Size = New System.Drawing.Size(160, 32)
        Me.btn_MenuPic.TabIndex = 9
        Me.btn_MenuPic.Text = "���j���[�摜�쐬"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(224, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 24)
        Me.Label5.TabIndex = 255
        Me.Label5.Text = "���i�ꗗ���"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(24, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(184, 24)
        Me.Label13.TabIndex = 254
        Me.Label13.Text = "��ʕ\���^�C�v"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chk_Price
        '
        Me.chk_Price.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_Price.Location = New System.Drawing.Point(56, 80)
        Me.chk_Price.Name = "chk_Price"
        Me.chk_Price.Size = New System.Drawing.Size(160, 24)
        Me.chk_Price.TabIndex = 7
        Me.chk_Price.Text = "���z�ʂɕ\������"
        '
        'chk_ShowGenr
        '
        Me.chk_ShowGenr.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_ShowGenr.Location = New System.Drawing.Point(56, 104)
        Me.chk_ShowGenr.Name = "chk_ShowGenr"
        Me.chk_ShowGenr.Size = New System.Drawing.Size(168, 24)
        Me.chk_ShowGenr.TabIndex = 8
        Me.chk_ShowGenr.Text = "�W����������\������"
        '
        'cbo_Style
        '
        Me.cbo_Style.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_Style.Location = New System.Drawing.Point(224, 48)
        Me.cbo_Style.Name = "cbo_Style"
        Me.cbo_Style.Size = New System.Drawing.Size(184, 23)
        Me.cbo_Style.TabIndex = 6
        '
        'cbo_Pat
        '
        Me.cbo_Pat.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_Pat.Location = New System.Drawing.Point(24, 48)
        Me.cbo_Pat.Name = "cbo_Pat"
        Me.cbo_Pat.Size = New System.Drawing.Size(184, 23)
        Me.cbo_Pat.TabIndex = 5
        '
        'CNL1550
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1018, 691)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel1, Me.stb_Msg})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL1550"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JCV01_3"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' --------------------------------------------------------------------------------
    ' ���W���[�����ϐ���`
    ' --------------------------------------------------------------------------------
    Private L_DragMode As String
    Private L_TitleStr As String
    Private L_ProcFlg As Boolean
    Private L_ProcFlg2 As Boolean
    Private L_EditFlg As Boolean
    Private L_MenuGrpID As String       '--(2006.01.27)
    Private L_MenuID As String

    ' --------------------------------------------------------------------------------
    ' ���W���[�����萔��`
    ' --------------------------------------------------------------------------------
    Private Const LC_MOVEMODE As String = "M"
    Private Const LC_COPYMODE As String = "C"
    Private Const LC_NOSEL As String = "---"
    Private Const LC_PAT_GENR As String = "0"
    Private Const LC_PAT_NETA As String = "1"
    Private Const LC_PAT_DIRC As String = "2"
    Private Const LC_STYLE_LIST As String = "A"
    Private Const LC_STYLE_PIC12 As String = "B"
    Private Const LC_STYLE_PIC4 As String = "C"


    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���ǂݍ��ݎ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub TP1040_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �t�H�[�����̐ݒ�
        '------------------------------
        Me.Text = GF_FormText("- ���j���[�o�^���")

        '------------------------------
        ' �t�H�[������������
        '------------------------------
        Call LS_Initialize()

        '------------------------------
        ' �g�����U�N�V�����J�n
        '------------------------------
        If Not GF_BeginTrans() Then
            GoTo SYSTEM_ERROR
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("TP1040_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���N���[�Y�C�x���g
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub TP1040_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Dim strMenuNM As String = Nothing
        Dim strMenuGrpNM As String = Nothing

        '���W���������t�`�F�b�N
        If LF_CheckMenuPic("TPM060", strMenuNM, strMenuGrpNM) = False Then
            GF_Msg("", "�y" & strMenuNM & " - " & strMenuGrpNM & "�z�̃��j���[�摜�Ɋ��t���s���Ă��܂���B" & vbCrLf & "�\�����@��ύX���邩�A���j���[�摜�ɃW�������̊��t�������s���Ă��������B", MsgBoxStyle.OKOnly)
            e.Cancel = True
            Exit Sub
        End If

        If L_EditFlg Then
            Select Case LF_TP1040Save(False)
                Case CNL1920.FuncResult.NormalEnd
                    ' �������Ȃ�
                Case CNL1920.FuncResult.CancelEnd
                    e.Cancel = True
                Case CNL1920.FuncResult.UnusualEnd
                    GoTo SYSTEM_ERROR
                Case Else
                    GoTo SYSTEM_ERROR
            End Select
        Else
            If Not GF_RollbackTrans() Then
                GoTo SYSTEM_ERROR
            End If
        End If
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("TP1040_Closing")
        e.Cancel = True
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F[TP1040]�I������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_TP1040Term()
        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F[TP1040]�ۑ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_TP1040Save(ByVal pMode As Boolean) As FuncResult

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_TP1040Save = CNL1920.FuncResult.UnusualEnd

        If L_EditFlg Then
            Select Case GF_Msg("Q03", "", MsgBoxStyle.YesNoCancel, MsgBoxStyle.Question)
                Case MsgBoxResult.Yes

                    ' --- (2003.11.19) �����ȃ��j���[�̃`�F�b�N������ǉ� ---
                    Select Case LF_ChkMenuEnabled(True)
                        Case CNL1920.FuncResult.CancelEnd
                            LF_TP1040Save = CNL1920.FuncResult.CancelEnd
                            Exit Function
                        Case CNL1920.FuncResult.UnusualEnd
                            GoTo SYSTEM_ERROR
                    End Select
                    If LF_ChkMenuEnabled(False) = CNL1920.FuncResult.UnusualEnd Then
                        GoTo SYSTEM_ERROR
                    End If
                    ' -------------------------------------------------------

                    If Not GF_CommitTrans() Then                                    ' �g�����U�N�V�����m��
                        GoTo SYSTEM_ERROR
                    End If

                    '--- (2006.02.14) ���j���[�؂�ւ��Ή� -------------------------------------
                    ''  FUMENU�X�V
                    'If Trim$(GF_GetAppInfo("STNUSE")) = GC_TRUE Then
                    '    If GF_PutFUMENUData() = False Then
                    '        Exit Function
                    '    End If
                    'End If
                    '---------------------------------------------------------------------------

                    L_EditFlg = False

                    If pMode Then
                        If Not GF_BeginTrans() Then
                            GoTo SYSTEM_ERROR
                        End If
                    End If

                    Call LS_Initialize()
                    LF_TP1040Save = CNL1920.FuncResult.NormalEnd

                Case MsgBoxResult.No
        If Not pMode Then
            If Not GF_RollbackTrans() Then
                GoTo SYSTEM_ERROR
            End If
        End If
        LF_TP1040Save = CNL1920.FuncResult.NormalEnd

                Case MsgBoxResult.Cancel
        LF_TP1040Save = CNL1920.FuncResult.CancelEnd

                Case Else
        GoTo SYSTEM_ERROR

            End Select
        End If

        Exit Function
SYSTEM_ERROR:
        LF_TP1040Save = CNL1920.FuncResult.UnusualEnd
        Call GS_ErrorTerm("LF_TP1040Save")
    End Function

    Private Function LF_ChkMenuEnabled(ByVal pMode As Boolean) As FuncResult
        ' --- (2003.11.19) �L�����̃`�F�b�N������ǉ� ---
        ' �S�m�[�h�����āA����W�������̓o�^����Ă��Ȃ����j���[�{�^���́AENABLED=GC_FALSE��ݒ肷��悤�ɂ���
        ' �܂��A�e�m�[�h���猩�āA�S�Ă̎q�m�[�h��ENABLED=GC_FALSE�ł���΁A�����ȃ��j���[�ł��邱�Ƃ����b�Z�[�W�ɂĎ����A�폜���Ă��܂�
        ' -----------------------------------------------

        ' ���� pMode �ɂ���
        '  > pMode = True / �`�F�b�N�����݂̂ŁA�폜����/�����������͍s��Ȃ��B
        '  > pMode = False / �`�F�b�N����/�폜����/�������������s���B���b�Z�[�W�m�F�͍s��Ȃ��B

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objPNode As TreeNode = Nothing
        Dim objCNode As TreeNode = Nothing
        Dim blnFound As Boolean
        Dim objData As New DataSet()
        Dim strMenuID As String = Nothing
        Dim strMenuGrpID As String
        Dim strSQL As String
        Dim blnAllUnUse As Boolean

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_ChkMenuEnabled = CNL1920.FuncResult.UnusualEnd

        '------------------------------
        ' �L�����`�F�b�N����
        '------------------------------
        For Each objPNode In trv_Menu.Nodes                                 ' �e�m�[�h���[�v
            blnFound = False
            blnAllUnUse = False
            For Each objCNode In objPNode.Nodes                             ' �q�m�[�h���[�v
                strMenuID = LF_GetMenuGrpCD(objPNode)                       ' ���m�[�h�̊e�R�[�h���擾����
                strMenuGrpID = LF_GetMenuGrpCD(objCNode)
                If Len(Trim$(strMenuID)) = 0 Or _
                   Len(Trim$(strMenuGrpID)) = 0 Then
                    Exit Function
                End If

                ' ���Y�m�[�h�ɃW���������R�t�����Ă��邩�A�c�a���璀�ꌟ�����s��
                objData = New DataSet()
                If Not LF_GetTPM060_3(strMenuID, strMenuGrpID, objData) Then
                    Exit Function
                End If

                If objData.Tables("com").Rows.Count = 0 Then
                    If pMode = False Then
                        objCNode.Checked = False
                    End If
                Else
                    blnFound = True

                    If objCNode.Checked = True Then
                        blnAllUnUse = True
                    End If
                End If
            Next

            ' �W�������o�^�ς݂ł����Ă��A�S�Ă̎q�m�[�h�� .Checked ��Ԃ� False �̏ꍇ�́A���l�̈����Ƃ���
            If blnAllUnUse = False Then
                blnFound = False
            End If

            If blnFound = False Then
                '------------------------------
                ' �������j���[���o��
                '------------------------------
                If pMode = True Then
                    If GF_Msg("", "���j���[�y " & objPNode.Text & " �z�̓W���������o�^���́A�L���ȃ{�^�����Ȃ����߁A�ۑ�����܂���" & vbCrLf & "��낵���ł����H", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.No Then
                        LF_ChkMenuEnabled = CNL1920.FuncResult.CancelEnd
                        Exit Function
                    End If
                Else
                    '------------------------------
                    ' �������j���[���폜����
                    '------------------------------
                    strSQL = ""
                    strSQL = strSQL & "DELETE FROM TPM060"
                    strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"
                    If Not GF_UpdData(strSQL) Then
                        Exit Function
                    End If
                End If
            End If
        Next

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_ChkMenuEnabled = CNL1920.FuncResult.NormalEnd

    End Function


    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�����\������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_Initialize()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim dtsData As New DataSet()

        '------------------------------
        ' �t�H�[������������
        '------------------------------
        lst_TreeKey.Visible = False                                         ' �B�����ڂ̔�\���ݒ�
        lst_MenuGrp.Visible = False
        lsv_MenuGrp.AllowDrop = True
        lsv_ItemGrp.AllowDrop = True
        Call GS_StatusSetup(stb_Msg)                                        ' �X�e�[�^�X�o�[������
        trv_Menu.Nodes.Clear()                                              ' ���j���[�c���[�r���[������
        lsv_MenuGrp.Items.Clear()                                           ' ���j���[�O���[�v�E���i�O���[�v�ꗗ������
        txt_MenuTitle.Text = ""
        lsv_ItemGrp.Items.Clear()
        lst_MenuGrp.Items.Clear()
        L_ProcFlg = False                                                   ' �������t���O(�C�x���g��������t���O)
        L_ProcFlg2 = False

        ' �t�H�[�J�X�r������A�I����������\������
        lsv_ItemGrp.HideSelection = False
        lsv_MenuGrp.HideSelection = False
        trv_Menu.HideSelection = False

        cbo_Pat.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_Pat.Items.Clear()
        Call GS_CboItemSet(cbo_Pat, "���i�W��������\��", LC_PAT_GENR)
        Call GS_CboItemSet(cbo_Pat, "�l�^�P�[�X��\��", LC_PAT_NETA)
        Call GS_CboItemSet(cbo_Pat, "���i�ꗗ�𒼐ڕ\��", LC_PAT_DIRC)
        Call GS_CboChgSel(cbo_Pat, LC_PAT_GENR)

        cbo_Style.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_Style.Items.Clear()
        Call GS_CboItemSet(cbo_Style, "�Z���ŕ\��", LC_STYLE_LIST)
        Call GS_CboItemSet(cbo_Style, "�ʐ^�ŕ\��(12/�X����)", LC_STYLE_PIC12)
        Call GS_CboItemSet(cbo_Style, "�ʐ^�ŕ\��(�S����)", LC_STYLE_PIC4)
        Call GS_CboChgSel(cbo_Style, LC_STYLE_LIST)

        Call LS_SetMenuTree()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_Initialize")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�ꗗ�擾����(���g�p)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM060_1(ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM060_1 = False

        '------------------------------
        ' ���j���[�O���[�v�}�X�^�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM060.MENUID, TPM060.MENUNM"
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " GROUP BY TPM060.MENUID, TPM060.MENUNM"
        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM060_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���i�O���[�v�ꗗ�擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    ' Private Function LF_GetTPM020_1(ByVal pMenuID As String, ByRef pDataSet As DataSet) As Boolean
    Private Function LF_GetTPM020_1(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM020_1 = False

        '------------------------------
        ' ���j���[�O���[�v�}�X�^�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM020.GROUPCD,"
        strSQL = strSQL & "       TPM020.GROUPNM,"
        strSQL = strSQL & "       TPM020.PRICEDISP"
        strSQL = strSQL & "  FROM TPM020"
        strSQL = strSQL & " WHERE TPM020.GROUPCD NOT IN (SELECT GROUPCD"
        strSQL = strSQL & "                                FROM TPM060"
        strSQL = strSQL & "                               WHERE MENUID    = '" & pMenuID & "'"
        ' --- (2003.11.20) MENUGRPID �������ɒǉ����� ---
        strSQL = strSQL & "                                 AND MENUGRPID = '" & pMenuGrpID & "'"
        ' -----------------------------------------------
        strSQL = strSQL & "                                 AND GROUPCD  <> '" & GC_DUMMY_GROUPCD & "'"
        strSQL = strSQL & "                                GROUP BY GROUPCD)"
        strSQL = strSQL & "   AND TPM020.GOODSCD = '0000'"
        strSQL = strSQL & " GROUP BY TPM020.GROUPCD,"
        strSQL = strSQL & "          TPM020.GROUPNM,"
        strSQL = strSQL & "          TPM020.PRICEDISP"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM020_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�O���[�v�擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM060_2(ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM060_2 = False

        '------------------------------
        ' ���j���[�O���[�v�}�X�^�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM060.MENUID,"
        strSQL = strSQL & "       TPM060.MENUNM,"
        strSQL = strSQL & "       TPM060.MENUGRPID,"
        strSQL = strSQL & "       TPM060.MENUGRPNM,"
        strSQL = strSQL & "       TPM060.ENABLED"
        '--- (2006.02.13) ���j���[�؂�ւ��Ή� ----------------------------------
        'strSQL = strSQL & ",      TPM060.MENUUSE"
        '------------------------------------------------------------------------
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " WHERE TPM060.GROUPCD = '" & GC_DUMMY_GROUPCD & "'"
        strSQL = strSQL & " GROUP BY TPM060.MENUID,"
        strSQL = strSQL & "          TPM060.MENUNM,"
        strSQL = strSQL & "          TPM060.MENUGRPID,"
        strSQL = strSQL & "          TPM060.MENUGRPNM,"
        strSQL = strSQL & "          TPM060.ENABLED"
        '--- (2006.02.13) ���j���[�؂�ւ��Ή� ----------------------------------
        'strSQL = strSQL & ",      TPM060.MENUUSE"
        '------------------------------------------------------------------------
        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM060_2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�O���[�v�����i�O���[�v�ꗗ�擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM060_3(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM060_3 = False

        '------------------------------
        ' ���j���[�O���[�v�}�X�^�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM060.GROUPCD,"
        strSQL = strSQL & "       TPM020.GROUPNM,"
        strSQL = strSQL & "       TPM060.MENUSTYLE,"
        strSQL = strSQL & "       TPM060.GROUPKBN,"
        strSQL = strSQL & "       TPM060.PRICEDISP"
        strSQL = strSQL & "  FROM TPM060,"
        strSQL = strSQL & "       TPM020"
        strSQL = strSQL & " WHERE TPM060.MENUID = '" & pMenuID & "'"
        strSQL = strSQL & "   AND TPM060.MENUGRPID = '" & pMenuGrpID & "'"
        strSQL = strSQL & "   AND TPM060.GROUPCD <> '" & GC_DUMMY_GROUPCD & "'"
        strSQL = strSQL & "   AND TPM020.GROUPCD = TPM060.GROUPCD"
        strSQL = strSQL & "   AND TPM020.GOODSCD = '0000'"
        '        strSQL = strSQL & " ORDER BY TPM060.DISPORDER"             '2005.10.08 ��Q�C��
        strSQL = strSQL & " ORDER BY CONVERT(INT,TPM060.DISPORDER)"
        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM060_3 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�O���[�v�����i�O���[�v�ꗗ�擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM060_4(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM060_4 = False

        '------------------------------
        ' ���j���[�O���[�v�}�X�^�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM060.GROUPCD,"
        strSQL = strSQL & "       TPM060.MENUSTYLE,"
        strSQL = strSQL & "       TPM060.GROUPKBN"
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " WHERE TPM060.MENUID = '" & pMenuID & "'"
        strSQL = strSQL & "   AND TPM060.MENUGRPID = '" & pMenuGrpID & "'"
        strSQL = strSQL & "   AND TPM060.GROUPCD = '" & GC_DUMMY_GROUPCD & "'"
        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM060_4 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�c���[��������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetMenuTree()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim dtsData As New DataSet()
        Dim dtrData As DataRow = Nothing
        Dim lngCnt As Long
        Dim objNode As TreeNode = Nothing
        Dim objCNode As TreeNode = Nothing
        Dim strBKey As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        trv_Menu.Nodes.Clear()                                              ' ���j���[�c���[�r���[������
        lst_TreeKey.Items.Clear()                                           ' �B���L�[�ێ����X�g������
        txt_MenuTitle.Clear()

        '------------------------------
        ' ���j���[�c���[��������
        '------------------------------
        If Not LF_GetTPM060_2(dtsData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            L_ProcFlg = True                                                    ' �C�x���g��������t���O�n�m
            lngCnt = 0
            strBKey = ""
            While lngCnt < dtsData.Tables("com").Rows.Count
                If Not GF_GetRows(dtsData, lngCnt, dtrData) Then
                    GoTo SYSTEM_ERROR
                End If

                '------------------------------
                ' �e�m�[�h�ǉ�
                '------------------------------
                If strBKey <> Trim$(dtrData("MENUID")) Then
                    objNode = trv_Menu.Nodes.Add(Trim$(dtrData("MENUNM")))
                    '--- (2006.02.13) ���j���[�؂�ւ��Ή� -----------------------
                    objNode.Checked = True
                    'If Trim$(dtrData("MENUUSE")) = "0" Then
                    '    objNode.Checked = True
                    'Else
                    '    objNode.Checked = False
                    'End If
                    '-------------------------------------------------------------
                    lst_TreeKey.Items.Add("P" & _
                                          Format$(objNode.Index, "00000") & _
                                          vbTab & _
                                          Trim$(dtrData("MENUID")))
                    strBKey = Trim$(dtrData("MENUID"))
                End If

                '------------------------------
                ' �q�m�[�h�ǉ�
                '------------------------------
                objCNode = objNode.Nodes.Add(Trim$(dtrData("MENUGRPNM")))
                objCNode.Checked = IIf(Trim$(dtrData("ENABLED")) = GC_TRUE, True, False)
                lst_TreeKey.Items.Add("C" & _
                                      Format$(objNode.Index, "00000") & _
                                      Format$(objCNode.Index, "00000") & _
                                      vbTab & _
                                      Trim$(dtrData("MENUGRPID")))              ' �B�����ڂ̃L�[�l�ǉ�

                lngCnt = lngCnt + 1
            End While
            L_ProcFlg = False                                                   ' �C�x���g��������t���O�n�e�e
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetMenuTree")
        L_ProcFlg = False
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�O���[�v�h�c�擾
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetMenuGrpCD(ByVal pNode As TreeNode) As String

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngCnt As Long
        Dim strFindKey As String
        Dim strWork() As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetMenuGrpCD = ""

        Try
            '------------------------------
            ' �e�m�[�h�͌����s��
            '------------------------------
            If IsNothing(pNode.Parent) Then
                strFindKey = "P" & Format$(pNode.Index, "00000")
            Else
                strFindKey = "C" & Format$(pNode.Parent.Index, "00000") & _
                                   Format$(pNode.Index, "00000")
            End If

            For lngCnt = 0 To lst_TreeKey.Items.Count() - 1
                strWork = Split(lst_TreeKey.Items(lngCnt), vbTab)
                If Trim$(strWork(0)) = strFindKey Then
                    LF_GetMenuGrpCD = Trim$(strWork(1))
                End If
            Next
        Catch
            Exit Function
        End Try

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�c���[���쎞����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub trv_Menu_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trv_Menu.AfterSelect

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim dtsData As New DataSet()

        Try
            '------------------------------
            ' �I���m�[�h����
            '------------------------------
            L_ProcFlg2 = True                                                   ' �e�I�u�W�F�N�g��Change�C�x���g�����}�~
            lsv_MenuGrp.Items.Clear()
            lsv_ItemGrp.Items.Clear()
            chk_Price.Checked = False
            chk_ShowGenr.Checked = False
            cbo_Pat.SelectedIndex = 0
            cbo_Style.SelectedIndex = 0

            L_MenuGrpID = LF_GetMenuGrpCD(e.Node)       '-- (2006.01.27) ���j���[�摜�쐬��ʂւ̃p�����^
            L_MenuID = LF_GetMenuGrpCD(trv_Menu.SelectedNode.Parent)

            If Not IsNothing(e.Node.Parent) Then
                chk_Price.Enabled = True
                chk_ShowGenr.Enabled = True
                cbo_Pat.Enabled = True
                cbo_Style.Enabled = True
                '--- (2006.01.31) ���j���[�摜�쐬 -------------------------------------------
                btn_MenuPic.Enabled = True
                LF_SetCbo_Pat(LF_GetMenuGrpCD(e.Node.Parent), LF_GetMenuGrpCD(e.Node))
                Call LS_SetMenuGrp(LF_GetMenuGrpCD(e.Node.Parent), _
                                   LF_GetMenuGrpCD(e.Node))                     ' [�I����]���i�O���[�v�ꗗ ����
                Call LS_SetItemGrp(LF_GetMenuGrpCD(e.Node.Parent), _
                                   LF_GetMenuGrpCD(e.Node))                     ' [�I����]���i�O���[�v�ꗗ ����
                '-----------------------------------------------------------------------------
                '--- (2006.02.10) ��z���j���[ ---------------------------
                'chk_Teigaku.Enabled = True
                'If LF_GetPriceType(LF_GetMenuGrpCD(e.Node.Parent), LF_GetMenuGrpCD(e.Node)) <> "0" Then
                '    chk_Teigaku.Checked = True
                '    txt_Price.Enabled = True
                '    txt_Price.Text = LF_GetPrice(LF_GetGoodsCD) & "�~"
                'Else
                '    chk_Teigaku.Checked = False
                '    txt_Price.Enabled = False
                '    txt_Price.Text = ""
                'End If
                '---------------------------------------------------------
            Else
                Call GS_CboChgSel(cbo_Pat, LC_PAT_GENR)
                Call GS_CboChgSel(cbo_Style, LC_STYLE_LIST)
                chk_Price.Enabled = False
                chk_ShowGenr.Enabled = False
                cbo_Pat.Enabled = False
                cbo_Style.Enabled = False
                '--- (2006.01.31) ���j���[�摜�쐬�{�^��
                btn_MenuPic.Enabled = False
                '--- (2006.02.10) ��z���j���[
                'chk_Teigaku.Enabled = False
                'txt_Price.Text = ""
                'txt_Price.Enabled = False
                '-----------------------------
            End If
            txt_MenuTitle.Text = e.Node.Text
            L_ProcFlg2 = False
            '---20060530 ���{ ADD START ���i�W�������o�^0�����̓��j���[�摜�쐬�s��
            btn_MenuPic.Enabled = True
            If lsv_MenuGrp.Items.Count = 0 Then

                btn_MenuPic.Enabled = False

            End If
            '---20060530 ���{ ADD END
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("trv_Menu_AfterSelect")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���i�O���[�v�ꗗ�ݒ菈��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    ' Private Sub LS_SetItemGrp(ByVal pMenuID As String)
    Private Sub LS_SetItemGrp(ByVal pMenuID As String, ByVal pMenuGrpID As String)
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngCnt As Long
        Dim dtsData As New DataSet()
        Dim dtrData As DataRow = Nothing
        Dim objItem As ListViewItem

        Try
            '------------------------------
            ' ����������
            '------------------------------
            lsv_ItemGrp.Items.Clear()

            '------------------------------
            ' ���i�O���[�v�ꗗ�ݒ�
            '------------------------------
            If Not LF_GetTPM020_1(pMenuID, pMenuGrpID, dtsData) Then
                GoTo SYSTEM_ERROR
            End If
            lngCnt = 0
            While lngCnt < dtsData.Tables("com").Rows.Count
                If Not GF_GetRows(dtsData, lngCnt, dtrData) Then
                    GoTo SYSTEM_ERROR
                End If

                objItem = New ListViewItem()
                With objItem
                    .Text = Trim$(dtrData("GROUPNM"))
                    .Tag = Trim$(dtrData("GROUPCD"))
                    .ImageIndex = 0
                    .SubItems.Add(dtrData("PRICEDISP"))
                End With
                lsv_ItemGrp.Items.Add(objItem)

                lngCnt = lngCnt + 1
            End While
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetItemGrp")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�����i�O���[�v���X�g�ݒ菈��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetMenuGrp(ByVal pMenuID As String, ByVal pMenuGrpID As String)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim dtsData As New DataSet()
        Dim dtrData As DataRow = Nothing
        Dim lngCnt As Long
        Dim strWork As String = Nothing
        Dim objItem As ListViewItem

        '------------------------------
        ' ����������
        '------------------------------
        lst_MenuGrp.Items.Clear()                                           ' �B�����ڏ����N���A

        '------------------------------
        ' ���i�O���[�v�ꗗ�擾
        '------------------------------
        If Not LF_GetTPM060_3(pMenuID, pMenuGrpID, dtsData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            '------------------------------
            ' �q�m�[�h���R�[�h�쐬
            '------------------------------
            lngCnt = 0
            While lngCnt < dtsData.Tables("com").Rows.Count
                If Not GF_GetRows(dtsData, lngCnt, dtrData) Then
                    GoTo SYSTEM_ERROR
                End If

                objItem = New ListViewItem()
                With objItem
                    .Text = strWork

                End With
                strWork = Trim$(dtrData("GROUPNM")) & vbTab & _
                          Trim$(dtrData("GROUPCD")) & vbTab & _
                          Trim$(dtrData("PRICEDISP"))
                lst_MenuGrp.Items.Add(strWork)

                lngCnt = lngCnt + 1
            End While
            Call LS_SetMenuGrpFromHide()

            '------------------------------
            ' �`�F�b�N�{�b�N�X�̐ݒ�
            '------------------------------
            dtsData = New DataSet()
            If LF_GetTPM060_4(pMenuID, pMenuGrpID, dtsData) = False Then
                GoTo SYSTEM_ERROR
            End If
            If dtsData.Tables("com").Rows.Count <> 0 Then
                If Not GF_GetRows(dtsData, 0, dtrData) Then
                    GoTo SYSTEM_ERROR
                End If

                ' --- (2004.02.06) ���������ύX ----------------------------
                'Select Case Trim$(dtrData("MENUSTYLE"))
                '    Case GC_MSTYLE_LISTSTR
                '        rdo_Pat1.Checked = True
                '        rdo_Pat2.Checked = False
                '        rdo_Pat3.Checked = False
                '        rdo_Pat4.Checked = False
                '        rdo_Pat5.Checked = False                            ' --- (2004.02.04) �l�^�P�[�X�Ή� ---
                '        chk_Price.Enabled = True
                '        chk_ShowGenr.Enabled = True
                '    Case GC_MSTYLE_LISTPIC
                '        rdo_Pat1.Checked = False
                '        rdo_Pat2.Checked = True
                '        rdo_Pat3.Checked = False
                '        rdo_Pat4.Checked = False
                '        rdo_Pat5.Checked = False                            ' --- (2004.02.04) �l�^�P�[�X�Ή� ---
                '        chk_Price.Enabled = True
                '        chk_ShowGenr.Enabled = True
                '    Case GC_MSTYLE_NOLIST
                '        rdo_Pat1.Checked = False
                '        rdo_Pat2.Checked = False
                '        rdo_Pat3.Checked = False
                '        rdo_Pat4.Checked = True
                '        rdo_Pat5.Checked = False                            ' --- (2004.02.04) �l�^�P�[�X�Ή� ---
                '        chk_Price.Enabled = False
                '        chk_ShowGenr.Enabled = False
                '    Case GC_MSTYLE_NOLISTSTR
                '        rdo_Pat1.Checked = False
                '        rdo_Pat2.Checked = False
                '        rdo_Pat3.Checked = True
                '        rdo_Pat4.Checked = False
                '        rdo_Pat5.Checked = False                            ' --- (2004.02.04) �l�^�P�[�X�Ή� ---
                '        chk_Price.Enabled = False
                '        chk_ShowGenr.Enabled = False
                '    Case GC_MSTYLE_NETACASE
                '        ' --- (2004.02.04) �l�^�P�[�X�Ή� ------------------
                '        rdo_Pat1.Checked = False
                '        rdo_Pat2.Checked = False
                '        rdo_Pat3.Checked = False
                '        rdo_Pat4.Checked = False
                '        rdo_Pat5.Checked = True
                '        chk_Price.Enabled = False
                '        chk_ShowGenr.Enabled = False
                '        ' --------------------------------------------------
                'End Select
                'Select Case Trim$(dtrData("GROUPKBN"))
                '    Case GC_ORDER_PRICE
                '        chk_Price.Checked = True
                '        chk_ShowGenr.Checked = False
                '    Case GC_ORDER_PRICE2
                '        chk_Price.Checked = True
                '        chk_ShowGenr.Checked = True
                '    Case Else
                '        chk_Price.Checked = False
                '        chk_ShowGenr.Checked = False
                'End Select
                ' ----------------------------------------------------------

                Select Case Trim$(dtrData("MENUSTYLE"))
                    Case GC_MSTYLE_LISTSTR
                        Call GS_CboChgSel(cbo_Pat, LC_PAT_GENR)
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_LIST)

                    Case GC_MSTYLE_LISTPIC
                        Call GS_CboChgSel(cbo_Pat, LC_PAT_GENR)
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC12)

                    Case GC_MSTYLE_LISTPIC4
                        Call GS_CboChgSel(cbo_Pat, LC_PAT_GENR)
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC4)

                    Case GC_MSTYLE_NETACASE
                        Call GS_CboChgSel(cbo_Pat, LC_PAT_NETA)
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC4)

                    Case GC_MSTYLE_NETASTR
                        Call GS_CboChgSel(cbo_Pat, LC_PAT_NETA)
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_LIST)

                    Case GC_MSTYLE_NETAPIC
                        Call GS_CboChgSel(cbo_Pat, LC_PAT_NETA)
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC12)

                    Case GC_MSTYLE_NOLIST
                        Call GS_CboChgSel(cbo_Pat, LC_PAT_DIRC)
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_LIST)

                    Case GC_MSTYLE_NOLISTSTR
                        Call GS_CboChgSel(cbo_Pat, LC_PAT_DIRC)
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC12)

                    Case GC_MSTYLE_NOLISTPIC4
                        Call GS_CboChgSel(cbo_Pat, LC_PAT_DIRC)
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC4)

                        '--- (2006.01.31) ���j���[�摜�ǉ� -----------------------
                    Case GC_MSTYLE_PICTJ
                        Call GS_CboChgSel(cbo_Pat, "3")
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_LIST)
                    Case GC_MSTYLE_PIC12
                        Call GS_CboChgSel(cbo_Pat, "3")
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC12)
                    Case GC_MSTYLE_PIC4
                        Call GS_CboChgSel(cbo_Pat, "3")
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC4)


                End Select

                chk_Price.Enabled = True
                chk_ShowGenr.Enabled = True
                Select Case Trim$(dtrData("GROUPKBN"))
                    Case GC_ORDER_GROUP
                        chk_Price.Checked = False
                        chk_ShowGenr.Checked = False
                    Case GC_ORDER_PRICE
                        chk_Price.Checked = True
                        chk_ShowGenr.Checked = False
                    Case GC_ORDER_PRICE2
                        chk_Price.Checked = True
                        chk_ShowGenr.Checked = True
                    Case Else
                        chk_Price.Enabled = False
                        chk_ShowGenr.Enabled = False
                End Select

                '--- (2006.02.08) ���j���[�摜�ǉ� --------------------------------------------
                ' �u���j���[�摜�\���v�̏ꍇ�A�e�`�F�b�NBOX�͎g���Ȃ�
                If Trim$(dtrData("MENUSTYLE")) = GC_MSTYLE_PICTJ Or _
                   Trim$(dtrData("MENUSTYLE")) = GC_MSTYLE_PIC12 Or _
                   Trim$(dtrData("MENUSTYLE")) = GC_MSTYLE_PIC4 Then
                    chk_Price.Enabled = False
                    chk_ShowGenr.Enabled = False
                End If
                '------------------------------------------------------------------------------
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetMenuGrp")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�����i�O���[�v���X�g�ݒ�i�B�����ڂ��\����֔��f�j
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetMenuGrpFromHide()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngCnt As Long
        Dim objItem As ListViewItem
        Dim strWork() As String

        '------------------------------
        ' ����������
        '------------------------------
        lsv_MenuGrp.Items.Clear()                                           ' ���i�O���[�v�ꗗ�����N���A

        Try
            For lngCnt = 0 To lst_MenuGrp.Items.Count - 1

                objItem = New ListViewItem()
                strWork = Split(lst_MenuGrp.Items(lngCnt), vbTab)

                With objItem
                    .Text = strWork(0)
                    .Tag = strWork(1)
                    .ImageIndex = 0
                    .SubItems.Add(strWork(2))
                End With
                lsv_MenuGrp.Items.Add(objItem)

            Next
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetMenuGrpFromHide")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F(�I����)���i�O���[�v�ꗗ �h���b�O�J�n������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub lsv_MenuGrp_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_MenuGrp.ItemDrag
        L_DragMode = LC_MOVEMODE
        lsv_MenuGrp.DoDragDrop(e.Item, DragDropEffects.Copy)
        '---20060530 ���{ ADD START ���i�W�������o�^0�����̓��j���[�摜�쐬�s��
        btn_MenuPic.Enabled = True
        If lsv_MenuGrp.Items.Count = 0 Then

            btn_MenuPic.Enabled = False

        End If
        '---20060530 ���{ ADD END
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F(�I����)���i�O���[�v�ꗗ �h���b�O������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub lsv_MenuGrp_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_MenuGrp.DragEnter
        If (e.Data.GetDataPresent(GetType(ListViewItem))) Then
            e.Effect = DragDropEffects.Copy
        End If
        '---20060530 ���{ ADD START ���i�W�������o�^0�����̓��j���[�摜�쐬�s��
        btn_MenuPic.Enabled = True
        If lsv_MenuGrp.Items.Count = 0 Then

            btn_MenuPic.Enabled = False

        End If
        '---20060530 ���{ ADD END
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F(�I����)���i�O���[�v�ꗗ �h���b�O������
    ' �@�@�\�T�v�F�����A�C�e����Ƀh���b�O�����ہA���Y�A�C�e����I����Ԃɂ���
    '             (����� WindowsExplorer �ɂ��킹��)
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub lsv_MenuGrp_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_MenuGrp.DragOver

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objItem As ListViewItem
        Dim objPoint As Point

        If (e.Data.GetDataPresent(GetType(ListViewItem))) Then
            objPoint = lsv_MenuGrp.PointToClient(New Point(e.X, e.Y))
            objItem = lsv_MenuGrp.GetItemAt(objPoint.X, objPoint.Y)
            If Not IsNothing(objItem) Then
                lsv_MenuGrp.Select()
                objItem.Selected = True
            End If
        End If
        '---20060530 ���{ ADD START ���i�W�������o�^0�����̓��j���[�摜�쐬�s��
        btn_MenuPic.Enabled = True
        If lsv_MenuGrp.Items.Count = 0 Then

            btn_MenuPic.Enabled = False

        End If
        '---20060530 ���{ ADD END
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F(�c�a�X�V�_�@)[�I����]���i�O���[�v�ꗗ �h���b�v������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub lsv_MenuGrp_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_MenuGrp.DragDrop

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objItem As ListViewItem
        Dim objSrcItem As ListViewItem
        Dim objPoint As Point
        Dim intIndex As Integer
        Dim strWork As String
        Dim lngCnt As Integer
        Dim udtUpdVal As typTPM060 = Nothing
        Dim udtUpdKey As typTPM060 = Nothing
        Dim udtDummy As typTPM060 = Nothing                                           ' �������p�Ɏg�p����B�l�̐ݒ�֎~

        Try
            If (e.Data.GetDataPresent(GetType(ListViewItem))) Then
                '------------------------------
                ' �󗝃f�[�^�擾
                '------------------------------
                objSrcItem = e.Data.GetData(GetType(ListViewItem))              ' �h���b�O����Ă����A�C�e���f�[�^
                objPoint = lsv_MenuGrp.PointToClient(New Point(e.X, e.Y))       ' �}�E�X�|�C���^�̍��W�ʒu
                objItem = lsv_MenuGrp.GetItemAt(objPoint.X, objPoint.Y)         ' ���ɑΉ�����A�A�C�e���f�[�^
                intIndex = lsv_MenuGrp.Items.IndexOf(objItem)                   ' ���� index�l

                strWork = objSrcItem.Text & vbTab & _
                          objSrcItem.Tag & vbTab & _
                          objSrcItem.SubItems(1).Text                           ' �B���̈�֓o�^����l�𐶐�
                If L_DragMode = LC_MOVEMODE Then                                ' �h���b�O���[�h�̔���
                    For lngCnt = 0 To lst_MenuGrp.Items.Count - 1               ' �B���̈���ɁA����A�C�e�������݂���ꍇ�́A��ɍ폜���Ă��܂�
                        If strWork = lst_MenuGrp.Items(lngCnt) Then
                            lst_MenuGrp.Items.RemoveAt(lngCnt)
                            Exit For
                        End If
                    Next
                End If

                If intIndex = -1 Then                                           ' �}����Index�����߂�
                    intIndex = lst_MenuGrp.Items.Count
                Else
                    If intIndex < 0 Then
                        intIndex = 0
                    End If
                End If
                lst_MenuGrp.Items.Insert(intIndex, strWork)
                If L_DragMode = LC_COPYMODE Then
                    objSrcItem.Remove()
                End If

                Call LS_SetMenuGrpFromHide()                                    ' �B�����X�g�{�b�N�X����A�\����֔��f

                '------------------------------
                ' �h���b�v��񁨂c�a���f
                '------------------------------
                If L_DragMode = LC_MOVEMODE Then
                    '------------------------------
                    ' �d���A�C�e���폜����
                    '------------------------------
                    With udtUpdKey
                        .MENUID = LF_GetMenuGrpCD(trv_Menu.SelectedNode.Parent)
                        .MENUGRPID = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
                        .GROUPCD = CStr(objSrcItem.Tag)
                    End With
                    If Not LF_UpdTPM060_3(udtUpdVal, udtUpdKey, False) Then
                        GoTo SYSTEM_ERROR
                    End If
                End If

                With udtUpdVal
                    .MENUID = LF_GetMenuGrpCD(trv_Menu.SelectedNode.Parent)
                    .MENUNM = GF_RepQuo(trv_Menu.SelectedNode.Parent.Text)
                    .MENUGRPID = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
                    .MENUGRPNM = GF_RepQuo(trv_Menu.SelectedNode.Text)
                    .GROUPCD = CStr(objSrcItem.Tag)
                    .DISPORDER = CStr(intIndex)
                    .PRICEDISP = IIf(CStr(objSrcItem.SubItems(1).Text), GC_TRUE, GC_FALSE)
                    .ENABLED = GC_TRUE
                    .UPDID = GC_UPDID
                    .UPDYMD = Now
                    '--- (2006.02.13) ���j���[�؂�ւ��Ή� --------------------------------------------
                    '.PRICETYPE = IIf(chk_Teigaku.Checked, "1", "0")
                    '.MENUUSE = IIf(trv_Menu.SelectedNode.Parent.Checked, "0", "1")
                    '----------------------------------------------------------------------------------
                End With
                Call LF_GetChkStatus(udtUpdVal)                             ' �`�F�b�N��Ԏ擾
                If Not LF_UpdTPM060_3(udtUpdVal, udtUpdKey, True) Then
                    GoTo SYSTEM_ERROR
                End If

                '------------------------------
                ' �\�������ڂ̃��i���o����
                '------------------------------
                udtUpdVal = udtDummy                                        ' �ϐ�������
                udtUpdKey = udtDummy
                For lngCnt = 0 To lsv_MenuGrp.Items.Count - 1
                    With udtUpdVal
                        .DISPORDER = CLng(lngCnt)
                        .UPDID = GC_UPDID
                        .UPDYMD = Now
                    End With
                    With udtUpdKey
                        .MENUID = LF_GetMenuGrpCD(trv_Menu.SelectedNode.Parent)
                        .MENUGRPID = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
                        .GROUPCD = lsv_MenuGrp.Items(lngCnt).Tag
                    End With
                    If Not LF_UpdTPM060_5(udtUpdVal, udtUpdKey) Then
                        GoTo SYSTEM_ERROR
                    End If
                Next

            End If
            '---20060530 ���{ ADD START ���i�W�������o�^0�����̓��j���[�摜�쐬�s��
            btn_MenuPic.Enabled = True
            If lsv_MenuGrp.Items.Count = 0 Then

                btn_MenuPic.Enabled = False

            End If
            '---20060530 ���{ ADD END
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("lsv_MenuGrp_DragDrop")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���i�O���[�v�ꗗ �h���b�O�J�n������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub lsv_ItemGrp_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_ItemGrp.ItemDrag
        L_DragMode = LC_COPYMODE
        lsv_ItemGrp.DoDragDrop(e.Item, DragDropEffects.Copy)
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���i�O���[�v�ꗗ �h���b�O������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub lsv_ItemGrp_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemGrp.DragEnter
        If (e.Data.GetDataPresent(GetType(ListViewItem))) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���i�O���[�v�ꗗ �h���b�v������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub lsv_ItemGrp_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemGrp.DragDrop

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objSrcItem As ListViewItem
        Dim objItem As ListViewItem
        Dim lngCnt As Integer
        Dim strWork As String
        Dim udtUpdVal As typTPM060 = Nothing
        Dim udtUpdKey As typTPM060 = Nothing

        Try
            If (e.Data.GetDataPresent(GetType(ListViewItem))) Then
                '------------------------------
                ' �󗝃f�[�^�擾
                '------------------------------
                objSrcItem = e.Data.GetData(GetType(ListViewItem))
                For lngCnt = 0 To lsv_ItemGrp.Items.Count - 1
                    If lsv_ItemGrp.Items(lngCnt).Tag = objSrcItem.Tag Then      ' ���i�O���[�v�R�[�h�d���`�F�b�N
                        Exit Sub
                    End If
                Next

                '------------------------------
                ' �ǉ��A�C�e���̐���
                '------------------------------
                objItem = New ListViewItem()
                With objItem
                    .Text = objSrcItem.Text
                    .Tag = objSrcItem.Tag
                    .ImageIndex = 0
                    .SubItems.Add(objSrcItem.SubItems(1).Text)
                End With
                lsv_ItemGrp.Items.Add(objItem)

                ' ���i�O���[�v���X�g����A�Ώۂ̃��R�[�h���폜���Ă���
                For lngCnt = 0 To lst_MenuGrp.Items.Count - 1
                    strWork = objSrcItem.Text & vbTab & _
                              objSrcItem.Tag & vbTab & _
                              objSrcItem.SubItems(1).Text
                    If strWork = lst_MenuGrp.Items(lngCnt) Then                 ' (�I����)���i���X�g���̍폜/�ĕ`�揈��
                        lst_MenuGrp.Items.RemoveAt(lngCnt)
                        Call LS_SetMenuGrpFromHide()
                        Exit For
                    End If
                Next

                '------------------------------
                ' ���i�O���[�v�폜�^�c�a���f
                '------------------------------
                With udtUpdKey
                    .MENUID = LF_GetMenuGrpCD(trv_Menu.SelectedNode.Parent)
                    .MENUGRPID = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
                    .GROUPCD = CStr(objSrcItem.Tag)
                End With
                If Not LF_UpdTPM060_3(udtUpdVal, udtUpdKey, False) Then
                    GoTo SYSTEM_ERROR
                End If

            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("lsv_ItemGrp_DragDrop")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F(�c�a�X�V�_�@)�O���[�v���e�L�X�g�{�b�N�X ���͒l�ύX������
    ' �@�@�\�T�v�F���͓��e�𒀈�A�c���[�r���[�֒ʒm���A�c�a�X�V���s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub txt_MenuTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MenuTitle.TextChanged

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objNode As TreeNode = Nothing
        Dim udtUpdVal As typTPM060 = Nothing
        Dim udtUpdKey As typTPM060 = Nothing

        If IsNothing(trv_Menu.SelectedNode) Then Exit Sub
        If txt_MenuTitle.Modified = False Then Exit Sub

        ' --- (2003.12.08) ���p��������͐������� ---
        Dim lngST As Long
        lngST = txt_MenuTitle.SelectionStart
            ' 2014-05-12 2�o�C�g������������
        'txt_MenuTitle.Text = StrConv(txt_MenuTitle.Text, VbStrConv.Wide)
        If lngST >= 0 Then txt_MenuTitle.SelectionStart = lngST
        ' -------------------------------------------

        '------------------------------
        ' �c���[�r���[�ւ̓��͒l���f
        '------------------------------
        objNode = trv_Menu.SelectedNode
        If IsNothing(objNode.Parent) Then
            If GF_LenB(txt_MenuTitle.Text) > 50 Then
                txt_MenuTitle.Text = GF_MidB(txt_MenuTitle.Text, 1, 50)
                txt_MenuTitle.SelectionStart = GF_LenB(txt_MenuTitle.Text)
            End If
        Else
            ' --- (2003.12.02) ���͒������̕ύX ----------------------------
            'If GF_LenB(txt_MenuTitle.Text) > 20 Then
            '    txt_MenuTitle.Text = GF_MidB(txt_MenuTitle.Text, 1, 20)
            '    txt_MenuTitle.SelectionStart = GF_LenB(txt_MenuTitle.Text)
            'End If
            If GF_LenB(txt_MenuTitle.Text) > 36 Then
                txt_MenuTitle.Text = GF_MidB(txt_MenuTitle.Text, 1, 36)
                txt_MenuTitle.SelectionStart = GF_LenB(txt_MenuTitle.Text)
            End If
            ' --------------------------------------------------------------
        End If
        objNode.Text = txt_MenuTitle.Text

        '------------------------------
        ' �c�a�ւ̓��͒l���f(�X�V)
        '------------------------------
        If IsNothing(objNode.Parent) Then                                   ' �e�m�[�h���̕ύX
            udtUpdKey.MENUID = LF_GetMenuGrpCD(objNode)
            udtUpdVal.MENUNM = GF_RepQuo(Trim$(txt_MenuTitle.Text))
        Else                                                                ' �q�m�[�h���̕ύX
            udtUpdKey.MENUID = LF_GetMenuGrpCD(objNode.Parent)
            udtUpdKey.MENUGRPID = LF_GetMenuGrpCD(objNode)
            udtUpdVal.MENUGRPNM = GF_RepQuo(Trim$(txt_MenuTitle.Text))
        End If
        udtUpdVal.UPDID = GC_UPDID
        udtUpdVal.UPDYMD = Now
        If Not LF_UpdTPM060_2(udtUpdVal, udtUpdKey) Then
            GoTo SYSTEM_ERROR
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_MenuTitle_TextChanged")

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�c�[���o�[����������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub tlb_Btn_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlb_Btn.ButtonClick

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As Form = Nothing

        Select Case e.Button.Text
            Case tlb_Btn.Buttons.Item(0).Text
                objForm = New CNL1551()
            Case tlb_Btn.Buttons.Item(1).Text
                objForm = New CNL1552()
            Case tlb_Btn.Buttons.Item(2).Text
                If Not IsNothing(trv_Menu.SelectedNode) Then
                    Select Case LF_UpdDeleteMenu(trv_Menu.SelectedNode)
                        Case CNL1920.FuncResult.NormalEnd
                            Call LS_Initialize()
                        Case CNL1920.FuncResult.CancelEnd
                        Case CNL1920.FuncResult.UnusualEnd
                            GoTo SYSTEM_ERROR
                        Case Else
                            GoTo SYSTEM_ERROR
                    End Select
                End If
                Exit Sub
        End Select

        objForm.ShowDialog()
        Select Case objForm.DialogResult
            Case DialogResult.OK
                Call LS_Initialize()
                L_EditFlg = True
            Case DialogResult.Cancel
                ' �������Ȃ�
            Case Else
                GoTo SYSTEM_ERROR
        End Select
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("tlb_Btn_ButtonClick")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�폜����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdDeleteMenu(ByVal pNode As TreeNode) As FuncResult

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim strMenuID As String
        Dim strMenuNm As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdDeleteMenu = CNL1920.FuncResult.UnusualEnd

        '------------------------------
        ' �Ώۃ��j���[�h�c�擾
        '------------------------------
        If Not IsNothing(pNode.Parent) Then
            strMenuID = LF_GetMenuGrpCD(pNode.Parent)
            strMenuNm = Trim$(pNode.Parent.Text)
        Else
            strMenuID = LF_GetMenuGrpCD(pNode)
            strMenuNm = Trim$(pNode.Text)
        End If

        If GF_Msg("", Replace(GF_GetMsg("Q05"), "@@@", strMenuNm), MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            If GF_Msg("A01", "", MsgBoxStyle.YesNo, MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                strSQL = ""
                strSQL = strSQL & "DELETE FROM TPM060"
                strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"
                If Not GF_UpdData(strSQL) Then
                    Exit Function
                End If

                '--- (2006.02.08) ���j���[�摜�p�e�[�u���� ------------------------------------------
                strSQL = ""
                strSQL = strSQL & "DELETE FROM TPM150"
                strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"
                If Not GF_UpdData(strSQL) Then
                    Exit Function
                End If
                '------------------------------------------------------------------------------------

                '--- (2006.02.13) ���j���[�؂�ւ��Ή��@�R�t�����i�R�[�h��������-------------------
                'If Not GF_MenuGoodsLink(strMenuID, "", "DEL") Then
                '    Exit Function
                'End If
                '------------------------------------------------------------------------------------

                L_EditFlg = True
            Else
                LF_UpdDeleteMenu = CNL1920.FuncResult.CancelEnd
                Exit Function
            End If
        Else
            LF_UpdDeleteMenu = CNL1920.FuncResult.CancelEnd
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdDeleteMenu = CNL1920.FuncResult.NormalEnd

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F(�c�a�X�V�_�@)���j���[�c���[ �`�F�b�N��ԕω�������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub trv_Menu_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trv_Menu.AfterCheck

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim udtUpdVal As typTPM060 = Nothing
        Dim udtUpdKey As typTPM060 = Nothing

        '------------------------------
        ' �C�x���g��������t���O�m�F
        '------------------------------
        If L_ProcFlg Then Exit Sub
        If IsNothing(e.Node.Parent) Then Exit Sub

        '------------------------------
        ' ���j���[�g�p�ۍX�V����
        '------------------------------
        Try
            With udtUpdVal                                                  ' �X�V�l�ݒ�
                .ENABLED = IIf(e.Node.Checked, GC_TRUE, GC_FALSE)
                .UPDID = GC_UPDID
                .UPDYMD = Now
            End With
            With udtUpdKey                                                  ' �X�V�ΏۃL�[�l�ݒ�
                .MENUID = LF_GetMenuGrpCD(e.Node.Parent)
                .MENUGRPID = LF_GetMenuGrpCD(e.Node)
            End With
            If Not LF_UpdTPM060_1(udtUpdVal, udtUpdKey) Then
                GoTo SYSTEM_ERROR
            End If

        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("trv_Menu_AfterCheck")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�c���[ �`�F�b�N��ԕω����O����
    ' �@�@�\�T�v�F�e(Root)�m�[�h�̃`�F�b�N��ԕύX���֎~����
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub trv_Menu_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles trv_Menu.BeforeCheck

        '------------------------------
        ' �C�x���g��������t���O�m�F
        '------------------------------
        If L_ProcFlg Then Exit Sub

        '--- (2006.02.13) ���j���[�؂�ւ��Ή� -------------------  2006.06.28 �C��
        If IsNothing(e.Node.Parent) Then
            e.Cancel = True
        End If
        '---------------------------------------------------------

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FTPM060(���j���[�O���[�v�}�X�^)�X�V���� - (�P)
    ' �@�@�\�T�v�F���j���[�O���[�v�̎g�p��(ENABLED����)�ɂ��āA�X�V���s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM060_1(ByVal pUpdVal As typTPM060, ByVal pUpdKey As typTPM060) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM060_1 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM060"
        strSQL = strSQL & "   SET TPM060.ENABLED = '" & pUpdVal.ENABLED & "',"
        strSQL = strSQL & "       TPM060.UPDID = '" & pUpdVal.UPDID & "',"
        strSQL = strSQL & "       TPM060.UPDYMD = '" & pUpdVal.UPDYMD & "'"
        strSQL = strSQL & " WHERE TPM060.MENUID = '" & pUpdKey.MENUID & "'"
        strSQL = strSQL & "   AND TPM060.MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If
        L_EditFlg = True

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM060_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FTPM060(���j���[�O���[�v�}�X�^)�X�V���� - (�P)
    ' �@�@�\�T�v�F���j���[�̎g�p��(MENUUSE����)�ɂ��āA�X�V���s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2006.02.13 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM060_1_1(ByVal pMenuUse As String, ByVal pMenuID As String) As Boolean

        ''------------------------------
        '' �����ϐ���`
        ''------------------------------
        'Dim strSQL As String

        ''------------------------------
        '' �����l�ݒ�
        ''------------------------------
        'LF_UpdTPM060_1_1 = False

        'strSQL = ""
        'strSQL = strSQL & "UPDATE TPM060"
        'strSQL = strSQL & "   SET TPM060.MENUUSE = '" & pMenuUse & "',"
        'strSQL = strSQL & "       TPM060.UPDID = '" & GC_UPDID & "',"
        'strSQL = strSQL & "       TPM060.UPDYMD = '" & Now & "'"
        'strSQL = strSQL & " WHERE TPM060.MENUID = '" & pMenuID & "'"
        'If Not GF_UpdData(strSQL) Then
        '    Exit Function
        'End If
        'L_EditFlg = True

        ''------------------------------
        '' �ԋp�l�ݒ�
        ''------------------------------
        LF_UpdTPM060_1_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FTPM060(���j���[�O���[�v�}�X�^)�X�V���� - (�Q)
    ' �@�@�\�T�v�F���j���[�y�у��j���[�O���[�v�̖��̍��ڂɂ��āA�X�V���s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM060_2(ByVal pUpdVal As typTPM060, ByVal pUpdKey As typTPM060) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim strWhere As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM060_2 = False
        strSQL = ""
        strWhere = ""

        '------------------------------
        ' �X�V�r�p�k������
        '------------------------------
        strSQL = strSQL & "UPDATE TPM060"

        If Len(Trim$(pUpdKey.MENUGRPID)) = 0 Then
            strSQL = strSQL & "   SET TPM060.MENUNM    = '" & pUpdVal.MENUNM & "',"
            strWhere = strWhere & " WHERE TPM060.MENUID = '" & pUpdKey.MENUID & "'"
        Else
            strSQL = strSQL & "   SET TPM060.MENUGRPNM = '" & pUpdVal.MENUGRPNM & "',"
            strWhere = strWhere & " WHERE TPM060.MENUID = '" & pUpdKey.MENUID & "'"
            strWhere = strWhere & "   AND TPM060.MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
        End If

        strSQL = strSQL & "       TPM060.UPDID = '" & pUpdVal.UPDID & "',"
        strSQL = strSQL & "       TPM060.UPDYMD = '" & pUpdVal.UPDYMD & "'"
        strSQL = strSQL & strWhere
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If
        L_EditFlg = True

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM060_2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FTPM060(���j���[�O���[�v�}�X�^)�X�V���� - (�R)
    ' �@�@�\�T�v�F���j���[�O���[�v�ɑ�����A���i�O���[�v�̓o�^�^�폜���s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM060_3(ByVal pUpdVal As typTPM060, ByVal pUpdKey As typTPM060, ByVal pblnUpdFlg As Boolean) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        '--- (2006.02.01) ���j���[�摜�ǉ� --------------------
        Dim strSQL2 As String
        Dim objData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM060_3 = False
        strSQL = ""

        '------------------------------
        ' �X�V�r�p�k������
        '------------------------------
        If pblnUpdFlg Then
            strSQL = strSQL & "INSERT INTO TPM060 VALUES("
            strSQL = strSQL & "'" & pUpdVal.MENUID & "',"
            strSQL = strSQL & "'" & pUpdVal.MENUNM & "',"
            strSQL = strSQL & "'" & pUpdVal.MENUGRPID & "',"
            strSQL = strSQL & "'" & pUpdVal.MENUGRPNM & "',"
            strSQL = strSQL & "'" & pUpdVal.MENUSTYLE & "',"
            strSQL = strSQL & "'" & pUpdVal.GROUPCD & "',"
            strSQL = strSQL & "'" & pUpdVal.DISPORDER & "',"
            strSQL = strSQL & "'" & pUpdVal.PRICEDISP & "',"
            strSQL = strSQL & "'" & pUpdVal.GROUPKBN & "',"
            strSQL = strSQL & "'" & pUpdVal.ENABLED & "',"
            strSQL = strSQL & "'" & pUpdVal.UPDID & "',"
            strSQL = strSQL & "'" & pUpdVal.UPDYMD & "')"
        Else
            strSQL = strSQL & "DELETE FROM TPM060"
            strSQL = strSQL & "      WHERE TPM060.MENUID    = '" & pUpdKey.MENUID & "'"
            strSQL = strSQL & "        AND TPM060.MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
            strSQL = strSQL & "        AND TPM060.GROUPCD   = '" & pUpdKey.GROUPCD & "'"

            '--- (2006.02.01) ���j���[�摜�ǉ� ----------------------------------------------------
            ' �W���������������ꂽ��A���j���[�摜�̂�������������
            strSQL2 = ""
            strSQL2 = strSQL2 & "SELECT * FROM TPM150"
            strSQL2 = strSQL2 & " WHERE MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
            strSQL2 = strSQL2 & "   AND GROUPCD   = '" & pUpdKey.GROUPCD & "'"
            If Not GF_GetData(strSQL2, objData) Then
                Exit Function
            End If

            If objData.Tables("com").Rows.Count > 0 Then
                strSQL2 = ""
                strSQL2 = strSQL2 & "UPDATE TPM150"
                strSQL2 = strSQL2 & "   SET GROUPCD = 'J000'"
                strSQL2 = strSQL2 & " WHERE MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
                strSQL2 = strSQL2 & "   AND GROUPCD   = '" & pUpdKey.GROUPCD & "'"
                If Not GF_UpdData(strSQL2) Then
                    Exit Function
                End If
            End If

            '--------------------------------------------------------------------------------------
        End If
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If
        L_EditFlg = True

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM060_3 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FTPM060(���j���[�O���[�v�}�X�^)�X�V���� - (�P)
    ' �@�@�\�T�v�F���j���[�O���[�v�̎g�p��(ENABLED����)�ɂ��āA�X�V���s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM060_4(ByVal pUpdVal As typTPM060, ByVal pUpdKey As typTPM060) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM060_4 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM060"
        strSQL = strSQL & "   SET TPM060.MENUSTYLE = '" & pUpdVal.MENUSTYLE & "',"
        strSQL = strSQL & "       TPM060.GROUPKBN  = '" & pUpdVal.GROUPKBN & "',"
        '--- (2006.02.10) ��z���j���[ -----------------------------------------------------------
        'strSQL = strSQL & "       TPM060.PRICETYPE = '" & IIf(chk_Teigaku.Checked = True, "1", "0") & "',"
        '-----------------------------------------------------------------------------------------
        strSQL = strSQL & "       TPM060.UPDID = '" & pUpdVal.UPDID & "',"
        strSQL = strSQL & "       TPM060.UPDYMD = '" & pUpdVal.UPDYMD & "'"
        strSQL = strSQL & " WHERE TPM060.MENUID = '" & pUpdKey.MENUID & "'"
        strSQL = strSQL & "   AND TPM060.MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If
        L_EditFlg = True

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM060_4 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FTPM060(���j���[�O���[�v�}�X�^)�X�V���� - (�T)
    ' �@�@�\�T�v�F���j���[�O���[�v�̎g�p��(ENABLED����)�ɂ��āA�X�V���s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM060_5(ByVal pUpdVal As typTPM060, ByVal pUpdKey As typTPM060) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM060_5 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM060"
        strSQL = strSQL & "   SET TPM060.DISPORDER = '" & pUpdVal.DISPORDER & "',"
        strSQL = strSQL & "       TPM060.UPDID     = '" & pUpdVal.UPDID & "',"
        strSQL = strSQL & "       TPM060.UPDYMD    = '" & pUpdVal.UPDYMD & "'"
        strSQL = strSQL & " WHERE TPM060.MENUID    = '" & pUpdKey.MENUID & "'"
        strSQL = strSQL & "   AND TPM060.MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
        strSQL = strSQL & "   AND TPM060.GROUPCD   = '" & pUpdKey.GROUPCD & "'"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If
        L_EditFlg = True

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM060_5 = True

    End Function

    Private Function LF_UpdTPM010(ByVal pMenuID As String, ByVal pMenuGrpID As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM010 = False

        '------------------------------
        ' ���i�}�X�^�X�V
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM010"
        strSQL = strSQL & "   SET TPM010.GENERATEFLG = '" & GC_TRUE & "',"
        strSQL = strSQL & "       TPM010.UPDID       = '" & GC_UPDID & "',"
        strSQL = strSQL & "       TPM010.UPDYMD      = getdate()"
        strSQL = strSQL & " WHERE TPM010.GOODSCD IN (SELECT TPM020.GOODSCD"
        strSQL = strSQL & "                            FROM TPM020, TPM060"
        strSQL = strSQL & "                           WHERE TPM020.GROUPCD   = TPM060.GROUPCD"
        strSQL = strSQL & "                             AND TPM020.GOODSCD  <> '0000'"
        strSQL = strSQL & "                             AND TPM060.MENUID    = '" & Trim$(pMenuID) & "'"
        strSQL = strSQL & "                             AND TPM060.MENUGRPID = '" & Trim$(pMenuGrpID) & "'"
        strSQL = strSQL & "                             AND TPM060.GROUPCD  <> 'J000')"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM010 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���i�O���[�v�\��/��\���`�F�b�N�ύX������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub cbo_Pat_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Price.CheckedChanged, chk_ShowGenr.CheckedChanged, cbo_Style.SelectionChangeCommitted, cbo_Pat.SelectionChangeCommitted

        If L_ProcFlg2 Then Exit Sub
        If IsNothing(trv_Menu.SelectedNode) Then Exit Sub
        If IsNothing(trv_Menu.SelectedNode.Parent) Then Exit Sub

        Try
            Dim strPat As String
            Dim strStyle As String

            strPat = GF_CboGetCode(cbo_Pat, cbo_Pat.SelectedIndex)
            strStyle = GF_CboGetCode(cbo_Style, cbo_Style.SelectedIndex)

            If strPat = LC_PAT_GENR Then
                chk_Price.Enabled = True
                chk_ShowGenr.Enabled = True
                If chk_Price.Checked = True Then
                    chk_ShowGenr.Enabled = True
                Else
                    chk_ShowGenr.Checked = False
                    chk_ShowGenr.Enabled = True
                End If
            Else
                chk_Price.Enabled = False
                chk_Price.Checked = False
                chk_ShowGenr.Enabled = False
                chk_ShowGenr.Checked = False
            End If

            Call LS_UpdChkStatus()

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("cbo_Pat_SelectedIndexChanged")
    End Sub

    Private Sub LS_UpdChkStatus()
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim udtUpdVal As typTPM060 = Nothing
        Dim udtUpdKey As typTPM060 = Nothing

        Try
            Call LF_GetChkStatus(udtUpdVal)
            With udtUpdKey
                .MENUID = LF_GetMenuGrpCD(trv_Menu.SelectedNode.Parent)
                .MENUGRPID = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
            End With
        Catch
            GoTo SYSTEM_ERROR
        End Try
        If Not LF_UpdTPM060_4(udtUpdVal, udtUpdKey) Then
            GoTo SYSTEM_ERROR
        End If

        ' �摜�����t���O�̍X�V���s��(2004.07.14)
        If Not LF_UpdTPM010(udtUpdKey.MENUID, udtUpdKey.MENUGRPID) Then
            GoTo SYSTEM_ERROR
        End If

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_UpdChkStatus")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�`�F�b�N��Ԋm�F
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetChkStatus(ByRef pUpdVal As typTPM060) As Boolean

        Dim strPat As String
        Dim strStyle As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetChkStatus = False

        strPat = GF_CboGetCode(cbo_Pat, cbo_Pat.SelectedIndex)
        strStyle = GF_CboGetCode(cbo_Style, cbo_Style.SelectedIndex)

        Try
            '------------------------------
            ' �I����Ԋm�F
            '------------------------------
            With pUpdVal
                Select Case strPat
                    Case LC_PAT_GENR
                        Select Case strStyle
                            Case LC_STYLE_LIST
                                .MENUSTYLE = GC_MSTYLE_LISTSTR
                            Case LC_STYLE_PIC12
                                .MENUSTYLE = GC_MSTYLE_LISTPIC
                            Case LC_STYLE_PIC4
                                .MENUSTYLE = GC_MSTYLE_LISTPIC4
                        End Select
                        If chk_Price.Checked = False And chk_ShowGenr.Checked = False Then
                            .GROUPKBN = GC_ORDER_GROUP
                        End If
                        If chk_Price.Checked = True And chk_ShowGenr.Checked = False Then
                            .GROUPKBN = GC_ORDER_PRICE
                        End If
                        If chk_Price.Checked = True And chk_ShowGenr.Checked = True Then
                            .GROUPKBN = GC_ORDER_PRICE2
                        End If


                    Case LC_PAT_NETA
                        Select Case strStyle
                            Case LC_STYLE_LIST
                                .MENUSTYLE = GC_MSTYLE_NETASTR
                            Case LC_STYLE_PIC12
                                .MENUSTYLE = GC_MSTYLE_NETAPIC
                            Case LC_STYLE_PIC4
                                .MENUSTYLE = GC_MSTYLE_NETACASE
                        End Select
                        .GROUPKBN = GC_ORDER_CASE

                    Case LC_PAT_DIRC
                        Select Case strStyle
                            Case LC_STYLE_LIST
                                .MENUSTYLE = GC_MSTYLE_NOLIST
                            Case LC_STYLE_PIC12
                                .MENUSTYLE = GC_MSTYLE_NOLISTSTR
                            Case LC_STYLE_PIC4
                                .MENUSTYLE = GC_MSTYLE_NOLISTPIC4
                        End Select
                        .GROUPKBN = GC_ORDER_NONE

                        '--- (2006.01.31) ���j���[�摜�ǉ� ------------------------
                    Case 3
                        Select Case strStyle
                            Case LC_STYLE_LIST
                                .MENUSTYLE = GC_MSTYLE_PICTJ
                            Case LC_STYLE_PIC12
                                .MENUSTYLE = GC_MSTYLE_PIC12
                            Case LC_STYLE_PIC4
                                .MENUSTYLE = GC_MSTYLE_PIC4
                        End Select
                        .GROUPKBN = GC_ORDER_GROUP

                End Select

                .UPDID = GC_UPDID
                .UPDYMD = Now
            End With
        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetChkStatus = True

    End Function

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        If LF_TP1040Save(True) = CNL1920.FuncResult.UnusualEnd Then
            Exit Sub
        End If
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Call LS_TP1040Term()
    End Sub

    Private Sub btn_MenuPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MenuPic.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As New CNL1710()
        Dim i As Integer

        '------------------------------
        ' ���j���[�摜�쐬��ʕ\��
        '------------------------------
        i = cbo_Pat.SelectedIndex
        objForm.G_Code = L_MenuGrpID
        objForm.G_Menu = L_MenuID
        Me.Enabled = False
        If objForm.ShowDialog = DialogResult.Yes Then
            L_EditFlg = True
        End If
        Me.Enabled = True

        LF_SetCbo_Pat(L_MenuID, L_MenuGrpID, CStr(i))

    End Sub

    Private Function LF_SetCbo_Pat(ByVal pMenuID As String, ByVal pMenuGrpID As String, Optional ByVal pstrCode As String = "0") As Object

        '--- ���j���[�摜�����݂��邩�`�F�b�N -----------------------------

        Dim strSQL As String
        Dim objData As New DataSet()

        LF_SetCbo_Pat = Nothing

        strSQL = ""
        strSQL = strSQL & "SELECT * FROM TPM150"
        strSQL = strSQL & " WHERE MENUID = '" & pMenuID & "'"
        strSQL = strSQL & "   AND MENUGRPID = '" & pMenuGrpID & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        cbo_Pat.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_Pat.Items.Clear()
        Call GS_CboItemSet(cbo_Pat, "���i�W��������\��", LC_PAT_GENR)
        Call GS_CboItemSet(cbo_Pat, "�l�^�P�[�X��\��", LC_PAT_NETA)
        Call GS_CboItemSet(cbo_Pat, "���i�ꗗ�𒼐ڕ\��", LC_PAT_DIRC)
        If objData.Tables("com").Rows.Count > 0 Then
            Call GS_CboItemSet(cbo_Pat, "���j���[�摜��\��", "3")
        End If
        Call GS_CboChgSel(cbo_Pat, Trim$(pstrCode))


    End Function

    Private Function LF_GetPriceType(ByVal pMenuID As String, ByVal pMenuGrpID As String) As String
        '--- (2006.02.10) ��z���j���[ ---------------------------------

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetPriceType = "0"

        strSQL = ""
        strSQL = strSQL & "SELECT PRICETYPE"
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " WHERE MENUID = '" & pMenuID & "'"
        strSQL = strSQL & "   AND MENUGRPID = '" & pMenuGrpID & "'"
        strSQL = strSQL & "   AND GROUPCD = 'J000'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count > 0 Then
            If Not GF_GetRows(objData, 0, objRow) Then
                Exit Function
            End If

            LF_GetPriceType = objRow("PRICETYPE")

        End If

    End Function

    'Private Sub chk_Teigaku_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Call LS_UpdChkStatus()

    '    If chk_Teigaku.Checked = True Then
    '        txt_Price.Text = "0�~"
    '        txt_Price.Enabled = True
    '    Else
    '        txt_Price.Text = ""
    '        txt_Price.Enabled = False
    '    End If

    'End Sub

    'Private Sub txt_Price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    ' ���l�݂̂U���܂œ��͉\�Ƃ��鐧�������

    '    '------------------------------
    '    ' �����ϐ���`
    '    '------------------------------
    '    Dim lngST As Long

    '    If txt_Price.Modified = False Then Exit Sub
    '    lngST = txt_Price.SelectionStart
    '    If lngST >= 0 Then txt_Price.SelectionStart = lngST

    '    '------------------------------
    '    ' ���͒�����
    '    '------------------------------
    '    If GF_LenB(txt_Price.Text) > 6 Then
    '        txt_Price.Text = GF_MidB(txt_Price.Text, 1, 6)
    '        txt_Price.SelectionStart = GF_LenB(txt_Price.Text)
    '        'Exit Sub
    '    End If

    '    If Len(Trim$(txt_Price.Text)) = 0 Then
    '        txt_Price.Text = "0"
    '    End If

    '    If IsNumeric(Trim$(txt_Price.Text)) = False Then
    '        txt_Price.Text = "0"
    '    End If

    'End Sub

    'Private Sub txt_Price_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    ' �J���}�y�сA"�~"�����𒷂��O�̕������Replace����
    '    txt_Price.Text = Replace(txt_Price.Text, ",", "")
    '    txt_Price.Text = Replace(txt_Price.Text, "�~", "")

    'End Sub

    'Private Sub txt_Price_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim strSQL As String

    '    If IsNumeric(Trim$(txt_Price.Text)) = False Then
    '        MsgBox("���z�͐����݂̂���͂��Ă�������", MsgBoxStyle.OKOnly)
    '        Exit Sub
    '    End If

    '    strSQL = ""
    '    strSQL = strSQL & "UPDATE TPM010"
    '    strSQL = strSQL & "   SET PRICE = " & Trim$(txt_Price.Text)
    '    strSQL = strSQL & " WHERE GOODSCD = '" & LF_GetGoodsCD() & "'"

    '    If Not GF_UpdData(strSQL) Then
    '        Exit Sub
    '    End If

    '    ' �J���}�ҏW�{"�~"�����̕t���ҏW���s��
    '    txt_Price.Text = Format$(CLng(Trim$(txt_Price.Text)), "###,##0") & "�~"

    '    L_EditFlg = True

    'End Sub

    'Private Sub txt_Price_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Len(txt_Price.Text) >= 6 Then
    '        e.Handled = True
    '    End If
    'End Sub

    Private Function LF_GetGoodsCD() As String

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim strGOODS() As String

        LF_GetGoodsCD = ""

        strSQL = ""
        strSQL = strSQL & "SELECT APVALUE"
        strSQL = strSQL & "  FROM TPM090"
        strSQL = strSQL & " WHERE APKEY LIKE 'GOODS_MENU%'"
        strSQL = strSQL & "   AND APVALUE LIKE '%/" & L_MenuID & "%'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count <= 0 Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, objRow) Then
            Exit Function
        End If

        strGOODS = Split(Trim$(objRow("APVALUE")), "/")
        LF_GetGoodsCD = strGOODS(0)

    End Function

    Private Function LF_GetPrice(ByVal pCode As String) As Integer

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetPrice = 0

        strSQL = ""
        strSQL = strSQL & "SELECT PRICE"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " WHERE GOODSCD = '" & pCode & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count <= 0 Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, objRow) Then
            Exit Function
        End If

        LF_GetPrice = objRow("PRICE")

    End Function

End Class
