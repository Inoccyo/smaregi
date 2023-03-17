' --------------------------------------------------------------------------------
' 　機　　能：CrossNavi - 商品番号新規追加画面
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
' --------------------------------------------------------------------------------
Public Class CNL2031
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
        Me.Label1.Text = "■ 商品番号を入力してください"
        '
        'txt_Title
        '
        Me.txt_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Title.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_Title.Location = New System.Drawing.Point(65, 37)
        Me.txt_Title.Name = "txt_Title"
        Me.txt_Title.Size = New System.Drawing.Size(320, 22)
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
        'CNL2031
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
        Me.Name = "CNL2031"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CNL2031"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub CNL2031_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' フォーム初期化
        '------------------------------
        Me.Text = GF_FormText()
        txt_Title.Clear()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：決定ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------

        '------------------------------
        ' 未入力チェック
        '------------------------------
        If Len(Trim$(txt_Title.Text)) = 0 Then
            Call GF_Msg("E01", "", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            txt_Title.Select()
            Exit Sub
        End If

        '------------------------------
        ' 書式チェック
        '------------------------------
        If IsNumeric(Trim$(txt_Title.Text)) = False Then
            Call GF_Msg("", "商品番号は数字のみを入力してください。", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            txt_Title.Select()
            Exit Sub
        End If

        '------------------------------
        ' 入力長制限
        '------------------------------
        If GF_LenB(txt_Title.Text) <> 4 Then
            Call GF_Msg("", "商品番号は4桁で入力してください。", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            txt_Title.Select()
            Exit Sub
        End If

        '------------------------------
        ' 商品番号使用制限チェック(使用範囲：9001～9900)
        '------------------------------
        If CInt(txt_Title.Text) < 9001 Or CInt(txt_Title.Text) > 9900 Then
            Call GF_Msg("", "現在、コメントオプション用の商品番号のみ登録可能です。" & vbCrLf & "(使用可能範囲:9001～9900)", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            txt_Title.Select()
            Exit Sub
        End If

        '------------------------------
        ' 同一商品番号存在チェック
        '------------------------------
        Select Case LF_GetTPM010(Trim$(txt_Title.Text))
            Case CNL1920.FuncResult.CancelEnd
                ' 重複エラー 
                Call GF_Msg("", "商品番号【" & Trim$(txt_Title.Text) & "】は既に登録されています。" & vbCrLf & "再度、入力して下さい。", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                Exit Sub
            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        '------------------------------
        ' 商品情報レコード追加
        '------------------------------
        If Not LF_InsertTPM010(Trim$(txt_Title.Text)) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' TPM600未存在レコード作成処理
        '------------------------------
        Call LF_InsTPM600()

        With Me
            .DialogResult = DialogResult.OK
            .Close()
        End With

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_OK_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：同一商品番号存在チェック処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2004.05.31 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM010(ByVal pGoodsCD As String) As FuncResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM010 = CNL1920.FuncResult.UnusualEnd

        strSQL = ""
        strSQL = strSQL & "SELECT GOODSCD"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " WHERE GOODSCD = '" & pGoodsCD & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        If objData.Tables("com").Rows.Count = 0 Then
            LF_GetTPM010 = CNL1920.FuncResult.NormalEnd
        Else
            LF_GetTPM010 = CNL1920.FuncResult.CancelEnd
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品情報レコード追加処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_InsertTPM010(ByVal pGoodsCD As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()
        Dim dtsRows As DataRow = Nothing
        Dim intCnt As Integer
        Dim intLimitCnt As Integer

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_InsertTPM010 = False

        '------------------------------
        ' 商品登録件数取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT COUNT(*) AS CNT"
        strSQL = strSQL & "  FROM TPM010"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        If dtsData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not GF_GetRows(dtsData, 0, dtsRows) Then
            Exit Function
        End If

        intCnt = CInt(Trim$(dtsRows("CNT")))

        intLimitCnt = CInt(Trim$(GF_GetAppInfo("LIMIT_GOODS_CNT")))

        If intCnt > intLimitCnt Then
            GF_Msg("", "商品登録数が上限に達したため登録できません。" & vbCrLf & "未使用の商品番号をご利用ください。", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            LF_InsertTPM010 = True
            Exit Function

        Else
            Dim multiLingCnt As Integer = 0
            Dim lngCnt As Integer = 0

            ' 2017.10.10 多言語不具合対応（開始）
            'If GF_GetAppInfo2("MULTI_LING_USE") = "0" Then
            '    ' 多言語対応しない
            '    multiLingCnt = 0
            'Else
            '    ' 多言語対応する
            '    '2014-04-25 基本言語 + 1言語 の際不具合あり暫定処置
            '    ' TPM010Bにも登録しないと商品登録画面で不整合のエラーが起きる
            '    'multiLingCnt = CInt(GF_GetAppInfo3("MULTI_LING_CNT"))
            '    ' 2014-11-11 さらに暫定でもどす
            '    'multiLingCnt = 2
            '    multiLingCnt = CInt(GF_GetAppInfo3("MULTI_LING_CNT"))
            'End If
            multiLingCnt = 3 '多言語を何言語にしてもTPM010関連は全て登録しなければ不整合のエラーが起きる
            ' 2017.10.10 多言語不具合対応（終了）

            '------------------------------
            ' トランザクション開始
            '------------------------------
            If Not GF_BeginTrans() Then
                Exit Function
            End If

            While lngCnt < multiLingCnt + 1
                ' 商品マスタ更新(TPM010)
                strSQL = ""
                If lngCnt = 0 Then
                    strSQL = strSQL & "INSERT INTO TPM010 VALUES("
                    strSQL = strSQL & "'" & pGoodsCD & "',"                  ' GOODSCD
                    strSQL = strSQL & "'" & Space(10) & "',"                 ' GOODSNMJ
                    strSQL = strSQL & "'" & Space(10) & "',"                 ' GOODSNMJ2
                    strSQL = strSQL & "'コメントオプション',"                ' GOODSNMJ3
                    strSQL = strSQL & "'" & Space(10) & "',"                 ' GOODSNMJ4
                    strSQL = strSQL & "'" & Space(180) & "',"                ' JEXPNOTEJ
                    strSQL = strSQL & "'" & Space(100) & "',"                ' IMAGEDATA
                    strSQL = strSQL & "0,"                                   ' PRICE
                    strSQL = strSQL & "'" & Space(5) & "',"                  ' UNITJ
                    strSQL = strSQL & "'1',"                                 ' SELLFLG
                    strSQL = strSQL & "'000',"                               ' SCPNO01
                    strSQL = strSQL & "'000',"                               ' SCPNO02
                    strSQL = strSQL & "'000',"                               ' SCPNO03
                    strSQL = strSQL & "'000',"                               ' SCPNO04
                    strSQL = strSQL & "'000',"                               ' SCPNO05
                    strSQL = strSQL & "'000',"                               ' SCPNO06
                    strSQL = strSQL & "'000',"                               ' SCPNO07
                    strSQL = strSQL & "'000',"                               ' SCPNO08
                    strSQL = strSQL & "'000',"                               ' SCPNO09
                    strSQL = strSQL & "'000',"                               ' SCPNO10
                    strSQL = strSQL & "'000',"                               ' SCPNO11
                    strSQL = strSQL & "'000',"                               ' SCPNO12
                    strSQL = strSQL & "'1',"                                 ' STATUS
                    strSQL = strSQL & "'3',"                                 ' GOODSKIND
                    strSQL = strSQL & "'" & GF_GetBumon() & "',"             ' BUMONCD
                    strSQL = strSQL & "'00000000000000000000000000000000',"  ' KCPSTATUS
                    strSQL = strSQL & "'0',"                                 ' GENERATEFLG
                    strSQL = strSQL & "'***',"                               ' HTLNM1
                    strSQL = strSQL & "'***',"                               ' HTLNM2
                    strSQL = strSQL & "'0',"                                 ' SPFLG
                    strSQL = strSQL & "'0',"                                 ' NEWFLG
                    strSQL = strSQL & "'" & GC_UPDID & "',"                  ' UPDID
                    strSQL = strSQL & "'" & Now & "')"                       ' UPDYMD
                Else
                    Select Case lngCnt
                        Case 1
                            strSQL = strSQL & "INSERT INTO TPM010A VALUES("
                        Case 2
                            strSQL = strSQL & "INSERT INTO TPM010B VALUES("
                        Case 3
                            strSQL = strSQL & "INSERT INTO TPM010C VALUES("
                        Case Else
                            strSQL = strSQL & "INSERT INTO TPM010D VALUES("
                    End Select
                    strSQL = strSQL & "N'" & pGoodsCD & "',"                  ' GOODSCD
                    strSQL = strSQL & "N'" & Space(10) & "',"                 ' GOODSNMJ
                    strSQL = strSQL & "N'" & Space(10) & "',"                 ' GOODSNMJ2
                    strSQL = strSQL & "N'" & Space(180) & "',"                ' JEXPNOTEJ
                    strSQL = strSQL & "N'" & GC_UPDID & "',"                  ' UPDID
                    strSQL = strSQL & "N'" & Now & "')"                       ' UPDYMD
                End If

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                lngCnt = lngCnt + 1
            End While

            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM200 VALUES("
            strSQL = strSQL & "'" & pGoodsCD & "',"                                                ' GOODSCD
            strSQL = strSQL & "'" & pGoodsCD.Substring(1, 1) & pGoodsCD.Substring(3) & "',"        ' SEARCHNUMBER
            strSQL = strSQL & "'" & GC_UPDID & "',"                                                ' UPDID
            strSQL = strSQL & "'" & Now & "')"                                                     ' UPDYMD

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM330 VALUES("
            strSQL = strSQL & "'" & pGoodsCD & "',"                                                ' GOODSCD
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
            strSQL = strSQL & "'" & pGoodsCD & "',"                                                ' GOODSCD
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
            strSQL = strSQL & "'" & pGoodsCD & "',"                                                ' GOODSCD
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

        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_InsertTPM010 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：キャンセルボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        With Me
            .DialogResult = DialogResult.Cancel
            .Close()
        End With
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：テキストボックスキーダウン時イベントハンドラ
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_Title_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Title.KeyPress

        '------------------------------
        ' 4桁以上入力した状態でのBackSpace以外のキー入力をキャンセル
        '------------------------------
        If Len(txt_Title.Text) >= 4 And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

        '------------------------------
        ' 数字、BackSpace以外のキー入力をキャンセル
        '------------------------------
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub

    ''' <summary>
    ''' --------------------------------------------------------------------------------
    ''' 機　　能：TPM600未存在ﾚｺｰﾄﾞ作成処理
    ''' 機能概要：TPM010に存在して、TPM600に未存在のレコードをTPM600に作成する
    ''' 引　　数：
    ''' 戻 り 値：
    ''' 履　　歴：2019.08.08 ｸﾚｽｺ北陸)takigaura 新規作成
    ''' --------------------------------------------------------------------------------
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_InsTPM600() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim stbSQL As New System.Text.StringBuilder

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_InsTPM600 = False

        '------------------------------
        ' トランザクション開始
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        '------------------------------
        ' 更新処理
        '------------------------------
        With stbSQL
            .Length = 0
            .AppendLine("INSERT INTO TPM600")
            .AppendLine("SELECT")
            .AppendLine("     TPM010.GOODSCD AS 商品コード")
            .AppendLine(",    RIGHT('00000000000000'  + RTRIM(CAST(GOODSCD  AS VARCHAR)) ,14)     AS メニューコード")
            If GF_GetAppInfo("TEC_OWN_COM_CD_FLG") = GC_TRUE Then
                '自社コード - 初期値設定なし
                .AppendLine(",    '00000000000000'  AS 自社コード")
            Else
                '自社コード - 初期値設定あり
                .AppendLine(",    RIGHT('00000000000000'  + RTRIM(CAST(GOODSCD  AS VARCHAR)) ,14)     AS 自社コード")
            End If
            .AppendLine(",    0       AS '単価(軽減税率)'")
            .AppendLine(",    0       AS サブメニュー単価")
            .AppendLine(",    0       AS 'サブメニュー単価(軽減税率)'")
            .AppendLine(",    '0'     AS 単価種別")
            .AppendLine(",    '0'     AS 税ステータス")
            .AppendLine(",    '0'     AS '税ステータス(軽減税率)'")
            .AppendLine(",    '0'     AS 数量加筆")
            .AppendLine(",    '0'     AS 小計割引")
            .AppendLine(",    '1'     AS 飲食持帰")
            .AppendLine(",    '0'     AS OES用メニュー")
            .AppendLine(String.Format(",   '{0}'    AS 更新者", GC_UPDID))
            .AppendLine(String.Format(",   '{0}'    AS 更新日", Now))
            .AppendLine("FROM TPM010")
            .AppendLine("WHERE    NOT EXISTS( SELECT  *")
            .AppendLine("                     FROM    TPM600")
            .AppendLine("                     WHERE   TPM010.GOODSCD = TPM600.GOODSCD    )")
        End With

        If Not GF_UpdCmtData(stbSQL.ToString) Then
            Exit Function
        End If

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
        LF_InsTPM600 = True

    End Function

End Class
