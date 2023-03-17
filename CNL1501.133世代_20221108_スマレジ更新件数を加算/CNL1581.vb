Public Class CNL1581
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.txt_Title = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 16)
        Me.Label1.TabIndex = 264
        Me.Label1.Text = "■ 新しく作成する飲み放題メニュー名を入力してください"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btn_OK
        '
        Me.btn_OK.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_OK.Location = New System.Drawing.Point(264, 72)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(88, 32)
        Me.btn_OK.TabIndex = 2
        Me.btn_OK.Text = "作成"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(368, 72)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(88, 32)
        Me.btn_Cancel.TabIndex = 3
        Me.btn_Cancel.Text = "キャンセル"
        '
        'txt_Title
        '
        Me.txt_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Title.Location = New System.Drawing.Point(32, 40)
        Me.txt_Title.Name = "txt_Title"
        Me.txt_Title.Size = New System.Drawing.Size(360, 22)
        Me.txt_Title.TabIndex = 1
        Me.txt_Title.Text = "TextBox1"
        '
        'CNL1581
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(472, 110)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txt_Title, Me.btn_Cancel, Me.btn_OK, Me.Label1})
        Me.Name = "CNL1581"
        Me.Text = "新規作成"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CNL1581_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' フォーム初期化
        '------------------------------
        Me.Text = GF_FormText()
        txt_Title.Clear()

        Label1.Text = "新しく作成する" & GF_GetAppInfo("FREE_MENU_NM") & "メニュー名を入力してください。"

    End Sub

    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click

        '------------------------------
        ' 未入力チェック
        '------------------------------
        If Len(Trim$(txt_Title.Text)) = 0 Then
            Call GF_Msg("E01", "", MsgBoxStyle.OKOnly, MsgBoxStyle.Critical)
            txt_Title.Select()
            Exit Sub
        End If

        ' 同一名称のメニューが既に存在している場合は、エラーメッセージを表示して、処理を中断させる
        Select Case LF_GetTPM170(Trim$(txt_Title.Text))
            Case CNL1920.FuncResult.CancelEnd
                ' 存在するので、エラー 
                Call GF_Msg("", "既に【" & Trim$(txt_Title.Text) & "】が存在するため、使用できません。" & vbCrLf & "他のメニュー名を入力して下さい。", MsgBoxStyle.OKOnly, MsgBoxStyle.Critical)
                Exit Sub

            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        '------------------------------
        ' メニューレコード追加処理
        '------------------------------
        If Not LF_InsertNewMenu() Then
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

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        With Me
            .DialogResult = DialogResult.Cancel
            .Close()
        End With
    End Sub

    Private Function LF_GetTPM170(ByVal pMenuNM As String) As FuncResult
        '** 入力されたメニュー名称の存在チェック

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM170 = CNL1920.FuncResult.UnusualEnd

        strSQL = ""
        strSQL = strSQL & "SELECT TPM170.MENUID"
        strSQL = strSQL & "  FROM TPM170"
        strSQL = strSQL & " WHERE TPM170.MENUNM = '" & pMenuNM & "'"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        If objData.Tables("com").Rows.Count = 0 Then
            LF_GetTPM170 = CNL1920.FuncResult.NormalEnd
        Else
            LF_GetTPM170 = CNL1920.FuncResult.CancelEnd
        End If

    End Function

    Private Function LF_InsertNewMenu() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String = Nothing
        Dim dtsData As New DataSet()
        Dim strNewID As String = Nothing
        Dim strGoodsCD1 As String = Nothing
        Dim strGoodsCD2 As String = Nothing
        Dim strGoodsNM1 As String = Nothing
        Dim strGoodsNM2 As String = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_InsertNewMenu = False

        ' 新規メニューＩＤ取得
        If Not GF_GetNewID2(strNewID) Then
            Exit Function
        End If

        ' サブメニュー商品コード採番
        ' --- ↓(2008.11.25) 皿勘定有時の飲み放題対応のため修正↓ ---
        'If Not GF_GetGoodsCD(strGoodsCD1, strGoodsCD2, 8000) Then
        If Not GF_GetGoodsCD(strGoodsCD1, strGoodsCD2, 7000) Then
        ' --- ↑(2008.11.25) 皿勘定有時の飲み放題対応のため修正↑ ---
            Exit Function
        End If

        ' サブメニュー商品コードを商品マスタ(TPM010)に登録
        strGoodsNM1 = "１" & Mid$(Trim$(txt_Title.Text), 1, 19)
        If Not GF_InTPM010(strGoodsCD1, strGoodsNM1) Then
            Exit Function
        End If
        strGoodsNM2 = "２" & Mid$(Trim$(txt_Title.Text), 1, 19)
        If Not GF_InTPM010(strGoodsCD2, strGoodsNM2) Then
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM170 VALUES("
        strSQL = strSQL & "'" & strNewID & "',"                                 ' メニューＩＤ
        strSQL = strSQL & "'" & GF_RepQuo(Trim$(txt_Title.Text)) & "',"         ' メニュー名称
        strSQL = strSQL & "'0',"                                                ' メニュー形態
        strSQL = strSQL & "'0000',"                                             ' 商品グループＩＤ
        strSQL = strSQL & "'0',"                                                ' 表示順
        strSQL = strSQL & "'0',"                                                ' 単価表示有無
        strSQL = strSQL & "'1',"                                                ' 金額／グループ順区分
        strSQL = strSQL & "'1',"                                  ' 有効フラグ
        strSQL = strSQL & "0,"                                                  ' 飲み放題時間
        strSQL = strSQL & "'" & strGoodsCD1 & "',"                              ' サブメニュー１商品コード
        strSQL = strSQL & "'0',"                                                ' サブメニュー１有効フラグ
        strSQL = strSQL & "'" & strGoodsCD2 & "',"                              ' サブメニュー２商品コード
        strSQL = strSQL & "'0',"                                                ' サブメニュー１有効フラグ
        strSQL = strSQL & "'" & GC_UPDID & "',"
        strSQL = strSQL & "'" & Now & "')"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '--- (2006.06.16) STN100バージョンアップ ＨＴＬ用商品不要 ------------------------------------
        '' ハンディ用サブメニュー商品コード採番
        'If Not GF_GetGoodsCD(strGoodsCD1, strGoodsCD2, 7000) Then
        '    Exit Function
        'End If
        '' ハンディ用サブメニュー商品コードを商品マスタ(TPM010)に登録
        'If Not GF_InTPM010(strGoodsCD1, strGoodsNM1) Then
        '    Exit Function
        'End If
        'If Not GF_InTPM010(strGoodsCD2, strGoodsNM2) Then
        '    Exit Function
        'End If
        '---------------------------------------------------------------------------------------------

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_InsertNewMenu = True

    End Function

    Private Sub txt_Title_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Title.TextChanged

        Try
            Dim lngST As Long
            lngST = txt_Title.SelectionStart
            ' 2014-05-12 2バイト文字制限解除
            'txt_Title.Text = StrConv(txt_Title.Text, VbStrConv.Wide)
            If lngST >= 0 Then txt_Title.SelectionStart = lngST

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
End Class
