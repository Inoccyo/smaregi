Imports System.Threading

' --------------------------------------------------------------------------------
' Å@ã@Å@Å@î\ÅFCrossNavi - è§ïiìoò^âÊñ 
' Å@ã@î\äTóvÅFè»ó™
' Å@à¯Å@Å@êîÅFÇ»Çµ
' Å@ñﬂ ÇË ílÅFÇ»Çµ
' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
' --------------------------------------------------------------------------------
Public Class CNL1530
    Inherits System.Windows.Forms.Form

#Region " Windows ÉtÉHÅ[ÉÄ ÉfÉUÉCÉiÇ≈ê∂ê¨Ç≥ÇÍÇΩÉRÅ[Éh "

    Public Sub New()
        MyBase.New()

        ' Ç±ÇÃåƒÇ—èoÇµÇÕ Windows ÉtÉHÅ[ÉÄ ÉfÉUÉCÉiÇ≈ïKóvÇ≈Ç∑ÅB
        InitializeComponent()

        ' InitializeComponent() åƒÇ—èoÇµÇÃå„Ç…èâä˙âªÇí«â¡ÇµÇ‹Ç∑ÅB

    End Sub

    ' Form ÇÕ dispose ÇÉIÅ[ÉoÅ[ÉâÉCÉhÇµÇƒÉRÉìÉ|Å[ÉlÉìÉgàÍóóÇè¡ãéÇµÇ‹Ç∑ÅB
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Windows ÉtÉHÅ[ÉÄ ÉfÉUÉCÉiÇ≈ïKóvÇ≈Ç∑ÅB
    Private components As System.ComponentModel.IContainer

    ' ÉÅÉÇ : à»â∫ÇÃÉvÉçÉVÅ[ÉWÉÉÇÕÅAWindows ÉtÉHÅ[ÉÄ ÉfÉUÉCÉiÇ≈ïKóvÇ≈Ç∑ÅB
    ' Windows ÉtÉHÅ[ÉÄ ÉfÉUÉCÉiÇégÇ¡ÇƒïœçXÇµÇƒÇ≠ÇæÇ≥Ç¢ÅB  
    ' ÉRÅ[Éh ÉGÉfÉBÉ^ÇÕégópÇµÇ»Ç¢Ç≈Ç≠ÇæÇ≥Ç¢ÅB
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents grd_ItemList As System.Windows.Forms.DataGrid
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents txt_PicPath As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents cbo_SelGroup As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lbl_KCP3 As System.Windows.Forms.Label
    Friend WithEvents lbl_KCP2 As System.Windows.Forms.Label
    Friend WithEvents lbl_KCP1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_TPGoodsNM As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_SelRow As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents btn_SelFol As System.Windows.Forms.Button
    Friend WithEvents grd_PicList As System.Windows.Forms.DataGrid
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents tab_Items As System.Windows.Forms.TabControl
    Friend WithEvents txt_TPGoodsNM2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Price As System.Windows.Forms.TextBox
    Friend WithEvents tax_Price As System.Windows.Forms.TextBox
    Friend WithEvents btn_KPSet As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_OP1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_OP2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_HTLNM1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_HTLNM2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_GoodsNMJ4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbo_OP4 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_OP3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btn_PicClr As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_AddGoods As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents lbl_KCP4 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents chk_game As System.Windows.Forms.CheckBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txt_searchNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txt_ExpNoteJ As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbo_OP5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents chk_Status0 As System.Windows.Forms.CheckBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents chk_Status3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Status1 As System.Windows.Forms.CheckBox
    Friend WithEvents ccp_check As System.Windows.Forms.CheckBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TabPage_MULTI_LING As System.Windows.Forms.TabPage
    Friend WithEvents LabelMenuLanguage2 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents LabelMenuLanguage3 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txt_TPGoodsNM_B As System.Windows.Forms.TextBox
    Friend WithEvents txt_EXPNOTEJ_A As System.Windows.Forms.TextBox
    Friend WithEvents txt_TPGoodsNM2_A As System.Windows.Forms.TextBox
    Friend WithEvents txt_TPGoodsNM_A As System.Windows.Forms.TextBox
    Friend WithEvents txt_EXPNOTEJ_B As System.Windows.Forms.TextBox
    Friend WithEvents txt_TPGoodsNM2_B As System.Windows.Forms.TextBox
    Friend WithEvents txt_EXPNOTEJ_C As System.Windows.Forms.TextBox
    Friend WithEvents txt_TPGoodsNM2_C As System.Windows.Forms.TextBox
    Friend WithEvents txt_TPGoodsNM_C As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cmbPTN2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPTN1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label134 As System.Windows.Forms.Label
    Friend WithEvents Label139 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents LabelMenuLanguage4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chk_TaxKind1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_TaxKind0 As System.Windows.Forms.CheckBox
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblUnitPrice As System.Windows.Forms.Label
    Friend WithEvents lblUntEn As System.Windows.Forms.Label
    Friend WithEvents lblGoodsCnt As System.Windows.Forms.Label
    Friend WithEvents lblCnt As System.Windows.Forms.Label
    Friend WithEvents ButtonRest As System.Windows.Forms.Button
    Friend WithEvents chk_Lane As System.Windows.Forms.CheckBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txt_SubPrice_Reduce As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents lbl_Price As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txt_Price_Reduce As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txt_SubPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents cmb_TaxType As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbt_Ptype_Preset As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_Ptype_Open As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbt_OES_Disabled As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_OES_Enabled As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbt_Takeout_Both As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_Takeout_Eatin As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbt_Discount_Extra As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_Discount_Discount As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbt_Qadd_Enabled As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_Qadd_Disabled As System.Windows.Forms.RadioButton
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents rbt_Takeout_Takeout As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_GoodsCode As System.Windows.Forms.Label
    Friend WithEvents txt_OwnCompanyCode As System.Windows.Forms.TextBox
    Friend WithEvents cmb_TaxType_Reduced As System.Windows.Forms.ComboBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents chk_MenuCdEdit As System.Windows.Forms.CheckBox
    Friend WithEvents txt_MenuCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MenuCode As System.Windows.Forms.Label
    Friend WithEvents chk_Status2 As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Orig_SubPrice As System.Windows.Forms.Label
    Friend WithEvents lbl_Orig_SubPrice_Reduce As System.Windows.Forms.Label
    Friend WithEvents lbl_Orig_Price_Reduce As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents cbo_OP6 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_OP12 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_OP11 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_OP10 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_OP9 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_OP8 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_OP7 As System.Windows.Forms.ComboBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents UpperBox As System.Windows.Forms.TextBox
    Friend WithEvents LowerLabel As System.Windows.Forms.Label
    Friend WithEvents LowerBox As System.Windows.Forms.TextBox
    Friend WithEvents UpperLabel As System.Windows.Forms.Label
    Friend WithEvents txt_TECKCPNM3 As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents txt_HTLNM5 As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents cmb_Bumon As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CNL1530))
        Me.grd_ItemList = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.stb_Msg = New System.Windows.Forms.StatusBar
        Me.txt_PicPath = New System.Windows.Forms.TextBox
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ButtonRest = New System.Windows.Forms.Button
        Me.lblGoodsCnt = New System.Windows.Forms.Label
        Me.lblCnt = New System.Windows.Forms.Label
        Me.txt_Search = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.btn_Save = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_AddGoods = New System.Windows.Forms.Button
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.tab_Items = New System.Windows.Forms.TabControl
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.txt_HTLNM5 = New System.Windows.Forms.TextBox
        Me.Label68 = New System.Windows.Forms.Label
        Me.txt_TECKCPNM3 = New System.Windows.Forms.TextBox
        Me.Label67 = New System.Windows.Forms.Label
        Me.LowerLabel = New System.Windows.Forms.Label
        Me.LowerBox = New System.Windows.Forms.TextBox
        Me.UpperLabel = New System.Windows.Forms.Label
        Me.UpperBox = New System.Windows.Forms.TextBox
        Me.chk_Status2 = New System.Windows.Forms.CheckBox
        Me.cmbPTN2 = New System.Windows.Forms.ComboBox
        Me.cmbPTN1 = New System.Windows.Forms.ComboBox
        Me.Label139 = New System.Windows.Forms.Label
        Me.Label134 = New System.Windows.Forms.Label
        Me.tax_Price = New System.Windows.Forms.TextBox
        Me.txt_Price = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.chk_Status3 = New System.Windows.Forms.CheckBox
        Me.chk_Status1 = New System.Windows.Forms.CheckBox
        Me.chk_Status0 = New System.Windows.Forms.CheckBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.cbo_OP5 = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.lbl_KCP4 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.cmb_Bumon = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbo_OP4 = New System.Windows.Forms.ComboBox
        Me.cbo_OP3 = New System.Windows.Forms.ComboBox
        Me.txt_GoodsNMJ4 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_HTLNM2 = New System.Windows.Forms.TextBox
        Me.txt_HTLNM1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbo_OP2 = New System.Windows.Forms.ComboBox
        Me.cbo_OP1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_KPSet = New System.Windows.Forms.Button
        Me.txt_TPGoodsNM2 = New System.Windows.Forms.TextBox
        Me.lbl_KCP3 = New System.Windows.Forms.Label
        Me.lbl_KCP2 = New System.Windows.Forms.Label
        Me.lbl_KCP1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_TPGoodsNM = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.chk_Lane = New System.Windows.Forms.CheckBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.lblUntEn = New System.Windows.Forms.Label
        Me.txtUnitPrice = New System.Windows.Forms.TextBox
        Me.lblUnitPrice = New System.Windows.Forms.Label
        Me.chk_TaxKind1 = New System.Windows.Forms.CheckBox
        Me.chk_TaxKind0 = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.ccp_check = New System.Windows.Forms.CheckBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txt_ExpNoteJ = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.chk_game = New System.Windows.Forms.CheckBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txt_searchNumber = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lbl_Orig_Price_Reduce = New System.Windows.Forms.Label
        Me.lbl_Orig_SubPrice_Reduce = New System.Windows.Forms.Label
        Me.lbl_Orig_SubPrice = New System.Windows.Forms.Label
        Me.lbl_MenuCode = New System.Windows.Forms.Label
        Me.txt_MenuCode = New System.Windows.Forms.TextBox
        Me.chk_MenuCdEdit = New System.Windows.Forms.CheckBox
        Me.cmb_TaxType_Reduced = New System.Windows.Forms.ComboBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rbt_OES_Disabled = New System.Windows.Forms.RadioButton
        Me.rbt_OES_Enabled = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rbt_Takeout_Takeout = New System.Windows.Forms.RadioButton
        Me.rbt_Takeout_Both = New System.Windows.Forms.RadioButton
        Me.rbt_Takeout_Eatin = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rbt_Discount_Extra = New System.Windows.Forms.RadioButton
        Me.rbt_Discount_Discount = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbt_Qadd_Enabled = New System.Windows.Forms.RadioButton
        Me.rbt_Qadd_Disabled = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbt_Ptype_Open = New System.Windows.Forms.RadioButton
        Me.rbt_Ptype_Preset = New System.Windows.Forms.RadioButton
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.txt_SubPrice = New System.Windows.Forms.TextBox
        Me.cmb_TaxType = New System.Windows.Forms.ComboBox
        Me.txt_SubPrice_Reduce = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.lbl_GoodsCode = New System.Windows.Forms.Label
        Me.lbl_Price = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.txt_OwnCompanyCode = New System.Windows.Forms.TextBox
        Me.txt_Price_Reduce = New System.Windows.Forms.TextBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.cbo_OP12 = New System.Windows.Forms.ComboBox
        Me.cbo_OP11 = New System.Windows.Forms.ComboBox
        Me.cbo_OP10 = New System.Windows.Forms.ComboBox
        Me.cbo_OP9 = New System.Windows.Forms.ComboBox
        Me.cbo_OP8 = New System.Windows.Forms.ComboBox
        Me.cbo_OP7 = New System.Windows.Forms.ComboBox
        Me.cbo_OP6 = New System.Windows.Forms.ComboBox
        Me.TabPage_MULTI_LING = New System.Windows.Forms.TabPage
        Me.txt_EXPNOTEJ_C = New System.Windows.Forms.TextBox
        Me.txt_TPGoodsNM2_C = New System.Windows.Forms.TextBox
        Me.txt_TPGoodsNM_C = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.LabelMenuLanguage4 = New System.Windows.Forms.Label
        Me.txt_EXPNOTEJ_A = New System.Windows.Forms.TextBox
        Me.txt_TPGoodsNM2_A = New System.Windows.Forms.TextBox
        Me.txt_TPGoodsNM_A = New System.Windows.Forms.TextBox
        Me.txt_EXPNOTEJ_B = New System.Windows.Forms.TextBox
        Me.txt_TPGoodsNM2_B = New System.Windows.Forms.TextBox
        Me.txt_TPGoodsNM_B = New System.Windows.Forms.TextBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.LabelMenuLanguage3 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.LabelMenuLanguage2 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.btn_PicClr = New System.Windows.Forms.Button
        Me.btn_SelFol = New System.Windows.Forms.Button
        Me.grd_PicList = New System.Windows.Forms.DataGrid
        Me.cbo_SelGroup = New System.Windows.Forms.ComboBox
        Me.txt_SelRow = New System.Windows.Forms.TextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.grd_ItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tab_Items.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage_MULTI_LING.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.grd_PicList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_ItemList
        '
        Me.grd_ItemList.CaptionFont = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_ItemList.CaptionText = "Å° è§ïièÓïÒ"
        Me.grd_ItemList.CaptionVisible = False
        Me.grd_ItemList.DataMember = ""
        Me.grd_ItemList.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_ItemList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_ItemList.Location = New System.Drawing.Point(198, 137)
        Me.grd_ItemList.Name = "grd_ItemList"
        Me.grd_ItemList.Size = New System.Drawing.Size(455, 518)
        Me.grd_ItemList.TabIndex = 1
        Me.grd_ItemList.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.grd_ItemList.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grd_ItemList
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 665)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(1016, 24)
        Me.stb_Msg.TabIndex = 173
        Me.stb_Msg.Text = "StatusBar1"
        '
        'txt_PicPath
        '
        Me.txt_PicPath.Location = New System.Drawing.Point(10, 8)
        Me.txt_PicPath.Name = "txt_PicPath"
        Me.txt_PicPath.Size = New System.Drawing.Size(96, 19)
        Me.txt_PicPath.TabIndex = 241
        Me.txt_PicPath.Text = "TextBox1"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem4, Me.MenuItem2})
        Me.MenuItem1.Text = "è§ïiìoò^"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "ï€ë∂(&S)"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "èIóπ(&E)"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ButtonRest)
        Me.Panel1.Controls.Add(Me.lblGoodsCnt)
        Me.Panel1.Controls.Add(Me.lblCnt)
        Me.Panel1.Controls.Add(Me.txt_Search)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.btn_Save)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btn_AddGoods)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.tab_Items)
        Me.Panel1.Controls.Add(Me.cbo_SelGroup)
        Me.Panel1.Controls.Add(Me.txt_PicPath)
        Me.Panel1.Controls.Add(Me.grd_ItemList)
        Me.Panel1.Controls.Add(Me.txt_SelRow)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 195
        '
        'ButtonRest
        '
        Me.ButtonRest.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonRest.Location = New System.Drawing.Point(206, 82)
        Me.ButtonRest.Name = "ButtonRest"
        Me.ButtonRest.Size = New System.Drawing.Size(104, 34)
        Me.ButtonRest.TabIndex = 245
        Me.ButtonRest.Text = "écêîê›íË"
        Me.ButtonRest.UseVisualStyleBackColor = True
        '
        'lblGoodsCnt
        '
        Me.lblGoodsCnt.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblGoodsCnt.Location = New System.Drawing.Point(663, 36)
        Me.lblGoodsCnt.Name = "lblGoodsCnt"
        Me.lblGoodsCnt.Size = New System.Drawing.Size(100, 23)
        Me.lblGoodsCnt.TabIndex = 244
        Me.lblGoodsCnt.Text = "0"
        Me.lblGoodsCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCnt
        '
        Me.lblCnt.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblCnt.Image = CType(resources.GetObject("lblCnt.Image"), System.Drawing.Image)
        Me.lblCnt.Location = New System.Drawing.Point(646, 15)
        Me.lblCnt.Name = "lblCnt"
        Me.lblCnt.Size = New System.Drawing.Size(105, 21)
        Me.lblCnt.TabIndex = 243
        Me.lblCnt.Text = "åªç›ÇÃè§ïiêî"
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(429, 108)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(224, 22)
        Me.txt_Search.TabIndex = 2
        Me.txt_Search.Text = "TextBox1"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label25.Image = CType(resources.GetObject("Label25.Image"), System.Drawing.Image)
        Me.Label25.Location = New System.Drawing.Point(404, 21)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(220, 30)
        Me.Label25.TabIndex = 200
        Me.Label25.Text = "ÉIÉvÉVÉáÉìÇÕè§ïiî‘çÜÇ™" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9001Å`9900ÇÃä‘Ç≈çÏê¨ÇµÇƒÇ≠ÇæÇ≥Ç¢"
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Save.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(804, 10)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(180, 50)
        Me.btn_Save.TabIndex = 102
        Me.btn_Save.Text = "ï€ë∂"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(204, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(794, 1)
        Me.Label3.TabIndex = 198
        '
        'btn_AddGoods
        '
        Me.btn_AddGoods.BackColor = System.Drawing.SystemColors.Control
        Me.btn_AddGoods.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_AddGoods.Location = New System.Drawing.Point(350, 20)
        Me.btn_AddGoods.Name = "btn_AddGoods"
        Me.btn_AddGoods.Size = New System.Drawing.Size(50, 30)
        Me.btn_AddGoods.TabIndex = 101
        Me.btn_AddGoods.Text = "Å@Å@Å@Å@"
        Me.btn_AddGoods.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!)
        Me.Label21.Image = CType(resources.GetObject("Label21.Image"), System.Drawing.Image)
        Me.Label21.Location = New System.Drawing.Point(347, 82)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 15)
        Me.Label21.TabIndex = 196
        Me.Label21.Text = "çiçûÇ›"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!)
        Me.Label20.Image = CType(resources.GetObject("Label20.Image"), System.Drawing.Image)
        Me.Label20.Location = New System.Drawing.Point(347, 111)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 15)
        Me.Label20.TabIndex = 195
        Me.Label20.Text = "è§ïiåüçı"
        '
        'tab_Items
        '
        Me.tab_Items.Controls.Add(Me.TabPage3)
        Me.tab_Items.Controls.Add(Me.TabPage1)
        Me.tab_Items.Controls.Add(Me.TabPage2)
        Me.tab_Items.Controls.Add(Me.TabPage5)
        Me.tab_Items.Controls.Add(Me.TabPage_MULTI_LING)
        Me.tab_Items.Controls.Add(Me.TabPage4)
        Me.tab_Items.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tab_Items.Location = New System.Drawing.Point(660, 75)
        Me.tab_Items.Name = "tab_Items"
        Me.tab_Items.SelectedIndex = 0
        Me.tab_Items.Size = New System.Drawing.Size(349, 582)
        Me.tab_Items.TabIndex = 3
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.txt_HTLNM5)
        Me.TabPage3.Controls.Add(Me.Label68)
        Me.TabPage3.Controls.Add(Me.txt_TECKCPNM3)
        Me.TabPage3.Controls.Add(Me.Label67)
        Me.TabPage3.Controls.Add(Me.LowerLabel)
        Me.TabPage3.Controls.Add(Me.LowerBox)
        Me.TabPage3.Controls.Add(Me.UpperLabel)
        Me.TabPage3.Controls.Add(Me.UpperBox)
        Me.TabPage3.Controls.Add(Me.chk_Status2)
        Me.TabPage3.Controls.Add(Me.cmbPTN2)
        Me.TabPage3.Controls.Add(Me.cmbPTN1)
        Me.TabPage3.Controls.Add(Me.Label139)
        Me.TabPage3.Controls.Add(Me.Label134)
        Me.TabPage3.Controls.Add(Me.tax_Price)
        Me.TabPage3.Controls.Add(Me.txt_Price)
        Me.TabPage3.Controls.Add(Me.Label33)
        Me.TabPage3.Controls.Add(Me.Label32)
        Me.TabPage3.Controls.Add(Me.chk_Status3)
        Me.TabPage3.Controls.Add(Me.chk_Status1)
        Me.TabPage3.Controls.Add(Me.chk_Status0)
        Me.TabPage3.Controls.Add(Me.Label29)
        Me.TabPage3.Controls.Add(Me.Label28)
        Me.TabPage3.Controls.Add(Me.cbo_OP5)
        Me.TabPage3.Controls.Add(Me.Label27)
        Me.TabPage3.Controls.Add(Me.lbl_KCP4)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.cmb_Bumon)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.cbo_OP4)
        Me.TabPage3.Controls.Add(Me.cbo_OP3)
        Me.TabPage3.Controls.Add(Me.txt_GoodsNMJ4)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.txt_HTLNM2)
        Me.TabPage3.Controls.Add(Me.txt_HTLNM1)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.cbo_OP2)
        Me.TabPage3.Controls.Add(Me.cbo_OP1)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.btn_KPSet)
        Me.TabPage3.Controls.Add(Me.txt_TPGoodsNM2)
        Me.TabPage3.Controls.Add(Me.lbl_KCP3)
        Me.TabPage3.Controls.Add(Me.lbl_KCP2)
        Me.TabPage3.Controls.Add(Me.lbl_KCP1)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.txt_TPGoodsNM)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(341, 553)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "è§ïièÓïÒÇP"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txt_HTLNM5
        '
        Me.txt_HTLNM5.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_HTLNM5.Location = New System.Drawing.Point(125, 214)
        Me.txt_HTLNM5.Name = "txt_HTLNM5"
        Me.txt_HTLNM5.Size = New System.Drawing.Size(184, 22)
        Me.txt_HTLNM5.TabIndex = 241
        Me.txt_HTLNM5.Text = "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"
        '
        'Label68
        '
        Me.Label68.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label68.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label68.Image = CType(resources.GetObject("Label68.Image"), System.Drawing.Image)
        Me.Label68.Location = New System.Drawing.Point(1, 212)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(120, 24)
        Me.Label68.TabIndex = 240
        Me.Label68.Text = "ÉnÉìÉfÉBñº(í∑)"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_TECKCPNM3
        '
        Me.txt_TECKCPNM3.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_TECKCPNM3.Location = New System.Drawing.Point(125, 159)
        Me.txt_TECKCPNM3.Name = "txt_TECKCPNM3"
        Me.txt_TECKCPNM3.Size = New System.Drawing.Size(184, 22)
        Me.txt_TECKCPNM3.TabIndex = 239
        Me.txt_TECKCPNM3.Text = "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"
        '
        'Label67
        '
        Me.Label67.BackColor = System.Drawing.SystemColors.Control
        Me.Label67.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label67.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label67.Image = CType(resources.GetObject("Label67.Image"), System.Drawing.Image)
        Me.Label67.Location = New System.Drawing.Point(1, 156)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(119, 24)
        Me.Label67.TabIndex = 238
        Me.Label67.Text = "É`ÉPÉbÉgàÛéöñº"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LowerLabel
        '
        Me.LowerLabel.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LowerLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LowerLabel.Image = CType(resources.GetObject("LowerLabel.Image"), System.Drawing.Image)
        Me.LowerLabel.Location = New System.Drawing.Point(9, 602)
        Me.LowerLabel.Name = "LowerLabel"
        Me.LowerLabel.Size = New System.Drawing.Size(114, 24)
        Me.LowerLabel.TabIndex = 237
        Me.LowerLabel.Text = "àÛéöâ∫íi"
        Me.LowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LowerBox
        '
        Me.LowerBox.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LowerBox.Location = New System.Drawing.Point(126, 600)
        Me.LowerBox.Name = "LowerBox"
        Me.LowerBox.Size = New System.Drawing.Size(183, 22)
        Me.LowerBox.TabIndex = 236
        '
        'UpperLabel
        '
        Me.UpperLabel.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.UpperLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UpperLabel.Image = CType(resources.GetObject("UpperLabel.Image"), System.Drawing.Image)
        Me.UpperLabel.Location = New System.Drawing.Point(9, 572)
        Me.UpperLabel.Name = "UpperLabel"
        Me.UpperLabel.Size = New System.Drawing.Size(114, 24)
        Me.UpperLabel.TabIndex = 235
        Me.UpperLabel.Text = "àÛéöè„íi"
        Me.UpperLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UpperBox
        '
        Me.UpperBox.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.UpperBox.Location = New System.Drawing.Point(126, 573)
        Me.UpperBox.Name = "UpperBox"
        Me.UpperBox.Size = New System.Drawing.Size(183, 22)
        Me.UpperBox.TabIndex = 234
        '
        'chk_Status2
        '
        Me.chk_Status2.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_Status2.Image = CType(resources.GetObject("chk_Status2.Image"), System.Drawing.Image)
        Me.chk_Status2.Location = New System.Drawing.Point(227, 525)
        Me.chk_Status2.Name = "chk_Status2"
        Me.chk_Status2.Size = New System.Drawing.Size(96, 24)
        Me.chk_Status2.TabIndex = 20
        Me.chk_Status2.Text = "ÅuÉTÉuÅv"
        '
        'cmbPTN2
        '
        Me.cmbPTN2.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbPTN2.FormattingEnabled = True
        Me.cmbPTN2.Location = New System.Drawing.Point(175, 490)
        Me.cmbPTN2.Name = "cmbPTN2"
        Me.cmbPTN2.Size = New System.Drawing.Size(121, 23)
        Me.cmbPTN2.TabIndex = 232
        '
        'cmbPTN1
        '
        Me.cmbPTN1.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!)
        Me.cmbPTN1.FormattingEnabled = True
        Me.cmbPTN1.Location = New System.Drawing.Point(20, 490)
        Me.cmbPTN1.Name = "cmbPTN1"
        Me.cmbPTN1.Size = New System.Drawing.Size(121, 23)
        Me.cmbPTN1.TabIndex = 231
        '
        'Label139
        '
        Me.Label139.BackColor = System.Drawing.SystemColors.Control
        Me.Label139.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label139.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label139.Image = CType(resources.GetObject("Label139.Image"), System.Drawing.Image)
        Me.Label139.Location = New System.Drawing.Point(172, 465)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(114, 24)
        Me.Label139.TabIndex = 230
        Me.Label139.Text = "ÉpÉ^Å[Éì2"
        Me.Label139.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label134
        '
        Me.Label134.BackColor = System.Drawing.SystemColors.Control
        Me.Label134.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label134.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label134.Image = CType(resources.GetObject("Label134.Image"), System.Drawing.Image)
        Me.Label134.Location = New System.Drawing.Point(17, 465)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(114, 24)
        Me.Label134.TabIndex = 229
        Me.Label134.Text = "ÉpÉ^Å[Éì1"
        Me.Label134.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tax_Price
        '
        Me.tax_Price.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tax_Price.Location = New System.Drawing.Point(232, 66)
        Me.tax_Price.Name = "tax_Price"
        Me.tax_Price.Size = New System.Drawing.Size(64, 22)
        Me.tax_Price.TabIndex = 6
        Me.tax_Price.Text = "999,999"
        Me.tax_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Price
        '
        Me.txt_Price.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Price.Location = New System.Drawing.Point(126, 66)
        Me.txt_Price.Name = "txt_Price"
        Me.txt_Price.Size = New System.Drawing.Size(64, 22)
        Me.txt_Price.TabIndex = 7
        Me.txt_Price.Text = "999,999"
        Me.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label33.Image = CType(resources.GetObject("Label33.Image"), System.Drawing.Image)
        Me.Label33.Location = New System.Drawing.Point(298, 69)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(30, 24)
        Me.Label33.TabIndex = 228
        Me.Label33.Text = "â~"
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 13.0!)
        Me.Label32.Image = CType(resources.GetObject("Label32.Image"), System.Drawing.Image)
        Me.Label32.Location = New System.Drawing.Point(214, 67)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(24, 24)
        Me.Label32.TabIndex = 227
        Me.Label32.Text = "/"
        '
        'chk_Status3
        '
        Me.chk_Status3.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_Status3.Image = CType(resources.GetObject("chk_Status3.Image"), System.Drawing.Image)
        Me.chk_Status3.Location = New System.Drawing.Point(227, 549)
        Me.chk_Status3.Name = "chk_Status3"
        Me.chk_Status3.Size = New System.Drawing.Size(96, 24)
        Me.chk_Status3.TabIndex = 22
        Me.chk_Status3.Text = "ÅuÉZÉbÉgÅv"
        '
        'chk_Status1
        '
        Me.chk_Status1.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_Status1.Image = CType(resources.GetObject("chk_Status1.Image"), System.Drawing.Image)
        Me.chk_Status1.Location = New System.Drawing.Point(125, 549)
        Me.chk_Status1.Name = "chk_Status1"
        Me.chk_Status1.Size = New System.Drawing.Size(96, 24)
        Me.chk_Status1.TabIndex = 21
        Me.chk_Status1.Text = "ÅuÉRÉÅÉìÉgÅv"
        '
        'chk_Status0
        '
        Me.chk_Status0.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_Status0.Image = CType(resources.GetObject("chk_Status0.Image"), System.Drawing.Image)
        Me.chk_Status0.Location = New System.Drawing.Point(125, 525)
        Me.chk_Status0.Name = "chk_Status0"
        Me.chk_Status0.Size = New System.Drawing.Size(96, 24)
        Me.chk_Status0.TabIndex = 19
        Me.chk_Status0.Text = "ÅuÉÅÉCÉìÅv"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Image = CType(resources.GetObject("Label29.Image"), System.Drawing.Image)
        Me.Label29.Location = New System.Drawing.Point(2, 525)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(114, 24)
        Me.Label29.TabIndex = 223
        Me.Label29.Text = "ÉXÉeÅ[É^ÉX"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label28.Image = CType(resources.GetObject("Label28.Image"), System.Drawing.Image)
        Me.Label28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label28.Location = New System.Drawing.Point(125, 434)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(16, 24)
        Me.Label28.TabIndex = 222
        Me.Label28.Text = "1"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbo_OP5
        '
        Me.cbo_OP5.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_OP5.Location = New System.Drawing.Point(141, 435)
        Me.cbo_OP5.Name = "cbo_OP5"
        Me.cbo_OP5.Size = New System.Drawing.Size(168, 23)
        Me.cbo_OP5.TabIndex = 17
        Me.cbo_OP5.Text = "ComboBox5"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Image = CType(resources.GetObject("Label27.Image"), System.Drawing.Image)
        Me.Label27.Location = New System.Drawing.Point(2, 408)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(220, 24)
        Me.Label27.TabIndex = 220
        Me.Label27.Text = "ÉTÉuÉRÉÅÉìÉg/ÉZÉbÉg"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_KCP4
        '
        Me.lbl_KCP4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_KCP4.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 10.0!)
        Me.lbl_KCP4.Image = CType(resources.GetObject("lbl_KCP4.Image"), System.Drawing.Image)
        Me.lbl_KCP4.Location = New System.Drawing.Point(244, 97)
        Me.lbl_KCP4.Name = "lbl_KCP4"
        Me.lbl_KCP4.Size = New System.Drawing.Size(36, 24)
        Me.lbl_KCP4.TabIndex = 219
        Me.lbl_KCP4.Text = "99"
        Me.lbl_KCP4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.Location = New System.Drawing.Point(18, 316)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 24)
        Me.Label13.TabIndex = 214
        Me.Label13.Text = "ï°êîëIëïsâ¬Ç≈Ç∑"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.Location = New System.Drawing.Point(5, 298)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 24)
        Me.Label11.TabIndex = 213
        Me.Label11.Text = "Å¶êîó ÉIÉvÉVÉáÉìÇÕ"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Image = CType(resources.GetObject("Label22.Image"), System.Drawing.Image)
        Me.Label22.Location = New System.Drawing.Point(69, 36)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 24)
        Me.Label22.TabIndex = 212
        Me.Label22.Text = "(â∫íi)"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_Bumon
        '
        Me.cmb_Bumon.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb_Bumon.Location = New System.Drawing.Point(125, 242)
        Me.cmb_Bumon.Name = "cmb_Bumon"
        Me.cmb_Bumon.Size = New System.Drawing.Size(184, 23)
        Me.cmb_Bumon.TabIndex = 12
        Me.cmb_Bumon.Text = "ÇmÇmÇmÇmÇmÇmÇmÇm"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Image = CType(resources.GetObject("Label18.Image"), System.Drawing.Image)
        Me.Label18.Location = New System.Drawing.Point(69, 10)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 24)
        Me.Label18.TabIndex = 211
        Me.Label18.Text = "(è„íi)"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.Location = New System.Drawing.Point(2, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 24)
        Me.Label9.TabIndex = 208
        Me.Label9.Text = "ïîñÂÉRÅ[Éh"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(192, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 24)
        Me.Label1.TabIndex = 210
        Me.Label1.Text = "â~"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label19.Image = CType(resources.GetObject("Label19.Image"), System.Drawing.Image)
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label19.Location = New System.Drawing.Point(125, 380)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 24)
        Me.Label19.TabIndex = 204
        Me.Label19.Text = "4"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.Location = New System.Drawing.Point(125, 351)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 24)
        Me.Label15.TabIndex = 203
        Me.Label15.Text = "3"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.Location = New System.Drawing.Point(125, 322)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 24)
        Me.Label14.TabIndex = 202
        Me.Label14.Text = "2"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(125, 293)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 24)
        Me.Label10.TabIndex = 201
        Me.Label10.Text = "1"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbo_OP4
        '
        Me.cbo_OP4.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_OP4.Location = New System.Drawing.Point(141, 380)
        Me.cbo_OP4.Name = "cbo_OP4"
        Me.cbo_OP4.Size = New System.Drawing.Size(168, 23)
        Me.cbo_OP4.TabIndex = 16
        Me.cbo_OP4.Text = "ComboBox4"
        '
        'cbo_OP3
        '
        Me.cbo_OP3.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_OP3.Location = New System.Drawing.Point(141, 351)
        Me.cbo_OP3.Name = "cbo_OP3"
        Me.cbo_OP3.Size = New System.Drawing.Size(168, 23)
        Me.cbo_OP3.TabIndex = 15
        Me.cbo_OP3.Text = "ComboBox3"
        '
        'txt_GoodsNMJ4
        '
        Me.txt_GoodsNMJ4.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_GoodsNMJ4.Location = New System.Drawing.Point(125, 131)
        Me.txt_GoodsNMJ4.Name = "txt_GoodsNMJ4"
        Me.txt_GoodsNMJ4.Size = New System.Drawing.Size(184, 22)
        Me.txt_GoodsNMJ4.TabIndex = 9
        Me.txt_GoodsNMJ4.Text = "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(2, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 24)
        Me.Label7.TabIndex = 181
        Me.Label7.Text = "ÉvÉäÉìÉ^àÛéöñº"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_HTLNM2
        '
        Me.txt_HTLNM2.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_HTLNM2.Location = New System.Drawing.Point(210, 186)
        Me.txt_HTLNM2.Name = "txt_HTLNM2"
        Me.txt_HTLNM2.Size = New System.Drawing.Size(64, 22)
        Me.txt_HTLNM2.TabIndex = 11
        Me.txt_HTLNM2.Text = "NNNNNN"
        '
        'txt_HTLNM1
        '
        Me.txt_HTLNM1.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_HTLNM1.Location = New System.Drawing.Point(125, 186)
        Me.txt_HTLNM1.Name = "txt_HTLNM1"
        Me.txt_HTLNM1.Size = New System.Drawing.Size(64, 22)
        Me.txt_HTLNM1.TabIndex = 10
        Me.txt_HTLNM1.Text = "NNNNNN"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(2, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 24)
        Me.Label5.TabIndex = 178
        Me.Label5.Text = "ÉnÉìÉfÉBñº"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbo_OP2
        '
        Me.cbo_OP2.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_OP2.Location = New System.Drawing.Point(141, 322)
        Me.cbo_OP2.Name = "cbo_OP2"
        Me.cbo_OP2.Size = New System.Drawing.Size(168, 23)
        Me.cbo_OP2.TabIndex = 14
        Me.cbo_OP2.Text = "ComboBox2"
        '
        'cbo_OP1
        '
        Me.cbo_OP1.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_OP1.Location = New System.Drawing.Point(141, 293)
        Me.cbo_OP1.Name = "cbo_OP1"
        Me.cbo_OP1.Size = New System.Drawing.Size(168, 23)
        Me.cbo_OP1.TabIndex = 13
        Me.cbo_OP1.Text = "ComboBox1"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(-1, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 24)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "ÉRÉÅÉìÉgÉIÉvÉVÉáÉì"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_KPSet
        '
        Me.btn_KPSet.BackColor = System.Drawing.SystemColors.Control
        Me.btn_KPSet.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_KPSet.Location = New System.Drawing.Point(286, 97)
        Me.btn_KPSet.Name = "btn_KPSet"
        Me.btn_KPSet.Size = New System.Drawing.Size(48, 24)
        Me.btn_KPSet.TabIndex = 8
        Me.btn_KPSet.Text = "ê›íË"
        Me.btn_KPSet.UseVisualStyleBackColor = False
        '
        'txt_TPGoodsNM2
        '
        Me.txt_TPGoodsNM2.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_TPGoodsNM2.Location = New System.Drawing.Point(125, 38)
        Me.txt_TPGoodsNM2.Name = "txt_TPGoodsNM2"
        Me.txt_TPGoodsNM2.Size = New System.Drawing.Size(184, 22)
        Me.txt_TPGoodsNM2.TabIndex = 5
        Me.txt_TPGoodsNM2.Text = "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"
        '
        'lbl_KCP3
        '
        Me.lbl_KCP3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_KCP3.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 10.0!)
        Me.lbl_KCP3.Image = CType(resources.GetObject("lbl_KCP3.Image"), System.Drawing.Image)
        Me.lbl_KCP3.Location = New System.Drawing.Point(205, 97)
        Me.lbl_KCP3.Name = "lbl_KCP3"
        Me.lbl_KCP3.Size = New System.Drawing.Size(36, 24)
        Me.lbl_KCP3.TabIndex = 167
        Me.lbl_KCP3.Text = "99"
        Me.lbl_KCP3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_KCP2
        '
        Me.lbl_KCP2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_KCP2.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 10.0!)
        Me.lbl_KCP2.Image = CType(resources.GetObject("lbl_KCP2.Image"), System.Drawing.Image)
        Me.lbl_KCP2.Location = New System.Drawing.Point(166, 97)
        Me.lbl_KCP2.Name = "lbl_KCP2"
        Me.lbl_KCP2.Size = New System.Drawing.Size(36, 24)
        Me.lbl_KCP2.TabIndex = 166
        Me.lbl_KCP2.Text = "99"
        Me.lbl_KCP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_KCP1
        '
        Me.lbl_KCP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_KCP1.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 10.0!)
        Me.lbl_KCP1.Image = CType(resources.GetObject("lbl_KCP1.Image"), System.Drawing.Image)
        Me.lbl_KCP1.Location = New System.Drawing.Point(127, 97)
        Me.lbl_KCP1.Name = "lbl_KCP1"
        Me.lbl_KCP1.Size = New System.Drawing.Size(36, 24)
        Me.lbl_KCP1.TabIndex = 165
        Me.lbl_KCP1.Text = "99"
        Me.lbl_KCP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(2, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 24)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = "è§ïièoóÕêÊ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_TPGoodsNM
        '
        Me.txt_TPGoodsNM.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_TPGoodsNM.Location = New System.Drawing.Point(125, 12)
        Me.txt_TPGoodsNM.Name = "txt_TPGoodsNM"
        Me.txt_TPGoodsNM.Size = New System.Drawing.Size(184, 22)
        Me.txt_TPGoodsNM.TabIndex = 4
        Me.txt_TPGoodsNM.Text = "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(2, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 24)
        Me.Label6.TabIndex = 161
        Me.Label6.Text = "è§ïiñº"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.Location = New System.Drawing.Point(3, 66)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(119, 24)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "âøäi(ê≈ï /ê≈çû)"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.chk_Lane)
        Me.TabPage1.Controls.Add(Me.Label46)
        Me.TabPage1.Controls.Add(Me.lblUntEn)
        Me.TabPage1.Controls.Add(Me.txtUnitPrice)
        Me.TabPage1.Controls.Add(Me.lblUnitPrice)
        Me.TabPage1.Controls.Add(Me.chk_TaxKind1)
        Me.TabPage1.Controls.Add(Me.chk_TaxKind0)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.ccp_check)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.txt_ExpNoteJ)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.chk_game)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.txt_searchNumber)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(341, 553)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "è§ïièÓïÒÇQ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chk_Lane
        '
        Me.chk_Lane.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!)
        Me.chk_Lane.Image = CType(resources.GetObject("chk_Lane.Image"), System.Drawing.Image)
        Me.chk_Lane.Location = New System.Drawing.Point(123, 381)
        Me.chk_Lane.Name = "chk_Lane"
        Me.chk_Lane.Size = New System.Drawing.Size(133, 24)
        Me.chk_Lane.TabIndex = 241
        Me.chk_Lane.Text = "ÉåÅ[ÉìòAågè§ïi"
        Me.chk_Lane.UseVisualStyleBackColor = True
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label46.Image = CType(resources.GetObject("Label46.Image"), System.Drawing.Image)
        Me.Label46.Location = New System.Drawing.Point(4, 385)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(77, 15)
        Me.Label46.TabIndex = 240
        Me.Label46.Text = "ÉåÅ[ÉìòAåg"
        '
        'lblUntEn
        '
        Me.lblUntEn.AutoSize = True
        Me.lblUntEn.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblUntEn.Image = CType(resources.GetObject("lblUntEn.Image"), System.Drawing.Image)
        Me.lblUntEn.Location = New System.Drawing.Point(229, 336)
        Me.lblUntEn.Name = "lblUntEn"
        Me.lblUntEn.Size = New System.Drawing.Size(22, 15)
        Me.lblUntEn.TabIndex = 239
        Me.lblUntEn.Text = "â~"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(123, 333)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtUnitPrice.TabIndex = 238
        Me.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.AutoSize = True
        Me.lblUnitPrice.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblUnitPrice.Image = CType(resources.GetObject("lblUnitPrice.Image"), System.Drawing.Image)
        Me.lblUnitPrice.Location = New System.Drawing.Point(4, 333)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(37, 15)
        Me.lblUnitPrice.TabIndex = 237
        Me.lblUnitPrice.Text = "å¥âø"
        '
        'chk_TaxKind1
        '
        Me.chk_TaxKind1.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_TaxKind1.Image = CType(resources.GetObject("chk_TaxKind1.Image"), System.Drawing.Image)
        Me.chk_TaxKind1.Location = New System.Drawing.Point(123, 290)
        Me.chk_TaxKind1.Name = "chk_TaxKind1"
        Me.chk_TaxKind1.Size = New System.Drawing.Size(116, 24)
        Me.chk_TaxKind1.TabIndex = 236
        Me.chk_TaxKind1.Text = " ì‡ê≈"
        '
        'chk_TaxKind0
        '
        Me.chk_TaxKind0.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_TaxKind0.Image = CType(resources.GetObject("chk_TaxKind0.Image"), System.Drawing.Image)
        Me.chk_TaxKind0.Location = New System.Drawing.Point(123, 260)
        Me.chk_TaxKind0.Name = "chk_TaxKind0"
        Me.chk_TaxKind0.Size = New System.Drawing.Size(116, 24)
        Me.chk_TaxKind0.TabIndex = 235
        Me.chk_TaxKind0.Text = " äOê≈"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(3, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 24)
        Me.Label8.TabIndex = 234
        Me.Label8.Text = "ê≈éÌï "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Image = CType(resources.GetObject("Label31.Image"), System.Drawing.Image)
        Me.Label31.Location = New System.Drawing.Point(156, 219)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(101, 24)
        Me.Label31.TabIndex = 233
        Me.Label31.Text = "CCPàÛéöÇ∑ÇÈ"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Image = CType(resources.GetObject("Label30.Image"), System.Drawing.Image)
        Me.Label30.Location = New System.Drawing.Point(4, 219)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(101, 24)
        Me.Label30.TabIndex = 232
        Me.Label30.Text = "CCPàÛéö"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ccp_check
        '
        Me.ccp_check.AutoSize = True
        Me.ccp_check.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!)
        Me.ccp_check.Location = New System.Drawing.Point(124, 225)
        Me.ccp_check.Name = "ccp_check"
        Me.ccp_check.Size = New System.Drawing.Size(15, 14)
        Me.ccp_check.TabIndex = 34
        Me.ccp_check.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
        Me.Label16.Location = New System.Drawing.Point(30, 118)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 24)
        Me.Label16.TabIndex = 229
        Me.Label16.Text = "ì¸óÕÇ≈Ç´Ç‹Ç∑"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Image = CType(resources.GetObject("Label23.Image"), System.Drawing.Image)
        Me.Label23.Location = New System.Drawing.Point(4, 100)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(81, 24)
        Me.Label23.TabIndex = 228
        Me.Label23.Text = "Å¶60ï∂éöÇ‹Ç≈"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_ExpNoteJ
        '
        Me.txt_ExpNoteJ.AcceptsReturn = True
        Me.txt_ExpNoteJ.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_ExpNoteJ.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt_ExpNoteJ.Location = New System.Drawing.Point(123, 66)
        Me.txt_ExpNoteJ.MaxLength = 66
        Me.txt_ExpNoteJ.Multiline = True
        Me.txt_ExpNoteJ.Name = "txt_ExpNoteJ"
        Me.txt_ExpNoteJ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_ExpNoteJ.Size = New System.Drawing.Size(201, 143)
        Me.txt_ExpNoteJ.TabIndex = 33
        Me.txt_ExpNoteJ.Text = "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm" & _
            "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.Location = New System.Drawing.Point(4, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 24)
        Me.Label12.TabIndex = 227
        Me.Label12.Text = "è§ïiê‡ñæ"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chk_game
        '
        Me.chk_game.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!)
        Me.chk_game.Image = CType(resources.GetObject("chk_game.Image"), System.Drawing.Image)
        Me.chk_game.Location = New System.Drawing.Point(124, 38)
        Me.chk_game.Name = "chk_game"
        Me.chk_game.Size = New System.Drawing.Size(133, 24)
        Me.chk_game.TabIndex = 32
        Me.chk_game.Text = "ÉQÅ[ÉÄëŒè€è§ïi"
        Me.chk_game.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Image = CType(resources.GetObject("Label26.Image"), System.Drawing.Image)
        Me.Label26.Location = New System.Drawing.Point(3, 38)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(130, 24)
        Me.Label26.TabIndex = 224
        Me.Label26.Text = "ÉQÅ[ÉÄê›íË"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_searchNumber
        '
        Me.txt_searchNumber.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_searchNumber.Location = New System.Drawing.Point(123, 11)
        Me.txt_searchNumber.Name = "txt_searchNumber"
        Me.txt_searchNumber.Size = New System.Drawing.Size(68, 22)
        Me.txt_searchNumber.TabIndex = 31
        Me.txt_searchNumber.Text = "9999"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Image = CType(resources.GetObject("Label24.Image"), System.Drawing.Image)
        Me.Label24.Location = New System.Drawing.Point(3, 9)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(114, 24)
        Me.Label24.TabIndex = 222
        Me.Label24.Text = "åüçıî‘çÜê›íË"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.CNL1501.My.Resources.Resources.back2
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.lbl_Orig_Price_Reduce)
        Me.TabPage2.Controls.Add(Me.lbl_Orig_SubPrice_Reduce)
        Me.TabPage2.Controls.Add(Me.lbl_Orig_SubPrice)
        Me.TabPage2.Controls.Add(Me.lbl_MenuCode)
        Me.TabPage2.Controls.Add(Me.txt_MenuCode)
        Me.TabPage2.Controls.Add(Me.chk_MenuCdEdit)
        Me.TabPage2.Controls.Add(Me.cmb_TaxType_Reduced)
        Me.TabPage2.Controls.Add(Me.Label53)
        Me.TabPage2.Controls.Add(Me.Label59)
        Me.TabPage2.Controls.Add(Me.Label50)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Label52)
        Me.TabPage2.Controls.Add(Me.Label54)
        Me.TabPage2.Controls.Add(Me.Label55)
        Me.TabPage2.Controls.Add(Me.txt_SubPrice)
        Me.TabPage2.Controls.Add(Me.cmb_TaxType)
        Me.TabPage2.Controls.Add(Me.txt_SubPrice_Reduce)
        Me.TabPage2.Controls.Add(Me.Label56)
        Me.TabPage2.Controls.Add(Me.Label51)
        Me.TabPage2.Controls.Add(Me.lbl_GoodsCode)
        Me.TabPage2.Controls.Add(Me.lbl_Price)
        Me.TabPage2.Controls.Add(Me.Label49)
        Me.TabPage2.Controls.Add(Me.Label57)
        Me.TabPage2.Controls.Add(Me.Label47)
        Me.TabPage2.Controls.Add(Me.txt_OwnCompanyCode)
        Me.TabPage2.Controls.Add(Me.txt_Price_Reduce)
        Me.TabPage2.Controls.Add(Me.Label48)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(341, 553)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "è§ïièÓïÒ3"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lbl_Orig_Price_Reduce
        '
        Me.lbl_Orig_Price_Reduce.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_Orig_Price_Reduce.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!)
        Me.lbl_Orig_Price_Reduce.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Orig_Price_Reduce.Image = CType(resources.GetObject("lbl_Orig_Price_Reduce.Image"), System.Drawing.Image)
        Me.lbl_Orig_Price_Reduce.Location = New System.Drawing.Point(163, 158)
        Me.lbl_Orig_Price_Reduce.Name = "lbl_Orig_Price_Reduce"
        Me.lbl_Orig_Price_Reduce.Size = New System.Drawing.Size(67, 24)
        Me.lbl_Orig_Price_Reduce.TabIndex = 236
        Me.lbl_Orig_Price_Reduce.Text = "999,999"
        Me.lbl_Orig_Price_Reduce.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Orig_Price_Reduce.Visible = False
        '
        'lbl_Orig_SubPrice_Reduce
        '
        Me.lbl_Orig_SubPrice_Reduce.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_Orig_SubPrice_Reduce.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!)
        Me.lbl_Orig_SubPrice_Reduce.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Orig_SubPrice_Reduce.Image = CType(resources.GetObject("lbl_Orig_SubPrice_Reduce.Image"), System.Drawing.Image)
        Me.lbl_Orig_SubPrice_Reduce.Location = New System.Drawing.Point(163, 204)
        Me.lbl_Orig_SubPrice_Reduce.Name = "lbl_Orig_SubPrice_Reduce"
        Me.lbl_Orig_SubPrice_Reduce.Size = New System.Drawing.Size(67, 24)
        Me.lbl_Orig_SubPrice_Reduce.TabIndex = 235
        Me.lbl_Orig_SubPrice_Reduce.Text = "999,999"
        Me.lbl_Orig_SubPrice_Reduce.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Orig_SubPrice_Reduce.Visible = False
        '
        'lbl_Orig_SubPrice
        '
        Me.lbl_Orig_SubPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_Orig_SubPrice.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!)
        Me.lbl_Orig_SubPrice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Orig_SubPrice.Image = CType(resources.GetObject("lbl_Orig_SubPrice.Image"), System.Drawing.Image)
        Me.lbl_Orig_SubPrice.Location = New System.Drawing.Point(163, 182)
        Me.lbl_Orig_SubPrice.Name = "lbl_Orig_SubPrice"
        Me.lbl_Orig_SubPrice.Size = New System.Drawing.Size(67, 24)
        Me.lbl_Orig_SubPrice.TabIndex = 234
        Me.lbl_Orig_SubPrice.Text = "999,999"
        Me.lbl_Orig_SubPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Orig_SubPrice.Visible = False
        '
        'lbl_MenuCode
        '
        Me.lbl_MenuCode.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_MenuCode.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!)
        Me.lbl_MenuCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_MenuCode.Image = CType(resources.GetObject("lbl_MenuCode.Image"), System.Drawing.Image)
        Me.lbl_MenuCode.Location = New System.Drawing.Point(93, 132)
        Me.lbl_MenuCode.Name = "lbl_MenuCode"
        Me.lbl_MenuCode.Size = New System.Drawing.Size(104, 24)
        Me.lbl_MenuCode.TabIndex = 233
        Me.lbl_MenuCode.Text = "999999999999"
        Me.lbl_MenuCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_MenuCode.Visible = False
        '
        'txt_MenuCode
        '
        Me.txt_MenuCode.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_MenuCode.Location = New System.Drawing.Point(150, 11)
        Me.txt_MenuCode.MaxLength = 13
        Me.txt_MenuCode.Name = "txt_MenuCode"
        Me.txt_MenuCode.Size = New System.Drawing.Size(130, 22)
        Me.txt_MenuCode.TabIndex = 232
        Me.txt_MenuCode.Text = "9999999999999"
        Me.txt_MenuCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chk_MenuCdEdit
        '
        Me.chk_MenuCdEdit.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!)
        Me.chk_MenuCdEdit.Image = CType(resources.GetObject("chk_MenuCdEdit.Image"), System.Drawing.Image)
        Me.chk_MenuCdEdit.Location = New System.Drawing.Point(282, 9)
        Me.chk_MenuCdEdit.Name = "chk_MenuCdEdit"
        Me.chk_MenuCdEdit.Size = New System.Drawing.Size(57, 24)
        Me.chk_MenuCdEdit.TabIndex = 231
        Me.chk_MenuCdEdit.Text = "ï“èW"
        Me.chk_MenuCdEdit.UseVisualStyleBackColor = True
        '
        'cmb_TaxType_Reduced
        '
        Me.cmb_TaxType_Reduced.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb_TaxType_Reduced.Location = New System.Drawing.Point(151, 97)
        Me.cmb_TaxType_Reduced.Name = "cmb_TaxType_Reduced"
        Me.cmb_TaxType_Reduced.Size = New System.Drawing.Size(168, 23)
        Me.cmb_TaxType_Reduced.TabIndex = 230
        Me.cmb_TaxType_Reduced.Text = "ComboBox1"
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label53.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label53.Location = New System.Drawing.Point(7, 33)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(137, 24)
        Me.Label53.TabIndex = 227
        Me.Label53.Text = "é©é–ÉRÅ[Éh"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label59.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label59.Image = CType(resources.GetObject("Label59.Image"), System.Drawing.Image)
        Me.Label59.Location = New System.Drawing.Point(8, 94)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(137, 24)
        Me.Label59.TabIndex = 229
        Me.Label59.Text = "ÑØåyå∏ê≈ó¶ ê≈Ω√∞¿Ω"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label50.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label50.Location = New System.Drawing.Point(7, 9)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(137, 24)
        Me.Label50.TabIndex = 226
        Me.Label50.Text = "ÉÅÉjÉÖÅ[ÉRÅ[Éh"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox5
        '
        Me.GroupBox5.BackgroundImage = Global.CNL1501.My.Resources.Resources.back2
        Me.GroupBox5.Controls.Add(Me.rbt_OES_Disabled)
        Me.GroupBox5.Controls.Add(Me.rbt_OES_Enabled)
        Me.GroupBox5.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.75!)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 486)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(329, 43)
        Me.GroupBox5.TabIndex = 225
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "OESópÉÅÉjÉÖÅ["
        '
        'rbt_OES_Disabled
        '
        Me.rbt_OES_Disabled.AutoSize = True
        Me.rbt_OES_Disabled.BackgroundImage = CType(resources.GetObject("rbt_OES_Disabled.BackgroundImage"), System.Drawing.Image)
        Me.rbt_OES_Disabled.Location = New System.Drawing.Point(213, 16)
        Me.rbt_OES_Disabled.Name = "rbt_OES_Disabled"
        Me.rbt_OES_Disabled.Size = New System.Drawing.Size(67, 17)
        Me.rbt_OES_Disabled.TabIndex = 0
        Me.rbt_OES_Disabled.Text = "ÇµÇ»Ç¢"
        Me.rbt_OES_Disabled.UseVisualStyleBackColor = True
        '
        'rbt_OES_Enabled
        '
        Me.rbt_OES_Enabled.AutoSize = True
        Me.rbt_OES_Enabled.BackgroundImage = CType(resources.GetObject("rbt_OES_Enabled.BackgroundImage"), System.Drawing.Image)
        Me.rbt_OES_Enabled.Checked = True
        Me.rbt_OES_Enabled.Location = New System.Drawing.Point(87, 19)
        Me.rbt_OES_Enabled.Name = "rbt_OES_Enabled"
        Me.rbt_OES_Enabled.Size = New System.Drawing.Size(53, 17)
        Me.rbt_OES_Enabled.TabIndex = 0
        Me.rbt_OES_Enabled.TabStop = True
        Me.rbt_OES_Enabled.Text = "Ç∑ÇÈ"
        Me.rbt_OES_Enabled.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = Global.CNL1501.My.Resources.Resources.back2
        Me.GroupBox4.Controls.Add(Me.rbt_Takeout_Takeout)
        Me.GroupBox4.Controls.Add(Me.rbt_Takeout_Both)
        Me.GroupBox4.Controls.Add(Me.rbt_Takeout_Eatin)
        Me.GroupBox4.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.75!)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 430)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(329, 50)
        Me.GroupBox4.TabIndex = 225
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "à˘êH/éùãA"
        '
        'rbt_Takeout_Takeout
        '
        Me.rbt_Takeout_Takeout.AutoSize = True
        Me.rbt_Takeout_Takeout.BackgroundImage = CType(resources.GetObject("rbt_Takeout_Takeout.BackgroundImage"), System.Drawing.Image)
        Me.rbt_Takeout_Takeout.Location = New System.Drawing.Point(263, 19)
        Me.rbt_Takeout_Takeout.Name = "rbt_Takeout_Takeout"
        Me.rbt_Takeout_Takeout.Size = New System.Drawing.Size(53, 17)
        Me.rbt_Takeout_Takeout.TabIndex = 1
        Me.rbt_Takeout_Takeout.Text = "éùãA"
        Me.rbt_Takeout_Takeout.UseVisualStyleBackColor = True
        '
        'rbt_Takeout_Both
        '
        Me.rbt_Takeout_Both.AutoSize = True
        Me.rbt_Takeout_Both.BackgroundImage = CType(resources.GetObject("rbt_Takeout_Both.BackgroundImage"), System.Drawing.Image)
        Me.rbt_Takeout_Both.Location = New System.Drawing.Point(169, 19)
        Me.rbt_Takeout_Both.Name = "rbt_Takeout_Both"
        Me.rbt_Takeout_Both.Size = New System.Drawing.Size(67, 17)
        Me.rbt_Takeout_Both.TabIndex = 0
        Me.rbt_Takeout_Both.Text = "óºï˚â¬"
        Me.rbt_Takeout_Both.UseVisualStyleBackColor = True
        '
        'rbt_Takeout_Eatin
        '
        Me.rbt_Takeout_Eatin.AutoSize = True
        Me.rbt_Takeout_Eatin.BackgroundImage = CType(resources.GetObject("rbt_Takeout_Eatin.BackgroundImage"), System.Drawing.Image)
        Me.rbt_Takeout_Eatin.Checked = True
        Me.rbt_Takeout_Eatin.Location = New System.Drawing.Point(85, 19)
        Me.rbt_Takeout_Eatin.Name = "rbt_Takeout_Eatin"
        Me.rbt_Takeout_Eatin.Size = New System.Drawing.Size(53, 17)
        Me.rbt_Takeout_Eatin.TabIndex = 0
        Me.rbt_Takeout_Eatin.TabStop = True
        Me.rbt_Takeout_Eatin.Text = "à˘êH"
        Me.rbt_Takeout_Eatin.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = Global.CNL1501.My.Resources.Resources.back2
        Me.GroupBox3.Controls.Add(Me.rbt_Discount_Extra)
        Me.GroupBox3.Controls.Add(Me.rbt_Discount_Discount)
        Me.GroupBox3.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.75!)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 370)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(329, 45)
        Me.GroupBox3.TabIndex = 225
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "è¨åväÑà¯/äÑëù"
        '
        'rbt_Discount_Extra
        '
        Me.rbt_Discount_Extra.AutoSize = True
        Me.rbt_Discount_Extra.BackgroundImage = CType(resources.GetObject("rbt_Discount_Extra.BackgroundImage"), System.Drawing.Image)
        Me.rbt_Discount_Extra.Location = New System.Drawing.Point(212, 19)
        Me.rbt_Discount_Extra.Name = "rbt_Discount_Extra"
        Me.rbt_Discount_Extra.Size = New System.Drawing.Size(67, 17)
        Me.rbt_Discount_Extra.TabIndex = 0
        Me.rbt_Discount_Extra.Text = "îÒëŒè€"
        Me.rbt_Discount_Extra.UseVisualStyleBackColor = True
        '
        'rbt_Discount_Discount
        '
        Me.rbt_Discount_Discount.AutoSize = True
        Me.rbt_Discount_Discount.BackgroundImage = CType(resources.GetObject("rbt_Discount_Discount.BackgroundImage"), System.Drawing.Image)
        Me.rbt_Discount_Discount.Checked = True
        Me.rbt_Discount_Discount.Location = New System.Drawing.Point(87, 19)
        Me.rbt_Discount_Discount.Name = "rbt_Discount_Discount"
        Me.rbt_Discount_Discount.Size = New System.Drawing.Size(53, 17)
        Me.rbt_Discount_Discount.TabIndex = 0
        Me.rbt_Discount_Discount.TabStop = True
        Me.rbt_Discount_Discount.Text = "ëŒè€"
        Me.rbt_Discount_Discount.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.CNL1501.My.Resources.Resources.back2
        Me.GroupBox2.Controls.Add(Me.rbt_Qadd_Enabled)
        Me.GroupBox2.Controls.Add(Me.rbt_Qadd_Disabled)
        Me.GroupBox2.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.75!)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 307)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(329, 45)
        Me.GroupBox2.TabIndex = 224
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "êîó â¡éZ"
        '
        'rbt_Qadd_Enabled
        '
        Me.rbt_Qadd_Enabled.AutoSize = True
        Me.rbt_Qadd_Enabled.BackgroundImage = CType(resources.GetObject("rbt_Qadd_Enabled.BackgroundImage"), System.Drawing.Image)
        Me.rbt_Qadd_Enabled.Location = New System.Drawing.Point(213, 19)
        Me.rbt_Qadd_Enabled.Name = "rbt_Qadd_Enabled"
        Me.rbt_Qadd_Enabled.Size = New System.Drawing.Size(53, 17)
        Me.rbt_Qadd_Enabled.TabIndex = 0
        Me.rbt_Qadd_Enabled.Text = "â¡éZ"
        Me.rbt_Qadd_Enabled.UseVisualStyleBackColor = True
        '
        'rbt_Qadd_Disabled
        '
        Me.rbt_Qadd_Disabled.AutoSize = True
        Me.rbt_Qadd_Disabled.BackgroundImage = CType(resources.GetObject("rbt_Qadd_Disabled.BackgroundImage"), System.Drawing.Image)
        Me.rbt_Qadd_Disabled.Checked = True
        Me.rbt_Qadd_Disabled.Location = New System.Drawing.Point(87, 19)
        Me.rbt_Qadd_Disabled.Name = "rbt_Qadd_Disabled"
        Me.rbt_Qadd_Disabled.Size = New System.Drawing.Size(67, 17)
        Me.rbt_Qadd_Disabled.TabIndex = 0
        Me.rbt_Qadd_Disabled.TabStop = True
        Me.rbt_Qadd_Disabled.Text = "ïsâ¡éZ"
        Me.rbt_Qadd_Disabled.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.CNL1501.My.Resources.Resources.back2
        Me.GroupBox1.Controls.Add(Me.rbt_Ptype_Open)
        Me.GroupBox1.Controls.Add(Me.rbt_Ptype_Preset)
        Me.GroupBox1.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 245)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 46)
        Me.GroupBox1.TabIndex = 224
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "íPâøéÌï "
        '
        'rbt_Ptype_Open
        '
        Me.rbt_Ptype_Open.AutoSize = True
        Me.rbt_Ptype_Open.BackgroundImage = CType(resources.GetObject("rbt_Ptype_Open.BackgroundImage"), System.Drawing.Image)
        Me.rbt_Ptype_Open.Location = New System.Drawing.Point(213, 19)
        Me.rbt_Ptype_Open.Name = "rbt_Ptype_Open"
        Me.rbt_Ptype_Open.Size = New System.Drawing.Size(81, 17)
        Me.rbt_Ptype_Open.TabIndex = 0
        Me.rbt_Ptype_Open.Text = "ÉIÅ[ÉvÉì"
        Me.rbt_Ptype_Open.UseVisualStyleBackColor = True
        '
        'rbt_Ptype_Preset
        '
        Me.rbt_Ptype_Preset.AutoSize = True
        Me.rbt_Ptype_Preset.BackgroundImage = CType(resources.GetObject("rbt_Ptype_Preset.BackgroundImage"), System.Drawing.Image)
        Me.rbt_Ptype_Preset.Checked = True
        Me.rbt_Ptype_Preset.Location = New System.Drawing.Point(87, 19)
        Me.rbt_Ptype_Preset.Name = "rbt_Ptype_Preset"
        Me.rbt_Ptype_Preset.Size = New System.Drawing.Size(95, 17)
        Me.rbt_Ptype_Preset.TabIndex = 0
        Me.rbt_Ptype_Preset.TabStop = True
        Me.rbt_Ptype_Preset.Text = "ÉvÉäÉZÉbÉg"
        Me.rbt_Ptype_Preset.UseVisualStyleBackColor = True
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.SystemColors.Control
        Me.Label52.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label52.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label52.Image = CType(resources.GetObject("Label52.Image"), System.Drawing.Image)
        Me.Label52.Location = New System.Drawing.Point(302, 180)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(30, 24)
        Me.Label52.TabIndex = 222
        Me.Label52.Text = "â~"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label54.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label54.Image = CType(resources.GetObject("Label54.Image"), System.Drawing.Image)
        Me.Label54.Location = New System.Drawing.Point(10, 180)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(220, 24)
        Me.Label54.TabIndex = 220
        Me.Label54.Text = "ÉTÉuÉÅÉjÉÖÅ[íPâø"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.SystemColors.Control
        Me.Label55.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label55.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label55.Image = CType(resources.GetObject("Label55.Image"), System.Drawing.Image)
        Me.Label55.Location = New System.Drawing.Point(302, 207)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(30, 24)
        Me.Label55.TabIndex = 219
        Me.Label55.Text = "â~"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_SubPrice
        '
        Me.txt_SubPrice.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_SubPrice.Location = New System.Drawing.Point(236, 182)
        Me.txt_SubPrice.Name = "txt_SubPrice"
        Me.txt_SubPrice.Size = New System.Drawing.Size(64, 22)
        Me.txt_SubPrice.TabIndex = 217
        Me.txt_SubPrice.Text = "999,999"
        Me.txt_SubPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmb_TaxType
        '
        Me.cmb_TaxType.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb_TaxType.Location = New System.Drawing.Point(151, 70)
        Me.cmb_TaxType.Name = "cmb_TaxType"
        Me.cmb_TaxType.Size = New System.Drawing.Size(168, 23)
        Me.cmb_TaxType.TabIndex = 223
        Me.cmb_TaxType.Text = "ComboBox1"
        '
        'txt_SubPrice_Reduce
        '
        Me.txt_SubPrice_Reduce.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_SubPrice_Reduce.Location = New System.Drawing.Point(236, 207)
        Me.txt_SubPrice_Reduce.Name = "txt_SubPrice_Reduce"
        Me.txt_SubPrice_Reduce.Size = New System.Drawing.Size(64, 22)
        Me.txt_SubPrice_Reduce.TabIndex = 217
        Me.txt_SubPrice_Reduce.Text = "999,999"
        Me.txt_SubPrice_Reduce.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label56.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label56.Image = CType(resources.GetObject("Label56.Image"), System.Drawing.Image)
        Me.Label56.Location = New System.Drawing.Point(10, 205)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(220, 24)
        Me.Label56.TabIndex = 218
        Me.Label56.Text = "ÑØåyå∏ê≈ó¶ ÉTÉuÉÅÉjÉÖÅ[íPâø"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.SystemColors.Control
        Me.Label51.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label51.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label51.Image = CType(resources.GetObject("Label51.Image"), System.Drawing.Image)
        Me.Label51.Location = New System.Drawing.Point(302, 129)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(30, 24)
        Me.Label51.TabIndex = 216
        Me.Label51.Text = "â~"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_GoodsCode
        '
        Me.lbl_GoodsCode.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_GoodsCode.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!)
        Me.lbl_GoodsCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_GoodsCode.Image = CType(resources.GetObject("lbl_GoodsCode.Image"), System.Drawing.Image)
        Me.lbl_GoodsCode.Location = New System.Drawing.Point(279, 31)
        Me.lbl_GoodsCode.Name = "lbl_GoodsCode"
        Me.lbl_GoodsCode.Size = New System.Drawing.Size(47, 24)
        Me.lbl_GoodsCode.TabIndex = 215
        Me.lbl_GoodsCode.Text = "9999"
        Me.lbl_GoodsCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_GoodsCode.Visible = False
        '
        'lbl_Price
        '
        Me.lbl_Price.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_Price.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!)
        Me.lbl_Price.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Price.Image = CType(resources.GetObject("lbl_Price.Image"), System.Drawing.Image)
        Me.lbl_Price.Location = New System.Drawing.Point(233, 130)
        Me.lbl_Price.Name = "lbl_Price"
        Me.lbl_Price.Size = New System.Drawing.Size(67, 24)
        Me.lbl_Price.TabIndex = 215
        Me.lbl_Price.Text = "999,999"
        Me.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label49.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label49.Location = New System.Drawing.Point(10, 130)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(220, 24)
        Me.Label49.TabIndex = 214
        Me.Label49.Text = "íPâø"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.Transparent
        Me.Label57.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label57.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label57.Image = CType(resources.GetObject("Label57.Image"), System.Drawing.Image)
        Me.Label57.Location = New System.Drawing.Point(8, 67)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(134, 24)
        Me.Label57.TabIndex = 218
        Me.Label57.Text = "ê≈Ω√∞¿Ω"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.SystemColors.Control
        Me.Label47.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label47.Image = CType(resources.GetObject("Label47.Image"), System.Drawing.Image)
        Me.Label47.Location = New System.Drawing.Point(302, 156)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(30, 24)
        Me.Label47.TabIndex = 213
        Me.Label47.Text = "â~"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_OwnCompanyCode
        '
        Me.txt_OwnCompanyCode.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_OwnCompanyCode.Location = New System.Drawing.Point(150, 33)
        Me.txt_OwnCompanyCode.MaxLength = 13
        Me.txt_OwnCompanyCode.Name = "txt_OwnCompanyCode"
        Me.txt_OwnCompanyCode.Size = New System.Drawing.Size(130, 22)
        Me.txt_OwnCompanyCode.TabIndex = 211
        Me.txt_OwnCompanyCode.Text = "9999999999999"
        Me.txt_OwnCompanyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Price_Reduce
        '
        Me.txt_Price_Reduce.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Price_Reduce.Location = New System.Drawing.Point(236, 156)
        Me.txt_Price_Reduce.Name = "txt_Price_Reduce"
        Me.txt_Price_Reduce.Size = New System.Drawing.Size(64, 22)
        Me.txt_Price_Reduce.TabIndex = 211
        Me.txt_Price_Reduce.Text = "999,999"
        Me.txt_Price_Reduce.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label48.Image = CType(resources.GetObject("Label48.Image"), System.Drawing.Image)
        Me.Label48.Location = New System.Drawing.Point(10, 156)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(220, 24)
        Me.Label48.TabIndex = 212
        Me.Label48.Text = "ÑØåyå∏ê≈ó¶ íPâø"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage5
        '
        Me.TabPage5.BackgroundImage = Global.CNL1501.My.Resources.Resources.back2
        Me.TabPage5.Controls.Add(Me.Label66)
        Me.TabPage5.Controls.Add(Me.Label65)
        Me.TabPage5.Controls.Add(Me.Label64)
        Me.TabPage5.Controls.Add(Me.Label63)
        Me.TabPage5.Controls.Add(Me.Label62)
        Me.TabPage5.Controls.Add(Me.Label61)
        Me.TabPage5.Controls.Add(Me.Label60)
        Me.TabPage5.Controls.Add(Me.Label58)
        Me.TabPage5.Controls.Add(Me.cbo_OP12)
        Me.TabPage5.Controls.Add(Me.cbo_OP11)
        Me.TabPage5.Controls.Add(Me.cbo_OP10)
        Me.TabPage5.Controls.Add(Me.cbo_OP9)
        Me.TabPage5.Controls.Add(Me.cbo_OP8)
        Me.TabPage5.Controls.Add(Me.cbo_OP7)
        Me.TabPage5.Controls.Add(Me.cbo_OP6)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(341, 553)
        Me.TabPage5.TabIndex = 5
        Me.TabPage5.Text = "è§ïièÓïÒ4"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label66
        '
        Me.Label66.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label66.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label66.Image = CType(resources.GetObject("Label66.Image"), System.Drawing.Image)
        Me.Label66.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label66.Location = New System.Drawing.Point(74, 309)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(25, 24)
        Me.Label66.TabIndex = 228
        Me.Label66.Text = "12"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label65
        '
        Me.Label65.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label65.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label65.Image = CType(resources.GetObject("Label65.Image"), System.Drawing.Image)
        Me.Label65.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label65.Location = New System.Drawing.Point(74, 264)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(25, 24)
        Me.Label65.TabIndex = 227
        Me.Label65.Text = "11"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label64
        '
        Me.Label64.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label64.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label64.Image = CType(resources.GetObject("Label64.Image"), System.Drawing.Image)
        Me.Label64.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label64.Location = New System.Drawing.Point(74, 219)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(25, 24)
        Me.Label64.TabIndex = 226
        Me.Label64.Text = "10"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label63
        '
        Me.Label63.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label63.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label63.Image = CType(resources.GetObject("Label63.Image"), System.Drawing.Image)
        Me.Label63.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label63.Location = New System.Drawing.Point(83, 173)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(16, 24)
        Me.Label63.TabIndex = 225
        Me.Label63.Text = "9"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label62
        '
        Me.Label62.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label62.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label62.Image = CType(resources.GetObject("Label62.Image"), System.Drawing.Image)
        Me.Label62.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label62.Location = New System.Drawing.Point(83, 129)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(16, 24)
        Me.Label62.TabIndex = 224
        Me.Label62.Text = "8"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label61
        '
        Me.Label61.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label61.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label61.Image = CType(resources.GetObject("Label61.Image"), System.Drawing.Image)
        Me.Label61.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label61.Location = New System.Drawing.Point(83, 81)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(16, 24)
        Me.Label61.TabIndex = 223
        Me.Label61.Text = "7"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label60
        '
        Me.Label60.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label60.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label60.Image = CType(resources.GetObject("Label60.Image"), System.Drawing.Image)
        Me.Label60.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label60.Location = New System.Drawing.Point(83, 37)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(16, 24)
        Me.Label60.TabIndex = 222
        Me.Label60.Text = "6"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.SystemColors.Control
        Me.Label58.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label58.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label58.Image = CType(resources.GetObject("Label58.Image"), System.Drawing.Image)
        Me.Label58.Location = New System.Drawing.Point(12, 8)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(228, 24)
        Me.Label58.TabIndex = 221
        Me.Label58.Text = "ÉTÉuÉRÉÅÉìÉg/ÉZÉbÉg"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbo_OP12
        '
        Me.cbo_OP12.FormattingEnabled = True
        Me.cbo_OP12.Location = New System.Drawing.Point(100, 311)
        Me.cbo_OP12.Name = "cbo_OP12"
        Me.cbo_OP12.Size = New System.Drawing.Size(121, 23)
        Me.cbo_OP12.TabIndex = 6
        '
        'cbo_OP11
        '
        Me.cbo_OP11.FormattingEnabled = True
        Me.cbo_OP11.Location = New System.Drawing.Point(100, 266)
        Me.cbo_OP11.Name = "cbo_OP11"
        Me.cbo_OP11.Size = New System.Drawing.Size(121, 23)
        Me.cbo_OP11.TabIndex = 5
        '
        'cbo_OP10
        '
        Me.cbo_OP10.FormattingEnabled = True
        Me.cbo_OP10.Location = New System.Drawing.Point(100, 220)
        Me.cbo_OP10.Name = "cbo_OP10"
        Me.cbo_OP10.Size = New System.Drawing.Size(121, 23)
        Me.cbo_OP10.TabIndex = 4
        '
        'cbo_OP9
        '
        Me.cbo_OP9.FormattingEnabled = True
        Me.cbo_OP9.Location = New System.Drawing.Point(100, 173)
        Me.cbo_OP9.Name = "cbo_OP9"
        Me.cbo_OP9.Size = New System.Drawing.Size(121, 23)
        Me.cbo_OP9.TabIndex = 3
        '
        'cbo_OP8
        '
        Me.cbo_OP8.FormattingEnabled = True
        Me.cbo_OP8.Location = New System.Drawing.Point(100, 129)
        Me.cbo_OP8.Name = "cbo_OP8"
        Me.cbo_OP8.Size = New System.Drawing.Size(121, 23)
        Me.cbo_OP8.TabIndex = 2
        '
        'cbo_OP7
        '
        Me.cbo_OP7.FormattingEnabled = True
        Me.cbo_OP7.Location = New System.Drawing.Point(100, 81)
        Me.cbo_OP7.Name = "cbo_OP7"
        Me.cbo_OP7.Size = New System.Drawing.Size(121, 23)
        Me.cbo_OP7.TabIndex = 1
        '
        'cbo_OP6
        '
        Me.cbo_OP6.FormattingEnabled = True
        Me.cbo_OP6.Location = New System.Drawing.Point(100, 37)
        Me.cbo_OP6.Name = "cbo_OP6"
        Me.cbo_OP6.Size = New System.Drawing.Size(121, 23)
        Me.cbo_OP6.TabIndex = 0
        '
        'TabPage_MULTI_LING
        '
        Me.TabPage_MULTI_LING.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_MULTI_LING.BackgroundImage = Global.CNL1501.My.Resources.Resources.back2
        Me.TabPage_MULTI_LING.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage_MULTI_LING.Controls.Add(Me.txt_EXPNOTEJ_C)
        Me.TabPage_MULTI_LING.Controls.Add(Me.txt_TPGoodsNM2_C)
        Me.TabPage_MULTI_LING.Controls.Add(Me.txt_TPGoodsNM_C)
        Me.TabPage_MULTI_LING.Controls.Add(Me.Label34)
        Me.TabPage_MULTI_LING.Controls.Add(Me.Label39)
        Me.TabPage_MULTI_LING.Controls.Add(Me.Label44)
        Me.TabPage_MULTI_LING.Controls.Add(Me.Label45)
        Me.TabPage_MULTI_LING.Controls.Add(Me.LabelMenuLanguage4)
        Me.TabPage_MULTI_LING.Controls.Add(Me.txt_EXPNOTEJ_A)
        Me.TabPage_MULTI_LING.Controls.Add(Me.txt_TPGoodsNM2_A)
        Me.TabPage_MULTI_LING.Controls.Add(Me.txt_TPGoodsNM_A)
        Me.TabPage_MULTI_LING.Controls.Add(Me.txt_EXPNOTEJ_B)
        Me.TabPage_MULTI_LING.Controls.Add(Me.txt_TPGoodsNM2_B)
        Me.TabPage_MULTI_LING.Controls.Add(Me.txt_TPGoodsNM_B)
        Me.TabPage_MULTI_LING.Controls.Add(Me.Label43)
        Me.TabPage_MULTI_LING.Controls.Add(Me.Label42)
        Me.TabPage_MULTI_LING.Controls.Add(Me.Label41)
        Me.TabPage_MULTI_LING.Controls.Add(Me.Label40)
        Me.TabPage_MULTI_LING.Controls.Add(Me.LabelMenuLanguage3)
        Me.TabPage_MULTI_LING.Controls.Add(Me.Label38)
        Me.TabPage_MULTI_LING.Controls.Add(Me.Label37)
        Me.TabPage_MULTI_LING.Controls.Add(Me.Label36)
        Me.TabPage_MULTI_LING.Controls.Add(Me.Label35)
        Me.TabPage_MULTI_LING.Controls.Add(Me.LabelMenuLanguage2)
        Me.TabPage_MULTI_LING.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage_MULTI_LING.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_MULTI_LING.Name = "TabPage_MULTI_LING"
        Me.TabPage_MULTI_LING.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_MULTI_LING.Size = New System.Drawing.Size(341, 553)
        Me.TabPage_MULTI_LING.TabIndex = 3
        Me.TabPage_MULTI_LING.Text = "ëΩåæåÍìoò^"
        Me.TabPage_MULTI_LING.UseVisualStyleBackColor = True
        '
        'txt_EXPNOTEJ_C
        '
        Me.txt_EXPNOTEJ_C.AcceptsReturn = True
        Me.txt_EXPNOTEJ_C.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_EXPNOTEJ_C.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt_EXPNOTEJ_C.Location = New System.Drawing.Point(120, 432)
        Me.txt_EXPNOTEJ_C.MaxLength = 102
        Me.txt_EXPNOTEJ_C.Multiline = True
        Me.txt_EXPNOTEJ_C.Name = "txt_EXPNOTEJ_C"
        Me.txt_EXPNOTEJ_C.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_EXPNOTEJ_C.Size = New System.Drawing.Size(201, 114)
        Me.txt_EXPNOTEJ_C.TabIndex = 43
        Me.txt_EXPNOTEJ_C.Text = "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm" & _
            "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"
        '
        'txt_TPGoodsNM2_C
        '
        Me.txt_TPGoodsNM2_C.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_TPGoodsNM2_C.Location = New System.Drawing.Point(138, 404)
        Me.txt_TPGoodsNM2_C.Name = "txt_TPGoodsNM2_C"
        Me.txt_TPGoodsNM2_C.Size = New System.Drawing.Size(183, 22)
        Me.txt_TPGoodsNM2_C.TabIndex = 42
        Me.txt_TPGoodsNM2_C.Text = "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"
        '
        'txt_TPGoodsNM_C
        '
        Me.txt_TPGoodsNM_C.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_TPGoodsNM_C.Location = New System.Drawing.Point(138, 380)
        Me.txt_TPGoodsNM_C.Name = "txt_TPGoodsNM_C"
        Me.txt_TPGoodsNM_C.Size = New System.Drawing.Size(183, 22)
        Me.txt_TPGoodsNM_C.TabIndex = 41
        Me.txt_TPGoodsNM_C.Text = "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(3, 434)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(67, 15)
        Me.Label34.TabIndex = 20
        Me.Label34.Text = "è§ïiê‡ñæ"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(85, 408)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(47, 15)
        Me.Label39.TabIndex = 19
        Me.Label39.Text = "(â∫íi)"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(85, 384)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(47, 15)
        Me.Label44.TabIndex = 18
        Me.Label44.Text = "(è„íi)"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(6, 384)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(52, 15)
        Me.Label45.TabIndex = 17
        Me.Label45.Text = "è§ïiñº"
        '
        'LabelMenuLanguage4
        '
        Me.LabelMenuLanguage4.AutoSize = True
        Me.LabelMenuLanguage4.Location = New System.Drawing.Point(3, 368)
        Me.LabelMenuLanguage4.Name = "LabelMenuLanguage4"
        Me.LabelMenuLanguage4.Size = New System.Drawing.Size(52, 15)
        Me.LabelMenuLanguage4.TabIndex = 16
        Me.LabelMenuLanguage4.Text = "äÿçëåÍ"
        '
        'txt_EXPNOTEJ_A
        '
        Me.txt_EXPNOTEJ_A.AcceptsReturn = True
        Me.txt_EXPNOTEJ_A.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_EXPNOTEJ_A.Location = New System.Drawing.Point(120, 64)
        Me.txt_EXPNOTEJ_A.MaxLength = 102
        Me.txt_EXPNOTEJ_A.Multiline = True
        Me.txt_EXPNOTEJ_A.Name = "txt_EXPNOTEJ_A"
        Me.txt_EXPNOTEJ_A.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_EXPNOTEJ_A.Size = New System.Drawing.Size(201, 114)
        Me.txt_EXPNOTEJ_A.TabIndex = 37
        Me.txt_EXPNOTEJ_A.Text = "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm" & _
            "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"
        '
        'txt_TPGoodsNM2_A
        '
        Me.txt_TPGoodsNM2_A.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_TPGoodsNM2_A.Location = New System.Drawing.Point(138, 36)
        Me.txt_TPGoodsNM2_A.Name = "txt_TPGoodsNM2_A"
        Me.txt_TPGoodsNM2_A.Size = New System.Drawing.Size(183, 22)
        Me.txt_TPGoodsNM2_A.TabIndex = 36
        Me.txt_TPGoodsNM2_A.Text = "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"
        '
        'txt_TPGoodsNM_A
        '
        Me.txt_TPGoodsNM_A.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_TPGoodsNM_A.Location = New System.Drawing.Point(138, 12)
        Me.txt_TPGoodsNM_A.Name = "txt_TPGoodsNM_A"
        Me.txt_TPGoodsNM_A.Size = New System.Drawing.Size(183, 22)
        Me.txt_TPGoodsNM_A.TabIndex = 35
        Me.txt_TPGoodsNM_A.Text = "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"
        '
        'txt_EXPNOTEJ_B
        '
        Me.txt_EXPNOTEJ_B.AcceptsReturn = True
        Me.txt_EXPNOTEJ_B.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_EXPNOTEJ_B.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt_EXPNOTEJ_B.Location = New System.Drawing.Point(120, 248)
        Me.txt_EXPNOTEJ_B.MaxLength = 102
        Me.txt_EXPNOTEJ_B.Multiline = True
        Me.txt_EXPNOTEJ_B.Name = "txt_EXPNOTEJ_B"
        Me.txt_EXPNOTEJ_B.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_EXPNOTEJ_B.Size = New System.Drawing.Size(201, 114)
        Me.txt_EXPNOTEJ_B.TabIndex = 40
        Me.txt_EXPNOTEJ_B.Text = "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm" & _
            "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"
        '
        'txt_TPGoodsNM2_B
        '
        Me.txt_TPGoodsNM2_B.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_TPGoodsNM2_B.Location = New System.Drawing.Point(138, 220)
        Me.txt_TPGoodsNM2_B.Name = "txt_TPGoodsNM2_B"
        Me.txt_TPGoodsNM2_B.Size = New System.Drawing.Size(183, 22)
        Me.txt_TPGoodsNM2_B.TabIndex = 39
        Me.txt_TPGoodsNM2_B.Text = "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"
        '
        'txt_TPGoodsNM_B
        '
        Me.txt_TPGoodsNM_B.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_TPGoodsNM_B.Location = New System.Drawing.Point(138, 196)
        Me.txt_TPGoodsNM_B.Name = "txt_TPGoodsNM_B"
        Me.txt_TPGoodsNM_B.Size = New System.Drawing.Size(183, 22)
        Me.txt_TPGoodsNM_B.TabIndex = 38
        Me.txt_TPGoodsNM_B.Text = "ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(3, 250)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(67, 15)
        Me.Label43.TabIndex = 9
        Me.Label43.Text = "è§ïiê‡ñæ"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(85, 224)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(47, 15)
        Me.Label42.TabIndex = 8
        Me.Label42.Text = "(â∫íi)"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(85, 200)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(47, 15)
        Me.Label41.TabIndex = 7
        Me.Label41.Text = "(è„íi)"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(6, 200)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(52, 15)
        Me.Label40.TabIndex = 6
        Me.Label40.Text = "è§ïiñº"
        '
        'LabelMenuLanguage3
        '
        Me.LabelMenuLanguage3.AutoSize = True
        Me.LabelMenuLanguage3.Location = New System.Drawing.Point(3, 184)
        Me.LabelMenuLanguage3.Name = "LabelMenuLanguage3"
        Me.LabelMenuLanguage3.Size = New System.Drawing.Size(52, 15)
        Me.LabelMenuLanguage3.TabIndex = 5
        Me.LabelMenuLanguage3.Text = "íÜçëåÍ"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label38.Location = New System.Drawing.Point(3, 66)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(67, 15)
        Me.Label38.TabIndex = 4
        Me.Label38.Text = "è§ïiê‡ñæ"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label37.Location = New System.Drawing.Point(85, 40)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(47, 15)
        Me.Label37.TabIndex = 3
        Me.Label37.Text = "(â∫íi)"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label36.Location = New System.Drawing.Point(85, 16)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(47, 15)
        Me.Label36.TabIndex = 2
        Me.Label36.Text = "(è„íi)"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label35.Location = New System.Drawing.Point(6, 16)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(52, 15)
        Me.Label35.TabIndex = 1
        Me.Label35.Text = "è§ïiñº"
        '
        'LabelMenuLanguage2
        '
        Me.LabelMenuLanguage2.AutoSize = True
        Me.LabelMenuLanguage2.BackColor = System.Drawing.Color.Transparent
        Me.LabelMenuLanguage2.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelMenuLanguage2.Location = New System.Drawing.Point(3, 0)
        Me.LabelMenuLanguage2.Name = "LabelMenuLanguage2"
        Me.LabelMenuLanguage2.Size = New System.Drawing.Size(37, 15)
        Me.LabelMenuLanguage2.TabIndex = 0
        Me.LabelMenuLanguage2.Text = "âpåÍ"
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), System.Drawing.Image)
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage4.Controls.Add(Me.btn_PicClr)
        Me.TabPage4.Controls.Add(Me.btn_SelFol)
        Me.TabPage4.Controls.Add(Me.grd_PicList)
        Me.TabPage4.Font = New System.Drawing.Font("ÇlÇr ÇoÉSÉVÉbÉN", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(341, 553)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "âÊëúìoò^"
        Me.TabPage4.UseVisualStyleBackColor = True
        Me.TabPage4.Visible = False
        '
        'btn_PicClr
        '
        Me.btn_PicClr.BackColor = System.Drawing.SystemColors.Control
        Me.btn_PicClr.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_PicClr.Location = New System.Drawing.Point(18, 5)
        Me.btn_PicClr.Name = "btn_PicClr"
        Me.btn_PicClr.Size = New System.Drawing.Size(145, 36)
        Me.btn_PicClr.TabIndex = 52
        Me.btn_PicClr.Text = "è§ïiâÊëúÉNÉäÉA"
        Me.btn_PicClr.UseVisualStyleBackColor = False
        '
        'btn_SelFol
        '
        Me.btn_SelFol.BackColor = System.Drawing.SystemColors.Control
        Me.btn_SelFol.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_SelFol.Location = New System.Drawing.Point(175, 5)
        Me.btn_SelFol.Name = "btn_SelFol"
        Me.btn_SelFol.Size = New System.Drawing.Size(145, 36)
        Me.btn_SelFol.TabIndex = 51
        Me.btn_SelFol.Text = "âÊëúÉtÉHÉãÉ_ëIë"
        Me.btn_SelFol.UseVisualStyleBackColor = False
        '
        'grd_PicList
        '
        Me.grd_PicList.CaptionFont = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_PicList.CaptionText = "è§ïiâÊëúàÍóó"
        Me.grd_PicList.CaptionVisible = False
        Me.grd_PicList.DataMember = ""
        Me.grd_PicList.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_PicList.HeaderFont = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_PicList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_PicList.Location = New System.Drawing.Point(2, 47)
        Me.grd_PicList.Name = "grd_PicList"
        Me.grd_PicList.Size = New System.Drawing.Size(335, 493)
        Me.grd_PicList.TabIndex = 0
        '
        'cbo_SelGroup
        '
        Me.cbo_SelGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_SelGroup.Font = New System.Drawing.Font("ÇlÇr ÉSÉVÉbÉN", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_SelGroup.Location = New System.Drawing.Point(429, 79)
        Me.cbo_SelGroup.Name = "cbo_SelGroup"
        Me.cbo_SelGroup.Size = New System.Drawing.Size(224, 23)
        Me.cbo_SelGroup.TabIndex = 1
        '
        'txt_SelRow
        '
        Me.txt_SelRow.Location = New System.Drawing.Point(10, 35)
        Me.txt_SelRow.Name = "txt_SelRow"
        Me.txt_SelRow.Size = New System.Drawing.Size(48, 19)
        Me.txt_SelRow.TabIndex = 242
        Me.txt_SelRow.Text = "TextBox1"
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
        '
        'CNL1530
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1016, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stb_Msg)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL1530"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.grd_ItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tab_Items.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage_MULTI_LING.ResumeLayout(False)
        Me.TabPage_MULTI_LING.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.grd_PicList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Enum PROC_KIND
        GooodsEdit = 1
        RecommendationEdit = 2
    End Enum
    Public pProcKind As PROC_KIND

    Private Structure EnabledFlags
        Public ENABLED_GOODSNMJ2 As String
        Public ENABLED_GOODSNMJ4 As String
        Public ENABLED_IMAGEDATA As String
        Public ENABLED_JEXPNOTEJ As String
        Public ENABLED_SCPNO01_04 As String
        Public ENABLED_TAXPRICE As String
        Public ENABLED_KCPSTATUS As String
    End Structure

    Private L_PriceEdit As String = Nothing
    Private L_Tax_PriceEdit As String = Nothing
    Private L_OptionIndex As Integer
    Private L_blnEditFlg As Boolean
    Private L_blnDDMode As Boolean
    Private L_CRow As Long
    Private L_EnabledFlags As EnabledFlags
    Private L_sysSetOptionType As String

    ' ÉtÉBÉãÉ^éwíË
    Private Const LC_FLT_ALLITEM As String = "J000"
    Private Const LC_FLT_NOGROUP As String = "J999"

    '' É\Å[ÉgéwíË
    'Private Const LC_SORT_ALLITEM_CODE As String = "ALL_CODE"
    'Private Const LC_SORT_ALLITEM_ITEM As String = "ALL_ITEM"
    'Private Const LC_SORT_ALLITEM_PRICE As String = "ALL_PRICE"
    'Private Const LC_SORT_NOIMAGE As String = "NOIMG"
    'Private Const LC_SORT_NOINFO As String = "NOINFO"
    'Private Const LC_SORT_NOUNIT As String = "NOUNIT"




    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFèàóùãÊï™îªíË
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2004.02.02 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Function LF_PROCKIND() As PROC_KIND
        If pProcKind <> PROC_KIND.GooodsEdit And _
           pProcKind <> PROC_KIND.RecommendationEdit Then
            LF_PROCKIND = PROC_KIND.GooodsEdit
        Else
            LF_PROCKIND = pProcKind
        End If
    End Function

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFÉtÉHÅ[ÉÄì«Ç›çûÇ›éûèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub CNL1530_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''------------------------------
        '' ì‡ïîïœêîíËã`
        ''------------------------------
        Dim objForm As New CNL1810()
        Dim da As New DataAccess
        Dim TMP012Flg As String = GF_GetAppInfo3("KCP_TPM012_FLG")
        Dim PRICE_EDIT As String = GF_GetAppInfo("PRICE_EDIT")
        Dim PHOTO_PATH As String = GF_GetAppInfo("PHOTO_PATH")
        Dim MULTI_LING_USE As String = GF_GetAppInfo2("MULTI_LING_USE")
        Dim MULTI_LING_CNT As String = GF_GetAppInfo3("MULTI_LING_CNT")
        Dim HTLNMUSE As String = GF_GetAppInfo("HTLNMUSE")
        Dim KCPUSE As String = GF_GetAppInfo("KCPUSE")
        '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
        Dim TICKETUSE As String = GF_GetAppInfo("TICKETUSE")
        '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§<<<
        Dim SYS_TYPE As String = GF_GetAppInfo("SYS_TYPE")
        Dim SHOKUPOS_FLG As String = GF_GetAppInfo2("SHOKUPOS_FLG")
        Dim SMAREGI_FLG As String = GF_GetAppInfo("SMAREGI_FLG")
        Dim SEARCH_NUM_FLG As String = GF_GetAppInfo2("SEARCH_NUM_FLG")
        Dim CNWH_GAMEFLG As String = GF_GetAppInfo2("CNWH_GAMEFLG")
        Dim DELIVARY_FLG As String = GF_GetAppInfo("DELIVARY_FLG")
        Dim CNWH_ZANSU_FLG As String = GF_GetAppInfo2("CNWH_ZANSU_FLG")
        Dim TEC_MENU_CD_DIGITS As String = GF_GetAppInfo("TEC_MENU_CD_DIGITS")
        Dim OES_TOOL_VER As String = GF_GetAppInfo("OES_TOOL_VER")
        Dim TEC_REDUCED_TAX_RATE As String = GF_GetAppInfo("TEC_REDUCED_TAX_RATE")
        Dim TEC_REDUCED_SETUP As String = GF_GetAppInfo("TEC_REDUCED_SETUP")
        Dim TecDpCodeTo As String = GF_GetAppInfo("TEC_DP_CODE_TO")
        Dim ChkDpCodeFlg As String = GF_GetAppInfo("CHK_DP_CODE_FLG")
        Dim DualPriceUse As String = GF_GetAppInfo("DUAL_PRICE_USE")
        Dim ShowSubcomments As String = GF_GetAppInfo("Subcomment_FLG")
        Dim TakeoutActive As String = GF_GetAppInfo3("CNWH002_1")
        L_EnabledFlags.ENABLED_GOODSNMJ2 = GF_GetAppInfo("ENABLED_GOODSNMJ2")
        L_EnabledFlags.ENABLED_GOODSNMJ4 = GF_GetAppInfo("ENABLED_GOODSNMJ4")
        L_EnabledFlags.ENABLED_IMAGEDATA = GF_GetAppInfo("ENABLED_IMAGEDATA")
        L_EnabledFlags.ENABLED_JEXPNOTEJ = GF_GetAppInfo("ENABLED_JEXPNOTEJ")
        L_EnabledFlags.ENABLED_SCPNO01_04 = GF_GetAppInfo("ENABLED_SCPNO01_04")
        L_EnabledFlags.ENABLED_TAXPRICE = GF_GetAppInfo("ENABLED_TAXPRICE")
        L_EnabledFlags.ENABLED_KCPSTATUS = GF_GetAppInfo("ENABLED_KCPSTATUS")
        L_sysSetOptionType = GF_GetAppInfo("SYS_SetOption_TYPE")

        Try
            '------------------------------
            ' ï¬Ç∂ÇÈÉ{É^ÉìîÒï\é¶âª
            '------------------------------
            Me.ControlBox = False

            '------------------------------
            ' ÉtÉHÅ[ÉÄñºèÃê›íË
            '------------------------------
            Me.Text = IIf(LF_PROCKIND() = PROC_KIND.GooodsEdit, " è§ïiìoò^ ", " ì˙ë÷ÇÌÇËè§ïiìoò^ ")
            Me.TopMost = True

            '------------------------------
            ' ï\é¶ílÉNÉäÉA(èâä˙âª)
            '------------------------------
            grd_ItemList.AllowDrop = True
            grd_PicList.AllowDrop = True

            L_PriceEdit = PRICE_EDIT                       ' óLå¯ê´ê›íËéÊìæ
            If Len(Trim$(L_PriceEdit)) = 0 Then
                L_PriceEdit = GC_FALSE
            End If
            'è¡îÔê≈ëŒâûÅ@2013.12.19
            L_Tax_PriceEdit = PRICE_EDIT                       ' óLå¯ê´ê›íËéÊìæ
            If Len(Trim$(L_Tax_PriceEdit)) = 0 Then
                L_Tax_PriceEdit = GC_FALSE
            End If

            With txt_Price
                .Clear()
                .ImeMode = ImeMode.Disable
                .ReadOnly = IIf(L_PriceEdit = GC_TRUE, False, True)
                .ContextMenu = New ContextMenu()                            ' âEÉNÉäÉbÉNÉÅÉjÉÖÅ[ï\é¶ã÷é~ëŒçÙ
            End With

            'è¡îÔê≈çûã‡äz
            With tax_Price
                .Clear()
                .ImeMode = ImeMode.Disable
                .ReadOnly = IIf(L_PriceEdit = GC_TRUE, False, True)
                .ContextMenu = New ContextMenu()                            ' âEÉNÉäÉbÉNÉÅÉjÉÖÅ[ï\é¶ã÷é~ëŒçÙ
            End With

            txt_ExpNoteJ.Clear()
            txt_PicPath.Text = PHOTO_PATH
            tab_Items.SelectedIndex = 0                                         ' [è§ïièÓïÒì¸óÕ]É^ÉuÇèâä˙ëIëèÛë‘Ç…ê›íË
            Call GS_StatusSetup(stb_Msg)                                        ' ÉXÉeÅ[É^ÉXÉoÅ[èâä˙âª
            L_blnEditFlg = False
            txt_PicPath.Visible = False
            txt_SelRow.Visible = False
            txt_SelRow.Clear()

            If LF_PROCKIND() = PROC_KIND.RecommendationEdit Then
                btn_AddGoods.Visible = False
                Label25.Visible = False
            End If

            txt_TPGoodsNM.Clear()
            txt_TPGoodsNM2.Clear()
            'ëΩåæåÍã@î\ëŒâû
            If MULTI_LING_USE = "1" Then
                txt_TPGoodsNM_A.Clear()
                txt_TPGoodsNM2_A.Clear()
                txt_TPGoodsNM_B.Clear()
                txt_TPGoodsNM2_B.Clear()
                txt_TPGoodsNM_C.Clear()
                txt_TPGoodsNM2_C.Clear()
                If CInt(MULTI_LING_CNT) < 2 Then
                    txt_TPGoodsNM_B.Enabled = False
                    txt_TPGoodsNM2_B.Enabled = False
                    txt_EXPNOTEJ_B.Enabled = False
                End If
                If CInt(MULTI_LING_CNT) < 3 Then
                    txt_TPGoodsNM_C.Enabled = False
                    txt_TPGoodsNM2_C.Enabled = False
                    txt_EXPNOTEJ_C.Enabled = False
                End If
            End If

            lbl_KCP1.Text = ""
            lbl_KCP2.Text = ""
            lbl_KCP3.Text = ""
            lbl_KCP4.Text = ""          'KCPèoóÕêÊ4â”èäëŒâû

            Call LF_SetBumonCmb()

            ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„
            Call LF_SetPtnCmb()
            ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„

            '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura >>>
            Call LF_InsTPM600()             ' TPM600ñ¢ë∂ç›⁄∫∞ƒﬁçÏê¨èàóù
            Call LS_SetTaxTypeCombo()       ' ê≈ÉXÉeÅ[É^ÉXÉRÉìÉ{ê∂ê¨
            Call LS_SetTaxTypeCombo("1")    ' åyå∏ê≈ó¶ ê≈ÉXÉeÅ[É^ÉXÉRÉìÉ{ê∂ê¨
            '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura <<<

            '------------------------------
            ' ï\é¶éwíËÉRÉìÉ{ê∂ê¨
            '------------------------------
            Call LS_SetSelGroupCombo()                                          ' è§ïiÉOÉãÅ[ÉvéwíËÉRÉìÉ{ê∂ê¨
            'Call LS_SetSelSortCombo()                                           ' É\Å[ÉgéwíËÉRÉìÉ{ê∂ê¨
            Call LS_SetSelOptCombo()                                            ' ÉIÉvÉVÉáÉìéwíËÉRÉìÉ{ê∂ê¨(2004.05.25)

            '------------------------------
            ' è§ïiàÍóóÉOÉäÉbÉhê∂ê¨
            '------------------------------
            'cbo_SelSort.SelectedIndex = 0                                       ' [íçà”]ÉOÉäÉbÉhê∂ê¨ÉçÉWÉbÉNÇ™ÅASelGroup.SelectedIndexïœâªéûÇ…åƒÇ—èoÇ≥ÇÍÇÈ
            cbo_SelGroup.SelectedIndex = 0
            txt_Search.Clear()
            Call LS_GridSetup()

            '------------------------------
            ' è§ïiâÊëúàÍóóÉOÉäÉbÉhê∂ê¨
            '------------------------------
            Call LS_GridSetup2()
            'objForm.Close()

            If HTLNMUSE = GC_TRUE Then
                Label5.Visible = True
                txt_HTLNM1.Visible = True
                txt_HTLNM2.Visible = True
            Else
                Label5.Visible = False
                txt_HTLNM1.Visible = False
                txt_HTLNM2.Visible = False
            End If

            If KCPUSE = GC_TRUE Then
                Label7.Visible = True
                txt_GoodsNMJ4.Visible = True
            Else
                Label7.Visible = False
                txt_GoodsNMJ4.Visible = False
            End If

            '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
            If TICKETUSE = GC_TRUE Then
                Label67.Visible = False
                txt_TECKCPNM3.Visible = False
            Else
                Label67.Visible = True
                txt_TECKCPNM3.Visible = True
            End If

            If HTLNMUSE = GC_TRUE Then
                Label68.Visible = True
                txt_HTLNM5.Visible = True
            Else
                Label68.Visible = False
                txt_HTLNM5.Visible = False
            End If
            '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§<<<

            If Trim$(SYS_TYPE) = "2" Or Trim$(SYS_TYPE) = "3" Or Trim$(SHOKUPOS_FLG) = "1" Or Trim$(SMAREGI_FLG) = "1" Then
                Label9.Visible = True
                cmb_Bumon.Visible = True
            Else
                Label9.Visible = False
                cmb_Bumon.Visible = False
            End If

            If Trim$(SEARCH_NUM_FLG) = GC_FALSE Then
                Label24.Visible = True
                txt_searchNumber.Visible = True
            Else
                Label24.Visible = False
                txt_searchNumber.Visible = False
                'Me.txt_ExpNoteJ.Size = New System.Drawing.Size(201, 141)
            End If

            If Trim$(CNWH_GAMEFLG) = GC_FALSE Then
                Label26.Visible = True
                chk_game.Visible = True
            Else
                Label26.Visible = False
                chk_game.Visible = False
            End If

            If Trim$(SYS_TYPE) = "2" Or Trim$(SYS_TYPE) = "3" Then
                Label27.Visible = True
                Label28.Visible = True
                cbo_OP5.Visible = True

                Label29.Visible = True
                chk_Status0.Visible = True
                chk_Status1.Visible = True
                chk_Status2.Visible = True
                chk_Status3.Visible = True

                Label30.Visible = True
                ccp_check.Visible = True
                Label31.Visible = True
            Else
                'SYS_TYPE Ç™ 1ÅCSYS_SetOption_TYPE Ç™ 1 ÇÃÇ∆Ç´Å@ÉTÉuÉRÉÅÉìÉgÉZÉbÉgÇï\é¶Ç∑ÇÈ
                Dim visibleSubCommentSet As Boolean = (Trim$(SYS_TYPE) = "1") AndAlso (L_sysSetOptionType = "1")
                Label27.Visible = visibleSubCommentSet
                Label28.Visible = visibleSubCommentSet
                cbo_OP5.Visible = visibleSubCommentSet

                Label29.Visible = False
                chk_Status0.Visible = False
                chk_Status1.Visible = False
                chk_Status2.Visible = False
                chk_Status3.Visible = False

                Label30.Visible = False
                ccp_check.Visible = False
                Label31.Visible = False
            End If

            ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------
            If LF_ChkLaneFlg() = "1" Then
                Label46.Visible = True
                chk_Lane.Visible = True
            Else
                Label46.Visible = False
                chk_Lane.Visible = False
            End If
            ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------

            'ê≈éÌï çÄñ⁄ ï\é¶â¬î€
            If Trim$(SHOKUPOS_FLG) = GC_FALSE Then
                Label8.Visible = True
                chk_TaxKind0.Visible = True
                chk_TaxKind1.Visible = True
            Else
                Label8.Visible = False
                chk_TaxKind0.Visible = False
                chk_TaxKind1.Visible = False
            End If

            'ëΩåæåÍã@î\ëŒâû
            If Not MULTI_LING_USE = "1" Then
                tab_Items.TabPages.Remove(TabPage_MULTI_LING)
            Else
                LabelMenuLanguage2.Text = System.Configuration.ConfigurationManager.AppSettings("MenuLanguage2")
                LabelMenuLanguage3.Text = System.Configuration.ConfigurationManager.AppSettings("MenuLanguage3")
                LabelMenuLanguage4.Text = System.Configuration.ConfigurationManager.AppSettings("MenuLanguage4")
            End If

            '2016.06.21 ìcë„
            If Not LS_Load_CheckKCP() Then ' è§ïièoóÕêÊÉ`ÉFÉbÉN
                btn_KPSet.Focus()
                grd_ItemList.CurrentCell = New DataGridCell(0, -1)
            End If
            '2016.06.21 ìcë„

            'ñ{ïîîzêMëŒâû 2018.01.15 ìcë„
            If DELIVARY_FLG = "1" Or DELIVARY_FLG = "2" Or DELIVARY_FLG = "3" Then
                lblUnitPrice.Visible = True
                txtUnitPrice.Visible = True
                lblUntEn.Visible = True
            Else
                lblUnitPrice.Visible = False
                txtUnitPrice.Visible = False
                lblUntEn.Visible = False
            End If
            'ñ{ïîîzêMëŒâû 2018.01.15 ìcë„

            Call LS_GetCnt()

            ' écêîê›íËÇégÇ§Ç©Ç«Ç§Ç©
            Dim c_CNWH_ZANSU_FLG As String = CNWH_ZANSU_FLG
            If (c_CNWH_ZANSU_FLG = "0") Then
                ButtonRest.Enabled = False
                ButtonRest.Visible = False
                'Call GF_UpdData("TRUNCATE TABLE TPD700")
                Dim threadForTruncateTPD700 As New Thread(New ThreadStart(AddressOf SubForTruncateTPD700))
                threadForTruncateTPD700.Start()
            ElseIf (c_CNWH_ZANSU_FLG = "2") Then
                ButtonRest.Enabled = False
                ButtonRest.Visible = False
            End If

            'åyå∏ê≈ó¶ëŒâû
            Dim digits As String = TEC_MENU_CD_DIGITS
            txt_MenuCode.MaxLength = CInt(digits)
            txt_OwnCompanyCode.MaxLength = CInt(digits)

            'ÇµÇÂÇ≠POSÅAÉXÉ}ÉWÉåòAågéûÇ‹ÇΩÇÕTECã@äÌòAìÆîÒòAìÆÇ≈åyå∏ê≈ó¶ëŒâûÇµÇ»Ç¢èÍçáÇÕè§ïièÓïÒ3ÇîÒï\é¶Ç∆Ç∑ÇÈ
            If ((Trim$(SHOKUPOS_FLG) = "1") Or ((SYS_TYPE = "0" Or SYS_TYPE = "1") And TEC_REDUCED_TAX_RATE = "0")) And TakeoutActive = "0" Then 'Gert 03/24
                tab_Items.TabPages.Remove(TabPage2)
            End If

            If (ShowSubcomments = "0") Then
                tab_Items.TabPages.Remove(TabPage5)
            End If

            'TECã@äÌòAìÆîÒòAìÆÇ≈åyå∏ê≈ó¶ëŒâûÇ∑ÇÈèÍçá
            If (SYS_TYPE = "0" Or SYS_TYPE = "1") And TEC_REDUCED_TAX_RATE = "1" Then
                'ÇµÇÂÇ≠POSÅAÉXÉ}ÉåÉWÇ∆òAågÇµÇ»Ç¢èÍçá
                'ïKóvçÄñ⁄ÇÃÇ›ï\é¶Ç∑ÇÈ
                Label50.Visible = False
                txt_MenuCode.Visible = False
                chk_MenuCdEdit.Visible = False
                Label53.Visible = False
                txt_OwnCompanyCode.Visible = False

                Label59.Visible = False
                cmb_TaxType_Reduced.Visible = False

                Label49.Visible = False
                lbl_Price.Visible = False
                Label51.Visible = False
                Label48.Visible = False
                txt_Price_Reduce.Visible = False
                Label47.Visible = False

                Label54.Visible = False
                txt_SubPrice.Visible = False
                Label52.Visible = False
                Label56.Visible = False
                txt_SubPrice_Reduce.Visible = False
                Label55.Visible = False

                GroupBox1.Visible = False
                GroupBox2.Visible = False
                GroupBox3.Visible = False
                GroupBox4.Visible = False
                GroupBox5.Visible = False
            End If


            If SYS_TYPE = "2" Or SYS_TYPE = "3" Then
                'ïîñÂÉRÅ[ÉhÇ∆TECçÄñ⁄(à˘êHÅ^éùÇøãAÇË)ÇÃêÆçáê´É`ÉFÉbÉNÇé¿é{Ç∑ÇÈèÍçá
                If ChkDpCodeFlg = "1" Then
                    If Not LS_Load_CheckTAKEOUTTYPE(TecDpCodeTo) Then ' ïîñÂÉRÅ[ÉhÅAà˘êH/éùãAÉ`ÉFÉbÉN
                        cmb_Bumon.Focus()
                        grd_ItemList.CurrentCell = New DataGridCell(0, -1)
                    End If
                End If

                If OES_TOOL_VER = "2" Then
                    Label50.Visible = True
                    txt_MenuCode.Visible = True
                    chk_MenuCdEdit.Visible = True
                Else
                    Label50.Visible = False
                    txt_MenuCode.Visible = False
                    chk_MenuCdEdit.Visible = False
                End If

                If OES_TOOL_VER = "2" And (TEC_REDUCED_TAX_RATE = "1" Or TEC_REDUCED_SETUP = "1") And DualPriceUse = "1" Then
                    Label48.Visible = True
                    txt_Price_Reduce.Visible = True
                    Label47.Visible = True
                    Label56.Visible = True
                    txt_SubPrice_Reduce.Visible = True
                    Label55.Visible = True
                    Label59.Visible = True
                    cmb_TaxType_Reduced.Visible = True
                Else
                    Label48.Visible = False
                    txt_Price_Reduce.Visible = False
                    Label47.Visible = False
                    Label56.Visible = False
                    txt_SubPrice_Reduce.Visible = False
                    Label55.Visible = False
                    Label59.Visible = False
                    cmb_TaxType_Reduced.Visible = False
                End If
            End If
            If TakeoutActive = "1" Then 'Gert 03/24
                Label48.Visible = True
                txt_Price_Reduce.Visible = True
            End If
            If TMP012Flg = "1" Then
                Me.LowerLabel.Visible = True
                Me.LowerBox.Visible = True
                Me.UpperLabel.Visible = True
                Me.UpperBox.Visible = True
            Else
                Me.LowerLabel.Visible = False
                Me.LowerBox.Visible = False
                Me.UpperLabel.Visible = False
                Me.UpperBox.Visible = False
            End If

        Catch
            GoTo SYSTEM_ERROR

        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1530_Load")
    End Sub

    Private Shared Sub SubForTruncateTPD700()

        Call GF_UpdData("TRUNCATE TABLE TPD700")

    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïiÉOÉãÅ[ÉvéwíËÉRÉìÉ{ê∂ê¨èàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetSelGroupCombo()

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim strSQL As String = Nothing
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' ëSè§ïiÉOÉãÅ[ÉvñºéÊìæ
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT GROUPCD,"
        strSQL = strSQL & "       GROUPNM"
        strSQL = strSQL & "  FROM TPM020"
        strSQL = strSQL & " WHERE GOODSCD = '0000'"

        If LF_PROCKIND() = PROC_KIND.RecommendationEdit Then
            strSQL = strSQL & "   AND SPFLG = '" & GC_TRUE & "'"
        End If

        strSQL = strSQL & " ORDER BY GROUPCD"

        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' ÉRÉìÉ{É{ÉbÉNÉXê›íË
        '------------------------------
        Try
            With cbo_SelGroup
                .Items.Clear()  ' èâä˙ÉNÉäÉA
                .Items.Add("ëSÇƒÇÃè§ïiÇï\é¶Ç∑ÇÈ" & Space(100) & vbTab & LC_FLT_ALLITEM)

                If LF_PROCKIND() = PROC_KIND.GooodsEdit Then
                    .Items.Add("è§ïiÉOÉãÅ[ÉvéwíËÇ»Çµ" & Space(100) & vbTab & LC_FLT_NOGROUP)
                End If

                lngCnt = 0
                While lngCnt < objData.Tables("com").Rows.Count
                    If Not GF_GetRows(objData, lngCnt, objRows) Then
                        GoTo SYSTEM_ERROR
                    End If
                    .Items.Add("Åw" & Trim$(objRows("GROUPNM")) & "Åxï\é¶" & Space(100) & vbTab & Trim$(objRows("GROUPCD")))
                    lngCnt = lngCnt + 1
                End While

            End With
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetSelGroupCombo")
    End Sub

    '    ' --------------------------------------------------------------------------------
    '    ' Å@ã@Å@Å@î\ÅFÉ\Å[ÉgéwíËÉRÉìÉ{ê∂ê¨èàóù
    '    ' Å@ã@î\äTóvÅF
    '    ' Å@à¯Å@Å@êîÅF
    '    ' Å@ñﬂ ÇË ílÅF
    '    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    '    ' --------------------------------------------------------------------------------
    '    Private Sub LS_SetSelSortCombo()

    '        Try
    '            With cbo_SelSort
    '                .Items.Clear()
    '                .Items.Add("ëSÇƒï\é¶Ç∑ÇÈ(è§ïiî‘çÜèá)" & Space(100) & vbTab & LC_SORT_ALLITEM_CODE)
    '                .Items.Add("ëSÇƒï\é¶Ç∑ÇÈ(è§ïiñºèá)" & Space(100) & vbTab & LC_SORT_ALLITEM_ITEM)
    '                .Items.Add("ëSÇƒï\é¶Ç∑ÇÈ(âøäièá)" & Space(100) & vbTab & LC_SORT_ALLITEM_PRICE)
    '                .Items.Add("è§ïiâÊëúñ¢ê›íËï™ÇÃÇ›ï\é¶" & Space(100) & vbTab & LC_SORT_NOIMAGE)
    '                .Items.Add("ê‡ñæï∂ñ¢ê›íËï™ÇÃÇ›ï\é¶" & Space(100) & vbTab & LC_SORT_NOINFO)
    '                .Items.Add("è§ïiâøäiñ¢ê›íËï™ÇÃÇ›ï\é¶" & Space(100) & vbTab & LC_SORT_NOUNIT)
    '            End With
    '        Catch
    '            GoTo SYSTEM_ERROR
    '        End Try

    '        Exit Sub
    'SYSTEM_ERROR:
    '        Call GS_ErrorTerm("LS_SetSelSortCombo")
    '    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFÉIÉvÉVÉáÉìéwíËÉRÉìÉ{ê∂ê¨èàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2004.05.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetSelOptCombo()

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim strSQL As String = Nothing
        Dim strSQL2 As String = Nothing
        Dim strSQL3 As String = Nothing
        Dim objData As New DataSet()
        Dim objData2 As New DataSet()
        Dim objData3 As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strWork As String = Nothing
        Dim lngSCP(1) As Long

        '------------------------------
        ' êîó ÉIÉvÉVÉáÉìê›íËîÕàÕéÊìæ
        '------------------------------
        strWork = GF_GetAppInfo("NUMSCP_F")
        If Len(Trim$(strWork)) = 0 Then
            GoTo SYSTEM_ERROR
        End If
        lngSCP(0) = CLng(strWork)

        strWork = GF_GetAppInfo("NUMSCP_T")
        If Len(Trim$(strWork)) = 0 Then
            GoTo SYSTEM_ERROR
        End If
        lngSCP(1) = CLng(strWork)

        '------------------------------
        ' ëSè§ïiÉOÉãÅ[ÉvñºéÊìæ
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT  SCPNO,"
        strSQL = strSQL & "        GUIDE"
        strSQL = strSQL & "  FROM  TPM100"
        strSQL = strSQL & " WHERE  GUIDE    <> ''"
        strSQL = strSQL & "   AND (GOODSCD1 <> '0000'"
        strSQL = strSQL & "    OR  GOODSCD2 <> '0000'"
        strSQL = strSQL & "    OR  GOODSCD3 <> '0000')"
        strSQL = strSQL & "   AND  SCPNO    >= '001'"
        strSQL = strSQL & "   AND  SCPNO    <= '050'"
        strSQL = strSQL & " ORDER BY SCPNO"

        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        strSQL2 = ""
        strSQL2 = strSQL2 & "SELECT  SCPNO,"
        strSQL2 = strSQL2 & "        GUIDE"
        strSQL2 = strSQL2 & "  FROM  TPM100"
        strSQL2 = strSQL2 & " WHERE  GUIDE    <> ''"
        strSQL2 = strSQL2 & "   AND (GOODSCD1 <> '0000'"
        strSQL2 = strSQL2 & "    OR  GOODSCD2 <> '0000'"
        strSQL2 = strSQL2 & "    OR  GOODSCD3 <> '0000')"
        strSQL2 = strSQL2 & "   AND  SCPNO    >= '051'" 'Gert 11/26
        strSQL2 = strSQL2 & "   AND  SCPNO    <= '150'"
        strSQL2 = strSQL2 & " ORDER BY SCPNO"

        If Not GF_GetData(strSQL2, objData2) Then
            GoTo SYSTEM_ERROR
        End If

        strSQL3 = ""
        strSQL3 = strSQL3 & "SELECT  SCPNO,"
        strSQL3 = strSQL3 & "        GUIDE"
        strSQL3 = strSQL3 & "  FROM  TPM100"
        strSQL3 = strSQL3 & " WHERE  GUIDE    <> ''"
        strSQL3 = strSQL3 & "   AND (GOODSCD1 <> '0000'"
        strSQL3 = strSQL3 & "    OR  GOODSCD2 <> '0000'"
        strSQL3 = strSQL3 & "    OR  GOODSCD3 <> '0000')"
        strSQL3 = strSQL3 & "   AND  SCPNO    >= '051'"
        strSQL3 = strSQL3 & "   AND  SCPNO    <= '100'"
        strSQL3 = strSQL3 & " ORDER BY SCPNO"

        If Not GF_GetData(strSQL3, objData3) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' ÉRÉìÉ{É{ÉbÉNÉXê›íË
        '------------------------------
        Try
            cbo_OP1.DropDownStyle = ComboBoxStyle.DropDownList
            cbo_OP2.DropDownStyle = ComboBoxStyle.DropDownList
            cbo_OP3.DropDownStyle = ComboBoxStyle.DropDownList
            cbo_OP4.DropDownStyle = ComboBoxStyle.DropDownList
            cbo_OP5.DropDownStyle = ComboBoxStyle.DropDownList
            cbo_OP6.DropDownStyle = ComboBoxStyle.DropDownList
            cbo_OP7.DropDownStyle = ComboBoxStyle.DropDownList
            cbo_OP8.DropDownStyle = ComboBoxStyle.DropDownList
            cbo_OP9.DropDownStyle = ComboBoxStyle.DropDownList
            cbo_OP10.DropDownStyle = ComboBoxStyle.DropDownList
            cbo_OP11.DropDownStyle = ComboBoxStyle.DropDownList
            cbo_OP12.DropDownStyle = ComboBoxStyle.DropDownList

            cbo_OP1.Items.Clear()
            cbo_OP2.Items.Clear()
            cbo_OP3.Items.Clear()
            cbo_OP4.Items.Clear()
            cbo_OP5.Items.Clear()
            cbo_OP6.Items.Clear()
            cbo_OP7.Items.Clear()
            cbo_OP8.Items.Clear()
            cbo_OP9.Items.Clear()
            cbo_OP10.Items.Clear()
            cbo_OP11.Items.Clear()
            cbo_OP12.Items.Clear()

            Call GS_CboItemSet(cbo_OP3, "---", "000")
            Call GS_CboItemSet(cbo_OP4, "---", "000")
            Call GS_CboItemSet(cbo_OP1, "---", "000")
            Call GS_CboItemSet(cbo_OP2, "---", "000")
            Call GS_CboItemSet(cbo_OP5, "---", "000")
            Call GS_CboItemSet(cbo_OP6, "---", "000")
            Call GS_CboItemSet(cbo_OP7, "---", "000")
            Call GS_CboItemSet(cbo_OP8, "---", "000")
            Call GS_CboItemSet(cbo_OP9, "---", "000")
            Call GS_CboItemSet(cbo_OP10, "---", "000")
            Call GS_CboItemSet(cbo_OP11, "---", "000")
            Call GS_CboItemSet(cbo_OP12, "---", "000")

            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    GoTo SYSTEM_ERROR
                End If

                strWork = Trim$(objRows("SCPNO"))
                If lngSCP(0) <= CLng(strWork) And _
                   lngSCP(1) >= CLng(strWork) Then
                    strWork = strWork & vbTab & "1"                         ' êîó éwíËâ¬î\ÉIÉvÉVÉáÉì
                Else
                    strWork = strWork & vbTab & "0"                         ' í èÌÉIÉvÉVÉáÉì
                End If

                Call GS_CboItemSet(cbo_OP1, Trim$(objRows("GUIDE")), strWork)
                Call GS_CboItemSet(cbo_OP2, Trim$(objRows("GUIDE")), strWork)
                Call GS_CboItemSet(cbo_OP3, Trim$(objRows("GUIDE")), strWork)
                Call GS_CboItemSet(cbo_OP4, Trim$(objRows("GUIDE")), strWork)

                lngCnt = lngCnt + 1
            End While

            lngCnt = 0
            While lngCnt < objData2.Tables("com").Rows.Count
                If Not GF_GetRows(objData2, lngCnt, objRows) Then
                    GoTo SYSTEM_ERROR
                End If

                strWork = Trim$(objRows("SCPNO")) & vbTab & "0"

                Call GS_CboItemSet(cbo_OP6, Trim$(objRows("GUIDE")), strWork)
                Call GS_CboItemSet(cbo_OP7, Trim$(objRows("GUIDE")), strWork)
                Call GS_CboItemSet(cbo_OP8, Trim$(objRows("GUIDE")), strWork)
                Call GS_CboItemSet(cbo_OP9, Trim$(objRows("GUIDE")), strWork)
                Call GS_CboItemSet(cbo_OP10, Trim$(objRows("GUIDE")), strWork)
                Call GS_CboItemSet(cbo_OP11, Trim$(objRows("GUIDE")), strWork)
                Call GS_CboItemSet(cbo_OP12, Trim$(objRows("GUIDE")), strWork)

                lngCnt = lngCnt + 1
            End While

            lngCnt = 0
            While lngCnt < objData2.Tables("com").Rows.Count
                If Not GF_GetRows(objData2, lngCnt, objRows) Then
                    GoTo SYSTEM_ERROR
                End If

                strWork = Trim$(objRows("SCPNO")) & vbTab & "0"

                Call GS_CboItemSet(cbo_OP5, Trim$(objRows("GUIDE")), strWork)

                lngCnt = lngCnt + 1
            End While
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetSelOptCombo")
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFìoò^çœÇ›è§ïiàÍóóÉOÉäÉbÉh èâä˙ê›íËèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub LS_GridSetup()

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim objTs As New DataGridTableStyle()                               ' êVÇµÇ¢DataGridTableStyleÇÃçÏê¨
        '2019.08.09 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura >>>
        ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------
        ''Dim udtGridCol(38) As typGridColumn
        'Dim udtGridCol(39) As typGridColumn
        'Dim udtGridCol(53) As typGridColumn
        ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------
        '2019.08.09 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura >>>
        '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
        Dim udtGridCol(55) As typGridColumn
        '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§<<<

        Dim lngCnt As Long
        Dim dtsData As New DataSet()
        Dim dtsList As DataSet
        Dim objTable As DataTable

        Try
            '------------------------------
            ' ÉeÅ[ÉuÉãÉXÉ^ÉCÉãíËã`
            '------------------------------
            With objTs
                .MappingName = "ITEMLIST"                                       ' É}ÉbÉvñºÇéwíË
                .PreferredRowHeight = 85                                       ' ïWèÄçsçÇÇéwíË
            End With

            '------------------------------
            ' äeçÄñ⁄ëÆê´íËã`
            '------------------------------
            With udtGridCol(0)
                .intType = CNL1920.COLUMN_TYPE.CHECK_STYLE
                .strMapName = "SELLFLG"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 20
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = False
            End With
            With udtGridCol(1)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSCD"
                .strHeadText = "è§ïiî‘çÜ"
                .blnAllowNull = False
                .lngWidth = 70
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With
            With udtGridCol(2)
                .intType = CNL1920.COLUMN_TYPE.IMAGE_NOEDIT_STYLE
                .strMapName = "PICTURE"
                .strHeadText = "è§ïiâÊëú"
                .blnAllowNull = False
                .lngWidth = 133
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With
            With udtGridCol(3)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSNM"
                .strHeadText = "è§ïiñº"
                .blnAllowNull = False
                .lngWidth = 150
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With
            If Trim$(GF_GetAppInfo("SALES_TAX_SWITCHING")) = 0 Then
                'ê≈î≤âøäiÇÕï\é¶ÇµÇ»Ç¢
                With udtGridCol(4)
                    .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                    .strMapName = "PRICE"
                    .strHeadText = ""
                    .blnAllowNull = False
                    .lngWidth = 0
                    .objAlign = HorizontalAlignment.Center
                    .blnReadOnly = True
                End With
            Else
                With udtGridCol(4)
                    .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                    .strMapName = "PRICE"
                    .strHeadText = "ê≈î≤äz"
                    .blnAllowNull = False
                    .lngWidth = 60
                    .objAlign = HorizontalAlignment.Left
                    .blnReadOnly = True
                End With
            End If
            With udtGridCol(5)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSINFOJ"
                .strHeadText = "è§ïiê‡ñæ"
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With
            With udtGridCol(6)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GENRNM"
                .strHeadText = "ÉWÉÉÉìÉãñº"
                .blnAllowNull = False
                .lngWidth = IIf(pProcKind = PROC_KIND.GooodsEdit, 0, 119)
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With

            ' --- à»â∫ÅAâBÇµçÄñ⁄ ---
            With udtGridCol(7)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "UNIT"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(8)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "POS_ITEMNM"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(9)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "TP_ITEMNM"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(10)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "TP_ITEMNM2"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(11)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "KCP1"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(12)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "KCP2"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(13)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "KCP3"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(14)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "UPDFLG"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(15)
                .intType = CNL1920.COLUMN_TYPE.CHECK_STYLE
                .strMapName = "DISPKIND"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(16)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "OPTION"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(17)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "HTL1"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(18)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "HTL2"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(19)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "GOODSNMJ4"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(20)

                ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„
                '.intType = CNL1920.COLUMN_TYPE.CHECK_STYLE
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„

                .strMapName = "SPFLG"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With

            With udtGridCol(21)

                ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„
                '.intType = CNL1920.COLUMN_TYPE.CHECK_STYLE
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„

                .strMapName = "NEWFLG"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(22)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "BUMONCD"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(23)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "SEARCHNUMBER"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(24)
                .intType = CNL1920.COLUMN_TYPE.CHECK_STYLE
                .strMapName = "GAMEFLG"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(25)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "STATUS"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(26)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "CCPFLG"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            If Trim$(GF_GetAppInfo("SALES_TAX_SWITCHING")) = 0 Then
                'ê≈çûÇ›ã‡äzÇï\é¶Ç∑ÇÈ
                With udtGridCol(27)   'è¡îÔê≈ëŒâûÅ@2013.12.19
                    .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                    .strMapName = "TAXPRICE"
                    .strHeadText = "ê≈çûäz"
                    .blnAllowNull = False
                    .lngWidth = 60
                    .objAlign = HorizontalAlignment.Left
                    .blnReadOnly = True
                End With
            Else
                With udtGridCol(27)   'è¡îÔê≈ëŒâûÅ@2013.12.19
                    .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                    .strMapName = "TAXPRICE"
                    .strHeadText = ""
                    .blnAllowNull = False
                    .lngWidth = 0
                    .objAlign = HorizontalAlignment.Center
                    .blnReadOnly = True
                End With
            End If

            'ëΩåæåÍã@î\ëŒâû
            If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                With udtGridCol(28)
                    .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                    .strMapName = "GOODSNMJ_A"
                    .strHeadText = ""
                    .blnAllowNull = False
                    .lngWidth = 0
                    .objAlign = HorizontalAlignment.Center
                    .blnReadOnly = True
                End With
                With udtGridCol(29)
                    .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                    .strMapName = "GOODSNMJ2_A"
                    .strHeadText = ""
                    .blnAllowNull = False
                    .lngWidth = 0
                    .objAlign = HorizontalAlignment.Center
                    .blnReadOnly = True
                End With
                With udtGridCol(30)
                    .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                    .strMapName = "JEXPNOTEJ_A"
                    .strHeadText = ""
                    .blnAllowNull = False
                    .lngWidth = 0
                    .objAlign = HorizontalAlignment.Left
                    .blnReadOnly = True
                End With
                With udtGridCol(31)
                    .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                    .strMapName = "GOODSNMJ_B"
                    .strHeadText = ""
                    .blnAllowNull = False
                    .lngWidth = 0
                    .objAlign = HorizontalAlignment.Center
                    .blnReadOnly = True
                End With
                With udtGridCol(32)
                    .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                    .strMapName = "GOODSNMJ2_B"
                    .strHeadText = ""
                    .blnAllowNull = False
                    .lngWidth = 0
                    .objAlign = HorizontalAlignment.Center
                    .blnReadOnly = True
                End With
                With udtGridCol(33)
                    .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                    .strMapName = "JEXPNOTEJ_B"
                    .strHeadText = ""
                    .blnAllowNull = False
                    .lngWidth = 0
                    .objAlign = HorizontalAlignment.Left
                    .blnReadOnly = True
                End With
                With udtGridCol(34)
                    .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                    .strMapName = "GOODSNMJ_C"
                    .strHeadText = ""
                    .blnAllowNull = False
                    .lngWidth = 0
                    .objAlign = HorizontalAlignment.Center
                    .blnReadOnly = True
                End With
                With udtGridCol(35)
                    .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                    .strMapName = "GOODSNMJ2_C"
                    .strHeadText = ""
                    .blnAllowNull = False
                    .lngWidth = 0
                    .objAlign = HorizontalAlignment.Center
                    .blnReadOnly = True
                End With
                With udtGridCol(36)
                    .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                    .strMapName = "JEXPNOTEJ_C"
                    .strHeadText = ""
                    .blnAllowNull = False
                    .lngWidth = 0
                    .objAlign = HorizontalAlignment.Left
                    .blnReadOnly = True
                End With
            End If
            With udtGridCol(37)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "TAXKIND"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(38)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "COST"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------
            With udtGridCol(39)
                .intType = CNL1920.COLUMN_TYPE.CHECK_STYLE
                .strMapName = "DEPARTFLG"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------

            '2019.08.09 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura >>>
            With udtGridCol(40)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "MENUCD"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(41)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "INSTORECD"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(42)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "PRICE_RED"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(43)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "SUBPRICE"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(44)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "SUBPRICE_RED"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(45)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "PRICETYPE"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(46)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "TAXTYPE"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(47)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "TAXTYPE_RED"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(48)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "QADDITIONALFLG"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(49)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "DISCOUNTFLG"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(50)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "TAKEOUTTYPE"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(51)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "OESMENUFLG"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(52)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "UPPERTEXT"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(53)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "LOWERTEXT"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            '2019.08.09 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura <<<

            '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
            With udtGridCol(54)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "TECKCPNM3"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            With udtGridCol(55)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "HTLNM5"
                .strHeadText = ""
                .blnAllowNull = False
                .lngWidth = 0
                .objAlign = HorizontalAlignment.Center
                .blnReadOnly = True
            End With
            '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§<<<

            For lngCnt = 0 To UBound(udtGridCol)                                ' äeóÒíËã`ÇÉeÅ[ÉuÉãÉXÉ^ÉCÉãÇ…í«â¡
                Call GS_GridAddColumn(udtGridCol(lngCnt), objTs)
            Next
            objTs.AllowSorting = False                                          ' óÒå©èoÇµÉNÉäÉbÉNÇ…ÇÊÇÈÉ\Å[ÉgÇã÷é~
            objTs.RowHeadersVisible = False

            With grd_ItemList
                .TableStyles.Clear()
                .TableStyles.Add(objTs)                                         ' ÉeÅ[ÉuÉãÉXÉ^ÉCÉãÇDataGridÇ…í«â¡
                .ReadOnly = False                                               ' ï“èWã÷é~
            End With

            '------------------------------
            ' ÉOÉäÉbÉhê∂ê¨
            '------------------------------
            dtsList = New DataSet("ItemList")
            objTable = New DataTable("ITEMLIST")
            For lngCnt = 0 To UBound(udtGridCol)
                Call GS_GridAddTable(udtGridCol(lngCnt), objTable)
            Next

            '------------------------------
            ' ÉfÅ[É^ílê›íË
            '------------------------------
            If LF_PROCKIND() = PROC_KIND.GooodsEdit Then                        ' --- (2004.02.02) èàóùãÊï™í«â¡ëŒâû ---
                Call LS_SetItemGrid(objTable, udtGridCol)
            Else
                Call LS_SetItemGrid2(objTable, udtGridCol)
            End If

            dtsList.Tables.Add(objTable)                                        ' ÉeÅ[ÉuÉãÇDataSetÇ…í«â¡Ç∑ÇÈ

            Dim ds As DataSet = CType(dtsList, DataSet)
            Dim cm As CurrencyManager = CType(BindingContext(dtsList, "ItemList"), CurrencyManager)
            Dim dv As DataView = CType(cm.List, DataView)
            dv.AllowNew = False
            grd_ItemList.DataSource = dv                                    ' DataSetÇ∆ÉeÅ[ÉuÉãÇDataGridÇ…ê⁄ë±Ç∑ÇÈ


            Dim objCell As DataGridCell
            objCell.ColumnNumber = 1
            objCell.RowNumber = 0
            grd_ItemList.CurrentCell = objCell
            L_CRow = grd_ItemList.CurrentCell.RowNumber

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GridSetup")
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFìoò^çœÇ›è§ïiàÍóóÉOÉäÉbÉh ï\é¶ílê›íËèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetItemGrid(ByVal pTable As DataTable, ByVal pGridCols() As typGridColumn)

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim objData As New DataSet()
        Dim objWRow As DataRow = Nothing
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strWork As String = Nothing
        Dim strKCP() As String = Nothing
        Dim lngKCP As Long
        Dim strOTKCP(3) As String           'KCPèoóÕêÊ4â”èäëŒâû
        Dim strItemPath As String = Nothing
        Dim strMultiLingUse As String = Nothing
        Dim strDelivaryFlg As String = Nothing

        '------------------------------
        ' èâä˙ílê›íË
        '------------------------------
        strItemPath = GF_GetAppInfo("ITEM_PATH")
        strMultiLingUse = GF_GetAppInfo2("MULTI_LING_USE")
        strDelivaryFlg = GF_GetAppInfo("DELIVARY_FLG")

        '------------------------------
        ' ê›íËÉfÅ[É^éÊìæ
        '------------------------------
        If Not LF_GetTPM010(objData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            '------------------------------
            ' ÉÅÉjÉÖÅ[ÉeÅ[ÉuÉãåèêîÉ`ÉFÉbÉN
            '------------------------------
            If objData.Tables("com").Rows.Count > 0 Then
                '------------------------------
                ' É^ÉuëSëÃÇäàê´
                '------------------------------
                tab_Items.Enabled = True
            Else
                '------------------------------
                ' É^ÉuëSëÃÇîÒäàê´
                '------------------------------
                tab_Items.Enabled = False
            End If

            '------------------------------
            ' ÉÅÉjÉÖÅ[ÉeÅ[ÉuÉãÉIÅ[ÉvÉì
            '------------------------------
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objWRow) Then
                    Exit Sub
                End If

                objRows = pTable.NewRow
                objRows(pGridCols(0).strMapName) = IIf(Trim$(objWRow("SELLFLG")) = GC_TRUE, True, False)
                objRows(pGridCols(1).strMapName) = Trim$(objWRow("GOODSCD"))
                objRows(pGridCols(2).strMapName) = IIf(Len(Trim$(objWRow("IMAGEDATA"))) = 0, "", strItemPath & "\S_" & Trim$(objWRow("IMAGEDATA")))
                objRows(pGridCols(4).strMapName) = Format$(CLng(Trim$(objWRow("PRICE"))), "#,##0")
                objRows(pGridCols(5).strMapName) = Trim$(Replace(Trim$(objWRow("JEXPNOTEJ")), "<BR>", vbCrLf))
                objRows(pGridCols(6).strMapName) = ""                       ' ÉWÉÉÉìÉãñºÇÕîÒï\é¶çÄñ⁄ÇÃÇΩÇﬂÅAê›íËïsóv
                objRows(pGridCols(7).strMapName) = Trim$(objWRow("UNITJ"))
                objRows(pGridCols(8).strMapName) = RTrim$(objWRow("GOODSNMJ3"))
                objRows(pGridCols(9).strMapName) = RTrim$(objWRow("GOODSNMJ"))
                objRows(pGridCols(10).strMapName) = RTrim$(objWRow("GOODSNMJ2"))
                objRows(pGridCols(11).strMapName) = Trim$(objWRow("KCPSTATUS"))
                objRows(pGridCols(12).strMapName) = ""
                objRows(pGridCols(13).strMapName) = ""

                Erase strOTKCP
                ' ---------- 2020/03/09 èoóÕêÊ6â”èäëŒâû(START) ----------
                'ReDim strOTKCP(3)               'KCPèoóÕêÊ4â”èäëŒâû
                ReDim strOTKCP(5)
                ' ---------- 2020/03/09 èoóÕêÊ6â”èäëŒâû(END) ----------
                strWork = LF_GetKCPStat(Trim$(objWRow("KCPSTATUS")))
                If Len(Trim$(strWork)) <> 0 Then
                    strKCP = Split(strWork, ",")
                    For lngKCP = 0 To UBound(strKCP)
                        strOTKCP(lngKCP) = strKCP(lngKCP)
                    Next
                End If
                objRows(pGridCols(3).strMapName) = LF_ItemColEdit(RTrim$(objWRow("GOODSNMJ")), _
                                                                  RTrim$(objWRow("GOODSNMJ2")))

                objRows(pGridCols(14).strMapName) = GC_FALSE
                objRows(pGridCols(15).strMapName) = IIf(Trim$(objWRow("SELLFLG")) = GC_TRUE, True, False)
                objRows(pGridCols(16).strMapName) = IIf(Len(Trim$(objWRow("SCPNO01"))) = 0, "000", Trim$(objWRow("SCPNO01"))) & "," & _
                                                    IIf(Len(Trim$(objWRow("SCPNO02"))) = 0, "000", Trim$(objWRow("SCPNO02"))) & "," & _
                                                    IIf(Len(Trim$(objWRow("SCPNO03"))) = 0, "000", Trim$(objWRow("SCPNO03"))) & "," & _
                                                    IIf(Len(Trim$(objWRow("SCPNO04"))) = 0, "000", Trim$(objWRow("SCPNO04"))) & "," & _
                                                    IIf(Len(Trim$(objWRow("SCPNO05"))) = 0, "000", Trim$(objWRow("SCPNO05"))) & "," & _
                                                    IIf(Len(Trim$(objWRow("SCPNO06"))) = 0, "000", Trim$(objWRow("SCPNO06"))) & "," & _
                                                    IIf(Len(Trim$(objWRow("SCPNO07"))) = 0, "000", Trim$(objWRow("SCPNO07"))) & "," & _
                                                    IIf(Len(Trim$(objWRow("SCPNO08"))) = 0, "000", Trim$(objWRow("SCPNO08"))) & "," & _
                                                    IIf(Len(Trim$(objWRow("SCPNO09"))) = 0, "000", Trim$(objWRow("SCPNO09"))) & "," & _
                                                    IIf(Len(Trim$(objWRow("SCPNO10"))) = 0, "000", Trim$(objWRow("SCPNO10"))) & "," & _
                                                    IIf(Len(Trim$(objWRow("SCPNO11"))) = 0, "000", Trim$(objWRow("SCPNO11"))) & "," & _
                                                    IIf(Len(Trim$(objWRow("SCPNO12"))) = 0, "000", Trim$(objWRow("SCPNO12")))
                objRows(pGridCols(17).strMapName) = RTrim$(objWRow("HTLNM1"))
                objRows(pGridCols(18).strMapName) = RTrim$(objWRow("HTLNM2"))
                objRows(pGridCols(19).strMapName) = RTrim$(objWRow("GOODSNMJ4"))

                ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„
                'objRows(pGridCols(20).strMapName) = IIf(Trim$(objWRow("SPFLG")) = "1", True, False)
                'objRows(pGridCols(21).strMapName) = IIf(Trim$(objWRow("NEWFLG")) = "1", True, False)

                Dim str As String

                str = Trim$(objWRow("SPFLG"))

                objRows(pGridCols(20).strMapName) = Trim$(objWRow("SPFLG"))
                objRows(pGridCols(21).strMapName) = Trim$(objWRow("NEWFLG"))
                ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„

                objRows(pGridCols(22).strMapName) = RTrim$(objWRow("BUMONCD"))
                If IsDBNull(objWRow("SEARCHNUMBER")) Then
                    objRows(pGridCols(23).strMapName) = ""
                Else
                    objRows(pGridCols(23).strMapName) = RTrim$(objWRow("SEARCHNUMBER"))
                End If
                If IsDBNull(objWRow("GAMEFLG")) Then
                    objRows(pGridCols(24).strMapName) = False
                Else
                    objRows(pGridCols(24).strMapName) = IIf(Trim$(objWRow("GAMEFLG")) = "1", True, False)
                End If
                If IsDBNull(objWRow("CCPFLG")) Then
                    objRows(pGridCols(26).strMapName) = False
                Else
                    'objRows(pGridCols(26).strMapName) = IIf(Trim$(objWRow("CCPFLG")) = "0", True, False)
                    objRows(pGridCols(26).strMapName) = IIf(Trim$(objWRow("CCPFLG")) = "1", True, False)
                End If
                objRows(pGridCols(25).strMapName) = Trim$(objWRow("STATUS"))
                'è¡îÔê≈ëŒâûÅ@2013.12.19
                If IsDBNull(objWRow("TAXPRICE")) Then
                    objRows(pGridCols(27).strMapName) = CLng("0")
                Else
                    objRows(pGridCols(27).strMapName) = Format$(CLng(Trim$(objWRow("TAXPRICE"))), "#,##0")
                End If

                'ëΩåæåÍã@î\ëŒâû
                If strMultiLingUse = "1" Then
                    objRows(pGridCols(28).strMapName) = RTrim$(objWRow("GOODSNMJ_A"))
                    objRows(pGridCols(29).strMapName) = RTrim$(objWRow("GOODSNMJ2_A"))
                    objRows(pGridCols(30).strMapName) = Trim$(Replace(Trim$(objWRow("JEXPNOTEJ_A")), "<BR>", vbCrLf))
                    objRows(pGridCols(31).strMapName) = RTrim$(objWRow("GOODSNMJ_B"))
                    objRows(pGridCols(32).strMapName) = RTrim$(objWRow("GOODSNMJ2_B"))
                    objRows(pGridCols(33).strMapName) = Trim$(Replace(Trim$(objWRow("JEXPNOTEJ_B")), "<BR>", vbCrLf))
                    objRows(pGridCols(34).strMapName) = RTrim$(objWRow("GOODSNMJ_C"))
                    objRows(pGridCols(35).strMapName) = RTrim$(objWRow("GOODSNMJ2_C"))
                    objRows(pGridCols(36).strMapName) = Trim$(Replace(Trim$(objWRow("JEXPNOTEJ_C")), "<BR>", vbCrLf))
                End If

                If IsDBNull(objWRow("TAXKIND")) Then
                    objRows(pGridCols(37).strMapName) = ""
                Else
                    objRows(pGridCols(37).strMapName) = RTrim$(objWRow("TAXKIND"))
                End If

                ' ñ{ïîîzêMëŒâû
                If strDelivaryFlg = "1" Or strDelivaryFlg = "2" Or strDelivaryFlg = "3" Then
                    If IsDBNull(objWRow("COST")) Then
                        objRows(pGridCols(38).strMapName) = ""
                    Else
                        objRows(pGridCols(38).strMapName) = RTrim$(objWRow("COST"))
                    End If
                End If

                ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------
                If LF_ChkLaneFlg() = "1" Then
                    objRows(pGridCols(39).strMapName) = IIf(LTrim$(RTrim$(IIf(objWRow("DEPARTFLG") Is DBNull.Value, "0", objWRow("DEPARTFLG")))) = "1", True, False)
                End If
                ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------

                '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura >>>

                objRows(pGridCols(40).strMapName) = objWRow("MENUCD")
                objRows(pGridCols(41).strMapName) = objWRow("INSTORECD")
                objRows(pGridCols(42).strMapName) = objWRow("PRICE_RED")
                objRows(pGridCols(43).strMapName) = objWRow("SUBPRICE")
                objRows(pGridCols(44).strMapName) = objWRow("SUBPRICE_RED")
                objRows(pGridCols(45).strMapName) = objWRow("PRICETYPE")
                objRows(pGridCols(46).strMapName) = objWRow("TAXTYPE")
                objRows(pGridCols(47).strMapName) = objWRow("TAXTYPE_RED")
                objRows(pGridCols(48).strMapName) = objWRow("QADDITIONALFLG")
                objRows(pGridCols(49).strMapName) = objWRow("DISCOUNTFLG")
                objRows(pGridCols(50).strMapName) = objWRow("TAKEOUTTYPE")
                objRows(pGridCols(51).strMapName) = objWRow("OESMENUFLG")

                '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura <<<
                ' ëSäpì¸óÕs
                If GF_GetAppInfo("PRINT_FLG") = "1" Then
                    ' ëSäpì¸óÕ
                    objRows(pGridCols(52).strMapName) = StrConv(Trim$(objWRow("UPPERTEXT").ToString()), VbStrConv.Wide)
                    objRows(pGridCols(53).strMapName) = StrConv(Trim$(objWRow("LOWERTEXT").ToString()), VbStrConv.Wide)
                ElseIf GF_GetAppInfo("PRINT_FLG") = "2" Then
                    ' îºäpì¸óÕ
                    objRows(pGridCols(52).strMapName) = StrConv(Trim$(objWRow("UPPERTEXT").ToString()), VbStrConv.Narrow)
                    objRows(pGridCols(53).strMapName) = StrConv(Trim$(objWRow("LOWERTEXT").ToString()), VbStrConv.Narrow)
                End If

                '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
                If GF_GetAppInfo("TICKETUSE") = "1" Then
                    objRows(pGridCols(54).strMapName) = objWRow("TECKCPNM3")
                End If
                If GF_GetAppInfo("HTLNMUSE") = "0" Then
                    objRows(pGridCols(55).strMapName) = objWRow("HTLNM5")
                End If
                '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§<<<

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

    Private Function LF_ItemColEdit(ByVal pTPNM As String, ByVal pTPNM2 As String) As String

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim strWork As String = Nothing

        '------------------------------
        ' èâä˙ílê›íË
        '------------------------------
        LF_ItemColEdit = ""
        strWork = ""

        '------------------------------
        ' ï\é¶ílï“èW
        '------------------------------
        strWork = strWork & RTrim$(pTPNM) & vbCrLf                           ' É^ÉbÉ`ÉpÉlÉãï\é¶è§ïiñº
        strWork = strWork & RTrim$(pTPNM2)

        '------------------------------
        ' ï‘ãpílê›íË
        '------------------------------
        LF_ItemColEdit = strWork

    End Function

    Private Function LF_GetKCPStat(ByVal pStsBit As String) As String

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim strKCP(3) As String
        Dim lngI As Long
        Dim lngJ As Long
        Dim strRet() As String = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' èâä˙ílê›íË
        '------------------------------
        LF_GetKCPStat = ""

        strKCP(0) = Mid$(pStsBit, 1, 8)
        strKCP(1) = Mid$(pStsBit, 9, 8)
        strKCP(2) = Mid$(pStsBit, 17, 8)
        strKCP(3) = Mid$(pStsBit, 25, 8)
        Erase strRet

        lngCnt = 0
        For lngI = 0 To 3
            For lngJ = 8 To 1 Step -1                                       ' --- (2003.12.09) è∏èáèoóÕëŒâû ---
                If Mid$(strKCP(lngI), lngJ, 1) = "1" Then
                    ReDim Preserve strRet(lngCnt)
                    strRet(lngCnt) = (8 - (lngJ - 1)) + (lngI * 8)
                    lngCnt = lngCnt + 1
                End If
            Next
        Next

        '------------------------------
        ' ï‘ãpílê›íË
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

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïiÉ}ÉXÉ^éÊìæèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2004.02.02 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM010_2(ByVal pData As DataSet) As Boolean

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim strSQL As String = Nothing
        Dim strSelGrp As String = Nothing
        '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
        Dim TICKETUSE As String = GF_GetAppInfo("TICKETUSE")
        Dim HTLNMUSE As String = GF_GetAppInfo("HTLNMUSE")
        '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

        '------------------------------
        ' èâä˙ílê›íË
        '------------------------------
        LF_GetTPM010_2 = False

        '------------------------------
        ' è§ïiÉ}ÉXÉ^ëSåèéÊìæ
        '------------------------------
        Try
            strSQL = ""
            strSQL = strSQL & "SELECT TPM010.*"
            strSQL = strSQL & "      ,TPM020.GROUPCD"
            strSQL = strSQL & "      ,GENRNM.GROUPNM"
            strSQL = strSQL & "      ,TPM200.SEARCHNUMBER"
            strSQL = strSQL & "      ,TPM210.GAMEENABLED AS GAMEFLG"
            strSQL = strSQL & "      ,TPM250.CCPENABLED AS CCPFLG"

            'ëΩåæåÍã@î\ëŒâû
            If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                strSQL = strSQL & "      ,TPM010A.GOODSNMJ AS GOODSNMJ_A"
                strSQL = strSQL & "      ,TPM010A.GOODSNMJ2 AS GOODSNMJ2_A"
                strSQL = strSQL & "      ,TPM010A.JEXPNOTEJ AS JEXPNOTEJ_A"
                strSQL = strSQL & "      ,TPM010B.GOODSNMJ AS GOODSNMJ_B"
                strSQL = strSQL & "      ,TPM010B.GOODSNMJ2 AS GOODSNMJ2_B"
                strSQL = strSQL & "      ,TPM010B.JEXPNOTEJ AS JEXPNOTEJ_B"
                strSQL = strSQL & "      ,TPM010C.GOODSNMJ AS GOODSNMJ_C"
                strSQL = strSQL & "      ,TPM010C.GOODSNMJ2 AS GOODSNMJ2_C"
                strSQL = strSQL & "      ,TPM010C.JEXPNOTEJ AS JEXPNOTEJ_C"
            End If

            strSQL = strSQL & "      ,ISNULL(TPM260.TAXPRICE, 0) AS TAXPRICE"
            strSQL = strSQL & "      ,TPM320.TAXKIND"

            ' ñ{ïîîzêMëŒâû
            If GF_GetAppInfo("DELIVARY_FLG") = "1" Or GF_GetAppInfo("DELIVARY_FLG") = "2" Or GF_GetAppInfo("DELIVARY_FLG") = "3" Then
                strSQL = strSQL & "      ,TPM340.COST"
            End If

            ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------
            If LF_ChkLaneFlg() = "1" Then
                strSQL = strSQL & "     , TPM440.DEPARTFLG"
            End If
            ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------

            '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura >>>
            strSQL = strSQL & "     , TPM600.MENUCD"
            strSQL = strSQL & "     , TPM600.INSTORECD"
            strSQL = strSQL & "     , TPM600.PRICE_RED"
            strSQL = strSQL & "     , TPM600.SUBPRICE"
            strSQL = strSQL & "     , TPM600.SUBPRICE_RED"
            strSQL = strSQL & "     , TPM600.PRICETYPE"
            strSQL = strSQL & "     , TPM600.TAXTYPE"
            strSQL = strSQL & "     , TPM600.TAXTYPE_RED"
            strSQL = strSQL & "     , TPM600.QADDITIONALFLG"
            strSQL = strSQL & "     , TPM600.DISCOUNTFLG"
            strSQL = strSQL & "     , TPM600.TAKEOUTTYPE"
            strSQL = strSQL & "     , TPM600.OESMENUFLG"
            '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura <<<
            strSQL = strSQL & "     , TPM012.UPPERTEXT"
            strSQL = strSQL & "     , TPM012.LOWERTEXT"

            '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
            If TICKETUSE = "1" Then
                strSQL = strSQL & "     , TPM013.TECKCPNM3"
            End If
            If HTLNMUSE = "0" Then
                strSQL = strSQL & "     , TPM013.HTLNM5"
            End If
            '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

            strSQL = strSQL & "  FROM TPM010 LEFT JOIN TPM200"
            strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM200.GOODSCD"
            strSQL = strSQL & "              LEFT JOIN TPM210"
            strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM210.GOODSCD"
            strSQL = strSQL & "              LEFT JOIN TPM250"
            strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM250.GOODSCD"
            strSQL = strSQL & "              LEFT JOIN TPM320"
            strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM320.GOODSCD"
            strSQL = strSQL & "              LEFT JOIN TPM012"
            strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM012.GOODSCD"

            'ëΩåæåÍã@î\ëŒâû
            If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                strSQL = strSQL & "              LEFT JOIN TPM010A"
                strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM010A.GOODSCD"
                strSQL = strSQL & "              LEFT JOIN TPM010B"
                strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM010B.GOODSCD"
                strSQL = strSQL & "              LEFT JOIN TPM010C"
                strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM010C.GOODSCD"
            End If

            ' ñ{ïîîzêMëŒâû
            If GF_GetAppInfo("DELIVARY_FLG") = "1" Or GF_GetAppInfo("DELIVARY_FLG") = "2" Or GF_GetAppInfo("DELIVARY_FLG") = "3" Then
                strSQL = strSQL & "              LEFT JOIN TPM340"
                strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM340.GOODSCD"
            End If

            ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------
            If LF_ChkLaneFlg() = "1" Then
                strSQL = strSQL & "              LEFT JOIN TPM440"
                strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM440.GOODSCD"
            End If
            ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------

            '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura >>>
            strSQL = strSQL & "              LEFT JOIN TPM600"
            strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM600.GOODSCD"
            '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura <<<

            '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
            If TICKETUSE = "1" Or HTLNMUSE = "0" Then
                strSQL = strSQL & "              LEFT JOIN TPM013"
                strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM013.GOODSCD"
            End If
            '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

            'è¡îÔê≈ëŒâûÅ@2013.12.19
            strSQL = strSQL & "              LEFT JOIN TPM260"
            strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM260.GOODSCD,"
            strSQL = strSQL & "       TPM020,"
            strSQL = strSQL & "       (SELECT TPM020.GROUPCD, TPM020.GROUPNM FROM TPM020 WHERE TPM020.GOODSCD = '0000' AND TPM020.SPFLG = '0') AS GENRNM"
            strSQL = strSQL & " WHERE TPM010.GOODSCD = TPM020.GOODSCD"
            strSQL = strSQL & "   AND TPM020.GROUPCD = GENRNM.GROUPCD"

            strSelGrp = GF_CboGetCode(cbo_SelGroup, cbo_SelGroup.SelectedIndex)
            Select Case strSelGrp
                Case LC_FLT_ALLITEM
                Case LC_FLT_NOGROUP
                Case Else
                    strSQL = strSQL & "   AND TPM020.GROUPCD = '" & strSelGrp & "'"
            End Select

            If Len(Trim$(txt_Search.Text)) <> 0 Then
                strSQL = strSQL & "   AND TPM010.GOODSNMJ LIKE '%" & Trim$(txt_Search.Text) & "%'"
            End If

            'Select Case GF_CboGetCode(cbo_SelSort, cbo_SelSort.SelectedIndex)
            '    Case LC_SORT_ALLITEM_CODE
            '        strSQL = strSQL & " ORDER BY TPM010.GOODSCD, TPM020.GROUPCD"
            '    Case LC_SORT_ALLITEM_ITEM
            '        strSQL = strSQL & " ORDER BY TPM010.GOODSNMJ, TPM010.GOODSCD, TPM020.GROUPCD"
            '    Case LC_SORT_ALLITEM_PRICE
            '        strSQL = strSQL & " ORDER BY TPM010.PRICE, TPM010.GOODSCD, TPM020.GROUPCD"
            '    Case LC_SORT_NOIMAGE
            '        If InStr(strSQL, "WHERE") = 0 Then
            '            strSQL = strSQL & " WHERE "
            '        Else
            '            strSQL = strSQL & " AND "
            '        End If
            '        strSQL = strSQL & "LEN(LTRIM(TPM010.IMAGEDATA)) = 0"
            '        strSQL = strSQL & " ORDER BY TPM010.GOODSCD, TPM020.GROUPCD"
            '    Case LC_SORT_NOINFO
            '        If InStr(strSQL, "WHERE") = 0 Then
            '            strSQL = strSQL & " WHERE "
            '        Else
            '            strSQL = strSQL & " AND "
            '        End If
            '        strSQL = strSQL & "LEN(LTRIM(TPM010.JEXPNOTEJ)) = 0"
            '        strSQL = strSQL & " ORDER BY TPM010.GOODSCD, TPM020.GROUPCD"
            '    Case LC_SORT_NOUNIT
            '        If InStr(strSQL, "WHERE") = 0 Then
            '            strSQL = strSQL & " WHERE "
            '        Else
            '            strSQL = strSQL & " AND "
            '        End If
            '        strSQL = strSQL & "LEN(LTRIM(TPM010.UNITJ)) = 0"
            '        strSQL = strSQL & " ORDER BY TPM010.GOODSCD, TPM020.GROUPCD"
            '    Case Else
            '        Exit Function
            'End Select
        Catch
            Exit Function
        End Try

        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' ï‘ãpílê›íË
        '------------------------------
        LF_GetTPM010_2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFìoò^çœÇ›è§ïiàÍóóÉOÉäÉbÉh ï\é¶ílê›íËèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2004.02.02 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetItemGrid2(ByVal pTable As DataTable, ByVal pGridCols() As typGridColumn)

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim objData As New DataSet()
        Dim objWRow As DataRow = Nothing
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strWork As String = Nothing
        Dim strKCP() As String = Nothing
        Dim lngKCP As Long
        Dim strBKey As String = Nothing
        Dim strOTKCP(3) As String           'èoóÕêÊ4â”èäëŒâû
        Dim strItemPath As String = Nothing
        Dim strMultiLingUse As String = Nothing
        Dim strDelivaryFlg As String = Nothing

        '------------------------------
        ' èâä˙ílê›íË
        '------------------------------
        strItemPath = GF_GetAppInfo("ITEM_PATH")
        strMultiLingUse = GF_GetAppInfo2("MULTI_LING_USE")
        strDelivaryFlg = GF_GetAppInfo("DELIVARY_FLG")

        '------------------------------
        ' ê›íËÉfÅ[É^éÊìæ
        '------------------------------
        If Not LF_GetTPM010_2(objData) Then
            GoTo SYSTEM_ERROR
        End If

        Try
            '------------------------------
            ' ÉÅÉjÉÖÅ[ÉeÅ[ÉuÉãåèêîÉ`ÉFÉbÉN
            '------------------------------
            If objData.Tables("com").Rows.Count > 0 Then
                '------------------------------
                ' É^ÉuëSëÃÇäàê´
                '------------------------------
                tab_Items.Enabled = True
            Else
                '------------------------------
                ' É^ÉuëSëÃÇîÒäàê´
                '------------------------------
                tab_Items.Enabled = False
            End If

            '------------------------------
            ' ÉÅÉjÉÖÅ[ÉeÅ[ÉuÉãÉIÅ[ÉvÉì
            '------------------------------
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objWRow) Then
                    Exit Sub
                End If

                If strBKey <> Trim$(objWRow("GOODSCD")) Then
                    objRows = pTable.NewRow
                    objRows(pGridCols(0).strMapName) = IIf(Trim$(objWRow("SELLFLG")) = GC_TRUE, True, False)
                    objRows(pGridCols(1).strMapName) = Trim$(objWRow("GOODSCD"))
                    objRows(pGridCols(2).strMapName) = IIf(Len(Trim$(objWRow("IMAGEDATA"))) = 0, "", strItemPath & "\S_" & Trim$(objWRow("IMAGEDATA")))
                    objRows(pGridCols(4).strMapName) = Format$(CLng(Trim$(objWRow("PRICE"))), "#,##0")
                    objRows(pGridCols(5).strMapName) = Trim$(Replace(Trim$(objWRow("JEXPNOTEJ")), "<BR>", vbCrLf))
                    objRows(pGridCols(6).strMapName) = Trim$(objWRow("GROUPNM"))
                    objRows(pGridCols(7).strMapName) = Trim$(objWRow("UNITJ"))
                    objRows(pGridCols(8).strMapName) = RTrim$(objWRow("GOODSNMJ3"))
                    objRows(pGridCols(9).strMapName) = RTrim$(objWRow("GOODSNMJ"))
                    objRows(pGridCols(10).strMapName) = RTrim$(objWRow("GOODSNMJ2"))
                    objRows(pGridCols(11).strMapName) = Trim$(objWRow("KCPSTATUS"))
                    objRows(pGridCols(12).strMapName) = ""
                    objRows(pGridCols(13).strMapName) = ""
                    strWork = LF_GetKCPStat(Trim$(objWRow("KCPSTATUS")))
                    If Len(Trim$(strWork)) <> 0 Then
                        strKCP = Split(strWork, ",")
                        For lngKCP = 0 To UBound(strKCP)
                            strOTKCP(lngKCP) = strKCP(lngKCP)
                        Next
                    End If

                    objRows(pGridCols(3).strMapName) = LF_ItemColEdit(RTrim$(objWRow("GOODSNMJ")), _
                                                                      RTrim$(objWRow("GOODSNMJ2")))
                    objRows(pGridCols(14).strMapName) = GC_FALSE
                    objRows(pGridCols(15).strMapName) = IIf(Trim$(objWRow("SELLFLG")) = GC_TRUE, True, False)
                    objRows(pGridCols(16).strMapName) = IIf(Len(Trim$(objWRow("SCPNO01"))) = 0, "000", Trim$(objWRow("SCPNO01"))) & "," & _
                                                        IIf(Len(Trim$(objWRow("SCPNO02"))) = 0, "000", Trim$(objWRow("SCPNO02"))) & "," & _
                                                        IIf(Len(Trim$(objWRow("SCPNO03"))) = 0, "000", Trim$(objWRow("SCPNO03"))) & "," & _
                                                        IIf(Len(Trim$(objWRow("SCPNO04"))) = 0, "000", Trim$(objWRow("SCPNO04"))) & "," & _
                                                        IIf(Len(Trim$(objWRow("SCPNO05"))) = 0, "000", Trim$(objWRow("SCPNO05"))) & "," & _
                                                        IIf(Len(Trim$(objWRow("SCPNO06"))) = 0, "000", Trim$(objWRow("SCPNO06"))) & "," & _
                                                        IIf(Len(Trim$(objWRow("SCPNO07"))) = 0, "000", Trim$(objWRow("SCPNO07"))) & "," & _
                                                        IIf(Len(Trim$(objWRow("SCPNO08"))) = 0, "000", Trim$(objWRow("SCPNO08"))) & "," & _
                                                        IIf(Len(Trim$(objWRow("SCPNO09"))) = 0, "000", Trim$(objWRow("SCPNO09"))) & "," & _
                                                        IIf(Len(Trim$(objWRow("SCPNO10"))) = 0, "000", Trim$(objWRow("SCPNO10"))) & "," & _
                                                        IIf(Len(Trim$(objWRow("SCPNO11"))) = 0, "000", Trim$(objWRow("SCPNO11"))) & "," & _
                                                        IIf(Len(Trim$(objWRow("SCPNO12"))) = 0, "000", Trim$(objWRow("SCPNO12")))
                    objRows(pGridCols(17).strMapName) = Trim$(objWRow("HTLNM1"))
                    objRows(pGridCols(18).strMapName) = Trim$(objWRow("HTLNM2"))
                    objRows(pGridCols(19).strMapName) = RTrim$(objWRow("GOODSNMJ4"))

                    ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„
                    'objRows(pGridCols(20).strMapName) = IIf(Trim$(objWRow("SPFLG")) = "1", True, False)
                    'objRows(pGridCols(21).strMapName) = IIf(Trim$(objWRow("NEWFLG")) = "1", True, False)

                    objRows(pGridCols(20).strMapName) = Trim$(objWRow("SPFLG"))
                    objRows(pGridCols(21).strMapName) = Trim$(objWRow("NEWFLG"))
                    ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„

                    objRows(pGridCols(22).strMapName) = RTrim$(objWRow("BUMONCD"))
                    If IsDBNull(objWRow("SEARCHNUMBER")) Then
                        objRows(pGridCols(23).strMapName) = ""
                    Else
                        objRows(pGridCols(23).strMapName) = RTrim$(objWRow("SEARCHNUMBER"))
                    End If
                    If IsDBNull(objWRow("GAMEFLG")) Then
                        objRows(pGridCols(24).strMapName) = False
                    Else
                        objRows(pGridCols(24).strMapName) = IIf(Trim$(objWRow("GAMEFLG")) = "1", True, False)
                    End If
                    If IsDBNull(objWRow("CCPFLG")) Then
                        objRows(pGridCols(26).strMapName) = False
                    Else
                        'objRows(pGridCols(26).strMapName) = IIf(Trim$(objWRow("CCPFLG")) = "0", True, False)
                        objRows(pGridCols(26).strMapName) = IIf(Trim$(objWRow("CCPFLG")) = "1", True, False)
                    End If
                    objRows(pGridCols(25).strMapName) = Trim$(objWRow("STATUS"))

                    'è¡îÔê≈ëŒâûÅ@2013.12.19
                    If IsDBNull(objWRow("TAXPRICE")) Then
                        objRows(pGridCols(27).strMapName) = CLng("0")
                    Else
                        objRows(pGridCols(27).strMapName) = Format$(CLng(Trim$(objWRow("TAXPRICE"))), "#,##0")
                    End If

                    'ëΩåæåÍã@î\ëŒâû
                    If strMultiLingUse = "1" Then
                        objRows(pGridCols(28).strMapName) = RTrim$(objWRow("GOODSNMJ_A"))
                        objRows(pGridCols(29).strMapName) = RTrim$(objWRow("GOODSNMJ2_A"))
                        objRows(pGridCols(30).strMapName) = Trim$(Replace(Trim$(objWRow("JEXPNOTEJ_A")), "<BR>", vbCrLf))
                        objRows(pGridCols(31).strMapName) = RTrim$(objWRow("GOODSNMJ_B"))
                        objRows(pGridCols(32).strMapName) = RTrim$(objWRow("GOODSNMJ2_B"))
                        objRows(pGridCols(33).strMapName) = Trim$(Replace(Trim$(objWRow("JEXPNOTEJ_B")), "<BR>", vbCrLf))
                        objRows(pGridCols(34).strMapName) = RTrim$(objWRow("GOODSNMJ_C"))
                        objRows(pGridCols(35).strMapName) = RTrim$(objWRow("GOODSNMJ2_C"))
                        objRows(pGridCols(36).strMapName) = Trim$(Replace(Trim$(objWRow("JEXPNOTEJ_C")), "<BR>", vbCrLf))
                    End If

                    If IsDBNull(objWRow("TAXKIND")) Then
                        objRows(pGridCols(37).strMapName) = ""
                    Else
                        objRows(pGridCols(37).strMapName) = RTrim$(objWRow("TAXKIND"))
                    End If

                    ' ñ{ïîîzêMëŒâû
                    If strDelivaryFlg = "1" Or strDelivaryFlg = "2" Or strDelivaryFlg = "3" Then
                        If IsDBNull(objWRow("COST")) Then
                            objRows(pGridCols(38).strMapName) = ""
                        Else
                            objRows(pGridCols(38).strMapName) = RTrim$(objWRow("COST"))
                        End If
                    End If

                    ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------
                    If LF_ChkLaneFlg() = "1" Then
                        objRows(pGridCols(39).strMapName) = IIf(LTrim$(RTrim$(IIf(objWRow("DEPARTFLG") Is DBNull.Value, "0", objWRow("DEPARTFLG")))) = "1", True, False)
                    End If
                    ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------

                    '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura >>>

                    objRows(pGridCols(40).strMapName) = objWRow("MENUCD")
                    objRows(pGridCols(41).strMapName) = objWRow("INSTORECD")
                    objRows(pGridCols(42).strMapName) = objWRow("PRICE_RED")
                    objRows(pGridCols(43).strMapName) = objWRow("SUBPRICE")
                    objRows(pGridCols(44).strMapName) = objWRow("SUBPRICE_RED")
                    objRows(pGridCols(45).strMapName) = objWRow("PRICETYPE")
                    objRows(pGridCols(46).strMapName) = objWRow("TAXTYPE")
                    objRows(pGridCols(47).strMapName) = objWRow("TAXTYPE_RED")
                    objRows(pGridCols(48).strMapName) = objWRow("QADDITIONALFLG")
                    objRows(pGridCols(49).strMapName) = objWRow("DISCOUNTFLG")
                    objRows(pGridCols(50).strMapName) = objWRow("TAKEOUTTYPE")
                    objRows(pGridCols(51).strMapName) = objWRow("OESMENUFLG")

                    '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura <<<
                    objRows(pGridCols(52).strMapName) = objWRow("UPPERTEXT")
                    objRows(pGridCols(53).strMapName) = objWRow("LOWERTEXT")

                    '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
                    If GF_GetAppInfo("TICKETUSE") = "1" Then
                        objRows(pGridCols(54).strMapName) = objWRow("TECKCPNM3")
                    End If
                    If GF_GetAppInfo("HTLNMUSE") = "0" Then
                        objRows(pGridCols(55).strMapName) = objWRow("HTLNM5")
                    End If
                    '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

                    pTable.Rows.Add(objRows)
                    strBKey = Trim$(objWRow("GOODSCD"))
                Else
                    objRows(pGridCols(6).strMapName) = objRows(pGridCols(5).strMapName) & vbCrLf & _
                                                       Trim$(objWRow("GROUPNM"))
                End If

                lngCnt = lngCnt + 1
            End While
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetItemGrid2")
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïiêîéÊìæ èâä˙ê›íËèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2018.01.23 ÉNÉåÉXÉRñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub LS_GetCnt()

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim strSQL As String = Nothing
        Dim strSelGrp As String = Nothing
        Dim objData As New DataSet
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' è§ïiÉ}ÉXÉ^ëSåèéÊìæ
        '------------------------------
        Try
            strSQL = ""
            strSQL = strSQL & "SELECT COUNT(*) AS CNT"
            strSQL = strSQL & "  FROM TPM010"

            If Not GF_GetData(strSQL, objData) Then
                Exit Sub
            End If

            If objData.Tables("com").Rows.Count = 0 Then
                Exit Sub
            End If

            If Not GF_GetRows(objData, 0, objRows) Then
                Exit Sub
            End If

            lblGoodsCnt.Text = Trim$(objRows("CNT"))

        Catch
            Exit Sub
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GetCnt")
    End Sub


    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFìoò^çœÇ›è§ïiàÍóóÉOÉäÉbÉh èâä˙ê›íËèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub LS_GridSetup2()

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim objTs As New DataGridTableStyle()                               ' êVÇµÇ¢DataGridTableStyleÇÃçÏê¨
        Dim udtGridCol(1) As typGridColumn
        Dim lngCnt As Long
        Dim dtsData As New DataSet()
        Dim dtrRows As DataRow = Nothing
        Dim dtsList As DataSet
        Dim objTable As DataTable
        Dim strWork() As String = Nothing

        Try
            '------------------------------
            ' ÉeÅ[ÉuÉãÉXÉ^ÉCÉãíËã`
            '------------------------------
            With objTs
                .MappingName = "PICTURELIST"                                    ' É}ÉbÉvñºÇéwíË
                .PreferredRowHeight = 90                                        ' ïWèÄçsçÇÇéwíË
            End With

            '------------------------------
            ' äeçÄñ⁄ëÆê´íËã`
            '------------------------------
            With udtGridCol(0)
                .intType = CNL1920.COLUMN_TYPE.IMAGE_NOEDIT_STYLE
                .strMapName = "PICTURE"
                .strHeadText = "è§ïiâÊëú"
                .blnAllowNull = False
                .lngWidth = 120
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With
            With udtGridCol(1)
                .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
                .strMapName = "PICTPATH"
                .strHeadText = "âÊëúÉtÉ@ÉCÉãñº"
                .blnAllowNull = False
                .lngWidth = 192
                .objAlign = HorizontalAlignment.Left
                .blnReadOnly = True
            End With

            For lngCnt = 0 To UBound(udtGridCol)                                ' äeóÒíËã`ÇÉeÅ[ÉuÉãÉXÉ^ÉCÉãÇ…í«â¡
                Call GS_GridAddColumn(udtGridCol(lngCnt), objTs)
            Next
            objTs.AllowSorting = False                                          ' óÒå©èoÇµÉNÉäÉbÉNÇ…ÇÊÇÈÉ\Å[ÉgÇã÷é~
            objTs.RowHeadersVisible = False

            With grd_PicList
                .TableStyles.Clear()
                .TableStyles.Add(objTs)                                         ' ÉeÅ[ÉuÉãÉXÉ^ÉCÉãÇDataGridÇ…í«â¡
                .ReadOnly = True                                                ' ï“èWã÷é~
            End With

            '------------------------------
            ' ÉOÉäÉbÉhê∂ê¨
            '------------------------------
            dtsList = New DataSet("PictureList")
            objTable = New DataTable("PICTURELIST")
            For lngCnt = 0 To UBound(udtGridCol)
                Call GS_GridAddTable(udtGridCol(lngCnt), objTable)
            Next

            '------------------------------
            ' ÉfÅ[É^ílê›íË
            '------------------------------
            Dim strFile As String = Nothing
            Dim strTargetDir As String = Nothing
            Try
                strTargetDir = Trim$(txt_PicPath.Text)
                If System.IO.Directory.Exists(strTargetDir) = False Then
                    Exit Try
                End If
                For Each strFile In System.IO.Directory.GetFiles(strTargetDir, "*.JPG")
                    dtrRows = objTable.NewRow
                    dtrRows(udtGridCol(0).strMapName) = strFile
                    strWork = Split(strFile, "\")
                    dtrRows(udtGridCol(1).strMapName) = strWork(UBound(strWork))
                    objTable.Rows.Add(dtrRows)
                Next
                For Each strFile In System.IO.Directory.GetFiles(strTargetDir, "*.GIF")
                    dtrRows = objTable.NewRow
                    dtrRows(udtGridCol(0).strMapName) = strFile
                    strWork = Split(strFile, "\")
                    dtrRows(udtGridCol(1).strMapName) = strWork(UBound(strWork))
                    objTable.Rows.Add(dtrRows)
                Next
            Catch
                GoTo SYSTEM_ERROR
            End Try

            dtsList.Tables.Add(objTable)                                        ' ÉeÅ[ÉuÉãÇDataSetÇ…í«â¡Ç∑ÇÈ
            grd_PicList.SetDataBinding(dtsList, "PICTURELIST")                  ' DataSetÇ∆ÉeÅ[ÉuÉãÇDataGridÇ…ê⁄ë±Ç∑ÇÈ

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GridSetup2")
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïiÉ}ÉXÉ^éÊìæèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM010(ByVal pData As DataSet) As Boolean

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim strSQL As String = Nothing
        Dim strSelGrp As String = Nothing
        '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
        Dim TICKETUSE As String = GF_GetAppInfo("TICKETUSE")
        Dim HTLNMUSE As String = GF_GetAppInfo("HTLNMUSE")
        '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

        '------------------------------
        ' èâä˙ílê›íË
        '------------------------------
        LF_GetTPM010 = False

        '------------------------------
        ' è§ïiÉ}ÉXÉ^ëSåèéÊìæ
        '------------------------------
        Try
            strSQL = ""
            strSQL = strSQL & "SELECT TPM010.*"
            strSQL = strSQL & "      ,TPM200.SEARCHNUMBER"
            strSQL = strSQL & "      ,TPM210.GAMEENABLED AS GAMEFLG"
            strSQL = strSQL & "      ,TPM250.CCPENABLED AS CCPFLG"

            'ëΩåæåÍã@î\ëŒâû
            If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                strSQL = strSQL & "      ,TPM010A.GOODSNMJ AS GOODSNMJ_A"
                strSQL = strSQL & "      ,TPM010A.GOODSNMJ2 AS GOODSNMJ2_A"
                strSQL = strSQL & "      ,TPM010A.JEXPNOTEJ AS JEXPNOTEJ_A"
                strSQL = strSQL & "      ,TPM010B.GOODSNMJ AS GOODSNMJ_B"
                strSQL = strSQL & "      ,TPM010B.GOODSNMJ2 AS GOODSNMJ2_B"
                strSQL = strSQL & "      ,TPM010B.JEXPNOTEJ AS JEXPNOTEJ_B"
                strSQL = strSQL & "      ,TPM010C.GOODSNMJ AS GOODSNMJ_C"
                strSQL = strSQL & "      ,TPM010C.GOODSNMJ2 AS GOODSNMJ2_C"
                strSQL = strSQL & "      ,TPM010C.JEXPNOTEJ AS JEXPNOTEJ_C"
            End If

            strSQL = strSQL & "      ,TPM260.TAXPRICE"
            strSQL = strSQL & "      ,TPM320.TAXKIND"

            ' ñ{ïîîzêMëŒâû
            If GF_GetAppInfo("DELIVARY_FLG") = "1" Or GF_GetAppInfo("DELIVARY_FLG") = "2" Or GF_GetAppInfo("DELIVARY_FLG") = "3" Then
                strSQL = strSQL & "      ,TPM340.COST"
            End If

            ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------
            If LF_ChkLaneFlg() = "1" Then
                strSQL = strSQL & "     , TPM440.DEPARTFLG"
            End If
            ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------

            '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura >>>
            strSQL = strSQL & "     , TPM600.MENUCD"
            strSQL = strSQL & "     , TPM600.INSTORECD"
            strSQL = strSQL & "     , TPM600.PRICE_RED"
            strSQL = strSQL & "     , TPM600.SUBPRICE"
            strSQL = strSQL & "     , TPM600.SUBPRICE_RED"
            strSQL = strSQL & "     , TPM600.PRICETYPE"
            strSQL = strSQL & "     , TPM600.TAXTYPE"
            strSQL = strSQL & "     , TPM600.TAXTYPE_RED"
            strSQL = strSQL & "     , TPM600.QADDITIONALFLG"
            strSQL = strSQL & "     , TPM600.DISCOUNTFLG"
            strSQL = strSQL & "     , TPM600.TAKEOUTTYPE"
            strSQL = strSQL & "     , TPM600.OESMENUFLG"
            '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura <<<

            strSQL = strSQL & "     , TPM012.UPPERTEXT"
            strSQL = strSQL & "     , TPM012.LOWERTEXT"

            '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
            If TICKETUSE = "1" Then
                strSQL = strSQL & "     , TPM013.TECKCPNM3"
            End If
            If HTLNMUSE = "0" Then
                strSQL = strSQL & "     , TPM013.HTLNM5"
            End If
            '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

            strSelGrp = GF_CboGetCode(cbo_SelGroup, cbo_SelGroup.SelectedIndex)
            Select Case strSelGrp
                Case LC_FLT_ALLITEM
                    strSQL = strSQL & "  FROM TPM010 LEFT JOIN TPM200"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM200.GOODSCD"
                    strSQL = strSQL & "              LEFT JOIN TPM210"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM210.GOODSCD"
                    strSQL = strSQL & "              LEFT JOIN TPM250"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM250.GOODSCD"
                    strSQL = strSQL & "              LEFT JOIN TPM260"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM260.GOODSCD"  'è¡îÔê≈ëŒâûÅ@2013.12.19
                    strSQL = strSQL & "              LEFT JOIN TPM320"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM320.GOODSCD"
                    strSQL = strSQL & "              LEFT JOIN TPM012"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM012.GOODSCD"

                    '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
                    If TICKETUSE = "1" Or HTLNMUSE = "0" Then
                        strSQL = strSQL & "              LEFT JOIN TPM013"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM013.GOODSCD"
                    End If
                    '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

                    'ëΩåæåÍã@î\ëŒâû
                    If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                        strSQL = strSQL & "              LEFT JOIN TPM010A"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM010A.GOODSCD"
                        strSQL = strSQL & "              LEFT JOIN TPM010B"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM010B.GOODSCD"
                        strSQL = strSQL & "              LEFT JOIN TPM010C"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM010C.GOODSCD"
                    End If

                    ' ñ{ïîîzêMëŒâû
                    If GF_GetAppInfo("DELIVARY_FLG") = "1" Or GF_GetAppInfo("DELIVARY_FLG") = "2" Or GF_GetAppInfo("DELIVARY_FLG") = "3" Then
                        strSQL = strSQL & "              LEFT JOIN TPM340"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM340.GOODSCD"
                    End If

                    ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------
                    If LF_ChkLaneFlg() = "1" Then
                        strSQL = strSQL & "              LEFT JOIN TPM440"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM440.GOODSCD"
                    End If
                    ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------

                    '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura >>>
                    strSQL = strSQL & "              LEFT JOIN TPM600"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM600.GOODSCD"
                    '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura <<<

                Case LC_FLT_NOGROUP
                    strSQL = strSQL & "  FROM TPM010 LEFT JOIN TPM200"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM200.GOODSCD"
                    strSQL = strSQL & "              LEFT JOIN TPM210"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM210.GOODSCD"
                    strSQL = strSQL & "              LEFT JOIN TPM250"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM250.GOODSCD"
                    strSQL = strSQL & "              LEFT JOIN TPM260"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM260.GOODSCD"  'è¡îÔê≈ëŒâûÅ@2013.12.19
                    strSQL = strSQL & "              LEFT JOIN TPM320"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM320.GOODSCD"
                    strSQL = strSQL & "              LEFT JOIN TPM012"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM012.GOODSCD"

                    '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
                    If TICKETUSE = "1" Or HTLNMUSE = "0" Then
                        strSQL = strSQL & "              LEFT JOIN TPM013"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM013.GOODSCD"
                    End If
                    '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

                    'ëΩåæåÍã@î\ëŒâû
                    If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                        strSQL = strSQL & "              LEFT JOIN TPM010A"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM010A.GOODSCD"
                        strSQL = strSQL & "              LEFT JOIN TPM010B"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM010B.GOODSCD"
                        strSQL = strSQL & "              LEFT JOIN TPM010C"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM010C.GOODSCD"
                    End If

                    If GF_GetAppInfo("DELIVARY_FLG") = "1" Or GF_GetAppInfo("DELIVARY_FLG") = "2" Or GF_GetAppInfo("DELIVARY_FLG") = "3" Then
                        strSQL = strSQL & "              LEFT JOIN TPM340"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM340.GOODSCD"
                    End If

                    ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------
                    If LF_ChkLaneFlg() = "1" Then
                        strSQL = strSQL & "              LEFT JOIN TPM440"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM440.GOODSCD"
                    End If
                    ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------

                    '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura >>>
                    strSQL = strSQL & "              LEFT JOIN TPM600"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM600.GOODSCD"
                    '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura <<<

                    strSQL = strSQL & " WHERE TPM010.GOODSCD NOT IN (SELECT TPM020.GOODSCD FROM TPM020 GROUP BY TPM020.GOODSCD)"

                Case Else
                    strSQL = strSQL & "  FROM TPM010 LEFT JOIN TPM200"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM200.GOODSCD"
                    strSQL = strSQL & "              LEFT JOIN TPM210"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM210.GOODSCD"
                    strSQL = strSQL & "              LEFT JOIN TPM250"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM250.GOODSCD"
                    strSQL = strSQL & "              LEFT JOIN TPM320"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM320.GOODSCD"
                    strSQL = strSQL & "              LEFT JOIN TPM012"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM012.GOODSCD"

                    '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
                    If TICKETUSE = "1" Or HTLNMUSE = "0" Then
                        strSQL = strSQL & "              LEFT JOIN TPM013"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM013.GOODSCD"
                    End If
                    '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

                    'ëΩåæåÍã@î\ëŒâû
                    If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                        strSQL = strSQL & "              LEFT JOIN TPM010A"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM010A.GOODSCD"
                        strSQL = strSQL & "              LEFT JOIN TPM010B"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM010B.GOODSCD"
                        strSQL = strSQL & "              LEFT JOIN TPM010C"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM010C.GOODSCD"
                    End If

                    If GF_GetAppInfo("DELIVARY_FLG") = "1" Or GF_GetAppInfo("DELIVARY_FLG") = "2" Or GF_GetAppInfo("DELIVARY_FLG") = "3" Then
                        strSQL = strSQL & "              LEFT JOIN TPM340"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM340.GOODSCD"
                    End If

                    ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------
                    If LF_ChkLaneFlg() = "1" Then
                        strSQL = strSQL & "              LEFT JOIN TPM440"
                        strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM440.GOODSCD"
                    End If
                    ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------

                    '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura >>>
                    strSQL = strSQL & "              LEFT JOIN TPM600"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM600.GOODSCD"
                    '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura <<<

                    strSQL = strSQL & "              LEFT JOIN TPM260"
                    strSQL = strSQL & "                     ON TPM010.GOODSCD = TPM260.GOODSCD,"  'è¡îÔê≈ëŒâûÅ@2013.12.19
                    strSQL = strSQL & "       TPM020"
                    strSQL = strSQL & " WHERE TPM010.GOODSCD = TPM020.GOODSCD"
                    strSQL = strSQL & "   AND TPM020.GROUPCD = '" & strSelGrp & "'"
            End Select

            If Len(Trim$(txt_Search.Text)) <> 0 Then
                If InStr(strSQL, "WHERE") = 0 Then
                    strSQL = strSQL & " WHERE "
                Else
                    strSQL = strSQL & "   AND "
                End If
                strSQL = strSQL & "TPM010.GOODSNMJ LIKE '%" & Trim$(txt_Search.Text) & "%'"
            End If

            Select Case strSelGrp
                Case LC_FLT_ALLITEM
                    strSQL = strSQL & " ORDER BY TPM010.GOODSCD ASC"
                Case LC_FLT_NOGROUP
                    strSQL = strSQL & " ORDER BY TPM010.GOODSCD ASC"
                Case Else
                    strSQL = strSQL & " ORDER BY TPM010.GOODSCD ASC"
            End Select

            'Select Case GF_CboGetCode(cbo_SelSort, cbo_SelSort.SelectedIndex)
            '    Case LC_SORT_ALLITEM_CODE
            '        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"
            '    Case LC_SORT_ALLITEM_ITEM
            '        strSQL = strSQL & " ORDER BY TPM010.GOODSNMJ, TPM010.GOODSCD"
            '    Case LC_SORT_ALLITEM_PRICE
            '        strSQL = strSQL & " ORDER BY TPM010.PRICE, TPM010.GOODSCD"
            '    Case LC_SORT_NOIMAGE
            '        If InStr(strSQL, "WHERE") = 0 Then
            '            strSQL = strSQL & " WHERE "
            '        Else
            '            strSQL = strSQL & " AND "
            '        End If
            '        strSQL = strSQL & "LEN(LTRIM(TPM010.IMAGEDATA)) = 0"
            '    Case LC_SORT_NOINFO
            '        If InStr(strSQL, "WHERE") = 0 Then
            '            strSQL = strSQL & " WHERE "
            '        Else
            '            strSQL = strSQL & " AND "
            '        End If
            '        strSQL = strSQL & "LEN(LTRIM(TPM010.JEXPNOTEJ)) = 0"
            '    Case LC_SORT_NOUNIT
            '        If InStr(strSQL, "WHERE") = 0 Then
            '            strSQL = strSQL & " WHERE "
            '        Else
            '            strSQL = strSQL & " AND "
            '        End If
            '        strSQL = strSQL & "LEN(LTRIM(TPM010.UNITJ)) = 0"
            '    Case Else
            '        Exit Function
            'End Select
        Catch
            Exit Function
        End Try

        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' ï‘ãpílê›íË
        '------------------------------
        LF_GetTPM010 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFìoò^çœÇ›è§ïiàÍóóÉOÉäÉbÉhêßå‰ÅiçsëIëèÛë‘êßå‰Åj
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub grd_ItemList_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_ItemList.CurrentCellChanged

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim lngCnt As Long

        '------------------------------
        ' çsëIëèÛë‘êßå‰
        '------------------------------
        Try
            With grd_ItemList
                If GF_GetRowCnt(grd_ItemList) < 0 Then Exit Sub

                For lngCnt = 0 To GF_GetRowCnt(grd_ItemList) - 1
                    .UnSelect(lngCnt)
                Next

                If Len(Trim$(txt_SelRow.Text)) <> 0 Then
                    If .CurrentCell.RowNumber <> CLng(txt_SelRow.Text) Then
                        ' L_CRow ÅÅ ëOÇ…ëIëÇ≥ÇÍÇƒÇ¢ÇΩçsî‘çÜ
                        'If grd_ItemList(CInt(txt_SelRow.Text), 0) <> grd_ItemList(CInt(txt_SelRow.Text), 15) Then
                        '    lngCnt = .CurrentCell.RowNumber

                        '    .CurrentCell = New DataGridCell(CInt(txt_SelRow.Text), 0)
                        '    CType(BindingContext(grd_ItemList.DataSource), CurrencyManager).Position = CInt(txt_SelRow.Text)

                        '    grd_ItemList(CInt(txt_SelRow.Text), 14) = GC_TRUE
                        '    L_blnEditFlg = True
                        '    btn_Save.BackColor = Color.Yellow
                        '    Call LS_ShowCurrentItem(lngCnt)                 ' ëIëçsÇÃì‡óeÇÅAì¸óÕóÃàÊÇ÷ì]ãLÇ∑ÇÈ
                        '    .CurrentCell = New DataGridCell(lngCnt, 0)
                        '    .Select(lngCnt)
                        'Else
                        Call LS_ShowCurrentItem(.CurrentCell.RowNumber) ' ëIëçsÇÃì‡óeÇÅAì¸óÕóÃàÊÇ÷ì]ãLÇ∑ÇÈ
                        .CurrentCell = New DataGridCell(.CurrentCell.RowNumber, 0)
                        .Select(.CurrentCell.RowNumber)
                        'End If
                    Else
                        Call LS_ShowCurrentItem(.CurrentCell.RowNumber)     ' ëIëçsÇÃì‡óeÇÅAì¸óÕóÃàÊÇ÷ì]ãLÇ∑ÇÈ
                        .CurrentCell = New DataGridCell(.CurrentCell.RowNumber, 0)
                        .Select(.CurrentCell.RowNumber)
                    End If
                Else
                    Call LS_ShowCurrentItem(.CurrentCell.RowNumber)         ' ëIëçsÇÃì‡óeÇÅAì¸óÕóÃàÊÇ÷ì]ãLÇ∑ÇÈ
                    .CurrentCell = New DataGridCell(.CurrentCell.RowNumber, 0)
                    .Select(.CurrentCell.RowNumber)
                End If

            End With
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("grd_ItemList_CurrentCellChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïiâÊëúàÍóóÉOÉäÉbÉhêßå‰ÅiçsëIëèÛë‘êßå‰Åj
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub grd_PicList_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_PicList.CurrentCellChanged

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim objCell As DataGridCell
        Dim lngCnt As Long

        '------------------------------
        ' çsëIëèÛë‘êßå‰
        '------------------------------
        Try
            With grd_PicList
                If GF_GetRowCnt(grd_PicList) < 0 Then Exit Sub
                For lngCnt = 0 To GF_GetRowCnt(grd_PicList) - 1
                    .UnSelect(lngCnt)
                Next

                objCell = New DataGridCell(.CurrentCell.RowNumber, 0)
                .CurrentCell = objCell
                .Select(.CurrentCell.RowNumber)
            End With
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("grd_PicList_CurrentCellChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFìoò^çœÇ›è§ïiàÍóóÉOÉäÉbÉhì‡óe ì]ãLèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub LS_ShowCurrentItem(ByVal pRow As Integer)

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim strWork() As String = Nothing
        Dim strOption As String = Nothing
        Dim lngCnt As Long
        Dim strKPStat As String = Nothing
        Dim lngKPCnt As Long
        ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„
        Dim i As Integer
        Dim strPtn As String
        ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„

        ' 2017.11.01 ñ{ïîîzêM ÉNÉåÉXÉRñkó§ ìcë„
        Dim strGoodsCD As String = ""
        Dim strEnabled As String = ""
        ' 2017.11.01 ñ{ïîîzêM ÉNÉåÉXÉRñkó§ ìcë„

        Try

            txt_Price.Text = Format$(CLng(grd_ItemList(pRow, 4)), "#,##0")

            'è¡îÔê≈ëŒâûÅ@2013.12.19
            tax_Price.Text = Format$(CLng(grd_ItemList(pRow, 27)), "#,##0")

            lbl_KCP1.Text = ""
            lbl_KCP2.Text = ""
            lbl_KCP3.Text = ""
            lbl_KCP4.Text = ""          'KCPèoóÕêÊ4â”èäëŒâû
            strKPStat = LF_GetKCPStat(grd_ItemList(pRow, 11))
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
                        Case 3
                            lbl_KCP4.Text = strWork(lngKPCnt)       'KCPèoóÕêÊ4â”èäëŒâû
                        Case Is >= 4
                            Exit For
                    End Select
                Next
            Else
                lbl_KCP1.Text = ""
                lbl_KCP2.Text = ""
                lbl_KCP3.Text = ""
                lbl_KCP4.Text = ""          'KCPèoóÕêÊ4â”èäëŒâû
            End If

            txt_TPGoodsNM.Text = grd_ItemList(pRow, 9)
            txt_TPGoodsNM2.Text = grd_ItemList(pRow, 10)
            txt_ExpNoteJ.Text = grd_ItemList(pRow, 5)

            'ëΩåæåÍã@î\ëŒâû
            If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                txt_TPGoodsNM_A.Text = grd_ItemList(pRow, 28)
                txt_TPGoodsNM2_A.Text = grd_ItemList(pRow, 29)
                txt_EXPNOTEJ_A.Text = grd_ItemList(pRow, 30)
                txt_TPGoodsNM_B.Text = grd_ItemList(pRow, 31)
                txt_TPGoodsNM2_B.Text = grd_ItemList(pRow, 32)
                txt_EXPNOTEJ_B.Text = grd_ItemList(pRow, 33)
                txt_TPGoodsNM_C.Text = grd_ItemList(pRow, 34)
                txt_TPGoodsNM2_C.Text = grd_ItemList(pRow, 35)
                txt_EXPNOTEJ_C.Text = grd_ItemList(pRow, 36)
            End If

            strWork = Split(grd_ItemList(pRow, 16), ",")
            If strWork.GetUpperBound(0) <> 11 Then
                GoTo SYSTEM_ERROR
            End If

            lngCnt = 0
            For Each strOption In strWork
                If lngCnt < 12 Then
                    '--- ÉIÉvÉVÉáÉìÅiã‡äzñ≥Åj --------
                    Select Case lngCnt
                        Case 0
                            Call GS_CboChgSel(cbo_OP1, strOption)
                        Case 1
                            Call GS_CboChgSel(cbo_OP2, strOption)
                        Case 2
                            Call GS_CboChgSel(cbo_OP3, strOption)
                        Case 3
                            Call GS_CboChgSel(cbo_OP4, strOption)
                        Case 4
                            Call GS_CboChgSel(cbo_OP5, strOption)
                        Case 5
                            Call GS_CboChgSel(cbo_OP6, strOption)
                        Case 6
                            Call GS_CboChgSel(cbo_OP7, strOption)
                        Case 7
                            Call GS_CboChgSel(cbo_OP8, strOption)
                        Case 8
                            Call GS_CboChgSel(cbo_OP9, strOption)
                        Case 9
                            Call GS_CboChgSel(cbo_OP10, strOption)
                        Case 10
                            Call GS_CboChgSel(cbo_OP11, strOption)
                        Case 11
                            Call GS_CboChgSel(cbo_OP12, strOption)
                        Case Else
                    End Select
                Else
                    Exit For
                End If
                lngCnt = lngCnt + 1
            Next

            'Select Case lngCnt
            '    Case 0
            '        Call GS_CboChgSel(cbo_OP1, "000")
            '        Call GS_CboChgSel(cbo_OP2, "000")
            '        Call GS_CboChgSel(cbo_OP3, "000")
            '        Call GS_CboChgSel(cbo_OP4, "000")
            '    Case 1
            '        Call GS_CboChgSel(cbo_OP2, "000")
            '        Call GS_CboChgSel(cbo_OP3, "000")
            '        Call GS_CboChgSel(cbo_OP4, "000")
            '    Case 2
            '        Call GS_CboChgSel(cbo_OP3, "000")
            '        Call GS_CboChgSel(cbo_OP4, "000")
            '    Case 3
            '        Call GS_CboChgSel(cbo_OP4, "000")
            'End Select

            txt_HTLNM1.Text = grd_ItemList(pRow, 17)
            txt_HTLNM2.Text = grd_ItemList(pRow, 18)
            txt_GoodsNMJ4.Text = grd_ItemList(pRow, 19)

            ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„
            'chk_Special.Checked = grd_ItemList(pRow, 20)
            'chk_New.Checked = grd_ItemList(pRow, 21)

            cmbPTN1.Text = cmbPTN1.Items.Item(SetPtnKbn(grd_ItemList(pRow, 20).ToString)).ToString
            cmbPTN2.Text = cmbPTN2.Items.Item(SetPtnKbn(grd_ItemList(pRow, 21).ToString)).ToString
            ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„

            Call GS_CboChgSel(cmb_Bumon, grd_ItemList(pRow, 22))
            txt_searchNumber.Text = grd_ItemList(pRow, 23)
            chk_game.Checked = grd_ItemList(pRow, 24)
            ccp_check.Checked = grd_ItemList(pRow, 26)
            chk_Status0.Checked = IIf(grd_ItemList(pRow, 25) = "0", GC_FALSE, GC_TRUE)
            chk_Status1.Checked = IIf(grd_ItemList(pRow, 25) = "1", GC_FALSE, GC_TRUE)
            chk_Status2.Checked = IIf(grd_ItemList(pRow, 25) = "2", GC_FALSE, GC_TRUE)
            chk_Status3.Checked = IIf(grd_ItemList(pRow, 25) = "3", GC_FALSE, GC_TRUE)

            chk_TaxKind0.Checked = IIf(grd_ItemList(pRow, 37) = "0", GC_FALSE, GC_TRUE)
            chk_TaxKind1.Checked = IIf(grd_ItemList(pRow, 37) = "1", GC_FALSE, GC_TRUE)

            ' 2017.11.01 ñ{ïîîzêM ÉNÉåÉXÉRñkó§ ìcë„
            If GF_GetAppInfo("DELIVARY_FLG") = "1" Or GF_GetAppInfo("DELIVARY_FLG") = "2" Or GF_GetAppInfo("DELIVARY_FLG") = "3" Then
                txtUnitPrice.Text = grd_ItemList(pRow, 38)
            End If

            If GF_GetAppInfo3("SV_GOODS_CHECK_FLG") = "1" Then

                strGoodsCD = grd_ItemList(pRow, 1)

                ' ï“èWÉtÉâÉOÇ™OFFÇæÇ¡ÇΩèÍçá
                If LS_GoodsEnabled(strGoodsCD) Then
                    ' è§ïièÓïÒï“èWïsâ¬èàóù
                    If Not LS_GoodsInfoONOFF(False) Then
                        GoTo SYSTEM_ERROR
                    End If
                Else
                    ' è§ïièÓïÒï“èWãñâ¬èàóù
                    If Not LS_GoodsInfoONOFF(True) Then
                        GoTo SYSTEM_ERROR
                    End If
                End If

            End If
            ' 2017.11.01 ñ{ïîîzêM ÉNÉåÉXÉRñkó§ ìcë„

            ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------
            If LF_ChkLaneFlg() = "1" Then
                chk_Lane.Checked = grd_ItemList(pRow, 39)
            End If
            ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------

            '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura >>>
            lbl_GoodsCode.Text = grd_ItemList(pRow, 1)
            lbl_MenuCode.Text = grd_ItemList(pRow, 40)
            txt_MenuCode.Text = grd_ItemList(pRow, 40)
            txt_OwnCompanyCode.Text = grd_ItemList(pRow, 41)

            If grd_ItemList(pRow, 1).Equals(Long.Parse(txt_MenuCode.Text).ToString) Then
                chk_MenuCdEdit.Checked = False
                txt_MenuCode.Enabled = False
            Else
                chk_MenuCdEdit.Checked = True
                txt_MenuCode.Enabled = True
            End If

            If Trim$(GF_GetAppInfo("SALES_TAX_SWITCHING")) = 0 Then
                'ê≈çûï\ãLéûÇÕê≈çûÇ›âøäiÇï\é¶
                lbl_Price.Text = Format$(CLng(grd_ItemList(pRow, 27)), "#,##0")
            Else
                'ê≈ï ï\ãLéûÇÕê≈ï âøäiÇï\é¶
                lbl_Price.Text = Format$(CLng(grd_ItemList(pRow, 4)), "#,##0")
            End If
            txt_Price_Reduce.Text = Format$(CLng(grd_ItemList(pRow, 42)), "#,##0")
            lbl_Orig_Price_Reduce.Text = grd_ItemList(pRow, 42)
            txt_SubPrice.Text = Format$(CLng(grd_ItemList(pRow, 43)), "#,##0")
            lbl_Orig_SubPrice.Text = grd_ItemList(pRow, 43)
            txt_SubPrice_Reduce.Text = Format$(CLng(grd_ItemList(pRow, 44)), "#,##0")
            lbl_Orig_SubPrice_Reduce.Text = grd_ItemList(pRow, 44)

            rbt_Ptype_Preset.Checked = IIf(grd_ItemList(pRow, 45) = 0, True, False)
            rbt_Ptype_Open.Checked = IIf(grd_ItemList(pRow, 45) = 1, True, False)

            cmb_TaxType.SelectedValue = grd_ItemList(pRow, 46)
            cmb_TaxType_Reduced.SelectedValue = grd_ItemList(pRow, 47)

            rbt_Qadd_Disabled.Checked = IIf(grd_ItemList(pRow, 48) = 0, True, False)
            rbt_Qadd_Enabled.Checked = IIf(grd_ItemList(pRow, 48) = 1, True, False)

            rbt_Discount_Discount.Checked = IIf(grd_ItemList(pRow, 49) = 0, True, False)
            rbt_Discount_Extra.Checked = IIf(grd_ItemList(pRow, 49) = 1, True, False)

            rbt_Takeout_Eatin.Checked = IIf(grd_ItemList(pRow, 50) = 0, True, False)
            rbt_Takeout_Both.Checked = IIf(grd_ItemList(pRow, 50) = 1, True, False)
            rbt_Takeout_Takeout.Checked = IIf(grd_ItemList(pRow, 50) = 2, True, False)

            rbt_OES_Enabled.Checked = IIf(grd_ItemList(pRow, 51) = 0, True, False)
            rbt_OES_Disabled.Checked = IIf(grd_ItemList(pRow, 51) = 1, True, False)
            '2019.08.08 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura <<<
            UpperBox.Text = grd_ItemList(pRow, 52).ToString()
            LowerBox.Text = grd_ItemList(pRow, 53).ToString()

            '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
            txt_TECKCPNM3.Text = grd_ItemList(pRow, 54).ToString()
            txt_HTLNM5.Text = grd_ItemList(pRow, 55).ToString()
            '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

            txt_SelRow.Text = pRow

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_ShowCurrentItem")
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïiâÊëúàÍóóÉOÉäÉbÉhêßå‰ÅiÉhÉâÉbÉOäJénêßå‰Åj
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub grd_PicList_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grd_PicList.MouseDown

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim objCell As DataGridCell
        Dim objPoint As Point = grd_PicList.PointToClient(Cursor.Position)
        Dim objHitTest As System.Windows.Forms.DataGrid.HitTestInfo

        If GF_GetRowCnt(grd_PicList) = 0 Then Exit Sub

        If e.Clicks = 2 Then
            Call LS_ShowSampleImage(grd_PicList(grd_PicList.CurrentCell.RowNumber, 0))
            Exit Sub
        End If

        With grd_PicList
            ' ç¿ïWà íuÇ©ÇÁÅAÉJÉåÉìÉgçsÇïœçXÇ∑ÇÈ
            objHitTest = .HitTest(objPoint)
            If objHitTest.Row <> -1 Then
                objCell = New DataGridCell(objHitTest.Row, 0)
                .CurrentCell = objCell
            End If

            ' ÉhÉâÉbÉOèàóùäJén
            L_blnDDMode = False
            DoDragDrop(CStr(grd_PicList(objCell.RowNumber, 0)), DragDropEffects.Copy)

        End With

    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïiâÊëúàÍóóÉOÉäÉbÉhêßå‰ÅiÉhÉâÉbÉOëÄçÏíÜêßå‰Åj
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub grd_PicList_DragOver(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grd_PicList.DragOver
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ìoò^çœÇ›è§ïiàÍóóÉOÉäÉbÉhêßå‰ÅiÉhÉâÉbÉOëÄçÏíÜêßå‰Åj
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub grd_ItemList_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grd_ItemList.DragOver

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim objCell As DataGridCell
        Dim objPoint As Point = grd_ItemList.PointToClient(Cursor.Position)
        Dim objHitTest As System.Windows.Forms.DataGrid.HitTestInfo

        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            With grd_ItemList
                ' ç¿ïWà íuÇ©ÇÁÅAÉJÉåÉìÉgçsÇïœçXÇ∑ÇÈ
                objHitTest = .HitTest(objPoint)
                If objHitTest.Row <> -1 Then
                    objCell = New DataGridCell(objHitTest.Row, 7)
                    .CurrentCell = objCell
                End If
            End With

            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub grd_ItemList_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grd_ItemList.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ìoò^çœÇ›è§ïiàÍóóÉOÉäÉbÉhêßå‰ÅiÉhÉâÉbÉOëÄçÏíÜêßå‰Åj
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub grd_ItemList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grd_ItemList.DragDrop

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim objCell As DataGridCell = grd_ItemList.CurrentCell
        Dim objPoint As Point = grd_ItemList.PointToClient(Cursor.Position)

        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            If Len(Trim$(grd_ItemList(objCell.RowNumber, 2))) <> 0 Then
                If GF_Msg("Q11", "", MsgBoxStyle.Question, MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            grd_ItemList(objCell.RowNumber, 2) = CStr(e.Data.GetData(DataFormats.Text))
            grd_ItemList(objCell.RowNumber, 14) = GC_TRUE
            L_blnEditFlg = True
            btn_Save.BackColor = Color.Yellow
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïièÓïÒì¸óÕì‡óeèëÇ´ñﬂÇµèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    'Private Sub LS_WriteRetItemInfo()
    Private Sub LS_WriteRetItemInfo(Optional ByVal pKCPStat As String = "", Optional ByVal SetEdited As Boolean = True)

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim objCell As DataGridCell = grd_ItemList.CurrentCell
        Dim strOpt(11) As String
        Dim strWork As String = Nothing
        Dim strOptions As String = Nothing
        Dim lngOP1 As Long
        Dim lngOP2 As Long
        Dim strKCP() As String = Nothing
        Dim strOTKCP(2) As String

        If objCell.RowNumber = -1 Then Exit Sub
        If Len(Trim$(txt_SelRow.Text)) = 0 Or Not IsNumeric(txt_SelRow.Text) Then Exit Sub

        Try
            grd_ItemList(CInt(txt_SelRow.Text), 9) = txt_TPGoodsNM.Text
            grd_ItemList(CInt(txt_SelRow.Text), 10) = txt_TPGoodsNM2.Text
            grd_ItemList(CInt(txt_SelRow.Text), 5) = txt_ExpNoteJ.Text

            'ëΩåæåÍã@î\ëŒâû
            If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                grd_ItemList(CInt(txt_SelRow.Text), 28) = txt_TPGoodsNM_A.Text
                grd_ItemList(CInt(txt_SelRow.Text), 29) = txt_TPGoodsNM2_A.Text
                grd_ItemList(CInt(txt_SelRow.Text), 30) = txt_EXPNOTEJ_A.Text
                grd_ItemList(CInt(txt_SelRow.Text), 31) = txt_TPGoodsNM_B.Text
                grd_ItemList(CInt(txt_SelRow.Text), 32) = txt_TPGoodsNM2_B.Text
                grd_ItemList(CInt(txt_SelRow.Text), 33) = txt_EXPNOTEJ_B.Text
                grd_ItemList(CInt(txt_SelRow.Text), 34) = txt_TPGoodsNM_C.Text
                grd_ItemList(CInt(txt_SelRow.Text), 35) = txt_TPGoodsNM2_C.Text
                grd_ItemList(CInt(txt_SelRow.Text), 36) = txt_EXPNOTEJ_C.Text
            End If

            If L_PriceEdit = GC_TRUE Then
                grd_ItemList(CInt(txt_SelRow.Text), 4) = Format$(CLng(Replace(txt_Price.Text, ",", "")), "#####0")
            End If
            'è¡îÔê≈ëŒâûÅ@2013.12.19
            If L_Tax_PriceEdit = GC_TRUE Then
                grd_ItemList(CInt(txt_SelRow.Text), 27) = Format$(CLng(Replace(tax_Price.Text, ",", "")), "#####0")
            End If

            grd_ItemList(CInt(txt_SelRow.Text), 14) = GC_TRUE

            '------------------------------
            ' KCPÉXÉeÅ[É^ÉXîΩâf
            '------------------------------
            If Len(Trim$(pKCPStat)) <> 0 Then
                grd_ItemList(CInt(txt_SelRow.Text), 11) = pKCPStat
            End If

            grd_ItemList(CInt(txt_SelRow.Text), 3) = LF_ItemColEdit(txt_TPGoodsNM.Text, _
                                                                    txt_TPGoodsNM2.Text)

            '------------------------------
            ' ÉIÉvÉVÉáÉìê›íËíléÊìæ
            '------------------------------
            strWork = Format$(CLng(GF_CboGetCode(cbo_OP1, cbo_OP1.SelectedIndex)), "000")
            strOptions = strWork
            strWork = Format$(CLng(GF_CboGetCode(cbo_OP2, cbo_OP2.SelectedIndex)), "000")
            strOptions = strOptions & "," & strWork
            strWork = Format$(CLng(GF_CboGetCode(cbo_OP3, cbo_OP3.SelectedIndex)), "000")
            strOptions = strOptions & "," & strWork
            strWork = Format$(CLng(GF_CboGetCode(cbo_OP4, cbo_OP4.SelectedIndex)), "000")
            strOptions = strOptions & "," & strWork
            strWork = Format$(CLng(GF_CboGetCode(cbo_OP5, cbo_OP5.SelectedIndex)), "000")
            strOptions = strOptions & "," & strWork
            strWork = Format$(CLng(GF_CboGetCode(cbo_OP6, cbo_OP6.SelectedIndex)), "000")
            strOptions = strOptions & "," & strWork
            strWork = Format$(CLng(GF_CboGetCode(cbo_OP7, cbo_OP7.SelectedIndex)), "000")
            strOptions = strOptions & "," & strWork
            strWork = Format$(CLng(GF_CboGetCode(cbo_OP8, cbo_OP8.SelectedIndex)), "000")
            strOptions = strOptions & "," & strWork
            strWork = Format$(CLng(GF_CboGetCode(cbo_OP9, cbo_OP9.SelectedIndex)), "000")
            strOptions = strOptions & "," & strWork
            strWork = Format$(CLng(GF_CboGetCode(cbo_OP10, cbo_OP10.SelectedIndex)), "000")
            strOptions = strOptions & "," & strWork
            strWork = Format$(CLng(GF_CboGetCode(cbo_OP11, cbo_OP11.SelectedIndex)), "000")
            strOptions = strOptions & "," & strWork
            strWork = Format$(CLng(GF_CboGetCode(cbo_OP12, cbo_OP12.SelectedIndex)), "000")
            strOptions = strOptions & "," & strWork


            ''------------------------------
            '' îzóÒèâä˙âª
            ''------------------------------
            'For lngOP1 = 0 To 11
            '    strOpt(lngOP1) = "000"
            'Next

            'lngOP1 = 0
            'lngOP2 = 4
            'strWork = GF_CboGetCode(cbo_OP1, cbo_OP1.SelectedIndex)
            'If strWork <> "000" Then                                        ' ñ¢ê›íËà»äO
            '    If CLng(strWork) <= 50 Then                                 ' ÉRÉÅÉìÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP1) = Format$(CLng(strWork), "000")
            '        lngOP1 = lngOP1 + 1
            '    Else                                                        ' ÉTÉuÅ^ÉZÉbÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP2) = Format$(CLng(strWork), "000")
            '        lngOP2 = lngOP2 + 1
            '    End If
            'End If
            'strWork = GF_CboGetCode(cbo_OP2, cbo_OP2.SelectedIndex)
            'If strWork <> "000" Then                                        ' ñ¢ê›íËà»äO
            '    If CLng(strWork) <= 50 Then                                 ' ÉRÉÅÉìÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP1) = Format$(CLng(strWork), "000")
            '        lngOP1 = lngOP1 + 1
            '    Else                                                        ' ÉTÉuÅ^ÉZÉbÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP2) = Format$(CLng(strWork), "000")
            '        lngOP2 = lngOP2 + 1
            '    End If
            'End If
            'strWork = GF_CboGetCode(cbo_OP3, cbo_OP3.SelectedIndex)
            'If strWork <> "000" Then                                        ' ñ¢ê›íËà»äO
            '    If CLng(strWork) <= 50 Then                                 ' ÉRÉÅÉìÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP1) = Format$(CLng(strWork), "000")
            '        lngOP1 = lngOP1 + 1
            '    Else                                                        ' ÉTÉuÅ^ÉZÉbÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP2) = Format$(CLng(strWork), "000")
            '        lngOP2 = lngOP2 + 1
            '    End If
            'End If
            'strWork = GF_CboGetCode(cbo_OP4, cbo_OP4.SelectedIndex)
            'If strWork <> "000" Then                                        ' ñ¢ê›íËà»äO
            '    If CLng(strWork) <= 50 Then                                 ' ÉRÉÅÉìÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP1) = Format$(CLng(strWork), "000")
            '        lngOP1 = lngOP1 + 1
            '    Else                                                        ' ÉTÉuÅ^ÉZÉbÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP2) = Format$(CLng(strWork), "000")
            '        lngOP2 = lngOP2 + 1
            '    End If
            'End If
            'strWork = GF_CboGetCode(cbo_OP5, cbo_OP5.SelectedIndex)
            'If strWork <> "000" And strWork <> "" Then                                        ' ñ¢ê›íËà»äO
            '    If CLng(strWork) <= 50 Then                                 ' ÉRÉÅÉìÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP1) = Format$(CLng(strWork), "000")
            '        lngOP1 = lngOP1 + 1
            '    Else                                                        ' ÉTÉuÅ^ÉZÉbÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP2) = Format$(CLng(strWork), "000")
            '        lngOP2 = lngOP2 + 1
            '    End If
            'End If
            'strWork = GF_CboGetCode(cbo_OP6, cbo_OP6.SelectedIndex)
            'If strWork <> "000" And strWork <> "" Then                                        ' ñ¢ê›íËà»äO
            '    If CLng(strWork) <= 50 Then                                 ' ÉRÉÅÉìÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP1) = Format$(CLng(strWork), "000")
            '        lngOP1 = lngOP1 + 1
            '    Else                                                        ' ÉTÉuÅ^ÉZÉbÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP2) = Format$(CLng(strWork), "000")
            '        lngOP2 = lngOP2 + 1
            '    End If
            'End If
            'strWork = GF_CboGetCode(cbo_OP7, cbo_OP7.SelectedIndex)
            'If strWork <> "000" And strWork <> "" Then                                        ' ñ¢ê›íËà»äO
            '    If CLng(strWork) <= 50 Then                                 ' ÉRÉÅÉìÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP1) = Format$(CLng(strWork), "000")
            '        lngOP1 = lngOP1 + 1
            '    Else                                                        ' ÉTÉuÅ^ÉZÉbÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP2) = Format$(CLng(strWork), "000")
            '        lngOP2 = lngOP2 + 1
            '    End If
            'End If
            'strWork = GF_CboGetCode(cbo_OP8, cbo_OP8.SelectedIndex)
            'If strWork <> "000" And strWork <> "" Then                                        ' ñ¢ê›íËà»äO
            '    If CLng(strWork) <= 50 Then                                 ' ÉRÉÅÉìÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP1) = Format$(CLng(strWork), "000")
            '        lngOP1 = lngOP1 + 1
            '    Else                                                        ' ÉTÉuÅ^ÉZÉbÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP2) = Format$(CLng(strWork), "000")
            '        lngOP2 = lngOP2 + 1
            '    End If
            'End If
            'strWork = GF_CboGetCode(cbo_OP9, cbo_OP9.SelectedIndex)
            'If strWork <> "000" And strWork <> "" Then                                        ' ñ¢ê›íËà»äO
            '    If CLng(strWork) <= 50 Then                                 ' ÉRÉÅÉìÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP1) = Format$(CLng(strWork), "000")
            '        lngOP1 = lngOP1 + 1
            '    Else                                                        ' ÉTÉuÅ^ÉZÉbÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP2) = Format$(CLng(strWork), "000")
            '        lngOP2 = lngOP2 + 1
            '    End If
            'End If
            'strWork = GF_CboGetCode(cbo_OP10, cbo_OP10.SelectedIndex)
            'If strWork <> "000" And strWork <> "" Then                                        ' ñ¢ê›íËà»äO
            '    If CLng(strWork) <= 50 Then                                 ' ÉRÉÅÉìÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP1) = Format$(CLng(strWork), "000")
            '        lngOP1 = lngOP1 + 1
            '    Else                                                        ' ÉTÉuÅ^ÉZÉbÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP2) = Format$(CLng(strWork), "000")
            '        lngOP2 = lngOP2 + 1
            '    End If
            'End If
            'strWork = GF_CboGetCode(cbo_OP11, cbo_OP11.SelectedIndex)
            'If strWork <> "000" And strWork <> "" Then                                        ' ñ¢ê›íËà»äO
            '    If CLng(strWork) <= 50 Then                                 ' ÉRÉÅÉìÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP1) = Format$(CLng(strWork), "000")
            '        lngOP1 = lngOP1 + 1
            '    Else                                                        ' ÉTÉuÅ^ÉZÉbÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP2) = Format$(CLng(strWork), "000")
            '        lngOP2 = lngOP2 + 1
            '    End If
            'End If
            'strWork = GF_CboGetCode(cbo_OP12, cbo_OP12.SelectedIndex)
            'If strWork <> "000" And strWork <> "" Then                                        ' ñ¢ê›íËà»äO
            '    If CLng(strWork) <= 50 Then                                 ' ÉRÉÅÉìÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP1) = Format$(CLng(strWork), "000")
            '        lngOP1 = lngOP1 + 1
            '    Else                                                        ' ÉTÉuÅ^ÉZÉbÉgÉIÉvÉVÉáÉì
            '        strOpt(lngOP2) = Format$(CLng(strWork), "000")
            '        lngOP2 = lngOP2 + 1
            '    End If
            'End If

            'strWork = ""
            'For lngOP1 = 0 To 11
            '    If lngOP1 <> 0 Then
            '        strWork = strWork & ","
            '    End If
            '    strWork = strWork & strOpt(lngOP1)
            'Next

            grd_ItemList(CInt(txt_SelRow.Text), 16) = strOptions
            grd_ItemList(CInt(txt_SelRow.Text), 17) = txt_HTLNM1.Text
            grd_ItemList(CInt(txt_SelRow.Text), 18) = txt_HTLNM2.Text
            grd_ItemList(CInt(txt_SelRow.Text), 19) = txt_GoodsNMJ4.Text

            ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„
            'grd_ItemList(CInt(txt_SelRow.Text), 20) = chk_Special.Checked
            'grd_ItemList(CInt(txt_SelRow.Text), 21) = chk_New.Checked

            grd_ItemList(CInt(txt_SelRow.Text), 20) = PtnKbn(cmbPTN1.Text)
            grd_ItemList(CInt(txt_SelRow.Text), 21) = PtnKbn(cmbPTN2.Text)
            ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„

            grd_ItemList(CInt(txt_SelRow.Text), 22) = GF_CboGetCode(cmb_Bumon, cmb_Bumon.SelectedIndex)
            grd_ItemList(CInt(txt_SelRow.Text), 23) = txt_searchNumber.Text
            grd_ItemList(CInt(txt_SelRow.Text), 24) = chk_game.Checked
            grd_ItemList(CInt(txt_SelRow.Text), 26) = ccp_check.Checked
            'ëΩåæåÍã@î\ëŒâû
            If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                grd_ItemList(CInt(txt_SelRow.Text), 28) = txt_TPGoodsNM_A.Text
                grd_ItemList(CInt(txt_SelRow.Text), 29) = txt_TPGoodsNM2_A.Text
                grd_ItemList(CInt(txt_SelRow.Text), 30) = txt_EXPNOTEJ_A.Text
                grd_ItemList(CInt(txt_SelRow.Text), 31) = txt_TPGoodsNM_B.Text
                grd_ItemList(CInt(txt_SelRow.Text), 32) = txt_TPGoodsNM2_B.Text
                grd_ItemList(CInt(txt_SelRow.Text), 33) = txt_EXPNOTEJ_B.Text
                grd_ItemList(CInt(txt_SelRow.Text), 34) = txt_TPGoodsNM_C.Text
                grd_ItemList(CInt(txt_SelRow.Text), 35) = txt_TPGoodsNM2_C.Text
                grd_ItemList(CInt(txt_SelRow.Text), 36) = txt_EXPNOTEJ_C.Text
            End If

            If chk_Status0.Checked Then
                grd_ItemList(CInt(txt_SelRow.Text), 25) = "0"
            ElseIf chk_Status1.Checked Then
                grd_ItemList(CInt(txt_SelRow.Text), 25) = "1"
            ElseIf chk_Status2.Checked Then
                grd_ItemList(CInt(txt_SelRow.Text), 25) = "2"
            Else
                grd_ItemList(CInt(txt_SelRow.Text), 25) = "3"
            End If

            If chk_TaxKind0.Checked Then
                grd_ItemList(CInt(txt_SelRow.Text), 37) = "0"
            ElseIf chk_TaxKind1.Checked Then
                grd_ItemList(CInt(txt_SelRow.Text), 37) = "1"
            End If

            ' ñ{ïîîzêMëŒâû
            If GF_GetAppInfo("DELIVARY_FLG") = "1" Or GF_GetAppInfo("DELIVARY_FLG") = "2" Or GF_GetAppInfo("DELIVARY_FLG") = "3" Then
                grd_ItemList(CInt(txt_SelRow.Text), 38) = txtUnitPrice.Text
            End If

            ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------
            If LF_ChkLaneFlg() = "1" Then
                grd_ItemList(CInt(txt_SelRow.Text), 39) = chk_Lane.Checked
            End If
            ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------

            '2019.08.09 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura >>>
            grd_ItemList(CInt(txt_SelRow.Text), 40) = txt_MenuCode.Text
            grd_ItemList(CInt(txt_SelRow.Text), 41) = txt_OwnCompanyCode.Text

            grd_ItemList(CInt(txt_SelRow.Text), 42) = Format$(CLng(Replace(txt_Price_Reduce.Text, ",", "")), "#####0")
            grd_ItemList(CInt(txt_SelRow.Text), 43) = Format$(CLng(Replace(txt_SubPrice.Text, ",", "")), "#####0")
            grd_ItemList(CInt(txt_SelRow.Text), 44) = Format$(CLng(Replace(txt_SubPrice_Reduce.Text, ",", "")), "#####0")

            If rbt_Ptype_Preset.Checked Then
                grd_ItemList(CInt(txt_SelRow.Text), 45) = "0"
            ElseIf rbt_Ptype_Open.Checked Then
                grd_ItemList(CInt(txt_SelRow.Text), 45) = "1"
            End If

            grd_ItemList(CInt(txt_SelRow.Text), 46) = cmb_TaxType.SelectedValue
            grd_ItemList(CInt(txt_SelRow.Text), 47) = cmb_TaxType_Reduced.SelectedValue

            If rbt_Qadd_Disabled.Checked Then
                grd_ItemList(CInt(txt_SelRow.Text), 48) = "0"
            Else
                grd_ItemList(CInt(txt_SelRow.Text), 48) = "1"
            End If

            If rbt_Discount_Discount.Checked Then
                grd_ItemList(CInt(txt_SelRow.Text), 49) = "0"
            Else
                grd_ItemList(CInt(txt_SelRow.Text), 49) = "1"
            End If

            If rbt_Takeout_Eatin.Checked Then
                grd_ItemList(CInt(txt_SelRow.Text), 50) = "0"
            ElseIf rbt_Takeout_Both.Checked Then
                grd_ItemList(CInt(txt_SelRow.Text), 50) = "1"
            Else
                grd_ItemList(CInt(txt_SelRow.Text), 50) = "2"
            End If

            If rbt_OES_Enabled.Checked Then
                grd_ItemList(CInt(txt_SelRow.Text), 51) = "0"
            Else
                grd_ItemList(CInt(txt_SelRow.Text), 51) = "1"
            End If

            grd_ItemList(CInt(txt_SelRow.Text), 52) = UpperBox.Text
            grd_ItemList(CInt(txt_SelRow.Text), 53) = LowerBox.Text


            '2019.08.09 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura <<<

            '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
            grd_ItemList(CInt(txt_SelRow.Text), 54) = txt_TECKCPNM3.Text
            grd_ItemList(CInt(txt_SelRow.Text), 55) = txt_HTLNM5.Text
            '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

            If SetEdited = True Then
                L_blnEditFlg = True 'Gert 04/01
                btn_Save.BackColor = Color.Yellow
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_WriteRetItemInfo")
    End Sub

    ' --------------------------------------------------------------------------------
    '   ã@Å@Å@î\ÅFÉAÉCÉRÉìÉpÉ^Å[ÉìêUÇËï™ÇØèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2017.01.01 ÉNÉåÉXÉRñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Function SetPtnKbn(ByVal pcode As String) As String

        SetPtnKbn = pcode

        Select Case pcode
            Case "A"
                SetPtnKbn = 10
            Case "B"
                SetPtnKbn = 11
            Case "C"
                SetPtnKbn = 12
            Case "D"
                SetPtnKbn = 13
            Case "E"
                SetPtnKbn = 14
            Case "F"
                SetPtnKbn = 15
            Case "G"
                SetPtnKbn = 16
            Case " "
                SetPtnKbn = 0
        End Select

    End Function

    ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„
    ' --------------------------------------------------------------------------------
    '   ã@Å@Å@î\ÅFÉpÉ^Å[ÉìãÊï™éÊìæèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2017.01.01 ÉNÉåÉXÉRñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Function PtnKbn(ByVal pcodenm As String) As String

        Dim strSQL As String = Nothing
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        PtnKbn = ""

        strSQL = ""
        strSQL = strSQL & " SELECT CODEVAL"
        strSQL = strSQL & "   FROM TPM030"
        strSQL = strSQL & "  WHERE CODENM = '" & pcodenm & "'"
        strSQL = strSQL & "    AND CODEID = 'PTNMSG'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        PtnKbn = Trim$(objRows("CODEVAL"))

    End Function
    ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„


    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFÉfÅ[É^ï€ë∂èàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub LS_SaveData()
        LS_WriteRetItemInfo("", False) 'Gert 04/01
        Me.Cursor = Cursors.WaitCursor
        If Not LF_UpdTPM010() Then                                          ' è§ïiÉ}ÉXÉ^çXêVèàóù
            GoTo SYSTEM_ERROR
        End If
        If Not LF_DelUnuseFile() Then                                       ' ñ¢égópÉtÉ@ÉCÉãçÌèúèàóù
            GoTo SYSTEM_ERROR
        End If
        L_blnEditFlg = False
        btn_Save.BackColor = Color.Empty
        Me.Cursor = Cursors.Default
        Exit Sub

SYSTEM_ERROR:
        Me.Cursor = Cursors.Default
        Call GS_ErrorTerm("LS_SaveData")
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïièÓïÒì¸óÕì‡óeèëÇ´ñﬂÇµèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM010() As Boolean

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim strSQL As String = Nothing
        Dim strSQL2 As String = Nothing
        Dim lngCnt As Long
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim strItemPath As String = Nothing
        Dim objBitmap As Bitmap
        Dim objGraph As Graphics
        Dim strOrgPath As String = Nothing
        Dim strTgtPath As String = Nothing
        Dim strSTgtPath As String = Nothing
        Dim strImgNM As String = Nothing
        Dim strWork() As String = Nothing
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngTPM200Cnt As Long
        Dim lngTPM210Cnt As Long
        Dim lngTPM250Cnt As Long
        Dim lngTPM260Cnt As Long
        Dim lngTPM320Cnt As Long
        Dim objData2 As New DataSet()
        Dim strSearchNumFlg As String = Nothing
        Dim strCNWHGameFlg As String = Nothing
        Dim strDelivaryFlg As String = Nothing
        Dim strMultiLingUse As String = Nothing
        '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
        Dim TICKETUSE As String = GF_GetAppInfo("TICKETUSE")
        Dim HTLNMUSE As String = GF_GetAppInfo("HTLNMUSE")
        '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

        '------------------------------
        ' èâä˙ílê›íË
        '------------------------------
        LF_UpdTPM010 = False
        strItemPath = GF_GetAppInfo("ITEM_PATH")
        strSearchNumFlg = GF_GetAppInfo2("SEARCH_NUM_FLG")
        strCNWHGameFlg = GF_GetAppInfo2("CNWH_GAMEFLG")
        strDelivaryFlg = GF_GetAppInfo("DELIVARY_FLG")
        strMultiLingUse = GF_GetAppInfo2("MULTI_LING_USE")

        '------------------------------
        ' ÉgÉâÉìÉUÉNÉVÉáÉìäJén
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        '------------------------------
        ' çXêVèàóù
        '------------------------------
        With grd_ItemList
            For lngCnt = 0 To GF_GetRowCnt(grd_ItemList) - 1
                If grd_ItemList(lngCnt, 14) = GC_TRUE Then                   ' ïœçXÇÃÇ©Ç©Ç¡ÇΩçsÇÃÇ›çXêVëŒè€Ç∆Ç∑ÇÈ

                    If Len(Trim$(grd_ItemList(lngCnt, 2))) <> 0 Then
                        objFileInfo = New System.IO.FileInfo(Trim$(grd_ItemList(lngCnt, 2)))
                        strImgNM = objFileInfo.Name

                        If strImgNM.Substring(0, 2) = "S_" Then
                            strImgNM = strImgNM.Remove(0, 2)
                        End If

                        If objFileInfo.DirectoryName <> strItemPath Then
                            Try
                                ' ê›íËÇ≥ÇÍÇΩÉtÉ@ÉCÉãÇ™ê≥Ç»ÇÃÇ≈ÅAÇªÇÃÉtÉ@ÉCÉãÇÃñºëOÇÅAïiî‘Ç…ïœÇ¶ÇƒÇµÇ‹Ç§ÅB
                                ' Ç‡ÇµÇ‡ÅAÇªÇÃïiî‘Ç…ïœÇ¶ÇƒÇµÇ‹Ç¡ÇΩå„ÇÃÉtÉ@ÉCÉãñºÇ™ÅAè§ïiâÊëúÉtÉHÉãÉ_Ç…ë∂ç›ÇµÇΩÇÁÅAÇªÇÍÇÕè¡ÇµÇƒÇµÇ‹Ç¡ÇƒÅAêVÇΩÇ…çÏÇËíºÇ∑ÅB
                                strOrgPath = Trim$(grd_ItemList(lngCnt, 2))

                                strImgNM = Trim$(grd_ItemList(lngCnt, 1)) & Format$(Now, "yyyyMMddHHmmss") & objFileInfo.Extension
                                strTgtPath = strItemPath & "\" & strImgNM
                                strSTgtPath = strItemPath & "\S_" & strImgNM

                                '------------------------------
                                ' ãåè§ïiâÊëúÇçÌèú
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
                                ' ÉIÉäÉWÉiÉãÉTÉCÉYÉRÉsÅ[
                                '------------------------------
                                System.IO.File.Copy(strOrgPath, strTgtPath)

                                '------------------------------
                                ' èkè¨èàóùÉRÉsÅ[(çƒï€ë∂)
                                '------------------------------
                                Try
                                    'GIFâÊëúÇÃèÍçáÅAÉIÉäÉWÉiÉãÉTÉCÉYÉRÉsÅ[
                                    If Strings.Right(strTgtPath, 3) = "gif" Then
                                        System.IO.File.Copy(strOrgPath, strSTgtPath)
                                    Else
                                        objBitmap = New Bitmap(320, 240)
                                        objGraph = Graphics.FromImage(objBitmap)
                                        objGraph.DrawImage(Image.FromFile(strTgtPath), 0, 0, 320, 240)
                                        objBitmap.Save(strSTgtPath, System.Drawing.Imaging.ImageFormat.Jpeg)
                                        objBitmap.Dispose()
                                        objGraph.Dispose()
                                    End If
                                Catch
                                    Call GF_RollbackTrans()
                                    Exit Function
                                End Try
                            Catch
                                Call GF_RollbackTrans()
                                Exit Function
                            End Try
                        End If
                    End If

                    strSQL = ""
                    strSQL = strSQL & "UPDATE TPM010"

                    If Len(Trim$(grd_ItemList(lngCnt, 5))) = 0 Then
                        strSQL = strSQL & "   SET TPM010.JEXPNOTEJ = '" & Space(1) & "',"
                    Else
                        strSQL = strSQL & "   SET TPM010.JEXPNOTEJ = '" & Trim$(Replace(GF_RepQuo(grd_ItemList(lngCnt, 5)), vbCrLf, "<BR>")) & "',"
                    End If

                    If Not IsNothing(objFileInfo) Then
                        strSQL = strSQL & "       TPM010.IMAGEDATA = '" & GF_RepQuo(strImgNM) & "',"
                    Else
                        strSQL = strSQL & "       TPM010.IMAGEDATA = '" & Space(1) & "',"
                    End If

                    If Len(Trim$(grd_ItemList(lngCnt, 7))) = 0 Then
                        strSQL = strSQL & "       TPM010.UNITJ     = '" & Space(1) & "',"
                    Else
                        strSQL = strSQL & "       TPM010.UNITJ     = '" & GF_RepQuo(grd_ItemList(lngCnt, 7)) & "',"
                    End If

                    If Len(Trim$(grd_ItemList(lngCnt, 9))) = 0 Then
                        strSQL = strSQL & "       TPM010.GOODSNMJ  = '" & GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 8))) & "',"
                    Else
                        strSQL = strSQL & "       TPM010.GOODSNMJ  = '" & GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 9))) & "',"
                    End If

                    If Len(Trim$(grd_ItemList(lngCnt, 10))) = 0 Then
                        strSQL = strSQL & "       TPM010.GOODSNMJ2 = '" & Space(1) & "',"
                    Else
                        strSQL = strSQL & "       TPM010.GOODSNMJ2 = '" & GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 10))) & "',"
                    End If

                    If L_PriceEdit = GC_TRUE Then
                        strSQL = strSQL & "       TPM010.PRICE     = '" & Replace(Trim$(grd_ItemList(lngCnt, 4)), ",", "") & "',"
                    End If

                    strSQL = strSQL & "       TPM010.SELLFLG   = '" & IIf(grd_ItemList(lngCnt, 0) = True, GC_TRUE, GC_FALSE) & "',"
                    strSQL = strSQL & "       TPM010.GENERATEFLG = '" & GC_TRUE & "',"
                    strSQL = strSQL & "       TPM010.KCPSTATUS   = '" & Trim$(grd_ItemList(lngCnt, 11)) & "',"
                    strWork = Split(Trim$(grd_ItemList(lngCnt, 16)), ",")

                    If strWork.GetUpperBound(0) <> 11 Then
                        Call GF_RollbackTrans()
                        Exit Function
                    End If

                    strSQL = strSQL & "       TPM010.SCPNO01   = '" & Trim$(strWork(0)) & "',"
                    strSQL = strSQL & "       TPM010.SCPNO02   = '" & Trim$(strWork(1)) & "',"
                    strSQL = strSQL & "       TPM010.SCPNO03   = '" & Trim$(strWork(2)) & "',"
                    strSQL = strSQL & "       TPM010.SCPNO04   = '" & Trim$(strWork(3)) & "',"
                    strSQL = strSQL & "       TPM010.SCPNO05   = '" & Trim$(strWork(4)) & "',"
                    strSQL = strSQL & "       TPM010.SCPNO06   = '" & Trim$(strWork(5)) & "',"
                    strSQL = strSQL & "       TPM010.SCPNO07   = '" & Trim$(strWork(6)) & "',"
                    strSQL = strSQL & "       TPM010.SCPNO08   = '" & Trim$(strWork(7)) & "',"
                    strSQL = strSQL & "       TPM010.SCPNO09   = '" & Trim$(strWork(8)) & "',"
                    strSQL = strSQL & "       TPM010.SCPNO10   = '" & Trim$(strWork(9)) & "',"
                    strSQL = strSQL & "       TPM010.SCPNO11   = '" & Trim$(strWork(10)) & "',"
                    strSQL = strSQL & "       TPM010.SCPNO12   = '" & Trim$(strWork(11)) & "',"
                    strSQL = strSQL & "       TPM010.STATUS    = '" & GF_RepQuo(grd_ItemList(lngCnt, 25)) & "',"
                    strSQL = strSQL & "       TPM010.HTLNM1    = '" & GF_RepQuo(grd_ItemList(lngCnt, 17)) & "',"
                    strSQL = strSQL & "       TPM010.HTLNM2    = '" & GF_RepQuo(grd_ItemList(lngCnt, 18)) & "',"
                    strSQL = strSQL & "       TPM010.GOODSNMJ4 = '" & GF_RepQuo(grd_ItemList(lngCnt, 19)) & "',"

                    ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„
                    'strSQL = strSQL & "       TPM010.SPFLG     = '" & IIf(grd_ItemList(lngCnt, 20) = True, "1", "0") & "',"
                    'strSQL = strSQL & "       TPM010.NEWFLG    = '" & IIf(grd_ItemList(lngCnt, 21) = True, "1", "0") & "',"

                    strSQL = strSQL & "       TPM010.SPFLG     = '" & LS_RtnPtn(grd_ItemList(lngCnt, 20)) & "',"
                    strSQL = strSQL & "       TPM010.NEWFLG    = '" & LS_RtnPtn(grd_ItemList(lngCnt, 21)) & "',"
                    ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„

                    strSQL = strSQL & "       TPM010.BUMONCD   = '" & GF_RepQuo(grd_ItemList(lngCnt, 22)) & "',"
                    strSQL = strSQL & "       TPM010.UPDID     = '" & GC_UPDID & "',"
                    strSQL = strSQL & "       TPM010.UPDYMD    = '" & Now & "'"
                    strSQL = strSQL & " WHERE TPM010.GOODSCD   = '" & grd_ItemList(lngCnt, 1) & "'"

                    objFileInfo = Nothing

                    If Not GF_UpdData(strSQL) Then
                        Call GF_RollbackTrans()
                        Exit Function
                    End If

                    'Make sure all ID's in TPM012 match TPM010'
                    strSQL = ""
                    strSQL = strSQL + "insert into TPM012 (GOODSCD, UPPERTEXT, LOWERTEXT, UPID, UPDYMD) "
                    strSQL = strSQL + "select top 999999 GOODSCD, 'Å@', 'Å@', '" & GC_UPDID & "','" & Now & "'  from TPM010 as origin " 'ëSäpÉXÉyÅ[ÉX
                    strSQL = strSQL + "where  origin.GOODSCD NOT IN (SELECT GOODSCD FROM TPM012) "

                    If Not GF_UpdData(strSQL) Then
                        Call GF_RollbackTrans()
                        Exit Function
                    End If

                    strSQL = ""
                    strSQL = strSQL & "IF (NOT EXISTS(SELECT GOODSCD FROM TPM012 WHERE GOODSCD = '" & grd_ItemList(lngCnt, 1) & "')) "
                    strSQL = strSQL & " BEGIN "
                    strSQL = strSQL & " INSERT into TPM012 (GOODSCD, UPPERTEXT, LOWERTEXT, UPID, UPDYMD) "
                    strSQL = strSQL & " VALUES ( '" & grd_ItemList(lngCnt, 1) & "', '" & StrConv(grd_ItemList(lngCnt, 52), VbStrConv.Narrow) & "', '" & StrConv(grd_ItemList(lngCnt, 53), VbStrConv.Narrow) & "', '" & GC_UPDID & "', '" & Now & "') "
                    strSQL = strSQL & " END "
                    strSQL = strSQL & " ELSE "
                    strSQL = strSQL & " BEGIN "
                    strSQL = strSQL & " UPDATE TPM012 "
                    strSQL = strSQL & " SET UPPERTEXT = '" & StrConv(grd_ItemList(lngCnt, 52), VbStrConv.Narrow) & "' "
                    strSQL = strSQL & " , LOWERTEXT = '" & StrConv(grd_ItemList(lngCnt, 53), VbStrConv.Narrow) & "' "
                    strSQL = strSQL & " , UPID = '" & GC_UPDID & "' "
                    strSQL = strSQL & " , UPDYMD = '" & Now & "' "
                    strSQL = strSQL & " WHERE GOODSCD = '" & grd_ItemList(lngCnt, 1) & "' "
                    strSQL = strSQL & " END "

                    If Not GF_UpdData(strSQL) Then
                        Call GF_RollbackTrans()
                        Exit Function
                    End If

                    '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
                    'TPM013 ë∂ç›É`ÉFÉbÉN
                    If TICKETUSE = "1" Or HTLNMUSE = "0" Then
                        strSQL = ""
                        strSQL = strSQL + "insert into TPM013 (GOODSCD, TECKCPNM3, HTLNM5, UPDID, UPDYMD) "
                        strSQL = strSQL + "select top 999999 GOODSCD, 'Å@', 'Å@', '" & GC_UPDID & "','" & Now & "'  from TPM010 as origin " 'ëSäpÉXÉyÅ[ÉX
                        strSQL = strSQL + "where  origin.GOODSCD NOT IN (SELECT GOODSCD FROM TPM013) "

                        If Not GF_UpdData(strSQL) Then
                            Call GF_RollbackTrans()
                            Exit Function
                        End If

                        strSQL = ""
                        strSQL = strSQL & "IF (NOT EXISTS(SELECT GOODSCD FROM TPM013 WHERE GOODSCD = '" & grd_ItemList(lngCnt, 1) & "')) "
                        strSQL = strSQL & " BEGIN "
                        strSQL = strSQL & " INSERT into TPM013 (GOODSCD, TECKCPNM3, HTLNM5, UPDID, UPDYMD) "
                        strSQL = strSQL & " VALUES ( '" & grd_ItemList(lngCnt, 1) & "', '" & grd_ItemList(lngCnt, 54) & "', '" & grd_ItemList(lngCnt, 55) & "', '" & GC_UPDID & "', '" & Now & "') "
                        strSQL = strSQL & " END "
                        strSQL = strSQL & " ELSE "
                        strSQL = strSQL & " BEGIN "

                        strSQL = strSQL & " UPDATE TPM013 "
                        If TICKETUSE = "1" And HTLNMUSE = "0" Then
                            strSQL = strSQL & " SET TECKCPNM3 = '" & grd_ItemList(lngCnt, 54) & "' "
                            strSQL = strSQL & " , HTLNM5 = '" & grd_ItemList(lngCnt, 55) & "' "
                        ElseIf TICKETUSE = "1" And HTLNMUSE = "1" Then
                            strSQL = strSQL & " SET TECKCPNM3 = '" & grd_ItemList(lngCnt, 54) & "' "
                        ElseIf TICKETUSE = "0" And HTLNMUSE = "0" Then
                            strSQL = strSQL & " SET HTLNM5 = '" & grd_ItemList(lngCnt, 55) & "' "
                        End If

                        strSQL = strSQL & " , UPDID = '" & GC_UPDID & "' "
                        strSQL = strSQL & " , UPDYMD = '" & Now & "' "
                        strSQL = strSQL & " WHERE GOODSCD = '" & grd_ItemList(lngCnt, 1) & "' "
                        strSQL = strSQL & " END "

                        If Not GF_UpdData(strSQL) Then
                            Call GF_RollbackTrans()
                            Exit Function
                        End If

                    End If
                    '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

                    '2019.08.09 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura >>>
                    strSQL = ""
                    strSQL = strSQL & "UPDATE TPM600 SET"
                    strSQL = strSQL & String.Format(" MENUCD = '{0}',", GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 40))))
                    strSQL = strSQL & String.Format(" INSTORECD = '{0}',", GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 41))))
                    strSQL = strSQL & String.Format(" PRICE_RED = {0},", Replace(Trim$(grd_ItemList(lngCnt, 42)), ",", ""))
                    strSQL = strSQL & String.Format(" SUBPRICE = {0},", Replace(Trim$(grd_ItemList(lngCnt, 43)), ",", ""))
                    strSQL = strSQL & String.Format(" SUBPRICE_RED = {0},", Replace(Trim$(grd_ItemList(lngCnt, 44)), ",", ""))
                    strSQL = strSQL & String.Format(" PRICETYPE = '{0}',", GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 45))))
                    strSQL = strSQL & String.Format(" TAXTYPE = '{0}',", GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 46))))
                    strSQL = strSQL & String.Format(" TAXTYPE_RED = '{0}',", GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 47))))
                    strSQL = strSQL & String.Format(" QADDITIONALFLG = '{0}',", GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 48))))
                    strSQL = strSQL & String.Format(" DISCOUNTFLG = '{0}',", GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 49))))
                    strSQL = strSQL & String.Format(" TAKEOUTTYPE = '{0}',", GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 50))))
                    strSQL = strSQL & String.Format(" OESMENUFLG = '{0}',", GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 51))))
                    strSQL = strSQL & String.Format(" UPDID = '{0}',", GC_UPDID)
                    strSQL = strSQL & String.Format(" UPDYMD = '{0}'", Now)
                    strSQL = strSQL & String.Format(" WHERE GOODSCD = '{0}'", grd_ItemList(lngCnt, 1))

                    If Not GF_UpdData(strSQL) Then
                        Call GF_RollbackTrans()
                        Exit Function
                    End If
                    '2019.08.09 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura <<<





                    If Trim$(strSearchNumFlg) = GC_FALSE Then
                        '------------------------------
                        ' èâä˙âª
                        '------------------------------
                        objData = New DataSet()
                        objRows = Nothing
                        lngTPM200Cnt = 0

                        '------------------------------
                        ' TPM200ìoò^èàóù
                        '------------------------------
                        strSQL = ""
                        strSQL = strSQL & "SELECT SEARCHNUMBER"
                        strSQL = strSQL & "     , GOODSCD"
                        strSQL = strSQL & "  FROM TPM200"
                        strSQL = strSQL & " WHERE GOODSCD = '" & grd_ItemList(lngCnt, 1) & "'"

                        If Not GF_GetData(strSQL, objData) Then
                            Exit Function
                        End If

                        If objData.Tables("com").Rows.Count > 0 Then
                            ' Update
                            While lngTPM200Cnt < objData.Tables("com").Rows.Count
                                If Not GF_GetRows(objData, lngTPM200Cnt, objRows) Then
                                    Exit Function
                                End If

                                strSQL = ""
                                strSQL = strSQL & "UPDATE TPM200"
                                strSQL = strSQL & "   SET SEARCHNUMBER = '" & Trim(grd_ItemList(lngCnt, 23)) & "',"
                                strSQL = strSQL & "       UPDID        = '" & GC_UPDID & "',"
                                strSQL = strSQL & "       UPDYMD       = '" & Now & "'"
                                strSQL = strSQL & " WHERE GOODSCD      = '" & objRows("GOODSCD").ToString & "'"

                                If Not GF_UpdData(strSQL) Then
                                    Call GF_RollbackTrans()
                                    Exit Function
                                End If

                                lngTPM200Cnt = lngTPM200Cnt + 1
                            End While

                        Else
                            If Trim(grd_ItemList(lngCnt, 23)) <> "" Then
                                ' åüçıî‘çÜì¸óÕéûÇÃÇ›í«â¡èàóùÇé¿é{
                                ' Insert
                                strSQL = ""
                                strSQL = strSQL & "INSERT INTO TPM200 VALUES("
                                strSQL = strSQL & "'" & Trim(grd_ItemList(lngCnt, 1)) & "',"   ' GOODSCD
                                strSQL = strSQL & "'" & Trim(grd_ItemList(lngCnt, 23)) & "',"  ' SEARCHNUMBER
                                strSQL = strSQL & "'" & GC_UPDID & "',"                        ' UPDID
                                strSQL = strSQL & "'" & Now & "')"                             ' UPDYMD

                                If Not GF_UpdData(strSQL) Then
                                    Call GF_RollbackTrans()
                                    Exit Function
                                End If

                            End If
                        End If
                    End If

                    If Trim$(strCNWHGameFlg) = GC_FALSE Then
                        '------------------------------
                        ' èâä˙âª
                        '------------------------------
                        objData = New DataSet()
                        objRows = Nothing
                        lngTPM210Cnt = 0

                        '------------------------------
                        ' TPM210ìoò^èàóù
                        '------------------------------
                        strSQL = ""
                        strSQL = strSQL & "SELECT GOODSCD"
                        strSQL = strSQL & "     , GAMEENABLED"
                        strSQL = strSQL & "  FROM TPM210"
                        strSQL = strSQL & " WHERE GOODSCD = '" & grd_ItemList(lngCnt, 1) & "'"

                        If Not GF_GetData(strSQL, objData) Then
                            Exit Function
                        End If

                        If objData.Tables("com").Rows.Count > 0 Then
                            ' Update
                            While lngTPM210Cnt < objData.Tables("com").Rows.Count
                                If Not GF_GetRows(objData, lngTPM210Cnt, objRows) Then
                                    Exit Function
                                End If

                                strSQL = ""
                                strSQL = strSQL & "UPDATE TPM210"
                                strSQL = strSQL & "   SET GAMEENABLED = '" & IIf(Trim(grd_ItemList(lngCnt, 24)) = False, 0, 1) & "',"
                                strSQL = strSQL & "       UPDID       = '" & GC_UPDID & "',"
                                strSQL = strSQL & "       UPDYMD      = '" & Now & "'"
                                strSQL = strSQL & " WHERE GOODSCD     = '" & objRows("GOODSCD").ToString & "'"

                                If Not GF_UpdData(strSQL) Then
                                    Call GF_RollbackTrans()
                                    Exit Function
                                End If

                                lngTPM210Cnt = lngTPM210Cnt + 1
                            End While

                        Else
                            If Trim(grd_ItemList(lngCnt, 24)) = True Then
                                ' ÉQÅ[ÉÄëIëéûÇÃÇ›í«â¡èàóùÇé¿é{
                                ' Insert
                                strSQL = ""
                                strSQL = strSQL & "INSERT INTO TPM210 VALUES("
                                strSQL = strSQL & "'" & Trim(grd_ItemList(lngCnt, 1)) & "',"   ' GOODSCD
                                strSQL = strSQL & "'" & IIf(Trim(grd_ItemList(lngCnt, 24)) = False, 0, 1) & "',"  ' GAMEENABLED
                                strSQL = strSQL & "'" & GC_UPDID & "',"                        ' UPDID
                                strSQL = strSQL & "'" & Now & "')"                             ' UPDYMD

                                If Not GF_UpdData(strSQL) Then
                                    Call GF_RollbackTrans()
                                    Exit Function
                                End If

                            End If
                        End If
                    End If

                    ' ñ{ïîîzêMëŒâû
                    If Trim$(strDelivaryFlg) = "1" Or strDelivaryFlg = "2" Or strDelivaryFlg = "3" Then
                        '------------------------------
                        ' èâä˙âª
                        '------------------------------
                        objData = New DataSet()
                        objRows = Nothing

                        '------------------------------
                        ' TPM330ìoò^èàóù
                        '------------------------------
                        strSQL = ""
                        strSQL = strSQL & "SELECT GOODSCD"
                        strSQL = strSQL & "     , ENABLEDFLG"
                        strSQL = strSQL & "  FROM TPM330"
                        strSQL = strSQL & " WHERE GOODSCD = '" & grd_ItemList(lngCnt, 1) & "'"

                        If Not GF_GetData(strSQL, objData) Then
                            Exit Function
                        End If

                        If objData.Tables("com").Rows.Count > 0 Then
                            ' Update
                            ' TPM330ÇÕUPDATEÇµÇ»Ç¢
                        Else
                            ' Insert
                            strSQL = ""
                            strSQL = strSQL & "INSERT INTO TPM330 VALUES("
                            strSQL = strSQL & "'" & Trim(grd_ItemList(lngCnt, 1)) & "',"   ' GOODSCD
                            strSQL = strSQL & "'0',"                                       ' ENABLEDFLG
                            strSQL = strSQL & "'" & GC_UPDID & "',"                        ' UPDID
                            strSQL = strSQL & "'" & Now & "')"                             ' UPDYMD

                            If Not GF_UpdData(strSQL) Then
                                Call GF_RollbackTrans()
                                Exit Function
                            End If
                        End If

                        '------------------------------
                        ' èâä˙âª
                        '------------------------------
                        objData = New DataSet()
                        objRows = Nothing

                        '------------------------------
                        ' TPM340ìoò^èàóù
                        '------------------------------
                        strSQL = ""
                        strSQL = strSQL & "SELECT GOODSCD"
                        strSQL = strSQL & "     , COST"
                        strSQL = strSQL & "  FROM TPM340"
                        strSQL = strSQL & " WHERE GOODSCD = '" & grd_ItemList(lngCnt, 1) & "'"

                        If Not GF_GetData(strSQL, objData) Then
                            Exit Function
                        End If

                        If objData.Tables("com").Rows.Count > 0 Then
                            ' Update
                            strSQL = ""
                            strSQL = strSQL & "UPDATE TPM340"
                            strSQL = strSQL & "   SET COST = '" & Trim(grd_ItemList(lngCnt, 38)) & "',"
                            strSQL = strSQL & "       UPDID       = '" & GC_UPDID & "',"
                            strSQL = strSQL & "       UPDYMD      = '" & Now & "'"
                            strSQL = strSQL & " WHERE GOODSCD     = '" & grd_ItemList(lngCnt, 1) & "'"

                            If Not GF_UpdData(strSQL) Then
                                Call GF_RollbackTrans()
                                Exit Function
                            End If
                        Else
                            ' Insert
                            strSQL = ""
                            strSQL = strSQL & "INSERT INTO TPM340 VALUES("
                            strSQL = strSQL & "'" & Trim(grd_ItemList(lngCnt, 1)) & "',"                                         ' GOODSCD
                            strSQL = strSQL & IIf(Trim(grd_ItemList(lngCnt, 38)) = "", 0, Trim(grd_ItemList(lngCnt, 38))) & ","  ' COST
                            strSQL = strSQL & "'" & GC_UPDID & "',"                                                              ' UPDID
                            strSQL = strSQL & "'" & Now & "')"                                                                   ' UPDYMD

                            If Not GF_UpdData(strSQL) Then
                                Call GF_RollbackTrans()
                                Exit Function
                            End If
                        End If

                        '------------------------------
                        ' èâä˙âª
                        '------------------------------
                        objData = New DataSet()
                        objRows = Nothing

                        '------------------------------
                        ' TPM350ìoò^èàóù
                        '------------------------------
                        strSQL = ""
                        strSQL = strSQL & "SELECT GOODSCD"
                        strSQL = strSQL & "     , DELIVARYFLG"
                        strSQL = strSQL & "  FROM TPM350"
                        strSQL = strSQL & " WHERE GOODSCD = '" & grd_ItemList(lngCnt, 1) & "'"

                        If Not GF_GetData(strSQL, objData) Then
                            Exit Function
                        End If

                        If objData.Tables("com").Rows.Count > 0 Then
                            ' Update
                            ' TPM350ÇÕUPDATEÇµÇ»Ç¢
                        Else
                            ' Insert
                            strSQL = ""
                            strSQL = strSQL & "INSERT INTO TPM350 VALUES("
                            strSQL = strSQL & "'" & Trim(grd_ItemList(lngCnt, 1)) & "',"   ' GOODSCD
                            strSQL = strSQL & "'0',"                                       ' DELIVARYFLG
                            strSQL = strSQL & "'" & GC_UPDID & "',"                        ' UPDID
                            strSQL = strSQL & "'" & Now & "')"                             ' UPDYMD

                            If Not GF_UpdData(strSQL) Then
                                Call GF_RollbackTrans()
                                Exit Function
                            End If
                        End If
                    End If
                    ' ñ{ïîîzêMëŒâû

                    '2013.10.21 êVãKçÏê¨
                    '------------------------------
                    ' èâä˙âª
                    '------------------------------
                    objData = New DataSet()
                    objRows = Nothing
                    lngTPM250Cnt = 0
                    '------------------------------
                    ' TPM250ìoò^èàóù
                    '------------------------------
                    strSQL = ""
                    strSQL = strSQL & "SELECT GOODSCD"
                    strSQL = strSQL & "     , CCPENABLED"
                    strSQL = strSQL & "  FROM TPM250"
                    strSQL = strSQL & " WHERE GOODSCD = '" & grd_ItemList(lngCnt, 1) & "'"

                    If Not GF_GetData(strSQL, objData) Then
                        Exit Function
                    End If

                    If objData.Tables("com").Rows.Count > 0 Then
                        ' Update
                        While lngTPM250Cnt < objData.Tables("com").Rows.Count
                            If Not GF_GetRows(objData, lngTPM250Cnt, objRows) Then
                                Exit Function
                            End If

                            strSQL = ""
                            strSQL = strSQL & "UPDATE TPM250"
                            '2019.08.09 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura >>>
                            strSQL = strSQL & "   SET CCPENABLED = '" & IIf(Trim(grd_ItemList(lngCnt, 26)) = True, 1, 0) & "',"
                            'strSQL = strSQL & "   SET CCPENABLED = '" & IIf(Trim(grd_ItemList(lngCnt, 26)) = False, 1, 0) & "',"
                            '2019.08.09 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura <<<
                            strSQL = strSQL & "       UPDID       = '" & GC_UPDID & "',"
                            strSQL = strSQL & "       UPDYMD      = '" & Now & "'"
                            strSQL = strSQL & " WHERE GOODSCD     = '" & objRows("GOODSCD").ToString & "'"

                            If Not GF_UpdData(strSQL) Then
                                Call GF_RollbackTrans()
                                Exit Function
                            End If

                            lngTPM250Cnt = lngTPM250Cnt + 1
                        End While

                    Else
                        If Trim(grd_ItemList(lngCnt, 26)) = True Then

                            ' Insert
                            strSQL = ""
                            strSQL = strSQL & "INSERT INTO TPM250 VALUES("
                            strSQL = strSQL & "'" & Trim(grd_ItemList(lngCnt, 1)) & "',"   ' GOODSCD
                            '2019.08.09 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura >>>
                            strSQL = strSQL & "'" & IIf(Trim(grd_ItemList(lngCnt, 26)) = True, 1, 0) & "',"  ' CCPENABLED
                            'strSQL = strSQL & "'" & IIf(Trim(grd_ItemList(lngCnt, 26)) = False, 1, 0) & "',"  ' CCPENABLED
                            '2019.08.09 åyå∏ê≈ó¶ëŒâû ∏⁄Ω∫ñkó§)takigaura <<<
                            strSQL = strSQL & "'" & GC_UPDID & "',"                        ' UPDID
                            strSQL = strSQL & "'" & Now & "')"                             ' UPDYMD

                            If Not GF_UpdData(strSQL) Then
                                Call GF_RollbackTrans()
                                Exit Function
                            End If

                        End If
                    End If

                    '------------------------------
                    ' èâä˙âª
                    '------------------------------
                    objData = New DataSet()
                    objRows = Nothing
                    lngTPM260Cnt = 0

                    '------------------------------
                    ' TPM260ìoò^èàóù
                    '------------------------------
                    strSQL = ""
                    strSQL = strSQL & "SELECT GOODSCD,"
                    strSQL = strSQL & "       TAXPRICE"
                    strSQL = strSQL & "  FROM TPM260"
                    strSQL = strSQL & " WHERE GOODSCD = '" & grd_ItemList(lngCnt, 1) & "'"

                    If Not GF_GetData(strSQL, objData) Then
                        Exit Function
                    End If
                    If objData.Tables("com").Rows.Count > 0 Then
                        ' Update
                        While lngTPM260Cnt < objData.Tables("com").Rows.Count
                            If Not GF_GetRows(objData, lngTPM260Cnt, objRows) Then
                                Exit Function
                            End If

                            strSQL = ""
                            strSQL = strSQL & "UPDATE TPM260"
                            strSQL = strSQL & "   SET TAXPRICE     = " & CInt(Trim(grd_ItemList(lngCnt, 27))) & ","
                            strSQL = strSQL & "       UPDID        = '" & GC_UPDID & "',"
                            strSQL = strSQL & "       UPDYMD       = '" & Now & "'"
                            strSQL = strSQL & " WHERE GOODSCD      = '" & objRows("GOODSCD").ToString & "'"

                            If Not GF_UpdData(strSQL) Then
                                Call GF_RollbackTrans()
                                Exit Function
                            End If

                            lngTPM260Cnt = lngTPM260Cnt + 1
                        End While
                    Else
                        ' Insert
                        strSQL = ""
                        strSQL = strSQL & "INSERT INTO TPM260 VALUES("
                        strSQL = strSQL & "'" & Trim(grd_ItemList(lngCnt, 1)) & "',"   ' GOODSCD
                        strSQL = strSQL & CInt(Trim(grd_ItemList(lngCnt, 27))) & ","  ' TAXPRICE
                        strSQL = strSQL & "'" & GC_UPDID & "',"                        ' UPDID
                        strSQL = strSQL & "'" & Now & "')"                             ' UPDYMD

                        If Not GF_UpdData(strSQL) Then
                            Call GF_RollbackTrans()
                            Exit Function
                        End If
                    End If

                    '------------------------------
                    ' èâä˙âª
                    '------------------------------
                    objData = New DataSet()
                    objRows = Nothing
                    lngTPM320Cnt = 0

                    '------------------------------
                    ' TPM320ìoò^èàóù
                    '------------------------------
                    strSQL = ""
                    strSQL = strSQL & "SELECT GOODSCD,"
                    strSQL = strSQL & "       TAXKIND"
                    strSQL = strSQL & "  FROM TPM320"
                    strSQL = strSQL & " WHERE GOODSCD = '" & grd_ItemList(lngCnt, 1) & "'"

                    If Not GF_GetData(strSQL, objData) Then
                        Exit Function
                    End If
                    If objData.Tables("com").Rows.Count > 0 Then
                        ' Update
                        While lngTPM320Cnt < objData.Tables("com").Rows.Count
                            If Not GF_GetRows(objData, lngTPM320Cnt, objRows) Then
                                Exit Function
                            End If

                            strSQL = ""
                            strSQL = strSQL & "UPDATE TPM320"
                            strSQL = strSQL & "   SET TAXKIND = '" & IIf(Trim(grd_ItemList(lngCnt, 37)) = "1", "1", "0") & "',"
                            strSQL = strSQL & "       UPDID   = '" & GC_UPDID & "',"
                            strSQL = strSQL & "       UPDYMD  = '" & Now & "'"
                            strSQL = strSQL & " WHERE GOODSCD = '" & objRows("GOODSCD").ToString & "'"

                            If Not GF_UpdData(strSQL) Then
                                Call GF_RollbackTrans()
                                Exit Function
                            End If

                            lngTPM320Cnt = lngTPM320Cnt + 1
                        End While
                    Else
                        ' Insert
                        strSQL = ""
                        strSQL = strSQL & "INSERT INTO TPM320 VALUES("
                        strSQL = strSQL & "'" & Trim(grd_ItemList(lngCnt, 1)) & "',"   ' GOODSCD
                        strSQL = strSQL & "'" & IIf(Trim(grd_ItemList(lngCnt, 37)) = "1", "1", "0") & "',"   ' TAXKIND
                        strSQL = strSQL & "'" & GC_UPDID & "',"                        ' UPDID
                        strSQL = strSQL & "'" & Now & "')"                             ' UPDYMD

                        If Not GF_UpdData(strSQL) Then
                            Call GF_RollbackTrans()
                            Exit Function
                        End If

                        'ê≈éÌï Ç™ñ¢ê›íËÇÃèÍçáÇÕèâä˙íl("äOê≈")Çê›íËÇ∑ÇÈ
                        If Trim(grd_ItemList(lngCnt, 37)) = "" Then
                            grd_ItemList(lngCnt, 37) = "0"
                        End If
                    End If

                    'ëΩåæåÍã@î\ëŒâû
                    If strMultiLingUse = "1" Then
                        ' TPM010A
                        strSQL = ""
                        strSQL = strSQL & "UPDATE TPM010A"

                        If Len(Trim$(grd_ItemList(lngCnt, 30))) = 0 Then
                            strSQL = strSQL & "   SET TPM010A.JEXPNOTEJ = N'" & Space(1) & "',"
                        Else
                            strSQL = strSQL & "   SET TPM010A.JEXPNOTEJ = N'" & Trim$(Replace(GF_RepQuo(grd_ItemList(lngCnt, 30)), vbCrLf, "<BR>")) & "',"
                        End If

                        If Len(Trim$(grd_ItemList(lngCnt, 28))) = 0 Then
                            strSQL = strSQL & "       TPM010A.GOODSNMJ  = N'" & Space(1) & "',"
                        Else
                            strSQL = strSQL & "       TPM010A.GOODSNMJ  = N'" & GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 28))) & "',"
                        End If

                        If Len(Trim$(grd_ItemList(lngCnt, 29))) = 0 Then
                            strSQL = strSQL & "       TPM010A.GOODSNMJ2 = N'" & Space(1) & "',"
                        Else
                            strSQL = strSQL & "       TPM010A.GOODSNMJ2 = N'" & GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 29))) & "',"
                        End If

                        strSQL = strSQL & "       TPM010A.UPDID     = '" & GC_UPDID & "',"
                        strSQL = strSQL & "       TPM010A.UPDYMD    = '" & Now & "'"
                        strSQL = strSQL & " WHERE TPM010A.GOODSCD   = '" & grd_ItemList(lngCnt, 1) & "'"

                        objFileInfo = Nothing

                        If Not GF_UpdData(strSQL) Then
                            Call GF_RollbackTrans()
                            Exit Function
                        End If

                        ' TPM010B
                        strSQL = ""
                        strSQL = strSQL & "UPDATE TPM010B"

                        If Len(Trim$(grd_ItemList(lngCnt, 33))) = 0 Then
                            strSQL = strSQL & "   SET TPM010B.JEXPNOTEJ = N'" & Space(1) & "',"
                        Else
                            strSQL = strSQL & "   SET TPM010B.JEXPNOTEJ = N'" & Trim$(Replace(GF_RepQuo(grd_ItemList(lngCnt, 33)), vbCrLf, "<BR>")) & "',"
                        End If

                        If Len(Trim$(grd_ItemList(lngCnt, 31))) = 0 Then
                            strSQL = strSQL & "       TPM010B.GOODSNMJ  = N'" & Space(1) & "',"
                        Else
                            strSQL = strSQL & "       TPM010B.GOODSNMJ  = N'" & GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 31))) & "',"
                        End If

                        If Len(Trim$(grd_ItemList(lngCnt, 32))) = 0 Then
                            strSQL = strSQL & "       TPM010B.GOODSNMJ2 = N'" & Space(1) & "',"
                        Else
                            strSQL = strSQL & "       TPM010B.GOODSNMJ2 = N'" & GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 32))) & "',"
                        End If

                        strSQL = strSQL & "       TPM010B.UPDID     = '" & GC_UPDID & "',"
                        strSQL = strSQL & "       TPM010B.UPDYMD    = '" & Now & "'"
                        strSQL = strSQL & " WHERE TPM010B.GOODSCD   = '" & grd_ItemList(lngCnt, 1) & "'"

                        objFileInfo = Nothing

                        If Not GF_UpdData(strSQL) Then
                            Call GF_RollbackTrans()
                            Exit Function
                        End If

                        ' TPM010C   'Å@20180625Å@äÿçëåÍÅ@â∫íiìoò^ïsîıëŒâû
                        strSQL = ""
                        strSQL = strSQL & "UPDATE TPM010C"

                        If Len(Trim$(grd_ItemList(lngCnt, 36))) = 0 Then
                            strSQL = strSQL & "   SET TPM010C.JEXPNOTEJ = N'" & Space(1) & "',"
                        Else
                            strSQL = strSQL & "   SET TPM010C.JEXPNOTEJ = N'" & Trim$(Replace(GF_RepQuo(grd_ItemList(lngCnt, 36)), vbCrLf, "<BR>")) & "',"
                        End If

                        If Len(Trim$(grd_ItemList(lngCnt, 34))) = 0 Then
                            strSQL = strSQL & "       TPM010C.GOODSNMJ  = N'" & Space(1) & "',"
                        Else
                            strSQL = strSQL & "       TPM010C.GOODSNMJ  = N'" & GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 34))) & "',"
                        End If

                        If Len(Trim$(grd_ItemList(lngCnt, 35))) = 0 Then
                            strSQL = strSQL & "       TPM010C.GOODSNMJ2 = N'" & Space(1) & "',"
                        Else
                            strSQL = strSQL & "       TPM010C.GOODSNMJ2 = N'" & GF_RepQuo(RTrim$(grd_ItemList(lngCnt, 35))) & "',"
                        End If

                        strSQL = strSQL & "       TPM010C.UPDID     = '" & GC_UPDID & "',"
                        strSQL = strSQL & "       TPM010C.UPDYMD    = '" & Now & "'"
                        strSQL = strSQL & " WHERE TPM010C.GOODSCD   = '" & grd_ItemList(lngCnt, 1) & "'"

                        objFileInfo = Nothing

                        If Not GF_UpdData(strSQL) Then
                            Call GF_RollbackTrans()
                            Exit Function
                        End If
                    End If

                    ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------
                    If LF_ChkLaneFlg() = "1" Then
                        Dim sql As New System.Text.StringBuilder()

                        ' TPM440Ç…UPDATEÇ∑ÇÈÉåÉRÅ[ÉhÇ™ë∂ç›Ç∑ÇÍÇŒUPDATEÇÅAÇ»ÇØÇÍÇŒINSERTÇçsÇ§
                        If LF_GetTPM440(grd_ItemList(lngCnt, 1)) Then
                            sql.Append("UPDATE TPM440 ")
                            sql.Append("SET ")
                            sql.Append(" DEPARTFLG = '").Append(IIf(grd_ItemList(lngCnt, 39) = True, "1", "0")).Append("', ")
                            sql.Append(" UPDID = '").Append(GC_UPDID).Append("', ")
                            sql.Append(" UPDYMD = GETDATE() ")
                            sql.Append("WHERE GOODSCD = '").Append(grd_ItemList(lngCnt, 1)).Append("' ")
                        Else
                            sql.Append("INSERT INTO TPM440 ( ")
                            sql.Append(" GOODSCD, ")
                            sql.Append(" DEPARTFLG, ")
                            sql.Append(" UPDID, ")
                            sql.Append(" UPDYMD ")
                            sql.Append(") VALUES ( ")
                            sql.Append(" '").Append(grd_ItemList(lngCnt, 1)).Append("', ")
                            sql.Append(" '").Append(IIf(grd_ItemList(lngCnt, 39) = True, "1", "0")).Append("', ")
                            sql.Append(" '").Append(GC_UPDID).Append("', ")
                            sql.Append(" GETDATE() ")
                            sql.Append(") ")
                        End If

                        If Not GF_UpdData(sql.ToString()) Then
                            Call GF_RollbackTrans()
                            Exit Function
                        End If
                    End If
                    ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------

                Else
                    'çXêVÇ≥ÇÍÇƒÇ»Ç¢è§ïiÇ≈ÅATPM260Ç…ìoò^Ç≥ÇÍÇƒÇ¢Ç»Ç¢èÍçáÅAêVÇµÇ≠ìoò^Ç∑ÇÈ
                    '------------------------------
                    ' èâä˙âª
                    '------------------------------
                    objData2 = New DataSet()

                    '------------------------------
                    ' TPM260ìoò^èàóù
                    '------------------------------
                    strSQL = ""
                    strSQL = strSQL & "SELECT GOODSCD,"
                    strSQL = strSQL & "       TAXPRICE"
                    strSQL = strSQL & "  FROM TPM260"
                    strSQL = strSQL & " WHERE GOODSCD = '" & grd_ItemList(lngCnt, 1) & "'"

                    If Not GF_GetData(strSQL, objData2) Then
                        Exit Function
                    End If
                    If objData2.Tables("com").Rows.Count > 0 Then

                    Else
                        ' Insert
                        strSQL = ""
                        strSQL = strSQL & "INSERT INTO TPM260 VALUES("
                        strSQL = strSQL & "'" & Trim(grd_ItemList(lngCnt, 1)) & "',"   ' GOODSCD
                        strSQL = strSQL & CInt(Trim(grd_ItemList(lngCnt, 27))) & ","  ' TAXPRICE
                        strSQL = strSQL & "'" & GC_UPDID & "',"                        ' UPDID
                        strSQL = strSQL & "'" & Now & "')"                             ' UPDYMD

                        If Not GF_UpdData(strSQL) Then
                            Call GF_RollbackTrans()
                            Exit Function
                        End If

                    End If

                    'çXêVÇ≥ÇÍÇƒÇ»Ç¢è§ïiÇ≈ÅATPM320Ç…ìoò^Ç≥ÇÍÇƒÇ¢Ç»Ç¢èÍçáÅAêVÇµÇ≠ìoò^Ç∑ÇÈ
                    '------------------------------
                    ' èâä˙âª
                    '------------------------------
                    objData2 = New DataSet()

                    '------------------------------
                    ' TPM320ìoò^èàóù
                    '------------------------------
                    strSQL = ""
                    strSQL = strSQL & "SELECT GOODSCD,"
                    strSQL = strSQL & "       TAXKIND"
                    strSQL = strSQL & "  FROM TPM320"
                    strSQL = strSQL & " WHERE GOODSCD = '" & grd_ItemList(lngCnt, 1) & "'"

                    If Not GF_GetData(strSQL, objData) Then
                        Exit Function
                    End If

                    If objData.Tables("com").Rows.Count > 0 Then
                    Else
                        ' Insert
                        strSQL = ""
                        strSQL = strSQL & "INSERT INTO TPM320 VALUES("
                        strSQL = strSQL & "'" & Trim(grd_ItemList(lngCnt, 1)) & "',"   ' GOODSCD
                        strSQL = strSQL & "'" & IIf(Trim(grd_ItemList(lngCnt, 37)) = "1", "1", "0") & "',"   ' TAXKIND
                        strSQL = strSQL & "'" & GC_UPDID & "',"                        ' UPDID
                        strSQL = strSQL & "'" & Now & "')"                             ' UPDYMD

                        If Not GF_UpdData(strSQL) Then
                            Call GF_RollbackTrans()
                            Exit Function
                        End If

                        'ê≈éÌï Ç™ñ¢ê›íËÇÃèÍçáÇÕèâä˙íl("äOê≈")Çê›íËÇ∑ÇÈ
                        If Trim(grd_ItemList(lngCnt, 37)) = "" Then
                            grd_ItemList(lngCnt, 37) = "0"
                        End If
                    End If

                    ' 2018.08.03 ñ{ïîîzêM
                    ' ñ{ïîîzêMëŒâû
                    If Trim$(strDelivaryFlg) = "1" Or strDelivaryFlg = "2" Or strDelivaryFlg = "3" Then

                        'çXêVÇ≥ÇÍÇƒÇ»Ç¢è§ïiÇ≈ÅATPM330Ç…ìoò^Ç≥ÇÍÇƒÇ¢Ç»Ç¢èÍçáÅAêVÇµÇ≠ìoò^Ç∑ÇÈ
                        '------------------------------
                        ' èâä˙âª
                        '------------------------------
                        objData = New DataSet()

                        '------------------------------
                        ' TPM330ìoò^èàóù
                        '------------------------------
                        strSQL = ""
                        strSQL = strSQL & "SELECT GOODSCD,"
                        strSQL = strSQL & "       ENABLEDFLG"
                        strSQL = strSQL & "  FROM TPM330"
                        strSQL = strSQL & " WHERE GOODSCD = '" & grd_ItemList(lngCnt, 1) & "'"

                        If Not GF_GetData(strSQL, objData) Then
                            Exit Function
                        End If

                        If objData.Tables("com").Rows.Count > 0 Then
                        Else
                            ' Insert
                            strSQL = ""
                            strSQL = strSQL & "INSERT INTO TPM330 VALUES("
                            strSQL = strSQL & "'" & Trim(grd_ItemList(lngCnt, 1)) & "',"   ' GOODSCD
                            strSQL = strSQL & "'0',"                                       ' ENABLEDFLG
                            strSQL = strSQL & "'" & GC_UPDID & "',"                        ' UPDID
                            strSQL = strSQL & "'" & Now & "')"                             ' UPDYMD

                            If Not GF_UpdData(strSQL) Then
                                Call GF_RollbackTrans()
                                Exit Function
                            End If

                        End If

                        'çXêVÇ≥ÇÍÇƒÇ»Ç¢è§ïiÇ≈ÅATPM340Ç…ìoò^Ç≥ÇÍÇƒÇ¢Ç»Ç¢èÍçáÅAêVÇµÇ≠ìoò^Ç∑ÇÈ
                        '------------------------------
                        ' èâä˙âª
                        '------------------------------
                        objData = New DataSet()

                        '------------------------------
                        ' TPM340ìoò^èàóù
                        '------------------------------
                        strSQL = ""
                        strSQL = strSQL & "SELECT GOODSCD,"
                        strSQL = strSQL & "       COST"
                        strSQL = strSQL & "  FROM TPM340"
                        strSQL = strSQL & " WHERE GOODSCD = '" & grd_ItemList(lngCnt, 1) & "'"

                        If Not GF_GetData(strSQL, objData) Then
                            Exit Function
                        End If

                        If objData.Tables("com").Rows.Count > 0 Then
                        Else
                            ' Insert
                            strSQL = ""
                            strSQL = strSQL & "INSERT INTO TPM340 VALUES("
                            strSQL = strSQL & "'" & Trim(grd_ItemList(lngCnt, 1)) & "',"                                                ' GOODSCD
                            strSQL = strSQL & "'" & IIf(Trim(grd_ItemList(lngCnt, 38)) = "", 0, Trim(grd_ItemList(lngCnt, 38))) & "',"  ' COST
                            strSQL = strSQL & "'" & GC_UPDID & "',"                                                                     ' UPDID
                            strSQL = strSQL & "'" & Now & "')"                                                                          ' UPDYMD

                            If Not GF_UpdData(strSQL) Then
                                Call GF_RollbackTrans()
                                Exit Function
                            End If

                        End If

                        'çXêVÇ≥ÇÍÇƒÇ»Ç¢è§ïiÇ≈ÅATPM350Ç…ìoò^Ç≥ÇÍÇƒÇ¢Ç»Ç¢èÍçáÅAêVÇµÇ≠ìoò^Ç∑ÇÈ
                        '------------------------------
                        ' èâä˙âª
                        '------------------------------
                        objData = New DataSet()

                        '------------------------------
                        ' TPM350ìoò^èàóù
                        '------------------------------
                        strSQL = ""
                        strSQL = strSQL & "SELECT GOODSCD,"
                        strSQL = strSQL & "       DELIVARYFLG"
                        strSQL = strSQL & "  FROM TPM350"
                        strSQL = strSQL & " WHERE GOODSCD = '" & grd_ItemList(lngCnt, 1) & "'"

                        If Not GF_GetData(strSQL, objData) Then
                            Exit Function
                        End If

                        If objData.Tables("com").Rows.Count > 0 Then
                        Else
                            ' Insert
                            strSQL = ""
                            strSQL = strSQL & "INSERT INTO TPM350 VALUES("
                            strSQL = strSQL & "'" & Trim(grd_ItemList(lngCnt, 1)) & "',"   ' GOODSCD
                            strSQL = strSQL & "'0',"                                       ' DELIVARYFLG
                            strSQL = strSQL & "'" & GC_UPDID & "',"                        ' UPDID
                            strSQL = strSQL & "'" & Now & "')"                             ' UPDYMD

                            If Not GF_UpdData(strSQL) Then
                                Call GF_RollbackTrans()
                                Exit Function
                            End If

                        End If

                    End If
                    ' ñ{ïîîzêMëŒâû
                    ' 2018.08.03 ñ{ïîîzêM

                    ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------
                    If LF_ChkLaneFlg() = "1" Then
                        Dim sql As New System.Text.StringBuilder()

                        ' TPM440Ç…UPDATEÇ∑ÇÈÉåÉRÅ[ÉhÇ™ë∂ç›Ç∑ÇÍÇŒUPDATEÇÅAÇ»ÇØÇÍÇŒINSERTÇçsÇ§
                        If LF_GetTPM440(grd_ItemList(lngCnt, 1)) Then
                            sql.Append("UPDATE TPM440 ")
                            sql.Append("SET ")
                            sql.Append(" DEPARTFLG = '").Append(IIf(grd_ItemList(lngCnt, 39) = True, "1", "0")).Append("', ")
                            sql.Append(" UPDID = '").Append(GC_UPDID).Append("', ")
                            sql.Append(" UPDYMD = GETDATE() ")
                            sql.Append("WHERE GOODSCD = '").Append(grd_ItemList(lngCnt, 1)).Append("' ")
                        Else
                            sql.Append("INSERT INTO TPM440 ( ")
                            sql.Append(" GOODSCD, ")
                            sql.Append(" DEPARTFLG, ")
                            sql.Append(" UPDID, ")
                            sql.Append(" UPDYMD ")
                            sql.Append(") VALUES ( ")
                            sql.Append(" '").Append(grd_ItemList(lngCnt, 1)).Append("', ")
                            sql.Append(" '").Append(IIf(grd_ItemList(lngCnt, 39) = True, "1", "0")).Append("', ")
                            sql.Append(" '").Append(GC_UPDID).Append("', ")
                            sql.Append(" GETDATE() ")
                            sql.Append(") ")
                        End If

                        If Not GF_UpdData(sql.ToString()) Then
                            Call GF_RollbackTrans()
                            Exit Function
                        End If
                    End If
                    ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------

                End If
            Next
        End With

        '------------------------------
        ' ÉgÉâÉìÉUÉNÉVÉáÉìämíË
        '------------------------------
        If Not GF_CommitTrans() Then
            Call GF_RollbackTrans()
            Exit Function
        End If

        '------------------------------
        ' ï‘ãpílê›íË
        '------------------------------
        LF_UpdTPM010 = True

    End Function

    ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------
    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïiÉRÅ[Éhë∂ç›óLñ≥îªíËèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅFstrGoodsCd:è§ïiÉRÅ[Éh
    ' Å@ñﬂ ÇË ílÅFTrue:óLÇËÅAFalse:ñ≥Çµ
    ' Å@óöÅ@Å@óÅF2018.12.18 ÉNÉåÉXÉRñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM440(ByVal strGoodsCd As String) As Boolean
        Dim blRtn As Boolean = False

        Dim sql As New System.Text.StringBuilder()

        sql.Append("SELECT COUNT(GOODSCD) AS COUNT ")
        sql.Append("  FROM TPM440 ")
        sql.Append(" WHERE GOODSCD = '").Append(strGoodsCd).Append("' ")

        Dim objData As New DataSet()

        If Not GF_GetData(sql.ToString(), objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows(0)("COUNT") > 0 Then
            blRtn = True
        End If

        Return blRtn
    End Function
    ' --- (2018.12.18) ì¡ã}ÉåÅ[ÉìòAåg --------------

    ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„
    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFîÃë£ÉRÅ[Éhï‘ãpèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2017.01.01 ÉNÉåÉXÉRñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Function LS_RtnPtn(ByVal pcodeid As String) As String


        LS_RtnPtn = ""

        If pcodeid = " " Then

            pcodeid = 0

        ElseIf Not IsNumeric(pcodeid) Then

        ElseIf CInt(pcodeid) > 9 Then

            Select Case pcodeid
                Case 10
                    pcodeid = "A"
                Case 11
                    pcodeid = "B"
                Case 12
                    pcodeid = "C"
                Case 13
                    pcodeid = "D"
                Case 14
                    pcodeid = "E"
                Case 15
                    pcodeid = "F"
                Case 16
                    pcodeid = "G"
            End Select

        End If

        LS_RtnPtn = pcodeid

    End Function
    ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„

    ' 2017.11.01 ñ{ïîîzêM ÉNÉåÉXÉRñkó§ ìcë„
    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïièÓïÒï“èWãñâ¬ÉtÉâÉOï‘ãpèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2017.11.01 ÉNÉåÉXÉRñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Function LS_GoodsEnabled(ByVal pgoodscd As String) As Boolean

        Dim strSQL As String = ""
        Dim objData As New DataSet
        Dim objRow As DataRow = Nothing

        LS_GoodsEnabled = False

        Try

            strSQL = ""
            strSQL = strSQL & " SELECT ENABLEDFLG"
            strSQL = strSQL & " FROM TPM330"
            strSQL = strSQL & " WHERE GOODSCD = '" & pgoodscd & "'"

            If Not GF_GetData(strSQL, objData) Then
                Exit Function
            End If

            If Not GF_GetRows(objData, 0, objRow) Then
                Exit Function
            End If

            If Trim$(objRow("ENABLEDFLG")) = "1" Then
                LS_GoodsEnabled = True
            End If

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Function

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GoodsEnabled")
    End Function

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïièÓïÒï“èWïsâ¬èàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2017.11.01 ÉNÉåÉXÉRñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Function LS_GoodsInfoONOFF(ByVal pmode As Boolean) As Boolean

        '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
        Dim TICKETUSE As String = GF_GetAppInfo("TICKETUSE")
        Dim HTLNMUSE As String = GF_GetAppInfo("HTLNMUSE")
        '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

        LS_GoodsInfoONOFF = False

        Try

            If pmode Then

                txt_Price.Enabled = True

                tax_Price.Enabled = True

                lbl_KCP1.Enabled = True
                lbl_KCP2.Enabled = True
                lbl_KCP3.Enabled = True
                lbl_KCP4.Enabled = True

                btn_KPSet.Enabled = True

                txt_TPGoodsNM.Enabled = True
                txt_TPGoodsNM2.Enabled = True
                txt_ExpNoteJ.Enabled = True

                'ëΩåæåÍã@î\ëŒâû
                If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                    txt_TPGoodsNM_A.Enabled = True
                    txt_TPGoodsNM2_A.Enabled = True
                    txt_EXPNOTEJ_A.Enabled = True
                    txt_TPGoodsNM_B.Enabled = True
                    txt_TPGoodsNM2_B.Enabled = True
                    txt_EXPNOTEJ_B.Enabled = True
                    txt_TPGoodsNM_C.Enabled = True
                    txt_TPGoodsNM2_C.Enabled = True
                    txt_EXPNOTEJ_C.Enabled = True

                    If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) < 2 Then
                        txt_TPGoodsNM_B.Enabled = False
                        txt_TPGoodsNM2_B.Enabled = False
                        txt_EXPNOTEJ_B.Enabled = False
                    End If
                    If CInt(GF_GetAppInfo3("MULTI_LING_CNT")) < 3 Then
                        txt_TPGoodsNM_C.Enabled = False
                        txt_TPGoodsNM2_C.Enabled = False
                        txt_EXPNOTEJ_C.Enabled = False
                    End If
                End If

                cbo_OP1.Enabled = True
                cbo_OP2.Enabled = True
                cbo_OP3.Enabled = True
                cbo_OP4.Enabled = True
                cbo_OP5.Enabled = True
                cbo_OP6.Enabled = True
                cbo_OP7.Enabled = True
                cbo_OP8.Enabled = True
                cbo_OP9.Enabled = True
                cbo_OP10.Enabled = True
                cbo_OP11.Enabled = True
                cbo_OP12.Enabled = True

                txt_HTLNM1.Enabled = True
                txt_HTLNM2.Enabled = True
                txt_GoodsNMJ4.Enabled = True
                '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
                If TICKETUSE = "1" Then
                    txt_TECKCPNM3.Enabled = True
                End If
                If HTLNMUSE = "0" Then
                    txt_HTLNM5.Enabled = True
                End If
                '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

                cmbPTN1.Enabled = True
                cmbPTN2.Enabled = True
                cmb_Bumon.Enabled = True

                If GF_GetAppInfo3("SEARCH_NUM_FLG") = "1" Then
                    txt_searchNumber.Enabled = True
                End If

                If GF_GetAppInfo3("CNWH_GAMEFLG") = "1" Then
                    chk_game.Enabled = True
                End If

                ccp_check.Enabled = True
                chk_Status0.Enabled = True
                chk_Status1.Enabled = True
                chk_Status2.Enabled = True
                chk_Status3.Enabled = True

                chk_TaxKind0.Enabled = True
                chk_TaxKind1.Enabled = True

                txt_SelRow.Enabled = True

                btn_PicClr.Enabled = True
                btn_SelFol.Enabled = True

                lblUnitPrice.Enabled = True
                txtUnitPrice.Enabled = True
                lblUntEn.Enabled = True

            Else
                If GF_GetAppInfo3("SV_PRICE_CHECK_FLG") = "1" Then
                    txt_Price.Enabled = False
                    tax_Price.Enabled = False
                Else
                    txt_Price.Enabled = True
                    tax_Price.Enabled = True
                End If

                If GF_GetAppInfo3("SV_KCP_CHECK_FLG") = "1" Then
                    lbl_KCP1.Enabled = False
                    lbl_KCP2.Enabled = False
                    lbl_KCP3.Enabled = False
                    lbl_KCP4.Enabled = False
                    btn_KPSet.Enabled = False
                Else
                    lbl_KCP1.Enabled = True
                    lbl_KCP2.Enabled = True
                    lbl_KCP3.Enabled = True
                    lbl_KCP4.Enabled = True
                    btn_KPSet.Enabled = True
                End If

                txt_TPGoodsNM.Enabled = False
                txt_TPGoodsNM2.Enabled = False
                txt_ExpNoteJ.Enabled = False

                'ëΩåæåÍã@î\ëŒâû
                If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then
                    txt_TPGoodsNM_A.Enabled = False
                    txt_TPGoodsNM2_A.Enabled = False
                    txt_EXPNOTEJ_A.Enabled = False
                    txt_TPGoodsNM_B.Enabled = False
                    txt_TPGoodsNM2_B.Enabled = False
                    txt_EXPNOTEJ_B.Enabled = False
                    txt_TPGoodsNM_C.Enabled = False
                    txt_TPGoodsNM2_C.Enabled = False
                    txt_EXPNOTEJ_C.Enabled = False
                End If

                cbo_OP1.Enabled = False
                cbo_OP2.Enabled = False
                cbo_OP3.Enabled = False
                cbo_OP4.Enabled = False
                cbo_OP5.Enabled = False
                cbo_OP6.Enabled = False
                cbo_OP7.Enabled = False
                cbo_OP8.Enabled = False
                cbo_OP9.Enabled = False
                cbo_OP10.Enabled = False
                cbo_OP11.Enabled = False
                cbo_OP12.Enabled = False

                txt_HTLNM1.Enabled = False
                txt_HTLNM2.Enabled = False
                txt_GoodsNMJ4.Enabled = False

                '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
                If TICKETUSE = "1" Then
                    txt_TECKCPNM3.Enabled = False
                End If
                If HTLNMUSE = "0" Then
                    txt_HTLNM5.Enabled = False
                End If
                '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

                cmbPTN1.Enabled = False
                cmbPTN2.Enabled = False
                cmb_Bumon.Enabled = False

                txt_searchNumber.Enabled = False
                chk_game.Enabled = False
                ccp_check.Enabled = False
                chk_Status0.Enabled = False
                chk_Status1.Enabled = False
                chk_Status2.Enabled = False
                chk_Status3.Enabled = False

                chk_TaxKind0.Enabled = False
                chk_TaxKind1.Enabled = False

                txt_SelRow.Enabled = False

                btn_PicClr.Enabled = False
                btn_SelFol.Enabled = False

                lblUnitPrice.Enabled = False
                txtUnitPrice.Enabled = False
                lblUntEn.Enabled = False

            End If

            ' Gert 03/02
            If (pmode = False) Then
                txt_TPGoodsNM.Enabled = (L_EnabledFlags.ENABLED_GOODSNMJ2 = "1")
                txt_TPGoodsNM2.Enabled = (L_EnabledFlags.ENABLED_GOODSNMJ2 = "1")
                txt_GoodsNMJ4.Enabled = (L_EnabledFlags.ENABLED_GOODSNMJ4 = "1")
                btn_PicClr.Enabled = (L_EnabledFlags.ENABLED_IMAGEDATA = "1")
                btn_SelFol.Enabled = (L_EnabledFlags.ENABLED_IMAGEDATA = "1")
                txt_ExpNoteJ.Enabled = (L_EnabledFlags.ENABLED_JEXPNOTEJ = "1")
                cbo_OP1.Enabled = (L_EnabledFlags.ENABLED_SCPNO01_04 = "1")
                cbo_OP2.Enabled = (L_EnabledFlags.ENABLED_SCPNO01_04 = "1")
                cbo_OP3.Enabled = (L_EnabledFlags.ENABLED_SCPNO01_04 = "1")
                cbo_OP4.Enabled = (L_EnabledFlags.ENABLED_SCPNO01_04 = "1")
                tax_Price.Enabled = (L_EnabledFlags.ENABLED_TAXPRICE = "1")
                txt_Price.Enabled = (L_EnabledFlags.ENABLED_TAXPRICE = "1")
                lbl_KCP1.Enabled = (L_EnabledFlags.ENABLED_KCPSTATUS = "1")
                lbl_KCP2.Enabled = (L_EnabledFlags.ENABLED_KCPSTATUS = "1")
                lbl_KCP3.Enabled = (L_EnabledFlags.ENABLED_KCPSTATUS = "1")
                lbl_KCP4.Enabled = (L_EnabledFlags.ENABLED_KCPSTATUS = "1")
                btn_KPSet.Enabled = (L_EnabledFlags.ENABLED_KCPSTATUS = "1")
            End If


            LS_GoodsInfoONOFF = True

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Function

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GoodsInfoOFF")
    End Function
    ' 2017.11.01 ñ{ïîîzêM ÉNÉåÉXÉRñkó§ ìcë„

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFÉtÉHÉãÉ_éQè∆É{É^Éìâüâ∫éûèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub btn_SelFol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelFol.Click

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim objFolder As New BrowseFolder()
        Dim strSelPath As String = Nothing

        '------------------------------
        ' èâä˙ílê›íË
        '------------------------------
        Try
            strSelPath = objFolder.BrowseDialog("ÉtÉHÉãÉ_ÇéwíËÇµÇƒÇ≠ÇæÇ≥Ç¢", Me)
            If strSelPath = g_udtAppConfig.strImgPath Then
                Call GF_Msg("E02", "", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                txt_PicPath.Text = strSelPath
                If Len(Trim$(txt_PicPath.Text)) <> 0 Then
                    Call LS_GridSetup2()
                End If
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_SelFol_Click")
    End Sub


    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFäÑïtâÊëúâèúÉ{É^Éìâüâ∫éûèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2011.11.04 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub btn_PicClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PicClr.Click

        Call LS_ItemImageSet()

    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïiâÊëúÉtÉHÉãÉ_ì‡ ñ¢égópâÊëúÉtÉ@ÉCÉãçÌèúèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Function LF_DelUnuseFile() As Boolean

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim strSQL As String = Nothing
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strUFile() As String = Nothing
        Dim strFile As String = Nothing
        Dim strItemPath As String = Nothing
        Dim strWork As String = Nothing
        Dim blnFound As Boolean
        Dim objFileInfo As System.IO.FileInfo = Nothing

        '------------------------------
        ' èâä˙ílê›íË
        '------------------------------
        LF_DelUnuseFile = False

        '------------------------------
        ' égópíÜâÊëúÉtÉ@ÉCÉãàÍóóéÊìæ
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT IMAGEDATA"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " WHERE LEN(LTRIM(IMAGEDATA)) <> 0"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If
            ReDim Preserve strUFile(lngCnt)
            strUFile(lngCnt) = Trim$(objRows("IMAGEDATA"))

            lngCnt = lngCnt + 1
        End While

        Try
            '------------------------------
            ' âÊëúÉtÉ@ÉCÉãégópíÜîªíË
            '------------------------------
            strItemPath = GF_GetAppInfo("ITEM_PATH")
            For Each strFile In System.IO.Directory.GetFiles(strItemPath)
                blnFound = False
                If Not IsNothing(strUFile) Then
                    objFileInfo = New System.IO.FileInfo(strFile)
                    For Each strWork In strUFile
                        If objFileInfo.Name = strWork Or _
                           objFileInfo.Name = "S_" & strWork Then
                            blnFound = True
                        End If
                    Next
                    objFileInfo = Nothing
                End If

                '------------------------------
                ' ñ¢égópÉtÉ@ÉCÉãÇ≈Ç†ÇÍÇŒçÌèú
                '------------------------------
                If Not blnFound Then
                    Call System.IO.File.SetAttributes(strFile, IO.FileAttributes.Normal)
                    Call System.IO.File.Delete(strFile)
                End If
            Next
        Catch
            Exit Function
        End Try

        '------------------------------
        ' ï‘ãpílê›íË
        '------------------------------
        LF_DelUnuseFile = True

    End Function

    Private Sub LS_CommitCheck()
        'Call LS_WriteRetItemInfo("", False) 'Gert 04/01

        'Dim objCell As DataGridCell
        'Dim lngCnt As Long

        'lngCnt = grd_ItemList.CurrentCell.RowNumber
        'If lngCnt = 0 Or lngCnt <> (GF_GetRowCnt(grd_ItemList) - 1) Then
        '    objCell.RowNumber = GF_GetRowCnt(grd_ItemList) - 1
        'Else
        '    objCell.RowNumber = 0
        'End If

        'objCell.ColumnNumber = 7
        'grd_ItemList.CurrentCell = objCell

        'With objCell
        '    .ColumnNumber = 7
        '    .RowNumber = lngCnt
        'End With
        'grd_ItemList.CurrentCell = objCell
    End Sub

    Private Sub LS_SetGridToTop()
        Dim objCell As DataGridCell
        Dim lngCnt As Long

        lngCnt = grd_ItemList.CurrentCell.RowNumber
        If lngCnt = 0 Or lngCnt <> (GF_GetRowCnt(grd_ItemList) - 1) Then
            objCell.RowNumber = GF_GetRowCnt(grd_ItemList) - 1
        Else
            objCell.RowNumber = 0
        End If

        objCell.ColumnNumber = 7
        grd_ItemList.CurrentCell = objCell

        With objCell
            .ColumnNumber = 7
            .RowNumber = lngCnt
        End With
        grd_ItemList.CurrentCell = objCell
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFÉtÉHÅ[ÉÄÉNÉçÅ[ÉYéûèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub CNL1530_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Call LS_CommitCheck() 'Gert 02/03
        e.Cancel = Not LF_ChkSave(False, True)
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅF[ÉÅÉjÉÖÅ[] - [ï€ë∂] âüâ∫éûèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click

        '2016.04.25 ìcë„
        If Not LS_CheckKCP() Then ' è§ïièoóÕêÊÉ`ÉFÉbÉN
            btn_KPSet.Focus()
            Exit Sub
        End If
        '2016.04.25 ìcë„

        Call LS_CommitCheck()
        Call LS_SaveData()
        Call LS_SetGridToTop()

        '------------------------------
        ' FUMENUçXêV
        '------------------------------
        If GF_GetAppInfo("OES_TOOL_VER_CNL1501") = "0" Then
            Call LS_UpdFUMENU()
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅF[ï€ë∂]É{É^Éìâüâ∫éûèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click

        '2016.04.25 ìcë„
        If Not LS_CheckKCP() Then ' è§ïièoóÕêÊÉ`ÉFÉbÉN
            btn_KPSet.Focus()
            Exit Sub
        End If
        '2016.04.25 ìcë„

        Call LS_CommitCheck()
        Call LS_SaveData()
        Call LS_SetGridToTop()

        '------------------------------
        ' FUMENUçXêV
        '------------------------------
        If GF_GetAppInfo("OES_TOOL_VER_CNL1501") = "0" Then
            Call LS_UpdFUMENU()
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFKCPSTATUSämîFèàóù
    ' Å@ã@î\äTóvÅFÉåÅ[ÉìêUÇËï™ÇØî‘çÜÇÃÇ›ÇÃê›íËÇÕNG(í«â¡)
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2016.04.25 ÉNÉåÉXÉRñkó§ êVãKçÏê¨
    '             2018.07.03 ÉNÉåÉXÉRñkó§ èCê≥
    ' --------------------------------------------------------------------------------
    Private Function LS_CheckKCP() As Boolean

        Dim lngCnt As Integer
        Dim i As Integer
        Dim KcpStr As String
        Dim GoodsNM As String
        Dim GoodsCD As String
        Dim int As Integer
        ' 2018.07.03 TECÉåÅ[ÉìêUÇËï™ÇØ
        Dim strLEENKCPNO_L As String = ""
        Dim strLEENKCPNO_L2 As String = ""
        Dim strLEENKCPNO_R As String = ""
        Dim strLEENKCPNO_R2 As String = ""
        ' ---------- 2020/03/09 ÉåÅ[ÉìêUÇËï™ÇØ20â”èäëŒâû(START) ----------
        Dim strLEENKCPNO_05 As String = ""
        Dim strLEENKCPNO_06 As String = ""
        Dim strLEENKCPNO_07 As String = ""
        Dim strLEENKCPNO_08 As String = ""
        Dim strLEENKCPNO_09 As String = ""
        Dim strLEENKCPNO_10 As String = ""
        Dim strLEENKCPNO_11 As String = ""
        Dim strLEENKCPNO_12 As String = ""
        Dim strLEENKCPNO_13 As String = ""
        Dim strLEENKCPNO_14 As String = ""
        Dim strLEENKCPNO_15 As String = ""
        Dim strLEENKCPNO_16 As String = ""
        Dim strLEENKCPNO_17 As String = ""
        Dim strLEENKCPNO_18 As String = ""
        Dim strLEENKCPNO_19 As String = ""
        Dim strLEENKCPNO_20 As String = ""
        ' ---------- 2020/03/09 ÉåÅ[ÉìêUÇËï™ÇØ20â”èäëŒâû(END) ----------
        Dim strKCPNO As String = ""
        Dim aryKCPNO() As String = Nothing
        Dim KcpStr2 As String = ""
        Dim GoodsNM2 As String = ""
        Dim GoodsCD2 As String = ""
        Dim blnLEENKCPNO_L As Boolean
        Dim blnLEENKCPNO_L2 As Boolean
        Dim blnLEENKCPNO_R As Boolean
        Dim blnLEENKCPNO_R2 As Boolean
        ' ---------- 2020/03/09 ÉåÅ[ÉìêUÇËï™ÇØ20â”èäëŒâû(START) ----------
        Dim blnLEENKCPNO_05 As Boolean
        Dim blnLEENKCPNO_06 As Boolean
        Dim blnLEENKCPNO_07 As Boolean
        Dim blnLEENKCPNO_08 As Boolean
        Dim blnLEENKCPNO_09 As Boolean
        Dim blnLEENKCPNO_10 As Boolean
        Dim blnLEENKCPNO_11 As Boolean
        Dim blnLEENKCPNO_12 As Boolean
        Dim blnLEENKCPNO_13 As Boolean
        Dim blnLEENKCPNO_14 As Boolean
        Dim blnLEENKCPNO_15 As Boolean
        Dim blnLEENKCPNO_16 As Boolean
        Dim blnLEENKCPNO_17 As Boolean
        Dim blnLEENKCPNO_18 As Boolean
        Dim blnLEENKCPNO_19 As Boolean
        Dim blnLEENKCPNO_20 As Boolean
        ' ---------- 2020/03/09 ÉåÅ[ÉìêUÇËï™ÇØ20â”èäëŒâû(END) ----------
        ' 2018.07.03 TECÉåÅ[ÉìêUÇËï™ÇØ
        Dim strLeenKcpCheckFlg As String = Nothing

        '------------------------------
        ' èâä˙ílê›íË
        '------------------------------
        LS_CheckKCP = True
        KcpStr = ""
        i = 0
        strLeenKcpCheckFlg = GF_GetAppInfo2("LEENKCP_CHECK_FLG")
        strLEENKCPNO_L = GF_GetAppInfo("LEENWAKE_KCPNO_L")
        strLEENKCPNO_L2 = GF_GetAppInfo("LEENWAKE_KCPNO_L2")
        strLEENKCPNO_R = GF_GetAppInfo("LEENWAKE_KCPNO_R")
        strLEENKCPNO_R2 = GF_GetAppInfo("LEENWAKE_KCPNO_R2")
        ' ---------- 2020/03/09 ÉåÅ[ÉìêUÇËï™ÇØ20â”èäëŒâû(START) ----------
        strLEENKCPNO_05 = GF_GetAppInfo("LEENWAKE_KCPNO_05")
        strLEENKCPNO_06 = GF_GetAppInfo("LEENWAKE_KCPNO_06")
        strLEENKCPNO_07 = GF_GetAppInfo("LEENWAKE_KCPNO_07")
        strLEENKCPNO_08 = GF_GetAppInfo("LEENWAKE_KCPNO_08")
        strLEENKCPNO_09 = GF_GetAppInfo("LEENWAKE_KCPNO_09")
        strLEENKCPNO_10 = GF_GetAppInfo("LEENWAKE_KCPNO_10")
        strLEENKCPNO_11 = GF_GetAppInfo("LEENWAKE_KCPNO_11")
        strLEENKCPNO_12 = GF_GetAppInfo("LEENWAKE_KCPNO_12")
        strLEENKCPNO_13 = GF_GetAppInfo("LEENWAKE_KCPNO_13")
        strLEENKCPNO_14 = GF_GetAppInfo("LEENWAKE_KCPNO_14")
        strLEENKCPNO_15 = GF_GetAppInfo("LEENWAKE_KCPNO_15")
        strLEENKCPNO_16 = GF_GetAppInfo("LEENWAKE_KCPNO_16")
        strLEENKCPNO_17 = GF_GetAppInfo("LEENWAKE_KCPNO_17")
        strLEENKCPNO_18 = GF_GetAppInfo("LEENWAKE_KCPNO_18")
        strLEENKCPNO_19 = GF_GetAppInfo("LEENWAKE_KCPNO_19")
        strLEENKCPNO_20 = GF_GetAppInfo("LEENWAKE_KCPNO_20")
        ' ---------- 2020/03/09 ÉåÅ[ÉìêUÇËï™ÇØ20â”èäëŒâû(END) ----------

        blnLEENKCPNO_L = IIf(GF_GetAppInfo2("LEENKCP_L_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_L2 = IIf(GF_GetAppInfo2("LEENKCP_L2_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_R = IIf(GF_GetAppInfo2("LEENKCP_R_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_R2 = IIf(GF_GetAppInfo2("LEENKCP_R2_CHECK_FLG") = "0", True, False)
        ' ---------- 2020/03/09 ÉåÅ[ÉìêUÇËï™ÇØ20â”èäëŒâû(START) ----------
        blnLEENKCPNO_05 = IIf(GF_GetAppInfo2("LEENKCP_05_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_06 = IIf(GF_GetAppInfo2("LEENKCP_06_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_07 = IIf(GF_GetAppInfo2("LEENKCP_07_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_08 = IIf(GF_GetAppInfo2("LEENKCP_08_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_09 = IIf(GF_GetAppInfo2("LEENKCP_09_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_10 = IIf(GF_GetAppInfo2("LEENKCP_10_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_11 = IIf(GF_GetAppInfo2("LEENKCP_11_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_12 = IIf(GF_GetAppInfo2("LEENKCP_12_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_13 = IIf(GF_GetAppInfo2("LEENKCP_13_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_14 = IIf(GF_GetAppInfo2("LEENKCP_14_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_15 = IIf(GF_GetAppInfo2("LEENKCP_15_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_16 = IIf(GF_GetAppInfo2("LEENKCP_16_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_17 = IIf(GF_GetAppInfo2("LEENKCP_17_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_18 = IIf(GF_GetAppInfo2("LEENKCP_18_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_19 = IIf(GF_GetAppInfo2("LEENKCP_19_CHECK_FLG") = "0", True, False)
        blnLEENKCPNO_20 = IIf(GF_GetAppInfo2("LEENKCP_20_CHECK_FLG") = "0", True, False)
        ' ---------- 2020/03/09 ÉåÅ[ÉìêUÇËï™ÇØ20â”èäëŒâû(END) ----------

        CNL2010.L_judge = False

        For lngCnt = 0 To GF_GetRowCnt(grd_ItemList) - 1
            GoodsCD = ""
            GoodsNM = ""
            If grd_ItemList(lngCnt, 14) = GC_TRUE Then                   ' ïœçXÇÃÇ©Ç©Ç¡ÇΩçsÇÃÇ›çXêVëŒè€Ç∆Ç∑ÇÈ
                If Trim$(grd_ItemList(lngCnt, 11)) = "00000000000000000000000000000000" And grd_ItemList(lngCnt, 0) = True And _
                    CInt(Trim$(grd_ItemList(lngCnt, 1))) >= 1 And CInt(Trim$(grd_ItemList(lngCnt, 1))) <= 8999 Then ' è§ïièoóÕêÊÇ™ê›íËÇ≥ÇÍÇƒÇ¢Ç»Ç¢èÍçá
                    If Len(Trim$(grd_ItemList(lngCnt, 9))) = 0 Then
                        GoodsNM = GoodsNM & RTrim$(grd_ItemList(lngCnt, 8))
                    Else
                        GoodsNM = GoodsNM & RTrim$(grd_ItemList(lngCnt, 9))
                    End If

                    If Len(Trim$(grd_ItemList(lngCnt, 10))) = 0 Then
                        GoodsNM = GoodsNM & Space(1)
                    Else
                        GoodsNM = GoodsNM & RTrim$(grd_ItemList(lngCnt, 10))
                    End If

                    GoodsCD = Trim$(grd_ItemList(lngCnt, 1))

                    If i = 0 Then
                        grd_ItemList.CurrentCell = New DataGridCell(lngCnt, -1)
                        i = i + 1
                    End If

                    KcpStr = KcpStr & "è§ïiî‘çÜ:" & GoodsCD & vbCrLf & "è§ïiñºÅ@ :" & GoodsNM & vbCrLf & "" 'è§ïiî‘çÜÅFÅ@Å@è§ïiñº:
                    int = Split(KcpStr, vbNewLine).Length

                    CNL2010.L_judge = True

                    If int >= 30 Then
                        Exit For
                    End If
                End If
            End If

            ' 2018.07.03 TECÉåÅ[ÉìêUÇËï™ÇØ 
            If strLeenKcpCheckFlg = "0" Then
                If grd_ItemList(lngCnt, 14) = GC_TRUE Then
                    If grd_ItemList(lngCnt, 0) = True And CInt(Trim$(grd_ItemList(lngCnt, 1))) >= 1 And CInt(Trim$(grd_ItemList(lngCnt, 1))) <= 8999 Then

                        strKCPNO = LF_GetKCPStat(Trim$(grd_ItemList(lngCnt, 11)))
                        aryKCPNO = Split(strKCPNO, ",")

                        ' ---------- 2020/03/09 ÉåÅ[ÉìêUÇËï™ÇØ20â”èäëŒâû(START) ----------
                        'If Array.IndexOf(aryKCPNO, strLEENKCPNO_L) > -1 Or Array.IndexOf(aryKCPNO, strLEENKCPNO_L2) > -1 Or Array.IndexOf(aryKCPNO, strLEENKCPNO_R) > -1 _
                        '                                                                                                    Or Array.IndexOf(aryKCPNO, strLEENKCPNO_R2) > -1 Then
                        If Array.IndexOf(aryKCPNO, strLEENKCPNO_L) > -1 Or _
                            Array.IndexOf(aryKCPNO, strLEENKCPNO_L2) > -1 Or _
                             Array.IndexOf(aryKCPNO, strLEENKCPNO_R) > -1 Or _
                              Array.IndexOf(aryKCPNO, strLEENKCPNO_R2) > -1 Or _
                               Array.IndexOf(aryKCPNO, strLEENKCPNO_05) > -1 Or _
                                Array.IndexOf(aryKCPNO, strLEENKCPNO_06) > -1 Or _
                                 Array.IndexOf(aryKCPNO, strLEENKCPNO_07) > -1 Or _
                                  Array.IndexOf(aryKCPNO, strLEENKCPNO_08) > -1 Or _
                                   Array.IndexOf(aryKCPNO, strLEENKCPNO_09) > -1 Or _
                                    Array.IndexOf(aryKCPNO, strLEENKCPNO_10) > -1 Or _
                                     Array.IndexOf(aryKCPNO, strLEENKCPNO_11) > -1 Or _
                                      Array.IndexOf(aryKCPNO, strLEENKCPNO_12) > -1 Or _
                                       Array.IndexOf(aryKCPNO, strLEENKCPNO_13) > -1 Or _
                                        Array.IndexOf(aryKCPNO, strLEENKCPNO_14) > -1 Or _
                                         Array.IndexOf(aryKCPNO, strLEENKCPNO_15) > -1 Or _
                                          Array.IndexOf(aryKCPNO, strLEENKCPNO_16) > -1 Or _
                                           Array.IndexOf(aryKCPNO, strLEENKCPNO_17) > -1 Or _
                                            Array.IndexOf(aryKCPNO, strLEENKCPNO_18) > -1 Or _
                                             Array.IndexOf(aryKCPNO, strLEENKCPNO_19) > -1 Or _
                                              Array.IndexOf(aryKCPNO, strLEENKCPNO_20) > -1 Then
                        ' ---------- 2020/03/09 ÉåÅ[ÉìêUÇËï™ÇØ20â”èäëŒâû(END) ----------

                            If aryKCPNO.Length = 1 Then

                                ' ---------- 2020/03/09 ÉåÅ[ÉìêUÇËï™ÇØ20â”èäëŒâû(START) ----------
                                'If (blnLEENKCPNO_L And aryKCPNO(0) = strLEENKCPNO_L) Or (blnLEENKCPNO_L2 And aryKCPNO(0) = strLEENKCPNO_L2) Or _
                                '         (blnLEENKCPNO_R And aryKCPNO(0) = strLEENKCPNO_R) Or (blnLEENKCPNO_R2 And aryKCPNO(0) = strLEENKCPNO_R2) Then
                                If (blnLEENKCPNO_L And aryKCPNO(0) = strLEENKCPNO_L) Or _
                                    (blnLEENKCPNO_L2 And aryKCPNO(0) = strLEENKCPNO_L2) Or _
                                     (blnLEENKCPNO_R And aryKCPNO(0) = strLEENKCPNO_R) Or _
                                      (blnLEENKCPNO_R2 And aryKCPNO(0) = strLEENKCPNO_R2) Or _
                                       (blnLEENKCPNO_05 And aryKCPNO(0) = strLEENKCPNO_05) Or _
                                        (blnLEENKCPNO_06 And aryKCPNO(0) = strLEENKCPNO_06) Or _
                                         (blnLEENKCPNO_07 And aryKCPNO(0) = strLEENKCPNO_07) Or _
                                          (blnLEENKCPNO_08 And aryKCPNO(0) = strLEENKCPNO_08) Or _
                                           (blnLEENKCPNO_09 And aryKCPNO(0) = strLEENKCPNO_09) Or _
                                            (blnLEENKCPNO_10 And aryKCPNO(0) = strLEENKCPNO_10) Or _
                                             (blnLEENKCPNO_11 And aryKCPNO(0) = strLEENKCPNO_11) Or _
                                              (blnLEENKCPNO_12 And aryKCPNO(0) = strLEENKCPNO_12) Or _
                                               (blnLEENKCPNO_13 And aryKCPNO(0) = strLEENKCPNO_13) Or _
                                                (blnLEENKCPNO_14 And aryKCPNO(0) = strLEENKCPNO_14) Or _
                                                 (blnLEENKCPNO_15 And aryKCPNO(0) = strLEENKCPNO_15) Or _
                                                  (blnLEENKCPNO_16 And aryKCPNO(0) = strLEENKCPNO_16) Or _
                                                   (blnLEENKCPNO_17 And aryKCPNO(0) = strLEENKCPNO_17) Or _
                                                    (blnLEENKCPNO_18 And aryKCPNO(0) = strLEENKCPNO_18) Or _
                                                     (blnLEENKCPNO_19 And aryKCPNO(0) = strLEENKCPNO_19) Or _
                                                      (blnLEENKCPNO_20 And aryKCPNO(0) = strLEENKCPNO_20) Then
                                ' ---------- 2020/03/09 ÉåÅ[ÉìêUÇËï™ÇØ20â”èäëŒâû(END) ----------

                                    If Len(Trim$(grd_ItemList(lngCnt, 9))) = 0 Then
                                        GoodsNM2 = GoodsNM2 & RTrim$(grd_ItemList(lngCnt, 8))
                                    Else
                                        GoodsNM2 = GoodsNM2 & RTrim$(grd_ItemList(lngCnt, 9))
                                    End If

                                    If Len(Trim$(grd_ItemList(lngCnt, 10))) = 0 Then
                                        GoodsNM2 = GoodsNM2 & Space(1)
                                    Else
                                        GoodsNM2 = GoodsNM2 & RTrim$(grd_ItemList(lngCnt, 10))
                                    End If

                                    GoodsCD2 = Trim$(grd_ItemList(lngCnt, 1))

                                    ' ÉGÉâÅ[ÉÅÉbÉZÅ[ÉWï\é¶
                                    KcpStr2 = KcpStr2 & "è§ïiî‘çÜ:" & GoodsCD2 & vbCrLf & "è§ïiñºÅ@ :" & GoodsNM2 & vbCrLf & "" 'è§ïiî‘çÜÅFÅ@Å@è§ïiñº:
                                    CNL2010.L_judge = True

                                End If
                            End If
                        End If
                    End If
                End If
            End If
            ' 2018.07.03 TECÉåÅ[ÉìêUÇËï™ÇØ
        Next

        If KcpStr <> "" Then
            GF_Msg("", "è§ïièoóÕêÊÇê›íËÇµÇƒâ∫Ç≥Ç¢ÅB" & vbCrLf & "" & vbCrLf & KcpStr, MsgBoxStyle.OkOnly) '¥◊∞“Øæ∞ºﬁÇÃå„Ç…è§ïi∫∞ƒﬁÅAè§ïiñºÇÇ¬ÇØÇÈ
            LS_CheckKCP = False
        End If

        ' 2018.07.03 TECÉåÅ[ÉìêUÇËï™ÇØ 
        If strLeenKcpCheckFlg = "0" Then
            If KcpStr2 <> "" Then
                GF_Msg("", "è§ïièoóÕêÊÇï°êîéwíËÇµÇƒâ∫Ç≥Ç¢ÅB" & vbCrLf & KcpStr2, MsgBoxStyle.OkOnly) '¥◊∞“Øæ∞ºﬁÇÃå„Ç…è§ïi∫∞ƒﬁÅAè§ïiñºÇÇ¬ÇØÇÈ
                LS_CheckKCP = False
            End If
        End If
        ' 2018.07.03 TECÉåÅ[ÉìêUÇËï™ÇØ 

    End Function

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFKCPSTATUSämîFèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2016.04.25 ÉNÉåÉXÉRñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Function LS_Load_CheckKCP() As Boolean
        Dim lngCnt As Integer
        Dim i As Integer
        Dim KcpStr As String
        Dim GoodsNM As String
        Dim GoodsCD As String
        Dim int As Integer

        LS_Load_CheckKCP = True
        KcpStr = ""
        i = 0

        For lngCnt = 0 To GF_GetRowCnt(grd_ItemList) - 1
            GoodsCD = ""
            GoodsNM = ""
            If Trim$(grd_ItemList(lngCnt, 11)) = "00000000000000000000000000000000" And grd_ItemList(lngCnt, 0) = True And _
                CInt(Trim$(grd_ItemList(lngCnt, 1))) >= 1 And CInt(Trim$(grd_ItemList(lngCnt, 1))) <= 8999 Then ' è§ïièoóÕêÊÇ™ê›íËÇ≥ÇÍÇƒÇ¢Ç»Ç¢èÍçá
                If Len(Trim$(grd_ItemList(lngCnt, 9))) = 0 Then
                    GoodsNM = GoodsNM & RTrim$(grd_ItemList(lngCnt, 8))
                Else
                    GoodsNM = GoodsNM & RTrim$(grd_ItemList(lngCnt, 9))
                End If

                If Len(Trim$(grd_ItemList(lngCnt, 10))) = 0 Then
                    GoodsNM = GoodsNM & Space(1)
                Else
                    GoodsNM = GoodsNM & RTrim$(grd_ItemList(lngCnt, 10))
                End If

                GoodsCD = Trim$(grd_ItemList(lngCnt, 1))

                If i = 0 Then
                    grd_ItemList.CurrentCell = New DataGridCell(lngCnt, -1)
                    i = i + 1
                End If

                KcpStr = KcpStr & "è§ïiî‘çÜ:" & GoodsCD & vbCrLf & "è§ïiñºÅ@ :" & GoodsNM & vbCrLf & "" 'è§ïiî‘çÜÅFÅ@Å@è§ïiñº:
                int = Split(KcpStr, vbNewLine).Length

                grd_ItemList(lngCnt, 0) = False


                If int >= 30 Then
                    Exit For
                End If
            End If
        Next


        If KcpStr <> "" Then
            GF_Msg("", "è§ïièoóÕêÊÇê›íËÇµÇƒâ∫Ç≥Ç¢ÅB" & vbCrLf & "" & vbCrLf & KcpStr, MsgBoxStyle.OkOnly) '¥◊∞“Øæ∞ºﬁÇÃå„Ç…è§ïi∫∞ƒﬁÅAè§ïiñºÇÇ¬ÇØÇÈ
            LS_Load_CheckKCP = False
        End If
    End Function

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFTAKEOUTTYPEämîFèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2019.09.04 ÉNÉåÉXÉRñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Function LS_Load_CheckTAKEOUTTYPE(ByVal pTecDpCodeTo As String) As Boolean
        Dim lngCnt As Integer
        Dim i As Integer
        Dim KcpStr As String
        Dim GoodsNM As String
        Dim GoodsCD As String
        Dim int As Integer

        LS_Load_CheckTAKEOUTTYPE = True
        KcpStr = ""
        i = 0

        For lngCnt = 0 To GF_GetRowCnt(grd_ItemList) - 1
            GoodsCD = ""
            GoodsNM = ""
            ' ïîñÂÇÕÉeÉCÉNÉAÉEÉgÇæÇ™à˘êHÅ^éùÇøãAÇËÇ™ÅuéùÇøãAÇËÅvÇ≈ÇÕÇ»Ç¢èÍçá
            If Trim$(grd_ItemList(lngCnt, 22)) = pTecDpCodeTo And Trim$(grd_ItemList(lngCnt, 50)) <> "2" And grd_ItemList(lngCnt, 0) = True Then
                If Len(Trim$(grd_ItemList(lngCnt, 9))) = 0 Then
                    GoodsNM = GoodsNM & RTrim$(grd_ItemList(lngCnt, 8))
                Else
                    GoodsNM = GoodsNM & RTrim$(grd_ItemList(lngCnt, 9))
                End If

                If Len(Trim$(grd_ItemList(lngCnt, 10))) = 0 Then
                    GoodsNM = GoodsNM & Space(1)
                Else
                    GoodsNM = GoodsNM & RTrim$(grd_ItemList(lngCnt, 10))
                End If

                GoodsCD = Trim$(grd_ItemList(lngCnt, 1))

                If i = 0 Then
                    grd_ItemList.CurrentCell = New DataGridCell(lngCnt, -1)
                    i = i + 1
                End If

                KcpStr = KcpStr & "è§ïiî‘çÜ:" & GoodsCD & vbCrLf & "è§ïiñºÅ@ :" & GoodsNM & vbCrLf & "" 'è§ïiî‘çÜÅFÅ@Å@è§ïiñº:
                int = Split(KcpStr, vbNewLine).Length

                If int >= 30 Then
                    Exit For
                End If
            End If
        Next


        If KcpStr <> "" Then
            GF_Msg("", "ÉeÉCÉNÉAÉEÉgÇÃïîñÂÇ™ëIëÇ≥ÇÍÇƒÇ¢ÇÈâ∫ãLè§ïiÇÃ" & vbCrLf & "Åyà˘êH/éùãAÅzÇÃê›íËÇ™ïsê≥Ç≈Ç∑ÅB" & vbCrLf & "Åyà˘êH/éùãAÅzÇÃê›íËÇÅyéùãAÅzÇ…ïœçXÇµÇƒÇ≠ÇæÇ≥Ç¢ÅB" & vbCrLf & "" & vbCrLf & KcpStr, MsgBoxStyle.OkOnly) '¥◊∞“Øæ∞ºﬁÇÃå„Ç…è§ïi∫∞ƒﬁÅAè§ïiñºÇÇ¬ÇØÇÈ
            LS_Load_CheckTAKEOUTTYPE = False
        End If
    End Function

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFTab_ItemsÉRÉìÉgÉçÅ[Éãèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2016.04.25 ÉNÉåÉXÉRñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub Tab_Items_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab_Items.Leave
        If Not LS_CheckKCP() Then ' è§ïièoóÕêÊÉ`ÉFÉbÉN
            btn_KPSet.Focus()
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅF[ÉÅÉjÉÖÅ[] - [ï¬Ç∂ÇÈ] âüâ∫éûèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click

        'START 2016.04.25 ìcë„
        If Not LS_CheckKCP() Then ' è§ïièoóÕêÊÉ`ÉFÉbÉN
            btn_KPSet.Focus()
            Exit Sub
        End If
        'END 2016.04.25 ìcë„

        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFÉRÉìÉ{É{ÉbÉNÉXëIëéûèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub cbo_SelGroup_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_SelGroup.SelectionChangeCommitted

        Call LS_CommitCheck() 'Gert 04/01
        'txt_SelRow.Text = "0"                                               ' åªç›ëIëçsÇÉ[ÉçÉNÉäÉA(2004.05.25)
        Call LF_ChkSave(False, True)
        Call LS_GridSetup()
    End Sub

    'Private Sub cbo_SelSort_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_SelSort.SelectionChangeCommitted

    '    Call LS_CommitCheck()
    '    txt_SelRow.Text = "0"                                               ' åªç›ëIëçsÇÉ[ÉçÉNÉäÉA(2004.05.25)
    '    Call LF_ChkSave(False)
    '    Call LS_GridSetup()
    'End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFï€ë∂óvî€ämîFèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Function LF_ChkSave(ByVal pChkMode As Boolean, Optional ByVal pWritecurrentitem As Boolean = False) As Boolean

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim objRet As MsgBoxResult

        '------------------------------
        ' èâä˙ílê›íË
        '------------------------------
        LF_ChkSave = False

        '------------------------------
        ' ï€ë∂èàóùóvî€îªíË
        '------------------------------
        If L_blnEditFlg Then                                                ' ï“èWçXêVóLñ≥ÉtÉâÉOîªíË
            If pChkMode Then
                objRet = GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNoCancel)
            Else
                objRet = GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNo)
            End If

            Select Case objRet
                Case MsgBoxResult.Yes
                    Call LS_SaveData()

                    '------------------------------
                    ' FUMENUçXêV
                    '------------------------------
                    If GF_GetAppInfo("OES_TOOL_VER_CNL1501") = "0" Then
                        If Not LS_UpdFUMENU() Then
                            If pWritecurrentitem Then 'Gert 04/01
                                LS_WriteRetItemInfo("", False)
                            End If
                            LF_ChkSave = True
                        End If
                    Else
                        LF_ChkSave = True
                    End If

                    L_blnEditFlg = False
                    btn_Save.BackColor = Color.Empty
                Case MsgBoxResult.No
                    L_blnEditFlg = False
                    btn_Save.BackColor = Color.Empty
                Case MsgBoxResult.Cancel
                    LF_ChkSave = False
                    Exit Function
            End Select
        End If

        '------------------------------
        ' ï‘ãpílê›íË
        '------------------------------
        LF_ChkSave = True

    End Function

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFÇeÇtÇlÇdÇmÇtçXêVèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Function LS_UpdFUMENU() As Boolean

        '------------------------------
        ' èâä˙ílê›íË
        '------------------------------
        LS_UpdFUMENU = False

        '' ÇrÇsÇmÉfÅ[É^èoóÕèàóù
        If Trim$(GF_GetAppInfo("SYS_TYPE")) = "2" Or Trim$(GF_GetAppInfo("SYS_TYPE")) = "3" Then
            ' ST-700-Fà»ëOÇÃVerÇÃèÍçá
            '-- FUMENUë∂ç›É`ÉFÉbÉN
            If Not System.IO.File.Exists(Trim$(GF_GetAppInfo("OES_PATH")) & "\" & Trim$(GF_GetAppInfo("OES_MENUTBL"))) Then
                GF_Msg("", "FUMENU ÉpÉXÇämîFÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
                Exit Function
            End If
            '--- FUMENUçXêV
            If GF_PutFUMENUData() = False Then
                Exit Function
            End If
        End If

        '------------------------------
        ' ï‘ãpílê›íË
        '------------------------------
        LS_UpdFUMENU = True

    End Function


    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFâÊëúägëÂï\é¶èàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub LS_ShowSampleImage(ByVal pFilePath As String)

        Dim objForm As New CNL1531()

        If Len(Trim$(pFilePath)) = 0 Then
            Exit Sub
        End If

        With objForm
            .G_FilePath = pFilePath
            .ShowDialog()
        End With

    End Sub

    ' START 2016.05.12 ìcë„
    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïiä÷òAÉeÉLÉXÉgÉ{ÉbÉNÉX ì¸óÕéûèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅFtxtBox:ÉeÉLÉXÉgÉ{ÉbÉNÉXÉIÉuÉWÉFÉNÉgÅAvbStrConvKind:VbStrConvÉvÉçÉpÉeÉBÅAlngMaxTextLengthAsByte:ÉeÉLÉXÉgì¸óÕâ¬î\ÉoÉCÉgêî
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2016.05.10 ÉNÉåÉXÉRñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub TextBoxTextChanged(ByVal txtBox As TextBox, ByVal vbStrConvKind As VbStrConv, ByVal lngMaxTextLengthAsByte As Long)

        Select Case txtBox.Name
            Case txt_TPGoodsNM.Name, txt_TPGoodsNM2.Name, txt_GoodsNMJ4.Name, txt_ExpNoteJ.Name, UpperBox.Name, LowerBox.Name

                '------------------------------
                ' ì‡ïîïœêîíËã`
                '------------------------------
                Dim lngST As Long

                If txtBox.Modified = False Then Exit Sub
                lngST = txtBox.SelectionStart

                ' 2018.05.21 ìcë„
                If Not GF_GetAppInfo("PRINT_FLG") = "0" Then
                    txtBox.Text = StrConv(txtBox.Text, vbStrConvKind)
                End If

                'txtBox.Text = StrConv(txtBox.Text, vbStrConvKind)
                ' 2018.05.21 ìcë„

                If lngST >= 0 Then txtBox.SelectionStart = lngST

                '------------------------------
                ' ì¸óÕí∑êßå¿
                '------------------------------
                If GF_LenB(txtBox.Text) > lngMaxTextLengthAsByte Then
                    txtBox.Text = GF_MidB(txtBox.Text, 1, lngMaxTextLengthAsByte)
                    txtBox.SelectionStart = GF_LenB(txtBox.Text)
                End If
                Call LS_WriteRetItemInfo()

                'Case txt_ExpNoteJ.Name
                '    If txtBox.Modified = False Then Exit Sub

                '    '------------------------------
                '    ' ì‡ïîïœêîíËã`
                '    '------------------------------
                '    Dim intPos As Integer
                '    Dim lngCrCnt As Long

                '    If Len(txtBox.Text) <> 0 Then
                '        If Mid$(txtBox.Text, Len(txtBox.Text), 1) = vbLf Then
                '            intPos = 1
                '            While intPos <> 0
                '                intPos = InStr(intPos, txtBox.Text, vbCrLf)
                '                If intPos <> 0 Then
                '                    lngCrCnt = lngCrCnt + 1
                '                    intPos = intPos + 1
                '                End If
                '            End While
                '            If lngCrCnt >= 5 Then
                '                txtBox.Text = Mid$(txtBox.Text, 1, Len(txtBox.Text) - 2)
                '                txtBox.SelectionStart = GF_LenB(txtBox.Text)
                '            End If
                '        End If
                '    End If

                '    Call LS_WriteRetItemInfo()

            Case Else

        End Select

    End Sub
    ' END 2016.05.12 ìcë„

    ' START 2016.05.10 ìcë„
    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïiê‡ñæï∂ ì¸óÕéûèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub txt_ExpNoteJ_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ExpNoteJ.TextChanged

        ''------------------------------
        '' ì‡ïîïœêîíËã`
        ''------------------------------
        ''Dim lngST As Long

        'If txt_ExpNoteJ.Modified = False Then
        '    Exit Sub
        'End If

        '' 2014-04-25 2ÉoÉCÉgï∂éöêßå¿âèú
        ''lngST = txt_ExpNoteJ.SelectionStart
        ''txt_ExpNoteJ.Text = StrConv(txt_ExpNoteJ.Text, VbStrConv.Wide)
        ''If lngST >= 0 Then
        ''    txt_ExpNoteJ.SelectionStart = lngST
        ''End If

        ''------------------------------
        '' ì‡ïîïœêîíËã`
        ''------------------------------
        'Dim intPos As Integer
        'Dim lngCrCnt As Long

        'If Len(txt_ExpNoteJ.Text) <> 0 Then
        '    If Mid$(txt_ExpNoteJ.Text, Len(txt_ExpNoteJ.Text), 1) = vbLf Then
        '        intPos = 1
        '        While intPos <> 0
        '            intPos = InStr(intPos, txt_ExpNoteJ.Text, vbCrLf)
        '            If intPos <> 0 Then
        '                lngCrCnt = lngCrCnt + 1
        '                intPos = intPos + 1
        '            End If
        '        End While
        '        If lngCrCnt >= 5 Then
        '            txt_ExpNoteJ.Text = Mid$(txt_ExpNoteJ.Text, 1, Len(txt_ExpNoteJ.Text) - 2)
        '            txt_ExpNoteJ.SelectionStart = GF_LenB(txt_ExpNoteJ.Text)
        '        End If
        '    End If
        'End If

        'Call LS_WriteRetItemInfo()

        'txt_ExpNoteJ.Text = StrConv(txt_ExpNoteJ.Text, VbStrConv.Wide) ' ADD 2016.05.09 ìcë„

        ' 2018.05.21 ìcë„
        If GF_GetAppInfo("PRINT_FLG") = "1" Then
            ' ëSäpì¸óÕ
            Call TextBoxTextChanged(txt_ExpNoteJ, VbStrConv.Wide, 180)
        ElseIf GF_GetAppInfo("PRINT_FLG") = "2" Then
            ' îºäpì¸óÕ
            Call TextBoxTextChanged(txt_ExpNoteJ, VbStrConv.Narrow, 180)
        Else
            Call TextBoxTextChanged(txt_ExpNoteJ, VbStrConv.Wide, 180)
        End If

        'Call TextBoxTextChanged(txt_ExpNoteJ, VbStrConv.Wide, 180)
        ' 2018.05.21 ìcë„

    End Sub
    ' END 2016.05.10 ìcë„

    ' START 2016.04.20 ìcë„ 
    Private Sub txt_ExpNoteJ_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ExpNoteJ.KeyPress

        ' 2018.05.21 ìcë„
        If GF_GetAppInfo("PRINT_FLG") = "1" Then
            ' ëSäpì¸óÕ
            e.KeyChar = StrConv(e.KeyChar, VbStrConv.Wide)
        ElseIf GF_GetAppInfo("PRINT_FLG") = "2" Then
            ' îºäpì¸óÕ
            e.KeyChar = StrConv(e.KeyChar, VbStrConv.Narrow)
        End If

        'Call TextBoxTextChanged(txt_ExpNoteJ, VbStrConv.Wide, 180)
        ' 2018.05.21 ìcë„

    End Sub
    ' END 2016.04.20 ìcë„

    Private Sub txt_ExpNoteJ_A_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_EXPNOTEJ_A.TextChanged

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim lngST As Long

        If txt_EXPNOTEJ_A.Modified = False Then
            Exit Sub
        End If

        lngST = txt_EXPNOTEJ_A.SelectionStart
        txt_EXPNOTEJ_A.Text = StrConv(txt_EXPNOTEJ_A.Text, VbStrConv.None)
        If lngST >= 0 Then
            txt_EXPNOTEJ_A.SelectionStart = lngST
        End If

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim intPos As Integer
        Dim lngCrCnt As Long

        If Len(txt_EXPNOTEJ_A.Text) <> 0 Then
            If Mid$(txt_EXPNOTEJ_A.Text, Len(txt_EXPNOTEJ_A.Text), 1) = vbLf Then
                intPos = 1
                While intPos <> 0
                    intPos = InStr(intPos, txt_EXPNOTEJ_A.Text, vbCrLf)
                    If intPos <> 0 Then
                        lngCrCnt = lngCrCnt + 1
                        intPos = intPos + 1
                    End If
                End While
                If lngCrCnt >= 5 Then
                    txt_EXPNOTEJ_A.Text = Mid$(txt_EXPNOTEJ_A.Text, 1, Len(txt_EXPNOTEJ_A.Text) - 2)
                    txt_EXPNOTEJ_A.SelectionStart = GF_LenB(txt_EXPNOTEJ_A.Text)
                End If
            End If
        End If

        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub txt_ExpNoteJ_B_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_EXPNOTEJ_B.TextChanged

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        'Dim lngST As Long

        If txt_EXPNOTEJ_B.Modified = False Then
            Exit Sub
        End If

        ' 2014-04-25 2ÉoÉCÉgï∂éöêßå¿âèú
        'lngST = txt_EXPNOTEJ_B.SelectionStart
        'txt_EXPNOTEJ_B.Text = StrConv(txt_EXPNOTEJ_B.Text, VbStrConv.None)
        'If lngST >= 0 Then
        '    txt_EXPNOTEJ_B.SelectionStart = lngST
        'End If

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim intPos As Integer
        Dim lngCrCnt As Long

        If Len(txt_EXPNOTEJ_B.Text) <> 0 Then
            If Mid$(txt_EXPNOTEJ_B.Text, Len(txt_EXPNOTEJ_B.Text), 1) = vbLf Then
                intPos = 1
                While intPos <> 0
                    intPos = InStr(intPos, txt_EXPNOTEJ_B.Text, vbCrLf)
                    If intPos <> 0 Then
                        lngCrCnt = lngCrCnt + 1
                        intPos = intPos + 1
                    End If
                End While
                If lngCrCnt >= 5 Then
                    txt_EXPNOTEJ_B.Text = Mid$(txt_EXPNOTEJ_B.Text, 1, Len(txt_EXPNOTEJ_B.Text) - 2)
                    txt_EXPNOTEJ_B.SelectionStart = GF_LenB(txt_EXPNOTEJ_B.Text)
                End If
            End If
        End If
        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub txt_ExpNoteJ_C_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_EXPNOTEJ_C.TextChanged

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        'Dim lngST As Long

        If txt_EXPNOTEJ_C.Modified = False Then
            Exit Sub
        End If

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim intPos As Integer
        Dim lngCrCnt As Long

        If Len(txt_EXPNOTEJ_C.Text) <> 0 Then
            If Mid$(txt_EXPNOTEJ_C.Text, Len(txt_EXPNOTEJ_C.Text), 1) = vbLf Then
                intPos = 1
                While intPos <> 0
                    intPos = InStr(intPos, txt_EXPNOTEJ_C.Text, vbCrLf)
                    If intPos <> 0 Then
                        lngCrCnt = lngCrCnt + 1
                        intPos = intPos + 1
                    End If
                End While
                If lngCrCnt >= 5 Then
                    txt_EXPNOTEJ_C.Text = Mid$(txt_EXPNOTEJ_C.Text, 1, Len(txt_EXPNOTEJ_C.Text) - 2)
                    txt_EXPNOTEJ_C.SelectionStart = GF_LenB(txt_EXPNOTEJ_C.Text)
                End If
            End If
        End If
        Call LS_WriteRetItemInfo()
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïiâÊëúägëÂï\é¶èàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub grd_ItemList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_ItemList.DoubleClick

        Dim objPoint As Point = grd_ItemList.PointToClient(Cursor.Position)
        Dim objHitTest As System.Windows.Forms.DataGrid.HitTestInfo

        objHitTest = grd_ItemList.HitTest(objPoint)
        If objHitTest.Column = 0 Then
            Exit Sub
        End If

        Call LS_ShowSampleImage(grd_ItemList(grd_ItemList.CurrentCell.RowNumber, 2))

    End Sub

    ' START 2016.05.10 ìcë„
    Private Sub txt_TPGoodsNM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TPGoodsNM.TextChanged

        ''------------------------------
        '' ì‡ïîïœêîíËã`
        ''------------------------------
        ''Dim lngST As Long

        'If txt_TPGoodsNM.Modified = False Then
        '    Exit Sub
        'End If

        '' 2014-04-25 2ÉoÉCÉgï∂éöêßå¿âèú
        ''lngST = txt_TPGoodsNM.SelectionStart
        ''txt_TPGoodsNM.Text = StrConv(txt_TPGoodsNM.Text, VbStrConv.Wide)
        ''If lngST >= 0 Then
        ''    txt_TPGoodsNM.SelectionStart = lngST
        ''End If

        ''------------------------------
        '' ì¸óÕí∑êßå¿
        ''------------------------------
        'If GF_LenB(txt_TPGoodsNM.Text) > 20 Then
        '    txt_TPGoodsNM.Text = GF_MidB(txt_TPGoodsNM.Text, 1, 20)
        '    txt_TPGoodsNM.SelectionStart = GF_LenB(txt_TPGoodsNM.Text)
        'End If

        'Call LS_WriteRetItemInfo()

        'txt_TPGoodsNM.Text = StrConv(txt_TPGoodsNM.Text, VbStrConv.Wide) ' ADD 2016.05.09 ìcë„

        ' 2018.05.21 ìcë„
        If GF_GetAppInfo("PRINT_FLG") = "1" Then
            ' ëSäpì¸óÕ
            Call TextBoxTextChanged(txt_TPGoodsNM, VbStrConv.Wide, 20)
        ElseIf GF_GetAppInfo("PRINT_FLG") = "2" Then
            ' îºäpì¸óÕ
            Call TextBoxTextChanged(txt_TPGoodsNM, VbStrConv.Narrow, 20)
        Else
            Call TextBoxTextChanged(txt_TPGoodsNM, VbStrConv.Wide, 20)
        End If

        'Call TextBoxTextChanged(txt_TPGoodsNM, VbStrConv.Wide, 20)
        ' 2018.05.21 ìcë„

    End Sub
    ' END 2016.05.10 ìcë„

    'START 2016.04.20 ìcë„ 
    Private Sub txt_TPGoodsNM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_TPGoodsNM.KeyPress

        ' 2018.05.21 ìcë„
        If GF_GetAppInfo("PRINT_FLG") = "1" Then
            ' ëSäpì¸óÕ
            e.KeyChar = StrConv(e.KeyChar, VbStrConv.Wide)
        ElseIf GF_GetAppInfo("PRINT_FLG") = "2" Then
            ' îºäpì¸óÕ
            e.KeyChar = StrConv(e.KeyChar, VbStrConv.Narrow)
        End If

        'e.KeyChar = StrConv(e.KeyChar, VbStrConv.Wide) 'îºäpì¸óÕêßå¿
        ' 2018.05.21 ìcë„

    End Sub
    'END 2016.04.20 ìcë„

    ' START 2016.05.10 ìcë„
    Private Sub txt_TPGoodsNM2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TPGoodsNM2.TextChanged

        ''------------------------------
        '' ì‡ïîïœêîíËã`
        ''------------------------------
        ''Dim lngST As Long

        'If txt_TPGoodsNM2.Modified = False Then
        '    Exit Sub
        'End If

        '' 2014-04-25 2ÉoÉCÉgï∂éöêßå¿âèú
        ''lngST = txt_TPGoodsNM2.SelectionStart
        ''txt_TPGoodsNM2.Text = StrConv(txt_TPGoodsNM2.Text, VbStrConv.Wide)
        ''If lngST >= 0 Then
        ''    txt_TPGoodsNM2.SelectionStart = lngST
        ''End If

        ''------------------------------
        '' ì¸óÕí∑êßå¿
        ''------------------------------
        'If GF_LenB(txt_TPGoodsNM2.Text) > 20 Then
        '    txt_TPGoodsNM2.Text = GF_MidB(txt_TPGoodsNM2.Text, 1, 20)
        '    txt_TPGoodsNM2.SelectionStart = GF_LenB(txt_TPGoodsNM2.Text)
        'End If

        'Call LS_WriteRetItemInfo()

        'txt_TPGoodsNM2.Text = StrConv(txt_TPGoodsNM2.Text, VbStrConv.Wide) ' ADD 2016.05.09 ìcë„

        ' 2018.05.21 ìcë„
        If GF_GetAppInfo("PRINT_FLG") = "1" Then
            ' ëSäpì¸óÕ
            Call TextBoxTextChanged(txt_TPGoodsNM2, VbStrConv.Wide, 20)
        ElseIf GF_GetAppInfo("PRINT_FLG") = "2" Then
            ' îºäpì¸óÕ
            Call TextBoxTextChanged(txt_TPGoodsNM2, VbStrConv.Narrow, 20)
        Else
            Call TextBoxTextChanged(txt_TPGoodsNM2, VbStrConv.Wide, 20)
        End If

        'Call TextBoxTextChanged(txt_TPGoodsNM2, VbStrConv.Wide, 20)
        ' 2018.05.21 ìcë„

    End Sub
    ' END 2016.05.10 ìcë„

    'START 2016.04.20 ìcë„ 
    Private Sub txt_TPGoodsNM2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_TPGoodsNM2.KeyPress
        ' 2018.05.21 ìcë„
        If GF_GetAppInfo("PRINT_FLG") = "1" Then
            ' ëSäpì¸óÕ
            e.KeyChar = StrConv(e.KeyChar, VbStrConv.Wide)
        ElseIf GF_GetAppInfo("PRINT_FLG") = "2" Then
            ' îºäpì¸óÕ
            e.KeyChar = StrConv(e.KeyChar, VbStrConv.Narrow)
        End If

        'e.KeyChar = StrConv(e.KeyChar, VbStrConv.Wide) 'îºäpì¸óÕêßå¿
        ' 2018.05.21 ìcë„
    End Sub
    'END 2016.04.20 ìcë„

    Private Sub txt_TPGoodsNM_A_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TPGoodsNM_A.TextChanged

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim lngST As Long

        If txt_TPGoodsNM_A.Modified = False Then
            Exit Sub
        End If

        lngST = txt_TPGoodsNM_A.SelectionStart
        txt_TPGoodsNM_A.Text = StrConv(txt_TPGoodsNM_A.Text, VbStrConv.None)
        If lngST >= 0 Then
            txt_TPGoodsNM_A.SelectionStart = lngST
        End If

        '------------------------------
        ' ì¸óÕí∑êßå¿
        '------------------------------
        If GF_LenB(txt_TPGoodsNM_A.Text) > 25 Then
            txt_TPGoodsNM_A.Text = GF_MidB(txt_TPGoodsNM_A.Text, 1, 25)
            txt_TPGoodsNM_A.SelectionStart = GF_LenB(txt_TPGoodsNM_A.Text)
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub txt_TPGoodsNM2_A_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TPGoodsNM2_A.TextChanged

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim lngST As Long

        If txt_TPGoodsNM2_A.Modified = False Then
            Exit Sub
        End If

        lngST = txt_TPGoodsNM2_A.SelectionStart
        txt_TPGoodsNM2_A.Text = StrConv(txt_TPGoodsNM2_A.Text, VbStrConv.None)
        If lngST >= 0 Then
            txt_TPGoodsNM2_A.SelectionStart = lngST
        End If

        '------------------------------
        ' ì¸óÕí∑êßå¿
        '------------------------------
        If GF_LenB(txt_TPGoodsNM2_A.Text) > 25 Then
            txt_TPGoodsNM2_A.Text = GF_MidB(txt_TPGoodsNM2_A.Text, 1, 25)
            txt_TPGoodsNM2_A.SelectionStart = GF_LenB(txt_TPGoodsNM2_A.Text)
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub txt_TPGoodsNM_B_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TPGoodsNM_B.TextChanged

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim lngST As Long

        If txt_TPGoodsNM_B.Modified = False Then
            Exit Sub
        End If

        lngST = txt_TPGoodsNM_B.SelectionStart
        txt_TPGoodsNM_B.Text = StrConv(txt_TPGoodsNM_B.Text, VbStrConv.None)
        If lngST >= 0 Then
            txt_TPGoodsNM_B.SelectionStart = lngST
        End If

        '------------------------------
        ' ì¸óÕí∑êßå¿
        '------------------------------
        If GF_LenB(txt_TPGoodsNM_B.Text) > 20 Then
            txt_TPGoodsNM_B.Text = GF_MidB(txt_TPGoodsNM_B.Text, 1, 20)
            txt_TPGoodsNM_B.SelectionStart = GF_LenB(txt_TPGoodsNM_B.Text)
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub txt_TPGoodsNM2_B_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TPGoodsNM2_B.TextChanged

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim lngST As Long

        If txt_TPGoodsNM2_B.Modified = False Then
            Exit Sub
        End If

        lngST = txt_TPGoodsNM2_B.SelectionStart
        txt_TPGoodsNM2_B.Text = StrConv(txt_TPGoodsNM2_B.Text, VbStrConv.None)
        If lngST >= 0 Then
            txt_TPGoodsNM2_B.SelectionStart = lngST
        End If

        '------------------------------
        ' ì¸óÕí∑êßå¿
        '------------------------------
        If GF_LenB(txt_TPGoodsNM2_B.Text) > 20 Then
            txt_TPGoodsNM2_B.Text = GF_MidB(txt_TPGoodsNM2_B.Text, 1, 20)
            txt_TPGoodsNM2_B.SelectionStart = GF_LenB(txt_TPGoodsNM2_B.Text)
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub txt_TPGoodsNM_C_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TPGoodsNM_C.TextChanged

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim lngST As Long

        If txt_TPGoodsNM_C.Modified = False Then
            Exit Sub
        End If

        lngST = txt_TPGoodsNM_C.SelectionStart
        txt_TPGoodsNM_C.Text = StrConv(txt_TPGoodsNM_C.Text, VbStrConv.None)
        If lngST >= 0 Then
            txt_TPGoodsNM_C.SelectionStart = lngST
        End If

        '------------------------------
        ' ì¸óÕí∑êßå¿
        '------------------------------
        If GF_LenB(txt_TPGoodsNM_C.Text) > 25 Then
            txt_TPGoodsNM_C.Text = GF_MidB(txt_TPGoodsNM_C.Text, 1, 25)
            txt_TPGoodsNM_C.SelectionStart = GF_LenB(txt_TPGoodsNM_C.Text)
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub txt_TPGoodsNM2_C_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TPGoodsNM2_C.TextChanged

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim lngST As Long

        If txt_TPGoodsNM2_C.Modified = False Then
            Exit Sub
        End If

        lngST = txt_TPGoodsNM2_C.SelectionStart
        txt_TPGoodsNM2_C.Text = StrConv(txt_TPGoodsNM2_C.Text, VbStrConv.None)
        If lngST >= 0 Then
            txt_TPGoodsNM2_C.SelectionStart = lngST
        End If

        '------------------------------
        ' ì¸óÕí∑êßå¿
        '------------------------------
        If GF_LenB(txt_TPGoodsNM2_C.Text) > 25 Then
            txt_TPGoodsNM2_C.Text = GF_MidB(txt_TPGoodsNM2_C.Text, 1, 25)
            txt_TPGoodsNM2_C.SelectionStart = GF_LenB(txt_TPGoodsNM2_C.Text)
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub LS_ItemImageSet()
        ' pProcKind  / True:âÊëúäÑìñ False:âÊëúâèú
        ' pProcRange / True:ëSåèëŒè€ False:ÉJÉåÉìÉgÇÃÇ›

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim lngRow As Long

        '------------------------------
        ' ämîFÉÅÉbÉZÅ[ÉWï\é¶
        '------------------------------
        If GF_Msg("", "åªç›ëIëíÜÇÃè§ïiâÊëúÇÃäÑìñâèúÇçsÇ¢Ç‹Ç∑ÅBçÌèúÇµÇƒÇ‡ÇÊÇÎÇµÇ¢Ç≈Ç∑Ç©ÅH", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        '------------------------------
        ' èâä˙ílê›íË
        '------------------------------
        If Len(Trim$(txt_SelRow.Text)) = 0 Then
            txt_SelRow.Text = 0
        End If

        '------------------------------
        ' èàóùîÕàÕê›íË
        '------------------------------
        lngRow = CLng(Trim$(txt_SelRow.Text))

        Try
            '------------------------------
            ' âÊëúâèúèàóù
            '------------------------------
            grd_ItemList.Select(lngRow)

            grd_ItemList(lngRow, 2) = ""
            grd_ItemList(lngRow, 14) = GC_TRUE
            L_blnEditFlg = True
            btn_Save.BackColor = Color.Yellow

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Me.Cursor = Cursors.Default
        Call GS_ErrorTerm("LS_ItemImageSet")
    End Sub

    Private Sub txt_Price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Price.TextChanged

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim lngST As Long
        Dim salesTaxSwitching As String

        If txt_Price.Modified = False Then
            Exit Sub
        End If

        lngST = txt_Price.SelectionStart
        If lngST >= 0 Then
            txt_Price.SelectionStart = lngST
        End If

        salesTaxSwitching = Trim$(GF_GetAppInfo("SALES_TAX_SWITCHING"))

        '------------------------------
        ' ì¸óÕí∑êßå¿
        '------------------------------
        If GF_LenB(txt_Price.Text) > 6 Then
            txt_Price.Text = GF_MidB(txt_Price.Text, 1, 6)
            txt_Price.SelectionStart = GF_LenB(txt_Price.Text)
            If salesTaxSwitching = "1" Then
                'ê≈ï ï\ãLéû
                lbl_Price.Text = GF_MidB(txt_Price.Text, 1, 6)
            End If
        End If

        If Len(Trim$(txt_Price.Text)) = 0 Then
            txt_Price.Text = "0"
            If salesTaxSwitching = "1" Then
                'ê≈ï ï\ãLéû
                lbl_Price.Text = "0"
            End If
        End If

        If IsNumeric(Trim$(txt_Price.Text)) = False Then
            txt_Price.Text = "0"
            If salesTaxSwitching = "1" Then
                'ê≈ï ï\ãLéû
                lbl_Price.Text = "0"
            End If
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub txt_Price_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Price.Enter

        ' ÉJÉìÉ}Çí∑Ç≥ÇOÇÃï∂éöóÒÇ…ReplaceÇ∑ÇÈ
        txt_Price.Text = Replace(txt_Price.Text, ",", "")

    End Sub

    Private Sub txt_Price_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Price.Leave

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim salesTaxSwitching As String
        salesTaxSwitching = Trim$(GF_GetAppInfo("SALES_TAX_SWITCHING"))

        If IsNumeric(Trim$(txt_Price.Text)) = False Then
            GF_Msg("", "ã‡äzÇÕêîéöÇÃÇ›Çì¸óÕÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        ' ÉJÉìÉ}ï“èWÇçsÇ§
        txt_Price.Text = Format$(CLng(Trim$(txt_Price.Text)), "###,##0")
        If salesTaxSwitching = "1" Then
            'ê≈ï ï\ãLéû
            lbl_Price.Text = Format$(CLng(Trim$(txt_Price.Text)), "###,##0")
        End If

        'ê≈çûâøäiÇÃåvè„ÇçsÇ§ 2013.12.19
        Dim Taxprice As Decimal      'ê≈çûÇ›åvéZåãâ 
        Dim price As Decimal         'ê≈çûÇ›ã‡äz
        Dim Taxprice_dec As String   'ê≈çûÇ›åvéZåãâ è¨êîì_ëÊàÍà ÇÃíl
        Dim lngST As Long
        Dim ReturnPriceReduce As String = Nothing

        If GF_GetAppInfo("PRICE_EDIT_SWITCHING") = "0" Then
            ' ê≈ï âøäiÇ©ÇÁê≈çûâøäiÇé©ìÆåvéZÇ∑ÇÈèÍçá

            'ê≈çûÇ›ã‡äzåvéZ
            Taxprice = txt_Price.Text * (1 + (GF_GetAppInfo("SALES_TAX_RATE")) / 100)

            'åvéZåãâ ÇÃè¨êîëÊàÍà ÇÃílÇéÊìæ
            Taxprice_dec = Mid$((Taxprice - Fix(Taxprice)), 3, 1)

            'NéÃN+1ì¸èàóù
            'è¨êîëÊàÍà ÇÃílÇ™0ÇÃéû
            If Taxprice_dec = Nothing Then
                tax_Price.Text = Format$(CLng(Trim$(Taxprice)), "###,##0")
                If salesTaxSwitching = "0" Then
                    'ê≈çûÇ›ï\ãLéû
                    lbl_Price.Text = Format$(CLng(Trim$(Taxprice)), "###,##0")
                End If
            Else

                If Taxprice_dec > Trim$(GF_GetAppInfo("TAX_ROUND_OFF")) Then
                    'è¨êîëÊàÍà ÇÃílÇ™NÇÊÇËëÂÇ´Ç¢éû
                    price = Math.Ceiling(Taxprice)
                Else
                    'è¨êîëÊàÍà ÇÃílÇ™Nà»â∫ÇÃéû
                    price = Math.Truncate(Taxprice)
                End If
                tax_Price.Text = Format$(CLng(Trim$(price)), "###,##0")
                If salesTaxSwitching = "0" Then
                    'ê≈çûÇ›ï\ãLéû
                    lbl_Price.Text = Format$(CLng(Trim$(Taxprice)), "###,##0")
                End If
            End If

            'åªç›ÇÃê≈çûâøäiÇÉäÉXÉgÇ…í«â¡
            lngST = tax_Price.SelectionStart
            If lngST >= 0 Then
                tax_Price.SelectionStart = lngST
            End If

            If salesTaxSwitching = "1" Then
                'ê≈ï ï\ãLéû
                'é©ìÆåvéZÇ≥ÇÍÇΩåyå∏ê≈ó¶íPâøÇÃéZèo
                If LF_AutomaticCalculationPrice(txt_Price.Text, ReturnPriceReduce) Then
                    'éZèoÇ≈Ç´ÇΩèÍçáÇÕílÇîΩâf
                    txt_Price_Reduce.Text = Format$(CLng(Trim$(ReturnPriceReduce)), "###,##0")
                End If
            Else
                'é©ìÆåvéZÇ≥ÇÍÇΩåyå∏ê≈ó¶íPâøÇÃéZèo
                If LF_AutomaticCalculationPrice(tax_Price.Text, ReturnPriceReduce) Then
                    'éZèoÇ≈Ç´ÇΩèÍçáÇÕílÇîΩâf
                    txt_Price_Reduce.Text = Format$(CLng(Trim$(ReturnPriceReduce)), "###,##0")
                End If
            End If

        End If

        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub txt_Price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Price.KeyPress

        If "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".Contains(e.KeyChar) And Len(txt_Price.Text) >= 6 Then
            e.Handled = True
        End If

    End Sub

    'è¡îÔê≈ëŒâûÅ@2013.12.19Å@ÉeÉLÉXÉgïœçXéûèàóù
    Private Sub tax_Price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tax_Price.TextChanged

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim lngST As Long
        Dim salesTaxSwitching As String

        If tax_Price.Modified = False Then
            Exit Sub
        End If

        lngST = tax_Price.SelectionStart
        If lngST >= 0 Then
            tax_Price.SelectionStart = lngST
        End If

        salesTaxSwitching = Trim$(GF_GetAppInfo("SALES_TAX_SWITCHING"))

        '------------------------------
        ' ì¸óÕí∑êßå¿
        '------------------------------
        If GF_LenB(tax_Price.Text) > 6 Then
            tax_Price.Text = GF_MidB(tax_Price.Text, 1, 6)
            tax_Price.SelectionStart = GF_LenB(tax_Price.Text)
            If salesTaxSwitching = "0" Then
                'ê≈çûÇ›ï\ãLéû
                lbl_Price.Text = GF_MidB(tax_Price.Text, 1, 6)
            End If
        End If

        If Len(Trim$(tax_Price.Text)) = 0 Then
            tax_Price.Text = "0"
            If salesTaxSwitching = "0" Then
                'ê≈çûÇ›ï\ãLéû
                lbl_Price.Text = "0"
            End If
        End If

        If IsNumeric(Trim$(tax_Price.Text)) = False Then
            tax_Price.Text = "0"
            If salesTaxSwitching = "0" Then
                'ê≈çûÇ›ï\ãLéû
                lbl_Price.Text = "0"
            End If
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub tax_Price_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tax_Price.Enter


        ' ÉJÉìÉ}Çí∑Ç≥ÇOÇÃï∂éöóÒÇ…ReplaceÇ∑ÇÈ
        tax_Price.Text = Replace(tax_Price.Text, ",", "")

    End Sub

    Private Sub tax_Price_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tax_Price.Leave

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim salesTaxSwitching As String = Nothing
        Dim ReturnPriceReduce As String = Nothing
        salesTaxSwitching = Trim$(GF_GetAppInfo("SALES_TAX_SWITCHING"))

        If IsNumeric(Trim$(tax_Price.Text)) = False Then
            GF_Msg("", "ã‡äzÇÕêîéöÇÃÇ›Çì¸óÕÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        ' ÉJÉìÉ}ï“èWÇçsÇ§
        tax_Price.Text = Format$(CLng(Trim$(tax_Price.Text)), "###,##0")

        'ê≈ï âøäiÇÃåvè„ÇçsÇ§ 2013.12.19
        Dim Taxprice As Decimal      'ê≈çûÇ›åvéZåãâ 
        Dim price As Decimal         'ê≈çûÇ›ã‡äz
        Dim ConsuTax As Decimal      'ê≈ó¶ÇÃí[êî
        Dim Taxprice_dec As String   'ê≈çûÇ›åvéZåãâ è¨êîì_ëÊàÍà ÇÃíl
        Dim lngST As Long

        If GF_GetAppInfo("PRICE_EDIT_SWITCHING") = "1" Then
            ' ê≈çûâøäiÇ©ÇÁê≈ï âøäiÇé©ìÆåvéZÇ∑ÇÈèÍçá

            'ê≈ï ã‡äzåvéZ
            ConsuTax = 1 + (GF_GetAppInfo("SALES_TAX_RATE") / 100)
            Taxprice = CStr(CLng(tax_Price.Text) / ConsuTax)

            'åvéZåãâ ÇÃè¨êîëÊàÍà ÇÃílÇéÊìæ
            Taxprice_dec = Mid$((Taxprice - Fix(Taxprice)), 3, 1)

            'NéÃN+1ì¸èàóù
            'è¨êîëÊàÍà ÇÃílÇ™0ÇÃéû
            If Taxprice_dec = Nothing Then
                txt_Price.Text = Format$(CLng(Trim$(Taxprice)), "###,##0")
                If salesTaxSwitching = "0" Then
                    'ê≈çûÇ›ï\ãLéû
                    lbl_Price.Text = Format$(CLng(Trim$(Taxprice)), "###,##0")
                End If
            Else
                If Taxprice_dec > Trim$(GF_GetAppInfo("TAX_ROUND_OFF2")) Then
                    'è¨êîëÊàÍà ÇÃílÇ™NÇÊÇËëÂÇ´Ç¢éû
                    price = Math.Ceiling(Taxprice)
                Else
                    'è¨êîëÊàÍà ÇÃílÇ™Nà»â∫ÇÃéû
                    price = Math.Truncate(Taxprice)
                End If
                txt_Price.Text = Format$(CLng(Trim$(price)), "###,##0")
                If salesTaxSwitching = "0" Then
                    'ê≈çûÇ›ï\ãLéû
                    lbl_Price.Text = Format$(CLng(Trim$(Taxprice)), "###,##0")
                End If
            End If

            'åªç›ÇÃê≈ï âøäiÇÉäÉXÉgÇ…í«â¡
            lngST = txt_Price.SelectionStart
            If lngST >= 0 Then
                txt_Price.SelectionStart = lngST
            End If

            If salesTaxSwitching = "1" Then
                'ê≈ï ï\ãLéû
                'é©ìÆåvéZÇ≥ÇÍÇΩåyå∏ê≈ó¶íPâøÇÃéZèo
                If LF_AutomaticCalculationPrice(txt_Price.Text, ReturnPriceReduce) Then
                    'éZèoÇ≈Ç´ÇΩèÍçáÇÕílÇîΩâf
                    txt_Price_Reduce.Text = Format$(CLng(Trim$(ReturnPriceReduce)), "###,##0")
                End If
            Else
                'é©ìÆåvéZÇ≥ÇÍÇΩåyå∏ê≈ó¶íPâøÇÃéZèo
                If LF_AutomaticCalculationPrice(tax_Price.Text, ReturnPriceReduce) Then
                    'éZèoÇ≈Ç´ÇΩèÍçáÇÕílÇîΩâf
                    txt_Price_Reduce.Text = Format$(CLng(Trim$(ReturnPriceReduce)), "###,##0")
                End If
            End If

        End If

        If salesTaxSwitching = "0" Then
            'ê≈çûÇ›ï\ãLéû
            lbl_Price.Text = Format$(CLng(Trim$(tax_Price.Text)), "###,##0")

            'é©ìÆåvéZÇ≥ÇÍÇΩåyå∏ê≈ó¶íPâøÇÃéZèo
            If LF_AutomaticCalculationPrice(tax_Price.Text, ReturnPriceReduce) Then
                'éZèoÇ≈Ç´ÇΩèÍçáÇÕílÇîΩâf
                txt_Price_Reduce.Text = Format$(CLng(Trim$(ReturnPriceReduce)), "###,##0")
            End If
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub tax_Price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tax_Price.KeyPress


        If "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".Contains(e.KeyChar) And Len(tax_Price.Text) >= 6 Then
            e.Handled = True
        End If

    End Sub

    Private Sub cbo_OP1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_OP1.SelectionChangeCommitted

        If cbo_OP1.SelectedIndex <> 0 Then
            If Not LF_CheckOption(0) Then
                GF_Msg("", "ÇªÇÃÉIÉvÉVÉáÉìÇÕê›íËçœÇ›Ç≈Ç∑" & vbCrLf & "ï ÇÃÉIÉvÉVÉáÉìÇê›íËÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
                cbo_OP1.SelectedIndex = L_OptionIndex
                Exit Sub
            End If
        End If

        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub cbo_OP2_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_OP2.SelectionChangeCommitted

        If cbo_OP2.SelectedIndex <> 0 Then
            If Not LF_CheckOption(1) Then
                GF_Msg("", "ÇªÇÃÉIÉvÉVÉáÉìÇÕê›íËçœÇ›Ç≈Ç∑" & vbCrLf & "ï ÇÃÉIÉvÉVÉáÉìÇê›íËÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
                cbo_OP2.SelectedIndex = L_OptionIndex
                Exit Sub
            End If
        End If

        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub cbo_OP3_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_OP3.SelectionChangeCommitted

        If cbo_OP3.SelectedIndex <> 0 Then
            If Not LF_CheckOption(2) Then
                GF_Msg("", "ÇªÇÃÉIÉvÉVÉáÉìÇÕê›íËçœÇ›Ç≈Ç∑" & vbCrLf & "ï ÇÃÉIÉvÉVÉáÉìÇê›íËÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
                cbo_OP3.SelectedIndex = L_OptionIndex
                Exit Sub
            End If
        End If

        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub cbo_OP4_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_OP4.SelectionChangeCommitted

        If cbo_OP4.SelectedIndex <> 0 Then
            If Not LF_CheckOption(3) Then
                GF_Msg("", "ÇªÇÃÉIÉvÉVÉáÉìÇÕê›íËçœÇ›Ç≈Ç∑" & vbCrLf & "ï ÇÃÉIÉvÉVÉáÉìÇê›íËÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
                cbo_OP4.SelectedIndex = L_OptionIndex
                Exit Sub
            End If
        End If

        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub cbo_OP5_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_OP5.SelectionChangeCommitted

        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub cbo_OP6_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_OP6.SelectionChangeCommitted
        If cbo_OP6.SelectedIndex <> 0 Then
            If Not LF_CheckOption2(0) Then
                GF_Msg("", "ÇªÇÃÉIÉvÉVÉáÉìÇÕê›íËçœÇ›Ç≈Ç∑" & vbCrLf & "ï ÇÃÉIÉvÉVÉáÉìÇê›íËÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
                cbo_OP6.SelectedIndex = L_OptionIndex
                Exit Sub
            End If
        End If

        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub cbo_OP7_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_OP7.SelectionChangeCommitted

        If cbo_OP6.SelectedIndex <> 0 Then
            If Not LF_CheckOption2(1) Then
                GF_Msg("", "ÇªÇÃÉIÉvÉVÉáÉìÇÕê›íËçœÇ›Ç≈Ç∑" & vbCrLf & "ï ÇÃÉIÉvÉVÉáÉìÇê›íËÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
                cbo_OP6.SelectedIndex = L_OptionIndex
                Exit Sub
            End If
        End If

        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub cbo_OP8_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_OP8.SelectionChangeCommitted

        If cbo_OP6.SelectedIndex <> 0 Then
            If Not LF_CheckOption2(2) Then
                GF_Msg("", "ÇªÇÃÉIÉvÉVÉáÉìÇÕê›íËçœÇ›Ç≈Ç∑" & vbCrLf & "ï ÇÃÉIÉvÉVÉáÉìÇê›íËÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
                cbo_OP6.SelectedIndex = L_OptionIndex
                Exit Sub
            End If
        End If

        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub cbo_OP9_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_OP9.SelectionChangeCommitted

        If cbo_OP6.SelectedIndex <> 0 Then
            If Not LF_CheckOption2(3) Then
                GF_Msg("", "ÇªÇÃÉIÉvÉVÉáÉìÇÕê›íËçœÇ›Ç≈Ç∑" & vbCrLf & "ï ÇÃÉIÉvÉVÉáÉìÇê›íËÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
                cbo_OP6.SelectedIndex = L_OptionIndex
                Exit Sub
            End If
        End If

        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub cbo_OP10_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_OP10.SelectionChangeCommitted

        If cbo_OP6.SelectedIndex <> 0 Then
            If Not LF_CheckOption2(4) Then
                GF_Msg("", "ÇªÇÃÉIÉvÉVÉáÉìÇÕê›íËçœÇ›Ç≈Ç∑" & vbCrLf & "ï ÇÃÉIÉvÉVÉáÉìÇê›íËÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
                cbo_OP6.SelectedIndex = L_OptionIndex
                Exit Sub
            End If
        End If

        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub cbo_OP11_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_OP11.SelectionChangeCommitted

        If cbo_OP6.SelectedIndex <> 0 Then
            If Not LF_CheckOption2(5) Then
                GF_Msg("", "ÇªÇÃÉIÉvÉVÉáÉìÇÕê›íËçœÇ›Ç≈Ç∑" & vbCrLf & "ï ÇÃÉIÉvÉVÉáÉìÇê›íËÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
                cbo_OP6.SelectedIndex = L_OptionIndex
                Exit Sub
            End If
        End If

        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub cbo_OP12_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_OP12.SelectionChangeCommitted

        If cbo_OP6.SelectedIndex <> 0 Then
            If Not LF_CheckOption2(6) Then
                GF_Msg("", "ÇªÇÃÉIÉvÉVÉáÉìÇÕê›íËçœÇ›Ç≈Ç∑" & vbCrLf & "ï ÇÃÉIÉvÉVÉáÉìÇê›íËÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
                cbo_OP6.SelectedIndex = L_OptionIndex
                Exit Sub
            End If
        End If

        Call LS_WriteRetItemInfo()
    End Sub

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
            .G_KCPStatus = grd_ItemList(CLng(txt_SelRow.Text), 11)
            If .ShowDialog() = DialogResult.OK Then
                Call LS_WriteRetItemInfo(.G_KCPStatus)
                Call LS_ShowCurrentItem(CInt(txt_SelRow.Text))
                'START 2016.04.25 ìcë„
                If CInt(Trim$(grd_ItemList(CLng(txt_SelRow.Text), 1))) <= 8999 Then
                    If lbl_KCP1.Text <> "" Or lbl_KCP2.Text <> "" Or lbl_KCP3.Text <> "" Or lbl_KCP4.Text <> "" Then ' è§ïièoóÕêÊÇ™ì¸óÕÇµÇƒÇ†ÇÈèÍçá
                        CNL2010.L_judge = False                                               ' îªíËópïœêîÇfalse
                    ElseIf lbl_KCP1.Text = "" And lbl_KCP2.Text = "" And lbl_KCP3.Text = "" And lbl_KCP4.Text = "" Then ' è§ïièoóÕêÊÇ™ì¸óÕÇµÇƒÇ¢Ç»Ç¢èÍçá
                        CNL2010.L_judge = True                                                   ' îªíËópïœêîÇTrue
                    End If
                End If
                'END 2016.04.25 ìcë„
            End If
        End With
    End Sub

    Private Sub txt_HTLNM1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_HTLNM1.TextChanged

        If txt_HTLNM1.Modified = False Then
            Exit Sub
        End If

        '------------------------------
        ' ì¸óÕí∑êßå¿
        '------------------------------
        If GF_LenB(txt_HTLNM1.Text) > 5 Then
            txt_HTLNM1.Text = GF_MidB(txt_HTLNM1.Text, 1, 5)
            txt_HTLNM1.SelectionStart = GF_LenB(txt_HTLNM1.Text)
        End If

        Call LS_WriteRetItemInfo()
    End Sub

    Private Sub txt_HTLNM2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_HTLNM2.TextChanged

        If txt_HTLNM2.Modified = False Then
            Exit Sub
        End If

        If GF_LenB(txt_HTLNM2.Text) > 5 Then
            txt_HTLNM2.Text = GF_MidB(txt_HTLNM2.Text, 1, 5)
            txt_HTLNM2.SelectionStart = GF_LenB(txt_HTLNM2.Text)
        End If

        Call LS_WriteRetItemInfo()
    End Sub

    ' START 2016.05.10 ìcë„
    Private Sub txt_GoodsNMJ4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GoodsNMJ4.TextChanged

        ''------------------------------
        '' ì‡ïîïœêîíËã`
        ''------------------------------
        'Dim lngST As Long = Nothing

        'If txt_GoodsNMJ4.Modified = False Then
        '    Exit Sub
        'End If

        'If Not GF_GetAppInfo("PRINT_FLG") = 0 Then
        '    'ì¸óÕêßå¿Ç»Çµ

        '    lngST = txt_GoodsNMJ4.SelectionStart

        '    If GF_GetAppInfo("PRINT_FLG") = 1 Then
        '        'ëSäpì¸óÕÇÃÇ›
        '        txt_GoodsNMJ4.Text = StrConv(txt_GoodsNMJ4.Text, VbStrConv.Wide)
        '    Else
        '        'îºäpì¸óÕÇÃÇ›
        '        txt_GoodsNMJ4.Text = StrConv(txt_GoodsNMJ4.Text, VbStrConv.Narrow)
        '    End If

        '    If lngST >= 0 Then
        '        txt_GoodsNMJ4.SelectionStart = lngST
        '    End If

        'End If

        ''------------------------------
        '' ì¸óÕí∑êßå¿
        ''------------------------------
        'If GF_LenB(txt_GoodsNMJ4.Text) > 16 Then
        '    txt_GoodsNMJ4.Text = GF_MidB(txt_GoodsNMJ4.Text, 1, 16)
        '    txt_GoodsNMJ4.SelectionStart = GF_LenB(txt_GoodsNMJ4.Text)
        'End If

        'Call LS_WriteRetItemInfo()

        'txt_GoodsNMJ4.Text = StrConv(txt_GoodsNMJ4.Text, VbStrConv.Wide) ' ADD 2016.05.09 ìcë„

        ' 2018.05.21 ìcë„
        If GF_GetAppInfo("PRINT_FLG") = "1" Then
            ' ëSäpì¸óÕ
            Call TextBoxTextChanged(txt_GoodsNMJ4, VbStrConv.Wide, 20)
        ElseIf GF_GetAppInfo("PRINT_FLG") = "2" Then
            ' îºäpì¸óÕ
            Call TextBoxTextChanged(txt_GoodsNMJ4, VbStrConv.Narrow, 20)
        Else
            Call TextBoxTextChanged(txt_GoodsNMJ4, VbStrConv.Wide, 20)
        End If

        'Call TextBoxTextChanged(txt_GoodsNMJ4, VbStrConv.Wide, 20)
        ' 2018.05.21 ìcë„

    End Sub
    ' END 2016.05.10 ìcë„

    'START 2016.04.20 ìcë„ 
    Private Sub txt_GoodsNMJ4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_GoodsNMJ4.KeyPress
        ' 2018.05.21 ìcë„
        If GF_GetAppInfo("PRINT_FLG") = "1" Then
            ' ëSäpì¸óÕ
            e.KeyChar = StrConv(e.KeyChar, VbStrConv.Wide)
        ElseIf GF_GetAppInfo("PRINT_FLG") = "2" Then
            ' îºäpì¸óÕ
            e.KeyChar = StrConv(e.KeyChar, VbStrConv.Narrow)
        End If

        'e.KeyChar = StrConv(e.KeyChar, VbStrConv.Wide) 'îºäpì¸óÕêßå¿
        ' 2018.05.21 ìcë„
    End Sub
    '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
    Private Sub txt_TECKCPNM3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TECKCPNM3.TextChanged

        If txt_TECKCPNM3.Modified = False Then
            Exit Sub
        End If

        '------------------------------
        ' ì¸óÕí∑êßå¿
        '------------------------------
        If GF_LenB(txt_TECKCPNM3.Text) > 24 Then
            txt_TECKCPNM3.Text = GF_MidB(txt_TECKCPNM3.Text, 1, 24)
            txt_TECKCPNM3.SelectionStart = GF_LenB(txt_TECKCPNM3.Text)
        End If

        Call LS_WriteRetItemInfo()

    End Sub
    Private Sub txt_HTLNM5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_HTLNM5.TextChanged

        If txt_HTLNM5.Modified = False Then
            Exit Sub
        End If

        '------------------------------
        ' ì¸óÕí∑êßå¿
        '------------------------------
        If GF_LenB(txt_HTLNM5.Text) > 24 Then
            txt_HTLNM5.Text = GF_MidB(txt_HTLNM5.Text, 1, 24)
            txt_HTLNM5.SelectionStart = GF_LenB(txt_HTLNM5.Text)
        End If

        Call LS_WriteRetItemInfo()

    End Sub
    '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

    'END 2016.04.20 ìcë„

    Private Sub chk_Status0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Status0.Click

        If chk_Status0.Checked = True And (chk_Status1.Checked = True Or chk_Status2.Checked = True Or chk_Status3.Checked = True) Then
            chk_Status1.Checked = False
            chk_Status2.Checked = False
            chk_Status3.Checked = False
        ElseIf chk_Status0.Checked = False And chk_Status1.Checked = False And chk_Status2.Checked = False And chk_Status3.Checked = False Then
            chk_Status0.Checked = True
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub chk_Status1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Status1.Click

        If chk_Status1.Checked = True And (chk_Status0.Checked = True Or chk_Status2.Checked = True Or chk_Status3.Checked = True) Then
            chk_Status0.Checked = False
            chk_Status2.Checked = False
            chk_Status3.Checked = False
        ElseIf chk_Status0.Checked = False And chk_Status1.Checked = False And chk_Status2.Checked = False And chk_Status3.Checked = False Then
            chk_Status0.Checked = True
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub chk_Status2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Status2.Click

        If chk_Status2.Checked = True And (chk_Status0.Checked = True Or chk_Status1.Checked = True Or chk_Status3.Checked = True) Then
            chk_Status0.Checked = False
            chk_Status1.Checked = False
            chk_Status3.Checked = False
        ElseIf chk_Status0.Checked = False And chk_Status1.Checked = False And chk_Status2.Checked = False And chk_Status3.Checked = False Then
            chk_Status0.Checked = True
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub chk_Status3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Status3.Click

        If chk_Status3.Checked = True And (chk_Status0.Checked = True Or chk_Status1.Checked = True Or chk_Status2.Checked = True) Then
            chk_Status0.Checked = False
            chk_Status1.Checked = False
            chk_Status2.Checked = False
        ElseIf chk_Status0.Checked = False And chk_Status1.Checked = False And chk_Status2.Checked = False And chk_Status3.Checked = False Then
            chk_Status0.Checked = True
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    'ê≈éÌï Å]äOê≈É`ÉFÉbÉNÉ{ÉbÉNÉXïœçX
    Private Sub chk_TaxKind0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_TaxKind0.Click

        If chk_TaxKind0.Checked = True And chk_TaxKind1.Checked = True Then
            chk_TaxKind1.Checked = False
        ElseIf chk_TaxKind0.Checked = False And chk_TaxKind1.Checked = False Then
            chk_TaxKind0.Checked = True
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    'ê≈éÌï Å]ì‡ê≈É`ÉFÉbÉNÉ{ÉbÉNÉXïœçX
    Private Sub chk_TaxKind1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_TaxKind1.Click

        If chk_TaxKind1.Checked = True And chk_TaxKind0.Checked = True Then
            chk_TaxKind0.Checked = False
        ElseIf chk_TaxKind1.Checked = False And chk_TaxKind0.Checked = False Then
            chk_TaxKind1.Checked = True
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub txt_searchNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_searchNumber.TextChanged

        Dim lngST As Long

        If txt_searchNumber.Modified = False Then
            Exit Sub
        End If

        lngST = txt_searchNumber.SelectionStart
        If lngST >= 0 Then
            txt_searchNumber.SelectionStart = lngST
        End If

        '------------------------------
        ' ì¸óÕí∑êßå¿
        '------------------------------
        If GF_LenB(txt_searchNumber.Text) > 4 Then
            txt_searchNumber.Text = GF_MidB(txt_searchNumber.Text, 1, 4)
            txt_searchNumber.SelectionStart = GF_LenB(txt_searchNumber.Text)
        End If

    End Sub

    Private Sub txtUnitPrice_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnitPrice.TextChanged

        If txtUnitPrice.Modified = False Then
            Exit Sub
        End If

        '------------------------------
        ' ì¸óÕí∑êßå¿
        '------------------------------
        If GF_LenB(txtUnitPrice.Text) > 6 Then
            txtUnitPrice.Text = GF_MidB(txtUnitPrice.Text, 1, 6)
            txtUnitPrice.SelectionStart = GF_LenB(txtUnitPrice.Text)
        End If

        If Len(Trim$(txtUnitPrice.Text)) = 0 Then
            txtUnitPrice.Text = "0"
        End If

        If IsNumeric(Trim$(txtUnitPrice.Text)) = False Then
            txtUnitPrice.Text = "0"
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub txtUnitPrice_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnitPrice.Leave

        If IsNumeric(Trim$(txtUnitPrice.Text)) = False Then
            GF_Msg("", "ã‡äzÇÕêîéöÇÃÇ›Çì¸óÕÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

    End Sub

    Private Sub chk_game_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_game.Click

        Call LS_WriteRetItemInfo()

    End Sub
    Private Sub ccp_check_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ccp_check.Click

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub txt_searchNumber_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_searchNumber.LostFocus

        Dim strSQL As String = Nothing
        Dim lngCnt As Long

        If txt_searchNumber.Modified = False Then
            Exit Sub
        End If

        If Trim$(txt_searchNumber.Text) <> String.Empty Then
            '------------------------------
            ' å^É`ÉFÉbÉN
            '------------------------------
            If IsNumeric(Trim$(txt_searchNumber.Text)) = False Then
                GF_Msg("", "åüçıî‘çÜÇÕêîéöÇÃÇ›ì¸óÕÇµÇƒâ∫Ç≥Ç¢", MsgBoxStyle.OkOnly)
                txt_searchNumber.Text = grd_ItemList(CInt(txt_SelRow.Text), 23)
                Exit Sub
            End If

            '------------------------------
            ' èdï°É`ÉFÉbÉN
            '------------------------------
            With grd_ItemList
                For lngCnt = 0 To GF_GetRowCnt(grd_ItemList) - 1
                    If RTrim$(grd_ItemList(lngCnt, 1)) <> RTrim$(grd_ItemList(CInt(txt_SelRow.Text), 1)) Then
                        If RTrim$(grd_ItemList(lngCnt, 23)) = Trim(txt_searchNumber.Text) Then
                            GF_Msg("", "ä˘Ç…ìØàÍÇÃåüçıî‘çÜÇ™ê›íËÇ≥ÇÍÇƒÇ¢Ç‹Ç∑ÅB", MsgBoxStyle.OkOnly)
                            txt_searchNumber.Text = grd_ItemList(CInt(txt_SelRow.Text), 23)
                            Exit Sub
                        End If
                    End If
                Next
            End With
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Function LF_SetBumonCmb() As Object
        '** ïîñÂÉRÅ[ÉhópÉRÉìÉ{É{ÉbÉNÉXê›íË

        Dim strSQL As String = Nothing
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim i As Integer

        LF_SetBumonCmb = Nothing

        cmb_Bumon.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_Bumon.Items.Clear()

        strSQL = ""
        strSQL = strSQL & "SELECT BUMONCD,"
        strSQL = strSQL & "       BUMONNM"
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

    ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„
    Private Function LF_SetPtnCmb() As Object

        '** îÃë£ÉpÉ^Å[ÉìópÉRÉìÉ{É{ÉbÉNÉXê›íË

        Dim strSQL As String = Nothing
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim i As Integer

        LF_SetPtnCmb = Nothing

        cmbPTN1.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPTN2.DropDownStyle = ComboBoxStyle.DropDownList

        cmbPTN1.Items.Clear()
        cmbPTN2.Items.Clear()

        strSQL = ""
        strSQL = strSQL & "SELECT CONVERT(int,CODEVAL) AS NUM,"
        strSQL = strSQL & "       CODENM"
        strSQL = strSQL & "  FROM TPM030"
        strSQL = strSQL & " WHERE CODEID = 'PTNMSG'"
        strSQL = strSQL & " ORDER BY NUM"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count > 0 Then
            For i = 0 To objData.Tables("com").Rows.Count - 1
                If Not GF_GetRows(objData, i, objRow) Then
                    Exit Function
                End If

                cmbPTN1.Items.Add(objRow("CODENM"))
                cmbPTN2.Items.Add(objRow("CODENM"))

            Next
        End If

    End Function
    ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„

    Private Sub chk_Lane_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Lane.Click

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub cmb_Bumon_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Bumon.SelectionChangeCommitted

        ''ëIëÇµÇΩïîñÂÉRÅ[ÉhÇ™ÅuÉeÉCÉNÉAÉEÉgÅvÇÃèÍçáÇÕà˘êHÅ^éùÇøãAÇËÇÃílÇÅuéùÇøãAÇËÅvÇ÷ïœçXÇ∑ÇÈ
        'If GF_GetAppInfo("SYS_TYPE") = "2" Or GF_GetAppInfo("SYS_TYPE") = "3" Then
        '    If GF_CboGetCode(cmb_Bumon, cmb_Bumon.SelectedIndex) = GF_GetAppInfo("TEC_DP_CODE_TO") Then
        '        rbt_Takeout_Takeout.Checked = True
        '    End If
        'End If

        Call LS_WriteRetItemInfo()

    End Sub

    ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„
    Private Sub cmbPTN1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPTN1.SelectionChangeCommitted

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub cmbPTN2_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPTN2.SelectionChangeCommitted

        Call LS_WriteRetItemInfo()

    End Sub
    ' 2017.01.01 Ç™Ç¡ÇƒÇÒéıéiå¸ÇØ ÉNÉåÉXÉRñkó§ ìcë„

    Private Function LF_CheckOption(ByVal pCnt As Integer) As Boolean

        Dim objCombo(3) As System.Windows.Forms.ComboBox
        Dim i As Integer

        LF_CheckOption = False

        objCombo(0) = cbo_OP1
        objCombo(1) = cbo_OP2
        objCombo(2) = cbo_OP3
        objCombo(3) = cbo_OP4

        For i = 0 To 3
            If i <> pCnt Then
                If objCombo(pCnt).SelectedIndex = objCombo(i).SelectedIndex Then
                    Exit Function
                End If
            End If
        Next

        LF_CheckOption = True

    End Function

    ' 2021.11.26 Gert

    Private Function LF_CheckOption2(ByVal pCnt As Integer) As Boolean

        Dim objCombo(6) As System.Windows.Forms.ComboBox
        Dim i As Integer

        LF_CheckOption2 = False

        objCombo(0) = cbo_OP6
        objCombo(1) = cbo_OP7
        objCombo(2) = cbo_OP8
        objCombo(3) = cbo_OP9
        objCombo(4) = cbo_OP10
        objCombo(5) = cbo_OP11
        objCombo(6) = cbo_OP12

        For i = 0 To 6
            If i <> pCnt Then
                If objCombo(pCnt).SelectedIndex = objCombo(i).SelectedIndex Then
                    Exit Function
                End If
            End If
        Next

        LF_CheckOption2 = True

    End Function

    Private Sub cbo_OP1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_OP1.Click
        L_OptionIndex = cbo_OP1.SelectedIndex
    End Sub

    Private Sub cbo_OP2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_OP2.Click
        L_OptionIndex = cbo_OP2.SelectedIndex
    End Sub

    Private Sub cbo_OP3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_OP3.Click
        L_OptionIndex = cbo_OP3.SelectedIndex
    End Sub

    Private Sub cbo_OP4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_OP4.Click
        L_OptionIndex = cbo_OP4.SelectedIndex
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFÅuè§ïiêVãKí«â¡ÅvÉ{É^Éìâüâ∫éûèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.08.25 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub btn_AddGoods_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddGoods.Click

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim objForm As Form

        '2016.04.25 ìcë„
        If Not LS_CheckKCP() Then ' è§ïièoóÕêÊÉ`ÉFÉbÉN
            Exit Sub
        End If
        '2016.04.25 ìcë„

        Call LS_CommitCheck()
        Call LF_ChkSave(False)

        objForm = New CNL2031()

        objForm.ShowDialog()

        Select Case objForm.DialogResult
            Case DialogResult.OK
                '------------------------------
                ' ï\é¶ílÉNÉäÉA(èâä˙âª)
                '------------------------------
                grd_ItemList.AllowDrop = True
                grd_PicList.AllowDrop = True

                L_PriceEdit = GF_GetAppInfo("PRICE_EDIT")                       ' óLå¯ê´ê›íËéÊìæ
                If Len(Trim$(L_PriceEdit)) = 0 Then
                    L_PriceEdit = GC_FALSE
                End If

                With txt_Price
                    .Clear()
                    .ImeMode = ImeMode.Disable
                    .ReadOnly = IIf(L_PriceEdit = GC_TRUE, False, True)
                    .ContextMenu = New ContextMenu()                            ' âEÉNÉäÉbÉNÉÅÉjÉÖÅ[ï\é¶ã÷é~ëŒçÙ
                End With
                'è¡îÔê≈ëŒâûÅ@2013.12.19
                With tax_Price
                    .Clear()
                    .ImeMode = ImeMode.Disable
                    .ReadOnly = IIf(L_PriceEdit = GC_TRUE, False, True)
                    .ContextMenu = New ContextMenu()                            ' âEÉNÉäÉbÉNÉÅÉjÉÖÅ[ï\é¶ã÷é~ëŒçÙ
                End With

                txt_ExpNoteJ.Clear()
                txt_PicPath.Text = GF_GetAppInfo("PHOTO_PATH")
                tab_Items.SelectedIndex = 0                                         ' [è§ïièÓïÒì¸óÕ]É^ÉuÇèâä˙ëIëèÛë‘Ç…ê›íË
                Call GS_StatusSetup(stb_Msg)                                        ' ÉXÉeÅ[É^ÉXÉoÅ[èâä˙âª
                L_blnEditFlg = False
                btn_Save.BackColor = Color.Empty
                txt_PicPath.Visible = False
                txt_SelRow.Visible = False
                txt_SelRow.Clear()

                txt_TPGoodsNM.Clear()
                txt_TPGoodsNM2.Clear()
                lbl_KCP1.Text = ""
                lbl_KCP2.Text = ""
                lbl_KCP3.Text = ""
                lbl_KCP4.Text = ""      'KCPèoóÕêÊ4â”èäëŒâû

                'ëΩåæåÍã@î\ëŒâû
                If GF_GetAppInfo("MULTI_LING_USE") = "1" Then
                    txt_EXPNOTEJ_A.Clear()
                    txt_EXPNOTEJ_B.Clear()
                    txt_EXPNOTEJ_C.Clear()
                    txt_TPGoodsNM_A.Clear()
                    txt_TPGoodsNM2_A.Clear()
                    txt_TPGoodsNM_B.Clear()
                    txt_TPGoodsNM2_B.Clear()
                    txt_TPGoodsNM_C.Clear()
                    txt_TPGoodsNM2_C.Clear()
                End If

                Call LF_SetBumonCmb()

                '------------------------------
                ' ï\é¶éwíËÉRÉìÉ{ê∂ê¨
                '------------------------------
                Call LS_SetSelGroupCombo()                                          ' è§ïiÉOÉãÅ[ÉvéwíËÉRÉìÉ{ê∂ê¨
                'Call LS_SetSelSortCombo()                                          ' É\Å[ÉgéwíËÉRÉìÉ{ê∂ê¨
                Call LS_SetSelOptCombo()                                            ' ÉIÉvÉVÉáÉìéwíËÉRÉìÉ{ê∂ê¨(2004.05.25)

                '------------------------------
                ' è§ïiàÍóóÉOÉäÉbÉhê∂ê¨
                '------------------------------
                'cbo_SelSort.SelectedIndex = 0                                      ' [íçà”]ÉOÉäÉbÉhê∂ê¨ÉçÉWÉbÉNÇ™ÅASelGroup.SelectedIndexïœâªéûÇ…åƒÇ—èoÇ≥ÇÍÇÈ
                cbo_SelGroup.SelectedIndex = 0
                txt_Search.Clear()
                Call LS_GridSetup()

                '------------------------------
                ' è§ïiâÊëúàÍóóÉOÉäÉbÉhê∂ê¨
                '------------------------------
                Call LS_GridSetup2()
                objForm.Close()

                If GF_GetAppInfo("HTLNMUSE") = GC_TRUE Then
                    Label5.Visible = True
                    txt_HTLNM1.Visible = True
                    txt_HTLNM2.Visible = True
                Else
                    Label5.Visible = False
                    txt_HTLNM1.Visible = False
                    txt_HTLNM2.Visible = False
                End If

                If GF_GetAppInfo("KCPUSE") = GC_TRUE Then
                    Label7.Visible = True
                    txt_GoodsNMJ4.Visible = True
                Else
                    Label7.Visible = False
                    txt_GoodsNMJ4.Visible = False
                End If
                '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ >>>
                If GF_GetAppInfo("TICKETUSE") = "1" Then
                    Label67.Visible = True
                    txt_TECKCPNM3.Visible = True
                Else
                    Label67.Visible = False
                    txt_TECKCPNM3.Visible = False
                End If
                If GF_GetAppInfo("HTLNMUSE") = "0" Then
                    Label68.Visible = True
                    txt_HTLNM5.Visible = True
                Else
                    Label68.Visible = False
                    txt_HTLNM5.Visible = False
                End If
                '2021.10.28 ¡πØƒàÛéöñºèÃÅEHTLñºèÃí«â¡Å@∏⁄Ω∫ñkó§ <<<

                L_blnEditFlg = True
                btn_Save.BackColor = Color.Yellow
            Case DialogResult.Cancel
                ' âΩÇ‡ÇµÇ»Ç¢
            Case Else
                GoTo SYSTEM_ERROR
        End Select

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_AddGoods_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïiàÍóó åüçıÉeÉLÉXÉgÉ{ÉbÉNÉXì‡ EnterÉLÅ[âüâ∫éûèàóù
    ' Å@ã@î\äTóvÅF
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.12.01 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub txt_Search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call LS_CommitCheck()  'Gert 03/02
            'txt_SelRow.Text = "0"                                               ' åªç›ëIëçsÇÉ[ÉçÉNÉäÉA(2004.05.25)
            Call LF_ChkSave(False, True)
            Call LS_GridSetup()

            txt_Search.AppendText("")
            txt_Search.Focus()
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' Å@ã@Å@Å@î\ÅFè§ïiàÍóó åüçıÉeÉLÉXÉgÉ{ÉbÉNÉXì¸óÕéûèàóù
    ' Å@ã@î\äTóvÅFì¸óÕí∑Ç…Ç¬Ç¢ÇƒÅAñºèÃçÄñ⁄í∑(20ÉoÉCÉg)Ç≈êßå¿ÇçsÇ§
    ' Å@à¯Å@Å@êîÅF
    ' Å@ñﬂ ÇË ílÅF
    ' Å@óöÅ@Å@óÅF2003.12.02 É\ÉâÉìñkó§ êVãKçÏê¨
    ' --------------------------------------------------------------------------------
    Private Sub txt_Search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Search.TextChanged

        If txt_Search.Modified = False Then
            Exit Sub
        End If

        '------------------------------
        ' ì¸óÕí∑êßå¿
        '------------------------------
        If GF_LenB(txt_Search.Text) > 20 Then
            txt_Search.Text = GF_MidB(txt_Search.Text, 1, 20)
            txt_Search.SelectionStart = GF_LenB(txt_Search.Text)
            Exit Sub
        End If

        Call LS_CommitCheck() 'Gert 02/03
        'txt_SelRow.Text = "0"                                               ' åªç›ëIëçsÇÉ[ÉçÉNÉäÉA(2004.05.25)
        Call LF_ChkSave(False, True)
        Call LS_GridSetup()

        txt_Search.AppendText("")
        txt_Search.Focus()
    End Sub

    Private Sub ButtonRest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRest.Click
        Dim AppFullPath As String = System.Configuration.ConfigurationManager.AppSettings("ZanAppFullPath")

        ' https://dobon.net/vb/dotnet/process/shell.html
        'ProcessStartInfoÉIÉuÉWÉFÉNÉgÇçÏê¨Ç∑ÇÈ
        Dim psi As New System.Diagnostics.ProcessStartInfo()
        'ãNìÆÇ∑ÇÈÉtÉ@ÉCÉãÇÃÉpÉXÇéwíËÇ∑ÇÈ
        psi.FileName = AppFullPath
        'ÉRÉ}ÉìÉhÉâÉCÉìà¯êîÇéwíËÇ∑ÇÈ
        'psi.Arguments = """C:\test\1.txt"""

        'ÉAÉvÉäÉPÅ[ÉVÉáÉìÇãNìÆÇ∑ÇÈ
        System.Diagnostics.Process.Start(psi)
    End Sub

    ' 2019.05.09 ÉIÅ[ÉgÉEÉFÉCÉ^Å[òAåg
    Private Function LF_ChkLaneFlg() As String

        Dim LaneFlg As String = Nothing

        LF_ChkLaneFlg = "0"

        LaneFlg = Trim$(GF_GetAppInfo("LANE_FLG"))

        If LaneFlg = "2" Or LaneFlg = "4" Then
            'ñkì˙ñ{ÉJÉRÅ[òAìÆÇÃèÍçá
            LF_ChkLaneFlg = "1"
        End If

    End Function
    ' 2019.05.09 ÉIÅ[ÉgÉEÉFÉCÉ^Å[òAåg


    ''' <summary>
    ''' --------------------------------------------------------------------------------
    ''' ã@Å@Å@î\ÅFTPM600ñ¢ë∂ç›⁄∫∞ƒﬁçÏê¨èàóù
    ''' ã@î\äTóvÅFTPM010Ç…ë∂ç›ÇµÇƒÅATPM600Ç…ñ¢ë∂ç›ÇÃÉåÉRÅ[ÉhÇTPM600Ç…çÏê¨Ç∑ÇÈ
    ''' à¯Å@Å@êîÅF
    ''' ñﬂ ÇË ílÅF
    ''' óöÅ@Å@óÅF2019.08.08 ∏⁄Ω∫ñkó§)takigaura êVãKçÏê¨
    ''' --------------------------------------------------------------------------------
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_InsTPM600() As Boolean

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim stbSQL As New System.Text.StringBuilder
        Dim stbSQL2 As New System.Text.StringBuilder
        Dim TecDpCodeTo As String = GF_GetAppInfo("TEC_DP_CODE_TO")
        Dim strSQL As String = Nothing
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim ReturnPriceReduce As String

        '------------------------------
        ' èâä˙ílê›íË
        '------------------------------
        LF_InsTPM600 = False
        ReturnPriceReduce = 0
        lngCnt = 0

        '------------------------------
        ' êVãKí«â¡çsèÓïÒéÊìæ
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT GOODSCD"
        strSQL = strSQL & "     , PRICE"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " WHERE NOT EXISTS(SELECT *"
        strSQL = strSQL & "                    FROM TPM600"
        strSQL = strSQL & "                   WHERE TPM010.GOODSCD = TPM600.GOODSCD)"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        '------------------------------
        ' ÉgÉâÉìÉUÉNÉVÉáÉìäJén
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        '------------------------------
        ' TPM600êVãKí«â¡èàóù
        '------------------------------
        With stbSQL
            .Length = 0
            .AppendLine("INSERT INTO TPM600")
            .AppendLine("SELECT")
            .AppendLine("     TPM010.GOODSCD AS è§ïiÉRÅ[Éh")
            .AppendLine(",    RIGHT('00000000000000'  + RTRIM(CAST(GOODSCD  AS VARCHAR)) ,14)     AS ÉÅÉjÉÖÅ[ÉRÅ[Éh")
            If GF_GetAppInfo("TEC_OWN_COM_CD_FLG") = GC_TRUE Then
                'é©é–ÉRÅ[Éh - èâä˙ílê›íËÇ»Çµ
                .AppendLine(",    '00000000000000'  AS é©é–ÉRÅ[Éh")
            Else
                'é©é–ÉRÅ[Éh - èâä˙ílê›íËÇ†ÇË
                .AppendLine(",    RIGHT('00000000000000'  + RTRIM(CAST(GOODSCD  AS VARCHAR)) ,14)     AS é©é–ÉRÅ[Éh")
            End If
            .AppendLine(",    0       AS 'íPâø(åyå∏ê≈ó¶)'")
            .AppendLine(",    0       AS ÉTÉuÉÅÉjÉÖÅ[íPâø")
            .AppendLine(",    0       AS 'ÉTÉuÉÅÉjÉÖÅ[íPâø(åyå∏ê≈ó¶)'")
            .AppendLine(",    '0'     AS íPâøéÌï ")
            .AppendLine(",    '0'     AS ê≈ÉXÉeÅ[É^ÉX")
            .AppendLine(",    '0'     AS 'ê≈ÉXÉeÅ[É^ÉX(åyå∏ê≈ó¶)'")
            .AppendLine(",    '0'     AS êîó â¡ïM")
            .AppendLine(",    '0'     AS è¨åväÑà¯")
            .AppendLine(",    CASE WHEN TPM010.BUMONCD = '" & TecDpCodeTo & "' THEN '2' ELSE '1' END      AS à˘êHéùãA")
            .AppendLine(",    '0'     AS OESópÉÅÉjÉÖÅ[")
            .AppendLine(String.Format(",   '{0}'    AS çXêVé“", GC_UPDID))
            .AppendLine(String.Format(",   '{0}'    AS çXêVì˙", Now))
            .AppendLine("FROM TPM010")
            .AppendLine("WHERE    NOT EXISTS( SELECT  *")
            .AppendLine("                     FROM    TPM600")
            .AppendLine("                     WHERE   TPM010.GOODSCD = TPM600.GOODSCD    )")
        End With

        If Not GF_UpdData(stbSQL.ToString) Then
            Call GF_RollbackTrans()
            Exit Function
        End If

        'åyå∏ê≈ó¶íPâøÇÃåvéZ(èâä˙ílÇÃê›íË)
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If

            'é©ìÆåvéZÇ≥ÇÍÇΩåyå∏ê≈ó¶íPâøÇÃéZèo
            If LF_AutomaticCalculationPrice(Trim$(objRows("PRICE")).ToString, ReturnPriceReduce, "init") Then
                'éZèoÇ≈Ç´ÇΩèÍçáÇÕTPM600Ç…ílÇîΩâf

                '------------------------------
                ' çXêVèàóù
                '------------------------------
                With stbSQL2
                    .Length = 0
                    .AppendLine("UPDATE TPM600")
                    .AppendLine("   SET PRICE_RED = " & ReturnPriceReduce)
                    .AppendLine("     , UPDID     = '" & GC_UPDID & "'")
                    .AppendLine("     , UPDYMD    = '" & Now & "'")
                    .AppendLine(" WHERE GOODSCD   = '" & Trim$(objRows("GOODSCD")).ToString & "'")
                End With

                If Not GF_UpdData(stbSQL2.ToString) Then
                    Call GF_RollbackTrans()
                    Exit Function
                End If

            End If

            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' ÉgÉâÉìÉUÉNÉVÉáÉìämíË
        '------------------------------
        If Not GF_CommitTrans() Then
            Call GF_RollbackTrans()
            Exit Function
        End If

        '------------------------------
        ' ï‘ãpílê›íË
        '------------------------------
        LF_InsTPM600 = True

    End Function

    ''' <summary> 
    ''' --------------------------------------------------------------------------------
    ''' ã@Å@Å@î\ÅFê≈ÉXÉeÅ[É^ÉXÉRÉìÉ{çÏê¨èàóù
    ''' ã@î\äTóvÅFê≈ÉXÉeÅ[É^ÉXÇÃÉRÉìÉ{É{ÉbÉNÉXÇçÏê¨Ç∑ÇÈ
    ''' à¯Å@Å@êîÅF
    ''' ñﬂ ÇË ílÅF
    ''' óöÅ@Å@óÅF2019.08.08 ∏⁄Ω∫ñkó§)takigaura êVãKçÏê¨
    ''' --------------------------------------------------------------------------------
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LS_SetTaxTypeCombo(Optional ByVal pReducedType As String = "0")

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim strSQL As String = Nothing
        Dim objData As New DataSet()

        '------------------------------
        ' ëSè§ïiÉOÉãÅ[ÉvñºéÊìæ
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TAXTYPE, "
        strSQL = strSQL & "       NAME "
        strSQL = strSQL & "  FROM TPM610 "
        strSQL = strSQL & " WHERE REDUCEDTYPE = '" & pReducedType & "'"
        strSQL = strSQL & " ORDER BY TAXTYPE "

        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            objData = New DataSet()

            strSQL = ""
            strSQL = strSQL & "SELECT '0' AS TAXTYPE"
            strSQL = strSQL & "     ,  'dummy0' AS NAME"
            strSQL = strSQL & " UNION "
            strSQL = strSQL & "SELECT '1' AS TAXTYPE"
            strSQL = strSQL & "     ,  'dummy1' AS NAME"
            strSQL = strSQL & " UNION "
            strSQL = strSQL & "SELECT '2' AS TAXTYPE"
            strSQL = strSQL & "     ,  'dummy2' AS NAME"
            strSQL = strSQL & " UNION "
            strSQL = strSQL & "SELECT '3' AS TAXTYPE"
            strSQL = strSQL & "     ,  'dummy3' AS NAME"
            strSQL = strSQL & " UNION "
            strSQL = strSQL & "SELECT '4' AS TAXTYPE"
            strSQL = strSQL & "     ,  'dummy4' AS NAME"
            strSQL = strSQL & " UNION "
            strSQL = strSQL & "SELECT '5' AS TAXTYPE"
            strSQL = strSQL & "     ,  'dummy5' AS NAME"
            strSQL = strSQL & " UNION "
            strSQL = strSQL & "SELECT '99' AS TAXTYPE"
            strSQL = strSQL & "     ,  'dummy99' AS NAME"

            If Not GF_GetData(strSQL, objData) Then
                GoTo SYSTEM_ERROR
            End If
        End If

        '------------------------------
        ' ÉRÉìÉ{É{ÉbÉNÉXê›íË
        '------------------------------
        Try
            If pReducedType = "0" Then
                'ê≈ÉXÉeÅ[É^ÉX
                With cmb_TaxType
                    .DropDownStyle = ComboBoxStyle.DropDownList

                    .Items.Clear()  ' èâä˙ÉNÉäÉA

                    .DataSource = objData.Tables("com")
                    .DisplayMember = "NAME"
                    .ValueMember = "TAXTYPE"

                End With
            Else
                'åyå∏ê≈ó¶ ê≈ÉXÉeÅ[É^ÉX
                With cmb_TaxType_Reduced
                    .DropDownStyle = ComboBoxStyle.DropDownList

                    .Items.Clear()  ' èâä˙ÉNÉäÉA

                    .DataSource = objData.Tables("com")
                    .DisplayMember = "NAME"
                    .ValueMember = "TAXTYPE"

                End With
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetTaxTypeCombo")
    End Sub

    ''' <summary>
    ''' --------------------------------------------------------------------------------
    ''' ã@Å@Å@î\ÅFÉÅÉjÉÖÅ[ÉRÅ[Éhï“èWÉtÉâÉOïœçXéûèàóù
    ''' ã@î\äTóvÅFÉÅÉjÉÖÅ[ÉRÅ[Éhï“èWÉtÉâÉOÇÃÉ`ÉFÉbÉNÉIÉìÅ^ÉIÉtÇêÿÇËë÷Ç¶ÇΩèÍçáÇ…ÅAÉÅÉjÉÖÅ[ÉRÅ[ÉhÇÃäàê´(µ›)Å^îÒäàê´(µÃ)ÇêÿÇËë÷Ç¶ÇÈ
    ''' à¯Å@Å@êîÅF
    ''' ñﬂ ÇË ílÅF
    ''' óöÅ@Å@óÅF2019.08.09 ∏⁄Ω∫ñkó§)takigaura êVãKçÏê¨
    ''' --------------------------------------------------------------------------------
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chk_MenuCdEdit_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_MenuCdEdit.CheckedChanged
        txt_MenuCode.Enabled = chk_MenuCdEdit.Checked
    End Sub

    ''' <summary>
    ''' --------------------------------------------------------------------------------
    ''' ã@Å@Å@î\ÅFÉÅÉjÉÖÅ[ÉRÅ[Éhï“èWéûèàóù
    ''' ã@î\äTóvÅFÉÅÉjÉÖÅ[ÉRÅ[Éhï“èWéûÇ…ï“èWÉtÉâÉOÇÃïœçXÇ∆ïœçXì‡óeÇÃèëÇ´ñﬂÇµÇçsÇ§
    ''' à¯Å@Å@êîÅF
    ''' ñﬂ ÇË ílÅF
    ''' óöÅ@Å@óÅF2019.08.09 ∏⁄Ω∫ñkó§)takigaura êVãKçÏê¨
    ''' --------------------------------------------------------------------------------
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txt_MenuCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MenuCode.TextChanged
        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim lngST As Long

        If txt_MenuCode.Modified = False Then
            Exit Sub
        End If

        lngST = txt_MenuCode.SelectionStart
        If lngST >= 0 Then
            txt_MenuCode.SelectionStart = lngST
        End If

        If Len(Trim$(txt_MenuCode.Text)) = 0 Then
            txt_MenuCode.Text = "0"
        End If

        If IsNumeric(Trim$(txt_MenuCode.Text)) = False Then
            txt_MenuCode.Text = Long.Parse(lbl_GoodsCode.Text).ToString
        End If

        Call LS_WriteRetItemInfo()
    End Sub

    ''' <summary>
    ''' --------------------------------------------------------------------------------
    ''' ã@Å@Å@î\ÅFé©é–ÉRÅ[Éhï“èWéûèàóù
    ''' ã@î\äTóvÅFé©é–ÉRÅ[Éhï“èWéûÇ…ï“èWÉtÉâÉOÇÃïœçXÇ∆ïœçXì‡óeÇÃèëÇ´ñﬂÇµÇçsÇ§
    ''' à¯Å@Å@êîÅF
    ''' ñﬂ ÇË ílÅF
    ''' óöÅ@Å@óÅF2019.08.09 ∏⁄Ω∫ñkó§)takigaura êVãKçÏê¨
    ''' --------------------------------------------------------------------------------
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txt_OwnCompanyCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_OwnCompanyCode.TextChanged
        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim lngST As Long

        If txt_OwnCompanyCode.Modified = False Then
            Exit Sub
        End If

        lngST = txt_OwnCompanyCode.SelectionStart
        If lngST >= 0 Then
            txt_OwnCompanyCode.SelectionStart = lngST
        End If

        If Len(Trim$(txt_OwnCompanyCode.Text)) = 0 Then
            txt_OwnCompanyCode.Text = "0"
        End If

        If IsNumeric(Trim$(txt_OwnCompanyCode.Text)) = False Then
            txt_OwnCompanyCode.Text = "0"
        End If

        Call LS_WriteRetItemInfo()
    End Sub

    ''' <summary>
    ''' --------------------------------------------------------------------------------
    ''' ã@Å@Å@î\ÅFåyå∏ê≈ó¶ íPâøï“èWéûèàóù
    ''' ã@î\äTóvÅFåyå∏ê≈ó¶ íPâøï“èWéûÇ…ï“èWÉtÉâÉOÇÃïœçXÇ∆ïœçXì‡óeÇÃèëÇ´ñﬂÇµÇçsÇ§
    ''' à¯Å@Å@êîÅF
    ''' ñﬂ ÇË ílÅF
    ''' óöÅ@Å@óÅF2019.08.09 ∏⁄Ω∫ñkó§)takigaura êVãKçÏê¨
    ''' --------------------------------------------------------------------------------
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txt_Price_Reduce_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Price_Reduce.TextChanged

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim lngST As Long

        If txt_Price_Reduce.Modified = False Then
            Exit Sub
        End If

        lngST = txt_Price_Reduce.SelectionStart
        If lngST >= 0 Then
            txt_Price_Reduce.SelectionStart = lngST
        End If

        '------------------------------
        ' ì¸óÕí∑êßå¿
        '------------------------------
        If GF_LenB(txt_Price_Reduce.Text) > 6 Then
            txt_Price_Reduce.Text = GF_MidB(txt_Price_Reduce.Text, 1, 6)
            txt_Price_Reduce.SelectionStart = GF_LenB(txt_Price_Reduce.Text)
        End If

        If Len(Trim$(txt_Price_Reduce.Text)) = 0 Then
            txt_Price_Reduce.Text = "0"
        End If

        If IsNumeric(Trim$(txt_Price_Reduce.Text)) = False Then
            txt_Price_Reduce.Text = "0"
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    ''' <summary>
    ''' --------------------------------------------------------------------------------
    ''' ã@Å@Å@î\ÅFÉTÉuÉÅÉjÉÖÅ[íPâøï“èWéûèàóù
    ''' ã@î\äTóvÅFÉTÉuÉÅÉjÉÖÅ[íPâøï“èWéûÇ…ï“èWÉtÉâÉOÇÃïœçXÇ∆ïœçXì‡óeÇÃèëÇ´ñﬂÇµÇçsÇ§
    ''' à¯Å@Å@êîÅF
    ''' ñﬂ ÇË ílÅF
    ''' óöÅ@Å@óÅF2019.08.09 ∏⁄Ω∫ñkó§)takigaura êVãKçÏê¨
    ''' --------------------------------------------------------------------------------
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txt_SubPrice_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SubPrice.TextChanged

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim lngST As Long

        If txt_SubPrice.Modified = False Then
            Exit Sub
        End If

        lngST = txt_SubPrice.SelectionStart
        If lngST >= 0 Then
            txt_SubPrice.SelectionStart = lngST
        End If

        '------------------------------
        ' ì¸óÕí∑êßå¿
        '------------------------------
        If GF_LenB(txt_SubPrice.Text) > 6 Then
            txt_SubPrice.Text = GF_MidB(txt_SubPrice.Text, 1, 6)
            txt_SubPrice.SelectionStart = GF_LenB(txt_SubPrice.Text)
        End If

        If Len(Trim$(txt_SubPrice.Text)) = 0 Then
            txt_SubPrice.Text = "0"
        End If

        If IsNumeric(Trim$(txt_SubPrice.Text)) = False Then
            txt_SubPrice.Text = "0"
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    ''' <summary>
    ''' --------------------------------------------------------------------------------
    ''' ã@Å@Å@î\ÅFåyå∏ê≈ó¶ ÉTÉuÉÅÉjÉÖÅ[íPâø ï“èWéûèàóù
    ''' ã@î\äTóvÅFåyå∏ê≈ó¶ ÉTÉuÉÅÉjÉÖÅ[íPâøï“èWéûÇ…ï“èWÉtÉâÉOÇÃïœçXÇ∆ïœçXì‡óeÇÃèëÇ´ñﬂÇµÇçsÇ§
    ''' à¯Å@Å@êîÅF
    ''' ñﬂ ÇË ílÅF
    ''' óöÅ@Å@óÅF2019.08.09 ∏⁄Ω∫ñkó§)takigaura êVãKçÏê¨
    ''' --------------------------------------------------------------------------------
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txt_SubPrice_Reduce_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SubPrice_Reduce.TextChanged

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim lngST As Long

        If txt_SubPrice_Reduce.Modified = False Then
            Exit Sub
        End If

        lngST = txt_SubPrice_Reduce.SelectionStart
        If lngST >= 0 Then
            txt_SubPrice_Reduce.SelectionStart = lngST
        End If

        '------------------------------
        ' ì¸óÕí∑êßå¿
        '------------------------------
        If GF_LenB(txt_SubPrice_Reduce.Text) > 6 Then
            txt_SubPrice_Reduce.Text = GF_MidB(txt_SubPrice_Reduce.Text, 1, 6)
            txt_SubPrice_Reduce.SelectionStart = GF_LenB(txt_SubPrice_Reduce.Text)
        End If

        If Len(Trim$(txt_SubPrice_Reduce.Text)) = 0 Then
            txt_SubPrice_Reduce.Text = "0"
        End If

        If IsNumeric(Trim$(txt_SubPrice_Reduce.Text)) = False Then
            txt_SubPrice_Reduce.Text = "0"
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    ''' <summary>
    ''' --------------------------------------------------------------------------------
    ''' ã@Å@Å@î\ÅFê≈ÉXÉeÅ[É^ÉX ïœçXéûèàóù
    ''' ã@î\äTóvÅFê≈ÉXÉeÅ[É^ÉX ïœçXéûÇ…ï“èWÉtÉâÉOÇÃïœçXÇ∆ïœçXì‡óeÇÃèëÇ´ñﬂÇµÇçsÇ§
    ''' à¯Å@Å@êîÅF
    ''' ñﬂ ÇË ílÅF
    ''' óöÅ@Å@óÅF2019.08.09 ∏⁄Ω∫ñkó§)takigaura êVãKçÏê¨
    ''' --------------------------------------------------------------------------------
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmb_TaxType_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_TaxType.SelectionChangeCommitted

        Dim ReturnPriceReduce As String = Nothing
        Dim ReturnSubPriceReduce As String = Nothing

        'é©ìÆåvéZÇ≥ÇÍÇΩåyå∏ê≈ó¶íPâøÇÃéZèo
        If LF_AutomaticCalculationPrice(txt_Price.Text, ReturnPriceReduce) Then
            'éZèoÇ≈Ç´ÇΩèÍçáÇÕílÇîΩâf
            txt_Price_Reduce.Text = Format$(CLng(Trim$(ReturnPriceReduce)), "###,##0")
        End If

        'é©ìÆåvéZÇ≥ÇÍÇΩåyå∏ê≈ó¶ÉTÉuÉÅÉjÉÖÅ[íPâøÇÃéZèo
        If LF_AutomaticCalculationPrice(txt_SubPrice.Text, ReturnSubPriceReduce) Then
            'éZèoÇ≈Ç´ÇΩèÍçáÇÕílÇîΩâf
            txt_SubPrice_Reduce.Text = Format$(CLng(Trim$(ReturnSubPriceReduce)), "###,##0")
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    ''' <summary>
    ''' --------------------------------------------------------------------------------
    ''' ã@Å@Å@î\ÅFê≈ÉXÉeÅ[É^ÉX ïœçXéûèàóù
    ''' ã@î\äTóvÅFê≈ÉXÉeÅ[É^ÉX ïœçXéûÇ…ï“èWÉtÉâÉOÇÃïœçXÇ∆ïœçXì‡óeÇÃèëÇ´ñﬂÇµÇçsÇ§
    ''' à¯Å@Å@êîÅF
    ''' ñﬂ ÇË ílÅF
    ''' óöÅ@Å@óÅF2019.08.09 ∏⁄Ω∫ñkó§)takigaura êVãKçÏê¨
    ''' --------------------------------------------------------------------------------
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmb_TaxType_Reduced_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_TaxType_Reduced.SelectionChangeCommitted

        Dim ReturnPriceReduce As String = Nothing
        Dim ReturnSubPriceReduce As String = Nothing

        'é©ìÆåvéZÇ≥ÇÍÇΩåyå∏ê≈ó¶íPâøÇÃéZèo
        If LF_AutomaticCalculationPrice(lbl_Price.Text, ReturnPriceReduce) Then
            'éZèoÇ≈Ç´ÇΩèÍçáÇÕílÇîΩâf
            txt_Price_Reduce.Text = Format$(CLng(Trim$(ReturnPriceReduce)), "###,##0")
        End If

        'é©ìÆåvéZÇ≥ÇÍÇΩåyå∏ê≈ó¶ÉTÉuÉÅÉjÉÖÅ[íPâøÇÃéZèo
        If LF_AutomaticCalculationPrice(txt_SubPrice.Text, ReturnSubPriceReduce) Then
            'éZèoÇ≈Ç´ÇΩèÍçáÇÕílÇîΩâf
            txt_SubPrice_Reduce.Text = Format$(CLng(Trim$(ReturnSubPriceReduce)), "###,##0")
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    ''' <summary>
    ''' --------------------------------------------------------------------------------
    ''' ã@Å@Å@î\ÅFÉâÉWÉIÉ{É^Éì ïœçXéûèàóù
    ''' ã@î\äTóvÅFÉâÉWÉIÉ{É^Éì ïœçXéûÇ…ï“èWÉtÉâÉOÇÃïœçXÇ∆ïœçXì‡óeÇÃèëÇ´ñﬂÇµÇçsÇ§
    ''' à¯Å@Å@êîÅF
    ''' ñﬂ ÇË ílÅF
    ''' óöÅ@Å@óÅF2019.08.09 ∏⁄Ω∫ñkó§)takigaura êVãKçÏê¨
    ''' --------------------------------------------------------------------------------
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rbt_Ptype_Open_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbt_Ptype_Open.Click, rbt_Ptype_Preset.Click, rbt_Qadd_Disabled.Click, rbt_Qadd_Enabled.Click, rbt_Discount_Discount.Click, rbt_Discount_Extra.Click, rbt_Takeout_Both.Click, rbt_Takeout_Eatin.Click, rbt_Takeout_Takeout.Click, rbt_OES_Disabled.Click, rbt_OES_Enabled.Click

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub txt_MenuCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MenuCode.Enter

        ' êÊì™ÇÃÉ[ÉçÇèúãéÇ∑ÇÈ(É[ÉçñÑÇﬂÇÃèúãé)
        txt_MenuCode.Text = Long.Parse(txt_MenuCode.Text).ToString

    End Sub

    Private Sub txt_MenuCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MenuCode.Leave

        If IsNumeric(Trim$(txt_MenuCode.Text)) = False Then
            GF_Msg("", "ÉÅÉjÉÖÅ[ÉRÅ[ÉhÇÕêîílÇÃÇ›Çì¸óÕÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        'ê›íËílÇ™0ÇÃèÍçáÇÕè§ïiÉRÅ[ÉhÇê›íËÇ∑ÇÈ
        If Long.Parse(txt_MenuCode.Text).ToString.Equals("0") Then
            txt_MenuCode.Text = lbl_GoodsCode.Text
        End If

        ' É[ÉçñÑÇﬂÇçsÇ§
        txt_MenuCode.Text = CLng(Trim$(txt_MenuCode.Text)).ToString("00000000000000")

        'ê›íËÇµÇΩÉÅÉjÉÖÅ[ÉRÅ[ÉhÇÃèdï°É`ÉFÉbÉN
        If Not LF_ChkSameMenuCode() Then
            GF_Msg("", "ä˘Ç…ìØàÍÇÃåüçıî‘çÜÇ™ê›íËÇ≥ÇÍÇƒÇ¢Ç‹Ç∑ÅB", MsgBoxStyle.OkOnly)
            txt_MenuCode.Text = lbl_MenuCode.Text
        End If

        If GF_GetAppInfo("TEC_OWN_COM_CD_FLG") = GC_FALSE Then
            'é©é–ÉRÅ[Éh - èâä˙ílê›íËÇ†ÇË
            txt_OwnCompanyCode.Text = txt_MenuCode.Text
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub txt_OwnCompanyCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_OwnCompanyCode.Enter

        ' êÊì™ÇÃÉ[ÉçÇèúãéÇ∑ÇÈ(É[ÉçñÑÇﬂÇÃèúãé)
        txt_OwnCompanyCode.Text = Long.Parse(txt_OwnCompanyCode.Text).ToString

    End Sub

    Private Sub txt_OwnCompanyCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_OwnCompanyCode.Leave

        If IsNumeric(Trim$(txt_OwnCompanyCode.Text)) = False Then
            GF_Msg("", "é©é–ÉRÅ[ÉhÇÕêîílÇÃÇ›Çì¸óÕÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        ' É[ÉçñÑÇﬂÇçsÇ§
        txt_OwnCompanyCode.Text = CLng(Trim$(txt_OwnCompanyCode.Text)).ToString("00000000000000")

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub txt_Price_Reduce_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Price_Reduce.Enter

        ' ÉJÉìÉ}Çí∑Ç≥ÇOÇÃï∂éöóÒÇ…ReplaceÇ∑ÇÈ
        txt_Price_Reduce.Text = Replace(txt_Price_Reduce.Text, ",", "")

    End Sub

    Private Sub txt_Price_Reduce_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Price_Reduce.Leave

        If IsNumeric(Trim$(txt_Price_Reduce.Text)) = False Then
            GF_Msg("", "ã‡äzÇÕêîéöÇÃÇ›Çì¸óÕÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        ' ÉJÉìÉ}ï“èWÇçsÇ§
        txt_Price_Reduce.Text = Format$(CLng(Trim$(txt_Price_Reduce.Text)), "###,##0")

        'ÉeÉLÉXÉgÉ{ÉbÉNÉXÇ…ÉJÅ[É\ÉãÇ™ìñÇΩÇ¡ÇΩÇÃÇ›Ç≈ì¸óÕì‡óeÇ…ïœçXÇ™Ç»Ç¢èÍçáÇÕï€ë∂É{É^ÉìÇäàê´âªÇµÇ»Ç¢
        If Replace(txt_Price_Reduce.Text, ",", "") = lbl_Orig_Price_Reduce.Text Then
            Exit Sub
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub txt_SubPrice_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SubPrice.Enter

        ' ÉJÉìÉ}Çí∑Ç≥ÇOÇÃï∂éöóÒÇ…ReplaceÇ∑ÇÈ
        txt_SubPrice.Text = Replace(txt_SubPrice.Text, ",", "")

    End Sub

    Private Sub txt_SubPrice_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SubPrice.Leave

        Dim ReturnSubPriceReduce As String = Nothing

        If IsNumeric(Trim$(txt_SubPrice.Text)) = False Then
            GF_Msg("", "ã‡äzÇÕêîéöÇÃÇ›Çì¸óÕÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        ' ÉJÉìÉ}ï“èWÇçsÇ§
        txt_SubPrice.Text = Format$(CLng(Trim$(txt_SubPrice.Text)), "###,##0")

        'ÉeÉLÉXÉgÉ{ÉbÉNÉXÇ…ÉJÅ[É\ÉãÇ™ìñÇΩÇ¡ÇΩÇÃÇ›Ç≈ì¸óÕì‡óeÇ…ïœçXÇ™Ç»Ç¢èÍçáÇÕï€ë∂É{É^ÉìÇäàê´âªÇµÇ»Ç¢
        If Replace(txt_SubPrice.Text, ",", "") = lbl_Orig_SubPrice.Text Then
            Exit Sub
        End If

        'ílÇ…ïœçXÇ™ì¸Ç¡ÇΩèÍçáÇÕÉXÉeÅ[É^ÉXÇÃílÇÅuÉTÉuÅvÇ÷ïœçX
        chk_Status0.Checked = False
        chk_Status1.Checked = False
        chk_Status2.Checked = True
        chk_Status3.Checked = False

        'é©ìÆåvéZÇ≥ÇÍÇΩåyå∏ê≈ó¶ÉTÉuÉÅÉjÉÖÅ[íPâøÇÃéZèo
        If LF_AutomaticCalculationPrice(txt_SubPrice.Text, ReturnSubPriceReduce) Then
            'éZèoÇ≈Ç´ÇΩèÍçáÇÕílÇîΩâf
            txt_SubPrice_Reduce.Text = Format$(CLng(Trim$(ReturnSubPriceReduce)), "###,##0")
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    Private Sub txt_SubPrice_Reduce_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SubPrice_Reduce.Enter

        ' ÉJÉìÉ}Çí∑Ç≥ÇOÇÃï∂éöóÒÇ…ReplaceÇ∑ÇÈ
        txt_SubPrice_Reduce.Text = Replace(txt_SubPrice_Reduce.Text, ",", "")

    End Sub

    Private Sub txt_SubPrice_Reduce_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SubPrice_Reduce.Leave

        If IsNumeric(Trim$(txt_SubPrice_Reduce.Text)) = False Then
            GF_Msg("", "ã‡äzÇÕêîéöÇÃÇ›Çì¸óÕÇµÇƒÇ≠ÇæÇ≥Ç¢", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        ' ÉJÉìÉ}ï“èWÇçsÇ§
        txt_SubPrice_Reduce.Text = Format$(CLng(Trim$(txt_SubPrice_Reduce.Text)), "###,##0")

        'ÉeÉLÉXÉgÉ{ÉbÉNÉXÇ…ÉJÅ[É\ÉãÇ™ìñÇΩÇ¡ÇΩÇÃÇ›Ç≈ì¸óÕì‡óeÇ…ïœçXÇ™Ç»Ç¢èÍçáÇÕï€ë∂É{É^ÉìÇäàê´âªÇµÇ»Ç¢
        If Replace(txt_SubPrice_Reduce.Text, ",", "") = lbl_Orig_SubPrice_Reduce.Text Then
            Exit Sub
        End If

        Call LS_WriteRetItemInfo()

    End Sub

    ''' <summary>
    ''' --------------------------------------------------------------------------------
    ''' ã@Å@Å@î\ÅFèdï°É`ÉFÉbÉNèàóù
    ''' ã@î\äTóvÅFÉOÉäÉbÉhì‡ÇÃÉÅÉjÉÖÅ[ÉRÅ[ÉhàÍóóì‡Ç…ä˘Ç…ìoò^çœÇÃÉÅÉjÉÖÅ[ÉRÅ[ÉhÇ™Ç»Ç¢Ç©ämîFÇçsÇ§
    ''' à¯Å@Å@êîÅF
    ''' ñﬂ ÇË ílÅF
    ''' óöÅ@Å@óÅF2019.08.08 ∏⁄Ω∫ñkó§)takigaura êVãKçÏê¨
    ''' --------------------------------------------------------------------------------
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_ChkSameMenuCode() As Boolean

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim lngCnt As Long
        Dim blnFlg As Boolean = True

        '------------------------------
        ' èâä˙ílê›íË
        '------------------------------
        LF_ChkSameMenuCode = False

        '------------------------------
        ' èdï°É`ÉFÉbÉNèàóù
        '------------------------------
        With grd_ItemList
            For lngCnt = 0 To GF_GetRowCnt(grd_ItemList) - 1

                'ï“èWíÜÇÃçsÇÃÉÅÉjÉÖÅ[ÉRÅ[ÉhÇÕèdï°É`ÉFÉbÉNëŒè€äO
                If lngCnt <> CLng(txt_SelRow.Text) Then
                    If grd_ItemList(lngCnt, 40) = txt_MenuCode.Text Then
                        'ìØàÍÉÅÉjÉÖÅ[ÉRÅ[Éhë∂ç›
                        blnFlg = False
                        Exit For
                    End If
                End If

            Next
        End With

        '------------------------------
        ' ï‘ãpílê›íË
        '------------------------------
        If blnFlg Then
            LF_ChkSameMenuCode = True
        End If

    End Function

    ''' <summary>
    ''' --------------------------------------------------------------------------------
    ''' ã@Å@Å@î\ÅFåyå∏ê≈ó¶íPâøÅAåyå∏ê≈ó¶ÉTÉuÉÅÉjÉÖÅ[íPâø é©ìÆåvéZèàóù
    ''' ã@î\äTóvÅFê≈ÉXÉeÅ[É^ÉXÅAåyå∏ê≈ó¶ê≈ÉXÉeÅ[É^ÉXÅAíPâøÅAÉTÉuÉÅÉjÉÖÅ[íPâøÇÃê›íËéûÇ…åyå∏ê≈ó¶íPâøÅAåyå∏ê≈ó¶ÉTÉuÉÅÉjÉÖÅ[íPâøÇé©ìÆåvéZÇ∑ÇÈ
    ''' à¯Å@Å@êîÅF
    ''' ñﬂ ÇË ílÅF
    ''' óöÅ@Å@óÅF2019.09.04 ÉNÉåÉXÉRñkó§ êVãKçÏê¨
    ''' --------------------------------------------------------------------------------
    ''' </summary>
    ''' <param name="pPrice">íPâøÇ‹ÇΩÇÕÉTÉuÉÅÉjÉÖÅ[íPâø</param>
    ''' <param name="pRedecePrice">åyå∏ê≈ó¶åvéZåãâ íl</param>
    ''' <param name="pKbn">ãÛîíÅFâÊñ ì‡ïœçXéûÅA"init"ÅFèâä˙ï\é¶éû</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_AutomaticCalculationPrice(ByVal pPrice As String, ByRef pRedecePrice As String, Optional ByVal pKbn As String = "") As Boolean

        '------------------------------
        ' ì‡ïîïœêîíËã`
        '------------------------------
        Dim strSQL As String = Nothing
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strTaxationType(1) As String
        Dim strTaxRate(1) As String
        Dim strRounding(1) As String
        Dim lngInputPrice As Long
        Dim lngHontaiPrice As Long

        '------------------------------
        ' èâä˙ílê›íË
        '------------------------------
        LF_AutomaticCalculationPrice = False

        lngCnt = 0
        lngInputPrice = CLng(pPrice)
        lngHontaiPrice = 0

        Try
            '------------------------------
            ' ëŒè€è§ïiÇÃê≈èÓïÒÇéÊìæ
            '------------------------------
            strSQL = ""
            strSQL = strSQL & "SELECT TAXTYPE"
            strSQL = strSQL & "     , REDUCEDTYPE"
            strSQL = strSQL & "     , TAXATIONTYPE"
            strSQL = strSQL & "     , TAXRATE"
            strSQL = strSQL & "     , ROUNDING"
            strSQL = strSQL & "  FROM TPM610"
            strSQL = strSQL & " WHERE REDUCEDTYPE = '0'"
            If pKbn = "" Then
                'íPâøïœçXéû
                strSQL = strSQL & "   AND TAXTYPE     = '" & cmb_TaxType.SelectedValue & "'"
            Else
                'êVãKí«â¡éû
                strSQL = strSQL & "   AND TAXTYPE     = '0'"
            End If
            strSQL = strSQL & " UNION "
            strSQL = strSQL & "SELECT TAXTYPE"
            strSQL = strSQL & "     , REDUCEDTYPE"
            strSQL = strSQL & "     , TAXATIONTYPE"
            strSQL = strSQL & "     , TAXRATE"
            strSQL = strSQL & "     , ROUNDING"
            strSQL = strSQL & "  FROM TPM610"
            strSQL = strSQL & " WHERE REDUCEDTYPE = '1'"
            If pKbn = "" Then
                'íPâøïœçXéû
                strSQL = strSQL & "   AND TAXTYPE     = '" & cmb_TaxType_Reduced.SelectedValue & "'"
            Else
                'êVãKí«â¡éû
                strSQL = strSQL & "   AND TAXTYPE     = '0'"
            End If
            strSQL = strSQL & " ORDER BY REDUCEDTYPE"

            If Not GF_GetData(strSQL, objData) Then
                Exit Function
            End If

            If objData.Tables("com").Rows.Count = 0 Then
                Exit Function
            End If

            '------------------------------
            ' ÉRÉìÉ{É{ÉbÉNÉXê›íË
            '------------------------------
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    Exit Function
                End If

                strTaxationType(lngCnt) = Trim$(objRows("TAXATIONTYPE")).ToString
                strTaxRate(lngCnt) = Trim$(objRows("TAXRATE")).ToString
                strRounding(lngCnt) = Trim$(objRows("ROUNDING")).ToString

                lngCnt = lngCnt + 1

                If lngCnt >= 2 Then
                    Exit While
                End If
            End While

            'ê≈ÉXÉeÅ[É^ÉXÇ∆åyå∏ê≈ó¶ÉXÉeÅ[É^ÉXÇÃílÉ`ÉFÉbÉN
            If strTaxationType(0) = "0" And strTaxationType(1) = "0" Then
                'ê≈ÉXÉeÅ[É^ÉXÇ∆åyå∏ê≈ó¶ÉXÉeÅ[É^ÉXÇ™ã§Ç…"äOê≈"ÇÃèÍçá
                pRedecePrice = lngInputPrice.ToString

            ElseIf strTaxationType(0) = "1" And strTaxationType(1) = "1" Then
                'ê≈ÉXÉeÅ[É^ÉXÇ∆åyå∏ê≈ó¶ÉXÉeÅ[É^ÉXÇ™ã§Ç…"ì‡ê≈"ÇÃèÍçá
                'ñ{ëÃâøäiÇÃéZèo
                Select Case strRounding(0)
                    Case "0"
                        'êÿéÃÇƒ
                        lngHontaiPrice = Math.Ceiling(Math.Abs(lngInputPrice) / (1D + (CDec(strTaxRate(0)) / 100))) * If(lngInputPrice >= 0, 1, -1)
                    Case "1"
                        'êÿÇËè„Ç∞
                        lngHontaiPrice = Math.Truncate(lngInputPrice / (1D + (CDec(strTaxRate(0)) / 100)))
                    Case "2"
                        'éléÃå‹ì¸
                        lngHontaiPrice = Math.Ceiling((lngInputPrice - 0.5D) / (1D + (CDec(strTaxRate(0)) / 100)))
                    Case Else
                        'àŸèÌílê›íËÇÃèÍçá
                        lngHontaiPrice = 0
                End Select

                'åyå∏ê≈ó¶íPâøÇÃéZèo
                Select Case strRounding(1)
                    Case "0"
                        'êÿéÃÇƒ
                        pRedecePrice = Math.Floor(lngHontaiPrice * (1D + (CDec(strTaxRate(1)) / 100))).ToString
                    Case "1"
                        'êÿÇËè„Ç∞
                        pRedecePrice = Math.Ceiling(lngHontaiPrice * (1D + (CDec(strTaxRate(1)) / 100))).ToString
                    Case "2"
                        'éléÃå‹ì¸
                        pRedecePrice = Math.Round(lngHontaiPrice * (1D + (CDec(strTaxRate(1)) / 100)), MidpointRounding.AwayFromZero).ToString
                    Case Else
                        'àŸèÌílê›íËÇÃèÍçá
                        pRedecePrice = "0"
                End Select

            Else
                'ê≈ÉXÉeÅ[É^ÉXÇ∆åyå∏ê≈ó¶ÉXÉeÅ[É^ÉXÇ™àŸÇ»ÇÈèÍçá
                Exit Function
            End If

        Catch
            GoTo SYSTEM_ERROR
        End Try

        '------------------------------
        ' ï‘ãpílê›íË
        '------------------------------
        LF_AutomaticCalculationPrice = True

        Exit Function

SYSTEM_ERROR:
        Call GS_ErrorTerm("LF_AutomaticCalculationPrice")


    End Function


    Private Sub cbo_OP6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_OP6.Click
        L_OptionIndex = cbo_OP6.SelectedIndex
    End Sub

    Private Sub UpperBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UpperBox.KeyPress
        ' ëSäpì¸óÕ
        If GF_GetAppInfo("PRINT_FLG") = "1" Then
            ' ëSäpì¸óÕ
            e.KeyChar = StrConv(e.KeyChar, VbStrConv.Wide)
        ElseIf GF_GetAppInfo("PRINT_FLG") = "2" Then
            ' îºäpì¸óÕ
            e.KeyChar = StrConv(e.KeyChar, VbStrConv.Narrow)
        End If
    End Sub

    Private Sub LowerBoxKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LowerBox.KeyPress
        ' ëSäpì¸óÕs
        If GF_GetAppInfo("PRINT_FLG") = "1" Then
            ' ëSäpì¸óÕ
            e.KeyChar = StrConv(e.KeyChar, VbStrConv.Wide)
        ElseIf GF_GetAppInfo("PRINT_FLG") = "2" Then
            ' îºäpì¸óÕ
            e.KeyChar = StrConv(e.KeyChar, VbStrConv.Narrow)
        End If
    End Sub

    Private Sub UpperBoxTextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpperBox.TextChanged
        If UpperBox.Text.Length > 8 Then
            UpperBox.Text = UpperBox.Text.Substring(0, 8)
        End If

        Call TextBoxTextChanged(UpperBox, VbStrConv.Wide, 20)
    End Sub
    Private Sub LowerBoxTextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LowerBox.TextChanged
        If LowerBox.Text.Length > 10 Then
            LowerBox.Text = LowerBox.Text.Substring(0, 10)
        End If

        Call TextBoxTextChanged(LowerBox, VbStrConv.Wide, 20)
    End Sub

    Private Sub grd_ItemList_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grd_ItemList.MouseDown 'Gert 04/01
        Dim hi As DataGrid.HitTestInfo
        Dim datastyle As DataGridTableStyle
        Dim columnstyle As DataGridColumnStyle

        hi = grd_ItemList.HitTest(e.X, e.Y)
        If (hi.Type = System.Windows.Forms.DataGrid.HitTestType.Cell) And (hi.Row = grd_ItemList.CurrentRowIndex) Then
            datastyle = grd_ItemList.TableStyles.Item(0)
            columnstyle = datastyle.GridColumnStyles(hi.Column)
            If columnstyle.GetType().FullName = "System.Windows.Forms.DataGridBoolColumn" Then
                L_blnEditFlg = True
                btn_Save.BackColor = Color.Yellow
                grd_ItemList(grd_ItemList.CurrentRowIndex, 14) = GC_TRUE
            End If
        End If
    End Sub
End Class

