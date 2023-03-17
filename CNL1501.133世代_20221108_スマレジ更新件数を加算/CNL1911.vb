Imports System.Collections.Generic
Imports System.IO

Module CNL1911

    ' OA) 2015.9.29
    ' 商品マスタ(FUMENU) TECデータ取込用
    Public Structure typItemData2
        Dim str商品コード As String
        Dim str部門コード As String
        Dim str商品名１ As String
        Dim str商品名２ As String
        Dim int単価 As Integer
        Dim intメニュータイプ As ITEM_TYPE
        Dim str出力先ＫＰ As String
        Dim strオプション As String
        Dim strＨＴＬ名称1 As String
        Dim strＨＴＬ名称2 As String
        Dim strCCPItem As String
    End Structure

    ' --------------------------------------------------------------------------------
    ' 　機　　能：TECデータ取込処理
    ' 　機能概要：省略
    ' 　引　　数：省略
    ' 　戻 り 値：省略
    ' 　履　　歴：2015.09.29 OA 新規作成
    ' --------------------------------------------------------------------------------
    Public Function ImportTECData(ByVal frMdiParent As Form) As Boolean

        Dim strExpPath As String
        Dim strFUMENUPath As String
        Dim strFSCPPath As String
        Dim intFUMENUUpdate As Integer
        Dim intFUMENUInsert As Integer
        Dim intFUMENUDelete As Integer
        Dim intFSCPUpdate As Integer
        Dim intFSCPInsert As Integer
        Dim intFSCPDelete As Integer
        Dim strMessage As String
        Dim strFlgTecDataImportPath As String

        ImportTECData = False

        '------------------------------
        ' ファイル存在チェック
        '------------------------------
        strFUMENUPath = GF_GetAppInfo("OES_PATH") & "\" & "FUMENU"
        strFSCPPath = GF_GetAppInfo("OES_PATH") & "\" & "FSCP"

        If Not (System.IO.File.Exists(strFUMENUPath) And System.IO.File.Exists(strFSCPPath)) Then
            Call GF_Msg("", "*TECデータ取込実行時のエラー*" & vbCrLf & "FUMENUまたはFSCPファイルが存在しません" & vbCrLf & "予めFSWORKS設定ツールにて読み込んでください" & vbCrLf & "(" & GF_GetAppInfo("OES_PATH") & ")", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
            Exit Function
        End If

        '------------------------------
        ' 削除レコードのバックアップ(ステップ1: テーブル全体をバックアップ)
        '------------------------------ 
        Try
            strExpPath = GF_GetAppInfo("BACKUP_PATH") & "\TECDataImport(" & Format$(Now, "yyyyMMddHHmmss") & ")"
            System.IO.Directory.CreateDirectory(strExpPath)
        Catch
            Call GF_Msg("", "*TECデータ取込実行時のエラー*" & vbCrLf & "バックアップの作成に失敗しました" & vbCrLf & "再度設定を確認して下さい", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            Exit Function
        End Try

        If Not ImportTECData_TableBackup(strExpPath) Then
            Call GF_Msg("", "*TECデータ取込実行時のエラー*" & vbCrLf & "バックアップの作成に失敗しました" & vbCrLf & "再度設定を確認して下さい", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            Exit Function
        End If

        '------------------------------
        ' データ取込処理
        '------------------------------ 
        If Not GF_BeginTrans() Then
            Call GF_Msg("", "*TECデータ取込実行時のエラー*" & vbCrLf & "データ取込に失敗しました(DBトランザクションエラー)", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            Exit Function
        End If

        If Not ImportTECDataFUMENU(strExpPath, strFUMENUPath, intFUMENUUpdate, intFUMENUInsert, intFUMENUDelete) Then
            Call GF_Msg("", "*TECデータ取込実行時のエラー*" & vbCrLf & "データ取込に失敗しました(FUMENUファイルの取込時のエラー)", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            GoTo SYSTEM_ERROR
        End If

        If Not ImportTECDataFSCP(strExpPath, strFSCPPath, intFSCPUpdate, intFSCPInsert, intFSCPDelete) Then
            Call GF_Msg("", "*TECデータ取込実行時のエラー*" & vbCrLf & "データ取込に失敗しました(FSCPファイルの取込時のエラー)", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            GoTo SYSTEM_ERROR
        End If

        If Not GF_CommitTrans() Then
            Call GF_Msg("", "*TECデータ取込実行時のエラー*" & vbCrLf & "データ取込に失敗しました(DBトランザクションエラー)", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' 結果表示
        '------------------------------ 
        strMessage = "商品マスタ" & vbCrLf
        strMessage = strMessage & "追加:" & intFUMENUInsert & "件 更新:" & intFUMENUUpdate & "件 削除:" & intFUMENUDelete & "件" & vbCrLf
        strMessage = strMessage & "オプションマスタ" & vbCrLf
        strMessage = strMessage & "追加:" & intFSCPInsert & "件 更新:" & intFSCPUpdate & "件 削除:" & intFSCPDelete & "件"
        GF_Msg("", strMessage, MsgBoxStyle.OkOnly, MsgBoxStyle.Information)

        '------------------------------
        'フラグファイルを作成
        '------------------------------
        Try
            strFlgTecDataImportPath = GF_GetAppInfo("AP_PATH") & "\" & "flg_tec_data_import"
            If System.IO.File.Exists(strFlgTecDataImportPath) = False Then
                System.IO.File.Create(strFlgTecDataImportPath)
                DirectCast(frMdiParent, CNL2010).btn_menu11.Font = New Font("ＭＳ ゴシック", 11.25)
                DirectCast(frMdiParent, CNL2010).btn_menu11.Text = "各種設定"
            End If
        Catch
            GF_Msg("", "TECデータ取込フラグファイルの作成に失敗しました", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            Exit Function
        End Try

        ImportTECData = True
        Exit Function

SYSTEM_ERROR:
        Call GF_RollbackTrans()

    End Function

    Public Function ImportTECDataFUMENU(ByVal strExpPath As String, ByVal strFUMENUPath As String, ByRef intUpdateCount As Integer, ByRef intInsertCount As Integer, ByRef intDeleteCount As Integer) As Boolean

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objData2 As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim intFile As Short

        Dim strGOODSCDsTPM010 As New List(Of String)
        Dim strGOODSCDsTPM250 As New List(Of String)
        Dim udtFUMENU As typItemData2 = Nothing

        intUpdateCount = 0
        intInsertCount = 0
        intDeleteCount = 0

        Dim countRow As Integer
        Dim strGOODSCD As String

        ImportTECDataFUMENU = False

        '------------------------------
        ' TPM010から商品コード一覧を取得
        '------------------------------ 
        strSQL = "SELECT GOODSCD FROM TPM010"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If
            strGOODSCDsTPM010.Add(Trim$(objRows("GOODSCD")))
            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' TPM250から商品コード一覧を取得
        '------------------------------ 

        strSQL = ""
        strSQL = strSQL & "SELECT GOODSCD FROM TPM250"
        If Not GF_GetData(strSQL, objData2) Then
            Exit Function
        End If

        lngCnt = 0
        While lngCnt < objData2.Tables("com").Rows.Count
            If Not GF_GetRows(objData2, lngCnt, objRows) Then
                Exit Function
            End If
            strGOODSCDsTPM250.Add(Trim$(objRows("GOODSCD")))
            lngCnt = lngCnt + 1
        End While

        '------------------------------
        ' FUMENUから1レコードずつデータを読込。TPM010、TPM250を追加、更新
        '------------------------------ 
        Try
            intFile = FreeFile()
            FileOpen(intFile, strFUMENUPath, OpenMode.Binary)

            countRow = CInt(New FileInfo(strFUMENUPath).Length / 147)
            For row As Integer = 1 To countRow
                udtFUMENU = ImportTECData_readFUMENU(intFile)

                If strGOODSCDsTPM010.Contains(udtFUMENU.str商品コード) Then
                    If Not ImportTECData_UPDATE_TPM010(udtFUMENU) Then
                        Exit Function
                    End If
                    intUpdateCount = intUpdateCount + 1
                Else
                    If Not ImportTECData_INSERT_TPM010(udtFUMENU) Then
                        Exit Function
                    End If
                    intInsertCount = intInsertCount + 1
                End If
                strGOODSCDsTPM010.Remove(udtFUMENU.str商品コード)

                If strGOODSCDsTPM250.Contains(udtFUMENU.str商品コード) Then
                    If Not ImportTECData_UPDATE_TPM250(udtFUMENU) Then
                        Exit Function
                    End If
                Else
                    If Not ImportTECData_INSERT_TPM250(udtFUMENU) Then
                        Exit Function
                    End If
                End If
                strGOODSCDsTPM250.Remove(udtFUMENU.str商品コード)

            Next

            '------------------------------
            ' TPM010、TPM250からFUMENUに存在しなかった商品を削除
            '------------------------------
            For Each strGOODSCD In strGOODSCDsTPM010
                If Not ImportTECData_DELETE_TPM010(strGOODSCD) Then
                    Exit Function
                End If
                intDeleteCount = intDeleteCount + 1
            Next

            For Each strGOODSCD In strGOODSCDsTPM250
                If Not ImportTECData_DELETE_TPM250(strGOODSCD) Then
                    Exit Function
                End If
            Next

            '------------------------------
            ' 削除レコードのバックアップ(ステップ2: バックアップファイルから削除行のみを抽出)
            '------------------------------ 
            If Not ImportTECData_ExcerptDeletedFromTPM010CSV(strExpPath, strGOODSCDsTPM010) Then
                Exit Function
            End If

            If Not ImportTECData_ExcerptDeletedFromTPM250CSV(strExpPath, strGOODSCDsTPM250) Then
                Exit Function
            End If

            ImportTECDataFUMENU = True

        Catch
            Exit Function
        Finally
            FileClose(intFile)
        End Try

    End Function

    Public Function ImportTECDataFSCP(ByVal strExpPath As String, ByVal strFSCPPath As String, ByRef intUpdateCount As Integer, ByRef intInsertCount As Integer, ByRef intDeleteCount As Integer) As Boolean

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim intFile As Short

        Dim strSCPNOs As New List(Of String)
        Dim udtFSCP As typSCPData = Nothing

        intUpdateCount = 0
        intInsertCount = 0
        intDeleteCount = 0

        Dim countRow As Integer
        Dim strSCPNO As String

        ImportTECDataFSCP = False

        '------------------------------
        ' SCPNO一覧を取得
        '------------------------------ 
        strSQL = "SELECT SCPNO FROM TPM100"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If
            strSCPNOs.Add(Trim$(objRows("SCPNO")))
            lngCnt = lngCnt + 1
        End While

        Try
            intFile = FreeFile()
            FileOpen(intFile, strFSCPPath, OpenMode.Binary)

            countRow = CInt(New FileInfo(strFSCPPath).Length / 53)
            For index As Integer = 1 To countRow
                udtFSCP = ImportTECData_readFSCP(intFile)
                If strSCPNOs.Contains(udtFSCP.strSCPNo) Then
                    If Not ImportTECData_UPDATE_TPM100(udtFSCP) Then
                        Exit Function
                    End If
                    intUpdateCount = intUpdateCount + 1
                Else
                    If Not ImportTECData_INSERT_TPM100(udtFSCP) Then
                        Exit Function
                    End If
                    intInsertCount = intInsertCount + 1
                End If
                strSCPNOs.Remove(udtFSCP.strSCPNo)
            Next

            For Each strSCPNO In strSCPNOs
                If Not ImportTECData_DELETE_TPM100(strSCPNO) Then
                    Exit Function
                End If
                intDeleteCount = intDeleteCount + 1
            Next

            '------------------------------
            ' 削除レコードのバックアップ(ステップ2: バックアップファイルから削除行のみを抽出)
            '------------------------------ 
            If Not ImportTECData_ExcerptDeletedFromTPM100CSV(strExpPath, strSCPNOs) Then
                Exit Function
            End If

            ImportTECDataFSCP = True

        Catch
            Exit Function
        Finally
            FileClose(intFile)
        End Try

    End Function

    '--- バイナリ読込処理 ---------------------------

    Function ImportTECData_readFUMENU(ByVal intFile As Short) As typItemData2

        Dim bTmp() As Byte
        Dim udtFUMENU As typItemData2 = Nothing
        Dim strTmp As String
        Dim omitDone As Boolean = False

        ReDim bTmp(1) '1
        FileGet(intFile, bTmp)
        udtFUMENU.str商品コード = bTmp(0).ToString("X2") & bTmp(1).ToString("X2") 'GOODSCD

        ReDim bTmp(0) '2
        FileGet(intFile, bTmp)
        udtFUMENU.str部門コード = bTmp(0).ToString("X2") 'BUMONCD

        ReDim bTmp(12) '3
        FileGet(intFile, bTmp)

        ReDim bTmp(19) '4
        FileGet(intFile, bTmp)

        ReDim bTmp(19) '5
        FileGet(intFile, bTmp)
        udtFUMENU.str商品名１ = Trim$(System.Text.Encoding.GetEncoding(932).GetString(bTmp)) 'GOODSNMJ
        If udtFUMENU.str商品名１ = "" Then udtFUMENU.str商品名１ = " " '※空文字だとBCP時にnullが出力されるため、対策

        ReDim bTmp(19) '6
        FileGet(intFile, bTmp)

        ReDim bTmp(9) '7-1
        FileGet(intFile, bTmp)
        strTmp = System.Text.Encoding.GetEncoding(932).GetString(bTmp)
        udtFUMENU.strＨＴＬ名称1 = MidB(strTmp, 1, 5, omitDone) 'HTLNM1 (2015.10.5 全角文字が5、6バイト目をまたぐ場合の処理追加)
        If omitDone Then
            udtFUMENU.strＨＴＬ名称2 = Trim$(MidB(strTmp, 5, 5, omitDone)) 'HTLNM2
        Else
            udtFUMENU.strＨＴＬ名称2 = Trim$(MidB(strTmp, 6, 5, omitDone)) 'HTLNM2
        End If
        If udtFUMENU.strＨＴＬ名称1 = "" Then udtFUMENU.strＨＴＬ名称1 = " "
        If udtFUMENU.strＨＴＬ名称2 = "" Then udtFUMENU.strＨＴＬ名称2 = " "

        ReDim bTmp(4) '8
        FileGet(intFile, bTmp)
        If Microsoft.VisualBasic.Right(bTmp(4).ToString("X2"), 1) <> "D" Then '2016.2.15 == "C" -> <>"D" 
            udtFUMENU.int単価 = bTmp(0).ToString("X2") & bTmp(1).ToString("X2") & bTmp(2).ToString("X2") & Microsoft.VisualBasic.Left(bTmp(3).ToString("X2"), 1) & "." & Microsoft.VisualBasic.Right(bTmp(3).ToString("X2"), 1) & Microsoft.VisualBasic.Left(bTmp(4).ToString("X2"), 1) 'PRICE
        Else
            udtFUMENU.int単価 = "-" & bTmp(0).ToString("X2") & bTmp(1).ToString("X2") & bTmp(2).ToString("X2") & Microsoft.VisualBasic.Left(bTmp(3).ToString("X2"), 1) & "." & Microsoft.VisualBasic.Right(bTmp(3).ToString("X2"), 1) & Microsoft.VisualBasic.Left(bTmp(4).ToString("X2"), 1) 'PRICE
        End If

        ReDim bTmp(4) '9
        FileGet(intFile, bTmp)

        ReDim bTmp(4) '10
        FileGet(intFile, bTmp)

        ReDim bTmp(0) '11
        FileGet(intFile, bTmp)

        ReDim bTmp(0) '12
        FileGet(intFile, bTmp)
        udtFUMENU.intメニュータイプ = bTmp(0) And &H7 'STATUS (2015.10.1 &H17->&H07に変更)

        ReDim bTmp(0) '13
        FileGet(intFile, bTmp)

        ReDim bTmp(3) '14
        FileGet(intFile, bTmp)
        udtFUMENU.str出力先ＫＰ = Convert.ToString(Integer.Parse(bTmp(0)), 2).PadLeft(8, "0") & _
            Convert.ToString(Integer.Parse(bTmp(1)), 2).PadLeft(8, "0") & _
            Convert.ToString(Integer.Parse(bTmp(2)), 2).PadLeft(8, "0") & _
            Convert.ToString(Integer.Parse(bTmp(3)), 2).PadLeft(8, "0") 'KCPSTATUS

        ReDim bTmp(0) '15
        FileGet(intFile, bTmp)

        ReDim bTmp(0) '16
        FileGet(intFile, bTmp)
        If ((bTmp(0) And &H10) <> 0) Then
            udtFUMENU.strCCPItem = "0"
        Else
            udtFUMENU.strCCPItem = "1"
        End If

        ReDim bTmp(0) '17
        FileGet(intFile, bTmp)

        ReDim bTmp(0) '18
        udtFUMENU.strオプション = ""
        For i As Integer = 1 To 12
            FileGet(intFile, bTmp)
            If i <> 12 Then
                udtFUMENU.strオプション = udtFUMENU.strオプション & bTmp(0).ToString.PadLeft(3, "0") & "," 'SCPNO
            Else
                udtFUMENU.strオプション = udtFUMENU.strオプション & bTmp(0).ToString.PadLeft(3, "0") 'SCPNO
            End If
        Next

        ReDim bTmp(0) '19
        FileGet(intFile, bTmp)

        ReDim bTmp(0) '20
        FileGet(intFile, bTmp)

        ReDim bTmp(0) '21
        FileGet(intFile, bTmp)

        ReDim bTmp(0) '22
        FileGet(intFile, bTmp)

        ReDim bTmp(4) '23
        FileGet(intFile, bTmp)

        ReDim bTmp(4) '24
        FileGet(intFile, bTmp)

        ReDim bTmp(4) '25
        FileGet(intFile, bTmp)

        ReDim bTmp(4) '26
        FileGet(intFile, bTmp)

        ImportTECData_readFUMENU = udtFUMENU

    End Function

    Function ImportTECData_readFSCP(ByVal intFile As Short) As typSCPData

        Dim bTmp() As Byte
        Dim udtFSCP As typSCPData = Nothing

        ReDim bTmp(0) '1
        FileGet(intFile, bTmp)
        Dim Scpno As String = bTmp(0)
        udtFSCP.strSCPNo = Scpno.PadLeft(3, "0") 'SCPNO

        ReDim bTmp(19) '2
        FileGet(intFile, bTmp)
        udtFSCP.strガイダンス = Trim$(System.Text.Encoding.GetEncoding(932).GetString(bTmp)) 'GUIDE
        If udtFSCP.strガイダンス = "" Then udtFSCP.strガイダンス = " "

        ReDim bTmp(1) 'MENU1-16
        udtFSCP.str商品コード = ""
        For i As Integer = 1 To 16
            FileGet(intFile, bTmp)
            If i <> 16 Then
                udtFSCP.str商品コード = udtFSCP.str商品コード & bTmp(0).ToString("X2") & "" & bTmp(1).ToString("X2") & ","
            Else
                udtFSCP.str商品コード = udtFSCP.str商品コード & bTmp(0).ToString("X2") & "" & bTmp(1).ToString("X2")
            End If
        Next

        ImportTECData_readFSCP = udtFSCP

    End Function

    '--- DB追加、更新、削除処理 ---------------------------

    Function ImportTECData_INSERT_TPM010(ByVal pArgs As typItemData2) As Boolean
        Dim strSQL As String
        Dim strWork() As String

        ImportTECData_INSERT_TPM010 = False

        strWork = Split(pArgs.strオプション, ",")
        If strWork.GetUpperBound(0) <> 11 Then
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM010 VALUES("
        strSQL = strSQL & "'" & pArgs.str商品コード.PadRight(5) & "',"               ' // GOODSCD
        strSQL = strSQL & "'" & pArgs.str商品名１ & "',"                 ' ＴＰ商品名１   // str商品名１ or str商品名2  ----- ???
        strSQL = strSQL & "' ',"                 ' ＴＰ商品名２
        strSQL = strSQL & "' ',"                 ' ＰＯＳ商品名１
        strSQL = strSQL & "'" & pArgs.str商品名１ & "',"                 ' ＰＯＳ商品名２
        strSQL = strSQL & "' ',"                           ' 説明文
        strSQL = strSQL & "'" & Space(100) & "',"                           ' 画像データ
        strSQL = strSQL & "'" & CLng(pArgs.int単価) & "',"                  ' 単価額  // PRICE
        strSQL = strSQL & "' ',"                             ' 単位
        strSQL = strSQL & "'0',"                                            ' 品切れフラグ
        strSQL = strSQL & "'" & strWork(0) & "',"                             ' ＳＣＰ№１ // SCPNO01
        strSQL = strSQL & "'" & strWork(1) & "',"                             ' ＳＣＰ№２ // SCPNO02
        strSQL = strSQL & "'" & strWork(2) & "',"                             ' ＳＣＰ№３ // SCPNO03
        strSQL = strSQL & "'" & strWork(3) & "',"                             ' ＳＣＰ№４ // SCPNO04
        strSQL = strSQL & "'" & strWork(4) & "',"                             ' ＳＣＰ№５ // SCPNO05
        strSQL = strSQL & "'" & strWork(5) & "',"                             ' ＳＣＰ№６ // SCPNO06
        strSQL = strSQL & "'" & strWork(6) & "',"                             ' ＳＣＰ№７ // SCPNO07
        strSQL = strSQL & "'" & strWork(7) & "',"                             ' ＳＣＰ№８ // SCPNO08
        strSQL = strSQL & "'" & strWork(8) & "',"                             ' ＳＣＰ№９ // SCPNO09
        strSQL = strSQL & "'" & strWork(9) & "',"                             ' ＳＣＰ№１０ // SCPNO10
        strSQL = strSQL & "'" & strWork(10) & "',"                            ' ＳＣＰ№１１ // SCPNO11
        strSQL = strSQL & "'" & strWork(11) & "',"                            ' ＳＣＰ№１２ // SCPNO12
        Select Case CInt(pArgs.intメニュータイプ)                             ' 商品ステータス     // STATUS
            Case 0 'CNL1910.ITEM_TYPE.MAIN_MENU and &H01
                strSQL = strSQL & "'0',"
            Case 1 'CNL1910.ITEM_TYPE.COMMENT_MENU and &H01
                strSQL = strSQL & "'1',"
            Case 2 'CNL1910.ITEM_TYPE.SUB_MENU and &H01
                strSQL = strSQL & "'2',"
            Case 4 'CNL1910.ITEM_TYPE.SET_MENU and &H01
                strSQL = strSQL & "'3',"
            Case Else
                Exit Function
        End Select
        strSQL = strSQL & "'1',"                                            ' 商品分類
        strSQL = strSQL & "'" & pArgs.str部門コード & "',"                   ' 部門コード           // BUMONCD
        strSQL = strSQL & "'" & pArgs.str出力先ＫＰ & "',"                   ' ＫＣＰステータス      // KCPSTATUS
        strSQL = strSQL & "'0',"                             ' 画像再生成フラグ  //GENERATEFLG
        strSQL = strSQL & "'" & pArgs.strＨＴＬ名称1 & "',"                             ' HTL名称１            // HTLNM1  ---- ???strＨＴＬ名称1
        strSQL = strSQL & "'" & pArgs.strＨＴＬ名称2 & "',"                             ' HTL名称２            // HTLNM2  ---- ???
        strSQL = strSQL & "'0',"                                            ' おすすめフラグ
        strSQL = strSQL & "'0',"                                            ' 新作フラグ
        strSQL = strSQL & "'CNL1911ins',"
        strSQL = strSQL & "'" & Now & "')"

        ImportTECData_INSERT_TPM010 = GF_UpdData(strSQL)

    End Function

    Function ImportTECData_UPDATE_TPM010(ByVal pArgs As typItemData2) As Boolean

        Dim strSQL As String
        Dim strWork() As String

        ImportTECData_UPDATE_TPM010 = False

        strWork = Split(pArgs.strオプション, ",")
        If strWork.GetUpperBound(0) <> 11 Then
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM010 SET"
        strSQL = strSQL & " TPM010.GOODSNMJ = '" & pArgs.str商品名１ & "',"
        strSQL = strSQL & " TPM010.GOODSNMJ2 = ' ',"
        strSQL = strSQL & " TPM010.GOODSNMJ4 = '" & pArgs.str商品名１ & "',"
        strSQL = strSQL & " TPM010.PRICE = '" & CLng(pArgs.int単価) & "',"
        strSQL = strSQL & " TPM010.SCPNO01 = '" & strWork(0) & "',"
        strSQL = strSQL & " TPM010.SCPNO02 = '" & strWork(1) & "',"
        strSQL = strSQL & " TPM010.SCPNO03 = '" & strWork(2) & "',"
        strSQL = strSQL & " TPM010.SCPNO04 = '" & strWork(3) & "',"
        strSQL = strSQL & " TPM010.SCPNO05 = '" & strWork(4) & "',"
        strSQL = strSQL & " TPM010.SCPNO06 = '" & strWork(5) & "',"
        strSQL = strSQL & " TPM010.SCPNO07 = '" & strWork(6) & "',"
        strSQL = strSQL & " TPM010.SCPNO08 = '" & strWork(7) & "',"
        strSQL = strSQL & " TPM010.SCPNO09 = '" & strWork(8) & "',"
        strSQL = strSQL & " TPM010.SCPNO10 = '" & strWork(9) & "',"
        strSQL = strSQL & " TPM010.SCPNO11 = '" & strWork(10) & "',"
        strSQL = strSQL & " TPM010.SCPNO12 = '" & strWork(11) & "',"
        Select Case CInt(pArgs.intメニュータイプ)
            Case 0 'CNL1910.ITEM_TYPE.MAIN_MENU and &H01
                strSQL = strSQL & " TPM010.STATUS = '0',"
            Case 1 'CNL1910.ITEM_TYPE.COMMENT_MENU and &H01
                strSQL = strSQL & " TPM010.STATUS = '1',"
            Case 2 'CNL1910.ITEM_TYPE.SUB_MENU and &H01
                strSQL = strSQL & " TPM010.STATUS = '2',"
            Case 4 'CNL1910.ITEM_TYPE.SET_MENU and &H01
                strSQL = strSQL & " TPM010.STATUS = '3',"
            Case Else
                Exit Function
        End Select
        strSQL = strSQL & " TPM010.BUMONCD = '" & pArgs.str部門コード & "',"
        strSQL = strSQL & " TPM010.KCPSTATUS = '" & pArgs.str出力先ＫＰ & "',"
        strSQL = strSQL & " TPM010.HTLNM1 = '" & pArgs.strＨＴＬ名称1 & "',"
        strSQL = strSQL & " TPM010.HTLNM2 = '" & pArgs.strＨＴＬ名称2 & "',"
        strSQL = strSQL & " TPM010.UPDID = 'CNL1911upd',"
        strSQL = strSQL & " TPM010.UPDYMD = '" & Now & "'"
        strSQL = strSQL & " WHERE TPM010.GOODSCD = '" & pArgs.str商品コード & "'"

        ImportTECData_UPDATE_TPM010 = GF_UpdData(strSQL)

    End Function

    Function ImportTECData_DELETE_TPM010(ByVal strGoodScd As String) As Boolean

        Dim strSQL As String
        strSQL = ""
        strSQL = strSQL & "DELETE TPM010 WHERE TPM010.GOODSCD = '" & strGoodScd & "'"

        ImportTECData_DELETE_TPM010 = GF_UpdData(strSQL)

    End Function

    Function ImportTECData_INSERT_TPM100(ByVal pArgs As typSCPData) As Boolean

        Dim strSQL As String
        Dim strWork() As String = Nothing

        ImportTECData_INSERT_TPM100 = False

        strWork = Split(pArgs.str商品コード, ",")
        If strWork.GetUpperBound(0) <> 15 Then
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM100 VALUES("
        strSQL = strSQL & "'" & pArgs.strSCPNo & "',"            ' SCPNO
        strSQL = strSQL & "'" & pArgs.strガイダンス & "',"        ' GUIDE
        strSQL = strSQL & "'" & strWork(0) & "',"                ' GOODSCD1
        strSQL = strSQL & "'" & strWork(1) & "',"                ' GOODSCD2
        strSQL = strSQL & "'" & strWork(2) & "',"                ' GOODSCD3
        strSQL = strSQL & "'" & strWork(3) & "',"                 ' GOODSCD4
        strSQL = strSQL & "'" & strWork(4) & "',"                 ' GOODSCD5
        strSQL = strSQL & "'" & strWork(5) & "',"                 ' GOODSCD6
        strSQL = strSQL & "'" & strWork(6) & "',"                 ' GOODSCD7
        strSQL = strSQL & "'" & strWork(7) & "',"                 ' GOODSCD8
        strSQL = strSQL & "'" & strWork(8) & "',"                 ' GOODSCD9
        strSQL = strSQL & "'" & strWork(9) & "',"                 ' GOODSCD10
        strSQL = strSQL & "'" & strWork(10) & "',"                 ' GOODSCD11
        strSQL = strSQL & "'" & strWork(11) & "',"                 ' GOODSCD12
        strSQL = strSQL & "'" & strWork(12) & "',"                 ' GOODSCD13
        strSQL = strSQL & "'" & strWork(13) & "',"                 ' GOODSCD14
        strSQL = strSQL & "'" & strWork(14) & "',"                 ' GOODSCD15
        strSQL = strSQL & "'" & strWork(15) & "',"                 ' GOODSCD16
        strSQL = strSQL & "'CNL1911ins',"
        strSQL = strSQL & "'" & Now & "')"          ' UPDYMD

        ImportTECData_INSERT_TPM100 = GF_UpdData(strSQL)

    End Function

    Function ImportTECData_UPDATE_TPM100(ByVal pArgs As typSCPData) As Boolean

        Dim strSQL As String
        Dim strWork() As String = Nothing

        ImportTECData_UPDATE_TPM100 = False

        strWork = Split(pArgs.str商品コード, ",")
        If strWork.GetUpperBound(0) <> 15 Then
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM100 SET TPM100.GUIDE  = '" & pArgs.strガイダンス & "',"
        strSQL = strSQL & " TPM100.GOODSCD1 = '" & strWork(0) & "',"
        strSQL = strSQL & " TPM100.GOODSCD2 = '" & strWork(1) & "',"
        strSQL = strSQL & " TPM100.GOODSCD3 = '" & strWork(2) & "',"
        strSQL = strSQL & " TPM100.GOODSCD4 = '" & strWork(3) & "',"
        strSQL = strSQL & " TPM100.GOODSCD5 = '" & strWork(4) & "',"
        strSQL = strSQL & " TPM100.GOODSCD6 = '" & strWork(5) & "',"
        strSQL = strSQL & " TPM100.GOODSCD7 = '" & strWork(6) & "',"
        strSQL = strSQL & " TPM100.GOODSCD8 = '" & strWork(7) & "',"
        strSQL = strSQL & " TPM100.GOODSCD9 = '" & strWork(8) & "',"
        strSQL = strSQL & " TPM100.GOODSCD10 = '" & strWork(9) & "',"
        strSQL = strSQL & " TPM100.GOODSCD11 = '" & strWork(10) & "',"
        strSQL = strSQL & " TPM100.GOODSCD12 = '" & strWork(11) & "',"
        strSQL = strSQL & " TPM100.GOODSCD13 = '" & strWork(12) & "',"
        strSQL = strSQL & " TPM100.GOODSCD14 = '" & strWork(13) & "',"
        strSQL = strSQL & " TPM100.GOODSCD15 = '" & strWork(14) & "',"
        strSQL = strSQL & " TPM100.GOODSCD16 = '" & strWork(15) & "',"
        strSQL = strSQL & " TPM100.UPDID = 'CNL1911upd',"
        strSQL = strSQL & " TPM100.UPDYMD = '" & Now & "'"
        strSQL = strSQL & " WHERE TPM100.SCPNO = '" & pArgs.strSCPNo & "'"

        ImportTECData_UPDATE_TPM100 = GF_UpdData(strSQL)

    End Function

    Function ImportTECData_DELETE_TPM100(ByVal strSCPNO As String) As Boolean

        Dim strSQL As String

        strSQL = ""
        strSQL = strSQL & "DELETE TPM100 WHERE TPM100.SCPNO = '" & strSCPNO & "'"

        ImportTECData_DELETE_TPM100 = GF_UpdData(strSQL)

    End Function

    Function ImportTECData_INSERT_TPM250(ByVal pArgs As typItemData2) As Boolean

        Dim strSQL As String

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM250 VALUES("
        strSQL = strSQL & "'" & pArgs.str商品コード.PadRight(5) & "',"               ' // GOODSCD
        strSQL = strSQL & "'" & pArgs.strCCPItem & "',"  ' CCPステータス
        strSQL = strSQL & "'CNL1911ins',"
        strSQL = strSQL & "'" & Now & "')"

        ImportTECData_INSERT_TPM250 = GF_UpdData(strSQL)

    End Function

    Function ImportTECData_UPDATE_TPM250(ByVal pArgs As typItemData2) As Boolean

        Dim strSQL As String

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM250 SET"
        strSQL = strSQL & " TPM250.CCPENABLED = '" & pArgs.strCCPItem & "',"
        strSQL = strSQL & " TPM250.UPDID = 'CNL1911upd',"
        strSQL = strSQL & " TPM250.UPDYMD = '" & Now & "'"
        strSQL = strSQL & " WHERE TPM250.GOODSCD = '" & pArgs.str商品コード & "'"

        ImportTECData_UPDATE_TPM250 = GF_UpdData(strSQL)

    End Function

    Function ImportTECData_DELETE_TPM250(ByVal strGoodScd As String) As Boolean

        Dim strSQL As String

        strSQL = ""
        strSQL = strSQL & "DELETE TPM250 WHERE TPM250.GOODSCD = '" & strGoodScd & "'"

        ImportTECData_DELETE_TPM250 = GF_UpdData(strSQL)

    End Function

    '--- 削除レコードのバックアップ処理 ---------------------------

    Function ImportTECData_TableBackup(ByVal strExpPath As String) As Boolean

        Dim strTableNames() As String = {"TPM010", "TPM100", "TPM250"}
        Dim intCnt As Integer
        Dim intProcID As Integer
        Dim strCmdLine As String

        ImportTECData_TableBackup = False

        Try
            For intCnt = 0 To UBound(strTableNames)
                strCmdLine = ""
                strCmdLine = strCmdLine & "BCP"
                strCmdLine = strCmdLine & " " & strTableNames(intCnt) ' 退避テーブル名
                strCmdLine = strCmdLine & " out"                                                ' エクスポート指定
                strCmdLine = strCmdLine & " """ & strExpPath & "\" & strTableNames(intCnt) & "_取込前.txt"""  ' 退避ファイル名
                strCmdLine = strCmdLine & " -S " & g_udtAppConfig.strDBServerName
                strCmdLine = strCmdLine & " -U " & g_udtAppConfig.strDBServerUserID
                strCmdLine = strCmdLine & " -P " & g_udtAppConfig.strDBServerPassWD

                strCmdLine = strCmdLine & " -c -t ,"

                Debug.WriteLine(strCmdLine)
                intProcID = Shell("cmd.exe /C " & strCmdLine, AppWinStyle.Hide, True)

                If intProcID <> 0 Then
                    Exit Function
                End If
            Next intCnt
        Catch
            Exit Function
        End Try

        ImportTECData_TableBackup = True

    End Function

    Function ImportTECData_ExcerptDeletedFromTPM010CSV(ByVal strExpPath As String, ByVal strGOODSCDs As List(Of String)) As Boolean

        Dim strBackupFilePath As String
        Dim strDeleteFilePath As String

        ImportTECData_ExcerptDeletedFromTPM010CSV = False

        strBackupFilePath = strExpPath & "\" & "TPM010_取込前.txt"
        strDeleteFilePath = strExpPath & "\" & "TPM010_削除.txt"

        ImportTECData_ExcerptDeletedFromTPM010CSV = ImportTECData_ExcerptDeletedFromCSV(strBackupFilePath, strDeleteFilePath, strGOODSCDs)

    End Function

    Function ImportTECData_ExcerptDeletedFromTPM100CSV(ByVal strExpPath As String, ByVal strSCPNOs As List(Of String)) As Boolean

        Dim strBackupFilePath As String
        Dim strDeleteFilePath As String

        ImportTECData_ExcerptDeletedFromTPM100CSV = False

        strBackupFilePath = strExpPath & "\" & "TPM100_取込前.txt"
        strDeleteFilePath = strExpPath & "\" & "TPM100_削除.txt"

        ImportTECData_ExcerptDeletedFromTPM100CSV = ImportTECData_ExcerptDeletedFromCSV(strBackupFilePath, strDeleteFilePath, strSCPNOs)

    End Function

    Function ImportTECData_ExcerptDeletedFromTPM250CSV(ByVal strExpPath As String, ByVal strGOODSCDs As List(Of String)) As Boolean

        Dim strBackupFilePath As String
        Dim strDeleteFilePath As String

        ImportTECData_ExcerptDeletedFromTPM250CSV = False

        strBackupFilePath = strExpPath & "\" & "TPM250_取込前.txt"
        strDeleteFilePath = strExpPath & "\" & "TPM250_削除.txt"

        ImportTECData_ExcerptDeletedFromTPM250CSV = ImportTECData_ExcerptDeletedFromCSV(strBackupFilePath, strDeleteFilePath, strGOODSCDs)

    End Function

    Function ImportTECData_ExcerptDeletedFromCSV(ByVal strBackupFilePath As String, ByVal strDeleteFilePath As String, ByVal strCDs As List(Of String)) As Boolean

        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim CSVlinesIn As New ArrayList
        Dim CSVout As New List(Of String)
        Dim enc As System.Text.Encoding

        ImportTECData_ExcerptDeletedFromCSV = False

        Try
            enc = System.Text.Encoding.GetEncoding(932)
            CSVlinesIn.AddRange(IO.File.ReadAllLines(strBackupFilePath, enc))

            For Each line As String In CSVlinesIn
                Dim codeFSCP As String() = line.Split(",")
                If strCDs.Contains(Trim$(codeFSCP(0))) Then
                    CSVout.Add(line)
                End If
            Next
            IO.File.WriteAllLines(strDeleteFilePath, CSVout.ToArray, enc)
        Catch
            Exit Function
        End Try

        ImportTECData_ExcerptDeletedFromCSV = True

    End Function

    '--- 文字列の切り出し(最後の1バイトが全角文字の半分になる場合、その1バイトを切り捨てる) ---------------------------

    Public Function MidB(ByVal str As String, ByVal start As Integer, ByVal length As Integer, ByRef omitDone As Boolean) As String

        omitDone = False

        Dim SJIS As System.Text.Encoding = System.Text.Encoding.GetEncoding(932)
        Dim B() As Byte = CType(Array.CreateInstance(GetType(Byte), length), Byte())

        Array.Copy(SJIS.GetBytes(str), start - 1, B, 0, length)

        Dim st1 As String = SJIS.GetString(B)

        Dim ResultLength As Integer = System.Text.Encoding.GetEncoding(932).GetByteCount(st1) '- start + 1 2016.2.15

        If length = ResultLength - 1 Then
            omitDone = True
            MidB = st1.Substring(0, st1.Length - 1)
        Else
            MidB = st1
        End If

    End Function

End Module
