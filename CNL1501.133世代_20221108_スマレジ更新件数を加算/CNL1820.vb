Public Class CNL1820
    Inherits System.Windows.Forms.Form

#Region " Windows �t�H�[�� �f�U�C�i�Ő������ꂽ�R�[�h "

    Public Sub New()
        MyBase.New()

        ' ���̌Ăяo���� Windows �t�H�[�� �f�U�C�i�ŕK�v�ł��B
        InitializeComponent()

        ' InitializeComponent() �Ăяo���̌�ɏ�������ǉ����܂��B

    End Sub

    ' Form �� dispose ���I�[�o�[���C�h���ăR���|�[�l���g�ꗗ���������܂��B
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Windows �t�H�[�� �f�U�C�i�ŕK�v�ł��B
    Private components As System.ComponentModel.IContainer

    ' ���� : �ȉ��̃v���V�[�W���́AWindows �t�H�[�� �f�U�C�i�ŕK�v�ł��B
    ' Windows �t�H�[�� �f�U�C�i���g���ĕύX���Ă��������B  
    ' �R�[�h �G�f�B�^�͎g�p���Ȃ��ł��������B
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt�T�[�o�� As System.Windows.Forms.TextBox
    Friend WithEvents txt���[�U�� As System.Windows.Forms.TextBox
    Friend WithEvents txt�p�X���[�h As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt�f�[�^�x�[�X�� As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txt�T�[�o�� = New System.Windows.Forms.TextBox()
        Me.txt���[�U�� = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt�p�X���[�h = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt�f�[�^�x�[�X�� = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt�T�[�o��
        '
        Me.txt�T�[�o��.Location = New System.Drawing.Point(120, 40)
        Me.txt�T�[�o��.Name = "txt�T�[�o��"
        Me.txt�T�[�o��.Size = New System.Drawing.Size(136, 19)
        Me.txt�T�[�o��.TabIndex = 0
        Me.txt�T�[�o��.Text = ""
        '
        'txt���[�U��
        '
        Me.txt���[�U��.Location = New System.Drawing.Point(120, 88)
        Me.txt���[�U��.Name = "txt���[�U��"
        Me.txt���[�U��.Size = New System.Drawing.Size(136, 19)
        Me.txt���[�U��.TabIndex = 2
        Me.txt���[�U��.Text = "TextBox2"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "�T�[�o��"
        '
        'txt�p�X���[�h
        '
        Me.txt�p�X���[�h.Location = New System.Drawing.Point(120, 112)
        Me.txt�p�X���[�h.Name = "txt�p�X���[�h"
        Me.txt�p�X���[�h.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txt�p�X���[�h.Size = New System.Drawing.Size(136, 19)
        Me.txt�p�X���[�h.TabIndex = 3
        Me.txt�p�X���[�h.Text = "TextBox3"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "���[�U�[��"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "�p�X���[�h"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "�ڑ��e�X�g"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(104, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "�ۑ�"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(200, 176)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 24)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "�L�����Z��"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(296, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "�f�[�^�x�[�X�T�[�o�ւ̐ڑ��ݒ��ύX���܂�"
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
        Me.Label5.Text = "[����]"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(8, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(280, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "�V�X�e�����N�����Ȃ��Ȃ�\��������܂��̂ŁA�ݒ�ɂ������ẮA�\�������Ӊ������B"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(32, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "�f�[�^�x�[�X��"
        '
        'txt�f�[�^�x�[�X��
        '
        Me.txt�f�[�^�x�[�X��.Location = New System.Drawing.Point(120, 64)
        Me.txt�f�[�^�x�[�X��.Name = "txt�f�[�^�x�[�X��"
        Me.txt�f�[�^�x�[�X��.Size = New System.Drawing.Size(136, 19)
        Me.txt�f�[�^�x�[�X��.TabIndex = 1
        Me.txt�f�[�^�x�[�X��.Text = ""
        '
        'CNL1820
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(292, 253)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label7, Me.txt�f�[�^�x�[�X��, Me.Label6, Me.Label5, Me.Label4, Me.Button3, Me.Button2, Me.Button1, Me.Label3, Me.Label2, Me.txt�p�X���[�h, Me.Label1, Me.txt���[�U��, Me.txt�T�[�o��})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CNL1820"
        Me.Text = "JCV90"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private blnSuccess As Boolean
    Private mstr�T�[�o�� As String
    Private mstr�f�[�^�x�[�X�� As String
    Private mstr���[�U�� As String
    Private mstr�p�X���[�h As String

    Private Sub JCV90_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mstr�T�[�o�� = System.Configuration.ConfigurationManager.AppSettings("DBServer Name")
        mstr�f�[�^�x�[�X�� = System.Configuration.ConfigurationManager.AppSettings("DBServer DBName")
        mstr���[�U�� = System.Configuration.ConfigurationManager.AppSettings("DBServer UserID")
        mstr�p�X���[�h = System.Configuration.ConfigurationManager.AppSettings("DBServer PassWD")

        txt�T�[�o��.Text = mstr�T�[�o��
        txt�f�[�^�x�[�X��.Text = mstr�f�[�^�x�[�X��
        txt���[�U��.Text = mstr���[�U��
        txt�p�X���[�h.Text = mstr�p�X���[�h

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        '------------------------------
        ' ���ʊm�F���[�h�Ŏ��s
        '------------------------------
        If GF_ConnectDB(txt�T�[�o��.Text, txt�f�[�^�x�[�X��.Text, txt���[�U��.Text, txt�p�X���[�h.Text, True) Then
            If MsgBox("�f�[�^�x�[�X�T�[�o�ւ̐ڑ��ɐ������܂���" & vbCrLf & _
                      "���̂܂ܐݒ�l��ۑ����܂����H", _
                      MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If LF_SaveAppConfig() = False Then
                    MsgBox("�ݒ�l�̕ۑ��Ɏ��s���܂���", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly)
                Else
                    MsgBox("�ݒ�l��ۑ����܂���", MsgBoxStyle.Information + MsgBoxStyle.OKOnly)
                End If
            End If
        Else
            MsgBox("�f�[�^�x�[�X�T�[�o�ւ̐ڑ��Ɏ��s���܂���")
        End If

    End Sub

    Private Function LF_SaveAppConfig() As Boolean
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim appConfigPath As String
        Dim doc As System.Xml.XmlDocument
        Dim node As System.Xml.XmlNode
        Dim n As System.Xml.XmlNode
        Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_SaveAppConfig = False

        '------------------------------
        ' �\���t�@�C���̃p�X���擾
        '------------------------------
        asm = System.Reflection.Assembly.GetExecutingAssembly
        appConfigPath = System.IO.Path.GetDirectoryName(asm.Location) + "\�X�ܓ����V�X�e��.exe.config"

        '------------------------------
        ' �\���t�@�C����XML DOM�ɓǍ���
        '------------------------------
        doc = New System.Xml.XmlDocument()
        doc.Load(appConfigPath)
        node = doc("configuration")("appSettings")

        '------------------------------
        ' �L�[�l�̕ύX���s��
        '------------------------------
        ' �c�a�T�[�o��
        For Each n In doc("configuration")("appSettings")
            If n.Name = "add" Then
                If n.Attributes.GetNamedItem("key").Value = "DBServer Name" Then
                    n.Attributes.GetNamedItem("value").Value = txt�T�[�o��.Text
                End If
            End If
        Next

        ' �c�a��
        For Each n In doc("configuration")("appSettings")
            If n.Name = "add" Then
                If n.Attributes.GetNamedItem("key").Value = "DBServer DBName" Then
                    n.Attributes.GetNamedItem("value").Value = txt�f�[�^�x�[�X��.Text
                End If
            End If
        Next

        ' ���[�U��
        For Each n In doc("configuration")("appSettings")
            If n.Name = "add" Then
                If n.Attributes.GetNamedItem("key").Value = "DBServer UserID" Then
                    n.Attributes.GetNamedItem("value").Value = txt���[�U��.Text
                End If
            End If
        Next

        ' �p�X���[�h
        For Each n In doc("configuration")("appSettings")
            If n.Name = "add" Then
                If n.Attributes.GetNamedItem("key").Value = "DBServer PassWD" Then
                    n.Attributes.GetNamedItem("value").Value = txt�p�X���[�h.Text
                End If
            End If
        Next

        '------------------------------
        ' �ύX���ꂽ�\���t�@�C����ۑ�
        '------------------------------
        doc.Save(appConfigPath)

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_SaveAppConfig = True

    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If LF_SaveAppConfig() = False Then
            MsgBox("�ݒ�l�̕ۑ��Ɏ��s���܂���", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly)
        Else
            MsgBox("�ݒ�l��ۑ����܂���", MsgBoxStyle.Information + MsgBoxStyle.OKOnly)
        End If

    End Sub

    Private Sub JCV90_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        MsgBox("�ċN�����Ă�������")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
