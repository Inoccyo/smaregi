' --------------------------------------------------------------------------------
' 　機　　能：店舗内情報システム - サーバメンテナンス(バックアップ／リカバリ)
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
' --------------------------------------------------------------------------------

Public Class CNL1601
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMaxDay As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxBK As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtMaxDay = New System.Windows.Forms.TextBox()
        Me.txtMaxBK = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "■ バックアップを保存できる最大日数"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "■ １日の最大バックアップ数"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(176, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(288, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "キャンセル"
        '
        'txtMaxDay
        '
        Me.txtMaxDay.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtMaxDay.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtMaxDay.Location = New System.Drawing.Point(312, 16)
        Me.txtMaxDay.MaxLength = 2
        Me.txtMaxDay.Name = "txtMaxDay"
        Me.txtMaxDay.Size = New System.Drawing.Size(40, 22)
        Me.txtMaxDay.TabIndex = 0
        Me.txtMaxDay.Text = "99"
        Me.txtMaxDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMaxBK
        '
        Me.txtMaxBK.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtMaxBK.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtMaxBK.Location = New System.Drawing.Point(312, 48)
        Me.txtMaxBK.MaxLength = 2
        Me.txtMaxBK.Name = "txtMaxBK"
        Me.txtMaxBK.Size = New System.Drawing.Size(40, 22)
        Me.txtMaxBK.TabIndex = 1
        Me.txtMaxBK.Text = "99"
        Me.txtMaxBK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label3.Location = New System.Drawing.Point(352, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "日"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label4.Location = New System.Drawing.Point(352, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "回"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CNL1601
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(402, 119)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.Label3, Me.txtMaxBK, Me.txtMaxDay, Me.Button2, Me.Button1, Me.Label2, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CNL1601"
        Me.ShowInTaskbar = False
        Me.Text = "TP1061"
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub TP1061_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' フォーム名称設定
        '------------------------------
        Me.Text = GF_FormText("- バックアップ・リカバリ画面")

        '------------------------------
        ' フォーム初期化処理
        '------------------------------
        txtMaxDay.Text = g_udtAppConfig.strBK_MaxDay
        txtMaxBK.Text = g_udtAppConfig.strBK_MaxTime

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：入力値制限処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txtMaxDay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMaxDay.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMaxBK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMaxBK.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＯＫボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strFlds() As String
        Dim strFld As String
        Dim strSubFld() As String
        Dim lngCnt As Long

        ' --- (2003.12.02) 未入力時、エラーとなる現象を回避 ----------------
        If Len(Trim$(txtMaxDay.Text)) = 0 Then
            txtMaxDay.Text = "1"
        End If
        If Len(Trim$(txtMaxBK.Text)) = 0 Then
            txtMaxBK.Text = "1"
        End If
        ' ------------------------------------------------------------------

        '------------------------------
        ' 不要ディレクトリ削除(親)
        '------------------------------
        If CLng(g_udtAppConfig.strBK_MaxDay) > CLng(Trim$(txtMaxDay.Text)) Then
            strFlds = System.IO.Directory.GetDirectories(g_udtAppConfig.strBKPath)
            Array.Sort(strFlds)
            For lngCnt = (UBound(strFlds) - CLng(Trim$(txtMaxDay.Text))) To 0 Step -1
                Call GS_DelFiles(strFlds(lngCnt))
                Debug.Write("DELETE : [" & strFlds(lngCnt) & "]" & vbCrLf)
            Next
        End If

        '------------------------------
        ' 不要ディレクトリ削除(子)
        '------------------------------
        If CLng(g_udtAppConfig.strBK_MaxTime) > CLng(Trim$(txtMaxBK.Text)) Then
            For Each strFld In System.IO.Directory.GetDirectories(g_udtAppConfig.strBKPath)
                strSubFld = System.IO.Directory.GetDirectories(strFld)
                Array.Sort(strSubFld)
                For lngCnt = (UBound(strSubFld) - CLng(Trim$(txtMaxBK.Text))) To 0 Step -1
                    Call GS_DelFiles(strSubFld(lngCnt))
                    Debug.Write("DELETE : [" & strSubFld(lngCnt) & "]" & vbCrLf)
                Next
            Next
        End If

        If Not LF_SaveAppConfig() Then
            GoTo SYSTEM_ERROR
        Else
            Call GF_Msg("I03", "", MsgBoxStyle.OKOnly, MsgBoxStyle.Information)
        End If
        Me.Close()

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("Button1_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：キャンセルボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：App.Configファイル 書き換え処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_SaveAppConfig() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_SaveAppConfig = False

        '------------------------------
        ' システム管理マスタ 更新
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM040"
        strSQL = strSQL & "   SET TPM040.BK_MAXDAY  = '" & Trim$(txtMaxDay.Text) & "',"
        strSQL = strSQL & "       TPM040.BK_MAXTIME = '" & Trim$(txtMaxBK.Text) & "'"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_SaveAppConfig = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：最大保持日数項目 入力時処理
    ' 　機能概要：最大保持日数項目について、入力長制限を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.02 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txtMaxDay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaxDay.TextChanged
        '------------------------------
        ' 入力長制限
        '------------------------------
        If GF_LenB(txtMaxDay.Text) > 2 Then
            txtMaxDay.Text = GF_MidB(txtMaxDay.Text, 1, 2)
            txtMaxDay.SelectionStart = GF_LenB(txtMaxDay.Text)
            Exit Sub
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：最大保持回数項目 入力時処理
    ' 　機能概要：最大保持回数項目について、入力長制限を行う
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.12.02 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txtMaxBK_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaxBK.TextChanged
        '------------------------------
        ' 入力長制限
        '------------------------------
        If GF_LenB(txtMaxBK.Text) > 2 Then
            txtMaxBK.Text = GF_MidB(txtMaxBK.Text, 1, 2)
            txtMaxBK.SelectionStart = GF_LenB(txtMaxBK.Text)
            Exit Sub
        End If
    End Sub
End Class
