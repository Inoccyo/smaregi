' --------------------------------------------------------------------------------
' 　機　　能：店舗内情報システム - サーバメンテナンス(メニュー更新画面)
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
' --------------------------------------------------------------------------------

Public Class CNL1520
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
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents grd_UnmatchList As System.Windows.Forms.DataGrid
    Friend WithEvents grd_ItemList As System.Windows.Forms.DataGrid
    Friend WithEvents cbo_SelRow As System.Windows.Forms.ComboBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.stb_Msg = New System.Windows.Forms.StatusBar()
        Me.grd_UnmatchList = New System.Windows.Forms.DataGrid()
        Me.grd_ItemList = New System.Windows.Forms.DataGrid()
        Me.cbo_SelRow = New System.Windows.Forms.ComboBox()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.grd_UnmatchList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_ItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 667)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(1018, 24)
        Me.stb_Msg.TabIndex = 242
        Me.stb_Msg.Text = "StatusBar1"
        '
        'grd_UnmatchList
        '
        Me.grd_UnmatchList.CaptionText = "■ データ取り込み結果"
        Me.grd_UnmatchList.DataMember = ""
        Me.grd_UnmatchList.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_UnmatchList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_UnmatchList.Location = New System.Drawing.Point(8, 8)
        Me.grd_UnmatchList.Name = "grd_UnmatchList"
        Me.grd_UnmatchList.Size = New System.Drawing.Size(632, 648)
        Me.grd_UnmatchList.TabIndex = 1
        '
        'grd_ItemList
        '
        Me.grd_ItemList.CaptionText = "■ 前回との差分"
        Me.grd_ItemList.DataMember = ""
        Me.grd_ItemList.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_ItemList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_ItemList.Location = New System.Drawing.Point(648, 8)
        Me.grd_ItemList.Name = "grd_ItemList"
        Me.grd_ItemList.Size = New System.Drawing.Size(360, 648)
        Me.grd_ItemList.TabIndex = 2
        '
        'cbo_SelRow
        '
        Me.cbo_SelRow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_SelRow.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_SelRow.Location = New System.Drawing.Point(440, 8)
        Me.cbo_SelRow.Name = "cbo_SelRow"
        Me.cbo_SelRow.Size = New System.Drawing.Size(200, 23)
        Me.cbo_SelRow.TabIndex = 3
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
        Me.MenuItem2.Text = "編集内容を保存する(&S)"
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
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbo_SelRow, Me.grd_ItemList, Me.grd_UnmatchList})
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 268
        '
        'CNL1520
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1018, 691)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel1, Me.stb_Msg})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL1520"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNL1520"
        CType(Me.grd_UnmatchList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_ItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' --------------------------------------------------------------------------------
    ' モジュール内定数定義
    ' --------------------------------------------------------------------------------
    Private Const LC_NODATA As String = "<< 未登録 >>"
    Private Const LC_SELROW_ALL As String = "ALL"
    Private Const LC_SELROW_DIF As String = "DIF"

    ' --------------------------------------------------------------------------------
    ' モジュール内変数定義
    ' --------------------------------------------------------------------------------
    Private L_objData As DataSet
    Private L_udtGridCol() As typGridColumn
    Private L_blnEditFlg As Boolean

    Private Structure typWidth
        Dim strFrom As String
        Dim strTo As String
    End Structure


    ' --- (2004.02.09) 単価訂正機能追加 ------------------------------------
    Private L_PriceEdit As String
    ' ----------------------------------------------------------------------

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub CNL1520_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            '------------------------------
            ' フォーム名称設定
            '------------------------------
            Me.Text = GF_FormText()

            '------------------------------
            ' 初期化処理
            '------------------------------
            Call GS_StatusSetup(stb_Msg)                                    ' ステータスバー初期化
            grd_UnmatchList.AllowDrop = True
            grd_ItemList.AllowDrop = True

            '------------------------------
            ' 絞込みコンボ設定処理
            '------------------------------
            cbo_SelRow.Items.Clear()
            Call GS_CboItemSet(cbo_SelRow, "全て表示する", LC_SELROW_ALL)
            Call GS_CboItemSet(cbo_SelRow, "差分の商品のみ表示する", LC_SELROW_DIF)
            cbo_SelRow.SelectedIndex = 0


            ' --- (2003.12.04) 取得元ファイル存在確認処理追加 --------------
            Dim strFileNm As String
            strFileNm = GF_GetAppInfo("OES_PATH") & "\" & GF_GetAppInfo("OES_MENUTBL")
            If System.IO.File.Exists(strFileNm) = False Then
                Call GF_Msg("", "メニューファイルが存在しないため、処理を続行できません" & vbCrLf & "[ " & strFileNm & "]", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
                MenuItem2.Enabled = False
                L_blnEditFlg = False
                Exit Sub
            End If

            strFileNm = GF_GetAppInfo("OES_PATH") & "\" & GF_GetAppInfo("OES_SCPTBL")
            If System.IO.File.Exists(strFileNm) = False Then
                Call GF_Msg("", "オプションファイルが存在しないため、処理を続行できません" & vbCrLf & "[ " & strFileNm & "]", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
                MenuItem2.Enabled = False
                L_blnEditFlg = False
                Exit Sub
            End If

            strFileNm = GF_GetAppInfo("OES_PATH") & "\" & GF_GetAppInfo("OES_DPTBL")
            If System.IO.File.Exists(strFileNm) = False Then
                Call GF_Msg("", "部門ファイルが存在しないため、処理を続行できません" & vbCrLf & "[ " & strFileNm & "]", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
                MenuItem2.Enabled = False
                L_blnEditFlg = False
                Exit Sub
            End If
            ' --------------------------------------------------------------


            ' --- (2004.02.09) 単価訂正機能追加 ----------------------------
            L_PriceEdit = GF_GetAppInfo("PRICE_EDIT")                       ' 有効性設定取得
            If Len(Trim$(L_PriceEdit)) = 0 Then
                L_PriceEdit = GC_FALSE
            End If
            ' --------------------------------------------------------------

            '------------------------------
            ' データ不一致検出処理
            '------------------------------
            Call LS_ChkMenuTbl()

            L_blnEditFlg = True

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1520_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューマスタ更新状況確認処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_ChkMenuTbl()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objStatus As New CNL1810()
        Dim blnResult As Boolean

        Try
            '------------------------------
            ' 進捗状況通知フォーム表示
            '------------------------------
            objStatus.Show()
            With objStatus
                .pgs_Status.Minimum = 0
                .TopMost = True
            End With
            System.Windows.Forms.Application.DoEvents()

            Me.Cursor = Cursors.WaitCursor
            Call LS_GridSetup(objStatus)
            Call LS_GridSetup2(objStatus)
            Call LS_ChkFSCP(objStatus, blnResult)
            If blnResult And _
               GF_GetRowCnt(grd_ItemList) = 0 Then
                If GF_Msg("Q10", "", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    Call LS_SaveAllData()
                End If
            End If
            Me.Cursor = Cursors.Default

            objStatus.Close()

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Me.Cursor = Cursors.Default
        Call GS_ErrorTerm("CNL1520_Load")
    End Sub

    Private Sub LS_ChkFSCP(ByVal objStatus As CNL1810, ByRef pResult As Boolean)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim strFileNM As String
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim intFile As Integer
        Dim lngCnt As Long
        Dim bytData() As Byte
        Dim lngCol As Long
        Dim objSjisEnc As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")

        '------------------------------
        ' 初期値設定
        '------------------------------
        pResult = False                                                     ' 初期状態では、過不足無しで設定

        '------------------------------
        ' ＳＣＰマスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM TPM100"
        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' "FSCP"取得
        '------------------------------
        strFileNM = GF_GetAppInfo("OES_PATH") & "\" & _
                    GF_GetAppInfo("OES_SCPTBL")
        objFileInfo = New System.IO.FileInfo(strFileNM)
        If objData.Tables("com").Rows.Count <> (objFileInfo.Length / 53) Then
            pResult = True
            Exit Sub
        End If

        With objStatus
            .lbl_Msg.Text = "コメント・サブ／セットメニューテーブルの確認中です..."
            .pgs_Status.Maximum = objFileInfo.Length / 53
            .pgs_Status.Value = 0
        End With
        objFileInfo = Nothing
        System.Windows.Forms.Application.DoEvents()

        intFile = FreeFile()
        FileOpen(intFile, strFileNM, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
        lngCnt = 0
        While Not EOF(intFile)

            '------------------------------
            ' SCP-No.取得
            '------------------------------
            bytData = LF_GetBData(1, 1, intFile, lngCnt, 53)

            strSQL = ""
            strSQL = strSQL & "SELECT SCPNO,"

            ' --- (2003.12.02) ガイダンス項目取得追加 ----------------------
            strSQL = strSQL & "       GUIDE,"
            ' --------------------------------------------------------------

            strSQL = strSQL & "       GOODSCD1  AS SCPMENU0,"
            strSQL = strSQL & "       GOODSCD2  AS SCPMENU1,"
            strSQL = strSQL & "       GOODSCD3  AS SCPMENU2,"
            strSQL = strSQL & "       GOODSCD4  AS SCPMENU3,"
            strSQL = strSQL & "       GOODSCD5  AS SCPMENU4,"
            strSQL = strSQL & "       GOODSCD6  AS SCPMENU5,"
            strSQL = strSQL & "       GOODSCD7  AS SCPMENU6,"
            strSQL = strSQL & "       GOODSCD8  AS SCPMENU7,"
            strSQL = strSQL & "       GOODSCD9  AS SCPMENU8,"
            strSQL = strSQL & "       GOODSCD10 AS SCPMENU9,"
            strSQL = strSQL & "       GOODSCD11 AS SCPMENU10,"
            strSQL = strSQL & "       GOODSCD12 AS SCPMENU11,"
            strSQL = strSQL & "       GOODSCD13 AS SCPMENU12,"
            strSQL = strSQL & "       GOODSCD14 AS SCPMENU13,"
            strSQL = strSQL & "       GOODSCD15 AS SCPMENU14,"
            strSQL = strSQL & "       GOODSCD16 AS SCPMENU15"
            strSQL = strSQL & "  FROM TPM100"
            strSQL = strSQL & " WHERE SCPNO = '" & Format$(CLng(Convert.ToUInt16(Trim$(Replace(BitConverter.ToString(bytData), "-", "")), 16).ToString), "000") & "'"
            objData = New DataSet()
            If Not GF_GetData(strSQL, objData) Then
                FileClose(intFile)
                GoTo SYSTEM_ERROR
            End If
            If objData.Tables("com").Rows.Count = 0 Then
                pResult = True
                FileClose(intFile)
                Exit Sub
            End If
            If Not GF_GetRows(objData, 0, objRows) Then
                FileClose(intFile)
                GoTo SYSTEM_ERROR
            End If

            ' --- (2003.12.02) ガイダンス文言の差異についてもチェックする --
            ' 存在する場合、ガイダンス文言は一致するか？
            bytData = LF_GetBData(2, 20, intFile, lngCnt, 53)
            If Trim$(objRows("GUIDE")) <> Trim$(objSjisEnc.GetString(bytData)) Then
                pResult = True
                FileClose(intFile)
                Exit Sub
            End If
            ' --------------------------------------------------------------

            ' 存在する場合、メニューコードは全て一致するか？
            For lngCol = 0 To 15
                bytData = LF_GetBData(22 + (lngCol * 2), 2, intFile, lngCnt, 53)
                If Trim$(objRows("SCPMENU" & CStr(lngCol))) <> Trim$(Replace(BitConverter.ToString(bytData), "-", "")) Then
                    pResult = True
                    FileClose(intFile)
                    Exit Sub
                End If
            Next

            lngCnt = lngCnt + 1
            objStatus.pgs_Status.Value = lngCnt
        End While
        FileClose(intFile)

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_ChkFSCP")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：端末機稼動状況確認グリッド 初期セットアップ処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_GridSetup(ByVal pStatus As CNL1810)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objTs As New DataGridTableStyle()                               ' 新しいDataGridTableStyleの作成
        Dim lngCnt As Long
        Dim dtsData As New DataSet()
        Dim objTable As DataTable

        Try
            '------------------------------
            ' テーブルスタイル定義
            '------------------------------
            With objTs
                .MappingName = "UNMATCHLIST"                                      ' マップ名を指定
                .PreferredRowHeight = 20                                        ' 標準行高を指定
            End With

            '------------------------------
            ' 各項目属性定義
            '------------------------------
            Call LF_SetColumns(L_udtGridCol)

            For lngCnt = 0 To UBound(L_udtGridCol)                                ' 各列定義をテーブルスタイルに追加
                Call GS_GridAddColumn(L_udtGridCol(lngCnt), objTs)
            Next
            objTs.AllowSorting = False                                          ' 列見出しクリックによるソートを禁止
            objTs.RowHeadersVisible = False

            With grd_UnmatchList
                .TableStyles.Clear()
                .TableStyles.Add(objTs)                                         ' テーブルスタイルをDataGridに追加
                .ReadOnly = True                                                ' 編集禁止
            End With

            '------------------------------
            ' グリッド生成
            '------------------------------
            L_objData = New DataSet("UnmatchList")
            objTable = New DataTable("UNMATCHLIST")
            For lngCnt = 0 To UBound(L_udtGridCol)
                Call GS_GridAddTable(L_udtGridCol(lngCnt), objTable)
            Next

            '------------------------------
            ' データ値設定
            '------------------------------
            If Not LF_GetFUMENU(objTable, L_udtGridCol, pStatus) Then
                Exit Sub
            End If
            L_objData.Tables.Add(objTable)                                        ' テーブルをDataSetに追加する
            Call LS_ChgDispStyle()                                              ' 全行表示指定で、グリッドにデータ連結する

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GridSetup")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：端末機稼動状況確認グリッド 初期セットアップ処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_GridSetup2(ByVal pStatus As CNL1810)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objTs As New DataGridTableStyle()                               ' 新しいDataGridTableStyleの作成
        Dim udtGridCol() As typGridColumn = Nothing
        Dim lngCnt As Long
        Dim dtsData As New DataSet()
        Dim dtsList As DataSet
        Dim objTable As DataTable

        Try
            '------------------------------
            ' テーブルスタイル定義
            '------------------------------
            With objTs
                .MappingName = "UNMATCHLIST"                                      ' マップ名を指定
                .PreferredRowHeight = 20                                        ' 標準行高を指定
            End With

            '------------------------------
            ' 各項目属性定義
            '------------------------------
            Call LF_SetColumns(udtGridCol, "R")

            For lngCnt = 0 To UBound(udtGridCol)                                ' 各列定義をテーブルスタイルに追加
                Call GS_GridAddColumn(udtGridCol(lngCnt), objTs)
            Next
            objTs.AllowSorting = False                                          ' 列見出しクリックによるソートを禁止
            objTs.RowHeadersVisible = False

            With grd_ItemList
                .TableStyles.Clear()
                .TableStyles.Add(objTs)                                         ' テーブルスタイルをDataGridに追加
                .ReadOnly = True                                                ' 編集禁止
            End With

            '------------------------------
            ' グリッド生成
            '------------------------------
            dtsList = New DataSet("TermList")
            objTable = New DataTable("UNMATCHLIST")
            For lngCnt = 0 To UBound(udtGridCol)
                Call GS_GridAddTable(udtGridCol(lngCnt), objTable)
            Next

            '------------------------------
            ' データ値設定
            '------------------------------
            If Not LF_GetUnmatchList(objTable, udtGridCol, pStatus) Then
                Exit Sub
            End If
            dtsList.Tables.Add(objTable)                                        ' テーブルをDataSetに追加する
            grd_ItemList.SetDataBinding(dtsList, "UNMATCHLIST")                ' DataSetとテーブルをDataGridに接続する
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GridSetup2")
    End Sub

    Private Sub LF_SetColumns(ByRef pGridCols() As typGridColumn, Optional ByVal pLR As String = "L")

        ReDim pGridCols(29)         '--- (2006.05.24) おすすめ、新作フラグ追加
        'ReDim pGridCols(27)

        '------------------------------
        ' 可視項目定義
        '------------------------------
        With pGridCols(0)
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "GOODSCD"
            .strHeadText = "商品番号"
            .blnAllowNull = False
            .lngWidth = 70
            .objAlign = HorizontalAlignment.Center
            .blnReadOnly = True
        End With
        With pGridCols(1)
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "GOODSNM"
            .strHeadText = "商品名"
            .blnAllowNull = False
            .lngWidth = 170
            .objAlign = HorizontalAlignment.Left
        End With
        With pGridCols(2)
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "PRICE"
            .strHeadText = "単価"
            .blnAllowNull = False
            .lngWidth = 70
            .objAlign = HorizontalAlignment.Right
            .blnReadOnly = True
        End With
        With pGridCols(3)
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "JEXPNOTE"
            .strHeadText = "説明文"
            .blnAllowNull = False
            .lngWidth = IIf(pLR = "L", 239, 0)
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With

        '------------------------------
        ' 不可視項目定義
        '------------------------------
        With pGridCols(4)                                                   ' 画像データパス
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "IMAGEDATA"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(5)                                                   ' 単位
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "UNITJ"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(6)                                                   ' コメント１
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_COM1"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(7)                                                   ' コメント２
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_COM2"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(8)                                                   ' コメント３
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_COM3"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(9)                                                   ' コメント４
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_COM4"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(10)                                                  ' サブメニュー１
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_SUB1"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(11)                                                  ' サブメニュー２
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_SUB2"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(12)                                                  ' サブメニュー３
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_SUB3"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(13)                                                  ' サブメニュー４
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_SUB4"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(14)                                                  ' セットメニュー１
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_SET1"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(15)                                                  ' セットメニュー２
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_SET2"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(16)                                                  ' セットメニュー３
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_SET3"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(17)                                                  ' セットメニュー４
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_SET4"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(18)                                                  ' 商品ステータス
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "STATUS"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(19)                                                  ' 商品分類
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "GOODSKIND"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        ' --- (2003.11.28) 部門コード項目を追加 ----------------------------
        With pGridCols(20)                                                  ' 部門コード
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "BUMONCD"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        ' ------------------------------------------------------------------
        ' --- (2003.11.28) ＫＣＰステータス項目を追加 ----------------------
        With pGridCols(21)                                                  ' ＫＣＰステータス
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "KCPSTATUS"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        ' ------------------------------------------------------------------
        ' --- (2003.12.01) 商品名２項目を追加 ------------------------------
        With pGridCols(22)                                                  ' ＫＣＰステータス
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "GOODSNMJ2"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        ' ------------------------------------------------------------------
        ' --- (2003.12.01) 商品名２項目を追加 ------------------------------
        With pGridCols(23)                                                  ' ＫＣＰステータス
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "GOODSNMJ3"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        ' ------------------------------------------------------------------
        ' --- (2004.02.09) タッチパネル商品名２項目を追加 ------------------
        With pGridCols(24)                                                  ' タッチパネル商品名２
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "GOODSNMJ4"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        ' ------------------------------------------------------------------
        With pGridCols(25)                                                  ' 存在有無
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "Exist"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With

        ' --- (2004.10.14) ＨＴＬ用名称項目追加 ----------------------------
        With pGridCols(26)                                                  ' ＨＴＬ用名称１
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "HTLNM1"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(27)                                                  ' ＨＴＬ用名称２
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "HTLNM2"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        ' ------------------------------------------------------------------
        '--- (2006.05.24) おすすめ、新作フラグ追加 -------------------------
        With pGridCols(28)                                                  ' おすすめフラグ
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SPFLG"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(29)                                                  ' 新作フラグ
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "NEWFLG"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        '-------------------------------------------------------------------

    End Sub

    'Private Function LF_GetTPM010(ByVal pData As DataSet, _
    '                              Optional ByVal pGoodsCd As String = "", _
    '                              Optional ByVal pGoodsNM As String = "", _
    '                              Optional ByVal pGoodsNM2 As String = "", _
    '                              Optional ByVal pPrice As String = "", _
    '                              Optional ByVal pSCPStat As String = "") As Boolean
    Private Function LF_GetTPM010(ByVal pData As DataSet, _
                                  Optional ByVal pGoodsCd As String = "", _
                                  Optional ByVal pGoodsNM As String = "", _
                                  Optional ByVal pGoodsNM2 As String = "", _
                                  Optional ByVal pPrice As String = "", _
                                  Optional ByVal pSCPStat As String = "", _
                                  Optional ByVal pBumonCD As String = "") As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM010 = False

        '------------------------------
        ' 商品マスタ取得処理
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM TPM010"
        If Len(Trim$(pGoodsCd)) <> 0 Then
            ' --- (2003.12.02) マッチングキーを、品名のみに変更する --------
            'strSQL = strSQL & " WHERE GOODSCD      = '" & pGoodsCd & "'"
            'strSQL = strSQL & "   AND GOODSNMJ     = '" & pGoodsNM & "'"
            'strSQL = strSQL & "   AND PRICE        = " & pPrice
            'strSQL = strSQL & "   AND SCPNO01 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 1, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO02 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 3, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO03 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 5, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO04 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 7, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO05 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 9, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO06 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 11, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO07 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 13, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO08 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 15, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO09 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 17, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO10 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 19, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO11 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 21, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO12 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 23, 2), 16).ToString), "000") & "'"

            ' --- (2004.02.02) ＰＯＳ商品名に対応 --------------------------
            'strSQL = strSQL & " WHERE GOODSNMJ     = '" & pGoodsNM & "'"
            'strSQL = strSQL & " WHERE GOODSNMJ3    = '" & pGoodsNM & "'"
            strSQL = strSQL & " WHERE GOODSNMJ4    = '" & pGoodsNM & "'"            '2006.06.28 CrossNavi改修
            ' --------------------------------------------------------------

            ' --- (2003.12.17) 同一商品名対応 ------------------------------
            strSQL = strSQL & "   AND BUMONCD      = '" & pBumonCD & "'"
            ' --------------------------------------------------------------

            ' --------------------------------------------------------------
        Else
            strSQL = strSQL & " ORDER BY GOODSCD"
        End If
        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPM010 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：最新メニューテーブル取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetFUMENU(ByRef pTable As DataTable, ByVal pGridCols() As typGridColumn, ByVal pStatus As CNL1810) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strFileNm As String
        Dim intFile As Integer
        Dim lngCnt As Long
        Dim bytData() As Byte
        Dim objSjisEnc As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")
        Dim objData As DataSet
        Dim objRows As DataRow = Nothing
        Dim objWRow As DataRow = Nothing
        Dim strGoodsCD As String
        Dim strGoodsNM As String
        Dim strBumonCD As String
        Dim strPrice As String
        Dim strSCPStat As String
        Dim strFStat As String
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim lngFileRec As Long
        Dim udtSushi As typWidth
        Dim udtEtc As typWidth
        Dim udtSysItem As typWidth
        Dim udtPosItem As typWidth
        Dim strWork() As String
        Dim strBumon As String
        Dim lngBCnt As Long
        Dim blnFound As Boolean
        Dim strWK As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetFUMENU = False

        Try
            '------------------------------
            ' 商品分類判定基準値取得
            '------------------------------
            udtSushi.strFrom = GF_GetAppInfo("GK_SUSHI_F")
            If Len(Trim$(udtSushi.strFrom)) = 0 Or Not IsNumeric(udtSushi.strFrom) Then
                Exit Function
            End If

            udtSushi.strTo = GF_GetAppInfo("GK_SUSHI_T")
            If Len(Trim$(udtSushi.strTo)) = 0 Or Not IsNumeric(udtSushi.strTo) Then
                Exit Function
            End If

            udtEtc.strFrom = GF_GetAppInfo("GK_ETC_F")
            If Len(Trim$(udtEtc.strFrom)) = 0 Or Not IsNumeric(udtEtc.strFrom) Then
                Exit Function
            End If

            udtEtc.strTo = GF_GetAppInfo("GK_ETC_T")
            If Len(Trim$(udtEtc.strTo)) = 0 Or Not IsNumeric(udtEtc.strTo) Then
                Exit Function
            End If

            udtSysItem.strFrom = GF_GetAppInfo("GK_SYSITEM_F")
            If Len(Trim$(udtSysItem.strFrom)) = 0 Or Not IsNumeric(udtSysItem.strFrom) Then
                Exit Function
            End If

            udtSysItem.strTo = GF_GetAppInfo("GK_SYSITEM_T")
            If Len(Trim$(udtSysItem.strTo)) = 0 Or Not IsNumeric(udtSysItem.strTo) Then
                Exit Function
            End If

            udtPosItem.strFrom = GF_GetAppInfo("GK_POSITEM_F")
            If Len(Trim$(udtPosItem.strFrom)) = 0 Or Not IsNumeric(udtPosItem.strFrom) Then
                Exit Function
            End If

            udtPosItem.strTo = GF_GetAppInfo("GK_POSITEM_T")
            If Len(Trim$(udtPosItem.strTo)) = 0 Or Not IsNumeric(udtPosItem.strTo) Then
                Exit Function
            End If

            '------------------------------
            ' メニューテーブルオープン
            '------------------------------
            strFileNm = GF_GetAppInfo("OES_PATH") & "\" & _
                        GF_GetAppInfo("OES_MENUTBL")
            objFileInfo = New System.IO.FileInfo(strFileNm)                 ' ファイル情報取得
            lngFileRec = objFileInfo.Length / 147
            objFileInfo = Nothing
            With pStatus
                .lbl_Msg.Text = "最新のメニューマスタを取得中です..."
                .pgs_Status.Maximum = lngFileRec
                .pgs_Status.Value = 0
            End With
            System.Windows.Forms.Application.DoEvents()

            intFile = FreeFile()
            FileOpen(intFile, strFileNm, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
            lngCnt = 0
            While Not EOF(intFile)
                objRows = pTable.NewRow

                bytData = LF_GetBData(1, 2, intFile, lngCnt, 147)           ' 商品コード取得
                objRows(pGridCols(0).strMapName) = Trim$(Replace(BitConverter.ToString(bytData), "-", ""))
                strGoodsCD = Trim$(Replace(BitConverter.ToString(bytData), "-", ""))

                bytData = LF_GetBData(3, 1, intFile, lngCnt, 147)           ' リンクＤＰコード(部門コード)取得
                objRows(pGridCols(20).strMapName) = Trim$(Replace(BitConverter.ToString(bytData), "-", ""))
                strBumonCD = Trim$(Replace(BitConverter.ToString(bytData), "-", ""))

                bytData = LF_GetBData(37, 20, intFile, lngCnt, 147)         ' 商品名取得
                ' --- (2004.02.27) ２０バイトトリミングを行なう ------------
                'objRows(pGridCols(1).strMapName) = LF_WideCnv(RTrim$(objSjisEnc.GetString(bytData)))
                'strGoodsNM = LF_WideCnv(RTrim$(objSjisEnc.GetString(bytData)))
                objRows(pGridCols(1).strMapName) = GF_MidB(LF_WideCnv(RTrim$(objSjisEnc.GetString(bytData))), 1, 20)
                strGoodsNM = GF_MidB(LF_WideCnv(RTrim$(objSjisEnc.GetString(bytData))), 1, 20)
                ' ----------------------------------------------------------

                ' ---(2003.12.01) 商品名２項目追加 -------------------------
                bytData = LF_GetBData(57, 20, intFile, lngCnt, 147)         ' 商品名２取得
                ' --- (2004.02.27) ２０バイトトリミングを行なう ------------
                'objRows(pGridCols(22).strMapName) = LF_WideCnv(RTrim$(objSjisEnc.GetString(bytData)))
                objRows(pGridCols(22).strMapName) = GF_MidB(LF_WideCnv(RTrim$(objSjisEnc.GetString(bytData))), 1, 20)
                ' ----------------------------------------------------------
                ' ----------------------------------------------------------

                ' --- (2004.10.14) ＨＴＬ用名称追加 ------------------------
                bytData = LF_GetBData(77, 5, intFile, lngCnt, 147)          ' ＨＴＬ名称１取得
                objRows(pGridCols(26).strMapName) = GF_MidB(RTrim$(objSjisEnc.GetString(bytData)), 1, 5)
                bytData = LF_GetBData(82, 5, intFile, lngCnt, 147)          ' ＨＴＬ名称２取得
                objRows(pGridCols(27).strMapName) = GF_MidB(RTrim$(objSjisEnc.GetString(bytData)), 1, 5)
                ' ----------------------------------------------------------

                bytData = LF_GetBData(87, 5, intFile, lngCnt, 147)          ' 単価取得
                objRows(pGridCols(2).strMapName) = Format$(CLng(Trim$(LF_SPKCnv(bytData, 2))), "#,##0")
                strPrice = Trim$(LF_SPKCnv(bytData, 2))

                bytData = LF_GetBData(103, 1, intFile, lngCnt, 147)        ' 機能ステータス２取得
                strFStat = Trim$(LF_BITCnv(bytData))

                ' --- (2003.12.09) 正しく取得できない障害を改修 ------------
                ' --- (2003.11.28) ＫＰステータス取得追加 ------------------
                'bytData = LF_GetBData(105, 4, intFile, lngCnt, 147)       ' ＫＰステータス
                'objRows(pGridCols(21).strMapName) = Trim$(LF_BITCnv(bytData))
                ' ----------------------------------------------------------
                strWK = ""
                bytData = LF_GetBData(105, 1, intFile, lngCnt, 147)
                strWK = strWK & Trim$(LF_BITCnv(bytData))
                bytData = LF_GetBData(106, 1, intFile, lngCnt, 147)
                strWK = strWK & Trim$(LF_BITCnv(bytData))
                bytData = LF_GetBData(107, 1, intFile, lngCnt, 147)
                strWK = strWK & Trim$(LF_BITCnv(bytData))
                bytData = LF_GetBData(108, 1, intFile, lngCnt, 147)
                strWK = strWK & Trim$(LF_BITCnv(bytData))
                objRows(pGridCols(21).strMapName) = strWK
                ' ----------------------------------------------------------

                bytData = LF_GetBData(112, 12, intFile, lngCnt, 147)        ' SCPステータス取得
                strSCPStat = Replace(BitConverter.ToString(bytData), "-", "")

                bytData = LF_GetBData(147, 1, intFile, lngCnt, 147)        ' レコード最終点まで読み進める(Dummy)

                '------------------------------
                ' 完全一致レコード検索
                '------------------------------
                objData = New DataSet()                                     ' 説明文取得

                'If Not LF_GetTPM010(objData, strGoodsCD, strGoodsNM, "", strPrice, strSCPStat) Then
                If Not LF_GetTPM010(objData, strGoodsCD, strGoodsNM, "", strPrice, strSCPStat, strBumonCD) Then
                    Exit Function
                End If
                If objData.Tables("com").Rows.Count <> 0 Then
                    If Not GF_GetRows(objData, 0, objWRow) Then
                        Exit Function
                    End If
                    ' --- (2003.12.02) 改行タグ隠し対策 --------------------
                    'objRows(pGridCols(3).strMapName) = Trim$(objWRow("JEXPNOTEJ"))      ' 説明文
                    objRows(pGridCols(3).strMapName) = Trim$(Replace(Trim$(objWRow("JEXPNOTEJ")), "<BR>", vbCrLf))    ' 説明文
                    ' ------------------------------------------------------
                    objRows(pGridCols(4).strMapName) = Trim$(objWRow("IMAGEDATA"))      ' 画像データ
                    objRows(pGridCols(5).strMapName) = Trim$(objWRow("UNITJ"))          ' 単位
                    ' --- (2004.02.02) タッチパネル商品名引継対応 ----------

                    ' --- (2004.02.27) 左側余白を削除しないようにする ------
                    'objRows(pGridCols(23).strMapName) = Trim$(objWRow("GOODSNMJ"))
                    objRows(pGridCols(23).strMapName) = RTrim$(objWRow("GOODSNMJ"))
                    ' ------------------------------------------------------

                    ' ------------------------------------------------------
                    ' --- (2004.02.09) タッチパネル商品名２引継対応 --------
                    ' --- (2004.02.27) 左側余白を削除しないようにする ------
                    'objRows(pGridCols(24).strMapName) = Trim$(objWRow("GOODSNMJ2"))
                    objRows(pGridCols(24).strMapName) = RTrim$(objWRow("GOODSNMJ2"))
                    ' ------------------------------------------------------
                    ' ------------------------------------------------------

                    ' --- (2004.02.09) 単価訂正機能追加 --------------------
                    If L_PriceEdit = GC_TRUE Then
                        objRows(pGridCols(2).strMapName) = Trim$(objWRow("PRICE"))
                    End If
                    ' ------------------------------------------------------

                    objRows(pGridCols(25).strMapName) = "1"

                    '--- (2006.05.24) おすすめ、新作フラグ追加 -------------
                    objRows(pGridCols(28).strMapName) = Trim$(objWRow("SPFLG"))
                    objRows(pGridCols(29).strMapName) = Trim$(objWRow("NEWFLG"))
                    '-------------------------------------------------------
                Else
                    objRows(pGridCols(3).strMapName) = LC_NODATA            ' 説明文
                    objRows(pGridCols(4).strMapName) = ""                   ' 画像データ
                    objRows(pGridCols(5).strMapName) = ""                   ' 単位
                    ' --- (2004.02.02) タッチパネル商品名引継対応 ----------
                    objRows(pGridCols(23).strMapName) = strGoodsNM
                    ' ------------------------------------------------------
                    ' --- (2004.02.09) タッチパネル商品名２引継対応 --------
                    objRows(pGridCols(24).strMapName) = ""
                    ' ------------------------------------------------------
                    objRows(pGridCols(25).strMapName) = "0"
                    '--- (2006.05.24) おすすめ、新作フラグ追加 -------------
                    objRows(pGridCols(28).strMapName) = "0"
                    objRows(pGridCols(29).strMapName) = "0"
                    '-------------------------------------------------------
                End If
                ' コメント１～４
                objRows(pGridCols(6).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 1, 2), 16).ToString), "000")
                objRows(pGridCols(7).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 3, 2), 16).ToString), "000")
                objRows(pGridCols(8).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 5, 2), 16).ToString), "000")
                objRows(pGridCols(9).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 7, 2), 16).ToString), "000")
                ' サブメニュー１～４
                objRows(pGridCols(10).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 9, 2), 16).ToString), "000")
                objRows(pGridCols(11).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 11, 2), 16).ToString), "000")
                objRows(pGridCols(12).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 13, 2), 16).ToString), "000")
                objRows(pGridCols(13).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 15, 2), 16).ToString), "000")
                ' セットメニュー１～４
                objRows(pGridCols(14).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 17, 2), 16).ToString), "000")
                objRows(pGridCols(15).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 19, 2), 16).ToString), "000")
                objRows(pGridCols(16).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 21, 2), 16).ToString), "000")
                objRows(pGridCols(17).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 23, 2), 16).ToString), "000")

                Select Case Mid$(strFStat, 6, 3)
                    Case "000" : strFStat = "0"
                    Case "001" : strFStat = "1"
                    Case "010" : strFStat = "2"
                    Case "100" : strFStat = "3"
                    Case Else : strFStat = "9"
                End Select
                objRows(pGridCols(18).strMapName) = strFStat

                Select Case CLng(strGoodsCD)
                    Case CLng(udtSysItem.strFrom) To CLng(udtSysItem.strTo)
                        objRows(pGridCols(19).strMapName) = "2"
                    Case CLng(udtPosItem.strFrom) To CLng(udtPosItem.strTo)
                        objRows(pGridCols(19).strMapName) = "3"
                    Case Else
                        strBumon = GF_GetAppInfo("SUSHI_BUMON")
                        ' --- (2003.11.17) 「寿司」商品判定部門を指定しない場合に対応する ---
                        'If Len(Trim$(strBumon)) = 0 Then
                        '    Exit Function
                        'End If
                        blnFound = False
                        If Len(Trim$(strBumon)) <> 0 Then
                            strWork = Split(strBumon, "@")
                            For lngBCnt = 0 To UBound(strWork)
                                If strWork(lngBCnt) = strBumonCD Then
                                    blnFound = True
                                    Exit For
                                End If
                            Next
                        End If
                        ' -----------------------------------------------------------------
                        If blnFound Then
                            objRows(pGridCols(19).strMapName) = "0"
                        Else
                            objRows(pGridCols(19).strMapName) = "1"
                        End If
                End Select

                pTable.Rows.Add(objRows)
                lngCnt = lngCnt + 1
                pStatus.pgs_Status.Value = lngCnt
            End While
            FileClose(intFile)
        Catch
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetFUMENU = True

    End Function

    Private Function LF_WideCnv(ByVal pStr As String) As String
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim strWork As String
        Dim strRet As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_WideCnv = ""
        strRet = ""

        '------------------------------
        ' 全角変換処理
        '------------------------------
        For lngCnt = 1 To Len(pStr)
            strWork = Mid$(pStr, lngCnt, 1)
            ' 2014-05-12 2バイト文字制限解除
            'If strWork <> "m" And strWork <> "l" Then
            '    strRet = strRet & StrConv(strWork, VbStrConv.Wide)
            'Else
                strRet = strRet & strWork
            'End If
        Next

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_WideCnv = strRet

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：アンマッチリスト
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetUnmatchList(ByRef pTable As DataTable, ByVal pGridCols() As typGridColumn, ByVal pStatus As CNL1810) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim objWRow As DataRow = Nothing
        Dim objWRow2 As DataRow = Nothing
        Dim lngCnt As Long
        Dim lngGridCnt As Long
        Dim blnFound As Boolean

        Dim strWGoodsCD As String
        Dim strWGoodsNM As String
        Dim strWPrice As String
        Dim strWSCPStat As String

        Dim strDGoodsCD As String
        Dim strDGoodsNM As String
        Dim strDPrice As String
        Dim strDSCPStat As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetUnmatchList = False

        '------------------------------
        ' 商品マスタ全件取得
        '------------------------------
        If Not LF_GetTPM010(objData) Then
            Exit Function
        End If

        With pStatus
            .lbl_Msg.Text = "メニューテーブルの過不足を確認中です..."
            .pgs_Status.Maximum = objData.Tables("com").Rows.Count
            .pgs_Status.Value = 0
        End With
        System.Windows.Forms.Application.DoEvents()

        Try
            '------------------------------
            ' メニューテーブルオープン
            '------------------------------
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objWRow) Then
                    Exit Function
                End If

                blnFound = False
                strDGoodsCD = Trim$(objWRow("GOODSCD"))

                ' --- (2004.02.02) ＰＯＳ商品名項目へ変更 -----------------------------
                'strDGoodsNM = Trim$(objWRow("GOODSNMJ"))
                strDGoodsNM = Trim$(objWRow("GOODSNMJ3"))
                ' ---------------------------------------------------------------------

                strDPrice = Format$(CLng(Trim$(objWRow("PRICE"))), "#,##0")
                strDSCPStat = Trim$(objWRow("SCPNO01")) & _
                              Trim$(objWRow("SCPNO02")) & _
                              Trim$(objWRow("SCPNO03")) & _
                              Trim$(objWRow("SCPNO04")) & _
                              Trim$(objWRow("SCPNO05")) & _
                              Trim$(objWRow("SCPNO06")) & _
                              Trim$(objWRow("SCPNO07")) & _
                              Trim$(objWRow("SCPNO08")) & _
                              Trim$(objWRow("SCPNO09")) & _
                              Trim$(objWRow("SCPNO10")) & _
                              Trim$(objWRow("SCPNO11")) & _
                              Trim$(objWRow("SCPNO12"))

                For lngGridCnt = 0 To L_objData.Tables("UNMATCHLIST").Rows.Count - 1
                    objWRow2 = L_objData.Tables("UNMATCHLIST").Rows(lngGridCnt)
                    strWGoodsCD = Trim$(objWRow2(L_udtGridCol(0).strMapName))
                    strWGoodsNM = Trim$(objWRow2(L_udtGridCol(1).strMapName))
                    strWPrice = Trim$(objWRow2(L_udtGridCol(2).strMapName))
                    strWSCPStat = Trim$(objWRow2(L_udtGridCol(6).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(7).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(8).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(9).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(10).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(11).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(12).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(13).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(14).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(15).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(16).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(17).strMapName))

                    'If strWGoodsCD = strDGoodsCD And _
                    '   strWGoodsNM = strDGoodsNM And _
                    '   strWPrice = strDPrice And _
                    '   strWSCPStat = strDSCPStat Then

                    ' --- (2003.12.01) 差分検出条件を、商品名のみに変更 ----
                    'If strWGoodsCD = strDGoodsCD And _
                    '   strWGoodsNM = strDGoodsNM Then
                    '    blnFound = True
                    '    Exit For
                    'End If
                    If strWGoodsNM = strDGoodsNM Then
                        blnFound = True
                        Exit For
                    End If
                    ' ------------------------------------------------------
                Next

                If blnFound = False Then
                    objRows = pTable.NewRow
                    objRows(pGridCols(0).strMapName) = Trim$(objWRow("GOODSCD"))
                    ' --- (2004.02.02) ＰＯＳ商品名へ表示項目変更 ----------
                    'objRows(pGridCols(1).strMapName) = Trim$(objWRow("GOODSNMJ"))
                    objRows(pGridCols(1).strMapName) = Trim$(objWRow("GOODSNMJ3"))
                    ' ------------------------------------------------------
                    objRows(pGridCols(2).strMapName) = Format$(CLng(Trim$(objWRow("PRICE"))), "#,##0")

                    ' --- (2003.12.02) 改行タグ隠し対策 --------------------
                    'objRows(pGridCols(3).strMapName) = Trim$(objWRow("JEXPNOTEJ"))
                    objRows(pGridCols(3).strMapName) = Trim$(Replace(Trim$(objWRow("JEXPNOTEJ")), "<BR>", vbCrLf))
                    ' ------------------------------------------------------

                    objRows(pGridCols(4).strMapName) = Trim$(objWRow("IMAGEDATA"))
                    objRows(pGridCols(5).strMapName) = Trim$(objWRow("UNITJ"))
                    objRows(pGridCols(6).strMapName) = Trim$(objWRow("SCPNO01"))
                    objRows(pGridCols(7).strMapName) = Trim$(objWRow("SCPNO02"))
                    objRows(pGridCols(8).strMapName) = Trim$(objWRow("SCPNO03"))
                    objRows(pGridCols(9).strMapName) = Trim$(objWRow("SCPNO04"))
                    objRows(pGridCols(10).strMapName) = Trim$(objWRow("SCPNO05"))
                    objRows(pGridCols(11).strMapName) = Trim$(objWRow("SCPNO06"))
                    objRows(pGridCols(12).strMapName) = Trim$(objWRow("SCPNO07"))
                    objRows(pGridCols(13).strMapName) = Trim$(objWRow("SCPNO08"))
                    objRows(pGridCols(14).strMapName) = Trim$(objWRow("SCPNO09"))
                    objRows(pGridCols(15).strMapName) = Trim$(objWRow("SCPNO10"))
                    objRows(pGridCols(16).strMapName) = Trim$(objWRow("SCPNO11"))
                    objRows(pGridCols(17).strMapName) = Trim$(objWRow("SCPNO12"))
                    ' --- (2004.02.02) タッチパネル商品名引継対応 ----------
                    objRows(pGridCols(23).strMapName) = Trim$(objWRow("GOODSNMJ"))
                    ' ------------------------------------------------------
                    ' --- (2004.02.09) タッチパネル商品名２引継対応 --------
                    objRows(pGridCols(24).strMapName) = Trim$(objWRow("GOODSNMJ2"))
                    ' ------------------------------------------------------
                    objRows(pGridCols(25).strMapName) = "0"

                    ' --- (2004.10.14) ＨＴＬ用名称項目追加 ----------------
                    objRows(pGridCols(26).strMapName) = Trim$(objWRow("HTLNM1"))
                    objRows(pGridCols(27).strMapName) = Trim$(objWRow("HTLNM2"))
                    ' ------------------------------------------------------

                    '--- (2006.05.24) おすすめ、新作フラグ対応 -------------
                    objRows(pGridCols(28).strMapName) = Trim$(objWRow("SPFLG"))
                    objRows(pGridCols(29).strMapName) = Trim$(objWRow("NEWFLG"))
                    '-------------------------------------------------------

                    pTable.Rows.Add(objRows)
                End If

                lngCnt = lngCnt + 1
                pStatus.pgs_Status.Value = lngCnt
            End While

        Catch
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetUnmatchList = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：バイナリデータ読み込み処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetBData(ByVal pStartBit As Integer, _
                                 ByVal pReadLength As Integer, _
                                 ByVal pFileNo As Integer, _
                                 ByVal pRecord As Long, _
                                 ByVal pFullRecLength As Long) As Byte()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim bytBuff() As Byte

        '------------------------------
        ' 取得領域再定義
        '------------------------------
        ReDim bytBuff(pReadLength - 1)

        '------------------------------
        ' データ取得
        '------------------------------
        FileGet(pFileNo, bytBuff(pReadLength - 1), pStartBit + (pFullRecLength * pRecord))

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetBData = bytBuff

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：バイナリデータ(ＳＰＫ項目)数値化
    ' 　機能概要：サイン付きパック10進を Double 型で返却する
    ' 　引　　数：pSubLen : 少数桁数
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_SPKCnv(ByVal pOrg() As Byte, ByVal pSubLen As Integer) As Double

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strWork As String

        strWork = Replace(BitConverter.ToString(pOrg), "-", "")

        LF_SPKCnv = CDbl(Mid$(strWork, 1, (Len(strWork) - 1) - pSubLen))    ' 整数桁
        If pSubLen > 0 Then
            LF_SPKCnv = LF_SPKCnv + CDbl(Mid$(strWork, Len(strWork) - pSubLen, pSubLen)) * (-10 ^ pSubLen)
        End If
        If Mid$(strWork, Len(strWork)) <> "C" Then
            LF_SPKCnv = LF_SPKCnv * -1
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：バイナリデータ(ＳＰＫ項目)数値化
    ' 　機能概要：サイン付きパック10進を Double 型で返却する
    ' 　引　　数：pSubLen : 少数桁数
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_BITCnv(ByVal pOrg() As Byte) As String

        Dim strFmt As String = New String("0", (UBound(pOrg) + 1) * 8)
        LF_BITCnv = Format$(CDbl(Convert.ToString(Convert.ToInt32(Replace(BitConverter.ToString(pOrg), "-", ""), 16), 2)), strFmt)

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：不一致検出グリッド ドラッグ開始処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub grd_ItemList_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grd_ItemList.MouseDown
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCell As DataGridCell
        Dim objHitTest As DataGrid.HitTestInfo
        Dim objPoint As Point

        objPoint = grd_ItemList.PointToClient(Cursor.Position)
        objHitTest = grd_ItemList.HitTest(objPoint)
        If objHitTest.Row <> -1 Then
            objCell.RowNumber = objHitTest.Row
            grd_ItemList.CurrentCell = objCell
        End If

        '座標位置から、有効範囲外であれば、処理を無効とする
        If objHitTest.Row < 0 Or objHitTest.Column < 0 Then
            Exit Sub
        End If

        If grd_ItemList.VisibleRowCount >= 1 Then
            'DoDragDrop(CStr(grd_ItemList(lngRow, 0)), DragDropEffects.Copy)
            DoDragDrop(CStr(grd_ItemList(objHitTest.Row, 0)), DragDropEffects.Copy)
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：不一致検出グリッド ドラッグ中処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub grd_ItemList_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grd_ItemList.DragOver
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：不一致検出グリッド カレントカーソル変化時処理
    ' 　機能概要：行選択状態にする
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub grd_ItemList_CursorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_ItemList.CursorChanged
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCell As DataGridCell = grd_ItemList.CurrentCell
        Dim lngRow As Long = objCell.RowNumber

        If grd_ItemList.VisibleRowCount >= 1 Then
            grd_ItemList.Select(lngRow)
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：最新情報グリッド ドロップ処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub grd_UnmatchList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grd_UnmatchList.DragDrop
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim lngGridCnt As Long
        Dim blnFound As Boolean
        Dim objCell As DataGridCell = grd_UnmatchList.CurrentCell

        blnFound = False
        For lngGridCnt = 0 To GF_GetRowCnt(grd_ItemList) - 1
            If e.Data.GetData(DataFormats.Text) = grd_ItemList(lngGridCnt, 0) Then
                blnFound = True
                Exit For
            End If
        Next

        If blnFound = True Then
            If grd_UnmatchList(objCell.RowNumber, 25) <> "0" Then
                If GF_Msg("Q09", "", MsgBoxStyle.OKCancel, MsgBoxStyle.Question) = MsgBoxResult.Cancel Then
                    Exit Sub
                End If
            End If

            ' --- (2004.02.09) 単価訂正機能追加 ----------------------------
            'For lngCnt = 3 To 5
            '    grd_UnmatchList(objCell.RowNumber, lngCnt) = grd_ItemList(lngGridCnt, lngCnt)
            'Next
            For lngCnt = IIf(L_PriceEdit = GC_TRUE, 2, 3) To 5
                grd_UnmatchList(objCell.RowNumber, lngCnt) = grd_ItemList(lngGridCnt, lngCnt)
            Next
            ' --------------------------------------------------------------

            ' --- (2004.02.02) タッチパネル商品名引継対応 ------------------
            grd_UnmatchList(objCell.RowNumber, 23) = grd_ItemList(lngGridCnt, 23)
            ' --------------------------------------------------------------

            L_blnEditFlg = True
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：最新情報グリッド ドラッグ中処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub grd_UnmatchList_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grd_UnmatchList.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：最新情報グリッド ドラッグ中処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub grd_UnmatchList_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grd_UnmatchList.DragOver
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objPoint As Point = grd_UnmatchList.PointToClient(Cursor.Position)
        Dim objCell As DataGridCell
        Dim objHitTest As System.Windows.Forms.DataGrid.HitTestInfo

        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            '座標位置から、カレント行を変更する
            objHitTest = grd_UnmatchList.HitTest(objPoint)
            If objHitTest.Row <> -1 Then
                objCell.RowNumber = objHitTest.Row
                grd_UnmatchList.CurrentCell = objCell
            End If

            e.Effect = DragDropEffects.Copy
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：最新情報グリッド カレントカーソル変化時処理
    ' 　機能概要：行選択状態にする
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub grd_UnmatchList_CursorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_UnmatchList.CursorChanged
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCell As DataGridCell = grd_UnmatchList.CurrentCell
        Dim lngRow As Long = objCell.RowNumber
        Dim lngCnt As Long

        If grd_UnmatchList.VisibleRowCount >= 1 Then
            For lngCnt = 0 To GF_GetRowCnt(grd_UnmatchList) - 1
                grd_UnmatchList.UnSelect(lngCnt)
            Next
            grd_UnmatchList.Select(lngRow)
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：保存ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------

    ' --------------------------------------------------------------------------------
    ' 　機　　能：表示データ保存処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SaveAllData()

        Me.Cursor = Cursors.WaitCursor

        If Not GF_BeginTrans() Then                                         ' トランザクション開始処理
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' メニューマスタ更新
        '------------------------------
        If Not LF_UpdTPM010() Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' ＳＣＰマスタ更新
        '------------------------------
        If Not LF_UpdTPM100() Then
            GoTo SYSTEM_ERROR
        End If

        ' --- (2003.11.20) 存在しなくなった商品コードについて、ジャンルマスタから削除する ---
        '------------------------------
        ' ジャンルマスタ更新
        '------------------------------
        If Not LF_UpdTPM020() Then
            GoTo SYSTEM_ERROR
        End If
        ' -----------------------------------------------------------------------------------

        ' --- (2003.11.28) 部門マスタを取り込む ----------------------------
        '------------------------------
        ' 部門マスタ更新
        '------------------------------
        If Not LF_UpdTPM110() Then
            GoTo SYSTEM_ERROR
        End If
        ' ------------------------------------------------------------------

        If Not GF_CommitTrans() Then                                        ' トランザクション確定処理
            GoTo SYSTEM_ERROR
        End If

        ' --- (2003.12.02) 未使用商品画像ガベージ処理追加 ------------------
        If Not LF_DelUnuseFile() Then
            ' 更新処理確定後のファイル削除処理でエラーとなっても、ロールバックさせない
            Call GS_ErrorTerm("LS_SaveAllData")
        End If
        ' ------------------------------------------------------------------

        Me.Cursor = Cursors.Default

        Exit Sub

SYSTEM_ERROR:
        Me.Cursor = Cursors.Default
        Call GF_RollbackTrans()                                             ' トランザクション破棄
        Call GS_ErrorTerm("LS_SaveAllData")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：部門マスタ(TPM110)更新処理
    ' 　機能概要：部門マスタ(ＤＰテーブル)を、TPM110 へ転記する
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.11.28 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM110() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strFileNM As String
        Dim intFile As Integer
        Dim lngCnt As Long
        Dim bytData() As Byte
        Dim objSjisEnc As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM110 = False

        '------------------------------
        ' 部門マスタを全件削除
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE FROM TPM110"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        strFileNM = GF_GetAppInfo("OES_PATH") & "\" & _
                    GF_GetAppInfo("OES_DPTBL")
        intFile = FreeFile()
        FileOpen(intFile, strFileNM, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
        lngCnt = 0
        While Not EOF(intFile)
            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM110 VALUES("

            bytData = LF_GetBData(1, 1, intFile, lngCnt, 75)

            If Trim$(Replace(BitConverter.ToString(bytData), "-", "")) <> "00" Then
                strSQL = strSQL & "'" & Trim$(Replace(BitConverter.ToString(bytData), "-", "")) & "',"

                bytData = LF_GetBData(19, 16, intFile, lngCnt, 75)
                strSQL = strSQL & "'" & IIf(Len(Trim$(objSjisEnc.GetString(bytData))) <> 0, Trim$(objSjisEnc.GetString(bytData)), Space(1)) & "',"

                strSQL = strSQL & "'" & GC_UPDID & "',"
                strSQL = strSQL & "'" & Now & "')"
                If Not GF_UpdData(strSQL) Then
                    GoTo SYSTEM_ERROR
                End If
            End If

            lngCnt = lngCnt + 1
        End While
        FileClose(intFile)

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM110 = True
        Exit Function

SYSTEM_ERROR:
        FileClose(intFile)
        Exit Function
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ジャンルマスタ(TPM020)更新処理
    ' 　機能概要：再取り込みによって、存在しなくなった商品コードを、ジャンルマスタから
    '             削除する
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.11.20 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM020() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM020 = False

        '------------------------------
        ' 不要レコード削除
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE"
        strSQL = strSQL & "  FROM TPM020"
        strSQL = strSQL & " WHERE TPM020.GOODSCD <> '0000'"
        strSQL = strSQL & "   AND TPM020.GOODSCD NOT IN (SELECT TPM010.GOODSCD FROM TPM010)"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM020 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューマスタ(TPM010)更新処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM010() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim lngCnt As Long
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM010 = False

        '------------------------------
        ' 全件削除
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE FROM TPM010"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        For lngCnt = 0 To L_objData.Tables("UNMATCHLIST").Rows.Count - 1
            objRows = L_objData.Tables("UNMATCHLIST").Rows(lngCnt)
            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM010 VALUES("
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(0).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(0).strMapName))), Space(1)) & "',"

            ' --- (2004.02.02) 取得元項目変更-------------------------------
            'strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(1).strMapName))) <> 0, GF_RepQuo(GF_MidB(Trim$(objRows(L_udtGridCol(1).strMapName)), 1, 20)), Space(1)) & "',"

            ' --- (2004.02.27) 左余白を削除しないようにする ----------------
            'strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(23).strMapName))) <> 0, GF_RepQuo(GF_MidB(Trim$(objRows(L_udtGridCol(23).strMapName)), 1, 20)), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(23).strMapName))) <> 0, GF_RepQuo(GF_MidB(RTrim$(objRows(L_udtGridCol(23).strMapName)), 1, 20)), Space(1)) & "',"
            ' --------------------------------------------------------------

            ' --------------------------------------------------------------

            ' --- (2004.02.09) タッチパネル商品名２項目追加 ----------------
            ' --- (2003.12.01) 商品名２項目追加 ----------------------------
            ''strSQL = strSQL & "'" & Space(1) & "',"
            'strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(22).strMapName))) <> 0, GF_RepQuo(GF_MidB(Trim$(objRows(L_udtGridCol(22).strMapName)), 1, 20)), Space(1)) & "',"

            ' --- (2004.02.27) 左余白を削除しないようにする ----------------
            'strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(24).strMapName))) <> 0, GF_RepQuo(GF_MidB(Trim$(objRows(L_udtGridCol(24).strMapName)), 1, 20)), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(24).strMapName))) <> 0, GF_RepQuo(GF_MidB(RTrim$(objRows(L_udtGridCol(24).strMapName)), 1, 20)), Space(1)) & "',"
            ' --------------------------------------------------------------

            ' --------------------------------------------------------------
            ' --------------------------------------------------------------

            ' --- (2004.02.02) ＰＯＳ商品名項目追加 ------------------------
            ' --- (2004.02.27) 左余白を削除しないようにする ----------------
            'strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(1).strMapName))) <> 0, GF_RepQuo(GF_MidB(Trim$(objRows(L_udtGridCol(1).strMapName)), 1, 20)), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(1).strMapName))) <> 0, GF_RepQuo(GF_MidB(RTrim$(objRows(L_udtGridCol(1).strMapName)), 1, 20)), Space(1)) & "',"
            ' --------------------------------------------------------------
            ' --------------------------------------------------------------

            ' --- (2004.02.09) タッチパネル商品名２項目追加 ----------------
            ' --- (2004.02.27) 左余白を削除しないようにする ----------------
            'strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(22).strMapName))) <> 0, GF_RepQuo(GF_MidB(Trim$(objRows(L_udtGridCol(22).strMapName)), 1, 20)), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(22).strMapName))) <> 0, GF_RepQuo(GF_MidB(RTrim$(objRows(L_udtGridCol(22).strMapName)), 1, 20)), Space(1)) & "',"
            ' --------------------------------------------------------------
            ' --------------------------------------------------------------

            ' --- (2003.12.02) 改行タグ隠し対策 ----------------------------
            'strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(3).strMapName))) <> 0 And Trim$(objRows(L_udtGridCol(3).strMapName)) <> LC_NODATA, GF_RepQuo(Trim$(objRows(L_udtGridCol(3).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(3).strMapName))) <> 0 And Trim$(objRows(L_udtGridCol(3).strMapName)) <> LC_NODATA, GF_RepQuo(Replace(Trim$(objRows(L_udtGridCol(3).strMapName)), vbCrLf, "<BR>")), Space(1)) & "',"
            ' --------------------------------------------------------------

            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(4).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(4).strMapName))), Space(1)) & "',"
            strSQL = strSQL & CLng(GF_RepQuo(Trim$(objRows(L_udtGridCol(2).strMapName)))) & ","
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(5).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(5).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & GC_TRUE & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(6).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(6).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(7).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(7).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(8).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(8).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(9).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(9).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(10).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(10).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(11).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(11).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(12).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(12).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(13).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(13).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(14).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(14).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(15).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(15).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(16).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(16).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(17).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(17).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(18).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(18).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(19).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(19).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(20).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(20).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(21).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(21).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & GC_TRUE & "',"

            ' --- (2004.10.14) ＨＴＬ用名称項目追加 ------------------------
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(26).strMapName))) <> 0, GF_RepQuo(GF_MidB(RTrim$(objRows(L_udtGridCol(26).strMapName)), 1, 5)), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(27).strMapName))) <> 0, GF_RepQuo(GF_MidB(RTrim$(objRows(L_udtGridCol(27).strMapName)), 1, 5)), Space(1)) & "',"
            ' --------------------------------------------------------------

            '--- (2006.05.24) おすすめ、新作フラグ対応 ---------------------
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(28).strMapName))) <> 0, GF_RepQuo(RTrim$(objRows(L_udtGridCol(28).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(29).strMapName))) <> 0, GF_RepQuo(RTrim$(objRows(L_udtGridCol(29).strMapName))), Space(1)) & "',"
            '---------------------------------------------------------------

            strSQL = strSQL & "'" & GC_UPDID & "',"
            strSQL = strSQL & "'" & Now & "')"
            If Not GF_UpdData(strSQL) Then
                Exit Function
            End If
        Next

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM010 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＳＣＰマスタ(TPM100)更新処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM100() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim lngCnt As Long
        Dim lngCol As Long
        Dim strFileNM As String
        Dim intFile As Integer
        Dim bytData() As Byte
        Dim objSjisEnc As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM100 = False

        '------------------------------
        ' 全件削除
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE FROM TPM100"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        strFileNM = GF_GetAppInfo("OES_PATH") & "\" & _
                    GF_GetAppInfo("OES_SCPTBL")
        intFile = FreeFile()
        FileOpen(intFile, strFileNM, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
        lngCnt = 0
        While Not EOF(intFile)
            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM100 VALUES("

            bytData = LF_GetBData(1, 1, intFile, lngCnt, 53)
            strSQL = strSQL & "'" & Format$(CLng(Convert.ToUInt16(Trim$(Replace(BitConverter.ToString(bytData), "-", "")), 16).ToString), "000") & "',"

            bytData = LF_GetBData(2, 20, intFile, lngCnt, 53)
            strSQL = strSQL & "'" & IIf(Len(Trim$(objSjisEnc.GetString(bytData))) <> 0, Trim$(objSjisEnc.GetString(bytData)), Space(1)) & "',"

            For lngCol = 0 To 15
                bytData = LF_GetBData(22 + (lngCol * 2), 2, intFile, lngCnt, 53)
                strSQL = strSQL & "'" & Trim$(Replace(BitConverter.ToString(bytData), "-", "")) & "',"
            Next

            strSQL = strSQL & "'" & GC_UPDID & "',"
            strSQL = strSQL & "'" & Now & "')"
            If Not GF_UpdData(strSQL) Then
                GoTo SYSTEM_ERROR
            End If

            lngCnt = lngCnt + 1
        End While
        FileClose(intFile)

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM100 = True
        Exit Function

SYSTEM_ERROR:
        FileClose(intFile)
        Exit Function
    End Function

    Private Sub cbo_SelRow_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_SelRow.SelectionChangeCommitted

        '------------------------------
        ' 表示対象行切り替え処理
        '------------------------------
        If GF_GetRowCnt(grd_UnmatchList) = 0 Then Exit Sub
        Call LS_ChgDispStyle(GF_CboGetCode(cbo_SelRow, cbo_SelRow.SelectedIndex))

    End Sub

    Private Sub LS_ChgDispStyle(Optional ByVal pStyle As String = LC_SELROW_ALL)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objView As DataView
        Dim strFilter As String

        '------------------------------
        ' フィルタ文字列生成
        '------------------------------
        If pStyle = LC_SELROW_ALL Then
            strFilter = ""
        Else
            strFilter = L_udtGridCol(25).strMapName & "=0"
        End If

        '------------------------------
        ' グリッドデータ連結
        '------------------------------
        Try
            objView = New DataView(L_objData.Tables("UNMATCHLIST"), _
                                   strFilter, _
                                   "", _
                                   DataViewRowState.CurrentRows)
            grd_UnmatchList.DataSource = objView
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_ChgDispStyle")
    End Sub

    Private Sub TP1080_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        If L_blnEditFlg Then                                                ' 編集更新有無フラグ判定
            Select Case GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNoCancel)
                Case MsgBoxResult.Yes
                    Call LS_SaveAllData()
                Case MsgBoxResult.No
                Case MsgBoxResult.Cancel
                    e.Cancel = True
                    Exit Sub
            End Select
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("TP1080_Closing")
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click

        Try
            Call LS_SaveAllData()

            ' --- (2003.12.02) 更新処理後の「更新フラグ」クリアし忘れ対応 --
            L_blnEditFlg = False
            ' --------------------------------------------------------------
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("MenuItem2_Click")
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品画像フォルダ内 未使用画像ファイル削除処理
    ' 　機能概要：TECツールにて商品が削除されたものに対する対応
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.02 ソラン北陸 新規作成
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
        strSQL = strSQL & "SELECT TPM010.IMAGEDATA"
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
            ' 画像ファイル使用中判定
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
                ' 未使用ファイルであれば削除
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
        ' 返却値設定
        '------------------------------
        LF_DelUnuseFile = True

    End Function

End Class
