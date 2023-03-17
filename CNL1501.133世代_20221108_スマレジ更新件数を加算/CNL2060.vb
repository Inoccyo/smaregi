' --------------------------------------------------------------------------------
' 　機　　能：CrossNavi - オプション登録画面
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
' --------------------------------------------------------------------------------
Public Class CNL2060
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
    Friend WithEvents lsv_SelComOptList As System.Windows.Forms.ListView
    Friend WithEvents lsv_ComOptList As System.Windows.Forms.ListView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_GuideNM As System.Windows.Forms.TextBox
    Friend WithEvents ImageList3 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList4 As System.Windows.Forms.ImageList
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents btn_Down As System.Windows.Forms.Button
    Friend WithEvents btn_Up As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lsv_OptList As System.Windows.Forms.ListView
    Friend WithEvents btn_DelOp As System.Windows.Forms.Button
    Friend WithEvents btn_AddOp As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lsv_SetList As System.Windows.Forms.ListView
    Friend WithEvents txt_GuideNM_B As System.Windows.Forms.TextBox
    Friend WithEvents txt_GuideNM_A As System.Windows.Forms.TextBox
    Friend WithEvents LabelMenuLanguage3 As System.Windows.Forms.Label
    Friend WithEvents LabelMenuLanguage2 As System.Windows.Forms.Label
    Friend WithEvents LabelMenuLanguage1 As System.Windows.Forms.Label
    Friend WithEvents txt_GuideNM_C As System.Windows.Forms.TextBox
    Friend WithEvents LabelMenuLanguage4 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lsv_SubList As System.Windows.Forms.ListView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CNL2060))
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lsv_OptList = New System.Windows.Forms.ListView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.lsv_SubList = New System.Windows.Forms.ListView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lsv_SetList = New System.Windows.Forms.ListView
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.btn_DelOp = New System.Windows.Forms.Button
        Me.btn_AddOp = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_Down = New System.Windows.Forms.Button
        Me.btn_Up = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_Search = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_GuideNM_C = New System.Windows.Forms.TextBox
        Me.LabelMenuLanguage4 = New System.Windows.Forms.Label
        Me.txt_GuideNM_B = New System.Windows.Forms.TextBox
        Me.txt_GuideNM_A = New System.Windows.Forms.TextBox
        Me.LabelMenuLanguage3 = New System.Windows.Forms.Label
        Me.LabelMenuLanguage2 = New System.Windows.Forms.Label
        Me.LabelMenuLanguage1 = New System.Windows.Forms.Label
        Me.txt_GuideNM = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lsv_ComOptList = New System.Windows.Forms.ListView
        Me.lsv_SelComOptList = New System.Windows.Forms.ListView
        Me.ImageList4 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.MenuItem2.Text = "オプション登録"
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
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btn_DelOp)
        Me.Panel1.Controls.Add(Me.btn_AddOp)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_Down)
        Me.Panel1.Controls.Add(Me.btn_Up)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_Search)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lsv_ComOptList)
        Me.Panel1.Controls.Add(Me.lsv_SelComOptList)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 232
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(208, 111)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(390, 230)
        Me.TabControl1.TabIndex = 256
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.lsv_OptList)
        Me.TabPage1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(382, 200)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "コメント指示"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lsv_OptList
        '
        Me.lsv_OptList.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ListViewItem1.StateImageIndex = 0
        ListViewItem1.UseItemStyleForSubItems = False
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.StateImageIndex = 0
        Me.lsv_OptList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.lsv_OptList.Location = New System.Drawing.Point(1, 1)
        Me.lsv_OptList.MultiSelect = False
        Me.lsv_OptList.Name = "lsv_OptList"
        Me.lsv_OptList.Size = New System.Drawing.Size(376, 194)
        Me.lsv_OptList.TabIndex = 250
        Me.lsv_OptList.UseCompatibleStateImageBehavior = False
        Me.lsv_OptList.View = System.Windows.Forms.View.Details
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lsv_SubList)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(382, 200)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "サブコメント"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lsv_SubList
        '
        Me.lsv_SubList.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ListViewItem4.StateImageIndex = 0
        ListViewItem4.UseItemStyleForSubItems = False
        ListViewItem5.StateImageIndex = 0
        ListViewItem6.StateImageIndex = 0
        Me.lsv_SubList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4, ListViewItem5, ListViewItem6})
        Me.lsv_SubList.Location = New System.Drawing.Point(1, 1)
        Me.lsv_SubList.MultiSelect = False
        Me.lsv_SubList.Name = "lsv_SubList"
        Me.lsv_SubList.Size = New System.Drawing.Size(376, 194)
        Me.lsv_SubList.TabIndex = 251
        Me.lsv_SubList.UseCompatibleStateImageBehavior = False
        Me.lsv_SubList.View = System.Windows.Forms.View.Details
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.lsv_SetList)
        Me.TabPage2.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(382, 200)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "セット指示"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lsv_SetList
        '
        Me.lsv_SetList.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ListViewItem7.StateImageIndex = 0
        ListViewItem7.UseItemStyleForSubItems = False
        ListViewItem8.StateImageIndex = 0
        ListViewItem9.StateImageIndex = 0
        Me.lsv_SetList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem7, ListViewItem8, ListViewItem9})
        Me.lsv_SetList.Location = New System.Drawing.Point(1, 1)
        Me.lsv_SetList.MultiSelect = False
        Me.lsv_SetList.Name = "lsv_SetList"
        Me.lsv_SetList.Size = New System.Drawing.Size(376, 194)
        Me.lsv_SetList.TabIndex = 251
        Me.lsv_SetList.UseCompatibleStateImageBehavior = False
        Me.lsv_SetList.View = System.Windows.Forms.View.Details
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(615, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 30)
        Me.Label4.TabIndex = 255
        Me.Label4.Text = "新しいコメントオプションは" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "商品登録機能より追加してください"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label25.Image = CType(resources.GetObject("Label25.Image"), System.Drawing.Image)
        Me.Label25.Location = New System.Drawing.Point(634, 265)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(353, 30)
        Me.Label25.TabIndex = 254
        Me.Label25.Text = "オプションに設定するコメントを「コメントオプション」から選択し" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "「登録済みコメントオプション」へドラッグしてください"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(204, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(794, 1)
        Me.Label11.TabIndex = 253
        '
        'btn_DelOp
        '
        Me.btn_DelOp.BackColor = System.Drawing.SystemColors.Control
        Me.btn_DelOp.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_DelOp.Location = New System.Drawing.Point(414, 10)
        Me.btn_DelOp.Name = "btn_DelOp"
        Me.btn_DelOp.Size = New System.Drawing.Size(180, 50)
        Me.btn_DelOp.TabIndex = 252
        Me.btn_DelOp.Text = "選択中のオプション削除"
        Me.btn_DelOp.UseVisualStyleBackColor = False
        '
        'btn_AddOp
        '
        Me.btn_AddOp.BackColor = System.Drawing.SystemColors.Control
        Me.btn_AddOp.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_AddOp.Location = New System.Drawing.Point(219, 10)
        Me.btn_AddOp.Name = "btn_AddOp"
        Me.btn_AddOp.Size = New System.Drawing.Size(180, 50)
        Me.btn_AddOp.TabIndex = 251
        Me.btn_AddOp.Text = "オプション追加"
        Me.btn_AddOp.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(205, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 16)
        Me.Label2.TabIndex = 249
        Me.Label2.Text = "■ オプションガイダンス一覧"
        '
        'btn_Down
        '
        Me.btn_Down.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Down.Location = New System.Drawing.Point(416, 381)
        Me.btn_Down.Name = "btn_Down"
        Me.btn_Down.Size = New System.Drawing.Size(142, 28)
        Me.btn_Down.TabIndex = 248
        Me.btn_Down.Text = "下へ移動"
        Me.btn_Down.UseVisualStyleBackColor = False
        '
        'btn_Up
        '
        Me.btn_Up.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Up.Location = New System.Drawing.Point(245, 381)
        Me.btn_Up.Name = "btn_Up"
        Me.btn_Up.Size = New System.Drawing.Size(142, 28)
        Me.btn_Up.TabIndex = 247
        Me.btn_Up.Text = "上へ移動"
        Me.btn_Up.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(634, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 24)
        Me.Label7.TabIndex = 244
        Me.Label7.Text = "商品検索"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(749, 302)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(192, 22)
        Me.txt_Search.TabIndex = 6
        Me.txt_Search.Text = "TextBox1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.txt_GuideNM_C)
        Me.GroupBox1.Controls.Add(Me.LabelMenuLanguage4)
        Me.GroupBox1.Controls.Add(Me.txt_GuideNM_B)
        Me.GroupBox1.Controls.Add(Me.txt_GuideNM_A)
        Me.GroupBox1.Controls.Add(Me.LabelMenuLanguage3)
        Me.GroupBox1.Controls.Add(Me.LabelMenuLanguage2)
        Me.GroupBox1.Controls.Add(Me.LabelMenuLanguage1)
        Me.GroupBox1.Controls.Add(Me.txt_GuideNM)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(618, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 160)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "オプション設定"
        '
        'txt_GuideNM_C
        '
        Me.txt_GuideNM_C.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_GuideNM_C.Location = New System.Drawing.Point(106, 132)
        Me.txt_GuideNM_C.Name = "txt_GuideNM_C"
        Me.txt_GuideNM_C.Size = New System.Drawing.Size(273, 22)
        Me.txt_GuideNM_C.TabIndex = 251
        '
        'LabelMenuLanguage4
        '
        Me.LabelMenuLanguage4.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelMenuLanguage4.Image = Global.CNL1501.My.Resources.Resources.back2
        Me.LabelMenuLanguage4.Location = New System.Drawing.Point(20, 132)
        Me.LabelMenuLanguage4.Name = "LabelMenuLanguage4"
        Me.LabelMenuLanguage4.Size = New System.Drawing.Size(86, 22)
        Me.LabelMenuLanguage4.TabIndex = 250
        Me.LabelMenuLanguage4.Text = "韓国語"
        Me.LabelMenuLanguage4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_GuideNM_B
        '
        Me.txt_GuideNM_B.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_GuideNM_B.Location = New System.Drawing.Point(106, 100)
        Me.txt_GuideNM_B.Name = "txt_GuideNM_B"
        Me.txt_GuideNM_B.Size = New System.Drawing.Size(273, 22)
        Me.txt_GuideNM_B.TabIndex = 249
        '
        'txt_GuideNM_A
        '
        Me.txt_GuideNM_A.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_GuideNM_A.Location = New System.Drawing.Point(106, 68)
        Me.txt_GuideNM_A.Name = "txt_GuideNM_A"
        Me.txt_GuideNM_A.Size = New System.Drawing.Size(273, 22)
        Me.txt_GuideNM_A.TabIndex = 248
        '
        'LabelMenuLanguage3
        '
        Me.LabelMenuLanguage3.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelMenuLanguage3.Image = Global.CNL1501.My.Resources.Resources.back2
        Me.LabelMenuLanguage3.Location = New System.Drawing.Point(20, 100)
        Me.LabelMenuLanguage3.Name = "LabelMenuLanguage3"
        Me.LabelMenuLanguage3.Size = New System.Drawing.Size(86, 22)
        Me.LabelMenuLanguage3.TabIndex = 247
        Me.LabelMenuLanguage3.Text = "中国語"
        Me.LabelMenuLanguage3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMenuLanguage2
        '
        Me.LabelMenuLanguage2.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelMenuLanguage2.Image = Global.CNL1501.My.Resources.Resources.back2
        Me.LabelMenuLanguage2.Location = New System.Drawing.Point(20, 68)
        Me.LabelMenuLanguage2.Name = "LabelMenuLanguage2"
        Me.LabelMenuLanguage2.Size = New System.Drawing.Size(86, 22)
        Me.LabelMenuLanguage2.TabIndex = 246
        Me.LabelMenuLanguage2.Text = "英　語"
        Me.LabelMenuLanguage2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMenuLanguage1
        '
        Me.LabelMenuLanguage1.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelMenuLanguage1.Image = Global.CNL1501.My.Resources.Resources.back2
        Me.LabelMenuLanguage1.Location = New System.Drawing.Point(20, 36)
        Me.LabelMenuLanguage1.Name = "LabelMenuLanguage1"
        Me.LabelMenuLanguage1.Size = New System.Drawing.Size(86, 22)
        Me.LabelMenuLanguage1.TabIndex = 245
        Me.LabelMenuLanguage1.Text = "日本語"
        Me.LabelMenuLanguage1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_GuideNM
        '
        Me.txt_GuideNM.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_GuideNM.Location = New System.Drawing.Point(106, 36)
        Me.txt_GuideNM.Name = "txt_GuideNM"
        Me.txt_GuideNM.Size = New System.Drawing.Size(273, 22)
        Me.txt_GuideNM.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 16)
        Me.Label1.TabIndex = 244
        Me.Label1.Text = "ガイダンス名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(615, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(228, 16)
        Me.Label5.TabIndex = 235
        Me.Label5.Text = "■ オプション一覧"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(205, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(306, 22)
        Me.Label3.TabIndex = 234
        Me.Label3.Text = "■ 登録済みコメントオプション一覧"
        '
        'lsv_ComOptList
        '
        Me.lsv_ComOptList.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_ComOptList.Location = New System.Drawing.Point(618, 330)
        Me.lsv_ComOptList.MultiSelect = False
        Me.lsv_ComOptList.Name = "lsv_ComOptList"
        Me.lsv_ComOptList.Size = New System.Drawing.Size(390, 322)
        Me.lsv_ComOptList.TabIndex = 10
        Me.lsv_ComOptList.UseCompatibleStateImageBehavior = False
        Me.lsv_ComOptList.View = System.Windows.Forms.View.Details
        '
        'lsv_SelComOptList
        '
        Me.lsv_SelComOptList.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        ListViewItem10.StateImageIndex = 0
        ListViewItem10.UseItemStyleForSubItems = False
        ListViewItem11.StateImageIndex = 0
        ListViewItem12.StateImageIndex = 0
        Me.lsv_SelComOptList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem10, ListViewItem11, ListViewItem12})
        Me.lsv_SelComOptList.Location = New System.Drawing.Point(208, 417)
        Me.lsv_SelComOptList.MultiSelect = False
        Me.lsv_SelComOptList.Name = "lsv_SelComOptList"
        Me.lsv_SelComOptList.Size = New System.Drawing.Size(390, 235)
        Me.lsv_SelComOptList.TabIndex = 4
        Me.lsv_SelComOptList.UseCompatibleStateImageBehavior = False
        Me.lsv_SelComOptList.View = System.Windows.Forms.View.Details
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
        'CNL2060
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1016, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.sts_Msg)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL2060"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNL2060"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Structure typItemInfo
        Dim strSCPNO As String
    End Structure

    ' 更新区分
    Private Const LC_UPDKBN_ADD As String = "ADD"
    Private Const LC_UPDKBN_DEL As String = "DEL"

    Private L_blnDMode As Boolean                                           ' True:追加操作 / False:削除操作
    Private L_blnEditFlg As Boolean

    Private L_sysType As String
    Private L_sysSetOptionType As String

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub CNL2060_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        L_sysType = Trim$(GF_GetAppInfo("SYS_TYPE"))
        L_sysSetOptionType = GF_GetAppInfo("SYS_SetOption_TYPE")

        '多言語機能対応
        If Not GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            LabelMenuLanguage1.Visible = False
            LabelMenuLanguage2.Visible = False
            LabelMenuLanguage3.Visible = False
            LabelMenuLanguage4.Visible = False
            txt_GuideNM_A.Visible = False
            txt_GuideNM_B.Visible = False
            txt_GuideNM_C.Visible = False
        Else
            LabelMenuLanguage1.Text = System.Configuration.ConfigurationManager.AppSettings("MenuLanguage1")
            LabelMenuLanguage2.Text = System.Configuration.ConfigurationManager.AppSettings("MenuLanguage2")
            LabelMenuLanguage3.Text = System.Configuration.ConfigurationManager.AppSettings("MenuLanguage3")
            LabelMenuLanguage4.Text = System.Configuration.ConfigurationManager.AppSettings("MenuLanguage4")
            If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) < 2 Then
                txt_GuideNM_B.Enabled = False
            End If
            If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) < 3 Then
                txt_GuideNM_C.Enabled = False
            End If
        End If

        'If Not Trim$(GF_GetAppInfo("SYS_TYPE")) = "2" Or Trim$(GF_GetAppInfo("SYS_TYPE")) = "3" Then
        '【メモ】2022/05/18 T.Yasushima
        '元のコードは（2 ではない）か（3）で TabPage2 を Remove していた。
        '正しくは（2 でも 3 でもない）の時に Remove(TabPage2)。
        'さらに（SYS_TYPE == 1 かつ SYS_SetOption_TYPE == 1）の時も Remove しないようになった。
        If L_sysType = "2" OrElse L_sysType = "3" Then
        ElseIf Not (L_sysType = "1" AndAlso L_sysSetOptionType = "1") Then
            TabControl1.TabPages.Remove(TabPage2)
        End If

        '------------------------------
        ' フォーム名称設定
        '------------------------------
        Me.Text = " オプション登録 "

        '---------------------------------
        '閉じるボタン非表示化
        '---------------------------------
        Me.ControlBox = False

        '------------------------------
        ' 初期化処理
        '------------------------------
        Call GS_StatusSetup(sts_Msg)
        Call LS_FormInit()

        L_blnEditFlg = False

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL2060_Load")
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
                With lsv_OptList
                    .Clear()
                    .FullRowSelect = True
                    .AllowDrop = True
                    .AllowColumnReorder = True
                    .HideSelection = False
                End With

                With lsv_SetList
                    .Clear()
                    .FullRowSelect = True
                    .AllowDrop = True
                    .AllowColumnReorder = True
                    .HideSelection = False
                End With

                With lsv_SubList
                    .Clear()
                    .FullRowSelect = True
                    .AllowDrop = True
                    .AllowColumnReorder = True
                    .HideSelection = False
                End With
            End If

            With lsv_SelComOptList
                .Clear()
                .FullRowSelect = True
                .AllowDrop = True
                .AllowColumnReorder = True
                .HideSelection = False
            End With

            txt_GuideNM.Clear()
            '多言語機能対応
            If GF_GetAppInfo2("MULTI_LING_USE") = 1 Then
                txt_GuideNM_A.Clear()
                txt_GuideNM_B.Clear()
                txt_GuideNM_C.Clear()
            End If

            If pInitialClear Then
                '------------------------------
                ' 商品一覧リスト
                '------------------------------
                With lsv_ComOptList
                    .Clear()
                    .FullRowSelect = True
                    .AllowDrop = True
                    .AllowColumnReorder = True
                    .HideSelection = False
                End With

                txt_Search.Clear()

                '------------------------------
                ' グループ一覧生成
                '------------------------------
                Call LS_SetGrpList()
                Call LS_SetItemList2()
            End If

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_FormInit")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：オプション一覧リスト表示処理
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
        Dim objData2 As New DataSet()
        Dim objData3 As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' 表示データ取得(コメント指示)
        '------------------------------
        If Not LF_GetTPM100_1(objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' 表示データ取得(セット指示)
        '------------------------------
        If Not LF_GetTPM100_4(objData2) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' 表示データ取得(サブコメント指示)
        '------------------------------
        If Not LF_GetTPM100_5(objData3) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            '------------------------------
            ' ＳＣＰテーブルオープン(コメント指示)
            '------------------------------
            lsv_OptList.Clear()
            With lsv_OptList.Columns
                .Add("ｵﾌﾟｼｮﾝ№", 100, HorizontalAlignment.Center)
                .Add("ｶﾞｲﾀﾞﾝｽ名", 250, HorizontalAlignment.Left)
            End With

            If Not IsNothing(objData.Tables("com")) Then
                lngCnt = 0
                While lngCnt < objData.Tables("com").Rows.Count
                    If Not GF_GetRows(objData, lngCnt, objRows) Then
                        Exit Sub
                    End If

                    objItem = New ListViewItem()
                    objItem.Text = Trim$(objRows("SCPNO"))
                    objItem.SubItems.Add(Trim$(objRows("GUIDE")))
                    '多言語機能対応
                    If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                        objItem.SubItems.Add(Trim$(objRows("GUIDE_A")))
                        objItem.SubItems.Add(Trim$(objRows("GUIDE_B")))
                        objItem.SubItems.Add(Trim$(objRows("GUIDE_C")))
                    End If

                    lsv_OptList.Items.Add(objItem)
                    objItem = Nothing

                    lngCnt = lngCnt + 1
                End While
            End If

            '------------------------------
            ' ＳＣＰテーブルオープン(セット指示)
            '------------------------------
            lsv_SetList.Clear()
            With lsv_SetList.Columns
                .Add("ｵﾌﾟｼｮﾝ№", 100, HorizontalAlignment.Center)
                .Add("ｶﾞｲﾀﾞﾝｽ名", 250, HorizontalAlignment.Left)
            End With

            If Not IsNothing(objData2.Tables("com")) Then
                lngCnt = 0
                objRows = Nothing
                While lngCnt < objData2.Tables("com").Rows.Count
                    If Not GF_GetRows(objData2, lngCnt, objRows) Then
                        Exit Sub
                    End If

                    objItem = New ListViewItem()
                    objItem.Text = Trim$(objRows("SCPNO"))
                    objItem.SubItems.Add(Trim$(objRows("GUIDE")))
                    '多言語機能対応
                    If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                        objItem.SubItems.Add(Trim$(objRows("GUIDE_A")))
                        objItem.SubItems.Add(Trim$(objRows("GUIDE_B")))
                        objItem.SubItems.Add(Trim$(objRows("GUIDE_C")))
                    End If
                    lsv_SetList.Items.Add(objItem)
                    objItem = Nothing

                    lngCnt = lngCnt + 1
                End While
            End If

            '------------------------------
            ' ＳＣＰテーブルオープン(サブコメント指示)
            '------------------------------
            lsv_SubList.Clear()
            With lsv_SubList.Columns
                .Add("ｵﾌﾟｼｮﾝ№", 100, HorizontalAlignment.Center)
                .Add("ｶﾞｲﾀﾞﾝｽ名", 250, HorizontalAlignment.Left)
            End With

            If Not IsNothing(objData3.Tables("com")) Then
                lngCnt = 0
                While lngCnt < objData3.Tables("com").Rows.Count
                    If Not GF_GetRows(objData3, lngCnt, objRows) Then
                        Exit Sub
                    End If

                    objItem = New ListViewItem()
                    objItem.Text = Trim$(objRows("SCPNO"))
                    objItem.SubItems.Add(Trim$(objRows("GUIDE")))
                    '多言語機能対応
                    If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                        objItem.SubItems.Add(Trim$(objRows("GUIDE_A")))
                        objItem.SubItems.Add(Trim$(objRows("GUIDE_B")))
                        objItem.SubItems.Add(Trim$(objRows("GUIDE_C")))
                    End If

                    lsv_SubList.Items.Add(objItem)
                    objItem = Nothing

                    lngCnt = lngCnt + 1
                End While
            End If

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetGrpList")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＳＣＰマスタ取得処理(オプション一覧 - コメント指示)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM100_1(ByRef pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM100_1 = False

        '------------------------------
        ' 商品グループマスタ取得
        '------------------------------
        strSQL = ""
        '多言語機能対応
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            strSQL = strSQL & "SELECT TPM100.*,"
            strSQL = strSQL & "       TPM100A.GUIDE AS GUIDE_A"
            strSQL = strSQL & "      ,TPM100B.GUIDE AS GUIDE_B"
            strSQL = strSQL & "      ,TPM100C.GUIDE AS GUIDE_C"
            strSQL = strSQL & "  FROM TPM100"
            strSQL = strSQL & "       LEFT JOIN TPM100A ON TPM100.SCPNO = TPM100A.SCPNO"
            strSQL = strSQL & "       LEFT JOIN TPM100B ON TPM100.SCPNO = TPM100B.SCPNO"
            strSQL = strSQL & "       LEFT JOIN TPM100C ON TPM100.SCPNO = TPM100C.SCPNO"
            strSQL = strSQL & "  WHERE TPM100.SCPNO >= '001'"
            strSQL = strSQL & "    AND TPM100.SCPNO <= '050'"
            strSQL = strSQL & " ORDER BY TPM100.SCPNO"
        Else
            strSQL = strSQL & "SELECT *"
            strSQL = strSQL & "  FROM TPM100"
            strSQL = strSQL & "  WHERE SCPNO >= '001'"
            strSQL = strSQL & "    AND SCPNO <= '050'"
            strSQL = strSQL & " ORDER BY SCPNO"
        End If


        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPM100_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＳＣＰマスタ取得処理(オプション一覧 - セット指示)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.04.16 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM100_4(ByRef pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM100_4 = False

        '------------------------------
        ' 商品グループマスタ取得
        '------------------------------
        strSQL = ""
        '多言語機能対応
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            strSQL = strSQL & "SELECT TPM100.*,"
            strSQL = strSQL & "       TPM100A.GUIDE AS GUIDE_A"
            strSQL = strSQL & "      ,TPM100B.GUIDE AS GUIDE_B"
            strSQL = strSQL & "      ,TPM100C.GUIDE AS GUIDE_C"
            strSQL = strSQL & "  FROM TPM100"
            strSQL = strSQL & "       LEFT JOIN TPM100A ON TPM100.SCPNO = TPM100A.SCPNO"
            strSQL = strSQL & "       LEFT JOIN TPM100B ON TPM100.SCPNO = TPM100B.SCPNO"
            strSQL = strSQL & "       LEFT JOIN TPM100C ON TPM100.SCPNO = TPM100C.SCPNO"
            strSQL = strSQL & " WHERE TPM100.SCPNO >= '101'"
            strSQL = strSQL & "   AND TPM100.SCPNO <= '150'"
            strSQL = strSQL & " ORDER BY TPM100.SCPNO"
        Else
            strSQL = strSQL & "SELECT *"
            strSQL = strSQL & "  FROM TPM100"
            strSQL = strSQL & "  WHERE SCPNO >= '101'"
            strSQL = strSQL & "    AND SCPNO <= '150'"
            strSQL = strSQL & " ORDER BY SCPNO"
        End If

        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPM100_4 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＳＣＰマスタ取得処理(オプション一覧 - コメント指示)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM100_5(ByRef pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM100_5 = False

        '------------------------------
        ' 商品グループマスタ取得
        '------------------------------
        strSQL = ""
        '多言語機能対応
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            strSQL = strSQL & "SELECT TPM100.*,"
            strSQL = strSQL & "       TPM100A.GUIDE AS GUIDE_A"
            strSQL = strSQL & "      ,TPM100B.GUIDE AS GUIDE_B"
            strSQL = strSQL & "      ,TPM100C.GUIDE AS GUIDE_C"
            strSQL = strSQL & "  FROM TPM100"
            strSQL = strSQL & "       LEFT JOIN TPM100A ON TPM100.SCPNO = TPM100A.SCPNO"
            strSQL = strSQL & "       LEFT JOIN TPM100B ON TPM100.SCPNO = TPM100B.SCPNO"
            strSQL = strSQL & "       LEFT JOIN TPM100C ON TPM100.SCPNO = TPM100C.SCPNO"
            strSQL = strSQL & "  WHERE TPM100.SCPNO >= '051'"
            strSQL = strSQL & "    AND TPM100.SCPNO <= '100'"
            strSQL = strSQL & " ORDER BY TPM100.SCPNO"
        Else
            strSQL = strSQL & "SELECT *"
            strSQL = strSQL & "  FROM TPM100"
            strSQL = strSQL & "  WHERE SCPNO >= '051'"
            strSQL = strSQL & "    AND SCPNO <= '100'"
            strSQL = strSQL & " ORDER BY SCPNO"
        End If


        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPM100_5 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＳＣＰマスタ取得処理(登録済みコメントオプション一覧)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM100_2(ByVal pSCPNO As String, ByRef pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM100_2 = False

        '------------------------------
        ' 商品グループマスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM100.SCPNO,"
        strSQL = strSQL & "       TPM100.GUIDE,"
        strSQL = strSQL & "       SCP1.GOODSCD    AS SCP1CD,"
        strSQL = strSQL & "       SCP1.GOODSNMJ   AS SCP1NM,"
        strSQL = strSQL & "       SCP1.GOODSNMJ2  AS SCP1NM2,"
        strSQL = strSQL & "       SCP2.GOODSCD    AS SCP2CD,"
        strSQL = strSQL & "       SCP2.GOODSNMJ   AS SCP2NM,"
        strSQL = strSQL & "       SCP2.GOODSNMJ2  AS SCP2NM2,"
        strSQL = strSQL & "       SCP3.GOODSCD    AS SCP3CD,"
        strSQL = strSQL & "       SCP3.GOODSNMJ   AS SCP3NM,"
        strSQL = strSQL & "       SCP3.GOODSNMJ2  AS SCP3NM2,"
        strSQL = strSQL & "       SCP4.GOODSCD    AS SCP4CD,"
        strSQL = strSQL & "       SCP4.GOODSNMJ   AS SCP4NM,"
        strSQL = strSQL & "       SCP4.GOODSNMJ2  AS SCP4NM2,"
        strSQL = strSQL & "       SCP5.GOODSCD    AS SCP5CD,"
        strSQL = strSQL & "       SCP5.GOODSNMJ   AS SCP5NM,"
        strSQL = strSQL & "       SCP5.GOODSNMJ2  AS SCP5NM2,"
        strSQL = strSQL & "       SCP6.GOODSCD    AS SCP6CD,"
        strSQL = strSQL & "       SCP6.GOODSNMJ   AS SCP6NM,"
        strSQL = strSQL & "       SCP6.GOODSNMJ2  AS SCP6NM2,"
        strSQL = strSQL & "       SCP7.GOODSCD    AS SCP7CD,"
        strSQL = strSQL & "       SCP7.GOODSNMJ   AS SCP7NM,"
        strSQL = strSQL & "       SCP7.GOODSNMJ2  AS SCP7NM2,"
        strSQL = strSQL & "       SCP8.GOODSCD    AS SCP8CD,"
        strSQL = strSQL & "       SCP8.GOODSNMJ   AS SCP8NM,"
        strSQL = strSQL & "       SCP8.GOODSNMJ2  AS SCP8NM2,"
        strSQL = strSQL & "       SCP9.GOODSCD    AS SCP9CD,"
        strSQL = strSQL & "       SCP9.GOODSNMJ   AS SCP9NM,"
        strSQL = strSQL & "       SCP9.GOODSNMJ2  AS SCP9NM2,"
        strSQL = strSQL & "       SCP10.GOODSCD   AS SCP10CD,"
        strSQL = strSQL & "       SCP10.GOODSNMJ  AS SCP10NM,"
        strSQL = strSQL & "       SCP10.GOODSNMJ2 AS SCP10NM2,"
        strSQL = strSQL & "       SCP11.GOODSCD   AS SCP11CD,"
        strSQL = strSQL & "       SCP11.GOODSNMJ  AS SCP11NM,"
        strSQL = strSQL & "       SCP11.GOODSNMJ2 AS SCP11NM2,"
        strSQL = strSQL & "       SCP12.GOODSCD   AS SCP12CD,"
        strSQL = strSQL & "       SCP12.GOODSNMJ  AS SCP12NM,"
        strSQL = strSQL & "       SCP12.GOODSNMJ2 AS SCP12NM2,"
        strSQL = strSQL & "       SCP13.GOODSCD   AS SCP13CD,"
        strSQL = strSQL & "       SCP13.GOODSNMJ  AS SCP13NM,"
        strSQL = strSQL & "       SCP13.GOODSNMJ2 AS SCP13NM2,"
        strSQL = strSQL & "       SCP14.GOODSCD   AS SCP14CD,"
        strSQL = strSQL & "       SCP14.GOODSNMJ  AS SCP14NM,"
        strSQL = strSQL & "       SCP14.GOODSNMJ2 AS SCP14NM2,"
        strSQL = strSQL & "       SCP15.GOODSCD   AS SCP15CD,"
        strSQL = strSQL & "       SCP15.GOODSNMJ  AS SCP15NM,"
        strSQL = strSQL & "       SCP15.GOODSNMJ2 AS SCP15NM2,"
        strSQL = strSQL & "       SCP16.GOODSCD   AS SCP16CD,"
        strSQL = strSQL & "       SCP16.GOODSNMJ  AS SCP16NM,"
        strSQL = strSQL & "       SCP16.GOODSNMJ2 AS SCP16NM2"
        strSQL = strSQL & "  FROM TPM100 LEFT OUTER JOIN TPM010 SCP1"
        strSQL = strSQL & "                           ON SCP1.GOODSCD  = TPM100.GOODSCD1"
        strSQL = strSQL & "              LEFT OUTER JOIN TPM010 SCP2"
        strSQL = strSQL & "                           ON SCP2.GOODSCD  = TPM100.GOODSCD2"
        strSQL = strSQL & "              LEFT OUTER JOIN TPM010 SCP3"
        strSQL = strSQL & "                           ON SCP3.GOODSCD  = TPM100.GOODSCD3"
        strSQL = strSQL & "              LEFT OUTER JOIN TPM010 SCP4"
        strSQL = strSQL & "                           ON SCP4.GOODSCD  = TPM100.GOODSCD4"
        strSQL = strSQL & "              LEFT OUTER JOIN TPM010 SCP5"
        strSQL = strSQL & "                           ON SCP5.GOODSCD  = TPM100.GOODSCD5"
        strSQL = strSQL & "              LEFT OUTER JOIN TPM010 SCP6"
        strSQL = strSQL & "                           ON SCP6.GOODSCD  = TPM100.GOODSCD6"
        strSQL = strSQL & "              LEFT OUTER JOIN TPM010 SCP7"
        strSQL = strSQL & "                           ON SCP7.GOODSCD  = TPM100.GOODSCD7"
        strSQL = strSQL & "              LEFT OUTER JOIN TPM010 SCP8"
        strSQL = strSQL & "                           ON SCP8.GOODSCD  = TPM100.GOODSCD8"
        strSQL = strSQL & "              LEFT OUTER JOIN TPM010 SCP9"
        strSQL = strSQL & "                           ON SCP9.GOODSCD  = TPM100.GOODSCD9"
        strSQL = strSQL & "              LEFT OUTER JOIN TPM010 SCP10"
        strSQL = strSQL & "                           ON SCP10.GOODSCD = TPM100.GOODSCD10"
        strSQL = strSQL & "              LEFT OUTER JOIN TPM010 SCP11"
        strSQL = strSQL & "                           ON SCP11.GOODSCD = TPM100.GOODSCD11"
        strSQL = strSQL & "              LEFT OUTER JOIN TPM010 SCP12"
        strSQL = strSQL & "                           ON SCP12.GOODSCD = TPM100.GOODSCD12"
        strSQL = strSQL & "              LEFT OUTER JOIN TPM010 SCP13"
        strSQL = strSQL & "                           ON SCP13.GOODSCD = TPM100.GOODSCD13"
        strSQL = strSQL & "              LEFT OUTER JOIN TPM010 SCP14"
        strSQL = strSQL & "                           ON SCP14.GOODSCD = TPM100.GOODSCD14"
        strSQL = strSQL & "              LEFT OUTER JOIN TPM010 SCP15"
        strSQL = strSQL & "                           ON SCP15.GOODSCD = TPM100.GOODSCD15"
        strSQL = strSQL & "              LEFT OUTER JOIN TPM010 SCP16"
        strSQL = strSQL & "                           ON SCP16.GOODSCD = TPM100.GOODSCD16"
        strSQL = strSQL & " WHERE TPM100.SCPNO = '" & pSCPNO & "'"

        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPM100_2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＳＣＰマスタ取得処理(削除対象一覧)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM100_3(ByRef pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM100_3 = False

        '------------------------------
        ' 商品グループマスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT SCPNO,"
        strSQL = strSQL & "       GUIDE,"
        strSQL = strSQL & "       GOODSCD1"
        strSQL = strSQL & "  FROM TPM100"
        strSQL = strSQL & " WHERE GOODSCD1 = '0000'"

        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPM100_3 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品マスタ取得処理(コメントオプション一覧)
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

        '------------------------------
        ' 選択タブ判定("0"：コメント指示、"1"：セット指示)
        '------------------------------
        If TabControl1.SelectedIndex = 0 Then
            strSQL = strSQL & " WHERE STATUS  = '1'"
            strSQL = strSQL & "   AND GOODSCD > '9000'"
            strSQL = strSQL & "   AND GOODSCD < '9901'"
        Else
            strSQL = strSQL & " WHERE GOODSCD < '9901'"
        End If

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

    ' --------------------------------------------------------------------------------
    ' 　機　　能：オプショングループリスト選択時処理(コメント指示)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_OptList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_OptList.SelectedIndexChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection

        '------------------------------
        ' 選択項目取得
        '------------------------------
        Try
            objCollection = lsv_OptList.SelectedItems
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

                ''------------------------------
                '' ガイダンス名編集領域へ転記
                ''------------------------------
                txt_GuideNM.Text = .Item(0).SubItems.Item(1).Text
                '多言語機能対応
                If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                    txt_GuideNM_A.Text = .Item(0).SubItems.Item(2).Text
                    If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 1 Then
                        txt_GuideNM_B.Text = .Item(0).SubItems.Item(3).Text
                    End If
                    If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 2 Then
                        txt_GuideNM_C.Text = .Item(0).SubItems.Item(4).Text
                    End If
                End If

                '------------------------------
                ' 登録済みコメントオプション一覧生成
                '------------------------------
                Call LS_SetItemList(.Item(0).Text)

            End With
            Me.Cursor = Cursors.Default
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Me.Cursor = Cursors.Default
        Call GS_ErrorTerm("lsv_OptList_SelectedIndexChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：オプショングループリスト選択時処理(コメント指示)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SubList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_SubList.SelectedIndexChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection

        '------------------------------
        ' 選択項目取得
        '------------------------------
        Try
            objCollection = lsv_SubList.SelectedItems
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

                ''------------------------------
                '' ガイダンス名編集領域へ転記
                ''------------------------------
                txt_GuideNM.Text = .Item(0).SubItems.Item(1).Text
                '多言語機能対応
                If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                    txt_GuideNM_A.Text = .Item(0).SubItems.Item(2).Text
                    If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 1 Then
                        txt_GuideNM_B.Text = .Item(0).SubItems.Item(3).Text
                    End If
                    If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 2 Then
                        txt_GuideNM_C.Text = .Item(0).SubItems.Item(4).Text
                    End If
                End If

                '------------------------------
                ' 登録済みコメントオプション一覧生成
                '------------------------------
                Call LS_SetItemList(.Item(0).Text)

            End With
            Me.Cursor = Cursors.Default
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Me.Cursor = Cursors.Default
        Call GS_ErrorTerm("lsv_SubList_SelectedIndexChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：オプショングループリスト選択時処理(セット指示)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.04.16 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SetList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_SetList.SelectedIndexChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection

        '------------------------------
        ' 選択項目取得
        '------------------------------
        Try
            objCollection = lsv_SetList.SelectedItems
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

                ''------------------------------
                '' ガイダンス名編集領域へ転記
                ''------------------------------
                txt_GuideNM.Text = .Item(0).SubItems.Item(1).Text
                '多言語機能対応
                If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                    txt_GuideNM_A.Text = .Item(0).SubItems.Item(2).Text
                    If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 1 Then
                        txt_GuideNM_B.Text = .Item(0).SubItems.Item(3).Text
                    End If
                    If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 2 Then
                        txt_GuideNM_C.Text = .Item(0).SubItems.Item(4).Text
                    End If
                End If

                '------------------------------
                ' 登録済みコメントオプション一覧生成
                '------------------------------
                Call LS_SetItemList(.Item(0).Text)

            End With
            Me.Cursor = Cursors.Default
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Me.Cursor = Cursors.Default
        Call GS_ErrorTerm("lsv_SetList_SelectedIndexChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：タブ選択時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.04.16 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        '------------------------------
        ' 選択項目取得
        '------------------------------
        Try
            With lsv_SelComOptList
                .Clear()
                .FullRowSelect = True
                .AllowDrop = True
                .AllowColumnReorder = True
                .HideSelection = False
            End With

            txt_GuideNM.Clear()
            '多言語機能対応
            If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                txt_GuideNM_A.Clear()
                txt_GuideNM_B.Clear()
                txt_GuideNM_C.Clear()
            End If

            '------------------------------
            ' 商品一覧リスト
            '------------------------------
            With lsv_ComOptList
                .Clear()
                .FullRowSelect = True
                .AllowDrop = True
                .AllowColumnReorder = True
                .HideSelection = False
            End With

            txt_Search.Clear()

            '------------------------------
            ' グループ一覧生成
            '------------------------------
            Call LS_SetGrpList()
            Call LS_SetItemList2()

            Me.Cursor = Cursors.Default
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Me.Cursor = Cursors.Default
        Call GS_ErrorTerm("TabControl1_SelectedIndexChanged")
    End Sub


    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済みコメントオプショングリッド 表示値設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetItemList(ByVal pSCPNO As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim intCnt As Integer
        Dim objItem As ListViewItem
        Dim intMaxCnt As Integer

        '------------------------------
        ' 設定データ取得
        '------------------------------
        If Not LF_GetTPM100_2(pSCPNO, objData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            '------------------------------
            ' メニューテーブルオープン
            '------------------------------
            lsv_SelComOptList.Clear()
            With lsv_SelComOptList.Columns
                .Add("商品番号", 80, HorizontalAlignment.Center)
                .Add("商品名", 285, HorizontalAlignment.Left)
            End With

            If objData.Tables("com").Rows.Count = 0 Then
                GoTo SYSTEM_ERROR
            Else
                If Not GF_GetRows(objData, 0, objRows) Then
                    Exit Sub
                End If

                '------------------------------
                ' 選択タブ判定("0"：コメント指示、"1"：セット指示)
                '------------------------------
                intMaxCnt = 0
                If TabControl1.SelectedIndex = 0 Or TabControl1.SelectedIndex = 1 Then
                    intMaxCnt = CInt(GF_GetAppInfo("CMNT_MAX_CNT"))
                Else
                    intMaxCnt = 16
                End If

                For intCnt = 1 To intMaxCnt
                    If Not IsDBNull(objRows("SCP" & CStr(intCnt) & "CD")) Then
                        objItem = New ListViewItem()
                        objItem.Text = Trim$(objRows("SCP" & CStr(intCnt) & "CD"))
                        objItem.SubItems.Add(Trim$(objRows("SCP" & CStr(intCnt) & "NM")) & Trim$(objRows("SCP" & CStr(intCnt) & "NM2")))

                        lsv_SelComOptList.Items.Add(objItem)
                        objItem = Nothing
                    End If
                Next
            End If

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetItemList")
    End Sub


    ' --------------------------------------------------------------------------------
    ' 　機　　能：コメントオプション一覧グリッド 表示値設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetItemList2()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim objItem As ListViewItem
        Dim optvis As String
        Dim goodscode As Integer


        '------------------------------
        ' 設定データ取得
        '------------------------------
        If Not LF_GetTPM010(objData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            '------------------------------
            ' メニューテーブルオープン
            '------------------------------
            lsv_ComOptList.Clear()
            With lsv_ComOptList.Columns
                .Add("商品番号", 80, HorizontalAlignment.Center)
                .Add("商品名", 285, HorizontalAlignment.Left)
            End With

            If Not IsNothing(objData.Tables("com")) Then
                lngCnt = 0
                optvis = GF_GetAppInfo("CMNT_OPT_Visible")
                While lngCnt < objData.Tables("com").Rows.Count
                    If Not GF_GetRows(objData, lngCnt, objRows) Then
                        Exit Sub
                    End If
                    goodscode = Convert.ToInt32(Trim$(objRows("GOODSCD")))

                    If (optvis = "1" Or goodscode > 9000) Then 'Gert 11/26

                        objItem = New ListViewItem()
                        objItem.Text = Trim$(objRows("GOODSCD"))
                        objItem.SubItems.Add(Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2")))

                        lsv_ComOptList.Items.Add(objItem)
                        objItem = Nothing

                    End If
                    lngCnt = lngCnt + 1

                End While
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetItemList2")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：オプション追加ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_AddOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddOp.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objForm As New CNL2061()

        objForm.ShowDialog()
        Select Case objForm.DialogResult
            Case DialogResult.OK
                '------------------------------
                ' グループ一覧生成
                '------------------------------
                Call LS_FormInit()

                L_blnEditFlg = True
            Case DialogResult.Cancel
                ' 何もしない
            Case Else
                GoTo SYSTEM_ERROR
        End Select

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_AddOp_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：オプション削除ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_DelOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DelOp.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim udtInfo As typItemInfo

        '------------------------------
        ' 選択タブ判定("0"：コメント指示、"1"：セット指示)
        '------------------------------
        If TabControl1.SelectedIndex = 0 Then
            '------------------------------
            ' 削除グループコード取得(コメント指示)
            '------------------------------
            objCollection = lsv_OptList.SelectedItems
            With objCollection
                If .Count = 0 Then
                    Exit Sub
                End If

                If .Contains(.Item(0)) = False Then
                    Exit Sub
                End If

                udtInfo.strSCPNO = lsv_OptList.SelectedItems.Item(0).Text
            End With
        End If
        If TabControl1.SelectedIndex = 1 Then
            '------------------------------
            ' 削除グループコード取得(サブコメント指示)
            '------------------------------
            objCollection = lsv_SubList.SelectedItems
            With objCollection
                If .Count = 0 Then
                    Exit Sub
                End If

                If .Contains(.Item(0)) = False Then
                    Exit Sub
                End If

                udtInfo.strSCPNO = lsv_SubList.SelectedItems.Item(0).Text
            End With
        End If
        If TabControl1.SelectedIndex = 2 Then
            '------------------------------
            ' 削除グループコード取得(セット指示)
            '------------------------------
            objCollection = lsv_SetList.SelectedItems
            With objCollection
                If .Count = 0 Then
                    Exit Sub
                End If

                If .Contains(.Item(0)) = False Then
                    Exit Sub
                End If

                udtInfo.strSCPNO = lsv_SetList.SelectedItems.Item(0).Text
            End With
        End If

        If GF_Msg("", Replace(GF_GetMsg("Q05"), "@@@", objCollection.Item(0).SubItems.Item(1).Text), MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        Select Case LF_ChkDelMenu(udtInfo.strSCPNO, objCollection.Item(0).SubItems.Item(1).Text)
            Case CNL1920.FuncResult.CancelEnd
                Exit Sub
            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        If Not LF_UpdTPM100_1(udtInfo.strSCPNO) Then
            GoTo SYSTEM_ERROR
        End If

        If Not LF_UpdTPM010_3(udtInfo.strSCPNO) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' グループ一覧生成
        '------------------------------
        Call LS_FormInit()

        L_blnEditFlg = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_DelOp_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：オプション連鎖削除確認処理
    ' 　機能概要：オプション削除により、商品に割り当てたオプションが連鎖的に無効化してしまう場合の確認処理
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.03 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_ChkDelMenu(ByVal pScpNo As String, ByVal pGuideNm As String) As FuncResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_ChkDelMenu = CNL1920.FuncResult.UnusualEnd

        '------------------------------
        ' 連鎖無効化メニュー検索
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT  *"
        strSQL = strSQL & "  FROM  TPM010"
        strSQL = strSQL & " WHERE (SCPNO01 = '" & pScpNo & "'"
        strSQL = strSQL & "    OR  SCPNO02 = '" & pScpNo & "'"
        strSQL = strSQL & "    OR  SCPNO03 = '" & pScpNo & "'"
        strSQL = strSQL & "    OR  SCPNO04 = '" & pScpNo & "'"
        strSQL = strSQL & "    OR  SCPNO05 = '" & pScpNo & "'"
        strSQL = strSQL & "    OR  SCPNO06 = '" & pScpNo & "'"
        strSQL = strSQL & "    OR  SCPNO07 = '" & pScpNo & "'"
        strSQL = strSQL & "    OR  SCPNO08 = '" & pScpNo & "'"
        strSQL = strSQL & "    OR  SCPNO09 = '" & pScpNo & "'"
        strSQL = strSQL & "    OR  SCPNO10 = '" & pScpNo & "'"
        strSQL = strSQL & "    OR  SCPNO11 = '" & pScpNo & "'"
        strSQL = strSQL & "    OR  SCPNO12 = '" & pScpNo & "')"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count > 0 Then
            If Not GF_GetRows(objData, 0, objRows) Then
                Exit Function
            End If

            If GF_Msg("", "オプション【" & pGuideNm & "】は既に商品に割付されています。" & vbCrLf & "オプションを削除すると割付が強制解除されます。" & vbCrLf & "よろしいですか？", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.No Then
                LF_ChkDelMenu = CNL1920.FuncResult.CancelEnd
                Exit Function
            End If
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_ChkDelMenu = CNL1920.FuncResult.NormalEnd

    End Function

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
    Private Sub CNL2060_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        If L_blnEditFlg Then                                                ' 編集更新有無フラグ判定
            '    Select Case GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNoCancel)
            '        Case MsgBoxResult.Yes
            '            '------------------------------
            '            ' トランザクション確定
            '            '------------------------------
            '            If Not GF_CommitTrans() Then
            '                Call GF_RollbackTrans()
            '                GoTo SYSTEM_ERROR
            '            End If

            '------------------------------
            ' FUMENU更新
            '------------------------------
            If GF_GetAppInfo("OES_TOOL_VER_CNL1501") = "0" Then
                Call LS_UpdFUMENU()
            End If

            '------------------------------
            ' 無効オプション削除処理
            '------------------------------
            If LF_ChkOptEnabled() = CNL1920.FuncResult.UnusualEnd Then
                GoTo SYSTEM_ERROR
            End If

        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL2060_Closing")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：無効オプション削除処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_ChkOptEnabled() As FuncResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_ChkOptEnabled = CNL1920.FuncResult.UnusualEnd

        '------------------------------
        ' ＳＣＰマスタ取得
        '------------------------------
        If Not LF_GetTPM100_3(objData) Then
            Exit Function
        End If

        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If

            '------------------------------
            ' 無効オプション検出時
            '------------------------------
            Select Case GF_Msg("", "オプション【 " & Trim$(objRows("GUIDE")) & " 】にはコメントオプション未設定のため、強制削除します", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                Case MsgBoxResult.Ok
                    '------------------------------
                    ' 無効オプションを削除する
                    '------------------------------
                    If Not LF_UpdTPM100_1(Trim$(objRows("SCPNO"))) Then
                        LF_ChkOptEnabled = CNL1920.FuncResult.UnusualEnd
                        Exit Function
                    End If

                    If Not LF_UpdTPM010_3(Trim$(objRows("SCPNO"))) Then
                        LF_ChkOptEnabled = CNL1920.FuncResult.UnusualEnd
                        Exit Function
                    End If
                Case Else
                    LF_ChkOptEnabled = CNL1920.FuncResult.CancelEnd
                    Exit Function
            End Select

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_ChkOptEnabled = CNL1920.FuncResult.NormalEnd

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＦＵＭＥＮＵ更新処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_UpdFUMENU()

        '' ＳＴＮデータ出力処理
        'If Trim$(GF_GetAppInfo("SYS_TYPE")) = "2" Or Trim$(GF_GetAppInfo("SYS_TYPE")) = "3" Then
        If L_sysType = "2" Or L_sysType = "3" Then
            ''-- FUMENU存在チェック(OES_MENUTBL)
            'If Not System.IO.File.Exists(Trim$(GF_GetAppInfo("OES_PATH")) & "\" & Trim$(GF_GetAppInfo("OES_MENUTBL"))) Then
            '    GF_Msg("", "FUMENU パスを確認してください", MsgBoxStyle.OkOnly)
            '    Exit Sub
            'End If
            ''--- FUMENU更新
            'If GF_PutFUMENUData() = False Then
            '    Exit Sub
            'End If

            If GF_GetAppInfo("OES_TOOL_VER_CNL1501") = "0" Then
                ' ST-700-F以前のVerの場合
                '-- FSCP存在チェック(OES_SCPTBL)
                If Not System.IO.File.Exists(Trim$(GF_GetAppInfo("OES_PATH")) & "\" & Trim$(GF_GetAppInfo("OES_SCPTBL"))) Then
                    GF_Msg("", "FSCP パスを確認してください", MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
                '--- FSCP更新
                If GF_PutFSCPData() = False Then
                    Exit Sub
                End If

            Else

                '' (2012.5.21　修正)FScompassの場合、開店処理にて設定データ更新を行うよう変更
                ''--- MC_FSCP更新
                'If GF_PutFSCPData_DB() = False Then
                '    GF_Msg("", "POSデータ(FSCP)の更新に失敗しました。" & vbCrLf & "設定を見直してください。", MsgBoxStyle.OkOnly)
                '    Exit Sub
                'End If

            End If
        End If

    End Sub

    ' ------------------------------------------------------------------------------------------------------------------------------------------
    ' --- ＤＢ更新処理  ------------------------------------------------------------------------------------------------------------------------
    ' ------------------------------------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品グループマスタ／グループ内重複チェック
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM100_4(ByVal pScpNo As String, ByVal pGoodsCD As String, ByRef pExists As Boolean) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()


        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM100_4 = False
        pExists = False

        strSQL = ""
        strSQL = strSQL & "SELECT  *"
        strSQL = strSQL & "  FROM  TPM100"
        strSQL = strSQL & " WHERE  SCPNO     = '" & pScpNo & "'"
        strSQL = strSQL & "   AND (GOODSCD1  = '" & pGoodsCD & "'"
        strSQL = strSQL & "    OR  GOODSCD2  = '" & pGoodsCD & "'"
        strSQL = strSQL & "    OR  GOODSCD3  = '" & pGoodsCD & "'"
        strSQL = strSQL & "    OR  GOODSCD4  = '" & pGoodsCD & "'"
        strSQL = strSQL & "    OR  GOODSCD5  = '" & pGoodsCD & "'"
        strSQL = strSQL & "    OR  GOODSCD6  = '" & pGoodsCD & "'"
        strSQL = strSQL & "    OR  GOODSCD7  = '" & pGoodsCD & "'"
        strSQL = strSQL & "    OR  GOODSCD8  = '" & pGoodsCD & "'"
        strSQL = strSQL & "    OR  GOODSCD9  = '" & pGoodsCD & "'"
        strSQL = strSQL & "    OR  GOODSCD10 = '" & pGoodsCD & "'"
        strSQL = strSQL & "    OR  GOODSCD11 = '" & pGoodsCD & "'"
        strSQL = strSQL & "    OR  GOODSCD12 = '" & pGoodsCD & "'"
        strSQL = strSQL & "    OR  GOODSCD13 = '" & pGoodsCD & "'"
        strSQL = strSQL & "    OR  GOODSCD14 = '" & pGoodsCD & "'"
        strSQL = strSQL & "    OR  GOODSCD15 = '" & pGoodsCD & "'"
        strSQL = strSQL & "    OR  GOODSCD16 = '" & pGoodsCD & "')"

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
        LF_GetTPM100_4 = True
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：オプションマスタ更新処理(グループ追加/削除処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM100_1(ByVal pScpNo As String) As Boolean

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
        LF_UpdTPM100_1 = False

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "DELETE TPM100"
        strSQL = strSQL & " WHERE SCPNO = '" & pScpNo & "'"

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        '多言語機能対応
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            strSQL2 = ""
            strSQL2 = strSQL2 & "DELETE TPM100A"
            strSQL2 = strSQL2 & " WHERE SCPNO = '" & pScpNo & "'"

            If Not GF_UpdData(strSQL2) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            strSQL3 = ""
            strSQL3 = strSQL3 & "DELETE TPM100B"
            strSQL3 = strSQL3 & " WHERE SCPNO = '" & pScpNo & "'"

            If Not GF_UpdData(strSQL3) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            strSQL4 = ""
            strSQL4 = strSQL4 & "DELETE TPM100C"
            strSQL4 = strSQL4 & " WHERE SCPNO = '" & pScpNo & "'"

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
        LF_UpdTPM100_1 = True
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：オプションマスタ更新処理(グループ追加/削除処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM010_3(ByVal pScpNo As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM010_3 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM010"
        strSQL = strSQL & "   SET SCPNO01 = CASE WHEN SCPNO01 = '" & pScpNo & "'"
        strSQL = strSQL & "                      THEN '000'"
        strSQL = strSQL & "                 ELSE SCPNO01"
        strSQL = strSQL & "                 END,"
        strSQL = strSQL & "       SCPNO02 = CASE WHEN SCPNO02 = '" & pScpNo & "'"
        strSQL = strSQL & "                      THEN '000'"
        strSQL = strSQL & "                 ELSE SCPNO02"
        strSQL = strSQL & "                 END,"
        strSQL = strSQL & "       SCPNO03 = CASE WHEN SCPNO03 = '" & pScpNo & "'"
        strSQL = strSQL & "                      THEN '000'"
        strSQL = strSQL & "                 ELSE SCPNO03"
        strSQL = strSQL & "                 END,"
        strSQL = strSQL & "       SCPNO04 = CASE WHEN SCPNO04 = '" & pScpNo & "'"
        strSQL = strSQL & "                      THEN '000'"
        strSQL = strSQL & "                 ELSE SCPNO04"
        strSQL = strSQL & "                 END,"
        strSQL = strSQL & "       SCPNO05 = CASE WHEN SCPNO05 = '" & pScpNo & "'"
        strSQL = strSQL & "                      THEN '000'"
        strSQL = strSQL & "                 ELSE SCPNO05"
        strSQL = strSQL & "                 END,"
        strSQL = strSQL & "       SCPNO06 = CASE WHEN SCPNO06 = '" & pScpNo & "'"
        strSQL = strSQL & "                      THEN '000'"
        strSQL = strSQL & "                 ELSE SCPNO06"
        strSQL = strSQL & "                 END,"
        strSQL = strSQL & "       SCPNO07 = CASE WHEN SCPNO07 = '" & pScpNo & "'"
        strSQL = strSQL & "                      THEN '000'"
        strSQL = strSQL & "                 ELSE SCPNO07"
        strSQL = strSQL & "                 END,"
        strSQL = strSQL & "       SCPNO08 = CASE WHEN SCPNO08 = '" & pScpNo & "'"
        strSQL = strSQL & "                      THEN '000'"
        strSQL = strSQL & "                 ELSE SCPNO08"
        strSQL = strSQL & "                 END,"
        strSQL = strSQL & "       SCPNO09 = CASE WHEN SCPNO09 = '" & pScpNo & "'"
        strSQL = strSQL & "                      THEN '000'"
        strSQL = strSQL & "                 ELSE SCPNO09"
        strSQL = strSQL & "                 END,"
        strSQL = strSQL & "       SCPNO10 = CASE WHEN SCPNO10 = '" & pScpNo & "'"
        strSQL = strSQL & "                      THEN '000'"
        strSQL = strSQL & "                 ELSE SCPNO10"
        strSQL = strSQL & "                 END,"
        strSQL = strSQL & "       SCPNO11 = CASE WHEN SCPNO11 = '" & pScpNo & "'"
        strSQL = strSQL & "                      THEN '000'"
        strSQL = strSQL & "                 ELSE SCPNO11"
        strSQL = strSQL & "                 END,"
        strSQL = strSQL & "       SCPNO12 = CASE WHEN SCPNO12 = '" & pScpNo & "'"
        strSQL = strSQL & "                      THEN '000'"
        strSQL = strSQL & "                 ELSE SCPNO12"
        strSQL = strSQL & "                 End,"
        strSQL = strSQL & "       UPDYMD  = '" & Now & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM010_3 = True
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：オプションマスタ更新処理(コメントオプション追加/削除処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM100_2(ByVal pUpdKbn As String, ByVal pScpNo As String, ByVal pGoodsCD As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strSQL2 As String
        Dim strSQL3 As String
        Dim strSQL4 As String
        Dim intCnt As Integer
        Dim strSCPNO(15) As String
        Dim i As Integer

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM100_2 = False

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        For i = 0 To 15
            strSCPNO(i) = "0000"
        Next

        strSQL = ""
        strSQL2 = ""
        strSQL3 = ""
        strSQL4 = ""
        intCnt = 0
        i = 0
        Select Case pUpdKbn
            Case LC_UPDKBN_ADD
                If lsv_SelComOptList.Items.Count >= 16 Then
                    Exit Function
                End If

                strSQL = strSQL & "UPDATE TPM100"
                strSQL = strSQL & "   SET GUIDE   = '" & Trim$(txt_GuideNM.Text) & "',"                                    ' GUIDE
                strSQL = strSQL & "       GOODSCD" & CStr(lsv_SelComOptList.Items.Count + 1) & " = '" & pGoodsCD & "',"  ' GOODSCD1～16
                strSQL = strSQL & "       UPDYMD  = '" & Now & "'"                                                       ' UPDYMD
                strSQL = strSQL & " WHERE SCPNO   = '" & pScpNo & "'"                                                    ' SCPNO

                '多言語機能対応
                If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                    strSQL2 = strSQL2 & "UPDATE TPM100A"
                    strSQL2 = strSQL2 & "   SET GUIDE   = N'" & Trim$(txt_GuideNM_A.Text) & "',"                                ' GUIDE
                    strSQL2 = strSQL2 & "       GOODSCD" & CStr(lsv_SelComOptList.Items.Count + 1) & " = N'" & pGoodsCD & "',"  ' GOODSCD1～16
                    strSQL2 = strSQL2 & "       UPDYMD  = N'" & Now & "'"                                                       ' UPDYMD
                    strSQL2 = strSQL2 & " WHERE SCPNO   = '" & pScpNo & "'"                                                    ' SCPNO

                    strSQL3 = strSQL3 & "UPDATE TPM100B"
                    If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 1 Then
                        strSQL3 = strSQL3 & "   SET GUIDE   = N'" & Trim$(txt_GuideNM_B.Text) & "',"                           ' GUIDE
                    Else
                        strSQL3 = strSQL3 & "   SET GUIDE   = N'" & Trim$(txt_GuideNM.Text) & "',"                           ' GUIDE
                    End If
                    strSQL3 = strSQL3 & "       GOODSCD" & CStr(lsv_SelComOptList.Items.Count + 1) & " = N'" & pGoodsCD & "',"  ' GOODSCD1～16
                    strSQL3 = strSQL3 & "       UPDYMD  = N'" & Now & "'"                                                       ' UPDYMD
                    strSQL3 = strSQL3 & " WHERE SCPNO   = '" & pScpNo & "'"                                                    ' SCPNO

                    strSQL4 = strSQL4 & "UPDATE TPM100C"
                    If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 2 Then
                        strSQL4 = strSQL4 & "   SET GUIDE   = N'" & Trim$(txt_GuideNM_C.Text) & "',"                           ' GUIDE
                    Else
                        strSQL4 = strSQL4 & "   SET GUIDE   = N'" & Trim$(txt_GuideNM.Text) & "',"                           ' GUIDE
                    End If
                    strSQL4 = strSQL4 & "       GOODSCD" & CStr(lsv_SelComOptList.Items.Count + 1) & " = N'" & pGoodsCD & "',"  ' GOODSCD1～16
                    strSQL4 = strSQL4 & "       UPDYMD  = N'" & Now & "'"                                                       ' UPDYMD
                    strSQL4 = strSQL4 & " WHERE SCPNO   = '" & pScpNo & "'"                                                    ' SCPNO
                End If

            Case LC_UPDKBN_DEL
                While intCnt < lsv_SelComOptList.Items.Count
                    If lsv_SelComOptList.Items(intCnt).Text <> pGoodsCD Then
                        strSCPNO(i) = lsv_SelComOptList.Items(intCnt).Text
                        i = i + 1
                    End If
                    intCnt = intCnt + 1
                End While

                strSQL = strSQL & "UPDATE TPM100"
                strSQL = strSQL & "   SET GUIDE   = '" & Trim$(txt_GuideNM.Text) & "',"                                    ' GUIDE

                '多言語機能対応
                If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                    strSQL2 = strSQL2 & "UPDATE TPM100A"
                    strSQL2 = strSQL2 & "   SET GUIDE   = N'" & Trim$(txt_GuideNM_A.Text) & "',"                                    ' GUIDE

                    strSQL3 = strSQL3 & "UPDATE TPM100B"
                    If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 1 Then
                        strSQL3 = strSQL3 & "   SET GUIDE   = N'" & Trim$(txt_GuideNM_B.Text) & "',"                                    ' GUIDE
                    Else
                        strSQL3 = strSQL3 & "   SET GUIDE   = N'" & Trim$(txt_GuideNM.Text) & "',"                                    ' GUIDE
                    End If

                    strSQL4 = strSQL4 & "UPDATE TPM100C"
                    If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 2 Then
                        strSQL4 = strSQL4 & "   SET GUIDE   = N'" & Trim$(txt_GuideNM_C.Text) & "',"                                    ' GUIDE
                    Else
                        strSQL4 = strSQL4 & "   SET GUIDE   = N'" & Trim$(txt_GuideNM.Text) & "',"                                    ' GUIDE
                    End If
                End If

                i = 0
                For i = 0 To 15
                    strSQL = strSQL & "       GOODSCD" & CStr(i + 1) & " = '" & strSCPNO(i) & "',"                       ' GOODSCD1～16

                    '多言語機能対応
                    If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                        strSQL2 = strSQL2 & "       GOODSCD" & CStr(i + 1) & " = N'" & strSCPNO(i) & "',"                       ' GOODSCD1～16

                        strSQL3 = strSQL3 & "       GOODSCD" & CStr(i + 1) & " = N'" & strSCPNO(i) & "',"

                        strSQL4 = strSQL4 & "       GOODSCD" & CStr(i + 1) & " = N'" & strSCPNO(i) & "',"
                    End If
                Next

                strSQL = strSQL & "       UPDYMD  = '" & Now & "'"                                                       ' UPDYMD
                strSQL = strSQL & " WHERE SCPNO   = '" & pScpNo & "'"                                                    ' SCPNO

                '多言語機能対応
                If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                    strSQL2 = strSQL2 & "       UPDYMD  = N'" & Now & "'"                                                       ' UPDYMD
                    strSQL2 = strSQL2 & " WHERE SCPNO   = '" & pScpNo & "'"                                                    ' SCPNO

                    strSQL3 = strSQL3 & "       UPDYMD  = N'" & Now & "'"                                                       ' UPDYMD
                    strSQL3 = strSQL3 & " WHERE SCPNO   = '" & pScpNo & "'"

                    strSQL4 = strSQL4 & "       UPDYMD  = N'" & Now & "'"                                                       ' UPDYMD
                    strSQL4 = strSQL4 & " WHERE SCPNO   = '" & pScpNo & "'"
                End If
            Case Else
                Exit Function

        End Select

        'If Not GF_UpdCmtData(strSQL) Then
        '    Exit Function
        'End If
        Dim fgUpdateComplete As Boolean
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            fgUpdateComplete = Not GF_UpdData(strSQL) Or Not GF_UpdData(strSQL2) Or Not GF_UpdData(strSQL3) Or Not GF_UpdData(strSQL4)
        Else
            fgUpdateComplete = Not GF_UpdData(strSQL)
        End If
        If fgUpdateComplete Then
            GF_RollbackTrans()
            Exit Function
        Else
            If Not GF_CommitTrans() Then
                GF_RollbackTrans()
                Exit Function
            End If

        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM100_2 = True
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：オプションマスタ更新処理(ガイダンス名称更新処理)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM100_3(ByVal pGuide As String, ByVal pScpNo As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM100_3 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM100"
        strSQL = strSQL & "   SET GUIDE  = '" & GF_RepQuo(pGuide) & "',"
        strSQL = strSQL & "       UPDID  = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD = '" & Now & "'"
        strSQL = strSQL & " WHERE SCPNO  = '" & pScpNo & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM100_3 = True
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：オプションマスタ更新処理(ガイダンス名称更新処理)英語
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM100_A_3(ByVal pGuide As String, ByVal pScpNo As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM100_A_3 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM100A"
        strSQL = strSQL & "   SET GUIDE  = N'" & GF_RepQuo(pGuide) & "',"
        strSQL = strSQL & "       UPDID  = N'" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD = N'" & Now & "'"
        strSQL = strSQL & " WHERE SCPNO  = '" & pScpNo & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM100_A_3 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：オプションマスタ更新処理(ガイダンス名称更新処理)中国語
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.04.04 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM100_B_3(ByVal pGuide As String, ByVal pScpNo As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM100_B_3 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM100B"
        strSQL = strSQL & "   SET GUIDE  = N'" & GF_RepQuo(pGuide) & "',"
        strSQL = strSQL & "       UPDID  = N'" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD = N'" & Now & "'"
        strSQL = strSQL & " WHERE SCPNO  = '" & pScpNo & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM100_B_3 = True

    End Function

    Private Function LF_UpdTPM100_C_3(ByVal pGuide As String, ByVal pScpNo As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM100_C_3 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM100C"
        strSQL = strSQL & "   SET GUIDE  = N'" & GF_RepQuo(pGuide) & "',"
        strSQL = strSQL & "       UPDID  = N'" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD = N'" & Now & "'"
        strSQL = strSQL & " WHERE SCPNO  = '" & pScpNo & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM100_C_3 = True

    End Function

    Private Function LF_UpdTPM100_4(ByVal pScpNo As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strSQL2 As String
        Dim strSQL3 As String
        Dim strSQL4 As String
        Dim intCnt As Integer
        Dim strSCPNO(15) As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM100_4 = False

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        For intCnt = 0 To 15
            strSCPNO(intCnt) = "0000"
        Next

        '------------------------------
        ' 全アイテム表示順更新
        '------------------------------
        strSQL = ""
        strSQL2 = ""
        strSQL3 = ""
        strSQL4 = ""
        intCnt = 0
        intCnt = 0

        While intCnt < lsv_SelComOptList.Items.Count
            strSCPNO(intCnt) = lsv_SelComOptList.Items(intCnt).Text
            intCnt = intCnt + 1
        End While

        strSQL = strSQL & "UPDATE TPM100"
        strSQL = strSQL & "   SET GUIDE   = '" & Trim$(txt_GuideNM.Text) & "',"                                  ' GUIDE

        '多言語機能対応
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            strSQL2 = strSQL2 & "UPDATE TPM100A"
            strSQL2 = strSQL2 & "   SET GUIDE   = N'" & Trim$(txt_GuideNM_A.Text) & "',"                                  ' GUIDE

            strSQL3 = strSQL3 & "UPDATE TPM100B"
            If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 1 Then
                strSQL3 = strSQL3 & "   SET GUIDE   = N'" & Trim$(txt_GuideNM_B.Text) & "',"                                  ' GUIDE
            Else
                strSQL3 = strSQL3 & "   SET GUIDE   = N'" & Trim$(txt_GuideNM.Text) & "',"                                  ' GUIDE
            End If

            strSQL4 = strSQL4 & "UPDATE TPM100C"
            If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) > 2 Then
                strSQL4 = strSQL4 & "   SET GUIDE   = N'" & Trim$(txt_GuideNM_C.Text) & "',"                                  ' GUIDE
            Else
                strSQL4 = strSQL4 & "   SET GUIDE   = N'" & Trim$(txt_GuideNM.Text) & "',"                                  ' GUIDE
            End If
        End If

        intCnt = 0
        For intCnt = 0 To 15
            strSQL = strSQL & "       GOODSCD" & CStr(intCnt + 1) & " = '" & strSCPNO(intCnt) & "',"             ' GOODSCD1～16

            '多言語機能対応
            If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                strSQL2 = strSQL2 & "       GOODSCD" & CStr(intCnt + 1) & " = N'" & strSCPNO(intCnt) & "',"             ' GOODSCD1～16

                strSQL3 = strSQL3 & "       GOODSCD" & CStr(intCnt + 1) & " = N'" & strSCPNO(intCnt) & "',"             ' GOODSCD1～16

                strSQL4 = strSQL4 & "       GOODSCD" & CStr(intCnt + 1) & " = N'" & strSCPNO(intCnt) & "',"             ' GOODSCD1～16
            End If

        Next

        strSQL = strSQL & "       UPDYMD  = '" & Now & "'"                                                       ' UPDYMD
        strSQL = strSQL & " WHERE SCPNO   = '" & pScpNo & "'"                                                    ' SCPNO

        '多言語機能対応
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
            strSQL2 = strSQL2 & "       UPDYMD  = N'" & Now & "'"                                                       ' UPDYMD
            strSQL2 = strSQL2 & " WHERE SCPNO   = '" & pScpNo & "'"                                                    ' SCPNO

            strSQL3 = strSQL3 & "       UPDYMD  = N'" & Now & "'"                                                       ' UPDYMD
            strSQL3 = strSQL3 & " WHERE SCPNO   = '" & pScpNo & "'"                                                    ' SCPNO

            strSQL4 = strSQL4 & "       UPDYMD  = N'" & Now & "'"                                                       ' UPDYMD
            strSQL4 = strSQL4 & " WHERE SCPNO   = '" & pScpNo & "'"                                                    ' SCPNO
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

        ' 2014-07-04 コミットが抜けていたので追加
        '------------------------------
        ' トランザクション確定
        '------------------------------
        If Not GF_CommitTrans() Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM100_4 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ガイダンス名変更処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_GuideNM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GuideNM.TextChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection

        If txt_GuideNM.Modified = True Then
            Dim lngST As Long

            lngST = txt_GuideNM.SelectionStart

            ' 2014-05-12 2バイト文字制限解除
            'txt_GuideNM.Text = StrConv(txt_GuideNM.Text, VbStrConv.Wide)

            If lngST >= 0 Then
                txt_GuideNM.SelectionStart = lngST
            End If

            '------------------------------
            ' 入力長制限
            '------------------------------
            If GF_LenB(txt_GuideNM.Text) > 20 Then
                txt_GuideNM.Text = GF_MidB(txt_GuideNM.Text, 1, 20)
                txt_GuideNM.SelectionStart = GF_LenB(txt_GuideNM.Text)
                Exit Sub
            End If

            '------------------------------
            ' 選択タブ判定("0"：コメント指示、"1"：セット指示)
            '------------------------------
            If TabControl1.SelectedIndex = 0 Then
                '------------------------------
                ' 選択項目取得(コメント指示)
                '------------------------------
                objCollection = lsv_OptList.SelectedItems
            End If

            If TabControl1.SelectedIndex = 1 Then
                '------------------------------
                ' 選択項目取得(サブコメント指示)
                '------------------------------
                objCollection = lsv_SubList.SelectedItems
            End If

            If TabControl1.SelectedIndex = 2 Then
                '------------------------------
                ' 選択項目取得(セット指示)
                '------------------------------
                objCollection = lsv_SetList.SelectedItems
            End If


            With objCollection
                If .Count = 0 Then
                    Exit Sub
                End If

                If .Contains(.Item(0)) = False Then
                    Exit Sub
                End If
                .Item(0).SubItems.Item(1).Text = txt_GuideNM.Text

                If Not LF_UpdTPM100_3(txt_GuideNM.Text, .Item(0).Text) Then
                    GoTo SYSTEM_ERROR
                End If

                L_blnEditFlg = True
            End With
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_GuideNM_TextChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ガイダンス名変更処理（英語）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.04.04 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_GuideNM_A_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GuideNM_A.TextChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection

        If txt_GuideNM_A.Modified = True Then
            Dim lngST As Long

            lngST = txt_GuideNM_A.SelectionStart

            txt_GuideNM_A.Text = StrConv(txt_GuideNM_A.Text, VbStrConv.None)

            If lngST >= 0 Then
                txt_GuideNM_A.SelectionStart = lngST
            End If

            '------------------------------
            ' 入力長制限
            '------------------------------
            If GF_LenB(txt_GuideNM_A.Text) > 40 Then
                txt_GuideNM_A.Text = GF_MidB(txt_GuideNM_A.Text, 1, 40)
                txt_GuideNM_A.SelectionStart = GF_LenB(txt_GuideNM_A.Text)
                Exit Sub
            End If

            '------------------------------
            ' 選択項目取得
            '------------------------------
            objCollection = lsv_OptList.SelectedItems
            With objCollection
                If .Count = 0 Then
                    Exit Sub
                End If

                If .Contains(.Item(0)) = False Then
                    Exit Sub
                End If
                .Item(0).SubItems.Item(2).Text = txt_GuideNM_A.Text

                If Not LF_UpdTPM100_A_3(txt_GuideNM_A.Text, .Item(0).Text) Then
                    GoTo SYSTEM_ERROR
                End If

                L_blnEditFlg = True
            End With
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_GuideNM_A_TextChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ガイダンス名変更処理（中国語）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.04.04 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_GuideNM_B_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GuideNM_B.TextChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection

        If txt_GuideNM_B.Modified = True Then
            Dim lngST As Long

            lngST = txt_GuideNM_B.SelectionStart

            txt_GuideNM_B.Text = StrConv(txt_GuideNM_B.Text, VbStrConv.None)

            If lngST >= 0 Then
                txt_GuideNM_B.SelectionStart = lngST
            End If

            '------------------------------
            ' 入力長制限
            '------------------------------
            If GF_LenB(txt_GuideNM_B.Text) > 40 Then
                txt_GuideNM_B.Text = GF_MidB(txt_GuideNM_B.Text, 1, 40)
                txt_GuideNM_B.SelectionStart = GF_LenB(txt_GuideNM_B.Text)
                Exit Sub
            End If

            '------------------------------
            ' 選択項目取得
            '------------------------------
            objCollection = lsv_OptList.SelectedItems
            With objCollection
                If .Count = 0 Then
                    Exit Sub
                End If

                If .Contains(.Item(0)) = False Then
                    Exit Sub
                End If
                .Item(0).SubItems.Item(3).Text = txt_GuideNM_B.Text

                If Not LF_UpdTPM100_B_3(txt_GuideNM_B.Text, .Item(0).Text) Then
                    GoTo SYSTEM_ERROR
                End If

                L_blnEditFlg = True
            End With
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_GuideNM_B_TextChanged")
    End Sub

    Private Sub txt_GuideNM_C_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GuideNM_C.TextChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection

        If txt_GuideNM_C.Modified = True Then
            Dim lngST As Long

            lngST = txt_GuideNM_C.SelectionStart

            txt_GuideNM_C.Text = StrConv(txt_GuideNM_C.Text, VbStrConv.None)

            If lngST >= 0 Then
                txt_GuideNM_C.SelectionStart = lngST
            End If

            '------------------------------
            ' 入力長制限
            '------------------------------
            If GF_LenB(txt_GuideNM_C.Text) > 40 Then
                txt_GuideNM_C.Text = GF_MidB(txt_GuideNM_C.Text, 1, 40)
                txt_GuideNM_C.SelectionStart = GF_LenB(txt_GuideNM_C.Text)
                Exit Sub
            End If

            '------------------------------
            ' 選択項目取得
            '------------------------------
            objCollection = lsv_OptList.SelectedItems
            With objCollection
                If .Count = 0 Then
                    Exit Sub
                End If

                If .Contains(.Item(0)) = False Then
                    Exit Sub
                End If
                .Item(0).SubItems.Item(4).Text = txt_GuideNM_C.Text

                If Not LF_UpdTPM100_C_3(txt_GuideNM_C.Text, .Item(0).Text) Then
                    GoTo SYSTEM_ERROR
                End If

                L_blnEditFlg = True
            End With
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_GuideNM_C_TextChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済みコメントオプションドラッグドロップ処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_ItemGrp_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_SelComOptList.ItemDrag
        ' ドラッグ処理開始
        L_blnDMode = False
        lsv_SelComOptList.DoDragDrop(lsv_SelComOptList.SelectedItems, DragDropEffects.Copy)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済みコメントオプションドラッグドロップ処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SelComOptList_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_SelComOptList.DragEnter
        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：登録済みコメントオプションドラッグドロップ処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_SelComOptList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_SelComOptList.DragDrop

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objItem As ListViewItem
        Dim objPoint As Point
        Dim udtInfo As typItemInfo
        Dim intChgPos As Integer = 0

        '------------------------------
        ' 選択タブ判定("0"：コメント指示、"1"：セット指示)
        '------------------------------
        If TabControl1.SelectedIndex = 0 Then
            If lsv_OptList.SelectedItems.Count = 0 Then
                Exit Sub
            End If
        End If
        If TabControl1.SelectedIndex = 1 Then
            If lsv_SubList.SelectedItems.Count = 0 Then
                Exit Sub
            End If
        End If
        If TabControl1.SelectedIndex = 2 Then
            If lsv_SetList.SelectedItems.Count = 0 Then
                Exit Sub
            End If
        End If

        If L_blnDMode = False Then
            objPoint = lsv_SelComOptList.PointToClient(New Point(e.X, e.Y))
            objItem = lsv_SelComOptList.GetItemAt(objPoint.X, objPoint.Y)
            '------------------------------
            ' 選択タブ判定("0"：コメント指示、"1"：セット指示)
            '------------------------------
            If TabControl1.SelectedIndex = 0 Then
                udtInfo.strSCPNO = lsv_OptList.SelectedItems.Item(0).Text
            End If
            If TabControl1.SelectedIndex = 1 Then
                udtInfo.strSCPNO = lsv_SubList.SelectedItems.Item(0).Text
            End If
            If TabControl1.SelectedIndex = 2 Then

                udtInfo.strSCPNO = lsv_SetList.SelectedItems.Item(0).Text
            End If

            '------------------------------
            ' インデックス未取得時は最大値を設定
            '------------------------------
            If IsNothing(objItem) Then
                intChgPos = lsv_SelComOptList.Items.Count - 1
            Else
                intChgPos = objItem.Index
            End If

            Call LS_ItemMove(udtInfo.strSCPNO, intChgPos, e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))

        Else
            If Not e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then
                Exit Sub
            End If

            '------------------------------
            ' 選択タブ判定("0"：コメント指示、"1"：セット指示)
            '------------------------------
            If TabControl1.SelectedIndex = 0 Then
                If lsv_SelComOptList.Items.Count < GF_GetAppInfo("CMNT_MAX_CNT") Then
                    Call LS_AddItems(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
                End If
            Else
                If lsv_SelComOptList.Items.Count < 16 Then
                    Call LS_AddItems(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
                End If
            End If

        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：コメントオプション一覧ドラッグドロップ処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_ComOptList_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_ComOptList.ItemDrag
        ' ドラッグ処理開始
        L_blnDMode = True
        lsv_SelComOptList.DoDragDrop(lsv_ComOptList.SelectedItems, DragDropEffects.Copy)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：コメントオプション一覧ドラッグドロップ処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_ComOptList_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ComOptList.DragEnter
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
    Private Sub lsv_ComOptList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ComOptList.DragDrop

        If L_blnDMode = True Then
            Exit Sub
        End If

        If Not e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then
            Exit Sub
        End If

        Call LS_RemoveItems(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))

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
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim udtinfo As typItemInfo
        Dim lngDataCnt As Integer
        Dim lngCnt As Integer
        Dim lngRefCnt As Integer
        Dim blnExists As Boolean

        If pTargetData.Count = 0 Then
            Exit Sub
        End If

        '------------------------------
        ' 選択タブ判定("0"：コメント指示、"1"：セット指示)
        '------------------------------
        If TabControl1.SelectedIndex = 0 Then
            objCollection = lsv_OptList.SelectedItems
        End If
        If TabControl1.SelectedIndex = 1 Then
            objCollection = lsv_SubList.SelectedItems
        End If
        If TabControl1.SelectedIndex = 2 Then
            objCollection = lsv_SetList.SelectedItems
        End If

        With objCollection
            If .Count = 0 Then
                Exit Sub
            End If

            If .Contains(.Item(0)) = False Then
                Exit Sub
            End If

            udtinfo.strSCPNO = .Item(0).Text
        End With

        lngDataCnt = pTargetData.Count
        lngCnt = 0
        lngRefCnt = 0
        For lngCnt = 0 To lngDataCnt - 1
            '------------------------------
            ' 追加先グループコード取得
            '------------------------------
            If Not LF_GetTPM100_4(udtinfo.strSCPNO, _
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
                If Not LF_UpdTPM100_2(LC_UPDKBN_ADD, _
                                      udtinfo.strSCPNO, _
                                      Trim$(pTargetData.Item(lngRefCnt).Text)) Then
                    GoTo SYSTEM_ERROR
                End If

            End If
        Next

        '------------------------------
        ' グループ内商品一覧更新
        '------------------------------
        Call LS_SetItemList(udtinfo.strSCPNO)

        L_blnEditFlg = True
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AddItems")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：コメントオプション解除処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_RemoveItems(ByVal pTargetData As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim udtinfo As typItemInfo
        Dim lngCnt As Integer

        If pTargetData.Count = 0 Then
            Exit Sub
        End If

        '------------------------------
        ' 選択タブ判定("0"：コメント指示、"1"：セット指示)
        '------------------------------
        If TabControl1.SelectedIndex = 0 Then
            '------------------------------
            ' 削除先グループコード取得
            '------------------------------
            objCollection = lsv_OptList.SelectedItems
        End If
        If TabControl1.SelectedIndex = 1 Then
            '------------------------------
            ' 削除先グループコード取得
            '------------------------------
            objCollection = lsv_SubList.SelectedItems
        End If
        If TabControl1.SelectedIndex = 2 Then
            '------------------------------
            ' 削除先グループコード取得
            '------------------------------
            objCollection = lsv_SetList.SelectedItems
        End If

        With objCollection
            If .Count = 0 Then
                Exit Sub
            End If

            If .Contains(.Item(0)) = False Then
                Exit Sub
            End If

            udtinfo.strSCPNO = .Item(0).Text
        End With

        lngCnt = 0
        While lngCnt < pTargetData.Count
            '------------------------------
            ' ＤＢ更新処理
            '------------------------------
            If Not LF_UpdTPM100_2(LC_UPDKBN_DEL, _
                                  udtinfo.strSCPNO, _
                                  Trim$(pTargetData.Item(lngCnt).Text)) Then
                GoTo SYSTEM_ERROR
            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' グループ内商品一覧更新
        '------------------------------
        Call LS_SetItemList(udtinfo.strSCPNO)

        L_blnEditFlg = True
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_RemoveItems")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：表示順変更処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_ItemMove(ByVal pScpNo As String, ByVal pChgPos As Long, ByVal pMoveItems As ListView.SelectedListViewItemCollection)

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
            If pChgPos < 0 Or lsv_SelComOptList.Items.Count - 1 < pChgPos Then
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
                If lngPos > objItem.Index And blnUpFlg Then
                    lngPos = lngPos - 1
                End If
                lsv_SelComOptList.Items.Remove(objItem)
                lsv_SelComOptList.Items.Insert(lngPos, objItem)

                If blnUpFlg Then
                    lngPos = lngPos + 1
                End If
            Next

            '------------------------------
            ' 表示順項目更新処理
            '------------------------------
            If Not LF_UpdTPM100_4(pScpNo) Then
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

    ' --------------------------------------------------------------------------------
    ' 　機　　能：コメントオプション名称検索テキストボックス内 Enterキー押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_Search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call LS_SetItemList2()
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
        Call LS_SetItemList2()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：追加ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If lsv_SelComOptList.Items.Count < GF_GetAppInfo("CMNT_MAX_CNT") Then
            Call LS_AddItems(lsv_ComOptList.SelectedItems)
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：解除ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Clr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LS_RemoveItems(lsv_SelComOptList.SelectedItems)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：上へ移動ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Up.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim udtInfo As typItemInfo
        Dim lngTargetIndex As Long

        '------------------------------
        ' 選択タブ判定("0"：コメント指示、"1"：セット指示)
        '------------------------------
        If TabControl1.SelectedIndex = 0 Then
            If lsv_OptList.SelectedItems.Count = 0 Then
                Exit Sub
            End If
        End If
        If TabControl1.SelectedIndex = 1 Then
            If lsv_SubList.SelectedItems.Count = 0 Then
                Exit Sub
            End If
        End If
        If TabControl1.SelectedIndex = 2 Then

            If lsv_SetList.SelectedItems.Count = 0 Then
                Exit Sub
            End If
        End If

        If lsv_SelComOptList.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        '------------------------------
        ' 選択タブ判定("0"：コメント指示、"1"：セット指示)
        '------------------------------
        If TabControl1.SelectedIndex = 0 Then
            udtInfo.strSCPNO = lsv_OptList.SelectedItems.Item(0).Text
        End If
        If TabControl1.SelectedIndex = 1 Then
            udtInfo.strSCPNO = lsv_SubList.SelectedItems.Item(0).Text
        End If
        If TabControl1.SelectedIndex = 2 Then
            udtInfo.strSCPNO = lsv_SetList.SelectedItems.Item(0).Text
        End If

        lngTargetIndex = lsv_SelComOptList.SelectedItems(0).Index - 1
        If lngTargetIndex < 0 Then
            Exit Sub
        End If

        Call LS_ItemMove(udtInfo.strSCPNO, lngTargetIndex, lsv_SelComOptList.SelectedItems)
        lsv_SelComOptList.EnsureVisible(lngTargetIndex)

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Up_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：下へ移動ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Down.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim udtInfo As typItemInfo
        Dim lngTargetIndex As Long

        '------------------------------
        ' 選択タブ判定("0"：コメント指示、"1"：セット指示)
        '------------------------------
        If TabControl1.SelectedIndex = 0 Then
            If lsv_OptList.SelectedItems.Count = 0 Then
                Exit Sub
            End If
        End If
        If TabControl1.SelectedIndex = 1 Then
            If lsv_SubList.SelectedItems.Count = 0 Then
                Exit Sub
            End If
        End If
        If TabControl1.SelectedIndex = 2 Then
            If lsv_SetList.SelectedItems.Count = 0 Then
                Exit Sub
            End If
        End If

        If lsv_SelComOptList.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        '------------------------------
        ' 選択タブ判定("0"：コメント指示、"1"：セット指示)
        '------------------------------
        If TabControl1.SelectedIndex = 0 Then
            udtInfo.strSCPNO = lsv_OptList.SelectedItems.Item(0).Text
        End If
        If TabControl1.SelectedIndex = 1 Then
            udtInfo.strSCPNO = lsv_SubList.SelectedItems.Item(0).Text
        End If
        If TabControl1.SelectedIndex = 2 Then
            udtInfo.strSCPNO = lsv_SetList.SelectedItems.Item(0).Text
        End If

        lngTargetIndex = lsv_SelComOptList.SelectedItems(lsv_SelComOptList.SelectedItems.Count - 1).Index + 1
        If lngTargetIndex > lsv_SelComOptList.Items.Count - 1 Then
            Exit Sub
        End If

        Call LS_ItemMove(udtInfo.strSCPNO, lngTargetIndex, lsv_SelComOptList.SelectedItems)
        lsv_SelComOptList.EnsureVisible(lngTargetIndex)

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Down_Click")
    End Sub


End Class
