Public Class DataBaseAccess

    '-------------------------------------------------------------------------------
    ' クラス内変数定義
    '-------------------------------------------------------------------------------
    Private L_objConnect As SqlClient.SqlConnection  'データベースコネクション
    Private L_objTrans As SqlClient.SqlTransaction   'データベーストランザクション

    '-------------------------------------------------------------------------------
    ' クラス内定数定義
    '-------------------------------------------------------------------------------

    '-------------------------------------------------------------------------------
    ' 外部変数定義
    '-------------------------------------------------------------------------------

    '-------------------------------------------------------------------------------
    ' 外部定数定義
    '-------------------------------------------------------------------------------

    '-------------------------------------------------------------------------------
    ' 構造体定義
    '-------------------------------------------------------------------------------

    '-------------------------------------------------------------------------------
    ' 列挙体定義
    '-------------------------------------------------------------------------------

    ' --------------------------------------------------------------------------------
    ' 　機　　能：【共通】初期処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.02.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function SqlInitialize(ByVal connectionString As String, _
                                  Optional ByRef Msg As String = "") As Boolean

        If Not SqlDBConnect(connectionString, Msg) Then
            Return False
        End If

        Return True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：【共通】ＤＢ接続処理
    ' 　機能概要：ＤＢ接続処理を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.02.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function SqlDBConnect(ByVal connectionString As String, _
                                 Optional ByRef Msg As String = "") As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim ex As Exception
        '------------------------------
        ' 初期値設定
        '------------------------------

        '------------------------------
        ' ＤＢサーバ接続
        '------------------------------
        Try
            If L_objConnect IsNot Nothing AndAlso _
               L_objConnect.State = ConnectionState.Open Then
                '接続済みの場合は再接続しない
                Return True
            End If

            L_objConnect = New SqlClient.SqlConnection()
            L_objConnect.ConnectionString = connectionString
            L_objConnect.Open()

        Catch ex
            Msg = ex.Message
            Return False
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        Return True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：【共通】終了処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.02.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function SqlFinalize(Optional ByRef Msg As String = "") As Boolean

        If Not SqlDBDisConnect(Msg) Then
            Return False
        End If

        Return True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：【共通】ＤＢ切断処理
    ' 　機能概要：ＤＢ切断処理を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.02.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function SqlDBDisConnect(Optional ByRef Msg As String = "") As Boolean

        '------------------------------
        ' 初期値設定
        '------------------------------
        Dim ex As Exception

        '------------------------------
        ' ＤＢサーバ接続
        '------------------------------
        ' 接続文字列の取得
        Try

            'データベースを切断
            L_objConnect.Close()
            L_objConnect.Dispose()

        Catch ex
            Msg = ex.Message
            Return False
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        Return True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：【共通】ＤＢ読み込み処理(データセット生成)
    ' 　機能概要：入力引数より、データテーブルを生成します。また、当関数の出力引数を
    ' 　　　　　　sqlGetRows()関数を使用することで参照することができます。
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.02.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function SqlGetData(ByVal pstrSQL As String, ByRef pobjData As DataTable, Optional ByRef Msg As String = "") As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objAdapter As SqlClient.SqlDataAdapter
        Dim ex As Exception

        '------------------------------
        ' 初期値設定
        '------------------------------
        pobjData = New DataTable

        '------------------------------
        ' ＤＢ抽出処理
        '------------------------------
        Try
            objAdapter = New SqlClient.SqlDataAdapter(pstrSQL, L_objConnect)
            objAdapter.SelectCommand.CommandTimeout = 3600
            objAdapter.Fill(pobjData)
        Catch ex
            Msg = ex.Message
            Return False
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        Return True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：【共通】行データ返却
    ' 　機能概要：入力引数として与えられる DataSet オブジェクトより、指定行の DataRow
    ' 　　　　　　オブジェクトを生成し、返却します。
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.02.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function SqlGetRows(ByVal pobjData As DataSet, ByVal pRow As Long, ByRef pobjRows As DataRow, Optional ByRef Msg As String = "") As Boolean

        'Dim intCnt As Integer

        '------------------------------
        ' 初期値設定
        '------------------------------
        SqlGetRows = False
        Dim ex As Exception

        '------------------------------
        ' ＤＢ抽出処理
        '------------------------------
        Try

            pobjRows = pobjData.Tables("com").Rows(pRow)

        Catch ex
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        SqlGetRows = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：トランザクション開始制御
    ' 　機能概要：トランザクションの開始を宣言する
    ' 　引　　数：なし
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2017.02.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function SqlBeginTrans(Optional ByRef Msg As String = "") As Boolean

        '------------------------------
        ' 初期値設定
        '------------------------------
        SqlBeginTrans = False
        Dim ex As Exception

        '------------------------------
        ' トランザクション開始
        '------------------------------
        Try

            L_objTrans = L_objConnect.BeginTransaction(IsolationLevel.ReadUncommitted)

        Catch ex
            Msg = ex.Message
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        SqlBeginTrans = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：トランザクション確定制御
    ' 　機能概要：トランザクションを確定する
    ' 　引　　数：なし
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2017.02.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function SqlCommitTrans(Optional ByRef Msg As String = "") As Boolean

        '------------------------------
        ' 初期値設定
        '------------------------------
        SqlCommitTrans = False
        Dim ex As Exception

        '------------------------------
        ' トランザクション確定
        '------------------------------
        Try

            If L_objTrans IsNot Nothing Then
                L_objTrans.Commit()
                L_objTrans.Dispose()
                L_objTrans = Nothing
            End If

        Catch ex
            Msg = ex.Message
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        SqlCommitTrans = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：トランザクション破棄制御
    ' 　機能概要：トランザクションを破棄する
    ' 　引　　数：なし
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2017.02.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function SqlRollbackTrans(Optional ByRef Msg As String = "") As Boolean

        '------------------------------
        ' 初期値設定
        '------------------------------
        SqlRollbackTrans = False
        Dim ex As Exception

        '------------------------------
        ' トランザクション破棄
        '------------------------------
        Try

            If L_objTrans IsNot Nothing Then
                L_objTrans.Rollback()
                L_objTrans.Dispose()
                L_objTrans = Nothing
            End If
        Catch ex
            Msg = ex.Message
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        SqlRollbackTrans = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：【共通】ＤＢ更新処理
    ' 　機能概要：ＤＢ更新処理を行います
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2017.02.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function SqlUpdData(ByVal pstrSQL As String, Optional ByRef Msg As String = "") As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim cmd As SqlClient.SqlCommand = L_objConnect.CreateCommand
        Dim ex As Exception

        '------------------------------
        ' 初期値設定
        '------------------------------
        SqlUpdData = False

        '------------------------------
        ' 更新処理
        '------------------------------
        Try
            If L_objTrans Is Nothing Then
                Msg = "トランザクションが存在しないため、更新は行われませんでした。"
                Exit Function
            End If

            cmd.CommandText = pstrSQL
            cmd.Transaction = L_objTrans
            cmd.CommandTimeout = 3600
            cmd.ExecuteNonQuery()

        Catch ex
            Msg = ex.Message & " SQL=" & pstrSQL
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        SqlUpdData = True

    End Function

    Public Function strQuot(ByVal pstrSTR) As String

        If Replace(pstrSTR, "'", "''") Is Nothing Then
            Return ""
        Else
            Return Replace(pstrSTR, "'", "''")
        End If

    End Function

End Class
