Public Class CNL1571
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdo_FreeMsg As System.Windows.Forms.RadioButton
    Friend WithEvents lsv_MsgList As System.Windows.Forms.ListView
    Friend WithEvents txt_Msg1 As System.Windows.Forms.TextBox
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents btn_Del As System.Windows.Forms.Button
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_Del = New System.Windows.Forms.Button
        Me.btn_Add = New System.Windows.Forms.Button
        Me.txt_Msg1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lsv_MsgList = New System.Windows.Forms.ListView
        Me.rdo_FreeMsg = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.stb_Msg = New System.Windows.Forms.StatusBar
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_Del)
        Me.Panel1.Controls.Add(Me.btn_Add)
        Me.Panel1.Controls.Add(Me.txt_Msg1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lsv_MsgList)
        Me.Panel1.Controls.Add(Me.rdo_FreeMsg)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 400)
        Me.Panel1.TabIndex = 0
        '
        'btn_Del
        '
        Me.btn_Del.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Del.Location = New System.Drawing.Point(416, 344)
        Me.btn_Del.Name = "btn_Del"
        Me.btn_Del.Size = New System.Drawing.Size(120, 32)
        Me.btn_Del.TabIndex = 11
        Me.btn_Del.Text = "��@�@��"
        '
        'btn_Add
        '
        Me.btn_Add.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Add.Location = New System.Drawing.Point(288, 344)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(120, 32)
        Me.btn_Add.TabIndex = 10
        Me.btn_Add.Text = "�V�K�ǉ�"
        '
        'txt_Msg1
        '
        Me.txt_Msg1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Msg1.Location = New System.Drawing.Point(288, 48)
        Me.txt_Msg1.Name = "txt_Msg1"
        Me.txt_Msg1.Size = New System.Drawing.Size(248, 22)
        Me.txt_Msg1.TabIndex = 5
        Me.txt_Msg1.Text = "�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "�� ���b�Z�[�W�̕�����ҏW���܂�"
        '
        'lsv_MsgList
        '
        Me.lsv_MsgList.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_MsgList.Location = New System.Drawing.Point(40, 96)
        Me.lsv_MsgList.Name = "lsv_MsgList"
        Me.lsv_MsgList.Size = New System.Drawing.Size(200, 280)
        Me.lsv_MsgList.TabIndex = 3
        Me.lsv_MsgList.UseCompatibleStateImageBehavior = False
        Me.lsv_MsgList.View = System.Windows.Forms.View.Details
        '
        'rdo_FreeMsg
        '
        Me.rdo_FreeMsg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_FreeMsg.Location = New System.Drawing.Point(40, 46)
        Me.rdo_FreeMsg.Name = "rdo_FreeMsg"
        Me.rdo_FreeMsg.Size = New System.Drawing.Size(176, 24)
        Me.rdo_FreeMsg.TabIndex = 2
        Me.rdo_FreeMsg.Text = "�C�ӑ��M���b�Z�[�W"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "�� ���b�Z�[�W�̎�ނ�I�����܂�"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4})
        Me.MenuItem1.Text = "�t�@�C��(&F)"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "�ۑ�(&S)"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "�I��(&E)"
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 401)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(576, 24)
        Me.stb_Msg.TabIndex = 2
        Me.stb_Msg.Text = "StatusBar1"
        '
        'CNL1571
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(576, 425)
        Me.Controls.Add(Me.stb_Msg)
        Me.Controls.Add(Me.Panel1)
        Me.Menu = Me.MainMenu1
        Me.Name = "CNL1571"
        Me.Text = "CNL1571"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private L_blnEdit As Boolean

    Private Structure typMsg
        Dim strMsgCD As String
        Dim strMsg As String
    End Structure

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���ǂݍ��ݎ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub CNL1571_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �t�H�[�����̐ݒ�
        '------------------------------
        Me.Text = GF_FormText(" - �q�Ȓ[�����M���b�Z�[�W�ҏW")

        '------------------------------
        ' ����������
        '------------------------------
        Call GS_StatusSetup(stb_Msg)                                        ' �X�e�[�^�X�o�[������

        '------------------------------
        ' ��ʏ�����
        '------------------------------
        Call LS_FormSetup()

        '------------------------------
        ' �g�����U�N�V�����J�n
        '------------------------------
        L_blnEdit = False

        If Not GF_BeginTrans() Then
            GoTo SYSTEM_ERROR
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1571_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���ݒ菈��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_FormSetup()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        txt_Msg1.Clear()
        btn_Add.Enabled = True
        btn_Del.Enabled = True

        '------------------------------
        ' ��ʏ����l�ݒ�
        '------------------------------
        With lsv_MsgList
            .Clear()
            .HeaderStyle = ColumnHeaderStyle.None
            .Columns.Add("���b�Z�[�W���e", 196, HorizontalAlignment.Left)
            .MultiSelect = False
            .HideSelection = False
        End With

        '------------------------------
        ' ���b�Z�[�W���X�g�쐬
        '------------------------------
        Call LS_FreeMsgList()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_FormSetup")
    End Sub

    Private Sub CNL1571_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objRet As MsgBoxResult

        '------------------------------
        ' �X�V�����m�F
        '------------------------------
        If L_blnEdit Then
            objRet = GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNoCancel)
            Select Case objRet
                Case MsgBoxResult.Yes
                    '------------------------------
                    ' �g�����U�N�V�����m��
                    '------------------------------
                    If Not GF_CommitTrans() Then
                        GoTo SYSTEM_ERROR
                    End If

                Case MsgBoxResult.No
                    '------------------------------
                    ' �g�����U�N�V�����j��
                    '------------------------------
                    If Not GF_RollbackTrans() Then
                        GoTo SYSTEM_ERROR
                    End If

                Case MsgBoxResult.Cancel
                    e.Cancel = True
            End Select
        Else
            '------------------------------
            ' �g�����U�N�V�����j��
            '------------------------------
            If Not GF_RollbackTrans() Then
                GoTo SYSTEM_ERROR
            End If
        End If

        Exit Sub

SYSTEM_ERROR:
        '------------------------------
        ' �g�����U�N�V�����j��
        '------------------------------
        Call GF_RollbackTrans()
        Call GS_ErrorTerm("CNL1571_Closing")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���b�Z�[�W���X�g�쐬����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_FreeMsgList()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim objItem As ListViewItem

        '------------------------------
        ' ���b�Z�[�W�ꗗ�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM030.CODEID,"
        strSQL = strSQL & "       TPM030.CODEVAL,"
        strSQL = strSQL & "       TPM030.CODENM"
        strSQL = strSQL & "  FROM TPM030 LEFT JOIN TPM120 ON TPM030.CODEID = TPM120.CODEID AND TPM030.CODEVAL = TPM120.CODEVAL AND TPM120.IMAGECD LIKE 'MA%'"
        strSQL = strSQL & " WHERE TPM030.CODEID  = 'SENDMSG2'"
        strSQL = strSQL & " ORDER BY TPM030.CODEVAL"

        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' ���X�g�{�b�N�X�ݒ�
        '------------------------------
        lsv_MsgList.Items.Clear()
        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                GoTo SYSTEM_ERROR
            End If

            objItem = New ListViewItem()
            With objItem
                .Text = LF_N2S(objRows("CODENM"))
                .SubItems.Add(LF_N2S(objRows("CODEVAL")))
                .SubItems.Add(LF_N2S(objRows("CODENM")))
                .SubItems.Add("")
                .SubItems.Add("")
            End With
            lsv_MsgList.Items.Add(objItem)

            lngCnt = lngCnt + 1
        End While

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_FreeMsgList")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�m�t�k�k�l���菈��
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_N2S(ByVal pObject As Object) As String

        LF_N2S = ""
        If IsDBNull(pObject) Then
            Exit Function
        Else
            LF_N2S = Trim$(pObject)
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���b�Z�[�W���X�g�@�I�����b�Z�[�W�ύX����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub lsv_MsgList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_MsgList.SelectedIndexChanged

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim strNoImgCD(2) As String

        objCollection = lsv_MsgList.SelectedItems
        With objCollection
            If .Count = 0 Then
                Exit Sub
            End If

            If .Contains(.Item(0)) = False Then
                Exit Sub
            End If

            txt_Msg1.Text = RTrim$(.Item(0).SubItems(2).Text)
        End With

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���M���b�Z�[�W�����ύX����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub txt_Msg1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Msg1.TextChanged

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngST As Long
        Dim objCollection As ListView.SelectedListViewItemCollection

        '------------------------------
        ' �C�x���g�������s����
        '------------------------------
        If txt_Msg1.Modified = False Then
            Exit Sub
        End If

        '------------------------------
        ' ���p���͋֎~
        '------------------------------
        lngST = txt_Msg1.SelectionStart
            ' 2014-05-12 2�o�C�g������������
        'txt_Msg1.Text = StrConv(txt_Msg1.Text, VbStrConv.Wide)
        If lngST >= 0 Then
            txt_Msg1.SelectionStart = lngST
        End If

        '------------------------------
        ' ���͒�����
        '------------------------------
        If GF_LenB(txt_Msg1.Text) > 40 Then
            txt_Msg1.Text = GF_MidB(txt_Msg1.Text, 1, 40)
            txt_Msg1.SelectionStart = GF_LenB(txt_Msg1.Text)
            Exit Sub
        End If

        '------------------------------
        ' �X�V����
        '------------------------------
        objCollection = lsv_MsgList.SelectedItems
        With objCollection
            If .Count = 0 Then
                Exit Sub
            End If

            If .Contains(.Item(0)) = False Then
                Exit Sub
            End If

            .Item(0).SubItems(2).Text = Trim$(txt_Msg1.Text)
            .Item(0).SubItems(0).Text = Trim$(txt_Msg1.Text)

            If Not LF_UpdTPM030(Trim$(.Item(0).SubItems(1).Text), RTrim$(.Item(0).SubItems(2).Text)) Then
                GoTo SYSTEM_ERROR
            End If
        End With

        L_blnEdit = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_Msg1_TextChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�s�o�l�O�R�O�X�V����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM030(ByVal pMsgCD As String, ByVal pMsgVal As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim strMsg As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM030 = False

        If Len(Trim$(pMsgVal)) = 0 Then
            strMsg = Space(40)
        Else
            strMsg = pMsgVal
        End If

        '------------------------------
        ' ���b�Z�[�W�}�X�^�X�V
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM030"
        strSQL = strSQL & "   SET CODENM  = '" & GF_RepQuo(strMsg) & "',"
        strSQL = strSQL & "       UPDID   = 'SYSTEM',"
        strSQL = strSQL & "       UPDYMD  = getdate()"
        strSQL = strSQL & " WHERE CODEID  = 'SENDMSG2'"
        strSQL = strSQL & "   AND CODEVAL = '" & pMsgCD & "'"

        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM030 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[ - [�ۑ�]����������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objRet As MsgBoxResult

        '------------------------------
        ' �X�V�����m�F
        '------------------------------
        If L_blnEdit Then
            objRet = GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNoCancel)
            Select Case objRet
                Case MsgBoxResult.Yes
                    If Not GF_CommitTrans() Then                            ' �g�����U�N�V�����m��
                        GoTo SYSTEM_ERROR
                    End If

                Case MsgBoxResult.No
                    If Not GF_RollbackTrans() Then                          ' �g�����U�N�V�����j��
                        GoTo SYSTEM_ERROR
                    End If

            End Select

            If Not GF_BeginTrans() Then
                GoTo SYSTEM_ERROR
            End If
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GF_RollbackTrans()
        Call GS_ErrorTerm("MenuItem2_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[ - [�I��]����������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u�V�K�ǉ��v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click

        If Not LF_InsTPM030() Then
            GoTo SYSTEM_ERROR
        End If

        Call LS_FreeMsgList()

        L_blnEdit = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Add_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�u�폜�v�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Del.Click

        If Not LF_DelTPM030() Then
            GoTo SYSTEM_ERROR
        End If

        Call LS_FreeMsgList()

        L_blnEdit = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Del_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�s�o�l�O�R�O�ǉ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_InsTPM030() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngI As Long
        Dim strNewID As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_InsTPM030 = False

        '------------------------------
        ' �̔ԏ���
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT CODEVAL"
        strSQL = strSQL & "  FROM TPM030"
        strSQL = strSQL & " WHERE CODEID = 'SENDMSG2'"
        strSQL = strSQL & " ORDER BY CODEVAL"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        strNewID = ""
        If objData.Tables("com").Rows.Count = 0 Then
            strNewID = "I00"
        Else
            If Not GF_GetRows(objData, objData.Tables("com").Rows.Count - 1, objRows) Then
                Exit Function
            End If

            If Mid(Trim$(objRows("CODEVAL")), 2) = "99" Then
                ' �󂫔Ԍ�������
                lngI = 0
                While lngI < objData.Tables("com").Rows.Count
                    If Not GF_GetRows(objData, lngI, objRows) Then
                        Exit Function
                    End If
                    If lngI <> CLng(Mid$(Trim$(objRows("CODEVAL")), 2)) Then
                        strNewID = "I" & Format$(lngI, "00")
                        Exit While
                    End If

                    lngI = lngI + 1
                End While

                If Len(Trim$(strNewID)) = 0 Then
                    Call GF_Msg("", "����ȏ�A���b�Z�[�W��ǉ����邱�Ƃ��ł��܂���", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                    LF_InsTPM030 = True
                    Exit Function
                End If
            Else
                strNewID = "I" & Format$(CLng(Mid(Trim$(objRows("CODEVAL")), 2)) + 1, "00")
            End If
        End If

        '------------------------------
        ' �V�K���b�Z�[�W���R�[�h�ǉ�
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM030 VALUES("
        strSQL = strSQL & "       'SENDMSG2',"
        strSQL = strSQL & "       '" & strNewID & "',"
        strSQL = strSQL & "       '�V�K�ǉ����b�Z�[�W',"
        strSQL = strSQL & "       'SYSTEM',"
        strSQL = strSQL & "       getdate())"

        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_InsTPM030 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�s�o�l�O�R�O�폜����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.10.27 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_DelTPM030() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_DelTPM030 = False

        '------------------------------
        ' �C�x���g�������s����
        '------------------------------
        objCollection = lsv_MsgList.SelectedItems
        With objCollection
            If .Count = 0 Then Exit Function
            If .Contains(.Item(0)) = False Then Exit Function
        End With

        '------------------------------
        ' ���b�Z�[�W�}�X�^�폜
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE"
        strSQL = strSQL & "  FROM TPM030"
        strSQL = strSQL & " WHERE TPM030.CODEID  = 'SENDMSG2'"
        strSQL = strSQL & "   AND TPM030.CODEVAL = '" & Trim$(objCollection.Item(0).SubItems(1).Text) & "'"

        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �C���X�g�֘A�t���}�X�^�폜
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE"
        strSQL = strSQL & "  FROM TPM120"
        strSQL = strSQL & " WHERE TPM120.CODEID  = 'SENDMSG2'"
        strSQL = strSQL & "   AND TPM120.CODEVAL = '" & Trim$(objCollection.Item(0).SubItems(1).Text) & "'"

        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_DelTPM030 = True

    End Function
End Class
