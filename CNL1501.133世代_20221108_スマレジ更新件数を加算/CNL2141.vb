''' <summary>
''' CrossNavi - ����R�[�X�o�^���
''' </summary>
''' <remarks>2013.03.05 �N���X�R�k�� �V�K�쐬</remarks>
Public Class CNL2141
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_Title = New System.Windows.Forms.TextBox
        Me.btn_OK = New System.Windows.Forms.Button
        Me.btn_Cancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "�� ����R�[�X���̂���͂��Ă�������"
        '
        'txt_Title
        '
        Me.txt_Title.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Title.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_Title.Location = New System.Drawing.Point(24, 37)
        Me.txt_Title.MaxLength = 20
        Me.txt_Title.Name = "txt_Title"
        Me.txt_Title.Size = New System.Drawing.Size(360, 22)
        Me.txt_Title.TabIndex = 1
        Me.txt_Title.Text = "txt_Title"
        '
        'btn_OK
        '
        Me.btn_OK.BackColor = System.Drawing.SystemColors.Control
        Me.btn_OK.Location = New System.Drawing.Point(120, 73)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(72, 32)
        Me.btn_OK.TabIndex = 2
        Me.btn_OK.Text = "����"
        Me.btn_OK.UseVisualStyleBackColor = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Cancel.Location = New System.Drawing.Point(200, 73)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(72, 32)
        Me.btn_Cancel.TabIndex = 3
        Me.btn_Cancel.Text = "�L�����Z��"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'CNL2141
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
        Me.Name = "CNL2141"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "JCV01_4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ''' <summary>
    ''' �t�H�[���ǂݍ��ݎ�����
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CNL2141_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �t�H�[��������
        '------------------------------
        Me.Text = GF_FormText()
        txt_Title.Clear()

    End Sub

    ''' <summary>
    ''' [����]�{�^������������
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click

        '------------------------------
        ' �����̓`�F�b�N
        '------------------------------
        If Len(Trim$(txt_Title.Text)) = 0 Then
            Call GF_Msg("", Replace(GF_GetMsg("E09"), "@@@", "�R�[�X����"), MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            txt_Title.Select()
            Exit Sub
        End If

        '------------------------------
        ' ���ꖼ�̂̕���R�[�X�����ɑ��݂��Ă���ꍇ�́A�G���[���b�Z�[�W��\�����āA�����𒆒f������
        '------------------------------
        Select Case LF_GetTPM010Houdai(Trim$(txt_Title.Text))
            Case CNL1920.FuncResult.CancelEnd
                ' ���݂���̂ŁA�G���[ 
                Call GF_Msg("", "���Ɂy" & Trim$(txt_Title.Text) & "�z�����݂��邽�߁A�g�p�ł��܂���B" & vbCrLf & "���̃R�[�X���̂���͂��ĉ������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                Exit Sub

            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        '------------------------------
        ' ����R�[�X�ǉ�����
        '------------------------------
        If Not LF_InsertNewCourse() Then
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

    ''' <summary>
    ''' �������R�[�X���̑��݃`�F�b�N����
    ''' </summary>
    ''' <param name="pHoudaiNM"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_GetTPM010Houdai(ByVal pHoudaiNM As String) As FuncResult

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM010Houdai = CNL1920.FuncResult.UnusualEnd

        strSQL = ""
        strSQL = strSQL & "SELECT GOODSCD"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " WHERE GOODSNMJ + GOODSNMJ2 = '" & pHoudaiNM & "'"
        strSQL = strSQL & "   AND SUBSTRING(GOODSCD,1,1) = '7'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        If objData.Tables("com").Rows.Count = 0 Then
            LF_GetTPM010Houdai = CNL1920.FuncResult.NormalEnd
        Else
            LF_GetTPM010Houdai = CNL1920.FuncResult.CancelEnd
        End If

    End Function

    ''' <summary>
    ''' [�L�����Z��]�{�^������������
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        With Me
            .DialogResult = DialogResult.Cancel
            .Close()
        End With
    End Sub

    ''' <summary>
    ''' ����R�[�X�ǉ�����
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_InsertNewCourse() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()
        Dim strNewID As String = Nothing
        Dim strCnt As String = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_InsertNewCourse = False

        '------------------------------
        ' TPM010�J�E���g�擾
        '------------------------------
        Select Case GF_GetCntTPM010(strCnt)
            Case CNL1920.FuncResult.CancelEnd
                GF_Msg("", "���i�o�^��������ɒB���܂����B�����ꂩ�̃R�[�X���폜���ĉ������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                LF_InsertNewCourse = True
                Exit Function

            Case CNL1920.FuncResult.UnusualEnd
                Exit Function
        End Select

        '------------------------------
        ' �ŏI�h�c�擾
        '------------------------------
        Select Case GF_GetNewCourseID(strNewID)
            Case CNL1920.FuncResult.CancelEnd
                GF_Msg("", "�R�[�X�o�^��������ɒB���܂����B�����ꂩ�̃R�[�X���폜���ĉ������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                LF_InsertNewCourse = True
                Exit Function

            Case CNL1920.FuncResult.UnusualEnd
                Exit Function
        End Select

        '------------------------------
        ' �g�����U�N�V�����J�n
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        ' ���i�}�X�^�o�^
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM010 VALUES("
        strSQL = strSQL & "'" & strNewID.PadRight(5) & "',"
        strSQL = strSQL & "'" & Mid(txt_Title.Text, 1, 10) & "',"                 ' �s�o���i���P
        strSQL = strSQL & "'" & IIf(Mid(txt_Title.Text, 11, 20) = "", Space(20), Mid(txt_Title.Text, 11, 20)) & "',"              ' �s�o���i���Q
        strSQL = strSQL & "'" & Mid(txt_Title.Text, 1, 10) & "',"                 ' �o�n�r���i���P
        strSQL = strSQL & "'" & Mid(txt_Title.Text, 1, 10) & "',"                 ' �o�n�r���i���Q
        strSQL = strSQL & "'" & Space(180) & "',"                           ' ������
        strSQL = strSQL & "'" & Space(100) & "',"                           ' �摜�f�[�^
        strSQL = strSQL & "0,"                                              ' �P���z
        strSQL = strSQL & "'" & Space(5) & "',"                             ' �P��
        strSQL = strSQL & "'0',"                             ' �i�؂�t���O
        strSQL = strSQL & "'000',"                             ' �r�b�o���P
        strSQL = strSQL & "'000',"                             ' �r�b�o���Q
        strSQL = strSQL & "'000',"                             ' �r�b�o���R
        strSQL = strSQL & "'000',"                             ' �r�b�o���S
        strSQL = strSQL & "'000',"                             ' �r�b�o���T
        strSQL = strSQL & "'000',"                             ' �r�b�o���U
        strSQL = strSQL & "'000',"                             ' �r�b�o���V
        strSQL = strSQL & "'000',"                             ' �r�b�o���W
        strSQL = strSQL & "'000',"                             ' �r�b�o���X
        strSQL = strSQL & "'000',"                             ' �r�b�o���P�O
        strSQL = strSQL & "'000',"                             ' �r�b�o���P�P
        strSQL = strSQL & "'000',"                             ' �r�b�o���P�Q
        strSQL = strSQL & "'0',"                             ' ���i�X�e�[�^�X
        strSQL = strSQL & "'3',"                             ' ���i����
        strSQL = strSQL & "'" & GF_GetBumon() & "',"         ' ����R�[�h
        strSQL = strSQL & "'00000000000000000000000000000000',"             ' �j�b�o�X�e�[�^�X
        strSQL = strSQL & "'0',"                                            ' �摜�Đ����t���O
        strSQL = strSQL & "'" & Space(5) & "',"                             ' HTL���̂P
        strSQL = strSQL & "'" & Space(5) & "',"                             ' HTL���̂Q
        strSQL = strSQL & "'0',"                                            ' �������߃t���O
        strSQL = strSQL & "'0',"                                            ' �V��t���O
        strSQL = strSQL & "'" & GC_UPDID & "',"
        strSQL = strSQL & "'" & Now & "')"

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        '������@�\�Ή�
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then

            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM010A VALUES("
            strSQL = strSQL & "N'" & strNewID.PadRight(5) & "',"
            strSQL = strSQL & "N'" & Space(10) & "',"              ' �s�o���i���P
            strSQL = strSQL & "N'" & Space(10) & "',"              ' �s�o���i���Q
            strSQL = strSQL & "N'" & Space(180) & "',"             ' ������
            strSQL = strSQL & "N'" & GC_UPDID & "',"
            strSQL = strSQL & "N'" & Now & "')"

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM010B VALUES("
            strSQL = strSQL & "N'" & strNewID.PadRight(5) & "',"
            strSQL = strSQL & "N'" & Space(10) & "',"              ' �s�o���i���P
            strSQL = strSQL & "N'" & Space(10) & "',"              ' �s�o���i���Q
            strSQL = strSQL & "N'" & Space(180) & "',"             ' ������
            strSQL = strSQL & "N'" & GC_UPDID & "',"
            strSQL = strSQL & "N'" & Now & "')"

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM010C VALUES("
            strSQL = strSQL & "N'" & strNewID.PadRight(5) & "',"
            strSQL = strSQL & "N'" & Space(10) & "',"              ' �s�o���i���P
            strSQL = strSQL & "N'" & Space(10) & "',"              ' �s�o���i���Q
            strSQL = strSQL & "N'" & Space(180) & "',"             ' ������
            strSQL = strSQL & "N'" & GC_UPDID & "',"
            strSQL = strSQL & "N'" & Now & "')"

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

        End If

        ' �H�׈��ݕ���R�[�X�}�X�^�o�^
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM170 VALUES("
        strSQL = strSQL & "'" & strNewID.PadRight(5) & "',"
        strSQL = strSQL & "0,"                  ' �H�׈��ݕ��莞��
        strSQL = strSQL & "'0'," ' �H�׈��ݕ���R�[�X�O���[�vID
        strSQL = strSQL & "'" & GC_UPDID & "',"
        strSQL = strSQL & "'" & Now & "')"

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        ' �H�׈��ݕ���R�[�X�}�X�^�o�^
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM300 VALUES("
        strSQL = strSQL & "'" & strNewID.PadRight(5) & "',"
        strSQL = strSQL & "1,"                  ' ���X�g�I�[�_�[����
        strSQL = strSQL & "'" & GC_UPDID & "',"
        strSQL = strSQL & "'" & Now & "')"

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM200 VALUES("
        strSQL = strSQL & "'" & strNewID.PadRight(5) & "',"                                                            ' GOODSCD
        strSQL = strSQL & "'" & strNewID.PadRight(5).Substring(0, 1) & strNewID.PadRight(5).Substring(2) & "',"        ' SEARCHNUMBER
        strSQL = strSQL & "'" & GC_UPDID & "',"                                                                        ' UPDID
        strSQL = strSQL & "'" & Now & "')"                                                                             ' UPDYMD

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM330 VALUES("
        strSQL = strSQL & "'" & strNewID.PadRight(5) & "',"                                    ' GOODSCD
        strSQL = strSQL & "'0',"                                                               ' ENABLEDFLG
        strSQL = strSQL & "'" & GC_UPDID & "',"                                                ' UPDID
        strSQL = strSQL & "'" & Now & "')"                                                     ' UPDYMD

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM340 VALUES("
        strSQL = strSQL & "'" & strNewID.PadRight(5) & "',"                                    ' GOODSCD
        strSQL = strSQL & "'0',"                                                               ' COST
        strSQL = strSQL & "'" & GC_UPDID & "',"                                                ' UPDID
        strSQL = strSQL & "'" & Now & "')"                                                     ' UPDYMD

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM350 VALUES("
        strSQL = strSQL & "'" & strNewID.PadRight(5) & "',"                                                ' GOODSCD
        strSQL = strSQL & "'0',"                                                               ' DELIVARYFLG
        strSQL = strSQL & "'" & GC_UPDID & "',"                                                ' UPDID
        strSQL = strSQL & "'" & Now & "')"                                                     ' UPDYMD

        If Not GF_UpdData(strSQL) Then
            If Not GF_RollbackTrans() Then
                Exit Function
            End If
            Exit Function
        End If

        '------------------------------
        ' �g�����U�N�V�����m��
        '------------------------------
        If Not GF_CommitTrans() Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_InsertNewCourse = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�^�C�g���e�L�X�g�{�b�N�X�ύX������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub txt_Title_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Title.TextChanged

        Try
            '------------------------------
            ' �����ϐ���`
            '------------------------------
            Dim lngST As Long

            lngST = txt_Title.SelectionStart
            ' 2014-05-12 2�o�C�g������������
            'txt_Title.Text = StrConv(txt_Title.Text, VbStrConv.Wide)
            If lngST >= 0 Then
                txt_Title.SelectionStart = lngST
            End If

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

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pResultID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GF_GetNewCourseID(ByRef pResultID As String) As FuncResult

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        pResultID = ""

        '------------------------------
        ' �ŏI�̔Ԓl�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TOP 1 GOODSCD "
        strSQL = strSQL & "FROM TPM010 "
        strSQL = strSQL & "WHERE SUBSTRING(GOODSCD,1,1) = '7' "
        strSQL = strSQL & "ORDER BY GOODSCD DESC "

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            pResultID = "7000"
            Return FuncResult.NormalEnd
        End If

        If Not GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        pResultID = CStr(CInt(Trim$(objRows("GOODSCD"))) + 1)

        If CInt(pResultID) > 7999 Then
            Return FuncResult.CancelEnd
        Else
            Return FuncResult.NormalEnd
        End If

    End Function

    Private Function GF_GetCntTPM010(ByRef pCnt As String) As FuncResult

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim intLimitCnt As Integer

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        pCnt = ""

        '------------------------------
        ' �ŏI�̔Ԓl�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & " SELECT COUNT(*) AS CNT"
        strSQL = strSQL & " FROM TPM010"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        pCnt = CInt(Trim$(objRows("CNT")))

        intLimitCnt = CInt(Trim$(GF_GetAppInfo("LIMIT_GOODS_CNT")))

        If CInt(pCnt) > intLimitCnt Then
            Return FuncResult.CancelEnd
        Else
            Return FuncResult.NormalEnd
        End If

    End Function
End Class
