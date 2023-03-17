' --------------------------------------------------------------------------------
' 　機　　能：店舗内情報システム - サーバメンテナンス(メニュー登録画面)
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
' --------------------------------------------------------------------------------


Public Class CNL1610
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents crv_View As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CNL1610))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.crv_View = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "ファイル(&F)"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "閉じる"
        '
        'crv_View
        '
        Me.crv_View.ActiveViewIndex = -1
        Me.crv_View.Location = New System.Drawing.Point(0, 8)
        Me.crv_View.Name = "crv_View"
        Me.crv_View.ReportSource = Nothing
        Me.crv_View.ShowGroupTreeButton = False
        Me.crv_View.ShowRefreshButton = False
        Me.crv_View.ShowTextSearchButton = False
        Me.crv_View.Size = New System.Drawing.Size(1016, 656)
        Me.crv_View.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Bitmap)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 0
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(880, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 32)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "印刷"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'CNL1610
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1016, 669)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.crv_View})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL1610"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TP1090"
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub TP1090_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objStatus As New CNL1810()

        '------------------------------
        ' フォーム名称設定
        '------------------------------
        Me.Text = GF_FormText("- 帳票出力画面")

        '------------------------------
        ' 進捗状況通知フォーム表示
        '------------------------------
        objStatus.Show()
        With objStatus
            .lbl_Msg.Text = "帳票出力処理中です。しばらくお待ちください..."
            .pgs_Status.Maximum = 100
            .pgs_Status.Minimum = 0
            .pgs_Status.Value = 0
            .TopMost = True
        End With
        System.Windows.Forms.Application.DoEvents()

        '------------------------------
        ' 帳票出力処理
        '------------------------------
        If Not LF_PrtMain(objStatus) Then
            GoTo SYSTEM_ERROR
        End If

        objStatus.Close()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("TP1090_Load")
    End Sub


    Private Function LF_PrtMain(ByRef pStatus As CNL1810) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objSample As New CNL1620()
        Dim objLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo()


        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_PrtMain = False

        '------------------------------
        ' 帳票出力ワークテーブル生成
        '------------------------------
        If Not LF_PrtCreateWTbl(pStatus) Then
            Exit Function
        End If
        pStatus.lbl_Msg.Text = "帳票イメージを生成しています。しばらくお待ちください..."
        System.Windows.Forms.Application.DoEvents()


        '------------------------------
        ' 帳票出力
        '------------------------------
        ' --- (2003.12.13) 出力方法変更 ------------------------------------
        'Try
        '    With objLogonInfo
        '        .ConnectionInfo = objSample.Database.Tables(0).LogOnInfo.ConnectionInfo
        '        .ConnectionInfo.DatabaseName = g_udtAppConfig.strDBServerDBName
        '        .ConnectionInfo.ServerName = g_udtAppConfig.strDBServerName
        '        .ConnectionInfo.Password = g_udtAppConfig.strDBServerPassWD
        '        .ConnectionInfo.UserID = g_udtAppConfig.strDBServerUserID
        '    End With
        '    With objSample.Database.Tables.Item(0)
        '        .ApplyLogOnInfo(objLogonInfo)
        '        .Location = g_udtAppConfig.strDBServerDBName & _
        '                    ".." & objSample.Database.Tables.Item(0).Name
        '    End With

        '    ' --- (2003.12.02) レポートツリーを非表示とする ----------------
        '    crv_View.DisplayGroupTree = False
        '    ' --------------------------------------------------------------
        '    objSample.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        '    objSample.PrintToPrinter(1, False, 0, 0)
        '    crv_View.ReportSource = objSample
        'Catch
        '    Exit Function
        'End Try
        If Not LF_CreatePrintObj(objSample) Then
            Exit Function
        End If
        Try
            With crv_View
                .DisplayGroupTree = False
                .ShowPrintButton = False
                .ShowRefreshButton = False
                .ShowCloseButton = False
                .ShowExportButton = False
                .ReportSource = objSample
            End With
        Catch
            Exit Function
        End Try
        ' ------------------------------------------------------------------

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_PrtMain = True

    End Function

    Private Function LF_CreatePrintObj(ByRef pPObj As CNL1620) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objSample As New CNL1620()
        Dim objLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_CreatePrintObj = False

        '------------------------------
        ' 帳票出力
        '------------------------------
        Try
            With objLogonInfo
                .ConnectionInfo = objSample.Database.Tables(0).LogOnInfo.ConnectionInfo
                .ConnectionInfo.DatabaseName = g_udtAppConfig.strDBServerDBName
                .ConnectionInfo.ServerName = g_udtAppConfig.strDBServerName
                .ConnectionInfo.Password = g_udtAppConfig.strDBServerPassWD
                .ConnectionInfo.UserID = g_udtAppConfig.strDBServerUserID
            End With
            With objSample.Database.Tables.Item(0)
                .ApplyLogOnInfo(objLogonInfo)
                .Location = g_udtAppConfig.strDBServerDBName & _
                            ".." & objSample.Database.Tables.Item(0).Name
            End With

            objSample.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            pPObj = objSample

        Catch
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_CreatePrintObj = True

    End Function

    Private Function LF_PrtCreateWTbl(ByRef pStatus As CNL1810) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strKCPSts As String
        Dim strWork() As String
        Dim strSCP(1) As String
        Dim lngI As Long
        Dim lngOPCnt As Long
        Dim strSGuide As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_PrtCreateWTbl = False

        '------------------------------
        ' 「寿司」ガイダンス取得
        '------------------------------
        strSGuide = LF_GetSushiGuide()

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        '------------------------------
        ' テーブルクリア
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE FROM TPD040"
        If Not GF_UpdData(strSQL) Then
            Call GF_RollbackTrans()
            Exit Function
        End If

        '------------------------------
        ' 抽出ＳＱＬ文生成
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM060.MENUID,"
        strSQL = strSQL & "       TPM060.MENUNM,"
        strSQL = strSQL & "       TPM060.MENUGRPID,"
        strSQL = strSQL & "       TPM060.MENUGRPNM,"
        strSQL = strSQL & "       TPM060.DISPORDER,"
        strSQL = strSQL & "       TPM060.GROUPCD,"
        strSQL = strSQL & "       (SELECT TPM020.GROUPNM FROM TPM020 WHERE TPM020.GROUPCD = TPM060.GROUPCD AND TPM020.GOODSCD = '0000') AS GROUPNM,"
        strSQL = strSQL & "       TPM020.GOODSCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ4,"
        strSQL = strSQL & "       TPM010.JEXPNOTEJ,"
        strSQL = strSQL & "       (SELECT TPM020.GROUPINFO FROM TPM020 WHERE TPM020.GROUPCD = TPM060.GROUPCD AND TPM020.GOODSCD = '0000') AS GROUPINFO,"
        strSQL = strSQL & "       TPM010.PRICE,"
        strSQL = strSQL & "       TPM010.IMAGEDATA,"
        strSQL = strSQL & "       (SELECT TPM020.GROUPIMAGE FROM TPM020 WHERE TPM020.GROUPCD = TPM060.GROUPCD AND TPM020.GOODSCD = '0000') AS GROUPIMAGE,"

        ' ---(2003.11.28) 抽出項目追加 -------------------------------------
        strSQL = strSQL & "       TPM010.GOODSKIND,"
        strSQL = strSQL & "       TPM010.KCPSTATUS,"
        strSQL = strSQL & "       TPM010.SCPNO01,"
        strSQL = strSQL & "       TPM010.SCPNO02,"
        strSQL = strSQL & "       TPM010.SCPNO03,"
        strSQL = strSQL & "       TPM010.SCPNO04,"
        strSQL = strSQL & "       TPM010.SCPNO05,"
        strSQL = strSQL & "       TPM010.SCPNO06,"
        strSQL = strSQL & "       TPM010.SCPNO07,"
        strSQL = strSQL & "       TPM010.SCPNO08,"
        strSQL = strSQL & "       TPM010.SCPNO09,"
        strSQL = strSQL & "       TPM010.SCPNO10,"
        strSQL = strSQL & "       TPM010.SCPNO11,"
        strSQL = strSQL & "       TPM010.SCPNO12,"
        strSQL = strSQL & "       (SELECT TPM100.GUIDE FROM TPM100 WHERE TPM100.SCPNO = TPM010.SCPNO01) AS SCPNO01G,"
        strSQL = strSQL & "       (SELECT TPM100.GUIDE FROM TPM100 WHERE TPM100.SCPNO = TPM010.SCPNO02) AS SCPNO02G,"
        strSQL = strSQL & "       (SELECT TPM100.GUIDE FROM TPM100 WHERE TPM100.SCPNO = TPM010.SCPNO03) AS SCPNO03G,"
        strSQL = strSQL & "       (SELECT TPM100.GUIDE FROM TPM100 WHERE TPM100.SCPNO = TPM010.SCPNO04) AS SCPNO04G,"
        strSQL = strSQL & "       (SELECT TPM100.GUIDE FROM TPM100 WHERE TPM100.SCPNO = TPM010.SCPNO05) AS SCPNO05G,"
        strSQL = strSQL & "       (SELECT TPM100.GUIDE FROM TPM100 WHERE TPM100.SCPNO = TPM010.SCPNO06) AS SCPNO06G,"
        strSQL = strSQL & "       (SELECT TPM100.GUIDE FROM TPM100 WHERE TPM100.SCPNO = TPM010.SCPNO07) AS SCPNO07G,"
        strSQL = strSQL & "       (SELECT TPM100.GUIDE FROM TPM100 WHERE TPM100.SCPNO = TPM010.SCPNO08) AS SCPNO08G,"
        strSQL = strSQL & "       (SELECT TPM100.GUIDE FROM TPM100 WHERE TPM100.SCPNO = TPM010.SCPNO09) AS SCPNO09G,"
        strSQL = strSQL & "       (SELECT TPM100.GUIDE FROM TPM100 WHERE TPM100.SCPNO = TPM010.SCPNO10) AS SCPNO10G,"
        strSQL = strSQL & "       (SELECT TPM100.GUIDE FROM TPM100 WHERE TPM100.SCPNO = TPM010.SCPNO11) AS SCPNO11G,"
        strSQL = strSQL & "       (SELECT TPM100.GUIDE FROM TPM100 WHERE TPM100.SCPNO = TPM010.SCPNO12) AS SCPNO12G"
        ' ------------------------------------------------------------------

        strSQL = strSQL & "  FROM TPM060,"
        strSQL = strSQL & "       TPM020,"
        strSQL = strSQL & "       TPM010"
        strSQL = strSQL & " WHERE TPM060.GROUPCD = TPM020.GROUPCD"
        strSQL = strSQL & "   AND TPM010.GOODSCD = TPM020.GOODSCD"

        ' --- (2004.08.03) 課題点対応 --------------------------------------
        strSQL = strSQL & "   AND TPM010.SELLFLG = '" & GC_TRUE & "'"
        ' ------------------------------------------------------------------

        strSQL = strSQL & " ORDER BY TPM060.MENUID,"
        strSQL = strSQL & "          TPM060.MENUGRPID,"
        '        strSQL = strSQL & "          TPM060.DISPORDER,"        '2005.10.08 障害修正
        strSQL = strSQL & "          CONVERT(int,TPM060.DISPORDER),"
        strSQL = strSQL & "          TPM020.GOODSCD"
        If Not GF_GetData(strSQL, objData) Then
            Call GF_RollbackTrans()
            Exit Function
        End If

        pStatus.pgs_Status.Maximum = objData.Tables("com").Rows.Count

        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Call GF_RollbackTrans()
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPD040 VALUES("
            strSQL = strSQL & "'" & objRows("MENUID") & "',"
            strSQL = strSQL & "'" & objRows("MENUNM") & "',"
            strSQL = strSQL & "'" & objRows("MENUGRPID") & "',"
            strSQL = strSQL & "'" & objRows("MENUGRPNM") & "',"
            strSQL = strSQL & "'" & objRows("DISPORDER") & "',"
            strSQL = strSQL & "'" & objRows("GROUPCD") & "',"
            strSQL = strSQL & "'" & objRows("GROUPNM") & "',"
            strSQL = strSQL & "'" & objRows("GOODSCD") & "',"
            strSQL = strSQL & "'" & objRows("GOODSNMJ") & "',"
            strSQL = strSQL & "'" & objRows("GOODSNMJ4") & "',"
            strSQL = strSQL & objRows("PRICE") & ","
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows("IMAGEDATA"))) = 0, "×", "○") & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows("GROUPIMAGE"))) = 0, "×", "○") & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows("JEXPNOTEJ"))) = 0, "×", "○") & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows("GROUPINFO"))) = 0, "×", "○") & "',"

            ' --- (2003.11.28) 設定項目追加 --------------------------------
            '------------------------------
            ' ＫＣＰステータス
            '------------------------------
            strKCPSts = ""
            strKCPSts = LF_GetKCPStat(Trim$(objRows("KCPSTATUS")))
            If Len(Trim$(strKCPSts)) = 0 Then
                strSQL = strSQL & "'" & Space(2) & "',"
                strSQL = strSQL & "'" & Space(2) & "',"
                strSQL = strSQL & "'" & Space(2) & "',"
            Else
                strWork = Split(strKCPSts, ",")
                strSQL = strSQL & "'" & IIf(Len(Trim$(strWork(0))) = 0, Space(2), strWork(0)) & "',"
                strSQL = strSQL & "'" & IIf(Len(Trim$(strWork(1))) = 0, Space(2), strWork(1)) & "',"
                strSQL = strSQL & "'" & IIf(Len(Trim$(strWork(2))) = 0, Space(2), strWork(2)) & "',"
            End If

            '------------------------------
            ' ＳＣＰステータス
            '------------------------------
            strSCP(0) = ""
            strSCP(1) = ""
            If Trim$(objRows("GOODSKIND")) = "0" Then
                For lngI = 1 To 12
                    If objRows("SCPNO" & Format$(lngI, "00")) <> "000" Then
                        ' 数量オプションチェック
                        If objRows("SCPNO" & Format$(lngI, "00")) < GF_GetAppInfo("NUMSCP_F") Or _
                           objRows("SCPNO" & Format$(lngI, "00")) > GF_GetAppInfo("NUMSCP_T") Then
                            strSCP(1) = Format$(lngI, "00")
                            Exit For
                        End If
                    End If
                Next
                strSQL = strSQL & "'" & strSGuide & "',"
                If Len(Trim$(strSCP(1))) = 0 Then
                    strSQL = strSQL & "'" & Space(1) & "',"
                Else
                    strSQL = strSQL & "'" & Trim$(objRows("SCPNO" & strSCP(1) & "G")) & "',"
                End If
            Else
                lngOPCnt = 0
                For lngI = 1 To 12
                    If objRows("SCPNO" & Format$(lngI, "00")) <> "000" Then
                        ' 数量オプションチェック
                        If objRows("SCPNO" & Format$(lngI, "00")) >= GF_GetAppInfo("NUMSCP_F") And _
                           objRows("SCPNO" & Format$(lngI, "00")) <= GF_GetAppInfo("NUMSCP_T") Then
                            If lngOPCnt = 0 Then
                                strSCP(0) = Format$(lngI, "00")
                                Exit For
                            Else
                                Exit For
                            End If
                        Else
                            strSCP(lngOPCnt) = Format$(lngI, "00")
                            lngOPCnt = lngOPCnt + 1
                            If lngOPCnt >= 2 Then
                                Exit For
                            End If
                        End If
                    End If
                Next
                If Len(Trim$(strSCP(0))) = 0 Then
                    strSQL = strSQL & "'" & Space(1) & "',"
                Else
                    strSQL = strSQL & "'" & Trim$(objRows("SCPNO" & strSCP(0) & "G")) & "',"
                End If
                If Len(Trim$(strSCP(1))) = 0 Then
                    strSQL = strSQL & "'" & Space(1) & "',"
                Else
                    strSQL = strSQL & "'" & Trim$(objRows("SCPNO" & strSCP(1) & "G")) & "',"
                End If
            End If
            ' --------------------------------------------------------------

            strSQL = strSQL & "'" & GC_UPDID & "',"
            strSQL = strSQL & "'" & Now & "')"
            If Not GF_UpdData(strSQL) Then
                Call GF_RollbackTrans()
                Exit Function
            End If

            lngCnt = lngCnt + 1
            pStatus.pgs_Status.Value = lngCnt
        End While

        '------------------------------
        ' トランザクション確定
        '------------------------------
        If Not GF_CommitTrans() Then
            Call GF_RollbackTrans()
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_PrtCreateWTbl = True

    End Function

    ' --- (2003.11.28) ＫＰステータス判定処理 ------------------------------
    Private Function LF_GetKCPStat(ByVal pStsBit As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strKCP(3) As String
        Dim lngI As Long
        Dim lngJ As Long
        Dim strRet(2) As String
        Dim lngCnt As Long

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetKCPStat = ""

        strKCP(0) = Mid$(pStsBit, 1, 8)
        strKCP(1) = Mid$(pStsBit, 9, 8)
        strKCP(2) = Mid$(pStsBit, 17, 8)
        strKCP(3) = Mid$(pStsBit, 25, 8)
        strRet(0) = ""
        strRet(1) = ""
        strRet(2) = ""

        lngCnt = 0
        For lngI = 0 To 3
            'For lngJ = 1 To 8
            For lngJ = 8 To 1 Step -1                                       ' --- (2003.12.09) 昇順出力対応 ---
                If Mid$(strKCP(lngI), lngJ, 1) = "1" Then
                    strRet(lngCnt) = (8 - (lngJ - 1)) + (lngI * 8)
                    lngCnt = lngCnt + 1
                    If lngCnt >= 3 Then
                        Exit For
                    End If
                End If
            Next
            If lngCnt >= 3 Then
                Exit For
            End If
        Next

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetKCPStat = strRet(0) & "," & _
                        strRet(1) & "," & _
                        strRet(2)

    End Function
    ' ----------------------------------------------------------------------

    Private Function LF_GetSushiGuide() As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strSCPNo As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetSushiGuide = ""

        '------------------------------
        ' ＳＣＰ番号取得
        '------------------------------
        strSCPNo = GF_GetAppInfo("SUSHI_SCP_NO")
        If Len(Trim$(strSCPNo)) = 0 Then
            Exit Function
        End If

        '------------------------------
        ' ガイダンス取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM100.GUIDE"
        strSQL = strSQL & "  FROM TPM100"
        strSQL = strSQL & " WHERE TPM100.SCPNO = '" & strSCPNo & "'"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If
        If Not GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetSushiGuide = Trim$(objRows("GUIDE"))

    End Function

    ' --- (2003.12.02) メニューバーより、閉じるコマンド追加 ----------------
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub
    ' ----------------------------------------------------------------------


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim objSample As New CNL1620()

        If Not LF_CreatePrintObj(objSample) Then
            Exit Sub
        End If

        With PrintDialog1
            .AllowPrintToFile = False
            .AllowSomePages = True
            .AllowSelection = True
            .PrinterSettings = New System.Drawing.Printing.PrinterSettings()
            .PrinterSettings.PrintRange = Drawing.Printing.PrintRange.AllPages

            If .ShowDialog = DialogResult.OK Then
                objSample.PrintOptions.PrinterName = .PrinterSettings.PrinterName
                objSample.PrintToPrinter(1, False, .PrinterSettings.FromPage, .PrinterSettings.ToPage)
            End If
        End With

    End Sub

End Class
