' --------------------------------------------------------------------------------
' 　機　　能：店舗内情報システム - クライアントメンテナンス
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
' --------------------------------------------------------------------------------
Public Class CNL1531
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pic_Sample As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.pic_Sample = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pic_Sample
        '
        Me.pic_Sample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_Sample.Name = "pic_Sample"
        Me.pic_Sample.Size = New System.Drawing.Size(512, 384)
        Me.pic_Sample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Sample.TabIndex = 0
        Me.pic_Sample.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(440, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "閉じる"
        '
        'CNL1531
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(514, 419)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.pic_Sample})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CNL1531"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TP1021"
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' --------------------------------------------------------------------------------
    ' グローバル変数定義
    ' --------------------------------------------------------------------------------
    Public G_FilePath As String

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub TP1021_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '------------------------------
        ' フォーム名称設定
        '------------------------------
        Me.Text = GF_FormText("")

        '------------------------------
        ' 画像表示処理
        '------------------------------
        pic_Sample.SizeMode = PictureBoxSizeMode.StretchImage
        Call LS_ShowImage()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画像表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_ShowImage()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objImgFile As System.IO.FileStream

        Try
            'GIF画像の場合
            If Strings.Right(G_FilePath, 3) = "gif" Then
                pic_Sample.ImageLocation = G_FilePath
            Else
                objImgFile = New System.IO.FileStream(G_FilePath, IO.FileMode.Open, IO.FileAccess.Read)
                pic_Sample.Image = System.Drawing.Image.FromStream(objImgFile)
                objImgFile.Close()
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_ShowImage")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：閉じるボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class
