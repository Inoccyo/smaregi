Public Class CNL1534
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
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_OK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList3 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList4 As System.Windows.Forms.ImageList
    Friend WithEvents tlb_Move As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlb_Btn2 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents lsv_ItemList As System.Windows.Forms.ListView
    Friend WithEvents lsv_ItemGrp As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CNL1534))
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList4 = New System.Windows.Forms.ImageList(Me.components)
        Me.tlb_Move = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton()
        Me.tlb_Btn2 = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton()
        Me.lsv_ItemList = New System.Windows.Forms.ListView()
        Me.lsv_ItemGrp = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(136, 360)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(104, 32)
        Me.btn_Cancel.TabIndex = 7
        Me.btn_Cancel.Text = "�L�����Z��"
        '
        'btn_OK
        '
        Me.btn_OK.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_OK.Location = New System.Drawing.Point(24, 360)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(104, 32)
        Me.btn_OK.TabIndex = 6
        Me.btn_OK.Text = "�n�j"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "�� �T�u���j���[��I�����ĉ�����"
        '
        'ImageList3
        '
        Me.ImageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList3.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList4
        '
        Me.ImageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList4.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageList4.ImageStream = CType(resources.GetObject("ImageList4.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList4.TransparentColor = System.Drawing.Color.Transparent
        '
        'tlb_Move
        '
        Me.tlb_Move.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton6, Me.ToolBarButton7})
        Me.tlb_Move.Divider = False
        Me.tlb_Move.Dock = System.Windows.Forms.DockStyle.None
        Me.tlb_Move.DropDownArrows = True
        Me.tlb_Move.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tlb_Move.ImageList = Me.ImageList4
        Me.tlb_Move.Location = New System.Drawing.Point(24, 256)
        Me.tlb_Move.Name = "tlb_Move"
        Me.tlb_Move.ShowToolTips = True
        Me.tlb_Move.Size = New System.Drawing.Size(200, 31)
        Me.tlb_Move.TabIndex = 8
        Me.tlb_Move.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 0
        Me.ToolBarButton6.Text = "��ֈړ�"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.ImageIndex = 1
        Me.ToolBarButton7.Text = "���ֈړ�"
        '
        'tlb_Btn2
        '
        Me.tlb_Btn2.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton4, Me.ToolBarButton2, Me.ToolBarButton5})
        Me.tlb_Btn2.ButtonSize = New System.Drawing.Size(107, 60)
        Me.tlb_Btn2.Divider = False
        Me.tlb_Btn2.Dock = System.Windows.Forms.DockStyle.None
        Me.tlb_Btn2.DropDownArrows = True
        Me.tlb_Btn2.ImageList = Me.ImageList3
        Me.tlb_Btn2.Location = New System.Drawing.Point(304, 48)
        Me.tlb_Btn2.Name = "tlb_Btn2"
        Me.tlb_Btn2.ShowToolTips = True
        Me.tlb_Btn2.Size = New System.Drawing.Size(112, 181)
        Me.tlb_Btn2.TabIndex = 11
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 1
        Me.ToolBarButton4.Text = "�T�u���j���[�֒ǉ�"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 0
        Me.ToolBarButton2.Text = "�T�u���j���[����폜"
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.ImageIndex = 2
        Me.ToolBarButton5.Text = "�S�ĉ�������"
        '
        'lsv_ItemList
        '
        Me.lsv_ItemList.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_ItemList.Location = New System.Drawing.Point(424, 40)
        Me.lsv_ItemList.Name = "lsv_ItemList"
        Me.lsv_ItemList.Size = New System.Drawing.Size(384, 352)
        Me.lsv_ItemList.TabIndex = 10
        Me.lsv_ItemList.View = System.Windows.Forms.View.Details
        '
        'lsv_ItemGrp
        '
        Me.lsv_ItemGrp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3})
        Me.lsv_ItemGrp.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_ItemGrp.Location = New System.Drawing.Point(16, 40)
        Me.lsv_ItemGrp.Name = "lsv_ItemGrp"
        Me.lsv_ItemGrp.Size = New System.Drawing.Size(280, 200)
        Me.lsv_ItemGrp.TabIndex = 9
        Me.lsv_ItemGrp.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Width = 135
        '
        'CNL1534
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(824, 470)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.tlb_Move, Me.tlb_Btn2, Me.lsv_ItemList, Me.lsv_ItemGrp, Me.btn_Cancel, Me.btn_OK, Me.Label1})
        Me.Name = "CNL1534"
        Me.Text = "CNL1534"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public G_Sub1 As String
    Public G_Sub2 As String
    Public G_Sub3 As String
    Public G_Sub4 As String
    Public G_Sub5 As String
    Public G_Sub6 As String
    Public G_Code As String
    Private L_blnDMode As Boolean                                           ' True:�ǉ����� / False:�폜����

    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click

        Dim intCnt As Integer

        While intCnt < lsv_ItemGrp.Items.Count

            Select Case intCnt
                Case 0
                    G_Sub1 = lsv_ItemGrp.Items(intCnt).SubItems(1).Text
                Case 1
                    G_Sub2 = lsv_ItemGrp.Items(intCnt).Text
                Case 2
                    G_Sub3 = lsv_ItemGrp.Items(intCnt).Text
                Case 3
                    G_Sub4 = lsv_ItemGrp.Items(intCnt).Text
                Case 4
                    G_Sub5 = lsv_ItemGrp.Items(intCnt).Text
                Case 5
                    G_Sub6 = lsv_ItemGrp.Items(intCnt).Text
                Case Else
            End Select

            intCnt = intCnt + 1

        End While
        'If Not GF_CommitTrans() Then
        '    Exit Sub
        'End If

        '------------------------------
        ' �e��ʂ֒l�ԋp
        '------------------------------
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click

        'If Not GF_RollbackTrans() Then
        '    Exit Sub
        'End If

        '------------------------------
        ' �e��ʂ֒l�ԋp
        '------------------------------
        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub CNL1534_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        With lsv_ItemList
            .Clear()
            .FullRowSelect = True
            .AllowDrop = True
            .AllowColumnReorder = True
            .HideSelection = False
        End With

        With lsv_ItemGrp
            .Clear()
            .FullRowSelect = True
            .AllowDrop = True
            .AllowColumnReorder = True
            .HideSelection = False
        End With

        '-- �f�[�^�\��
        LF_SetItemList()
        LF_SetItemList2()

        '------------------------------
        ' �g�����U�N�V�����J�n
        '------------------------------
        'If Not GF_BeginTrans() Then
        '    Exit Sub
        'End If

    End Sub

    Private Function LF_SetItemList2() As Object

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim intCnt As Integer
        Dim intRowCnt As Integer
        Dim objItem As ListViewItem

        LF_SetItemList2 = Nothing

        '------------------------------
        ' ���j���[�e�[�u���I�[�v��
        '------------------------------
        lsv_ItemList.Clear()
        With lsv_ItemList.Columns
            .Add("���i�R�[�h", 90, HorizontalAlignment.Center)
            .Add("���i��", 200, HorizontalAlignment.Left)
            .Add("�P��", 75, HorizontalAlignment.Right)
        End With

        '-- �\���f�[�^�擾
        strSQL = ""
        strSQL = strSQL & "SELECT GOODSCD, GOODSNMJ, PRICE"
        strSQL = strSQL & "  FROM TPM010"
        'strSQL = strSQL & " WHERE GOODSCD > '"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        intRowCnt = objData.Tables("com").Rows.Count

        If intRowCnt > 0 Then
            For intCnt = 0 To intRowCnt - 1
                If Not GF_GetRows(objData, intCnt, objRow) Then
                    Exit Function
                End If

                objItem = New ListViewItem()
                objItem.Text = Trim$(objRow("GOODSCD")) & Space(6)         ' �㔼�̃X�y�[�X�́A�}�E�X���쎞�̋�U��h�~�΍�
                objItem.SubItems.Add(Trim$(objRow("GOODSNMJ")))
                ' ------------------------------------------------------
                objItem.SubItems.Add(Format$(CLng(Trim$(objRow("PRICE"))), "#,##0") & "�~")
                lsv_ItemList.Items.Add(objItem)

            Next
        End If


    End Function

    Private Function LF_SetItemList() As Object

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim objItem As ListViewItem
        Dim strSQL As String
        Dim intSCPNO As Integer

        LF_SetItemList = Nothing

        Try
            '------------------------------
            ' ���j���[�e�[�u���I�[�v��
            '------------------------------
            lsv_ItemGrp.Clear()
            With lsv_ItemGrp.Columns
                .Add("���i�R�[�h", 90, HorizontalAlignment.Center)
                .Add("���i��", 262, HorizontalAlignment.Left)
                .Add("�P��", 75, HorizontalAlignment.Right)
            End With

            '-- �\���f�[�^�擾
            strSQL = ""
            For intSCPNO = 5 To 10
                strSQL = strSQL & "SELECT " & intSCPNO & " AS CNT,"
                strSQL = strSQL & "       A.SCPNO" & Format(intSCPNO, "00") & " AS SCPNO,"
                strSQL = strSQL & "       B.GOODSCD AS GOODSCD,"
                strSQL = strSQL & "       B.GOODSNMJ AS GOODSNMJ,"
                strSQL = strSQL & "       B.PRICE AS PRICE"
                strSQL = strSQL & "  FROM TPM010 A, TPM010 B"
                strSQL = strSQL & " WHERE A.GOODSCD = '" & G_Code & "'"
                strSQL = strSQL & "   AND A.SCPNO" & Format(intSCPNO, "00") & " = B.GOODSCD"

                If intSCPNO < 10 Then
                    strSQL = strSQL & " UNION "
                End If
            Next
            strSQL = strSQL & " ORDER BY CNT"

            If Not GF_GetData(strSQL, objData) Then
                Exit Function
            End If

            lngCnt = 0
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objRows) Then
                    Exit Function
                End If

                objItem = New ListViewItem()
                objItem.Text = Trim$(objRows("GOODSCD")) & Space(6)        ' �㔼�̃X�y�[�X�́A�}�E�X���쎞�̋�U��h�~�΍�
                objItem.SubItems.Add(Trim$(objRows("GOODSNMJ")))
                objItem.SubItems.Add(Format$(CLng(Trim$(objRows("PRICE"))), "#,##0") & "�~")
                lsv_ItemGrp.Items.Add(objItem)
                objItem = Nothing

                lngCnt = lngCnt + 1
            End While
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Function

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetItemList")
    End Function

    Private Sub tlb_Btn2_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlb_Btn2.ButtonClick

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objItem As ListViewItem

        Select Case e.Button.Text
            Case tlb_Btn2.Buttons.Item(0).Text
                Call LS_AddItems(lsv_ItemList.SelectedItems)

            Case tlb_Btn2.Buttons.Item(1).Text
                Call LS_RemoveItems(lsv_ItemGrp.SelectedItems)

            Case tlb_Btn2.Buttons.Item(2).Text
                lsv_ItemGrp.SelectedItems.Clear()                           ' �I����ԉ���
                For Each objItem In lsv_ItemGrp.Items                       ' �S�A�C�e���I�����
                    objItem.Selected = True
                Next
                Call LS_RemoveItems(lsv_ItemGrp.SelectedItems)

            Case Else
                GoTo SYSTEM_ERROR
        End Select

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("tlb_Btn2_ButtonClick")
    End Sub

    Private Sub LS_AddItems(ByVal pTargetData As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        'Dim udtinfo As typItemInfo
        Dim lngDataCnt As Integer
        Dim lngCnt As Integer
        Dim lngListCnt As Integer
        Dim lngRefCnt As Integer
        Dim intSCPNo As Integer
        Dim intListCnt As Integer
        Dim objItem As ListViewItem
        Dim objListView As New ListView()

        '-- ���ڐ��`�F�b�N�i���z�L�I�v�V�����͍ő�6�j
        If pTargetData.Count > 6 Then
            MsgBox("�T�u���j���[�̎w��͍ő�U�ł�", MsgBoxStyle.OKOnly)
            Exit Sub
        End If
        If lsv_ItemGrp.Items.Count = 6 Then
            MsgBox("�T�u���j���[�̎w��͍ő�U�ł�", MsgBoxStyle.OKOnly)
            Exit Sub
        End If
        If lsv_ItemGrp.Items.Count + pTargetData.Count > 6 Then
            MsgBox("�T�u���j���[�̎w��͍ő�U�ł�", MsgBoxStyle.OKOnly)
            Exit Sub
        End If

        If pTargetData.Count = 0 Then Exit Sub

        lngDataCnt = pTargetData.Count
        lngCnt = 0
        lngRefCnt = 0
        intListCnt = lsv_ItemGrp.Items.Count
        intSCPNo = 5

        For lngCnt = 0 To lngDataCnt - 1

            objItem = New ListViewItem()
            objItem.Text = pTargetData.Item(lngRefCnt).Text
            objItem.SubItems.Add(pTargetData.Item(lngRefCnt).SubItems(1).Text)
            objItem.SubItems.Add(pTargetData.Item(lngRefCnt).SubItems(2).Text)
            lsv_ItemGrp.Items.Add(objItem)
            objItem = Nothing

            ' --- �E���̃��X�g�r���[���猸�炷
            With lsv_ItemList.Items
                For lngListCnt = 0 To .Count - 1
                    If .Item(lngListCnt).Text = pTargetData.Item(lngRefCnt).Text Then
                        .Item(lngListCnt).Remove()
                        Exit For
                    End If
                Next
            End With
        Next

        'lsv_ItemGrp = objListView

        ''-- TPM010�̃T�u���j���[�iSCPNO05�`SCPNO11�j���X�V
        ''strSQL = ""
        ''strSQL = strSQL & "UPDATE TPM010"
        ''strSQL = strSQL & " SET "
        ''If intListCnt > 0 Then
        ''    For i = 0 To intListCnt - 1
        ''        strSQL = strSQL & " SCPNO" & Format(intSCPNo, "00") & " = '" & lsv_ItemGrp.Items(i).Text & "',"
        ''        intSCPNo = intSCPNo + 1
        ''    Next
        ''End If

        ''For lngCnt = 0 To lngDataCnt - 1

        ''    strSQL = strSQL & " SCPNO" & Format(intSCPNo, "00") & " = '" & pTargetData.Item(lngRefCnt).Text & "',"
        ''    intSCPNo = intSCPNo + 1

        ''    ' --- �E���̃��X�g�r���[���猸�炷
        ''    With lsv_ItemList.Items
        ''        For lngListCnt = 0 To .Count - 1
        ''            If .Item(lngListCnt).Text = pTargetData.Item(lngRefCnt).Text Then
        ''                .Item(lngListCnt).Remove()
        ''                Exit For
        ''            End If
        ''        Next
        ''    End With
        ''Next

        ''If intSCPNo < 10 Then
        ''    While intSCPNo < 11
        ''        strSQL = strSQL & " SCPNO" & Format(intSCPNo, "00") & " = '00000',"
        ''        intSCPNo = intSCPNo + 1
        ''    End While
        ''End If

        ''strSQL = strSQL & "UPDID = '" & GC_UPDID & "',"
        ''strSQL = strSQL & "UPDYMD = '" & Now & "'"
        ''strSQL = strSQL & " WHERE GOODSCD = '" & G_Code & "'"

        ''If Not GF_UpdData(strSQL) Then
        ''    Exit Sub
        ''End If


        ''''------------------------------
        '''' �O���[�v�����i�ꗗ�X�V
        ''''------------------------------
        ''Call LF_SetItemList()

        ''''------------------------------
        '''' �\�������ڍX�V����
        ''''------------------------------
        ''If Not LF_UpdTPM020_4(udtinfo.strGROUPCD) Then
        ''    GoTo SYSTEM_ERROR
        ''End If

        ''L_blnEditFlg = True
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_AddItems")

    End Sub

    Private Sub LS_RemoveItems(ByVal pTargetData As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngCnt As Long
        Dim strSQL As String
        Dim intDelCnt As Integer
        Dim intSCPNO As Integer
        Dim objListView As New ListView()
        Dim i As Integer

        If pTargetData.Count = 0 Then Exit Sub

        i = 0
        lngCnt = 0
        intDelCnt = 0
        intSCPNO = 5
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM010 SET"

        While lngCnt < lsv_ItemGrp.Items.Count

            'objItem = New ListViewItem()
            'objItem.Text = lsv_ItemGrp.Items(i).Text
            'objItem.SubItems.Add(Trim$(lsv_ItemGrp.Items(i).SubItems(0).Text))
            'objItem.SubItems.Add(Trim$(lsv_ItemGrp.Items(i).SubItems(1).Text))
            'objListView.Items.Add(objItem)
            'objItem = Nothing

            If intDelCnt < pTargetData.Count Then
                If lsv_ItemGrp.Items(i).Text = pTargetData.Item(intDelCnt).Text Then
                    lsv_ItemGrp.Items.Item(i).Remove()
                Else
                    i = i + 1
                End If
            End If

            '------------------------------
            ' �c�a�X�V����
            '------------------------------
            ''If intDelCnt < pTargetData.Count Then
            ''    If lsv_ItemGrp.Items(lngCnt).Text = pTargetData.Item(intDelCnt).Text Then
            ''        intDelCnt = intDelCnt + 1
            ''    Else
            ''        strSQL = strSQL & " SCPNO" & Format(intSCPNO, "00") & " = '" & lsv_ItemGrp.Items(lngCnt).Text & "',"
            ''        intSCPNO = intSCPNO + 1
            ''    End If
            ''Else
            ''    strSQL = strSQL & " SCPNO" & Format(intSCPNO, "00") & " = '" & lsv_ItemGrp.Items(lngCnt).Text & "',"
            ''    intSCPNO = intSCPNO + 1
            ''End If

            lngCnt = lngCnt + 1
        End While
        ''If intSCPNO < 10 Then
        ''    While intSCPNO < 11
        ''        strSQL = strSQL & " SCPNO" & Format(intSCPNO, "00") & " = '00000',"
        ''        intSCPNO = intSCPNO + 1
        ''    End While
        ''End If
        ''strSQL = strSQL & "UPDID = '" & GC_UPDID & "',"
        ''strSQL = strSQL & "UPDYMD = '" & Now & "'"
        ''strSQL = strSQL & " WHERE GOODSCD = '" & G_Code & "'"

        ''If Not GF_UpdData(strSQL) Then
        ''    Exit Sub
        ''End If

        'lsv_ItemGrp = objListView

        'Call LF_SetItemList()

        '' --- (2003.12.08) [���o�^���i]�ȊO�́A�E���̃��X�g���X�V���Ȃ� ----
        ''Call LS_SetItemList2(GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex))
        'If GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex) = LC_SORT_NOGROUP Then
        '    Call LF_SetItemList2(GF_CboGetCode(cbo_Sort, cbo_Sort.SelectedIndex))
        'End If
        ' ------------------------------------------------------------------

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_RemoveItems")

    End Sub

    Private Sub tlb_Move_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlb_Move.ButtonClick

        Dim lngTargetIndex As Long

        If lsv_ItemGrp.SelectedItems.Count = 0 Then Exit Sub

        Select Case e.Button.Text
            Case tlb_Move.Buttons(0).Text
                lngTargetIndex = lsv_ItemGrp.SelectedItems(0).Index - 1
                If lngTargetIndex < 0 Then Exit Sub
            Case tlb_Move.Buttons(1).Text
                lngTargetIndex = lsv_ItemGrp.SelectedItems(lsv_ItemGrp.SelectedItems.Count - 1).Index + 1
                If lngTargetIndex > lsv_ItemGrp.Items.Count - 1 Then Exit Sub
            Case Else
                Exit Sub
        End Select
        Call LS_ItemMove(lngTargetIndex, lsv_ItemGrp.SelectedItems)
        lsv_ItemGrp.EnsureVisible(lngTargetIndex)

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("tlb_Move_ButtonClick")
    End Sub

    Private Sub LS_ItemMove(ByVal pChgPos As Long, ByVal pMoveItems As ListView.SelectedListViewItemCollection)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objItem As ListViewItem
        Dim lngPos As Integer
        Dim lngCnt As Integer
        Dim lngMoveTop As Integer
        Dim blnUpFlg As Boolean

        Try
            '------------------------------
            ' �ύX�ʒu����
            '------------------------------
            If pChgPos < 0 Or lsv_ItemGrp.Items.Count - 1 < pChgPos Then Exit Sub

            If pChgPos <= pMoveItems(0).Index Then
                blnUpFlg = True
            Else
                blnUpFlg = False
            End If

            lngMoveTop = pMoveItems(0).Index
            For lngCnt = 1 To pMoveItems.Count - 1
                If lngMoveTop + 1 = pMoveItems(lngCnt).Index Then
                    lngMoveTop = pMoveItems(lngCnt).Index
                Else
                    blnUpFlg = True
                    Exit For
                End If
            Next

            '------------------------------
            ' �\�����ʕύX����
            '------------------------------
            lngPos = pChgPos
            For Each objItem In pMoveItems
                If lngPos > objItem.Index And blnUpFlg Then lngPos = lngPos - 1
                lsv_ItemGrp.Items.Remove(objItem)
                lsv_ItemGrp.Items.Insert(lngPos, objItem)

                If blnUpFlg Then lngPos = lngPos + 1
            Next

            '------------------------------
            ' �\�������ڍX�V����
            '------------------------------
            If Not LF_UpdTPM010() Then
                GoTo SYSTEM_ERROR
            End If

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_ItemMove")
    End Sub

    Private Function LF_UpdTPM010() As Boolean

        Dim strSQL As String
        Dim intSCPNO As Integer
        Dim intCnt As Integer

        LF_UpdTPM010 = False

        intCnt = 0
        strSQL = ""

        strSQL = strSQL & "UPDATE TPM010 SET "
        For intSCPNO = 5 To 10
            If intCnt < lsv_ItemGrp.Items.Count Then
                strSQL = strSQL & "SCPNO" & Format(intSCPNO, "00") & " = '" & lsv_ItemGrp.Items(intCnt).Text & "', "
            Else
                strSQL = strSQL & "SCPNO" & Format(intSCPNO, "00") & " = '00000', "
            End If
            intCnt = intCnt + 1
        Next
        strSQL = strSQL & "UPDID = '" & GC_UPDID & "',"
        strSQL = strSQL & "UPDYMD = '" & Now & "'"
        strSQL = strSQL & " WHERE GOODSCD = '" & G_Code & "'"

        'If Not GF_UpdData(strSQL) Then
        '    Exit Function
        'End If

        LF_UpdTPM010 = True

    End Function

    Private Sub lsv_ItemGrp_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_ItemGrp.ItemDrag
        ' �h���b�O�����J�n
        L_blnDMode = False
        lsv_ItemGrp.DoDragDrop(lsv_ItemGrp.SelectedItems, DragDropEffects.Copy)
    End Sub

    Private Sub lsv_ItemGrp_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemGrp.DragEnter
        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub lsv_ItemGrp_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemGrp.DragDrop

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objItem As ListViewItem
        Dim objPoint As Point


        If L_blnDMode = False Then
            objPoint = lsv_ItemGrp.PointToClient(New Point(e.X, e.Y))
            objItem = lsv_ItemGrp.GetItemAt(objPoint.X, objPoint.Y)

            Call LS_ItemMove(objItem.Index, e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))

        Else
            If Not e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then Exit Sub
            Call LS_AddItems(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))
        End If

    End Sub

    Private Sub lsv_ItemList_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lsv_ItemList.ItemDrag
        ' �h���b�O�����J�n
        L_blnDMode = True
        lsv_ItemGrp.DoDragDrop(lsv_ItemList.SelectedItems, DragDropEffects.Copy)
    End Sub
    Private Sub lsv_ItemList_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemList.DragEnter
        If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub lsv_ItemList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsv_ItemList.DragDrop

        If L_blnDMode = True Then Exit Sub
        If Not e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection)) Then Exit Sub
        Call LS_RemoveItems(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)))

    End Sub

End Class
