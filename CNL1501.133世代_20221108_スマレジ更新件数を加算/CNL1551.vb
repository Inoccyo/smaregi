' --------------------------------------------------------------------------------
' �@�@�@�@�\�FCrossNavi - ���j���[�V�K�ǉ����
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------

Public Class CNL1551
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
        Me.Label1.Text = "�� ���j���[������͂��Ă�������"
        '
        'txt_Title
        '
        Me.txt_Title.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Title.Location = New System.Drawing.Point(24, 37)
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
        'CNL1551
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
        Me.Name = "CNL1551"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "JCV01_4"
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
    Private Sub CNL1551_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �t�H�[��������
        '------------------------------
        Me.Text = GF_FormText()
        txt_Title.Clear()

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F[����]�{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click

        '------------------------------
        ' �����̓`�F�b�N
        '------------------------------
        If Len(Trim$(txt_Title.Text)) = 0 Then
            Call GF_Msg("E01", "", MsgBoxStyle.OKOnly, MsgBoxStyle.Critical)
            txt_Title.Select()
            Exit Sub
        End If

        '------------------------------
        ' ���ꖼ�̂̃��j���[�����ɑ��݂��Ă���ꍇ�́A�G���[���b�Z�[�W��\�����āA�����𒆒f������
        '------------------------------
        Select Case LF_GetTPM060(Trim$(txt_Title.Text))
            Case CNL1920.FuncResult.CancelEnd
                ' ���݂���̂ŁA�G���[ 
                Call GF_Msg("", "���Ɂy" & Trim$(txt_Title.Text) & "�z�����݂��邽�߁A�g�p�ł��܂���B" & vbCrLf & "���̃��j���[������͂��ĉ������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Critical)
                Exit Sub

            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        '------------------------------
        ' ���j���[���R�[�h�ǉ�����
        '------------------------------
        If Not LF_InsertNewMenu() Then
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

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���ꃁ�j���[���̑��݃`�F�b�N����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2004.05.31 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM060(ByVal pMenuNM As String) As FuncResult

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM060 = CNL1920.FuncResult.UnusualEnd

        strSQL = ""
        strSQL = strSQL & "SELECT MENUID"
        strSQL = strSQL & "  FROM TPM060"
        strSQL = strSQL & " WHERE MENUNM = '" & pMenuNM & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        If objData.Tables("com").Rows.Count = 0 Then
            LF_GetTPM060 = CNL1920.FuncResult.NormalEnd
        Else
            LF_GetTPM060 = CNL1920.FuncResult.CancelEnd
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F[�L�����Z��]�{�^������������
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
    ' �@�@�@�@�\�F���j���[���R�[�h�ǉ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_InsertNewMenu() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()
        Dim lngCnt As Long
        Dim strNewID As String = Nothing
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim objBitmap As Bitmap
        Dim objGraph As Graphics
        Dim strGrpImgPath As String
        Dim strOrgPath As String
        Dim strTgtPath As String
        Dim strSTgtPath As String
        Dim strFilePath As String
        Dim strDefImg As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_InsertNewMenu = False
        strGrpImgPath = GF_GetAppInfo("MENUIMG_V")

        '------------------------------
        ' �ŏI�h�c�擾
        '------------------------------
        Select Case GF_GetNewID(CNL1920.ID_KIND.MenuID, strNewID)
            Case CNL1920.FuncResult.CancelEnd
                GF_Msg("", "���j���[�o�^��������ɒB���܂����B�����ꂩ�̃��j���[���폜���ĉ������B", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                LF_InsertNewMenu = True
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

        For lngCnt = 1 To 11
            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM060 VALUES("
            strSQL = strSQL & "'" & strNewID & "',"
            strSQL = strSQL & "'" & GF_RepQuo(Trim$(txt_Title.Text)) & "',"
            strSQL = strSQL & "'" & Format$(lngCnt, "000") & "',"

            Select Case lngCnt
                Case 10
                    strSQL = strSQL & "'�n���f�B�p���j���[',"
                Case 11
                    strSQL = strSQL & "'���ݕ���p���j���[',"
                Case Else
                    ' 2014-05-12 2�o�C�g������������
                    'strSQL = strSQL & "'���̖��ݒ�" & StrConv(Format$(lngCnt, "0"), VbStrConv.Wide) & "',"
                    strSQL = strSQL & "'���̖��ݒ�" & Format$(lngCnt, "0") & "',"
            End Select

            strSQL = strSQL & "'" & GC_MSTYLE_MENUGRP_DIRC4 & "',"
            strSQL = strSQL & "'" & GC_DUMMY_GROUPCD & "',"
            strSQL = strSQL & "'0',"
            strSQL = strSQL & "'0',"
            strSQL = strSQL & "'" & GC_ORDER_GROUP & "',"
            strSQL = strSQL & "'" & GC_TRUE & "',"
            strSQL = strSQL & "'" & GC_UPDID & "',"
            strSQL = strSQL & "'" & Now & "')"

            If Not GF_UpdData(strSQL) Then
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                Exit Function
            End If

            Try
                If lngCnt > 2 Then
                    strDefImg = GF_GetMaterial("S047JC")
                Else
                    strDefImg = GF_GetMaterial("S048JC")
                End If

                If Len(Trim$(strDefImg)) = 0 Then
                    Exit Function
                End If
                objFileInfo = New System.IO.FileInfo(strDefImg)

                strOrgPath = GF_GetAppInfo("MATERIAL_V") & "\" & Trim$(strDefImg)
                strFilePath = Format$(lngCnt, "000") & "_" & Replace(objFileInfo.Name, objFileInfo.Extension, "") & Format$(Now, "yyyyMMddHHmmss") & objFileInfo.Extension
                strTgtPath = strGrpImgPath & "\" & strFilePath
                strSTgtPath = strGrpImgPath & "\S_" & strFilePath

                '------------------------------
                ' �I���W�i���T�C�Y�R�s�[
                '------------------------------
                System.IO.File.Copy(strOrgPath, strTgtPath)

                '------------------------------
                ' �k�������R�s�[(�ĕۑ�)
                '------------------------------
                If lngCnt > 2 Then
                    objBitmap = New Bitmap(352, 264)
                    objGraph = Graphics.FromImage(objBitmap)
                    objGraph.DrawImage(Image.FromFile(strTgtPath), 0, 0, 352, 264)
                Else
                    Dim imagew, imageh, lngHeight As Integer
                    Dim fs As System.IO.FileStream
                    fs = New System.IO.FileStream(strTgtPath, IO.FileMode.Open, IO.FileAccess.Read)
                    imagew = System.Drawing.Image.FromStream(fs).Width
                    imageh = System.Drawing.Image.FromStream(fs).Height
                    fs.Close()
                    lngHeight = (imageh * 352) / imagew
                    objBitmap = New Bitmap(352, lngHeight)
                    objGraph = Graphics.FromImage(objBitmap)
                    objGraph.DrawImage(Image.FromFile(strTgtPath), 0, 0, 352, lngHeight)
                End If
                objBitmap.Save(strSTgtPath, System.Drawing.Imaging.ImageFormat.Png)
                objBitmap.Dispose()
                objGraph.Dispose()

                strSQL = ""
                strSQL = strSQL & "INSERT INTO TPM061 VALUES("
                strSQL = strSQL & "'" & strNewID & "',"
                strSQL = strSQL & "'" & Format$(lngCnt, "000") & "',"
                strSQL = strSQL & "'" & strFilePath & "',"
                strSQL = strSQL & "'" & GC_UPDID & "',"
                strSQL = strSQL & "'" & Now & "')"

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If
            Catch
                If Not GF_RollbackTrans() Then
                    Exit Function
                End If
                objFileInfo = Nothing
                Exit Function
            End Try
        Next

        '������@�\�Ή�
        If GF_GetAppInfo2("MULTI_LING_USE") = "1" Then

            '------------------------------
            ' TPM060A�ATPM061A�ǉ�
            '------------------------------
            Threading.Thread.Sleep(1000)
            For lngCnt = 1 To 11
                strSQL = ""
                strSQL = strSQL & "INSERT INTO TPM060A VALUES("
                strSQL = strSQL & "N'" & strNewID & "',"
                strSQL = strSQL & "N'" & GF_RepQuo(Trim$(txt_Title.Text)) & "',"
                strSQL = strSQL & "N'" & Format$(lngCnt, "000") & "',"

                Select Case lngCnt
                    Case 10
                        strSQL = strSQL & "N'�n���f�B�p���j���[',"
                    Case 11
                        strSQL = strSQL & "N'���ݕ���p���j���[',"
                    Case Else
                    ' 2014-05-12 2�o�C�g������������
                        'strSQL = strSQL & "N'���̖��ݒ�" & StrConv(Format$(lngCnt, "0"), VbStrConv.Wide) & "',"
                        strSQL = strSQL & "N'���̖��ݒ�" & Format$(lngCnt, "0") & "',"
                End Select

                strSQL = strSQL & "N'" & GC_MSTYLE_MENUGRP_DIRC4 & "',"
                strSQL = strSQL & "N'" & GC_DUMMY_GROUPCD & "',"
                strSQL = strSQL & "N'0',"
                strSQL = strSQL & "N'0',"
                strSQL = strSQL & "N'" & GC_ORDER_GROUP & "',"
                strSQL = strSQL & "N'" & GC_TRUE & "',"
                strSQL = strSQL & "N'" & GC_UPDID & "',"
                strSQL = strSQL & "N'" & Now & "')"

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                Try
                    If lngCnt > 2 Then
                        strDefImg = GF_GetMaterial("S047JC")
                    Else
                        strDefImg = GF_GetMaterial("S048JC")
                    End If

                    If Len(Trim$(strDefImg)) = 0 Then
                        Exit Function
                    End If
                    objFileInfo = New System.IO.FileInfo(strDefImg)

                    strOrgPath = GF_GetAppInfo("MATERIAL_V") & "\" & Trim$(strDefImg)
                    strFilePath = Format$(lngCnt, "000") & "A_" & Replace(objFileInfo.Name, objFileInfo.Extension, "") & Format$(Now, "yyyyMMddHHmmss") & objFileInfo.Extension
                    strTgtPath = strGrpImgPath & "\" & strFilePath
                    strSTgtPath = strGrpImgPath & "\S_" & strFilePath

                    '------------------------------
                    ' �I���W�i���T�C�Y�R�s�[
                    '------------------------------
                    System.IO.File.Copy(strOrgPath, strTgtPath)

                    '------------------------------
                    ' �k�������R�s�[(�ĕۑ�)
                    '------------------------------
                    If lngCnt > 2 Then
                        objBitmap = New Bitmap(352, 264)
                        objGraph = Graphics.FromImage(objBitmap)
                        objGraph.DrawImage(Image.FromFile(strTgtPath), 0, 0, 352, 264)
                    Else
                        Dim imagew, imageh, lngHeight As Integer
                        Dim fs As System.IO.FileStream
                        fs = New System.IO.FileStream(strTgtPath, IO.FileMode.Open, IO.FileAccess.Read)
                        imagew = System.Drawing.Image.FromStream(fs).Width
                        imageh = System.Drawing.Image.FromStream(fs).Height
                        fs.Close()
                        lngHeight = (imageh * 352) / imagew
                        objBitmap = New Bitmap(352, lngHeight)
                        objGraph = Graphics.FromImage(objBitmap)
                        objGraph.DrawImage(Image.FromFile(strTgtPath), 0, 0, 352, lngHeight)
                    End If
                    objBitmap.Save(strSTgtPath, System.Drawing.Imaging.ImageFormat.Png)
                    objBitmap.Dispose()
                    objGraph.Dispose()

                    strSQL = ""
                    strSQL = strSQL & "INSERT INTO TPM061A VALUES("
                    strSQL = strSQL & "N'" & strNewID & "',"
                    strSQL = strSQL & "N'" & Format$(lngCnt, "000") & "',"
                    strSQL = strSQL & "N'" & strFilePath & "',"
                    strSQL = strSQL & "N'" & GC_UPDID & "',"
                    strSQL = strSQL & "N'" & Now & "')"

                    If Not GF_UpdData(strSQL) Then
                        If Not GF_RollbackTrans() Then
                            Exit Function
                        End If
                        Exit Function
                    End If
                Catch
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    objFileInfo = Nothing
                    Exit Function
                End Try
            Next

            '------------------------------
            ' TPM060B�ATPM061B�ǉ�
            '------------------------------
            Threading.Thread.Sleep(1000)
            For lngCnt = 1 To 11
                strSQL = ""
                strSQL = strSQL & "INSERT INTO TPM060B VALUES("
                strSQL = strSQL & "N'" & strNewID & "',"
                strSQL = strSQL & "N'" & GF_RepQuo(Trim$(txt_Title.Text)) & "',"
                strSQL = strSQL & "N'" & Format$(lngCnt, "000") & "',"

                Select Case lngCnt
                    Case 10
                        strSQL = strSQL & "N'�n���f�B�p���j���[',"
                    Case 11
                        strSQL = strSQL & "N'���ݕ���p���j���[',"
                    Case Else
                    ' 2014-05-12 2�o�C�g������������
                        'strSQL = strSQL & "N'���̖��ݒ�" & StrConv(Format$(lngCnt, "0"), VbStrConv.Wide) & "',"
                        strSQL = strSQL & "N'���̖��ݒ�" & Format$(lngCnt, "0") & "',"
                End Select

                strSQL = strSQL & "N'" & GC_MSTYLE_MENUGRP_DIRC4 & "',"
                strSQL = strSQL & "N'" & GC_DUMMY_GROUPCD & "',"
                strSQL = strSQL & "N'0',"
                strSQL = strSQL & "N'0',"
                strSQL = strSQL & "N'" & GC_ORDER_GROUP & "',"
                strSQL = strSQL & "N'" & GC_TRUE & "',"
                strSQL = strSQL & "N'" & GC_UPDID & "',"
                strSQL = strSQL & "N'" & Now & "')"

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                Try
                    If lngCnt > 2 Then
                        strDefImg = GF_GetMaterial("S047JC")
                    Else
                        strDefImg = GF_GetMaterial("S048JC")
                    End If

                    If Len(Trim$(strDefImg)) = 0 Then
                        Exit Function
                    End If
                    objFileInfo = New System.IO.FileInfo(strDefImg)

                    strOrgPath = GF_GetAppInfo("MATERIAL_V") & "\" & Trim$(strDefImg)
                    strFilePath = Format$(lngCnt, "000") & "B_" & Replace(objFileInfo.Name, objFileInfo.Extension, "") & Format$(Now, "yyyyMMddHHmmss") & objFileInfo.Extension
                    strTgtPath = strGrpImgPath & "\" & strFilePath
                    strSTgtPath = strGrpImgPath & "\S_" & strFilePath

                    '------------------------------
                    ' �I���W�i���T�C�Y�R�s�[
                    '------------------------------
                    System.IO.File.Copy(strOrgPath, strTgtPath)

                    '------------------------------
                    ' �k�������R�s�[(�ĕۑ�)
                    '------------------------------
                    If lngCnt > 2 Then
                        objBitmap = New Bitmap(352, 264)
                        objGraph = Graphics.FromImage(objBitmap)
                        objGraph.DrawImage(Image.FromFile(strTgtPath), 0, 0, 352, 264)
                    Else
                        Dim imagew, imageh, lngHeight As Integer
                        Dim fs As System.IO.FileStream
                        fs = New System.IO.FileStream(strTgtPath, IO.FileMode.Open, IO.FileAccess.Read)
                        imagew = System.Drawing.Image.FromStream(fs).Width
                        imageh = System.Drawing.Image.FromStream(fs).Height
                        fs.Close()
                        lngHeight = (imageh * 352) / imagew
                        objBitmap = New Bitmap(352, lngHeight)
                        objGraph = Graphics.FromImage(objBitmap)
                        objGraph.DrawImage(Image.FromFile(strTgtPath), 0, 0, 352, lngHeight)
                    End If
                    objBitmap.Save(strSTgtPath, System.Drawing.Imaging.ImageFormat.Png)
                    objBitmap.Dispose()
                    objGraph.Dispose()

                    strSQL = ""
                    strSQL = strSQL & "INSERT INTO TPM061B VALUES("
                    strSQL = strSQL & "N'" & strNewID & "',"
                    strSQL = strSQL & "N'" & Format$(lngCnt, "000") & "',"
                    strSQL = strSQL & "N'" & strFilePath & "',"
                    strSQL = strSQL & "N'" & GC_UPDID & "',"
                    strSQL = strSQL & "N'" & Now & "')"

                    If Not GF_UpdData(strSQL) Then
                        If Not GF_RollbackTrans() Then
                            Exit Function
                        End If
                        Exit Function
                    End If
                Catch
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    objFileInfo = Nothing
                    Exit Function
                End Try
            Next

            '------------------------------
            ' TPM060C�ATPM061C�ǉ�
            '------------------------------
            Threading.Thread.Sleep(1000)
            For lngCnt = 1 To 11
                strSQL = ""
                strSQL = strSQL & "INSERT INTO TPM060C VALUES("
                strSQL = strSQL & "N'" & strNewID & "',"
                strSQL = strSQL & "N'" & GF_RepQuo(Trim$(txt_Title.Text)) & "',"
                strSQL = strSQL & "N'" & Format$(lngCnt, "000") & "',"

                Select Case lngCnt
                    Case 10
                        strSQL = strSQL & "N'�n���f�B�p���j���[',"
                    Case 11
                        strSQL = strSQL & "N'���ݕ���p���j���[',"
                    Case Else
                    ' 2014-05-12 2�o�C�g������������
                        'strSQL = strSQL & "N'���̖��ݒ�" & StrConv(Format$(lngCnt, "0"), VbStrConv.Wide) & "',"
                        strSQL = strSQL & "N'���̖��ݒ�" & Format$(lngCnt, "0") & "',"
                End Select

                strSQL = strSQL & "N'" & GC_MSTYLE_MENUGRP_DIRC4 & "',"
                strSQL = strSQL & "N'" & GC_DUMMY_GROUPCD & "',"
                strSQL = strSQL & "N'0',"
                strSQL = strSQL & "N'0',"
                strSQL = strSQL & "N'" & GC_ORDER_GROUP & "',"
                strSQL = strSQL & "N'" & GC_TRUE & "',"
                strSQL = strSQL & "N'" & GC_UPDID & "',"
                strSQL = strSQL & "N'" & Now & "')"

                If Not GF_UpdData(strSQL) Then
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    Exit Function
                End If

                Try
                    If lngCnt > 2 Then
                        strDefImg = GF_GetMaterial("S047JC")
                    Else
                        strDefImg = GF_GetMaterial("S048JC")
                    End If

                    If Len(Trim$(strDefImg)) = 0 Then
                        Exit Function
                    End If
                    objFileInfo = New System.IO.FileInfo(strDefImg)

                    strOrgPath = GF_GetAppInfo("MATERIAL_V") & "\" & Trim$(strDefImg)
                    strFilePath = Format$(lngCnt, "000") & "C_" & Replace(objFileInfo.Name, objFileInfo.Extension, "") & Format$(Now, "yyyyMMddHHmmss") & objFileInfo.Extension
                    strTgtPath = strGrpImgPath & "\" & strFilePath
                    strSTgtPath = strGrpImgPath & "\S_" & strFilePath

                    '------------------------------
                    ' �I���W�i���T�C�Y�R�s�[
                    '------------------------------
                    System.IO.File.Copy(strOrgPath, strTgtPath)

                    '------------------------------
                    ' �k�������R�s�[(�ĕۑ�)
                    '------------------------------
                    If lngCnt > 2 Then
                        objBitmap = New Bitmap(352, 264)
                        objGraph = Graphics.FromImage(objBitmap)
                        objGraph.DrawImage(Image.FromFile(strTgtPath), 0, 0, 352, 264)
                    Else
                        Dim imagew, imageh, lngHeight As Integer
                        Dim fs As System.IO.FileStream
                        fs = New System.IO.FileStream(strTgtPath, IO.FileMode.Open, IO.FileAccess.Read)
                        imagew = System.Drawing.Image.FromStream(fs).Width
                        imageh = System.Drawing.Image.FromStream(fs).Height
                        fs.Close()
                        lngHeight = (imageh * 352) / imagew
                        objBitmap = New Bitmap(352, lngHeight)
                        objGraph = Graphics.FromImage(objBitmap)
                        objGraph.DrawImage(Image.FromFile(strTgtPath), 0, 0, 352, lngHeight)
                    End If
                    objBitmap.Save(strSTgtPath, System.Drawing.Imaging.ImageFormat.Png)
                    objBitmap.Dispose()
                    objGraph.Dispose()

                    strSQL = ""
                    strSQL = strSQL & "INSERT INTO TPM061C VALUES("
                    strSQL = strSQL & "N'" & strNewID & "',"
                    strSQL = strSQL & "N'" & Format$(lngCnt, "000") & "',"
                    strSQL = strSQL & "N'" & strFilePath & "',"
                    strSQL = strSQL & "N'" & GC_UPDID & "',"
                    strSQL = strSQL & "N'" & Now & "')"

                    If Not GF_UpdData(strSQL) Then
                        If Not GF_RollbackTrans() Then
                            Exit Function
                        End If
                        Exit Function
                    End If
                Catch
                    If Not GF_RollbackTrans() Then
                        Exit Function
                    End If
                    objFileInfo = Nothing
                    Exit Function
                End Try
            Next

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
        LF_InsertNewMenu = True
        objFileInfo = Nothing

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
End Class
