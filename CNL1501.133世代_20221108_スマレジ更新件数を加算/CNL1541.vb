' --------------------------------------------------------------------------------
' �@�@�@�@�\�FCrossNavi - �摜�I�����
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------

Public Class CNL1541
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grd_ImgList As System.Windows.Forms.DataGrid
    Friend WithEvents pic_Sample As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txt_PicPath As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grd_ImgList = New System.Windows.Forms.DataGrid
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.pic_Sample = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.txt_PicPath = New System.Windows.Forms.TextBox
        CType(Me.grd_ImgList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Sample, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_ImgList
        '
        Me.grd_ImgList.CaptionText = "�� �g�p����摜��I�����ĉ�����"
        Me.grd_ImgList.CaptionVisible = False
        Me.grd_ImgList.DataMember = ""
        Me.grd_ImgList.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_ImgList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_ImgList.Location = New System.Drawing.Point(214, 10)
        Me.grd_ImgList.Name = "grd_ImgList"
        Me.grd_ImgList.Size = New System.Drawing.Size(408, 432)
        Me.grd_ImgList.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(12, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "����"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(116, 409)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "�L�����Z��"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'pic_Sample
        '
        Me.pic_Sample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_Sample.Location = New System.Drawing.Point(12, 29)
        Me.pic_Sample.Name = "pic_Sample"
        Me.pic_Sample.Size = New System.Drawing.Size(192, 144)
        Me.pic_Sample.TabIndex = 3
        Me.pic_Sample.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "�� ���ݑI�𒆂̉摜"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 179)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 32)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "�摜�t�H���_�I��"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txt_PicPath
        '
        Me.txt_PicPath.Location = New System.Drawing.Point(172, 217)
        Me.txt_PicPath.Name = "txt_PicPath"
        Me.txt_PicPath.Size = New System.Drawing.Size(32, 19)
        Me.txt_PicPath.TabIndex = 6
        Me.txt_PicPath.Text = "TextBox1"
        '
        'CNL1541
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.txt_PicPath)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic_Sample)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grd_ImgList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CNL1541"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TP1031"
        CType(Me.grd_ImgList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Sample, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public G_TP1031_Ret As String

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���ǂݍ��ݎ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub TP1031_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �t�H�[�����̐ݒ�
        '------------------------------
        Me.Text = GF_FormText()

        '------------------------------
        ' ����������
        '------------------------------
        txt_PicPath.Visible = False
        txt_PicPath.Text = GF_GetAppInfo("PHOTO_PATH")
        pic_Sample.SizeMode = PictureBoxSizeMode.Zoom
        Call LS_SampleImgShow(G_TP1031_Ret)
        Call LS_GridSetup()

    End Sub


    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�O���[�v�����i�ꗗ�O���b�h ��������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_GridSetup()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objTs As New DataGridTableStyle()                               ' �V����DataGridTableStyle�̍쐬
        Dim udtGridCol(2) As typGridColumn
        Dim lngCnt As Long
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim dtsList As DataSet
        Dim objTable As DataTable

        '------------------------------
        ' �e�[�u���X�^�C����`
        '------------------------------
        With objTs
            .MappingName = "IMAGELIST"                                      ' �}�b�v�����w��
            .PreferredRowHeight = 96                                        ' �W���s�����w��
        End With

        '------------------------------
        ' �e���ڑ�����`
        '------------------------------
        With udtGridCol(0)
            .intType = CNL1920.COLUMN_TYPE.IMAGE_NOEDIT_STYLE
            .strMapName = "PIC_COL1"
            .strHeadText = "�摜��P"
            .blnAllowNull = False
            .lngWidth = 128
            .objAlign = HorizontalAlignment.Center
            .blnReadOnly = True
        End With
        With udtGridCol(1)
            .intType = CNL1920.COLUMN_TYPE.IMAGE_NOEDIT_STYLE
            .strMapName = "PIC_COL2"
            .strHeadText = "�摜��Q"
            .blnAllowNull = False
            .lngWidth = 128
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With udtGridCol(2)
            .intType = CNL1920.COLUMN_TYPE.IMAGE_NOEDIT_STYLE
            .strMapName = "PIC_COL3"
            .strHeadText = "�摜��R"
            .blnAllowNull = False
            .lngWidth = 128
            .objAlign = HorizontalAlignment.Right
            .blnReadOnly = True
        End With

        For lngCnt = 0 To UBound(udtGridCol)                                ' �e���`���e�[�u���X�^�C���ɒǉ�
            Call GS_GridAddColumn(udtGridCol(lngCnt), objTs)
        Next
        objTs.AllowSorting = False                                          ' �񌩏o���N���b�N�ɂ��\�[�g���֎~
        objTs.RowHeadersVisible = False

        With grd_ImgList
            .TableStyles.Clear()
            .TableStyles.Add(objTs)                                         ' �e�[�u���X�^�C����DataGrid�ɒǉ�
            .ReadOnly = True                                                ' �ҏW�֎~
            .ColumnHeadersVisible = False
        End With

        '------------------------------
        ' �O���b�h����
        '------------------------------
        dtsList = New DataSet("ImageList")
        objTable = New DataTable("IMAGELIST")
        For lngCnt = 0 To UBound(udtGridCol)
            Call GS_GridAddTable(udtGridCol(lngCnt), objTable)
        Next

        '------------------------------
        ' �f�[�^�l�ݒ�
        '------------------------------
        Dim strFile As String
        Dim strTargetDir As String
        Dim lngCol As Long
        Try
            strTargetDir = Trim$(txt_PicPath.Text)
            If System.IO.Directory.Exists(strTargetDir) = False Then
                Exit Try
            End If

            lngCnt = 0
            lngCol = 0
            For Each strFile In System.IO.Directory.GetFiles(strTargetDir, "*.JPG")
                If lngCol = 0 Then
                    If lngCnt <> 0 Then
                        objTable.Rows.Add(objRows)
                    End If
                    objRows = objTable.NewRow
                End If
                objRows(udtGridCol(lngCol).strMapName) = strFile

                lngCnt = lngCnt + 1
                If lngCnt Mod 3 = 0 And lngCnt <> 0 Then
                    lngCol = 0
                Else
                    lngCol = lngCol + 1
                End If
            Next

            ' --- (2004.02.06) �l�^�P�[�X�Ή� ------------------------------
            For Each strFile In System.IO.Directory.GetFiles(strTargetDir, "*.gif")
                If lngCol = 0 Then
                    If lngCnt <> 0 Then
                        objTable.Rows.Add(objRows)
                    End If
                    objRows = objTable.NewRow
                End If
                objRows(udtGridCol(lngCol).strMapName) = strFile

                lngCnt = lngCnt + 1
                If lngCnt Mod 3 = 0 And lngCnt <> 0 Then
                    lngCol = 0
                Else
                    lngCol = lngCol + 1
                End If
            Next
            ' --------------------------------------------------------------

            If Not IsNothing(objRows) Then
                objTable.Rows.Add(objRows)
            End If
        Catch
            Exit Sub
        End Try

        dtsList.Tables.Add(objTable)                                        ' �e�[�u����DataSet�ɒǉ�����
        grd_ImgList.SetDataBinding(dtsList, "IMAGELIST")                    ' DataSet�ƃe�[�u����DataGrid�ɐڑ�����

    End Sub

    Private Sub grd_ImgList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_ImgList.DoubleClick
        If GF_GetRowCnt(grd_ImgList) = 0 Then Exit Sub
        Call LS_RetClose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call LS_RetClose()
    End Sub

    Private Sub LS_SampleImgShow(ByVal pFileName As String)

        Dim objFile As System.IO.FileStream

        If Len(Trim$(pFileName)) = 0 Then Exit Sub
        If System.IO.File.Exists(pFileName) = False Then Exit Sub

        'GIF�摜�̏ꍇ
        If Strings.Right(pFileName, 3) = "gif" Then
            pic_Sample.ImageLocation = pFileName
        Else
            objFile = New System.IO.FileStream(pFileName, IO.FileMode.Open, IO.FileAccess.Read)
            pic_Sample.Image = System.Drawing.Image.FromStream(objFile)
            objFile.Close()
        End If

    End Sub

    Private Sub grd_ImgList_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_ImgList.CurrentCellChanged

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCell As DataGridCell
        objCell = grd_ImgList.CurrentCell
        G_TP1031_Ret = grd_ImgList(objCell)

        Call LS_SampleImgShow(G_TP1031_Ret)
    End Sub

    Private Sub LS_RetClose()
        Dim objCell As DataGridCell
        If GF_GetRowCnt(grd_ImgList) <> 0 Then
            objCell = grd_ImgList.CurrentCell
            G_TP1031_Ret = grd_ImgList(objCell)
        End If
        Me.Close()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        G_TP1031_Ret = ""
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objFolder As New BrowseFolder()
        Dim strSelPath As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        strSelPath = objFolder.BrowseDialog("�t�H���_���w�肵�Ă��������B", Me)
        If strSelPath = g_udtAppConfig.strImgPath Then
            Call GF_Msg("E02", "", MsgBoxStyle.OkOnly, MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            txt_PicPath.Text = strSelPath
            If Len(Trim$(txt_PicPath.Text)) <> 0 Then
                Call LS_GridSetup()
            End If
        End If
    End Sub

    Private Sub CNL1541_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strDefImg As String
        Dim objFileInfo As System.IO.FileInfo = Nothing

        ' �f�t�H���g�摜���擾
        strDefImg = GF_GetMaterial("S013JC")
        If Len(Trim$(strDefImg)) = 0 Then Exit Sub

        If Len(Trim$(G_TP1031_Ret)) <> 0 Then
            objFileInfo = New System.IO.FileInfo(G_TP1031_Ret)
            If objFileInfo.Name = strDefImg Then
                G_TP1031_Ret = ""
            End If
            objFileInfo = Nothing
        End If

    End Sub

End Class
