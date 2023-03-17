' --------------------------------------------------------------------------------
' 　機　　能：店舗内情報システム - サーバメンテナンス(メニュー登録画面)
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
' --------------------------------------------------------------------------------

Public Class CNL1550
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "にぎり", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "ドリンク", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "おすすめ", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "ジャンルＡ", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "ジャンルＢ", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "ジャンルＣ", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CNL1550))
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "一二〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "一六〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "二〇〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "二四〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "二八〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "三二〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "四〇〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "四八〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "五六〇円", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))}, 0)
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
        Me.Label3.Text = "● 商品ジャンル"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.txt_MenuTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_MenuTitle.Location = New System.Drawing.Point(112, 24)
        Me.txt_MenuTitle.Name = "txt_MenuTitle"
        Me.txt_MenuTitle.Size = New System.Drawing.Size(360, 20)
        Me.txt_MenuTitle.TabIndex = 4
        Me.txt_MenuTitle.Text = ""
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
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
        Me.Label2.Text = "メニュータイトル"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'trv_Menu
        '
        Me.trv_Menu.CheckBoxes = True
        Me.trv_Menu.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.trv_Menu.ImageList = Me.ImageList3
        Me.trv_Menu.Indent = 25
        Me.trv_Menu.Location = New System.Drawing.Point(24, 64)
        Me.trv_Menu.Name = "trv_Menu"
        Me.trv_Menu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("メニュー１", New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("握り鮨"), New System.Windows.Forms.TreeNode("細・中巻き"), New System.Windows.Forms.TreeNode("手巻き"), New System.Windows.Forms.TreeNode("一品料理"), New System.Windows.Forms.TreeNode("ドリンク"), New System.Windows.Forms.TreeNode("未設定"), New System.Windows.Forms.TreeNode("未設定"), New System.Windows.Forms.TreeNode("未設定"), New System.Windows.Forms.TreeNode("ノード0"), New System.Windows.Forms.TreeNode("ノード1")})})
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
        Me.ToolBarButton1.Text = "新しいメニューを作る"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 1
        Me.ToolBarButton2.Text = "メニューをコピーする"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 2
        Me.ToolBarButton3.Text = "メニューを削除する"
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
        Me.MenuItem1.Text = "ファイル(&F)"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "保存(&S)"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "終了(&E)"
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
        Me.Label4.Text = "● 商品ジャンル"
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
        Me.GroupBox1.Text = "メニューグループ情報"
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
        Me.GroupBox2.Text = "画面表示方法を選択して下さい"
        '
        'btn_MenuPic
        '
        Me.btn_MenuPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_MenuPic.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_MenuPic.Location = New System.Drawing.Point(256, 96)
        Me.btn_MenuPic.Name = "btn_MenuPic"
        Me.btn_MenuPic.Size = New System.Drawing.Size(160, 32)
        Me.btn_MenuPic.TabIndex = 9
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
        Me.chk_Price.Location = New System.Drawing.Point(56, 80)
        Me.chk_Price.Name = "chk_Price"
        Me.chk_Price.Size = New System.Drawing.Size(160, 24)
        Me.chk_Price.TabIndex = 7
        Me.chk_Price.Text = "金額別に表示する"
        '
        'chk_ShowGenr
        '
        Me.chk_ShowGenr.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_ShowGenr.Location = New System.Drawing.Point(56, 104)
        Me.chk_ShowGenr.Name = "chk_ShowGenr"
        Me.chk_ShowGenr.Size = New System.Drawing.Size(168, 24)
        Me.chk_ShowGenr.TabIndex = 8
        Me.chk_ShowGenr.Text = "ジャンル名を表示する"
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
    ' モジュール内変数定義
    ' --------------------------------------------------------------------------------
    Private L_DragMode As String
    Private L_TitleStr As String
    Private L_ProcFlg As Boolean
    Private L_ProcFlg2 As Boolean
    Private L_EditFlg As Boolean
    Private L_MenuGrpID As String       '--(2006.01.27)
    Private L_MenuID As String

    ' --------------------------------------------------------------------------------
    ' モジュール内定数定義
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
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub TP1040_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' フォーム名称設定
        '------------------------------
        Me.Text = GF_FormText("- メニュー登録画面")

        '------------------------------
        ' フォーム初期化処理
        '------------------------------
        Call LS_Initialize()

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            GoTo SYSTEM_ERROR
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("TP1040_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォームクローズイベント
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub TP1040_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Dim strMenuNM As String = Nothing
        Dim strMenuGrpNM As String = Nothing

        '中ジャンル割付チェック
        If LF_CheckMenuPic("TPM060", strMenuNM, strMenuGrpNM) = False Then
            GF_Msg("", "【" & strMenuNM & " - " & strMenuGrpNM & "】のメニュー画像に割付が行われていません。" & vbCrLf & "表示方法を変更するか、メニュー画像にジャンルの割付処理を行ってください。", MsgBoxStyle.OKOnly)
            e.Cancel = True
            Exit Sub
        End If

        If L_EditFlg Then
            Select Case LF_TP1040Save(False)
                Case CNL1920.FuncResult.NormalEnd
                    ' 何もしない
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
    ' 　機　　能：[TP1040]終了処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_TP1040Term()
        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：[TP1040]保存処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_TP1040Save(ByVal pMode As Boolean) As FuncResult

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_TP1040Save = CNL1920.FuncResult.UnusualEnd

        If L_EditFlg Then
            Select Case GF_Msg("Q03", "", MsgBoxStyle.YesNoCancel, MsgBoxStyle.Question)
                Case MsgBoxResult.Yes

                    ' --- (2003.11.19) 無効なメニューのチェック処理を追加 ---
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

                    If Not GF_CommitTrans() Then                                    ' トランザクション確定
                        GoTo SYSTEM_ERROR
                    End If

                    '--- (2006.02.14) メニュー切り替え対応 -------------------------------------
                    ''  FUMENU更新
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
        ' --- (2003.11.19) 有効性のチェック処理を追加 ---
        ' 全ノードを見て、一つもジャンルの登録されていないメニューボタンは、ENABLED=GC_FALSEを設定するようにする
        ' また、親ノードから見て、全ての子ノードがENABLED=GC_FALSEであれば、無効なメニューであることをメッセージにて示し、削除してしまう
        ' -----------------------------------------------

        ' 引数 pMode について
        '  > pMode = True / チェック処理のみで、削除処理/無効化処理は行わない。
        '  > pMode = False / チェック処理/削除処理/無効化処理を行う。メッセージ確認は行わない。

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

            ' ジャンル登録済みであっても、全ての子ノードの .Checked 状態が False の場合は、同様の扱いとする
            If blnAllUnUse = False Then
                blnFound = False
            End If

            If blnFound = False Then
                '------------------------------
                ' 無効メニュー検出時
                '------------------------------
                If pMode = True Then
                    If GF_Msg("", "メニュー【 " & objPNode.Text & " 】はジャンル未登録又は、有効なボタンがないため、保存されません" & vbCrLf & "よろしいですか？", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.No Then
                        LF_ChkMenuEnabled = CNL1920.FuncResult.CancelEnd
                        Exit Function
                    End If
                Else
                    '------------------------------
                    ' 無効メニューを削除する
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
        ' 返却値設定
        '------------------------------
        LF_ChkMenuEnabled = CNL1920.FuncResult.NormalEnd

    End Function


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
        lsv_MenuGrp.AllowDrop = True
        lsv_ItemGrp.AllowDrop = True
        Call GS_StatusSetup(stb_Msg)                                        ' ステータスバー初期化
        trv_Menu.Nodes.Clear()                                              ' メニューツリービュー初期化
        lsv_MenuGrp.Items.Clear()                                           ' メニューグループ・商品グループ一覧初期化
        txt_MenuTitle.Text = ""
        lsv_ItemGrp.Items.Clear()
        lst_MenuGrp.Items.Clear()
        L_ProcFlg = False                                                   ' 処理中フラグ(イベント発生回避フラグ)
        L_ProcFlg2 = False

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

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_Initialize")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニュー一覧取得処理(未使用)
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

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM060_1 = False

        '------------------------------
        ' メニューグループマスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM060.MENUID, TPM060.MENUNM"
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " GROUP BY TPM060.MENUID, TPM060.MENUNM"
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
    ' 　機　　能：商品グループ一覧取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    ' Private Function LF_GetTPM020_1(ByVal pMenuID As String, ByRef pDataSet As DataSet) As Boolean
    Private Function LF_GetTPM020_1(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByRef pDataSet As DataSet) As Boolean

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
        ' メニューグループマスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM020.GROUPCD,"
        strSQL = strSQL & "       TPM020.GROUPNM,"
        strSQL = strSQL & "       TPM020.PRICEDISP"
        strSQL = strSQL & "  FROM TPM020"
        strSQL = strSQL & " WHERE TPM020.GROUPCD NOT IN (SELECT GROUPCD"
        strSQL = strSQL & "                                FROM TPM060"
        strSQL = strSQL & "                               WHERE MENUID    = '" & pMenuID & "'"
        ' --- (2003.11.20) MENUGRPID を条件に追加する ---
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
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM020_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューグループ取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM060_2(ByRef pDataSet As DataSet) As Boolean

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
        strSQL = strSQL & "SELECT TPM060.MENUID,"
        strSQL = strSQL & "       TPM060.MENUNM,"
        strSQL = strSQL & "       TPM060.MENUGRPID,"
        strSQL = strSQL & "       TPM060.MENUGRPNM,"
        strSQL = strSQL & "       TPM060.ENABLED"
        '--- (2006.02.13) メニュー切り替え対応 ----------------------------------
        'strSQL = strSQL & ",      TPM060.MENUUSE"
        '------------------------------------------------------------------------
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " WHERE TPM060.GROUPCD = '" & GC_DUMMY_GROUPCD & "'"
        strSQL = strSQL & " GROUP BY TPM060.MENUID,"
        strSQL = strSQL & "          TPM060.MENUNM,"
        strSQL = strSQL & "          TPM060.MENUGRPID,"
        strSQL = strSQL & "          TPM060.MENUGRPNM,"
        strSQL = strSQL & "          TPM060.ENABLED"
        '--- (2006.02.13) メニュー切り替え対応 ----------------------------------
        'strSQL = strSQL & ",      TPM060.MENUUSE"
        '------------------------------------------------------------------------
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
    ' 　機　　能：メニューグループ内商品グループ一覧取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM060_3(ByVal pMenuID As String, ByVal pMenuGrpID As String, ByRef pDataSet As DataSet) As Boolean

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
        '        strSQL = strSQL & " ORDER BY TPM060.DISPORDER"             '2005.10.08 障害修正
        strSQL = strSQL & " ORDER BY CONVERT(INT,TPM060.DISPORDER)"
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
    ' 　機　　能：メニューグループ内商品グループ一覧取得処理
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
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM060_4 = True

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
        Dim strBKey As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        trv_Menu.Nodes.Clear()                                              ' メニューツリービュー初期化
        lst_TreeKey.Items.Clear()                                           ' 隠しキー保持リスト初期化
        txt_MenuTitle.Clear()

        '------------------------------
        ' メニューツリー生成処理
        '------------------------------
        If Not LF_GetTPM060_2(dtsData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            L_ProcFlg = True                                                    ' イベント発生回避フラグＯＮ
            lngCnt = 0
            strBKey = ""
            While lngCnt < dtsData.Tables("com").Rows.Count
                If Not GF_GetRows(dtsData, lngCnt, dtrData) Then
                    GoTo SYSTEM_ERROR
                End If

                '------------------------------
                ' 親ノード追加
                '------------------------------
                If strBKey <> Trim$(dtrData("MENUID")) Then
                    objNode = trv_Menu.Nodes.Add(Trim$(dtrData("MENUNM")))
                    '--- (2006.02.13) メニュー切り替え対応 -----------------------
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
                ' 子ノード追加
                '------------------------------
                objCNode = objNode.Nodes.Add(Trim$(dtrData("MENUGRPNM")))
                objCNode.Checked = IIf(Trim$(dtrData("ENABLED")) = GC_TRUE, True, False)
                lst_TreeKey.Items.Add("C" & _
                                      Format$(objNode.Index, "00000") & _
                                      Format$(objCNode.Index, "00000") & _
                                      vbTab & _
                                      Trim$(dtrData("MENUGRPID")))              ' 隠し項目のキー値追加

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
    ' 　機　　能：メニューグループＩＤ取得
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
            lsv_MenuGrp.Items.Clear()
            lsv_ItemGrp.Items.Clear()
            chk_Price.Checked = False
            chk_ShowGenr.Checked = False
            cbo_Pat.SelectedIndex = 0
            cbo_Style.SelectedIndex = 0

            L_MenuGrpID = LF_GetMenuGrpCD(e.Node)       '-- (2006.01.27) メニュー画像作成画面へのパラメタ
            L_MenuID = LF_GetMenuGrpCD(trv_Menu.SelectedNode.Parent)

            If Not IsNothing(e.Node.Parent) Then
                chk_Price.Enabled = True
                chk_ShowGenr.Enabled = True
                cbo_Pat.Enabled = True
                cbo_Style.Enabled = True
                '--- (2006.01.31) メニュー画像作成 -------------------------------------------
                btn_MenuPic.Enabled = True
                LF_SetCbo_Pat(LF_GetMenuGrpCD(e.Node.Parent), LF_GetMenuGrpCD(e.Node))
                Call LS_SetMenuGrp(LF_GetMenuGrpCD(e.Node.Parent), _
                                   LF_GetMenuGrpCD(e.Node))                     ' [選択後]商品グループ一覧 生成
                Call LS_SetItemGrp(LF_GetMenuGrpCD(e.Node.Parent), _
                                   LF_GetMenuGrpCD(e.Node))                     ' [選択元]商品グループ一覧 生成
                '-----------------------------------------------------------------------------
                '--- (2006.02.10) 定額メニュー ---------------------------
                'chk_Teigaku.Enabled = True
                'If LF_GetPriceType(LF_GetMenuGrpCD(e.Node.Parent), LF_GetMenuGrpCD(e.Node)) <> "0" Then
                '    chk_Teigaku.Checked = True
                '    txt_Price.Enabled = True
                '    txt_Price.Text = LF_GetPrice(LF_GetGoodsCD) & "円"
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
                '--- (2006.01.31) メニュー画像作成ボタン
                btn_MenuPic.Enabled = False
                '--- (2006.02.10) 定額メニュー
                'chk_Teigaku.Enabled = False
                'txt_Price.Text = ""
                'txt_Price.Enabled = False
                '-----------------------------
            End If
            txt_MenuTitle.Text = e.Node.Text
            L_ProcFlg2 = False
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
        Call GS_ErrorTerm("trv_Menu_AfterSelect")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループ一覧設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    ' Private Sub LS_SetItemGrp(ByVal pMenuID As String)
    Private Sub LS_SetItemGrp(ByVal pMenuID As String, ByVal pMenuGrpID As String)
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
            lsv_ItemGrp.Items.Clear()

            '------------------------------
            ' 商品グループ一覧設定
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
    ' 　機　　能：メニュー内商品グループリスト設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetMenuGrp(ByVal pMenuID As String, ByVal pMenuGrpID As String)

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
        lst_MenuGrp.Items.Clear()                                           ' 隠し項目初期クリア

        '------------------------------
        ' 商品グループ一覧取得
        '------------------------------
        If Not LF_GetTPM060_3(pMenuID, pMenuGrpID, dtsData) Then
            GoTo SYSTEM_ERROR
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
                strWork = Trim$(dtrData("GROUPNM")) & vbTab & _
                          Trim$(dtrData("GROUPCD")) & vbTab & _
                          Trim$(dtrData("PRICEDISP"))
                lst_MenuGrp.Items.Add(strWork)

                lngCnt = lngCnt + 1
            End While
            Call LS_SetMenuGrpFromHide()

            '------------------------------
            ' チェックボックスの設定
            '------------------------------
            dtsData = New DataSet()
            If LF_GetTPM060_4(pMenuID, pMenuGrpID, dtsData) = False Then
                GoTo SYSTEM_ERROR
            End If
            If dtsData.Tables("com").Rows.Count <> 0 Then
                If Not GF_GetRows(dtsData, 0, dtrData) Then
                    GoTo SYSTEM_ERROR
                End If

                ' --- (2004.02.06) 処理方式変更 ----------------------------
                'Select Case Trim$(dtrData("MENUSTYLE"))
                '    Case GC_MSTYLE_LISTSTR
                '        rdo_Pat1.Checked = True
                '        rdo_Pat2.Checked = False
                '        rdo_Pat3.Checked = False
                '        rdo_Pat4.Checked = False
                '        rdo_Pat5.Checked = False                            ' --- (2004.02.04) ネタケース対応 ---
                '        chk_Price.Enabled = True
                '        chk_ShowGenr.Enabled = True
                '    Case GC_MSTYLE_LISTPIC
                '        rdo_Pat1.Checked = False
                '        rdo_Pat2.Checked = True
                '        rdo_Pat3.Checked = False
                '        rdo_Pat4.Checked = False
                '        rdo_Pat5.Checked = False                            ' --- (2004.02.04) ネタケース対応 ---
                '        chk_Price.Enabled = True
                '        chk_ShowGenr.Enabled = True
                '    Case GC_MSTYLE_NOLIST
                '        rdo_Pat1.Checked = False
                '        rdo_Pat2.Checked = False
                '        rdo_Pat3.Checked = False
                '        rdo_Pat4.Checked = True
                '        rdo_Pat5.Checked = False                            ' --- (2004.02.04) ネタケース対応 ---
                '        chk_Price.Enabled = False
                '        chk_ShowGenr.Enabled = False
                '    Case GC_MSTYLE_NOLISTSTR
                '        rdo_Pat1.Checked = False
                '        rdo_Pat2.Checked = False
                '        rdo_Pat3.Checked = True
                '        rdo_Pat4.Checked = False
                '        rdo_Pat5.Checked = False                            ' --- (2004.02.04) ネタケース対応 ---
                '        chk_Price.Enabled = False
                '        chk_ShowGenr.Enabled = False
                '    Case GC_MSTYLE_NETACASE
                '        ' --- (2004.02.04) ネタケース対応 ------------------
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

                        '--- (2006.01.31) メニュー画像追加 -----------------------
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

                '--- (2006.02.08) メニュー画像追加 --------------------------------------------
                ' 「メニュー画像表示」の場合、各チェックBOXは使えない
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
    ' 　機　　能：メニュー内商品グループリスト設定（隠し項目より表示域へ反映）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
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

    ' --------------------------------------------------------------------------------
    ' 　機　　能：(選択済)商品グループ一覧 ドラッグ開始時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
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

    ' --------------------------------------------------------------------------------
    ' 　機　　能：(選択済)商品グループ一覧 ドラッグ中処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
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

    ' --------------------------------------------------------------------------------
    ' 　機　　能：(選択済)商品グループ一覧 ドラッグ中処理
    ' 　機能概要：既存アイテム上にドラッグした際、当該アイテムを選択状態にする
    '             (動作を WindowsExplorer にあわせる)
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
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

    ' --------------------------------------------------------------------------------
    ' 　機　　能：(ＤＢ更新契機)[選択済]商品グループ一覧 ドロップ時処理
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
                    '--- (2006.02.13) メニュー切り替え対応 --------------------------------------------
                    '.PRICETYPE = IIf(chk_Teigaku.Checked, "1", "0")
                    '.MENUUSE = IIf(trv_Menu.SelectedNode.Parent.Checked, "0", "1")
                    '----------------------------------------------------------------------------------
                End With
                Call LF_GetChkStatus(udtUpdVal)                             ' チェック状態取得
                If Not LF_UpdTPM060_3(udtUpdVal, udtUpdKey, True) Then
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
                        .MENUID = LF_GetMenuGrpCD(trv_Menu.SelectedNode.Parent)
                        .MENUGRPID = LF_GetMenuGrpCD(trv_Menu.SelectedNode)
                        .GROUPCD = lsv_MenuGrp.Items(lngCnt).Tag
                    End With
                    If Not LF_UpdTPM060_5(udtUpdVal, udtUpdKey) Then
                        GoTo SYSTEM_ERROR
                    End If
                Next

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

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループ一覧 ドラッグ開始時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_ItemGrp_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_ItemGrp.ItemDrag
        L_DragMode = LC_COPYMODE
        lsv_ItemGrp.DoDragDrop(e.Item, DragDropEffects.Copy)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループ一覧 ドラッグ中処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_ItemGrp_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemGrp.DragEnter
        If (e.Data.GetDataPresent(GetType(ListViewItem))) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループ一覧 ドロップ時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_ItemGrp_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemGrp.DragDrop

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
                              objSrcItem.Tag & vbTab & _
                              objSrcItem.SubItems(1).Text
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

        If IsNothing(trv_Menu.SelectedNode) Then Exit Sub
        If txt_MenuTitle.Modified = False Then Exit Sub

        ' --- (2003.12.08) 半角文字を入力制限した ---
        Dim lngST As Long
        lngST = txt_MenuTitle.SelectionStart
            ' 2014-05-12 2バイト文字制限解除
        'txt_MenuTitle.Text = StrConv(txt_MenuTitle.Text, VbStrConv.Wide)
        If lngST >= 0 Then txt_MenuTitle.SelectionStart = lngST
        ' -------------------------------------------

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
            ' --- (2003.12.02) 入力長制限の変更 ----------------------------
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
        ' ＤＢへの入力値反映(更新)
        '------------------------------
        If IsNothing(objNode.Parent) Then                                   ' 親ノード名称変更
            udtUpdKey.MENUID = LF_GetMenuGrpCD(objNode)
            udtUpdVal.MENUNM = GF_RepQuo(Trim$(txt_MenuTitle.Text))
        Else                                                                ' 子ノード名称変更
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
    ' 　機　　能：ツールバー押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub tlb_Btn_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlb_Btn.ButtonClick

        '------------------------------
        ' 内部変数定義
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
                ' 何もしない
            Case Else
                GoTo SYSTEM_ERROR
        End Select
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("tlb_Btn_ButtonClick")
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
            If GF_Msg("A01", "", MsgBoxStyle.YesNo, MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                strSQL = ""
                strSQL = strSQL & "DELETE FROM TPM060"
                strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"
                If Not GF_UpdData(strSQL) Then
                    Exit Function
                End If

                '--- (2006.02.08) メニュー画像用テーブルも ------------------------------------------
                strSQL = ""
                strSQL = strSQL & "DELETE FROM TPM150"
                strSQL = strSQL & " WHERE MENUID = '" & strMenuID & "'"
                If Not GF_UpdData(strSQL) Then
                    Exit Function
                End If
                '------------------------------------------------------------------------------------

                '--- (2006.02.13) メニュー切り替え対応　紐付く商品コード情報も消す-------------------
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

        '------------------------------
        ' イベント発生回避フラグ確認
        '------------------------------
        If L_ProcFlg Then Exit Sub
        If IsNothing(e.Node.Parent) Then Exit Sub

        '------------------------------
        ' メニュー使用可否更新処理
        '------------------------------
        Try
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
        If L_ProcFlg Then Exit Sub

        '--- (2006.02.13) メニュー切り替え対応 -------------------  2006.06.28 修正
        If IsNothing(e.Node.Parent) Then
            e.Cancel = True
        End If
        '---------------------------------------------------------

    End Sub

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

        '------------------------------
        ' 初期値設定
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
        ' 返却値設定
        '------------------------------
        LF_UpdTPM060_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：TPM060(メニューグループマスタ)更新処理 - (１)
    ' 　機能概要：メニューの使用可否(MENUUSE項目)について、更新を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2006.02.13 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM060_1_1(ByVal pMenuUse As String, ByVal pMenuID As String) As Boolean

        ''------------------------------
        '' 内部変数定義
        ''------------------------------
        'Dim strSQL As String

        ''------------------------------
        '' 初期値設定
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
        '' 返却値設定
        ''------------------------------
        LF_UpdTPM060_1_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：TPM060(メニューグループマスタ)更新処理 - (２)
    ' 　機能概要：メニュー及びメニューグループの名称項目について、更新を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM060_2(ByVal pUpdVal As typTPM060, ByVal pUpdKey As typTPM060) As Boolean

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
            Exit Function
        End If
        L_EditFlg = True

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM060_2 = True

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
        '--- (2006.02.01) メニュー画像追加 --------------------
        Dim strSQL2 As String
        Dim objData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM060_3 = False
        strSQL = ""

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
        Else
            strSQL = strSQL & "DELETE FROM TPM060"
            strSQL = strSQL & "      WHERE TPM060.MENUID    = '" & pUpdKey.MENUID & "'"
            strSQL = strSQL & "        AND TPM060.MENUGRPID = '" & pUpdKey.MENUGRPID & "'"
            strSQL = strSQL & "        AND TPM060.GROUPCD   = '" & pUpdKey.GROUPCD & "'"

            '--- (2006.02.01) メニュー画像追加 ----------------------------------------------------
            ' ジャンルが解除されたら、メニュー画像のわりつけも解除する
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

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM060_4 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM060"
        strSQL = strSQL & "   SET TPM060.MENUSTYLE = '" & pUpdVal.MENUSTYLE & "',"
        strSQL = strSQL & "       TPM060.GROUPKBN  = '" & pUpdVal.GROUPKBN & "',"
        '--- (2006.02.10) 定額メニュー -----------------------------------------------------------
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
        ' 返却値設定
        '------------------------------
        LF_UpdTPM060_4 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：TPM060(メニューグループマスタ)更新処理 - (５)
    ' 　機能概要：メニューグループの使用可否(ENABLED項目)について、更新を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM060_5(ByVal pUpdVal As typTPM060, ByVal pUpdKey As typTPM060) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
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
        ' 返却値設定
        '------------------------------
        LF_UpdTPM060_5 = True

    End Function

    Private Function LF_UpdTPM010(ByVal pMenuID As String, ByVal pMenuGrpID As String) As Boolean

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
        ' 返却値設定
        '------------------------------
        LF_UpdTPM010 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループ表示/非表示チェック変更時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
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
        ' 内部変数定義
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

        ' 画像生成フラグの更新を行う(2004.07.14)
        If Not LF_UpdTPM010(udtUpdKey.MENUID, udtUpdKey.MENUGRPID) Then
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

                        '--- (2006.01.31) メニュー画像追加 ------------------------
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
        ' 内部変数定義
        '------------------------------
        Dim objForm As New CNL1710()
        Dim i As Integer

        '------------------------------
        ' メニュー画像作成画面表示
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

        '--- メニュー画像が存在するかチェック -----------------------------

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
        Call GS_CboItemSet(cbo_Pat, "商品ジャンルを表示", LC_PAT_GENR)
        Call GS_CboItemSet(cbo_Pat, "ネタケースを表示", LC_PAT_NETA)
        Call GS_CboItemSet(cbo_Pat, "商品一覧を直接表示", LC_PAT_DIRC)
        If objData.Tables("com").Rows.Count > 0 Then
            Call GS_CboItemSet(cbo_Pat, "メニュー画像を表示", "3")
        End If
        Call GS_CboChgSel(cbo_Pat, Trim$(pstrCode))


    End Function

    Private Function LF_GetPriceType(ByVal pMenuID As String, ByVal pMenuGrpID As String) As String
        '--- (2006.02.10) 定額メニュー ---------------------------------

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
    '        txt_Price.Text = "0円"
    '        txt_Price.Enabled = True
    '    Else
    '        txt_Price.Text = ""
    '        txt_Price.Enabled = False
    '    End If

    'End Sub

    'Private Sub txt_Price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    ' 数値のみ６桁まで入力可能とする制御を入れる

    '    '------------------------------
    '    ' 内部変数定義
    '    '------------------------------
    '    Dim lngST As Long

    '    If txt_Price.Modified = False Then Exit Sub
    '    lngST = txt_Price.SelectionStart
    '    If lngST >= 0 Then txt_Price.SelectionStart = lngST

    '    '------------------------------
    '    ' 入力長制限
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

    '    ' カンマ及び、"円"文字を長さ０の文字列にReplaceする
    '    txt_Price.Text = Replace(txt_Price.Text, ",", "")
    '    txt_Price.Text = Replace(txt_Price.Text, "円", "")

    'End Sub

    'Private Sub txt_Price_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim strSQL As String

    '    If IsNumeric(Trim$(txt_Price.Text)) = False Then
    '        MsgBox("金額は数字のみを入力してください", MsgBoxStyle.OKOnly)
    '        Exit Sub
    '    End If

    '    strSQL = ""
    '    strSQL = strSQL & "UPDATE TPM010"
    '    strSQL = strSQL & "   SET PRICE = " & Trim$(txt_Price.Text)
    '    strSQL = strSQL & " WHERE GOODSCD = '" & LF_GetGoodsCD() & "'"

    '    If Not GF_UpdData(strSQL) Then
    '        Exit Sub
    '    End If

    '    ' カンマ編集＋"円"文字の付加編集を行う
    '    txt_Price.Text = Format$(CLng(Trim$(txt_Price.Text)), "###,##0") & "円"

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
