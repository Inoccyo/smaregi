Public Class CNWG490

    Public G_2920 As Object                                 ' 2011/07/29�C��
    Public Enum SoldOutKind
        OnSale = 0
        SoldOut = 1
    End Enum

    Public Enum FuncResult
        NormalEnd = 0
        CancelEnd = 1
        ErrorEnd = 9
    End Enum

    ' �ԋp�l�F -1 = �V�X�e����Q / 0 = ����I�� / 1 = �o�^�ς� or �����ς� / 2 = ���i�}�X�^�s����
    Public Function GF_SetSoldOut(ByVal pGoodsCD As String, ByVal pSellKind As SoldOutKind) As Integer

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        '�i�؂�4�p�^�[���Ή��@2013.10.28
        Dim tableNM As String = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        GF_SetSoldOut = -1

        '------------------------------
        ' ���i�}�X�^���݃`�F�b�N
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSCD"
        strSQL = strSQL & "  FROM TPM010"
        strSQL = strSQL & " WHERE TPM010.GOODSCD = '" & pGoodsCD & "'"
        If Not CType(G_2920, TP2920).GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            GF_SetSoldOut = 2
            Exit Function
        End If

        '------------------------------
        ' ���R�[�h���݊m�F
        '------------------------------
        'strSQL = ""
        'strSQL = strSQL & "SELECT TPD030.GOODSCD"
        'strSQL = strSQL & "  FROM TPD030"
        'strSQL = strSQL & " WHERE TPD030.GOODSCD = '" & pGoodsCD & "'"
        'objData = New DataSet()
        'If Not CType(G_2920, TP2920).GF_GetData(strSQL, objData) Then
        '    Exit Function
        'End If
        If LF_GetTable("TPD030", pGoodsCD) Then
            tableNM = "TPD030"
        End If

        If tableNM = Nothing And LF_GetTable("TPD031", pGoodsCD) Then
            tableNM = "TPD031"
        End If

        If tableNM = Nothing And LF_GetTable("TPD032", pGoodsCD) Then
            tableNM = "TPD032"
        End If

        If tableNM = Nothing And LF_GetTable("TPD033", pGoodsCD) Then
            tableNM = "TPD033"
        End If

        '------------------------------
        ' ����؂���e�[�u���X�V
        '------------------------------
        If pSellKind = SoldOutKind.OnSale Then                              ' �i�؂����
            If tableNM = Nothing Then
                'If objData.Tables("com").Rows.Count = 0 Then
                GF_SetSoldOut = 1
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "DELETE"
            'strSQL = strSQL & "  FROM TPD030"
            'strSQL = strSQL & " WHERE TPD030.GOODSCD = '" & pGoodsCD & "'"
            strSQL = strSQL & "  FROM " & tableNM
            strSQL = strSQL & " WHERE GOODSCD = '" & pGoodsCD & "'"
        Else                                                                ' �i�؂�o�^
            If objData.Tables("com").Rows.Count <> 0 Then
                GF_SetSoldOut = 1
                Exit Function
            End If

            strSQL = ""
            'strSQL = strSQL & "INSERT INTO TPD030 VALUES("
            strSQL = strSQL & "INSERT INTO " & tableNM & "VALUES("
            strSQL = strSQL & "'" & pGoodsCD & "',"
            strSQL = strSQL & "'SYSTEM',"
            strSQL = strSQL & "getdate())"
        End If
        If Not CType(G_2920, TP2920).GF_BeginTrans Then
            Exit Function
        End If
        If Not CType(G_2920, TP2920).GF_UpdData(strSQL) Then
            Call CType(G_2920, TP2920).GF_RollbackTrans()
            Exit Function
        End If
        If Not CType(G_2920, TP2920).GF_CommitTrans Then
            Call CType(G_2920, TP2920).GF_RollbackTrans()
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        GF_SetSoldOut = 0

    End Function

    '�i�؂�4�p�^�[���Ή��@2013.10.28

    ''' <summary>
    ''' TPD03X���݃`�F�b�N
    ''' </summary>
    ''' <param name="pTableId"></param>
    ''' <param name="pGoodsCD"></param>
    ''' <remarks></remarks>
    Public Function LF_GetTable(ByVal pTableId As String, ByVal pGoodsCD As String) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        LF_GetTable = True

        '------------------------------
        ' ���R�[�h���݊m�F
        '------------------------------
        strSQL = ""
        strSQL &= "SELECT GOODSCD"
        strSQL &= "  FROM " & pTableId
        strSQL &= " WHERE GOODSCD = '" & pGoodsCD & "'"

        dtsData = New DataSet()

        If Not CType(G_2920, TP2920).GF_GetData(strSQL, dtsData) Then
            Exit Function
        End If

        If dtsData.Tables("com").Rows.Count = 0 Then
            '------------------------------
            ' �ԋp�l�ݒ�
            '------------------------------
            LF_GetTable = False
        End If

    End Function

    Public Function GF_GetMyTermNo(ByVal pIPAddr As String, ByVal pLRFLG As String, ByRef pTermNo As String) As FuncResult

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim strTermKind As String

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        GF_GetMyTermNo = FuncResult.ErrorEnd
        pTermNo = ""

        '------------------------------
        ' �@��敪�ϊ�
        '------------------------------
        Select Case pLRFLG
            Case "L"
                strTermKind = "TC5"
            Case "R"
                strTermKind = "TC6"
            Case "F"
                strTermKind = "TCQ"
            Case Else
                Exit Function
        End Select

        '------------------------------
        ' �֘A�@��Ǘ��e�[�u���擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM050.SEATID"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE TPM050.TERMID   = '" & pIPAddr & "'"
        strSQL = strSQL & "   AND TPM050.TERMKIND = '" & strTermKind & "'"
        If Not CType(G_2920, TP2920).GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            GF_GetMyTermNo = FuncResult.CancelEnd
            Exit Function
        End If
        If Not CType(G_2920, TP2920).GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        pTermNo = Trim$(objRows("SEATID"))
        GF_GetMyTermNo = FuncResult.NormalEnd

    End Function

    Public Function GF_GetORDERSTATUS(ByVal pIPAddr As String, ByRef pOrderStatus As String) As FuncResult

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        GF_GetORDERSTATUS = FuncResult.ErrorEnd
        pOrderStatus = ""

        '------------------------------
        ' �֘A�@��Ǘ��e�[�u���擾
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM050.ORDERSTATUS"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE TPM050.TERMID   = '" & pIPAddr & "'"
        If Not CType(G_2920, TP2920).GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            GF_GetORDERSTATUS = FuncResult.CancelEnd
            Exit Function
        End If
        If Not CType(G_2920, TP2920).GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        pOrderStatus = Trim$(objRows("ORDERSTATUS"))
        GF_GetORDERSTATUS = FuncResult.NormalEnd

    End Function

    Public Function GF_GetKCPStatus(ByRef pArray() As String, ByVal pKCPNo As Long) As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim lngCnt As Long
        Dim intI As Integer
        Dim intJ As Integer
        Dim blnFound As Boolean

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        GF_GetKCPStatus = False
        blnFound = False

        '------------------------------
        ' �j�b�o�X�e�[�^�X�񐶐�
        '------------------------------
        Try
            lngCnt = 1
            For intI = 0 To 3
                For intJ = 8 To 1 Step -1
                    If pKCPNo = lngCnt Then
                        pArray(intI) = Mid$(pArray(intI), 1, intJ - 1) & "1" & Mid$(pArray(intI), intJ + 1)
                        blnFound = True
                        Exit For
                    End If
                    lngCnt = lngCnt + 1
                Next
                If blnFound Then
                    Exit For
                End If
            Next
        Catch
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        GF_GetKCPStatus = True

    End Function

    Public Function GF_PadSpc(ByVal pStr As String, ByVal Length As Long) As String

        GF_PadSpc = Space(Length - Len(Trim$(pStr))) & Trim$(pStr)

    End Function

    Public Function GF_UpdTPM090(ByVal pAPVALUE As String, ByVal pAPKEY As String) As Boolean
        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim strSQL As String

        GF_UpdTPM090 = False

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM090"
        strSQL = strSQL & "   SET TPM090.APVALUE = '" & pAPVALUE & "',"
        strSQL = strSQL & "       TPM090.UPDID = 'SYSTEM_PGM',"
        strSQL = strSQL & "       TPM090.UPDYMD = getdate()"
        strSQL = strSQL & " WHERE TPM090.APKEY   = '" & pAPKEY & "'"
        If Not CType(G_2920, TP2920).GF_UpdData(strSQL) = True Then
            Exit Function
        End If

        GF_UpdTPM090 = True

    End Function
    Public Function GF_MidB(ByVal pStr As String, ByVal pStart As Long, ByVal pLength As Long) As String

        Dim bytBuff() As Byte

        If pLength > GF_LenB(pStr) - (pStart - 1) Then
            pLength = GF_LenB(pStr) - (pStart - 1)
        End If

        GF_MidB = ""
        bytBuff = System.Text.Encoding.GetEncoding("Shift-JIS").GetBytes(pStr)
        GF_MidB = System.Text.Encoding.GetEncoding("Shift-JIS").GetString(bytBuff, pStart - 1, pLength)

    End Function
    Public Function GF_LenB(ByVal pStr As String) As Long

        If IsNothing(pStr) Then
            GF_LenB = 0
            Exit Function
        End If

        GF_LenB = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(pStr)
    End Function

End Class
