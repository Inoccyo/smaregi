' --------------------------------------------------------------------------------
' 　機　　能：CrossNavi - グループ新規追加画面
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
' --------------------------------------------------------------------------------

Public Class CNL1542
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
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_OK As System.Windows.Forms.Button
    Friend WithEvents txt_Title As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btn_Cancel = New System.Windows.Forms.Button
        Me.btn_OK = New System.Windows.Forms.Button
        Me.txt_Title = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Cancel.Location = New System.Drawing.Point(200, 73)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(72, 32)
        Me.btn_Cancel.TabIndex = 2
        Me.btn_Cancel.Text = "キャンセル"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_OK
        '
        Me.btn_OK.BackColor = System.Drawing.SystemColors.Control
        Me.btn_OK.Location = New System.Drawing.Point(120, 73)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(72, 32)
        Me.btn_OK.TabIndex = 1
        Me.btn_OK.Text = "決定"
        Me.btn_OK.UseVisualStyleBackColor = False
        '
        'txt_Title
        '
        Me.txt_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Title.Location = New System.Drawing.Point(24, 37)
        Me.txt_Title.Name = "txt_Title"
        Me.txt_Title.Size = New System.Drawing.Size(360, 22)
        Me.txt_Title.TabIndex = 0
        Me.txt_Title.Text = "txt_Title"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "■ グループ名を入力してください"
        '
        'CNL1542
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
        Me.Name = "CNL1542"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TP1032"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public G_TP1032Ret As String

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub TP1032_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' フォーム初期化
        '------------------------------
        Me.Text = GF_FormText()
        txt_Title.Clear()
        G_TP1032Ret = ""

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：[決定]ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click
        G_TP1032Ret = txt_Title.Text
        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：[キャンセル]ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：タイトルテキストボックス変更時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_Title_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Title.TextChanged

        If txt_Title.Modified = True Then
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

            '------------------------------
            ' 入力長制限
            '------------------------------
            If GF_LenB(txt_Title.Text) > 40 Then
                txt_Title.Text = GF_MidB(txt_Title.Text, 1, 40)
                txt_Title.SelectionStart = GF_LenB(txt_Title.Text)
                Exit Sub
            End If
        End If

    End Sub
End Class
