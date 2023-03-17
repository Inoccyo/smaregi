Imports System.Data.SqlClient

' --------------------------------------------------------------------------------
' 　機　　能：CrossNavi - 各種設定画面
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2011.11.07 ソラン北陸 新規作成
' --------------------------------------------------------------------------------
Public Class CNL2130
    Inherits System.Windows.Forms.Form


#Region " Windows フォーム デザイナで生成されたコード "

    Public Sub New()
        MyBase.New()

        ' この呼び出しは Windows フォーム デザイナで必要です。
        InitializeComponent()
        ProgressLabelDeli.Text = ""
        ProgressLabelOMOTENASHI.Text = ""

        ' InitializeComponent() 呼び出しの後に初期化を追加します。

    End Sub

    ' Form は dispose をオーバーライドしてコンポーネント一覧を消去します。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    ' メモ : 以下のプロシージャは、Windows フォーム デザイナで必要です。
    ' Windows フォーム デザイナを使って変更してください。  
    ' コード エディタは使用しないでください。
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"aaa", "a2", "a3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"bbb"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ccc"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"aaa", "a2", "a3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"bbb"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ccc"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
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
        Me.TabControl1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold)
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
        Me.TabPage2.Text = "画面体裁設定"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(404, 460)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(147, 15)
        Me.Label21.TabIndex = 230
        Me.Label21.Text = "■ 厨房警告時間表示"
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
        Me.GroupBox13.Text = "厨房警告時間表示"
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
        Me.Label32.Text = "秒"
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(238, 65)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(22, 15)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "秒"
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(238, 27)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(22, 15)
        Me.Label30.TabIndex = 3
        Me.Label30.Text = "秒"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(44, 103)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 15)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "3回目"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(44, 68)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 15)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "2回目"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(44, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 15)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "1回目"
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
        Me.GroupBox11.Text = "端数処理"
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
        Me.Label20.Text = "入"
        '
        'Label19
        '
        Me.Label19.Image = Global.CNL1501.My.Resources.Resources.back2
        Me.Label19.Location = New System.Drawing.Point(208, 32)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(22, 16)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "捨"
        '
        'Label18
        '
        Me.Label18.Image = Global.CNL1501.My.Resources.Resources.back2
        Me.Label18.Location = New System.Drawing.Point(20, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(111, 16)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "小数点第一位"
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
        Me.GroupBox9.Text = "消費税率"
        '
        'Label16
        '
        Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
        Me.Label16.Location = New System.Drawing.Point(266, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(22, 16)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "％"
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
        Me.GroupBox7.Text = "パターン切り替え"
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
        Me.Label15.Text = "■ 消費税設定"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("MS UI Gothic", 11.25!)
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.Location = New System.Drawing.Point(22, 306)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(200, 23)
        Me.Label14.TabIndex = 224
        Me.Label14.Text = "■ トップ画面表示パターン変更"
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
        Me.GroupBox10.Text = "品切れ文字設定"
        '
        'text_sold_out4
        '
        Me.text_sold_out4.Location = New System.Drawing.Point(126, 123)
        Me.text_sold_out4.Name = "text_sold_out4"
        Me.text_sold_out4.Size = New System.Drawing.Size(134, 22)
        Me.text_sold_out4.TabIndex = 7
        Me.text_sold_out4.Text = "明日入荷"
        '
        'text_sold_out3
        '
        Me.text_sold_out3.Location = New System.Drawing.Point(126, 89)
        Me.text_sold_out3.Name = "text_sold_out3"
        Me.text_sold_out3.Size = New System.Drawing.Size(134, 22)
        Me.text_sold_out3.TabIndex = 6
        Me.text_sold_out3.Text = "入荷待ち"
        '
        'text_sold_out2
        '
        Me.text_sold_out2.Location = New System.Drawing.Point(126, 56)
        Me.text_sold_out2.Name = "text_sold_out2"
        Me.text_sold_out2.Size = New System.Drawing.Size(134, 22)
        Me.text_sold_out2.TabIndex = 5
        Me.text_sold_out2.Text = "仕込み中"
        '
        'text_sold_out1
        '
        Me.text_sold_out1.Location = New System.Drawing.Point(126, 23)
        Me.text_sold_out1.Name = "text_sold_out1"
        Me.text_sold_out1.Size = New System.Drawing.Size(134, 22)
        Me.text_sold_out1.TabIndex = 4
        Me.text_sold_out1.Text = "品切れ"
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
        Me.Label8.Text = "■ 店舗情報設定"
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
        Me.GroupBox8.Text = "店舗ロゴ"
        '
        'rdo_Logo_Hide
        '
        Me.rdo_Logo_Hide.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Logo_Hide.Image = CType(resources.GetObject("rdo_Logo_Hide.Image"), System.Drawing.Image)
        Me.rdo_Logo_Hide.Location = New System.Drawing.Point(176, 24)
        Me.rdo_Logo_Hide.Name = "rdo_Logo_Hide"
        Me.rdo_Logo_Hide.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Logo_Hide.TabIndex = 1
        Me.rdo_Logo_Hide.Text = "表示しない"
        '
        'rdo_Logo_Show
        '
        Me.rdo_Logo_Show.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Logo_Show.Image = CType(resources.GetObject("rdo_Logo_Show.Image"), System.Drawing.Image)
        Me.rdo_Logo_Show.Location = New System.Drawing.Point(48, 24)
        Me.rdo_Logo_Show.Name = "rdo_Logo_Show"
        Me.rdo_Logo_Show.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Logo_Show.TabIndex = 0
        Me.rdo_Logo_Show.Text = "表示する"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(404, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(248, 16)
        Me.Label7.TabIndex = 215
        Me.Label7.Text = "■ 店舗ロゴ表示設定"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(22, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(248, 16)
        Me.Label6.TabIndex = 214
        Me.Label6.Text = "■ 広告表示設定"
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
        Me.GroupBox1.Text = "時間設定"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(266, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 16)
        Me.Label4.TabIndex = 219
        Me.Label4.Text = "秒"
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
        Me.Label5.Text = "広告画像の切替時間"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(266, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 16)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "秒"
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
        Me.Label1.Text = "広告表示までの待ち時間"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(22, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 16)
        Me.Label3.TabIndex = 212
        Me.Label3.Text = "■ 画面表示設定"
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
        Me.GroupBox3.Text = "『呼出』ボタン"
        '
        'rdo_Call_Hide
        '
        Me.rdo_Call_Hide.Image = CType(resources.GetObject("rdo_Call_Hide.Image"), System.Drawing.Image)
        Me.rdo_Call_Hide.Location = New System.Drawing.Point(176, 24)
        Me.rdo_Call_Hide.Name = "rdo_Call_Hide"
        Me.rdo_Call_Hide.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Call_Hide.TabIndex = 3
        Me.rdo_Call_Hide.Text = "表示しない"
        '
        'rdo_Call_Show
        '
        Me.rdo_Call_Show.Image = CType(resources.GetObject("rdo_Call_Show.Image"), System.Drawing.Image)
        Me.rdo_Call_Show.Location = New System.Drawing.Point(48, 24)
        Me.rdo_Call_Show.Name = "rdo_Call_Show"
        Me.rdo_Call_Show.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Call_Show.TabIndex = 2
        Me.rdo_Call_Show.Text = "表示する"
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
        Me.GroupBox2.Text = "小計項目"
        '
        'rdo_Hide
        '
        Me.rdo_Hide.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Hide.Image = CType(resources.GetObject("rdo_Hide.Image"), System.Drawing.Image)
        Me.rdo_Hide.Location = New System.Drawing.Point(176, 24)
        Me.rdo_Hide.Name = "rdo_Hide"
        Me.rdo_Hide.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Hide.TabIndex = 1
        Me.rdo_Hide.Text = "表示しない"
        '
        'rdo_Show
        '
        Me.rdo_Show.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Show.Image = CType(resources.GetObject("rdo_Show.Image"), System.Drawing.Image)
        Me.rdo_Show.Location = New System.Drawing.Point(48, 24)
        Me.rdo_Show.Name = "rdo_Show"
        Me.rdo_Show.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Show.TabIndex = 0
        Me.rdo_Show.Text = "表示する"
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
        Me.GroupBox5.Text = "『お会計』ボタン"
        '
        'rdo_Kaikei_Hide
        '
        Me.rdo_Kaikei_Hide.Image = CType(resources.GetObject("rdo_Kaikei_Hide.Image"), System.Drawing.Image)
        Me.rdo_Kaikei_Hide.Location = New System.Drawing.Point(176, 24)
        Me.rdo_Kaikei_Hide.Name = "rdo_Kaikei_Hide"
        Me.rdo_Kaikei_Hide.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Kaikei_Hide.TabIndex = 1
        Me.rdo_Kaikei_Hide.Text = "表示しない"
        '
        'rdo_Kaikei_Show
        '
        Me.rdo_Kaikei_Show.Image = CType(resources.GetObject("rdo_Kaikei_Show.Image"), System.Drawing.Image)
        Me.rdo_Kaikei_Show.Location = New System.Drawing.Point(48, 24)
        Me.rdo_Kaikei_Show.Name = "rdo_Kaikei_Show"
        Me.rdo_Kaikei_Show.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Kaikei_Show.TabIndex = 0
        Me.rdo_Kaikei_Show.Text = "表示する"
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
        Me.GroupBox4.Text = "『割勘』ボタン"
        '
        'rdo_Warikan_Hide
        '
        Me.rdo_Warikan_Hide.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Warikan_Hide.Image = CType(resources.GetObject("rdo_Warikan_Hide.Image"), System.Drawing.Image)
        Me.rdo_Warikan_Hide.Location = New System.Drawing.Point(176, 24)
        Me.rdo_Warikan_Hide.Name = "rdo_Warikan_Hide"
        Me.rdo_Warikan_Hide.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Warikan_Hide.TabIndex = 1
        Me.rdo_Warikan_Hide.Text = "表示しない"
        '
        'rdo_Warikan_Show
        '
        Me.rdo_Warikan_Show.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_Warikan_Show.Image = CType(resources.GetObject("rdo_Warikan_Show.Image"), System.Drawing.Image)
        Me.rdo_Warikan_Show.Location = New System.Drawing.Point(48, 24)
        Me.rdo_Warikan_Show.Name = "rdo_Warikan_Show"
        Me.rdo_Warikan_Show.Size = New System.Drawing.Size(112, 24)
        Me.rdo_Warikan_Show.TabIndex = 0
        Me.rdo_Warikan_Show.Text = "表示する"
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
        Me.TabPage4.Text = "売上データ出力"
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
        Me.Label25.Text = "商品が注文された時間帯と数量をまとめた" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "売上データをCSVファイルで出力します"
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
        Me.Label12.Text = "売上データ出力先"
        '
        'btn_BrowseCsv
        '
        Me.btn_BrowseCsv.BackColor = System.Drawing.SystemColors.Control
        Me.btn_BrowseCsv.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_BrowseCsv.Location = New System.Drawing.Point(476, 113)
        Me.btn_BrowseCsv.Name = "btn_BrowseCsv"
        Me.btn_BrowseCsv.Size = New System.Drawing.Size(48, 24)
        Me.btn_BrowseCsv.TabIndex = 157
        Me.btn_BrowseCsv.Text = "参照"
        Me.btn_BrowseCsv.UseVisualStyleBackColor = False
        '
        'txt_PutPathCsv
        '
        Me.txt_PutPathCsv.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_PutPathCsv.Location = New System.Drawing.Point(20, 115)
        Me.txt_PutPathCsv.Name = "txt_PutPathCsv"
        Me.txt_PutPathCsv.Size = New System.Drawing.Size(450, 22)
        Me.txt_PutPathCsv.TabIndex = 156
        Me.txt_PutPathCsv.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"
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
        Me.btn_OutputCsv.Text = "売上データ出力"
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
        Me.TabPage1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(805, 626)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "データバックアップ"
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
        Me.Label10.Text = "データバックアップ出力先"
        '
        'btn_Browse
        '
        Me.btn_Browse.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Browse.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Browse.Location = New System.Drawing.Point(476, 113)
        Me.btn_Browse.Name = "btn_Browse"
        Me.btn_Browse.Size = New System.Drawing.Size(48, 24)
        Me.btn_Browse.TabIndex = 152
        Me.btn_Browse.Text = "参照"
        Me.btn_Browse.UseVisualStyleBackColor = False
        '
        'txt_PutPath
        '
        Me.txt_PutPath.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_PutPath.Location = New System.Drawing.Point(20, 115)
        Me.txt_PutPath.Name = "txt_PutPath"
        Me.txt_PutPath.Size = New System.Drawing.Size(450, 22)
        Me.txt_PutPath.TabIndex = 151
        Me.txt_PutPath.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"
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
        Me.btn_Output.Text = "データ出力"
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
        Me.TabPage3.Text = "送信メッセージ編集"
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
        Me.GroupBox6.Text = "送信メッセージ編集"
        '
        'txt_Msg1
        '
        Me.txt_Msg1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Msg1.Location = New System.Drawing.Point(119, 32)
        Me.txt_Msg1.Name = "txt_Msg1"
        Me.txt_Msg1.Size = New System.Drawing.Size(280, 22)
        Me.txt_Msg1.TabIndex = 275
        Me.txt_Msg1.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.Location = New System.Drawing.Point(18, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 16)
        Me.Label17.TabIndex = 274
        Me.Label17.Text = "メッセージ"
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
        Me.btn_Del.Text = "選択中のメッセージ削除"
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
        Me.btn_Add.Text = "メッセージ追加"
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
        Me.TabPage5.Text = "注文一覧"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lsv_OrderDetails
        '
        Me.lsv_OrderDetails.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
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
        Me.btn_Reprint.Text = "再印字"
        Me.btn_Reprint.UseVisualStyleBackColor = False
        '
        'lsv_OrderList
        '
        Me.lsv_OrderList.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
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
        Me.GroupBox12.Text = "座席番号絞込み"
        '
        'cbo_SeatChg
        '
        Me.cbo_SeatChg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_SeatChg.Location = New System.Drawing.Point(27, 21)
        Me.cbo_SeatChg.Name = "cbo_SeatChg"
        Me.cbo_SeatChg.Size = New System.Drawing.Size(279, 23)
        Me.cbo_SeatChg.TabIndex = 30
        Me.cbo_SeatChg.Text = "座席番号"
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
        Me.TabPage6.Text = "TECデータ取込"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'btn_ImportTECData
        '
        Me.btn_ImportTECData.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_ImportTECData.Location = New System.Drawing.Point(20, 10)
        Me.btn_ImportTECData.Name = "btn_ImportTECData"
        Me.btn_ImportTECData.Size = New System.Drawing.Size(180, 50)
        Me.btn_ImportTECData.TabIndex = 0
        Me.btn_ImportTECData.Text = "TECデータ取込"
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
        Me.TabPage7.Text = "ゲーム設定"
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
        Me.lbl_order.Text = "現在、値を～"
        '
        'lbl_judge
        '
        Me.lbl_judge.AutoSize = True
        Me.lbl_judge.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_judge.Location = New System.Drawing.Point(45, 215)
        Me.lbl_judge.Name = "lbl_judge"
        Me.lbl_judge.Size = New System.Drawing.Size(143, 15)
        Me.lbl_judge.TabIndex = 3
        Me.lbl_judge.Text = "システム○○中です。"
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
        Me.GroupBox15.Text = "1ゲームプレイするための注文数"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(54, 24)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(156, 15)
        Me.Label35.TabIndex = 1
        Me.Label35.Text = "商品注文で1ゲームプレイ"
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
        Me.GroupBox14.Text = "ゲーム当たり判定回数"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(54, 24)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(162, 15)
        Me.Label34.TabIndex = 1
        Me.Label34.Text = "回ゲームプレイで1回当たり"
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
        Me.Label33.Text = "■ゲーム当たり設定"
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
        Me.TabPage8.Text = "出力先パターン設定"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Location = New System.Drawing.Point(361, 140)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "保存"
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
        Me.Column1.HeaderText = "出力先"
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
        Me.Label42.Text = "■出力先パターン設定"
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
        Me.btnDec.Text = "決定"
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
        Me.Label45.Text = "■現在使用している出力先パターン"
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
        Me.TabPage9.Text = "本部配信"
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
        Me.Label48.Text = "取込状況"
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
        Me.Label43.Text = "売上データを集計し、" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "本部SVにアップロードします。"
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
        Me.btnSalesUplode.Text = "売上データ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "アップロード"
        Me.btnSalesUplode.UseVisualStyleBackColor = False
        '
        'lbl_Msg3
        '
        Me.lbl_Msg3.Location = New System.Drawing.Point(191, 162)
        Me.lbl_Msg3.Name = "lbl_Msg3"
        Me.lbl_Msg3.Size = New System.Drawing.Size(324, 78)
        Me.lbl_Msg3.TabIndex = 9
        Me.lbl_Msg3.Text = "バックアップデータより" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "メニューを復元します。"
        Me.lbl_Msg3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Msg2
        '
        Me.lbl_Msg2.Location = New System.Drawing.Point(6, 90)
        Me.lbl_Msg2.Name = "lbl_Msg2"
        Me.lbl_Msg2.Size = New System.Drawing.Size(85, 23)
        Me.lbl_Msg2.TabIndex = 8
        Me.lbl_Msg2.Text = "取込状況"
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
        Me.lbl_Msg1.Text = "本部より配信される" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "メニューデータを取り込みます。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "４５～６０分程お時間を頂戴します。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "※回線状況により上記より掛かる場合があります。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.btn_Reference.Text = "参照"
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
        Me.btn_BackupImport.Text = "バックアップ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "メニューデータ取込"
        Me.btn_BackupImport.UseVisualStyleBackColor = False
        '
        'btn_Deli_Import
        '
        Me.btn_Deli_Import.BackColor = System.Drawing.Color.LightGray
        Me.btn_Deli_Import.Location = New System.Drawing.Point(6, 6)
        Me.btn_Deli_Import.Name = "btn_Deli_Import"
        Me.btn_Deli_Import.Size = New System.Drawing.Size(165, 78)
        Me.btn_Deli_Import.TabIndex = 1
        Me.btn_Deli_Import.Text = "本部メニューデータ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "取込"
        Me.btn_Deli_Import.UseVisualStyleBackColor = False
        '
        'btn_OMOTENASHI_Import
        '
        Me.btn_OMOTENASHI_Import.BackColor = System.Drawing.Color.LightGray
        Me.btn_OMOTENASHI_Import.Enabled = False
        Me.btn_OMOTENASHI_Import.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_OMOTENASHI_Import.Location = New System.Drawing.Point(6, 402)
        Me.btn_OMOTENASHI_Import.Name = "btn_OMOTENASHI_Import"
        Me.btn_OMOTENASHI_Import.Size = New System.Drawing.Size(165, 78)
        Me.btn_OMOTENASHI_Import.TabIndex = 88
        Me.btn_OMOTENASHI_Import.Text = "OMOTENASHIデータ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "取込"
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
        Me.MenuItem1.Text = "各種設定"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "-"
        '
        'mnu_End
        '
        Me.mnu_End.Index = 1
        Me.mnu_End.Text = "終了(&E)"
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
        Me.Label36.Text = "現在、値を～"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label37.Location = New System.Drawing.Point(45, 215)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(143, 15)
        Me.Label37.TabIndex = 3
        Me.Label37.Text = "システム○○中です。"
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
        Me.GroupBox16.Text = "1ゲームプレイするための注文数"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(54, 24)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(156, 15)
        Me.Label38.TabIndex = 1
        Me.Label38.Text = "商品注文で1ゲームプレイ"
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
        Me.GroupBox17.Text = "ゲーム当たり判定回数"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(54, 24)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(162, 15)
        Me.Label39.TabIndex = 1
        Me.Label39.Text = "回ゲームプレイで1回当たり"
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
        Me.Label40.Text = "■ゲーム当たり設定"
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
    ' モジュール内変数定義
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
        ' 2014-07-05 品切れ名称2種が変更できない不具合修正
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

    ' START 2016.05.10 田代
    Private Enum typUpdata_game

        GAMEHITNUM = 0
        GAMEPLAYNUM = 1

    End Enum
    ' END 2016.05.10 田代

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
    ' モジュール内ユーザ定義型定義
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
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub CNL2130_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            '------------------------------
            ' フォーム名称設定
            '------------------------------
            Me.Text = " 各種設定 "

            '---------------------------------
            ' 閉じるボタン非表示化
            '---------------------------------
            Me.ControlBox = False

            '------------------------------
            ' 初期化処理
            '------------------------------
            Call GS_StatusSetup(stb_Msg)

            '------------------------------
            ' 画面体裁設定 表示処理
            '------------------------------
            Call LS_SetInitForm()

            L_blnEdit = False

            If GF_GetAppInfo("RECEIPT_PRINTING") = 1 Then
                TabControl1.TabPages.Remove(TabPage5)
            End If

            '------------------------------
            ' 2015.9.29 OA) TECデータ取込
            '------------------------------
            If Not (GF_GetAppInfo("SYS_TYPE") = 2 And GF_GetAppInfo("OES_TOOL_VER") = 0 And GF_GetAppInfo("OES_TOOL_VER_CNL1501") = 0) Then
                TabControl1.TabPages.Remove(TabPage6)
            End If

            '--------------------------------
            ' 2016.05.10 田代 ゲーム機能修正
            '--------------------------------
            If Not GF_GetAppInfo2("CNWH_GAMEFLG") = 1 Then
                TabControl1.TabPages.Remove(TabPage7)
            End If

            ' 2017.01.01 がってん寿司向け クレスコ北陸 田代
            If Not GF_GetAppInfo3("KCP_PTN_FLG") = "1" Then
                TabControl1.TabPages.Remove(TabPage8)
            End If
            ' 2017.01.01 がってん寿司向け クレスコ北陸 田代

            ' 2017.10.01 本部配信 クレスコ北陸 田代
            If GF_GetAppInfo("DELIVARY_FLG") = "0" Then
                TabControl1.TabPages.Remove(TabPage9)
            End If
            ' 2017.10.01 本部配信 クレスコ北陸 田代

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
    ' 　機　　能：メニュー - [終了]押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub mnu_End_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_End.Click
        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：「データ出力」ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Output_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Output.Click
        targetPrgLabel = ProgressLabelDeli
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objInfo As typConnectionInfo = Nothing

        With objInfo
            .strSVNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer Name"))
            .strDBNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer DBName"))
            .strUserNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer UserID"))
            .strPasswd = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer PassWD"))

        End With

        '------------------------------
        ' ディレクトリ存在チェック
        '------------------------------
        If System.IO.Directory.Exists(txt_PutPath.Text) = False Then
            '------------------------------
            ' ダイアログ表示
            '------------------------------
            Call LS_SetSelPath()
        End If

        If Len(txt_PutPath.Text) <> 0 Then
            Me.Cursor = Cursors.WaitCursor

            '------------------------------
            ' データエクスポート
            '------------------------------
            Call LS_DataExport(objInfo)

            Me.Cursor = Cursors.Default
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ダイアログ表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetSelPath()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objFolder As New BrowseFolder()
        Dim strSelPath As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        Try
            strSelPath = objFolder.BrowseDialog("フォルダを指定してください", Me)
            txt_PutPath.Text = strSelPath
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetSelPath")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：データエクスポート処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：
    ' --------------------------------------------------------------------------------
    Private Sub LS_DataExport(ByVal pInfo As typConnectionInfo)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strExpPath As String

        With pInfo
            .strAdvPath = Trim$(GF_GetAppInfo("ADV_PATH"))
            .strItemPath = Trim$(GF_GetAppInfo("ITEM_PATH"))
            .strGrpPath = Trim$(GF_GetAppInfo("GROUP_PATH"))
            .strMenuGrpPath = Trim$(GF_GetAppInfo("MENUIMG_V"))
            .strStoreMkPath = Trim$(GF_GetAppInfo("STOREMARK_V"))

            ' コピー元パス取得
            strExpPath = txt_PutPath.Text
        End With

        '------------------------------
        ' エクスポートパス準備
        '------------------------------
        If Len(Trim$(Dir(strExpPath, FileAttribute.Directory))) = 0 Then
            If GF_Msg("", _
                      "指定されたパスが見つかりません。作成しますか？" & vbCrLf & _
                      "[" & strExpPath & "]", _
                      MsgBoxStyle.YesNo, _
                      MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Try
                    System.IO.Directory.CreateDirectory(strExpPath)
                Catch
                    Call GF_Msg("", "フォルダの作成に失敗しました" & vbCrLf & "再度設定を確認して下さい", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
                    Exit Sub
                End Try
            End If
        End If

        Try
            strExpPath = strExpPath & "\BackUpData(" & Format$(Now, "yyyyMMddHHmmss") & ")"
            System.IO.Directory.CreateDirectory(strExpPath)
        Catch
            Call GF_Msg("", "フォルダの作成に失敗しました" & vbCrLf & "再度設定を確認して下さい", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

        '------------------------------
        ' BCPエクスポート
        '------------------------------
        If Not LF_TableBackup(strExpPath & "\TableData", pInfo) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' DBごとバックアップ
        '------------------------------
        If Not LF_DBBackup(strExpPath & "\TableData", pInfo) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' 画像ファイルコピー
        '------------------------------
        If Not LF_ImageBackup(strExpPath & "\ImageData", pInfo) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' インポート用バッチファイル生成
        '------------------------------
        If Not LF_CreateRestoreBatch(strExpPath, pInfo) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' 終了メッセージ表示
        '------------------------------
        Call GF_Msg("", "データエクスポートが完了しました" & vbCrLf & "[" & strExpPath & "]", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_DataExport")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：テーブル退避処理
    ' 　機能概要：省略
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_TableBackup(ByVal pTargetPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim intProcID As Integer
        Dim strCmdLine As String
        Dim wkdouble As Double

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_TableBackup = False

        '------------------------------
        ' 全テーブル一覧取得
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
                strCmdLine = strCmdLine & " " & pInfo.strDBNM & ".." & Trim$(objRows("NAME"))   ' 退避テーブル名
                strCmdLine = strCmdLine & " out"                                                ' エクスポート指定
                strCmdLine = strCmdLine & " """ & pTargetPath & "\" & _
                                                Trim$(objRows("NAME")) & ".txt"""               ' 退避ファイル名"
                strCmdLine = strCmdLine & " -S " & pInfo.strSVNM
                strCmdLine = strCmdLine & " -U " & pInfo.strUserNM
                strCmdLine = strCmdLine & " -P " & pInfo.strPasswd

                ' 数値型への変換可否チェック
                If Double.TryParse(Trim$(objRows("NAME")).Substring(Trim$(objRows("NAME")).Length - 1, 1), wkdouble) Then
                    ' 数値型(多言語テーブル)の場合
                    strCmdLine = strCmdLine & " -c -t ,"
                Else
                    ' 数値型以外(通常テーブル)の場合
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
        ' 返却値設定
        '------------------------------
        LF_TableBackup = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：テーブル退避処理
    ' 　機能概要：省略
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_DeliTableBackup(ByVal pTargetPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim intProcID As Integer
        Dim strCmdLine As String
        Dim wkdouble As Double

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_DeliTableBackup = False

        '------------------------------
        ' 全テーブル一覧取得
        '------------------------------
        Try
            If System.IO.Directory.Exists(pTargetPath) = False Then
                System.IO.Directory.CreateDirectory(pTargetPath)
            End If

            ' 0.01ずつ増加
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
                ' 0.01ずつ増加
                targetPrgBar.Value = targetPrgBar.Value + 0.01

                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    Exit Function
                End If

                targetPrgLabel.Text = "バックアップ：" + objRows("NAME")
                strCmdLine = ""
                strCmdLine = strCmdLine & "BCP"
                strCmdLine = strCmdLine & " " & pInfo.strDBNM & ".." & Trim$(objRows("NAME"))   ' 退避テーブル名
                strCmdLine = strCmdLine & " out"                                                ' エクスポート指定

                If Trim$(objRows("NAME")).IndexOf("B") > 0 Or Trim$(objRows("NAME")).IndexOf("C") > 0 Then
                    strCmdLine = strCmdLine & " """ & pTargetPath & "\" & Trim$(objRows("NAME")) & ".csv"""               ' 退避ファイル名"
                    'strCmdLine = strCmdLine & " -w -t " & """" & "," & """" & " -T -S " & pInfo.strSVNM
                    strCmdLine = strCmdLine & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -w -t ,"
                Else
                    strCmdLine = strCmdLine & " """ & pTargetPath & "\" & Trim$(objRows("NAME")) & ".txt"""               ' 退避ファイル名"
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
        ' 返却値設定
        '------------------------------
        LF_DeliTableBackup = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：テーブル退避処理
    ' 　機能概要：省略
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2014.04.08 クロスドリーム 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_DBBackup(ByVal pTargetPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim intProcID As Integer
        Dim strCmdLine As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_DBBackup = False

        Try
            ' ディレクトリ作成
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
        ' 返却値設定
        '------------------------------
        LF_DBBackup = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像ファイル退避処理
    ' 　機能概要：省略
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_ImageBackup(ByVal pTargetPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_ImageBackup = False

        Try
            '------------------------------
            ' 画像ファイル退避
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
        ' 返却値設定
        '------------------------------
        LF_ImageBackup = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像ファイル退避処理
    ' 　機能概要：省略
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2018.08.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_Deli_ImageBackup(ByVal pTargetPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_Deli_ImageBackup = False

        Try
            '------------------------------
            ' 画像ファイル退避
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
        ' 返却値設定
        '------------------------------
        LF_Deli_ImageBackup = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ファイル転送処理
    ' 　機能概要：省略
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_ImageCopy(ByVal pSourceFld As String, _
                                  ByVal pTargetFld As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strFile As String
        Dim strWork() As String
        Dim strTFile As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_ImageCopy = False

        Try
            '------------------------------
            ' 転送先フォルダ存在チェック
            '------------------------------
            If System.IO.Directory.Exists(pTargetFld) = False Then
                System.IO.Directory.CreateDirectory(pTargetFld)
            End If

            '------------------------------
            ' 転送元フォルダ存在チェック
            '------------------------------
            If System.IO.Directory.Exists(pSourceFld) = False Then
                Exit Function
            End If

            '------------------------------
            ' ファイル転送処理
            '------------------------------
            For Each strFile In System.IO.Directory.GetFiles(pSourceFld, "*.*")
                strWork = Split(strFile, "\")
                strTFile = pTargetFld & "\" & strWork(UBound(strWork))
                If System.IO.File.Exists(strTFile) = True Then                  ' 転送先に、同一ファイル名が存在した場合は削除する
                    System.IO.File.SetAttributes(strTFile, IO.FileAttributes.Normal)
                    System.IO.File.Delete(strTFile)
                End If
                System.IO.File.Copy(strFile, strTFile)
            Next

        Catch
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_ImageCopy = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ファイル転送処理
    ' 　機能概要：省略
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_Deli_ImageCopy(ByVal pSourceFld As String, ByVal pTargetFld As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strFile As String
        Dim strWork() As String
        Dim strTFile As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_Deli_ImageCopy = False

        Try
            '------------------------------
            ' 転送先フォルダ存在チェック
            '------------------------------
            If System.IO.Directory.Exists(pTargetFld) = False Then
                System.IO.Directory.CreateDirectory(pTargetFld)
            End If

            '------------------------------
            ' 転送元フォルダ存在チェック
            '------------------------------
            If System.IO.Directory.Exists(pSourceFld) = False Then
                Exit Function
            End If

            '------------------------------
            ' ファイル転送処理
            '------------------------------
            For Each strFile In System.IO.Directory.GetFiles(pSourceFld, "*.*")
                ' 0.1%ずつ増加
                If targetPrgBar.Value = 999 Then
                    targetPrgBar.Value = 999
                ElseIf targetPrgBar.Value = 52 Then
                    targetPrgBar.Value = 52
                Else
                    targetPrgBar.Value = targetPrgBar.Value + 0.01
                End If

                strWork = Split(strFile, "\")
                strTFile = pTargetFld & "\" & strWork(UBound(strWork))
                targetPrgLabel.Text = "画像移動：" + strTFile
                If System.IO.File.Exists(strTFile) = True Then                  ' 転送先に、同一ファイル名が存在した場合は削除する
                    System.IO.File.SetAttributes(strTFile, IO.FileAttributes.Normal)
                    System.IO.File.Delete(strTFile)
                End If
                System.IO.File.Copy(strFile, strTFile)
            Next

        Catch
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_Deli_ImageCopy = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：RESTOREバッチファイル生成処理
    ' 　機能概要：省略
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_CreateRestoreBatch(ByVal pPutPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        Dim objBatch As System.IO.StreamWriter

        LF_CreateRestoreBatch = False

        Try
            '------------------------------
            ' ファイル出力
            '------------------------------
            targetPrgLabel.Text = ".batファイル作成"
            ' 2014-04-08 データベース全体を一括でバックアップするよう修正
            objBatch = New System.IO.StreamWriter(pPutPath & "\Restore.bat", False, System.Text.Encoding.Default)
            With objBatch
                .WriteLine("@echo off")
                .WriteLine("echo バックアップデータの復元を行います")
                .WriteLine("echo Cross Naviを閉じてください")
                .WriteLine("pause")
                .WriteLine("echo *** バックアップデータのインポート中です ***")

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

                .WriteLine("echo *** 商品画像ファイルのコピー中です ***")
                .WriteLine("xcopy .\ImageData\ItemImage\*.* C:\Inetpub\wwwroot\CNWI001\ItemImage /V /Y /R /Q")

                .WriteLine("echo *** グループ画像ファイルのコピー中です ***")
                .WriteLine("xcopy .\ImageData\GroupImage\*.* C:\Inetpub\wwwroot\CNWI001\GroupImage /V /Y /R /Q")

                .WriteLine("echo *** メニューグループ画像ファイルのコピー中です ***")
                .WriteLine("xcopy .\ImageData\MenuImage\*.* C:\Inetpub\wwwroot\CNWI001\MenuImage /V /Y /R /Q")

                .WriteLine("echo *** 広告画像ファイルのコピー中です ***")
                .WriteLine("xcopy .\ImageData\AdvImage\*.* C:\Inetpub\wwwroot\CNWI001\AdvImage /V /Y /R /Q")

                .WriteLine("echo *** 店舗ロゴファイルのコピー中です ***")
                .WriteLine("xcopy .\ImageData\StoreMark\*.* C:\Inetpub\wwwroot\CNWI001\StoreMark /V /Y /R /Q")

                .WriteLine("echo 終了しました")
                .WriteLine("pause")

                .Close()
            End With
        Catch
            Exit Function
        End Try

        LF_CreateRestoreBatch = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：タブコントロール変更処理
    ' 　機能概要：省略
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        ''------------------------------
        '' 内部変数定義
        ''------------------------------
        'Dim objRet As MsgBoxResult

        'Select Case L_selectTab
        '    Case typSelectTab.Tab1
        '        '------------------------------
        '        ' 更新処理確認
        '        '------------------------------
        '        If L_blnEdit Then
        '            objRet = GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNo)

        '            Select Case objRet
        '                Case MsgBoxResult.Yes
        '                    '------------------------------
        '                    ' トランザクション開始
        '                    '------------------------------
        '                    If Not GF_BeginTrans() Then
        '                        GoTo SYSTEM_ERROR
        '                    End If

        '                    '------------------------------
        '                    ' 更新処理
        '                    '------------------------------
        '                    If Not LF_UpdTPM040() Then
        '                        GoTo SYSTEM_ERROR
        '                    End If

        '                    '------------------------------
        '                    ' トランザクション確定
        '                    '------------------------------
        '                    If Not GF_CommitTrans() Then
        '                        GoTo SYSTEM_ERROR
        '                    End If

        '                Case MsgBoxResult.No

        '            End Select

        '        End If

        '    Case typSelectTab.Tab2
        '        '------------------------------
        '        ' 更新処理確認
        '        '------------------------------
        '        If L_blnEdit Then
        '            objRet = GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNo)

        '            Select Case objRet
        '                Case MsgBoxResult.Yes
        '                    '------------------------------
        '                    ' トランザクション確定
        '                    '------------------------------
        '                    If Not GF_CommitTrans() Then
        '                        GoTo SYSTEM_ERROR
        '                    End If

        '                Case MsgBoxResult.No
        '                    '------------------------------
        '                    ' トランザクション破棄
        '                    '------------------------------
        '                    If Not GF_RollbackTrans() Then
        '                        GoTo SYSTEM_ERROR
        '                    End If

        '            End Select
        '        Else
        '            '------------------------------
        '            ' トランザクション破棄
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
            Case 0  ' 画面体裁設定
                '------------------------------
                ' 画面体裁設定 表示処理
                '------------------------------
                Call LS_SetInitForm()

                L_blnEdit = False

            Case 1 ' 売上データ出力
                txt_PutPathCsv.Text = Trim$(GF_GetAppInfo("SALES_PATH")) & "\PriceData(" & Format$(Now, "yyyyMMddHHmmss") & ").csv"
                txt_PutPathCsv.Enabled = False

            Case 2 ' データバックアップ
                txt_PutPath.Text = Trim$(GF_GetAppInfo("BACKUP_PATH"))
                txt_PutPath.Enabled = False

            Case 3 ' 送信メッセージ編集
                '------------------------------
                ' 画面初期化
                '------------------------------
                Call LS_FormSetup()

                L_blnEdit = False

            Case Else

                ' 2017.01.01 がってん寿司向け クレスコ北陸 田代
                If GF_GetAppInfo2("CNWH_GAMEFLG") = 1 Then
                    Call LF_GameSetInitForm()
                End If

                If GF_GetAppInfo3("KCP_PTN_FLG") = 1 Then
                    Call LF_PaternInitForm()
                End If
                ' 2017.01.01 がってん寿司向け クレスコ北陸 田代

                ' 2017.10.01 本部配信 クレスコ北陸 田代
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
                    ' 2017.10.01 本部配信 クレスコ北陸 田代

                    Exit Sub
        End Select

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("TabControl1_SelectedIndexChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画面体裁設定 表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetInitForm()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        'Label8.Visible = False
        txt_StoreInfo.Visible = False

        '------------------------------
        ' システム管理マスタ取得
        '------------------------------
        If Not LF_GetTPM040(objData) Then
            GoTo SYSTEM_ERROR
        End If

        If Not GF_GetRows(objData, 0, objRows) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' 現行設定値 表示処理
        '------------------------------
        Try
            '------------------------------
            ' 店舗情報(お知らせ)設定
            '------------------------------
            txt_StoreInfo.Text = Replace(Trim$(objRows("STOREINFO")), "<BR>", vbCrLf)
            If GF_LenB(GF_RepQuo(objRows("STOREINFO"))) > 100 Then
                txt_StoreInfo.BackColor = Color.Pink
            Else
                txt_StoreInfo.BackColor = Color.White
            End If

            '------------------------------
            ' 店舗ロゴ表示設定
            '------------------------------
            If Trim$(objRows("LOGO_VIEW")) = GC_TRUE Then
                Call LS_SetRadio(rdo_Logo_Show, True)
            Else
                Call LS_SetRadio(rdo_Logo_Hide, True)
            End If

            '------------------------------
            ' 画面表示設定
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
            ' 広告表示設定
            '------------------------------
            txt_Wait_Time.Text = Trim$(objRows("CHGTIME"))
            txt_Chg_Time.Text = Trim$(objRows("CHGINT"))

            '------------------------------
            ' 厨房警告時間表示設定
            '------------------------------

            '警告時間黄
            Text_alert.Text = CInt(LF_GetTPM090("1"))

            '警告時間オレンジ
            Text_alert2.Text = CInt(LF_GetTPM090("2"))

            '警告時間赤
            Text_alert3.Text = CInt(LF_GetTPM090("3"))

            '------------------------------
            ' 品切れ文字表示設定
            '------------------------------

            '品切れパターン１
            text_sold_out1.Text = Trim$(LF_TPM090("1"))

            '品切れパターン２
            text_sold_out2.Text = Trim$(LF_TPM090("2"))

            '品切れパターン３
            text_sold_out3.Text = Trim$(LF_TPM090("3"))

            '品切れパターン４
            text_sold_out4.Text = Trim$(LF_TPM090("4"))

            '----------------------------------------------
            ' トップ画面表示パターン　2013.10.07　追加
            '----------------------------------------------
            Call LS_TopCmbSetup()
            If Trim$(GF_GetAppInfo2("TOP_VARIABLE_FLG")) = 0 Then
                Call GS_CboChgSel(Cbo_TopChg, Trim$(GF_GetAppInfo2("TOP_DISPCD")))
            Else
                Label14.Visible = False
                GroupBox7.Visible = False
            End If

            '------------------------------
            ' 消費税率表示設定
            '------------------------------
            sales_tax_rate.Text = Trim$(GF_GetAppInfo("SALES_TAX_RATE"))

            '------------------------------
            ' 小数第一位端数処理値表示設定
            '------------------------------
            tax_round_1.Text = Trim$(GF_GetAppInfo("TAX_ROUND_OFF"))
            tax_round_2.Text = Trim$(GF_GetAppInfo("TAX_ROUND_OFF")) + 1

            '------------------------------
            ' [送信メッセージ編集]表示可否
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

    ' START 2016.05.10 田代
    ' --------------------------------------------------------------------------------
    ' 　機　　能：ゲーム設定 表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2016.05.10 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LF_GameSetInitForm()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' システム管理マスタ取得
        '------------------------------
        If Not LF_GetTPM040(objData) Then
            GoTo SYSTEM_ERROR
        End If

        If Not GF_GetRows(objData, 0, objRows) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' 現行設定値 表示処理
        '------------------------------
        Try
            txt_GAMEHITNUM.Text = Trim$(GF_GetAppInfo2("CNWH_GAMEHITNUM"))
            txt_GAMEPLAYNUM.Text = Trim$(GF_GetAppInfo2("CNWH_GAMEPLAYNUM"))

            '-----------------------------------
            ' ゲーム設定値編集可否 表示処理
            '-----------------------------------
            If Trim$(objRows("CLMODE")) = 0 Then
                txt_GAMEHITNUM.Enabled = False
                txt_GAMEPLAYNUM.Enabled = False

                lbl_judge.Text = "システム稼働中です。"
                lbl_order.Text = "現在、ゲーム設定の値を変更することはできません。"

            ElseIf Trim$(objRows("CLMODE")) = 1 Then
                txt_GAMEHITNUM.Enabled = True
                txt_GAMEPLAYNUM.Enabled = True

                lbl_judge.Text = "システム停止中です。"
                lbl_order.Text = "現在、ゲーム設定の値を変更することができます。"
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
    ' END 2016.05.10 田代

    ' 2017.01.01 がってん寿司向け クレスコ北陸 田代
    ' --------------------------------------------------------------------------------
    ' 　機　　能：出力先パターン表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2016.01.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LF_PaternInitForm()

        '------------------------------
        ' 内部変数定義
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

                cmb1.HeaderText = "パターン1"

                cmb2.HeaderText = "パターン2"

                cmb3.HeaderText = "パターン3"

                cmb4.HeaderText = "パターン4"

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
                        cmbPtn.Text = "パターン１"
                    Case "2"
                        cmbPtn.Text = "パターン２"
                    Case "3"
                        cmbPtn.Text = "パターン３"
                    Case "4"
                        cmbPtn.Text = "パターン４"

                End Select


                cmbPtn.Items.Add("パターン１")

                cmbPtn.Items.Add("パターン２")

                cmbPtn.Items.Add("パターン３")

                cmbPtn.Items.Add("パターン４")

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
    ' 2017.01.01 がってん寿司向け クレスコ北陸 田代


    ' --------------------------------------------------------------------------------
    ' 　機　　能：システム管理マスタ 取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM040(ByRef pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM040 = False

        '------------------------------
        ' SQL組立
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
        ' 返却値設定
        '------------------------------
        LF_GetTPM040 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：AP情報管理マスタ 取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.08.06 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM090(ByVal pFlg As String) As String
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM090 = ""

        '------------------------------
        ' SQL組立
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
        ' 返却値設定
        '------------------------------

        LF_GetTPM090 = objRows("APVALUE")

        Return LF_GetTPM090

    End Function

    '品切れ4パターン対応　2013.10.28
    Private Function LF_TPM090(ByVal sFlg As String) As String
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing


        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_TPM090 = ""

        '------------------------------
        ' SQL組立
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
        ' 返却値設定
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
        ' 更新処理
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
        ' 更新処理
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
        ' 更新処理
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
        ' 更新処理
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
        ' 更新処理
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
            ' 更新処理
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
            ' 更新処理
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
            ' 更新処理
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
            ' 更新処理
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
            ' 更新処理
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
            ' 更新処理
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

            MessageBox.Show("品切れ文字を入力して下さい")
            If text_sold_out1.CanUndo = True Then
                text_sold_out1.Undo()

            End If
        End If

    End Sub

    Private Sub text_sold_out1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out1.Leave
        If Not text_sold_out1.Text = "" Then
            '------------------------------
            ' 更新処理
            '------------------------------
            If Not LF_UpdTPM090(typUpdata.SOLDOUT_NM) Then
                Exit Sub
            End If
        End If

    End Sub

    Private Sub text_sold_out1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out1.TextChanged

        Dim lngST As Long



        lngST = text_sold_out1.SelectionStart
        ' 2014-05-12 2バイト文字制限解除
        'text_sold_out1.Text = StrConv(text_sold_out1.Text, VbStrConv.Wide)
        If lngST >= 0 Then
            text_sold_out1.SelectionStart = lngST
        End If

        '------------------------------
        ' 入力長制限
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

            MessageBox.Show("品切れ文字を入力して下さい")
            If text_sold_out2.CanUndo = True Then
                text_sold_out2.Undo()

            End If
        End If
    End Sub

    Private Sub text_sold_out2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out2.Leave
        If Not text_sold_out2.Text = "" Then
            '------------------------------
            ' 更新処理
            '------------------------------
            If Not LF_UpdTPM090(typUpdata.SOLDOUT_NM_2) Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub text_sold_out2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out2.TextChanged

        Dim lngST As Long



        lngST = text_sold_out2.SelectionStart
        ' 2014-05-12 2バイト文字制限解除
        'text_sold_out2.Text = StrConv(text_sold_out2.Text, VbStrConv.Wide)
        If lngST >= 0 Then
            text_sold_out2.SelectionStart = lngST
        End If

        '------------------------------
        ' 入力長制限
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

            MessageBox.Show("品切れ文字を入力して下さい")
            If text_sold_out3.CanUndo = True Then
                text_sold_out3.Undo()

            End If
        End If
    End Sub

    Private Sub text_sold_out3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out3.Leave
        If Not text_sold_out3.Text = "" Then
            '------------------------------
            ' 更新処理
            '------------------------------
            If Not LF_UpdTPM090(typUpdata.SOLDOUT_NM_3) Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub text_sold_out3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out3.TextChanged

        Dim lngST As Long



        lngST = text_sold_out3.SelectionStart
        ' 2014-05-12 2バイト文字制限解除
        'text_sold_out3.Text = StrConv(text_sold_out3.Text, VbStrConv.Wide)
        If lngST >= 0 Then
            text_sold_out3.SelectionStart = lngST
        End If
        '------------------------------
        ' 入力長制限
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

            MessageBox.Show("品切れ文字を入力して下さい")
            If text_sold_out4.CanUndo = True Then
                text_sold_out4.Undo()

            End If
        End If
    End Sub

    Private Sub text_sold_out4_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out4.Leave
        If Not text_sold_out4.Text = "" Then
            '------------------------------
            ' 更新処理
            '------------------------------
            If Not LF_UpdTPM090(typUpdata.SOLDOUT_NM_4) Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub text_sold_out4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_sold_out4.TextChanged

        Dim lngST As Long



        lngST = text_sold_out4.SelectionStart
        ' 2014-05-12 2バイト文字制限解除
        'text_sold_out4.Text = StrConv(text_sold_out4.Text, VbStrConv.Wide)
        If lngST >= 0 Then
            text_sold_out4.SelectionStart = lngST
        End If

        '------------------------------
        ' 入力長制限
        '------------------------------
        If GF_LenB(text_sold_out4.Text) > 16 Then
            text_sold_out4.Text = GF_MidB(text_sold_out4.Text, 1, 16)
            text_sold_out4.SelectionStart = GF_LenB(text_sold_out4.Text)
        End If
    End Sub

    '消費税率変更　2013.12.18
    Private Sub sales_tax_rate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sales_tax_rate.TextChanged

        If sales_tax_rate.Modified = False Then
            Exit Sub
        End If
        If Len(Trim$(sales_tax_rate.Text)) = 0 Then
            sales_tax_rate.Text = ""

        End If

        L_blnEdit = True

    End Sub

    '消費税率変更　2013.12.18
    Private Sub sales_tax_rate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sales_tax_rate.Leave
        If Not sales_tax_rate.Text = "" Then
            '------------------------------
            ' 更新処理
            '------------------------------
            If Not LF_UpdTPM090(typUpdata.TAX_RATE) Then
                Exit Sub
            End If
        Else
            MessageBox.Show("消費税率を入力して下さい")
            If sales_tax_rate.CanUndo = True Then
                sales_tax_rate.Undo()
            End If
        End If
    End Sub

    '端数処理値変更　2013.1.9
    Private Sub tax_round_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tax_round_1.TextChanged

        If tax_round_1.Modified = False Then
            Exit Sub
        End If
        If Len(Trim$(tax_round_1.Text)) = 0 Then
            tax_round_1.Text = ""

        End If

        L_blnEdit = True

    End Sub

    '端数処理値変更　2013.1.9
    Private Sub tax_round_1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tax_round_1.Leave
        If Not tax_round_1.Text = "" Then
            '------------------------------
            ' 更新処理
            '------------------------------
            If Not LF_UpdTPM090(typUpdata.ROUND_OFF) Then
                Exit Sub
            End If

            tax_round_2.Text = Trim$(GF_GetAppInfo("TAX_ROUND_OFF")) + 1
        Else
            MessageBox.Show("端数処理する基準の値を入力して下さい")
            If tax_round_1.CanUndo = True Then
                tax_round_1.Undo()
            End If
        End If
    End Sub

    ' START 2016.05.10 田代
    Private Sub txt_GAMEHITNUM_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GAMEHITNUM.LostFocus
        If txt_GAMEHITNUM.Modified = False Then
            Exit Sub
        End If

        If Trim$(txt_GAMEHITNUM.Text) = "" Then

            MessageBox.Show("ゲームの当たり判定回数の値を入力して下さい")
            If txt_GAMEHITNUM.CanUndo = True Then
                txt_GAMEHITNUM.Undo()
            End If
        End If
    End Sub
    Private Sub txt_GAMEHITNUM_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GAMEHITNUM.Leave
        If Not txt_GAMEHITNUM.Text = "" Then
            '-------------------------------
            ' 更新処理
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

            MessageBox.Show("再生ゲーム数の値を入力して下さい")
            If txt_GAMEPLAYNUM.CanUndo = True Then
                txt_GAMEPLAYNUM.Undo()
            End If
        End If
    End Sub
    Private Sub txt_GAMEPLAYNUM_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GAMEPLAYNUM.Leave
        If Not txt_GAMEPLAYNUM.Text = "" Then
            '-------------------------------
            ' 更新処理
            '-------------------------------
            If Not LF_UpdTPM091(typUpdata_game.GAMEPLAYNUM) Then
                Exit Sub
            End If
        End If
    End Sub
    ' END 2016.05.10 田代

    ' --------------------------------------------------------------------------------
    ' 　機　　能：システム管理マスタ 更新処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM040(ByVal updKbn As CNL1501.CNL2130.typUpdKbn) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM040 = False

        '------------------------------
        ' システム管理マスタ 更新
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
        ' 返却値設定
        '------------------------------
        LF_UpdTPM040 = True

    End Function

    '品切れ4パターン対応　2013.10.28
    Private Function LF_UpdTPM090(ByVal updap As CNL1501.CNL2130.typUpdata) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM090 = False

        '------------------------------
        ' システム管理マスタ 更新
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

                '消費税率変更　2013.12.18
            Case typUpdata.TAX_RATE
                strSQL = strSQL & "   SET APVALUE = '" & Trim$(sales_tax_rate.Text) & "'"
                strSQL = strSQL & "   WHERE APKEY = 'SALES_TAX_RATE'"

                '端数処理値　2013.1.9
            Case typUpdata.ROUND_OFF
                strSQL = strSQL & "   SET APVALUE = '" & Trim$(tax_round_1.Text) & "'"
                strSQL = strSQL & "   WHERE APKEY = 'TAX_ROUND_OFF'"

        End Select


        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM090 = True

    End Function

    ' START 2016.05.10 田代
    ' ゲーム当たり判定回数、ゲーム再生回数更新処理
    Private Function LF_UpdTPM091(ByVal updap As CNL1501.CNL2130.typUpdata_game) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM091 = False

        '------------------------------
        ' システム管理マスタ 更新
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
        ' 返却値設定
        '------------------------------
        LF_UpdTPM091 = True

    End Function
    ' END 2015.05.10 田代


    ' --------------------------------------------------------------------------------
    ' 　機　　能：マスタ値設定項目 入力制限処理
    ' 　機能概要：広告表示までの待ち時間
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_Wait_Time_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Wait_Time.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：マスタ値設定項目 入力制限処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_Chg_Time_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Chg_Time.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：マスタ値設定項目 入力制限処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.08.06    クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub Text_alert_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_alert.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：マスタ値設定項目 入力制限処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.08.06    クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub Text_alert2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_alert2.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：マスタ値設定項目 入力制限処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.08.06    クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub Text_alert3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_alert3.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：マスタ値設定項目 入力制限処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.12 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub sales_tax_rate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sales_tax_rate.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：マスタ値設定項目 入力制限処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2014.1.9  新規作成
    ' --------------------------------------------------------------------------------
    Private Sub tax_round_1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tax_round_1.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    '    ' --------------------------------------------------------------------------------
    '    ' 　機　　能：メニュー - [保存]押下時処理
    '    ' 　機能概要：
    '    ' 　引　　数：
    '    ' 　戻 り 値：
    '    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    '    ' --------------------------------------------------------------------------------
    '    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click

    '        Select Case TabControl1.SelectedIndex
    '            Case 0
    '                '------------------------------
    '                ' 更新処理確認
    '                '------------------------------
    '                If L_blnEdit Then
    '                    '------------------------------
    '                    ' トランザクション開始
    '                    '------------------------------
    '                    If Not GF_BeginTrans() Then
    '                        GoTo SYSTEM_ERROR
    '                    End If

    '                    '------------------------------
    '                    ' 更新処理
    '                    '------------------------------
    '                    If Not LF_UpdTPM040() Then
    '                        GoTo SYSTEM_ERROR
    '                    End If

    '                    '------------------------------
    '                    ' トランザクション確定
    '                    '------------------------------
    '                    If Not GF_CommitTrans() Then
    '                        GoTo SYSTEM_ERROR
    '                    End If

    '                    L_blnEdit = False
    '                End If

    '            Case 1
    '                '------------------------------
    '                ' 更新処理確認
    '                '------------------------------
    '                If L_blnEdit Then
    '                    '------------------------------
    '                    ' トランザクション確定
    '                    '------------------------------
    '                    If Not GF_CommitTrans() Then
    '                        GoTo SYSTEM_ERROR
    '                    End If

    '                    '------------------------------
    '                    ' トランザクション開始
    '                    '------------------------------
    '                    If Not GF_BeginTrans() Then
    '                        GoTo SYSTEM_ERROR
    '                    End If

    '                    L_blnEdit = False
    '                Else
    '                    '------------------------------
    '                    ' トランザクション破棄
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
    '        '' トランザクション破棄
    '        ''------------------------------
    '        'Call GF_RollbackTrans()
    '        Call GS_ErrorTerm("MenuItem3_Click")
    '    End Sub

    '    Private Sub CNL2130_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

    '        '------------------------------
    '        ' 内部変数定義
    '        '------------------------------
    '        Dim objRet As MsgBoxResult

    '        Select Case TabControl1.SelectedIndex
    '            Case 0
    '                '------------------------------
    '                ' 更新処理確認
    '                '------------------------------
    '                If L_blnEdit Then
    '                    objRet = GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNoCancel)

    '                    Select Case objRet
    '                        Case MsgBoxResult.Yes
    '                            '------------------------------
    '                            ' トランザクション開始
    '                            '------------------------------
    '                            If Not GF_BeginTrans() Then
    '                                GoTo SYSTEM_ERROR
    '                            End If

    '                            '------------------------------
    '                            ' 更新処理
    '                            '------------------------------
    '                            If Not LF_UpdTPM040() Then
    '                                GoTo SYSTEM_ERROR
    '                            End If

    '                            '------------------------------
    '                            ' トランザクション確定
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
    '                ' 更新処理確認
    '                '------------------------------
    '                If L_blnEdit Then
    '                    objRet = GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNoCancel)

    '                    Select Case objRet
    '                        Case MsgBoxResult.Yes
    '                            '------------------------------
    '                            ' トランザクション確定
    '                            '------------------------------
    '                            If Not GF_CommitTrans() Then
    '                                GoTo SYSTEM_ERROR
    '                            End If

    '                        Case MsgBoxResult.No
    '                            '------------------------------
    '                            ' トランザクション破棄
    '                            '------------------------------
    '                            If Not GF_RollbackTrans() Then
    '                                GoTo SYSTEM_ERROR
    '                            End If

    '                        Case MsgBoxResult.Cancel
    '                            e.Cancel = True
    '                    End Select
    '                Else
    '                    '------------------------------
    '                    ' トランザクション破棄
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
    '        ' トランザクション破棄
    '        '------------------------------
    '        Call GF_RollbackTrans()
    '        Call GS_ErrorTerm("CNL2130_Closing")
    '    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_FormSetup()

        '------------------------------
        ' 初期値設定
        '------------------------------
        txt_Msg1.Clear()
        btn_Add.Enabled = True
        btn_Del.Enabled = True

        '------------------------------
        ' 画面初期値設定
        '------------------------------
        With lsv_MsgList
            .Clear()
            .FullRowSelect = True
            .Columns.Add("メッセージ", 275, HorizontalAlignment.Left)
            .MultiSelect = False
            .HideSelection = False
        End With

        '------------------------------
        ' メッセージリスト作成
        '------------------------------
        Call LS_FreeMsgList()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_FormSetup")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メッセージリスト作成処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_FreeMsgList()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim objItem As ListViewItem

        '------------------------------
        ' メッセージ一覧取得
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
        ' リストボックス設定
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
    ' 　機　　能：ＮＵＬＬ値判定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
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
    ' 　機　　能：メッセージリスト　選択メッセージ変更処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_MsgList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_MsgList.SelectedIndexChanged

        '------------------------------
        ' 内部変数定義
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
    ' 　機　　能：送信メッセージ文言変更処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_Msg1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Msg1.TextChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngST As Long
        Dim objCollection As ListView.SelectedListViewItemCollection

        '------------------------------
        ' イベント処理続行判定
        '------------------------------
        If txt_Msg1.Modified = False Then
            Exit Sub
        End If

        '------------------------------
        ' 半角入力禁止
        '------------------------------
        lngST = txt_Msg1.SelectionStart
        ' 2014-05-12 2バイト文字制限解除
        'txt_Msg1.Text = StrConv(txt_Msg1.Text, VbStrConv.Wide)
        If lngST >= 0 Then
            txt_Msg1.SelectionStart = lngST
        End If

        '------------------------------
        ' 入力長制約
        '------------------------------
        If GF_LenB(txt_Msg1.Text) > 40 Then
            txt_Msg1.Text = GF_MidB(txt_Msg1.Text, 1, 40)
            txt_Msg1.SelectionStart = GF_LenB(txt_Msg1.Text)
            Exit Sub
        End If

        '------------------------------
        ' 更新処理
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
    ' 　機　　能：ＴＰＭ０３０更新処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM030(ByVal pMsgCD As String, ByVal pMsgVal As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strMsg As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM030 = False

        If Len(Trim$(pMsgVal)) = 0 Then
            strMsg = Space(40)
        Else
            strMsg = pMsgVal
        End If

        '------------------------------
        ' メッセージマスタ更新
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
        ' 返却値設定
        '------------------------------
        LF_UpdTPM030 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：「新規追加」ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click

        '------------------------------
        ' ＴＰＭ０３０追加処理
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
    ' 　機　　能：「削除」ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Del.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection

        '------------------------------
        ' イベント処理続行判定
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
        ' ＴＰＭ０３０削除処理
        '------------------------------
        If Not LF_DelTPM030() Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' メッセージ一覧生成
        '------------------------------
        Call LS_FreeMsgList()

        txt_Msg1.Clear()

        L_blnEdit = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Del_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＴＰＭ０３０追加処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_InsTPM030() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngI As Long
        Dim strNewID As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_InsTPM030 = False

        '------------------------------
        ' 採番処理
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
                ' 空き番検索処理
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
                    Call GF_Msg("", "これ以上、メッセージを追加することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                    LF_InsTPM030 = True
                    Exit Function
                End If
            Else
                strNewID = "I" & Format$(CLng(Mid(Trim$(objRows("CODEVAL")), 2)) + 1, "00")
            End If
        End If

        '------------------------------
        ' 新規メッセージレコード追加
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM030 VALUES("
        strSQL = strSQL & "       'SENDMSG2',"
        strSQL = strSQL & "       '" & strNewID & "',"
        strSQL = strSQL & "       '新規追加メッセージ',"
        strSQL = strSQL & "       'SYSTEM',"
        strSQL = strSQL & "       getdate())"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_InsTPM030 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＴＰＭ０３０削除処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_DelTPM030() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_DelTPM030 = False

        '------------------------------
        ' イベント処理続行判定
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
        ' メッセージマスタ削除
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
        ' イラスト関連付けマスタ削除
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
        ' 返却値設定
        '------------------------------
        LF_DelTPM030 = True

    End Function

    Private Sub btn_Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Browse.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objFolder As New BrowseFolder()
        Dim strSelPath As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        Try
            strSelPath = objFolder.BrowseDialog("フォルダを指定してください", Me)
            txt_PutPath.Text = strSelPath
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Browse_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：「売上データ出力」ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_OutputCsv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OutputCsv.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim RowsCnt As Integer
        Dim ColmCnt As Integer
        Dim strEncoding As System.Text.Encoding
        Dim strStreamWriter As System.IO.StreamWriter = Nothing


        If System.IO.File.Exists(txt_PutPathCsv.Text) = True Then
            '------------------------------
            ' ダイアログボックス表示
            '------------------------------
            If Not GetSaveFile() Then
                Call GF_Msg("", "既に同一名称のファイルが登録されています" & vbCrLf & "ファイル名を変更してください", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                Exit Sub
            End If
        End If

        '------------------------------
        ' 帳票データ取得処理
        '------------------------------
        If Not LF_GetDATA(objData) Then
            Exit Sub
        End If

        Try
            '------------------------------
            ' ファイル名設定
            '------------------------------
            strEncoding = System.Text.Encoding.GetEncoding("Shift_JIS")
            strStreamWriter = New System.IO.StreamWriter(txt_PutPathCsv.Text, False, strEncoding)

            '------------------------------
            ' ファイル出力
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
            MsgBox("ファイルの出力に失敗しました")

            Exit Sub
        End Try

        strStreamWriter.Close()
        Call GF_Msg("", "売上データを作成しました" & vbCrLf & "[" & txt_PutPathCsv.Text & "]", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_OutputCsv_Click")
    End Sub

    '' --------------------------------------------------------------------------------
    '' 　機　　能：帳票テーブル更新処理(ＤＥＬＥＴＥ)
    '' 　機能概要：
    '' 　引　　数：
    '' 　戻 り 値：
    '' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    '' --------------------------------------------------------------------------------
    'Private Function LF_Delete() As Boolean

    '    '------------------------------
    '    ' 内部変数定義
    '    '------------------------------
    '    Dim strSQL As String

    '    '------------------------------
    '    ' 初期値設定
    '    '------------------------------
    '    LF_Delete = False

    '    '------------------------------
    '    ' SQL組立
    '    '------------------------------
    '    strSQL = ""
    '    strSQL = strSQL & "DELETE"
    '    strSQL = strSQL & "  FROM TPD100"

    '    If Not GF_UpdCmtData(strSQL) Then
    '        Exit Function
    '    End If

    '    '------------------------------
    '    ' 返却値設定
    '    '------------------------------
    '    LF_Delete = True

    'End Function

    '' --------------------------------------------------------------------------------
    '' 　機　　能：帳票テーブル作成処理
    '' 　機能概要：
    '' 　引　　数：
    '' 　戻 り 値：
    '' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    '' --------------------------------------------------------------------------------
    'Private Function LF_CreateWorkTable() As FuncResult

    '    '------------------------------
    '    ' 内部変数定義
    '    '------------------------------
    '    Dim objData As New DataSet()
    '    Dim objRows As DataRow = Nothing
    '    Dim lngCnt As Long
    '    Dim strNow As String
    '    Dim lngSum As Long
    '    Dim objSum As strOrderData

    '    '------------------------------
    '    ' 初期値設定
    '    '------------------------------
    '    LF_CreateWorkTable = CNL1920.FuncResult.UnusualEnd
    '    strNow = Format(Now(), "yyyyMMdd")

    '    With objSum
    '        .OUTSHOHIN = ""
    '        .SHOHIN = "9999"
    '        .SHOHINNM = "合計"
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
    '    ' データ取得
    '    '------------------------------
    '    If Not LF_GetData(objData) Then
    '        Exit Function
    '    End If

    '    If objData.Tables("com").Rows.Count = 0 Then
    '        Call GF_Msg("", "対象データがありません", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
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
    '            ' エリアの初期化
    '            '------------------------------
    '            Call LS_ClearData()
    '            L_OrderDatakey.SHOHIN = CStr(objRows("SHOHIN"))             ' キー退避

    '            L_OrderData.SHOHINKIND = "商品番号"
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
    '                        '何もしない
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
    '            ' 帳票テーブル更新(明細データ追加)
    '            '------------------------------
    '            If Not LF_UpdData(L_OrderData) Then
    '                Exit Function
    '            End If
    '        End While

    '        objSum.SHOHINKIND = L_OrderData.SHOHINKIND
    '        '------------------------------
    '        ' 帳票テーブル更新(合計データ追加)
    '        '------------------------------
    '        If Not LF_UpdData(objSum) Then
    '            Exit Function
    '        End If

    '    Catch
    '        Exit Function
    '    End Try

    '    '------------------------------
    '    ' 返却値設定
    '    '------------------------------
    '    LF_CreateWorkTable = CNL1920.FuncResult.NormalEnd

    'End Function

    Private Function GetSaveFile() As Boolean

        '------------------------------
        ' 初期値設定
        '------------------------------
        GetSaveFile = False

        '------------------------------
        ' SaveFileDialogクラスのインスタンスを作成
        '------------------------------
        Dim sfd As New SaveFileDialog()

        '------------------------------
        ' はじめのファイル名を指定する
        '------------------------------
        sfd.FileName = "PriceData(" & Format$(Now, "yyyyMMddHHmmss") & ").csv"

        '------------------------------
        ' はじめに表示されるフォルダを指定する
        '------------------------------
        sfd.InitialDirectory = Trim$(GF_GetAppInfo("SALES_PATH"))

        '------------------------------
        ' [ファイルの種類]に表示される選択肢を指定する
        '------------------------------
        sfd.Filter = "csvファイル|*.csv|すべてのファイル(*.*)|*.*"

        '------------------------------
        ' [ファイルの種類]ではじめに
        ' 「すべてのファイル」が選択されているようにする
        '------------------------------
        sfd.FilterIndex = 2

        '------------------------------
        ' タイトルを設定する
        '------------------------------
        sfd.Title = "保存先のファイルを選択してください"

        '------------------------------
        ' ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
        '------------------------------
        sfd.RestoreDirectory = True

        '------------------------------
        ' 既に存在するファイル名を指定したとき警告する
        ' デフォルトでTrueなので指定する必要はない
        '------------------------------
        sfd.OverwritePrompt = True

        '------------------------------
        ' 存在しないパスが指定されたとき警告を表示する
        ' デフォルトでTrueなので指定する必要はない
        '------------------------------
        sfd.CheckPathExists = True

        '------------------------------
        ' ダイアログを表示する
        '------------------------------
        If sfd.ShowDialog() = DialogResult.OK Then
            txt_PutPathCsv.Text = sfd.FileName
        Else
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        GetSaveFile = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：帳票データ取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetDATA(ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetDATA = False

        '------------------------------
        ' SQL組立
        '------------------------------
        strSQL = ""
        strSQL = strSQL & " SELECT TPM010.GOODSCD AS '商品番号',"
        strSQL = strSQL & "        MAX(LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ, '　', ' '))) + LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ2, '　', ' ')))) AS '商品名称',"
        strSQL = strSQL & "        ISNULL(SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END),0) AS '売上数量',"
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
        strSQL = strSQL & "        ISNULL((SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END) * MAX(TPM010.PRICE)),0) AS '売上金額'"
        strSQL = strSQL & "   FROM TPM010 LEFT JOIN TPD010 ON TPM010.GOODSCD = TPD010.GOODSCD"
        strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999"
        strSQL = strSQL & " GROUP BY TPM010.GOODSCD"

        '飲み放題商品別集計
        strSQL = strSQL & " UNION"
        strSQL = strSQL & " SELECT TPM010.GOODSCD AS '商品番号',"
        strSQL = strSQL & "        MAX(LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ, '　', ' '))) + LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ2, '　', ' ')))) + '" & GF_GetAppInfo2("FREEGOODS_MARK") & "' AS '商品名称',"
        strSQL = strSQL & "        ISNULL(SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END),0) AS '売上数量',"
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
        strSQL = strSQL & "        ISNULL((SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END) * MAX(TPM010.PRICE)),0) AS '売上金額'"
        strSQL = strSQL & "   FROM TPM010 LEFT JOIN TPD010 ON TPM010.GOODSCD = TPD010.GOODSCD"
        strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999"
        strSQL = strSQL & "   AND   TPD010.ORDERFLG = '50'"
        strSQL = strSQL & " GROUP BY TPM010.GOODSCD"
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

        '------------------------------
        ' データ取得
        '------------------------------
        If Not GF_GetData(strSQL, pDataSet) Then
            Call GF_Msg("", "DB接続に失敗しました", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            Exit Function
        End If

        If pDataSet.Tables("com").Rows.Count = 0 Then
            Call GF_Msg("", "対象データがありません", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            Exit Function
        End If


        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetDATA = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：スペース埋め処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function LF_PadSpc(ByVal pStr As String, ByVal Length As Long) As String

        LF_PadSpc = Space(Length - Len(Trim$(pStr))) & Trim$(pStr)

    End Function

    Private Sub btn_BrowseCsv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BrowseCsv.Click

        '------------------------------       
        ' 内部変数定義
        '------------------------------
        Dim FileName As String = Nothing

        '------------------------------
        ' ダイアログボックス表示
        '------------------------------
        If Not GetSaveFile() Then
            Exit Sub
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：トップ画面表示パターン切替表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.10.07 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_TopCmbSetup()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow
        Dim lngCnt As Long

        '------------------------------
        ' 初期値設定
        '------------------------------

        Cbo_TopChg.DropDownStyle = ComboBoxStyle.DropDownList

        '------------------------------
        ' トップメニューリスト取得
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
        ' トップメニュー選択コンボ設定
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
    ' 　機　　能：トップ画面表示パターン切替更新処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.10.07 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub Cbo_TopChg_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_TopChg.SelectionChangeCommitted


        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' システム管理マスタ 更新
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM091"
        strSQL = strSQL & "   SET APVALUE = '" & Trim$(GF_CboGetCode(Cbo_TopChg, Cbo_TopChg.SelectedIndex)) & "'"
        strSQL = strSQL & " WHERE APKEY = 'TOP_DISPCD'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Sub
        End If

        GF_Msg("", "トップ画面を切り替えました", MsgBoxStyle.OkOnly)


    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：CrossNavi【レシート再印字機能】
    ' 　機能概要：レシート再印字ボタン押下でレシート再印字を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2014.1 機能移植
    ' --------------------------------------------------------------------------------
    Private Sub btn_Reprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reprint.Click
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strSeatId As String
        Dim strOrderNo As Integer
        Dim objCollection As ListView.SelectedListViewItemCollection

        '------------------------------
        ' 初期値設定
        '------------------------------
        objCollection = lsv_OrderList.SelectedItems
        With objCollection
            If .Count = 0 Then
                MsgBox("席番号を選んでください。")
                Exit Sub
            End If

            '------------------------------
            ' ガイダンス名編集領域へ転記
            '------------------------------
            strSeatId = .Item(0).SubItems.Item(1).Text
            strOrderNo = .Item(0).SubItems.Item(2).Text
        End With

        '------------------------------
        ' メッセージマスタ更新
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
            MsgBox("更新に失敗しました。再度更新を行ってください。")
            Exit Sub
        End If
        MsgBox("レシート再印字しました。")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：CrossNavi【レシート再印字機能】
    ' 　機能概要：タブ初回表示時
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2014.1 機能移植
    ' --------------------------------------------------------------------------------
    Private Sub TabPage5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage5.Enter

        'コンボボックスの初期化
        Call LS_CmbSetup()
        cbo_SeatChg.SelectedIndex = 0

        '注文一覧リストの作成
        Call LS_SetOrderList(LC_ALL_SELECT)
        lsv_OrderList.HideSelection = False

        '注文明細リストの作成
        Call LS_SetOrderDetails(LC_NO_SEATID, LC_NO_ORDERNO)

        If GF_GetAppInfo3("RECEIPT_REPRINTING") = 1 Then
            btn_Reprint.Visible = False
        End If


    End Sub
    ' --------------------------------------------------------------------------------
    ' 　機　　能：CrossNavi【レシート再印字機能】
    ' 　機能概要：座席絞込み検索時
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2014.1 機能移植
    ' --------------------------------------------------------------------------------
    Private Sub CmbChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_SeatChg.SelectionChangeCommitted
        Call LS_SetOrderList(Trim$(GF_CboGetCode(cbo_SeatChg, cbo_SeatChg.SelectedIndex)))

        '注文明細リストの作成
        Call LS_SetOrderDetails(LC_NO_SEATID, LC_NO_ORDERNO)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：CrossNavi【レシート再印字機能】
    ' 　機能概要：座席選択コンボボックスの表示処理
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2014.1 機能移植
    ' --------------------------------------------------------------------------------
    Private Sub LS_CmbSetup()
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow
        Dim lngCnt As Long

        '------------------------------
        ' 初期値設定
        '------------------------------
        cbo_SeatChg.DropDownStyle = ComboBoxStyle.DropDownList

        '--------------------------------------------------------
        ' 座席リスト取得 TCBはテイクアウト端末の為、対象から外す
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
        ' メニュー選択コンボ設定
        '------------------------------
        Try
            With cbo_SeatChg
                .Items.Clear()
                .Items.Add("全席" & Space(100) & vbTab & LC_ALL_SELECT)

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
    ' 　機　　能：CrossNavi【レシート再印字機能】
    ' 　機能概要：「注文明細」リスト表示
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2014.1 機能移植
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetOrderDetails(ByVal pSEATID As String, ByVal pORDERNO As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow
        Dim lngCnt As Long
        Dim objItem As ListViewItem
        Dim strTime As String

        '------------------------------
        ' 初期設定
        '------------------------------
        lsv_OrderDetails.Clear()
        With lsv_OrderDetails
            .BeginUpdate()
            .Items.Clear()
            .Columns.Clear()

            .View = View.Details
            .FullRowSelect = True

            .Columns.Add("", 0, HorizontalAlignment.Center)
            .Columns.Add("商品名", 145, HorizontalAlignment.Center)
            .Columns.Add("数量", 44, HorizontalAlignment.Center)
            .Columns.Add("注文時間", 85, HorizontalAlignment.Center)
            .Columns.Add("金額", 80, HorizontalAlignment.Center)
        End With

        '------------------------------
        ' 注文明細一覧取得
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
    ' 　機　　能：CrossNavi【レシート再印字機能】
    ' 　機能概要：「注文一覧」リスト表示
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2014.1 機能移植
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetOrderList(ByVal pSEATID As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow
        Dim lngCnt As Long
        Dim objItem As ListViewItem
        Dim strPrice As String
        Dim strTime As String

        '------------------------------
        ' 初期設定
        '------------------------------
        lsv_OrderList.Clear()
        With lsv_OrderList
            .BeginUpdate()
            .Items.Clear()
            .Columns.Clear()

            .View = View.Details
            .FullRowSelect = True

            .Columns.Add("", 0, HorizontalAlignment.Left)
            .Columns.Add("座席番号", 90, HorizontalAlignment.Center)
            .Columns.Add("注文No", 90, HorizontalAlignment.Center)
            .Columns.Add("会計時間", 115, HorizontalAlignment.Center)
            .Columns.Add("合計金額", 115, HorizontalAlignment.Center)
        End With

        '------------------------------
        ' 端末機一覧取得
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
    ' 　機　　能：CrossNavi【レシート再印字機能】
    ' 　機能概要：「注文一覧リスト」の表示項目取得
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2014.1 機能移植
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPD010(ByRef pData As DataSet, ByVal pSEATID As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPD010 = False

        '------------------------------
        ' ＳＱＬ文生成
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
        ' 返却値設定
        '------------------------------
        pData = objData
        LF_GetTPD010 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：CrossNavi【レシート再印字機能】
    ' 　機能概要：「注文明細」リストの表示項目取得
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2014.1 機能移植
    ' --------------------------------------------------------------------------------
    Private Function LF_GetOrderDetails(ByRef pData As DataSet, ByVal pSEATID As String, ByVal pORDERNO As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetOrderDetails = False

        '------------------------------
        ' ＳＱＬ文生成
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
        ' 返却値設定
        '------------------------------
        pData = objData
        LF_GetOrderDetails = True


    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：CrossNavi【レシート再印字機能】
    ' 　機能概要：注文一覧画面の表示項目取得
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2014.1 機能移植
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTotalPrice(ByVal pSEATID As String, ByVal pORDERNO As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim intCnt As Integer
        Dim intTotalPrice As Decimal

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTotalPrice = Nothing

        '------------------------------
        ' ＳＱＬ文生成
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
        If objData.Tables("com").Rows.Count = 0 Then Exit Function ' 抽出結果０件時は、何も行わない
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
        ' 返却値設定
        '------------------------------
        LF_GetTotalPrice = CStr(intTotalPrice)

    End Function

    Private Function LF_GetTaxPrice(ByVal pTotal As String) As Integer
        Dim Taxprice As Decimal      '税込み計算結果
        Dim price As Decimal         '税込み金額
        Dim Taxprice_dec As String   '税込み計算結果小数点第一位の値

        '' ------------------------------
        '' 初期値設定
        '' ------------------------------
        LF_GetTaxPrice = 0

        '税込み金額計算
        Taxprice = pTotal * (1 + (GF_GetAppInfo("SALES_TAX_RATE")) / 100)

        '計算結果の小数第一位の値を取得
        Taxprice_dec = Mid$((Taxprice - Fix(Taxprice)), 3, 1)

        'N捨N+1入処理
        '小数第一位の値が0の時
        If Taxprice_dec = Nothing Then
            pTotal = Format$(CLng(Trim$(Taxprice)), "###,##0")
        Else

            If Taxprice_dec > Trim$(GF_GetAppInfo("TAX_ROUND_OFF")) Then
                '小数第一位の値がNより大きい時
                price = Math.Ceiling(Taxprice)
            Else
                '小数第一位の値がN以下の時
                price = Math.Truncate(Taxprice)
            End If
            pTotal = Format$(CLng(Trim$(price)), "###,##0")
        End If

        LF_GetTaxPrice = pTotal

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：CrossNavi【レシート再印字機能】
    ' 　機能概要：注文明細画面表示　注文一覧画面のインデックス変更毎に呼び出される
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2014.1 機能移植
    ' --------------------------------------------------------------------------------
    Private Sub lsv_OrderList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_OrderList.SelectedIndexChanged


        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim strSeatNo As String
        Dim strOrderNo As String

        '------------------------------
        ' 選択項目取得
        '------------------------------
        objCollection = lsv_OrderList.SelectedItems
        With objCollection

            If .Count = 0 Then
                Exit Sub
            End If

            '------------------------------
            ' ガイダンス名編集領域へ転記
            '------------------------------
            strSeatNo = .Item(0).SubItems.Item(1).Text
            strOrderNo = .Item(0).SubItems.Item(2).Text

            '------------------------------
            ' グ登録済みコメントオプション一覧生成
            '------------------------------
            Call LS_SetOrderDetails(strSeatNo, strOrderNo)

        End With

    End Sub

    ' 2017.10.01 本部配信 クレスコ北陸 田代
    ' --------------------------------------------------------------------------------
    ' 　機　　能：本部SV側フォルダチェック
    ' 　機能概要：本部SV側に配信メニューフォルダが存在しているかチェック
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.10.01 クレスコ北陸 新規作成
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
    ' 　機　　能：店舗SV 既存メニューバックアップ
    ' 　機能概要：配信メニュー取込前に既存メニューのバックアップ作業を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.10.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_MenuBackUp() As Boolean

        '------------------------------
        ' 内部変数定義
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
        ' ディレクトリ存在チェック
        '------------------------------
        If System.IO.Directory.Exists("C:\CrossNavi\backup") = False Then
            ' 抜け出す
            Exit Function
        End If

        If Len("C:\CrossNavi\backup") <> 0 Then

            '------------------------------
            ' データエクスポート
            '------------------------------
            If LS_Deli_DataExport(objInfo) Then
                LF_MenuBackUp = True
            End If

        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：データエクスポート処理
    ' 　機能概要：既存メニューのバックアップ処理を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.10.01 クレスコ北陸 田代
    ' --------------------------------------------------------------------------------
    Private Function LS_Deli_DataExport(ByVal pInfo As typConnectionInfo) As Boolean

        '------------------------------
        ' 内部変数定義
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

                ' コピー元パス取得
                strExpPath = "C:\CrossNavi\backup"
            End With

            '------------------------------
            ' エクスポートパス準備
            '------------------------------

            strExpPath = strExpPath & "\BackUpData(" & Format$(Now, "yyyyMMddHHmmss") & ")"
            System.IO.Directory.CreateDirectory(strExpPath)
            targetPrgLabel.Text = "フォルダ作成：" + strExpPath
            ' 5%
            targetPrgBar.Value = 51

            '------------------------------
            ' BCPエクスポート
            '------------------------------
            If Not LF_DeliTableBackup(strExpPath & "\TableData", pInfo) Then
                Exit Function
            End If

            ' 5%
            targetPrgBar.Value = 52

            '------------------------------
            ' 画像ファイルコピー
            '------------------------------
            If Not LF_Deli_ImageBackup(strExpPath & "\ImageData", pInfo) Then
                Exit Function
            End If

            '------------------------------
            ' インポート用バッチファイル生成
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
    ' 　機　　能：配信メニュー取込処理
    ' 　機能概要：配信メニューを本部SV側からコピーする
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.10.01 クレスコ北陸 田代
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

        ' 本部SVの店舗配信フォルダへのパス
        strSVPath = GF_GetAppInfo("DELI_SV_IP") & "/CrossiAid/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/" & GF_GetAppInfo("DELI_SHOPCD")
        strFTPServer = GF_GetAppInfo("DELI_SV_IP")
        strShopDirectory = "/CrossiAid/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/" & GF_GetAppInfo("DELI_SHOPCD")

        ' 本部SVの配信メニューフォルダ名取得
        'strSVFullPath = strSVPath & "/" & GF_GetAppInfo("DELI_COMPANYCD") & "_" & GF_GetAppInfo("DELI_GYOTAICD") & "_" & GF_GetAppInfo("DELI_SHOPCD") & "_" & pstrDate
        strSVFullPath = strSVPath & "/" & GF_GetAppInfo("DELI_COMPANYCD") & "_" & GF_GetAppInfo("DELI_GYOTAICD") & "_" & pstrDate

        ' CL側の配信メニューコピー先パス
        strCLPath = GF_GetAppInfo("DELI_MENU_PATH") & "/BackUpData(" & Format(Now, "yyyyMMddHHmmss") & ")"

        ' メニュー配信フォルダの配信日取得
        strFolderName = LS_Right(strSVFullPath, 32).Replace(Environment.NewLine, "") 'Gert 08/06
        targetPrgLabel.Text = "インポート：" + strFolderName

        ' 2022-02-02
        ' 本部SV側のdelivaryflgへのパス(書き換え前)
        'strDeliFlgPath = GF_GetAppInfo("DELI_SV_IP") & "/CrossiAid/delivaryflg/" & strFolderName & "_0.txt"
        ' 本部SV側のdelivaryflgへのパス(書き換え前)
        'strDeliFlgLimiPath = GF_GetAppInfo("DELI_SV_IP") & "/CrossiAid/delivaryflg/" & strFolderName & "_5.txt"
        strDelivaryflgDir = "/CrossiAid/delivaryflg"

        strDeliFlgBeforeName = strFolderName & "_0.txt"
        If LF_ChkExistFTP(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName) Then

            ' 本部SV側のdelivaryflgへのパス(書き換え後)
            strDeliFlgAfterName = strFolderName & "_1.txt"

            ' delivaryflg書き換え
            If Not LF_Writeflg(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName, strDeliFlgAfterName) Then
                Exit Function
            End If

            strSVFullPath = strSVFullPath.Replace(Environment.NewLine, "")

            ' 配信メニューコピー
            ' ImageDataフォルダ作成
            Call System.IO.Directory.CreateDirectory(strCLPath & "/ImageData")
            ' ImageDataファイルダウンロード
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/AdvImage", strCLPath, "/ImageData/AdvImage")
            ' AdvImageディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/AdvImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/GroupImage", strCLPath, "/ImageData/GroupImage")
            ' GroupImageディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/GroupImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/ItemImage", strCLPath, "/ImageData/ItemImage")
            ' ItemImageディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/ItemImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/FreeMenuImage", strCLPath, "/ImageData/FreeMenuImage")
            ' FreeMenuImageディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/FreeMenuImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/MenuImage", strCLPath, "/ImageData/MenuImage")
            ' MenuImageディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/MenuImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/StoreMark", strCLPath, "/ImageData/StoreMark")
            ' StoreMarkディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/StoreMark")
            ' ImageDataディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData")
            ' TableDataフォルダ作成
            Call System.IO.Directory.CreateDirectory(strCLPath & "/TableData")
            ' TableDataファイルダウンロード
            Call LS_CopyDirectoryFTP(strSVFullPath & "/TableData", strCLPath, "/TableData")
            ' TableDataディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/TableData")
            ' メニューデータディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath)

            With objInfo
                .strSVNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer Name"))
                .strDBNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer DBName"))
                .strUserNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer UserID"))
                .strPasswd = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer PassWD"))
            End With

            ' ディレクトリ存在チェック
            If System.IO.Directory.Exists(strCLPath) = False Then
                ' 抜け出す
                Exit Function
            End If

            If Len(strCLPath) <> 0 Then

                ' データインポート
                If Not LS_Deli_DataInport(objInfo, strCLPath) Then
                    Exit Function
                End If

            End If

        Else
            strDeliFlgBeforeName = strFolderName & "_5.txt"
            If LF_ChkExistFTP(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName) Then

                ' 本部SV側のdelivaryflgへのパス(書き換え後)
                strDeliFlgAfterName = strFolderName & "_1.txt"

                ' delivaryflg書き換え
                If Not LF_Writeflg(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName, strDeliFlgAfterName) Then
                    Exit Function
                End If

                strSVFullPath = strSVFullPath.Replace(Environment.NewLine, "")

                ' 配信メニューコピー
                ' ImageDataフォルダ作成
                Call System.IO.Directory.CreateDirectory(strCLPath & "/ImageData")
                ' ImageDataファイルダウンロード
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/AdvImage", strCLPath, "/ImageData/AdvImage") 'Gert 10/12
                ' AdvImageディレクトリ削除
                Call LF_DeleteDirectoryContentsFTP(strSVFullPath & "/ImageData/AdvImage")
                Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/AdvImage")
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/GroupImage", strCLPath, "/ImageData/GroupImage") 'Gert 10/12
                ' GroupImageディレクトリ削除
                Call LF_DeleteDirectoryContentsFTP(strSVFullPath & "/ImageData/GroupImage")
                Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/GroupImage")
                Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/ItemImage", strCLPath, "/ImageData/ItemImage")
                ' ItemImageディレクトリ削除
                Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/ItemImage")
                Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/FreeMenuImage", strCLPath, "/ImageData/FreeMenuImage")
                ' FreeMenuImageディレクトリ削除
                Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/FreeMenuImage")
                Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/MenuImage", strCLPath, "/ImageData/MenuImage")
                ' MenuImageディレクトリ削除
                Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/MenuImage")
                Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/StoreMark", strCLPath, "/ImageData/StoreMark")
                ' StoreMarkディレクトリ削除
                Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/StoreMark")
                ' ImageDataディレクトリ削除
                Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData")
                ' TableDataフォルダ作成
                Call System.IO.Directory.CreateDirectory(strCLPath & "/TableData")
                ' TableDataファイルダウンロード
                Call LS_CopyDirectoryFTP(strSVFullPath & "/TableData", strCLPath, "/TableData")
                ' TableDataディレクトリ削除
                Call LF_DeleteDirectoryFTP(strSVFullPath & "/TableData")
                ' メニューデータディレクトリ削除
                Call LF_DeleteDirectoryFTP(strSVFullPath)

                ' 50%
                targetPrgBar.Value = 500

                With objInfo
                    .strSVNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer Name"))
                    .strDBNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer DBName"))
                    .strUserNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer UserID"))
                    .strPasswd = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer PassWD"))
                End With

                ' ディレクトリ存在チェック
                If System.IO.Directory.Exists(strCLPath) = False Then
                    ' 抜け出す
                    Exit Function
                End If

                If Len(strCLPath) <> 0 Then

                    ' データインポート(限定配信)
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

        ' 本部SV側のdelivaryflgへのパス(書き換え前)
        'strDeliFlgPath = GF_GetAppInfo("DELI_SV_IP") & "/CrossiAid/delivaryflg/" & strFolderName & "_1.txt"
        strDeliFlgBeforeName = strFolderName & "_1.txt"

        ' 本部SV側のdelivaryflgへのパス(書き換え後)
        strDeliFlgAfterName = strFolderName & "_2.txt"

        ' delivaryflg書き換え
        If Not LF_Writeflg(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName, strDeliFlgAfterName) Then
            Exit Function
        End If

        ' 94%
        targetPrgBar.Value = 940
        targetPrgLabel.Text = "店舗フォルダを削除する：" + strCLPath

        ' 店舗CL側配信メニューフォルダ削除
        System.IO.Directory.Delete(strCLPath, True)

        ' 本部SV側配信メニューフォルダ削除
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

        ' 本部SVの店舗配信フォルダへのパス
        strSVPath = GF_GetAppInfo("DELI_SV_IP") & "/OMOTENASHI/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/" & GF_GetAppInfo("DELI_SHOPCD")
        strFTPServer = GF_GetAppInfo("DELI_SV_IP")
        strShopDirectory = "/OMOTENASHI/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/" & GF_GetAppInfo("DELI_SHOPCD")

        ' 本部SVの配信メニューフォルダ名取得
        'strSVFullPath = strSVPath & "/" & GF_GetAppInfo("DELI_COMPANYCD") & "_" & GF_GetAppInfo("DELI_GYOTAICD") & "_" & GF_GetAppInfo("DELI_SHOPCD") & "_" & pstrDate
        'strSVFullPath = strSVPath & "/" & GF_GetAppInfo("DELI_COMPANYCD") & "_" & GF_GetAppInfo("DELI_GYOTAICD") & "_" & pstrDate
        strSVFullPath = strSVPath & "/" & pTargetDir

        ' CL側の配信メニューコピー先パス
        'strCLPath = GF_GetAppInfo("DELI_MENU_PATH") & "/BackUpData(" & Format(Now, "yyyyMMddHHmmss") & ")"
        strCLPath = GF_GetAppInfo("DELI_MENU_PATH") & "\O" & LS_Right(pTargetDir, 12) & "(" & Format(Now, "yyyyMMddHHmmss") & ")"

        ' メニュー配信フォルダの配信日取得
        strFolderName = LS_Right(strSVFullPath, 47).Replace(Environment.NewLine, "") 'Gert 08/06
        targetPrgLabel.Text = "インポート：" + strFolderName

        ' 2022-02-02
        ' 本部SV側のdelivaryflgへのパス(書き換え前)
        'strDeliFlgPath = GF_GetAppInfo("DELI_SV_IP") & "/CrossiAid/delivaryflg/" & strFolderName & "_0.txt"
        ' 本部SV側のdelivaryflgへのパス(書き換え前)
        'strDeliFlgLimiPath = GF_GetAppInfo("DELI_SV_IP") & "/CrossiAid/delivaryflg/" & strFolderName & "_5.txt"
        strDelivaryflgDir = "/OMOTENASHI/" & GF_GetAppInfo("DELI_COMPANYCD") & "/" & GF_GetAppInfo("DELI_GYOTAICD") & "/delivaryflg"

        strDeliFlgBeforeName = strFolderName & "_0.txt"
        If LF_ChkExistFTP(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName) Then

            ' 本部SV側のdelivaryflgへのパス(書き換え後)
            strDeliFlgAfterName = strFolderName & "_1.txt"

            ' delivaryflg書き換え
            If Not LF_Writeflg(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName, strDeliFlgAfterName) Then
                Exit Function
            End If

            strSVFullPath = strSVFullPath.Replace(Environment.NewLine, "")

            ' 配信メニューコピー
            ' ImageDataフォルダ作成
            Call System.IO.Directory.CreateDirectory(strCLPath & "/ImageData")
            ' ImageDataファイルダウンロード
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/AdvImage", strCLPath, "/ImageData/AdvImage")
            ' AdvImageディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/AdvImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/GroupImage", strCLPath, "/ImageData/GroupImage")
            ' GroupImageディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/GroupImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/ItemImage", strCLPath, "/ImageData/ItemImage")
            ' ItemImageディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/ItemImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/FreeMenuImage", strCLPath, "/ImageData/FreeMenuImage")
            ' FreeMenuImageディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/FreeMenuImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/MenuImage", strCLPath, "/ImageData/MenuImage")
            ' MenuImageディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/MenuImage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/StoreMark", strCLPath, "/ImageData/StoreMark")
            ' StoreMarkディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/StoreMark")

            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/MenuPage", strCLPath, "/ImageData/MenuPage")
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/MenuPage")
            Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/MenuThumbnail", strCLPath, "/ImageData/MenuThumbnail")
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/MenuThumbnail")

            ' ImageDataディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData")
            ' TableDataフォルダ作成
            Call System.IO.Directory.CreateDirectory(strCLPath & "/TableData")
            ' TableDataファイルダウンロード
            Call LS_CopyDirectoryFTP(strSVFullPath & "/TableData", strCLPath, "/TableData")
            ' TableDataディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath & "/TableData")
            ' メニューデータディレクトリ削除
            Call LF_DeleteDirectoryFTP(strSVFullPath)

            With objInfo
                .strSVNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer Name"))
                .strDBNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer DBName"))
                .strUserNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer UserID"))
                .strPasswd = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer PassWD"))
            End With

            ' ディレクトリ存在チェック
            If System.IO.Directory.Exists(strCLPath) = False Then
                ' 抜け出す
                Exit Function
            End If

            If Len(strCLPath) <> 0 Then

                ' 2022-03-29-
                ' データインポート
                If Not LS_OMOTENASHI_DataInport(objInfo, strCLPath) Then
                    Exit Function
                End If

            End If

        Else
            strDeliFlgBeforeName = strFolderName & "_5.txt"
            If LF_ChkExistFTP(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName) Then
                ' 本部SV側のdelivaryflgへのパス(書き換え後)
                'strDeliFlgAfterName = strFolderName & "_1.txt"
                ' delivaryflg書き換え
                'If Not LF_Writeflg(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName, strDeliFlgAfterName) Then
                '    Exit Function
                'End If
                'strSVFullPath = strSVFullPath.Replace(Environment.NewLine, "")
                ' 配信メニューコピー
                ' ImageDataフォルダ作成
                'Call System.IO.Directory.CreateDirectory(strCLPath & "/ImageData")
                ' ImageDataファイルダウンロード
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/AdvImage", strCLPath, "/ImageData/AdvImage") 'Gert 10/12
                ' AdvImageディレクトリ削除
                'Call LF_DeleteDirectoryContentsFTP(strSVFullPath & "/ImageData/AdvImage")
                'Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/AdvImage")
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/GroupImage", strCLPath, "/ImageData/GroupImage") 'Gert 10/12
                ' GroupImageディレクトリ削除
                'Call LF_DeleteDirectoryContentsFTP(strSVFullPath & "/ImageData/GroupImage")
                'Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/GroupImage")
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/ItemImage", strCLPath, "/ImageData/ItemImage")
                ' ItemImageディレクトリ削除
                'Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/ItemImage")
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/FreeMenuImage", strCLPath, "/ImageData/FreeMenuImage")
                ' FreeMenuImageディレクトリ削除
                'Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/FreeMenuImage")
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/MenuImage", strCLPath, "/ImageData/MenuImage")
                ' MenuImageディレクトリ削除
                'Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/MenuImage")
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/ImageData/StoreMark", strCLPath, "/ImageData/StoreMark")
                ' StoreMarkディレクトリ削除
                'Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData/StoreMark")
                ' ImageDataディレクトリ削除
                'Call LF_DeleteDirectoryFTP(strSVFullPath & "/ImageData")
                ' TableDataフォルダ作成
                'Call System.IO.Directory.CreateDirectory(strCLPath & "/TableData")
                ' TableDataファイルダウンロード
                'Call LS_CopyDirectoryFTP(strSVFullPath & "/TableData", strCLPath, "/TableData")
                ' TableDataディレクトリ削除
                'Call LF_DeleteDirectoryFTP(strSVFullPath & "/TableData")
                ' メニューデータディレクトリ削除
                'Call LF_DeleteDirectoryFTP(strSVFullPath)
                ' 50%
                'prg_Bar.Value = 500
                'With objInfo
                '    .strSVNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer Name"))
                '    .strDBNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer DBName"))
                '    .strUserNM = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer UserID"))
                '    .strPasswd = Trim$(System.Configuration.ConfigurationManager.AppSettings("DBServer PassWD"))
                'End With
                ' ディレクトリ存在チェック
                'If System.IO.Directory.Exists(strCLPath) = False Then
                '    ' 抜け出す
                '    Exit Function
                'End If
                'If Len(strCLPath) <> 0 Then
                '    ' データインポート(限定配信)
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

        ' 本部SV側のdelivaryflgへのパス(書き換え前)
        'strDeliFlgPath = GF_GetAppInfo("DELI_SV_IP") & "/CrossiAid/delivaryflg/" & strFolderName & "_1.txt"
        strDeliFlgBeforeName = strFolderName & "_1.txt"

        ' 本部SV側のdelivaryflgへのパス(書き換え後)
        strDeliFlgAfterName = strFolderName & "_2.txt"

        ' delivaryflg書き換え
        If Not LF_Writeflg(strFTPServer, strDelivaryflgDir, strDeliFlgBeforeName, strDeliFlgAfterName) Then
            Exit Function
        End If

        ' 94%
        targetPrgBar.Value = 940
        targetPrgLabel.Text = "店舗フォルダを削除する：" + strCLPath

        ' 店舗CL側配信メニューフォルダ削除
        System.IO.Directory.Delete(strCLPath, True)

        ' 本部SV側配信メニューフォルダ削除
        If Not LF_DeleteFolderSV(strSVFullPath) Then
            Exit Function
        End If

        ' 95%
        targetPrgBar.Value = 950

        LS_OMOTENASHI_Import = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：バックアップメニュー取込処理
    ' 　機能概要：バックアップからメニューデータを取り込む
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.10.01 クレスコ北陸 田代
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

        ' ディレクトリ存在チェック
        If System.IO.Directory.Exists(strPath) = False Then
            ' 抜け出す
            Exit Function
        End If

        If Len(strPath) <> 0 Then

            ' データインポート
            If Not LS_Backup_DataInport(objInfo, strPath) Then
                Exit Function
            End If

        End If

        LS_Backup_Import = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ディレクトリコピー処理
    ' 　機能概要：配信メニューを本部SV側からコピーする
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.10.01 クレスコ北陸 田代
    ' --------------------------------------------------------------------------------
    Private Sub LS_CopyDirectory(ByVal sourceDirName As String, ByVal destDirName As String)

        ''コピー先のディレクトリがないときは作る
        If Not System.IO.Directory.Exists(destDirName) Then
            System.IO.Directory.CreateDirectory(destDirName)
            '属性もコピー
            System.IO.File.SetAttributes(destDirName, System.IO.File.GetAttributes(sourceDirName))
        End If

        'コピー先のディレクトリ名の末尾に"\"をつける
        If destDirName.Chars((destDirName.Length - 1)) <> System.IO.Path.DirectorySeparatorChar Then
            destDirName = destDirName + System.IO.Path.DirectorySeparatorChar
        End If

        'コピー元のディレクトリにあるファイルをコピー
        Dim fs As String() = System.IO.Directory.GetFiles(sourceDirName)
        Dim f As String

        For Each f In fs
            System.IO.File.Copy(f, destDirName + System.IO.Path.GetFileName(f), True)
        Next

        'コピー元のディレクトリにあるディレクトリをコピー
        Dim dirs As String() = System.IO.Directory.GetDirectories(sourceDirName)
        Dim dir As String

        For Each dir In dirs
            LS_CopyDirectory(dir, destDirName + System.IO.Path.GetFileName(dir))
        Next
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ディレクトリコピー処理
    ' 　機能概要：配信メニューを本部SV側からコピーする
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2018.01.11 クレスコ北陸 田代
    ' --------------------------------------------------------------------------------
    Private Sub LS_CopyDirectoryFTP(ByVal pPath As String, ByVal pDirNM As String, ByVal pNM As String)

        Dim strSVFile As String = ""
        Dim strLocalFile As String = ""
        Dim strFileErrorMessage As String = ""
        Dim e As ExecutionEngineException


        Try

            System.IO.Directory.CreateDirectory(pDirNM & pNM)

            'ファイル一覧を取得するディレクトリのURI
            Dim u As New Uri("ftp://" & pPath & "/")

            'FtpWebRequestの作成
            Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(u), System.Net.FtpWebRequest)
            'ログインユーザー名とパスワードを設定
            'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
            Dim strFTPId As String = "ftp"
            Dim strFTPPass As String = ""
            getFTPUserPass(strFTPId, strFTPPass)
            ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)
            'MethodにWebRequestMethods.Ftp.ListDirectoryDetails("LIST")を設定
            ftpReq.Method = System.Net.WebRequestMethods.Ftp.ListDirectory
            '要求の完了後に接続を閉じる
            ftpReq.KeepAlive = False
            ' 2019-11-06 -------------------------------------------------------------------------------
            If System.Configuration.ConfigurationManager.AppSettings("FTPUploadPassiveMode") = "0" Then
                'PASSIVEモードを無効にする
                ftpReq.UsePassive = False
            Else
                ftpReq.UsePassive = True
            End If
            ' ------------------------------------------------------------------------------------------
            'FtpWebResponseを取得
            Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
            'FTPサーバーから送信されたデータを取得
            Dim sr As New System.IO.StreamReader(ftpRes.GetResponseStream()) '"Shift-JIS" 'Gert 04/01
            Dim res As String = sr.ReadToEnd()

            sr.Close()
            '閉じる
            ftpRes.Close()

            If res.Count = 0 Then
                Exit Sub
            End If

            Dim strFileNM As String() = res.Split(Environment.NewLine)

            ''WebClientオブジェクトを作成
            'Dim wc As New System.Net.WebClient()
            ''ログインユーザー名とパスワードを指定
            'wc.Credentials = New System.Net.NetworkCredential("ftp", "")

            For i As Integer = 0 To strFileNM.Count - 2
                targetPrgLabel.Text = "ファイル取り込む：" + strFileNM(i)
                ' 0.1%ずつ増加
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

                'FTPサーバーからダウンロードする
                'wc.DownloadFile("ftp://" & strSVFile, strLocalFile)
                If Not LF_TransFileDataFTP(strSVFile, strLocalFile) = "" Then 'Gert 04/01
                    If Not LF_TransFileDataFTP(strSVFile, strLocalFile) = "" Then 'Gert 10/01 3回retry
                        strFileErrorMessage = LF_TransFileDataFTP(strSVFile, strLocalFile)
                        If Not strFileErrorMessage = "" Then
                            GS_ErrorTerm(strFileErrorMessage)
                            Exit Sub
                        End If
                    End If

                End If

                ' FTPサーバのファイル削除
                If Not LF_DeleteFileFTP(strSVFile) Then 'Gert 10/01 3回retry
                    If Not LF_DeleteFileFTP(strSVFile) Then
                        If Not LF_DeleteFileFTP(strSVFile) Then
                            Exit Sub
                        End If
                    End If
                End If


            Next

            '解放する
            'wc.Dispose()

        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューデータダウンロード処理(FTP処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.12.01 クレスコ北陸 新規作成
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

            LF_TransFileDataFTP = "FTP接続エラー"

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
            'FtpWebResponseを取得
            Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
            'ファイルをダウンロードするためのStreamを取得
            Dim resStrm As System.IO.Stream = ftpRes.GetResponseStream()
            'ダウンロードしたファイルを書き込むためのFileStreamを作成
            Dim fs As New System.IO.FileStream(downFile, System.IO.FileMode.Create, System.IO.FileAccess.Write)
            'ダウンロードしたデータを書き込む
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

            '閉じる
            ftpRes.Close()

            LF_TransFileDataFTP = ""

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Function

SYSTEM_ERROR:
        'Call GS_ErrorTerm("FTPファイル通信エラー：" & strFileNM)
        LF_TransFileDataFTP = pFilename
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：FTPファイルデータ削除処理(FTP処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2018.02.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_DeleteFileFTP(ByVal pdir As String) As Boolean

        LF_DeleteFileFTP = False

        '削除するファイルのURI
        Dim u As New Uri("ftp://" & pdir)

        'FtpWebRequestの作成
        Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(u), System.Net.FtpWebRequest)
        'ログインユーザー名とパスワードを設定
        'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
        Dim strFTPId As String = "ftp"
        Dim strFTPPass As String = ""
        getFTPUserPass(strFTPId, strFTPPass)
        ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)
        'MethodにWebRequestMethods.Ftp.DeleteFileを設定
        ftpReq.Method = System.Net.WebRequestMethods.Ftp.DeleteFile

        'FtpWebResponseを取得
        Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)

        '閉じる
        ftpRes.Close()

        LF_DeleteFileFTP = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：FTPディレクトリ削除処理(FTP処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2018.02.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_DeleteDirectoryFTP(ByVal pdir As String) As Boolean
        targetPrgLabel.Text = "フォルダー削除：" + pdir

        Dim success As Boolean = False
        Dim tries As Integer = 0


        Do While (success = False And tries < 3)

            Try
                '削除するファイルのURI
                Dim u As New Uri("ftp://" & pdir)

                'FtpWebRequestの作成
                Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(u), System.Net.FtpWebRequest)
                'ログインユーザー名とパスワードを設定
                'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
                Dim strFTPId As String = "ftp"
                Dim strFTPPass As String = ""
                getFTPUserPass(strFTPId, strFTPPass)
                ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)
                'MethodにWebRequestMethods.Ftp.RemoveDirectoryを設定
                ftpReq.Method = System.Net.WebRequestMethods.Ftp.RemoveDirectory

                'FtpWebResponseを取得
                Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)

                '閉じる
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
    ' 　機　　能：FTPディレクトリ削除処理(FTP処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2018.02.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LF_DeleteDirectoryContentsFTP(ByVal pdir As String)
        targetPrgLabel.Text = "フォルダー削除：" + pdir

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

            ''WebClientオブジェクトを作成
            'Dim wc As New System.Net.WebClient()
            ''ログインユーザー名とパスワードを指定
            'wc.Credentials = New System.Net.NetworkCredential("ftp", "")

            For i As Integer = 0 To strFileNM.Count - 2
                If i > 0 Then
                    strFileNM(i) = strFileNM(i).TrimStart
                End If

                strSVFile = pdir & "/" & Trim$(strFileNM(i))

                ' FTPサーバのファイル削除
                If Not LF_DeleteFileFTP(strSVFile) Then 'Gert 10/01 3回retry
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
    ' 　機　　能：既存メニューDELETE処理
    ' 　機能概要：既存メニューをDBからDELETEする
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.10.01 クレスコ北陸 田代
    ' --------------------------------------------------------------------------------
    Private Function LS_DeleteMenu(ByVal pPutPath As String) As Boolean

        Dim strSQL As String = ""

        LS_DeleteMenu = False

        Try
            For i As Integer = 0 To 29
                Select Case i

                    Case 0
                        targetPrgLabel.Text = "削除:" + "TPM010"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM010"
                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 1
                        targetPrgLabel.Text = "削除:" + "TPM020"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM020"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 2
                        targetPrgLabel.Text = "削除:" + "TPM030"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM030"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 3
                        targetPrgLabel.Text = "削除:" + "TPM040"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM040"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 4
                        targetPrgLabel.Text = "削除:" + "TPM060"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM060"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 5
                        targetPrgLabel.Text = "削除:" + "TPM061"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM061"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 6
                        targetPrgLabel.Text = "削除:" + "TPM062"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM062"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 7
                        targetPrgLabel.Text = "削除:" + "TPM080"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM080"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 8
                        'targetPrgLabel.Text = "削除:" + "TPM090"
                        'strSQL = ""
                        'strSQL = strSQL & " DELETE FROM TPM090"

                        'If Not GF_UpdCmtData(strSQL) Then
                        '    Exit Function
                        'End If
                    Case 9
                        'targetPrgLabel.Text = "削除:" + "TPM091"
                        'strSQL = ""
                        'strSQL = strSQL & " DELETE FROM TPM091"

                        'If Not GF_UpdCmtData(strSQL) Then
                        '    Exit Function
                        'End If
                    Case 10
                        targetPrgLabel.Text = "削除:" + "TPM092"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM092"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 11
                        targetPrgLabel.Text = "削除:" + "TPM100"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM100"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 12
                        targetPrgLabel.Text = "削除:" + "TPM110"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM110"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 13
                        targetPrgLabel.Text = "削除:" + "TPM120"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM120"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 14
                        targetPrgLabel.Text = "削除:" + "TPM160"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM160"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 15
                        targetPrgLabel.Text = "削除:" + "TPM170"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM170"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 16
                        targetPrgLabel.Text = "削除:" + "TPM200"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM200"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 17
                        targetPrgLabel.Text = "削除:" + "TPM210"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM210"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 18
                        targetPrgLabel.Text = "削除:" + "TPM220"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM220"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 19
                        targetPrgLabel.Text = "削除:" + ""
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM230"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 20
                        targetPrgLabel.Text = "削除:" + "TPM240"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM240"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 21
                        targetPrgLabel.Text = "削除:" + "TPM250"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM250"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 22
                        targetPrgLabel.Text = "削除:" + "TPM260"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM260"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 23
                        targetPrgLabel.Text = "削除:" + "TPM300"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM300"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 24
                        targetPrgLabel.Text = "削除:" + "TPM310"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM310"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 25
                        targetPrgLabel.Text = "削除:" + "TPM330"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM330"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 26
                        targetPrgLabel.Text = "削除:" + "TPM340"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM340"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 27
                        targetPrgLabel.Text = "削除:" + "TPM350"
                        strSQL = ""
                        strSQL = strSQL & " DELETE FROM TPM350"

                        If Not GF_UpdCmtData(strSQL) Then
                            Exit Function
                        End If
                    Case 28
                        targetPrgLabel.Text = "削除:" + "TPM600"
                        strSQL = ""

                        If System.IO.File.Exists(pPutPath & "\TableData\TPM600.txt") = True Then
                            'TPM600データ存在時
                            strSQL = strSQL & " DELETE FROM TPM600"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        End If
                    Case 29
                        targetPrgLabel.Text = "削除:" + "TPM610"
                        strSQL = ""

                        If System.IO.File.Exists(pPutPath & "\TableData\TPM610.txt") = True Then
                            'TPM610データ存在時
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
                            targetPrgLabel.Text = "削除:" + "TPM010A"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM010A"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 1
                            targetPrgLabel.Text = "削除:" + "TPM010B"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM010B"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 2
                            targetPrgLabel.Text = "削除:" + "TPM010C"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM010C"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 3
                            targetPrgLabel.Text = "削除:" + "TPM020A"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM020A"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 4
                            targetPrgLabel.Text = "削除:" + "TPM020B"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM020B"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 5
                            targetPrgLabel.Text = "削除:" + "TPM020C"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM020C"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 6
                            targetPrgLabel.Text = "削除:" + "TPM030A"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM030A"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 7
                            targetPrgLabel.Text = "削除:" + "TPM030B"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM030B"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 8
                            targetPrgLabel.Text = "削除:" + "TPM030C"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM030C"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 9
                            targetPrgLabel.Text = "削除:" + "TPM060A"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM060A"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 10
                            targetPrgLabel.Text = "削除:" + "TPM060B"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM060B"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 11
                            targetPrgLabel.Text = "削除:" + "TPM060C"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM060C"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 12
                            targetPrgLabel.Text = "削除:" + "TPM061A"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM061A"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 13
                            targetPrgLabel.Text = "削除:" + "TPM061B"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM061B"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 14
                            targetPrgLabel.Text = "削除:" + "TPM061C"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM061C"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 15
                            targetPrgLabel.Text = "削除:" + "TPM100A"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM100A"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 16
                            targetPrgLabel.Text = "削除:" + "TPM100B"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM100B"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 17
                            targetPrgLabel.Text = "削除:" + "TPM100C"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM100C"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 18
                            targetPrgLabel.Text = "削除:" + "TPM240A"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM240A"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 19
                            targetPrgLabel.Text = "削除:" + "TPM240B"
                            strSQL = ""
                            strSQL = strSQL & " DELETE FROM TPM240B"

                            If Not GF_UpdCmtData(strSQL) Then
                                Exit Function
                            End If
                        Case 20
                            targetPrgLabel.Text = "削除:" + "TPM240C"
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
            targetPrgLabel.Text = "削除:" + "TPM540"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM540"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "削除:" + "TPM541"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM541"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "削除:" + "TPM545"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM545"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "削除:" + "TPM550"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM550"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "削除:" + "TPM552"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM552"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "削除:" + "TPM554"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM554"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "削除:" + "TPM555"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM555"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "削除:" + "TPM556"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM556"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "削除:" + "TPM557"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM557"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "削除:" + "TPM558"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM558"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "削除:" + "TPM559"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM559"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "削除:" + "TPM560"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM560"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "削除:" + "TPM562"
            strSQL = ""
            strSQL = strSQL & " DELETE FROM TPM562"
            If Not GF_UpdCmtData(strSQL) Then
                Exit Function
            End If

            targetPrgLabel.Text = "削除:" + "TPM565"
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
    ' 　機　　能：TPM350 DELETE処理(限定配信)
    ' 　機能概要：既存メニューをDBからDELETEする
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.12.01 クレスコ北陸 田代
    ' --------------------------------------------------------------------------------
    Private Function LS_DeleteTPM350() As Boolean
        targetPrgLabel.Text = "テーブル削除：TPM350"
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
    ' 　機　　能：TPM010 DELETE処理(限定配信)
    ' 　機能概要：既存メニューをDBからDELETEする
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.12.01 クレスコ北陸 田代
    ' --------------------------------------------------------------------------------
    Private Function LS_DeleteTPM010(ByVal pgoodscd As String) As Boolean

        Dim strSQL As String = ""

        LS_DeleteTPM010 = False

        Try
            targetPrgLabel.Text = "限定配信商品削除：TPM010：" + pgoodscd
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
    ' 　機　　能：データインポート処理
    ' 　機能概要：配信メニューのインポート処理を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.10.01 クレスコ北陸 田代
    ' --------------------------------------------------------------------------------
    Private Function LS_Deli_DataInport(ByVal pInfo As typConnectionInfo, ByVal pPath As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strExpPath As String

        LS_Deli_DataInport = False

        With pInfo
            .strAdvPath = Trim$(GF_GetAppInfo("ADV_PATH"))
            .strItemPath = Trim$(GF_GetAppInfo("ITEM_PATH"))
            .strGrpPath = Trim$(GF_GetAppInfo("GROUP_PATH"))
            .strMenuGrpPath = Trim$(GF_GetAppInfo("MENUIMG_V"))
            .strStoreMkPath = Trim$(GF_GetAppInfo("STOREMARK_V"))

            ' インポート元パス取得
            strExpPath = pPath
        End With
        ' 90%
        targetPrgBar.Value = 900

        ' 画像ファイルコピー
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

        ' インポート用コマンド実行
        If Not LS_CreateImportCommand(strExpPath, pInfo) Then
            Exit Function
        End If

        LS_Deli_DataInport = True

    End Function

    Private Function LS_OMOTENASHI_DataInport(ByVal pInfo As typConnectionInfo, ByVal pPath As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strExpPath As String

        LS_OMOTENASHI_DataInport = False

        With pInfo
            .strAdvPath = Trim$(GF_GetAppInfo("ADV_PATH"))
            .strItemPath = Trim$(GF_GetAppInfo("ITEM_PATH"))
            .strGrpPath = Trim$(GF_GetAppInfo("GROUP_PATH"))
            .strMenuGrpPath = Trim$(GF_GetAppInfo("MENUIMG_V"))
            .strStoreMkPath = Trim$(GF_GetAppInfo("STOREMARK_V"))

            ' インポート元パス取得
            strExpPath = pPath
        End With
        ' 90%
        targetPrgBar.Value = 900

        ' 画像ファイルコピー
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

        ' インポート用コマンド実行
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
    ' 　機　　能：データインポート処理
    ' 　機能概要：配信メニューのインポート処理を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.10.01 クレスコ北陸 田代
    ' --------------------------------------------------------------------------------
    Private Function LS_Deli_DataInportLimited(ByVal pInfo As typConnectionInfo, ByVal pPath As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strExpPath As String

        LS_Deli_DataInportLimited = False

        With pInfo
            .strAdvPath = Trim$(GF_GetAppInfo("ADV_PATH"))
            .strItemPath = Trim$(GF_GetAppInfo("ITEM_PATH"))
            .strGrpPath = Trim$(GF_GetAppInfo("GROUP_PATH"))
            .strMenuGrpPath = Trim$(GF_GetAppInfo("MENUIMG_V"))
            .strStoreMkPath = Trim$(GF_GetAppInfo("STOREMARK_V"))

            ' インポート元パス取得
            strExpPath = pPath
        End With
        ' 60%
        targetPrgBar.Value = 60
        ' 画像ファイルコピー
        LS_Deli_ImageBackupLimited(strExpPath & "\ImageData", pInfo)

        ' 70%
        targetPrgBar.Value = 60

        If Not LS_DeleteTPM350() Then
            Exit Function
        End If

        If Not LS_ChgCsvLimited(strExpPath) Then
            Exit Function
        End If

        ' インポート用コマンド実行(TPM350)
        If Not LS_ImportCommandLimited(False, strExpPath, pInfo) Then
            Exit Function
        End If

        ' 70%
        targetPrgBar.Value = 70

        If Not LF_SelectDelteTPM010() Then
            Exit Function
        End If

        ' インポート用コマンド実行(TPM010)
        If Not LS_ImportCommandLimited(True, strExpPath, pInfo) Then
            Exit Function
        End If

        LS_Deli_DataInportLimited = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：データインポート処理
    ' 　機能概要：バックアップデータのインポート処理を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.10.01 クレスコ北陸 田代
    ' --------------------------------------------------------------------------------
    Private Function LS_Backup_DataInport(ByVal pInfo As typConnectionInfo, ByVal pPath As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strExpPath As String

        LS_Backup_DataInport = False

        With pInfo
            .strAdvPath = Trim$(GF_GetAppInfo("ADV_PATH"))
            .strItemPath = Trim$(GF_GetAppInfo("ITEM_PATH"))
            .strGrpPath = Trim$(GF_GetAppInfo("GROUP_PATH"))
            .strMenuGrpPath = Trim$(GF_GetAppInfo("MENUIMG_V"))
            .strStoreMkPath = Trim$(GF_GetAppInfo("STOREMARK_V"))

            ' インポート元パス取得
            strExpPath = pPath
        End With

        ' 画像ファイルコピー
        'If Not LS_Deli_ImageBackup(strExpPath & "\ImageData", pInfo) Then
        '    Exit Function
        'End If

        If Not LS_DeleteMenu(strExpPath) Then
            Exit Function
        End If

        ' インポート用コマンド実行
        If Not LS_CreateImportCommand(strExpPath, pInfo) Then
            Exit Function
        End If

        LS_Backup_DataInport = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：拡張子変換処理
    ' 　機能概要：拡張子の変換処理を行う
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2017.09.21 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LS_ChgCsv(ByVal pPutPath As String) As Boolean

        LS_ChgCsv = False

        Try
            targetPrgLabel.Text = "テーブルデータ移動中"
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
                'TPM600データ存在時
                System.IO.File.Move(pPutPath & "\TableData\TPM600.csv", pPutPath & "\TableData\TPM600.txt")
            End If
            If System.IO.File.Exists(pPutPath & "\TableData\TPM610.csv") = True Then
                'TPM610データ存在時
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
            targetPrgLabel.Text = "テーブルデータ移動中"
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
    ' 　機　　能：拡張子変換処理
    ' 　機能概要：拡張子の変換処理を行う
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2017.12.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LS_ChgCsvLimited(ByVal pPutPath As String) As Boolean

        LS_ChgCsvLimited = False

        Try
            targetPrgLabel.Text = "テーブルデータ移動：TPM010"
            System.IO.File.Move(pPutPath & "\TableData\TPM010.csv", pPutPath & "\TableData\TPM010.txt")
            targetPrgLabel.Text = "テーブルデータ移動：TPM010"
            System.IO.File.Move(pPutPath & "\TableData\TPM350.csv", pPutPath & "\TableData\TPM350.txt")

            LS_ChgCsvLimited = True

            Exit Function
        Catch
            Exit Function
        End Try

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像ファイルコピー処理
    ' 　機能概要：配信されたメニューの画像ファイルをコピーを行う
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2017.09.21 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LS_Deli_ImageBackup(ByVal pTargetPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        '------------------------------
        ' 初期値設定
        '------------------------------
        LS_Deli_ImageBackup = False

        Try
            '------------------------------
            ' 画像ファイル退避
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
        ' 返却値設定
        '------------------------------
        LS_Deli_ImageBackup = True

    End Function

    Private Function LS_OMOTENASHI_ImageBackup(ByVal pTargetPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        '------------------------------
        ' 初期値設定
        '------------------------------
        LS_OMOTENASHI_ImageBackup = False

        Try
            '------------------------------
            ' 画像ファイル退避
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
        ' 返却値設定
        '------------------------------
        LS_OMOTENASHI_ImageBackup = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像ファイルコピー処理
    ' 　機能概要：配信されたメニューの画像ファイルをコピーを行う
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2017.09.21 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_Deli_ImageBackupLimited(ByVal pTargetPath As String, ByVal pInfo As typConnectionInfo)

        '------------------------------
        ' 画像ファイル退避
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
    ' 　機　　能：配信メニューDB登録処理
    ' 　機能概要：配信メニューをDBにINSERT処理を行う
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2017.10.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LS_CreateImportCommand(ByVal pPutPath As String, ByVal pInfo As typConnectionInfo) As Boolean

        Dim proc As New System.Diagnostics.Process
        Dim strLUNGflg As String

        LS_CreateImportCommand = False

        Try

            '多言語機能対応
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
            targetPrgLabel.Text = "テーブルデータインポート"
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
                    'TPM600データ存在時
                    sw.WriteLine("bcp " & pInfo.strDBNM & "..TPM600 in " & """" & pPutPath & "\TableData\TPM600.txt" & """" & " -S " & pInfo.strSVNM & " -U " & pInfo.strUserNM & " -P " & pInfo.strPasswd & " -c -t ,")
                End If
                If System.IO.File.Exists(pPutPath & "\TableData\TPM610.txt") = True Then
                    'TPM610データ存在時
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

            '多言語機能対応
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
            targetPrgLabel.Text = "テーブルデータインポート"
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
    ' 　機　　能：配信メニューDB登録処理(限定配信)
    ' 　機能概要：配信メニューをDBにINSERT処理を行う
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2017.10.01 クレスコ北陸 新規作成
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
            targetPrgLabel.Text = "一括インポート：TPM010"
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
            targetPrgLabel.Text = "一括インポート：TPM350"
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
                targetPrgLabel.Text = "一括インポート：TPM010A"
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

                targetPrgLabel.Text = "一括インポート：TPM010B"
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

                targetPrgLabel.Text = "一括インポート：TPM010C"
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
    ' 　機　　能：出力文字列表示処理
    ' 　機能概要：省略
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2017.10.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    '行が出力されるたびに呼び出される
    Private Sub p_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs)
        '出力された文字列を表示する
        Console.WriteLine(e.Data)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：文字列切り取り処理
    ' 　機能概要：文字列の右端から指定した文字数分の文字列を返す
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2017.10.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LS_Right(ByVal stTarget As String, ByVal iLength As Integer) As String

        If iLength <= stTarget.Length Then
            Return stTarget.Substring(stTarget.Length - iLength)
        End If

        Return stTarget

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：バックアップデータチェック処理
    ' 　機能概要：バックアップデータが選択されているかチェックを行う
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2017.10.01 クレスコ北陸 新規作成
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
    ' 2017.10.01 本部配信 クレスコ北陸 田代

    ' 2017.11.01 本部配信 クレスコ北陸 田代
    ' --------------------------------------------------------------------------------
    ' 　機　　能：数量・売上・単価データ取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.11.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetSalesDATA(ByRef pDataSet As DataSet, ByVal pmode As Integer, ByVal pTransDate As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetSalesDATA = False

        '------------------------------
        ' SQL組立
        '------------------------------
        strSQL = ""
        If pmode = 1 Then
            strSQL = strSQL & " SELECT TPM010.GOODSCD AS '商品番号 数量順',"
        ElseIf pmode = 2 Then
            strSQL = strSQL & " SELECT TPM010.GOODSCD AS '商品番号 売上順',"
        ElseIf pmode = 3 Then
            strSQL = strSQL & " SELECT TPM010.GOODSCD AS '商品番号 単価順',"
        End If
        strSQL = strSQL & "        MAX(LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ, '　', ' '))) + LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ2, '　', ' ')))) AS '商品名称',"
        strSQL = strSQL & "        TPM010.PRICE AS '単価',"
        strSQL = strSQL & "        ISNULL(SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END),0) AS '売上数量',"
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
        strSQL = strSQL & "        ISNULL((SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END) * MAX(TPM010.PRICE)),0) AS '売上金額'"
        strSQL = strSQL & "   FROM TPM010 LEFT JOIN TPD010 ON TPM010.GOODSCD = TPD010.GOODSCD"
        'strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999 AND TPM010.PRICE > 0 AND TPD010.ORDERTIME <> '99999999999999' AND TPD010.TRANSTIME <> '99999999999999'"
        strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999 AND TPD010.ORDERTIME <> '99999999999999' AND TPD010.TRANSTIME <> '99999999999999'"  ' 価格 0円対応
        strSQL = strSQL & "     AND TPD010.TRANSTIME >= '" & pTransDate & "090000'"
        strSQL = strSQL & "     AND TPD010.TRANSTIME <= '" & DateTime.Parse(pTransDate.Substring(0, 4) & "/" & pTransDate.Substring(4, 2) & "/" & pTransDate.Substring(6, 2)).AddDays(1).ToString("yyyyMMdd") & "085959'"
        strSQL = strSQL & " GROUP BY TPM010.GOODSCD,TPM010.PRICE"

        If pmode = 1 Then
            strSQL = strSQL & " ORDER BY 売上数量 DESC"
        ElseIf pmode = 2 Then
            strSQL = strSQL & " ORDER BY 売上金額 DESC"
        ElseIf pmode = 3 Then
            strSQL = strSQL & " ORDER BY 単価 DESC"
        End If



        '------------------------------
        ' データ取得
        '------------------------------
        If Not GF_GetData(strSQL, pDataSet) Then
            Call GF_Msg("", "DB接続に失敗しました", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            Exit Function
        End If

        If pDataSet.Tables("com").Rows.Count = 0 Then
            'Call GF_Msg("", "対象データがありません", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            LF_GetSalesDATA = True
            Exit Function
        End If

        LF_GetSalesDATA = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：原価率データ取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.11.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetCostDATA(ByRef pDataSet As DataSet, ByVal pTransDate As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetCostDATA = False

        '------------------------------
        ' SQL組立
        '------------------------------
        strSQL = ""
        strSQL = strSQL & " SELECT TPM010.GOODSCD AS '商品番号',"
        strSQL = strSQL & "        MAX(LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ, '　', ' '))) + LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ2, '　', ' ')))) AS '商品名称',"
        'strSQL = strSQL & "        CONVERT(varchar,ISNULL(((TPM340.COST / TPM010.PRICE) * 100),0)) AS '原価率',"
        strSQL = strSQL & "        CONVERT(varchar,CASE WHEN TPM010.PRICE=0 THEN '0' ELSE ISNULL(((TPM340.COST / TPM010.PRICE) * 100),0) END) AS '原価率'," ' 0円商品対応
        strSQL = strSQL & "        ISNULL(SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END),0) AS '売上数量',"
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
        strSQL = strSQL & "        ISNULL((SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END) * MAX(TPM010.PRICE)),0) AS '売上金額'"
        strSQL = strSQL & "   FROM TPM010 LEFT JOIN TPD010 ON TPM010.GOODSCD = TPD010.GOODSCD LEFT JOIN TPM340 ON TPD010.GOODSCD = TPM340.GOODSCD"
        'strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999 AND TPM010.PRICE > 0 AND TPD010.ORDERTIME <> '99999999999999' AND TPD010.TRANSTIME <> '99999999999999'"
        strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999  AND TPD010.ORDERTIME <> '99999999999999' AND TPD010.TRANSTIME <> '99999999999999'" ' 0円商品対応
        strSQL = strSQL & "     AND TPD010.TRANSTIME >= '" & pTransDate & "090000'"
        strSQL = strSQL & "     AND TPD010.TRANSTIME <= '" & DateTime.Parse(pTransDate.Substring(0, 4) & "/" & pTransDate.Substring(4, 2) & "/" & pTransDate.Substring(6, 2)).AddDays(1).ToString("yyyyMMdd") & "085959'"
        strSQL = strSQL & " GROUP BY TPM010.GOODSCD,TPM010.PRICE,TPM340.COST"
        strSQL = strSQL & " ORDER BY 原価率 DESC"

        '------------------------------
        ' データ取得
        '------------------------------
        If Not GF_GetData(strSQL, pDataSet) Then
            Call GF_Msg("", "DB接続に失敗しました", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            Exit Function
        End If

        If pDataSet.Tables("com").Rows.Count = 0 Then
            'Call GF_Msg("", "対象データがありません", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            LF_GetCostDATA = True
            Exit Function
        End If

        LF_GetCostDATA = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：粗利額データ取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.11.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetArariGakuDATA(ByRef pDataSet As DataSet, ByVal pTransDate As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetArariGakuDATA = False

        '------------------------------
        ' SQL組立
        '------------------------------
        strSQL = ""
        strSQL = strSQL & " SELECT TPM010.GOODSCD AS '商品番号',"
        strSQL = strSQL & "        MAX(LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ, '　', ' '))) + LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ2, '　', ' ')))) AS '商品名称',"
        strSQL = strSQL & "        ISNULL(((TPM010.PRICE - TPM340.COST) * ISNULL(SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END),0)),0) AS '粗利額',"
        strSQL = strSQL & "        ISNULL(SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END),0) AS '売上数量',"
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
        strSQL = strSQL & "        ISNULL((SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END) * MAX(TPM010.PRICE)),0) AS '売上金額'"
        strSQL = strSQL & "   FROM TPM010 LEFT JOIN TPD010 ON TPM010.GOODSCD = TPD010.GOODSCD LEFT JOIN TPM340 ON TPD010.GOODSCD = TPM340.GOODSCD"
        'strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999 AND TPM010.PRICE > 0 AND TPD010.ORDERTIME <> '99999999999999' AND TPD010.TRANSTIME <> '99999999999999'"
        strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999 AND TPD010.ORDERTIME <> '99999999999999' AND TPD010.TRANSTIME <> '99999999999999'" ' 0円商品対応
        strSQL = strSQL & "     AND TPD010.TRANSTIME >= '" & pTransDate & "090000'"
        strSQL = strSQL & "     AND TPD010.TRANSTIME <= '" & DateTime.Parse(pTransDate.Substring(0, 4) & "/" & pTransDate.Substring(4, 2) & "/" & pTransDate.Substring(6, 2)).AddDays(1).ToString("yyyyMMdd") & "085959'"
        strSQL = strSQL & " GROUP BY TPM010.GOODSCD,TPM010.PRICE,TPM340.COST"
        strSQL = strSQL & " ORDER BY 粗利額 DESC"

        '------------------------------
        ' データ取得
        '------------------------------
        If Not GF_GetData(strSQL, pDataSet) Then
            Call GF_Msg("", "DB接続に失敗しました", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            Exit Function
        End If

        If pDataSet.Tables("com").Rows.Count = 0 Then
            'Call GF_Msg("", "対象データがありません", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            LF_GetArariGakuDATA = True
            Exit Function
        End If

        LF_GetArariGakuDATA = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：粗利率データ取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.11.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetArariRituDATA(ByRef pDataSet As DataSet, ByVal pTransDate As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetArariRituDATA = False

        '------------------------------
        ' SQL組立
        '------------------------------
        strSQL = ""
        strSQL = strSQL & " SELECT TPM010.GOODSCD AS '商品番号',"
        strSQL = strSQL & "        MAX(LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ, '　', ' '))) + LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ2, '　', ' ')))) AS '商品名称',"
        'strSQL = strSQL & "        CONVERT(varchar,ISNULL(ROUND((((TPM010.PRICE - TPM340.COST) / TPM010.PRICE) * 100),3),0)) AS '粗利率',"
        strSQL = strSQL & "        CONVERT(varchar,CASE WHEN TPM010.PRICE=0 THEN '0' ELSE ISNULL(ROUND((((TPM010.PRICE - TPM340.COST) / TPM010.PRICE) * 100),3),0)END) AS '粗利率',"
        strSQL = strSQL & "        ISNULL(SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END),0) AS '売上数量',"
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
        strSQL = strSQL & "        ISNULL((SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END) * MAX(TPM010.PRICE)),0) AS '売上金額'"
        strSQL = strSQL & "   FROM TPM010 LEFT JOIN TPD010 ON TPM010.GOODSCD = TPD010.GOODSCD LEFT JOIN TPM340 ON TPD010.GOODSCD = TPM340.GOODSCD"
        'strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999 AND TPM010.PRICE > 0 AND TPD010.ORDERTIME <> '99999999999999' AND TPD010.TRANSTIME <> '99999999999999'"
        strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999 AND TPD010.ORDERTIME <> '99999999999999' AND TPD010.TRANSTIME <> '99999999999999'" ' 0円商品対応
        strSQL = strSQL & "     AND TPD010.TRANSTIME >= '" & pTransDate & "090000'"
        strSQL = strSQL & "     AND TPD010.TRANSTIME <= '" & DateTime.Parse(pTransDate.Substring(0, 4) & "/" & pTransDate.Substring(4, 2) & "/" & pTransDate.Substring(6, 2)).AddDays(1).ToString("yyyyMMdd") & "085959'"
        strSQL = strSQL & " GROUP BY TPM010.GOODSCD,TPM010.PRICE,TPM340.COST"
        strSQL = strSQL & " ORDER BY 粗利率 DESC"

        '------------------------------
        ' データ取得
        '------------------------------
        If Not GF_GetData(strSQL, pDataSet) Then
            Call GF_Msg("", "DB接続に失敗しました", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            Exit Function
        End If

        If pDataSet.Tables("com").Rows.Count = 0 Then
            'Call GF_Msg("", "対象データがありません", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            LF_GetArariRituDATA = True
            Exit Function
        End If

        LF_GetArariRituDATA = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：消込データ取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.11.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetRecords(ByRef pDataSet As DataSet, ByVal pTransDate As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetRecords = False

        '------------------------------
        ' SQL組立
        '------------------------------
        strSQL = ""
        strSQL = strSQL & " SELECT TPM050.SEATID AS '厨房端末',"
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
        strSQL = strSQL & "                      THEN TPD011.QUANTITY ELSE '0' END) AS '合計'"
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
        ' データ取得
        '------------------------------
        If Not GF_GetData(strSQL, pDataSet) Then
            Call GF_Msg("", "DB接続に失敗しました", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            Exit Function
        End If

        If pDataSet.Tables("com").Rows.Count = 0 Then
            'Call GF_Msg("", "対象データがありません", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            LF_GetRecords = True
            Exit Function
        End If

        LF_GetRecords = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：売上データ集計処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.11.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetSalesData2(ByRef pFilename As String, ByVal pTransDate As String, ByRef pFtp As Long) As Boolean

        '------------------------------
        ' 内部変数定義
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
            ' ファイル名設定
            '------------------------------
            strEncoding = System.Text.Encoding.GetEncoding("Shift_JIS")
            strStreamWriter = New System.IO.StreamWriter(strCsvPath, False, strEncoding)

            For i As Integer = 1 To 6
                objData.Clear()
                objData.Tables.Clear()
                objRows = Nothing

                '------------------------------
                ' 帳票データ取得処理
                '------------------------------
                Select Case i
                    Case 1 ' 数量順
                        If Not LF_GetSalesDATA(objData, i, pTransDate) Then
                            Exit Function
                        End If
                    Case 2 ' 売上順
                        If Not LF_GetSalesDATA(objData, i, pTransDate) Then
                            Exit Function
                        End If
                    Case 3 ' 単価順
                        If Not LF_GetSalesDATA(objData, i, pTransDate) Then
                            Exit Function
                        End If
                    Case 4 ' 原価率順
                        If Not LF_GetCostDATA(objData, pTransDate) Then
                            Exit Function
                        End If
                    Case 5 ' 粗利額順
                        If Not LF_GetArariGakuDATA(objData, pTransDate) Then
                            Exit Function
                        End If
                    Case 6 ' 粗利率順
                        If Not LF_GetArariRituDATA(objData, pTransDate) Then
                            Exit Function
                        End If
                End Select

                '------------------------------
                ' ファイル出力
                ' 該当データが無ければCSV出力しない
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
            '中身無しのファイルは削除する

            If pFtp = 0 Then
                System.IO.File.Delete(strCsvPath)
            End If

            ' 2018.07.20 エラーメッセージ非表示 
            MsgBox("ファイルの出力に失敗しました。(" & ex.Message & ")")

            Exit Function
        End Try

        strStreamWriter.Close()
        '中身無しのファイルは削除する
        If pFtp = 0 Then
            System.IO.File.Delete(strCsvPath)
        End If

        LF_GetSalesData2 = True

        Exit Function
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：売上データ集計処理(バックアップ)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2020.05.18 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetSalesDataBackup(ByRef pFilename As String, ByVal pTransDate As String, ByRef pFtp As Long) As Boolean

        '------------------------------
        ' 内部変数定義
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
            ' ファイル名設定
            '------------------------------
            strEncoding = System.Text.Encoding.GetEncoding("Shift_JIS")
            strStreamWriter = New System.IO.StreamWriter(strCsvPath, False, strEncoding)

            For i As Integer = 1 To 6
                objData.Clear()
                objData.Tables.Clear()
                objRows = Nothing

                '------------------------------
                ' 帳票データ取得処理
                '------------------------------
                Select Case i
                    Case 1 ' 数量順
                        If Not LF_GetSalesDATA(objData, i, pTransDate) Then
                            Exit Function
                        End If
                    Case 2 ' 売上順
                        If Not LF_GetSalesDATA(objData, i, pTransDate) Then
                            Exit Function
                        End If
                    Case 3 ' 単価順
                        If Not LF_GetSalesDATA(objData, i, pTransDate) Then
                            Exit Function
                        End If
                    Case 4 ' 原価率順
                        If Not LF_GetCostDATA(objData, pTransDate) Then
                            Exit Function
                        End If
                    Case 5 ' 粗利額順
                        If Not LF_GetArariGakuDATA(objData, pTransDate) Then
                            Exit Function
                        End If
                    Case 6 ' 粗利率順
                        If Not LF_GetArariRituDATA(objData, pTransDate) Then
                            Exit Function
                        End If
                End Select

                '------------------------------
                ' ファイル出力
                ' 該当データが無ければCSV出力しない
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
            '中身無しのファイルは削除する

            If pFtp = 0 Then
                System.IO.File.Delete(strCsvPath)
            End If

            ' 2018.07.20 エラーメッセージ非表示 
            MsgBox("ファイルの出力に失敗しました。(" & ex.Message & ")")

            Exit Function
        End Try

        strStreamWriter.Close()
        '中身無しのファイルは削除する
        If pFtp = 0 Then
            System.IO.File.Delete(strCsvPath)
        End If

        LF_GetSalesDataBackup = True

        Exit Function
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：消込データ集計処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.11.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetRecordsDATA(ByRef pFilename As String, ByVal pTransDate As String) As Boolean

        '------------------------------
        ' 内部変数定義
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
            ' ファイル名設定
            '------------------------------
            strEncoding = System.Text.Encoding.GetEncoding("Shift_JIS")
            strStreamWriter = New System.IO.StreamWriter(strCsvPath, False, strEncoding)

            objData.Clear()
            objData.Tables.Clear()
            objRows = Nothing

            '------------------------------
            ' 消込データ取得処理
            '------------------------------
            If Not LF_GetRecords(objData, pTransDate) Then
                Exit Function
            End If

            '------------------------------
            ' ファイル出力
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
            MsgBox("ファイルの出力に失敗しました")

            Exit Function
        End Try

        strStreamWriter.Close()

        LF_GetRecordsDATA = True

        Exit Function
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：消込データ集計処理(バックアップ用)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2020.05.19 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetRecordsDATABackup(ByRef pFilename As String, ByVal pTransDate As String) As Boolean

        '------------------------------
        ' 内部変数定義
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
            ' ファイル名設定
            '------------------------------
            strEncoding = System.Text.Encoding.GetEncoding("Shift_JIS")
            strStreamWriter = New System.IO.StreamWriter(strCsvPath, False, strEncoding)

            objData.Clear()
            objData.Tables.Clear()
            objRows = Nothing

            '------------------------------
            ' 消込データ取得処理
            '------------------------------
            If Not LF_GetRecords(objData, pTransDate) Then
                Exit Function
            End If

            '------------------------------
            ' ファイル出力
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
            MsgBox("ファイルの出力に失敗しました")

            Exit Function
        End Try

        strStreamWriter.Close()

        LF_GetRecordsDATABackup = True

        Exit Function
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：売上データ転送処理(FTP処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.11.01 クレスコ北陸 新規作成
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

            'FtpWebResponseを取得
            Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
            '閉じる
            ftpRes.Close()

            LF_TransSalesDataFTP = True

        Catch ex As Exception
            Call LS_WriteLogFTP(ex.Message)
        End Try

        Exit Function

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：売上データ転送処理(FTP処理 一ヶ月分)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2018.04.01 クレスコ北陸 新規作成
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

                'FtpWebResponseを取得
                Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
                '閉じる
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
    ' 　機　　能：売上データ転送処理(FTP処理 フォルダ内全て)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2020.05.18 クレスコ北陸 新規作成
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

                ' FtpWebResponseを取得
                Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
                ' 閉じる
                ftpRes.Close()
                ' FTP処理で転送したファイルを削除
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
    ' 　機　　能：消込データ転送処理(FTP処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.12.01 クレスコ北陸 新規作成
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

            'FtpWebResponseを取得
            Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
            '閉じる
            ftpRes.Close()

            LF_TransRecordsDataFTP = True

        Catch ex As Exception
            Call LS_WriteLogFTP(ex.Message)
        End Try

        Exit Function

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：消込データ転送処理(FTP処理 一ヶ月分)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2018.04.01 クレスコ北陸 新規作成
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

                'FtpWebResponseを取得
                Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
                '閉じる
                ftpRes.Close()

            Next

            LF_TransRecords = True

        Catch ex As Exception
            Call LS_WriteLogFTP(ex.Message)
        End Try

        Exit Function

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：消込データ転送処理(FTP処理　フォルダ内全て)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2020.05.19 クレスコ北陸 新規作成
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

                'FtpWebResponseを取得
                Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
                '閉じる
                ftpRes.Close()
                ' FTP処理で転送したファイルを削除
                My.Computer.FileSystem.DeleteFile(strFiles(i))

            Next

            LF_TransRecordsLoop = True

        Catch ex As Exception
            Call LS_WriteLogFTP(ex.Message)
        End Try

        Exit Function

    End Function
    ' 2017.11.01 本部配信 クレスコ北陸 田代

    ' 2017.12.01 本部配信 クレスコ北陸 田代
    ' --------------------------------------------------------------------------------
    ' 　機　　能：TPM010　選択削除処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.12.01 クレスコ北陸 新規作成
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
                Exit Function ' 抽出結果０件時は、何も行わない
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
    ' 　機　　能：delivaryflg取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.12.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LF_GetDeliDir(ByVal pdir As String, ByRef pstr As String)

        'ファイル一覧を取得するディレクトリのURI
        Dim u As New Uri("ftp://" & pdir)

        'FtpWebRequestの作成
        Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(u), System.Net.FtpWebRequest)
        'ログインユーザー名とパスワードを設定
        'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
        Dim strFTPId As String = "ftp"
        Dim strFTPPass As String = ""
        getFTPUserPass(strFTPId, strFTPPass)
        ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)

        'MethodにWebRequestMethods.Ftp.ListDirectoryDetails("LIST")を設定
        ftpReq.Method = System.Net.WebRequestMethods.Ftp.ListDirectoryDetails

        '要求の完了後に接続を閉じる
        ftpReq.KeepAlive = False

        ' 2019-11-06 -------------------------------------------------------------------------------
        If System.Configuration.ConfigurationManager.AppSettings("FTPUploadPassiveMode") = "0" Then
            'PASSIVEモードを無効にする
            ftpReq.UsePassive = False
        Else
            ftpReq.UsePassive = True
        End If
        ' ------------------------------------------------------------------------------------------
        'FtpWebResponseを取得
        Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)

        'FTPサーバーから送信されたデータを取得
        Dim sr As New System.IO.StreamReader(ftpRes.GetResponseStream())

        pstr = sr.ReadToEnd()

        sr.Close()

        '閉じる
        ftpRes.Close()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ファイル存在チェック処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.12.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_ChkExistFTP(ByVal pServerName As String, ByVal pTargetDirectory As String, ByVal pTargetFileName As String) As Boolean

        ' 2022-02-01 -----------------------------------------------------
        'Dim strFileNM As String = ""
        ' クレスコ環境の場合は38、クロス環境の場合は35 ※IPアドレスの長さ
        'Dim strDir As String = pDir.Substring(0, 35)
        'Dim strDir As String = pDir.Substring(0, 38)
        ' ----------------------------------------------------------------
        Dim aryFile() As String

        Dim strFTPId As String = "ftp"
        Dim strFTPPass As String = ""
        getFTPUserPass(strFTPId, strFTPPass)
        Try

            'strFileNM = LS_Right(pDir, 38)

            'ファイル一覧を取得するディレクトリのURI
            'Dim u As New Uri("ftp://" & strDir)
            Dim u As New Uri("ftp://" & pServerName & pTargetDirectory & "/")

            'FtpWebRequestの作成
            Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(u), System.Net.FtpWebRequest)
            'ログインユーザー名とパスワードを設定
            'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
            ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)

            'MethodにWebRequestMethods.Ftp.ListDirectoryDetails("LIST")を設定
            ftpReq.Method = System.Net.WebRequestMethods.Ftp.ListDirectory

            '要求の完了後に接続を閉じる
            ftpReq.KeepAlive = False

            ' 2019-11-06 -------------------------------------------------------------------------------
            If System.Configuration.ConfigurationManager.AppSettings("FTPUploadPassiveMode") = "0" Then
                'PASSIVEモードを無効にする
                ftpReq.UsePassive = False
            Else
                ftpReq.UsePassive = True
            End If
            ' ------------------------------------------------------------------------------------------
            'FtpWebResponseを取得
            Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)

            'FTPサーバーから送信されたデータを取得
            Dim sr As New System.IO.StreamReader(ftpRes.GetResponseStream())

            Dim strDirNM As String = sr.ReadToEnd

            aryFile = Split(strDirNM, vbCrLf)

            For i As Integer = 0 To aryFile.Count - 2

                'If aryFile(i) = strFileNM Then
                If aryFile(i) = pTargetFileName Then

                    sr.Close()

                    '閉じる
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
    ' 　機　　能：フラグファイル書き換え処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.12.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    'Private Function LF_Writeflg(ByVal pDir As String, ByVal pToFileNM As String) As Boolean
    Private Function LF_Writeflg(ByVal pServerName As String, ByVal pTargetDirectory As String, ByVal pFromFileNM As String, ByVal pToFileNM As String) As Boolean

        Try

            '名前を変更するファイルのURI
            'Dim u As New Uri("ftp://" & pDir)
            Dim u As New Uri("ftp://" & pServerName & pTargetDirectory & "/" & pFromFileNM)
            '新しいファイル名
            'Dim newName As String = pToFileNM

            'FtpWebRequestの作成
            Dim ftpReq As System.Net.FtpWebRequest = _
                CType(System.Net.WebRequest.Create(u), System.Net.FtpWebRequest)
            'ログインユーザー名とパスワードを設定
            'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
            Dim strFTPId As String = "ftp"
            Dim strFTPPass As String = ""
            getFTPUserPass(strFTPId, strFTPPass)
            ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)
            'MethodにWebRequestMethods.Ftp.Rename(RENAME)を設定
            ftpReq.Method = System.Net.WebRequestMethods.Ftp.Rename

            '変更後の新しいファイル名を設定
            'ftpReq.RenameTo = newName
            ftpReq.RenameTo = pToFileNM

            'FtpWebResponseを取得
            Dim ftpRes As System.Net.FtpWebResponse = CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)

            'FTPサーバーから送信されたステータスを表示
            Console.WriteLine("{0}: {1}", ftpRes.StatusCode, ftpRes.StatusDescription)
            '閉じる
            ftpRes.Close()

            LF_Writeflg = True

        Catch ex As Exception
            Exit Function
        End Try

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：本部SVフォルダ削除処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.12.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_DeleteFolderSV(ByVal pdir As String) As Boolean

        Try

            pdir = pdir.Replace(Environment.NewLine, "")

            '削除するファイルのURI
            Dim u As New Uri("ftp://" & pdir)

            'FtpWebRequestの作成
            Dim ftpReq As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(u), System.Net.FtpWebRequest)
            'ログインユーザー名とパスワードを設定
            'ftpReq.Credentials = New System.Net.NetworkCredential("ftp", "")
            Dim strFTPId As String = "ftp"
            Dim strFTPPass As String = ""
            getFTPUserPass(strFTPId, strFTPPass)
            ftpReq.Credentials = New System.Net.NetworkCredential(strFTPId, strFTPPass)
            'MethodにWebRequestMethods.Ftp.DeleteFile(DELE)を設定
            ftpReq.Method = System.Net.WebRequestMethods.Ftp.RemoveDirectory

            LF_DeleteFolderSV = True
        Catch
            Exit Function
        End Try

    End Function
    ' 2017.12.01 本部配信 クレスコ北陸 田代

    '------------------------------
    ' 2015.9.29 OA) TECデータ取込
    '------------------------------
    Private Sub btn_ImportTECData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImportTECData.Click
        Call ImportTECData(Me.MdiParent)
    End Sub

    ' 2017.01.01 がってん寿司向け クレスコ北陸 田代
    ' --------------------------------------------------------------------------------
    ' 　機　　能：使用パターン更新処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.01.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btnDec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDec.Click

        Dim strSQL As String = Nothing
        Dim UpdPtn As String = Nothing

        Try

            UpdPtn = cmbPtn.Text

            Select Case UpdPtn

                Case "パターン１"
                    UpdPtn = "1"
                Case "パターン２"
                    UpdPtn = "2"
                Case "パターン３"
                    UpdPtn = "3"
                Case "パターン４"
                    UpdPtn = "4"

            End Select

            strSQL = ""
            strSQL = strSQL & " UPDATE TPM092"
            strSQL = strSQL & " SET APVALUE = '" & UpdPtn & "'"
            strSQL = strSQL & " WHERE APKEY = 'KCP_PTN'"

            If Not GF_UpdData(strSQL) Then
                GoTo SYSTEM_ERROR
            End If

            Call MsgBox("更新完了しました。", MsgBoxStyle.OkOnly, "CrossNavi")

        Catch
            GoTo SYSTEM_ERROR
        End Try

        '20180727 CNL1301リスタートバッチ起動追加
        If GF_GetAppInfo3("KCP_PTN_CNL1301_FLG") = 1 Then
            Process.Start("C:\CrossNavi\tool\CNL1301restart.bat")
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btnDec_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：出力先パターン更新処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.01.01 クレスコ北陸 新規作成
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

            Call MsgBox("更新完了しました。", MsgBoxStyle.OkOnly, "CrossNavi")

        Catch
            GoTo SYSTEM_ERROR
        End Try

        
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btnSave_Click")
    End Sub
    ' 2017.01.01 がってん寿司向け クレスコ北陸 田代

    ' 2017.10.01 本部配信 クレスコ北陸 田代
    ' --------------------------------------------------------------------------------
    ' 　機　　能：配信メニュー取込処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.01.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Deli_Import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deli_Import.Click

        targetPrgBar = prg_Bar_Deli
        targetPrgLabel = ProgressLabelDeli
        Dim result As DialogResult = MessageBox.Show("本部メニューデータ取込を開始しますか？", "CrossNavi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Dim strDeliDate As String = ""

        ' プログレスバー最小値
        targetPrgBar.Minimum = 0
        ' プログレスバー最大値
        targetPrgBar.Maximum = 1000
        ' プログレスバー初期値
        targetPrgBar.Value = targetPrgBar.Minimum
        targetPrgLabel.Text = "始め"

        ' メニュー取込処理
        Try
            ' カーソル　通常→待機
            Me.Cursor = Cursors.WaitCursor

            'フォームコントロールのロック
            Call LS_UseControl(False)

            If result = Windows.Forms.DialogResult.Yes Then
                ' 本部SV側のフォルダ存在チェック
                If Not LF_ChkFolder(strDeliDate) Then
                    Call MsgBox("メニューが配信されていません。メニュー取込処理を終了します。", MsgBoxStyle.OkOnly, "CrossNavi")

                    ' 待機→通常
                    Me.Cursor = Cursors.Default

                    ' 初期値に戻す
                    targetPrgBar.Value = 0
                    targetPrgLabel.Text = ""

                    'フォームコントロールのロック解除
                    Call LS_UseControl(True)

                    Exit Sub
                Else
                    ' 5%
                    targetPrgBar.Value = 50
                    targetPrgLabel.Text = "メニューバックアップ始め"""
                    ' 既存メニューバックアップ
                    If Not LF_MenuBackUp() Then
                        Call MsgBox("既存メニューバックアップ処理に失敗しました。メニュー取込処理を終了します。", MsgBoxStyle.OkOnly, "CrossNavi")

                        ' 待機→通常
                        Me.Cursor = Cursors.Default

                        ' 初期値に戻す
                        targetPrgBar.Value = 0
                        targetPrgLabel.Text = ""

                        'フォームコントロールのロック解除
                        Call LS_UseControl(True)

                        Exit Sub
                    Else
                        ' 10%
                        targetPrgBar.Value = 100
                        targetPrgLabel.Text = "配信メニュー取込始め"
                        ' 配信メニュー取込
                        If Not LS_Deli_Import(strDeliDate) Then
                            Call MsgBox("配信メニュー取込処理に失敗しました。メニュー取込処理を終了します。", MsgBoxStyle.OkOnly, "CrossNavi")

                            ' 待機→通常
                            Me.Cursor = Cursors.Default

                            ' 初期値に戻す
                            targetPrgBar.Value = 0
                            targetPrgLabel.Text = ""

                            'フォームコントロールのロック解除
                            Call LS_UseControl(True)

                            Exit Sub
                        Else
                            ' 100%
                            targetPrgBar.Value = 1000
                            targetPrgLabel.Text = ""
                            Call MsgBox("本部メニューデータ取込処理が完了しました。", MsgBoxStyle.OkOnly, "CrossNavi")
                        End If
                    End If
                End If
            End If

            ' 待機→通常
            Me.Cursor = Cursors.Default
        Catch
            GoTo SYSTEM_ERROR
        End Try
        ' 初期値に戻す
        targetPrgBar.Value = 0

        'フォームコントロールのロック解除
        Call LS_UseControl(True)

        Exit Sub

SYSTEM_ERROR:
        'フォームコントロールのロック解除
        Call LS_UseControl(True)

        Call GS_ErrorTerm("btn_Deli_Import_Click")
        ' 初期値に戻す
        targetPrgBar.Value = 0
        ' カーソル　待機→通常
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_OMOTENASHI_Import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OMOTENASHI_Import.Click

        targetPrgBar = prg_Bar_OMOTENASHI
        targetPrgLabel = ProgressLabelOMOTENASHI
        Dim result As DialogResult = MessageBox.Show("OMOTENASHIデータ取込を開始しますか？", "CrossNavi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Dim strTargetDir As String = ""

        ' プログレスバー最小値
        targetPrgBar.Minimum = 0
        ' プログレスバー最大値
        targetPrgBar.Maximum = 1000
        ' プログレスバー初期値
        targetPrgBar.Value = targetPrgBar.Minimum
        targetPrgLabel.Text = "始め"

        ' メニュー取込処理
        Try
            ' カーソル　通常→待機
            Me.Cursor = Cursors.WaitCursor

            'フォームコントロールのロック
            Call LS_UseControl(False)

            If result = Windows.Forms.DialogResult.Yes Then
                ' 本部SV側のフォルダ存在チェック
                If Not LF_ChkOMOTENASHIFolder(strTargetDir) Then
                    Call MsgBox("メニューが配信されていません。メニュー取込処理を終了します。", MsgBoxStyle.OkOnly, "CrossNavi")

                    ' 待機→通常
                    Me.Cursor = Cursors.Default

                    ' 初期値に戻す
                    targetPrgBar.Value = 0
                    targetPrgLabel.Text = ""

                    'フォームコントロールのロック解除
                    Call LS_UseControl(True)

                    Exit Sub
                Else
                    ' 5%
                    targetPrgBar.Value = 50
                    'ProgressLabel.Text = "メニューバックアップ始め"""
                    ' 既存メニューバックアップ
                    'If Not LF_MenuBackUp() Then
                    '    Call MsgBox("既存メニューバックアップ処理に失敗しました。メニュー取込処理を終了します。", MsgBoxStyle.OkOnly, "CrossNavi")
                    '    ' 待機→通常
                    '    Me.Cursor = Cursors.Default
                    '    ' 初期値に戻す
                    '    prg_Bar.Value = 0
                    '    'フォームコントロールのロック解除
                    '    Call LS_UseControl(True)
                    '    Exit Sub
                    'Else
                    ' 10%
                    targetPrgBar.Value = 100
                    targetPrgLabel.Text = "配信メニュー取込始め"
                    ' 配信メニュー取込
                    If Not LS_OMOTENASHI_Import(strTargetDir) Then
                        Call MsgBox("配信メニュー取込処理に失敗しました。メニュー取込処理を終了します。", MsgBoxStyle.OkOnly, "CrossNavi")

                        ' 待機→通常
                        Me.Cursor = Cursors.Default

                        ' 初期値に戻す
                        targetPrgBar.Value = 0
                        targetPrgLabel.Text = ""

                        'フォームコントロールのロック解除
                        Call LS_UseControl(True)

                        Exit Sub
                    Else
                        ' 100%
                        targetPrgBar.Value = 1000
                        targetPrgLabel.Text = ""
                        Call MsgBox("本部メニューデータ取込処理が完了しました。", MsgBoxStyle.OkOnly, "CrossNavi")
                    End If
                    'End If
                End If
                End If

            ' 待機→通常
            Me.Cursor = Cursors.Default
        Catch
            GoTo SYSTEM_ERROR
        End Try
        ' 初期値に戻す
        targetPrgBar.Value = 0

        'フォームコントロールのロック解除
        Call LS_UseControl(True)

        Exit Sub

SYSTEM_ERROR:
        'フォームコントロールのロック解除
        Call LS_UseControl(True)

        Call GS_ErrorTerm("btn_OMOTENASHI_Import_Click")
        ' 初期値に戻す
        targetPrgBar.Value = 0
        ' カーソル　待機→通常
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_Reference_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reference.Click

        ' FolderBrowserDialog の新しいインスタンスを生成する (デザイナから追加している場合は必要ない)
        Dim FolderBrowserDialog1 As New FolderBrowserDialog()

        ' ダイアログの説明を設定する
        FolderBrowserDialog1.Description = "取込を行うバックアップフォルダを選択してください。"

        ' ルートになる特殊フォルダを設定する (初期値 SpecialFolder.Desktop)
        FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer

        ' 初期選択するパスを設定する
        FolderBrowserDialog1.SelectedPath = "C:\CrossNavi\backup\"

        ' [新しいフォルダ] ボタンを表示する (初期値 True)
        FolderBrowserDialog1.ShowNewFolderButton = False

        ' ダイアログを表示し、戻り値が [OK] の場合は、選択したディレクトリを表示する
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            lbl_Path.Text = FolderBrowserDialog1.SelectedPath
        End If

        ' 不要になった時点で破棄する (正しくは オブジェクトの破棄を保証する を参照)
        FolderBrowserDialog1.Dispose()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：バックアップメニュー取込処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2018.04.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_BackupImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BackupImport.Click

        Dim result As DialogResult = MessageBox.Show("バックアップメニューデータ取込を開始しますか？", "CrossNavi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

        Try
            If result = Windows.Forms.DialogResult.Yes Then
                ' 通常→待機
                Me.Cursor = Cursors.WaitCursor

                If Not LS_chkPath() Then
                    Call MsgBox("取り込むバックアップデータが選択されていません。", MsgBoxStyle.OkOnly, "CrossNavi")
                    ' 待機→通常
                    Me.Cursor = Cursors.Default
                    Exit Sub
                Else
                    If Not LS_Backup_Import() Then
                        Call MsgBox("バックアップデータ取込に失敗しました。", MsgBoxStyle.OkOnly, "CrossNavi")
                        ' 待機→通常
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If
                End If

                Call MsgBox("バックアップデータ取込が完了しました。", MsgBoxStyle.OkOnly, "CrossNavi")

                ' 待機→通常
                Me.Cursor = Cursors.Default

            End If

        Catch ex As Exception
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_BackupImport_Click")
        ' 待機→通常
        Me.Cursor = Cursors.Default
    End Sub
    ' 2017.10.01 本部配信 クレスコ北陸 田代

    ' 2017.11.01 本部配信 クレスコ北陸 田代
    ' --------------------------------------------------------------------------------
    ' 　機　　能：集計データアップロード処理(手動)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2018.04.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btnSalesUplode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalesUplode.Click

        Dim strSalesFileNM As String = ""
        Dim strRecordsFileNM As String = ""

        Try

            ' 1ヶ月前の売上データ削除
            ' 売上データ保持する仕様に変更するため、コメントアウト
            'Call LS_DeleteSalesFiles()

            ' 売上データ転送処理
            If Not LF_TransSalesLoop() Then
                GoTo SYSTEM_ERROR
                Exit Sub
            End If

            ' 1ヶ月前の消込データ削除
            ' 消込データ保持する仕様に変更するため、コメントアウト
            'Call LS_DeleteRecordsFiles()

            ' 消込データ転送処理
            If Not LF_TransRecordsLoop() Then
                GoTo SYSTEM_ERROR
                Exit Sub
            End If

            Call MsgBox("集計データアップロード完了致しました。", MsgBoxStyle.OkOnly, "CrossNavi")

        Catch
            GoTo SYSTEM_ERROR
            Exit Sub
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btnSalesUplode_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：集計データアップロード処理(自動)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2018.04.01 クレスコ北陸 新規作成
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
            ' 1ヶ月前の売上データ削除
            ' 売上データ保持する仕様に変更するため、コメントアウト
            'Call LS_DeleteSalesFiles()

            ' 1ヶ月前の消込データ削除
            ' 消込データ保持する仕様に変更するため、コメントアウト
            'Call LS_DeleteRecordsFiles()

            '日にちを取得
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
                Exit Sub ' 抽出結果０件時は、何も行わない
            End If

            '日にち(9:00～翌8:59)毎に日別データを出力して本部サーバにアップロードする
            While intCnt < CLng(objData.Tables("com").Rows.Count)
                lngSalesDataFTP = 0
                lngSalesDataFTPBackup = 0

                If Not GF_GetRows(objData, intCnt, objRows) Then
                    Exit Sub
                End If

                ' 売上データ集計処理
                If Not LF_GetSalesData2(strSalesFileNM, Trim$(objRows("TRANSDATE")), lngSalesDataFTP) Then
                    Exit Sub
                End If

                ' 売上データ集計処理(バックアップ用)
                If Not LF_GetSalesDataBackup(strSalesFileNMBackup, Trim$(objRows("TRANSDATE")), lngSalesDataFTPBackup) Then
                    Exit Sub
                End If

                ' 消込データ集計処理
                If LF_GetRecordsDATA(strRecordsFileNM, Trim$(objRows("TRANSDATE"))) Then
                    ' 消込データ集計処理(バックアップ用)
                    If LF_GetRecordsDATABackup(strRecordsFileNMBackup, Trim$(objRows("TRANSDATE"))) Then
                        lngRecordsFTPBackup = 1
                    End If
                End If

                intCnt += 1
            End While

            ' 売上データ転送処理(csvファイルが作成された場合のみ)
            If lngSalesDataFTP = 1 Then
                If Not LF_TransSalesLoop() Then
                    Exit Sub
                End If
            End If

            ' 消込データ転送処理(csvファイルが作成された場合のみ)
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
    ' 　機　　能：集計データ削除処理(自動)
    ' 　機能概要：１ヶ月前の売上データが存在する場合削除する。
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2018.04.01 クレスコ北陸 新規作成
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
            '作成日を比較して32日以上前に作成されたものなら削除
            If DateDiff("d", files_createdate, Now) > 31 Then
                System.IO.File.Delete(files(i))
            End If
        Next

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：消込データ削除処理(自動)
    ' 　機能概要：１ヶ月前の消込データが存在する場合削除する。
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2018.04.01 クレスコ北陸 新規作成
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
            '作成日を比較して32日以上前に作成されたものなら削除
            If DateDiff("d", files_createdate, Now) > 31 Then
                System.IO.File.Delete(files(i))
            End If
        Next

    End Sub
    ' 2017.11.01 本部配信 クレスコ北陸 田代

    ' 2018.05.23 本部配信　クレスコ北陸
    ''' <summary>
    ''' フォーム制御
    ''' 本部メニューデータ取込時のコントロールの活性非活性を制御する
    ''' </summary>
    ''' <param name="bln"></param>
    ''' <remarks></remarks>
    Private Sub LS_UseControl(ByVal bln As Boolean)

        If bln Then
            'Trueの場合（フォームコントロールのロック解除）
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
            'Falseの場合（フォームコントロールのロック）
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
    ' 　機　　能：ログ出力
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2018.10.01 クレスコ北陸 新規作成
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
    ' 2018.05.23 本部配信　クレスコ北陸

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品画像フォルダ内 未使用画像ファイル削除処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2021.08.05 ゲルト
    ' --------------------------------------------------------------------------------
    Private Function LF_DelUnuseFile() As Boolean

        '------------------------------
        ' 内部変数定義
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
        ' 初期値設定
        '------------------------------
        LF_DelUnuseFile = False

        '------------------------------
        ' 使用中画像ファイル一覧取得(メニューグループ)
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM061.FILENM AS IMAGEPATH"
        strSQL = strSQL & "  FROM TPM061"
        strSQL = strSQL & " WHERE LEN(LTrim(TPM061.FILENM)) <> 0"
        '多言語機能対応
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
        ' 画像ファイル使用中判定
        '------------------------------
        If objData.Tables("com").Rows.Count <> 0 Then
            strItemPath = GF_GetAppInfo("MENUIMG_V")
            For Each strFile In System.IO.Directory.GetFiles(strItemPath)
                objFileInfo = New System.IO.FileInfo(strFile)
                blnFound = False
                targetPrgLabel.Text = "画像使用中判定：" + objFileInfo.Name
                '------------------------------
                ' メニュー画像もGroupImageに格納。ファイル名の頭文字が"M"はメニュー画像のため、削除しない
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
                    ' 未使用ファイルであれば削除
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
        ' 使用中画像ファイル一覧取得(グループ)
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM020.GROUPIMAGE AS IMAGEPATH "
        strSQL = strSQL & "  FROM TPM020"
        strSQL = strSQL & " WHERE TPM020.GOODSCD = '0000'"
        strSQL = strSQL & "   AND LEN(LTRIM(TPM020.GROUPIMAGE)) <> 0"
        strSQL = strSQL & " GROUP BY TPM020.GROUPCD,"
        strSQL = strSQL & "          TPM020.GROUPIMAGE"
        '多言語機能対応
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
        ' 画像ファイル使用中判定
        '------------------------------
        If objData.Tables("com").Rows.Count <> 0 Then
            strItemPath = GF_GetAppInfo("GROUP_PATH")
            For Each strFile In System.IO.Directory.GetFiles(strItemPath)
                objFileInfo = New System.IO.FileInfo(strFile)
                blnFound = False
                '------------------------------
                ' メニュー画像もGroupImageに格納。ファイル名の頭文字が"M"はメニュー画像のため、削除しない
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
                    ' 未使用ファイルであれば削除
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
        ' 返却値設定
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
