Imports System.Data.SqlClient

' --------------------------------------------------------------------------------
' 　機　　能：店舗内情報システム - サーバメンテナンス(共通関数・定義域)
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
' --------------------------------------------------------------------------------

Module CNL1920
    ' --------------------------------------------------------------------------------
    ' プロジェクト内共通変数定義
    ' --------------------------------------------------------------------------------
    Public G_objConnect As SqlClient.SqlConnection
    Public G_objTrans As SqlClient.SqlTransaction
    Public g_udtAppConfig As typAppConfig

    Public G_objSVConnect As SqlClient.SqlConnection                        ' --- (2003.12.09) メニューリアル切替対応 ---

    ' --------------------------------------------------------------------------------
    ' プロジェクト内共通定数定義
    ' --------------------------------------------------------------------------------
    ' 異常系メッセージ
    Public Const GC_MSG01 As String = "アプリケーションを起動できませんでした。"
    Public Const GC_MSG02 As String = "エラーが発生したため、処理は中断されました。" & vbCrLf & "発生箇所 [@@@]"

    ' 内部定数
    Public Const GC_HalfByte As String = "0"
    Public Const GC_FullByte As String = "1"
    Public Const GC_Numeric As String = "2"
    Public Const GC_AllChar As String = "3"

    Public Const GC_TRUE As String = "0"
    Public Const GC_FALSE As String = "1"
    Public Const GC_UPDID As String = "SYSTEM"
    Public Const GC_ORDER_NONE As String = "0"
    Public Const GC_ORDER_GROUP As String = "1"
    Public Const GC_ORDER_PRICE As String = "2"
    Public Const GC_ORDER_PRICE2 As String = "3"
    Public Const GC_ORDER_CASE As String = "4"                              ' --- (2004.02.04) ネタケース対応 ---

    ' TPM060.MENUSTYLE 定数
    Public Const GC_MSTYLE_LISTSTR As String = "0"
    Public Const GC_MSTYLE_LISTPIC As String = "1"
    Public Const GC_MSTYLE_NOLIST As String = "2"
    Public Const GC_MSTYLE_NOLISTSTR As String = "3"
    Public Const GC_MSTYLE_NETACASE As String = "4"                         ' --- (2004.02.04) ネタケース対応 ---
    Public Const GC_MSTYLE_NETASTR As String = "5"
    Public Const GC_MSTYLE_NETAPIC As String = "6"
    Public Const GC_MSTYLE_LISTPIC4 As String = "7"
    Public Const GC_MSTYLE_NOLISTPIC4 As String = "8"
    '--- (2006.01.31) メニュー画像追加
    Public Const GC_MSTYLE_PICTJ As String = "13"
    Public Const GC_MSTYLE_PIC12 As String = "14"
    Public Const GC_MSTYLE_PIC4 As String = "15"

    Public Const GC_MSTYLE_MENUGRP_DIRC4 As String = "01"
    Public Const GC_MSTYLE_MENUGRP_DIRC6 As String = "02"
    Public Const GC_MSTYLE_MENUGRP_DIRC9 As String = "03"
    Public Const GC_MSTYLE_MENUGRP_DIRC16 As String = "04"
    Public Const GC_MSTYLE_MENUGRP_DIRCDAILY As String = "09"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE1 As String = "1A"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE2 As String = "1B"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE3 As String = "1C"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE4 As String = "1D"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE5 As String = "1E"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE6 As String = "1F"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE7 As String = "1G"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE8 As String = "1H"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE9 As String = "1I"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE10 As String = "1J"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE11 As String = "1K"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE12 As String = "1L"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE13 As String = "1M"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE14 As String = "1N"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE15 As String = "1O"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE16 As String = "1P"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE17 As String = "1Q"
    Public Const GC_MSTYLE_MENUGRP_DIRCFREE18 As String = "1R"
    Public Const GC_MSTYLE_MENUGRP_PIC4 As String = "05"
    Public Const GC_MSTYLE_MENUGRP_PIC6 As String = "06"
    Public Const GC_MSTYLE_MENUGRP_PIC9 As String = "07"
    Public Const GC_MSTYLE_MENUGRP_PIC16 As String = "08"
    Public Const GC_MSTYLE_GOODS_PIC4 As String = "11"
    Public Const GC_MSTYLE_GOODS_PIC6 As String = "12"
    Public Const GC_MSTYLE_GOODS_PIC9 As String = "13"
    Public Const GC_MSTYLE_GOODS_PIC16 As String = "14"
    Public Const GC_MSTYLE_GOODS_DAILY As String = "15"
    Public Const GC_MSTYLE_GOODS_FREE1 As String = "2A"
    Public Const GC_MSTYLE_GOODS_FREE2 As String = "2B"
    Public Const GC_MSTYLE_GOODS_FREE3 As String = "2C"
    Public Const GC_MSTYLE_GOODS_FREE4 As String = "2D"
    Public Const GC_MSTYLE_GOODS_FREE5 As String = "2E"
    Public Const GC_MSTYLE_GOODS_FREE6 As String = "2F"
    Public Const GC_MSTYLE_GOODS_FREE7 As String = "2G"
    Public Const GC_MSTYLE_GOODS_FREE8 As String = "2H"
    Public Const GC_MSTYLE_GOODS_FREE9 As String = "2I"
    Public Const GC_MSTYLE_GOODS_FREE10 As String = "2J"
    Public Const GC_MSTYLE_GOODS_FREE11 As String = "2K"
    Public Const GC_MSTYLE_GOODS_FREE12 As String = "2L"
    Public Const GC_MSTYLE_GOODS_FREE13 As String = "2M"
    Public Const GC_MSTYLE_GOODS_FREE14 As String = "2N"
    Public Const GC_MSTYLE_GOODS_FREE15 As String = "2O"
    Public Const GC_MSTYLE_GOODS_FREE16 As String = "2P"
    Public Const GC_MSTYLE_GOODS_FREE17 As String = "2Q"
    Public Const GC_MSTYLE_GOODS_FREE18 As String = "2R"

    Public Const GC_DUMMY_GROUPCD As String = "J000"

    Public Const GC_ADV_ADDNEW As String = "KAA"
    Public Const GC_ADV_DEFSEL As String = "KBB"

    ' 広告画像サイズ(Advertising picture)
    Public Const GC_ADVPIC_W As Long = 696
    Public Const GC_ADVPIC_H As Long = 522

    ' バックアップログファイル
    Public Const GC_BKLOG_NM As String = "TPInfo.bck"

    ' 売り切れ区分
    Public Const GC_OOS_ONSELE As String = "A"
    Public Const GC_OOS_SOLDOUT As String = "B"
    Public Const GC_OOS_NONE As String = "C"
    Public Const GC_OOS_SOLDOUT_FREE As String = "D"            '2006.06.28 飲み放題対応　追加

    ' 和英区分
    Public Const GC_EJKBN_J As String = "J"
    Public Const GC_EJKBN_E As String = "E"

    ' --------------------------------------------------------------------------------
    ' ユーザ定義型宣言
    ' --------------------------------------------------------------------------------
    Public Structure typAppConfig
        Dim strAppName As String
        Dim strAppVersion As String
        Dim strAppComment As String
        Dim strDBServerName As String
        Dim strDBServerDBName As String
        Dim strDBServerUserID As String
        Dim strDBServerPassWD As String
        Dim strAppPath As String
        Dim strTempPath As String
        Dim strImpPath As String
        Dim strAdvPath As String
        Dim strImgPath As String
        Dim strBKPath As String
        Dim strTIPath As String
        Dim strBK_MaxDay As String
        Dim strBK_MaxTime As String
        Dim strWebPath As String
        Dim strMenuImgPath As String
        Dim strMenuImgPath2 As String                                       ' 2004/05/25追加
        Dim strMenuImgPath3 As String                                       ' 2006/03/10追加
        Dim strMenuImgTemp As String
        Dim strNMImgPath As String
        Dim strNMImgPath2 As String                                         ' 2004/05/25追加
        Dim strNMImgPath3 As String                                         ' 2006/03/10追加
        Dim strOMImgPath As String
        Dim strOMImgPath2 As String                                         ' 2004/05/25追加
        Dim strOMImgPath3 As String                                         ' 2006/03/10追加
    End Structure

    Public Structure typGridColumn
        Dim intType As COLUMN_TYPE                                          ' 項目型(列挙体より指定)
        Dim strMapName As String                                            ' マップ名
        Dim strHeadText As String                                           ' ヘッダテキスト
        Dim blnAllowNull As Boolean                                         ' ＮＵＬＬ値許可(True:許可 / False:不許可)
        Dim lngWidth As Long                                                ' 表示幅
        Dim objAlign As HorizontalAlignment                                 ' 表示位置(列挙体より指定)
        Dim blnReadOnly As Boolean                                          ' 
    End Structure

    Public Structure typTPM020
        Dim GROUPCD As String
        Dim GOODSCD As String
        Dim GROUPNM As String
        Dim GROUPINFO As String
        Dim GROUPIMAGE As String
        Dim PRICEDISP As String
        Dim DISPORDER As String
        Dim ENABLED As String
        Dim SPFLG As String
        Dim UPDID As String
        Dim UPDYMD As String
    End Structure

    Public Structure typTPM020A
        Dim GROUPCD As String
        Dim GOODSCD As String
        Dim GROUPNM As String
        Dim GROUPINFO As String
        Dim GROUPIMAGE As String
        Dim PRICEDISP As String
        Dim DISPORDER As String
        Dim ENABLED As String
        Dim SPFLG As String
        Dim UPDID As String
        Dim UPDYMD As String
    End Structure

    Public Structure typTPM020B
        Dim GROUPCD As String
        Dim GOODSCD As String
        Dim GROUPNM As String
        Dim GROUPINFO As String
        Dim GROUPIMAGE As String
        Dim PRICEDISP As String
        Dim DISPORDER As String
        Dim ENABLED As String
        Dim SPFLG As String
        Dim UPDID As String
        Dim UPDYMD As String
    End Structure

    Public Structure typTPM020C
        Dim GROUPCD As String
        Dim GOODSCD As String
        Dim GROUPNM As String
        Dim GROUPINFO As String
        Dim GROUPIMAGE As String
        Dim PRICEDISP As String
        Dim DISPORDER As String
        Dim ENABLED As String
        Dim SPFLG As String
        Dim UPDID As String
        Dim UPDYMD As String
    End Structure

    Public Structure typTPM060
        Dim MENUID As String
        Dim MENUNM As String
        Dim MENUGRPID As String
        Dim MENUGRPNM As String
        Dim MENUSTYLE As String
        Dim GROUPCD As String
        Dim DISPORDER As String
        Dim PRICEDISP As String
        Dim GROUPKBN As String
        Dim ENABLED As String
        Dim PRICETYPE As String                 '--- (2006.02.13) 追加
        Dim MENUUSE As String                   '--- (2006.02.13) 追加
        Dim UPDID As String
        Dim UPDYMD As String
    End Structure

    Public Structure typTPM060A
        Dim MENUID As String
        Dim MENUNM As String
        Dim MENUGRPID As String
        Dim MENUGRPNM As String
        Dim MENUSTYLE As String
        Dim GROUPCD As String
        Dim DISPORDER As String
        Dim PRICEDISP As String
        Dim GROUPKBN As String
        Dim ENABLED As String
        Dim PRICETYPE As String                 '--- (2006.02.13) 追加
        Dim MENUUSE As String                   '--- (2006.02.13) 追加
        Dim UPDID As String
        Dim UPDYMD As String
    End Structure

    Public Structure typTPM060B
        Dim MENUID As String
        Dim MENUNM As String
        Dim MENUGRPID As String
        Dim MENUGRPNM As String
        Dim MENUSTYLE As String
        Dim GROUPCD As String
        Dim DISPORDER As String
        Dim PRICEDISP As String
        Dim GROUPKBN As String
        Dim ENABLED As String
        Dim PRICETYPE As String                 '--- (2006.02.13) 追加
        Dim MENUUSE As String                   '--- (2006.02.13) 追加
        Dim UPDID As String
        Dim UPDYMD As String
    End Structure

    Public Structure typTPM060C
        Dim MENUID As String
        Dim MENUNM As String
        Dim MENUGRPID As String
        Dim MENUGRPNM As String
        Dim MENUSTYLE As String
        Dim GROUPCD As String
        Dim DISPORDER As String
        Dim PRICEDISP As String
        Dim GROUPKBN As String
        Dim ENABLED As String
        Dim PRICETYPE As String                 '--- (2006.02.13) 追加
        Dim MENUUSE As String                   '--- (2006.02.13) 追加
        Dim UPDID As String
        Dim UPDYMD As String
    End Structure

    ' --------------------------------------------------------------------------------
    ' ユーザ定義値列挙体宣言
    ' --------------------------------------------------------------------------------
    Public Enum COLUMN_TYPE
        TEXT_STYLE = 0
        IMAGE_STYLE = 1
        IMAGE_NOEDIT_STYLE = 2
        CHECK_STYLE = 3
    End Enum

    Public Enum FuncResult
        NormalEnd = 0
        CancelEnd = 1
        UnusualEnd = 9
    End Enum

    Public Enum ID_KIND                                                     ' --- (2003.12.11) 追加 ---
        GenrID = 0
        MenuID = 1
    End Enum

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＤＢサーバ接続処理
    ' 　機能概要：引数に従い、データベースサーバへの接続処理を行う
    ' 　引　　数：pstrSQL          参照ＳＱＬ文
    '　　　　　 ：pSqlDataReader   参照結果
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_ConnectDB(ByVal pstrServerNm As String, _
                                 ByVal pstrDatabase As String, _
                                 ByVal pstrUserNm As String, _
                                 ByVal pstrPasswd As String, _
                                 Optional ByVal pblnMode As Boolean = False) As Boolean
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objTestCon As SqlClient.SqlConnection
        Dim strConnect As String

        '------------------------------
        ' 接続文字列生成
        '------------------------------
        strConnect = "data source=" & Trim$(pstrServerNm) & ";" & _
                     "initial catalog=" & Trim$(pstrDatabase) & ";" & _
                     "user id=" & Trim$(pstrUserNm) & ";" & _
                     "password=" & Trim$(pstrPasswd) & ";"

        '------------------------------
        ' 接続処理
        '------------------------------
        If pblnMode Then
            ' 導通確認モード
            Try
                objTestCon = New SqlClient.SqlConnection(strConnect)
                objTestCon.Open()
            Catch
                GoTo SYSTEM_ERROR
            End Try
            If Not GF_DisConnectDB(objTestCon) Then
                GoTo SYSTEM_ERROR
            End If

        Else
            ' アプリケーション起動モード(Default)
            Try
                G_objConnect = New SqlClient.SqlConnection(strConnect)
                G_objConnect.Open()
            Catch
                GoTo SYSTEM_ERROR
            End Try
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        GF_ConnectDB = True

        Exit Function

SYSTEM_ERROR:
        GF_ConnectDB = False
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＤＢサーバ接続処理
    ' 　機能概要：引数に従い、データベースサーバへの接続処理を行います。
    ' 　引　　数：pstrSQL          参照ＳＱＬ文
    '　　　　　 ：pSqlDataReader   参照結果
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2003.07.18 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_DisConnectDB(ByVal pobjConnect As SqlClient.SqlConnection) As Boolean

        '------------------------------
        ' ＤＢ切断処理
        '------------------------------
        Try
            pobjConnect.Close()
        Catch
            GF_DisConnectDB = False
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        GF_DisConnectDB = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＤＢ読み込み処理(データセット生成)
    ' 　機能概要：入力引数より、データセットを生成します。また、当関数の出力引数を
    '　　　　　 　comGetRows()関数を使用することで参照することができます。
    ' 　引　　数：pstrSQL          参照ＳＱＬ文
    '　　　　　 ：pSqlDataReader   参照結果
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_GetData(ByVal pstrSQL As String, _
                               ByRef pdstData As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim dtaAdapter As SqlClient.SqlDataAdapter

        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_GetData = False

        '------------------------------
        ' ＤＢ抽出処理
        '------------------------------
        Try
            'SQL接続情報が切断されてしまった場合はコネクトを行う
            If G_objConnect.State = 0 Then
                G_objConnect.Open()
            End If
            dtaAdapter = New SqlClient.SqlDataAdapter(pstrSQL, G_objConnect)
            dtaAdapter.Fill(pdstData, "com")
        Catch
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        GF_GetData = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＤＢ読み込み処理(行データ返却)
    ' 　機能概要：入力引数として与えられる DataSet オブジェクトより、指定行の DataRow
    '　　　　　 　オブジェクトを生成し、返却します。
    ' 　引　　数：
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_GetRows(ByVal pdtsData As DataSet, _
                               ByVal pRow As Long, _
                               ByRef pdtrRows As DataRow) As Boolean

        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_GetRows = False

        '------------------------------
        ' ＤＢ抽出処理
        '------------------------------
        Try
            pdtrRows = pdtsData.Tables("com").Rows(pRow)
        Catch
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        GF_GetRows = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：トランザクション開始制御
    ' 　機能概要：トランザクションの開始を宣言する
    ' 　引　　数：なし
    '　　　　　 ：
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2003.07.18 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_BeginTrans() As Boolean
        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_BeginTrans = False

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_UpdData("BEGIN TRANSACTION") Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        GF_BeginTrans = True
        Debug.WriteLine("GF_BeginTrans")
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：トランザクション確定制御
    ' 　機能概要：トランザクションを確定する
    ' 　引　　数：なし
    '　　　　　 ：
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2003.07.18 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_CommitTrans() As Boolean
        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_CommitTrans = False

        '------------------------------
        ' トランザクション確定
        '------------------------------
        If Not GF_UpdData("COMMIT TRANSACTION") Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        GF_CommitTrans = True
        Debug.WriteLine("GF_CommitTrans")
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：トランザクション破棄制御
    ' 　機能概要：トランザクションを破棄する
    ' 　引　　数：なし
    '　　　　　 ：
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2003.07.18 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_RollbackTrans() As Boolean
        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_RollbackTrans = False

        '------------------------------
        ' トランザクション破棄
        '------------------------------
        If Not GF_UpdData("ROLLBACK TRANSACTION") Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        GF_RollbackTrans = True
        Debug.WriteLine("GF_RollbackTrans")
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＤＢ読み込み処理(ＤＢ更新処理)
    ' 　機能概要：ＤＢ更新処理を行います
    ' 　引　　数：pstrSQL          参照ＳＱＬ文
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_UpdData(ByVal pstrSQL As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim scmCommand As New SqlClient.SqlCommand()

        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_UpdData = False

        '------------------------------
        ' 更新処理
        '------------------------------
        Try
            'SQL接続情報が切断されてしまった場合はコネクトを行う
            If G_objConnect.State = 0 Then
                G_objConnect.Open()
            End If
            With scmCommand
                .Connection = G_objConnect
                .Transaction = G_objTrans
                .CommandText = pstrSQL
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            Debug.WriteLine("Sql Error: " & ex.Message)
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        GF_UpdData = True
        Debug.WriteLine("GF_UpdData [" & pstrSQL & "]")
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＤＢ更新処理(トランザクション開始～確定まで)
    ' 　機能概要：ＤＢ更新処理を行います
    ' 　引　　数：pstrSQL          参照ＳＱＬ文
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_UpdCmtData(ByVal pstrSQL As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim scmCommand As New SqlClient.SqlCommand()

        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_UpdCmtData = False

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        '------------------------------
        ' 更新処理
        '------------------------------
        If Not GF_UpdData(pstrSQL) Then
            '------------------------------
            ' トランザクション破棄
            '------------------------------
            Call GF_RollbackTrans()
            Exit Function
        End If

        '------------------------------
        ' トランザクション確定
        '------------------------------
        If Not GF_CommitTrans() Then
            '------------------------------
            ' トランザクション破棄
            '------------------------------
            Call GF_RollbackTrans()
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        GF_UpdCmtData = True
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＤＢ更新処理(トランザクション開始～確定まで)
    ' 　機能概要：ＤＢ更新処理を行います
    ' 　引　　数：aryStr()          参照ＳＱＬ郡
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2014-04.26 t.abe
    ' --------------------------------------------------------------------------------
    Public Function GF_UpdCmtSomeData(ByVal aryStr() As String) As Boolean

        'Dim strSQL As String
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim scmCommand As New SqlClient.SqlCommand()

        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_UpdCmtSomeData = False

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        '------------------------------
        ' 更新処理
        '------------------------------
        For Each strSQL As String In aryStr
            If Not GF_UpdData(strSQL) Then
                '------------------------------
                ' トランザクション破棄
                '------------------------------
                Call GF_RollbackTrans()
                Exit Function
            End If
        Next
        '------------------------------
        ' トランザクション確定
        '------------------------------
        If Not GF_CommitTrans() Then
            '------------------------------
            ' トランザクション破棄
            '------------------------------
            Call GF_RollbackTrans()
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        GF_UpdCmtSomeData = True
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：コンボボックス 表示値設定処理
    ' 　機能概要：省略
    ' 　引　　数：省略
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Sub GS_CboItemSet(ByVal pcboTarget As ComboBox, _
                             ByVal pstrDisplay As String, _
                             ByVal pstrCode As String)

        pcboTarget.Items.Add(pstrDisplay & Space(100) & vbTab & pstrCode)

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：コンボボックス テキスト値取得処理
    ' 　機能概要：省略
    ' 　引　　数：省略
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_CboGetText(ByVal pcboTarget As ComboBox, _
                                  ByVal plngIndex As Long) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strArray() As String

        Try
            strArray = Split(pcboTarget.Items.Item(plngIndex), vbTab)
            GF_CboGetText = Trim$(strArray(0))
        Catch
            GF_CboGetText = ""
        End Try
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：コンボボックス コード値取得処理
    ' 　機能概要：省略
    ' 　引　　数：省略
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_CboGetCode(ByVal pcboTarget As ComboBox, _
                                  ByVal plngIndex As Long) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strArray() As String

        Try
            strArray = Split(pcboTarget.Items.Item(plngIndex), vbTab)
            GF_CboGetCode = strArray(1)
        Catch
            GF_CboGetCode = ""
        End Try
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：コンボボックス 選択状態変更処理
    ' 　機能概要：省略
    ' 　引　　数：省略
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Sub GS_CboChgSel(ByVal pcboTarget As ComboBox, _
                            ByVal pstrCode As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long

        lngCnt = 0
        Try
            While lngCnt < pcboTarget.Items.Count
                If GF_CboGetCode(pcboTarget, lngCnt) = Trim$(pstrCode) Then
                    pcboTarget.SelectedIndex = lngCnt
                End If
                lngCnt = lngCnt + 1
            End While
        Catch
            Exit Sub
        End Try
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：リストボックス 表示値設定処理
    ' 　機能概要：省略
    ' 　引　　数：なし
    ' 　戻 り 値：なし
    ' 　履　　歴：2003.03.01 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Sub GS_SetListBox(ByVal pListBox As ListBox, _
                             ByVal pSetString As String, _
                             ByVal pSetCode As String)

        pListBox.Items.Add(Trim$(pSetString) & Space(100) & vbTab & Trim$(pSetCode))

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：リストボックス コード値取得処理
    ' 　機能概要：省略
    ' 　引　　数：省略
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_LstGetCode(ByVal pcboTarget As ListBox, _
                                  ByVal plngIndex As Long) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strArray() As String

        Try
            strArray = Split(pcboTarget.Items.Item(plngIndex), vbTab)
            GF_LstGetCode = strArray(1)
        Catch
            GF_LstGetCode = ""
        End Try
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：リストボックス 表示値取得処理
    ' 　機能概要：省略
    ' 　引　　数：省略
    ' 　戻 り 値：[True] 成功 / [False] 失敗
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_LstGetString(ByVal pcboTarget As ListBox, _
                                    ByVal plngIndex As Long) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strArray() As String

        Try
            strArray = Split(pcboTarget.Items.Item(plngIndex), vbTab)
            GF_LstGetString = strArray(0)
        Catch
            GF_LstGetString = ""
        End Try
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：リストボックス コード値検索
    ' 　機能概要：入力引数で示されるコード値が、リストボックス内に存在するかどうかを返却する
    ' 　引　　数：なし
    ' 　戻 り 値：[True] 存在する / [False] 存在しない
    ' 　履　　歴：2003.03.01 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_FndListBox(ByVal pListBox As ListBox, _
                                  ByVal pFndCode As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim strArray() As String

        GF_FndListBox = False

        lngCnt = 0
        While lngCnt < pListBox.Items.Count
            Try
                strArray = Split(pListBox.Items.Item(lngCnt), vbTab)
                If Trim$(strArray(1)) = Trim$(pFndCode) Then
                    GF_FndListBox = True
                    Exit Function
                End If
            Catch
                Exit Function
            End Try
            lngCnt = lngCnt + 1
        End While

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：シングルクォーテーション置換処理
    ' 　機能概要：省略
    ' 　引　　数：省略
    ' 　戻 り 値：シングルクォーテーション置換後の文字列
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_RepQuo(ByVal pstrData As String) As String
        If InStr(1, pstrData, "'") <> 0 Then
            GF_RepQuo = Replace(pstrData, "'", "''")
        Else
            GF_RepQuo = pstrData
        End If
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：入力文字数カウント処理
    ' 　機能概要：省略
    ' 　引　　数：省略
    ' 　戻 り 値：シングルクォーテーション置換後の文字列
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Sub GS_chkByte(ByVal pObj As TextBox, _
                          ByVal pWidth As String, _
                          Optional ByVal pLimitedChar As String = GC_AllChar)

        If pLimitedChar <> GC_AllChar Then
            If IsNumeric(pObj.Text) = False Then
                If Len(Trim$(pObj.Text)) <> 0 Then
                    pObj.BackColor = Color.Pink
                    pObj.Focus()
                    Exit Sub
                End If
            Else
                pObj.BackColor = Color.White
            End If
        End If

        If LF_chkByte(Trim$(pObj.Text), pWidth) = False Then
            pObj.BackColor = Color.Red
            pObj.Focus()
        Else
            pObj.BackColor = Color.White
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：入力文字数カウント処理
    ' 　機能概要：省略
    ' 　引　　数：省略
    ' 　戻 り 値：シングルクォーテーション置換後の文字列
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_chkByte(ByVal pstrValue As String, _
                                ByVal pKbn As String) As Boolean

        Dim lngChkLen As Long
        Dim lngCnt As Long

        LF_chkByte = False

        Select Case pKbn
            Case GC_HalfByte
                ' 半角のみ
                lngChkLen = 1
            Case GC_FullByte
                ' 全角のみ
                lngChkLen = 2
        End Select

        For lngCnt = 1 To Len(pstrValue)
            If System.Text.Encoding.GetEncoding("Shift-JIS").GetByteCount(Mid$(pstrValue, lngCnt, 1)) <> lngChkLen Then
                Exit Function
            End If
        Next

        LF_chkByte = True
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：漢数字変換
    ' 　機能概要：入力パラメータの数値を、漢数字に変換し、文字列として返却する。
    ' 　引　　数：pstrValue   調整対象文字列
    ' 　戻 り 値：調整後の文字列
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_ChgNumeric(ByVal pstrValue As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngLen As Long
        Dim lngCnt As Long

        lngLen = Len(pstrValue)
        GF_ChgNumeric = ""

        For lngCnt = 1 To lngLen + 1
            Select Case Mid(pstrValue, lngCnt, 1)
                Case 0
                    GF_ChgNumeric = GF_ChgNumeric & "〇"
                Case 1
                    GF_ChgNumeric = GF_ChgNumeric & "一"
                Case 2
                    GF_ChgNumeric = GF_ChgNumeric & "二"
                Case 3
                    GF_ChgNumeric = GF_ChgNumeric & "三"
                Case 4
                    GF_ChgNumeric = GF_ChgNumeric & "四"
                Case 5
                    GF_ChgNumeric = GF_ChgNumeric & "五"
                Case 6
                    GF_ChgNumeric = GF_ChgNumeric & "六"
                Case 7
                    GF_ChgNumeric = GF_ChgNumeric & "七"
                Case 8
                    GF_ChgNumeric = GF_ChgNumeric & "八"
                Case 9
                    GF_ChgNumeric = GF_ChgNumeric & "九"
            End Select
        Next lngCnt

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画面(フォーム)キャプション文字列生成処理
    ' 　機能概要：省略
    ' 　引　　数：省略
    ' 　戻 り 値：
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_FormText(Optional ByVal pStr As String = "") As String
        'GF_FormText = Space(1) & g_udtAppConfig.strAppName & Space(2) & "Ver " & g_udtAppConfig.strAppVersion & Space(2) & Trim$(pStr)
        GF_FormText = Space(1) & g_udtAppConfig.strAppName & Space(2) & Trim$(pStr)
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：グリッド列設定処理
    ' 　機能概要：省略
    ' 　引　　数：省略
    ' 　戻 り 値：
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Sub GS_GridAddColumn(ByVal pArgs As typGridColumn, ByRef pAddTable As DataGridTableStyle)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCs As DataGridImageTextBoxColumn                             ' サムネイル表示向けの画像表示列定義列
        Dim objCs2 As DataGridTextBoxColumn                                 ' 通常のテキスト表示列定義
        Dim objCs3 As DataGridBoolColumn                                    ' チェックボックス型定義
        Dim objCs4 As DataGridImageTextBoxColumnNoEdit                      ' サムネイル表示向けの画像表示列定義列

        '------------------------------
        ' 項目型判定
        '------------------------------
        Select Case pArgs.intType

            Case CNL1920.COLUMN_TYPE.IMAGE_STYLE
                objCs = New DataGridImageTextBoxColumn()
                With objCs
                    .MappingName = pArgs.strMapName
                    .Width = pArgs.lngWidth
                    .HeaderText = pArgs.strHeadText
                    .Alignment = pArgs.objAlign
                End With
                pAddTable.GridColumnStyles.Add(objCs)

            Case CNL1920.COLUMN_TYPE.IMAGE_NOEDIT_STYLE
                objCs4 = New DataGridImageTextBoxColumnNoEdit()
                With objCs4
                    .MappingName = pArgs.strMapName
                    .Width = pArgs.lngWidth
                    .HeaderText = pArgs.strHeadText
                    .Alignment = pArgs.objAlign
                End With
                pAddTable.GridColumnStyles.Add(objCs4)

            Case CNL1920.COLUMN_TYPE.TEXT_STYLE
                objCs2 = New DataGridTextBoxColumn()
                With objCs2
                    .MappingName = pArgs.strMapName
                    .Width = pArgs.lngWidth
                    .HeaderText = pArgs.strHeadText
                    .Alignment = pArgs.objAlign
                    .ReadOnly = pArgs.blnReadOnly
                End With
                pAddTable.GridColumnStyles.Add(objCs2)

            Case COLUMN_TYPE.CHECK_STYLE
                objCs3 = New DataGridBoolColumn()
                With objCs3
                    .MappingName = pArgs.strMapName
                    .Width = pArgs.lngWidth
                    .HeaderText = pArgs.strHeadText
                    .Alignment = pArgs.objAlign
                    .AllowNull = pArgs.blnAllowNull
                    .ReadOnly = pArgs.blnReadOnly
                End With
                pAddTable.GridColumnStyles.Add(objCs3)

            Case Else
                Exit Sub

        End Select

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：グリッド列追加処理
    ' 　機能概要：省略
    ' 　引　　数：省略
    ' 　戻 り 値：
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Sub GS_GridAddTable(ByVal pArgs As typGridColumn, ByRef pTable As DataTable)

        '------------------------------
        ' 初期値設定
        '------------------------------
        Dim objColumn As DataColumn

        objColumn = New DataColumn(pArgs.strMapName)
        With objColumn
            Select Case pArgs.intType
                Case CNL1920.COLUMN_TYPE.IMAGE_STYLE, _
                            COLUMN_TYPE.IMAGE_NOEDIT_STYLE
                    .DefaultValue = ""
                    .DataType = Type.GetType("System.String")

                Case CNL1920.COLUMN_TYPE.TEXT_STYLE
                    .DefaultValue = ""
                    .DataType = Type.GetType("System.String")

                Case COLUMN_TYPE.CHECK_STYLE
                    .DefaultValue = False
                    .DataType = Type.GetType("System.Boolean")

                Case Else
                    Exit Sub

            End Select

        End With
        pTable.Columns.Add(objColumn)

    End Sub

    Public Sub GS_ErrorTerm(ByVal pErrPoint As String)
        Call GF_Msg("", Replace(GC_MSG02, "@@@", pErrPoint), MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：アプリケーション情報取得関数
    ' 　機能概要：省略
    ' 　引　　数：省略
    ' 　戻 り 値：
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_GetAppInfo(ByVal pAPKEY As String) As String

        GF_GetAppInfo = Nothing

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' マスタ情報取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT APVALUE FROM TPM090 WHERE APKEY = '" & pAPKEY & "'"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        Else
            If Not GF_GetRows(objData, 0, objRows) Then
                Exit Function
            Else
                GF_GetAppInfo = Trim$(objRows("APVALUE"))
            End If
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：アプリケーション情報取得関数
    ' 　機能概要：省略
    ' 　引　　数：省略
    ' 　戻 り 値：
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_GetAppInfo2(ByVal pAPKEY As String) As String

        GF_GetAppInfo2 = Nothing

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' マスタ情報取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT APVALUE FROM TPM091 WHERE APKEY = '" & pAPKEY & "'"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        Else
            If Not GF_GetRows(objData, 0, objRows) Then
                Exit Function
            Else
                GF_GetAppInfo2 = Trim$(objRows("APVALUE"))
            End If
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：アプリケーション情報取得関数
    ' 　機能概要：省略
    ' 　引　　数：省略
    ' 　戻 り 値：
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_GetAppInfo3(ByVal pAPKEY As String) As String

        GF_GetAppInfo3 = Nothing

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' マスタ情報取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT APVALUE FROM TPM092 WHERE APKEY LIKE '" & pAPKEY & "%'"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        Else
            If Not GF_GetRows(objData, 0, objRows) Then
                Exit Function
            Else
                GF_GetAppInfo3 = Trim$(objRows("APVALUE"))
            End If
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メッセージ取得処理
    ' 　機能概要：省略
    ' 　引　　数：省略
    ' 　戻 り 値：
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_GetMsg(ByVal pMsgID As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()
        Dim dtrData As DataRow = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_GetMsg = ""

        '------------------------------
        ' ＳＱＬ文生成
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT CODENM"
        strSQL = strSQL & "  FROM TPM030"
        strSQL = strSQL & " WHERE CODEID = 'VBMSG'"
        strSQL = strSQL & "   AND CODEVAL = '" & pMsgID & "'"
        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        If dtsData.Tables("com").Rows.Count = 0 Then
            Exit Function
        Else
            If Not GF_GetRows(dtsData, 0, dtrData) Then
                Exit Function
            End If
            GF_GetMsg = Trim$(dtrData("CODENM"))
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：文字列長取得
    ' 　機能概要：パラメータに示される文字列について、バイト長を返却する
    ' 　引　　数：省略
    ' 　戻 り 値：
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_LenB(ByVal pStr As String) As Long
        GF_LenB = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(pStr)
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：文字列長取得(韓国語)
    ' 　機能概要：パラメータに示される文字列について、バイト長を返却する
    ' 　引　　数：省略
    ' 　戻 り 値：
    ' 　履　　歴：2015.11.27 cresco 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_LenB_Korea(ByVal pStr As String) As Long
        GF_LenB_Korea = System.Text.Encoding.GetEncoding("ks_c_5601-1987").GetByteCount(pStr)
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：文字列切り出し処理
    ' 　機能概要：パラメータに示される文字列について、指定範囲をバイト単位で返却する
    ' 　引　　数：省略
    ' 　戻 り 値：
    ' 　履　　歴：2003.02.28 SORUN 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_MidB(ByVal pStr As String, ByVal pStart As Long, ByVal pLength As Long) As String

        Dim bytBuff() As Byte

        If pLength > GF_LenB(pStr) - (pStart - 1) Then
            pLength = GF_LenB(pStr) - (pStart - 1)
        End If

        GF_MidB = ""
        bytBuff = System.Text.Encoding.GetEncoding("Shift-JIS").GetBytes(pStr)
        GF_MidB = System.Text.Encoding.GetEncoding("Shift-JIS").GetString(bytBuff, pStart - 1, pLength)

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：文字列切り出し処理(韓国語)
    ' 　機能概要：パラメータに示される文字列について、指定範囲をバイト単位で返却する
    ' 　引　　数：省略
    ' 　戻 り 値：
    ' 　履　　歴：2015.11.27 cresco 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_MidB_Korea(ByVal pStr As String, ByVal pStart As Long, ByVal pLength As Long) As String

        Dim bytBuff() As Byte

        If pLength > GF_LenB_Korea(pStr) - (pStart - 1) Then
            pLength = GF_LenB_Korea(pStr) - (pStart - 1)
        End If

        GF_MidB_Korea = ""
        bytBuff = System.Text.Encoding.GetEncoding("ks_c_5601-1987").GetBytes(pStr)
        GF_MidB_Korea = System.Text.Encoding.GetEncoding("ks_c_5601-1987").GetString(bytBuff, pStart - 1, pLength)

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：特定ディレクトリ以降を、全て削除する
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Sub GS_DelFiles(ByVal pFolder As String)

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strFiles() As String
        Dim strFile As String
        Dim strSubFld() As String
        Dim strFld As String

        '------------------------------
        ' 全ファイル取得 → 削除
        '------------------------------
        strFiles = System.IO.Directory.GetFiles(pFolder, "*.*")
        For Each strFile In strFiles
            System.IO.File.SetAttributes(strFile, IO.FileAttributes.Normal)
            System.IO.File.Delete(strFile)
        Next

        '------------------------------
        ' 全サブフォルダ取得
        '------------------------------
        strSubFld = System.IO.Directory.GetDirectories(pFolder)
        For Each strFld In strSubFld
            Call GS_DelFiles(strFld)
        Next

        System.IO.File.SetAttributes(pFolder, IO.FileAttributes.Normal)
        System.IO.Directory.Delete(pFolder)
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メッセージボックス表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_Msg(Optional ByVal pMsgID As String = "", _
                           Optional ByVal pMsgStr As String = "", _
                           Optional ByVal pButton As MsgBoxStyle = MsgBoxStyle.OkCancel, _
                           Optional ByVal pInfo As MsgBoxStyle = MsgBoxStyle.Information) As MsgBoxResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strMsg As String = Nothing

        If Len(Trim$(pMsgID)) <> 0 Then
            strMsg = GF_GetMsg(pMsgID)
        End If
        strMsg = strMsg & pMsgStr
        GF_Msg = MsgBox(strMsg, pButton + pInfo, g_udtAppConfig.strAppName)

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像エンコーダー情報取得処理
    ' 　機能概要：引数(MimeType)で指定されたImageCodecInfoを探して返す
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_GetEncoderInfo(ByVal pmineType As String) As System.Drawing.Imaging.ImageCodecInfo

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objEncoders() As System.Drawing.Imaging.ImageCodecInfo
        Dim objEncoder As System.Drawing.Imaging.ImageCodecInfo

        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_GetEncoderInfo = Nothing

        objEncoders = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()
        For Each objEncoder In objEncoders
            If objEncoder.MimeType = pmineType Then
                GF_GetEncoderInfo = objEncoder
                Exit For
            End If
        Next

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：文字列逆順並べ替え処理
    ' 　機能概要：引数で指定された文字列変数を逆転し、返却する
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_RevStr(ByVal pOrgStr As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim strWork As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_RevStr = ""

        '------------------------------
        ' 主処理
        '------------------------------
        Try
            strWork = ""
            For lngCnt = Len(pOrgStr) To 1 Step -1
                strWork = strWork & Mid$(pOrgStr, lngCnt, 1)
            Next
        Catch
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        GF_RevStr = strWork

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：グリッド表示行数取得処理
    ' 　機能概要：引数で指定されたグリッドに表示されている行数を取得する
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_GetRowCnt(ByVal pGrid As DataGrid) As Long

        '------------------------------
        ' 内部変数定義
        '------------------------------
        GF_GetRowCnt = 0

        '------------------------------
        ' グリッド表示行数取得
        '------------------------------
        Try
            GF_GetRowCnt = pGrid.BindingContext(pGrid.DataSource, pGrid.DataMember).Count
        Catch
            Exit Function
        End Try

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像素材名取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_GetMaterial(ByVal pImageCD As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_GetMaterial = ""

        '------------------------------
        ' 引数チェック
        '------------------------------
        If Len(Trim$(pImageCD)) = 0 Then Exit Function

        '------------------------------
        ' 素材画像名取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM070.FILENM"
        strSQL = strSQL & "  FROM TPM070,"
        strSQL = strSQL & "       TPM040"
        strSQL = strSQL & " WHERE TPM070.IMAGESET = TPM040.IMAGESET"
        strSQL = strSQL & "   AND TPM070.IMAGECD  = '" & pImageCD & "'"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        Else
            If objData.Tables("com").Rows.Count = 0 Then
                Exit Function
            End If
        End If

        If Not GF_GetRows(objData, 0, objRows) Then
            Exit Function
        Else
            GF_GetMaterial = Trim$(objRows("FILENM"))
        End If

    End Function

    Public Sub GS_StatusSetup(ByVal pObj As StatusBar)

        With pObj                                                           ' ステータスバー初期化
            .Panels.Clear()
            .Panels.Add("")
            .Panels(0).AutoSize = StatusBarPanelAutoSize.Spring
            .Panels(0).Alignment = HorizontalAlignment.Left

            .Panels.Add(Format$(Now, "yyyy年MM月dd日") & _
                        "(" & Mid$(WeekdayName(Weekday(Now)), 1, 1) & ")" & Space(1) & _
                        Format$(Now, "HH:mm"))
            .Panels(1).Width = 200
            .Panels(1).Alignment = HorizontalAlignment.Center
        End With

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニュー／ジャンルＩＤ採番処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.11 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_GetNewID(ByVal pIDKind As ID_KIND, ByRef pResultID As String) As FuncResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngTempID As Long
        Dim strTempID As String
        Dim lngCnt As Long
        Dim lngMaxCnt As Long
        Dim strTBLNM As String
        Dim strCOLNM As String
        Dim lngRCnt As Long
        Dim strUPDCOL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_GetNewID = FuncResult.UnusualEnd                                 ' 異常終了
        pResultID = ""

        '------------------------------
        ' 最終採番値取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM040.GENR_MAXNO,"
        strSQL = strSQL & "       TPM040.MENU_MAXNO"
        strSQL = strSQL & "  FROM TPM040"
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
        ' 存在チェック
        '------------------------------
        Select Case pIDKind
            Case ID_KIND.GenrID
                strUPDCOL = "GENR_MAXNO"
                strTBLNM = "TPM020"
                strCOLNM = "GROUPCD"
                lngTempID = CLng(Trim$(objRows("GENR_MAXNO"))) + 1
                lngMaxCnt = 999
                If lngTempID > lngMaxCnt Then
                    lngTempID = lngMaxCnt
                End If
                strTempID = "J" & Format$(lngTempID, "000")

            Case ID_KIND.MenuID
                strUPDCOL = "MENU_MAXNO"
                strTBLNM = "TPM060"
                strCOLNM = "MENUID"
                lngTempID = CLng(Trim$(objRows("MENU_MAXNO"))) + 1
                lngMaxCnt = 99
                If lngTempID > lngMaxCnt Then
                    lngTempID = lngMaxCnt
                End If
                strTempID = "M" & Format$(lngTempID, "00")

            Case Else
                Exit Function
        End Select

        strSQL = ""
        strSQL = strSQL & "SELECT " & strTBLNM & "." & strCOLNM
        strSQL = strSQL & "  FROM " & strTBLNM
        strSQL = strSQL & " WHERE " & strTBLNM & "." & strCOLNM & "='" & strTempID & "'"
        objData = New DataSet()
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            ' 存在しない(そのまま適用する)
            pResultID = strTempID
        Else
            ' 存在する(空き番検索する)
            strSQL = ""
            strSQL = strSQL & "SELECT " & strTBLNM & "." & strCOLNM
            strSQL = strSQL & "  FROM " & strTBLNM
            strSQL = strSQL & " GROUP BY " & strTBLNM & "." & strCOLNM
            strSQL = strSQL & " ORDER BY " & strTBLNM & "." & strCOLNM
            objData = New DataSet()
            If Not GF_GetData(strSQL, objData) Then
                Exit Function
            End If
            lngRCnt = 0

            For lngCnt = 1 To lngMaxCnt
                If objData.Tables("com").Rows.Count > lngRCnt Then
                    If Not GF_GetRows(objData, lngRCnt, objRows) Then
                        Exit Function
                    End If
                    If CLng(Mid$(Trim$(objRows(strCOLNM)), 2)) <> lngCnt Then
                        lngTempID = lngCnt
                        If pIDKind = ID_KIND.GenrID Then
                            strTempID = "J" & Format$(lngTempID, "000")
                        Else
                            strTempID = "M" & Format$(lngTempID, "00")
                        End If
                        pResultID = strTempID
                        Exit For
                    End If
                    lngRCnt = lngRCnt + 1
                Else
                    lngTempID = lngCnt
                    If pIDKind = ID_KIND.GenrID Then
                        strTempID = "J" & Format$(lngTempID, "000")
                    Else
                        strTempID = "M" & Format$(lngTempID, "00")
                    End If
                    pResultID = strTempID
                    Exit For
                End If
            Next
        End If

        '------------------------------
        ' TPM040.採番管理項目 更新
        '------------------------------
        If Len(Trim$(pResultID)) <> 0 Then
            strSQL = ""
            strSQL = strSQL & "UPDATE TPM040 SET TPM040." & strUPDCOL & "=" & lngTempID & ","
            strSQL = strSQL & "                  TPM040.UPDID  = '" & GC_UPDID & "',"
            strSQL = strSQL & "                  TPM040.UPDYMD = '" & Now & "'"
            If Not GF_UpdData(strSQL) Then
                Exit Function
            End If
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        If Len(Trim$(pResultID)) = 0 Then
            GF_GetNewID = FuncResult.CancelEnd                              ' 空き番なし
        Else
            GF_GetNewID = FuncResult.NormalEnd                              ' 正常終了
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：新規の飲み放題メニューＩＤを取得
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2006.04.05 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_GetNewID2(ByRef pstrNewID As String) As Boolean

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim intNo As Integer
        Dim intCnt As Integer

        GF_GetNewID2 = False
        intNo = 1

        strSQL = ""
        strSQL = strSQL & "SELECT MENUID FROM TPM170"
        strSQL = strSQL & " GROUP BY MENUID"
        strSQL = strSQL & " ORDER BY MENUID"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count > 0 Then
            For intCnt = 0 To objData.Tables("com").Rows.Count - 1
                If Not GF_GetRows(objData, intCnt, objRow) Then
                    Exit Function
                End If

                If intNo < CInt(Replace(Trim$(objRow("MENUID")), "F", "")) Then
                    Exit For
                End If

                intNo = intNo + 1
            Next
        End If

        pstrNewID = "F" & Format(intNo, "00")
        GF_GetNewID2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：飲み放題サブメニュー商品コードを採番
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2006.04.05 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_GetGoodsCD(ByRef pGoodsCD1 As String, ByRef pGoodsCD2 As String, ByVal pNo As Integer) As Boolean

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim intNo As Integer
        Dim intCnt As Integer

        GF_GetGoodsCD = False
        intNo = pNo
        pGoodsCD1 = ""
        pGoodsCD2 = ""

        strSQL = ""
        strSQL = strSQL & "SELECT GOODSCD FROM TPM010"
        strSQL = strSQL & " WHERE GOODSCD >= '" & pNo & "'"
        strSQL = strSQL & " ORDER BY GOODSCD"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count > 0 Then
            For intCnt = 0 To objData.Tables("com").Rows.Count - 1
                If Not GF_GetRows(objData, intCnt, objRow) Then
                    Exit Function
                End If

                If intNo < CInt(Trim$(objRow("GOODSCD"))) Then
                    If Trim$(pGoodsCD1) = "" Then
                        pGoodsCD1 = intNo
                        If pNo = 8500 Or pNo = 7500 Then
                            Exit For
                        End If
                    ElseIf Trim$(pGoodsCD2) = "" Then
                        pGoodsCD2 = intNo
                        Exit For
                    End If
                End If

                intNo = intNo + 1
            Next
        Else
            pGoodsCD1 = intNo
            pGoodsCD2 = intNo + 1
        End If

        GF_GetGoodsCD = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：採番したサブメニュー商品をTPM010に登録する
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2006.04.05 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_InTPM010(ByVal pGOODSCD As String, ByVal pGOODSNM As String) As Boolean

        Dim strSQL As String

        GF_InTPM010 = False

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM010 VALUES("
        strSQL = strSQL & "'" & pGOODSCD.PadRight(5) & "',"
        strSQL = strSQL & "'" & Mid(pGOODSNM, 1, 10) & "',"                 ' ＴＰ商品名１
        strSQL = strSQL & "'" & IIf(Mid(pGOODSNM, 11, 20) = "", Space(20), Mid(pGOODSNM, 11, 20)) & "',"              ' ＴＰ商品名２
        strSQL = strSQL & "'" & Mid(pGOODSNM, 1, 10) & "',"                 ' ＰＯＳ商品名１
        strSQL = strSQL & "'" & Mid(pGOODSNM, 1, 10) & "',"                 ' ＰＯＳ商品名２
        strSQL = strSQL & "'" & Space(180) & "',"                           ' 説明文
        strSQL = strSQL & "'" & Space(100) & "',"                           ' 画像データ
        strSQL = strSQL & "0,"                                              ' 単価額
        strSQL = strSQL & "'" & Space(5) & "',"                             ' 単位
        strSQL = strSQL & "'0',"                             ' 品切れフラグ
        strSQL = strSQL & "'000',"                             ' ＳＣＰ№１
        strSQL = strSQL & "'000',"                             ' ＳＣＰ№２
        strSQL = strSQL & "'000',"                             ' ＳＣＰ№３
        strSQL = strSQL & "'000',"                             ' ＳＣＰ№４
        strSQL = strSQL & "'000',"                             ' ＳＣＰ№５
        strSQL = strSQL & "'000',"                             ' ＳＣＰ№６
        strSQL = strSQL & "'000',"                             ' ＳＣＰ№７
        strSQL = strSQL & "'000',"                             ' ＳＣＰ№８
        strSQL = strSQL & "'000',"                             ' ＳＣＰ№９
        strSQL = strSQL & "'000',"                             ' ＳＣＰ№１０
        strSQL = strSQL & "'000',"                             ' ＳＣＰ№１１
        strSQL = strSQL & "'000',"                             ' ＳＣＰ№１２
        strSQL = strSQL & "'0',"                             ' 商品ステータス
        strSQL = strSQL & "'1',"                             ' 商品分類
        strSQL = strSQL & "'" & GF_GetBumon() & "',"                        ' 部門コード
        strSQL = strSQL & "'00000000000000000000000000000000',"             ' ＫＣＰステータス
        strSQL = strSQL & "'" & Space(1) & "',"                             ' 画像再生成フラグ
        strSQL = strSQL & "'" & Space(5) & "',"                             ' HTL名称１
        strSQL = strSQL & "'" & Space(5) & "',"                             ' HTL名称２
        strSQL = strSQL & "'0',"                                            ' おすすめフラグ
        strSQL = strSQL & "'0',"                                            ' 新作フラグ
        strSQL = strSQL & "'" & GC_UPDID & "',"
        strSQL = strSQL & "'" & Now & "')"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        GF_InTPM010 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：TPM010 初期データ用の部門コード。マスタに存在するコードであれば何でもＯＫ
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2006.04.05 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_GetBumon() As String

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        GF_GetBumon = ""

        strSQL = ""
        strSQL = strSQL & "SELECT BUMONCD FROM TPM110"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, objRow) Then
            Exit Function
        End If

        GF_GetBumon = objRow("BUMONCD")

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ファイル容量取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2004.04.15 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_FSizeChk(ByVal pPath As String, ByVal pFileNM As String) As Long

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim lngSize As Long
        Dim strFiles As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_FSizeChk = 0
        lngSize = 0

        '------------------------------
        ' ファイル長取得処理
        '------------------------------
        For Each strFiles In System.IO.Directory.GetFiles(pPath, pFileNM)
            objFileInfo = New System.IO.FileInfo(strFiles)
            lngSize = lngSize + objFileInfo.Length
            objFileInfo = Nothing
        Next

        '------------------------------
        ' 返却値設定
        '------------------------------
        GF_FSizeChk = lngSize

    End Function

    Public Function GF_AllAdvChk() As FuncResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strBKey As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_AllAdvChk = FuncResult.UnusualEnd
        strBKey = ""

        '------------------------------
        ' 広告グループリスト取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM080.ADVGRP_ID,"
        strSQL = strSQL & "       TPM080.ADVGRP_NM"
        strSQL = strSQL & "  FROM TPM080"
        strSQL = strSQL & " WHERE TPM080.ADV_ID = '000'"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count <> 0 Then
            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    Exit Function
                End If

                Select Case GF_AdvGrpLengthChk(Trim$(objRows("ADVGRP_ID")))
                    Case FuncResult.CancelEnd
                        Call GF_Msg("", "広告 [" & Trim$(objRows("ADVGRP_NM")) & "] の容量が制限値を超えています" & vbCrLf & _
                                        "タッチパネルへの表示ができません", _
                                    MsgBoxStyle.Exclamation, _
                                    MsgBoxStyle.OkOnly)
                        GF_AllAdvChk = FuncResult.CancelEnd
                        Exit Function

                    Case FuncResult.UnusualEnd
                        Call GF_Msg("", "広告画像容量チェック処理にて異常が発生しました", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                        Exit Function

                End Select

                lngCnt = lngCnt + 1
            End While
        End If

        GF_AllAdvChk = FuncResult.NormalEnd

    End Function

    Public Function GF_AdvGrpLengthChk(ByVal pAdvID As String) As FuncResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strMaxLength As String
        Dim strAdvPath As String
        Dim lngAdvSize As Long
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_AdvGrpLengthChk = FuncResult.UnusualEnd
        strMaxLength = Trim$(GF_GetAppInfo("ADV_MAXSIZE"))
        strAdvPath = Trim$(GF_GetAppInfo("ADV_PATH"))

        '------------------------------
        ' TPM090設定値評価
        '------------------------------
        If Len(Trim$(strMaxLength)) = 0 Then
            Exit Function
        End If
        If IsNumeric(strMaxLength) = False Then
            Exit Function
        End If
        If Len(Trim$(strAdvPath)) = 0 Then
            Exit Function
        End If
        If System.IO.Directory.Exists(strAdvPath) = False Then
            Exit Function
        End If

        '------------------------------
        ' グループ内画像総容量取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM080.ADVGRP_ID,"
        strSQL = strSQL & "       TPM080.ADV_ID"
        strSQL = strSQL & "  FROM TPM080"
        strSQL = strSQL & " WHERE TPM080.ADVGRP_ID = '" & pAdvID & "'"
        strSQL = strSQL & "   AND TPM080.ADV_ID <> '000'"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        lngCnt = 0
        lngAdvSize = 0
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If

            lngAdvSize = lngAdvSize + GF_FSizeChk(strAdvPath, Trim$(objRows("ADVGRP_ID")) & Trim$(objRows("ADV_ID")) & ".jpg")

            lngCnt = lngCnt + 1
        End While

        If lngAdvSize > CLng(strMaxLength) Then
            GF_AdvGrpLengthChk = FuncResult.CancelEnd
            Exit Function
        End If


        '------------------------------
        ' 返却値設定
        '------------------------------
        GF_AdvGrpLengthChk = FuncResult.NormalEnd

    End Function

    Public Function GF_PadSpace(ByVal pVal As String, ByVal pLength As Integer) As String

        If GF_LenB(pVal) < pLength Then
            GF_PadSpace = pVal & Space(pLength - GF_LenB(pVal))
        Else
            GF_PadSpace = GF_MidB(pVal, 1, pLength)
        End If

    End Function

    Public Function LF_CheckMenuPic(ByVal pstrTable As String, ByRef strMenuNM As String, ByRef strMenuGrpNM As String) As Boolean

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_CheckMenuPic = False
        strMenuNM = ""
        strMenuGrpNM = ""

        'ジャンル割付されていない中ジャンル設定を検索
        strSQL = ""
        strSQL = strSQL & "SELECT MAX(TPM150.GROUPCD),"
        strSQL = strSQL & "       TPM150.MENUID,"
        strSQL = strSQL & "       TPM150.MENUGRPID,"
        strSQL = strSQL & "       MIN(" & pstrTable & ".MENUNM) AS MENUNM"
        If pstrTable = "TPM060" Then
            strSQL = strSQL & "  ,MIN(TPM060.MENUGRPNM) AS MENUGRPNM"
        End If
        strSQL = strSQL & "  FROM TPM150"
        strSQL = strSQL & " RIGHT JOIN " & pstrTable & " ON TPM150.MENUID = " & pstrTable & ".MENUID"
        strSQL = strSQL & " WHERE " & pstrTable & ".MENUSTYLE IN (13,14,15)"
        strSQL = strSQL & " GROUP BY TPM150.MENUID, TPM150.MENUGRPID"
        strSQL = strSQL & " HAVING MAX(TPM150.GROUPCD) = 'J000'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count > 0 Then
            If Not GF_GetRows(objData, 0, objRow) Then
                Exit Function
            End If

            strMenuNM = objRow("MENUNM")
            If pstrTable = "TPM060" Then
                strMenuGrpNM = objRow("MENUGRPNM")
            End If

            Exit Function
        End If

        LF_CheckMenuPic = True

    End Function

    ''Public Function GF_CheckMenuCnt() As Boolean
    ''    '--- (2006.02.13) メニュー切り替え対応 ------------------------------------------
    ''    ' 使用可能メニュー数は最大５個

    ''    Dim strSQL As String
    ''    Dim objData As New DataSet()
    ''    Dim objRow As DataRow

    ''    GF_CheckMenuCnt = False

    ''    strSQL = ""
    ''    strSQL = strSQL & "SELECT MENUID"
    ''    strSQL = strSQL & "  FROM TPM060"
    ''    strSQL = strSQL & " WHERE MENUUSE = '0'"
    ''    strSQL = strSQL & " GROUP BY MENUID"
    ''    If Not GF_GetData(strSQL, objData) Then
    ''        Exit Function
    ''    End If

    ''    If objData.Tables("com").Rows.Count >= 5 Then
    ''        Exit Function
    ''    End If

    ''    GF_CheckMenuCnt = True

    ''End Function

    ''Public Function GF_MenuGoodsLink(ByVal pMenuID As String, ByVal pTitle As String, Optional ByVal pMode As String = "NEW") As Boolean
    ''    '--- (2006.02.13) メニュー切り替え対応 -----------------

    ''    Dim strSQL As String
    ''    Dim objData As New DataSet()
    ''    Dim objRow As DataRow
    ''    Dim strCode() As String
    ''    Dim i As Integer

    ''    GF_MenuGoodsLink = False

    ''    ' TPM090 から商品との紐付け情報を取得
    ''    strSQL = ""
    ''    strSQL = strSQL & "SELECT * FROM TPM090"
    ''    strSQL = strSQL & " WHERE APKEY LIKE 'GOODS_MENU%'"
    ''    If Not GF_GetData(strSQL, objData) Then
    ''        Exit Function
    ''    End If

    ''    If objData.Tables("com").Rows.Count <= 0 Then
    ''        Exit Function
    ''    End If

    ''    For i = 0 To 4
    ''        If Not GF_GetRows(objData, i, objRow) Then
    ''            Exit Function
    ''        End If
    ''        strCode = Split(objRow("APVALUE"), "/")
    ''        If pMode = "NEW" Then
    ''            If Trim$(strCode(1)) = "" Then
    ''                '--- メニューのファーストオーダー用商品コードを自動採番
    ''                strSQL = ""
    ''                strSQL = strSQL & "UPDATE TPM010"
    ''                strSQL = strSQL & "   SET GOODSNMJ  = '" & Mid(Trim$(pTitle), 1, 10) & "',"
    ''                strSQL = strSQL & "       GOODSNMJ2 = '" & Mid(Trim$(pTitle), 11, 10) & "',"
    ''                strSQL = strSQL & "       GOODSNMJ4 = '" & Mid(Trim$(pTitle), 1, 10) & "',"
    ''                strSQL = strSQL & "       UPDID     = '" & GC_UPDID & "',"
    ''                strSQL = strSQL & "       UPDYMD    = '" & Now & "'"
    ''                strSQL = strSQL & " WHERE GOODSCD   = '" & strCode(0) & "'"
    ''                If Not GF_UpdData(strSQL) Then
    ''                    Exit Function
    ''                End If

    ''                '--- メニューID、商品コードの紐付け情報をTPM090に登録
    ''                strSQL = ""
    ''                strSQL = strSQL & "UPDATE TPM090"
    ''                strSQL = strSQL & "   SET APVALUE = '" & strCode(0) & "/" & pMenuID & "',"
    ''                strSQL = strSQL & "       COMMENT = '【" & Trim$(pTitle) & "】商品コード',"
    ''                strSQL = strSQL & "       UPDID   = '" & GC_UPDID & "',"
    ''                strSQL = strSQL & "       UPDYMD  = '" & Now & "'"
    ''                strSQL = strSQL & " WHERE APKEY   = '" & objRow("APKEY") & "'"
    ''                If Not GF_UpdData(strSQL) Then
    ''                    Exit Function
    ''                End If

    ''                GF_MenuGoodsLink = True
    ''                Exit Function

    ''            End If
    ''        Else

    ''            If Trim$(strCode(1)) = pMenuID Then

    ''                '--- TPM010 を元に戻す
    ''                strSQL = ""
    ''                strSQL = strSQL & "UPDATE TPM010"
    ''                strSQL = strSQL & "   SET GOODSNMJ  = GOODSNMJ3,"
    ''                strSQL = strSQL & "       GOODSNMJ2 = '　',"
    ''                strSQL = strSQL & "       GOODSNMJ4 = GOODSNMJ3,"
    ''                strSQL = strSQL & "       UPDID     = '" & GC_UPDID & "',"
    ''                strSQL = strSQL & "       UPDYMD    = '" & Now & "'"
    ''                strSQL = strSQL & " WHERE GOODSCD   = '" & strCode(0) & "'"
    ''                If Not GF_UpdData(strSQL) Then
    ''                    Exit Function
    ''                End If

    ''                '--- TPM090 を元に戻す
    ''                strSQL = ""
    ''                strSQL = strSQL & "UPDATE TPM090"
    ''                strSQL = strSQL & "   SET APVALUE = '" & strCode(0) & "/" & Space(4) & "',"
    ''                strSQL = strSQL & "       COMMENT = '商品コード',"
    ''                strSQL = strSQL & "       UPDID   = '" & GC_UPDID & "',"
    ''                strSQL = strSQL & "       UPDYMD  = '" & Now & "'"
    ''                strSQL = strSQL & " WHERE APKEY   = '" & objRow("APKEY") & "'"
    ''                If Not GF_UpdData(strSQL) Then
    ''                    Exit Function
    ''                End If

    ''                GF_MenuGoodsLink = True
    ''                Exit Function

    ''            End If

    ''        End If

    ''    Next

    ''    GF_MenuGoodsLink = True

    ''End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：採番用のＳＣＰＮＯを取得
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2006.06.15 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_GetSCPNO(ByRef pSCPNO As String) As Boolean
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim intNo As Integer
        Dim intCnt As Integer

        GF_GetSCPNO = False
        intNo = 1
        pSCPNO = ""

        strSQL = ""
        strSQL = strSQL & "SELECT SCPNO"
        strSQL = strSQL & "  FROM TPM100"
        strSQL = strSQL & " WHERE SCPNO >= '001'"
        strSQL = strSQL & "   AND SCPNO <= '035'"
        strSQL = strSQL & " ORDER BY SCPNO"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count > 0 Then
            For intCnt = 0 To objData.Tables("com").Rows.Count - 1
                If Not GF_GetRows(objData, intCnt, objRow) Then
                    Exit Function
                End If

                '取得したデータ間にスペースがあった場合はカウンタにプラス１をした値を設定
                If intNo < CInt(Trim$(objRow("SCPNO"))) Then
                    pSCPNO = GF_PutZero(intNo, 3)
                    Exit For
                End If

                intNo = intNo + 1
            Next

            '取得したデータ間にスペースがなかった場合は取得件数にプラス１をした値を設定
            If pSCPNO = "" Then
                pSCPNO = GF_PutZero(objData.Tables("com").Rows.Count + 1, 3)
            End If
        Else
            pSCPNO = "001"
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        GF_GetSCPNO = True
    End Function

    Private Function GF_PutZero(ByVal pSCPNO As Integer, ByVal pFLOW As Integer) As String
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim strScpNo As String

        strScpNo = CLng(pSCPNO)

        '変数の先頭文字が"0"埋めされている場合は削除
        For lngCnt = 0 To pFLOW
            If strScpNo.Length <> pFLOW Then
                strScpNo = "0" + strScpNo
            Else
                Exit For
            End If
        Next

        GF_PutZero = strScpNo
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：採番したサブメニュー商品をTPM010に登録する
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2006.04.05 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function GF_InTPM100(ByVal pSCPNO As String, ByVal pGUIDE As String) As Boolean

        Dim strSQL As String
        'Dim strGOODSCD As String
        'Dim strSCPNO As String
        'Dim lngCnt As Long

        GF_InTPM100 = False

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        'ＳＣＰマスタ更新(TPM100)
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM100 VALUES("
        strSQL = strSQL & "'" & pSCPNO & "',"       ' SCPNO
        strSQL = strSQL & "'" & pGUIDE & "',"       ' GUIDE
        strSQL = strSQL & "'0000',"                 ' GOODSCD1
        strSQL = strSQL & "'0000',"                 ' GOODSCD2
        strSQL = strSQL & "'0000',"                 ' GOODSCD3
        strSQL = strSQL & "'0000',"                 ' GOODSCD4
        strSQL = strSQL & "'0000',"                 ' GOODSCD5
        strSQL = strSQL & "'0000',"                 ' GOODSCD6
        strSQL = strSQL & "'0000',"                 ' GOODSCD7
        strSQL = strSQL & "'0000',"                 ' GOODSCD8
        strSQL = strSQL & "'0000',"                 ' GOODSCD9
        strSQL = strSQL & "'0000',"                 ' GOODSCD10
        strSQL = strSQL & "'0000',"                 ' GOODSCD11
        strSQL = strSQL & "'0000',"                 ' GOODSCD12
        strSQL = strSQL & "'0000',"                 ' GOODSCD13
        strSQL = strSQL & "'0000',"                 ' GOODSCD14
        strSQL = strSQL & "'0000',"                 ' GOODSCD15
        strSQL = strSQL & "'0000',"                 ' GOODSCD16
        strSQL = strSQL & "'" & GC_UPDID & "',"     ' UPDID
        strSQL = strSQL & "'" & Now & "')"          ' UPDYMD

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        '多言語機能対応
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then

            'ＳＣＰマスタ更新(TPM100)
            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM100A VALUES("
            strSQL = strSQL & "N'" & pSCPNO & "',"       ' SCPNO
            strSQL = strSQL & "N'option',"               ' GUIDE
            strSQL = strSQL & "N'0000',"                 ' GOODSCD1
            strSQL = strSQL & "N'0000',"                 ' GOODSCD2
            strSQL = strSQL & "N'0000',"                 ' GOODSCD3
            strSQL = strSQL & "N'0000',"                 ' GOODSCD4
            strSQL = strSQL & "N'0000',"                 ' GOODSCD5
            strSQL = strSQL & "N'0000',"                 ' GOODSCD6
            strSQL = strSQL & "N'0000',"                 ' GOODSCD7
            strSQL = strSQL & "N'0000',"                 ' GOODSCD8
            strSQL = strSQL & "N'0000',"                 ' GOODSCD9
            strSQL = strSQL & "N'0000',"                 ' GOODSCD10
            strSQL = strSQL & "N'0000',"                 ' GOODSCD11
            strSQL = strSQL & "N'0000',"                 ' GOODSCD12
            strSQL = strSQL & "N'0000',"                 ' GOODSCD13
            strSQL = strSQL & "N'0000',"                 ' GOODSCD14
            strSQL = strSQL & "N'0000',"                 ' GOODSCD15
            strSQL = strSQL & "N'0000',"                 ' GOODSCD16
            strSQL = strSQL & "N'" & GC_UPDID & "',"     ' UPDID
            strSQL = strSQL & "N'" & Now & "')"          ' UPDYMD

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            'ＳＣＰマスタ更新(TPM100)
            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM100B VALUES("
            strSQL = strSQL & "N'" & pSCPNO & "',"       ' SCPNO
            strSQL = strSQL & "N'option',"               ' GUIDE
            strSQL = strSQL & "N'0000',"                 ' GOODSCD1
            strSQL = strSQL & "N'0000',"                 ' GOODSCD2
            strSQL = strSQL & "N'0000',"                 ' GOODSCD3
            strSQL = strSQL & "N'0000',"                 ' GOODSCD4
            strSQL = strSQL & "N'0000',"                 ' GOODSCD5
            strSQL = strSQL & "N'0000',"                 ' GOODSCD6
            strSQL = strSQL & "N'0000',"                 ' GOODSCD7
            strSQL = strSQL & "N'0000',"                 ' GOODSCD8
            strSQL = strSQL & "N'0000',"                 ' GOODSCD9
            strSQL = strSQL & "N'0000',"                 ' GOODSCD10
            strSQL = strSQL & "N'0000',"                 ' GOODSCD11
            strSQL = strSQL & "N'0000',"                 ' GOODSCD12
            strSQL = strSQL & "N'0000',"                 ' GOODSCD13
            strSQL = strSQL & "N'0000',"                 ' GOODSCD14
            strSQL = strSQL & "N'0000',"                 ' GOODSCD15
            strSQL = strSQL & "N'0000',"                 ' GOODSCD16
            strSQL = strSQL & "N'" & GC_UPDID & "',"     ' UPDID
            strSQL = strSQL & "N'" & Now & "')"          ' UPDYMD

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            'ＳＣＰマスタ更新(TPM100)
            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM100C VALUES("
            strSQL = strSQL & "N'" & pSCPNO & "',"       ' SCPNO
            strSQL = strSQL & "N'option',"               ' GUIDE
            strSQL = strSQL & "N'0000',"                 ' GOODSCD1
            strSQL = strSQL & "N'0000',"                 ' GOODSCD2
            strSQL = strSQL & "N'0000',"                 ' GOODSCD3
            strSQL = strSQL & "N'0000',"                 ' GOODSCD4
            strSQL = strSQL & "N'0000',"                 ' GOODSCD5
            strSQL = strSQL & "N'0000',"                 ' GOODSCD6
            strSQL = strSQL & "N'0000',"                 ' GOODSCD7
            strSQL = strSQL & "N'0000',"                 ' GOODSCD8
            strSQL = strSQL & "N'0000',"                 ' GOODSCD9
            strSQL = strSQL & "N'0000',"                 ' GOODSCD10
            strSQL = strSQL & "N'0000',"                 ' GOODSCD11
            strSQL = strSQL & "N'0000',"                 ' GOODSCD12
            strSQL = strSQL & "N'0000',"                 ' GOODSCD13
            strSQL = strSQL & "N'0000',"                 ' GOODSCD14
            strSQL = strSQL & "N'0000',"                 ' GOODSCD15
            strSQL = strSQL & "N'0000',"                 ' GOODSCD16
            strSQL = strSQL & "N'" & GC_UPDID & "',"     ' UPDID
            strSQL = strSQL & "N'" & Now & "')"          ' UPDYMD

            If Not GF_UpdData(strSQL) Then
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

        GF_InTPM100 = True

    End Function

    Private Function LF_DelZero(ByVal pStr As String) As String
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim strScpNo As String

        strScpNo = Trim$(pStr)

        '変数の先頭文字が"0"埋めされている場合は削除
        For lngCnt = 0 To Len(Trim$(pStr))
            If strScpNo.Substring(0, 1) = "0" Then
                strScpNo = strScpNo.Remove(0, 1)
            Else
                Exit For
            End If
        Next

        LF_DelZero = strScpNo
    End Function

End Module
