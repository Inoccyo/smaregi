''' <summary>
''' CrossNavi - 放題コース登録画面
''' </summary>
''' <remarks>2013.03.05 クレスコ北陸 新規作成</remarks>
Public Class CNL2141
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Title As System.Windows.Forms.TextBox
    Friend WithEvents btn_OK As System.Windows.Forms.Button
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_Title = New System.Windows.Forms.TextBox
        Me.btn_OK = New System.Windows.Forms.Button
        Me.btn_Cancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "■ 放題コース名称を入力してください"
        '
        'txt_Title
        '
        Me.txt_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Title.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_Title.Location = New System.Drawing.Point(24, 37)
        Me.txt_Title.MaxLength = 20
        Me.txt_Title.Name = "txt_Title"
        Me.txt_Title.Size = New System.Drawing.Size(360, 22)
        Me.txt_Title.TabIndex = 1
        Me.txt_Title.Text = "txt_Title"
        '
        'btn_OK
        '
        Me.btn_OK.BackColor = System.Drawing.SystemColors.Control
        Me.btn_OK.Location = New System.Drawing.Point(120, 73)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(72, 32)
        Me.btn_OK.TabIndex = 2
        Me.btn_OK.Text = "決定"
        Me.btn_OK.UseVisualStyleBackColor = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Cancel.Location = New System.Drawing.Point(200, 73)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(72, 32)
        Me.btn_Cancel.TabIndex = 3
        Me.btn_Cancel.Text = "キャンセル"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'CNL2141
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(416, 117)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.txt_Title)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CNL2141"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "JCV01_4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ''' <summary>
    ''' フォーム読み込み時処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CNL2141_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' フォーム初期化
        '------------------------------
        Me.Text = GF_FormText()
        txt_Title.Clear()

    End Sub

    ''' <summary>
    ''' [決定]ボタン押下時処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click

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
        If Not LF_InsertNewCourse() Then
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
    Private Function LF_InsertNewCourse() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()
        Dim strNewID As String = Nothing
        Dim strCnt As String = Nothing

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
        strSQL = strSQL & "0,"                                              ' 単価額
        strSQL = strSQL & "'" & Space(5) & "',"                             ' 単位
        strSQL = strSQL & "'0',"                             ' 品切れフラグ
        strSQL = strSQL & "'000',"                             ' ＳＣＰ�ｂP
        strSQL = strSQL & "'000',"                             ' ＳＣＰ�ｂQ
        strSQL = strSQL & "'000',"                             ' ＳＣＰ�ｂR
        strSQL = strSQL & "'000',"                             ' ＳＣＰ�ｂS
        strSQL = strSQL & "'000',"                             ' ＳＣＰ�ｂT
        strSQL = strSQL & "'000',"                             ' ＳＣＰ�ｂU
        strSQL = strSQL & "'000',"                             ' ＳＣＰ�ｂV
        strSQL = strSQL & "'000',"                             ' ＳＣＰ�ｂW
        strSQL = strSQL & "'000',"                             ' ＳＣＰ�ｂX
        strSQL = strSQL & "'000',"                             ' ＳＣＰ�ｂP０
        strSQL = strSQL & "'000',"                             ' ＳＣＰ�ｂP１
        strSQL = strSQL & "'000',"                             ' ＳＣＰ�ｂP２
        strSQL = strSQL & "'0',"                             ' 商品ステータス
        strSQL = strSQL & "'3',"                             ' 商品分類
        strSQL = strSQL & "'" & GF_GetBumon() & "',"         ' 部門コード
        strSQL = strSQL & "'00000000000000000000000000000000',"             ' ＫＣＰステータス
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
        strSQL = strSQL & "0,"                  ' 食べ飲み放題時間
        strSQL = strSQL & "'0'," ' 食べ飲み放題コースグループID
        strSQL = strSQL & "'" & GC_UPDID & "',"
        strSQL = strSQL & "'" & Now & "')"

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        ' 食べ飲み放題コースマスタ登録
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM300 VALUES("
        strSQL = strSQL & "'" & strNewID.PadRight(5) & "',"
        strSQL = strSQL & "1,"                  ' ラストオーダー時間
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
