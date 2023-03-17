Public Class CNL2142
    Inherits System.Windows.Forms.Form

    ''' <summary>
    ''' フォーム読み込み時処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CNL2142_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' フォーム初期化
        '------------------------------
        Me.Text = GF_FormText()
        txt_Title.Clear()

        '------------------------------
        ' 放題コースリスト作成
        '------------------------------
        Call LS_SetFreeMenuList()

    End Sub

    ''' <summary>
    ''' [決定]ボタン押下時処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click

        Dim strFreeMenuCD As String

        '------------------------------
        ' 事前情報収集
        '------------------------------
        If lst_FreeMenu.SelectedIndex = -1 Then
            Call GF_Msg("E10", "", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            Exit Sub
        Else
            strFreeMenuCD = GF_LstGetCode(lst_FreeMenu, lst_FreeMenu.SelectedIndex)
        End If

        '------------------------------
        ' 未入力チェック
        '------------------------------
        If Len(Trim$(txt_Title.Text)) = 0 Then
            Call GF_Msg("", Replace(GF_GetMsg("E09"), "@@@", "コース名称"), MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            txt_Title.Select()
            Exit Sub
        End If

        '------------------------------
        ' 同一名称の放題コースが既に存在している場合は、エラーメッセージを表示して、処理を中断させる
        '------------------------------
        Select Case LF_GetTPM010Houdai(Trim$(txt_Title.Text))
            Case CNL1920.FuncResult.CancelEnd
                ' 存在するので、エラー 
                Call GF_Msg("", "既に【" & Trim$(txt_Title.Text) & "】が存在するため、使用できません。" & vbCrLf & "他のコース名称を入力して下さい。", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                Exit Sub

            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        '------------------------------
        ' 放題コース追加処理
        '------------------------------
        If Not LF_InsertNewCourse(strFreeMenuCD) Then
            GoTo SYSTEM_ERROR
        End If

        With Me
            .DialogResult = DialogResult.OK
            .Close()
        End With

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_OK_Click")
    End Sub

    ''' <summary>
    ''' 同一放題コース名称存在チェック処理
    ''' </summary>
    ''' <param name="pHoudaiNM"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_GetTPM010Houdai(ByVal pHoudaiNM As String) As FuncResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM010Houdai = CNL1920.FuncResult.UnusualEnd

        strSQL = ""
        strSQL = strSQL & "SELECT GOODSCD"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " WHERE GOODSNMJ + GOODSNMJ2 = '" & pHoudaiNM & "'"
        strSQL = strSQL & "   AND SUBSTRING(GOODSCD,1,1) = '7'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        If objData.Tables("com").Rows.Count = 0 Then
            LF_GetTPM010Houdai = CNL1920.FuncResult.NormalEnd
        Else
            LF_GetTPM010Houdai = CNL1920.FuncResult.CancelEnd
        End If

    End Function

    ''' <summary>
    ''' [キャンセル]ボタン押下時処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        With Me
            .DialogResult = DialogResult.Cancel
            .Close()
        End With
    End Sub

    ''' <summary>
    ''' 放題コース追加処理
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_InsertNewCourse(ByVal pFreeGoodsCD As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()
        Dim strNewID As String = Nothing
        Dim strCnt As String = Nothing
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim intCnt As Integer
        Dim strFREETIME As Integer
        Dim strFREEGROUPID As String
        Dim strPrice As Integer
        Dim strKCPSTATUS As String
        Dim strLastCallTime As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_InsertNewCourse = False

        '------------------------------
        ' TPM010カウント取得
        '------------------------------
        Select Case GF_GetCntTPM010(strCnt)
            Case CNL1920.FuncResult.CancelEnd
                GF_Msg("", "商品登録数が上限に達しました。いずれかのコースを削除して下さい。", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                LF_InsertNewCourse = True
                Exit Function

            Case CNL1920.FuncResult.UnusualEnd
                Exit Function
        End Select

        '------------------------------
        ' 最終ＩＤ取得
        '------------------------------
        Select Case GF_GetNewCourseID(strNewID)
            Case CNL1920.FuncResult.CancelEnd
                GF_Msg("", "コース登録数が上限に達しました。いずれかのコースを削除して下さい。", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                LF_InsertNewCourse = True
                Exit Function

            Case CNL1920.FuncResult.UnusualEnd
                Exit Function
        End Select

        '-----------------------------------------
        'コピー元放題コースマスタ情報収集（TPM170）
        '-----------------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM TPM170"
        strSQL = strSQL & " WHERE FREECOURSEGOODSCD = '" & pFreeGoodsCD & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If Not GF_GetRows(objData, intCnt, objRows) Then
            Exit Function
        End If

        strFREETIME = objRows("FREETIME")
        strFREEGROUPID = objRows("FREEGROUPID")

        '-----------------------------------------
        'コピー元放題コースマスタ情報収集（TPM010）
        '-----------------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " WHERE GOODSCD = '" & pFreeGoodsCD & "'"

        objData = New DataSet()
        objRows = Nothing
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If Not GF_GetRows(objData, intCnt, objRows) Then
            Exit Function
        End If

        strPrice = objRows("PRICE")
        strKCPSTATUS = objRows("KCPSTATUS")

        '-----------------------------------------
        'コピー元放題コースマスタ情報収集（TPM300）
        '-----------------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM TPM300"
        strSQL = strSQL & " WHERE FREECOURSEGOODSCD = '" & pFreeGoodsCD & "'"

        objData = New DataSet()
        objRows = Nothing
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If Not GF_GetRows(objData, intCnt, objRows) Then
            Exit Function
        End If

        strLastCallTime = objRows("LASTCALLTIME")

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        ' 商品マスタ登録
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM010 VALUES("
        strSQL = strSQL & "'" & strNewID.PadRight(5) & "',"
        strSQL = strSQL & "'" & Mid(txt_Title.Text, 1, 10) & "',"                 ' ＴＰ商品名１
        strSQL = strSQL & "'" & IIf(Mid(txt_Title.Text, 11, 20) = "", Space(20), Mid(txt_Title.Text, 11, 20)) & "',"              ' ＴＰ商品名２
        strSQL = strSQL & "'" & Mid(txt_Title.Text, 1, 10) & "',"                 ' ＰＯＳ商品名１
        strSQL = strSQL & "'" & Mid(txt_Title.Text, 1, 10) & "',"                 ' ＰＯＳ商品名２
        strSQL = strSQL & "'" & Space(180) & "',"                           ' 説明文
        strSQL = strSQL & "'" & Space(100) & "',"                           ' 画像データ
        strSQL = strSQL & strPrice & ","                                    ' 単価額
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
        strSQL = strSQL & "'3',"                             ' 商品分類
        strSQL = strSQL & "'" & GF_GetBumon() & "',"         ' 部門コード
        strSQL = strSQL & "'" & strKCPSTATUS & "',"             ' ＫＣＰステータス
        strSQL = strSQL & "'0',"                                            ' 画像再生成フラグ
        strSQL = strSQL & "'" & Space(5) & "',"                             ' HTL名称１
        strSQL = strSQL & "'" & Space(5) & "',"                             ' HTL名称２
        strSQL = strSQL & "'0',"                                            ' おすすめフラグ
        strSQL = strSQL & "'0',"                                            ' 新作フラグ
        strSQL = strSQL & "'" & GC_UPDID & "',"
        strSQL = strSQL & "'" & Now & "')"

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        '多言語機能対応
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then

            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM010A VALUES("
            strSQL = strSQL & "N'" & strNewID.PadRight(5) & "',"
            strSQL = strSQL & "N'" & Space(10) & "',"              ' ＴＰ商品名１
            strSQL = strSQL & "N'" & Space(10) & "',"              ' ＴＰ商品名２
            strSQL = strSQL & "N'" & Space(180) & "',"             ' 説明文
            strSQL = strSQL & "N'" & GC_UPDID & "',"
            strSQL = strSQL & "N'" & Now & "')"

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM010B VALUES("
            strSQL = strSQL & "N'" & strNewID.PadRight(5) & "',"
            strSQL = strSQL & "N'" & Space(10) & "',"              ' ＴＰ商品名１
            strSQL = strSQL & "N'" & Space(10) & "',"              ' ＴＰ商品名２
            strSQL = strSQL & "N'" & Space(180) & "',"             ' 説明文
            strSQL = strSQL & "N'" & GC_UPDID & "',"
            strSQL = strSQL & "N'" & Now & "')"

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM010C VALUES("
            strSQL = strSQL & "N'" & strNewID.PadRight(5) & "',"
            strSQL = strSQL & "N'" & Space(10) & "',"              ' ＴＰ商品名１
            strSQL = strSQL & "N'" & Space(10) & "',"              ' ＴＰ商品名２
            strSQL = strSQL & "N'" & Space(180) & "',"             ' 説明文
            strSQL = strSQL & "N'" & GC_UPDID & "',"
            strSQL = strSQL & "N'" & Now & "')"

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

        End If

        ' 食べ飲み放題コースマスタ登録
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM170 VALUES("
        strSQL = strSQL & "'" & strNewID.PadRight(5) & "',"
        strSQL = strSQL & strFREETIME & ","                  ' 食べ飲み放題時間
        strSQL = strSQL & "'" & strFREEGROUPID & "',"        ' 食べ飲み放題コースグループID
        strSQL = strSQL & "'" & GC_UPDID & "',"
        strSQL = strSQL & "'" & Now & "')"

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        '-----------------------------------------
        'コピー元放題コースマスタ情報収集（TPM160）
        '-----------------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM TPM160"
        strSQL = strSQL & " WHERE FREECOURSEGOODSCD = '" & pFreeGoodsCD & "'"

        objData = New DataSet()
        objRows = Nothing
        If Not GF_GetData(strSQL, objData) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        If objData.Tables("com").Rows.Count <> 0 Then
            intCnt = 0
            While intCnt < CInt(objData.Tables("com").Rows.Count)

                If Not GF_GetRows(objData, intCnt, objRows) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                ' 食べ飲み放題コースマスタ登録
                strSQL = ""
                strSQL = strSQL & "INSERT INTO TPM160 VALUES("
                strSQL = strSQL & "'" & strNewID.PadRight(5) & "',"
                strSQL = strSQL & "'" & objRows("FREEGOODSCD") & "',"
                strSQL = strSQL & "'" & GC_UPDID & "',"
                strSQL = strSQL & "'" & Now & "')"

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If
                intCnt += 1
            End While
        End If

        ' 食べ飲み放題コースマスタ登録
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM300 VALUES("
        strSQL = strSQL & "'" & strNewID.PadRight(5) & "',"
        strSQL = strSQL & strLastCallTime & ","                  ' ラストオーダー時間
        strSQL = strSQL & "'" & GC_UPDID & "',"
        strSQL = strSQL & "'" & Now & "')"

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM200 VALUES("
        strSQL = strSQL & "'" & strNewID.PadRight(5) & "',"                                                            ' GOODSCD
        strSQL = strSQL & "'" & strNewID.PadRight(5).Substring(0, 1) & strNewID.PadRight(5).Substring(2) & "',"        ' SEARCHNUMBER
        strSQL = strSQL & "'" & GC_UPDID & "',"                                                                        ' UPDID
        strSQL = strSQL & "'" & Now & "')"                                                                             ' UPDYMD

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM330 VALUES("
        strSQL = strSQL & "'" & strNewID.PadRight(5) & "',"                                    ' GOODSCD
        strSQL = strSQL & "'0',"                                                               ' ENABLEDFLG
        strSQL = strSQL & "'" & GC_UPDID & "',"                                                ' UPDID
        strSQL = strSQL & "'" & Now & "')"                                                     ' UPDYMD

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM340 VALUES("
        strSQL = strSQL & "'" & strNewID.PadRight(5) & "',"                                    ' GOODSCD
        strSQL = strSQL & "'0',"                                                               ' COST
        strSQL = strSQL & "'" & GC_UPDID & "',"                                                ' UPDID
        strSQL = strSQL & "'" & Now & "')"                                                     ' UPDYMD

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM350 VALUES("
        strSQL = strSQL & "'" & strNewID.PadRight(5) & "',"                                                ' GOODSCD
        strSQL = strSQL & "'0',"                                                               ' DELIVARYFLG
        strSQL = strSQL & "'" & GC_UPDID & "',"                                                ' UPDID
        strSQL = strSQL & "'" & Now & "')"                                                     ' UPDYMD

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        '------------------------------
        ' トランザクション確定
        '------------------------------
        If Not GF_CommitTrans() Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_InsertNewCourse = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：タイトルテキストボックス変更時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_Title_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Title.TextChanged

        Try
            '------------------------------
            ' 内部変数定義
            '------------------------------
            Dim lngST As Long

            lngST = txt_Title.SelectionStart
            ' 2014-05-12 2バイト文字制限解除
            'txt_Title.Text = StrConv(txt_Title.Text, VbStrConv.Wide)
            If lngST >= 0 Then
                txt_Title.SelectionStart = lngST
            End If

            If GF_LenB(txt_Title.Text) > 50 Then
                txt_Title.Text = GF_MidB(txt_Title.Text, 1, 50)
                txt_Title.SelectionStart = GF_LenB(txt_Title.Text)
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_Title_TextChanged")
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pResultID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GF_GetNewCourseID(ByRef pResultID As String) As FuncResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        pResultID = ""

        '------------------------------
        ' 最終採番値取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TOP 1 GOODSCD "
        strSQL = strSQL & "FROM TPM010 "
        strSQL = strSQL & "WHERE SUBSTRING(GOODSCD,1,1) = '7' "
        strSQL = strSQL & "ORDER BY GOODSCD DESC "

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            pResultID = "7000"
            Return FuncResult.NormalEnd
        End If

        If Not GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        pResultID = CStr(CInt(Trim$(objRows("GOODSCD"))) + 1)

        If CInt(pResultID) > 7999 Then
            Return FuncResult.CancelEnd
        Else
            Return FuncResult.NormalEnd
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告情報選択リストボックス 設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetFreeMenuList()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' 初期値設定
        '------------------------------
        lst_FreeMenu.Items.Clear()

        '------------------------------
        ' 設定データ取得
        '------------------------------
        If Not LF_GetTPM170(objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' データ値設定
        '------------------------------
        Try
            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    GoTo SYSTEM_ERROR
                End If

                Call GS_SetListBox(lst_FreeMenu, Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2")), Trim$(objRows("FREECOURSEGOODSCD")))
                lngCnt = lngCnt + 1
            End While

            '------------------------------
            ' 広告情報選択リストボックス 選択処理
            '------------------------------
            If lst_FreeMenu.SelectedIndex = -1 Then
                If lst_FreeMenu.Items.Count <> 0 Then
                    lst_FreeMenu.SelectedIndex = 0
                End If
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetFreeMenuList")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：飲み放題コースマスタ取得
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM170(ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM170 = False

        '------------------------------
        ' 広告画像情報マスタ 抽出
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM170.FREECOURSEGOODSCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2"
        strSQL = strSQL & "  FROM TPM170, TPM010"
        strSQL = strSQL & " WHERE TPM170.FREECOURSEGOODSCD = TPM010.GOODSCD"

        If Not GF_GetData(strSQL, pDataSet) Then
            Exit Function
        End If

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM170 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：TPM010カウント取得
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：
    ' --------------------------------------------------------------------------------
    Private Function GF_GetCntTPM010(ByRef pCnt As String) As FuncResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim intLimitCnt As Integer

        '------------------------------
        ' 初期値設定
        '------------------------------
        pCnt = ""

        '------------------------------
        ' 最終採番値取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & " SELECT COUNT(*) AS CNT"
        strSQL = strSQL & " FROM TPM010"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        pCnt = CInt(Trim$(objRows("CNT")))

        intLimitCnt = CInt(Trim$(GF_GetAppInfo("LIMIT_GOODS_CNT")))

        If CInt(pCnt) > intLimitCnt Then
            Return FuncResult.CancelEnd
        Else
            Return FuncResult.NormalEnd
        End If

    End Function
End Class