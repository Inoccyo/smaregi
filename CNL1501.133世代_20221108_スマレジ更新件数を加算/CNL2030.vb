' --------------------------------------------------------------------------------
' 　機　　能：CrossNavi - 商品配置画面
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
' --------------------------------------------------------------------------------

Public Class CNL2030
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageList3 As System.Windows.Forms.ImageList
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents lsv_ItemList As System.Windows.Forms.ListView
    Friend WithEvents lsv_MenuGrp As System.Windows.Forms.ListView
    Friend WithEvents txt_MenuTitle As System.Windows.Forms.TextBox
    Friend WithEvents trv_Menu As System.Windows.Forms.TreeView
    Friend WithEvents lst_TreeKey As System.Windows.Forms.ListBox
    Friend WithEvents lst_MenuGrp As System.Windows.Forms.ListBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbo_Style As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Dwn As System.Windows.Forms.Button
    Friend WithEvents btn_Up As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_MenuAdd As System.Windows.Forms.Button
    Friend WithEvents btn_MenuDel As System.Windows.Forms.Button
    Friend WithEvents btn_GrpDel As System.Windows.Forms.Button
    Friend WithEvents btn_GrpAdd As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_DelImg As System.Windows.Forms.Button
    Friend WithEvents pic_Img As System.Windows.Forms.PictureBox
    Friend WithEvents btn_SelImg As System.Windows.Forms.Button
    Friend WithEvents txt_ImagePath As System.Windows.Forms.TextBox
    Friend WithEvents chk_SpFlg As System.Windows.Forms.CheckBox
    Friend WithEvents tab_Items As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txt_MenuTitle_A As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_MenuTitle_B As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents pic_img_A As System.Windows.Forms.PictureBox
    Friend WithEvents btn_DelImg_A As System.Windows.Forms.Button
    Friend WithEvents btn_SelImg_A As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pic_img_B As System.Windows.Forms.PictureBox
    Friend WithEvents btn_DelImg_B As System.Windows.Forms.Button
    Friend WithEvents btn_SelImg_B As System.Windows.Forms.Button
    Friend WithEvents txt_ImagePath_C As System.Windows.Forms.TextBox
    Friend WithEvents txt_ImagePath_B As System.Windows.Forms.TextBox
    Friend WithEvents txt_ImagePath_A As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents pic_img_C As System.Windows.Forms.PictureBox
    Friend WithEvents btn_DelImg_C As System.Windows.Forms.Button
    Friend WithEvents btn_SelImg_C As System.Windows.Forms.Button
    Friend WithEvents txt_MenuTitle_C As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbo_Pat As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CNL2030))
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"にぎり"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ドリンク"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"おすすめ"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ジャンルＡ"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ジャンルＢ"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ジャンルＣ"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem22 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"一二〇円"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem23 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"一六〇円"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem24 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"二〇〇円"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem25 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"二四〇円"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem26 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"二八〇円"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem27 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"三二〇円"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem28 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"四〇〇円"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem29 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"四八〇円"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem30 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"五六〇円"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("握り鮨")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("細・中巻き")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("手巻き")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("一品料理")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ドリンク")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("未設定")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("未設定")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("未設定")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ノード0")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ノード1")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("メニュー１", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21})
        Me.Label3 = New System.Windows.Forms.Label
        Me.lsv_ItemList = New System.Windows.Forms.ListView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lsv_MenuGrp = New System.Windows.Forms.ListView
        Me.txt_MenuTitle = New System.Windows.Forms.TextBox
        Me.stb_Msg = New System.Windows.Forms.StatusBar
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.trv_Menu = New System.Windows.Forms.TreeView
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.lst_TreeKey = New System.Windows.Forms.ListBox
        Me.lst_MenuGrp = New System.Windows.Forms.ListBox
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.tab_Items = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btn_DelImg = New System.Windows.Forms.Button
        Me.pic_Img = New System.Windows.Forms.PictureBox
        Me.btn_SelImg = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chk_SpFlg = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbo_Style = New System.Windows.Forms.ComboBox
        Me.cbo_Pat = New System.Windows.Forms.ComboBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.pic_img_A = New System.Windows.Forms.PictureBox
        Me.btn_DelImg_A = New System.Windows.Forms.Button
        Me.btn_SelImg_A = New System.Windows.Forms.Button
        Me.txt_MenuTitle_A = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.pic_img_B = New System.Windows.Forms.PictureBox
        Me.btn_DelImg_B = New System.Windows.Forms.Button
        Me.btn_SelImg_B = New System.Windows.Forms.Button
        Me.txt_MenuTitle_B = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.pic_img_C = New System.Windows.Forms.PictureBox
        Me.btn_DelImg_C = New System.Windows.Forms.Button
        Me.btn_SelImg_C = New System.Windows.Forms.Button
        Me.txt_MenuTitle_C = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_ImagePath = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_Search = New System.Windows.Forms.TextBox
        Me.btn_GrpDel = New System.Windows.Forms.Button
        Me.btn_GrpAdd = New System.Windows.Forms.Button
        Me.btn_MenuDel = New System.Windows.Forms.Button
        Me.btn_MenuAdd = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.btn_Dwn = New System.Windows.Forms.Button
        Me.btn_Up = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_ImagePath_A = New System.Windows.Forms.TextBox
        Me.txt_ImagePath_B = New System.Windows.Forms.TextBox
        Me.txt_ImagePath_C = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.tab_Items.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pic_Img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pic_img_A, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic_img_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.pic_img_C, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(613, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 24)
        Me.Label3.TabIndex = 174
        Me.Label3.Text = "● 商品一覧"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lsv_ItemList
        '
        Me.lsv_ItemList.AllowDrop = True
        Me.lsv_ItemList.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ListViewItem16.StateImageIndex = 0
        ListViewItem17.StateImageIndex = 0
        ListViewItem18.StateImageIndex = 0
        ListViewItem19.StateImageIndex = 0
        ListViewItem20.StateImageIndex = 0
        ListViewItem21.StateImageIndex = 0
        Me.lsv_ItemList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem16, ListViewItem17, ListViewItem18, ListViewItem19, ListViewItem20, ListViewItem21})
        Me.lsv_ItemList.Location = New System.Drawing.Point(616, 391)
        Me.lsv_ItemList.Name = "lsv_ItemList"
        Me.lsv_ItemList.Size = New System.Drawing.Size(392, 265)
        Me.lsv_ItemList.TabIndex = 10
        Me.lsv_ItemList.UseCompatibleStateImageBehavior = False
        Me.lsv_ItemList.View = System.Windows.Forms.View.Details
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'lsv_MenuGrp
        '
        Me.lsv_MenuGrp.AllowDrop = True
        Me.lsv_MenuGrp.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ListViewItem22.StateImageIndex = 0
        ListViewItem23.StateImageIndex = 0
        ListViewItem24.StateImageIndex = 0
        ListViewItem25.StateImageIndex = 0
        ListViewItem26.StateImageIndex = 0
        ListViewItem27.StateImageIndex = 0
        ListViewItem28.StateImageIndex = 0
        ListViewItem29.StateImageIndex = 0
        ListViewItem30.StateImageIndex = 0
        Me.lsv_MenuGrp.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem22, ListViewItem23, ListViewItem24, ListViewItem25, ListViewItem26, ListViewItem27, ListViewItem28, ListViewItem29, ListViewItem30})
        Me.lsv_MenuGrp.Location = New System.Drawing.Point(207, 391)
        Me.lsv_MenuGrp.Name = "lsv_MenuGrp"
        Me.lsv_MenuGrp.Size = New System.Drawing.Size(392, 265)
        Me.lsv_MenuGrp.TabIndex = 2
        Me.lsv_MenuGrp.UseCompatibleStateImageBehavior = False
        Me.lsv_MenuGrp.View = System.Windows.Forms.View.Details
        '
        'txt_MenuTitle
        '
        Me.txt_MenuTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_MenuTitle.Location = New System.Drawing.Point(3, 30)
        Me.txt_MenuTitle.Name = "txt_MenuTitle"
        Me.txt_MenuTitle.Size = New System.Drawing.Size(351, 22)
        Me.txt_MenuTitle.TabIndex = 4
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 665)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(1016, 24)
        Me.stb_Msg.TabIndex = 221
        Me.stb_Msg.Text = "StatusBar1"
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(6, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 24)
        Me.Label2.TabIndex = 243
        Me.Label2.Text = "メニュータイトル"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'trv_Menu
        '
        Me.trv_Menu.CheckBoxes = True
        Me.trv_Menu.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.trv_Menu.ImageIndex = 1
        Me.trv_Menu.ImageList = Me.ImageList3
        Me.trv_Menu.Indent = 25
        Me.trv_Menu.Location = New System.Drawing.Point(207, 86)
        Me.trv_Menu.Name = "trv_Menu"
        TreeNode12.Name = ""
        TreeNode12.Text = "握り鮨"
        TreeNode13.Name = ""
        TreeNode13.Text = "細・中巻き"
        TreeNode14.Name = ""
        TreeNode14.Text = "手巻き"
        TreeNode15.Name = ""
        TreeNode15.Text = "一品料理"
        TreeNode16.Name = ""
        TreeNode16.Text = "ドリンク"
        TreeNode17.Name = ""
        TreeNode17.Text = "未設定"
        TreeNode18.Name = ""
        TreeNode18.Text = "未設定"
        TreeNode19.Name = ""
        TreeNode19.Text = "未設定"
        TreeNode20.Name = ""
        TreeNode20.Text = "ノード0"
        TreeNode21.Name = ""
        TreeNode21.Text = "ノード1"
        TreeNode22.Name = ""
        TreeNode22.Text = "メニュー１"
        Me.trv_Menu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode22})
        Me.trv_Menu.SelectedImageIndex = 0
        Me.trv_Menu.Size = New System.Drawing.Size(392, 265)
        Me.trv_Menu.TabIndex = 1
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList3.Images.SetKeyName(0, "")
        Me.ImageList3.Images.SetKeyName(1, "")
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
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem4})
        Me.MenuItem1.Text = "商品配置"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "終了(&E)"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txt_ImagePath_C)
        Me.Panel1.Controls.Add(Me.txt_ImagePath_B)
        Me.Panel1.Controls.Add(Me.txt_ImagePath_A)
        Me.Panel1.Controls.Add(Me.tab_Items)
        Me.Panel1.Controls.Add(Me.txt_ImagePath)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_Search)
        Me.Panel1.Controls.Add(Me.btn_GrpDel)
        Me.Panel1.Controls.Add(Me.btn_GrpAdd)
        Me.Panel1.Controls.Add(Me.btn_MenuDel)
        Me.Panel1.Controls.Add(Me.btn_MenuAdd)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btn_Dwn)
        Me.Panel1.Controls.Add(Me.btn_Up)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lst_MenuGrp)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lsv_ItemList)
        Me.Panel1.Controls.Add(Me.trv_Menu)
        Me.Panel1.Controls.Add(Me.lst_TreeKey)
        Me.Panel1.Controls.Add(Me.lsv_MenuGrp)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 255
        '
        'tab_Items
        '
        Me.tab_Items.Controls.Add(Me.TabPage1)
        Me.tab_Items.Controls.Add(Me.TabPage2)
        Me.tab_Items.Controls.Add(Me.TabPage3)
        Me.tab_Items.Controls.Add(Me.TabPage4)
        Me.tab_Items.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tab_Items.ItemSize = New System.Drawing.Size(80, 22)
        Me.tab_Items.Location = New System.Drawing.Point(604, 76)
        Me.tab_Items.Name = "tab_Items"
        Me.tab_Items.SelectedIndex = 0
        Me.tab_Items.Size = New System.Drawing.Size(405, 284)
        Me.tab_Items.TabIndex = 294
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BackgroundImage = Global.CNL1501.My.Resources.Resources.back2
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.txt_MenuTitle)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(397, 254)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "商品配置"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.Add(Me.btn_DelImg)
        Me.GroupBox3.Controls.Add(Me.pic_Img)
        Me.GroupBox3.Controls.Add(Me.btn_SelImg)
        Me.GroupBox3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(197, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(190, 181)
        Me.GroupBox3.TabIndex = 294
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "画像設定"
        '
        'btn_DelImg
        '
        Me.btn_DelImg.BackColor = System.Drawing.SystemColors.Control
        Me.btn_DelImg.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_DelImg.Location = New System.Drawing.Point(132, 15)
        Me.btn_DelImg.Name = "btn_DelImg"
        Me.btn_DelImg.Size = New System.Drawing.Size(48, 24)
        Me.btn_DelImg.TabIndex = 5
        Me.btn_DelImg.Text = "解除"
        Me.btn_DelImg.UseVisualStyleBackColor = False
        '
        'pic_Img
        '
        Me.pic_Img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_Img.Location = New System.Drawing.Point(10, 45)
        Me.pic_Img.Name = "pic_Img"
        Me.pic_Img.Size = New System.Drawing.Size(168, 126)
        Me.pic_Img.TabIndex = 246
        Me.pic_Img.TabStop = False
        '
        'btn_SelImg
        '
        Me.btn_SelImg.BackColor = System.Drawing.SystemColors.Control
        Me.btn_SelImg.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_SelImg.Location = New System.Drawing.Point(78, 15)
        Me.btn_SelImg.Name = "btn_SelImg"
        Me.btn_SelImg.Size = New System.Drawing.Size(48, 24)
        Me.btn_SelImg.TabIndex = 4
        Me.btn_SelImg.Text = "選択"
        Me.btn_SelImg.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.chk_SpFlg)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cbo_Style)
        Me.GroupBox2.Controls.Add(Me.cbo_Pat)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(177, 181)
        Me.GroupBox2.TabIndex = 250
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "画面表示方法"
        '
        'chk_SpFlg
        '
        Me.chk_SpFlg.Image = CType(resources.GetObject("chk_SpFlg.Image"), System.Drawing.Image)
        Me.chk_SpFlg.Location = New System.Drawing.Point(11, 131)
        Me.chk_SpFlg.Name = "chk_SpFlg"
        Me.chk_SpFlg.Size = New System.Drawing.Size(152, 40)
        Me.chk_SpFlg.TabIndex = 4
        Me.chk_SpFlg.Text = "日替わり商品登録に表示"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(9, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 24)
        Me.Label5.TabIndex = 255
        Me.Label5.Text = "商品一覧画面"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.Location = New System.Drawing.Point(9, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(158, 24)
        Me.Label13.TabIndex = 254
        Me.Label13.Text = "グループ一覧画面"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbo_Style
        '
        Me.cbo_Style.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_Style.Location = New System.Drawing.Point(9, 98)
        Me.cbo_Style.Name = "cbo_Style"
        Me.cbo_Style.Size = New System.Drawing.Size(158, 23)
        Me.cbo_Style.TabIndex = 6
        '
        'cbo_Pat
        '
        Me.cbo_Pat.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_Pat.Location = New System.Drawing.Point(9, 44)
        Me.cbo_Pat.Name = "cbo_Pat"
        Me.cbo_Pat.Size = New System.Drawing.Size(158, 23)
        Me.cbo_Pat.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.BackgroundImage = Global.CNL1501.My.Resources.Resources.back2
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.txt_MenuTitle_A)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(397, 254)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = " 英 語"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = Global.CNL1501.My.Resources.Resources.back2
        Me.GroupBox4.Controls.Add(Me.pic_img_A)
        Me.GroupBox4.Controls.Add(Me.btn_DelImg_A)
        Me.GroupBox4.Controls.Add(Me.btn_SelImg_A)
        Me.GroupBox4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(197, 72)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(190, 181)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "画像設定"
        '
        'pic_img_A
        '
        Me.pic_img_A.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_img_A.ErrorImage = CType(resources.GetObject("pic_img_A.ErrorImage"), System.Drawing.Image)
        Me.pic_img_A.InitialImage = CType(resources.GetObject("pic_img_A.InitialImage"), System.Drawing.Image)
        Me.pic_img_A.Location = New System.Drawing.Point(10, 45)
        Me.pic_img_A.Name = "pic_img_A"
        Me.pic_img_A.Size = New System.Drawing.Size(168, 126)
        Me.pic_img_A.TabIndex = 2
        Me.pic_img_A.TabStop = False
        '
        'btn_DelImg_A
        '
        Me.btn_DelImg_A.BackColor = System.Drawing.SystemColors.Control
        Me.btn_DelImg_A.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_DelImg_A.Location = New System.Drawing.Point(132, 15)
        Me.btn_DelImg_A.Name = "btn_DelImg_A"
        Me.btn_DelImg_A.Size = New System.Drawing.Size(48, 24)
        Me.btn_DelImg_A.TabIndex = 1
        Me.btn_DelImg_A.Text = "解除"
        Me.btn_DelImg_A.UseVisualStyleBackColor = False
        '
        'btn_SelImg_A
        '
        Me.btn_SelImg_A.BackColor = System.Drawing.SystemColors.Control
        Me.btn_SelImg_A.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_SelImg_A.Location = New System.Drawing.Point(78, 15)
        Me.btn_SelImg_A.Name = "btn_SelImg_A"
        Me.btn_SelImg_A.Size = New System.Drawing.Size(48, 24)
        Me.btn_SelImg_A.TabIndex = 0
        Me.btn_SelImg_A.Text = "選択"
        Me.btn_SelImg_A.UseVisualStyleBackColor = False
        '
        'txt_MenuTitle_A
        '
        Me.txt_MenuTitle_A.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_MenuTitle_A.Location = New System.Drawing.Point(3, 30)
        Me.txt_MenuTitle_A.Name = "txt_MenuTitle_A"
        Me.txt_MenuTitle_A.Size = New System.Drawing.Size(351, 22)
        Me.txt_MenuTitle_A.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Image = Global.CNL1501.My.Resources.Resources.back2
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "メニュータイトル"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Transparent
        Me.TabPage3.BackgroundImage = Global.CNL1501.My.Resources.Resources.back2
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.txt_MenuTitle_B)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(397, 254)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = " 中国語"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.CNL1501.My.Resources.Resources.back2
        Me.GroupBox1.Controls.Add(Me.pic_img_B)
        Me.GroupBox1.Controls.Add(Me.btn_DelImg_B)
        Me.GroupBox1.Controls.Add(Me.btn_SelImg_B)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(197, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 181)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "画像設定"
        '
        'pic_img_B
        '
        Me.pic_img_B.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_img_B.ErrorImage = CType(resources.GetObject("pic_img_B.ErrorImage"), System.Drawing.Image)
        Me.pic_img_B.InitialImage = CType(resources.GetObject("pic_img_B.InitialImage"), System.Drawing.Image)
        Me.pic_img_B.Location = New System.Drawing.Point(10, 45)
        Me.pic_img_B.Name = "pic_img_B"
        Me.pic_img_B.Size = New System.Drawing.Size(168, 126)
        Me.pic_img_B.TabIndex = 2
        Me.pic_img_B.TabStop = False
        '
        'btn_DelImg_B
        '
        Me.btn_DelImg_B.BackColor = System.Drawing.SystemColors.Control
        Me.btn_DelImg_B.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_DelImg_B.Location = New System.Drawing.Point(132, 15)
        Me.btn_DelImg_B.Name = "btn_DelImg_B"
        Me.btn_DelImg_B.Size = New System.Drawing.Size(48, 24)
        Me.btn_DelImg_B.TabIndex = 1
        Me.btn_DelImg_B.Text = "解除"
        Me.btn_DelImg_B.UseVisualStyleBackColor = False
        '
        'btn_SelImg_B
        '
        Me.btn_SelImg_B.BackColor = System.Drawing.SystemColors.Control
        Me.btn_SelImg_B.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_SelImg_B.Location = New System.Drawing.Point(78, 15)
        Me.btn_SelImg_B.Name = "btn_SelImg_B"
        Me.btn_SelImg_B.Size = New System.Drawing.Size(48, 24)
        Me.btn_SelImg_B.TabIndex = 0
        Me.btn_SelImg_B.Text = "選択"
        Me.btn_SelImg_B.UseVisualStyleBackColor = False
        '
        'txt_MenuTitle_B
        '
        Me.txt_MenuTitle_B.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_MenuTitle_B.Location = New System.Drawing.Point(3, 30)
        Me.txt_MenuTitle_B.Name = "txt_MenuTitle_B"
        Me.txt_MenuTitle_B.Size = New System.Drawing.Size(351, 22)
        Me.txt_MenuTitle_B.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Image = Global.CNL1501.My.Resources.Resources.back2
        Me.Label6.Location = New System.Drawing.Point(6, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "メニュータイトル"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Transparent
        Me.TabPage4.BackgroundImage = Global.CNL1501.My.Resources.Resources.back2
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Controls.Add(Me.txt_MenuTitle_C)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(397, 254)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = " 韓国語"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackgroundImage = Global.CNL1501.My.Resources.Resources.back2
        Me.GroupBox5.Controls.Add(Me.pic_img_C)
        Me.GroupBox5.Controls.Add(Me.btn_DelImg_C)
        Me.GroupBox5.Controls.Add(Me.btn_SelImg_C)
        Me.GroupBox5.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(197, 72)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(190, 181)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "画像設定"
        '
        'pic_img_C
        '
        Me.pic_img_C.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_img_C.ErrorImage = CType(resources.GetObject("pic_img_C.ErrorImage"), System.Drawing.Image)
        Me.pic_img_C.InitialImage = CType(resources.GetObject("pic_img_C.InitialImage"), System.Drawing.Image)
        Me.pic_img_C.Location = New System.Drawing.Point(10, 45)
        Me.pic_img_C.Name = "pic_img_C"
        Me.pic_img_C.Size = New System.Drawing.Size(168, 126)
        Me.pic_img_C.TabIndex = 2
        Me.pic_img_C.TabStop = False
        '
        'btn_DelImg_C
        '
        Me.btn_DelImg_C.BackColor = System.Drawing.SystemColors.Control
        Me.btn_DelImg_C.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_DelImg_C.Location = New System.Drawing.Point(132, 15)
        Me.btn_DelImg_C.Name = "btn_DelImg_C"
        Me.btn_DelImg_C.Size = New System.Drawing.Size(48, 24)
        Me.btn_DelImg_C.TabIndex = 1
        Me.btn_DelImg_C.Text = "解除"
        Me.btn_DelImg_C.UseVisualStyleBackColor = False
        '
        'btn_SelImg_C
        '
        Me.btn_SelImg_C.BackColor = System.Drawing.SystemColors.Control
        Me.btn_SelImg_C.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_SelImg_C.Location = New System.Drawing.Point(78, 15)
        Me.btn_SelImg_C.Name = "btn_SelImg_C"
        Me.btn_SelImg_C.Size = New System.Drawing.Size(48, 24)
        Me.btn_SelImg_C.TabIndex = 0
        Me.btn_SelImg_C.Text = "選択"
        Me.btn_SelImg_C.UseVisualStyleBackColor = False
        '
        'txt_MenuTitle_C
        '
        Me.txt_MenuTitle_C.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_MenuTitle_C.Location = New System.Drawing.Point(3, 30)
        Me.txt_MenuTitle_C.Name = "txt_MenuTitle_C"
        Me.txt_MenuTitle_C.Size = New System.Drawing.Size(351, 22)
        Me.txt_MenuTitle_C.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Image = Global.CNL1501.My.Resources.Resources.back2
        Me.Label8.Location = New System.Drawing.Point(6, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "メニュータイトル"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_ImagePath
        '
        Me.txt_ImagePath.Location = New System.Drawing.Point(63, 496)
        Me.txt_ImagePath.Name = "txt_ImagePath"
        Me.txt_ImagePath.Size = New System.Drawing.Size(100, 19)
        Me.txt_ImagePath.TabIndex = 247
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(726, 363)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 24)
        Me.Label7.TabIndex = 293
        Me.Label7.Text = "商品検索"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(810, 365)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(192, 22)
        Me.txt_Search.TabIndex = 292
        Me.txt_Search.Text = "TextBox1"
        '
        'btn_GrpDel
        '
        Me.btn_GrpDel.BackColor = System.Drawing.SystemColors.Control
        Me.btn_GrpDel.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_GrpDel.Location = New System.Drawing.Point(819, 10)
        Me.btn_GrpDel.Name = "btn_GrpDel"
        Me.btn_GrpDel.Size = New System.Drawing.Size(180, 50)
        Me.btn_GrpDel.TabIndex = 291
        Me.btn_GrpDel.Text = "グループの削除"
        Me.btn_GrpDel.UseVisualStyleBackColor = False
        '
        'btn_GrpAdd
        '
        Me.btn_GrpAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btn_GrpAdd.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_GrpAdd.Location = New System.Drawing.Point(616, 10)
        Me.btn_GrpAdd.Name = "btn_GrpAdd"
        Me.btn_GrpAdd.Size = New System.Drawing.Size(180, 50)
        Me.btn_GrpAdd.TabIndex = 290
        Me.btn_GrpAdd.Text = "グループの追加"
        Me.btn_GrpAdd.UseVisualStyleBackColor = False
        '
        'btn_MenuDel
        '
        Me.btn_MenuDel.BackColor = System.Drawing.SystemColors.Control
        Me.btn_MenuDel.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_MenuDel.Location = New System.Drawing.Point(419, 10)
        Me.btn_MenuDel.Name = "btn_MenuDel"
        Me.btn_MenuDel.Size = New System.Drawing.Size(180, 50)
        Me.btn_MenuDel.TabIndex = 289
        Me.btn_MenuDel.Text = "メニューの削除"
        Me.btn_MenuDel.UseVisualStyleBackColor = False
        '
        'btn_MenuAdd
        '
        Me.btn_MenuAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btn_MenuAdd.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_MenuAdd.Location = New System.Drawing.Point(219, 10)
        Me.btn_MenuAdd.Name = "btn_MenuAdd"
        Me.btn_MenuAdd.Size = New System.Drawing.Size(180, 50)
        Me.btn_MenuAdd.TabIndex = 287
        Me.btn_MenuAdd.Text = "メニューの追加"
        Me.btn_MenuAdd.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(204, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(794, 1)
        Me.Label11.TabIndex = 286
        '
        'btn_Dwn
        '
        Me.btn_Dwn.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Dwn.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Dwn.Location = New System.Drawing.Point(512, 362)
        Me.btn_Dwn.Name = "btn_Dwn"
        Me.btn_Dwn.Size = New System.Drawing.Size(72, 24)
        Me.btn_Dwn.TabIndex = 282
        Me.btn_Dwn.Text = "下へ移動"
        Me.btn_Dwn.UseVisualStyleBackColor = False
        '
        'btn_Up
        '
        Me.btn_Up.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Up.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Up.Location = New System.Drawing.Point(414, 362)
        Me.btn_Up.Name = "btn_Up"
        Me.btn_Up.Size = New System.Drawing.Size(82, 24)
        Me.btn_Up.TabIndex = 281
        Me.btn_Up.Text = "上へ移動"
        Me.btn_Up.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(204, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 24)
        Me.Label4.TabIndex = 256
        Me.Label4.Text = "● 商品一覧（選択済み）"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_ImagePath_A
        '
        Me.txt_ImagePath_A.Location = New System.Drawing.Point(63, 521)
        Me.txt_ImagePath_A.Name = "txt_ImagePath_A"
        Me.txt_ImagePath_A.Size = New System.Drawing.Size(100, 19)
        Me.txt_ImagePath_A.TabIndex = 295
        '
        'txt_ImagePath_B
        '
        Me.txt_ImagePath_B.Location = New System.Drawing.Point(63, 546)
        Me.txt_ImagePath_B.Name = "txt_ImagePath_B"
        Me.txt_ImagePath_B.Size = New System.Drawing.Size(100, 19)
        Me.txt_ImagePath_B.TabIndex = 296
        '
        'txt_ImagePath_C
        '
        Me.txt_ImagePath_C.Location = New System.Drawing.Point(63, 571)
        Me.txt_ImagePath_C.Name = "txt_ImagePath_C"
        Me.txt_ImagePath_C.Size = New System.Drawing.Size(100, 19)
        Me.txt_ImagePath_C.TabIndex = 297
        '
        'CNL2030
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1016, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stb_Msg)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL2030"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNL2030"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tab_Items.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.pic_Img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.pic_img_A, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pic_img_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.pic_img_C, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' --------------------------------------------------------------------------------
    ' モジュール内変数定義
    ' --------------------------------------------------------------------------------
    Private L_DragMode As String
    Private L_blnDragMode As Boolean                                           ' True:追加操作 / False:削除操作
    Private L_TitleStr As String
    Private L_ProcFlg As Boolean
    Private L_ProcFlg2 As Boolean
    Private L_EditFlg As Boolean
    Private L_MenuID As String
    Private L_MenuGrpID As String
    Private L_GrpID As String
    Private L_MenuIdx As Integer
    Private L_MenuGrpIdx As Integer
    Private L_GrpIdx As Integer

    ' --------------------------------------------------------------------------------
    ' モジュール内定数定義
    ' --------------------------------------------------------------------------------
    Private Const LC_PAT_DIRC As String = "0"
    Private Const LC_PAT_PIC4 As String = "1"
    Private Const LC_PAT_PIC6 As String = "2"
    Private Const LC_PAT_PIC9 As String = "3"
    Private Const LC_PAT_PIC16 As String = "4"
    Private Const LC_STYLE_PIC4 As String = "A"
    Private Const LC_STYLE_PIC6 As String = "B"
    Private Const LC_STYLE_PIC9 As String = "C"
    Private Const LC_STYLE_PIC16 As String = "D"
    Private Const LC_STYLE_DAILY As String = "E"
    Private Const LC_STYLE_FREE1 As String = "F"
    Private Const LC_STYLE_FREE2 As String = "G"
    Private Const LC_STYLE_FREE3 As String = "H"
    Private Const LC_STYLE_FREE4 As String = "I"
    Private Const LC_STYLE_FREE5 As String = "J"
    Private Const LC_STYLE_FREE6 As String = "K"
    Private Const LC_STYLE_FREE7 As String = "L"
    Private Const LC_STYLE_FREE8 As String = "M"
    Private Const LC_STYLE_FREE9 As String = "N"
    Private Const LC_STYLE_FREE10 As String = "O"
    Private Const LC_STYLE_FREE11 As String = "P"
    Private Const LC_STYLE_FREE12 As String = "Q"
    Private Const LC_STYLE_FREE13 As String = "R"
    Private Const LC_STYLE_FREE14 As String = "S"
    Private Const LC_STYLE_FREE15 As String = "T"
    Private Const LC_STYLE_FREE16 As String = "U"
    Private Const LC_STYLE_FREE17 As String = "V"
    Private Const LC_STYLE_FREE18 As String = "W"

    Private Const LC_MENU As String = "1"
    Private Const LC_MENU_GRP As String = "2"
    Private Const LC_GRP As String = "3"

    ' 更新区分
    Private Const LC_UPDKBN_ADD As String = "ADD"
    Private Const LC_UPDKBN_DEL As String = "DEL"

    ' 新規グループ追加時の標準値
    Private Const LC_DEF_GRPNMJ As String = "名称未設定"
    Private Const LC_DEF_GRPPRICE As String = GC_TRUE

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub CNL2030_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' フォーム名称設定
        '------------------------------
        Me.Text = " 商品配置 "

        '---------------------------------
        ' 閉じるボタン非表示化
        '---------------------------------
        Me.ControlBox = False

        '------------------------------
        ' フォーム初期化処理
        '------------------------------
        Call LS_Initialize()

        '多言語機能対応
        If Not GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            tab_Items.TabPages.Remove(TabPage2)
            tab_Items.TabPages.Remove(TabPage3)
            tab_Items.TabPages.Remove(TabPage4)
        Else
            ' Remove の方が楽だが、あえて表示させ使用不可に
              'If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) = 1 Then
              '  tab_Items.TabPages.Remove(TabPage3)
              'End If
              tab_Items.TabPages.Item(1).Text = System.Configuration.ConfigurationManager.AppSettings("MenuLanguage2")
              tab_Items.TabPages.Item(2).Text = System.Configuration.ConfigurationManager.AppSettings("MenuLanguage3")
              tab_Items.TabPages.Item(3).Text = System.Configuration.ConfigurationManager.AppSettings("MenuLanguage4")
        End If

        ' --- (2022.11.02) 【OMOTENASHI】未使用画像ファイル削除 --------------
        '------------------------------
        ' 【OMOTENASHI】未使用画像ファイル削除処理
        '------------------------------
        If Not LF_DelUnuseOMOTENASHIFile() Then
            GoTo SYSTEM_ERROR
        End If
        ' --- (2022.11.02) 【OMOTENASHI】未使用画像ファイル削除 --------------

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL2030_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォームクローズイベント
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub CNL2030_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        If L_EditFlg Then
            Select Case LF_CNL2030Save()
                Case CNL1920.FuncResult.NormalEnd
                    ' 何もしない
                Case CNL1920.FuncResult.CancelEnd
                    e.Cancel = True
                Case CNL1920.FuncResult.UnusualEnd
                    GoTo SYSTEM_ERROR
                Case Else
                    GoTo SYSTEM_ERROR
            End Select
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL2030_Closing")
        e.Cancel = True
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：[CNL2030]保存処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_CNL2030Save() As FuncResult

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_CNL2030Save = CNL1920.FuncResult.UnusualEnd

        If L_EditFlg Then
            '------------------------------
            ' 未使用画像ファイル削除処理
            '------------------------------
            If Not LF_DelUnuseFile() Then
                GoTo SYSTEM_ERROR
            End If

            '------------------------------
            ' 無効メニュー削除処理
            '------------------------------
            If LF_ChkMenuEnabled() = CNL1920.FuncResult.UnusualEnd Then
                GoTo SYSTEM_ERROR
            End If

            L_EditFlg = False
        End If

        LF_CNL2030Save = CNL1920.FuncResult.NormalEnd
        Exit Function

SYSTEM_ERROR:
        LF_CNL2030Save = CNL1920.FuncResult.UnusualEnd
        Call GS_ErrorTerm("LF_CNL2030Save")
    End Function

    Private Function LF_ChkMenuEnabled() As FuncResult
        '------------------------------
        ' 全ノードを見て、一つもジャンルの登録されていないメニューボタンは、ENABLED=GC_FALSEを設定するようにする
        ' また、親ノードから見て、全ての子ノードがENABLED=GC_FALSEであれば、無効なメニューであることをメッセージにて示し、削除してしまう
        '------------------------------

        '------------------------------
        ' 内部変数定義
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
        ' 初期値設定
        '------------------------------
        LF_ChkMenuEnabled = CNL1920.FuncResult.UnusualEnd

        '------------------------------
        ' 有効性チェック処理
        '------------------------------
        For Each objPNode In trv_Menu.Nodes                                 ' 親ノードループ
            blnFound = False
            blnAllUnUse = False
            For Each objCNode In objPNode.Nodes                             ' 子ノードループ
                strMenuID = LF_GetMenuGrpCD(objPNode)                       ' 現ノードの各コードを取得する
                strMenuGrpID = LF_GetMenuGrpCD(objCNode)

                If Len(Trim$(strMenuID)) = 0 Or _
                   Len(Trim$(strMenuGrpID)) = 0 Then
                    Exit Function
                End If

                ' 当該ノードにジャンルが紐付けられているか、ＤＢから逐一検索を行う
                objData = New DataSet()
                If Not LF_GetTPM060_4(strMenuID, strMenuGrpID, objData) Then
                    Exit Function
                End If

                If objData.Tables("com").Rows.Count = 0 Then
                    objCNode.Checked = False
                Else
                    blnFound = True

                    If objCNode.Checked = True Then
                        blnAllUnUse = True
                    End If
                End If
            Next

            ' ジャンル登録済みであっても、全ての子ノードの .Checked 状態が False の場合は、同様の扱いとする
            If blnAllUnUse = False Then
                blnFound = False
            End If

            If blnFound = False Then
                '------------------------------
                ' 無効メニュー検出時
                '------------------------------
                Select Case GF_Msg("", "メニュー【 " & objPNode.Text & " 】にはグループが登録されていないため、強制削除します", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                    Case MsgBoxResult.Ok
                        '------------------------------
                        ' 無効メニューを削除する
                        '------------------------------
                        '------------------------------
                        ' トランザクション開始
                        '------------------------------
                        If Not GF_BeginTrans() Then
                            Exit Function
                        End If

                        strSQL = ""
                        strSQL = strSQL & "DELETE FROM TPM060"
                        strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"

                        If Not GF_UpdData(strSQL) Then
                            If Not GF_RollbackTrans() Then
                                Exit Function
                            End If
                            Exit Function
                        End If

                        strSQL = ""
                        strSQL = strSQL & "DELETE FROM TPM061"
                        strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"

                        If Not GF_UpdData(strSQL) Then
                            If Not GF_RollbackTrans() Then
                                Exit Function
                            End If
                            Exit Function
                        End If

                        '多言語機能対応
                        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then

                            '------------------------------
                            ' TPM060A削除
                            '------------------------------
                            strSQL = ""
                            strSQL = strSQL & "DELETE FROM TPM060A"
                            strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"

                            If Not GF_UpdData(strSQL) Then
                                If Not GF_RollbackTrans() Then
                                    Exit Function
                                End If
                                Exit Function
                            End If

                            '------------------------------
                            ' TPM060B削除
                            '------------------------------
                            strSQL = ""
                            strSQL = strSQL & "DELETE FROM TPM060B"
                            strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"

                            If Not GF_UpdData(strSQL) Then
                                If Not GF_RollbackTrans() Then
                                    Exit Function
                                End If
                                Exit Function
                            End If

                            '------------------------------
                            ' TPM060C削除
                            '------------------------------
                            strSQL = ""
                            strSQL = strSQL & "DELETE FROM TPM060C"
                            strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"

                            If Not GF_UpdData(strSQL) Then
                                If Not GF_RollbackTrans() Then
                                    Exit Function
                                End If
                                Exit Function
                            End If

                            '------------------------------
                            ' TPM061A削除
                            '------------------------------
                            strSQL = ""
                            strSQL = strSQL & "DELETE FROM TPM061A"
                            strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"

                            If Not GF_UpdData(strSQL) Then
                                If Not GF_RollbackTrans() Then
                                    Exit Function
                                End If
                                Exit Function
                            End If

                            '------------------------------
                            ' TPM061B削除
                            '------------------------------
                            strSQL = ""
                            strSQL = strSQL & "DELETE FROM TPM061B"
                            strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"

                            If Not GF_UpdData(strSQL) Then
                                If Not GF_RollbackTrans() Then
                                    Exit Function
                                End If
                                Exit Function
                            End If

                            '------------------------------
                            ' TPM061C削除
                            '------------------------------
                            strSQL = ""
                            strSQL = strSQL & "DELETE FROM TPM061C"
                            strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"

                            If Not GF_UpdData(strSQL) Then
                                If Not GF_RollbackTrans() Then
                                    Exit Function
                                End If
                                Exit Function
                            End If

                        End If

                        '------------------------------
                        ' トランザクション確定
                        '------------------------------
                        If Not GF_CommitTrans() Then
                            Exit Function
                        End If

                    Case Else
                        Exit Function
                End Select
            End If
        Next

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_ChkMenuEnabled = CNL1920.FuncResult.NormalEnd

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品画像フォルダ内 未使用画像ファイル削除処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
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

    ' --- (2022.11.02) 【OMOTENASHI】未使用画像ファイル削除 --------------
    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像フォルダ内 未使用画像ファイル削除処理（OMOTENASHI）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_DelUnuseOMOTENASHIFile() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strUFile() As String = Nothing
        Dim strFile As String
        Dim strMenuPath As String
        Dim strWork As String
        Dim blnFound As Boolean
        Dim objFileInfo As System.IO.FileInfo = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_DelUnuseOMOTENASHIFile = False

        '------------------------------
        ' OMOTENASHI使用中画像ファイル一覧取得(MenuPage)
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT file_name "
        strSQL = strSQL & "  FROM TPM555 "
        strSQL = strSQL & "UNION "
        strSQL = strSQL & "SELECT file_name "
        strSQL = strSQL & "  FROM TPM570 "

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If
            ReDim Preserve strUFile(lngCnt)
            strUFile(lngCnt) = Trim$(objRows("file_name"))

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' 画像ファイル使用中判定
        '------------------------------
        If objData.Tables("com").Rows.Count <> 0 Then
            strMenuPath = GF_GetAppInfo("MENUPAGE_V")
            For Each strFile In System.IO.Directory.GetFiles(strMenuPath)
                objFileInfo = New System.IO.FileInfo(strFile)
                blnFound = False

                For Each strWork In strUFile
                    If objFileInfo.Name = strWork Then
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
            Next
        End If

        '------------------------------
        ' 使用中画像ファイル一覧取得(MenuThumbnail)
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT SUBSTRING(file_name, 1, 14) + '_' + RIGHT('0000' + CONVERT(NVARCHAR, RTRIM(file_page_number)), 4) + '.jpg' AS FILENAME "
        strSQL = strSQL & "  FROM TPM555"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If
            ReDim Preserve strUFile(lngCnt)
            strUFile(lngCnt) = Trim$(objRows("FILENAME"))

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' 画像ファイル使用中判定
        '------------------------------
        If objData.Tables("com").Rows.Count <> 0 Then
            strMenuPath = GF_GetAppInfo("MENUTHUMBNAIL_V")
            For Each strFile In System.IO.Directory.GetFiles(strMenuPath)
                objFileInfo = New System.IO.FileInfo(strFile)
                blnFound = False

                For Each strWork In strUFile
                    If objFileInfo.Name = strWork Then
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
            Next
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_DelUnuseOMOTENASHIFile = True

    End Function
    ' --- (2022.11.02) 【OMOTENASHI】未使用画像ファイル削除 --------------

    ' --------------------------------------------------------------------------------
    ' 　機　　能：初期表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_Initialize()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim dtsData As New DataSet()

        '------------------------------
        ' フォーム初期化処理
        '------------------------------
        lst_TreeKey.Visible = False                                         ' 隠し項目の非表示設定
        lst_MenuGrp.Visible = False
        txt_ImagePath.Visible = False
        txt_ImagePath_A.Visible = False
        txt_ImagePath_B.Visible = False
        txt_ImagePath_C.Visible = False
        trv_Menu.Nodes.Clear()                                              ' メニューツリービュー初期化
        lsv_MenuGrp.Items.Clear()                                           ' メニューグループ・商品グループ一覧初期化
        lsv_ItemList.Items.Clear()
        lst_MenuGrp.Items.Clear()
        txt_MenuTitle.Text = ""
        txt_Search.Text = ""
        L_ProcFlg = False                                                   ' 処理中フラグ(イベント発生回避フラグ)
        L_ProcFlg2 = False
        chk_SpFlg.Checked = False

        '------------------------------
        ' 商品一覧(選択済み)初期化
        '------------------------------
        With lsv_MenuGrp
            .Clear()
            .FullRowSelect = True
            .AllowDrop = True
            .AllowColumnReorder = True
            .HideSelection = False
        End With

        '------------------------------
        ' 商品一覧初期化
        '------------------------------
        With lsv_ItemList
            .Clear()
            .FullRowSelect = True
            .AllowDrop = True
            .AllowColumnReorder = True
            .HideSelection = False
        End With

        '------------------------------
        ' ステータスバー初期化
        '------------------------------
        Call GS_StatusSetup(stb_Msg)

        ' フォーカス喪失後も、選択域を強調表示する
        trv_Menu.HideSelection = False

        cbo_Pat.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_Pat.Items.Clear()
        Call GS_CboItemSet(cbo_Pat, "商品一覧を直接表示", LC_PAT_DIRC)
        Call GS_CboItemSet(cbo_Pat, "４分割表示", LC_PAT_PIC4)
        Call GS_CboItemSet(cbo_Pat, "６分割表示", LC_PAT_PIC6)
        Call GS_CboItemSet(cbo_Pat, "９分割表示", LC_PAT_PIC9)
        Call GS_CboItemSet(cbo_Pat, "１６分割表示", LC_PAT_PIC16)
        Call GS_CboChgSel(cbo_Pat, LC_PAT_DIRC)

        cbo_Style.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_Style.Items.Clear()
        Call GS_CboItemSet(cbo_Style, "４分割表示", LC_STYLE_PIC4)
        Call GS_CboItemSet(cbo_Style, "６分割表示", LC_STYLE_PIC6)
        Call GS_CboItemSet(cbo_Style, "９分割表示", LC_STYLE_PIC9)
        Call GS_CboItemSet(cbo_Style, "１６分割表示", LC_STYLE_PIC16)
        Call GS_CboItemSet(cbo_Style, "日替わり表示", LC_STYLE_DAILY)

        'フリーテンプレート使用可否判定
        If Trim$(GF_GetAppInfo2("FREE_TEMPLATE_USE")) = "1" Then
            Call GS_CboItemSet(cbo_Style, "テンプレート１", LC_STYLE_FREE1)
            Call GS_CboItemSet(cbo_Style, "テンプレート２", LC_STYLE_FREE2)
            Call GS_CboItemSet(cbo_Style, "テンプレート３", LC_STYLE_FREE3)
            Call GS_CboItemSet(cbo_Style, "テンプレート４", LC_STYLE_FREE4)
            Call GS_CboItemSet(cbo_Style, "テンプレート５", LC_STYLE_FREE5)
            Call GS_CboItemSet(cbo_Style, "テンプレート６", LC_STYLE_FREE6)
            Call GS_CboItemSet(cbo_Style, "テンプレート７", LC_STYLE_FREE7)
            Call GS_CboItemSet(cbo_Style, "テンプレート８", LC_STYLE_FREE8)
            Call GS_CboItemSet(cbo_Style, "テンプレート９", LC_STYLE_FREE9)
            Call GS_CboItemSet(cbo_Style, "テンプレート１０", LC_STYLE_FREE10)
            Call GS_CboItemSet(cbo_Style, "テンプレート１１", LC_STYLE_FREE11)
            Call GS_CboItemSet(cbo_Style, "テンプレート１２", LC_STYLE_FREE12)
            Call GS_CboItemSet(cbo_Style, "テンプレート１３", LC_STYLE_FREE13)
            Call GS_CboItemSet(cbo_Style, "テンプレート１４", LC_STYLE_FREE14)
            Call GS_CboItemSet(cbo_Style, "テンプレート１５", LC_STYLE_FREE15)
            Call GS_CboItemSet(cbo_Style, "テンプレート１６", LC_STYLE_FREE16)
            Call GS_CboItemSet(cbo_Style, "テンプレート１７", LC_STYLE_FREE17)
            Call GS_CboItemSet(cbo_Style, "テンプレート１８", LC_STYLE_FREE18)
        End If
        Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC4)

        Call LS_SetMenuTree()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_Initialize")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品一覧取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM010_1(ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM010_1 = False

        '------------------------------
        ' 商品マスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        strSQL = strSQL & "       TPM010.PRICE,"
        strSQL = strSQL & "       ISNULL(TPM260.TAXPRICE, 0) AS TAXPRICE"   '消費税対応　2013.1.9
        strSQL = strSQL & "  FROM TPM010 LEFT JOIN TPM260 ON TPM010.GOODSCD = TPM260.GOODSCD"
        strSQL = strSQL & " WHERE STATUS = '0'"
        strSQL = strSQL & "   AND GOODSKIND IN ('0', '1')"
        If Len(Trim$(txt_Search.Text)) <> 0 Then
            strSQL = strSQL & "   AND GOODSNMJ LIKE '%" & Trim$(txt_Search.Text) & "%'"
        End If
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM010_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューグループ内商品グループ一覧取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM010_2(ByVal pGrpCD As String, ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM010_2 = False

        '------------------------------
        ' 商品マスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        strSQL = strSQL & "       TPM010.PRICE,"
        strSQL = strSQL & " ISNULL(TPM260.TAXPRICE, 0) AS TAXPRICE"    '消費税対応　2014.1.9
        strSQL = strSQL & "  FROM TPM010 LEFT JOIN TPM260 ON TPM010.GOODSCD = TPM260.GOODSCD,"
        strSQL = strSQL & "       TPM020"
        strSQL = strSQL & " WHERE TPM020.GROUPCD  = '" & pGrpCD & "'"
        strSQL = strSQL & "   AND TPM020.GOODSCD <> '0000'"
        strSQL = strSQL & "   AND TPM010.GOODSCD  = TPM020.GOODSCD"
        strSQL = strSQL & " ORDER BY CONVERT(NUMERIC,TPM020.DISPORDER)"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM010_2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能： メニューツリー生成処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM060_1(ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()
        Dim strWhere As String
        Dim srtParam As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM060_1 = False
        strWhere = ""
        srtParam = ""

        '------------------------------
        ' メニューグループマスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM060.MENUID,"
        strSQL = strSQL & "       TPM060.MENUNM,"
        strSQL = strSQL & "       TPM060.MENUGRPID,"
        strSQL = strSQL & "       TPM060.MENUGRPNM,"
        strSQL = strSQL & "       TPM060.ENABLED AS ENABLED1,"
        strSQL = strSQL & "       TPM020.GROUPCD,"
        strSQL = strSQL & "       TPM020.GROUPNM,"
        strSQL = strSQL & "       TPM020.ENABLED AS ENABLED2"
        strSQL = strSQL & "  FROM TPM060 LEFT JOIN TPM020"
        strSQL = strSQL & "    ON TPM060.GROUPCD = TPM020.GROUPCD"
        strSQL = strSQL & "   AND TPM020.GOODSCD = '0000'"
        strSQL = strSQL & "   AND TPM060.GROUPCD <> 'J000'"

        '------------------------------
        ' 自社製ハンディターミナル使用有無チェック
        '------------------------------
        If Trim$(GF_GetAppInfo("HANDYUSE")) = GC_TRUE Then
            srtParam = srtParam & "'010'"
        End If

        '------------------------------
        ' 定額メニュー(飲み放題)使用有無チェック
        '------------------------------
        If Trim$(GF_GetAppInfo("PRICE_TYPE")) = GC_TRUE Then
            If srtParam.Equals("") Then
                srtParam = srtParam & "'011'"
            Else
                srtParam = srtParam & ", '011'"
            End If
        End If

        If Not srtParam.Equals("") Then
            strSQL = strSQL & " WHERE TPM060.MENUGRPID NOT IN (" & srtParam & ")"
        End If

        strSQL = strSQL & " ORDER BY TPM060.MENUID"
        strSQL = strSQL & "        ,TPM060.MENUGRPID"
        strSQL = strSQL & "        ,CONVERT(NUMERIC, TPM060.DISPORDER)"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM060_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューグループ内商品グループ一覧取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM060_2(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM060_2 = False

        '------------------------------
        ' メニューグループマスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT GROUPCD,"
        strSQL = strSQL & "       MENUSTYLE,"
        strSQL = strSQL & "       GROUPKBN"
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " WHERE MENUID    = '" & pMenuID & "'"
        strSQL = strSQL & "   AND MENUGRPID = '" & pMenuGrpID & "'"
        strSQL = strSQL & "   AND GROUPCD   = '" & GC_DUMMY_GROUPCD & "'"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM060_2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューグループ一覧取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM060_3(ByVal pMenuID As String, ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM060_3 = False

        '------------------------------
        ' メニューグループマスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT MENUGRPID,"
        strSQL = strSQL & "       MENUGRPNM"
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " WHERE MENUID = '" & pMenuID & "'"
        strSQL = strSQL & " GROUP BY MENUGRPID,"
        strSQL = strSQL & "          MENUGRPNM"
        strSQL = strSQL & " ORDER BY MENUGRPID"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM060_3 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ジャンル一覧取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM060_4(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM060_4 = False

        '------------------------------
        ' メニューグループマスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM020.GROUPCD,"
        strSQL = strSQL & "       TPM020.GROUPNM"
        strSQL = strSQL & "  FROM TPM060 LEFT JOIN TPM020 ON TPM060.GROUPCD = TPM020.GROUPCD"
        strSQL = strSQL & "                              AND TPM020.GOODSCD = '0000'"
        strSQL = strSQL & " WHERE TPM060.MENUID    = '" & pMenuID & "'"
        strSQL = strSQL & "   AND TPM060.MENUGRPID = '" & pMenuGrpID & "'"
        strSQL = strSQL & "   AND TPM060.GROUPCD   <> 'J000'"
        strSQL = strSQL & " ORDER BY TPM060.MENUID,"
        strSQL = strSQL & "          TPM060.MENUGRPID,"
        strSQL = strSQL & "          CONVERT(NUMERIC, TPM060.DISPORDER)"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM060_4 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューグループ内商品グループ一覧取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM060_5(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByVal pGrpID As String, ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM060_5 = False

        '------------------------------
        ' メニューグループマスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT GROUPCD,"
        strSQL = strSQL & "       MENUSTYLE,"
        strSQL = strSQL & "       GROUPKBN"
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " WHERE MENUID    = '" & pMenuID & "'"
        strSQL = strSQL & "   AND MENUGRPID = '" & pMenuGrpID & "'"
        strSQL = strSQL & "   AND GROUPCD   = '" & pGrpID & "'"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM060_5 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューツリー生成処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
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
        Dim objDNode As TreeNode = Nothing
        Dim strBKey As String
        Dim strCKey As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        trv_Menu.Nodes.Clear()                                              ' メニューツリービュー初期化
        lst_TreeKey.Items.Clear()                                           ' 隠しキー保持リスト初期化
        txt_MenuTitle.Clear()
        '多言語機能対応
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            txt_MenuTitle_A.Clear()
            txt_MenuTitle_B.Clear()
            txt_MenuTitle_C.Clear()
        End If

        '------------------------------
        ' メニューツリー生成処理
        '------------------------------
        If Not LF_GetTPM060_1(dtsData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            L_ProcFlg = True                                                    ' イベント発生回避フラグＯＮ
            lngCnt = 0
            strBKey = ""
            strCKey = ""
            While lngCnt < dtsData.Tables("com").Rows.Count
                If Not GF_GetRows(dtsData, lngCnt, dtrData) Then
                    GoTo SYSTEM_ERROR
                End If

                '------------------------------
                ' 親ノード追加
                '------------------------------
                If strBKey <> Trim$(dtrData("MENUID")) Then
                    objNode = trv_Menu.Nodes.Add(Trim$(dtrData("MENUNM")))
                    objNode.Checked = True

                    lst_TreeKey.Items.Add("P" & _
                                          Format$(objNode.Index, "00000") & _
                                          vbTab & _
                                          Trim$(dtrData("MENUID")))
                    strBKey = Trim$(dtrData("MENUID"))
                End If

                '------------------------------
                ' 子ノード追加
                '------------------------------
                If strCKey <> Trim$(dtrData("MENUGRPID")) Then
                    objCNode = objNode.Nodes.Add(Trim$(dtrData("MENUGRPNM")))
                    objCNode.Checked = IIf(Trim$(dtrData("ENABLED1")) = GC_TRUE, True, False)

                    lst_TreeKey.Items.Add("C" & _
                                          Format$(objNode.Index, "00000") & _
                                          Format$(objCNode.Index, "00000") & _
                                          vbTab & _
                                          Trim$(dtrData("MENUGRPID")))              ' 隠し項目のキー値追加
                    strCKey = Trim$(dtrData("MENUGRPID"))
                End If

                '------------------------------
                ' 孫ノード追加
                '------------------------------
                If Not dtrData("GROUPNM") Is DBNull.Value Then
                    objDNode = objCNode.Nodes.Add(Trim$(dtrData("GROUPNM")))
                    objDNode.Checked = IIf(Trim$(dtrData("ENABLED2")) = GC_TRUE, True, False)

                    lst_TreeKey.Items.Add("D" & _
                                          Format$(objNode.Index, "00000") & _
                                          Format$(objCNode.Index, "00000") & _
                                          Format$(objDNode.Index, "00000") & _
                                          vbTab & _
                                          Trim$(dtrData("GROUPCD")))              ' 隠し項目のキー値追加
                End If

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

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューＩＤ／メニューグループＩＤ／グループＣＤ取得
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetMenuGrpCD(ByVal pNode As TreeNode) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim strFindKey As String
        Dim strWork() As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetMenuGrpCD = ""

        Try
            '------------------------------
            ' 親ノードは検索不可
            '------------------------------
            If IsNothing(pNode.Parent) Then
                strFindKey = "P" & Format$(pNode.Index, "00000")
            Else
                If IsNothing(pNode.Parent.Parent) Then
                    strFindKey = "C" & Format$(pNode.Parent.Index, "00000") & _
                                       Format$(pNode.Index, "00000")
                Else
                    strFindKey = "D" & Format$(pNode.Parent.Parent.Index, "00000") & _
                                       Format$(pNode.Parent.Index, "00000") & _
                                       Format$(pNode.Index, "00000")
                End If
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
    ' 　機　　能：メニューＩＤ／メニューグループＩＤ／グループＣＤ取得
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetMenuNM_A(ByVal pNode As TreeNode, ByVal pMENUID As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim strFindKey As String
        Dim strWork() As String
        Dim MenuGrpId As String = Nothing
        Dim strSQL As String
        Dim objData As New DataSet
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetMenuNM_A = ""

        Try
            '------------------------------
            ' 親ノードは検索不可
            '------------------------------
            If IsNothing(pNode.Parent) Then
                strFindKey = "P" & Format$(pNode.Index, "00000")
            Else
                If IsNothing(pNode.Parent.Parent) Then
                    strFindKey = "C" & Format$(pNode.Parent.Index, "00000") & _
                                       Format$(pNode.Index, "00000")
                Else
                    strFindKey = "D" & Format$(pNode.Parent.Parent.Index, "00000") & _
                                       Format$(pNode.Parent.Index, "00000") & _
                                       Format$(pNode.Index, "00000")
                End If
            End If

            For lngCnt = 0 To lst_TreeKey.Items.Count() - 1
                strWork = Split(lst_TreeKey.Items(lngCnt), vbTab)
                If Trim$(strWork(0)) = strFindKey Then
                    MenuGrpId = Trim$(strWork(1))
                End If
            Next

            If IsNothing(pNode.Parent) Then

            Else
                If IsNothing(pNode.Parent.Parent) Then
                    strSQL = ""
                    strSQL = strSQL & "SELECT MENUGRPNM"
                    strSQL = strSQL & "  FROM TPM060A"
                    strSQL = strSQL & " WHERE MENUID    = '" & pMENUID & "'"
                    strSQL = strSQL & "   AND MENUGRPID = '" & MenuGrpId & "'"

                    If Not GF_GetData(strSQL, objData) Then
                        Exit Function
                    End If

                    If Not GF_GetRows(objData, 0, objRows) Then
                        Exit Function
                    End If

                    LF_GetMenuNM_A = Trim$(objRows("MENUGRPNM"))

                Else
                    strSQL = ""
                    strSQL = strSQL & "SELECT GROUPNM"
                    strSQL = strSQL & "  FROM TPM020A"
                    strSQL = strSQL & " WHERE GOODSCD = '0000'"
                    strSQL = strSQL & "   AND GROUPCD = '" & MenuGrpId & "'"

                    If Not GF_GetData(strSQL, objData) Then
                        Exit Function
                    End If

                    If Not GF_GetRows(objData, 0, objRows) Then
                        Exit Function
                    End If

                    LF_GetMenuNM_A = Trim$(objRows("GROUPNM"))
                End If
            End If

        Catch
            Exit Function
        End Try

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューＩＤ／メニューグループＩＤ／グループＣＤ取得
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetMenuNM_B(ByVal pNode As TreeNode, ByVal pMENUID As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim strFindKey As String
        Dim strWork() As String
        Dim MenuGrpId As String = Nothing
        Dim strSQL As String
        Dim objData As New DataSet
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetMenuNM_B = ""

        Try
            '------------------------------
            ' 親ノードは検索不可
            '------------------------------
            If IsNothing(pNode.Parent) Then
                strFindKey = "P" & Format$(pNode.Index, "00000")
            Else
                If IsNothing(pNode.Parent.Parent) Then
                    strFindKey = "C" & Format$(pNode.Parent.Index, "00000") & _
                                       Format$(pNode.Index, "00000")
                Else
                    strFindKey = "D" & Format$(pNode.Parent.Parent.Index, "00000") & _
                                       Format$(pNode.Parent.Index, "00000") & _
                                       Format$(pNode.Index, "00000")
                End If
            End If

            For lngCnt = 0 To lst_TreeKey.Items.Count() - 1
                strWork = Split(lst_TreeKey.Items(lngCnt), vbTab)
                If Trim$(strWork(0)) = strFindKey Then
                    MenuGrpId = Trim$(strWork(1))
                End If
            Next

            If IsNothing(pNode.Parent) Then

            Else
                If IsNothing(pNode.Parent.Parent) Then
                    strSQL = ""
                    strSQL = strSQL & "SELECT MENUGRPNM"
                    strSQL = strSQL & "  FROM TPM060B"
                    strSQL = strSQL & " WHERE MENUID    = '" & pMENUID & "'"
                    strSQL = strSQL & "   AND MENUGRPID = '" & MenuGrpId & "'"

                    If Not GF_GetData(strSQL, objData) Then
                        Exit Function
                    End If

                    If Not GF_GetRows(objData, 0, objRows) Then
                        Exit Function
                    End If

                    LF_GetMenuNM_B = Trim$(objRows("MENUGRPNM"))

                Else
                    strSQL = ""
                    strSQL = strSQL & "SELECT GROUPNM"
                    strSQL = strSQL & "  FROM TPM020B"
                    strSQL = strSQL & " WHERE GOODSCD = '0000'"
                    strSQL = strSQL & "   AND GROUPCD = '" & MenuGrpId & "'"

                    If Not GF_GetData(strSQL, objData) Then
                        Exit Function
                    End If

                    If Not GF_GetRows(objData, 0, objRows) Then
                        Exit Function
                    End If

                    LF_GetMenuNM_B = Trim$(objRows("GROUPNM"))
                End If
            End If

        Catch
            Exit Function
        End Try

    End Function

    Private Function LF_GetMenuNM_C(ByVal pNode As TreeNode, ByVal pMENUID As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim strFindKey As String
        Dim strWork() As String
        Dim MenuGrpId As String = Nothing
        Dim strSQL As String
        Dim objData As New DataSet
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetMenuNM_C = ""

        Try
            '------------------------------
            ' 親ノードは検索不可
            '------------------------------
            If IsNothing(pNode.Parent) Then
                strFindKey = "P" & Format$(pNode.Index, "00000")
            Else
                If IsNothing(pNode.Parent.Parent) Then
                    strFindKey = "C" & Format$(pNode.Parent.Index, "00000") & _
                                       Format$(pNode.Index, "00000")
                Else
                    strFindKey = "D" & Format$(pNode.Parent.Parent.Index, "00000") & _
                                       Format$(pNode.Parent.Index, "00000") & _
                                       Format$(pNode.Index, "00000")
                End If
            End If

            For lngCnt = 0 To lst_TreeKey.Items.Count() - 1
                strWork = Split(lst_TreeKey.Items(lngCnt), vbTab)
                If Trim$(strWork(0)) = strFindKey Then
                    MenuGrpId = Trim$(strWork(1))
                End If
            Next

            If IsNothing(pNode.Parent) Then

            Else
                If IsNothing(pNode.Parent.Parent) Then
                    strSQL = ""
                    strSQL = strSQL & "SELECT MENUGRPNM"
                    strSQL = strSQL & "  FROM TPM060C"
                    strSQL = strSQL & " WHERE MENUID    = '" & pMENUID & "'"
                    strSQL = strSQL & "   AND MENUGRPID = '" & MenuGrpId & "'"

                    If Not GF_GetData(strSQL, objData) Then
                        Exit Function
                    End If

                    If Not GF_GetRows(objData, 0, objRows) Then
                        Exit Function
                    End If

                    LF_GetMenuNM_C = Trim$(objRows("MENUGRPNM"))

                Else
                    strSQL = ""
                    strSQL = strSQL & "SELECT GROUPNM"
                    strSQL = strSQL & "  FROM TPM020C"
                    strSQL = strSQL & " WHERE GOODSCD = '0000'"
                    strSQL = strSQL & "   AND GROUPCD = '" & MenuGrpId & "'"

                    If Not GF_GetData(strSQL, objData) Then
                        Exit Function
                    End If

                    If Not GF_GetRows(objData, 0, objRows) Then
                        Exit Function
                    End If

                    LF_GetMenuNM_C = Trim$(objRows("GROUPNM"))
                End If
            End If

        Catch
            Exit Function
        End Try

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューツリー操作時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub trv_Menu_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trv_Menu.AfterSelect

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim dtsData As New DataSet()

        Try
            '------------------------------
            ' 選択ノード判定
            '------------------------------
            L_ProcFlg2 = True                                                   ' 各オブジェクトのChangeイベント発生抑止
            lsv_MenuGrp.Clear()
            lsv_ItemList.Clear()
            cbo_Pat.SelectedIndex = 0
            cbo_Style.SelectedIndex = 0
            pic_Img.SizeMode = PictureBoxSizeMode.Zoom
            pic_Img.Image = Nothing
            txt_ImagePath.Clear()
            txt_ImagePath_A.Clear()
            txt_ImagePath_B.Clear()
            txt_ImagePath_C.Clear()
            chk_SpFlg.Checked = False
            txt_MenuTitle.Enabled = True
            '多言語機能対応
            If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                pic_img_A.SizeMode = PictureBoxSizeMode.Zoom
                pic_img_B.SizeMode = PictureBoxSizeMode.Zoom
                pic_img_C.SizeMode = PictureBoxSizeMode.Zoom
                pic_img_A.Image = Nothing
                pic_img_B.Image = Nothing
                pic_img_C.Image = Nothing
                txt_MenuTitle_A.Enabled = True
                txt_MenuTitle_B.Enabled = True
                txt_MenuTitle_C.Enabled = True
            End If

            If IsNothing(e.Node.Parent) Then
                '------------------------------
                ' [メニュー]項目選択時
                '------------------------------
                L_MenuID = LF_GetMenuGrpCD(e.Node)
                L_MenuGrpID = ""
                L_GrpID = ""

                Call GS_CboChgSel(cbo_Pat, LC_PAT_DIRC)
                Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC4)
                cbo_Pat.Enabled = False
                cbo_Style.Enabled = False

                Label2.Text = "メニュー名"

                Label4.Text = ""
                btn_MenuDel.Enabled = True
                btn_GrpAdd.Enabled = False
                btn_GrpDel.Enabled = False
                btn_Up.Enabled = False
                btn_Dwn.Enabled = False
                txt_Search.Enabled = False
                btn_SelImg.Enabled = False
                btn_DelImg.Enabled = False
                chk_SpFlg.Enabled = False
                '多言語機能対応
                If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                    Label1.Text = "メニュー名"
                    Label6.Text = "メニュー名"
                    Label8.Text = "メニュー名"
                    btn_SelImg_A.Enabled = False
                    btn_DelImg_A.Enabled = False
                    btn_SelImg_B.Enabled = False
                    btn_DelImg_B.Enabled = False
                    btn_SelImg_C.Enabled = False
                    btn_DelImg_C.Enabled = False
                    txt_MenuTitle_A.Text = e.Node.Text
                    'txt_MenuTitle_A.Enabled = False
                    If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 1 Then
                        txt_MenuTitle_B.Text = e.Node.Text
                    Else
                        txt_MenuTitle_B.Text = ""
                        txt_MenuTitle_B.Enabled = False
                    End If
                    If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 2 Then
                        txt_MenuTitle_C.Text = e.Node.Text
                    Else
                        txt_MenuTitle_C.Text = ""
                        txt_MenuTitle_C.Enabled = False
                    End If
                End If

                'Call LS_SetMenuGrp(L_MenuID, Nothing, Nothing)                      ' メニューグループ一覧生成
            Else
                If IsNothing(e.Node.Parent.Parent) Then
                    '------------------------------
                    ' [メニューグループ]項目選択時
                    '------------------------------
                    L_MenuID = LF_GetMenuGrpCD(e.Node.Parent)
                    L_MenuGrpID = LF_GetMenuGrpCD(e.Node)
                    L_GrpID = ""

                    cbo_Pat.Enabled = True
                    cbo_Style.Enabled = False

                    Label2.Text = "メニューグループ名"
                    Label4.Text = "● グループ一覧"
                    btn_MenuDel.Enabled = False
                    btn_GrpAdd.Enabled = True
                    btn_GrpDel.Enabled = False
                    btn_Up.Enabled = True
                    btn_Dwn.Enabled = True
                    txt_Search.Enabled = False
                    btn_SelImg.Enabled = True
                    btn_DelImg.Enabled = True
                    chk_SpFlg.Enabled = False

                    Call LS_SetMenuGrp(L_MenuID, L_MenuGrpID, Nothing)               ' ジャンル一覧生成
                    Call LS_SetMenuCmbPat(L_MenuID, L_MenuGrpID)                     ' 画面表示方法 生成(グループ一覧画面)
                    Call LS_SetPictureImage(L_MenuID, L_MenuGrpID, Nothing)          ' 画像設定

                    'txt_MenuTitle.Enabled = true
                    '多言語機能対応
                    If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                        Label1.Text = "メニューグループ名"
                        Label6.Text = "メニューグループ名"
                        Label8.Text = "メニューグループ名"
                        btn_SelImg_A.Enabled = True
                        btn_DelImg_A.Enabled = True
                        Call LS_SetPictureImage_A(L_MenuID, L_MenuGrpID, Nothing)          ' 2013.02 日本語画像設定
                        txt_MenuTitle_A.Text = LF_GetMenuNM_A(e.Node, L_MenuID)          ' 多言語メニュー名称表示
                        'txt_MenuTitle_A.Enabled = True
                        If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 1 Then
                            btn_SelImg_B.Enabled = True
                            btn_DelImg_B.Enabled = True
                            Call LS_SetPictureImage_B(L_MenuID, L_MenuGrpID, Nothing)          ' 2013.02 日本語画像設定
                            txt_MenuTitle_B.Text = LF_GetMenuNM_B(e.Node, L_MenuID)          ' 多言語メニュー名称表示
                            'txt_MenuTitle_B.Enabled = True
                        Else
                            txt_MenuTitle_B.Text = ""          ' 多言語メニュー名称表示
                            txt_MenuTitle_B.Enabled = False
                        End If
                        If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 2 Then
                            btn_SelImg_C.Enabled = True
                            btn_DelImg_C.Enabled = True
                            Call LS_SetPictureImage_C(L_MenuID, L_MenuGrpID, Nothing)          ' 2013.02 日本語画像設定
                            txt_MenuTitle_C.Text = LF_GetMenuNM_C(e.Node, L_MenuID)          ' 多言語メニュー名称表示
                            'txt_MenuTitle_B.Enabled = True
                        Else
                            txt_MenuTitle_C.Text = ""          ' 多言語メニュー名称表示
                            txt_MenuTitle_C.Enabled = False
                        End If
                    End If

                Else
                    '------------------------------
                    ' [グループ]項目選択時
                    '------------------------------
                    L_MenuID = LF_GetMenuGrpCD(e.Node.Parent.Parent)
                    L_MenuGrpID = LF_GetMenuGrpCD(e.Node.Parent)
                    L_GrpID = LF_GetMenuGrpCD(e.Node)

                    Call GS_CboChgSel(cbo_Pat, LC_PAT_DIRC)
                    Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC4)
                    cbo_Pat.Enabled = False
                    cbo_Style.Enabled = True

                    Label2.Text = "グループ名"
                    Label4.Text = "● 商品一覧（選択済み）"
                    btn_MenuDel.Enabled = False
                    btn_GrpAdd.Enabled = False
                    btn_GrpDel.Enabled = True
                    btn_Up.Enabled = True
                    btn_Dwn.Enabled = True
                    txt_Search.Enabled = True
                    btn_SelImg.Enabled = True
                    btn_DelImg.Enabled = True
                    chk_SpFlg.Enabled = True

                    Call LS_SetMenuCmbPat(L_MenuID, L_MenuGrpID)                     ' 画面表示方法 生成(グループ一覧画面)
                    Call LS_SetMenuCmbStyle(L_MenuID, L_MenuGrpID, L_GrpID)          ' 画面表示方法 生成(商品一覧画面)
                    Call LS_SetMenuGrp(L_MenuID, L_MenuGrpID, L_GrpID)               ' 商品一覧(選択済み) 生成
                    Call LS_SetPictureImage(L_MenuID, L_MenuGrpID, L_GrpID)          ' 画像設定
                    Call LS_SetItemGrp()                                             ' 商品一覧 生成

                    '多言語機能対応
                    If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                        Label1.Text = "グループ名"
                        Label6.Text = "グループ名"
                        Label8.Text = "グループ名"
                        btn_SelImg_A.Enabled = True
                        btn_DelImg_A.Enabled = True
                        Call LS_SetPictureImage_A(L_MenuID, L_MenuGrpID, L_GrpID)        ' 英語語画像設定
                        txt_MenuTitle_A.Text = LF_GetMenuNM_A(e.Node, L_MenuID)          ' 多言語メニュー名称表示
                        'txt_MenuTitle_A.Enabled = True
                        If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 1 Then
                            btn_SelImg_B.Enabled = True
                            btn_DelImg_B.Enabled = True
                            Call LS_SetPictureImage_B(L_MenuID, L_MenuGrpID, L_GrpID)        ' 英語語画像設定
                            txt_MenuTitle_B.Text = LF_GetMenuNM_B(e.Node, L_MenuID)          ' 多言語メニュー名称表示
                            'txt_MenuTitle_B.Enabled = True
                        Else
                            txt_MenuTitle_B.Text = ""          ' 多言語メニュー名称表示
                            txt_MenuTitle_B.Enabled = False
                        End If
                        If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 2 Then
                            btn_SelImg_C.Enabled = True
                            btn_DelImg_C.Enabled = True
                            Call LS_SetPictureImage_C(L_MenuID, L_MenuGrpID, L_GrpID)        ' 英語語画像設定
                            txt_MenuTitle_C.Text = LF_GetMenuNM_C(e.Node, L_MenuID)          ' 多言語メニュー名称表示
                            'txt_MenuTitle_C.Enabled = True
                        Else
                            txt_MenuTitle_C.Text = ""          ' 多言語メニュー名称表示
                            txt_MenuTitle_C.Enabled = False
                        End If
                    End If

                End If
            End If

            txt_MenuTitle.Text = e.Node.Text
            L_ProcFlg2 = False
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("trv_Menu_AfterSelect")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品一覧設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetItemGrp()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim dtsData As New DataSet()
        Dim dtrData As DataRow = Nothing
        Dim objItem As ListViewItem

        Try
            '------------------------------
            ' 初期化処理
            '------------------------------
            lsv_ItemList.Clear()

            '------------------------------
            ' 商品一覧設定
            '------------------------------
            If Not LF_GetTPM010_1(dtsData) Then
                GoTo SYSTEM_ERROR
            End If

            '------------------------------
            ' 商品一覧設定
            '------------------------------
            With lsv_ItemList.Columns
                .Add("番号", 50, HorizontalAlignment.Center)
                .Add("商品名", 255, HorizontalAlignment.Left)
                If Trim$(GF_GetAppInfo("SALES_TAX_SWITCHING")) = 0 Then '消費税対応
                    .Add("税込額", 60, HorizontalAlignment.Right)
                Else
                    .Add("税抜額", 60, HorizontalAlignment.Right)
                End If
            End With

            If Not IsNothing(dtsData.Tables("com")) Then
                lngCnt = 0
                While lngCnt < dtsData.Tables("com").Rows.Count
                    If Not GF_GetRows(dtsData, lngCnt, dtrData) Then
                        Exit Sub
                    End If

                    objItem = New ListViewItem()
                    objItem.Text = Trim$(dtrData("GOODSCD"))
                    objItem.SubItems.Add(Trim$(dtrData("GOODSNMJ")) & Trim$(dtrData("GOODSNMJ2")))
                    If Trim$(GF_GetAppInfo("SALES_TAX_SWITCHING")) = 0 Then '消費税対応
                        objItem.SubItems.Add(Trim$(dtrData("TAXPRICE")))
                    Else
                        objItem.SubItems.Add(Trim$(dtrData("PRICE")))
                    End If
                    lsv_ItemList.Items.Add(objItem)
                    objItem = Nothing

                    lngCnt = lngCnt + 1
                End While
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetItemGrp")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニュー選択時の商品グループリスト設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetMenuGrp(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByVal pGroupCD As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim dtsData As New DataSet()
        Dim dtrData As DataRow = Nothing
        Dim lngCnt As Long
        Dim strWork As String = Nothing
        Dim objItem As ListViewItem

        '------------------------------
        ' 初期化処理
        '------------------------------
        lst_MenuGrp.Items.Clear()                                                    ' 隠し項目初期クリア

        If IsNothing(pMenuGrpID) Then
            '------------------------------
            ' メニューグループ一覧取得
            '------------------------------
            If Not LF_GetTPM060_3(pMenuID, dtsData) Then
                GoTo SYSTEM_ERROR
            End If
        Else
            If IsNothing(pGroupCD) Then
                '------------------------------
                ' ジャンル一覧取得
                '------------------------------
                If Not LF_GetTPM060_4(pMenuID, pMenuGrpID, dtsData) Then
                    GoTo SYSTEM_ERROR
                End If
            Else
                '------------------------------
                ' 商品グループ一覧取得
                '------------------------------
                If Not LF_GetTPM010_2(pGroupCD, dtsData) Then
                    GoTo SYSTEM_ERROR
                End If
            End If
        End If

        Try
            '------------------------------
            ' 子ノードレコード作成
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

                If IsNothing(pMenuGrpID) Then

                    strWork = Trim$(dtrData("MENUGRPID")) & vbTab & _
                              Trim$(dtrData("MENUGRPNM"))
                    lst_MenuGrp.Items.Add(strWork)

                Else
                    If IsNothing(pGroupCD) Then

                        strWork = Trim$(dtrData("GROUPCD")) & vbTab & _
                                  Trim$(dtrData("GROUPNM"))
                        lst_MenuGrp.Items.Add(strWork)

                    Else

                        If Trim$(GF_GetAppInfo("SALES_TAX_SWITCHING")) = 0 Then
                            strWork = Trim$(dtrData("GOODSCD")) & vbTab & _
                                      Trim$(dtrData("GOODSNMJ")) & Trim$(dtrData("GOODSNMJ2")) & vbTab & _
                                      Trim$(dtrData("TAXPRICE"))
                        Else
                            strWork = Trim$(dtrData("GOODSCD")) & vbTab & _
                                      Trim$(dtrData("GOODSNMJ")) & Trim$(dtrData("GOODSNMJ2")) & vbTab & _
                                      Trim$(dtrData("PRICE"))
                        End If
                        lst_MenuGrp.Items.Add(strWork)

                    End If
                End If

                lngCnt = lngCnt + 1
            End While

            If IsNothing(pMenuGrpID) Then
                Call LS_SetMenuGrpFromHide(LC_MENU)
            Else
                If IsNothing(pGroupCD) Then
                    Call LS_SetMenuGrpFromHide(LC_MENU_GRP)
                Else
                    Call LS_SetMenuGrpFromHide(LC_GRP)
                End If
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetMenuGrp")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニュー内商品グループリスト設定（隠し項目より表示域へ反映）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetMenuGrpFromHide(ByVal pSelCD As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim objItem As New ListViewItem
        Dim strWork() As String

        '------------------------------
        ' 初期化処理
        '------------------------------
        lsv_MenuGrp.Clear()                                                          ' 商品グループ一覧初期クリア

        Try
            Select Case pSelCD
                Case LC_MENU
                    '------------------------------
                    ' [メニュー]項目選択時
                    '------------------------------
                    With lsv_MenuGrp.Columns
                        .Add("番号", 0, HorizontalAlignment.Center)
                        .Add("メニューグループ名", 365, HorizontalAlignment.Left)
                    End With

                    For lngCnt = 0 To lst_MenuGrp.Items.Count - 1
                        strWork = Split(lst_MenuGrp.Items(lngCnt), vbTab)

                        objItem = New ListViewItem()
                        With objItem
                            .Text = strWork(0)
                            .SubItems.Add(strWork(1))
                        End With

                        lsv_MenuGrp.Items.Add(objItem)
                    Next
                Case LC_MENU_GRP
                    '------------------------------
                    ' [メニューグループ]項目選択時
                    '------------------------------
                    With lsv_MenuGrp.Columns
                        .Add("番号", 0, HorizontalAlignment.Center)
                        .Add("グループ名", 365, HorizontalAlignment.Left)
                    End With

                    For lngCnt = 0 To lst_MenuGrp.Items.Count - 1
                        strWork = Split(lst_MenuGrp.Items(lngCnt), vbTab)

                        objItem = New ListViewItem()
                        With objItem
                            .Text = strWork(0)
                            .SubItems.Add(strWork(1))
                        End With

                        lsv_MenuGrp.Items.Add(objItem)
                    Next

                Case LC_GRP
                    '------------------------------
                    ' [グループ]項目選択時
                    '------------------------------
                    With lsv_MenuGrp.Columns
                        .Add("番号", 50, HorizontalAlignment.Center)
                        .Add("商品名", 255, HorizontalAlignment.Left)
                        If Trim$(GF_GetAppInfo("SALES_TAX_SWITCHING")) = 0 Then   '消費税対応
                            .Add("税込額", 60, HorizontalAlignment.Right)
                        Else
                            .Add("税抜額", 60, HorizontalAlignment.Right)
                        End If
                    End With

                    For lngCnt = 0 To lst_MenuGrp.Items.Count - 1
                        strWork = Split(lst_MenuGrp.Items(lngCnt), vbTab)

                        objItem = New ListViewItem()
                        With objItem
                            .Text = strWork(0)
                            .SubItems.Add(strWork(1))
                            .SubItems.Add(strWork(2))
                        End With

                        lsv_MenuGrp.Items.Add(objItem)
                    Next
                Case Else
                    GoTo SYSTEM_ERROR
            End Select
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetMenuGrpFromHide")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューグループ／グループ画像表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetPictureImage(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByVal pGroupCD As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objFile As System.IO.FileStream
        Dim strGrpImgPath As String
        Dim dtsData As New DataSet()
        Dim dtrData As DataRow = Nothing

        Try
            If IsNothing(pMenuGrpID) Then
                '------------------------------
                ' [メニュー]項目選択時
                '------------------------------
                Exit Sub
                ' なにもしない
            Else
                If IsNothing(pGroupCD) Then
                    '------------------------------
                    ' [メニューグループ]項目選択時
                    '------------------------------
                    If Not LF_GetTPM061_1(pMenuID, pMenuGrpID, dtsData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    If Not GF_GetRows(dtsData, 0, dtrData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    strGrpImgPath = GF_GetAppInfo("MENUIMG_V")
                Else
                    '------------------------------
                    ' [グループ]項目選択時
                    '------------------------------
                    If Not LF_GetTPM020_1(pGroupCD, dtsData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    If Not GF_GetRows(dtsData, 0, dtrData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    strGrpImgPath = GF_GetAppInfo("GROUP_PATH")

                    If Trim$(dtrData("SPFLG")) = GC_TRUE Then
                        chk_SpFlg.Checked = True
                    Else
                        chk_SpFlg.Checked = False
                    End If
                End If
            End If

            If Len(Trim$(dtrData("IMAGEPATH"))) = 0 Then
                Exit Sub
            Else
                strGrpImgPath = strGrpImgPath & "\" & Trim$(dtrData("IMAGEPATH"))
                txt_ImagePath.Text = Trim$(dtrData("IMAGEPATH"))
            End If

            If Len(Trim$(strGrpImgPath)) <> 0 Then
                If System.IO.File.Exists(strGrpImgPath) = True Then
                    'GIF画像の場合
                    If Strings.Right(strGrpImgPath, 3) = "gif" Then
                        pic_Img.ImageLocation = strGrpImgPath
                    Else
                        objFile = New System.IO.FileStream(strGrpImgPath, IO.FileMode.Open, IO.FileAccess.Read)
                        pic_Img.Image = System.Drawing.Image.FromStream(objFile)
                        objFile.Close()
                    End If
                End If
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetPictureImage")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューグループ／グループ画像表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetPictureImage_A(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByVal pGroupCD As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objFile As System.IO.FileStream
        Dim strGrpImgPath As String
        Dim dtsData As New DataSet()
        Dim dtrData As DataRow = Nothing

        Try
            If IsNothing(pMenuGrpID) Then
                '------------------------------
                ' [メニュー]項目選択時
                '------------------------------
                Exit Sub
                ' なにもしない
            Else
                If IsNothing(pGroupCD) Then
                    '------------------------------
                    ' [メニューグループ]項目選択時
                    '------------------------------
                    If Not LF_GetTPM061A_1(pMenuID, pMenuGrpID, dtsData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    If Not GF_GetRows(dtsData, 0, dtrData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    strGrpImgPath = GF_GetAppInfo("MENUIMG_V")
                Else
                    '------------------------------
                    ' [グループ]項目選択時
                    '------------------------------
                    If Not LF_GetTPM020A_1(pGroupCD, dtsData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    If Not GF_GetRows(dtsData, 0, dtrData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    strGrpImgPath = GF_GetAppInfo("GROUP_PATH")

                    'If Trim$(dtrData("SPFLG")) = GC_TRUE Then
                    '    chk_SpFlg.Checked = True
                    'Else
                    '    chk_SpFlg.Checked = False
                    'End If
                End If
            End If

            If Len(Trim$(dtrData("IMAGEPATH"))) = 0 Then
                Exit Sub
            Else
                strGrpImgPath = strGrpImgPath & "\" & Trim$(dtrData("IMAGEPATH"))
                txt_ImagePath_A.Text = Trim$(dtrData("IMAGEPATH"))
            End If

            If Len(Trim$(strGrpImgPath)) <> 0 Then
                If System.IO.File.Exists(strGrpImgPath) = True Then
                    'GIF画像の場合
                    If Strings.Right(strGrpImgPath, 3) = "gif" Then
                        pic_img_A.ImageLocation = strGrpImgPath
                    Else
                        objFile = New System.IO.FileStream(strGrpImgPath, IO.FileMode.Open, IO.FileAccess.Read)
                        pic_img_A.Image = System.Drawing.Image.FromStream(objFile)
                        objFile.Close()
                    End If
                End If
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetPictureImage_A")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューグループ／グループ画像表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetPictureImage_B(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByVal pGroupCD As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objFile As System.IO.FileStream
        Dim strGrpImgPath As String
        Dim dtsData As New DataSet()
        Dim dtrData As DataRow = Nothing

        Try
            If IsNothing(pMenuGrpID) Then
                '------------------------------
                ' [メニュー]項目選択時
                '------------------------------
                Exit Sub
                ' なにもしない
            Else
                If IsNothing(pGroupCD) Then
                    '------------------------------
                    ' [メニューグループ]項目選択時
                    '------------------------------
                    If Not LF_GetTPM061B_1(pMenuID, pMenuGrpID, dtsData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    If Not GF_GetRows(dtsData, 0, dtrData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    strGrpImgPath = GF_GetAppInfo("MENUIMG_V")
                Else
                    '------------------------------
                    ' [グループ]項目選択時
                    '------------------------------
                    If Not LF_GetTPM020B_1(pGroupCD, dtsData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    If Not GF_GetRows(dtsData, 0, dtrData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    strGrpImgPath = GF_GetAppInfo("GROUP_PATH")

                    'If Trim$(dtrData("SPFLG")) = GC_TRUE Then
                    '    chk_SpFlg.Checked = True
                    'Else
                    '    chk_SpFlg.Checked = False
                    'End If
                End If
            End If

            If Len(Trim$(dtrData("IMAGEPATH"))) = 0 Then
                Exit Sub
            Else
                strGrpImgPath = strGrpImgPath & "\" & Trim$(dtrData("IMAGEPATH"))
                txt_ImagePath_B.Text = Trim$(dtrData("IMAGEPATH"))
            End If

            If Len(Trim$(strGrpImgPath)) <> 0 Then
                If System.IO.File.Exists(strGrpImgPath) = True Then
                    'GIF画像の場合
                    If Strings.Right(strGrpImgPath, 3) = "gif" Then
                        pic_img_B.ImageLocation = strGrpImgPath
                    Else
                        objFile = New System.IO.FileStream(strGrpImgPath, IO.FileMode.Open, IO.FileAccess.Read)
                        pic_img_B.Image = System.Drawing.Image.FromStream(objFile)
                        objFile.Close()
                    End If
                End If
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetPictureImage_B")
    End Sub

    Private Sub LS_SetPictureImage_C(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByVal pGroupCD As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objFile As System.IO.FileStream
        Dim strGrpImgPath As String
        Dim dtsData As New DataSet()
        Dim dtrData As DataRow = Nothing

        Try
            If IsNothing(pMenuGrpID) Then
                '------------------------------
                ' [メニュー]項目選択時
                '------------------------------
                Exit Sub
                ' なにもしない
            Else
                If IsNothing(pGroupCD) Then
                    '------------------------------
                    ' [メニューグループ]項目選択時
                    '------------------------------
                    If Not LF_GetTPM061C_1(pMenuID, pMenuGrpID, dtsData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    If Not GF_GetRows(dtsData, 0, dtrData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    strGrpImgPath = GF_GetAppInfo("MENUIMG_V")
                Else
                    '------------------------------
                    ' [グループ]項目選択時
                    '------------------------------
                    If Not LF_GetTPM020C_1(pGroupCD, dtsData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    If Not GF_GetRows(dtsData, 0, dtrData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    strGrpImgPath = GF_GetAppInfo("GROUP_PATH")

                    'If Trim$(dtrData("SPFLG")) = GC_TRUE Then
                    '    chk_SpFlg.Checked = True
                    'Else
                    '    chk_SpFlg.Checked = False
                    'End If
                End If
            End If

            If Len(Trim$(dtrData("IMAGEPATH"))) = 0 Then
                Exit Sub
            Else
                strGrpImgPath = strGrpImgPath & "\" & Trim$(dtrData("IMAGEPATH"))
                txt_ImagePath_C.Text = Trim$(dtrData("IMAGEPATH"))
            End If

            If Len(Trim$(strGrpImgPath)) <> 0 Then
                If System.IO.File.Exists(strGrpImgPath) = True Then
                    'GIF画像の場合
                    If Strings.Right(strGrpImgPath, 3) = "gif" Then
                        pic_img_C.ImageLocation = strGrpImgPath
                    Else
                        objFile = New System.IO.FileStream(strGrpImgPath, IO.FileMode.Open, IO.FileAccess.Read)
                        pic_img_C.Image = System.Drawing.Image.FromStream(objFile)
                        objFile.Close()
                    End If
                End If
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetPictureImage_C")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニュー画像マスタ一覧取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM061_1(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM061_1 = False

        '------------------------------
        ' メニュー画像マスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT FILENM AS IMAGEPATH"
        strSQL = strSQL & "  FROM TPM061"
        strSQL = strSQL & " WHERE MENUID    = '" & pMenuID & "'"
        strSQL = strSQL & "   AND MENUGRPID = '" & pMenuGrpID & "'"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM061_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニュー画像マスタ一覧取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM061A_1(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM061A_1 = False

        '------------------------------
        ' メニュー画像マスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT FILENM AS IMAGEPATH"
        strSQL = strSQL & "  FROM TPM061A"
        strSQL = strSQL & " WHERE MENUID    = '" & pMenuID & "'"
        strSQL = strSQL & "   AND MENUGRPID = '" & pMenuGrpID & "'"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM061A_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニュー画像マスタ一覧取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM061B_1(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM061B_1 = False

        '------------------------------
        ' メニュー画像マスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT FILENM AS IMAGEPATH"
        strSQL = strSQL & "  FROM TPM061B"
        strSQL = strSQL & " WHERE MENUID    = '" & pMenuID & "'"
        strSQL = strSQL & "   AND MENUGRPID = '" & pMenuGrpID & "'"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM061B_1 = True

    End Function

    Private Function LF_GetTPM061C_1(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM061C_1 = False

        '------------------------------
        ' メニュー画像マスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT FILENM AS IMAGEPATH"
        strSQL = strSQL & "  FROM TPM061C"
        strSQL = strSQL & " WHERE MENUID    = '" & pMenuID & "'"
        strSQL = strSQL & "   AND MENUGRPID = '" & pMenuGrpID & "'"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM061C_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループ一覧取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM020_1(ByVal pGroupCD As String, ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM020_1 = False

        '------------------------------
        ' 商品グループマスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT GROUPIMAGE AS IMAGEPATH,"
        strSQL = strSQL & "       SPFLG"
        strSQL = strSQL & "  FROM TPM020"
        strSQL = strSQL & " WHERE GROUPCD = '" & pGroupCD & "'"
        strSQL = strSQL & "   AND GOODSCD = '0000'"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM020_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループ一覧取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM020A_1(ByVal pGroupCD As String, ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM020A_1 = False

        '------------------------------
        ' 商品グループマスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT GROUPIMAGE AS IMAGEPATH "
        strSQL = strSQL & "  FROM TPM020A"
        strSQL = strSQL & " WHERE GROUPCD = '" & pGroupCD & "'"
        strSQL = strSQL & "   AND GOODSCD = '0000'"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM020A_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループ一覧取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM020B_1(ByVal pGroupCD As String, ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM020B_1 = False

        '------------------------------
        ' 商品グループマスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT GROUPIMAGE AS IMAGEPATH "
        strSQL = strSQL & "  FROM TPM020B"
        strSQL = strSQL & " WHERE GROUPCD = '" & pGroupCD & "'"
        strSQL = strSQL & "   AND GOODSCD = '0000'"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM020B_1 = True

    End Function

    Private Function LF_GetTPM020C_1(ByVal pGroupCD As String, ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM020C_1 = False

        '------------------------------
        ' 商品グループマスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT GROUPIMAGE AS IMAGEPATH "
        strSQL = strSQL & "  FROM TPM020C"
        strSQL = strSQL & " WHERE GROUPCD = '" & pGroupCD & "'"
        strSQL = strSQL & "   AND GOODSCD = '0000'"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM020C_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニュー内商品グループリスト設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetMenuCmbPat(ByVal pMenuID As String, ByVal pMenuGrpID As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim dtsData As New DataSet()
        Dim dtrData As DataRow = Nothing
        Dim strWork As String = Nothing

        Try
            '------------------------------
            ' チェックボックスの設定
            '------------------------------
            dtsData = New DataSet()
            If LF_GetTPM060_2(pMenuID, pMenuGrpID, dtsData) = False Then
                GoTo SYSTEM_ERROR
            End If

            If dtsData.Tables("com").Rows.Count <> 0 Then
                If Not GF_GetRows(dtsData, 0, dtrData) Then
                    GoTo SYSTEM_ERROR
                End If

                Select Case Trim$(dtrData("MENUSTYLE"))
                    Case GC_MSTYLE_MENUGRP_DIRC4, GC_MSTYLE_MENUGRP_DIRC6, GC_MSTYLE_MENUGRP_DIRC9, GC_MSTYLE_MENUGRP_DIRC16, GC_MSTYLE_MENUGRP_DIRCDAILY, _
                            GC_MSTYLE_MENUGRP_DIRCFREE1, GC_MSTYLE_MENUGRP_DIRCFREE2, GC_MSTYLE_MENUGRP_DIRCFREE3, GC_MSTYLE_MENUGRP_DIRCFREE4, GC_MSTYLE_MENUGRP_DIRCFREE5, GC_MSTYLE_MENUGRP_DIRCFREE6, _
                            GC_MSTYLE_MENUGRP_DIRCFREE7, GC_MSTYLE_MENUGRP_DIRCFREE8, GC_MSTYLE_MENUGRP_DIRCFREE9, GC_MSTYLE_MENUGRP_DIRCFREE10, GC_MSTYLE_MENUGRP_DIRCFREE11, GC_MSTYLE_MENUGRP_DIRCFREE12, _
                            GC_MSTYLE_MENUGRP_DIRCFREE13, GC_MSTYLE_MENUGRP_DIRCFREE14, GC_MSTYLE_MENUGRP_DIRCFREE15, GC_MSTYLE_MENUGRP_DIRCFREE16, GC_MSTYLE_MENUGRP_DIRCFREE17, GC_MSTYLE_MENUGRP_DIRCFREE18
                        Call GS_CboChgSel(cbo_Pat, LC_PAT_DIRC)

                        Select Case Trim$(dtrData("MENUSTYLE"))
                            Case GC_MSTYLE_MENUGRP_DIRC4
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC4)

                            Case GC_MSTYLE_MENUGRP_DIRC6
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC6)

                            Case GC_MSTYLE_MENUGRP_DIRC9
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC9)

                            Case GC_MSTYLE_MENUGRP_DIRC16
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC16)

                            Case GC_MSTYLE_MENUGRP_DIRCDAILY
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_DAILY)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE1
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE1)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE2
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE2)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE3
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE3)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE4
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE4)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE5
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE5)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE6
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE6)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE7
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE7)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE8
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE8)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE9
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE9)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE10
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE10)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE11
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE11)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE12
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE12)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE13
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE13)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE14
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE14)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE15
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE15)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE16
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE16)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE17
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE17)

                            Case GC_MSTYLE_MENUGRP_DIRCFREE18
                                Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE18)
                        End Select

                        If L_GrpID = "" Then
                            ' メニューグループ選択時
                            '商品一覧直接表示時は、「商品一覧画面」ドロップダウンは活性とする
                            cbo_Style.Enabled = True
                        Else
                            ' グループ選択時
                            '商品一覧直接表示時は、「商品一覧画面」ドロップダウンは非活性とする
                            cbo_Style.Enabled = False
                        End If

                    Case GC_MSTYLE_MENUGRP_PIC4
                        Call GS_CboChgSel(cbo_Pat, LC_PAT_PIC4)

                    Case GC_MSTYLE_MENUGRP_PIC6
                        Call GS_CboChgSel(cbo_Pat, LC_PAT_PIC6)

                    Case GC_MSTYLE_MENUGRP_PIC9
                        Call GS_CboChgSel(cbo_Pat, LC_PAT_PIC9)

                    Case GC_MSTYLE_MENUGRP_PIC16
                        Call GS_CboChgSel(cbo_Pat, LC_PAT_PIC16)

                End Select
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetMenuCmbPat")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニュー内商品グループリスト設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetMenuCmbStyle(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByVal pGrpID As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim dtsData As New DataSet()
        Dim dtrData As DataRow = Nothing
        Dim strWork As String = Nothing

        Try
            '------------------------------
            ' チェックボックスの設定
            '------------------------------
            dtsData = New DataSet()
            If LF_GetTPM060_5(pMenuID, pMenuGrpID, pGrpID, dtsData) = False Then
                GoTo SYSTEM_ERROR
            End If

            If dtsData.Tables("com").Rows.Count <> 0 Then
                If Not GF_GetRows(dtsData, 0, dtrData) Then
                    GoTo SYSTEM_ERROR
                End If

                Select Case Trim$(dtrData("MENUSTYLE"))
                    Case GC_MSTYLE_GOODS_PIC4
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC4)

                    Case GC_MSTYLE_GOODS_PIC6
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC6)

                    Case GC_MSTYLE_GOODS_PIC9
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC9)

                    Case GC_MSTYLE_GOODS_PIC16
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_PIC16)

                    Case GC_MSTYLE_GOODS_DAILY
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_DAILY)

                    Case GC_MSTYLE_GOODS_FREE1
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE1)

                    Case GC_MSTYLE_GOODS_FREE2
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE2)

                    Case GC_MSTYLE_GOODS_FREE3
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE3)

                    Case GC_MSTYLE_GOODS_FREE4
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE4)

                    Case GC_MSTYLE_GOODS_FREE5
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE5)

                    Case GC_MSTYLE_GOODS_FREE6
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE6)

                    Case GC_MSTYLE_GOODS_FREE7
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE7)

                    Case GC_MSTYLE_GOODS_FREE8
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE8)

                    Case GC_MSTYLE_GOODS_FREE9
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE9)

                    Case GC_MSTYLE_GOODS_FREE10
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE10)

                    Case GC_MSTYLE_GOODS_FREE11
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE11)

                    Case GC_MSTYLE_GOODS_FREE12
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE12)

                    Case GC_MSTYLE_GOODS_FREE13
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE13)

                    Case GC_MSTYLE_GOODS_FREE14
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE14)

                    Case GC_MSTYLE_GOODS_FREE15
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE15)

                    Case GC_MSTYLE_GOODS_FREE16
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE16)

                    Case GC_MSTYLE_GOODS_FREE17
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE17)

                    Case GC_MSTYLE_GOODS_FREE18
                        Call GS_CboChgSel(cbo_Style, LC_STYLE_FREE18)
                End Select
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetMenuCmbStyle")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューグループ／グループ／商品一覧(選択済み) ドラッグ開始時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_MenuGrp_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_MenuGrp.ItemDrag

        ' ドラッグ処理開始
        L_blnDragMode = False
        lsv_MenuGrp.DoDragDrop(lsv_MenuGrp.SelectedItems, DragDropEffects.Copy)

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューグループ／グループ／商品一覧(選択済み) ドラッグ中処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_MenuGrp_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_MenuGrp.DragEnter

        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューグループ／グループ／商品一覧(選択済み) ドロップ時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_MenuGrp_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_MenuGrp.DragDrop

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objItem As ListViewItem
        Dim objPoint As Point
        Dim objNode As TreeNode = Nothing
        Dim intChgPos As Integer = 0

        '------------------------------
        ' ツリービュー未選択時は何もしない
        '------------------------------
        If trv_Menu.Nodes.Count = 0 Then
            Exit Sub
        End If

        '------------------------------
        ' ツリービューの値取得
        '------------------------------
        objNode = trv_Menu.SelectedNode
        If IsNothing(objNode.Parent) Then
            '------------------------------
            ' [メニュー]項目選択時
            '------------------------------
            ' 何もなし
        Else
            If IsNothing(objNode.Parent.Parent) Then
                '------------------------------
                ' [メニューグループ]項目選択時
                '------------------------------
                If L_blnDragMode = False Then
                    objPoint = lsv_MenuGrp.PointToClient(New Point(e.X, e.Y))
                    objItem = lsv_MenuGrp.GetItemAt(objPoint.X, objPoint.Y)

                    '------------------------------
                    ' ツリービューインデックス取得
                    '------------------------------
                    Call LS_GetTreeViweIndex()

                    '------------------------------
                    ' インデックス未取得時は最大値を設定
                    '------------------------------
                    If IsNothing(objItem) Then
                        intChgPos = lsv_MenuGrp.Items.Count - 1
                    Else
                        intChgPos = objItem.Index
                    End If

                    '------------------------------
                    ' 表示順変更処理
                    '------------------------------
                    Call LS_ItemMove(intChgPos, e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))

                    '------------------------------
                    ' メニューツリー生成処理
                    '------------------------------
                    Call LS_SetMenuTree()

                    '------------------------------
                    ' ツリービューインデックス設定
                    '------------------------------
                    Call LS_SetTreeViweIndex()
                End If
            Else
                '------------------------------
                ' [グループ]項目選択時
                '------------------------------
                If L_blnDragMode = False Then
                    objPoint = lsv_MenuGrp.PointToClient(New Point(e.X, e.Y))
                    objItem = lsv_MenuGrp.GetItemAt(objPoint.X, objPoint.Y)

                    '------------------------------
                    ' インデックス未取得時は最大値を設定
                    '------------------------------
                    If IsNothing(objItem) Then
                        intChgPos = lsv_MenuGrp.Items.Count - 1
                    Else
                        intChgPos = objItem.Index
                    End If

                    Call LS_ItemMove(intChgPos, e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))

                Else
                    If Not e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then
                        Exit Sub
                    End If

                    Call LS_AddItems(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
                End If
            End If
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品一覧 ドラッグ開始時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_ItemList_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_ItemList.ItemDrag

        ' ドラッグ処理開始
        L_blnDragMode = True
        lsv_MenuGrp.DoDragDrop(lsv_ItemList.SelectedItems, DragDropEffects.Copy)

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品一覧 ドラッグ中処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_ItemList_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemList.DragEnter

        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品一覧 ドロップ時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_ItemList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemList.DragDrop

        If L_blnDragMode = True Then
            Exit Sub
        End If

        If Not e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then
            Exit Sub
        End If

        Call LS_RemoveItems(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))

    End Sub

    Private Sub LS_AddItems(ByVal pTargetData As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngDataCnt As Integer
        Dim lngCnt As Integer
        Dim lngRefCnt As Integer
        Dim blnExists As Boolean

        If pTargetData.Count = 0 Then
            Exit Sub
        End If

        lngDataCnt = pTargetData.Count
        lngCnt = 0
        lngRefCnt = 0
        For lngCnt = 0 To lngDataCnt - 1
            '------------------------------
            ' 追加先グループコード取得
            '------------------------------
            If Not LF_GetTPM020_2(L_GrpID, _
                                  pTargetData.Item(lngRefCnt).Text, _
                                  blnExists) Then
                GoTo SYSTEM_ERROR
            End If

            If blnExists Then
                lngRefCnt = lngRefCnt + 1
            Else
                '------------------------------
                ' ＤＢ更新処理
                '------------------------------
                If Not LF_UpdTPM020_5(LC_UPDKBN_ADD, L_GrpID, Trim$(pTargetData.Item(lngRefCnt).Text)) Then
                    GoTo SYSTEM_ERROR
                End If

                lngRefCnt = lngRefCnt + 1
            End If
        Next

        '------------------------------
        ' 商品一覧(選択済み) 生成
        '------------------------------
        Call LS_SetMenuGrp(L_MenuID, L_MenuGrpID, L_GrpID)

        '------------------------------
        ' 表示順項目更新処理
        '------------------------------
        If Not LF_UpdTPM020_2() Then
            GoTo SYSTEM_ERROR
        End If

        L_EditFlg = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AddItems")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ／グループ内重複チェック
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM020_2(ByVal pGroupCD As String, ByVal pGoodsCD As String, ByRef pExists As Boolean) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM020_2 = False
        pExists = False

        strSQL = ""
        strSQL = strSQL & "SELECT GOODSCD"
        strSQL = strSQL & "  FROM TPM020"
        strSQL = strSQL & " WHERE GROUPCD = '" & pGroupCD & "'"
        strSQL = strSQL & "   AND GOODSCD = '" & pGoodsCD & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            pExists = False
        Else
            pExists = True
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPM020_2 = True

    End Function

    Private Sub LS_RemoveItems(ByVal pTargetData As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Integer
        Dim objNode As TreeNode = Nothing

        If pTargetData.Count = 0 Then
            Exit Sub
        End If

        '------------------------------
        ' 削除先グループコード取得
        '------------------------------
        objNode = trv_Menu.SelectedNode
        If IsNothing(objNode.Parent) Then
            '------------------------------
            ' [メニュー]項目選択時
            '------------------------------
            ' 何もなし
        Else
            If IsNothing(objNode.Parent.Parent) Then
                '------------------------------
                ' [メニューグループ]項目選択時
                '------------------------------
                ' 何もなし
            Else
                '------------------------------
                ' [グループ]項目選択時
                '------------------------------
                lngCnt = 0
                While lngCnt < pTargetData.Count
                    '------------------------------
                    ' ＤＢ更新処理
                    '------------------------------
                    If Not LF_UpdTPM020_5(LC_UPDKBN_DEL, L_GrpID, Trim$(pTargetData.Item(lngCnt).Text)) Then
                        GoTo SYSTEM_ERROR
                    End If

                    lngCnt = lngCnt + 1
                End While

                '------------------------------
                ' 商品一覧(選択済み) 生成
                '------------------------------
                Call LS_SetMenuGrp(L_MenuID, L_MenuGrpID, L_GrpID)

                '------------------------------
                ' 表示順項目更新処理
                '------------------------------
                If Not LF_UpdTPM020_2() Then
                    GoTo SYSTEM_ERROR
                End If

                L_EditFlg = True
            End If
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_RemoveItems")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ更新処理(グループ内商品コード追加/削除処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM020_5(ByVal pUpdKbn As String, ByVal pGroupCD As String, ByVal pGoodsCD As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strSQL2 As String
        Dim strSQL3 As String
        Dim strSQL4 As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020_5 = False

        strSQL = ""
        strSQL2 = ""
        strSQL3 = ""
        strSQL4 = ""
        Select Case pUpdKbn
            Case LC_UPDKBN_ADD
                strSQL = strSQL & "INSERT INTO TPM020 VALUES("
                strSQL = strSQL & "'" & pGroupCD & "',"
                strSQL = strSQL & "'" & pGoodsCD & "',"
                strSQL = strSQL & "'" & Space(100) & "',"
                strSQL = strSQL & "'" & Space(360) & "',"
                strSQL = strSQL & "'" & Space(100) & "',"
                strSQL = strSQL & "'" & Space(1) & "',"
                strSQL = strSQL & "'9999999999',"
                strSQL = strSQL & "'" & GC_TRUE & "',"
                strSQL = strSQL & "'" & Space(1) & "',"
                strSQL = strSQL & "'" & GC_UPDID & "',"
                strSQL = strSQL & "'" & Now & "')"
                '多言語機能対応
                If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                    strSQL2 = strSQL2 & "INSERT INTO TPM020A VALUES("
                    strSQL2 = strSQL2 & "N'" & pGroupCD & "',"
                    strSQL2 = strSQL2 & "N'" & pGoodsCD & "',"
                    strSQL2 = strSQL2 & "N'" & Space(100) & "',"
                    strSQL2 = strSQL2 & "N'" & Space(360) & "',"
                    strSQL2 = strSQL2 & "N'" & Space(100) & "',"
                    strSQL2 = strSQL2 & "N'" & Space(1) & "',"
                    strSQL2 = strSQL2 & "N'9999999999',"
                    strSQL2 = strSQL2 & "N'" & GC_TRUE & "',"
                    strSQL2 = strSQL2 & "N'" & Space(1) & "',"
                    strSQL2 = strSQL2 & "N'" & GC_UPDID & "',"
                    strSQL2 = strSQL2 & "N'" & Now & "')"

                    strSQL3 = strSQL3 & "INSERT INTO TPM020B VALUES("
                    strSQL3 = strSQL3 & "N'" & pGroupCD & "',"
                    strSQL3 = strSQL3 & "N'" & pGoodsCD & "',"
                    strSQL3 = strSQL3 & "N'" & Space(100) & "',"
                    strSQL3 = strSQL3 & "N'" & Space(360) & "',"
                    strSQL3 = strSQL3 & "N'" & Space(100) & "',"
                    strSQL3 = strSQL3 & "N'" & Space(1) & "',"
                    strSQL3 = strSQL3 & "N'9999999999',"
                    strSQL3 = strSQL3 & "N'" & GC_TRUE & "',"
                    strSQL3 = strSQL3 & "N'" & Space(1) & "',"
                    strSQL3 = strSQL3 & "N'" & GC_UPDID & "',"
                    strSQL3 = strSQL3 & "N'" & Now & "')"

                    strSQL4 = strSQL4 & "INSERT INTO TPM020C VALUES("
                    strSQL4 = strSQL4 & "N'" & pGroupCD & "',"
                    strSQL4 = strSQL4 & "N'" & pGoodsCD & "',"
                    strSQL4 = strSQL4 & "N'" & Space(100) & "',"
                    strSQL4 = strSQL4 & "N'" & Space(360) & "',"
                    strSQL4 = strSQL4 & "N'" & Space(100) & "',"
                    strSQL4 = strSQL4 & "N'" & Space(1) & "',"
                    strSQL4 = strSQL4 & "N'9999999999',"
                    strSQL4 = strSQL4 & "N'" & GC_TRUE & "',"
                    strSQL4 = strSQL4 & "N'" & Space(1) & "',"
                    strSQL4 = strSQL4 & "N'" & GC_UPDID & "',"
                    strSQL4 = strSQL4 & "N'" & Now & "')"
                End If

            Case LC_UPDKBN_DEL
                strSQL = strSQL & "DELETE FROM TPM020"
                strSQL = strSQL & " WHERE GROUPCD = '" & pGroupCD & "'"
                strSQL = strSQL & "   AND GOODSCD = '" & pGoodsCD & "'"

                '多言語機能対応
                If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                    strSQL2 = strSQL2 & "DELETE FROM TPM020A"
                    strSQL2 = strSQL2 & " WHERE GROUPCD = '" & pGroupCD & "'"
                    strSQL2 = strSQL2 & "   AND GOODSCD = '" & pGoodsCD & "'"

                    strSQL3 = strSQL3 & "DELETE FROM TPM020B"
                    strSQL3 = strSQL3 & " WHERE GROUPCD = '" & pGroupCD & "'"
                    strSQL3 = strSQL3 & "   AND GOODSCD = '" & pGoodsCD & "'"

                    strSQL4 = strSQL4 & "DELETE FROM TPM020C"
                    strSQL4 = strSQL4 & " WHERE GROUPCD = '" & pGroupCD & "'"
                    strSQL4 = strSQL4 & "   AND GOODSCD = '" & pGoodsCD & "'"
                End If

            Case Else
                Exit Function
        End Select

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        '多言語機能対応
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            If Not GF_UpdData(strSQL2) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            If Not GF_UpdData(strSQL3) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            If Not GF_UpdData(strSQL4) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If
        End If

        '------------------------------
        ' トランザクション確定
        '------------------------------
        If Not GF_CommitTrans() Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020_5 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：(ＤＢ更新契機)グループ名テキストボックス 入力値変更時処理
    ' 　機能概要：入力内容を逐一、ツリービューへ通知し、ＤＢ更新を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_MenuTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MenuTitle.TextChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objNode As TreeNode = Nothing
        Dim udtUpdVal As typTPM060 = Nothing
        Dim udtUpdKey As typTPM060 = Nothing
        'Dim lngST As Long
        Dim udtUpdVal20 As typTPM020 = Nothing
        Dim udtUpdKey20 As typTPM020 = Nothing

        If IsNothing(trv_Menu.SelectedNode) Then
            Exit Sub
        End If

        If txt_MenuTitle.Modified = False Then
            Exit Sub
        End If

        ' 2014-04-25 2バイト文字制限解除
        'lngST = txt_MenuTitle.SelectionStart
        'txt_MenuTitle.Text = StrConv(txt_MenuTitle.Text, VbStrConv.Wide)
        'If lngST >= 0 Then
        '    txt_MenuTitle.SelectionStart = lngST
        'End If

        '------------------------------
        ' ツリービューへの入力値反映
        '------------------------------
        objNode = trv_Menu.SelectedNode
        If IsNothing(objNode.Parent) Then
            If GF_LenB(txt_MenuTitle.Text) > 50 Then
                txt_MenuTitle.Text = GF_MidB(txt_MenuTitle.Text, 1, 50)
                txt_MenuTitle.SelectionStart = GF_LenB(txt_MenuTitle.Text)
            End If
        Else
            If IsNothing(objNode.Parent.Parent) Then
                If GF_LenB(txt_MenuTitle.Text) > 36 Then
                    txt_MenuTitle.Text = GF_MidB(txt_MenuTitle.Text, 1, 36)
                    txt_MenuTitle.SelectionStart = GF_LenB(txt_MenuTitle.Text)
                End If
            Else
                If GF_LenB(txt_MenuTitle.Text) > 40 Then
                    txt_MenuTitle.Text = GF_MidB(txt_MenuTitle.Text, 1, 40)
                    txt_MenuTitle.SelectionStart = GF_LenB(txt_MenuTitle.Text)
                End If
            End If
        End If
        objNode.Text = txt_MenuTitle.Text

        '------------------------------
        ' ＤＢへの入力値反映(更新)
        '------------------------------
        If IsNothing(objNode.Parent) Then
            udtUpdKey.MENUID = LF_GetMenuGrpCD(objNode)
            udtUpdVal.MENUNM = GF_RepQuo(Trim$(txt_MenuTitle.Text))
            udtUpdVal.UPDID = GC_UPDID
            udtUpdVal.UPDYMD = Now

            If Not LF_UpdTPM060_2(udtUpdVal, udtUpdKey, 1) Then
                GoTo SYSTEM_ERROR
            End If
        Else
            If IsNothing(objNode.Parent.Parent) Then
                udtUpdKey.MENUID = LF_GetMenuGrpCD(objNode.Parent)
                udtUpdKey.MENUGRPID = LF_GetMenuGrpCD(objNode)
                udtUpdVal.MENUGRPNM = GF_RepQuo(Trim$(txt_MenuTitle.Text))
                udtUpdVal.UPDID = GC_UPDID
                udtUpdVal.UPDYMD = Now

                If Not LF_UpdTPM060_2(udtUpdVal, udtUpdKey, 0) Then
                    GoTo SYSTEM_ERROR
                End If
            Else
                udtUpdKey20.GROUPCD = LF_GetMenuGrpCD(objNode)
                udtUpdKey20.GOODSCD = "0000"
                udtUpdVal20.GROUPNM = GF_RepQuo(Trim$(txt_MenuTitle.Text))
                udtUpdVal20.UPDID = GC_UPDID
                udtUpdVal20.UPDYMD = Now

                If Not LF_UpdTPM020_1(udtUpdVal20, udtUpdKey20) Then
                    GoTo SYSTEM_ERROR
                End If
            End If
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_MenuTitle_TextChanged")
    End Sub

    ' 　機　　能：(ＤＢ更新契機)グループ名テキストボックス 入力値変更時処理
    ' 　機能概要：入力内容を逐一、ツリービューへ通知し、ＤＢ更新を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.02.06 クレスコ北陸 新規作成
    '   　　　　：多言語メニュー名称入力欄更新用
    ' --------------------------------------------------------------------------------
    Private Sub txt_MenuTitle_A_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MenuTitle_A.TextChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objNode As TreeNode = Nothing
        Dim udtUpdVal As typTPM060A = Nothing
        Dim udtUpdKey As typTPM060A = Nothing
        Dim lngST As Long
        Dim udtUpdVal20 As typTPM020A = Nothing
        Dim udtUpdKey20 As typTPM020A = Nothing

        If IsNothing(trv_Menu.SelectedNode) Then
            Exit Sub
        End If

        If txt_MenuTitle_A.Modified = False Then
            Exit Sub
        End If

        lngST = txt_MenuTitle_A.SelectionStart
        txt_MenuTitle_A.Text = StrConv(txt_MenuTitle_A.Text, VbStrConv.None, 1041)
        If lngST >= 0 Then
            txt_MenuTitle_A.SelectionStart = lngST
        End If

        '------------------------------
        ' ツリービューへの入力値反映
        '------------------------------
        objNode = trv_Menu.SelectedNode
        If IsNothing(objNode.Parent) Then
            If GF_LenB(txt_MenuTitle_A.Text) > 50 Then
                txt_MenuTitle_A.Text = GF_MidB(txt_MenuTitle_A.Text, 1, 50)
                txt_MenuTitle_A.SelectionStart = GF_LenB(txt_MenuTitle_A.Text)
            End If
        Else
            If IsNothing(objNode.Parent.Parent) Then
                If GF_LenB(txt_MenuTitle_A.Text) > 36 Then
                    txt_MenuTitle_A.Text = GF_MidB(txt_MenuTitle_A.Text, 1, 36)
                    txt_MenuTitle_A.SelectionStart = GF_LenB(txt_MenuTitle_A.Text)
                End If
            Else
                If GF_LenB(txt_MenuTitle_A.Text) > 40 Then
                    txt_MenuTitle_A.Text = GF_MidB(txt_MenuTitle_A.Text, 1, 40)
                    txt_MenuTitle_A.SelectionStart = GF_LenB(txt_MenuTitle_A.Text)
                End If
            End If
        End If
        'objNode.Text = txt_MenuTitle_J.Text

        '------------------------------
        ' ＤＢへの入力値反映(更新)
        '------------------------------
        If IsNothing(objNode.Parent) Then
            udtUpdKey.MENUID = LF_GetMenuGrpCD(objNode)
            udtUpdVal.MENUNM = GF_RepQuo(Trim$(txt_MenuTitle_A.Text))
            udtUpdVal.UPDID = GC_UPDID
            udtUpdVal.UPDYMD = Now

            If Not LF_UpdTPM060A_2(udtUpdVal, udtUpdKey) Then
                GoTo SYSTEM_ERROR
            End If
        Else
            If IsNothing(objNode.Parent.Parent) Then
                udtUpdKey.MENUID = LF_GetMenuGrpCD(objNode.Parent)
                udtUpdKey.MENUGRPID = LF_GetMenuGrpCD(objNode)
                udtUpdVal.MENUGRPNM = GF_RepQuo(Trim$(txt_MenuTitle_A.Text))
                udtUpdVal.UPDID = GC_UPDID
                udtUpdVal.UPDYMD = Now

                If Not LF_UpdTPM060A_2(udtUpdVal, udtUpdKey) Then
                    GoTo SYSTEM_ERROR
                End If
            Else
                udtUpdKey20.GROUPCD = LF_GetMenuGrpCD(objNode)
                udtUpdKey20.GOODSCD = "0000"
                udtUpdVal20.GROUPNM = GF_RepQuo(Trim$(txt_MenuTitle_A.Text))
                udtUpdVal20.UPDID = GC_UPDID
                udtUpdVal20.UPDYMD = Now

                If Not LF_UpdTPM020A_1(udtUpdVal20, udtUpdKey20) Then
                    GoTo SYSTEM_ERROR
                End If
            End If
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_MenuTitle_A_TextChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：(ＤＢ更新契機)グループ名テキストボックス 入力値変更時処理
    ' 　機能概要：入力内容を逐一、ツリービューへ通知し、ＤＢ更新を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_MenuTitle_B_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MenuTitle_B.TextChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objNode As TreeNode = Nothing
        Dim udtUpdVal As typTPM060B = Nothing
        Dim udtUpdKey As typTPM060B = Nothing
        Dim lngST As Long
        Dim udtUpdVal20 As typTPM020B = Nothing
        Dim udtUpdKey20 As typTPM020B = Nothing

        If IsNothing(trv_Menu.SelectedNode) Then
            Exit Sub
        End If

        If txt_MenuTitle_B.Modified = False Then
            Exit Sub
        End If

        lngST = txt_MenuTitle_B.SelectionStart
        txt_MenuTitle_B.Text = StrConv(txt_MenuTitle_B.Text, VbStrConv.None)
        If lngST >= 0 Then
            txt_MenuTitle_B.SelectionStart = lngST
        End If

        '------------------------------
        ' ツリービューへの入力値反映
        '------------------------------
        objNode = trv_Menu.SelectedNode
        If IsNothing(objNode.Parent) Then
            If GF_LenB(txt_MenuTitle_B.Text) > 50 Then
                txt_MenuTitle_B.Text = GF_MidB(txt_MenuTitle_B.Text, 1, 50)
                txt_MenuTitle_B.SelectionStart = GF_LenB(txt_MenuTitle_B.Text)
            End If
        Else
            If IsNothing(objNode.Parent.Parent) Then
                If GF_LenB(txt_MenuTitle_B.Text) > 36 Then
                    txt_MenuTitle_B.Text = GF_MidB(txt_MenuTitle_B.Text, 1, 36)
                    txt_MenuTitle_B.SelectionStart = GF_LenB(txt_MenuTitle_B.Text)
                End If
            Else
                If GF_LenB(txt_MenuTitle_B.Text) > 40 Then
                    txt_MenuTitle_B.Text = GF_MidB(txt_MenuTitle_B.Text, 1, 40)
                    txt_MenuTitle_B.SelectionStart = GF_LenB(txt_MenuTitle_B.Text)
                End If
            End If
        End If
        'objNode.Text = txt_MenuTitle.Text

        '------------------------------
        ' ＤＢへの入力値反映(更新)
        '------------------------------
        If IsNothing(objNode.Parent) Then
            udtUpdKey.MENUID = LF_GetMenuGrpCD(objNode)
            udtUpdVal.MENUNM = GF_RepQuo(Trim$(txt_MenuTitle_B.Text))
            udtUpdVal.UPDID = GC_UPDID
            udtUpdVal.UPDYMD = Now

            If Not LF_UpdTPM060B_2(udtUpdVal, udtUpdKey) Then
                GoTo SYSTEM_ERROR
            End If
        Else
            If IsNothing(objNode.Parent.Parent) Then
                udtUpdKey.MENUID = LF_GetMenuGrpCD(objNode.Parent)
                udtUpdKey.MENUGRPID = LF_GetMenuGrpCD(objNode)
                udtUpdVal.MENUGRPNM = GF_RepQuo(Trim$(txt_MenuTitle_B.Text))
                udtUpdVal.UPDID = GC_UPDID
                udtUpdVal.UPDYMD = Now

                If Not LF_UpdTPM060B_2(udtUpdVal, udtUpdKey) Then
                    GoTo SYSTEM_ERROR
                End If
            Else
                udtUpdKey20.GROUPCD = LF_GetMenuGrpCD(objNode)
                udtUpdKey20.GOODSCD = "0000"
                udtUpdVal20.GROUPNM = GF_RepQuo(Trim$(txt_MenuTitle_B.Text))
                udtUpdVal20.UPDID = GC_UPDID
                udtUpdVal20.UPDYMD = Now

                If Not LF_UpdTPM020B_1(udtUpdVal20, udtUpdKey20) Then
                    GoTo SYSTEM_ERROR
                End If
            End If
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_MenuTitle_B_TextChanged")
    End Sub

    Private Sub txt_MenuTitle_C_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MenuTitle_C.TextChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objNode As TreeNode = Nothing
        Dim udtUpdVal As typTPM060C = Nothing
        Dim udtUpdKey As typTPM060C = Nothing
        Dim lngST As Long
        Dim udtUpdVal20 As typTPM020C = Nothing
        Dim udtUpdKey20 As typTPM020C = Nothing

        If IsNothing(trv_Menu.SelectedNode) Then
            Exit Sub
        End If

        If txt_MenuTitle_C.Modified = False Then
            Exit Sub
        End If

        lngST = txt_MenuTitle_C.SelectionStart
        txt_MenuTitle_C.Text = StrConv(txt_MenuTitle_C.Text, VbStrConv.None)
        If lngST >= 0 Then
            txt_MenuTitle_C.SelectionStart = lngST
        End If

        '------------------------------
        ' ツリービューへの入力値反映
        '------------------------------
        objNode = trv_Menu.SelectedNode
        If IsNothing(objNode.Parent) Then
            If GF_LenB_Korea(txt_MenuTitle_C.Text) > 50 Then
                txt_MenuTitle_C.Text = GF_MidB_Korea(txt_MenuTitle_C.Text, 1, 50)
                txt_MenuTitle_C.SelectionStart = GF_LenB_Korea(txt_MenuTitle_C.Text)
            End If
        Else
            If IsNothing(objNode.Parent.Parent) Then
                If GF_LenB_Korea(txt_MenuTitle_C.Text) > 36 Then
                    txt_MenuTitle_C.Text = GF_MidB_Korea(txt_MenuTitle_C.Text, 1, 36)
                    txt_MenuTitle_C.SelectionStart = GF_LenB_Korea(txt_MenuTitle_C.Text)
                End If
            Else
                If GF_LenB_Korea(txt_MenuTitle_C.Text) > 40 Then
                    txt_MenuTitle_C.Text = GF_MidB_Korea(txt_MenuTitle_C.Text, 1, 40)
                    txt_MenuTitle_C.SelectionStart = GF_LenB_Korea(txt_MenuTitle_C.Text)
                End If
            End If
        End If
        'objNode.Text = txt_MenuTitle_J.Text

        '------------------------------
        ' ＤＢへの入力値反映(更新)
        '------------------------------
        If IsNothing(objNode.Parent) Then
            udtUpdKey.MENUID = LF_GetMenuGrpCD(objNode)
            udtUpdVal.MENUNM = GF_RepQuo(Trim$(txt_MenuTitle_C.Text))
            udtUpdVal.UPDID = GC_UPDID
            udtUpdVal.UPDYMD = Now

            If Not LF_UpdTPM060C_2(udtUpdVal, udtUpdKey) Then
                GoTo SYSTEM_ERROR
            End If
        Else
            If IsNothing(objNode.Parent.Parent) Then
                udtUpdKey.MENUID = LF_GetMenuGrpCD(objNode.Parent)
                udtUpdKey.MENUGRPID = LF_GetMenuGrpCD(objNode)
                udtUpdVal.MENUGRPNM = GF_RepQuo(Trim$(txt_MenuTitle_C.Text))
                udtUpdVal.UPDID = GC_UPDID
                udtUpdVal.UPDYMD = Now

                If Not LF_UpdTPM060C_2(udtUpdVal, udtUpdKey) Then
                    GoTo SYSTEM_ERROR
                End If
            Else
                udtUpdKey20.GROUPCD = LF_GetMenuGrpCD(objNode)
                udtUpdKey20.GOODSCD = "0000"
                udtUpdVal20.GROUPNM = GF_RepQuo(Trim$(txt_MenuTitle_C.Text))
                udtUpdVal20.UPDID = GC_UPDID
                udtUpdVal20.UPDYMD = Now

                If Not LF_UpdTPM020C_1(udtUpdVal20, udtUpdKey20) Then
                    GoTo SYSTEM_ERROR
                End If
            End If
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_MenuTitle_C_TextChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニュー削除処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
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
        If Not IsNothing(pNode.Parent) Then
            strMenuID = LF_GetMenuGrpCD(pNode.Parent)
            strMenuNm = Trim$(pNode.Parent.Text)
        Else
            strMenuID = LF_GetMenuGrpCD(pNode)
            strMenuNm = Trim$(pNode.Text)
        End If

        If GF_Msg("", Replace(GF_GetMsg("Q05"), "@@@", strMenuNm), MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then

            '------------------------------
            ' 表示中メニュー削除前チェック
            '------------------------------
            If LF_GetTPM040(strMenuID) = False Then
                Call GF_Msg("", "タッチパネルに表示中のため削除できません。" & vbCrLf & "開店処理より表示中のメニューを変更後、再度実施してください。", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
                LF_UpdDeleteMenu = CNL1920.FuncResult.CancelEnd
                Exit Function
            End If

            If GF_Msg("A01", "", MsgBoxStyle.YesNo, MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                '------------------------------
                ' トランザクション開始
                '------------------------------
                If Not GF_BeginTrans() Then
                    Exit Function
                End If

                strSQL = ""
                strSQL = strSQL & "DELETE FROM TPM020"
                strSQL = strSQL & " WHERE EXISTS (SELECT *"
                strSQL = strSQL & "                 FROM TPM060"
                strSQL = strSQL & "                WHERE TPM060.MENUID   = '" & strMenuID & "'"
                strSQL = strSQL & "                  AND TPM060.GROUPCD <> 'J000'"
                strSQL = strSQL & "                  AND TPM060.GROUPCD  = TPM020.GROUPCD)"

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                strSQL = ""
                strSQL = strSQL & "DELETE FROM TPM061"
                strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                strSQL = ""
                strSQL = strSQL & "DELETE FROM TPM060"
                strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                '多言語機能対応
                If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then

                    strSQL = ""
                    strSQL = strSQL & "DELETE FROM TPM020A"
                    strSQL = strSQL & " WHERE EXISTS (SELECT *"
                    strSQL = strSQL & "                 FROM TPM060A"
                    strSQL = strSQL & "                WHERE TPM060A.MENUID   = '" & strMenuID & "'"
                    strSQL = strSQL & "                  AND TPM060A.GROUPCD <> 'J000'"
                    strSQL = strSQL & "                  AND TPM060A.GROUPCD  = TPM020A.GROUPCD)"

                    If Not GF_UpdData(strSQL) Then
                        If Not GF_RollbackTrans() Then
                            Exit Function
                        End If
                        Exit Function
                    End If

                    strSQL = ""
                    strSQL = strSQL & "DELETE FROM TPM020B"
                    strSQL = strSQL & " WHERE EXISTS (SELECT *"
                    strSQL = strSQL & "                 FROM TPM060B"
                    strSQL = strSQL & "                WHERE TPM060B.MENUID   = '" & strMenuID & "'"
                    strSQL = strSQL & "                  AND TPM060B.GROUPCD <> 'J000'"
                    strSQL = strSQL & "                  AND TPM060B.GROUPCD  = TPM020B.GROUPCD)"

                    If Not GF_UpdData(strSQL) Then
                        If Not GF_RollbackTrans() Then
                            Exit Function
                        End If
                        Exit Function
                    End If

                    strSQL = ""
                    strSQL = strSQL & "DELETE FROM TPM020C"
                    strSQL = strSQL & " WHERE EXISTS (SELECT *"
                    strSQL = strSQL & "                 FROM TPM060C"
                    strSQL = strSQL & "                WHERE TPM060C.MENUID   = '" & strMenuID & "'"
                    strSQL = strSQL & "                  AND TPM060C.GROUPCD <> 'J000'"
                    strSQL = strSQL & "                  AND TPM060C.GROUPCD  = TPM020C.GROUPCD)"

                    If Not GF_UpdData(strSQL) Then
                        If Not GF_RollbackTrans() Then
                            Exit Function
                        End If
                        Exit Function
                    End If

                    strSQL = ""
                    strSQL = strSQL & "DELETE FROM TPM061A"
                    strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"

                    If Not GF_UpdData(strSQL) Then
                        If Not GF_RollbackTrans() Then
                            Exit Function
                        End If
                        Exit Function
                    End If

                    strSQL = ""
                    strSQL = strSQL & "DELETE FROM TPM061B"
                    strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"

                    If Not GF_UpdData(strSQL) Then
                        If Not GF_RollbackTrans() Then
                            Exit Function
                        End If
                        Exit Function
                    End If

                    strSQL = ""
                    strSQL = strSQL & "DELETE FROM TPM061C"
                    strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"

                    If Not GF_UpdData(strSQL) Then
                        If Not GF_RollbackTrans() Then
                            Exit Function
                        End If
                        Exit Function
                    End If

                    strSQL = ""
                    strSQL = strSQL & "DELETE FROM TPM060A"
                    strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"

                    If Not GF_UpdData(strSQL) Then
                        If Not GF_RollbackTrans() Then
                            Exit Function
                        End If
                        Exit Function
                    End If

                    strSQL = ""
                    strSQL = strSQL & "DELETE FROM TPM060B"
                    strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"

                    If Not GF_UpdData(strSQL) Then
                        If Not GF_RollbackTrans() Then
                            Exit Function
                        End If
                        Exit Function
                    End If
                    strSQL = ""
                    strSQL = strSQL & "DELETE FROM TPM060C"
                    strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"

                    If Not GF_UpdData(strSQL) Then
                        If Not GF_RollbackTrans() Then
                            Exit Function
                        End If
                        Exit Function
                    End If
                End If

                '------------------------------
                ' トランザクション確定
                '------------------------------
                If Not GF_CommitTrans() Then
                    Exit Function
                End If

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
        ' 返却値設定
        '------------------------------
        LF_UpdDeleteMenu = CNL1920.FuncResult.NormalEnd

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：(ＤＢ更新契機)メニューツリー チェック状態変化時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub trv_Menu_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trv_Menu.AfterCheck

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim udtUpdVal As typTPM060 = Nothing
        Dim udtUpdKey As typTPM060 = Nothing
        Dim udtUpdVal20 As typTPM020 = Nothing
        Dim udtUpdKey20 As typTPM020 = Nothing

        '------------------------------
        ' イベント発生回避フラグ確認
        '------------------------------
        If L_ProcFlg Then
            Exit Sub
        End If

        '------------------------------
        ' メニューのチェックは変更不可
        '------------------------------
        If IsNothing(e.Node.Parent) Then
            Exit Sub
        End If

        '------------------------------
        ' メニューグループ、グループ使用可否更新処理
        '------------------------------
        Try
            If IsNothing(e.Node.Parent.Parent) Then
                '------------------------------
                ' メニューグループ更新処理
                '------------------------------
                With udtUpdVal                                                  ' 更新値設定
                    .ENABLED = IIf(e.Node.Checked, GC_TRUE, GC_FALSE)
                    .UPDID = GC_UPDID
                    .UPDYMD = Now
                End With

                With udtUpdKey                                                  ' 更新対象キー値設定
                    .MENUID = LF_GetMenuGrpCD(e.Node.Parent)
                    .MENUGRPID = LF_GetMenuGrpCD(e.Node)
                End With

                If Not LF_UpdTPM060_1(udtUpdVal, udtUpdKey) Then
                    GoTo SYSTEM_ERROR
                End If
            Else
                '------------------------------
                ' グループ更新処理
                '------------------------------
                With udtUpdVal20                                                ' 更新値設定
                    .ENABLED = IIf(e.Node.Checked, GC_TRUE, GC_FALSE)
                    .UPDID = GC_UPDID
                    .UPDYMD = Now
                End With

                With udtUpdKey20                                                ' 更新対象キー値設定
                    .GROUPCD = LF_GetMenuGrpCD(e.Node)
                End With

                If Not LF_UpdTPM020_4(udtUpdVal20, udtUpdKey20) Then
                    GoTo SYSTEM_ERROR
                End If
            End If

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("trv_Menu_AfterCheck")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューツリー チェック状態変化直前処理
    ' 　機能概要：親(Root)ノードのチェック状態変更を禁止する
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub trv_Menu_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles trv_Menu.BeforeCheck

        '------------------------------
        ' イベント発生回避フラグ確認
        '------------------------------
        If L_ProcFlg Then
            Exit Sub
        End If

        If IsNothing(e.Node.Parent) Then
            e.Cancel = True
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：システム管理マスタ 取得処理
    ' 　機能概要：選択中メニューの削除不可チェック
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM040(ByVal pMenuId As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM040 = False

        '------------------------------
        ' ＳＱＬ文生成
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT DEFMENUID"
        strSQL = strSQL & "  FROM TPM040"
        strSQL = strSQL & " WHERE DEFMENUID = '" & pMenuId & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count <> 0 Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPM040 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：TPM020(ジャンルマスタ)更新処理
    ' 　機能概要：ジャンルの名称項目について、更新を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM020_1(ByVal pUpdVal As typTPM020, ByVal pUpdKey As typTPM020) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020_1 = False

        '------------------------------
        ' 更新ＳＱＬ文生成
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM020"
        strSQL = strSQL & "   SET GROUPNM = '" & pUpdVal.GROUPNM & "',"
        strSQL = strSQL & "       UPDID   = '" & pUpdVal.UPDID & "',"
        strSQL = strSQL & "       UPDYMD  = '" & pUpdVal.UPDYMD & "'"
        strSQL = strSQL & " WHERE GROUPCD = '" & pUpdKey.GROUPCD & "'"
        strSQL = strSQL & "   AND GOODSCD = '" & pUpdKey.GOODSCD & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If
        L_EditFlg = True

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：TPM020(ジャンルマスタ)更新処理
    ' 　機能概要：ジャンルの名称項目について、更新を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM020A_1(ByVal pUpdVal As typTPM020A, ByVal pUpdKey As typTPM020A) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020A_1 = False

        '------------------------------
        ' 更新ＳＱＬ文生成
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM020A"
        strSQL = strSQL & "   SET GROUPNM = N'" & pUpdVal.GROUPNM & "',"
        strSQL = strSQL & "       UPDID   = N'" & pUpdVal.UPDID & "',"
        strSQL = strSQL & "       UPDYMD  = N'" & pUpdVal.UPDYMD & "'"
        strSQL = strSQL & " WHERE GROUPCD = '" & pUpdKey.GROUPCD & "'"
        strSQL = strSQL & "   AND GOODSCD = '" & pUpdKey.GOODSCD & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If
        L_EditFlg = True

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020A_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：TPM020(ジャンルマスタ)更新処理
    ' 　機能概要：ジャンルの名称項目について、更新を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM020B_1(ByVal pUpdVal As typTPM020B, ByVal pUpdKey As typTPM020B) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020B_1 = False

        '------------------------------
        ' 更新ＳＱＬ文生成
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM020B"
        strSQL = strSQL & "   SET GROUPNM = N'" & pUpdVal.GROUPNM & "',"
        strSQL = strSQL & "       UPDID   = N'" & pUpdVal.UPDID & "',"
        strSQL = strSQL & "       UPDYMD  = N'" & pUpdVal.UPDYMD & "'"
        strSQL = strSQL & " WHERE GROUPCD = '" & pUpdKey.GROUPCD & "'"
        strSQL = strSQL & "   AND GOODSCD = '" & pUpdKey.GOODSCD & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If
        L_EditFlg = True

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020B_1 = True

    End Function

    Private Function LF_UpdTPM020C_1(ByVal pUpdVal As typTPM020C, ByVal pUpdKey As typTPM020C) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020C_1 = False

        '------------------------------
        ' 更新ＳＱＬ文生成
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM020C"
        strSQL = strSQL & "   SET GROUPNM = N'" & pUpdVal.GROUPNM & "',"
        strSQL = strSQL & "       UPDID   = N'" & pUpdVal.UPDID & "',"
        strSQL = strSQL & "       UPDYMD  = N'" & pUpdVal.UPDYMD & "'"
        strSQL = strSQL & " WHERE GROUPCD = '" & pUpdKey.GROUPCD & "'"
        strSQL = strSQL & "   AND GOODSCD = '" & pUpdKey.GOODSCD & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If
        L_EditFlg = True

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020C_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：TPM020(グループマスタ)更新処理
    ' 　機能概要：グループの使用可否(ENABLED項目)について、更新を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM020_4(ByVal pUpdVal As typTPM020, ByVal pUpdKey As typTPM020) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        'Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020_4 = False

        ' 2014-04-26 多言語不備修正
        Dim LangCount As Integer
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            'LangCount = CInt(GF_GetAppInfo3("MULTI_LING_CNT"))
            ' TPM060に合わせA,B,Cともに更新
            LangCount = 3
        Else
            LangCount = 0
        End If
        Dim aryStr(LangCount) As String
        '------------------------------
        ' 更新ＳＱＬ文生成
        '------------------------------
        Dim ii As Integer
        For ii = 0 To LangCount
            Select Case ii
                Case 1
                    aryStr(ii) = "UPDATE TPM020A"
                Case 2
                    aryStr(ii) = "UPDATE TPM020B"
                Case 3
                    aryStr(ii) = "UPDATE TPM020C"
                Case Else
                    aryStr(ii) = "UPDATE TPM020"
            End Select
            'aryStr(ii) = aryStr(ii) & "UPDATE TPM020"
            aryStr(ii) = aryStr(ii) & "   SET ENABLED = '" & pUpdVal.ENABLED & "',"
            aryStr(ii) = aryStr(ii) & "       UPDID   = '" & pUpdVal.UPDID & "',"
            aryStr(ii) = aryStr(ii) & "       UPDYMD  = '" & pUpdVal.UPDYMD & "'"
            aryStr(ii) = aryStr(ii) & " WHERE GROUPCD = '" & pUpdKey.GROUPCD & "'"
        Next

        If Not GF_UpdCmtSomeData(aryStr) Then
            Exit Function
        End If
        L_EditFlg = True

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020_4 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：TPM060(メニューグループマスタ)更新処理 - (１)
    ' 　機能概要：メニューグループの使用可否(ENABLED項目)について、更新を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM060_1(ByVal pUpdVal As typTPM060, ByVal pUpdKey As typTPM060) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strSQL2 As String
        Dim strSQL3 As String
        Dim strSQL4 As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM060_1 = False

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        '------------------------------
        ' 更新ＳＱＬ文生成
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM060"
        strSQL = strSQL & "   SET ENABLED   = '" & pUpdVal.ENABLED & "',"
        strSQL = strSQL & "       UPDID     = '" & pUpdVal.UPDID & "',"
        strSQL = strSQL & "       UPDYMD    = '" & pUpdVal.UPDYMD & "'"
        strSQL = strSQL & " WHERE MENUID    = '" & pUpdKey.MENUID & "'"
        strSQL = strSQL & "   AND MENUGRPID = '" & pUpdKey.MENUGRPID & "'"

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        '多言語機能対応
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            'TPM060Aも同時にアップデートを行う
            strSQL2 = ""
            strSQL2 = strSQL2 & "UPDATE TPM060A"
            strSQL2 = strSQL2 & "   SET ENABLED   = N'" & pUpdVal.ENABLED & "',"
            strSQL2 = strSQL2 & "       UPDID     = N'" & pUpdVal.UPDID & "',"
            strSQL2 = strSQL2 & "       UPDYMD    = N'" & pUpdVal.UPDYMD & "'"
            strSQL2 = strSQL2 & " WHERE MENUID    = '" & pUpdKey.MENUID & "'"
            strSQL2 = strSQL2 & "   AND MENUGRPID = '" & pUpdKey.MENUGRPID & "'"

            If Not GF_UpdData(strSQL2) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            'TPM060Bも同時にアップデートを行う
            strSQL3 = ""
            strSQL3 = strSQL3 & "UPDATE TPM060B"
            strSQL3 = strSQL3 & "   SET ENABLED   = N'" & pUpdVal.ENABLED & "',"
            strSQL3 = strSQL3 & "       UPDID     = N'" & pUpdVal.UPDID & "',"
            strSQL3 = strSQL3 & "       UPDYMD    = N'" & pUpdVal.UPDYMD & "'"
            strSQL3 = strSQL3 & " WHERE MENUID    = '" & pUpdKey.MENUID & "'"
            strSQL3 = strSQL3 & "   AND MENUGRPID = '" & pUpdKey.MENUGRPID & "'"

            If Not GF_UpdData(strSQL3) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            'TPM060Cも同時にアップデートを行う
            strSQL4 = ""
            strSQL4 = strSQL4 & "UPDATE TPM060C"
            strSQL4 = strSQL4 & "   SET ENABLED   = N'" & pUpdVal.ENABLED & "',"
            strSQL4 = strSQL4 & "       UPDID     = N'" & pUpdVal.UPDID & "',"
            strSQL4 = strSQL4 & "       UPDYMD    = N'" & pUpdVal.UPDYMD & "'"
            strSQL4 = strSQL4 & " WHERE MENUID    = '" & pUpdKey.MENUID & "'"
            strSQL4 = strSQL4 & "   AND MENUGRPID = '" & pUpdKey.MENUGRPID & "'"

            If Not GF_UpdData(strSQL4) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If
        End If

        '------------------------------
        ' トランザクション確定
        '------------------------------
        If Not GF_CommitTrans() Then
            Exit Function
        End If

        L_EditFlg = True

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM060_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：TPM060(メニューグループマスタ)更新処理 - (２)
    ' 　機能概要：メニュー及びメニューグループの名称項目について、更新を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM060_2(ByVal pUpdVal As typTPM060, ByVal pUpdKey As typTPM060, ByVal pUpdFlg As Integer) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strWhere As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM060_2 = False
        strSQL = ""
        strWhere = ""

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        '------------------------------
        ' 更新ＳＱＬ文生成
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
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        '多言語機能対応
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            If pUpdFlg.Equals(1) Then
                '------------------------------
                ' 更新ＳＱＬ文生成(TPM060A)
                '------------------------------
                strSQL = ""
                strWhere = ""
                strSQL = strSQL & "UPDATE TPM060A"

                If Len(Trim$(pUpdKey.MENUGRPID)) = 0 Then
                    strSQL = strSQL & "   SET TPM060A.MENUNM    = '" & pUpdVal.MENUNM & "',"
                    strWhere = strWhere & " WHERE TPM060A.MENUID = '" & pUpdKey.MENUID & "'"
                Else
                    strSQL = strSQL & "   SET TPM060A.MENUGRPNM = '" & pUpdVal.MENUGRPNM & "',"
                    strWhere = strWhere & " WHERE TPM060A.MENUID = '" & pUpdKey.MENUID & "'"
                    strWhere = strWhere & "   AND TPM060A.MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
                End If

                strSQL = strSQL & "       TPM060A.UPDID = '" & pUpdVal.UPDID & "',"
                strSQL = strSQL & "       TPM060A.UPDYMD = '" & pUpdVal.UPDYMD & "'"
                strSQL = strSQL & strWhere

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                '------------------------------
                ' 更新ＳＱＬ文生成(TPM060B)
                '------------------------------
                strSQL = ""
                strWhere = ""
                strSQL = strSQL & "UPDATE TPM060B"

                If Len(Trim$(pUpdKey.MENUGRPID)) = 0 Then
                    strSQL = strSQL & "   SET TPM060B.MENUNM    = '" & pUpdVal.MENUNM & "',"
                    strWhere = strWhere & " WHERE TPM060B.MENUID = '" & pUpdKey.MENUID & "'"
                Else
                    strSQL = strSQL & "   SET TPM060B.MENUGRPNM = '" & pUpdVal.MENUGRPNM & "',"
                    strWhere = strWhere & " WHERE TPM060B.MENUID = '" & pUpdKey.MENUID & "'"
                    strWhere = strWhere & "   AND TPM060B.MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
                End If

                strSQL = strSQL & "       TPM060B.UPDID = '" & pUpdVal.UPDID & "',"
                strSQL = strSQL & "       TPM060B.UPDYMD = '" & pUpdVal.UPDYMD & "'"
                strSQL = strSQL & strWhere

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                '------------------------------
                ' 更新ＳＱＬ文生成(TPM060C)
                '------------------------------
                strSQL = ""
                strWhere = ""
                strSQL = strSQL & "UPDATE TPM060C"

                If Len(Trim$(pUpdKey.MENUGRPID)) = 0 Then
                    strSQL = strSQL & "   SET TPM060C.MENUNM    = '" & pUpdVal.MENUNM & "',"
                    strWhere = strWhere & " WHERE TPM060C.MENUID = '" & pUpdKey.MENUID & "'"
                Else
                    strSQL = strSQL & "   SET TPM060C.MENUGRPNM = '" & pUpdVal.MENUGRPNM & "',"
                    strWhere = strWhere & " WHERE TPM060C.MENUID = '" & pUpdKey.MENUID & "'"
                    strWhere = strWhere & "   AND TPM060C.MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
                End If

                strSQL = strSQL & "       TPM060C.UPDID = '" & pUpdVal.UPDID & "',"
                strSQL = strSQL & "       TPM060C.UPDYMD = '" & pUpdVal.UPDYMD & "'"
                strSQL = strSQL & strWhere

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

            End If
        End If

        '------------------------------
        ' トランザクション確定
        '------------------------------
        If Not GF_CommitTrans() Then
            Exit Function
        End If

        L_EditFlg = True

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM060_2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：TPM060(メニューグループマスタ)更新処理 - (２)
    ' 　機能概要：メニュー及びメニューグループの名称項目について、更新を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM060A_2(ByVal pUpdVal As typTPM060A, ByVal pUpdKey As typTPM060A) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strWhere As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM060A_2 = False
        strSQL = ""
        strWhere = ""

        '------------------------------
        ' 更新ＳＱＬ文生成
        '------------------------------
        strSQL = strSQL & "UPDATE TPM060A"

        If Len(Trim$(pUpdKey.MENUGRPID)) = 0 Then
            strSQL = strSQL & "   SET TPM060A.MENUNM    = N'" & pUpdVal.MENUNM & "',"
            strWhere = strWhere & " WHERE TPM060A.MENUID = '" & pUpdKey.MENUID & "'"
        Else
            strSQL = strSQL & "   SET TPM060A.MENUGRPNM = N'" & pUpdVal.MENUGRPNM & "',"
            strWhere = strWhere & " WHERE TPM060A.MENUID = '" & pUpdKey.MENUID & "'"
            strWhere = strWhere & "   AND TPM060A.MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
        End If

        strSQL = strSQL & "       TPM060A.UPDID = '" & pUpdVal.UPDID & "',"
        strSQL = strSQL & "       TPM060A.UPDYMD = '" & pUpdVal.UPDYMD & "'"
        strSQL = strSQL & strWhere

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If
        L_EditFlg = True

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM060A_2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：TPM060(メニューグループマスタ)更新処理 - (２)
    ' 　機能概要：メニュー及びメニューグループの名称項目について、更新を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM060B_2(ByVal pUpdVal As typTPM060B, ByVal pUpdKey As typTPM060B) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strWhere As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM060B_2 = False
        strSQL = ""
        strWhere = ""

        '------------------------------
        ' 更新ＳＱＬ文生成
        '------------------------------
        strSQL = strSQL & "UPDATE TPM060B"

        If Len(Trim$(pUpdKey.MENUGRPID)) = 0 Then
            strSQL = strSQL & "   SET TPM060B.MENUNM    = N'" & pUpdVal.MENUNM & "',"
            strWhere = strWhere & " WHERE TPM060B.MENUID = '" & pUpdKey.MENUID & "'"
        Else
            strSQL = strSQL & "   SET TPM060B.MENUGRPNM = N'" & pUpdVal.MENUGRPNM & "',"
            strWhere = strWhere & " WHERE TPM060B.MENUID = '" & pUpdKey.MENUID & "'"
            strWhere = strWhere & "   AND TPM060B.MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
        End If

        strSQL = strSQL & "       TPM060B.UPDID = '" & pUpdVal.UPDID & "',"
        strSQL = strSQL & "       TPM060B.UPDYMD = '" & pUpdVal.UPDYMD & "'"
        strSQL = strSQL & strWhere

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If
        L_EditFlg = True

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM060B_2 = True

    End Function

    Private Function LF_UpdTPM060C_2(ByVal pUpdVal As typTPM060C, ByVal pUpdKey As typTPM060C) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strWhere As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM060C_2 = False
        strSQL = ""
        strWhere = ""

        '------------------------------
        ' 更新ＳＱＬ文生成
        '------------------------------
        strSQL = strSQL & "UPDATE TPM060C"

        If Len(Trim$(pUpdKey.MENUGRPID)) = 0 Then
            strSQL = strSQL & "   SET TPM060C.MENUNM    = N'" & pUpdVal.MENUNM & "',"
            strWhere = strWhere & " WHERE TPM060C.MENUID = '" & pUpdKey.MENUID & "'"
        Else
            strSQL = strSQL & "   SET TPM060C.MENUGRPNM = N'" & pUpdVal.MENUGRPNM & "',"
            strWhere = strWhere & " WHERE TPM060C.MENUID = '" & pUpdKey.MENUID & "'"
            strWhere = strWhere & "   AND TPM060C.MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
        End If

        strSQL = strSQL & "       TPM060C.UPDID = '" & pUpdVal.UPDID & "',"
        strSQL = strSQL & "       TPM060C.UPDYMD = '" & pUpdVal.UPDYMD & "'"
        strSQL = strSQL & strWhere

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If
        L_EditFlg = True

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM060C_2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：TPM060(メニューグループマスタ)更新処理 - (３)
    ' 　機能概要：メニューグループに属する、商品グループの登録／削除を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM060_3(ByVal pUpdVal As typTPM060, ByVal pUpdKey As typTPM060, ByVal pblnUpdFlg As Boolean) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strSQL2 As String
        Dim strSQL3 As String
        Dim strSQL4 As String
        Dim objData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM060_3 = False
        strSQL = ""
        strSQL2 = ""
        strSQL3 = ""
        strSQL4 = ""

        '------------------------------
        ' 更新ＳＱＬ文生成
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

            '多言語機能対応
            If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                strSQL2 = strSQL2 & "INSERT INTO TPM060A VALUES("
                strSQL2 = strSQL2 & "N'" & pUpdVal.MENUID & "',"
                strSQL2 = strSQL2 & "N'" & pUpdVal.MENUNM & "',"
                strSQL2 = strSQL2 & "N'" & pUpdVal.MENUGRPID & "',"
                strSQL2 = strSQL2 & "N'" & GF_RepQuo(txt_MenuTitle_A.Text) & "',"
                strSQL2 = strSQL2 & "N'" & pUpdVal.MENUSTYLE & "',"
                strSQL2 = strSQL2 & "N'" & pUpdVal.GROUPCD & "',"
                strSQL2 = strSQL2 & "N'" & pUpdVal.DISPORDER & "',"
                strSQL2 = strSQL2 & "N'" & pUpdVal.PRICEDISP & "',"
                strSQL2 = strSQL2 & "N'" & pUpdVal.GROUPKBN & "',"
                strSQL2 = strSQL2 & "N'" & pUpdVal.ENABLED & "',"
                strSQL2 = strSQL2 & "N'" & pUpdVal.UPDID & "',"
                strSQL2 = strSQL2 & "N'" & pUpdVal.UPDYMD & "')"

                strSQL3 = strSQL3 & "INSERT INTO TPM060B VALUES("
                strSQL3 = strSQL3 & "N'" & pUpdVal.MENUID & "',"
                strSQL3 = strSQL3 & "N'" & pUpdVal.MENUNM & "',"
                strSQL3 = strSQL3 & "N'" & pUpdVal.MENUGRPID & "',"
                strSQL3 = strSQL3 & "N'" & GF_RepQuo(txt_MenuTitle_B.Text) & "',"
                strSQL3 = strSQL3 & "N'" & pUpdVal.MENUSTYLE & "',"
                strSQL3 = strSQL3 & "N'" & pUpdVal.GROUPCD & "',"
                strSQL3 = strSQL3 & "N'" & pUpdVal.DISPORDER & "',"
                strSQL3 = strSQL3 & "N'" & pUpdVal.PRICEDISP & "',"
                strSQL3 = strSQL3 & "N'" & pUpdVal.GROUPKBN & "',"
                strSQL3 = strSQL3 & "N'" & pUpdVal.ENABLED & "',"
                strSQL3 = strSQL3 & "N'" & pUpdVal.UPDID & "',"
                strSQL3 = strSQL3 & "N'" & pUpdVal.UPDYMD & "')"

                strSQL4 = strSQL4 & "INSERT INTO TPM060C VALUES("
                strSQL4 = strSQL4 & "N'" & pUpdVal.MENUID & "',"
                strSQL4 = strSQL4 & "N'" & pUpdVal.MENUNM & "',"
                strSQL4 = strSQL4 & "N'" & pUpdVal.MENUGRPID & "',"
                strSQL4 = strSQL4 & "N'" & GF_RepQuo(txt_MenuTitle_C.Text) & "',"
                strSQL4 = strSQL4 & "N'" & pUpdVal.MENUSTYLE & "',"
                strSQL4 = strSQL4 & "N'" & pUpdVal.GROUPCD & "',"
                strSQL4 = strSQL4 & "N'" & pUpdVal.DISPORDER & "',"
                strSQL4 = strSQL4 & "N'" & pUpdVal.PRICEDISP & "',"
                strSQL4 = strSQL4 & "N'" & pUpdVal.GROUPKBN & "',"
                strSQL4 = strSQL4 & "N'" & pUpdVal.ENABLED & "',"
                strSQL4 = strSQL4 & "N'" & pUpdVal.UPDID & "',"
                strSQL4 = strSQL4 & "N'" & pUpdVal.UPDYMD & "')"
            End If

        Else
            strSQL = strSQL & "DELETE FROM TPM060"
            strSQL = strSQL & "      WHERE MENUID    = '" & pUpdKey.MENUID & "'"
            strSQL = strSQL & "        AND MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
            strSQL = strSQL & "        AND GROUPCD   = '" & pUpdKey.GROUPCD & "'"

            '多言語機能対応
            If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                strSQL2 = strSQL2 & "DELETE FROM TPM060A"
                strSQL2 = strSQL2 & "      WHERE MENUID    = '" & pUpdKey.MENUID & "'"
                strSQL2 = strSQL2 & "        AND MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
                strSQL2 = strSQL2 & "        AND GROUPCD   = '" & pUpdKey.GROUPCD & "'"

                strSQL3 = strSQL3 & "DELETE FROM TPM060B"
                strSQL3 = strSQL3 & "      WHERE MENUID    = '" & pUpdKey.MENUID & "'"
                strSQL3 = strSQL3 & "        AND MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
                strSQL3 = strSQL3 & "        AND GROUPCD   = '" & pUpdKey.GROUPCD & "'"

                strSQL4 = strSQL4 & "DELETE FROM TPM060C"
                strSQL4 = strSQL4 & "      WHERE MENUID    = '" & pUpdKey.MENUID & "'"
                strSQL4 = strSQL4 & "        AND MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
                strSQL4 = strSQL4 & "        AND GROUPCD   = '" & pUpdKey.GROUPCD & "'"
            End If
        End If

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        If Not GF_UpdCmtData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        '多言語機能対応
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            If Not GF_UpdData(strSQL2) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            If Not GF_UpdData(strSQL3) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            If Not GF_UpdData(strSQL4) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If
        End If

        '------------------------------
        ' トランザクション確定
        '------------------------------
        If Not GF_CommitTrans() Then
            Exit Function
        End If

        L_EditFlg = True

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM060_3 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：TPM060(メニューグループマスタ)更新処理 - (１)
    ' 　機能概要：メニューグループの使用可否(ENABLED項目)について、更新を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM060_4(ByVal pUpdVal As typTPM060, ByVal pUpdKey As typTPM060) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strSQL2 As String
        Dim strSQL3 As String
        Dim strSQL4 As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM060_4 = False

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        '------------------------------
        ' 更新ＳＱＬ文生成
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM060"
        strSQL = strSQL & "   SET MENUSTYLE = '" & pUpdVal.MENUSTYLE & "',"
        strSQL = strSQL & "       GROUPKBN  = '" & pUpdVal.GROUPKBN & "',"
        strSQL = strSQL & "       UPDID     = '" & pUpdVal.UPDID & "',"
        strSQL = strSQL & "       UPDYMD    = '" & pUpdVal.UPDYMD & "'"
        strSQL = strSQL & " WHERE MENUID    = '" & pUpdKey.MENUID & "'"
        strSQL = strSQL & "   AND MENUGRPID = '" & pUpdKey.MENUGRPID & "'"

        If pUpdKey.GROUPCD = "" Then
            ' グループ一覧画面の画面表示タイプ変更時
            strSQL = strSQL & "   AND GROUPCD = '" & GC_DUMMY_GROUPCD & "'"
        Else
            ' 商品一覧画面の画面表示タイプ変更時
            strSQL = strSQL & "   AND GROUPCD = '" & pUpdKey.GROUPCD & "'"
        End If

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        '多言語機能対応
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            'TPM060Aも同時にアップデートを行う
            strSQL2 = ""
            strSQL2 = strSQL2 & "UPDATE TPM060A"
            strSQL2 = strSQL2 & "   SET MENUSTYLE = N'" & pUpdVal.MENUSTYLE & "',"
            strSQL2 = strSQL2 & "       GROUPKBN  = N'" & pUpdVal.GROUPKBN & "',"
            strSQL2 = strSQL2 & "       UPDID     = N'" & pUpdVal.UPDID & "',"
            strSQL2 = strSQL2 & "       UPDYMD    = N'" & pUpdVal.UPDYMD & "'"
            strSQL2 = strSQL2 & " WHERE MENUID    = '" & pUpdKey.MENUID & "'"
            strSQL2 = strSQL2 & "   AND MENUGRPID = '" & pUpdKey.MENUGRPID & "'"

            If pUpdKey.GROUPCD = "" Then
                ' グループ一覧画面の画面表示タイプ変更時
                strSQL2 = strSQL2 & "   AND GROUPCD = '" & GC_DUMMY_GROUPCD & "'"
            Else
                ' 商品一覧画面の画面表示タイプ変更時
                strSQL2 = strSQL2 & "   AND GROUPCD = '" & pUpdKey.GROUPCD & "'"
            End If

            If Not GF_UpdData(strSQL2) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            'TPM060Bも同時にアップデートを行う
            strSQL3 = ""
            strSQL3 = strSQL3 & "UPDATE TPM060B"
            strSQL3 = strSQL3 & "   SET MENUSTYLE = N'" & pUpdVal.MENUSTYLE & "',"
            strSQL3 = strSQL3 & "       GROUPKBN  = N'" & pUpdVal.GROUPKBN & "',"
            strSQL3 = strSQL3 & "       UPDID     = N'" & pUpdVal.UPDID & "',"
            strSQL3 = strSQL3 & "       UPDYMD    = N'" & pUpdVal.UPDYMD & "'"
            strSQL3 = strSQL3 & " WHERE MENUID    = '" & pUpdKey.MENUID & "'"
            strSQL3 = strSQL3 & "   AND MENUGRPID = '" & pUpdKey.MENUGRPID & "'"

            If pUpdKey.GROUPCD = "" Then
                ' グループ一覧画面の画面表示タイプ変更時
                strSQL3 = strSQL3 & "   AND GROUPCD = '" & GC_DUMMY_GROUPCD & "'"
            Else
                ' 商品一覧画面の画面表示タイプ変更時
                strSQL3 = strSQL3 & "   AND GROUPCD = '" & pUpdKey.GROUPCD & "'"
            End If

            If Not GF_UpdData(strSQL3) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            'TPM060Cも同時にアップデートを行う
            strSQL4 = ""
            strSQL4 = strSQL4 & "UPDATE TPM060C"
            strSQL4 = strSQL4 & "   SET MENUSTYLE = N'" & pUpdVal.MENUSTYLE & "',"
            strSQL4 = strSQL4 & "       GROUPKBN  = N'" & pUpdVal.GROUPKBN & "',"
            strSQL4 = strSQL4 & "       UPDID     = N'" & pUpdVal.UPDID & "',"
            strSQL4 = strSQL4 & "       UPDYMD    = N'" & pUpdVal.UPDYMD & "'"
            strSQL4 = strSQL4 & " WHERE MENUID    = '" & pUpdKey.MENUID & "'"
            strSQL4 = strSQL4 & "   AND MENUGRPID = '" & pUpdKey.MENUGRPID & "'"

            If pUpdKey.GROUPCD = "" Then
                ' グループ一覧画面の画面表示タイプ変更時
                strSQL4 = strSQL4 & "   AND GROUPCD = '" & GC_DUMMY_GROUPCD & "'"
            Else
                ' 商品一覧画面の画面表示タイプ変更時
                strSQL4 = strSQL4 & "   AND GROUPCD = '" & pUpdKey.GROUPCD & "'"
            End If

            If Not GF_UpdData(strSQL4) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If
        End If

        '------------------------------
        ' トランザクション確定
        '------------------------------
        If Not GF_CommitTrans() Then
            Exit Function
        End If

        L_EditFlg = True

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM060_4 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：TPM060(メニューグループマスタ)更新処理 - (２)
    ' 　機能概要：メニューグループの使用可否(ENABLED項目)について、更新を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM060_8(ByVal pUpdVal As typTPM060, ByVal pUpdKey As typTPM060) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strSQL2 As String
        Dim strSQL3 As String
        Dim strSQL4 As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM060_8 = False

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        '------------------------------
        ' 更新ＳＱＬ文生成
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM060"
        strSQL = strSQL & "   SET MENUSTYLE = '" & pUpdVal.MENUSTYLE & "',"
        strSQL = strSQL & "       GROUPKBN  = '" & pUpdVal.GROUPKBN & "',"
        strSQL = strSQL & "       UPDID     = '" & pUpdVal.UPDID & "',"
        strSQL = strSQL & "       UPDYMD    = '" & pUpdVal.UPDYMD & "'"
        strSQL = strSQL & " WHERE MENUID    = '" & pUpdKey.MENUID & "'"
        strSQL = strSQL & "   AND MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
        strSQL = strSQL & "   AND GROUPCD  <> '" & GC_DUMMY_GROUPCD & "'"

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        '多言語機能対応
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            'TPM060Aも同時にアップデートを行う
            strSQL2 = ""
            strSQL2 = strSQL2 & "UPDATE TPM060A"
            strSQL2 = strSQL2 & "   SET MENUSTYLE = N'" & pUpdVal.MENUSTYLE & "',"
            strSQL2 = strSQL2 & "       GROUPKBN  = N'" & pUpdVal.GROUPKBN & "',"
            strSQL2 = strSQL2 & "       UPDID     = N'" & pUpdVal.UPDID & "',"
            strSQL2 = strSQL2 & "       UPDYMD    = N'" & pUpdVal.UPDYMD & "'"
            strSQL2 = strSQL2 & " WHERE MENUID    = '" & pUpdKey.MENUID & "'"
            strSQL2 = strSQL2 & "   AND MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
            strSQL2 = strSQL2 & "   AND GROUPCD  <> '" & GC_DUMMY_GROUPCD & "'"

            If Not GF_UpdData(strSQL2) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            'TPM060Bも同時にアップデートを行う
            strSQL3 = ""
            strSQL3 = strSQL3 & "UPDATE TPM060B"
            strSQL3 = strSQL3 & "   SET MENUSTYLE = N'" & pUpdVal.MENUSTYLE & "',"
            strSQL3 = strSQL3 & "       GROUPKBN  = N'" & pUpdVal.GROUPKBN & "',"
            strSQL3 = strSQL3 & "       UPDID     = N'" & pUpdVal.UPDID & "',"
            strSQL3 = strSQL3 & "       UPDYMD    = N'" & pUpdVal.UPDYMD & "'"
            strSQL3 = strSQL3 & " WHERE MENUID    = '" & pUpdKey.MENUID & "'"
            strSQL3 = strSQL3 & "   AND MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
            strSQL3 = strSQL3 & "   AND GROUPCD  <> '" & GC_DUMMY_GROUPCD & "'"

            If Not GF_UpdData(strSQL3) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            'TPM060Cも同時にアップデートを行う
            strSQL4 = ""
            strSQL4 = strSQL4 & "UPDATE TPM060C"
            strSQL4 = strSQL4 & "   SET MENUSTYLE = N'" & pUpdVal.MENUSTYLE & "',"
            strSQL4 = strSQL4 & "       GROUPKBN  = N'" & pUpdVal.GROUPKBN & "',"
            strSQL4 = strSQL4 & "       UPDID     = N'" & pUpdVal.UPDID & "',"
            strSQL4 = strSQL4 & "       UPDYMD    = N'" & pUpdVal.UPDYMD & "'"
            strSQL4 = strSQL4 & " WHERE MENUID    = '" & pUpdKey.MENUID & "'"
            strSQL4 = strSQL4 & "   AND MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
            strSQL4 = strSQL4 & "   AND GROUPCD  <> '" & GC_DUMMY_GROUPCD & "'"

            If Not GF_UpdData(strSQL4) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If
        End If

        '------------------------------
        ' トランザクション確定
        '------------------------------
        If Not GF_CommitTrans() Then
            Exit Function
        End If

        L_EditFlg = True

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM060_8 = True

    End Function

    Private Function LF_UpdTPM010_1(ByVal pMenuID As String, ByVal pMenuGrpID As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM010_1 = False

        '------------------------------
        ' 更新ＳＱＬ文生成
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

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM010_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループ表示/非表示チェック変更時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub cbo_Pat_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_Pat.SelectionChangeCommitted

        If L_ProcFlg2 Then
            Exit Sub
        End If

        If IsNothing(trv_Menu.SelectedNode) Then
            Exit Sub
        End If

        If IsNothing(trv_Menu.SelectedNode.Parent) Then
            Exit Sub
        End If

        If GF_CboGetCode(cbo_Pat, cbo_Pat.SelectedIndex) = "0" Then
            ' 商品一覧直接表示(4～6分割)選択時は、「商品一覧画面」ドロップダウンは活性とする
            cbo_Style.Enabled = True
        Else
            ' 上記以外は、「商品一覧画面」ドロップダウンは非活性とする
            cbo_Style.Enabled = False
        End If

        Try
            Call LS_UpdChkStatus("1")
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("cbo_Pat_SelectedIndexChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループ表示/非表示チェック変更時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub cbo_Style_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_Style.SelectionChangeCommitted

        If L_ProcFlg2 Then
            Exit Sub
        End If

        If IsNothing(trv_Menu.SelectedNode) Then
            Exit Sub
        End If

        If IsNothing(trv_Menu.SelectedNode.Parent) Then
            Exit Sub
        End If

        If IsNothing(trv_Menu.SelectedNode.Parent.Parent) Then
            ' メニューグループで商品一覧ドロップダウンが選択された場合
            Try
                Call LS_UpdChkStatus("3")
            Catch
                GoTo SYSTEM_ERROR
            End Try

            Exit Sub
        End If

        Try
            Call LS_UpdChkStatus("2")
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("cbo_Style_SelectionChangeCommitted")
    End Sub

    Private Sub LS_UpdChkStatus(ByVal pVal As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim udtUpdVal As typTPM060 = Nothing
        Dim udtUpdVal2 As typTPM060 = Nothing
        Dim udtUpdKey As typTPM060 = Nothing

        Try
            If pVal = "1" Then ' メニューグループ選択時
                Call LF_GetChkStatus(udtUpdVal, "1")

                With udtUpdKey
                    .MENUID = LF_GetMenuGrpCD(trv_Menu.SelectedNode.Parent)
                    .MENUGRPID = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
                    .GROUPCD = ""
                End With

            ElseIf pVal = "2" Then ' グループ選択時
                Call LF_GetChkStatus(udtUpdVal, "2")

                With udtUpdKey
                    .MENUID = LF_GetMenuGrpCD(trv_Menu.SelectedNode.Parent.Parent)
                    .MENUGRPID = LF_GetMenuGrpCD(trv_Menu.SelectedNode.Parent)
                    .GROUPCD = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
                End With

            Else ' メニューグループ選択時(商品一覧直接表示時)
                With udtUpdKey
                    .MENUID = LF_GetMenuGrpCD(trv_Menu.SelectedNode.Parent)
                    .MENUGRPID = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
                    .GROUPCD = ""
                End With

                Call LF_GetChkStatus(udtUpdVal, "1")

                Call LF_GetChkStatus(udtUpdVal2, "3")

                If Not LF_UpdTPM060_8(udtUpdVal2, udtUpdKey) Then
                    GoTo SYSTEM_ERROR
                End If

            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        If Not LF_UpdTPM060_4(udtUpdVal, udtUpdKey) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' 画像生成フラグの更新
        '------------------------------
        If Not LF_UpdTPM010_1(udtUpdKey.MENUID, udtUpdKey.MENUGRPID) Then
            GoTo SYSTEM_ERROR
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_UpdChkStatus")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：チェック状態確認
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetChkStatus(ByRef pUpdVal As typTPM060, ByVal pVal As String) As Boolean

        Dim strPat As String
        Dim strStyle As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetChkStatus = False

        If pVal = "1" Then ' メニューグループ選択時
            strPat = GF_CboGetCode(cbo_Pat, cbo_Pat.SelectedIndex)
            strStyle = GF_CboGetCode(cbo_Style, cbo_Style.SelectedIndex)

            Try
                '------------------------------
                ' 選択状態確認
                '------------------------------
                With pUpdVal
                    Select Case strPat
                        Case LC_PAT_DIRC
                            Select Case strStyle
                                Case LC_STYLE_PIC4
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRC4

                                Case LC_STYLE_PIC6
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRC6

                                Case LC_STYLE_PIC9
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRC9

                                Case LC_STYLE_PIC16
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRC16

                                Case LC_STYLE_DAILY
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCDAILY

                                Case LC_STYLE_FREE1
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE1

                                Case LC_STYLE_FREE2
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE2

                                Case LC_STYLE_FREE3
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE3

                                Case LC_STYLE_FREE4
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE4

                                Case LC_STYLE_FREE5
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE5

                                Case LC_STYLE_FREE6
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE6

                                Case LC_STYLE_FREE7
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE7

                                Case LC_STYLE_FREE8
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE8

                                Case LC_STYLE_FREE9
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE9

                                Case LC_STYLE_FREE10
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE10

                                Case LC_STYLE_FREE11
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE11

                                Case LC_STYLE_FREE12
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE12

                                Case LC_STYLE_FREE13
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE13

                                Case LC_STYLE_FREE14
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE14

                                Case LC_STYLE_FREE15
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE15

                                Case LC_STYLE_FREE16
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE16

                                Case LC_STYLE_FREE17
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE17

                                Case LC_STYLE_FREE18
                                    .MENUSTYLE = GC_MSTYLE_MENUGRP_DIRCFREE18
                            End Select

                        Case LC_PAT_PIC4
                            .MENUSTYLE = GC_MSTYLE_MENUGRP_PIC4

                        Case LC_PAT_PIC6
                            .MENUSTYLE = GC_MSTYLE_MENUGRP_PIC6

                        Case LC_PAT_PIC9
                            .MENUSTYLE = GC_MSTYLE_MENUGRP_PIC9

                        Case LC_PAT_PIC16
                            .MENUSTYLE = GC_MSTYLE_MENUGRP_PIC16

                    End Select

                    .GROUPKBN = GC_ORDER_NONE
                    .UPDID = GC_UPDID
                    .UPDYMD = Now
                End With
            Catch
                Exit Function
            End Try
        ElseIf pVal = "2" Then ' グループ選択時
            strStyle = GF_CboGetCode(cbo_Style, cbo_Style.SelectedIndex)

            Try
                '------------------------------
                ' 選択状態確認
                '------------------------------
                With pUpdVal
                    Select Case strStyle
                        Case LC_STYLE_PIC4
                            .MENUSTYLE = GC_MSTYLE_GOODS_PIC4

                        Case LC_STYLE_PIC6
                            .MENUSTYLE = GC_MSTYLE_GOODS_PIC6

                        Case LC_STYLE_PIC9
                            .MENUSTYLE = GC_MSTYLE_GOODS_PIC9

                        Case LC_STYLE_PIC16
                            .MENUSTYLE = GC_MSTYLE_GOODS_PIC16

                        Case LC_STYLE_DAILY
                            .MENUSTYLE = GC_MSTYLE_GOODS_DAILY

                        Case LC_STYLE_FREE1
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE1

                        Case LC_STYLE_FREE2
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE2

                        Case LC_STYLE_FREE3
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE3

                        Case LC_STYLE_FREE4
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE4

                        Case LC_STYLE_FREE5
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE5

                        Case LC_STYLE_FREE6
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE6

                        Case LC_STYLE_FREE7
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE7

                        Case LC_STYLE_FREE8
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE8

                        Case LC_STYLE_FREE9
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE9

                        Case LC_STYLE_FREE10
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE10

                        Case LC_STYLE_FREE11
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE11

                        Case LC_STYLE_FREE12
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE12

                        Case LC_STYLE_FREE13
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE13

                        Case LC_STYLE_FREE14
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE14

                        Case LC_STYLE_FREE15
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE15

                        Case LC_STYLE_FREE16
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE16

                        Case LC_STYLE_FREE17
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE17

                        Case LC_STYLE_FREE18
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE18
                    End Select

                    .GROUPKBN = GC_ORDER_NONE
                    .UPDID = GC_UPDID
                    .UPDYMD = Now
                End With
            Catch
                Exit Function
            End Try
        Else ' メニューグループ選択時(商品一覧直接表示時)
            strStyle = GF_CboGetCode(cbo_Style, cbo_Style.SelectedIndex)

            Try
                '------------------------------
                ' 選択状態確認
                '------------------------------
                With pUpdVal
                    Select Case strStyle
                        Case LC_STYLE_PIC4
                            .MENUSTYLE = GC_MSTYLE_GOODS_PIC4

                        Case LC_STYLE_PIC6
                            .MENUSTYLE = GC_MSTYLE_GOODS_PIC6

                        Case LC_STYLE_PIC9
                            .MENUSTYLE = GC_MSTYLE_GOODS_PIC9

                        Case LC_STYLE_PIC16
                            .MENUSTYLE = GC_MSTYLE_GOODS_PIC16

                        Case LC_STYLE_DAILY
                            .MENUSTYLE = GC_MSTYLE_GOODS_DAILY

                        Case LC_STYLE_FREE1
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE1

                        Case LC_STYLE_FREE2
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE2

                        Case LC_STYLE_FREE3
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE3

                        Case LC_STYLE_FREE4
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE4

                        Case LC_STYLE_FREE5
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE5

                        Case LC_STYLE_FREE6
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE6

                        Case LC_STYLE_FREE7
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE7

                        Case LC_STYLE_FREE8
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE8

                        Case LC_STYLE_FREE9
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE9

                        Case LC_STYLE_FREE10
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE10

                        Case LC_STYLE_FREE11
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE11

                        Case LC_STYLE_FREE12
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE12

                        Case LC_STYLE_FREE13
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE13

                        Case LC_STYLE_FREE14
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE14

                        Case LC_STYLE_FREE15
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE15

                        Case LC_STYLE_FREE16
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE16

                        Case LC_STYLE_FREE17
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE17

                        Case LC_STYLE_FREE18
                            .MENUSTYLE = GC_MSTYLE_GOODS_FREE18
                    End Select

                    .GROUPKBN = GC_ORDER_NONE
                    .UPDID = GC_UPDID
                    .UPDYMD = Now
                End With
            Catch
                Exit Function
            End Try
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetChkStatus = True

    End Function

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：「上へ移動」ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Up.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngTargetIndex As Long

        '------------------------------
        ' 未選択時は処理を行わない
        '------------------------------
        If lsv_MenuGrp.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        lngTargetIndex = lsv_MenuGrp.SelectedItems(0).Index - 1
        If lngTargetIndex < 0 Then
            Exit Sub
        End If

        '------------------------------
        ' ツリービューインデックス取得
        '------------------------------
        Call LS_GetTreeViweIndex()

        '------------------------------
        ' 表示順変更処理
        '------------------------------
        Call LS_ItemMove(lngTargetIndex, lsv_MenuGrp.SelectedItems)

        If L_GrpIdx.Equals(-1) Then
            '------------------------------
            ' メニューツリー生成処理
            '------------------------------
            Call LS_SetMenuTree()

            '------------------------------
            ' ツリービューインデックス設定
            '------------------------------
            Call LS_SetTreeViweIndex()
            lsv_MenuGrp.Items(CInt(lngTargetIndex)).Selected = True
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：「下へ移動」ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Dwn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Dwn.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngTargetIndex As Long

        '------------------------------
        ' 未選択時は処理を行わない
        '------------------------------
        If lsv_MenuGrp.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        lngTargetIndex = lsv_MenuGrp.SelectedItems(lsv_MenuGrp.SelectedItems.Count - 1).Index + 1
        If lngTargetIndex > lsv_MenuGrp.Items.Count - 1 Then
            Exit Sub
        End If

        '------------------------------
        ' ツリービューインデックス取得
        '------------------------------
        Call LS_GetTreeViweIndex()

        '------------------------------
        ' 表示順変更処理
        '------------------------------
        Call LS_ItemMove(lngTargetIndex, lsv_MenuGrp.SelectedItems)

        If L_GrpIdx.Equals(-1) Then
            '------------------------------
            ' メニューツリー生成処理
            '------------------------------
            Call LS_SetMenuTree()

            '------------------------------
            ' ツリービューインデックス設定
            '------------------------------
            Call LS_SetTreeViweIndex()
            lsv_MenuGrp.Items(CInt(lngTargetIndex)).Selected = True
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：表示順変更処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_ItemMove(ByVal pChgPos As Long, ByVal pMoveItems As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objItem As ListViewItem
        Dim lngPos As Integer
        Dim lngCnt As Integer
        Dim lngMoveTop As Integer
        Dim blnUpFlg As Boolean

        Try
            '------------------------------
            ' 変更位置判定
            '------------------------------
            If pChgPos < 0 Or lsv_MenuGrp.Items.Count - 1 < pChgPos Then
                Exit Sub
            End If

            If pChgPos <= pMoveItems(0).Index Then
                blnUpFlg = True
            Else
                blnUpFlg = False
            End If

            lngMoveTop = pMoveItems(0).Index
            For lngCnt = 1 To pMoveItems.Count - 1
                If lngMoveTop + 1 = pMoveItems(lngCnt).Index Then
                    lngMoveTop = pMoveItems(lngCnt).Index
                Else
                    blnUpFlg = True
                    Exit For
                End If
            Next

            '------------------------------
            ' 表示順位変更処理
            '------------------------------
            lngPos = pChgPos
            For Each objItem In pMoveItems
                If lngPos > objItem.Index And blnUpFlg Then lngPos = lngPos - 1
                lsv_MenuGrp.Items.Remove(objItem)
                lsv_MenuGrp.Items.Insert(lngPos, objItem)

                If blnUpFlg Then lngPos = lngPos + 1
            Next

            If L_GrpID.Equals("") Then
                '------------------------------
                ' 表示順項目更新処理
                '------------------------------
                If Not LF_UpdTPM060_5() Then
                    GoTo SYSTEM_ERROR
                End If
            Else
                '------------------------------
                ' 表示順項目更新処理
                '------------------------------
                If Not LF_UpdTPM020_2() Then
                    GoTo SYSTEM_ERROR
                End If
            End If

            L_EditFlg = True                                             ' 更新フラグＯＮ

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_ItemMove")
    End Sub

    Private Function LF_UpdTPM060_5() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strSQL2 As String
        Dim strSQL3 As String
        Dim strSQL4 As String
        Dim lngCnt As Long
        Dim objItem As ListViewItem

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM060_5 = False

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        '------------------------------
        ' 全アイテム表示順更新
        '------------------------------
        lngCnt = 1
        For Each objItem In lsv_MenuGrp.Items
            strSQL = ""
            strSQL = strSQL & "UPDATE TPM060"
            strSQL = strSQL & "   SET DISPORDER = '" & lngCnt & "',"
            strSQL = strSQL & "       UPDID     = '" & GC_UPDID & "',"
            strSQL = strSQL & "       UPDYMD    = '" & Now & "'"
            strSQL = strSQL & " WHERE MENUID    = '" & L_MenuID & "'"
            strSQL = strSQL & "   AND MENUGRPID = '" & L_MenuGrpID & "'"
            strSQL = strSQL & "   AND GROUPCD   = '" & objItem.SubItems(0).Text & "'"

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            '多言語機能対応
            If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                strSQL2 = ""
                strSQL2 = strSQL2 & "UPDATE TPM060A"
                strSQL2 = strSQL2 & "   SET DISPORDER = '" & lngCnt & "',"
                strSQL2 = strSQL2 & "       UPDID     = '" & GC_UPDID & "',"
                strSQL2 = strSQL2 & "       UPDYMD    = '" & Now & "'"
                strSQL2 = strSQL2 & " WHERE MENUID    = '" & L_MenuID & "'"
                strSQL2 = strSQL2 & "   AND MENUGRPID = '" & L_MenuGrpID & "'"
                strSQL2 = strSQL2 & "   AND GROUPCD   = '" & objItem.SubItems(0).Text & "'"

                If Not GF_UpdData(strSQL2) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                strSQL3 = ""
                strSQL3 = strSQL3 & "UPDATE TPM060B"
                strSQL3 = strSQL3 & "   SET DISPORDER = '" & lngCnt & "',"
                strSQL3 = strSQL3 & "       UPDID     = '" & GC_UPDID & "',"
                strSQL3 = strSQL3 & "       UPDYMD    = '" & Now & "'"
                strSQL3 = strSQL3 & " WHERE MENUID    = '" & L_MenuID & "'"
                strSQL3 = strSQL3 & "   AND MENUGRPID = '" & L_MenuGrpID & "'"
                strSQL3 = strSQL3 & "   AND GROUPCD   = '" & objItem.SubItems(0).Text & "'"

                If Not GF_UpdData(strSQL3) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                strSQL4 = ""
                strSQL4 = strSQL4 & "UPDATE TPM060C"
                strSQL4 = strSQL4 & "   SET DISPORDER = '" & lngCnt & "',"
                strSQL4 = strSQL4 & "       UPDID     = '" & GC_UPDID & "',"
                strSQL4 = strSQL4 & "       UPDYMD    = '" & Now & "'"
                strSQL4 = strSQL4 & " WHERE MENUID    = '" & L_MenuID & "'"
                strSQL4 = strSQL4 & "   AND MENUGRPID = '" & L_MenuGrpID & "'"
                strSQL4 = strSQL4 & "   AND GROUPCD   = '" & objItem.SubItems(0).Text & "'"

                If Not GF_UpdData(strSQL4) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

            End If

            lngCnt = lngCnt + 1
        Next

        '------------------------------
        ' トランザクション確定
        '------------------------------
        If Not GF_CommitTrans() Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM060_5 = True

    End Function

    Private Function LF_UpdTPM020_2() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strSQL2 As String
        Dim strSQL3 As String
        Dim strSQL4 As String
        Dim lngCnt As Long
        Dim objItem As ListViewItem

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020_2 = False

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        '------------------------------
        ' 全アイテム表示順更新
        '------------------------------
        lngCnt = 1
        For Each objItem In lsv_MenuGrp.Items
            strSQL = ""
            strSQL = strSQL & "UPDATE TPM020"
            strSQL = strSQL & "   SET DISPORDER = '" & Format$(lngCnt, "0000000000") & "',"
            strSQL = strSQL & "       UPDID     = '" & GC_UPDID & "',"
            strSQL = strSQL & "       UPDYMD    = '" & Now & "'"
            strSQL = strSQL & " WHERE GROUPCD   = '" & L_GrpID & "'"
            strSQL = strSQL & "   AND GOODSCD   = '" & objItem.SubItems(0).Text & "'"

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            '多言語機能対応
            If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                strSQL2 = ""
                strSQL2 = strSQL2 & "UPDATE TPM020A"
                strSQL2 = strSQL2 & "   SET DISPORDER = '" & Format$(lngCnt, "0000000000") & "',"
                strSQL2 = strSQL2 & "       UPDID     = '" & GC_UPDID & "',"
                strSQL2 = strSQL2 & "       UPDYMD    = '" & Now & "'"
                strSQL2 = strSQL2 & " WHERE GROUPCD   = '" & L_GrpID & "'"
                strSQL2 = strSQL2 & "   AND GOODSCD   = '" & objItem.SubItems(0).Text & "'"

                If Not GF_UpdData(strSQL2) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                strSQL3 = ""
                strSQL3 = strSQL3 & "UPDATE TPM020B"
                strSQL3 = strSQL3 & "   SET DISPORDER = '" & Format$(lngCnt, "0000000000") & "',"
                strSQL3 = strSQL3 & "       UPDID     = '" & GC_UPDID & "',"
                strSQL3 = strSQL3 & "       UPDYMD    = '" & Now & "'"
                strSQL3 = strSQL3 & " WHERE GROUPCD   = '" & L_GrpID & "'"
                strSQL3 = strSQL3 & "   AND GOODSCD   = '" & objItem.SubItems(0).Text & "'"

                If Not GF_UpdData(strSQL3) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                strSQL4 = ""
                strSQL4 = strSQL4 & "UPDATE TPM020C"
                strSQL4 = strSQL4 & "   SET DISPORDER = '" & Format$(lngCnt, "0000000000") & "',"
                strSQL4 = strSQL4 & "       UPDID     = '" & GC_UPDID & "',"
                strSQL4 = strSQL4 & "       UPDYMD    = '" & Now & "'"
                strSQL4 = strSQL4 & " WHERE GROUPCD   = '" & L_GrpID & "'"
                strSQL4 = strSQL4 & "   AND GOODSCD   = '" & objItem.SubItems(0).Text & "'"

                If Not GF_UpdData(strSQL4) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

            End If

            lngCnt = lngCnt + 1
        Next

        '------------------------------
        ' トランザクション確定
        '------------------------------
        If Not GF_CommitTrans() Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020_2 = True

    End Function

    Private Sub btn_MenuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MenuAdd.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objForm As Form = Nothing

        objForm = New CNL1551()

        objForm.ShowDialog()

        Select Case objForm.DialogResult
            Case DialogResult.OK
                Call LS_Initialize()
                L_EditFlg = True

            Case DialogResult.Cancel
                ' 何もしない

            Case Else
                GoTo SYSTEM_ERROR

        End Select

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_MenuAdd_Click")
    End Sub

    '    Private Sub btn_MenuCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '        '------------------------------
    '        ' 内部変数定義
    '        '------------------------------
    '        Dim objForm As Form = Nothing

    '        objForm = New CNL1554()

    '        objForm.ShowDialog()

    '        Select Case objForm.DialogResult
    '            Case DialogResult.OK
    '                Call LS_Initialize()
    '                L_EditFlg = True

    '            Case DialogResult.Cancel
    '                ' 何もしない

    '            Case Else
    '                GoTo SYSTEM_ERROR

    '        End Select

    '        Exit Sub

    'SYSTEM_ERROR:
    '        Call GS_ErrorTerm("btn_MenuAdd_Click")
    '    End Sub

    Private Sub btn_MenuDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MenuDel.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objForm As Form = Nothing

        If Not IsNothing(trv_Menu.SelectedNode) Then
            Select Case LF_UpdDeleteMenu(trv_Menu.SelectedNode)
                Case CNL1920.FuncResult.NormalEnd
                    Call LS_Initialize()

                Case CNL1920.FuncResult.CancelEnd
                    ' 何もしない

                Case CNL1920.FuncResult.UnusualEnd
                    GoTo SYSTEM_ERROR

                Case Else
                    GoTo SYSTEM_ERROR

            End Select
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_MenuDel_Click")
    End Sub

    Private Sub btn_GrpAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GrpAdd.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objForm As New CNL1542()

        '------------------------------
        ' ツリービューインデックス取得
        '------------------------------
        Call LS_GetTreeViweIndex()

        objForm.ShowDialog()

        If Len(Trim$(objForm.G_TP1032Ret)) <> 0 Then
            If Not LF_UpdTPM020_3(LC_UPDKBN_ADD, "", Trim$(objForm.G_TP1032Ret)) Then
                GoTo SYSTEM_ERROR
            End If
        Else
            Exit Sub
        End If

        L_EditFlg = True

        '------------------------------
        ' メニューツリー生成処理
        '------------------------------
        Call LS_SetMenuTree()

        '------------------------------
        ' ツリービューインデックス設定
        '------------------------------
        Call LS_SetTreeViweIndex()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_GrpAdd_Click")
    End Sub

    Private Sub btn_GrpDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GrpDel.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strGroupCd As String
        Dim strGroupNm As String

        '------------------------------
        ' 対象グループＣＤ、名称取得
        '------------------------------
        strGroupCd = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
        strGroupNm = Trim$(trv_Menu.SelectedNode.Text)

        '------------------------------
        ' ツリービューインデックス取得
        '------------------------------
        Call LS_GetTreeViweIndex()

        '------------------------------
        ' 削除時確認メッセージ
        '------------------------------
        If GF_Msg("", Replace(GF_GetMsg("Q05"), "@@@", strGroupNm), MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        '------------------------------
        ' メニューグループ削除確認処理
        '------------------------------
        Select Case LF_ChkDelMenu(strGroupCd, strGroupNm)
            Case CNL1920.FuncResult.CancelEnd
                Exit Sub
            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        If Not LF_UpdTPM020_3(LC_UPDKBN_DEL, strGroupCd) Then
            GoTo SYSTEM_ERROR
        End If

        L_EditFlg = True

        '------------------------------
        ' メニューツリー生成処理
        '------------------------------
        Call LS_SetMenuTree()

        '------------------------------
        ' ツリービューインデックス設定
        '------------------------------
        L_GrpIdx = -1                       ' グループ削除時はメニューグループ選択中とするため、グループのインデックスをクリア
        Call LS_SetTreeViweIndex()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_GrpDel_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューグループ連鎖削除確認処理
    ' 　機能概要：ジャンル削除により、連鎖的にメニューが無効化してしまう場合の確認処理
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.03 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_ChkDelMenu(ByVal pGroupCd As String, ByVal pGroupNm As String) As FuncResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_ChkDelMenu = CNL1920.FuncResult.UnusualEnd

        '------------------------------
        ' 連鎖無効化メニュー検索
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM060.MENUID,"
        strSQL = strSQL & "       TPM060.MENUNM"
        strSQL = strSQL & "  FROM TPM060 LEFT JOIN (SELECT TPM060.MENUID FROM TPM060 WHERE TPM060.GROUPCD NOT IN ('J000', '" & pGroupCd & "') GROUP BY TPM060.MENUID) AS TPM060_2 ON TPM060.MENUID = TPM060_2.MENUID"
        strSQL = strSQL & " WHERE TPM060_2.MENUID IS NULL"
        strSQL = strSQL & " GROUP BY TPM060.MENUID,"
        strSQL = strSQL & "          TPM060.MENUNM"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If

            If GF_Msg("", "ジャンル【" & pGroupNm & "】を削除すると、以下のメニューが無効となり、削除されます。よろしいですか？" & vbCrLf & "削除対象メニュー：【" & Trim$(objRows("MENUNM")) & "】", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.No Then
                LF_ChkDelMenu = CNL1920.FuncResult.CancelEnd
                Exit Function
            Else
                L_MenuIdx = 0
                L_MenuGrpIdx = -1
                L_GrpIdx = -1
            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_ChkDelMenu = CNL1920.FuncResult.NormalEnd

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ更新処理(グループ追加/削除処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM020_3(ByVal pUpdKbn As String, Optional ByVal pDelGrpCD As String = "", Optional ByVal pAddGrpNm As String = "") As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String = Nothing
        Dim strSQL2 As String = Nothing
        Dim strSQL3 As String = Nothing
        Dim strSQL4 As String = Nothing
        Dim strNewNo As String = Nothing
        Dim strGroupCd As String = Nothing
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim objBitmap1 As Bitmap
        Dim objBitmap2 As Bitmap
        Dim objBitmap3 As Bitmap
        Dim objBitmap4 As Bitmap
        Dim objGraph1 As Graphics
        Dim objGraph2 As Graphics
        Dim objGraph3 As Graphics
        Dim objGraph4 As Graphics
        Dim strGrpImgPath As String
        Dim strOrgPath As String
        Dim strTgtPath1 As String
        Dim strTgtPath2 As String = Nothing
        Dim strTgtPath3 As String = Nothing
        Dim strTgtPath4 As String = Nothing
        Dim strSTgtPath1 As String
        Dim strSTgtPath2 As String = Nothing
        Dim strSTgtPath3 As String = Nothing
        Dim strSTgtPath4 As String = Nothing
        Dim strFilePath1 As String
        Dim strFilePath2 As String = Nothing
        Dim strFilePath3 As String = Nothing
        Dim strFilePath4 As String = Nothing
        Dim strDefImg As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020_3 = False

        strDefImg = GF_GetMaterial("S047JC")
        If Len(Trim$(strDefImg)) = 0 Then
            Exit Function
        End If
        strGrpImgPath = GF_GetAppInfo("GROUP_PATH")
        objFileInfo = New System.IO.FileInfo(strDefImg)

        strSQL = ""
        strSQL2 = ""
        strSQL3 = ""
        strSQL4 = ""
        Select Case pUpdKbn
            Case LC_UPDKBN_ADD
                Select Case GF_GetNewID(CNL1920.ID_KIND.GenrID, strNewNo)
                    Case CNL1920.FuncResult.CancelEnd
                        GF_Msg("", "ジャンル登録数が上限に達しました。いずれかのメニューを削除して下さい。", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                        LF_UpdTPM020_3 = True
                        Exit Function

                    Case CNL1920.FuncResult.UnusualEnd
                        Exit Function
                End Select

                strOrgPath = GF_GetAppInfo("MATERIAL_V") & "\" & Trim$(strDefImg)
                ' TPM020
                strFilePath1 = Replace(objFileInfo.Name, objFileInfo.Extension, "") & Format$(Now, "yyyyMMddHHmmss") & objFileInfo.Extension
                strTgtPath1 = strGrpImgPath & "\" & strFilePath1
                strSTgtPath1 = strGrpImgPath & "\S_" & strFilePath1

                '多言語機能対応
                If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                    ' TPM020A
                    strFilePath2 = "A" & Replace(objFileInfo.Name, objFileInfo.Extension, "") & Format$(Now, "yyyyMMddHHmmss") & objFileInfo.Extension
                    strTgtPath2 = strGrpImgPath & "\" & strFilePath2
                    strSTgtPath2 = strGrpImgPath & "\S_" & strFilePath2

                    ' TPM020B
                    strFilePath3 = "B" & Replace(objFileInfo.Name, objFileInfo.Extension, "") & Format$(Now, "yyyyMMddHHmmss") & objFileInfo.Extension
                    strTgtPath3 = strGrpImgPath & "\" & strFilePath3
                    strSTgtPath3 = strGrpImgPath & "\S_" & strFilePath3

                    ' TPM020C
                    strFilePath4 = "C" & Replace(objFileInfo.Name, objFileInfo.Extension, "") & Format$(Now, "yyyyMMddHHmmss") & objFileInfo.Extension
                    strTgtPath4 = strGrpImgPath & "\" & strFilePath4
                    strSTgtPath4 = strGrpImgPath & "\S_" & strFilePath4
                End If

                '------------------------------
                ' オリジナルサイズコピー
                '------------------------------
                System.IO.File.Copy(strOrgPath, strTgtPath1)

                '多言語機能対応
                If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                    System.IO.File.Copy(strOrgPath, strTgtPath2)
                    System.IO.File.Copy(strOrgPath, strTgtPath3)
                    System.IO.File.Copy(strOrgPath, strTgtPath4)
                End If


                '------------------------------
                ' 縮小処理コピー(再保存)
                '------------------------------
                ' TPM020
                objBitmap1 = New Bitmap(352, 264)
                objGraph1 = Graphics.FromImage(objBitmap1)
                objGraph1.DrawImage(Image.FromFile(strTgtPath1), 0, 0, 352, 264)
                objBitmap1.Save(strSTgtPath1, System.Drawing.Imaging.ImageFormat.Png)
                objBitmap1.Dispose()
                objGraph1.Dispose()

                strSQL = strSQL & "INSERT INTO TPM020 VALUES("
                strSQL = strSQL & "'" & strNewNo & "',"
                strSQL = strSQL & "'0000',"
                strSQL = strSQL & "'" & IIf(Len(Trim$(pAddGrpNm)) = 0, LC_DEF_GRPNMJ, GF_RepQuo(pAddGrpNm)) & "',"
                strSQL = strSQL & "'" & Space(1) & "',"
                strSQL = strSQL & "'" & strFilePath1 & "',"
                strSQL = strSQL & "'" & LC_DEF_GRPPRICE & "',"
                strSQL = strSQL & "'0000000000',"
                strSQL = strSQL & "'" & GC_TRUE & "',"
                strSQL = strSQL & "'" & GC_FALSE & "',"
                strSQL = strSQL & "'" & GC_UPDID & "',"
                strSQL = strSQL & "'" & Now & "')"

                '多言語機能対応
                If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                    ' TPM020A
                    objBitmap2 = New Bitmap(352, 264)
                    objGraph2 = Graphics.FromImage(objBitmap2)
                    objGraph2.DrawImage(Image.FromFile(strTgtPath2), 0, 0, 352, 264)
                    objBitmap2.Save(strSTgtPath2, System.Drawing.Imaging.ImageFormat.Png)
                    objBitmap2.Dispose()
                    objGraph2.Dispose()

                    ' TPM020B
                    objBitmap3 = New Bitmap(352, 264)
                    objGraph3 = Graphics.FromImage(objBitmap3)
                    objGraph3.DrawImage(Image.FromFile(strTgtPath3), 0, 0, 352, 264)
                    objBitmap3.Save(strSTgtPath3, System.Drawing.Imaging.ImageFormat.Png)
                    objBitmap3.Dispose()
                    objGraph3.Dispose()

                    ' TPM020C
                    objBitmap4 = New Bitmap(352, 264)
                    objGraph4 = Graphics.FromImage(objBitmap4)
                    objGraph4.DrawImage(Image.FromFile(strTgtPath4), 0, 0, 352, 264)
                    objBitmap4.Save(strSTgtPath4, System.Drawing.Imaging.ImageFormat.Png)
                    objBitmap4.Dispose()
                    objGraph4.Dispose()

                    strSQL2 = strSQL2 & "INSERT INTO TPM020A VALUES("
                    strSQL2 = strSQL2 & "N'" & strNewNo & "',"
                    strSQL2 = strSQL2 & "N'0000',"
                    strSQL2 = strSQL2 & "N'" & IIf(Len(Trim$(pAddGrpNm)) = 0, LC_DEF_GRPNMJ, GF_RepQuo(pAddGrpNm)) & "',"
                    strSQL2 = strSQL2 & "N'" & Space(1) & "',"
                    strSQL2 = strSQL2 & "N'" & strFilePath2 & "',"
                    strSQL2 = strSQL2 & "N'" & LC_DEF_GRPPRICE & "',"
                    strSQL2 = strSQL2 & "N'0000000000',"
                    strSQL2 = strSQL2 & "N'" & GC_TRUE & "',"
                    strSQL2 = strSQL2 & "N'" & GC_FALSE & "',"
                    strSQL2 = strSQL2 & "N'" & GC_UPDID & "',"
                    strSQL2 = strSQL2 & "N'" & Now & "')"

                    strSQL3 = strSQL3 & "INSERT INTO TPM020B VALUES("
                    strSQL3 = strSQL3 & "N'" & strNewNo & "',"
                    strSQL3 = strSQL3 & "N'0000',"
                    strSQL3 = strSQL3 & "N'" & IIf(Len(Trim$(pAddGrpNm)) = 0, LC_DEF_GRPNMJ, GF_RepQuo(pAddGrpNm)) & "',"
                    strSQL3 = strSQL3 & "N'" & Space(1) & "',"
                    strSQL3 = strSQL3 & "N'" & strFilePath3 & "',"
                    strSQL3 = strSQL3 & "N'" & LC_DEF_GRPPRICE & "',"
                    strSQL3 = strSQL3 & "N'0000000000',"
                    strSQL3 = strSQL3 & "N'" & GC_TRUE & "',"
                    strSQL3 = strSQL3 & "N'" & GC_FALSE & "',"
                    strSQL3 = strSQL3 & "N'" & GC_UPDID & "',"
                    strSQL3 = strSQL3 & "N'" & Now & "')"

                    strSQL4 = strSQL4 & "INSERT INTO TPM020C VALUES("
                    strSQL4 = strSQL4 & "N'" & strNewNo & "',"
                    strSQL4 = strSQL4 & "N'0000',"
                    strSQL4 = strSQL4 & "N'" & IIf(Len(Trim$(pAddGrpNm)) = 0, LC_DEF_GRPNMJ, GF_RepQuo(pAddGrpNm)) & "',"
                    strSQL4 = strSQL4 & "N'" & Space(1) & "',"
                    strSQL4 = strSQL4 & "N'" & strFilePath4 & "',"
                    strSQL4 = strSQL4 & "N'" & LC_DEF_GRPPRICE & "',"
                    strSQL4 = strSQL4 & "N'0000000000',"
                    strSQL4 = strSQL4 & "N'" & GC_TRUE & "',"
                    strSQL4 = strSQL4 & "N'" & GC_FALSE & "',"
                    strSQL4 = strSQL4 & "N'" & GC_UPDID & "',"
                    strSQL4 = strSQL4 & "N'" & Now & "')"
                End If

                strGroupCd = strNewNo
            Case LC_UPDKBN_DEL
                strSQL = strSQL & "DELETE TPM020"
                strSQL = strSQL & " WHERE GROUPCD = '" & pDelGrpCD & "'"

                '多言語機能対応
                If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                    strSQL2 = strSQL2 & "DELETE TPM020A"
                    strSQL2 = strSQL2 & " WHERE GROUPCD = '" & pDelGrpCD & "'"

                    strSQL3 = strSQL3 & "DELETE TPM020B"
                    strSQL3 = strSQL3 & " WHERE GROUPCD = '" & pDelGrpCD & "'"

                    strSQL4 = strSQL4 & "DELETE TPM020C"
                    strSQL4 = strSQL4 & " WHERE GROUPCD = '" & pDelGrpCD & "'"
                End If

                strGroupCd = pDelGrpCD
            Case Else
                Exit Function
        End Select

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        '多言語機能対応
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            If Not GF_UpdData(strSQL2) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            If Not GF_UpdData(strSQL3) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            If Not GF_UpdData(strSQL4) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If
        End If

        '------------------------------
        ' トランザクション確定
        '------------------------------
        If Not GF_CommitTrans() Then
            Exit Function
        End If

        If LF_UpdTPM060_7(pUpdKbn, strGroupCd) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020_3 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：(ＤＢ更新契機)[選択済]商品グループ一覧 ドロップ時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM060_7(ByVal pUpdKbn As String, ByVal pGroupCd As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim intIndex As Integer
        Dim udtUpdVal As typTPM060 = Nothing
        Dim udtUpdKey As typTPM060 = Nothing

        Try
            Select Case pUpdKbn
                Case LC_UPDKBN_ADD
                    intIndex = lst_MenuGrp.Items.Count

                    '------------------------------
                    ' ＤＢ反映
                    '------------------------------
                    With udtUpdVal
                        .MENUID = LF_GetMenuGrpCD(trv_Menu.SelectedNode.Parent)
                        .MENUNM = GF_RepQuo(trv_Menu.SelectedNode.Parent.Text)
                        .MENUGRPID = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
                        .MENUGRPNM = GF_RepQuo(trv_Menu.SelectedNode.Text)
                        .GROUPCD = pGroupCd
                        .DISPORDER = CStr(intIndex)
                        .PRICEDISP = GC_FALSE
                        .ENABLED = GC_TRUE
                        .UPDID = GC_UPDID
                        .UPDYMD = Now
                    End With

                    Call LF_GetChkStatus(udtUpdVal, "2")                             ' チェック状態取得

                    If Not LF_UpdTPM060_3(udtUpdVal, udtUpdKey, True) Then
                        GoTo SYSTEM_ERROR
                    End If

                Case LC_UPDKBN_DEL
                    If Not LF_UpdTPM060_6(pGroupCd) Then
                        GoTo SYSTEM_ERROR
                    End If

                Case Else
                    Exit Function
            End Select

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Function

SYSTEM_ERROR:
        Call GS_ErrorTerm("LF_UpdTPM060_7")
    End Function

    Private Function LF_UpdTPM060_6(ByVal pDelGrpCd As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM060_6 = False

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        '------------------------------
        ' ジャンルを連鎖削除
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE FROM TPM060"
        strSQL = strSQL & "      WHERE GROUPCD = '" & pDelGrpCd & "'"

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        '多言語機能対応
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            strSQL = ""
            strSQL = strSQL & "DELETE FROM TPM060A"
            strSQL = strSQL & "      WHERE GROUPCD = '" & pDelGrpCd & "'"

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "DELETE FROM TPM060B"
            strSQL = strSQL & "      WHERE GROUPCD = '" & pDelGrpCd & "'"

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "DELETE FROM TPM060C"
            strSQL = strSQL & "      WHERE GROUPCD = '" & pDelGrpCd & "'"

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If
        End If

        '------------------------------
        ' 無効化メニュー削除処理
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM060.MENUID,"
        strSQL = strSQL & "       TPM060.MENUNM"
        strSQL = strSQL & "  FROM TPM060 LEFT JOIN (SELECT TPM060.MENUID FROM TPM060 WHERE TPM060.GROUPCD NOT IN ('J000') GROUP BY TPM060.MENUID) AS TPM060_2 ON TPM060.MENUID = TPM060_2.MENUID"
        strSQL = strSQL & " WHERE TPM060_2.MENUID IS NULL"
        strSQL = strSQL & " GROUP BY TPM060.MENUID,"
        strSQL = strSQL & "          TPM060.MENUNM"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "DELETE FROM TPM060"
            strSQL = strSQL & "      WHERE MENUID = '" & Trim$(objRows("MENUID")) & "'"

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "DELETE FROM TPM061"
            strSQL = strSQL & "      WHERE MENUID = '" & Trim$(objRows("MENUID")) & "'"

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            '多言語機能対応
            If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                strSQL = ""
                strSQL = strSQL & "DELETE FROM TPM060A"
                strSQL = strSQL & "      WHERE MENUID = '" & Trim$(objRows("MENUID")) & "'"

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                strSQL = ""
                strSQL = strSQL & "DELETE FROM TPM061A"
                strSQL = strSQL & "      WHERE MENUID = '" & Trim$(objRows("MENUID")) & "'"

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                strSQL = ""
                strSQL = strSQL & "DELETE FROM TPM060B"
                strSQL = strSQL & "      WHERE MENUID = '" & Trim$(objRows("MENUID")) & "'"

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                strSQL = ""
                strSQL = strSQL & "DELETE FROM TPM061B"
                strSQL = strSQL & "      WHERE MENUID = '" & Trim$(objRows("MENUID")) & "'"

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                strSQL = ""
                strSQL = strSQL & "DELETE FROM TPM060C"
                strSQL = strSQL & "      WHERE MENUID = '" & Trim$(objRows("MENUID")) & "'"

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                strSQL = ""
                strSQL = strSQL & "DELETE FROM TPM061C"
                strSQL = strSQL & "      WHERE MENUID = '" & Trim$(objRows("MENUID")) & "'"

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If
            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' トランザクション確定
        '------------------------------
        If Not GF_CommitTrans() Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM060_6 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ツリービュー 選択位置インデックス取得
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_GetTreeViweIndex()

        If IsNothing(trv_Menu.SelectedNode.Parent) Then
            L_MenuIdx = trv_Menu.SelectedNode.Index
            L_MenuGrpIdx = -1
            L_GrpIdx = -1
        Else
            If IsNothing(trv_Menu.SelectedNode.Parent.Parent) Then
                L_MenuIdx = trv_Menu.SelectedNode.Parent.Index
                L_MenuGrpIdx = trv_Menu.SelectedNode.Index
                L_GrpIdx = -1
            Else
                L_MenuIdx = trv_Menu.SelectedNode.Parent.Parent.Index
                L_MenuGrpIdx = trv_Menu.SelectedNode.Parent.Index
                L_GrpIdx = trv_Menu.SelectedNode.Index
            End If
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ツリービュー 選択位置インデックス設定
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetTreeViweIndex()

        If L_GrpIdx.Equals(-1) Then
            If L_MenuGrpIdx.Equals(-1) Then
                trv_Menu.SelectedNode = trv_Menu.Nodes.Item(L_MenuIdx)
            Else
                trv_Menu.SelectedNode = trv_Menu.Nodes.Item(L_MenuIdx).Nodes(L_MenuGrpIdx)
                trv_Menu.Nodes.Item(L_MenuIdx).Nodes(L_MenuGrpIdx).ExpandAll()
            End If
        Else
            trv_Menu.SelectedNode = trv_Menu.Nodes.Item(L_MenuIdx).Nodes(L_MenuGrpIdx).Nodes(L_GrpIdx)
            trv_Menu.Nodes.Item(L_MenuIdx).Nodes(L_MenuGrpIdx).Nodes(L_GrpIdx).ExpandAll()
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品一覧検索テキストボックス内 Enterキー押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_Search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call LS_SetItemGrp()
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品一覧検索テキストボックス入力時処理
    ' 　機能概要：入力長について、名称項目長(20バイト)で制限を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.02 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_Search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Search.TextChanged

        If txt_Search.Modified = False Then
            Exit Sub
        End If

        '------------------------------
        ' 入力長制限
        '------------------------------
        If GF_LenB(txt_Search.Text) > 20 Then
            txt_Search.Text = GF_MidB(txt_Search.Text, 1, 20)
            txt_Search.SelectionStart = GF_LenB(txt_Search.Text)
            Exit Sub
        End If
        Call LS_SetItemGrp()

    End Sub

    Private Sub btn_SelImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelImg.Click
        Call LS_GrpImgSelect()
    End Sub

    Private Sub btn_SelImg_A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelImg_A.Click
        Call LS_GrpImgSelect_A()
    End Sub

    Private Sub btn_SelImg_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelImg_B.Click
        Call LS_GrpImgSelect_B()
    End Sub

    Private Sub btn_SelImg_C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelImg_C.Click
        Call LS_GrpImgSelect_C()
    End Sub

    Private Sub LS_GrpImgSelect()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objForm As New CNL1541()
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim objFile As System.IO.FileStream
        Dim strRetName As String = Nothing
        Dim objNode As TreeNode = Nothing
        Dim strMode As String = Nothing

        With objForm
            objNode = trv_Menu.SelectedNode
            If IsNothing(objNode.Parent) Then
                '------------------------------
                ' [メニュー]選択時
                '------------------------------
                Exit Sub
            Else
                If IsNothing(objNode.Parent.Parent) Then
                    '------------------------------
                    ' [メニューグループ]選択時
                    '------------------------------
                    .G_TP1031_Ret = GF_GetAppInfo("MENUIMG_V") & "\" & txt_ImagePath.Text
                    strMode = LC_MENU_GRP
                Else
                    '------------------------------
                    ' [グループ]選択時
                    '------------------------------
                    .G_TP1031_Ret = GF_GetAppInfo("GROUP_PATH") & "\" & txt_ImagePath.Text
                    strMode = LC_GRP
                End If
            End If
            .ShowDialog()

            If Len(Trim$(.G_TP1031_Ret)) = 0 Then
                Exit Sub
            Else
                Call LS_TransGrpImage(.G_TP1031_Ret, strMode, strRetName)

                objFileInfo = New System.IO.FileInfo(strRetName)

                If IsNothing(objNode.Parent) Then
                    Exit Sub
                Else
                    If IsNothing(objNode.Parent.Parent) Then
                        If Not LF_UpdTPM061_1(L_MenuID, L_MenuGrpID, objFileInfo.Name) Then
                            GoTo SYSTEM_ERROR
                        End If

                        ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う
                        If Not LF_UpdTPM010_3(L_MenuID, L_MenuGrpID) Then
                            GoTo SYSTEM_ERROR
                        End If
                    Else
                        If Not LF_UpdTPM020_6(L_GrpID, objFileInfo.Name) Then
                            GoTo SYSTEM_ERROR
                        End If

                        ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う
                        If Not LF_UpdTPM010_2(L_GrpID) Then
                            GoTo SYSTEM_ERROR
                        End If
                    End If
                End If

                '------------------------------
                ' 表示反映
                '------------------------------
                Try
                    'GIF画像の場合
                    If Strings.Right(strRetName, 3) = "gif" Then
                        pic_Img.ImageLocation = strRetName
                    Else
                        objFile = New System.IO.FileStream(strRetName, IO.FileMode.Open, IO.FileAccess.Read)
                        pic_Img.Image = System.Drawing.Image.FromStream(objFile)
                        objFile.Close()
                    End If
                Catch
                    GoTo SYSTEM_ERROR
                End Try

                txt_ImagePath.Text = objFileInfo.Name

                L_EditFlg = True
            End If
        End With

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GrpImgSelect")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：英語メニュー画像登録
    ' 　機能概要：英語画面に表示するメニュー画像選択
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：20.12.02 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_GrpImgSelect_A()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objForm As New CNL1541()
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim objFile As System.IO.FileStream
        Dim strRetName As String = Nothing
        Dim objNode As TreeNode = Nothing
        Dim strMode As String = Nothing

        With objForm
            objNode = trv_Menu.SelectedNode
            If IsNothing(objNode.Parent) Then
                '------------------------------
                ' [メニュー]選択時
                '------------------------------
                Exit Sub
            Else
                If IsNothing(objNode.Parent.Parent) Then
                    '------------------------------
                    ' [メニューグループ]選択時
                    '------------------------------
                    .G_TP1031_Ret = GF_GetAppInfo("MENUIMG_V") & "\" & txt_ImagePath_A.Text
                    strMode = LC_MENU_GRP
                Else
                    '------------------------------
                    ' [グループ]選択時
                    '------------------------------
                    .G_TP1031_Ret = GF_GetAppInfo("GROUP_PATH") & "\" & txt_ImagePath_A.Text
                    strMode = LC_GRP
                End If
            End If
            .ShowDialog()

            If Len(Trim$(.G_TP1031_Ret)) = 0 Then
                Exit Sub
            Else
                Call LS_TransGrpImage(.G_TP1031_Ret, strMode, strRetName)

                objFileInfo = New System.IO.FileInfo(strRetName)

                If IsNothing(objNode.Parent) Then
                    Exit Sub
                Else
                    If IsNothing(objNode.Parent.Parent) Then
                        If Not LF_UpdTPM061A_1(L_MenuID, L_MenuGrpID, objFileInfo.Name) Then
                            GoTo SYSTEM_ERROR
                        End If

                        ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う
                        If Not LF_UpdTPM010_3(L_MenuID, L_MenuGrpID) Then
                            GoTo SYSTEM_ERROR
                        End If
                    Else
                        If Not LF_UpdTPM020A_6(L_GrpID, objFileInfo.Name) Then
                            GoTo SYSTEM_ERROR
                        End If

                        ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う
                        If Not LF_UpdTPM010_2(L_GrpID) Then
                            GoTo SYSTEM_ERROR
                        End If
                    End If
                End If

                '------------------------------
                ' 表示反映
                '------------------------------
                Try
                    'GIF画像の場合
                    If Strings.Right(strRetName, 3) = "gif" Then
                        pic_img_A.ImageLocation = strRetName
                    Else
                        objFile = New System.IO.FileStream(strRetName, IO.FileMode.Open, IO.FileAccess.Read)
                        pic_img_A.Image = System.Drawing.Image.FromStream(objFile)
                        objFile.Close()
                    End If
                Catch
                    GoTo SYSTEM_ERROR
                End Try

                txt_ImagePath_A.Text = objFileInfo.Name

                L_EditFlg = True
            End If
        End With

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GrpImgSelect_A")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：中国語メニュー画像登録
    ' 　機能概要：中国語画面に表示するメニュー画像選択
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：20.12.02 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_GrpImgSelect_B()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objForm As New CNL1541()
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim objFile As System.IO.FileStream
        Dim strRetName As String = Nothing
        Dim objNode As TreeNode = Nothing
        Dim strMode As String = Nothing

        With objForm
            objNode = trv_Menu.SelectedNode
            If IsNothing(objNode.Parent) Then
                '------------------------------
                ' [メニュー]選択時
                '------------------------------
                Exit Sub
            Else
                If IsNothing(objNode.Parent.Parent) Then
                    '------------------------------
                    ' [メニューグループ]選択時
                    '------------------------------
                    .G_TP1031_Ret = GF_GetAppInfo("MENUIMG_V") & "\" & txt_ImagePath_B.Text
                    strMode = LC_MENU_GRP
                Else
                    '------------------------------
                    ' [グループ]選択時
                    '------------------------------
                    .G_TP1031_Ret = GF_GetAppInfo("GROUP_PATH") & "\" & txt_ImagePath_B.Text
                    strMode = LC_GRP
                End If
            End If
            .ShowDialog()

            If Len(Trim$(.G_TP1031_Ret)) = 0 Then
                Exit Sub
            Else
                Call LS_TransGrpImage(.G_TP1031_Ret, strMode, strRetName)

                objFileInfo = New System.IO.FileInfo(strRetName)

                If IsNothing(objNode.Parent) Then
                    Exit Sub
                Else
                    If IsNothing(objNode.Parent.Parent) Then
                        If Not LF_UpdTPM061B_1(L_MenuID, L_MenuGrpID, objFileInfo.Name) Then
                            GoTo SYSTEM_ERROR
                        End If

                        ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う
                        If Not LF_UpdTPM010_3(L_MenuID, L_MenuGrpID) Then
                            GoTo SYSTEM_ERROR
                        End If
                    Else
                        If Not LF_UpdTPM020B_6(L_GrpID, objFileInfo.Name) Then
                            GoTo SYSTEM_ERROR
                        End If

                        ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う
                        If Not LF_UpdTPM010_2(L_GrpID) Then
                            GoTo SYSTEM_ERROR
                        End If
                    End If
                End If

                '------------------------------
                ' 表示反映
                '------------------------------
                Try
                    'GIF画像の場合
                    If Strings.Right(strRetName, 3) = "gif" Then
                        pic_img_B.ImageLocation = strRetName
                    Else
                        objFile = New System.IO.FileStream(strRetName, IO.FileMode.Open, IO.FileAccess.Read)
                        pic_img_B.Image = System.Drawing.Image.FromStream(objFile)
                        objFile.Close()
                    End If
                Catch
                    GoTo SYSTEM_ERROR
                End Try

                txt_ImagePath_B.Text = objFileInfo.Name

                L_EditFlg = True
            End If
        End With

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GrpImgSelect_B")
    End Sub

    Private Sub LS_GrpImgSelect_C()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objForm As New CNL1541()
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim objFile As System.IO.FileStream
        Dim strRetName As String = Nothing
        Dim objNode As TreeNode = Nothing
        Dim strMode As String = Nothing

        With objForm
            objNode = trv_Menu.SelectedNode
            If IsNothing(objNode.Parent) Then
                '------------------------------
                ' [メニュー]選択時
                '------------------------------
                Exit Sub
            Else
                If IsNothing(objNode.Parent.Parent) Then
                    '------------------------------
                    ' [メニューグループ]選択時
                    '------------------------------
                    .G_TP1031_Ret = GF_GetAppInfo("MENUIMG_V") & "\" & txt_ImagePath_C.Text
                    strMode = LC_MENU_GRP
                Else
                    '------------------------------
                    ' [グループ]選択時
                    '------------------------------
                    .G_TP1031_Ret = GF_GetAppInfo("GROUP_PATH") & "\" & txt_ImagePath_C.Text
                    strMode = LC_GRP
                End If
            End If
            .ShowDialog()

            If Len(Trim$(.G_TP1031_Ret)) = 0 Then
                Exit Sub
            Else
                Call LS_TransGrpImage(.G_TP1031_Ret, strMode, strRetName)

                objFileInfo = New System.IO.FileInfo(strRetName)

                If IsNothing(objNode.Parent) Then
                    Exit Sub
                Else
                    If IsNothing(objNode.Parent.Parent) Then
                        If Not LF_UpdTPM061C_1(L_MenuID, L_MenuGrpID, objFileInfo.Name) Then
                            GoTo SYSTEM_ERROR
                        End If

                        ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う
                        If Not LF_UpdTPM010_3(L_MenuID, L_MenuGrpID) Then
                            GoTo SYSTEM_ERROR
                        End If
                    Else
                        If Not LF_UpdTPM020C_6(L_GrpID, objFileInfo.Name) Then
                            GoTo SYSTEM_ERROR
                        End If

                        ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う
                        If Not LF_UpdTPM010_2(L_GrpID) Then
                            GoTo SYSTEM_ERROR
                        End If
                    End If
                End If

                '------------------------------
                ' 表示反映
                '------------------------------
                Try
                    'GIF画像の場合
                    If Strings.Right(strRetName, 3) = "gif" Then
                        pic_img_C.ImageLocation = strRetName
                    Else
                        objFile = New System.IO.FileStream(strRetName, IO.FileMode.Open, IO.FileAccess.Read)
                        pic_img_C.Image = System.Drawing.Image.FromStream(objFile)
                        objFile.Close()
                    End If
                Catch
                    GoTo SYSTEM_ERROR
                End Try

                txt_ImagePath_C.Text = objFileInfo.Name

                L_EditFlg = True
            End If
        End With

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GrpImgSelect_C")
    End Sub

    Private Sub LS_TransGrpImage(ByVal pFileNm As String, ByVal pSelectMode As String, ByRef pResultName As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim objBitmap As Bitmap
        Dim objGraph As Graphics
        Dim strGrpImgPath As String
        Dim strOrgPath As String
        Dim strTgtPath As String
        Dim strSTgtPath As String
        Dim strFilePath As String

        ' TP1031内では、全てフルパスで画像ファイルを扱う。
        ' 返却値(=G_TP1031_Ret)でも同様に、フルパスで返却されるが、これを
        ' システムで保持する『グループ画像保存パス』へ転送するため、
        ' ファイル情報として分解し、同パスへコピーを行う。
        ' 最終的に、他の画像が選択され、使われないことになったとしても、
        ' 画面クローズ時に、画像ガベージ処理を行うため、不要な画像ファイル
        ' は残らないことになる。
        Select Case pSelectMode
            Case LC_MENU_GRP
                strGrpImgPath = GF_GetAppInfo("MENUIMG_V")
            Case LC_GRP
                strGrpImgPath = GF_GetAppInfo("GROUP_PATH")
            Case Else
                Exit Sub
        End Select
        objFileInfo = New System.IO.FileInfo(pFileNm)
        strTgtPath = strGrpImgPath & "\" & objFileInfo.Name

        If objFileInfo.DirectoryName <> strGrpImgPath Then
            Try
                ' 既に同名のファイルが存在した場合は、それを消してしまって、新たに作り直す
                strOrgPath = pFileNm
                strFilePath = Replace(objFileInfo.Name, objFileInfo.Extension, "") & Format$(Now, "yyyyMMddHHmmss") & objFileInfo.Extension
                strTgtPath = strGrpImgPath & "\" & strFilePath
                strSTgtPath = strGrpImgPath & "\S_" & strFilePath

                '------------------------------
                ' 旧グループ画像を削除
                '------------------------------
                If System.IO.File.Exists(strTgtPath) = True Then
                    objFileInfo = Nothing
                    pResultName = strTgtPath
                End If

                If System.IO.File.Exists(strSTgtPath) = True Then
                    objFileInfo = Nothing
                    pResultName = strTgtPath
                End If

                '------------------------------
                ' オリジナルサイズコピー
                '------------------------------
                System.IO.File.Copy(strOrgPath, strTgtPath)

                '------------------------------
                ' 縮小処理コピー(再保存)
                '------------------------------
                Call LS_GetTreeViweIndex()

                If L_GrpIdx.Equals(-1) Then
                    If L_MenuGrpIdx.Equals(-1) Then
                        '------------------------------
                        ' メニュー選択時
                        '------------------------------
                        Exit Sub
                    Else
                        '------------------------------
                        ' メニューグループ選択時
                        '------------------------------
                        If L_MenuGrpIdx.Equals(0) Or L_MenuGrpIdx.Equals(1) Then
                            'GIF画像の場合、オリジナルサイズコピー
                            If Strings.Right(strTgtPath, 3) = "gif" Then
                                System.IO.File.Copy(strOrgPath, strSTgtPath)
                            Else
                                '------------------------------
                                ' 先頭から1,2番目のメニューグループの画像は大サイズ
                                '------------------------------
                                Dim imagew, imageh, lngHeight As Integer
                                Dim fs As System.IO.FileStream
                                fs = New System.IO.FileStream(strTgtPath, IO.FileMode.Open, IO.FileAccess.Read)
                                imagew = System.Drawing.Image.FromStream(fs).Width
                                imageh = System.Drawing.Image.FromStream(fs).Height
                                fs.Close()
                                lngHeight = (imageh * 352) / imagew
                                objBitmap = New Bitmap(352, lngHeight)
                                objGraph = Graphics.FromImage(objBitmap)
                                objGraph.DrawImage(Image.FromFile(strTgtPath), 0, 0, 352, lngHeight)
                                objBitmap.Save(strSTgtPath, System.Drawing.Imaging.ImageFormat.Png)
                                objBitmap.Dispose()
                                objGraph.Dispose()
                            End If
                        Else
                            'GIF画像の場合、オリジナルサイズコピー
                            If Strings.Right(strTgtPath, 3) = "gif" Then
                                System.IO.File.Copy(strOrgPath, strSTgtPath)
                            Else
                                objBitmap = New Bitmap(352, 264)
                                objGraph = Graphics.FromImage(objBitmap)
                                objGraph.DrawImage(Image.FromFile(strTgtPath), 0, 0, 352, 264)
                                objBitmap.Save(strSTgtPath, System.Drawing.Imaging.ImageFormat.Png)
                                objBitmap.Dispose()
                                objGraph.Dispose()
                            End If
                        End If
                    End If
                Else
                    '------------------------------
                    ' グループ選択時
                    '------------------------------
                    'GIF画像の場合、オリジナルサイズコピー
                    If Strings.Right(strTgtPath, 3) = "gif" Then
                        System.IO.File.Copy(strOrgPath, strSTgtPath)
                    Else
                        objBitmap = New Bitmap(352, 264)
                        objGraph = Graphics.FromImage(objBitmap)
                        objGraph.DrawImage(Image.FromFile(strTgtPath), 0, 0, 352, 264)
                        objBitmap.Save(strSTgtPath, System.Drawing.Imaging.ImageFormat.Png)
                        objBitmap.Dispose()
                        objGraph.Dispose()
                    End If
                End If

            Catch
                objFileInfo = Nothing
                Exit Sub
            End Try
        End If
        objFileInfo = Nothing
        pResultName = strTgtPath

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ更新処理(グループ情報更新処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM020_6(ByVal pGroupCD As String, Optional ByVal pImagePath As String = "") As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020_6 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM020"
        strSQL = strSQL & "   SET GROUPIMAGE = '" & IIf(Len(pImagePath) = 0, Space(100), pImagePath) & "',"
        strSQL = strSQL & "       SPFLG      = '" & IIf(chk_SpFlg.Checked, GC_TRUE, GC_FALSE) & "',"
        strSQL = strSQL & "       UPDID      = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD     = '" & Now & "'"
        strSQL = strSQL & " WHERE GROUPCD    = '" & pGroupCD & "'"
        strSQL = strSQL & "   AND GOODSCD    = '0000'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020_6 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ更新処理(グループ情報更新処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.02.06 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM020A_6(ByVal pGroupCD As String, Optional ByVal pImagePath As String = "") As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020A_6 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM020A"
        If pImagePath = "" Then
            strSQL = strSQL & "   SET SPFLG      = N'" & IIf(chk_SpFlg.Checked, GC_TRUE, GC_FALSE) & "',"
        Else
            strSQL = strSQL & "   SET GROUPIMAGE = N'" & IIf(Len(pImagePath) = 0, Space(100), pImagePath) & "',"
            strSQL = strSQL & "       SPFLG      = N'" & IIf(chk_SpFlg.Checked, GC_TRUE, GC_FALSE) & "',"
        End If
        strSQL = strSQL & "       UPDID      = N'" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD     = N'" & Now & "'"
        strSQL = strSQL & " WHERE GROUPCD    = '" & pGroupCD & "'"
        strSQL = strSQL & "   AND GOODSCD    = '0000'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020A_6 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ更新処理(グループ情報更新処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.02.06 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM020B_6(ByVal pGroupCD As String, Optional ByVal pImagePath As String = "") As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020B_6 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM020B"
        If pImagePath = "" Then
            strSQL = strSQL & "   SET SPFLG      = N'" & IIf(chk_SpFlg.Checked, GC_TRUE, GC_FALSE) & "',"
        Else
            strSQL = strSQL & "   SET GROUPIMAGE = N'" & IIf(Len(pImagePath) = 0, Space(100), pImagePath) & "',"
            strSQL = strSQL & "       SPFLG      = N'" & IIf(chk_SpFlg.Checked, GC_TRUE, GC_FALSE) & "',"
        End If
        strSQL = strSQL & "       UPDID      = N'" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD     = N'" & Now & "'"
        strSQL = strSQL & " WHERE GROUPCD    = '" & pGroupCD & "'"
        strSQL = strSQL & "   AND GOODSCD    = '0000'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020B_6 = True

    End Function

    Private Function LF_UpdTPM020C_6(ByVal pGroupCD As String, Optional ByVal pImagePath As String = "") As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020C_6 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM020C"
        If pImagePath = "" Then
            strSQL = strSQL & "   SET SPFLG      = N'" & IIf(chk_SpFlg.Checked, GC_TRUE, GC_FALSE) & "',"
        Else
            strSQL = strSQL & "   SET GROUPIMAGE = N'" & IIf(Len(pImagePath) = 0, Space(100), pImagePath) & "',"
            strSQL = strSQL & "       SPFLG      = N'" & IIf(chk_SpFlg.Checked, GC_TRUE, GC_FALSE) & "',"
        End If
        strSQL = strSQL & "       UPDID      = N'" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD     = N'" & Now & "'"
        strSQL = strSQL & " WHERE GROUPCD    = '" & pGroupCD & "'"
        strSQL = strSQL & "   AND GOODSCD    = '0000'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020C_6 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ更新処理(グループ情報更新処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM061_1(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByVal pImagePath As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM061_1 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM061"
        strSQL = strSQL & "   SET FILENM    = '" & IIf(Len(pImagePath) = 0, Space(100), pImagePath) & "',"
        strSQL = strSQL & "       UPDID     = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD    = '" & Now & "'"
        strSQL = strSQL & " WHERE MENUID    = '" & pMenuID & "'"
        strSQL = strSQL & "   AND MENUGRPID = '" & pMenuGrpID & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM061_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ更新処理(グループ情報更新処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM061A_1(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByVal pImagePath As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM061A_1 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM061A"
        strSQL = strSQL & "   SET FILENM    = N'" & IIf(Len(pImagePath) = 0, Space(100), pImagePath) & "',"
        strSQL = strSQL & "       UPDID     = N'" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD    = N'" & Now & "'"
        strSQL = strSQL & " WHERE MENUID    = '" & pMenuID & "'"
        strSQL = strSQL & "   AND MENUGRPID = '" & pMenuGrpID & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM061A_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ更新処理(グループ情報更新処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM061B_1(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByVal pImagePath As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM061B_1 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM061B"
        strSQL = strSQL & "   SET FILENM    = N'" & IIf(Len(pImagePath) = 0, Space(100), pImagePath) & "',"
        strSQL = strSQL & "       UPDID     = N'" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD    = N'" & Now & "'"
        strSQL = strSQL & " WHERE MENUID    = '" & pMenuID & "'"
        strSQL = strSQL & "   AND MENUGRPID = '" & pMenuGrpID & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM061B_1 = True

    End Function

    Private Function LF_UpdTPM061C_1(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByVal pImagePath As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM061C_1 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM061C"
        strSQL = strSQL & "   SET FILENM    = N'" & IIf(Len(pImagePath) = 0, Space(100), pImagePath) & "',"
        strSQL = strSQL & "       UPDID     = N'" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD    = N'" & Now & "'"
        strSQL = strSQL & " WHERE MENUID    = '" & pMenuID & "'"
        strSQL = strSQL & "   AND MENUGRPID = '" & pMenuGrpID & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM061C_1 = True

    End Function

    Private Function LF_UpdTPM010_2(ByVal pGroupCD As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM010_2 = False

        '------------------------------
        ' 商品マスタ更新
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM010"
        strSQL = strSQL & "   SET TPM010.GENERATEFLG = '" & GC_TRUE & "',"
        strSQL = strSQL & "       TPM010.UPDID       = '" & GC_UPDID & "',"
        strSQL = strSQL & "       TPM010.UPDYMD      = getdate()"
        strSQL = strSQL & " WHERE TPM010.GOODSCD IN (SELECT TPM010.GOODSCD"
        strSQL = strSQL & "                            FROM TPM010,"
        strSQL = strSQL & "                                 TPM020"
        strSQL = strSQL & "                           WHERE TPM020.GROUPCD = '" & pGroupCD & "'"
        strSQL = strSQL & "                             AND TPM020.GOODSCD <> '0000'"
        strSQL = strSQL & "                             AND TPM020.GOODSCD = TPM010.GOODSCD)"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM010_2 = True

    End Function

    Private Function LF_UpdTPM010_3(ByVal pMenuID As String, ByVal pMenuGrpID As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM010_3 = False

        '------------------------------
        ' 商品マスタ更新
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM010"
        strSQL = strSQL & "   SET TPM010.GENERATEFLG = '" & GC_TRUE & "',"
        strSQL = strSQL & "       TPM010.UPDID       = '" & GC_UPDID & "',"
        strSQL = strSQL & "       TPM010.UPDYMD      = getdate()"
        strSQL = strSQL & " WHERE TPM010.GOODSCD IN (SELECT TPM010.GOODSCD"
        strSQL = strSQL & "                            FROM TPM010,"
        strSQL = strSQL & "                                 TPM020,"
        strSQL = strSQL & "                                 TPM060"
        strSQL = strSQL & "                           WHERE TPM060.MENUID    = '" & pMenuID & "'"
        strSQL = strSQL & "                             AND TPM060.MENUGRPID = '" & pMenuGrpID & "'"
        strSQL = strSQL & "                             AND TPM060.GROUPCD  <> 'J000'"
        strSQL = strSQL & "                             AND TPM060.GROUPCD   = TPM020.GROUPCD"
        strSQL = strSQL & "                             AND TPM020.GOODSCD  <> '0000'"
        strSQL = strSQL & "                             AND TPM020.GOODSCD   = TPM010.GOODSCD)"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM010_3 = True

    End Function

    Private Sub btn_DelImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DelImg.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strDefImg As String
        Dim strGrpImgPath As String
        Dim strRetName As String = Nothing
        Dim objFile As System.IO.FileStream
        Dim objNode As TreeNode = Nothing
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim strMode As String = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        Call LS_GetTreeViweIndex()

        If L_GrpIdx.Equals(-1) Then
            If L_MenuGrpIdx.Equals(-1) Then
                '------------------------------
                ' メニュー選択時
                '------------------------------
                Exit Sub
            Else
                '------------------------------
                ' メニューグループ選択時
                '------------------------------
                If L_MenuGrpIdx.Equals(0) Or L_MenuGrpIdx.Equals(1) Then
                    '------------------------------
                    ' 先頭から1,2番目のメニューグループの画像は大サイズ
                    '------------------------------
                    strDefImg = GF_GetMaterial("S048JC")
                Else
                    strDefImg = GF_GetMaterial("S047JC")
                End If
                strMode = LC_MENU_GRP
            End If
        Else
            '------------------------------
            ' グループ選択時
            '------------------------------
            strDefImg = GF_GetMaterial("S047JC")
            strMode = LC_GRP
        End If

        If Len(Trim$(strDefImg)) = 0 Then
            GoTo SYSTEM_ERROR
        End If
        strGrpImgPath = GF_GetAppInfo("MATERIAL_V") & "\" & Trim$(strDefImg)

        txt_ImagePath.Text = ""

        Call LS_TransGrpImage(strGrpImgPath, strMode, strRetName)

        objFileInfo = New System.IO.FileInfo(strRetName)

        objNode = trv_Menu.SelectedNode
        If IsNothing(objNode.Parent) Then
            Exit Sub
        Else
            If IsNothing(objNode.Parent.Parent) Then
                '------------------------------
                ' グループイメージを解除
                '------------------------------
                If Not LF_UpdTPM061_1(L_MenuID, L_MenuGrpID, objFileInfo.Name) Then
                    GoTo SYSTEM_ERROR
                End If

                '------------------------------
                ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う
                '------------------------------
                If Not LF_UpdTPM010_3(L_MenuID, L_MenuGrpID) Then
                    GoTo SYSTEM_ERROR
                End If
            Else
                '------------------------------
                ' グループイメージを解除
                '------------------------------
                If Not LF_UpdTPM020_6(L_GrpID, objFileInfo.Name) Then
                    GoTo SYSTEM_ERROR
                End If

                '------------------------------
                ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う
                '------------------------------
                If Not LF_UpdTPM010_2(L_GrpID) Then
                    GoTo SYSTEM_ERROR
                End If
            End If
        End If

        '------------------------------
        ' 表示反映
        '------------------------------
        Try
            'GIF画像の場合
            If Strings.Right(strRetName, 3) = "gif" Then
                pic_Img.ImageLocation = strRetName
            Else
                objFile = New System.IO.FileStream(strRetName, IO.FileMode.Open, IO.FileAccess.Read)
                pic_Img.Image = System.Drawing.Image.FromStream(objFile)
                objFile.Close()
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        txt_ImagePath.Text = objFileInfo.Name

        L_EditFlg = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_DelImg_Click")
    End Sub

    Private Sub btn_DelImg_A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DelImg_A.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strDefImg As String
        Dim strGrpImgPath As String
        Dim strRetName As String = Nothing
        Dim objFile As System.IO.FileStream
        Dim objNode As TreeNode = Nothing
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim strMode As String = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        Call LS_GetTreeViweIndex()

        If L_GrpIdx.Equals(-1) Then
            If L_MenuGrpIdx.Equals(-1) Then
                '------------------------------
                ' メニュー選択時
                '------------------------------
                Exit Sub
            Else
                '------------------------------
                ' メニューグループ選択時
                '------------------------------
                If L_MenuGrpIdx.Equals(0) Or L_MenuGrpIdx.Equals(1) Then
                    '------------------------------
                    ' 先頭から1,2番目のメニューグループの画像は大サイズ
                    '------------------------------
                    strDefImg = GF_GetMaterial("S048JC")
                Else
                    strDefImg = GF_GetMaterial("S047JC")
                End If
                strMode = LC_MENU_GRP
            End If
        Else
            '------------------------------
            ' グループ選択時
            '------------------------------
            strDefImg = GF_GetMaterial("S047JC")
            strMode = LC_GRP
        End If

        If Len(Trim$(strDefImg)) = 0 Then
            GoTo SYSTEM_ERROR
        End If
        strGrpImgPath = GF_GetAppInfo("MATERIAL_V") & "\" & Trim$(strDefImg)

        txt_ImagePath_A.Text = ""

        Call LS_TransGrpImage(strGrpImgPath, strMode, strRetName)

        objFileInfo = New System.IO.FileInfo(strRetName)

        objNode = trv_Menu.SelectedNode
        If IsNothing(objNode.Parent) Then
            Exit Sub
        Else
            If IsNothing(objNode.Parent.Parent) Then
                '------------------------------
                ' グループイメージを解除
                '------------------------------
                If Not LF_UpdTPM061A_1(L_MenuID, L_MenuGrpID, objFileInfo.Name) Then
                    GoTo SYSTEM_ERROR
                End If

                '------------------------------
                ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う
                '------------------------------
                'If Not LF_UpdTPM010A_3(L_MenuID, L_MenuGrpID) Then
                '    GoTo SYSTEM_ERROR
                'End If
            Else
                '------------------------------
                ' グループイメージを解除
                '------------------------------
                If Not LF_UpdTPM020A_6(L_GrpID, objFileInfo.Name) Then
                    GoTo SYSTEM_ERROR
                End If

                '------------------------------
                ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う
                '------------------------------
                'If Not LF_UpdTPM010_2(L_GrpID) Then
                '    GoTo SYSTEM_ERROR
                'End If
            End If
        End If

        '------------------------------
        ' 表示反映
        '------------------------------
        Try
            'GIF画像の場合
            If Strings.Right(strRetName, 3) = "gif" Then
                pic_img_A.ImageLocation = strRetName
            Else
                objFile = New System.IO.FileStream(strRetName, IO.FileMode.Open, IO.FileAccess.Read)
                pic_img_A.Image = System.Drawing.Image.FromStream(objFile)
                objFile.Close()
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        txt_ImagePath_A.Text = objFileInfo.Name

        L_EditFlg = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_DelImg_A_Click")
    End Sub

    Private Sub btn_DelImg_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DelImg_B.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strDefImg As String
        Dim strGrpImgPath As String
        Dim strRetName As String = Nothing
        Dim objFile As System.IO.FileStream
        Dim objNode As TreeNode = Nothing
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim strMode As String = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        Call LS_GetTreeViweIndex()

        If L_GrpIdx.Equals(-1) Then
            If L_MenuGrpIdx.Equals(-1) Then
                '------------------------------
                ' メニュー選択時
                '------------------------------
                Exit Sub
            Else
                '------------------------------
                ' メニューグループ選択時
                '------------------------------
                If L_MenuGrpIdx.Equals(0) Or L_MenuGrpIdx.Equals(1) Then
                    '------------------------------
                    ' 先頭から1,2番目のメニューグループの画像は大サイズ
                    '------------------------------
                    strDefImg = GF_GetMaterial("S048JC")
                Else
                    strDefImg = GF_GetMaterial("S047JC")
                End If
                strMode = LC_MENU_GRP
            End If
        Else
            '------------------------------
            ' グループ選択時
            '------------------------------
            strDefImg = GF_GetMaterial("S047JC")
            strMode = LC_GRP
        End If

        If Len(Trim$(strDefImg)) = 0 Then
            GoTo SYSTEM_ERROR
        End If
        strGrpImgPath = GF_GetAppInfo("MATERIAL_V") & "\" & Trim$(strDefImg)

        txt_ImagePath_B.Text = ""

        Call LS_TransGrpImage(strGrpImgPath, strMode, strRetName)

        objFileInfo = New System.IO.FileInfo(strRetName)

        objNode = trv_Menu.SelectedNode
        If IsNothing(objNode.Parent) Then
            Exit Sub
        Else
            If IsNothing(objNode.Parent.Parent) Then
                '------------------------------
                ' グループイメージを解除
                '------------------------------
                If Not LF_UpdTPM061B_1(L_MenuID, L_MenuGrpID, objFileInfo.Name) Then
                    GoTo SYSTEM_ERROR
                End If

                '------------------------------
                ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う
                '------------------------------
                'If Not LF_UpdTPM010A_3(L_MenuID, L_MenuGrpID) Then
                '    GoTo SYSTEM_ERROR
                'End If
            Else
                '------------------------------
                ' グループイメージを解除
                '------------------------------
                If Not LF_UpdTPM020B_6(L_GrpID, objFileInfo.Name) Then
                    GoTo SYSTEM_ERROR
                End If

                '------------------------------
                ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う
                '------------------------------
                'If Not LF_UpdTPM010_2(L_GrpID) Then
                '    GoTo SYSTEM_ERROR
                'End If
            End If
        End If

        '------------------------------
        ' 表示反映
        '------------------------------
        Try
            'GIF画像の場合
            If Strings.Right(strRetName, 3) = "gif" Then
                pic_img_B.ImageLocation = strRetName
            Else
                objFile = New System.IO.FileStream(strRetName, IO.FileMode.Open, IO.FileAccess.Read)
                pic_img_B.Image = System.Drawing.Image.FromStream(objFile)
                objFile.Close()
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        txt_ImagePath_B.Text = objFileInfo.Name

        L_EditFlg = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_DelImg_B_Click")
    End Sub

    Private Sub btn_DelImg_C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DelImg_C.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strDefImg As String
        Dim strGrpImgPath As String
        Dim strRetName As String = Nothing
        Dim objFile As System.IO.FileStream
        Dim objNode As TreeNode = Nothing
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim strMode As String = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        Call LS_GetTreeViweIndex()

        If L_GrpIdx.Equals(-1) Then
            If L_MenuGrpIdx.Equals(-1) Then
                '------------------------------
                ' メニュー選択時
                '------------------------------
                Exit Sub
            Else
                '------------------------------
                ' メニューグループ選択時
                '------------------------------
                If L_MenuGrpIdx.Equals(0) Or L_MenuGrpIdx.Equals(1) Then
                    '------------------------------
                    ' 先頭から1,2番目のメニューグループの画像は大サイズ
                    '------------------------------
                    strDefImg = GF_GetMaterial("S048JC")
                Else
                    strDefImg = GF_GetMaterial("S047JC")
                End If
                strMode = LC_MENU_GRP
            End If
        Else
            '------------------------------
            ' グループ選択時
            '------------------------------
            strDefImg = GF_GetMaterial("S047JC")
            strMode = LC_GRP
        End If

        If Len(Trim$(strDefImg)) = 0 Then
            GoTo SYSTEM_ERROR
        End If
        strGrpImgPath = GF_GetAppInfo("MATERIAL_V") & "\" & Trim$(strDefImg)

        txt_ImagePath_C.Text = ""

        Call LS_TransGrpImage(strGrpImgPath, strMode, strRetName)

        objFileInfo = New System.IO.FileInfo(strRetName)

        objNode = trv_Menu.SelectedNode
        If IsNothing(objNode.Parent) Then
            Exit Sub
        Else
            If IsNothing(objNode.Parent.Parent) Then
                '------------------------------
                ' グループイメージを解除
                '------------------------------
                If Not LF_UpdTPM061C_1(L_MenuID, L_MenuGrpID, objFileInfo.Name) Then
                    GoTo SYSTEM_ERROR
                End If

                '------------------------------
                ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う
                '------------------------------
                'If Not LF_UpdTPM010A_3(L_MenuID, L_MenuGrpID) Then
                '    GoTo SYSTEM_ERROR
                'End If
            Else
                '------------------------------
                ' グループイメージを解除
                '------------------------------
                If Not LF_UpdTPM020C_6(L_GrpID, objFileInfo.Name) Then
                    GoTo SYSTEM_ERROR
                End If

                '------------------------------
                ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う
                '------------------------------
                'If Not LF_UpdTPM010_2(L_GrpID) Then
                '    GoTo SYSTEM_ERROR
                'End If
            End If
        End If

        '------------------------------
        ' 表示反映
        '------------------------------
        Try
            'GIF画像の場合
            If Strings.Right(strRetName, 3) = "gif" Then
                pic_img_C.ImageLocation = strRetName
            Else
                objFile = New System.IO.FileStream(strRetName, IO.FileMode.Open, IO.FileAccess.Read)
                pic_img_C.Image = System.Drawing.Image.FromStream(objFile)
                objFile.Close()
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        txt_ImagePath_C.Text = objFileInfo.Name

        L_EditFlg = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_DelImg_C_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：[日替り商品登録に表示]チェックボックス　チェック変更時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub chk_SpFlg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_SpFlg.CheckedChanged

        If L_ProcFlg2 Then
            Exit Sub
        End If

        If IsNothing(trv_Menu.SelectedNode) Then
            Exit Sub
        End If

        If IsNothing(trv_Menu.SelectedNode.Parent) Then
            Exit Sub
        End If

        Try
            '------------------------------
            ' グループイメージを解除
            '------------------------------
            If Not LF_UpdTPM020_6(L_GrpID) Then
                GoTo SYSTEM_ERROR
            End If

            '多言語機能対応
            If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                If Not LF_UpdTPM020A_6(L_GrpID) Then
                    GoTo SYSTEM_ERROR
                End If

                If Not LF_UpdTPM020B_6(L_GrpID) Then
                    GoTo SYSTEM_ERROR
                End If

                If Not LF_UpdTPM020C_6(L_GrpID) Then
                    GoTo SYSTEM_ERROR
                End If
            End If

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("chk_SpFlg_CheckedChanged")
    End Sub
End Class
