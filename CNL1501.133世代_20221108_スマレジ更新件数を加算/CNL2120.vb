' --------------------------------------------------------------------------------
' 　機　　能：CrossNavi - 閉店処理画面
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2011.11.07 ソラン北陸 新規作成
' --------------------------------------------------------------------------------
Public Class CNL2120
    Inherits System.Windows.Forms.Form

    '----(2013.10.22)新規作成----------------------
    ' ---------------------------------------------
    ' モジュール内ユーザ定義型定義
    ' ---------------------------------------------
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
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents mnu_End As System.Windows.Forms.MenuItem
    Friend WithEvents btn_End As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CNL2120))
        Me.stb_Msg = New System.Windows.Forms.StatusBar
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.mnu_End = New System.Windows.Forms.MenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.btn_End = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.mnu_End})
        Me.MenuItem1.Text = "閉店処理"
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
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btn_End)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(262, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(262, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Label1"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(204, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(794, 1)
        Me.Label11.TabIndex = 148
        '
        'btn_End
        '
        Me.btn_End.BackColor = System.Drawing.SystemColors.Control
        Me.btn_End.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_End.Location = New System.Drawing.Point(219, 10)
        Me.btn_End.Name = "btn_End"
        Me.btn_End.Size = New System.Drawing.Size(180, 50)
        Me.btn_End.TabIndex = 11
        Me.btn_End.Text = "営業終了"
        Me.btn_End.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        '
        'CNL2120
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(9, 19)
        Me.ClientSize = New System.Drawing.Size(1016, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stb_Msg)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL2120"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Private Sub CNL2120_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''------------------------------
        '' 内部変数定義
        ''------------------------------
        'Dim objForm As New CNL1810()

        Try
            '------------------------------
            ' フォーム名称設定
            '------------------------------
            Me.Text = " 閉店処理 "

            '---------------------------------
            '閉じるボタン非表示化
            '---------------------------------
            Me.ControlBox = False

            ''------------------------------
            '' 起動ステータス表示
            ''------------------------------
            'objForm.Show()
            'objForm.lbl_Msg.Text = "起動処理中です。しばらくお待ちください..."
            'objForm.TopMost = True
            'System.Windows.Forms.Application.DoEvents()

            '------------------------------
            ' 初期化処理
            '------------------------------
            Call GS_StatusSetup(stb_Msg)

            '------------------------------
            ' 管理マスタより現況設定
            '------------------------------
            Call LS_SetStatus()

            ''------------------------------
            '' 起動ステータスクローズ
            ''------------------------------
            'objForm.Close()

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL2120_Load")
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
        If Trim$(objRows("CLMODE")) = GC_TRUE Then
            '------------------------------
            ' ボタン使用可否設定
            '------------------------------
            btn_End.Enabled = True

            '---------------------------------
            '開店表示変更
            '---------------------------------
            btn_End.Text = "営業終了"

            Me.Label1.Text = "現在、営業中です。"
            Me.Label2.Text = "営業を終了する場合は、上記の[営業終了]ボタンを押してください。"
        Else
            '------------------------------
            ' ボタン使用可否設定
            '------------------------------
            btn_End.Enabled = False

            '---------------------------------
            '閉店表示変更
            '---------------------------------
            btn_End.Text = "準備中"

            Me.Label1.Text = "現在、準備中です。"
            Me.Label2.Text = "営業を開始する場合は、[開店処理]の[営業開始]ボタンを押してください。"
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
        strSQL = strSQL & "SELECT DEFMENUID,"
        strSQL = strSQL & "       DEFADVID,"
        strSQL = strSQL & "       CLMODE"
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
    ' 　機　　能：営業終了ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_End_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_End.Click

        If GF_Msg("", "営業を終了します。" & vbCrLf & "よろしいですか？", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            ' ---- アンケート集計およびデータ削除 -------------
            Call out_Enq()
            ' -------------------------------------------------
            '-----売上データ自動出力（2013.10.22）新規作成-----
            If GF_GetAppInfo("AUTO_PRICE_OUTPUT") = 0 Then
                Call LS_Auto_sales()
            End If
            '--------------------------------------------------

            Call LS_ChgLine()
            Call LS_SetStatus()
            If GF_GetAppInfo("DELIVARY_FLG") = "1" Or GF_GetAppInfo("DELIVARY_FLG") = "2" Then
                Call CNL2130.LS_SalesUpdate()
            End If
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：アンケート集計およびデータ削除
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2019.04.08
    ' --------------------------------------------------------------------------------
    Private Sub out_Enq()
        Dim phpCmd As String = "C:\php\php.exe"
        Dim fileDir As String = "C:\Apache Software Foundation\Apache2.2\htdocs\api\cross_i_navi\enq"
        Dim phpFile As String = "csv.php"
        Dim driveLetter = fileDir.Substring(0, 2)
        If System.IO.File.Exists(phpCmd) Then
            If System.IO.File.Exists(fileDir & "\" & phpFile) Then

                'Processオブジェクトを作成
                Dim p As New System.Diagnostics.Process()

                'ComSpec(cmd.exe)のパスを取得して、FileNameプロパティに指定
                p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec")
                '出力を読み取れるようにする
                p.StartInfo.UseShellExecute = False
                p.StartInfo.RedirectStandardOutput = True
                p.StartInfo.RedirectStandardInput = False
                'ウィンドウを表示しないようにする
                p.StartInfo.CreateNoWindow = True
                Dim strCommand As String = "/c " & driveLetter & " & CD """ & fileDir & """ & " & phpCmd & " """ & fileDir & "\" & phpFile & """"
                'コマンドラインを指定（"/c"は実行後閉じるために必要）
                p.StartInfo.Arguments = strCommand


                '起動
                p.Start()

                '出力を読み取る
                Dim results As String = p.StandardOutput.ReadToEnd()

                'プロセス終了まで待機する
                'WaitForExitはReadToEndの後である必要がある
                '(親プロセス、子プロセスでブロック防止のため)
                p.WaitForExit()
                p.Close()

                '出力された結果を表示
                'Console.WriteLine(results)
            End If
        End If

    End Sub


    ' --------------------------------------------------------------------------------
    ' 　機　　能：業務ステータス切替処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_ChgLine()

        '------------------------------
        ' システム管理マスタ更新
        '------------------------------
        'If Not GF_BeginTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        If Not LF_UpdTPM040() Then
            GoTo SYSTEM_ERROR
        End If

        DirectCast(MdiParent, CNL2010).btn_menu01.BackColor = Color.Violet
        DirectCast(MdiParent, CNL2010).btn_menu10.BackColor = Color.LightSkyBlue

        'If Not GF_CommitTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        '------------------------------
        ' ボタン使用可否設定
        '------------------------------
        btn_End.Enabled = False

        Exit Sub

SYSTEM_ERROR:
        'Call GF_RollbackTrans()
        Call GS_ErrorTerm("LS_ChgLine")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：システム管理マスタ 更新処理 - 業務ステータス切替処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM040() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM040 = False

        '------------------------------
        ' システム管理マスタ更新
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM040"
        strSQL = strSQL & "   SET CLMODE = '" & GC_FALSE & "',"
        strSQL = strSQL & "       UPDID  = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD = '" & Now & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM040 = True

    End Function

    Private Sub LS_Auto_sales()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim FileName As String = Nothing
        Dim objRows As DataRow = Nothing
        Dim RowsCnt As Integer
        Dim ColmCnt As Integer
        Dim strEncoding As System.Text.Encoding
        Dim strStreamWriter As System.IO.StreamWriter = Nothing


        '------------------------------
        ' 保存フォルダ、ファイル名指定
        '------------------------------
        System.Environment.CurrentDirectory = Trim$(GF_GetAppInfo("SALES_AUTO_PATH"))  'フォルダ名指定
        FileName = "PriceData(" & Format$(Now, "yyyyMMddHHmmss") & ").csv"             'ファイル名指定

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
            strStreamWriter = New System.IO.StreamWriter(FileName, False, strEncoding)

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
        Call GF_Msg("", "売上データを作成しました" & vbCrLf & "[" & FileName & "]", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_OutputCsv_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：帳票データ取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.10.22 新規作成
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
        strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <= '8999'"
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
    ' 　履　　歴：2013.10.22 新規作成
    ' --------------------------------------------------------------------------------
    Public Function LF_PadSpc(ByVal pStr As String, ByVal Length As Long) As String

        LF_PadSpc = Space(Length - Len(Trim$(pStr))) & Trim$(pStr)

    End Function
End Class
