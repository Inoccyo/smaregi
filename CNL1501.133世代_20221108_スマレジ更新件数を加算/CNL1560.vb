' --------------------------------------------------------------------------------
' 　機　　能：CrossNavi - お知らせ作成画面
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
' --------------------------------------------------------------------------------
Public Class CNL1560
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
    Friend WithEvents btn_Fol As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents grd_ImgList As System.Windows.Forms.DataGrid
    Friend WithEvents txt_ImgPath As System.Windows.Forms.TextBox
    Friend WithEvents grd_AdvList As System.Windows.Forms.DataGrid
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents lst_AdvSel As System.Windows.Forms.ListBox
    Friend WithEvents txt_AdvNm As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txt_GoodsCD As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_Menu As System.Windows.Forms.Label
    Friend WithEvents btn_Goods As System.Windows.Forms.Button
    Friend WithEvents chk_Order As System.Windows.Forms.CheckBox
    Friend WithEvents pic_EditArea As System.Windows.Forms.PictureBox
    Friend WithEvents txt_WriteMsg As System.Windows.Forms.TextBox
    Friend WithEvents chk_Shadow As System.Windows.Forms.CheckBox
    Public WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_AddKo As System.Windows.Forms.Button
    Friend WithEvents btn_DelKo As System.Windows.Forms.Button
    Friend WithEvents btn_Dwn As System.Windows.Forms.Button
    Friend WithEvents btn_Up As System.Windows.Forms.Button
    Friend WithEvents btn_Del As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents pic_ViewArea As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grd_AdvList2 As System.Windows.Forms.DataGrid
    Friend WithEvents btn_Prev As System.Windows.Forms.Button
    Friend WithEvents btn_Color As System.Windows.Forms.Button
    Friend WithEvents btn_Font As System.Windows.Forms.Button
    Friend WithEvents btn_Img_Edt As System.Windows.Forms.Button
    Friend WithEvents chk_Draw As System.Windows.Forms.CheckBox
    Friend WithEvents btn_ClrGoods As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CNL1560))
        Me.stb_Msg = New System.Windows.Forms.StatusBar
        Me.grd_ImgList = New System.Windows.Forms.DataGrid
        Me.grd_AdvList = New System.Windows.Forms.DataGrid
        Me.btn_Fol = New System.Windows.Forms.Button
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.txt_ImgPath = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.lst_AdvSel = New System.Windows.Forms.ListBox
        Me.txt_AdvNm = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.pic_ViewArea = New System.Windows.Forms.PictureBox
        Me.btn_Del = New System.Windows.Forms.Button
        Me.btn_Add = New System.Windows.Forms.Button
        Me.btn_Dwn = New System.Windows.Forms.Button
        Me.btn_Up = New System.Windows.Forms.Button
        Me.btn_DelKo = New System.Windows.Forms.Button
        Me.btn_AddKo = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.chk_Draw = New System.Windows.Forms.CheckBox
        Me.btn_Img_Edt = New System.Windows.Forms.Button
        Me.btn_Prev = New System.Windows.Forms.Button
        Me.btn_Color = New System.Windows.Forms.Button
        Me.btn_Font = New System.Windows.Forms.Button
        Me.grd_AdvList2 = New System.Windows.Forms.DataGrid
        Me.txt_GoodsCD = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbl_Menu = New System.Windows.Forms.Label
        Me.btn_Goods = New System.Windows.Forms.Button
        Me.chk_Order = New System.Windows.Forms.CheckBox
        Me.pic_EditArea = New System.Windows.Forms.PictureBox
        Me.txt_WriteMsg = New System.Windows.Forms.TextBox
        Me.chk_Shadow = New System.Windows.Forms.CheckBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_ClrGoods = New System.Windows.Forms.Button
        CType(Me.grd_ImgList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_AdvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pic_ViewArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.grd_AdvList2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_EditArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 665)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(1016, 24)
        Me.stb_Msg.TabIndex = 232
        Me.stb_Msg.Text = "StatusBar1"
        '
        'grd_ImgList
        '
        Me.grd_ImgList.CaptionFont = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_ImgList.CaptionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grd_ImgList.CaptionText = "■編集元画像"
        Me.grd_ImgList.CaptionVisible = False
        Me.grd_ImgList.DataMember = ""
        Me.grd_ImgList.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_ImgList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_ImgList.Location = New System.Drawing.Point(612, 122)
        Me.grd_ImgList.Name = "grd_ImgList"
        Me.grd_ImgList.Size = New System.Drawing.Size(174, 488)
        Me.grd_ImgList.TabIndex = 0
        '
        'grd_AdvList
        '
        Me.grd_AdvList.CaptionFont = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_AdvList.CaptionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grd_AdvList.CaptionText = "■広告画像一覧"
        Me.grd_AdvList.CaptionVisible = False
        Me.grd_AdvList.DataMember = ""
        Me.grd_AdvList.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_AdvList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_AdvList.Location = New System.Drawing.Point(321, 122)
        Me.grd_AdvList.Name = "grd_AdvList"
        Me.grd_AdvList.Size = New System.Drawing.Size(174, 488)
        Me.grd_AdvList.TabIndex = 13
        '
        'btn_Fol
        '
        Me.btn_Fol.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Fol.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Fol.Location = New System.Drawing.Point(612, 92)
        Me.btn_Fol.Name = "btn_Fol"
        Me.btn_Fol.Size = New System.Drawing.Size(174, 24)
        Me.btn_Fol.TabIndex = 1
        Me.btn_Fol.Text = "画像フォルダ選択"
        Me.btn_Fol.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "")
        Me.ImageList1.Images.SetKeyName(12, "")
        Me.ImageList1.Images.SetKeyName(13, "")
        Me.ImageList1.Images.SetKeyName(14, "")
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        Me.ImageList2.Images.SetKeyName(3, "")
        Me.ImageList2.Images.SetKeyName(4, "")
        Me.ImageList2.Images.SetKeyName(5, "")
        Me.ImageList2.Images.SetKeyName(6, "")
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
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.Location = New System.Drawing.Point(12, 137)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 17)
        Me.Label17.TabIndex = 274
        Me.Label17.Text = "お知らせ名"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem7})
        Me.MenuItem1.Text = "お知らせ作成"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.Text = "終了(&E)"
        '
        'lst_AdvSel
        '
        Me.lst_AdvSel.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lst_AdvSel.ItemHeight = 15
        Me.lst_AdvSel.Items.AddRange(New Object() {"１行目", "２行目", "３行目", "４行目", "５行目"})
        Me.lst_AdvSel.Location = New System.Drawing.Point(15, 30)
        Me.lst_AdvSel.Name = "lst_AdvSel"
        Me.lst_AdvSel.Size = New System.Drawing.Size(270, 79)
        Me.lst_AdvSel.TabIndex = 10
        '
        'txt_AdvNm
        '
        Me.txt_AdvNm.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_AdvNm.Location = New System.Drawing.Point(15, 157)
        Me.txt_AdvNm.Name = "txt_AdvNm"
        Me.txt_AdvNm.Size = New System.Drawing.Size(270, 22)
        Me.txt_AdvNm.TabIndex = 11
        Me.txt_AdvNm.Text = "TextBox1"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 285
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(198, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(813, 652)
        Me.TabControl1.TabIndex = 287
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.btn_Add)
        Me.TabPage1.Controls.Add(Me.btn_Dwn)
        Me.TabPage1.Controls.Add(Me.btn_Up)
        Me.TabPage1.Controls.Add(Me.btn_DelKo)
        Me.TabPage1.Controls.Add(Me.btn_AddKo)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btn_Fol)
        Me.TabPage1.Controls.Add(Me.grd_AdvList)
        Me.TabPage1.Controls.Add(Me.grd_ImgList)
        Me.TabPage1.Controls.Add(Me.txt_ImgPath)
        Me.TabPage1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(805, 622)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "お知らせ登録"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.pic_ViewArea)
        Me.GroupBox2.Controls.Add(Me.btn_Del)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 324)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 286)
        Me.GroupBox2.TabIndex = 285
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "選択している画像"
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
        Me.btn_Del.Text = "削除"
        Me.btn_Del.UseVisualStyleBackColor = False
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Add.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Add.Location = New System.Drawing.Point(506, 329)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(97, 36)
        Me.btn_Add.TabIndex = 281
        Me.btn_Add.Text = "追加"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'btn_Dwn
        '
        Me.btn_Dwn.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Dwn.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Dwn.Location = New System.Drawing.Point(423, 92)
        Me.btn_Dwn.Name = "btn_Dwn"
        Me.btn_Dwn.Size = New System.Drawing.Size(72, 24)
        Me.btn_Dwn.TabIndex = 280
        Me.btn_Dwn.Text = "下へ移動"
        Me.btn_Dwn.UseVisualStyleBackColor = False
        '
        'btn_Up
        '
        Me.btn_Up.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Up.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Up.Location = New System.Drawing.Point(321, 92)
        Me.btn_Up.Name = "btn_Up"
        Me.btn_Up.Size = New System.Drawing.Size(82, 24)
        Me.btn_Up.TabIndex = 279
        Me.btn_Up.Text = "上へ移動"
        Me.btn_Up.UseVisualStyleBackColor = False
        '
        'btn_DelKo
        '
        Me.btn_DelKo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_DelKo.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_DelKo.Location = New System.Drawing.Point(215, 10)
        Me.btn_DelKo.Name = "btn_DelKo"
        Me.btn_DelKo.Size = New System.Drawing.Size(180, 50)
        Me.btn_DelKo.TabIndex = 278
        Me.btn_DelKo.Text = "選択中のお知らせ削除"
        Me.btn_DelKo.UseVisualStyleBackColor = False
        '
        'btn_AddKo
        '
        Me.btn_AddKo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_AddKo.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_AddKo.Location = New System.Drawing.Point(20, 10)
        Me.btn_AddKo.Name = "btn_AddKo"
        Me.btn_AddKo.Size = New System.Drawing.Size(180, 50)
        Me.btn_AddKo.TabIndex = 277
        Me.btn_AddKo.Text = "お知らせ追加"
        Me.btn_AddKo.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(5, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(794, 1)
        Me.Label11.TabIndex = 276
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txt_AdvNm)
        Me.GroupBox1.Controls.Add(Me.lst_AdvSel)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 197)
        Me.GroupBox1.TabIndex = 275
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "お知らせの種類"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.btn_ClrGoods)
        Me.TabPage2.Controls.Add(Me.chk_Draw)
        Me.TabPage2.Controls.Add(Me.btn_Img_Edt)
        Me.TabPage2.Controls.Add(Me.btn_Prev)
        Me.TabPage2.Controls.Add(Me.btn_Color)
        Me.TabPage2.Controls.Add(Me.btn_Font)
        Me.TabPage2.Controls.Add(Me.grd_AdvList2)
        Me.TabPage2.Controls.Add(Me.txt_GoodsCD)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.lbl_Menu)
        Me.TabPage2.Controls.Add(Me.btn_Goods)
        Me.TabPage2.Controls.Add(Me.chk_Order)
        Me.TabPage2.Controls.Add(Me.pic_EditArea)
        Me.TabPage2.Controls.Add(Me.txt_WriteMsg)
        Me.TabPage2.Controls.Add(Me.chk_Shadow)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(805, 622)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "お知らせ編集"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chk_Draw
        '
        Me.chk_Draw.Appearance = System.Windows.Forms.Appearance.Button
        Me.chk_Draw.AutoSize = True
        Me.chk_Draw.BackColor = System.Drawing.SystemColors.Control
        Me.chk_Draw.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_Draw.Location = New System.Drawing.Point(503, 70)
        Me.chk_Draw.Name = "chk_Draw"
        Me.chk_Draw.Size = New System.Drawing.Size(134, 25)
        Me.chk_Draw.TabIndex = 304
        Me.chk_Draw.Text = "      記入する      "
        Me.chk_Draw.UseVisualStyleBackColor = False
        '
        'btn_Img_Edt
        '
        Me.btn_Img_Edt.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Img_Edt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Img_Edt.Location = New System.Drawing.Point(648, 10)
        Me.btn_Img_Edt.Name = "btn_Img_Edt"
        Me.btn_Img_Edt.Size = New System.Drawing.Size(135, 50)
        Me.btn_Img_Edt.TabIndex = 303
        Me.btn_Img_Edt.Text = "画像更新"
        Me.btn_Img_Edt.UseVisualStyleBackColor = False
        '
        'btn_Prev
        '
        Me.btn_Prev.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Prev.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Prev.Location = New System.Drawing.Point(648, 70)
        Me.btn_Prev.Name = "btn_Prev"
        Me.btn_Prev.Size = New System.Drawing.Size(135, 25)
        Me.btn_Prev.TabIndex = 302
        Me.btn_Prev.Text = "１つ前に戻す"
        Me.btn_Prev.UseVisualStyleBackColor = False
        '
        'btn_Color
        '
        Me.btn_Color.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Color.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Color.Location = New System.Drawing.Point(358, 70)
        Me.btn_Color.Name = "btn_Color"
        Me.btn_Color.Size = New System.Drawing.Size(135, 25)
        Me.btn_Color.TabIndex = 300
        Me.btn_Color.Text = "文字色設定"
        Me.btn_Color.UseVisualStyleBackColor = False
        '
        'btn_Font
        '
        Me.btn_Font.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Font.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Font.Location = New System.Drawing.Point(215, 70)
        Me.btn_Font.Name = "btn_Font"
        Me.btn_Font.Size = New System.Drawing.Size(135, 25)
        Me.btn_Font.TabIndex = 299
        Me.btn_Font.Text = "フォント設定"
        Me.btn_Font.UseVisualStyleBackColor = False
        '
        'grd_AdvList2
        '
        Me.grd_AdvList2.CaptionFont = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_AdvList2.CaptionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grd_AdvList2.CaptionText = "■広告画像一覧"
        Me.grd_AdvList2.CaptionVisible = False
        Me.grd_AdvList2.DataMember = ""
        Me.grd_AdvList2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_AdvList2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_AdvList2.Location = New System.Drawing.Point(21, 42)
        Me.grd_AdvList2.Name = "grd_AdvList2"
        Me.grd_AdvList2.Size = New System.Drawing.Size(174, 488)
        Me.grd_AdvList2.TabIndex = 298
        '
        'txt_GoodsCD
        '
        Me.txt_GoodsCD.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_GoodsCD.Location = New System.Drawing.Point(559, 585)
        Me.txt_GoodsCD.Name = "txt_GoodsCD"
        Me.txt_GoodsCD.Size = New System.Drawing.Size(24, 22)
        Me.txt_GoodsCD.TabIndex = 297
        Me.txt_GoodsCD.Text = "TextBox1"
        Me.txt_GoodsCD.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(13, 558)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(480, 16)
        Me.Label6.TabIndex = 296
        Me.Label6.Text = "■ 商品画面に遷移する場合は、チェックをつけ、対象商品を選択してください"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lbl_Menu
        '
        Me.lbl_Menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Menu.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_Menu.Location = New System.Drawing.Point(47, 587)
        Me.lbl_Menu.Name = "lbl_Menu"
        Me.lbl_Menu.Size = New System.Drawing.Size(312, 24)
        Me.lbl_Menu.TabIndex = 295
        Me.lbl_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_Goods
        '
        Me.btn_Goods.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Goods.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Goods.Location = New System.Drawing.Point(374, 586)
        Me.btn_Goods.Name = "btn_Goods"
        Me.btn_Goods.Size = New System.Drawing.Size(75, 25)
        Me.btn_Goods.TabIndex = 291
        Me.btn_Goods.Text = "選択"
        Me.btn_Goods.UseVisualStyleBackColor = False
        '
        'chk_Order
        '
        Me.chk_Order.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_Order.Image = CType(resources.GetObject("chk_Order.Image"), System.Drawing.Image)
        Me.chk_Order.Location = New System.Drawing.Point(25, 587)
        Me.chk_Order.Name = "chk_Order"
        Me.chk_Order.Size = New System.Drawing.Size(16, 24)
        Me.chk_Order.TabIndex = 290
        '
        'pic_EditArea
        '
        Me.pic_EditArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_EditArea.Location = New System.Drawing.Point(215, 104)
        Me.pic_EditArea.Name = "pic_EditArea"
        Me.pic_EditArea.Size = New System.Drawing.Size(568, 426)
        Me.pic_EditArea.TabIndex = 292
        Me.pic_EditArea.TabStop = False
        '
        'txt_WriteMsg
        '
        Me.txt_WriteMsg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_WriteMsg.Location = New System.Drawing.Point(227, 38)
        Me.txt_WriteMsg.Name = "txt_WriteMsg"
        Me.txt_WriteMsg.Size = New System.Drawing.Size(410, 22)
        Me.txt_WriteMsg.TabIndex = 288
        Me.txt_WriteMsg.Text = "TextBox1"
        '
        'chk_Shadow
        '
        Me.chk_Shadow.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_Shadow.Image = CType(resources.GetObject("chk_Shadow.Image"), System.Drawing.Image)
        Me.chk_Shadow.Location = New System.Drawing.Point(503, 10)
        Me.chk_Shadow.Name = "chk_Shadow"
        Me.chk_Shadow.Size = New System.Drawing.Size(134, 28)
        Me.chk_Shadow.TabIndex = 287
        Me.chk_Shadow.Text = "影付きで記入する"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label18.Location = New System.Drawing.Point(13, 542)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(779, 1)
        Me.Label18.TabIndex = 294
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(212, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 16)
        Me.Label1.TabIndex = 293
        Me.Label1.Text = "■ 画像に記入する文言を入力してください"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btn_ClrGoods
        '
        Me.btn_ClrGoods.BackColor = System.Drawing.SystemColors.Control
        Me.btn_ClrGoods.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_ClrGoods.Location = New System.Drawing.Point(455, 587)
        Me.btn_ClrGoods.Name = "btn_ClrGoods"
        Me.btn_ClrGoods.Size = New System.Drawing.Size(75, 25)
        Me.btn_ClrGoods.TabIndex = 305
        Me.btn_ClrGoods.Text = "解除"
        Me.btn_ClrGoods.UseVisualStyleBackColor = False
        '
        'CNL1560
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1016, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stb_Msg)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL1560"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JCV06"
        CType(Me.grd_ImgList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_AdvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pic_ViewArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.grd_AdvList2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_EditArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Structure typDrawStrImg
        Dim strWriteString As String
        Dim objFontStyle As Font
        Dim objDrawColor As System.Drawing.Brush
        Dim lngX As Long
        Dim lngY As Long
        Dim blnUndo As Boolean
    End Structure

    Private L_objBitmap As Bitmap
    Private L_objGraph As Graphics
    Private L_objColor As Color
    Private L_DrawFlg As Boolean
    Private L_objFont As Font
    Private L_objUndo() As typDrawStrImg
    Private L_lngDrawCnt As Long
    Private L_strSelFile As String
    'Private L_blnEditFlg As Boolean

    ' --------------------------------------------------------------------------------
    ' モジュール内列挙型定義
    ' --------------------------------------------------------------------------------
    Private Enum TLBMODE
        INITMODE = 0
        ADDMODE = 1
        EDITMODE = 2
    End Enum

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub CNL1560_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' フォーム名称設定
        '------------------------------
        Me.Text = " お知らせ作成 "

        '---------------------------------
        '閉じるボタン非表示化
        '---------------------------------
        Me.ControlBox = False

        Try
            '------------------------------
            ' 各モジュール内変数初期設定
            '------------------------------
            L_objBitmap = New Bitmap(GC_ADVPIC_W, GC_ADVPIC_H, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
            L_objGraph = Graphics.FromImage(L_objBitmap)
            L_objColor = txt_WriteMsg.ForeColor
            L_DrawFlg = False
            L_objFont = New Font("ＭＳ Ｐゴシック", 22)
            L_lngDrawCnt = 0
            L_strSelFile = ""
            'L_blnEditFlg = False

            '------------------------------
            ' フォーム初期化処理
            '------------------------------
            txt_ImgPath.Text = g_udtAppConfig.strImpPath                        ' ファイルパス
            txt_AdvNm.Clear()                                                   ' 広告名
            txt_WriteMsg.Clear()                                                ' 画像描画メッセージ

            chk_Shadow.Checked = True
            txt_ImgPath.Visible = False
            chk_Order.Checked = False                                           ' 広告画像からのオーダ用 - 使用可否チェック
            txt_GoodsCD.Text = ""                                               ' 広告画像からのオーダ用 - 商品コード
            lbl_Menu.Text = ""                                                  ' 広告画像からのオーダ用 - 商品名称
            btn_Goods.Enabled = False                                           ' 広告画像からのオーダ用 - 選択ボタン
            btn_ClrGoods.Enabled = False                                        ' 広告画像からのオーダ用 - 解除ボタン

            '------------------------------
            ' 広告情報選択コンボ生成
            '------------------------------
            Call LS_SetAdvList()

            '------------------------------
            ' ステータス情報生成
            '------------------------------
            Call GS_StatusSetup(stb_Msg)

            '------------------------------
            ' 追加・削除ボタン使用可否設定
            '------------------------------
            Call LS_SetButton(TLBMODE.INITMODE)

            '------------------------------
            ' 各画像リスト生成
            '------------------------------
            Call LS_GridSetup_1()                                               ' 選択画像リスト
            Call LS_GridSetup_2()                                               ' 広告画像リスト

            '------------------------------
            ' トランザクション処理
            '------------------------------
            'If Not GF_BeginTrans() Then
            '    GoTo SYSTEM_ERROR
            'End If

            '------------------------------
            ' 広告画像容量チェック
            '------------------------------
            If GF_AllAdvChk() = CNL1920.FuncResult.UnusualEnd Then
                GoTo SYSTEM_ERROR
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1560_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画面終了時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub CNL1560_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        'If L_blnEditFlg Then
        '    Select Case MsgBox(GF_GetMsg("Q03"), MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question, g_udtAppConfig.strAppName)
        '        Case MsgBoxResult.Yes
        '            '------------------------------
        '            ' 広告画像容量チェック
        '            '------------------------------
        '            Select Case GF_AllAdvChk()
        '                Case CNL1920.FuncResult.UnusualEnd
        '                    GoTo SYSTEM_ERROR
        '                Case CNL1920.FuncResult.CancelEnd
        '                    e.Cancel = True
        '                    Exit Sub
        '            End Select

        '            '------------------------------
        '            ' 無効メニュー削除処理
        '            '------------------------------
        '            Select Case LF_ChkAdvEnabled(True)
        '                Case CNL1920.FuncResult.UnusualEnd
        '                    GoTo SYSTEM_ERROR
        '                Case CNL1920.FuncResult.CancelEnd
        '                    e.Cancel = True
        '                    Exit Sub
        '            End Select

        '            If LF_ChkAdvEnabled(False) = CNL1920.FuncResult.UnusualEnd Then
        '                GoTo SYSTEM_ERROR
        '            End If

        '            '------------------------------
        '            ' コミット処理
        '            '------------------------------
        '            If Not GF_CommitTrans() Then
        '                GoTo SYSTEM_ERROR
        '            End If

        '        Case MsgBoxResult.No
        '            '------------------------------
        '            ' ロールバック処理
        '            '------------------------------
        '            If Not GF_RollbackTrans() Then
        '                GoTo SYSTEM_ERROR
        '            End If

        '        Case MsgBoxResult.Cancel
        '            e.Cancel = True
        '            Exit Sub

        '        Case Else
        '            Exit Sub
        '    End Select
        'Else
        '    '------------------------------
        '    ' ロールバック処理
        '    '------------------------------
        '    If Not GF_RollbackTrans() Then
        '        GoTo SYSTEM_ERROR
        '    End If
        'End If

        '------------------------------
        ' 無効メニュー削除処理
        '------------------------------
        If LF_ChkAdvEnabled() = CNL1920.FuncResult.UnusualEnd Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' 未使用画像ファイル削除処理
        '------------------------------
        If Not LF_DelUnuseFile() Then
            GoTo SYSTEM_ERROR
        End If

        L_objBitmap = Nothing
        L_objGraph = Nothing

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1560_Closing")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：無効メニュー削除処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_ChkAdvEnabled() As FuncResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objData2 As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_ChkAdvEnabled = CNL1920.FuncResult.UnusualEnd

        '------------------------------
        ' 全メニューグループコード取得
        '------------------------------
        If Not LF_GetTPM080_1(objData) Then
            Exit Function
        End If

        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If

            '------------------------------
            ' 広告グループ内画像数取得
            '------------------------------
            strSQL = ""
            strSQL = strSQL & "SELECT ADVGRP_ID"
            strSQL = strSQL & "  FROM TPM080"
            strSQL = strSQL & " WHERE ADVGRP_ID = '" & Trim$(objRows("ADVGRP_ID")) & "'"
            strSQL = strSQL & "   AND ADV_ID    <> '000'"
            strSQL = strSQL & "   AND DISPORDER <> '000'"

            objData2 = New DataSet()

            If Not GF_GetData(strSQL, objData2) Then
                Exit Function
            End If

            If objData2.Tables("com").Rows.Count = 0 Then
                '------------------------------
                ' 無効メニュー検出時
                '------------------------------
                Select Case GF_Msg("", "お知らせ【 " & Trim$(objRows("ADVGRP_NM")) & " 】にはお知らせ画像未登録のため、強制削除します", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                    Case MsgBoxResult.Ok
                        '------------------------------
                        ' 無効メニューを削除する
                        '------------------------------
                        If Not LF_UpdTPM080_5(Trim$(objRows("ADVGRP_ID"))) Then
                            LF_ChkAdvEnabled = CNL1920.FuncResult.UnusualEnd
                            Exit Function
                        End If

                    Case Else
                        LF_ChkAdvEnabled = CNL1920.FuncResult.CancelEnd
                        Exit Function
                End Select
            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_ChkAdvEnabled = CNL1920.FuncResult.NormalEnd

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告情報選択リストボックス 設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetAdvList()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' 初期値設定
        '------------------------------
        lst_AdvSel.Items.Clear()
        txt_AdvNm.Text = ""

        '------------------------------
        ' 設定データ取得
        '------------------------------
        If Not LF_GetTPM080_1(objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' データ値設定
        '------------------------------
        Try
            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    GoTo SYSTEM_ERROR
                End If

                Call GS_SetListBox(lst_AdvSel, Trim$(objRows("ADVGRP_NM")), Trim$(objRows("ADVGRP_ID")))
                lngCnt = lngCnt + 1
            End While

            '------------------------------
            ' 広告情報選択リストボックス 選択処理
            '------------------------------
            If lst_AdvSel.SelectedIndex = -1 Then
                If lst_AdvSel.Items.Count <> 0 Then
                    lst_AdvSel.SelectedIndex = 0
                End If
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetAdvList")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告情報選択リストボックス 選択時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lst_AdvSel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lst_AdvSel.SelectedIndexChanged

        If txt_AdvNm.Modified = True Then
            Exit Sub
        End If

        txt_AdvNm.Text = Trim$(GF_LstGetString(lst_AdvSel, lst_AdvSel.SelectedIndex))

        '------------------------------
        ' 追加・削除ボタン使用可否設定
        '------------------------------
        Call LS_SetButton(TLBMODE.INITMODE)

        '------------------------------
        ' 広告画像リスト生成
        '------------------------------
        Call LS_GridSetup_2()

        '------------------------------
        ' 選択画像領域クリア
        '------------------------------
        L_objBitmap = New Bitmap(GC_ADVPIC_W, GC_ADVPIC_H, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
        L_objGraph = Graphics.FromImage(L_objBitmap)
        pic_ViewArea.Refresh()
        L_strSelFile = ""

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：選択画像一覧グリッド セットアップ処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_GridSetup_1()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objTs As New DataGridTableStyle()                               ' 新しいDataGridTableStyleの作成
        Dim udtGridCol(2) As typGridColumn
        Dim lngCnt As Long
        Dim dtsData As New DataSet()
        Dim dtrRows As DataRow = Nothing
        Dim dtsList As DataSet
        Dim objTable As DataTable
        Dim strFile As String

        '------------------------------
        ' テーブルスタイル定義
        '------------------------------
        With objTs
            .MappingName = "IMAGELIST2"                                     ' マップ名を指定
            .PreferredRowHeight = 114                                       ' 標準行高を指定
            .GridLineStyle = DataGridLineStyle.None                         ' グリッドラインを非表示に設定
            .RowHeadersVisible = False
        End With

        '------------------------------
        ' 各項目属性定義
        '------------------------------
        With udtGridCol(0)                                                  ' 『選択画像』項目
            .intType = CNL1920.COLUMN_TYPE.IMAGE_NOEDIT_STYLE
            .strMapName = "PICTURE"
            .strHeadText = "選択画像"
            .blnAllowNull = False
            .lngWidth = 152
            .objAlign = HorizontalAlignment.Center
        End With

        For lngCnt = 0 To UBound(udtGridCol) - 1                            ' 各列定義をテーブルスタイルに追加
            Call GS_GridAddColumn(udtGridCol(lngCnt), objTs)
        Next
        objTs.AllowSorting = False                                          ' 列見出しクリックによるソートを禁止
        objTs.RowHeadersVisible = False

        With grd_ImgList
            .TableStyles.Clear()
            .TableStyles.Add(objTs)                                         ' テーブルスタイルをDataGridに追加
            .ReadOnly = True                                                ' 編集禁止
        End With

        '------------------------------
        ' グリッド生成
        '------------------------------
        dtsList = New DataSet("ImgList")
        objTable = New DataTable("IMAGELIST2")
        For lngCnt = 0 To UBound(udtGridCol) - 1
            Call GS_GridAddTable(udtGridCol(lngCnt), objTable)
        Next

        '------------------------------
        ' データ値設定
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

        dtsList.Tables.Add(objTable)                                        ' テーブルをDataSetに追加する
        grd_ImgList.SetDataBinding(dtsList, "IMAGELIST2")                   ' DataSetとテーブルをDataGridに接続する

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GridSetup_1")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告画像一覧グリッド セットアップ処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_GridSetup_2()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objTs As New DataGridTableStyle()                               ' 新しいDataGridTableStyleの作成
        Dim udtGridCol(4) As typGridColumn
        Dim lngCnt As Long
        Dim objData As New DataSet()
        Dim dtsData As New DataSet()
        Dim dtrRows As DataRow = Nothing
        Dim dtrData As DataRow = Nothing
        Dim dtsList As DataSet
        Dim objTable As DataTable

        '------------------------------
        ' 広告選択状態 設定処理
        '------------------------------
        If lst_AdvSel.SelectedIndex = -1 Then
            If lst_AdvSel.Items.Count <> 0 Then
                lst_AdvSel.SelectedIndex = 0
            End If
        End If

        '------------------------------
        ' 表示データ取得処理
        '------------------------------
        If Not LF_GetTPM080_2(objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' テーブルスタイル定義
        '------------------------------
        With objTs
            .MappingName = "IMAGELIST3"                                     ' マップ名を指定
            .PreferredRowHeight = 114                                       ' 標準行高を指定
            .GridLineStyle = DataGridLineStyle.None                         ' グリッドラインを非表示に設定
            .RowHeadersVisible = False
        End With

        '------------------------------
        ' 各項目属性定義
        '------------------------------
        With udtGridCol(0)                                                  ' 『広告画像』項目
            .intType = CNL1920.COLUMN_TYPE.IMAGE_NOEDIT_STYLE
            .strMapName = "PICTURE"
            .strHeadText = "お知らせ画像"
            .blnAllowNull = False
            .lngWidth = 152
            .objAlign = HorizontalAlignment.Center
        End With

        With udtGridCol(1)                                                  ' 『画像ID』項目
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "ADV_ID"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Center
            .blnReadOnly = True
        End With

        With udtGridCol(2)                                                  ' 『表示順』項目
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "DISPORDER"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Center
            .blnReadOnly = True
        End With

        For lngCnt = 0 To UBound(udtGridCol) - 1                            ' 各列定義をテーブルスタイルに追加
            Call GS_GridAddColumn(udtGridCol(lngCnt), objTs)
        Next
        objTs.AllowSorting = False                                          ' 列見出しクリックによるソートを禁止
        objTs.RowHeadersVisible = False

        With grd_AdvList
            .TableStyles.Clear()                                            ' 一旦、全てクリアする
            .TableStyles.Add(objTs)                                         ' テーブルスタイルをDataGridに追加
            .ReadOnly = True                                                ' 編集禁止
        End With

        '------------------------------
        ' グリッド生成
        '------------------------------
        dtsList = New DataSet("ImgList2")
        objTable = New DataTable("IMAGELIST3")

        For lngCnt = 0 To UBound(udtGridCol) - 1
            Call GS_GridAddTable(udtGridCol(lngCnt), objTable)
        Next

        '------------------------------
        ' データ値設定
        '------------------------------
        Try
            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, dtrData) Then
                    GoTo SYSTEM_ERROR
                End If

                dtrRows = objTable.NewRow
                dtrRows(udtGridCol(0).strMapName) = g_udtAppConfig.strAdvPath & "\" & Trim$(dtrData("FILENM"))
                dtrRows(udtGridCol(1).strMapName) = Trim$(dtrData("ADV_ID"))
                dtrRows(udtGridCol(2).strMapName) = Trim$(dtrData("DISPORDER"))
                objTable.Rows.Add(dtrRows)
                lngCnt = lngCnt + 1
            End While
        Catch
            GoTo SYSTEM_ERROR
        End Try

        dtsList.Tables.Add(objTable)                                        ' テーブルをDataSetに追加する
        grd_AdvList.SetDataBinding(dtsList, "IMAGELIST3")                   ' DataSetとテーブルをDataGridに接続する

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GridSetup_2")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像編集用広告画像一覧グリッド セットアップ処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_GridSetup_3()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objTs As New DataGridTableStyle()                               ' 新しいDataGridTableStyleの作成
        Dim udtGridCol(4) As typGridColumn
        Dim lngCnt As Long
        Dim objData As New DataSet()
        Dim dtsData As New DataSet()
        Dim dtrRows As DataRow = Nothing
        Dim dtrData As DataRow = Nothing
        Dim dtsList As DataSet
        Dim objTable As DataTable

        '------------------------------
        ' 広告選択状態 設定処理
        '------------------------------
        If lst_AdvSel.SelectedIndex = -1 Then
            If lst_AdvSel.Items.Count <> 0 Then
                lst_AdvSel.SelectedIndex = 0
            End If
        End If

        '------------------------------
        ' 表示データ取得処理
        '------------------------------
        If Not LF_GetTPM080_2(objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' テーブルスタイル定義
        '------------------------------
        With objTs
            .MappingName = "IMAGELIST4"                                     ' マップ名を指定
            .PreferredRowHeight = 114                                       ' 標準行高を指定
            .GridLineStyle = DataGridLineStyle.None                         ' グリッドラインを非表示に設定
            .RowHeadersVisible = False
        End With

        '------------------------------
        ' 各項目属性定義
        '------------------------------
        With udtGridCol(0)                                                  ' 『広告画像』項目
            .intType = CNL1920.COLUMN_TYPE.IMAGE_NOEDIT_STYLE
            .strMapName = "PICTURE"
            .strHeadText = "お知らせ画像"
            .blnAllowNull = False
            .lngWidth = 152
            .objAlign = HorizontalAlignment.Center
        End With

        With udtGridCol(1)                                                  ' 『画像ID』項目
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "ADV_ID"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Center
            .blnReadOnly = True
        End With

        With udtGridCol(2)                                                  ' 『表示順』項目
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "DISPORDER"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Center
            .blnReadOnly = True
        End With

        For lngCnt = 0 To UBound(udtGridCol) - 1                            ' 各列定義をテーブルスタイルに追加
            Call GS_GridAddColumn(udtGridCol(lngCnt), objTs)
        Next
        objTs.AllowSorting = False                                          ' 列見出しクリックによるソートを禁止
        objTs.RowHeadersVisible = False

        With grd_AdvList2
            .TableStyles.Clear()                                            ' 一旦、全てクリアする
            .TableStyles.Add(objTs)                                         ' テーブルスタイルをDataGridに追加
            .ReadOnly = True                                                ' 編集禁止
        End With

        '------------------------------
        ' グリッド生成
        '------------------------------
        dtsList = New DataSet("ImgList3")
        objTable = New DataTable("IMAGELIST4")

        For lngCnt = 0 To UBound(udtGridCol) - 1
            Call GS_GridAddTable(udtGridCol(lngCnt), objTable)
        Next

        '------------------------------
        ' データ値設定
        '------------------------------
        Try
            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, dtrData) Then
                    GoTo SYSTEM_ERROR
                End If

                dtrRows = objTable.NewRow
                dtrRows(udtGridCol(0).strMapName) = g_udtAppConfig.strAdvPath & "\" & Trim$(dtrData("FILENM"))
                dtrRows(udtGridCol(1).strMapName) = Trim$(dtrData("ADV_ID"))
                dtrRows(udtGridCol(2).strMapName) = Trim$(dtrData("DISPORDER"))
                objTable.Rows.Add(dtrRows)
                lngCnt = lngCnt + 1
            End While
        Catch
            GoTo SYSTEM_ERROR
        End Try

        dtsList.Tables.Add(objTable)                                        ' テーブルをDataSetに追加する
        grd_AdvList2.SetDataBinding(dtsList, "IMAGELIST4")                   ' DataSetとテーブルをDataGridに接続する

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GridSetup_3")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：選択画像一覧生成元フォルダ選択ボタン 押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Fol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Fol.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objFolder As New BrowseFolder()
        Dim strSelPath As String

        Try
            '------------------------------
            ' 初期値設定
            '------------------------------
            strSelPath = objFolder.BrowseDialog("フォルダを指定してください。", Me)
            If strSelPath = g_udtAppConfig.strAdvPath Then
                Call GF_Msg("E02", "", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                txt_ImgPath.Text = strSelPath
                If Len(Trim$(txt_ImgPath.Text)) <> 0 Then
                    '------------------------------
                    ' 選択画像リスト生成
                    '------------------------------
                    Call LS_GridSetup_1()
                End If
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Fol_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：選択画像一覧カレントセル位置変化時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub grd_ImgList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_ImgList.Click
        Call LS_PictureSelect(grd_ImgList, TLBMODE.ADDMODE)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告画像一覧カレントセル位置変化時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub grd_AdvList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_AdvList.Click
        Call LS_PictureSelect(grd_AdvList, TLBMODE.EDITMODE)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像編集用選択画像一覧カレントセル位置変化時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub grd_AdvList2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_AdvList2.Click
        Call LS_PictureSelect2(grd_AdvList2)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：選択、広告画像選択処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_PictureSelect(ByVal pGridObj As DataGrid, ByVal pSelMode As TLBMODE)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCell As DataGridCell
        Dim strFile As String
        Dim objFileSys As System.IO.FileStream

        If GF_GetRowCnt(pGridObj) = 0 Then
            Exit Sub
        End If

        '------------------------------
        ' 初期値設定
        '------------------------------
        Me.Cursor = Cursors.WaitCursor

        objCell = pGridObj.CurrentCell
        strFile = pGridObj(objCell.RowNumber, 0)
        L_strSelFile = strFile
        If Len(Dir(strFile)) = 0 Then
            Exit Sub
        End If

        objFileSys = New System.IO.FileStream(strFile, IO.FileMode.Open, IO.FileAccess.Read)
        L_objGraph.DrawImage(System.Drawing.Image.FromStream(objFileSys), _
                             0, _
                             0, _
                             GC_ADVPIC_W, _
                             GC_ADVPIC_H)                                   ' 指定画像の描画
        pic_ViewArea.Refresh()                                              ' 編集域の強制再描画

        objFileSys.Close()

        Erase L_objUndo                                                     ' アンドゥ情報のクリア

        '------------------------------
        ' 追加・削除ボタン使用可否設定
        '------------------------------
        Call LS_SetButton(pSelMode)

        Me.Cursor = Cursors.Default

        Exit Sub

SYSTEM_ERROR:
        Me.Cursor = Cursors.Default
        Call GS_ErrorTerm("LS_PictureSelect")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像編集用選択画像選択処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_PictureSelect2(ByVal pGridObj As DataGrid)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCell As DataGridCell
        Dim strFile As String
        Dim objFileSys As System.IO.FileStream

        If GF_GetRowCnt(pGridObj) = 0 Then
            Exit Sub
        End If

        '------------------------------
        ' 初期値設定
        '------------------------------
        Me.Cursor = Cursors.WaitCursor

        objCell = pGridObj.CurrentCell
        strFile = pGridObj(objCell.RowNumber, 0)
        L_strSelFile = strFile
        If Len(Dir(strFile)) = 0 Then
            Exit Sub
        End If

        objFileSys = New System.IO.FileStream(strFile, IO.FileMode.Open, IO.FileAccess.Read)
        L_objGraph.DrawImage(System.Drawing.Image.FromStream(objFileSys), _
                             0, _
                             0, _
                             GC_ADVPIC_W, _
                             GC_ADVPIC_H)                                   ' 指定画像の描画
        pic_EditArea.Refresh()                                              ' 編集域の強制再描画

        '------------------------------
        ' 商品詳細遷移情報設定処理
        '------------------------------
        LF_SetAdvGoodsCD(pGridObj(objCell.RowNumber, 1))

        objFileSys.Close()

        Erase L_objUndo                                                     ' アンドゥ情報のクリア

        Me.Cursor = Cursors.Default

        Exit Sub

SYSTEM_ERROR:
        Me.Cursor = Cursors.Default
        Call GS_ErrorTerm("LS_PictureSelect2")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品詳細遷移情報設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2006.01.16 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_SetAdvGoodsCD(ByVal pstrAdvID As String) As Object

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strAdvGrpID As String
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_SetAdvGoodsCD = Nothing
        'chk_Order.Checked = False
        txt_GoodsCD.Text = ""
        lbl_Menu.Text = ""

        '------------------------------
        ' 表示中の広告グループ取得
        '------------------------------
        strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)

        strSQL = ""
        strSQL = strSQL & "SELECT TPM080.ORDERFLG,"
        strSQL = strSQL & "       TPM080.GOODSCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ"
        strSQL = strSQL & "  FROM TPM080,"
        strSQL = strSQL & "       TPM010"
        strSQL = strSQL & " WHERE TPM080.ADVGRP_ID = '" & strAdvGrpID & "'"
        strSQL = strSQL & "   AND TPM080.ADV_ID    = '" & pstrAdvID & "'"
        strSQL = strSQL & "   AND TPM080.GOODSCD   = TPM010.GOODSCD"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count > 0 Then
            If Not GF_GetRows(objData, 0, objRow) Then
                Exit Function
            End If
        Else
            chk_Order.Checked = False
            Exit Function
        End If

        If objRow("ORDERFLG") = "1" Then
            chk_Order.Checked = True
            txt_GoodsCD.Text = objRow("GOODSCD")
            lbl_Menu.Text = objRow("GOODSNMJ")
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像編集域 再描画時処理(画像選択時)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub pic_ViewArea_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pic_ViewArea.Paint
        e.Graphics.DrawImage(L_objBitmap, 0, 0, pic_ViewArea.Width, pic_ViewArea.Height)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像編集域 再描画時処理(画像編集時)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub pic_EditArea_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pic_EditArea.Paint
        e.Graphics.DrawImage(L_objBitmap, 0, 0, pic_EditArea.Width, pic_EditArea.Height)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像編集域 描画モード時におけるマウスＩＮ時処理(画像編集時)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub pic_EditArea_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_EditArea.MouseEnter
        If L_DrawFlg = False Then
            Exit Sub
        End If

        Me.Cursor = Cursors.Cross
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像編集域 描画モード時におけるマウスＯＵＴ時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub pic_EditArea_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_EditArea.MouseLeave
        If L_DrawFlg = False Then
            Exit Sub
        End If

        Me.Cursor = Cursors.Default
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像編集域 描画モード時におけるマウス移動時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub pic_EditArea_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_EditArea.MouseMove

        If L_DrawFlg = False Then
            Exit Sub
        End If

        If L_lngDrawCnt <> 0 Then
            Call LS_Undo()
        End If
        Call LS_DrawString(e.X, e.Y)

        L_lngDrawCnt = L_lngDrawCnt + 1

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像編集域 描画モード時におけるマウスボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub pic_EditArea_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_EditArea.MouseDown

        If L_DrawFlg = False Then
            Exit Sub
        End If

        Call LS_Undo()
        Call LS_DrawString(e.X, e.Y)

        L_DrawFlg = False
        Me.Cursor = Cursors.Default
        L_lngDrawCnt = 0
        chk_Draw.Checked = False

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像編集域 文字列描画処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_DrawString(ByVal plngX As Long, ByVal plngY As Long)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim lngX As Long
        Dim lngY As Long

        Try
            '------------------------------
            ' 初期値設定
            '------------------------------
            lngX = plngX * (GC_ADVPIC_W / pic_EditArea.Width)
            lngY = plngY * (GC_ADVPIC_H / pic_EditArea.Height)

            '------------------------------
            ' 文字列描画処理
            '------------------------------
            L_objGraph.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            If chk_Shadow.Checked Then
                L_objGraph.DrawString(txt_WriteMsg.Text, _
                                      L_objFont, _
                                      System.Drawing.Brushes.LightGray, _
                                      lngX + 2, _
                                      lngY + 2)
            End If
            L_objGraph.DrawString(txt_WriteMsg.Text, _
                                  L_objFont, _
                                  New SolidBrush(L_objColor), _
                                  lngX, _
                                  lngY)
            pic_EditArea.Refresh()

            '------------------------------
            ' 操作履歴保持処理
            '------------------------------
            If IsNothing(L_objUndo) Then
                lngCnt = 0
            Else
                lngCnt = UBound(L_objUndo)
            End If
            ReDim Preserve L_objUndo(lngCnt + 1)
            With L_objUndo(lngCnt)
                .strWriteString = txt_WriteMsg.Text
                .objFontStyle = L_objFont
                .objDrawColor = New SolidBrush(L_objColor)
                .lngX = lngX
                .lngY = lngY
                .blnUndo = chk_Shadow.Checked
            End With
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_DrawString")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：文字列描画モード遷移処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_DrawModeChg()

        Try
            If Len(Trim$(L_strSelFile)) = 0 Then
                Exit Sub
            End If

            L_DrawFlg = chk_Draw.Checked

            If L_DrawFlg = False Then
                L_lngDrawCnt = 0
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_DrawModeChg")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：新規広告情報登録画面表示／追加機能
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_AddAdvGrp()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strAdvGrpID As String
        Dim strAdvGrpNM As String

        Try
            strAdvGrpID = LF_GetMaxGrpID()
            strAdvGrpNM = InputBox("■ 追加するお知らせ名を入力してください", g_udtAppConfig.strAppName)

            If Len(Trim$(strAdvGrpNM)) = 0 Then
                Exit Sub
            End If

            If GF_LenB(strAdvGrpNM) > 50 Then
                strAdvGrpNM = GF_MidB(strAdvGrpNM, 1, 50)
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        If Not LF_UpdTPM080_1(strAdvGrpID, strAdvGrpNM, "000", "000", "0", "     ") Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' 広告情報選択コンボ生成
        '------------------------------
        Call LS_SetAdvList()
        'L_blnEditFlg = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AddAdvGrp")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：新規広告情報削除メッセージ表示／削除機能
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_DelAdvGrp()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strAdvGrpID As String

        If lst_AdvSel.SelectedIndex = -1 Then
            Exit Sub
        End If

        Try
            If GF_Msg("", Replace(GF_GetMsg("Q05"), "@@@", Trim$(GF_LstGetString(lst_AdvSel, lst_AdvSel.SelectedIndex))), MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then

                strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)

                '------------------------------
                ' 表示中メニュー削除前チェック
                '------------------------------
                If LF_GetTPM040(strAdvGrpID) = False Then
                    Call GF_Msg("", "タッチパネルに表示中のため削除できません。" & vbCrLf & "開店処理より表示中のお知らせを変更後、再度実施してください。", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                If GF_Msg("A01", "", MsgBoxStyle.YesNo, MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                    If Not LF_UpdTPM080_5(strAdvGrpID) Then
                        GoTo SYSTEM_ERROR
                    End If

                    '------------------------------
                    ' 広告画像リスト生成
                    '------------------------------
                    Call LS_GridSetup_2()

                    '------------------------------
                    ' 広告情報選択コンボ生成
                    '------------------------------
                    Call LS_SetAdvList()
                    'L_blnEditFlg = True
                End If
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_DelAdvGrp")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：システム管理マスタ 取得処理
    ' 　機能概要：選択中お知らせ情報の削除不可チェック
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM040(ByVal pAdvGrpId As String) As Boolean

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
        strSQL = strSQL & "SELECT DEFADVID"
        strSQL = strSQL & "  FROM TPM040"
        strSQL = strSQL & " WHERE DEFADVID = '" & pAdvGrpId & "'"

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
    ' 　機　　能：追加・削除ボタン使用可否設定
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetButton(ByVal pMode As TLBMODE)

        Select Case pMode
            Case TLBMODE.INITMODE                    '初期設定時
                Me.btn_Add.Enabled = False
                Me.btn_Del.Enabled = False
                Me.btn_Up.Enabled = False
                Me.btn_Dwn.Enabled = False

            Case TLBMODE.ADDMODE                     '追加モード時
                Me.btn_Add.Enabled = True
                Me.btn_Del.Enabled = False
                Me.btn_Up.Enabled = False
                Me.btn_Dwn.Enabled = False

            Case TLBMODE.EDITMODE                    '削除モード時
                Me.btn_Add.Enabled = False
                Me.btn_Del.Enabled = True
                Me.btn_Up.Enabled = True
                Me.btn_Dwn.Enabled = True

            Case Else
                Exit Sub
        End Select

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォント選択ダイアログ表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_ShowFontDialog()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objFontDialog As New FontDialog()

        '------------------------------
        ' フォント選択ダイアログ表示
        '------------------------------
        With objFontDialog
            .Font = L_objFont
            .MaxSize = 90
            .MinSize = 10
            .FontMustExist = True
            .AllowVerticalFonts = True
            .ShowColor = False
            .ShowEffects = True
            .FixedPitchOnly = False
            .AllowVectorFonts = True

            If .ShowDialog <> DialogResult.Cancel Then
                L_objFont = .Font
            End If
        End With

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：描画色選択ダイアログ表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_ShowColorDialog()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objColorDialog As New ColorDialog()

        '------------------------------
        ' 色選択ダイアログ表示
        '------------------------------
        With objColorDialog
            .SolidColorOnly = True
            .AllowFullOpen = True
            .ShowHelp = False
            .Color = txt_WriteMsg.ForeColor

            If .ShowDialog <> DialogResult.Cancel Then
                L_objColor = .Color
            End If
        End With

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：アンドゥ処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_Undo()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim objFileSys As System.IO.FileStream

        ' アンドゥ情報が存在しない場合は、処理対象外とする
        If IsNothing(L_objUndo) Then
            Exit Sub
        Else
            If UBound(L_objUndo) = 0 Then
                Exit Sub
            End If
        End If

        Try
            '------------------------------
            ' 現在選択中の画像を取得
            '------------------------------
            ReDim Preserve L_objUndo(UBound(L_objUndo) - 1)

            '------------------------------
            ' アンドゥ情報と併せて再描画
            '------------------------------
            objFileSys = New System.IO.FileStream(L_strSelFile, IO.FileMode.Open, IO.FileAccess.Read)
            With L_objGraph
                .DrawImage(System.Drawing.Image.FromStream(objFileSys), 0, 0, GC_ADVPIC_W, GC_ADVPIC_H)
                objFileSys.Close()

                For lngCnt = 0 To UBound(L_objUndo) - 1
                    If L_objUndo(lngCnt).blnUndo Then
                        .DrawString(L_objUndo(lngCnt).strWriteString, _
                                    L_objUndo(lngCnt).objFontStyle, _
                                    System.Drawing.Brushes.LightGray, _
                                    L_objUndo(lngCnt).lngX + 2, _
                                    L_objUndo(lngCnt).lngY + 2)
                    End If
                    .DrawString(L_objUndo(lngCnt).strWriteString, _
                                L_objUndo(lngCnt).objFontStyle, _
                                L_objUndo(lngCnt).objDrawColor, _
                                L_objUndo(lngCnt).lngX, _
                                L_objUndo(lngCnt).lngY)
                Next
            End With

            pic_EditArea.Refresh()
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_Undo")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：編集画像追加処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_AdvImgAdd()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strAdvGrpID As String
        Dim strAdvID As String
        Dim strAdvGrpNM As String
        Dim strAdvNum As String
        Dim objCell As DataGridCell
        Dim strOrderFlg As String
        Dim strGoodsCD As String

        Try
            '------------------------------
            ' 事前情報収集
            '------------------------------
            If lst_AdvSel.SelectedIndex = -1 Then
                Call GF_Msg("E04", "", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                Exit Sub
            Else
                strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)
                strAdvGrpNM = GF_LstGetString(lst_AdvSel, lst_AdvSel.SelectedIndex)
                strAdvID = LF_GetMaxID()
                strAdvNum = LF_GetMaxCount(strAdvGrpID, Format$(CLng(strAdvID) - 1, "000"))
                strOrderFlg = IIf(chk_Order.Checked = True, 1, 0)
                strGoodsCD = txt_GoodsCD.Text
            End If

            If Len(Trim$(strAdvGrpID)) = 0 Or _
               Len(Trim$(strAdvNum)) = 0 Then
                GoTo SYSTEM_ERROR
            End If

            '------------------------------
            ' 画像保存処理
            '------------------------------
            If Not LF_SaveImage(strAdvGrpID, strAdvID) Then
                GoTo SYSTEM_ERROR
            End If

            '------------------------------
            ' ＤＢ保存処理
            '------------------------------
            If Not LF_UpdTPM080_1(strAdvGrpID, strAdvGrpNM, strAdvID, strAdvNum, strOrderFlg, strGoodsCD) Then
                GoTo SYSTEM_ERROR
            End If

            '------------------------------
            ' 総容量チェック処理
            '------------------------------
            Select Case GF_AdvGrpLengthChk(strAdvGrpID)
                Case CNL1920.FuncResult.CancelEnd
                    Call GF_Msg("", "お知らせグループ [" & Trim$(strAdvGrpNM) & "] の容量が制限値を超えました" & vbCrLf & _
                                    "タッチパネルへの表示ができないため、いずれかのお知らせ画像を削除してください", _
                                MsgBoxStyle.Exclamation, _
                                MsgBoxStyle.OkOnly)

                    If Not LF_UpdTPM080_2(strAdvGrpID, strAdvID) Then
                        GoTo SYSTEM_ERROR
                    End If
                    Exit Sub

                Case CNL1920.FuncResult.UnusualEnd
                    GoTo SYSTEM_ERROR
            End Select

            Erase L_objUndo

            '------------------------------
            ' 広告画像リスト生成
            '------------------------------
            Call LS_GridSetup_2()

            '------------------------------
            ' 追加・削除ボタン使用可否設定
            '------------------------------
            Call LS_SetButton(TLBMODE.INITMODE)

            With objCell
                .RowNumber = CInt(GF_GetRowCnt(grd_AdvList)) - 1
                .ColumnNumber = 0
            End With
            grd_AdvList.CurrentCell = objCell

            '------------------------------
            ' 選択画像領域クリア
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

    ' --------------------------------------------------------------------------------
    ' 　機　　能：編集画像保存処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_SaveImage(ByVal pAdvGrpID As String, ByVal pAdvID As String) As Boolean

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_SaveImage = False

        Try
            '------------------------------
            ' エンコード方式の指定
            '------------------------------
            Dim myEncoderParameters As New System.Drawing.Imaging.EncoderParameters(1)
            Dim myEncoderParameter As New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 99)
            myEncoderParameters.Param(0) = myEncoderParameter

            '------------------------------
            ' 保存形式の指定
            '------------------------------
            Dim myImageCodecInfo As System.Drawing.Imaging.ImageCodecInfo
            myImageCodecInfo = GF_GetEncoderInfo("image/jpeg")
            Dim ext As String = myImageCodecInfo.FilenameExtension.Split(";"c)(0)
            ext = System.IO.Path.GetExtension(ext).ToLower()

            '------------------------------
            ' 保存処理
            '------------------------------
            Dim saveName As String
            saveName = System.IO.Path.ChangeExtension(LF_AdvFileNm(pAdvGrpID, pAdvID), ext)
            L_objBitmap.Save(saveName, myImageCodecInfo, myEncoderParameters)

        Catch
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_SaveImage = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告画像ファイル名生成処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_AdvFileNm(ByVal pAdvGrpID As String, ByVal pAdvID As String, Optional ByVal pFullRet As Boolean = True) As String

        If pFullRet Then
            LF_AdvFileNm = g_udtAppConfig.strAdvPath & "\"
        Else
            LF_AdvFileNm = ""
        End If
        LF_AdvFileNm = LF_AdvFileNm & pAdvGrpID & pAdvID & ".jpg"

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：編集画像更新処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_AdvImgUpd()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCell As DataGridCell
        Dim strAdvGrpID As String
        Dim strAdvID As String
        Dim strAdvNum As String
        'Dim intOrderFlg As Integer
        'Dim strGoodsCD As String
        Dim intUpdate As Integer

        Try
            intUpdate = 0

            If IsNothing(L_objUndo) Then
                intUpdate = 1
            Else
                If UBound(L_objUndo) = 0 Then
                    intUpdate = 1
                End If
            End If

            objCell = grd_AdvList2.CurrentCell
            strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)
            strAdvID = grd_AdvList2(objCell.RowNumber, 1)
            strAdvNum = grd_AdvList2(objCell.RowNumber, 2)

            If intUpdate = 0 Then
                Me.Cursor = Cursors.WaitCursor

                If Not LF_SaveImage(strAdvGrpID, strAdvID) Then
                    GoTo SYSTEM_ERROR
                End If

                Me.Cursor = Cursors.Default

                Erase L_objUndo

                '------------------------------
                ' 画像編集用広告画像リスト生成
                '------------------------------
                Call LS_GridSetup_3()
                grd_AdvList2.CurrentCell = objCell
            End If

            ''------------------------------
            '' 商品詳細遷移情報更新処理
            ''------------------------------
            'intOrderFlg = IIf(chk_Order.Checked = True, 1, 0)
            'strGoodsCD = txt_GoodsCD.Text
            'If Not LF_UpdTPM080_6(strAdvID, intOrderFlg, strGoodsCD) Then
            '    GoTo SYSTEM_ERROR
            'End If

            '------------------------------
            ' 選択画像領域クリア
            '------------------------------
            L_objBitmap = New Bitmap(GC_ADVPIC_W, GC_ADVPIC_H, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
            L_objGraph = Graphics.FromImage(L_objBitmap)
            pic_EditArea.Refresh()
            L_strSelFile = ""
            chk_Order.Checked = False
            txt_GoodsCD.Text = ""
            lbl_Menu.Text = ""
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AdvImgUpd")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：編集画像削除処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_AdvImgDel()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strAdvGrpID As String
        Dim strAdvID As String
        Dim strDispOrder As String
        Dim objCell As DataGridCell
        Dim objRow As DataRow = Nothing

        '------------------------------
        ' 事前情報取得
        '------------------------------
        Try
            objCell = grd_AdvList.CurrentCell
            strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)
            strAdvID = grd_AdvList(objCell.RowNumber, 1)
            strDispOrder = grd_AdvList(objCell.RowNumber, 2)
        Catch
            GoTo SYSTEM_ERROR
        End Try

        '------------------------------
        ' 表示中お知らせ 判定チェック
        '------------------------------
        If LF_GetTPM040(strAdvGrpID) = False Then
            '------------------------------
            ' 選択お知らせ表示件数取得処理
            '------------------------------
            If Not LF_GetTPM080_3(objRow) Then
                GoTo SYSTEM_ERROR
            End If

            '------------------------------
            ' 現在設定値 表示処理
            '------------------------------
            If Trim$(objRow("RECCNT")) <= 1 Then
                Call GF_Msg("", "タッチパネルに表示中のお知らせのため、" & vbCrLf & "１件以上の登録が必要です。", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        '------------------------------
        ' ＤＢ更新処理
        '------------------------------
        If Not LF_UpdTPM080_2(strAdvGrpID, strAdvID) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' 広告画像リスト生成
        '------------------------------
        Call LS_GridSetup_2()

        '------------------------------
        ' 追加・削除ボタン使用可否設定
        '------------------------------
        Call LS_SetButton(TLBMODE.INITMODE)

        Try
            '------------------------------
            ' 選択画像領域クリア
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

    ' --------------------------------------------------------------------------------
    ' 　機　　能：編集文字列入力時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_WriteMsg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_WriteMsg.TextChanged

        '------------------------------
        ' ユーザー入力時のみ処理対象
        '------------------------------
        If txt_WriteMsg.Modified = False Then
            Exit Sub
        End If

        L_DrawFlg = False
        L_lngDrawCnt = 0
        chk_Draw.Checked = False

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：編集後画像一覧 表示順位変更処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_ChgRank(ByVal pProcKbn As Boolean)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCell As DataGridCell
        Dim lngMaxRow As Long
        Dim strDispOrder As String
        Dim strTargetOrder As String
        Dim strTargetAdvID As String
        Dim strAdvID As String

        Try
            '------------------------------
            ' 初期値設定
            '------------------------------
            objCell = grd_AdvList.CurrentCell                                   ' カレントセル位置取得
            lngMaxRow = GF_GetRowCnt(grd_AdvList)
            If pProcKbn Then                                                    ' 処理区分により、処理禁止位置判定
                If objCell.RowNumber <= 0 Then
                    Exit Sub
                End If
            Else
                If objCell.RowNumber >= (lngMaxRow - 1) Then
                    Exit Sub
                End If
            End If

            ' 順位変更対象画像の情報取得
            strDispOrder = grd_AdvList(objCell.RowNumber, 2)
            strAdvID = grd_AdvList(objCell.RowNumber, 1)

            ' 順位変更後の情報取得
            If pProcKbn Then
                strTargetOrder = grd_AdvList(objCell.RowNumber - 1, 2)
                strTargetAdvID = grd_AdvList(objCell.RowNumber - 1, 1)
            Else
                strTargetOrder = grd_AdvList(objCell.RowNumber + 1, 2)
                strTargetAdvID = grd_AdvList(objCell.RowNumber + 1, 1)
            End If

            '------------------------------
            ' 広告画像一覧リソース一時解放
            '------------------------------
            grd_AdvList.DataSource = Nothing
            grd_AdvList.TableStyles.Clear()

            ' 手順１：変更元→DUMMY
            If Not LF_UpdTPM080_3(strAdvID, "000", strDispOrder) Then
                GoTo SYSTEM_ERROR
            End If

            ' 手順２：変更先→(空き番となった)変更元
            If Not LF_UpdTPM080_3(strTargetAdvID, strDispOrder, strTargetOrder) Then
                GoTo SYSTEM_ERROR
            End If

            ' 手順３：DYMMY→(空き番となた)変更先
            If Not LF_UpdTPM080_3(strAdvID, strTargetOrder, "000") Then
                GoTo SYSTEM_ERROR
            End If

            '------------------------------
            ' 広告画像リスト生成
            '------------------------------
            Call LS_GridSetup_2()

            If pProcKbn Then
                objCell.RowNumber = objCell.RowNumber - 1
            Else
                objCell.RowNumber = objCell.RowNumber + 1
            End If
            grd_AdvList.CurrentCell = objCell
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_ChgRank")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告名称項目 変化時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_AdvNm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_AdvNm.TextChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strWork() As String

        '------------------------------
        ' キーボード入力時以外は処理対象外
        '------------------------------
        If txt_AdvNm.Modified = False Then
            Exit Sub
        End If

        If lst_AdvSel.SelectedIndex = -1 Then
            Exit Sub
        End If

        Try
            If GF_LenB(txt_AdvNm.Text) > 50 Then
                txt_AdvNm.Text = GF_MidB(txt_AdvNm.Text, 1, 50)
                txt_AdvNm.SelectionStart = GF_LenB(txt_AdvNm.Text)
                Exit Sub
            End If

            '------------------------------
            ' 広告画像リスト更新
            '------------------------------
            strWork = Split(lst_AdvSel.Items(lst_AdvSel.SelectedIndex), vbTab)
            lst_AdvSel.Items(lst_AdvSel.SelectedIndex) = Trim$(txt_AdvNm.Text) & Space(100) & vbTab & strWork(1)
        Catch
            GoTo SYSTEM_ERROR
        End Try

        '------------------------------
        ' 広告情報マスタ更新
        '------------------------------
        If Not LF_UpdTPM080_4(strWork(1), Trim$(txt_AdvNm.Text)) Then
            GoTo SYSTEM_ERROR
        End If
        'L_blnEditFlg = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_AdvNm_TextChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告画像情報マスタ 取得 - (１)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM080_1(ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM080_1 = False

        '------------------------------
        ' 広告画像情報マスタ 抽出
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT ADVGRP_ID,"
        strSQL = strSQL & "       ADVGRP_NM"
        strSQL = strSQL & "  FROM TPM080"
        strSQL = strSQL & " GROUP BY ADVGRP_ID,"
        strSQL = strSQL & "          ADVGRP_NM"
        strSQL = strSQL & " ORDER BY ADVGRP_ID"

        If Not GF_GetData(strSQL, pDataSet) Then
            Exit Function
        End If

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM080_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告画像情報マスタ 取得 - (２)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM080_2(ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM080_2 = False

        '------------------------------
        ' 広告画像情報マスタ 抽出
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT ADV_ID,"
        strSQL = strSQL & "       DISPORDER,"
        strSQL = strSQL & "       FILENM,"
        strSQL = strSQL & "       ENABLED"
        strSQL = strSQL & "  FROM TPM080"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex) & "'"
        strSQL = strSQL & "   AND ADV_ID    <> '000'"
        strSQL = strSQL & "   AND DISPORDER <> '000'"
        strSQL = strSQL & " ORDER BY DISPORDER"

        If Not GF_GetData(strSQL, pDataSet) Then
            Exit Function
        End If

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM080_2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告画像情報マスタ 取得 - (３)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM080_3(ByRef pRows As DataRow) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM080_3 = False

        '------------------------------
        ' 広告画像情報マスタ 抽出
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT COUNT(*) AS RECCNT"
        strSQL = strSQL & "  FROM TPM080"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex) & "'"
        strSQL = strSQL & "   AND ADV_ID    <> '000'"
        strSQL = strSQL & "   AND DISPORDER <> '000'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, pRows) Then
            Exit Function
        End If

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM080_3 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告画像グループＩＤ採番処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetMaxGrpID() As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetMaxGrpID = ""

        '------------------------------
        ' 最終連番取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT MAX(ADVGRP_ID) AS MAXGRPID"
        strSQL = strSQL & "  FROM TPM080"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        If IsDBNull(objRows("MAXGRPID")) Then
            LF_GetMaxGrpID = "K" & Format$(CLng(Mid$(Trim$("K00"), 2, 2)) + 1, "00")
        Else
            LF_GetMaxGrpID = "K" & Format$(CLng(Mid$(Trim$(objRows("MAXGRPID")), 2, 2)) + 1, "00")
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告画像ＩＤ採番処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetMaxID() As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetMaxID = ""

        '------------------------------
        ' 最終連番取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT MAX(ADV_ID) AS MAXID"
        strSQL = strSQL & "  FROM TPM080"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex) & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        If IsDBNull(objRows("MAXID")) Then
            LF_GetMaxID = Format$(CLng(Trim$("000")) + 1, "000")
        Else
            LF_GetMaxID = Format$(CLng(Trim$(objRows("MAXID"))) + 1, "000")
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：表示順採番処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetMaxCount(ByVal pAdvGrpID As String, ByVal pAdvID As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetMaxCount = ""
        If Len(Trim$(pAdvGrpID)) = 0 Or Len(Trim$(pAdvID)) = 0 Then Exit Function

        '------------------------------
        ' 最終連番取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT MAX(DISPORDER) AS MAXNUM"
        strSQL = strSQL & "  FROM TPM080"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & Trim$(pAdvGrpID) & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        If IsDBNull(objRows("MAXNUM")) Then
            LF_GetMaxCount = Format$(CLng(Trim$("000")) + 1, "000")
        Else
            LF_GetMaxCount = Format$(CLng(Trim$(objRows("MAXNUM"))) + 1, "000")
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告画像情報マスタ更新処理(１)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM080_1(ByVal pAdvGrpID As String, ByVal pAdvGrpNm As String, _
    ByVal pAdvID As String, ByVal pDispOrder As String, ByVal pOrderFlg As String, ByVal pGoodsCD As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM080_1 = False

        '------------------------------
        ' 追加文字列生成
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM080 VALUES("
        strSQL = strSQL & "'" & pAdvGrpID & "',"
        strSQL = strSQL & "'" & GF_RepQuo(pAdvGrpNm) & "',"
        strSQL = strSQL & "'" & pAdvID & "',"
        strSQL = strSQL & "'" & pDispOrder & "',"
        strSQL = strSQL & "'" & LF_AdvFileNm(pAdvGrpID, pAdvID, False) & "',"
        strSQL = strSQL & "'" & GC_TRUE & "',"
        strSQL = strSQL & "'" & pOrderFlg & "',"
        strSQL = strSQL & "'" & pGoodsCD & "',"
        strSQL = strSQL & "'" & GC_UPDID & "',"
        strSQL = strSQL & "'" & Now & "'"
        strSQL = strSQL & ")"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM080_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告画像情報マスタ更新処理(２)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM080_2(ByVal pAdvGrpID As String, ByVal pAdvID As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM080_2 = False

        '------------------------------
        ' 追加文字列生成
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE FROM TPM080"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & pAdvGrpID & "'"
        strSQL = strSQL & "   AND ADV_ID    = '" & pAdvID & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM080_2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告画像情報マスタ更新処理(３)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM080_3(ByVal pAdvID As String, ByVal pTargetOrder As String, ByVal pOriginalOrder As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strAdvGrpID As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM080_3 = False

        strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)

        '------------------------------
        ' 文字列生成
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM080"
        strSQL = strSQL & "   SET DISPORDER = '" & pTargetOrder & "'"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & strAdvGrpID & "'"
        strSQL = strSQL & "   AND ADV_ID    = '" & pAdvID & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        LF_UpdTPM080_3 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告画像情報マスタ更新処理(４)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM080_4(ByVal pAdvID As String, ByVal pAdvGrpNM As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strAdvGrpID As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM080_4 = False

        strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)

        '------------------------------
        ' 文字列生成
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM080"
        strSQL = strSQL & "   SET ADVGRP_NM = '" & pAdvGrpNM & "'"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & pAdvID & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        LF_UpdTPM080_4 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告画像情報マスタ更新処理(５)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM080_5(ByVal pAdvGrpID As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM080_5 = False

        '------------------------------
        ' 追加文字列生成
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE FROM TPM080"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & pAdvGrpID & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM080_5 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告画像情報マスタ更新処理(６)
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2006.01.16 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM080_6(ByVal pAdvID As String, ByVal pintOrderFlg As Integer, ByVal pstrGoodsCD As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strAdvGrpID As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM080_6 = False

        strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)

        '------------------------------
        ' 文字列生成
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM080"
        strSQL = strSQL & "   SET ORDERFLG  = '" & pintOrderFlg & "',"
        strSQL = strSQL & "       GOODSCD   = '" & IIf(Trim$(pstrGoodsCD) = "", Space(5), pstrGoodsCD) & "',"
        strSQL = strSQL & "       UPDID     = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD    = '" & Now & "'"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & strAdvGrpID & "'"
        strSQL = strSQL & "   AND ADV_ID    = '" & pAdvID & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        LF_UpdTPM080_6 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告画像フォルダ内 未使用画像ファイル削除処理
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

        Try
            '------------------------------
            ' 使用中画像ファイル一覧取得
            '------------------------------
            strSQL = ""
            strSQL = strSQL & "SELECT FILENM"
            strSQL = strSQL & "  FROM TPM080"
            strSQL = strSQL & " WHERE LEN(LTRIM(FILENM)) <> 0"
            strSQL = strSQL & "   AND ADV_ID             <> '000'"

            If Not GF_GetData(strSQL, objData) Then
                Exit Function
            End If

            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    Exit Function
                End If
                ReDim Preserve strUFile(lngCnt)
                strUFile(lngCnt) = Trim$(objRows("FILENM"))

                lngCnt = lngCnt + 1
            End While

            '------------------------------
            ' 画像ファイル使用中判定
            '------------------------------
            strItemPath = GF_GetAppInfo("ADV_PATH")
            For Each strFile In System.IO.Directory.GetFiles(strItemPath)
                blnFound = False
                If Not IsNothing(strUFile) Then
                    objFileInfo = New System.IO.FileInfo(strFile)
                    For Each strWork In strUFile
                        If objFileInfo.Name = strWork Then
                            blnFound = True
                        End If
                    Next
                    objFileInfo = Nothing
                End If

                '------------------------------
                ' 未使用ファイルであれば削除
                '------------------------------
                If Not blnFound Then
                    Call System.IO.File.SetAttributes(strFile, IO.FileAttributes.Normal)
                    Call System.IO.File.Delete(strFile)
                    Debug.WriteLine(strFile)
                End If

            Next
        Catch
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_DelUnuseFile = True

    End Function

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品詳細用選択ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Goods_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Goods.Click

        '------------------------------
        ' 初期値設定
        '------------------------------
        Dim objForm As New CNL1561()
        Dim objCell As DataGridCell
        Dim strAdvID As String
        Dim intOrderFlg As Integer
        Dim strGoodsCD As String

        With objForm
            .StartPosition = FormStartPosition.CenterParent
            .FormBorderStyle = FormBorderStyle.FixedDialog
            .ShowInTaskbar = False
            .MaximizeBox = False
            .MinimizeBox = False
            .ControlBox = False
            .MaximumSize = .Size
            .G_Code = txt_GoodsCD.Text
            If .ShowDialog() = DialogResult.OK Then
                lbl_Menu.Text = objForm.G_Menu
                txt_GoodsCD.Text = objForm.G_Code

                If L_strSelFile = "" Then
                    '------------------------------
                    ' 商品画像表示
                    '------------------------------
                    LF_GetGoodsPic()
                End If

            End If
        End With

        '------------------------------
        ' 商品詳細遷移情報更新処理
        '------------------------------
        If Len(Trim$(L_strSelFile)) = 0 Then
            Exit Sub
        End If

        objCell = grd_AdvList2.CurrentCell
        strAdvID = grd_AdvList2(objCell.RowNumber, 1)
        intOrderFlg = IIf(chk_Order.Checked = True, 1, 0)
        strGoodsCD = txt_GoodsCD.Text

        If Not LF_UpdTPM080_6(strAdvID, intOrderFlg, strGoodsCD) Then
            Exit Sub
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品詳細用解除ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.04.09 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_ClrGoods_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ClrGoods.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objCell As DataGridCell
        Dim strAdvID As String
        Dim strAdvGrpID As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        objCell = grd_AdvList2.CurrentCell
        strAdvID = grd_AdvList2(objCell.RowNumber, 1)

        strAdvGrpID = GF_LstGetCode(lst_AdvSel, lst_AdvSel.SelectedIndex)

        '------------------------------
        ' 文字列生成
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM080"
        strSQL = strSQL & "   SET ORDERFLG  = '0',"
        strSQL = strSQL & "       GOODSCD   = '" & Space(1) & "',"
        strSQL = strSQL & "       UPDID     = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD    = '" & Now & "'"
        strSQL = strSQL & " WHERE ADVGRP_ID = '" & strAdvGrpID & "'"
        strSQL = strSQL & "   AND ADV_ID    = '" & strAdvID & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Sub
        End If

        chk_Order.Checked = False
        btn_Goods.Enabled = False
        btn_ClrGoods.Enabled = False
        txt_GoodsCD.Text = ""
        lbl_Menu.Text = ""

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品詳細用チェックボックス押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub chk_Order_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Order.CheckedChanged

        If chk_Order.Checked = True Then
            btn_Goods.Enabled = True
            btn_ClrGoods.Enabled = True
        Else
            btn_Goods.Enabled = False
            btn_ClrGoods.Enabled = False
            txt_GoodsCD.Text = ""
            lbl_Menu.Text = ""
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品詳細用商品画像表示
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetGoodsPic() As Object

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim strFile As String
        Dim objFileSys As System.IO.FileStream

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetGoodsPic = Nothing

        strSQL = ""
        strSQL = strSQL & "SELECT IMAGEDATA"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " WHERE GOODSCD = '" & txt_GoodsCD.Text & "'"

        If Not GF_GetData(strSQL, objData) Then
            Return Nothing
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Return Nothing
        End If

        If Not GF_GetRows(objData, 0, objRow) Then
            Return Nothing
        End If

        strFile = g_udtAppConfig.strImgPath & "\" & Trim$(objRow("IMAGEDATA"))
        If System.IO.File.Exists(strFile) Then
            objFileSys = New System.IO.FileStream(strFile, IO.FileMode.Open, IO.FileAccess.Read)
            L_objGraph.DrawImage(System.Drawing.Image.FromStream(objFileSys), _
                                 0, _
                                 0, _
                                 GC_ADVPIC_W, _
                                 GC_ADVPIC_H)                                   ' 指定画像の描画
            pic_ViewArea.Refresh()                                              ' 編集域の強制再描画

            L_strSelFile = strFile

            '------------------------------
            ' 追加・削除ボタン使用可否設定
            '------------------------------
            Call LS_SetButton(TLBMODE.ADDMODE)

        End If
        '---------------------------------------------------------------------------------------------------
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：「広告の新規追加」ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_AddKo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddKo.Click

        '------------------------------
        ' 新規広告情報登録画面表示／追加
        '------------------------------
        Call LS_AddAdvGrp()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_AddKo_Click")

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：「広告の削除」ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_DelKo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DelKo.Click

        '------------------------------
        ' 新規広告情報削除メッセージ表示／削除
        '------------------------------
        Call LS_DelAdvGrp()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_DelKo_Click")

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
        ' 編集後画像一覧 表示順位変更処理
        '------------------------------
        Call LS_ChgRank(True)

        'L_blnEditFlg = True

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
        ' 編集後画像一覧 表示順位変更処理
        '------------------------------
        LS_ChgRank(False)

        'L_blnEditFlg = True

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：「追加」ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click

        '------------------------------
        ' 編集画像追加処理
        '------------------------------
        Call LS_AdvImgAdd()

        'L_blnEditFlg = True

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：「削除」ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Del.Click

        '------------------------------
        ' 編集画像解除処理
        '------------------------------
        Call LS_AdvImgDel()

        'L_blnEditFlg = True

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        Select Case TabControl1.SelectedIndex
            Case 0
                '------------------------------
                ' 各画像リスト生成
                '------------------------------
                Call LS_GridSetup_2()                                               ' 編集後画像リスト

                '------------------------------
                ' 追加・削除ボタン使用可否設定
                '------------------------------
                Call LS_SetButton(TLBMODE.INITMODE)

            Case 1
                '------------------------------
                ' 各画像リスト生成
                '------------------------------
                Call LS_GridSetup_3()                                               ' 編集後画像リスト

            Case Else
                Exit Sub
        End Select

        txt_WriteMsg.Clear()                                                ' 画像描画メッセージ

        '------------------------------
        ' 選択画像領域クリア
        '------------------------------
        L_objBitmap = New Bitmap(GC_ADVPIC_W, GC_ADVPIC_H, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
        L_objGraph = Graphics.FromImage(L_objBitmap)
        pic_ViewArea.Refresh()
        L_strSelFile = ""
        chk_Order.Checked = False
        txt_GoodsCD.Text = ""
        lbl_Menu.Text = ""
        btn_Goods.Enabled = False
        btn_ClrGoods.Enabled = False
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：「更新」ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Img_Edt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Img_Edt.Click

        '------------------------------
        ' 編集画像更新処理
        '------------------------------
        Call LS_AdvImgUpd()

        'L_blnEditFlg = True

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：「フォント設定」ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Font_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Font.Click

        '------------------------------
        ' フォント選択ダイアログ表示
        '------------------------------
        Call LS_ShowFontDialog()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：「文字色設定」ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Color_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Color.Click

        '------------------------------
        ' 描画色選択ダイアログ表示
        '------------------------------
        Call LS_ShowColorDialog()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：「記入する」ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub chk_Draw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Draw.CheckedChanged

        '------------------------------
        ' 描画モード
        '------------------------------
        Call LS_DrawModeChg()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：「１つ前に戻す」ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Prev.Click

        '------------------------------
        ' アンドゥ処理
        '------------------------------
        Call LS_Undo()

    End Sub
End Class
