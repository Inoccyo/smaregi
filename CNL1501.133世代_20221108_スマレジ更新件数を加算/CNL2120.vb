' --------------------------------------------------------------------------------
' �@�@�@�@�\�FCrossNavi - �X�������
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2011.11.07 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------
Public Class CNL2120
    Inherits System.Windows.Forms.Form

    '----(2013.10.22)�V�K�쐬----------------------
    ' ---------------------------------------------
    ' ���W���[�������[�U��`�^��`
    ' ---------------------------------------------
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
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents mnu_End As System.Windows.Forms.MenuItem
    Friend WithEvents btn_End As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CNL2120))
        Me.stb_Msg = New System.Windows.Forms.StatusBar
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.mnu_End = New System.Windows.Forms.MenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.btn_End = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 665)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(1016, 24)
        Me.stb_Msg.TabIndex = 5
        Me.stb_Msg.Text = "StatusBar1"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.mnu_End})
        Me.MenuItem1.Text = "�X����"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "-"
        '
        'mnu_End
        '
        Me.mnu_End.Index = 1
        Me.mnu_End.Text = "�I��(&E)"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btn_End)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(262, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(262, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Label1"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(204, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(794, 1)
        Me.Label11.TabIndex = 148
        '
        'btn_End
        '
        Me.btn_End.BackColor = System.Drawing.SystemColors.Control
        Me.btn_End.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_End.Location = New System.Drawing.Point(219, 10)
        Me.btn_End.Name = "btn_End"
        Me.btn_End.Size = New System.Drawing.Size(180, 50)
        Me.btn_End.TabIndex = 11
        Me.btn_End.Text = "�c�ƏI��"
        Me.btn_End.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        '
        'CNL2120
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(9, 19)
        Me.ClientSize = New System.Drawing.Size(1016, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stb_Msg)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL2120"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���ǂݍ��ݎ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub CNL2120_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''------------------------------
        '' �����ϐ���`
        ''------------------------------
        'Dim objForm As New CNL1810()

        Try
            '------------------------------
            ' �t�H�[�����̐ݒ�
            '------------------------------
            Me.Text = " �X���� "

            '---------------------------------
            '����{�^����\����
            '---------------------------------
            Me.ControlBox = False

            ''------------------------------
            '' �N���X�e�[�^�X�\��
            ''------------------------------
            'objForm.Show()
            'objForm.lbl_Msg.Text = "�N���������ł��B���΂炭���҂���������..."
            'objForm.TopMost = True
            'System.Windows.Forms.Application.DoEvents()

            '------------------------------
            ' ����������
            '------------------------------
            Call GS_StatusSetup(stb_Msg)

            '------------------------------
            ' �Ǘ��}�X�^��茻���ݒ�
            '------------------------------
            Call LS_SetStatus()

            ''------------------------------
            '' �N���X�e�[�^�X�N���[�Y
            ''------------------------------
            'objForm.Close()

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL2120_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���ݐݒ�l �\������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetStatus()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^�擾
        '------------------------------
        If Not LF_GetTPM040(objRows) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' ���ݐݒ�l �\������
        '------------------------------
        If Trim$(objRows("CLMODE")) = GC_TRUE Then
            '------------------------------
            ' �{�^���g�p�ېݒ�
            '------------------------------
            btn_End.Enabled = True

            '---------------------------------
            '�J�X�\���ύX
            '---------------------------------
            btn_End.Text = "�c�ƏI��"

            Me.Label1.Text = "���݁A�c�ƒ��ł��B"
            Me.Label2.Text = "�c�Ƃ��I������ꍇ�́A��L��[�c�ƏI��]�{�^���������Ă��������B"
        Else
            '------------------------------
            ' �{�^���g�p�ېݒ�
            '------------------------------
            btn_End.Enabled = False

            '---------------------------------
            '�X�\���ύX
            '---------------------------------
            btn_End.Text = "������"

            Me.Label1.Text = "���݁A�������ł��B"
            Me.Label2.Text = "�c�Ƃ��J�n����ꍇ�́A[�J�X����]��[�c�ƊJ�n]�{�^���������Ă��������B"
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetStatus")
    End Sub

    Private Function LF_GetTPM040(ByRef pRows As DataRow) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM040 = False

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT DEFMENUID,"
        strSQL = strSQL & "       DEFADVID,"
        strSQL = strSQL & "       CLMODE"
        strSQL = strSQL & "  FROM TPM040"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, pRows) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetTPM040 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[ - [�I��]����������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub mnu_End_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_End.Click

        Me.Close()

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�c�ƏI���{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_End_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_End.Click

        If GF_Msg("", "�c�Ƃ��I�����܂��B" & vbCrLf & "��낵���ł����H", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            ' ---- �A���P�[�g�W�v����уf�[�^�폜 -------------
            Call out_Enq()
            ' -------------------------------------------------
            '-----����f�[�^�����o�́i2013.10.22�j�V�K�쐬-----
            If GF_GetAppInfo("AUTO_PRICE_OUTPUT") = 0 Then
                Call LS_Auto_sales()
            End If
            '--------------------------------------------------

            Call LS_ChgLine()
            Call LS_SetStatus()
            If GF_GetAppInfo("DELIVARY_FLG") = "1" Or GF_GetAppInfo("DELIVARY_FLG") = "2" Then
                Call CNL2130.LS_SalesUpdate()
            End If
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�A���P�[�g�W�v����уf�[�^�폜
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2019.04.08
    ' --------------------------------------------------------------------------------
    Private Sub out_Enq()
        Dim phpCmd As String = "C:\php\php.exe"
        Dim fileDir As String = "C:\Apache Software Foundation\Apache2.2\htdocs\api\cross_i_navi\enq"
        Dim phpFile As String = "csv.php"
        Dim driveLetter = fileDir.Substring(0, 2)
        If System.IO.File.Exists(phpCmd) Then
            If System.IO.File.Exists(fileDir & "\" & phpFile) Then

                'Process�I�u�W�F�N�g���쐬
                Dim p As New System.Diagnostics.Process()

                'ComSpec(cmd.exe)�̃p�X���擾���āAFileName�v���p�e�B�Ɏw��
                p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec")
                '�o�͂�ǂݎ���悤�ɂ���
                p.StartInfo.UseShellExecute = False
                p.StartInfo.RedirectStandardOutput = True
                p.StartInfo.RedirectStandardInput = False
                '�E�B���h�E��\�����Ȃ��悤�ɂ���
                p.StartInfo.CreateNoWindow = True
                Dim strCommand As String = "/c " & driveLetter & " & CD """ & fileDir & """ & " & phpCmd & " """ & fileDir & "\" & phpFile & """"
                '�R�}���h���C�����w��i"/c"�͎��s����邽�߂ɕK�v�j
                p.StartInfo.Arguments = strCommand


                '�N��
                p.Start()

                '�o�͂�ǂݎ��
                Dim results As String = p.StandardOutput.ReadToEnd()

                '�v���Z�X�I���܂őҋ@����
                'WaitForExit��ReadToEnd�̌�ł���K�v������
                '(�e�v���Z�X�A�q�v���Z�X�Ńu���b�N�h�~�̂���)
                p.WaitForExit()
                p.Close()

                '�o�͂��ꂽ���ʂ�\��
                'Console.WriteLine(results)
            End If
        End If

    End Sub


    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�Ɩ��X�e�[�^�X�ؑ֏���
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_ChgLine()

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^�X�V
        '------------------------------
        'If Not GF_BeginTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        If Not LF_UpdTPM040() Then
            GoTo SYSTEM_ERROR
        End If

        DirectCast(MdiParent, CNL2010).btn_menu01.BackColor = Color.Violet
        DirectCast(MdiParent, CNL2010).btn_menu10.BackColor = Color.LightSkyBlue

        'If Not GF_CommitTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        '------------------------------
        ' �{�^���g�p�ېݒ�
        '------------------------------
        btn_End.Enabled = False

        Exit Sub

SYSTEM_ERROR:
        'Call GF_RollbackTrans()
        Call GS_ErrorTerm("LS_ChgLine")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�V�X�e���Ǘ��}�X�^ �X�V���� - �Ɩ��X�e�[�^�X�ؑ֏���
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM040() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM040 = False

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^�X�V
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM040"
        strSQL = strSQL & "   SET CLMODE = '" & GC_FALSE & "',"
        strSQL = strSQL & "       UPDID  = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD = '" & Now & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM040 = True

    End Function

    Private Sub LS_Auto_sales()

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


        '------------------------------
        ' �ۑ��t�H���_�A�t�@�C�����w��
        '------------------------------
        System.Environment.CurrentDirectory = Trim$(GF_GetAppInfo("SALES_AUTO_PATH"))  '�t�H���_���w��
        FileName = "PriceData(" & Format$(Now, "yyyyMMddHHmmss") & ").csv"             '�t�@�C�����w��

        '------------------------------
        ' ���[�f�[�^�擾����
        '------------------------------
        If Not LF_GetDATA(objData) Then
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

            Exit Sub
        End Try

        strStreamWriter.Close()
        Call GF_Msg("", "����f�[�^���쐬���܂���" & vbCrLf & "[" & FileName & "]", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_OutputCsv_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���[�f�[�^�擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.10.22 �V�K�쐬
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
        strSQL = ""
        strSQL = strSQL & " SELECT TPM010.GOODSCD AS '���i�ԍ�',"
        strSQL = strSQL & "        MAX(LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ, '�@', ' '))) + LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ2, '�@', ' ')))) AS '���i����',"
        strSQL = strSQL & "        ISNULL(SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END),0) AS '���㐔��',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 09 THEN TPD010.QUANTITY ELSE '0' END) AS '9:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 10 THEN TPD010.QUANTITY ELSE '0' END) AS '10:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 11 THEN TPD010.QUANTITY ELSE '0' END) AS '11:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 12 THEN TPD010.QUANTITY ELSE '0' END) AS '12:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 13 THEN TPD010.QUANTITY ELSE '0' END) AS '13:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 14 THEN TPD010.QUANTITY ELSE '0' END) AS '14:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 15 THEN TPD010.QUANTITY ELSE '0' END) AS '15:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 16 THEN TPD010.QUANTITY ELSE '0' END) AS '16:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 17 THEN TPD010.QUANTITY ELSE '0' END) AS '17:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 18 THEN TPD010.QUANTITY ELSE '0' END) AS '18:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 19 THEN TPD010.QUANTITY ELSE '0' END) AS '19:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 20 THEN TPD010.QUANTITY ELSE '0' END) AS '20:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 21 THEN TPD010.QUANTITY ELSE '0' END) AS '21:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 22 THEN TPD010.QUANTITY ELSE '0' END) AS '22:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 23 THEN TPD010.QUANTITY ELSE '0' END) AS '23:00',"
        strSQL = strSQL & "        SUM(CASE WHEN LEN(CONVERT(CHAR,TPD010.TRANSTIME)) = 1 THEN '0' WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 00 THEN TPD010.QUANTITY ELSE '0' END) AS '0:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 01 THEN TPD010.QUANTITY ELSE '0' END) AS '1:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 02 THEN TPD010.QUANTITY ELSE '0' END) AS '2:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 03 THEN TPD010.QUANTITY ELSE '0' END) AS '3:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 04 THEN TPD010.QUANTITY ELSE '0' END) AS '4:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 05 THEN TPD010.QUANTITY ELSE '0' END) AS '5:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 06 THEN TPD010.QUANTITY ELSE '0' END) AS '6:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 07 THEN TPD010.QUANTITY ELSE '0' END) AS '7:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 08 THEN TPD010.QUANTITY ELSE '0' END) AS '8:00',"
        strSQL = strSQL & "        ISNULL((SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END) * MAX(TPM010.PRICE)),0) AS '������z'"
        strSQL = strSQL & "   FROM TPM010 LEFT JOIN TPD010 ON TPM010.GOODSCD = TPD010.GOODSCD"
        strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <= '8999'"
        strSQL = strSQL & " GROUP BY TPM010.GOODSCD"

        '���ݕ��菤�i�ʏW�v
        strSQL = strSQL & " UNION"
        strSQL = strSQL & " SELECT TPM010.GOODSCD AS '���i�ԍ�',"
        strSQL = strSQL & "        MAX(LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ, '�@', ' '))) + LTRIM(RTRIM(REPLACE(TPM010.GOODSNMJ2, '�@', ' ')))) + '" & GF_GetAppInfo2("FREEGOODS_MARK") & "' AS '���i����',"
        strSQL = strSQL & "        ISNULL(SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END),0) AS '���㐔��',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 09 THEN TPD010.QUANTITY ELSE '0' END) AS '9:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 10 THEN TPD010.QUANTITY ELSE '0' END) AS '10:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 11 THEN TPD010.QUANTITY ELSE '0' END) AS '11:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 12 THEN TPD010.QUANTITY ELSE '0' END) AS '12:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 13 THEN TPD010.QUANTITY ELSE '0' END) AS '13:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 14 THEN TPD010.QUANTITY ELSE '0' END) AS '14:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 15 THEN TPD010.QUANTITY ELSE '0' END) AS '15:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 16 THEN TPD010.QUANTITY ELSE '0' END) AS '16:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 17 THEN TPD010.QUANTITY ELSE '0' END) AS '17:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 18 THEN TPD010.QUANTITY ELSE '0' END) AS '18:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 19 THEN TPD010.QUANTITY ELSE '0' END) AS '19:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 20 THEN TPD010.QUANTITY ELSE '0' END) AS '20:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 21 THEN TPD010.QUANTITY ELSE '0' END) AS '21:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 22 THEN TPD010.QUANTITY ELSE '0' END) AS '22:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 23 THEN TPD010.QUANTITY ELSE '0' END) AS '23:00',"
        strSQL = strSQL & "        SUM(CASE WHEN LEN(CONVERT(CHAR,TPD010.TRANSTIME)) = 1 THEN '0' WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 00 THEN TPD010.QUANTITY ELSE '0' END) AS '0:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 01 THEN TPD010.QUANTITY ELSE '0' END) AS '1:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 02 THEN TPD010.QUANTITY ELSE '0' END) AS '2:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 03 THEN TPD010.QUANTITY ELSE '0' END) AS '3:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 04 THEN TPD010.QUANTITY ELSE '0' END) AS '4:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 05 THEN TPD010.QUANTITY ELSE '0' END) AS '5:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 06 THEN TPD010.QUANTITY ELSE '0' END) AS '6:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 07 THEN TPD010.QUANTITY ELSE '0' END) AS '7:00',"
        strSQL = strSQL & "        SUM(CASE WHEN SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME), 9, 2) = 08 THEN TPD010.QUANTITY ELSE '0' END) AS '8:00',"
        strSQL = strSQL & "        ISNULL((SUM(CASE WHEN TPD010.TRANSTIME = 0 THEN '0' ELSE TPD010.QUANTITY END) * MAX(TPM010.PRICE)),0) AS '������z'"
        strSQL = strSQL & "   FROM TPM010 LEFT JOIN TPD010 ON TPM010.GOODSCD = TPD010.GOODSCD"
        strSQL = strSQL & "   WHERE TPM010.GOODSCD >= '0000' AND TPM010.GOODSCD <=8999"
        strSQL = strSQL & "   AND   TPD010.ORDERFLG = '50'"
        strSQL = strSQL & " GROUP BY TPM010.GOODSCD"
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

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

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�X�y�[�X���ߏ���
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2013.10.22 �V�K�쐬
    ' --------------------------------------------------------------------------------
    Public Function LF_PadSpc(ByVal pStr As String, ByVal Length As Long) As String

        LF_PadSpc = Space(Length - Len(Trim$(pStr))) & Trim$(pStr)

    End Function
End Class
