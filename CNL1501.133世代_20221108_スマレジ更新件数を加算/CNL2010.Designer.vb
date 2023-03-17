<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CNL2010
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CNL2010))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_preview = New System.Windows.Forms.Button
        Me.btn_menu11 = New System.Windows.Forms.Button
        Me.btn_menu10 = New System.Windows.Forms.Button
        Me.btn_menu08 = New System.Windows.Forms.Button
        Me.btn_menu09 = New System.Windows.Forms.Button
        Me.btn_menu01 = New System.Windows.Forms.Button
        Me.btn_menu02 = New System.Windows.Forms.Button
        Me.btn_menu06 = New System.Windows.Forms.Button
        Me.btn_menu05 = New System.Windows.Forms.Button
        Me.btn_menu03 = New System.Windows.Forms.Button
        Me.btn_menu04 = New System.Windows.Forms.Button
        Me.btn_menu07 = New System.Windows.Forms.Button
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.stb_Msg = New System.Windows.Forms.StatusBar
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_preview)
        Me.Panel1.Controls.Add(Me.btn_menu11)
        Me.Panel1.Controls.Add(Me.btn_menu10)
        Me.Panel1.Controls.Add(Me.btn_menu08)
        Me.Panel1.Controls.Add(Me.btn_menu09)
        Me.Panel1.Controls.Add(Me.btn_menu01)
        Me.Panel1.Controls.Add(Me.btn_menu02)
        Me.Panel1.Controls.Add(Me.btn_menu06)
        Me.Panel1.Controls.Add(Me.btn_menu05)
        Me.Panel1.Controls.Add(Me.btn_menu03)
        Me.Panel1.Controls.Add(Me.btn_menu04)
        Me.Panel1.Controls.Add(Me.btn_menu07)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 663)
        Me.Panel1.TabIndex = 2
        '
        'btn_preview
        '
        Me.btn_preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_preview.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!)
        Me.btn_preview.Location = New System.Drawing.Point(8, 554)
        Me.btn_preview.Name = "btn_preview"
        Me.btn_preview.Size = New System.Drawing.Size(179, 45)
        Me.btn_preview.TabIndex = 12
        Me.btn_preview.Text = "プレビュー"
        Me.btn_preview.UseVisualStyleBackColor = False
        '
        'btn_menu11
        '
        Me.btn_menu11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_menu11.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!)
        Me.btn_menu11.Location = New System.Drawing.Point(9, 611)
        Me.btn_menu11.Name = "btn_menu11"
        Me.btn_menu11.Size = New System.Drawing.Size(179, 45)
        Me.btn_menu11.TabIndex = 11
        Me.btn_menu11.Text = "各種設定"
        Me.btn_menu11.UseVisualStyleBackColor = False
        '
        'btn_menu10
        '
        Me.btn_menu10.BackColor = System.Drawing.Color.Violet
        Me.btn_menu10.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!)
        Me.btn_menu10.Location = New System.Drawing.Point(9, 324)
        Me.btn_menu10.Name = "btn_menu10"
        Me.btn_menu10.Size = New System.Drawing.Size(179, 45)
        Me.btn_menu10.TabIndex = 10
        Me.btn_menu10.Text = "閉店処理"
        Me.btn_menu10.UseVisualStyleBackColor = False
        '
        'btn_menu08
        '
        Me.btn_menu08.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_menu08.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!)
        Me.btn_menu08.Location = New System.Drawing.Point(9, 497)
        Me.btn_menu08.Name = "btn_menu08"
        Me.btn_menu08.Size = New System.Drawing.Size(179, 45)
        Me.btn_menu08.TabIndex = 7
        Me.btn_menu08.Text = "食べ飲み放題登録"
        Me.btn_menu08.UseVisualStyleBackColor = False
        '
        'btn_menu09
        '
        Me.btn_menu09.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_menu09.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!)
        Me.btn_menu09.Location = New System.Drawing.Point(10, 496)
        Me.btn_menu09.Name = "btn_menu09"
        Me.btn_menu09.Size = New System.Drawing.Size(179, 45)
        Me.btn_menu09.TabIndex = 9
        Me.btn_menu09.Text = "プレビュー"
        Me.btn_menu09.UseVisualStyleBackColor = False
        '
        'btn_menu01
        '
        Me.btn_menu01.BackColor = System.Drawing.Color.Violet
        Me.btn_menu01.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_menu01.Location = New System.Drawing.Point(9, 15)
        Me.btn_menu01.Name = "btn_menu01"
        Me.btn_menu01.Size = New System.Drawing.Size(179, 45)
        Me.btn_menu01.TabIndex = 0
        Me.btn_menu01.Text = "開店処理"
        Me.btn_menu01.UseVisualStyleBackColor = False
        '
        'btn_menu02
        '
        Me.btn_menu02.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_menu02.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!)
        Me.btn_menu02.Location = New System.Drawing.Point(9, 75)
        Me.btn_menu02.Name = "btn_menu02"
        Me.btn_menu02.Size = New System.Drawing.Size(179, 45)
        Me.btn_menu02.TabIndex = 1
        Me.btn_menu02.Text = "商品登録"
        Me.btn_menu02.UseVisualStyleBackColor = False
        '
        'btn_menu06
        '
        Me.btn_menu06.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_menu06.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!)
        Me.btn_menu06.Location = New System.Drawing.Point(9, 136)
        Me.btn_menu06.Name = "btn_menu06"
        Me.btn_menu06.Size = New System.Drawing.Size(179, 45)
        Me.btn_menu06.TabIndex = 5
        Me.btn_menu06.Text = "日替わり商品登録"
        Me.btn_menu06.UseVisualStyleBackColor = False
        '
        'btn_menu05
        '
        Me.btn_menu05.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_menu05.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!)
        Me.btn_menu05.Location = New System.Drawing.Point(8, 445)
        Me.btn_menu05.Name = "btn_menu05"
        Me.btn_menu05.Size = New System.Drawing.Size(179, 45)
        Me.btn_menu05.TabIndex = 4
        Me.btn_menu05.Text = "オプション登録"
        Me.btn_menu05.UseVisualStyleBackColor = False
        '
        'btn_menu03
        '
        Me.btn_menu03.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_menu03.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!)
        Me.btn_menu03.Location = New System.Drawing.Point(9, 199)
        Me.btn_menu03.Name = "btn_menu03"
        Me.btn_menu03.Size = New System.Drawing.Size(179, 45)
        Me.btn_menu03.TabIndex = 2
        Me.btn_menu03.Text = "商品配置"
        Me.btn_menu03.UseVisualStyleBackColor = False
        '
        'btn_menu04
        '
        Me.btn_menu04.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_menu04.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!)
        Me.btn_menu04.Location = New System.Drawing.Point(8, 384)
        Me.btn_menu04.Name = "btn_menu04"
        Me.btn_menu04.Size = New System.Drawing.Size(179, 45)
        Me.btn_menu04.TabIndex = 3
        Me.btn_menu04.Text = "お知らせ作成"
        Me.btn_menu04.UseVisualStyleBackColor = False
        '
        'btn_menu07
        '
        Me.btn_menu07.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_menu07.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!)
        Me.btn_menu07.Location = New System.Drawing.Point(9, 265)
        Me.btn_menu07.Name = "btn_menu07"
        Me.btn_menu07.Size = New System.Drawing.Size(179, 45)
        Me.btn_menu07.TabIndex = 6
        Me.btn_menu07.Text = "品切れ登録"
        Me.btn_menu07.UseVisualStyleBackColor = False
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem2})
        Me.MenuItem1.Text = "メインメニュー"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "終了(&E)"
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 664)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(1018, 24)
        Me.stb_Msg.TabIndex = 174
        Me.stb_Msg.Text = "StatusBar1"
        '
        'CNL2010
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 688)
        Me.Controls.Add(Me.stb_Msg)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL2010"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNL2010"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_menu03 As System.Windows.Forms.Button
    Friend WithEvents btn_menu02 As System.Windows.Forms.Button
    Friend WithEvents btn_menu01 As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents btn_menu06 As System.Windows.Forms.Button
    Friend WithEvents btn_menu05 As System.Windows.Forms.Button
    Friend WithEvents btn_menu04 As System.Windows.Forms.Button
    Friend WithEvents btn_menu11 As System.Windows.Forms.Button
    Friend WithEvents btn_menu10 As System.Windows.Forms.Button
    Friend WithEvents btn_menu09 As System.Windows.Forms.Button
    Friend WithEvents btn_menu08 As System.Windows.Forms.Button
    Friend WithEvents btn_menu07 As System.Windows.Forms.Button
    Friend WithEvents btn_preview As System.Windows.Forms.Button
End Class
