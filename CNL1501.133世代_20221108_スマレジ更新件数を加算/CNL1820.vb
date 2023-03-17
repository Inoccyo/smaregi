Public Class CNL1820
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtサーバ名 As System.Windows.Forms.TextBox
    Friend WithEvents txtユーザ名 As System.Windows.Forms.TextBox
    Friend WithEvents txtパスワード As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtデータベース名 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtサーバ名 = New System.Windows.Forms.TextBox()
        Me.txtユーザ名 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtパスワード = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtデータベース名 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtサーバ名
        '
        Me.txtサーバ名.Location = New System.Drawing.Point(120, 40)
        Me.txtサーバ名.Name = "txtサーバ名"
        Me.txtサーバ名.Size = New System.Drawing.Size(136, 19)
        Me.txtサーバ名.TabIndex = 0
        Me.txtサーバ名.Text = ""
        '
        'txtユーザ名
        '
        Me.txtユーザ名.Location = New System.Drawing.Point(120, 88)
        Me.txtユーザ名.Name = "txtユーザ名"
        Me.txtユーザ名.Size = New System.Drawing.Size(136, 19)
        Me.txtユーザ名.TabIndex = 2
        Me.txtユーザ名.Text = "TextBox2"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "サーバ名"
        '
        'txtパスワード
        '
        Me.txtパスワード.Location = New System.Drawing.Point(120, 112)
        Me.txtパスワード.Name = "txtパスワード"
        Me.txtパスワード.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtパスワード.Size = New System.Drawing.Size(136, 19)
        Me.txtパスワード.TabIndex = 3
        Me.txtパスワード.Text = "TextBox3"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ユーザー名"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "パスワード"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "接続テスト"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(104, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "保存"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(200, 176)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 24)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "キャンセル"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(296, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "データベースサーバへの接続設定を変更します"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(8, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "[注意]"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(8, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(280, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "システムが起動しなくなる可能性がありますので、設定にあたっては、十分ご注意下さい。"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(32, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "データベース名"
        '
        'txtデータベース名
        '
        Me.txtデータベース名.Location = New System.Drawing.Point(120, 64)
        Me.txtデータベース名.Name = "txtデータベース名"
        Me.txtデータベース名.Size = New System.Drawing.Size(136, 19)
        Me.txtデータベース名.TabIndex = 1
        Me.txtデータベース名.Text = ""
        '
        'CNL1820
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(292, 253)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label7, Me.txtデータベース名, Me.Label6, Me.Label5, Me.Label4, Me.Button3, Me.Button2, Me.Button1, Me.Label3, Me.Label2, Me.txtパスワード, Me.Label1, Me.txtユーザ名, Me.txtサーバ名})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CNL1820"
        Me.Text = "JCV90"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private blnSuccess As Boolean
    Private mstrサーバ名 As String
    Private mstrデータベース名 As String
    Private mstrユーザ名 As String
    Private mstrパスワード As String

    Private Sub JCV90_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mstrサーバ名 = System.Configuration.ConfigurationManager.AppSettings("DBServer Name")
        mstrデータベース名 = System.Configuration.ConfigurationManager.AppSettings("DBServer DBName")
        mstrユーザ名 = System.Configuration.ConfigurationManager.AppSettings("DBServer UserID")
        mstrパスワード = System.Configuration.ConfigurationManager.AppSettings("DBServer PassWD")

        txtサーバ名.Text = mstrサーバ名
        txtデータベース名.Text = mstrデータベース名
        txtユーザ名.Text = mstrユーザ名
        txtパスワード.Text = mstrパスワード

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        '------------------------------
        ' 導通確認モードで試行
        '------------------------------
        If GF_ConnectDB(txtサーバ名.Text, txtデータベース名.Text, txtユーザ名.Text, txtパスワード.Text, True) Then
            If MsgBox("データベースサーバへの接続に成功しました" & vbCrLf & _
                      "このまま設定値を保存しますか？", _
                      MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If LF_SaveAppConfig() = False Then
                    MsgBox("設定値の保存に失敗しました", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly)
                Else
                    MsgBox("設定値を保存しました", MsgBoxStyle.Information + MsgBoxStyle.OKOnly)
                End If
            End If
        Else
            MsgBox("データベースサーバへの接続に失敗しました")
        End If

    End Sub

    Private Function LF_SaveAppConfig() As Boolean
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim appConfigPath As String
        Dim doc As System.Xml.XmlDocument
        Dim node As System.Xml.XmlNode
        Dim n As System.Xml.XmlNode
        Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_SaveAppConfig = False

        '------------------------------
        ' 構成ファイルのパスを取得
        '------------------------------
        asm = System.Reflection.Assembly.GetExecutingAssembly
        appConfigPath = System.IO.Path.GetDirectoryName(asm.Location) + "\店舗内情報システム.exe.config"

        '------------------------------
        ' 構成ファイルをXML DOMに読込む
        '------------------------------
        doc = New System.Xml.XmlDocument()
        doc.Load(appConfigPath)
        node = doc("configuration")("appSettings")

        '------------------------------
        ' キー値の変更を行う
        '------------------------------
        ' ＤＢサーバ名
        For Each n In doc("configuration")("appSettings")
            If n.Name = "add" Then
                If n.Attributes.GetNamedItem("key").Value = "DBServer Name" Then
                    n.Attributes.GetNamedItem("value").Value = txtサーバ名.Text
                End If
            End If
        Next

        ' ＤＢ名
        For Each n In doc("configuration")("appSettings")
            If n.Name = "add" Then
                If n.Attributes.GetNamedItem("key").Value = "DBServer DBName" Then
                    n.Attributes.GetNamedItem("value").Value = txtデータベース名.Text
                End If
            End If
        Next

        ' ユーザ名
        For Each n In doc("configuration")("appSettings")
            If n.Name = "add" Then
                If n.Attributes.GetNamedItem("key").Value = "DBServer UserID" Then
                    n.Attributes.GetNamedItem("value").Value = txtユーザ名.Text
                End If
            End If
        Next

        ' パスワード
        For Each n In doc("configuration")("appSettings")
            If n.Name = "add" Then
                If n.Attributes.GetNamedItem("key").Value = "DBServer PassWD" Then
                    n.Attributes.GetNamedItem("value").Value = txtパスワード.Text
                End If
            End If
        Next

        '------------------------------
        ' 変更された構成ファイルを保存
        '------------------------------
        doc.Save(appConfigPath)

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_SaveAppConfig = True

    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If LF_SaveAppConfig() = False Then
            MsgBox("設定値の保存に失敗しました", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly)
        Else
            MsgBox("設定値を保存しました", MsgBoxStyle.Information + MsgBoxStyle.OKOnly)
        End If

    End Sub

    Private Sub JCV90_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        MsgBox("再起動してください")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
