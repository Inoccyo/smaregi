Public Class CNL1580
    Inherits System.Windows.Forms.Form

#Region " Windows フォーム デザイナで生成されたコード "

    Public Sub New()
        MyBase.New()

        ' この呼び出しは Windows フォーム デザイナで必要です。
        InitializeComponent()

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
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tlb_Btn As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList3 As System.Windows.Forms.ImageList
    Friend WithEvents trv_Menu As System.Windows.Forms.TreeView
    Friend WithEvents ImageList4 As System.Windows.Forms.ImageList
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lsv_MenuGrp As System.Windows.Forms.ListView
    Friend WithEvents ImageList5 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_MenuPic As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chk_Price As System.Windows.Forms.CheckBox
    Friend WithEvents chk_ShowGenr As System.Windows.Forms.CheckBox
    Friend WithEvents cbo_Style As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_Pat As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_MenuTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lsv_ItemGrp As System.Windows.Forms.ListView
    Friend WithEvents lst_MenuGrp As System.Windows.Forms.ListBox
    Friend WithEvents lst_TreeKey As System.Windows.Forms.ListBox
    Friend WithEvents txt_Time As System.Windows.Forms.TextBox
    Friend WithEvents chk_Sub2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Sub1 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Sub2Price As System.Windows.Forms.TextBox
    Friend WithEvents txt_Sub2NM As System.Windows.Forms.TextBox
    Friend WithEvents txt_Sub1Price As System.Windows.Forms.TextBox
    Friend WithEvents txt_Sub1NM As System.Windows.Forms.TextBox
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_Bumon As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lsv_ItemList As System.Windows.Forms.ListView
    Friend WithEvents cbo_Sort As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lsv_Menu As System.Windows.Forms.ListView
    Friend WithEvents grd_ItemList As System.Windows.Forms.DataGrid
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents txt_Sub1CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_Sub2CD As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_TPGoodsNM As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btn_KPSet As System.Windows.Forms.Button
    Friend WithEvents txt_Price As System.Windows.Forms.TextBox
    Friend WithEvents lbl_KCP1 As System.Windows.Forms.Label
    Friend WithEvents lbl_KCP3 As System.Windows.Forms.Label
    Friend WithEvents lbl_KCP2 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lbl_ItemNMJ As System.Windows.Forms.Label
    Friend WithEvents lbl_ItemCode As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cmb_Bumon As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents grd_Course As System.Windows.Forms.DataGrid
    Friend WithEvents txt_GoodsNMJ4 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txt_HTLNM2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_HTLNM1 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_TPGoodsNM2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_SelRow As System.Windows.Forms.TextBox
    Friend WithEvents cmb_DispMenu As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_DrinkMenu As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Corse As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CNL1580))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "にぎり", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "ドリンク", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "おすすめ", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "ジャンルＡ", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "ジャンルＢ", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "ジャンルＣ", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "一二〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "一六〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "二〇〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "二四〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "二八〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "三二〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "四〇〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "四八〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "五六〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "一二〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "一六〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "二〇〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "二四〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "二八〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "三二〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem22 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "四〇〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem23 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "四八〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem24 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "五六〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_Corse = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_SelRow = New System.Windows.Forms.TextBox()
        Me.txt_TPGoodsNM2 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmb_DispMenu = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmb_DrinkMenu = New System.Windows.Forms.ComboBox()
        Me.txt_TPGoodsNM = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btn_KPSet = New System.Windows.Forms.Button()
        Me.txt_Price = New System.Windows.Forms.TextBox()
        Me.lbl_KCP1 = New System.Windows.Forms.Label()
        Me.lbl_KCP3 = New System.Windows.Forms.Label()
        Me.lbl_KCP2 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lbl_ItemNMJ = New System.Windows.Forms.Label()
        Me.lbl_ItemCode = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cmb_Bumon = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_GoodsNMJ4 = New System.Windows.Forms.TextBox()
        Me.txt_HTLNM2 = New System.Windows.Forms.TextBox()
        Me.txt_HTLNM1 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.grd_Course = New System.Windows.Forms.DataGrid()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lsv_ItemGrp = New System.Windows.Forms.ListView()
        Me.ImageList5 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_Sub2CD = New System.Windows.Forms.TextBox()
        Me.txt_Sub1CD = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Time = New System.Windows.Forms.TextBox()
        Me.chk_Sub2 = New System.Windows.Forms.CheckBox()
        Me.chk_Sub1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Sub2Price = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Sub2NM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Sub1Price = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Sub1NM = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_MenuPic = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chk_Price = New System.Windows.Forms.CheckBox()
        Me.chk_ShowGenr = New System.Windows.Forms.CheckBox()
        Me.cbo_Style = New System.Windows.Forms.ComboBox()
        Me.cbo_Pat = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_MenuTitle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lsv_MenuGrp = New System.Windows.Forms.ListView()
        Me.trv_Menu = New System.Windows.Forms.TreeView()
        Me.ImageList4 = New System.Windows.Forms.ImageList(Me.components)
        Me.tlb_Btn = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton()
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.lst_TreeKey = New System.Windows.Forms.ListBox()
        Me.lst_MenuGrp = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grd_ItemList = New System.Windows.Forms.DataGrid()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.cbo_Bumon = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lsv_ItemList = New System.Windows.Forms.ListView()
        Me.cbo_Sort = New System.Windows.Forms.ComboBox()
        Me.lsv_Menu = New System.Windows.Forms.ListView()
        Me.stb_Msg = New System.Windows.Forms.StatusBar()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grd_Course, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.grd_ItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'TabControl1
        '
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabPage3, Me.TabPage1, Me.TabPage2})
        Me.TabControl1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(992, 600)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.AddRange(New System.Windows.Forms.Control() {Me.btn_Corse, Me.GroupBox3, Me.grd_Course})
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(984, 568)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "コースメニュー登録"
        '
        'btn_Corse
        '
        Me.btn_Corse.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Corse.Location = New System.Drawing.Point(24, 24)
        Me.btn_Corse.Name = "btn_Corse"
        Me.btn_Corse.Size = New System.Drawing.Size(240, 48)
        Me.btn_Corse.TabIndex = 1
        Me.btn_Corse.Text = "新しいコースメニューを作成する"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.txt_SelRow, Me.txt_TPGoodsNM2, Me.Label25, Me.Label22, Me.cmb_DispMenu, Me.Label21, Me.Label20, Me.cmb_DrinkMenu, Me.txt_TPGoodsNM, Me.Label31, Me.Label30, Me.btn_KPSet, Me.txt_Price, Me.lbl_KCP1, Me.lbl_KCP3, Me.lbl_KCP2, Me.Label36, Me.lbl_ItemNMJ, Me.lbl_ItemCode, Me.Label34, Me.cmb_Bumon, Me.Label19, Me.Label37, Me.Label32, Me.txt_GoodsNMJ4, Me.txt_HTLNM2, Me.txt_HTLNM1, Me.Label23, Me.Label24})
        Me.GroupBox3.Location = New System.Drawing.Point(620, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(344, 496)
        Me.GroupBox3.TabIndex = 273
        Me.GroupBox3.TabStop = False
        '
        'txt_SelRow
        '
        Me.txt_SelRow.Location = New System.Drawing.Point(280, 464)
        Me.txt_SelRow.Name = "txt_SelRow"
        Me.txt_SelRow.Size = New System.Drawing.Size(48, 26)
        Me.txt_SelRow.TabIndex = 281
        Me.txt_SelRow.Text = "TextBox1"
        '
        'txt_TPGoodsNM2
        '
        Me.txt_TPGoodsNM2.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_TPGoodsNM2.Location = New System.Drawing.Point(8, 256)
        Me.txt_TPGoodsNM2.Name = "txt_TPGoodsNM2"
        Me.txt_TPGoodsNM2.Size = New System.Drawing.Size(328, 22)
        Me.txt_TPGoodsNM2.TabIndex = 7
        Me.txt_TPGoodsNM2.Text = "鍋コース"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label25.Location = New System.Drawing.Point(10, 288)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(325, 1)
        Me.Label25.TabIndex = 279
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(8, 296)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(328, 24)
        Me.Label22.TabIndex = 272
        Me.Label22.Text = "タッチパネル表示メニュー"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_DispMenu
        '
        Me.cmb_DispMenu.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb_DispMenu.Location = New System.Drawing.Point(8, 320)
        Me.cmb_DispMenu.Name = "cmb_DispMenu"
        Me.cmb_DispMenu.Size = New System.Drawing.Size(328, 23)
        Me.cmb_DispMenu.TabIndex = 8
        Me.cmb_DispMenu.Text = "メインメニュー"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label21.Location = New System.Drawing.Point(8, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(325, 1)
        Me.Label21.TabIndex = 270
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(8, 352)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(328, 24)
        Me.Label20.TabIndex = 268
        Me.Label20.Text = "セット飲み放題メニュー"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_DrinkMenu
        '
        Me.cmb_DrinkMenu.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb_DrinkMenu.Location = New System.Drawing.Point(8, 376)
        Me.cmb_DrinkMenu.Name = "cmb_DrinkMenu"
        Me.cmb_DrinkMenu.Size = New System.Drawing.Size(328, 23)
        Me.cmb_DrinkMenu.TabIndex = 9
        Me.cmb_DrinkMenu.Text = "飲み放題Ａコース"
        '
        'txt_TPGoodsNM
        '
        Me.txt_TPGoodsNM.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_TPGoodsNM.Location = New System.Drawing.Point(8, 232)
        Me.txt_TPGoodsNM.Name = "txt_TPGoodsNM"
        Me.txt_TPGoodsNM.Size = New System.Drawing.Size(328, 22)
        Me.txt_TPGoodsNM.TabIndex = 6
        Me.txt_TPGoodsNM.Text = "鍋コース"
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label31.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label31.Location = New System.Drawing.Point(8, 208)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(328, 24)
        Me.Label31.TabIndex = 161
        Me.Label31.Text = "コースメニュー名"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label30.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label30.Location = New System.Drawing.Point(128, 152)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(208, 24)
        Me.Label30.TabIndex = 164
        Me.Label30.Text = "出力ＫＣＰ番号"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_KPSet
        '
        Me.btn_KPSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_KPSet.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_KPSet.Location = New System.Drawing.Point(272, 176)
        Me.btn_KPSet.Name = "btn_KPSet"
        Me.btn_KPSet.Size = New System.Drawing.Size(64, 24)
        Me.btn_KPSet.TabIndex = 5
        Me.btn_KPSet.Text = "設定"
        '
        'txt_Price
        '
        Me.txt_Price.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Price.Location = New System.Drawing.Point(8, 176)
        Me.txt_Price.Name = "txt_Price"
        Me.txt_Price.Size = New System.Drawing.Size(120, 22)
        Me.txt_Price.TabIndex = 4
        Me.txt_Price.Text = "3,000円"
        Me.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_KCP1
        '
        Me.lbl_KCP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_KCP1.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_KCP1.Location = New System.Drawing.Point(128, 176)
        Me.lbl_KCP1.Name = "lbl_KCP1"
        Me.lbl_KCP1.Size = New System.Drawing.Size(48, 24)
        Me.lbl_KCP1.TabIndex = 165
        Me.lbl_KCP1.Text = "1"
        Me.lbl_KCP1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lbl_KCP3
        '
        Me.lbl_KCP3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_KCP3.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_KCP3.Location = New System.Drawing.Point(224, 176)
        Me.lbl_KCP3.Name = "lbl_KCP3"
        Me.lbl_KCP3.Size = New System.Drawing.Size(48, 24)
        Me.lbl_KCP3.TabIndex = 167
        Me.lbl_KCP3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lbl_KCP2
        '
        Me.lbl_KCP2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_KCP2.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_KCP2.Location = New System.Drawing.Point(176, 176)
        Me.lbl_KCP2.Name = "lbl_KCP2"
        Me.lbl_KCP2.Size = New System.Drawing.Size(48, 24)
        Me.lbl_KCP2.TabIndex = 166
        Me.lbl_KCP2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label36.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label36.Location = New System.Drawing.Point(8, 152)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(120, 24)
        Me.Label36.TabIndex = 50
        Me.Label36.Text = "単価"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_ItemNMJ
        '
        Me.lbl_ItemNMJ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ItemNMJ.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_ItemNMJ.Location = New System.Drawing.Point(8, 120)
        Me.lbl_ItemNMJ.Name = "lbl_ItemNMJ"
        Me.lbl_ItemNMJ.Size = New System.Drawing.Size(328, 24)
        Me.lbl_ItemNMJ.TabIndex = 155
        Me.lbl_ItemNMJ.Text = "宴会コース１"
        Me.lbl_ItemNMJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_ItemCode
        '
        Me.lbl_ItemCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ItemCode.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_ItemCode.Location = New System.Drawing.Point(8, 48)
        Me.lbl_ItemCode.Name = "lbl_ItemCode"
        Me.lbl_ItemCode.Size = New System.Drawing.Size(112, 24)
        Me.lbl_ItemCode.TabIndex = 151
        Me.lbl_ItemCode.Text = "7001"
        Me.lbl_ItemCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label34.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label34.Location = New System.Drawing.Point(8, 96)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(328, 24)
        Me.Label34.TabIndex = 135
        Me.Label34.Text = "ＰＯＳ商品名"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_Bumon
        '
        Me.cmb_Bumon.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb_Bumon.Location = New System.Drawing.Point(120, 48)
        Me.cmb_Bumon.Name = "cmb_Bumon"
        Me.cmb_Bumon.Size = New System.Drawing.Size(216, 23)
        Me.cmb_Bumon.TabIndex = 3
        Me.cmb_Bumon.Text = "宴会コース"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(120, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(216, 24)
        Me.Label19.TabIndex = 208
        Me.Label19.Text = "部門コード"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label37.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label37.Location = New System.Drawing.Point(8, 24)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(112, 24)
        Me.Label37.TabIndex = 3
        Me.Label37.Text = "商品番号"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label32.Location = New System.Drawing.Point(8, 408)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(325, 1)
        Me.Label32.TabIndex = 147
        '
        'txt_GoodsNMJ4
        '
        Me.txt_GoodsNMJ4.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_GoodsNMJ4.Location = New System.Drawing.Point(104, 440)
        Me.txt_GoodsNMJ4.Name = "txt_GoodsNMJ4"
        Me.txt_GoodsNMJ4.Size = New System.Drawing.Size(232, 22)
        Me.txt_GoodsNMJ4.TabIndex = 12
        Me.txt_GoodsNMJ4.Text = "ＮＮＮＮＮＮＮＮＮＮ"
        '
        'txt_HTLNM2
        '
        Me.txt_HTLNM2.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_HTLNM2.Location = New System.Drawing.Point(8, 464)
        Me.txt_HTLNM2.Name = "txt_HTLNM2"
        Me.txt_HTLNM2.Size = New System.Drawing.Size(88, 22)
        Me.txt_HTLNM2.TabIndex = 11
        Me.txt_HTLNM2.Text = "NNNNNN"
        '
        'txt_HTLNM1
        '
        Me.txt_HTLNM1.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_HTLNM1.Location = New System.Drawing.Point(8, 440)
        Me.txt_HTLNM1.Name = "txt_HTLNM1"
        Me.txt_HTLNM1.Size = New System.Drawing.Size(88, 22)
        Me.txt_HTLNM1.TabIndex = 10
        Me.txt_HTLNM1.Text = "NNNNNN"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label23.Location = New System.Drawing.Point(104, 416)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(232, 24)
        Me.Label23.TabIndex = 278
        Me.Label23.Text = "ＫＣＰ印字商品名"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label24.Location = New System.Drawing.Point(8, 416)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 24)
        Me.Label24.TabIndex = 277
        Me.Label24.Text = "HTL名称"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grd_Course
        '
        Me.grd_Course.CaptionFont = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_Course.CaptionText = "■ 商品情報"
        Me.grd_Course.DataMember = ""
        Me.grd_Course.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_Course.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_Course.Location = New System.Drawing.Point(20, 80)
        Me.grd_Course.Name = "grd_Course"
        Me.grd_Course.Size = New System.Drawing.Size(592, 464)
        Me.grd_Course.TabIndex = 2
        Me.grd_Course.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label10, Me.lsv_ItemGrp, Me.GroupBox1, Me.Label4, Me.lsv_MenuGrp, Me.trv_Menu, Me.tlb_Btn, Me.lst_TreeKey, Me.lst_MenuGrp})
        Me.TabPage1.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(984, 568)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "　飲み放題メニュー登録　"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(528, 296)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 24)
        Me.Label10.TabIndex = 261
        Me.Label10.Text = "● 商品ジャンル"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lsv_ItemGrp
        '
        Me.lsv_ItemGrp.AllowDrop = True
        Me.lsv_ItemGrp.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_ItemGrp.FullRowSelect = True
        ListViewItem1.StateImageIndex = 0
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.StateImageIndex = 0
        ListViewItem4.StateImageIndex = 0
        ListViewItem5.StateImageIndex = 0
        ListViewItem6.StateImageIndex = 0
        Me.lsv_ItemGrp.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6})
        Me.lsv_ItemGrp.LargeImageList = Me.ImageList5
        Me.lsv_ItemGrp.Location = New System.Drawing.Point(528, 320)
        Me.lsv_ItemGrp.MultiSelect = False
        Me.lsv_ItemGrp.Name = "lsv_ItemGrp"
        Me.lsv_ItemGrp.Size = New System.Drawing.Size(448, 243)
        Me.lsv_ItemGrp.TabIndex = 260
        '
        'ImageList5
        '
        Me.ImageList5.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList5.ImageSize = New System.Drawing.Size(44, 42)
        Me.ImageList5.ImageStream = CType(resources.GetObject("ImageList5.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList5.TransparentColor = System.Drawing.Color.Transparent
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txt_Sub2CD, Me.txt_Sub1CD, Me.Label9, Me.Label8, Me.txt_Time, Me.chk_Sub2, Me.chk_Sub1, Me.Label6, Me.txt_Sub2Price, Me.Label7, Me.txt_Sub2NM, Me.Label3, Me.txt_Sub1Price, Me.Label1, Me.txt_Sub1NM, Me.GroupBox2, Me.Label2, Me.txt_MenuTitle})
        Me.GroupBox1.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(528, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 280)
        Me.GroupBox1.TabIndex = 259
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "メニューグループ情報"
        '
        'txt_Sub2CD
        '
        Me.txt_Sub2CD.Location = New System.Drawing.Point(328, 104)
        Me.txt_Sub2CD.Name = "txt_Sub2CD"
        Me.txt_Sub2CD.Size = New System.Drawing.Size(24, 22)
        Me.txt_Sub2CD.TabIndex = 268
        Me.txt_Sub2CD.Text = ""
        Me.txt_Sub2CD.Visible = False
        '
        'txt_Sub1CD
        '
        Me.txt_Sub1CD.Location = New System.Drawing.Point(296, 104)
        Me.txt_Sub1CD.Name = "txt_Sub1CD"
        Me.txt_Sub1CD.Size = New System.Drawing.Size(24, 22)
        Me.txt_Sub1CD.TabIndex = 267
        Me.txt_Sub1CD.Text = ""
        Me.txt_Sub1CD.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(240, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 16)
        Me.Label9.TabIndex = 266
        Me.Label9.Text = "分"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 24)
        Me.Label8.TabIndex = 265
        Me.Label8.Text = "制限時間"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Time
        '
        Me.txt_Time.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Time.Location = New System.Drawing.Point(136, 104)
        Me.txt_Time.Name = "txt_Time"
        Me.txt_Time.Size = New System.Drawing.Size(96, 20)
        Me.txt_Time.TabIndex = 9
        Me.txt_Time.Text = "120"
        Me.txt_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chk_Sub2
        '
        Me.chk_Sub2.Location = New System.Drawing.Point(136, 82)
        Me.chk_Sub2.Name = "chk_Sub2"
        Me.chk_Sub2.Size = New System.Drawing.Size(16, 16)
        Me.chk_Sub2.TabIndex = 6
        Me.chk_Sub2.Text = "CheckBox2"
        '
        'chk_Sub1
        '
        Me.chk_Sub1.Location = New System.Drawing.Point(136, 58)
        Me.chk_Sub1.Name = "chk_Sub1"
        Me.chk_Sub1.Size = New System.Drawing.Size(16, 16)
        Me.chk_Sub1.TabIndex = 3
        Me.chk_Sub1.Text = "CheckBox1"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(416, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 16)
        Me.Label6.TabIndex = 261
        Me.Label6.Text = "円"
        '
        'txt_Sub2Price
        '
        Me.txt_Sub2Price.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Sub2Price.Location = New System.Drawing.Point(360, 80)
        Me.txt_Sub2Price.Name = "txt_Sub2Price"
        Me.txt_Sub2Price.Size = New System.Drawing.Size(56, 20)
        Me.txt_Sub2Price.TabIndex = 8
        Me.txt_Sub2Price.Text = "1000"
        Me.txt_Sub2Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 24)
        Me.Label7.TabIndex = 259
        Me.Label7.Text = "サブメニュー名２"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Sub2NM
        '
        Me.txt_Sub2NM.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Sub2NM.Location = New System.Drawing.Point(152, 80)
        Me.txt_Sub2NM.Name = "txt_Sub2NM"
        Me.txt_Sub2NM.Size = New System.Drawing.Size(192, 20)
        Me.txt_Sub2NM.TabIndex = 7
        Me.txt_Sub2NM.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(416, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 257
        Me.Label3.Text = "円"
        '
        'txt_Sub1Price
        '
        Me.txt_Sub1Price.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Sub1Price.Location = New System.Drawing.Point(360, 56)
        Me.txt_Sub1Price.Name = "txt_Sub1Price"
        Me.txt_Sub1Price.Size = New System.Drawing.Size(56, 20)
        Me.txt_Sub1Price.TabIndex = 5
        Me.txt_Sub1Price.Text = "1000"
        Me.txt_Sub1Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 255
        Me.Label1.Text = "サブメニュー名１"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Sub1NM
        '
        Me.txt_Sub1NM.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Sub1NM.Location = New System.Drawing.Point(152, 56)
        Me.txt_Sub1NM.Name = "txt_Sub1NM"
        Me.txt_Sub1NM.Size = New System.Drawing.Size(192, 20)
        Me.txt_Sub1NM.TabIndex = 4
        Me.txt_Sub1NM.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.btn_MenuPic, Me.Label5, Me.Label13, Me.chk_Price, Me.chk_ShowGenr, Me.cbo_Style, Me.cbo_Pat})
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 128)
        Me.GroupBox2.TabIndex = 253
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "画面表示方法を選択して下さい"
        '
        'btn_MenuPic
        '
        Me.btn_MenuPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_MenuPic.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_MenuPic.Location = New System.Drawing.Point(256, 80)
        Me.btn_MenuPic.Name = "btn_MenuPic"
        Me.btn_MenuPic.Size = New System.Drawing.Size(160, 32)
        Me.btn_MenuPic.TabIndex = 14
        Me.btn_MenuPic.Text = "メニュー画像作成"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(224, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 24)
        Me.Label5.TabIndex = 255
        Me.Label5.Text = "商品一覧画面"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(24, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(184, 24)
        Me.Label13.TabIndex = 254
        Me.Label13.Text = "画面表示タイプ"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chk_Price
        '
        Me.chk_Price.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_Price.Location = New System.Drawing.Point(72, 88)
        Me.chk_Price.Name = "chk_Price"
        Me.chk_Price.Size = New System.Drawing.Size(72, 24)
        Me.chk_Price.TabIndex = 12
        Me.chk_Price.Text = "金額別に表示する"
        Me.chk_Price.Visible = False
        '
        'chk_ShowGenr
        '
        Me.chk_ShowGenr.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_ShowGenr.Location = New System.Drawing.Point(160, 88)
        Me.chk_ShowGenr.Name = "chk_ShowGenr"
        Me.chk_ShowGenr.Size = New System.Drawing.Size(80, 24)
        Me.chk_ShowGenr.TabIndex = 13
        Me.chk_ShowGenr.Text = "ジャンル名を表示する"
        Me.chk_ShowGenr.Visible = False
        '
        'cbo_Style
        '
        Me.cbo_Style.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_Style.Location = New System.Drawing.Point(224, 48)
        Me.cbo_Style.Name = "cbo_Style"
        Me.cbo_Style.Size = New System.Drawing.Size(184, 23)
        Me.cbo_Style.TabIndex = 11
        '
        'cbo_Pat
        '
        Me.cbo_Pat.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_Pat.Location = New System.Drawing.Point(24, 48)
        Me.cbo_Pat.Name = "cbo_Pat"
        Me.cbo_Pat.Size = New System.Drawing.Size(184, 23)
        Me.cbo_Pat.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 24)
        Me.Label2.TabIndex = 252
        Me.Label2.Text = "メインメニュー名"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_MenuTitle
        '
        Me.txt_MenuTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_MenuTitle.Location = New System.Drawing.Point(136, 32)
        Me.txt_MenuTitle.Name = "txt_MenuTitle"
        Me.txt_MenuTitle.Size = New System.Drawing.Size(304, 20)
        Me.txt_MenuTitle.TabIndex = 2
        Me.txt_MenuTitle.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 24)
        Me.Label4.TabIndex = 258
        Me.Label4.Text = "● 商品ジャンル"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lsv_MenuGrp
        '
        Me.lsv_MenuGrp.Alignment = System.Windows.Forms.ListViewAlignment.Default
        Me.lsv_MenuGrp.AllowDrop = True
        Me.lsv_MenuGrp.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
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
        Me.lsv_MenuGrp.LargeImageList = Me.ImageList5
        Me.lsv_MenuGrp.Location = New System.Drawing.Point(8, 304)
        Me.lsv_MenuGrp.MultiSelect = False
        Me.lsv_MenuGrp.Name = "lsv_MenuGrp"
        Me.lsv_MenuGrp.Size = New System.Drawing.Size(509, 258)
        Me.lsv_MenuGrp.TabIndex = 257
        '
        'trv_Menu
        '
        Me.trv_Menu.CheckBoxes = True
        Me.trv_Menu.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.trv_Menu.ImageList = Me.ImageList4
        Me.trv_Menu.Indent = 25
        Me.trv_Menu.Location = New System.Drawing.Point(8, 56)
        Me.trv_Menu.Name = "trv_Menu"
        Me.trv_Menu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("メニュー１")})
        Me.trv_Menu.Size = New System.Drawing.Size(509, 216)
        Me.trv_Menu.TabIndex = 1
        '
        'ImageList4
        '
        Me.ImageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList4.ImageSize = New System.Drawing.Size(22, 22)
        Me.ImageList4.ImageStream = CType(resources.GetObject("ImageList4.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList4.TransparentColor = System.Drawing.Color.Transparent
        '
        'tlb_Btn
        '
        Me.tlb_Btn.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton3})
        Me.tlb_Btn.ButtonSize = New System.Drawing.Size(170, 47)
        Me.tlb_Btn.Divider = False
        Me.tlb_Btn.Dock = System.Windows.Forms.DockStyle.None
        Me.tlb_Btn.DropDownArrows = True
        Me.tlb_Btn.ImageList = Me.ImageList3
        Me.tlb_Btn.Location = New System.Drawing.Point(8, 8)
        Me.tlb_Btn.Name = "tlb_Btn"
        Me.tlb_Btn.ShowToolTips = True
        Me.tlb_Btn.Size = New System.Drawing.Size(516, 48)
        Me.tlb_Btn.TabIndex = 1
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 0
        Me.ToolBarButton1.Text = "新しい飲み放題メニューを作る"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 1
        Me.ToolBarButton2.Text = "飲み放題メニューをコピーする"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 2
        Me.ToolBarButton3.Text = "飲み放題メニューを削除する"
        '
        'ImageList3
        '
        Me.ImageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList3.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        '
        'lst_TreeKey
        '
        Me.lst_TreeKey.Location = New System.Drawing.Point(0, 48)
        Me.lst_TreeKey.Name = "lst_TreeKey"
        Me.lst_TreeKey.Size = New System.Drawing.Size(24, 199)
        Me.lst_TreeKey.TabIndex = 250
        '
        'lst_MenuGrp
        '
        Me.lst_MenuGrp.Location = New System.Drawing.Point(0, 472)
        Me.lst_MenuGrp.Name = "lst_MenuGrp"
        Me.lst_MenuGrp.Size = New System.Drawing.Size(16, 56)
        Me.lst_MenuGrp.TabIndex = 251
        '
        'TabPage2
        '
        Me.TabPage2.Controls.AddRange(New System.Windows.Forms.Control() {Me.grd_ItemList, Me.Label18, Me.Label11, Me.Label17, Me.Label14, Me.Label15, Me.Label16, Me.btn_Clear, Me.txt_Search, Me.cbo_Bumon, Me.Label12, Me.lsv_ItemList, Me.cbo_Sort, Me.lsv_Menu})
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(984, 568)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "　飲み放題商品登録　"
        '
        'grd_ItemList
        '
        Me.grd_ItemList.CaptionFont = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_ItemList.CaptionText = "■ 商品情報"
        Me.grd_ItemList.CaptionVisible = False
        Me.grd_ItemList.DataMember = ""
        Me.grd_ItemList.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_ItemList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_ItemList.Location = New System.Drawing.Point(8, 216)
        Me.grd_ItemList.Name = "grd_ItemList"
        Me.grd_ItemList.Size = New System.Drawing.Size(512, 344)
        Me.grd_ItemList.TabIndex = 275
        Me.grd_ItemList.TabStop = False
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label18.Location = New System.Drawing.Point(256, 200)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(128, 16)
        Me.Label18.TabIndex = 274
        Me.Label18.Text = "■ 飲み放題商品"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 16)
        Me.Label11.TabIndex = 273
        Me.Label11.Text = "■ 商品ジャンル"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 200)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 16)
        Me.Label17.TabIndex = 270
        Me.Label17.Text = "■ 登録済み商品"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.Location = New System.Drawing.Point(640, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 24)
        Me.Label14.TabIndex = 269
        Me.Label14.Text = "品名検索"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Location = New System.Drawing.Point(640, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 24)
        Me.Label15.TabIndex = 268
        Me.Label15.Text = "登録部門"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label16.Location = New System.Drawing.Point(640, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 24)
        Me.Label16.TabIndex = 267
        Me.Label16.Text = "表示条件"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Clear
        '
        Me.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Clear.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Clear.Location = New System.Drawing.Point(912, 56)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(56, 24)
        Me.btn_Clear.TabIndex = 4
        Me.btn_Clear.Text = "クリア"
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(712, 8)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(192, 22)
        Me.txt_Search.TabIndex = 1
        Me.txt_Search.Text = ""
        '
        'cbo_Bumon
        '
        Me.cbo_Bumon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Bumon.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_Bumon.Location = New System.Drawing.Point(712, 32)
        Me.cbo_Bumon.Name = "cbo_Bumon"
        Me.cbo_Bumon.Size = New System.Drawing.Size(192, 23)
        Me.cbo_Bumon.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(520, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 16)
        Me.Label12.TabIndex = 263
        Me.Label12.Text = "■ 商品一覧"
        '
        'lsv_ItemList
        '
        Me.lsv_ItemList.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_ItemList.Location = New System.Drawing.Point(528, 80)
        Me.lsv_ItemList.Name = "lsv_ItemList"
        Me.lsv_ItemList.Size = New System.Drawing.Size(448, 480)
        Me.lsv_ItemList.TabIndex = 262
        Me.lsv_ItemList.View = System.Windows.Forms.View.Details
        '
        'cbo_Sort
        '
        Me.cbo_Sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Sort.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_Sort.Location = New System.Drawing.Point(712, 56)
        Me.cbo_Sort.Name = "cbo_Sort"
        Me.cbo_Sort.Size = New System.Drawing.Size(192, 23)
        Me.cbo_Sort.TabIndex = 3
        '
        'lsv_Menu
        '
        Me.lsv_Menu.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_Menu.FullRowSelect = True
        ListViewItem16.StateImageIndex = 0
        ListViewItem17.StateImageIndex = 0
        ListViewItem18.StateImageIndex = 0
        ListViewItem19.StateImageIndex = 0
        ListViewItem20.StateImageIndex = 0
        ListViewItem21.StateImageIndex = 0
        ListViewItem22.StateImageIndex = 0
        ListViewItem23.StateImageIndex = 0
        ListViewItem24.StateImageIndex = 0
        Me.lsv_Menu.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem16, ListViewItem17, ListViewItem18, ListViewItem19, ListViewItem20, ListViewItem21, ListViewItem22, ListViewItem23, ListViewItem24})
        Me.lsv_Menu.LargeImageList = Me.ImageList5
        Me.lsv_Menu.Location = New System.Drawing.Point(8, 24)
        Me.lsv_Menu.MultiSelect = False
        Me.lsv_Menu.Name = "lsv_Menu"
        Me.lsv_Menu.Size = New System.Drawing.Size(512, 168)
        Me.lsv_Menu.TabIndex = 259
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 606)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(1008, 24)
        Me.stb_Msg.TabIndex = 222
        Me.stb_Msg.Text = "StatusBar1"
        '
        'CNL1580
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1008, 630)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.stb_Msg, Me.TabControl1})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CNL1580"
        Me.Text = "CNL1580"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grd_Course, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.grd_ItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const LC_PAT_GENR As String = "0"
    Private Const LC_PAT_NETA As String = "1"
    Private Const LC_PAT_DIRC As String = "2"
    Private Const LC_STYLE_LIST As String = "A"
    Private Const LC_STYLE_PIC12 As String = "B"
    Private Const LC_STYLE_PIC4 As String = "C"

    Private Const LC_SORT_UPDYMD As String = "0"
    Private Const LC_SORT_NOGROUP As String = "1"
    Private Const LC_SORT_PRICE As String = "2"
    Private Const LC_SORT_NOSORT As String = "3"
    Private Const LC_SORT_BUMON As String = "4"
    Private Const LC_SORT_SEARCH As String = "5"

    Private Const LC_MOVEMODE As String = "M"
    Private Const LC_COPYMODE As String = "C"

    Private L_ProcFlg As Boolean
    Private L_blnEditFlg As Boolean
    Private L_blnDMode As Boolean
    Private L_intRowNo As Integer
    Private L_MenuCD As String
    Private L_DragMode As String
    Private L_PriceEdit As Boolean
    Private L_CRow As Long
    Private L_TabNo As Integer

    Private Sub CNL1580_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' フォーム名称設定
        '------------------------------
        Me.Text = GF_FormText("- " & GF_GetAppInfo("FREE_MENU_NM") & "登録画面")

        '------------------------------
        ' フォーム初期化処理
        '------------------------------

        '-- タブページ名称設定
        TabControl1.TabPages(1).Text = GF_GetAppInfo("FREE_MENU_NM") & "設定"
        TabControl1.TabPages(2).Text = GF_GetAppInfo("FREE_MENU_NM") & "商品登録"

        Select Case TabControl1.SelectedIndex
            Case 0
                L_TabNo = 0
                Call LS_CourseFormInitialize()
            Case 1
                L_TabNo = 1
                Call LS_MenuFormInitialize()
            Case 2
                L_TabNo = 2
                Call LS_GOODSFormInitialize()
            Case Else
                Exit Sub
        End Select

        L_blnEditFlg = False
        L_blnDMode = False
        L_intRowNo = -1
        L_MenuCD = ""

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1580_Load")
    End Sub

    Private Sub CNL1580_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Dim strMenuNM As String = Nothing
        Dim strMenuGrpNM As String = Nothing

        '中ジャンル割付チェック
        If LF_CheckMenuPic("TPM170", strMenuNM, strMenuGrpNM) = False Then
            GF_Msg("", "【" & strMenuNM & "】のメニュー画像に割付が行われていません。" & vbCrLf & "表示方法を変更するか、メニュー画像にジャンルの割付処理を行ってください。", MsgBoxStyle.OkOnly)
            e.Cancel = True
            Exit Sub
        End If

        If L_TabNo = 0 Then
            LS_CommitCheck()
        End If

        If L_blnEditFlg = True Then
            Select Case GF_Msg("", "変更を保存しますか？", MsgBoxStyle.YesNoCancel)
                Case MsgBoxResult.Yes
                    If L_TabNo = 0 Then
                        '-- コースメニュー登録の場合、TPM010、TPM170更新
                        If Not LF_UpdTPM010() Then
                            L_blnEditFlg = False
                            If Not GF_RollbackTrans() Then
                                Exit Sub
                            End If
                        End If
                        If Not LF_UpdTPM180() Then
                            L_blnEditFlg = False
                            If Not GF_RollbackTrans() Then
                                Exit Sub
                            End If
                        End If
                    ' --- (2008.01.11) 飲み放題対応 -----------------------------
                    ElseIf L_TabNo = 1 Then
                        If Not LF_ErrDataExist() > 0 Then
                            L_blnEditFlg = False
                        Else
                            GF_Msg("", GF_GetAppInfo("FREE_MENU_NM") & "に金額が設定されている商品の割付は出来ません", MsgBoxStyle.OkOnly)
                            e.Cancel = True
                            Exit Sub
                        End If
                    ' -----------------------------------------------------------
                    End If
                    If Not GF_CommitTrans() Then
                        Exit Sub
                    End If
                    ' FUMENU 更新
                    If Trim$(GF_GetAppInfo("SYS_TYPE")) = "2" Or Trim$(GF_GetAppInfo("SYS_TYPE")) = "3" Then
                        '-- FUMENU存在チェック
                        If System.IO.File.Exists(Trim$(GF_GetAppInfo("OES_PATH")) & "\" & Trim$(GF_GetAppInfo("OES_MENUTBL"))) Then
                            If GF_PutFUMENUData() = False Then
                                L_blnEditFlg = False
                                'Exit Sub
                            End If
                        Else
                            GF_Msg("", "FUMENU パスを確認してください", MsgBoxStyle.OkOnly)
                        End If
                    End If

                    L_blnEditFlg = False

                Case MsgBoxResult.No
                    If Not GF_RollbackTrans() Then
                        Exit Sub
                    End If

                    L_blnEditFlg = False

                Case MsgBoxResult.Cancel
                    e.Cancel = True
            End Select

        Else
            If Not GF_RollbackTrans() Then
                Exit Sub
            End If
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：飲み放題商品登録初期表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' --------------------------------------------------------------------------------
    Private Sub LS_GOODSFormInitialize(Optional ByVal pInitMode As Boolean = True)

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If pInitMode Then
            If Not GF_BeginTrans() Then
                Exit Sub
            End If
            L_blnEditFlg = False
        End If

        ' 商品ジャンル一覧表示 -----------------------------
        If pInitMode Then
            lsv_Menu.Clear()
            lsv_Menu.HideSelection = True
            LF_Set_LsvMenu()
        End If

        ' 商品一覧表示 -------------------------------------
        With grd_ItemList
            .TableStyles.Clear()
            .DataSource = Nothing
            .AllowDrop = True
            .ReadOnly = False
        End With
        'LS_GridSetup()

        If pInitMode Then
            With lsv_ItemList
                .Clear()
                .FullRowSelect = True
                .AllowDrop = True
                .AllowColumnReorder = True
                '.HideSelection = False
            End With

            LF_SetItemList()

            '------------------------------
            ' 商品一覧ソートコンボ生成
            '------------------------------
            cbo_Sort.Items.Clear()
            Call GS_CboItemSet(cbo_Sort, "登録日時順に表示する", LC_SORT_UPDYMD)
            Call GS_CboItemSet(cbo_Sort, "未登録商品のみ表示する", LC_SORT_NOGROUP)
            Call GS_CboItemSet(cbo_Sort, "単価順に表示する", LC_SORT_PRICE)
            Call GS_CboItemSet(cbo_Sort, "--- 指定なし ---", LC_SORT_NOSORT)
            cbo_Sort.SelectedIndex = 3

            '------------------------------
            ' 部門一覧コンボ生成
            '------------------------------
            cbo_Bumon.Items.Clear()
            Call LS_SetBumonCombo()
            cbo_Bumon.SelectedIndex = 0

            txt_Search.Text = ""

        End If

        Label18.Text = "■ " & GF_GetAppInfo("FREE_MENU_NM") & "商品"

    End Sub

    Private Function LF_Set_LsvMenu() As Object

        LF_Set_LsvMenu = Nothing

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim intCnt As Integer
        Dim objItem As ListViewItem

        strSQL = ""
        strSQL = strSQL & "SELECT GROUPCD,GROUPNM"
        strSQL = strSQL & "  FROM TPM020"
        strSQL = strSQL & " WHERE GOODSCD = '0000 '"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        For intCnt = 0 To objData.Tables("com").Rows.Count - 1
            If Not GF_GetRows(objData, intCnt, objRow) Then
                Exit Function
            End If

            objItem = New ListViewItem()

            With objItem
                .Text = Trim$(objRow("GROUPNM"))
                .Tag = objRow("GROUPCD")
                .ImageIndex = 0
            End With
            lsv_Menu.Items.Add(objItem)

        Next

    End Function

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        If L_TabNo = 0 And TabControl1.SelectedIndex <> 0 Then
            LS_CommitCheck()
        End If

        If L_blnEditFlg = True Then
            If GF_Msg("", "保存しますか？", MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then
                If L_TabNo = 0 Then
                    '-- コースメニュー登録の場合、TPM010、TPM170更新
                    If Not LF_UpdTPM010() Then
                        L_blnEditFlg = False
                        If Not GF_RollbackTrans() Then
                            Exit Sub
                        End If
                    End If
                    If Not LF_UpdTPM180() Then
                        L_blnEditFlg = False
                        If Not GF_RollbackTrans() Then
                            Exit Sub
                        End If
                    End If
                ' --- (2008.01.11) 飲み放題対応 -----------------------------
                ElseIf L_TabNo = 1 Then
                    If LF_ErrDataExist() > 0 Then
                        GF_Msg("", GF_GetAppInfo("FREE_MENU_NM") & "に金額が設定されている商品の割付は出来ません", MsgBoxStyle.OKOnly)
                        L_blnEditFlg = False
                        TabControl1.SelectedIndex = L_TabNo
                        Exit Sub
                    End If
                ' -----------------------------------------------------------
                End If
                If Not GF_CommitTrans() Then
                    L_blnEditFlg = False
                    Exit Sub
                End If
                ' FUMENU 更新
                If Trim$(GF_GetAppInfo("SYS_TYPE")) = "2" Or Trim$(GF_GetAppInfo("SYS_TYPE")) = "3" Then
                    '-- FUMENU存在チェック
                    If System.IO.File.Exists(Trim$(GF_GetAppInfo("OES_PATH")) & "\" & Trim$(GF_GetAppInfo("OES_MENUTBL"))) Then
                        If GF_PutFUMENUData() = False Then
                            L_blnEditFlg = False
                            'Exit Sub
                        End If
                    Else
                        GF_Msg("", "FUMENU パスを確認してください", MsgBoxStyle.OKOnly)
                    End If
                End If

            Else
                If Not GF_RollbackTrans() Then
                    Exit Sub
                End If
            End If

            L_blnEditFlg = False
        Else
            If Not GF_RollbackTrans() Then
                Exit Sub
            End If
        End If

        Select Case TabControl1.SelectedIndex
            Case 0
                L_TabNo = 0
                Call LS_CourseFormInitialize()
            Case 1
                L_TabNo = 1
                Call LS_MenuFormInitialize()
            Case 2
                L_TabNo = 2
                Call LS_GOODSFormInitialize()
            Case Else
                Exit Sub
        End Select

    End Sub

    Private Sub lsv_Menu_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Menu.SelectedIndexChanged

        Dim objCollection As ListView.SelectedListViewItemCollection

        objCollection = lsv_Menu.SelectedItems
        If objCollection.Count = 0 Then
            Call LS_GOODSFormInitialize(False)
            Exit Sub
        End If
        If objCollection.Contains(objCollection.Item(0)) = False Then
            Call LS_GOODSFormInitialize(False)
            Exit Sub
        End If
        LS_GridSetup()

    End Sub

    Private Function LF_SetItemList() As Object

        LF_SetItemList = Nothing

        ' ■商品一覧　リスト作成 --------------------------------------------------------

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim lngCnt As Long
        Dim objItem As ListViewItem

        '-- 表示データ取得 -----------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        strSQL = strSQL & "       TPM010.PRICE"
        strSQL = strSQL & "  FROM TPM010"
        '---(2006.06.28) 不要な為削除-----------
        'strSQL = strSQL & " WHERE TPM010.GOODSCD >= '1000'"
        'strSQL = strSQL & "   AND TPM010.GOODSCD <= '3999'"
        '---------------------------------------
        '--- (2007.11.27) 障害対応 -------------------------
        strSQL = strSQL & " WHERE TPM010.STATUS = '0'"
        'strSQL = strSQL & "   AND TPM010.STATUS = '0'"
        '---------------------------------------------------
        strSQL = strSQL & "   AND TPM010.GOODSKIND IN ('0', '1')"
        If Len(Trim$(txt_Search.Text)) <> 0 Then
            strSQL = strSQL & "   AND TPM010.GOODSNMJ LIKE '%" & Trim$(txt_Search.Text) & "%'"
        End If
        If cbo_Bumon.SelectedIndex <> -1 And GF_CboGetCode(cbo_Bumon, cbo_Bumon.SelectedIndex) <> "@@" Then
            strSQL = strSQL & "   AND TPM010.BUMONCD = '" & GF_CboGetCode(cbo_Bumon, cbo_Bumon.SelectedIndex) & "'"
        End If
        Select Case cbo_Sort.SelectedIndex
            Case LC_SORT_UPDYMD
                strSQL = strSQL & " ORDER BY TPM010.UPDYMD DESC, TPM010.GOODSCD"
            Case LC_SORT_NOGROUP
                strSQL = strSQL & "   AND TPM010.GOODSCD NOT IN (SELECT TPM020.GOODSCD FROM TPM020 WHERE TPM020.GOODSCD <> '0000')"
                strSQL = strSQL & " ORDER BY TPM010.GOODSCD"
            Case LC_SORT_PRICE
                strSQL = strSQL & " ORDER BY TPM010.PRICE"
            Case LC_SORT_NOSORT
                strSQL = strSQL & " ORDER BY TPM010.GOODSCD"
            Case Else
        End Select
        ' ------------------------------------------------------------------

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' メニューテーブルオープン
        '------------------------------
        lsv_ItemList.Clear()
        With lsv_ItemList.Columns
            .Add("商品コード", 90, HorizontalAlignment.Center)
            .Add("商品名", 262, HorizontalAlignment.Left)
            .Add("単価", 75, HorizontalAlignment.Right)
        End With

        If Not IsNothing(objData.Tables("com")) Then
            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objRow) Then
                    Exit Function
                End If

                objItem = New ListViewItem()
                objItem.Text = objRow("GOODSCD")
                objItem.SubItems.Add(Trim$(objRow("GOODSNMJ")) & Trim$(objRow("GOODSNMJ2")))
                objItem.SubItems.Add(Format$(CLng(Trim$(objRow("PRICE"))), "#,##0") & "円")
                lsv_ItemList.Items.Add(objItem)

                lngCnt = lngCnt + 1
            End While
        End If

    End Function

    Private Sub lsv_ItemList_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_ItemList.ItemDrag
        ' ドラッグ処理開始
        L_blnDMode = True
        lsv_ItemGrp.DoDragDrop(lsv_ItemList.SelectedItems, DragDropEffects.Copy)
    End Sub
    Private Sub lsv_ItemList_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemList.DragEnter
        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
            e.Effect = DragDropEffects.Copy
        ElseIf e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub lsv_ItemList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemList.DragDrop

        Dim objCell As DataGridCell

        'If L_blnDMode = True Then Exit Sub
        If Not e.Data.GetDataPresent(DataFormats.Text) Then Exit Sub

        'For i = 0 To GF_GetRowCnt(grd_ItemList) - 1
        '    grd_ItemList.UnSelect(i)
        'Next

        With grd_ItemList

            .Item(grd_ItemList.CurrentRowIndex, 3) = ""
            .Item(grd_ItemList.CurrentRowIndex, 4) = ""
            .Item(grd_ItemList.CurrentRowIndex, 5) = ""

            objCell = New DataGridCell(grd_ItemList.CurrentRowIndex, 6)
            .CurrentCell = objCell
            L_intRowNo = grd_ItemList.CurrentRowIndex

            If Not LF_UpTPM160("DEL", .Item(grd_ItemList.CurrentRowIndex, 0)) Then
                GoTo SYSTEM_ERROR
            End If
            L_blnEditFlg = True

        End With

        '-- ドラッグ終了
        L_blnDMode = False

        'Debug.WriteLine("lsv_ItemList_DragDrop 【" & grd_ItemList.CurrentRowIndex & "】")

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("lsv_ItemList_DragDrop")
    End Sub

    Private Sub grd_ItemList_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grd_ItemList.DragOver

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCell As DataGridCell
        Dim objPoint As Point = grd_ItemList.PointToClient(Cursor.Position)
        Dim objHitTest As System.Windows.Forms.DataGrid.HitTestInfo
        Dim i As Integer

        For i = 0 To GF_GetRowCnt(grd_ItemList) - 1
            grd_ItemList.UnSelect(i)
        Next

        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
            With grd_ItemList
                ' 座標位置から、カレント行を変更する
                objHitTest = .HitTest(objPoint)
                If objHitTest.Row <> -1 Then
                    objCell = New DataGridCell(objHitTest.Row, 6)
                    .CurrentCell = objCell
                    .Select(objHitTest.Row)
                    L_intRowNo = objHitTest.Row
                End If
            End With
            e.Effect = DragDropEffects.Copy
        ElseIf (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub

    Private Sub grd_ItemList_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grd_ItemList.DragEnter
        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済み商品一覧グリッド制御（ドラッグ操作中制御）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' --------------------------------------------------------------------------------
    Private Sub grd_ItemList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grd_ItemList.DragDrop

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCell As DataGridCell = grd_ItemList.CurrentCell
        Dim objPoint As Point = grd_ItemList.PointToClient(Cursor.Position)
        Dim objTargetData As ListView.SelectedListViewItemCollection
        Dim strGoodsNM As String

        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then

            objTargetData = e.Data.GetData(GetType(ListView.SelectedListViewItemCollection))

            grd_ItemList(objCell.RowNumber, 3) = objTargetData.Item(0).SubItems(0).Text
            strGoodsNM = objTargetData.Item(0).SubItems(1).Text
            If Len(objTargetData.Item(0).SubItems(1).Text) > 10 Then
                strGoodsNM = Mid(objTargetData.Item(0).SubItems(1).Text, 1, 10) & vbCrLf & Mid(objTargetData.Item(0).SubItems(1).Text, 11)
            Else
                strGoodsNM = objTargetData.Item(0).SubItems(1).Text
            End If
            grd_ItemList(objCell.RowNumber, 4) = strGoodsNM
            grd_ItemList(objCell.RowNumber, 5) = objTargetData.Item(0).SubItems(2).Text
            If Not LF_UpTPM160("IN", grd_ItemList(objCell.RowNumber, 0), grd_ItemList(objCell.RowNumber, 3)) Then
                GoTo SYSTEM_ERROR
            End If
            L_blnEditFlg = True

        End If

        L_blnDMode = True

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("grd_ItemList_DragDrop")
    End Sub

    Private Sub grd_ItemList_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grd_ItemList.MouseDown

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCell As DataGridCell
        Dim objPoint As Point = grd_ItemList.PointToClient(Cursor.Position)
        Dim objHitTest As System.Windows.Forms.DataGrid.HitTestInfo

        If GF_GetRowCnt(grd_ItemList) = 0 Then Exit Sub

        With grd_ItemList
            ' 座標位置から、カレント行を変更する
            objHitTest = .HitTest(objPoint)
            If objHitTest.Row <> -1 Then

                objCell = New DataGridCell(objHitTest.Row, 6)
                .CurrentCell = objCell
                L_intRowNo = objHitTest.Row
                ' ドラッグ処理開始
                'L_blnDDMode = False
                DoDragDrop(CStr(grd_ItemList(objCell.RowNumber, 6)), DragDropEffects.Copy)

                '.Select(.CurrentCell.RowNumber)

            End If
        End With

    End Sub

    Private Sub grd_ItemList_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_ItemList.CurrentCellChanged

        Dim i As Integer
        Dim objHitTest As System.Windows.Forms.DataGrid.HitTestInfo
        Dim objPoint As Point = grd_ItemList.PointToClient(Cursor.Position)
        Dim objCell As DataGridCell

        For i = 0 To GF_GetRowCnt(grd_ItemList) - 1
            grd_ItemList.UnSelect(i)
        Next

        With grd_ItemList
            ' 座標位置から、カレント行を変更する
            objHitTest = .HitTest(objPoint)
            If objHitTest.Row <> -1 Or L_intRowNo <> -1 Then
                objCell = New DataGridCell(.CurrentCell.RowNumber, 6)
                .CurrentCell = objCell
                .Select(.CurrentCell.RowNumber)
                'Debug.WriteLine("あ")
            End If
        End With

        'Debug.WriteLine("grd_ItemList_CurrentCellChanged 【" & objHitTest.Row & "】【" & grd_ItemList.CurrentCell.RowNumber & "】")

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済み商品一覧グリッド 初期設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' --------------------------------------------------------------------------------
    Private Sub LS_GridSetup()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objTs As New DataGridTableStyle()                               ' 新しいDataGridTableStyleの作成
        Dim udtGridCol(6) As typGridColumn
        Dim lngCnt As Long
        Dim dtsData As New DataSet()
        Dim dtrRows As DataRow = Nothing
        Dim dtrData As DataRow = Nothing
        Dim dtsList As DataSet
        Dim objTable As DataTable
        Dim objRow As DataRow = Nothing

        Try
            '------------------------------
            ' テーブルスタイル定義
            '------------------------------
            With objTs
                .MappingName = "ITEMLIST"                                       ' マップ名を指定
                .PreferredRowHeight = 55                                       ' 標準行高を指定
            End With

            '------------------------------
            ' 各項目属性定義
            '------------------------------
            With udtGridCol(0)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSCD"
                .strHeadText = "番号"
                .blnAllowNull = False
                .lngWidth = 40
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(1)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSNM"
                .strHeadText = "商品名"
                .blnAllowNull = False
                .lngWidth = 148
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With
            With udtGridCol(2)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "PRICE"
                .strHeadText = "単価"
                .blnAllowNull = False
                .lngWidth = 55
                .objAlign = HorizontalAlignment.Right
                .blnReadOnly = True
            End With
            With udtGridCol(3)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "FGOODSCD"
                .strHeadText = "番号"
                .blnAllowNull = False
                .lngWidth = 40
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(4)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "FGOODSNM"
                .strHeadText = "商品名"
                .blnAllowNull = False
                .lngWidth = 148
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With
            With udtGridCol(5)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "FPRICE"
                .strHeadText = "単価"
                .blnAllowNull = False
                .lngWidth = 55
                .objAlign = HorizontalAlignment.Right
                .blnReadOnly = True
            End With
            '-- フォーカス設定用隠し項目
            With udtGridCol(6)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "DUMMYCD"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Right
                .blnReadOnly = True
            End With

            For lngCnt = 0 To UBound(udtGridCol)                                ' 各列定義をテーブルスタイルに追加
                Call GS_GridAddColumn(udtGridCol(lngCnt), objTs)
            Next
            objTs.AllowSorting = False                                          ' 列見出しクリックによるソートを禁止
            objTs.RowHeadersVisible = False

            With grd_ItemList
                .TableStyles.Clear()
                .TableStyles.Add(objTs)                                         ' テーブルスタイルをDataGridに追加
                '.ReadOnly = True                                                ' 編集禁止
                .ReadOnly = False                                               ' 編集禁止
            End With

            '------------------------------
            ' グリッド生成
            '------------------------------
            dtsList = New DataSet("ItemList")
            objTable = New DataTable("ITEMLIST")
            For lngCnt = 0 To UBound(udtGridCol)
                Call GS_GridAddTable(udtGridCol(lngCnt), objTable)
            Next

            Call LS_SetItemGrid(objTable, udtGridCol)

            If objTable.Rows.Count <= 0 Then
                Exit Sub
            End If

            dtsList.Tables.Add(objTable)                                        ' テーブルをDataSetに追加する
            'grd_ItemList.SetDataBinding(dtsList, "ITEMLIST")                    ' DataSetとテーブルをDataGridに接続する


            Dim ds As DataSet = CType(dtsList, DataSet)
            Dim cm As CurrencyManager = CType(BindingContext(dtsList, "ItemList"), CurrencyManager)
            Dim dv As DataView = CType(cm.List, DataView)
            dv.AllowNew = False
            'grd_ItemList.SetDataBinding(dv, "ITEMLIST")                    ' DataSetとテーブルをDataGridに接続する
            grd_ItemList.DataSource = dv                                    ' DataSetとテーブルをDataGridに接続する


            'Dim objCell As DataGridCell
            'objCell.ColumnNumber = 1
            'objCell.RowNumber = 0
            'grd_ItemList.CurrentCell = objCell
            ''L_CRow = grd_ItemList.CurrentCell.RowNumber

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GridSetup")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済み商品一覧グリッド 表示値設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetItemGrid(ByVal pTable As DataTable, ByVal pGridCols() As typGridColumn)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objWRow As DataRow = Nothing
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strSQL As String

        '------------------------------
        ' 設定データ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        strSQL = strSQL & "       TPM010.PRICE,"
        strSQL = strSQL & "       ISNULL(TPM160.FREEGOODSCD,' ') AS FREEGOODSCD,"
        strSQL = strSQL & "       ISNULL((SELECT TPM010.GOODSNMJ FROM TPM010 WHERE TPM010.GOODSCD = TPM160.FREEGOODSCD),' ') AS FGOODSNMJ,"
        strSQL = strSQL & "       ISNULL((SELECT TPM010.GOODSNMJ2 FROM TPM010 WHERE TPM010.GOODSCD = TPM160.FREEGOODSCD),' ') AS FGOODSNMJ2,"
        strSQL = strSQL & "       ISNULL((SELECT TPM010.PRICE FROM TPM010 WHERE TPM010.GOODSCD = TPM160.FREEGOODSCD),0) AS FPRICE,"
        strSQL = strSQL & "       '1' AS DUMMYCD"
        strSQL = strSQL & "  FROM TPM010 LEFT JOIN TPM160 ON TPM010.GOODSCD = TPM160.GOODSCD,"
        strSQL = strSQL & "       TPM020"
        strSQL = strSQL & " WHERE TPM020.GROUPCD = '" & lsv_Menu.SelectedItems.Item(0).Tag & "'"
        strSQL = strSQL & "   AND TPM010.GOODSCD = TPM020.GOODSCD"
        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            '------------------------------
            ' メニューテーブルオープン
            '------------------------------
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objWRow) Then
                    Exit Sub
                End If

                objRows = pTable.NewRow
                objRows(pGridCols(0).strMapName) = objWRow("GOODSCD")
                objRows(pGridCols(1).strMapName) = Trim$(objWRow("GOODSNMJ")) & Trim$(objWRow("GOODSNMJ2"))
                objRows(pGridCols(2).strMapName) = Format$(CLng(Trim$(objWRow("PRICE"))), "#,##0") & "円"
                objRows(pGridCols(3).strMapName) = Trim$(objWRow("FREEGOODSCD"))
                objRows(pGridCols(4).strMapName) = Trim$(objWRow("FGOODSNMJ")) & vbCrLf & Trim$(objWRow("FGOODSNMJ2"))
                objRows(pGridCols(5).strMapName) = IIf(Trim$(objWRow("FREEGOODSCD")) = "", "", Format$(CLng(Trim$(objWRow("FPRICE"))), "#,##0") & "円")

                pTable.Rows.Add(objRows)
                lngCnt = lngCnt + 1
            End While
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetItemGrid")
    End Sub

    Private Function LF_UpTPM160(ByVal pMode As String, ByVal pGoodsCD As String, Optional ByVal pFreeGoodsCD As String = "") As Boolean

        Dim strSQL As String

        LF_UpTPM160 = False
        strSQL = ""

        Select Case pMode
            Case "IN"
                If LF_DataExist(pGoodsCD) > 0 Then
                    '-- 更新
                    strSQL = strSQL & "UPDATE TPM160"
                    strSQL = strSQL & "   SET FREEGOODSCD = '" & pFreeGoodsCD & "',"
                    strSQL = strSQL & "       UPDID       = '" & GC_UPDID & "',"
                    strSQL = strSQL & "       UPDYMD      = '" & Now & "'"
                    strSQL = strSQL & " WHERE GOODSCD = '" & pGoodsCD & "'"
                Else
                    '-- 追加
                    strSQL = strSQL & "INSERT INTO TPM160 VALUES("
                    strSQL = strSQL & "'" & pGoodsCD & "',"
                    strSQL = strSQL & "'" & pFreeGoodsCD & "',"
                    strSQL = strSQL & "'" & GC_UPDID & "',"
                    strSQL = strSQL & "'" & Now & "')"
                End If
            Case "DEL"
                '-- 削除
                strSQL = strSQL & "DELETE FROM TPM160"
                strSQL = strSQL & " WHERE GOODSCD = '" & pGoodsCD & "'"
            Case Else
                Exit Function
        End Select

        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '-------------------------------
        ' TPM160.GENERATEFLG も更新
        '-------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM010"
        strSQL = strSQL & "   SET GENERATEFLG = '" & GC_TRUE & "',"
        strSQL = strSQL & "       UPDID = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD = '" & Now & "'"
        strSQL = strSQL & " WHERE GOODSCD = '" & pFreeGoodsCD & "'"

        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpTPM160 = True

    End Function

    Private Function LF_UpdTPM010(ByVal pMenuID As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM010 = False

        '------------------------------
        ' 商品マスタ更新
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM010"
        strSQL = strSQL & "   SET TPM010.GENERATEFLG = '" & GC_TRUE & "',"
        strSQL = strSQL & "       TPM010.UPDID       = '" & GC_UPDID & "',"
        strSQL = strSQL & "       TPM010.UPDYMD      = getdate()"
        strSQL = strSQL & " WHERE TPM010.GOODSCD IN (SELECT TPM020.GOODSCD"
        strSQL = strSQL & "                            FROM TPM020, TPM170"
        strSQL = strSQL & "                           WHERE TPM020.GROUPCD   = TPM170.GROUPCD"
        strSQL = strSQL & "                             AND TPM020.GOODSCD  <> '0000'"
        strSQL = strSQL & "                             AND TPM170.MENUID    = '" & Trim$(pMenuID) & "')"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM010 = True

    End Function

    Private Function LF_DataExist(ByVal pCode As String) As Integer

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_DataExist = 0

        strSQL = ""
        strSQL = strSQL & "SELECT * FROM TPM160"
        strSQL = strSQL & " WHERE GOODSCD = '" & pCode & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        LF_DataExist = objData.Tables("com").Rows.Count

    End Function

    Private Sub txt_Search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Search.TextChanged

        LF_SetItemList()

    End Sub

    Private Sub cbo_Bumon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_Bumon.SelectedIndexChanged

        LF_SetItemList()

    End Sub

    Private Sub cbo_Sort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_Sort.SelectedIndexChanged

        LF_SetItemList()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：部門検索コンボ表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetBumonCombo()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' 部門一覧取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM110.BUMONCD,"
        strSQL = strSQL & "       TPM110.BUMONNM"
        strSQL = strSQL & "  FROM TPM110"
        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If
        lngCnt = 0
        Call GS_CboItemSet(cbo_Bumon, "--- 指定なし ---", "@@")
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                GoTo SYSTEM_ERROR
            End If
            Call GS_CboItemSet(cbo_Bumon, Trim$(objRows("BUMONCD")) & ":" & Trim$(objRows("BUMONNM")), Trim$(objRows("BUMONCD")))
            lngCnt = lngCnt + 1
        End While

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetBumonCombo")
    End Sub

    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click

        txt_Search.Text = ""
        cbo_Bumon.SelectedIndex = 0
        cbo_Sort.SelectedIndex = 3

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：飲み放題メニュー登録初期表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' --------------------------------------------------------------------------------
    Private Sub LS_MenuFormInitialize(Optional ByVal pMode As Boolean = True)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim dtsData As New DataSet()
        Dim dtrData As DataRow = Nothing
        Dim strFreeNM As String

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If pMode Then
            If Not GF_BeginTrans() Then
                Exit Sub
            End If
        End If
        L_blnEditFlg = False

        '------------------------------
        ' フォーム初期化処理
        '------------------------------
        lst_TreeKey.Visible = False                                         ' 隠し項目の非表示設定
        lst_MenuGrp.Visible = False
        lsv_MenuGrp.AllowDrop = True
        lsv_ItemGrp.AllowDrop = True
        Call GS_StatusSetup(stb_Msg)                                        ' ステータスバー初期化
        trv_Menu.Nodes.Clear()                                              ' メニューツリービュー初期化
        lsv_MenuGrp.Items.Clear()                                           ' メニューグループ・商品グループ一覧初期化
        txt_MenuTitle.Text = ""
        lsv_ItemGrp.Items.Clear()
        lst_MenuGrp.Items.Clear()
        L_ProcFlg = False                                                   ' 処理中フラグ(イベント発生回避フラグ)

        txt_MenuTitle.Text = ""
        chk_Sub1.Checked = False
        txt_Sub1CD.Text = ""
        txt_Sub1NM.Text = ""
        txt_Sub1Price.Text = ""
        chk_Sub2.Checked = False
        txt_Sub2CD.Text = ""
        txt_Sub2NM.Text = ""
        txt_Sub2Price.Text = ""
        txt_Time.Text = ""

        ' フォーカス喪失後も、選択域を強調表示する
        lsv_ItemGrp.HideSelection = False
        lsv_MenuGrp.HideSelection = False
        trv_Menu.HideSelection = False

        cbo_Pat.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_Pat.Items.Clear()
        Call GS_CboItemSet(cbo_Pat, "商品ジャンルを表示", LC_PAT_GENR)
        Call GS_CboItemSet(cbo_Pat, "ネタケースを表示", LC_PAT_NETA)
        Call GS_CboItemSet(cbo_Pat, "商品一覧を直接表示", LC_PAT_DIRC)
        Call GS_CboChgSel(cbo_Pat, LC_PAT_GENR)

        cbo_Style.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_Style.Items.Clear()
        Call GS_CboItemSet(cbo_Style, "短冊で表示", LC_STYLE_LIST)
        Call GS_CboItemSet(cbo_Style, "写真で表示(12/９分割)", LC_STYLE_PIC12)
        Call GS_CboItemSet(cbo_Style, "写真で表示(４分割)", LC_STYLE_PIC4)
        Call GS_CboChgSel(cbo_Style, LC_STYLE_LIST)

        Call LS_SetMenuTree()
        '---20060530 張本 ADD START メニューツリー０件時はメニュー画像作成不可---
        btn_MenuPic.Enabled = False
        '---20060530 張本 ADD END
        strFreeNM = GF_GetAppInfo("FREE_MENU_NM")
        tlb_Btn.Buttons(0).Text = "新しい" & strFreeNM & "メニューを作る"
        tlb_Btn.Buttons(1).Text = strFreeNM & "メニューをコピーする"
        tlb_Btn.Buttons(2).Text = strFreeNM & "メニューを削除する"

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_MenuFormInitialize")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューツリー生成処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetMenuTree()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim dtsData As New DataSet()
        Dim dtrData As DataRow = Nothing
        Dim lngCnt As Long
        Dim objNode As TreeNode = Nothing
        Dim objCNode As TreeNode = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        trv_Menu.Nodes.Clear()                                              ' メニューツリービュー初期化
        lst_TreeKey.Items.Clear()                                           ' 隠しキー保持リスト初期化
        txt_MenuTitle.Clear()

        '------------------------------
        ' メニューツリー生成処理
        '------------------------------
        If Not LF_GetTPM170(dtsData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            L_ProcFlg = True                                                    ' イベント発生回避フラグＯＮ
            lngCnt = 0
            While lngCnt < dtsData.Tables("com").Rows.Count
                If Not GF_GetRows(dtsData, lngCnt, dtrData) Then
                    GoTo SYSTEM_ERROR
                End If

                objNode = trv_Menu.Nodes.Add(Trim$(dtrData("MENUNM")))

                If Trim$(dtrData("ENABLED")) = "1" Then
                    objNode.Checked = True
                Else
                    objNode.Checked = False
                End If

                lst_TreeKey.Items.Add("P" & _
                                      Format$(objNode.Index, "00000") & _
                                      vbTab & _
                                      Trim$(dtrData("MENUID")))

                lngCnt = lngCnt + 1

            End While
            L_ProcFlg = False                                                   ' イベント発生回避フラグＯＦＦ
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetMenuTree")
        L_ProcFlg = False
    End Sub

    Private Function LF_GetTPM170(ByRef pobjData As DataSet) As Boolean

        Dim strSQL As String
        Dim objData As New DataSet()

        LF_GetTPM170 = False

        strSQL = ""
        strSQL = strSQL & "SELECT TPM170.MENUID,"
        strSQL = strSQL & "       TPM170.MENUNM,"
        strSQL = strSQL & "       TPM170.ENABLED"
        strSQL = strSQL & "  FROM TPM170"
        strSQL = strSQL & " WHERE TPM170.GROUPCD = '0000'"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pobjData = objData
        LF_GetTPM170 = True

    End Function

    Private Sub trv_Menu_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trv_Menu.AfterSelect

        lsv_MenuGrp.Clear()
        lst_MenuGrp.Items.Clear()

        L_MenuCD = LF_GetMenuGrpCD(trv_Menu.SelectedNode)

        LF_SetCbo_Pat(L_MenuCD)

        '-- 登録済み商品ジャンル一覧作成
        LF_SetMenuList(L_MenuCD)
        '-- メニューグループ情報作成
        LF_SetMenuInfo(L_MenuCD)
        '-- 編集元商品ジャンル一覧作成
        LS_SetItemGrp(L_MenuCD)

        '---20060530 張本 ADD START 商品ジャンル登録0件時はメニュー画像作成不可
        btn_MenuPic.Enabled = True
        If lsv_MenuGrp.Items.Count = 0 Then

            btn_MenuPic.Enabled = False

        End If
        '---20060530 張本 ADD END
    End Sub

    Private Function LF_GetMenuGrpCD(ByVal pNode As TreeNode) As String
        '*** 選択された飲み放題メニューＣＤを取得する **********

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim strFindKey As String = Nothing
        Dim strWork() As String = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetMenuGrpCD = ""

        Try
            If IsNothing(pNode.Parent) Then
                strFindKey = "P" & Format$(pNode.Index, "00000")
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

    Private Function LF_SetMenuList(ByVal pMenuCD As String) As Object
        '*** 選択された飲み放題メニューに登録済みの商品ジャンル一覧を設定 ******

        Dim strSQL As String = Nothing
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim intCnt As Integer
        Dim objItem As ListViewItem
        Dim strWork As String = Nothing

        LF_SetMenuList = Nothing

        strSQL = ""
        strSQL = strSQL & "SELECT TPM020.GROUPCD,TPM020.GROUPNM, TPM170.PRICEDISP"
        strSQL = strSQL & "  FROM TPM020, TPM170"
        strSQL = strSQL & " WHERE TPM020.GOODSCD = '0000 '"
        strSQL = strSQL & "   AND TPM170.MENUID = '" & pMenuCD & "'"
        strSQL = strSQL & "   AND TPM170.GROUPCD <> '0000'"
        strSQL = strSQL & "   AND TPM020.GROUPCD = TPM170.GROUPCD"
        strSQL = strSQL & " ORDER BY TPM020.DISPORDER"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        For intCnt = 0 To objData.Tables("com").Rows.Count - 1
            If Not GF_GetRows(objData, intCnt, objRow) Then
                Exit Function
            End If

            objItem = New ListViewItem()

            With objItem
                .Text = strWork

            End With

            strWork = Trim$(objRow("GROUPNM")) & vbTab & _
                      Trim$(objRow("GROUPCD")) & vbTab & _
                      Trim$(objRow("PRICEDISP"))
            lst_MenuGrp.Items.Add(strWork)
            'With objItem
            '    .Text = Trim$(objRow("GROUPNM"))
            '    .Tag = objRow("GROUPCD")
            '    .ImageIndex = 0
            'End With
            'lsv_MenuGrp.Items.Add(objItem)

        Next

        Call LS_SetMenuGrpFromHide()

    End Function

    Private Function LF_SetMenuInfo(ByVal pMenuCD As String) As Object

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_SetMenuInfo = Nothing

        '-- 選択された飲み放題メニュー情報を取得
        strSQL = ""
        strSQL = strSQL & "SELECT TPM170.MENUID,"
        strSQL = strSQL & "       TPM170.MENUNM,"
        strSQL = strSQL & "       TPM170.MENUSTYLE,"
        strSQL = strSQL & "       TPM170.GROUPKBN,"
        strSQL = strSQL & "       TPM170.ENABLED,"
        strSQL = strSQL & "       TPM170.FREEDRINKTIME,"
        strSQL = strSQL & "       TPM170.SUB1GOODSCD,"
        strSQL = strSQL & "       TPM170.SUB1ENABLED,"
        strSQL = strSQL & "       TPM170.SUB2GOODSCD,"
        strSQL = strSQL & "       TPM170.SUB2ENABLED,"
        strSQL = strSQL & "      (SELECT TPM010.GOODSNMJ + GOODSNMJ2 FROM TPM010 WHERE TPM010.GOODSCD = TPM170.SUB1GOODSCD) AS SUB1GOODSNMJ,"
        strSQL = strSQL & "      (SELECT TPM010.GOODSNMJ + GOODSNMJ2 FROM TPM010 WHERE TPM010.GOODSCD = TPM170.SUB2GOODSCD) AS SUB2GOODSNMJ,"
        strSQL = strSQL & "      (SELECT TPM010.PRICE FROM TPM010 WHERE TPM010.GOODSCD = TPM170.SUB1GOODSCD) AS SUB1PRICE,"
        strSQL = strSQL & "      (SELECT TPM010.PRICE FROM TPM010 WHERE TPM010.GOODSCD = TPM170.SUB2GOODSCD) AS SUB2PRICE"
        strSQL = strSQL & "  FROM TPM170, TPM010"
        strSQL = strSQL & " WHERE TPM170.MENUID = '" & pMenuCD & "'"
        strSQL = strSQL & "   AND TPM170.GROUPCD = '0000'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, objRow) Then
            Exit Function
        End If

        '-- 各メニューグループ情報を設定
        txt_MenuTitle.Text = objRow("MENUNM")
        chk_Sub1.Checked = IIf(objRow("SUB1ENABLED") = "1", True, False)
        txt_Sub1NM.Text = Trim$(objRow("SUB1GOODSNMJ"))
        txt_Sub1Price.Text = objRow("SUB1PRICE")
        txt_Sub1CD.Text = objRow("SUB1GOODSCD")
        chk_Sub2.Checked = IIf(objRow("SUB2ENABLED") = "1", True, False)
        txt_Sub2NM.Text = Trim$(objRow("SUB2GOODSNMJ"))
        txt_Sub2Price.Text = objRow("SUB2PRICE")
        txt_Sub2CD.Text = objRow("SUB2GOODSCD")
        txt_Time.Text = objRow("FREEDRINKTIME")

        Select Case Trim$(objRow("MENUSTYLE"))
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
        Select Case Trim$(objRow("GROUPKBN"))
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

        ' 「メニュー画像表示」の場合、各チェックBOXは使えない
        If Trim$(objRow("MENUSTYLE")) = GC_MSTYLE_PICTJ Or _
           Trim$(objRow("MENUSTYLE")) = GC_MSTYLE_PIC12 Or _
           Trim$(objRow("MENUSTYLE")) = GC_MSTYLE_PIC4 Then
            chk_Price.Enabled = False
            chk_ShowGenr.Enabled = False
        End If

    End Function

    Private Sub LS_SetItemGrp(ByVal pMenuID As String)
        '** 編集元　商品ジャンル一覧作成 *******

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim objItem As ListViewItem

        Try
            '------------------------------
            ' 初期化処理
            '------------------------------
            lsv_ItemGrp.Items.Clear()

            '------------------------------
            ' 商品グループ一覧設定
            '------------------------------
            '------------------------------
            ' メニューグループマスタ取得
            '------------------------------
            strSQL = ""
            strSQL = strSQL & "SELECT TPM020.GROUPCD,"
            strSQL = strSQL & "       TPM020.GROUPNM,"
            strSQL = strSQL & "       TPM020.PRICEDISP"
            strSQL = strSQL & "  FROM TPM020"
            strSQL = strSQL & " WHERE TPM020.GROUPCD NOT IN (SELECT GROUPCD"
            strSQL = strSQL & "                                FROM TPM170"
            strSQL = strSQL & "                               WHERE MENUID    = '" & pMenuID & "'"
            strSQL = strSQL & "                                GROUP BY GROUPCD)"
            strSQL = strSQL & "   AND TPM020.GOODSCD = '0000'"
            strSQL = strSQL & " GROUP BY TPM020.GROUPCD,"
            strSQL = strSQL & "          TPM020.GROUPNM,"
            strSQL = strSQL & "          TPM020.PRICEDISP"

            If Not GF_GetData(strSQL, objData) Then
                Exit Sub
            End If

            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objRow) Then
                    Exit Sub
                End If

                objItem = New ListViewItem()
                With objItem
                    .Text = Trim$(objRow("GROUPNM"))
                    .Tag = Trim$(objRow("GROUPCD"))
                    .ImageIndex = 0
                    .SubItems.Add(objRow("PRICEDISP"))
                End With
                lsv_ItemGrp.Items.Add(objItem)

                lngCnt = lngCnt + 1
            End While
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub txt_MenuTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MenuTitle.TextChanged
        '--- メインメニュー名の変更をツリービューへ連絡し、ＤＢに更新する

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objNode As TreeNode = Nothing
        Dim strSQL As String

        If IsNothing(trv_Menu.SelectedNode) Then Exit Sub
        If txt_MenuTitle.Modified = False Then Exit Sub

        ' --- 半角文字を入力制限した ---
        Dim lngST As Long
        lngST = txt_MenuTitle.SelectionStart
            ' 2014-05-12 2バイト文字制限解除
        'txt_MenuTitle.Text = StrConv(txt_MenuTitle.Text, VbStrConv.Wide)
        If lngST >= 0 Then txt_MenuTitle.SelectionStart = lngST

        '------------------------------
        ' ツリービューへの入力値反映
        '------------------------------
        objNode = trv_Menu.SelectedNode
        If GF_LenB(txt_MenuTitle.Text) > 50 Then
            txt_MenuTitle.Text = GF_MidB(txt_MenuTitle.Text, 1, 50)
            txt_MenuTitle.SelectionStart = GF_LenB(txt_MenuTitle.Text)
        End If
        objNode.Text = txt_MenuTitle.Text

        '------------------------------
        ' ＤＢへの入力値反映(更新)
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM170"
        strSQL = strSQL & "   SET MENUNM = '" & Trim$(txt_MenuTitle.Text) & "',"
        strSQL = strSQL & "       UPDID = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD = '" & Now & "'"
        strSQL = strSQL & " WHERE MENUID = '" & LF_GetMenuGrpCD(objNode) & "'"

        If Not GF_UpdData(strSQL) Then
            Exit Sub
        End If

        L_blnEditFlg = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_MenuTitle_TextChanged")

    End Sub
    Private Sub cbo_Pat_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Price.CheckedChanged, chk_ShowGenr.CheckedChanged, cbo_Style.SelectionChangeCommitted, cbo_Pat.SelectionChangeCommitted
        '--- 【画面表示タイプ】【商品一覧画面】【金額別チェックＢＯＸ】【ジャンル名表示チェックＢＯＸ】に変更があった場合

        'If L_ProcFlg2 Then Exit Sub
        If IsNothing(trv_Menu.SelectedNode) Then Exit Sub

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
        ' 内部変数定義
        '------------------------------
        Dim strPat As String = Nothing
        Dim strStyle As String = Nothing
        Dim strMenuStyle As String = Nothing
        Dim strGroupKbn As String = Nothing
        Dim strSQL As String = Nothing

        strPat = GF_CboGetCode(cbo_Pat, cbo_Pat.SelectedIndex)
        strStyle = GF_CboGetCode(cbo_Style, cbo_Style.SelectedIndex)

        '-- 【画面表示タイプ】【商品一覧画面】設定情報取得
        Try
            Select Case strPat
                Case LC_PAT_GENR
                    Select Case strStyle
                        Case LC_STYLE_LIST
                            strMenuStyle = GC_MSTYLE_LISTSTR
                        Case LC_STYLE_PIC12
                            strMenuStyle = GC_MSTYLE_LISTPIC
                        Case LC_STYLE_PIC4
                            strMenuStyle = GC_MSTYLE_LISTPIC4
                    End Select
                    If chk_Price.Checked = False And chk_ShowGenr.Checked = False Then
                        strGroupKbn = GC_ORDER_GROUP
                    End If
                    If chk_Price.Checked = True And chk_ShowGenr.Checked = False Then
                        strGroupKbn = GC_ORDER_PRICE
                    End If
                    If chk_Price.Checked = True And chk_ShowGenr.Checked = True Then
                        strGroupKbn = GC_ORDER_PRICE2
                    End If


                Case LC_PAT_NETA
                    Select Case strStyle
                        Case LC_STYLE_LIST
                            strMenuStyle = GC_MSTYLE_NETASTR
                        Case LC_STYLE_PIC12
                            strMenuStyle = GC_MSTYLE_NETAPIC
                        Case LC_STYLE_PIC4
                            strMenuStyle = GC_MSTYLE_NETACASE
                    End Select
                    strGroupKbn = GC_ORDER_CASE

                Case LC_PAT_DIRC
                    Select Case strStyle
                        Case LC_STYLE_LIST
                            strMenuStyle = GC_MSTYLE_NOLIST
                        Case LC_STYLE_PIC12
                            strMenuStyle = GC_MSTYLE_NOLISTSTR
                        Case LC_STYLE_PIC4
                            strMenuStyle = GC_MSTYLE_NOLISTPIC4
                    End Select
                    strGroupKbn = GC_ORDER_NONE

                Case 3
                    Select Case strStyle
                        Case LC_STYLE_LIST
                            strMenuStyle = GC_MSTYLE_PICTJ
                        Case LC_STYLE_PIC12
                            strMenuStyle = GC_MSTYLE_PIC12
                        Case LC_STYLE_PIC4
                            strMenuStyle = GC_MSTYLE_PIC4
                    End Select
                    strGroupKbn = GC_ORDER_GROUP

            End Select
        Catch
            GoTo SYSTEM_ERROR
        End Try

        '-- TPM170 更新用ＳＱＬ作成
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM170"
        strSQL = strSQL & "   SET MENUSTYLE = '" & strMenuStyle & "',"
        strSQL = strSQL & "       GROUPKBN  = '" & strGroupKbn & "',"
        strSQL = strSQL & "       UPDID = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD = '" & Now & "'"
        strSQL = strSQL & " WHERE MENUID = '" & LF_GetMenuGrpCD(trv_Menu.SelectedNode) & "'"
        'strSQL = strSQL & "   AND GROUPCD = '0000'"

        If Not GF_UpdData(strSQL) Then
            GoTo SYSTEM_ERROR
        End If

        If Not LF_UpdTPM010(LF_GetMenuGrpCD(trv_Menu.SelectedNode)) Then
            GoTo SYSTEM_ERROR
        End If

        L_blnEditFlg = True

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_UpdChkStatus")
    End Sub

    Private Sub txt_Time_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Time.TextChanged
        '--- 制限時間が変更された場合、ＤＢ更新を行う

        Dim strSQL As String

        If txt_Time.Modified = False Then
            Exit Sub
        End If

        '-- 入力値チェック
        txt_Time.Text = StrConv(Trim$(txt_Time.Text), VbStrConv.Narrow)
        If Len(txt_Time.Text) > 3 Then
            GF_Msg("", "制限時間は３桁までです", MsgBoxStyle.OKOnly)
            Exit Sub
        End If

        If Not IsNumeric(txt_Time.Text) Then
            GF_Msg("", "制限時間は数字のみを入力してください", MsgBoxStyle.OKOnly)
            Exit Sub
        End If

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM170"
        strSQL = strSQL & "   SET FREEDRINKTIME = " & Trim$(txt_Time.Text) & ","
        strSQL = strSQL & "       UPDID = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD = '" & Now & "'"
        strSQL = strSQL & " WHERE MENUID = '" & LF_GetMenuGrpCD(trv_Menu.SelectedNode) & "'"
        strSQL = strSQL & "   AND GROUPCD = '0000'"

        If Not GF_UpdData(strSQL) Then
            GoTo SYSTEM_ERROR
        End If

        L_blnEditFlg = True

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_Time_TextChanged")
    End Sub

    Private Sub LF_Sub1Sub2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Sub1.Click, chk_Sub2.Click
        '--- サブメニュー１、２の有効チェックが変更された場合、ＤＢ更新を行う

        Dim strSQL As String

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM170"
        strSQL = strSQL & "   SET SUB1ENABLED = '" & IIf(chk_Sub1.Checked = True, "1", "0") & "',"
        strSQL = strSQL & "       SUB2ENABLED = '" & IIf(chk_Sub2.Checked = True, "1", "0") & "',"
        strSQL = strSQL & "       UPDID = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD = '" & Now & "'"
        strSQL = strSQL & " WHERE MENUID = '" & LF_GetMenuGrpCD(trv_Menu.SelectedNode) & "'"
        strSQL = strSQL & "   AND GROUPCD = '0000'"

        If Not GF_UpdData(strSQL) Then
            GoTo SYSTEM_ERROR
        End If

        L_blnEditFlg = True

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("chk_Sub1Sub2_CheckedChanged")
    End Sub

    Private Sub LF_Sub1SUB2_TextChanged(ByVal pMenuCD As String, ByVal pMenuNM As String, ByVal pPrice As String)
        '---サブメニュー１，２の名称・金額が変更された場合、TPM010とFUMENUを更新する

        Dim strSQL As String

        ' 入力値チェック
        pPrice = StrConv(Trim$(pPrice), VbStrConv.Narrow)
        If Len(pPrice) > 7 Then
            GF_Msg("", "金額は７桁までです", MsgBoxStyle.OKOnly)
            Exit Sub
        End If

        If Not IsNumeric(pPrice) Then
            GF_Msg("", "金額は数字のみを入力してください", MsgBoxStyle.OKOnly)
            Exit Sub
        End If

            ' 2014-05-12 2バイト文字制限解除
        'pMenuNM = StrConv(Trim$(pMenuNM), VbStrConv.Wide)
        pMenuNM = Trim$(pMenuNM)
        If Len(pPrice) > 20 Then
            GF_Msg("", "サブメニュー名称は20文字までです", MsgBoxStyle.OKOnly)
            Exit Sub
        End If

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM010"
        strSQL = strSQL & "   SET GOODSNMJ = '" & GF_MidB(Trim$(pMenuNM), 1, 20) & "',"
        If GF_LenB(Trim$(pMenuNM)) > 20 Then
            strSQL = strSQL & "   GOODSNMJ2 = '" & GF_MidB(Trim$(pMenuNM), 21, 20) & "',"
        Else
            strSQL = strSQL & "   GOODSNMJ2 = '" & Space(20) & "',"
        End If
        strSQL = strSQL & "       PRICE = " & pPrice & ","
        strSQL = strSQL & "       UPDID = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD = '" & Now & "'"
        strSQL = strSQL & " WHERE GOODSCD = '" & pMenuCD & "'"

        If Not GF_UpdData(strSQL) Then
            GoTo SYSTEM_ERROR
        End If

        L_blnEditFlg = True

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LF_Sub1SUB2_TextChanged")
    End Sub

    Private Sub txt_Sub1NM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Sub1NM.TextChanged
        Dim lngST As Long

        If IsNothing(trv_Menu.SelectedNode) Then Exit Sub
        If txt_Sub1NM.Modified = False Then
            Exit Sub
        End If

        '-- 全角に変換
        lngST = txt_Sub1NM.SelectionStart
            ' 2014-05-12 2バイト文字制限解除
        'txt_Sub1NM.Text = StrConv(txt_Sub1NM.Text, VbStrConv.Wide)
        If lngST >= 0 Then txt_Sub1NM.SelectionStart = lngST

        If GF_LenB(txt_Sub1NM.Text) > 40 Then
            txt_Sub1NM.Text = GF_MidB(txt_Sub1NM.Text, 1, 40)
            txt_Sub1NM.SelectionStart = GF_LenB(txt_Sub1NM.Text)
        End If

        LF_Sub1SUB2_TextChanged(txt_Sub1CD.Text, txt_Sub1NM.Text, txt_Sub1Price.Text)

    End Sub

    Private Sub txt_Sub1Price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Sub1Price.TextChanged

        If IsNothing(trv_Menu.SelectedNode) Then Exit Sub
        If txt_Sub1Price.Modified = False Then
            Exit Sub
        End If

        LF_Sub1SUB2_TextChanged(txt_Sub1CD.Text, txt_Sub1NM.Text, txt_Sub1Price.Text)

    End Sub
    Private Sub txt_Sub2NM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Sub2NM.TextChanged

        Dim lngST As Long

        If IsNothing(trv_Menu.SelectedNode) Then Exit Sub
        If txt_Sub2NM.Modified = False Then
            Exit Sub
        End If

        '-- 全角に変換
        lngST = txt_Sub2NM.SelectionStart
            ' 2014-05-12 2バイト文字制限解除
        'txt_Sub2NM.Text = StrConv(txt_Sub2NM.Text, VbStrConv.Wide)
        If lngST >= 0 Then txt_Sub2NM.SelectionStart = lngST

        If GF_LenB(txt_Sub2NM.Text) > 40 Then
            txt_Sub2NM.Text = GF_MidB(txt_Sub2NM.Text, 1, 40)
            txt_Sub2NM.SelectionStart = GF_LenB(txt_Sub2NM.Text)
        End If

        LF_Sub1SUB2_TextChanged(txt_Sub2CD.Text, txt_Sub2NM.Text, txt_Sub2Price.Text)

    End Sub

    Private Sub txt_Sub2Price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Sub2Price.TextChanged

        If IsNothing(trv_Menu.SelectedNode) Then Exit Sub
        If txt_Sub2Price.Modified = False Then
            Exit Sub
        End If

        LF_Sub1SUB2_TextChanged(txt_Sub2CD.Text, txt_Sub2NM.Text, txt_Sub2Price.Text)

    End Sub

    Private Sub lsv_MenuGrp_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_MenuGrp.ItemDrag
        L_DragMode = LC_MOVEMODE
        lsv_MenuGrp.DoDragDrop(e.Item, DragDropEffects.Copy)
        '---20060530 張本 ADD START 商品ジャンル登録0件時はメニュー画像作成不可
        btn_MenuPic.Enabled = True
        If lsv_MenuGrp.Items.Count = 0 Then

            btn_MenuPic.Enabled = False

        End If
        '---20060530 張本 ADD END
    End Sub

    Private Sub lsv_MenuGrp_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_MenuGrp.DragEnter
        If (e.Data.GetDataPresent(GetType(ListViewItem))) Then
            e.Effect = DragDropEffects.Copy
        End If
        '---20060530 張本 ADD START 商品ジャンル登録0件時はメニュー画像作成不可
        btn_MenuPic.Enabled = True
        If lsv_MenuGrp.Items.Count = 0 Then

            btn_MenuPic.Enabled = False

        End If
        '---20060530 張本 ADD END
    End Sub

    Private Sub lsv_MenuGrp_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_MenuGrp.DragOver

        '------------------------------
        ' 内部変数定義
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
        '---20060530 張本 ADD START 商品ジャンル登録0件時はメニュー画像作成不可
        btn_MenuPic.Enabled = True
        If lsv_MenuGrp.Items.Count = 0 Then

            btn_MenuPic.Enabled = False

        End If
        '---20060530 張本 ADD END
    End Sub

    Private Sub lsv_MenuGrp_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_MenuGrp.DragDrop
        '★★　ジャンルを新しく登録　★★

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objItem As ListViewItem
        Dim objSrcItem As ListViewItem
        Dim objPoint As Point
        Dim intIndex As Integer
        Dim strWork As String
        Dim lngCnt As Integer
        Dim udtUpdVal As typTPM060 = Nothing
        Dim udtUpdKey As typTPM060 = Nothing
        Dim udtDummy As typTPM060 = Nothing                                           ' 初期化用に使用する。値の設定禁止

        Try
            If (e.Data.GetDataPresent(GetType(ListViewItem))) Then
                '------------------------------
                ' 受理データ取得
                '------------------------------
                objSrcItem = e.Data.GetData(GetType(ListViewItem))              ' ドラッグされてきたアイテムデータ
                objPoint = lsv_MenuGrp.PointToClient(New Point(e.X, e.Y))       ' マウスポインタの座標位置
                objItem = lsv_MenuGrp.GetItemAt(objPoint.X, objPoint.Y)         ' ↑に対応する、アイテムデータ
                intIndex = lsv_MenuGrp.Items.IndexOf(objItem)                   ' ↑の index値

                strWork = objSrcItem.Text & vbTab & _
                          objSrcItem.Tag & vbTab & _
                          objSrcItem.SubItems(1).Text                           ' 隠し領域へ登録する値を生成
                If L_DragMode = LC_MOVEMODE Then                                ' ドラッグモードの判定
                    For lngCnt = 0 To lst_MenuGrp.Items.Count - 1               ' 隠し領域内に、同一アイテムが存在する場合は、先に削除してしまう
                        If strWork = lst_MenuGrp.Items(lngCnt) Then
                            lst_MenuGrp.Items.RemoveAt(lngCnt)
                            Exit For
                        End If
                    Next
                End If

                If intIndex = -1 Then                                           ' 挿入先Indexを決める
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

                Call LS_SetMenuGrpFromHide()                                    ' 隠しリストボックスから、表示域へ反映

                '------------------------------
                ' ドロップ情報→ＤＢ反映
                '------------------------------
                If L_DragMode = LC_MOVEMODE Then
                    '------------------------------
                    ' 重複アイテム削除処理
                    '------------------------------
                    With udtUpdKey
                        .MENUID = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
                        '.MENUGRPID = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
                        .GROUPCD = CStr(objSrcItem.Tag)
                        .ENABLED = IIf(trv_Menu.SelectedNode.Checked = True, 1, 0)
                    End With
                    Call LF_GetChkStatus(udtUpdVal)                             ' チェック状態取得
                    If Not LF_UpdTPM170_1(udtUpdVal, udtUpdKey, False) Then
                        GoTo SYSTEM_ERROR
                    End If
                End If

                With udtUpdVal
                    .MENUID = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
                    .MENUNM = GF_RepQuo(trv_Menu.SelectedNode.Text)
                    .GROUPCD = CStr(objSrcItem.Tag)
                    .DISPORDER = CStr(intIndex)
                    .PRICEDISP = IIf(CStr(objSrcItem.SubItems(1).Text), GC_TRUE, GC_FALSE)
                    .ENABLED = IIf(trv_Menu.SelectedNode.Checked = True, 1, 0)
                    .UPDID = GC_UPDID
                    .UPDYMD = Now
                End With
                Call LF_GetChkStatus(udtUpdVal)                             ' チェック状態取得
                If Not LF_UpdTPM170_1(udtUpdVal, udtUpdKey, True) Then
                    GoTo SYSTEM_ERROR
                End If

                '------------------------------
                ' 表示順項目のリナンバ処理
                '------------------------------
                udtUpdVal = udtDummy                                        ' 変数初期化
                udtUpdKey = udtDummy
                For lngCnt = 0 To lsv_MenuGrp.Items.Count - 1
                    With udtUpdVal
                        .DISPORDER = CLng(lngCnt)
                        .UPDID = GC_UPDID
                        .UPDYMD = Now
                    End With
                    With udtUpdKey
                        .MENUID = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
                        '.MENUGRPID = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
                        .GROUPCD = lsv_MenuGrp.Items(lngCnt).Tag
                    End With
                    If Not LF_UpdTPM170_2(udtUpdVal, udtUpdKey) Then
                        GoTo SYSTEM_ERROR
                    End If
                Next

                '--- (2006.05.19) 編集元から削除
                lsv_ItemGrp.Clear()
                LS_SetItemGrp(LF_GetMenuGrpCD(trv_Menu.SelectedNode))

            End If
            '---20060530 張本 ADD START 商品ジャンル登録0件時はメニュー画像作成不可
            btn_MenuPic.Enabled = True
            If lsv_MenuGrp.Items.Count = 0 Then

                btn_MenuPic.Enabled = False

            End If
            '---20060530 張本 ADD END
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("lsv_MenuGrp_DragDrop")
    End Sub

    Private Sub lsv_ItemGrp_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_ItemGrp.ItemDrag
        'L_DragMode = LC_COPYMODE
        lsv_ItemGrp.DoDragDrop(e.Item, DragDropEffects.Copy)
    End Sub

    Private Sub lsv_ItemGrp_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemGrp.DragEnter
        If (e.Data.GetDataPresent(GetType(ListViewItem))) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub lsv_ItemGrp_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemGrp.DragDrop
        '★★　「飲み放題メニュー登録画面」登録済み商品ジャンルを編集元へDrag&Drop　★★

        '------------------------------
        ' 内部変数定義
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
                ' 受理データ取得
                '------------------------------
                objSrcItem = e.Data.GetData(GetType(ListViewItem))
                For lngCnt = 0 To lsv_ItemGrp.Items.Count - 1
                    If lsv_ItemGrp.Items(lngCnt).Tag = objSrcItem.Tag Then      ' 商品グループコード重複チェック
                        Exit Sub
                    End If
                Next

                '------------------------------
                ' 追加アイテムの生成
                '------------------------------
                objItem = New ListViewItem()
                With objItem
                    .Text = objSrcItem.Text
                    .Tag = objSrcItem.Tag
                    .ImageIndex = 0
                    .SubItems.Add(objSrcItem.SubItems(1).Text)
                End With
                lsv_ItemGrp.Items.Add(objItem)

                ' 商品グループリストから、対象のレコードを削除しておく
                For lngCnt = 0 To lst_MenuGrp.Items.Count - 1
                    strWork = objSrcItem.Text & vbTab & _
                              objSrcItem.Tag
                    If strWork = lst_MenuGrp.Items(lngCnt) Then                 ' (選択済)商品リスト側の削除/再描画処理
                        lst_MenuGrp.Items.RemoveAt(lngCnt)
                        Call LS_SetMenuGrpFromHide()
                        Exit For
                    End If
                Next

                '------------------------------
                ' 商品グループ削除／ＤＢ反映
                '------------------------------
                With udtUpdKey
                    .MENUID = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
                    .GROUPCD = CStr(objSrcItem.Tag)
                End With
                If Not LF_UpdTPM170_1(udtUpdVal, udtUpdKey, False) Then
                    GoTo SYSTEM_ERROR
                End If

                '--- (2006.05.19)　商品グループリスト再表示
                lsv_ItemGrp.Clear()
                LS_SetItemGrp(LF_GetMenuGrpCD(trv_Menu.SelectedNode))
                '-- 登録済み商品ジャンル一覧作成
                lsv_MenuGrp.Clear()
                lst_MenuGrp.Items.Clear()
                LF_SetMenuList(L_MenuCD)

            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("lsv_ItemGrp_DragDrop")
    End Sub

    Private Sub LS_SetMenuGrpFromHide()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim objItem As ListViewItem
        Dim strWork() As String

        '------------------------------
        ' 初期化処理
        '------------------------------
        lsv_MenuGrp.Items.Clear()                                           ' 商品グループ一覧初期クリア

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

    Private Function LF_GetChkStatus(ByRef pUpdVal As typTPM060) As Boolean

        Dim strPat As String
        Dim strStyle As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetChkStatus = False

        strPat = GF_CboGetCode(cbo_Pat, cbo_Pat.SelectedIndex)
        strStyle = GF_CboGetCode(cbo_Style, cbo_Style.SelectedIndex)

        Try
            '------------------------------
            ' 選択状態確認
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
        ' 返却値設定
        '------------------------------
        LF_GetChkStatus = True

    End Function

    Private Function LF_UpdTPM170_1(ByVal pUpdVal As typTPM060, ByVal pUpdKey As typTPM060, ByVal pblnUpdFlg As Boolean) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strSQL2 As String
        Dim objData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM170_1 = False
        strSQL = ""

        '------------------------------
        ' 更新ＳＱＬ文生成
        '------------------------------
        If pblnUpdFlg Then
            strSQL = strSQL & "INSERT INTO TPM170 VALUES("
            strSQL = strSQL & "'" & pUpdVal.MENUID & "',"
            strSQL = strSQL & "'" & pUpdVal.MENUNM & "',"
            strSQL = strSQL & "'" & pUpdVal.MENUSTYLE & "',"
            strSQL = strSQL & "'" & pUpdVal.GROUPCD & "',"
            strSQL = strSQL & "'" & pUpdVal.DISPORDER & "',"
            strSQL = strSQL & "'" & pUpdVal.PRICEDISP & "',"
            strSQL = strSQL & "'" & pUpdVal.GROUPKBN & "',"
            strSQL = strSQL & "'" & pUpdVal.ENABLED & "',"
            strSQL = strSQL & "0,"
            strSQL = strSQL & "'" & Space(5) & "',"
            strSQL = strSQL & "'" & Space(1) & "',"
            strSQL = strSQL & "'" & Space(5) & "',"
            strSQL = strSQL & "'" & Space(1) & "',"
            strSQL = strSQL & "'" & pUpdVal.UPDID & "',"
            strSQL = strSQL & "'" & pUpdVal.UPDYMD & "')"
        Else
            strSQL = strSQL & "DELETE FROM TPM170"
            strSQL = strSQL & "      WHERE TPM170.MENUID    = '" & pUpdKey.MENUID & "'"
            strSQL = strSQL & "        AND TPM170.GROUPCD   = '" & pUpdKey.GROUPCD & "'"

            '--- メニュー画像 ----------------------------------------------------
            ' ジャンルが解除されたら、メニュー画像のわりつけも解除する
            strSQL2 = ""
            strSQL2 = strSQL2 & "SELECT * FROM TPM150"
            strSQL2 = strSQL2 & " WHERE MENUID = '" & pUpdKey.MENUID & "'"
            strSQL2 = strSQL2 & "   AND GROUPCD   = '" & pUpdKey.GROUPCD & "'"
            If Not GF_GetData(strSQL2, objData) Then
                Exit Function
            End If

            If objData.Tables("com").Rows.Count > 0 Then
                strSQL2 = ""
                strSQL2 = strSQL2 & "UPDATE TPM150"
                strSQL2 = strSQL2 & "   SET GROUPCD = 'J000'"
                strSQL2 = strSQL2 & " WHERE MENUID = '" & pUpdKey.MENUID & "'"
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

        '------------------------------
        ' TPM010.GENERATEFLG も更新
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM010"
        strSQL = strSQL & "   SET TPM010.GENERATEFLG = '" & GC_TRUE & "',"
        strSQL = strSQL & "       TPM010.UPDID = '" & pUpdVal.UPDID & "',"
        strSQL = strSQL & "       TPM010.UPDYMD = '" & pUpdVal.UPDYMD & "'"
        strSQL = strSQL & " WHERE TPM010.GOODSCD IN (SELECT TPM020.GOODSCD FROM TPM020 WHERE GROUPCD = '" & pUpdVal.GROUPCD & "')"

        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        L_blnEditFlg = True

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM170_1 = True

    End Function

    Private Function LF_UpdTPM170_2(ByVal pUpdVal As typTPM060, ByVal pUpdKey As typTPM060) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM170_2 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM170"
        strSQL = strSQL & "   SET TPM170.DISPORDER = '" & pUpdVal.DISPORDER & "',"
        strSQL = strSQL & "       TPM170.UPDID     = '" & pUpdVal.UPDID & "',"
        strSQL = strSQL & "       TPM170.UPDYMD    = '" & pUpdVal.UPDYMD & "'"
        strSQL = strSQL & " WHERE TPM170.MENUID    = '" & pUpdKey.MENUID & "'"
        strSQL = strSQL & "   AND TPM170.GROUPCD   = '" & pUpdKey.GROUPCD & "'"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If
        L_blnEditFlg = True

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM170_2 = True

    End Function

    Private Sub tlb_Btn_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlb_Btn.ButtonClick

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objForm As Form = Nothing

        Select Case e.Button.Text
            Case tlb_Btn.Buttons.Item(0).Text
                objForm = New CNL1581()
            Case tlb_Btn.Buttons.Item(1).Text
                objForm = New CNL1582()
            Case tlb_Btn.Buttons.Item(2).Text
                If Not IsNothing(trv_Menu.SelectedNode) Then
                    Select Case LF_UpdDeleteMenu(trv_Menu.SelectedNode)
                        Case CNL1920.FuncResult.NormalEnd
                            Call LS_MenuFormInitialize(False)
                            L_blnEditFlg = True
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
                Call LS_MenuFormInitialize(False)
                L_blnEditFlg = True
            Case DialogResult.Cancel
                ' 何もしない
            Case Else
                GoTo SYSTEM_ERROR
        End Select
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("tlb_Btn_ButtonClick")
    End Sub
    Private Function LF_UpdDeleteMenu(ByVal pNode As TreeNode) As FuncResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strMenuID As String
        Dim strMenuNm As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdDeleteMenu = CNL1920.FuncResult.UnusualEnd

        '------------------------------
        ' 対象メニューＩＤ取得
        '------------------------------
        strMenuID = LF_GetMenuGrpCD(pNode)
        strMenuNm = Trim$(pNode.Text)

        If GF_Msg("", Replace(GF_GetMsg("Q05"), "@@@", strMenuNm), MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            If GF_Msg("A01", "", MsgBoxStyle.YesNo, MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                strSQL = ""
                strSQL = strSQL & "DELETE FROM TPM170"
                strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"
                If Not GF_UpdData(strSQL) Then
                    Exit Function
                End If

                '--- メニュー画像用テーブルも ------------------------------------------
                strSQL = ""
                strSQL = strSQL & "DELETE FROM TPM150"
                strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"
                If Not GF_UpdData(strSQL) Then
                    Exit Function
                End If

            Else
                LF_UpdDeleteMenu = CNL1920.FuncResult.CancelEnd
                Exit Function
            End If
        Else
            LF_UpdDeleteMenu = CNL1920.FuncResult.CancelEnd
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdDeleteMenu = CNL1920.FuncResult.NormalEnd

    End Function

    Private Sub Mstyle_Chage(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_Pat.SelectionChangeCommitted, cbo_Style.SelectionChangeCommitted, chk_Price.Click, chk_ShowGenr.Click

        If IsNothing(trv_Menu.SelectedNode) Then Exit Sub

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

    Private Sub btn_MenuPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MenuPic.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objForm As New CNL1710()
        Dim i As Integer

        '------------------------------
        ' メニュー画像作成画面表示
        '------------------------------
        i = cbo_Pat.SelectedIndex
        objForm.G_Code = ""
        objForm.G_Menu = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
        Me.Enabled = False
        If objForm.ShowDialog = DialogResult.Yes Then
            L_blnEditFlg = True
        End If
        Me.Enabled = True

        LF_SetCbo_Pat(LF_GetMenuGrpCD(trv_Menu.SelectedNode), CStr(i))

    End Sub
    Private Function LF_SetCbo_Pat(ByVal pMenuID As String, Optional ByVal pstrCode As String = "0") As Object

        LF_SetCbo_Pat = Nothing

        '--- メニュー画像が存在するかチェック -----------------------------

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        strSQL = ""
        strSQL = strSQL & "SELECT * FROM TPM150"
        strSQL = strSQL & " WHERE MENUID = '" & pMenuID & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        cbo_Pat.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_Pat.Items.Clear()
        Call GS_CboItemSet(cbo_Pat, "商品ジャンルを表示", LC_PAT_GENR)
        Call GS_CboItemSet(cbo_Pat, "ネタケースを表示", LC_PAT_NETA)
        Call GS_CboItemSet(cbo_Pat, "商品一覧を直接表示", LC_PAT_DIRC)
        If objData.Tables("com").Rows.Count > 0 Then
            Call GS_CboItemSet(cbo_Pat, "メニュー画像を表示", "3")
        End If
        Call GS_CboChgSel(cbo_Pat, Trim$(pstrCode))


    End Function

    Private Sub LS_CourseFormInitialize(Optional ByVal pMode As Boolean = True)

        '--------------------------------------------
        ' コースメニュー登録画面初期処理
        '--------------------------------------------

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If pMode Then
            If Not GF_BeginTrans() Then
                Exit Sub
            End If
        End If
        L_blnEditFlg = False

        '--- 表示領域初期化 ---------------------------------------------------
        lbl_ItemCode.Text = ""
        lbl_ItemNMJ.Text = ""
        txt_TPGoodsNM.Text = ""
        txt_TPGoodsNM2.Text = ""
        lbl_KCP1.Text = ""
        lbl_KCP2.Text = ""
        lbl_KCP3.Text = ""
        txt_SelRow.Visible = False
        txt_SelRow.Clear()
        cmb_Bumon.Text = ""
        cmb_DispMenu.Text = ""
        cmb_DrinkMenu.Text = ""

        '* 単価
        L_PriceEdit = GF_GetAppInfo("PRICE_EDIT")
        If Len(Trim$(L_PriceEdit)) = 0 Then
            L_PriceEdit = GC_FALSE
        End If
        With txt_Price
            .Clear()
            .ImeMode = ImeMode.Disable
            .ReadOnly = IIf(L_PriceEdit = GC_TRUE, False, True)
            .ContextMenu = New ContextMenu()                            ' 右クリックメニュー表示禁止対策
        End With
        '* HTL名称
        If GF_GetAppInfo("HTLNMUSE") = GC_TRUE Then
            Label24.Visible = True
            Label32.Visible = True
            txt_HTLNM1.Visible = True
            txt_HTLNM2.Visible = True
        Else
            Label24.Visible = False
            Label32.Visible = False
            txt_HTLNM1.Visible = False
            txt_HTLNM2.Visible = False
        End If
        '* KCP印字商品名
        If GF_GetAppInfo("KCPUSE") = GC_TRUE Then
            Label23.Visible = True
            txt_GoodsNMJ4.Visible = True
        Else
            Label23.Visible = False
            txt_GoodsNMJ4.Visible = False
        End If

        Label20.Text = "セット" & GF_GetAppInfo("FREE_MENU_NM") & "メニュー"

        '--------------------------------------------
        ' 各コンボボックス作成
        '--------------------------------------------
        Call LF_SetBumonCmb()
        Call LF_SetDispMenuCmb()
        Call LF_SetDrikMenuCmb()

        '--------------------------------------------
        ' コースメニュー一覧表示
        '--------------------------------------------
        Call LS_CourseGridSetup()

    End Sub

    Private Sub LS_CourseGridSetup()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objTs As New DataGridTableStyle()                               ' 新しいDataGridTableStyleの作成
        Dim udtGridCol(18) As typGridColumn
        Dim lngCnt As Long
        Dim dtsData As New DataSet()
        Dim dtrRows As DataRow = Nothing
        Dim dtrData As DataRow = Nothing
        Dim dtsList As DataSet
        Dim objTable As DataTable
        Dim objRow As DataRow = Nothing

        Try
            '------------------------------
            ' テーブルスタイル定義
            '------------------------------
            With objTs
                .MappingName = "ITEMLIST"                                       ' マップ名を指定
                .PreferredRowHeight = 85                                       ' 標準行高を指定         2005.10.05
            End With

            '------------------------------
            ' 各項目属性定義
            '------------------------------
            With udtGridCol(0)
                .intType = CNL1920.COLUMN_TYPE.CHECK_STYLE
                .strMapName = "SELLFLG"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 20
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = False
            End With
            With udtGridCol(1)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSCD"
                .strHeadText = "商品番号"
                .blnAllowNull = False
                .lngWidth = 70
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(2)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSNM"
                .strHeadText = "商品名／ＫＣＰ番号"
                .blnAllowNull = False
                .lngWidth = 184
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With
            With udtGridCol(3)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "PRICE"
                .strHeadText = "単価"
                .blnAllowNull = False
                .lngWidth = 70
                .objAlign = HorizontalAlignment.Right
                .blnReadOnly = True
            End With
            With udtGridCol(4)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "DISPMENUNM"
                .strHeadText = "表示メニュー／" & GF_GetAppInfo("FREE_MENU_NM") & "セット"
                .blnAllowNull = False
                .lngWidth = 200
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With
            'With udtGridCol(5)
            '    .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            '    .strMapName = "FREEMENUNM"
            '    .strHeadText = "セット飲み放題メニュー"
            '    .blnAllowNull = False
            '    .lngWidth = 70
            '    .objAlign = HorizontalAlignment.Right
            '    .blnReadOnly = True
            'End With
            ' --- 以下、隠し項目 ---
            With udtGridCol(5)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "DISPMENUID"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Right
                .blnReadOnly = True
            End With
            With udtGridCol(6)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "FREEDRINKMENUID"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Right
                .blnReadOnly = True
            End With
            With udtGridCol(7)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "POS_ITEMNM"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(8)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "TP_ITEMNM"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(9)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "TP_ITEMNM2"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(10)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "KCP1"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(11)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "KCP2"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(12)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "KCP3"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(13)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "UPDFLG"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(14)
                .intType = CNL1920.COLUMN_TYPE.CHECK_STYLE
                .strMapName = "DISPKIND"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(15)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "HTL1"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(16)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "HTL2"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(17)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSNMJ4"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(18)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "BUMONCD"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With

            For lngCnt = 0 To UBound(udtGridCol)                                ' 各列定義をテーブルスタイルに追加
                Call GS_GridAddColumn(udtGridCol(lngCnt), objTs)
            Next
            objTs.AllowSorting = False                                          ' 列見出しクリックによるソートを禁止
            objTs.RowHeadersVisible = False

            With grd_Course
                .TableStyles.Clear()
                .TableStyles.Add(objTs)                                         ' テーブルスタイルをDataGridに追加
                '.ReadOnly = True                                                ' 編集禁止
                .ReadOnly = False                                               ' 編集禁止
            End With

            '------------------------------
            ' グリッド生成
            '------------------------------
            dtsList = New DataSet("ItemList")
            objTable = New DataTable("ITEMLIST")
            For lngCnt = 0 To UBound(udtGridCol)
                Call GS_GridAddTable(udtGridCol(lngCnt), objTable)
            Next

            '------------------------------
            ' データ値設定
            '------------------------------
            Call LF_SetCourseGridData(objTable, udtGridCol)

            dtsList.Tables.Add(objTable)                                        ' テーブルをDataSetに追加する

            Dim ds As DataSet = CType(dtsList, DataSet)
            Dim cm As CurrencyManager = CType(BindingContext(dtsList, "ItemList"), CurrencyManager)
            Dim dv As DataView = CType(cm.List, DataView)
            dv.AllowNew = False
            grd_Course.DataSource = dv                                    ' DataSetとテーブルをDataGridに接続する

            Dim objCell As DataGridCell
            objCell.ColumnNumber = 1
            objCell.RowNumber = 0
            grd_Course.CurrentCell = objCell
            L_CRow = grd_Course.CurrentCell.RowNumber

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_CourseGridSetup")
    End Sub

    Private Function LF_SetCourseGridData(ByVal pTable As DataTable, ByVal pGridCols() As typGridColumn) As Object

        LF_SetCourseGridData = Nothing

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objWRow As DataRow = Nothing
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strSQL As String
        Dim strOTKCP(2) As String
        Dim strWork As String
        Dim strKCP() As String
        Dim lngKCP As Long

        '------------------------------
        ' 設定データ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT DISTINCT(TPM010.GOODSCD),"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        strSQL = strSQL & "       TPM010.GOODSNMJ3,"
        strSQL = strSQL & "       TPM010.GOODSNMJ4,"
        strSQL = strSQL & "       TPM010.SELLFLG,"
        strSQL = strSQL & "       TPM010.PRICE,"
        strSQL = strSQL & "       TPM010.BUMONCD,"
        strSQL = strSQL & "       TPM010.KCPSTATUS,"
        strSQL = strSQL & "       TPM010.HTLNM1,"
        strSQL = strSQL & "       TPM010.HTLNM2,"
        strSQL = strSQL & "       TPM180.DISPMENUID,"
        '--- (2006.07.07)飲み放題メニュー未登録時、コースメニュー一覧が画面表示されないバグの対応 ---
        'strSQL = strSQL & "       ISNULL((SELECT DISTINCT(TPM060.MENUNM) FROM TPM060 WHERE TPM060.MENUID = TPM180.DISPMENUID),' ') AS DISPMENUNM,"
        strSQL = strSQL & "       ISNULL(TPM060.MENUNM,' ') AS DISPMENUNM,"
        '--------------------------------------------------------------------------------------------
        strSQL = strSQL & "       TPM180.FREEDRINKMENUID,"
        '--- (2006.07.07)飲み放題メニュー未登録時、コースメニュー一覧が画面表示されないバグの対応 ---
        'strSQL = strSQL & "       ISNULL((SELECT DISTINCT(TPM170.MENUNM) FROM TPM170 WHERE TPM170.MENUID = TPM180.FREEDRINKMENUID),' ') AS FREEMENUNM,"
        strSQL = strSQL & "       ISNULL(TPM170.MENUNM,' ') AS FREEMENUNM,"
        '--------------------------------------------------------------------------------------------
        strSQL = strSQL & "       '1' AS DUMMYCD"
        '--- (2006.07.07)飲み放題メニュー未登録時、コースメニュー一覧が画面表示されないバグの対応 ---
        'strSQL = strSQL & "  FROM TPM010,TPM180, TPM170, TPM060"
        strSQL = strSQL & "  FROM TPM010,TPM180"
        strSQL = strSQL & "       LEFT JOIN TPM060 ON TPM180.DISPMENUID = TPM060.MENUID"
        strSQL = strSQL & "       LEFT JOIN TPM170 ON TPM180.FREEDRINKMENUID = TPM170.MENUID"
        '--------------------------------------------------------------------------------------------
        strSQL = strSQL & " WHERE TPM010.GOODSCD = TPM180.GOODSCD"
        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            '------------------------------
            ' メニューテーブルオープン
            '------------------------------
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objWRow) Then
                    Exit Function
                End If

                objRows = pTable.NewRow
                objRows(pGridCols(0).strMapName) = IIf(Trim$(objWRow("SELLFLG")) = GC_TRUE, True, False)
                objRows(pGridCols(1).strMapName) = objWRow("GOODSCD")
                objRows(pGridCols(3).strMapName) = Format$(CLng(Trim$(objWRow("PRICE"))), "#,##0")
                'objRows(pGridCols(4).strMapName) = Trim$(objWRow("DISPMENUNM"))
                'objRows(pGridCols(5).strMapName) = Trim$(objWRow("FREEMENUNM"))
                objRows(pGridCols(4).strMapName) = LF_EditMenuNM(RTrim$(objWRow("DISPMENUNM")), RTrim$(objWRow("FREEMENUNM")))

                objRows(pGridCols(5).strMapName) = Trim$(objWRow("DISPMENUID"))
                objRows(pGridCols(6).strMapName) = Trim$(objWRow("FREEDRINKMENUID"))
                objRows(pGridCols(7).strMapName) = RTrim$(objWRow("GOODSNMJ3"))
                objRows(pGridCols(8).strMapName) = RTrim$(objWRow("GOODSNMJ"))
                objRows(pGridCols(9).strMapName) = RTrim$(objWRow("GOODSNMJ2"))
                objRows(pGridCols(10).strMapName) = Trim$(objWRow("KCPSTATUS"))
                objRows(pGridCols(11).strMapName) = ""
                objRows(pGridCols(12).strMapName) = ""
                objRows(pGridCols(13).strMapName) = GC_FALSE
                objRows(pGridCols(14).strMapName) = IIf(Trim$(objWRow("SELLFLG")) = GC_TRUE, True, False)
                objRows(pGridCols(15).strMapName) = RTrim$(objWRow("HTLNM1"))
                objRows(pGridCols(16).strMapName) = RTrim$(objWRow("HTLNM2"))
                objRows(pGridCols(17).strMapName) = RTrim$(objWRow("GOODSNMJ4"))
                objRows(pGridCols(18).strMapName) = RTrim$(objWRow("BUMONCD"))

                Erase strOTKCP
                ReDim strOTKCP(2)
                strWork = LF_GetKCPStat(Trim$(objWRow("KCPSTATUS")))
                If Len(Trim$(strWork)) <> 0 Then
                    strKCP = Split(strWork, ",")
                    For lngKCP = 0 To UBound(strKCP)
                        strOTKCP(lngKCP) = strKCP(lngKCP)
                    Next
                End If
                objRows(pGridCols(2).strMapName) = LF_ItemColEdit(RTrim$(objWRow("GOODSNMJ")), _
                                                                  RTrim$(objWRow("GOODSNMJ2")), _
                                                                  strOTKCP(0), _
                                                                  strOTKCP(1), _
                                                                  strOTKCP(2))

                pTable.Rows.Add(objRows)
                lngCnt = lngCnt + 1
            End While
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Function
SYSTEM_ERROR:
        Call GS_ErrorTerm("LF_SetCourseGridData")
    End Function

    Private Function LF_EditMenuNM(ByVal pDispMenuNM As String, ByVal pDrinkMenuNM As String) As String
        '** タッチパネル表示メニューと、セット飲み放題メニューをあわせて表示

        Dim strWork As String

        LF_EditMenuNM = ""

        strWork = ""
        strWork = strWork & RTrim$(pDispMenuNM) & vbCrLf
        If Trim$(pDrinkMenuNM) <> "" Then
            strWork = strWork & vbCrLf & vbCrLf & "[セット" & GF_GetAppInfo("FREE_MENU_NM") & "メニュー]" & vbCrLf
            strWork = strWork & Space(2) & RTrim$(pDrinkMenuNM)
        End If

        LF_EditMenuNM = strWork

    End Function

    Private Function LF_ItemColEdit(ByVal pTPNM As String, ByVal pTPNM2 As String, ByVal pKP1 As String, ByVal pKP2 As String, ByVal pKP3 As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strWork As String
        Dim strKCP(2) As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_ItemColEdit = ""
        strWork = ""
        strKCP(0) = Trim$(pKP1)
        strKCP(1) = Trim$(pKP2)
        strKCP(2) = Trim$(pKP3)

        '------------------------------
        ' 表示値編集
        '------------------------------
        strWork = strWork & RTrim$(pTPNM) & vbCrLf                           ' タッチパネル表示商品名
        strWork = strWork & RTrim$(pTPNM2) & vbCrLf
        If Len(strKCP(0)) <> 0 Then                                         ' ＫＣＰ出力№
            strWork = strWork & vbCrLf & "[KCP出力№]" & vbCrLf
            strWork = strWork & Space(2) & Format$(CLng(strKCP(0)), "00")
            If Len(strKCP(1)) <> 0 Then
                strWork = strWork & Space(1) & "/" & Space(1) & Format$(CLng(strKCP(1)), "00")
                If Len(strKCP(2)) <> 0 Then
                    strWork = strWork & Space(1) & "/" & Space(1) & Format$(CLng(strKCP(2)), "00")
                End If
            End If
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_ItemColEdit = strWork

    End Function

    Private Function LF_GetKCPStat(ByVal pStsBit As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strKCP(3) As String
        Dim lngI As Long
        Dim lngJ As Long
        Dim strRet() As String
        Dim lngCnt As Long

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetKCPStat = ""

        strKCP(0) = Mid$(pStsBit, 1, 8)
        strKCP(1) = Mid$(pStsBit, 9, 8)
        strKCP(2) = Mid$(pStsBit, 17, 8)
        strKCP(3) = Mid$(pStsBit, 25, 8)
        Erase strRet

        lngCnt = 0
        For lngI = 0 To 3
            For lngJ = 8 To 1 Step -1                                       ' --- (2003.12.09) 昇順出力対応 ---
                If Mid$(strKCP(lngI), lngJ, 1) = "1" Then
                    ReDim Preserve strRet(lngCnt)
                    strRet(lngCnt) = (8 - (lngJ - 1)) + (lngI * 8)
                    lngCnt = lngCnt + 1
                End If
            Next
        Next

        '------------------------------
        ' 返却値設定
        '------------------------------
        If Not IsNothing(strRet) Then
            For lngCnt = 0 To UBound(strRet)
                If lngCnt <> 0 Then
                    LF_GetKCPStat = LF_GetKCPStat & ","
                End If
                LF_GetKCPStat = LF_GetKCPStat & strRet(lngCnt)
            Next
        End If

    End Function

    Private Sub grd_Course_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_Course.CurrentCellChanged
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long

        '------------------------------
        ' 行選択状態制御
        '------------------------------
        Try
            With grd_Course
                If GF_GetRowCnt(grd_Course) < 0 Then Exit Sub

                For lngCnt = 0 To GF_GetRowCnt(grd_Course) - 1
                    .UnSelect(lngCnt)
                Next

                If Len(Trim$(txt_SelRow.Text)) <> 0 Then
                    If .CurrentCell.RowNumber <> CLng(txt_SelRow.Text) Then
                        ' L_CRow ＝ 前に選択されていた行番号
                        If grd_Course(CInt(txt_SelRow.Text), 0) <> grd_Course(CInt(txt_SelRow.Text), 14) Then
                            lngCnt = .CurrentCell.RowNumber

                            ' --- (2004.07.16) 行移動時のエラー発生を回避 --
                            .CurrentCell = New DataGridCell(CInt(txt_SelRow.Text), 0)
                            CType(BindingContext(grd_Course.DataSource), CurrencyManager).Position = CInt(txt_SelRow.Text)
                            ' ----------------------------------------------

                            grd_Course(CInt(txt_SelRow.Text), 13) = GC_TRUE
                            Debug.WriteLine("行:" & CInt(txt_SelRow.Text) & " / を更新")
                            L_blnEditFlg = True
                            Call LS_ShowCurrentItem(lngCnt)                 ' 選択行の内容を、入力領域へ転記する
                            .CurrentCell = New DataGridCell(lngCnt, 0)
                            .Select(lngCnt)
                        Else
                            Call LS_ShowCurrentItem(.CurrentCell.RowNumber) ' 選択行の内容を、入力領域へ転記する
                            .CurrentCell = New DataGridCell(.CurrentCell.RowNumber, 0)
                            .Select(.CurrentCell.RowNumber)
                        End If
                    Else
                        Call LS_ShowCurrentItem(.CurrentCell.RowNumber)     ' 選択行の内容を、入力領域へ転記する
                        .CurrentCell = New DataGridCell(.CurrentCell.RowNumber, 0)
                        .Select(.CurrentCell.RowNumber)
                    End If
                Else
                    Call LS_ShowCurrentItem(.CurrentCell.RowNumber)         ' 選択行の内容を、入力領域へ転記する
                    .CurrentCell = New DataGridCell(.CurrentCell.RowNumber, 0)
                    .Select(.CurrentCell.RowNumber)
                End If

            End With
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("grd_Course_CurrentCellChanged")
    End Sub

    Private Sub LS_ShowCurrentItem(ByVal pRow As Integer)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strWork() As String
        Dim strKPStat As String
        Dim lngKPCnt As Long

        Try
            lbl_ItemCode.Text = grd_Course(pRow, 1)
            lbl_ItemNMJ.Text = grd_Course(pRow, 7)
            txt_Price.Text = Format$(CLng(grd_Course(pRow, 3)), "#,##0") & "円"

            lbl_KCP1.Text = ""
            lbl_KCP2.Text = ""
            lbl_KCP3.Text = ""
            strKPStat = LF_GetKCPStat(grd_Course(pRow, 10))
            lngKPCnt = 0
            If Len(Trim$(strKPStat)) <> 0 Then
                strWork = Split(strKPStat, ",")
                For lngKPCnt = 0 To UBound(strWork)
                    Select Case lngKPCnt
                        Case 0
                            lbl_KCP1.Text = strWork(lngKPCnt)
                        Case 1
                            lbl_KCP2.Text = strWork(lngKPCnt)
                        Case 2
                            lbl_KCP3.Text = strWork(lngKPCnt)
                        Case Is >= 3
                            Exit For
                    End Select
                Next
            Else
                lbl_KCP1.Text = ""
                lbl_KCP2.Text = ""
                lbl_KCP3.Text = ""
            End If

            txt_TPGoodsNM.Text = grd_Course(pRow, 8)
            txt_TPGoodsNM2.Text = grd_Course(pRow, 9)
            txt_HTLNM1.Text = grd_Course(pRow, 15)
            txt_HTLNM2.Text = grd_Course(pRow, 16)
            txt_GoodsNMJ4.Text = grd_Course(pRow, 17)
            Call GS_CboChgSel(cmb_Bumon, grd_Course(pRow, 18))
            Call GS_CboChgSel(cmb_DispMenu, grd_Course(pRow, 5))
            Call GS_CboChgSel(cmb_DrinkMenu, grd_Course(pRow, 6))

            txt_SelRow.Text = pRow

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_ShowCurrentItem")
    End Sub

    Private Function LF_SetBumonCmb() As Object

        LF_SetBumonCmb = Nothing

        '--- コースメニュー登録画面.部門コードコンボ作成

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim i As Integer

        cmb_Bumon.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_Bumon.Items.Clear()

        strSQL = ""
        strSQL = strSQL & "SELECT BUMONCD, BUMONNM"
        strSQL = strSQL & "  FROM TPM110"
        strSQL = strSQL & " ORDER BY BUMONCD"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count > 0 Then
            For i = 0 To objData.Tables("com").Rows.Count - 1
                If Not GF_GetRows(objData, i, objRow) Then
                    Exit Function
                End If

                cmb_Bumon.Items.Add(objRow("BUMONNM") & Space(100) & vbTab & Trim$(objRow("BUMONCD")))

            Next
        End If

    End Function

    Private Function LF_SetDispMenuCmb() As Object

        LF_SetDispMenuCmb = Nothing

        '-- コースメニュー登録画面.タッチパネル表示メニューコンボ作成

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim i As Integer

        cmb_DispMenu.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_DispMenu.Items.Clear()

        strSQL = ""
        strSQL = strSQL & "SELECT DISTINCT(MENUID), MENUNM"
        strSQL = strSQL & "  FROM TPM060"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count > 0 Then
            For i = 0 To objData.Tables("com").Rows.Count - 1
                If Not GF_GetRows(objData, i, objRow) Then
                    Exit Function
                End If

                cmb_DispMenu.Items.Add(objRow("MENUNM") & Space(100) & vbTab & Trim$(objRow("MENUID")))

            Next
        End If

    End Function

    Private Function LF_SetDrikMenuCmb() As Object

        LF_SetDrikMenuCmb = Nothing

        '-- コースメニュー登録画面.セット飲み放題メニューコンボ作成

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim i As Integer

        cmb_DrinkMenu.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_DrinkMenu.Items.Clear()
        cmb_DrinkMenu.Items.Add("-- なし --" & Space(100) & vbTab & "000")

        strSQL = ""
        strSQL = strSQL & "SELECT DISTINCT(MENUID), MENUNM"
        strSQL = strSQL & "  FROM TPM170"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count > 0 Then
            For i = 0 To objData.Tables("com").Rows.Count - 1
                If Not GF_GetRows(objData, i, objRow) Then
                    Exit Function
                End If

                cmb_DrinkMenu.Items.Add(objRow("MENUNM") & Space(100) & vbTab & Trim$(objRow("MENUID")))

            Next
        End If

    End Function
    Private Sub LS_WriteRetItemInfo(Optional ByVal pKCPStat As String = "")

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCell As DataGridCell = grd_Course.CurrentCell
        Dim strOpt(11) As String
        Dim strWork As String
        Dim strKCP() As String
        Dim strOTKCP(2) As String
        Dim lngKCP As Long

        If objCell.RowNumber = -1 Then Exit Sub
        If Len(Trim$(txt_SelRow.Text)) = 0 Or Not IsNumeric(txt_SelRow.Text) Then Exit Sub

        Try
            grd_Course(CInt(txt_SelRow.Text), 8) = txt_TPGoodsNM.Text
            grd_Course(CInt(txt_SelRow.Text), 9) = txt_TPGoodsNM2.Text
            If L_PriceEdit = GC_TRUE Then
                grd_Course(CInt(txt_SelRow.Text), 3) = Format$(CLng(Replace(Replace(txt_Price.Text, ",", ""), "円", "")), "###,##0")
            End If
            grd_Course(CInt(txt_SelRow.Text), 13) = GC_TRUE


            If Len(Trim$(pKCPStat)) <> 0 Then
                grd_Course(CInt(txt_SelRow.Text), 10) = pKCPStat
            End If
            strWork = LF_GetKCPStat(grd_Course(CInt(txt_SelRow.Text), 10))
            If Len(Trim$(strWork)) <> 0 Then
                strKCP = Split(strWork, ",")
                For lngKCP = 0 To UBound(strKCP)
                    strOTKCP(lngKCP) = strKCP(lngKCP)
                Next
            End If
            grd_Course(CInt(txt_SelRow.Text), 2) = LF_ItemColEdit(txt_TPGoodsNM.Text, _
                                                                    txt_TPGoodsNM2.Text, _
                                                                    strOTKCP(0), _
                                                                    strOTKCP(1), _
                                                                    strOTKCP(2))

            grd_Course(CInt(txt_SelRow.Text), 15) = txt_HTLNM1.Text
            grd_Course(CInt(txt_SelRow.Text), 16) = txt_HTLNM2.Text
            grd_Course(CInt(txt_SelRow.Text), 17) = txt_GoodsNMJ4.Text
            grd_Course(CInt(txt_SelRow.Text), 18) = GF_CboGetCode(cmb_Bumon, cmb_Bumon.SelectedIndex)
            grd_Course(CInt(txt_SelRow.Text), 4) = LF_EditMenuNM(GF_CboGetText(cmb_DispMenu, cmb_DispMenu.SelectedIndex), IIf(cmb_DrinkMenu.SelectedIndex <> 0, GF_CboGetText(cmb_DrinkMenu, cmb_DrinkMenu.SelectedIndex), ""))
            grd_Course(CInt(txt_SelRow.Text), 5) = GF_CboGetCode(cmb_DispMenu, cmb_DispMenu.SelectedIndex)
            grd_Course(CInt(txt_SelRow.Text), 6) = GF_CboGetCode(cmb_DrinkMenu, cmb_DrinkMenu.SelectedIndex)

            L_blnEditFlg = True
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_WriteRetItemInfo")
    End Sub

    Private Sub txt_Price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Price.TextChanged

        ' 数値のみ６桁まで入力可能とする制御を入れる

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngST As Long

        If txt_Price.Modified = False Then Exit Sub
        lngST = txt_Price.SelectionStart
        If lngST >= 0 Then txt_Price.SelectionStart = lngST

        '------------------------------
        ' 入力長制限
        '------------------------------
        If GF_LenB(txt_Price.Text) > 6 Then
            txt_Price.Text = GF_MidB(txt_Price.Text, 1, 6)
            txt_Price.SelectionStart = GF_LenB(txt_Price.Text)
            'Exit Sub
        End If


        If Len(Trim$(txt_Price.Text)) = 0 Then
            txt_Price.Text = "0"
        End If

        If IsNumeric(Trim$(txt_Price.Text)) = False Then
            txt_Price.Text = "0"
        End If

        Call LS_WriteRetItemInfo()

    End Sub
    Private Sub txt_Price_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Price.Enter

        ' カンマ及び、"円"文字を長さ０の文字列にReplaceする
        txt_Price.Text = Replace(txt_Price.Text, ",", "")
        txt_Price.Text = Replace(txt_Price.Text, "円", "")

    End Sub

    Private Sub txt_Price_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Price.Leave

        If IsNumeric(Trim$(txt_Price.Text)) = False Then
            GF_Msg("", "金額は数字のみを入力してください", MsgBoxStyle.OKOnly)
            Exit Sub
        End If

        ' カンマ編集＋"円"文字の付加編集を行う
        txt_Price.Text = Format$(CLng(Trim$(txt_Price.Text)), "###,##0") & "円"

    End Sub

    Private Sub txt_Price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Price.KeyPress
        If Len(txt_Price.Text) >= 6 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_TPGoodsNM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TPGoodsNM.TextChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngST As Long

        If txt_TPGoodsNM.Modified = False Then Exit Sub
        lngST = txt_TPGoodsNM.SelectionStart
            ' 2014-05-12 2バイト文字制限解除
        'txt_TPGoodsNM.Text = StrConv(txt_TPGoodsNM.Text, VbStrConv.Wide)
        If lngST >= 0 Then txt_TPGoodsNM.SelectionStart = lngST

        '------------------------------
        ' 入力長制限
        '------------------------------
        If GF_LenB(txt_TPGoodsNM.Text) > 20 Then
            txt_TPGoodsNM.Text = GF_MidB(txt_TPGoodsNM.Text, 1, 20)
            txt_TPGoodsNM.SelectionStart = GF_LenB(txt_TPGoodsNM.Text)
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub txt_TPGoodsNM2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TPGoodsNM2.TextChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngST As Long

        If txt_TPGoodsNM2.Modified = False Then Exit Sub
        lngST = txt_TPGoodsNM2.SelectionStart
            ' 2014-05-12 2バイト文字制限解除
        'txt_TPGoodsNM2.Text = StrConv(txt_TPGoodsNM2.Text, VbStrConv.Wide)
        If lngST >= 0 Then txt_TPGoodsNM2.SelectionStart = lngST

        '------------------------------
        ' 入力長制限
        '------------------------------
        If GF_LenB(txt_TPGoodsNM2.Text) > 20 Then
            txt_TPGoodsNM2.Text = GF_MidB(txt_TPGoodsNM2.Text, 1, 20)
            txt_TPGoodsNM2.SelectionStart = GF_LenB(txt_TPGoodsNM2.Text)
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub txt_HTLNM1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_HTLNM1.TextChanged
        If txt_HTLNM1.Modified = False Then Exit Sub

        '------------------------------
        ' 入力長制限
        '------------------------------
        If GF_LenB(txt_HTLNM1.Text) > 5 Then
            txt_HTLNM1.Text = GF_MidB(txt_HTLNM1.Text, 1, 5)
            txt_HTLNM1.SelectionStart = GF_LenB(txt_HTLNM1.Text)
        End If

        Call LS_WriteRetItemInfo()
    End Sub
    Private Sub txt_HTLNM2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_HTLNM2.TextChanged
        If txt_HTLNM2.Modified = False Then Exit Sub

        If GF_LenB(txt_HTLNM2.Text) > 5 Then
            txt_HTLNM2.Text = GF_MidB(txt_HTLNM2.Text, 1, 5)
            txt_HTLNM2.SelectionStart = GF_LenB(txt_HTLNM2.Text)
        End If

        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub txt_GoodsNMJ4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GoodsNMJ4.TextChanged
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngST As Long

        If txt_GoodsNMJ4.Modified = False Then Exit Sub
        lngST = txt_GoodsNMJ4.SelectionStart
            ' 2014-05-12 2バイト文字制限解除
        'txt_GoodsNMJ4.Text = StrConv(txt_GoodsNMJ4.Text, VbStrConv.Wide)
        If lngST >= 0 Then txt_GoodsNMJ4.SelectionStart = lngST

        '------------------------------
        ' 入力長制限
        '------------------------------
        If GF_LenB(txt_GoodsNMJ4.Text) > 20 Then
            txt_GoodsNMJ4.Text = GF_MidB(txt_GoodsNMJ4.Text, 1, 20)
            txt_GoodsNMJ4.SelectionStart = GF_LenB(txt_GoodsNMJ4.Text)
        End If

        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub cmb_DispMenu_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_DispMenu.SelectionChangeCommitted
        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub cmb_DrinkMenu_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_DrinkMenu.SelectionChangeCommitted
        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub cmb_Bumon_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Bumon.SelectionChangeCommitted
        Call LS_WriteRetItemInfo()
    End Sub

    Private Function LF_UpdTPM010() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim lngCnt As Long

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM010 = False

        '------------------------------
        ' 更新処理
        '------------------------------
        With grd_Course
            For lngCnt = 0 To GF_GetRowCnt(grd_Course) - 1
                If grd_Course(lngCnt, 13) = GC_TRUE Then                   ' 変更のかかった行のみ更新対象とする

                    strSQL = ""
                    strSQL = strSQL & "UPDATE TPM010"
                    If Len(Trim$(grd_Course(lngCnt, 8))) = 0 Then
                        strSQL = strSQL & "   SET TPM010.GOODSNMJ  = '" & RTrim$(grd_Course(lngCnt, 7)) & "',"
                    Else
                        strSQL = strSQL & "   SET TPM010.GOODSNMJ  = '" & RTrim$(grd_Course(lngCnt, 8)) & "',"
                    End If

                    If Len(Trim$(grd_Course(lngCnt, 9))) = 0 Then
                        strSQL = strSQL & "       TPM010.GOODSNMJ2 = '" & Space(1) & "',"
                    Else
                        strSQL = strSQL & "       TPM010.GOODSNMJ2 = '" & RTrim$(grd_Course(lngCnt, 9)) & "',"
                    End If

                    ' --- (2004.02.09) 単価訂正機能追加 --------------------
                    If L_PriceEdit = GC_TRUE Then
                        strSQL = strSQL & "       TPM010.PRICE     = '" & Replace(Trim$(grd_Course(lngCnt, 3)), ",", "") & "',"
                    End If
                    ' ------------------------------------------------------

                    strSQL = strSQL & "       TPM010.SELLFLG   = '" & IIf(grd_Course(lngCnt, 0) = True, GC_TRUE, GC_FALSE) & "',"

                    strSQL = strSQL & "       TPM010.GENERATEFLG = '" & GC_TRUE & "',"

                    strSQL = strSQL & "       TPM010.KCPSTATUS   = '" & Trim$(grd_Course(lngCnt, 10)) & "',"

                    strSQL = strSQL & "       TPM010.HTLNM1 = '" & GF_RepQuo(grd_Course(lngCnt, 15)) & "',"
                    strSQL = strSQL & "       TPM010.HTLNM2 = '" & GF_RepQuo(grd_Course(lngCnt, 16)) & "',"

                    strSQL = strSQL & "       TPM010.GOODSNMJ4   = '" & GF_RepQuo(grd_Course(lngCnt, 17)) & "',"

                    strSQL = strSQL & "       TPM010.BUMONCD  = '" & GF_RepQuo(grd_Course(lngCnt, 18)) & "',"

                    strSQL = strSQL & "       TPM010.UPDID     = '" & GC_UPDID & "',"
                    strSQL = strSQL & "       TPM010.UPDYMD    = '" & Now & "'"
                    strSQL = strSQL & " WHERE TPM010.GOODSCD   = '" & grd_Course(lngCnt, 1) & "'"

                    If Not GF_UpdData(strSQL) Then
                        Exit Function
                    End If

                End If
            Next

        End With

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM010 = True

    End Function

    Private Function LF_UpdTPM180() As Boolean

        Dim strSQL As String
        Dim lngCnt As Long

        LF_UpdTPM180 = False

        With grd_Course
            For lngCnt = 0 To GF_GetRowCnt(grd_Course) - 1
                If grd_Course(lngCnt, 13) = GC_TRUE Then                   ' 変更のかかった行のみ更新対象とする

                    If RTrim$(grd_Course(lngCnt, 5)) = "000" Then

                        'タッチパネル表示メニューが未設定の場合、確認メッセージを表示し、
                        GF_Msg("", RTrim$("【" & grd_Course(lngCnt, 8)) & "】はタッチパネル表示メニューが設定されていないため、保存されません。", MsgBoxStyle.OKOnly)

                    Else

                        strSQL = ""
                        strSQL = strSQL & "UPDATE TPM180"
                        strSQL = strSQL & "   SET TPM180.DISPMENUID      = '" & RTrim$(grd_Course(lngCnt, 5)) & "',"
                        strSQL = strSQL & "       TPM180.FREEDRINKMENUID = '" & RTrim$(grd_Course(lngCnt, 6)) & "',"
                        strSQL = strSQL & "       TPM180.UPDID           = '" & GC_UPDID & "',"
                        strSQL = strSQL & "       TPM180.UPDYMD          = '" & Now & "'"
                        strSQL = strSQL & " WHERE TPM180.GOODSCD         = '" & grd_Course(lngCnt, 1) & "'"

                        If Not GF_UpdData(strSQL) Then
                            Exit Function
                        End If
                    End If

                End If

            Next

        End With

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM180 = True

    End Function

    Private Sub btn_KPSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_KPSet.Click
        Dim objForm As New CNL1533()

        With objForm
            .StartPosition = FormStartPosition.CenterParent
            .FormBorderStyle = FormBorderStyle.FixedDialog
            .ShowInTaskbar = False
            .MaximizeBox = False
            .MinimizeBox = False
            .ControlBox = False
            .MaximumSize = .Size
            .G_KCPStatus = grd_Course(CLng(txt_SelRow.Text), 10)
            If .ShowDialog() = DialogResult.OK Then
                Call LS_WriteRetItemInfo(.G_KCPStatus)
                Call LS_ShowCurrentItem(CInt(txt_SelRow.Text))
            End If
        End With
    End Sub

    Private Sub trv_Menu_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trv_Menu.AfterCheck
        ''CheckBox 状態変更

        Dim strSQL As String

        If L_ProcFlg Then Exit Sub
        If IsNothing(e.Node) Then Exit Sub

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM170"
        strSQL = strSQL & "   SET ENABLED = '" & IIf(e.Node.Checked = True, 1, 0) & "',"
        strSQL = strSQL & "       UPDID   = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD  = '" & Now & "'"
        strSQL = strSQL & " WHERE MENUID  = '" & LF_GetMenuGrpCD(e.Node) & "'"

        If Not GF_UpdData(strSQL) Then
            Exit Sub
        End If

        L_blnEditFlg = True

    End Sub

    Private Sub btn_Corse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Corse.Click

        '*** 新しいコースメニューを作る **********************************

        Dim objForm As Form = Nothing

        objForm = New CNL1583()

        objForm.ShowDialog()
        Select Case objForm.DialogResult
            Case DialogResult.OK
                Call LS_CourseFormInitialize(False)
                L_blnEditFlg = True
            Case DialogResult.Cancel
                ' 何もしない
            Case Else
                GoTo SYSTEM_ERROR
        End Select

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Corse_Click")
    End Sub

    Private Sub LS_CommitCheck()

        Dim objCell As DataGridCell
        Dim lngCnt As Long

        lngCnt = grd_Course.CurrentCell.RowNumber
        If lngCnt = 0 Or lngCnt <> (GF_GetRowCnt(grd_Course) - 1) Then
            objCell.RowNumber = GF_GetRowCnt(grd_Course) - 1
        Else
            objCell.RowNumber = 0
        End If
        objCell.ColumnNumber = 7
        grd_Course.CurrentCell = objCell

        With objCell
            .ColumnNumber = 7
            .RowNumber = lngCnt
        End With
        grd_Course.CurrentCell = objCell

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：金額設定データ存在有無チェック処理
    ' 　機能概要：金額が設定されている商品データを飲み放題として設定できないようにする
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2008.01.29 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_ErrDataExist() As Integer

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_ErrDataExist = 0

        '------------------------------
        ' システム管理マスタ検索
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT * "
        strSQL = strSQL & "  FROM TPM010,TPM020,TPM170 "
        strSQL = strSQL & " WHERE TPM010.GOODSCD = TPM020.GOODSCD "
        strSQL = strSQL & "   AND TPM020.GROUPCD = TPM170.GROUPCD "
        strSQL = strSQL & "   AND TPM010.PRICE <> '0' "
        strSQL = strSQL & "   AND TPM010.SELLFLG = '0' "
        strSQL = strSQL & "   AND TPM020.GOODSCD <> '0000' "
        strSQL = strSQL & "   AND TPM170.GROUPCD <> '0000' "
        strSQL = strSQL & "ORDER BY TPM010.GOODSCD"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_ErrDataExist = objData.Tables("com").Rows.Count

    End Function

End Class
