Imports System.Data.SqlClient

' --------------------------------------------------------------------------------
' �@�@�@�@�\�FCrossNavi - �e��ݒ���
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2011.11.07 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------
Public Class CNL2130
    Inherits System.Windows.Forms.Form


#Region " Windows �t�H�[�� �f�U�C�i�Ő������ꂽ�R�[�h "

    Public Sub New()
        MyBase.New()

        ' ���̌Ăяo���� Windows �t�H�[�� �f�U�C�i�ŕK�v�ł��B
        InitializeComponent()
        ProgressLabelDeli.Text = ""
        ProgressLabelOMOTENASHI.Text = ""

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_End As System.Windows.Forms.MenuItem
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Wait_Time As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Chg_Time As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_Logo_Hide As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Logo_Show As System.Windows.Forms.RadioButton
    Friend WithEvents txt_StoreInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_Del As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents lsv_MsgList As System.Windows.Forms.ListView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_Msg1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_Browse As System.Windows.Forms.Button
    Friend WithEvents txt_PutPath As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btn_BrowseCsv As System.Windows.Forms.Button
    Friend WithEvents txt_PutPathCsv As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btn_OutputCsv As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents text_sold_out4 As System.Windows.Forms.TextBox
    Friend WithEvents text_sold_out3 As System.Windows.Forms.TextBox
    Friend WithEvents text_sold_out2 As System.Windows.Forms.TextBox
    Friend WithEvents text_sold_out1 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents lsv_OrderDetails As System.Windows.Forms.ListView
    Friend WithEvents btn_Reprint As System.Windows.Forms.Button
    Friend WithEvents lsv_OrderList As System.Windows.Forms.ListView
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_SeatChg As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Cbo_TopChg As System.Windows.Forms.ComboBox
    Friend WithEvents sales_tax_rate As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tax_round_2 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tax_round_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents Text_alert As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Text_alert3 As System.Windows.Forms.TextBox
    Friend WithEvents Text_alert2 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents btn_ImportTECData As System.Windows.Forms.Button
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_GAMEPLAYNUM As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_GAMEHITNUM As System.Windows.Forms.TextBox
    Friend WithEvents lbl_order As System.Windows.Forms.Label
    Friend WithEvents lbl_judge As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents btnDec As System.Windows.Forms.Button
    Friend WithEvents cmbPtn As System.Windows.Forms.ComboBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents btn_Deli_Import As System.Windows.Forms.Button
    Friend WithEvents btn_OMOTENASHI_Import As System.Windows.Forms.Button
    Friend WithEvents lbl_Line1 As System.Windows.Forms.Label
    Friend WithEvents btn_BackupImport As System.Windows.Forms.Button
    Friend WithEvents lbl_Path As System.Windows.Forms.Label
    Friend WithEvents btn_Reference As System.Windows.Forms.Button
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents lbl_Msg1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Msg2 As System.Windows.Forms.Label
    Friend WithEvents prg_Bar_Deli As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_Msg3 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents btnSalesUplode As System.Windows.Forms.Button
    Friend WithEvents ProgressLabelDeli As System.Windows.Forms.Label
    Friend WithEvents ProgressLabelOMOTENASHI As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents prg_Bar_OMOTENASHI As System.Windows.Forms.ProgressBar
    Friend WithEvents btn_Output As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CNL2130))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"aaa", "a2", "a3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"bbb"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ccc"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"aaa", "a2", "a3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"bbb"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ccc"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.Text_alert3 = New System.Windows.Forms.TextBox
        Me.Text_alert2 = New System.Windows.Forms.TextBox
        Me.Text_alert = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.tax_round_1 = New System.Windows.Forms.TextBox
        Me.tax_round_2 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.sales_tax_rate = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Cbo_TopChg = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.text_sold_out4 = New System.Windows.Forms.TextBox
        Me.text_sold_out3 = New System.Windows.Forms.TextBox
        Me.text_sold_out2 = New System.Windows.Forms.TextBox
        Me.text_sold_out1 = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txt_StoreInfo = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.rdo_Logo_Hide = New System.Windows.Forms.RadioButton
        Me.rdo_Logo_Show = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_Chg_Time = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Wait_Time = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdo_Call_Hide = New System.Windows.Forms.RadioButton
        Me.rdo_Call_Show = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdo_Hide = New System.Windows.Forms.RadioButton
        Me.rdo_Show = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rdo_Kaikei_Hide = New System.Windows.Forms.RadioButton
        Me.rdo_Kaikei_Show = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rdo_Warikan_Hide = New System.Windows.Forms.RadioButton
        Me.rdo_Warikan_Show = New System.Windows.Forms.RadioButton
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.btn_BrowseCsv = New System.Windows.Forms.Button
        Me.txt_PutPathCsv = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.btn_OutputCsv = New System.Windows.Forms.Button
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label10 = New System.Windows.Forms.Label
        Me.btn_Browse = New System.Windows.Forms.Button
        Me.txt_PutPath = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btn_Output = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txt_Msg1 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.lsv_MsgList = New System.Windows.Forms.ListView
        Me.btn_Del = New System.Windows.Forms.Button
        Me.btn_Add = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.lsv_OrderDetails = New System.Windows.Forms.ListView
        Me.btn_Reprint = New System.Windows.Forms.Button
        Me.lsv_OrderList = New System.Windows.Forms.ListView
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.cbo_SeatChg = New System.Windows.Forms.ComboBox
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.btn_ImportTECData = New System.Windows.Forms.Button
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.lbl_order = New System.Windows.Forms.Label
        Me.lbl_judge = New System.Windows.Forms.Label
        Me.GroupBox15 = New System.Windows.Forms.GroupBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.txt_GAMEPLAYNUM = New System.Windows.Forms.TextBox
        Me.GroupBox14 = New System.Windows.Forms.GroupBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.txt_GAMEHITNUM = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.btnSave = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.btnDec = New System.Windows.Forms.Button
        Me.cmbPtn = New System.Windows.Forms.ComboBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.TabPage9 = New System.Windows.Forms.TabPage
        Me.ProgressLabelOMOTENASHI = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.prg_Bar_OMOTENASHI = New System.Windows.Forms.ProgressBar
        Me.ProgressLabelDeli = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.btnSalesUplode = New System.Windows.Forms.Button
        Me.lbl_Msg3 = New System.Windows.Forms.Label
        Me.lbl_Msg2 = New System.Windows.Forms.Label
        Me.prg_Bar_Deli = New System.Windows.Forms.ProgressBar
        Me.lbl_Msg1 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.btn_Reference = New System.Windows.Forms.Button
        Me.lbl_Path = New System.Windows.Forms.Label
        Me.btn_BackupImport = New System.Windows.Forms.Button
        Me.btn_Deli_Import = New System.Windows.Forms.Button
        Me.btn_OMOTENASHI_Import = New System.Windows.Forms.Button
        Me.lbl_Line1 = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.mnu_End = New System.Windows.Forms.MenuItem
        Me.stb_Msg = New System.Windows.Forms.StatusBar
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.GroupBox16 = New System.Windows.Forms.GroupBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox17 = New System.Windows.Forms.GroupBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage9.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 33
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.Location = New System.Drawing.Point(198, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(813, 656)
        Me.TabControl1.TabIndex = 151
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.GroupBox13)
        Me.TabPage2.Controls.Add(Me.GroupBox11)
        Me.TabPage2.Controls.Add(Me.GroupBox9)
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.GroupBox10)
        Me.TabPage2.Controls.Add(Me.txt_StoreInfo)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.GroupBox8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(805, 626)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "��ʑِ̍ݒ�"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(404, 460)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(147, 15)
        Me.Label21.TabIndex = 230
        Me.Label21.Text = "�� �~�[�x�����ԕ\��"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Text_alert3)
        Me.GroupBox13.Controls.Add(Me.Text_alert2)
        Me.GroupBox13.Controls.Add(Me.Text_alert)
        Me.GroupBox13.Controls.Add(Me.Label32)
        Me.GroupBox13.Controls.Add(Me.Label31)
        Me.GroupBox13.Controls.Add(Me.Label30)
        Me.GroupBox13.Controls.Add(Me.Label24)
        Me.GroupBox13.Controls.Add(Me.Label23)
        Me.GroupBox13.Controls.Add(Me.Label22)
        Me.GroupBox13.Location = New System.Drawing.Point(436, 483)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(320, 133)
        Me.GroupBox13.TabIndex = 229
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "�~�[�x�����ԕ\��"
        '
        'Text_alert3
        '
        Me.Text_alert3.Location = New System.Drawing.Point(132, 96)
        Me.Text_alert3.MaxLength = 5
        Me.Text_alert3.Name = "Text_alert3"
        Me.Text_alert3.Size = New System.Drawing.Size(100, 22)
        Me.Text_alert3.TabIndex = 8
        Me.Text_alert3.Text = "99999"
        Me.Text_alert3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Text_alert2
        '
        Me.Text_alert2.Location = New System.Drawing.Point(132, 61)
        Me.Text_alert2.MaxLength = 5
        Me.Text_alert2.Name = "Text_alert2"
        Me.Text_alert2.Size = New System.Drawing.Size(100, 22)
        Me.Text_alert2.TabIndex = 7
        Me.Text_alert2.Text = "99999"
        Me.Text_alert2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Text_alert
        '
        Me.Text_alert.Location = New System.Drawing.Point(132, 26)
        Me.Text_alert.MaxLength = 5
        Me.Text_alert.Name = "Text_alert"
        Me.Text_alert.Size = New System.Drawing.Size(100, 22)
        Me.Text_alert.TabIndex = 6
        Me.Text_alert.Text = "99999"
        Me.Text_alert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(238, 103)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(22, 15)
        Me.Label32.TabIndex = 5
        Me.Label32.Text = "�b"
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(238, 65)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(22, 15)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "�b"
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(238, 27)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(22, 15)
        Me.Label30.TabIndex = 3
        Me.Label30.Text = "�b"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(44, 103)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 15)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "3���"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(44, 68)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 15)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "2���"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(44, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 15)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "1���"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.tax_round_1)
        Me.GroupBox11.Controls.Add(Me.tax_round_2)
        Me.GroupBox11.Controls.Add(Me.Label20)
        Me.GroupBox11.Controls.Add(Me.Label19)
        Me.GroupBox11.Controls.Add(Me.Label18)
        Me.GroupBox11.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(54, 482)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(320, 62)
        Me.GroupBox11.TabIndex = 228
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "�[������"
        '
        'tax_round_1
        '
        Me.tax_round_1.Location = New System.Drawing.Point(161, 26)
        Me.tax_round_1.Name = "tax_round_1"
        Me.tax_round_1.Size = New System.Drawing.Size(41, 22)
        Me.tax_round_1.TabIndex = 4
        Me.tax_round_1.Text = "9"
        Me.tax_round_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tax_round_2
        '
        Me.tax_round_2.Image = Global.CNL1501.My.Resources.Resources.back2
        Me.tax_round_2.Location = New System.Drawing.Point(242, 30)
        Me.tax_round_2.Name = "tax_round_2"
        Me.tax_round_2.Size = New System.Drawing.Size(24, 20)
        Me.tax_round_2.TabIndex = 3
        Me.tax_round_2.Text = "99"
        '
        'Label20
        '
        Me.Label20.Image = Global.CNL1501.My.Resources.Resources.back2
        Me.Label20.Location = New System.Drawing.Point(266, 32)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(22, 16)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "��"
        '
        'Label19
        '
        Me.Label19.Image = Global.CNL1501.My.Resources.Resources.back2
        Me.Label19.Location = New System.Drawing.Point(208, 32)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(22, 16)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "��"
        '
        'Label18
        '
        Me.Label18.Image = Global.CNL1501.My.Resources.Resources.back2
        Me.Label18.Location = New System.Drawing.Point(20, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(111, 16)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "�����_����"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label16)
        Me.GroupBox9.Controls.Add(Me.sales_tax_rate)
        Me.GroupBox9.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(54, 427)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(320, 49)
        Me.GroupBox9.TabIndex = 227
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "����ŗ�"
        '
        'Label16
        '
        Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
        Me.Label16.Location = New System.Drawing.Point(266, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(22, 16)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "��"
        '
        'sales_tax_rate
        '
        Me.sales_tax_rate.Location = New System.Drawing.Point(212, 15)
        Me.sales_tax_rate.MaxLength = 2
        Me.sales_tax_rate.Name = "sales_tax_rate"
        Me.sales_tax_rate.Size = New System.Drawing.Size(41, 22)
        Me.sales_tax_rate.TabIndex = 0
        Me.sales_tax_rate.Text = "99"
        Me.sales_tax_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Cbo_TopChg)
        Me.GroupBox7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(54, 332)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(320, 61)
        Me.GroupBox7.TabIndex = 226
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "�p�^�[���؂�ւ�"
        '
        'Cbo_TopChg
        '
        Me.Cbo_TopChg.FormattingEnabled = True
        Me.Cbo_TopChg.Location = New System.Drawing.Point(48, 23)
        Me.Cbo_TopChg.Name = "Cbo_TopChg"
        Me.Cbo_TopChg.Size = New System.Drawing.Size(212, 23)
        Me.Cbo_TopChg.TabIndex = 0
        Me.Cbo_TopChg.Text = "ComboBox3"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("MS UI Gothic", 11.25!)
        Me.Label15.Location = New System.Drawing.Point(22, 404)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(248, 16)
        Me.Label15.TabIndex = 225
        Me.Label15.Text = "�� ����Őݒ�"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("MS UI Gothic", 11.25!)
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.Location = New System.Drawing.Point(22, 306)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(200, 23)
        Me.Label14.TabIndex = 224
        Me.Label14.Text = "�� �g�b�v��ʕ\���p�^�[���ύX"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.text_sold_out4)
        Me.GroupBox10.Controls.Add(Me.text_sold_out3)
        Me.GroupBox10.Controls.Add(Me.text_sold_out2)
        Me.GroupBox10.Controls.Add(Me.text_sold_out1)
        Me.GroupBox10.Controls.Add(Me.Label29)
        Me.GroupBox10.Controls.Add(Me.Label28)
        Me.GroupBox10.Controls.Add(Me.Label27)
        Me.GroupBox10.Controls.Add(Me.Label26)
        Me.GroupBox10.Font = New System.Drawing.Font("MS UI Gothic", 11.25!)
        Me.GroupBox10.Location = New System.Drawing.Point(436, 284)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(320, 168)
        Me.GroupBox10.TabIndex = 223
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "�i�؂ꕶ���ݒ�"
        '
        'text_sold_out4
        '
        Me.text_sold_out4.Location = New System.Drawing.Point(126, 123)
        Me.text_sold_out4.Name = "text_sold_out4"
        Me.text_sold_out4.Size = New System.Drawing.Size(134, 22)
        Me.text_sold_out4.TabIndex = 7
        Me.text_sold_out4.Text = "��������"
        '
        'text_sold_out3
        '
        Me.text_sold_out3.Location = New System.Drawing.Point(126, 89)
        Me.text_sold_out3.Name = "text_sold_out3"
        Me.text_sold_out3.Size = New System.Drawing.Size(134, 22)
        Me.text_sold_out3.TabIndex = 6
        Me.text_sold_out3.Text = "���ב҂�"
        '
        'text_sold_out2
        '
        Me.text_sold_out2.Location = New System.Drawing.Point(126, 56)
        Me.text_sold_out2.Name = "text_sold_out2"
        Me.text_sold_out2.Size = New System.Drawing.Size(134, 22)
        Me.text_sold_out2.TabIndex = 5
        Me.text_sold_out2.Text = "�d���ݒ�"
        '
        'text_sold_out1
        '
        Me.text_sold_out1.Location = New System.Drawing.Point(126, 23)
        Me.text_sold_out1.Name = "text_sold_out1"
        Me.text_sold_out1.Size = New System.Drawing.Size(134, 22)
        Me.text_sold_out1.TabIndex = 4
        Me.text_sold_out1.Text = "�i�؂�"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(45, 130)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(18, 15)
        Me.Label29.TabIndex = 3
        Me.Label29.Text = "4."
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(45, 96)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(18, 15)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "3."
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(45, 63)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(18, 15)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "2."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(45, 30)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(18, 15)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "1."
        '
        'txt_StoreInfo
        '
        Me.txt_StoreInfo.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_StoreInfo.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt_StoreInfo.Location = New System.Drawing.Point(54, 569)
        Me.txt_StoreInfo.MaxLength = 100
        Me.txt_StoreInfo.Multiline = True
        Me.txt_StoreInfo.Name = "txt_StoreInfo"
        Me.txt_StoreInfo.Size = New System.Drawing.Size(320, 35)
        Me.txt_StoreInfo.TabIndex = 218
        Me.txt_StoreInfo.Text = "TextBox1"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(404, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 23)
        Me.Label8.TabIndex = 219
        Me.Label8.Text = "�� �X�܏��ݒ�"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackgroundImage = CType(resources.GetObject("GroupBox8.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox8.Controls.Add(Me.rdo_Logo_Hide)
        Me.GroupBox8.Controls.Add(Me.rdo_Logo_Show)
        Me.GroupBox8.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(436, 194)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(320, 56)
        Me.GroupBox8.TabIndex = 212
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "�X�܃��S"
        '
        'rdo_Logo_Hide
        '
        Me.rdo_Logo_Hide.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Logo_Hide.Image = CType(resources.GetObject("rdo_Logo_Hide.Image"), System.Drawing.Image)
        Me.rdo_Logo_Hide.Location = New System.Drawing.Point(176, 24)
        Me.rdo_Logo_Hide.Name = "rdo_Logo_Hide"
        Me.rdo_Logo_Hide.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Logo_Hide.TabIndex = 1
        Me.rdo_Logo_Hide.Text = "�\�����Ȃ�"
        '
        'rdo_Logo_Show
        '
        Me.rdo_Logo_Show.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Logo_Show.Image = CType(resources.GetObject("rdo_Logo_Show.Image"), System.Drawing.Image)
        Me.rdo_Logo_Show.Location = New System.Drawing.Point(48, 24)
        Me.rdo_Logo_Show.Name = "rdo_Logo_Show"
        Me.rdo_Logo_Show.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Logo_Show.TabIndex = 0
        Me.rdo_Logo_Show.Text = "�\������"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(404, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(248, 16)
        Me.Label7.TabIndex = 215
        Me.Label7.Text = "�� �X�܃��S�\���ݒ�"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(22, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(248, 16)
        Me.Label6.TabIndex = 214
        Me.Label6.Text = "�� �L���\���ݒ�"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Chg_Time)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_Wait_Time)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(54, 205)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 91)
        Me.GroupBox1.TabIndex = 213
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "���Ԑݒ�"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(266, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 16)
        Me.Label4.TabIndex = 219
        Me.Label4.Text = "�b"
        '
        'txt_Chg_Time
        '
        Me.txt_Chg_Time.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_Chg_Time.Location = New System.Drawing.Point(219, 56)
        Me.txt_Chg_Time.MaxLength = 3
        Me.txt_Chg_Time.Name = "txt_Chg_Time"
        Me.txt_Chg_Time.Size = New System.Drawing.Size(41, 22)
        Me.txt_Chg_Time.TabIndex = 218
        Me.txt_Chg_Time.Text = "999"
        Me.txt_Chg_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(45, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 16)
        Me.Label5.TabIndex = 217
        Me.Label5.Text = "�L���摜�̐ؑ֎���"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(266, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 16)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "�b"
        '
        'txt_Wait_Time
        '
        Me.txt_Wait_Time.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_Wait_Time.Location = New System.Drawing.Point(219, 22)
        Me.txt_Wait_Time.MaxLength = 3
        Me.txt_Wait_Time.Name = "txt_Wait_Time"
        Me.txt_Wait_Time.Size = New System.Drawing.Size(41, 22)
        Me.txt_Wait_Time.TabIndex = 215
        Me.txt_Wait_Time.Text = "999"
        Me.txt_Wait_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(45, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 16)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "�L���\���܂ł̑҂�����"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(22, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 16)
        Me.Label3.TabIndex = 212
        Me.Label3.Text = "�� ��ʕ\���ݒ�"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.Add(Me.rdo_Call_Hide)
        Me.GroupBox3.Controls.Add(Me.rdo_Call_Show)
        Me.GroupBox3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(436, 42)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(320, 56)
        Me.GroupBox3.TabIndex = 209
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "�w�ďo�x�{�^��"
        '
        'rdo_Call_Hide
        '
        Me.rdo_Call_Hide.Image = CType(resources.GetObject("rdo_Call_Hide.Image"), System.Drawing.Image)
        Me.rdo_Call_Hide.Location = New System.Drawing.Point(176, 24)
        Me.rdo_Call_Hide.Name = "rdo_Call_Hide"
        Me.rdo_Call_Hide.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Call_Hide.TabIndex = 3
        Me.rdo_Call_Hide.Text = "�\�����Ȃ�"
        '
        'rdo_Call_Show
        '
        Me.rdo_Call_Show.Image = CType(resources.GetObject("rdo_Call_Show.Image"), System.Drawing.Image)
        Me.rdo_Call_Show.Location = New System.Drawing.Point(48, 24)
        Me.rdo_Call_Show.Name = "rdo_Call_Show"
        Me.rdo_Call_Show.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Call_Show.TabIndex = 2
        Me.rdo_Call_Show.Text = "�\������"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.rdo_Hide)
        Me.GroupBox2.Controls.Add(Me.rdo_Show)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(436, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 56)
        Me.GroupBox2.TabIndex = 210
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "���v����"
        '
        'rdo_Hide
        '
        Me.rdo_Hide.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Hide.Image = CType(resources.GetObject("rdo_Hide.Image"), System.Drawing.Image)
        Me.rdo_Hide.Location = New System.Drawing.Point(176, 24)
        Me.rdo_Hide.Name = "rdo_Hide"
        Me.rdo_Hide.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Hide.TabIndex = 1
        Me.rdo_Hide.Text = "�\�����Ȃ�"
        '
        'rdo_Show
        '
        Me.rdo_Show.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Show.Image = CType(resources.GetObject("rdo_Show.Image"), System.Drawing.Image)
        Me.rdo_Show.Location = New System.Drawing.Point(48, 24)
        Me.rdo_Show.Name = "rdo_Show"
        Me.rdo_Show.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Show.TabIndex = 0
        Me.rdo_Show.Text = "�\������"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackgroundImage = CType(resources.GetObject("GroupBox5.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox5.Controls.Add(Me.rdo_Kaikei_Hide)
        Me.GroupBox5.Controls.Add(Me.rdo_Kaikei_Show)
        Me.GroupBox5.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(54, 42)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(320, 56)
        Me.GroupBox5.TabIndex = 208
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "�w����v�x�{�^��"
        '
        'rdo_Kaikei_Hide
        '
        Me.rdo_Kaikei_Hide.Image = CType(resources.GetObject("rdo_Kaikei_Hide.Image"), System.Drawing.Image)
        Me.rdo_Kaikei_Hide.Location = New System.Drawing.Point(176, 24)
        Me.rdo_Kaikei_Hide.Name = "rdo_Kaikei_Hide"
        Me.rdo_Kaikei_Hide.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Kaikei_Hide.TabIndex = 1
        Me.rdo_Kaikei_Hide.Text = "�\�����Ȃ�"
        '
        'rdo_Kaikei_Show
        '
        Me.rdo_Kaikei_Show.Image = CType(resources.GetObject("rdo_Kaikei_Show.Image"), System.Drawing.Image)
        Me.rdo_Kaikei_Show.Location = New System.Drawing.Point(48, 24)
        Me.rdo_Kaikei_Show.Name = "rdo_Kaikei_Show"
        Me.rdo_Kaikei_Show.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Kaikei_Show.TabIndex = 0
        Me.rdo_Kaikei_Show.Text = "�\������"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = CType(resources.GetObject("GroupBox4.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox4.Controls.Add(Me.rdo_Warikan_Hide)
        Me.GroupBox4.Controls.Add(Me.rdo_Warikan_Show)
        Me.GroupBox4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(54, 106)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(320, 56)
        Me.GroupBox4.TabIndex = 211
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "�w�����x�{�^��"
        '
        'rdo_Warikan_Hide
        '
        Me.rdo_Warikan_Hide.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Warikan_Hide.Image = CType(resources.GetObject("rdo_Warikan_Hide.Image"), System.Drawing.Image)
        Me.rdo_Warikan_Hide.Location = New System.Drawing.Point(176, 24)
        Me.rdo_Warikan_Hide.Name = "rdo_Warikan_Hide"
        Me.rdo_Warikan_Hide.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Warikan_Hide.TabIndex = 1
        Me.rdo_Warikan_Hide.Text = "�\�����Ȃ�"
        '
        'rdo_Warikan_Show
        '
        Me.rdo_Warikan_Show.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Warikan_Show.Image = CType(resources.GetObject("rdo_Warikan_Show.Image"), System.Drawing.Image)
        Me.rdo_Warikan_Show.Location = New System.Drawing.Point(48, 24)
        Me.rdo_Warikan_Show.Name = "rdo_Warikan_Show"
        Me.rdo_Warikan_Show.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Warikan_Show.TabIndex = 0
        Me.rdo_Warikan_Show.Text = "�\������"
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), System.Drawing.Image)
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage4.Controls.Add(Me.Label25)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.btn_BrowseCsv)
        Me.TabPage4.Controls.Add(Me.txt_PutPathCsv)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.btn_OutputCsv)
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(805, 626)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "����f�[�^�o��"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label25.Image = CType(resources.GetObject("Label25.Image"), System.Drawing.Image)
        Me.Label25.Location = New System.Drawing.Point(230, 21)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(253, 30)
        Me.Label25.TabIndex = 202
        Me.Label25.Text = "���i���������ꂽ���ԑтƐ��ʂ��܂Ƃ߂�" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "����f�[�^��CSV�t�@�C���ŏo�͂��܂�"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.Location = New System.Drawing.Point(17, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 15)
        Me.Label12.TabIndex = 158
        Me.Label12.Text = "����f�[�^�o�͐�"
        '
        'btn_BrowseCsv
        '
        Me.btn_BrowseCsv.BackColor = System.Drawing.SystemColors.Control
        Me.btn_BrowseCsv.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_BrowseCsv.Location = New System.Drawing.Point(476, 113)
        Me.btn_BrowseCsv.Name = "btn_BrowseCsv"
        Me.btn_BrowseCsv.Size = New System.Drawing.Size(48, 24)
        Me.btn_BrowseCsv.TabIndex = 157
        Me.btn_BrowseCsv.Text = "�Q��"
        Me.btn_BrowseCsv.UseVisualStyleBackColor = False
        '
        'txt_PutPathCsv
        '
        Me.txt_PutPathCsv.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_PutPathCsv.Location = New System.Drawing.Point(20, 115)
        Me.txt_PutPathCsv.Name = "txt_PutPathCsv"
        Me.txt_PutPathCsv.Size = New System.Drawing.Size(450, 22)
        Me.txt_PutPathCsv.TabIndex = 156
        Me.txt_PutPathCsv.Text = "�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label13.Location = New System.Drawing.Point(5, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(794, 1)
        Me.Label13.TabIndex = 155
        '
        'btn_OutputCsv
        '
        Me.btn_OutputCsv.BackColor = System.Drawing.SystemColors.Control
        Me.btn_OutputCsv.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_OutputCsv.Location = New System.Drawing.Point(20, 10)
        Me.btn_OutputCsv.Name = "btn_OutputCsv"
        Me.btn_OutputCsv.Size = New System.Drawing.Size(180, 50)
        Me.btn_OutputCsv.TabIndex = 154
        Me.btn_OutputCsv.Text = "����f�[�^�o��"
        Me.btn_OutputCsv.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.btn_Browse)
        Me.TabPage1.Controls.Add(Me.txt_PutPath)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.btn_Output)
        Me.TabPage1.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(805, 626)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "�f�[�^�o�b�N�A�b�v"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.Location = New System.Drawing.Point(17, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 15)
        Me.Label10.TabIndex = 153
        Me.Label10.Text = "�f�[�^�o�b�N�A�b�v�o�͐�"
        '
        'btn_Browse
        '
        Me.btn_Browse.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Browse.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Browse.Location = New System.Drawing.Point(476, 113)
        Me.btn_Browse.Name = "btn_Browse"
        Me.btn_Browse.Size = New System.Drawing.Size(48, 24)
        Me.btn_Browse.TabIndex = 152
        Me.btn_Browse.Text = "�Q��"
        Me.btn_Browse.UseVisualStyleBackColor = False
        '
        'txt_PutPath
        '
        Me.txt_PutPath.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_PutPath.Location = New System.Drawing.Point(20, 115)
        Me.txt_PutPath.Name = "txt_PutPath"
        Me.txt_PutPath.Size = New System.Drawing.Size(450, 22)
        Me.txt_PutPath.TabIndex = 151
        Me.txt_PutPath.Text = "�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(5, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(794, 1)
        Me.Label11.TabIndex = 150
        '
        'btn_Output
        '
        Me.btn_Output.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Output.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Output.Location = New System.Drawing.Point(20, 10)
        Me.btn_Output.Name = "btn_Output"
        Me.btn_Output.Size = New System.Drawing.Size(180, 50)
        Me.btn_Output.TabIndex = 14
        Me.btn_Output.Text = "�f�[�^�o��"
        Me.btn_Output.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Transparent
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.lsv_MsgList)
        Me.TabPage3.Controls.Add(Me.btn_Del)
        Me.TabPage3.Controls.Add(Me.btn_Add)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(805, 626)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "���M���b�Z�[�W�ҏW"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackgroundImage = CType(resources.GetObject("GroupBox6.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox6.Controls.Add(Me.txt_Msg1)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(355, 93)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(425, 69)
        Me.GroupBox6.TabIndex = 276
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "���M���b�Z�[�W�ҏW"
        '
        'txt_Msg1
        '
        Me.txt_Msg1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Msg1.Location = New System.Drawing.Point(119, 32)
        Me.txt_Msg1.Name = "txt_Msg1"
        Me.txt_Msg1.Size = New System.Drawing.Size(280, 22)
        Me.txt_Msg1.TabIndex = 275
        Me.txt_Msg1.Text = "�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.Location = New System.Drawing.Point(18, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 16)
        Me.Label17.TabIndex = 274
        Me.Label17.Text = "���b�Z�[�W"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lsv_MsgList
        '
        Me.lsv_MsgList.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_MsgList.Location = New System.Drawing.Point(27, 93)
        Me.lsv_MsgList.Name = "lsv_MsgList"
        Me.lsv_MsgList.Size = New System.Drawing.Size(304, 517)
        Me.lsv_MsgList.TabIndex = 154
        Me.lsv_MsgList.UseCompatibleStateImageBehavior = False
        Me.lsv_MsgList.View = System.Windows.Forms.View.Details
        '
        'btn_Del
        '
        Me.btn_Del.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Del.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Del.Location = New System.Drawing.Point(215, 10)
        Me.btn_Del.Name = "btn_Del"
        Me.btn_Del.Size = New System.Drawing.Size(180, 50)
        Me.btn_Del.TabIndex = 153
        Me.btn_Del.Text = "�I�𒆂̃��b�Z�[�W�폜"
        Me.btn_Del.UseVisualStyleBackColor = False
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Add.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Add.Location = New System.Drawing.Point(20, 10)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(180, 50)
        Me.btn_Add.TabIndex = 152
        Me.btn_Add.Text = "���b�Z�[�W�ǉ�"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(5, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(794, 1)
        Me.Label9.TabIndex = 151
        '
        'TabPage5
        '
        Me.TabPage5.BackgroundImage = CType(resources.GetObject("TabPage5.BackgroundImage"), System.Drawing.Image)
        Me.TabPage5.Controls.Add(Me.lsv_OrderDetails)
        Me.TabPage5.Controls.Add(Me.btn_Reprint)
        Me.TabPage5.Controls.Add(Me.lsv_OrderList)
        Me.TabPage5.Controls.Add(Me.GroupBox12)
        Me.TabPage5.Location = New System.Drawing.Point(4, 26)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(805, 626)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "�����ꗗ"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lsv_OrderDetails
        '
        Me.lsv_OrderDetails.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ListViewItem1.StateImageIndex = 0
        ListViewItem1.UseItemStyleForSubItems = False
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.StateImageIndex = 0
        Me.lsv_OrderDetails.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.lsv_OrderDetails.Location = New System.Drawing.Point(436, 105)
        Me.lsv_OrderDetails.MultiSelect = False
        Me.lsv_OrderDetails.Name = "lsv_OrderDetails"
        Me.lsv_OrderDetails.Size = New System.Drawing.Size(357, 505)
        Me.lsv_OrderDetails.TabIndex = 259
        Me.lsv_OrderDetails.UseCompatibleStateImageBehavior = False
        Me.lsv_OrderDetails.View = System.Windows.Forms.View.Details
        '
        'btn_Reprint
        '
        Me.btn_Reprint.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Reprint.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Reprint.Location = New System.Drawing.Point(506, 27)
        Me.btn_Reprint.Name = "btn_Reprint"
        Me.btn_Reprint.Size = New System.Drawing.Size(208, 59)
        Me.btn_Reprint.TabIndex = 258
        Me.btn_Reprint.Text = "�Ĉ�"
        Me.btn_Reprint.UseVisualStyleBackColor = False
        '
        'lsv_OrderList
        '
        Me.lsv_OrderList.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ListViewItem4.StateImageIndex = 0
        ListViewItem4.UseItemStyleForSubItems = False
        ListViewItem5.StateImageIndex = 0
        ListViewItem6.StateImageIndex = 0
        Me.lsv_OrderList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4, ListViewItem5, ListViewItem6})
        Me.lsv_OrderList.Location = New System.Drawing.Point(6, 68)
        Me.lsv_OrderList.MultiSelect = False
        Me.lsv_OrderList.Name = "lsv_OrderList"
        Me.lsv_OrderList.Size = New System.Drawing.Size(413, 542)
        Me.lsv_OrderList.TabIndex = 257
        Me.lsv_OrderList.UseCompatibleStateImageBehavior = False
        Me.lsv_OrderList.View = System.Windows.Forms.View.Details
        '
        'GroupBox12
        '
        Me.GroupBox12.BackgroundImage = CType(resources.GetObject("GroupBox12.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox12.Controls.Add(Me.cbo_SeatChg)
        Me.GroupBox12.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(326, 56)
        Me.GroupBox12.TabIndex = 255
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "���Ȕԍ��i����"
        '
        'cbo_SeatChg
        '
        Me.cbo_SeatChg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_SeatChg.Location = New System.Drawing.Point(27, 21)
        Me.cbo_SeatChg.Name = "cbo_SeatChg"
        Me.cbo_SeatChg.Size = New System.Drawing.Size(279, 23)
        Me.cbo_SeatChg.TabIndex = 30
        Me.cbo_SeatChg.Text = "���Ȕԍ�"
        '
        'TabPage6
        '
        Me.TabPage6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage6.Controls.Add(Me.btn_ImportTECData)
        Me.TabPage6.Location = New System.Drawing.Point(4, 26)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(805, 626)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "TEC�f�[�^�捞"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'btn_ImportTECData
        '
        Me.btn_ImportTECData.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_ImportTECData.Location = New System.Drawing.Point(20, 10)
        Me.btn_ImportTECData.Name = "btn_ImportTECData"
        Me.btn_ImportTECData.Size = New System.Drawing.Size(180, 50)
        Me.btn_ImportTECData.TabIndex = 0
        Me.btn_ImportTECData.Text = "TEC�f�[�^�捞"
        Me.btn_ImportTECData.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.Transparent
        Me.TabPage7.BackgroundImage = CType(resources.GetObject("TabPage7.BackgroundImage"), System.Drawing.Image)
        Me.TabPage7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage7.Controls.Add(Me.lbl_order)
        Me.TabPage7.Controls.Add(Me.lbl_judge)
        Me.TabPage7.Controls.Add(Me.GroupBox15)
        Me.TabPage7.Controls.Add(Me.GroupBox14)
        Me.TabPage7.Controls.Add(Me.Label33)
        Me.TabPage7.Location = New System.Drawing.Point(4, 26)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(805, 626)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "�Q�[���ݒ�"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'lbl_order
        '
        Me.lbl_order.AutoSize = True
        Me.lbl_order.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_order.Location = New System.Drawing.Point(45, 247)
        Me.lbl_order.Name = "lbl_order"
        Me.lbl_order.Size = New System.Drawing.Size(88, 15)
        Me.lbl_order.TabIndex = 4
        Me.lbl_order.Text = "���݁A�l���`"
        '
        'lbl_judge
        '
        Me.lbl_judge.AutoSize = True
        Me.lbl_judge.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_judge.Location = New System.Drawing.Point(45, 215)
        Me.lbl_judge.Name = "lbl_judge"
        Me.lbl_judge.Size = New System.Drawing.Size(143, 15)
        Me.lbl_judge.TabIndex = 3
        Me.lbl_judge.Text = "�V�X�e���������ł��B"
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.Label35)
        Me.GroupBox15.Controls.Add(Me.txt_GAMEPLAYNUM)
        Me.GroupBox15.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox15.Location = New System.Drawing.Point(48, 133)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(320, 56)
        Me.GroupBox15.TabIndex = 2
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "1�Q�[���v���C���邽�߂̒�����"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(54, 24)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(156, 15)
        Me.Label35.TabIndex = 1
        Me.Label35.Text = "���i������1�Q�[���v���C"
        '
        'txt_GAMEPLAYNUM
        '
        Me.txt_GAMEPLAYNUM.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_GAMEPLAYNUM.Location = New System.Drawing.Point(6, 21)
        Me.txt_GAMEPLAYNUM.MaxLength = 2
        Me.txt_GAMEPLAYNUM.Name = "txt_GAMEPLAYNUM"
        Me.txt_GAMEPLAYNUM.Size = New System.Drawing.Size(42, 22)
        Me.txt_GAMEPLAYNUM.TabIndex = 0
        Me.txt_GAMEPLAYNUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.Label34)
        Me.GroupBox14.Controls.Add(Me.txt_GAMEHITNUM)
        Me.GroupBox14.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox14.Location = New System.Drawing.Point(48, 52)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(320, 56)
        Me.GroupBox14.TabIndex = 1
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "�Q�[�������蔻���"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(54, 24)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(162, 15)
        Me.Label34.TabIndex = 1
        Me.Label34.Text = "��Q�[���v���C��1�񓖂���"
        '
        'txt_GAMEHITNUM
        '
        Me.txt_GAMEHITNUM.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_GAMEHITNUM.Location = New System.Drawing.Point(6, 21)
        Me.txt_GAMEHITNUM.MaxLength = 2
        Me.txt_GAMEHITNUM.Name = "txt_GAMEHITNUM"
        Me.txt_GAMEHITNUM.Size = New System.Drawing.Size(42, 22)
        Me.txt_GAMEHITNUM.TabIndex = 0
        Me.txt_GAMEHITNUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label33.Location = New System.Drawing.Point(22, 18)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(248, 16)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "���Q�[��������ݒ�"
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.Color.Transparent
        Me.TabPage8.BackgroundImage = CType(resources.GetObject("TabPage8.BackgroundImage"), System.Drawing.Image)
        Me.TabPage8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage8.Controls.Add(Me.btnSave)
        Me.TabPage8.Controls.Add(Me.DataGridView1)
        Me.TabPage8.Controls.Add(Me.Label42)
        Me.TabPage8.Controls.Add(Me.Label41)
        Me.TabPage8.Controls.Add(Me.btnDec)
        Me.TabPage8.Controls.Add(Me.cmbPtn)
        Me.TabPage8.Controls.Add(Me.Label45)
        Me.TabPage8.Location = New System.Drawing.Point(4, 26)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(805, 626)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "�o�͐�p�^�[���ݒ�"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Location = New System.Drawing.Point(361, 140)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "�ۑ�"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGridView1.Location = New System.Drawing.Point(41, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(720, 406)
        Me.DataGridView1.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.HeaderText = "�o�͐�"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label42.Location = New System.Drawing.Point(62, 144)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(142, 15)
        Me.Label42.TabIndex = 8
        Me.Label42.Text = "���o�͐�p�^�[���ݒ�"
        '
        'Label41
        '
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.Location = New System.Drawing.Point(41, 113)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(720, 1)
        Me.Label41.TabIndex = 7
        '
        'btnDec
        '
        Me.btnDec.BackColor = System.Drawing.SystemColors.Control
        Me.btnDec.Location = New System.Drawing.Point(361, 61)
        Me.btnDec.Name = "btnDec"
        Me.btnDec.Size = New System.Drawing.Size(75, 25)
        Me.btnDec.TabIndex = 6
        Me.btnDec.Text = "����"
        Me.btnDec.UseVisualStyleBackColor = False
        '
        'cmbPtn
        '
        Me.cmbPtn.FormattingEnabled = True
        Me.cmbPtn.Location = New System.Drawing.Point(130, 60)
        Me.cmbPtn.Name = "cmbPtn"
        Me.cmbPtn.Size = New System.Drawing.Size(180, 24)
        Me.cmbPtn.TabIndex = 5
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label45.Location = New System.Drawing.Point(62, 30)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(248, 16)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "�����ݎg�p���Ă���o�͐�p�^�[��"
        '
        'TabPage9
        '
        Me.TabPage9.BackColor = System.Drawing.Color.Transparent
        Me.TabPage9.BackgroundImage = CType(resources.GetObject("TabPage9.BackgroundImage"), System.Drawing.Image)
        Me.TabPage9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage9.Controls.Add(Me.ProgressLabelOMOTENASHI)
        Me.TabPage9.Controls.Add(Me.Label48)
        Me.TabPage9.Controls.Add(Me.prg_Bar_OMOTENASHI)
        Me.TabPage9.Controls.Add(Me.ProgressLabelDeli)
        Me.TabPage9.Controls.Add(Me.Label44)
        Me.TabPage9.Controls.Add(Me.Label43)
        Me.TabPage9.Controls.Add(Me.btnSalesUplode)
        Me.TabPage9.Controls.Add(Me.lbl_Msg3)
        Me.TabPage9.Controls.Add(Me.lbl_Msg2)
        Me.TabPage9.Controls.Add(Me.prg_Bar_Deli)
        Me.TabPage9.Controls.Add(Me.lbl_Msg1)
        Me.TabPage9.Controls.Add(Me.Label46)
        Me.TabPage9.Controls.Add(Me.btn_Reference)
        Me.TabPage9.Controls.Add(Me.lbl_Path)
        Me.TabPage9.Controls.Add(Me.btn_BackupImport)
        Me.TabPage9.Controls.Add(Me.btn_Deli_Import)
        Me.TabPage9.Controls.Add(Me.btn_OMOTENASHI_Import)
        Me.TabPage9.Controls.Add(Me.lbl_Line1)
        Me.TabPage9.Location = New System.Drawing.Point(4, 26)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(805, 626)
        Me.TabPage9.TabIndex = 6
        Me.TabPage9.Text = "�{���z�M"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'ProgressLabelOMOTENASHI
        '
        Me.ProgressLabelOMOTENASHI.AutoSize = True
        Me.ProgressLabelOMOTENASHI.Location = New System.Drawing.Point(6, 518)
        Me.ProgressLabelOMOTENASHI.Name = "ProgressLabelOMOTENASHI"
        Me.ProgressLabelOMOTENASHI.Size = New System.Drawing.Size(16, 16)
        Me.ProgressLabelOMOTENASHI.TabIndex = 91
        Me.ProgressLabelOMOTENASHI.Text = "s"
        '
        'Label48
        '
        Me.Label48.Location = New System.Drawing.Point(6, 486)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(85, 23)
        Me.Label48.TabIndex = 90
        Me.Label48.Text = "�捞��"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'prg_Bar_OMOTENASHI
        '
        Me.prg_Bar_OMOTENASHI.Location = New System.Drawing.Point(108, 486)
        Me.prg_Bar_OMOTENASHI.Maximum = 1000
        Me.prg_Bar_OMOTENASHI.Name = "prg_Bar_OMOTENASHI"
        Me.prg_Bar_OMOTENASHI.Size = New System.Drawing.Size(270, 23)
        Me.prg_Bar_OMOTENASHI.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prg_Bar_OMOTENASHI.TabIndex = 89
        '
        'ProgressLabelDeli
        '
        Me.ProgressLabelDeli.AutoSize = True
        Me.ProgressLabelDeli.Location = New System.Drawing.Point(6, 122)
        Me.ProgressLabelDeli.Name = "ProgressLabelDeli"
        Me.ProgressLabelDeli.Size = New System.Drawing.Size(16, 16)
        Me.ProgressLabelDeli.TabIndex = 13
        Me.ProgressLabelDeli.Text = "s"
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(1, 387)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(794, 1)
        Me.Label44.TabIndex = 12
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(214, 304)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(324, 78)
        Me.Label43.TabIndex = 11
        Me.Label43.Text = "����f�[�^���W�v���A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�{��SV�ɃA�b�v���[�h���܂��B"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalesUplode
        '
        Me.btnSalesUplode.AutoSize = True
        Me.btnSalesUplode.BackColor = System.Drawing.Color.LightGray
        Me.btnSalesUplode.Location = New System.Drawing.Point(7, 295)
        Me.btnSalesUplode.Name = "btnSalesUplode"
        Me.btnSalesUplode.Size = New System.Drawing.Size(183, 78)
        Me.btnSalesUplode.TabIndex = 10
        Me.btnSalesUplode.Text = "����f�[�^" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�A�b�v���[�h"
        Me.btnSalesUplode.UseVisualStyleBackColor = False
        '
        'lbl_Msg3
        '
        Me.lbl_Msg3.Location = New System.Drawing.Point(191, 162)
        Me.lbl_Msg3.Name = "lbl_Msg3"
        Me.lbl_Msg3.Size = New System.Drawing.Size(324, 78)
        Me.lbl_Msg3.TabIndex = 9
        Me.lbl_Msg3.Text = "�o�b�N�A�b�v�f�[�^���" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "���j���[�𕜌����܂��B"
        Me.lbl_Msg3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Msg2
        '
        Me.lbl_Msg2.Location = New System.Drawing.Point(6, 90)
        Me.lbl_Msg2.Name = "lbl_Msg2"
        Me.lbl_Msg2.Size = New System.Drawing.Size(85, 23)
        Me.lbl_Msg2.TabIndex = 8
        Me.lbl_Msg2.Text = "�捞��"
        Me.lbl_Msg2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'prg_Bar_Deli
        '
        Me.prg_Bar_Deli.Location = New System.Drawing.Point(108, 90)
        Me.prg_Bar_Deli.Maximum = 1000
        Me.prg_Bar_Deli.Name = "prg_Bar_Deli"
        Me.prg_Bar_Deli.Size = New System.Drawing.Size(270, 23)
        Me.prg_Bar_Deli.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prg_Bar_Deli.TabIndex = 7
        '
        'lbl_Msg1
        '
        Me.lbl_Msg1.Location = New System.Drawing.Point(191, 6)
        Me.lbl_Msg1.Name = "lbl_Msg1"
        Me.lbl_Msg1.Size = New System.Drawing.Size(387, 78)
        Me.lbl_Msg1.TabIndex = 6
        Me.lbl_Msg1.Text = "�{�����z�M�����" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "���j���[�f�[�^����荞�݂܂��B" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�S�T�`�U�O���������Ԃ𒸑Ղ��܂��B" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "������󋵂ɂ���L���|����ꍇ������܂��B" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbl_Msg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label46
        '
        Me.Label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label46.Location = New System.Drawing.Point(4, 280)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(794, 1)
        Me.Label46.TabIndex = 5
        Me.Label46.Text = " "
        '
        'btn_Reference
        '
        Me.btn_Reference.BackColor = System.Drawing.Color.LightGray
        Me.btn_Reference.Location = New System.Drawing.Point(462, 247)
        Me.btn_Reference.Name = "btn_Reference"
        Me.btn_Reference.Size = New System.Drawing.Size(72, 24)
        Me.btn_Reference.TabIndex = 4
        Me.btn_Reference.Text = "�Q��"
        Me.btn_Reference.UseVisualStyleBackColor = False
        '
        'lbl_Path
        '
        Me.lbl_Path.BackColor = System.Drawing.Color.White
        Me.lbl_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Path.Location = New System.Drawing.Point(6, 249)
        Me.lbl_Path.Name = "lbl_Path"
        Me.lbl_Path.Size = New System.Drawing.Size(450, 22)
        Me.lbl_Path.TabIndex = 3
        '
        'btn_BackupImport
        '
        Me.btn_BackupImport.BackColor = System.Drawing.Color.LightGray
        Me.btn_BackupImport.Location = New System.Drawing.Point(6, 162)
        Me.btn_BackupImport.Name = "btn_BackupImport"
        Me.btn_BackupImport.Size = New System.Drawing.Size(165, 78)
        Me.btn_BackupImport.TabIndex = 2
        Me.btn_BackupImport.Text = "�o�b�N�A�b�v" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "���j���[�f�[�^�捞"
        Me.btn_BackupImport.UseVisualStyleBackColor = False
        '
        'btn_Deli_Import
        '
        Me.btn_Deli_Import.BackColor = System.Drawing.Color.LightGray
        Me.btn_Deli_Import.Location = New System.Drawing.Point(6, 6)
        Me.btn_Deli_Import.Name = "btn_Deli_Import"
        Me.btn_Deli_Import.Size = New System.Drawing.Size(165, 78)
        Me.btn_Deli_Import.TabIndex = 1
        Me.btn_Deli_Import.Text = "�{�����j���[�f�[�^" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�捞"
        Me.btn_Deli_Import.UseVisualStyleBackColor = False
        '
        'btn_OMOTENASHI_Import
        '
        Me.btn_OMOTENASHI_Import.BackColor = System.Drawing.Color.LightGray
        Me.btn_OMOTENASHI_Import.Enabled = False
        Me.btn_OMOTENASHI_Import.Font = New System.Drawing.Font("�l�r �o�S�V�b�N", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_OMOTENASHI_Import.Location = New System.Drawing.Point(6, 402)
        Me.btn_OMOTENASHI_Import.Name = "btn_OMOTENASHI_Import"
        Me.btn_OMOTENASHI_Import.Size = New System.Drawing.Size(165, 78)
        Me.btn_OMOTENASHI_Import.TabIndex = 88
        Me.btn_OMOTENASHI_Import.Text = "OMOTENASHI�f�[�^" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�捞"
        Me.btn_OMOTENASHI_Import.UseVisualStyleBackColor = False
        '
        'lbl_Line1
        '
        Me.lbl_Line1.BackColor = System.Drawing.Color.Black
        Me.lbl_Line1.Location = New System.Drawing.Point(4, 149)
        Me.lbl_Line1.Name = "lbl_Line1"
        Me.lbl_Line1.Size = New System.Drawing.Size(794, 1)
        Me.lbl_Line1.TabIndex = 0
        Me.lbl_Line1.Text = " "
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.mnu_End})
        Me.MenuItem1.Text = "�e��ݒ�"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "-"
        '
        'mnu_End
        '
        Me.mnu_End.Index = 1
        Me.mnu_End.Text = "�I��(&E)"
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 665)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(1016, 24)
        Me.stb_Msg.TabIndex = 34
        Me.stb_Msg.Text = "StatusBar1"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label36.Location = New System.Drawing.Point(45, 247)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(88, 15)
        Me.Label36.TabIndex = 4
        Me.Label36.Text = "���݁A�l���`"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label37.Location = New System.Drawing.Point(45, 215)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(143, 15)
        Me.Label37.TabIndex = 3
        Me.Label37.Text = "�V�X�e���������ł��B"
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.Label38)
        Me.GroupBox16.Controls.Add(Me.TextBox1)
        Me.GroupBox16.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox16.Location = New System.Drawing.Point(48, 133)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(320, 56)
        Me.GroupBox16.TabIndex = 2
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "1�Q�[���v���C���邽�߂̒�����"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(54, 24)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(156, 15)
        Me.Label38.TabIndex = 1
        Me.Label38.Text = "���i������1�Q�[���v���C"
        '
        'TextBox1
        '
        Me.TextBox1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBox1.Location = New System.Drawing.Point(6, 21)
        Me.TextBox1.MaxLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(42, 22)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.Label39)
        Me.GroupBox17.Controls.Add(Me.TextBox2)
        Me.GroupBox17.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox17.Location = New System.Drawing.Point(48, 52)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(320, 56)
        Me.GroupBox17.TabIndex = 1
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "�Q�[�������蔻���"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(54, 24)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(162, 15)
        Me.Label39.TabIndex = 1
        Me.Label39.Text = "��Q�[���v���C��1�񓖂���"
        '
        'TextBox2
        '
        Me.TextBox2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBox2.Location = New System.Drawing.Point(6, 21)
        Me.TextBox2.MaxLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(42, 22)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label40.Location = New System.Drawing.Point(22, 18)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(248, 16)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "���Q�[��������ݒ�"
        '
        'CNL2130
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1016, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stb_Msg)
        Me.Menu = Me.MainMenu1
        Me.Name = "CNL2130"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNL2130"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' --------------------------------------------------------------------------------
    ' ���W���[�����ϐ���`
    ' --------------------------------------------------------------------------------
    Private L_blnEdit As Boolean
    Private L_ProcFlg As Boolean
    Private fgCheckM555 As Boolean = False

    Private Enum typDataKind
        MenuData = 0
        AdvData = 1
    End Enum

    Private Enum typUpdKbn
        CHGTIME = 0
        CHGINT = 1
        STOREINFO = 2
        SUBTOTAL = 3
        CALL_FLG = 4
        KAIKEI_FLG = 5
        WARIKAN_FLG = 6
        LOGO_VIEW = 7
    End Enum
    Private Enum typUpdata

        ALERT_TIME = 0
        ALERT_TIME2 = 1
        ALERT_TIME3 = 2
        ' 2014-07-05 �i�؂ꖼ��2�킪�ύX�ł��Ȃ��s��C��
        'SOLDOUT_NM = 1
        'SOLDOUT_NM_2 = 2
        'SOLDOUT_NM_3 = 3
        'SOLDOUT_NM_4 = 4
        'TAX_RATE = 5
        'ROUND_OFF = 6
        SOLDOUT_NM = 3
        SOLDOUT_NM_2 = 4
        SOLDOUT_NM_3 = 5
        SOLDOUT_NM_4 = 6
        TAX_RATE = 7
        ROUND_OFF = 8


    End Enum

    ' START 2016.05.10 �c��
    Private Enum typUpdata_game

        GAMEHITNUM = 0
        GAMEPLAYNUM = 1

    End Enum
    ' END 2016.05.10 �c��

    Private Structure typMsg
        Dim strMsgCD As String
        Dim strMsg As String
    End Structure

    Private Structure typConnectionInfo
        Dim strSVNM As String
        Dim strDBNM As String
        Dim strUserNM As String
        Dim strPasswd As String

        ''Dim strPutPath As String
        Dim strAdvPath As String
        Dim strItemPath As String
        Dim strGrpPath As String
        Dim strMenuGrpPath As String
        Dim strStoreMkPath As String
    End Structure

    ' ------------------------------------------------------------------------------
    ' ���W���[�������[�U��`�^��`
    ' ------------------------------------------------------------------------------
    Private Structure strOrderData
        Dim SHOHINKIND As String
        Dim SHOHIN As String
        Dim OUTSHOHIN As String
        Dim SHOHINNM As String
        Dim TIME00 As String
        Dim TIME01 As String
        Dim TIME02 As String
        Dim TIME03 As String
        Dim TIME04 As String
        Dim TIME05 As String
        Dim TIME06 As String
        Dim TIME07 As String
        Dim TIME08 As String
        Dim TIME09 As String
        Dim TIME10 As String
        Dim TIME11 As String
        Dim TIME12 As String
        Dim TIME13 As String
        Dim TIME14 As String
        Dim TIME15 As String
        Dim TIME16 As String
        Dim TIME17 As String
        Dim TIME18 As String
        Dim TIME19 As String
        Dim TIME20 As String
        Dim TIME21 As String
        Dim TIME22 As String
        Dim TIME23 As String
        Dim URIAGE As String
        Dim URIAGE_NUM As String
    End Structure

    Private L_OrderData As strOrderData

    Private Structure strOrderDataKEY
        Dim SHOHIN As String
    End Structure

    Private L_OrderDatakey As strOrderDataKEY

    Private Const LC_ALL_SELECT As String = "0"
    Private Const LC_NO_SEATID As String = "0"
    Private Const LC_NO_ORDERNO As Integer = 0

    ' 2020-03-03
    Private L_OMOTENASHI_DISH_fr As String
    Private L_OMOTENASHI_DISH_to As String

    ' 2022-04 prg_Bar_Deli or prg_Bar_OMOTENASHI
    Private targetPrgBar As Windows.Forms.ProgressBar
    ' 2022-04 ProgressLabelDeli or ProgressLabelOMOTENASHI
    Private targetPrgLabel As Windows.Forms.Label
    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���ǂݍ��ݎ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub CNL2130_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            '------------------------------
            ' �t�H�[�����̐ݒ�
            '------------------------------
            Me.Text = " �e��ݒ� "

            '---------------------------------
            ' ����{�^����\����
            '---------------------------------
            Me.ControlBox = False

            '------------------------------
            ' ����������
            '------------------------------
            Call GS_StatusSetup(stb_Msg)

            '------------------------------
            ' ��ʑِ̍ݒ� �\������
            '------------------------------
            Call LS_SetInitForm()

            L_blnEdit = False

            If GF_GetAppInfo("RECEIPT_PRINTING") = 1 Then
                TabControl1.TabPages.Remove(TabPage5)
            End If

            '------------------------------
            ' 2015.9.29 OA) TEC�f�[�^�捞
            '------------------------------
            If Not (GF_GetAppInfo("SYS_TYPE") = 2 And GF_GetAppInfo("OES_TOOL_VER") = 0 And GF_GetAppInfo("OES_TOOL_VER_CNL1501") = 0) Then
                TabControl1.TabPages.Remove(TabPage6)
            End If

            '--------------------------------
            ' 2016.05.10 �c�� �Q�[���@�\�C��
            '--------------------------------
            If Not GF_GetAppInfo2("CNWH_GAMEFLG") = 1 Then
                TabControl1.TabPages.Remove(TabPage7)
            End If

            ' 2017.01.01 �����Ă���i���� �N���X�R�k�� �c��
            If Not GF_GetAppInfo3("KCP_PTN_FLG") = "1" Then
                TabControl1.TabPages.Remove(TabPage8)
            End If
            ' 2017.01.01 �����Ă���i���� �N���X�R�k�� �c��

            ' 2017.10.01 �{���z�M �N���X�R�k�� �c��
            If GF_GetAppInfo("DELIVARY_FLG") = "0" Then
                TabControl1.TabPages.Remove(TabPage9)
            End If
            ' 2017.10.01 �{���z�M �N���X�R�k�� �c��

            ' 2020-03-03
            Dim strVal As String = Trim$(GF_GetAppInfo("OMOTENASHI_DISH"))
            If strVal <> "" Then
                Dim parts As String()
                parts = Split(strVal, "/", -1, CompareMethod.Binary)
                L_OMOTENASHI_DISH_fr = parts(0)
                L_OMOTENASHI_DISH_to = parts(1)
            Else
                L_OMOTENASHI_DISH_fr = "0000"
                L_OMOTENASHI_DISH_to = "0000"
            End If

            Dim objData As New DataSet()
            Dim objRows As DataRow = Nothing
            Dim strSQL As String = "IF EXISTS(SELECT * FROM sys.columns WHERE Name = N'sort_order' AND Object_ID = OBJECT_ID(N'TPM555'))"
            strSQL &= "  SELECT 'yes' AS answer"
            strSQL &= " ELSE"
            strSQL &= "  SELECT 'no' AS answer"
            If GF_GetData(strSQL, objData) Then
                If objData.Tables("com").Rows.Count = 1 Then
                    If GF_GetRows(objData, 0, objRows) Then
                        If objRows("answer") = "yes" Then
                            fgCheckM555 = True
                        End If
                    End If
                End If
            End If

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL2130_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[ - [�I��]����������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub mnu_End_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_End.Click
        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u�f�[�^�o�́v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Output_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Output.Click
        targetPrgLabel = ProgressLabelDeli
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objInfo As typConnectionInfo = Nothing

        With objInfo
            .strSVNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer Name"))
            .strDBNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer DBName"))
            .strUserNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer UserID"))
            .strPasswd = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer PassWD"))

        End With

        '------------------------------
        ' �f�B���N�g�����݃`�F�b�N
        '------------------------------
        If System.IO.Directory.Exists(txt_PutPath.Text) = False Then
            '------------------------------
            ' �_�C�A���O�\��
            '------------------------------
            Call LS_SetSelPath()
        End If

        If Len(txt_PutPath.Text) <> 0 Then
            Me.Cursor = Cursors.WaitCursor

            '------------------------------
            ' �f�[�^�G�N�X�|�[�g
            '------------------------------
            Call LS_DataExport(objInfo)

            Me.Cursor = Cursors.Default
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�_�C�A���O�\������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetSelPath()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objFolder As New BrowseFolder()
        Dim strSelPath As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        Try
            strSelPath = objFolder.BrowseDialog("�t�H���_���w�肵�Ă�������", Me)
            txt_PutPath.Text = strSelPath
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetSelPath")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�f�[�^�G�N�X�|�[�g����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F
    ' --------------------------------------------------------------------------------
    Private Sub LS_DataExport(ByVal pInfo As typConnectionInfo)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strExpPath As String

        With pInfo
            .strAdvPath = Trim$(GF_GetAppInfo("ADV_PATH"))
            .strItemPath = Trim$(GF_GetAppInfo("ITEM_PATH"))
            .strGrpPath = Trim$(GF_GetAppInfo("GROUP_PATH"))
            .strMenuGrpPath = Trim$(GF_GetAppInfo("MENUIMG_V"))
            .strStoreMkPath = Trim$(GF_GetAppInfo("STOREMARK_V"))

            ' �R�s�[���p�X�擾
            strExpPath = txt_PutPath.Text
        End With

        '------------------------------
        ' �G�N�X�|�[�g�p�X����
        '------------------------------
        If Len(Trim$(Dir(strExpPath, FileAttribute.Directory))) = 0 Then
            If GF_Msg("", _
                      "�w�肳�ꂽ�p�X��������܂���B�쐬���܂����H" & vbCrLf & _
                      "[" & strExpPath & "]", _
                      MsgBoxStyle.YesNo, _
                      MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Try
                    System.IO.Directory.CreateDirectory(strExpPath)
                Catch
                    Call GF_Msg("", "�t�H���_�̍쐬�Ɏ��s���܂���" & vbCrLf & "�ēx�ݒ���m�F���ĉ�����", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
                    Exit Sub
                End Try
            End If
        End If

        Try
            strExpPath = strExpPath & "\BackUpData(" & Format$(Now, "yyyyMMddHHmmss") & ")"
            System.IO.Directory.CreateDirectory(strExpPath)
        Catch
            Call GF_Msg("", "�t�H���_�̍쐬�Ɏ��s���܂���" & vbCrLf & "�ēx�ݒ���m�F���ĉ�����", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

        '------------------------------
        ' BCP�G�N�X�|�[�g
        '------------------------------
        If Not LF_TableBackup(strExpPath & "\TableData", pInfo) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' DB���ƃo�b�N�A�b�v
        '------------------------------
        If Not LF_DBBackup(strExpPath & "\TableData", pInfo) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �摜�t�@�C���R�s�[
        '------------------------------
        If Not LF_ImageBackup(strExpPath & "\ImageData", pInfo) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �C���|�[�g�p�o�b�`�t�@�C������
        '------------------------------
        If Not LF_CreateRestoreBatch(strExpPath, pInfo) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �I�����b�Z�[�W�\��
        '------------------------------
        Call GF_Msg("", "�f�[�^�G�N�X�|�[�g���������܂���" & vbCrLf & "[" & strExpPath & "]", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_DataExport")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�e�[�u���ޔ�����
    ' �@�@�\�T�v�F�ȗ�
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_TableBackup(ByVal pTargetPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim intProcID As Integer
        Dim strCmdLine As String
        Dim wkdouble As Double

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_TableBackup = False

        '------------------------------
        ' �S�e�[�u���ꗗ�擾
        '------------------------------
        Try
            If System.IO.Directory.Exists(pTargetPath) = False Then
                System.IO.Directory.CreateDirectory(pTargetPath)
            End If

            strSQL = ""
            strSQL = strSQL & "SELECT NAME"
            strSQL = strSQL & "  FROM SYSOBJECTS"
            strSQL = strSQL & " WHERE NAME LIKE 'TP%'"

            If Not GF_GetData(strSQL, objData) Then
                Exit Function
            End If

            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    Exit Function
                End If

                strCmdLine = ""
                strCmdLine = strCmdLine & "BCP"
                strCmdLine = strCmdLine & " " & pInfo.strDBNM & ".." & Trim$(objRows("NAME"))   ' �ޔ��e�[�u����
                strCmdLine = strCmdLine & " out"                                                ' �G�N�X�|�[�g�w��
                strCmdLine = strCmdLine & " """ & pTargetPath & "\" & _
                                                Trim$(objRows("NAME")) & ".txt"""               ' �ޔ��t�@�C����"
                strCmdLine = strCmdLine & " -S " & pInfo.strSVNM
                strCmdLine = strCmdLine & " -U " & pInfo.strUserNM
                strCmdLine = strCmdLine & " -P " & pInfo.strPasswd

                ' ���l�^�ւ̕ϊ��ۃ`�F�b�N
                If Double.TryParse(Trim$(objRows("NAME")).Substring(Trim$(objRows("NAME")).Length - 1, 1), wkdouble) Then
                    ' ���l�^(������e�[�u��)�̏ꍇ
                    strCmdLine = strCmdLine & " -c -t ,"
                Else
                    ' ���l�^�ȊO(�ʏ�e�[�u��)�̏ꍇ
                    strCmdLine = strCmdLine & " -N -t ,"
                End If

                Debug.WriteLine(strCmdLine)
                intProcID = Shell("cmd.exe /C " & strCmdLine, AppWinStyle.Hide, True)

                If intProcID <> 0 Then
                    Exit Function
                End If

                lngCnt = lngCnt + 1
            End While
        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_TableBackup = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�e�[�u���ޔ�����
    ' �@�@�\�T�v�F�ȗ�
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_DeliTableBackup(ByVal pTargetPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim intProcID As Integer
        Dim strCmdLine As String
        Dim wkdouble As Double

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_DeliTableBackup = False

        '------------------------------
        ' �S�e�[�u���ꗗ�擾
        '------------------------------
        Try
            If System.IO.Directory.Exists(pTargetPath) = False Then
                System.IO.Directory.CreateDirectory(pTargetPath)
            End If

            ' 0.01������
            targetPrgBar.Value = targetPrgBar.Value + 0.01

            strSQL = ""
            strSQL = strSQL & "SELECT NAME"
            strSQL = strSQL & "  FROM SYSOBJECTS"
            strSQL = strSQL & " WHERE NAME LIKE 'TP%'"

            If Not GF_GetData(strSQL, objData) Then
                Exit Function
            End If

            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                ' 0.01������
                targetPrgBar.Value = targetPrgBar.Value + 0.01

                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    Exit Function
                End If

                targetPrgLabel.Text = "�o�b�N�A�b�v�F" + objRows("NAME")
                strCmdLine = ""
                strCmdLine = strCmdLine & "BCP"
                strCmdLine = strCmdLine & " " & pInfo.strDBNM & ".." & Trim$(objRows("NAME"))   ' �ޔ��e�[�u����
                strCmdLine = strCmdLine & " out"                                                ' �G�N�X�|�[�g�w��

                If Trim$(objRows("NAME")).IndexOf("B") > 0 Or Trim$(objRows("NAME")).IndexOf("C") > 0 Then
                    strCmdLine = strCmdLine & " """ & pTargetPath & "\" & Trim$(objRows("NAME")) & ".csv"""               ' �ޔ��t�@�C����"
                    'strCmdLine = strCmdLine & " -w -t " & """" & "," & """" & " -T -S " & pInfo.strSVNM
                    strCmdLine = strCmdLine & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,"
                Else
                    strCmdLine = strCmdLine & " """ & pTargetPath & "\" & Trim$(objRows("NAME")) & ".txt"""               ' �ޔ��t�@�C����"
                    'strCmdLine = strCmdLine & " -w -t " & """" & "," & """" & " -T -S " & pInfo.strSVNM
                    strCmdLine = strCmdLine & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,"
                End If

                Debug.WriteLine(strCmdLine)

                intProcID = Shell("cmd.exe /C " & strCmdLine, AppWinStyle.Hide, True)

                System.Windows.Forms.Application.DoEvents()

                If intProcID <> 0 Then
                    Exit Function
                End If

                lngCnt = lngCnt + 1
            End While
        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_DeliTableBackup = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�e�[�u���ޔ�����
    ' �@�@�\�T�v�F�ȗ�
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2014.04.08 �N���X�h���[�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_DBBackup(ByVal pTargetPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim intProcID As Integer
        Dim strCmdLine As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_DBBackup = False

        Try
            ' �f�B���N�g���쐬
            If System.IO.Directory.Exists(pTargetPath) = False Then
                System.IO.Directory.CreateDirectory(pTargetPath)
            End If

            strCmdLine = "sqlcmd -S localhost\VSdotNet -Q ""BACKUP DATABASE TP_DB TO DISK='" & pTargetPath & "\TP_DB.bak' WITH INIT"""
            intProcID = Shell("cmd.exe /C " & strCmdLine, AppWinStyle.Hide, True)

            If intProcID <> 0 Then
                Exit Function
            End If

        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_DBBackup = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�摜�t�@�C���ޔ�����
    ' �@�@�\�T�v�F�ȗ�
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_ImageBackup(ByVal pTargetPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_ImageBackup = False

        Try
            '------------------------------
            ' �摜�t�@�C���ޔ�
            '------------------------------
            ' 2019-11-06 ----------------------------------------------------------------------------------------
            'If Not LF_ImageCopy(pInfo.strItemPath, pTargetPath & "\ItemImage") Then
            '    Exit Function
            'End If

            'If Not LF_ImageCopy(pInfo.strGrpPath, pTargetPath & "\GroupImage") Then
            '    Exit Function
            'End If

            'If Not LF_ImageCopy(pInfo.strMenuGrpPath, pTargetPath & "\MenuImage") Then
            '    Exit Function
            'End If

            'If Not LF_ImageCopy(pInfo.strAdvPath, pTargetPath & "\AdvImage") Then
            '    Exit Function
            'End If

            'If Not LF_ImageCopy(pInfo.strStoreMkPath, pTargetPath & "\StoreMark") Then
            '    Exit Function
            'End If

            Dim charBackSlash As String = Chr(&H5C)
            Dim partSrc As String()
            'parts = Split("C:\inetpub\wwwroot\CNWI001\AAAA", delim, -1, CompareMethod.Binary)
            partSrc = Split(pInfo.strItemPath, charBackSlash, -1, CompareMethod.Binary)
            Dim srcPath As String = ""
            Dim ii As Integer

            For ii = 0 To partSrc.Length - 2
                If ii <> 0 Then
                    srcPath = srcPath & charBackSlash
                End If
                srcPath = srcPath & partSrc(ii)
            Next
            'Dim files As String() = System.IO.Directory.GetFiles(pPath, "*", System.IO.SearchOption.TopDirectoryOnly)
            'Dim ff As String = Dir(pPath)
            'Dim files As String() = System.IO.Directory.GetFiles(pPath)
            Dim dirsPath As String() = System.IO.Directory.GetDirectories(srcPath)
            For Each sPath As String In dirsPath
                Dim tmpDir As String() = Split(sPath, charBackSlash, -1, CompareMethod.Binary)
                Dim strDir As String = tmpDir(tmpDir.Length - 1)

                If strDir.ToLower() <> "template" Then
                    'strDir = strDir & delim
                    If Not LF_ImageCopy(srcPath & charBackSlash & strDir, pTargetPath & charBackSlash & strDir) Then
                        Exit Function
                    End If
                End If
            Next
            ' ---------------------------------------------------------------------------------------------------
        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_ImageBackup = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�摜�t�@�C���ޔ�����
    ' �@�@�\�T�v�F�ȗ�
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2018.08.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_Deli_ImageBackup(ByVal pTargetPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_Deli_ImageBackup = False

        Try
            '------------------------------
            ' �摜�t�@�C���ޔ�
            '------------------------------
            If Not LF_Deli_ImageCopy(pInfo.strItemPath, pTargetPath & "\ItemImage") Then
                Exit Function
            End If

            If Not LF_Deli_ImageCopy(pInfo.strGrpPath, pTargetPath & "\GroupImage") Then
                Exit Function
            End If

            If Not LF_Deli_ImageCopy(pInfo.strMenuGrpPath, pTargetPath & "\MenuImage") Then
                Exit Function
            End If

            If Not LF_Deli_ImageCopy(pInfo.strAdvPath, pTargetPath & "\AdvImage") Then
                Exit Function
            End If

            If Not LF_Deli_ImageCopy(pInfo.strStoreMkPath, pTargetPath & "\StoreMark") Then
                Exit Function
            End If
        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_Deli_ImageBackup = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�@�C���]������
    ' �@�@�\�T�v�F�ȗ�
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_ImageCopy(ByVal pSourceFld As String, _
                                  ByVal pTargetFld As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strFile As String
        Dim strWork() As String
        Dim strTFile As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_ImageCopy = False

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
            For Each strFile In System.IO.Directory.GetFiles(pSourceFld, "*.*")
                strWork = Split(strFile, "\")
                strTFile = pTargetFld & "\" & strWork(UBound(strWork))
                If System.IO.File.Exists(strTFile) = True Then                  ' �]����ɁA����t�@�C���������݂����ꍇ�͍폜����
                    System.IO.File.SetAttributes(strTFile, IO.FileAttributes.Normal)
                    System.IO.File.Delete(strTFile)
                End If
                System.IO.File.Copy(strFile, strTFile)
            Next

        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_ImageCopy = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�@�C���]������
    ' �@�@�\�T�v�F�ȗ�
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_Deli_ImageCopy(ByVal pSourceFld As String, ByVal pTargetFld As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strFile As String
        Dim strWork() As String
        Dim strTFile As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_Deli_ImageCopy = False

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
            For Each strFile In System.IO.Directory.GetFiles(pSourceFld, "*.*")
                ' 0.1%������
                If targetPrgBar.Value = 999 Then
                    targetPrgBar.Value = 999
                ElseIf targetPrgBar.Value = 52 Then
                    targetPrgBar.Value = 52
                Else
                    targetPrgBar.Value = targetPrgBar.Value + 0.01
                End If

                strWork = Split(strFile, "\")
                strTFile = pTargetFld & "\" & strWork(UBound(strWork))
                targetPrgLabel.Text = "�摜�ړ��F" + strTFile
                If System.IO.File.Exists(strTFile) = True Then                  ' �]����ɁA����t�@�C���������݂����ꍇ�͍폜����
                    System.IO.File.SetAttributes(strTFile, IO.FileAttributes.Normal)
                    System.IO.File.Delete(strTFile)
                End If
                System.IO.File.Copy(strFile, strTFile)
            Next

        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_Deli_ImageCopy = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FRESTORE�o�b�`�t�@�C����������
    ' �@�@�\�T�v�F�ȗ�
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_CreateRestoreBatch(ByVal pPutPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        Dim objBatch As System.IO.StreamWriter

        LF_CreateRestoreBatch = False

        Try
            '------------------------------
            ' �t�@�C���o��
            '------------------------------
            targetPrgLabel.Text = ".bat�t�@�C���쐬"
            ' 2014-04-08 �f�[�^�x�[�X�S�̂��ꊇ�Ńo�b�N�A�b�v����悤�C��
            objBatch = New System.IO.StreamWriter(pPutPath & "\Restore.bat", False, System.Text.Encoding.Default)
            With objBatch
                .WriteLine("@echo off")
                .WriteLine("echo �o�b�N�A�b�v�f�[�^�̕������s���܂�")
                .WriteLine("echo Cross Navi����Ă�������")
                .WriteLine("pause")
                .WriteLine("echo *** �o�b�N�A�b�v�f�[�^�̃C���|�[�g���ł� ***")

                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPD010 in .\TableData\TPD010.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPD011 in .\TableData\TPD011.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPD020 in .\TableData\TPD020.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPD025 in .\TableData\TPD025.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPD026 in .\TableData\TPD026.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPD030 in .\TableData\TPD030.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPD040 in .\TableData\TPD040.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPD050 in .\TableData\TPD050.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPD100 in .\TableData\TPD100.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPD200 in .\TableData\TPD200.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPD210 in .\TableData\TPD210.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPD220 in .\TableData\TPD220.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPD230 in .\TableData\TPD230.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPD240 in .\TableData\TPD240.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPD250 in .\TableData\TPD250.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPD260 in .\TableData\TPD260.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPD500 in .\TableData\TPD500.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")

                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM010 in .\TableData\TPM010.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM020 in .\TableData\TPM020.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM030 in .\TableData\TPM030.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM040 in .\TableData\TPM040.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM050 in .\TableData\TPM050.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM060 in .\TableData\TPM060.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM061 in .\TableData\TPM061.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM070 in .\TableData\TPM070.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM080 in .\TableData\TPM080.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM090 in .\TableData\TPM090.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM091 in .\TableData\TPM091.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM092 in .\TableData\TPM092.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM100 in .\TableData\TPM100.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM110 in .\TableData\TPM110.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM120 in .\TableData\TPM120.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM130 in .\TableData\TPM130.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM140 in .\TableData\TPM140.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM150 in .\TableData\TPM150.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM160 in .\TableData\TPM160.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM170 in .\TableData\TPM170.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM180 in .\TableData\TPM180.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM190 in .\TableData\TPM190.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")

                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM010A in .\TableData\TPM010A.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -N -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM010B in .\TableData\TPM010B.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -N -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM020A in .\TableData\TPM020A.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -N -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM020B in .\TableData\TPM020B.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -N -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM030A in .\TableData\TPM030A.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -N -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM030B in .\TableData\TPM030B.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -N -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM060A in .\TableData\TPM060A.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -N -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM060B in .\TableData\TPM060B.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -N -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM061A in .\TableData\TPM061A.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -N -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM061B in .\TableData\TPM061B.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -N -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM100A in .\TableData\TPM100A.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -N -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM100B in .\TableData\TPM100B.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -N -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM190A in .\TableData\TPM190A.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -N -t ,")
                '                .WriteLine("bcp " & pInfo.strDBNM & "..TPM190B in .\TableData\TPM190B.txt -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -N -t ,")
                .WriteLine("net stop MSSQL$VSdotNet")
                .WriteLine("net start MSSQL$VSdotNet")
                .WriteLine("sqlcmd -S localhost\VSdotNet -Q ""RESTORE DATABASE TP_DB FROM DISK='%CD%\TableData\TP_DB.bak'""")

                .WriteLine("echo *** ���i�摜�t�@�C���̃R�s�[���ł� ***")
                .WriteLine("xcopy .\ImageData\ItemImage\*.* C:\Inetpub\wwwroot\CNWI001\ItemImage /V /Y /R /Q")

                .WriteLine("echo *** �O���[�v�摜�t�@�C���̃R�s�[���ł� ***")
                .WriteLine("xcopy .\ImageData\GroupImage\*.* C:\Inetpub\wwwroot\CNWI001\GroupImage /V /Y /R /Q")

                .WriteLine("echo *** ���j���[�O���[�v�摜�t�@�C���̃R�s�[���ł� ***")
                .WriteLine("xcopy .\ImageData\MenuImage\*.* C:\Inetpub\wwwroot\CNWI001\MenuImage /V /Y /R /Q")

                .WriteLine("echo *** �L���摜�t�@�C���̃R�s�[���ł� ***")
                .WriteLine("xcopy .\ImageData\AdvImage\*.* C:\Inetpub\wwwroot\CNWI001\AdvImage /V /Y /R /Q")

                .WriteLine("echo *** �X�܃��S�t�@�C���̃R�s�[���ł� ***")
                .WriteLine("xcopy .\ImageData\StoreMark\*.* C:\Inetpub\wwwroot\CNWI001\StoreMark /V /Y /R /Q")

                .WriteLine("echo �I�����܂���")
                .WriteLine("pause")

                .Close()
            End With
        Catch
            Exit Function
        End Try

        LF_CreateRestoreBatch = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�^�u�R���g���[���ύX����
    ' �@�@�\�T�v�F�ȗ�
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        ''------------------------------
        '' �����ϐ���`
        ''------------------------------
        'Dim objRet As MsgBoxResult

        'Select Case L_selectTab
        '    Case typSelectTab.Tab1
        '        '------------------------------
        '        ' �X�V�����m�F
        '        '------------------------------
        '        If L_blnEdit Then
        '            objRet = GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNo)

        '            Select Case objRet
        '                Case MsgBoxResult.Yes
        '                    '------------------------------
        '                    ' �g�����U�N�V�����J�n
        '                    '------------------------------
        '                    If Not GF_BeginTrans() Then
        '                        GoTo SYSTEM_ERROR
        '                    End If

        '                    '------------------------------
        '                    ' �X�V����
        '                    '------------------------------
        '                    If Not LF_UpdTPM040() Then
        '                        GoTo SYSTEM_ERROR
        '                    End If

        '                    '------------------------------
        '                    ' �g�����U�N�V�����m��
        '                    '------------------------------
        '                    If Not GF_CommitTrans() Then
        '                        GoTo SYSTEM_ERROR
        '                    End If

        '                Case MsgBoxResult.No

        '            End Select

        '        End If

        '    Case typSelectTab.Tab2
        '        '------------------------------
        '        ' �X�V�����m�F
        '        '------------------------------
        '        If L_blnEdit Then
        '            objRet = GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNo)

        '            Select Case objRet
        '                Case MsgBoxResult.Yes
        '                    '------------------------------
        '                    ' �g�����U�N�V�����m��
        '                    '------------------------------
        '                    If Not GF_CommitTrans() Then
        '                        GoTo SYSTEM_ERROR
        '                    End If

        '                Case MsgBoxResult.No
        '                    '------------------------------
        '                    ' �g�����U�N�V�����j��
        '                    '------------------------------
        '                    If Not GF_RollbackTrans() Then
        '                        GoTo SYSTEM_ERROR
        '                    End If

        '            End Select
        '        Else
        '            '------------------------------
        '            ' �g�����U�N�V�����j��
        '            '------------------------------
        '            If Not GF_RollbackTrans() Then
        '                GoTo SYSTEM_ERROR
        '            End If
        '        End If

        '    Case typSelectTab.Tab3

        '    Case Else
        '        Exit Sub
        'End Select

        Select Case TabControl1.SelectedIndex
            Case 0  ' ��ʑِ̍ݒ�
                '------------------------------
                ' ��ʑِ̍ݒ� �\������
                '------------------------------
                Call LS_SetInitForm()

                L_blnEdit = False

            Case 1 ' ����f�[�^�o��
                txt_PutPathCsv.Text = Trim$(GF_GetAppInfo("SALES_PATH")) & "\PriceData(" & Format$(Now, "yyyyMMddHHmmss") & ").csv"
                txt_PutPathCsv.Enabled = False

            Case 2 ' �f�[�^�o�b�N�A�b�v
                txt_PutPath.Text = Trim$(GF_GetAppInfo("BACKUP_PATH"))
                txt_PutPath.Enabled = False

            Case 3 ' ���M���b�Z�[�W�ҏW
                '------------------------------
                ' ��ʏ�����
                '------------------------------
                Call LS_FormSetup()

                L_blnEdit = False

            Case Else

                ' 2017.01.01 �����Ă���i���� �N���X�R�k�� �c��
                If GF_GetAppInfo2("CNWH_GAMEFLG") = 1 Then
                    Call LF_GameSetInitForm()
                End If

                If GF_GetAppInfo3("KCP_PTN_FLG") = 1 Then
                    Call LF_PaternInitForm()
                End If
                ' 2017.01.01 �����Ă���i���� �N���X�R�k�� �c��

                ' 2017.10.01 �{���z�M �N���X�R�k�� �c��
                If Trim$(GF_GetAppInfo("DELIVARY_FLG")) = "1" Then
                    btn_Deli_Import.Enabled = True
                    If fgCheckM555 Then
                        btn_OMOTENASHI_Import.Enabled = True
                    Else
                        btn_OMOTENASHI_Import.Enabled = False
                    End If
                    btnSalesUplode.Enabled = True
                ElseIf Trim$(GF_GetAppInfo("DELIVARY_FLG")) = "2" Then
                    btn_Deli_Import.Enabled = False
                    btn_OMOTENASHI_Import.Enabled = False
                    btnSalesUplode.Enabled = True
                ElseIf Trim$(GF_GetAppInfo("DELIVARY_FLG")) = "3" Then
                    btn_Deli_Import.Enabled = True
                    If fgCheckM555 Then
                        btn_OMOTENASHI_Import.Enabled = True
                    Else
                        btn_OMOTENASHI_Import.Enabled = False
                    End If
                    btnSalesUplode.Enabled = False
                End If
                    ' 2017.10.01 �{���z�M �N���X�R�k�� �c��

                    Exit Sub
        End Select

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("TabControl1_SelectedIndexChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F��ʑِ̍ݒ� �\������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetInitForm()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        'Label8.Visible = False
        txt_StoreInfo.Visible = False

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
            ' �X�܏��(���m�点)�ݒ�
            '------------------------------
            txt_StoreInfo.Text = Replace(Trim$(objRows("STOREINFO")), "<BR>", vbCrLf)
            If GF_LenB(GF_RepQuo(objRows("STOREINFO"))) > 100 Then
                txt_StoreInfo.BackColor = Color.Pink
            Else
                txt_StoreInfo.BackColor = Color.White
            End If

            '------------------------------
            ' �X�܃��S�\���ݒ�
            '------------------------------
            If Trim$(objRows("LOGO_VIEW")) = GC_TRUE Then
                Call LS_SetRadio(rdo_Logo_Show, True)
            Else
                Call LS_SetRadio(rdo_Logo_Hide, True)
            End If

            '------------------------------
            ' ��ʕ\���ݒ�
            '------------------------------
            If Trim$(objRows("KAIKEI_FLG")) = GC_TRUE Then
                Call LS_SetRadio(rdo_Kaikei_Show, True)
                Call LS_SetRadio(rdo_Kaikei_Hide, False)
            Else
                Call LS_SetRadio(rdo_Kaikei_Show, False)
                Call LS_SetRadio(rdo_Kaikei_Hide, True)
            End If

            If Trim$(objRows("CALL_FLG")) = GC_TRUE Then
                Call LS_SetRadio(rdo_Call_Show, True)
                Call LS_SetRadio(rdo_Call_Hide, False)
            Else
                Call LS_SetRadio(rdo_Call_Show, False)
                Call LS_SetRadio(rdo_Call_Hide, True)
            End If

            If Trim$(objRows("WARIKAN_FLG")) = GC_TRUE Then
                Call LS_SetRadio(rdo_Warikan_Show, True)
                Call LS_SetRadio(rdo_Warikan_Hide, False)
            Else
                Call LS_SetRadio(rdo_Warikan_Show, False)
                Call LS_SetRadio(rdo_Warikan_Hide, True)
            End If

            If Trim$(objRows("SUBTOTAL")) = GC_TRUE Then
                Call LS_SetRadio(rdo_Show, True)
                Call LS_SetRadio(rdo_Hide, False)
            Else
                Call LS_SetRadio(rdo_Show, False)
                Call LS_SetRadio(rdo_Hide, True)
            End If

            '------------------------------
            ' �L���\���ݒ�
            '------------------------------
            txt_Wait_Time.Text = Trim$(objRows("CHGTIME"))
            txt_Chg_Time.Text = Trim$(objRows("CHGINT"))

            '------------------------------
            ' �~�[�x�����ԕ\���ݒ�
            '------------------------------

            '�x�����ԉ�
            Text_alert.Text = CInt(LF_GetTPM090("1"))

            '�x�����ԃI�����W
            Text_alert2.Text = CInt(LF_GetTPM090("2"))

            '�x�����Ԑ�
            Text_alert3.Text = CInt(LF_GetTPM090("3"))

            '------------------------------
            ' �i�؂ꕶ���\���ݒ�
            '------------------------------

            '�i�؂�p�^�[���P
            text_sold_out1.Text = Trim$(LF_TPM090("1"))

            '�i�؂�p�^�[���Q
            text_sold_out2.Text = Trim$(LF_TPM090("2"))

            '�i�؂�p�^�[���R
            text_sold_out3.Text = Trim$(LF_TPM090("3"))

            '�i�؂�p�^�[���S
            text_sold_out4.Text = Trim$(LF_TPM090("4"))

            '----------------------------------------------
            ' �g�b�v��ʕ\���p�^�[���@2013.10.07�@�ǉ�
            '----------------------------------------------
            Call LS_TopCmbSetup()
            If Trim$(GF_GetAppInfo2("TOP_VARIABLE_FLG")) = 0 Then
                Call GS_CboChgSel(Cbo_TopChg, Trim$(GF_GetAppInfo2("TOP_DISPCD")))
            Else
                Label14.Visible = False
                GroupBox7.Visible = False
            End If

            '------------------------------
            ' ����ŗ��\���ݒ�
            '------------------------------
            sales_tax_rate.Text = Trim$(GF_GetAppInfo("SALES_TAX_RATE"))

            '------------------------------
            ' �������ʒ[�������l�\���ݒ�
            '------------------------------
            tax_round_1.Text = Trim$(GF_GetAppInfo("TAX_ROUND_OFF"))
            tax_round_2.Text = Trim$(GF_GetAppInfo("TAX_ROUND_OFF")) + 1

            '------------------------------
            ' [���M���b�Z�[�W�ҏW]�\����
            '------------------------------
            If Trim$(GF_GetAppInfo3("CNWQ002_1")) = "1" And TabControl1.TabPages.Count > 3 Then
                TabControl1.TabPages.RemoveAt(3)
            End If

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetStatus")
    End Sub

    ' START 2016.05.10 �c��
    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�Q�[���ݒ� �\������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2016.05.10 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LF_GameSetInitForm()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

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
            txt_GAMEHITNUM.Text = Trim$(GF_GetAppInfo2("CNWH_GAMEHITNUM"))
            txt_GAMEPLAYNUM.Text = Trim$(GF_GetAppInfo2("CNWH_GAMEPLAYNUM"))

            '-----------------------------------
            ' �Q�[���ݒ�l�ҏW�� �\������
            '-----------------------------------
            If Trim$(objRows("CLMODE")) = 0 Then
                txt_GAMEHITNUM.Enabled = False
                txt_GAMEPLAYNUM.Enabled = False

                lbl_judge.Text = "�V�X�e���ғ����ł��B"
                lbl_order.Text = "���݁A�Q�[���ݒ�̒l��ύX���邱�Ƃ͂ł��܂���B"

            ElseIf Trim$(objRows("CLMODE")) = 1 Then
                txt_GAMEHITNUM.Enabled = True
                txt_GAMEPLAYNUM.Enabled = True

                lbl_judge.Text = "�V�X�e����~���ł��B"
                lbl_order.Text = "���݁A�Q�[���ݒ�̒l��ύX���邱�Ƃ��ł��܂��B"
            Else
                txt_GAMEHITNUM.Enabled = False
                txt_GAMEPLAYNUM.Enabled = False
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetStatus")
    End Sub
    ' END 2016.05.10 �c��

    ' 2017.01.01 �����Ă���i���� �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�o�͐�p�^�[���\������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2016.01.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LF_PaternInitForm()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String = Nothing
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim cmb1 As New DataGridViewComboBoxColumn
        Dim cmb2 As New DataGridViewComboBoxColumn
        Dim cmb3 As New DataGridViewComboBoxColumn
        Dim cmb4 As New DataGridViewComboBoxColumn
        Dim cmbPtnNo As String
        Dim i As Integer

        Try

            If DataGridView1.Rows.Count < 2 Then

                strSQL = ""
                strSQL = strSQL & " SELECT CONVERT(int,PRNNO) AS NUM,"
                strSQL = strSQL & "        PTN1,"
                strSQL = strSQL & "        PTN2,"
                strSQL = strSQL & "        PTN3,"
                strSQL = strSQL & "        PTN4"
                strSQL = strSQL & " FROM TPM310"
                strSQL = strSQL & " ORDER BY NUM"

                If Not GF_GetData(strSQL, objData) Then
                    GoTo SYSTEM_ERROR
                End If

                For i = 0 To 31

                    If i < 32 Then
                        DataGridView1.Rows.Add()
                    End If

                    If Not GF_GetRows(objData, i, objRows) Then
                        GoTo SYSTEM_ERROR
                    End If

                    DataGridView1.Rows(i).Cells(0).Value = CStr(Trim$(objRows("NUM")))
                    cmb1.Items.Add((i + 1).ToString)
                    cmb2.Items.Add((i + 1).ToString)
                    cmb3.Items.Add((i + 1).ToString)
                    cmb4.Items.Add((i + 1).ToString)

                Next

                cmb1.HeaderText = "�p�^�[��1"

                cmb2.HeaderText = "�p�^�[��2"

                cmb3.HeaderText = "�p�^�[��3"

                cmb4.HeaderText = "�p�^�[��4"

                DataGridView1.Columns.Add(cmb1)

                DataGridView1.Columns.Add(cmb2)

                DataGridView1.Columns.Add(cmb3)

                DataGridView1.Columns.Add(cmb4)

                For i = 0 To 31

                    If Not GF_GetRows(objData, i, objRows) Then
                        GoTo SYSTEM_ERROR
                    End If

                    DataGridView1.Rows(i).Cells(1).Value = Trim$(objRows("PTN1"))

                    DataGridView1.Rows(i).Cells(2).Value = Trim$(objRows("PTN2"))

                    DataGridView1.Rows(i).Cells(3).Value = Trim$(objRows("PTN3"))

                    DataGridView1.Rows(i).Cells(4).Value = Trim$(objRows("PTN4"))

                Next

                cmbPtnNo = GF_GetAppInfo3("KCP_PTN")

                Select Case cmbPtnNo

                    Case "1"
                        cmbPtn.Text = "�p�^�[���P"
                    Case "2"
                        cmbPtn.Text = "�p�^�[���Q"
                    Case "3"
                        cmbPtn.Text = "�p�^�[���R"
                    Case "4"
                        cmbPtn.Text = "�p�^�[���S"

                End Select


                cmbPtn.Items.Add("�p�^�[���P")

                cmbPtn.Items.Add("�p�^�[���Q")

                cmbPtn.Items.Add("�p�^�[���R")

                cmbPtn.Items.Add("�p�^�[���S")

                DataGridView1.AllowUserToAddRows = False

            End If

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LF_PaternInitForm")
    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        e.Cancel = True
    End Sub
    ' 2017.01.01 �����Ă���i���� �N���X�R�k�� �c��


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
        ' SQL�g��
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
    ' �@�@�@�@�\�FAP���Ǘ��}�X�^ �擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.08.06 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM090(ByVal pFlg As String) As String
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM090 = ""

        '------------------------------
        ' SQL�g��
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT APVALUE"
        strSQL = strSQL & "  FROM TPM090"

        Select Case pFlg
            Case "1"
                strSQL = strSQL & "   WHERE APKEY = 'ALERT_TIME1'"

            Case "2"
                strSQL = strSQL & "   WHERE APKEY = 'ALERT_TIME2'"

            Case "3"
                strSQL = strSQL & "   WHERE APKEY = 'ALERT_TIME3'"

        End Select

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------

        LF_GetTPM090 = objRows("APVALUE")

        Return LF_GetTPM090

    End Function

    '�i�؂�4�p�^�[���Ή��@2013.10.28
    Private Function LF_TPM090(ByVal sFlg As String) As String
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing


        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_TPM090 = ""

        '------------------------------
        ' SQL�g��
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT APVALUE"
        strSQL = strSQL & "  FROM TPM090"

        Select Case sFlg
            Case "1"
                strSQL = strSQL & "   WHERE APKEY = 'SOLDOUT_NM'"

            Case "2"
                strSQL = strSQL & "   WHERE APKEY = 'SOLDOUT_NM_2'"

            Case "3"
                strSQL = strSQL & "   WHERE APKEY = 'SOLDOUT_NM_3'"

            Case "4"
                strSQL = strSQL & "   WHERE APKEY = 'SOLDOUT_NM_4'"

        End Select


        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If



        If Not GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If


        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------

        LF_TPM090 = objRows("APVALUE")

        Return LF_TPM090

    End Function

    Private Sub LS_SetRadio(ByVal pObj As RadioButton, ByVal pChecked As Boolean)
        L_ProcFlg = True
        pObj.Checked = pChecked
        L_ProcFlg = False
    End Sub

    Private Sub rdo_Kaikei_Show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Kaikei_Show.CheckedChanged
        If L_ProcFlg Then
            Exit Sub
        End If

        '------------------------------
        ' �X�V����
        '------------------------------
        If Not LF_UpdTPM040(typUpdKbn.KAIKEI_FLG) Then
            Exit Sub
        End If

        L_blnEdit = True
    End Sub

    Private Sub rdo_Kaikei_Hide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Kaikei_Hide.CheckedChanged
        If L_ProcFlg Then
            Exit Sub
        End If

        L_blnEdit = True
    End Sub

    Private Sub rdo_Call_Show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Call_Show.CheckedChanged
        If L_ProcFlg Then
            Exit Sub
        End If

        '------------------------------
        ' �X�V����
        '------------------------------
        If Not LF_UpdTPM040(typUpdKbn.CALL_FLG) Then
            Exit Sub
        End If

        L_blnEdit = True
    End Sub

    Private Sub rdo_Call_Hide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Call_Hide.CheckedChanged
        If L_ProcFlg Then
            Exit Sub
        End If

        L_blnEdit = True
    End Sub

    Private Sub rdo_Warikan_Show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Warikan_Show.CheckedChanged
        If L_ProcFlg Then
            Exit Sub
        End If

        '------------------------------
        ' �X�V����
        '------------------------------
        If Not LF_UpdTPM040(typUpdKbn.WARIKAN_FLG) Then
            Exit Sub
        End If

        L_blnEdit = True
    End Sub

    Private Sub rdo_Warikan_Hide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Warikan_Hide.CheckedChanged
        If L_ProcFlg Then
            Exit Sub
        End If

        L_blnEdit = True
    End Sub

    Private Sub rdo_Show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Show.CheckedChanged
        If L_ProcFlg Then
            Exit Sub
        End If

        '------------------------------
        ' �X�V����
        '------------------------------
        If Not LF_UpdTPM040(typUpdKbn.SUBTOTAL) Then
            Exit Sub
        End If

        L_blnEdit = True
    End Sub

    Private Sub rdo_Hide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Hide.CheckedChanged
        If L_ProcFlg Then
            Exit Sub
        End If

        L_blnEdit = True
    End Sub

    Private Sub rdo_Logo_Show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Logo_Show.CheckedChanged
        If L_ProcFlg Then
            Exit Sub
        End If

        '------------------------------
        ' �X�V����
        '------------------------------
        If Not LF_UpdTPM040(typUpdKbn.LOGO_VIEW) Then
            Exit Sub
        End If

        L_blnEdit = True
    End Sub

    Private Sub rdo_Logo_Hide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Logo_Hide.CheckedChanged
        If L_ProcFlg Then
            Exit Sub
        End If

        L_blnEdit = True
    End Sub

    Private Sub txt_StoreInfo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_StoreInfo.TextChanged
        If txt_StoreInfo.Modified = False Then
            Exit Sub
        End If

        If GF_LenB(GF_RepQuo(Replace(txt_StoreInfo.Text, vbCrLf, "<BR>"))) > 100 Then
            txt_StoreInfo.BackColor = Color.Pink
        Else
            txt_StoreInfo.BackColor = Color.White
        End If

        L_blnEdit = True
    End Sub

    Private Sub txt_StoreInfo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_StoreInfo.Leave
        If GF_LenB(GF_RepQuo(Replace(txt_StoreInfo.Text, vbCrLf, "<BR>"))) <= 100 Then
            '------------------------------
            ' �X�V����
            '------------------------------
            If Not LF_UpdTPM040(typUpdKbn.STOREINFO) Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txt_Wait_Time_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Wait_Time.TextChanged
        If txt_Wait_Time.Modified = False Then
            Exit Sub
        End If

        If Len(Trim$(txt_Wait_Time.Text)) = 0 Then
            txt_Wait_Time.Text = "0"
        End If

        L_blnEdit = True
    End Sub

    Private Sub txt_Wait_Time_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Wait_Time.Leave
        If Not txt_Wait_Time.Text = "0" Then
            '------------------------------
            ' �X�V����
            '------------------------------
            If Not LF_UpdTPM040(typUpdKbn.CHGTIME) Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txt_Chg_Time_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Chg_Time.TextChanged
        If txt_Chg_Time.Modified = False Then
            Exit Sub
        End If

        If Len(Trim$(txt_Chg_Time.Text)) = 0 Then
            txt_Chg_Time.Text = "0"
        End If

        L_blnEdit = True
    End Sub

    Private Sub txt_Chg_Time_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Chg_Time.Leave
        If Not txt_Chg_Time.Text = "0" Then
            '------------------------------
            ' �X�V����
            '------------------------------
            If Not LF_UpdTPM040(typUpdKbn.CHGINT) Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Text_alert_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_alert.TextChanged
        If Text_alert.Modified = False Then
            Exit Sub
        End If

        If Len(Trim$(Text_alert.Text)) = 0 Then
            Text_alert.Text = "0"
        End If

        L_blnEdit = True
    End Sub

    Private Sub Text_alert_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_alert.Leave
        If Not Text_alert.Text = "0" Then
            '------------------------------
            ' �X�V����
            '------------------------------
            If Not LF_UpdTPM090(typUpdata.ALERT_TIME) Then
                Exit Sub
            End If
        End If
    End Sub


    Private Sub Text_alert2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_alert2.TextChanged
        If Text_alert2.Modified = False Then
            Exit Sub
        End If

        If Len(Trim$(Text_alert2.Text)) = 0 Then
            Text_alert2.Text = "0"
        End If

        L_blnEdit = True
    End Sub

    Private Sub Text_alert2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_alert2.Leave
        If Not Text_alert2.Text = "0" Then
            '------------------------------
            ' �X�V����
            '------------------------------
            If Not LF_UpdTPM090(typUpdata.ALERT_TIME2) Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Text_alert3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_alert3.TextChanged
        If Text_alert3.Modified = False Then
            Exit Sub
        End If

        If Len(Trim$(Text_alert3.Text)) = 0 Then
            Text_alert3.Text = "0"
        End If

        L_blnEdit = True
    End Sub

    Private Sub Text_alert3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_alert3.Leave
        If Not Text_alert3.Text = "0" Then
            '------------------------------
            ' �X�V����
            '------------------------------
            If Not LF_UpdTPM090(typUpdata.ALERT_TIME3) Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub text_sold_out1_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out1.LostFocus

        If text_sold_out1.Modified = False Then
            Exit Sub

        End If

        If Trim$(text_sold_out1.Text) = "" Then

            MessageBox.Show("�i�؂ꕶ������͂��ĉ�����")
            If text_sold_out1.CanUndo = True Then
                text_sold_out1.Undo()

            End If
        End If

    End Sub

    Private Sub text_sold_out1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out1.Leave
        If Not text_sold_out1.Text = "" Then
            '------------------------------
            ' �X�V����
            '------------------------------
            If Not LF_UpdTPM090(typUpdata.SOLDOUT_NM) Then
                Exit Sub
            End If
        End If

    End Sub

    Private Sub text_sold_out1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out1.TextChanged

        Dim lngST As Long



        lngST = text_sold_out1.SelectionStart
        ' 2014-05-12 2�o�C�g������������
        'text_sold_out1.Text = StrConv(text_sold_out1.Text, VbStrConv.Wide)
        If lngST >= 0 Then
            text_sold_out1.SelectionStart = lngST
        End If

        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(text_sold_out1.Text) > 16 Then
            text_sold_out1.Text = GF_MidB(text_sold_out1.Text, 1, 16)
            text_sold_out1.SelectionStart = GF_LenB(text_sold_out1.Text)
        End If
    End Sub

    Private Sub text_sold_out2_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out2.LostFocus
        If text_sold_out2.Modified = False Then
            Exit Sub
        End If

        If Trim$(text_sold_out2.Text) = "" Then

            MessageBox.Show("�i�؂ꕶ������͂��ĉ�����")
            If text_sold_out2.CanUndo = True Then
                text_sold_out2.Undo()

            End If
        End If
    End Sub

    Private Sub text_sold_out2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out2.Leave
        If Not text_sold_out2.Text = "" Then
            '------------------------------
            ' �X�V����
            '------------------------------
            If Not LF_UpdTPM090(typUpdata.SOLDOUT_NM_2) Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub text_sold_out2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out2.TextChanged

        Dim lngST As Long



        lngST = text_sold_out2.SelectionStart
        ' 2014-05-12 2�o�C�g������������
        'text_sold_out2.Text = StrConv(text_sold_out2.Text, VbStrConv.Wide)
        If lngST >= 0 Then
            text_sold_out2.SelectionStart = lngST
        End If

        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(text_sold_out2.Text) > 16 Then
            text_sold_out2.Text = GF_MidB(text_sold_out2.Text, 1, 16)
            text_sold_out2.SelectionStart = GF_LenB(text_sold_out2.Text)
        End If
    End Sub


    Private Sub text_sold_out3_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out3.LostFocus
        If text_sold_out3.Modified = False Then
            Exit Sub
        End If

        If Trim$(text_sold_out3.Text) = "" Then

            MessageBox.Show("�i�؂ꕶ������͂��ĉ�����")
            If text_sold_out3.CanUndo = True Then
                text_sold_out3.Undo()

            End If
        End If
    End Sub

    Private Sub text_sold_out3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out3.Leave
        If Not text_sold_out3.Text = "" Then
            '------------------------------
            ' �X�V����
            '------------------------------
            If Not LF_UpdTPM090(typUpdata.SOLDOUT_NM_3) Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub text_sold_out3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out3.TextChanged

        Dim lngST As Long



        lngST = text_sold_out3.SelectionStart
        ' 2014-05-12 2�o�C�g������������
        'text_sold_out3.Text = StrConv(text_sold_out3.Text, VbStrConv.Wide)
        If lngST >= 0 Then
            text_sold_out3.SelectionStart = lngST
        End If
        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(text_sold_out3.Text) > 16 Then
            text_sold_out3.Text = GF_MidB(text_sold_out3.Text, 1, 16)
            text_sold_out3.SelectionStart = GF_LenB(text_sold_out3.Text)
        End If
    End Sub

    Private Sub text_sold_out4_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out4.LostFocus
        If text_sold_out4.Modified = False Then
            Exit Sub
        End If

        If Trim$(text_sold_out4.Text) = "" Then

            MessageBox.Show("�i�؂ꕶ������͂��ĉ�����")
            If text_sold_out4.CanUndo = True Then
                text_sold_out4.Undo()

            End If
        End If
    End Sub

    Private Sub text_sold_out4_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out4.Leave
        If Not text_sold_out4.Text = "" Then
            '------------------------------
            ' �X�V����
            '------------------------------
            If Not LF_UpdTPM090(typUpdata.SOLDOUT_NM_4) Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub text_sold_out4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out4.TextChanged

        Dim lngST As Long



        lngST = text_sold_out4.SelectionStart
        ' 2014-05-12 2�o�C�g������������
        'text_sold_out4.Text = StrConv(text_sold_out4.Text, VbStrConv.Wide)
        If lngST >= 0 Then
            text_sold_out4.SelectionStart = lngST
        End If

        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(text_sold_out4.Text) > 16 Then
            text_sold_out4.Text = GF_MidB(text_sold_out4.Text, 1, 16)
            text_sold_out4.SelectionStart = GF_LenB(text_sold_out4.Text)
        End If
    End Sub

    '����ŗ��ύX�@2013.12.18
    Private Sub sales_tax_rate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sales_tax_rate.TextChanged

        If sales_tax_rate.Modified = False Then
            Exit Sub
        End If
        If Len(Trim$(sales_tax_rate.Text)) = 0 Then
            sales_tax_rate.Text = ""

        End If

        L_blnEdit = True

    End Sub

    '����ŗ��ύX�@2013.12.18
    Private Sub sales_tax_rate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sales_tax_rate.Leave
        If Not sales_tax_rate.Text = "" Then
            '------------------------------
            ' �X�V����
            '------------------------------
            If Not LF_UpdTPM090(typUpdata.TAX_RATE) Then
                Exit Sub
            End If
        Else
            MessageBox.Show("����ŗ�����͂��ĉ�����")
            If sales_tax_rate.CanUndo = True Then
                sales_tax_rate.Undo()
            End If
        End If
    End Sub

    '�[�������l�ύX�@2013.1.9
    Private Sub tax_round_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tax_round_1.TextChanged

        If tax_round_1.Modified = False Then
            Exit Sub
        End If
        If Len(Trim$(tax_round_1.Text)) = 0 Then
            tax_round_1.Text = ""

        End If

        L_blnEdit = True

    End Sub

    '�[�������l�ύX�@2013.1.9
    Private Sub tax_round_1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tax_round_1.Leave
        If Not tax_round_1.Text = "" Then
            '------------------------------
            ' �X�V����
            '------------------------------
            If Not LF_UpdTPM090(typUpdata.ROUND_OFF) Then
                Exit Sub
            End If

            tax_round_2.Text = Trim$(GF_GetAppInfo("TAX_ROUND_OFF")) + 1
        Else
            MessageBox.Show("�[�����������̒l����͂��ĉ�����")
            If tax_round_1.CanUndo = True Then
                tax_round_1.Undo()
            End If
        End If
    End Sub

    ' START 2016.05.10 �c��
    Private Sub txt_GAMEHITNUM_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GAMEHITNUM.LostFocus
        If txt_GAMEHITNUM.Modified = False Then
            Exit Sub
        End If

        If Trim$(txt_GAMEHITNUM.Text) = "" Then

            MessageBox.Show("�Q�[���̓����蔻��񐔂̒l����͂��ĉ�����")
            If txt_GAMEHITNUM.CanUndo = True Then
                txt_GAMEHITNUM.Undo()
            End If
        End If
    End Sub
    Private Sub txt_GAMEHITNUM_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GAMEHITNUM.Leave
        If Not txt_GAMEHITNUM.Text = "" Then
            '-------------------------------
            ' �X�V����
            '-------------------------------
            If Not LF_UpdTPM091(typUpdata_game.GAMEHITNUM) Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txt_GAMEPLAYNUM_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GAMEPLAYNUM.LostFocus
        If txt_GAMEPLAYNUM.Modified = False Then
            Exit Sub
        End If

        If Trim$(txt_GAMEPLAYNUM.Text) = "" Then

            MessageBox.Show("�Đ��Q�[�����̒l����͂��ĉ�����")
            If txt_GAMEPLAYNUM.CanUndo = True Then
                txt_GAMEPLAYNUM.Undo()
            End If
        End If
    End Sub
    Private Sub txt_GAMEPLAYNUM_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GAMEPLAYNUM.Leave
        If Not txt_GAMEPLAYNUM.Text = "" Then
            '-------------------------------
            ' �X�V����
            '-------------------------------
            If Not LF_UpdTPM091(typUpdata_game.GAMEPLAYNUM) Then
                Exit Sub
            End If
        End If
    End Sub
    ' END 2016.05.10 �c��

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�V�X�e���Ǘ��}�X�^ �X�V����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM040(ByVal updKbn As CNL1501.CNL2130.typUpdKbn) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM040 = False

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^ �X�V
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM040"
        Select Case updKbn
            Case typUpdKbn.CHGTIME
                strSQL = strSQL & "   SET CHGTIME     = '" & Trim$(txt_Wait_Time.Text) & "'"

            Case typUpdKbn.CHGINT
                strSQL = strSQL & "   SET CHGINT      = '" & Trim$(txt_Chg_Time.Text) & "'"

            Case typUpdKbn.STOREINFO
                strSQL = strSQL & "   SET STOREINFO   = '" & IIf(Len(Trim$(txt_StoreInfo.Text)) = 0, Space(1), GF_RepQuo(Replace(txt_StoreInfo.Text, vbCrLf, "<BR>"))) & "'"

            Case typUpdKbn.SUBTOTAL
                strSQL = strSQL & "   SET SUBTOTAL    = '" & IIf(rdo_Show.Checked, GC_TRUE, GC_FALSE) & "'"

            Case typUpdKbn.CALL_FLG
                strSQL = strSQL & "   SET CALL_FLG    = '" & IIf(rdo_Call_Show.Checked, GC_TRUE, GC_FALSE) & "'"

            Case typUpdKbn.KAIKEI_FLG
                strSQL = strSQL & "   SET KAIKEI_FLG  = '" & IIf(rdo_Kaikei_Show.Checked, GC_TRUE, GC_FALSE) & "'"

            Case typUpdKbn.WARIKAN_FLG
                strSQL = strSQL & "   SET WARIKAN_FLG = '" & IIf(rdo_Warikan_Show.Checked, GC_TRUE, GC_FALSE) & "'"

            Case typUpdKbn.LOGO_VIEW
                strSQL = strSQL & "   SET LOGO_VIEW   = '" & IIf(rdo_Logo_Show.Checked, GC_TRUE, GC_FALSE) & "'"
        End Select

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM040 = True

    End Function

    '�i�؂�4�p�^�[���Ή��@2013.10.28
    Private Function LF_UpdTPM090(ByVal updap As CNL1501.CNL2130.typUpdata) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM090 = False

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^ �X�V
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM090"
        Select Case updap
            Case typUpdata.ALERT_TIME
                strSQL = strSQL & "   SET APVALUE = '" & Trim$(Text_alert.Text) & "'"
                strSQL = strSQL & "   WHERE APKEY = 'ALERT_TIME1'"

            Case typUpdata.ALERT_TIME2
                strSQL = strSQL & "   SET APVALUE = '" & Trim$(Text_alert2.Text) & "'"
                strSQL = strSQL & "   WHERE APKEY = 'ALERT_TIME2'"

            Case typUpdata.ALERT_TIME3
                strSQL = strSQL & "   SET APVALUE   = '" & Trim$(Text_alert3.Text) & "'"
                strSQL = strSQL & "   WHERE APKEY = 'ALERT_TIME3'"

            Case typUpdata.SOLDOUT_NM
                strSQL = strSQL & "   SET APVALUE = '" & Trim$(text_sold_out1.Text) & "'"
                strSQL = strSQL & "   WHERE APKEY = 'SOLDOUT_NM'"

            Case typUpdata.SOLDOUT_NM_2
                strSQL = strSQL & "   SET APVALUE = '" & Trim$(text_sold_out2.Text) & "'"
                strSQL = strSQL & "   WHERE APKEY = 'SOLDOUT_NM_2'"

            Case typUpdata.SOLDOUT_NM_3
                strSQL = strSQL & "   SET APVALUE = '" & Trim$(text_sold_out3.Text) & "'"
                strSQL = strSQL & "   WHERE APKEY = 'SOLDOUT_NM_3'"

            Case typUpdata.SOLDOUT_NM_4
                strSQL = strSQL & "   SET APVALUE = '" & Trim$(text_sold_out4.Text) & "'"
                strSQL = strSQL & "   WHERE APKEY = 'SOLDOUT_NM_4'"

                '����ŗ��ύX�@2013.12.18
            Case typUpdata.TAX_RATE
                strSQL = strSQL & "   SET APVALUE = '" & Trim$(sales_tax_rate.Text) & "'"
                strSQL = strSQL & "   WHERE APKEY = 'SALES_TAX_RATE'"

                '�[�������l�@2013.1.9
            Case typUpdata.ROUND_OFF
                strSQL = strSQL & "   SET APVALUE = '" & Trim$(tax_round_1.Text) & "'"
                strSQL = strSQL & "   WHERE APKEY = 'TAX_ROUND_OFF'"

        End Select


        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM090 = True

    End Function

    ' START 2016.05.10 �c��
    ' �Q�[�������蔻��񐔁A�Q�[���Đ��񐔍X�V����
    Private Function LF_UpdTPM091(ByVal updap As CNL1501.CNL2130.typUpdata_game) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM091 = False

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^ �X�V
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM091"
        Select Case updap
            Case typUpdata_game.GAMEHITNUM
                strSQL = strSQL & "   SET APVALUE = '" & Trim$(txt_GAMEHITNUM.Text) & "'"
                strSQL = strSQL & "   WHERE APKEY = 'CNWH_GAMEHITNUM'"
            Case typUpdata_game.GAMEPLAYNUM
                strSQL = strSQL & "   SET APVALUE = '" & Trim$(txt_GAMEPLAYNUM.Text) & "'"
                strSQL = strSQL & "   WHERE APKEY = 'CNWH_GAMEPLAYNUM'"

        End Select

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM091 = True

    End Function
    ' END 2015.05.10 �c��


    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�}�X�^�l�ݒ荀�� ���͐�������
    ' �@�@�\�T�v�F�L���\���܂ł̑҂�����
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub txt_Wait_Time_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Wait_Time.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�}�X�^�l�ݒ荀�� ���͐�������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub txt_Chg_Time_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Chg_Time.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�}�X�^�l�ݒ荀�� ���͐�������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.08.06    �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub Text_alert_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_alert.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�}�X�^�l�ݒ荀�� ���͐�������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.08.06    �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub Text_alert2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_alert2.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�}�X�^�l�ݒ荀�� ���͐�������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.08.06    �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub Text_alert3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_alert3.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�}�X�^�l�ݒ荀�� ���͐�������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.12 �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub sales_tax_rate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sales_tax_rate.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�}�X�^�l�ݒ荀�� ���͐�������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2014.1.9  �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub tax_round_1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tax_round_1.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    '    ' --------------------------------------------------------------------------------
    '    ' �@�@�@�@�\�F���j���[ - [�ۑ�]����������
    '    ' �@�@�\�T�v�F
    '    ' �@���@�@���F
    '    ' �@�� �� �l�F
    '    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    '    ' --------------------------------------------------------------------------------
    '    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click

    '        Select Case TabControl1.SelectedIndex
    '            Case 0
    '                '------------------------------
    '                ' �X�V�����m�F
    '                '------------------------------
    '                If L_blnEdit Then
    '                    '------------------------------
    '                    ' �g�����U�N�V�����J�n
    '                    '------------------------------
    '                    If Not GF_BeginTrans() Then
    '                        GoTo SYSTEM_ERROR
    '                    End If

    '                    '------------------------------
    '                    ' �X�V����
    '                    '------------------------------
    '                    If Not LF_UpdTPM040() Then
    '                        GoTo SYSTEM_ERROR
    '                    End If

    '                    '------------------------------
    '                    ' �g�����U�N�V�����m��
    '                    '------------------------------
    '                    If Not GF_CommitTrans() Then
    '                        GoTo SYSTEM_ERROR
    '                    End If

    '                    L_blnEdit = False
    '                End If

    '            Case 1
    '                '------------------------------
    '                ' �X�V�����m�F
    '                '------------------------------
    '                If L_blnEdit Then
    '                    '------------------------------
    '                    ' �g�����U�N�V�����m��
    '                    '------------------------------
    '                    If Not GF_CommitTrans() Then
    '                        GoTo SYSTEM_ERROR
    '                    End If

    '                    '------------------------------
    '                    ' �g�����U�N�V�����J�n
    '                    '------------------------------
    '                    If Not GF_BeginTrans() Then
    '                        GoTo SYSTEM_ERROR
    '                    End If

    '                    L_blnEdit = False
    '                Else
    '                    '------------------------------
    '                    ' �g�����U�N�V�����j��
    '                    '------------------------------
    '                    If Not GF_RollbackTrans() Then
    '                        GoTo SYSTEM_ERROR
    '                    End If
    '                End If

    '            Case 2
    '                Exit Sub
    '            Case Else
    '                Exit Sub
    '        End Select

    '        Exit Sub

    'SYSTEM_ERROR:
    '        ''------------------------------
    '        '' �g�����U�N�V�����j��
    '        ''------------------------------
    '        'Call GF_RollbackTrans()
    '        Call GS_ErrorTerm("MenuItem3_Click")
    '    End Sub

    '    Private Sub CNL2130_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

    '        '------------------------------
    '        ' �����ϐ���`
    '        '------------------------------
    '        Dim objRet As MsgBoxResult

    '        Select Case TabControl1.SelectedIndex
    '            Case 0
    '                '------------------------------
    '                ' �X�V�����m�F
    '                '------------------------------
    '                If L_blnEdit Then
    '                    objRet = GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNoCancel)

    '                    Select Case objRet
    '                        Case MsgBoxResult.Yes
    '                            '------------------------------
    '                            ' �g�����U�N�V�����J�n
    '                            '------------------------------
    '                            If Not GF_BeginTrans() Then
    '                                GoTo SYSTEM_ERROR
    '                            End If

    '                            '------------------------------
    '                            ' �X�V����
    '                            '------------------------------
    '                            If Not LF_UpdTPM040() Then
    '                                GoTo SYSTEM_ERROR
    '                            End If

    '                            '------------------------------
    '                            ' �g�����U�N�V�����m��
    '                            '------------------------------
    '                            If Not GF_CommitTrans() Then
    '                                GoTo SYSTEM_ERROR
    '                            End If

    '                        Case MsgBoxResult.No

    '                        Case MsgBoxResult.Cancel
    '                            e.Cancel = True
    '                    End Select

    '                End If

    '            Case 1
    '                '------------------------------
    '                ' �X�V�����m�F
    '                '------------------------------
    '                If L_blnEdit Then
    '                    objRet = GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNoCancel)

    '                    Select Case objRet
    '                        Case MsgBoxResult.Yes
    '                            '------------------------------
    '                            ' �g�����U�N�V�����m��
    '                            '------------------------------
    '                            If Not GF_CommitTrans() Then
    '                                GoTo SYSTEM_ERROR
    '                            End If

    '                        Case MsgBoxResult.No
    '                            '------------------------------
    '                            ' �g�����U�N�V�����j��
    '                            '------------------------------
    '                            If Not GF_RollbackTrans() Then
    '                                GoTo SYSTEM_ERROR
    '                            End If

    '                        Case MsgBoxResult.Cancel
    '                            e.Cancel = True
    '                    End Select
    '                Else
    '                    '------------------------------
    '                    ' �g�����U�N�V�����j��
    '                    '------------------------------
    '                    If Not GF_RollbackTrans() Then
    '                        GoTo SYSTEM_ERROR
    '                    End If
    '                End If

    '            Case 2

    '            Case Else
    '                Exit Sub
    '        End Select

    '        Exit Sub

    'SYSTEM_ERROR:
    '        '------------------------------
    '        ' �g�����U�N�V�����j��
    '        '------------------------------
    '        Call GF_RollbackTrans()
    '        Call GS_ErrorTerm("CNL2130_Closing")
    '    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���ݒ菈��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_FormSetup()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        txt_Msg1.Clear()
        btn_Add.Enabled = True
        btn_Del.Enabled = True

        '------------------------------
        ' ��ʏ����l�ݒ�
        '------------------------------
        With lsv_MsgList
            .Clear()
            .FullRowSelect = True
            .Columns.Add("���b�Z�[�W", 275, HorizontalAlignment.Left)
            .MultiSelect = False
            .HideSelection = False
        End With

        '------------------------------
        ' ���b�Z�[�W���X�g�쐬
        '------------------------------
        Call LS_FreeMsgList()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_FormSetup")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���b�Z�[�W���X�g�쐬����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_FreeMsgList()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim objItem As ListViewItem

        '------------------------------
        ' ���b�Z�[�W�ꗗ�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM030.CODEID,"
        strSQL = strSQL & "       TPM030.CODEVAL,"
        strSQL = strSQL & "       TPM030.CODENM"
        strSQL = strSQL & "  FROM TPM030 LEFT JOIN TPM120 ON TPM030.CODEID = TPM120.CODEID AND TPM030.CODEVAL = TPM120.CODEVAL AND TPM120.IMAGECD LIKE 'MA%'"
        strSQL = strSQL & " WHERE TPM030.CODEID  = 'SENDMSG2'"
        strSQL = strSQL & " ORDER BY TPM030.CODEVAL"

        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' ���X�g�{�b�N�X�ݒ�
        '------------------------------
        lsv_MsgList.Items.Clear()
        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                GoTo SYSTEM_ERROR
            End If

            objItem = New ListViewItem()
            With objItem
                .Text = LF_N2S(objRows("CODENM"))
                .SubItems.Add(LF_N2S(objRows("CODEVAL")))
                .SubItems.Add(LF_N2S(objRows("CODENM")))
                .SubItems.Add("")
                .SubItems.Add("")
            End With
            lsv_MsgList.Items.Add(objItem)

            lngCnt = lngCnt + 1
        End While

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_FreeMsgList")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�m�t�k�k�l���菈��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_N2S(ByVal pObject As Object) As String

        LF_N2S = ""
        If IsDBNull(pObject) Then
            Exit Function
        Else
            LF_N2S = Trim$(pObject)
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���b�Z�[�W���X�g�@�I�����b�Z�[�W�ύX����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub lsv_MsgList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_MsgList.SelectedIndexChanged

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim strNoImgCD(2) As String

        objCollection = lsv_MsgList.SelectedItems
        With objCollection
            If .Count = 0 Then
                Exit Sub
            End If

            If .Contains(.Item(0)) = False Then
                Exit Sub
            End If

            txt_Msg1.Text = RTrim$(.Item(0).SubItems(2).Text)
        End With

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���M���b�Z�[�W�����ύX����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub txt_Msg1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Msg1.TextChanged

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngST As Long
        Dim objCollection As ListView.SelectedListViewItemCollection

        '------------------------------
        ' �C�x���g�������s����
        '------------------------------
        If txt_Msg1.Modified = False Then
            Exit Sub
        End If

        '------------------------------
        ' ���p���͋֎~
        '------------------------------
        lngST = txt_Msg1.SelectionStart
        ' 2014-05-12 2�o�C�g������������
        'txt_Msg1.Text = StrConv(txt_Msg1.Text, VbStrConv.Wide)
        If lngST >= 0 Then
            txt_Msg1.SelectionStart = lngST
        End If

        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(txt_Msg1.Text) > 40 Then
            txt_Msg1.Text = GF_MidB(txt_Msg1.Text, 1, 40)
            txt_Msg1.SelectionStart = GF_LenB(txt_Msg1.Text)
            Exit Sub
        End If

        '------------------------------
        ' �X�V����
        '------------------------------
        objCollection = lsv_MsgList.SelectedItems
        With objCollection
            If .Count = 0 Then
                Exit Sub
            End If

            If .Contains(.Item(0)) = False Then
                Exit Sub
            End If

            .Item(0).SubItems(2).Text = Trim$(txt_Msg1.Text)
            .Item(0).SubItems(0).Text = Trim$(txt_Msg1.Text)

            If Not LF_UpdTPM030(Trim$(.Item(0).SubItems(1).Text), RTrim$(.Item(0).SubItems(2).Text)) Then
                GoTo SYSTEM_ERROR
            End If
        End With

        L_blnEdit = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_Msg1_TextChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�s�o�l�O�R�O�X�V����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM030(ByVal pMsgCD As String, ByVal pMsgVal As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim strMsg As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM030 = False

        If Len(Trim$(pMsgVal)) = 0 Then
            strMsg = Space(40)
        Else
            strMsg = pMsgVal
        End If

        '------------------------------
        ' ���b�Z�[�W�}�X�^�X�V
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM030"
        strSQL = strSQL & "   SET CODENM  = '" & GF_RepQuo(strMsg) & "',"
        strSQL = strSQL & "       UPDID   = 'SYSTEM',"
        strSQL = strSQL & "       UPDYMD  = getdate()"
        strSQL = strSQL & " WHERE CODEID  = 'SENDMSG2'"
        strSQL = strSQL & "   AND CODEVAL = '" & pMsgCD & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM030 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u�V�K�ǉ��v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click

        '------------------------------
        ' �s�o�l�O�R�O�ǉ�����
        '------------------------------
        If Not LF_InsTPM030() Then
            GoTo SYSTEM_ERROR
        End If

        Call LS_FreeMsgList()

        L_blnEdit = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Add_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u�폜�v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Del.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection

        '------------------------------
        ' �C�x���g�������s����
        '------------------------------
        objCollection = lsv_MsgList.SelectedItems
        With objCollection
            If .Count = 0 Then
                Exit Sub
            End If

            If .Contains(.Item(0)) = False Then
                Exit Sub
            End If
        End With

        If GF_Msg("", Replace(GF_GetMsg("Q05"), "@@@", objCollection.Item(0).SubItems.Item(0).Text), MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        '------------------------------
        ' �s�o�l�O�R�O�폜����
        '------------------------------
        If Not LF_DelTPM030() Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' ���b�Z�[�W�ꗗ����
        '------------------------------
        Call LS_FreeMsgList()

        txt_Msg1.Clear()

        L_blnEdit = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Del_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�s�o�l�O�R�O�ǉ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_InsTPM030() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngI As Long
        Dim strNewID As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_InsTPM030 = False

        '------------------------------
        ' �̔ԏ���
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT CODEVAL"
        strSQL = strSQL & "  FROM TPM030"
        strSQL = strSQL & " WHERE CODEID = 'SENDMSG2'"
        strSQL = strSQL & " ORDER BY CODEVAL"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        strNewID = ""
        If objData.Tables("com").Rows.Count = 0 Then
            strNewID = "I00"
        Else
            If Not GF_GetRows(objData, objData.Tables("com").Rows.Count - 1, objRows) Then
                Exit Function
            End If

            If Mid(Trim$(objRows("CODEVAL")), 2) = "99" Then
                ' �󂫔Ԍ�������
                lngI = 0
                While lngI < objData.Tables("com").Rows.Count
                    If Not GF_GetRows(objData, lngI, objRows) Then
                        Exit Function
                    End If
                    If lngI <> CLng(Mid$(Trim$(objRows("CODEVAL")), 2)) Then
                        strNewID = "I" & Format$(lngI, "00")
                        Exit While
                    End If

                    lngI = lngI + 1
                End While

                If Len(Trim$(strNewID)) = 0 Then
                    Call GF_Msg("", "����ȏ�A���b�Z�[�W��ǉ����邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                    LF_InsTPM030 = True
                    Exit Function
                End If
            Else
                strNewID = "I" & Format$(CLng(Mid(Trim$(objRows("CODEVAL")), 2)) + 1, "00")
            End If
        End If

        '------------------------------
        ' �V�K���b�Z�[�W���R�[�h�ǉ�
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM030 VALUES("
        strSQL = strSQL & "       'SENDMSG2',"
        strSQL = strSQL & "       '" & strNewID & "',"
        strSQL = strSQL & "       '�V�K�ǉ����b�Z�[�W',"
        strSQL = strSQL & "       'SYSTEM',"
        strSQL = strSQL & "       getdate())"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_InsTPM030 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�s�o�l�O�R�O�폜����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_DelTPM030() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_DelTPM030 = False

        '------------------------------
        ' �C�x���g�������s����
        '------------------------------
        objCollection = lsv_MsgList.SelectedItems
        With objCollection
            If .Count = 0 Then
                Exit Function
            End If

            If .Contains(.Item(0)) = False Then
                Exit Function
            End If
        End With

        '------------------------------
        ' ���b�Z�[�W�}�X�^�폜
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE"
        strSQL = strSQL & "  FROM TPM030"
        strSQL = strSQL & " WHERE TPM030.CODEID  = 'SENDMSG2'"
        strSQL = strSQL & "   AND TPM030.CODEVAL = '" & Trim$(objCollection.Item(0).SubItems(1).Text) & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �C���X�g�֘A�t���}�X�^�폜
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE"
        strSQL = strSQL & "  FROM TPM120"
        strSQL = strSQL & " WHERE TPM120.CODEID  = 'SENDMSG2'"
        strSQL = strSQL & "   AND TPM120.CODEVAL = '" & Trim$(objCollection.Item(0).SubItems(1).Text) & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_DelTPM030 = True

    End Function

    Private Sub btn_Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Browse.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objFolder As New BrowseFolder()
        Dim strSelPath As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        Try
            strSelPath = objFolder.BrowseDialog("�t�H���_���w�肵�Ă�������", Me)
            txt_PutPath.Text = strSelPath
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Browse_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u����f�[�^�o�́v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_OutputCsv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OutputCsv.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim RowsCnt As Integer
        Dim ColmCnt As Integer
        Dim strEncoding As System.Text.Encoding
        Dim strStreamWriter As System.IO.StreamWriter = Nothing


        If System.IO.File.Exists(txt_PutPathCsv.Text) = True Then
            '------------------------------
            ' �_�C�A���O�{�b�N�X�\��
            '------------------------------
            If Not GetSaveFile() Then
                Call GF_Msg("", "���ɓ��ꖼ�̂̃t�@�C�����o�^����Ă��܂�" & vbCrLf & "�t�@�C������ύX���Ă�������", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                Exit Sub
            End If
        End If

        '------------------------------
        ' ���[�f�[�^�擾����
        '------------------------------
        If Not LF_GetDATA(objData) Then
            Exit Sub
        End If

        Try
            '------------------------------
            ' �t�@�C�����ݒ�
            '------------------------------
            strEncoding = System.Text.Encoding.GetEncoding("Shift_JIS")
            strStreamWriter = New System.IO.StreamWriter(txt_PutPathCsv.Text, False, strEncoding)

            '------------------------------
            ' �t�@�C���o��
            '------------------------------
            ColmCnt = 0

            While ColmCnt < objData.Tables("com").Columns.Count
                If Not GF_GetRows(objData, RowsCnt, objRows) Then
                    Exit Sub
                End If

                If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                    strStreamWriter.WriteLine(objData.Tables("com").Columns(ColmCnt))
                Else
                    strStreamWriter.Write(objData.Tables("com").Columns(ColmCnt))
                    strStreamWriter.Write(",")
                End If

                ColmCnt = ColmCnt + 1
            End While

            ColmCnt = 0
            RowsCnt = 0
            While RowsCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, RowsCnt, objRows) Then
                    Exit Sub
                End If

                While ColmCnt < objData.Tables("com").Columns.Count
                    If Not GF_GetRows(objData, RowsCnt, objRows) Then
                        Exit Sub
                    End If

                    If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                        strStreamWriter.WriteLine(objData.Tables("com").Rows(RowsCnt)(ColmCnt))
                    Else
                        strStreamWriter.Write(objData.Tables("com").Rows(RowsCnt)(ColmCnt) & ",")
                    End If

                    ColmCnt = ColmCnt + 1
                End While

                ColmCnt = 0
                RowsCnt = RowsCnt + 1
            End While
        Catch
            strStreamWriter.Close()
            MsgBox("�t�@�C���̏o�͂Ɏ��s���܂���")

            Exit Sub
        End Try

        strStreamWriter.Close()
        Call GF_Msg("", "����f�[�^���쐬���܂���" & vbCrLf & "[" & txt_PutPathCsv.Text & "]", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_OutputCsv_Click")
    End Sub

    '' --------------------------------------------------------------------------------
    '' �@�@�@�@�\�F���[�e�[�u���X�V����(�c�d�k�d�s�d)
    '' �@�@�\�T�v�F
    '' �@���@�@���F
    '' �@�� �� �l�F
    '' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    '' --------------------------------------------------------------------------------
    'Private Function LF_Delete() As Boolean

    '    '------------------------------
    '    ' �����ϐ���`
    '    '------------------------------
    '    Dim strSQL As String

    '    '------------------------------
    '    ' �����l�ݒ�
    '    '------------------------------
    '    LF_Delete = False

    '    '------------------------------
    '    ' SQL�g��
    '    '------------------------------
    '    strSQL = ""
    '    strSQL = strSQL & "DELETE"
    '    strSQL = strSQL & "  FROM TPD100"

    '    If Not GF_UpdCmtData(strSQL) Then
    '        Exit Function
    '    End If

    '    '------------------------------
    '    ' �ԋp�l�ݒ�
    '    '------------------------------
    '    LF_Delete = True

    'End Function

    '' --------------------------------------------------------------------------------
    '' �@�@�@�@�\�F���[�e�[�u���쐬����
    '' �@�@�\�T�v�F
    '' �@���@�@���F
    '' �@�� �� �l�F
    '' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    '' --------------------------------------------------------------------------------
    'Private Function LF_CreateWorkTable() As FuncResult

    '    '------------------------------
    '    ' �����ϐ���`
    '    '------------------------------
    '    Dim objData As New DataSet()
    '    Dim objRows As DataRow = Nothing
    '    Dim lngCnt As Long
    '    Dim strNow As String
    '    Dim lngSum As Long
    '    Dim objSum As strOrderData

    '    '------------------------------
    '    ' �����l�ݒ�
    '    '------------------------------
    '    LF_CreateWorkTable = CNL1920.FuncResult.UnusualEnd
    '    strNow = Format(Now(), "yyyyMMdd")

    '    With objSum
    '        .OUTSHOHIN = ""
    '        .SHOHIN = "9999"
    '        .SHOHINNM = "���v"
    '        .TIME00 = "0"
    '        .TIME01 = "0"
    '        .TIME02 = "0"
    '        .TIME03 = "0"
    '        .TIME04 = "0"
    '        .TIME05 = "0"
    '        .TIME06 = "0"
    '        .TIME07 = "0"
    '        .TIME08 = "0"
    '        .TIME09 = "0"
    '        .TIME10 = "0"
    '        .TIME11 = "0"
    '        .TIME12 = "0"
    '        .TIME13 = "0"
    '        .TIME14 = "0"
    '        .TIME15 = "0"
    '        .TIME16 = "0"
    '        .TIME17 = "0"
    '        .TIME18 = "0"
    '        .TIME19 = "0"
    '        .TIME20 = "0"
    '        .TIME21 = "0"
    '        .TIME22 = "0"
    '        .TIME23 = "0"
    '        .URIAGE = "0"
    '        .URIAGE_NUM = "0"
    '    End With

    '    '------------------------------
    '    ' �f�[�^�擾
    '    '------------------------------
    '    If Not LF_GetData(objData) Then
    '        Exit Function
    '    End If

    '    If objData.Tables("com").Rows.Count = 0 Then
    '        Call GF_Msg("", "�Ώۃf�[�^������܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
    '        LF_CreateWorkTable = CNL1920.FuncResult.CancelEnd
    '        Exit Function
    '    End If

    '    Try
    '        lngCnt = 0
    '        If Not GF_GetRows(objData, lngCnt, objRows) Then
    '            Exit Function
    '        End If

    '        While lngCnt < objData.Tables("com").Rows.Count
    '            '------------------------------
    '            ' �G���A�̏�����
    '            '------------------------------
    '            Call LS_ClearData()
    '            L_OrderDatakey.SHOHIN = CStr(objRows("SHOHIN"))             ' �L�[�ޔ�

    '            L_OrderData.SHOHINKIND = "���i�ԍ�"
    '            L_OrderData.OUTSHOHIN = CStr(objRows("SHOHIN"))
    '            L_OrderData.SHOHINNM = CStr(objRows("SHOHINNM")) & CStr(objRows("SHOHINNM2"))
    '            L_OrderData.SHOHIN = CStr(objRows("SHOHIN"))

    '            lngSum = 0
    '            While L_OrderDatakey.SHOHIN = CStr(objRows("SHOHIN")) And _
    '                  lngCnt < objData.Tables("com").Rows.Count

    '                Select Case CStr(objRows("TIME"))
    '                    'Select Case strNow & CStr(objRows("TIME")).Substring(8, 2)
    '                    'Case strNow & "00"
    '                    '    L_OrderData.TIME00 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME00 = CLng(objSum.TIME00) + CLng(objRows("CNT"))
    '                    'Case strNow & "01"
    '                    '    L_OrderData.TIME01 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME01 = CLng(objSum.TIME01) + CLng(objRows("CNT"))
    '                    'Case strNow & "02"
    '                    '    L_OrderData.TIME02 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME02 = CLng(objSum.TIME02) + CLng(objRows("CNT"))
    '                    'Case strNow & "03"
    '                    '    L_OrderData.TIME03 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME03 = CLng(objSum.TIME03) + CLng(objRows("CNT"))
    '                    'Case strNow & "04"
    '                    '    L_OrderData.TIME04 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME04 = CLng(objSum.TIME04) + CLng(objRows("CNT"))
    '                    'Case strNow & "05"
    '                    '    L_OrderData.TIME05 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME05 = CLng(objSum.TIME05) + CLng(objRows("CNT"))
    '                    'Case strNow & "06"
    '                    '    L_OrderData.TIME06 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME06 = CLng(objSum.TIME06) + CLng(objRows("CNT"))
    '                    Case strNow & "07"
    '                        L_OrderData.TIME07 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME07 = CLng(objSum.TIME07) + CLng(objRows("CNT"))
    '                    Case strNow & "08"
    '                        L_OrderData.TIME08 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME08 = CLng(objSum.TIME08) + CLng(objRows("CNT"))
    '                    Case strNow & "09"
    '                        L_OrderData.TIME09 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME09 = CLng(objSum.TIME09) + CLng(objRows("CNT"))
    '                    Case strNow & "10"
    '                        L_OrderData.TIME10 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME10 = CLng(objSum.TIME10) + CLng(objRows("CNT"))
    '                    Case strNow & "11"
    '                        L_OrderData.TIME11 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME11 = CLng(objSum.TIME11) + CLng(objRows("CNT"))
    '                    Case strNow & "12"
    '                        L_OrderData.TIME12 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME12 = CLng(objSum.TIME12) + CLng(objRows("CNT"))
    '                    Case strNow & "13"
    '                        L_OrderData.TIME13 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME13 = CLng(objSum.TIME13) + CLng(objRows("CNT"))
    '                    Case strNow & "14"
    '                        L_OrderData.TIME14 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME14 = CLng(objSum.TIME14) + CLng(objRows("CNT"))
    '                    Case strNow & "15"
    '                        L_OrderData.TIME15 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME15 = CLng(objSum.TIME15) + CLng(objRows("CNT"))
    '                    Case strNow & "16"
    '                        L_OrderData.TIME16 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME16 = CLng(objSum.TIME16) + CLng(objRows("CNT"))
    '                    Case strNow & "17"
    '                        L_OrderData.TIME17 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME17 = CLng(objSum.TIME17) + CLng(objRows("CNT"))
    '                    Case strNow & "18"
    '                        L_OrderData.TIME18 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME18 = CLng(objSum.TIME18) + CLng(objRows("CNT"))
    '                    Case strNow & "19"
    '                        L_OrderData.TIME19 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME19 = CLng(objSum.TIME19) + CLng(objRows("CNT"))
    '                    Case strNow & "20"
    '                        L_OrderData.TIME20 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME20 = CLng(objSum.TIME20) + CLng(objRows("CNT"))
    '                    Case strNow & "21"
    '                        L_OrderData.TIME21 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME21 = CLng(objSum.TIME21) + CLng(objRows("CNT"))
    '                    Case strNow & "22"
    '                        L_OrderData.TIME22 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME22 = CLng(objSum.TIME22) + CLng(objRows("CNT"))
    '                    Case strNow & "23"
    '                        L_OrderData.TIME23 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME23 = CLng(objSum.TIME23) + CLng(objRows("CNT"))
    '                    Case Else
    '                        '�������Ȃ�
    '                End Select

    '                L_OrderData.URIAGE = L_OrderData.URIAGE + (CInt(objRows("PRICE")))
    '                objSum.URIAGE = objSum.URIAGE + CInt(objRows("PRICE"))

    '                lngCnt = lngCnt + 1
    '                If lngCnt < objData.Tables("com").Rows.Count Then
    '                    If Not GF_GetRows(objData, lngCnt, objRows) Then
    '                        Exit Function
    '                    End If
    '                End If
    '            End While

    '            L_OrderData.URIAGE_NUM = CStr(lngSum)
    '            objSum.URIAGE_NUM = CStr(CLng(objSum.URIAGE_NUM) + lngSum)

    '            '------------------------------
    '            ' ���[�e�[�u���X�V(���׃f�[�^�ǉ�)
    '            '------------------------------
    '            If Not LF_UpdData(L_OrderData) Then
    '                Exit Function
    '            End If
    '        End While

    '        objSum.SHOHINKIND = L_OrderData.SHOHINKIND
    '        '------------------------------
    '        ' ���[�e�[�u���X�V(���v�f�[�^�ǉ�)
    '        '------------------------------
    '        If Not LF_UpdData(objSum) Then
    '            Exit Function
    '        End If

    '    Catch
    '        Exit Function
    '    End Try

    '    '------------------------------
    '    ' �ԋp�l�ݒ�
    '    '------------------------------
    '    LF_CreateWorkTable = CNL1920.FuncResult.NormalEnd

    'End Function

    Private Function GetSaveFile() As Boolean

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        GetSaveFile = False

        '------------------------------
        ' SaveFileDialog�N���X�̃C���X�^���X���쐬
        '------------------------------
        Dim sfd As New SaveFileDialog()

        '------------------------------
        ' �͂��߂̃t�@�C�������w�肷��
        '------------------------------
        sfd.FileName = "PriceData(" & Format$(Now, "yyyyMMddHHmmss") & ").csv"

        '------------------------------
        ' �͂��߂ɕ\�������t�H���_���w�肷��
        '------------------------------
        sfd.InitialDirectory = Trim$(GF_GetAppInfo("SALES_PATH"))

        '------------------------------
        ' [�t�@�C���̎��]�ɕ\�������I�������w�肷��
        '------------------------------
        sfd.Filter = "csv�t�@�C��|*.csv|���ׂẴt�@�C��(*.*)|*.*"

        '------------------------------
        ' [�t�@�C���̎��]�ł͂��߂�
        ' �u���ׂẴt�@�C���v���I������Ă���悤�ɂ���
        '------------------------------
        sfd.FilterIndex = 2

        '------------------------------
        ' �^�C�g����ݒ肷��
        '------------------------------
        sfd.Title = "�ۑ���̃t�@�C����I�����Ă�������"

        '------------------------------
        ' �_�C�A���O�{�b�N�X�����O�Ɍ��݂̃f�B���N�g���𕜌�����悤�ɂ���
        '------------------------------
        sfd.RestoreDirectory = True

        '------------------------------
        ' ���ɑ��݂���t�@�C�������w�肵���Ƃ��x������
        ' �f�t�H���g��True�Ȃ̂Ŏw�肷��K�v�͂Ȃ�
        '------------------------------
        sfd.OverwritePrompt = True

        '------------------------------
        ' ���݂��Ȃ��p�X���w�肳�ꂽ�Ƃ��x����\������
        ' �f�t�H���g��True�Ȃ̂Ŏw�肷��K�v�͂Ȃ�
        '------------------------------
        sfd.CheckPathExists = True

        '------------------------------
        ' �_�C�A���O��\������
        '------------------------------
        If sfd.ShowDialog() = DialogResult.OK Then
            txt_PutPathCsv.Text = sfd.FileName
        Else
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        GetSaveFile = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���[�f�[�^�擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetDATA(ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetDATA = False

        '------------------------------
        ' SQL�g��
        '------------------------------
        strSQL = ""
        strSQL = strSQL & " SELECT TPM010.GOODSCD AS '���i�ԍ�',"
        strSQL = strSQL & "        MAX(LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ, '�@', ' '))) + LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ2, '�@', ' ')))) AS '���i����',"
        strSQL = strSQL & "        ISNULL(SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END),0) AS '���㐔��',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 09 THEN TPD010.QUANTITY ELSE '0' END) AS '9:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 10 THEN TPD010.QUANTITY ELSE '0' END) AS '10:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 11 THEN TPD010.QUANTITY ELSE '0' END) AS '11:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 12 THEN TPD010.QUANTITY ELSE '0' END) AS '12:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 13 THEN TPD010.QUANTITY ELSE '0' END) AS '13:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 14 THEN TPD010.QUANTITY ELSE '0' END) AS '14:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 15 THEN TPD010.QUANTITY ELSE '0' END) AS '15:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 16 THEN TPD010.QUANTITY ELSE '0' END) AS '16:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 17 THEN TPD010.QUANTITY ELSE '0' END) AS '17:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 18 THEN TPD010.QUANTITY ELSE '0' END) AS '18:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 19 THEN TPD010.QUANTITY ELSE '0' END) AS '19:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 20 THEN TPD010.QUANTITY ELSE '0' END) AS '20:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 21 THEN TPD010.QUANTITY ELSE '0' END) AS '21:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 22 THEN TPD010.QUANTITY ELSE '0' END) AS '22:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 23 THEN TPD010.QUANTITY ELSE '0' END) AS '23:00',"
        strSQL = strSQL & "        SUM(CASE WHEN LEN(CONVERT(CHAR,TPD010.TRANSTIME)) = 1 THEN '0' WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 00 THEN TPD010.QUANTITY ELSE '0' END) AS '0:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 01 THEN TPD010.QUANTITY ELSE '0' END) AS '1:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 02 THEN TPD010.QUANTITY ELSE '0' END) AS '2:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 03 THEN TPD010.QUANTITY ELSE '0' END) AS '3:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 04 THEN TPD010.QUANTITY ELSE '0' END) AS '4:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 05 THEN TPD010.QUANTITY ELSE '0' END) AS '5:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 06 THEN TPD010.QUANTITY ELSE '0' END) AS '6:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 07 THEN TPD010.QUANTITY ELSE '0' END) AS '7:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 08 THEN TPD010.QUANTITY ELSE '0' END) AS '8:00',"
        strSQL = strSQL & "        ISNULL((SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END) * MAX(TPM010.PRICE)),0) AS '������z'"
        strSQL = strSQL & "   FROM TPM010 LEFT JOIN TPD010 ON TPM010.GOODSCD = TPD010.GOODSCD"
        strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999"
        strSQL = strSQL & " GROUP BY TPM010.GOODSCD"

        '���ݕ��菤�i�ʏW�v
        strSQL = strSQL & " UNION"
        strSQL = strSQL & " SELECT TPM010.GOODSCD AS '���i�ԍ�',"
        strSQL = strSQL & "        MAX(LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ, '�@', ' '))) + LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ2, '�@', ' ')))) + '" & GF_GetAppInfo2("FREEGOODS_MARK") & "' AS '���i����',"
        strSQL = strSQL & "        ISNULL(SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END),0) AS '���㐔��',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 09 THEN TPD010.QUANTITY ELSE '0' END) AS '9:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 10 THEN TPD010.QUANTITY ELSE '0' END) AS '10:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 11 THEN TPD010.QUANTITY ELSE '0' END) AS '11:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 12 THEN TPD010.QUANTITY ELSE '0' END) AS '12:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 13 THEN TPD010.QUANTITY ELSE '0' END) AS '13:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 14 THEN TPD010.QUANTITY ELSE '0' END) AS '14:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 15 THEN TPD010.QUANTITY ELSE '0' END) AS '15:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 16 THEN TPD010.QUANTITY ELSE '0' END) AS '16:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 17 THEN TPD010.QUANTITY ELSE '0' END) AS '17:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 18 THEN TPD010.QUANTITY ELSE '0' END) AS '18:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 19 THEN TPD010.QUANTITY ELSE '0' END) AS '19:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 20 THEN TPD010.QUANTITY ELSE '0' END) AS '20:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 21 THEN TPD010.QUANTITY ELSE '0' END) AS '21:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 22 THEN TPD010.QUANTITY ELSE '0' END) AS '22:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 23 THEN TPD010.QUANTITY ELSE '0' END) AS '23:00',"
        strSQL = strSQL & "        SUM(CASE WHEN LEN(CONVERT(CHAR,TPD010.TRANSTIME)) = 1 THEN '0' WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 00 THEN TPD010.QUANTITY ELSE '0' END) AS '0:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 01 THEN TPD010.QUANTITY ELSE '0' END) AS '1:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 02 THEN TPD010.QUANTITY ELSE '0' END) AS '2:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 03 THEN TPD010.QUANTITY ELSE '0' END) AS '3:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 04 THEN TPD010.QUANTITY ELSE '0' END) AS '4:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 05 THEN TPD010.QUANTITY ELSE '0' END) AS '5:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 06 THEN TPD010.QUANTITY ELSE '0' END) AS '6:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 07 THEN TPD010.QUANTITY ELSE '0' END) AS '7:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 08 THEN TPD010.QUANTITY ELSE '0' END) AS '8:00',"
        strSQL = strSQL & "        ISNULL((SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END) * MAX(TPM010.PRICE)),0) AS '������z'"
        strSQL = strSQL & "   FROM TPM010 LEFT JOIN TPD010 ON TPM010.GOODSCD = TPD010.GOODSCD"
        strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999"
        strSQL = strSQL & "   AND   TPD010.ORDERFLG = '50'"
        strSQL = strSQL & " GROUP BY TPM010.GOODSCD"
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

        '------------------------------
        ' �f�[�^�擾
        '------------------------------
        If Not GF_GetData(strSQL, pDataSet) Then
            Call GF_Msg("", "DB�ڑ��Ɏ��s���܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            Exit Function
        End If

        If pDataSet.Tables("com").Rows.Count = 0 Then
            Call GF_Msg("", "�Ώۃf�[�^������܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            Exit Function
        End If


        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetDATA = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�X�y�[�X���ߏ���
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Public Function LF_PadSpc(ByVal pStr As String, ByVal Length As Long) As String

        LF_PadSpc = Space(Length - Len(Trim$(pStr))) & Trim$(pStr)

    End Function

    Private Sub btn_BrowseCsv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BrowseCsv.Click

        '------------------------------       
        ' �����ϐ���`
        '------------------------------
        Dim FileName As String = Nothing

        '------------------------------
        ' �_�C�A���O�{�b�N�X�\��
        '------------------------------
        If Not GetSaveFile() Then
            Exit Sub
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�g�b�v��ʕ\���p�^�[���ؑ֕\������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.10.07 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_TopCmbSetup()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow
        Dim lngCnt As Long

        '------------------------------
        ' �����l�ݒ�
        '------------------------------

        Cbo_TopChg.DropDownStyle = ComboBoxStyle.DropDownList

        '------------------------------
        ' �g�b�v���j���[���X�g�擾
        '------------------------------

        strSQL = ""
        strSQL = strSQL & "SELECT TPM240.PATTERNID,"
        strSQL = strSQL & "       TPM240.PATTERNNM"
        strSQL = strSQL & "  FROM TPM240"
        strSQL = strSQL & " GROUP BY TPM240.PATTERNID,"
        strSQL = strSQL & "          TPM240.PATTERNNM"
        'strSQL = strSQL & " ORDER BY TPM240.PATTERNNM,"
        'strSQL = strSQL & "          TPM240.PATTERNID"

        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �g�b�v���j���[�I���R���{�ݒ�
        '------------------------------
        Try
            Cbo_TopChg.Items.Clear()
            lngCnt = 0

            While lngCnt < objData.Tables("com").Rows.Count
                objRows = Nothing
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    GoTo SYSTEM_ERROR
                End If

                Call GS_CboItemSet(Cbo_TopChg, Trim$(objRows("PATTERNNM")), Trim$(objRows("PATTERNID")))

                lngCnt = lngCnt + 1
            End While

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_TopCmbSetup")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�g�b�v��ʕ\���p�^�[���ؑ֍X�V����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.10.07 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub Cbo_TopChg_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_TopChg.SelectionChangeCommitted


        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^ �X�V
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM091"
        strSQL = strSQL & "   SET APVALUE = '" & Trim$(GF_CboGetCode(Cbo_TopChg, Cbo_TopChg.SelectedIndex)) & "'"
        strSQL = strSQL & " WHERE APKEY = 'TOP_DISPCD'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Sub
        End If

        GF_Msg("", "�g�b�v��ʂ�؂�ւ��܂���", MsgBoxStyle.OkOnly)


    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FCrossNavi�y���V�[�g�Ĉ󎚋@�\�z
    ' �@�@�\�T�v�F���V�[�g�Ĉ󎚃{�^�������Ń��V�[�g�Ĉ󎚂��s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2014.1 �@�\�ڐA
    ' --------------------------------------------------------------------------------
    Private Sub btn_Reprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reprint.Click
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim strSeatId As String
        Dim strOrderNo As Integer
        Dim objCollection As ListView.SelectedListViewItemCollection

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        objCollection = lsv_OrderList.SelectedItems
        With objCollection
            If .Count = 0 Then
                MsgBox("�Ȕԍ���I��ł��������B")
                Exit Sub
            End If

            '------------------------------
            ' �K�C�_���X���ҏW�̈�֓]�L
            '------------------------------
            strSeatId = .Item(0).SubItems.Item(1).Text
            strOrderNo = .Item(0).SubItems.Item(2).Text
        End With

        '------------------------------
        ' ���b�Z�[�W�}�X�^�X�V
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPD010"
        strSQL = strSQL & "   SET ORDERKIND = '2',"
        strSQL = strSQL & "       UPDID     = 'CNL2130',"
        strSQL = strSQL & "       UPDYMD    = getdate()"
        strSQL = strSQL & " WHERE SEATID    = '" & RSet(strSeatId, 5) & "'"
        strSQL = strSQL & "   AND ORDERNO   = " & strOrderNo
        strSQL = strSQL & "   AND GOODSCD   = '" & GF_GetAppInfo("REG_GOODSCD") & "'"

        If Not GF_UpdCmtData(strSQL) Then
            MsgBox("�X�V�Ɏ��s���܂����B�ēx�X�V���s���Ă��������B")
            Exit Sub
        End If
        MsgBox("���V�[�g�Ĉ󎚂��܂����B")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FCrossNavi�y���V�[�g�Ĉ󎚋@�\�z
    ' �@�@�\�T�v�F�^�u����\����
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2014.1 �@�\�ڐA
    ' --------------------------------------------------------------------------------
    Private Sub TabPage5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage5.Enter

        '�R���{�{�b�N�X�̏�����
        Call LS_CmbSetup()
        cbo_SeatChg.SelectedIndex = 0

        '�����ꗗ���X�g�̍쐬
        Call LS_SetOrderList(LC_ALL_SELECT)
        lsv_OrderList.HideSelection = False

        '�������׃��X�g�̍쐬
        Call LS_SetOrderDetails(LC_NO_SEATID, LC_NO_ORDERNO)

        If GF_GetAppInfo3("RECEIPT_REPRINTING") = 1 Then
            btn_Reprint.Visible = False
        End If


    End Sub
    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FCrossNavi�y���V�[�g�Ĉ󎚋@�\�z
    ' �@�@�\�T�v�F���ȍi���݌�����
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2014.1 �@�\�ڐA
    ' --------------------------------------------------------------------------------
    Private Sub CmbChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_SeatChg.SelectionChangeCommitted
        Call LS_SetOrderList(Trim$(GF_CboGetCode(cbo_SeatChg, cbo_SeatChg.SelectedIndex)))

        '�������׃��X�g�̍쐬
        Call LS_SetOrderDetails(LC_NO_SEATID, LC_NO_ORDERNO)
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FCrossNavi�y���V�[�g�Ĉ󎚋@�\�z
    ' �@�@�\�T�v�F���ȑI���R���{�{�b�N�X�̕\������
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2014.1 �@�\�ڐA
    ' --------------------------------------------------------------------------------
    Private Sub LS_CmbSetup()
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow
        Dim lngCnt As Long

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        cbo_SeatChg.DropDownStyle = ComboBoxStyle.DropDownList

        '--------------------------------------------------------
        ' ���ȃ��X�g�擾 TCB�̓e�C�N�A�E�g�[���ׁ̈A�Ώۂ���O��
        '--------------------------------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM050.SEATID"
        strSQL = strSQL & "  FROM TPM050 left join TPD050 on TPM050.SEATID = TPD050.SEATID"
        strSQL = strSQL & " WHERE TPM050.TERMKIND IN ('TCA','TC0')"
        strSQL = strSQL & "   AND TPD050.M8 = '1'"

        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' ���j���[�I���R���{�ݒ�
        '------------------------------
        Try
            With cbo_SeatChg
                .Items.Clear()
                .Items.Add("�S��" & Space(100) & vbTab & LC_ALL_SELECT)

                lngCnt = 0

                While lngCnt < objData.Tables("com").Rows.Count
                    objRows = Nothing
                    If Not GF_GetRows(objData, lngCnt, objRows) Then
                        GoTo SYSTEM_ERROR
                    End If
                    .Items.Add(Trim(objRows("SEATID")) & Space(100) & vbTab & Trim(objRows("SEATID")))
                    lngCnt = lngCnt + 1
                End While
            End With
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_MenuCmbSetup")
    End Sub
    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FCrossNavi�y���V�[�g�Ĉ󎚋@�\�z
    ' �@�@�\�T�v�F�u�������ׁv���X�g�\��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2014.1 �@�\�ڐA
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetOrderDetails(ByVal pSEATID As String, ByVal pORDERNO As String)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow
        Dim lngCnt As Long
        Dim objItem As ListViewItem
        Dim strTime As String

        '------------------------------
        ' �����ݒ�
        '------------------------------
        lsv_OrderDetails.Clear()
        With lsv_OrderDetails
            .BeginUpdate()
            .Items.Clear()
            .Columns.Clear()

            .View = View.Details
            .FullRowSelect = True

            .Columns.Add("", 0, HorizontalAlignment.Center)
            .Columns.Add("���i��", 145, HorizontalAlignment.Center)
            .Columns.Add("����", 44, HorizontalAlignment.Center)
            .Columns.Add("��������", 85, HorizontalAlignment.Center)
            .Columns.Add("���z", 80, HorizontalAlignment.Center)
        End With

        '------------------------------
        ' �������׈ꗗ�擾
        '------------------------------
        If Not LF_GetOrderDetails(objData, pSEATID, pORDERNO) Then
            GoTo SYSTEM_ERROR
        End If

        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count
            objRows = Nothing
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                GoTo SYSTEM_ERROR
            End If

            strTime = Trim$(objRows("ORDERTIME")).Substring(8, 2) & ":" & Trim$(objRows("ORDERTIME")).Substring(10, 2)

            objItem = New ListViewItem()
            With objItem
                .Text = ""
                .SubItems.Add(Trim(objRows("GOODSNMJ")))
                .SubItems.Add(Trim(objRows("QUANTITY")))
                .SubItems.Add(strTime)
                If GF_GetAppInfo("SALES_TAX_SWITCHING") = "1" Then
                    .SubItems.Add(Format(CDbl(Trim(objRows("PRICE"))) * CInt(Trim(objRows("QUANTITY"))), "###,##0"))
                Else
                    .SubItems.Add(Format(CDbl(Trim(objRows("TAXPRICE"))) * CInt(Trim(objRows("QUANTITY"))), "###,##0"))
                End If
            End With

            lsv_OrderDetails.Items.Add(objItem)

            lngCnt = lngCnt + 1
        End While

        lsv_OrderDetails.EndUpdate()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetTermList")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FCrossNavi�y���V�[�g�Ĉ󎚋@�\�z
    ' �@�@�\�T�v�F�u�����ꗗ�v���X�g�\��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2014.1 �@�\�ڐA
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetOrderList(ByVal pSEATID As String)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow
        Dim lngCnt As Long
        Dim objItem As ListViewItem
        Dim strPrice As String
        Dim strTime As String

        '------------------------------
        ' �����ݒ�
        '------------------------------
        lsv_OrderList.Clear()
        With lsv_OrderList
            .BeginUpdate()
            .Items.Clear()
            .Columns.Clear()

            .View = View.Details
            .FullRowSelect = True

            .Columns.Add("", 0, HorizontalAlignment.Left)
            .Columns.Add("���Ȕԍ�", 90, HorizontalAlignment.Center)
            .Columns.Add("����No", 90, HorizontalAlignment.Center)
            .Columns.Add("��v����", 115, HorizontalAlignment.Center)
            .Columns.Add("���v���z", 115, HorizontalAlignment.Center)
        End With

        '------------------------------
        ' �[���@�ꗗ�擾
        '------------------------------
        If Not LF_GetTPD010(objData, pSEATID) Then
            GoTo SYSTEM_ERROR
        End If

        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count
            objRows = Nothing
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                GoTo SYSTEM_ERROR
            End If

            strPrice = LF_GetTotalPrice(Trim(objRows("SEATID")), objRows("ORDERNO"))
            strTime = Trim$(objRows("ORDERTIME")).Substring(8, 2) & ":" & Trim$(objRows("ORDERTIME")).Substring(10, 2)

            objItem = New ListViewItem()
            With objItem
                .Text = ""
                .SubItems.Add(Trim(objRows("SEATID")))
                .SubItems.Add(objRows("ORDERNO"))
                .SubItems.Add(strTime)
                .SubItems.Add(Format(CDbl(strPrice), "###,##0"))
            End With

            lsv_OrderList.Items.Add(objItem)

            lngCnt = lngCnt + 1
        End While

        lsv_OrderList.EndUpdate()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetTermList")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FCrossNavi�y���V�[�g�Ĉ󎚋@�\�z
    ' �@�@�\�T�v�F�u�����ꗗ���X�g�v�̕\�����ڎ擾
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2014.1 �@�\�ڐA
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPD010(ByRef pData As DataSet, ByVal pSEATID As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPD010 = False

        '------------------------------
        ' �r�p�k������
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPD010.SEATID,"
        strSQL = strSQL & "       TPD010.ORDERNO,"
        strSQL = strSQL & "       TPD010.ORDERTIME"
        strSQL = strSQL & "  FROM TPD010 left join TPD050 on TPD010.SEATID = TPD050.SEATID"
        strSQL = strSQL & " WHERE TPD010.GOODSCD = '" & Trim$(GF_GetAppInfo("REG_GOODSCD")) & "'"
        strSQL = strSQL & "   AND TPD050.M8 = '1'"
        If pSEATID <> LC_ALL_SELECT Then
            strSQL = strSQL & " AND TPD010.SEATID = '" & RSet(pSEATID, 5) & "'"
        End If
        strSQL = strSQL & " ORDER BY TPD010.SEATID, TPD010.ORDERNO"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        pData = objData
        LF_GetTPD010 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FCrossNavi�y���V�[�g�Ĉ󎚋@�\�z
    ' �@�@�\�T�v�F�u�������ׁv���X�g�̕\�����ڎ擾
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2014.1 �@�\�ڐA
    ' --------------------------------------------------------------------------------
    Private Function LF_GetOrderDetails(ByRef pData As DataSet, ByVal pSEATID As String, ByVal pORDERNO As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetOrderDetails = False

        '------------------------------
        ' �r�p�k������
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSNMJ4 AS GOODSNMJ,"
        strSQL = strSQL & "       TPD010.QUANTITY,"
        strSQL = strSQL & "       TPD010.ORDERTIME,"
        strSQL = strSQL & "       TPM010.PRICE,"
        strSQL = strSQL & "       TPM260.TAXPRICE"
        strSQL = strSQL & "  FROM TPD010,"
        strSQL = strSQL & "       TPM010,"
        strSQL = strSQL & "       TPM260"
        strSQL = strSQL & " WHERE TPD010.GOODSCD    = TPM010.GOODSCD"
        strSQL = strSQL & " AND   TPD010.GOODSCD    = TPM260.GOODSCD"
        strSQL = strSQL & " AND   TPD010.SEATID     = '" & RSet(pSEATID, 5) & "'"
        strSQL = strSQL & " AND   TPD010.ORDERNO    = " & pORDERNO
        strSQL = strSQL & " AND   TPD010.SELECTTIME <> '0'"
        strSQL = strSQL & " AND   TPD010.ORDERTIME <> '0'"
        strSQL = strSQL & " AND   TPD010.TRANSTIME <> '0'"
        strSQL = strSQL & " AND   TPD010.TRANSTIME <> '99999999999999'"
        strSQL = strSQL & " AND   TPD010.GOODSCD <> '" & Trim$(GF_GetAppInfo("REG_GOODSCD")) & "'"
        strSQL = strSQL & " AND   TPD010.GOODSCD <> '" & Trim$(GF_GetAppInfo("OPEN_GOODSCD")) & "'"
        strSQL = strSQL & " AND   TPD010.GOODSCD <> '" & Trim$(GF_GetAppInfo("CALL_GOODSCD")) & "'"
        strSQL = strSQL & " AND   TPD010.ORDERFLG <> 50"
        ' 2020-03-03
        If L_OMOTENASHI_DISH_fr <> L_OMOTENASHI_DISH_to Then
            strSQL &= " AND TPD010.GOODSCD >= '" & L_OMOTENASHI_DISH_fr & "' AND TPD010.GOODSCD <= '" & L_OMOTENASHI_DISH_to & "'"
        End If

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        pData = objData
        LF_GetOrderDetails = True


    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FCrossNavi�y���V�[�g�Ĉ󎚋@�\�z
    ' �@�@�\�T�v�F�����ꗗ��ʂ̕\�����ڎ擾
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2014.1 �@�\�ڐA
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTotalPrice(ByVal pSEATID As String, ByVal pORDERNO As String) As String

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim intCnt As Integer
        Dim intTotalPrice As Decimal

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTotalPrice = Nothing

        '------------------------------
        ' �r�p�k������
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.PRICE,"
        strSQL = strSQL & "       TPD010.QUANTITY"
        strSQL = strSQL & "  FROM TPD010,"
        strSQL = strSQL & "       TPM010"
        strSQL = strSQL & " WHERE TPD010.GOODSCD = TPM010.GOODSCD"
        strSQL = strSQL & " AND   TPD010.SEATID  = '" & RSet(pSEATID, 5) & "'"
        strSQL = strSQL & " AND   TPD010.ORDERNO = '" & pORDERNO & "'"
        strSQL = strSQL & " AND   TPD010.SELECTTIME <> 0"
        strSQL = strSQL & " AND   TPD010.ORDERTIME  <> 0"
        strSQL = strSQL & " AND   TPD010.TRANSTIME  <> 0"
        strSQL = strSQL & " AND   TPD010.TRANSTIME  <> 99999999999999"
        ' 2020-03-03
        If L_OMOTENASHI_DISH_fr <> L_OMOTENASHI_DISH_to Then
            strSQL &= " AND TPD010.GOODSCD >= '" & L_OMOTENASHI_DISH_fr & "' AND TPD010.GOODSCD <= '" & L_OMOTENASHI_DISH_to & "'"
        End If

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        intCnt = 0
        intTotalPrice = 0
        If objData.Tables("com").Rows.Count = 0 Then Exit Function ' ���o���ʂO�����́A�����s��Ȃ�
        While intCnt < CLng(objData.Tables("com").Rows.Count)

            If Not GF_GetRows(objData, intCnt, objRows) Then
                Exit Function
            End If

            intTotalPrice = intTotalPrice + Format(CDbl(Trim(objRows("PRICE"))) * CInt(Trim(objRows("QUANTITY"))))

            intCnt += 1
        End While

        If GF_GetAppInfo("SALES_TAX_SWITCHING") = "0" Then
            intTotalPrice = LF_GetTaxPrice(intTotalPrice)
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetTotalPrice = CStr(intTotalPrice)

    End Function

    Private Function LF_GetTaxPrice(ByVal pTotal As String) As Integer
        Dim Taxprice As Decimal      '�ō��݌v�Z����
        Dim price As Decimal         '�ō��݋��z
        Dim Taxprice_dec As String   '�ō��݌v�Z���ʏ����_���ʂ̒l

        '' ------------------------------
        '' �����l�ݒ�
        '' ------------------------------
        LF_GetTaxPrice = 0

        '�ō��݋��z�v�Z
        Taxprice = pTotal * (1 + (GF_GetAppInfo("SALES_TAX_RATE")) / 100)

        '�v�Z���ʂ̏������ʂ̒l���擾
        Taxprice_dec = Mid$((Taxprice - Fix(Taxprice)), 3, 1)

        'N��N+1������
        '�������ʂ̒l��0�̎�
        If Taxprice_dec = Nothing Then
            pTotal = Format$(CLng(Trim$(Taxprice)), "###,##0")
        Else

            If Taxprice_dec > Trim$(GF_GetAppInfo("TAX_ROUND_OFF")) Then
                '�������ʂ̒l��N���傫����
                price = Math.Ceiling(Taxprice)
            Else
                '�������ʂ̒l��N�ȉ��̎�
                price = Math.Truncate(Taxprice)
            End If
            pTotal = Format$(CLng(Trim$(price)), "###,##0")
        End If

        LF_GetTaxPrice = pTotal

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FCrossNavi�y���V�[�g�Ĉ󎚋@�\�z
    ' �@�@�\�T�v�F�������׉�ʕ\���@�����ꗗ��ʂ̃C���f�b�N�X�ύX���ɌĂяo�����
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2014.1 �@�\�ڐA
    ' --------------------------------------------------------------------------------
    Private Sub lsv_OrderList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_OrderList.SelectedIndexChanged


        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim strSeatNo As String
        Dim strOrderNo As String

        '------------------------------
        ' �I�����ڎ擾
        '------------------------------
        objCollection = lsv_OrderList.SelectedItems
        With objCollection

            If .Count = 0 Then
                Exit Sub
            End If

            '------------------------------
            ' �K�C�_���X���ҏW�̈�֓]�L
            '------------------------------
            strSeatNo = .Item(0).SubItems.Item(1).Text
            strOrderNo = .Item(0).SubItems.Item(2).Text

            '------------------------------
            ' �O�o�^�ς݃R�����g�I�v�V�����ꗗ����
            '------------------------------
            Call LS_SetOrderDetails(strSeatNo, strOrderNo)

        End With

    End Sub

    ' 2017.10.01 �{���z�M �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�{��SV���t�H���_�`�F�b�N
    ' �@�@�\�T�v�F�{��SV���ɔz�M���j���[�t�H���_�����݂��Ă��邩�`�F�b�N
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.10.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_ChkFolder(ByRef pstrDate As String) As Boolean

        Dim strPath As String = ""
        Dim strDirNm As String = ""
        Dim strDate As String = ""
        Dim strDirDate As String = ""

        LF_ChkFolder = False

        strPath = GF_GetAppInfo("DELI_SV_IP") & "/CrossiAid/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/" & GF_GetAppInfo("DELI_SHOPCD") & "/"

        'strDirNm = System.IO.Directory.GetDirectories(strPath, "*", IO.SearchOption.TopDirectoryOnly)

        ' 1%
        targetPrgBar.Value = 10
        targetPrgLabel.Text = "Getting filepath " + strPath
        Call LF_GetDeliDir(strPath, strDirNm)

        strDate = Format(Now, "yyyyMMddHHmm")

        If strDirNm <> "" Then
            strDirDate = strDirNm.Substring(strDirNm.LastIndexOf("_") + 1, 12) 'Gert 03/01 LS_Right(strDirNm, 12)

            If (strDate >= strDirDate) Then
                pstrDate = strDirNm.Substring(strDirNm.LastIndexOf("_") - 9, 22) 'Gert 08/06 LS_Right(strDirNm, 24)
                LF_ChkFolder = True
            End If
        End If

        ' 2%
        targetPrgBar.Value = 20

    End Function

    Private Function LF_ChkOMOTENASHIFolder(ByRef pTargetDir As String) As Boolean

        Dim strPath As String = ""
        Dim strDirNm As String = ""
        Dim strDate As String = ""
        Dim strDirDate As String = ""

        LF_ChkOMOTENASHIFolder = False

        strPath = GF_GetAppInfo("DELI_SV_IP") & "/OMOTENASHI/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/" & GF_GetAppInfo("DELI_SHOPCD") & "/"

        'strDirNm = System.IO.Directory.GetDirectories(strPath, "*", IO.SearchOption.TopDirectoryOnly)

        ' 1%
        targetPrgBar.Value = 10
        targetPrgLabel.Text = "Getting filepath " + strPath
        Call LF_GetDeliDir(strPath, strDirNm)

        strDate = Format(Now, "yyyyMMddHHmm")

        If strDirNm <> "" Then
            'strDirDate = strDirNm.Substring(strDirNm.LastIndexOf("_") + 1, 12) 'Gert 03/01 LS_Right(strDirNm, 12)
            strDirDate = strDirNm.Substring(strDirNm.LastIndexOf(" ") + 1, 12)

            If (strDate >= strDirDate) Then
                'pstrDate = strDirNm.Substring(strDirNm.LastIndexOf("_") - 24, 37) 'Gert 08/06 LS_Right(strDirNm, 24)
                pTargetDir = strDirNm.Substring(strDirNm.LastIndexOf(" ") + 1, 47)
                LF_ChkOMOTENASHIFolder = True
            End If
        End If

        ' 2%
        targetPrgBar.Value = 20

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�X��SV �������j���[�o�b�N�A�b�v
    ' �@�@�\�T�v�F�z�M���j���[�捞�O�Ɋ������j���[�̃o�b�N�A�b�v��Ƃ��s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.10.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_MenuBackUp() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objInfo As typConnectionInfo = Nothing

        LF_MenuBackUp = False

        With objInfo
            .strSVNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer Name"))
            .strDBNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer DBName"))
            .strUserNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer UserID"))
            .strPasswd = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer PassWD"))
        End With

        '------------------------------
        ' �f�B���N�g�����݃`�F�b�N
        '------------------------------
        If System.IO.Directory.Exists("C:\CrossNavi\backup") = False Then
            ' �����o��
            Exit Function
        End If

        If Len("C:\CrossNavi\backup") <> 0 Then

            '------------------------------
            ' �f�[�^�G�N�X�|�[�g
            '------------------------------
            If LS_Deli_DataExport(objInfo) Then
                LF_MenuBackUp = True
            End If

        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�f�[�^�G�N�X�|�[�g����
    ' �@�@�\�T�v�F�������j���[�̃o�b�N�A�b�v�������s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.10.01 �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    Private Function LS_Deli_DataExport(ByVal pInfo As typConnectionInfo) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strExpPath As String

        LS_Deli_DataExport = False

        Try
            With pInfo
                .strAdvPath = Trim$(GF_GetAppInfo("ADV_PATH"))
                .strItemPath = Trim$(GF_GetAppInfo("ITEM_PATH"))
                .strGrpPath = Trim$(GF_GetAppInfo("GROUP_PATH"))
                .strMenuGrpPath = Trim$(GF_GetAppInfo("MENUIMG_V"))
                .strStoreMkPath = Trim$(GF_GetAppInfo("STOREMARK_V"))

                ' �R�s�[���p�X�擾
                strExpPath = "C:\CrossNavi\backup"
            End With

            '------------------------------
            ' �G�N�X�|�[�g�p�X����
            '------------------------------

            strExpPath = strExpPath & "\BackUpData(" & Format$(Now, "yyyyMMddHHmmss") & ")"
            System.IO.Directory.CreateDirectory(strExpPath)
            targetPrgLabel.Text = "�t�H���_�쐬�F" + strExpPath
            ' 5%
            targetPrgBar.Value = 51

            '------------------------------
            ' BCP�G�N�X�|�[�g
            '------------------------------
            If Not LF_DeliTableBackup(strExpPath & "\TableData", pInfo) Then
                Exit Function
            End If

            ' 5%
            targetPrgBar.Value = 52

            '------------------------------
            ' �摜�t�@�C���R�s�[
            '------------------------------
            If Not LF_Deli_ImageBackup(strExpPath & "\ImageData", pInfo) Then
                Exit Function
            End If

            '------------------------------
            ' �C���|�[�g�p�o�b�`�t�@�C������
            '------------------------------
            If Not LF_CreateRestoreBatch(strExpPath, pInfo) Then
                Exit Function
            End If

            LS_Deli_DataExport = True

        Catch
            Exit Function
        End Try

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�z�M���j���[�捞����
    ' �@�@�\�T�v�F�z�M���j���[��{��SV������R�s�[����
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.10.01 �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    Private Function LS_Deli_Import(ByVal pstrDate As String) As Boolean

        Dim strSVPath As String = ""
        Dim strSVFullPath As String = ""
        Dim strCLPath As String = ""
        Dim strAfterSVFullPath As String = ""
        Dim objInfo As typConnectionInfo = Nothing
        Dim strFolderName As String = ""
        Dim strDeliFlgPath As String = ""
        Dim strDeliFlgLimiPath As String = ""
        'Dim strDeliFlgAfterPath As String = ""
        ' 2022-02-02
        Dim strFTPServer As String = ""
        Dim strShopDirectory As String = ""
        Dim strTargetPath As String = ""
        Dim strDelivaryflgDir As String = ""
        Dim strDeliFlgBeforeName As String = ""
        Dim strDeliFlgAfterName As String = ""

        LS_Deli_Import = False

        ' �{��SV�̓X�ܔz�M�t�H���_�ւ̃p�X
        strSVPath = GF_GetAppInfo("DELI_SV_IP") & "/CrossiAid/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/" & GF_GetAppInfo("DELI_SHOPCD")
        strFTPServer = GF_GetAppInfo("DELI_SV_IP")
        strShopDirectory = "/CrossiAid/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/" & GF_GetAppInfo("DELI_SHOPCD")

        ' �{��SV�̔z�M���j���[�t�H���_���擾
        'strSVFullPath = strSVPath & "/" & GF_GetAppInfo("DELI_COMPANYCD") & "_" & GF_GetAppInfo("DELI_GYOTAICD") & "_" & GF_GetAppInfo("DELI_SHOPCD") & "_" & pstrDate
        strSVFullPath = strSVPath & "/" & GF_GetAppInfo("DELI_COMPANYCD") & "_" & GF_GetAppInfo("DELI_GYOTAICD") & "_" & pstrDate

        ' CL���̔z�M���j���[�R�s�[��p�X
        strCLPath = GF_GetAppInfo("DELI_MENU_PATH") & "/BackUpData(" & Format(Now, "yyyyMMddHHmmss") & ")"

        ' ���j���[�z�M�t�H���_�̔z�M���擾
        strFolderName = LS_Right(strSVFullPath, 32).Replace(Environment.NewLine, "") 'Gert 08/06
        targetPrgLabel.Text = "�C���|�[�g�F" + strFolderName

        ' 2022-02-02
        ' �{��SV����delivaryflg�ւ̃p�X(���������O)
        'strDeliFlgPath = GF_GetAppInfo("DELI_SV_IP") & "/CrossiAid/delivaryflg/" & strFolderName & "_0.txt"
        ' �{��SV����delivaryflg�ւ̃p�X(���������O)
        'strDeliFlgLimiPath = GF_GetAppInfo("DELI_SV_IP") & "/CrossiAid/delivaryflg/" & strFolderName & "_5.txt"
        strDelivaryflgDir = "/CrossiAid/delivaryflg"

        strDeliFlgBeforeName = strFolderName & "_0.txt"
        If LF_ChkExistFTP(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName) Then

            ' �{��SV����delivaryflg�ւ̃p�X(����������)
            strDeliFlgAfterName = strFolderName & "_1.txt"

            ' delivaryflg��������
            If Not LF_Writeflg(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName, strDeliFlgAfterName) Then
                Exit Function
            End If

            strSVFullPath = strSVFullPath.Replace(Environment.NewLine, "")

            ' �z�M���j���[�R�s�[
            ' ImageData�t�H���_�쐬
            Call System.IO.Directory.CreateDirectory(strCLPath & "/ImageData")
            ' ImageData�t�@�C���_�E�����[�h
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/AdvImage", strCLPath, "/ImageData/AdvImage")
            ' AdvImage�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/AdvImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/GroupImage", strCLPath, "/ImageData/GroupImage")
            ' GroupImage�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/GroupImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/ItemImage", strCLPath, "/ImageData/ItemImage")
            ' ItemImage�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/ItemImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/FreeMenuImage", strCLPath, "/ImageData/FreeMenuImage")
            ' FreeMenuImage�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/FreeMenuImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/MenuImage", strCLPath, "/ImageData/MenuImage")
            ' MenuImage�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/MenuImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/StoreMark", strCLPath, "/ImageData/StoreMark")
            ' StoreMark�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/StoreMark")
            ' ImageData�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData")
            ' TableData�t�H���_�쐬
            Call System.IO.Directory.CreateDirectory(strCLPath & "/TableData")
            ' TableData�t�@�C���_�E�����[�h
            Call LS_CopyDirectoryFTP(strSVFullPath & "/TableData", strCLPath, "/TableData")
            ' TableData�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/TableData")
            ' ���j���[�f�[�^�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath)

            With objInfo
                .strSVNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer Name"))
                .strDBNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer DBName"))
                .strUserNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer UserID"))
                .strPasswd = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer PassWD"))
            End With

            ' �f�B���N�g�����݃`�F�b�N
            If System.IO.Directory.Exists(strCLPath) = False Then
                ' �����o��
                Exit Function
            End If

            If Len(strCLPath) <> 0 Then

                ' �f�[�^�C���|�[�g
                If Not LS_Deli_DataInport(objInfo, strCLPath) Then
                    Exit Function
                End If

            End If

        Else
            strDeliFlgBeforeName = strFolderName & "_5.txt"
            If LF_ChkExistFTP(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName) Then

                ' �{��SV����delivaryflg�ւ̃p�X(����������)
                strDeliFlgAfterName = strFolderName & "_1.txt"

                ' delivaryflg��������
                If Not LF_Writeflg(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName, strDeliFlgAfterName) Then
                    Exit Function
                End If

                strSVFullPath = strSVFullPath.Replace(Environment.NewLine, "")

                ' �z�M���j���[�R�s�[
                ' ImageData�t�H���_�쐬
                Call System.IO.Directory.CreateDirectory(strCLPath & "/ImageData")
                ' ImageData�t�@�C���_�E�����[�h
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/AdvImage", strCLPath, "/ImageData/AdvImage") 'Gert 10/12
                ' AdvImage�f�B���N�g���폜
                Call LF_DeleteDirectoryContentsFTP(strSVFullPath & "/ImageData/AdvImage")
                Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/AdvImage")
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/GroupImage", strCLPath, "/ImageData/GroupImage") 'Gert 10/12
                ' GroupImage�f�B���N�g���폜
                Call LF_DeleteDirectoryContentsFTP(strSVFullPath & "/ImageData/GroupImage")
                Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/GroupImage")
                Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/ItemImage", strCLPath, "/ImageData/ItemImage")
                ' ItemImage�f�B���N�g���폜
                Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/ItemImage")
                Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/FreeMenuImage", strCLPath, "/ImageData/FreeMenuImage")
                ' FreeMenuImage�f�B���N�g���폜
                Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/FreeMenuImage")
                Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/MenuImage", strCLPath, "/ImageData/MenuImage")
                ' MenuImage�f�B���N�g���폜
                Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/MenuImage")
                Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/StoreMark", strCLPath, "/ImageData/StoreMark")
                ' StoreMark�f�B���N�g���폜
                Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/StoreMark")
                ' ImageData�f�B���N�g���폜
                Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData")
                ' TableData�t�H���_�쐬
                Call System.IO.Directory.CreateDirectory(strCLPath & "/TableData")
                ' TableData�t�@�C���_�E�����[�h
                Call LS_CopyDirectoryFTP(strSVFullPath & "/TableData", strCLPath, "/TableData")
                ' TableData�f�B���N�g���폜
                Call LF_DeleteDirectoryFTP(strSVFullPath & "/TableData")
                ' ���j���[�f�[�^�f�B���N�g���폜
                Call LF_DeleteDirectoryFTP(strSVFullPath)

                ' 50%
                targetPrgBar.Value = 500

                With objInfo
                    .strSVNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer Name"))
                    .strDBNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer DBName"))
                    .strUserNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer UserID"))
                    .strPasswd = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer PassWD"))
                End With

                ' �f�B���N�g�����݃`�F�b�N
                If System.IO.Directory.Exists(strCLPath) = False Then
                    ' �����o��
                    Exit Function
                End If

                If Len(strCLPath) <> 0 Then

                    ' �f�[�^�C���|�[�g(����z�M)
                    If Not LS_Deli_DataInportLimited(objInfo, strCLPath) Then
                        Exit Function
                    End If

                End If

            Else
                Exit Function
            End If
        End If

        ' 93%
        targetPrgBar.Value = 930

        ' �{��SV����delivaryflg�ւ̃p�X(���������O)
        'strDeliFlgPath = GF_GetAppInfo("DELI_SV_IP") & "/CrossiAid/delivaryflg/" & strFolderName & "_1.txt"
        strDeliFlgBeforeName = strFolderName & "_1.txt"

        ' �{��SV����delivaryflg�ւ̃p�X(����������)
        strDeliFlgAfterName = strFolderName & "_2.txt"

        ' delivaryflg��������
        If Not LF_Writeflg(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName, strDeliFlgAfterName) Then
            Exit Function
        End If

        ' 94%
        targetPrgBar.Value = 940
        targetPrgLabel.Text = "�X�܃t�H���_���폜����F" + strCLPath

        ' �X��CL���z�M���j���[�t�H���_�폜
        System.IO.Directory.Delete(strCLPath, True)

        ' �{��SV���z�M���j���[�t�H���_�폜
        If Not LF_DeleteFolderSV(strSVFullPath) Then
            Exit Function
        End If

        ' 95%
        targetPrgBar.Value = 950

        LS_Deli_Import = True

    End Function

    Private Function LS_OMOTENASHI_Import(ByVal pTargetDir As String) As Boolean

        Dim strSVPath As String = ""
        Dim strSVFullPath As String = ""
        Dim strCLPath As String = ""
        Dim strAfterSVFullPath As String = ""
        Dim objInfo As typConnectionInfo = Nothing
        Dim strFolderName As String = ""
        Dim strDeliFlgPath As String = ""
        Dim strDeliFlgLimiPath As String = ""
        'Dim strDeliFlgAfterPath As String = ""
        ' 2022-02-02
        Dim strFTPServer As String = ""
        Dim strShopDirectory As String = ""
        Dim strTargetPath As String = ""
        Dim strDelivaryflgDir As String = ""
        Dim strDeliFlgBeforeName As String = ""
        Dim strDeliFlgAfterName As String = ""

        LS_OMOTENASHI_Import = False

        ' �{��SV�̓X�ܔz�M�t�H���_�ւ̃p�X
        strSVPath = GF_GetAppInfo("DELI_SV_IP") & "/OMOTENASHI/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/" & GF_GetAppInfo("DELI_SHOPCD")
        strFTPServer = GF_GetAppInfo("DELI_SV_IP")
        strShopDirectory = "/OMOTENASHI/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/" & GF_GetAppInfo("DELI_SHOPCD")

        ' �{��SV�̔z�M���j���[�t�H���_���擾
        'strSVFullPath = strSVPath & "/" & GF_GetAppInfo("DELI_COMPANYCD") & "_" & GF_GetAppInfo("DELI_GYOTAICD") & "_" & GF_GetAppInfo("DELI_SHOPCD") & "_" & pstrDate
        'strSVFullPath = strSVPath & "/" & GF_GetAppInfo("DELI_COMPANYCD") & "_" & GF_GetAppInfo("DELI_GYOTAICD") & "_" & pstrDate
        strSVFullPath = strSVPath & "/" & pTargetDir

        ' CL���̔z�M���j���[�R�s�[��p�X
        'strCLPath = GF_GetAppInfo("DELI_MENU_PATH") & "/BackUpData(" & Format(Now, "yyyyMMddHHmmss") & ")"
        strCLPath = GF_GetAppInfo("DELI_MENU_PATH") & "\O" & LS_Right(pTargetDir, 12) & "(" & Format(Now, "yyyyMMddHHmmss") & ")"

        ' ���j���[�z�M�t�H���_�̔z�M���擾
        strFolderName = LS_Right(strSVFullPath, 47).Replace(Environment.NewLine, "") 'Gert 08/06
        targetPrgLabel.Text = "�C���|�[�g�F" + strFolderName

        ' 2022-02-02
        ' �{��SV����delivaryflg�ւ̃p�X(���������O)
        'strDeliFlgPath = GF_GetAppInfo("DELI_SV_IP") & "/CrossiAid/delivaryflg/" & strFolderName & "_0.txt"
        ' �{��SV����delivaryflg�ւ̃p�X(���������O)
        'strDeliFlgLimiPath = GF_GetAppInfo("DELI_SV_IP") & "/CrossiAid/delivaryflg/" & strFolderName & "_5.txt"
        strDelivaryflgDir = "/OMOTENASHI/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/delivaryflg"

        strDeliFlgBeforeName = strFolderName & "_0.txt"
        If LF_ChkExistFTP(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName) Then

            ' �{��SV����delivaryflg�ւ̃p�X(����������)
            strDeliFlgAfterName = strFolderName & "_1.txt"

            ' delivaryflg��������
            If Not LF_Writeflg(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName, strDeliFlgAfterName) Then
                Exit Function
            End If

            strSVFullPath = strSVFullPath.Replace(Environment.NewLine, "")

            ' �z�M���j���[�R�s�[
            ' ImageData�t�H���_�쐬
            Call System.IO.Directory.CreateDirectory(strCLPath & "/ImageData")
            ' ImageData�t�@�C���_�E�����[�h
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/AdvImage", strCLPath, "/ImageData/AdvImage")
            ' AdvImage�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/AdvImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/GroupImage", strCLPath, "/ImageData/GroupImage")
            ' GroupImage�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/GroupImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/ItemImage", strCLPath, "/ImageData/ItemImage")
            ' ItemImage�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/ItemImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/FreeMenuImage", strCLPath, "/ImageData/FreeMenuImage")
            ' FreeMenuImage�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/FreeMenuImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/MenuImage", strCLPath, "/ImageData/MenuImage")
            ' MenuImage�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/MenuImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/StoreMark", strCLPath, "/ImageData/StoreMark")
            ' StoreMark�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/StoreMark")

            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/MenuPage", strCLPath, "/ImageData/MenuPage")
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/MenuPage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/MenuThumbnail", strCLPath, "/ImageData/MenuThumbnail")
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/MenuThumbnail")

            ' ImageData�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData")
            ' TableData�t�H���_�쐬
            Call System.IO.Directory.CreateDirectory(strCLPath & "/TableData")
            ' TableData�t�@�C���_�E�����[�h
            Call LS_CopyDirectoryFTP(strSVFullPath & "/TableData", strCLPath, "/TableData")
            ' TableData�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/TableData")
            ' ���j���[�f�[�^�f�B���N�g���폜
            Call LF_DeleteDirectoryFTP(strSVFullPath)

            With objInfo
                .strSVNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer Name"))
                .strDBNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer DBName"))
                .strUserNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer UserID"))
                .strPasswd = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer PassWD"))
            End With

            ' �f�B���N�g�����݃`�F�b�N
            If System.IO.Directory.Exists(strCLPath) = False Then
                ' �����o��
                Exit Function
            End If

            If Len(strCLPath) <> 0 Then

                ' 2022-03-29-
                ' �f�[�^�C���|�[�g
                If Not LS_OMOTENASHI_DataInport(objInfo, strCLPath) Then
                    Exit Function
                End If

            End If

        Else
            strDeliFlgBeforeName = strFolderName & "_5.txt"
            If LF_ChkExistFTP(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName) Then
                ' �{��SV����delivaryflg�ւ̃p�X(����������)
                'strDeliFlgAfterName = strFolderName & "_1.txt"
                ' delivaryflg��������
                'If Not LF_Writeflg(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName, strDeliFlgAfterName) Then
                '    Exit Function
                'End If
                'strSVFullPath = strSVFullPath.Replace(Environment.NewLine, "")
                ' �z�M���j���[�R�s�[
                ' ImageData�t�H���_�쐬
                'Call System.IO.Directory.CreateDirectory(strCLPath & "/ImageData")
                ' ImageData�t�@�C���_�E�����[�h
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/AdvImage", strCLPath, "/ImageData/AdvImage") 'Gert 10/12
                ' AdvImage�f�B���N�g���폜
                'Call LF_DeleteDirectoryContentsFTP(strSVFullPath & "/ImageData/AdvImage")
                'Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/AdvImage")
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/GroupImage", strCLPath, "/ImageData/GroupImage") 'Gert 10/12
                ' GroupImage�f�B���N�g���폜
                'Call LF_DeleteDirectoryContentsFTP(strSVFullPath & "/ImageData/GroupImage")
                'Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/GroupImage")
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/ItemImage", strCLPath, "/ImageData/ItemImage")
                ' ItemImage�f�B���N�g���폜
                'Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/ItemImage")
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/FreeMenuImage", strCLPath, "/ImageData/FreeMenuImage")
                ' FreeMenuImage�f�B���N�g���폜
                'Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/FreeMenuImage")
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/MenuImage", strCLPath, "/ImageData/MenuImage")
                ' MenuImage�f�B���N�g���폜
                'Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/MenuImage")
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/StoreMark", strCLPath, "/ImageData/StoreMark")
                ' StoreMark�f�B���N�g���폜
                'Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/StoreMark")
                ' ImageData�f�B���N�g���폜
                'Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData")
                ' TableData�t�H���_�쐬
                'Call System.IO.Directory.CreateDirectory(strCLPath & "/TableData")
                ' TableData�t�@�C���_�E�����[�h
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/TableData", strCLPath, "/TableData")
                ' TableData�f�B���N�g���폜
                'Call LF_DeleteDirectoryFTP(strSVFullPath & "/TableData")
                ' ���j���[�f�[�^�f�B���N�g���폜
                'Call LF_DeleteDirectoryFTP(strSVFullPath)
                ' 50%
                'prg_Bar.Value = 500
                'With objInfo
                '    .strSVNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer Name"))
                '    .strDBNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer DBName"))
                '    .strUserNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer UserID"))
                '    .strPasswd = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer PassWD"))
                'End With
                ' �f�B���N�g�����݃`�F�b�N
                'If System.IO.Directory.Exists(strCLPath) = False Then
                '    ' �����o��
                '    Exit Function
                'End If
                'If Len(strCLPath) <> 0 Then
                '    ' �f�[�^�C���|�[�g(����z�M)
                '    If Not LS_Deli_DataInportLimited(objInfo, strCLPath) Then
                '        Exit Function
                '    End If
                'End If
            Else
                Exit Function
            End If
        End If

        ' 93%
        targetPrgBar.Value = 930

        ' �{��SV����delivaryflg�ւ̃p�X(���������O)
        'strDeliFlgPath = GF_GetAppInfo("DELI_SV_IP") & "/CrossiAid/delivaryflg/" & strFolderName & "_1.txt"
        strDeliFlgBeforeName = strFolderName & "_1.txt"

        ' �{��SV����delivaryflg�ւ̃p�X(����������)
        strDeliFlgAfterName = strFolderName & "_2.txt"

        ' delivaryflg��������
        If Not LF_Writeflg(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName, strDeliFlgAfterName) Then
            Exit Function
        End If

        ' 94%
        targetPrgBar.Value = 940
        targetPrgLabel.Text = "�X�܃t�H���_���폜����F" + strCLPath

        ' �X��CL���z�M���j���[�t�H���_�폜
        System.IO.Directory.Delete(strCLPath, True)

        ' �{��SV���z�M���j���[�t�H���_�폜
        If Not LF_DeleteFolderSV(strSVFullPath) Then
            Exit Function
        End If

        ' 95%
        targetPrgBar.Value = 950

        LS_OMOTENASHI_Import = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�o�b�N�A�b�v���j���[�捞����
    ' �@�@�\�T�v�F�o�b�N�A�b�v���烁�j���[�f�[�^����荞��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.10.01 �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    Private Function LS_Backup_Import() As Boolean

        Dim strPath As String = ""
        Dim objInfo As typConnectionInfo = Nothing

        LS_Backup_Import = False

        With objInfo
            .strSVNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer Name"))
            .strDBNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer DBName"))
            .strUserNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer UserID"))
            .strPasswd = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer PassWD"))
        End With

        strPath = lbl_Path.Text

        ' �f�B���N�g�����݃`�F�b�N
        If System.IO.Directory.Exists(strPath) = False Then
            ' �����o��
            Exit Function
        End If

        If Len(strPath) <> 0 Then

            ' �f�[�^�C���|�[�g
            If Not LS_Backup_DataInport(objInfo, strPath) Then
                Exit Function
            End If

        End If

        LS_Backup_Import = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�f�B���N�g���R�s�[����
    ' �@�@�\�T�v�F�z�M���j���[��{��SV������R�s�[����
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.10.01 �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    Private Sub LS_CopyDirectory(ByVal sourceDirName As String, ByVal destDirName As String)

        ''�R�s�[��̃f�B���N�g�����Ȃ��Ƃ��͍��
        If Not System.IO.Directory.Exists(destDirName) Then
            System.IO.Directory.CreateDirectory(destDirName)
            '�������R�s�[
            System.IO.File.SetAttributes(destDirName, System.IO.File.GetAttributes(sourceDirName))
        End If

        '�R�s�[��̃f�B���N�g�����̖�����"\"������
        If destDirName.Chars((destDirName.Length - 1)) <> System.IO.Path.DirectorySeparatorChar Then
            destDirName = destDirName + System.IO.Path.DirectorySeparatorChar
        End If

        '�R�s�[���̃f�B���N�g���ɂ���t�@�C�����R�s�[
        Dim fs As String() = System.IO.Directory.GetFiles(sourceDirName)
        Dim f As String

        For Each f In fs
            System.IO.File.Copy(f, destDirName + System.IO.Path.GetFileName(f), True)
        Next

        '�R�s�[���̃f�B���N�g���ɂ���f�B���N�g�����R�s�[
        Dim dirs As String() = System.IO.Directory.GetDirectories(sourceDirName)
        Dim dir As String

        For Each dir In dirs
            LS_CopyDirectory(dir, destDirName + System.IO.Path.GetFileName(dir))
        Next
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�f�B���N�g���R�s�[����
    ' �@�@�\�T�v�F�z�M���j���[��{��SV������R�s�[����
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2018.01.11 �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    Private Sub LS_CopyDirectoryFTP(ByVal pPath As String, ByVal pDirNM As String, ByVal pNM As String)

        Dim strSVFile As String = ""
        Dim strLocalFile As String = ""
        Dim strFileErrorMessage As String = ""
        Dim e As ExecutionEngineException


        Try

            System.IO.Directory.CreateDirectory(pDirNM & pNM)

            '�t�@�C���ꗗ���擾����f�B���N�g����URI
            Dim u As New Uri("ftp://" & pPath & "/")

            'FtpWebRequest�̍쐬
            Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(u), System.Net.FtpWebRequest)
            '���O�C�����[�U�[���ƃp�X���[�h��ݒ�
            'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
            Dim strFTPId As String = "ftp"
            Dim strFTPPass As String = ""
            getFTPUserPass(strFTPId, strFTPPass)
            ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)
            'Method��WebRequestMethods.Ftp.ListDirectoryDetails("LIST")��ݒ�
            ftpReq.Method = System.Net.WebRequestMethods.Ftp.ListDirectory
            '�v���̊�����ɐڑ������
            ftpReq.KeepAlive = False
            ' 2019-11-06 -------------------------------------------------------------------------------
            If System.Configuration.ConfigurationManager.AppSettings("FTPUploadPassiveMode") = "0" Then
                'PASSIVE���[�h�𖳌��ɂ���
                ftpReq.UsePassive = False
            Else
                ftpReq.UsePassive = True
            End If
            ' ------------------------------------------------------------------------------------------
            'FtpWebResponse���擾
            Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
            'FTP�T�[�o�[���瑗�M���ꂽ�f�[�^���擾
            Dim sr As New System.IO.StreamReader(ftpRes.GetResponseStream()) '"Shift-JIS" 'Gert 04/01
            Dim res As String = sr.ReadToEnd()

            sr.Close()
            '����
            ftpRes.Close()

            If res.Count = 0 Then
                Exit Sub
            End If

            Dim strFileNM As String() = res.Split(Environment.NewLine)

            ''WebClient�I�u�W�F�N�g���쐬
            'Dim wc As New System.Net.WebClient()
            ''���O�C�����[�U�[���ƃp�X���[�h���w��
            'wc.Credentials = New System.Net.NetworkCredential("ftp", "")

            For i As Integer = 0 To strFileNM.Count - 2
                targetPrgLabel.Text = "�t�@�C����荞�ށF" + strFileNM(i)
                ' 0.1%������
                If targetPrgBar.Value = 899 Then
                    targetPrgBar.Value = 899
                Else
                    targetPrgBar.Value = targetPrgBar.Value + 1
                End If

                If i > 0 Then
                    strFileNM(i) = strFileNM(i).TrimStart
                End If

                strSVFile = pPath & "/" & Trim$(strFileNM(i))
                strLocalFile = pDirNM & pNM & "/" & Trim$(strFileNM(i))

                'FTP�T�[�o�[����_�E�����[�h����
                'wc.DownloadFile("ftp://" & strSVFile, strLocalFile)
                If Not LF_TransFileDataFTP(strSVFile, strLocalFile) = "" Then 'Gert 04/01
                    If Not LF_TransFileDataFTP(strSVFile, strLocalFile) = "" Then 'Gert 10/01 3��retry
                        strFileErrorMessage = LF_TransFileDataFTP(strSVFile, strLocalFile)
                        If Not strFileErrorMessage = "" Then
                            GS_ErrorTerm(strFileErrorMessage)
                            Exit Sub
                        End If
                    End If

                End If

                ' FTP�T�[�o�̃t�@�C���폜
                If Not LF_DeleteFileFTP(strSVFile) Then 'Gert 10/01 3��retry
                    If Not LF_DeleteFileFTP(strSVFile) Then
                        If Not LF_DeleteFileFTP(strSVFile) Then
                            Exit Sub
                        End If
                    End If
                End If


            Next

            '�������
            'wc.Dispose()

        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�f�[�^�_�E�����[�h����(FTP����)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.12.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_TransFileDataFTP(ByVal pFilename As String, ByVal pdirNM As String) As String

        Dim downFile As String = ""
        Dim strFileNM As String = pFilename
        Dim strFTPurl As String = ""

        pFilename = pFilename.Replace("\", "/")
        strFileNM = strFileNM.Replace("\", "/")

        Dim upUrl As New Uri("ftp://" & strFileNM)

        Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(upUrl), System.Net.FtpWebRequest)

        Try
            downFile = pdirNM

            LF_TransFileDataFTP = "FTP�ڑ��G���["

            'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
            Dim strFTPId As String = "ftp"
            Dim strFTPPass As String = ""
            getFTPUserPass(strFTPId, strFTPPass)
            ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)

            ftpReq.Method = System.Net.WebRequestMethods.Ftp.DownloadFile

            ftpReq.KeepAlive = False

            ftpReq.UseBinary = False
            ' 2019-11-06 -------------------------------------------------------------------------------
            If System.Configuration.ConfigurationManager.AppSettings("FTPUploadPassiveMode") = "0" Then
                ftpReq.UsePassive = False
            Else
                ftpReq.UsePassive = True
            End If
            ' ------------------------------------------------------------------------------------------
            'FtpWebResponse���擾
            Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
            '�t�@�C�����_�E�����[�h���邽�߂�Stream���擾
            Dim resStrm As System.IO.Stream = ftpRes.GetResponseStream()
            '�_�E�����[�h�����t�@�C�����������ނ��߂�FileStream���쐬
            Dim fs As New System.IO.FileStream(downFile, System.IO.FileMode.Create, System.IO.FileAccess.Write)
            '�_�E�����[�h�����f�[�^����������
            Dim buffer(1023) As Byte
            While True
                Dim readSize As Integer = resStrm.Read(buffer, 0, buffer.Length)
                If readSize = 0 Then
                    Exit While
                End If
                fs.Write(buffer, 0, readSize)
            End While
            fs.Close()
            resStrm.Close()

            '����
            ftpRes.Close()

            LF_TransFileDataFTP = ""

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Function

SYSTEM_ERROR:
        'Call GS_ErrorTerm("FTP�t�@�C���ʐM�G���[�F" & strFileNM)
        LF_TransFileDataFTP = pFilename
    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FFTP�t�@�C���f�[�^�폜����(FTP����)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2018.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_DeleteFileFTP(ByVal pdir As String) As Boolean

        LF_DeleteFileFTP = False

        '�폜����t�@�C����URI
        Dim u As New Uri("ftp://" & pdir)

        'FtpWebRequest�̍쐬
        Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(u), System.Net.FtpWebRequest)
        '���O�C�����[�U�[���ƃp�X���[�h��ݒ�
        'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
        Dim strFTPId As String = "ftp"
        Dim strFTPPass As String = ""
        getFTPUserPass(strFTPId, strFTPPass)
        ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)
        'Method��WebRequestMethods.Ftp.DeleteFile��ݒ�
        ftpReq.Method = System.Net.WebRequestMethods.Ftp.DeleteFile

        'FtpWebResponse���擾
        Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)

        '����
        ftpRes.Close()

        LF_DeleteFileFTP = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FFTP�f�B���N�g���폜����(FTP����)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2018.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_DeleteDirectoryFTP(ByVal pdir As String) As Boolean
        targetPrgLabel.Text = "�t�H���_�[�폜�F" + pdir

        Dim success As Boolean = False
        Dim tries As Integer = 0


        Do While (success = False And tries < 3)

            Try
                '�폜����t�@�C����URI
                Dim u As New Uri("ftp://" & pdir)

                'FtpWebRequest�̍쐬
                Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(u), System.Net.FtpWebRequest)
                '���O�C�����[�U�[���ƃp�X���[�h��ݒ�
                'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
                Dim strFTPId As String = "ftp"
                Dim strFTPPass As String = ""
                getFTPUserPass(strFTPId, strFTPPass)
                ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)
                'Method��WebRequestMethods.Ftp.RemoveDirectory��ݒ�
                ftpReq.Method = System.Net.WebRequestMethods.Ftp.RemoveDirectory

                'FtpWebResponse���擾
                Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)

                '����
                ftpRes.Close()
                tries = tries + 1
                success = True

            Catch ex As Exception
                LF_DeleteDirectoryFTP = False
                success = False
                tries = tries + 1

            End Try
        Loop
        LF_DeleteDirectoryFTP = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FFTP�f�B���N�g���폜����(FTP����)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2018.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LF_DeleteDirectoryContentsFTP(ByVal pdir As String)
        targetPrgLabel.Text = "�t�H���_�[�폜�F" + pdir

        Dim strSVFile As String = ""
        Dim strLocalFile As String = ""
        Dim strFileErrorMessage As String = ""
        Dim e As ExecutionEngineException

        Try
            Dim u As New Uri("ftp://" & pdir & "/")
            Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(u), System.Net.FtpWebRequest)
            'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
            Dim strFTPId As String = "ftp"
            Dim strFTPPass As String = ""
            getFTPUserPass(strFTPId, strFTPPass)
            ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)
            ftpReq.Method = System.Net.WebRequestMethods.Ftp.ListDirectory
            ftpReq.KeepAlive = False
            If System.Configuration.ConfigurationManager.AppSettings("FTPUploadPassiveMode") = "0" Then
                ftpReq.UsePassive = False
            Else
                ftpReq.UsePassive = True
            End If
            Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
            Dim sr As New System.IO.StreamReader(ftpRes.GetResponseStream()) '"Shift-JIS" 'Gert 04/01
            Dim res As String = sr.ReadToEnd()

            sr.Close()
            ftpRes.Close()

            If res.Count = 0 Then
                Exit Sub
            End If

            Dim strFileNM As String() = res.Split(Environment.NewLine)

            ''WebClient�I�u�W�F�N�g���쐬
            'Dim wc As New System.Net.WebClient()
            ''���O�C�����[�U�[���ƃp�X���[�h���w��
            'wc.Credentials = New System.Net.NetworkCredential("ftp", "")

            For i As Integer = 0 To strFileNM.Count - 2
                If i > 0 Then
                    strFileNM(i) = strFileNM(i).TrimStart
                End If

                strSVFile = pdir & "/" & Trim$(strFileNM(i))

                ' FTP�T�[�o�̃t�@�C���폜
                If Not LF_DeleteFileFTP(strSVFile) Then 'Gert 10/01 3��retry
                    If Not LF_DeleteFileFTP(strSVFile) Then
                        If Not LF_DeleteFileFTP(strSVFile) Then
                            Exit Sub
                        End If
                    End If
                End If
            Next

        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�������j���[DELETE����
    ' �@�@�\�T�v�F�������j���[��DB����DELETE����
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.10.01 �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    Private Function LS_DeleteMenu(ByVal pPutPath As String) As Boolean

        Dim strSQL As String = ""

        LS_DeleteMenu = False

        Try
            For i As Integer = 0 To 29
                Select Case i

                    Case 0
                        targetPrgLabel.Text = "�폜:" + "TPM010"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM010"
                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 1
                        targetPrgLabel.Text = "�폜:" + "TPM020"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM020"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 2
                        targetPrgLabel.Text = "�폜:" + "TPM030"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM030"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 3
                        targetPrgLabel.Text = "�폜:" + "TPM040"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM040"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 4
                        targetPrgLabel.Text = "�폜:" + "TPM060"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM060"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 5
                        targetPrgLabel.Text = "�폜:" + "TPM061"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM061"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 6
                        targetPrgLabel.Text = "�폜:" + "TPM062"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM062"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 7
                        targetPrgLabel.Text = "�폜:" + "TPM080"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM080"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 8
                        'targetPrgLabel.Text = "�폜:" + "TPM090"
                        'strSQL = ""
                        'strSQL = strSQL & " DELETE FROM TPM090"

                        'If Not GF_UpdCmtData(strSQL) Then
                        '    Exit Function
                        'End If
                    Case 9
                        'targetPrgLabel.Text = "�폜:" + "TPM091"
                        'strSQL = ""
                        'strSQL = strSQL & " DELETE FROM TPM091"

                        'If Not GF_UpdCmtData(strSQL) Then
                        '    Exit Function
                        'End If
                    Case 10
                        targetPrgLabel.Text = "�폜:" + "TPM092"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM092"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 11
                        targetPrgLabel.Text = "�폜:" + "TPM100"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM100"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 12
                        targetPrgLabel.Text = "�폜:" + "TPM110"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM110"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 13
                        targetPrgLabel.Text = "�폜:" + "TPM120"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM120"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 14
                        targetPrgLabel.Text = "�폜:" + "TPM160"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM160"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 15
                        targetPrgLabel.Text = "�폜:" + "TPM170"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM170"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 16
                        targetPrgLabel.Text = "�폜:" + "TPM200"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM200"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 17
                        targetPrgLabel.Text = "�폜:" + "TPM210"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM210"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 18
                        targetPrgLabel.Text = "�폜:" + "TPM220"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM220"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 19
                        targetPrgLabel.Text = "�폜:" + ""
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM230"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 20
                        targetPrgLabel.Text = "�폜:" + "TPM240"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM240"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 21
                        targetPrgLabel.Text = "�폜:" + "TPM250"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM250"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 22
                        targetPrgLabel.Text = "�폜:" + "TPM260"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM260"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 23
                        targetPrgLabel.Text = "�폜:" + "TPM300"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM300"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 24
                        targetPrgLabel.Text = "�폜:" + "TPM310"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM310"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 25
                        targetPrgLabel.Text = "�폜:" + "TPM330"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM330"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 26
                        targetPrgLabel.Text = "�폜:" + "TPM340"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM340"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 27
                        targetPrgLabel.Text = "�폜:" + "TPM350"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM350"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 28
                        targetPrgLabel.Text = "�폜:" + "TPM600"
                        strSQL = ""

                        If System.IO.File.Exists(pPutPath & "\TableData\TPM600.txt") = True Then
                            'TPM600�f�[�^���ݎ�
                            strSQL = strSQL & " DELETE FROM TPM600"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        End If
                    Case 29
                        targetPrgLabel.Text = "�폜:" + "TPM610"
                        strSQL = ""

                        If System.IO.File.Exists(pPutPath & "\TableData\TPM610.txt") = True Then
                            'TPM610�f�[�^���ݎ�
                            strSQL = strSQL & " DELETE FROM TPM610"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        End If
                    Case Else
                        Exit Select
                End Select
            Next

            If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                For j As Integer = 0 To 20
                    Select Case j
                        Case 0
                            targetPrgLabel.Text = "�폜:" + "TPM010A"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM010A"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 1
                            targetPrgLabel.Text = "�폜:" + "TPM010B"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM010B"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 2
                            targetPrgLabel.Text = "�폜:" + "TPM010C"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM010C"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 3
                            targetPrgLabel.Text = "�폜:" + "TPM020A"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM020A"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 4
                            targetPrgLabel.Text = "�폜:" + "TPM020B"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM020B"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 5
                            targetPrgLabel.Text = "�폜:" + "TPM020C"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM020C"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 6
                            targetPrgLabel.Text = "�폜:" + "TPM030A"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM030A"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 7
                            targetPrgLabel.Text = "�폜:" + "TPM030B"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM030B"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 8
                            targetPrgLabel.Text = "�폜:" + "TPM030C"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM030C"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 9
                            targetPrgLabel.Text = "�폜:" + "TPM060A"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM060A"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 10
                            targetPrgLabel.Text = "�폜:" + "TPM060B"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM060B"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 11
                            targetPrgLabel.Text = "�폜:" + "TPM060C"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM060C"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 12
                            targetPrgLabel.Text = "�폜:" + "TPM061A"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM061A"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 13
                            targetPrgLabel.Text = "�폜:" + "TPM061B"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM061B"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 14
                            targetPrgLabel.Text = "�폜:" + "TPM061C"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM061C"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 15
                            targetPrgLabel.Text = "�폜:" + "TPM100A"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM100A"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 16
                            targetPrgLabel.Text = "�폜:" + "TPM100B"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM100B"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 17
                            targetPrgLabel.Text = "�폜:" + "TPM100C"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM100C"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 18
                            targetPrgLabel.Text = "�폜:" + "TPM240A"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM240A"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 19
                            targetPrgLabel.Text = "�폜:" + "TPM240B"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM240B"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 20
                            targetPrgLabel.Text = "�폜:" + "TPM240C"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM240C"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case Else
                            Exit Select
                    End Select
                Next
            End If
        Catch ex As Exception
            Call MsgBox(ex.Message)
        End Try

        LS_DeleteMenu = True

    End Function

    Private Function LS_DeleteOMOTENASHI(ByVal pPutPath As String) As Boolean

        Dim strSQL As String = ""

        LS_DeleteOMOTENASHI = False

        Try
            targetPrgLabel.Text = "�폜:" + "TPM540"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM540"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "�폜:" + "TPM541"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM541"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "�폜:" + "TPM545"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM545"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "�폜:" + "TPM550"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM550"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "�폜:" + "TPM552"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM552"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "�폜:" + "TPM554"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM554"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "�폜:" + "TPM555"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM555"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "�폜:" + "TPM556"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM556"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "�폜:" + "TPM557"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM557"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "�폜:" + "TPM558"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM558"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "�폜:" + "TPM559"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM559"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "�폜:" + "TPM560"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM560"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "�폜:" + "TPM562"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM562"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "�폜:" + "TPM565"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM565"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

        Catch ex As Exception
            Call MsgBox(ex.Message)
        End Try

        LS_DeleteOMOTENASHI = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FTPM350 DELETE����(����z�M)
    ' �@�@�\�T�v�F�������j���[��DB����DELETE����
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.12.01 �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    Private Function LS_DeleteTPM350() As Boolean
        targetPrgLabel.Text = "�e�[�u���폜�FTPM350"
        Dim strSQL As String = ""

        LS_DeleteTPM350 = False

        strSQL = ""
        strSQL = strSQL & " DELETE FROM TPM350"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        LS_DeleteTPM350 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FTPM010 DELETE����(����z�M)
    ' �@�@�\�T�v�F�������j���[��DB����DELETE����
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.12.01 �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    Private Function LS_DeleteTPM010(ByVal pgoodscd As String) As Boolean

        Dim strSQL As String = ""

        LS_DeleteTPM010 = False

        Try
            targetPrgLabel.Text = "����z�M���i�폜�FTPM010�F" + pgoodscd
            strSQL = ""
            strSQL = strSQL & " DELETE TPM010"
            strSQL = strSQL & "  WHERE GOODSCD = '" & pgoodscd & "'"

            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            If Trim$(GF_GetAppInfo2("MULTI_LING_USE")) = "1" Then
                strSQL = ""
                strSQL = strSQL & " DELETE TPM010A"
                strSQL = strSQL & "  WHERE GOODSCD = '" & pgoodscd & "'"

                If Not GF_UpdCmtData(strSQL) Then
                    Exit Function
                End If

                strSQL = ""
                strSQL = strSQL & " DELETE TPM010B"
                strSQL = strSQL & "  WHERE GOODSCD = '" & pgoodscd & "'"

                If Not GF_UpdCmtData(strSQL) Then
                    Exit Function
                End If

                strSQL = ""
                strSQL = strSQL & " DELETE TPM010C"
                strSQL = strSQL & "  WHERE GOODSCD = '" & pgoodscd & "'"

                If Not GF_UpdCmtData(strSQL) Then
                    Exit Function
                End If
            End If

            LS_DeleteTPM010 = True

        Catch

        End Try


    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�f�[�^�C���|�[�g����
    ' �@�@�\�T�v�F�z�M���j���[�̃C���|�[�g�������s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.10.01 �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    Private Function LS_Deli_DataInport(ByVal pInfo As typConnectionInfo, ByVal pPath As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strExpPath As String

        LS_Deli_DataInport = False

        With pInfo
            .strAdvPath = Trim$(GF_GetAppInfo("ADV_PATH"))
            .strItemPath = Trim$(GF_GetAppInfo("ITEM_PATH"))
            .strGrpPath = Trim$(GF_GetAppInfo("GROUP_PATH"))
            .strMenuGrpPath = Trim$(GF_GetAppInfo("MENUIMG_V"))
            .strStoreMkPath = Trim$(GF_GetAppInfo("STOREMARK_V"))

            ' �C���|�[�g���p�X�擾
            strExpPath = pPath
        End With
        ' 90%
        targetPrgBar.Value = 900

        ' �摜�t�@�C���R�s�[
        If Not LS_Deli_ImageBackup(strExpPath & "\ImageData", pInfo) Then
            Exit Function
        End If
        ' 91%
        targetPrgBar.Value = 910

        'Delete Unused Images
        If Not LF_DelUnuseFile() Then
            Exit Function
        End If
        ' 91%
        targetPrgBar.Value = 920

        If Not LS_DeleteMenu(strExpPath) Then
            Exit Function
        End If
        ' 92%
        targetPrgBar.Value = 930

        If Not LS_ChgCsv(strExpPath) Then
            Exit Function
        End If

        ' �C���|�[�g�p�R�}���h���s
        If Not LS_CreateImportCommand(strExpPath, pInfo) Then
            Exit Function
        End If

        LS_Deli_DataInport = True

    End Function

    Private Function LS_OMOTENASHI_DataInport(ByVal pInfo As typConnectionInfo, ByVal pPath As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strExpPath As String

        LS_OMOTENASHI_DataInport = False

        With pInfo
            .strAdvPath = Trim$(GF_GetAppInfo("ADV_PATH"))
            .strItemPath = Trim$(GF_GetAppInfo("ITEM_PATH"))
            .strGrpPath = Trim$(GF_GetAppInfo("GROUP_PATH"))
            .strMenuGrpPath = Trim$(GF_GetAppInfo("MENUIMG_V"))
            .strStoreMkPath = Trim$(GF_GetAppInfo("STOREMARK_V"))

            ' �C���|�[�g���p�X�擾
            strExpPath = pPath
        End With
        ' 90%
        targetPrgBar.Value = 900

        ' �摜�t�@�C���R�s�[
        If Not LS_OMOTENASHI_ImageBackup(strExpPath & "\ImageData", pInfo) Then
            Exit Function
        End If
        ' 91%
        targetPrgBar.Value = 910

        'Delete Unused Images
        If Not LF_DelUnuseFile() Then
            Exit Function
        End If
        ' 91%
        targetPrgBar.Value = 920

        If Not LS_DeleteMenu(strExpPath) Then
            Exit Function
        End If
        If Not LS_DeleteOMOTENASHI(strExpPath) Then
            Exit Function
        End If

        ' 92%
        targetPrgBar.Value = 930

        If Not LS_ChgCsv(strExpPath) Then
            Exit Function
        End If
        If Not LS_ChgCsvOMOTENASHI(strExpPath) Then
            Exit Function
        End If

        ' �C���|�[�g�p�R�}���h���s
        If Not LS_CreateImportCommand(strExpPath, pInfo) Then
            Exit Function
        End If
        If Not LS_CreateImportCommandOMOTENASHI(strExpPath, pInfo) Then
            Exit Function
        End If
        NullToBlank(False)

        LS_OMOTENASHI_DataInport = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�f�[�^�C���|�[�g����
    ' �@�@�\�T�v�F�z�M���j���[�̃C���|�[�g�������s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.10.01 �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    Private Function LS_Deli_DataInportLimited(ByVal pInfo As typConnectionInfo, ByVal pPath As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strExpPath As String

        LS_Deli_DataInportLimited = False

        With pInfo
            .strAdvPath = Trim$(GF_GetAppInfo("ADV_PATH"))
            .strItemPath = Trim$(GF_GetAppInfo("ITEM_PATH"))
            .strGrpPath = Trim$(GF_GetAppInfo("GROUP_PATH"))
            .strMenuGrpPath = Trim$(GF_GetAppInfo("MENUIMG_V"))
            .strStoreMkPath = Trim$(GF_GetAppInfo("STOREMARK_V"))

            ' �C���|�[�g���p�X�擾
            strExpPath = pPath
        End With
        ' 60%
        targetPrgBar.Value = 60
        ' �摜�t�@�C���R�s�[
        LS_Deli_ImageBackupLimited(strExpPath & "\ImageData", pInfo)

        ' 70%
        targetPrgBar.Value = 60

        If Not LS_DeleteTPM350() Then
            Exit Function
        End If

        If Not LS_ChgCsvLimited(strExpPath) Then
            Exit Function
        End If

        ' �C���|�[�g�p�R�}���h���s(TPM350)
        If Not LS_ImportCommandLimited(False, strExpPath, pInfo) Then
            Exit Function
        End If

        ' 70%
        targetPrgBar.Value = 70

        If Not LF_SelectDelteTPM010() Then
            Exit Function
        End If

        ' �C���|�[�g�p�R�}���h���s(TPM010)
        If Not LS_ImportCommandLimited(True, strExpPath, pInfo) Then
            Exit Function
        End If

        LS_Deli_DataInportLimited = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�f�[�^�C���|�[�g����
    ' �@�@�\�T�v�F�o�b�N�A�b�v�f�[�^�̃C���|�[�g�������s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.10.01 �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    Private Function LS_Backup_DataInport(ByVal pInfo As typConnectionInfo, ByVal pPath As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strExpPath As String

        LS_Backup_DataInport = False

        With pInfo
            .strAdvPath = Trim$(GF_GetAppInfo("ADV_PATH"))
            .strItemPath = Trim$(GF_GetAppInfo("ITEM_PATH"))
            .strGrpPath = Trim$(GF_GetAppInfo("GROUP_PATH"))
            .strMenuGrpPath = Trim$(GF_GetAppInfo("MENUIMG_V"))
            .strStoreMkPath = Trim$(GF_GetAppInfo("STOREMARK_V"))

            ' �C���|�[�g���p�X�擾
            strExpPath = pPath
        End With

        ' �摜�t�@�C���R�s�[
        'If Not LS_Deli_ImageBackup(strExpPath & "\ImageData", pInfo) Then
        '    Exit Function
        'End If

        If Not LS_DeleteMenu(strExpPath) Then
            Exit Function
        End If

        ' �C���|�[�g�p�R�}���h���s
        If Not LS_CreateImportCommand(strExpPath, pInfo) Then
            Exit Function
        End If

        LS_Backup_DataInport = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�g���q�ϊ�����
    ' �@�@�\�T�v�F�g���q�̕ϊ��������s��
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2017.09.21 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LS_ChgCsv(ByVal pPutPath As String) As Boolean

        LS_ChgCsv = False

        Try
            targetPrgLabel.Text = "�e�[�u���f�[�^�ړ���"
            System.IO.File.Move(pPutPath & "\TableData\TPM010.csv", pPutPath & "\TableData\TPM010.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM010A.csv", pPutPath & "\TableData\TPM010A.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM020.csv", pPutPath & "\TableData\TPM020.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM020A.csv", pPutPath & "\TableData\TPM020A.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM030.csv", pPutPath & "\TableData\TPM030.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM030A.csv", pPutPath & "\TableData\TPM030A.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM040.csv", pPutPath & "\TableData\TPM040.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM060.csv", pPutPath & "\TableData\TPM060.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM060A.csv", pPutPath & "\TableData\TPM060A.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM061.csv", pPutPath & "\TableData\TPM061.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM061A.csv", pPutPath & "\TableData\TPM061A.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM062.csv", pPutPath & "\TableData\TPM062.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM080.csv", pPutPath & "\TableData\TPM080.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM090.csv", pPutPath & "\TableData\TPM090.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM091.csv", pPutPath & "\TableData\TPM091.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM092.csv", pPutPath & "\TableData\TPM092.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM100.csv", pPutPath & "\TableData\TPM100.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM100A.csv", pPutPath & "\TableData\TPM100A.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM110.csv", pPutPath & "\TableData\TPM110.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM120.csv", pPutPath & "\TableData\TPM120.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM160.csv", pPutPath & "\TableData\TPM160.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM170.csv", pPutPath & "\TableData\TPM170.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM200.csv", pPutPath & "\TableData\TPM200.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM210.csv", pPutPath & "\TableData\TPM210.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM220.csv", pPutPath & "\TableData\TPM220.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM230.csv", pPutPath & "\TableData\TPM230.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM240.csv", pPutPath & "\TableData\TPM240.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM240A.csv", pPutPath & "\TableData\TPM240A.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM250.csv", pPutPath & "\TableData\TPM250.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM260.csv", pPutPath & "\TableData\TPM260.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM300.csv", pPutPath & "\TableData\TPM300.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM310.csv", pPutPath & "\TableData\TPM310.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM330.csv", pPutPath & "\TableData\TPM330.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM340.csv", pPutPath & "\TableData\TPM340.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM350.csv", pPutPath & "\TableData\TPM350.txt")
            If System.IO.File.Exists(pPutPath & "\TableData\TPM600.csv") = True Then
                'TPM600�f�[�^���ݎ�
                System.IO.File.Move(pPutPath & "\TableData\TPM600.csv", pPutPath & "\TableData\TPM600.txt")
            End If
            If System.IO.File.Exists(pPutPath & "\TableData\TPM610.csv") = True Then
                'TPM610�f�[�^���ݎ�
                System.IO.File.Move(pPutPath & "\TableData\TPM610.csv", pPutPath & "\TableData\TPM610.txt")
            End If

            LS_ChgCsv = True

            Exit Function
        Catch
            Exit Function
        End Try

    End Function

    Private Function LS_ChgCsvOMOTENASHI(ByVal pPutPath As String) As Boolean

        LS_ChgCsvOMOTENASHI = False

        Try
            targetPrgLabel.Text = "�e�[�u���f�[�^�ړ���"
            System.IO.File.Move(pPutPath & "\TableData\TPM540.csv", pPutPath & "\TableData\TPM540.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM541.csv", pPutPath & "\TableData\TPM541.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM545.csv", pPutPath & "\TableData\TPM545.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM550.csv", pPutPath & "\TableData\TPM550.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM552.csv", pPutPath & "\TableData\TPM552.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM554.csv", pPutPath & "\TableData\TPM554.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM555.csv", pPutPath & "\TableData\TPM555.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM556.csv", pPutPath & "\TableData\TPM556.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM557.csv", pPutPath & "\TableData\TPM557.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM558.csv", pPutPath & "\TableData\TPM558.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM559.csv", pPutPath & "\TableData\TPM559.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM560.csv", pPutPath & "\TableData\TPM560.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM562.csv", pPutPath & "\TableData\TPM562.txt")
            System.IO.File.Move(pPutPath & "\TableData\TPM565.csv", pPutPath & "\TableData\TPM565.txt")
            LS_ChgCsvOMOTENASHI = True

            Exit Function
        Catch
            Exit Function
        End Try

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�g���q�ϊ�����
    ' �@�@�\�T�v�F�g���q�̕ϊ��������s��
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2017.12.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LS_ChgCsvLimited(ByVal pPutPath As String) As Boolean

        LS_ChgCsvLimited = False

        Try
            targetPrgLabel.Text = "�e�[�u���f�[�^�ړ��FTPM010"
            System.IO.File.Move(pPutPath & "\TableData\TPM010.csv", pPutPath & "\TableData\TPM010.txt")
            targetPrgLabel.Text = "�e�[�u���f�[�^�ړ��FTPM010"
            System.IO.File.Move(pPutPath & "\TableData\TPM350.csv", pPutPath & "\TableData\TPM350.txt")

            LS_ChgCsvLimited = True

            Exit Function
        Catch
            Exit Function
        End Try

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�摜�t�@�C���R�s�[����
    ' �@�@�\�T�v�F�z�M���ꂽ���j���[�̉摜�t�@�C�����R�s�[���s��
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2017.09.21 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LS_Deli_ImageBackup(ByVal pTargetPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LS_Deli_ImageBackup = False

        Try
            '------------------------------
            ' �摜�t�@�C���ޔ�
            '------------------------------
            If Not LF_Deli_ImageCopy(pTargetPath & "\ItemImage", pInfo.strItemPath) Then
                Exit Function
            End If

            If Not LF_Deli_ImageCopy(pTargetPath & "\GroupImage", pInfo.strGrpPath) Then
                Exit Function
            End If

            If Not LF_Deli_ImageCopy(pTargetPath & "\MenuImage", pInfo.strMenuGrpPath) Then
                Exit Function
            End If

            If Not LF_Deli_ImageCopy(pTargetPath & "\AdvImage", pInfo.strAdvPath) Then
                Exit Function
            End If

            If Not LF_Deli_ImageCopy(pTargetPath & "\StoreMark", pInfo.strStoreMkPath) Then
                Exit Function
            End If
        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LS_Deli_ImageBackup = True

    End Function

    Private Function LS_OMOTENASHI_ImageBackup(ByVal pTargetPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LS_OMOTENASHI_ImageBackup = False

        Try
            '------------------------------
            ' �摜�t�@�C���ޔ�
            '------------------------------
            If Not LF_Deli_ImageCopy(pTargetPath & "\ItemImage", pInfo.strItemPath) Then
                Exit Function
            End If
            If Not LF_Deli_ImageCopy(pTargetPath & "\GroupImage", pInfo.strGrpPath) Then
                Exit Function
            End If
            If Not LF_Deli_ImageCopy(pTargetPath & "\MenuImage", pInfo.strMenuGrpPath) Then
                Exit Function
            End If
            If Not LF_Deli_ImageCopy(pTargetPath & "\AdvImage", pInfo.strAdvPath) Then
                Exit Function
            End If
            If Not LF_Deli_ImageCopy(pTargetPath & "\StoreMark", pInfo.strStoreMkPath) Then
                Exit Function
            End If
            If Not LF_Deli_ImageCopy(pTargetPath & "\MenuPage", "C:\Inetpub\wwwroot\CNWI001\MenuPage") Then
                Exit Function
            End If
            If Not LF_Deli_ImageCopy(pTargetPath & "\MenuThumbnail", "C:\Inetpub\wwwroot\CNWI001\MenuThumbnail") Then
                Exit Function
            End If
        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LS_OMOTENASHI_ImageBackup = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�摜�t�@�C���R�s�[����
    ' �@�@�\�T�v�F�z�M���ꂽ���j���[�̉摜�t�@�C�����R�s�[���s��
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2017.09.21 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_Deli_ImageBackupLimited(ByVal pTargetPath As String, ByVal pInfo As typConnectionInfo)

        '------------------------------
        ' �摜�t�@�C���ޔ�
        '------------------------------
        If Not LF_Deli_ImageCopy(pTargetPath & "\ItemImage", pInfo.strItemPath) Then
            Exit Sub
        End If

        If Not LF_Deli_ImageCopy(pTargetPath & "\MenuImage", pInfo.strMenuGrpPath) Then
            Exit Sub
        End If

        If Not LF_Deli_ImageCopy(pTargetPath & "\StoreMark", pInfo.strStoreMkPath) Then
            Exit Sub
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�z�M���j���[DB�o�^����
    ' �@�@�\�T�v�F�z�M���j���[��DB��INSERT�������s��
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2017.10.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LS_CreateImportCommand(ByVal pPutPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        Dim proc As New System.Diagnostics.Process
        Dim strLUNGflg As String

        LS_CreateImportCommand = False

        Try

            '������@�\�Ή�
            strLUNGflg = Trim$(GF_GetAppInfo2("MULTI_LING_USE"))

            proc.StartInfo.UseShellExecute = False
            proc.StartInfo.RedirectStandardInput = True

            proc.StartInfo.RedirectStandardOutput = True
            AddHandler proc.OutputDataReceived, AddressOf p_OutputDataReceived

            proc.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec")
            proc.StartInfo.CreateNoWindow = True

            proc.Start()

            proc.BeginOutputReadLine()

            Dim sw As System.IO.StreamWriter = proc.StandardInput
            targetPrgLabel.Text = "�e�[�u���f�[�^�C���|�[�g"
            If sw.BaseStream.CanWrite Then

                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM010 in " & """" & pPutPath & "\TableData\TPM010.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM020 in " & """" & pPutPath & "\TableData\TPM020.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM030 in " & """" & pPutPath & "\TableData\TPM030.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM040 in " & """" & pPutPath & "\TableData\TPM040.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM060 in " & """" & pPutPath & "\TableData\TPM060.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM061 in " & """" & pPutPath & "\TableData\TPM061.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM062 in " & """" & pPutPath & "\TableData\TPM062.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM080 in " & """" & pPutPath & "\TableData\TPM080.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                'sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM090 in " & """" & pPutPath & "\TableData\TPM090.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                'sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM091 in " & """" & pPutPath & "\TableData\TPM091.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM092 in " & """" & pPutPath & "\TableData\TPM092.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM100 in " & """" & pPutPath & "\TableData\TPM100.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM110 in " & """" & pPutPath & "\TableData\TPM110.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM120 in " & """" & pPutPath & "\TableData\TPM120.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM160 in " & """" & pPutPath & "\TableData\TPM160.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM170 in " & """" & pPutPath & "\TableData\TPM170.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM200 in " & """" & pPutPath & "\TableData\TPM200.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM210 in " & """" & pPutPath & "\TableData\TPM210.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM220 in " & """" & pPutPath & "\TableData\TPM220.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM230 in " & """" & pPutPath & "\TableData\TPM230.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM240 in " & """" & pPutPath & "\TableData\TPM240.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM250 in " & """" & pPutPath & "\TableData\TPM250.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM260 in " & """" & pPutPath & "\TableData\TPM260.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM300 in " & """" & pPutPath & "\TableData\TPM300.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM310 in " & """" & pPutPath & "\TableData\TPM310.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM330 in " & """" & pPutPath & "\TableData\TPM330.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM340 in " & """" & pPutPath & "\TableData\TPM340.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM350 in " & """" & pPutPath & "\TableData\TPM350.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                If System.IO.File.Exists(pPutPath & "\TableData\TPM600.txt") = True Then
                    'TPM600�f�[�^���ݎ�
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM600 in " & """" & pPutPath & "\TableData\TPM600.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                End If
                If System.IO.File.Exists(pPutPath & "\TableData\TPM610.txt") = True Then
                    'TPM610�f�[�^���ݎ�
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM610 in " & """" & pPutPath & "\TableData\TPM610.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                End If

                If strLUNGflg = "1" Then

                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM010A in " & """" & pPutPath & "\TableData\TPM010A.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM010B in " & """" & pPutPath & "\TableData\TPM010B.csv" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM010C in " & """" & pPutPath & "\TableData\TPM010C.csv" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                    'sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM010B in " & """" & pPutPath & "\TableData\TPM010B.csv" & """" & " -w -t" & """" & "," & """" & "  -T -S" & pInfo.strSVNM & " -U " & pInfo.strUserNM)
                    'sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM010C in " & """" & pPutPath & "\TableData\TPM010C.csv" & """" & " -w -t" & """" & "," & """" & "  -T -S" & pInfo.strSVNM & " -U " & pInfo.strUserNM)
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM020A in " & """" & pPutPath & "\TableData\TPM020A.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM020B in " & """" & pPutPath & "\TableData\TPM020B.csv" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM020C in " & """" & pPutPath & "\TableData\TPM020C.csv" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                    'sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM020B in " & """" & pPutPath & "\TableData\TPM020B.csv" & """" & " -w -t" & """" & "," & """" & "  -T -S" & pInfo.strSVNM & " -U " & pInfo.strUserNM)
                    'sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM020C in " & """" & pPutPath & "\TableData\TPM020C.csv" & """" & " -w -t" & """" & "," & """" & "  -T -S" & pInfo.strSVNM & " -U " & pInfo.strUserNM)
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM030A in " & """" & pPutPath & "\TableData\TPM030A.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM030B in " & """" & pPutPath & "\TableData\TPM030B.csv" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM030C in " & """" & pPutPath & "\TableData\TPM030C.csv" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                    'sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM030B in " & """" & pPutPath & "\TableData\TPM030B.csv" & """" & " -w -t" & """" & "," & """" & "  -T -S" & pInfo.strSVNM & " -U " & pInfo.strUserNM)
                    'sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM030C in " & """" & pPutPath & "\TableData\TPM030C.csv" & """" & " -w -t" & """" & "," & """" & "  -T -S" & pInfo.strSVNM & " -U " & pInfo.strUserNM)
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM060A in " & """" & pPutPath & "\TableData\TPM060A.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM060B in " & """" & pPutPath & "\TableData\TPM060B.csv" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM060C in " & """" & pPutPath & "\TableData\TPM060C.csv" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                    'sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM060B in " & """" & pPutPath & "\TableData\TPM060B.csv" & """" & " -w -t" & """" & "," & """" & "  -T -S" & pInfo.strSVNM & " -U " & pInfo.strUserNM)
                    'sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM060C in " & """" & pPutPath & "\TableData\TPM060C.csv" & """" & " -w -t" & """" & "," & """" & "  -T -S" & pInfo.strSVNM & " -U " & pInfo.strUserNM)
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM061A in " & """" & pPutPath & "\TableData\TPM061A.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM061B in " & """" & pPutPath & "\TableData\TPM061B.csv" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM061C in " & """" & pPutPath & "\TableData\TPM061C.csv" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                    'sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM061B in " & """" & pPutPath & "\TableData\TPM061B.csv" & """" & " -w -t" & """" & "," & """" & "  -T -S" & pInfo.strSVNM & " -U " & pInfo.strUserNM)
                    'sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM061C in " & """" & pPutPath & "\TableData\TPM061C.csv" & """" & " -w -t" & """" & "," & """" & "  -T -S" & pInfo.strSVNM & " -U " & pInfo.strUserNM)
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM100A in " & """" & pPutPath & "\TableData\TPM100A.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM100B in " & """" & pPutPath & "\TableData\TPM100B.csv" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM100C in " & """" & pPutPath & "\TableData\TPM100C.csv" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                    'sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM100B in " & """" & pPutPath & "\TableData\TPM100B.csv" & """" & " -w -t" & """" & "," & """" & "  -T -S" & pInfo.strSVNM & " -U " & pInfo.strUserNM)
                    'sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM100C in " & """" & pPutPath & "\TableData\TPM100C.csv" & """" & " -w -t" & """" & "," & """" & "  -T -S" & pInfo.strSVNM & " -U " & pInfo.strUserNM)
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM240A in " & """" & pPutPath & "\TableData\TPM240A.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM240B in " & """" & pPutPath & "\TableData\TPM240B.csv" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM240C in " & """" & pPutPath & "\TableData\TPM240C.csv" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                    'sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM240B in " & """" & pPutPath & "\TableData\TPM240B.csv" & """" & " -w -t" & """" & "," & """" & "  -T -S" & pInfo.strSVNM & " -U " & pInfo.strUserNM)
                    'sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM240C in " & """" & pPutPath & "\TableData\TPM240C.csv" & """" & " -w -t" & """" & "," & """" & "  -T -S" & pInfo.strSVNM & " -U " & pInfo.strUserNM)

                End If

            End If

            sw.Close()

            proc.WaitForExit()

            proc.Close()

        Catch
            Exit Function
        End Try

        LS_CreateImportCommand = True

    End Function

    Private Function LS_CreateImportCommandOMOTENASHI(ByVal pPutPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        Dim proc As New System.Diagnostics.Process
        'Dim strLUNGflg As String

        LS_CreateImportCommandOMOTENASHI = False

        Try

            '������@�\�Ή�
            'strLUNGflg = Trim$(GF_GetAppInfo2("MULTI_LING_USE"))

            proc.StartInfo.UseShellExecute = False
            proc.StartInfo.RedirectStandardInput = True

            proc.StartInfo.RedirectStandardOutput = True
            AddHandler proc.OutputDataReceived, AddressOf p_OutputDataReceived

            proc.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec")
            proc.StartInfo.CreateNoWindow = True

            proc.Start()

            proc.BeginOutputReadLine()

            Dim sw As System.IO.StreamWriter = proc.StandardInput
            targetPrgLabel.Text = "�e�[�u���f�[�^�C���|�[�g"
            If sw.BaseStream.CanWrite Then
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM540 in " & """" & pPutPath & "\TableData\TPM540.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM541 in " & """" & pPutPath & "\TableData\TPM541.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM545 in " & """" & pPutPath & "\TableData\TPM545.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM550 in " & """" & pPutPath & "\TableData\TPM550.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM552 in " & """" & pPutPath & "\TableData\TPM552.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM554 in " & """" & pPutPath & "\TableData\TPM554.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM555 in " & """" & pPutPath & "\TableData\TPM555.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM556 in " & """" & pPutPath & "\TableData\TPM556.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM557 in " & """" & pPutPath & "\TableData\TPM557.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM558 in " & """" & pPutPath & "\TableData\TPM558.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM559 in " & """" & pPutPath & "\TableData\TPM559.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM560 in " & """" & pPutPath & "\TableData\TPM560.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM562 in " & """" & pPutPath & "\TableData\TPM562.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
                sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM565 in " & """" & pPutPath & "\TableData\TPM565.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,")
            End If

            sw.Close()

            proc.WaitForExit()

            proc.Close()

        Catch
            Exit Function
        End Try

        LS_CreateImportCommandOMOTENASHI = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�z�M���j���[DB�o�^����(����z�M)
    ' �@�@�\�T�v�F�z�M���j���[��DB��INSERT�������s��
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2017.10.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LS_ImportCommandLimited(ByVal pmode As Boolean, ByVal pPutPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        'Dim proc As New System.Diagnostics.Process

        LS_ImportCommandLimited = False

        'Try

        '    proc.StartInfo.UseShellExecute = False
        '    proc.StartInfo.RedirectStandardInput = True

        '    proc.StartInfo.RedirectStandardOutput = True
        '    AddHandler proc.OutputDataReceived, AddressOf p_OutputDataReceived

        '    proc.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec")
        '    proc.StartInfo.CreateNoWindow = True

        '    proc.Start()

        '    proc.BeginOutputReadLine()

        '    Dim sw As System.IO.StreamWriter = proc.StandardInput

        '    If sw.BaseStream.CanWrite Then

        '        If pmode Then
        '            sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM010 in " & """" & pPutPath & "\TableData\TPM010.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
        '        Else
        '            sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM350 in " & """" & pPutPath & "\TableData\TPM350.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
        '        End If

        '    End If

        '    sw.Close()

        '    proc.WaitForExit()

        '    proc.Close()

        'Catch
        '    Exit Function
        'End Try

        Dim strSQL As String = ""

        If pmode Then
            targetPrgLabel.Text = "�ꊇ�C���|�[�g�FTPM010"
            strSQL = strSQL & "IF OBJECT_ID('tempdb.dbo.#outer', 'U') IS NOT NULL "
            strSQL = strSQL & "DROP TABLE #outer; "
            strSQL = strSQL & "CREATE TABLE #outer( "
            strSQL = strSQL & "[GOODSCD] [char](5), [GOODSNMJ] [varchar](20), [GOODSNMJ2] [varchar](20), [GOODSNMJ3] [varchar](20), "
            strSQL = strSQL & "[GOODSNMJ4] [varchar](20), [JEXPNOTEJ] [varchar](180), [IMAGEDATA] [char](100), [PRICE] [numeric](7, 0), "
            strSQL = strSQL & "[UNITJ] [varchar](5), [SELLFLG] [char](1), [SCPNO01] [char](3), [SCPNO02] [char](3), [SCPNO03] [char](3), "
            strSQL = strSQL & "[SCPNO04] [char](3), [SCPNO05] [char](3), [SCPNO06] [char](3), [SCPNO07] [char](3), [SCPNO08] [char](3), "
            strSQL = strSQL & "[SCPNO09] [char](3), [SCPNO10] [char](3), [SCPNO11] [char](3), [SCPNO12] [char](3), "
            strSQL = strSQL & "[STATUS] [char](1), [GOODSKIND] [char](1), [BUMONCD] [char](2), [KCPSTATUS] [char](32), "
            strSQL = strSQL & "[GENERATEFLG] [char](1), [HTLNM1] [varchar](5), [HTLNM2] [varchar](5), [SPFLG] [char](1), [NEWFLG] [char](1), "
            strSQL = strSQL & "[UPDID] [char](10), [UPDYMD] [datetime]); "
            strSQL = strSQL & "DECLARE @sql NVARCHAR(MAX); "
            strSQL = strSQL & "SET @sql = N'SET NOCOUNT ON; "
            strSQL = strSQL & "CREATE TABLE #inner( "
            strSQL = strSQL & "[GOODSCD] [char](50), [GOODSNMJ] [varchar](200), [GOODSNMJ2] [varchar](200), [GOODSNMJ3] [varchar](200), "
            strSQL = strSQL & "[GOODSNMJ4] [varchar](200), [JEXPNOTEJ] [varchar](1800), [IMAGEDATA] [char](1000), [PRICE] [numeric](30, 0), "
            strSQL = strSQL & "[UNITJ] [varchar](50), [SELLFLG] [char](10), [SCPNO01] [char](30), [SCPNO02] [char](30), [SCPNO03] [char](30), "
            strSQL = strSQL & "[SCPNO04] [char](30), [SCPNO05] [char](30), [SCPNO06] [char](30), [SCPNO07] [char](30), [SCPNO08] [char](30), "
            strSQL = strSQL & "[SCPNO09] [char](30), [SCPNO10] [char](30), [SCPNO11] [char](30), [SCPNO12] [char](30), "
            strSQL = strSQL & "[STATUS] [char](10), [GOODSKIND] [char](10), [BUMONCD] [char](20), [KCPSTATUS] [char](320), "
            strSQL = strSQL & "[GENERATEFLG] [char](10), [HTLNM1] [varchar](50), [HTLNM2] [varchar](50), [SPFLG] [char](10), [NEWFLG] [char](10), "
            strSQL = strSQL & "[UPDID] [char](100), [UPDYMD] [datetime]); "
            strSQL = strSQL & "BULK INSERT #inner "
            strSQL = strSQL & " FROM ''" & pPutPath & "\TableData\TPM010.txt'' "
            strSQL = strSQL & "WITH(fieldterminator = '','',rowterminator=''\n''); "
            strSQL = strSQL & "CREATE TABLE #innertwo([GOODSCD] [char](5), "
            strSQL = strSQL & "[DELIVARYFLG] [char](1), "
            strSQL = strSQL & "[UPDID] [char](10), "
            strSQL = strSQL & "[UPDYMD] [datetime]); "
            strSQL = strSQL & "BULK INSERT #innertwo "
            strSQL = strSQL & "FROM ''" & pPutPath & "\TableData\TPM350.txt'' "
            strSQL = strSQL & "WITH(fieldterminator = '','',rowterminator=''\n''); "
            strSQL = strSQL & "SELECT RTRIM(#inner.GOODSCD), RTRIM(#inner.GOODSNMJ), RTRIM(#inner.GOODSNMJ2), RTRIM(#inner.GOODSNMJ3), RTRIM(#inner.GOODSNMJ4), RTRIM(#inner.JEXPNOTEJ), RTRIM(#inner.IMAGEDATA), RTRIM(#inner.PRICE), RTRIM(#inner.UNITJ), RTRIM(#inner.SELLFLG), RTRIM(#inner.SCPNO01), RTRIM(#inner.SCPNO02), RTRIM(#inner.SCPNO03), "
            strSQL = strSQL & "RTRIM(#inner.SCPNO04), RTRIM(#inner.SCPNO05), RTRIM(#inner.SCPNO06), RTRIM(#inner.SCPNO07), RTRIM(#inner.SCPNO08), RTRIM(#inner.SCPNO09), RTRIM(#inner.SCPNO10), RTRIM(#inner.SCPNO11), RTRIM(#inner.SCPNO12), RTRIM(#inner.STATUS), RTRIM(#inner.GOODSKIND), RTRIM(#inner.BUMONCD), RTRIM(#inner.KCPSTATUS), RTRIM(#inner.GENERATEFLG), "
            strSQL = strSQL & "RTRIM(#inner.HTLNM1), RTRIM(#inner.HTLNM2), RTRIM(#inner.SPFLG), RTRIM(#inner.NEWFLG), RTRIM(#inner.UPDID), RTRIM(#inner.UPDYMD) "
            strSQL = strSQL & "FROM #inner INNER JOIN #innertwo on #inner.GOODSCD = #innertwo.GOODSCD where #innertwo.DELIVARYFLG = ''1'''; "
            strSQL = strSQL & "INSERT #outer EXEC master.sys.sp_executesql @sql; "
            strSQL = strSQL & "INSERT INTO TPM010 (GOODSCD, GOODSNMJ, GOODSNMJ2, GOODSNMJ3, GOODSNMJ4, JEXPNOTEJ, IMAGEDATA, PRICE, UNITJ, SELLFLG, SCPNO01, SCPNO02, SCPNO03, SCPNO04, SCPNO05, SCPNO06, SCPNO07, SCPNO08, SCPNO09, SCPNO10, SCPNO11, SCPNO12, STATUS, GOODSKIND, BUMONCD, KCPSTATUS, GENERATEFLG, HTLNM1, HTLNM2, SPFLG, NEWFLG, UPDID, UPDYMD) "
            strSQL = strSQL & "SELECT GOODSCD, GOODSNMJ, GOODSNMJ2, GOODSNMJ3, GOODSNMJ4, JEXPNOTEJ, IMAGEDATA, PRICE, UNITJ, SELLFLG, SCPNO01, SCPNO02, SCPNO03, SCPNO04, SCPNO05, SCPNO06, SCPNO07, SCPNO08, SCPNO09, SCPNO10, SCPNO11, SCPNO12, STATUS, GOODSKIND, BUMONCD, KCPSTATUS, GENERATEFLG, HTLNM1, HTLNM2, SPFLG, NEWFLG, UPDID, UPDYMD FROM #outer A "
            strSQL = strSQL & "WHERE NOT EXISTS ( SELECT * FROM TPM010 B WHERE A.GOODSCD = B.GOODSCD) "
        Else
            targetPrgLabel.Text = "�ꊇ�C���|�[�g�FTPM350"
            strSQL = strSQL & "BULK INSERT TPM350 "
            strSQL = strSQL & "FROM '" & pPutPath & "\TableData\TPM350.txt' "
            strSQL = strSQL & "WITH (fieldterminator = ',',rowterminator='\n') "
        End If

        strSQL = strSQL.Replace("/", "\")

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        If pmode Then
            If Trim$(GF_GetAppInfo2("MULTI_LING_USE")) = "1" Then
                targetPrgLabel.Text = "�ꊇ�C���|�[�g�FTPM010A"
                strSQL = ""
                strSQL = strSQL & "IF OBJECT_ID('tempdb.dbo.#outer', 'U') IS NOT NULL "
                strSQL = strSQL & "DROP TABLE #outer; "
                strSQL = strSQL & "CREATE TABLE #outer( "
                strSQL = strSQL & "[GOODSCD] [char](5), [GOODSNMJ] [varchar](20), [GOODSNMJ2] [varchar](20), [JEXPNOTEJ] [varchar](180), [UPDID] [char](10), [UPDYMD] [datetime]); "
                strSQL = strSQL & "DECLARE @sql NVARCHAR(MAX); "
                strSQL = strSQL & "SET @sql = N'SET NOCOUNT ON; "
                strSQL = strSQL & "CREATE TABLE #inner( "
                strSQL = strSQL & "[GOODSCD] [char](50), [GOODSNMJ] [varchar](200), [GOODSNMJ2] [varchar](200), [JEXPNOTEJ] [varchar](1800), [UPDID] [char](100), [UPDYMD] [datetime]); "
                strSQL = strSQL & "BULK INSERT #inner "
                strSQL = strSQL & " FROM ''" & pPutPath & "\TableData\TPM010A.csv'' "
                strSQL = strSQL & "WITH(fieldterminator = '','',rowterminator=''\n''); "
                strSQL = strSQL & "CREATE TABLE #innertwo([GOODSCD] [char](5), "
                strSQL = strSQL & "[DELIVARYFLG] [char](1), "
                strSQL = strSQL & "[UPDID] [char](10), "
                strSQL = strSQL & "[UPDYMD] [datetime]); "
                strSQL = strSQL & "BULK INSERT #innertwo "
                strSQL = strSQL & "FROM ''" & pPutPath & "\TableData\TPM350.txt'' "
                strSQL = strSQL & "WITH(fieldterminator = '','',rowterminator=''\n''); "
                strSQL = strSQL & "SELECT RTRIM(#inner.GOODSCD), RTRIM(#inner.GOODSNMJ), RTRIM(#inner.GOODSNMJ2), RTRIM(#inner.JEXPNOTEJ), RTRIM(#inner.UPDID), RTRIM(#inner.UPDYMD) "
                strSQL = strSQL & "FROM #inner INNER JOIN #innertwo on #inner.GOODSCD = #innertwo.GOODSCD where #innertwo.DELIVARYFLG = ''1'''; "
                strSQL = strSQL & "INSERT #outer EXEC master.sys.sp_executesql @sql; "
                strSQL = strSQL & "INSERT INTO TPM010A (GOODSCD, GOODSNMJ, GOODSNMJ2, JEXPNOTEJ, UPDID, UPDYMD) "
                strSQL = strSQL & "SELECT GOODSCD, GOODSNMJ, GOODSNMJ2, JEXPNOTEJ, UPDID, UPDYMD FROM #outer A "
                strSQL = strSQL & "WHERE NOT EXISTS ( SELECT * FROM TPM010A B WHERE A.GOODSCD = B.GOODSCD) "

                strSQL = strSQL.Replace("/", "\")

                If Not GF_UpdCmtData(strSQL) Then
                    Exit Function
                End If

                targetPrgLabel.Text = "�ꊇ�C���|�[�g�FTPM010B"
                strSQL = ""
                strSQL = strSQL & "IF OBJECT_ID('tempdb.dbo.#outer', 'U') IS NOT NULL "
                strSQL = strSQL & "DROP TABLE #outer; "
                strSQL = strSQL & "CREATE TABLE #outer( "
                strSQL = strSQL & "[GOODSCD] [char](5), [GOODSNMJ] [varchar](20), [GOODSNMJ2] [varchar](20), [JEXPNOTEJ] [varchar](180), [UPDID] [char](10), [UPDYMD] [datetime]); "
                strSQL = strSQL & "DECLARE @sql NVARCHAR(MAX); "
                strSQL = strSQL & "SET @sql = N'SET NOCOUNT ON; "
                strSQL = strSQL & "CREATE TABLE #inner( "
                strSQL = strSQL & "[GOODSCD] [char](50), [GOODSNMJ] [varchar](200), [GOODSNMJ2] [varchar](200), [JEXPNOTEJ] [varchar](1800), [UPDID] [char](100), [UPDYMD] [datetime]); "
                strSQL = strSQL & "BULK INSERT #inner "
                strSQL = strSQL & " FROM ''" & pPutPath & "\TableData\TPM010B.csv'' "
                strSQL = strSQL & "WITH(fieldterminator = '','',rowterminator=''\n''); "
                strSQL = strSQL & "CREATE TABLE #innertwo([GOODSCD] [char](5), "
                strSQL = strSQL & "[DELIVARYFLG] [char](1), "
                strSQL = strSQL & "[UPDID] [char](10), "
                strSQL = strSQL & "[UPDYMD] [datetime]); "
                strSQL = strSQL & "BULK INSERT #innertwo "
                strSQL = strSQL & "FROM ''" & pPutPath & "\TableData\TPM350.txt'' "
                strSQL = strSQL & "WITH(fieldterminator = '','',rowterminator=''\n''); "
                strSQL = strSQL & "SELECT RTRIM(#inner.GOODSCD), RTRIM(#inner.GOODSNMJ), RTRIM(#inner.GOODSNMJ2), RTRIM(#inner.JEXPNOTEJ), RTRIM(#inner.UPDID), RTRIM(#inner.UPDYMD) "
                strSQL = strSQL & "FROM #inner INNER JOIN #innertwo on #inner.GOODSCD = #innertwo.GOODSCD where #innertwo.DELIVARYFLG = ''1'''; "
                strSQL = strSQL & "INSERT #outer EXEC master.sys.sp_executesql @sql; "
                strSQL = strSQL & "INSERT INTO TPM010B (GOODSCD, GOODSNMJ, GOODSNMJ2, JEXPNOTEJ, UPDID, UPDYMD) "
                strSQL = strSQL & "SELECT GOODSCD, GOODSNMJ, GOODSNMJ2, JEXPNOTEJ, UPDID, UPDYMD FROM #outer A "
                strSQL = strSQL & "WHERE NOT EXISTS ( SELECT * FROM TPM010B B WHERE A.GOODSCD = B.GOODSCD) "

                strSQL = strSQL.Replace("/", "\")

                If Not GF_UpdCmtData(strSQL) Then
                    Exit Function
                End If

                targetPrgLabel.Text = "�ꊇ�C���|�[�g�FTPM010C"
                strSQL = ""
                strSQL = strSQL & "IF OBJECT_ID('tempdb.dbo.#outer', 'U') IS NOT NULL "
                strSQL = strSQL & "DROP TABLE #outer; "
                strSQL = strSQL & "CREATE TABLE #outer( "
                strSQL = strSQL & "[GOODSCD] [char](5), [GOODSNMJ] [varchar](20), [GOODSNMJ2] [varchar](20), [JEXPNOTEJ] [varchar](180), [UPDID] [char](10), [UPDYMD] [datetime]); "
                strSQL = strSQL & "DECLARE @sql NVARCHAR(MAX); "
                strSQL = strSQL & "SET @sql = N'SET NOCOUNT ON; "
                strSQL = strSQL & "CREATE TABLE #inner( "
                strSQL = strSQL & "[GOODSCD] [char](50), [GOODSNMJ] [varchar](200), [GOODSNMJ2] [varchar](200), [JEXPNOTEJ] [varchar](1800), [UPDID] [char](100), [UPDYMD] [datetime]); "
                strSQL = strSQL & "BULK INSERT #inner "
                strSQL = strSQL & " FROM ''" & pPutPath & "\TableData\TPM010C.csv'' "
                strSQL = strSQL & "WITH(fieldterminator = '','',rowterminator=''\n''); "
                strSQL = strSQL & "CREATE TABLE #innertwo([GOODSCD] [char](5), "
                strSQL = strSQL & "[DELIVARYFLG] [char](1), "
                strSQL = strSQL & "[UPDID] [char](10), "
                strSQL = strSQL & "[UPDYMD] [datetime]); "
                strSQL = strSQL & "BULK INSERT #innertwo "
                strSQL = strSQL & "FROM ''" & pPutPath & "\TableData\TPM350.txt'' "
                strSQL = strSQL & "WITH(fieldterminator = '','',rowterminator=''\n''); "
                strSQL = strSQL & "SELECT RTRIM(#inner.GOODSCD), RTRIM(#inner.GOODSNMJ), RTRIM(#inner.GOODSNMJ2), RTRIM(#inner.JEXPNOTEJ), RTRIM(#inner.UPDID), RTRIM(#inner.UPDYMD) "
                strSQL = strSQL & "FROM #inner INNER JOIN #innertwo on #inner.GOODSCD = #innertwo.GOODSCD where #innertwo.DELIVARYFLG = ''1'''; "
                strSQL = strSQL & "INSERT #outer EXEC master.sys.sp_executesql @sql; "
                strSQL = strSQL & "INSERT INTO TPM010C (GOODSCD, GOODSNMJ, GOODSNMJ2, JEXPNOTEJ, UPDID, UPDYMD) "
                strSQL = strSQL & "SELECT GOODSCD, GOODSNMJ, GOODSNMJ2, JEXPNOTEJ, UPDID, UPDYMD FROM #outer A "
                strSQL = strSQL & "WHERE NOT EXISTS ( SELECT * FROM TPM010C B WHERE A.GOODSCD = B.GOODSCD) "

                strSQL = strSQL.Replace("/", "\")

                If Not GF_UpdCmtData(strSQL) Then
                    Exit Function
                End If
            End If
        End If

        LS_ImportCommandLimited = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�o�͕�����\������
    ' �@�@�\�T�v�F�ȗ�
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2017.10.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    '�s���o�͂���邽�тɌĂяo�����
    Private Sub p_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs)
        '�o�͂��ꂽ�������\������
        Console.WriteLine(e.Data)
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F������؂��菈��
    ' �@�@�\�T�v�F������̉E�[����w�肵�����������̕������Ԃ�
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2017.10.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LS_Right(ByVal stTarget As String, ByVal iLength As Integer) As String

        If iLength <= stTarget.Length Then
            Return stTarget.Substring(stTarget.Length - iLength)
        End If

        Return stTarget

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�o�b�N�A�b�v�f�[�^�`�F�b�N����
    ' �@�@�\�T�v�F�o�b�N�A�b�v�f�[�^���I������Ă��邩�`�F�b�N���s��
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F�Ȃ�
    ' �@���@�@���F2017.10.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LS_chkPath() As Boolean

        Dim strChkPath As String = ""

        LS_chkPath = False

        If Not lbl_Path.Text.Length <> 0 Then
            Exit Function
        Else

            strChkPath = LS_Right(lbl_Path.Text, 27)

            If Not strChkPath.Contains("BackUpData") Then
                Exit Function
            Else
                If Not System.IO.Directory.Exists(lbl_Path.Text & "\ImageData") Then
                    Exit Function
                Else
                    If Not System.IO.Directory.Exists(lbl_Path.Text & "\TableData") Then
                        Exit Function
                    Else
                        LS_chkPath = True
                    End If
                End If
            End If
        End If

    End Function
    ' 2017.10.01 �{���z�M �N���X�R�k�� �c��

    ' 2017.11.01 �{���z�M �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���ʁE����E�P���f�[�^�擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.11.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetSalesDATA(ByRef pDataSet As DataSet, ByVal pmode As Integer, ByVal pTransDate As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetSalesDATA = False

        '------------------------------
        ' SQL�g��
        '------------------------------
        strSQL = ""
        If pmode = 1 Then
            strSQL = strSQL & " SELECT TPM010.GOODSCD AS '���i�ԍ� ���ʏ�',"
        ElseIf pmode = 2 Then
            strSQL = strSQL & " SELECT TPM010.GOODSCD AS '���i�ԍ� ���㏇',"
        ElseIf pmode = 3 Then
            strSQL = strSQL & " SELECT TPM010.GOODSCD AS '���i�ԍ� �P����',"
        End If
        strSQL = strSQL & "        MAX(LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ, '�@', ' '))) + LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ2, '�@', ' ')))) AS '���i����',"
        strSQL = strSQL & "        TPM010.PRICE AS '�P��',"
        strSQL = strSQL & "        ISNULL(SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END),0) AS '���㐔��',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 09 THEN TPD010.QUANTITY ELSE '0' END) AS '9:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 10 THEN TPD010.QUANTITY ELSE '0' END) AS '10:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 11 THEN TPD010.QUANTITY ELSE '0' END) AS '11:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 12 THEN TPD010.QUANTITY ELSE '0' END) AS '12:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 13 THEN TPD010.QUANTITY ELSE '0' END) AS '13:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 14 THEN TPD010.QUANTITY ELSE '0' END) AS '14:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 15 THEN TPD010.QUANTITY ELSE '0' END) AS '15:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 16 THEN TPD010.QUANTITY ELSE '0' END) AS '16:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 17 THEN TPD010.QUANTITY ELSE '0' END) AS '17:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 18 THEN TPD010.QUANTITY ELSE '0' END) AS '18:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 19 THEN TPD010.QUANTITY ELSE '0' END) AS '19:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 20 THEN TPD010.QUANTITY ELSE '0' END) AS '20:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 21 THEN TPD010.QUANTITY ELSE '0' END) AS '21:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 22 THEN TPD010.QUANTITY ELSE '0' END) AS '22:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 23 THEN TPD010.QUANTITY ELSE '0' END) AS '23:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 00 THEN TPD010.QUANTITY ELSE '0' END) AS '0:00',"
        'strSQL = strSQL & "        SUM(CASE WHEN LEN(CONVERT(CHAR,TPD010.TRANSTIME)) = 1 THEN '0' WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 00 THEN TPD010.QUANTITY ELSE '0' END) AS '0:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 01 THEN TPD010.QUANTITY ELSE '0' END) AS '1:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 02 THEN TPD010.QUANTITY ELSE '0' END) AS '2:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 03 THEN TPD010.QUANTITY ELSE '0' END) AS '3:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 04 THEN TPD010.QUANTITY ELSE '0' END) AS '4:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 05 THEN TPD010.QUANTITY ELSE '0' END) AS '5:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 06 THEN TPD010.QUANTITY ELSE '0' END) AS '6:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 07 THEN TPD010.QUANTITY ELSE '0' END) AS '7:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 08 THEN TPD010.QUANTITY ELSE '0' END) AS '8:00',"
        strSQL = strSQL & "        ISNULL((SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END) * MAX(TPM010.PRICE)),0) AS '������z'"
        strSQL = strSQL & "   FROM TPM010 LEFT JOIN TPD010 ON TPM010.GOODSCD = TPD010.GOODSCD"
        'strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999 AND TPM010.PRICE > 0 AND TPD010.ORDERTIME <> '99999999999999' AND TPD010.TRANSTIME <> '99999999999999'"
        strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999 AND TPD010.ORDERTIME <> '99999999999999' AND TPD010.TRANSTIME <> '99999999999999'"  ' ���i 0�~�Ή�
        strSQL = strSQL & "     AND TPD010.TRANSTIME >= '" & pTransDate & "090000'"
        strSQL = strSQL & "     AND TPD010.TRANSTIME <= '" & DateTime.Parse(pTransDate.Substring(0, 4) & "/" & pTransDate.Substring(4, 2) & "/" & pTransDate.Substring(6, 2)).AddDays(1).ToString("yyyyMMdd") & "085959'"
        strSQL = strSQL & " GROUP BY TPM010.GOODSCD,TPM010.PRICE"

        If pmode = 1 Then
            strSQL = strSQL & " ORDER BY ���㐔�� DESC"
        ElseIf pmode = 2 Then
            strSQL = strSQL & " ORDER BY ������z DESC"
        ElseIf pmode = 3 Then
            strSQL = strSQL & " ORDER BY �P�� DESC"
        End If



        '------------------------------
        ' �f�[�^�擾
        '------------------------------
        If Not GF_GetData(strSQL, pDataSet) Then
            Call GF_Msg("", "DB�ڑ��Ɏ��s���܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            Exit Function
        End If

        If pDataSet.Tables("com").Rows.Count = 0 Then
            'Call GF_Msg("", "�Ώۃf�[�^������܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            LF_GetSalesDATA = True
            Exit Function
        End If

        LF_GetSalesDATA = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�������f�[�^�擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.11.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetCostDATA(ByRef pDataSet As DataSet, ByVal pTransDate As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetCostDATA = False

        '------------------------------
        ' SQL�g��
        '------------------------------
        strSQL = ""
        strSQL = strSQL & " SELECT TPM010.GOODSCD AS '���i�ԍ�',"
        strSQL = strSQL & "        MAX(LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ, '�@', ' '))) + LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ2, '�@', ' ')))) AS '���i����',"
        'strSQL = strSQL & "        CONVERT(varchar,ISNULL(((TPM340.COST / TPM010.PRICE) * 100),0)) AS '������',"
        strSQL = strSQL & "        CONVERT(varchar,CASE WHEN TPM010.PRICE=0 THEN '0' ELSE ISNULL(((TPM340.COST / TPM010.PRICE) * 100),0) END) AS '������'," ' 0�~���i�Ή�
        strSQL = strSQL & "        ISNULL(SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END),0) AS '���㐔��',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 09 THEN TPD010.QUANTITY ELSE '0' END) AS '9:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 10 THEN TPD010.QUANTITY ELSE '0' END) AS '10:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 11 THEN TPD010.QUANTITY ELSE '0' END) AS '11:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 12 THEN TPD010.QUANTITY ELSE '0' END) AS '12:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 13 THEN TPD010.QUANTITY ELSE '0' END) AS '13:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 14 THEN TPD010.QUANTITY ELSE '0' END) AS '14:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 15 THEN TPD010.QUANTITY ELSE '0' END) AS '15:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 16 THEN TPD010.QUANTITY ELSE '0' END) AS '16:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 17 THEN TPD010.QUANTITY ELSE '0' END) AS '17:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 18 THEN TPD010.QUANTITY ELSE '0' END) AS '18:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 19 THEN TPD010.QUANTITY ELSE '0' END) AS '19:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 20 THEN TPD010.QUANTITY ELSE '0' END) AS '20:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 21 THEN TPD010.QUANTITY ELSE '0' END) AS '21:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 22 THEN TPD010.QUANTITY ELSE '0' END) AS '22:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 23 THEN TPD010.QUANTITY ELSE '0' END) AS '23:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 00 THEN TPD010.QUANTITY ELSE '0' END) AS '0:00',"
        'strSQL = strSQL & "        SUM(CASE WHEN LEN(CONVERT(CHAR,TPD010.TRANSTIME)) = 1 THEN '0' WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 00 THEN TPD010.QUANTITY ELSE '0' END) AS '0:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 01 THEN TPD010.QUANTITY ELSE '0' END) AS '1:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 02 THEN TPD010.QUANTITY ELSE '0' END) AS '2:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 03 THEN TPD010.QUANTITY ELSE '0' END) AS '3:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 04 THEN TPD010.QUANTITY ELSE '0' END) AS '4:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 05 THEN TPD010.QUANTITY ELSE '0' END) AS '5:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 06 THEN TPD010.QUANTITY ELSE '0' END) AS '6:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 07 THEN TPD010.QUANTITY ELSE '0' END) AS '7:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 08 THEN TPD010.QUANTITY ELSE '0' END) AS '8:00',"
        strSQL = strSQL & "        ISNULL((SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END) * MAX(TPM010.PRICE)),0) AS '������z'"
        strSQL = strSQL & "   FROM TPM010 LEFT JOIN TPD010 ON TPM010.GOODSCD = TPD010.GOODSCD LEFT JOIN TPM340 ON TPD010.GOODSCD = TPM340.GOODSCD"
        'strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999 AND TPM010.PRICE > 0 AND TPD010.ORDERTIME <> '99999999999999' AND TPD010.TRANSTIME <> '99999999999999'"
        strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999  AND TPD010.ORDERTIME <> '99999999999999' AND TPD010.TRANSTIME <> '99999999999999'" ' 0�~���i�Ή�
        strSQL = strSQL & "     AND TPD010.TRANSTIME >= '" & pTransDate & "090000'"
        strSQL = strSQL & "     AND TPD010.TRANSTIME <= '" & DateTime.Parse(pTransDate.Substring(0, 4) & "/" & pTransDate.Substring(4, 2) & "/" & pTransDate.Substring(6, 2)).AddDays(1).ToString("yyyyMMdd") & "085959'"
        strSQL = strSQL & " GROUP BY TPM010.GOODSCD,TPM010.PRICE,TPM340.COST"
        strSQL = strSQL & " ORDER BY ������ DESC"

        '------------------------------
        ' �f�[�^�擾
        '------------------------------
        If Not GF_GetData(strSQL, pDataSet) Then
            Call GF_Msg("", "DB�ڑ��Ɏ��s���܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            Exit Function
        End If

        If pDataSet.Tables("com").Rows.Count = 0 Then
            'Call GF_Msg("", "�Ώۃf�[�^������܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            LF_GetCostDATA = True
            Exit Function
        End If

        LF_GetCostDATA = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�e���z�f�[�^�擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.11.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetArariGakuDATA(ByRef pDataSet As DataSet, ByVal pTransDate As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetArariGakuDATA = False

        '------------------------------
        ' SQL�g��
        '------------------------------
        strSQL = ""
        strSQL = strSQL & " SELECT TPM010.GOODSCD AS '���i�ԍ�',"
        strSQL = strSQL & "        MAX(LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ, '�@', ' '))) + LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ2, '�@', ' ')))) AS '���i����',"
        strSQL = strSQL & "        ISNULL(((TPM010.PRICE - TPM340.COST) * ISNULL(SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END),0)),0) AS '�e���z',"
        strSQL = strSQL & "        ISNULL(SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END),0) AS '���㐔��',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 09 THEN TPD010.QUANTITY ELSE '0' END) AS '9:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 10 THEN TPD010.QUANTITY ELSE '0' END) AS '10:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 11 THEN TPD010.QUANTITY ELSE '0' END) AS '11:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 12 THEN TPD010.QUANTITY ELSE '0' END) AS '12:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 13 THEN TPD010.QUANTITY ELSE '0' END) AS '13:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 14 THEN TPD010.QUANTITY ELSE '0' END) AS '14:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 15 THEN TPD010.QUANTITY ELSE '0' END) AS '15:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 16 THEN TPD010.QUANTITY ELSE '0' END) AS '16:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 17 THEN TPD010.QUANTITY ELSE '0' END) AS '17:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 18 THEN TPD010.QUANTITY ELSE '0' END) AS '18:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 19 THEN TPD010.QUANTITY ELSE '0' END) AS '19:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 20 THEN TPD010.QUANTITY ELSE '0' END) AS '20:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 21 THEN TPD010.QUANTITY ELSE '0' END) AS '21:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 22 THEN TPD010.QUANTITY ELSE '0' END) AS '22:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 23 THEN TPD010.QUANTITY ELSE '0' END) AS '23:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 00 THEN TPD010.QUANTITY ELSE '0' END) AS '0:00',"
        'strSQL = strSQL & "        SUM(CASE WHEN LEN(CONVERT(CHAR,TPD010.TRANSTIME)) = 1 THEN '0' WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 00 THEN TPD010.QUANTITY ELSE '0' END) AS '0:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 01 THEN TPD010.QUANTITY ELSE '0' END) AS '1:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 02 THEN TPD010.QUANTITY ELSE '0' END) AS '2:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 03 THEN TPD010.QUANTITY ELSE '0' END) AS '3:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 04 THEN TPD010.QUANTITY ELSE '0' END) AS '4:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 05 THEN TPD010.QUANTITY ELSE '0' END) AS '5:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 06 THEN TPD010.QUANTITY ELSE '0' END) AS '6:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 07 THEN TPD010.QUANTITY ELSE '0' END) AS '7:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 08 THEN TPD010.QUANTITY ELSE '0' END) AS '8:00',"
        strSQL = strSQL & "        ISNULL((SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END) * MAX(TPM010.PRICE)),0) AS '������z'"
        strSQL = strSQL & "   FROM TPM010 LEFT JOIN TPD010 ON TPM010.GOODSCD = TPD010.GOODSCD LEFT JOIN TPM340 ON TPD010.GOODSCD = TPM340.GOODSCD"
        'strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999 AND TPM010.PRICE > 0 AND TPD010.ORDERTIME <> '99999999999999' AND TPD010.TRANSTIME <> '99999999999999'"
        strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999 AND TPD010.ORDERTIME <> '99999999999999' AND TPD010.TRANSTIME <> '99999999999999'" ' 0�~���i�Ή�
        strSQL = strSQL & "     AND TPD010.TRANSTIME >= '" & pTransDate & "090000'"
        strSQL = strSQL & "     AND TPD010.TRANSTIME <= '" & DateTime.Parse(pTransDate.Substring(0, 4) & "/" & pTransDate.Substring(4, 2) & "/" & pTransDate.Substring(6, 2)).AddDays(1).ToString("yyyyMMdd") & "085959'"
        strSQL = strSQL & " GROUP BY TPM010.GOODSCD,TPM010.PRICE,TPM340.COST"
        strSQL = strSQL & " ORDER BY �e���z DESC"

        '------------------------------
        ' �f�[�^�擾
        '------------------------------
        If Not GF_GetData(strSQL, pDataSet) Then
            Call GF_Msg("", "DB�ڑ��Ɏ��s���܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            Exit Function
        End If

        If pDataSet.Tables("com").Rows.Count = 0 Then
            'Call GF_Msg("", "�Ώۃf�[�^������܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            LF_GetArariGakuDATA = True
            Exit Function
        End If

        LF_GetArariGakuDATA = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�e�����f�[�^�擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.11.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetArariRituDATA(ByRef pDataSet As DataSet, ByVal pTransDate As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetArariRituDATA = False

        '------------------------------
        ' SQL�g��
        '------------------------------
        strSQL = ""
        strSQL = strSQL & " SELECT TPM010.GOODSCD AS '���i�ԍ�',"
        strSQL = strSQL & "        MAX(LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ, '�@', ' '))) + LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ2, '�@', ' ')))) AS '���i����',"
        'strSQL = strSQL & "        CONVERT(varchar,ISNULL(ROUND((((TPM010.PRICE - TPM340.COST) / TPM010.PRICE) * 100),3),0)) AS '�e����',"
        strSQL = strSQL & "        CONVERT(varchar,CASE WHEN TPM010.PRICE=0 THEN '0' ELSE ISNULL(ROUND((((TPM010.PRICE - TPM340.COST) / TPM010.PRICE) * 100),3),0)END) AS '�e����',"
        strSQL = strSQL & "        ISNULL(SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END),0) AS '���㐔��',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 09 THEN TPD010.QUANTITY ELSE '0' END) AS '9:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 10 THEN TPD010.QUANTITY ELSE '0' END) AS '10:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 11 THEN TPD010.QUANTITY ELSE '0' END) AS '11:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 12 THEN TPD010.QUANTITY ELSE '0' END) AS '12:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 13 THEN TPD010.QUANTITY ELSE '0' END) AS '13:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 14 THEN TPD010.QUANTITY ELSE '0' END) AS '14:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 15 THEN TPD010.QUANTITY ELSE '0' END) AS '15:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 16 THEN TPD010.QUANTITY ELSE '0' END) AS '16:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 17 THEN TPD010.QUANTITY ELSE '0' END) AS '17:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 18 THEN TPD010.QUANTITY ELSE '0' END) AS '18:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 19 THEN TPD010.QUANTITY ELSE '0' END) AS '19:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 20 THEN TPD010.QUANTITY ELSE '0' END) AS '20:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 21 THEN TPD010.QUANTITY ELSE '0' END) AS '21:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 22 THEN TPD010.QUANTITY ELSE '0' END) AS '22:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 23 THEN TPD010.QUANTITY ELSE '0' END) AS '23:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 00 THEN TPD010.QUANTITY ELSE '0' END) AS '0:00',"
        'strSQL = strSQL & "        SUM(CASE WHEN LEN(CONVERT(CHAR,TPD010.TRANSTIME)) = 1 THEN '0' WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 00 THEN TPD010.QUANTITY ELSE '0' END) AS '0:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 01 THEN TPD010.QUANTITY ELSE '0' END) AS '1:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 02 THEN TPD010.QUANTITY ELSE '0' END) AS '2:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 03 THEN TPD010.QUANTITY ELSE '0' END) AS '3:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 04 THEN TPD010.QUANTITY ELSE '0' END) AS '4:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 05 THEN TPD010.QUANTITY ELSE '0' END) AS '5:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 06 THEN TPD010.QUANTITY ELSE '0' END) AS '6:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 07 THEN TPD010.QUANTITY ELSE '0' END) AS '7:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 08 THEN TPD010.QUANTITY ELSE '0' END) AS '8:00',"
        strSQL = strSQL & "        ISNULL((SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END) * MAX(TPM010.PRICE)),0) AS '������z'"
        strSQL = strSQL & "   FROM TPM010 LEFT JOIN TPD010 ON TPM010.GOODSCD = TPD010.GOODSCD LEFT JOIN TPM340 ON TPD010.GOODSCD = TPM340.GOODSCD"
        'strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999 AND TPM010.PRICE > 0 AND TPD010.ORDERTIME <> '99999999999999' AND TPD010.TRANSTIME <> '99999999999999'"
        strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999 AND TPD010.ORDERTIME <> '99999999999999' AND TPD010.TRANSTIME <> '99999999999999'" ' 0�~���i�Ή�
        strSQL = strSQL & "     AND TPD010.TRANSTIME >= '" & pTransDate & "090000'"
        strSQL = strSQL & "     AND TPD010.TRANSTIME <= '" & DateTime.Parse(pTransDate.Substring(0, 4) & "/" & pTransDate.Substring(4, 2) & "/" & pTransDate.Substring(6, 2)).AddDays(1).ToString("yyyyMMdd") & "085959'"
        strSQL = strSQL & " GROUP BY TPM010.GOODSCD,TPM010.PRICE,TPM340.COST"
        strSQL = strSQL & " ORDER BY �e���� DESC"

        '------------------------------
        ' �f�[�^�擾
        '------------------------------
        If Not GF_GetData(strSQL, pDataSet) Then
            Call GF_Msg("", "DB�ڑ��Ɏ��s���܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            Exit Function
        End If

        If pDataSet.Tables("com").Rows.Count = 0 Then
            'Call GF_Msg("", "�Ώۃf�[�^������܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            LF_GetArariRituDATA = True
            Exit Function
        End If

        LF_GetArariRituDATA = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�����f�[�^�擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.11.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetRecords(ByRef pDataSet As DataSet, ByVal pTransDate As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetRecords = False

        '------------------------------
        ' SQL�g��
        '------------------------------
        strSQL = ""
        strSQL = strSQL & " SELECT TPM050.SEATID AS '�~�[�[��',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 09 THEN TPD011.QUANTITY ELSE '0' END) AS '9:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 10 THEN TPD011.QUANTITY ELSE '0' END) AS '10:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 11 THEN TPD011.QUANTITY ELSE '0' END) AS '11:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 12 THEN TPD011.QUANTITY ELSE '0' END) AS '12:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 13 THEN TPD011.QUANTITY ELSE '0' END) AS '13:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 14 THEN TPD011.QUANTITY ELSE '0' END) AS '14:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 15 THEN TPD011.QUANTITY ELSE '0' END) AS '15:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 16 THEN TPD011.QUANTITY ELSE '0' END) AS '16:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 17 THEN TPD011.QUANTITY ELSE '0' END) AS '17:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 18 THEN TPD011.QUANTITY ELSE '0' END) AS '18:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 19 THEN TPD011.QUANTITY ELSE '0' END) AS '19:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 20 THEN TPD011.QUANTITY ELSE '0' END) AS '20:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 21 THEN TPD011.QUANTITY ELSE '0' END) AS '21:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 22 THEN TPD011.QUANTITY ELSE '0' END) AS '22:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 23 THEN TPD011.QUANTITY ELSE '0' END) AS '23:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 00 THEN TPD011.QUANTITY ELSE '0' END) AS '0:00',"
        'strSQL = strSQL & "        SUM(CASE WHEN LEN(CONVERT(CHAR,TPD011.TRANSTIME)) = 1 THEN '0' WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 00 THEN TPD011.QUANTITY ELSE '0' END) AS '0:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 01 THEN TPD011.QUANTITY ELSE '0' END) AS '1:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 02 THEN TPD011.QUANTITY ELSE '0' END) AS '2:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 03 THEN TPD011.QUANTITY ELSE '0' END) AS '3:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 04 THEN TPD011.QUANTITY ELSE '0' END) AS '4:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 05 THEN TPD011.QUANTITY ELSE '0' END) AS '5:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 06 THEN TPD011.QUANTITY ELSE '0' END) AS '6:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 07 THEN TPD011.QUANTITY ELSE '0' END) AS '7:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 08 THEN TPD011.QUANTITY ELSE '0' END) AS '8:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 09 OR SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 10 OR SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 11 OR"
        strSQL = strSQL & "                      SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 12 OR SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 13 OR SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 14 OR"
        strSQL = strSQL & "                      SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 15 OR SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 16 OR SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 17 OR"
        strSQL = strSQL & "                      SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 18 OR SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 19 OR SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 20 OR"
        strSQL = strSQL & "                      SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 21 OR SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 22 OR SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 23 OR"
        strSQL = strSQL & "                      SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 00 OR SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 01 OR SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 02 OR"
        strSQL = strSQL & "                      SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 03 OR SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 04 OR SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 05 OR"
        strSQL = strSQL & "                      SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 06 OR SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 07 OR SUBSTRING(CONVERT(CHAR,TPD011.TRANSTIME), 9, 2) = 08"
        strSQL = strSQL & "                      THEN TPD011.QUANTITY ELSE '0' END) AS '���v'"
        strSQL = strSQL & " FROM TPM050 LEFT JOIN TPD011 ON TPM050.TERMID = TPD011.RTERMID"
        strSQL = strSQL & "                             AND TPD011.ORDERTIME <> '99999999999999'"
        strSQL = strSQL & "                             AND TPD011.TRANSTIME <> '99999999999999'"
        strSQL = strSQL & "                             AND TPD011.TRANSTIME >= '" & pTransDate & "090000'"
        strSQL = strSQL & "                             AND TPD011.TRANSTIME <= '" & DateTime.Parse(pTransDate.Substring(0, 4) & "/" & pTransDate.Substring(4, 2) & "/" & pTransDate.Substring(6, 2)).AddDays(1).ToString("yyyyMMdd") & "085959'"
        strSQL = strSQL & " WHERE TPM050.TERMKIND = 'TCQ'"
        strSQL = strSQL & "  OR  (TPD011.GOODSCD >= '0000'"
        strSQL = strSQL & "  AND TPD011.GOODSCD <= '8999')"
        strSQL = strSQL & " GROUP BY TPM050.SEATID "
        strSQL = strSQL & " ORDER BY TPM050.SEATID"

        '------------------------------
        ' �f�[�^�擾
        '------------------------------
        If Not GF_GetData(strSQL, pDataSet) Then
            Call GF_Msg("", "DB�ڑ��Ɏ��s���܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            Exit Function
        End If

        If pDataSet.Tables("com").Rows.Count = 0 Then
            'Call GF_Msg("", "�Ώۃf�[�^������܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            LF_GetRecords = True
            Exit Function
        End If

        LF_GetRecords = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F����f�[�^�W�v����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.11.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetSalesData2(ByRef pFilename As String, ByVal pTransDate As String, ByRef pFtp As Long) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim RowsCnt As Integer
        Dim ColmCnt As Integer
        Dim strCsvPath As String = ""
        Dim strEncoding As System.Text.Encoding
        Dim strStreamWriter As System.IO.StreamWriter = Nothing
        Dim strErrMsg As String = ""
        Dim fgNeedDQ As Boolean
        Dim strData As String

        strCsvPath = Trim$(GF_GetAppInfo("DELI_SALES_CSV_PATH")) & "uplode" & "\SalesData(" & pTransDate & Format(Now, "HHmmss") & ").csv"

        Try

            pFilename = strCsvPath

            '------------------------------
            ' �t�@�C�����ݒ�
            '------------------------------
            strEncoding = System.Text.Encoding.GetEncoding("Shift_JIS")
            strStreamWriter = New System.IO.StreamWriter(strCsvPath, False, strEncoding)

            For i As Integer = 1 To 6
                objData.Clear()
                objData.Tables.Clear()
                objRows = Nothing

                '------------------------------
                ' ���[�f�[�^�擾����
                '------------------------------
                Select Case i
                    Case 1 ' ���ʏ�
                        If Not LF_GetSalesDATA(objData, i, pTransDate) Then
                            Exit Function
                        End If
                    Case 2 ' ���㏇
                        If Not LF_GetSalesDATA(objData, i, pTransDate) Then
                            Exit Function
                        End If
                    Case 3 ' �P����
                        If Not LF_GetSalesDATA(objData, i, pTransDate) Then
                            Exit Function
                        End If
                    Case 4 ' ��������
                        If Not LF_GetCostDATA(objData, pTransDate) Then
                            Exit Function
                        End If
                    Case 5 ' �e���z��
                        If Not LF_GetArariGakuDATA(objData, pTransDate) Then
                            Exit Function
                        End If
                    Case 6 ' �e������
                        If Not LF_GetArariRituDATA(objData, pTransDate) Then
                            Exit Function
                        End If
                End Select

                '------------------------------
                ' �t�@�C���o��
                ' �Y���f�[�^���������CSV�o�͂��Ȃ�
                '------------------------------
                If objData.Tables("com").Rows.Count <> 0 Then

                    ColmCnt = 0
                    RowsCnt = 0

                    While ColmCnt < objData.Tables("com").Columns.Count
                        'If Not GF_GetRows(objData, RowsCnt, objRows) Then
                        '    Exit Function
                        'End If

                        ' 2020-02-15 -------------------------------------------------------------
                        'If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                        '    strStreamWriter.WriteLine(objData.Tables("com").Columns(ColmCnt))
                        'Else
                        '    strStreamWriter.Write(objData.Tables("com").Columns(ColmCnt))
                        '    strStreamWriter.Write(",")
                        'End If
                        fgNeedDQ = False
                        strData = objData.Tables("com").Columns(ColmCnt).ToString()
                        'System.Diagnostics.Debug.WriteLine(strData)
                        If strData.IndexOf(",") >= 0 Then
                            fgNeedDQ = True
                        End If
                        If strData.IndexOf("""") >= 0 Then
                            fgNeedDQ = True
                            strData = Replace(strData, """", """""", 1, -1, CompareMethod.Binary)
                        End If
                        If fgNeedDQ Then
                            strData = """" + strData + """"
                        End If
                        'System.Diagnostics.Debug.WriteLine(strData)
                        If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                            strStreamWriter.WriteLine(strData)
                        Else
                            strStreamWriter.Write(strData)
                            strStreamWriter.Write(",")
                        End If
                        ' ------------------------------------------------------------------------

                        ColmCnt = ColmCnt + 1
                    End While

                    ColmCnt = 0
                    RowsCnt = 0
                    While RowsCnt < objData.Tables("com").Rows.Count
                        If Not GF_GetRows(objData, RowsCnt, objRows) Then
                            Exit Function
                        End If

                        While ColmCnt < objData.Tables("com").Columns.Count
                            If Not GF_GetRows(objData, RowsCnt, objRows) Then
                                Exit Function
                            End If

                            ' 2020-02-15 -------------------------------------------------------------
                            'If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                            '    strStreamWriter.WriteLine(objData.Tables("com").Rows(RowsCnt)(ColmCnt))
                            'Else
                            '    strStreamWriter.Write(objData.Tables("com").Rows(RowsCnt)(ColmCnt) & ",")
                            'End If
                            fgNeedDQ = False
                            strData = objData.Tables("com").Rows(RowsCnt)(ColmCnt).ToString()
                            'System.Diagnostics.Debug.WriteLine(strData)
                            If strData.IndexOf(",") >= 0 Then
                                fgNeedDQ = True
                            End If
                            If strData.IndexOf("""") >= 0 Then
                                fgNeedDQ = True
                                strData = Replace(strData, """", """""", 1, -1, CompareMethod.Binary)
                            End If
                            If fgNeedDQ Then
                                strData = """" + strData + """"
                            End If
                            'System.Diagnostics.Debug.WriteLine(strData)
                            If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                                strStreamWriter.WriteLine(strData)
                            Else
                                strStreamWriter.Write(strData & ",")
                            End If

                            ColmCnt = ColmCnt + 1
                        End While

                        ColmCnt = 0
                        RowsCnt = RowsCnt + 1
                    End While

                    pFtp = 1
                End If
            Next


        Catch ex As Exception
            strStreamWriter.Close()
            '���g�����̃t�@�C���͍폜����

            If pFtp = 0 Then
                System.IO.File.Delete(strCsvPath)
            End If

            ' 2018.07.20 �G���[���b�Z�[�W��\�� 
            MsgBox("�t�@�C���̏o�͂Ɏ��s���܂����B(" & ex.Message & ")")

            Exit Function
        End Try

        strStreamWriter.Close()
        '���g�����̃t�@�C���͍폜����
        If pFtp = 0 Then
            System.IO.File.Delete(strCsvPath)
        End If

        LF_GetSalesData2 = True

        Exit Function
    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F����f�[�^�W�v����(�o�b�N�A�b�v)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2020.05.18 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetSalesDataBackup(ByRef pFilename As String, ByVal pTransDate As String, ByRef pFtp As Long) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim RowsCnt As Integer
        Dim ColmCnt As Integer
        Dim strCsvPath As String = ""
        Dim strEncoding As System.Text.Encoding
        Dim strStreamWriter As System.IO.StreamWriter = Nothing
        Dim strErrMsg As String = ""
        Dim fgNeedDQ As Boolean
        Dim strData As String

        strCsvPath = Trim$(GF_GetAppInfo("DELI_SALES_CSV_PATH")) & "\SalesData(" & pTransDate & Format(Now, "HHmmss") & ").csv"

        Try

            pFilename = strCsvPath

            '------------------------------
            ' �t�@�C�����ݒ�
            '------------------------------
            strEncoding = System.Text.Encoding.GetEncoding("Shift_JIS")
            strStreamWriter = New System.IO.StreamWriter(strCsvPath, False, strEncoding)

            For i As Integer = 1 To 6
                objData.Clear()
                objData.Tables.Clear()
                objRows = Nothing

                '------------------------------
                ' ���[�f�[�^�擾����
                '------------------------------
                Select Case i
                    Case 1 ' ���ʏ�
                        If Not LF_GetSalesDATA(objData, i, pTransDate) Then
                            Exit Function
                        End If
                    Case 2 ' ���㏇
                        If Not LF_GetSalesDATA(objData, i, pTransDate) Then
                            Exit Function
                        End If
                    Case 3 ' �P����
                        If Not LF_GetSalesDATA(objData, i, pTransDate) Then
                            Exit Function
                        End If
                    Case 4 ' ��������
                        If Not LF_GetCostDATA(objData, pTransDate) Then
                            Exit Function
                        End If
                    Case 5 ' �e���z��
                        If Not LF_GetArariGakuDATA(objData, pTransDate) Then
                            Exit Function
                        End If
                    Case 6 ' �e������
                        If Not LF_GetArariRituDATA(objData, pTransDate) Then
                            Exit Function
                        End If
                End Select

                '------------------------------
                ' �t�@�C���o��
                ' �Y���f�[�^���������CSV�o�͂��Ȃ�
                '------------------------------
                If objData.Tables("com").Rows.Count <> 0 Then

                    ColmCnt = 0
                    RowsCnt = 0

                    While ColmCnt < objData.Tables("com").Columns.Count
                        fgNeedDQ = False
                        strData = objData.Tables("com").Columns(ColmCnt).ToString()
                        If strData.IndexOf(",") >= 0 Then
                            fgNeedDQ = True
                        End If
                        If strData.IndexOf("""") >= 0 Then
                            fgNeedDQ = True
                            strData = Replace(strData, """", """""", 1, -1, CompareMethod.Binary)
                        End If
                        If fgNeedDQ Then
                            strData = """" + strData + """"
                        End If
                        If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                            strStreamWriter.WriteLine(strData)
                        Else
                            strStreamWriter.Write(strData)
                            strStreamWriter.Write(",")
                        End If
                        ' ------------------------------------------------------------------------

                        ColmCnt = ColmCnt + 1
                    End While

                    ColmCnt = 0
                    RowsCnt = 0
                    While RowsCnt < objData.Tables("com").Rows.Count
                        If Not GF_GetRows(objData, RowsCnt, objRows) Then
                            Exit Function
                        End If

                        While ColmCnt < objData.Tables("com").Columns.Count
                            If Not GF_GetRows(objData, RowsCnt, objRows) Then
                                Exit Function
                            End If

                            ' 2020-02-15 -------------------------------------------------------------
                            fgNeedDQ = False
                            strData = objData.Tables("com").Rows(RowsCnt)(ColmCnt).ToString()
                            If strData.IndexOf(",") >= 0 Then
                                fgNeedDQ = True
                            End If
                            If strData.IndexOf("""") >= 0 Then
                                fgNeedDQ = True
                                strData = Replace(strData, """", """""", 1, -1, CompareMethod.Binary)
                            End If
                            If fgNeedDQ Then
                                strData = """" + strData + """"
                            End If
                            If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                                strStreamWriter.WriteLine(strData)
                            Else
                                strStreamWriter.Write(strData & ",")
                            End If

                            ColmCnt = ColmCnt + 1
                        End While

                        ColmCnt = 0
                        RowsCnt = RowsCnt + 1
                    End While

                    pFtp = 1
                End If
            Next


        Catch ex As Exception
            strStreamWriter.Close()
            '���g�����̃t�@�C���͍폜����

            If pFtp = 0 Then
                System.IO.File.Delete(strCsvPath)
            End If

            ' 2018.07.20 �G���[���b�Z�[�W��\�� 
            MsgBox("�t�@�C���̏o�͂Ɏ��s���܂����B(" & ex.Message & ")")

            Exit Function
        End Try

        strStreamWriter.Close()
        '���g�����̃t�@�C���͍폜����
        If pFtp = 0 Then
            System.IO.File.Delete(strCsvPath)
        End If

        LF_GetSalesDataBackup = True

        Exit Function
    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�����f�[�^�W�v����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.11.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetRecordsDATA(ByRef pFilename As String, ByVal pTransDate As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim RowsCnt As Integer
        Dim ColmCnt As Integer
        Dim strCsvPath As String = ""
        Dim strEncoding As System.Text.Encoding
        Dim strStreamWriter As System.IO.StreamWriter = Nothing

        strCsvPath = Trim$(GF_GetAppInfo("DELI_RECORDS_PATH")) & "uplode" & "\RecordsData(" & pTransDate & Format(Now, "HHmmss") & ").csv"

        Try

            pFilename = strCsvPath

            '------------------------------
            ' �t�@�C�����ݒ�
            '------------------------------
            strEncoding = System.Text.Encoding.GetEncoding("Shift_JIS")
            strStreamWriter = New System.IO.StreamWriter(strCsvPath, False, strEncoding)

            objData.Clear()
            objData.Tables.Clear()
            objRows = Nothing

            '------------------------------
            ' �����f�[�^�擾����
            '------------------------------
            If Not LF_GetRecords(objData, pTransDate) Then
                Exit Function
            End If

            '------------------------------
            ' �t�@�C���o��
            '------------------------------
            ColmCnt = 0
            RowsCnt = 0

            While ColmCnt < objData.Tables("com").Columns.Count
                'If Not GF_GetRows(objData, RowsCnt, objRows) Then
                '    Exit Function
                'End If

                If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                    strStreamWriter.WriteLine(objData.Tables("com").Columns(ColmCnt))
                Else
                    strStreamWriter.Write(objData.Tables("com").Columns(ColmCnt))
                    strStreamWriter.Write(",")
                End If

                ColmCnt = ColmCnt + 1
            End While

            ColmCnt = 0
            RowsCnt = 0
            While RowsCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, RowsCnt, objRows) Then
                    Exit Function
                End If

                While ColmCnt < objData.Tables("com").Columns.Count
                    If Not GF_GetRows(objData, RowsCnt, objRows) Then
                        Exit Function
                    End If

                    If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                        strStreamWriter.WriteLine(objData.Tables("com").Rows(RowsCnt)(ColmCnt))
                    Else
                        strStreamWriter.Write(objData.Tables("com").Rows(RowsCnt)(ColmCnt) & ",")
                    End If

                    ColmCnt = ColmCnt + 1
                End While

                ColmCnt = 0
                RowsCnt = RowsCnt + 1
            End While

        Catch
            strStreamWriter.Close()
            MsgBox("�t�@�C���̏o�͂Ɏ��s���܂���")

            Exit Function
        End Try

        strStreamWriter.Close()

        LF_GetRecordsDATA = True

        Exit Function
    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�����f�[�^�W�v����(�o�b�N�A�b�v�p)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2020.05.19 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetRecordsDATABackup(ByRef pFilename As String, ByVal pTransDate As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim RowsCnt As Integer
        Dim ColmCnt As Integer
        Dim strCsvPath As String = ""
        Dim strEncoding As System.Text.Encoding
        Dim strStreamWriter As System.IO.StreamWriter = Nothing

        strCsvPath = Trim$(GF_GetAppInfo("DELI_RECORDS_PATH")) & "\RecordsData(" & pTransDate & Format(Now, "HHmmss") & ").csv"

        Try

            pFilename = strCsvPath

            '------------------------------
            ' �t�@�C�����ݒ�
            '------------------------------
            strEncoding = System.Text.Encoding.GetEncoding("Shift_JIS")
            strStreamWriter = New System.IO.StreamWriter(strCsvPath, False, strEncoding)

            objData.Clear()
            objData.Tables.Clear()
            objRows = Nothing

            '------------------------------
            ' �����f�[�^�擾����
            '------------------------------
            If Not LF_GetRecords(objData, pTransDate) Then
                Exit Function
            End If

            '------------------------------
            ' �t�@�C���o��
            '------------------------------
            ColmCnt = 0
            RowsCnt = 0

            While ColmCnt < objData.Tables("com").Columns.Count
                'If Not GF_GetRows(objData, RowsCnt, objRows) Then
                '    Exit Function
                'End If

                If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                    strStreamWriter.WriteLine(objData.Tables("com").Columns(ColmCnt))
                Else
                    strStreamWriter.Write(objData.Tables("com").Columns(ColmCnt))
                    strStreamWriter.Write(",")
                End If

                ColmCnt = ColmCnt + 1
            End While

            ColmCnt = 0
            RowsCnt = 0
            While RowsCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, RowsCnt, objRows) Then
                    Exit Function
                End If

                While ColmCnt < objData.Tables("com").Columns.Count
                    If Not GF_GetRows(objData, RowsCnt, objRows) Then
                        Exit Function
                    End If

                    If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                        strStreamWriter.WriteLine(objData.Tables("com").Rows(RowsCnt)(ColmCnt))
                    Else
                        strStreamWriter.Write(objData.Tables("com").Rows(RowsCnt)(ColmCnt) & ",")
                    End If

                    ColmCnt = ColmCnt + 1
                End While

                ColmCnt = 0
                RowsCnt = RowsCnt + 1
            End While

        Catch
            strStreamWriter.Close()
            MsgBox("�t�@�C���̏o�͂Ɏ��s���܂���")

            Exit Function
        End Try

        strStreamWriter.Close()

        LF_GetRecordsDATABackup = True

        Exit Function
    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F����f�[�^�]������(FTP����)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.11.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_TransSalesDataFTP(ByVal pFilename As String) As Boolean

        Dim upFile As String = ""
        Dim strFileNM As String = pFilename.Substring(26, 29)
        Dim strFTPurl As String = ""

        strFTPurl = GF_GetAppInfo("DELI_SV_IP") & "/Sales/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/" & GF_GetAppInfo("DELI_SHOPCD") & "/"

        Dim upUrl As New Uri("ftp://" & strFTPurl & strFileNM)

        Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(upUrl), System.Net.FtpWebRequest)

        Try
            upFile = pFilename

            LF_TransSalesDataFTP = False

            'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
            Dim strFTPId As String = "ftp"
            Dim strFTPPass As String = ""
            getFTPUserPass(strFTPId, strFTPPass)
            ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)

            ftpReq.Method = System.Net.WebRequestMethods.Ftp.UploadFile

            ftpReq.KeepAlive = False

            ftpReq.UseBinary = False
            ' 2019-11-06 -------------------------------------------------------------------------------
            If System.Configuration.ConfigurationManager.AppSettings("FTPUploadPassiveMode") = "0" Then
                ftpReq.UsePassive = False
            Else
                ftpReq.UsePassive = True
            End If
            ' ------------------------------------------------------------------------------------------
            Dim reqSrm As System.IO.Stream = ftpReq.GetRequestStream()

            Dim fs As New System.IO.FileStream(upFile, System.IO.FileMode.Open, System.IO.FileAccess.Read)

            Dim buffer(1023) As Byte

            While True

                Dim readSize As Integer = fs.Read(buffer, 0, buffer.Length)

                If readSize = 0 Then
                    Exit While
                End If

                reqSrm.Write(buffer, 0, readSize)

            End While

            fs.Close()

            reqSrm.Close()

            'FtpWebResponse���擾
            Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
            '����
            ftpRes.Close()

            LF_TransSalesDataFTP = True

        Catch ex As Exception
            Call LS_WriteLogFTP(ex.Message)
        End Try

        Exit Function

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F����f�[�^�]������(FTP���� �ꃖ����)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2018.04.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_TransSales() As Boolean

        Dim upFile As String = ""
        Dim strFileNM As String = ""
        Dim strFTPurl As String = ""
        Dim strFiles As String() = System.IO.Directory.GetFiles(Trim$(GF_GetAppInfo("DELI_SALES_CSV_PATH ")), "*", IO.SearchOption.TopDirectoryOnly)

        Try
            For i As Integer = 0 To strFiles.Count - 1

                strFileNM = strFiles(i).Substring(26, 29)

                strFTPurl = GF_GetAppInfo("DELI_SV_IP") & "/Sales/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/" & GF_GetAppInfo("DELI_SHOPCD") & "/"

                Dim upUrl As New Uri("ftp://" & strFTPurl & strFileNM)

                Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(upUrl), System.Net.FtpWebRequest)

                upFile = strFiles(i)

                LF_TransSales = False

                'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
                Dim strFTPId As String = "ftp"
                Dim strFTPPass As String = ""
                getFTPUserPass(strFTPId, strFTPPass)
                ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)

                ftpReq.Method = System.Net.WebRequestMethods.Ftp.UploadFile

                ftpReq.KeepAlive = False

                ftpReq.UseBinary = False
                ' 2019-11-06 -------------------------------------------------------------------------------
                If System.Configuration.ConfigurationManager.AppSettings("FTPUploadPassiveMode") = "0" Then
                    ftpReq.UsePassive = False
                Else
                    ftpReq.UsePassive = True
                End If
                ' ------------------------------------------------------------------------------------------
                Dim reqSrm As System.IO.Stream = ftpReq.GetRequestStream()

                Dim fs As New System.IO.FileStream(upFile, System.IO.FileMode.Open, System.IO.FileAccess.Read)

                Dim buffer(1023) As Byte

                While True

                    Dim readSize As Integer = fs.Read(buffer, 0, buffer.Length)

                    If readSize = 0 Then
                        Exit While
                    End If

                    reqSrm.Write(buffer, 0, readSize)

                End While

                fs.Close()

                reqSrm.Close()

                'FtpWebResponse���擾
                Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
                '����
                ftpRes.Close()

            Next

            LF_TransSales = True

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Function

SYSTEM_ERROR:
        Call GS_ErrorTerm("LF_TransSales")
    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F����f�[�^�]������(FTP���� �t�H���_���S��)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2020.05.18 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_TransSalesLoop() As Boolean

        Dim upFile As String = ""
        Dim strFileNM As String = ""
        Dim strFTPurl As String = ""
        Dim strFiles As String() = System.IO.Directory.GetFiles(Trim$(GF_GetAppInfo("DELI_SALES_CSV_PATH ") & "uplode"), "*", IO.SearchOption.TopDirectoryOnly)

        Try
            For i As Integer = 0 To strFiles.Count - 1

                strFileNM = strFiles(i).Substring(32, 29)

                strFTPurl = GF_GetAppInfo("DELI_SV_IP") & "/Sales/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/" & GF_GetAppInfo("DELI_SHOPCD") & "/"

                Dim upUrl As New Uri("ftp://" & strFTPurl & strFileNM)

                Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(upUrl), System.Net.FtpWebRequest)

                upFile = strFiles(i)

                LF_TransSalesLoop = False

                'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
                Dim strFTPId As String = "ftp"
                Dim strFTPPass As String = ""
                getFTPUserPass(strFTPId, strFTPPass)
                ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)

                ftpReq.Method = System.Net.WebRequestMethods.Ftp.UploadFile

                ftpReq.KeepAlive = False

                ftpReq.UseBinary = False
                ' 2019-11-06 -------------------------------------------------------------------------------
                If System.Configuration.ConfigurationManager.AppSettings("FTPUploadPassiveMode") = "0" Then
                    ftpReq.UsePassive = False
                Else
                    ftpReq.UsePassive = True
                End If
                ' ------------------------------------------------------------------------------------------
                Dim reqSrm As System.IO.Stream = ftpReq.GetRequestStream()

                Dim fs As New System.IO.FileStream(upFile, System.IO.FileMode.Open, System.IO.FileAccess.Read)

                Dim buffer(1023) As Byte

                While True

                    Dim readSize As Integer = fs.Read(buffer, 0, buffer.Length)

                    If readSize = 0 Then
                        Exit While
                    End If

                    reqSrm.Write(buffer, 0, readSize)

                End While

                fs.Close()

                reqSrm.Close()

                ' FtpWebResponse���擾
                Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
                ' ����
                ftpRes.Close()
                ' FTP�����œ]�������t�@�C�����폜
                My.Computer.FileSystem.DeleteFile(strFiles(i))

            Next

            LF_TransSalesLoop = True

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Function

SYSTEM_ERROR:
        Call GS_ErrorTerm("LF_TransSales")
    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�����f�[�^�]������(FTP����)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.12.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_TransRecordsDataFTP(ByVal pFilename As String) As Boolean

        Dim upFile As String = ""
        Dim strFileNM As String = pFilename.Substring(30, 31)
        Dim strFTPurl As String = ""

        strFTPurl = GF_GetAppInfo("DELI_SV_IP") & "/Records/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/" & GF_GetAppInfo("DELI_SHOPCD") & "/"

        Dim upUrl As New Uri("ftp://" & strFTPurl & strFileNM)

        Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(upUrl), System.Net.FtpWebRequest)

        Try
            upFile = pFilename

            LF_TransRecordsDataFTP = False

            'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
            Dim strFTPId As String = "ftp"
            Dim strFTPPass As String = ""
            getFTPUserPass(strFTPId, strFTPPass)
            ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)

            ftpReq.Method = System.Net.WebRequestMethods.Ftp.UploadFile

            ftpReq.KeepAlive = False

            ftpReq.UseBinary = False
            ' 2019-11-06 -------------------------------------------------------------------------------
            If System.Configuration.ConfigurationManager.AppSettings("FTPUploadPassiveMode") = "0" Then
                ftpReq.UsePassive = False
            Else
                ftpReq.UsePassive = True
            End If
            ' ------------------------------------------------------------------------------------------
            Dim reqSrm As System.IO.Stream = ftpReq.GetRequestStream()

            Dim fs As New System.IO.FileStream(upFile, System.IO.FileMode.Open, System.IO.FileAccess.Read)

            Dim buffer(1023) As Byte

            While True

                Dim readSize As Integer = fs.Read(buffer, 0, buffer.Length)

                If readSize = 0 Then
                    Exit While
                End If

                reqSrm.Write(buffer, 0, readSize)

            End While

            fs.Close()

            reqSrm.Close()

            'FtpWebResponse���擾
            Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
            '����
            ftpRes.Close()

            LF_TransRecordsDataFTP = True

        Catch ex As Exception
            Call LS_WriteLogFTP(ex.Message)
        End Try

        Exit Function

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�����f�[�^�]������(FTP���� �ꃖ����)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2018.04.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_TransRecords() As Boolean

        Dim upFile As String = ""
        Dim strFileNM As String = ""
        Dim strFTPurl As String = ""
        Dim strFiles As String() = System.IO.Directory.GetFiles(Trim$(GF_GetAppInfo("DELI_RECORDS_PATH")), "*", IO.SearchOption.TopDirectoryOnly)

        Try
            For i As Integer = 0 To strFiles.Count - 1

                strFileNM = strFiles(i).Substring(30, 31)

                strFTPurl = GF_GetAppInfo("DELI_SV_IP") & "/Records/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/" & GF_GetAppInfo("DELI_SHOPCD") & "/"

                Dim upUrl As New Uri("ftp://" & strFTPurl & strFileNM)

                Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(upUrl), System.Net.FtpWebRequest)

                upFile = strFiles(i)

                LF_TransRecords = False

                'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
                Dim strFTPId As String = "ftp"
                Dim strFTPPass As String = ""
                getFTPUserPass(strFTPId, strFTPPass)
                ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)

                ftpReq.Method = System.Net.WebRequestMethods.Ftp.UploadFile

                ftpReq.KeepAlive = False

                ftpReq.UseBinary = False
                ' 2019-11-06 -------------------------------------------------------------------------------
                If System.Configuration.ConfigurationManager.AppSettings("FTPUploadPassiveMode") = "0" Then
                    ftpReq.UsePassive = False
                Else
                    ftpReq.UsePassive = True
                End If
                ' ------------------------------------------------------------------------------------------
                Dim reqSrm As System.IO.Stream = ftpReq.GetRequestStream()

                Dim fs As New System.IO.FileStream(upFile, System.IO.FileMode.Open, System.IO.FileAccess.Read)

                Dim buffer(1023) As Byte

                While True

                    Dim readSize As Integer = fs.Read(buffer, 0, buffer.Length)

                    If readSize = 0 Then
                        Exit While
                    End If

                    reqSrm.Write(buffer, 0, readSize)

                End While

                fs.Close()

                reqSrm.Close()

                'FtpWebResponse���擾
                Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
                '����
                ftpRes.Close()

            Next

            LF_TransRecords = True

        Catch ex As Exception
            Call LS_WriteLogFTP(ex.Message)
        End Try

        Exit Function

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�����f�[�^�]������(FTP�����@�t�H���_���S��)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2020.05.19 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_TransRecordsLoop() As Boolean

        Dim upFile As String = ""
        Dim strFileNM As String = ""
        Dim strFTPurl As String = ""
        Dim strFiles As String() = System.IO.Directory.GetFiles(Trim$(GF_GetAppInfo("DELI_RECORDS_PATH")) & "uplode", "*", IO.SearchOption.TopDirectoryOnly)

        Try
            For i As Integer = 0 To strFiles.Count - 1

                strFileNM = strFiles(i).Substring(36, 31)

                strFTPurl = GF_GetAppInfo("DELI_SV_IP") & "/Records/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/" & GF_GetAppInfo("DELI_SHOPCD") & "/"

                Dim upUrl As New Uri("ftp://" & strFTPurl & strFileNM)

                Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(upUrl), System.Net.FtpWebRequest)

                upFile = strFiles(i)

                LF_TransRecordsLoop = False

                'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
                Dim strFTPId As String = "ftp"
                Dim strFTPPass As String = ""
                getFTPUserPass(strFTPId, strFTPPass)
                ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)

                ftpReq.Method = System.Net.WebRequestMethods.Ftp.UploadFile

                ftpReq.KeepAlive = False

                ftpReq.UseBinary = False
                ' 2019-11-06 -------------------------------------------------------------------------------
                If System.Configuration.ConfigurationManager.AppSettings("FTPUploadPassiveMode") = "0" Then
                    ftpReq.UsePassive = False
                Else
                    ftpReq.UsePassive = True
                End If
                ' ------------------------------------------------------------------------------------------
                Dim reqSrm As System.IO.Stream = ftpReq.GetRequestStream()

                Dim fs As New System.IO.FileStream(upFile, System.IO.FileMode.Open, System.IO.FileAccess.Read)

                Dim buffer(1023) As Byte

                While True

                    Dim readSize As Integer = fs.Read(buffer, 0, buffer.Length)

                    If readSize = 0 Then
                        Exit While
                    End If

                    reqSrm.Write(buffer, 0, readSize)

                End While

                fs.Close()

                reqSrm.Close()

                'FtpWebResponse���擾
                Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
                '����
                ftpRes.Close()
                ' FTP�����œ]�������t�@�C�����폜
                My.Computer.FileSystem.DeleteFile(strFiles(i))

            Next

            LF_TransRecordsLoop = True

        Catch ex As Exception
            Call LS_WriteLogFTP(ex.Message)
        End Try

        Exit Function

    End Function
    ' 2017.11.01 �{���z�M �N���X�R�k�� �c��

    ' 2017.12.01 �{���z�M �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FTPM010�@�I���폜����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.12.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_SelectDelteTPM010() As Boolean

        Dim strSQL As String = ""
        Dim objData As New DataSet
        Dim objRows As DataRow = Nothing
        Dim intCnt As Integer
        Dim strGoodsCD As String = ""

        LF_SelectDelteTPM010 = False

        Try
            strSQL = ""
            strSQL = strSQL & " SELECT GOODSCD"
            strSQL = strSQL & "   FROM TPM350"
            strSQL = strSQL & "  WHERE DELIVARYFLG = '1'"

            If Not GF_GetData(strSQL, objData) Then
                Exit Function
            End If

            intCnt = 0

            If objData.Tables("com").Rows.Count = 0 Then
                Exit Function ' ���o���ʂO�����́A�����s��Ȃ�
            End If

            While intCnt < CLng(objData.Tables("com").Rows.Count)

                If Not GF_GetRows(objData, intCnt, objRows) Then
                    GoTo SYSTEM_ERROR
                End If

                strGoodsCD = Trim$(objRows("GOODSCD"))

                If Not LS_DeleteTPM010(strGoodsCD) Then
                    GoTo SYSTEM_ERROR
                End If

                intCnt += 1
            End While

            LF_SelectDelteTPM010 = True

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Function

SYSTEM_ERROR:
        Call GS_ErrorTerm("LF_SelectDeleteTPM010")
    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�Fdelivaryflg�擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.12.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LF_GetDeliDir(ByVal pdir As String, ByRef pstr As String)

        '�t�@�C���ꗗ���擾����f�B���N�g����URI
        Dim u As New Uri("ftp://" & pdir)

        'FtpWebRequest�̍쐬
        Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(u), System.Net.FtpWebRequest)
        '���O�C�����[�U�[���ƃp�X���[�h��ݒ�
        'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
        Dim strFTPId As String = "ftp"
        Dim strFTPPass As String = ""
        getFTPUserPass(strFTPId, strFTPPass)
        ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)

        'Method��WebRequestMethods.Ftp.ListDirectoryDetails("LIST")��ݒ�
        ftpReq.Method = System.Net.WebRequestMethods.Ftp.ListDirectoryDetails

        '�v���̊�����ɐڑ������
        ftpReq.KeepAlive = False

        ' 2019-11-06 -------------------------------------------------------------------------------
        If System.Configuration.ConfigurationManager.AppSettings("FTPUploadPassiveMode") = "0" Then
            'PASSIVE���[�h�𖳌��ɂ���
            ftpReq.UsePassive = False
        Else
            ftpReq.UsePassive = True
        End If
        ' ------------------------------------------------------------------------------------------
        'FtpWebResponse���擾
        Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)

        'FTP�T�[�o�[���瑗�M���ꂽ�f�[�^���擾
        Dim sr As New System.IO.StreamReader(ftpRes.GetResponseStream())

        pstr = sr.ReadToEnd()

        sr.Close()

        '����
        ftpRes.Close()

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�@�C�����݃`�F�b�N����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.12.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_ChkExistFTP(ByVal pServerName As String, ByVal pTargetDirectory As String, ByVal pTargetFileName As String) As Boolean

        ' 2022-02-01 -----------------------------------------------------
        'Dim strFileNM As String = ""
        ' �N���X�R���̏ꍇ��38�A�N���X���̏ꍇ��35 ��IP�A�h���X�̒���
        'Dim strDir As String = pDir.Substring(0, 35)
        'Dim strDir As String = pDir.Substring(0, 38)
        ' ----------------------------------------------------------------
        Dim aryFile() As String

        Dim strFTPId As String = "ftp"
        Dim strFTPPass As String = ""
        getFTPUserPass(strFTPId, strFTPPass)
        Try

            'strFileNM = LS_Right(pDir, 38)

            '�t�@�C���ꗗ���擾����f�B���N�g����URI
            'Dim u As New Uri("ftp://" & strDir)
            Dim u As New Uri("ftp://" & pServerName & pTargetDirectory & "/")

            'FtpWebRequest�̍쐬
            Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(u), System.Net.FtpWebRequest)
            '���O�C�����[�U�[���ƃp�X���[�h��ݒ�
            'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
            ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)

            'Method��WebRequestMethods.Ftp.ListDirectoryDetails("LIST")��ݒ�
            ftpReq.Method = System.Net.WebRequestMethods.Ftp.ListDirectory

            '�v���̊�����ɐڑ������
            ftpReq.KeepAlive = False

            ' 2019-11-06 -------------------------------------------------------------------------------
            If System.Configuration.ConfigurationManager.AppSettings("FTPUploadPassiveMode") = "0" Then
                'PASSIVE���[�h�𖳌��ɂ���
                ftpReq.UsePassive = False
            Else
                ftpReq.UsePassive = True
            End If
            ' ------------------------------------------------------------------------------------------
            'FtpWebResponse���擾
            Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)

            'FTP�T�[�o�[���瑗�M���ꂽ�f�[�^���擾
            Dim sr As New System.IO.StreamReader(ftpRes.GetResponseStream())

            Dim strDirNM As String = sr.ReadToEnd

            aryFile = Split(strDirNM, vbCrLf)

            For i As Integer = 0 To aryFile.Count - 2

                'If aryFile(i) = strFileNM Then
                If aryFile(i) = pTargetFileName Then

                    sr.Close()

                    '����
                    ftpRes.Close()

                    LF_ChkExistFTP = True

                    Exit For

                End If

            Next

        Catch ex As Exception
            Exit Function
        End Try

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t���O�t�@�C��������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.12.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    'Private Function LF_Writeflg(ByVal pDir As String, ByVal pToFileNM As String) As Boolean
    Private Function LF_Writeflg(ByVal pServerName As String, ByVal pTargetDirectory As String, ByVal pFromFileNM As String, ByVal pToFileNM As String) As Boolean

        Try

            '���O��ύX����t�@�C����URI
            'Dim u As New Uri("ftp://" & pDir)
            Dim u As New Uri("ftp://" & pServerName & pTargetDirectory & "/" & pFromFileNM)
            '�V�����t�@�C����
            'Dim newName As String = pToFileNM

            'FtpWebRequest�̍쐬
            Dim ftpReq As System.Net.FtpWebRequest = _
                CType(System.Net.WebRequest.Create(u), System.Net.FtpWebRequest)
            '���O�C�����[�U�[���ƃp�X���[�h��ݒ�
            'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
            Dim strFTPId As String = "ftp"
            Dim strFTPPass As String = ""
            getFTPUserPass(strFTPId, strFTPPass)
            ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)
            'Method��WebRequestMethods.Ftp.Rename(RENAME)��ݒ�
            ftpReq.Method = System.Net.WebRequestMethods.Ftp.Rename

            '�ύX��̐V�����t�@�C������ݒ�
            'ftpReq.RenameTo = newName
            ftpReq.RenameTo = pToFileNM

            'FtpWebResponse���擾
            Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)

            'FTP�T�[�o�[���瑗�M���ꂽ�X�e�[�^�X��\��
            Console.WriteLine("{0}: {1}", ftpRes.StatusCode, ftpRes.StatusDescription)
            '����
            ftpRes.Close()

            LF_Writeflg = True

        Catch ex As Exception
            Exit Function
        End Try

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�{��SV�t�H���_�폜����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.12.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_DeleteFolderSV(ByVal pdir As String) As Boolean

        Try

            pdir = pdir.Replace(Environment.NewLine, "")

            '�폜����t�@�C����URI
            Dim u As New Uri("ftp://" & pdir)

            'FtpWebRequest�̍쐬
            Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(u), System.Net.FtpWebRequest)
            '���O�C�����[�U�[���ƃp�X���[�h��ݒ�
            'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
            Dim strFTPId As String = "ftp"
            Dim strFTPPass As String = ""
            getFTPUserPass(strFTPId, strFTPPass)
            ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)
            'Method��WebRequestMethods.Ftp.DeleteFile(DELE)��ݒ�
            ftpReq.Method = System.Net.WebRequestMethods.Ftp.RemoveDirectory

            LF_DeleteFolderSV = True
        Catch
            Exit Function
        End Try

    End Function
    ' 2017.12.01 �{���z�M �N���X�R�k�� �c��

    '------------------------------
    ' 2015.9.29 OA) TEC�f�[�^�捞
    '------------------------------
    Private Sub btn_ImportTECData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImportTECData.Click
        Call ImportTECData(Me.MdiParent)
    End Sub

    ' 2017.01.01 �����Ă���i���� �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�g�p�p�^�[���X�V����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.01.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btnDec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDec.Click

        Dim strSQL As String = Nothing
        Dim UpdPtn As String = Nothing

        Try

            UpdPtn = cmbPtn.Text

            Select Case UpdPtn

                Case "�p�^�[���P"
                    UpdPtn = "1"
                Case "�p�^�[���Q"
                    UpdPtn = "2"
                Case "�p�^�[���R"
                    UpdPtn = "3"
                Case "�p�^�[���S"
                    UpdPtn = "4"

            End Select

            strSQL = ""
            strSQL = strSQL & " UPDATE TPM092"
            strSQL = strSQL & " SET APVALUE = '" & UpdPtn & "'"
            strSQL = strSQL & " WHERE APKEY = 'KCP_PTN'"

            If Not GF_UpdData(strSQL) Then
                GoTo SYSTEM_ERROR
            End If

            Call MsgBox("�X�V�������܂����B", MsgBoxStyle.OkOnly, "CrossNavi")

        Catch
            GoTo SYSTEM_ERROR
        End Try

        '20180727 CNL1301���X�^�[�g�o�b�`�N���ǉ�
        If GF_GetAppInfo3("KCP_PTN_CNL1301_FLG") = 1 Then
            Process.Start("C:\CrossNavi\tool\CNL1301restart.bat")
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btnDec_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�o�͐�p�^�[���X�V����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.01.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim strSQL As String
        Dim i As Integer
        Dim j As Integer

        Try

            For i = 1 To 4

                For j = 1 To 32

                    strSQL = ""
                    strSQL = strSQL & " UPDATE TPM310"
                    strSQL = strSQL & "    SET PTN" & i & "='" & DataGridView1.Rows(j - 1).Cells(i).Value.ToString & "'"
                    strSQL = strSQL & "  WHERE PRNNO = '" & j & "'"

                    If Not GF_UpdData(strSQL) Then
                        GoTo SYSTEM_ERROR
                    End If

                Next
            Next

            Call MsgBox("�X�V�������܂����B", MsgBoxStyle.OkOnly, "CrossNavi")

        Catch
            GoTo SYSTEM_ERROR
        End Try

        
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btnSave_Click")
    End Sub
    ' 2017.01.01 �����Ă���i���� �N���X�R�k�� �c��

    ' 2017.10.01 �{���z�M �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�z�M���j���[�捞����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.01.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Deli_Import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deli_Import.Click

        targetPrgBar = prg_Bar_Deli
        targetPrgLabel = ProgressLabelDeli
        Dim result As DialogResult = MessageBox.Show("�{�����j���[�f�[�^�捞���J�n���܂����H", "CrossNavi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Dim strDeliDate As String = ""

        ' �v���O���X�o�[�ŏ��l
        targetPrgBar.Minimum = 0
        ' �v���O���X�o�[�ő�l
        targetPrgBar.Maximum = 1000
        ' �v���O���X�o�[�����l
        targetPrgBar.Value = targetPrgBar.Minimum
        targetPrgLabel.Text = "�n��"

        ' ���j���[�捞����
        Try
            ' �J�[�\���@�ʏ큨�ҋ@
            Me.Cursor = Cursors.WaitCursor

            '�t�H�[���R���g���[���̃��b�N
            Call LS_UseControl(False)

            If result = Windows.Forms.DialogResult.Yes Then
                ' �{��SV���̃t�H���_���݃`�F�b�N
                If Not LF_ChkFolder(strDeliDate) Then
                    Call MsgBox("���j���[���z�M����Ă��܂���B���j���[�捞�������I�����܂��B", MsgBoxStyle.OkOnly, "CrossNavi")

                    ' �ҋ@���ʏ�
                    Me.Cursor = Cursors.Default

                    ' �����l�ɖ߂�
                    targetPrgBar.Value = 0
                    targetPrgLabel.Text = ""

                    '�t�H�[���R���g���[���̃��b�N����
                    Call LS_UseControl(True)

                    Exit Sub
                Else
                    ' 5%
                    targetPrgBar.Value = 50
                    targetPrgLabel.Text = "���j���[�o�b�N�A�b�v�n��"""
                    ' �������j���[�o�b�N�A�b�v
                    If Not LF_MenuBackUp() Then
                        Call MsgBox("�������j���[�o�b�N�A�b�v�����Ɏ��s���܂����B���j���[�捞�������I�����܂��B", MsgBoxStyle.OkOnly, "CrossNavi")

                        ' �ҋ@���ʏ�
                        Me.Cursor = Cursors.Default

                        ' �����l�ɖ߂�
                        targetPrgBar.Value = 0
                        targetPrgLabel.Text = ""

                        '�t�H�[���R���g���[���̃��b�N����
                        Call LS_UseControl(True)

                        Exit Sub
                    Else
                        ' 10%
                        targetPrgBar.Value = 100
                        targetPrgLabel.Text = "�z�M���j���[�捞�n��"
                        ' �z�M���j���[�捞
                        If Not LS_Deli_Import(strDeliDate) Then
                            Call MsgBox("�z�M���j���[�捞�����Ɏ��s���܂����B���j���[�捞�������I�����܂��B", MsgBoxStyle.OkOnly, "CrossNavi")

                            ' �ҋ@���ʏ�
                            Me.Cursor = Cursors.Default

                            ' �����l�ɖ߂�
                            targetPrgBar.Value = 0
                            targetPrgLabel.Text = ""

                            '�t�H�[���R���g���[���̃��b�N����
                            Call LS_UseControl(True)

                            Exit Sub
                        Else
                            ' 100%
                            targetPrgBar.Value = 1000
                            targetPrgLabel.Text = ""
                            Call MsgBox("�{�����j���[�f�[�^�捞�������������܂����B", MsgBoxStyle.OkOnly, "CrossNavi")
                        End If
                    End If
                End If
            End If

            ' �ҋ@���ʏ�
            Me.Cursor = Cursors.Default
        Catch
            GoTo SYSTEM_ERROR
        End Try
        ' �����l�ɖ߂�
        targetPrgBar.Value = 0

        '�t�H�[���R���g���[���̃��b�N����
        Call LS_UseControl(True)

        Exit Sub

SYSTEM_ERROR:
        '�t�H�[���R���g���[���̃��b�N����
        Call LS_UseControl(True)

        Call GS_ErrorTerm("btn_Deli_Import_Click")
        ' �����l�ɖ߂�
        targetPrgBar.Value = 0
        ' �J�[�\���@�ҋ@���ʏ�
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_OMOTENASHI_Import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OMOTENASHI_Import.Click

        targetPrgBar = prg_Bar_OMOTENASHI
        targetPrgLabel = ProgressLabelOMOTENASHI
        Dim result As DialogResult = MessageBox.Show("OMOTENASHI�f�[�^�捞���J�n���܂����H", "CrossNavi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Dim strTargetDir As String = ""

        ' �v���O���X�o�[�ŏ��l
        targetPrgBar.Minimum = 0
        ' �v���O���X�o�[�ő�l
        targetPrgBar.Maximum = 1000
        ' �v���O���X�o�[�����l
        targetPrgBar.Value = targetPrgBar.Minimum
        targetPrgLabel.Text = "�n��"

        ' ���j���[�捞����
        Try
            ' �J�[�\���@�ʏ큨�ҋ@
            Me.Cursor = Cursors.WaitCursor

            '�t�H�[���R���g���[���̃��b�N
            Call LS_UseControl(False)

            If result = Windows.Forms.DialogResult.Yes Then
                ' �{��SV���̃t�H���_���݃`�F�b�N
                If Not LF_ChkOMOTENASHIFolder(strTargetDir) Then
                    Call MsgBox("���j���[���z�M����Ă��܂���B���j���[�捞�������I�����܂��B", MsgBoxStyle.OkOnly, "CrossNavi")

                    ' �ҋ@���ʏ�
                    Me.Cursor = Cursors.Default

                    ' �����l�ɖ߂�
                    targetPrgBar.Value = 0
                    targetPrgLabel.Text = ""

                    '�t�H�[���R���g���[���̃��b�N����
                    Call LS_UseControl(True)

                    Exit Sub
                Else
                    ' 5%
                    targetPrgBar.Value = 50
                    'ProgressLabel.Text = "���j���[�o�b�N�A�b�v�n��"""
                    ' �������j���[�o�b�N�A�b�v
                    'If Not LF_MenuBackUp() Then
                    '    Call MsgBox("�������j���[�o�b�N�A�b�v�����Ɏ��s���܂����B���j���[�捞�������I�����܂��B", MsgBoxStyle.OkOnly, "CrossNavi")
                    '    ' �ҋ@���ʏ�
                    '    Me.Cursor = Cursors.Default
                    '    ' �����l�ɖ߂�
                    '    prg_Bar.Value = 0
                    '    '�t�H�[���R���g���[���̃��b�N����
                    '    Call LS_UseControl(True)
                    '    Exit Sub
                    'Else
                    ' 10%
                    targetPrgBar.Value = 100
                    targetPrgLabel.Text = "�z�M���j���[�捞�n��"
                    ' �z�M���j���[�捞
                    If Not LS_OMOTENASHI_Import(strTargetDir) Then
                        Call MsgBox("�z�M���j���[�捞�����Ɏ��s���܂����B���j���[�捞�������I�����܂��B", MsgBoxStyle.OkOnly, "CrossNavi")

                        ' �ҋ@���ʏ�
                        Me.Cursor = Cursors.Default

                        ' �����l�ɖ߂�
                        targetPrgBar.Value = 0
                        targetPrgLabel.Text = ""

                        '�t�H�[���R���g���[���̃��b�N����
                        Call LS_UseControl(True)

                        Exit Sub
                    Else
                        ' 100%
                        targetPrgBar.Value = 1000
                        targetPrgLabel.Text = ""
                        Call MsgBox("�{�����j���[�f�[�^�捞�������������܂����B", MsgBoxStyle.OkOnly, "CrossNavi")
                    End If
                    'End If
                End If
                End If

            ' �ҋ@���ʏ�
            Me.Cursor = Cursors.Default
        Catch
            GoTo SYSTEM_ERROR
        End Try
        ' �����l�ɖ߂�
        targetPrgBar.Value = 0

        '�t�H�[���R���g���[���̃��b�N����
        Call LS_UseControl(True)

        Exit Sub

SYSTEM_ERROR:
        '�t�H�[���R���g���[���̃��b�N����
        Call LS_UseControl(True)

        Call GS_ErrorTerm("btn_OMOTENASHI_Import_Click")
        ' �����l�ɖ߂�
        targetPrgBar.Value = 0
        ' �J�[�\���@�ҋ@���ʏ�
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_Reference_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reference.Click

        ' FolderBrowserDialog �̐V�����C���X�^���X�𐶐����� (�f�U�C�i����ǉ����Ă���ꍇ�͕K�v�Ȃ�)
        Dim FolderBrowserDialog1 As New FolderBrowserDialog()

        ' �_�C�A���O�̐�����ݒ肷��
        FolderBrowserDialog1.Description = "�捞���s���o�b�N�A�b�v�t�H���_��I�����Ă��������B"

        ' ���[�g�ɂȂ����t�H���_��ݒ肷�� (�����l SpecialFolder.Desktop)
        FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer

        ' �����I������p�X��ݒ肷��
        FolderBrowserDialog1.SelectedPath = "C:\CrossNavi\backup\"

        ' [�V�����t�H���_] �{�^����\������ (�����l True)
        FolderBrowserDialog1.ShowNewFolderButton = False

        ' �_�C�A���O��\�����A�߂�l�� [OK] �̏ꍇ�́A�I�������f�B���N�g����\������
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            lbl_Path.Text = FolderBrowserDialog1.SelectedPath
        End If

        ' �s�v�ɂȂ������_�Ŕj������ (�������� �I�u�W�F�N�g�̔j����ۏ؂��� ���Q��)
        FolderBrowserDialog1.Dispose()

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�o�b�N�A�b�v���j���[�捞����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2018.04.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_BackupImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BackupImport.Click

        Dim result As DialogResult = MessageBox.Show("�o�b�N�A�b�v���j���[�f�[�^�捞���J�n���܂����H", "CrossNavi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

        Try
            If result = Windows.Forms.DialogResult.Yes Then
                ' �ʏ큨�ҋ@
                Me.Cursor = Cursors.WaitCursor

                If Not LS_chkPath() Then
                    Call MsgBox("��荞�ރo�b�N�A�b�v�f�[�^���I������Ă��܂���B", MsgBoxStyle.OkOnly, "CrossNavi")
                    ' �ҋ@���ʏ�
                    Me.Cursor = Cursors.Default
                    Exit Sub
                Else
                    If Not LS_Backup_Import() Then
                        Call MsgBox("�o�b�N�A�b�v�f�[�^�捞�Ɏ��s���܂����B", MsgBoxStyle.OkOnly, "CrossNavi")
                        ' �ҋ@���ʏ�
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If
                End If

                Call MsgBox("�o�b�N�A�b�v�f�[�^�捞���������܂����B", MsgBoxStyle.OkOnly, "CrossNavi")

                ' �ҋ@���ʏ�
                Me.Cursor = Cursors.Default

            End If

        Catch ex As Exception
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_BackupImport_Click")
        ' �ҋ@���ʏ�
        Me.Cursor = Cursors.Default
    End Sub
    ' 2017.10.01 �{���z�M �N���X�R�k�� �c��

    ' 2017.11.01 �{���z�M �N���X�R�k�� �c��
    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�W�v�f�[�^�A�b�v���[�h����(�蓮)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2018.04.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btnSalesUplode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalesUplode.Click

        Dim strSalesFileNM As String = ""
        Dim strRecordsFileNM As String = ""

        Try

            ' 1�����O�̔���f�[�^�폜
            ' ����f�[�^�ێ�����d�l�ɕύX���邽�߁A�R�����g�A�E�g
            'Call LS_DeleteSalesFiles()

            ' ����f�[�^�]������
            If Not LF_TransSalesLoop() Then
                GoTo SYSTEM_ERROR
                Exit Sub
            End If

            ' 1�����O�̏����f�[�^�폜
            ' �����f�[�^�ێ�����d�l�ɕύX���邽�߁A�R�����g�A�E�g
            'Call LS_DeleteRecordsFiles()

            ' �����f�[�^�]������
            If Not LF_TransRecordsLoop() Then
                GoTo SYSTEM_ERROR
                Exit Sub
            End If

            Call MsgBox("�W�v�f�[�^�A�b�v���[�h�����v���܂����B", MsgBoxStyle.OkOnly, "CrossNavi")

        Catch
            GoTo SYSTEM_ERROR
            Exit Sub
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btnSalesUplode_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�W�v�f�[�^�A�b�v���[�h����(����)
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2018.04.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Public Sub LS_SalesUpdate()

        Dim strSalesFileNM As String = ""
        Dim strSalesFileNMBackup As String = ""
        Dim strRecordsFileNM As String = ""
        Dim strRecordsFileNMBackup As String = ""
        Dim lngSalesDataFTP As Long = 0
        Dim lngSalesDataFTPBackup As Long = 0
        Dim lngRecordsFTPBackup As Long = 0
        Dim strSQL As String = ""
        Dim objData As New DataSet
        Dim objRows As DataRow = Nothing
        Dim intCnt As Integer

        Try
            ' 1�����O�̔���f�[�^�폜
            ' ����f�[�^�ێ�����d�l�ɕύX���邽�߁A�R�����g�A�E�g
            'Call LS_DeleteSalesFiles()

            ' 1�����O�̏����f�[�^�폜
            ' �����f�[�^�ێ�����d�l�ɕύX���邽�߁A�R�����g�A�E�g
            'Call LS_DeleteRecordsFiles()

            '���ɂ����擾
            strSQL = ""
            strSQL = strSQL & " SELECT LEFT(TRANSTIME, 8) AS TRANSDATE"
            strSQL = strSQL & "   FROM TPD010"
            strSQL = strSQL & "  WHERE TPD010.TRANSTIME <> '0'"
            strSQL = strSQL & "    AND TPD010.TRANSTIME <> '99999999999999'"
            strSQL = strSQL & "  GROUP BY LEFT(TRANSTIME, 8)"

            If Not GF_GetData(strSQL, objData) Then
                Exit Sub
            End If

            intCnt = 0

            If objData.Tables("com").Rows.Count = 0 Then
                Exit Sub ' ���o���ʂO�����́A�����s��Ȃ�
            End If

            '���ɂ�(9:00�`��8:59)���ɓ��ʃf�[�^���o�͂��Ė{���T�[�o�ɃA�b�v���[�h����
            While intCnt < CLng(objData.Tables("com").Rows.Count)
                lngSalesDataFTP = 0
                lngSalesDataFTPBackup = 0

                If Not GF_GetRows(objData, intCnt, objRows) Then
                    Exit Sub
                End If

                ' ����f�[�^�W�v����
                If Not LF_GetSalesData2(strSalesFileNM, Trim$(objRows("TRANSDATE")), lngSalesDataFTP) Then
                    Exit Sub
                End If

                ' ����f�[�^�W�v����(�o�b�N�A�b�v�p)
                If Not LF_GetSalesDataBackup(strSalesFileNMBackup, Trim$(objRows("TRANSDATE")), lngSalesDataFTPBackup) Then
                    Exit Sub
                End If

                ' �����f�[�^�W�v����
                If LF_GetRecordsDATA(strRecordsFileNM, Trim$(objRows("TRANSDATE"))) Then
                    ' �����f�[�^�W�v����(�o�b�N�A�b�v�p)
                    If LF_GetRecordsDATABackup(strRecordsFileNMBackup, Trim$(objRows("TRANSDATE"))) Then
                        lngRecordsFTPBackup = 1
                    End If
                End If

                intCnt += 1
            End While

            ' ����f�[�^�]������(csv�t�@�C�����쐬���ꂽ�ꍇ�̂�)
            If lngSalesDataFTP = 1 Then
                If Not LF_TransSalesLoop() Then
                    Exit Sub
                End If
            End If

            ' �����f�[�^�]������(csv�t�@�C�����쐬���ꂽ�ꍇ�̂�)
            If lngRecordsFTPBackup = 1 Then
                If Not LF_TransRecordsLoop() Then
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            Call LS_WriteLogFTP(ex.Message)
            Exit Sub
        End Try

        Exit Sub

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�W�v�f�[�^�폜����(����)
    ' �@�@�\�T�v�F�P�����O�̔���f�[�^�����݂���ꍇ�폜����B
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2018.04.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_DeleteSalesFiles()

        Dim FolderPath As String = Trim$(GF_GetAppInfo("DELI_SALES_CSV_PATH"))

        Dim files As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = _
                                                My.Computer.FileSystem.FindInFiles( _
                                                Trim$(GF_GetAppInfo("DELI_SALES_CSV_PATH")), _
                                                "", _
                                                False, _
                                                FileIO.SearchOption.SearchAllSubDirectories, _
                                                New String() {"*.csv"})

        Dim files_createdate As DateTime

        For i As Integer = 0 To files.Count - 1
            files_createdate = System.IO.File.GetCreationTime(files(i))
            '�쐬�����r����32���ȏ�O�ɍ쐬���ꂽ���̂Ȃ�폜
            If DateDiff("d", files_createdate, Now) > 31 Then
                System.IO.File.Delete(files(i))
            End If
        Next

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�����f�[�^�폜����(����)
    ' �@�@�\�T�v�F�P�����O�̏����f�[�^�����݂���ꍇ�폜����B
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2018.04.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_DeleteRecordsFiles()

        Dim FolderPath As String = Trim$(GF_GetAppInfo("DELI_RECORDS_PATH"))

        Dim files As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = _
                                                My.Computer.FileSystem.FindInFiles( _
                                                Trim$(GF_GetAppInfo("DELI_RECORDS_PATH")), _
                                                "", _
                                                False, _
                                                FileIO.SearchOption.SearchAllSubDirectories, _
                                                New String() {"*.csv"})

        Dim files_createdate As DateTime

        For i As Integer = 0 To files.Count - 1
            files_createdate = System.IO.File.GetCreationTime(files(i))
            '�쐬�����r����32���ȏ�O�ɍ쐬���ꂽ���̂Ȃ�폜
            If DateDiff("d", files_createdate, Now) > 31 Then
                System.IO.File.Delete(files(i))
            End If
        Next

    End Sub
    ' 2017.11.01 �{���z�M �N���X�R�k�� �c��

    ' 2018.05.23 �{���z�M�@�N���X�R�k��
    ''' <summary>
    ''' �t�H�[������
    ''' �{�����j���[�f�[�^�捞���̃R���g���[���̊����񊈐��𐧌䂷��
    ''' </summary>
    ''' <param name="bln"></param>
    ''' <remarks></remarks>
    Private Sub LS_UseControl(ByVal bln As Boolean)

        If bln Then
            'True�̏ꍇ�i�t�H�[���R���g���[���̃��b�N�����j
            Me.TabControl1.Enabled = True
            Me.btn_Deli_Import.Enabled = True
            If fgCheckM555 Then
                btn_OMOTENASHI_Import.Enabled = True
            Else
                btn_OMOTENASHI_Import.Enabled = False
            End If
            Me.btn_BackupImport.Enabled = True
            Me.btn_Reference.Enabled = True
            Me.btnSalesUplode.Enabled = True
            CType(Me.MdiParent, CNL2010).btn_menu01.Enabled = True
            CType(Me.MdiParent, CNL2010).btn_menu02.Enabled = True
            CType(Me.MdiParent, CNL2010).btn_menu03.Enabled = True
            CType(Me.MdiParent, CNL2010).btn_menu04.Enabled = True
            CType(Me.MdiParent, CNL2010).btn_menu05.Enabled = True
            CType(Me.MdiParent, CNL2010).btn_menu06.Enabled = True
            CType(Me.MdiParent, CNL2010).btn_menu07.Enabled = True
            CType(Me.MdiParent, CNL2010).btn_menu08.Enabled = True
            CType(Me.MdiParent, CNL2010).btn_menu09.Enabled = True
            CType(Me.MdiParent, CNL2010).btn_menu10.Enabled = True
            CType(Me.MdiParent, CNL2010).btn_menu11.Enabled = True

        Else
            'False�̏ꍇ�i�t�H�[���R���g���[���̃��b�N�j
            Me.TabControl1.Enabled = False
            Me.btn_Deli_Import.Enabled = False
            btn_OMOTENASHI_Import.Enabled = False
            Me.btn_BackupImport.Enabled = False
            Me.btn_Reference.Enabled = False
            Me.btnSalesUplode.Enabled = False
            CType(Me.MdiParent, CNL2010).btn_menu01.Enabled = False
            CType(Me.MdiParent, CNL2010).btn_menu02.Enabled = False
            CType(Me.MdiParent, CNL2010).btn_menu03.Enabled = False
            CType(Me.MdiParent, CNL2010).btn_menu04.Enabled = False
            CType(Me.MdiParent, CNL2010).btn_menu05.Enabled = False
            CType(Me.MdiParent, CNL2010).btn_menu06.Enabled = False
            CType(Me.MdiParent, CNL2010).btn_menu07.Enabled = False
            CType(Me.MdiParent, CNL2010).btn_menu08.Enabled = False
            CType(Me.MdiParent, CNL2010).btn_menu09.Enabled = False
            CType(Me.MdiParent, CNL2010).btn_menu10.Enabled = False
            CType(Me.MdiParent, CNL2010).btn_menu11.Enabled = False

        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���O�o��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2018.10.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_WriteLogFTP(ByVal strTxt As String)

        Dim textFile As System.IO.StreamWriter
        Dim strDateNow As String = ""

        Try
            strDateNow = Format(Now, "yyyyMMddhhmmss")

            textFile = New System.IO.StreamWriter("C:\CrossNavi\Log\" & strDateNow & "(FTP).txt", True, System.Text.Encoding.Default)

            textFile.WriteLine(strTxt)
            textFile.Close()
        Catch ex As Exception

        End Try

    End Sub
    ' 2018.05.23 �{���z�M�@�N���X�R�k��

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���i�摜�t�H���_�� ���g�p�摜�t�@�C���폜����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2021.08.05 �Q���g
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

        '------------------------------
        ' �g�p���摜�t�@�C���ꗗ�擾(���j���[�O���[�v)
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM061.FILENM AS IMAGEPATH"
        strSQL = strSQL & "  FROM TPM061"
        strSQL = strSQL & " WHERE LEN(LTrim(TPM061.FILENM)) <> 0"
        '������@�\�Ή�
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            strSQL = strSQL & " UNION "
            strSQL = strSQL & "SELECT TPM061A.FILENM AS IMAGEPATH"
            strSQL = strSQL & "  FROM TPM061A"
            strSQL = strSQL & " WHERE LEN(LTrim(TPM061A.FILENM)) <> 0"
            strSQL = strSQL & " UNION "
            strSQL = strSQL & "SELECT TPM061B.FILENM AS IMAGEPATH"
            strSQL = strSQL & "  FROM TPM061B"
            strSQL = strSQL & " WHERE LEN(LTrim(TPM061B.FILENM)) <> 0"
            strSQL = strSQL & " UNION "
            strSQL = strSQL & "SELECT TPM061C.FILENM AS IMAGEPATH"
            strSQL = strSQL & "  FROM TPM061C"
            strSQL = strSQL & " WHERE LEN(LTrim(TPM061C.FILENM)) <> 0"
        End If

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If
            ReDim Preserve strUFile(lngCnt)
            strUFile(lngCnt) = Trim$(objRows("IMAGEPATH"))

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' �摜�t�@�C���g�p������
        '------------------------------
        If objData.Tables("com").Rows.Count <> 0 Then
            strItemPath = GF_GetAppInfo("MENUIMG_V")
            For Each strFile In System.IO.Directory.GetFiles(strItemPath)
                objFileInfo = New System.IO.FileInfo(strFile)
                blnFound = False
                targetPrgLabel.Text = "�摜�g�p������F" + objFileInfo.Name
                '------------------------------
                ' ���j���[�摜��GroupImage�Ɋi�[�B�t�@�C�����̓�������"M"�̓��j���[�摜�̂��߁A�폜���Ȃ�
                '------------------------------
                If Mid(objFileInfo.Name, 1, 1) <> "M" Then
                    For Each strWork In strUFile
                        If objFileInfo.Name = strWork Or _
                           objFileInfo.Name = "S_" & strWork Then
                            blnFound = True
                        End If
                    Next
                    objFileInfo = Nothing

                    '------------------------------
                    ' ���g�p�t�@�C���ł���΍폜
                    '------------------------------
                    If Not blnFound Then
                        Call System.IO.File.SetAttributes(strFile, IO.FileAttributes.Normal)
                        Call System.IO.File.Delete(strFile)
                        Debug.WriteLine(strFile)
                    End If
                End If
            Next
        End If

        '------------------------------
        ' �g�p���摜�t�@�C���ꗗ�擾(�O���[�v)
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM020.GROUPIMAGE AS IMAGEPATH "
        strSQL = strSQL & "  FROM TPM020"
        strSQL = strSQL & " WHERE TPM020.GOODSCD = '0000'"
        strSQL = strSQL & "   AND LEN(LTRIM(TPM020.GROUPIMAGE)) <> 0"
        strSQL = strSQL & " GROUP BY TPM020.GROUPCD,"
        strSQL = strSQL & "          TPM020.GROUPIMAGE"
        '������@�\�Ή�
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            strSQL = strSQL & " UNION "
            strSQL = strSQL & "SELECT TPM020A.GROUPIMAGE AS IMAGEPATH "
            strSQL = strSQL & "  FROM TPM020A"
            strSQL = strSQL & " WHERE TPM020A.GOODSCD = '0000'"
            strSQL = strSQL & "   AND LEN(LTRIM(TPM020A.GROUPIMAGE)) <> 0"
            strSQL = strSQL & " GROUP BY TPM020A.GROUPCD,"
            strSQL = strSQL & "          TPM020A.GROUPIMAGE"
            strSQL = strSQL & " UNION "
            strSQL = strSQL & "SELECT TPM020B.GROUPIMAGE AS IMAGEPATH "
            strSQL = strSQL & "  FROM TPM020B"
            strSQL = strSQL & " WHERE TPM020B.GOODSCD = '0000'"
            strSQL = strSQL & "   AND LEN(LTRIM(TPM020B.GROUPIMAGE)) <> 0"
            strSQL = strSQL & " GROUP BY TPM020B.GROUPCD,"
            strSQL = strSQL & "          TPM020B.GROUPIMAGE"
            strSQL = strSQL & " UNION "
            strSQL = strSQL & "SELECT TPM020C.GROUPIMAGE AS IMAGEPATH "
            strSQL = strSQL & "  FROM TPM020C"
            strSQL = strSQL & " WHERE TPM020C.GOODSCD = '0000'"
            strSQL = strSQL & "   AND LEN(LTRIM(TPM020C.GROUPIMAGE)) <> 0"
            strSQL = strSQL & " GROUP BY TPM020C.GROUPCD,"
            strSQL = strSQL & "          TPM020C.GROUPIMAGE"
        End If

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If
            ReDim Preserve strUFile(lngCnt)
            strUFile(lngCnt) = Trim$(objRows("IMAGEPATH"))

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' �摜�t�@�C���g�p������
        '------------------------------
        If objData.Tables("com").Rows.Count <> 0 Then
            strItemPath = GF_GetAppInfo("GROUP_PATH")
            For Each strFile In System.IO.Directory.GetFiles(strItemPath)
                objFileInfo = New System.IO.FileInfo(strFile)
                blnFound = False
                '------------------------------
                ' ���j���[�摜��GroupImage�Ɋi�[�B�t�@�C�����̓�������"M"�̓��j���[�摜�̂��߁A�폜���Ȃ�
                '------------------------------
                If Mid(objFileInfo.Name, 1, 1) <> "M" Then
                    For Each strWork In strUFile
                        If objFileInfo.Name = strWork Or _
                           objFileInfo.Name = "S_" & strWork Then
                            blnFound = True
                        End If
                    Next
                    objFileInfo = Nothing

                    '------------------------------
                    ' ���g�p�t�@�C���ł���΍폜
                    '------------------------------
                    If Not blnFound Then
                        Call System.IO.File.SetAttributes(strFile, IO.FileAttributes.Normal)
                        Call System.IO.File.Delete(strFile)
                        Debug.WriteLine(strFile)
                    End If
                End If
            Next
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_DelUnuseFile = True

    End Function

    Function NullToBlank(ByVal fgGoOrBack As Boolean) As Boolean
        NullToBlank = False
        If Not NullToBlankSub(fgGoOrBack, "TPM541", "wording") Then
            Exit Function
        End If
        If Not NullToBlankSub(fgGoOrBack, "TPM555", "category_title") Then
            Exit Function
        End If
        If Not NullToBlankSub(fgGoOrBack, "TPM556", "category_title") Then
            Exit Function
        End If
        If Not NullToBlankSub(fgGoOrBack, "TPM557", "goods_cd") Then
            Exit Function
        End If
        If Not NullToBlankSub(fgGoOrBack, "TPM560", "category_title") Then
            Exit Function
        End If
        If Not NullToBlankSub(fgGoOrBack, "TPM560", "GROUPCD") Then
            Exit Function
        End If
        If Not NullToBlankSub(fgGoOrBack, "TPM565", "wording") Then
            Exit Function
        End If
        NullToBlank = True
    End Function

    Function NullToBlankSub(ByVal fgGoOrBack As Boolean, ByVal tableName As String, ByVal fieldName As String) As Boolean
        NullToBlankSub = False
        Dim strSQL As String
        If fgGoOrBack Then
            strSQL = "UPDATE " & tableName & " SET " & fieldName & " = '' WHERE " & fieldName & " IS NULL"
            If Not GF_UpdData(strSQL) Then
                Exit Function
            End If
            strSQL = "UPDATE " & tableName & " SET " & fieldName & " = '_' WHERE " & fieldName & "  = ''"
            If Not GF_UpdData(strSQL) Then
                Exit Function
            End If
        Else
            strSQL = "UPDATE " & tableName & " SET " & fieldName & " = '' WHERE " & fieldName & "  = '_'"
            If Not GF_UpdData(strSQL) Then
                Exit Function
            End If
        End If
        NullToBlankSub = True
    End Function

    Private Sub getFTPUserPass(ByRef pFTPId As String, ByRef pFTPPass As String)
        pFTPId = Trim$(GF_GetAppInfo("DELI_FTP_ID"))
        pFTPPass = Trim$(GF_GetAppInfo("DELI_FTP_PW"))
        If pFTPId = "" Then
            pFTPId = "ftp"
            pFTPPass = ""
        End If
    End Sub

End Class
