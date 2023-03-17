Public Class CNL1533
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
    Friend WithEvents lst_KCP As System.Windows.Forms.CheckedListBox
    Friend WithEvents btn_OK As System.Windows.Forms.Button
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CNL1533))
        Me.lst_KCP = New System.Windows.Forms.CheckedListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_OK = New System.Windows.Forms.Button
        Me.btn_Cancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lst_KCP
        '
        Me.lst_KCP.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lst_KCP.Items.AddRange(New Object() {"�v�v�v�v"})
        Me.lst_KCP.Location = New System.Drawing.Point(8, 32)
        Me.lst_KCP.Name = "lst_KCP"
        Me.lst_KCP.Size = New System.Drawing.Size(224, 310)
        Me.lst_KCP.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "�� ���i�o�͐��I�����ĉ�����"
        '
        'btn_OK
        '
        Me.btn_OK.BackColor = System.Drawing.SystemColors.Control
        Me.btn_OK.Font = New System.Drawing.Font("�l�r �S�V�b�N", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_OK.Location = New System.Drawing.Point(12, 348)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(104, 24)
        Me.btn_OK.TabIndex = 2
        Me.btn_OK.Text = "����"
        Me.btn_OK.UseVisualStyleBackColor = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("�l�r �S�V�b�N", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(124, 348)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(104, 24)
        Me.btn_Cancel.TabIndex = 3
        Me.btn_Cancel.Text = "�L�����Z��"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'CNL1533
        '
        Me.AcceptButton = Me.btn_OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(240, 381)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lst_KCP)
        Me.Name = "CNL1533"
        Me.Text = "CNL1533"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public G_KCPStatus As String

    Private Sub CNL1533_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = GF_FormText(" - ���i�o�͐�I��")
        Call LS_FormSetup()

    End Sub

    Private Sub LS_FormSetup()

        Dim lngCnt As Long
        Dim strWork(3) As String
        Dim lngBitCnt As Long
        Dim lngAryCnt As Long
        Dim blnEnabled As Boolean
        ' 2017.1.1 �����Ă���i���� �N���X�R�k�� �c��
        Dim strSQL As String = Nothing
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim IntCnt As Integer
        Dim IntSEATID As Integer
        Dim IntArray() As Integer
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        ' 2017.1.1 �����Ă���i���� �N���X�R�k�� �c��


        Try

            ' 2017.1.1 �����Ă���i���� �N���X�R�k�� �c��
            'If Len(Trim$(G_KCPStatus)) = 0 Then
            '    GoTo SYSTEM_ERROR
            'Else
            '    strWork(0) = Mid$(G_KCPStatus, 1, 8)
            '    strWork(1) = Mid$(G_KCPStatus, 9, 8)
            '    strWork(2) = Mid$(G_KCPStatus, 17, 8)
            '    strWork(3) = Mid$(G_KCPStatus, 25, 8)
            'End If

            'With lst_KCP
            '    .Items.Clear()
            '    lngAryCnt = 0
            '    lngBitCnt = 8
            '    For lngCnt = 1 To 32
            '        If (lngCnt - 1) Mod 8 = 0 And (lngCnt - 1) <> 0 Then
            '            lngAryCnt = lngAryCnt + 1
            '            lngBitCnt = 8
            '        End If
            '        If Mid$(strWork(lngAryCnt), lngBitCnt, 1) = "1" Then
            '            blnEnabled = True
            '        Else
            '            blnEnabled = False
            '        End If
            '        lngBitCnt = lngBitCnt - 1
            '        ' 2014-05-12 2�o�C�g������������
            '        '.Items.Add("�o�͐�" & StrConv(Format$(lngCnt, "00"), VbStrConv.Wide) & Space(100) & vbTab & lngCnt, blnEnabled)
            '        .Items.Add("�o�͐�" & Format$(lngCnt, "00") & Space(100) & vbTab & lngCnt, blnEnabled)
            '    Next
            'End With

            ' KCP�����\���t���O���L���ȂƂ�
            If GF_GetAppInfo3("KCP_LIMIT") = "1" Then

                ' ���[���U�蕪���t���O���L���ȂƂ�
                If GF_GetAppInfo("LEENWAKE_FLG") = "1" Then

                    IntCnt = 0

                    strSQL = ""
                    strSQL = strSQL & "SELECT  *"
                    strSQL = strSQL & "  FROM  TPM050"
                    strSQL = strSQL & " WHERE  TERMKIND = 'TC8'"
                    strSQL = strSQL & "    OR  TERMKIND = 'TT2'"
                    strSQL = strSQL & "    OR  TERMKIND = 'TCQ'"
                    strSQL = strSQL & " ORDER BY SEATID"

                    If Not GF_GetData(strSQL, objData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    IntCnt = objData.Tables("com").Rows.Count

                    If IntCnt = 0 Then
                        GoTo SYSTEM_ERROR
                    End If

                    ReDim Preserve IntArray(IntCnt - 1)

                    For j = 0 To IntCnt - 1

                        If Not GF_GetRows(objData, j, objRows) Then
                            GoTo SYSTEM_ERROR
                        End If

                        IntArray(j) = Trim$(objRows("SEATID"))

                    Next

                    ' ---------- 2020/03/09 ���[���U�蕪��20�ӏ��Ή�(START) ----------
                    'For j = 0 To 3
                    For j = 0 To 19
                    ' ---------- 2020/03/09 ���[���U�蕪��20�ӏ��Ή�(END) ----------

                        Select Case j
                            Case 0
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_L")))
                            Case 1
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_R")))
                            Case 2
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_L2")))
                            Case 3
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_R2")))
                            ' ---------- 2020/03/09 ���[���U�蕪��20�ӏ��Ή�(START) ----------
                            Case 4
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_05")))
                            Case 5
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_06")))
                            Case 6
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_07")))
                            Case 7
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_08")))
                            Case 8
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_09")))
                            Case 9
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_10")))
                            Case 10
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_11")))
                            Case 11
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_12")))
                            Case 12
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_13")))
                            Case 13
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_14")))
                            Case 14
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_15")))
                            Case 15
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_16")))
                            Case 16
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_17")))
                            Case 17
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_18")))
                            Case 18
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_19")))
                            Case 19
                                IntSEATID = CInt(Trim$(GF_GetAppInfo("LEENWAKE_KCPNO_20")))
                            ' ---------- 2020/03/09 ���[���U�蕪��20�ӏ��Ή�(END) ----------
                        End Select

                        ' ---------- 2020/03/09 ���[���U�蕪��20�ӏ��Ή�(START) ----------
                        '�o�͐�ԍ���33�ȏ�iTPM090��LEENWAKE_KCPNO_**�ɐݒ肵���l���o�͐�Ƃ��đ��݂��Ȃ��ԍ��j�̏ꍇ�͐ݒ肵�Ȃ�
                        If IntSEATID < 33 Then
                            '�擾�����e�[�u���ԍ������ɐݒ肳��Ă���ꍇ�͐ݒ肵�Ȃ�
                            If Array.IndexOf(IntArray, IntSEATID) < 0 Then
                                IntCnt = UBound(IntArray) + 1

                                ReDim Preserve IntArray(IntCnt)

                                IntArray(IntCnt) = IntSEATID
                            End If
                        End If
                        ' ---------- 2020/03/09 ���[���U�蕪��20�ӏ��Ή�(END) ----------

                    Next

                    '2017-08-08 �y���z�����J�X�^�}�C�Y
                    '�o�͐�ϊ��@�\�g�p�t���O
                    If GF_GetAppInfo3("CNWH001_5") = "1" Then

                        IntSEATID = CInt(Trim$(GF_GetAppInfo3("CNWH001_6")))

                        If Array.IndexOf(IntArray, IntSEATID) < 0 Then
                            IntCnt = UBound(IntArray) + 1

                            If Not IntArray.Contains(IntSEATID) Then
                                ReDim Preserve IntArray(IntCnt)
                                IntArray(IntCnt) = IntSEATID
                            End If

                        End If

                    End If

                    Array.Sort(IntArray)

                    If Len(Trim$(G_KCPStatus)) = 0 Then
                        GoTo SYSTEM_ERROR
                    Else
                        strWork(0) = Mid$(G_KCPStatus, 1, 8)
                        strWork(1) = Mid$(G_KCPStatus, 9, 8)
                        strWork(2) = Mid$(G_KCPStatus, 17, 8)
                        strWork(3) = Mid$(G_KCPStatus, 25, 8)
                    End If

                    With lst_KCP
                        .Items.Clear()
                        lngAryCnt = 0
                        lngBitCnt = 8

                        k = 0

                        '2017-08-08 �y���z�����J�X�^�}�C�Y
                        IntCnt = UBound(IntArray)
                        For i = 1 To 32

                            IntSEATID = IntArray(k)

                            If (i - 1) Mod 8 = 0 And (i - 1) <> 0 Then
                                lngAryCnt = lngAryCnt + 1
                                lngBitCnt = 8
                            End If

                            If i = IntSEATID Then

                                If Mid$(strWork(lngAryCnt), lngBitCnt, 1) = "1" Then
                                    blnEnabled = True
                                Else
                                    blnEnabled = False
                                End If

                                ' 2014-05-12 2�o�C�g������������
                                '.Items.Add("�o�͐�" & StrConv(Format$(lngCnt, "00"), VbStrConv.Wide) & Space(100) & vbTab & lngCnt, blnEnabled)
                                .Items.Add("�o�͐�" & Format$(IntSEATID, "00") & Space(100) & vbTab & IntSEATID, blnEnabled)

                                If k < IntCnt Then
                                    k = k + 1
                                End If

                            End If

                            lngBitCnt = lngBitCnt - 1

                        Next
                    End With

                Else

                    IntCnt = 0

                    strSQL = ""
                    strSQL = strSQL & "SELECT  *"
                    strSQL = strSQL & "  FROM  TPM050"
                    strSQL = strSQL & " WHERE  TERMKIND = 'TC8'"
                    strSQL = strSQL & "    OR  TERMKIND = 'TT2'"
                    strSQL = strSQL & "    OR  TERMKIND = 'TCQ'"
                    strSQL = strSQL & "    OR  TERMKIND = 'TC7'"
                    strSQL = strSQL & " ORDER BY SEATID"

                    If Not GF_GetData(strSQL, objData) Then
                        GoTo SYSTEM_ERROR
                    End If

                    IntCnt = objData.Tables("com").Rows.Count

                    If IntCnt = 0 Then
                        GoTo SYSTEM_ERROR
                    End If

                    '2017-08-08 �y���z�����J�X�^�}�C�Y
                    ReDim Preserve IntArray(IntCnt - 1)

                    For j = 0 To IntCnt - 1

                        If Not GF_GetRows(objData, j, objRows) Then
                            GoTo SYSTEM_ERROR
                        End If

                        IntArray(j) = Trim$(objRows("SEATID"))

                    Next

                    '�o�͐�ϊ��@�\�g�p�t���O
                    If GF_GetAppInfo3("CNWH001_5") = "1" Then

                        IntSEATID = CInt(Trim$(GF_GetAppInfo3("CNWH001_6")))

                        If Array.IndexOf(IntArray, IntSEATID) < 0 Then
                            IntCnt = UBound(IntArray) + 1

                            If Not IntArray.Contains(IntSEATID) Then
                                ReDim Preserve IntArray(IntCnt)
                                IntArray(IntCnt) = IntSEATID
                            End If

                        End If

                    End If

                    Array.Sort(IntArray)

                    If Len(Trim$(G_KCPStatus)) = 0 Then
                        GoTo SYSTEM_ERROR
                    Else
                        strWork(0) = Mid$(G_KCPStatus, 1, 8)
                        strWork(1) = Mid$(G_KCPStatus, 9, 8)
                        strWork(2) = Mid$(G_KCPStatus, 17, 8)
                        strWork(3) = Mid$(G_KCPStatus, 25, 8)
                    End If

                    With lst_KCP
                        .Items.Clear()
                        lngAryCnt = 0
                        lngBitCnt = 8

                        k = 0

                        '2017-08-08 �y���z�����J�X�^�}�C�Y
                        IntCnt = UBound(IntArray)
                        For i = 1 To 32

                            '2017-08-08 �y���z�����J�X�^�}�C�Y
                            IntSEATID = IntArray(k)

                            If (i - 1) Mod 8 = 0 And (i - 1) <> 0 Then
                                lngAryCnt = lngAryCnt + 1
                                lngBitCnt = 8
                            End If

                            If i = IntSEATID Then

                                If Mid$(strWork(lngAryCnt), lngBitCnt, 1) = "1" Then
                                    blnEnabled = True
                                Else
                                    blnEnabled = False
                                End If

                                ' 2014-05-12 2�o�C�g������������
                                '.Items.Add("�o�͐�" & StrConv(Format$(lngCnt, "00"), VbStrConv.Wide) & Space(100) & vbTab & lngCnt, blnEnabled)
                                .Items.Add("�o�͐�" & Format$(IntSEATID, "00") & Space(100) & vbTab & IntSEATID, blnEnabled)

                                '2017-08-08 �y���z�����J�X�^�}�C�Y
                                If k < IntCnt Then
                                    k = k + 1
                                End If

                            End If

                            lngBitCnt = lngBitCnt - 1

                        Next
                    End With

                End If

            Else

                If Len(Trim$(G_KCPStatus)) = 0 Then
                    GoTo SYSTEM_ERROR
                Else
                    strWork(0) = Mid$(G_KCPStatus, 1, 8)
                    strWork(1) = Mid$(G_KCPStatus, 9, 8)
                    strWork(2) = Mid$(G_KCPStatus, 17, 8)
                    strWork(3) = Mid$(G_KCPStatus, 25, 8)
                End If

                With lst_KCP
                    .Items.Clear()
                    lngAryCnt = 0
                    lngBitCnt = 8
                    For lngCnt = 1 To 32
                        If (lngCnt - 1) Mod 8 = 0 And (lngCnt - 1) <> 0 Then
                            lngAryCnt = lngAryCnt + 1
                            lngBitCnt = 8
                        End If
                        If Mid$(strWork(lngAryCnt), lngBitCnt, 1) = "1" Then
                            blnEnabled = True
                        Else
                            blnEnabled = False
                        End If
                        lngBitCnt = lngBitCnt - 1
                        ' 2014-05-12 2�o�C�g������������
                        '.Items.Add("�o�͐�" & StrConv(Format$(lngCnt, "00"), VbStrConv.Wide) & Space(100) & vbTab & lngCnt, blnEnabled)
                        .Items.Add("�o�͐�" & Format$(lngCnt, "00") & Space(100) & vbTab & lngCnt, blnEnabled)
                    Next
                End With

            End If
            ' 2017.1.1 �����Ă���i���� �N���X�R�k�� �c��
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_FormSetup")
    End Sub

    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objItem As Object
        Dim lngCnt As Long
        Dim selCnt As Long

        '------------------------------
        ' �����w�萔�`�F�b�N
        '------------------------------
        lngCnt = 0
        For Each objItem In lst_KCP.CheckedItems
            lngCnt = lngCnt + 1
        Next
        '---(2005.10.08) �����o�͂��\�ɂ���-----------------------------
        'If lngCnt >= 2 Then
        '    Call GF_Msg("", "�����̂j�b�o�𓯎��Ɏw��ł��܂���", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If
        ' ---------- 2020/03/09 �o�͐�6�ӏ��Ή�(START) ----------
        If GF_GetAppInfo("KCP_SELECT_COUNT") = "0" Then
            '�o�͐�3�ӏ�
            selCnt = 4
        Else
            '�o�͐�6�ӏ�
            selCnt = 7
        End If

        If lngCnt >= selCnt Then
        'If lngCnt >= 4 Then
        'If lngCnt >= 7 Then
        ' ---------- 2020/03/09 �o�͐�6�ӏ��Ή�(END) ----------
            Call GF_Msg("", "�o�͐�̑I������l���z���܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        '---------------------------------------------------------------

        '---(2012.03.30)��---
        Dim strMaterial() As String
        Dim strMaterial2() As String
        Dim strWork() As String
        Dim intCnt As Integer
        Dim intCnt2 As Integer
        Dim intCnt3 As Integer
        Dim intCnt4 As Integer
        ' ---------- 2020/03/09 �o�͐�6�ӏ��Ή�(START) ----------
        Dim strKCP(selCnt - 2) As String
        'Dim strKCP(2) As String
        'Dim strKCP(5) As String
        ' ---------- 2020/03/09 �o�͐�6�ӏ��Ή�(END) ----------

        '�~�[�[���ԍ��EKCP�ԍ����̎擾
        strMaterial = Split(GF_GetAppInfo("OUTPUT_KCP"), "/")

        '�`�F�b�N��t�����o��KCP�ԍ��̎擾
        intCnt = 0
        For Each objItem In lst_KCP.CheckedItems
            strWork = Split(CStr(objItem), vbTab)

            strKCP(intCnt) = strWork(1)

            intCnt = intCnt + 1
        Next

        '�~�[�[���ԍ����݃`�F�b�N
        For intCnt = 0 To UBound(strMaterial)
            strMaterial2 = Split(strMaterial(intCnt), "@")

            intCnt2 = 0
            While intCnt2 <= UBound(strKCP)

                If strMaterial2(0) = strKCP(intCnt2) Then

                    'KCP�ԍ����݃`�F�b�N
                    For intCnt4 = 1 To strMaterial2.Length - 1
                        intCnt3 = 0
                        While intCnt3 <= UBound(strKCP)

                            If strMaterial2(intCnt4) = strKCP(intCnt3) Then
                                Call GF_Msg("", "�~�[�p�l���Ƒ΂ɂȂ�j�b�o�𓯎��ɐݒ�ł��܂���B", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
                                Exit Sub
                            End If

                            intCnt3 = intCnt3 + 1
                        End While
                    Next

                End If

                intCnt2 = intCnt2 + 1
            End While

        Next
        '---(2012.03.30)��---

        '------------------------------
        ' �e��ʂ֒l�ԋp
        '------------------------------
        G_KCPStatus = LF_BitBuild()
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Function LF_BitBuild() As String

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngBitCnt As Long
        Dim lngCnt As Long
        Dim strBit(3) As String
        Dim objItem As Object
        Dim strWork() As String
        Dim blnKCP(31) As Boolean

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_BitBuild = ""

        '------------------------------
        ' �I���ς݂j�b�o�ԍ��擾
        '------------------------------
        For lngCnt = 0 To UBound(blnKCP)
            blnKCP(lngCnt) = False
        Next
        For Each objItem In lst_KCP.CheckedItems
            strWork = Split(CStr(objItem), vbTab)
            blnKCP(CLng(strWork(1)) - 1) = True
        Next

        '------------------------------
        ' �a�h�s�����񐶐�
        '------------------------------
        lngBitCnt = 0
        For lngCnt = 0 To 31
            If lngCnt Mod 8 = 0 And lngCnt <> 0 Then
                lngBitCnt = lngBitCnt + 1
            End If

            strBit(lngBitCnt) = IIf(blnKCP(lngCnt), "1", "0") & strBit(lngBitCnt)
        Next

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_BitBuild = strBit(0) & _
                      strBit(1) & _
                      strBit(2) & _
                      strBit(3)

    End Function


End Class
