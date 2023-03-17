' --------------------------------------------------------------------------------
' 　機　　能：CrossNavi - 開店処理画面
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2011.11.07 ソラン北陸 新規作成
' --------------------------------------------------------------------------------
Public Class CNL2020
    Inherits System.Windows.Forms.Form

    'その他
    Private _スマレジ連携履歴更新情報 As スマレジ連携履歴更新情報型

    'スマレジ HTTPステータス
    Private Const HTTP_OK As String = "200 OK"
    Private Const HTTP_BAD_REQUEST As String = "400 BadRequest"
    Private Const HTTP_NOT_FOUND As String = "404 Not Found"
    Friend WithEvents btn_OutputGoodsData As System.Windows.Forms.Button
    Friend WithEvents btn_KioskGoodsData As System.Windows.Forms.Button
    Private Const HTTP_想定外エラー As String = "接続エラー"

#Region "構造体"

    Private Structure スマレジ連携履歴更新情報型
        Dim 取込正常件数 As Integer
        Dim 取込エラーコード As String
        Dim 取込エラー内容 As String
        Dim 取込エラー詳細 As String
        Dim HTTPステータス As String

        Public Sub Initialize()
            取込正常件数 = 0
            取込エラーコード = ""
            取込エラー内容 = ""
            取込エラー詳細 = ""
            HTTPステータス = ""
        End Sub

    End Structure

#End Region

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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_MenuChg As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_AdvChg As System.Windows.Forms.ComboBox
    Friend WithEvents lsv_TermList As System.Windows.Forms.ListView
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents btn_TermChk As System.Windows.Forms.Button
    Friend WithEvents mnu_End As System.Windows.Forms.MenuItem
    Friend WithEvents btn_Start As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_UpdFUMENU As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_SMAREGI As System.Windows.Forms.Button
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CNL2020))
        Me.cbo_MenuChg = New System.Windows.Forms.ComboBox
        Me.cbo_AdvChg = New System.Windows.Forms.ComboBox
        Me.lsv_TermList = New System.Windows.Forms.ListView
        Me.stb_Msg = New System.Windows.Forms.StatusBar
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.mnu_End = New System.Windows.Forms.MenuItem
        Me.btn_TermChk = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_KioskGoodsData = New System.Windows.Forms.Button
        Me.btn_OutputGoodsData = New System.Windows.Forms.Button
        Me.btn_SMAREGI = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_UpdFUMENU = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_Start = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbo_MenuChg
        '
        Me.cbo_MenuChg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_MenuChg.Location = New System.Drawing.Point(27, 21)
        Me.cbo_MenuChg.Name = "cbo_MenuChg"
        Me.cbo_MenuChg.Size = New System.Drawing.Size(279, 23)
        Me.cbo_MenuChg.TabIndex = 30
        Me.cbo_MenuChg.Text = "ComboBox1"
        '
        'cbo_AdvChg
        '
        Me.cbo_AdvChg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_AdvChg.Location = New System.Drawing.Point(27, 21)
        Me.cbo_AdvChg.Name = "cbo_AdvChg"
        Me.cbo_AdvChg.Size = New System.Drawing.Size(279, 23)
        Me.cbo_AdvChg.TabIndex = 31
        Me.cbo_AdvChg.Text = "ComboBox2"
        '
        'lsv_TermList
        '
        Me.lsv_TermList.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_TermList.Location = New System.Drawing.Point(208, 155)
        Me.lsv_TermList.Name = "lsv_TermList"
        Me.lsv_TermList.Size = New System.Drawing.Size(790, 495)
        Me.lsv_TermList.TabIndex = 5
        Me.lsv_TermList.UseCompatibleStateImageBehavior = False
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 665)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(1016, 24)
        Me.stb_Msg.TabIndex = 5
        Me.stb_Msg.Text = "StatusBar1"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = -1
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.mnu_End})
        Me.MenuItem1.Text = "開店処理"
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
        'btn_TermChk
        '
        Me.btn_TermChk.BackColor = System.Drawing.SystemColors.Control
        Me.btn_TermChk.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_TermChk.Location = New System.Drawing.Point(609, 10)
        Me.btn_TermChk.Name = "btn_TermChk"
        Me.btn_TermChk.Size = New System.Drawing.Size(180, 50)
        Me.btn_TermChk.TabIndex = 2
        Me.btn_TermChk.Text = "電源の確認"
        Me.btn_TermChk.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_KioskGoodsData)
        Me.Panel1.Controls.Add(Me.btn_OutputGoodsData)
        Me.Panel1.Controls.Add(Me.btn_SMAREGI)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_UpdFUMENU)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btn_Start)
        Me.Panel1.Controls.Add(Me.btn_TermChk)
        Me.Panel1.Controls.Add(Me.lsv_TermList)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 10
        '
        'btn_KioskGoodsData
        '
        Me.btn_KioskGoodsData.BackColor = System.Drawing.SystemColors.Control
        Me.btn_KioskGoodsData.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btn_KioskGoodsData.Location = New System.Drawing.Point(417, 10)
        Me.btn_KioskGoodsData.Name = "btn_KioskGoodsData"
        Me.btn_KioskGoodsData.Size = New System.Drawing.Size(180, 50)
        Me.btn_KioskGoodsData.TabIndex = 156
        Me.btn_KioskGoodsData.Text = "商品マスタCSV出力"
        Me.btn_KioskGoodsData.UseVisualStyleBackColor = False
        Me.btn_KioskGoodsData.Visible = False
        '
        'btn_OutputGoodsData
        '
        Me.btn_OutputGoodsData.BackColor = System.Drawing.SystemColors.Control
        Me.btn_OutputGoodsData.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btn_OutputGoodsData.Location = New System.Drawing.Point(417, 10)
        Me.btn_OutputGoodsData.Name = "btn_OutputGoodsData"
        Me.btn_OutputGoodsData.Size = New System.Drawing.Size(180, 50)
        Me.btn_OutputGoodsData.TabIndex = 155
        Me.btn_OutputGoodsData.Text = "商品マスタCSV出力"
        Me.btn_OutputGoodsData.UseVisualStyleBackColor = False
        Me.btn_OutputGoodsData.Visible = False
        '
        'btn_SMAREGI
        '
        Me.btn_SMAREGI.BackColor = System.Drawing.SystemColors.Control
        Me.btn_SMAREGI.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btn_SMAREGI.Location = New System.Drawing.Point(417, 10)
        Me.btn_SMAREGI.Name = "btn_SMAREGI"
        Me.btn_SMAREGI.Size = New System.Drawing.Size(180, 50)
        Me.btn_SMAREGI.TabIndex = 154
        Me.btn_SMAREGI.Text = "スマレジデータ更新"
        Me.btn_SMAREGI.UseVisualStyleBackColor = False
        Me.btn_SMAREGI.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(423, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 30)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "パネルを注文画面に" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   切り替えます"
        '
        'btn_UpdFUMENU
        '
        Me.btn_UpdFUMENU.BackColor = System.Drawing.SystemColors.Control
        Me.btn_UpdFUMENU.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btn_UpdFUMENU.Location = New System.Drawing.Point(417, 10)
        Me.btn_UpdFUMENU.Name = "btn_UpdFUMENU"
        Me.btn_UpdFUMENU.Size = New System.Drawing.Size(180, 50)
        Me.btn_UpdFUMENU.TabIndex = 152
        Me.btn_UpdFUMENU.Text = "POSデータ更新"
        Me.btn_UpdFUMENU.UseVisualStyleBackColor = False
        Me.btn_UpdFUMENU.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(793, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 30)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "電源が「×」の場合は" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   機械の電源を確認してください"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(204, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(794, 1)
        Me.Label11.TabIndex = 148
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.cbo_MenuChg)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(243, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 56)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "現在表示中のメニューです"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.cbo_AdvChg)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(630, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 56)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "現在表示中のお知らせです"
        '
        'btn_Start
        '
        Me.btn_Start.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Start.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Start.Location = New System.Drawing.Point(219, 10)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(180, 50)
        Me.btn_Start.TabIndex = 1
        Me.btn_Start.Text = "営業開始"
        Me.btn_Start.UseVisualStyleBackColor = False
        '
        'CNL2020
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1016, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stb_Msg)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CNL2020"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub CNL2020_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objForm As New CNL1810()

        Try
            '------------------------------
            ' フォーム名称設定
            '------------------------------
            Me.Text = " 開店処理 "

            '---------------------------------
            '閉じるボタン非表示化
            '---------------------------------
            Me.ControlBox = False

            '------------------------------
            ' 起動ステータス表示
            '------------------------------
            objForm.Show()
            objForm.lbl_Msg.Text = "起動処理中です。しばらくお待ちください..."
            objForm.TopMost = True
            System.Windows.Forms.Application.DoEvents()

            '------------------------------
            ' 初期化処理
            '------------------------------
            Call GS_StatusSetup(stb_Msg)
            cbo_MenuChg.DropDownStyle = ComboBoxStyle.DropDownList
            cbo_AdvChg.DropDownStyle = ComboBoxStyle.DropDownList

            '------------------------------
            ' POSデータ更新ボタン表示制御
            '------------------------------
            If GF_GetAppInfo("OES_TOOL_VER_CNL1501") = "1" Then
                Label1.Visible = False
                btn_UpdFUMENU.Visible = True
            Else
                Label1.Visible = True
                btn_UpdFUMENU.Visible = False
            End If

            '------------------------------
            ' スマレジデータ更新ボタン表示制御
            '------------------------------
            If GF_GetAppInfo("SMAREGI_FLG") = "1" Then
                Label1.Visible = False
                btn_UpdFUMENU.Visible = False
                btn_SMAREGI.Visible = True
                btn_OutputGoodsData.Visible = False
                btn_KioskGoodsData.Visible = False ' --- (2022.09.01) Kiosk自動精算機連携
            Else
                btn_SMAREGI.Visible = False
            End If

            '------------------------------
            ' 商品マスタCSV出力ボタン表示制御（テラオカレジ連携）
            '------------------------------
            If GF_GetAppInfo("TERAOKA_FLG") = "1" Then
                Label1.Visible = False
                btn_UpdFUMENU.Visible = False
                btn_SMAREGI.Visible = False
                btn_OutputGoodsData.Visible = True
                btn_KioskGoodsData.Visible = False ' --- (2022.09.01) Kiosk自動精算機連携
            Else
                btn_OutputGoodsData.Visible = False
            End If

            ' --- (2022.09.01) Kiosk自動精算機連携 --------------
            '------------------------------
            ' 商品マスタCSV出力ボタン表示制御（Kiosk自動精算機連携）
            '------------------------------
            If GF_GetAppInfo2("KIOSK_QR_FLG") = "1" Then
                Label1.Visible = False
                btn_UpdFUMENU.Visible = False
                btn_SMAREGI.Visible = False
                btn_OutputGoodsData.Visible = False
                btn_KioskGoodsData.Visible = True
            Else
                btn_KioskGoodsData.Visible = False
            End If
            ' --- (2022.09.01) Kiosk自動精算機連携 --------------

            '------------------------------
            ' メニュー/広告切替コンボ設定
            '------------------------------
            Call LS_MenuCmbSetup()
            Call LS_AdvCmbSetup()

            '------------------------------
            ' 管理マスタより現況設定
            '------------------------------
            Call LS_SetStatus()

            '------------------------------
            ' プログレスバー表示
            '------------------------------
            Dim i As Integer = 0
            For i = 1 To 20
                Threading.Thread.Sleep(250)
                objForm.pgs_Status.Value = 5 * i
            Next

            '------------------------------
            ' 端末機稼動確認スレッド開始
            '------------------------------
            G_Thread = New Threading.Thread(AddressOf LS_CheckPingResult)
            G_Thread.Start()

            '------------------------------
            ' 起動ステータスクローズ
            '------------------------------
            objForm.Close()

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL2020_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：端末機一覧 設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetTermList()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow
        Dim lngCnt As Long
        Dim objItem As ListViewItem

        '------------------------------
        ' 初期設定
        '------------------------------
        Control.CheckForIllegalCrossThreadCalls = False
        With lsv_TermList
            .BeginUpdate()
            .Items.Clear()
            .Columns.Clear()

            .View = View.Details
            .FullRowSelect = True
            .Columns.Add("", 0, HorizontalAlignment.Left)
            .Columns.Add("電源", 96, HorizontalAlignment.Center)
            .Columns.Add("座席番号", 96, HorizontalAlignment.Center)
            .Columns.Add("機器区分", 216, HorizontalAlignment.Left)
            .Columns.Add("ＩＰアドレス", 144, HorizontalAlignment.Left)
        End With

        '------------------------------
        ' 端末機一覧取得
        '------------------------------
        If Not LF_GetTPM050(objData) Then
            GoTo SYSTEM_ERROR
        End If

        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count
            objRows = Nothing
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                GoTo SYSTEM_ERROR
            End If

            objItem = New ListViewItem()
            With objItem
                .Text = ""
                .SubItems.Add("---")
                .SubItems.Add(Trim$(IIf(IsDBNull(objRows("SEATID")), "-", objRows("SEATID"))))
                .SubItems.Add(Trim$(IIf(IsDBNull(objRows("CODENM")), System.Configuration.ConfigurationManager.AppSettings("OrderPanelNotAssigned"), objRows("CODENM"))))
                .SubItems.Add(objRows("TERMID"))
            End With
            lsv_TermList.Items.Add(objItem)

            lngCnt = lngCnt + 1
        End While

        lsv_TermList.EndUpdate()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetTermList")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：端末機一覧 取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM050(ByRef pData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM050 = False

        '------------------------------
        ' ＳＱＬ文生成
        '------------------------------
        '配席機能修正
        If GF_GetAppInfo("SEAT_DISTRIBUTION ") = "0" Then
            strSQL = ""
            strSQL = strSQL & "SELECT TPM051.REALTERMID AS TERMID,"
            strSQL = strSQL & "       TPM050.SEATID,"
            strSQL = strSQL & "       TPM030.CODENM"
            strSQL = strSQL & "  FROM TPM051"
            strSQL = strSQL & "       LEFT JOIN TPM050 ON TPM051.VIRTUALTERMID = TPM050.TERMID"
            strSQL = strSQL & "       LEFT JOIN TPM030 ON TPM050.TERMKIND      = TPM030.CODEVAL"
            strSQL = strSQL & "   AND TPM030.CODEID   = 'TERMKIND'"
            strSQL = strSQL & " UNION "
            strSQL = strSQL & "SELECT TPM050.TERMID,"
            strSQL = strSQL & "       TPM050.SEATID,"
            strSQL = strSQL & "       TPM030.CODENM"
            strSQL = strSQL & "  FROM TPM050,"
            strSQL = strSQL & "       TPM030"
            strSQL = strSQL & " WHERE TPM050.TERMKIND = TPM030.CODEVAL"
            strSQL = strSQL & "   AND TPM030.CODEID   = 'TERMKIND'"
            strSQL = strSQL & "   AND TPM050.TERMKIND NOT IN ('TCA','TC0')"
        Else
            strSQL = ""
            strSQL = strSQL & "SELECT TPM050.TERMID,"
            strSQL = strSQL & "       TPM050.SEATID,"
            strSQL = strSQL & "       TPM030.CODENM"
            strSQL = strSQL & "  FROM TPM050,"
            strSQL = strSQL & "       TPM030"
            strSQL = strSQL & " WHERE TPM050.TERMKIND = TPM030.CODEVAL"
            strSQL = strSQL & "   AND TPM030.CODEID   = 'TERMKIND'"
            strSQL = strSQL & " ORDER BY TPM050.TERMKIND,"
            strSQL = strSQL & "          TPM050.SEATID"
        End If

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pData = objData
        LF_GetTPM050 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニュー切替コンボ設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_MenuCmbSetup()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow
        Dim lngCnt As Long
        Dim strMenuOID As String
        Dim strMenuNM As String
        Dim strMenuID As String

        '------------------------------
        ' メニューリスト取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM060.MENUID,"
        strSQL = strSQL & "       TPM060.MENUNM,"
        strSQL = strSQL & "       MAX(TPM060.UPDYMD) AS MAXYMD"
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " GROUP BY TPM060.MENUID,"
        strSQL = strSQL & "          TPM060.MENUNM"
        strSQL = strSQL & " ORDER BY TPM060.MENUNM,"
        strSQL = strSQL & "          TPM060.MENUID"

        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' メニュー選択コンボ設定
        '------------------------------
        Try
            cbo_MenuChg.Items.Clear()
            lngCnt = 0
            strMenuNM = ""
            strMenuID = ""
            strMenuOID = ""

            While lngCnt < objData.Tables("com").Rows.Count
                objRows = Nothing
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    GoTo SYSTEM_ERROR
                End If

                If lngCnt = 0 Then
                    strMenuNM = Trim$(objRows("MENUNM"))
                    strMenuID = Trim$(objRows("MENUID"))
                    strMenuOID = Trim$(objRows("MENUID"))
                End If

                If strMenuNM <> Trim$(objRows("MENUNM")) Then
                    Call GS_CboItemSet(cbo_MenuChg, strMenuNM, strMenuID & vbTab & strMenuOID)
                    strMenuOID = Trim$(objRows("MENUID"))
                End If

                strMenuNM = Trim$(objRows("MENUNM"))
                strMenuID = Trim$(objRows("MENUID"))

                lngCnt = lngCnt + 1
            End While

            Call GS_CboItemSet(cbo_MenuChg, strMenuNM, strMenuID & vbTab & strMenuOID)

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_MenuCmbSetup")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告切替コンボ設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_AdvCmbSetup()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow
        Dim lngCnt As Long

        '------------------------------
        ' 広告リスト取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM080.ADVGRP_ID,"
        strSQL = strSQL & "       TPM080.ADVGRP_NM"
        strSQL = strSQL & "  FROM TPM080"
        strSQL = strSQL & " GROUP BY TPM080.ADVGRP_ID,"
        strSQL = strSQL & "          TPM080.ADVGRP_NM"

        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' 広告選択コンボ設定
        '------------------------------
        Try
            cbo_AdvChg.Items.Clear()
            lngCnt = 0

            While lngCnt < objData.Tables("com").Rows.Count
                objRows = Nothing
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    GoTo SYSTEM_ERROR
                End If

                Call GS_CboItemSet(cbo_AdvChg, Trim$(objRows("ADVGRP_NM")), Trim$(objRows("ADVGRP_ID")))

                lngCnt = lngCnt + 1
            End While

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AdvCmbSetup")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：現在設定値 表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetStatus()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' システム管理マスタ取得
        '------------------------------
        If Not LF_GetTPM040(objRows) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' 現在設定値 表示処理
        '------------------------------
        Call GS_CboChgSel(cbo_MenuChg, Trim$(objRows("DEFMENUID")))
        Call GS_CboChgSel(cbo_AdvChg, Trim$(objRows("DEFADVID")))

        If Trim$(objRows("CLMODE")) = GC_TRUE Then
            '------------------------------
            ' ボタン使用可否設定
            '------------------------------
            btn_Start.Enabled = False

            '---------------------------------
            '開店表示変更
            '---------------------------------
            btn_Start.Text = "営業中"
        Else
            '------------------------------
            ' ボタン使用可否設定
            '------------------------------
            btn_Start.Enabled = True

            '---------------------------------
            '閉店表示変更
            '---------------------------------
            btn_Start.Text = "営業開始"
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetStatus")
    End Sub

    Private Function LF_GetTPM040(ByRef pRows As DataRow) As Boolean

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
        ' システム管理マスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM040.DEFMENUID,"
        strSQL = strSQL & "       TPM040.DEFADVID,"
        strSQL = strSQL & "       TPM040.CLMODE"
        strSQL = strSQL & "  FROM TPM040"

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
        ' 返却値設定
        '------------------------------
        LF_GetTPM040 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：端末稼動状況確認処理スレッド定義
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_CheckPingResult()

        Do
            Call LS_SetTermList()

            If Not LF_CheckPingResult() Then
                GoTo SYSTEM_ERROR
            End If

            Threading.Thread.Sleep(1000 * CLng(GF_GetAppInfo("CHK_TERM_INFO")))
        Loop

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_CheckPingResult")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：端末機稼動状況 確認
    ' 　機能概要：全端末機に対し、PINGパケットの応答により稼動状況を判定する
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_CheckPingResult() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim intProcID As Integer
        Dim objFile As System.IO.StreamReader
        Dim strLine As String
        Dim lngCnt As Long = Nothing
        Dim lngMaxRow As Long = Nothing
        Dim strTargetIP As String
        Dim strTempFile As String
        Dim strResult As String
        Dim objItem As ListViewItem
        Dim inrPingTime As Integer

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_CheckPingResult = False

        Try
            btn_TermChk.Enabled = False

            '------------------------------
            ' PING送出時間設定
            '------------------------------
            inrPingTime = 1000 * CLng(GF_GetAppInfo("CHK_PING_INFO"))

            For Each objItem In lsv_TermList.Items
                '------------------------------
                ' 調査対象端末
                '------------------------------
                strTargetIP = Trim$(objItem.SubItems(4).Text)
                strTempFile = g_udtAppConfig.strTempPath & "\" & Replace(strTargetIP, ".", "_") & ".txt"

                '------------------------------
                ' PINGパケット送出
                '------------------------------
                intProcID = Shell("cmd.exe /C ping.exe -n 2 " & strTargetIP & " > """ & strTempFile & """", AppWinStyle.Hide, True, inrPingTime)

                '------------------------------
                ' 結果ファイルより判定
                '------------------------------
                If intProcID = 0 Then
                    objFile = New System.IO.StreamReader(strTempFile, System.Text.Encoding.Default)
                    strLine = objFile.ReadLine

                    strResult = ""
                    While Not strLine Is Nothing
                        If strLine.IndexOf("100% の損失") <> -1 Then
                            ' If strLine.IndexOf("100% loss") <> -1 Then
                            strResult = "×"
                            Exit While
                        End If
                        strLine = objFile.ReadLine
                    End While

                    If Len(Trim$(strResult)) = 0 Then
                        objItem.SubItems(1).Text = "○"
                    Else
                        objItem.SubItems(1).Text = strResult
                    End If

                    objFile.Close()
                    System.IO.File.Delete(strTempFile)
                Else
                    objItem.SubItems(1).Text = "×"
                End If

                System.Windows.Forms.Application.DoEvents()
            Next

            btn_TermChk.Enabled = True

        Catch ex As System.Threading.ThreadAbortException
            Exit Try
        Catch
            btn_TermChk.Enabled = True
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_CheckPingResult = True

    End Function

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
    ' 　機　　能：電源確認ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_TermChk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TermChk.Click

        G_Thread.Abort()
        G_Thread = New Threading.Thread(AddressOf LS_CheckPingResult)
        G_Thread.Start()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニュー切替コンボ 選択状態変化時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub cbo_MenuChg_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_MenuChg.SelectionChangeCommitted

        Call LS_ChgMenuID()

        GF_Msg("", "表示するメニューを変更しました", MsgBoxStyle.OkOnly)

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告切替コンボ 選択状態変化時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub cbo_AdvChg_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_AdvChg.SelectionChangeCommitted

        'If Not GF_BeginTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        If Not LF_UpdTPM040_2() Then
            GoTo SYSTEM_ERROR
        End If

        'If Not GF_CommitTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        GF_Msg("", "表示するお知らせを変更しました", MsgBoxStyle.OkOnly)

        Exit Sub

SYSTEM_ERROR:
        'Call GF_RollbackTrans()
        Call GS_ErrorTerm("cbo_MenuChg_SelectionChangeCommitted")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：システム管理マスタ 更新処理（１） - メニュー切替処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM040_1() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM040_1 = False

        '------------------------------
        ' システム管理マスタ 更新
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM040"
        strSQL = strSQL & "   SET DEFMENUID = '" & Trim$(GF_CboGetCode(cbo_MenuChg, cbo_MenuChg.SelectedIndex)) & "',"
        strSQL = strSQL & "       UPDID     = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD    = '" & Now & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM040_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：システム管理マスタ 更新処理（２） - 広告切替処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM040_2() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM040_2 = False

        '------------------------------
        ' システム管理マスタ更新
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM040"
        strSQL = strSQL & "   SET DEFADVID = '" & Trim$(GF_CboGetCode(cbo_AdvChg, cbo_AdvChg.SelectedIndex)) & "',"
        strSQL = strSQL & "       UPDID    = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD   = '" & Now & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM040_2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：注文データ消去処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_TableInit() As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strSQL2 As String
        ' --- (2018.12.20) 特急レーン連携 --------------
        'Dim strTbl(12) As String
        Dim strTbl(18) As String
        ' --- (2018.12.20) 特急レーン連携 --------------
        Dim lngCnt As Long

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_TableInit = "削除前エラー"
        
        ' 2014-10-07 ハンディ機能追加に伴いテーブル追加 TPD013, TPD600
        strTbl(0) = "TPD010"
        strTbl(1) = "TPD011"
        strTbl(2) = "TPD012"
        strTbl(3) = "TPD013"
        strTbl(4) = "TPD200"
        strTbl(5) = "TPD210"
        strTbl(6) = "TPD220"
        strTbl(7) = "TPD230"
        strTbl(8) = "TPD240"
        strTbl(9) = "TPD250"
        strTbl(10) = "TPD500"
        strTbl(11) = "TPD600"
        strTbl(12) = "TPD052"
        ' --- (2018.12.20) 特急レーン連携 --------------
        strTbl(13) = "TPD400"
        strTbl(14) = "TPD410"
        ' --- (2018.12.20) 特急レーン連携 --------------
        ' --- (2019.05.23) お通し端末入店情報管理 --------------
        strTbl(15) = "TPD014"
        ' --- (2019.05.23) お通し端末入店情報管理 --------------
        ' 2019-11-06 --------------
        strTbl(16) = "TPD400"
        strTbl(17) = "TPD410"
        strTbl(18) = "TPD730" ' 
        ' -------------------------


        '------------------------------
        ' テーブルクリア処理
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        For lngCnt = 0 To UBound(strTbl)
            If Len(Trim$(strTbl(lngCnt))) <> 0 Then
                ' 2014-10-07 ハンディ機能追加に伴い修正 TPD012 は以前と別物
                'If GF_GetAppInfo2("CNWH_RFIDWRITE") = "0" And lngCnt = 2 Then
                ' タグ書込み機能無＆データ消去テーブルが"TPD012"の場合
                'Else
                ' 上記以外の場合
                strSQL = ""
                ' 2019-11-06 ----------------------------------------------------------------------------
                If strTbl(lngCnt) = "TPD730" Then
                    strSQL = strSQL & "IF OBJECT_ID(N'" & strTbl(lngCnt) & "', N'U') IS NOT NULL TRUNCATE TABLE " & strTbl(lngCnt)
                Else
                    strSQL = strSQL & "TRUNCATE TABLE " & strTbl(lngCnt)
                End If
                ' ---------------------------------------------------------------------------------------
                LF_TableInit = strSQL
                If Not GF_UpdData(strSQL) Then
                    Call GF_RollbackTrans()
                    Exit Function
                End If

                'End If

            End If
        Next

        ' 2014-10-07 ハンディメモ画像削除
        For Each memoImgFile As String In System.IO.Directory.GetFiles("C:\inetpub\wwwroot\CNWI001\memo")
            System.IO.File.Delete(memoImgFile)
        Next

        If GF_GetAppInfo("NOTIFICATION_FLG") = "0" Then

            strSQL = ""
            strSQL = strSQL & "TRUNCATE TABLE SYS_TP.T_KITCHEN_TRANS_R"
            LF_TableInit = strSQL
            If Not GF_UpdData(strSQL) Then
                Call GF_RollbackTrans()
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "TRUNCATE TABLE SYS_TP.T_KITCHEN_TRANS"
            LF_TableInit = strSQL
            If Not GF_UpdData(strSQL) Then
                Call GF_RollbackTrans()
                Exit Function
            End If

        End If

        '整理番号不具合対応  2013.11.06
        If GF_GetAppInfo3("CNWH002_1") = "1" Then          'テイクアウト機能使用する場合
            strSQL2 = ""
            strSQL2 = strSQL2 & "UPDATE TPD050 SET D1 = '0'"
            strSQL2 = strSQL2 & " WHERE  TERMKIND = 'TCB'"
            LF_TableInit = strSQL2
            If Not GF_UpdData(strSQL2) Then
                Call GF_RollbackTrans()
                Exit Function
            End If

        Else
            '未使用時、何もしない
        End If

        ' 混雑登録　座席管理マスタの初期化 2014.2.24
        strSQL2 = ""
        strSQL2 = strSQL2 & "UPDATE TPD051 SET D1 = '0',"
        strSQL2 = strSQL2 & "                  D2 = '0',"
        strSQL2 = strSQL2 & "                  D3 = '0',"
        strSQL2 = strSQL2 & "                  D4 = '0',"
        strSQL2 = strSQL2 & "                  D5 = '0',"
        strSQL2 = strSQL2 & "                  D6 = '0',"
        strSQL2 = strSQL2 & "                  D7 = '0',"
        strSQL2 = strSQL2 & "                  D8 = '0',"
        strSQL2 = strSQL2 & "                  D9 = '0',"
        strSQL2 = strSQL2 & "                  D10 = '0',"
        strSQL2 = strSQL2 & "                  D11 = '0',"
        strSQL2 = strSQL2 & "                  D12 = '0',"
        strSQL2 = strSQL2 & "                  D13 = '0',"
        strSQL2 = strSQL2 & "                  D14 = '0',"
        strSQL2 = strSQL2 & "                  D15 = '0',"
        strSQL2 = strSQL2 & "                  D16 = '0',"
        strSQL2 = strSQL2 & "                  D17 = '0',"
        strSQL2 = strSQL2 & "                  D18 = '0',"
        strSQL2 = strSQL2 & "                  D19 = '0',"
        strSQL2 = strSQL2 & "                  D20 = '0',"
        strSQL2 = strSQL2 & "                  D21 = '0',"
        strSQL2 = strSQL2 & "                  D22 = '0',"
        strSQL2 = strSQL2 & "                  D23 = '0',"
        strSQL2 = strSQL2 & "                  D24 = '0',"
        strSQL2 = strSQL2 & "                  D25 = '0',"
        strSQL2 = strSQL2 & "                  D26 = '0',"
        strSQL2 = strSQL2 & "                  D27 = '0',"
        strSQL2 = strSQL2 & "                  D28 = '0',"
        strSQL2 = strSQL2 & "                  D29 = '0',"
        strSQL2 = strSQL2 & "                  D30 = '0'"
        strSQL2 = strSQL2 & " WHERE TERMKIND IN ('TC0', 'TCA', 'TCB')"

        If Not GF_UpdData(strSQL2) Then
            LF_TableInit = strSQL2
            Call GF_RollbackTrans()
            Exit Function
        End If

        If Not GF_CommitTrans() Then
            LF_TableInit = "コミット失敗"
            Call GF_RollbackTrans()
            Exit Function
        End If

        '------------------------------
        ' 端末状態フラグを全て空席状態にする
        '------------------------------

        Call UpdateOrderStatus()

        '------------------------------
        ' ゲーム機能判定処理
        '------------------------------
        If Trim$(GF_GetAppInfo2("CNWH_GAMEFLG")) = GC_FALSE Then
            '------------------------------
            ' ゲーム関連テーブルの更新
            '------------------------------
            Call UpdateGameTable()
        End If

        '------------------------------
        ' 食べ飲み放題 TPD050初期化
        '------------------------------
        If Trim$(GF_GetAppInfo("PRICE_TYPE")) = GC_FALSE Then
            '------------------------------
            ' ゲーム関連テーブルの更新
            '------------------------------
            Call UpdateGameTable()
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_TableInit = ""

    End Function


    ' --------------------------------------------------------------------------------
    ' 　機　　能：営業開始ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Start.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strStnLink As String
        Dim strSonetLink As String
        Dim strTagRWLink As String
        Dim strSysType As String
        Dim strGameLink As String
        Dim strTicketLink As String
        Dim strStnLink_B As String   'BIXOLON
        Dim strSmaregiLink As String
        ' --- (2018.12.20) 特急レーン連携 --------------
        Dim strLaneLink As String
        ' --- (2018.12.20) 特急レーン連携 --------------
        Dim tableInitError As String
        Dim strFlgTecDataImportPath As String

        strStnLink = Nothing
        strSonetLink = Nothing
        strTagRWLink = Nothing
        strGameLink = Nothing
        strTicketLink = Nothing
        strStnLink_B = Nothing
        strSmaregiLink = Nothing
        ' --- (2018.12.20) 特急レーン連携 --------------
        strLaneLink = Nothing
        ' --- (2018.12.20) 特急レーン連携 --------------

        If GF_Msg("", "営業を開始します。" & vbCrLf & "よろしいですか？", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            strSysType = GF_GetAppInfo("SYS_TYPE")

            If Trim$(strSysType) = "2" Or Trim$(strSysType) = "3" Then
                strStnLink = GF_GetAppInfo("STNLINK")
                If Len(Trim$(strStnLink)) = 0 Then
                    Call GF_Msg("", "ステーション連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    If System.IO.File.Exists(Trim$(strStnLink)) = False Then
                        Call GF_Msg("", "ステーション連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If

                If Trim$(GF_GetAppInfo("TEC_USE_FLG")) = "0" Then
                    strStnLink_B = GF_GetAppInfo("EKCPLINK")
                    If Len(Trim$(strStnLink_B)) = 0 Then
                        Call GF_Msg("", "プリンタ連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        If System.IO.File.Exists(Trim$(strStnLink_B)) = False Then
                            Call GF_Msg("", "プリンタ連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                    End If
                Else
                    If Trim$(GF_GetAppInfo("TAKEOUTPRINT_USE_FLG")) = "0" Then
                        strStnLink_B = GF_GetAppInfo("EKCPLINK")
                        If Len(Trim$(strStnLink_B)) = 0 Then
                            Call GF_Msg("", "プリンタ連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                            Exit Sub
                        Else
                            If System.IO.File.Exists(Trim$(strStnLink_B)) = False Then
                                Call GF_Msg("", "プリンタ連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                                Exit Sub
                            End If
                        End If
                    End If
                End If


            ElseIf Trim$(strSysType) = "1" Then
                strStnLink_B = GF_GetAppInfo("EKCPLINK")
                If Len(Trim$(strStnLink_B)) = 0 Then
                    Call GF_Msg("", "プリンタ連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    If System.IO.File.Exists(Trim$(strStnLink_B)) = False Then
                        Call GF_Msg("", "プリンタ連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If

                If Trim$(GF_GetAppInfo("SMAREGI_FLG")) = "1" Then
                    'スマレジ連携ありの場合
                    strSmaregiLink = Trim$(GF_GetAppInfo("SMAREGI_LINK"))
                    If Len(strSmaregiLink) = 0 Then
                        Call GF_Msg("", "スマレジ連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        If System.IO.File.Exists(strSmaregiLink) = False Then
                            Call GF_Msg("", "スマレジ連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                    End If
                End If
            End If

            If Trim$(GF_GetAppInfo("H_USE")) = "1" Then
                strSonetLink = GF_GetAppInfo("H_PATH")
                If System.IO.File.Exists(Trim$(strSonetLink)) = False Then
                    Call GF_Msg("", "表示機連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If

            ' タグ書込み連携プログラム起動確認
            If Trim$(GF_GetAppInfo2("CNWH_RFIDWRITE")) = "1" Then
                strTagRWLink = Trim$(GF_GetAppInfo("TAGLINK"))
                If Len(strTagRWLink) = 0 Then
                    Call GF_Msg("", "タグ書込み連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    If System.IO.File.Exists(strTagRWLink) = False Then
                        Call GF_Msg("", "タグ書込み連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            End If

            'ゲーム機能連携プログラム起動確認
            If Trim$(GF_GetAppInfo2("CNWH_GAMEFLG")) = "1" And Trim$(GF_GetAppInfo2("CNWH_GAMEOUTPUT")) = "0" Then
                strGameLink = GF_GetAppInfo("GAMELINK")
                If Len(Trim$(strGameLink)) = 0 Then
                    Call GF_Msg("", "ゲーム機能連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    If System.IO.File.Exists(Trim$(strGameLink)) = False Then
                        Call GF_Msg("", "ゲーム機能連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            End If

            '発券機連携プログラム起動確認
            If Trim$(GF_GetAppInfo2("HAKKEN_USE")) = "1" Then
                strTicketLink = GF_GetAppInfo("HAKKENLINK")
                If Len(Trim$(strTicketLink)) = 0 Then
                    Call GF_Msg("", "発券機連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    If System.IO.File.Exists(Trim$(strTicketLink)) = False Then
                        Call GF_Msg("", "発券機連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            End If

            ' --- (2018.12.20) 北日本カコー特急レーン連携 --------------
            '北日本カコー特急レーン連携プログラム起動確認
            If GF_GetAppInfo("LANE_FLG") = "2" Then
                strLaneLink = GF_GetAppInfo("LANE_PATH")
                If System.IO.File.Exists(Trim$(strLaneLink)) = False Then
                    Call GF_Msg("", "特急レーン連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
            ' --- (2018.12.20) 北日本カコー特急レーン連携 --------------

            ' --- (2019.02.05) ループシステム搬送レーン連携 --------------
            'ループシステム搬送レーン連携プログラム起動確認
            If GF_GetAppInfo("LANE_FLG") = "3" Then
                strLaneLink = GF_GetAppInfo("LANE_PATH")
                If System.IO.File.Exists(Trim$(strLaneLink)) = False Then
                    Call GF_Msg("", "搬送レーン連携プログラムを検出することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
            ' --- (2019.02.05) ループシステム搬送レーン連携 --------------

            '------------------------------
            ' テーブルの初期化処理を行う
            '------------------------------
            If GF_GetAppInfo("DellTableMSG") = 1 Then
                If GF_Msg("", "注文データを消去しますか？", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    If Not LF_TableInit() Then
                        GoTo SYSTEM_ERROR
                    End If
                End If
            Else
                'If Not LF_TableInit() Then
                tableInitError = LF_TableInit()
                If tableInitError <> "" Then
                    Call GF_Msg("", "データ初期化に失敗しました" & Environment.NewLine & tableInitError, MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    GoTo SYSTEM_ERROR
                End If
            End If
            '------------------------------
            ' 2015.9.29 OA) TECデータ取込 フラグファイル削除
            '------------------------------
            If (GF_GetAppInfo("SYS_TYPE") = 2 And GF_GetAppInfo("OES_TOOL_VER") = 0 And GF_GetAppInfo("OES_TOOL_VER_CNL1501") = 0) Then
                Try
                    strFlgTecDataImportPath = GF_GetAppInfo("AP_PATH") & "\" & "flg_tec_data_import"
                    If System.IO.File.Exists(strFlgTecDataImportPath) Then
                        System.IO.File.Delete(strFlgTecDataImportPath)
                        DirectCast(MdiParent, CNL2010).btn_menu11.Font = New Font("ＭＳ ゴシック", 10)
                        DirectCast(MdiParent, CNL2010).btn_menu11.Text = "各種設定" & vbCrLf & "※TECデータ取込未実施"
                    End If
                Catch
                    GF_Msg("", "TECデータ取込フラグファイルの削除に失敗しました", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                End Try
            End If

            ' --- (2018.12.20) 特急レーン連携 --------------
            'Call LS_ChgLine(strStnLink, strSonetLink, strTagRWLink, strGameLink, strTicketLink, strStnLink_B, strSmaregiLink)
            Call LS_ChgLine(strStnLink, strSonetLink, strTagRWLink, strGameLink, strTicketLink, strStnLink_B, strSmaregiLink, strLaneLink)
            ' --- (2018.12.20) 特急レーン連携 --------------
            Call LS_SetStatus()
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Start_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：業務ステータス切替処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_ChgLine(Optional ByVal pStnLink As String = "", Optional ByVal pSonetLink As String = "", Optional ByVal pTagRWLink As String = "", Optional ByVal pGameLink As String = "", Optional ByVal pTicketLink As String = "", Optional ByVal pStnLink_B As String = "", Optional ByVal pSmaregiLink As String = "", Optional ByVal pLaneLink As String = "")

        '------------------------------
        ' システム管理マスタ更新
        '------------------------------
        'If Not GF_BeginTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        If Not LF_UpdTPM040_3() Then
            GoTo SYSTEM_ERROR
        End If

        DirectCast(MdiParent, CNL2010).btn_menu01.BackColor = Color.LightSkyBlue
        DirectCast(MdiParent, CNL2010).btn_menu10.BackColor = Color.Violet

        'If Not GF_CommitTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        '------------------------------
        ' Shell実行
        '------------------------------
        If Len(Trim$(pSonetLink)) <> 0 Then
            Shell(Trim$(pSonetLink), AppWinStyle.Hide)
        End If

        If Len(Trim$(pStnLink)) <> 0 Then
            Shell(Trim$(pStnLink), AppWinStyle.Hide)
        End If

        If Len(Trim$(pTagRWLink)) <> 0 Then
            Shell(Trim$(pTagRWLink), AppWinStyle.Hide)
        End If

        If Len(Trim$(pGameLink)) <> 0 Then
            Shell(Trim$(pGameLink), AppWinStyle.Hide)
        End If

        If Len(Trim$(pTicketLink)) <> 0 Then
            Shell(Trim$(pTicketLink), AppWinStyle.Hide)
        End If

        If Len(Trim$(pStnLink_B)) <> 0 Then
            Shell(Trim$(pStnLink_B), AppWinStyle.Hide)
        End If

        If Len(Trim$(pSmaregiLink)) <> 0 Then
            Shell(Trim$(pSmaregiLink), AppWinStyle.Hide)
        End If

        If Len(Trim$(pLaneLink)) <> 0 Then
            Shell(Trim$(pLaneLink), AppWinStyle.Hide)
        End If

        '------------------------------
        ' ボタン使用可否設定
        '------------------------------
        btn_Start.Enabled = False

        Exit Sub

SYSTEM_ERROR:
        'Call GF_RollbackTrans()
        Call GS_ErrorTerm("LS_ChgLine")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：システム管理マスタ 更新処理（３） - 業務ステータス切替処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM040_3() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM040_3 = False

        '------------------------------
        ' システム管理マスタ更新
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM040"
        strSQL = strSQL & "   SET CLMODE = '" & GC_TRUE & "',"
        strSQL = strSQL & "       UPDID  = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD = '" & Now & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM040_3 = True

    End Function

    Private Sub CNL2020_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        '------------------------------
        ' 端末機稼動確認スレッド終了
        '------------------------------
        G_Thread.Abort()

    End Sub

    Private Sub LS_ChgMenuID()

        'If Not GF_BeginTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        If Not LF_UpdTPM040_1() Then
            GoTo SYSTEM_ERROR
        End If

        'If Not GF_CommitTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        Exit Sub

SYSTEM_ERROR:
        'Call GF_RollbackTrans()
        Call GS_ErrorTerm("LS_ChgMenuID")
    End Sub

    '2016.09.27 クレスコ北陸 神林　

    ' --------------------------------------------------------------------------------
    '  機能概要：座席番号管理マスタの全ての端末状態フラグをお通し待ち受け(空席)の状態にする。
    '  引    数：
    '  戻 り 値：
    ' --------------------------------------------------------------------------------

    'Private Sub UpdateOrderStatus()

    '------------------------------
    ' 内部変数定義
    '------------------------------
    'Dim strSQL As String
    'Dim strSysType As String

    'strSysType = GF_GetAppInfo("SYS_TYPE")

    '' 精算連動ありの場合のみ、OrderStatus = 2。それ以外は1。
    'If Trim$(strSysType) = "2" Then
    '' ------------------------------
    '' 端末フラグを更新する
    '' ------------------------------
    '    strSQL = "UPDATE TPM050 SET ORDERSTATUS='2', "
    'ElseIf GF_GetAppInfo("TPG_FLG") = "1" Then
    '    strSQL = "UPDATE TPM050 SET ORDERSTATUS='2', "
    'Else
    '    strSQL = "UPDATE TPM050 SET ORDERSTATUS='1', "
    'End If

    'strSQL = strSQL & "    SPMENU     = '000',"
    'strSQL = strSQL & "    SPMENU2    = '000',"
    'strSQL = strSQL & "    HISTORYFLG = '0'"

    'If GF_GetAppInfo("NO_REGTYPE") <> "00" Then
    '    strSQL = strSQL & " WHERE TERMKIND <> '" & GF_GetAppInfo("NO_REGTYPE") & "'"
    'End If

    'If Not GF_UpdCmtData(strSQL) Then
    '    Exit Sub
    'End If

    ' --------------------------------------------------------------------------------
    '  機能概要：座席番号管理マスタの全ての端末状態フラグをお通し待ち受け(空席)または使用中の状態にする。
    '  引    数：
    '  戻 り 値：
    ' --------------------------------------------------------------------------------
    Private Sub UpdateOrderStatus()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strSysType As String
        Dim strSobaFlg As String

        strSobaFlg = GF_GetAppInfo3("SOBA_FLG")

        strSysType = GF_GetAppInfo("SYS_TYPE")

        ' 精算連動ありまたはお通しパネルありの場合、OrderStatus = 2。それ以外は1。
        If Trim$(strSysType) = "2" Or GF_GetAppInfo("TPG_FLG") = "1" Then

            strSQL = "UPDATE TPM050 SET ORDERSTATUS='2', "

            '蕎麦屋専用フラグが有効の場合、OrderStatus= 1。
            If strSobaFlg = "1" Then
                strSQL = "UPDATE TPM050 SET ORDERSTATUS='1', "
                '全ての端末のお通しコード発行
                For SEATID As Integer = 1 To 97
                    LF_SetSQLTPD010(SEATID)
                Next
                For SEATID As Integer = 98 To 99
                    LF_SetSQLTPD010(SEATID)
                Next
            End If
        Else
            strSQL = "UPDATE TPM050 SET ORDERSTATUS='1', "
        End If

        strSQL = strSQL & "    SPMENU     = '000',"
        strSQL = strSQL & "    SPMENU2    = '000',"
        strSQL = strSQL & "    HISTORYFLG = '0'"

        If GF_GetAppInfo("NO_REGTYPE") <> "00" Then
            'strSQL = strSQL & " WHERE TERMKIND <> '" & GF_GetAppInfo("NO_REGTYPE") & "'"
            strSQL = strSQL & " WHERE TERMKIND NOT IN ('" & GF_GetAppInfo("NO_REGTYPE") & "', 'TCQ', 'TCV')"
        Else
            strSQL = strSQL & " WHERE TERMKIND NOT IN ('TCQ', 'TCV')"
        End If

        If Not GF_UpdCmtData(strSQL) Then
            Exit Sub
        End If

        '2016.09.27 クレスコ北陸 神林

        '------------------------------
        ' 配席機能使用中であれば配席管理マスタ初期化する
        '------------------------------
        If GF_GetAppInfo("SEAT_DISTRIBUTION") = "0" Then
            Call UpdateTPM051()
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：FScompass接続スレッド定義
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SqlConnection()

        Dim da As New DataAccess

        Try
            '-----------------------------
            'FScompas初期接続
            '-----------------------------
            ' データベース接続開始処理
            da.CleateSqlConnection(Trim$(GF_GetAppInfo("OES_CONNECT_STR")))
        Catch
            GF_Msg("", "POSデータ(FUMENU)の接続に失敗しました。" & vbCrLf & "設定を見直してください。", MsgBoxStyle.OkOnly)
            Exit Sub
        Finally
            ' データベース切断処理
            da.CloseConnection()
        End Try

        Exit Sub

    End Sub

    Private Sub btn_UpdFUMENU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_UpdFUMENU.Click

        CNL2010.Enabled = False
        Me.Enabled = False

        '' ＳＴＮデータ出力処理
        If Trim$(GF_GetAppInfo("SYS_TYPE")) = "2" Or Trim$(GF_GetAppInfo("SYS_TYPE")) = "3" Then

            ' FScompassの場合
            '--- MC_FSCP更新
            If GF_PutFSCPData_DB() = False Then
                GF_Msg("", "POSデータ(FSCP)の更新に失敗しました。" & vbCrLf & "設定を見直してください。", MsgBoxStyle.OkOnly)
                CNL2010.Enabled = True
                Me.Enabled = True
                Exit Sub
            End If

            '--- MC_FUMENU更新
            If GF_PutFUMENUData_DB() = False Then
                GF_Msg("", "POSデータ(FUMENU)の更新に失敗しました。" & vbCrLf & "設定を見直してください。", MsgBoxStyle.OkOnly)
                CNL2010.Enabled = True
                Me.Enabled = True
                Exit Sub
            End If
        End If
        'End If
        GF_Msg("", "POSデータ更新が完了しました")

        CNL2010.Enabled = True
        Me.Enabled = True

    End Sub

    ' --------------------------------------------------------------------------------
    '  機能概要：TPD510のTruncateおよびTPD020のカラム：D1～D10を初期化する。
    '  引    数：
    '  戻 り 値：
    ' --------------------------------------------------------------------------------
    Private Sub UpdateGameTable()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' TPD510 Truncate処理
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "TRUNCATE TABLE TPD510"

        If Not GF_UpdCmtData(strSQL) Then
            Call GF_RollbackTrans()
            Exit Sub
        End If

        '------------------------------
        ' TPD050 カラム：D1～D10の初期化処理
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPD050"
        strSQL = strSQL & "   SET D1  = '0',"
        strSQL = strSQL & "       D2  = '0',"
        strSQL = strSQL & "       D3  = '0',"
        strSQL = strSQL & "       D4  = '0',"
        strSQL = strSQL & "       D5  = '0',"
        strSQL = strSQL & "       D6  = '0',"
        strSQL = strSQL & "       D7  = '0',"
        strSQL = strSQL & "       D8  = '0',"
        strSQL = strSQL & "       D9  = '0',"
        strSQL = strSQL & "       D10 = '0'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Sub
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    '  機能概要：配席管理マスタの配席端末の仮想端末識別IDを初期化する
    '  引    数：
    '  戻 り 値：
    ' --------------------------------------------------------------------------------
    Private Sub UpdateTPM051()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM051"
        strSQL = strSQL & "   SET VIRTUALTERMID = ' ',"
        strSQL = strSQL & "       UPDID         = 'CNL2020',"
        strSQL = strSQL & "       UPDYMD        = '" & Now & "'"
        '固定席で開局と座席設定同時に行う場合、固定席の仮想端末識別IDはクリアしない
        If GF_GetAppInfo2("FIXED_SEAT_OPENFLG") = "0" Then
            strSQL = strSQL & " WHERE SEATFLG       = 'D'"
        End If

        If Not GF_UpdCmtData(strSQL) Then
            Exit Sub
        End If
    End Sub
    '2016.09.28 クレスコ北陸 神林
    ' --------------------------------------------------------------------------------
    '  機能概要：全ての席のTPD090のGOODSCDをお通しコード(9902)で登録する。
    '  引    数：SEATID
    '  戻 り 値：
    ' --------------------------------------------------------------------------------

    Private Sub LF_SetSQLTPD010(ByVal SEATID As String)

        Dim strSQL As String
        Dim datNow As Date
        Dim OrderNo As Long
        Dim TERMID As String

        datNow = Now
        OrderNo = LF_GetOrderNo(SEATID)
        TERMID = LF_GetTermID(SEATID)
        If Not (TERMID = "") Then

            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPD010 VALUES("
            strSQL = strSQL & "'" & RSet(SEATID, 5) & "', "                                 '座席番号
            strSQL = strSQL & OrderNo & ", "                                                'オーダー連番
            strSQL = strSQL & "'" & TERMID & "', "                                          '端末識別ID
            strSQL = strSQL & "9902, "                                                      '商品ID
            strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                          '商品選択日時
            strSQL = strSQL & "0, "                                                         '注文受付日時
            strSQL = strSQL & "0, "                                                         'ステーション配信日時
            strSQL = strSQL & "0, "                                                         '数量
            strSQL = strSQL & "'00', "                                                      '指示ステータス位置１
            strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ１
            strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ１
            strSQL = strSQL & "0, "                                                         'SCP数量１
            strSQL = strSQL & "'00', "                                                      '指示ステータス位置２
            strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ２
            strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ２
            strSQL = strSQL & "0, "                                                         'SCP数量２
            strSQL = strSQL & "'00', "                                                      '指示ステータス位置３
            strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ３
            strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ３
            strSQL = strSQL & "0, "                                                         'SCP数量３
            strSQL = strSQL & "'00', "                                                      '指示ステータス位置４
            strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ４
            strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ４
            strSQL = strSQL & "0, "                                                         'SCP数量４
            strSQL = strSQL & "'0', "                                                       'オーダー種別
            strSQL = strSQL & "'0', "                                                       '商品分類
            strSQL = strSQL & "'00', "                                                      '注文フラグ
            strSQL = strSQL & "'000.000.000.000', "                                         '厨房端末識別ID
            strSQL = strSQL & "0, "                                                         'お通し人数
            strSQL = strSQL & "'CNWG001', "                                                 '更新者
            strSQL = strSQL & "GETDATE())"                                                  '更新日

            If Not GF_UpdCmtData(strSQL) Then
                Exit Sub
            End If
        End If

    End Sub

    '2016.09.28 クレスコ北陸 神林
    ' --------------------------------------------------------------------------------
    '  機能概要：オーダー連番を取得する。
    '  引    数：SEATID
    '  戻 り 値：OrderNo
    ' --------------------------------------------------------------------------------

    Private Function LF_GetOrderNo(ByVal strSEATID As String) As Long
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetOrderNo = 0

        strSQL = ""
        strSQL = strSQL & "SELECT ORDERNO"
        strSQL = strSQL & "  FROM TPD010"
        strSQL = strSQL & " WHERE SEATID ='" & RSet(strSEATID, 5) & "'"
        strSQL = strSQL & " ORDER BY SELECTTIME DESC"

        If Not GF_GetData(strSQL, objData) Then
            'Response.Redirect("./TP2990.html?CNWT040(LF_GetOrderNo_1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, objRow) Then
            'Response.Redirect("./TP2990.html?CNWT040(LF_GetOrderNo_3)")
            Exit Function
        End If

        LF_GetOrderNo = CLng(objRow("ORDERNO")) + 1
    End Function
    '2016.09.28 クレスコ北陸 神林
    ' --------------------------------------------------------------------------------
    '  機能概要：TermIDを取得する。
    '  引    数：SEATID
    '  戻 り 値：TermID
    ' --------------------------------------------------------------------------------

    Private Function LF_GetTermID(ByVal SEATID As String) As String
        Dim strSQL As String        '' SQL実行文字列
        Dim objDataSet As DataSet   '' DataSetオブジェクト
        Dim objDataRow As DataRow = Nothing   '' DataRowオブジェクト

        LF_GetTermID = ""

        strSQL = ""
        strSQL = strSQL & "SELECT TERMID"
        strSQL = strSQL & " FROM TPM050"
        strSQL = strSQL & " WHERE SEATID = '" & RSet(SEATID, 5) & "'"
        strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCA'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCB') "
        strSQL = strSQL & " ORDER BY TERMID"

        objDataSet = New DataSet()

        If Not GF_GetData(strSQL, objDataSet) Then
            'Response.Redirect("./TP2990.html?CNWT040(LF_GetTermID-1)")
            Exit Function
        End If

        If objDataSet.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not GF_GetRows(objDataSet, 0, objDataRow) Then
            'Response.Redirect("./TP2990.html?CNWT040(LF_GetTermID-2)")
            Exit Function
        End If

        LF_GetTermID = Trim$(objDataRow("TERMID"))
    End Function
    '2016.09.28 クレスコ北陸 神林

    ''' <summary>
    ''' スマレジ - メニューマスタ更新
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_SMAREGI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SMAREGI.Click

        CNL2010.Enabled = False
        Me.Enabled = False

        _スマレジ連携履歴更新情報 = Nothing         '初期化
        _スマレジ連携履歴更新情報.Initialize()

        '--------------------------------------
        '  スマレジ取引情報を読込
        '--------------------------------------
        Dim smaregiStatusValue As String = ""
        Dim smaregiProductText As String = ""
        Dim smaregiProduct As Json.transactionGetDataMain_Product = Nothing

        Call UpdSmaregiProductData(smaregiProductText, smaregiProduct)

        '成功判定
        If _スマレジ連携履歴更新情報.HTTPステータス <> HTTP_OK Then
            GF_Msg("", "【スマレジ】POSデータの更新に失敗しました" & vbCrLf & "【エラー情報】" & vbCrLf & "　エラーコード ： " & _スマレジ連携履歴更新情報.取込エラーコード & vbCrLf & "　エラー内容 ： " & _スマレジ連携履歴更新情報.取込エラー内容 & vbCrLf & "　エラー詳細 ： " & _スマレジ連携履歴更新情報.取込エラー詳細, MsgBoxStyle.OkOnly)
            CNL2010.Enabled = True
            Me.Enabled = True
        Else
            GF_Msg("", "【スマレジ】POSデータ更新完了" & vbCrLf & "【更新件数 ： " & _スマレジ連携履歴更新情報.取込正常件数 & "件】", MsgBoxStyle.OkOnly)
            CNL2010.Enabled = True
            Me.Enabled = True
        End If

    End Sub

    ''' <summary>
    ''' スマレジ商品情報を更新する（商品(Product)、商品価格（ProductPrice））
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdSmaregiProductData(ByRef smaregiPriceText As String, ByRef smaregiPrice As Json.transactionGetDataMain_Product)

        Dim smaregiRef As Json.SmaregiRefParamsJson = Nothing
        Dim smaregiRefRows As Json.SmaregiRefParamsJsonRows = Nothing
        Dim smaregiRefRowsPrice As Json.SmaregiRefParamsJsonRowsPrice = Nothing
        Dim jq As New System.ServiceModel.Dispatcher.JsonQueryStringConverter
        Dim lngLoopCnt As Long = 0        ' --- (2022.11.02) スマレジ商品マスタ登録件数上限撤廃改修

        '■ヘッダー取得
        Dim getHeader As String = ""
        Dim statusValueHeader As String = ""

        'パラメータ設定
        smaregiRef = New Json.SmaregiRefParamsJson
        smaregiRefRows = New Json.SmaregiRefParamsJsonRows
        smaregiRefRowsPrice = New Json.SmaregiRefParamsJsonRowsPrice

        ' --- (2022.11.02) スマレジ商品マスタ登録件数上限撤廃改修 --------------
        'マスタ登録件数を500で割った値（切り上げ）ぶんループする
        lngLoopCnt = Math.Ceiling(LF_GetTPM010CNT() / 500)

        For i As Integer = 0 To lngLoopCnt - 1
            '商品テーブル
            With smaregiRefRows

                'テーブル名称
                .table_name = "Product"

            End With

            '商品価格テーブル
            With smaregiRefRowsPrice

                'テーブル名称
                .table_name = "ProductPrice"

            End With

            '全体
            With smaregiRef

                '処理区分
                Dim proc_info_proc_division As New Json.proc_info_proc_division
                proc_info_proc_division.proc_division = "U"
                .proc_info.Add(proc_info_proc_division)

            End With

            getHeader = UpdSmaregiInfo(smaregiRef, smaregiRefRows, smaregiRefRowsPrice, statusValueHeader, i)

            '成功判定
            If statusValueHeader <> HTTP_OK Then
                _スマレジ連携履歴更新情報.HTTPステータス = statusValueHeader
                Exit Sub
            End If

            '返却用データに設定(文字列・JSON分解値)
            getHeader = getHeader.Replace("""result"":", """result"":[")
            getHeader = getHeader.Replace("}}", "}]}")
            smaregiPriceText = getHeader
            smaregiPrice = DirectCast(jq.ConvertStringToValue(getHeader, _
                                                              GetType(Json.transactionGetDataMain_Product)),  _
                                                              Json.transactionGetDataMain_Product)

            _スマレジ連携履歴更新情報.取込正常件数 += CLng(smaregiPrice.result(0).Product)
        Next

        'If LF_GetTPM010CNT() > 500 Then
        '    '商品テーブル
        '    With smaregiRefRows

        '        'テーブル名称
        '        .table_name = "Product"

        '    End With

        '    '商品価格テーブル
        '    With smaregiRefRowsPrice

        '        'テーブル名称
        '        .table_name = "ProductPrice"

        '    End With

        '    '全体
        '    With smaregiRef

        '        '処理区分
        '        Dim proc_info_proc_division As New Json.proc_info_proc_division
        '        proc_info_proc_division.proc_division = "U"
        '        .proc_info.Add(proc_info_proc_division)

        '    End With

        '    getHeader = UpdSmaregiInfo(smaregiRef, smaregiRefRows, smaregiRefRowsPrice, statusValueHeader, 1)

        '    '成功判定
        '    If statusValueHeader <> HTTP_OK Then
        '        _スマレジ連携履歴更新情報.HTTPステータス = statusValueHeader
        '        Exit Sub
        '    End If

        '    '返却用データに設定(文字列・JSON分解値)
        '    getHeader = getHeader.Replace("""result"":", """result"":[")
        '    getHeader = getHeader.Replace("}}", "}]}")
        '    smaregiPriceText = getHeader
        '    smaregiPrice = DirectCast(jq.ConvertStringToValue(getHeader, _
        '                                                      GetType(Json.transactionGetDataMain_Product)),  _
        '                                                      Json.transactionGetDataMain_Product)

        '    _スマレジ連携履歴更新情報.取込正常件数 += CLng(smaregiPrice.result(0).Product)
        'End If
        ' --- (2022.11.02) スマレジ商品マスタ登録件数上限撤廃改修 --------------

        '正常に設定
        _スマレジ連携履歴更新情報.HTTPステータス = HTTP_OK

    End Sub

    ''' <summary>
    ''' スマレジの更新結果情報を取得し、文字列の状態で返却する
    ''' </summary>
    ''' <param name="smaregiRef"></param>
    ''' <param name="smaregiRefRows"></param>
    ''' <param name="smaregiRefRowsPrice"></param>
    ''' <param name="statusValue"></param>
    ''' <param name="cnt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function UpdSmaregiInfo(ByVal smaregiRef As Json.SmaregiRefParamsJson, ByVal smaregiRefRows As Json.SmaregiRefParamsJsonRows, _
                                    ByVal smaregiRefRowsPrice As Json.SmaregiRefParamsJsonRowsPrice, ByRef statusValue As String, Optional ByVal cnt As Integer = 0) As String

        Dim result As String = ""
        Dim dtsData As New DataSet()
        Dim dtsRow As DataRow = Nothing
        Dim startCnt As Long = 0
        Dim RowsStr As String = ""
        Dim RowsStrPrice As String = ""
        Dim param As String = ""
        Dim paramPrice As String = ""
        Dim dataParam As String = ""
        Dim dataParamPrice As String = ""
        Dim endCnt As Long = 0
        Dim storeId As String = ""
        Dim OpenItem() As String
        Dim OpenItemFrom As String
        Dim OpenItemTo As String
        Dim SalesTax As String
        Dim ReducedTaxRate As String
        Dim compareCnt As Long = 0        ' --- (2022.11.02) スマレジ商品マスタ登録件数上限撤廃改修

        Try
            storeId = Trim$(GF_GetAppInfo("SMAREGI_STOREID"))

            'オープン単価商品コード取得
            OpenItem = Trim$(GF_GetAppInfo("OPENITEM")).Split("/")
            OpenItemFrom = OpenItem(0)
            OpenItemTo = OpenItem(1)

            '税区分取得
            SalesTax = Trim$(GF_GetAppInfo("SALES_TAX_SWITCHING"))

            '軽減税率適用区分
            ReducedTaxRate = Trim$(GF_GetAppInfo("TEC_REDUCED_TAX_RATE"))

            'パラメータをJSON形式に変換
            Dim jq As New System.ServiceModel.Dispatcher.JsonQueryStringConverter

            If LF_GetTPM010(dtsData) Then

                '------------------------------
                '商品データ部(行)
                '------------------------------
                '商品ID
                Dim rows_productId As New Json.rows_productId
                '部門ID
                Dim rows_categoryId As New Json.rows_categoryId
                '商品コード
                Dim rows_productCode As New Json.rows_productCode
                '商品名
                Dim rows_productName As New Json.rows_productName
                '税区分
                Dim rows_taxDivision As New Json.rows_taxDivision
                '商品価格区分
                Dim rows_productPriceDivision As New Json.rows_productPriceDivision
                '商品単価
                Dim rows_price As New Json.rows_price
                '部門の税設定使用有無
                Dim rows_useCategoryReduceTax As New Json.rows_useCategoryReduceTax
                '軽減税率ID
                Dim rows_reduceTaxId As New Json.rows_reduceTaxId

                '------------------------------
                '商品価格データ部(行)
                '------------------------------
                '商品ID
                Dim rowsPrice_productId As New Json.rowsPrice_productId
                '店舗ID
                Dim rowsPrice_storeId As New Json.rowsPrice_storeId
                '価格区分
                Dim rowsPrice_priceDivision As New Json.rowsPrice_priceDivision
                '適用開始日
                Dim rowsPrice_startDate As New Json.rowsPrice_startDate
                '商品単価
                Dim rowsPrice_price As New Json.rowsPrice_price

                ' --- (2022.11.02) スマレジ商品マスタ登録件数上限撤廃改修 --------------
                startCnt = 500 * cnt
                compareCnt = 500 + (500 * cnt)

                If dtsData.Tables("com").Rows.Count > compareCnt Then
                    endCnt = compareCnt
                Else
                    endCnt = dtsData.Tables("com").Rows.Count
                End If

                'If cnt = 0 Then
                '    If dtsData.Tables("com").Rows.Count > 500 Then
                '        endCnt = 500
                '    Else
                '        endCnt = dtsData.Tables("com").Rows.Count
                '    End If
                'Else
                '    startCnt = 500
                '    If dtsData.Tables("com").Rows.Count > 1000 Then
                '        endCnt = 1000
                '    Else
                '        endCnt = dtsData.Tables("com").Rows.Count
                '    End If
                'End If
                ' --- (2022.11.02) スマレジ商品マスタ登録件数上限撤廃改修 --------------

                While startCnt < endCnt

                    If Not GF_GetRows(dtsData, startCnt, dtsRow) Then
                        'GoTo SYSTEM_ERROR
                    End If

                    'Rowsをクリア
                    smaregiRefRows.rows.Clear()
                    smaregiRefRowsPrice.rows.Clear()

                    With smaregiRefRows

                        'データ部(行 - 商品ID)
                        rows_productId.productId = Trim$(CLng(dtsRow("GOODSCD")))
                        .rows.Add(rows_productId)

                        'データ部(行 - 部門ID)
                        rows_categoryId.categoryId = Trim$(dtsRow("BUMONCD"))
                        .rows.Add(rows_categoryId)

                        'データ部(行 - 商品コード)
                        rows_productCode.productCode = Trim$(dtsRow("GOODSCD"))
                        .rows.Add(rows_productCode)

                        'データ部(行 - 商品名)
                        rows_productName.productName = Trim$(dtsRow("GOODSNMJ")) & Trim$(dtsRow("GOODSNMJ2"))
                        .rows.Add(rows_productName)

                        'データ部(行 - 税区分)
                        If SalesTax = "0" Then
                            '内税
                            rows_taxDivision.taxDivision = "0"
                        ElseIf SalesTax = "1" Then
                            '内税
                            rows_taxDivision.taxDivision = "1"
                        Else
                            Throw New Exception()
                        End If
                        .rows.Add(rows_taxDivision)

                        'データ部(行 - 商品価格区分)
                        If Trim$(dtsRow("GOODSCD")) >= OpenItemFrom And Trim$(dtsRow("GOODSCD")) <= OpenItemTo Then
                            rows_productPriceDivision.productPriceDivision = "2"
                        Else
                            rows_productPriceDivision.productPriceDivision = "1"
                        End If
                        .rows.Add(rows_productPriceDivision)

                        'データ部(行 - 商品単価)
                        If SalesTax = "1" Then
                            rows_price.price = Trim$(dtsRow("PRICE"))
                        ElseIf Trim$(dtsRow("TAXTYPE")) = "1" And ReducedTaxRate = "1" Then
                            rows_price.price = Trim$(dtsRow("PRICE_RED"))
                        Else
                            rows_price.price = Trim$(dtsRow("TAXPRICE"))
                        End If
                        .rows.Add(rows_price)

                        'データ部(行 - 部門の税設定使用有無)
                        rows_useCategoryReduceTax.useCategoryReduceTax = "0"
                        .rows.Add(rows_useCategoryReduceTax)

                        'データ部(行 - 軽減税率ID)
                        If ReducedTaxRate = "1" Then
                            If Trim$(dtsRow("TAXTYPE")) = "0" Then
                                rows_reduceTaxId.reduceTaxId = ""
                            ElseIf Trim$(dtsRow("TAXTYPE")) = "1" Then
                                rows_reduceTaxId.reduceTaxId = "10000001"
                            Else
                                rows_reduceTaxId.reduceTaxId = ""
                            End If
                        ElseIf ReducedTaxRate = "0" Then
                            rows_reduceTaxId.reduceTaxId = ""
                        Else
                            Throw New Exception()
                        End If
                        .rows.Add(rows_reduceTaxId)

                    End With

                    'Rowsを一度切り離して、文字列化する
                    For i As Integer = 0 To smaregiRefRows.rows.Count - 1
                        If i > 0 Then
                            RowsStr &= ","
                        End If

                        '型ごとの分岐
                        If TypeOf smaregiRefRows.rows(i) Is Json.rows_productId Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_productId))

                        ElseIf TypeOf smaregiRefRows.rows(i) Is Json.rows_categoryId Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_categoryId))

                        ElseIf TypeOf smaregiRefRows.rows(i) Is Json.rows_productCode Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_productCode))

                        ElseIf TypeOf smaregiRefRows.rows(i) Is Json.rows_taxDivision Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_taxDivision))

                        ElseIf TypeOf smaregiRefRows.rows(i) Is Json.rows_productName Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_productName))

                        ElseIf TypeOf smaregiRefRows.rows(i) Is Json.rows_price Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_price))

                        ElseIf TypeOf smaregiRefRows.rows(i) Is Json.rows_productPriceDivision Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_productPriceDivision))

                        ElseIf TypeOf smaregiRefRows.rows(i) Is Json.rows_useCategoryReduceTax Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_useCategoryReduceTax))

                        ElseIf TypeOf smaregiRefRows.rows(i) Is Json.rows_reduceTaxId Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_reduceTaxId))
                        End If
                    Next

                    '特定文字を取り除く
                    RowsStr = RowsStr.Replace("{", "")
                    RowsStr = RowsStr.Replace("}", "")

                    RowsStr = "{" & RowsStr & "}"

                    If dataParam.Length <> 0 Then
                        RowsStr = "," & RowsStr
                    End If

                    dataParam &= RowsStr
                    RowsStr = Nothing

                    With smaregiRefRowsPrice

                        'データ部(行 - 商品ID)
                        rowsPrice_productId.price_productId = Trim$(CLng(dtsRow("GOODSCD")))
                        .rows.Add(rowsPrice_productId)

                        'データ部(行 - 店舗ID)
                        rowsPrice_storeId.Price_storeId = storeId
                        .rows.Add(rowsPrice_storeId)

                        'データ部(行 - 価格区分)
                        rowsPrice_priceDivision.Price_priceDivision = "1"
                        .rows.Add(rowsPrice_priceDivision)

                        'データ部(行 - 運用開始日)
                        rowsPrice_startDate.Price_startDate = Now.ToString("yyyy-MM-dd")
                        .rows.Add(rowsPrice_startDate)

                        'データ部(行 - 商品単価)
                        If SalesTax = "1" Then
                            rowsPrice_price.Price_price = Trim$(dtsRow("PRICE"))
                        ElseIf Trim$(dtsRow("TAXTYPE")) = "1" And ReducedTaxRate = "1" Then
                            rowsPrice_price.Price_price = Trim$(dtsRow("PRICE_RED"))
                        Else
                            rowsPrice_price.Price_price = Trim$(dtsRow("TAXPRICE"))
                        End If
                        .rows.Add(rowsPrice_price)

                    End With

                    'Rowsをクリア
                    smaregiRefRows.rows.Clear()

                    'Rowsを一度切り離して、文字列化する
                    For i As Integer = 0 To smaregiRefRowsPrice.rows.Count - 1
                        If i > 0 Then
                            RowsStrPrice &= ","
                        End If

                        '型ごとの分岐
                        If TypeOf smaregiRefRowsPrice.rows(i) Is Json.rowsPrice_productId Then
                            RowsStrPrice &= jq.ConvertValueToString(smaregiRefRowsPrice.rows(i), GetType(Json.rowsPrice_productId))

                        ElseIf TypeOf smaregiRefRowsPrice.rows(i) Is Json.rowsPrice_storeId Then
                            RowsStrPrice &= jq.ConvertValueToString(smaregiRefRowsPrice.rows(i), GetType(Json.rowsPrice_storeId))

                        ElseIf TypeOf smaregiRefRowsPrice.rows(i) Is Json.rowsPrice_priceDivision Then
                            RowsStrPrice &= jq.ConvertValueToString(smaregiRefRowsPrice.rows(i), GetType(Json.rowsPrice_priceDivision))

                        ElseIf TypeOf smaregiRefRowsPrice.rows(i) Is Json.rowsPrice_startDate Then
                            RowsStrPrice &= jq.ConvertValueToString(smaregiRefRowsPrice.rows(i), GetType(Json.rowsPrice_startDate))

                        ElseIf TypeOf smaregiRefRowsPrice.rows(i) Is Json.rowsPrice_price Then
                            RowsStrPrice &= jq.ConvertValueToString(smaregiRefRowsPrice.rows(i), GetType(Json.rowsPrice_price))
                        End If
                    Next

                    '特定文字を取り除く
                    RowsStrPrice = RowsStrPrice.Replace("{", "")
                    RowsStrPrice = RowsStrPrice.Replace("}", "")

                    RowsStrPrice = "{" & RowsStrPrice & "}"

                    If dataParamPrice.Length <> 0 Then
                        RowsStrPrice = "," & RowsStrPrice
                    End If

                    dataParamPrice &= RowsStrPrice
                    RowsStrPrice = Nothing

                    'Rowsをクリア
                    smaregiRefRowsPrice.rows.Clear()

                    startCnt = startCnt + 1
                End While

                '文字列変換して、Rowsを設定し直す
                param = jq.ConvertValueToString(smaregiRefRows, GetType(Json.SmaregiRefParamsJsonRows))
                param = param.Replace("""rows"":[]", """rows"":[" & dataParam & "]")

                paramPrice = jq.ConvertValueToString(smaregiRefRowsPrice, GetType(Json.SmaregiRefParamsJsonRowsPrice))
                paramPrice = paramPrice.Replace("""rows"":[]", """rows"":[" & dataParamPrice & "]")

            End If

            'proc_infoを一度切り離して、文字列化する
            Dim ProcInfoStr As String = ""
            For i As Integer = 0 To smaregiRef.proc_info.Count - 1
                If i > 0 Then
                    ProcInfoStr &= ","
                End If

                '型ごとの分岐
                If TypeOf smaregiRef.proc_info(i) Is Json.proc_info_proc_division Then
                    ProcInfoStr &= jq.ConvertValueToString(smaregiRef.proc_info(i), GetType(Json.proc_info_proc_division))
                End If
            Next

            'proc_infoをクリア
            smaregiRef.proc_info.Clear()
            'dataをクリア
            smaregiRef.data.Clear()

            '文字列変換して、dataを設定し直す
            Dim param2 As String = jq.ConvertValueToString(smaregiRef, GetType(Json.SmaregiRefParamsJson))
            param2 = param2.Replace("""data"":[]", """data"":[" & param + "," + paramPrice & "]")
            param2 = param2.Replace("""proc_info"":[]", """proc_info"":" & ProcInfoStr)

            '------------------------------
            ' リクエスト設定
            '------------------------------
            Dim url As String = Trim$(GF_GetAppInfo("SMAREGI_URL"))
            Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(url)

            With request
                ' リクエストヘッダ設定
                With .Headers
                    .Add("X_contract_id", Trim$(GF_GetAppInfo("SMAREGI_CONTRACT")))
                    .Add("X_access_token", Trim$(GF_GetAppInfo("SMAREGI_TOKEN")))
                End With
                .Method = "POST"
                .ContentType = "application/x-www-form-urlencoded;charset=UTF-8"
            End With

            Dim post As String = String.Empty
            post &= "proc_name=product_upd&params=" & param2

            Dim post_byte As Byte() = System.Text.Encoding.UTF8.GetBytes(post)
            Dim reqStream As System.IO.Stream = request.GetRequestStream
            With reqStream
                .Write(post_byte, 0, post_byte.Length)
                .Close()
            End With

            'レスポンスの処理
            Dim response As System.Net.WebResponse = Nothing
            response = request.GetResponse

            Dim httpResponse As System.Net.HttpWebResponse = CType(response, System.Net.HttpWebResponse)
            statusValue = httpResponse.StatusCode & " " & httpResponse.StatusDescription

            Dim repStream As System.IO.Stream = response.GetResponseStream
            Dim sr As New System.IO.StreamReader(repStream)

            '取得した情報を格納
            Dim json As String = String.Empty
            While sr.Peek >= 0

                json &= sr.ReadLine

            End While

            result = json

        Catch ex As System.Net.WebException
            'HTTPプロトコルエラーかどうか調べる
            If ex.Status = System.Net.WebExceptionStatus.ProtocolError Then
                'HttpWebResponseを取得
                Dim errres As System.Net.HttpWebResponse = _
                    CType(ex.Response, System.Net.HttpWebResponse)
                statusValue = errres.StatusCode & " " & errres.StatusDescription

                'エラー詳細を取得する
                Dim repStream As System.IO.Stream = errres.GetResponseStream
                Dim sr As New System.IO.StreamReader(repStream)
                Dim json As String = String.Empty
                While sr.Peek >= 0
                    json &= sr.ReadLine
                End While

                Try
                    Dim jq As New System.ServiceModel.Dispatcher.JsonQueryStringConverter
                    If json <> "" Then
                        Dim errInfo As Json.errorInfo _
                                    = DirectCast(jq.ConvertStringToValue(json, _
                                      GetType(Json.errorInfo)),  _
                                      Json.errorInfo)

                        _スマレジ連携履歴更新情報.取込エラーコード = errInfo.error_code
                        _スマレジ連携履歴更新情報.取込エラー内容 = errInfo.errorM
                        _スマレジ連携履歴更新情報.取込エラー詳細 = errInfo.error_description
                    End If

                Catch ex2 As Exception
                    'json変換失敗した場合、スマレジからのステータスは取得できなかった、として、接続エラーとする
                    statusValue = HTTP_想定外エラー
                End Try

            Else
                statusValue = HTTP_想定外エラー
            End If
            'Me.Close()

        Catch ex As Exception

            'GoTo SYSTEM_ERROR

            Trace.Write(ex.Message)

            statusValue = HTTP_想定外エラー
            'Me.Close()

        End Try

        Return result

        'SYSTEM_ERROR:
        '        Call GS_ErrorTerm("UpdSmaregiInfo")
    End Function

    ''' <summary>
    ''' 商品マスタ一覧を取得する
    ''' </summary>
    ''' <param name="pDataSet"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_GetTPM010(ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM010 = False

        '------------------------------
        ' 商品マスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        strSQL = strSQL & "       TPM010.BUMONCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        strSQL = strSQL & "       TPM010.PRICE,"
        strSQL = strSQL & "       TPM600.TAXTYPE,"
        strSQL = strSQL & "       TPM600.PRICE_RED,"
        strSQL = strSQL & "       TPM260.TAXPRICE"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & "       LEFT JOIN TPM600 ON TPM010.GOODSCD = TPM600.GOODSCD"
        strSQL = strSQL & "       LEFT JOIN TPM260 ON TPM010.GOODSCD = TPM260.GOODSCD"
        strSQL = strSQL & " WHERE CONVERT(decimal,TPM010.GOODSCD) < 9000"
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM010 = True

    End Function

    ''' <summary>
    ''' 商品マスタ一覧の件数を取得する
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_GetTPM010CNT() As Long

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM010CNT = False

        '------------------------------
        ' 商品マスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        strSQL = strSQL & "       TPM010.BUMONCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        strSQL = strSQL & "       ISNULL(TPM320.TAXKIND, '0') AS TAXKIND,"
        strSQL = strSQL & "       TPM010.PRICE"
        strSQL = strSQL & "  FROM TPM010 LEFT JOIN TPM320 ON TPM010.GOODSCD = TPM320.GOODSCD"
        strSQL = strSQL & " WHERE CONVERT(decimal,TPM010.GOODSCD) < 9000"
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        If dtsData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPM010CNT = dtsData.Tables("com").Rows.Count

    End Function

    Private Sub btn_btn_OutputGoodsData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OutputGoodsData.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()
        Dim csvPath As String = GF_GetAppInfo("TERAOKA_CSVPATH") & "\" & Now.ToString("yyyyMMddHHmmss") & ".csv"
        Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")

        Try
            '------------------------------
            ' 出力内容取得
            '------------------------------
            strSQL = ""
            strSQL = strSQL & "SELECT TPM010.GOODSCD AS GOODSCD"
            strSQL = strSQL & "       , TPM010.GOODSNMJ AS GOODSNMJ"
            strSQL = strSQL & "       , TPM010.PRICE AS PRICE"
            strSQL = strSQL & "       , '1' AS SUBCATEGORY"
            strSQL = strSQL & "       , '0' AS STOPFLAG"
            strSQL = strSQL & "       , '9' AS TAXCODE"
            strSQL = strSQL & "       , '0' AS TAKEOUTFLG"
            strSQL = strSQL & "  FROM TPM010 "
            strSQL = strSQL & " WHERE CONVERT(INT,TPM010.GOODSCD) < 9000"
            strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

            If Not GF_GetData(strSQL, dtsData) Then
                Exit Sub
            End If

            If dtsData.Tables("com").Rows.Count = 0 Then
                MsgBox("出力対象の商品が存在しません")
                Exit Sub
            End If

            '書き込むファイルを開く
            Dim sr As New System.IO.StreamWriter(csvPath, False, enc)

            Dim colCount As Integer = dtsData.Tables("com").Columns.Count
            Dim lastColIndex As Integer = colCount - 1
            Dim i As Integer
            Dim row As DataRow

            For Each row In dtsData.Tables("com").Rows
                For i = 0 To colCount - 1
                    'フィールドの取得
                    Dim field As String = row(i).ToString()
                    '"で囲む
                    field = field.Replace("""", """""")
                    'フィールドを書き込む
                    sr.Write(field)
                    'カンマを書き込む
                    If lastColIndex > i Then
                        sr.Write(","c)
                    End If
                Next
                '改行する
                sr.Write(vbCrLf)
            Next

            '閉じる
            sr.Close()

            MsgBox("CSVファイルを出力しました。" & vbCrLf & csvPath)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    ' --- (2022.09.01) Kiosk自動精算機連携 --------------
    Private Sub btn_KioskGoodsData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_KioskGoodsData.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()
        Dim csvPath As String = GF_GetAppInfo2("KIOSK_CSV_PATH")
        Dim enc As System.Text.Encoding = System.Text.Encoding.UTF8

        Try
            '------------------------------
            ' 出力内容取得
            '------------------------------
            strSQL = ""
            strSQL = strSQL & "SELECT LTRIM(RTRIM(TPM010.GOODSCD)) AS GOODSCD"
            strSQL = strSQL & "     , LTRIM(RTRIM(TPM010.GOODSNMJ)) AS GOODSNMJ"
            strSQL = strSQL & "     , LTRIM(RTRIM(TPM260.TAXPRICE)) AS PRICE"
            strSQL = strSQL & "  FROM TPM010 "
            strSQL = strSQL & "     , TPM260 "
            strSQL = strSQL & " WHERE TPM010.GOODSCD = TPM260.GOODSCD"
            strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

            If Not GF_GetData(strSQL, dtsData) Then
                Exit Sub
            End If

            If dtsData.Tables("com").Rows.Count = 0 Then
                MsgBox("出力対象の商品が存在しません")
                Exit Sub
            End If

            '書き込むファイルを開く
            Dim sr As New System.IO.StreamWriter(csvPath, False, enc)

            Dim colCount As Integer = dtsData.Tables("com").Columns.Count
            Dim lastColIndex As Integer = colCount - 1
            Dim i As Integer
            Dim row As DataRow

            For Each row In dtsData.Tables("com").Rows
                For i = 0 To colCount - 1
                    'フィールドの取得
                    Dim field As String = row(i).ToString()
                    'フィールドを書き込む
                    sr.Write(field)
                    'カンマを書き込む
                    If lastColIndex > i Then
                        sr.Write(","c)
                    End If
                Next
                '改行する
                sr.Write(vbCr)
            Next

            '閉じる
            sr.Close()

            MsgBox("Kiosk自動精算機 - CSVファイルを出力しました。" & vbCrLf & csvPath)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    ' --- (2022.09.01) Kiosk自動精算機連携 --------------
End Class
