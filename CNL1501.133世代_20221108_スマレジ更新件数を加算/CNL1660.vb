Public Class CNL1660
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
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents crv_View As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CNL1660))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.crv_View = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.MenuItem1.Text = "�t�@�C��(&F)"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "����(&C)"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Bitmap)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 0
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(879, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 32)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "���"
        '
        'crv_View
        '
        Me.crv_View.ActiveViewIndex = -1
        Me.crv_View.Location = New System.Drawing.Point(-88, 16)
        Me.crv_View.Name = "crv_View"
        Me.crv_View.ReportSource = Nothing
        Me.crv_View.ShowExportButton = False
        Me.crv_View.ShowGroupTreeButton = False
        Me.crv_View.ShowPrintButton = False
        Me.crv_View.ShowRefreshButton = False
        Me.crv_View.ShowTextSearchButton = False
        Me.crv_View.Size = New System.Drawing.Size(1016, 672)
        Me.crv_View.TabIndex = 19
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(736, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 34)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "�f�[�^�o��"
        '
        'CNL1660
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1014, 665)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button2, Me.Button1, Me.crv_View})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL1660"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNL1660"
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
        Dim URIAGE_NUM As String                                            ' 20040722 - ���n�Ή�
    End Structure
    Private L_OrderData As strOrderData

    Private Structure strOrderDataKEY
        Dim SHOHIN As String
    End Structure
    Private L_OrderDatakey As strOrderDataKEY

    Public Structure typMsg
        Dim strMSGID As String
        Dim strMSGTEXT As String
    End Structure

    Private Sub CNL1660_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objStatus As New CNL1810()

        '------------------------------
        ' �t�H�[�����̐ݒ�
        '------------------------------
        Me.Text = GF_FormText("- ���㑬��o�͉��")

        '------------------------------
        ' �i���󋵒ʒm�t�H�[���\��
        '------------------------------
        objStatus.Show()
        With objStatus
            .lbl_Msg.Text = "���[�o�͏������ł��B���΂炭���҂���������..."
            .pgs_Status.Maximum = 100
            .pgs_Status.Minimum = 0
            .pgs_Status.Value = 0
            .TopMost = True
        End With
        System.Windows.Forms.Application.DoEvents()

        '------------------------------
        ' ���[�o�͏���
        '------------------------------
        With objStatus.pgs_Status
            .Minimum = 0
            .Maximum = 100
            .Value = 0
        End With
        Select Case LF_PrtMain(objStatus)
            Case CNL1920.FuncResult.CancelEnd

                Exit Sub
            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        objStatus.Close()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1660_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�T�[�o�^�c�a�T�[�o�ڑ�����
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2003.12.09 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_SVDBConnect() As Boolean
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strConnect As String
        Dim strDBSVNM As String
        Dim strDBSVDBNM As String
        Dim strDBSVUID As String
        Dim strDBSVPASS As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_SVDBConnect = False
        strDBSVNM = GF_GetAppInfo("SVDB_NM")
        strDBSVDBNM = GF_GetAppInfo("SVDB_DBNM")
        strDBSVUID = GF_GetAppInfo("SVDB_UID")
        strDBSVPASS = GF_GetAppInfo("SVDB_PASSWD")

        '------------------------------
        ' �ڑ������񐶐�
        '------------------------------
        strConnect = "data source=" & Trim$(strDBSVNM) & ";" & _
                     "initial catalog=" & Trim$(strDBSVDBNM) & ";" & _
                     "user id=" & Trim$(strDBSVUID) & ";" & _
                     "password=" & Trim$(strDBSVPASS) & ";"

        '------------------------------
        ' �ڑ�����
        '------------------------------
        Try
            G_objSVConnect = New SqlClient.SqlConnection(strConnect)
            G_objSVConnect.Open()
        Catch
            GoTo SYSTEM_ERROR
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_SVDBConnect = True

        Exit Function

SYSTEM_ERROR:
        LF_SVDBConnect = False
        Exit Function
    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�T�[�o���c�a�ǂݍ��ݏ���(�f�[�^�Z�b�g����)
    ' �@�@�\�T�v�F���͈������A�f�[�^�Z�b�g�𐶐����܂��B�܂��A���֐��̏o�͈�����
    '�@�@�@�@�@ �@comGetRows()�֐����g�p���邱�ƂŎQ�Ƃ��邱�Ƃ��ł��܂��B
    ' �@���@�@���FpstrSQL          �Q�Ƃr�p�k��
    '�@�@�@�@�@ �FpSqlDataReader   �Q�ƌ���
    ' �@�� �� �l�F[True] ���� / [False] ���s
    ' �@���@�@���F2003.12.09 SORUN �V�K�쐬
    ' --------------------------------------------------------------------------------
    Private Function LF_SVGetData(ByVal pstrSQL As String, _
                                  ByRef pdstData As DataSet) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objAdapter As SqlClient.SqlDataAdapter

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_SVGetData = False

        '------------------------------
        ' �c�a���o����
        '------------------------------
        Try
            objAdapter = New SqlClient.SqlDataAdapter(pstrSQL, G_objSVConnect)
            objAdapter.Fill(pdstData, "com")
        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_SVGetData = True

    End Function

    Private Function LF_PrtMain(ByRef pStatus As CNL1810) As FuncResult

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objSample As New CNL1670()
        Dim objLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_PrtMain = CNL1920.FuncResult.UnusualEnd
        Try
            With crv_View
                .DisplayGroupTree = False
                .ShowPrintButton = False
                .ShowRefreshButton = False
                .ShowCloseButton = False
                .ShowExportButton = False
            End With
        Catch
            Exit Function
        End Try

        '------------------------------
        ' ���[�o�̓��[�N�e�[�u������
        '------------------------------
        If Not GF_BeginTrans() Then                                         ' �g�����U�N�V�����J�n����
            Exit Function
        End If
        If Not LF_Delete() Then
            GoTo SYSTEM_ERROR
        End If
        If Not GF_CommitTrans() Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �T�[�o�f�[�^�x�[�X�ڑ�
        '------------------------------
        If Not LF_SVDBConnect() Then
            pStatus.Close()
            Call GF_Msg("", "�T�[�o�Ƃ̐ڑ����ł��܂���ł���", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
            LF_PrtMain = CNL1920.FuncResult.CancelEnd
            Exit Function
        End If

        '------------------------------
        ' �g�����U�N�V�����J�n
        '------------------------------
        If Not GF_BeginTrans() Then                                         ' �g�����U�N�V�����J�n����
            Exit Function
        End If

        Select Case LF_PrtCreateWTbl(pStatus, "1")
            Case CNL1920.FuncResult.CancelEnd
                pStatus.Close()
                LF_PrtMain = CNL1920.FuncResult.CancelEnd
                GoTo SYSTEM_ERROR
            Case CNL1920.FuncResult.UnusualEnd
                GoTo SYSTEM_ERROR
        End Select

        ' --- (2004.08.02) �ۑ�_�Ή� --------------------------------------
        'Select Case LF_PrtCreateWTbl(pStatus, "2")
        '    Case CNL1920.FuncResult.CancelEnd
        '        pStatus.Close()
        '        LF_PrtMain = CNL1920.FuncResult.CancelEnd
        '        GoTo SYSTEM_ERROR
        '    Case CNL1920.FuncResult.UnusualEnd
        '        GoTo SYSTEM_ERROR
        'End Select
        ' ------------------------------------------------------------------

        '------------------------------
        ' �g�����U�N�V�����m�菈��
        '------------------------------
        If Not GF_CommitTrans() Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' �T�[�o�f�[�^�x�[�X�ڑ� �ؒf
        '------------------------------
        G_objSVConnect.Close()                                          ' �T�[�o���c�a�ڑ����
        G_objSVConnect.Dispose()

        pStatus.lbl_Msg.Text = "���[�C���[�W�𐶐����Ă��܂��B���΂炭���҂���������..."
        System.Windows.Forms.Application.DoEvents()

        '------------------------------
        ' ���[�o��
        '------------------------------
        If Not LF_CreatePrintObj(objSample) Then
            Exit Function
        End If
        Try
            crv_View.ReportSource = objSample
        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_PrtMain = CNL1920.FuncResult.NormalEnd
        Exit Function

SYSTEM_ERROR:
        Call GF_RollbackTrans()
    End Function

    Private Function LF_CreatePrintObj(ByRef pPObj As CNL1670) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objSample As New CNL1670()
        Dim objLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_CreatePrintObj = False

        '------------------------------
        ' ���[�o��
        '------------------------------
        Try
            With objLogonInfo
                .ConnectionInfo = objSample.Database.Tables(0).LogOnInfo.ConnectionInfo
                .ConnectionInfo.DatabaseName = g_udtAppConfig.strDBServerDBName
                .ConnectionInfo.ServerName = g_udtAppConfig.strDBServerName
                .ConnectionInfo.Password = g_udtAppConfig.strDBServerPassWD
                .ConnectionInfo.UserID = g_udtAppConfig.strDBServerUserID
            End With
            With objSample.Database.Tables.Item(0)
                .ApplyLogOnInfo(objLogonInfo)
                .Location = g_udtAppConfig.strDBServerDBName & _
                            ".." & objSample.Database.Tables.Item(0).Name
            End With

            objSample.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            pPObj = objSample

        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_CreatePrintObj = True

    End Function

    Private Function LF_PrtCreateWTbl(ByRef pStatus As CNL1810, ByVal pJyoken As String) As FuncResult

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim strNow As String
        Dim lngSum As Long                                                  ' 20040722 ���n�Ή�
        Dim objSum As strOrderData

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_PrtCreateWTbl = CNL1920.FuncResult.UnusualEnd
        strNow = Format(Now(), "yyyyMMdd")                                  ' �V�X�e�����t�ݒ�

        ' --- (2004.08.03) �ۑ�_�Ή� --------------------------------------
        With objSum
            .OUTSHOHIN = ""
            .SHOHIN = "9999"
            .SHOHINNM = "���v"
            .TIME00 = "0"
            .TIME01 = "0"
            .TIME02 = "0"
            .TIME03 = "0"
            .TIME04 = "0"
            .TIME05 = "0"
            .TIME06 = "0"
            .TIME07 = "0"
            .TIME08 = "0"
            .TIME09 = "0"
            .TIME10 = "0"
            .TIME11 = "0"
            .TIME12 = "0"
            .TIME13 = "0"
            .TIME14 = "0"
            .TIME15 = "0"
            .TIME16 = "0"
            .TIME17 = "0"
            .TIME18 = "0"
            .TIME19 = "0"
            .TIME20 = "0"
            .TIME21 = "0"
            .TIME22 = "0"
            .TIME23 = "0"
            .URIAGE = "0"
            .URIAGE_NUM = "0"
        End With
        ' ------------------------------------------------------------------

        '------------------------------
        '�f�[�^�擾
        '------------------------------
        If Not LF_GetData(objData, pJyoken) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Call GF_Msg("", "�Ώۃf�[�^������܂���", MsgBoxStyle.OKOnly, MsgBoxStyle.Information)
            LF_PrtCreateWTbl = CNL1920.FuncResult.CancelEnd
            Exit Function
        End If

        Try
            lngCnt = 0
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                Exit Function
            End If

            While lngCnt < objData.Tables("com").Rows.Count
                Call LS_ClearData()                                         ' ������
                L_OrderDatakey.SHOHIN = CStr(objRows("SHOHIN"))             ' �L�[�ޔ�
                Select Case pJyoken                                         ' �w�b�_�ҏW
                    Case "1"
                        L_OrderData.SHOHINKIND = "���i�ԍ�"
                        L_OrderData.OUTSHOHIN = CStr(objRows("SHOHIN"))
                        L_OrderData.SHOHINNM = CStr(objRows("SHOHINNM")) & CStr(objRows("SHOHINNM2"))
                    Case "2"
                        L_OrderData.SHOHINKIND = "�W������"
                        L_OrderData.OUTSHOHIN = ""
                        L_OrderData.SHOHINNM = CStr(objRows("SHOHINNM"))
                End Select
                L_OrderData.SHOHIN = CStr(objRows("SHOHIN"))

                lngSum = 0                                                  ' 20040722 ���n�Ή�
                While L_OrderDatakey.SHOHIN = CStr(objRows("SHOHIN")) And _
                      lngCnt < objData.Tables("com").Rows.Count

                    Select Case CStr(objRows("TIME"))                       ' WK�Ɋi�[
                        'Case strNow & "00"
                        '    L_OrderData.TIME00 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "01"
                        '    L_OrderData.TIME01 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "02"
                        '    L_OrderData.TIME02 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "03"
                        '    L_OrderData.TIME03 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "04"
                        '    L_OrderData.TIME04 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "05"
                        '    L_OrderData.TIME05 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "06"
                        '    L_OrderData.TIME06 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "07"
                        '    L_OrderData.TIME07 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "08"
                        '    L_OrderData.TIME08 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "09"
                        '    L_OrderData.TIME09 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                        'Case strNow & "10"
                        '    L_OrderData.TIME10 = CInt(objRows("CNT"))
                        '    lngSum = lngSum + CInt(objRows("CNT"))
                    Case strNow & "11"
                            L_OrderData.TIME11 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME11 = CLng(objSum.TIME11) + CLng(objRows("CNT"))
                        Case strNow & "12"
                            L_OrderData.TIME12 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME12 = CLng(objSum.TIME12) + CLng(objRows("CNT"))
                        Case strNow & "13"
                            L_OrderData.TIME13 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME13 = CLng(objSum.TIME13) + CLng(objRows("CNT"))
                        Case strNow & "14"
                            L_OrderData.TIME14 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME14 = CLng(objSum.TIME14) + CLng(objRows("CNT"))
                        Case strNow & "15"
                            L_OrderData.TIME15 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME15 = CLng(objSum.TIME15) + CLng(objRows("CNT"))
                        Case strNow & "16"
                            L_OrderData.TIME16 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME16 = CLng(objSum.TIME16) + CLng(objRows("CNT"))
                        Case strNow & "17"
                            L_OrderData.TIME17 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME17 = CLng(objSum.TIME17) + CLng(objRows("CNT"))
                        Case strNow & "18"
                            L_OrderData.TIME18 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME18 = CLng(objSum.TIME18) + CLng(objRows("CNT"))
                        Case strNow & "19"
                            L_OrderData.TIME19 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME19 = CLng(objSum.TIME19) + CLng(objRows("CNT"))
                        Case strNow & "20"
                            L_OrderData.TIME20 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME20 = CLng(objSum.TIME20) + CLng(objRows("CNT"))
                        Case strNow & "21"
                            L_OrderData.TIME21 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME21 = CLng(objSum.TIME21) + CLng(objRows("CNT"))
                        Case strNow & "22"
                            L_OrderData.TIME22 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME22 = CLng(objSum.TIME22) + CLng(objRows("CNT"))
                        Case strNow & "23"
                            L_OrderData.TIME23 = CInt(objRows("CNT"))
                            lngSum = lngSum + CInt(objRows("CNT"))
                            objSum.TIME23 = CLng(objSum.TIME23) + CLng(objRows("CNT"))
                        Case Else
                            '�������Ȃ�
                    End Select

                    L_OrderData.URIAGE = L_OrderData.URIAGE + (CInt(objRows("PRICE")))
                    objSum.URIAGE = objSum.URIAGE + CInt(objRows("PRICE"))

                    lngCnt = lngCnt + 1
                    pStatus.pgs_Status.Value = pStatus.pgs_Status.Value + Fix((50 / CLng(objData.Tables("com").Rows.Count)))
                    If lngCnt < objData.Tables("com").Rows.Count Then
                        If Not GF_GetRows(objData, lngCnt, objRows) Then
                            Exit Function
                        End If
                    End If
                End While

                ' --- (2004.07.22) ���n�Ή� --------------------------------
                L_OrderData.URIAGE_NUM = CStr(lngSum)
                ' ----------------------------------------------------------
                objSum.URIAGE_NUM = CStr(CLng(objSum.URIAGE_NUM) + lngSum)

                '------------------------------
                ' ���[�e�[�u���X�V
                '------------------------------
                If Not LF_DataUpd(L_OrderData) Then
                    Exit Function
                End If
            End While

            ' --- (2004.08.03) �ۑ�_�Ή� ----------------------------------
            objSum.SHOHINKIND = L_OrderData.SHOHINKIND
            If Not LF_DataUpd(objSum) Then
                Exit Function
            End If
            ' --------------------------------------------------------------

        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_PrtCreateWTbl = CNL1920.FuncResult.NormalEnd

        Exit Function
    End Function

    Private Sub LS_ClearData()
        Try
            L_OrderData.SHOHIN = ""
            L_OrderData.OUTSHOHIN = ""
            L_OrderData.SHOHINNM = ""
            L_OrderData.TIME00 = 0
            L_OrderData.TIME01 = 0
            L_OrderData.TIME02 = 0
            L_OrderData.TIME03 = 0
            L_OrderData.TIME04 = 0
            L_OrderData.TIME05 = 0
            L_OrderData.TIME06 = 0
            L_OrderData.TIME07 = 0
            L_OrderData.TIME08 = 0
            L_OrderData.TIME09 = 0
            L_OrderData.TIME10 = 0
            L_OrderData.TIME11 = 0
            L_OrderData.TIME12 = 0
            L_OrderData.TIME13 = 0
            L_OrderData.TIME14 = 0
            L_OrderData.TIME15 = 0
            L_OrderData.TIME16 = 0
            L_OrderData.TIME17 = 0
            L_OrderData.TIME18 = 0
            L_OrderData.TIME19 = 0
            L_OrderData.TIME20 = 0
            L_OrderData.TIME21 = 0
            L_OrderData.TIME22 = 0
            L_OrderData.TIME23 = 0
            L_OrderData.URIAGE = 0
            L_OrderData.URIAGE_NUM = 0                                      ' 20040722 - ���n�Ή�
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_ClearData")
    End Sub

    Private Function LF_Delete() As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_Delete = False

        '------------------------------
        ' ���[�N�e�[�u���폜
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE"
        strSQL = strSQL & "  FROM TPD100"
        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_Delete = True

    End Function

    Private Function LF_GetData(ByRef pDataSet As DataSet, ByVal pJyoken As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim strNow As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetData = False

        '�V�X�e�����t�ݒ�
        strNow = Format(Now(), "yyyyMMdd")

        strSQL = ""
        Select Case pJyoken
            Case 1
                '���i�ԍ�
                strSQL = strSQL & "SELECT SUM(TPD010.QUANTITY) CNT,"
                strSQL = strSQL & "       TPD010.GOODSCD SHOHIN,"
                strSQL = strSQL & "       MAX(TPM010.GOODSNMJ) SHOHINNM,"
                strSQL = strSQL & "       MAX(TPM010.GOODSNMJ2) SHOHINNM2,"
                strSQL = strSQL & "       SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME),1, 10) TIME,"
                strSQL = strSQL & "       SUM(TPM010.PRICE * TPD010.QUANTITY) PRICE"
                strSQL = strSQL & "  FROM TPD010,"
                strSQL = strSQL & "       TPM010 "
                strSQL = strSQL & " WHERE TPD010.GOODSCD = TPM010.GOODSCD"
                strSQL = strSQL & "   AND TPD010.SELECTTIME <> 0"
                strSQL = strSQL & "   AND TPD010.ORDERTIME  <> 0"
                strSQL = strSQL & "   AND TPD010.TRANSTIME <> 0"
                strSQL = strSQL & "   AND TPD010.TRANSTIME <> 99999999999999"
                strSQL = strSQL & "   AND SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME),1, 8) = '" & strNow & "'"
                strSQL = strSQL & " GROUP BY TPD010.GOODSCD,"
                strSQL = strSQL & "          SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME),1, 10)"
                strSQL = strSQL & " ORDER BY TPD010.GOODSCD,"
                strSQL = strSQL & "          TIME"

            Case 2
                '�W������
                strSQL = strSQL & "SELECT SUM(TPD010.QUANTITY) CNT,"
                strSQL = strSQL & "       TPM020A.GROUPCD SHOHIN,"
                strSQL = strSQL & "       MAX(TPM020B.GROUPNM) SHOHINNM,"
                strSQL = strSQL & "       SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME),1, 10) TIME,"
                strSQL = strSQL & "       SUM(TPM010.PRICE * TPD010.QUANTITY) PRICE"
                strSQL = strSQL & "  FROM TPD010,"
                strSQL = strSQL & "       TPM010,"
                strSQL = strSQL & "       TPM020 TPM020A,"
                strSQL = strSQL & "       TPM020 TPM020B"
                strSQL = strSQL & " WHERE TPD010.GOODSCD = TPM010.GOODSCD"
                strSQL = strSQL & "   AND TPD010.GOODSCD = TPM020A.GOODSCD"
                strSQL = strSQL & "   AND TPM020B.GROUPCD = TPM020A.GROUPCD"
                strSQL = strSQL & "   AND TPM020B.GOODSCD = '0000'"
                strSQL = strSQL & "   AND TPD010.SELECTTIME <> 0"
                strSQL = strSQL & "   AND TPD010.ORDERTIME  <> 0"
                strSQL = strSQL & "   AND TPD010.TRANSTIME <> 0"
                strSQL = strSQL & "   AND TPD010.TRANSTIME <> 99999999999999"
                strSQL = strSQL & "   AND SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME),1, 8) = '" & strNow & "'"
                strSQL = strSQL & " GROUP BY TPM020A.GROUPCD,"
                strSQL = strSQL & "          SUBSTRING(CONVERT(CHAR,TPD010.TRANSTIME),1, 10)"
                strSQL = strSQL & " ORDER BY TPM020A.GROUPCD,"
                strSQL = strSQL & "          TIME"
        End Select

        If Not LF_SVGetData(strSQL, pDataSet) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_GetData = True

    End Function

    Private Function LF_DataUpd(ByRef pOrderData As strOrderData) As Boolean
        '------------------------------       
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_DataUpd = False

        strSQL = ""
        strSQL = strSQL & "INSERT INTO"
        strSQL = strSQL & "     TPD100"
        strSQL = strSQL & "     VALUES ('"
        strSQL = strSQL & pOrderData.SHOHINKIND & "','"
        strSQL = strSQL & pOrderData.SHOHIN & "','"
        strSQL = strSQL & LF_PadSpc(pOrderData.OUTSHOHIN, 4) & "','"
        strSQL = strSQL & pOrderData.SHOHINNM & "',"
        strSQL = strSQL & pOrderData.TIME00 & ","
        strSQL = strSQL & pOrderData.TIME01 & ","
        strSQL = strSQL & pOrderData.TIME02 & ","
        strSQL = strSQL & pOrderData.TIME03 & ","
        strSQL = strSQL & pOrderData.TIME04 & ","
        strSQL = strSQL & pOrderData.TIME05 & ","
        strSQL = strSQL & pOrderData.TIME06 & ","
        strSQL = strSQL & pOrderData.TIME07 & ","
        strSQL = strSQL & pOrderData.TIME08 & ","
        strSQL = strSQL & pOrderData.TIME09 & ","
        strSQL = strSQL & pOrderData.TIME10 & ","
        strSQL = strSQL & pOrderData.TIME11 & ","
        strSQL = strSQL & pOrderData.TIME12 & ","
        strSQL = strSQL & pOrderData.TIME13 & ","
        strSQL = strSQL & pOrderData.TIME14 & ","
        strSQL = strSQL & pOrderData.TIME15 & ","
        strSQL = strSQL & pOrderData.TIME16 & ","
        strSQL = strSQL & pOrderData.TIME17 & ","
        strSQL = strSQL & pOrderData.TIME18 & ","
        strSQL = strSQL & pOrderData.TIME19 & ","
        strSQL = strSQL & pOrderData.TIME20 & ","
        strSQL = strSQL & pOrderData.TIME21 & ","
        strSQL = strSQL & pOrderData.TIME22 & ","
        strSQL = strSQL & pOrderData.TIME23 & ","
        strSQL = strSQL & pOrderData.URIAGE & ","
        strSQL = strSQL & pOrderData.URIAGE_NUM & ","
        strSQL = strSQL & "'SYSTEM',"
        strSQL = strSQL & "getdate()"
        strSQL = strSQL & ")"

        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        LF_DataUpd = True

    End Function

    Public Function LF_PadSpc(ByVal pStr As String, ByVal Length As Long) As String

        LF_PadSpc = Space(Length - Len(Trim$(pStr))) & Trim$(pStr)

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim objSample As New CNL1670()

        If Not LF_CreatePrintObj(objSample) Then
            Exit Sub
        End If

        With PrintDialog1
            .AllowPrintToFile = False
            .AllowSomePages = True
            .AllowSelection = True
            .PrinterSettings = New System.Drawing.Printing.PrinterSettings()
            .PrinterSettings.PrintRange = Drawing.Printing.PrintRange.AllPages

            If .ShowDialog = DialogResult.OK Then
                objSample.PrintOptions.PrinterName = .PrinterSettings.PrinterName
                objSample.PrintToPrinter(1, False, .PrinterSettings.FromPage, .PrinterSettings.ToPage)
            End If
        End With

    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub


    '-----------------(2011.3.28)���㑬��f�[�^�o�͒ǉ��@�R�Y-------------------------------
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim RowsCnt As Integer
        Dim ColmCnt As Integer
        Dim FileName As String = Nothing
        Dim strEncoding As System.Text.Encoding
        Dim strStreamWriter As System.IO.StreamWriter = Nothing

        '------------------------------
        '�_�C�A���O�{�b�N�X�\��
        '------------------------------
        If Not GetSaveFile(FileName) Then
            Exit Sub
        End If

        '------------------------------
        ' TPD100 �擾SQL
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "select OUTMSGNO AS ""���i�ԍ�"", GOODSNM AS ""����"", URIAGENUM AS ""���㐔��"","
        strSQL = strSQL & " TIME07 AS ""07:00"", TIME08 AS ""08:00"", TIME09 AS ""09:00"", TIME10 AS ""10:00"","
        strSQL = strSQL & " TIME11 AS ""11:00"", TIME12 AS ""12:00"", TIME13 AS ""13:00"","
        strSQL = strSQL & " TIME14 AS ""14:00"", TIME15 AS ""15:00"", TIME16 AS ""16:00"", TIME17 AS ""17:00"", TIME18 AS ""18:00"", TIME19 AS ""19:00"", TIME20 AS ""20:00"","
        strSQL = strSQL & " TIME21 AS ""21:00"", TIME22 AS ""22:00"", TIME23 AS ""23:00"", URIAGE AS ""������z"""
        strSQL = strSQL & " from TPD100"

        '------------------------------
        '�f�[�^�擾
        '------------------------------
        If Not GF_GetData(strSQL, objData) Then
            Call GF_Msg("", "DB�ڑ��Ɏ��s���܂���", MsgBoxStyle.OKOnly, MsgBoxStyle.Information)
            Exit Sub
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Call GF_Msg("", "�Ώۃf�[�^������܂���", MsgBoxStyle.OKOnly, MsgBoxStyle.Information)
            Exit Sub
        End If

        Try
            '------------------------------
            '�t�@�C�����ݒ�
            '------------------------------
            strEncoding = System.Text.Encoding.GetEncoding("Shift_JIS")
            strStreamWriter = New System.IO.StreamWriter(FileName, False, strEncoding)

            '------------------------------
            '�t�@�C���o��
            '------------------------------
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
                    If RowsCnt = 0 Then
                        If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                            strStreamWriter.WriteLine(objData.Tables("com").Columns(ColmCnt))
                        Else
                            strStreamWriter.Write(objData.Tables("com").Columns(ColmCnt))
                            strStreamWriter.Write(",")
                        End If
                    Else
                        If ColmCnt = (objData.Tables("com").Columns.Count - 1) Then
                            strStreamWriter.WriteLine(objData.Tables("com").Rows(RowsCnt)(ColmCnt))
                        Else
                            strStreamWriter.Write(objData.Tables("com").Rows(RowsCnt)(ColmCnt) & ",")
                        End If
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
        MsgBox("�ۑ����I�����܂���")

    End Sub

    Private Function GetSaveFile(ByRef fname As String) As Boolean
        GetSaveFile = False

        'SaveFileDialog�N���X�̃C���X�^���X���쐬
        Dim sfd As New SaveFileDialog()

        '�͂��߂̃t�@�C�������w�肷��
        sfd.FileName = "PriceData(" & Format$(Now, "yyyyMMddHHmmss") & ").csv"
        '�͂��߂ɕ\�������t�H���_���w�肷��
        sfd.InitialDirectory = "C:\"
        '[�t�@�C���̎��]�ɕ\�������I�������w�肷��
        sfd.Filter = _
         "csv�t�@�C��|*.csv|���ׂẴt�@�C��(*.*)|*.*"
        '[�t�@�C���̎��]�ł͂��߂�
        '�u���ׂẴt�@�C���v���I������Ă���悤�ɂ���
        sfd.FilterIndex = 2
        '�^�C�g����ݒ肷��
        sfd.Title = "�ۑ���̃t�@�C����I�����Ă�������"
        '�_�C�A���O�{�b�N�X�����O�Ɍ��݂̃f�B���N�g���𕜌�����悤�ɂ���
        sfd.RestoreDirectory = True
        '���ɑ��݂���t�@�C�������w�肵���Ƃ��x������
        '�f�t�H���g��True�Ȃ̂Ŏw�肷��K�v�͂Ȃ�
        sfd.OverwritePrompt = True
        '���݂��Ȃ��p�X���w�肳�ꂽ�Ƃ��x����\������
        '�f�t�H���g��True�Ȃ̂Ŏw�肷��K�v�͂Ȃ�
        sfd.CheckPathExists = True

        '�_�C�A���O��\������
        If sfd.ShowDialog() = DialogResult.OK Then
            fname = sfd.FileName
        Else
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        GetSaveFile = True

    End Function

End Class
