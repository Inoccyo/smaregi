Public Class CNL1710
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
    Friend WithEvents grd_ImgList As System.Windows.Forms.DataGrid
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents tlb_Btn2 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Column1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsv_Grp As System.Windows.Forms.ListView
    Friend WithEvents PicImage As System.Windows.Forms.PictureBox
    Friend WithEvents lab_a As System.Windows.Forms.Label
    Friend WithEvents Pos24 As System.Windows.Forms.Label
    Friend WithEvents Pos23 As System.Windows.Forms.Label
    Friend WithEvents Pos22 As System.Windows.Forms.Label
    Friend WithEvents Pos21 As System.Windows.Forms.Label
    Friend WithEvents Pos30 As System.Windows.Forms.Label
    Friend WithEvents Pos29 As System.Windows.Forms.Label
    Friend WithEvents Pos28 As System.Windows.Forms.Label
    Friend WithEvents Pos27 As System.Windows.Forms.Label
    Friend WithEvents Pos26 As System.Windows.Forms.Label
    Friend WithEvents Pos25 As System.Windows.Forms.Label
    Friend WithEvents Pos40 As System.Windows.Forms.Label
    Friend WithEvents Pos39 As System.Windows.Forms.Label
    Friend WithEvents Pos38 As System.Windows.Forms.Label
    Friend WithEvents Pos37 As System.Windows.Forms.Label
    Friend WithEvents Pos36 As System.Windows.Forms.Label
    Friend WithEvents Pos35 As System.Windows.Forms.Label
    Friend WithEvents Pos34 As System.Windows.Forms.Label
    Friend WithEvents Pos33 As System.Windows.Forms.Label
    Friend WithEvents Pos32 As System.Windows.Forms.Label
    Friend WithEvents Pos31 As System.Windows.Forms.Label
    Friend WithEvents Pos50 As System.Windows.Forms.Label
    Friend WithEvents Pos49 As System.Windows.Forms.Label
    Friend WithEvents Pos48 As System.Windows.Forms.Label
    Friend WithEvents Pos47 As System.Windows.Forms.Label
    Friend WithEvents Pos46 As System.Windows.Forms.Label
    Friend WithEvents Pos45 As System.Windows.Forms.Label
    Friend WithEvents Pos44 As System.Windows.Forms.Label
    Friend WithEvents Pos43 As System.Windows.Forms.Label
    Friend WithEvents Pos42 As System.Windows.Forms.Label
    Friend WithEvents Pos41 As System.Windows.Forms.Label
    Friend WithEvents Pos59 As System.Windows.Forms.Label
    Friend WithEvents Pos58 As System.Windows.Forms.Label
    Friend WithEvents Pos57 As System.Windows.Forms.Label
    Friend WithEvents Pos56 As System.Windows.Forms.Label
    Friend WithEvents Pos55 As System.Windows.Forms.Label
    Friend WithEvents Pos54 As System.Windows.Forms.Label
    Friend WithEvents Pos53 As System.Windows.Forms.Label
    Friend WithEvents Pos52 As System.Windows.Forms.Label
    Friend WithEvents Pos51 As System.Windows.Forms.Label
    Friend WithEvents cmb_MenuCD As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Menu As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Select As System.Windows.Forms.Label
    Friend WithEvents Pos0 As System.Windows.Forms.Label
    Friend WithEvents Pos1 As System.Windows.Forms.Label
    Friend WithEvents Pos2 As System.Windows.Forms.Label
    Friend WithEvents Pos3 As System.Windows.Forms.Label
    Friend WithEvents Pos4 As System.Windows.Forms.Label
    Friend WithEvents Pos5 As System.Windows.Forms.Label
    Friend WithEvents Pos11 As System.Windows.Forms.Label
    Friend WithEvents Pos10 As System.Windows.Forms.Label
    Friend WithEvents Pos9 As System.Windows.Forms.Label
    Friend WithEvents Pos8 As System.Windows.Forms.Label
    Friend WithEvents Pos7 As System.Windows.Forms.Label
    Friend WithEvents Pos6 As System.Windows.Forms.Label
    Friend WithEvents Pos17 As System.Windows.Forms.Label
    Friend WithEvents Pos16 As System.Windows.Forms.Label
    Friend WithEvents Pos15 As System.Windows.Forms.Label
    Friend WithEvents Pos14 As System.Windows.Forms.Label
    Friend WithEvents Pos13 As System.Windows.Forms.Label
    Friend WithEvents Pos12 As System.Windows.Forms.Label
    Friend WithEvents Pos19 As System.Windows.Forms.Label
    Friend WithEvents Pos18 As System.Windows.Forms.Label
    Friend WithEvents Pos20 As System.Windows.Forms.Label
    Friend WithEvents txt_ImgPath As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CNL1710))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "�\�t�g�h�����N", System.Drawing.SystemColors.WindowText, System.Drawing.Color.Red, New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "�ԐF")}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "�E�C�X�L�[", System.Drawing.SystemColors.WindowText, System.Drawing.Color.Aqua, New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "����", System.Drawing.SystemColors.WindowText, System.Drawing.Color.Silver, New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "�r�[��", System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte)), New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "�J�N�e��", System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(255, Byte)), New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, -1)
        Me.Pos0 = New System.Windows.Forms.Label()
        Me.grd_ImgList = New System.Windows.Forms.DataGrid()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lab_a = New System.Windows.Forms.Label()
        Me.tlb_Btn2 = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.lsv_Grp = New System.Windows.Forms.ListView()
        Me.Column1 = New System.Windows.Forms.ColumnHeader()
        Me.PicImage = New System.Windows.Forms.PictureBox()
        Me.Pos1 = New System.Windows.Forms.Label()
        Me.Pos2 = New System.Windows.Forms.Label()
        Me.Pos3 = New System.Windows.Forms.Label()
        Me.Pos4 = New System.Windows.Forms.Label()
        Me.Pos5 = New System.Windows.Forms.Label()
        Me.Pos11 = New System.Windows.Forms.Label()
        Me.Pos10 = New System.Windows.Forms.Label()
        Me.Pos9 = New System.Windows.Forms.Label()
        Me.Pos8 = New System.Windows.Forms.Label()
        Me.Pos7 = New System.Windows.Forms.Label()
        Me.Pos6 = New System.Windows.Forms.Label()
        Me.Pos17 = New System.Windows.Forms.Label()
        Me.Pos16 = New System.Windows.Forms.Label()
        Me.Pos15 = New System.Windows.Forms.Label()
        Me.Pos14 = New System.Windows.Forms.Label()
        Me.Pos13 = New System.Windows.Forms.Label()
        Me.Pos12 = New System.Windows.Forms.Label()
        Me.Pos24 = New System.Windows.Forms.Label()
        Me.Pos23 = New System.Windows.Forms.Label()
        Me.Pos22 = New System.Windows.Forms.Label()
        Me.Pos21 = New System.Windows.Forms.Label()
        Me.Pos19 = New System.Windows.Forms.Label()
        Me.Pos18 = New System.Windows.Forms.Label()
        Me.Pos30 = New System.Windows.Forms.Label()
        Me.Pos29 = New System.Windows.Forms.Label()
        Me.Pos28 = New System.Windows.Forms.Label()
        Me.Pos27 = New System.Windows.Forms.Label()
        Me.Pos26 = New System.Windows.Forms.Label()
        Me.Pos25 = New System.Windows.Forms.Label()
        Me.Pos40 = New System.Windows.Forms.Label()
        Me.Pos39 = New System.Windows.Forms.Label()
        Me.Pos38 = New System.Windows.Forms.Label()
        Me.Pos37 = New System.Windows.Forms.Label()
        Me.Pos36 = New System.Windows.Forms.Label()
        Me.Pos35 = New System.Windows.Forms.Label()
        Me.Pos34 = New System.Windows.Forms.Label()
        Me.Pos33 = New System.Windows.Forms.Label()
        Me.Pos32 = New System.Windows.Forms.Label()
        Me.Pos31 = New System.Windows.Forms.Label()
        Me.Pos50 = New System.Windows.Forms.Label()
        Me.Pos49 = New System.Windows.Forms.Label()
        Me.Pos48 = New System.Windows.Forms.Label()
        Me.Pos47 = New System.Windows.Forms.Label()
        Me.Pos46 = New System.Windows.Forms.Label()
        Me.Pos45 = New System.Windows.Forms.Label()
        Me.Pos44 = New System.Windows.Forms.Label()
        Me.Pos43 = New System.Windows.Forms.Label()
        Me.Pos42 = New System.Windows.Forms.Label()
        Me.Pos41 = New System.Windows.Forms.Label()
        Me.Pos20 = New System.Windows.Forms.Label()
        Me.Pos59 = New System.Windows.Forms.Label()
        Me.Pos58 = New System.Windows.Forms.Label()
        Me.Pos57 = New System.Windows.Forms.Label()
        Me.Pos56 = New System.Windows.Forms.Label()
        Me.Pos55 = New System.Windows.Forms.Label()
        Me.Pos54 = New System.Windows.Forms.Label()
        Me.Pos53 = New System.Windows.Forms.Label()
        Me.Pos52 = New System.Windows.Forms.Label()
        Me.Pos51 = New System.Windows.Forms.Label()
        Me.cmb_MenuCD = New System.Windows.Forms.ComboBox()
        Me.cmb_Menu = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Select = New System.Windows.Forms.Label()
        Me.txt_ImgPath = New System.Windows.Forms.TextBox()
        CType(Me.grd_ImgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pos0
        '
        Me.Pos0.BackColor = System.Drawing.Color.Transparent
        Me.Pos0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos0.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos0.Location = New System.Drawing.Point(200, 32)
        Me.Pos0.Name = "Pos0"
        Me.Pos0.Size = New System.Drawing.Size(64, 64)
        Me.Pos0.TabIndex = 17
        Me.Pos0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grd_ImgList
        '
        Me.grd_ImgList.CaptionText = "�� �ҏW���摜"
        Me.grd_ImgList.DataMember = ""
        Me.grd_ImgList.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_ImgList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_ImgList.Location = New System.Drawing.Point(0, 24)
        Me.grd_ImgList.Name = "grd_ImgList"
        Me.grd_ImgList.Size = New System.Drawing.Size(176, 656)
        Me.grd_ImgList.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(176, 24)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "�摜�t�H���_�I��"
        '
        'lab_a
        '
        Me.lab_a.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lab_a.Location = New System.Drawing.Point(200, 536)
        Me.lab_a.Name = "lab_a"
        Me.lab_a.Size = New System.Drawing.Size(480, 16)
        Me.lab_a.TabIndex = 275
        Me.lab_a.Text = "�� ���j���[��I�����A�W����������̉摜�Ɋ���t���Ă�������"
        Me.lab_a.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'tlb_Btn2
        '
        Me.tlb_Btn2.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton4, Me.ToolBarButton3})
        Me.tlb_Btn2.ButtonSize = New System.Drawing.Size(120, 65)
        Me.tlb_Btn2.Divider = False
        Me.tlb_Btn2.Dock = System.Windows.Forms.DockStyle.None
        Me.tlb_Btn2.DropDownArrows = True
        Me.tlb_Btn2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tlb_Btn2.ImageList = Me.ImageList2
        Me.tlb_Btn2.Location = New System.Drawing.Point(744, 552)
        Me.tlb_Btn2.Name = "tlb_Btn2"
        Me.tlb_Btn2.ShowToolTips = True
        Me.tlb_Btn2.Size = New System.Drawing.Size(248, 66)
        Me.tlb_Btn2.TabIndex = 276
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 2
        Me.ToolBarButton4.Text = "�o�^"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 3
        Me.ToolBarButton3.Text = "�S�ĉ���"
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'lsv_Grp
        '
        Me.lsv_Grp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Column1})
        Me.lsv_Grp.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_Grp.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5})
        Me.lsv_Grp.Location = New System.Drawing.Point(856, 72)
        Me.lsv_Grp.MultiSelect = False
        Me.lsv_Grp.Name = "lsv_Grp"
        Me.lsv_Grp.Size = New System.Drawing.Size(160, 448)
        Me.lsv_Grp.TabIndex = 4
        Me.lsv_Grp.View = System.Windows.Forms.View.Details
        '
        'Column1
        '
        Me.Column1.Text = "�W������"
        Me.Column1.Width = 100
        '
        'PicImage
        '
        Me.PicImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicImage.Location = New System.Drawing.Point(176, 16)
        Me.PicImage.Name = "PicImage"
        Me.PicImage.Size = New System.Drawing.Size(680, 500)
        Me.PicImage.TabIndex = 16
        Me.PicImage.TabStop = False
        '
        'Pos1
        '
        Me.Pos1.BackColor = System.Drawing.Color.Transparent
        Me.Pos1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos1.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos1.Location = New System.Drawing.Point(264, 32)
        Me.Pos1.Name = "Pos1"
        Me.Pos1.Size = New System.Drawing.Size(64, 64)
        Me.Pos1.TabIndex = 278
        Me.Pos1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos2
        '
        Me.Pos2.BackColor = System.Drawing.Color.Transparent
        Me.Pos2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos2.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos2.Location = New System.Drawing.Point(328, 32)
        Me.Pos2.Name = "Pos2"
        Me.Pos2.Size = New System.Drawing.Size(64, 64)
        Me.Pos2.TabIndex = 279
        Me.Pos2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos3
        '
        Me.Pos3.BackColor = System.Drawing.Color.Transparent
        Me.Pos3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos3.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos3.Location = New System.Drawing.Point(392, 32)
        Me.Pos3.Name = "Pos3"
        Me.Pos3.Size = New System.Drawing.Size(64, 64)
        Me.Pos3.TabIndex = 280
        Me.Pos3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos4
        '
        Me.Pos4.BackColor = System.Drawing.Color.Transparent
        Me.Pos4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos4.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos4.Location = New System.Drawing.Point(456, 32)
        Me.Pos4.Name = "Pos4"
        Me.Pos4.Size = New System.Drawing.Size(64, 64)
        Me.Pos4.TabIndex = 281
        Me.Pos4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos5
        '
        Me.Pos5.BackColor = System.Drawing.Color.Transparent
        Me.Pos5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos5.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos5.Location = New System.Drawing.Point(520, 32)
        Me.Pos5.Name = "Pos5"
        Me.Pos5.Size = New System.Drawing.Size(64, 64)
        Me.Pos5.TabIndex = 282
        Me.Pos5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos11
        '
        Me.Pos11.BackColor = System.Drawing.Color.Transparent
        Me.Pos11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos11.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos11.Location = New System.Drawing.Point(264, 112)
        Me.Pos11.Name = "Pos11"
        Me.Pos11.Size = New System.Drawing.Size(64, 64)
        Me.Pos11.TabIndex = 288
        Me.Pos11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos10
        '
        Me.Pos10.BackColor = System.Drawing.Color.Transparent
        Me.Pos10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos10.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos10.Location = New System.Drawing.Point(200, 112)
        Me.Pos10.Name = "Pos10"
        Me.Pos10.Size = New System.Drawing.Size(64, 64)
        Me.Pos10.TabIndex = 287
        Me.Pos10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos9
        '
        Me.Pos9.BackColor = System.Drawing.Color.Transparent
        Me.Pos9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos9.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos9.Location = New System.Drawing.Point(776, 32)
        Me.Pos9.Name = "Pos9"
        Me.Pos9.Size = New System.Drawing.Size(64, 64)
        Me.Pos9.TabIndex = 286
        Me.Pos9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos8
        '
        Me.Pos8.BackColor = System.Drawing.Color.Transparent
        Me.Pos8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos8.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos8.Location = New System.Drawing.Point(712, 32)
        Me.Pos8.Name = "Pos8"
        Me.Pos8.Size = New System.Drawing.Size(64, 64)
        Me.Pos8.TabIndex = 285
        Me.Pos8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos7
        '
        Me.Pos7.BackColor = System.Drawing.Color.Transparent
        Me.Pos7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos7.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos7.Location = New System.Drawing.Point(648, 32)
        Me.Pos7.Name = "Pos7"
        Me.Pos7.Size = New System.Drawing.Size(64, 64)
        Me.Pos7.TabIndex = 284
        Me.Pos7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos6
        '
        Me.Pos6.BackColor = System.Drawing.Color.Transparent
        Me.Pos6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos6.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos6.Location = New System.Drawing.Point(584, 32)
        Me.Pos6.Name = "Pos6"
        Me.Pos6.Size = New System.Drawing.Size(64, 64)
        Me.Pos6.TabIndex = 283
        Me.Pos6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos17
        '
        Me.Pos17.BackColor = System.Drawing.Color.Transparent
        Me.Pos17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos17.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos17.Location = New System.Drawing.Point(648, 112)
        Me.Pos17.Name = "Pos17"
        Me.Pos17.Size = New System.Drawing.Size(64, 64)
        Me.Pos17.TabIndex = 294
        Me.Pos17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos16
        '
        Me.Pos16.BackColor = System.Drawing.Color.Transparent
        Me.Pos16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos16.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos16.Location = New System.Drawing.Point(584, 112)
        Me.Pos16.Name = "Pos16"
        Me.Pos16.Size = New System.Drawing.Size(64, 64)
        Me.Pos16.TabIndex = 293
        Me.Pos16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos15
        '
        Me.Pos15.BackColor = System.Drawing.Color.Transparent
        Me.Pos15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos15.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos15.Location = New System.Drawing.Point(520, 112)
        Me.Pos15.Name = "Pos15"
        Me.Pos15.Size = New System.Drawing.Size(64, 64)
        Me.Pos15.TabIndex = 292
        Me.Pos15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos14
        '
        Me.Pos14.BackColor = System.Drawing.Color.Transparent
        Me.Pos14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos14.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos14.Location = New System.Drawing.Point(456, 112)
        Me.Pos14.Name = "Pos14"
        Me.Pos14.Size = New System.Drawing.Size(64, 64)
        Me.Pos14.TabIndex = 291
        Me.Pos14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos13
        '
        Me.Pos13.BackColor = System.Drawing.Color.Transparent
        Me.Pos13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos13.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos13.Location = New System.Drawing.Point(392, 112)
        Me.Pos13.Name = "Pos13"
        Me.Pos13.Size = New System.Drawing.Size(64, 64)
        Me.Pos13.TabIndex = 290
        Me.Pos13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos12
        '
        Me.Pos12.BackColor = System.Drawing.Color.Transparent
        Me.Pos12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos12.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos12.Location = New System.Drawing.Point(328, 112)
        Me.Pos12.Name = "Pos12"
        Me.Pos12.Size = New System.Drawing.Size(64, 64)
        Me.Pos12.TabIndex = 289
        Me.Pos12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos24
        '
        Me.Pos24.BackColor = System.Drawing.Color.Transparent
        Me.Pos24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos24.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos24.Location = New System.Drawing.Point(456, 192)
        Me.Pos24.Name = "Pos24"
        Me.Pos24.Size = New System.Drawing.Size(64, 64)
        Me.Pos24.TabIndex = 300
        Me.Pos24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos23
        '
        Me.Pos23.BackColor = System.Drawing.Color.Transparent
        Me.Pos23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos23.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos23.Location = New System.Drawing.Point(392, 192)
        Me.Pos23.Name = "Pos23"
        Me.Pos23.Size = New System.Drawing.Size(64, 64)
        Me.Pos23.TabIndex = 299
        Me.Pos23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos22
        '
        Me.Pos22.BackColor = System.Drawing.Color.Transparent
        Me.Pos22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos22.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos22.Location = New System.Drawing.Point(328, 192)
        Me.Pos22.Name = "Pos22"
        Me.Pos22.Size = New System.Drawing.Size(64, 64)
        Me.Pos22.TabIndex = 298
        Me.Pos22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos21
        '
        Me.Pos21.BackColor = System.Drawing.Color.Transparent
        Me.Pos21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos21.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos21.Location = New System.Drawing.Point(264, 192)
        Me.Pos21.Name = "Pos21"
        Me.Pos21.Size = New System.Drawing.Size(64, 64)
        Me.Pos21.TabIndex = 297
        Me.Pos21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos19
        '
        Me.Pos19.BackColor = System.Drawing.Color.Transparent
        Me.Pos19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos19.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos19.Location = New System.Drawing.Point(776, 112)
        Me.Pos19.Name = "Pos19"
        Me.Pos19.Size = New System.Drawing.Size(64, 64)
        Me.Pos19.TabIndex = 296
        Me.Pos19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos18
        '
        Me.Pos18.BackColor = System.Drawing.Color.Transparent
        Me.Pos18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos18.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos18.Location = New System.Drawing.Point(712, 112)
        Me.Pos18.Name = "Pos18"
        Me.Pos18.Size = New System.Drawing.Size(64, 64)
        Me.Pos18.TabIndex = 295
        Me.Pos18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos30
        '
        Me.Pos30.BackColor = System.Drawing.Color.Transparent
        Me.Pos30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos30.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos30.Location = New System.Drawing.Point(200, 272)
        Me.Pos30.Name = "Pos30"
        Me.Pos30.Size = New System.Drawing.Size(64, 64)
        Me.Pos30.TabIndex = 306
        Me.Pos30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos29
        '
        Me.Pos29.BackColor = System.Drawing.Color.Transparent
        Me.Pos29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos29.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos29.Location = New System.Drawing.Point(776, 192)
        Me.Pos29.Name = "Pos29"
        Me.Pos29.Size = New System.Drawing.Size(64, 64)
        Me.Pos29.TabIndex = 305
        Me.Pos29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos28
        '
        Me.Pos28.BackColor = System.Drawing.Color.Transparent
        Me.Pos28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos28.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos28.Location = New System.Drawing.Point(712, 192)
        Me.Pos28.Name = "Pos28"
        Me.Pos28.Size = New System.Drawing.Size(64, 64)
        Me.Pos28.TabIndex = 304
        Me.Pos28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos27
        '
        Me.Pos27.BackColor = System.Drawing.Color.Transparent
        Me.Pos27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos27.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos27.Location = New System.Drawing.Point(648, 192)
        Me.Pos27.Name = "Pos27"
        Me.Pos27.Size = New System.Drawing.Size(64, 64)
        Me.Pos27.TabIndex = 303
        Me.Pos27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos26
        '
        Me.Pos26.BackColor = System.Drawing.Color.Transparent
        Me.Pos26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos26.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos26.Location = New System.Drawing.Point(584, 192)
        Me.Pos26.Name = "Pos26"
        Me.Pos26.Size = New System.Drawing.Size(64, 64)
        Me.Pos26.TabIndex = 302
        Me.Pos26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos25
        '
        Me.Pos25.BackColor = System.Drawing.Color.Transparent
        Me.Pos25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos25.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos25.Location = New System.Drawing.Point(520, 192)
        Me.Pos25.Name = "Pos25"
        Me.Pos25.Size = New System.Drawing.Size(64, 64)
        Me.Pos25.TabIndex = 301
        Me.Pos25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos40
        '
        Me.Pos40.BackColor = System.Drawing.Color.Transparent
        Me.Pos40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos40.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos40.Location = New System.Drawing.Point(200, 352)
        Me.Pos40.Name = "Pos40"
        Me.Pos40.Size = New System.Drawing.Size(64, 64)
        Me.Pos40.TabIndex = 316
        Me.Pos40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos39
        '
        Me.Pos39.BackColor = System.Drawing.Color.Transparent
        Me.Pos39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos39.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos39.Location = New System.Drawing.Point(776, 272)
        Me.Pos39.Name = "Pos39"
        Me.Pos39.Size = New System.Drawing.Size(64, 64)
        Me.Pos39.TabIndex = 315
        Me.Pos39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos38
        '
        Me.Pos38.BackColor = System.Drawing.Color.Transparent
        Me.Pos38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos38.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos38.Location = New System.Drawing.Point(712, 272)
        Me.Pos38.Name = "Pos38"
        Me.Pos38.Size = New System.Drawing.Size(64, 64)
        Me.Pos38.TabIndex = 314
        Me.Pos38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos37
        '
        Me.Pos37.BackColor = System.Drawing.Color.Transparent
        Me.Pos37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos37.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos37.Location = New System.Drawing.Point(648, 272)
        Me.Pos37.Name = "Pos37"
        Me.Pos37.Size = New System.Drawing.Size(64, 64)
        Me.Pos37.TabIndex = 313
        Me.Pos37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos36
        '
        Me.Pos36.BackColor = System.Drawing.Color.Transparent
        Me.Pos36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos36.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos36.Location = New System.Drawing.Point(584, 272)
        Me.Pos36.Name = "Pos36"
        Me.Pos36.Size = New System.Drawing.Size(64, 64)
        Me.Pos36.TabIndex = 312
        Me.Pos36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos35
        '
        Me.Pos35.BackColor = System.Drawing.Color.Transparent
        Me.Pos35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos35.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos35.Location = New System.Drawing.Point(520, 272)
        Me.Pos35.Name = "Pos35"
        Me.Pos35.Size = New System.Drawing.Size(64, 64)
        Me.Pos35.TabIndex = 311
        Me.Pos35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos34
        '
        Me.Pos34.BackColor = System.Drawing.Color.Transparent
        Me.Pos34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos34.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos34.Location = New System.Drawing.Point(456, 272)
        Me.Pos34.Name = "Pos34"
        Me.Pos34.Size = New System.Drawing.Size(64, 64)
        Me.Pos34.TabIndex = 310
        Me.Pos34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos33
        '
        Me.Pos33.BackColor = System.Drawing.Color.Transparent
        Me.Pos33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos33.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos33.Location = New System.Drawing.Point(392, 272)
        Me.Pos33.Name = "Pos33"
        Me.Pos33.Size = New System.Drawing.Size(64, 64)
        Me.Pos33.TabIndex = 309
        Me.Pos33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos32
        '
        Me.Pos32.BackColor = System.Drawing.Color.Transparent
        Me.Pos32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos32.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos32.Location = New System.Drawing.Point(328, 272)
        Me.Pos32.Name = "Pos32"
        Me.Pos32.Size = New System.Drawing.Size(64, 64)
        Me.Pos32.TabIndex = 308
        Me.Pos32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos31
        '
        Me.Pos31.BackColor = System.Drawing.Color.Transparent
        Me.Pos31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos31.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos31.Location = New System.Drawing.Point(264, 272)
        Me.Pos31.Name = "Pos31"
        Me.Pos31.Size = New System.Drawing.Size(64, 64)
        Me.Pos31.TabIndex = 307
        Me.Pos31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos50
        '
        Me.Pos50.BackColor = System.Drawing.Color.Transparent
        Me.Pos50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos50.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos50.Location = New System.Drawing.Point(200, 432)
        Me.Pos50.Name = "Pos50"
        Me.Pos50.Size = New System.Drawing.Size(64, 64)
        Me.Pos50.TabIndex = 326
        Me.Pos50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos49
        '
        Me.Pos49.BackColor = System.Drawing.Color.Transparent
        Me.Pos49.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos49.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos49.Location = New System.Drawing.Point(776, 352)
        Me.Pos49.Name = "Pos49"
        Me.Pos49.Size = New System.Drawing.Size(64, 64)
        Me.Pos49.TabIndex = 325
        Me.Pos49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos48
        '
        Me.Pos48.BackColor = System.Drawing.Color.Transparent
        Me.Pos48.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos48.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos48.Location = New System.Drawing.Point(712, 352)
        Me.Pos48.Name = "Pos48"
        Me.Pos48.Size = New System.Drawing.Size(64, 64)
        Me.Pos48.TabIndex = 324
        Me.Pos48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos47
        '
        Me.Pos47.BackColor = System.Drawing.Color.Transparent
        Me.Pos47.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos47.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos47.Location = New System.Drawing.Point(648, 352)
        Me.Pos47.Name = "Pos47"
        Me.Pos47.Size = New System.Drawing.Size(64, 64)
        Me.Pos47.TabIndex = 323
        Me.Pos47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos46
        '
        Me.Pos46.BackColor = System.Drawing.Color.Transparent
        Me.Pos46.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos46.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos46.Location = New System.Drawing.Point(584, 352)
        Me.Pos46.Name = "Pos46"
        Me.Pos46.Size = New System.Drawing.Size(64, 64)
        Me.Pos46.TabIndex = 322
        Me.Pos46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos45
        '
        Me.Pos45.BackColor = System.Drawing.Color.Transparent
        Me.Pos45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos45.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos45.Location = New System.Drawing.Point(520, 352)
        Me.Pos45.Name = "Pos45"
        Me.Pos45.Size = New System.Drawing.Size(64, 64)
        Me.Pos45.TabIndex = 321
        Me.Pos45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos44
        '
        Me.Pos44.BackColor = System.Drawing.Color.Transparent
        Me.Pos44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos44.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos44.Location = New System.Drawing.Point(456, 352)
        Me.Pos44.Name = "Pos44"
        Me.Pos44.Size = New System.Drawing.Size(64, 64)
        Me.Pos44.TabIndex = 320
        Me.Pos44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos43
        '
        Me.Pos43.BackColor = System.Drawing.Color.Transparent
        Me.Pos43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos43.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos43.Location = New System.Drawing.Point(392, 352)
        Me.Pos43.Name = "Pos43"
        Me.Pos43.Size = New System.Drawing.Size(64, 64)
        Me.Pos43.TabIndex = 319
        Me.Pos43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos42
        '
        Me.Pos42.BackColor = System.Drawing.Color.Transparent
        Me.Pos42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos42.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos42.Location = New System.Drawing.Point(328, 352)
        Me.Pos42.Name = "Pos42"
        Me.Pos42.Size = New System.Drawing.Size(64, 64)
        Me.Pos42.TabIndex = 318
        Me.Pos42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos41
        '
        Me.Pos41.BackColor = System.Drawing.Color.Transparent
        Me.Pos41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos41.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos41.Location = New System.Drawing.Point(264, 352)
        Me.Pos41.Name = "Pos41"
        Me.Pos41.Size = New System.Drawing.Size(64, 64)
        Me.Pos41.TabIndex = 317
        Me.Pos41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos20
        '
        Me.Pos20.BackColor = System.Drawing.Color.Transparent
        Me.Pos20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos20.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos20.Location = New System.Drawing.Point(200, 192)
        Me.Pos20.Name = "Pos20"
        Me.Pos20.Size = New System.Drawing.Size(64, 64)
        Me.Pos20.TabIndex = 336
        Me.Pos20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos59
        '
        Me.Pos59.BackColor = System.Drawing.Color.Transparent
        Me.Pos59.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos59.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos59.Location = New System.Drawing.Point(776, 432)
        Me.Pos59.Name = "Pos59"
        Me.Pos59.Size = New System.Drawing.Size(64, 64)
        Me.Pos59.TabIndex = 335
        Me.Pos59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos58
        '
        Me.Pos58.BackColor = System.Drawing.Color.Transparent
        Me.Pos58.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos58.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos58.Location = New System.Drawing.Point(712, 432)
        Me.Pos58.Name = "Pos58"
        Me.Pos58.Size = New System.Drawing.Size(64, 64)
        Me.Pos58.TabIndex = 334
        Me.Pos58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos57
        '
        Me.Pos57.BackColor = System.Drawing.Color.Transparent
        Me.Pos57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos57.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos57.Location = New System.Drawing.Point(648, 432)
        Me.Pos57.Name = "Pos57"
        Me.Pos57.Size = New System.Drawing.Size(64, 64)
        Me.Pos57.TabIndex = 333
        Me.Pos57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos56
        '
        Me.Pos56.BackColor = System.Drawing.Color.Transparent
        Me.Pos56.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos56.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos56.Location = New System.Drawing.Point(584, 432)
        Me.Pos56.Name = "Pos56"
        Me.Pos56.Size = New System.Drawing.Size(64, 64)
        Me.Pos56.TabIndex = 332
        Me.Pos56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos55
        '
        Me.Pos55.BackColor = System.Drawing.Color.Transparent
        Me.Pos55.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos55.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos55.Location = New System.Drawing.Point(520, 432)
        Me.Pos55.Name = "Pos55"
        Me.Pos55.Size = New System.Drawing.Size(64, 64)
        Me.Pos55.TabIndex = 331
        Me.Pos55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos54
        '
        Me.Pos54.BackColor = System.Drawing.Color.Transparent
        Me.Pos54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos54.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos54.Location = New System.Drawing.Point(456, 432)
        Me.Pos54.Name = "Pos54"
        Me.Pos54.Size = New System.Drawing.Size(64, 64)
        Me.Pos54.TabIndex = 330
        Me.Pos54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos53
        '
        Me.Pos53.BackColor = System.Drawing.Color.Transparent
        Me.Pos53.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos53.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos53.Location = New System.Drawing.Point(392, 432)
        Me.Pos53.Name = "Pos53"
        Me.Pos53.Size = New System.Drawing.Size(64, 64)
        Me.Pos53.TabIndex = 329
        Me.Pos53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos52
        '
        Me.Pos52.BackColor = System.Drawing.Color.Transparent
        Me.Pos52.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos52.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos52.Location = New System.Drawing.Point(328, 432)
        Me.Pos52.Name = "Pos52"
        Me.Pos52.Size = New System.Drawing.Size(64, 64)
        Me.Pos52.TabIndex = 328
        Me.Pos52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pos51
        '
        Me.Pos51.BackColor = System.Drawing.Color.Transparent
        Me.Pos51.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pos51.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pos51.Location = New System.Drawing.Point(264, 432)
        Me.Pos51.Name = "Pos51"
        Me.Pos51.Size = New System.Drawing.Size(64, 64)
        Me.Pos51.TabIndex = 327
        Me.Pos51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_MenuCD
        '
        Me.cmb_MenuCD.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb_MenuCD.ItemHeight = 15
        Me.cmb_MenuCD.Location = New System.Drawing.Point(784, 0)
        Me.cmb_MenuCD.Name = "cmb_MenuCD"
        Me.cmb_MenuCD.Size = New System.Drawing.Size(56, 23)
        Me.cmb_MenuCD.TabIndex = 337
        Me.cmb_MenuCD.Visible = False
        '
        'cmb_Menu
        '
        Me.cmb_Menu.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb_Menu.ItemHeight = 15
        Me.cmb_Menu.Location = New System.Drawing.Point(856, 48)
        Me.cmb_Menu.Name = "cmb_Menu"
        Me.cmb_Menu.Size = New System.Drawing.Size(160, 23)
        Me.cmb_Menu.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(856, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 338
        Me.Label1.Text = "�� �I�𒆃W������"
        '
        'lbl_Select
        '
        Me.lbl_Select.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Select.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_Select.Location = New System.Drawing.Point(856, 22)
        Me.lbl_Select.Name = "lbl_Select"
        Me.lbl_Select.Size = New System.Drawing.Size(160, 16)
        Me.lbl_Select.TabIndex = 339
        Me.lbl_Select.Text = "�Ȃ�"
        '
        'txt_ImgPath
        '
        Me.txt_ImgPath.Location = New System.Drawing.Point(184, 656)
        Me.txt_ImgPath.Name = "txt_ImgPath"
        Me.txt_ImgPath.Size = New System.Drawing.Size(64, 19)
        Me.txt_ImgPath.TabIndex = 340
        Me.txt_ImgPath.Text = "txt_ImgPath"
        Me.txt_ImgPath.Visible = False
        '
        'CNL1710
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1016, 686)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txt_ImgPath, Me.lbl_Select, Me.Label1, Me.cmb_MenuCD, Me.Pos20, Me.Pos59, Me.Pos58, Me.Pos57, Me.Pos56, Me.Pos55, Me.Pos54, Me.Pos53, Me.Pos52, Me.Pos51, Me.Pos50, Me.Pos49, Me.Pos48, Me.Pos47, Me.Pos46, Me.Pos45, Me.Pos44, Me.Pos43, Me.Pos42, Me.Pos41, Me.Pos40, Me.Pos39, Me.Pos38, Me.Pos37, Me.Pos36, Me.Pos35, Me.Pos34, Me.Pos33, Me.Pos32, Me.Pos31, Me.Pos30, Me.Pos29, Me.Pos28, Me.Pos27, Me.Pos26, Me.Pos25, Me.Pos24, Me.Pos23, Me.Pos22, Me.Pos21, Me.Pos19, Me.Pos18, Me.Pos17, Me.Pos16, Me.Pos15, Me.Pos14, Me.Pos13, Me.Pos12, Me.Pos11, Me.Pos10, Me.Pos9, Me.Pos8, Me.Pos7, Me.Pos6, Me.Pos5, Me.Pos4, Me.Pos3, Me.Pos2, Me.Pos1, Me.lsv_Grp, Me.lab_a, Me.cmb_Menu, Me.grd_ImgList, Me.Button3, Me.Pos0, Me.PicImage, Me.tlb_Btn2})
        Me.Name = "CNL1710"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNL1710"
        CType(Me.grd_ImgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public G_Code As String
    public G_Menu as String 

    Private L_Color As Color
    Private L_Control As New Collection()
    Private L_Bmap As Bitmap
    Private L_EditFlg As Integer
    Private L_PicChange As Integer

    Private Sub CNL1710_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim i As Integer
        Dim objControl As System.Windows.Forms.Control

        '------------------------------
        ' �t�H�[�����̐ݒ�
        '------------------------------
        Me.Text = GF_FormText("���j���[�摜�쐬")

        '-- �ϐ�������
        L_EditFlg = 0
        L_PicChange = 0
        L_Bmap = New Bitmap(686, 500, System.Drawing.Imaging.PixelFormat.Format32bppRgb)

        '-- PictureBox��̃��x����S��PictureBox�̎q�R���g���[���ɐݒ肷��
        LF_GetControl(Me.Controls)
        For Each objControl In L_Control
            If Mid(Trim$(objControl.Name), 1, 3) = "Pos" Then
                PicImage.Controls.Add(objControl)
                objControl.BackColor = Color.Transparent
                objControl.Top = objControl.Top - PicImage.Top
                objControl.Left = objControl.Left - PicImage.Left
            End If
        Next

        i = 0
        '-- ���j���[�R���{�a�n�w�A���j���[�R�[�h�R���{�a�n�w�i�B���j�쐬
        If Mid(Trim$(G_Menu), 1, 1) = "M" Then
            ' �ʏ탁�j���[�p
            LS_SetMenuList()
        Else
            ' ���ݕ���p
            LS_SetMenuList2()
            '---20060530 ���{ ADD �H�ו��胁�j���[�o�^��ʂ���̑J�ڃ��j���[�������\�� START---
            If Trim$(G_Menu) <> "" Then
                i = cmb_MenuCD.FindString(Trim$(G_Menu))
                If i < 0 Then
                    i = 0
                End If
            End If
            '---20060530 ���{ ADD END---
        End If

        '-- �W�������o�^��ʂ���̑J�ڃ��j���[�������\��
        If Trim$(G_Code) <> "" Then
            i = cmb_MenuCD.FindString(Trim$(G_Code))
            If i < 0 Then
                i = 0
            End If
            'Else
            'i = 0
        End If


        cmb_Menu.SelectedIndex = i
        cmb_MenuCD.SelectedIndex = i
        LS_Setlsv_Grp(i)
        LF_SetPicture(i)

    End Sub

    Private Function LF_GetControl(ByVal objCollection As Control.ControlCollection) As Object

        LF_GetControl = Nothing

        '-- Form��̑S�R���g���[���擾
        Dim objControl As Control

        For Each objControl In objCollection
            If objControl.Controls.Count = 0 Then
                L_Control.Add(objControl)
            Else
                Call LF_GetControl(objControl.Controls)
            End If
        Next

    End Function

    Private Sub LS_SetMenuList()

        '-- ���j���[�R���{�a�n�w�쐬

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim lngRowCnt As Long

        strSQL = ""
        strSQL = strSQL & "SELECT DISTINCT(MENUGRPID),"
        strSQL = strSQL & "       MIN(MENUGRPNM) AS MENUGRPNM"
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " WHERE MENUID = '" & G_Menu & "'"
        strSQL = strSQL & "   AND GROUPCD <> 'J000'"
        'strSQL = strSQL & "   AND ENABLED = '0'" 20060530 ���{ �ύX ���ݕ���ɏ��������킹��
        strSQL = strSQL & " GROUP BY MENUGRPID"
        strSQL = strSQL & " ORDER BY MENUGRPID"
        If Not GF_GetData(strSQL, objData) Then
            Exit Sub
        End If

        cmb_Menu.Items.Clear()
        cmb_MenuCD.Items.Clear()
        If objData.Tables("com").Rows.Count > 0 Then
            For lngRowCnt = 0 To objData.Tables("com").Rows.Count - 1
                If Not GF_GetRows(objData, lngRowCnt, objRow) Then
                    Exit Sub
                End If
                cmb_Menu.Items.Add(Trim$(objRow("MENUGRPNM")))
                cmb_MenuCD.Items.Add(Trim$(objRow("MENUGRPID")))
            Next
        End If

    End Sub

    Private Sub LS_SetMenuList2()

        '-- ���ݕ��胁�j���[�R���{�a�n�w�쐬

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim lngRowCnt As Long

        strSQL = ""
        strSQL = strSQL & "SELECT DISTINCT(MENUID),"
        strSQL = strSQL & "       MIN(MENUNM) AS MENUNM"
        strSQL = strSQL & "  FROM TPM170"
        'strSQL = strSQL & " WHERE MENUID = '" & G_Menu & "'"
        'strSQL = strSQL & "   AND GROUPCD <> '0000'"
        '20060531 ���{ ADD ���i�W������0�����o�͑Ή�
        strSQL = strSQL & " WHERE GROUPCD <> '0000'"
        strSQL = strSQL & " GROUP BY MENUID"
        strSQL = strSQL & " ORDER BY MENUID"
        If Not GF_GetData(strSQL, objData) Then
            Exit Sub
        End If

        cmb_Menu.Items.Clear()
        cmb_MenuCD.Items.Clear()
        If objData.Tables("com").Rows.Count > 0 Then
            For lngRowCnt = 0 To objData.Tables("com").Rows.Count - 1
                If Not GF_GetRows(objData, lngRowCnt, objRow) Then
                    Exit Sub
                End If
                cmb_Menu.Items.Add(Trim$(objRow("MENUNM")))
                cmb_MenuCD.Items.Add(Trim$(objRow("MENUID")))
            Next
        End If

    End Sub

    Private Sub cmb_Menu_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Menu.SelectionChangeCommitted

        L_PicChange = 0
        LF_AllClear()
        LS_Setlsv_Grp(cmb_Menu.SelectedIndex)
        LF_SetPicture(cmb_Menu.SelectedIndex)

        lbl_Select.Text = "�Ȃ�"
        lbl_Select.BackColor = Nothing

    End Sub

    Private Sub LS_Setlsv_Grp(ByVal plngIndex As Long)
        '-- �W�������ꗗ�쐬

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim lngRowCnt As Long
        Dim objItem As New ListViewItem()
        Dim objColor(20) As Color
        Dim strTable As String
        '---20060530 ���{ ADD ���j���[�h�c�؂�ւ��p�ϐ��ǉ� START---
        Dim MenuID As String
        '---20060530 ���{ ADD END

        '-- �F�쐬
        objColor(0) = Color.Red
        objColor(1) = Color.Aqua
        objColor(2) = Color.Lime
        objColor(3) = Color.Yellow
        objColor(4) = Color.Magenta
        objColor(5) = Color.Purple
        objColor(6) = Color.Orange
        objColor(7) = Color.DeepSkyBlue
        objColor(8) = Color.LightPink
        objColor(9) = Color.Gray

        '-- �\���f�[�^�擾
        strSQL = ""
        If Mid(Trim$(G_Menu), 1, 1) = "M" Then
            strTable = "TPM060"
            '---20060530 ���{ ADD START---
            MenuID = G_Menu
            '---20060530 ���{ ADD END---
        Else
            strTable = "TPM170"
            '---20060530 ���{ ADD START--- 
            MenuID = cmb_MenuCD.Items(plngIndex)
            '---20060530 ���{ ADD END---
        End If

        strSQL = strSQL & "SELECT DISTINCT(TPM020.GROUPCD),"
        strSQL = strSQL & "       TPM020.GROUPNM"
        strSQL = strSQL & "  FROM TPM020, " & strTable
        strSQL = strSQL & " WHERE TPM020.GROUPCD = " & strTable & ".GROUPCD"
        strSQL = strSQL & "   AND " & strTable & ".MENUID = '" & MenuID & "'"
        If Mid(Trim$(G_Menu), 1, 1) = "M" Then
            strSQL = strSQL & "   AND " & strTable & ".MENUGRPID = '" & cmb_MenuCD.Items(plngIndex) & "'"
        End If
        strSQL = strSQL & "   AND TPM020.GOODSCD = '0000 '"
        If Not GF_GetData(strSQL, objData) Then
            Exit Sub
        End If

        lsv_Grp.Clear()
        With lsv_Grp.Columns
            .Add("�W������", 152, HorizontalAlignment.Center)
            .Add("�R�[�h", 0, HorizontalAlignment.Left)
        End With

        If objData.Tables("com").Rows.Count > 0 Then
            For lngRowCnt = 0 To objData.Tables("com").Rows.Count - 1
                If Not GF_GetRows(objData, lngRowCnt, objRow) Then
                    Exit Sub
                End If

                objItem = New ListViewItem()
                objItem.Text = GF_PadSpace(Trim$(objRow("GROUPNM")), 18)
                objItem.SubItems.Add(objRow("GROUPCD"))
                objItem.BackColor = objColor(lngRowCnt Mod 10)
                ' ------------------------------------------------------
                lsv_Grp.Items.Add(objItem)

            Next
        End If

    End Sub

    Private Function LF_SetPicture(ByVal plngIndex As Long) As Object

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim lngRowCnt As Long
        Dim objControl As System.Windows.Forms.Control
        Dim i As Integer
        Dim bmap As Bitmap
        Dim MenuID As String '20060530 ���{ ADD ���W���������j���[�摜�؂�ւ��p�i�[�ϐ� START

        LF_SetPicture = Nothing

        '---20060530 ���{ ADD START--- 
        If Mid(Trim$(G_Menu), 1, 1) = "M" Then
            MenuID = G_Menu
        Else
            MenuID = cmb_MenuCD.Items(plngIndex)
        End If
        '---20060530 ���{ ADD END---

        strSQL = ""
        strSQL = strSQL & "SELECT POSCNT, GROUPCD, IMAGEFILE"
        strSQL = strSQL & "  FROM TPM150"
        strSQL = strSQL & " WHERE MENUID = '" & MenuID & "'"
        If Mid(Trim$(G_Menu), 1, 1) = "M" Then
            strSQL = strSQL & "   AND MENUGRPID = '" & cmb_MenuCD.Items(plngIndex) & "'"
        End If
        '---20060626 ���{ �ύX 10.4�C���`�p�~�̈� ---
        'strSQL = strSQL & "   AND TERMTYPE = '1'"
        strSQL = strSQL & "   AND TERMTYPE = '2'"
        '--------------------------------------------
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count > 0 Then
            For lngRowCnt = 0 To objData.Tables("com").Rows.Count - 1
                If Not GF_GetRows(objData, lngRowCnt, objRow) Then
                    Exit Function
                End If

                '-- �S�R���g���[���擾
                L_Control = New Collection()
                LF_GetControl(Me.Controls)

                For Each objControl In L_Control
                    If Mid(Trim$(objControl.Name), 1, 3) = "Pos" Then

                        '-- ���x���ɐݒ�ς݂̃W������������t����
                        If objRow("POSCNT") = CInt(Replace(objControl.Name, "Pos", "")) Then

                            '-- �W�������ꗗ����F�擾
                            For i = 0 To lsv_Grp.Items.Count - 1
                                If Mid(lsv_Grp.Items(i).SubItems(1).Text, 1, 4) = objRow("GROUPCD") Then
                                    objControl.Text = "��"
                                    objControl.Tag = objRow("GROUPCD")
                                    objControl.ForeColor = lsv_Grp.Items(i).BackColor
                                    Exit For
                                End If
                            Next

                        End If

                    End If
                Next

            Next

            'If L_Bmap Is Nothing Then
            '    Exit Function
            'End If
            L_Bmap.Dispose()
            txt_ImgPath.Text = GF_GetAppInfo("GROUP_PATH") & "\" & Trim$(objRow("IMAGEFILE"))
            bmap = New Bitmap(GF_GetAppInfo("GROUP_PATH") & "\" & Trim$(objRow("IMAGEFILE")))
            L_Bmap = New Bitmap(bmap, 800, 600)
            PicImage.Refresh()                                              ' �ҏW��̋����ĕ`��

        Else
            L_Bmap.Dispose()
            txt_ImgPath.Text = ""
            L_Bmap = New Bitmap(686, 500, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
            Graphics.FromImage(L_Bmap)
            PicImage.Refresh()
        End If

    End Function

    Private Sub PicImage_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PicImage.Paint

        'Paint�C�x���g�n���h���ŉ摜��\������
        e.Graphics.DrawImage(L_Bmap, 0, 0, 680, 500)

        'e.Dispose()

    End Sub

    Private Sub lsv_Grp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Grp.Click

        L_Color = lsv_Grp.SelectedItems(0).BackColor
        G_Code = lsv_Grp.SelectedItems(0).SubItems(1).Text
        lbl_Select.Text = lsv_Grp.SelectedItems(0).Text
        lbl_Select.BackColor = lsv_Grp.SelectedItems(0).BackColor
        lsv_Grp.SelectedItems.Clear()

    End Sub

    Private Function LF_SetLabelColor(ByVal pobjLabel As System.Windows.Forms.Label) As Object

        LF_SetLabelColor = Nothing

        If Trim$(lbl_Select.Text) = "�Ȃ�" Then
            GF_Msg("", "�W��������I�����Ă�������", MsgBoxStyle.OkOnly)
            Exit Function
        End If

        If Trim$(txt_ImgPath.Text) = "" Then
            GF_Msg("", "�摜��I�����Ă�������", MsgBoxStyle.OkOnly)
            Exit Function
        End If

        If pobjLabel.Tag = "" Or pobjLabel.Tag <> G_Code Then
            pobjLabel.ForeColor = L_Color
            pobjLabel.Text = "��"
            pobjLabel.Tag = G_Code
        Else
            pobjLabel.Text = ""
            pobjLabel.Tag = ""
        End If

    End Function

    Private Function LF_AllClear() As Object

        LF_AllClear = Nothing

        '-- �W�������̊��t��S�ĉ�������

        Dim objControl As System.Windows.Forms.Control

        '-- �S�R���g���[���擾
        L_Control = New Collection()
        LF_GetControl(Me.Controls)

        '-- �ݒ���N���A
        For Each objControl In L_Control
            If Mid(Trim$(objControl.Name), 1, 3) = "Pos" Then
                objControl.Text = ""
                objControl.Tag = ""
            End If
        Next

    End Function

    Private Sub tlb_Btn2_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlb_Btn2.ButtonClick

        Dim intErrType As Integer

        Select Case e.Button.Text
            Case tlb_Btn2.Buttons.Item(0).Text
                '-- �o�^����
                If Not LF_Check(intErrType) Then
                    Select Case intErrType
                        Case 1
                            GF_Msg("", "�W������������t���Ă�������", MsgBoxStyle.OKOnly)
                            Exit Sub
                        Case 2
                            If GF_Msg("", "���t���Ă��Ȃ��W������������܂��B�o�^���Ă���낵���ł����H", MsgBoxStyle.OKCancel) = MsgBoxResult.Cancel Then
                                Exit Sub
                            End If
                    End Select
                End If
                'If Not GF_BeginTrans() Then
                '    Exit Sub
                'End If

                If Not LF_ExecSQL() Then
                    'Call GF_RollbackTrans()
                    Exit Sub
                End If

                L_EditFlg = 1

                'If Not GF_CommitTrans() Then
                '    Call GF_RollbackTrans()
                '    Exit Sub
                'End If

            Case tlb_Btn2.Buttons.Item(1).Text
                '-- �S�ĉ���
                LF_AllClear()

            Case Else
        End Select

    End Sub

    Private Function LF_Check(ByRef pintErrtype As Integer) As Boolean

        Dim objControl As System.Windows.Forms.Control
        Dim intCnt As Integer
        Dim intMatch As Integer

        LF_Check = False
        pintErrtype = 0

        '-- �S�R���g���[���擾
        L_Control = New Collection()
        LF_GetControl(Me.Controls)

        '-- �W���������P�ł��ݒ肳��Ă��邩�`�F�b�N -------------------------------------
        For Each objControl In L_Control
            If Mid(Trim$(objControl.Name), 1, 3) = "Pos" Then
                If Trim$(objControl.Tag) <> "" Then
                    '-- ����t�����Ă���̂łn�j
                    intMatch = 1
                    Exit For
                End If
            End If
        Next

        If intMatch <> 1 Then
            pintErrtype = 1
            Exit Function
        End If

        '-- �S�W���������������Ă��邩�`�F�b�N----------------------------------------
        For intCnt = 0 To lsv_Grp.Items.Count - 1

            intMatch = 0

            For Each objControl In L_Control
                If Mid(Trim$(objControl.Name), 1, 3) = "Pos" Then
                    If objControl.Tag = lsv_Grp.Items(intCnt).SubItems(1).Text Then
                        intMatch = 1
                        Exit For
                    End If
                End If
            Next

            If intMatch <> 1 Then
                pintErrtype = 2
                Exit Function
            End If

        Next intCnt

        LF_Check = True

    End Function

    '--------------------------------------
    ' 2006.6.26 ���{ �X�V 7�C���`�Ή�
    '--------------------------------------
    Private Function LF_ExecSQL() As Boolean

        Dim objControl As System.Windows.Forms.Control
        Dim strSQL As String
        Dim lngPos As Long
        Dim strMenuGrpID As String
        Dim strFileName As String
        Dim strMode As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim strOldFileNM As String
        Dim MenuID As String '20060530 ���{ ADD ���W���������j���[�؂�ւ��p�ϐ��ǉ�

        LF_ExecSQL = False
        If Mid(Trim$(G_Menu), 1, 1) = "M" Then
            strMenuGrpID = cmb_MenuCD.Items(cmb_Menu.SelectedIndex)
            '---20060530 ���{ ADD START---�@
            MenuID = G_Menu
            '---20060530 ���{ ADD END---
        Else
            strMenuGrpID = "000"
            '---20060530 ���{ ADD START---
            MenuID = cmb_MenuCD.Items(cmb_Menu.SelectedIndex)
            '---20060530 ���{ ADD END---
        End If
        strFileName = "MENU_" & MenuID & "_" & strMenuGrpID & "_" & Format$(Now, "yyyyMMddhhmmss") & ".jpg"

        '-- �S�R���g���[���擾
        L_Control = New Collection()
        LF_GetControl(Me.Controls)

        '-- �ǉ� or �X�V
        strSQL = ""
        strSQL = strSQL & "SELECT MENUGRPID,IMAGEFILE FROM TPM150"
        strSQL = strSQL & " WHERE MENUID = '" & MenuID & "'"
        strSQL = strSQL & "   AND MENUGRPID = '" & strMenuGrpID & "'"
        If GF_GetData(strSQL, objData) Then
            If objData.Tables("com").Rows.Count > 0 Then
                strMode = "UP"
                If Not GF_GetRows(objData, 0, objRow) Then
                    Exit Function
                End If
                strOldFileNM = Trim$(objRow("IMAGEFILE"))
            Else
                strMode = "INSERT"
                strOldFileNM = ""
            End If
        Else
            Exit Function
        End If

        For Each objControl In L_Control
            If Mid(Trim$(objControl.Name), 1, 3) = "Pos" Then

                lngPos = CInt(Replace(objControl.Name, "Pos", ""))

                ''--- 800�~600 �p
                'strSQL = ""
                'If Trim$(strMode) = "UP" Then
                '    strSQL = strSQL & "UPDATE TPM150"
                '    strSQL = strSQL & "   SET POSX1 = " & 63 * (lngPos Mod 10) & ", "
                '    strSQL = strSQL & "       POSY1 = " & 80 * (lngPos \ 10) & ", "
                '    strSQL = strSQL & "       POSX2 = " & 63 * (lngPos Mod 10 + 1) & ", "
                '    strSQL = strSQL & "       POSY2 = " & 80 * (lngPos \ 10 + 1) & ", "
                '    strSQL = strSQL & "       GROUPCD = '" & IIf(Trim$(objControl.Tag) = "", "J000", Trim$(objControl.Tag)) & "', "
                '    If L_PicChange = 1 Then
                '        strSQL = strSQL & "       IMAGEFILE = '" & strFileName & "', "
                '    End If
                '    strSQL = strSQL & "       UPDID = '" & GC_UPDID & "',"
                '    strSQL = strSQL & "       UPDYMD = '" & Now & "'"
                '    strSQL = strSQL & " WHERE MENUID = '" & MenuID & "'"  '20060530 ���{ �ύX
                '    strSQL = strSQL & "   AND MENUGRPID = '" & strMenuGrpID & "'"
                '    strSQL = strSQL & "   AND POSCNT = " & lngPos
                '    strSQL = strSQL & "   AND TERMTYPE = '1'"
                'Else
                '    strSQL = strSQL & "INSERT INTO TPM150 VALUES("
                '    strSQL = strSQL & "'" & MenuID & "', " '20060530 ���{ �ύX
                '    strSQL = strSQL & "'" & strMenuGrpID & "', "
                '    strSQL = strSQL & lngPos & ", "
                '    strSQL = strSQL & "'1', "
                '    strSQL = strSQL & 63 * (lngPos Mod 10) & ", "
                '    strSQL = strSQL & 80 * (lngPos \ 10) & ", "
                '    strSQL = strSQL & 63 * (lngPos Mod 10 + 1) & ", "
                '    strSQL = strSQL & 80 * (lngPos \ 10 + 1) & ", "
                '    strSQL = strSQL & "'" & IIf(Trim$(objControl.Tag) = "", "J000", Trim$(objControl.Tag)) & "', "
                '    strSQL = strSQL & "'" & strFileName & "', "
                '    strSQL = strSQL & "'" & GC_UPDID & "',"
                '    strSQL = strSQL & "'" & Now & "')"
                'End If

                'If Not GF_UpdData(strSQL) Then
                '    Exit Function
                'End If

                '--- 1024�~768 �p
                strSQL = ""
                If Trim$(strMode) = "UP" Then
                    strSQL = strSQL & "UPDATE TPM150"
                    strSQL = strSQL & "   SET POSX1 = " & 80 * (lngPos Mod 10) & ", "
                    strSQL = strSQL & "       POSY1 = " & 94 * (lngPos \ 10) & ", "
                    strSQL = strSQL & "       POSX2 = " & 80 * (lngPos Mod 10 + 1) & ", "
                    strSQL = strSQL & "       POSY2 = " & 94 * (lngPos \ 10 + 1) & ", "
                    strSQL = strSQL & "       GROUPCD = '" & IIf(Trim$(objControl.Tag) = "", "J000", Trim$(objControl.Tag)) & "', "
                    If L_PicChange = 1 Then
                        strSQL = strSQL & "       IMAGEFILE = '" & strFileName & "', "
                    End If
                    strSQL = strSQL & "       UPDID = '" & GC_UPDID & "',"
                    strSQL = strSQL & "       UPDYMD = '" & Now & "'"
                    strSQL = strSQL & " WHERE MENUID = '" & MenuID & "'" '20060530 ���{ �ύX
                    strSQL = strSQL & "   AND MENUGRPID = '" & strMenuGrpID & "'"
                    strSQL = strSQL & "   AND POSCNT = " & lngPos
                    strSQL = strSQL & "   AND TERMTYPE = '2'"
                Else
                    strSQL = strSQL & "INSERT INTO TPM150 VALUES("
                    strSQL = strSQL & "'" & MenuID & "', " '20060530 ���{ �ύX
                    strSQL = strSQL & "'" & strMenuGrpID & "', "
                    strSQL = strSQL & lngPos & ", "
                    strSQL = strSQL & "'2', "
                    strSQL = strSQL & 80 * (lngPos Mod 10) & ", "
                    strSQL = strSQL & 94 * (lngPos \ 10) & ", "
                    strSQL = strSQL & 80 * (lngPos Mod 10 + 1) & ", "
                    strSQL = strSQL & 94 * (lngPos \ 10 + 1) & ", "
                    strSQL = strSQL & "'" & IIf(Trim$(objControl.Tag) = "", "J000", Trim$(objControl.Tag)) & "', "
                    strSQL = strSQL & "'" & strFileName & "', "
                    strSQL = strSQL & "'" & GC_UPDID & "',"
                    strSQL = strSQL & "'" & Now & "')"
                End If

                If Not GF_UpdData(strSQL) Then
                    Exit Function
                End If

                '--- 2006.6.26 ���{ �X�V 7�C���`�Ή� ----
                '--- TERMTYPE= '3' �Ŋi�[ ---------------
                '--- 800�~480 �p
                strSQL = ""
                If Trim$(strMode) = "UP" Then
                    strSQL = strSQL & "UPDATE TPM150"
                    strSQL = strSQL & "   SET POSX1 = " & 70 * (lngPos Mod 10) & ", "
                    strSQL = strSQL & "       POSY1 = " & 78 * (lngPos \ 10) & ", "
                    strSQL = strSQL & "       POSX2 = " & 70 * (lngPos Mod 10 + 1) & ", "
                    strSQL = strSQL & "       POSY2 = " & 78 * (lngPos \ 10 + 1) & ", "
                    strSQL = strSQL & "       GROUPCD = '" & IIf(Trim$(objControl.Tag) = "", "J000", Trim$(objControl.Tag)) & "', "
                    If L_PicChange = 1 Then
                        strSQL = strSQL & "       IMAGEFILE = '" & strFileName & "', "
                    End If
                    strSQL = strSQL & "       UPDID = '" & GC_UPDID & "',"
                    strSQL = strSQL & "       UPDYMD = '" & Now & "'"
                    strSQL = strSQL & " WHERE MENUID = '" & MenuID & "'"
                    strSQL = strSQL & "   AND MENUGRPID = '" & strMenuGrpID & "'"
                    strSQL = strSQL & "   AND POSCNT = " & lngPos
                    strSQL = strSQL & "   AND TERMTYPE = '3'"
                Else
                    strSQL = strSQL & "INSERT INTO TPM150 VALUES("
                    strSQL = strSQL & "'" & MenuID & "', "
                    strSQL = strSQL & "'" & strMenuGrpID & "', "
                    strSQL = strSQL & lngPos & ", "
                    strSQL = strSQL & "'3', "
                    strSQL = strSQL & 70 * (lngPos Mod 10) & ", "
                    strSQL = strSQL & 78 * (lngPos \ 10) & ", "
                    strSQL = strSQL & 70 * (lngPos Mod 10 + 1) & ", "
                    strSQL = strSQL & 78 * (lngPos \ 10 + 1) & ", "
                    strSQL = strSQL & "'" & IIf(Trim$(objControl.Tag) = "", "J000", Trim$(objControl.Tag)) & "', "
                    strSQL = strSQL & "'" & strFileName & "', "
                    strSQL = strSQL & "'" & GC_UPDID & "',"
                    strSQL = strSQL & "'" & Now & "')"
                End If

                If Not GF_UpdData(strSQL) Then
                    Exit Function
                End If
                '----------------------------------------

            End If
        Next

        '-- �ҏW�摜���R�s�[����
        If L_PicChange = 1 Then
            If Not LF_SaveImage(strFileName, strOldFileNM) Then
                Exit Function
            End If
        End If

        LF_ExecSQL = True

    End Function

    Private Function LF_SaveImage(ByVal pFileName As String, ByVal pOldfFileNM As String) As Boolean
        ' --------------------------------------------------------------------------------
        ' �@�@�@�@�\�F�ҏW�摜�ۑ�����
        ' --------------------------------------------------------------------------------

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
            saveName = System.IO.Path.ChangeExtension(GF_GetAppInfo("GROUP_PATH") & "\" & pFileName, ext)
            If Trim$(pOldfFileNM) <> "" Then
                pOldfFileNM = System.IO.Path.ChangeExtension(GF_GetAppInfo("GROUP_PATH") & "\" & pOldfFileNM, ext)
                If System.IO.File.Exists(pOldfFileNM) = True Then
                    System.IO.File.Delete(pOldfFileNM)
                End If
            End If
            L_Bmap.Save(saveName, myImageCodecInfo, myEncoderParameters)

        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_SaveImage = True

    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' --------------------------------------------------------------------------------
        ' �@�@�@�@�\�F�ҏW�O�摜�ꗗ�������t�H���_�I���{�^�� ����������
        ' --------------------------------------------------------------------------------

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
                Call GF_Msg("E02", "", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                txt_ImgPath.Text = strSelPath
                If Len(Trim$(txt_ImgPath.Text)) <> 0 Then
                    Call LS_GridSetup_1()
                End If
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("Button3_Click")
    End Sub

    Private Sub LS_GridSetup_1()
        ' --------------------------------------------------------------------------------
        ' �@�@�@�@�\�F�ҏW�O�摜�ꗗ�O���b�h �Z�b�g�A�b�v����
        ' --------------------------------------------------------------------------------

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objTs As New DataGridTableStyle()                               ' �V����DataGridTableStyle�̍쐬
        Dim udtGridCol(1) As typGridColumn
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
            .PreferredRowHeight = 141                                       ' �W���s�����w��
            .GridLineStyle = DataGridLineStyle.None                         ' �O���b�h���C�����\���ɐݒ�
            .RowHeadersVisible = False
        End With

        '------------------------------
        ' �e���ڑ�����`
        '------------------------------
        With udtGridCol(0)                                                  ' �w�Ȕԁx����
            .intType = CNL1920.COLUMN_TYPE.IMAGE_NOEDIT_STYLE
            .strMapName = "PICTURE"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 175
            .objAlign = HorizontalAlignment.Center
        End With

        For lngCnt = 0 To UBound(udtGridCol) - 1                            ' �e���`���e�[�u���X�^�C���ɒǉ�
            Call GS_GridAddColumn(udtGridCol(lngCnt), objTs)
        Next

        With grd_ImgList
            .TableStyles.Clear()
            .TableStyles.Add(objTs)                                         ' �e�[�u���X�^�C����DataGrid�ɒǉ�
            .ReadOnly = True                                                ' �ҏW�֎~
            .AllowSorting = False                                           ' �񌩏o���N���b�N�ɂ��\�[�g���֎~
            .ColumnHeadersVisible = False
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

    Private Sub grd_ImgList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_ImgList.Click

        L_PicChange = 1

        '-- �O�̉摜�̊��t�����N���A
        LF_AllClear()

        Call LS_PictureSelect()

    End Sub

    Private Sub LS_PictureSelect()
        ' --------------------------------------------------------------------------------
        ' �ҏW�摜�I������
        ' --------------------------------------------------------------------------------

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCell As DataGridCell
        Dim strFile As String
        Dim bmap As Bitmap

        If GF_GetRowCnt(grd_ImgList) = 0 Then
            Exit Sub
        End If

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        Me.Cursor = Cursors.WaitCursor

        objCell = grd_ImgList.CurrentCell
        strFile = grd_ImgList(objCell.RowNumber, 0)
        If Len(Dir(strFile)) = 0 Then Exit Sub

        txt_ImgPath.Text = strFile

        L_Bmap.Dispose()
        bmap = New Bitmap(strFile)
        L_Bmap = New Bitmap(bmap, 800, 600)

        PicImage.Refresh()                                              ' �ҏW��̋����ĕ`��

        Me.Cursor = Cursors.Default

        Exit Sub

SYSTEM_ERROR:
        Me.Cursor = Cursors.Default
        Call GS_ErrorTerm("LS_PictureSelect")

    End Sub

    Private Sub Pos0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos0.Click
        LF_SetLabelColor(Pos0)
    End Sub

    Private Sub Pos1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos1.Click
        LF_SetLabelColor(Pos1)
    End Sub

    Private Sub Pos2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos2.Click
        LF_SetLabelColor(Pos2)
    End Sub

    Private Sub Pos3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos3.Click
        LF_SetLabelColor(Pos3)
    End Sub

    Private Sub Pos4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos4.Click
        LF_SetLabelColor(Pos4)
    End Sub

    Private Sub Pos5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos5.Click
        LF_SetLabelColor(Pos5)
    End Sub

    Private Sub Pos6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos6.Click
        LF_SetLabelColor(Pos6)
    End Sub

    Private Sub Pos7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos7.Click
        LF_SetLabelColor(Pos7)
    End Sub

    Private Sub Pos8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos8.Click
        LF_SetLabelColor(Pos8)
    End Sub

    Private Sub Pos9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos9.Click
        LF_SetLabelColor(Pos9)
    End Sub

    Private Sub Pos10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos10.Click
        LF_SetLabelColor(Pos10)
    End Sub

    Private Sub Pos11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos11.Click
        LF_SetLabelColor(Pos11)
    End Sub

    Private Sub Pos12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos12.Click
        LF_SetLabelColor(Pos12)
    End Sub

    Private Sub Pos13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos13.Click
        LF_SetLabelColor(Pos13)
    End Sub

    Private Sub Pos14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos14.Click
        LF_SetLabelColor(Pos14)
    End Sub

    Private Sub Pos15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos15.Click
        LF_SetLabelColor(Pos15)
    End Sub

    Private Sub Pos16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos16.Click
        LF_SetLabelColor(Pos16)
    End Sub

    Private Sub Pos17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos17.Click
        LF_SetLabelColor(Pos17)
    End Sub

    Private Sub Pos18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos18.Click
        LF_SetLabelColor(Pos18)
    End Sub

    Private Sub Pos19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos19.Click
        LF_SetLabelColor(Pos19)
    End Sub

    Private Sub Pos20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos20.Click
        LF_SetLabelColor(Pos20)
    End Sub

    Private Sub Pos21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos21.Click
        LF_SetLabelColor(Pos21)
    End Sub

    Private Sub Pos22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos22.Click
        LF_SetLabelColor(Pos22)
    End Sub

    Private Sub Pos23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos23.Click
        LF_SetLabelColor(Pos23)
    End Sub

    Private Sub Pos24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos24.Click
        LF_SetLabelColor(Pos24)
    End Sub

    Private Sub Pos25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos25.Click
        LF_SetLabelColor(Pos25)
    End Sub

    Private Sub Pos26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos26.Click
        LF_SetLabelColor(Pos26)
    End Sub

    Private Sub Pos27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos27.Click
        LF_SetLabelColor(Pos27)
    End Sub

    Private Sub Pos28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos28.Click
        LF_SetLabelColor(Pos28)
    End Sub

    Private Sub Pos29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos29.Click
        LF_SetLabelColor(Pos29)
    End Sub

    Private Sub Pos30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos30.Click
        LF_SetLabelColor(Pos30)
    End Sub

    Private Sub Pos31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos31.Click
        LF_SetLabelColor(Pos31)
    End Sub

    Private Sub Pos32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos32.Click
        LF_SetLabelColor(Pos32)
    End Sub

    Private Sub Pos33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos33.Click
        LF_SetLabelColor(Pos33)
    End Sub

    Private Sub Pos34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos34.Click
        LF_SetLabelColor(Pos34)
    End Sub

    Private Sub Pos35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos35.Click
        LF_SetLabelColor(Pos35)
    End Sub

    Private Sub Pos36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos36.Click
        LF_SetLabelColor(Pos36)
    End Sub

    Private Sub Pos37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos37.Click
        LF_SetLabelColor(Pos37)
    End Sub

    Private Sub Pos38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos38.Click
        LF_SetLabelColor(Pos38)
    End Sub

    Private Sub Pos39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos39.Click
        LF_SetLabelColor(Pos39)
    End Sub

    Private Sub Pos40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos40.Click
        LF_SetLabelColor(Pos40)
    End Sub

    Private Sub Pos41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos41.Click
        LF_SetLabelColor(Pos41)
    End Sub

    Private Sub Pos42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos42.Click
        LF_SetLabelColor(Pos42)
    End Sub

    Private Sub Pos43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos43.Click
        LF_SetLabelColor(Pos43)
    End Sub

    Private Sub Pos44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos44.Click
        LF_SetLabelColor(Pos44)
    End Sub

    Private Sub Pos45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos45.Click
        LF_SetLabelColor(Pos45)
    End Sub

    Private Sub Pos46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos46.Click
        LF_SetLabelColor(Pos46)
    End Sub

    Private Sub Pos47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos47.Click
        LF_SetLabelColor(Pos47)
    End Sub

    Private Sub Pos48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos48.Click
        LF_SetLabelColor(Pos48)
    End Sub

    Private Sub Pos49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos49.Click
        LF_SetLabelColor(Pos49)
    End Sub

    Private Sub Pos50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos50.Click
        LF_SetLabelColor(Pos50)
    End Sub

    Private Sub Pos51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos51.Click
        LF_SetLabelColor(Pos51)
    End Sub

    Private Sub Pos52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos52.Click
        LF_SetLabelColor(Pos52)
    End Sub

    Private Sub Pos53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos53.Click
        LF_SetLabelColor(Pos53)
    End Sub

    Private Sub Pos54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos54.Click
        LF_SetLabelColor(Pos54)
    End Sub

    Private Sub Pos55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos55.Click
        LF_SetLabelColor(Pos55)
    End Sub

    Private Sub Pos56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos56.Click
        LF_SetLabelColor(Pos56)
    End Sub

    Private Sub Pos57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos57.Click
        LF_SetLabelColor(Pos57)
    End Sub

    Private Sub Pos58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos58.Click
        LF_SetLabelColor(Pos58)
    End Sub

    Private Sub Pos59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos59.Click
        LF_SetLabelColor(Pos59)
    End Sub

    Private Sub CNL1710_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If L_EditFlg = 1 Then
            Me.DialogResult = DialogResult.Yes
        End If
    End Sub
End Class
