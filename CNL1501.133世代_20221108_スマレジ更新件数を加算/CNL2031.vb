' --------------------------------------------------------------------------------
' �@�@�@�@�\�FCrossNavi - ���i�ԍ��V�K�ǉ����
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------
Public Class CNL2031
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
        Me.Label1.Text = "�� ���i�ԍ�����͂��Ă�������"
        '
        'txt_Title
        '
        Me.txt_Title.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Title.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_Title.Location = New System.Drawing.Point(65, 37)
        Me.txt_Title.Name = "txt_Title"
        Me.txt_Title.Size = New System.Drawing.Size(320, 22)
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
        'CNL2031
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
        Me.Name = "CNL2031"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CNL2031"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���ǂݍ��ݎ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub CNL2031_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �t�H�[��������
        '------------------------------
        Me.Text = GF_FormText()
        txt_Title.Clear()

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F����{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------

        '------------------------------
        ' �����̓`�F�b�N
        '------------------------------
        If Len(Trim$(txt_Title.Text)) = 0 Then
            Call GF_Msg("E01", "", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            txt_Title.Select()
            Exit Sub
        End If

        '------------------------------
        ' �����`�F�b�N
        '------------------------------
        If IsNumeric(Trim$(txt_Title.Text)) = False Then
            Call GF_Msg("", "���i�ԍ��͐����݂̂���͂��Ă��������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            txt_Title.Select()
            Exit Sub
        End If

        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(txt_Title.Text) <> 4 Then
            Call GF_Msg("", "���i�ԍ���4���œ��͂��Ă��������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            txt_Title.Select()
            Exit Sub
        End If

        '------------------------------
        ' ���i�ԍ��g�p�����`�F�b�N(�g�p�͈́F9001�`9900)
        '------------------------------
        If CInt(txt_Title.Text) < 9001 Or CInt(txt_Title.Text) > 9900 Then
            Call GF_Msg("", "���݁A�R�����g�I�v�V�����p�̏��i�ԍ��̂ݓo�^�\�ł��B" & vbCrLf & "(�g�p�\�͈�:9001�`9900)", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
            txt_Title.Select()
            Exit Sub
        End If

        '------------------------------
        ' ���ꏤ�i�ԍ����݃`�F�b�N
        '------------------------------
        Select Case LF_GetTPM010(Trim$(txt_Title.Text))
            Case CNL1920.FuncResult.CancelEnd
                ' �d���G���[ 
                Call GF_Msg("", "���i�ԍ��y" & Trim$(txt_Title.Text) & "�z�͊��ɓo�^����Ă��܂��B" & vbCrLf & "�ēx�A���͂��ĉ������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                Exit Sub
            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        '------------------------------
        ' ���i��񃌃R�[�h�ǉ�
        '------------------------------
        If Not LF_InsertTPM010(Trim$(txt_Title.Text)) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' TPM600�����݃��R�[�h�쐬����
        '------------------------------
        Call LF_InsTPM600()

        With Me
            .DialogResult = DialogResult.OK
            .Close()
        End With

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_OK_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���ꏤ�i�ԍ����݃`�F�b�N����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2004.05.31 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM010(ByVal pGoodsCD As String) As FuncResult

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM010 = CNL1920.FuncResult.UnusualEnd

        strSQL = ""
        strSQL = strSQL & "SELECT GOODSCD"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " WHERE GOODSCD = '" & pGoodsCD & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        If objData.Tables("com").Rows.Count = 0 Then
            LF_GetTPM010 = CNL1920.FuncResult.NormalEnd
        Else
            LF_GetTPM010 = CNL1920.FuncResult.CancelEnd
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���i��񃌃R�[�h�ǉ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_InsertTPM010(ByVal pGoodsCD As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()
        Dim dtsRows As DataRow = Nothing
        Dim intCnt As Integer
        Dim intLimitCnt As Integer

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_InsertTPM010 = False

        '------------------------------
        ' ���i�o�^�����擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT COUNT(*) AS CNT"
        strSQL = strSQL & "  FROM TPM010"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        If dtsData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not GF_GetRows(dtsData, 0, dtsRows) Then
            Exit Function
        End If

        intCnt = CInt(Trim$(dtsRows("CNT")))

        intLimitCnt = CInt(Trim$(GF_GetAppInfo("LIMIT_GOODS_CNT")))

        If intCnt > intLimitCnt Then
            GF_Msg("", "���i�o�^��������ɒB�������ߓo�^�ł��܂���B" & vbCrLf & "���g�p�̏��i�ԍ��������p���������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            LF_InsertTPM010 = True
            Exit Function

        Else
            Dim multiLingCnt As Integer = 0
            Dim lngCnt As Integer = 0

            ' 2017.10.10 ������s��Ή��i�J�n�j
            'If GF_GetAppInfo2("MULTI_LING_USE") = "0" Then
            '    ' ������Ή����Ȃ�
            '    multiLingCnt = 0
            'Else
            '    ' ������Ή�����
            '    '2014-04-25 ��{���� + 1���� �̍ەs�����b�菈�u
            '    ' TPM010B�ɂ��o�^���Ȃ��Ə��i�o�^��ʂŕs�����̃G���[���N����
            '    'multiLingCnt = CInt(GF_GetAppInfo3("MULTI_LING_CNT"))
            '    ' 2014-11-11 ����Ɏb��ł��ǂ�
            '    'multiLingCnt = 2
            '    multiLingCnt = CInt(GF_GetAppInfo3("MULTI_LING_CNT"))
            'End If
            multiLingCnt = 3 '�������������ɂ��Ă�TPM010�֘A�͑S�ēo�^���Ȃ���Εs�����̃G���[���N����
            ' 2017.10.10 ������s��Ή��i�I���j

            '------------------------------
            ' �g�����U�N�V�����J�n
            '------------------------------
            If Not GF_BeginTrans() Then
                Exit Function
            End If

            While lngCnt < multiLingCnt + 1
                ' ���i�}�X�^�X�V(TPM010)
                strSQL = ""
                If lngCnt = 0 Then
                    strSQL = strSQL & "INSERT INTO TPM010 VALUES("
                    strSQL = strSQL & "'" & pGoodsCD & "',"                  ' GOODSCD
                    strSQL = strSQL & "'" & Space(10) & "',"                 ' GOODSNMJ
                    strSQL = strSQL & "'" & Space(10) & "',"                 ' GOODSNMJ2
                    strSQL = strSQL & "'�R�����g�I�v�V����',"                ' GOODSNMJ3
                    strSQL = strSQL & "'" & Space(10) & "',"                 ' GOODSNMJ4
                    strSQL = strSQL & "'" & Space(180) & "',"                ' JEXPNOTEJ
                    strSQL = strSQL & "'" & Space(100) & "',"                ' IMAGEDATA
                    strSQL = strSQL & "0,"                                   ' PRICE
                    strSQL = strSQL & "'" & Space(5) & "',"                  ' UNITJ
                    strSQL = strSQL & "'1',"                                 ' SELLFLG
                    strSQL = strSQL & "'000',"                               ' SCPNO01
                    strSQL = strSQL & "'000',"                               ' SCPNO02
                    strSQL = strSQL & "'000',"                               ' SCPNO03
                    strSQL = strSQL & "'000',"                               ' SCPNO04
                    strSQL = strSQL & "'000',"                               ' SCPNO05
                    strSQL = strSQL & "'000',"                               ' SCPNO06
                    strSQL = strSQL & "'000',"                               ' SCPNO07
                    strSQL = strSQL & "'000',"                               ' SCPNO08
                    strSQL = strSQL & "'000',"                               ' SCPNO09
                    strSQL = strSQL & "'000',"                               ' SCPNO10
                    strSQL = strSQL & "'000',"                               ' SCPNO11
                    strSQL = strSQL & "'000',"                               ' SCPNO12
                    strSQL = strSQL & "'1',"                                 ' STATUS
                    strSQL = strSQL & "'3',"                                 ' GOODSKIND
                    strSQL = strSQL & "'" & GF_GetBumon() & "',"             ' BUMONCD
                    strSQL = strSQL & "'00000000000000000000000000000000',"  ' KCPSTATUS
                    strSQL = strSQL & "'0',"                                 ' GENERATEFLG
                    strSQL = strSQL & "'***',"                               ' HTLNM1
                    strSQL = strSQL & "'***',"                               ' HTLNM2
                    strSQL = strSQL & "'0',"                                 ' SPFLG
                    strSQL = strSQL & "'0',"                                 ' NEWFLG
                    strSQL = strSQL & "'" & GC_UPDID & "',"                  ' UPDID
                    strSQL = strSQL & "'" & Now & "')"                       ' UPDYMD
                Else
                    Select Case lngCnt
                        Case 1
                            strSQL = strSQL & "INSERT INTO TPM010A VALUES("
                        Case 2
                            strSQL = strSQL & "INSERT INTO TPM010B VALUES("
                        Case 3
                            strSQL = strSQL & "INSERT INTO TPM010C VALUES("
                        Case Else
                            strSQL = strSQL & "INSERT INTO TPM010D VALUES("
                    End Select
                    strSQL = strSQL & "N'" & pGoodsCD & "',"                  ' GOODSCD
                    strSQL = strSQL & "N'" & Space(10) & "',"                 ' GOODSNMJ
                    strSQL = strSQL & "N'" & Space(10) & "',"                 ' GOODSNMJ2
                    strSQL = strSQL & "N'" & Space(180) & "',"                ' JEXPNOTEJ
                    strSQL = strSQL & "N'" & GC_UPDID & "',"                  ' UPDID
                    strSQL = strSQL & "N'" & Now & "')"                       ' UPDYMD
                End If

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                lngCnt = lngCnt + 1
            End While

            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM200 VALUES("
            strSQL = strSQL & "'" & pGoodsCD & "',"                                                ' GOODSCD
            strSQL = strSQL & "'" & pGoodsCD.Substring(1, 1) & pGoodsCD.Substring(3) & "',"        ' SEARCHNUMBER
            strSQL = strSQL & "'" & GC_UPDID & "',"                                                ' UPDID
            strSQL = strSQL & "'" & Now & "')"                                                     ' UPDYMD

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM330 VALUES("
            strSQL = strSQL & "'" & pGoodsCD & "',"                                                ' GOODSCD
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
            strSQL = strSQL & "'" & pGoodsCD & "',"                                                ' GOODSCD
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
            strSQL = strSQL & "'" & pGoodsCD & "',"                                                ' GOODSCD
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

        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_InsertTPM010 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L�����Z���{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        With Me
            .DialogResult = DialogResult.Cancel
            .Close()
        End With
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�e�L�X�g�{�b�N�X�L�[�_�E�����C�x���g�n���h��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub txt_Title_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Title.KeyPress

        '------------------------------
        ' 4���ȏ���͂�����Ԃł�BackSpace�ȊO�̃L�[���͂��L�����Z��
        '------------------------------
        If Len(txt_Title.Text) >= 4 And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

        '------------------------------
        ' �����ABackSpace�ȊO�̃L�[���͂��L�����Z��
        '------------------------------
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub

    ''' <summary>
    ''' --------------------------------------------------------------------------------
    ''' �@�@�@�\�FTPM600������ں��ލ쐬����
    ''' �@�\�T�v�FTPM010�ɑ��݂��āATPM600�ɖ����݂̃��R�[�h��TPM600�ɍ쐬����
    ''' ���@�@���F
    ''' �� �� �l�F
    ''' ���@�@���F2019.08.08 �ڽ��k��)takigaura �V�K�쐬
    ''' --------------------------------------------------------------------------------
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_InsTPM600() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim stbSQL As New System.Text.StringBuilder

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_InsTPM600 = False

        '------------------------------
        ' �g�����U�N�V�����J�n
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        '------------------------------
        ' �X�V����
        '------------------------------
        With stbSQL
            .Length = 0
            .AppendLine("INSERT INTO TPM600")
            .AppendLine("SELECT")
            .AppendLine("     TPM010.GOODSCD AS ���i�R�[�h")
            .AppendLine(",    RIGHT('00000000000000'  + RTRIM(CAST(GOODSCD  AS VARCHAR)) ,14)     AS ���j���[�R�[�h")
            If GF_GetAppInfo("TEC_OWN_COM_CD_FLG") = GC_TRUE Then
                '���ЃR�[�h - �����l�ݒ�Ȃ�
                .AppendLine(",    '00000000000000'  AS ���ЃR�[�h")
            Else
                '���ЃR�[�h - �����l�ݒ肠��
                .AppendLine(",    RIGHT('00000000000000'  + RTRIM(CAST(GOODSCD  AS VARCHAR)) ,14)     AS ���ЃR�[�h")
            End If
            .AppendLine(",    0       AS '�P��(�y���ŗ�)'")
            .AppendLine(",    0       AS �T�u���j���[�P��")
            .AppendLine(",    0       AS '�T�u���j���[�P��(�y���ŗ�)'")
            .AppendLine(",    '0'     AS �P�����")
            .AppendLine(",    '0'     AS �ŃX�e�[�^�X")
            .AppendLine(",    '0'     AS '�ŃX�e�[�^�X(�y���ŗ�)'")
            .AppendLine(",    '0'     AS ���ʉ��M")
            .AppendLine(",    '0'     AS ���v����")
            .AppendLine(",    '1'     AS ���H���A")
            .AppendLine(",    '0'     AS OES�p���j���[")
            .AppendLine(String.Format(",   '{0}'    AS �X�V��", GC_UPDID))
            .AppendLine(String.Format(",   '{0}'    AS �X�V��", Now))
            .AppendLine("FROM TPM010")
            .AppendLine("WHERE    NOT EXISTS( SELECT  *")
            .AppendLine("                     FROM    TPM600")
            .AppendLine("                     WHERE   TPM010.GOODSCD = TPM600.GOODSCD    )")
        End With

        If Not GF_UpdCmtData(stbSQL.ToString) Then
            Exit Function
        End If

        '------------------------------
        ' �g�����U�N�V�����m��
        '------------------------------
        If Not GF_CommitTrans() Then
            Call GF_RollbackTrans()
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_InsTPM600 = True

    End Function

End Class
