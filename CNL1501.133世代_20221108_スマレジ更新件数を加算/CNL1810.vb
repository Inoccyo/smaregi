Public Class CNL1810
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
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents pgs_Status As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.pgs_Status = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(8, 8)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(392, 16)
        Me.lbl_Msg.TabIndex = 0
        '
        'pgs_Status
        '
        Me.pgs_Status.Location = New System.Drawing.Point(8, 40)
        Me.pgs_Status.Name = "pgs_Status"
        Me.pgs_Status.Size = New System.Drawing.Size(392, 16)
        Me.pgs_Status.TabIndex = 1
        '
        'CNL1810
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(408, 61)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.pgs_Status, Me.lbl_Msg})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CNL1810"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNL1810"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TP1062_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = GF_FormText("")
    End Sub
End Class
