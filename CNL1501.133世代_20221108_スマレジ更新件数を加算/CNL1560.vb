' --------------------------------------------------------------------------------
' �@�@�@�@�\�FCrossNavi - ���m�点�쐬���
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------
Public Class CNL1560
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
    Friend WithEvents btn_Fol As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents grd_ImgList As System.Windows.Forms.DataGrid
    Friend WithEvents txt_ImgPath As System.Windows.Forms.TextBox
    Friend WithEvents grd_AdvList As System.Windows.Forms.DataGrid
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents lst_AdvSel As System.Windows.Forms.ListBox
    Friend WithEvents txt_AdvNm As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txt_GoodsCD As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_Menu As System.Windows.Forms.Label
    Friend WithEvents btn_Goods As System.Windows.Forms.Button
    Friend WithEvents chk_Order As System.Windows.Forms.CheckBox
    Friend WithEvents pic_EditArea As System.Windows.Forms.PictureBox
    Friend WithEvents txt_WriteMsg As System.Windows.Forms.TextBox
    Friend WithEvents chk_Shadow As System.Windows.Forms.CheckBox
    Public WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_AddKo As System.Windows.Forms.Button
    Friend WithEvents btn_DelKo As System.Windows.Forms.Button
    Friend WithEvents btn_Dwn As System.Windows.Forms.Button
    Friend WithEvents btn_Up As System.Windows.Forms.Button
    Friend WithEvents btn_Del As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents pic_ViewArea As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grd_AdvList2 As System.Windows.Forms.DataGrid
    Friend WithEvents btn_Prev As System.Windows.Forms.Button
    Friend WithEvents btn_Color As System.Windows.Forms.Button
    Friend WithEvents btn_Font As System.Windows.Forms.Button
    Friend WithEvents btn_Img_Edt As System.Windows.Forms.Button
    Friend WithEvents chk_Draw As System.Windows.Forms.CheckBox
    Friend WithEvents btn_ClrGoods As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CNL1560))
        Me.stb_Msg = New System.Windows.Forms.StatusBar
        Me.grd_ImgList = New System.Windows.Forms.DataGrid
        Me.grd_AdvList = New System.Windows.Forms.DataGrid
        Me.btn_Fol = New System.Windows.Forms.Button
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.txt_ImgPath = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.lst_AdvSel = New System.Windows.Forms.ListBox
        Me.txt_AdvNm = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.pic_ViewArea = New System.Windows.Forms.PictureBox
        Me.btn_Del = New System.Windows.Forms.Button
        Me.btn_Add = New System.Windows.Forms.Button
        Me.btn_Dwn = New System.Windows.Forms.Button
        Me.btn_Up = New System.Windows.Forms.Button
        Me.btn_DelKo = New System.Windows.Forms.Button
        Me.btn_AddKo = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.chk_Draw = New System.Windows.Forms.CheckBox
        Me.btn_Img_Edt = New System.Windows.Forms.Button
        Me.btn_Prev = New System.Windows.Forms.Button
        Me.btn_Color = New System.Windows.Forms.Button
        Me.btn_Font = New System.Windows.Forms.Button
        Me.grd_AdvList2 = New System.Windows.Forms.DataGrid
        Me.txt_GoodsCD = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbl_Menu = New System.Windows.Forms.Label
        Me.btn_Goods = New System.Windows.Forms.Button
        Me.chk_Order = New System.Windows.Forms.CheckBox
        Me.pic_EditArea = New System.Windows.Forms.PictureBox
        Me.txt_WriteMsg = New System.Windows.Forms.TextBox
        Me.chk_Shadow = New System.Windows.Forms.CheckBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_ClrGoods = New System.Windows.Forms.Button
        CType(Me.grd_ImgList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_AdvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pic_ViewArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.grd_AdvList2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_EditArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 665)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(1016, 24)
        Me.stb_Msg.TabIndex = 232
        Me.stb_Msg.Text = "StatusBar1"
        '
        'grd_ImgList
        '
        Me.grd_ImgList.CaptionFont = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_ImgList.CaptionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grd_ImgList.CaptionText = "���ҏW���摜"
        Me.grd_ImgList.CaptionVisible = False
        Me.grd_ImgList.DataMember = ""
        Me.grd_ImgList.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_ImgList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_ImgList.Location = New System.Drawing.Point(612, 122)
        Me.grd_ImgList.Name = "grd_ImgList"
        Me.grd_ImgList.Size = New System.Drawing.Size(174, 488)
        Me.grd_ImgList.TabIndex = 0
        '
        'grd_AdvList
        '
        Me.grd_AdvList.CaptionFont = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_AdvList.CaptionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grd_AdvList.CaptionText = "���L���摜�ꗗ"
        Me.grd_AdvList.CaptionVisible = False
        Me.grd_AdvList.DataMember = ""
        Me.grd_AdvList.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_AdvList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_AdvList.Location = New System.Drawing.Point(321, 122)
        Me.grd_AdvList.Name = "grd_AdvList"
        Me.grd_AdvList.Size = New System.Drawing.Size(174, 488)
        Me.grd_AdvList.TabIndex = 13
        '
        'btn_Fol
        '
        Me.btn_Fol.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Fol.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Fol.Location = New System.Drawing.Point(612, 92)
        Me.btn_Fol.Name = "btn_Fol"
        Me.btn_Fol.Size = New System.Drawing.Size(174, 24)
        Me.btn_Fol.TabIndex = 1
        Me.btn_Fol.Text = "�摜�t�H���_�I��"
        Me.btn_Fol.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "")
        Me.ImageList1.Images.SetKeyName(12, "")
        Me.ImageList1.Images.SetKeyName(13, "")
        Me.ImageList1.Images.SetKeyName(14, "")
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        Me.ImageList2.Images.SetKeyName(3, "")
        Me.ImageList2.Images.SetKeyName(4, "")
        Me.ImageList2.Images.SetKeyName(5, "")
        Me.ImageList2.Images.SetKeyName(6, "")
        '
        'txt_ImgPath
        '
        Me.txt_ImgPath.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_ImgPath.Location = New System.Drawing.Point(516, 591)
        Me.txt_ImgPath.Name = "txt_ImgPath"
        Me.txt_ImgPath.Size = New System.Drawing.Size(64, 19)
        Me.txt_ImgPath.TabIndex = 272
        Me.txt_ImgPath.Text = "txt_ImgPath"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.Location = New System.Drawing.Point(12, 137)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 17)
        Me.Label17.TabIndex = 274
        Me.Label17.Text = "���m�点��"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem7})
        Me.MenuItem1.Text = "���m�点�쐬"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.Text = "�I��(&E)"
        '
        'lst_AdvSel
        '
        Me.lst_AdvSel.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lst_AdvSel.ItemHeight = 15
        Me.lst_AdvSel.Items.AddRange(New Object() {"�P�s��", "�Q�s��", "�R�s��", "�S�s��", "�T�s��"})
        Me.lst_AdvSel.Location = New System.Drawing.Point(15, 30)
        Me.lst_AdvSel.Name = "lst_AdvSel"
        Me.lst_AdvSel.Size = New System.Drawing.Size(270, 79)
        Me.lst_AdvSel.TabIndex = 10
        '
        'txt_AdvNm
        '
        Me.txt_AdvNm.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_AdvNm.Location = New System.Drawing.Point(15, 157)
        Me.txt_AdvNm.Name = "txt_AdvNm"
        Me.txt_AdvNm.Size = New System.Drawing.Size(270, 22)
        Me.txt_AdvNm.TabIndex = 11
        Me.txt_AdvNm.Text = "TextBox1"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 285
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(198, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(813, 652)
        Me.TabControl1.TabIndex = 287
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.btn_Add)
        Me.TabPage1.Controls.Add(Me.btn_Dwn)
        Me.TabPage1.Controls.Add(Me.btn_Up)
        Me.TabPage1.Controls.Add(Me.btn_DelKo)
        Me.TabPage1.Controls.Add(Me.btn_AddKo)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btn_Fol)
        Me.TabPage1.Controls.Add(Me.grd_AdvList)
        Me.TabPage1.Controls.Add(Me.grd_ImgList)
        Me.TabPage1.Controls.Add(Me.txt_ImgPath)
        Me.TabPage1.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(805, 622)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "���m�点�o�^"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.pic_ViewArea)
        Me.GroupBox2.Controls.Add(Me.btn_Del)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 324)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 286)
        Me.GroupBox2.TabIndex = 285
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "�I�����Ă���摜"
        '
        'pic_ViewArea
        '
        Me.pic_ViewArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_ViewArea.Location = New System.Drawing.Point(15, 53)
        Me.pic_ViewArea.Name = "pic_ViewArea"
        Me.pic_ViewArea.Size = New System.Drawing.Size(268, 201)
        Me.pic_ViewArea.TabIndex = 284
        Me.pic_ViewArea.TabStop = False
        '
        'btn_Del
        '
        Me.btn_Del.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Del.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Del.Location = New System.Drawing.Point(211, 21)
        Me.btn_Del.Name = "btn_Del"
        Me.btn_Del.Size = New System.Drawing.Size(72, 24)
        Me.btn_Del.TabIndex = 283
        Me.btn_Del.Text = "�폜"
        Me.btn_Del.UseVisualStyleBackColor = False
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Add.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Add.Location = New System.Drawing.Point(506, 329)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(97, 36)
        Me.btn_Add.TabIndex = 281
        Me.btn_Add.Text = "�ǉ�"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'btn_Dwn
        '
        Me.btn_Dwn.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Dwn.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Dwn.Location = New System.Drawing.Point(423, 92)
        Me.btn_Dwn.Name = "btn_Dwn"
        Me.btn_Dwn.Size = New System.Drawing.Size(72, 24)
        Me.btn_Dwn.TabIndex = 280
        Me.btn_Dwn.Text = "���ֈړ�"
        Me.btn_Dwn.UseVisualStyleBackColor = False
        '
        'btn_Up
        '
        Me.btn_Up.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Up.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Up.Location = New System.Drawing.Point(321, 92)
        Me.btn_Up.Name = "btn_Up"
        Me.btn_Up.Size = New System.Drawing.Size(82, 24)
        Me.btn_Up.TabIndex = 279
        Me.btn_Up.Text = "��ֈړ�"
        Me.btn_Up.UseVisualStyleBackColor = False
        '
        'btn_DelKo
        '
        Me.btn_DelKo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_DelKo.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_DelKo.Location = New System.Drawing.Point(215, 10)
        Me.btn_DelKo.Name = "btn_DelKo"
        Me.btn_DelKo.Size = New System.Drawing.Size(180, 50)
        Me.btn_DelKo.TabIndex = 278
        Me.btn_DelKo.Text = "�I�𒆂̂��m�点�폜"
        Me.btn_DelKo.UseVisualStyleBackColor = False
        '
        'btn_AddKo
        '
        Me.btn_AddKo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_AddKo.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_AddKo.Location = New System.Drawing.Point(20, 10)
        Me.btn_AddKo.Name = "btn_AddKo"
        Me.btn_AddKo.Size = New System.Drawing.Size(180, 50)
        Me.btn_AddKo.TabIndex = 277
        Me.btn_AddKo.Text = "���m�点�ǉ�"
        Me.btn_AddKo.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(5, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(794, 1)
        Me.Label11.TabIndex = 276
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txt_AdvNm)
        Me.GroupBox1.Controls.Add(Me.lst_AdvSel)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 197)
        Me.GroupBox1.TabIndex = 275
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "���m�点�̎��"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.btn_ClrGoods)
        Me.TabPage2.Controls.Add(Me.chk_Draw)
        Me.TabPage2.Controls.Add(Me.btn_Img_Edt)
        Me.TabPage2.Controls.Add(Me.btn_Prev)
        Me.TabPage2.Controls.Add(Me.btn_Color)
        Me.TabPage2.Controls.Add(Me.btn_Font)
        Me.TabPage2.Controls.Add(Me.grd_AdvList2)
        Me.TabPage2.Controls.Add(Me.txt_GoodsCD)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.lbl_Menu)
        Me.TabPage2.Controls.Add(Me.btn_Goods)
        Me.TabPage2.Controls.Add(Me.chk_Order)
        Me.TabPage2.Controls.Add(Me.pic_EditArea)
        Me.TabPage2.Controls.Add(Me.txt_WriteMsg)
        Me.TabPage2.Controls.Add(Me.chk_Shadow)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(805, 622)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "���m�点�ҏW"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chk_Draw
        '
        Me.chk_Draw.Appearance = System.Windows.Forms.Appearance.Button
        Me.chk_Draw.AutoSize = True
        Me.chk_Draw.BackColor = System.Drawing.SystemColors.Control
        Me.chk_Draw.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_Draw.Location = New System.Drawing.Point(503, 70)
        Me.chk_Draw.Name = "chk_Draw"
        Me.chk_Draw.Size = New System.Drawing.Size(134, 25)
        Me.chk_Draw.TabIndex = 304
        Me.chk_Draw.Text = "      �L������      "
        Me.chk_Draw.UseVisualStyleBackColor = False
        '
        'btn_Img_Edt
        '
        Me.btn_Img_Edt.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Img_Edt.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Img_Edt.Location = New System.Drawing.Point(648, 10)
        Me.btn_Img_Edt.Name = "btn_Img_Edt"
        Me.btn_Img_Edt.Size = New System.Drawing.Size(135, 50)
        Me.btn_Img_Edt.TabIndex = 303
        Me.btn_Img_Edt.Text = "�摜�X�V"
        Me.btn_Img_Edt.UseVisualStyleBackColor = False
        '
        'btn_Prev
        '
        Me.btn_Prev.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Prev.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Prev.Location = New System.Drawing.Point(648, 70)
        Me.btn_Prev.Name = "btn_Prev"
        Me.btn_Prev.Size = New System.Drawing.Size(135, 25)
        Me.btn_Prev.TabIndex = 302
        Me.btn_Prev.Text = "�P�O�ɖ߂�"
        Me.btn_Prev.UseVisualStyleBackColor = False
        '
        'btn_Color
        '
        Me.btn_Color.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Color.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Color.Location = New System.Drawing.Point(358, 70)
        Me.btn_Color.Name = "btn_Color"
        Me.btn_Color.Size = New System.Drawing.Size(135, 25)
        Me.btn_Color.TabIndex = 300
        Me.btn_Color.Text = "�����F�ݒ�"
        Me.btn_Color.UseVisualStyleBackColor = False
        '
        'btn_Font
        '
        Me.btn_Font.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Font.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Font.Location = New System.Drawing.Point(215, 70)
        Me.btn_Font.Name = "btn_Font"
        Me.btn_Font.Size = New System.Drawing.Size(135, 25)
        Me.btn_Font.TabIndex = 299
        Me.btn_Font.Text = "�t�H���g�ݒ�"
        Me.btn_Font.UseVisualStyleBackColor = False
        '
        'grd_AdvList2
        '
        Me.grd_AdvList2.CaptionFont = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_AdvList2.CaptionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grd_AdvList2.CaptionText = "���L���摜�ꗗ"
        Me.grd_AdvList2.CaptionVisible = False
        Me.grd_AdvList2.DataMember = ""
        Me.grd_AdvList2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_AdvList2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_AdvList2.Location = New System.Drawing.Point(21, 42)
        Me.grd_AdvList2.Name = "grd_AdvList2"
        Me.grd_AdvList2.Size = New System.Drawing.Size(174, 488)
        Me.grd_AdvList2.TabIndex = 298
        '
        'txt_GoodsCD
        '
        Me.txt_GoodsCD.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_GoodsCD.Location = New System.Drawing.Point(559, 585)
        Me.txt_GoodsCD.Name = "txt_GoodsCD"
        Me.txt_GoodsCD.Size = New System.Drawing.Size(24, 22)
        Me.txt_GoodsCD.TabIndex = 297
        Me.txt_GoodsCD.Text = "TextBox1"
        Me.txt_GoodsCD.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(13, 558)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(480, 16)
        Me.Label6.TabIndex = 296
        Me.Label6.Text = "�� ���i��ʂɑJ�ڂ���ꍇ�́A�`�F�b�N�����A�Ώۏ��i��I�����Ă�������"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lbl_Menu
        '
        Me.lbl_Menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Menu.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_Menu.Location = New System.Drawing.Point(47, 587)
        Me.lbl_Menu.Name = "lbl_Menu"
        Me.lbl_Menu.Size = New System.Drawing.Size(312, 24)
        Me.lbl_Menu.TabIndex = 295
        Me.lbl_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_Goods
        '
        Me.btn_Goods.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Goods.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Goods.Location = New System.Drawing.Point(374, 586)
        Me.btn_Goods.Name = "btn_Goods"
        Me.btn_Goods.Size = New System.Drawing.Size(75, 25)
        Me.btn_Goods.TabIndex = 291
        Me.btn_Goods.Text = "�I��"
        Me.btn_Goods.UseVisualStyleBackColor = False
        '
        'chk_Order
        '
        Me.chk_Order.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_Order.Image = CType(resources.GetObject("chk_Order.Image"), System.Drawing.Image)
        Me.chk_Order.Location = New System.Drawing.Point(25, 587)
        Me.chk_Order.Name = "chk_Order"
        Me.chk_Order.Size = New System.Drawing.Size(16, 24)
        Me.chk_Order.TabIndex = 290
        '
        'pic_EditArea
        '
        Me.pic_EditArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_EditArea.Location = New System.Drawing.Point(215, 104)
        Me.pic_EditArea.Name = "pic_EditArea"
        Me.pic_EditArea.Size = New System.Drawing.Size(568, 426)
        Me.pic_EditArea.TabIndex = 292
        Me.pic_EditArea.TabStop = False
        '
        'txt_WriteMsg
        '
        Me.txt_WriteMsg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_WriteMsg.Location = New System.Drawing.Point(227, 38)
        Me.txt_WriteMsg.Name = "txt_WriteMsg"
        Me.txt_WriteMsg.Size = New System.Drawing.Size(410, 22)
        Me.txt_WriteMsg.TabIndex = 288
        Me.txt_WriteMsg.Text = "TextBox1"
        '
        'chk_Shadow
        '
        Me.chk_Shadow.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_Shadow.Image = CType(resources.GetObject("chk_Shadow.Image"), System.Drawing.Image)
        Me.chk_Shadow.Location = New System.Drawing.Point(503, 10)
        Me.chk_Shadow.Name = "chk_Shadow"
        Me.chk_Shadow.Size = New System.Drawing.Size(134, 28)
        Me.chk_Shadow.TabIndex = 287
        Me.chk_Shadow.Text = "�e�t���ŋL������"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label18.Location = New System.Drawing.Point(13, 542)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(779, 1)
        Me.Label18.TabIndex = 294
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(212, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 16)
        Me.Label1.TabIndex = 293
        Me.Label1.Text = "�� �摜�ɋL�����镶������͂��Ă�������"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btn_ClrGoods
        '
        Me.btn_ClrGoods.BackColor = System.Drawing.SystemColors.Control
        Me.btn_ClrGoods.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_ClrGoods.Location = New System.Drawing.Point(455, 587)
        Me.btn_ClrGoods.Name = "btn_ClrGoods"
        Me.btn_ClrGoods.Size = New System.Drawing.Size(75, 25)
        Me.btn_ClrGoods.TabIndex = 305
        Me.btn_ClrGoods.Text = "����"
        Me.btn_ClrGoods.UseVisualStyleBackColor = False
        '
        'CNL1560
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1016, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stb_Msg)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL1560"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JCV06"
        CType(Me.grd_ImgList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_AdvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pic_ViewArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.grd_AdvList2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_EditArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Structure typDrawStrImg
        Dim strWriteString As String
        Dim objFontStyle As Font
        Dim objDrawColor As System.Drawing.Brush
        Dim lngX As Long
        Dim lngY As Long
        Dim blnUndo As Boolean
    End Structure

    Private L_objBitmap As Bitmap
    Private L_objGraph As Graphics
    Private L_objColor As Color
    Private L_DrawFlg As Boolean
    Private L_objFont As Font
    Private L_objUndo() As typDrawStrImg
    Private L_lngDrawCnt As Long
    Private L_strSelFile As String
    'Private L_blnEditFlg As Boolean

    ' --------------------------------------------------------------------------------
    ' ���W���[�����񋓌^��`
    ' --------------------------------------------------------------------------------
    Private Enum TLBMODE
        INITMODE = 0
        ADDMODE = 1
        EDITMODE = 2
    End Enum

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���ǂݍ��ݎ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub CNL1560_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �t�H�[�����̐ݒ�
        '------------------------------
        Me.Text = " ���m�点�쐬 "

        '---------------------------------
        '����{�^����\����
        '---------------------------------
        Me.ControlBox = False

        Try
            '------------------------------
            ' �e���W���[�����ϐ������ݒ�
            '------------------------------
            L_objBitmap = New Bitmap(GC_ADVPIC_W, GC_ADVPIC_H, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
            L_objGraph = Graphics.FromImage(L_objBitmap)
            L_objColor = txt_WriteMsg.ForeColor
            L_DrawFlg = False
            L_objFont = New Font("�l�r �o�S�V�b�N", 22)
            L_lngDrawCnt = 0
            L_strSelFile = ""
            'L_blnEditFlg = False

            '------------------------------
            ' �t�H�[������������
            '------------------------------
            txt_ImgPath.Text = g_udtAppConfig.strImpPath                        ' �t�@�C���p�X
            txt_AdvNm.Clear()                                                   ' �L����
            txt_WriteMsg.Clear()                                                ' �摜�`�惁�b�Z�[�W

            chk_Shadow.Checked = True
            txt_ImgPath.Visible = False
            chk_Order.Checked = False                                           ' �L���摜����̃I�[�_�p - �g�p�ۃ`�F�b�N
            txt_GoodsCD.Text = ""                                               ' �L���摜����̃I�[�_�p - ���i�R�[�h
            lbl_Menu.Text = ""                                                  ' �L���摜����̃I�[�_�p - ���i����
            btn_Goods.Enabled = False                                           ' �L���摜����̃I�[�_�p - �I���{�^��
            btn_ClrGoods.Enabled = False                                        ' �L���摜����̃I�[�_�p - �����{�^��

            '------------------------------
            ' �L�����I���R���{����
            '------------------------------
            Call LS_SetAdvList()

            '------------------------------
            ' �X�e�[�^�X��񐶐�
            '------------------------------
            Call GS_StatusSetup(stb_Msg)

            '------------------------------
            ' �ǉ��E�폜�{�^���g�p�ېݒ�
            '------------------------------
            Call LS_SetButton(TLBMODE.INITMODE)

            '------------------------------
            ' �e�摜���X�g����
            '------------------------------
            Call LS_GridSetup_1()                                               ' �I���摜���X�g
            Call LS_GridSetup_2()                                               ' �L���摜���X�g

            '------------------------------
            ' �g�����U�N�V��������
            '------------------------------
            'If Not GF_BeginTrans() Then
            '    GoTo SYSTEM_ERROR
            'End If

            '------------------------------
            ' �L���摜�e�ʃ`�F�b�N
            '------------------------------
            If GF_AllAdvChk() = CNL1920.FuncResult.UnusualEnd Then
                GoTo SYSTEM_ERROR
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1560_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F��ʏI��������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub CNL1560_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        'If L_blnEditFlg Then
        '    Select Case MsgBox(GF_GetMsg("Q03"), MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question, g_udtAppConfig.strAppName)
        '        Case MsgBoxResult.Yes
        '            '------------------------------
        '            ' �L���摜�e�ʃ`�F�b�N
        '            '------------------------------
        '            Select Case GF_AllAdvChk()
        '                Case CNL1920.FuncResult.UnusualEnd
        '                    GoTo SYSTEM_ERROR
        '                Case CNL1920.FuncResult.CancelEnd
        '                    e.Cancel = True
        '                    Exit Sub
        '            End Select

        '            '------------------------------
        '            ' �������j���[�폜����
        '            '------------------------------
        '            Select Case LF_ChkAdvEnabled(True)
        '                Case CNL1920.FuncResult.UnusualEnd
        '                    GoTo SYSTEM_ERROR
        '                Case CNL1920.FuncResult.CancelEnd
        '                    e.Cancel = True
        '                    Exit Sub
        '            End Select

        '            If LF_ChkAdvEnabled(False) = CNL1920.FuncResult.UnusualEnd Then
        '                GoTo SYSTEM_ERROR
        '            End If

        '            '------------------------------
        '            ' �R�~�b�g����
        '            '------------------------------
        '            If Not GF_CommitTrans() Then
        '                GoTo SYSTEM_ERROR
        '            End If

        '        Case MsgBoxResult.No
        '            '------------------------------
        '            ' ���[���o�b�N����
        '            '------------------------------
        '            If Not GF_RollbackTrans() Then
        '                GoTo SYSTEM_ERROR
        '            End If

        '        Case MsgBoxResult.Cancel
        '            e.Cancel = True
        '            Exit Sub

        '        Case Else
        '            Exit Sub
        '    End Select
        'Else
        '    '------------------------------
        '    ' ���[���o�b�N����
        '    '------------------------------
        '    If Not GF_RollbackTrans() Then
        '        GoTo SYSTEM_ERROR
        '    End If
        'End If

        '------------------------------
        ' �������j���[�폜����
        '------------------------------
        If LF_ChkAdvEnabled() = CNL1920.FuncResult.UnusualEnd Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' ���g�p�摜�t�@�C���폜����
        '------------------------------
        If Not LF_DelUnuseFile() Then
            GoTo SYSTEM_ERROR
        End If

        L_objBitmap = Nothing
        L_objGraph = Nothing

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1560_Closing")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�������j���[�폜����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_ChkAdvEnabled() As FuncResult

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objData2 As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_ChkAdvEnabled = CNL1920.FuncResult.UnusualEnd

        '------------------------------
        ' �S���j���[�O���[�v�R�[�h�擾
        '------------------------------
        If Not LF_GetTPM080_1(objData) Then
            Exit Function
        End If

        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If

            '------------------------------
            ' �L���O���[�v���摜���擾
            '------------------------------
            strSQL = ""
            strSQL = strSQL & "SELECT ADVGRP_ID"
            strSQL = strSQL & "  FROM TPM080"
            strSQL = strSQL & " WHERE ADVGRP_ID = '" & Trim$(objRows("ADVGRP_ID")) & "'"
            strSQL = strSQL & "   AND ADV_ID    <> '000'"
            strSQL = strSQL & "   AND DISPORDER <> '000'"

            objData2 = New DataSet()

            If Not GF_GetData(strSQL, objData2) Then
                Exit Function
            End If

            If objData2.Tables("com").Rows.Count = 0 Then
                '------------------------------
                ' �������j���[���o��
                '------------------------------
                Select Case GF_Msg("", "���m�点�y " & Trim$(objRows("ADVGRP_NM")) & " �z�ɂ͂��m�点�摜���o�^�̂��߁A�����폜���܂�", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                    Case MsgBoxResult.Ok
                        '------------------------------
                        ' �������j���[���폜����
                        '------------------------------
                        If Not LF_UpdTPM080_5(Trim$(objRows("ADVGRP_ID"))) Then
                            LF_ChkAdvEnabled = CNL1920.FuncResult.UnusualEnd
                            Exit Function
                        End If

                    Case Else
                        LF_ChkAdvEnabled = CNL1920.FuncResult.CancelEnd
                        Exit Function
                End Select
            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_ChkAdvEnabled = CNL1920.FuncResult.NormalEnd

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L�����I�����X�g�{�b�N�X �ݒ菈��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetAdvList()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        lst_AdvSel.Items.Clear()
        txt_AdvNm.Text = ""

        '------------------------------
        ' �ݒ�f�[�^�擾
        '------------------------------
        If Not LF_GetTPM080_1(objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �f�[�^�l�ݒ�
        '------------------------------
        Try
            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    GoTo SYSTEM_ERROR
                End If

                Call GS_SetListBox(lst_AdvSel, Trim$(objRows("ADVGRP_NM")), Trim$(objRows("ADVGRP_ID")))
                lngCnt = lngCnt + 1
            End While

            '------------------------------
            ' �L�����I�����X�g�{�b�N�X �I������
            '------------------------------
            If lst_AdvSel.SelectedIndex = -1 Then
                If lst_AdvSel.Items.Count <> 0 Then
                    lst_AdvSel.SelectedIndex = 0
                End If
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetAdvList")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L�����I�����X�g�{�b�N�X �I��������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub lst_AdvSel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lst_AdvSel.SelectedIndexChanged

        If txt_AdvNm.Modified = True Then
            Exit Sub
        End If

        txt_AdvNm.Text = Trim$(GF_LstGetString(lst_AdvSel, lst_AdvSel.SelectedIndex))

        '------------------------------
        ' �ǉ��E�폜�{�^���g�p�ېݒ�
        '------------------------------
        Call LS_SetButton(TLBMODE.INITMODE)

        '------------------------------
        ' �L���摜���X�g����
        '------------------------------
        Call LS_GridSetup_2()

        '------------------------------
        ' �I���摜�̈�N���A
        '------------------------------
        L_objBitmap = New Bitmap(GC_ADVPIC_W, GC_ADVPIC_H, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
        L_objGraph = Graphics.FromImage(L_objBitmap)
        pic_ViewArea.Refresh()
        L_strSelFile = ""

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�I���摜�ꗗ�O���b�h �Z�b�g�A�b�v����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_GridSetup_1()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objTs As New DataGridTableStyle()                               ' �V����DataGridTableStyle�̍쐬
        Dim udtGridCol(2) As typGridColumn
        Dim lngCnt As Long
        Dim dtsData As New DataSet()
        Dim dtrRows As DataRow = Nothing
        Dim dtsList As DataSet
        Dim objTable As DataTable
        Dim strFile As String

        '------------------------------
        ' �e�[�u���X�^�C����`
        '------------------------------
        With objTs
            .MappingName = "IMAGELIST2"                                     ' �}�b�v�����w��
            .PreferredRowHeight = 114                                       ' �W���s�����w��
            .GridLineStyle = DataGridLineStyle.None                         ' �O���b�h���C�����\���ɐݒ�
            .RowHeadersVisible = False
        End With

        '------------------------------
        ' �e���ڑ�����`
        '------------------------------
        With udtGridCol(0)                                                  ' �w�I���摜�x����
            .intType = CNL1920.COLUMN_TYPE.IMAGE_NOEDIT_STYLE
            .strMapName = "PICTURE"
            .strHeadText = "�I���摜"
            .blnAllowNull = False
            .lngWidth = 152
            .objAlign = HorizontalAlignment.Center
        End With

        For lngCnt = 0 To UBound(udtGridCol) - 1                            ' �e���`���e�[�u���X�^�C���ɒǉ�
            Call GS_GridAddColumn(udtGridCol(lngCnt), objTs)
        Next
        objTs.AllowSorting = False                                          ' �񌩏o���N���b�N�ɂ��\�[�g���֎~
        objTs.RowHeadersVisible = False

        With grd_ImgList
            .TableStyles.Clear()
            .TableStyles.Add(objTs)                                         ' �e�[�u���X�^�C����DataGrid�ɒǉ�
            .ReadOnly = True                                                ' �ҏW�֎~
        End With

        '------------------------------
        ' �O���b�h����
        '------------------------------
        dtsList = New DataSet("ImgList")
        objTable = New DataTable("IMAGELIST2")
        For lngCnt = 0 To UBound(udtGridCol) - 1
            Call GS_GridAddTable(udtGridCol(lngCnt), objTable)
        Next

        '------------------------------
        ' �f�[�^�l�ݒ�
        '------------------------------
        Try
            lngCnt = 1
            If System.IO.Directory.Exists(txt_ImgPath.Text) Then
                For Each strFile In System.IO.Directory.GetFiles(txt_ImgPath.Text, "*.jpg")
                    dtrRows = objTable.NewRow
                    dtrRows(udtGridCol(0).strMapName) = strFile
                    objTable.Rows.Add(dtrRows)
                    lngCnt = lngCnt + 1
                Next
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        dtsList.Tables.Add(objTable)                                        ' �e�[�u����DataSet�ɒǉ�����
        grd_ImgList.SetDataBinding(dtsList, "IMAGELIST2")                   ' DataSet�ƃe�[�u����DataGrid�ɐڑ�����

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GridSetup_1")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���摜�ꗗ�O���b�h �Z�b�g�A�b�v����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_GridSetup_2()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objTs As New DataGridTableStyle()                               ' �V����DataGridTableStyle�̍쐬
        Dim udtGridCol(4) As typGridColumn
        Dim lngCnt As Long
        Dim objData As New DataSet()
        Dim dtsData As New DataSet()
        Dim dtrRows As DataRow = Nothing
        Dim dtrData As DataRow = Nothing
        Dim dtsList As DataSet
        Dim objTable As DataTable

        '------------------------------
        ' �L���I����� �ݒ菈��
        '------------------------------
        If lst_AdvSel.SelectedIndex = -1 Then
            If lst_AdvSel.Items.Count <> 0 Then
                lst_AdvSel.SelectedIndex = 0
            End If
        End If

        '------------------------------
        ' �\���f�[�^�擾����
        '------------------------------
        If Not LF_GetTPM080_2(objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �e�[�u���X�^�C����`
        '------------------------------
        With objTs
            .MappingName = "IMAGELIST3"                                     ' �}�b�v�����w��
            .PreferredRowHeight = 114                                       ' �W���s�����w��
            .GridLineStyle = DataGridLineStyle.None                         ' �O���b�h���C�����\���ɐݒ�
            .RowHeadersVisible = False
        End With

        '------------------------------
        ' �e���ڑ�����`
        '------------------------------
        With udtGridCol(0)                                                  ' �w�L���摜�x����
            .intType = CNL1920.COLUMN_TYPE.IMAGE_NOEDIT_STYLE
            .strMapName = "PICTURE"
            .strHeadText = "���m�点�摜"
            .blnAllowNull = False
            .lngWidth = 152
            .objAlign = HorizontalAlignment.Center
        End With

        With udtGridCol(1)                                                  ' �w�摜ID�x����
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "ADV_ID"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Center
            .blnReadOnly = True
        End With

        With udtGridCol(2)                                                  ' �w�\�����x����
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "DISPORDER"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Center
            .blnReadOnly = True
        End With

        For lngCnt = 0 To UBound(udtGridCol) - 1                            ' �e���`���e�[�u���X�^�C���ɒǉ�
            Call GS_GridAddColumn(udtGridCol(lngCnt), objTs)
        Next
        objTs.AllowSorting = False                                          ' �񌩏o���N���b�N�ɂ��\�[�g���֎~
        objTs.RowHeadersVisible = False

        With grd_AdvList
            .TableStyles.Clear()                                            ' ��U�A�S�ăN���A����
            .TableStyles.Add(objTs)                                         ' �e�[�u���X�^�C����DataGrid�ɒǉ�
            .ReadOnly = True                                                ' �ҏW�֎~
        End With

        '------------------------------
        ' �O���b�h����
        '------------------------------
        dtsList = New DataSet("ImgList2")
        objTable = New DataTable("IMAGELIST3")

        For lngCnt = 0 To UBound(udtGridCol) - 1
            Call GS_GridAddTable(udtGridCol(lngCnt), objTable)
        Next

        '------------------------------
        ' �f�[�^�l�ݒ�
        '------------------------------
        Try
            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, dtrData) Then
                    GoTo SYSTEM_ERROR
                End If

                dtrRows = objTable.NewRow
                dtrRows(udtGridCol(0).strMapName) = g_udtAppConfig.strAdvPath & "\" & Trim$(dtrData("FILENM"))
                dtrRows(udtGridCol(1).strMapName) = Trim$(dtrData("ADV_ID"))
                dtrRows(udtGridCol(2).strMapName) = Trim$(dtrData("DISPORDER"))
                objTable.Rows.Add(dtrRows)
                lngCnt = lngCnt + 1
            End While
        Catch
            GoTo SYSTEM_ERROR
        End Try

        dtsList.Tables.Add(objTable)                                        ' �e�[�u����DataSet�ɒǉ�����
        grd_AdvList.SetDataBinding(dtsList, "IMAGELIST3")                   ' DataSet�ƃe�[�u����DataGrid�ɐڑ�����

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GridSetup_2")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�摜�ҏW�p�L���摜�ꗗ�O���b�h �Z�b�g�A�b�v����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_GridSetup_3()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objTs As New DataGridTableStyle()                               ' �V����DataGridTableStyle�̍쐬
        Dim udtGridCol(4) As typGridColumn
        Dim lngCnt As Long
        Dim objData As New DataSet()
        Dim dtsData As New DataSet()
        Dim dtrRows As DataRow = Nothing
        Dim dtrData As DataRow = Nothing
        Dim dtsList As DataSet
        Dim objTable As DataTable

        '------------------------------
        ' �L���I����� �ݒ菈��
        '------------------------------
        If lst_AdvSel.SelectedIndex = -1 Then
            If lst_AdvSel.Items.Count <> 0 Then
                lst_AdvSel.SelectedIndex = 0
            End If
        End If

        '------------------------------
        ' �\���f�[�^�擾����
        '------------------------------
        If Not LF_GetTPM080_2(objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �e�[�u���X�^�C����`
        '------------------------------
        With objTs
            .MappingName = "IMAGELIST4"                                     ' �}�b�v�����w��
            .PreferredRowHeight = 114                                       ' �W���s�����w��
            .GridLineStyle = DataGridLineStyle.None                         ' �O���b�h���C�����\���ɐݒ�
            .RowHeadersVisible = False
        End With

        '------------------------------
        ' �e���ڑ�����`
        '------------------------------
        With udtGridCol(0)                                                  ' �w�L���摜�x����
            .intType = CNL1920.COLUMN_TYPE.IMAGE_NOEDIT_STYLE
            .strMapName = "PICTURE"
            .strHeadText = "���m�点�摜"
            .blnAllowNull = False
            .lngWidth = 152
            .objAlign = HorizontalAlignment.Center
        End With

        With udtGridCol(1)                                                  ' �w�摜ID�x����
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "ADV_ID"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Center
            .blnReadOnly = True
        End With

        With udtGridCol(2)                                                  ' �w�\�����x����
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "DISPORDER"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Center
            .blnReadOnly = True
        End With

        For lngCnt = 0 To UBound(udtGridCol) - 1                            ' �e���`���e�[�u���X�^�C���ɒǉ�
            Call GS_GridAddColumn(udtGridCol(lngCnt), objTs)
        Next
        objTs.AllowSorting = False                                          ' �񌩏o���N���b�N�ɂ��\�[�g���֎~
        objTs.RowHeadersVisible = False

        With grd_AdvList2
            .TableStyles.Clear()                                            ' ��U�A�S�ăN���A����
            .TableStyles.Add(objTs)                                         ' �e�[�u���X�^�C����DataGrid�ɒǉ�
            .ReadOnly = True                                                ' �ҏW�֎~
        End With

        '------------------------------
        ' �O���b�h����
        '------------------------------
        dtsList = New DataSet("ImgList3")
        objTable = New DataTable("IMAGELIST4")

        For lngCnt = 0 To UBound(udtGridCol) - 1
            Call GS_GridAddTable(udtGridCol(lngCnt), objTable)
        Next

        '------------------------------
        ' �f�[�^�l�ݒ�
        '------------------------------
        Try
            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, dtrData) Then
                    GoTo SYSTEM_ERROR
                End If

                dtrRows = objTable.NewRow
                dtrRows(udtGridCol(0).strMapName) = g_udtAppConfig.strAdvPath & "\" & Trim$(dtrData("FILENM"))
                dtrRows(udtGridCol(1).strMapName) = Trim$(dtrData("ADV_ID"))
                dtrRows(udtGridCol(2).strMapName) = Trim$(dtrData("DISPORDER"))
                objTable.Rows.Add(dtrRows)
                lngCnt = lngCnt + 1
            End While
        Catch
            GoTo SYSTEM_ERROR
        End Try

        dtsList.Tables.Add(objTable)                                        ' �e�[�u����DataSet�ɒǉ�����
        grd_AdvList2.SetDataBinding(dtsList, "IMAGELIST4")                   ' DataSet�ƃe�[�u����DataGrid�ɐڑ�����

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GridSetup_3")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�I���摜�ꗗ�������t�H���_�I���{�^�� ����������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Fol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Fol.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objFolder As New BrowseFolder()
        Dim strSelPath As String

        Try
            '------------------------------
            ' �����l�ݒ�
            '------------------------------
            strSelPath = objFolder.BrowseDialog("�t�H���_���w�肵�Ă��������B", Me)
            If strSelPath = g_udtAppConfig.strAdvPath Then
                Call GF_Msg("E02", "", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                txt_ImgPath.Text = strSelPath
                If Len(Trim$(txt_ImgPath.Text)) <> 0 Then
                    '------------------------------
                    ' �I���摜���X�g����
                    '------------------------------
                    Call LS_GridSetup_1()
                End If
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Fol_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�I���摜�ꗗ�J�����g�Z���ʒu�ω�������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub grd_ImgList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_ImgList.Click
        Call LS_PictureSelect(grd_ImgList, TLBMODE.ADDMODE)
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���摜�ꗗ�J�����g�Z���ʒu�ω�������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub grd_AdvList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_AdvList.Click
        Call LS_PictureSelect(grd_AdvList, TLBMODE.EDITMODE)
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�摜�ҏW�p�I���摜�ꗗ�J�����g�Z���ʒu�ω�������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub grd_AdvList2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_AdvList2.Click
        Call LS_PictureSelect2(grd_AdvList2)
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�I���A�L���摜�I������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_PictureSelect(ByVal pGridObj As DataGrid, ByVal pSelMode As TLBMODE)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCell As DataGridCell
        Dim strFile As String
        Dim objFileSys As System.IO.FileStream

        If GF_GetRowCnt(pGridObj) = 0 Then
            Exit Sub
        End If

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        Me.Cursor = Cursors.WaitCursor

        objCell = pGridObj.CurrentCell
        strFile = pGridObj(objCell.RowNumber, 0)
        L_strSelFile = strFile
        If Len(Dir(strFile)) = 0 Then
            Exit Sub
        End If

        objFileSys = New System.IO.FileStream(strFile, IO.FileMode.Open, IO.FileAccess.Read)
        L_objGraph.DrawImage(System.Drawing.Image.FromStream(objFileSys), _
                             0, _
                             0, _
                             GC_ADVPIC_W, _
                             GC_ADVPIC_H)                                   ' �w��摜�̕`��
        pic_ViewArea.Refresh()                                              ' �ҏW��̋����ĕ`��

        objFileSys.Close()

        Erase L_objUndo                                                     ' �A���h�D���̃N���A

        '------------------------------
        ' �ǉ��E�폜�{�^���g�p�ېݒ�
        '------------------------------
        Call LS_SetButton(pSelMode)

        Me.Cursor = Cursors.Default

        Exit Sub

SYSTEM_ERROR:
        Me.Cursor = Cursors.Default
        Call GS_ErrorTerm("LS_PictureSelect")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�摜�ҏW�p�I���摜�I������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_PictureSelect2(ByVal pGridObj As DataGrid)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCell As DataGridCell
        Dim strFile As String
        Dim objFileSys As System.IO.FileStream

        If GF_GetRowCnt(pGridObj) = 0 Then
            Exit Sub
        End If

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        Me.Cursor = Cursors.WaitCursor

        objCell = pGridObj.CurrentCell
        strFile = pGridObj(objCell.RowNumber, 0)
        L_strSelFile = strFile
        If Len(Dir(strFile)) = 0 Then
            Exit Sub
        End If

        objFileSys = New System.IO.FileStream(strFile, IO.FileMode.Open, IO.FileAccess.Read)
        L_objGraph.DrawImage(System.Drawing.Image.FromStream(objFileSys), _
                             0, _
                             0, _
                             GC_ADVPIC_W, _
                             GC_ADVPIC_H)                                   ' �w��摜�̕`��
        pic_EditArea.Refresh()                                              ' �ҏW��̋����ĕ`��

        '------------------------------
        ' ���i�ڍבJ�ڏ��ݒ菈��
        '------------------------------
        LF_SetAdvGoodsCD(pGridObj(objCell.RowNumber, 1))

        objFileSys.Close()

        Erase L_objUndo                                                     ' �A���h�D���̃N���A

        Me.Cursor = Cursors.Default

        Exit Sub

SYSTEM_ERROR:
        Me.Cursor = Cursors.Default
        Call GS_ErrorTerm("LS_PictureSelect2")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���i�ڍבJ�ڏ��ݒ菈��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2006.01.16 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_SetAdvGoodsCD(ByVal pstrAdvID As String) As Object

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strAdvGrpID As String
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_SetAdvGoodsCD = Nothing
        'chk_Order.Checked = False
        txt_GoodsCD.Text = ""
        lbl_Menu.Text = ""

        '------------------------------
        ' �\�����̍L���O���[�v�擾
        '------------------------------
        strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)

        strSQL = ""
        strSQL = strSQL & "SELECT TPM080.ORDERFLG,"
        strSQL = strSQL & "       TPM080.GOODSCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ"
        strSQL = strSQL & "  FROM TPM080,"
        strSQL = strSQL & "       TPM010"
        strSQL = strSQL & " WHERE TPM080.ADVGRP_ID = '" & strAdvGrpID & "'"
        strSQL = strSQL & "   AND TPM080.ADV_ID    = '" & pstrAdvID & "'"
        strSQL = strSQL & "   AND TPM080.GOODSCD   = TPM010.GOODSCD"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count > 0 Then
            If Not GF_GetRows(objData, 0, objRow) Then
                Exit Function
            End If
        Else
            chk_Order.Checked = False
            Exit Function
        End If

        If objRow("ORDERFLG") = "1" Then
            chk_Order.Checked = True
            txt_GoodsCD.Text = objRow("GOODSCD")
            lbl_Menu.Text = objRow("GOODSNMJ")
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�摜�ҏW�� �ĕ`�掞����(�摜�I����)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub pic_ViewArea_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pic_ViewArea.Paint
        e.Graphics.DrawImage(L_objBitmap, 0, 0, pic_ViewArea.Width, pic_ViewArea.Height)
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�摜�ҏW�� �ĕ`�掞����(�摜�ҏW��)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub pic_EditArea_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pic_EditArea.Paint
        e.Graphics.DrawImage(L_objBitmap, 0, 0, pic_EditArea.Width, pic_EditArea.Height)
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�摜�ҏW�� �`�惂�[�h���ɂ�����}�E�X�h�m������(�摜�ҏW��)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub pic_EditArea_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_EditArea.MouseEnter
        If L_DrawFlg = False Then
            Exit Sub
        End If

        Me.Cursor = Cursors.Cross
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�摜�ҏW�� �`�惂�[�h���ɂ�����}�E�X�n�t�s������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub pic_EditArea_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_EditArea.MouseLeave
        If L_DrawFlg = False Then
            Exit Sub
        End If

        Me.Cursor = Cursors.Default
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�摜�ҏW�� �`�惂�[�h���ɂ�����}�E�X�ړ�������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub pic_EditArea_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_EditArea.MouseMove

        If L_DrawFlg = False Then
            Exit Sub
        End If

        If L_lngDrawCnt <> 0 Then
            Call LS_Undo()
        End If
        Call LS_DrawString(e.X, e.Y)

        L_lngDrawCnt = L_lngDrawCnt + 1

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�摜�ҏW�� �`�惂�[�h���ɂ�����}�E�X�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub pic_EditArea_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_EditArea.MouseDown

        If L_DrawFlg = False Then
            Exit Sub
        End If

        Call LS_Undo()
        Call LS_DrawString(e.X, e.Y)

        L_DrawFlg = False
        Me.Cursor = Cursors.Default
        L_lngDrawCnt = 0
        chk_Draw.Checked = False

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�摜�ҏW�� ������`�揈��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_DrawString(ByVal plngX As Long, ByVal plngY As Long)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngCnt As Long
        Dim lngX As Long
        Dim lngY As Long

        Try
            '------------------------------
            ' �����l�ݒ�
            '------------------------------
            lngX = plngX * (GC_ADVPIC_W / pic_EditArea.Width)
            lngY = plngY * (GC_ADVPIC_H / pic_EditArea.Height)

            '------------------------------
            ' ������`�揈��
            '------------------------------
            L_objGraph.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            If chk_Shadow.Checked Then
                L_objGraph.DrawString(txt_WriteMsg.Text, _
                                      L_objFont, _
                                      System.Drawing.Brushes.LightGray, _
                                      lngX + 2, _
                                      lngY + 2)
            End If
            L_objGraph.DrawString(txt_WriteMsg.Text, _
                                  L_objFont, _
                                  New SolidBrush(L_objColor), _
                                  lngX, _
                                  lngY)
            pic_EditArea.Refresh()

            '------------------------------
            ' ���엚��ێ�����
            '------------------------------
            If IsNothing(L_objUndo) Then
                lngCnt = 0
            Else
                lngCnt = UBound(L_objUndo)
            End If
            ReDim Preserve L_objUndo(lngCnt + 1)
            With L_objUndo(lngCnt)
                .strWriteString = txt_WriteMsg.Text
                .objFontStyle = L_objFont
                .objDrawColor = New SolidBrush(L_objColor)
                .lngX = lngX
                .lngY = lngY
                .blnUndo = chk_Shadow.Checked
            End With
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_DrawString")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F������`�惂�[�h�J�ڏ���
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_DrawModeChg()

        Try
            If Len(Trim$(L_strSelFile)) = 0 Then
                Exit Sub
            End If

            L_DrawFlg = chk_Draw.Checked

            If L_DrawFlg = False Then
                L_lngDrawCnt = 0
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_DrawModeChg")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�V�K�L�����o�^��ʕ\���^�ǉ��@�\
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_AddAdvGrp()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strAdvGrpID As String
        Dim strAdvGrpNM As String

        Try
            strAdvGrpID = LF_GetMaxGrpID()
            strAdvGrpNM = InputBox("�� �ǉ����邨�m�点������͂��Ă�������", g_udtAppConfig.strAppName)

            If Len(Trim$(strAdvGrpNM)) = 0 Then
                Exit Sub
            End If

            If GF_LenB(strAdvGrpNM) > 50 Then
                strAdvGrpNM = GF_MidB(strAdvGrpNM, 1, 50)
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        If Not LF_UpdTPM080_1(strAdvGrpID, strAdvGrpNM, "000", "000", "0", "     ") Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �L�����I���R���{����
        '------------------------------
        Call LS_SetAdvList()
        'L_blnEditFlg = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AddAdvGrp")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�V�K�L�����폜���b�Z�[�W�\���^�폜�@�\
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_DelAdvGrp()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strAdvGrpID As String

        If lst_AdvSel.SelectedIndex = -1 Then
            Exit Sub
        End If

        Try
            If GF_Msg("", Replace(GF_GetMsg("Q05"), "@@@", Trim$(GF_LstGetString(lst_AdvSel, lst_AdvSel.SelectedIndex))), MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then

                strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)

                '------------------------------
                ' �\�������j���[�폜�O�`�F�b�N
                '------------------------------
                If LF_GetTPM040(strAdvGrpID) = False Then
                    Call GF_Msg("", "�^�b�`�p�l���ɕ\�����̂��ߍ폜�ł��܂���B" & vbCrLf & "�J�X�������\�����̂��m�点��ύX��A�ēx���{���Ă��������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                If GF_Msg("A01", "", MsgBoxStyle.YesNo, MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                    If Not LF_UpdTPM080_5(strAdvGrpID) Then
                        GoTo SYSTEM_ERROR
                    End If

                    '------------------------------
                    ' �L���摜���X�g����
                    '------------------------------
                    Call LS_GridSetup_2()

                    '------------------------------
                    ' �L�����I���R���{����
                    '------------------------------
                    Call LS_SetAdvList()
                    'L_blnEditFlg = True
                End If
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_DelAdvGrp")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�V�X�e���Ǘ��}�X�^ �擾����
    ' �@�@�\�T�v�F�I�𒆂��m�点���̍폜�s�`�F�b�N
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM040(ByVal pAdvGrpId As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM040 = False

        '------------------------------
        ' �r�p�k������
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT DEFADVID"
        strSQL = strSQL & "  FROM TPM040"
        strSQL = strSQL & " WHERE DEFADVID = '" & pAdvGrpId & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count <> 0 Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetTPM040 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ǉ��E�폜�{�^���g�p�ېݒ�
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetButton(ByVal pMode As TLBMODE)

        Select Case pMode
            Case TLBMODE.INITMODE                    '�����ݒ莞
                Me.btn_Add.Enabled = False
                Me.btn_Del.Enabled = False
                Me.btn_Up.Enabled = False
                Me.btn_Dwn.Enabled = False

            Case TLBMODE.ADDMODE                     '�ǉ����[�h��
                Me.btn_Add.Enabled = True
                Me.btn_Del.Enabled = False
                Me.btn_Up.Enabled = False
                Me.btn_Dwn.Enabled = False

            Case TLBMODE.EDITMODE                    '�폜���[�h��
                Me.btn_Add.Enabled = False
                Me.btn_Del.Enabled = True
                Me.btn_Up.Enabled = True
                Me.btn_Dwn.Enabled = True

            Case Else
                Exit Sub
        End Select

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H���g�I���_�C�A���O�\������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_ShowFontDialog()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objFontDialog As New FontDialog()

        '------------------------------
        ' �t�H���g�I���_�C�A���O�\��
        '------------------------------
        With objFontDialog
            .Font = L_objFont
            .MaxSize = 90
            .MinSize = 10
            .FontMustExist = True
            .AllowVerticalFonts = True
            .ShowColor = False
            .ShowEffects = True
            .FixedPitchOnly = False
            .AllowVectorFonts = True

            If .ShowDialog <> DialogResult.Cancel Then
                L_objFont = .Font
            End If
        End With

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�`��F�I���_�C�A���O�\������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_ShowColorDialog()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objColorDialog As New ColorDialog()

        '------------------------------
        ' �F�I���_�C�A���O�\��
        '------------------------------
        With objColorDialog
            .SolidColorOnly = True
            .AllowFullOpen = True
            .ShowHelp = False
            .Color = txt_WriteMsg.ForeColor

            If .ShowDialog <> DialogResult.Cancel Then
                L_objColor = .Color
            End If
        End With

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�A���h�D����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_Undo()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngCnt As Long
        Dim objFileSys As System.IO.FileStream

        ' �A���h�D��񂪑��݂��Ȃ��ꍇ�́A�����ΏۊO�Ƃ���
        If IsNothing(L_objUndo) Then
            Exit Sub
        Else
            If UBound(L_objUndo) = 0 Then
                Exit Sub
            End If
        End If

        Try
            '------------------------------
            ' ���ݑI�𒆂̉摜���擾
            '------------------------------
            ReDim Preserve L_objUndo(UBound(L_objUndo) - 1)

            '------------------------------
            ' �A���h�D���ƕ����čĕ`��
            '------------------------------
            objFileSys = New System.IO.FileStream(L_strSelFile, IO.FileMode.Open, IO.FileAccess.Read)
            With L_objGraph
                .DrawImage(System.Drawing.Image.FromStream(objFileSys), 0, 0, GC_ADVPIC_W, GC_ADVPIC_H)
                objFileSys.Close()

                For lngCnt = 0 To UBound(L_objUndo) - 1
                    If L_objUndo(lngCnt).blnUndo Then
                        .DrawString(L_objUndo(lngCnt).strWriteString, _
                                    L_objUndo(lngCnt).objFontStyle, _
                                    System.Drawing.Brushes.LightGray, _
                                    L_objUndo(lngCnt).lngX + 2, _
                                    L_objUndo(lngCnt).lngY + 2)
                    End If
                    .DrawString(L_objUndo(lngCnt).strWriteString, _
                                L_objUndo(lngCnt).objFontStyle, _
                                L_objUndo(lngCnt).objDrawColor, _
                                L_objUndo(lngCnt).lngX, _
                                L_objUndo(lngCnt).lngY)
                Next
            End With

            pic_EditArea.Refresh()
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_Undo")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ҏW�摜�ǉ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_AdvImgAdd()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strAdvGrpID As String
        Dim strAdvID As String
        Dim strAdvGrpNM As String
        Dim strAdvNum As String
        Dim objCell As DataGridCell
        Dim strOrderFlg As String
        Dim strGoodsCD As String

        Try
            '------------------------------
            ' ���O�����W
            '------------------------------
            If lst_AdvSel.SelectedIndex = -1 Then
                Call GF_Msg("E04", "", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                Exit Sub
            Else
                strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)
                strAdvGrpNM = GF_LstGetString(lst_AdvSel, lst_AdvSel.SelectedIndex)
                strAdvID = LF_GetMaxID()
                strAdvNum = LF_GetMaxCount(strAdvGrpID, Format$(CLng(strAdvID) - 1, "000"))
                strOrderFlg = IIf(chk_Order.Checked = True, 1, 0)
                strGoodsCD = txt_GoodsCD.Text
            End If

            If Len(Trim$(strAdvGrpID)) = 0 Or _
               Len(Trim$(strAdvNum)) = 0 Then
                GoTo SYSTEM_ERROR
            End If

            '------------------------------
            ' �摜�ۑ�����
            '------------------------------
            If Not LF_SaveImage(strAdvGrpID, strAdvID) Then
                GoTo SYSTEM_ERROR
            End If

            '------------------------------
            ' �c�a�ۑ�����
            '------------------------------
            If Not LF_UpdTPM080_1(strAdvGrpID, strAdvGrpNM, strAdvID, strAdvNum, strOrderFlg, strGoodsCD) Then
                GoTo SYSTEM_ERROR
            End If

            '------------------------------
            ' ���e�ʃ`�F�b�N����
            '------------------------------
            Select Case GF_AdvGrpLengthChk(strAdvGrpID)
                Case CNL1920.FuncResult.CancelEnd
                    Call GF_Msg("", "���m�点�O���[�v [" & Trim$(strAdvGrpNM) & "] �̗e�ʂ������l�𒴂��܂���" & vbCrLf & _
                                    "�^�b�`�p�l���ւ̕\�����ł��Ȃ����߁A�����ꂩ�̂��m�点�摜���폜���Ă�������", _
                                MsgBoxStyle.Exclamation, _
                                MsgBoxStyle.OkOnly)

                    If Not LF_UpdTPM080_2(strAdvGrpID, strAdvID) Then
                        GoTo SYSTEM_ERROR
                    End If
                    Exit Sub

                Case CNL1920.FuncResult.UnusualEnd
                    GoTo SYSTEM_ERROR
            End Select

            Erase L_objUndo

            '------------------------------
            ' �L���摜���X�g����
            '------------------------------
            Call LS_GridSetup_2()

            '------------------------------
            ' �ǉ��E�폜�{�^���g�p�ېݒ�
            '------------------------------
            Call LS_SetButton(TLBMODE.INITMODE)

            With objCell
                .RowNumber = CInt(GF_GetRowCnt(grd_AdvList)) - 1
                .ColumnNumber = 0
            End With
            grd_AdvList.CurrentCell = objCell

            '------------------------------
            ' �I���摜�̈�N���A
            '------------------------------
            L_objBitmap = New Bitmap(GC_ADVPIC_W, GC_ADVPIC_H, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
            L_objGraph = Graphics.FromImage(L_objBitmap)
            pic_ViewArea.Refresh()
            L_strSelFile = ""
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AdvImgAdd")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ҏW�摜�ۑ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_SaveImage(ByVal pAdvGrpID As String, ByVal pAdvID As String) As Boolean

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_SaveImage = False

        Try
            '------------------------------
            ' �G���R�[�h�����̎w��
            '------------------------------
            Dim myEncoderParameters As New System.Drawing.Imaging.EncoderParameters(1)
            Dim myEncoderParameter As New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 99)
            myEncoderParameters.Param(0) = myEncoderParameter

            '------------------------------
            ' �ۑ��`���̎w��
            '------------------------------
            Dim myImageCodecInfo As System.Drawing.Imaging.ImageCodecInfo
            myImageCodecInfo = GF_GetEncoderInfo("image/jpeg")
            Dim ext As String = myImageCodecInfo.FilenameExtension.Split(";"c)(0)
            ext = System.IO.Path.GetExtension(ext).ToLower()

            '------------------------------
            ' �ۑ�����
            '------------------------------
            Dim saveName As String
            saveName = System.IO.Path.ChangeExtension(LF_AdvFileNm(pAdvGrpID, pAdvID), ext)
            L_objBitmap.Save(saveName, myImageCodecInfo, myEncoderParameters)

        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_SaveImage = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���摜�t�@�C������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_AdvFileNm(ByVal pAdvGrpID As String, ByVal pAdvID As String, Optional ByVal pFullRet As Boolean = True) As String

        If pFullRet Then
            LF_AdvFileNm = g_udtAppConfig.strAdvPath & "\"
        Else
            LF_AdvFileNm = ""
        End If
        LF_AdvFileNm = LF_AdvFileNm & pAdvGrpID & pAdvID & ".jpg"

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ҏW�摜�X�V����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_AdvImgUpd()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCell As DataGridCell
        Dim strAdvGrpID As String
        Dim strAdvID As String
        Dim strAdvNum As String
        'Dim intOrderFlg As Integer
        'Dim strGoodsCD As String
        Dim intUpdate As Integer

        Try
            intUpdate = 0

            If IsNothing(L_objUndo) Then
                intUpdate = 1
            Else
                If UBound(L_objUndo) = 0 Then
                    intUpdate = 1
                End If
            End If

            objCell = grd_AdvList2.CurrentCell
            strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)
            strAdvID = grd_AdvList2(objCell.RowNumber, 1)
            strAdvNum = grd_AdvList2(objCell.RowNumber, 2)

            If intUpdate = 0 Then
                Me.Cursor = Cursors.WaitCursor

                If Not LF_SaveImage(strAdvGrpID, strAdvID) Then
                    GoTo SYSTEM_ERROR
                End If

                Me.Cursor = Cursors.Default

                Erase L_objUndo

                '------------------------------
                ' �摜�ҏW�p�L���摜���X�g����
                '------------------------------
                Call LS_GridSetup_3()
                grd_AdvList2.CurrentCell = objCell
            End If

            ''------------------------------
            '' ���i�ڍבJ�ڏ��X�V����
            ''------------------------------
            'intOrderFlg = IIf(chk_Order.Checked = True, 1, 0)
            'strGoodsCD = txt_GoodsCD.Text
            'If Not LF_UpdTPM080_6(strAdvID, intOrderFlg, strGoodsCD) Then
            '    GoTo SYSTEM_ERROR
            'End If

            '------------------------------
            ' �I���摜�̈�N���A
            '------------------------------
            L_objBitmap = New Bitmap(GC_ADVPIC_W, GC_ADVPIC_H, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
            L_objGraph = Graphics.FromImage(L_objBitmap)
            pic_EditArea.Refresh()
            L_strSelFile = ""
            chk_Order.Checked = False
            txt_GoodsCD.Text = ""
            lbl_Menu.Text = ""
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AdvImgUpd")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ҏW�摜�폜����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_AdvImgDel()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strAdvGrpID As String
        Dim strAdvID As String
        Dim strDispOrder As String
        Dim objCell As DataGridCell
        Dim objRow As DataRow = Nothing

        '------------------------------
        ' ���O���擾
        '------------------------------
        Try
            objCell = grd_AdvList.CurrentCell
            strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)
            strAdvID = grd_AdvList(objCell.RowNumber, 1)
            strDispOrder = grd_AdvList(objCell.RowNumber, 2)
        Catch
            GoTo SYSTEM_ERROR
        End Try

        '------------------------------
        ' �\�������m�点 ����`�F�b�N
        '------------------------------
        If LF_GetTPM040(strAdvGrpID) = False Then
            '------------------------------
            ' �I�����m�点�\�������擾����
            '------------------------------
            If Not LF_GetTPM080_3(objRow) Then
                GoTo SYSTEM_ERROR
            End If

            '------------------------------
            ' ���ݐݒ�l �\������
            '------------------------------
            If Trim$(objRow("RECCNT")) <= 1 Then
                Call GF_Msg("", "�^�b�`�p�l���ɕ\�����̂��m�点�̂��߁A" & vbCrLf & "�P���ȏ�̓o�^���K�v�ł��B", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        '------------------------------
        ' �c�a�X�V����
        '------------------------------
        If Not LF_UpdTPM080_2(strAdvGrpID, strAdvID) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �L���摜���X�g����
        '------------------------------
        Call LS_GridSetup_2()

        '------------------------------
        ' �ǉ��E�폜�{�^���g�p�ېݒ�
        '------------------------------
        Call LS_SetButton(TLBMODE.INITMODE)

        Try
            '------------------------------
            ' �I���摜�̈�N���A
            '------------------------------
            L_objBitmap = New Bitmap(GC_ADVPIC_W, GC_ADVPIC_H, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
            L_objGraph = Graphics.FromImage(L_objBitmap)
            pic_ViewArea.Refresh()
            L_strSelFile = ""
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AdvImgDel")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ҏW��������͎�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub txt_WriteMsg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_WriteMsg.TextChanged

        '------------------------------
        ' ���[�U�[���͎��̂ݏ����Ώ�
        '------------------------------
        If txt_WriteMsg.Modified = False Then
            Exit Sub
        End If

        L_DrawFlg = False
        L_lngDrawCnt = 0
        chk_Draw.Checked = False

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ҏW��摜�ꗗ �\�����ʕύX����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_ChgRank(ByVal pProcKbn As Boolean)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCell As DataGridCell
        Dim lngMaxRow As Long
        Dim strDispOrder As String
        Dim strTargetOrder As String
        Dim strTargetAdvID As String
        Dim strAdvID As String

        Try
            '------------------------------
            ' �����l�ݒ�
            '------------------------------
            objCell = grd_AdvList.CurrentCell                                   ' �J�����g�Z���ʒu�擾
            lngMaxRow = GF_GetRowCnt(grd_AdvList)
            If pProcKbn Then                                                    ' �����敪�ɂ��A�����֎~�ʒu����
                If objCell.RowNumber <= 0 Then
                    Exit Sub
                End If
            Else
                If objCell.RowNumber >= (lngMaxRow - 1) Then
                    Exit Sub
                End If
            End If

            ' ���ʕύX�Ώۉ摜�̏��擾
            strDispOrder = grd_AdvList(objCell.RowNumber, 2)
            strAdvID = grd_AdvList(objCell.RowNumber, 1)

            ' ���ʕύX��̏��擾
            If pProcKbn Then
                strTargetOrder = grd_AdvList(objCell.RowNumber - 1, 2)
                strTargetAdvID = grd_AdvList(objCell.RowNumber - 1, 1)
            Else
                strTargetOrder = grd_AdvList(objCell.RowNumber + 1, 2)
                strTargetAdvID = grd_AdvList(objCell.RowNumber + 1, 1)
            End If

            '------------------------------
            ' �L���摜�ꗗ���\�[�X�ꎞ���
            '------------------------------
            grd_AdvList.DataSource = Nothing
            grd_AdvList.TableStyles.Clear()

            ' �菇�P�F�ύX����DUMMY
            If Not LF_UpdTPM080_3(strAdvID, "000", strDispOrder) Then
                GoTo SYSTEM_ERROR
            End If

            ' �菇�Q�F�ύX�恨(�󂫔ԂƂȂ���)�ύX��
            If Not LF_UpdTPM080_3(strTargetAdvID, strDispOrder, strTargetOrder) Then
                GoTo SYSTEM_ERROR
            End If

            ' �菇�R�FDYMMY��(�󂫔ԂƂȂ�)�ύX��
            If Not LF_UpdTPM080_3(strAdvID, strTargetOrder, "000") Then
                GoTo SYSTEM_ERROR
            End If

            '------------------------------
            ' �L���摜���X�g����
            '------------------------------
            Call LS_GridSetup_2()

            If pProcKbn Then
                objCell.RowNumber = objCell.RowNumber - 1
            Else
                objCell.RowNumber = objCell.RowNumber + 1
            End If
            grd_AdvList.CurrentCell = objCell
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_ChgRank")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L�����̍��� �ω�������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub txt_AdvNm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_AdvNm.TextChanged

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strWork() As String

        '------------------------------
        ' �L�[�{�[�h���͎��ȊO�͏����ΏۊO
        '------------------------------
        If txt_AdvNm.Modified = False Then
            Exit Sub
        End If

        If lst_AdvSel.SelectedIndex = -1 Then
            Exit Sub
        End If

        Try
            If GF_LenB(txt_AdvNm.Text) > 50 Then
                txt_AdvNm.Text = GF_MidB(txt_AdvNm.Text, 1, 50)
                txt_AdvNm.SelectionStart = GF_LenB(txt_AdvNm.Text)
                Exit Sub
            End If

            '------------------------------
            ' �L���摜���X�g�X�V
            '------------------------------
            strWork = Split(lst_AdvSel.Items(lst_AdvSel.SelectedIndex), vbTab)
            lst_AdvSel.Items(lst_AdvSel.SelectedIndex) = Trim$(txt_AdvNm.Text) & Space(100) & vbTab & strWork(1)
        Catch
            GoTo SYSTEM_ERROR
        End Try

        '------------------------------
        ' �L�����}�X�^�X�V
        '------------------------------
        If Not LF_UpdTPM080_4(strWork(1), Trim$(txt_AdvNm.Text)) Then
            GoTo SYSTEM_ERROR
        End If
        'L_blnEditFlg = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_AdvNm_TextChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���摜���}�X�^ �擾 - (�P)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM080_1(ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM080_1 = False

        '------------------------------
        ' �L���摜���}�X�^ ���o
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT ADVGRP_ID,"
        strSQL = strSQL & "       ADVGRP_NM"
        strSQL = strSQL & "  FROM TPM080"
        strSQL = strSQL & " GROUP BY ADVGRP_ID,"
        strSQL = strSQL & "          ADVGRP_NM"
        strSQL = strSQL & " ORDER BY ADVGRP_ID"

        If Not GF_GetData(strSQL, pDataSet) Then
            Exit Function
        End If

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM080_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���摜���}�X�^ �擾 - (�Q)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM080_2(ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM080_2 = False

        '------------------------------
        ' �L���摜���}�X�^ ���o
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT ADV_ID,"
        strSQL = strSQL & "       DISPORDER,"
        strSQL = strSQL & "       FILENM,"
        strSQL = strSQL & "       ENABLED"
        strSQL = strSQL & "  FROM TPM080"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex) & "'"
        strSQL = strSQL & "   AND ADV_ID    <> '000'"
        strSQL = strSQL & "   AND DISPORDER <> '000'"
        strSQL = strSQL & " ORDER BY DISPORDER"

        If Not GF_GetData(strSQL, pDataSet) Then
            Exit Function
        End If

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM080_2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���摜���}�X�^ �擾 - (�R)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM080_3(ByRef pRows As DataRow) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM080_3 = False

        '------------------------------
        ' �L���摜���}�X�^ ���o
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT COUNT(*) AS RECCNT"
        strSQL = strSQL & "  FROM TPM080"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex) & "'"
        strSQL = strSQL & "   AND ADV_ID    <> '000'"
        strSQL = strSQL & "   AND DISPORDER <> '000'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, pRows) Then
            Exit Function
        End If

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM080_3 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���摜�O���[�v�h�c�̔ԏ���
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetMaxGrpID() As String

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetMaxGrpID = ""

        '------------------------------
        ' �ŏI�A�Ԏ擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT MAX(ADVGRP_ID) AS MAXGRPID"
        strSQL = strSQL & "  FROM TPM080"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        If IsDBNull(objRows("MAXGRPID")) Then
            LF_GetMaxGrpID = "K" & Format$(CLng(Mid$(Trim$("K00"), 2, 2)) + 1, "00")
        Else
            LF_GetMaxGrpID = "K" & Format$(CLng(Mid$(Trim$(objRows("MAXGRPID")), 2, 2)) + 1, "00")
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���摜�h�c�̔ԏ���
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetMaxID() As String

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetMaxID = ""

        '------------------------------
        ' �ŏI�A�Ԏ擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT MAX(ADV_ID) AS MAXID"
        strSQL = strSQL & "  FROM TPM080"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex) & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        If IsDBNull(objRows("MAXID")) Then
            LF_GetMaxID = Format$(CLng(Trim$("000")) + 1, "000")
        Else
            LF_GetMaxID = Format$(CLng(Trim$(objRows("MAXID"))) + 1, "000")
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�\�����̔ԏ���
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetMaxCount(ByVal pAdvGrpID As String, ByVal pAdvID As String) As String

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetMaxCount = ""
        If Len(Trim$(pAdvGrpID)) = 0 Or Len(Trim$(pAdvID)) = 0 Then Exit Function

        '------------------------------
        ' �ŏI�A�Ԏ擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT MAX(DISPORDER) AS MAXNUM"
        strSQL = strSQL & "  FROM TPM080"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & Trim$(pAdvGrpID) & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        If IsDBNull(objRows("MAXNUM")) Then
            LF_GetMaxCount = Format$(CLng(Trim$("000")) + 1, "000")
        Else
            LF_GetMaxCount = Format$(CLng(Trim$(objRows("MAXNUM"))) + 1, "000")
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���摜���}�X�^�X�V����(�P)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM080_1(ByVal pAdvGrpID As String, ByVal pAdvGrpNm As String, _
    ByVal pAdvID As String, ByVal pDispOrder As String, ByVal pOrderFlg As String, ByVal pGoodsCD As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM080_1 = False

        '------------------------------
        ' �ǉ������񐶐�
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM080 VALUES("
        strSQL = strSQL & "'" & pAdvGrpID & "',"
        strSQL = strSQL & "'" & GF_RepQuo(pAdvGrpNm) & "',"
        strSQL = strSQL & "'" & pAdvID & "',"
        strSQL = strSQL & "'" & pDispOrder & "',"
        strSQL = strSQL & "'" & LF_AdvFileNm(pAdvGrpID, pAdvID, False) & "',"
        strSQL = strSQL & "'" & GC_TRUE & "',"
        strSQL = strSQL & "'" & pOrderFlg & "',"
        strSQL = strSQL & "'" & pGoodsCD & "',"
        strSQL = strSQL & "'" & GC_UPDID & "',"
        strSQL = strSQL & "'" & Now & "'"
        strSQL = strSQL & ")"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM080_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���摜���}�X�^�X�V����(�Q)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM080_2(ByVal pAdvGrpID As String, ByVal pAdvID As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM080_2 = False

        '------------------------------
        ' �ǉ������񐶐�
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE FROM TPM080"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & pAdvGrpID & "'"
        strSQL = strSQL & "   AND ADV_ID    = '" & pAdvID & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM080_2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���摜���}�X�^�X�V����(�R)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM080_3(ByVal pAdvID As String, ByVal pTargetOrder As String, ByVal pOriginalOrder As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim strAdvGrpID As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM080_3 = False

        strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)

        '------------------------------
        ' �����񐶐�
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM080"
        strSQL = strSQL & "   SET DISPORDER = '" & pTargetOrder & "'"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & strAdvGrpID & "'"
        strSQL = strSQL & "   AND ADV_ID    = '" & pAdvID & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        LF_UpdTPM080_3 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���摜���}�X�^�X�V����(�S)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM080_4(ByVal pAdvID As String, ByVal pAdvGrpNM As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim strAdvGrpID As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM080_4 = False

        strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)

        '------------------------------
        ' �����񐶐�
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM080"
        strSQL = strSQL & "   SET ADVGRP_NM = '" & pAdvGrpNM & "'"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & pAdvID & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        LF_UpdTPM080_4 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���摜���}�X�^�X�V����(�T)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM080_5(ByVal pAdvGrpID As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM080_5 = False

        '------------------------------
        ' �ǉ������񐶐�
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE FROM TPM080"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & pAdvGrpID & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM080_5 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���摜���}�X�^�X�V����(�U)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2006.01.16 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM080_6(ByVal pAdvID As String, ByVal pintOrderFlg As Integer, ByVal pstrGoodsCD As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim strAdvGrpID As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM080_6 = False

        strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)

        '------------------------------
        ' �����񐶐�
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM080"
        strSQL = strSQL & "   SET ORDERFLG  = '" & pintOrderFlg & "',"
        strSQL = strSQL & "       GOODSCD   = '" & IIf(Trim$(pstrGoodsCD) = "", Space(5), pstrGoodsCD) & "',"
        strSQL = strSQL & "       UPDID     = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD    = '" & Now & "'"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & strAdvGrpID & "'"
        strSQL = strSQL & "   AND ADV_ID    = '" & pAdvID & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        LF_UpdTPM080_6 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���摜�t�H���_�� ���g�p�摜�t�@�C���폜����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_DelUnuseFile() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strUFile() As String = Nothing
        Dim strFile As String
        Dim strItemPath As String
        Dim strWork As String
        Dim blnFound As Boolean
        Dim objFileInfo As System.IO.FileInfo = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_DelUnuseFile = False

        Try
            '------------------------------
            ' �g�p���摜�t�@�C���ꗗ�擾
            '------------------------------
            strSQL = ""
            strSQL = strSQL & "SELECT FILENM"
            strSQL = strSQL & "  FROM TPM080"
            strSQL = strSQL & " WHERE LEN(LTRIM(FILENM)) <> 0"
            strSQL = strSQL & "   AND ADV_ID             <> '000'"

            If Not GF_GetData(strSQL, objData) Then
                Exit Function
            End If

            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    Exit Function
                End If
                ReDim Preserve strUFile(lngCnt)
                strUFile(lngCnt) = Trim$(objRows("FILENM"))

                lngCnt = lngCnt + 1
            End While

            '------------------------------
            ' �摜�t�@�C���g�p������
            '------------------------------
            strItemPath = GF_GetAppInfo("ADV_PATH")
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
        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_DelUnuseFile = True

    End Function

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���i�ڍחp�I���{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Goods_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Goods.Click

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        Dim objForm As New CNL1561()
        Dim objCell As DataGridCell
        Dim strAdvID As String
        Dim intOrderFlg As Integer
        Dim strGoodsCD As String

        With objForm
            .StartPosition = FormStartPosition.CenterParent
            .FormBorderStyle = FormBorderStyle.FixedDialog
            .ShowInTaskbar = False
            .MaximizeBox = False
            .MinimizeBox = False
            .ControlBox = False
            .MaximumSize = .Size
            .G_Code = txt_GoodsCD.Text
            If .ShowDialog() = DialogResult.OK Then
                lbl_Menu.Text = objForm.G_Menu
                txt_GoodsCD.Text = objForm.G_Code

                If L_strSelFile = "" Then
                    '------------------------------
                    ' ���i�摜�\��
                    '------------------------------
                    LF_GetGoodsPic()
                End If

            End If
        End With

        '------------------------------
        ' ���i�ڍבJ�ڏ��X�V����
        '------------------------------
        If Len(Trim$(L_strSelFile)) = 0 Then
            Exit Sub
        End If

        objCell = grd_AdvList2.CurrentCell
        strAdvID = grd_AdvList2(objCell.RowNumber, 1)
        intOrderFlg = IIf(chk_Order.Checked = True, 1, 0)
        strGoodsCD = txt_GoodsCD.Text

        If Not LF_UpdTPM080_6(strAdvID, intOrderFlg, strGoodsCD) Then
            Exit Sub
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���i�ڍחp�����{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.04.09 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_ClrGoods_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ClrGoods.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objCell As DataGridCell
        Dim strAdvID As String
        Dim strAdvGrpID As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        objCell = grd_AdvList2.CurrentCell
        strAdvID = grd_AdvList2(objCell.RowNumber, 1)

        strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)

        '------------------------------
        ' �����񐶐�
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM080"
        strSQL = strSQL & "   SET ORDERFLG  = '0',"
        strSQL = strSQL & "       GOODSCD   = '" & Space(1) & "',"
        strSQL = strSQL & "       UPDID     = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD    = '" & Now & "'"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & strAdvGrpID & "'"
        strSQL = strSQL & "   AND ADV_ID    = '" & strAdvID & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Sub
        End If

        chk_Order.Checked = False
        btn_Goods.Enabled = False
        btn_ClrGoods.Enabled = False
        txt_GoodsCD.Text = ""
        lbl_Menu.Text = ""

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���i�ڍחp�`�F�b�N�{�b�N�X����������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub chk_Order_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Order.CheckedChanged

        If chk_Order.Checked = True Then
            btn_Goods.Enabled = True
            btn_ClrGoods.Enabled = True
        Else
            btn_Goods.Enabled = False
            btn_ClrGoods.Enabled = False
            txt_GoodsCD.Text = ""
            lbl_Menu.Text = ""
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���i�ڍחp���i�摜�\��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetGoodsPic() As Object

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim strFile As String
        Dim objFileSys As System.IO.FileStream

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetGoodsPic = Nothing

        strSQL = ""
        strSQL = strSQL & "SELECT IMAGEDATA"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " WHERE GOODSCD = '" & txt_GoodsCD.Text & "'"

        If Not GF_GetData(strSQL, objData) Then
            Return Nothing
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Return Nothing
        End If

        If Not GF_GetRows(objData, 0, objRow) Then
            Return Nothing
        End If

        strFile = g_udtAppConfig.strImgPath & "\" & Trim$(objRow("IMAGEDATA"))
        If System.IO.File.Exists(strFile) Then
            objFileSys = New System.IO.FileStream(strFile, IO.FileMode.Open, IO.FileAccess.Read)
            L_objGraph.DrawImage(System.Drawing.Image.FromStream(objFileSys), _
                                 0, _
                                 0, _
                                 GC_ADVPIC_W, _
                                 GC_ADVPIC_H)                                   ' �w��摜�̕`��
            pic_ViewArea.Refresh()                                              ' �ҏW��̋����ĕ`��

            L_strSelFile = strFile

            '------------------------------
            ' �ǉ��E�폜�{�^���g�p�ېݒ�
            '------------------------------
            Call LS_SetButton(TLBMODE.ADDMODE)

        End If
        '---------------------------------------------------------------------------------------------------
    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u�L���̐V�K�ǉ��v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_AddKo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddKo.Click

        '------------------------------
        ' �V�K�L�����o�^��ʕ\���^�ǉ�
        '------------------------------
        Call LS_AddAdvGrp()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_AddKo_Click")

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u�L���̍폜�v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_DelKo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DelKo.Click

        '------------------------------
        ' �V�K�L�����폜���b�Z�[�W�\���^�폜
        '------------------------------
        Call LS_DelAdvGrp()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_DelKo_Click")

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u��ֈړ��v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Up.Click

        '------------------------------
        ' �ҏW��摜�ꗗ �\�����ʕύX����
        '------------------------------
        Call LS_ChgRank(True)

        'L_blnEditFlg = True

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u���ֈړ��v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Dwn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Dwn.Click

        '------------------------------
        ' �ҏW��摜�ꗗ �\�����ʕύX����
        '------------------------------
        LS_ChgRank(False)

        'L_blnEditFlg = True

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u�ǉ��v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click

        '------------------------------
        ' �ҏW�摜�ǉ�����
        '------------------------------
        Call LS_AdvImgAdd()

        'L_blnEditFlg = True

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u�폜�v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Del.Click

        '------------------------------
        ' �ҏW�摜��������
        '------------------------------
        Call LS_AdvImgDel()

        'L_blnEditFlg = True

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        Select Case TabControl1.SelectedIndex
            Case 0
                '------------------------------
                ' �e�摜���X�g����
                '------------------------------
                Call LS_GridSetup_2()                                               ' �ҏW��摜���X�g

                '------------------------------
                ' �ǉ��E�폜�{�^���g�p�ېݒ�
                '------------------------------
                Call LS_SetButton(TLBMODE.INITMODE)

            Case 1
                '------------------------------
                ' �e�摜���X�g����
                '------------------------------
                Call LS_GridSetup_3()                                               ' �ҏW��摜���X�g

            Case Else
                Exit Sub
        End Select

        txt_WriteMsg.Clear()                                                ' �摜�`�惁�b�Z�[�W

        '------------------------------
        ' �I���摜�̈�N���A
        '------------------------------
        L_objBitmap = New Bitmap(GC_ADVPIC_W, GC_ADVPIC_H, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
        L_objGraph = Graphics.FromImage(L_objBitmap)
        pic_ViewArea.Refresh()
        L_strSelFile = ""
        chk_Order.Checked = False
        txt_GoodsCD.Text = ""
        lbl_Menu.Text = ""
        btn_Goods.Enabled = False
        btn_ClrGoods.Enabled = False
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u�X�V�v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Img_Edt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Img_Edt.Click

        '------------------------------
        ' �ҏW�摜�X�V����
        '------------------------------
        Call LS_AdvImgUpd()

        'L_blnEditFlg = True

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u�t�H���g�ݒ�v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Font_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Font.Click

        '------------------------------
        ' �t�H���g�I���_�C�A���O�\��
        '------------------------------
        Call LS_ShowFontDialog()

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u�����F�ݒ�v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Color_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Color.Click

        '------------------------------
        ' �`��F�I���_�C�A���O�\��
        '------------------------------
        Call LS_ShowColorDialog()

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u�L������v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub chk_Draw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Draw.CheckedChanged

        '------------------------------
        ' �`�惂�[�h
        '------------------------------
        Call LS_DrawModeChg()

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u�P�O�ɖ߂��v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Prev.Click

        '------------------------------
        ' �A���h�D����
        '------------------------------
        Call LS_Undo()

    End Sub
End Class
