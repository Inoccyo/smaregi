' --------------------------------------------------------------------------------
' �@�@�@�@�\�FCrossNavi - �H�׈��ݕ���o�^���
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2013.02.01 �N���X�R�k�� �V�K�쐬
' --------------------------------------------------------------------------------
Imports System.IO

Public Class CNL2140
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents sts_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ImageList3 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList4 As System.Windows.Forms.ImageList
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage20 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents pic_ViewArea As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Del As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents btn_Dwn As System.Windows.Forms.Button
    Friend WithEvents btn_Up As System.Windows.Forms.Button
    Friend WithEvents btn_Fol As System.Windows.Forms.Button
    Friend WithEvents grd_AdvList As System.Windows.Forms.DataGrid
    Friend WithEvents grd_ImgList As System.Windows.Forms.DataGrid
    Friend WithEvents txt_ImgPath As System.Windows.Forms.TextBox
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_AlertTime2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_AlertTime1 As System.Windows.Forms.TextBox
    Friend WithEvents lsv_CourseGoodsList As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_CourseColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_CourseTime As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_CourseTitle As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lsv_GoodsList As System.Windows.Forms.ListView
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents btn_CourseIns As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_CourseDel As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_CourseCopy As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_LastCallTime As System.Windows.Forms.TextBox
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CNL2140))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"aaa", "a2", "a3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"bbb"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ccc"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Me.sts_Msg = New System.Windows.Forms.StatusBar
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.ImageList4 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage10 = New System.Windows.Forms.TabPage
        Me.btn_CourseCopy = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_AlertTime2 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_AlertTime1 = New System.Windows.Forms.TextBox
        Me.lsv_CourseGoodsList = New System.Windows.Forms.ListView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbo_CourseColor = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_CourseTime = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbo_CourseTitle = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lsv_GoodsList = New System.Windows.Forms.ListView
        Me.txt_Search = New System.Windows.Forms.TextBox
        Me.btn_CourseIns = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btn_CourseDel = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TabPage20 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.pic_ViewArea = New System.Windows.Forms.PictureBox
        Me.btn_Del = New System.Windows.Forms.Button
        Me.btn_Add = New System.Windows.Forms.Button
        Me.btn_Dwn = New System.Windows.Forms.Button
        Me.btn_Up = New System.Windows.Forms.Button
        Me.btn_Fol = New System.Windows.Forms.Button
        Me.grd_AdvList = New System.Windows.Forms.DataGrid
        Me.grd_ImgList = New System.Windows.Forms.DataGrid
        Me.txt_ImgPath = New System.Windows.Forms.TextBox
        Me.txt_LastCallTime = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage20.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pic_ViewArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_AdvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_ImgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sts_Msg
        '
        Me.sts_Msg.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.sts_Msg.Location = New System.Drawing.Point(0, 643)
        Me.sts_Msg.Name = "sts_Msg"
        Me.sts_Msg.ShowPanels = True
        Me.sts_Msg.Size = New System.Drawing.Size(1016, 24)
        Me.sts_Msg.TabIndex = 194
        Me.sts_Msg.Text = "StatusBar1"
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "�O���[�v���炱�̏��i���O��"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem4})
        Me.MenuItem2.Text = "���菤�i�o�^"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "�I��(&E)"
        '
        'ImageList4
        '
        Me.ImageList4.ImageStream = CType(resources.GetObject("ImageList4.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList4.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList4.Images.SetKeyName(0, "")
        Me.ImageList4.Images.SetKeyName(1, "")
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList3.Images.SetKeyName(0, "")
        Me.ImageList3.Images.SetKeyName(1, "")
        Me.ImageList3.Images.SetKeyName(2, "")
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 232
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Controls.Add(Me.TabPage20)
        Me.TabControl1.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(201, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(813, 652)
        Me.TabControl1.TabIndex = 288
        '
        'TabPage10
        '
        Me.TabPage10.BackColor = System.Drawing.Color.Transparent
        Me.TabPage10.BackgroundImage = CType(resources.GetObject("TabPage10.BackgroundImage"), System.Drawing.Image)
        Me.TabPage10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage10.Controls.Add(Me.btn_CourseCopy)
        Me.TabPage10.Controls.Add(Me.Label1)
        Me.TabPage10.Controls.Add(Me.GroupBox2)
        Me.TabPage10.Controls.Add(Me.lsv_CourseGoodsList)
        Me.TabPage10.Controls.Add(Me.GroupBox1)
        Me.TabPage10.Controls.Add(Me.lsv_GoodsList)
        Me.TabPage10.Controls.Add(Me.txt_Search)
        Me.TabPage10.Controls.Add(Me.btn_CourseIns)
        Me.TabPage10.Controls.Add(Me.Label3)
        Me.TabPage10.Controls.Add(Me.Label5)
        Me.TabPage10.Controls.Add(Me.btn_CourseDel)
        Me.TabPage10.Controls.Add(Me.Label11)
        Me.TabPage10.Controls.Add(Me.Label7)
        Me.TabPage10.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage10.Location = New System.Drawing.Point(4, 26)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(805, 622)
        Me.TabPage10.TabIndex = 1
        Me.TabPage10.Text = "����R�[�X�o�^"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'btn_CourseCopy
        '
        Me.btn_CourseCopy.BackColor = System.Drawing.SystemColors.Control
        Me.btn_CourseCopy.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 12.0!)
        Me.btn_CourseCopy.ImageList = Me.ImageList1
        Me.btn_CourseCopy.Location = New System.Drawing.Point(206, 9)
        Me.btn_CourseCopy.Name = "btn_CourseCopy"
        Me.btn_CourseCopy.Size = New System.Drawing.Size(180, 50)
        Me.btn_CourseCopy.TabIndex = 261
        Me.btn_CourseCopy.Text = "����R�[�X�R�s�["
        Me.btn_CourseCopy.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!)
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(439, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 30)
        Me.Label1.TabIndex = 250
        Me.Label1.Text = "����R�[�X�ɓo�^���鏤�i���u���菤�i�ꗗ�v����I�����A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�u�I���ςݕ��菤�i�ꗗ�v�փh���b�O���Ă�������"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.txt_LastCallTime)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_AlertTime2)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txt_AlertTime1)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(405, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 105)
        Me.GroupBox2.TabIndex = 230
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "����R�[�X�ʒm�ݒ�"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.Location = New System.Drawing.Point(287, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 24)
        Me.Label15.TabIndex = 256
        Me.Label15.Text = "���O"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.Location = New System.Drawing.Point(23, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 24)
        Me.Label14.TabIndex = 255
        Me.Label14.Text = "���X�g�I�[�_�["
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.Location = New System.Drawing.Point(18, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 24)
        Me.Label9.TabIndex = 243
        Me.Label9.Text = "�ʒm(����:�ԕ\��)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.Location = New System.Drawing.Point(287, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 24)
        Me.Label12.TabIndex = 254
        Me.Label12.Text = "���O"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.Location = New System.Drawing.Point(287, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 24)
        Me.Label10.TabIndex = 254
        Me.Label10.Text = "���O"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_AlertTime2
        '
        Me.txt_AlertTime2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_AlertTime2.Location = New System.Drawing.Point(181, 44)
        Me.txt_AlertTime2.MaxLength = 3
        Me.txt_AlertTime2.Name = "txt_AlertTime2"
        Me.txt_AlertTime2.Size = New System.Drawing.Size(100, 22)
        Me.txt_AlertTime2.TabIndex = 232
        Me.txt_AlertTime2.Text = "0"
        Me.txt_AlertTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.Location = New System.Drawing.Point(18, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(157, 24)
        Me.Label13.TabIndex = 243
        Me.Label13.Text = "�ʒm(����:���\��)"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_AlertTime1
        '
        Me.txt_AlertTime1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_AlertTime1.Location = New System.Drawing.Point(181, 18)
        Me.txt_AlertTime1.MaxLength = 3
        Me.txt_AlertTime1.Name = "txt_AlertTime1"
        Me.txt_AlertTime1.Size = New System.Drawing.Size(100, 22)
        Me.txt_AlertTime1.TabIndex = 231
        Me.txt_AlertTime1.Text = "0"
        Me.txt_AlertTime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lsv_CourseGoodsList
        '
        Me.lsv_CourseGoodsList.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ListViewItem1.StateImageIndex = 0
        ListViewItem1.UseItemStyleForSubItems = False
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.StateImageIndex = 0
        Me.lsv_CourseGoodsList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.lsv_CourseGoodsList.Location = New System.Drawing.Point(6, 278)
        Me.lsv_CourseGoodsList.Name = "lsv_CourseGoodsList"
        Me.lsv_CourseGoodsList.Size = New System.Drawing.Size(381, 339)
        Me.lsv_CourseGoodsList.TabIndex = 240
        Me.lsv_CourseGoodsList.UseCompatibleStateImageBehavior = False
        Me.lsv_CourseGoodsList.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.cbo_CourseColor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_CourseTime)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbo_CourseTitle)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 152)
        Me.GroupBox1.TabIndex = 220
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "����R�[�X���"
        '
        'cbo_CourseColor
        '
        Me.cbo_CourseColor.FormattingEnabled = True
        Me.cbo_CourseColor.Location = New System.Drawing.Point(212, 111)
        Me.cbo_CourseColor.Name = "cbo_CourseColor"
        Me.cbo_CourseColor.Size = New System.Drawing.Size(121, 23)
        Me.cbo_CourseColor.TabIndex = 223
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(127, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 254
        Me.Label4.Text = "��"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_CourseTime
        '
        Me.txt_CourseTime.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_CourseTime.Location = New System.Drawing.Point(21, 111)
        Me.txt_CourseTime.MaxLength = 3
        Me.txt_CourseTime.Name = "txt_CourseTime"
        Me.txt_CourseTime.Size = New System.Drawing.Size(100, 22)
        Me.txt_CourseTime.TabIndex = 222
        Me.txt_CourseTime.Text = "0"
        Me.txt_CourseTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(209, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 24)
        Me.Label8.TabIndex = 252
        Me.Label8.Text = "����R�[�X�F"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(18, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 24)
        Me.Label2.TabIndex = 252
        Me.Label2.Text = "����R�[�X����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbo_CourseTitle
        '
        Me.cbo_CourseTitle.FormattingEnabled = True
        Me.cbo_CourseTitle.Location = New System.Drawing.Point(21, 45)
        Me.cbo_CourseTitle.Name = "cbo_CourseTitle"
        Me.cbo_CourseTitle.Size = New System.Drawing.Size(349, 23)
        Me.cbo_CourseTitle.TabIndex = 221
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(18, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 24)
        Me.Label6.TabIndex = 243
        Me.Label6.Text = "����R�[�X�^�C�g��"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lsv_GoodsList
        '
        Me.lsv_GoodsList.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_GoodsList.Location = New System.Drawing.Point(405, 280)
        Me.lsv_GoodsList.Name = "lsv_GoodsList"
        Me.lsv_GoodsList.Size = New System.Drawing.Size(390, 337)
        Me.lsv_GoodsList.TabIndex = 260
        Me.lsv_GoodsList.UseCompatibleStateImageBehavior = False
        Me.lsv_GoodsList.View = System.Windows.Forms.View.Details
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(515, 255)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(192, 22)
        Me.txt_Search.TabIndex = 250
        '
        'btn_CourseIns
        '
        Me.btn_CourseIns.BackColor = System.Drawing.SystemColors.Control
        Me.btn_CourseIns.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_CourseIns.Location = New System.Drawing.Point(9, 9)
        Me.btn_CourseIns.Name = "btn_CourseIns"
        Me.btn_CourseIns.Size = New System.Drawing.Size(180, 50)
        Me.btn_CourseIns.TabIndex = 200
        Me.btn_CourseIns.Text = "����R�[�X�o�^"
        Me.btn_CourseIns.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(6, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(268, 16)
        Me.Label3.TabIndex = 234
        Me.Label3.Text = "�� �I���ςݕ��菤�i�ꗗ"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(402, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(228, 16)
        Me.Label5.TabIndex = 235
        Me.Label5.Text = "�� ���菤�i�ꗗ"
        '
        'btn_CourseDel
        '
        Me.btn_CourseDel.BackColor = System.Drawing.SystemColors.Control
        Me.btn_CourseDel.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_CourseDel.Location = New System.Drawing.Point(404, 9)
        Me.btn_CourseDel.Name = "btn_CourseDel"
        Me.btn_CourseDel.Size = New System.Drawing.Size(180, 50)
        Me.btn_CourseDel.TabIndex = 210
        Me.btn_CourseDel.Text = "����R�[�X�폜"
        Me.btn_CourseDel.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(-7, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(794, 1)
        Me.Label11.TabIndex = 247
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(428, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 24)
        Me.Label7.TabIndex = 244
        Me.Label7.Text = "���i����"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage20
        '
        Me.TabPage20.BackColor = System.Drawing.Color.Transparent
        Me.TabPage20.BackgroundImage = CType(resources.GetObject("TabPage20.BackgroundImage"), System.Drawing.Image)
        Me.TabPage20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage20.Controls.Add(Me.GroupBox3)
        Me.TabPage20.Controls.Add(Me.btn_Add)
        Me.TabPage20.Controls.Add(Me.btn_Dwn)
        Me.TabPage20.Controls.Add(Me.btn_Up)
        Me.TabPage20.Controls.Add(Me.btn_Fol)
        Me.TabPage20.Controls.Add(Me.grd_AdvList)
        Me.TabPage20.Controls.Add(Me.grd_ImgList)
        Me.TabPage20.Controls.Add(Me.txt_ImgPath)
        Me.TabPage20.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage20.Location = New System.Drawing.Point(4, 26)
        Me.TabPage20.Name = "TabPage20"
        Me.TabPage20.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage20.Size = New System.Drawing.Size(805, 622)
        Me.TabPage20.TabIndex = 0
        Me.TabPage20.Text = "���j���[��ʓo�^"
        Me.TabPage20.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.Add(Me.pic_ViewArea)
        Me.GroupBox3.Controls.Add(Me.btn_Del)
        Me.GroupBox3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(298, 286)
        Me.GroupBox3.TabIndex = 285
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "�I�����Ă���摜"
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
        Me.btn_Add.Location = New System.Drawing.Point(506, 224)
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
        Me.btn_Dwn.Location = New System.Drawing.Point(428, 17)
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
        Me.btn_Up.Location = New System.Drawing.Point(326, 17)
        Me.btn_Up.Name = "btn_Up"
        Me.btn_Up.Size = New System.Drawing.Size(82, 24)
        Me.btn_Up.TabIndex = 279
        Me.btn_Up.Text = "��ֈړ�"
        Me.btn_Up.UseVisualStyleBackColor = False
        '
        'btn_Fol
        '
        Me.btn_Fol.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Fol.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Fol.Location = New System.Drawing.Point(607, 17)
        Me.btn_Fol.Name = "btn_Fol"
        Me.btn_Fol.Size = New System.Drawing.Size(174, 24)
        Me.btn_Fol.TabIndex = 1
        Me.btn_Fol.Text = "�摜�t�H���_�I��"
        Me.btn_Fol.UseVisualStyleBackColor = False
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
        Me.grd_AdvList.Location = New System.Drawing.Point(326, 47)
        Me.grd_AdvList.Name = "grd_AdvList"
        Me.grd_AdvList.Size = New System.Drawing.Size(174, 570)
        Me.grd_AdvList.TabIndex = 13
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
        Me.grd_ImgList.Location = New System.Drawing.Point(609, 47)
        Me.grd_ImgList.Name = "grd_ImgList"
        Me.grd_ImgList.Size = New System.Drawing.Size(174, 570)
        Me.grd_ImgList.TabIndex = 0
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
        'txt_LastCallTime
        '
        Me.txt_LastCallTime.Location = New System.Drawing.Point(181, 73)
        Me.txt_LastCallTime.Name = "txt_LastCallTime"
        Me.txt_LastCallTime.Size = New System.Drawing.Size(100, 22)
        Me.txt_LastCallTime.TabIndex = 257
        Me.txt_LastCallTime.Text = "1"
        Me.txt_LastCallTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CNL2140
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 16)
        Me.ClientSize = New System.Drawing.Size(1016, 667)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.sts_Msg)
        Me.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL2140"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNL2140"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage20.ResumeLayout(False)
        Me.TabPage20.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.pic_ViewArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_AdvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_ImgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Structure typItemInfo
        Dim strSCPNO As String
    End Structure

    Private Structure typDrawStrImg
        Dim strWriteString As String
        Dim objFontStyle As Font
        Dim objDrawColor As System.Drawing.Brush
        Dim lngX As Long
        Dim lngY As Long
        Dim blnUndo As Boolean
    End Structure

    ' --------------------------------------------------------------------------------
    ' ���W���[�����񋓌^��`
    ' --------------------------------------------------------------------------------
    Private Enum TLBMODE
        INITMODE = 0
        ADDMODE = 1
        EDITMODE = 2
    End Enum

    ' �X�V�敪
    Private Const LC_UPDKBN_ADD As String = "ADD"
    Private Const LC_UPDKBN_DEL As String = "DEL"

    Private L_blnDMode As Boolean       ' True:�ǉ����� / False:�폜����
    Private L_strSelFile As String
    Private L_objBitmap As Bitmap
    Private L_objGraph As Graphics
    Private L_objUndo() As typDrawStrImg
    Private L_FilePrefix As String = "Fmi"

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���ǂݍ��ݎ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub CNL2140_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �t�H�[�����̐ݒ�
        '------------------------------
        Me.Text = " �H�׈��ݕ���o�^ "

        '------------------------------
        '����{�^����\����
        '------------------------------
        Me.ControlBox = False

        '------------------------------
        ' ����������
        '------------------------------
        Call GS_StatusSetup(sts_Msg)
        Call LS_FormInit()

        '------------------------------
        ' �e�摜���X�g����
        '------------------------------
        Call LS_GridSetup_1()                                               ' �I���摜���X�g
        Call LS_GridSetup_2()                                               ' ���j���[�摜���X�g

        '------------------------------
        ' �ǉ��E�폜�{�^���g�p�ېݒ�
        '------------------------------
        Call LS_SetButton(TLBMODE.INITMODE)

        '------------------------------
        ' ����R�[�X�R�s�[�{�^������/�񊈐�����
        '------------------------------
        If LF_CheckMenuNum() = False Then
            btn_CourseCopy.Enabled = False
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL2140_Load")

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�����\������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_FormInit(Optional ByVal pInitialClear As Boolean = True)

        Try
            '------------------------------
            ' �����l�ݒ�
            '------------------------------
            txt_Search.Clear()
            txt_ImgPath.Visible = False

            L_objBitmap = New Bitmap(GC_ADVPIC_W, GC_ADVPIC_H, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
            L_objGraph = Graphics.FromImage(L_objBitmap)

            '------------------------------
            ' �i�؂ꏤ�i�ꗗ������
            '------------------------------
            With lsv_CourseGoodsList
                .Clear()
                .FullRowSelect = True
                .AllowDrop = True
                .AllowColumnReorder = True
                .HideSelection = False
            End With

            '------------------------------
            ' ���i�ꗗ������
            '------------------------------
            With lsv_GoodsList
                .Clear()
                .FullRowSelect = True
                .AllowDrop = True
                .AllowColumnReorder = True
                .HideSelection = False
            End With

            '------------------------------
            ' �ꗗ����
            '------------------------------
            Call LS_SetGoodsList()

            Call LS_SetSelCourseColorCombo()         ' �F�w��R���{����
            Call LS_SetSelCourseCombo()         ' �R�[�X�w��R���{����

            '------------------------------
            ' �H�׈��ݕ���ʒm���ԕ\��
            '------------------------------
            txt_AlertTime1.Text = GF_GetAppInfo("FREE_TIME_ALERT1")
            txt_AlertTime2.Text = GF_GetAppInfo("FREE_TIME_ALERT2")

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_FormInit")

    End Sub

    ''' <summary>
    ''' ����R�[�X���i�ꗗ�\������
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LS_SetCourseGoodsList()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objItem As ListViewItem
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' �\���f�[�^�擾
        '------------------------------
        If Not LF_GetTPM160(objData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            '------------------------------
            ' ����R�[�X���i�ꗗ�ݒ�
            '------------------------------
            lsv_CourseGoodsList.Clear()
            With lsv_CourseGoodsList.Columns
                .Add("���i�ԍ�", 80, HorizontalAlignment.Center)
                .Add("���i��", 285, HorizontalAlignment.Left)
            End With

            If Not IsNothing(objData.Tables("com")) Then
                lngCnt = 0
                While lngCnt < objData.Tables("com").Rows.Count
                    If Not GF_GetRows(objData, lngCnt, objRows) Then
                        Exit Sub
                    End If

                    objItem = New ListViewItem()
                    objItem.Text = Trim$(objRows("GOODSCD"))
                    objItem.SubItems.Add(Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2")))

                    lsv_CourseGoodsList.Items.Add(objItem)
                    objItem = Nothing

                    lngCnt = lngCnt + 1
                End While
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetSoldOutGoodsList")

    End Sub

    ''' <summary>
    ''' ���i�ꗗ�\������
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LS_SetGoodsList()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim objItem As ListViewItem

        '------------------------------
        ' �ݒ�f�[�^�擾
        '------------------------------
        If Not LF_GetTPM010(objData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            '------------------------------
            ' ���i�ꗗ�ݒ�
            '------------------------------
            lsv_GoodsList.Clear()
            With lsv_GoodsList.Columns
                .Add("���i�ԍ�", 80, HorizontalAlignment.Center)
                .Add("���i��", 285, HorizontalAlignment.Left)
            End With

            If Not IsNothing(objData.Tables("com")) Then
                lngCnt = 0
                While lngCnt < objData.Tables("com").Rows.Count
                    If Not GF_GetRows(objData, lngCnt, objRows) Then
                        Exit Sub
                    End If

                    objItem = New ListViewItem()
                    objItem.Text = Trim$(objRows("GOODSCD"))
                    objItem.SubItems.Add(Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2")))

                    lsv_GoodsList.Items.Add(objItem)
                    objItem = Nothing

                    lngCnt = lngCnt + 1
                End While
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetGoodsList")

    End Sub

    ''' <summary>
    ''' [����R�[�X�폜]�{�^������������
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_CourseDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CourseDel.Click

        '------------------------------
        ' �I���`�F�b�N
        '------------------------------
        If cbo_CourseTitle.SelectedIndex = 0 Then
            Call GF_Msg("", "����R�[�X��I�����Ă��������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            cbo_CourseTitle.Select()
            Exit Sub
        End If

        If GF_Msg("", "����R�[�X���폜���܂��B" & vbCrLf & "��낵���ł����H", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            If Not LF_DellCourse() Then
                GoTo SYSTEM_ERROR
            End If

            GF_Msg("", "����R�[�X���폜���܂���", MsgBoxStyle.OkOnly)

            '------------------------------
            ' ����R�[�X�ꗗ�X�V
            '------------------------------
            Call LS_FormInit()
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Del_Click")

    End Sub

    ''' <summary>
    ''' �H�׈��ݕ���ʒm���ԃ`�F�b�N
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_ChkAlertTime() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim AlertTime1 As Integer = CInt(txt_AlertTime1.Text)
        Dim AlertTime2 As Integer = CInt(txt_AlertTime2.Text)

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_ChkAlertTime = False

        If AlertTime1 <> 0 And _
           AlertTime2 <> 0 And _
           AlertTime1 < AlertTime2 Then
            Return False
        Else
            Return True
        End If

    End Function

    ''' <summary>
    ''' ����R�[�X�폜����
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_DellCourse() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_DellCourse = False

        '------------------------------
        ' �e�[�u���폜
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE FROM TPM010"
        strSQL = strSQL & " WHERE GOODSCD = '" & GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex) & "';"

        '������@�\�Ή�
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            strSQL = strSQL & "DELETE FROM TPM010A"
            strSQL = strSQL & " WHERE GOODSCD = '" & GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex) & "';"
            strSQL = strSQL & "DELETE FROM TPM010B"
            strSQL = strSQL & " WHERE GOODSCD = '" & GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex) & "';"
            strSQL = strSQL & "DELETE FROM TPM010C"
            strSQL = strSQL & " WHERE GOODSCD = '" & GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex) & "';"
        End If

        strSQL = strSQL & "DELETE FROM TPM160"
        strSQL = strSQL & " WHERE FREECOURSEGOODSCD = '" & GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex) & "';"
        strSQL = strSQL & "DELETE FROM TPM170"
        strSQL = strSQL & " WHERE FREECOURSEGOODSCD = '" & GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex) & "';"
        strSQL = strSQL & "DELETE FROM TPM300"
        strSQL = strSQL & " WHERE FREECOURSEGOODSCD = '" & GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex) & "';"
        strSQL = strSQL & "DELETE FROM TPM200"
        strSQL = strSQL & " WHERE GOODSCD = '" & GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex) & "';"
        strSQL = strSQL & "DELETE FROM TPM330"
        strSQL = strSQL & " WHERE GOODSCD = '" & GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex) & "';"
        strSQL = strSQL & "DELETE FROM TPM340"
        strSQL = strSQL & " WHERE GOODSCD = '" & GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex) & "';"
        strSQL = strSQL & "DELETE FROM TPM350"
        strSQL = strSQL & " WHERE GOODSCD = '" & GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex) & "'"


        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_DellCourse = True

    End Function

    ''' <summary>
    ''' ���莞�ԓo�^����
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_UpdTPM170(ByVal pCourseGoodsCD As String, ByVal pFreetime As Integer, ByVal pColor As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM170 = False

        '------------------------------
        ' �i�؂���Ǘ��e�[�u���폜
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM170"
        strSQL = strSQL & " SET FREETIME    = " & pFreetime.ToString
        strSQL = strSQL & " ,   FREEGROUPID = '" & pColor.Trim & "' "
        strSQL = strSQL & " WHERE FREECOURSEGOODSCD = '" & pCourseGoodsCD & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM170 = True

    End Function

    ''' <summary>
    ''' ���X�g�I�[�_�[���ԓo�^����
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_UpdTPM300(ByVal pCourseGoodsCD As String, ByVal pLastCalltime As Integer) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM300 = False

        '------------------------------
        ' �i�؂���Ǘ��e�[�u���폜
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM300"
        strSQL = strSQL & " SET LASTCALLTIME    = " & pLastCalltime.ToString
        strSQL = strSQL & " WHERE FREECOURSEGOODSCD = '" & pCourseGoodsCD & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM300 = True

    End Function

    ''' <summary>
    ''' �H�׈��ݕ���ʒm���ԓo�^����
    ''' </summary>
    ''' <param name="pNum">1:���ځA2:����</param>
    ''' <param name="pAlerttime">�ʒm����</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_UpdTPM090(ByVal pNum As String, ByVal pAlerttime As Integer) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM090 = False

        '------------------------------
        ' �i�؂���Ǘ��e�[�u���폜
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM090"
        strSQL = strSQL & " SET APVALUE    = " & pAlerttime.ToString
        strSQL = strSQL & " ,   UPDID       = 'CNL2140' "
        strSQL = strSQL & " ,   UPDYMD      = '" & Now & "' "
        strSQL = strSQL & " WHERE APKEY = 'FREE_TIME_ALERT" & pNum & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM090 = True

    End Function

    ''' <summary>
    ''' �H�׈��ݕ��菤�i�}�X�^�擾����(�H�׈��ݕ��菤�i�ꗗ)
    ''' </summary>
    ''' <param name="pData"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_GetTPM160(ByRef pData As DataSet) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM160 = False

        '------------------------------
        ' ���i�}�X�^�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2"
        strSQL = strSQL & "  FROM TPM010,"
        strSQL = strSQL & "       TPM160"
        strSQL = strSQL & " WHERE TPM010.GOODSCD = TPM160.FREEGOODSCD"
        strSQL = strSQL & " AND   TPM160.FREECOURSEGOODSCD = '" & GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex) & "'"
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetTPM160 = True

    End Function

    ''' <summary>
    ''' ���i�}�X�^�擾����(���i�ꗗ)
    ''' </summary>
    ''' <param name="pData"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_GetTPM010(ByRef pData As DataSet) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM010 = False

        '------------------------------
        ' ���i�}�X�^�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT GOODSCD,"
        strSQL = strSQL & "       GOODSNMJ,"
        strSQL = strSQL & "       GOODSNMJ2"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " WHERE STATUS  = '0'"
        strSQL = strSQL & "   AND SELLFLG = '0'"
        strSQL = strSQL & "   AND GOODSKIND <> '3'"

        If Len(Trim$(txt_Search.Text)) <> 0 Then
            strSQL = strSQL & "   AND GOODSNMJ LIKE '%" & Trim$(txt_Search.Text) & "%'"
        End If
        strSQL = strSQL & " ORDER BY GOODSCD"

        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetTPM010 = True

    End Function

    ''' <summary>
    ''' ���莞�ԁA�F�擾
    ''' </summary>
    ''' <param name="pFreetime"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_GetFreetime(ByRef pFreetime As Integer, ByRef pColor As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetFreetime = False

        '------------------------------
        ' ���i�}�X�^�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT FREETIME,FREEGROUPID"
        strSQL = strSQL & "  FROM TPM170"
        strSQL = strSQL & " WHERE FREECOURSEGOODSCD = '" & GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex) & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If GF_GetRows(objData, 0, objRows) = False Then
            Exit Function
        End If

        pFreetime = CInt(Trim$(objRows("FREETIME")))
        pColor = objRows("FREEGROUPID").ToString.Trim

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetFreetime = True

    End Function

    ' ���X�g�I�[�_�[���Ԏ擾
    Private Function LF_GetLastCallTime(ByRef pLastCallTime As Integer) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetLastCallTime = False

        '------------------------------
        ' ���i�}�X�^�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT LASTCALLTIME"
        strSQL = strSQL & "  FROM TPM300"
        strSQL = strSQL & " WHERE FREECOURSEGOODSCD = '" & GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex) & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If GF_GetRows(objData, 0, objRows) = False Then
            Exit Function
        End If

        pLastCallTime = CInt(Trim$(objRows("LASTCALLTIME")))

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetLastCallTime = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F����{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click

        Me.Close()

    End Sub

    ''' <summary>
    ''' ���i�d���`�F�b�N
    ''' </summary>
    ''' <param name="pGoodsCD"></param>
    ''' <param name="pExists"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_GetTPM160_2(ByVal pGoodsCD As String, ByVal pCourseGoodsCD As String, ByRef pExists As Boolean) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM160_2 = False
        pExists = False

        strSQL = ""
        strSQL = strSQL & "SELECT FREEGOODSCD"
        strSQL = strSQL & "  FROM TPM160"
        strSQL = strSQL & " WHERE FREECOURSEGOODSCD = '" & pCourseGoodsCD & "'"
        strSQL = strSQL & " AND   FREEGOODSCD = '" & pGoodsCD & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            pExists = False
        Else
            pExists = True
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetTPM160_2 = True

    End Function

    ''' <summary>
    ''' �H�׈��ݕ��菤�i�}�X�^�X�V����(�ǉ�/�폜����)
    ''' </summary>
    ''' <param name="pUpdKbn"></param>
    ''' <param name="pGoodsCD"></param>
    ''' <param name="pCourseGoodsCD"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_UpdTPM160(ByVal pUpdKbn As String, ByVal pGoodsCD As String, ByVal pCourseGoodsCD As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM160 = False

        strSQL = ""
        Select Case pUpdKbn
            Case LC_UPDKBN_ADD
                strSQL = strSQL & "INSERT INTO TPM160 VALUES("
                strSQL = strSQL & "'" & pCourseGoodsCD & "',"
                strSQL = strSQL & "'" & pGoodsCD & "',"
                strSQL = strSQL & "'" & GC_UPDID & "',"
                strSQL = strSQL & "'" & Now & "'"
                strSQL = strSQL & ")"

            Case LC_UPDKBN_DEL
                strSQL = strSQL & "DELETE FROM TPM160"
                strSQL = strSQL & " WHERE FREECOURSEGOODSCD = '" & pCourseGoodsCD & "'"
                strSQL = strSQL & " AND   FREEGOODSCD = '" & pGoodsCD & "'"

            Case Else
                Exit Function

        End Select

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM160 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�o�^�ς݃R�����g�I�v�V�����h���b�O�h���b�v����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SoldOutList_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_CourseGoodsList.ItemDrag

        '------------------------------
        ' �h���b�O�����J�n
        '------------------------------
        L_blnDMode = False
        lsv_CourseGoodsList.DoDragDrop(lsv_CourseGoodsList.SelectedItems, DragDropEffects.Copy)

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�o�^�ς݃R�����g�I�v�V�����h���b�O�h���b�v����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SoldOutList_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_CourseGoodsList.DragEnter

        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�o�^�ς݃R�����g�I�v�V�����h���b�O�h���b�v����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SoldOutList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_CourseGoodsList.DragDrop

        If L_blnDMode = False Then
            Exit Sub
        End If

        If Not e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then
            Exit Sub
        End If

        Call LS_AddItems(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�R�����g�I�v�V�����ꗗ�h���b�O�h���b�v����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub lsv_GoodsList_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_GoodsList.ItemDrag

        '------------------------------
        ' �h���b�O�����J�n
        '------------------------------
        L_blnDMode = True
        lsv_CourseGoodsList.DoDragDrop(lsv_GoodsList.SelectedItems, DragDropEffects.Copy)

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�R�����g�I�v�V�����ꗗ�h���b�O�h���b�v����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub lsv_GoodsList_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_GoodsList.DragEnter

        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�R�����g�I�v�V�����ꗗ�h���b�O�h���b�v����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub lsv_GoodsList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_GoodsList.DragDrop

        If L_blnDMode = True Then
            Exit Sub
        End If

        If Not e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then
            Exit Sub
        End If

        Call LS_RemoveItems(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�R�����g�I�v�V�����ǉ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_AddItems(ByVal pTargetData As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngCnt As Integer
        Dim blnExists As Boolean
        Dim CourseGoodsCD As String

        If pTargetData.Count = 0 Then
            Exit Sub
        End If

        If cbo_CourseTitle.SelectedIndex = 0 Then
            Call GF_Msg("", "����R�[�X��I�����Ă��������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            cbo_CourseTitle.Select()
            Exit Sub
        End If

        CourseGoodsCD = GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex)

        lngCnt = 0
        While lngCnt < pTargetData.Count
            '------------------------------
            ' ���i�d���`�F�b�N
            '------------------------------
            If Not LF_GetTPM160_2(pTargetData.Item(lngCnt).Text, CourseGoodsCD, _
                                  blnExists) Then
                GoTo SYSTEM_ERROR
            End If

            If Not blnExists Then
                '------------------------------
                ' �c�a�X�V����
                '------------------------------
                If Not LF_UpdTPM160(LC_UPDKBN_ADD, _
                                    Trim$(pTargetData.Item(lngCnt).Text), CourseGoodsCD) Then
                    GoTo SYSTEM_ERROR
                End If

            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' �i�؂ꏤ�i�ꗗ�X�V
        '------------------------------
        Call LS_SetCourseGoodsList()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AddItems")

    End Sub

    ''' <summary>
    ''' ����R�[�X���i��������
    ''' </summary>
    ''' <param name="pTargetData"></param>
    ''' <remarks></remarks>
    Private Sub LS_RemoveItems(ByVal pTargetData As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngCnt As Integer
        Dim CourseGoodsCD As String

        If pTargetData.Count = 0 Then
            Exit Sub
        End If

        CourseGoodsCD = GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex)

        lngCnt = 0
        While lngCnt < pTargetData.Count
            '------------------------------
            ' �c�a�X�V����
            '------------------------------
            If Not LF_UpdTPM160(LC_UPDKBN_DEL, _
                                Trim$(pTargetData.Item(lngCnt).Text), CourseGoodsCD) Then
                GoTo SYSTEM_ERROR
            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' �i�؂ꏤ�i�ꗗ�X�V
        '------------------------------
        Call LS_SetCourseGoodsList()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_RemoveItems")

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�R�����g�I�v�V�������̌����e�L�X�g�{�b�N�X�� Enter�L�[����������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub txt_Search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Search.KeyDown

        If e.KeyCode = Keys.Enter Then
            Call LS_SetGoodsList()
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�R�����g�I�v�V�������̌����e�L�X�g�{�b�N�X���͎�����
    ' �@�@�\�T�v�F���͒��ɂ��āA���̍��ڒ�(20�o�C�g)�Ő������s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub txt_Search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Search.TextChanged

        If txt_Search.Modified = False Then
            Exit Sub
        End If

        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(txt_Search.Text) > 20 Then
            txt_Search.Text = GF_MidB(txt_Search.Text, 1, 20)
            txt_Search.SelectionStart = GF_LenB(txt_Search.Text)
            Exit Sub
        End If

        Call LS_SetGoodsList()

    End Sub

    ''' <summary>
    ''' ����R�[�X�o�^�{�^������������
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_Ins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CourseIns.Click
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As Form = Nothing

        objForm = New CNL2141()

        objForm.ShowDialog()

        Select Case objForm.DialogResult
            Case DialogResult.OK
                Call LS_FormInit()
            Case DialogResult.Cancel
                ' �������Ȃ�
            Case Else
                GoTo SYSTEM_ERROR
        End Select
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Ins_Click")
    End Sub

    ''' <summary>
    ''' ����R�[�X�R�s�[�{�^������������
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CourseCopy.Click
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As Form = Nothing

        objForm = New CNL2142()

        objForm.ShowDialog()

        Select Case objForm.DialogResult
            Case DialogResult.OK
                Call LS_FormInit()
            Case DialogResult.Cancel
                ' �������Ȃ�
            Case Else
                GoTo SYSTEM_ERROR
        End Select
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Copy_Click")
    End Sub

    ''' <summary>
    ''' ����R�[�X�I����
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbo_CourseTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_CourseTitle.SelectedIndexChanged

        If cbo_CourseTitle.SelectedIndex <> 0 Then
            Dim Freetime As Integer
            Dim Color As String = ""
            Dim LastCallTime As Integer

            If Not LF_GetFreetime(Freetime, Color) Then
                Call GS_ErrorTerm("cbo_CourseTitle_SelectedIndexChanged")
                Exit Sub
            End If

            If Not LF_GetLastCallTime(LastCallTime) Then
                Call GS_ErrorTerm("cbo_CourseTitle_SelectedIndexChanged - 2")
                Exit Sub
            End If

            txt_CourseTime.Enabled = True
            txt_CourseTime.Text = Freetime.ToString
            cbo_CourseColor.Enabled = True
            cbo_CourseColor.SelectedValue = Color
            txt_LastCallTime.Enabled = True
            txt_LastCallTime.Text = LastCallTime

        Else
            txt_CourseTime.Enabled = False
            txt_CourseTime.Text = "0"
            cbo_CourseColor.Enabled = False
            cbo_CourseColor.SelectedIndex = 0
            txt_LastCallTime.Enabled = False
            txt_LastCallTime.Text = 1
        End If

        Call LS_SetCourseGoodsList()
    End Sub

    ''' <summary>
    ''' ���莞�ԕύX��
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txt_CourseTime_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CourseTime.Leave
        If cbo_CourseTitle.SelectedIndex = -1 Then
            Exit Sub
        End If
        If cbo_CourseTitle.SelectedIndex <> 0 Then

            If Not LF_UpdTPM170(GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex), CInt(txt_CourseTime.Text), cbo_CourseColor.SelectedValue) Then
                Call GS_ErrorTerm("txt_CourseTime_TextChanged")
                Exit Sub
            End If

        Else
            Call GF_Msg("", "����R�[�X��I�����Ă��������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub

    ''' <summary>
    ''' ���X�g�I�[�_�[���ԕύX��
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txt_LastCallTime_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_LastCallTime.Leave
        If cbo_CourseTitle.SelectedIndex = -1 Then
            Exit Sub
        End If
        If cbo_CourseTitle.SelectedIndex <> 0 Then

            If Not LF_UpdTPM300(GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex), CInt(txt_LastCallTime.Text)) Then
                Call GS_ErrorTerm("txt_LastCallTime_TextChanged")
                Exit Sub
            End If

        Else
            Call GF_Msg("", "����R�[�X��I�����Ă��������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub

    ''' <summary>
    ''' �F�I����
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbo_CourseColor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_CourseColor.Leave
        If cbo_CourseTitle.SelectedIndex = -1 Then
            Exit Sub
        End If
        If cbo_CourseTitle.SelectedIndex <> 0 Then

            If Not LF_UpdTPM170(GF_CboGetCode(cbo_CourseTitle, cbo_CourseTitle.SelectedIndex), CInt(txt_CourseTime.Text), cbo_CourseColor.SelectedValue) Then
                Call GS_ErrorTerm("cbo_CourseColor_Leave")
                Exit Sub
            End If

        Else
            Call GF_Msg("", "����R�[�X��I�����Ă��������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub

    ''' <summary>
    ''' �H�׈��ݕ���ʒm���ԂP
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txt_AlertTime1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_AlertTime1.Leave

        If Not LF_ChkAlertTime() Then
            Call GF_Msg("", "���ڂɒʒm���鎞�Ԃ͓��ڈȑO�̎��Ԃ��w�肵�Ă��������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            txt_AlertTime1.Select()
            txt_AlertTime1.Text = GF_GetAppInfo("FREE_TIME_ALERT1")
            Exit Sub
        End If

        If Not LF_UpdTPM090("1", CInt(txt_AlertTime1.Text)) Then
            Call GS_ErrorTerm("txt_AlertTime1_Leave")
        End If

    End Sub

    ''' <summary>
    ''' �H�׈��ݕ���ʒm���ԂQ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txt_AlertTime2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_AlertTime2.Leave

        If Not LF_ChkAlertTime() Then
            Call GF_Msg("", "���ڂɒʒm���鎞�Ԃ͓��ڈȑO�̎��Ԃ��w�肵�Ă��������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            txt_AlertTime2.Text = GF_GetAppInfo("FREE_TIME_ALERT2")
            txt_AlertTime2.Select()
            Exit Sub
        End If

        If Not LF_UpdTPM090("2", CInt(txt_AlertTime2.Text)) Then
            Call GS_ErrorTerm("txt_AlertTime2_Leave")
        End If

    End Sub

    ''' <summary>
    ''' ���莞�ԓ��͐���
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txt_CourseTime_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_AlertTime1.TextChanged, txt_AlertTime2.TextChanged, txt_CourseTime.TextChanged

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngST As Long
        Dim wkTextbox As TextBox

        If txt_CourseTime.Modified = True Then
            wkTextbox = txt_CourseTime
        ElseIf txt_AlertTime1.Modified = True Then
            wkTextbox = txt_AlertTime1
        ElseIf txt_AlertTime2.Modified = True Then
            wkTextbox = txt_AlertTime2
        Else
            Exit Sub
        End If

        lngST = wkTextbox.SelectionStart
        If lngST >= 0 Then
            wkTextbox.SelectionStart = lngST
        End If

        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(wkTextbox.Text) > 3 Then
            wkTextbox.Text = GF_MidB(wkTextbox.Text, 1, 3)
            wkTextbox.SelectionStart = GF_LenB(wkTextbox.Text)
        End If

        If Len(Trim$(wkTextbox.Text)) = 0 Then
            wkTextbox.Text = "0"
        End If

        If IsNumeric(Trim$(wkTextbox.Text)) = False Then
            wkTextbox.Text = "0"
        End If

    End Sub

    ''' <summary>
    ''' ���莞�ԓ��͐���
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txt_LastCallTime_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_LastCallTime.TextChanged

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngST As Long
        Dim wkTextbox As TextBox

        If txt_LastCallTime.Modified = True Then
            wkTextbox = txt_LastCallTime
        Else
            Exit Sub
        End If

        lngST = wkTextbox.SelectionStart
        If lngST >= 0 Then
            wkTextbox.SelectionStart = lngST
        End If

        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(wkTextbox.Text) > 3 Then
            wkTextbox.Text = GF_MidB(wkTextbox.Text, 1, 3)
            wkTextbox.SelectionStart = GF_LenB(wkTextbox.Text)
        End If

        If Trim$(wkTextbox.Text) = "0" Then
            wkTextbox.Text = "1"
        End If

        If Len(Trim$(wkTextbox.Text)) = 0 Then
            wkTextbox.Text = "1"
        End If

        If IsNumeric(Trim$(wkTextbox.Text)) = False Then
            wkTextbox.Text = "1"
        End If

    End Sub

    ''' <summary>
    ''' �t�H���_�I���{�^��
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
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
            Call GS_ErrorTerm("btn_Fol_Click")
        End Try

    End Sub

    ''' <summary>
    ''' �摜�ҏW�� �ĕ`�掞����(�摜�I����)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub pic_ViewArea_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pic_ViewArea.Paint
        e.Graphics.DrawImage(L_objBitmap, 0, 0, pic_ViewArea.Width, pic_ViewArea.Height)
    End Sub

    ''' <summary>
    ''' �I���摜�ꗗ�J�����g�Z���ʒu�ω�������
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grd_ImgList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_ImgList.Click
        Call LS_PictureSelect(grd_ImgList, TLBMODE.ADDMODE)
    End Sub

    ''' <summary>
    ''' ���j���[�摜�ꗗ�J�����g�Z���ʒu�ω�������
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grd_AdvList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_AdvList.Click
        Call LS_PictureSelect(grd_AdvList, TLBMODE.EDITMODE)
    End Sub

    ''' <summary>
    ''' �u�ǉ��v�{�^������������
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click

        '------------------------------
        ' �ҏW�摜�ǉ�����
        '------------------------------
        Call LS_AdvImgAdd()

    End Sub

    ''' <summary>
    ''' �u�폜�v�{�^������������
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Del.Click

        '------------------------------
        ' �ҏW�摜��������
        '------------------------------
        Call LS_AdvImgDel()

    End Sub

    ''' <summary>
    ''' �u��ֈړ��v�{�^������������
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_Up_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Up.Click

        Call LS_ChgRank(True)

    End Sub

    ''' <summary>
    ''' �u���ֈړ��v�{�^������������
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_Dwn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Dwn.Click

        Call LS_ChgRank(False)

    End Sub

    ''' <summary>
    ''' �摜�ꗗ �\�����ʕύX����
    ''' </summary>
    ''' <param name="pProcKbn"></param>
    ''' <remarks></remarks>
    Private Sub LS_ChgRank(ByVal pProcKbn As Boolean)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCell As DataGridCell
        Dim strPath1 As String
        Dim strPath2 As String

        Dim strNewPath1 As String
        Dim strNewPath2 As String

        Dim strFileNo1 As String
        Dim strFileNo2 As String
        'Dim strPathwk As String = GF_GetAppInfo("FREEMENU_PATH") & "\" & Format$(Now, "yyyyMMddHHmmss") & ".bak"
        'Dim strDispOrder As String
        Dim FREEMENU_PATH As String = GF_GetAppInfo("FREEMENU_PATH")

        Try
            '------------------------------
            ' �����l�ݒ�
            '------------------------------
            objCell = grd_AdvList.CurrentCell                                   ' �J�����g�Z���ʒu�擾
            strPath1 = grd_AdvList(objCell.RowNumber, 0)
            strFileNo1 = grd_AdvList(objCell.RowNumber, 2)

            ' �I�����ꂽ�t�@�C���̏����A�Ԏ擾
            Dim strFileNm As String = Path.GetFileNameWithoutExtension(strPath1)
            Dim intFileNo As Integer = CInt(strFileNm.Replace(L_FilePrefix, "").Split("_")(0))

            If pProcKbn Then                                                    ' �����敪�ɂ��A�����֎~�ʒu����
                If objCell.RowNumber <= 0 Then
                    Exit Sub
                End If

                objCell.RowNumber = objCell.RowNumber - 1

                strFileNo2 = grd_AdvList(objCell.RowNumber, 2)
                strPath2 = grd_AdvList(objCell.RowNumber, 0)
            Else
                Dim strPath As String = GF_GetAppInfo("FREEMENU_PATH")
                Dim strFiles As String() = Directory.GetFiles(strPath)

                If objCell.RowNumber >= (strFiles.Length - 1) Then
                    Exit Sub
                End If

                objCell.RowNumber = objCell.RowNumber + 1

                strFileNo2 = grd_AdvList(objCell.RowNumber, 2)
                strPath2 = grd_AdvList(objCell.RowNumber, 0)
            End If

            '�I���t�@�C�����ړ���
            strNewPath1 = FREEMENU_PATH & "\" & L_FilePrefix & strFileNo2 & "_" & Format$(Now, "yyyyMMddHHmmss") & Path.GetExtension(strPath1)
            File.Move(strPath1, strNewPath1)

            '�ړ���t�@�C�����I���t�@�C���̃|�W�V����
            strNewPath2 = FREEMENU_PATH & "\" & L_FilePrefix & strFileNo1 & "_" & Format$(Now, "yyyyMMddHHmmss") & Path.GetExtension(strPath2)
            File.Move(strPath2, strNewPath2)

            ''���t�@�C���폜
            'File.Delete(strPath1)
            'File.Delete(strPath2)

            Call LS_GridSetup_2()

            grd_AdvList.CurrentCell = objCell
        Catch
            Call GS_ErrorTerm("LS_ChgRank")
        End Try

    End Sub

    ''' <summary>
    ''' ���j���[�摜�폜����
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LS_AdvImgDel()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strPath As String
        Dim strDispOrder As String
        Dim objCell As DataGridCell
        Dim objRow As DataRow = Nothing

        '------------------------------
        ' ���O���擾
        '------------------------------
        Try
            objCell = grd_AdvList.CurrentCell
            strPath = grd_AdvList(objCell.RowNumber, 0)
            strDispOrder = grd_AdvList(objCell.RowNumber, 2)
        Catch
            GoTo SYSTEM_ERROR
        End Try

        '------------------------------
        ' ���݃`�F�b�N
        '------------------------------
        If Not File.Exists(strPath) Then
            Call GF_Msg("", "���ɍ폜����Ă��܂��B", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
        End If

        ' �t�@�C���폜
        File.Delete(strPath)

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

    Private Sub LS_PictureSelect(ByVal pGridObj As DataGrid, ByVal pSelMode As TLBMODE)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCell As DataGridCell
        Dim strFile As String
        Dim objFileSys As FileStream

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

        objFileSys = New FileStream(strFile, IO.FileMode.Open, IO.FileAccess.Read)
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

    ''' <summary>
    ''' ����R�[�X�w��R���{��������
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LS_SetSelCourseCombo()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String = Nothing
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strWork As String = Nothing

        '------------------------------
        ' �S���i�O���[�v���擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT S.GOODSCD, S.GOODSNMJ + S.GOODSNMJ2 AS NM "
        strSQL = strSQL & "FROM TPM010 S,TPM170 C "
        strSQL = strSQL & "WHERE S.GOODSCD = C.FREECOURSEGOODSCD "
        strSQL = strSQL & "ORDER BY S.GOODSCD "

        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �R���{�{�b�N�X�ݒ�
        '------------------------------
        Try
            cbo_CourseTitle.DropDownStyle = ComboBoxStyle.DropDownList

            cbo_CourseTitle.Items.Clear()

            Call GS_CboItemSet(cbo_CourseTitle, "---", "0000")

            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    GoTo SYSTEM_ERROR
                End If

                Call GS_CboItemSet(cbo_CourseTitle, Trim$(objRows("NM")), Trim$(objRows("GOODSCD")))

                lngCnt = lngCnt + 1
            End While

            cbo_CourseTitle.SelectedIndex = 0
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetSelCourseCombo")
    End Sub

    ''' <summary>
    ''' ����R�[�X�w��R���{��������
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LS_SetSelCourseColorCombo()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String = Nothing
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim strWork As String = Nothing

        '------------------------------
        ' �S���i�O���[�v���擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT "
        strSQL = strSQL & "    COLORCD, "
        strSQL = strSQL & "    COLORNM "
        strSQL = strSQL & "FROM "
        strSQL = strSQL & "    TPM220 "
        strSQL = strSQL & "ORDER BY "
        strSQL = strSQL & "    COLORCD "

        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �R���{�{�b�N�X�ݒ�
        '------------------------------
        Try
            cbo_CourseColor.DropDownStyle = ComboBoxStyle.DropDownList

            'cbo_CourseColor.Items.Clear()

            cbo_CourseColor.DataSource = objData.Tables("com")

            cbo_CourseColor.DisplayMember = "COLORNM"
            cbo_CourseColor.ValueMember = "COLORCD"

            cbo_CourseColor.SelectedIndex = 0
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetSelCourseColorCombo")
    End Sub

    ''' <summary>
    ''' �I���摜�ꗗ�O���b�h �Z�b�g�A�b�v����
    ''' </summary>
    ''' <remarks></remarks>
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
            If Directory.Exists(txt_ImgPath.Text) Then
                For Each strFile In Directory.GetFiles(txt_ImgPath.Text, "*.jpg")
                    dtrRows = objTable.NewRow
                    dtrRows(udtGridCol(0).strMapName) = strFile
                    objTable.Rows.Add(dtrRows)
                    lngCnt = lngCnt + 1
                Next
            End If
        Catch
            Call GS_ErrorTerm("LS_GridSetup_1")
        End Try

        dtsList.Tables.Add(objTable)                                        ' �e�[�u����DataSet�ɒǉ�����
        grd_ImgList.SetDataBinding(dtsList, "IMAGELIST2")                   ' DataSet�ƃe�[�u����DataGrid�ɐڑ�����

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
        Dim dtrRows As DataRow = Nothing
        Dim dtrData As DataRow = Nothing
        Dim dtsList As DataSet
        Dim objTable As DataTable

        '------------------------------
        ' �\���f�[�^�擾����
        '------------------------------
        Dim strPath As String = GF_GetAppInfo("FREEMENU_PATH")
        Dim strFiles As String() = Directory.GetFiles(strPath)

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
            .strHeadText = "���j���[�摜"
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
            For Each strFile As String In strFiles
                dtrRows = objTable.NewRow
                dtrRows(udtGridCol(0).strMapName) = strFile
                dtrRows(udtGridCol(1).strMapName) = Path.GetFileNameWithoutExtension(strFile)
                dtrRows(udtGridCol(2).strMapName) = dtrRows(udtGridCol(1).strMapName).Replace(L_FilePrefix, "").ToString.Split("_")(0)
                objTable.Rows.Add(dtrRows)
                lngCnt = lngCnt + 1
            Next
        Catch
            GoTo SYSTEM_ERROR
        End Try

        dtsList.Tables.Add(objTable)                                        ' �e�[�u����DataSet�ɒǉ�����
        grd_AdvList.SetDataBinding(dtsList, "IMAGELIST3")                   ' DataSet�ƃe�[�u����DataGrid�ɐڑ�����

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GridSetup_2")
    End Sub

    ''' <summary>
    ''' �摜�ǉ�����
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LS_AdvImgAdd()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strFileNo As String
        Dim objCell As DataGridCell

        Try
            '------------------------------
            ' �摜�ۑ�����
            '------------------------------
            Dim strPath As String = GF_GetAppInfo("FREEMENU_PATH")
            Dim strFiles As String() = Directory.GetFiles(strPath)

            If strFiles.Length = 0 Then
                strFileNo = CStr(1).PadLeft(5, "0")
            Else
                Dim wkStr As String() = Path.GetFileNameWithoutExtension(strFiles(strFiles.Length - 1)).Split("_")
                Dim strFileNm As String = wkStr(0)
                Dim intFileNo As Integer = CInt(strFileNm.Replace(L_FilePrefix, ""))

                strFileNo = CStr(intFileNo + 1).PadLeft(5, "0")
            End If

            If Not LF_SaveImage(L_FilePrefix, strFileNo) Then
                GoTo SYSTEM_ERROR
            End If

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

    ''' <summary>
    ''' ���j���[�摜�ۑ�����
    ''' </summary>
    ''' <param name="pAdvGrpID"></param>
    ''' <param name="pAdvID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
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
            ext = Path.GetExtension(ext).ToLower()

            '------------------------------
            ' �ۑ�����
            '------------------------------
            Dim saveName As String
            saveName = Path.ChangeExtension(GF_GetAppInfo("FREEMENU_PATH") & "\" & pAdvGrpID & pAdvID & "_" & Format$(Now, "yyyyMMddHHmmss"), ext)
            L_objBitmap.Save(saveName, myImageCodecInfo, myEncoderParameters)

        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_SaveImage = True

    End Function

    ''' <summary>
    ''' ����R�[�X�R�s�[�{�^������/�񊈐�����i�P���ȏ�o�^�ς݁FTrue �o�^�����FFalse�j
    ''' </summary>
    ''' <remarks></remarks>
    Private Function LF_CheckMenuNum() As Boolean

        LF_CheckMenuNum = False

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String = Nothing
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim strWork As String = Nothing

        '------------------------------
        ' �S���i�O���[�v���擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM TPM170"

        If Not GF_GetData(strSQL, objData) Then
            Call GS_ErrorTerm("LF_CheckMenuNum")
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        LF_CheckMenuNum = True

    End Function
End Class
