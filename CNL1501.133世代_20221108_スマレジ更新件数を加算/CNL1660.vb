Public Class CNL1660
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents crv_View As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CNL1660))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.crv_View = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.MenuItem2.Text = "閉じる(&C)"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Bitmap)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 0
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(879, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 32)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "印刷"
        '
        'crv_View
        '
        Me.crv_View.ActiveViewIndex = -1
        Me.crv_View.Location = New System.Drawing.Point(-88, 16)
        Me.crv_View.Name = "crv_View"
        Me.crv_View.ReportSource = Nothing
        Me.crv_View.ShowExportButton = False
        Me.crv_View.ShowGroupTreeButton = False
        Me.crv_View.ShowPrintButton = False
        Me.crv_View.ShowRefreshButton = False
        Me.crv_View.ShowTextSearchButton = False
        Me.crv_View.Size = New System.Drawing.Size(1016, 672)
        Me.crv_View.TabIndex = 19
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(736, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 34)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "データ出力"
        '
        'CNL1660
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1014, 665)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button2, Me.Button1, Me.crv_View})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL1660"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNL1660"
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' ------------------------------------------------------------------------------
    ' モジュール内ユーザ定義型定義
    ' ------------------------------------------------------------------------------
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
        Dim URIAGE_NUM As String                                            ' 20040722 - 現地対応
    End Structure
    Private L_OrderData As strOrderData

    Private Structure strOrderDataKEY
        Dim SHOHIN As String
    End Structure
    Private L_OrderDatakey As strOrderDataKEY

    Public Structure typMsg
        Dim strMSGID As String
        Dim strMSGTEXT As String
    End Structure

    Private Sub CNL1660_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objStatus As New CNL1810()

        '------------------------------
        ' フォーム名称設定
        '------------------------------
        Me.Text = GF_FormText("- 売上速報出力画面")

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
        With objStatus.pgs_Status
            .Minimum = 0
            .Maximum = 100
            .Value = 0
        End With
        Select Case LF_PrtMain(objStatus)
            Case CNL1920.FuncResult.CancelEnd

                Exit Sub
            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        objStatus.Close()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1660_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：サーバ／ＤＢサーバ接続処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.09 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_SVDBConnect() As Boolean
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strConnect As String
        Dim strDBSVNM As String
        Dim strDBSVDBNM As String
        Dim strDBSVUID As String
        Dim strDBSVPASS As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_SVDBConnect = False
        strDBSVNM = GF_GetAppInfo("SVDB_NM")
        strDBSVDBNM = GF_GetAppInfo("SVDB_DBNM")
        strDBSVUID = GF_GetAppInfo("SVDB_UID")
        strDBSVPASS = GF_GetAppInfo("SVDB_PASSWD")

        '------------------------------
        ' 接続文字列生成
        '------------------------------
        strConnect = "data source=" & Trim$(strDBSVNM) & ";" & _
                     "initial catalog=" & Trim$(strDBSVDBNM) & ";" & _
                     "user id=" & Trim$(strDBSVUID) & ";" & _
                     "password=" & Trim$(strDBSVPASS) & ";"

        '------------------------------
        ' 接続処理
        '------------------------------
        Try
            G_objSVConnect = New SqlClient.SqlConnection(strConnect)
            G_objSVConnect.Open()
        Catch
            GoTo SYSTEM_ERROR
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_SVDBConnect = True

        Exit Function

SYSTEM_ERROR:
        LF_SVDBConnect = False
        Exit Function
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：サーバ側ＤＢ読み込み処理(データセット生成)
    ' 　機能概要：入力引数より、データセットを生成します。また、当関数の出力引数を
    '　　　　　 　comGetRows()関数を使用することで参照することができます。
    ' 　引　　数：pstrSQL          参照ＳＱＬ文
    '　　　　　 ：pSqlDataReader   参照結果
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2003.12.09 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_SVGetData(ByVal pstrSQL As String, _
                                  ByRef pdstData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objAdapter As SqlClient.SqlDataAdapter

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_SVGetData = False

        '------------------------------
        ' ＤＢ抽出処理
        '------------------------------
        Try
            objAdapter = New SqlClient.SqlDataAdapter(pstrSQL, G_objSVConnect)
            objAdapter.Fill(pdstData, "com")
        Catch
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_SVGetData = True

    End Function

    Private Function LF_PrtMain(ByRef pStatus As CNL1810) As FuncResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objSample As New CNL1670()
        Dim objLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_PrtMain = CNL1920.FuncResult.UnusualEnd
        Try
            With crv_View
                .DisplayGroupTree = False
                .ShowPrintButton = False
                .ShowRefreshButton = False
                .ShowCloseButton = False
                .ShowExportButton = False
            End With
        Catch
            Exit Function
        End Try

        '------------------------------
        ' 帳票出力ワークテーブル生成
        '------------------------------
        If Not GF_BeginTrans() Then                                         ' トランザクション開始処理
            Exit Function
        End If
        If Not LF_Delete() Then
            GoTo SYSTEM_ERROR
        End If
        If Not GF_CommitTrans() Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' サーバデータベース接続
        '------------------------------
        If Not LF_SVDBConnect() Then
            pStatus.Close()
            Call GF_Msg("", "サーバとの接続ができませんでした", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
            LF_PrtMain = CNL1920.FuncResult.CancelEnd
            Exit Function
        End If

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then                                         ' トランザクション開始処理
            Exit Function
        End If

        Select Case LF_PrtCreateWTbl(pStatus, "1")
            Case CNL1920.FuncResult.CancelEnd
                pStatus.Close()
                LF_PrtMain = CNL1920.FuncResult.CancelEnd
                GoTo SYSTEM_ERROR
            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        ' --- (2004.08.02) 課題点対応 --------------------------------------
        'Select Case LF_PrtCreateWTbl(pStatus, "2")
        '    Case CNL1920.FuncResult.CancelEnd
        '        pStatus.Close()
        '        LF_PrtMain = CNL1920.FuncResult.CancelEnd
        '        GoTo SYSTEM_ERROR
        '    Case CNL1920.FuncResult.UnusualEnd
        '        GoTo SYSTEM_ERROR
        'End Select
        ' ------------------------------------------------------------------

        '------------------------------
        ' トランザクション確定処理
        '------------------------------
        If Not GF_CommitTrans() Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' サーバデータベース接続 切断
        '------------------------------
        G_objSVConnect.Close()                                          ' サーバ側ＤＢ接続解放
        G_objSVConnect.Dispose()

        pStatus.lbl_Msg.Text = "帳票イメージを生成しています。しばらくお待ちください..."
        System.Windows.Forms.Application.DoEvents()

        '------------------------------
        ' 帳票出力
        '------------------------------
        If Not LF_CreatePrintObj(objSample) Then
            Exit Function
        End If
        Try
            crv_View.ReportSource = objSample
        Catch
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_PrtMain = CNL1920.FuncResult.NormalEnd
        Exit Function

SYSTEM_ERROR:
        Call GF_RollbackTrans()
    End Function

    Private Function LF_CreatePrintObj(ByRef pPObj As CNL1670) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objSample As New CNL1670()
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

    Private Function LF_PrtCreateWTbl(ByRef pStatus As CNL1810, ByVal pJyoken As String) As FuncResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strNow As String
        Dim lngSum As Long                                                  ' 20040722 現地対応
        Dim objSum As strOrderData

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_PrtCreateWTbl = CNL1920.FuncResult.UnusualEnd
        strNow = Format(Now(), "yyyyMMdd")                                  ' システム日付設定

        ' --- (2004.08.03) 課題点対応 --------------------------------------
        With objSum
            .OUTSHOHIN = ""
            .SHOHIN = "9999"
            .SHOHINNM = "合計"
            .TIME00 = "0"
            .TIME01 = "0"
            .TIME02 = "0"
            .TIME03 = "0"
            .TIME04 = "0"
            .TIME05 = "0"
            .TIME06 = "0"
            .TIME07 = "0"
            .TIME08 = "0"
            .TIME09 = "0"
            .TIME10 = "0"
            .TIME11 = "0"
            .TIME12 = "0"
            .TIME13 = "0"
            .TIME14 = "0"
            .TIME15 = "0"
            .TIME16 = "0"
            .TIME17 = "0"
            .TIME18 = "0"
            .TIME19 = "0"
            .TIME20 = "0"
            .TIME21 = "0"
            .TIME22 = "0"
            .TIME23 = "0"
            .URIAGE = "0"
            .URIAGE_NUM = "0"
        End With
        ' ------------------------------------------------------------------

        '------------------------------
        'データ取得
        '------------------------------
        If Not LF_GetData(objData, pJyoken) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Call GF_Msg("", "対象データがありません", MsgBoxStyle.OKOnly, MsgBoxStyle.Information)
            LF_PrtCreateWTbl = CNL1920.FuncResult.CancelEnd
            Exit Function
        End If

        Try
            lngCnt = 0
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If

            While lngCnt < objData.Tables("com").Rows.Count
                Call LS_ClearData()                                         ' 初期化
                L_OrderDatakey.SHOHIN = CStr(objRows("SHOHIN"))             ' キー退避
                Select Case pJyoken                                         ' ヘッダ編集
                    Case "1"
                        L_OrderData.SHOHINKIND = "商品番号"
                        L_OrderData.OUTSHOHIN = CStr(objRows("SHOHIN"))
                        L_OrderData.SHOHINNM = CStr(objRows("SHOHINNM")) & CStr(objRows("SHOHINNM2"))
                    Case "2"
                        L_OrderData.SHOHINKIND = "ジャンル"
                        L_OrderData.OUTSHOHIN = ""
                        L_OrderData.SHOHINNM = CStr(objRows("SHOHINNM"))
                End Select
                L_OrderData.SHOHIN = CStr(objRows("SHOHIN"))

                lngSum = 0                                                  ' 20040722 現地対応
                While L_OrderDatakey.SHOHIN = CStr(objRows("SHOHIN")) And _
                      lngCnt < objData.Tables("com").Rows.Count

                    Select Case CStr(objRows("TIME"))                       ' WKに格納
                        'Case strNow & "00"
                        '    L_OrderData.TIME00 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "01"
                        '    L_OrderData.TIME01 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "02"
                        '    L_OrderData.TIME02 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "03"
                        '    L_OrderData.TIME03 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "04"
                        '    L_OrderData.TIME04 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "05"
                        '    L_OrderData.TIME05 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "06"
                        '    L_OrderData.TIME06 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "07"
                        '    L_OrderData.TIME07 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "08"
                        '    L_OrderData.TIME08 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "09"
                        '    L_OrderData.TIME09 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "10"
                        '    L_OrderData.TIME10 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                    Case strNow & "11"
                            L_OrderData.TIME11 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME11 = CLng(objSum.TIME11) + CLng(objRows("CNT"))
                        Case strNow & "12"
                            L_OrderData.TIME12 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME12 = CLng(objSum.TIME12) + CLng(objRows("CNT"))
                        Case strNow & "13"
                            L_OrderData.TIME13 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME13 = CLng(objSum.TIME13) + CLng(objRows("CNT"))
                        Case strNow & "14"
                            L_OrderData.TIME14 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME14 = CLng(objSum.TIME14) + CLng(objRows("CNT"))
                        Case strNow & "15"
                            L_OrderData.TIME15 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME15 = CLng(objSum.TIME15) + CLng(objRows("CNT"))
                        Case strNow & "16"
                            L_OrderData.TIME16 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME16 = CLng(objSum.TIME16) + CLng(objRows("CNT"))
                        Case strNow & "17"
                            L_OrderData.TIME17 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME17 = CLng(objSum.TIME17) + CLng(objRows("CNT"))
                        Case strNow & "18"
                            L_OrderData.TIME18 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME18 = CLng(objSum.TIME18) + CLng(objRows("CNT"))
                        Case strNow & "19"
                            L_OrderData.TIME19 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME19 = CLng(objSum.TIME19) + CLng(objRows("CNT"))
                        Case strNow & "20"
                            L_OrderData.TIME20 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME20 = CLng(objSum.TIME20) + CLng(objRows("CNT"))
                        Case strNow & "21"
                            L_OrderData.TIME21 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME21 = CLng(objSum.TIME21) + CLng(objRows("CNT"))
                        Case strNow & "22"
                            L_OrderData.TIME22 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME22 = CLng(objSum.TIME22) + CLng(objRows("CNT"))
                        Case strNow & "23"
                            L_OrderData.TIME23 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME23 = CLng(objSum.TIME23) + CLng(objRows("CNT"))
                        Case Else
                            '何もしない
                    End Select

                    L_OrderData.URIAGE = L_OrderData.URIAGE + (CInt(objRows("PRICE")))
                    objSum.URIAGE = objSum.URIAGE + CInt(objRows("PRICE"))

                    lngCnt = lngCnt + 1
                    pStatus.pgs_Status.Value = pStatus.pgs_Status.Value + Fix((50 / CLng(objData.Tables("com").Rows.Count)))
                    If lngCnt < objData.Tables("com").Rows.Count Then
                        If Not GF_GetRows(objData, lngCnt, objRows) Then
                            Exit Function
                        End If
                    End If
                End While

                ' --- (2004.07.22) 現地対応 --------------------------------
                L_OrderData.URIAGE_NUM = CStr(lngSum)
                ' ----------------------------------------------------------
                objSum.URIAGE_NUM = CStr(CLng(objSum.URIAGE_NUM) + lngSum)

                '------------------------------
                ' 帳票テーブル更新
                '------------------------------
                If Not LF_DataUpd(L_OrderData) Then
                    Exit Function
                End If
            End While

            ' --- (2004.08.03) 課題点対応 ----------------------------------
            objSum.SHOHINKIND = L_OrderData.SHOHINKIND
            If Not LF_DataUpd(objSum) Then
                Exit Function
            End If
            ' --------------------------------------------------------------

        Catch
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_PrtCreateWTbl = CNL1920.FuncResult.NormalEnd

        Exit Function
    End Function

    Private Sub LS_ClearData()
        Try
            L_OrderData.SHOHIN = ""
            L_OrderData.OUTSHOHIN = ""
            L_OrderData.SHOHINNM = ""
            L_OrderData.TIME00 = 0
            L_OrderData.TIME01 = 0
            L_OrderData.TIME02 = 0
            L_OrderData.TIME03 = 0
            L_OrderData.TIME04 = 0
            L_OrderData.TIME05 = 0
            L_OrderData.TIME06 = 0
            L_OrderData.TIME07 = 0
            L_OrderData.TIME08 = 0
            L_OrderData.TIME09 = 0
            L_OrderData.TIME10 = 0
            L_OrderData.TIME11 = 0
            L_OrderData.TIME12 = 0
            L_OrderData.TIME13 = 0
            L_OrderData.TIME14 = 0
            L_OrderData.TIME15 = 0
            L_OrderData.TIME16 = 0
            L_OrderData.TIME17 = 0
            L_OrderData.TIME18 = 0
            L_OrderData.TIME19 = 0
            L_OrderData.TIME20 = 0
            L_OrderData.TIME21 = 0
            L_OrderData.TIME22 = 0
            L_OrderData.TIME23 = 0
            L_OrderData.URIAGE = 0
            L_OrderData.URIAGE_NUM = 0                                      ' 20040722 - 現地対応
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_ClearData")
    End Sub

    Private Function LF_Delete() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_Delete = False

        '------------------------------
        ' ワークテーブル削除
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE"
        strSQL = strSQL & "  FROM TPD100"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_Delete = True

    End Function

    Private Function LF_GetData(ByRef pDataSet As DataSet, ByVal pJyoken As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strNow As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetData = False

        'システム日付設定
        strNow = Format(Now(), "yyyyMMdd")

        strSQL = ""
        Select Case pJyoken
            Case 1
                '商品番号
                strSQL = strSQL & "SELECT SUM(TPD010.QUANTITY) CNT,"
                strSQL = strSQL & "       TPD010.GOODSCD SHOHIN,"
                strSQL = strSQL & "       MAX(TPM010.GOODSNMJ) SHOHINNM,"
                strSQL = strSQL & "       MAX(TPM010.GOODSNMJ2) SHOHINNM2,"
                strSQL = strSQL & "       SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME),1, 10) TIME,"
                strSQL = strSQL & "       SUM(TPM010.PRICE * TPD010.QUANTITY) PRICE"
                strSQL = strSQL & "  FROM TPD010,"
                strSQL = strSQL & "       TPM010 "
                strSQL = strSQL & " WHERE TPD010.GOODSCD = TPM010.GOODSCD"
                strSQL = strSQL & "   AND TPD010.SELECTTIME <> 0"
                strSQL = strSQL & "   AND TPD010.ORDERTIME  <> 0"
                strSQL = strSQL & "   AND TPD010.TRANSTIME <> 0"
                strSQL = strSQL & "   AND TPD010.TRANSTIME <> 99999999999999"
                strSQL = strSQL & "   AND SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME),1, 8) = '" & strNow & "'"
                strSQL = strSQL & " GROUP BY TPD010.GOODSCD,"
                strSQL = strSQL & "          SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME),1, 10)"
                strSQL = strSQL & " ORDER BY TPD010.GOODSCD,"
                strSQL = strSQL & "          TIME"

            Case 2
                'ジャンル
                strSQL = strSQL & "SELECT SUM(TPD010.QUANTITY) CNT,"
                strSQL = strSQL & "       TPM020A.GROUPCD SHOHIN,"
                strSQL = strSQL & "       MAX(TPM020B.GROUPNM) SHOHINNM,"
                strSQL = strSQL & "       SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME),1, 10) TIME,"
                strSQL = strSQL & "       SUM(TPM010.PRICE * TPD010.QUANTITY) PRICE"
                strSQL = strSQL & "  FROM TPD010,"
                strSQL = strSQL & "       TPM010,"
                strSQL = strSQL & "       TPM020 TPM020A,"
                strSQL = strSQL & "       TPM020 TPM020B"
                strSQL = strSQL & " WHERE TPD010.GOODSCD = TPM010.GOODSCD"
                strSQL = strSQL & "   AND TPD010.GOODSCD = TPM020A.GOODSCD"
                strSQL = strSQL & "   AND TPM020B.GROUPCD = TPM020A.GROUPCD"
                strSQL = strSQL & "   AND TPM020B.GOODSCD = '0000'"
                strSQL = strSQL & "   AND TPD010.SELECTTIME <> 0"
                strSQL = strSQL & "   AND TPD010.ORDERTIME  <> 0"
                strSQL = strSQL & "   AND TPD010.TRANSTIME <> 0"
                strSQL = strSQL & "   AND TPD010.TRANSTIME <> 99999999999999"
                strSQL = strSQL & "   AND SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME),1, 8) = '" & strNow & "'"
                strSQL = strSQL & " GROUP BY TPM020A.GROUPCD,"
                strSQL = strSQL & "          SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME),1, 10)"
                strSQL = strSQL & " ORDER BY TPM020A.GROUPCD,"
                strSQL = strSQL & "          TIME"
        End Select

        If Not LF_SVGetData(strSQL, pDataSet) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetData = True

    End Function

    Private Function LF_DataUpd(ByRef pOrderData As strOrderData) As Boolean
        '------------------------------       
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_DataUpd = False

        strSQL = ""
        strSQL = strSQL & "INSERT INTO"
        strSQL = strSQL & "     TPD100"
        strSQL = strSQL & "     VALUES ('"
        strSQL = strSQL & pOrderData.SHOHINKIND & "','"
        strSQL = strSQL & pOrderData.SHOHIN & "','"
        strSQL = strSQL & LF_PadSpc(pOrderData.OUTSHOHIN, 4) & "','"
        strSQL = strSQL & pOrderData.SHOHINNM & "',"
        strSQL = strSQL & pOrderData.TIME00 & ","
        strSQL = strSQL & pOrderData.TIME01 & ","
        strSQL = strSQL & pOrderData.TIME02 & ","
        strSQL = strSQL & pOrderData.TIME03 & ","
        strSQL = strSQL & pOrderData.TIME04 & ","
        strSQL = strSQL & pOrderData.TIME05 & ","
        strSQL = strSQL & pOrderData.TIME06 & ","
        strSQL = strSQL & pOrderData.TIME07 & ","
        strSQL = strSQL & pOrderData.TIME08 & ","
        strSQL = strSQL & pOrderData.TIME09 & ","
        strSQL = strSQL & pOrderData.TIME10 & ","
        strSQL = strSQL & pOrderData.TIME11 & ","
        strSQL = strSQL & pOrderData.TIME12 & ","
        strSQL = strSQL & pOrderData.TIME13 & ","
        strSQL = strSQL & pOrderData.TIME14 & ","
        strSQL = strSQL & pOrderData.TIME15 & ","
        strSQL = strSQL & pOrderData.TIME16 & ","
        strSQL = strSQL & pOrderData.TIME17 & ","
        strSQL = strSQL & pOrderData.TIME18 & ","
        strSQL = strSQL & pOrderData.TIME19 & ","
        strSQL = strSQL & pOrderData.TIME20 & ","
        strSQL = strSQL & pOrderData.TIME21 & ","
        strSQL = strSQL & pOrderData.TIME22 & ","
        strSQL = strSQL & pOrderData.TIME23 & ","
        strSQL = strSQL & pOrderData.URIAGE & ","
        strSQL = strSQL & pOrderData.URIAGE_NUM & ","
        strSQL = strSQL & "'SYSTEM',"
        strSQL = strSQL & "getdate()"
        strSQL = strSQL & ")"

        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_DataUpd = True

    End Function

    Public Function LF_PadSpc(ByVal pStr As String, ByVal Length As Long) As String

        LF_PadSpc = Space(Length - Len(Trim$(pStr))) & Trim$(pStr)

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim objSample As New CNL1670()

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

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub


    '-----------------(2011.3.28)売上速報データ出力追加　山浦-------------------------------
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim RowsCnt As Integer
        Dim ColmCnt As Integer
        Dim FileName As String = Nothing
        Dim strEncoding As System.Text.Encoding
        Dim strStreamWriter As System.IO.StreamWriter = Nothing

        '------------------------------
        'ダイアログボックス表示
        '------------------------------
        If Not GetSaveFile(FileName) Then
            Exit Sub
        End If

        '------------------------------
        ' TPD100 取得SQL
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "select OUTMSGNO AS ""商品番号"", GOODSNM AS ""名称"", URIAGENUM AS ""売上数量"","
        strSQL = strSQL & " TIME07 AS ""07:00"", TIME08 AS ""08:00"", TIME09 AS ""09:00"", TIME10 AS ""10:00"","
        strSQL = strSQL & " TIME11 AS ""11:00"", TIME12 AS ""12:00"", TIME13 AS ""13:00"","
        strSQL = strSQL & " TIME14 AS ""14:00"", TIME15 AS ""15:00"", TIME16 AS ""16:00"", TIME17 AS ""17:00"", TIME18 AS ""18:00"", TIME19 AS ""19:00"", TIME20 AS ""20:00"","
        strSQL = strSQL & " TIME21 AS ""21:00"", TIME22 AS ""22:00"", TIME23 AS ""23:00"", URIAGE AS ""売上金額"""
        strSQL = strSQL & " from TPD100"

        '------------------------------
        'データ取得
        '------------------------------
        If Not GF_GetData(strSQL, objData) Then
            Call GF_Msg("", "DB接続に失敗しました", MsgBoxStyle.OKOnly, MsgBoxStyle.Information)
            Exit Sub
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Call GF_Msg("", "対象データがありません", MsgBoxStyle.OKOnly, MsgBoxStyle.Information)
            Exit Sub
        End If

        Try
            '------------------------------
            'ファイル名設定
            '------------------------------
            strEncoding = System.Text.Encoding.GetEncoding("Shift_JIS")
            strStreamWriter = New System.IO.StreamWriter(FileName, False, strEncoding)

            '------------------------------
            'ファイル出力
            '------------------------------
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
                    If RowsCnt = 0 Then
                        If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                            strStreamWriter.WriteLine(objData.Tables("com").Columns(ColmCnt))
                        Else
                            strStreamWriter.Write(objData.Tables("com").Columns(ColmCnt))
                            strStreamWriter.Write(",")
                        End If
                    Else
                        If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                            strStreamWriter.WriteLine(objData.Tables("com").Rows(RowsCnt)(ColmCnt))
                        Else
                            strStreamWriter.Write(objData.Tables("com").Rows(RowsCnt)(ColmCnt) & ",")
                        End If
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
        MsgBox("保存が終了しました")

    End Sub

    Private Function GetSaveFile(ByRef fname As String) As Boolean
        GetSaveFile = False

        'SaveFileDialogクラスのインスタンスを作成
        Dim sfd As New SaveFileDialog()

        'はじめのファイル名を指定する
        sfd.FileName = "PriceData(" & Format$(Now, "yyyyMMddHHmmss") & ").csv"
        'はじめに表示されるフォルダを指定する
        sfd.InitialDirectory = "C:\"
        '[ファイルの種類]に表示される選択肢を指定する
        sfd.Filter = _
         "csvファイル|*.csv|すべてのファイル(*.*)|*.*"
        '[ファイルの種類]ではじめに
        '「すべてのファイル」が選択されているようにする
        sfd.FilterIndex = 2
        'タイトルを設定する
        sfd.Title = "保存先のファイルを選択してください"
        'ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
        sfd.RestoreDirectory = True
        '既に存在するファイル名を指定したとき警告する
        'デフォルトでTrueなので指定する必要はない
        sfd.OverwritePrompt = True
        '存在しないパスが指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        sfd.CheckPathExists = True

        'ダイアログを表示する
        If sfd.ShowDialog() = DialogResult.OK Then
            fname = sfd.FileName
        Else
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        GetSaveFile = True

    End Function

End Class
