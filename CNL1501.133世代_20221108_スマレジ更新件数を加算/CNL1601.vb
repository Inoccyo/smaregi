' --------------------------------------------------------------------------------
' �@�@�@�@�\�F�X�ܓ����V�X�e�� - �T�[�o�����e�i���X(�o�b�N�A�b�v�^���J�o��)
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------

Public Class CNL1601
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
        Me.Label1.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "�� �o�b�N�A�b�v��ۑ��ł���ő����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "�� �P���̍ő�o�b�N�A�b�v��"
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
        Me.Button2.Text = "�L�����Z��"
        '
        'txtMaxDay
        '
        Me.txtMaxDay.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
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
        Me.txtMaxBK.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
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
        Me.Label3.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label3.Location = New System.Drawing.Point(352, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "��"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label4.Location = New System.Drawing.Point(352, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "��"
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
    ' �@�@�@�@�\�F�t�H�[���ǂݍ��ݎ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub TP1061_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �t�H�[�����̐ݒ�
        '------------------------------
        Me.Text = GF_FormText("- �o�b�N�A�b�v�E���J�o�����")

        '------------------------------
        ' �t�H�[������������
        '------------------------------
        txtMaxDay.Text = g_udtAppConfig.strBK_MaxDay
        txtMaxBK.Text = g_udtAppConfig.strBK_MaxTime

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���͒l��������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
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
    ' �@�@�@�@�\�F�n�j�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strFlds() As String
        Dim strFld As String
        Dim strSubFld() As String
        Dim lngCnt As Long

        ' --- (2003.12.02) �����͎��A�G���[�ƂȂ錻�ۂ���� ----------------
        If Len(Trim$(txtMaxDay.Text)) = 0 Then
            txtMaxDay.Text = "1"
        End If
        If Len(Trim$(txtMaxBK.Text)) = 0 Then
            txtMaxBK.Text = "1"
        End If
        ' ------------------------------------------------------------------

        '------------------------------
        ' �s�v�f�B���N�g���폜(�e)
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
        ' �s�v�f�B���N�g���폜(�q)
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
    ' �@�@�@�@�\�F�L�����Z���{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FApp.Config�t�@�C�� ������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_SaveAppConfig() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_SaveAppConfig = False

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^ �X�V
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM040"
        strSQL = strSQL & "   SET TPM040.BK_MAXDAY  = '" & Trim$(txtMaxDay.Text) & "',"
        strSQL = strSQL & "       TPM040.BK_MAXTIME = '" & Trim$(txtMaxBK.Text) & "'"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_SaveAppConfig = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ő�ێ��������� ���͎�����
    ' �@�@�\�T�v�F�ő�ێ��������ڂɂ��āA���͒��������s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.12.02 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub txtMaxDay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaxDay.TextChanged
        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(txtMaxDay.Text) > 2 Then
            txtMaxDay.Text = GF_MidB(txtMaxDay.Text, 1, 2)
            txtMaxDay.SelectionStart = GF_LenB(txtMaxDay.Text)
            Exit Sub
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ő�ێ��񐔍��� ���͎�����
    ' �@�@�\�T�v�F�ő�ێ��񐔍��ڂɂ��āA���͒��������s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.12.02 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub txtMaxBK_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaxBK.TextChanged
        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(txtMaxBK.Text) > 2 Then
            txtMaxBK.Text = GF_MidB(txtMaxBK.Text, 1, 2)
            txtMaxBK.SelectionStart = GF_LenB(txtMaxBK.Text)
            Exit Sub
        End If
    End Sub
End Class
