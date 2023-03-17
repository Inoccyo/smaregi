Public Class CNWG490

    Public G_2920 As Object                                 ' 2011/07/29修正
    Public Enum SoldOutKind
        OnSale = 0
        SoldOut = 1
    End Enum

    Public Enum FuncResult
        NormalEnd = 0
        CancelEnd = 1
        ErrorEnd = 9
    End Enum

    ' 返却値： -1 = システム障害 / 0 = 正常終了 / 1 = 登録済み or 解除済み / 2 = 商品マスタ不整合
    Public Function GF_SetSoldOut(ByVal pGoodsCD As String, ByVal pSellKind As SoldOutKind) As Integer

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        '品切れ4パターン対応　2013.10.28
        Dim tableNM As String = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_SetSoldOut = -1

        '------------------------------
        ' 商品マスタ存在チェック
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
        ' レコード存在確認
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
        ' 売り切れ情報テーブル更新
        '------------------------------
        If pSellKind = SoldOutKind.OnSale Then                              ' 品切れ解除
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
        Else                                                                ' 品切れ登録
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
        ' 返却値設定
        '------------------------------
        GF_SetSoldOut = 0

    End Function

    '品切れ4パターン対応　2013.10.28

    ''' <summary>
    ''' TPD03X存在チェック
    ''' </summary>
    ''' <param name="pTableId"></param>
    ''' <param name="pGoodsCD"></param>
    ''' <remarks></remarks>
    Public Function LF_GetTable(ByVal pTableId As String, ByVal pGoodsCD As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTable = True

        '------------------------------
        ' レコード存在確認
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
            ' 返却値設定
            '------------------------------
            LF_GetTable = False
        End If

    End Function

    Public Function GF_GetMyTermNo(ByVal pIPAddr As String, ByVal pLRFLG As String, ByRef pTermNo As String) As FuncResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim strTermKind As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_GetMyTermNo = FuncResult.ErrorEnd
        pTermNo = ""

        '------------------------------
        ' 機器区分変換
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
        ' 関連機器管理テーブル取得
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
        ' 返却値設定
        '------------------------------
        pTermNo = Trim$(objRows("SEATID"))
        GF_GetMyTermNo = FuncResult.NormalEnd

    End Function

    Public Function GF_GetORDERSTATUS(ByVal pIPAddr As String, ByRef pOrderStatus As String) As FuncResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_GetORDERSTATUS = FuncResult.ErrorEnd
        pOrderStatus = ""

        '------------------------------
        ' 関連機器管理テーブル取得
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
        ' 返却値設定
        '------------------------------
        pOrderStatus = Trim$(objRows("ORDERSTATUS"))
        GF_GetORDERSTATUS = FuncResult.NormalEnd

    End Function

    Public Function GF_GetKCPStatus(ByRef pArray() As String, ByVal pKCPNo As Long) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngCnt As Long
        Dim intI As Integer
        Dim intJ As Integer
        Dim blnFound As Boolean

        '------------------------------
        ' 初期値設定
        '------------------------------
        GF_GetKCPStatus = False
        blnFound = False

        '------------------------------
        ' ＫＣＰステータス列生成
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
        ' 返却値設定
        '------------------------------
        GF_GetKCPStatus = True

    End Function

    Public Function GF_PadSpc(ByVal pStr As String, ByVal Length As Long) As String

        GF_PadSpc = Space(Length - Len(Trim$(pStr))) & Trim$(pStr)

    End Function

    Public Function GF_UpdTPM090(ByVal pAPVALUE As String, ByVal pAPKEY As String) As Boolean
        '------------------------------
        ' 内部変数定義
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
