Partial Class CNWG032
    Inherits System.Web.UI.Page

#Region " Web フォーム デザイナで生成されたコード "

    'この呼び出しは Web フォーム デザイナで必要です。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        ' CODEGEN: このメソッド呼び出しは Web フォーム デザイナで必要です。
        ' コード エディタを使って変更しないでください。
        InitializeComponent()
    End Sub

#End Region

    Private L_Func As TP2920
    Private L_BtnBack As Boolean
    Private L_BtnPrev As Boolean
    Private Const SessionMsgName As String = "CNWG001.Msg"

    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '------------------------------
        ' セッション状態確認
        '------------------------------
        If IsNothing(Session("TP")) Then
            L_Func = New TP2920()
            If Not L_Func.GF_Initialize() Then
                Response.Redirect("./TP2990.html?CNWG032(Page_Load-1)")
                Exit Sub
            End If
            Session("TP") = L_Func
        Else
            L_Func = Session("TP")
        End If

        Me.ViewState.Add("MENUIMG_PATH", L_Func.GF_GetAppInfo("MENUIMG_PATH"))
        Me.ViewState.Add("IMGSET", L_Func.GF_GetImageSet())

        L_BtnBack = False
        L_BtnPrev = False

        Me.ViewState("REG_GOODSCD") = L_Func.GF_GetAppInfo("REG_GOODSCD")       'お会計
        Me.ViewState("OPEN_GOODSCD") = L_Func.GF_GetAppInfo("OPEN_GOODSCD")     'お通し

        btn_protect()

        If Request.QueryString("UPDID") <> "" Then
            btn_Click(Request.QueryString("UPDID"))
            Exit Sub
        End If
        '決定ボタンタッチ時
        If Request.QueryString("SETFLG") <> "" Then
            btn_Set_Click()
            Exit Sub
        End If

        '------------------------------
        ' ポストバック時は処理対象外
        '------------------------------
        If IsPostBack Then
            Exit Sub
        End If

        '------------------------------
        ' 遷移ﾊﾟﾗﾒﾀにより表示項目設定
        '------------------------------
        Call LF_SetForm()

        Session.Remove("NUMBER")

    End Sub

    Private Function LF_SetForm(Optional ByVal pNext As Boolean = False) As Object

        LF_SetForm = Nothing

        '空席
        btn_0.Visible = True
        btn_1.Visible = True
        btn_2.Visible = True
        btn_3.Visible = True
        btn_4.Visible = True
        btn_5.Visible = True
        btn_6.Visible = True
        btn_7.Visible = True
        btn_8.Visible = True
        btn_9.Visible = True
        btn_cls.Visible = True

    End Function

    Private Sub btn_protect()

        btn_1.Attributes.Add("ONCLICK", "return noBack();")
        btn_2.Attributes.Add("ONCLICK", "return noBack();")
        btn_3.Attributes.Add("ONCLICK", "return noBack();")
        btn_4.Attributes.Add("ONCLICK", "return noBack();")
        btn_5.Attributes.Add("ONCLICK", "return noBack();")
        btn_6.Attributes.Add("ONCLICK", "return noBack();")
        btn_7.Attributes.Add("ONCLICK", "return noBack();")
        btn_8.Attributes.Add("ONCLICK", "return noBack();")
        btn_9.Attributes.Add("ONCLICK", "return noBack();")
        btn_0.Attributes.Add("ONCLICK", "return noBack();")
        btn_cls.Attributes.Add("ONCLICK", "return noBack();")
        btn_back.Attributes.Add("ONCLICK", "return noBack();")
        btn_Set.Attributes.Add("ONCLICK", "return noBack();")


    End Sub

    Private Sub btn_Set_Click()

        L_BtnBack = True
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim lngCnt As Integer
        Dim datNow As Date

        Dim befSeatid As String '移動元テーブル
        Dim aftSeatid As String '移動先テーブル
        Dim befTermid As String '移動元端末識別ID
        Dim aftTermid As String '移動先端末識別ID
        Dim befOrderno As String '移動元オーダー連番
        Dim aftOrderno As String '移動先オーダー連番
        Dim strSPMENU As String
        Dim strSPMENU2 As String

        datNow = Now

        '入力チェック
        '空欄チェック
        If Session("NUMBER") = "" Or Session("NUMBER") = "0" Then
            Session(SessionMsgName) = "座席番号を入力して下さい。"
            Exit Sub
        End If

        '座席番号チェック
        strSQL = ""
        strSQL = strSQL & "SELECT *"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE SEATID = '" & RSet(Session("NUMBER"), 5) & "'"
        strSQL = strSQL & "   AND TERMKIND IN ('TCA','TCB','TC0')"

        objData = New DataSet()
        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?TPG032(btn_Set_Click)")
            Exit Sub
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Session(SessionMsgName) = "入力された座席番号は存在しません"
            Exit Sub
        End If
        objRow = Nothing
        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Exit Sub
        End If

        '状態チェック
        If Trim$(objRow("ORDERSTATUS")) = "1" Then
            Session(SessionMsgName) = "入力された座席番号は現在使用中です"
            Exit Sub
        ElseIf Trim(objRow("ORDERSTATUS")) = "A" Or Trim(objRow("ORDERSTATUS")) = "5" Or Trim(objRow("ORDERSTATUS")) = "C" Then
            Session(SessionMsgName) = "入力された座席番号は現在準備中です"
            Exit Sub
        End If

        '他端末使用有無チェック
        'HISTORYFLGをチェック
        strSQL = ""
        strSQL = strSQL & " SELECT * FROM TPM050"
        strSQL = strSQL & "  WHERE SEATID='" & RSet(Session("SEATID"), 5) & "'"
        strSQL = strSQL & "    AND HISTORYFLG <> '0'"
        strSQL = strSQL & "    AND TERMKIND IN ('TCA','TC0','TCB')"
        strSQL = strSQL & " UNION"
        strSQL = strSQL & " SELECT * FROM TPM050"
        strSQL = strSQL & "  WHERE SEATID='" & RSet(Session("NUMBER"), 5) & "'"
        strSQL = strSQL & "    AND HISTORYFLG <> '0'"
        strSQL = strSQL & "    AND TERMKIND IN ('TCA','TC0','TCB')"

        objData = New DataSet()
        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?TPG032(btn_Set_Click)")
            Exit Sub
        End If

        If objData.Tables("com").Rows.Count <> 0 Then
            Session(SessionMsgName) = "入力された座席は、他のパネルで操作中です。"
            Exit Sub
        End If

        '**********************************
        '清算連動時
        '**********************************
        If Session("TP").GF_GetAppInfo("SYS_TYPE") = 2 Then

            '----------------------------------
            '移動座席フラグの更新
            '----------------------------------
            If Not L_Func.GF_BeginTrans Then
                Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
            End If

            '----------------------------------
            'TPD050(UPDATE文)
            '移動先のフラグ更新
            '----------------------------------
            strSQL = ""
            strSQL = strSQL & "UPDATE TPD050"
            strSQL = strSQL & "   SET D10 = '1',"
            strSQL = strSQL & "       UPDID   = 'TPG032',"
            strSQL = strSQL & "       UPDYMD  = '" & datNow & "'"
            strSQL = strSQL & " WHERE SEATID  = '" & RSet(Session("NUMBER"), 5) & "'"
            strSQL = strSQL & " AND   TERMKIND IN ('TC0','TCA','TCB')"

            If Not L_Func.GF_UpdData(strSQL) Then
                Call L_Func.GF_RollbackTrans()
                Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                Exit Sub
            End If

            '----------------------------------
            'TPD050(UPDATE文)
            '移動元のフラグ更新
            '----------------------------------
            strSQL = ""
            strSQL = strSQL & "UPDATE TPD050"
            strSQL = strSQL & "   SET D10 = '2',"
            strSQL = strSQL & "       UPDID   = 'TPG032',"
            strSQL = strSQL & "       UPDYMD  = '" & datNow & "'"
            strSQL = strSQL & " WHERE SEATID  = '" & RSet(Session("SEATID"), 5) & "'"
            strSQL = strSQL & " AND   TERMKIND IN ('TC0','TCA','TCB')"

            If Not L_Func.GF_UpdData(strSQL) Then
                Call L_Func.GF_RollbackTrans()
                Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                Exit Sub
            End If

            If Not L_Func.GF_CommitTrans() Then
                Call L_Func.GF_RollbackTrans()
                Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                Exit Sub
            End If

            '----------------------------------
            '連携アプリで座席移動処理終了するまで待機
            '----------------------------------
            For lngCnt = 0 To 10
                If CheckSTNsendTblChg(Session("SEATID"), Session("NUMBER")) Then
                    Exit For
                End If

                If lngCnt <> 10 Then
                    Sleep(1000)
                Else
                    If CheckSTNsendTblChgErr(Session("NUMBER")) = "1" Then ' 移動先の座席更新フラグ確認
                        Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                    Else
                        Session(SessionMsgName) = "登録に失敗しました。移動先のお会計を済ませて下さい。"
                    End If

                    '座席移動処理未完了時はフラグを再更新する
                    If Not L_Func.GF_BeginTrans Then
                        Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                        Exit Sub
                    End If

                    '----------------------------------
                    'TPD050(UPDATE文)
                    '移動元のフラグ更新
                    '----------------------------------
                    strSQL = ""
                    strSQL = strSQL & "UPDATE TPD050"
                    strSQL = strSQL & "   SET D10 = '0',"
                    strSQL = strSQL & "       UPDID   = 'TPG032',"
                    strSQL = strSQL & "       UPDYMD  = '" & datNow & "'"
                    strSQL = strSQL & " WHERE SEATID  = '" & RSet(Session("NUMBER"), 5) & "'"
                    strSQL = strSQL & " AND   TERMKIND IN ('TC0','TCA','TCB')"

                    If Not L_Func.GF_UpdData(strSQL) Then
                        Call L_Func.GF_RollbackTrans()
                        Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                        Exit Sub
                    End If

                    '----------------------------------
                    'TPD050(UPDATE文)
                    '移動先のフラグ更新
                    '----------------------------------
                    strSQL = ""
                    strSQL = strSQL & "UPDATE TPD050"
                    strSQL = strSQL & "   SET D10 = '0',"
                    strSQL = strSQL & "       UPDID   = 'TPG032',"
                    strSQL = strSQL & "       UPDYMD  = '" & datNow & "'"
                    strSQL = strSQL & " WHERE SEATID  = '" & RSet(Session("SEATID"), 5) & "'"
                    strSQL = strSQL & " AND   TERMKIND IN ('TC0','TCA','TCB')"

                    If Not L_Func.GF_UpdData(strSQL) Then
                        Call L_Func.GF_RollbackTrans()
                        Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                        Exit Sub
                    End If

                    If Not L_Func.GF_CommitTrans() Then
                        Call L_Func.GF_RollbackTrans()
                        Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                        Exit Sub
                    End If

                    Exit Sub
                End If
            Next lngCnt

            '**********************************
            '非清算連動時
            '**********************************
        Else
            '---------------------------------
            '更新項目の取得
            '---------------------------------
            befSeatid = Session("SEATID")
            aftSeatid = Session("NUMBER")
            befTermid = LF_GetTermID(befSeatid)
            aftTermid = LF_GetTermID(aftSeatid)
            befOrderno = LF_GetOrderNo(befSeatid)
            aftOrderno = LF_GetOrderNo(aftSeatid) + 1
            strSPMENU = LF_GetSPMENU()
            strSPMENU2 = LF_GetSPMENU2(befSeatid)

            '---------------------------------
            '更新処理開始
            '---------------------------------
            If Not L_Func.GF_BeginTrans Then
                Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
            End If

            '---------------------------------
            'TPD010更新
            '移動元座席の注文データを、移動先座席の注文データに更新する
            '---------------------------------
            strSQL = ""
            strSQL = strSQL & "UPDATE TPD010"
            strSQL = strSQL & "   SET TERMID  = '" & aftTermid & "',"
            strSQL = strSQL & "       SEATID  = '" & RSet(aftSeatid, 5) & "',"
            strSQL = strSQL & "       ORDERNO = '" & aftOrderno & "',"
            strSQL = strSQL & "       UPDID   = 'CNWG032',"
            strSQL = strSQL & "       UPDYMD = '" & datNow & "'"
            strSQL = strSQL & " WHERE SEATID  = '" & RSet(befSeatid, 5) & "'"
            strSQL = strSQL & "   AND ORDERNO = '" & befOrderno & "'"
            strSQL = strSQL & "   AND TERMID = '" & befTermid & "'"
            If Not L_Func.GF_UpdData(strSQL) Then
                Call L_Func.GF_RollbackTrans()
                Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                Exit Sub
            End If

            '---------------------------------
            'TPD011更新
            '移動元座席の注文データを、移動先座席の注文データに更新する
            '---------------------------------
            strSQL = ""
            strSQL = strSQL & "UPDATE TPD011"
            strSQL = strSQL & "   SET TERMID  = '" & aftTermid & "',"
            strSQL = strSQL & "       SEATID  = '" & RSet(aftSeatid, 5) & "',"
            strSQL = strSQL & "       ORDERNO = '" & aftOrderno & "',"
            strSQL = strSQL & "       UPDID   = 'CNWG032',"
            strSQL = strSQL & "       UPDYMD = '" & datNow & "'"
            strSQL = strSQL & " WHERE SEATID  = '" & RSet(befSeatid, 5) & "'"
            strSQL = strSQL & "   AND ORDERNO = '" & befOrderno & "'"
            strSQL = strSQL & "   AND TERMID = '" & befTermid & "'"
            If Not L_Func.GF_UpdData(strSQL) Then
                Call L_Func.GF_RollbackTrans()
                Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                Exit Sub
            End If

            '---------------------------------
            'TPM050更新
            '移動先座席の状態を開局中に変更する
            '---------------------------------
            strSQL = ""
            strSQL = strSQL & "UPDATE TPM050"
            strSQL = strSQL & "   SET ORDERSTATUS  = '1',"
            strSQL = strSQL & "       SPMENU   = '" & strSPMENU & "',"
            strSQL = strSQL & "       SPMENU2  = '" & strSPMENU2 & "',"
            strSQL = strSQL & "       UPDID    = 'CNWG032',"
            strSQL = strSQL & "       UPDYMD   = '" & datNow & "'"
            strSQL = strSQL & " WHERE SEATID   = '" & RSet(aftSeatid, 5) & "'"
            strSQL = strSQL & " AND   TERMKIND IN ('TC0','TCA','TCB')"
            If Not L_Func.GF_UpdData(strSQL) Then
                Call L_Func.GF_RollbackTrans()
                Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                Exit Sub
            End If

            If Session("TP").GF_GetAppInfo2("FIXED_SEAT_OPENFLG") = 1 And Session("TP").GF_GetSeatFlg(befTermid) = "F" Then

                '---------------------------------
                'TPM051更新
                '移動元座席の状態を座席設定を解除する
                '---------------------------------
                strSQL = ""
                strSQL = strSQL & "UPDATE TPM051"
                strSQL = strSQL & "   SET VIRTUALTERMID = ' ',"
                strSQL = strSQL & "       UPDID         = 'CNWG032',"
                strSQL = strSQL & "       UPDYMD        = '" & datNow & "'"
                strSQL = strSQL & " WHERE REALTERMID    = '" & befTermid & "'"
                If Not L_Func.GF_UpdData(strSQL) Then
                    Call L_Func.GF_RollbackTrans()
                    Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                    Exit Sub
                End If

            ElseIf Session("TP").GF_GetSeatFlg(befTermid) = "D" Then
                '---------------------------------
                'TPM051更新
                '移動元座席の状態を座席設定を解除する
                '---------------------------------
                strSQL = ""
                strSQL = strSQL & "UPDATE TPM051"
                strSQL = strSQL & "   SET VIRTUALTERMID = ' ',"
                strSQL = strSQL & "       UPDID         = 'CNWG032',"
                strSQL = strSQL & "       UPDYMD        = '" & datNow & "'"
                strSQL = strSQL & " WHERE REALTERMID    = '" & befTermid & "'"
                If Not L_Func.GF_UpdData(strSQL) Then
                    Call L_Func.GF_RollbackTrans()
                    Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                    Exit Sub
                End If

            End If

            '---------------------------------
            'TPM050更新
            '移動元座席の状態を準備中に変更する
            '---------------------------------
            strSQL = ""
            strSQL = strSQL & "UPDATE TPM050"
            strSQL = strSQL & "   SET ORDERSTATUS  = '5',"
            strSQL = strSQL & "       SPMENU       = '000',"
            strSQL = strSQL & "       SPMENU2      = '000',"
            strSQL = strSQL & "       HISTORYFLG   = '0',"
            strSQL = strSQL & "       UPDID        = 'CNWG032',"
            strSQL = strSQL & "       UPDYMD       = '" & datNow & "'"
            strSQL = strSQL & " WHERE SEATID       = '" & RSet(befSeatid, 5) & "'"
            strSQL = strSQL & " AND   TERMKIND IN ('TC0','TCA','TCB')"
            If Not L_Func.GF_UpdData(strSQL) Then
                Call L_Func.GF_RollbackTrans()
                Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                Exit Sub
            End If

            '---------------------------------
            'TPD050更新
            '移動元座席のゲーム再生情報を移動先に移行
            '---------------------------------
            strSQL = ""
            strSQL = strSQL & "UPDATE TPD050"
            strSQL = strSQL & "   SET D1      = '" & LF_GetTPD050(befSeatid, "1") & "',"
            'strSQL = strSQL & "       D2      = '" & LF_GetTPD050(befSeatid, "2") & "',"
            strSQL = strSQL & "       D3      = '" & LF_GetTPD050(befSeatid, "3") & "',"
            strSQL = strSQL & "       D4      = '" & LF_GetTPD050(befSeatid, "4") & "',"
            strSQL = strSQL & "       D5      = '" & LF_GetTPD050(befSeatid, "5") & "',"
            strSQL = strSQL & "       D6      = '" & LF_GetTPD050(befSeatid, "6") & "',"
            strSQL = strSQL & "       D7      = '" & LF_GetTPD050(befSeatid, "7") & "',"
            strSQL = strSQL & "       D8      = '" & LF_GetTPD050(befSeatid, "8") & "',"
            strSQL = strSQL & "       D9      = '" & LF_GetTPD050(befSeatid, "9") & "',"
            strSQL = strSQL & "       UPDID   = 'CNWG032',"
            strSQL = strSQL & "       UPDYMD  = '" & datNow & "'"
            strSQL = strSQL & " WHERE SEATID  = '" & RSet(aftSeatid, 5) & "'"
            strSQL = strSQL & " AND   TERMKIND IN ('TC0','TCA','TCB')"
            If Not L_Func.GF_UpdData(strSQL) Then
                Call L_Func.GF_RollbackTrans()
                Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                Exit Sub
            End If

            '---------------------------------
            'TPD050更新
            '移動元座席のゲーム再生情報をクリア
            '---------------------------------
            strSQL = ""
            strSQL = strSQL & "UPDATE TPD050"
            strSQL = strSQL & "   SET D1 = '0',"
            'strSQL = strSQL & "       D2 = '0',"
            strSQL = strSQL & "       D3 = '0',"
            strSQL = strSQL & "       D4 = '0',"
            strSQL = strSQL & "       D5 = '0',"
            strSQL = strSQL & "       D6 = '0',"
            strSQL = strSQL & "       D7 = '0',"
            strSQL = strSQL & "       D8 = '0',"
            strSQL = strSQL & "       D9 = '0',"
            strSQL = strSQL & "       UPDID   = 'CNWG032',"
            strSQL = strSQL & "       UPDYMD  = '" & datNow & "'"
            strSQL = strSQL & " WHERE SEATID  = '" & RSet(befSeatid, 5) & "'"
            strSQL = strSQL & " AND   TERMKIND IN ('TC0','TCA','TCB')"
            If Not L_Func.GF_UpdData(strSQL) Then
                Call L_Func.GF_RollbackTrans()
                Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                Exit Sub
            End If

            '---------------------------------
            'TPD051更新
            '移動元座席のゲーム再生情報を移動先に移行
            '---------------------------------
            strSQL = ""
            strSQL = strSQL & "UPDATE TPD051"
            strSQL = strSQL & "   SET D1      = '" & LF_GetTPD051(befSeatid, "1") & "',"
            strSQL = strSQL & "       D2      = '" & LF_GetTPD051(befSeatid, "2") & "',"
            strSQL = strSQL & "       D3      = '" & LF_GetTPD051(befSeatid, "3") & "',"
            strSQL = strSQL & "       D4      = '" & LF_GetTPD051(befSeatid, "4") & "',"
            strSQL = strSQL & "       D5      = '" & LF_GetTPD051(befSeatid, "5") & "',"
            strSQL = strSQL & "       D6      = '" & LF_GetTPD051(befSeatid, "6") & "',"
            strSQL = strSQL & "       D7      = '" & LF_GetTPD051(befSeatid, "7") & "',"
            strSQL = strSQL & "       D8      = '" & LF_GetTPD051(befSeatid, "8") & "',"
            strSQL = strSQL & "       D9      = '" & LF_GetTPD051(befSeatid, "9") & "',"
            strSQL = strSQL & "       D10     = '" & LF_GetTPD051(befSeatid, "10") & "',"
            strSQL = strSQL & "       D11     = '" & LF_GetTPD051(befSeatid, "11") & "',"
            strSQL = strSQL & "       D12     = '" & LF_GetTPD051(befSeatid, "12") & "',"
            strSQL = strSQL & "       D13     = '" & LF_GetTPD051(befSeatid, "13") & "',"
            strSQL = strSQL & "       D14     = '" & LF_GetTPD051(befSeatid, "14") & "',"
            strSQL = strSQL & "       D15     = '" & LF_GetTPD051(befSeatid, "15") & "',"
            strSQL = strSQL & "       D16     = '" & LF_GetTPD051(befSeatid, "16") & "',"
            strSQL = strSQL & "       D17     = '" & LF_GetTPD051(befSeatid, "17") & "',"
            strSQL = strSQL & "       D18     = '" & LF_GetTPD051(befSeatid, "18") & "',"
            strSQL = strSQL & "       D19     = '" & LF_GetTPD051(befSeatid, "19") & "',"
            strSQL = strSQL & "       D20     = '" & LF_GetTPD051(befSeatid, "20") & "',"
            strSQL = strSQL & "       D21     = '" & LF_GetTPD051(befSeatid, "21") & "',"
            strSQL = strSQL & "       D22     = '" & LF_GetTPD051(befSeatid, "22") & "',"
            strSQL = strSQL & "       D23     = '" & LF_GetTPD051(befSeatid, "23") & "',"
            strSQL = strSQL & "       D24     = '" & LF_GetTPD051(befSeatid, "24") & "',"
            strSQL = strSQL & "       D25     = '" & LF_GetTPD051(befSeatid, "25") & "',"
            strSQL = strSQL & "       D26     = '" & LF_GetTPD051(befSeatid, "26") & "',"
            strSQL = strSQL & "       D27     = '" & LF_GetTPD051(befSeatid, "27") & "',"
            strSQL = strSQL & "       D28     = '" & LF_GetTPD051(befSeatid, "28") & "',"
            strSQL = strSQL & "       D29     = '" & LF_GetTPD051(befSeatid, "29") & "',"
            strSQL = strSQL & "       D30     = '" & LF_GetTPD051(befSeatid, "30") & "',"
            strSQL = strSQL & "       UPDID   = 'CNWG032',"
            strSQL = strSQL & "       UPDYMD  = '" & datNow & "'"
            strSQL = strSQL & " WHERE SEATID  = '" & RSet(aftSeatid, 5) & "'"
            strSQL = strSQL & " AND   TERMKIND IN ('TC0','TCA','TCB')"
            If Not L_Func.GF_UpdData(strSQL) Then
                Call L_Func.GF_RollbackTrans()
                Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                Exit Sub
            End If

            '---------------------------------
            'TPD051更新
            '移動元座席のゲーム再生情報をクリア
            '---------------------------------
            strSQL = ""
            strSQL = strSQL & "UPDATE TPD051"
            strSQL = strSQL & "   SET D1  = '0',"
            strSQL = strSQL & "       D2  = '0',"
            strSQL = strSQL & "       D3  = '0',"
            strSQL = strSQL & "       D4  = '0',"
            strSQL = strSQL & "       D5  = '0',"
            strSQL = strSQL & "       D6  = '0',"
            strSQL = strSQL & "       D7  = '0',"
            strSQL = strSQL & "       D8  = '0',"
            strSQL = strSQL & "       D9  = '0',"
            strSQL = strSQL & "       D10 = '0',"
            strSQL = strSQL & "       D11 = '0',"
            strSQL = strSQL & "       D12 = '0',"
            strSQL = strSQL & "       D13 = '0',"
            strSQL = strSQL & "       D14 = '0',"
            strSQL = strSQL & "       D15 = '0',"
            strSQL = strSQL & "       D16 = '0',"
            strSQL = strSQL & "       D17 = '0',"
            strSQL = strSQL & "       D18 = '0',"
            strSQL = strSQL & "       D19 = '0',"
            strSQL = strSQL & "       D20 = '0',"
            strSQL = strSQL & "       D21 = '0',"
            strSQL = strSQL & "       D22 = '0',"
            strSQL = strSQL & "       D23 = '0',"
            strSQL = strSQL & "       D24 = '0',"
            strSQL = strSQL & "       D25 = '0',"
            strSQL = strSQL & "       D26 = '0',"
            strSQL = strSQL & "       D27 = '0',"
            strSQL = strSQL & "       D28 = '0',"
            strSQL = strSQL & "       D29 = '0',"
            strSQL = strSQL & "       D30 = '0',"
            strSQL = strSQL & "       UPDID   = 'CNWG032',"
            strSQL = strSQL & "       UPDYMD  = '" & datNow & "'"
            strSQL = strSQL & " WHERE SEATID  = '" & RSet(befSeatid, 5) & "'"
            strSQL = strSQL & " AND   TERMKIND IN ('TC0','TCA','TCB')"
            If Not L_Func.GF_UpdData(strSQL) Then
                Call L_Func.GF_RollbackTrans()
                Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                Exit Sub
            End If

            If Not L_Func.GF_CommitTrans() Then
                Call L_Func.GF_RollbackTrans()
                Session(SessionMsgName) = "登録に失敗しました。再度登録を行って下さい。"
                Exit Sub
            End If

        End If

        L_BtnBack = True

        Session(SessionMsgName) = "座席移動行いました。【" & Session("SEATID") & "番席】→【" & Session("NUMBER") & "番席】"

        Exit Sub

    End Sub

    Private Function LF_GetSPMENU() As String
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetSPMENU = ""

        strSQL = ""
        strSQL = strSQL & "SELECT DEFMENUID"
        strSQL = strSQL & "  FROM TPM040"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG032(LF_GetSPMENU-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG032(LF_GetSPMENU-2)")
            Exit Function
        End If

        LF_GetSPMENU = Trim$(objRow("DEFMENUID"))
    End Function

    Private Function LF_GetSPMENU2(ByVal pSEATID As String) As String
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetSPMENU2 = ""

        strSQL = ""
        strSQL = strSQL & "SELECT TPM050.SPMENU2"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE TPM050.SEATID = '" & RSet(pSEATID, 5) & "'"
        strSQL = strSQL & "   AND TPM050.TERMKIND IN ('TC0','TCA','TCB')"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG032(LF_GetSPMENU-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG032(LF_GetSPMENU-2)")
            Exit Function
        End If

        LF_GetSPMENU2 = Trim$(objRow("SPMENU2"))
    End Function

    Private Function LF_GetTPD050(ByVal pSEATID As String, ByVal pCOUNT As String) As String
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetTPD050 = ""

        strSQL = ""
        strSQL = strSQL & "SELECT TPD050.D" & pCOUNT
        strSQL = strSQL & "  FROM TPD050"
        strSQL = strSQL & " WHERE SEATID = '" & RSet(pSEATID, 5) & "'"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Exit Function
        End If

        LF_GetTPD050 = objRow("D" & pCOUNT)

    End Function

    Private Function LF_GetTPD051(ByVal pSEATID As String, ByVal pCOUNT As String) As String
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetTPD051 = ""

        strSQL = ""
        strSQL = strSQL & "SELECT TPD051.D" & pCOUNT
        strSQL = strSQL & "  FROM TPD051"
        strSQL = strSQL & " WHERE SEATID = '" & RSet(pSEATID, 5) & "'"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Exit Function
        End If

        LF_GetTPD051 = objRow("D" & pCOUNT)

    End Function

    '' **************************************************
    ''  機能概要：座席移動処理が送信されたかを判断する。
    ''  引    数：
    ''  戻 り 値：True  ステーションで処理された
    ''            False ステーションで未処理
    '' **************************************************
    Private Function CheckSTNsendTblChg(ByVal befSEATID As String, ByVal aftSEATID As String) As Boolean
        Dim strSQL As String    '' SQL実行文字列
        Dim objData As DataSet  '' 取得した内容
        Dim objRow As DataRow = Nothing   '' 指定した位置の内容

        CheckSTNsendTblChg = False
        '' ------------------------------
        '' SQL実行文字列を生成する
        '' ------------------------------
        strSQL = ""
        strSQL = strSQL & " SELECT * FROM TPD050"
        strSQL = strSQL & "  WHERE SEATID='" & RSet(befSEATID, 5) & "'"
        strSQL = strSQL & "    AND D10    <> '0'"
        strSQL = strSQL & "    AND TERMKIND IN ('TCA','TC0','TCB')"
        strSQL = strSQL & " UNION"
        strSQL = strSQL & " SELECT * FROM TPD050"
        strSQL = strSQL & "  WHERE SEATID='" & RSet(befSEATID, 5) & "'"
        strSQL = strSQL & "    AND D10    <> '0'"
        strSQL = strSQL & "    AND TERMKIND IN ('TCA','TC0','TCB')"
        objData = New DataSet()

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            CheckSTNsendTblChg = True
            Exit Function
        End If

    End Function

    '' **************************************************
    ''  機能概要：座席移動処理が送信されたかを判断する。
    ''  引    数：
    ''  戻 り 値：1 データ更新失敗
    ''            3 顧客ファイル有り
    '' **************************************************
    Private Function CheckSTNsendTblChgErr(ByVal aftSEATID As String) As String
        Dim strSQL As String    '' SQL実行文字列
        Dim objData As DataSet  '' 取得した内容
        Dim objRow As DataRow = Nothing   '' 指定した位置の内容

        CheckSTNsendTblChgErr = "1"
        '' ------------------------------
        '' SQL実行文字列を生成する
        '' ------------------------------
        strSQL = ""
        strSQL = strSQL & " SELECT TPD050.D10 FROM TPD050"
        strSQL = strSQL & "  WHERE SEATID='" & RSet(aftSEATID, 5) & "'"
        strSQL = strSQL & "    AND TERMKIND IN ('TCA','TC0','TCB')"
        objData = New DataSet()

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Exit Function
        End If

        CheckSTNsendTblChgErr = Trim(objRow("D10"))

    End Function

    Private Function LF_SeatCheck() As Boolean
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_SeatCheck = False

        strSQL = ""

        '配席機能使用有無により、抽出条件を変更
        If L_Func.GF_GetAppInfo("SEAT_DISTRIBUTION") = "1" Then
            strSQL = strSQL & "SELECT SEATID"
            strSQL = strSQL & "  FROM TPM050"
            strSQL = strSQL & " WHERE SEATID ='" & RSet(Session("SEATID"), 5) & "'"
            strSQL = strSQL & "   AND TERMKIND IN ('TC0','TCA','TCB')"
        Else
            strSQL = strSQL & "SELECT SEATID"
            strSQL = strSQL & "  FROM TPD050"
            strSQL = strSQL & " WHERE SEATID ='" & RSet(Session("SEATID"), 5) & "'"
            strSQL = strSQL & "   AND TERMKIND IN ('TC0','TCA','TCB')"
        End If

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG032(LF_SeatCheck_1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG032(LF_SeatCheck_3)")
            Exit Function
        End If

        LF_SeatCheck = True
    End Function

    Private Function LF_SeatCheck2() As Boolean
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_SeatCheck2 = False

        strSQL = ""
        strSQL = strSQL & "SELECT SEATID"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE SEATID ='" & RSet(Session("NUMBER"), 5) & "'"
        strSQL = strSQL & "   AND ORDERSTATUS = '1'"
        strSQL = strSQL & "   AND TERMKIND IN ('TCA','TC0','TCB')"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG032(LF_SeatCheck2_1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            LF_SeatCheck2 = True
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG032(LF_SeatCheck2_3)")
            Exit Function
        End If

    End Function

    Private Sub btn_Click(ByVal pNUM As String)
        If pNUM = "10" Then
            lbl_number.Text = ""
            Session("NUMBER") = ""
        Else
            If Len(Session("NUMBER")) < 2 Then
                If Len(Session("NUMBER")) < 1 AndAlso pNUM = "0" Then
                    lbl_number.Text = ""
                Else
                    lbl_number.Text = Session("NUMBER") & pNUM
                    Session("NUMBER") = Session("NUMBER") & pNUM
                End If
            Else
                lbl_number.Text = Session("NUMBER")
            End If
        End If
    End Sub


    '' **************************************************
    ''  機能概要：<body>にonLoadイベントを出力する。
    ''  引    数：
    ''  戻 り 値：
    '' **************************************************
    Public Sub OnInitBody()
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        strSQL = ""
        strSQL = strSQL & "SELECT POSITION FROM TPM050"
        strSQL = strSQL & "       WHERE TERMKIND = 'TC9'"
        strSQL = strSQL & "         AND TERMID = '" & Trim$(Request.UserHostAddress) & "'"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG032(LF_CheckOrderStatus-1)")
            Exit Sub
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Sub
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG032(LF_CheckOrderStatus-2)")
            Exit Sub
        End If

        If L_BtnBack Then
            Response.Write("onLoad='parent.fWinClose();'")
        Else
            If L_BtnPrev Then
                Select Case objRow("POSITION").ToString
                    Case "20"
                        Response.Write("onLoad='fChgPage(" & Trim(Session("SEATID")) & ", """ & Trim(Request.QueryString("MENUID")) & """, """ & Trim(Request.QueryString("COURSE")) & """, """ & Trim(Request.QueryString("GOODSCD")) & """);'")
                    Case "21"
                        Response.Write("onLoad='fChgPage2(" & Trim(Session("SEATID")) & ", """ & Trim(Request.QueryString("MENUID")) & """, """ & Trim(Request.QueryString("COURSE")) & """, """ & Trim(Request.QueryString("GOODSCD")) & """);'")
                End Select
            End If
        End If
        ''201111
        'Response.Write("onLoad='fSetMessage(""" & Session("msg") & """);'")

    End Sub

    Private Sub LS_ButtonNotProtect()
        'インナーフレーム表示時は各種ボタン非プロテクト
        btn_0.Attributes("ONCLICK") = "return true"
        btn_1.Attributes("ONCLICK") = "return true"
        btn_2.Attributes("ONCLICK") = "return true"
        btn_3.Attributes("ONCLICK") = "return true"
        btn_4.Attributes("ONCLICK") = "return true"
        btn_5.Attributes("ONCLICK") = "return true"
        btn_6.Attributes("ONCLICK") = "return true"
        btn_7.Attributes("ONCLICK") = "return true"
        btn_8.Attributes("ONCLICK") = "return true"
        btn_9.Attributes("ONCLICK") = "return true"
        btn_cls.Attributes("ONCLICK") = "return true"
        btn_Set.Attributes("ONCLICK") = "return true"
        btn_back.Attributes("ONCLICK") = "parent.fWinClose();"
    End Sub

    Private Function LF_GetOrderNo(ByVal pSEATID As String) As Long
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetOrderNo = 0

        strSQL = ""
        strSQL = strSQL & "SELECT ORDERNO, SELECTTIME"
        strSQL = strSQL & "  FROM TPD010"
        strSQL = strSQL & " WHERE SEATID ='" & RSet(pSEATID, 5) & "'"
        strSQL = strSQL & " ORDER BY SELECTTIME DESC"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG032(LF_GetOrderNo_1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG032(LF_GetOrderNo_3)")
            Exit Function
        End If

        LF_GetOrderNo = CLng(objRow("ORDERNO"))
    End Function

    Private Function LF_GetTermID(ByVal pSEATID As String) As String
        Dim strSQL As String        '' SQL実行文字列
        Dim objDataSet As DataSet   '' DataSetオブジェクト
        Dim objDataRow As DataRow = Nothing   '' DataRowオブジェクト

        LF_GetTermID = ""

        strSQL = "SELECT TERMID"
        strSQL = strSQL & " FROM TPM050"
        strSQL = strSQL & " WHERE SEATID = '" & RSet(pSEATID, 5) & "'"
        strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCA'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCB') "
        strSQL = strSQL & " ORDER BY TERMID"

        objDataSet = New DataSet()
        If Not L_Func.GF_GetData(strSQL, objDataSet) Then
            Response.Redirect("./TP2990.html?CNWG032(LF_GetTermID_2-1)")
            Exit Function
        End If

        If objDataSet.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objDataSet, 0, objDataRow) Then
            Response.Redirect("./TP2990.html?CNWG032(LF_GetTermID_2-2)")
            Exit Function
        End If

        LF_GetTermID = Trim$(objDataRow("TERMID"))
    End Function

    '***********************************
    '指定座席番号のオーダー状況取得
    '
    'True:注文有り　False：注文無し
    '***********************************
    Private Function TPD010_ORDERCHECK(ByVal pSEATID As String) As Boolean

        TPD010_ORDERCHECK = False

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()
        Dim dtrRows As DataRow = Nothing
        Dim strMaterial(1) As String
        Dim strTimeKey As String = Nothing

        strSQL = ""
        strSQL = strSQL & "SELECT TPM010.GOODSCD,"
        strSQL = strSQL & "       TPM010.GOODSNMJ,"
        strSQL = strSQL & "       TPM010.GOODSNMJ2,"
        strSQL = strSQL & "       TPM010.UNITJ,"
        strSQL = strSQL & "       TPM010.PRICE,"
        strSQL = strSQL & "       (SELECT TPM010.GOODSNMJ FROM TPM010 WHERE TPD010.SCPMENU1 = TPM010.GOODSCD) AS SCP1,"
        strSQL = strSQL & "       (SELECT TPM010.GOODSNMJ FROM TPM010 WHERE TPD010.SCPMENU2 = TPM010.GOODSCD) AS SCP2,"
        strSQL = strSQL & "       (SELECT TPM010.GOODSNMJ FROM TPM010 WHERE TPD010.SCPMENU3 = TPM010.GOODSCD) AS SCP3,"
        strSQL = strSQL & "       (SELECT TPM010.GOODSNMJ FROM TPM010 WHERE TPD010.SCPMENU4 = TPM010.GOODSCD) AS SCP4,"
        strSQL = strSQL & "       TPD010.SCPCD1,"
        strSQL = strSQL & "       TPD010.SCPCD2,"
        strSQL = strSQL & "       TPD010.SCPCD3,"
        strSQL = strSQL & "       TPD010.SCPCD4,"
        strSQL = strSQL & "       TPD010.SCPMENU3,"
        strSQL = strSQL & "       TPD010.SCPMENU4,"
        strSQL = strSQL & "       TPD010.SCPQUANTITY3,"
        strSQL = strSQL & "       TPD010.SCPQUANTITY4,"
        strSQL = strSQL & "       TPD010.SCPMENU1,"
        strSQL = strSQL & "       TPD010.SCPMENU2,"
        strSQL = strSQL & "       TPD010.QUANTITY,"
        strSQL = strSQL & "       TPD010.SCPQUANTITY1,"
        strSQL = strSQL & "       TPD010.SCPQUANTITY2,"
        strSQL = strSQL & "       TPD010.SELECTTIME,"
        strSQL = strSQL & "       TPD010.TRANSTIME,"
        strSQL = strSQL & "       TPD010.ORDERTIME,"
        strSQL = strSQL & "       TPD010.ORDERFLG AS ORDERFLG"
        strSQL = strSQL & "  FROM TPM010,"
        strSQL = strSQL & "       TPD010"
        strSQL = strSQL & " WHERE TPD010.TERMID = '" & LF_GetTermID(pSEATID) & "'"
        strSQL = strSQL & "   AND TPD010.GOODSCD = TPM010.GOODSCD"
        strSQL = strSQL & "   AND TPD010.SELECTTIME <> 0"
        strSQL = strSQL & "   AND TPD010.ORDERTIME <> 0"
        strSQL = strSQL & "   AND (TPD010.ORDERFLG = '" & Session("TP").GC_ORDER_SELECT & "'"                '客席端末からのオーダー
        strSQL = strSQL & "    OR  TPD010.ORDERFLG = '" & Session("TP").GC_ORDER_SELECT_1 & "'"              '客席厨房からのオーダー
        strSQL = strSQL & "    OR  TPD010.ORDERFLG = '" & Session("TP").GC_ORDER_FREEDRINK & "')"            '飲み放題メニューのオーダー
        strSQL = strSQL & "   AND TPD010.GOODSCD <> '" & Session("TP").GF_GetAppInfo("REG_GOODSCD") & "'"
        strSQL = strSQL & "   AND TPD010.GOODSCD <> '" & Session("TP").GF_GetAppInfo("OPEN_GOODSCD") & "'"
        strSQL = strSQL & " AND TPD010.ORDERNO =" & LF_GetOrderNo(pSEATID)
        strSQL = strSQL & " ORDER BY TPD010.ORDERTIME DESC,"
        strSQL = strSQL & "          TPD010.SELECTTIME"

        If Not Session("TP").GF_GetData(strSQL, dtsData) Then
            Response.Redirect("./TP2990.html?CNWG032TPD010_ORDERCHECK-1)")
            Exit Function
        End If

        If dtsData.Tables("com").Rows.Count <> 0 Then
            TPD010_ORDERCHECK = True
        End If

    End Function
End Class
