' --------------------------------------------------------------------------------
' �@�@�@�@�\�FCrossNavi - �J�X�������
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2011.11.07 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------
Public Class CNL2020
    Inherits System.Windows.Forms.Form

    '���̑�
    Private _�X�}���W�A�g�����X�V��� As �X�}���W�A�g�����X�V���^

    '�X�}���W HTTP�X�e�[�^�X
    Private Const HTTP_OK As String = "200 OK"
    Private Const HTTP_BAD_REQUEST As String = "400 BadRequest"
    Private Const HTTP_NOT_FOUND As String = "404 Not Found"
    Friend WithEvents btn_OutputGoodsData As System.Windows.Forms.Button
    Friend WithEvents btn_KioskGoodsData As System.Windows.Forms.Button
    Private Const HTTP_�z��O�G���[ As String = "�ڑ��G���["

#Region "�\����"

    Private Structure �X�}���W�A�g�����X�V���^
        Dim �捞���팏�� As Integer
        Dim �捞�G���[�R�[�h As String
        Dim �捞�G���[���e As String
        Dim �捞�G���[�ڍ� As String
        Dim HTTP�X�e�[�^�X As String

        Public Sub Initialize()
            �捞���팏�� = 0
            �捞�G���[�R�[�h = ""
            �捞�G���[���e = ""
            �捞�G���[�ڍ� = ""
            HTTP�X�e�[�^�X = ""
        End Sub

    End Structure

#End Region

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_MenuChg As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_AdvChg As System.Windows.Forms.ComboBox
    Friend WithEvents lsv_TermList As System.Windows.Forms.ListView
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents btn_TermChk As System.Windows.Forms.Button
    Friend WithEvents mnu_End As System.Windows.Forms.MenuItem
    Friend WithEvents btn_Start As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_UpdFUMENU As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_SMAREGI As System.Windows.Forms.Button
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CNL2020))
        Me.cbo_MenuChg = New System.Windows.Forms.ComboBox
        Me.cbo_AdvChg = New System.Windows.Forms.ComboBox
        Me.lsv_TermList = New System.Windows.Forms.ListView
        Me.stb_Msg = New System.Windows.Forms.StatusBar
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.mnu_End = New System.Windows.Forms.MenuItem
        Me.btn_TermChk = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_KioskGoodsData = New System.Windows.Forms.Button
        Me.btn_OutputGoodsData = New System.Windows.Forms.Button
        Me.btn_SMAREGI = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_UpdFUMENU = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_Start = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbo_MenuChg
        '
        Me.cbo_MenuChg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_MenuChg.Location = New System.Drawing.Point(27, 21)
        Me.cbo_MenuChg.Name = "cbo_MenuChg"
        Me.cbo_MenuChg.Size = New System.Drawing.Size(279, 23)
        Me.cbo_MenuChg.TabIndex = 30
        Me.cbo_MenuChg.Text = "ComboBox1"
        '
        'cbo_AdvChg
        '
        Me.cbo_AdvChg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_AdvChg.Location = New System.Drawing.Point(27, 21)
        Me.cbo_AdvChg.Name = "cbo_AdvChg"
        Me.cbo_AdvChg.Size = New System.Drawing.Size(279, 23)
        Me.cbo_AdvChg.TabIndex = 31
        Me.cbo_AdvChg.Text = "ComboBox2"
        '
        'lsv_TermList
        '
        Me.lsv_TermList.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_TermList.Location = New System.Drawing.Point(208, 155)
        Me.lsv_TermList.Name = "lsv_TermList"
        Me.lsv_TermList.Size = New System.Drawing.Size(790, 495)
        Me.lsv_TermList.TabIndex = 5
        Me.lsv_TermList.UseCompatibleStateImageBehavior = False
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
        'MenuItem1
        '
        Me.MenuItem1.Index = -1
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.mnu_End})
        Me.MenuItem1.Text = "�J�X����"
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
        'btn_TermChk
        '
        Me.btn_TermChk.BackColor = System.Drawing.SystemColors.Control
        Me.btn_TermChk.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_TermChk.Location = New System.Drawing.Point(609, 10)
        Me.btn_TermChk.Name = "btn_TermChk"
        Me.btn_TermChk.Size = New System.Drawing.Size(180, 50)
        Me.btn_TermChk.TabIndex = 2
        Me.btn_TermChk.Text = "�d���̊m�F"
        Me.btn_TermChk.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_KioskGoodsData)
        Me.Panel1.Controls.Add(Me.btn_OutputGoodsData)
        Me.Panel1.Controls.Add(Me.btn_SMAREGI)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_UpdFUMENU)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btn_Start)
        Me.Panel1.Controls.Add(Me.btn_TermChk)
        Me.Panel1.Controls.Add(Me.lsv_TermList)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 10
        '
        'btn_KioskGoodsData
        '
        Me.btn_KioskGoodsData.BackColor = System.Drawing.SystemColors.Control
        Me.btn_KioskGoodsData.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btn_KioskGoodsData.Location = New System.Drawing.Point(417, 10)
        Me.btn_KioskGoodsData.Name = "btn_KioskGoodsData"
        Me.btn_KioskGoodsData.Size = New System.Drawing.Size(180, 50)
        Me.btn_KioskGoodsData.TabIndex = 156
        Me.btn_KioskGoodsData.Text = "���i�}�X�^CSV�o��"
        Me.btn_KioskGoodsData.UseVisualStyleBackColor = False
        Me.btn_KioskGoodsData.Visible = False
        '
        'btn_OutputGoodsData
        '
        Me.btn_OutputGoodsData.BackColor = System.Drawing.SystemColors.Control
        Me.btn_OutputGoodsData.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btn_OutputGoodsData.Location = New System.Drawing.Point(417, 10)
        Me.btn_OutputGoodsData.Name = "btn_OutputGoodsData"
        Me.btn_OutputGoodsData.Size = New System.Drawing.Size(180, 50)
        Me.btn_OutputGoodsData.TabIndex = 155
        Me.btn_OutputGoodsData.Text = "���i�}�X�^CSV�o��"
        Me.btn_OutputGoodsData.UseVisualStyleBackColor = False
        Me.btn_OutputGoodsData.Visible = False
        '
        'btn_SMAREGI
        '
        Me.btn_SMAREGI.BackColor = System.Drawing.SystemColors.Control
        Me.btn_SMAREGI.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btn_SMAREGI.Location = New System.Drawing.Point(417, 10)
        Me.btn_SMAREGI.Name = "btn_SMAREGI"
        Me.btn_SMAREGI.Size = New System.Drawing.Size(180, 50)
        Me.btn_SMAREGI.TabIndex = 154
        Me.btn_SMAREGI.Text = "�X�}���W�f�[�^�X�V"
        Me.btn_SMAREGI.UseVisualStyleBackColor = False
        Me.btn_SMAREGI.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(423, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 30)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "�p�l���𒍕���ʂ�" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   �؂�ւ��܂�"
        '
        'btn_UpdFUMENU
        '
        Me.btn_UpdFUMENU.BackColor = System.Drawing.SystemColors.Control
        Me.btn_UpdFUMENU.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btn_UpdFUMENU.Location = New System.Drawing.Point(417, 10)
        Me.btn_UpdFUMENU.Name = "btn_UpdFUMENU"
        Me.btn_UpdFUMENU.Size = New System.Drawing.Size(180, 50)
        Me.btn_UpdFUMENU.TabIndex = 152
        Me.btn_UpdFUMENU.Text = "POS�f�[�^�X�V"
        Me.btn_UpdFUMENU.UseVisualStyleBackColor = False
        Me.btn_UpdFUMENU.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(793, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 30)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "�d�����u�~�v�̏ꍇ��" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   �@�B�̓d�����m�F���Ă�������"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(204, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(794, 1)
        Me.Label11.TabIndex = 148
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.cbo_MenuChg)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(243, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 56)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "���ݕ\�����̃��j���[�ł�"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.cbo_AdvChg)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(630, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 56)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "���ݕ\�����̂��m�点�ł�"
        '
        'btn_Start
        '
        Me.btn_Start.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Start.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Start.Location = New System.Drawing.Point(219, 10)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(180, 50)
        Me.btn_Start.TabIndex = 1
        Me.btn_Start.Text = "�c�ƊJ�n"
        Me.btn_Start.UseVisualStyleBackColor = False
        '
        'CNL2020
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1016, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stb_Msg)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CNL2020"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
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
    Private Sub CNL2020_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objForm As New CNL1810()

        Try
            '------------------------------
            ' �t�H�[�����̐ݒ�
            '------------------------------
            Me.Text = " �J�X���� "

            '---------------------------------
            '����{�^����\����
            '---------------------------------
            Me.ControlBox = False

            '------------------------------
            ' �N���X�e�[�^�X�\��
            '------------------------------
            objForm.Show()
            objForm.lbl_Msg.Text = "�N���������ł��B���΂炭���҂���������..."
            objForm.TopMost = True
            System.Windows.Forms.Application.DoEvents()

            '------------------------------
            ' ����������
            '------------------------------
            Call GS_StatusSetup(stb_Msg)
            cbo_MenuChg.DropDownStyle = ComboBoxStyle.DropDownList
            cbo_AdvChg.DropDownStyle = ComboBoxStyle.DropDownList

            '------------------------------
            ' POS�f�[�^�X�V�{�^���\������
            '------------------------------
            If GF_GetAppInfo("OES_TOOL_VER_CNL1501") = "1" Then
                Label1.Visible = False
                btn_UpdFUMENU.Visible = True
            Else
                Label1.Visible = True
                btn_UpdFUMENU.Visible = False
            End If

            '------------------------------
            ' �X�}���W�f�[�^�X�V�{�^���\������
            '------------------------------
            If GF_GetAppInfo("SMAREGI_FLG") = "1" Then
                Label1.Visible = False
                btn_UpdFUMENU.Visible = False
                btn_SMAREGI.Visible = True
                btn_OutputGoodsData.Visible = False
                btn_KioskGoodsData.Visible = False ' --- (2022.09.01) Kiosk�������Z�@�A�g
            Else
                btn_SMAREGI.Visible = False
            End If

            '------------------------------
            ' ���i�}�X�^CSV�o�̓{�^���\������i�e���I�J���W�A�g�j
            '------------------------------
            If GF_GetAppInfo("TERAOKA_FLG") = "1" Then
                Label1.Visible = False
                btn_UpdFUMENU.Visible = False
                btn_SMAREGI.Visible = False
                btn_OutputGoodsData.Visible = True
                btn_KioskGoodsData.Visible = False ' --- (2022.09.01) Kiosk�������Z�@�A�g
            Else
                btn_OutputGoodsData.Visible = False
            End If

            ' --- (2022.09.01) Kiosk�������Z�@�A�g --------------
            '------------------------------
            ' ���i�}�X�^CSV�o�̓{�^���\������iKiosk�������Z�@�A�g�j
            '------------------------------
            If GF_GetAppInfo2("KIOSK_QR_FLG") = "1" Then
                Label1.Visible = False
                btn_UpdFUMENU.Visible = False
                btn_SMAREGI.Visible = False
                btn_OutputGoodsData.Visible = False
                btn_KioskGoodsData.Visible = True
            Else
                btn_KioskGoodsData.Visible = False
            End If
            ' --- (2022.09.01) Kiosk�������Z�@�A�g --------------

            '------------------------------
            ' ���j���[/�L���ؑփR���{�ݒ�
            '------------------------------
            Call LS_MenuCmbSetup()
            Call LS_AdvCmbSetup()

            '------------------------------
            ' �Ǘ��}�X�^��茻���ݒ�
            '------------------------------
            Call LS_SetStatus()

            '------------------------------
            ' �v���O���X�o�[�\��
            '------------------------------
            Dim i As Integer = 0
            For i = 1 To 20
                Threading.Thread.Sleep(250)
                objForm.pgs_Status.Value = 5 * i
            Next

            '------------------------------
            ' �[���@�ғ��m�F�X���b�h�J�n
            '------------------------------
            G_Thread = New Threading.Thread(AddressOf LS_CheckPingResult)
            G_Thread.Start()

            '------------------------------
            ' �N���X�e�[�^�X�N���[�Y
            '------------------------------
            objForm.Close()

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL2020_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�[���@�ꗗ �ݒ菈��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetTermList()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow
        Dim lngCnt As Long
        Dim objItem As ListViewItem

        '------------------------------
        ' �����ݒ�
        '------------------------------
        Control.CheckForIllegalCrossThreadCalls = False
        With lsv_TermList
            .BeginUpdate()
            .Items.Clear()
            .Columns.Clear()

            .View = View.Details
            .FullRowSelect = True
            .Columns.Add("", 0, HorizontalAlignment.Left)
            .Columns.Add("�d��", 96, HorizontalAlignment.Center)
            .Columns.Add("���Ȕԍ�", 96, HorizontalAlignment.Center)
            .Columns.Add("�@��敪", 216, HorizontalAlignment.Left)
            .Columns.Add("�h�o�A�h���X", 144, HorizontalAlignment.Left)
        End With

        '------------------------------
        ' �[���@�ꗗ�擾
        '------------------------------
        If Not LF_GetTPM050(objData) Then
            GoTo SYSTEM_ERROR
        End If

        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count
            objRows = Nothing
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                GoTo SYSTEM_ERROR
            End If

            objItem = New ListViewItem()
            With objItem
                .Text = ""
                .SubItems.Add("---")
                .SubItems.Add(Trim$(IIf(IsDBNull(objRows("SEATID")), "-", objRows("SEATID"))))
                .SubItems.Add(Trim$(IIf(IsDBNull(objRows("CODENM")), System.Configuration.ConfigurationManager.AppSettings("OrderPanelNotAssigned"), objRows("CODENM"))))
                .SubItems.Add(objRows("TERMID"))
            End With
            lsv_TermList.Items.Add(objItem)

            lngCnt = lngCnt + 1
        End While

        lsv_TermList.EndUpdate()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetTermList")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�[���@�ꗗ �擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM050(ByRef pData As DataSet) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM050 = False

        '------------------------------
        ' �r�p�k������
        '------------------------------
        '�z�ȋ@�\�C��
        If GF_GetAppInfo("SEAT_DISTRIBUTION ") = "0" Then
            strSQL = ""
            strSQL = strSQL & "SELECT TPM051.REALTERMID AS TERMID,"
            strSQL = strSQL & "       TPM050.SEATID,"
            strSQL = strSQL & "       TPM030.CODENM"
            strSQL = strSQL & "  FROM TPM051"
            strSQL = strSQL & "       LEFT JOIN TPM050 ON TPM051.VIRTUALTERMID = TPM050.TERMID"
            strSQL = strSQL & "       LEFT JOIN TPM030 ON TPM050.TERMKIND      = TPM030.CODEVAL"
            strSQL = strSQL & "   AND TPM030.CODEID   = 'TERMKIND'"
            strSQL = strSQL & " UNION "
            strSQL = strSQL & "SELECT TPM050.TERMID,"
            strSQL = strSQL & "       TPM050.SEATID,"
            strSQL = strSQL & "       TPM030.CODENM"
            strSQL = strSQL & "  FROM TPM050,"
            strSQL = strSQL & "       TPM030"
            strSQL = strSQL & " WHERE TPM050.TERMKIND = TPM030.CODEVAL"
            strSQL = strSQL & "   AND TPM030.CODEID   = 'TERMKIND'"
            strSQL = strSQL & "   AND TPM050.TERMKIND NOT IN ('TCA','TC0')"
        Else
            strSQL = ""
            strSQL = strSQL & "SELECT TPM050.TERMID,"
            strSQL = strSQL & "       TPM050.SEATID,"
            strSQL = strSQL & "       TPM030.CODENM"
            strSQL = strSQL & "  FROM TPM050,"
            strSQL = strSQL & "       TPM030"
            strSQL = strSQL & " WHERE TPM050.TERMKIND = TPM030.CODEVAL"
            strSQL = strSQL & "   AND TPM030.CODEID   = 'TERMKIND'"
            strSQL = strSQL & " ORDER BY TPM050.TERMKIND,"
            strSQL = strSQL & "          TPM050.SEATID"
        End If

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        pData = objData
        LF_GetTPM050 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�ؑփR���{�ݒ菈��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_MenuCmbSetup()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow
        Dim lngCnt As Long
        Dim strMenuOID As String
        Dim strMenuNM As String
        Dim strMenuID As String

        '------------------------------
        ' ���j���[���X�g�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM060.MENUID,"
        strSQL = strSQL & "       TPM060.MENUNM,"
        strSQL = strSQL & "       MAX(TPM060.UPDYMD) AS MAXYMD"
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " GROUP BY TPM060.MENUID,"
        strSQL = strSQL & "          TPM060.MENUNM"
        strSQL = strSQL & " ORDER BY TPM060.MENUNM,"
        strSQL = strSQL & "          TPM060.MENUID"

        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' ���j���[�I���R���{�ݒ�
        '------------------------------
        Try
            cbo_MenuChg.Items.Clear()
            lngCnt = 0
            strMenuNM = ""
            strMenuID = ""
            strMenuOID = ""

            While lngCnt < objData.Tables("com").Rows.Count
                objRows = Nothing
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    GoTo SYSTEM_ERROR
                End If

                If lngCnt = 0 Then
                    strMenuNM = Trim$(objRows("MENUNM"))
                    strMenuID = Trim$(objRows("MENUID"))
                    strMenuOID = Trim$(objRows("MENUID"))
                End If

                If strMenuNM <> Trim$(objRows("MENUNM")) Then
                    Call GS_CboItemSet(cbo_MenuChg, strMenuNM, strMenuID & vbTab & strMenuOID)
                    strMenuOID = Trim$(objRows("MENUID"))
                End If

                strMenuNM = Trim$(objRows("MENUNM"))
                strMenuID = Trim$(objRows("MENUID"))

                lngCnt = lngCnt + 1
            End While

            Call GS_CboItemSet(cbo_MenuChg, strMenuNM, strMenuID & vbTab & strMenuOID)

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_MenuCmbSetup")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���ؑփR���{�ݒ菈��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_AdvCmbSetup()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow
        Dim lngCnt As Long

        '------------------------------
        ' �L�����X�g�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM080.ADVGRP_ID,"
        strSQL = strSQL & "       TPM080.ADVGRP_NM"
        strSQL = strSQL & "  FROM TPM080"
        strSQL = strSQL & " GROUP BY TPM080.ADVGRP_ID,"
        strSQL = strSQL & "          TPM080.ADVGRP_NM"

        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �L���I���R���{�ݒ�
        '------------------------------
        Try
            cbo_AdvChg.Items.Clear()
            lngCnt = 0

            While lngCnt < objData.Tables("com").Rows.Count
                objRows = Nothing
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    GoTo SYSTEM_ERROR
                End If

                Call GS_CboItemSet(cbo_AdvChg, Trim$(objRows("ADVGRP_NM")), Trim$(objRows("ADVGRP_ID")))

                lngCnt = lngCnt + 1
            End While

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AdvCmbSetup")
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
        Call GS_CboChgSel(cbo_MenuChg, Trim$(objRows("DEFMENUID")))
        Call GS_CboChgSel(cbo_AdvChg, Trim$(objRows("DEFADVID")))

        If Trim$(objRows("CLMODE")) = GC_TRUE Then
            '------------------------------
            ' �{�^���g�p�ېݒ�
            '------------------------------
            btn_Start.Enabled = False

            '---------------------------------
            '�J�X�\���ύX
            '---------------------------------
            btn_Start.Text = "�c�ƒ�"
        Else
            '------------------------------
            ' �{�^���g�p�ېݒ�
            '------------------------------
            btn_Start.Enabled = True

            '---------------------------------
            '�X�\���ύX
            '---------------------------------
            btn_Start.Text = "�c�ƊJ�n"
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
        strSQL = strSQL & "SELECT TPM040.DEFMENUID,"
        strSQL = strSQL & "       TPM040.DEFADVID,"
        strSQL = strSQL & "       TPM040.CLMODE"
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
    ' �@�@�@�@�\�F�[���ғ��󋵊m�F�����X���b�h��`
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_CheckPingResult()

        Do
            Call LS_SetTermList()

            If Not LF_CheckPingResult() Then
                GoTo SYSTEM_ERROR
            End If

            Threading.Thread.Sleep(1000 * CLng(GF_GetAppInfo("CHK_TERM_INFO")))
        Loop

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_CheckPingResult")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�[���@�ғ��� �m�F
    ' �@�@�\�T�v�F�S�[���@�ɑ΂��APING�p�P�b�g�̉����ɂ��ғ��󋵂𔻒肷��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_CheckPingResult() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim intProcID As Integer
        Dim objFile As System.IO.StreamReader
        Dim strLine As String
        Dim lngCnt As Long = Nothing
        Dim lngMaxRow As Long = Nothing
        Dim strTargetIP As String
        Dim strTempFile As String
        Dim strResult As String
        Dim objItem As ListViewItem
        Dim inrPingTime As Integer

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_CheckPingResult = False

        Try
            btn_TermChk.Enabled = False

            '------------------------------
            ' PING���o���Ԑݒ�
            '------------------------------
            inrPingTime = 1000 * CLng(GF_GetAppInfo("CHK_PING_INFO"))

            For Each objItem In lsv_TermList.Items
                '------------------------------
                ' �����Ώے[��
                '------------------------------
                strTargetIP = Trim$(objItem.SubItems(4).Text)
                strTempFile = g_udtAppConfig.strTempPath & "\" & Replace(strTargetIP, ".", "_") & ".txt"

                '------------------------------
                ' PING�p�P�b�g���o
                '------------------------------
                intProcID = Shell("cmd.exe /C ping.exe -n 2 " & strTargetIP & " > """ & strTempFile & """", AppWinStyle.Hide, True, inrPingTime)

                '------------------------------
                ' ���ʃt�@�C����蔻��
                '------------------------------
                If intProcID = 0 Then
                    objFile = New System.IO.StreamReader(strTempFile, System.Text.Encoding.Default)
                    strLine = objFile.ReadLine

                    strResult = ""
                    While Not strLine Is Nothing
                        If strLine.IndexOf("100% �̑���") <> -1 Then
                            ' If strLine.IndexOf("100% loss") <> -1 Then
                            strResult = "�~"
                            Exit While
                        End If
                        strLine = objFile.ReadLine
                    End While

                    If Len(Trim$(strResult)) = 0 Then
                        objItem.SubItems(1).Text = "��"
                    Else
                        objItem.SubItems(1).Text = strResult
                    End If

                    objFile.Close()
                    System.IO.File.Delete(strTempFile)
                Else
                    objItem.SubItems(1).Text = "�~"
                End If

                System.Windows.Forms.Application.DoEvents()
            Next

            btn_TermChk.Enabled = True

        Catch ex As System.Threading.ThreadAbortException
            Exit Try
        Catch
            btn_TermChk.Enabled = True
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_CheckPingResult = True

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
    ' �@�@�@�@�\�F�d���m�F�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_TermChk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TermChk.Click

        G_Thread.Abort()
        G_Thread = New Threading.Thread(AddressOf LS_CheckPingResult)
        G_Thread.Start()

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�ؑփR���{ �I����ԕω�������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub cbo_MenuChg_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_MenuChg.SelectionChangeCommitted

        Call LS_ChgMenuID()

        GF_Msg("", "�\�����郁�j���[��ύX���܂���", MsgBoxStyle.OkOnly)

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�L���ؑփR���{ �I����ԕω�������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub cbo_AdvChg_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_AdvChg.SelectionChangeCommitted

        'If Not GF_BeginTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        If Not LF_UpdTPM040_2() Then
            GoTo SYSTEM_ERROR
        End If

        'If Not GF_CommitTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        GF_Msg("", "�\�����邨�m�点��ύX���܂���", MsgBoxStyle.OkOnly)

        Exit Sub

SYSTEM_ERROR:
        'Call GF_RollbackTrans()
        Call GS_ErrorTerm("cbo_MenuChg_SelectionChangeCommitted")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�V�X�e���Ǘ��}�X�^ �X�V�����i�P�j - ���j���[�ؑ֏���
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM040_1() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM040_1 = False

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^ �X�V
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM040"
        strSQL = strSQL & "   SET DEFMENUID = '" & Trim$(GF_CboGetCode(cbo_MenuChg, cbo_MenuChg.SelectedIndex)) & "',"
        strSQL = strSQL & "       UPDID     = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD    = '" & Now & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM040_1 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�V�X�e���Ǘ��}�X�^ �X�V�����i�Q�j - �L���ؑ֏���
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM040_2() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM040_2 = False

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^�X�V
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM040"
        strSQL = strSQL & "   SET DEFADVID = '" & Trim$(GF_CboGetCode(cbo_AdvChg, cbo_AdvChg.SelectedIndex)) & "',"
        strSQL = strSQL & "       UPDID    = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD   = '" & Now & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM040_2 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�����f�[�^��������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_TableInit() As String

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim strSQL2 As String
        ' --- (2018.12.20) ���}���[���A�g --------------
        'Dim strTbl(12) As String
        Dim strTbl(18) As String
        ' --- (2018.12.20) ���}���[���A�g --------------
        Dim lngCnt As Long

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_TableInit = "�폜�O�G���["
        
        ' 2014-10-07 �n���f�B�@�\�ǉ��ɔ����e�[�u���ǉ� TPD013, TPD600
        strTbl(0) = "TPD010"
        strTbl(1) = "TPD011"
        strTbl(2) = "TPD012"
        strTbl(3) = "TPD013"
        strTbl(4) = "TPD200"
        strTbl(5) = "TPD210"
        strTbl(6) = "TPD220"
        strTbl(7) = "TPD230"
        strTbl(8) = "TPD240"
        strTbl(9) = "TPD250"
        strTbl(10) = "TPD500"
        strTbl(11) = "TPD600"
        strTbl(12) = "TPD052"
        ' --- (2018.12.20) ���}���[���A�g --------------
        strTbl(13) = "TPD400"
        strTbl(14) = "TPD410"
        ' --- (2018.12.20) ���}���[���A�g --------------
        ' --- (2019.05.23) ���ʂ��[�����X���Ǘ� --------------
        strTbl(15) = "TPD014"
        ' --- (2019.05.23) ���ʂ��[�����X���Ǘ� --------------
        ' 2019-11-06 --------------
        strTbl(16) = "TPD400"
        strTbl(17) = "TPD410"
        strTbl(18) = "TPD730" ' 
        ' -------------------------


        '------------------------------
        ' �e�[�u���N���A����
        '------------------------------
        If Not GF_BeginTrans() Then
            Exit Function
        End If

        For lngCnt = 0 To UBound(strTbl)
            If Len(Trim$(strTbl(lngCnt))) <> 0 Then
                ' 2014-10-07 �n���f�B�@�\�ǉ��ɔ����C�� TPD012 �͈ȑO�ƕʕ�
                'If GF_GetAppInfo2("CNWH_RFIDWRITE") = "0" And lngCnt = 2 Then
                ' �^�O�����݋@�\�����f�[�^�����e�[�u����"TPD012"�̏ꍇ
                'Else
                ' ��L�ȊO�̏ꍇ
                strSQL = ""
                ' 2019-11-06 ----------------------------------------------------------------------------
                If strTbl(lngCnt) = "TPD730" Then
                    strSQL = strSQL & "IF OBJECT_ID(N'" & strTbl(lngCnt) & "', N'U') IS NOT NULL TRUNCATE TABLE " & strTbl(lngCnt)
                Else
                    strSQL = strSQL & "TRUNCATE TABLE " & strTbl(lngCnt)
                End If
                ' ---------------------------------------------------------------------------------------
                LF_TableInit = strSQL
                If Not GF_UpdData(strSQL) Then
                    Call GF_RollbackTrans()
                    Exit Function
                End If

                'End If

            End If
        Next

        ' 2014-10-07 �n���f�B�����摜�폜
        For Each memoImgFile As String In System.IO.Directory.GetFiles("C:\inetpub\wwwroot\CNWI001\memo")
            System.IO.File.Delete(memoImgFile)
        Next

        If GF_GetAppInfo("NOTIFICATION_FLG") = "0" Then

            strSQL = ""
            strSQL = strSQL & "TRUNCATE TABLE SYS_TP.T_KITCHEN_TRANS_R"
            LF_TableInit = strSQL
            If Not GF_UpdData(strSQL) Then
                Call GF_RollbackTrans()
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "TRUNCATE TABLE SYS_TP.T_KITCHEN_TRANS"
            LF_TableInit = strSQL
            If Not GF_UpdData(strSQL) Then
                Call GF_RollbackTrans()
                Exit Function
            End If

        End If

        '�����ԍ��s��Ή�  2013.11.06
        If GF_GetAppInfo3("CNWH002_1") = "1" Then          '�e�C�N�A�E�g�@�\�g�p����ꍇ
            strSQL2 = ""
            strSQL2 = strSQL2 & "UPDATE TPD050 SET D1 = '0'"
            strSQL2 = strSQL2 & " WHERE  TERMKIND = 'TCB'"
            LF_TableInit = strSQL2
            If Not GF_UpdData(strSQL2) Then
                Call GF_RollbackTrans()
                Exit Function
            End If

        Else
            '���g�p���A�������Ȃ�
        End If

        ' ���G�o�^�@���ȊǗ��}�X�^�̏����� 2014.2.24
        strSQL2 = ""
        strSQL2 = strSQL2 & "UPDATE TPD051 SET D1 = '0',"
        strSQL2 = strSQL2 & "                  D2 = '0',"
        strSQL2 = strSQL2 & "                  D3 = '0',"
        strSQL2 = strSQL2 & "                  D4 = '0',"
        strSQL2 = strSQL2 & "                  D5 = '0',"
        strSQL2 = strSQL2 & "                  D6 = '0',"
        strSQL2 = strSQL2 & "                  D7 = '0',"
        strSQL2 = strSQL2 & "                  D8 = '0',"
        strSQL2 = strSQL2 & "                  D9 = '0',"
        strSQL2 = strSQL2 & "                  D10 = '0',"
        strSQL2 = strSQL2 & "                  D11 = '0',"
        strSQL2 = strSQL2 & "                  D12 = '0',"
        strSQL2 = strSQL2 & "                  D13 = '0',"
        strSQL2 = strSQL2 & "                  D14 = '0',"
        strSQL2 = strSQL2 & "                  D15 = '0',"
        strSQL2 = strSQL2 & "                  D16 = '0',"
        strSQL2 = strSQL2 & "                  D17 = '0',"
        strSQL2 = strSQL2 & "                  D18 = '0',"
        strSQL2 = strSQL2 & "                  D19 = '0',"
        strSQL2 = strSQL2 & "                  D20 = '0',"
        strSQL2 = strSQL2 & "                  D21 = '0',"
        strSQL2 = strSQL2 & "                  D22 = '0',"
        strSQL2 = strSQL2 & "                  D23 = '0',"
        strSQL2 = strSQL2 & "                  D24 = '0',"
        strSQL2 = strSQL2 & "                  D25 = '0',"
        strSQL2 = strSQL2 & "                  D26 = '0',"
        strSQL2 = strSQL2 & "                  D27 = '0',"
        strSQL2 = strSQL2 & "                  D28 = '0',"
        strSQL2 = strSQL2 & "                  D29 = '0',"
        strSQL2 = strSQL2 & "                  D30 = '0'"
        strSQL2 = strSQL2 & " WHERE TERMKIND IN ('TC0', 'TCA', 'TCB')"

        If Not GF_UpdData(strSQL2) Then
            LF_TableInit = strSQL2
            Call GF_RollbackTrans()
            Exit Function
        End If

        If Not GF_CommitTrans() Then
            LF_TableInit = "�R�~�b�g���s"
            Call GF_RollbackTrans()
            Exit Function
        End If

        '------------------------------
        ' �[����ԃt���O��S�ċ�ȏ�Ԃɂ���
        '------------------------------

        Call UpdateOrderStatus()

        '------------------------------
        ' �Q�[���@�\���菈��
        '------------------------------
        If Trim$(GF_GetAppInfo2("CNWH_GAMEFLG")) = GC_FALSE Then
            '------------------------------
            ' �Q�[���֘A�e�[�u���̍X�V
            '------------------------------
            Call UpdateGameTable()
        End If

        '------------------------------
        ' �H�׈��ݕ��� TPD050������
        '------------------------------
        If Trim$(GF_GetAppInfo("PRICE_TYPE")) = GC_FALSE Then
            '------------------------------
            ' �Q�[���֘A�e�[�u���̍X�V
            '------------------------------
            Call UpdateGameTable()
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_TableInit = ""

    End Function


    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�c�ƊJ�n�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Start.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strStnLink As String
        Dim strSonetLink As String
        Dim strTagRWLink As String
        Dim strSysType As String
        Dim strGameLink As String
        Dim strTicketLink As String
        Dim strStnLink_B As String   'BIXOLON
        Dim strSmaregiLink As String
        ' --- (2018.12.20) ���}���[���A�g --------------
        Dim strLaneLink As String
        ' --- (2018.12.20) ���}���[���A�g --------------
        Dim tableInitError As String
        Dim strFlgTecDataImportPath As String

        strStnLink = Nothing
        strSonetLink = Nothing
        strTagRWLink = Nothing
        strGameLink = Nothing
        strTicketLink = Nothing
        strStnLink_B = Nothing
        strSmaregiLink = Nothing
        ' --- (2018.12.20) ���}���[���A�g --------------
        strLaneLink = Nothing
        ' --- (2018.12.20) ���}���[���A�g --------------

        If GF_Msg("", "�c�Ƃ��J�n���܂��B" & vbCrLf & "��낵���ł����H", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            strSysType = GF_GetAppInfo("SYS_TYPE")

            If Trim$(strSysType) = "2" Or Trim$(strSysType) = "3" Then
                strStnLink = GF_GetAppInfo("STNLINK")
                If Len(Trim$(strStnLink)) = 0 Then
                    Call GF_Msg("", "�X�e�[�V�����A�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    If System.IO.File.Exists(Trim$(strStnLink)) = False Then
                        Call GF_Msg("", "�X�e�[�V�����A�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If

                If Trim$(GF_GetAppInfo("TEC_USE_FLG")) = "0" Then
                    strStnLink_B = GF_GetAppInfo("EKCPLINK")
                    If Len(Trim$(strStnLink_B)) = 0 Then
                        Call GF_Msg("", "�v�����^�A�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        If System.IO.File.Exists(Trim$(strStnLink_B)) = False Then
                            Call GF_Msg("", "�v�����^�A�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                    End If
                Else
                    If Trim$(GF_GetAppInfo("TAKEOUTPRINT_USE_FLG")) = "0" Then
                        strStnLink_B = GF_GetAppInfo("EKCPLINK")
                        If Len(Trim$(strStnLink_B)) = 0 Then
                            Call GF_Msg("", "�v�����^�A�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                            Exit Sub
                        Else
                            If System.IO.File.Exists(Trim$(strStnLink_B)) = False Then
                                Call GF_Msg("", "�v�����^�A�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                                Exit Sub
                            End If
                        End If
                    End If
                End If


            ElseIf Trim$(strSysType) = "1" Then
                strStnLink_B = GF_GetAppInfo("EKCPLINK")
                If Len(Trim$(strStnLink_B)) = 0 Then
                    Call GF_Msg("", "�v�����^�A�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    If System.IO.File.Exists(Trim$(strStnLink_B)) = False Then
                        Call GF_Msg("", "�v�����^�A�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If

                If Trim$(GF_GetAppInfo("SMAREGI_FLG")) = "1" Then
                    '�X�}���W�A�g����̏ꍇ
                    strSmaregiLink = Trim$(GF_GetAppInfo("SMAREGI_LINK"))
                    If Len(strSmaregiLink) = 0 Then
                        Call GF_Msg("", "�X�}���W�A�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        If System.IO.File.Exists(strSmaregiLink) = False Then
                            Call GF_Msg("", "�X�}���W�A�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                    End If
                End If
            End If

            If Trim$(GF_GetAppInfo("H_USE")) = "1" Then
                strSonetLink = GF_GetAppInfo("H_PATH")
                If System.IO.File.Exists(Trim$(strSonetLink)) = False Then
                    Call GF_Msg("", "�\���@�A�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If

            ' �^�O�����ݘA�g�v���O�����N���m�F
            If Trim$(GF_GetAppInfo2("CNWH_RFIDWRITE")) = "1" Then
                strTagRWLink = Trim$(GF_GetAppInfo("TAGLINK"))
                If Len(strTagRWLink) = 0 Then
                    Call GF_Msg("", "�^�O�����ݘA�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    If System.IO.File.Exists(strTagRWLink) = False Then
                        Call GF_Msg("", "�^�O�����ݘA�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            End If

            '�Q�[���@�\�A�g�v���O�����N���m�F
            If Trim$(GF_GetAppInfo2("CNWH_GAMEFLG")) = "1" And Trim$(GF_GetAppInfo2("CNWH_GAMEOUTPUT")) = "0" Then
                strGameLink = GF_GetAppInfo("GAMELINK")
                If Len(Trim$(strGameLink)) = 0 Then
                    Call GF_Msg("", "�Q�[���@�\�A�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    If System.IO.File.Exists(Trim$(strGameLink)) = False Then
                        Call GF_Msg("", "�Q�[���@�\�A�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            End If

            '�����@�A�g�v���O�����N���m�F
            If Trim$(GF_GetAppInfo2("HAKKEN_USE")) = "1" Then
                strTicketLink = GF_GetAppInfo("HAKKENLINK")
                If Len(Trim$(strTicketLink)) = 0 Then
                    Call GF_Msg("", "�����@�A�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    If System.IO.File.Exists(Trim$(strTicketLink)) = False Then
                        Call GF_Msg("", "�����@�A�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            End If

            ' --- (2018.12.20) �k���{�J�R�[���}���[���A�g --------------
            '�k���{�J�R�[���}���[���A�g�v���O�����N���m�F
            If GF_GetAppInfo("LANE_FLG") = "2" Then
                strLaneLink = GF_GetAppInfo("LANE_PATH")
                If System.IO.File.Exists(Trim$(strLaneLink)) = False Then
                    Call GF_Msg("", "���}���[���A�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
            ' --- (2018.12.20) �k���{�J�R�[���}���[���A�g --------------

            ' --- (2019.02.05) ���[�v�V�X�e���������[���A�g --------------
            '���[�v�V�X�e���������[���A�g�v���O�����N���m�F
            If GF_GetAppInfo("LANE_FLG") = "3" Then
                strLaneLink = GF_GetAppInfo("LANE_PATH")
                If System.IO.File.Exists(Trim$(strLaneLink)) = False Then
                    Call GF_Msg("", "�������[���A�g�v���O���������o���邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
            ' --- (2019.02.05) ���[�v�V�X�e���������[���A�g --------------

            '------------------------------
            ' �e�[�u���̏������������s��
            '------------------------------
            If GF_GetAppInfo("DellTableMSG") = 1 Then
                If GF_Msg("", "�����f�[�^���������܂����H", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    If Not LF_TableInit() Then
                        GoTo SYSTEM_ERROR
                    End If
                End If
            Else
                'If Not LF_TableInit() Then
                tableInitError = LF_TableInit()
                If tableInitError <> "" Then
                    Call GF_Msg("", "�f�[�^�������Ɏ��s���܂���" & Environment.NewLine & tableInitError, MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                    GoTo SYSTEM_ERROR
                End If
            End If
            '------------------------------
            ' 2015.9.29 OA) TEC�f�[�^�捞 �t���O�t�@�C���폜
            '------------------------------
            If (GF_GetAppInfo("SYS_TYPE") = 2 And GF_GetAppInfo("OES_TOOL_VER") = 0 And GF_GetAppInfo("OES_TOOL_VER_CNL1501") = 0) Then
                Try
                    strFlgTecDataImportPath = GF_GetAppInfo("AP_PATH") & "\" & "flg_tec_data_import"
                    If System.IO.File.Exists(strFlgTecDataImportPath) Then
                        System.IO.File.Delete(strFlgTecDataImportPath)
                        DirectCast(MdiParent, CNL2010).btn_menu11.Font = New Font("�l�r �S�V�b�N", 10)
                        DirectCast(MdiParent, CNL2010).btn_menu11.Text = "�e��ݒ�" & vbCrLf & "��TEC�f�[�^�捞�����{"
                    End If
                Catch
                    GF_Msg("", "TEC�f�[�^�捞�t���O�t�@�C���̍폜�Ɏ��s���܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                End Try
            End If

            ' --- (2018.12.20) ���}���[���A�g --------------
            'Call LS_ChgLine(strStnLink, strSonetLink, strTagRWLink, strGameLink, strTicketLink, strStnLink_B, strSmaregiLink)
            Call LS_ChgLine(strStnLink, strSonetLink, strTagRWLink, strGameLink, strTicketLink, strStnLink_B, strSmaregiLink, strLaneLink)
            ' --- (2018.12.20) ���}���[���A�g --------------
            Call LS_SetStatus()
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Start_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�Ɩ��X�e�[�^�X�ؑ֏���
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_ChgLine(Optional ByVal pStnLink As String = "", Optional ByVal pSonetLink As String = "", Optional ByVal pTagRWLink As String = "", Optional ByVal pGameLink As String = "", Optional ByVal pTicketLink As String = "", Optional ByVal pStnLink_B As String = "", Optional ByVal pSmaregiLink As String = "", Optional ByVal pLaneLink As String = "")

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^�X�V
        '------------------------------
        'If Not GF_BeginTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        If Not LF_UpdTPM040_3() Then
            GoTo SYSTEM_ERROR
        End If

        DirectCast(MdiParent, CNL2010).btn_menu01.BackColor = Color.LightSkyBlue
        DirectCast(MdiParent, CNL2010).btn_menu10.BackColor = Color.Violet

        'If Not GF_CommitTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        '------------------------------
        ' Shell���s
        '------------------------------
        If Len(Trim$(pSonetLink)) <> 0 Then
            Shell(Trim$(pSonetLink), AppWinStyle.Hide)
        End If

        If Len(Trim$(pStnLink)) <> 0 Then
            Shell(Trim$(pStnLink), AppWinStyle.Hide)
        End If

        If Len(Trim$(pTagRWLink)) <> 0 Then
            Shell(Trim$(pTagRWLink), AppWinStyle.Hide)
        End If

        If Len(Trim$(pGameLink)) <> 0 Then
            Shell(Trim$(pGameLink), AppWinStyle.Hide)
        End If

        If Len(Trim$(pTicketLink)) <> 0 Then
            Shell(Trim$(pTicketLink), AppWinStyle.Hide)
        End If

        If Len(Trim$(pStnLink_B)) <> 0 Then
            Shell(Trim$(pStnLink_B), AppWinStyle.Hide)
        End If

        If Len(Trim$(pSmaregiLink)) <> 0 Then
            Shell(Trim$(pSmaregiLink), AppWinStyle.Hide)
        End If

        If Len(Trim$(pLaneLink)) <> 0 Then
            Shell(Trim$(pLaneLink), AppWinStyle.Hide)
        End If

        '------------------------------
        ' �{�^���g�p�ېݒ�
        '------------------------------
        btn_Start.Enabled = False

        Exit Sub

SYSTEM_ERROR:
        'Call GF_RollbackTrans()
        Call GS_ErrorTerm("LS_ChgLine")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�V�X�e���Ǘ��}�X�^ �X�V�����i�R�j - �Ɩ��X�e�[�^�X�ؑ֏���
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM040_3() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM040_3 = False

        '------------------------------
        ' �V�X�e���Ǘ��}�X�^�X�V
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM040"
        strSQL = strSQL & "   SET CLMODE = '" & GC_TRUE & "',"
        strSQL = strSQL & "       UPDID  = '" & GC_UPDID & "',"
        strSQL = strSQL & "       UPDYMD = '" & Now & "'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM040_3 = True

    End Function

    Private Sub CNL2020_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        '------------------------------
        ' �[���@�ғ��m�F�X���b�h�I��
        '------------------------------
        G_Thread.Abort()

    End Sub

    Private Sub LS_ChgMenuID()

        'If Not GF_BeginTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        If Not LF_UpdTPM040_1() Then
            GoTo SYSTEM_ERROR
        End If

        'If Not GF_CommitTrans() Then
        '    GoTo SYSTEM_ERROR
        'End If

        Exit Sub

SYSTEM_ERROR:
        'Call GF_RollbackTrans()
        Call GS_ErrorTerm("LS_ChgMenuID")
    End Sub

    '2016.09.27 �N���X�R�k�� �_�с@

    ' --------------------------------------------------------------------------------
    '  �@�\�T�v�F���Ȕԍ��Ǘ��}�X�^�̑S�Ă̒[����ԃt���O�����ʂ��҂���(���)�̏�Ԃɂ���B
    '  ��    ���F
    '  �� �� �l�F
    ' --------------------------------------------------------------------------------

    'Private Sub UpdateOrderStatus()

    '------------------------------
    ' �����ϐ���`
    '------------------------------
    'Dim strSQL As String
    'Dim strSysType As String

    'strSysType = GF_GetAppInfo("SYS_TYPE")

    '' ���Z�A������̏ꍇ�̂݁AOrderStatus = 2�B����ȊO��1�B
    'If Trim$(strSysType) = "2" Then
    '' ------------------------------
    '' �[���t���O���X�V����
    '' ------------------------------
    '    strSQL = "UPDATE TPM050 SET ORDERSTATUS='2', "
    'ElseIf GF_GetAppInfo("TPG_FLG") = "1" Then
    '    strSQL = "UPDATE TPM050 SET ORDERSTATUS='2', "
    'Else
    '    strSQL = "UPDATE TPM050 SET ORDERSTATUS='1', "
    'End If

    'strSQL = strSQL & "    SPMENU     = '000',"
    'strSQL = strSQL & "    SPMENU2    = '000',"
    'strSQL = strSQL & "    HISTORYFLG = '0'"

    'If GF_GetAppInfo("NO_REGTYPE") <> "00" Then
    '    strSQL = strSQL & " WHERE TERMKIND <> '" & GF_GetAppInfo("NO_REGTYPE") & "'"
    'End If

    'If Not GF_UpdCmtData(strSQL) Then
    '    Exit Sub
    'End If

    ' --------------------------------------------------------------------------------
    '  �@�\�T�v�F���Ȕԍ��Ǘ��}�X�^�̑S�Ă̒[����ԃt���O�����ʂ��҂���(���)�܂��͎g�p���̏�Ԃɂ���B
    '  ��    ���F
    '  �� �� �l�F
    ' --------------------------------------------------------------------------------
    Private Sub UpdateOrderStatus()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim strSysType As String
        Dim strSobaFlg As String

        strSobaFlg = GF_GetAppInfo3("SOBA_FLG")

        strSysType = GF_GetAppInfo("SYS_TYPE")

        ' ���Z�A������܂��͂��ʂ��p�l������̏ꍇ�AOrderStatus = 2�B����ȊO��1�B
        If Trim$(strSysType) = "2" Or GF_GetAppInfo("TPG_FLG") = "1" Then

            strSQL = "UPDATE TPM050 SET ORDERSTATUS='2', "

            '��������p�t���O���L���̏ꍇ�AOrderStatus= 1�B
            If strSobaFlg = "1" Then
                strSQL = "UPDATE TPM050 SET ORDERSTATUS='1', "
                '�S�Ă̒[���̂��ʂ��R�[�h���s
                For SEATID As Integer = 1 To 97
                    LF_SetSQLTPD010(SEATID)
                Next
                For SEATID As Integer = 98 To 99
                    LF_SetSQLTPD010(SEATID)
                Next
            End If
        Else
            strSQL = "UPDATE TPM050 SET ORDERSTATUS='1', "
        End If

        strSQL = strSQL & "    SPMENU     = '000',"
        strSQL = strSQL & "    SPMENU2    = '000',"
        strSQL = strSQL & "    HISTORYFLG = '0'"

        If GF_GetAppInfo("NO_REGTYPE") <> "00" Then
            'strSQL = strSQL & " WHERE TERMKIND <> '" & GF_GetAppInfo("NO_REGTYPE") & "'"
            strSQL = strSQL & " WHERE TERMKIND NOT IN ('" & GF_GetAppInfo("NO_REGTYPE") & "', 'TCQ', 'TCV')"
        Else
            strSQL = strSQL & " WHERE TERMKIND NOT IN ('TCQ', 'TCV')"
        End If

        If Not GF_UpdCmtData(strSQL) Then
            Exit Sub
        End If

        '2016.09.27 �N���X�R�k�� �_��

        '------------------------------
        ' �z�ȋ@�\�g�p���ł���Δz�ȊǗ��}�X�^����������
        '------------------------------
        If GF_GetAppInfo("SEAT_DISTRIBUTION") = "0" Then
            Call UpdateTPM051()
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�FFScompass�ڑ��X���b�h��`
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_SqlConnection()

        Dim da As New DataAccess

        Try
            '-----------------------------
            'FScompas�����ڑ�
            '-----------------------------
            ' �f�[�^�x�[�X�ڑ��J�n����
            da.CleateSqlConnection(Trim$(GF_GetAppInfo("OES_CONNECT_STR")))
        Catch
            GF_Msg("", "POS�f�[�^(FUMENU)�̐ڑ��Ɏ��s���܂����B" & vbCrLf & "�ݒ���������Ă��������B", MsgBoxStyle.OkOnly)
            Exit Sub
        Finally
            ' �f�[�^�x�[�X�ؒf����
            da.CloseConnection()
        End Try

        Exit Sub

    End Sub

    Private Sub btn_UpdFUMENU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_UpdFUMENU.Click

        CNL2010.Enabled = False
        Me.Enabled = False

        '' �r�s�m�f�[�^�o�͏���
        If Trim$(GF_GetAppInfo("SYS_TYPE")) = "2" Or Trim$(GF_GetAppInfo("SYS_TYPE")) = "3" Then

            ' FScompass�̏ꍇ
            '--- MC_FSCP�X�V
            If GF_PutFSCPData_DB() = False Then
                GF_Msg("", "POS�f�[�^(FSCP)�̍X�V�Ɏ��s���܂����B" & vbCrLf & "�ݒ���������Ă��������B", MsgBoxStyle.OkOnly)
                CNL2010.Enabled = True
                Me.Enabled = True
                Exit Sub
            End If

            '--- MC_FUMENU�X�V
            If GF_PutFUMENUData_DB() = False Then
                GF_Msg("", "POS�f�[�^(FUMENU)�̍X�V�Ɏ��s���܂����B" & vbCrLf & "�ݒ���������Ă��������B", MsgBoxStyle.OkOnly)
                CNL2010.Enabled = True
                Me.Enabled = True
                Exit Sub
            End If
        End If
        'End If
        GF_Msg("", "POS�f�[�^�X�V���������܂���")

        CNL2010.Enabled = True
        Me.Enabled = True

    End Sub

    ' --------------------------------------------------------------------------------
    '  �@�\�T�v�FTPD510��Truncate�����TPD020�̃J�����FD1�`D10������������B
    '  ��    ���F
    '  �� �� �l�F
    ' --------------------------------------------------------------------------------
    Private Sub UpdateGameTable()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' TPD510 Truncate����
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "TRUNCATE TABLE TPD510"

        If Not GF_UpdCmtData(strSQL) Then
            Call GF_RollbackTrans()
            Exit Sub
        End If

        '------------------------------
        ' TPD050 �J�����FD1�`D10�̏���������
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPD050"
        strSQL = strSQL & "   SET D1  = '0',"
        strSQL = strSQL & "       D2  = '0',"
        strSQL = strSQL & "       D3  = '0',"
        strSQL = strSQL & "       D4  = '0',"
        strSQL = strSQL & "       D5  = '0',"
        strSQL = strSQL & "       D6  = '0',"
        strSQL = strSQL & "       D7  = '0',"
        strSQL = strSQL & "       D8  = '0',"
        strSQL = strSQL & "       D9  = '0',"
        strSQL = strSQL & "       D10 = '0'"

        If Not GF_UpdCmtData(strSQL) Then
            Exit Sub
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    '  �@�\�T�v�F�z�ȊǗ��}�X�^�̔z�Ȓ[���̉��z�[������ID������������
    '  ��    ���F
    '  �� �� �l�F
    ' --------------------------------------------------------------------------------
    Private Sub UpdateTPM051()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM051"
        strSQL = strSQL & "   SET VIRTUALTERMID = ' ',"
        strSQL = strSQL & "       UPDID         = 'CNL2020',"
        strSQL = strSQL & "       UPDYMD        = '" & Now & "'"
        '�Œ�ȂŊJ�ǂƍ��Ȑݒ蓯���ɍs���ꍇ�A�Œ�Ȃ̉��z�[������ID�̓N���A���Ȃ�
        If GF_GetAppInfo2("FIXED_SEAT_OPENFLG") = "0" Then
            strSQL = strSQL & " WHERE SEATFLG       = 'D'"
        End If

        If Not GF_UpdCmtData(strSQL) Then
            Exit Sub
        End If
    End Sub
    '2016.09.28 �N���X�R�k�� �_��
    ' --------------------------------------------------------------------------------
    '  �@�\�T�v�F�S�Ă̐Ȃ�TPD090��GOODSCD�����ʂ��R�[�h(9902)�œo�^����B
    '  ��    ���FSEATID
    '  �� �� �l�F
    ' --------------------------------------------------------------------------------

    Private Sub LF_SetSQLTPD010(ByVal SEATID As String)

        Dim strSQL As String
        Dim datNow As Date
        Dim OrderNo As Long
        Dim TERMID As String

        datNow = Now
        OrderNo = LF_GetOrderNo(SEATID)
        TERMID = LF_GetTermID(SEATID)
        If Not (TERMID = "") Then

            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPD010 VALUES("
            strSQL = strSQL & "'" & RSet(SEATID, 5) & "', "                                 '���Ȕԍ�
            strSQL = strSQL & OrderNo & ", "                                                '�I�[�_�[�A��
            strSQL = strSQL & "'" & TERMID & "', "                                          '�[������ID
            strSQL = strSQL & "9902, "                                                      '���iID
            strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                          '���i�I�����
            strSQL = strSQL & "0, "                                                         '������t����
            strSQL = strSQL & "0, "                                                         '�X�e�[�V�����z�M����
            strSQL = strSQL & "0, "                                                         '����
            strSQL = strSQL & "'00', "                                                      '�w���X�e�[�^�X�ʒu�P
            strSQL = strSQL & "'000', "                                                     'SCP���ނP
            strSQL = strSQL & "'0000', "                                                    'SCP�ƭ��P
            strSQL = strSQL & "0, "                                                         'SCP���ʂP
            strSQL = strSQL & "'00', "                                                      '�w���X�e�[�^�X�ʒu�Q
            strSQL = strSQL & "'000', "                                                     'SCP���ނQ
            strSQL = strSQL & "'0000', "                                                    'SCP�ƭ��Q
            strSQL = strSQL & "0, "                                                         'SCP���ʂQ
            strSQL = strSQL & "'00', "                                                      '�w���X�e�[�^�X�ʒu�R
            strSQL = strSQL & "'000', "                                                     'SCP���ނR
            strSQL = strSQL & "'0000', "                                                    'SCP�ƭ��R
            strSQL = strSQL & "0, "                                                         'SCP���ʂR
            strSQL = strSQL & "'00', "                                                      '�w���X�e�[�^�X�ʒu�S
            strSQL = strSQL & "'000', "                                                     'SCP���ނS
            strSQL = strSQL & "'0000', "                                                    'SCP�ƭ��S
            strSQL = strSQL & "0, "                                                         'SCP���ʂS
            strSQL = strSQL & "'0', "                                                       '�I�[�_�[���
            strSQL = strSQL & "'0', "                                                       '���i����
            strSQL = strSQL & "'00', "                                                      '�����t���O
            strSQL = strSQL & "'000.000.000.000', "                                         '�~�[�[������ID
            strSQL = strSQL & "0, "                                                         '���ʂ��l��
            strSQL = strSQL & "'CNWG001', "                                                 '�X�V��
            strSQL = strSQL & "GETDATE())"                                                  '�X�V��

            If Not GF_UpdCmtData(strSQL) Then
                Exit Sub
            End If
        End If

    End Sub

    '2016.09.28 �N���X�R�k�� �_��
    ' --------------------------------------------------------------------------------
    '  �@�\�T�v�F�I�[�_�[�A�Ԃ��擾����B
    '  ��    ���FSEATID
    '  �� �� �l�FOrderNo
    ' --------------------------------------------------------------------------------

    Private Function LF_GetOrderNo(ByVal strSEATID As String) As Long
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetOrderNo = 0

        strSQL = ""
        strSQL = strSQL & "SELECT ORDERNO"
        strSQL = strSQL & "  FROM TPD010"
        strSQL = strSQL & " WHERE SEATID ='" & RSet(strSEATID, 5) & "'"
        strSQL = strSQL & " ORDER BY SELECTTIME DESC"

        If Not GF_GetData(strSQL, objData) Then
            'Response.Redirect("./TP2990.html?CNWT040(LF_GetOrderNo_1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, objRow) Then
            'Response.Redirect("./TP2990.html?CNWT040(LF_GetOrderNo_3)")
            Exit Function
        End If

        LF_GetOrderNo = CLng(objRow("ORDERNO")) + 1
    End Function
    '2016.09.28 �N���X�R�k�� �_��
    ' --------------------------------------------------------------------------------
    '  �@�\�T�v�FTermID���擾����B
    '  ��    ���FSEATID
    '  �� �� �l�FTermID
    ' --------------------------------------------------------------------------------

    Private Function LF_GetTermID(ByVal SEATID As String) As String
        Dim strSQL As String        '' SQL���s������
        Dim objDataSet As DataSet   '' DataSet�I�u�W�F�N�g
        Dim objDataRow As DataRow = Nothing   '' DataRow�I�u�W�F�N�g

        LF_GetTermID = ""

        strSQL = ""
        strSQL = strSQL & "SELECT TERMID"
        strSQL = strSQL & " FROM TPM050"
        strSQL = strSQL & " WHERE SEATID = '" & RSet(SEATID, 5) & "'"
        strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCA'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCB') "
        strSQL = strSQL & " ORDER BY TERMID"

        objDataSet = New DataSet()

        If Not GF_GetData(strSQL, objDataSet) Then
            'Response.Redirect("./TP2990.html?CNWT040(LF_GetTermID-1)")
            Exit Function
        End If

        If objDataSet.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not GF_GetRows(objDataSet, 0, objDataRow) Then
            'Response.Redirect("./TP2990.html?CNWT040(LF_GetTermID-2)")
            Exit Function
        End If

        LF_GetTermID = Trim$(objDataRow("TERMID"))
    End Function
    '2016.09.28 �N���X�R�k�� �_��

    ''' <summary>
    ''' �X�}���W - ���j���[�}�X�^�X�V
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_SMAREGI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SMAREGI.Click

        CNL2010.Enabled = False
        Me.Enabled = False

        _�X�}���W�A�g�����X�V��� = Nothing         '������
        _�X�}���W�A�g�����X�V���.Initialize()

        '--------------------------------------
        '  �X�}���W�������Ǎ�
        '--------------------------------------
        Dim smaregiStatusValue As String = ""
        Dim smaregiProductText As String = ""
        Dim smaregiProduct As Json.transactionGetDataMain_Product = Nothing

        Call UpdSmaregiProductData(smaregiProductText, smaregiProduct)

        '��������
        If _�X�}���W�A�g�����X�V���.HTTP�X�e�[�^�X <> HTTP_OK Then
            GF_Msg("", "�y�X�}���W�zPOS�f�[�^�̍X�V�Ɏ��s���܂���" & vbCrLf & "�y�G���[���z" & vbCrLf & "�@�G���[�R�[�h �F " & _�X�}���W�A�g�����X�V���.�捞�G���[�R�[�h & vbCrLf & "�@�G���[���e �F " & _�X�}���W�A�g�����X�V���.�捞�G���[���e & vbCrLf & "�@�G���[�ڍ� �F " & _�X�}���W�A�g�����X�V���.�捞�G���[�ڍ�, MsgBoxStyle.OkOnly)
            CNL2010.Enabled = True
            Me.Enabled = True
        Else
            GF_Msg("", "�y�X�}���W�zPOS�f�[�^�X�V����" & vbCrLf & "�y�X�V���� �F " & _�X�}���W�A�g�����X�V���.�捞���팏�� & "���z", MsgBoxStyle.OkOnly)
            CNL2010.Enabled = True
            Me.Enabled = True
        End If

    End Sub

    ''' <summary>
    ''' �X�}���W���i�����X�V����i���i(Product)�A���i���i�iProductPrice�j�j
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdSmaregiProductData(ByRef smaregiPriceText As String, ByRef smaregiPrice As Json.transactionGetDataMain_Product)

        Dim smaregiRef As Json.SmaregiRefParamsJson = Nothing
        Dim smaregiRefRows As Json.SmaregiRefParamsJsonRows = Nothing
        Dim smaregiRefRowsPrice As Json.SmaregiRefParamsJsonRowsPrice = Nothing
        Dim jq As New System.ServiceModel.Dispatcher.JsonQueryStringConverter
        Dim lngLoopCnt As Long = 0        ' --- (2022.11.02) �X�}���W���i�}�X�^�o�^��������P�p���C

        '���w�b�_�[�擾
        Dim getHeader As String = ""
        Dim statusValueHeader As String = ""

        '�p�����[�^�ݒ�
        smaregiRef = New Json.SmaregiRefParamsJson
        smaregiRefRows = New Json.SmaregiRefParamsJsonRows
        smaregiRefRowsPrice = New Json.SmaregiRefParamsJsonRowsPrice

        ' --- (2022.11.02) �X�}���W���i�}�X�^�o�^��������P�p���C --------------
        '�}�X�^�o�^������500�Ŋ������l�i�؂�グ�j�Ԃ񃋁[�v����
        lngLoopCnt = Math.Ceiling(LF_GetTPM010CNT() / 500)

        For i As Integer = 0 To lngLoopCnt - 1
            '���i�e�[�u��
            With smaregiRefRows

                '�e�[�u������
                .table_name = "Product"

            End With

            '���i���i�e�[�u��
            With smaregiRefRowsPrice

                '�e�[�u������
                .table_name = "ProductPrice"

            End With

            '�S��
            With smaregiRef

                '�����敪
                Dim proc_info_proc_division As New Json.proc_info_proc_division
                proc_info_proc_division.proc_division = "U"
                .proc_info.Add(proc_info_proc_division)

            End With

            getHeader = UpdSmaregiInfo(smaregiRef, smaregiRefRows, smaregiRefRowsPrice, statusValueHeader, i)

            '��������
            If statusValueHeader <> HTTP_OK Then
                _�X�}���W�A�g�����X�V���.HTTP�X�e�[�^�X = statusValueHeader
                Exit Sub
            End If

            '�ԋp�p�f�[�^�ɐݒ�(������EJSON����l)
            getHeader = getHeader.Replace("""result"":", """result"":[")
            getHeader = getHeader.Replace("}}", "}]}")
            smaregiPriceText = getHeader
            smaregiPrice = DirectCast(jq.ConvertStringToValue(getHeader, _
                                                              GetType(Json.transactionGetDataMain_Product)),  _
                                                              Json.transactionGetDataMain_Product)

            _�X�}���W�A�g�����X�V���.�捞���팏�� += CLng(smaregiPrice.result(0).Product)
        Next

        'If LF_GetTPM010CNT() > 500 Then
        '    '���i�e�[�u��
        '    With smaregiRefRows

        '        '�e�[�u������
        '        .table_name = "Product"

        '    End With

        '    '���i���i�e�[�u��
        '    With smaregiRefRowsPrice

        '        '�e�[�u������
        '        .table_name = "ProductPrice"

        '    End With

        '    '�S��
        '    With smaregiRef

        '        '�����敪
        '        Dim proc_info_proc_division As New Json.proc_info_proc_division
        '        proc_info_proc_division.proc_division = "U"
        '        .proc_info.Add(proc_info_proc_division)

        '    End With

        '    getHeader = UpdSmaregiInfo(smaregiRef, smaregiRefRows, smaregiRefRowsPrice, statusValueHeader, 1)

        '    '��������
        '    If statusValueHeader <> HTTP_OK Then
        '        _�X�}���W�A�g�����X�V���.HTTP�X�e�[�^�X = statusValueHeader
        '        Exit Sub
        '    End If

        '    '�ԋp�p�f�[�^�ɐݒ�(������EJSON����l)
        '    getHeader = getHeader.Replace("""result"":", """result"":[")
        '    getHeader = getHeader.Replace("}}", "}]}")
        '    smaregiPriceText = getHeader
        '    smaregiPrice = DirectCast(jq.ConvertStringToValue(getHeader, _
        '                                                      GetType(Json.transactionGetDataMain_Product)),  _
        '                                                      Json.transactionGetDataMain_Product)

        '    _�X�}���W�A�g�����X�V���.�捞���팏�� += CLng(smaregiPrice.result(0).Product)
        'End If
        ' --- (2022.11.02) �X�}���W���i�}�X�^�o�^��������P�p���C --------------

        '����ɐݒ�
        _�X�}���W�A�g�����X�V���.HTTP�X�e�[�^�X = HTTP_OK

    End Sub

    ''' <summary>
    ''' �X�}���W�̍X�V���ʏ����擾���A������̏�Ԃŕԋp����
    ''' </summary>
    ''' <param name="smaregiRef"></param>
    ''' <param name="smaregiRefRows"></param>
    ''' <param name="smaregiRefRowsPrice"></param>
    ''' <param name="statusValue"></param>
    ''' <param name="cnt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function UpdSmaregiInfo(ByVal smaregiRef As Json.SmaregiRefParamsJson, ByVal smaregiRefRows As Json.SmaregiRefParamsJsonRows, _
                                    ByVal smaregiRefRowsPrice As Json.SmaregiRefParamsJsonRowsPrice, ByRef statusValue As String, Optional ByVal cnt As Integer = 0) As String

        Dim result As String = ""
        Dim dtsData As New DataSet()
        Dim dtsRow As DataRow = Nothing
        Dim startCnt As Long = 0
        Dim RowsStr As String = ""
        Dim RowsStrPrice As String = ""
        Dim param As String = ""
        Dim paramPrice As String = ""
        Dim dataParam As String = ""
        Dim dataParamPrice As String = ""
        Dim endCnt As Long = 0
        Dim storeId As String = ""
        Dim OpenItem() As String
        Dim OpenItemFrom As String
        Dim OpenItemTo As String
        Dim SalesTax As String
        Dim ReducedTaxRate As String
        Dim compareCnt As Long = 0        ' --- (2022.11.02) �X�}���W���i�}�X�^�o�^��������P�p���C

        Try
            storeId = Trim$(GF_GetAppInfo("SMAREGI_STOREID"))

            '�I�[�v���P�����i�R�[�h�擾
            OpenItem = Trim$(GF_GetAppInfo("OPENITEM")).Split("/")
            OpenItemFrom = OpenItem(0)
            OpenItemTo = OpenItem(1)

            '�ŋ敪�擾
            SalesTax = Trim$(GF_GetAppInfo("SALES_TAX_SWITCHING"))

            '�y���ŗ��K�p�敪
            ReducedTaxRate = Trim$(GF_GetAppInfo("TEC_REDUCED_TAX_RATE"))

            '�p�����[�^��JSON�`���ɕϊ�
            Dim jq As New System.ServiceModel.Dispatcher.JsonQueryStringConverter

            If LF_GetTPM010(dtsData) Then

                '------------------------------
                '���i�f�[�^��(�s)
                '------------------------------
                '���iID
                Dim rows_productId As New Json.rows_productId
                '����ID
                Dim rows_categoryId As New Json.rows_categoryId
                '���i�R�[�h
                Dim rows_productCode As New Json.rows_productCode
                '���i��
                Dim rows_productName As New Json.rows_productName
                '�ŋ敪
                Dim rows_taxDivision As New Json.rows_taxDivision
                '���i���i�敪
                Dim rows_productPriceDivision As New Json.rows_productPriceDivision
                '���i�P��
                Dim rows_price As New Json.rows_price
                '����̐Őݒ�g�p�L��
                Dim rows_useCategoryReduceTax As New Json.rows_useCategoryReduceTax
                '�y���ŗ�ID
                Dim rows_reduceTaxId As New Json.rows_reduceTaxId

                '------------------------------
                '���i���i�f�[�^��(�s)
                '------------------------------
                '���iID
                Dim rowsPrice_productId As New Json.rowsPrice_productId
                '�X��ID
                Dim rowsPrice_storeId As New Json.rowsPrice_storeId
                '���i�敪
                Dim rowsPrice_priceDivision As New Json.rowsPrice_priceDivision
                '�K�p�J�n��
                Dim rowsPrice_startDate As New Json.rowsPrice_startDate
                '���i�P��
                Dim rowsPrice_price As New Json.rowsPrice_price

                ' --- (2022.11.02) �X�}���W���i�}�X�^�o�^��������P�p���C --------------
                startCnt = 500 * cnt
                compareCnt = 500 + (500 * cnt)

                If dtsData.Tables("com").Rows.Count > compareCnt Then
                    endCnt = compareCnt
                Else
                    endCnt = dtsData.Tables("com").Rows.Count
                End If

                'If cnt = 0 Then
                '    If dtsData.Tables("com").Rows.Count > 500 Then
                '        endCnt = 500
                '    Else
                '        endCnt = dtsData.Tables("com").Rows.Count
                '    End If
                'Else
                '    startCnt = 500
                '    If dtsData.Tables("com").Rows.Count > 1000 Then
                '        endCnt = 1000
                '    Else
                '        endCnt = dtsData.Tables("com").Rows.Count
                '    End If
                'End If
                ' --- (2022.11.02) �X�}���W���i�}�X�^�o�^��������P�p���C --------------

                While startCnt < endCnt

                    If Not GF_GetRows(dtsData, startCnt, dtsRow) Then
                        'GoTo SYSTEM_ERROR
                    End If

                    'Rows���N���A
                    smaregiRefRows.rows.Clear()
                    smaregiRefRowsPrice.rows.Clear()

                    With smaregiRefRows

                        '�f�[�^��(�s - ���iID)
                        rows_productId.productId = Trim$(CLng(dtsRow("GOODSCD")))
                        .rows.Add(rows_productId)

                        '�f�[�^��(�s - ����ID)
                        rows_categoryId.categoryId = Trim$(dtsRow("BUMONCD"))
                        .rows.Add(rows_categoryId)

                        '�f�[�^��(�s - ���i�R�[�h)
                        rows_productCode.productCode = Trim$(dtsRow("GOODSCD"))
                        .rows.Add(rows_productCode)

                        '�f�[�^��(�s - ���i��)
                        rows_productName.productName = Trim$(dtsRow("GOODSNMJ")) & Trim$(dtsRow("GOODSNMJ2"))
                        .rows.Add(rows_productName)

                        '�f�[�^��(�s - �ŋ敪)
                        If SalesTax = "0" Then
                            '����
                            rows_taxDivision.taxDivision = "0"
                        ElseIf SalesTax = "1" Then
                            '����
                            rows_taxDivision.taxDivision = "1"
                        Else
                            Throw New Exception()
                        End If
                        .rows.Add(rows_taxDivision)

                        '�f�[�^��(�s - ���i���i�敪)
                        If Trim$(dtsRow("GOODSCD")) >= OpenItemFrom And Trim$(dtsRow("GOODSCD")) <= OpenItemTo Then
                            rows_productPriceDivision.productPriceDivision = "2"
                        Else
                            rows_productPriceDivision.productPriceDivision = "1"
                        End If
                        .rows.Add(rows_productPriceDivision)

                        '�f�[�^��(�s - ���i�P��)
                        If SalesTax = "1" Then
                            rows_price.price = Trim$(dtsRow("PRICE"))
                        ElseIf Trim$(dtsRow("TAXTYPE")) = "1" And ReducedTaxRate = "1" Then
                            rows_price.price = Trim$(dtsRow("PRICE_RED"))
                        Else
                            rows_price.price = Trim$(dtsRow("TAXPRICE"))
                        End If
                        .rows.Add(rows_price)

                        '�f�[�^��(�s - ����̐Őݒ�g�p�L��)
                        rows_useCategoryReduceTax.useCategoryReduceTax = "0"
                        .rows.Add(rows_useCategoryReduceTax)

                        '�f�[�^��(�s - �y���ŗ�ID)
                        If ReducedTaxRate = "1" Then
                            If Trim$(dtsRow("TAXTYPE")) = "0" Then
                                rows_reduceTaxId.reduceTaxId = ""
                            ElseIf Trim$(dtsRow("TAXTYPE")) = "1" Then
                                rows_reduceTaxId.reduceTaxId = "10000001"
                            Else
                                rows_reduceTaxId.reduceTaxId = ""
                            End If
                        ElseIf ReducedTaxRate = "0" Then
                            rows_reduceTaxId.reduceTaxId = ""
                        Else
                            Throw New Exception()
                        End If
                        .rows.Add(rows_reduceTaxId)

                    End With

                    'Rows����x�؂藣���āA�����񉻂���
                    For i As Integer = 0 To smaregiRefRows.rows.Count - 1
                        If i > 0 Then
                            RowsStr &= ","
                        End If

                        '�^���Ƃ̕���
                        If TypeOf smaregiRefRows.rows(i) Is Json.rows_productId Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_productId))

                        ElseIf TypeOf smaregiRefRows.rows(i) Is Json.rows_categoryId Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_categoryId))

                        ElseIf TypeOf smaregiRefRows.rows(i) Is Json.rows_productCode Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_productCode))

                        ElseIf TypeOf smaregiRefRows.rows(i) Is Json.rows_taxDivision Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_taxDivision))

                        ElseIf TypeOf smaregiRefRows.rows(i) Is Json.rows_productName Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_productName))

                        ElseIf TypeOf smaregiRefRows.rows(i) Is Json.rows_price Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_price))

                        ElseIf TypeOf smaregiRefRows.rows(i) Is Json.rows_productPriceDivision Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_productPriceDivision))

                        ElseIf TypeOf smaregiRefRows.rows(i) Is Json.rows_useCategoryReduceTax Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_useCategoryReduceTax))

                        ElseIf TypeOf smaregiRefRows.rows(i) Is Json.rows_reduceTaxId Then
                            RowsStr &= jq.ConvertValueToString(smaregiRefRows.rows(i), GetType(Json.rows_reduceTaxId))
                        End If
                    Next

                    '���蕶������菜��
                    RowsStr = RowsStr.Replace("{", "")
                    RowsStr = RowsStr.Replace("}", "")

                    RowsStr = "{" & RowsStr & "}"

                    If dataParam.Length <> 0 Then
                        RowsStr = "," & RowsStr
                    End If

                    dataParam &= RowsStr
                    RowsStr = Nothing

                    With smaregiRefRowsPrice

                        '�f�[�^��(�s - ���iID)
                        rowsPrice_productId.price_productId = Trim$(CLng(dtsRow("GOODSCD")))
                        .rows.Add(rowsPrice_productId)

                        '�f�[�^��(�s - �X��ID)
                        rowsPrice_storeId.Price_storeId = storeId
                        .rows.Add(rowsPrice_storeId)

                        '�f�[�^��(�s - ���i�敪)
                        rowsPrice_priceDivision.Price_priceDivision = "1"
                        .rows.Add(rowsPrice_priceDivision)

                        '�f�[�^��(�s - �^�p�J�n��)
                        rowsPrice_startDate.Price_startDate = Now.ToString("yyyy-MM-dd")
                        .rows.Add(rowsPrice_startDate)

                        '�f�[�^��(�s - ���i�P��)
                        If SalesTax = "1" Then
                            rowsPrice_price.Price_price = Trim$(dtsRow("PRICE"))
                        ElseIf Trim$(dtsRow("TAXTYPE")) = "1" And ReducedTaxRate = "1" Then
                            rowsPrice_price.Price_price = Trim$(dtsRow("PRICE_RED"))
                        Else
                            rowsPrice_price.Price_price = Trim$(dtsRow("TAXPRICE"))
                        End If
                        .rows.Add(rowsPrice_price)

                    End With

                    'Rows���N���A
                    smaregiRefRows.rows.Clear()

                    'Rows����x�؂藣���āA�����񉻂���
                    For i As Integer = 0 To smaregiRefRowsPrice.rows.Count - 1
                        If i > 0 Then
                            RowsStrPrice &= ","
                        End If

                        '�^���Ƃ̕���
                        If TypeOf smaregiRefRowsPrice.rows(i) Is Json.rowsPrice_productId Then
                            RowsStrPrice &= jq.ConvertValueToString(smaregiRefRowsPrice.rows(i), GetType(Json.rowsPrice_productId))

                        ElseIf TypeOf smaregiRefRowsPrice.rows(i) Is Json.rowsPrice_storeId Then
                            RowsStrPrice &= jq.ConvertValueToString(smaregiRefRowsPrice.rows(i), GetType(Json.rowsPrice_storeId))

                        ElseIf TypeOf smaregiRefRowsPrice.rows(i) Is Json.rowsPrice_priceDivision Then
                            RowsStrPrice &= jq.ConvertValueToString(smaregiRefRowsPrice.rows(i), GetType(Json.rowsPrice_priceDivision))

                        ElseIf TypeOf smaregiRefRowsPrice.rows(i) Is Json.rowsPrice_startDate Then
                            RowsStrPrice &= jq.ConvertValueToString(smaregiRefRowsPrice.rows(i), GetType(Json.rowsPrice_startDate))

                        ElseIf TypeOf smaregiRefRowsPrice.rows(i) Is Json.rowsPrice_price Then
                            RowsStrPrice &= jq.ConvertValueToString(smaregiRefRowsPrice.rows(i), GetType(Json.rowsPrice_price))
                        End If
                    Next

                    '���蕶������菜��
                    RowsStrPrice = RowsStrPrice.Replace("{", "")
                    RowsStrPrice = RowsStrPrice.Replace("}", "")

                    RowsStrPrice = "{" & RowsStrPrice & "}"

                    If dataParamPrice.Length <> 0 Then
                        RowsStrPrice = "," & RowsStrPrice
                    End If

                    dataParamPrice &= RowsStrPrice
                    RowsStrPrice = Nothing

                    'Rows���N���A
                    smaregiRefRowsPrice.rows.Clear()

                    startCnt = startCnt + 1
                End While

                '������ϊ����āARows��ݒ肵����
                param = jq.ConvertValueToString(smaregiRefRows, GetType(Json.SmaregiRefParamsJsonRows))
                param = param.Replace("""rows"":[]", """rows"":[" & dataParam & "]")

                paramPrice = jq.ConvertValueToString(smaregiRefRowsPrice, GetType(Json.SmaregiRefParamsJsonRowsPrice))
                paramPrice = paramPrice.Replace("""rows"":[]", """rows"":[" & dataParamPrice & "]")

            End If

            'proc_info����x�؂藣���āA�����񉻂���
            Dim ProcInfoStr As String = ""
            For i As Integer = 0 To smaregiRef.proc_info.Count - 1
                If i > 0 Then
                    ProcInfoStr &= ","
                End If

                '�^���Ƃ̕���
                If TypeOf smaregiRef.proc_info(i) Is Json.proc_info_proc_division Then
                    ProcInfoStr &= jq.ConvertValueToString(smaregiRef.proc_info(i), GetType(Json.proc_info_proc_division))
                End If
            Next

            'proc_info���N���A
            smaregiRef.proc_info.Clear()
            'data���N���A
            smaregiRef.data.Clear()

            '������ϊ����āAdata��ݒ肵����
            Dim param2 As String = jq.ConvertValueToString(smaregiRef, GetType(Json.SmaregiRefParamsJson))
            param2 = param2.Replace("""data"":[]", """data"":[" & param + "," + paramPrice & "]")
            param2 = param2.Replace("""proc_info"":[]", """proc_info"":" & ProcInfoStr)

            '------------------------------
            ' ���N�G�X�g�ݒ�
            '------------------------------
            Dim url As String = Trim$(GF_GetAppInfo("SMAREGI_URL"))
            Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(url)

            With request
                ' ���N�G�X�g�w�b�_�ݒ�
                With .Headers
                    .Add("X_contract_id", Trim$(GF_GetAppInfo("SMAREGI_CONTRACT")))
                    .Add("X_access_token", Trim$(GF_GetAppInfo("SMAREGI_TOKEN")))
                End With
                .Method = "POST"
                .ContentType = "application/x-www-form-urlencoded;charset=UTF-8"
            End With

            Dim post As String = String.Empty
            post &= "proc_name=product_upd&params=" & param2

            Dim post_byte As Byte() = System.Text.Encoding.UTF8.GetBytes(post)
            Dim reqStream As System.IO.Stream = request.GetRequestStream
            With reqStream
                .Write(post_byte, 0, post_byte.Length)
                .Close()
            End With

            '���X�|���X�̏���
            Dim response As System.Net.WebResponse = Nothing
            response = request.GetResponse

            Dim httpResponse As System.Net.HttpWebResponse = CType(response, System.Net.HttpWebResponse)
            statusValue = httpResponse.StatusCode & " " & httpResponse.StatusDescription

            Dim repStream As System.IO.Stream = response.GetResponseStream
            Dim sr As New System.IO.StreamReader(repStream)

            '�擾���������i�[
            Dim json As String = String.Empty
            While sr.Peek >= 0

                json &= sr.ReadLine

            End While

            result = json

        Catch ex As System.Net.WebException
            'HTTP�v���g�R���G���[���ǂ������ׂ�
            If ex.Status = System.Net.WebExceptionStatus.ProtocolError Then
                'HttpWebResponse���擾
                Dim errres As System.Net.HttpWebResponse = _
                    CType(ex.Response, System.Net.HttpWebResponse)
                statusValue = errres.StatusCode & " " & errres.StatusDescription

                '�G���[�ڍׂ��擾����
                Dim repStream As System.IO.Stream = errres.GetResponseStream
                Dim sr As New System.IO.StreamReader(repStream)
                Dim json As String = String.Empty
                While sr.Peek >= 0
                    json &= sr.ReadLine
                End While

                Try
                    Dim jq As New System.ServiceModel.Dispatcher.JsonQueryStringConverter
                    If json <> "" Then
                        Dim errInfo As Json.errorInfo _
                                    = DirectCast(jq.ConvertStringToValue(json, _
                                      GetType(Json.errorInfo)),  _
                                      Json.errorInfo)

                        _�X�}���W�A�g�����X�V���.�捞�G���[�R�[�h = errInfo.error_code
                        _�X�}���W�A�g�����X�V���.�捞�G���[���e = errInfo.errorM
                        _�X�}���W�A�g�����X�V���.�捞�G���[�ڍ� = errInfo.error_description
                    End If

                Catch ex2 As Exception
                    'json�ϊ����s�����ꍇ�A�X�}���W����̃X�e�[�^�X�͎擾�ł��Ȃ������A�Ƃ��āA�ڑ��G���[�Ƃ���
                    statusValue = HTTP_�z��O�G���[
                End Try

            Else
                statusValue = HTTP_�z��O�G���[
            End If
            'Me.Close()

        Catch ex As Exception

            'GoTo SYSTEM_ERROR

            Trace.Write(ex.Message)

            statusValue = HTTP_�z��O�G���[
            'Me.Close()

        End Try

        Return result

        'SYSTEM_ERROR:
        '        Call GS_ErrorTerm("UpdSmaregiInfo")
    End Function

    ''' <summary>
    ''' ���i�}�X�^�ꗗ���擾����
    ''' </summary>
    ''' <param name="pDataSet"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_GetTPM010(ByRef pDataSet As DataSet) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM010 = False

        '------------------------------
        ' ���i�}�X�^�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        strSQL = strSQL & "       TPM010.BUMONCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        strSQL = strSQL & "       TPM010.PRICE,"
        strSQL = strSQL & "       TPM600.TAXTYPE,"
        strSQL = strSQL & "       TPM600.PRICE_RED,"
        strSQL = strSQL & "       TPM260.TAXPRICE"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & "       LEFT JOIN TPM600 ON TPM010.GOODSCD = TPM600.GOODSCD"
        strSQL = strSQL & "       LEFT JOIN TPM260 ON TPM010.GOODSCD = TPM260.GOODSCD"
        strSQL = strSQL & " WHERE CONVERT(decimal,TPM010.GOODSCD) < 9000"
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        pDataSet = dtsData
        LF_GetTPM010 = True

    End Function

    ''' <summary>
    ''' ���i�}�X�^�ꗗ�̌������擾����
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_GetTPM010CNT() As Long

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM010CNT = False

        '------------------------------
        ' ���i�}�X�^�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        strSQL = strSQL & "       TPM010.BUMONCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        strSQL = strSQL & "       ISNULL(TPM320.TAXKIND, '0') AS TAXKIND,"
        strSQL = strSQL & "       TPM010.PRICE"
        strSQL = strSQL & "  FROM TPM010 LEFT JOIN TPM320 ON TPM010.GOODSCD = TPM320.GOODSCD"
        strSQL = strSQL & " WHERE CONVERT(decimal,TPM010.GOODSCD) < 9000"
        strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

        If Not GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        If dtsData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetTPM010CNT = dtsData.Tables("com").Rows.Count

    End Function

    Private Sub btn_btn_OutputGoodsData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OutputGoodsData.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()
        Dim csvPath As String = GF_GetAppInfo("TERAOKA_CSVPATH") & "\" & Now.ToString("yyyyMMddHHmmss") & ".csv"
        Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")

        Try
            '------------------------------
            ' �o�͓��e�擾
            '------------------------------
            strSQL = ""
            strSQL = strSQL & "SELECT TPM010.GOODSCD AS GOODSCD"
            strSQL = strSQL & "       , TPM010.GOODSNMJ AS GOODSNMJ"
            strSQL = strSQL & "       , TPM010.PRICE AS PRICE"
            strSQL = strSQL & "       , '1' AS SUBCATEGORY"
            strSQL = strSQL & "       , '0' AS STOPFLAG"
            strSQL = strSQL & "       , '9' AS TAXCODE"
            strSQL = strSQL & "       , '0' AS TAKEOUTFLG"
            strSQL = strSQL & "  FROM TPM010 "
            strSQL = strSQL & " WHERE CONVERT(INT,TPM010.GOODSCD) < 9000"
            strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

            If Not GF_GetData(strSQL, dtsData) Then
                Exit Sub
            End If

            If dtsData.Tables("com").Rows.Count = 0 Then
                MsgBox("�o�͑Ώۂ̏��i�����݂��܂���")
                Exit Sub
            End If

            '�������ރt�@�C�����J��
            Dim sr As New System.IO.StreamWriter(csvPath, False, enc)

            Dim colCount As Integer = dtsData.Tables("com").Columns.Count
            Dim lastColIndex As Integer = colCount - 1
            Dim i As Integer
            Dim row As DataRow

            For Each row In dtsData.Tables("com").Rows
                For i = 0 To colCount - 1
                    '�t�B�[���h�̎擾
                    Dim field As String = row(i).ToString()
                    '"�ň͂�
                    field = field.Replace("""", """""")
                    '�t�B�[���h����������
                    sr.Write(field)
                    '�J���}����������
                    If lastColIndex > i Then
                        sr.Write(","c)
                    End If
                Next
                '���s����
                sr.Write(vbCrLf)
            Next

            '����
            sr.Close()

            MsgBox("CSV�t�@�C�����o�͂��܂����B" & vbCrLf & csvPath)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    ' --- (2022.09.01) Kiosk�������Z�@�A�g --------------
    Private Sub btn_KioskGoodsData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_KioskGoodsData.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()
        Dim csvPath As String = GF_GetAppInfo2("KIOSK_CSV_PATH")
        Dim enc As System.Text.Encoding = System.Text.Encoding.UTF8

        Try
            '------------------------------
            ' �o�͓��e�擾
            '------------------------------
            strSQL = ""
            strSQL = strSQL & "SELECT LTRIM(RTRIM(TPM010.GOODSCD)) AS GOODSCD"
            strSQL = strSQL & "     , LTRIM(RTRIM(TPM010.GOODSNMJ)) AS GOODSNMJ"
            strSQL = strSQL & "     , LTRIM(RTRIM(TPM260.TAXPRICE)) AS PRICE"
            strSQL = strSQL & "  FROM TPM010 "
            strSQL = strSQL & "     , TPM260 "
            strSQL = strSQL & " WHERE TPM010.GOODSCD = TPM260.GOODSCD"
            strSQL = strSQL & " ORDER BY TPM010.GOODSCD"

            If Not GF_GetData(strSQL, dtsData) Then
                Exit Sub
            End If

            If dtsData.Tables("com").Rows.Count = 0 Then
                MsgBox("�o�͑Ώۂ̏��i�����݂��܂���")
                Exit Sub
            End If

            '�������ރt�@�C�����J��
            Dim sr As New System.IO.StreamWriter(csvPath, False, enc)

            Dim colCount As Integer = dtsData.Tables("com").Columns.Count
            Dim lastColIndex As Integer = colCount - 1
            Dim i As Integer
            Dim row As DataRow

            For Each row In dtsData.Tables("com").Rows
                For i = 0 To colCount - 1
                    '�t�B�[���h�̎擾
                    Dim field As String = row(i).ToString()
                    '�t�B�[���h����������
                    sr.Write(field)
                    '�J���}����������
                    If lastColIndex > i Then
                        sr.Write(","c)
                    End If
                Next
                '���s����
                sr.Write(vbCr)
            Next

            '����
            sr.Close()

            MsgBox("Kiosk�������Z�@ - CSV�t�@�C�����o�͂��܂����B" & vbCrLf & csvPath)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    ' --- (2022.09.01) Kiosk�������Z�@�A�g --------------
End Class
