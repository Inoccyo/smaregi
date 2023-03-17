' --------------------------------------------------------------------------------
' 　機　　能：CrossNavi - メニューコピー画面
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：なし
' --------------------------------------------------------------------------------

Public Class CNL1554
    Inherits System.Windows.Forms.Form

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub CNL1554_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' フォーム初期化
        '------------------------------
        Me.Text = GF_FormText()
        txt_Title.Clear()

        '------------------------------
        ' 放題コースリスト作成
        '------------------------------
        Call LS_SetMenuList()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニュー選択リストボックス 設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetMenuList()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long

        '------------------------------
        ' 初期値設定
        '------------------------------
        lst_Menu.Items.Clear()

        '------------------------------
        ' 設定データ取得
        '------------------------------
        If Not LF_GetTPM060(objData) Then
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

                Call GS_SetListBox(lst_Menu, Trim$(objRows("GOODSNMJ")) & Trim$(objRows("GOODSNMJ2")), Trim$(objRows("FREECOURSEGOODSCD")))
                lngCnt = lngCnt + 1
            End While

            '------------------------------
            ' 広告情報選択リストボックス 選択処理
            '------------------------------
            If lst_Menu.SelectedIndex = -1 Then
                If lst_Menu.Items.Count <> 0 Then
                    lst_Menu.SelectedIndex = 0
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
    Private Function LF_GetTPM060(ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM060 = False

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
        LF_GetTPM060 = True

    End Function
End Class