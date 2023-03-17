' --------------------------------------------------------------------------------
' 　機　　能：店舗内情報システム - サーバメンテナンス(商品グループ登録画面)
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
' --------------------------------------------------------------------------------
Public Class CNL1540
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
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents lsv_Group As System.Windows.Forms.ListView
    Friend WithEvents tlb_Btn As System.Windows.Forms.ToolBar
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents sts_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents btn_SelImg As System.Windows.Forms.Button
    Friend WithEvents cbo_Sort As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lsv_ItemGrp As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsv_ItemList As System.Windows.Forms.ListView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_GrpInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_GrpNM As System.Windows.Forms.TextBox
    Friend WithEvents pic_GrpImg As System.Windows.Forms.PictureBox
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList3 As System.Windows.Forms.ImageList
    Friend WithEvents tlb_Btn2 As System.Windows.Forms.ToolBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList4 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlb_Move As System.Windows.Forms.ToolBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_Bumon As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents chk_SPFLG As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CNL1540))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"aaa", "a2", "a3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"bbb"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ccc"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Me.sts_Msg = New System.Windows.Forms.StatusBar
        Me.lsv_Group = New System.Windows.Forms.ListView
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.tlb_Btn = New System.Windows.Forms.ToolBar
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.btn_SelImg = New System.Windows.Forms.Button
        Me.cbo_Sort = New System.Windows.Forms.ComboBox
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_Search = New System.Windows.Forms.TextBox
        Me.cbo_Bumon = New System.Windows.Forms.ComboBox
        Me.tlb_Move = New System.Windows.Forms.ToolBar
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton
        Me.ImageList4 = New System.Windows.Forms.ImageList(Me.components)
        Me.tlb_Btn2 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chk_SPFLG = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txt_GrpNM = New System.Windows.Forms.TextBox
        Me.txt_GrpInfo = New System.Windows.Forms.TextBox
        Me.pic_GrpImg = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lsv_ItemList = New System.Windows.Forms.ListView
        Me.lsv_ItemGrp = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic_GrpImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sts_Msg
        '
        Me.sts_Msg.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.sts_Msg.Location = New System.Drawing.Point(0, 667)
        Me.sts_Msg.Name = "sts_Msg"
        Me.sts_Msg.ShowPanels = True
        Me.sts_Msg.Size = New System.Drawing.Size(1016, 24)
        Me.sts_Msg.TabIndex = 194
        Me.sts_Msg.Text = "StatusBar1"
        '
        'lsv_Group
        '
        Me.lsv_Group.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_Group.LargeImageList = Me.ImageList2
        Me.lsv_Group.Location = New System.Drawing.Point(8, 56)
        Me.lsv_Group.MultiSelect = False
        Me.lsv_Group.Name = "lsv_Group"
        Me.lsv_Group.Size = New System.Drawing.Size(496, 168)
        Me.lsv_Group.TabIndex = 1
        Me.lsv_Group.UseCompatibleStateImageBehavior = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        '
        'tlb_Btn
        '
        Me.tlb_Btn.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton3})
        Me.tlb_Btn.ButtonSize = New System.Drawing.Size(248, 45)
        Me.tlb_Btn.Divider = False
        Me.tlb_Btn.Dock = System.Windows.Forms.DockStyle.None
        Me.tlb_Btn.DropDownArrows = True
        Me.tlb_Btn.ImageList = Me.ImageList1
        Me.tlb_Btn.Location = New System.Drawing.Point(8, 8)
        Me.tlb_Btn.Name = "tlb_Btn"
        Me.tlb_Btn.ShowToolTips = True
        Me.tlb_Btn.Size = New System.Drawing.Size(496, 42)
        Me.tlb_Btn.TabIndex = 0
        Me.tlb_Btn.TabStop = True
        Me.tlb_Btn.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 0
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Text = "新しいジャンルを追加する"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 2
        Me.ToolBarButton3.Name = "ToolBarButton3"
        Me.ToolBarButton3.Text = "ジャンルを削除する"
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
        Me.MenuItem1.Text = "グループからこの商品を外す"
        '
        'btn_SelImg
        '
        Me.btn_SelImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_SelImg.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_SelImg.Location = New System.Drawing.Point(384, 24)
        Me.btn_SelImg.Name = "btn_SelImg"
        Me.btn_SelImg.Size = New System.Drawing.Size(48, 24)
        Me.btn_SelImg.TabIndex = 4
        Me.btn_SelImg.Text = "選択"
        '
        'cbo_Sort
        '
        Me.cbo_Sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Sort.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_Sort.Location = New System.Drawing.Point(752, 280)
        Me.cbo_Sort.Name = "cbo_Sort"
        Me.cbo_Sort.Size = New System.Drawing.Size(192, 23)
        Me.cbo_Sort.TabIndex = 8
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem4})
        Me.MenuItem2.Text = "ファイル(&F)"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "保存(&S)"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "終了(&E)"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txt_Search)
        Me.Panel1.Controls.Add(Me.cbo_Bumon)
        Me.Panel1.Controls.Add(Me.tlb_Move)
        Me.Panel1.Controls.Add(Me.tlb_Btn2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lsv_ItemList)
        Me.Panel1.Controls.Add(Me.lsv_ItemGrp)
        Me.Panel1.Controls.Add(Me.cbo_Sort)
        Me.Panel1.Controls.Add(Me.tlb_Btn)
        Me.Panel1.Controls.Add(Me.lsv_Group)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 232
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.Location = New System.Drawing.Point(952, 280)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 24)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "クリア"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(680, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 24)
        Me.Label7.TabIndex = 244
        Me.Label7.Text = "品名検索"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(680, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 242
        Me.Label6.Text = "登録部門"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(752, 232)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(192, 22)
        Me.txt_Search.TabIndex = 6
        Me.txt_Search.Text = "TextBox1"
        '
        'cbo_Bumon
        '
        Me.cbo_Bumon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Bumon.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_Bumon.Location = New System.Drawing.Point(752, 256)
        Me.cbo_Bumon.Name = "cbo_Bumon"
        Me.cbo_Bumon.Size = New System.Drawing.Size(192, 23)
        Me.cbo_Bumon.TabIndex = 7
        '
        'tlb_Move
        '
        Me.tlb_Move.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton6, Me.ToolBarButton7})
        Me.tlb_Move.Divider = False
        Me.tlb_Move.Dock = System.Windows.Forms.DockStyle.None
        Me.tlb_Move.DropDownArrows = True
        Me.tlb_Move.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tlb_Move.ImageList = Me.ImageList4
        Me.tlb_Move.Location = New System.Drawing.Point(256, 224)
        Me.tlb_Move.Name = "tlb_Move"
        Me.tlb_Move.ShowToolTips = True
        Me.tlb_Move.Size = New System.Drawing.Size(200, 34)
        Me.tlb_Move.TabIndex = 3
        Me.tlb_Move.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 0
        Me.ToolBarButton6.Name = "ToolBarButton6"
        Me.ToolBarButton6.Text = "上へ移動"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.ImageIndex = 1
        Me.ToolBarButton7.Name = "ToolBarButton7"
        Me.ToolBarButton7.Text = "下へ移動"
        '
        'ImageList4
        '
        Me.ImageList4.ImageStream = CType(resources.GetObject("ImageList4.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList4.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList4.Images.SetKeyName(0, "")
        Me.ImageList4.Images.SetKeyName(1, "")
        '
        'tlb_Btn2
        '
        Me.tlb_Btn2.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton4, Me.ToolBarButton2, Me.ToolBarButton5})
        Me.tlb_Btn2.ButtonSize = New System.Drawing.Size(97, 60)
        Me.tlb_Btn2.Divider = False
        Me.tlb_Btn2.Dock = System.Windows.Forms.DockStyle.None
        Me.tlb_Btn2.DropDownArrows = True
        Me.tlb_Btn2.ImageList = Me.ImageList3
        Me.tlb_Btn2.Location = New System.Drawing.Point(460, 368)
        Me.tlb_Btn2.Name = "tlb_Btn2"
        Me.tlb_Btn2.ShowToolTips = True
        Me.tlb_Btn2.Size = New System.Drawing.Size(96, 157)
        Me.tlb_Btn2.TabIndex = 11
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 1
        Me.ToolBarButton4.Name = "ToolBarButton4"
        Me.ToolBarButton4.Text = "ジャンルへ追加"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 0
        Me.ToolBarButton2.Name = "ToolBarButton2"
        Me.ToolBarButton2.Text = "ジャンルから削除"
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.ImageIndex = 2
        Me.ToolBarButton5.Name = "ToolBarButton5"
        Me.ToolBarButton5.Text = "全て解除する"
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList3.Images.SetKeyName(0, "")
        Me.ImageList3.Images.SetKeyName(1, "")
        Me.ImageList3.Images.SetKeyName(2, "")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_SPFLG)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_GrpNM)
        Me.GroupBox1.Controls.Add(Me.txt_GrpInfo)
        Me.GroupBox1.Controls.Add(Me.pic_GrpImg)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_SelImg)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(512, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 216)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ジャンル情報設定"
        '
        'chk_SPFLG
        '
        Me.chk_SPFLG.Location = New System.Drawing.Point(128, 187)
        Me.chk_SPFLG.Name = "chk_SPFLG"
        Me.chk_SPFLG.Size = New System.Drawing.Size(144, 24)
        Me.chk_SPFLG.TabIndex = 3
        Me.chk_SPFLG.Text = "「おすすめ」ジャンル"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(440, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "解除"
        '
        'txt_GrpNM
        '
        Me.txt_GrpNM.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_GrpNM.Location = New System.Drawing.Point(16, 48)
        Me.txt_GrpNM.Name = "txt_GrpNM"
        Me.txt_GrpNM.Size = New System.Drawing.Size(248, 22)
        Me.txt_GrpNM.TabIndex = 1
        '
        'txt_GrpInfo
        '
        Me.txt_GrpInfo.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_GrpInfo.Location = New System.Drawing.Point(16, 96)
        Me.txt_GrpInfo.Multiline = True
        Me.txt_GrpInfo.Name = "txt_GrpInfo"
        Me.txt_GrpInfo.Size = New System.Drawing.Size(248, 88)
        Me.txt_GrpInfo.TabIndex = 2
        '
        'pic_GrpImg
        '
        Me.pic_GrpImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_GrpImg.Location = New System.Drawing.Point(275, 48)
        Me.pic_GrpImg.Name = "pic_GrpImg"
        Me.pic_GrpImg.Size = New System.Drawing.Size(213, 160)
        Me.pic_GrpImg.TabIndex = 246
        Me.pic_GrpImg.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 22)
        Me.Label2.TabIndex = 247
        Me.Label2.Text = "ジャンル画像"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 22)
        Me.Label14.TabIndex = 245
        Me.Label14.Text = "紹介文"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 22)
        Me.Label1.TabIndex = 244
        Me.Label1.Text = "ジャンル名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(560, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 235
        Me.Label5.Text = "■ 商品一覧"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 16)
        Me.Label3.TabIndex = 234
        Me.Label3.Text = "■ 登録済みジャンル"
        '
        'lsv_ItemList
        '
        Me.lsv_ItemList.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_ItemList.Location = New System.Drawing.Point(560, 304)
        Me.lsv_ItemList.Name = "lsv_ItemList"
        Me.lsv_ItemList.Size = New System.Drawing.Size(448, 352)
        Me.lsv_ItemList.TabIndex = 10
        Me.lsv_ItemList.UseCompatibleStateImageBehavior = False
        Me.lsv_ItemList.View = System.Windows.Forms.View.Details
        '
        'lsv_ItemGrp
        '
        Me.lsv_ItemGrp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lsv_ItemGrp.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ListViewItem1.StateImageIndex = 0
        ListViewItem1.UseItemStyleForSubItems = False
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.StateImageIndex = 0
        Me.lsv_ItemGrp.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.lsv_ItemGrp.Location = New System.Drawing.Point(8, 256)
        Me.lsv_ItemGrp.Name = "lsv_ItemGrp"
        Me.lsv_ItemGrp.Size = New System.Drawing.Size(448, 400)
        Me.lsv_ItemGrp.TabIndex = 4
        Me.lsv_ItemGrp.UseCompatibleStateImageBehavior = False
        Me.lsv_ItemGrp.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "あ"
        Me.ColumnHeader1.Width = 123
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 113
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Width = 135
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(680, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 24)
        Me.Label4.TabIndex = 239
        Me.Label4.Text = "表示条件"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CNL1540
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1016, 691)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.sts_Msg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL1540"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JCV03"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pic_GrpImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Structure typItemInfo
        Dim strGROUPCD As String
        Dim strGROUPINFO As String
        Dim strGROUPIMAGE As String
        Dim strPRICEDISP As String
        Dim blnSPFLG As Boolean                                             ' --- (2004.02.03) 「おすすめジャンル」追加 ---
    End Structure

    ' 商品一覧ソート順
    Private Const LC_SORT_UPDYMD As String = "0"
    Private Const LC_SORT_NOGROUP As String = "1"
    Private Const LC_SORT_PRICE As String = "2"
    Private Const LC_SORT_NOSORT As String = "3"
    ' --- (2003.12.01) 絞込み条件追加 --------------------------------------
    Private Const LC_SORT_BUMON As String = "4"
    Private Const LC_SORT_SEARCH As String = "5"
    ' ----------------------------------------------------------------------

    ' 更新区分
    Private Const LC_UPDKBN_ADD As String = "ADD"
    Private Const LC_UPDKBN_DEL As String = "DEL"

    ' 新規グループ追加時の標準値
    Private Const LC_DEF_GRPNMJ As String = "名称未設定"
    Private Const LC_DEF_GRPINFOJ As String = ""
    Private Const LC_DEF_GRPIMAGE As String = ""
    Private Const LC_DEF_GRPPRICE As String = GC_TRUE

    Private L_blnDMode As Boolean                                           ' True:追加操作 / False:削除操作
    Private L_blnEditFlg As Boolean
    Private L_blnProcFlg As Boolean                                         ' True:処理中 / False:入力待ち状態

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub CNL1540_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' フォーム名称設定
        '------------------------------
        Me.Text = GF_FormText()

        '------------------------------
        ' 初期化処理
        '------------------------------
        Call GS_StatusSetup(sts_Msg)
        Call LS_FormInit()

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            GoTo SYSTEM_ERROR
        End If
        L_blnEditFlg = False

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("TP1030_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：初期表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_FormInit(Optional ByVal pInitialClear As Boolean = True)

        Try
            '------------------------------
            ' 初期化処理
            '------------------------------
            If pInitialClear Then
                With lsv_Group
                    .Clear()
                    .HideSelection = False
                End With
            End If
            With lsv_ItemGrp
                .Clear()
                .FullRowSelect = True
                .AllowDrop = True
                .AllowColumnReorder = True
                .HideSelection = False
            End With

            txt_GrpNM.Clear()
            txt_GrpInfo.Clear()
            pic_GrpImg.SizeMode = PictureBoxSizeMode.StretchImage
            pic_GrpImg.Image = Nothing

            ' --- (2004.02.03) 「おすすめ」チェック追加 --------------------
            L_blnProcFlg = True
            chk_SPFLG.Checked = False
            L_blnProcFlg = False
            ' --------------------------------------------------------------

            If pInitialClear Then
                '------------------------------
                ' 商品一覧リスト
                '------------------------------
                With lsv_ItemList
                    .Clear()
                    .FullRowSelect = True
                    .AllowDrop = True
                    .AllowColumnReorder = True
                    .HideSelection = False
                End With

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

                txt_Search.Clear()

                '------------------------------
                ' グループ一覧生成
                '------------------------------
                Call LS_SetGrpList()

                Call LS_SetItemList2(GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex))
            End If

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_FormInit")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：部門検索コンボ表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
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

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループリスト表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetGrpList()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objItem As ListViewItem
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim udtItem() As typItemInfo

        '------------------------------
        ' 表示データ取得
        '------------------------------
        If Not LF_GetTPM020_1(objData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            ReDim udtItem(objData.Tables("com").Rows.Count)
            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    GoTo SYSTEM_ERROR
                End If

                With udtItem(lngCnt)
                    .strGROUPCD = Trim$(objRows("GROUPCD"))
                    .strGROUPINFO = Replace(Trim$(objRows("GROUPINFO")), "<BR>", vbCrLf)
                    .strGROUPIMAGE = Trim$(objRows("GROUPIMAGE"))
                    .strPRICEDISP = Trim$(objRows("PRICEDISP"))
                    ' --- (2004.02.03) 「おすすめジャンル」追加 ------------
                    .blnSPFLG = IIf(Trim$(objRows("SPFLG")) = GC_TRUE, True, False)
                    ' ------------------------------------------------------
                End With

                objItem = New ListViewItem()
                With objItem
                    .Text = Trim$(objRows("GROUPNM"))
                    .Tag = udtItem(lngCnt)
                    .ImageIndex = 0
                End With
                lsv_Group.Items.Add(objItem)

                lngCnt = lngCnt + 1
            End While
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetGrpList")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ取得処理(商品グループリスト表示向け処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM020_1(ByRef pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM020_1 = False

        '------------------------------
        ' 商品グループマスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM TPM020"
        strSQL = strSQL & " WHERE TPM020.GOODSCD = '0000'"
        strSQL = strSQL & "   AND TPM020.ENABLED = '" & GC_TRUE & "'"
        ' --- (2003.12.10) 並び順変更 --------------------------------------
        'strSQL = strSQL & " ORDER BY TPM020.GROUPCD"
        strSQL = strSQL & " ORDER BY TPM020.UPDYMD"
        ' ------------------------------------------------------------------
        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPM020_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ取得処理(グループ内商品一覧)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM020_2(ByVal pGroupCD As String, ByRef pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM020_2 = False

        '------------------------------
        ' 商品グループマスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM020.GOODSCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        ' --- (2003.12.01) 抽出対象外とする --------------------------------
        'strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        ' ------------------------------------------------------------------
        ' --- (2004.02.09) 品名２連結出力対応-------------------------------
        strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        ' ------------------------------------------------------------------
        strSQL = strSQL & "       TPM010.PRICE"
        strSQL = strSQL & "  FROM TPM010,"
        strSQL = strSQL & "       TPM020"
        strSQL = strSQL & " WHERE TPM020.GROUPCD  = '" & pGroupCD & "'"
        strSQL = strSQL & "   AND TPM020.GOODSCD <> '0000'"
        strSQL = strSQL & "   AND TPM020.ENABLED  = '" & GC_TRUE & "'"
        strSQL = strSQL & "   AND TPM020.GOODSCD  = TPM010.GOODSCD"
        strSQL = strSQL & " ORDER BY TPM020.DISPORDER"
        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPM020_2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ取得処理(グループ内商品一覧)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM010(ByVal pSortOption As String, ByRef pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM010 = False

        '------------------------------
        ' 商品マスタ取得
        '------------------------------
        strSQL = ""

        ' --- (2003.12.13) 抽出条件文生成処理 変更 -------------------------
        'strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        'strSQL = strSQL & "       TPM010.GOODSNMJ,"
        '' --- (2003.12.01) 抽出対象外とする --------------------------------
        ''strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        '' ------------------------------------------------------------------
        'strSQL = strSQL & "       TPM010.PRICE"
        'strSQL = strSQL & "  FROM TPM010"
        'Select Case pSortOption
        '    Case LC_SORT_UPDYMD
        '        strSQL = strSQL & " WHERE TPM010.STATUS = '0'"
        '        strSQL = strSQL & "   AND TPM010.GOODSKIND IN ('0', '1')"
        '        strSQL = strSQL & " ORDER BY TPM010.UPDYMD DESC, TPM010.GOODSCD"
        '    Case LC_SORT_NOGROUP
        '        strSQL = strSQL & " WHERE TPM010.GOODSCD NOT IN (SELECT TPM020.GOODSCD FROM TPM020 WHERE TPM020.GOODSCD <> '0000')"
        '        strSQL = strSQL & "   AND TPM010.STATUS = '0'"
        '        strSQL = strSQL & "   AND TPM010.GOODSKIND IN ('0', '1')"
        '        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"
        '    Case LC_SORT_PRICE
        '        strSQL = strSQL & " WHERE TPM010.STATUS = '0'"
        '        strSQL = strSQL & "   AND TPM010.GOODSKIND IN ('0', '1')"
        '        strSQL = strSQL & " ORDER BY TPM010.PRICE"
        '    Case LC_SORT_NOSORT
        '        strSQL = strSQL & " WHERE TPM010.STATUS = '0'"
        '        strSQL = strSQL & "   AND TPM010.GOODSKIND IN ('0', '1')"
        '        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

        '    Case LC_SORT_BUMON, LC_SORT_SEARCH
        '        ' --- (2003.12.01) 絞込み条件追加 --------------------------
        '        LF_GetTPM010 = True
        '        Exit Function
        '        ' ----------------------------------------------------------
        '    Case Else
        '        Exit Function
        'End Select
        strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        ' --- (2004.02.09) 品名２連結出力対応 ------------------------------
        strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        ' ------------------------------------------------------------------
        strSQL = strSQL & "       TPM010.PRICE"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " WHERE TPM010.STATUS = '0'"
        strSQL = strSQL & "   AND TPM010.GOODSKIND IN ('0', '1')"
        ''--- (2006.05.27) CrossNavi対応　タッチパネル用通常商品のみ表示 --------2006.06.28 削除
        'strSQL = strSQL & "   AND TPM010.GOODSCD >= '1000'"
        'strSQL = strSQL & "   AND TPM010.GOODSCD <= '3999'"
        ''-------------------------------------------------------------------
        If Len(Trim$(txt_Search.Text)) <> 0 Then
            strSQL = strSQL & "   AND TPM010.GOODSNMJ LIKE '%" & Trim$(txt_Search.Text) & "%'"
        End If
        If cbo_Bumon.SelectedIndex <> -1 And GF_CboGetCode(cbo_Bumon, cbo_Bumon.SelectedIndex) <> "@@" Then
            strSQL = strSQL & "   AND TPM010.BUMONCD = '" & GF_CboGetCode(cbo_Bumon, cbo_Bumon.SelectedIndex) & "'"
        End If
        Select Case pSortOption
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
                Exit Function
        End Select
        ' ------------------------------------------------------------------
        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPM010 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループリスト選択時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_Group_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Group.SelectedIndexChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim udtInfo As typItemInfo
        Dim objFile As System.IO.FileStream
        Dim strGrpImgPath As String
        Dim strDefImg As String

        '------------------------------
        ' 選択項目取得
        '------------------------------
        Try
            objCollection = lsv_Group.SelectedItems
            With objCollection
                If .Count = 0 Then
                    Call LS_FormInit(False)
                    Exit Sub
                End If
                If .Contains(.Item(0)) = False Then
                    Call LS_FormInit(False)
                    Exit Sub
                End If
                Me.Cursor = Cursors.WaitCursor

                '------------------------------
                ' グループ情報編集領域へ転記
                '------------------------------
                udtInfo = .Item(0).Tag
                txt_GrpNM.Text = .Item(0).Text
                txt_GrpInfo.Text = udtInfo.strGROUPINFO

                ' --- (2004.02.03) 「おすすめジャンル」追加 ----------------
                L_blnProcFlg = True
                chk_SPFLG.Checked = udtInfo.blnSPFLG
                L_blnProcFlg = False
                ' ----------------------------------------------------------

                If Len(Trim$(udtInfo.strGROUPIMAGE)) = 0 Then
                    strDefImg = GF_GetMaterial("S013JC")
                    If Len(Trim$(strDefImg)) = 0 Then
                        GoTo SYSTEM_ERROR
                    End If
                    strGrpImgPath = GF_GetAppInfo("MATERIAL_V") & "\" & Trim$(strDefImg)
                Else
                    strGrpImgPath = GF_GetAppInfo("GROUP_PATH") & "\" & udtInfo.strGROUPIMAGE
                End If

                If Len(Trim$(strGrpImgPath)) <> 0 Then
                    If System.IO.File.Exists(strGrpImgPath) = True Then
                        objFile = New System.IO.FileStream(strGrpImgPath, IO.FileMode.Open, IO.FileAccess.Read)
                        pic_GrpImg.Image = System.Drawing.Image.FromStream(objFile)
                        objFile.Close()
                    End If
                End If

                '------------------------------
                ' グループ内商品一覧生成
                '------------------------------
                Call LS_SetItemList(udtInfo.strGROUPCD)
                'Call LS_SetItemList2(GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex))
            End With
            Me.Cursor = Cursors.Default
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Me.Cursor = Cursors.Default
        Call GS_ErrorTerm("lsv_Group_SelectedIndexChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：グループ内商品一覧グリッド 表示値設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetItemList(ByVal pGroupCD As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim objItem As ListViewItem

        '------------------------------
        ' 設定データ取得
        '------------------------------
        If Not LF_GetTPM020_2(pGroupCD, objData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            '------------------------------
            ' メニューテーブルオープン
            '------------------------------
            lsv_ItemGrp.Clear()
            With lsv_ItemGrp.Columns
                .Add("商品コード", 90, HorizontalAlignment.Center)
                .Add("商品名", 262, HorizontalAlignment.Left)
                .Add("単価", 75, HorizontalAlignment.Right)
            End With

            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    Exit Sub
                End If

                objItem = New ListViewItem()
                objItem.Text = Trim$(objRows("GOODSCD")) & Space(6)        ' 後半のスペースは、マウス操作時の空振り防止対策
                ' --- (2003.12.01) 表示対象外とする --------------------------------
                'objItem.SubItems.Add(Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2")))
                ' --- (2004.02.09) 品名２連結出力対応 ----------------------
                'objItem.SubItems.Add(Trim$(objRows("GOODSNMJ")))
                objItem.SubItems.Add(Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2")))
                ' ----------------------------------------------------------
                ' ------------------------------------------------------------------
                objItem.SubItems.Add(Format$(CLng(Trim$(objRows("PRICE"))), "#,##0") & "円")
                lsv_ItemGrp.Items.Add(objItem)
                objItem = Nothing

                lngCnt = lngCnt + 1
            End While
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetItemList")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：グループ内商品一覧グリッド 表示値設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetItemList2(ByVal pSortOption As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim objItem As ListViewItem

        '------------------------------
        ' 設定データ取得
        '------------------------------
        If Not LF_GetTPM010(pSortOption, objData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            '------------------------------
            ' メニューテーブルオープン
            '------------------------------
            lsv_ItemList.Clear()
            With lsv_ItemList.Columns
                .Add("商品コード", 90, HorizontalAlignment.Center)
                .Add("商品名", 262, HorizontalAlignment.Left)
                .Add("単価", 75, HorizontalAlignment.Right)
            End With

            ' --- (2003.12.01) 絞込み条件追加に伴い、表示処理有無判定追加 --
            If Not IsNothing(objData.Tables("com")) Then
                lngCnt = 0
                While lngCnt < objData.Tables("com").Rows.Count
                    If Not GF_GetRows(objData, lngCnt, objRows) Then
                        Exit Sub
                    End If

                    objItem = New ListViewItem()
                    objItem.Text = Trim$(objRows("GOODSCD")) & Space(6)         ' 後半のスペースは、マウス操作時の空振り防止対策
                    ' --- (2003.12.01) 表示対象外とする --------------------------------
                    'objItem.SubItems.Add(Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2")))
                    ' --- (2004.02.09) 品名２連結出力対応 ------------------
                    'objItem.SubItems.Add(Trim$(objRows("GOODSNMJ")))
                    objItem.SubItems.Add(Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2")))
                    ' ------------------------------------------------------
                    ' ------------------------------------------------------------------
                    objItem.SubItems.Add(Format$(CLng(Trim$(objRows("PRICE"))), "#,##0") & "円")
                    lsv_ItemList.Items.Add(objItem)

                    lngCnt = lngCnt + 1
                End While
            End If
            ' --------------------------------------------------------------
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetItemList2")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品一覧グリッド ソート条件変更時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    'Private Sub cbo_Sort_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_Sort.SelectedValueChanged
    '    If lsv_Group.SelectedItems.Count = 0 Then Exit Sub
    '    Call LS_SetItemList2(GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex))
    'End Sub
    Private Sub cbo_Sort_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_Sort.SelectionChangeCommitted
        Call LS_SetItemList2(GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex))
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：表示条件コンボ変化時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' 　履　　歴：2003.12.13 廃止
    ' --------------------------------------------------------------------------------
    'Private Sub cbo_Sort_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_Sort.SelectedIndexChanged

    '    '------------------------------
    '    ' 部門コンボ有効化
    '    '------------------------------
    '    If GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex) = LC_SORT_BUMON Then
    '        cbo_Bumon.Enabled = True
    '    Else
    '        cbo_Bumon.Enabled = False
    '        cbo_Bumon.SelectedIndex = -1
    '    End If

    '    '------------------------------
    '    ' 品名テキストボックス有効化
    '    '------------------------------
    '    If GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex) = LC_SORT_SEARCH Then
    '        btn_Search.Enabled = True
    '        txt_Search.Enabled = True
    '    Else
    '        btn_Search.Enabled = False
    '        txt_Search.Enabled = False
    '        txt_Search.Clear()
    '    End If

    'End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：グループ追加／削除ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub tlb_Btn_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlb_Btn.ButtonClick

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objForm As New CNL1542()
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim udtInfo As typItemInfo

        Select Case e.Button.Text
            Case tlb_Btn.Buttons.Item(0).Text
                objForm.ShowDialog()
                If Len(Trim$(objForm.G_TP1032Ret)) <> 0 Then
                    If Not LF_UpdTPM020_1(LC_UPDKBN_ADD, "", Trim$(objForm.G_TP1032Ret)) Then
                        GoTo SYSTEM_ERROR
                    End If
                Else
                    Exit Sub
                End If

            Case tlb_Btn.Buttons.Item(1).Text
                '------------------------------
                ' 削除グループコード取得
                '------------------------------
                objCollection = lsv_Group.SelectedItems
                With objCollection
                    If .Count = 0 Then Exit Sub
                    If .Contains(.Item(0)) = False Then Exit Sub
                    udtInfo = .Item(0).Tag
                End With

                ' --- (2003.12.02) 削除時確認メッセージ追加 ----------------
                If GF_Msg("", Replace(GF_GetMsg("Q05"), "@@@", objCollection.Item(0).Text), MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.No Then
                    Exit Sub
                End If
                ' ----------------------------------------------------------

                ' --- (2003.12.03) メニューグループ削除確認処理追加 --------
                Select Case LF_ChkDelMenu(udtInfo.strGROUPCD, objCollection.Item(0).Text)
                    Case CNL1920.FuncResult.CancelEnd
                        Exit Sub
                    Case CNL1920.FuncResult.UnusualEnd
                        GoTo SYSTEM_ERROR
                End Select
                ' ----------------------------------------------------------

                If Not LF_UpdTPM020_1(LC_UPDKBN_DEL, udtInfo.strGROUPCD) Then
                    GoTo SYSTEM_ERROR
                End If

                ' --- (2003.12.03) メニューグループ削除処理追加 ------------
                If Not LF_UpdTPM060(udtInfo.strGROUPCD) Then
                    GoTo SYSTEM_ERROR
                End If
                ' ----------------------------------------------------------

        End Select


        '------------------------------
        ' グループ一覧生成
        '------------------------------
        Call LS_FormInit()

        'lsv_Group.Clear()
        'Call LS_SetGrpList()
        If e.Button.Text = tlb_Btn.Buttons.Item(0).Text Then
            lsv_Group.Items(lsv_Group.Items.Count - 1).Selected = True
            lsv_Group.EnsureVisible(lsv_Group.Items.Count - 1)
        End If

        L_blnEditFlg = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("tlb_Btn_ButtonClick")

    End Sub

    Private Function LF_UpdTPM060(ByVal pDelGenr As String) As Boolean

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
        LF_UpdTPM060 = False

        '------------------------------
        ' ジャンルを連鎖削除
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE FROM TPM060"
        strSQL = strSQL & " WHERE TPM060.GROUPCD = '" & pDelGenr & "'"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 無効化メニュー削除処理
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM060.MENUID, TPM060.MENUNM"
        strSQL = strSQL & "  FROM TPM060 LEFT JOIN (SELECT TPM060.MENUID FROM TPM060 WHERE TPM060.GROUPCD NOT IN ('J000') GROUP BY TPM060.MENUID) AS TPM060_2 ON TPM060.MENUID = TPM060_2.MENUID"
        strSQL = strSQL & " WHERE TPM060_2.MENUID IS NULL"
        strSQL = strSQL & "  GROUP BY TPM060.MENUID, TPM060.MENUNM"
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
            strSQL = strSQL & " WHERE TPM060.MENUID = '" & Trim$(objRows("MENUID")) & "'"
            If Not GF_UpdData(strSQL) Then
                Exit Function
            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM060 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューグループ連鎖削除確認処理
    ' 　機能概要：ジャンル削除により、連鎖的にメニューが無効化してしまう場合の確認処理
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.03 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_ChkDelMenu(ByVal pDelGenr As String, ByVal pDelGenrNm As String) As FuncResult

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
        strSQL = strSQL & "SELECT TPM060.MENUID, TPM060.MENUNM"
        strSQL = strSQL & "  FROM TPM060 LEFT JOIN (SELECT TPM060.MENUID FROM TPM060 WHERE TPM060.GROUPCD NOT IN ('J000', '" & pDelGenr & "') GROUP BY TPM060.MENUID) AS TPM060_2 ON TPM060.MENUID = TPM060_2.MENUID"
        strSQL = strSQL & " WHERE TPM060_2.MENUID IS NULL"
        strSQL = strSQL & "  GROUP BY TPM060.MENUID, TPM060.MENUNM"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If

            If GF_Msg("", "ジャンル【" & pDelGenrNm & "】を削除すると、以下のメニューが無効となり、削除されます。よろしいですか？" & vbCrLf & "削除対象メニュー：【" & Trim$(objRows("MENUNM")) & "】", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.No Then
                LF_ChkDelMenu = CNL1920.FuncResult.CancelEnd
                Exit Function
            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_ChkDelMenu = CNL1920.FuncResult.NormalEnd

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：保存ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        If Not GF_CommitTrans() Then
            GoTo SYSTEM_ERROR
        End If
        L_blnEditFlg = False

        If Not GF_BeginTrans() Then
            GoTo SYSTEM_ERROR
        End If
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("MenuItem3_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：閉じるボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォームクローズ時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub CNL1540_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        If L_blnEditFlg Then                                                ' 編集更新有無フラグ判定
            Select Case GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNoCancel)
                Case MsgBoxResult.Yes
                    If Not GF_CommitTrans() Then
                        GoTo SYSTEM_ERROR
                    End If
                    If Not LF_DelUnuseFile() Then
                        GoTo SYSTEM_ERROR
                    End If
                Case MsgBoxResult.No
                    If Not GF_RollbackTrans() Then
                        GoTo SYSTEM_ERROR
                    End If
                Case MsgBoxResult.Cancel
                    e.Cancel = True
                    Exit Sub
            End Select
        Else
            If Not GF_RollbackTrans() Then
                GoTo SYSTEM_ERROR
            End If
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("TP1030_Closing")
    End Sub

    ' ------------------------------------------------------------------------------------------------------------------------------------------
    ' --- ＤＢ更新処理  ------------------------------------------------------------------------------------------------------------------------
    ' ------------------------------------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ新規グループ番号採番処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM020_3(ByRef pGroupNo As String) As Boolean
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim lngWork As Long


        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM020_3 = False
        pGroupNo = ""

        '------------------------------
        ' グループ№空き番検索
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM020.GROUPCD"
        strSQL = strSQL & "  FROM TPM020"
        strSQL = strSQL & " WHERE TPM020.GOODSCD = '0000'"
        strSQL = strSQL & " ORDER BY TPM020.GROUPCD"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            pGroupNo = "001"
            LF_GetTPM020_3 = True
            Exit Function
        End If

        lngCnt = 0
        lngWork = 0
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If

            If (lngWork + 1) = CLng(Mid$(Trim$(objRows("GROUPCD")), 2, 3)) Then
                lngWork = CLng(Mid$(Trim$(objRows("GROUPCD")), 2, 3))
            Else
                pGroupNo = Format$(lngWork + 1, "000")
                Exit While
            End If

            lngCnt = lngCnt + 1
        End While

        If Len(pGroupNo) = 0 Then
            pGroupNo = Format$(lngWork + 1, "000")
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPM020_3 = True
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ／グループ内重複チェック
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM020_4(ByVal pGroupCD As String, ByVal pGoodsCD As String, ByRef pExists As Boolean) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()


        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM020_4 = False
        pExists = False

        strSQL = ""
        strSQL = strSQL & "SELECT TPM020.GOODSCD"
        strSQL = strSQL & "  FROM TPM020"
        strSQL = strSQL & " WHERE TPM020.GROUPCD = '" & pGroupCD & "'"
        strSQL = strSQL & "   AND TPM020.GOODSCD = '" & pGoodsCD & "'"
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
        LF_GetTPM020_4 = True
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ更新処理(グループ追加/削除処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM020_1(ByVal pUpdKbn As String, Optional ByVal pDelGrpCD As String = "", Optional ByVal pAddGrpNm As String = "") As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strNewNo As String = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020_1 = False

        strSQL = ""
        Select Case pUpdKbn
            Case LC_UPDKBN_ADD
                ' --- (2003.12.11) メニューＩＤ採番方法を変更 ----------------------
                'If Not LF_GetTPM020_3(strNewNo) Then
                '    Exit Function
                'End If
                Select Case GF_GetNewID(CNL1920.ID_KIND.GenrID, strNewNo)
                    Case CNL1920.FuncResult.CancelEnd
                        GF_Msg("", "ジャンル登録数が上限に達しました。いずれかのメニューを削除して下さい。", MsgBoxStyle.OKOnly, MsgBoxStyle.Information)
                        LF_UpdTPM020_1 = True
                        Exit Function
                    Case CNL1920.FuncResult.UnusualEnd
                        Exit Function
                End Select
                ' ------------------------------------------------------------------
                strSQL = strSQL & "INSERT INTO TPM020 VALUES("
                ' --- (2003.12.11) メニューＩＤ採番方法を変更 ----------------------
                strSQL = strSQL & "'" & strNewNo & "',"
                ' ------------------------------------------------------------------
                strSQL = strSQL & "'0000',"
                strSQL = strSQL & "'" & IIf(Len(Trim$(pAddGrpNm)) = 0, LC_DEF_GRPNMJ, GF_RepQuo(pAddGrpNm)) & "',"
                strSQL = strSQL & "'" & Space(1) & "',"
                strSQL = strSQL & "'" & Space(1) & "',"
                strSQL = strSQL & "'" & LC_DEF_GRPPRICE & "',"
                strSQL = strSQL & "'0000000000',"
                strSQL = strSQL & "'" & GC_TRUE & "',"

                ' --- (2004.02.03) 「おすすめジャンル」追加 ----------------
                strSQL = strSQL & "'" & GC_FALSE & "',"
                ' ----------------------------------------------------------

                strSQL = strSQL & "'" & GC_UPDID & "',"
                strSQL = strSQL & "'" & Now & "')"

            Case LC_UPDKBN_DEL
                strSQL = strSQL & "DELETE TPM020"
                strSQL = strSQL & " WHERE TPM020.GROUPCD = '" & pDelGrpCD & "'"

                '--- (2006.02.08) メニュー画像用テーブルのジャンルを解除する -------------------------------------
                Dim strSQL2 As String

                strSQL2 = ""
                strSQL2 = strSQL2 & "UPDATE TPM150"
                strSQL2 = strSQL2 & "   SET GROUPCD = 'J000'"
                strSQL2 = strSQL2 & " WHERE TPM150.GROUPCD = '" & pDelGrpCD & "'"
                If Not GF_UpdData(strSQL2) Then
                    Exit Function
                End If
                '---------------------------------------------------------------------------------------

            Case Else
                Exit Function
        End Select
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020_1 = True
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ更新処理(グループ内商品コード追加/削除処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM020_2(ByVal pUpdKbn As String, ByVal pGroupCD As String, ByVal pGoodsCD As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020_2 = False

        strSQL = ""
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
                ' --- (2004.02.03) 「おすすめジャンル」追加 ----------------
                strSQL = strSQL & "'" & Space(1) & "',"
                ' ----------------------------------------------------------
                strSQL = strSQL & "'" & GC_UPDID & "',"
                strSQL = strSQL & "'" & Now & "')"

            Case LC_UPDKBN_DEL
                strSQL = strSQL & "DELETE FROM TPM020"
                strSQL = strSQL & " WHERE TPM020.GROUPCD = '" & pGroupCD & "'"
                strSQL = strSQL & "   AND TPM020.GOODSCD = '" & pGoodsCD & "'"

            Case Else
                Exit Function
        End Select
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020_2 = True
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ更新処理(グループ情報更新処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM020_3(ByVal pGroupNM As String, ByVal pGroupInfo As typItemInfo) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020_3 = False

        With pGroupInfo
            strSQL = ""
            strSQL = strSQL & "UPDATE TPM020"
            strSQL = strSQL & "   SET TPM020.GROUPNM    = '" & GF_RepQuo(pGroupNM) & "',"
            strSQL = strSQL & "       TPM020.GROUPINFO  = '" & IIf(Len(.strGROUPINFO) = 0, Space(360), Replace(GF_RepQuo(.strGROUPINFO), vbCrLf, "<BR>")) & "',"
            strSQL = strSQL & "       TPM020.GROUPIMAGE = '" & IIf(Len(.strGROUPIMAGE) = 0, Space(100), GF_RepQuo(.strGROUPIMAGE)) & "',"
            strSQL = strSQL & "       TPM020.PRICEDISP  = '" & .strPRICEDISP & "',"
            strSQL = strSQL & "       TPM020.UPDID      = '" & GC_UPDID & "',"
            strSQL = strSQL & "       TPM020.UPDYMD     = '" & Now & "'"
            strSQL = strSQL & " WHERE TPM020.GROUPCD    = '" & pGroupInfo.strGROUPCD & "'"
            strSQL = strSQL & "   AND TPM020.GOODSCD    = '0000'"
        End With
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020_3 = True
    End Function

    Private Function LF_UpdTPM020_4(ByVal pGrpCD As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim lngCnt As Long
        Dim objItem As ListViewItem

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020_4 = False

        '------------------------------
        ' 全アイテム表示順更新
        '------------------------------
        lngCnt = 1
        For Each objItem In lsv_ItemGrp.Items
            strSQL = ""
            strSQL = strSQL & "UPDATE TPM020"
            strSQL = strSQL & "   SET TPM020.DISPORDER = '" & Format$(lngCnt, "0000000000") & "'"
            strSQL = strSQL & " WHERE TPM020.GROUPCD = '" & pGrpCD & "'"
            strSQL = strSQL & "   AND TPM020.GOODSCD = '" & objItem.SubItems(0).Text & "'"
            If Not GF_UpdData(strSQL) Then
                Exit Function
            End If

            lngCnt = lngCnt + 1
        Next

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020_4 = True

    End Function

    ' --- (2004.02.03) 「おすすめジャンル」追加 ----------------------------
    Private Function LF_UpdTPM020_5(ByVal pGrpCD As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020_5 = False

        '------------------------------
        ' 「おすすめフラグ」更新処理
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM020"
        strSQL = strSQL & "   SET TPM020.SPFLG = '" & IIf(chk_SPFLG.Checked, GC_TRUE, GC_FALSE) & "'"
        strSQL = strSQL & " WHERE TPM020.GROUPCD = '" & pGrpCD & "'"
        strSQL = strSQL & "   AND TPM020.GOODSCD = '0000'"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020_5 = True

    End Function
    ' ----------------------------------------------------------------------

    Private Function LF_UpdTPM010(ByVal pGenrCD As String) As Boolean

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
        strSQL = strSQL & " WHERE TPM010.GOODSCD IN (SELECT TPM010.GOODSCD"
        strSQL = strSQL & "                            FROM TPM010,"
        strSQL = strSQL & "                                 TPM020"
        strSQL = strSQL & "                           WHERE TPM020.GROUPCD = '" & pGenrCD & "'"
        strSQL = strSQL & "                             AND TPM020.GOODSCD <> '0000'"
        strSQL = strSQL & "                             AND TPM020.GOODSCD = TPM010.GOODSCD)"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM010 = True

    End Function

    Private Sub txt_GrpNM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GrpNM.TextChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection

        If txt_GrpNM.Modified = True Then
            ' --- (2003.11.19) 半角文字を入力制限した ---
            Dim lngST As Long
            lngST = txt_GrpNM.SelectionStart
            ' 2014-05-12 2バイト文字制限解除
            'txt_GrpNM.Text = StrConv(txt_GrpNM.Text, VbStrConv.Wide)
            If lngST >= 0 Then txt_GrpNM.SelectionStart = lngST
            'txt_GrpNM.SelectionStart = GF_LenB(txt_GrpNM.Text)
            ' -------------------------------------------

            '------------------------------
            ' 入力長制限
            '------------------------------
            ' --- (2003.12.02) 最大入力長を、全角8文字に制限 ---------------
            'If GF_LenB(txt_GrpNM.Text) > 50 Then
            '    txt_GrpNM.Text = GF_MidB(txt_GrpNM.Text, 1, 50)
            '    txt_GrpNM.SelectionStart = GF_LenB(txt_GrpNM.Text)
            '    Exit Sub
            'End If
            If GF_LenB(txt_GrpNM.Text) > 16 Then
                txt_GrpNM.Text = GF_MidB(txt_GrpNM.Text, 1, 16)
                txt_GrpNM.SelectionStart = GF_LenB(txt_GrpNM.Text)
                Exit Sub
            End If
            ' --------------------------------------------------------------

            '------------------------------
            ' 選択項目取得
            '------------------------------
            objCollection = lsv_Group.SelectedItems
            With objCollection
                If .Count = 0 Then Exit Sub
                If .Contains(.Item(0)) = False Then Exit Sub
                .Item(0).Text = txt_GrpNM.Text

                If Not LF_UpdTPM020_3(txt_GrpNM.Text, .Item(0).Tag) Then
                    GoTo SYSTEM_ERROR
                End If
                L_blnEditFlg = True
            End With
        End If
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_GrpNM_TextChanged")
    End Sub

    Private Sub txt_GrpInfo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GrpInfo.TextChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim udtInfo As typItemInfo
        Dim intPos As Integer
        Dim lngCrCnt As Long

        If txt_GrpInfo.Modified = True Then

            If Len(txt_GrpInfo.Text) <> 0 Then
                If Mid$(txt_GrpInfo.Text, Len(txt_GrpInfo.Text), 1) = vbLf Then
                    intPos = 1
                    While intPos <> 0
                        intPos = InStr(intPos, txt_GrpInfo.Text, vbCrLf)
                        If intPos <> 0 Then
                            lngCrCnt = lngCrCnt + 1
                            intPos = intPos + 1
                        End If
                    End While
                    If lngCrCnt >= 5 Then
                        txt_GrpInfo.Text = Mid$(txt_GrpInfo.Text, 1, Len(txt_GrpInfo.Text) - 2)
                        txt_GrpInfo.SelectionStart = GF_LenB(txt_GrpInfo.Text)
                    End If
                End If
            End If

            '------------------------------
            ' 入力長制限
            '------------------------------
            If GF_LenB(txt_GrpInfo.Text) > 90 Then
                txt_GrpInfo.Text = GF_MidB(txt_GrpInfo.Text, 1, 90)
                txt_GrpInfo.SelectionStart = GF_LenB(txt_GrpInfo.Text)
                Exit Sub
            End If

            '------------------------------
            ' 選択項目取得
            '------------------------------
            objCollection = lsv_Group.SelectedItems
            With objCollection
                If .Count = 0 Then Exit Sub
                If .Contains(.Item(0)) = False Then Exit Sub

                udtInfo = .Item(0).Tag
                udtInfo.strGROUPINFO = txt_GrpInfo.Text
                .Item(0).Tag = udtInfo

                If Not LF_UpdTPM020_3(txt_GrpNM.Text, udtInfo) Then
                    GoTo SYSTEM_ERROR
                End If
                L_blnEditFlg = True
            End With
        End If
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_GrpInfo_TextChanged")
    End Sub

    Private Sub LS_TransGrpImage(ByVal pFileNm As String, ByRef pResultName As String)

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

        ' TP1031内では、全てフルパスで画像ファイルを扱う。
        ' 返却値(=G_TP1031_Ret)でも同様に、フルパスで返却されるが、これを
        ' システムで保持する『グループ画像保存パス』へ転送するため、
        ' ファイル情報として分解し、同パスへコピーを行う。
        ' 最終的に、他の画像が選択され、使われないことになったとしても、
        ' 画面クローズ時に、画像ガベージ処理を行うため、不要な画像ファイル
        ' は残らないことになる。
        strGrpImgPath = GF_GetAppInfo("GROUP_PATH")
        objFileInfo = New System.IO.FileInfo(pFileNm)
        ' --- (2003.12.15) 障害対応 ----------------------------------------
        strTgtPath = strGrpImgPath & "\" & objFileInfo.Name
        ' ------------------------------------------------------------------
        If objFileInfo.DirectoryName <> strGrpImgPath Then
            Try
                ' --- (2003.12.04) 同名別画像設定時対応 --------------------
                'If System.IO.File.Exists(strGrpImgPath & "\" & objFileInfo.Name) = False Then
                '    System.IO.File.Copy(pFileNm, _
                '                        strGrpImgPath & "\" & objFileInfo.Name)
                '    ' --- 縮小処理 ---
                '    objBitmap = New Bitmap(352, 264)
                '    objGraph = Graphics.FromImage(objBitmap)
                '    objGraph.DrawImage(Image.FromFile(strGrpImgPath & "\" & objFileInfo.Name), 0, 0, 352, 264)
                '    objBitmap.Save(strGrpImgPath & "\S_" & objFileInfo.Name, System.Drawing.Imaging.ImageFormat.Jpeg)
                '    objBitmap.Dispose()
                '    objGraph.Dispose()
                'End If

                ' 既に同名のファイルが存在した場合は、それを消してしまって、新たに作り直す
                strOrgPath = pFileNm
                ' --- (2003.12.13) メニューリアル切替対応 ------------------
                'strTgtPath = strGrpImgPath & "\" & objFileInfo.Name
                'strSTgtPath = strGrpImgPath & "\S_" & objFileInfo.Name
                strTgtPath = strGrpImgPath & "\" & Replace(objFileInfo.Name, objFileInfo.Extension, "") & Format$(Now, "yyyyMMddHHmmss") & objFileInfo.Extension
                strSTgtPath = strGrpImgPath & "\S_" & Replace(objFileInfo.Name, objFileInfo.Extension, "") & Format$(Now, "yyyyMMddHHmmss") & objFileInfo.Extension
                ' ----------------------------------------------------------

                '------------------------------
                ' 旧グループ画像を削除
                '------------------------------
                If System.IO.File.Exists(strTgtPath) = True Then
                    System.IO.File.SetAttributes(strTgtPath, IO.FileAttributes.Normal)
                    System.IO.File.Delete(strTgtPath)
                End If
                If System.IO.File.Exists(strSTgtPath) = True Then
                    System.IO.File.SetAttributes(strSTgtPath, IO.FileAttributes.Normal)
                    System.IO.File.Delete(strSTgtPath)
                End If

                '------------------------------
                ' オリジナルサイズコピー
                '------------------------------
                System.IO.File.Copy(strOrgPath, strTgtPath)

                '------------------------------
                ' 縮小処理コピー(再保存)
                '------------------------------
                objBitmap = New Bitmap(352, 264)
                objGraph = Graphics.FromImage(objBitmap)
                objGraph.DrawImage(Image.FromFile(strTgtPath), 0, 0, 352, 264)
                objBitmap.Save(strSTgtPath, System.Drawing.Imaging.ImageFormat.Jpeg)
                objBitmap.Dispose()
                objGraph.Dispose()
                ' ----------------------------------------------------------
            Catch
                objFileInfo = Nothing
                Exit Sub
            End Try
        End If
        objFileInfo = Nothing
        pResultName = strTgtPath

    End Sub

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
        ' 使用中画像ファイル一覧取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM020.GROUPCD,"
        strSQL = strSQL & "       TPM020.GROUPIMAGE"
        strSQL = strSQL & "  FROM TPM020"
        strSQL = strSQL & " WHERE TPM020.GOODSCD = '0000'"
        strSQL = strSQL & "   AND LEN(LTRIM(TPM020.GROUPIMAGE)) <> 0"
        strSQL = strSQL & " GROUP BY TPM020.GROUPCD,"
        strSQL = strSQL & "          TPM020.GROUPIMAGE"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If
            ReDim Preserve strUFile(lngCnt)
            strUFile(lngCnt) = Trim$(objRows("GROUPIMAGE"))

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
                '--- (2006.02.07) メニュー画像作成対応 --------------------------------------------------------
                ' メニュー画像もGroupImageに格納。ファイル名の頭文字が"M"はメニュー画像のため、削除しない
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
                '----------------------------------------------------------------------------------------------
            Next
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_DelUnuseFile = True

    End Function

    Private Sub lsv_ItemGrp_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_ItemGrp.ItemDrag
        ' ドラッグ処理開始
        L_blnDMode = False
        lsv_ItemGrp.DoDragDrop(lsv_ItemGrp.SelectedItems, DragDropEffects.Copy)
    End Sub

    Private Sub lsv_ItemGrp_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemGrp.DragEnter
        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub lsv_ItemGrp_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemGrp.DragDrop

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objItem As ListViewItem
        Dim objPoint As Point
        Dim udtInfo As typItemInfo

        If lsv_Group.SelectedItems.Count = 0 Then Exit Sub

        If L_blnDMode = False Then
            objPoint = lsv_ItemGrp.PointToClient(New Point(e.X, e.Y))
            objItem = lsv_ItemGrp.GetItemAt(objPoint.X, objPoint.Y)
            udtInfo = lsv_Group.SelectedItems(0).Tag

            Call LS_ItemMove(udtInfo.strGROUPCD, objItem.Index, e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))

        Else
            If Not e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then Exit Sub
            Call LS_AddItems(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
        End If

    End Sub

    Private Sub lsv_ItemList_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_ItemList.ItemDrag
        ' ドラッグ処理開始
        L_blnDMode = True
        lsv_ItemGrp.DoDragDrop(lsv_ItemList.SelectedItems, DragDropEffects.Copy)
    End Sub
    Private Sub lsv_ItemList_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemList.DragEnter
        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub lsv_ItemList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemList.DragDrop

        If L_blnDMode = True Then Exit Sub
        If Not e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then Exit Sub
        Call LS_RemoveItems(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))

    End Sub

    Private Sub tlb_Btn2_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlb_Btn2.ButtonClick

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objItem As ListViewItem

        Select Case e.Button.Text
            Case tlb_Btn2.Buttons.Item(0).Text
                Call LS_AddItems(lsv_ItemList.SelectedItems)

            Case tlb_Btn2.Buttons.Item(1).Text
                Call LS_RemoveItems(lsv_ItemGrp.SelectedItems)

            Case tlb_Btn2.Buttons.Item(2).Text
                lsv_ItemGrp.SelectedItems.Clear()                           ' 選択状態解除
                For Each objItem In lsv_ItemGrp.Items                       ' 全アイテム選択状態
                    objItem.Selected = True
                Next
                Call LS_RemoveItems(lsv_ItemGrp.SelectedItems)

            Case Else
                GoTo SYSTEM_ERROR
        End Select

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("tlb_Btn2_ButtonClick")
    End Sub

    Private Sub LS_AddItems(ByVal pTargetData As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim udtinfo As typItemInfo
        Dim lngDataCnt As Integer
        Dim lngCnt As Integer
        Dim lngListCnt As Integer
        Dim lngRefCnt As Integer
        Dim blnExists As Boolean

        If pTargetData.Count = 0 Then Exit Sub
        objCollection = lsv_Group.SelectedItems
        With objCollection
            If .Count = 0 Then Exit Sub
            If .Contains(.Item(0)) = False Then Exit Sub
            udtinfo = .Item(0).Tag
        End With

        lngDataCnt = pTargetData.Count
        lngCnt = 0
        lngRefCnt = 0
        For lngCnt = 0 To lngDataCnt - 1
            '------------------------------
            ' 追加先グループコード取得
            '------------------------------
            If Not LF_GetTPM020_4(udtinfo.strGROUPCD, _
                                  pTargetData.Item(lngRefCnt).Text, _
                                  blnExists) Then
                GoTo SYSTEM_ERROR
            End If
            If blnExists Then
                'Call GF_Msg("E05", vbCrLf & "[ " & pTargetData.Item(lngRefCnt).SubItems(1).Text & " ]", MsgBoxStyle.Exclamation, MsgBoxStyle.OKOnly)
                lngRefCnt = lngRefCnt + 1
            Else
                '------------------------------
                ' ＤＢ更新処理
                '------------------------------
                If Not LF_UpdTPM020_2(LC_UPDKBN_ADD, _
                                      udtinfo.strGROUPCD, _
                                      Trim$(pTargetData.Item(lngRefCnt).Text)) Then
                    GoTo SYSTEM_ERROR
                End If

                '------------------------------
                ' 商品一覧更新
                '------------------------------
                ' --- (2003.12.02) 右側のリストビューから減らす条件を追加 --
                If GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex) = LC_SORT_NOGROUP Then
                    With lsv_ItemList.Items
                        For lngListCnt = 0 To .Count - 1
                            If .Item(lngListCnt).Text = pTargetData.Item(lngRefCnt).Text Then
                                .Item(lngListCnt).Remove()
                                Exit For
                            End If
                        Next
                    End With
                Else
                    lngRefCnt = lngRefCnt + 1
                End If
                ' ----------------------------------------------------------
            End If
        Next

        '------------------------------
        ' グループ内商品一覧更新
        '------------------------------
        Call LS_SetItemList(udtinfo.strGROUPCD)

        '------------------------------
        ' 表示順項目更新処理
        '------------------------------
        If Not LF_UpdTPM020_4(udtinfo.strGROUPCD) Then
            GoTo SYSTEM_ERROR
        End If

        L_blnEditFlg = True
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AddItems")

    End Sub

    Private Sub LS_RemoveItems(ByVal pTargetData As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim udtinfo As typItemInfo
        Dim lngCnt As Integer

        If pTargetData.Count = 0 Then Exit Sub

        '------------------------------
        ' 削除先グループコード取得
        '------------------------------
        objCollection = lsv_Group.SelectedItems
        With objCollection
            If .Count = 0 Then Exit Sub
            If .Contains(.Item(0)) = False Then Exit Sub
            udtinfo = .Item(0).Tag
        End With

        lngCnt = 0
        While lngCnt < pTargetData.Count
            '------------------------------
            ' ＤＢ更新処理
            '------------------------------
            If Not LF_UpdTPM020_2(LC_UPDKBN_DEL, _
                                  udtinfo.strGROUPCD, _
                                  Trim$(pTargetData.Item(lngCnt).Text)) Then
                GoTo SYSTEM_ERROR
            End If

            lngCnt = lngCnt + 1
        End While
        Call LS_SetItemList(udtinfo.strGROUPCD)

        ' --- (2003.12.08) [未登録商品]以外は、右側のリストを更新しない ----
        'Call LS_SetItemList2(GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex))
        If GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex) = LC_SORT_NOGROUP Then
            Call LS_SetItemList2(GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex))
        End If
        ' ------------------------------------------------------------------

        '------------------------------
        ' 表示順項目更新処理
        '------------------------------
        If Not LF_UpdTPM020_4(udtinfo.strGROUPCD) Then
            GoTo SYSTEM_ERROR
        End If

        L_blnEditFlg = True
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_RemoveItems")

    End Sub

    Private Sub btn_SelImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelImg.Click
        Call LS_GrpImgSelect()
    End Sub

    Private Sub pic_GrpImg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_GrpImg.DoubleClick
        Call LS_GrpImgSelect()
    End Sub

    Private Sub LS_GrpImgSelect()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objForm As New CNL1541()
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim udtInfo As typItemInfo
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim strGrpImgPath As String
        Dim objFile As System.IO.FileStream
        Dim strRetName As String = Nothing                                           ' --- (2003.12.13) 追加 ---

        '------------------------------
        ' 選択項目取得
        '------------------------------
        objCollection = lsv_Group.SelectedItems
        With objCollection
            If .Count = 0 Then Exit Sub
            If .Contains(.Item(0)) = False Then Exit Sub

            udtInfo = .Item(0).Tag
        End With

        strGrpImgPath = GF_GetAppInfo("GROUP_PATH")
        With objForm
            .G_TP1031_Ret = IIf(Len(Trim$(udtInfo.strGROUPIMAGE)) = 0, _
                                GF_GetAppInfo("MATERIAL_V") & "\" & GF_GetMaterial("S013JC"), _
                                strGrpImgPath & "\" & udtInfo.strGROUPIMAGE)
            .ShowDialog()
            If Len(Trim$(.G_TP1031_Ret)) = 0 Then
                Exit Sub
            Else
                Call LS_TransGrpImage(.G_TP1031_Ret, strRetName)
                'objFileInfo = New System.IO.FileInfo(.G_TP1031_Ret)
                objFileInfo = New System.IO.FileInfo(strRetName)
                udtInfo.strGROUPIMAGE = objFileInfo.Name
                objCollection.Item(0).Tag = udtInfo
                If Not LF_UpdTPM020_3(txt_GrpNM.Text, udtInfo) Then
                    GoTo SYSTEM_ERROR
                End If

                ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う(2004.07.14)
                If Not LF_UpdTPM010(udtInfo.strGROUPCD) Then
                    GoTo SYSTEM_ERROR
                End If

                ' 表示反映
                Try
                    'objFile = New System.IO.FileStream(.G_TP1031_Ret, IO.FileMode.Open, IO.FileAccess.Read)
                    objFile = New System.IO.FileStream(strRetName, IO.FileMode.Open, IO.FileAccess.Read)
                    pic_GrpImg.Image = System.Drawing.Image.FromStream(objFile)
                    objFile.Close()
                Catch
                    GoTo SYSTEM_ERROR
                End Try

                L_blnEditFlg = True
            End If
        End With

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GrpImgSelect")
    End Sub

    Private Sub tlb_Move_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlb_Move.ButtonClick

        Dim udtInfo As typItemInfo
        Dim lngTargetIndex As Long

        If lsv_Group.SelectedItems.Count = 0 Then Exit Sub
        If lsv_ItemGrp.SelectedItems.Count = 0 Then Exit Sub

        udtInfo = lsv_Group.SelectedItems(0).Tag
        Select Case e.Button.Text
            Case tlb_Move.Buttons(0).Text
                lngTargetIndex = lsv_ItemGrp.SelectedItems(0).Index - 1
                If lngTargetIndex < 0 Then Exit Sub
            Case tlb_Move.Buttons(1).Text
                lngTargetIndex = lsv_ItemGrp.SelectedItems(lsv_ItemGrp.SelectedItems.Count - 1).Index + 1
                If lngTargetIndex > lsv_ItemGrp.Items.Count - 1 Then Exit Sub
            Case Else
                Exit Sub
        End Select
        Call LS_ItemMove(udtInfo.strGROUPCD, lngTargetIndex, lsv_ItemGrp.SelectedItems)
        lsv_ItemGrp.EnsureVisible(lngTargetIndex)

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("tlb_Move_ButtonClick")
    End Sub

    Private Sub LS_ItemMove(ByVal pGrpCD As String, ByVal pChgPos As Long, ByVal pMoveItems As ListView.SelectedListViewItemCollection)

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
            If pChgPos < 0 Or lsv_ItemGrp.Items.Count - 1 < pChgPos Then Exit Sub

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
                lsv_ItemGrp.Items.Remove(objItem)
                lsv_ItemGrp.Items.Insert(lngPos, objItem)

                If blnUpFlg Then lngPos = lngPos + 1
            Next

            '------------------------------
            ' 表示順項目更新処理
            '------------------------------
            If Not LF_UpdTPM020_4(pGrpCD) Then
                GoTo SYSTEM_ERROR
            End If

            L_blnEditFlg = True                                             ' 更新フラグＯＮ

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_ItemMove")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim udtInfo As typItemInfo
        Dim strDefImg As String
        Dim strGrpImgPath As String
        Dim objFile As System.IO.FileStream

        '------------------------------
        ' 選択項目取得
        '------------------------------
        objCollection = lsv_Group.SelectedItems
        With objCollection
            If .Count = 0 Then Exit Sub
            If .Contains(.Item(0)) = False Then Exit Sub

            udtInfo = .Item(0).Tag
        End With

        '------------------------------
        ' グループイメージを解除
        '------------------------------
        udtInfo.strGROUPIMAGE = ""
        objCollection.Item(0).Tag = udtInfo
        If Not LF_UpdTPM020_3(txt_GrpNM.Text, udtInfo) Then
            GoTo SYSTEM_ERROR
        End If

        ' ジャンル画像入替の際、当該ジャンルに属する全商品画像の再生成を行う(2004.07.14)
        If Not LF_UpdTPM010(udtInfo.strGROUPCD) Then
            GoTo SYSTEM_ERROR
        End If

        strDefImg = GF_GetMaterial("S013JC")
        If Len(Trim$(strDefImg)) = 0 Then
            GoTo SYSTEM_ERROR
        End If
        strGrpImgPath = GF_GetAppInfo("MATERIAL_V") & "\" & Trim$(strDefImg)
        Try
            objFile = New System.IO.FileStream(strGrpImgPath, IO.FileMode.Open, IO.FileAccess.Read)
            pic_GrpImg.Image = System.Drawing.Image.FromStream(objFile)
            objFile.Close()
        Catch
            GoTo SYSTEM_ERROR
        End Try
        L_blnEditFlg = True

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GrpImgSelect")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品名検索テキストボックス内 Enterキー押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_Search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call LS_SetItemList2(GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex))
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品名検索 検索開始ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LS_SetItemList2(GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex))
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：部門検索コンボボックス選択時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub cbo_Bumon_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_Bumon.SelectionChangeCommitted
        Call LS_SetItemList2(GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex))
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：名称検索テキストボックス入力時処理
    ' 　機能概要：入力長について、名称項目長(20バイト)で制限を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.02 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_Search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Search.TextChanged
        If txt_Search.Modified = False Then Exit Sub

        '------------------------------
        ' 入力長制限
        '------------------------------
        If GF_LenB(txt_Search.Text) > 20 Then
            txt_Search.Text = GF_MidB(txt_Search.Text, 1, 20)
            txt_Search.SelectionStart = GF_LenB(txt_Search.Text)
            Exit Sub
        End If
        Call LS_SetItemList2(GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex))

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If GF_Msg("", "表示条件をクリアしますか？", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        txt_Search.Clear()
        cbo_Bumon.SelectedIndex = 0
        cbo_Sort.SelectedIndex = 3
        Call LS_SetItemList2(GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex))
    End Sub

    Private Sub chk_SPFLG_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_SPFLG.CheckedChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection

        If L_blnProcFlg Then Exit Sub

        objCollection = lsv_Group.SelectedItems
        With objCollection
            If .Count = 0 Then Exit Sub
            If .Contains(.Item(0)) = False Then Exit Sub
            If Not LF_UpdTPM020_5(CType(.Item(0).Tag, typItemInfo).strGROUPCD) Then
                GoTo SYSTEM_ERROR
            End If
            L_blnEditFlg = True
        End With

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("chk_SPFLG_CheckedChanged")
    End Sub
End Class
