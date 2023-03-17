Public Class CtrlForm

    'その他
    Private _スマレジ連携履歴更新情報 As スマレジ連携履歴更新情報型

    'スマレジ HTTPステータス
    Private Const HTTP_OK As String = "200 OK"
    Private Const HTTP_BAD_REQUEST As String = "400 BadRequest"
    Private Const HTTP_NOT_FOUND As String = "404 Not Found"
    Private Const HTTP_想定外エラー As String = "接続エラー"

#Region "構造体"

    Private Structure スマレジ連携履歴更新情報型
        Dim HTTPステータス As String

        Public Sub Initialize()
            HTTPステータス = ""
        End Sub

    End Structure

#End Region

    '受信時にタイマーを操作するために必要な処理
    Private Delegate Sub StartTimerDelegate()
    Private StartTimerThread As Threading.Thread

    Private OutLog As OutLog
    Private DBAccess As DataBaseAccess

    '制御用フラグ
    Private OpenFlg_DB As Boolean
    Private OpenFlg_Timer As Boolean

    'コンストラクタ
    Public Sub New()

        ' この呼び出しは、Windows フォーム デザイナで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        ''ログクラスの生成
        'OutLog = New OutLog(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) & _
        '                    "\" & System.Configuration.ConfigurationManager.AppSettings("OutLogFile").ToString())

        'データベースクラスの生成
        DBAccess = New DataBaseAccess

    End Sub

    'フォームロード処理
    Private Sub CtrlForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'フラグの初期化
        OpenFlg_DB = False
        OpenFlg_Timer = False

        Try

            'タイマーインターバル設定
            If IsNumeric(System.Configuration.ConfigurationManager.AppSettings("TimerInterval").ToString()) = True Then
                Timer1.Interval = CInt(System.Configuration.ConfigurationManager.AppSettings("TimerInterval").ToString())
            Else
                Timer1.Interval = 5000
            End If

            'タイマーの起動 
            OpenFlg_Timer = True
            StartTimerThread = New Threading.Thread(AddressOf StartTimerWorker)
            StartTimerThread.Start()

        Catch ex As Exception

            Call OutLog.OutLog(ex.Message)

        End Try

    End Sub

    'タイマー操作を別スレッドで行う為の記述
    Private Sub StartTimerWorker()

        Try

            Invoke(New StartTimerDelegate(AddressOf StartTimer))

        Catch ex As Exception

            Call OutLog.OutLog(ex.Message)

        End Try

    End Sub

    'タイマー操作を別スレッドで行う為の記述
    Private Sub StartTimer()

        Try

            Timer1.Enabled = True

        Catch ex As Exception

            Call OutLog.OutLog(ex.Message)

        End Try

    End Sub

    'タイマー操作を別スレッドで行う為の記述
    Private Sub StopTimer()

        Try

            Timer1.Enabled = False

        Catch ex As Exception

            Call OutLog.OutLog(ex.Message)

        End Try

    End Sub

    'タイマーイベント
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Try

            'DBをオープンしていない場合、オープンを試みる
            If OpenFlg_DB = False Then

                Dim connStr As String = System.Configuration.ConfigurationManager.AppSettings("DBConnectionString").ToString()
                Dim errMsg As String = ""

                'データベース接続
                If DBAccess.SqlInitialize(connStr, errMsg) = False Then

                    '接続失敗
                    If System.Configuration.ConfigurationManager.AppSettings("GetCdLogKbn").ToString() = "1" Then
                        Call OutLog.OutLog(errMsg)
                    End If

                    'DB接続できなかった場合は以下の処理をしない
                    Exit Sub

                End If

                OpenFlg_DB = True

                'ログクラスの生成
                OutLog = New OutLog(Trim$(GetApValue("SMAREGI_PATH")) & _
                                    "\" & System.Configuration.ConfigurationManager.AppSettings("OutLogFile").ToString() & Now.ToString("yyyyMMdd") & ".log")
                'ログ出力
                Call OutLog.OutLog("データベース接続成功")

                '-----------------------------
                ' ローカルサーバのファイル削除
                '-----------------------------
                ' 7日前の日付取得
                Dim ymd As Decimal = CDec(System.DateTime.Today.AddDays(-7).ToString("yyyyMMdd"))

                ' 発券データのファイル削除
                For Each delFile In System.IO.Directory.GetFiles(Trim$(GetApValue("SMAREGI_PATH")), "*.log")
                    ' ローカルサーバのファイル作成日が7日以上経過していた場合
                    If ymd > CDec(System.IO.Path.GetFileName(delFile).Substring(7, 8)) Then
                        System.IO.File.Delete(delFile)
                    End If
                Next

            End If

            'DBがオープンしていた場合
            If OpenFlg_DB = True Then

                'タイマーストップ
                OpenFlg_Timer = False
                Invoke(New StartTimerDelegate(AddressOf StopTimer))

                'スマレジ 精算データ有無チェック
                Dim objDataTable As System.Data.DataTable = Nothing
                If CheckTPD052(objDataTable) > 0 Then
                    '対象となる精算データが存在する場合
                    For cnt = 0 To objDataTable.Rows.Count - 1
                        Call SendTransactionData(objDataTable.Rows(cnt).Item(0).ToString.Trim, objDataTable.Rows(cnt).Item(1).ToString.Trim, objDataTable.Rows(cnt).Item(2).ToString.Trim)
                    Next
                End If

                'タイマースタート
                Invoke(New StartTimerDelegate(AddressOf StartTimer))
                OpenFlg_Timer = True

            End If

            '-----------------------------------
            ' システム稼動チェック
            '-----------------------------------
            If getCLMODE() Then
                CtrlForm_Closing()
            End If

        Catch ex As Exception

            Call OutLog.OutLog(ex.Message)
            Call DBAccess.SqlFinalize()
            OpenFlg_DB = False
            If OpenFlg_Timer = False Then
                Invoke(New StartTimerDelegate(AddressOf StartTimer))
                OpenFlg_Timer = True
            End If

        End Try

    End Sub

    '終了処理
    Private Sub ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem.Click

        Me.Close()

    End Sub

    'フォームクロージング処理
    Private Sub CtrlForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try

            Dim errMsg As String = ""

            'DBがオープンしていた場合
            If OpenFlg_DB = True Then
                If DBAccess.SqlFinalize(errMsg) = False Then
                    If System.Configuration.ConfigurationManager.AppSettings("GetCdLogKbn").ToString() = "1" Then
                        Call OutLog.OutLog(errMsg)
                    End If
                End If
            End If

        Catch ex As Exception

            Call OutLog.OutLog(ex.Message)

        End Try

    End Sub

    ''' <summary>
    ''' フォーム終了イベント
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CtrlForm_Closing()
        Dim recNo As Integer = 0

        Try
            Call OutLog.OutLog("アプリケーション終了処理の開始")

            ' タイマー停止
            Timer1.Stop()
            Call OutLog.OutLog("タイマー停止")

        Catch ex As Exception

            Call OutLog.OutLog(ex.Message)

        Finally

            Call OutLog.OutLog("アプリケーション終了")
            Me.Close()

        End Try
    End Sub

    ''' <summary>
    ''' 精算データ有無チェック
    ''' </summary>
    ''' <param name="objDataTable"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CheckTPD052(ByRef objDataTable As System.Data.DataTable) As Long

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String = ""
        Dim errMsg As String = ""

        '------------------------------
        ' 初期値設定
        '------------------------------
        CheckTPD052 = 0

        '異常発生していないか確認
        Try

            strSQL = ""
            strSQL = strSQL & " SELECT MAX(TRANID) AS TRANID "
            strSQL = strSQL & "      , MAX(SEATID) AS SEATID "
            strSQL = strSQL & "      , MAX(TERMID) AS TERMID "
            strSQL = strSQL & "   FROM TPD052 "
            strSQL = strSQL & "  WHERE TRANKBN = '0' "
            strSQL = strSQL & "  GROUP BY TRANID "
            strSQL = strSQL & "         , SEATID "
            strSQL = strSQL & "         , TERMID "
            strSQL = strSQL & "  ORDER BY TRANID "
            strSQL = strSQL & "         , SEATID "
            strSQL = strSQL & "         , TERMID "

            If System.Configuration.ConfigurationManager.AppSettings("SQLLogKbn").ToString() = "1" Then
                Call OutLog.OutLog(strSQL)
            End If

            'データ抽出処理
            If DBAccess.SqlGetData(strSQL, objDataTable, errMsg) = False Then
                Call OutLog.OutLog(errMsg)
                Call DBAccess.SqlFinalize()
                OpenFlg_DB = False
                Exit Function
            Else
                '対象となる精算データ件数を返却する
                CheckTPD052 = objDataTable.Rows.Count
            End If

        Catch ex As Exception

            Call OutLog.OutLog(ex.Message)
            Call DBAccess.SqlFinalize()
            OpenFlg_DB = False

        End Try

    End Function

    ''' <summary>
    ''' 精算データ送信
    ''' </summary>
    ''' <param name="pTranId"></param>
    ''' <param name="pSeatId"></param>
    ''' <param name="pTermId"></param>
    ''' <remarks></remarks>
    Private Sub SendTransactionData(ByVal pTranId As String, ByVal pSeatId As String, ByVal pTermId As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String = ""
        Dim errMsg As String = ""

        '------------------------------
        ' 初期値設定
        '------------------------------
        _スマレジ連携履歴更新情報 = Nothing         '初期化
        _スマレジ連携履歴更新情報.Initialize()

        '--------------------------------------
        '  スマレジ取引情報を読込
        '--------------------------------------
        Dim smaregiStatusValue As String = ""
        Dim smaregiTransactionText As String = ""
        Dim smaregiTransaction As Json.transactionGetData_Transaction = Nothing

        '異常発生していないか確認
        Try

            Call UpdSmaregiTransactionData(smaregiTransactionText, smaregiTransaction, pTranId, pSeatId, pTermId)

            '成功判定
            If _スマレジ連携履歴更新情報.HTTPステータス <> HTTP_OK Then
                '失敗
                Exit Sub
            Else
                '成功時TPD052を更新
                Call UpdateTPD052(pTranId, pSeatId, pTermId)
            End If

        Catch ex As Exception

            Call OutLog.OutLog(ex.Message)
            Call DBAccess.SqlFinalize()
            OpenFlg_DB = False

        End Try

    End Sub

    ''' <summary>
    ''' スマレジ取引情報を更新する（取引(TransactionHead)、取引明細（TransactionDetail））
    ''' </summary>
    ''' <param name="smaregiTransactionText"></param>
    ''' <param name="smaregiTransaction"></param>
    ''' <param name="pTranId"></param>
    ''' <param name="pSeatId"></param>
    ''' <param name="pTermId"></param>
    ''' <remarks></remarks>
    Private Sub UpdSmaregiTransactionData(ByRef smaregiTransactionText As String, ByRef smaregiTransaction As Json.transactionGetData_Transaction, _
                                          ByVal pTranId As String, ByVal pSeatId As String, ByVal pTermId As String)

        Dim smaregiRef As Json.SmaregiRefParamsJson = Nothing
        Dim smaregiRefRowsHead As Json.SmaregiRefParamsJsonRowsHead = Nothing
        Dim smaregiRefRowsDetail As Json.SmaregiRefParamsJsonRowsDetail = Nothing
        Dim jq As New System.ServiceModel.Dispatcher.JsonQueryStringConverter

        '■ヘッダー取得
        Dim getHeader As String = ""
        Dim statusValueHeader As String = ""

        'パラメータ設定
        smaregiRef = New Json.SmaregiRefParamsJson
        smaregiRefRowsHead = New Json.SmaregiRefParamsJsonRowsHead
        smaregiRefRowsDetail = New Json.SmaregiRefParamsJsonRowsDetail

        '取引テーブル
        With smaregiRefRowsHead

            'テーブル名称
            .table_name = "TransactionHead"

        End With

        '取引明細テーブル
        With smaregiRefRowsDetail

            'テーブル名称
            .table_name = "TransactionDetail"

        End With

        '全体
        With smaregiRef

            '処理区分
            Dim proc_info_proc_division As New Json.proc_info_proc_division
            proc_info_proc_division.proc_division = "U"
            .proc_info.Add(proc_info_proc_division)

        End With

        getHeader = UpdSmaregiInfo(smaregiRef, smaregiRefRowsHead, smaregiRefRowsDetail, statusValueHeader, pTranId, pSeatId, pTermId)

        '成功判定
        If statusValueHeader <> HTTP_OK Then
            _スマレジ連携履歴更新情報.HTTPステータス = statusValueHeader
            Exit Sub
        End If

        '返却用データに設定(文字列・JSON分解値)
        getHeader = getHeader.Replace("[", "")
        getHeader = getHeader.Replace("]", "")
        getHeader = getHeader.Replace("""result"":", """result"":[")
        getHeader = getHeader.Replace("}}", "}]}")
        smaregiTransactionText = getHeader
        smaregiTransaction = DirectCast(jq.ConvertStringToValue(getHeader, _
                                                                GetType(Json.transactionGetData_Transaction)),  _
                                                                Json.transactionGetData_Transaction)

        'ログ出力
        Call OutLog.OutLog("*********************************************")
        Call OutLog.OutLog("精算データ送信：成功(" & HTTP_OK & ")")
        Call OutLog.OutLog("　取引情報更新処理")
        Call OutLog.OutLog("　　取引テーブル　　：" & smaregiTransaction.result(0).TransactionHead & "件（取引ID：" & smaregiTransaction.result(0).TransactionHeadIds & "）")
        Call OutLog.OutLog("　　取引明細テーブル：" & smaregiTransaction.result(0).TransactionDetail & "件")
        Call OutLog.OutLog("　TPD052更新対象値")
        Call OutLog.OutLog("　　取引ID：" & pTranId & "、座席番号：" & pSeatId & "、IPアドレス：" & pTermId)
        Call OutLog.OutLog("*********************************************")

        '正常に設定
        _スマレジ連携履歴更新情報.HTTPステータス = HTTP_OK

    End Sub

    ''' <summary>
    ''' スマレジの更新結果情報を取得し、文字列の状態で返却する
    ''' </summary>
    ''' <param name="smaregiRef"></param>
    ''' <param name="smaregiRefRowsHead"></param>
    ''' <param name="smaregiRefRowsDetail"></param>
    ''' <param name="statusValue"></param>
    ''' <param name="pTranId"></param>
    ''' <param name="pSeatId"></param>
    ''' <param name="pTermId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function UpdSmaregiInfo(ByVal smaregiRef As Json.SmaregiRefParamsJson, ByVal smaregiRefRowsHead As Json.SmaregiRefParamsJsonRowsHead, _
                                    ByVal smaregiRefRowsDetail As Json.SmaregiRefParamsJsonRowsDetail, ByRef statusValue As String, _
                                    ByVal pTranId As String, ByVal pSeatId As String, ByVal pTermId As String) As String

        Dim result As String = ""
        Dim dtsData As New DataSet()
        Dim dtsRow As DataRow = Nothing
        Dim lngCnt As Long = 0
        Dim RowsStr As String = ""
        Dim param As String = ""
        Dim paramHead As String = ""
        Dim paramDetail As String = ""
        Dim dataParam As String = ""
        Dim personNumber As String = ""
        Dim SalesTax As String = Trim$(GetApValue("SALES_TAX_SWITCHING"))
        Dim TaxExclude As Decimal = 0

        Try
            'パラメータをJSON形式に変換
            Dim jq As New System.ServiceModel.Dispatcher.JsonQueryStringConverter

            '客数取得
            Call GetGuestNumbers(pTranId, pSeatId, pTermId, personNumber)

            '合計金額取得
            Dim totalPrice As String = GetTotal(pTranId, pSeatId, pTermId, SalesTax)

            '消費税取得
            If SalesTax = 0 Then
                TaxExclude = 0
            ElseIf SalesTax = 1 Then
                TaxExclude = GetTaxExclude(pTranId, pSeatId, pTermId)
            End If

            '------------------------------
            '取引データ(行)
            '------------------------------
            With smaregiRefRowsHead

                '取引区分（固定値 10:取置き）
                Dim rows_transactionHeadDivision As New Json.rows_transactionHeadDivision
                rows_transactionHeadDivision.transactionHeadDivision = "10"
                .rows.Add(rows_transactionHeadDivision)

                '取消区分（固定値 0：通常）
                Dim rows_cancelDivision As New Json.rows_cancelDivision
                rows_cancelDivision.cancelDivision = "0"
                .rows.Add(rows_cancelDivision)

                '小計
                Dim rows_subtotal As New Json.rows_subtotal
                rows_subtotal.subtotal = totalPrice
                .rows.Add(rows_subtotal)

                '合計
                Dim rows_total As New Json.rows_total
                rows_total.total = totalPrice + TaxExclude
                .rows.Add(rows_total)

                '外税額（固定値 0）
                Dim rows_taxExclude As New Json.rows_taxExclude
                rows_taxExclude.taxExclude = TaxExclude
                .rows.Add(rows_taxExclude)

                '内税額（固定値 0）
                Dim rows_taxinclude As New Json.rows_taxInclude
                rows_taxinclude.taxInclude = "0"
                .rows.Add(rows_taxinclude)

                '店舗ID
                Dim rows_storeId As New Json.rows_storeId
                rows_storeId.storeId = Trim$(GetApValue("SMAREGI_STOREID"))
                .rows.Add(rows_storeId)

                '端末ID
                Dim rows_terminalId As New Json.rows_terminalId
                rows_terminalId.terminalId = Trim$(GetApValue("SMAREGI_TERMID"))
                .rows.Add(rows_terminalId)

                '端末取引ID
                Dim rows_terminalTranId As New Json.rows_terminalTranId
                rows_terminalTranId.terminalTranId = pTranId
                .rows.Add(rows_terminalTranId)

                '端末取引日時
                Dim rows_terminalTranDateTime As New Json.rows_terminalTranDateTime
                rows_terminalTranDateTime.terminalTranDateTime = Now.ToString("yyyy-MM-dd HH:mm:ss")
                .rows.Add(rows_terminalTranDateTime)

                'メモ
                Dim rows_memo As New Json.rows_memo
                rows_memo.memo = pSeatId
                .rows.Add(rows_memo)

                '客数
                Dim rows_guestNumbers As New Json.rows_guestNumbers
                rows_guestNumbers.guestNumbers = personNumber
                .rows.Add(rows_guestNumbers)

            End With

            'Rowsを一度切り離して、文字列化する
            For i As Integer = 0 To smaregiRefRowsHead.rows.Count - 1
                If i > 0 Then
                    RowsStr &= ","
                End If

                '型ごとの分岐
                If TypeOf smaregiRefRowsHead.rows(i) Is Json.rows_transactionHeadDivision Then
                    RowsStr &= jq.ConvertValueToString(smaregiRefRowsHead.rows(i), GetType(Json.rows_transactionHeadDivision))

                ElseIf TypeOf smaregiRefRowsHead.rows(i) Is Json.rows_cancelDivision Then
                    RowsStr &= jq.ConvertValueToString(smaregiRefRowsHead.rows(i), GetType(Json.rows_cancelDivision))

                ElseIf TypeOf smaregiRefRowsHead.rows(i) Is Json.rows_subtotal Then
                    RowsStr &= jq.ConvertValueToString(smaregiRefRowsHead.rows(i), GetType(Json.rows_subtotal))

                ElseIf TypeOf smaregiRefRowsHead.rows(i) Is Json.rows_total Then
                    RowsStr &= jq.ConvertValueToString(smaregiRefRowsHead.rows(i), GetType(Json.rows_total))

                ElseIf TypeOf smaregiRefRowsHead.rows(i) Is Json.rows_taxExclude Then
                    RowsStr &= jq.ConvertValueToString(smaregiRefRowsHead.rows(i), GetType(Json.rows_taxExclude))

                ElseIf TypeOf smaregiRefRowsHead.rows(i) Is Json.rows_taxInclude Then
                    RowsStr &= jq.ConvertValueToString(smaregiRefRowsHead.rows(i), GetType(Json.rows_taxInclude))

                ElseIf TypeOf smaregiRefRowsHead.rows(i) Is Json.rows_storeId Then
                    RowsStr &= jq.ConvertValueToString(smaregiRefRowsHead.rows(i), GetType(Json.rows_storeId))

                ElseIf TypeOf smaregiRefRowsHead.rows(i) Is Json.rows_terminalId Then
                    RowsStr &= jq.ConvertValueToString(smaregiRefRowsHead.rows(i), GetType(Json.rows_terminalId))

                ElseIf TypeOf smaregiRefRowsHead.rows(i) Is Json.rows_terminalTranId Then
                    RowsStr &= jq.ConvertValueToString(smaregiRefRowsHead.rows(i), GetType(Json.rows_terminalTranId))

                ElseIf TypeOf smaregiRefRowsHead.rows(i) Is Json.rows_terminalTranDateTime Then
                    RowsStr &= jq.ConvertValueToString(smaregiRefRowsHead.rows(i), GetType(Json.rows_terminalTranDateTime))

                ElseIf TypeOf smaregiRefRowsHead.rows(i) Is Json.rows_memo Then
                    RowsStr &= jq.ConvertValueToString(smaregiRefRowsHead.rows(i), GetType(Json.rows_memo))

                ElseIf TypeOf smaregiRefRowsHead.rows(i) Is Json.rows_guestNumbers Then
                    RowsStr &= jq.ConvertValueToString(smaregiRefRowsHead.rows(i), GetType(Json.rows_guestNumbers))
                End If
            Next

            '特定文字を取り除く
            RowsStr = RowsStr.Replace("{", "")
            RowsStr = RowsStr.Replace("}", "")

            RowsStr = "{" & RowsStr & "}"

            dataParam &= RowsStr
            RowsStr = Nothing

            'Rowsをクリア
            smaregiRefRowsHead.rows.Clear()

            '文字列変換して、Rowsを設定し直す
            paramHead = jq.ConvertValueToString(smaregiRefRowsHead, GetType(Json.SmaregiRefParamsJsonRowsHead))
            paramHead = paramHead.Replace("""rows"":[]", """rows"":[" & dataParam & "]")
            dataParam = ""

            '精算データ取得
            Dim objDataTable As System.Data.DataTable = Nothing
            Call GetSeisanData(pTranId, pSeatId, pTermId, objDataTable)

            '------------------------------
            '取引明細データ(行)
            '------------------------------
            '取引明細区分
            Dim rows_transactionDetailDivision As New Json.rows_transactionDetailDivision
            '商品ID
            Dim rows_productId As New Json.rows_productId
            '税区分
            Dim rows_taxDivision As New Json.rows_taxDivision
            '販売単価
            Dim rows_salesPrice As New Json.rows_salesPrice
            '数量
            Dim rows_quantity As New Json.rows_quantity
            '軽減税率ID
            Dim rows_reduceTaxId As New Json.rows_reduceTaxId

            lngCnt = 0
            While lngCnt < objDataTable.Rows.Count

                ''Rowsをクリア
                'smaregiRefRowsDetail.rows.Clear()

                With smaregiRefRowsDetail

                    'データ部(行 - 取引明細区分)（固定値 1:通常）
                    rows_transactionDetailDivision.transactionDetailDivision = "1"
                    .rows.Add(rows_transactionDetailDivision)

                    'データ部(行 - 商品ID)
                    rows_productId.productId = CLng(objDataTable.Rows(lngCnt).Item(4)).ToString.Trim
                    .rows.Add(rows_productId)

                    'データ部(行 - 税区分)
                    If SalesTax = "1" Then
                        '税抜（外税）の場合
                        rows_taxDivision.taxDivision = "1"
                    ElseIf SalesTax = "0" Then
                        '税込（内税）の場合
                        rows_taxDivision.taxDivision = "0"
                    End If
                    .rows.Add(rows_taxDivision)

                    'データ部(行 - 販売単価)
                    If SalesTax = "1" Then
                        '税抜（外税）の場合
                        rows_salesPrice.salesPrice = objDataTable.Rows(lngCnt).Item(6).ToString.Trim
                    ElseIf SalesTax = "0" Then
                        '税込（内税）の場合
                        rows_salesPrice.salesPrice = objDataTable.Rows(lngCnt).Item(8).ToString.Trim
                    End If
                    .rows.Add(rows_salesPrice)

                    'データ部(行 - 数量)
                    rows_quantity.quantity = objDataTable.Rows(lngCnt).Item(7).ToString.Trim
                    .rows.Add(rows_quantity)

                    'データ部(行 - 軽減税率ID)
                    If Trim$(GetApValue("TEC_REDUCED_TAX_RATE")) = "1" Then
                        If objDataTable.Rows(lngCnt).Item(10).ToString.Trim = "1" Then
                            rows_reduceTaxId.reduceTaxId = "10000001"
                        Else
                            rows_reduceTaxId.reduceTaxId = ""
                        End If
                    Else
                        rows_reduceTaxId.reduceTaxId = ""
                    End If
                    .rows.Add(rows_reduceTaxId)

                End With

                'Rowsを一度切り離して、文字列化する
                For i As Integer = 0 To smaregiRefRowsDetail.rows.Count - 1
                    If i > 0 Then
                        RowsStr &= ","
                    End If

                    '型ごとの分岐
                    If TypeOf smaregiRefRowsDetail.rows(i) Is Json.rows_transactionDetailDivision Then
                        RowsStr &= jq.ConvertValueToString(smaregiRefRowsDetail.rows(i), GetType(Json.rows_transactionDetailDivision))

                    ElseIf TypeOf smaregiRefRowsDetail.rows(i) Is Json.rows_productId Then
                        RowsStr &= jq.ConvertValueToString(smaregiRefRowsDetail.rows(i), GetType(Json.rows_productId))

                    ElseIf TypeOf smaregiRefRowsDetail.rows(i) Is Json.rows_taxDivision Then
                        RowsStr &= jq.ConvertValueToString(smaregiRefRowsDetail.rows(i), GetType(Json.rows_taxDivision))

                    ElseIf TypeOf smaregiRefRowsDetail.rows(i) Is Json.rows_salesPrice Then
                        RowsStr &= jq.ConvertValueToString(smaregiRefRowsDetail.rows(i), GetType(Json.rows_salesPrice))

                    ElseIf TypeOf smaregiRefRowsDetail.rows(i) Is Json.rows_quantity Then
                        RowsStr &= jq.ConvertValueToString(smaregiRefRowsDetail.rows(i), GetType(Json.rows_quantity))

                    ElseIf TypeOf smaregiRefRowsDetail.rows(i) Is Json.rows_reduceTaxId Then
                        RowsStr &= jq.ConvertValueToString(smaregiRefRowsDetail.rows(i), GetType(Json.rows_reduceTaxId))
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

                'Rowsをクリア
                smaregiRefRowsDetail.rows.Clear()

                lngCnt = lngCnt + 1
            End While

            '文字列変換して、Rowsを設定し直す
            paramDetail = jq.ConvertValueToString(smaregiRefRowsDetail, GetType(Json.SmaregiRefParamsJsonRowsDetail))
            paramDetail = paramDetail.Replace("""rows"":[]", """rows"":[" & dataParam & "]")

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
            param2 = param2.Replace("""data"":[]", """data"":[" & paramHead + "," + paramDetail & "]")
            param2 = param2.Replace("""proc_info"":[]", """proc_info"":" & ProcInfoStr)

            '------------------------------
            ' リクエスト設定
            '------------------------------
            Dim url As String = Trim$(GetApValue("SMAREGI_URL"))
            Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(url)

            With request
                ' リクエストヘッダ設定
                With .Headers
                    .Add("X_contract_id", Trim$(GetApValue("SMAREGI_CONTRACT")))
                    .Add("X_access_token", Trim$(GetApValue("SMAREGI_TOKEN")))
                End With
                .Method = "POST"
                .ContentType = "application/x-www-form-urlencoded;charset=UTF-8"
            End With

            Dim post As String = String.Empty
            post &= "proc_name=transaction_upd&params=" & param2

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

                        'ログ出力
                        Call OutLog.OutLog("*********************************************")
                        Call OutLog.OutLog("精算データ送信：失敗")
                        Call OutLog.OutLog("　取引情報更新処理")
                        Call OutLog.OutLog("　　取込エラーコード：" & errInfo.error_code)
                        Call OutLog.OutLog("　　取込エラー内容　：" & errInfo.errorM)
                        Call OutLog.OutLog("　　取込エラー詳細　：" & errInfo.error_description)
                        Call OutLog.OutLog("　TPD052更新対象値")
                        Call OutLog.OutLog("　　取引ID：" & pTranId & "、座席番号：" & pSeatId & "、IPアドレス：" & pTermId)
                        Call OutLog.OutLog("*********************************************")
                    End If

                Catch ex2 As Exception
                    'json変換失敗した場合、スマレジからのステータスは取得できなかった、として、接続エラーとする
                    statusValue = HTTP_想定外エラー
                End Try

            Else
                statusValue = HTTP_想定外エラー
            End If

        Catch ex As Exception

            statusValue = HTTP_想定外エラー

            Call OutLog.OutLog(ex.Message)
            Call DBAccess.SqlFinalize()
            OpenFlg_DB = False

        End Try

        Return result

    End Function

    ''' <summary>
    ''' 客数取得
    ''' </summary>
    ''' <param name="pTranId"></param>
    ''' <param name="pSEATID"></param>
    ''' <param name="pTERMID"></param>
    ''' <param name="pPERSONNUMBER"></param>
    ''' <remarks></remarks>
    Private Sub GetGuestNumbers(ByVal pTranId As String, ByVal pSEATID As String, ByVal pTERMID As String, ByRef pPERSONNUMBER As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String = ""
        Dim objDataTable As System.Data.DataTable = Nothing
        Dim errMsg As String = ""

        '異常発生していないか確認
        Try

            strSQL = ""
            strSQL = strSQL & " SELECT TOP 1 TRANID "
            strSQL = strSQL & "      , SEATID "
            strSQL = strSQL & "      , TERMID "
            strSQL = strSQL & "      , MAX(PERSONNUMBER) AS PERSONNUMBER "
            strSQL = strSQL & "   FROM TPD052 "
            strSQL = strSQL & "  WHERE TRANID  = '" & pTranId & "' "
            strSQL = strSQL & "    AND TRANKBN = '0' "
            strSQL = strSQL & "    AND SEATID  = '" & pSEATID.PadLeft(5) & "' "
            strSQL = strSQL & "    AND TERMID  = '" & pTERMID & "' "
            strSQL = strSQL & "  GROUP BY TRANID "
            strSQL = strSQL & "         , SEATID "
            strSQL = strSQL & "         , TERMID "
            strSQL = strSQL & "  ORDER BY TRANID "
            strSQL = strSQL & "         , SEATID "
            strSQL = strSQL & "         , TERMID "

            If System.Configuration.ConfigurationManager.AppSettings("SQLLogKbn").ToString() = "1" Then
                Call OutLog.OutLog(strSQL)
            End If

            'データ抽出処理
            If DBAccess.SqlGetData(strSQL, objDataTable, errMsg) = False Then
                Call OutLog.OutLog(errMsg)
                Call DBAccess.SqlFinalize()
                OpenFlg_DB = False
                Exit Sub
            Else
                '対象となるデータを返却値に設定する
                If objDataTable.Rows.Count > 0 Then
                    pPERSONNUMBER = objDataTable.Rows(0).Item(3).ToString.Trim
                End If
            End If

        Catch ex As Exception

            Call OutLog.OutLog(ex.Message)
            Call DBAccess.SqlFinalize()
            OpenFlg_DB = False

        End Try

    End Sub

    ''' <summary>
    ''' 合計金額取得
    ''' </summary>
    ''' <param name="pTranId"></param>
    ''' <param name="pSEATID"></param>
    ''' <param name="pTERMID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetTotal(ByVal pTranId As String, ByVal pSEATID As String, ByVal pTERMID As String, ByVal pSALESTAX As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String = ""
        Dim objDataTable As System.Data.DataTable = Nothing
        Dim errMsg As String = ""
        Dim totalAmount As Long

        '------------------------------
        ' 初期値設定
        '------------------------------
        GetTotal = 0
        totalAmount = 0

        '異常発生していないか確認
        Try

            strSQL = ""
            strSQL = strSQL & " SELECT TPM010.PRICE "
            If Trim$(GetApValue("TEC_REDUCED_TAX_RATE")) = "1" Then
                strSQL = strSQL & "  , CASE TPM600.TAXTYPE "
                strSQL = strSQL & "       WHEN '1' THEN TPM600.PRICE_RED "
                strSQL = strSQL & "       ELSE TPM260.TAXPRICE "
                strSQL = strSQL & "    END TAXPRICE "
            Else
                strSQL = strSQL & "  , TPM260.TAXPRICE "
            End If
            strSQL = strSQL & "      , TPD052.QUANTITY "
            strSQL = strSQL & "      , TPM600.TAXTYPE "
            strSQL = strSQL & "      , TPM610.TAXRATE "
            strSQL = strSQL & "      , TPM610.ROUNDING "
            strSQL = strSQL & "   FROM TPD052 "
            strSQL = strSQL & "      , TPM010 "
            strSQL = strSQL & "      , TPM260 "
            strSQL = strSQL & "      , TPM600 "
            strSQL = strSQL & "      , TPM610 "
            strSQL = strSQL & "  WHERE TPM010.GOODSCD = TPD052.GOODSCD "
            strSQL = strSQL & "    AND TPM010.GOODSCD = TPM260.GOODSCD "
            strSQL = strSQL & "    AND TPM010.GOODSCD = TPM600.GOODSCD "
            strSQL = strSQL & "    AND TPM600.TAXTYPE = TPM610.TAXTYPE "
            strSQL = strSQL & "    AND TPD052.TRANID  = '" & pTranId & "' "
            strSQL = strSQL & "    AND TPD052.TRANKBN = '0' "
            strSQL = strSQL & "    AND TPD052.SEATID  = '" & pSEATID.PadLeft(5) & "' "
            strSQL = strSQL & "    AND TPD052.TERMID  = '" & pTERMID & "' "
            strSQL = strSQL & "    AND TPD052.GOODSCD < '9901' "

            If System.Configuration.ConfigurationManager.AppSettings("SQLLogKbn").ToString() = "1" Then
                Call OutLog.OutLog(strSQL)
            End If

            'データ抽出処理
            If DBAccess.SqlGetData(strSQL, objDataTable, errMsg) = False Then
                Call OutLog.OutLog(errMsg)
                Call DBAccess.SqlFinalize()
                OpenFlg_DB = False
                Exit Function
            Else
                '合計金額を返却値に設定する
                For cnt = 0 To objDataTable.Rows.Count - 1
                    If pSALESTAX = "0" Then ' 内税
                        totalAmount += CLng(objDataTable.Rows(cnt).Item(1)) * CLng(objDataTable.Rows(cnt).Item(2))

                    ElseIf pSALESTAX = "1" Then ' 外税
                        totalAmount += CLng(objDataTable.Rows(cnt).Item(0)) * CLng(objDataTable.Rows(cnt).Item(2))

                    End If
                Next

                GetTotal = totalAmount.ToString

            End If

        Catch ex As Exception

            Call OutLog.OutLog(ex.Message)
            Call DBAccess.SqlFinalize()
            OpenFlg_DB = False

        End Try

    End Function

    ''' <summary>
    ''' 消費税取得
    ''' </summary>
    ''' <param name="pTranId"></param>
    ''' <param name="pSEATID"></param>
    ''' <param name="pTERMID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetTaxExclude(ByVal pTranId As String, ByVal pSEATID As String, ByVal pTERMID As String) As Decimal

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String = ""
        Dim objDataTable As System.Data.DataTable = Nothing
        Dim errMsg As String = ""
        Dim totalAmount As Long

        '------------------------------
        ' 初期値設定
        '------------------------------
        GetTaxExclude = 0
        totalAmount = 0

        '異常発生していないか確認
        Try

            strSQL = ""
            strSQL = strSQL & " SELECT TPM600.TAXTYPE "
            strSQL = strSQL & "      , MAX(TPM610.TAXRATE) "
            strSQL = strSQL & "      , SUM(TPM010.PRICE * TPD052.QUANTITY) "
            strSQL = strSQL & "      , MAX(TPM610.ROUNDING) "
            strSQL = strSQL & "   FROM TPD052 "
            strSQL = strSQL & "      , TPM010 "
            strSQL = strSQL & "      , TPM600 "
            strSQL = strSQL & "      , TPM610 "
            strSQL = strSQL & "  WHERE TPM010.GOODSCD = TPD052.GOODSCD "
            strSQL = strSQL & "    AND TPM010.GOODSCD = TPM600.GOODSCD "
            strSQL = strSQL & "    AND TPM600.TAXTYPE = TPM610.TAXTYPE "
            strSQL = strSQL & "    AND TPD052.TRANID  = '" & pTranId & "' "
            strSQL = strSQL & "    AND TPD052.TRANKBN = '0' "
            strSQL = strSQL & "    AND TPD052.SEATID  = '" & pSEATID.PadLeft(5) & "' "
            strSQL = strSQL & "    AND TPD052.TERMID  = '" & pTERMID & "' "
            strSQL = strSQL & "    AND TPD052.GOODSCD < '9901' "
            strSQL = strSQL & "  GROUP BY TPM600.TAXTYPE"

            If System.Configuration.ConfigurationManager.AppSettings("SQLLogKbn").ToString() = "1" Then
                Call OutLog.OutLog(strSQL)
            End If

            'データ抽出処理
            If DBAccess.SqlGetData(strSQL, objDataTable, errMsg) = False Then
                Call OutLog.OutLog(errMsg)
                Call DBAccess.SqlFinalize()
                OpenFlg_DB = False
                Exit Function
            Else
                '消費税額を返却値に設定する
                For cnt = 0 To objDataTable.Rows.Count - 1
                    If objDataTable.Rows(cnt).Item(3) = "1" Then ' 切り上げ
                        GetTaxExclude += Math.Ceiling(CLng(objDataTable.Rows(cnt).Item(2)) * CLng(objDataTable.Rows(cnt).Item(1)) / 100)
                    ElseIf objDataTable.Rows(cnt).Item(3) = "2" Then '四捨五入 
                        GetTaxExclude += Math.Round(CLng(objDataTable.Rows(cnt).Item(2)) * CLng(objDataTable.Rows(cnt).Item(1)) / 100)
                    Else
                        GetTaxExclude += Math.Floor((objDataTable.Rows(cnt).Item(2)) * CLng(objDataTable.Rows(cnt).Item(1)) / 100)
                    End If
                Next

            End If

        Catch ex As Exception

            Call OutLog.OutLog(ex.Message)
            Call DBAccess.SqlFinalize()
            OpenFlg_DB = False

        End Try

    End Function

    ''' <summary>
    ''' 精算データ取得
    ''' </summary>
    ''' <param name="pTranId"></param>
    ''' <param name="pSEATID"></param>
    ''' <param name="pTERMID"></param>
    ''' <param name="objDataTable"></param>
    ''' <remarks></remarks>
    Private Sub GetSeisanData(ByVal pTranId As String, ByVal pSEATID As String, ByVal pTERMID As String, _
                              ByRef objDataTable As System.Data.DataTable)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String = ""
        Dim errMsg As String = ""

        '異常発生していないか確認
        Try

            strSQL = ""
            strSQL = strSQL & " SELECT * "
            strSQL = strSQL & "  FROM ( "
            strSQL = strSQL & "        SELECT MAX(TPD052.TRANID) AS TRANID "
            strSQL = strSQL & "             , MAX(TPD052.TRANKBN) AS TRANKBN "
            strSQL = strSQL & "             , MAX(TPD052.SEATID) AS SEATID "
            strSQL = strSQL & "             , MAX(TPD052.TERMID) AS TERMID "
            strSQL = strSQL & "             , MAX(TPD052.GOODSCD) AS GOODSCD "
            strSQL = strSQL & "             , MAX(LTRIM(RTRIM(TPM010.GOODSNMJ)) + LTRIM(RTRIM(TPM010.GOODSNMJ2))) AS GOODSNM "
            strSQL = strSQL & "             , TPM010.PRICE"
            strSQL = strSQL & "             , SUM(TPD052.QUANTITY) AS QUANTITY "
            If Trim$(GetApValue("TEC_REDUCED_TAX_RATE")) = "1" Then
                strSQL = strSQL & "         , CASE MAX(TPM600.TAXTYPE) "
                strSQL = strSQL & "               WHEN '1' THEN MAX(TPM600.PRICE_RED) "
                strSQL = strSQL & "               ELSE MAX(TPM260.TAXPRICE) "
                strSQL = strSQL & "           END TAXPRICE"
            Else
                strSQL = strSQL & "         , MAX(TPM260.TAXPRICE) TAXPRICE "
            End If
            strSQL = strSQL & "             , MAX(TPD052.TAXKIND) AS TAXKIND "
            strSQL = strSQL & "             , MAX(TPM600.TAXTYPE) AS TAXTYPE "
            strSQL = strSQL & "          FROM TPD052 "
            strSQL = strSQL & "             , TPM010 "
            strSQL = strSQL & "             , TPM600 "
            strSQL = strSQL & "             , TPM260 "
            strSQL = strSQL & "         WHERE TPM010.GOODSCD = TPD052.GOODSCD "
            strSQL = strSQL & "           AND TPM010.GOODSCD = TPM600.GOODSCD "
            strSQL = strSQL & "           AND TPM010.GOODSCD = TPM260.GOODSCD "
            strSQL = strSQL & "           AND TPD052.TRANID  = '" & pTranId & "' "
            strSQL = strSQL & "           AND TPD052.TRANKBN = '0' "
            strSQL = strSQL & "           AND TPD052.SEATID  = '" & pSEATID.PadLeft(5) & "' "
            strSQL = strSQL & "           AND TPD052.TERMID  = '" & pTERMID & "' "
            strSQL = strSQL & "           AND TPD052.GOODSCD < '9901' "
            strSQL = strSQL & "         GROUP BY TPD052.TRANID "
            strSQL = strSQL & "                , TPD052.TRANKBN "
            strSQL = strSQL & "                , TPD052.SEATID "
            strSQL = strSQL & "                , TPD052.TERMID "
            strSQL = strSQL & "                , TPD052.GOODSCD "
            strSQL = strSQL & "                , TPM010.GOODSNMJ "
            strSQL = strSQL & "                , TPM010.GOODSNMJ2 "
            strSQL = strSQL & "                , TPM010.PRICE "
            strSQL = strSQL & "       ) AS TBL "
            strSQL = strSQL & " WHERE TBL.QUANTITY <> 0 "
            strSQL = strSQL & " ORDER BY TBL.GOODSCD "

            If System.Configuration.ConfigurationManager.AppSettings("SQLLogKbn").ToString() = "1" Then
                Call OutLog.OutLog(strSQL)
            End If

            'データ抽出処理
            If DBAccess.SqlGetData(strSQL, objDataTable, errMsg) = False Then
                Call OutLog.OutLog(errMsg)
                Call DBAccess.SqlFinalize()
                OpenFlg_DB = False
                Exit Sub
            End If

        Catch ex As Exception

            Call OutLog.OutLog(ex.Message)
            Call DBAccess.SqlFinalize()
            OpenFlg_DB = False

        End Try

    End Sub

    ''' <summary>
    ''' 汎用マスタ値取得(TPM090)
    ''' </summary>
    ''' <param name="pApKey"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetApValue(ByVal pApKey As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String = ""
        Dim objDataTable As System.Data.DataTable = Nothing
        Dim errMsg As String = ""

        '------------------------------
        ' 初期値設定
        '------------------------------
        GetApValue = 0

        '異常発生していないか確認
        Try

            strSQL = ""
            strSQL = strSQL & " SELECT APVALUE "
            strSQL = strSQL & "   FROM TPM090 "
            strSQL = strSQL & "  WHERE APKEY = '" & pApKey & "' "

            If System.Configuration.ConfigurationManager.AppSettings("SQLLogKbn").ToString() = "1" Then
                Call OutLog.OutLog(strSQL)
            End If

            'データ抽出処理
            If DBAccess.SqlGetData(strSQL, objDataTable, errMsg) = False Then
                Call OutLog.OutLog(errMsg)
                Call DBAccess.SqlFinalize()
                OpenFlg_DB = False
                Exit Function
            Else
                '対象データ値を返却値に設定する
                If objDataTable.Rows.Count > 0 Then
                    GetApValue = objDataTable.Rows(0).Item(0).ToString.Trim
                End If
            End If

        Catch ex As Exception

            Call OutLog.OutLog(ex.Message)
            Call DBAccess.SqlFinalize()
            OpenFlg_DB = False

        End Try

    End Function

    ''' <summary>
    ''' 送信済精算データ消去
    ''' </summary>
    ''' <param name="pTranId"></param>
    ''' <param name="pSEATID"></param>
    ''' <param name="pTERMID"></param>
    ''' <remarks></remarks>
    Private Sub UpdateTPD052(ByVal pTranId As String, ByVal pSEATID As String, ByVal pTERMID As String)

        Dim strSQL As String = ""
        Dim objDataTable As System.Data.DataTable = Nothing
        Dim cnt As Integer = 0

        Dim errMsg As String = ""
        Dim strWork As String = ""

        Try

            'トランザクションの開始
            If DBAccess.SqlBeginTrans(errMsg) = False Then
                Call OutLog.OutLog(errMsg)
                Call DBAccess.SqlFinalize()
                OpenFlg_DB = False
                Exit Sub
            End If

            strSQL = ""
            strSQL = strSQL & " UPDATE TPD052 "
            strSQL = strSQL & "    SET TRANKBN = '1' "
            strSQL = strSQL & "      , UPDID   = 'SMAREGI'  "
            strSQL = strSQL & "      , UPDYMD  = GETDATE() "
            strSQL = strSQL & " WHERE TRANID   = '" & pTranId & "' "
            strSQL = strSQL & "   AND TRANKBN  = '0' "
            strSQL = strSQL & "   AND SEATID   = '" & pSEATID.PadLeft(5) & "' "
            strSQL = strSQL & "   AND TERMID   = '" & pTERMID & "' "

            If System.Configuration.ConfigurationManager.AppSettings("SQLLogKbn").ToString() = "1" Then
                Call OutLog.OutLog(strSQL)
            End If

            If DBAccess.SqlUpdData(strSQL, errMsg) = False Then
                Call OutLog.OutLog(errMsg)
                Call DBAccess.SqlRollbackTrans()
                Call DBAccess.SqlFinalize()
                OpenFlg_DB = False
                Exit Sub
            End If

            'コミット
            If DBAccess.SqlCommitTrans(errMsg) = False Then
                Call OutLog.OutLog(errMsg)
                Call DBAccess.SqlFinalize()
                OpenFlg_DB = False
                Exit Sub
            End If

        Catch ex As Exception

            Call OutLog.OutLog(ex.Message)
            Call DBAccess.SqlFinalize()
            OpenFlg_DB = False

        End Try

    End Sub

    ''' <summary>
    ''' システム稼働状況の確認
    ''' </summary>
    ''' <returns>True:システム停止中 False:システム起動中</returns>
    ''' <remarks></remarks>
    Private Function GetCLMODE() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String = ""
        Dim objDataTable As System.Data.DataTable = Nothing
        Dim errMsg As String = ""

        '------------------------------
        ' 初期値設定
        '------------------------------
        GetCLMODE = False

        '異常発生していないか確認
        Try

            strSQL = ""
            strSQL = strSQL & " SELECT CLMODE"
            strSQL = strSQL & "   FROM TPM040"

            If System.Configuration.ConfigurationManager.AppSettings("SQLLogKbn").ToString() = "1" Then
                Call OutLog.OutLog(strSQL)
            End If

            'データ抽出処理
            If DBAccess.SqlGetData(strSQL, objDataTable, errMsg) = False Then
                Call OutLog.OutLog(errMsg)
                Call DBAccess.SqlFinalize()
                OpenFlg_DB = False
                Exit Function
            Else
                '該当レコードあり
                If objDataTable.Rows.Count > 0 Then
                    If objDataTable.Rows(0).Item(0).ToString.Trim() = "0" Then
                        'システム起動中
                        GetCLMODE = False
                    Else
                        'システム停止中
                        GetCLMODE = True
                    End If
                End If
            End If

        Catch ex As Exception

            Call OutLog.OutLog(ex.Message)
            Call DBAccess.SqlFinalize()
            OpenFlg_DB = False

        End Try

    End Function

End Class