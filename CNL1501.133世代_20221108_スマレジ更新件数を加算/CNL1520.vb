' --------------------------------------------------------------------------------
' �@�@�@�@�\�F�X�ܓ����V�X�e�� - �T�[�o�����e�i���X(���j���[�X�V���)
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------

Public Class CNL1520
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
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents grd_UnmatchList As System.Windows.Forms.DataGrid
    Friend WithEvents grd_ItemList As System.Windows.Forms.DataGrid
    Friend WithEvents cbo_SelRow As System.Windows.Forms.ComboBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.stb_Msg = New System.Windows.Forms.StatusBar()
        Me.grd_UnmatchList = New System.Windows.Forms.DataGrid()
        Me.grd_ItemList = New System.Windows.Forms.DataGrid()
        Me.cbo_SelRow = New System.Windows.Forms.ComboBox()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.grd_UnmatchList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_ItemList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.stb_Msg.TabIndex = 242
        Me.stb_Msg.Text = "StatusBar1"
        '
        'grd_UnmatchList
        '
        Me.grd_UnmatchList.CaptionText = "�� �f�[�^��荞�݌���"
        Me.grd_UnmatchList.DataMember = ""
        Me.grd_UnmatchList.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_UnmatchList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_UnmatchList.Location = New System.Drawing.Point(8, 8)
        Me.grd_UnmatchList.Name = "grd_UnmatchList"
        Me.grd_UnmatchList.Size = New System.Drawing.Size(632, 648)
        Me.grd_UnmatchList.TabIndex = 1
        '
        'grd_ItemList
        '
        Me.grd_ItemList.CaptionText = "�� �O��Ƃ̍���"
        Me.grd_ItemList.DataMember = ""
        Me.grd_ItemList.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grd_ItemList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_ItemList.Location = New System.Drawing.Point(648, 8)
        Me.grd_ItemList.Name = "grd_ItemList"
        Me.grd_ItemList.Size = New System.Drawing.Size(360, 648)
        Me.grd_ItemList.TabIndex = 2
        '
        'cbo_SelRow
        '
        Me.cbo_SelRow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_SelRow.Font = New System.Drawing.Font("�l�r �S�V�b�N", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo_SelRow.Location = New System.Drawing.Point(440, 8)
        Me.cbo_SelRow.Name = "cbo_SelRow"
        Me.cbo_SelRow.Size = New System.Drawing.Size(200, 23)
        Me.cbo_SelRow.TabIndex = 3
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
        Me.MenuItem2.Text = "�ҏW���e��ۑ�����(&S)"
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbo_SelRow, Me.grd_ItemList, Me.grd_UnmatchList})
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 268
        '
        'CNL1520
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1018, 691)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel1, Me.stb_Msg})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL1520"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNL1520"
        CType(Me.grd_UnmatchList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_ItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' --------------------------------------------------------------------------------
    ' ���W���[�����萔��`
    ' --------------------------------------------------------------------------------
    Private Const LC_NODATA As String = "<< ���o�^ >>"
    Private Const LC_SELROW_ALL As String = "ALL"
    Private Const LC_SELROW_DIF As String = "DIF"

    ' --------------------------------------------------------------------------------
    ' ���W���[�����ϐ���`
    ' --------------------------------------------------------------------------------
    Private L_objData As DataSet
    Private L_udtGridCol() As typGridColumn
    Private L_blnEditFlg As Boolean

    Private Structure typWidth
        Dim strFrom As String
        Dim strTo As String
    End Structure


    ' --- (2004.02.09) �P�������@�\�ǉ� ------------------------------------
    Private L_PriceEdit As String
    ' ----------------------------------------------------------------------

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�t�H�[���ǂݍ��ݎ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub CNL1520_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            '------------------------------
            ' �t�H�[�����̐ݒ�
            '------------------------------
            Me.Text = GF_FormText()

            '------------------------------
            ' ����������
            '------------------------------
            Call GS_StatusSetup(stb_Msg)                                    ' �X�e�[�^�X�o�[������
            grd_UnmatchList.AllowDrop = True
            grd_ItemList.AllowDrop = True

            '------------------------------
            ' �i���݃R���{�ݒ菈��
            '------------------------------
            cbo_SelRow.Items.Clear()
            Call GS_CboItemSet(cbo_SelRow, "�S�ĕ\������", LC_SELROW_ALL)
            Call GS_CboItemSet(cbo_SelRow, "�����̏��i�̂ݕ\������", LC_SELROW_DIF)
            cbo_SelRow.SelectedIndex = 0


            ' --- (2003.12.04) �擾���t�@�C�����݊m�F�����ǉ� --------------
            Dim strFileNm As String
            strFileNm = GF_GetAppInfo("OES_PATH") & "\" & GF_GetAppInfo("OES_MENUTBL")
            If System.IO.File.Exists(strFileNm) = False Then
                Call GF_Msg("", "���j���[�t�@�C�������݂��Ȃ����߁A�����𑱍s�ł��܂���" & vbCrLf & "[ " & strFileNm & "]", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
                MenuItem2.Enabled = False
                L_blnEditFlg = False
                Exit Sub
            End If

            strFileNm = GF_GetAppInfo("OES_PATH") & "\" & GF_GetAppInfo("OES_SCPTBL")
            If System.IO.File.Exists(strFileNm) = False Then
                Call GF_Msg("", "�I�v�V�����t�@�C�������݂��Ȃ����߁A�����𑱍s�ł��܂���" & vbCrLf & "[ " & strFileNm & "]", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
                MenuItem2.Enabled = False
                L_blnEditFlg = False
                Exit Sub
            End If

            strFileNm = GF_GetAppInfo("OES_PATH") & "\" & GF_GetAppInfo("OES_DPTBL")
            If System.IO.File.Exists(strFileNm) = False Then
                Call GF_Msg("", "����t�@�C�������݂��Ȃ����߁A�����𑱍s�ł��܂���" & vbCrLf & "[ " & strFileNm & "]", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
                MenuItem2.Enabled = False
                L_blnEditFlg = False
                Exit Sub
            End If
            ' --------------------------------------------------------------


            ' --- (2004.02.09) �P�������@�\�ǉ� ----------------------------
            L_PriceEdit = GF_GetAppInfo("PRICE_EDIT")                       ' �L�����ݒ�擾
            If Len(Trim$(L_PriceEdit)) = 0 Then
                L_PriceEdit = GC_FALSE
            End If
            ' --------------------------------------------------------------

            '------------------------------
            ' �f�[�^�s��v���o����
            '------------------------------
            Call LS_ChkMenuTbl()

            L_blnEditFlg = True

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1520_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�}�X�^�X�V�󋵊m�F����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_ChkMenuTbl()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objStatus As New CNL1810()
        Dim blnResult As Boolean

        Try
            '------------------------------
            ' �i���󋵒ʒm�t�H�[���\��
            '------------------------------
            objStatus.Show()
            With objStatus
                .pgs_Status.Minimum = 0
                .TopMost = True
            End With
            System.Windows.Forms.Application.DoEvents()

            Me.Cursor = Cursors.WaitCursor
            Call LS_GridSetup(objStatus)
            Call LS_GridSetup2(objStatus)
            Call LS_ChkFSCP(objStatus, blnResult)
            If blnResult And _
               GF_GetRowCnt(grd_ItemList) = 0 Then
                If GF_Msg("Q10", "", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    Call LS_SaveAllData()
                End If
            End If
            Me.Cursor = Cursors.Default

            objStatus.Close()

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Me.Cursor = Cursors.Default
        Call GS_ErrorTerm("CNL1520_Load")
    End Sub

    Private Sub LS_ChkFSCP(ByVal objStatus As CNL1810, ByRef pResult As Boolean)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim strFileNM As String
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim intFile As Integer
        Dim lngCnt As Long
        Dim bytData() As Byte
        Dim lngCol As Long
        Dim objSjisEnc As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        pResult = False                                                     ' ������Ԃł́A�ߕs�������Őݒ�

        '------------------------------
        ' �r�b�o�}�X�^�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM TPM100"
        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' "FSCP"�擾
        '------------------------------
        strFileNM = GF_GetAppInfo("OES_PATH") & "\" & _
                    GF_GetAppInfo("OES_SCPTBL")
        objFileInfo = New System.IO.FileInfo(strFileNM)
        If objData.Tables("com").Rows.Count <> (objFileInfo.Length / 53) Then
            pResult = True
            Exit Sub
        End If

        With objStatus
            .lbl_Msg.Text = "�R�����g�E�T�u�^�Z�b�g���j���[�e�[�u���̊m�F���ł�..."
            .pgs_Status.Maximum = objFileInfo.Length / 53
            .pgs_Status.Value = 0
        End With
        objFileInfo = Nothing
        System.Windows.Forms.Application.DoEvents()

        intFile = FreeFile()
        FileOpen(intFile, strFileNM, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
        lngCnt = 0
        While Not EOF(intFile)

            '------------------------------
            ' SCP-No.�擾
            '------------------------------
            bytData = LF_GetBData(1, 1, intFile, lngCnt, 53)

            strSQL = ""
            strSQL = strSQL & "SELECT SCPNO,"

            ' --- (2003.12.02) �K�C�_���X���ڎ擾�ǉ� ----------------------
            strSQL = strSQL & "       GUIDE,"
            ' --------------------------------------------------------------

            strSQL = strSQL & "       GOODSCD1  AS SCPMENU0,"
            strSQL = strSQL & "       GOODSCD2  AS SCPMENU1,"
            strSQL = strSQL & "       GOODSCD3  AS SCPMENU2,"
            strSQL = strSQL & "       GOODSCD4  AS SCPMENU3,"
            strSQL = strSQL & "       GOODSCD5  AS SCPMENU4,"
            strSQL = strSQL & "       GOODSCD6  AS SCPMENU5,"
            strSQL = strSQL & "       GOODSCD7  AS SCPMENU6,"
            strSQL = strSQL & "       GOODSCD8  AS SCPMENU7,"
            strSQL = strSQL & "       GOODSCD9  AS SCPMENU8,"
            strSQL = strSQL & "       GOODSCD10 AS SCPMENU9,"
            strSQL = strSQL & "       GOODSCD11 AS SCPMENU10,"
            strSQL = strSQL & "       GOODSCD12 AS SCPMENU11,"
            strSQL = strSQL & "       GOODSCD13 AS SCPMENU12,"
            strSQL = strSQL & "       GOODSCD14 AS SCPMENU13,"
            strSQL = strSQL & "       GOODSCD15 AS SCPMENU14,"
            strSQL = strSQL & "       GOODSCD16 AS SCPMENU15"
            strSQL = strSQL & "  FROM TPM100"
            strSQL = strSQL & " WHERE SCPNO = '" & Format$(CLng(Convert.ToUInt16(Trim$(Replace(BitConverter.ToString(bytData), "-", "")), 16).ToString), "000") & "'"
            objData = New DataSet()
            If Not GF_GetData(strSQL, objData) Then
                FileClose(intFile)
                GoTo SYSTEM_ERROR
            End If
            If objData.Tables("com").Rows.Count = 0 Then
                pResult = True
                FileClose(intFile)
                Exit Sub
            End If
            If Not GF_GetRows(objData, 0, objRows) Then
                FileClose(intFile)
                GoTo SYSTEM_ERROR
            End If

            ' --- (2003.12.02) �K�C�_���X�����̍��قɂ��Ă��`�F�b�N���� --
            ' ���݂���ꍇ�A�K�C�_���X�����͈�v���邩�H
            bytData = LF_GetBData(2, 20, intFile, lngCnt, 53)
            If Trim$(objRows("GUIDE")) <> Trim$(objSjisEnc.GetString(bytData)) Then
                pResult = True
                FileClose(intFile)
                Exit Sub
            End If
            ' --------------------------------------------------------------

            ' ���݂���ꍇ�A���j���[�R�[�h�͑S�Ĉ�v���邩�H
            For lngCol = 0 To 15
                bytData = LF_GetBData(22 + (lngCol * 2), 2, intFile, lngCnt, 53)
                If Trim$(objRows("SCPMENU" & CStr(lngCol))) <> Trim$(Replace(BitConverter.ToString(bytData), "-", "")) Then
                    pResult = True
                    FileClose(intFile)
                    Exit Sub
                End If
            Next

            lngCnt = lngCnt + 1
            objStatus.pgs_Status.Value = lngCnt
        End While
        FileClose(intFile)

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_ChkFSCP")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�[���@�ғ��󋵊m�F�O���b�h �����Z�b�g�A�b�v����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_GridSetup(ByVal pStatus As CNL1810)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objTs As New DataGridTableStyle()                               ' �V����DataGridTableStyle�̍쐬
        Dim lngCnt As Long
        Dim dtsData As New DataSet()
        Dim objTable As DataTable

        Try
            '------------------------------
            ' �e�[�u���X�^�C����`
            '------------------------------
            With objTs
                .MappingName = "UNMATCHLIST"                                      ' �}�b�v�����w��
                .PreferredRowHeight = 20                                        ' �W���s�����w��
            End With

            '------------------------------
            ' �e���ڑ�����`
            '------------------------------
            Call LF_SetColumns(L_udtGridCol)

            For lngCnt = 0 To UBound(L_udtGridCol)                                ' �e���`���e�[�u���X�^�C���ɒǉ�
                Call GS_GridAddColumn(L_udtGridCol(lngCnt), objTs)
            Next
            objTs.AllowSorting = False                                          ' �񌩏o���N���b�N�ɂ��\�[�g���֎~
            objTs.RowHeadersVisible = False

            With grd_UnmatchList
                .TableStyles.Clear()
                .TableStyles.Add(objTs)                                         ' �e�[�u���X�^�C����DataGrid�ɒǉ�
                .ReadOnly = True                                                ' �ҏW�֎~
            End With

            '------------------------------
            ' �O���b�h����
            '------------------------------
            L_objData = New DataSet("UnmatchList")
            objTable = New DataTable("UNMATCHLIST")
            For lngCnt = 0 To UBound(L_udtGridCol)
                Call GS_GridAddTable(L_udtGridCol(lngCnt), objTable)
            Next

            '------------------------------
            ' �f�[�^�l�ݒ�
            '------------------------------
            If Not LF_GetFUMENU(objTable, L_udtGridCol, pStatus) Then
                Exit Sub
            End If
            L_objData.Tables.Add(objTable)                                        ' �e�[�u����DataSet�ɒǉ�����
            Call LS_ChgDispStyle()                                              ' �S�s�\���w��ŁA�O���b�h�Ƀf�[�^�A������

        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GridSetup")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�[���@�ғ��󋵊m�F�O���b�h �����Z�b�g�A�b�v����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_GridSetup2(ByVal pStatus As CNL1810)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objTs As New DataGridTableStyle()                               ' �V����DataGridTableStyle�̍쐬
        Dim udtGridCol() As typGridColumn = Nothing
        Dim lngCnt As Long
        Dim dtsData As New DataSet()
        Dim dtsList As DataSet
        Dim objTable As DataTable

        Try
            '------------------------------
            ' �e�[�u���X�^�C����`
            '------------------------------
            With objTs
                .MappingName = "UNMATCHLIST"                                      ' �}�b�v�����w��
                .PreferredRowHeight = 20                                        ' �W���s�����w��
            End With

            '------------------------------
            ' �e���ڑ�����`
            '------------------------------
            Call LF_SetColumns(udtGridCol, "R")

            For lngCnt = 0 To UBound(udtGridCol)                                ' �e���`���e�[�u���X�^�C���ɒǉ�
                Call GS_GridAddColumn(udtGridCol(lngCnt), objTs)
            Next
            objTs.AllowSorting = False                                          ' �񌩏o���N���b�N�ɂ��\�[�g���֎~
            objTs.RowHeadersVisible = False

            With grd_ItemList
                .TableStyles.Clear()
                .TableStyles.Add(objTs)                                         ' �e�[�u���X�^�C����DataGrid�ɒǉ�
                .ReadOnly = True                                                ' �ҏW�֎~
            End With

            '------------------------------
            ' �O���b�h����
            '------------------------------
            dtsList = New DataSet("TermList")
            objTable = New DataTable("UNMATCHLIST")
            For lngCnt = 0 To UBound(udtGridCol)
                Call GS_GridAddTable(udtGridCol(lngCnt), objTable)
            Next

            '------------------------------
            ' �f�[�^�l�ݒ�
            '------------------------------
            If Not LF_GetUnmatchList(objTable, udtGridCol, pStatus) Then
                Exit Sub
            End If
            dtsList.Tables.Add(objTable)                                        ' �e�[�u����DataSet�ɒǉ�����
            grd_ItemList.SetDataBinding(dtsList, "UNMATCHLIST")                ' DataSet�ƃe�[�u����DataGrid�ɐڑ�����
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_GridSetup2")
    End Sub

    Private Sub LF_SetColumns(ByRef pGridCols() As typGridColumn, Optional ByVal pLR As String = "L")

        ReDim pGridCols(29)         '--- (2006.05.24) �������߁A�V��t���O�ǉ�
        'ReDim pGridCols(27)

        '------------------------------
        ' �����ڒ�`
        '------------------------------
        With pGridCols(0)
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "GOODSCD"
            .strHeadText = "���i�ԍ�"
            .blnAllowNull = False
            .lngWidth = 70
            .objAlign = HorizontalAlignment.Center
            .blnReadOnly = True
        End With
        With pGridCols(1)
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "GOODSNM"
            .strHeadText = "���i��"
            .blnAllowNull = False
            .lngWidth = 170
            .objAlign = HorizontalAlignment.Left
        End With
        With pGridCols(2)
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "PRICE"
            .strHeadText = "�P��"
            .blnAllowNull = False
            .lngWidth = 70
            .objAlign = HorizontalAlignment.Right
            .blnReadOnly = True
        End With
        With pGridCols(3)
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "JEXPNOTE"
            .strHeadText = "������"
            .blnAllowNull = False
            .lngWidth = IIf(pLR = "L", 239, 0)
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With

        '------------------------------
        ' �s�����ڒ�`
        '------------------------------
        With pGridCols(4)                                                   ' �摜�f�[�^�p�X
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "IMAGEDATA"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(5)                                                   ' �P��
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "UNITJ"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(6)                                                   ' �R�����g�P
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_COM1"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(7)                                                   ' �R�����g�Q
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_COM2"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(8)                                                   ' �R�����g�R
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_COM3"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(9)                                                   ' �R�����g�S
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_COM4"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(10)                                                  ' �T�u���j���[�P
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_SUB1"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(11)                                                  ' �T�u���j���[�Q
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_SUB2"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(12)                                                  ' �T�u���j���[�R
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_SUB3"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(13)                                                  ' �T�u���j���[�S
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_SUB4"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(14)                                                  ' �Z�b�g���j���[�P
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_SET1"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(15)                                                  ' �Z�b�g���j���[�Q
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_SET2"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(16)                                                  ' �Z�b�g���j���[�R
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_SET3"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(17)                                                  ' �Z�b�g���j���[�S
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SCP_SET4"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(18)                                                  ' ���i�X�e�[�^�X
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "STATUS"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(19)                                                  ' ���i����
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "GOODSKIND"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        ' --- (2003.11.28) ����R�[�h���ڂ�ǉ� ----------------------------
        With pGridCols(20)                                                  ' ����R�[�h
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "BUMONCD"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        ' ------------------------------------------------------------------
        ' --- (2003.11.28) �j�b�o�X�e�[�^�X���ڂ�ǉ� ----------------------
        With pGridCols(21)                                                  ' �j�b�o�X�e�[�^�X
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "KCPSTATUS"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        ' ------------------------------------------------------------------
        ' --- (2003.12.01) ���i���Q���ڂ�ǉ� ------------------------------
        With pGridCols(22)                                                  ' �j�b�o�X�e�[�^�X
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "GOODSNMJ2"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        ' ------------------------------------------------------------------
        ' --- (2003.12.01) ���i���Q���ڂ�ǉ� ------------------------------
        With pGridCols(23)                                                  ' �j�b�o�X�e�[�^�X
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "GOODSNMJ3"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        ' ------------------------------------------------------------------
        ' --- (2004.02.09) �^�b�`�p�l�����i���Q���ڂ�ǉ� ------------------
        With pGridCols(24)                                                  ' �^�b�`�p�l�����i���Q
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "GOODSNMJ4"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        ' ------------------------------------------------------------------
        With pGridCols(25)                                                  ' ���ݗL��
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "Exist"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With

        ' --- (2004.10.14) �g�s�k�p���̍��ڒǉ� ----------------------------
        With pGridCols(26)                                                  ' �g�s�k�p���̂P
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "HTLNM1"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(27)                                                  ' �g�s�k�p���̂Q
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "HTLNM2"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        ' ------------------------------------------------------------------
        '--- (2006.05.24) �������߁A�V��t���O�ǉ� -------------------------
        With pGridCols(28)                                                  ' �������߃t���O
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "SPFLG"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        With pGridCols(29)                                                  ' �V��t���O
            .intType = CNL1920.COLUMN_TYPE.TEXT_STYLE
            .strMapName = "NEWFLG"
            .strHeadText = ""
            .blnAllowNull = False
            .lngWidth = 0
            .objAlign = HorizontalAlignment.Left
            .blnReadOnly = True
        End With
        '-------------------------------------------------------------------

    End Sub

    'Private Function LF_GetTPM010(ByVal pData As DataSet, _
    '                              Optional ByVal pGoodsCd As String = "", _
    '                              Optional ByVal pGoodsNM As String = "", _
    '                              Optional ByVal pGoodsNM2 As String = "", _
    '                              Optional ByVal pPrice As String = "", _
    '                              Optional ByVal pSCPStat As String = "") As Boolean
    Private Function LF_GetTPM010(ByVal pData As DataSet, _
                                  Optional ByVal pGoodsCd As String = "", _
                                  Optional ByVal pGoodsNM As String = "", _
                                  Optional ByVal pGoodsNM2 As String = "", _
                                  Optional ByVal pPrice As String = "", _
                                  Optional ByVal pSCPStat As String = "", _
                                  Optional ByVal pBumonCD As String = "") As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTPM010 = False

        '------------------------------
        ' ���i�}�X�^�擾����
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM TPM010"
        If Len(Trim$(pGoodsCd)) <> 0 Then
            ' --- (2003.12.02) �}�b�`���O�L�[���A�i���݂̂ɕύX���� --------
            'strSQL = strSQL & " WHERE GOODSCD      = '" & pGoodsCd & "'"
            'strSQL = strSQL & "   AND GOODSNMJ     = '" & pGoodsNM & "'"
            'strSQL = strSQL & "   AND PRICE        = " & pPrice
            'strSQL = strSQL & "   AND SCPNO01 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 1, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO02 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 3, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO03 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 5, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO04 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 7, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO05 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 9, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO06 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 11, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO07 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 13, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO08 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 15, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO09 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 17, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO10 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 19, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO11 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 21, 2), 16).ToString), "000") & "'"
            'strSQL = strSQL & "   AND SCPNO12 = '" & Format$(CLng(Convert.ToUInt16(Mid$(pSCPStat, 23, 2), 16).ToString), "000") & "'"

            ' --- (2004.02.02) �o�n�r���i���ɑΉ� --------------------------
            'strSQL = strSQL & " WHERE GOODSNMJ     = '" & pGoodsNM & "'"
            'strSQL = strSQL & " WHERE GOODSNMJ3    = '" & pGoodsNM & "'"
            strSQL = strSQL & " WHERE GOODSNMJ4    = '" & pGoodsNM & "'"            '2006.06.28 CrossNavi���C
            ' --------------------------------------------------------------

            ' --- (2003.12.17) ���ꏤ�i���Ή� ------------------------------
            strSQL = strSQL & "   AND BUMONCD      = '" & pBumonCD & "'"
            ' --------------------------------------------------------------

            ' --------------------------------------------------------------
        Else
            strSQL = strSQL & " ORDER BY GOODSCD"
        End If
        If Not GF_GetData(strSQL, pData) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetTPM010 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ŐV���j���[�e�[�u���擾����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetFUMENU(ByRef pTable As DataTable, ByVal pGridCols() As typGridColumn, ByVal pStatus As CNL1810) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strFileNm As String
        Dim intFile As Integer
        Dim lngCnt As Long
        Dim bytData() As Byte
        Dim objSjisEnc As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")
        Dim objData As DataSet
        Dim objRows As DataRow = Nothing
        Dim objWRow As DataRow = Nothing
        Dim strGoodsCD As String
        Dim strGoodsNM As String
        Dim strBumonCD As String
        Dim strPrice As String
        Dim strSCPStat As String
        Dim strFStat As String
        Dim objFileInfo As System.IO.FileInfo = Nothing
        Dim lngFileRec As Long
        Dim udtSushi As typWidth
        Dim udtEtc As typWidth
        Dim udtSysItem As typWidth
        Dim udtPosItem As typWidth
        Dim strWork() As String
        Dim strBumon As String
        Dim lngBCnt As Long
        Dim blnFound As Boolean
        Dim strWK As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetFUMENU = False

        Try
            '------------------------------
            ' ���i���ޔ����l�擾
            '------------------------------
            udtSushi.strFrom = GF_GetAppInfo("GK_SUSHI_F")
            If Len(Trim$(udtSushi.strFrom)) = 0 Or Not IsNumeric(udtSushi.strFrom) Then
                Exit Function
            End If

            udtSushi.strTo = GF_GetAppInfo("GK_SUSHI_T")
            If Len(Trim$(udtSushi.strTo)) = 0 Or Not IsNumeric(udtSushi.strTo) Then
                Exit Function
            End If

            udtEtc.strFrom = GF_GetAppInfo("GK_ETC_F")
            If Len(Trim$(udtEtc.strFrom)) = 0 Or Not IsNumeric(udtEtc.strFrom) Then
                Exit Function
            End If

            udtEtc.strTo = GF_GetAppInfo("GK_ETC_T")
            If Len(Trim$(udtEtc.strTo)) = 0 Or Not IsNumeric(udtEtc.strTo) Then
                Exit Function
            End If

            udtSysItem.strFrom = GF_GetAppInfo("GK_SYSITEM_F")
            If Len(Trim$(udtSysItem.strFrom)) = 0 Or Not IsNumeric(udtSysItem.strFrom) Then
                Exit Function
            End If

            udtSysItem.strTo = GF_GetAppInfo("GK_SYSITEM_T")
            If Len(Trim$(udtSysItem.strTo)) = 0 Or Not IsNumeric(udtSysItem.strTo) Then
                Exit Function
            End If

            udtPosItem.strFrom = GF_GetAppInfo("GK_POSITEM_F")
            If Len(Trim$(udtPosItem.strFrom)) = 0 Or Not IsNumeric(udtPosItem.strFrom) Then
                Exit Function
            End If

            udtPosItem.strTo = GF_GetAppInfo("GK_POSITEM_T")
            If Len(Trim$(udtPosItem.strTo)) = 0 Or Not IsNumeric(udtPosItem.strTo) Then
                Exit Function
            End If

            '------------------------------
            ' ���j���[�e�[�u���I�[�v��
            '------------------------------
            strFileNm = GF_GetAppInfo("OES_PATH") & "\" & _
                        GF_GetAppInfo("OES_MENUTBL")
            objFileInfo = New System.IO.FileInfo(strFileNm)                 ' �t�@�C�����擾
            lngFileRec = objFileInfo.Length / 147
            objFileInfo = Nothing
            With pStatus
                .lbl_Msg.Text = "�ŐV�̃��j���[�}�X�^���擾���ł�..."
                .pgs_Status.Maximum = lngFileRec
                .pgs_Status.Value = 0
            End With
            System.Windows.Forms.Application.DoEvents()

            intFile = FreeFile()
            FileOpen(intFile, strFileNm, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
            lngCnt = 0
            While Not EOF(intFile)
                objRows = pTable.NewRow

                bytData = LF_GetBData(1, 2, intFile, lngCnt, 147)           ' ���i�R�[�h�擾
                objRows(pGridCols(0).strMapName) = Trim$(Replace(BitConverter.ToString(bytData), "-", ""))
                strGoodsCD = Trim$(Replace(BitConverter.ToString(bytData), "-", ""))

                bytData = LF_GetBData(3, 1, intFile, lngCnt, 147)           ' �����N�c�o�R�[�h(����R�[�h)�擾
                objRows(pGridCols(20).strMapName) = Trim$(Replace(BitConverter.ToString(bytData), "-", ""))
                strBumonCD = Trim$(Replace(BitConverter.ToString(bytData), "-", ""))

                bytData = LF_GetBData(37, 20, intFile, lngCnt, 147)         ' ���i���擾
                ' --- (2004.02.27) �Q�O�o�C�g�g���~���O���s�Ȃ� ------------
                'objRows(pGridCols(1).strMapName) = LF_WideCnv(RTrim$(objSjisEnc.GetString(bytData)))
                'strGoodsNM = LF_WideCnv(RTrim$(objSjisEnc.GetString(bytData)))
                objRows(pGridCols(1).strMapName) = GF_MidB(LF_WideCnv(RTrim$(objSjisEnc.GetString(bytData))), 1, 20)
                strGoodsNM = GF_MidB(LF_WideCnv(RTrim$(objSjisEnc.GetString(bytData))), 1, 20)
                ' ----------------------------------------------------------

                ' ---(2003.12.01) ���i���Q���ڒǉ� -------------------------
                bytData = LF_GetBData(57, 20, intFile, lngCnt, 147)         ' ���i���Q�擾
                ' --- (2004.02.27) �Q�O�o�C�g�g���~���O���s�Ȃ� ------------
                'objRows(pGridCols(22).strMapName) = LF_WideCnv(RTrim$(objSjisEnc.GetString(bytData)))
                objRows(pGridCols(22).strMapName) = GF_MidB(LF_WideCnv(RTrim$(objSjisEnc.GetString(bytData))), 1, 20)
                ' ----------------------------------------------------------
                ' ----------------------------------------------------------

                ' --- (2004.10.14) �g�s�k�p���̒ǉ� ------------------------
                bytData = LF_GetBData(77, 5, intFile, lngCnt, 147)          ' �g�s�k���̂P�擾
                objRows(pGridCols(26).strMapName) = GF_MidB(RTrim$(objSjisEnc.GetString(bytData)), 1, 5)
                bytData = LF_GetBData(82, 5, intFile, lngCnt, 147)          ' �g�s�k���̂Q�擾
                objRows(pGridCols(27).strMapName) = GF_MidB(RTrim$(objSjisEnc.GetString(bytData)), 1, 5)
                ' ----------------------------------------------------------

                bytData = LF_GetBData(87, 5, intFile, lngCnt, 147)          ' �P���擾
                objRows(pGridCols(2).strMapName) = Format$(CLng(Trim$(LF_SPKCnv(bytData, 2))), "#,##0")
                strPrice = Trim$(LF_SPKCnv(bytData, 2))

                bytData = LF_GetBData(103, 1, intFile, lngCnt, 147)        ' �@�\�X�e�[�^�X�Q�擾
                strFStat = Trim$(LF_BITCnv(bytData))

                ' --- (2003.12.09) �������擾�ł��Ȃ���Q�����C ------------
                ' --- (2003.11.28) �j�o�X�e�[�^�X�擾�ǉ� ------------------
                'bytData = LF_GetBData(105, 4, intFile, lngCnt, 147)       ' �j�o�X�e�[�^�X
                'objRows(pGridCols(21).strMapName) = Trim$(LF_BITCnv(bytData))
                ' ----------------------------------------------------------
                strWK = ""
                bytData = LF_GetBData(105, 1, intFile, lngCnt, 147)
                strWK = strWK & Trim$(LF_BITCnv(bytData))
                bytData = LF_GetBData(106, 1, intFile, lngCnt, 147)
                strWK = strWK & Trim$(LF_BITCnv(bytData))
                bytData = LF_GetBData(107, 1, intFile, lngCnt, 147)
                strWK = strWK & Trim$(LF_BITCnv(bytData))
                bytData = LF_GetBData(108, 1, intFile, lngCnt, 147)
                strWK = strWK & Trim$(LF_BITCnv(bytData))
                objRows(pGridCols(21).strMapName) = strWK
                ' ----------------------------------------------------------

                bytData = LF_GetBData(112, 12, intFile, lngCnt, 147)        ' SCP�X�e�[�^�X�擾
                strSCPStat = Replace(BitConverter.ToString(bytData), "-", "")

                bytData = LF_GetBData(147, 1, intFile, lngCnt, 147)        ' ���R�[�h�ŏI�_�܂œǂݐi�߂�(Dummy)

                '------------------------------
                ' ���S��v���R�[�h����
                '------------------------------
                objData = New DataSet()                                     ' �������擾

                'If Not LF_GetTPM010(objData, strGoodsCD, strGoodsNM, "", strPrice, strSCPStat) Then
                If Not LF_GetTPM010(objData, strGoodsCD, strGoodsNM, "", strPrice, strSCPStat, strBumonCD) Then
                    Exit Function
                End If
                If objData.Tables("com").Rows.Count <> 0 Then
                    If Not GF_GetRows(objData, 0, objWRow) Then
                        Exit Function
                    End If
                    ' --- (2003.12.02) ���s�^�O�B���΍� --------------------
                    'objRows(pGridCols(3).strMapName) = Trim$(objWRow("JEXPNOTEJ"))      ' ������
                    objRows(pGridCols(3).strMapName) = Trim$(Replace(Trim$(objWRow("JEXPNOTEJ")), "<BR>", vbCrLf))    ' ������
                    ' ------------------------------------------------------
                    objRows(pGridCols(4).strMapName) = Trim$(objWRow("IMAGEDATA"))      ' �摜�f�[�^
                    objRows(pGridCols(5).strMapName) = Trim$(objWRow("UNITJ"))          ' �P��
                    ' --- (2004.02.02) �^�b�`�p�l�����i�����p�Ή� ----------

                    ' --- (2004.02.27) �����]�����폜���Ȃ��悤�ɂ��� ------
                    'objRows(pGridCols(23).strMapName) = Trim$(objWRow("GOODSNMJ"))
                    objRows(pGridCols(23).strMapName) = RTrim$(objWRow("GOODSNMJ"))
                    ' ------------------------------------------------------

                    ' ------------------------------------------------------
                    ' --- (2004.02.09) �^�b�`�p�l�����i���Q���p�Ή� --------
                    ' --- (2004.02.27) �����]�����폜���Ȃ��悤�ɂ��� ------
                    'objRows(pGridCols(24).strMapName) = Trim$(objWRow("GOODSNMJ2"))
                    objRows(pGridCols(24).strMapName) = RTrim$(objWRow("GOODSNMJ2"))
                    ' ------------------------------------------------------
                    ' ------------------------------------------------------

                    ' --- (2004.02.09) �P�������@�\�ǉ� --------------------
                    If L_PriceEdit = GC_TRUE Then
                        objRows(pGridCols(2).strMapName) = Trim$(objWRow("PRICE"))
                    End If
                    ' ------------------------------------------------------

                    objRows(pGridCols(25).strMapName) = "1"

                    '--- (2006.05.24) �������߁A�V��t���O�ǉ� -------------
                    objRows(pGridCols(28).strMapName) = Trim$(objWRow("SPFLG"))
                    objRows(pGridCols(29).strMapName) = Trim$(objWRow("NEWFLG"))
                    '-------------------------------------------------------
                Else
                    objRows(pGridCols(3).strMapName) = LC_NODATA            ' ������
                    objRows(pGridCols(4).strMapName) = ""                   ' �摜�f�[�^
                    objRows(pGridCols(5).strMapName) = ""                   ' �P��
                    ' --- (2004.02.02) �^�b�`�p�l�����i�����p�Ή� ----------
                    objRows(pGridCols(23).strMapName) = strGoodsNM
                    ' ------------------------------------------------------
                    ' --- (2004.02.09) �^�b�`�p�l�����i���Q���p�Ή� --------
                    objRows(pGridCols(24).strMapName) = ""
                    ' ------------------------------------------------------
                    objRows(pGridCols(25).strMapName) = "0"
                    '--- (2006.05.24) �������߁A�V��t���O�ǉ� -------------
                    objRows(pGridCols(28).strMapName) = "0"
                    objRows(pGridCols(29).strMapName) = "0"
                    '-------------------------------------------------------
                End If
                ' �R�����g�P�`�S
                objRows(pGridCols(6).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 1, 2), 16).ToString), "000")
                objRows(pGridCols(7).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 3, 2), 16).ToString), "000")
                objRows(pGridCols(8).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 5, 2), 16).ToString), "000")
                objRows(pGridCols(9).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 7, 2), 16).ToString), "000")
                ' �T�u���j���[�P�`�S
                objRows(pGridCols(10).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 9, 2), 16).ToString), "000")
                objRows(pGridCols(11).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 11, 2), 16).ToString), "000")
                objRows(pGridCols(12).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 13, 2), 16).ToString), "000")
                objRows(pGridCols(13).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 15, 2), 16).ToString), "000")
                ' �Z�b�g���j���[�P�`�S
                objRows(pGridCols(14).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 17, 2), 16).ToString), "000")
                objRows(pGridCols(15).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 19, 2), 16).ToString), "000")
                objRows(pGridCols(16).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 21, 2), 16).ToString), "000")
                objRows(pGridCols(17).strMapName) = Format$(CLng(Convert.ToUInt16(Mid$(strSCPStat, 23, 2), 16).ToString), "000")

                Select Case Mid$(strFStat, 6, 3)
                    Case "000" : strFStat = "0"
                    Case "001" : strFStat = "1"
                    Case "010" : strFStat = "2"
                    Case "100" : strFStat = "3"
                    Case Else : strFStat = "9"
                End Select
                objRows(pGridCols(18).strMapName) = strFStat

                Select Case CLng(strGoodsCD)
                    Case CLng(udtSysItem.strFrom) To CLng(udtSysItem.strTo)
                        objRows(pGridCols(19).strMapName) = "2"
                    Case CLng(udtPosItem.strFrom) To CLng(udtPosItem.strTo)
                        objRows(pGridCols(19).strMapName) = "3"
                    Case Else
                        strBumon = GF_GetAppInfo("SUSHI_BUMON")
                        ' --- (2003.11.17) �u���i�v���i���蕔����w�肵�Ȃ��ꍇ�ɑΉ����� ---
                        'If Len(Trim$(strBumon)) = 0 Then
                        '    Exit Function
                        'End If
                        blnFound = False
                        If Len(Trim$(strBumon)) <> 0 Then
                            strWork = Split(strBumon, "@")
                            For lngBCnt = 0 To UBound(strWork)
                                If strWork(lngBCnt) = strBumonCD Then
                                    blnFound = True
                                    Exit For
                                End If
                            Next
                        End If
                        ' -----------------------------------------------------------------
                        If blnFound Then
                            objRows(pGridCols(19).strMapName) = "0"
                        Else
                            objRows(pGridCols(19).strMapName) = "1"
                        End If
                End Select

                pTable.Rows.Add(objRows)
                lngCnt = lngCnt + 1
                pStatus.pgs_Status.Value = lngCnt
            End While
            FileClose(intFile)
        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetFUMENU = True

    End Function

    Private Function LF_WideCnv(ByVal pStr As String) As String
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngCnt As Long
        Dim strWork As String
        Dim strRet As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_WideCnv = ""
        strRet = ""

        '------------------------------
        ' �S�p�ϊ�����
        '------------------------------
        For lngCnt = 1 To Len(pStr)
            strWork = Mid$(pStr, lngCnt, 1)
            ' 2014-05-12 2�o�C�g������������
            'If strWork <> "m" And strWork <> "l" Then
            '    strRet = strRet & StrConv(strWork, VbStrConv.Wide)
            'Else
                strRet = strRet & strWork
            'End If
        Next

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_WideCnv = strRet

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�A���}�b�`���X�g
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetUnmatchList(ByRef pTable As DataTable, ByVal pGridCols() As typGridColumn, ByVal pStatus As CNL1810) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim objWRow As DataRow = Nothing
        Dim objWRow2 As DataRow = Nothing
        Dim lngCnt As Long
        Dim lngGridCnt As Long
        Dim blnFound As Boolean

        Dim strWGoodsCD As String
        Dim strWGoodsNM As String
        Dim strWPrice As String
        Dim strWSCPStat As String

        Dim strDGoodsCD As String
        Dim strDGoodsNM As String
        Dim strDPrice As String
        Dim strDSCPStat As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetUnmatchList = False

        '------------------------------
        ' ���i�}�X�^�S���擾
        '------------------------------
        If Not LF_GetTPM010(objData) Then
            Exit Function
        End If

        With pStatus
            .lbl_Msg.Text = "���j���[�e�[�u���̉ߕs�����m�F���ł�..."
            .pgs_Status.Maximum = objData.Tables("com").Rows.Count
            .pgs_Status.Value = 0
        End With
        System.Windows.Forms.Application.DoEvents()

        Try
            '------------------------------
            ' ���j���[�e�[�u���I�[�v��
            '------------------------------
            While lngCnt < objData.Tables("com").Rows.Count
                If Not GF_GetRows(objData, lngCnt, objWRow) Then
                    Exit Function
                End If

                blnFound = False
                strDGoodsCD = Trim$(objWRow("GOODSCD"))

                ' --- (2004.02.02) �o�n�r���i�����ڂ֕ύX -----------------------------
                'strDGoodsNM = Trim$(objWRow("GOODSNMJ"))
                strDGoodsNM = Trim$(objWRow("GOODSNMJ3"))
                ' ---------------------------------------------------------------------

                strDPrice = Format$(CLng(Trim$(objWRow("PRICE"))), "#,##0")
                strDSCPStat = Trim$(objWRow("SCPNO01")) & _
                              Trim$(objWRow("SCPNO02")) & _
                              Trim$(objWRow("SCPNO03")) & _
                              Trim$(objWRow("SCPNO04")) & _
                              Trim$(objWRow("SCPNO05")) & _
                              Trim$(objWRow("SCPNO06")) & _
                              Trim$(objWRow("SCPNO07")) & _
                              Trim$(objWRow("SCPNO08")) & _
                              Trim$(objWRow("SCPNO09")) & _
                              Trim$(objWRow("SCPNO10")) & _
                              Trim$(objWRow("SCPNO11")) & _
                              Trim$(objWRow("SCPNO12"))

                For lngGridCnt = 0 To L_objData.Tables("UNMATCHLIST").Rows.Count - 1
                    objWRow2 = L_objData.Tables("UNMATCHLIST").Rows(lngGridCnt)
                    strWGoodsCD = Trim$(objWRow2(L_udtGridCol(0).strMapName))
                    strWGoodsNM = Trim$(objWRow2(L_udtGridCol(1).strMapName))
                    strWPrice = Trim$(objWRow2(L_udtGridCol(2).strMapName))
                    strWSCPStat = Trim$(objWRow2(L_udtGridCol(6).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(7).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(8).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(9).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(10).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(11).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(12).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(13).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(14).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(15).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(16).strMapName)) & _
                                  Trim$(objWRow2(L_udtGridCol(17).strMapName))

                    'If strWGoodsCD = strDGoodsCD And _
                    '   strWGoodsNM = strDGoodsNM And _
                    '   strWPrice = strDPrice And _
                    '   strWSCPStat = strDSCPStat Then

                    ' --- (2003.12.01) �������o�������A���i���݂̂ɕύX ----
                    'If strWGoodsCD = strDGoodsCD And _
                    '   strWGoodsNM = strDGoodsNM Then
                    '    blnFound = True
                    '    Exit For
                    'End If
                    If strWGoodsNM = strDGoodsNM Then
                        blnFound = True
                        Exit For
                    End If
                    ' ------------------------------------------------------
                Next

                If blnFound = False Then
                    objRows = pTable.NewRow
                    objRows(pGridCols(0).strMapName) = Trim$(objWRow("GOODSCD"))
                    ' --- (2004.02.02) �o�n�r���i���֕\�����ڕύX ----------
                    'objRows(pGridCols(1).strMapName) = Trim$(objWRow("GOODSNMJ"))
                    objRows(pGridCols(1).strMapName) = Trim$(objWRow("GOODSNMJ3"))
                    ' ------------------------------------------------------
                    objRows(pGridCols(2).strMapName) = Format$(CLng(Trim$(objWRow("PRICE"))), "#,##0")

                    ' --- (2003.12.02) ���s�^�O�B���΍� --------------------
                    'objRows(pGridCols(3).strMapName) = Trim$(objWRow("JEXPNOTEJ"))
                    objRows(pGridCols(3).strMapName) = Trim$(Replace(Trim$(objWRow("JEXPNOTEJ")), "<BR>", vbCrLf))
                    ' ------------------------------------------------------

                    objRows(pGridCols(4).strMapName) = Trim$(objWRow("IMAGEDATA"))
                    objRows(pGridCols(5).strMapName) = Trim$(objWRow("UNITJ"))
                    objRows(pGridCols(6).strMapName) = Trim$(objWRow("SCPNO01"))
                    objRows(pGridCols(7).strMapName) = Trim$(objWRow("SCPNO02"))
                    objRows(pGridCols(8).strMapName) = Trim$(objWRow("SCPNO03"))
                    objRows(pGridCols(9).strMapName) = Trim$(objWRow("SCPNO04"))
                    objRows(pGridCols(10).strMapName) = Trim$(objWRow("SCPNO05"))
                    objRows(pGridCols(11).strMapName) = Trim$(objWRow("SCPNO06"))
                    objRows(pGridCols(12).strMapName) = Trim$(objWRow("SCPNO07"))
                    objRows(pGridCols(13).strMapName) = Trim$(objWRow("SCPNO08"))
                    objRows(pGridCols(14).strMapName) = Trim$(objWRow("SCPNO09"))
                    objRows(pGridCols(15).strMapName) = Trim$(objWRow("SCPNO10"))
                    objRows(pGridCols(16).strMapName) = Trim$(objWRow("SCPNO11"))
                    objRows(pGridCols(17).strMapName) = Trim$(objWRow("SCPNO12"))
                    ' --- (2004.02.02) �^�b�`�p�l�����i�����p�Ή� ----------
                    objRows(pGridCols(23).strMapName) = Trim$(objWRow("GOODSNMJ"))
                    ' ------------------------------------------------------
                    ' --- (2004.02.09) �^�b�`�p�l�����i���Q���p�Ή� --------
                    objRows(pGridCols(24).strMapName) = Trim$(objWRow("GOODSNMJ2"))
                    ' ------------------------------------------------------
                    objRows(pGridCols(25).strMapName) = "0"

                    ' --- (2004.10.14) �g�s�k�p���̍��ڒǉ� ----------------
                    objRows(pGridCols(26).strMapName) = Trim$(objWRow("HTLNM1"))
                    objRows(pGridCols(27).strMapName) = Trim$(objWRow("HTLNM2"))
                    ' ------------------------------------------------------

                    '--- (2006.05.24) �������߁A�V��t���O�Ή� -------------
                    objRows(pGridCols(28).strMapName) = Trim$(objWRow("SPFLG"))
                    objRows(pGridCols(29).strMapName) = Trim$(objWRow("NEWFLG"))
                    '-------------------------------------------------------

                    pTable.Rows.Add(objRows)
                End If

                lngCnt = lngCnt + 1
                pStatus.pgs_Status.Value = lngCnt
            End While

        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetUnmatchList = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�o�C�i���f�[�^�ǂݍ��ݏ���
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_GetBData(ByVal pStartBit As Integer, _
                                 ByVal pReadLength As Integer, _
                                 ByVal pFileNo As Integer, _
                                 ByVal pRecord As Long, _
                                 ByVal pFullRecLength As Long) As Byte()

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim bytBuff() As Byte

        '------------------------------
        ' �擾�̈�Ē�`
        '------------------------------
        ReDim bytBuff(pReadLength - 1)

        '------------------------------
        ' �f�[�^�擾
        '------------------------------
        FileGet(pFileNo, bytBuff(pReadLength - 1), pStartBit + (pFullRecLength * pRecord))

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetBData = bytBuff

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�o�C�i���f�[�^(�r�o�j����)���l��
    ' �@�@�\�T�v�F�T�C���t���p�b�N10�i�� Double �^�ŕԋp����
    ' �@���@�@���FpSubLen : ��������
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_SPKCnv(ByVal pOrg() As Byte, ByVal pSubLen As Integer) As Double

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strWork As String

        strWork = Replace(BitConverter.ToString(pOrg), "-", "")

        LF_SPKCnv = CDbl(Mid$(strWork, 1, (Len(strWork) - 1) - pSubLen))    ' ������
        If pSubLen > 0 Then
            LF_SPKCnv = LF_SPKCnv + CDbl(Mid$(strWork, Len(strWork) - pSubLen, pSubLen)) * (-10 ^ pSubLen)
        End If
        If Mid$(strWork, Len(strWork)) <> "C" Then
            LF_SPKCnv = LF_SPKCnv * -1
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�o�C�i���f�[�^(�r�o�j����)���l��
    ' �@�@�\�T�v�F�T�C���t���p�b�N10�i�� Double �^�ŕԋp����
    ' �@���@�@���FpSubLen : ��������
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_BITCnv(ByVal pOrg() As Byte) As String

        Dim strFmt As String = New String("0", (UBound(pOrg) + 1) * 8)
        LF_BITCnv = Format$(CDbl(Convert.ToString(Convert.ToInt32(Replace(BitConverter.ToString(pOrg), "-", ""), 16), 2)), strFmt)

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�s��v���o�O���b�h �h���b�O�J�n����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub grd_ItemList_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grd_ItemList.MouseDown
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCell As DataGridCell
        Dim objHitTest As DataGrid.HitTestInfo
        Dim objPoint As Point

        objPoint = grd_ItemList.PointToClient(Cursor.Position)
        objHitTest = grd_ItemList.HitTest(objPoint)
        If objHitTest.Row <> -1 Then
            objCell.RowNumber = objHitTest.Row
            grd_ItemList.CurrentCell = objCell
        End If

        '���W�ʒu����A�L���͈͊O�ł���΁A�����𖳌��Ƃ���
        If objHitTest.Row < 0 Or objHitTest.Column < 0 Then
            Exit Sub
        End If

        If grd_ItemList.VisibleRowCount >= 1 Then
            'DoDragDrop(CStr(grd_ItemList(lngRow, 0)), DragDropEffects.Copy)
            DoDragDrop(CStr(grd_ItemList(objHitTest.Row, 0)), DragDropEffects.Copy)
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�s��v���o�O���b�h �h���b�O������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub grd_ItemList_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grd_ItemList.DragOver
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�s��v���o�O���b�h �J�����g�J�[�\���ω�������
    ' �@�@�\�T�v�F�s�I����Ԃɂ���
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub grd_ItemList_CursorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_ItemList.CursorChanged
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCell As DataGridCell = grd_ItemList.CurrentCell
        Dim lngRow As Long = objCell.RowNumber

        If grd_ItemList.VisibleRowCount >= 1 Then
            grd_ItemList.Select(lngRow)
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ŐV���O���b�h �h���b�v����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub grd_UnmatchList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grd_UnmatchList.DragDrop
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngCnt As Long
        Dim lngGridCnt As Long
        Dim blnFound As Boolean
        Dim objCell As DataGridCell = grd_UnmatchList.CurrentCell

        blnFound = False
        For lngGridCnt = 0 To GF_GetRowCnt(grd_ItemList) - 1
            If e.Data.GetData(DataFormats.Text) = grd_ItemList(lngGridCnt, 0) Then
                blnFound = True
                Exit For
            End If
        Next

        If blnFound = True Then
            If grd_UnmatchList(objCell.RowNumber, 25) <> "0" Then
                If GF_Msg("Q09", "", MsgBoxStyle.OKCancel, MsgBoxStyle.Question) = MsgBoxResult.Cancel Then
                    Exit Sub
                End If
            End If

            ' --- (2004.02.09) �P�������@�\�ǉ� ----------------------------
            'For lngCnt = 3 To 5
            '    grd_UnmatchList(objCell.RowNumber, lngCnt) = grd_ItemList(lngGridCnt, lngCnt)
            'Next
            For lngCnt = IIf(L_PriceEdit = GC_TRUE, 2, 3) To 5
                grd_UnmatchList(objCell.RowNumber, lngCnt) = grd_ItemList(lngGridCnt, lngCnt)
            Next
            ' --------------------------------------------------------------

            ' --- (2004.02.02) �^�b�`�p�l�����i�����p�Ή� ------------------
            grd_UnmatchList(objCell.RowNumber, 23) = grd_ItemList(lngGridCnt, 23)
            ' --------------------------------------------------------------

            L_blnEditFlg = True
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ŐV���O���b�h �h���b�O������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub grd_UnmatchList_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grd_UnmatchList.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ŐV���O���b�h �h���b�O������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub grd_UnmatchList_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grd_UnmatchList.DragOver
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objPoint As Point = grd_UnmatchList.PointToClient(Cursor.Position)
        Dim objCell As DataGridCell
        Dim objHitTest As System.Windows.Forms.DataGrid.HitTestInfo

        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            '���W�ʒu����A�J�����g�s��ύX����
            objHitTest = grd_UnmatchList.HitTest(objPoint)
            If objHitTest.Row <> -1 Then
                objCell.RowNumber = objHitTest.Row
                grd_UnmatchList.CurrentCell = objCell
            End If

            e.Effect = DragDropEffects.Copy
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ŐV���O���b�h �J�����g�J�[�\���ω�������
    ' �@�@�\�T�v�F�s�I����Ԃɂ���
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub grd_UnmatchList_CursorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_UnmatchList.CursorChanged
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objCell As DataGridCell = grd_UnmatchList.CurrentCell
        Dim lngRow As Long = objCell.RowNumber
        Dim lngCnt As Long

        If grd_UnmatchList.VisibleRowCount >= 1 Then
            For lngCnt = 0 To GF_GetRowCnt(grd_UnmatchList) - 1
                grd_UnmatchList.UnSelect(lngCnt)
            Next
            grd_UnmatchList.Select(lngRow)
        End If
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�ۑ��{�^������������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�\���f�[�^�ۑ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Sub LS_SaveAllData()

        Me.Cursor = Cursors.WaitCursor

        If Not GF_BeginTrans() Then                                         ' �g�����U�N�V�����J�n����
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' ���j���[�}�X�^�X�V
        '------------------------------
        If Not LF_UpdTPM010() Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �r�b�o�}�X�^�X�V
        '------------------------------
        If Not LF_UpdTPM100() Then
            GoTo SYSTEM_ERROR
        End If

        ' --- (2003.11.20) ���݂��Ȃ��Ȃ������i�R�[�h�ɂ��āA�W�������}�X�^����폜���� ---
        '------------------------------
        ' �W�������}�X�^�X�V
        '------------------------------
        If Not LF_UpdTPM020() Then
            GoTo SYSTEM_ERROR
        End If
        ' -----------------------------------------------------------------------------------

        ' --- (2003.11.28) ����}�X�^����荞�� ----------------------------
        '------------------------------
        ' ����}�X�^�X�V
        '------------------------------
        If Not LF_UpdTPM110() Then
            GoTo SYSTEM_ERROR
        End If
        ' ------------------------------------------------------------------

        If Not GF_CommitTrans() Then                                        ' �g�����U�N�V�����m�菈��
            GoTo SYSTEM_ERROR
        End If

        ' --- (2003.12.02) ���g�p���i�摜�K�x�[�W�����ǉ� ------------------
        If Not LF_DelUnuseFile() Then
            ' �X�V�����m���̃t�@�C���폜�����ŃG���[�ƂȂ��Ă��A���[���o�b�N�����Ȃ�
            Call GS_ErrorTerm("LS_SaveAllData")
        End If
        ' ------------------------------------------------------------------

        Me.Cursor = Cursors.Default

        Exit Sub

SYSTEM_ERROR:
        Me.Cursor = Cursors.Default
        Call GF_RollbackTrans()                                             ' �g�����U�N�V�����j��
        Call GS_ErrorTerm("LS_SaveAllData")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F����}�X�^(TPM110)�X�V����
    ' �@�@�\�T�v�F����}�X�^(�c�o�e�[�u��)���ATPM110 �֓]�L����
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.11.28 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM110() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim strFileNM As String
        Dim intFile As Integer
        Dim lngCnt As Long
        Dim bytData() As Byte
        Dim objSjisEnc As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM110 = False

        '------------------------------
        ' ����}�X�^��S���폜
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE FROM TPM110"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        strFileNM = GF_GetAppInfo("OES_PATH") & "\" & _
                    GF_GetAppInfo("OES_DPTBL")
        intFile = FreeFile()
        FileOpen(intFile, strFileNM, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
        lngCnt = 0
        While Not EOF(intFile)
            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM110 VALUES("

            bytData = LF_GetBData(1, 1, intFile, lngCnt, 75)

            If Trim$(Replace(BitConverter.ToString(bytData), "-", "")) <> "00" Then
                strSQL = strSQL & "'" & Trim$(Replace(BitConverter.ToString(bytData), "-", "")) & "',"

                bytData = LF_GetBData(19, 16, intFile, lngCnt, 75)
                strSQL = strSQL & "'" & IIf(Len(Trim$(objSjisEnc.GetString(bytData))) <> 0, Trim$(objSjisEnc.GetString(bytData)), Space(1)) & "',"

                strSQL = strSQL & "'" & GC_UPDID & "',"
                strSQL = strSQL & "'" & Now & "')"
                If Not GF_UpdData(strSQL) Then
                    GoTo SYSTEM_ERROR
                End If
            End If

            lngCnt = lngCnt + 1
        End While
        FileClose(intFile)

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM110 = True
        Exit Function

SYSTEM_ERROR:
        FileClose(intFile)
        Exit Function
    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�W�������}�X�^(TPM020)�X�V����
    ' �@�@�\�T�v�F�Ď�荞�݂ɂ���āA���݂��Ȃ��Ȃ������i�R�[�h���A�W�������}�X�^����
    '             �폜����
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.11.20 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM020() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM020 = False

        '------------------------------
        ' �s�v���R�[�h�폜
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE"
        strSQL = strSQL & "  FROM TPM020"
        strSQL = strSQL & " WHERE TPM020.GOODSCD <> '0000'"
        strSQL = strSQL & "   AND TPM020.GOODSCD NOT IN (SELECT TPM010.GOODSCD FROM TPM010)"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM020 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���j���[�}�X�^(TPM010)�X�V����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM010() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim lngCnt As Long
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM010 = False

        '------------------------------
        ' �S���폜
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE FROM TPM010"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        For lngCnt = 0 To L_objData.Tables("UNMATCHLIST").Rows.Count - 1
            objRows = L_objData.Tables("UNMATCHLIST").Rows(lngCnt)
            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM010 VALUES("
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(0).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(0).strMapName))), Space(1)) & "',"

            ' --- (2004.02.02) �擾�����ڕύX-------------------------------
            'strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(1).strMapName))) <> 0, GF_RepQuo(GF_MidB(Trim$(objRows(L_udtGridCol(1).strMapName)), 1, 20)), Space(1)) & "',"

            ' --- (2004.02.27) ���]�����폜���Ȃ��悤�ɂ��� ----------------
            'strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(23).strMapName))) <> 0, GF_RepQuo(GF_MidB(Trim$(objRows(L_udtGridCol(23).strMapName)), 1, 20)), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(23).strMapName))) <> 0, GF_RepQuo(GF_MidB(RTrim$(objRows(L_udtGridCol(23).strMapName)), 1, 20)), Space(1)) & "',"
            ' --------------------------------------------------------------

            ' --------------------------------------------------------------

            ' --- (2004.02.09) �^�b�`�p�l�����i���Q���ڒǉ� ----------------
            ' --- (2003.12.01) ���i���Q���ڒǉ� ----------------------------
            ''strSQL = strSQL & "'" & Space(1) & "',"
            'strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(22).strMapName))) <> 0, GF_RepQuo(GF_MidB(Trim$(objRows(L_udtGridCol(22).strMapName)), 1, 20)), Space(1)) & "',"

            ' --- (2004.02.27) ���]�����폜���Ȃ��悤�ɂ��� ----------------
            'strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(24).strMapName))) <> 0, GF_RepQuo(GF_MidB(Trim$(objRows(L_udtGridCol(24).strMapName)), 1, 20)), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(24).strMapName))) <> 0, GF_RepQuo(GF_MidB(RTrim$(objRows(L_udtGridCol(24).strMapName)), 1, 20)), Space(1)) & "',"
            ' --------------------------------------------------------------

            ' --------------------------------------------------------------
            ' --------------------------------------------------------------

            ' --- (2004.02.02) �o�n�r���i�����ڒǉ� ------------------------
            ' --- (2004.02.27) ���]�����폜���Ȃ��悤�ɂ��� ----------------
            'strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(1).strMapName))) <> 0, GF_RepQuo(GF_MidB(Trim$(objRows(L_udtGridCol(1).strMapName)), 1, 20)), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(1).strMapName))) <> 0, GF_RepQuo(GF_MidB(RTrim$(objRows(L_udtGridCol(1).strMapName)), 1, 20)), Space(1)) & "',"
            ' --------------------------------------------------------------
            ' --------------------------------------------------------------

            ' --- (2004.02.09) �^�b�`�p�l�����i���Q���ڒǉ� ----------------
            ' --- (2004.02.27) ���]�����폜���Ȃ��悤�ɂ��� ----------------
            'strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(22).strMapName))) <> 0, GF_RepQuo(GF_MidB(Trim$(objRows(L_udtGridCol(22).strMapName)), 1, 20)), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(22).strMapName))) <> 0, GF_RepQuo(GF_MidB(RTrim$(objRows(L_udtGridCol(22).strMapName)), 1, 20)), Space(1)) & "',"
            ' --------------------------------------------------------------
            ' --------------------------------------------------------------

            ' --- (2003.12.02) ���s�^�O�B���΍� ----------------------------
            'strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(3).strMapName))) <> 0 And Trim$(objRows(L_udtGridCol(3).strMapName)) <> LC_NODATA, GF_RepQuo(Trim$(objRows(L_udtGridCol(3).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(3).strMapName))) <> 0 And Trim$(objRows(L_udtGridCol(3).strMapName)) <> LC_NODATA, GF_RepQuo(Replace(Trim$(objRows(L_udtGridCol(3).strMapName)), vbCrLf, "<BR>")), Space(1)) & "',"
            ' --------------------------------------------------------------

            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(4).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(4).strMapName))), Space(1)) & "',"
            strSQL = strSQL & CLng(GF_RepQuo(Trim$(objRows(L_udtGridCol(2).strMapName)))) & ","
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(5).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(5).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & GC_TRUE & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(6).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(6).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(7).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(7).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(8).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(8).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(9).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(9).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(10).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(10).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(11).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(11).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(12).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(12).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(13).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(13).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(14).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(14).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(15).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(15).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(16).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(16).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(17).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(17).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(18).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(18).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(19).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(19).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(20).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(20).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(21).strMapName))) <> 0, GF_RepQuo(Trim$(objRows(L_udtGridCol(21).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & GC_TRUE & "',"

            ' --- (2004.10.14) �g�s�k�p���̍��ڒǉ� ------------------------
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(26).strMapName))) <> 0, GF_RepQuo(GF_MidB(RTrim$(objRows(L_udtGridCol(26).strMapName)), 1, 5)), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(27).strMapName))) <> 0, GF_RepQuo(GF_MidB(RTrim$(objRows(L_udtGridCol(27).strMapName)), 1, 5)), Space(1)) & "',"
            ' --------------------------------------------------------------

            '--- (2006.05.24) �������߁A�V��t���O�Ή� ---------------------
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(28).strMapName))) <> 0, GF_RepQuo(RTrim$(objRows(L_udtGridCol(28).strMapName))), Space(1)) & "',"
            strSQL = strSQL & "'" & IIf(Len(Trim$(objRows(L_udtGridCol(29).strMapName))) <> 0, GF_RepQuo(RTrim$(objRows(L_udtGridCol(29).strMapName))), Space(1)) & "',"
            '---------------------------------------------------------------

            strSQL = strSQL & "'" & GC_UPDID & "',"
            strSQL = strSQL & "'" & Now & "')"
            If Not GF_UpdData(strSQL) Then
                Exit Function
            End If
        Next

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM010 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�r�b�o�}�X�^(TPM100)�X�V����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM100() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim lngCnt As Long
        Dim lngCol As Long
        Dim strFileNM As String
        Dim intFile As Integer
        Dim bytData() As Byte
        Dim objSjisEnc As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_UpdTPM100 = False

        '------------------------------
        ' �S���폜
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE FROM TPM100"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        strFileNM = GF_GetAppInfo("OES_PATH") & "\" & _
                    GF_GetAppInfo("OES_SCPTBL")
        intFile = FreeFile()
        FileOpen(intFile, strFileNM, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
        lngCnt = 0
        While Not EOF(intFile)
            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM100 VALUES("

            bytData = LF_GetBData(1, 1, intFile, lngCnt, 53)
            strSQL = strSQL & "'" & Format$(CLng(Convert.ToUInt16(Trim$(Replace(BitConverter.ToString(bytData), "-", "")), 16).ToString), "000") & "',"

            bytData = LF_GetBData(2, 20, intFile, lngCnt, 53)
            strSQL = strSQL & "'" & IIf(Len(Trim$(objSjisEnc.GetString(bytData))) <> 0, Trim$(objSjisEnc.GetString(bytData)), Space(1)) & "',"

            For lngCol = 0 To 15
                bytData = LF_GetBData(22 + (lngCol * 2), 2, intFile, lngCnt, 53)
                strSQL = strSQL & "'" & Trim$(Replace(BitConverter.ToString(bytData), "-", "")) & "',"
            Next

            strSQL = strSQL & "'" & GC_UPDID & "',"
            strSQL = strSQL & "'" & Now & "')"
            If Not GF_UpdData(strSQL) Then
                GoTo SYSTEM_ERROR
            End If

            lngCnt = lngCnt + 1
        End While
        FileClose(intFile)

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_UpdTPM100 = True
        Exit Function

SYSTEM_ERROR:
        FileClose(intFile)
        Exit Function
    End Function

    Private Sub cbo_SelRow_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_SelRow.SelectionChangeCommitted

        '------------------------------
        ' �\���Ώۍs�؂�ւ�����
        '------------------------------
        If GF_GetRowCnt(grd_UnmatchList) = 0 Then Exit Sub
        Call LS_ChgDispStyle(GF_CboGetCode(cbo_SelRow, cbo_SelRow.SelectedIndex))

    End Sub

    Private Sub LS_ChgDispStyle(Optional ByVal pStyle As String = LC_SELROW_ALL)

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objView As DataView
        Dim strFilter As String

        '------------------------------
        ' �t�B���^�����񐶐�
        '------------------------------
        If pStyle = LC_SELROW_ALL Then
            strFilter = ""
        Else
            strFilter = L_udtGridCol(25).strMapName & "=0"
        End If

        '------------------------------
        ' �O���b�h�f�[�^�A��
        '------------------------------
        Try
            objView = New DataView(L_objData.Tables("UNMATCHLIST"), _
                                   strFilter, _
                                   "", _
                                   DataViewRowState.CurrentRows)
            grd_UnmatchList.DataSource = objView
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_ChgDispStyle")
    End Sub

    Private Sub TP1080_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        If L_blnEditFlg Then                                                ' �ҏW�X�V�L���t���O����
            Select Case GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNoCancel)
                Case MsgBoxResult.Yes
                    Call LS_SaveAllData()
                Case MsgBoxResult.No
                Case MsgBoxResult.Cancel
                    e.Cancel = True
                    Exit Sub
            End Select
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("TP1080_Closing")
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click

        Try
            Call LS_SaveAllData()

            ' --- (2003.12.02) �X�V������́u�X�V�t���O�v�N���A���Y��Ή� --
            L_blnEditFlg = False
            ' --------------------------------------------------------------
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("MenuItem2_Click")
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F���i�摜�t�H���_�� ���g�p�摜�t�@�C���폜����
    ' �@�@�\�T�v�FTEC�c�[���ɂď��i���폜���ꂽ���̂ɑ΂���Ή�
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.12.02 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_DelUnuseFile() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strUFile() As String = Nothing
        Dim strFile As String
        Dim strItemPath As String
        Dim strWork As String
        Dim blnFound As Boolean
        Dim objFileInfo As System.IO.FileInfo = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_DelUnuseFile = False

        '------------------------------
        ' �g�p���摜�t�@�C���ꗗ�擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.IMAGEDATA"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " WHERE LEN(LTRIM(IMAGEDATA)) <> 0"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If
            ReDim Preserve strUFile(lngCnt)
            strUFile(lngCnt) = Trim$(objRows("IMAGEDATA"))

            lngCnt = lngCnt + 1
        End While

        Try
            '------------------------------
            ' �摜�t�@�C���g�p������
            '------------------------------
            strItemPath = GF_GetAppInfo("ITEM_PATH")
            For Each strFile In System.IO.Directory.GetFiles(strItemPath)
                blnFound = False
                If Not IsNothing(strUFile) Then
                    objFileInfo = New System.IO.FileInfo(strFile)
                    For Each strWork In strUFile
                        If objFileInfo.Name = strWork Or _
                           objFileInfo.Name = "S_" & strWork Then
                            blnFound = True
                        End If
                    Next
                    objFileInfo = Nothing
                End If

                '------------------------------
                ' ���g�p�t�@�C���ł���΍폜
                '------------------------------
                If Not blnFound Then
                    Call System.IO.File.SetAttributes(strFile, IO.FileAttributes.Normal)
                    Call System.IO.File.Delete(strFile)
                End If
            Next
        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_DelUnuseFile = True

    End Function

End Class
