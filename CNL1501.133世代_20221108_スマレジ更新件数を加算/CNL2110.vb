' --------------------------------------------------------------------------------
' �@�@�@�@�\�FCrossNavi - ����f�[�^�o�͉��
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------
Public Class CNL2110
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents btn_OutputCsv As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CNL2110))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_OutputCsv = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.stb_Msg = New System.Windows.Forms.StatusBar
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "����f�[�^�o��"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "�I��(&E)"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'btn_OutputCsv
        '
        Me.btn_OutputCsv.BackColor = System.Drawing.SystemColors.Control
        Me.btn_OutputCsv.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_OutputCsv.Location = New System.Drawing.Point(219, 10)
        Me.btn_OutputCsv.Name = "btn_OutputCsv"
        Me.btn_OutputCsv.Size = New System.Drawing.Size(180, 50)
        Me.btn_OutputCsv.TabIndex = 20
        Me.btn_OutputCsv.Text = "����f�[�^�o��"
        Me.btn_OutputCsv.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_OutputCsv)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 150
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(204, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(794, 1)
        Me.Label3.TabIndex = 148
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 665)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(1016, 24)
        Me.stb_Msg.TabIndex = 151
        Me.stb_Msg.Text = "StatusBar1"
        '
        'CNL2110
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1016, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stb_Msg)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL2110"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNL2110"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' ------------------------------------------------------------------------------
    ' ���W���[�������[�U��`�^��`
    ' ------------------------------------------------------------------------------
    Private Structure strOrderData
        Dim SHOHINKIND As String
        Dim SHOHIN As String
        Dim OUTSHOHIN As String
        Dim SHOHINNM As String
        Dim TIME00 As String
        Dim TIME01 As String
        Dim TIME02 As String
        Dim TIME03 As String
        Dim TIME04 As String
        Dim TIME05 As String
        Dim TIME06 As String
        Dim TIME07 As String
        Dim TIME08 As String
        Dim TIME09 As String
        Dim TIME10 As String
        Dim TIME11 As String
        Dim TIME12 As String
        Dim TIME13 As String
        Dim TIME14 As String
        Dim TIME15 As String
        Dim TIME16 As String
        Dim TIME17 As String
        Dim TIME18 As String
        Dim TIME19 As String
        Dim TIME20 As String
        Dim TIME21 As String
        Dim TIME22 As String
        Dim TIME23 As String
        Dim URIAGE As String
        Dim URIAGE_NUM As String
    End Structure

    Private L_OrderData As strOrderData

    Private Structure strOrderDataKEY
        Dim SHOHIN As String
    End Structure

    Private L_OrderDatakey As strOrderDataKEY

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���ǂݍ��ݎ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub CNL2110_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �t�H�[�����̐ݒ�
        '------------------------------
        Me.Text = GF_FormText("- ����f�[�^�o��")

        '---------------------------------
        ' ����{�^����\����
        '---------------------------------
        Me.ControlBox = False

        '------------------------------
        ' ����������
        '------------------------------
        Call GS_StatusSetup(stb_Msg)

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u�I���v���j���[����������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click

        Me.Close()

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u����f�[�^�o�́v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_OutputCsv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OutputCsv.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim FileName As String = Nothing
        Dim objRows As DataRow = Nothing
        Dim RowsCnt As Integer
        Dim ColmCnt As Integer
        Dim strEncoding As System.Text.Encoding
        Dim strStreamWriter As System.IO.StreamWriter = Nothing

        ''------------------------------
        '' �g�����U�N�V�����J�n
        ''------------------------------
        'If Not GF_BeginTrans() Then
        '    Exit Sub
        'End If

        ''------------------------------
        '' ���[�o�̓e�[�u���폜
        ''------------------------------
        'If Not LF_Delete() Then
        '    GoTo SYSTEM_ERROR
        'End If

        ''------------------------------
        '' �R�~�b�g
        ''------------------------------
        'If Not GF_CommitTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        ''------------------------------
        '' �g�����U�N�V�����J�n
        ''------------------------------
        'If Not GF_BeginTrans() Then
        '    Exit Sub
        'End If

        'Select Case LF_CreateWorkTable()
        '    Case CNL1920.FuncResult.CancelEnd
        '        Exit Sub
        '    Case CNL1920.FuncResult.UnusualEnd
        '        GoTo SYSTEM_ERROR
        'End Select

        ''------------------------------
        '' �_�C�A���O�{�b�N�X�\��
        ''------------------------------
        'If Not GetSaveFile(FileName) Then
        '    Exit Sub
        'End If


        '------------------------------
        ' �ۑ��t�H���_�A�t�@�C�����w��
        '------------------------------
        System.Environment.CurrentDirectory = Trim$(GF_GetAppInfo("SALES_PATH"))  '�t�H���_���w��
        FileName = "PriceData(" & Format$(Now, "yyyyMMddHHmmss") & ").csv"             '�t�@�C�����w��


        '------------------------------
        ' ���[�f�[�^�擾����
        '------------------------------
        If Not LF_GetData(objData) Then
            Exit Sub
        End If

        Try
            '------------------------------
            ' �t�@�C�����ݒ�
            '------------------------------
            strEncoding = System.Text.Encoding.GetEncoding("Shift_JIS")
            strStreamWriter = New System.IO.StreamWriter(FileName, False, strEncoding)

            '------------------------------
            ' �t�@�C���o��
            '------------------------------
            ColmCnt = 0

            While ColmCnt < objData.Tables("com").Columns.Count
                If Not GF_GetRows(objData, RowsCnt, objRows) Then
                    Exit Sub
                End If
                If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                    strStreamWriter.WriteLine(objData.Tables("com").Columns(ColmCnt))
                Else
                    strStreamWriter.Write(objData.Tables("com").Columns(ColmCnt))
                    strStreamWriter.Write(",")
                End If
                ColmCnt = ColmCnt + 1
            End While

            ColmCnt = 0
            RowsCnt = 0
            While RowsCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, RowsCnt, objRows) Then
                    Exit Sub
                End If
                While ColmCnt < objData.Tables("com").Columns.Count
                    If Not GF_GetRows(objData, RowsCnt, objRows) Then
                        Exit Sub
                    End If
                    If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                        strStreamWriter.WriteLine(objData.Tables("com").Rows(RowsCnt)(ColmCnt))
                    Else
                        strStreamWriter.Write(objData.Tables("com").Rows(RowsCnt)(ColmCnt) & ",")
                    End If
                    ColmCnt = ColmCnt + 1

                End While
                ColmCnt = 0
                RowsCnt = RowsCnt + 1
            End While
        Catch
            strStreamWriter.Close()
            MsgBox("�t�@�C���̏o�͂Ɏ��s���܂���")

            'If Not GF_RollbackTrans() Then
            '    GoTo SYSTEM_ERROR
            'End If

            Exit Sub
        End Try

        strStreamWriter.Close()
        Call GF_Msg("", "����f�[�^���쐬���܂���" & vbCrLf & "[" & FileName & "]", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)

        ''------------------------------
        '' �R�~�b�g
        ''------------------------------
        'If Not GF_CommitTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_OutputCsv_Click")
    End Sub

    '    ' --------------------------------------------------------------------------------
    '    ' �@�@�@�@�\�F�c�a�o�^�p�\���̏���������
    '    ' �@�@�\�T�v�F
    '    ' �@���@�@���F
    '    ' �@�� �� �l�F
    '    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    '    ' --------------------------------------------------------------------------------
    '    Private Sub LS_ClearData()
    '        Try
    '            L_OrderData.SHOHIN = ""
    '            L_OrderData.OUTSHOHIN = ""
    '            L_OrderData.SHOHINNM = ""
    '            L_OrderData.TIME00 = 0
    '            L_OrderData.TIME01 = 0
    '            L_OrderData.TIME02 = 0
    '            L_OrderData.TIME03 = 0
    '            L_OrderData.TIME04 = 0
    '            L_OrderData.TIME05 = 0
    '            L_OrderData.TIME06 = 0
    '            L_OrderData.TIME07 = 0
    '            L_OrderData.TIME08 = 0
    '            L_OrderData.TIME09 = 0
    '            L_OrderData.TIME10 = 0
    '            L_OrderData.TIME11 = 0
    '            L_OrderData.TIME12 = 0
    '            L_OrderData.TIME13 = 0
    '            L_OrderData.TIME14 = 0
    '            L_OrderData.TIME15 = 0
    '            L_OrderData.TIME16 = 0
    '            L_OrderData.TIME17 = 0
    '            L_OrderData.TIME18 = 0
    '            L_OrderData.TIME19 = 0
    '            L_OrderData.TIME20 = 0
    '            L_OrderData.TIME21 = 0
    '            L_OrderData.TIME22 = 0
    '            L_OrderData.TIME23 = 0
    '            L_OrderData.URIAGE = 0
    '            L_OrderData.URIAGE_NUM = 0
    '        Catch
    '            GoTo SYSTEM_ERROR
    '        End Try

    '        Exit Sub

    'SYSTEM_ERROR:
    '        Call GS_ErrorTerm("LS_ClearData")
    '    End Sub

    '' --------------------------------------------------------------------------------
    '' �@�@�@�@�\�F���[�e�[�u���X�V����(�c�d�k�d�s�d)
    '' �@�@�\�T�v�F
    '' �@���@�@���F
    '' �@�� �� �l�F
    '' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    '' --------------------------------------------------------------------------------
    'Private Function LF_Delete() As Boolean

    '    '------------------------------
    '    ' �����ϐ���`
    '    '------------------------------
    '    Dim strSQL As String

    '    '------------------------------
    '    ' �����l�ݒ�
    '    '------------------------------
    '    LF_Delete = False

    '    '------------------------------
    '    ' SQL�g��
    '    '------------------------------
    '    strSQL = ""
    '    strSQL = strSQL & "DELETE"
    '    strSQL = strSQL & "  FROM TPD100"

    '    If Not GF_UpdCmtData(strSQL) Then
    '        Exit Function
    '    End If

    '    '------------------------------
    '    ' �ԋp�l�ݒ�
    '    '------------------------------
    '    LF_Delete = True

    'End Function

    '' --------------------------------------------------------------------------------
    '' �@�@�@�@�\�F���[�e�[�u���X�V����(�h�m�r�d�q�s)
    '' �@�@�\�T�v�F
    '' �@���@�@���F
    '' �@�� �� �l�F
    '' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    '' --------------------------------------------------------------------------------
    'Private Function LF_UpdData(ByRef pOrderData As strOrderData) As Boolean

    '    '------------------------------       
    '    ' �����ϐ���`
    '    '------------------------------
    '    Dim strSQL As String

    '    '------------------------------
    '    ' �����l�ݒ�
    '    '------------------------------
    '    LF_UpdData = False

    '    '------------------------------
    '    ' SQL�g��
    '    '------------------------------
    '    strSQL = ""
    '    strSQL = strSQL & "INSERT INTO"
    '    strSQL = strSQL & "       TPD100"
    '    strSQL = strSQL & "       VALUES ('"
    '    strSQL = strSQL & pOrderData.SHOHINKIND & "','"
    '    strSQL = strSQL & pOrderData.SHOHIN & "','"
    '    strSQL = strSQL & LF_PadSpc(pOrderData.OUTSHOHIN, 4) & "','"
    '    strSQL = strSQL & pOrderData.SHOHINNM & "',"
    '    strSQL = strSQL & pOrderData.TIME00 & ","
    '    strSQL = strSQL & pOrderData.TIME01 & ","
    '    strSQL = strSQL & pOrderData.TIME02 & ","
    '    strSQL = strSQL & pOrderData.TIME03 & ","
    '    strSQL = strSQL & pOrderData.TIME04 & ","
    '    strSQL = strSQL & pOrderData.TIME05 & ","
    '    strSQL = strSQL & pOrderData.TIME06 & ","
    '    strSQL = strSQL & pOrderData.TIME07 & ","
    '    strSQL = strSQL & pOrderData.TIME08 & ","
    '    strSQL = strSQL & pOrderData.TIME09 & ","
    '    strSQL = strSQL & pOrderData.TIME10 & ","
    '    strSQL = strSQL & pOrderData.TIME11 & ","
    '    strSQL = strSQL & pOrderData.TIME12 & ","
    '    strSQL = strSQL & pOrderData.TIME13 & ","
    '    strSQL = strSQL & pOrderData.TIME14 & ","
    '    strSQL = strSQL & pOrderData.TIME15 & ","
    '    strSQL = strSQL & pOrderData.TIME16 & ","
    '    strSQL = strSQL & pOrderData.TIME17 & ","
    '    strSQL = strSQL & pOrderData.TIME18 & ","
    '    strSQL = strSQL & pOrderData.TIME19 & ","
    '    strSQL = strSQL & pOrderData.TIME20 & ","
    '    strSQL = strSQL & pOrderData.TIME21 & ","
    '    strSQL = strSQL & pOrderData.TIME22 & ","
    '    strSQL = strSQL & pOrderData.TIME23 & ","
    '    strSQL = strSQL & pOrderData.URIAGE & ","
    '    strSQL = strSQL & pOrderData.URIAGE_NUM & ","
    '    strSQL = strSQL & "'SYSTEM',"
    '    strSQL = strSQL & "getdate()"
    '    strSQL = strSQL & ")"

    '    If Not GF_UpdCmtData(strSQL) Then
    '        Exit Function
    '    End If

    '    '------------------------------
    '    ' �ԋp�l�ݒ�
    '    '------------------------------
    '    LF_UpdData = True

    'End Function

    'Private Function GetSaveFile(ByRef fname As String) As Boolean

    '    '------------------------------
    '    ' �����l�ݒ�
    '    '------------------------------
    '    GetSaveFile = False

    '    '------------------------------
    '    ' SaveFileDialog�N���X�̃C���X�^���X���쐬
    '    '------------------------------
    '    Dim sfd As New SaveFileDialog()

    '    '------------------------------
    '    ' �͂��߂̃t�@�C�������w�肷��
    '    '------------------------------
    '    sfd.FileName = "PriceData(" & Format$(Now, "yyyyMMddHHmmss") & ").csv"

    '    '------------------------------
    '    ' �͂��߂ɕ\�������t�H���_���w�肷��
    '    '------------------------------
    '    sfd.InitialDirectory = Trim$(GF_GetAppInfo("SALES_PATH"))

    '    '------------------------------
    '    ' [�t�@�C���̎��]�ɕ\�������I�������w�肷��
    '    '------------------------------
    '    sfd.Filter = "csv�t�@�C��|*.csv|���ׂẴt�@�C��(*.*)|*.*"

    '    '------------------------------
    '    ' [�t�@�C���̎��]�ł͂��߂�
    '    ' �u���ׂẴt�@�C���v���I������Ă���悤�ɂ���
    '    '------------------------------
    '    sfd.FilterIndex = 2

    '    '------------------------------
    '    ' �^�C�g����ݒ肷��
    '    '------------------------------
    '    sfd.Title = "�ۑ���̃t�@�C����I�����Ă�������"

    '    '------------------------------
    '    ' �_�C�A���O�{�b�N�X�����O�Ɍ��݂̃f�B���N�g���𕜌�����悤�ɂ���
    '    '------------------------------
    '    sfd.RestoreDirectory = True

    '    '------------------------------
    '    ' ���ɑ��݂���t�@�C�������w�肵���Ƃ��x������
    '    ' �f�t�H���g��True�Ȃ̂Ŏw�肷��K�v�͂Ȃ�
    '    '------------------------------
    '    sfd.OverwritePrompt = True

    '    '------------------------------
    '    ' ���݂��Ȃ��p�X���w�肳�ꂽ�Ƃ��x����\������
    '    ' �f�t�H���g��True�Ȃ̂Ŏw�肷��K�v�͂Ȃ�
    '    '------------------------------
    '    sfd.CheckPathExists = True

    '    '------------------------------
    '    ' �_�C�A���O��\������
    '    '------------------------------
    '    If sfd.ShowDialog() = DialogResult.OK Then
    '        fname = sfd.FileName
    '    Else
    '        Exit Function
    '    End If

    '    '------------------------------
    '    ' �ԋp�l�ݒ�
    '    '------------------------------
    '    GetSaveFile = True

    'End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�X�y�[�X���ߏ���
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Public Function LF_PadSpc(ByVal pStr As String, ByVal Length As Long) As String

        LF_PadSpc = Space(Length - Len(Trim$(pStr))) & Trim$(pStr)

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���[�f�[�^�擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetDATA(ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetDATA = False

        '------------------------------
        ' SQL�g��
        '------------------------------

        'strSQL = strSQL & "SELECT OUTMSGNO  AS ""���i�ԍ�"","
        'strSQL = strSQL & "       GOODSNM   AS ""���i����"","
        'strSQL = strSQL & "       URIAGENUM AS ""���㐔��"","
        ''strSQL = strSQL & "       TIME00    AS ""00:00"","
        ''strSQL = strSQL & "       TIME01    AS ""01:00"","
        ''strSQL = strSQL & "       TIME02    AS ""02:00"","
        ''strSQL = strSQL & "       TIME03    AS ""03:00"","
        ''strSQL = strSQL & "       TIME04    AS ""04:00"","
        ''strSQL = strSQL & "       TIME05    AS ""05:00"","
        ''strSQL = strSQL & "       TIME06    AS ""06:00"","
        'strSQL = strSQL & "       TIME07    AS ""07:00"","
        'strSQL = strSQL & "       TIME08    AS ""08:00"","
        'strSQL = strSQL & "       TIME09    AS ""09:00"","
        'strSQL = strSQL & "       TIME10    AS ""10:00"","
        'strSQL = strSQL & "       TIME11    AS ""11:00"","
        'strSQL = strSQL & "       TIME12    AS ""12:00"","
        'strSQL = strSQL & "       TIME13    AS ""13:00"","
        'strSQL = strSQL & "       TIME14    AS ""14:00"","
        'strSQL = strSQL & "       TIME15    AS ""15:00"","
        'strSQL = strSQL & "       TIME16    AS ""16:00"","
        'strSQL = strSQL & "       TIME17    AS ""17:00"","
        'strSQL = strSQL & "       TIME18    AS ""18:00"","
        'strSQL = strSQL & "       TIME19    AS ""19:00"","
        'strSQL = strSQL & "       TIME20    AS ""20:00"","
        'strSQL = strSQL & "       TIME21    AS ""21:00"","
        'strSQL = strSQL & "       TIME22    AS ""22:00"","
        'strSQL = strSQL & "       TIME23    AS ""23:00"","
        'strSQL = strSQL & "       URIAGE    AS ""������z"""
        'strSQL = strSQL & "  FROM TPD100"
        strSQL = ""
        strSQL = strSQL & " SELECT SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 1, 8) AS YYYYMMDD,"
        strSQL = strSQL & "        TPm010.GOODSCD,"
        strSQL = strSQL & "        MAX(LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ, '�@', ' '))) + LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ2, '�@', ' ')))) AS GOODSNM,"
        strSQL = strSQL & "        MAX(TPM010.PRICE) AS PRICE,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 00 THEN TPD010.QUANTITY ELSE '0' END) AS TIME00,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 01 THEN TPD010.QUANTITY ELSE '0' END) AS TIME01,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 02 THEN TPD010.QUANTITY ELSE '0' END) AS TIME02,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 03 THEN TPD010.QUANTITY ELSE '0' END) AS TIME03,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 04 THEN TPD010.QUANTITY ELSE '0' END) AS TIME04,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 05 THEN TPD010.QUANTITY ELSE '0' END) AS TIME05,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 06 THEN TPD010.QUANTITY ELSE '0' END) AS TIME06,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 07 THEN TPD010.QUANTITY ELSE '0' END) AS TIME07,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 08 THEN TPD010.QUANTITY ELSE '0' END) AS TIME08,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 09 THEN TPD010.QUANTITY ELSE '0' END) AS TIME09,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 10 THEN TPD010.QUANTITY ELSE '0' END) AS TIME10,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 11 THEN TPD010.QUANTITY ELSE '0' END) AS TIME11,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 12 THEN TPD010.QUANTITY ELSE '0' END) AS TIME12,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 13 THEN TPD010.QUANTITY ELSE '0' END) AS TIME13,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 14 THEN TPD010.QUANTITY ELSE '0' END) AS TIME14,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 15 THEN TPD010.QUANTITY ELSE '0' END) AS TIME15,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 16 THEN TPD010.QUANTITY ELSE '0' END) AS TIME16,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 17 THEN TPD010.QUANTITY ELSE '0' END) AS TIME17,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 18 THEN TPD010.QUANTITY ELSE '0' END) AS TIME18,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 19 THEN TPD010.QUANTITY ELSE '0' END) AS TIME19,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 20 THEN TPD010.QUANTITY ELSE '0' END) AS TIME20,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 21 THEN TPD010.QUANTITY ELSE '0' END) AS TIME21,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 22 THEN TPD010.QUANTITY ELSE '0' END) AS TIME22,"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 23 THEN TPD010.QUANTITY ELSE '0' END) AS TIME23,"
        strSQL = strSQL & "        SUM(TPD010.QUANTITY) AS TOTALNUM,"
        strSQL = strSQL & "        (SUM(TPD010.QUANTITY) * MAX(TPM010.PRICE)) AS SUBTOTAL"
        strSQL = strSQL & "   FROM TPM010 LEFT JOIN TPD010 ON TPM010.GOODSCD = TPD010.GOODSCD"
        strSQL = strSQL & "  WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999"
        'strSQL = strSQL & " AND TPD010.SELECTTIME <> 0"
        'strSQL = strSQL & " AND TPD010.ORDERTIME  <> 0"
        'strSQL = strSQL & " AND TPD010.TRANSTIME  <> 0"
        'strSQL = strSQL & " AND TPD010.TRANSTIME  <> 99999999999999"
        'strSQL = strSQL & " WHERE(TPD010.GOODSCD = TPM010.GOODSCD)"
        'strSQL = strSQL & " where TPD010.SELECTTIME <> 0"
        'strSQL = strSQL & "AND TPD010.ORDERTIME  <> 0"
        'strSQL = strSQL & "  AND TPD010.TRANSTIME  <> 0"
        'strSQL = strSQL & " AND TPD010.TRANSTIME  <> 99999999999999"
        strSQL = strSQL & " GROUP BY TPM010.GOODSCD,"
        strSQL = strSQL & "          SUBSTRING(Convert(Char, TPD010.TRANSTIME), 1, 8)"
        strSQL = strSQL & " ORDER BY YYYYMMDD,"
        strSQL = strSQL & "          TPM010.GOODSCD"



        '------------------------------
        ' �f�[�^�擾
        '------------------------------
        If Not GF_GetData(strSQL, pDataSet) Then
            Call GF_Msg("", "DB�ڑ��Ɏ��s���܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            Exit Function
        End If

        If pDataSet.Tables("com").Rows.Count = 0 Then
            Call GF_Msg("", "�Ώۃf�[�^������܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
            Exit Function
        End If

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetDATA = True

    End Function

    '' --------------------------------------------------------------------------------
    '' �@�@�@�@�\�F���[�e�[�u���쐬����
    '' �@�@�\�T�v�F
    '' �@���@�@���F
    '' �@�� �� �l�F
    '' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    '' --------------------------------------------------------------------------------
    'Private Function LF_CreateWorkTable() As FuncResult

    '    '------------------------------
    '    ' �����ϐ���`
    '    '------------------------------
    '    Dim objData As New DataSet()
    '    Dim objRows As DataRow = Nothing
    '    Dim lngCnt As Long
    '    Dim strNow As String
    '    Dim lngSum As Long
    '    Dim objSum As strOrderData

    '    '------------------------------
    '    ' �����l�ݒ�
    '    '------------------------------
    '    LF_CreateWorkTable = CNL1920.FuncResult.UnusualEnd
    '    strNow = Format(Now(), "yyyyMMdd")

    '    With objSum
    '        .OUTSHOHIN = ""
    '        .SHOHIN = "9999"
    '        .SHOHINNM = "���v"
    '        .TIME00 = "0"
    '        .TIME01 = "0"
    '        .TIME02 = "0"
    '        .TIME03 = "0"
    '        .TIME04 = "0"
    '        .TIME05 = "0"
    '        .TIME06 = "0"
    '        .TIME07 = "0"
    '        .TIME08 = "0"
    '        .TIME09 = "0"
    '        .TIME10 = "0"
    '        .TIME11 = "0"
    '        .TIME12 = "0"
    '        .TIME13 = "0"
    '        .TIME14 = "0"
    '        .TIME15 = "0"
    '        .TIME16 = "0"
    '        .TIME17 = "0"
    '        .TIME18 = "0"
    '        .TIME19 = "0"
    '        .TIME20 = "0"
    '        .TIME21 = "0"
    '        .TIME22 = "0"
    '        .TIME23 = "0"
    '        .URIAGE = "0"
    '        .URIAGE_NUM = "0"
    '    End With

    '    '------------------------------
    '    ' �f�[�^�擾
    '    '------------------------------
    '    If Not LF_GetData(objData) Then
    '        Exit Function
    '    End If

    '    If objData.Tables("com").Rows.Count = 0 Then
    '        Call GF_Msg("", "�Ώۃf�[�^������܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
    '        LF_CreateWorkTable = CNL1920.FuncResult.CancelEnd
    '        Exit Function
    '    End If

    '    Try
    '        lngCnt = 0
    '        If Not GF_GetRows(objData, lngCnt, objRows) Then
    '            Exit Function
    '        End If

    '        While lngCnt < objData.Tables("com").Rows.Count
    '            '------------------------------
    '            ' �G���A�̏�����
    '            '------------------------------
    '            Call LS_ClearData()
    '            L_OrderDatakey.SHOHIN = CStr(objRows("SHOHIN"))             ' �L�[�ޔ�

    '            L_OrderData.SHOHINKIND = "���i�ԍ�"
    '            L_OrderData.OUTSHOHIN = CStr(objRows("SHOHIN"))
    '            L_OrderData.SHOHINNM = CStr(objRows("SHOHINNM")) & CStr(objRows("SHOHINNM2"))
    '            L_OrderData.SHOHIN = CStr(objRows("SHOHIN"))

    '            lngSum = 0
    '            While L_OrderDatakey.SHOHIN = CStr(objRows("SHOHIN")) And _
    '                  lngCnt < objData.Tables("com").Rows.Count

    '                Select Case CStr(objRows("TIME"))
    '                    'Select Case strNow & CStr(objRows("TIME")).Substring(8, 2)
    '                    'Case strNow & "00"
    '                    '    L_OrderData.TIME00 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME00 = CLng(objSum.TIME00) + CLng(objRows("CNT"))
    '                    'Case strNow & "01"
    '                    '    L_OrderData.TIME01 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME01 = CLng(objSum.TIME01) + CLng(objRows("CNT"))
    '                    'Case strNow & "02"
    '                    '    L_OrderData.TIME02 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME02 = CLng(objSum.TIME02) + CLng(objRows("CNT"))
    '                    'Case strNow & "03"
    '                    '    L_OrderData.TIME03 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME03 = CLng(objSum.TIME03) + CLng(objRows("CNT"))
    '                    'Case strNow & "04"
    '                    '    L_OrderData.TIME04 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME04 = CLng(objSum.TIME04) + CLng(objRows("CNT"))
    '                    'Case strNow & "05"
    '                    '    L_OrderData.TIME05 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME05 = CLng(objSum.TIME05) + CLng(objRows("CNT"))
    '                    'Case strNow & "06"
    '                    '    L_OrderData.TIME06 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME06 = CLng(objSum.TIME06) + CLng(objRows("CNT"))
    '                    'Case strNow & "07"
    '                    '    L_OrderData.TIME07 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME07 = CLng(objSum.TIME07) + CLng(objRows("CNT"))
    '                    'Case strNow & "08"
    '                    '    L_OrderData.TIME08 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME08 = CLng(objSum.TIME08) + CLng(objRows("CNT"))
    '                    'Case strNow & "09"
    '                    '    L_OrderData.TIME09 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME09 = CLng(objSum.TIME09) + CLng(objRows("CNT"))
    '                    'Case strNow & "10"
    '                    '    L_OrderData.TIME10 = CInt(objRows("CNT"))
    '                    '    lngSum = lngSum + CInt(objRows("CNT"))
    '                    '    objSum.TIME10 = CLng(objSum.TIME10) + CLng(objRows("CNT"))
    '                    Case strNow & "11"
    '                        L_OrderData.TIME11 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME11 = CLng(objSum.TIME11) + CLng(objRows("CNT"))
    '                    Case strNow & "12"
    '                        L_OrderData.TIME12 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME12 = CLng(objSum.TIME12) + CLng(objRows("CNT"))
    '                    Case strNow & "13"
    '                        L_OrderData.TIME13 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME13 = CLng(objSum.TIME13) + CLng(objRows("CNT"))
    '                    Case strNow & "14"
    '                        L_OrderData.TIME14 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME14 = CLng(objSum.TIME14) + CLng(objRows("CNT"))
    '                    Case strNow & "15"
    '                        L_OrderData.TIME15 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME15 = CLng(objSum.TIME15) + CLng(objRows("CNT"))
    '                    Case strNow & "16"
    '                        L_OrderData.TIME16 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME16 = CLng(objSum.TIME16) + CLng(objRows("CNT"))
    '                    Case strNow & "17"
    '                        L_OrderData.TIME17 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME17 = CLng(objSum.TIME17) + CLng(objRows("CNT"))
    '                    Case strNow & "18"
    '                        L_OrderData.TIME18 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME18 = CLng(objSum.TIME18) + CLng(objRows("CNT"))
    '                    Case strNow & "19"
    '                        L_OrderData.TIME19 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME19 = CLng(objSum.TIME19) + CLng(objRows("CNT"))
    '                    Case strNow & "20"
    '                        L_OrderData.TIME20 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME20 = CLng(objSum.TIME20) + CLng(objRows("CNT"))
    '                    Case strNow & "21"
    '                        L_OrderData.TIME21 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME21 = CLng(objSum.TIME21) + CLng(objRows("CNT"))
    '                    Case strNow & "22"
    '                        L_OrderData.TIME22 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME22 = CLng(objSum.TIME22) + CLng(objRows("CNT"))
    '                    Case strNow & "23"
    '                        L_OrderData.TIME23 = CInt(objRows("CNT"))
    '                        lngSum = lngSum + CInt(objRows("CNT"))
    '                        objSum.TIME23 = CLng(objSum.TIME23) + CLng(objRows("CNT"))
    '                    Case Else
    '                        '�������Ȃ�
    '                End Select

    '                L_OrderData.URIAGE = L_OrderData.URIAGE + (CInt(objRows("PRICE")))
    '                objSum.URIAGE = objSum.URIAGE + CInt(objRows("PRICE"))

    '                lngCnt = lngCnt + 1
    '                If lngCnt < objData.Tables("com").Rows.Count Then
    '                    If Not GF_GetRows(objData, lngCnt, objRows) Then
    '                        Exit Function
    '                    End If
    '                End If
    '            End While

    '            L_OrderData.URIAGE_NUM = CStr(lngSum)
    '            objSum.URIAGE_NUM = CStr(CLng(objSum.URIAGE_NUM) + lngSum)

    '            '------------------------------
    '            ' ���[�e�[�u���X�V(���׃f�[�^�ǉ�)
    '            '------------------------------
    '            If Not LF_UpdData(L_OrderData) Then
    '                Exit Function
    '            End If
    '        End While

    '        objSum.SHOHINKIND = L_OrderData.SHOHINKIND
    '        '------------------------------
    '        ' ���[�e�[�u���X�V(���v�f�[�^�ǉ�)
    '        '------------------------------
    '        If Not LF_UpdData(objSum) Then
    '            Exit Function
    '        End If

    '    Catch
    '        Exit Function
    '    End Try

    '    '------------------------------
    '    ' �ԋp�l�ݒ�
    '    '------------------------------
    '    LF_CreateWorkTable = CNL1920.FuncResult.NormalEnd

    'End Function

    'Private Function LF_GetData(ByRef pDataSet As DataSet) As Boolean

    '    '------------------------------
    '    ' �����ϐ���`
    '    '------------------------------
    '    Dim strSQL As String
    '    Dim strNow As String

    '    '------------------------------
    '    ' �����l�ݒ�
    '    '------------------------------
    '    LF_GetData = False
    '    strNow = Format(Now(), "yyyyMMdd")

    '    '------------------------------
    '    ' SQL�g��
    '    '------------------------------
    '    strSQL = ""
    '    strSQL = strSQL & "SELECT SUM(TPD010.QUANTITY) CNT,"
    '    strSQL = strSQL & "       TPD010.GOODSCD SHOHIN,"
    '    strSQL = strSQL & "       MAX(TPM010.GOODSNMJ) SHOHINNM,"
    '    strSQL = strSQL & "       MAX(TPM010.GOODSNMJ2) SHOHINNM2,"
    '    strSQL = strSQL & "       SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME),1, 10) TIME,"
    '    strSQL = strSQL & "       SUM(TPM010.PRICE * TPD010.QUANTITY) PRICE"
    '    strSQL = strSQL & "  FROM TPD010,"
    '    strSQL = strSQL & "       TPM010 "
    '    strSQL = strSQL & " WHERE TPD010.GOODSCD    = TPM010.GOODSCD"
    '    strSQL = strSQL & "   AND TPD010.SELECTTIME <> 0"
    '    strSQL = strSQL & "   AND TPD010.ORDERTIME  <> 0"
    '    strSQL = strSQL & "   AND TPD010.TRANSTIME  <> 0"
    '    strSQL = strSQL & "   AND TPD010.TRANSTIME  <> 99999999999999"
    '    strSQL = strSQL & "   AND SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME),1, 8) = '" & strNow & "'"
    '    strSQL = strSQL & " GROUP BY TPD010.GOODSCD,"
    '    strSQL = strSQL & "          SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME),1, 10)"
    '    strSQL = strSQL & " ORDER BY TPD010.GOODSCD,"
    '    strSQL = strSQL & "          TIME"

    '    If Not GF_GetData(strSQL, pDataSet) Then
    '        Exit Function
    '    End If

    '    '------------------------------
    '    ' �ԋp�l�ݒ�
    '    '------------------------------
    '    LF_GetData = True

    'End Function
End Class
