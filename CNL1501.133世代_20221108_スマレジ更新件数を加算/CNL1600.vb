' --------------------------------------------------------------------------------
' �@�@�@�@�\�F�X�ܓ����V�X�e�� - �T�[�o�����e�i���X(�o�b�N�A�b�v�^���J�o��)
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------

Public Class CNL1600
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents trv_BKInfo As System.Windows.Forms.TreeView
    Friend WithEvents txt_Comment As System.Windows.Forms.TextBox
    Friend WithEvents tlb_Btn As System.Windows.Forms.ToolBar
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CNL1600))
        Me.stb_Msg = New System.Windows.Forms.StatusBar()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.trv_BKInfo = New System.Windows.Forms.TreeView()
        Me.tlb_Btn = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.txt_Comment = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 667)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(1018, 24)
        Me.stb_Msg.TabIndex = 211
        Me.stb_Msg.Text = "StatusBar1"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'trv_BKInfo
        '
        Me.trv_BKInfo.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.trv_BKInfo.FullRowSelect = True
        Me.trv_BKInfo.ImageList = Me.ImageList1
        Me.trv_BKInfo.Location = New System.Drawing.Point(8, 64)
        Me.trv_BKInfo.Name = "trv_BKInfo"
        Me.trv_BKInfo.Nodes.AddRange(New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("�X�X���X�X���i���j", 2, 2, New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("(13��20��)�@�R�����g�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m�m"), New System.Windows.Forms.TreeNode("(16��35��)"), New System.Windows.Forms.TreeNode("(20��54��)")}), New System.Windows.Forms.TreeNode("�X�X���X�X���i�΁j", 2, 2, New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("#1 (15��40��)"), New System.Windows.Forms.TreeNode("#2 (�ޔ��f�[�^�Ȃ�)", 1, 1), New System.Windows.Forms.TreeNode("#3 (�ޔ��f�[�^�Ȃ�)", 1, 1)}), New System.Windows.Forms.TreeNode("�X�X���X�X���i���j", 2, 2, New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("#1 (99��99��)"), New System.Windows.Forms.TreeNode("#2 (99��99��)"), New System.Windows.Forms.TreeNode("#3 (99��99��)")}), New System.Windows.Forms.TreeNode("�X�X���X�X���i�؁j", 2, 2, New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("�m�[�h16"), New System.Windows.Forms.TreeNode("�m�[�h17"), New System.Windows.Forms.TreeNode("�m�[�h18")}), New System.Windows.Forms.TreeNode("�X�X���X�X���i���j", 2, 2, New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("�m�[�h19"), New System.Windows.Forms.TreeNode("�m�[�h20"), New System.Windows.Forms.TreeNode("�m�[�h21")}), New System.Windows.Forms.TreeNode("�X�X���X�X���i�y�j", 2, 2, New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("�m�[�h22"), New System.Windows.Forms.TreeNode("�m�[�h23"), New System.Windows.Forms.TreeNode("�m�[�h24")}), New System.Windows.Forms.TreeNode("�X�X���X�X���i���j", 2, 2, New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("�m�[�h25"), New System.Windows.Forms.TreeNode("�m�[�h26"), New System.Windows.Forms.TreeNode("�m�[�h27")})})
        Me.trv_BKInfo.Size = New System.Drawing.Size(1000, 592)
        Me.trv_BKInfo.TabIndex = 2
        '
        'tlb_Btn
        '
        Me.tlb_Btn.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2})
        Me.tlb_Btn.ButtonSize = New System.Drawing.Size(150, 51)
        Me.tlb_Btn.Divider = False
        Me.tlb_Btn.Dock = System.Windows.Forms.DockStyle.None
        Me.tlb_Btn.DropDownArrows = True
        Me.tlb_Btn.ImageList = Me.ImageList2
        Me.tlb_Btn.Location = New System.Drawing.Point(8, 8)
        Me.tlb_Btn.Name = "tlb_Btn"
        Me.tlb_Btn.ShowToolTips = True
        Me.tlb_Btn.Size = New System.Drawing.Size(304, 52)
        Me.tlb_Btn.TabIndex = 0
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 0
        Me.ToolBarButton1.Text = "�f�[�^��ޔ�����"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 1
        Me.ToolBarButton2.Text = "�ޔ��f�[�^����A��������"
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'txt_Comment
        '
        Me.txt_Comment.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Comment.Location = New System.Drawing.Point(320, 40)
        Me.txt_Comment.MaxLength = 100
        Me.txt_Comment.Name = "txt_Comment"
        Me.txt_Comment.Size = New System.Drawing.Size(688, 22)
        Me.txt_Comment.TabIndex = 1
        Me.txt_Comment.Text = "TextBox1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(320, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 236
        Me.Label1.Text = "�R�����g"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txt_Comment, Me.Label1, Me.tlb_Btn, Me.trv_BKInfo})
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 237
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
        Me.MenuItem2.Text = "�ޔ�ݒ�(&V)"
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
        'CNL1600
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1018, 691)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel1, Me.stb_Msg})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL1600"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JCV05"
        Me.Panel1.ResumeLayout(False)
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
    Private Sub JCV05_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �t�H�[�����̐ݒ�
        '------------------------------
        Me.Text = GF_FormText("- �o�b�N�A�b�v�E���J�o�����")

        '------------------------------
        ' �t�H�[������������
        '------------------------------
        txt_Comment.Text = ""
        Call GS_StatusSetup(stb_Msg)                                        ' �X�e�[�^�X�o�[������
        trv_BKInfo.HideSelection = False

        '------------------------------
        ' �����\������
        '------------------------------
        Call LS_CreateBKTree()

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�o�b�N�A�b�v�f�[�^�c���[ �\������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_CreateBKTree()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngChildCnt As Long
        Dim objRNode As TreeNode = Nothing
        Dim objCNode As TreeNode = Nothing
        Dim strRootTxt As String
        Dim strChildTxt As String
        Dim objFile As System.IO.StreamReader
        Dim strFileLine As String
        Dim strWork() As String
        Dim intImgIndex As Integer
        Dim strPathAry() As String
        Dim lngCnt As Long
        Dim strSubFlds() As String

        '------------------------------
        ' �c���[�m�[�h�\������
        '------------------------------
        Try
            With trv_BKInfo
                .BeginUpdate()
                .Nodes.Clear()
            End With

            If System.IO.Directory.Exists(g_udtAppConfig.strBKPath) = False Then
                Call GF_Msg("", "�o�b�N�A�b�v�p�X�����݂��Ȃ����A�ݒ�Ɍ�肪����܂��B�o�b�N�A�b�v�E���J�o���������s���܂���B", MsgBoxStyle.OKOnly, MsgBoxStyle.Critical)
                With tlb_Btn
                    .Buttons(0).Enabled = False
                    .Buttons(1).Enabled = False
                End With
                txt_Comment.Enabled = False
                Exit Sub
            End If

            strPathAry = System.IO.Directory.GetDirectories(g_udtAppConfig.strBKPath)
            Array.Sort(strPathAry)
            For lngCnt = UBound(strPathAry) To 0 Step -1
                If System.IO.File.Exists(strPathAry(lngCnt) & "\" & GC_BKLOG_NM) = True Then
                    '------------------------------
                    ' �e�m�[�h�ǉ�
                    '------------------------------
                    objFile = New System.IO.StreamReader(strPathAry(lngCnt) & "\" & GC_BKLOG_NM, System.Text.Encoding.Default)
                    strFileLine = objFile.ReadLine
                    objFile.Close()
                    strWork = Split(strFileLine, vbTab)
            ' 2014-05-12 2�o�C�g������������
                    'strRootTxt = StrConv(Format$(CDate(strWork(0)), "yyyy"), VbStrConv.Wide) & "�N" & _
                    '             StrConv(Format$(CDate(strWork(0)), "MM"), VbStrConv.Wide) & "��" & _
                    '             StrConv(Format$(CDate(strWork(0)), "dd"), VbStrConv.Wide) & "���i" & _
                    '             WeekdayName(Weekday(CDate(strWork(0))), False) & "�j"
                    strRootTxt = Format$(CDate(strWork(0)), "yyyy") & "�N" & _
                                 Format$(CDate(strWork(0)), "MM") & "��" & _
                                 Format$(CDate(strWork(0)), "dd") & "���i" & _
                                 WeekdayName(Weekday(CDate(strWork(0))), False) & "�j"
                    objRNode = trv_BKInfo.Nodes.Add(strRootTxt)                     ' �e�m�[�h��ǉ�
                    With objRNode
                        .ImageIndex = 2
                        .SelectedImageIndex = 2
                        .Tag = ""
                    End With

                    '------------------------------
                    ' �q�m�[�h�ǉ�
                    '------------------------------
                    strSubFlds = System.IO.Directory.GetDirectories(strPathAry(lngCnt))
                    Array.Sort(strSubFlds)
                    For lngChildCnt = UBound(strSubFlds) To 0 Step -1
                        If System.IO.File.Exists(strSubFlds(lngChildCnt) & "\" & GC_BKLOG_NM) = True Then
                            objFile = New System.IO.StreamReader(strSubFlds(lngChildCnt) & "\" & GC_BKLOG_NM, System.Text.Encoding.Default)
                            strFileLine = objFile.ReadLine
                            objFile.Close()
                            strWork = Split(strFileLine, vbTab)
            ' 2014-05-12 2�o�C�g������������
                            'strChildTxt = "�i" & _
                            '              StrConv(Format$(CDate(strWork(0)), "HH"), VbStrConv.Wide) & "��" & _
                            '              StrConv(Format$(CDate(strWork(0)), "mm"), VbStrConv.Wide) & "���j" & _
                            '              Space(4) & strWork(1)
                            strChildTxt = "�i" & _
                                          Format$(CDate(strWork(0)), "HH") & "��" & _
                                          Format$(CDate(strWork(0)), "mm") & "���j" & _
                                          Space(4) & strWork(1)
                            intImgIndex = 0
                            objCNode = objRNode.Nodes.Add(strChildTxt)
                            With objCNode
                                .ImageIndex = intImgIndex
                                .SelectedImageIndex = intImgIndex
                                .Tag = strSubFlds(lngChildCnt)
                            End With
                        End If
                    Next
                End If
            Next

            With trv_BKInfo
                .ExpandAll()
                .EndUpdate()
            End With
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        trv_BKInfo.EndUpdate()
        Call GS_ErrorTerm("LS_CreateBKTree")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�c�[���o�[����������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub tlb_Btn_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlb_Btn.ButtonClick

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objNode As TreeNode = Nothing
        Dim strQMsgID As String ' �J�n�O���b�Z�[�W�h�c
        Dim strSMsgID As String ' ���������b�Z�[�W�h�c
        Dim strEMsgID As String ' �����������b�Z�[�W�h�c

        Select Case e.Button.Text
            Case tlb_Btn.Buttons.Item(0).Text                               ' �o�b�N�A�b�v����
                strQMsgID = "Q07"
                strSMsgID = "S02"
                strEMsgID = "S04"
            Case tlb_Btn.Buttons.Item(1).Text
                strQMsgID = "Q08"
                strSMsgID = "S03"
                strEMsgID = "S05"
                objNode = trv_BKInfo.SelectedNode
                If IsNothing(objNode) Then
                    Exit Sub
                Else
                    If IsNothing(objNode.Parent) Then
                        Exit Sub
                    Else
                        If objNode.ImageIndex <> 0 Then
                            Exit Sub
                        End If
                    End If
                End If
            Case Else
                Exit Sub
        End Select
        If GF_Msg(strQMsgID, "", MsgBoxStyle.OKCancel, MsgBoxStyle.Question) = MsgBoxResult.OK Then
            stb_Msg.Panels(0).Text = GF_GetMsg(strSMsgID)
            Me.Cursor = Cursors.WaitCursor
            If e.Button.Text = tlb_Btn.Buttons.Item(0).Text Then
                If Not GF_Backup(Trim$(txt_Comment.Text)) Then
                    GoTo SYSTEM_ERROR
                End If
            Else
                If Not GF_Recovery(objNode.Tag) Then
                    GoTo SYSTEM_ERROR
                End If
            End If
            Me.Cursor = Cursors.Default
            Call GF_Msg(strEMsgID, "", MsgBoxStyle.OKOnly, MsgBoxStyle.Information)
            stb_Msg.Panels(0).Text = ""
            Call LS_CreateBKTree()                                      ' �c���[�r���[�Đ���
        End If

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("ToolBar1_ButtonClick")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ۑ�����/�ۑ��񐔐ݒ�E�B���h�E�\������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���N���[�Y������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub TP1060_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not LF_QueryQuit()
    End Sub

    Private Function LF_QueryQuit() As Boolean
        LF_QueryQuit = False
        'If MsgBox(GF_GetMsg("012"), MsgBoxStyle.YesNo + MsgBoxStyle.Question, g_udtAppConfig.strAppName) = MsgBoxResult.No Then
        '    Exit Function
        'End If
        LF_QueryQuit = True
    End Function

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim objForm As New CNL1601()
        objForm.ShowDialog()
        Call LS_CreateBKTree()                                      ' �c���[�r���[�Đ���
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Me.Close()
    End Sub
End Class
