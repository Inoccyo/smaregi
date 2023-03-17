Public Class CNL1581
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
        Me.Label1.Text = "�� �V�����쐬������ݕ��胁�j���[������͂��Ă�������"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btn_OK
        '
        Me.btn_OK.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_OK.Location = New System.Drawing.Point(264, 72)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(88, 32)
        Me.btn_OK.TabIndex = 2
        Me.btn_OK.Text = "�쐬"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(368, 72)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(88, 32)
        Me.btn_Cancel.TabIndex = 3
        Me.btn_Cancel.Text = "�L�����Z��"
        '
        'txt_Title
        '
        Me.txt_Title.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
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
        Me.Text = "�V�K�쐬"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CNL1581_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �t�H�[��������
        '------------------------------
        Me.Text = GF_FormText()
        txt_Title.Clear()

        Label1.Text = "�V�����쐬����" & GF_GetAppInfo("FREE_MENU_NM") & "���j���[������͂��Ă��������B"

    End Sub

    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click

        '------------------------------
        ' �����̓`�F�b�N
        '------------------------------
        If Len(Trim$(txt_Title.Text)) = 0 Then
            Call GF_Msg("E01", "", MsgBoxStyle.OKOnly, MsgBoxStyle.Critical)
            txt_Title.Select()
            Exit Sub
        End If

        ' ���ꖼ�̂̃��j���[�����ɑ��݂��Ă���ꍇ�́A�G���[���b�Z�[�W��\�����āA�����𒆒f������
        Select Case LF_GetTPM170(Trim$(txt_Title.Text))
            Case CNL1920.FuncResult.CancelEnd
                ' ���݂���̂ŁA�G���[ 
                Call GF_Msg("", "���Ɂy" & Trim$(txt_Title.Text) & "�z�����݂��邽�߁A�g�p�ł��܂���B" & vbCrLf & "���̃��j���[������͂��ĉ������B", MsgBoxStyle.OKOnly, MsgBoxStyle.Critical)
                Exit Sub

            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        '------------------------------
        ' ���j���[���R�[�h�ǉ�����
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
        '** ���͂��ꂽ���j���[���̂̑��݃`�F�b�N

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
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
        ' �ԋp�l�ݒ�
        '------------------------------
        If objData.Tables("com").Rows.Count = 0 Then
            LF_GetTPM170 = CNL1920.FuncResult.NormalEnd
        Else
            LF_GetTPM170 = CNL1920.FuncResult.CancelEnd
        End If

    End Function

    Private Function LF_InsertNewMenu() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String = Nothing
        Dim dtsData As New DataSet()
        Dim strNewID As String = Nothing
        Dim strGoodsCD1 As String = Nothing
        Dim strGoodsCD2 As String = Nothing
        Dim strGoodsNM1 As String = Nothing
        Dim strGoodsNM2 As String = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_InsertNewMenu = False

        ' �V�K���j���[�h�c�擾
        If Not GF_GetNewID2(strNewID) Then
            Exit Function
        End If

        ' �T�u���j���[���i�R�[�h�̔�
        ' --- ��(2008.11.25) �M����L���̈��ݕ���Ή��̂��ߏC���� ---
        'If Not GF_GetGoodsCD(strGoodsCD1, strGoodsCD2, 8000) Then
        If Not GF_GetGoodsCD(strGoodsCD1, strGoodsCD2, 7000) Then
        ' --- ��(2008.11.25) �M����L���̈��ݕ���Ή��̂��ߏC���� ---
            Exit Function
        End If

        ' �T�u���j���[���i�R�[�h�����i�}�X�^(TPM010)�ɓo�^
        strGoodsNM1 = "�P" & Mid$(Trim$(txt_Title.Text), 1, 19)
        If Not GF_InTPM010(strGoodsCD1, strGoodsNM1) Then
            Exit Function
        End If
        strGoodsNM2 = "�Q" & Mid$(Trim$(txt_Title.Text), 1, 19)
        If Not GF_InTPM010(strGoodsCD2, strGoodsNM2) Then
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM170 VALUES("
        strSQL = strSQL & "'" & strNewID & "',"                                 ' ���j���[�h�c
        strSQL = strSQL & "'" & GF_RepQuo(Trim$(txt_Title.Text)) & "',"         ' ���j���[����
        strSQL = strSQL & "'0',"                                                ' ���j���[�`��
        strSQL = strSQL & "'0000',"                                             ' ���i�O���[�v�h�c
        strSQL = strSQL & "'0',"                                                ' �\����
        strSQL = strSQL & "'0',"                                                ' �P���\���L��
        strSQL = strSQL & "'1',"                                                ' ���z�^�O���[�v���敪
        strSQL = strSQL & "'1',"                                  ' �L���t���O
        strSQL = strSQL & "0,"                                                  ' ���ݕ��莞��
        strSQL = strSQL & "'" & strGoodsCD1 & "',"                              ' �T�u���j���[�P���i�R�[�h
        strSQL = strSQL & "'0',"                                                ' �T�u���j���[�P�L���t���O
        strSQL = strSQL & "'" & strGoodsCD2 & "',"                              ' �T�u���j���[�Q���i�R�[�h
        strSQL = strSQL & "'0',"                                                ' �T�u���j���[�P�L���t���O
        strSQL = strSQL & "'" & GC_UPDID & "',"
        strSQL = strSQL & "'" & Now & "')"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '--- (2006.06.16) STN100�o�[�W�����A�b�v �g�s�k�p���i�s�v ------------------------------------
        '' �n���f�B�p�T�u���j���[���i�R�[�h�̔�
        'If Not GF_GetGoodsCD(strGoodsCD1, strGoodsCD2, 7000) Then
        '    Exit Function
        'End If
        '' �n���f�B�p�T�u���j���[���i�R�[�h�����i�}�X�^(TPM010)�ɓo�^
        'If Not GF_InTPM010(strGoodsCD1, strGoodsNM1) Then
        '    Exit Function
        'End If
        'If Not GF_InTPM010(strGoodsCD2, strGoodsNM2) Then
        '    Exit Function
        'End If
        '---------------------------------------------------------------------------------------------

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_InsertNewMenu = True

    End Function

    Private Sub txt_Title_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Title.TextChanged

        Try
            Dim lngST As Long
            lngST = txt_Title.SelectionStart
            ' 2014-05-12 2�o�C�g������������
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
