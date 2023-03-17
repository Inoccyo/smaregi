' --------------------------------------------------------------------------------
' 　機　　能：CrossNavi - 品切れ登録画面
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
' --------------------------------------------------------------------------------
Public Class CNL2080
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents sts_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lsv_SoldOutList As System.Windows.Forms.ListView
    Friend WithEvents lsv_GoodsList As System.Windows.Forms.ListView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ImageList3 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList4 As System.Windows.Forms.ImageList
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_Del As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lbl_Soldout_Nm3 As System.Windows.Forms.Label
    Friend WithEvents lbl_Soldout_Nm4 As System.Windows.Forms.Label
    Friend WithEvents lbl_Soldout_Nm2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Soldout_Nm As System.Windows.Forms.Label
    Friend WithEvents lsv_SoldOutList4 As System.Windows.Forms.ListView
    Friend WithEvents lsv_SoldOutList3 As System.Windows.Forms.ListView
    Friend WithEvents lsv_SoldOutList2 As System.Windows.Forms.ListView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CNL2080))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"aaa", "a2", "a3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"bbb"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ccc"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"aaa", "a2", "a3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"bbb"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ccc"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"aaa", "a2", "a3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"bbb"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ccc"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"aaa", "a2", "a3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"bbb"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"ccc"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)))
        Me.sts_Msg = New System.Windows.Forms.StatusBar
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbl_Soldout_Nm3 = New System.Windows.Forms.Label
        Me.lbl_Soldout_Nm4 = New System.Windows.Forms.Label
        Me.lbl_Soldout_Nm2 = New System.Windows.Forms.Label
        Me.lbl_Soldout_Nm = New System.Windows.Forms.Label
        Me.lsv_SoldOutList4 = New System.Windows.Forms.ListView
        Me.lsv_SoldOutList3 = New System.Windows.Forms.ListView
        Me.lsv_SoldOutList2 = New System.Windows.Forms.ListView
        Me.Label25 = New System.Windows.Forms.Label
        Me.btn_Del = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_Search = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lsv_GoodsList = New System.Windows.Forms.ListView
        Me.lsv_SoldOutList = New System.Windows.Forms.ListView
        Me.ImageList4 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'sts_Msg
        '
        Me.sts_Msg.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.sts_Msg.Location = New System.Drawing.Point(0, 665)
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
        Me.MenuItem1.Text = "グループからこの商品を外す"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem4})
        Me.MenuItem2.Text = "品切れ登録"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Text = "-"
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
        Me.Panel1.Controls.Add(Me.lbl_Soldout_Nm3)
        Me.Panel1.Controls.Add(Me.lbl_Soldout_Nm4)
        Me.Panel1.Controls.Add(Me.lbl_Soldout_Nm2)
        Me.Panel1.Controls.Add(Me.lbl_Soldout_Nm)
        Me.Panel1.Controls.Add(Me.lsv_SoldOutList4)
        Me.Panel1.Controls.Add(Me.lsv_SoldOutList3)
        Me.Panel1.Controls.Add(Me.lsv_SoldOutList2)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.btn_Del)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_Search)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lsv_GoodsList)
        Me.Panel1.Controls.Add(Me.lsv_SoldOutList)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 232
        '
        'lbl_Soldout_Nm3
        '
        Me.lbl_Soldout_Nm3.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_Soldout_Nm3.Image = CType(resources.GetObject("lbl_Soldout_Nm3.Image"), System.Drawing.Image)
        Me.lbl_Soldout_Nm3.Location = New System.Drawing.Point(205, 378)
        Me.lbl_Soldout_Nm3.Name = "lbl_Soldout_Nm3"
        Me.lbl_Soldout_Nm3.Size = New System.Drawing.Size(81, 24)
        Me.lbl_Soldout_Nm3.TabIndex = 256
        Me.lbl_Soldout_Nm3.Text = "品切れ３"
        Me.lbl_Soldout_Nm3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Soldout_Nm4
        '
        Me.lbl_Soldout_Nm4.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_Soldout_Nm4.Image = CType(resources.GetObject("lbl_Soldout_Nm4.Image"), System.Drawing.Image)
        Me.lbl_Soldout_Nm4.Location = New System.Drawing.Point(462, 378)
        Me.lbl_Soldout_Nm4.Name = "lbl_Soldout_Nm4"
        Me.lbl_Soldout_Nm4.Size = New System.Drawing.Size(81, 24)
        Me.lbl_Soldout_Nm4.TabIndex = 255
        Me.lbl_Soldout_Nm4.Text = "品切れ４"
        Me.lbl_Soldout_Nm4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Soldout_Nm2
        '
        Me.lbl_Soldout_Nm2.BackColor = System.Drawing.Color.White
        Me.lbl_Soldout_Nm2.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_Soldout_Nm2.Image = CType(resources.GetObject("lbl_Soldout_Nm2.Image"), System.Drawing.Image)
        Me.lbl_Soldout_Nm2.Location = New System.Drawing.Point(462, 110)
        Me.lbl_Soldout_Nm2.Name = "lbl_Soldout_Nm2"
        Me.lbl_Soldout_Nm2.Size = New System.Drawing.Size(81, 24)
        Me.lbl_Soldout_Nm2.TabIndex = 254
        Me.lbl_Soldout_Nm2.Text = "品切れ２"
        Me.lbl_Soldout_Nm2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Soldout_Nm
        '
        Me.lbl_Soldout_Nm.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_Soldout_Nm.Image = CType(resources.GetObject("lbl_Soldout_Nm.Image"), System.Drawing.Image)
        Me.lbl_Soldout_Nm.Location = New System.Drawing.Point(205, 112)
        Me.lbl_Soldout_Nm.Name = "lbl_Soldout_Nm"
        Me.lbl_Soldout_Nm.Size = New System.Drawing.Size(81, 24)
        Me.lbl_Soldout_Nm.TabIndex = 253
        Me.lbl_Soldout_Nm.Text = "品切れ１"
        Me.lbl_Soldout_Nm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lsv_SoldOutList4
        '
        Me.lsv_SoldOutList4.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ListViewItem1.StateImageIndex = 0
        ListViewItem1.UseItemStyleForSubItems = False
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.StateImageIndex = 0
        Me.lsv_SoldOutList4.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.lsv_SoldOutList4.Location = New System.Drawing.Point(465, 411)
        Me.lsv_SoldOutList4.Name = "lsv_SoldOutList4"
        Me.lsv_SoldOutList4.Size = New System.Drawing.Size(249, 229)
        Me.lsv_SoldOutList4.TabIndex = 252
        Me.lsv_SoldOutList4.UseCompatibleStateImageBehavior = False
        Me.lsv_SoldOutList4.View = System.Windows.Forms.View.Details
        '
        'lsv_SoldOutList3
        '
        Me.lsv_SoldOutList3.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ListViewItem4.StateImageIndex = 0
        ListViewItem4.UseItemStyleForSubItems = False
        ListViewItem5.StateImageIndex = 0
        ListViewItem6.StateImageIndex = 0
        Me.lsv_SoldOutList3.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4, ListViewItem5, ListViewItem6})
        Me.lsv_SoldOutList3.Location = New System.Drawing.Point(208, 411)
        Me.lsv_SoldOutList3.Name = "lsv_SoldOutList3"
        Me.lsv_SoldOutList3.Size = New System.Drawing.Size(242, 229)
        Me.lsv_SoldOutList3.TabIndex = 251
        Me.lsv_SoldOutList3.UseCompatibleStateImageBehavior = False
        Me.lsv_SoldOutList3.View = System.Windows.Forms.View.Details
        '
        'lsv_SoldOutList2
        '
        Me.lsv_SoldOutList2.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ListViewItem7.StateImageIndex = 0
        ListViewItem7.UseItemStyleForSubItems = False
        ListViewItem8.StateImageIndex = 0
        ListViewItem9.StateImageIndex = 0
        Me.lsv_SoldOutList2.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem7, ListViewItem8, ListViewItem9})
        Me.lsv_SoldOutList2.Location = New System.Drawing.Point(465, 146)
        Me.lsv_SoldOutList2.Name = "lsv_SoldOutList2"
        Me.lsv_SoldOutList2.Size = New System.Drawing.Size(249, 229)
        Me.lsv_SoldOutList2.TabIndex = 250
        Me.lsv_SoldOutList2.UseCompatibleStateImageBehavior = False
        Me.lsv_SoldOutList2.View = System.Windows.Forms.View.Details
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label25.Image = CType(resources.GetObject("Label25.Image"), System.Drawing.Image)
        Me.Label25.Location = New System.Drawing.Point(615, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(275, 30)
        Me.Label25.TabIndex = 249
        Me.Label25.Text = "品切れしたい商品を「商品一覧」から選択し、" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "「品切れ商品一覧」へドラッグしてください"
        '
        'btn_Del
        '
        Me.btn_Del.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Del.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Del.Location = New System.Drawing.Point(219, 10)
        Me.btn_Del.Name = "btn_Del"
        Me.btn_Del.Size = New System.Drawing.Size(180, 50)
        Me.btn_Del.TabIndex = 248
        Me.btn_Del.Text = "品切れ一括解除"
        Me.btn_Del.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(204, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(794, 1)
        Me.Label11.TabIndex = 247
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(723, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 24)
        Me.Label7.TabIndex = 244
        Me.Label7.Text = "商品検索"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(814, 112)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(192, 22)
        Me.txt_Search.TabIndex = 6
        Me.txt_Search.Text = "TextBox1"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(723, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(228, 16)
        Me.Label5.TabIndex = 235
        Me.Label5.Text = "■ 商品一覧"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(205, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(268, 16)
        Me.Label3.TabIndex = 234
        Me.Label3.Text = "■ 品切れ商品一覧"
        '
        'lsv_GoodsList
        '
        Me.lsv_GoodsList.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_GoodsList.Location = New System.Drawing.Point(726, 146)
        Me.lsv_GoodsList.Name = "lsv_GoodsList"
        Me.lsv_GoodsList.Size = New System.Drawing.Size(280, 505)
        Me.lsv_GoodsList.TabIndex = 10
        Me.lsv_GoodsList.UseCompatibleStateImageBehavior = False
        Me.lsv_GoodsList.View = System.Windows.Forms.View.Details
        '
        'lsv_SoldOutList
        '
        Me.lsv_SoldOutList.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ListViewItem10.StateImageIndex = 0
        ListViewItem10.UseItemStyleForSubItems = False
        ListViewItem11.StateImageIndex = 0
        ListViewItem12.StateImageIndex = 0
        Me.lsv_SoldOutList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem10, ListViewItem11, ListViewItem12})
        Me.lsv_SoldOutList.Location = New System.Drawing.Point(208, 146)
        Me.lsv_SoldOutList.Name = "lsv_SoldOutList"
        Me.lsv_SoldOutList.Size = New System.Drawing.Size(242, 229)
        Me.lsv_SoldOutList.TabIndex = 4
        Me.lsv_SoldOutList.UseCompatibleStateImageBehavior = False
        Me.lsv_SoldOutList.View = System.Windows.Forms.View.Details
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
        'CNL2080
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1016, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.sts_Msg)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL2080"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNL2080"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Structure typItemInfo
        Dim strSCPNO As String
    End Structure

    ' 更新区分
    Private Const LC_UPDKBN_ADD As String = "ADD"
    Private Const LC_UPDKBN_DEL As String = "DEL"

    Private L_blnDMode As String
    '0:商品一覧リストから操作
    '1:パターン１から操作
    '2:パターン２から操作
    '3:パターン３から操作
    '4:パターン４から操作
    'Private L_blnEditFlg As Boolean

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub CNL2080_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' フォーム名称設定
        '------------------------------
        Me.Text = " 品切れ登録 "

        '---------------------------------
        '閉じるボタン非表示化
        '---------------------------------
        Me.ControlBox = False

        '---------------------------------
        '品切れ文言取得
        '---------------------------------
        lbl_Soldout_Nm.Text = GF_GetAppInfo("SOLDOUT_NM")
        lbl_Soldout_Nm2.Text = GF_GetAppInfo("SOLDOUT_NM_2")
        lbl_Soldout_Nm3.Text = GF_GetAppInfo("SOLDOUT_NM_3")
        lbl_Soldout_Nm4.Text = GF_GetAppInfo("SOLDOUT_NM_4")

        '------------------------------
        ' 初期化処理
        '------------------------------
        Call GS_StatusSetup(sts_Msg)
        Call LS_FormInit()

        ''------------------------------
        '' トランザクション開始
        ''------------------------------
        'If Not GF_BeginTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If
        'L_blnEditFlg = False

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL2080_Load")
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
            ' 初期値設定
            '------------------------------
            txt_Search.Clear()

            '------------------------------
            ' 品切れ商品一覧初期化
            '------------------------------
            With lsv_SoldOutList
                .Clear()
                .FullRowSelect = True
                .AllowDrop = True
                .AllowColumnReorder = True
                .HideSelection = False
            End With

            With lsv_SoldOutList2
                .Clear()
                .FullRowSelect = True
                .AllowDrop = True
                .AllowColumnReorder = True
                .HideSelection = False
            End With

            With lsv_SoldOutList3
                .Clear()
                .FullRowSelect = True
                .AllowDrop = True
                .AllowColumnReorder = True
                .HideSelection = False
            End With

            With lsv_SoldOutList4
                .Clear()
                .FullRowSelect = True
                .AllowDrop = True
                .AllowColumnReorder = True
                .HideSelection = False
            End With

            '------------------------------
            ' 商品一覧初期化
            '------------------------------
            With lsv_GoodsList
                .Clear()
                .FullRowSelect = True
                .AllowDrop = True
                .AllowColumnReorder = True
                .HideSelection = False
            End With

            '------------------------------
            ' 一覧生成
            '------------------------------
            Call LS_SetSoldOutGoodsList()
            Call LS_SetSoldOutGoodsList2()
            Call LS_SetSoldOutGoodsList3()
            Call LS_SetSoldOutGoodsList4()
            Call LS_SetGoodsList()

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_FormInit")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ商品一覧表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetSoldOutGoodsList()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objItem As ListViewItem
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' 表示データ取得
        '------------------------------
        If Not LF_GetTPD030(objData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            '------------------------------
            ' 品切れ商品一覧設定
            '------------------------------
            lsv_SoldOutList.Clear()
            With lsv_SoldOutList.Columns
                .Add("No", 40, HorizontalAlignment.Center)
                .Add("商品名", 305, HorizontalAlignment.Left)
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

                    lsv_SoldOutList.Items.Add(objItem)
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

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ商品一覧表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetSoldOutGoodsList2()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objItem As ListViewItem
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' 表示データ取得
        '------------------------------
        If Not LF_GetTPD031(objData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            '------------------------------
            ' 品切れ商品一覧設定
            '------------------------------
            lsv_SoldOutList2.Clear()
            With lsv_SoldOutList2.Columns
                .Add("No", 40, HorizontalAlignment.Center)
                .Add("商品名", 305, HorizontalAlignment.Left)
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

                    lsv_SoldOutList2.Items.Add(objItem)
                    objItem = Nothing

                    lngCnt = lngCnt + 1
                End While
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetSoldOutGoodsList2")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ商品一覧表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetSoldOutGoodsList3()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objItem As ListViewItem
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' 表示データ取得
        '------------------------------
        If Not LF_GetTPD032(objData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            '------------------------------
            ' 品切れ商品一覧設定
            '------------------------------
            lsv_SoldOutList3.Clear()
            With lsv_SoldOutList3.Columns
                .Add("No", 40, HorizontalAlignment.Center)
                .Add("商品名", 305, HorizontalAlignment.Left)
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

                    lsv_SoldOutList3.Items.Add(objItem)
                    objItem = Nothing

                    lngCnt = lngCnt + 1
                End While
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetSoldOutGoodsList3")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ商品一覧表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetSoldOutGoodsList4()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objItem As ListViewItem
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' 表示データ取得
        '------------------------------
        If Not LF_GetTPD033(objData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            '------------------------------
            ' 品切れ商品一覧設定
            '------------------------------
            lsv_SoldOutList4.Clear()
            With lsv_SoldOutList4.Columns
                .Add("No", 40, HorizontalAlignment.Center)
                .Add("商品名", 305, HorizontalAlignment.Left)
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

                    lsv_SoldOutList4.Items.Add(objItem)
                    objItem = Nothing

                    lngCnt = lngCnt + 1
                End While
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetSoldOutGoodsList4")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品一覧表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetGoodsList()

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
        If Not LF_GetTPM010(objData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            '------------------------------
            ' 商品一覧設定
            '------------------------------
            lsv_GoodsList.Clear()
            With lsv_GoodsList.Columns
                .Add("No", 40, HorizontalAlignment.Center)
                .Add("商品名", 305, HorizontalAlignment.Left)
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

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ商品[一括解除]ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2011.11.07 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Del.Click

        If GF_Msg("", "品切れ商品を一括解除します。" & vbCrLf & "よろしいですか？", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            If Not LF_DellTPD030() Then
                GoTo SYSTEM_ERROR
            End If

            GF_Msg("", "品切れ商品を一括解除しました", MsgBoxStyle.OkOnly)

            '------------------------------
            ' 品切れ商品一覧更新
            '------------------------------
            Call LS_SetSoldOutGoodsList()
            Call LS_SetSoldOutGoodsList2()
            Call LS_SetSoldOutGoodsList3()
            Call LS_SetSoldOutGoodsList4()
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Del_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ情報管理テーブル削除処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2011.11.07 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_DellTPD030() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_DellTPD030 = False

        '------------------------------
        ' 品切れ情報管理テーブル削除
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "TRUNCATE TABLE TPD030"

        'If Not GF_BeginTrans() Then
        '    Exit Function
        'End If

        If Not GF_UpdCmtData(strSQL) Then
            'Call GF_RollbackTrans()
            Exit Function
        End If

        'If Not GF_CommitTrans() Then
        '    Call GF_RollbackTrans()
        '    Exit Function
        'End If

        strSQL = ""
        strSQL = strSQL & "TRUNCATE TABLE TPD031"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "TRUNCATE TABLE TPD032"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "TRUNCATE TABLE TPD033"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_DellTPD030 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ商品マスタ取得処理(品切れ商品一覧)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPD030(ByRef pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPD030 = False

        '------------------------------
        ' 品切れ商品マスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2"
        strSQL = strSQL & "  FROM TPM010,"
        strSQL = strSQL & "       TPD030"
        strSQL = strSQL & " WHERE TPM010.GOODSCD = TPD030.GOODSCD"
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPD030 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ商品マスタ取得処理(品切れ商品一覧)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPD031(ByRef pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPD031 = False

        '------------------------------
        ' 品切れ商品マスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2"
        strSQL = strSQL & "  FROM TPM010,"
        strSQL = strSQL & "       TPD031"
        strSQL = strSQL & " WHERE TPM010.GOODSCD = TPD031.GOODSCD"
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPD031 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ商品マスタ取得処理(品切れ商品一覧)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPD032(ByRef pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPD032 = False

        '------------------------------
        ' 品切れ商品マスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2"
        strSQL = strSQL & "  FROM TPM010,"
        strSQL = strSQL & "       TPD032"
        strSQL = strSQL & " WHERE TPM010.GOODSCD = TPD032.GOODSCD"
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPD032 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ商品マスタ取得処理(品切れ商品一覧)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPD033(ByRef pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPD033 = False

        '------------------------------
        ' 品切れ商品マスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2"
        strSQL = strSQL & "  FROM TPM010,"
        strSQL = strSQL & "       TPD033"
        strSQL = strSQL & " WHERE TPM010.GOODSCD = TPD033.GOODSCD"
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPD033 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品マスタ取得処理(商品一覧)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM010(ByRef pData As DataSet) As Boolean

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
        strSQL = strSQL & "SELECT GOODSCD,"
        strSQL = strSQL & "       GOODSNMJ,"
        strSQL = strSQL & "       GOODSNMJ2"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " WHERE STATUS  = '0'"
        strSQL = strSQL & "   AND SELLFLG = '0'"

        If Len(Trim$(txt_Search.Text)) <> 0 Then
            strSQL = strSQL & "   AND GOODSNMJ LIKE '%" & Trim$(txt_Search.Text) & "%'"
        End If
        strSQL = strSQL & " ORDER BY GOODSCD"

        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPM010 = True

    End Function

    '    ' --------------------------------------------------------------------------------
    '    ' 　機　　能：保存ボタン押下時処理
    '    ' 　機能概要：
    '    ' 　引　　数：
    '    ' 　戻 り 値：
    '    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    '    ' --------------------------------------------------------------------------------
    '    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '        'If Not GF_CommitTrans() Then
    '        '    GoTo SYSTEM_ERROR
    '        'End If
    '        L_blnEditFlg = False

    '        'If Not GF_BeginTrans() Then
    '        '    GoTo SYSTEM_ERROR
    '        'End If

    '        Exit Sub

    'SYSTEM_ERROR:
    '        Call GS_ErrorTerm("MenuItem3_Click")
    '    End Sub

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

    '    ' --------------------------------------------------------------------------------
    '    ' 　機　　能：フォームクローズ時処理
    '    ' 　機能概要：
    '    ' 　引　　数：
    '    ' 　戻 り 値：
    '    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    '    ' --------------------------------------------------------------------------------
    '    Private Sub CNL2080_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

    '        If L_blnEditFlg Then                                                ' 編集更新有無フラグ判定
    '            Select Case GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNoCancel)
    '                Case MsgBoxResult.Yes
    '                    ''------------------------------
    '                    '' トランザクション確定
    '                    ''------------------------------
    '                    'If Not GF_CommitTrans() Then
    '                    '    Call GF_RollbackTrans()
    '                    '    GoTo SYSTEM_ERROR
    '                    'End If

    '                Case MsgBoxResult.No
    '                    'If Not GF_RollbackTrans() Then
    '                    '    GoTo SYSTEM_ERROR
    '                    'End If

    '                Case MsgBoxResult.Cancel
    '                    e.Cancel = True
    '                    Exit Sub

    '            End Select
    '        Else
    '            'If Not GF_RollbackTrans() Then
    '            '    GoTo SYSTEM_ERROR
    '            'End If
    '        End If

    '        Exit Sub

    'SYSTEM_ERROR:
    '        Call GS_ErrorTerm("CNL2080_Closing")
    '    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ商品重複チェック
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPD030_2(ByVal pGoodsCD As String, ByRef pExists As Boolean) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPD030_2 = False
        pExists = False

        strSQL = ""
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM TPD030"
        strSQL = strSQL & " WHERE GOODSCD = '" & pGoodsCD & "'"
        strSQL = strSQL & " UNION "
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM TPD031"
        strSQL = strSQL & " WHERE GOODSCD = '" & pGoodsCD & "'"
        strSQL = strSQL & " UNION "
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM TPD032"
        strSQL = strSQL & " WHERE GOODSCD = '" & pGoodsCD & "'"
        strSQL = strSQL & " UNION "
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM TPD033"
        strSQL = strSQL & " WHERE GOODSCD = '" & pGoodsCD & "'"

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
        LF_GetTPD030_2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ登録マスタ更新処理(追加/削除処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPD030(ByVal pUpdKbn As String, ByVal pGoodsCD As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPD030 = False

        strSQL = ""
        Select Case pUpdKbn
            Case LC_UPDKBN_ADD
                strSQL = strSQL & "INSERT INTO TPD030 VALUES("
                strSQL = strSQL & "'" & pGoodsCD & "',"
                strSQL = strSQL & "'" & GC_UPDID & "',"
                strSQL = strSQL & "'" & Now & "'"
                strSQL = strSQL & ")"

            Case LC_UPDKBN_DEL
                strSQL = strSQL & "DELETE FROM TPD030"
                strSQL = strSQL & " WHERE GOODSCD = '" & pGoodsCD & "'"

            Case Else
                Exit Function

        End Select

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPD030 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ登録マスタ更新処理(追加/削除処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPD031(ByVal pUpdKbn As String, ByVal pGoodsCD As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPD031 = False

        strSQL = ""
        Select Case pUpdKbn
            Case LC_UPDKBN_ADD
                strSQL = strSQL & "INSERT INTO TPD031 VALUES("
                strSQL = strSQL & "'" & pGoodsCD & "',"
                strSQL = strSQL & "'" & GC_UPDID & "',"
                strSQL = strSQL & "'" & Now & "'"
                strSQL = strSQL & ")"

            Case LC_UPDKBN_DEL
                strSQL = strSQL & "DELETE FROM TPD031"
                strSQL = strSQL & " WHERE GOODSCD = '" & pGoodsCD & "'"

            Case Else
                Exit Function

        End Select

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPD031 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ登録マスタ更新処理(追加/削除処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPD032(ByVal pUpdKbn As String, ByVal pGoodsCD As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPD032 = False

        strSQL = ""
        Select Case pUpdKbn
            Case LC_UPDKBN_ADD
                strSQL = strSQL & "INSERT INTO TPD032 VALUES("
                strSQL = strSQL & "'" & pGoodsCD & "',"
                strSQL = strSQL & "'" & GC_UPDID & "',"
                strSQL = strSQL & "'" & Now & "'"
                strSQL = strSQL & ")"

            Case LC_UPDKBN_DEL
                strSQL = strSQL & "DELETE FROM TPD032"
                strSQL = strSQL & " WHERE GOODSCD = '" & pGoodsCD & "'"

            Case Else
                Exit Function

        End Select

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPD032 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ登録マスタ更新処理(追加/削除処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPD033(ByVal pUpdKbn As String, ByVal pGoodsCD As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPD033 = False

        strSQL = ""
        Select Case pUpdKbn
            Case LC_UPDKBN_ADD
                strSQL = strSQL & "INSERT INTO TPD033 VALUES("
                strSQL = strSQL & "'" & pGoodsCD & "',"
                strSQL = strSQL & "'" & GC_UPDID & "',"
                strSQL = strSQL & "'" & Now & "'"
                strSQL = strSQL & ")"

            Case LC_UPDKBN_DEL
                strSQL = strSQL & "DELETE FROM TPD033"
                strSQL = strSQL & " WHERE GOODSCD = '" & pGoodsCD & "'"

            Case Else
                Exit Function

        End Select

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPD033 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済みコメントオプションドラッグドロップ処理（パターン１）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SoldOutList_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_SoldOutList.ItemDrag
        ' ドラッグ処理開始
        L_blnDMode = "1"
        lsv_SoldOutList.DoDragDrop(lsv_SoldOutList.SelectedItems, DragDropEffects.Copy)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済みコメントオプションドラッグドロップ処理（パターン２）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SoldOutList2_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_SoldOutList2.ItemDrag
        ' ドラッグ処理開始
        L_blnDMode = "2"
        lsv_SoldOutList2.DoDragDrop(lsv_SoldOutList2.SelectedItems, DragDropEffects.Copy)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済みコメントオプションドラッグドロップ処理（パターン３）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SoldOutList3_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_SoldOutList3.ItemDrag
        ' ドラッグ処理開始
        L_blnDMode = "3"
        lsv_SoldOutList3.DoDragDrop(lsv_SoldOutList3.SelectedItems, DragDropEffects.Copy)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済みコメントオプションドラッグドロップ処理（パターン４）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SoldOutList4_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_SoldOutList4.ItemDrag
        ' ドラッグ処理開始
        L_blnDMode = "4"
        lsv_SoldOutList4.DoDragDrop(lsv_SoldOutList4.SelectedItems, DragDropEffects.Copy)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済みコメントオプションドラッグドロップ処理（パターン１）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SoldOutList_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_SoldOutList.DragEnter
        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済みコメントオプションドラッグドロップ処理（パターン２）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SoldOutList2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_SoldOutList2.DragEnter
        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済みコメントオプションドラッグドロップ処理（パターン３）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SoldOutList3_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_SoldOutList3.DragEnter
        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済みコメントオプションドラッグドロップ処理（パターン４）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SoldOutList4_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_SoldOutList4.DragEnter
        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済みコメントオプションドラッグドロップ処理（パターン１）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SoldOutList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_SoldOutList.DragDrop

        If L_blnDMode = "1" Then
            Exit Sub
        End If

        If Not e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then
            Exit Sub
        End If

        Select Case L_blnDMode
            Case "2"
                Call LS_RemoveItems2(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
            Case "3"
                Call LS_RemoveItems3(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
            Case "4"
                Call LS_RemoveItems4(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
            Case "0"

        End Select

        Call LS_AddItems(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))

        Call LS_SetSoldOutGoodsList()
        Call LS_SetSoldOutGoodsList2()
        Call LS_SetSoldOutGoodsList3()
        Call LS_SetSoldOutGoodsList4()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済みコメントオプションドラッグドロップ処理（パターン２）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SoldOutList2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_SoldOutList2.DragDrop

        If L_blnDMode = "2" Then
            Exit Sub
        End If

        If Not e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then
            Exit Sub
        End If

        Select Case L_blnDMode
            Case "1"
                Call LS_RemoveItems(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
            Case "3"
                Call LS_RemoveItems3(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
            Case "4"
                Call LS_RemoveItems4(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
            Case "0"

        End Select

        Call LS_AddItems2(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))

        Call LS_SetSoldOutGoodsList()
        Call LS_SetSoldOutGoodsList2()
        Call LS_SetSoldOutGoodsList3()
        Call LS_SetSoldOutGoodsList4()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済みコメントオプションドラッグドロップ処理（パターン３）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SoldOutList3_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_SoldOutList3.DragDrop

        If L_blnDMode = "3" Then
            Exit Sub
        End If

        If Not e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then
            Exit Sub
        End If

        Select Case L_blnDMode
            Case "1"
                Call LS_RemoveItems(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
            Case "2"
                Call LS_RemoveItems2(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
            Case "4"
                Call LS_RemoveItems4(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
            Case "0"

        End Select

        Call LS_AddItems3(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))

        Call LS_SetSoldOutGoodsList()
        Call LS_SetSoldOutGoodsList2()
        Call LS_SetSoldOutGoodsList3()
        Call LS_SetSoldOutGoodsList4()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済みコメントオプションドラッグドロップ処理（パターン４）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SoldOutList4_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_SoldOutList4.DragDrop

        If L_blnDMode = "4" Then
            Exit Sub
        End If

        If Not e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then
            Exit Sub
        End If

        Select Case L_blnDMode
            Case "1"
                Call LS_RemoveItems(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
            Case "2"
                Call LS_RemoveItems2(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
            Case "3"
                Call LS_RemoveItems3(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
            Case "0"

        End Select

        Call LS_AddItems4(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))

        Call LS_SetSoldOutGoodsList()
        Call LS_SetSoldOutGoodsList2()
        Call LS_SetSoldOutGoodsList3()
        Call LS_SetSoldOutGoodsList4()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：コメントオプション一覧ドラッグドロップ処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_GoodsList_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_GoodsList.ItemDrag
        ' ドラッグ処理開始
        L_blnDMode = "0"
        lsv_SoldOutList.DoDragDrop(lsv_GoodsList.SelectedItems, DragDropEffects.Copy)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：コメントオプション一覧ドラッグドロップ処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_GoodsList_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_GoodsList.DragEnter
        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：コメントオプション一覧ドラッグドロップ処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_GoodsList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_GoodsList.DragDrop

        If L_blnDMode = "0" Then
            Exit Sub
        End If

        If Not e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then
            Exit Sub
        End If

        Select Case L_blnDMode
            Case "1"
                Call LS_RemoveItems(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
            Case "2"
                Call LS_RemoveItems2(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
            Case "3"
                Call LS_RemoveItems3(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
            Case "4"
                Call LS_RemoveItems4(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
        End Select

        Call LS_SetSoldOutGoodsList()
        Call LS_SetSoldOutGoodsList2()
        Call LS_SetSoldOutGoodsList3()
        Call LS_SetSoldOutGoodsList4()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：コメントオプション追加処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_AddItems(ByVal pTargetData As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Integer
        Dim blnExists As Boolean

        If pTargetData.Count = 0 Then
            Exit Sub
        End If

        lngCnt = 0
        While lngCnt < pTargetData.Count
            '------------------------------
            ' 品切れ商品重複チェック
            '------------------------------
            If Not LF_GetTPD030_2(pTargetData.Item(lngCnt).Text, _
                                  blnExists) Then
                GoTo SYSTEM_ERROR
            End If

            If Not blnExists Then
                '------------------------------
                ' ＤＢ更新処理
                '------------------------------
                If Not LF_UpdTPD030(LC_UPDKBN_ADD, _
                                    Trim$(pTargetData.Item(lngCnt).Text)) Then
                    GoTo SYSTEM_ERROR
                End If

            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' 品切れ商品一覧更新
        '------------------------------
        'Call LS_SetSoldOutGoodsList()

        'L_blnEditFlg = True
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AddItems")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：コメントオプション追加処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_AddItems2(ByVal pTargetData As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Integer
        Dim blnExists As Boolean

        If pTargetData.Count = 0 Then
            Exit Sub
        End If

        lngCnt = 0
        While lngCnt < pTargetData.Count
            '------------------------------
            ' 品切れ商品重複チェック
            '------------------------------
            If Not LF_GetTPD030_2(pTargetData.Item(lngCnt).Text, _
                                  blnExists) Then
                GoTo SYSTEM_ERROR
            End If

            If Not blnExists Then
                '------------------------------
                ' ＤＢ更新処理
                '------------------------------
                If Not LF_UpdTPD031(LC_UPDKBN_ADD, _
                                    Trim$(pTargetData.Item(lngCnt).Text)) Then
                    GoTo SYSTEM_ERROR
                End If

            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' 品切れ商品一覧更新
        '------------------------------
        'Call LS_SetSoldOutGoodsList2()

        'L_blnEditFlg = True
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AddItems2")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：コメントオプション追加処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_AddItems3(ByVal pTargetData As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Integer
        Dim blnExists As Boolean

        If pTargetData.Count = 0 Then
            Exit Sub
        End If

        lngCnt = 0
        While lngCnt < pTargetData.Count
            '------------------------------
            ' 品切れ商品重複チェック
            '------------------------------
            If Not LF_GetTPD030_2(pTargetData.Item(lngCnt).Text, _
                                  blnExists) Then
                GoTo SYSTEM_ERROR
            End If

            If Not blnExists Then
                '------------------------------
                ' ＤＢ更新処理
                '------------------------------
                If Not LF_UpdTPD032(LC_UPDKBN_ADD, _
                                    Trim$(pTargetData.Item(lngCnt).Text)) Then
                    GoTo SYSTEM_ERROR
                End If

            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' 品切れ商品一覧更新
        '------------------------------
        'Call LS_SetSoldOutGoodsList3()

        'L_blnEditFlg = True
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AddItems3")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：コメントオプション追加処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_AddItems4(ByVal pTargetData As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Integer
        Dim blnExists As Boolean

        If pTargetData.Count = 0 Then
            Exit Sub
        End If

        lngCnt = 0
        While lngCnt < pTargetData.Count
            '------------------------------
            ' 品切れ商品重複チェック
            '------------------------------
            If Not LF_GetTPD030_2(pTargetData.Item(lngCnt).Text, _
                                  blnExists) Then
                GoTo SYSTEM_ERROR
            End If

            If Not blnExists Then
                '------------------------------
                ' ＤＢ更新処理
                '------------------------------
                If Not LF_UpdTPD033(LC_UPDKBN_ADD, _
                                    Trim$(pTargetData.Item(lngCnt).Text)) Then
                    GoTo SYSTEM_ERROR
                End If

            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' 品切れ商品一覧更新
        '------------------------------
        'Call LS_SetSoldOutGoodsList4()

        'L_blnEditFlg = True
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AddItems4")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ商品解除処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_RemoveItems(ByVal pTargetData As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Integer

        If pTargetData.Count = 0 Then
            Exit Sub
        End If

        lngCnt = 0
        While lngCnt < pTargetData.Count
            '------------------------------
            ' ＤＢ更新処理
            '------------------------------
            If Not LF_UpdTPD030(LC_UPDKBN_DEL, _
                                Trim$(pTargetData.Item(lngCnt).Text)) Then
                GoTo SYSTEM_ERROR
            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' 品切れ商品一覧更新
        '------------------------------
        'Call LS_SetSoldOutGoodsList()

        'L_blnEditFlg = True
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_RemoveItems")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ商品解除処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_RemoveItems2(ByVal pTargetData As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Integer

        If pTargetData.Count = 0 Then
            Exit Sub
        End If

        lngCnt = 0
        While lngCnt < pTargetData.Count
            '------------------------------
            ' ＤＢ更新処理
            '------------------------------
            If Not LF_UpdTPD031(LC_UPDKBN_DEL, _
                                Trim$(pTargetData.Item(lngCnt).Text)) Then
                GoTo SYSTEM_ERROR
            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' 品切れ商品一覧更新
        '------------------------------
        'Call LS_SetSoldOutGoodsList2()

        'L_blnEditFlg = True
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_RemoveItems2")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ商品解除処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_RemoveItems3(ByVal pTargetData As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Integer

        If pTargetData.Count = 0 Then
            Exit Sub
        End If

        lngCnt = 0
        While lngCnt < pTargetData.Count
            '------------------------------
            ' ＤＢ更新処理
            '------------------------------
            If Not LF_UpdTPD032(LC_UPDKBN_DEL, _
                                Trim$(pTargetData.Item(lngCnt).Text)) Then
                GoTo SYSTEM_ERROR
            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' 品切れ商品一覧更新
        '------------------------------
        'Call LS_SetSoldOutGoodsList3()

        'L_blnEditFlg = True
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_RemoveItems3")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ商品解除処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_RemoveItems4(ByVal pTargetData As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Integer

        If pTargetData.Count = 0 Then
            Exit Sub
        End If

        lngCnt = 0
        While lngCnt < pTargetData.Count
            '------------------------------
            ' ＤＢ更新処理
            '------------------------------
            If Not LF_UpdTPD033(LC_UPDKBN_DEL, _
                                Trim$(pTargetData.Item(lngCnt).Text)) Then
                GoTo SYSTEM_ERROR
            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' 品切れ商品一覧更新
        '------------------------------
        'Call LS_SetSoldOutGoodsList4()

        'L_blnEditFlg = True
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_RemoveItems4")
    End Sub


    ' --------------------------------------------------------------------------------
    ' 　機　　能：コメントオプション名称検索テキストボックス内 Enterキー押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_Search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call LS_SetGoodsList()
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：コメントオプション名称検索テキストボックス入力時処理
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

        Call LS_SetGoodsList()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：追加ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LS_AddItems(lsv_GoodsList.SelectedItems)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：解除ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Clr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LS_RemoveItems(lsv_SoldOutList.SelectedItems)
    End Sub
End Class
