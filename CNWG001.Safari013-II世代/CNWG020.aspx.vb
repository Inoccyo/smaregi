' 2014-08-08 table_N オブジェクトをコメント化
' JavaScriptの fAlertN について調べたところ関数 GF_Check_SPMENU2 を CNWG020 で呼び出す部分がどこにもないことが判明
'
'
'
'
'
'
'
'
Partial Class CNWG020
    Inherits System.Web.UI.Page
    Protected WithEvents btn_table1_status As System.Web.UI.WebControls.Label
    Protected WithEvents btn_table2_status As System.Web.UI.WebControls.Label
    Protected WithEvents btn_table3_status As System.Web.UI.WebControls.Label
    Protected WithEvents btn_table4_status As System.Web.UI.WebControls.Label
    Protected WithEvents btn_table5_status As System.Web.UI.WebControls.Label



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

    Private L_Iframe As String
    Private L_Seat As System.Web.UI.WebControls.Button
    Private L_Func As TP2920
    Private L_Yobi As String
    Private strOrderStatus As String
    Private Const SessionMsgName As String = "CNWG001.Msg"   '各画面のメッセージセッション変数名と同一である必要があります

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        ' ページを初期化する ユーザー コードをここに挿入します。

        '------------------------------
        ' セッション状態確認
        '------------------------------
        If IsNothing(Session("TP")) Then
            L_Func = New TP2920()
            If Not L_Func.GF_Initialize() Then
                Response.Redirect("./TP2990.html?CNWG020(Page_Load-1)")
                Exit Sub
            End If
            Session("TP") = L_Func
        Else
            L_Func = Session("TP")
        End If

        If Request.QueryString("NOJUMP") <> "1" Then
            Call LF_ChgDspPage()
        End If

        Me.ViewState("REG_GOODSCD") = L_Func.GF_GetAppInfo("REG_GOODSCD")       'お会計
        Me.ViewState("OPEN_GOODSCD") = L_Func.GF_GetAppInfo("OPEN_GOODSCD")     'お通し
        Me.ViewState("CALL_GOODSCD") = L_Func.GF_GetAppInfo("CALL_GOODSCD")
        Me.ViewState("ALERT_TIME4") = L_Func.GF_GetAppInfo("ALERT_TIME4")       'メニュー切替機能(コースの警告表示前時間)
        Me.ViewState("TPG_FLG") = L_Func.GF_GetAppInfo("TPG_FLG")
        Me.ViewState("ESPRO_KCPNO") = L_Func.GF_GetAppInfo("ESPRO_KCPNO")       '表示機連動用にORDERSTATUS追加　6：呼出中、7：会計中、8：呼出確認済、9：会計確認済
        Me.ViewState("CNWG_INPUT_NUMBER") = L_Func.GF_GetAppInfo3("CNWG_INPUT_NUMBER")      'TEC連動以外　お通しパネル人数入力　0：無効　1：有効

        '2014-08-23 POSTは使わないはず
        Call LS_ButtonProtect()

        If Trim$(Request.QueryString("MODE")) = "" Then
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")

        Else
            '端末設定画面からの遷移時
            Call LF_SetCNWGForm()
            Call LF_SetForm("1")
            Call LF_ParaPos()

            'btn_back.Attributes("ONCLICK") = "fWinClosePos();"
        End If

        '終了状態の時、CNWAへ遷移
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim strSQL As String

        strSQL = ""
        strSQL = strSQL & "SELECT CLMODE FROM TPM040"
        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG020(PageWrite-1)")
            Exit Sub
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Response.Redirect("./TP2990.html?CNWG020(PageWrite-2)")
            Exit Sub
        End If
        If Not Session("TP").GF_GetRows(objData, 0, objRows) Then
            Response.Redirect("./TP2990.html?CNWG020(PageWrite-3)")
            Exit Sub
        End If
        If Trim$(objRows("CLMODE")) = "1" Then
            Response.Redirect("/CNWA001/CNWA010.aspx")
            Exit Sub
        End If

        '客席閉鎖機能対応
        If L_Func.GF_GetAppInfo2("SEAT_CLOSURE_FLG") = "0" Then
            btn_CLOSURE.Visible = True
            btn_CLOSURE.Text = L_Func.GF_GetAppInfo2("SEAT_CLOSURE_MSG")
        Else
            btn_CLOSURE.Visible = False
        End If

        '閉鎖ボタンタッチ時
        If Request.QueryString("CLOSUREFLG") <> "" Then
            btn_CLOSURE_Click()
            Exit Sub
        End If

        If Request.QueryString("RELEASEFLG") <> "" Then
            btn_Release_Click()
            Exit Sub
        End If

        '------------------------------
        ' ポストバック時は処理対象外
        '------------------------------
        If IsPostBack Then
            Exit Sub
        End If

        'テーブルボタンクリック時
        If Trim$(Request.QueryString("TABLEID")) <> "" Then
            LS_TableClick()
        End If
    End Sub

    ''' <summary>
    ''' 残り時間取得（分）
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_GetTimeLimit(ByVal pSeatID As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        Dim StartTime As DateTime
        Dim FreeTime As Integer
        Dim FreeTimeZan As Integer

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTimeLimit = ""

        '------------------------------
        ' 座席拡張テーブル取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT D6,D7,D8"
        strSQL = strSQL & "  FROM TPD050"
        strSQL = strSQL & " WHERE SEATID = '" & pSeatID & "'"
        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If
        If Not Session("TP").GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        Try
            StartTime = DateTime.ParseExact(objRows("D6").ToString, "yyyyMMddHHmmss", Nothing)
            FreeTime = CInt(objRows("D7").ToString)

            If System.DateTime.Now > StartTime.AddMinutes(FreeTime) Then
                Exit Function
            Else
                Dim ts As TimeSpan = StartTime.AddMinutes(FreeTime) - System.DateTime.Now

                FreeTimeZan = ts.TotalMinutes
            End If

        Catch ex As Exception
            Exit Function
        End Try

        LF_GetTimeLimit &= FreeTimeZan.ToString

    End Function

    ''' <summary>
    ''' 残り時間取得（分）
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LF_GetTimeLimit_LO(ByVal pSeatID As String) As String

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        Dim StartTime As DateTime
        Dim FreeTime As Integer
        Dim FreeTimeZan As Integer
        Dim FreeCourses As String = ""
        Dim LastCallTime As Integer

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTimeLimit_LO = ""

        '------------------------------
        ' 座席拡張テーブル取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT D6,D7,D8"
        strSQL = strSQL & "  FROM TPD050"
        strSQL = strSQL & " WHERE SEATID = '" & pSeatID & "'"
        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If
        If Not Session("TP").GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        Try
            StartTime = DateTime.ParseExact(objRows("D6").ToString, "yyyyMMddHHmmss", Nothing)
            FreeTime = CInt(objRows("D7").ToString)
            FreeCourses = objRows("D8").ToString

            '------------------------------
            ' ラストオーダー時間取得
            '------------------------------
            LastCallTime = FreeTime - LF_GetLastCallTime(FreeCourses)

            'If System.DateTime.Now > StartTime.AddMinutes(FreeTime) Then
            If System.DateTime.Now > StartTime.AddMinutes(LastCallTime) Then
                Exit Function
            Else
                'Dim ts As TimeSpan = StartTime.AddMinutes(FreeTime) - System.DateTime.Now
                Dim ts As TimeSpan = StartTime.AddMinutes(LastCallTime) - System.DateTime.Now

                FreeTimeZan = ts.TotalMinutes

                If FreeTimeZan = 0 Then
                    FreeTimeZan = 1
                End If

            End If

        Catch ex As Exception
            Exit Function
        End Try

        LF_GetTimeLimit_LO &= FreeTimeZan.ToString

    End Function

    ' **************************************************
    '	機能概要：放題商品のラストオーダーの最大値を
    '	引	  数：登録中の飲み放題商品コード一覧
    '	戻 り 値：オーダー連番の最大値
    ' **************************************************
    Private Function LF_GetLastCallTime(ByVal pFreeCourse As String) As Integer
        Dim strSQL As String = Nothing '' SQL実行文字列
        Dim objData As DataSet '' キャッシュ情報
        Dim objRow As DataRow = Nothing '' 指定行情報

        LF_GetLastCallTime = 1
        '' ------------------------------
        '' 登録中放題商品のラストオーダー時刻の
        '' ------------------------------
        strSQL = "SELECT MAX(LASTCALLTIME) AS LASTCALLTIME"
        strSQL = strSQL & " FROM TPM300"
        strSQL = strSQL & " WHERE FREECOURSEGOODSCD IN (" & pFreeCourse & ")"

        objData = New DataSet()
        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count < 1 Then
            Exit Function
        End If

        If Not Session("TP").GF_GetRows(objData, 0, objRow) Then
            Exit Function
        End If

        LF_GetLastCallTime = Trim$(objRow("LASTCALLTIME"))
    End Function

    ''' <summary>
    ''' 画面更新Script追加
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub GS_Reload()
        '重複処理制御
        If Session("CNWG001_Reload") <> "1" And Trim$(Request.QueryString("TABLEID")).IndexOf("btn_table") = -1 Then
            Session("CNWG001_Reload") = "1"
        Else
            Session("CNWG001_Reload") = ""
        End If
        Response.Write("Reflexive();")
        'If Not IsPostBack Then
        '    Response.Write("Reflexive();")
        'End If

    End Sub

    ''' <summary>
    ''' テーブルボタン処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LS_TableClick()

        Dim SeatID As String = Trim$(Request.QueryString("TABLEID")).Replace("btn_table", "")
        Dim SeatPos As String
        Dim btn_table As Button = CType(FindControl(Trim$(Request.QueryString("TABLEID"))), Button)
        Dim hdn_btn_table As Button = CType(FindControl("hdn_btn_table" & SeatID), Button)
        Dim strTERMID As String = Nothing '' 端末識別ID
        Dim lngORDERNO As Long = 0  '' オーダー連番

        L_Seat = hdn_btn_table

        strOrderStatus = LF_GetOrderStatus()

        lngORDERNO = LF_GetOrderNo(L_Seat.Text)

        strTERMID = LF_GetTermID(L_Seat.Text)

        '重複処理制御
        'If Session("CNWG001_submit") = "1" Then
            Session("CNWG001_submit") = ""
        '    Exit Sub
        'End If

        If Trim$(strOrderStatus) = "5" Or Trim$(strOrderStatus) = "A" Then
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            If L_Func.GF_GetAppInfo("SEAT_DISTRIBUTION") = "0" Then   '配席機能使用
                Call LF_Seatcancel(L_Seat.Text)
            End If
            Session("CNWG001_submit") = "1"
            Exit Sub

            '表示機オプション
            If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
                Call LS_Update_TPD500(L_Seat.Text, "2")
            End If
            Session("CNWG001_submit") = "1"
            Exit Sub

        ElseIf Trim$(strOrderStatus) = "C" Then
            Call LF_SetSQLTPM050_C(L_Seat.Text)
            Call LF_SetDefaultForm() 'ボタン初期化
            Call LF_SetForm("0")
            Exit Sub

        ElseIf LS_DispCustomer(L_Seat.Text) And L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_Update_TPD500(L_Seat.Text, "1")
            Exit Sub

        ElseIf Trim$(strOrderStatus) = "2" And Me.ViewState("TPG_FLG") = "1" And Me.ViewState("CNWG_INPUT_NUMBER") = "0" Then
            '精算連動無し、お通し処理 人数入力なし
            Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
            Call LF_SetSQLTPD010(L_Seat.Text)
            Call LF_SetDefaultForm()
            Call LF_SetForm("0")
            Exit Sub
        End If

        If Trim$(Request.QueryString("MODE")) = "" Then
            If Session("TP").GF_GetAppInfo("IPPATSU_FLG") = "1" Then
                L_Seat = hdn_btn_table
                Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)

                strOrderStatus = LF_GetOrderStatus()

                If Trim$(strOrderStatus) = "5" Then
                    lngORDERNO = lngORDERNO - 1
                    Call LF_SetSQLTPD010_C(strTERMID, lngORDERNO, L_Seat.Text)
                    'お会計処理
                    Session(SessionMsgName) = "【" & L_Seat.Text & "番席】" & "お会計を受付ました。"
                    'Call LF_SetTransTime(L_Seat.Text)
                End If

                If Session("TP").GF_GetAppInfo3("SOBA_FLG") = "1" Then
                    Call LF_SetSQLTPM050(strOrderStatus, L_Seat.Text)
                    Call LF_SetSQLTPD010(L_Seat.Text)
                    Call LF_SetDefaultForm()
                    Call LF_SetForm("0")
                Else
                    Call LF_SetForm("0")
                End If
            Else
                L_Iframe = "1"
                L_Seat = hdn_btn_table
                'インナーフレーム表示時はボタンプロテクト
                Call LS_ButtonProtect()
            End If
            'L_Iframe = "1"
            'L_Seat = hdn_btn_table
            ''インナーフレーム表示時はボタンプロテクト
            'Call LS_ButtonProtect()
        Else
            Select Case SeatID
                Case "1"
                    SeatPos = "11"
                Case "2"
                    SeatPos = "12"
                Case "3"
                    SeatPos = "13"
                Case "4"
                    SeatPos = "14"
                Case "5"
                    SeatPos = "15"
                Case "6"
                    SeatPos = "16"
                Case "7"
                    SeatPos = "17"
                Case "8"
                    SeatPos = "18"
                Case "9"
                    SeatPos = "19"
                Case "10"
                    SeatPos = "20"
                Case "11"
                    SeatPos = "21"
                Case "12"
                    SeatPos = "22"
                Case "13"
                    SeatPos = "23"
                Case "14"
                    SeatPos = "24"
                Case "15"
                    SeatPos = "25"
                Case "16"
                    SeatPos = "26"
                Case "17"
                    SeatPos = "27"
                Case "18"
                    SeatPos = "28"
                Case "19"
                    SeatPos = "29"
                Case "20"
                    SeatPos = "30"
                Case "21"
                    SeatPos = "31"
                Case "22"
                    SeatPos = "32"
                Case "23"
                    SeatPos = "33"
                Case "24"
                    SeatPos = "34"
                Case "25"
                    SeatPos = "35"
                Case "26"
                    SeatPos = "36"
                Case "27"
                    SeatPos = "37"
                Case "28"
                    SeatPos = "38"
                Case "31"
                    SeatPos = "39"
                Case "32"
                    SeatPos = "40"
                Case "41"
                    SeatPos = "41"
                Case "42"
                    SeatPos = "42"
                Case "51"
                    SeatPos = "43"
                Case "52"
                    SeatPos = "44"
                Case "53"
                    SeatPos = "45"
                Case "54"
                    SeatPos = "46"
                Case "61"
                    SeatPos = "47"
                Case "62"
                    SeatPos = "48"
                Case "71"
                    SeatPos = "49"
                Case "72"
                    SeatPos = "50"
                Case "73"
                    SeatPos = "51"
                Case "74"
                    SeatPos = "52"
                Case "75"
                    SeatPos = "53"
                Case "76"
                    SeatPos = "54"
                Case "77"
                    SeatPos = "55"
                Case "78"
                    SeatPos = "56"
                Case "79"
                    SeatPos = "56"
                Case "80"
                    SeatPos = "58"
                Case "81"
                    SeatPos = "59"
                Case "82"
                    SeatPos = "60"
                Case "83"
                    SeatPos = "61"
                Case "84"
                    SeatPos = "62"
                Case "85"
                    SeatPos = "63"
                Case "86"
                    SeatPos = "64"
                Case "87"
                    SeatPos = "65"
                Case "88"
                    SeatPos = "66"
                Case "89"
                    SeatPos = "67"
                Case "90"
                    SeatPos = "68"
                Case "91"
                    SeatPos = "69"
                Case "92"
                    SeatPos = "70"
                Case "93"
                    SeatPos = "71"
                Case "94"
                    SeatPos = "72"
                Case "95"
                    SeatPos = "73"
                Case "96"
                    SeatPos = "74"
                Case "97"
                    SeatPos = "75"
                Case "98"
                    SeatPos = "76"
                Case "99"
                    SeatPos = "77"
                Case "100"
                    SeatPos = "78"
                Case "101"
                    SeatPos = "79"
                Case Else
                    SeatPos = ""
            End Select
            txt_Pos.Text = SeatPos
            LS_SelectTablePos(btn_table)
        End If
    End Sub

    Private Function LF_SetCNWGForm() As Object

        LF_SetCNWGForm = Nothing

        '端末設定画面からの遷移時
        '全てのテーブルの色を未設定にする
        'table_1.BackColor = System.Drawing.Color.White
        'table_2.BackColor = System.Drawing.Color.White
        'table_3.BackColor = System.Drawing.Color.White
        'table_4.BackColor = System.Drawing.Color.White
        'table_5.BackColor = System.Drawing.Color.White
        'table_6.BackColor = System.Drawing.Color.White
        'table_7.BackColor = System.Drawing.Color.White
        'table_8.BackColor = System.Drawing.Color.White
        'table_9.BackColor = System.Drawing.Color.White
        'table_10.BackColor = System.Drawing.Color.White
        'table_11.BackColor = System.Drawing.Color.White
        'table_12.BackColor = System.Drawing.Color.White
        'table_13.BackColor = System.Drawing.Color.White
        'table_14.BackColor = System.Drawing.Color.White
        'table_15.BackColor = System.Drawing.Color.White
        'table_16.BackColor = System.Drawing.Color.White
        'table_17.BackColor = System.Drawing.Color.White
        'table_18.BackColor = System.Drawing.Color.White
        'table_19.BackColor = System.Drawing.Color.White
        'table_20.BackColor = System.Drawing.Color.White
        'table_21.BackColor = System.Drawing.Color.White
        'table_22.BackColor = System.Drawing.Color.White
        'table_23.BackColor = System.Drawing.Color.White
        'table_24.BackColor = System.Drawing.Color.White
        'table_25.BackColor = System.Drawing.Color.White
        'table_26.BackColor = System.Drawing.Color.White
        'table_27.BackColor = System.Drawing.Color.White
        'table_28.BackColor = System.Drawing.Color.White
        'table_29.BackColor = System.Drawing.Color.White
        'table_30.BackColor = System.Drawing.Color.White
        'table_31.BackColor = System.Drawing.Color.White
        'table_32.BackColor = System.Drawing.Color.White
        'table_33.BackColor = System.Drawing.Color.White
        'table_34.BackColor = System.Drawing.Color.White
        'table_35.BackColor = System.Drawing.Color.White
        'table_36.BackColor = System.Drawing.Color.White
        'table_37.BackColor = System.Drawing.Color.White
        'table_38.BackColor = System.Drawing.Color.White
        'table_39.BackColor = System.Drawing.Color.White
        'table_41.BackColor = System.Drawing.Color.White
        'table_42.BackColor = System.Drawing.Color.White
        'table_51.BackColor = System.Drawing.Color.White
        'table_52.BackColor = System.Drawing.Color.White
        'table_53.BackColor = System.Drawing.Color.White
        'table_54.BackColor = System.Drawing.Color.White
        'table_61.BackColor = System.Drawing.Color.White
        'table_62.BackColor = System.Drawing.Color.White

        '全てのボタン文字を表示しない
        btn_table1.Text = ""
        btn_table2.Text = ""
        btn_table3.Text = ""
        btn_table4.Text = ""
        btn_table5.Text = ""
        btn_table6.Text = ""
        btn_table7.Text = ""
        btn_table8.Text = ""
        btn_table9.Text = ""
        btn_table10.Text = ""
        btn_table11.Text = ""
        btn_table12.Text = ""
        btn_table13.Text = ""
        btn_table14.Text = ""
        btn_table15.Text = ""
        btn_table16.Text = ""
        btn_table17.Text = ""
        btn_table18.Text = ""
        btn_table19.Text = ""
        btn_table20.Text = ""
        btn_table21.Text = ""
        btn_table22.Text = ""
        btn_table23.Text = ""
        btn_table24.Text = ""
        btn_table25.Text = ""
        btn_table26.Text = ""
        btn_table27.Text = ""
        btn_table28.Text = ""
        'btn_table30.Text = ""
        btn_table31.Text = ""
        btn_table32.Text = ""
        'btn_table33.Text = ""
        'btn_table34.Text = ""
        'btn_table35.Text = ""
        'btn_table36.Text = ""
        'btn_table37.Text = ""
        'btn_table38.Text = ""
        'btn_table39.Text = ""
        btn_table41.Text = ""
        btn_table42.Text = ""
        btn_table51.Text = ""
        btn_table52.Text = ""
        btn_table53.Text = ""
        btn_table54.Text = ""
        btn_table61.Text = ""
        btn_table62.Text = ""
        btn_table71.Text = ""
        btn_table72.Text = ""
        btn_table73.Text = ""
        btn_table74.Text = ""
        btn_table75.Text = ""
        btn_table76.Text = ""
        btn_table77.Text = ""
        btn_table78.Text = ""
        btn_table79.Text = ""
        btn_table80.Text = ""
        btn_table81.Text = ""
        btn_table82.Text = ""
        btn_table83.Text = ""
        btn_table84.Text = ""
        btn_table85.Text = ""
        btn_table86.Text = ""
        btn_table87.Text = ""
        btn_table88.Text = ""
        btn_table89.Text = ""
        btn_table158.Text = ""
        btn_table159.Text = ""
        btn_table160.Text = ""
        btn_table161.Text = ""
        btn_table162.Text = ""
        btn_table163.Text = ""
        btn_table164.Text = ""
        btn_table165.Text = ""
        btn_table166.Text = ""
        btn_table167.Text = ""
        btn_table168.Text = ""
        btn_table169.Text = ""
        btn_table170.Text = ""
        btn_table171.Text = ""
        btn_table172.Text = ""
        btn_table173.Text = ""
        btn_table174.Text = ""
        btn_table175.Text = ""
        btn_table176.Text = ""
        btn_table177.Text = ""
        btn_table178.Text = ""
        btn_table179.Text = ""
        btn_table180.Text = ""

        '表示項目制御
        btn_back.Visible = True
        btn_cancel.Visible = True
        btn_refresh.Text = "設定"
        txt_Pos.Visible = True
        txt_Pos.Text = ""

        '遷移してきたテーブル位置
        txt_Pos.Text = Trim$(Request.QueryString("POS"))

    End Function

    Private Function LF_SetDefaultForm() As Object

        LF_SetDefaultForm = Nothing

        '全てのテーブルの色を未設定にする
        'table_1.BackColor = System.Drawing.Color.White
        'table_2.BackColor = System.Drawing.Color.White
        'table_3.BackColor = System.Drawing.Color.White
        'table_4.BackColor = System.Drawing.Color.White
        'table_5.BackColor = System.Drawing.Color.White
        'table_6.BackColor = System.Drawing.Color.White
        'table_7.BackColor = System.Drawing.Color.White
        'table_8.BackColor = System.Drawing.Color.White
        'table_9.BackColor = System.Drawing.Color.White
        'table_10.BackColor = System.Drawing.Color.White
        'table_11.BackColor = System.Drawing.Color.White
        'table_12.BackColor = System.Drawing.Color.White
        'table_13.BackColor = System.Drawing.Color.White
        'table_14.BackColor = System.Drawing.Color.White
        'table_15.BackColor = System.Drawing.Color.White
        'table_16.BackColor = System.Drawing.Color.White
        'table_17.BackColor = System.Drawing.Color.White
        'table_18.BackColor = System.Drawing.Color.White
        'table_19.BackColor = System.Drawing.Color.White
        'table_20.BackColor = System.Drawing.Color.White
        'table_21.BackColor = System.Drawing.Color.White
        'table_22.BackColor = System.Drawing.Color.White
        'table_23.BackColor = System.Drawing.Color.White
        'table_24.BackColor = System.Drawing.Color.White
        'table_25.BackColor = System.Drawing.Color.White
        'table_26.BackColor = System.Drawing.Color.White
        'table_27.BackColor = System.Drawing.Color.White
        'table_28.BackColor = System.Drawing.Color.White
        'table_29.BackColor = System.Drawing.Color.White
        'table_30.BackColor = System.Drawing.Color.White
        'table_31.BackColor = System.Drawing.Color.White
        'table_32.BackColor = System.Drawing.Color.White
        'table_33.BackColor = System.Drawing.Color.White
        'table_34.BackColor = System.Drawing.Color.White
        'table_35.BackColor = System.Drawing.Color.White
        'table_36.BackColor = System.Drawing.Color.White
        'table_37.BackColor = System.Drawing.Color.White
        'table_38.BackColor = System.Drawing.Color.White
        'table_39.BackColor = System.Drawing.Color.White
        'table_41.BackColor = System.Drawing.Color.White
        'table_42.BackColor = System.Drawing.Color.White
        'table_51.BackColor = System.Drawing.Color.White
        'table_52.BackColor = System.Drawing.Color.White
        'table_53.BackColor = System.Drawing.Color.White
        'table_54.BackColor = System.Drawing.Color.White
        'table_61.BackColor = System.Drawing.Color.White
        'table_62.BackColor = System.Drawing.Color.White

        '全てのボタンを非表示にする
        btn_table1.Visible = False
        btn_table2.Visible = False
        btn_table3.Visible = False
        btn_table4.Visible = False
        btn_table5.Visible = False
        btn_table6.Visible = False
        btn_table7.Visible = False
        btn_table8.Visible = False
        btn_table9.Visible = False
        btn_table10.Visible = False
        btn_table11.Visible = False
        btn_table12.Visible = False
        btn_table13.Visible = False
        btn_table14.Visible = False
        btn_table15.Visible = False
        btn_table16.Visible = False
        btn_table17.Visible = False
        btn_table18.Visible = False
        btn_table19.Visible = False
        btn_table20.Visible = False
        btn_table21.Visible = False
        btn_table22.Visible = False
        btn_table23.Visible = False
        btn_table24.Visible = False
        btn_table25.Visible = False
        btn_table26.Visible = False
        btn_table27.Visible = False
        btn_table28.Visible = False
        'btn_table29.Visible = False
        'btn_table30.Visible = False
        btn_table31.Visible = False
        btn_table32.Visible = False
        'btn_table33.Visible = False
        'btn_table34.Visible = False
        'btn_table35.Visible = False
        'btn_table36.Visible = False
        'btn_table37.Visible = False
        'btn_table38.Visible = False
        'btn_table39.Visible = False
        btn_table41.Visible = False
        btn_table42.Visible = False
        btn_table51.Visible = False
        btn_table52.Visible = False
        btn_table53.Visible = False
        btn_table54.Visible = False
        btn_table61.Visible = False
        btn_table62.Visible = False
        btn_table71.Visible = False
        btn_table72.Visible = False
        btn_table73.Visible = False
        btn_table74.Visible = False
        btn_table75.Visible = False
        btn_table76.Visible = False
        btn_table77.Visible = False
        btn_table78.Visible = False
        btn_table79.Visible = False
        btn_table80.Visible = False
        btn_table81.Visible = False
        btn_table82.Visible = False
        btn_table83.Visible = False
        btn_table84.Visible = False
        btn_table85.Visible = False
        btn_table86.Visible = False
        btn_table87.Visible = False
        btn_table88.Visible = False
        btn_table89.Visible = False
        btn_table158.Visible = False
        btn_table159.Visible = False
        btn_table160.Visible = False
        btn_table161.Visible = False
        btn_table162.Visible = False
        btn_table163.Visible = False
        btn_table164.Visible = False
        btn_table165.Visible = False
        btn_table166.Visible = False
        btn_table167.Visible = False
        btn_table168.Visible = False
        btn_table169.Visible = False
        btn_table170.Visible = False
        btn_table171.Visible = False
        btn_table172.Visible = False
        btn_table173.Visible = False
        btn_table174.Visible = False
        btn_table175.Visible = False
        btn_table176.Visible = False
        btn_table177.Visible = False
        btn_table178.Visible = False
        btn_table179.Visible = False
        btn_table180.Visible = False

        call1.Visible = False
        call2.Visible = False
        call3.Visible = False
        call4.Visible = False
        call5.Visible = False
        call6.Visible = False

        '表示項目制御
        btn_back.Visible = False
        btn_cancel.Visible = False
        btn_refresh.Text = "更新"
        txt_Pos.Visible = False
        If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            lbl_call.Visible = True
        End If

    End Function

    Public Function LF_SetForm(ByVal pstrMode As String) As Object

        LF_SetForm = Nothing

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim i As Integer
        Dim intCnt As Integer
        Dim objButton As System.Web.UI.WebControls.Button = Nothing
        Dim objHdnButton As System.Web.UI.WebControls.Button = Nothing
        'Dim objTable As System.Web.UI.WebControls.Table = Nothing
        Dim FlgPotision As Boolean

        'TPM050を検索し、客席に設定されている端末を表示
        strSQL = ""
        strSQL = strSQL & "SELECT SEATID, ORDERSTATUS, SEATCOLOR, POSITION"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE TERMKIND = 'TC0' or TERMKIND = 'TCA' or TERMKIND = 'TCB'"
        strSQL = strSQL & " ORDER BY POSITION, ORDERSTATUS DESC"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
            Exit Function
        End If

        intCnt = objData.Tables("com").Rows.Count

        If intCnt = 0 Then
            Exit Function
        End If
        For i = 0 To intCnt - 1
            If Not L_Func.GF_GetRows(objData, i, objRow) Then
                GoTo SYSTEM_ERROR
            End If

            FlgPotision = False

            Select Case objRow("POSITION").ToString
                Case "11"
                    objButton = btn_table1
                    objHdnButton = hdn_btn_table1
                    'objTable = table_1
                    FlgPotision = True
                Case "12"
                    objButton = btn_table2
                    objHdnButton = hdn_btn_table2
                    'objTable = table_2
                    FlgPotision = True
                Case "13"
                    objButton = btn_table3
                    objHdnButton = hdn_btn_table3
                    'objTable = table_3
                    FlgPotision = True
                Case "14"
                    objButton = btn_table4
                    objHdnButton = hdn_btn_table4
                    'objTable = table_4
                    FlgPotision = True
                Case "15"
                    objButton = btn_table5
                    objHdnButton = hdn_btn_table5
                    'objTable = table_5
                    FlgPotision = True
                Case "16"
                    objButton = btn_table6
                    objHdnButton = hdn_btn_table6
                    'objTable = table_6
                    FlgPotision = True
                Case "17"
                    objButton = btn_table7
                    objHdnButton = hdn_btn_table7
                    'objTable = table_7
                    FlgPotision = True
                Case "18"
                    objButton = btn_table8
                    objHdnButton = hdn_btn_table8
                    'objTable = table_8
                    FlgPotision = True
                Case "19"
                    objButton = btn_table9
                    objHdnButton = hdn_btn_table9
                    'objTable = table_9
                    FlgPotision = True
                Case "20"
                    objButton = btn_table10
                    objHdnButton = hdn_btn_table10
                    'objTable = table_10
                    FlgPotision = True
                Case "21"
                    objButton = btn_table11
                    objHdnButton = hdn_btn_table11
                    'objTable = table_11
                    FlgPotision = True
                Case "22"
                    objButton = btn_table12
                    objHdnButton = hdn_btn_table12
                    'objTable = table_12
                    FlgPotision = True
                Case "23"
                    objButton = btn_table13
                    objHdnButton = hdn_btn_table13
                    'objTable = table_13
                    FlgPotision = True
                Case "24"
                    objButton = btn_table14
                    objHdnButton = hdn_btn_table14
                    'objTable = table_14
                    FlgPotision = True
                Case "25"
                    objButton = btn_table15
                    objHdnButton = hdn_btn_table15
                    'objTable = table_15
                    FlgPotision = True
                Case "26"
                    objButton = btn_table16
                    objHdnButton = hdn_btn_table16
                    'objTable = table_16
                    FlgPotision = True
                Case "27"
                    objButton = btn_table17
                    objHdnButton = hdn_btn_table17
                    'objTable = table_17
                    FlgPotision = True
                Case "28"
                    objButton = btn_table18
                    objHdnButton = hdn_btn_table18
                    'objTable = table_18
                    FlgPotision = True
                Case "29"
                    objButton = btn_table19
                    objHdnButton = hdn_btn_table19
                    'objTable = table_19
                    FlgPotision = True
                Case "30"
                    objButton = btn_table20
                    objHdnButton = hdn_btn_table20
                    'objTable = table_20
                    FlgPotision = True
                Case "31"
                    objButton = btn_table21
                    objHdnButton = hdn_btn_table21
                    'objTable = table_21
                    FlgPotision = True
                Case "32"
                    objButton = btn_table22
                    objHdnButton = hdn_btn_table22
                    'objTable = table_22
                    FlgPotision = True
                Case "33"
                    objButton = btn_table23
                    objHdnButton = hdn_btn_table23
                    'objTable = table_23
                    FlgPotision = True
                Case "34"
                    objButton = btn_table24
                    objHdnButton = hdn_btn_table24
                    'objTable = table_24
                    FlgPotision = True
                Case "35"
                    objButton = btn_table25
                    objHdnButton = hdn_btn_table25
                    'objTable = table_25
                    FlgPotision = True
                Case "36"
                    objButton = btn_table26
                    objHdnButton = hdn_btn_table26
                    'objTable = table_26
                    FlgPotision = True
                Case "37"
                    objButton = btn_table27
                    objHdnButton = hdn_btn_table27
                    'objTable = table_27
                    FlgPotision = True
                Case "38"
                    objButton = btn_table28
                    objHdnButton = hdn_btn_table28
                    'objTable = table_28
                    FlgPotision = True
                Case "39"
                    objButton = btn_table31
                    objHdnButton = hdn_btn_table31
                    'objTable = table_31
                    FlgPotision = True
                Case "40"
                    objButton = btn_table32
                    objHdnButton = hdn_btn_table32
                    'objTable = table_32
                    FlgPotision = True
                Case "41"
                    objButton = btn_table41
                    objHdnButton = hdn_btn_table41
                    'objTable = table_41
                    FlgPotision = True
                Case "42"
                    objButton = btn_table42
                    objHdnButton = hdn_btn_table42
                    'objTable = table_42
                    FlgPotision = True
                Case "43"
                    objButton = btn_table51
                    objHdnButton = hdn_btn_table51
                    'objTable = table_51
                    FlgPotision = True
                Case "44"
                    objButton = btn_table52
                    objHdnButton = hdn_btn_table52
                    'objTable = table_52
                    FlgPotision = True
                Case "45"
                    objButton = btn_table53
                    objHdnButton = hdn_btn_table53
                    'objTable = table_53
                    FlgPotision = True
                Case "46"
                    objButton = btn_table54
                    objHdnButton = hdn_btn_table54
                    'objTable = table_54
                    FlgPotision = True
                Case "47"
                    objButton = btn_table61
                    objHdnButton = hdn_btn_table61
                    'objTable = table_61
                    FlgPotision = True
                Case "48"
                    objButton = btn_table62
                    objHdnButton = hdn_btn_table62
                    'objTable = table_62
                    FlgPotision = True
                Case "49"
                    objButton = btn_table71
                    objHdnButton = hdn_btn_table71
                    'objTable = table_71
                    FlgPotision = True
                Case "50"
                    objButton = btn_table72
                    objHdnButton = hdn_btn_table72
                    'objTable = table_72
                    FlgPotision = True
                Case "51"
                    objButton = btn_table73
                    objHdnButton = hdn_btn_table73
                    'objTable = table_73
                    FlgPotision = True
                Case "52"
                    objButton = btn_table74
                    objHdnButton = hdn_btn_table74
                    'objTable = table_74
                    FlgPotision = True
                Case "53"
                    objButton = btn_table75
                    objHdnButton = hdn_btn_table75
                    'objTable = table_75
                    FlgPotision = True
                Case "54"
                    objButton = btn_table76
                    objHdnButton = hdn_btn_table76
                    'objTable = table_76
                    FlgPotision = True
                Case "55"
                    objButton = btn_table77
                    objHdnButton = hdn_btn_table77
                    'objTable = table_77
                    FlgPotision = True
                Case "56"
                    objButton = btn_table78
                    objHdnButton = hdn_btn_table78
                    'objTable = table_78
                    FlgPotision = True
                Case "57"
                    objButton = btn_table79
                    objHdnButton = hdn_btn_table79
                    'objTable = table_79
                    FlgPotision = True
                Case "58"
                    objButton = btn_table80
                    objHdnButton = hdn_btn_table80
                    'objTable = table_80
                    FlgPotision = True
                Case "59"
                    objButton = btn_table81
                    objHdnButton = hdn_btn_table81
                    'objTable = table_81
                    FlgPotision = True
                Case "60"
                    objButton = btn_table82
                    objHdnButton = hdn_btn_table82
                    'objTable = table_82
                    FlgPotision = True
                Case "61"
                    objButton = btn_table83
                    objHdnButton = hdn_btn_table83
                    'objTable = table_83
                    FlgPotision = True
                Case "62"
                    objButton = btn_table84
                    objHdnButton = hdn_btn_table84
                    'objTable = table_84
                    FlgPotision = True
                Case "63"
                    objButton = btn_table85
                    objHdnButton = hdn_btn_table85
                    'objTable = table_85
                    FlgPotision = True
                Case "64"
                    objButton = btn_table86
                    objHdnButton = hdn_btn_table86
                    'objTable = table_86
                    FlgPotision = True
                Case "65"
                    objButton = btn_table87
                    objHdnButton = hdn_btn_table87
                    'objTable = table_87
                    FlgPotision = True
                Case "66"
                    objButton = btn_table88
                    objHdnButton = hdn_btn_table88
                    'objTable = table_88
                    FlgPotision = True
                Case "67"
                    objButton = btn_table89
                    objHdnButton = hdn_btn_table89
                    'objTable = table_89
                    FlgPotision = True
                Case "68"
                    objButton = btn_table158
                    objHdnButton = hdn_btn_table158
                    'objTable = table_158
                    FlgPotision = True
                Case "69"
                    objButton = btn_table159
                    objHdnButton = hdn_btn_table159
                    'objTable = table_159
                    FlgPotision = True
                Case "70"
                    objButton = btn_table160
                    objHdnButton = hdn_btn_table160
                    'objTable = table_160
                    FlgPotision = True
                Case "71"
                    objButton = btn_table161
                    objHdnButton = hdn_btn_table161
                    'objTable = table_161
                    FlgPotision = True
                Case "72"
                    objButton = btn_table162
                    objHdnButton = hdn_btn_table162
                    'objTable = table_162
                    FlgPotision = True
                Case "73"
                    objButton = btn_table163
                    objHdnButton = hdn_btn_table163
                    'objTable = table_163
                    FlgPotision = True
                Case "74"
                    objButton = btn_table164
                    objHdnButton = hdn_btn_table164
                    'objTable = table_164
                    FlgPotision = True
                Case "75"
                    objButton = btn_table165
                    objHdnButton = hdn_btn_table165
                    'objTable = table_165
                    FlgPotision = True
                Case "76"
                    objButton = btn_table166
                    objHdnButton = hdn_btn_table166
                    'objTable = table_166
                    FlgPotision = True
                Case "77"
                    objButton = btn_table167
                    objHdnButton = hdn_btn_table167
                    'objTable = table_167
                    FlgPotision = True
                Case "78"
                    objButton = btn_table168
                    objHdnButton = hdn_btn_table168
                    'objTable = table_168
                    FlgPotision = True
                Case "79"
                    objButton = btn_table169
                    objHdnButton = hdn_btn_table169
                    'objTable = table_169
                    FlgPotision = True
                Case "80"
                    objButton = btn_table170
                    objHdnButton = hdn_btn_table170
                    'objTable = table_170
                    FlgPotision = True
                Case "81"
                    objButton = btn_table171
                    objHdnButton = hdn_btn_table171
                    'objTable = table_171
                    FlgPotision = True
                Case "82"
                    objButton = btn_table172
                    objHdnButton = hdn_btn_table172
                    'objTable = table_172
                    FlgPotision = True
                Case "83"
                    objButton = btn_table173
                    objHdnButton = hdn_btn_table173
                    'objTable = table_173
                    FlgPotision = True
                Case "84"
                    objButton = btn_table174
                    objHdnButton = hdn_btn_table174
                    'objTable = table_174
                    FlgPotision = True
                Case "85"
                    objButton = btn_table175
                    objHdnButton = hdn_btn_table175
                    'objTable = table_175
                    FlgPotision = True
                Case "86"
                    objButton = btn_table176
                    objHdnButton = hdn_btn_table176
                    'objTable = table_176
                    FlgPotision = True
                Case "87"
                    objButton = btn_table177
                    objHdnButton = hdn_btn_table177
                    'objTable = table_167
                    FlgPotision = True
                Case "88"
                    objButton = btn_table178
                    objHdnButton = hdn_btn_table178
                    'objTable = table_178
                    FlgPotision = True
                Case "89"
                    objButton = btn_table179
                    objHdnButton = hdn_btn_table179
                    'objTable = table_179
                    FlgPotision = True
                Case "90"
                    objButton = btn_table180
                    objHdnButton = hdn_btn_table180
                    'objTable = table_180
                    FlgPotision = True

                Case Else

            End Select

            'ボタン、テーブルの表示内容（色など）設定
            If Trim$(pstrMode) = "0" Then
                '客席状況確認画面
                If FlgPotision = True Then
                    'Call LF_SetButton(objButton, objTable, objHdnButton, objRow("SEATID"), Trim$(objRow("ORDERSTATUS")), Trim$(objRow("SEATCOLOR")))
                    Call LF_SetButton(objButton, objHdnButton, objRow("SEATID"), Trim$(objRow("ORDERSTATUS")), Trim$(objRow("SEATCOLOR")))
                End If
            Else
                '端末設定画面からの遷移時
                objButton.Text = Trim$(objRow("SEATID"))
                objHdnButton.Text = Trim$(objRow("SEATID"))
            End If

        Next

        If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" Then
            Call LS_DispStaff()
        End If

        'メッセージ初期化
        If Session(SessionMsgName) = "" Then
            lbl_Msg.Text = ""
        Else
            lbl_Msg.Text = Session(SessionMsgName).ToString
            If IsPostBack Then
                Session(SessionMsgName) = ""
            End If
        End If

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG020(LF_SetForm)")
        Exit Function
    End Function

    'Private Function LF_SetButton(ByVal objButton As System.Web.UI.WebControls.Button, _
    '                              ByVal objTable As System.Web.UI.WebControls.Table, _
    '                              ByVal objHdnButton As System.Web.UI.WebControls.Button, _
    '                              ByVal strSeatID As String, _
    '                              ByVal strOrderStatus As String, _
    '                              ByVal strColor As String) As Object
    Private Function LF_SetButton(ByVal objButton As System.Web.UI.WebControls.Button, _
                                  ByVal objHdnButton As System.Web.UI.WebControls.Button, _
                                  ByVal strSeatID As String, _
                                  ByVal strOrderStatus As String, _
                                  ByVal strColor As String) As Object

        LF_SetButton = Nothing

        Dim StayTime As Long
        Dim OTOOSHI_TIME1 As Long
        Dim OTOOSHI_TIME2 As Long
        Dim OTOOSHI_TIME3 As Long
        Dim objData As New DataSet()
        Dim strTimeLimitSec As String = ""
        Dim strTimeLimitSec_LO As String = ""

        '食べ飲み放題残りラストオーダー時間取得
        If Trim(Session("TP").GF_GetAppInfo("PRICE_TYPE")) = "1" Then
            strTimeLimitSec = LF_GetTimeLimit(strSeatID)
            strTimeLimitSec_LO = LF_GetTimeLimit_LO(strSeatID)
        End If

        'ボタンいろいろ設定
        With objButton

            'ボタン表示文字設定
            .Visible = True
            If Trim$(strOrderStatus) <> "2" Then

                StayTime = LF_GetStayTime(strSeatID)

                If LF_GetMenuID(strSeatID) Then
                    OTOOSHI_TIME1 = CLng(L_Func.GF_GetAppInfo("OTOOSHI_TIME4"))
                    OTOOSHI_TIME2 = CLng(L_Func.GF_GetAppInfo("OTOOSHI_TIME5"))
                    OTOOSHI_TIME3 = CLng(L_Func.GF_GetAppInfo("OTOOSHI_TIME6"))

                    If StayTime >= OTOOSHI_TIME1 Then
                        .BackColor = System.Drawing.Color.PaleTurquoise
                        .ForeColor = System.Drawing.Color.Black
                    End If

                    If StayTime > OTOOSHI_TIME2 Then
                        .BackColor = System.Drawing.Color.DeepSkyBlue
                        .ForeColor = System.Drawing.Color.White
                    End If

                    If StayTime > OTOOSHI_TIME3 Then
                        .BackColor = System.Drawing.Color.Blue
                        .ForeColor = System.Drawing.Color.White
                    End If
                Else
                    '食べ飲み放題の残り時間を表示する場合は個別に色を設定
                    If strTimeLimitSec_LO = "" AndAlso strTimeLimitSec = "" Then

                        If L_Func.GF_GetAppInfo3("CNWG002_FLG") = "1" Then
                            ' 入店管理情報付きお通し端末有り
                            OTOOSHI_TIME1 = CLng(L_Func.GF_GetAppInfo3("CNWG002_COLOR_TIME1"))
                            OTOOSHI_TIME2 = CLng(L_Func.GF_GetAppInfo3("CNWG002_COLOR_TIME2"))
                            OTOOSHI_TIME3 = CLng(L_Func.GF_GetAppInfo3("CNWG002_COLOR_TIME3"))

                            If StayTime >= OTOOSHI_TIME3 Then
                                .BackColor = System.Drawing.Color.Red
                                .ForeColor = System.Drawing.Color.White
                            ElseIf StayTime >= OTOOSHI_TIME2 Then
                                .BackColor = System.Drawing.Color.Green
                                .ForeColor = System.Drawing.Color.White
                            ElseIf StayTime >= OTOOSHI_TIME1 Then
                                .BackColor = System.Drawing.Color.SkyBlue
                                .ForeColor = System.Drawing.Color.Black
                            Else
                                .BackColor = System.Drawing.Color.Pink
                                .ForeColor = System.Drawing.Color.Black
                            End If
                        Else
                            ' 入店管理情報付きお通し端末無し
                            OTOOSHI_TIME1 = CLng(L_Func.GF_GetAppInfo("OTOOSHI_TIME1"))
                            OTOOSHI_TIME2 = CLng(L_Func.GF_GetAppInfo("OTOOSHI_TIME2"))
                            OTOOSHI_TIME3 = CLng(L_Func.GF_GetAppInfo("OTOOSHI_TIME3"))

                            If StayTime >= OTOOSHI_TIME1 Then
                                If L_Func.GF_ChkSeatSeting(strSeatID) = False Then
                                    .BackColor = System.Drawing.Color.Yellow
                                    .ForeColor = System.Drawing.Color.Black
                                Else
                                    .BackColor = System.Drawing.Color.Pink
                                    .ForeColor = System.Drawing.Color.Black
                                End If
                            End If

                            If StayTime > OTOOSHI_TIME2 Then
                                If L_Func.GF_ChkSeatSeting(strSeatID) = False Then
                                    .BackColor = System.Drawing.Color.Yellow
                                    .ForeColor = System.Drawing.Color.Black
                                Else
                                    .BackColor = System.Drawing.Color.Pink
                                    .ForeColor = System.Drawing.Color.Black
                                End If
                            End If

                            If StayTime > OTOOSHI_TIME3 Then
                                If L_Func.GF_ChkSeatSeting(strSeatID) = False Then
                                    .BackColor = System.Drawing.Color.Yellow
                                    .ForeColor = System.Drawing.Color.Black
                                Else
                                    .BackColor = System.Drawing.Color.Pink
                                    .ForeColor = System.Drawing.Color.Black
                                End If
                            End If
                        End If

                    ElseIf strTimeLimitSec_LO <> "" Then
                        Dim FreeTimeAlert1 As Integer = CInt(IIf(Session("TP").GF_GetAppInfo("FREE_TIME_ALERT1") = "", 0, Session("TP").GF_GetAppInfo("FREE_TIME_ALERT1")))
                        Dim FreeTimeAlert2 As Integer = CInt(IIf(Session("TP").GF_GetAppInfo("FREE_TIME_ALERT2") = "", 0, Session("TP").GF_GetAppInfo("FREE_TIME_ALERT2")))

                        If strTimeLimitSec_LO > FreeTimeAlert1 Then
                            .BackColor = System.Drawing.Color.Pink
                            .ForeColor = System.Drawing.Color.Black
                        End If

                        If FreeTimeAlert1 <> 0 And FreeTimeAlert1 >= strTimeLimitSec_LO And FreeTimeAlert2 < strTimeLimitSec_LO Then
                            .BackColor = System.Drawing.Color.Yellow
                            .ForeColor = System.Drawing.Color.Black
                        End If

                        If FreeTimeAlert2 <> 0 And FreeTimeAlert2 >= strTimeLimitSec_LO Then
                            .BackColor = System.Drawing.Color.Red
                            .ForeColor = System.Drawing.Color.Black
                        End If

                    ElseIf strTimeLimitSec_LO = "" AndAlso strTimeLimitSec <> "" Then
                        .BackColor = Color.FromName(L_Func.GF_GetAppInfo2("CNWG_FREE_END_COLOR1"))
                        .ForeColor = Color.FromName(L_Func.GF_GetAppInfo2("CNWG_FREE_END_COLOR2"))
                    End If

                End If

                If Trim$(strOrderStatus) = "5" Then
                    .Text = Trim$(strSeatID) & vbCrLf & "(会計)"
                    .BackColor = System.Drawing.Color.Black
                    .ForeColor = System.Drawing.Color.White
                ElseIf Trim$(strOrderStatus) = "A" Then
                    .Text = Trim$(strSeatID) & vbCrLf & "(会計)"
                    .BackColor = System.Drawing.Color.Blue
                    .ForeColor = System.Drawing.Color.White
                ElseIf Trim$(strOrderStatus) = "C" Then
                    .Text = Trim$(strSeatID) & vbCrLf & "(" & L_Func.GF_GetAppInfo2("SEAT_CLOSURE_MSG") & ")"
                    .BackColor = Color.FromName(L_Func.GF_GetAppInfo2("SEAT_CLOSURE_COLOR1"))
                    .ForeColor = Color.FromName(L_Func.GF_GetAppInfo2("SEAT_CLOSURE_COLOR2"))
                Else
                    If strTimeLimitSec_LO = "" Then
                        .Text = Trim$(strSeatID) & vbCrLf & "(" & StayTime & "分)"
                    Else
                        objButton.Font.Size = 10.5
                        .Text = Trim$(strSeatID) & vbCrLf & "(残" & strTimeLimitSec_LO & "分)"
                    End If

                    '表示機オプション
                    If L_Func.GF_GetAppInfo2("CNWG_CALLBTN") = "1" And LS_DispCustomer(strSeatID) Then
                        .Text = Trim$(strSeatID) & vbCrLf & "(呼出)"
                        .ForeColor = System.Drawing.Color.Black
                        .BackColor = System.Drawing.Color.AliceBlue
                    End If

                End If

            Else
                '空席の場合、ボタン色（グレー）
                .BackColor = System.Drawing.Color.WhiteSmoke
                .ForeColor = System.Drawing.Color.Black

                'ボタン表示文字設定
                .Text = Trim$(strSeatID)
            End If

        End With

        'テーブルの設定
        'With objTable
        '    Select Case Trim$(strColor)
        '        Case "0"
        '            '白
        '            .BackColor = System.Drawing.Color.White
        '        Case "1"
        '            '青
        '            .BackColor = System.Drawing.Color.Blue
        '        Case "2"
        '            'ピンク
        '            .BackColor = System.Drawing.Color.Red
        '        Case "3"
        '            '紫
        '            .BackColor = System.Drawing.Color.Purple
        '        Case "4"
        '            'オレンジ
        '            .BackColor = System.Drawing.Color.Orange
        '        Case "5"
        '            '緑
        '            .BackColor = System.Drawing.Color.Lime
        '        Case "6"
        '            '黄色
        '            .BackColor = System.Drawing.Color.Yellow
        '        Case "7"
        '            '白色
        '            .BackColor = System.Drawing.Color.AliceBlue
        '        Case "8"
        '            '黒色
        '            .BackColor = System.Drawing.Color.Black
        '        Case "9"
        '            '水色
        '            .BackColor = System.Drawing.Color.Aqua
        '        Case Else
        '            'オリーブ
        '            .BackColor = System.Drawing.Color.Olive
        '    End Select

        'End With

        With objHdnButton
            'ボタン表示文字設定
            .Text = Trim$(strSeatID)
        End With

    End Function

    Public Sub LS_IframeWrite()

        Dim strHTML As String
        Dim strMenuID As String = Nothing
        Dim strGoodsCD As String = Nothing

        strHTML = ""

        If Len(Trim$(L_Iframe)) > 0 Then
            If Trim$(LF_GetOrderStatus) <> "2" Then
                strHTML = "<iframe src=""CNWG030.aspx?SEATID="
                strHTML = strHTML & L_Seat.Text
                strHTML = strHTML & "&BTN_STATUS="
                strHTML = strHTML & ViewState("BTN_STATUS" & L_Seat.Text)
                strHTML = strHTML & "&AlertMin=" & ViewState("AlertMin")
                strHTML = strHTML & """ id=""F_CNWG020"" height=""168"" width=""1024"" align=""middle"" style=""Z-INDEX: 600; LEFT: 0px; POSITION: absolute; TOP: 600px"" frameBorder=""1"" scrolling=""no""></iframe>"
            Else
                ' ---------- 入店情報対応 ----------
                If L_Func.GF_GetAppInfo3("CNWG002_FLG") = "0" Then
                    'お通し端末使用時
                    If L_Func.GF_GetAppInfo("MENU_SELECT_FLG") = "0" Then
                        ' 座席別に設定されたメニューを案内する
                        Call LF_GetForEachMenu(strMenuID, strGoodsCD, RSet(L_Seat.Text, 5))
                        If Trim$(strMenuID) = "0" Then
                            Call LF_GetMenu(strMenuID, strGoodsCD)
                        End If
                    Else
                        Call LF_GetMenu(strMenuID, strGoodsCD)
                    End If

                    strHTML = "<iframe src=""CNWG050.aspx?SEATID="
                    strHTML = strHTML & L_Seat.Text
                    strHTML = strHTML & "&MENUID=" & strMenuID
                    strHTML = strHTML & "&GOODSCD=" & strGoodsCD
                    strHTML = strHTML & """ id=""F_CNWG020"" height=""168"" width=""1024"" align=""middle"" style=""Z-INDEX: 600; LEFT: 0px; POSITION: absolute; TOP: 600px"" frameBorder=""1"" scrolling=""no""></iframe>"
                Else
                    '入店管理情報付お通し端末使用時
                    If L_Func.GF_GetAppInfo("MENU_SELECT_FLG") = "0" Then
                        ' 座席別に設定されたメニューを案内する
                        Call LF_GetForEachMenu(strMenuID, strGoodsCD, RSet(L_Seat.Text, 5))
                        If Trim$(strMenuID) = "0" Then
                            Call LF_GetMenu(strMenuID, strGoodsCD)
                        End If
                    Else
                        Call LF_GetMenu(strMenuID, strGoodsCD)
                    End If

                    strHTML = "<iframe src=""CNWG051.aspx?SEATID="
                    strHTML = strHTML & L_Seat.Text
                    strHTML = strHTML & "&MENUID=" & strMenuID
                    strHTML = strHTML & "&GOODSCD=" & strGoodsCD
                    strHTML = strHTML & """ id=""F_CNWG020"" height=""228"" width=""1024"" align=""middle"" style=""Z-INDEX: 600; LEFT: 0px; POSITION: absolute; TOP: 540px"" frameBorder=""1"" scrolling=""no""></iframe>"
                End If
                ' ---------- 入店情報対応 ----------
            End If

            strHTML = strHTML & "<span id='lbl_Iframeflg' style='visibility:hidden'>1</span>"
        Else
            strHTML = strHTML & "<span id='lbl_Iframeflg' style='visibility:hidden'>0</span>"
        End If

        Response.Write(strHTML)

    End Sub

    ' 1項目のみ必要データを抽出する。
    ' (メニューID、GOODSCD(0000)を取得)
    Private Sub LF_GetMenu(ByRef strMenuID As String, ByRef strGoodsCD As String)

        Dim strSQL As String = Nothing
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        strSQL = strSQL & "SELECT '0000' AS GOODSCD,"
        strSQL = strSQL & "       DEFMENUID AS MENUID"
        strSQL = strSQL & "  FROM TPM040"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetMenu_1)")
            Exit Sub
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetMenu_2)")
            Exit Sub
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetMenu_3)")
            Exit Sub
        End If

        strMenuID = objRow("MENUID")
        strGoodsCD = objRow("GOODSCD")

    End Sub

    ''' <summary>
    ''' 座席別メニュー設定
    ''' </summary>
    ''' <param name="strMenuID"></param>
    '''<param name="strSeatID"></param>
    ''' <remarks></remarks>
    Private Sub LF_GetForEachMenu(ByRef strMenuID As String, ByRef strGoodsCD As String, ByVal strSeatID As String)

        Dim strSQL As String = Nothing
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        strSQL = strSQL & "SELECT '0000' AS GOODSCD,"
        strSQL = strSQL & "       TPD050.*"
        strSQL = strSQL & "  FROM TPD050"
        strSQL = strSQL & " WHERE TPD050.SEATID = '" & strSeatID & "'"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetForEachMenu_1)")
            Exit Sub
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetForEachMenu_2)")
            Exit Sub
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetForEachMenu_3)")
            Exit Sub
        End If

        strMenuID = objRow("M7")
        strGoodsCD = objRow("GOODSCD")

    End Sub

    Private Function LF_ParaPos() As Object

        LF_ParaPos = Nothing

        Dim objButton As System.Web.UI.WebControls.Button

        If Trim$(Request.QueryString("POS")) <> "" Then
            Select Case Trim$(Request.QueryString("POS"))
                Case "11"
                    objButton = btn_table1
                Case "12"
                    objButton = btn_table2
                Case "13"
                    objButton = btn_table3
                Case "14"
                    objButton = btn_table4
                Case "15"
                    objButton = btn_table5
                Case "16"
                    objButton = btn_table6
                Case "17"
                    objButton = btn_table7
                Case "18"
                    objButton = btn_table8
                Case "19"
                    objButton = btn_table9
                Case "20"
                    objButton = btn_table10
                Case "21"
                    objButton = btn_table11
                Case "22"
                    objButton = btn_table12
                Case "23"
                    objButton = btn_table13
                Case "24"
                    objButton = btn_table14
                Case "25"
                    objButton = btn_table15
                Case "26"
                    objButton = btn_table16
                Case "27"
                    objButton = btn_table17
                Case "28"
                    objButton = btn_table18
                Case "29"
                    objButton = btn_table19
                Case "30"
                    objButton = btn_table20
                Case "31"
                    objButton = btn_table21
                Case "32"
                    objButton = btn_table22
                Case "33"
                    objButton = btn_table23
                Case "34"
                    objButton = btn_table24
                Case "35"
                    objButton = btn_table25
                Case "36"
                    objButton = btn_table26
                Case "37"
                    objButton = btn_table27
                Case "38"
                    objButton = btn_table28
                Case "39"
                    objButton = btn_table31
                Case "40"
                    objButton = btn_table32
                Case "41"
                    objButton = btn_table41
                Case "42"
                    objButton = btn_table42
                Case "43"
                    objButton = btn_table51
                Case "44"
                    objButton = btn_table52
                Case "45"
                    objButton = btn_table53
                Case "46"
                    objButton = btn_table54
                Case "47"
                    objButton = btn_table61
                Case "48"
                    objButton = btn_table62
                Case "49"
                    objButton = btn_table71
                Case "50"
                    objButton = btn_table72
                Case "51"
                    objButton = btn_table73
                Case "52"
                    objButton = btn_table74
                Case "53"
                    objButton = btn_table75
                Case "54"
                    objButton = btn_table76
                Case "55"
                    objButton = btn_table77
                Case "56"
                    objButton = btn_table78
                Case "57"
                    objButton = btn_table79
                Case "58"
                    objButton = btn_table80
                Case "59"
                    objButton = btn_table81
                Case "60"
                    objButton = btn_table82
                Case "61"
                    objButton = btn_table83
                Case "62"
                    objButton = btn_table84
                Case "63"
                    objButton = btn_table85
                Case "64"
                    objButton = btn_table86
                Case "65"
                    objButton = btn_table87
                Case "66"
                    objButton = btn_table88
                Case "67"
                    objButton = btn_table89
                Case "68"
                    objButton = btn_table158
                Case "69"
                    objButton = btn_table159
                Case "70"
                    objButton = btn_table160
                Case "71"
                    objButton = btn_table161
                Case "72"
                    objButton = btn_table162
                Case "73"
                    objButton = btn_table163
                Case "74"
                    objButton = btn_table164
                Case "75"
                    objButton = btn_table165
                Case "76"
                    objButton = btn_table166
                Case "77"
                    objButton = btn_table167
                Case "78"
                    objButton = btn_table168
                Case "79"
                    objButton = btn_table169
                Case "80"
                    objButton = btn_table170
                Case "81"
                    objButton = btn_table171
                Case "82"
                    objButton = btn_table172
                Case "83"
                    objButton = btn_table173
                Case "84"
                    objButton = btn_table174
                Case "85"
                    objButton = btn_table175
                Case "86"
                    objButton = btn_table176
                Case "87"
                    objButton = btn_table177
                Case "88"
                    objButton = btn_table178
                Case "89"
                    objButton = btn_table179
                Case "90"
                    objButton = btn_table180
                Case Else
                    Exit Function
            End Select

            LS_SelectTablePos(objButton)

        End If

    End Function

    Private Sub LS_SelectTablePos(ByVal objButton As System.Web.UI.WebControls.Button)

        btn_table1.BackColor = System.Drawing.Color.Empty
        btn_table2.BackColor = System.Drawing.Color.Empty
        btn_table3.BackColor = System.Drawing.Color.Empty
        btn_table4.BackColor = System.Drawing.Color.Empty
        btn_table5.BackColor = System.Drawing.Color.Empty
        btn_table6.BackColor = System.Drawing.Color.Empty
        btn_table7.BackColor = System.Drawing.Color.Empty
        btn_table8.BackColor = System.Drawing.Color.Empty
        btn_table9.BackColor = System.Drawing.Color.Empty
        btn_table10.BackColor = System.Drawing.Color.Empty
        btn_table11.BackColor = System.Drawing.Color.Empty
        btn_table12.BackColor = System.Drawing.Color.Empty
        btn_table13.BackColor = System.Drawing.Color.Empty
        btn_table14.BackColor = System.Drawing.Color.Empty
        btn_table15.BackColor = System.Drawing.Color.Empty
        btn_table16.BackColor = System.Drawing.Color.Empty
        btn_table17.BackColor = System.Drawing.Color.Empty
        btn_table18.BackColor = System.Drawing.Color.Empty
        btn_table19.BackColor = System.Drawing.Color.Empty
        btn_table20.BackColor = System.Drawing.Color.Empty
        btn_table22.BackColor = System.Drawing.Color.Empty
        btn_table23.BackColor = System.Drawing.Color.Empty
        btn_table24.BackColor = System.Drawing.Color.Empty
        btn_table25.BackColor = System.Drawing.Color.Empty
        btn_table26.BackColor = System.Drawing.Color.Empty
        btn_table27.BackColor = System.Drawing.Color.Empty
        btn_table28.BackColor = System.Drawing.Color.Empty
        'btn_table29.BackColor = System.Drawing.Color.Empty
        'btn_table30.BackColor = System.Drawing.Color.Empty
        btn_table31.BackColor = System.Drawing.Color.Empty
        btn_table32.BackColor = System.Drawing.Color.Empty
        'btn_table33.BackColor = System.Drawing.Color.Empty
        'btn_table34.BackColor = System.Drawing.Color.Empty
        'btn_table35.BackColor = System.Drawing.Color.Empty
        'btn_table36.BackColor = System.Drawing.Color.Empty
        'btn_table37.BackColor = System.Drawing.Color.Empty
        'btn_table38.BackColor = System.Drawing.Color.Empty
        'btn_table39.BackColor = System.Drawing.Color.Empty
        btn_table41.BackColor = System.Drawing.Color.Empty
        btn_table42.BackColor = System.Drawing.Color.Empty
        btn_table51.BackColor = System.Drawing.Color.Empty
        btn_table52.BackColor = System.Drawing.Color.Empty
        btn_table53.BackColor = System.Drawing.Color.Empty
        btn_table54.BackColor = System.Drawing.Color.Empty
        btn_table61.BackColor = System.Drawing.Color.Empty
        btn_table62.BackColor = System.Drawing.Color.Empty
        btn_table71.BackColor = System.Drawing.Color.Empty
        btn_table72.BackColor = System.Drawing.Color.Empty
        btn_table73.BackColor = System.Drawing.Color.Empty
        btn_table74.BackColor = System.Drawing.Color.Empty
        btn_table75.BackColor = System.Drawing.Color.Empty
        btn_table76.BackColor = System.Drawing.Color.Empty
        btn_table77.BackColor = System.Drawing.Color.Empty
        btn_table78.BackColor = System.Drawing.Color.Empty
        btn_table79.BackColor = System.Drawing.Color.Empty
        btn_table80.BackColor = System.Drawing.Color.Empty
        btn_table81.BackColor = System.Drawing.Color.Empty
        btn_table82.BackColor = System.Drawing.Color.Empty
        btn_table83.BackColor = System.Drawing.Color.Empty
        btn_table84.BackColor = System.Drawing.Color.Empty
        btn_table85.BackColor = System.Drawing.Color.Empty
        btn_table86.BackColor = System.Drawing.Color.Empty
        btn_table87.BackColor = System.Drawing.Color.Empty
        btn_table88.BackColor = System.Drawing.Color.Empty
        btn_table89.BackColor = System.Drawing.Color.Empty
        btn_table158.BackColor = System.Drawing.Color.Empty
        btn_table159.BackColor = System.Drawing.Color.Empty
        btn_table160.BackColor = System.Drawing.Color.Empty
        btn_table161.BackColor = System.Drawing.Color.Empty
        btn_table162.BackColor = System.Drawing.Color.Empty
        btn_table163.BackColor = System.Drawing.Color.Empty
        btn_table164.BackColor = System.Drawing.Color.Empty
        btn_table165.BackColor = System.Drawing.Color.Empty
        btn_table166.BackColor = System.Drawing.Color.Empty
        btn_table167.BackColor = System.Drawing.Color.Empty
        btn_table168.BackColor = System.Drawing.Color.Empty
        btn_table169.BackColor = System.Drawing.Color.Empty
        btn_table170.BackColor = System.Drawing.Color.Empty
        btn_table171.BackColor = System.Drawing.Color.Empty
        btn_table172.BackColor = System.Drawing.Color.Empty
        btn_table173.BackColor = System.Drawing.Color.Empty
        btn_table174.BackColor = System.Drawing.Color.Empty
        btn_table175.BackColor = System.Drawing.Color.Empty
        btn_table176.BackColor = System.Drawing.Color.Empty
        btn_table177.BackColor = System.Drawing.Color.Empty
        btn_table178.BackColor = System.Drawing.Color.Empty
        btn_table179.BackColor = System.Drawing.Color.Empty
        btn_table180.BackColor = System.Drawing.Color.Empty

        If objButton Is btn_cancel = False Then
            objButton.BackColor = System.Drawing.Color.Red
        End If

    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_Pos.Text = ""
        LS_SelectTablePos(btn_cancel)
    End Sub

    Private Sub LS_ButtonProtect()

        btn_table1.Attributes("ONCLICK") = "return false"
        btn_table2.Attributes("ONCLICK") = "return false"
        btn_table3.Attributes("ONCLICK") = "return false"
        btn_table4.Attributes("ONCLICK") = "return false"
        btn_table5.Attributes("ONCLICK") = "return false"
        btn_table6.Attributes("ONCLICK") = "return false"
        btn_table7.Attributes("ONCLICK") = "return false"
        btn_table8.Attributes("ONCLICK") = "return false"
        btn_table9.Attributes("ONCLICK") = "return false"
        btn_table10.Attributes("ONCLICK") = "return false"
        btn_table11.Attributes("ONCLICK") = "return false"
        btn_table12.Attributes("ONCLICK") = "return false"
        btn_table13.Attributes("ONCLICK") = "return false"
        btn_table14.Attributes("ONCLICK") = "return false"
        btn_table15.Attributes("ONCLICK") = "return false"
        btn_table16.Attributes("ONCLICK") = "return false"
        btn_table17.Attributes("ONCLICK") = "return false"
        btn_table18.Attributes("ONCLICK") = "return false"
        btn_table19.Attributes("ONCLICK") = "return false"
        btn_table20.Attributes("ONCLICK") = "return false"
        btn_table21.Attributes("ONCLICK") = "return false"
        btn_table22.Attributes("ONCLICK") = "return false"
        btn_table23.Attributes("ONCLICK") = "return false"
        btn_table24.Attributes("ONCLICK") = "return false"
        btn_table25.Attributes("ONCLICK") = "return false"
        btn_table26.Attributes("ONCLICK") = "return false"
        btn_table27.Attributes("ONCLICK") = "return false"
        btn_table28.Attributes("ONCLICK") = "return false"
        'btn_table29.Attributes("ONCLICK") = "return false"
        'btn_table30.Attributes("ONCLICK") = "return false"
        btn_table31.Attributes("ONCLICK") = "return false"
        btn_table32.Attributes("ONCLICK") = "return false"
        'btn_table33.Attributes("ONCLICK") = "return false"
        'btn_table34.Attributes("ONCLICK") = "return false"
        'btn_table35.Attributes("ONCLICK") = "return false"
        'btn_table36.Attributes("ONCLICK") = "return false"
        'btn_table37.Attributes("ONCLICK") = "return false"
        'btn_table38.Attributes("ONCLICK") = "return false"
        'btn_table39.Attributes("ONCLICK") = "return false"
        'btn_refresh.Attributes("ONCLICK") = "return false"
        btn_table41.Attributes("ONCLICK") = "return false"
        btn_table42.Attributes("ONCLICK") = "return false"
        btn_table51.Attributes("ONCLICK") = "return false"
        btn_table52.Attributes("ONCLICK") = "return false"
        btn_table53.Attributes("ONCLICK") = "return false"
        btn_table54.Attributes("ONCLICK") = "return false"
        btn_table61.Attributes("ONCLICK") = "return false"
        btn_table62.Attributes("ONCLICK") = "return false"
        btn_table71.Attributes("ONCLICK") = "return false"
        btn_table72.Attributes("ONCLICK") = "return false"
        btn_table73.Attributes("ONCLICK") = "return false"
        btn_table74.Attributes("ONCLICK") = "return false"
        btn_table75.Attributes("ONCLICK") = "return false"
        btn_table76.Attributes("ONCLICK") = "return false"
        btn_table77.Attributes("ONCLICK") = "return false"
        btn_table78.Attributes("ONCLICK") = "return false"
        btn_table79.Attributes("ONCLICK") = "return false"
        btn_table80.Attributes("ONCLICK") = "return false"
        btn_table81.Attributes("ONCLICK") = "return false"
        btn_table82.Attributes("ONCLICK") = "return false"
        btn_table83.Attributes("ONCLICK") = "return false"
        btn_table84.Attributes("ONCLICK") = "return false"
        btn_table85.Attributes("ONCLICK") = "return false"
        btn_table86.Attributes("ONCLICK") = "return false"
        btn_table87.Attributes("ONCLICK") = "return false"
        btn_table88.Attributes("ONCLICK") = "return false"
        btn_table89.Attributes("ONCLICK") = "return false"
        btn_table158.Attributes("ONCLICK") = "return false"
        btn_table159.Attributes("ONCLICK") = "return false"
        btn_table160.Attributes("ONCLICK") = "return false"
        btn_table161.Attributes("ONCLICK") = "return false"
        btn_table162.Attributes("ONCLICK") = "return false"
        btn_table163.Attributes("ONCLICK") = "return false"
        btn_table164.Attributes("ONCLICK") = "return false"
        btn_table165.Attributes("ONCLICK") = "return false"
        btn_table166.Attributes("ONCLICK") = "return false"
        btn_table167.Attributes("ONCLICK") = "return false"
        btn_table168.Attributes("ONCLICK") = "return false"
        btn_table169.Attributes("ONCLICK") = "return false"
        btn_table170.Attributes("ONCLICK") = "return false"
        btn_table171.Attributes("ONCLICK") = "return false"
        btn_table172.Attributes("ONCLICK") = "return false"
        btn_table173.Attributes("ONCLICK") = "return false"
        btn_table174.Attributes("ONCLICK") = "return false"
        btn_table175.Attributes("ONCLICK") = "return false"
        btn_table176.Attributes("ONCLICK") = "return false"
        btn_table177.Attributes("ONCLICK") = "return false"
        btn_table178.Attributes("ONCLICK") = "return false"
        btn_table179.Attributes("ONCLICK") = "return false"
        btn_table180.Attributes("ONCLICK") = "return false"
 
        btn_CLOSURE.Attributes("ONCLICK") = "return false"
    End Sub

    Private Function LF_GetOrderStatus() As String
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetOrderStatus = ""

        strSQL = ""
        strSQL = strSQL & "SELECT ORDERSTATUS"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE SEATID = '" & RSet(L_Seat.Text, 5) & "'"
        strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCA'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCB' )"
        strSQL = strSQL & " ORDER BY ORDERSTATUS"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetOrderStatus-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetOrderStatus-2)")
            Exit Function
        End If

        LF_GetOrderStatus = Trim$(objRow("ORDERSTATUS"))

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG020(LF_GetOrderStatus-3)")
        Exit Function
    End Function

    Private Function LF_GetMenuID(ByVal pSeatID As String) As Boolean
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetMenuID = False

        strSQL = ""
        strSQL = strSQL & "SELECT TOP 1"
        strSQL = strSQL & "       TPM050.TERMID,"
        strSQL = strSQL & "       TPD010.ORDERNO,"
        strSQL = strSQL & "       TPD010.SELECTTIME"
        strSQL = strSQL & "  FROM TPD010, TPM050"
        strSQL = strSQL & " WHERE TPM050.SEATID = '" & pSeatID & "'"
        strSQL = strSQL & "   AND TPM050.SEATID = TPD010.SEATID"
        strSQL = strSQL & "   AND TPM050.TERMKIND IN ('TC0', 'TCA', 'TCB')"
        strSQL = strSQL & " ORDER BY TPD010.SELECTTIME DESC"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Exit Function
        End If


        strSQL = ""
        strSQL = strSQL & "SELECT TPD010.GOODSCD,"
        strSQL = strSQL & "       TPM180.DISPMENUID,"
        strSQL = strSQL & "       TPM180.FREEDRINKMENUID"
        strSQL = strSQL & "  FROM TPD010, TPM180"
        strSQL = strSQL & " WHERE TPD010.GOODSCD = TPM180.GOODSCD"
        strSQL = strSQL & "   AND TPD010.SEATID = '" & pSeatID & "'"
        strSQL = strSQL & "   AND TPD010.ORDERNO = '" & objRow("ORDERNO") & "'"
        strSQL = strSQL & "   AND TPD010.TERMID = '" & objRow("TERMID") & "'"

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

        If Len(objRow("GOODSCD")) > 0 Then
            LF_GetMenuID = True
        End If

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG020(LF_GetMenuID)")
        Exit Function
    End Function

    Private Function LF_GetStayTime(ByVal strSeatID As String) As Long
        Dim StayTime As Long
        Dim OrderTime As Date
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim Year As String
        Dim Month As String
        Dim Day As String
        Dim Hour As String
        Dim Minute As String
        Dim Second As String

        LF_GetStayTime = 0

        strSQL = ""
        strSQL = strSQL & "SELECT SELECTTIME"
        strSQL = strSQL & "  FROM TPD010"
        strSQL = strSQL & " WHERE SEATID  = '" & strSeatID & "'"
        strSQL = strSQL & "   AND GOODSCD = '" & Trim$(Me.ViewState("OPEN_GOODSCD")) & "'"
        strSQL = strSQL & " ORDER BY SELECTTIME DESC"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetStayTime-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetStayTime-2)")
            Exit Function
        End If

        Year = Mid(CStr(Trim$(objRow("SELECTTIME"))), 1, 4)
        Month = Mid(CStr(Trim$(objRow("SELECTTIME"))), 5, 2)
        Day = Mid(CStr(Trim$(objRow("SELECTTIME"))), 7, 2)
        Hour = Mid(CStr(Trim$(objRow("SELECTTIME"))), 9, 2)
        Minute = Mid(CStr(Trim$(objRow("SELECTTIME"))), 11, 2)
        Second = Mid(CStr(Trim$(objRow("SELECTTIME"))), 13, 2)

        OrderTime = CDate(Trim$(Format(Year & "/" & Month & "/" & Day & " " & Hour & ":" & Minute & ":" & Second)))
        StayTime = CLng(DateDiff(DateInterval.Minute, OrderTime, Now))

        LF_GetStayTime = StayTime
    End Function


    'SPMENUに設定済みの場合、コース時間と滞留時間チェック
    Public Function GF_Check_SPMENU2() As String

        GF_Check_SPMENU2 = Nothing

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim intcnt As Integer

        strSQL = ""
        strSQL = strSQL & "SELECT SEATID,"
        strSQL = strSQL & "       SPMENU2,"
        strSQL = strSQL & "       POSITION"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE ORDERSTATUS <> '2'"
        strSQL = strSQL & "   AND SPMENU2 <> '000'"
        strSQL = strSQL & "   AND TERMKIND IN ('TC0', 'TCA', 'TCB')"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG020(GF_Check_SPMENU2-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        For intcnt = 0 To objData.Tables("com").Rows.Count - 1
            If Not L_Func.GF_GetRows(objData, intcnt, objRow) Then
                Exit Function
            End If

            Call LF_Check_AlertTime(LF_GetStayTime(objRow("SEATID")), objRow("SPMENU2"), objRow("SEATID"), objRow("POSITION"))
        Next intcnt
    End Function

    '滞留時間とコース時間をチェック
    Private Function LF_Check_AlertTime(ByVal pStayTime As String, ByVal pSPMENU2 As String, ByVal strSeatID As String, ByVal pPOSITION As String) As Object

        LF_Check_AlertTime = Nothing

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim AlertTime As Long
        Dim AlertMin As Long

        strSQL = ""
        strSQL = strSQL & "SELECT FREEDRINKTIME"
        strSQL = strSQL & "  FROM TPM170"
        strSQL = strSQL & " WHERE MENUID = '" & pSPMENU2 & "'"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_Check_AlertTime-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_Check_AlertTime-2)")
            Exit Function
        End If

        AlertTime = 0
        AlertTime = objRow("FREEDRINKTIME") - Me.ViewState("ALERT_TIME4")       '警告開始時間

        If AlertTime <= pStayTime Then                                          '警告開始時間と経過時間の比較

            If objRow("FREEDRINKTIME") <= pStayTime Then                        '終了時間と経過時間の比較

                ViewState("BTN_STATUS" & Trim$(strSeatID)) = "2"

            Else
                '確認メッセージステータスセット　１、３
                AlertMin = objRow("FREEDRINKTIME") - pStayTime
                ViewState("AlertMin") = AlertMin

                If LF_CheckOrderStatus(strSeatID) = "3" Then  'ステータス３なら通過
                    Exit Function
                End If

                ViewState("BTN_STATUS" & Trim$(strSeatID)) = "1"

            End If

            strSQL = ""
            strSQL = strSQL & " fAlert(" & pPOSITION & ");"

            Response.Write(strSQL)
        End If
    End Function

    Private Function LF_CheckOrderStatus(ByVal strSeatID As String) As String
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_CheckOrderStatus = ""

        strSQL = ""
        strSQL = strSQL & "SELECT ORDERSTATUS"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE SEATID = '" & strSeatID & "'"
        strSQL = strSQL & "   AND TERMKIND IN ('TC0', 'TCA', 'TCB')"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_CheckOrderStatus-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_CheckOrderStatus-2)")
            Exit Function
        End If

        LF_CheckOrderStatus = objRow("ORDERSTATUS")
    End Function

    Private Function LF_ChgDspPage() As Object

        LF_ChgDspPage = Nothing

        Dim strSQL As String
        Dim strHTML As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        strSQL = ""
        strSQL = strSQL & "SELECT SEATID"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE TERMID = '" & Trim$(Request.UserHostAddress) & "'"
        strSQL = strSQL & "    AND TERMKIND = 'TC9'"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_CheckOrderStatus-1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_CheckOrderStatus-2)")
            Exit Function
        End If

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050 SET TPM050.POSITION = '" & Trim$(objRow("SEATID")) & "'"
        strSQL = strSQL & "       WHERE TERMKIND = 'TC9'"
        strSQL = strSQL & "         AND TERMID = '" & Trim$(Request.UserHostAddress) & "'"

        If Not L_Func.GF_BeginTrans Then
            Exit Function
        End If

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Function
        End If

        If Not L_Func.GF_CommitTrans Then
            Call L_Func.GF_RollbackTrans()
        End If

        strHTML = ""

        Select Case Trim$(objRow("SEATID"))
            Case "20"
                Exit Function
            Case "21"
                strHTML = "./CNWG021.aspx"
        End Select

        Response.Redirect(strHTML)

    End Function

    Private Sub btn_TPJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TPJ.Click

    End Sub

    Private Sub btn_Change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Change.Click
        Dim strSQL As String
        Dim strHTML As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim strPAGENO As String

        strSQL = ""
        strSQL = strSQL & "SELECT POSITION FROM TPM050"
        strSQL = strSQL & "       WHERE TERMKIND = 'TC9'"
        strSQL = strSQL & "         AND TERMID = '" & Trim$(Request.UserHostAddress) & "'"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_CheckOrderStatus-1)")
            Exit Sub
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Sub
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_CheckOrderStatus-2)")
            Exit Sub
        End If

        Select Case Trim$(objRow("POSITION"))
            Case "20"
                strPAGENO = "21"
            Case "21"
                strPAGENO = "20"
            Case Else
                strPAGENO = "21"
        End Select


        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050 SET TPM050.POSITION = '" & strPAGENO & "'"
        strSQL = strSQL & "       WHERE TERMKIND = 'TC9'"
        strSQL = strSQL & "         AND TERMID = '" & Trim$(Request.UserHostAddress) & "'"

        If Not L_Func.GF_BeginTrans Then
            Exit Sub
        End If

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Sub
        End If

        If Not L_Func.GF_CommitTrans Then
            Call L_Func.GF_RollbackTrans()
        End If

        Select Case strPAGENO
            Case "20"
                strHTML = "./CNWG020.aspx"
            Case "21"
                strHTML = "./CNWG021.aspx?NOJUMP=1"
            Case Else
                strHTML = "./CNWG020.aspx"
        End Select

        Response.Redirect(strHTML)

    End Sub


    Public Function BTN_WRITE() As Object

        BTN_WRITE = Nothing

        Dim strHTML As String = Nothing
        Dim MyTermKind As String = Nothing

        If Not LF_GetTermKind(Request.UserHostAddress, MyTermKind) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_BTN_WRITE-1)")
            Exit Function
        End If

        'If L_Func.GF_GetAppInfo("TPJ_ENABLE") <> 1 Then
        '    If MyTermKind <> "TCQ" Then
        '        strHTML = strHTML & "<TD ALIGN='middle'>"
        '        strHTML = strHTML & "<INPUT TYPE='button' VALUE='注文' Style='FONT-SIZE:16pt; WIDTH:90px; HEIGHT:35px; LEFT:820px; POSITION: absolute; TOP: 704px' onClick='fChangeKyakuAP();' ID=""btn_TPJ"" NAME=""btn_TPJ"">"
        '        strHTML = strHTML & "</TD>"
        '    End If
        'End If

        If MyTermKind = "TCQ" Then
            strHTML = strHTML & "<TD ALIGN='middle'>"
            strHTML = strHTML & "<INPUT TYPE='button' VALUE='戻る' Style='FONT-SIZE:16pt; WIDTH:90px; HEIGHT:35px; LEFT:880px; POSITION: absolute; TOP: 704px' onClick = 'fChangeTPQ();' ID=""btn_back"" NAME=""btn_back"">"
            strHTML = strHTML & "</TD>"
        Else
            '自端末時
            If L_Func.GF_GetAppInfo("TPJ_ENABLE") <> 1 Then
                If MyTermKind <> "TCQ" Then

                    If Trim$(L_Func.GF_GetAppInfo2("CNWQ_CNWJ001_BTN")) = "1" Then
                        strHTML = strHTML & "<TD ALIGN='middle'>"
                        strHTML = strHTML & "<INPUT TYPE='button' VALUE='代理注文' Style='FONT-SIZE:16pt; font-family:ＭＳ ゴシック; WIDTH:140px; HEIGHT:60px; LEFT:489px; POSITION: absolute; TOP: 669px' onClick='fChangeKyakuAP();' ID=""btn_TPJ"" NAME=""btn_TPJ"">"
                        strHTML = strHTML & "</TD>"
                    End If

                End If
            End If
        End If

        Response.Write(strHTML)

    End Function

    Private Function LF_SetSQLTPM050(ByVal OrderStatus As String, Optional ByVal pSeatID As String = "") As Object

        LF_SetSQLTPM050 = Nothing

        Dim strSQL As String
        Dim strMenuID As String = Nothing
        Dim strGoodsCD As String = Nothing

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050"

        'If OrderStatus <> "2" Then

        '    strSQL = strSQL & " SET ORDERSTATUS = '2',"     '空席状態
        '    strSQL = strSQL & "     SPMENU      = '000',"                                    '指定メニューＩＤ　
        '    strSQL = strSQL & "     SPMENU2     = '000',"                                    '指定メニューＩＤ　
        '    strSQL = strSQL & "     HISTORYFLG  = '0',"                                      'ヒストリーフラグ　
        'Else
        '    Call LF_GetMenu(strMenuID, strGoodsCD)
        '    'お通し処理（お通し状態に更新）
        '    strSQL = strSQL & " SET ORDERSTATUS = '1',"                                      '端末状態フラグ
        '    strSQL = strSQL & "     SPMENU      = '" & strMenuID & "',"  '指定メニューＩＤ　
        'End If
        'strSQL = strSQL & "  UPDID  = 'CNWG001',"                                             '更新者
        'strSQL = strSQL & "  UPDYMD = GETDATE()"                                             '更新日
        'strSQL = strSQL & " WHERE SEATID = '" & RSet(pSeatID, 5) & "'"
        'strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        'strSQL = strSQL & "   OR    TERMKIND = 'TCA' "
        'strSQL = strSQL & "   OR    TERMKIND = 'TCB' )"

        If L_Func.GF_GetAppInfo("IPPATSU_FLG") = "1" And L_Func.GF_GetAppInfo3("SOBA_FLG") = "1" Then

            If OrderStatus = "1" Then
                strSQL = strSQL & " SET ORDERSTATUS = '5',"     'セット状態
                strSQL = strSQL & "     SPMENU      = '000',"                                    '指定メニューＩＤ　
                strSQL = strSQL & "     SPMENU2     = '000',"                                    '指定メニューＩＤ　
                strSQL = strSQL & "     HISTORYFLG  = '0',"                                      'ヒストリーフラグ

            ElseIf OrderStatus = "5" Then

                Call LF_GetMenu(strMenuID, strGoodsCD)
                'お通し処理（お通し状態に更新）
                strSQL = strSQL & " SET ORDERSTATUS = '1',"                                      '端末状態フラグ
                strSQL = strSQL & "     SPMENU      = '000',"                                    '指定メニューＩＤ　
                strSQL = strSQL & "     SPMENU2     = '000',"                                    '指定メニューＩＤ
                strSQL = strSQL & "     HISTORYFLG  = '0',"                                      'ヒストリーフラグ　

            End If
        ElseIf L_Func.GF_GetAppInfo("IPPATSU_FLG") = "1" Then
            If OrderStatus <> "2" And OrderStatus = "5" Then

                strSQL = strSQL & " SET ORDERSTATUS = '2',"     '空席状態
                strSQL = strSQL & "     SPMENU      = '000',"                                    '指定メニューＩＤ　
                strSQL = strSQL & "     SPMENU2     = '000',"                                    '指定メニューＩＤ　
                strSQL = strSQL & "     HISTORYFLG  = '0',"                                      'ヒストリーフラグ　

            ElseIf L_Func.GF_GetAppInfo("SET_FLG") = "1" And OrderStatus = "1" Then

                strSQL = strSQL & " SET ORDERSTATUS = '5',"     'セット状態
                strSQL = strSQL & "     SPMENU      = '000',"                                    '指定メニューＩＤ　
                strSQL = strSQL & "     SPMENU2     = '000',"                                    '指定メニューＩＤ　
                strSQL = strSQL & "     HISTORYFLG  = '0',"                                      'ヒストリーフラグ　

            Else
                If L_Func.GF_GetAppInfo("MENU_SELECT_FLG") = "0" Then
                    ' 座席別に設定されたメニューを案内する
                    Call LF_GetForEachMenu(strMenuID, strGoodsCD, RSet(L_Seat.Text, 5))
                    If Trim$(strMenuID) = "0" Then
                        Call LF_GetMenu(strMenuID, strGoodsCD)
                    End If
                Else
                    Call LF_GetMenu(strMenuID, strGoodsCD)
                End If

                'お通し処理（お通し状態に更新）
                strSQL = strSQL & " SET ORDERSTATUS = '1',"                                      '端末状態フラグ
                strSQL = strSQL & "     SPMENU      = '" & strMenuID & "',"                      '指定メニューＩＤ　
            End If
        Else
            If OrderStatus <> "2" Then

                strSQL = strSQL & " SET ORDERSTATUS = '2',"     '空席状態
                strSQL = strSQL & "     SPMENU      = '000',"                                    '指定メニューＩＤ　
                strSQL = strSQL & "     SPMENU2     = '000',"                                    '指定メニューＩＤ　
                strSQL = strSQL & "     HISTORYFLG  = '0',"                                      'ヒストリーフラグ　
            Else
                If L_Func.GF_GetAppInfo("MENU_SELECT_FLG") = "0" Then
                    ' 座席別に設定されたメニューを案内する
                    Call LF_GetForEachMenu(strMenuID, strGoodsCD, RSet(pSeatID, 5))
                    If Trim$(strMenuID) = "0" Then
                        Call LF_GetMenu(strMenuID, strGoodsCD)
                    End If
                Else
                    Call LF_GetMenu(strMenuID, strGoodsCD)
                End If

                'お通し処理（お通し状態に更新）
                strSQL = strSQL & " SET ORDERSTATUS = '1',"                                  '端末状態フラグ
                strSQL = strSQL & "     SPMENU      = '" & strMenuID & "',"                  '指定メニューＩＤ　
            End If
        End If

        strSQL = strSQL & "  UPDID  = 'CNWG001',"                                             '更新者
        strSQL = strSQL & "  UPDYMD = GETDATE()"                                              '更新日
        strSQL = strSQL & " WHERE SEATID = '" & RSet(pSeatID, 5) & "'"
        strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCA' "
        strSQL = strSQL & "   OR    TERMKIND = 'TCB' )"

        If Not L_Func.GF_BeginTrans Then
            GoTo SYSTEM_ERROR
        End If

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Function
        End If

        If Not L_Func.GF_CommitTrans Then
            Call L_Func.GF_RollbackTrans()
            GoTo SYSTEM_ERROR
        End If

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG020(LF_SetSQLTPM050)")
        Exit Function
    End Function

    Private Function LF_SetSQLTPD010(ByVal SEATID As String) As Object

        LF_SetSQLTPD010 = Nothing

        Dim strSQL As String
        Dim datNow As Date
        Dim OrderNo As Long
        Dim TERMID As String

        datNow = Now
        OrderNo = LF_GetOrderNo(SEATID)
        TERMID = LF_GetTermID(SEATID)

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPD010 VALUES("
        strSQL = strSQL & "'" & RSet(SEATID, 5) & "', "                                 '座席番号
        strSQL = strSQL & OrderNo & ", "                                  'オーダー連番
        strSQL = strSQL & "'" & TERMID & "', "                                         '端末識別ID
        strSQL = strSQL & "'" & Trim$(Me.ViewState("OPEN_GOODSCD")) & "', "             '商品ID
        strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                          '商品選択日時
        strSQL = strSQL & "0, "                                                         '注文受付日時
        strSQL = strSQL & "0, "                                                         'ステーション配信日時
        strSQL = strSQL & "0, "                                                         '数量
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置１
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ１
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ１
        strSQL = strSQL & "0, "                                                         'SCP数量１
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置２
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ２
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ２
        strSQL = strSQL & "0, "                                                         'SCP数量２
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置３
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ３
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ３
        strSQL = strSQL & "0, "                                                         'SCP数量３
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置４
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ４
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ４
        strSQL = strSQL & "0, "                                                         'SCP数量４
        strSQL = strSQL & "'0', "                                                       'オーダー種別
        strSQL = strSQL & "'0', "                                                       '商品分類
        strSQL = strSQL & "'00', "                                                      '注文フラグ
        strSQL = strSQL & "'000.000.000.000', "                                         '厨房端末識別ID
        strSQL = strSQL & "0, "                                                         'お通し人数
        strSQL = strSQL & "'CNWG001', "                                                  '更新者
        strSQL = strSQL & "GETDATE())"                                                  '更新日

        If Not L_Func.GF_BeginTrans Then
            GoTo SYSTEM_ERROR
        End If

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Function
        End If

        If Not L_Func.GF_CommitTrans Then
            Call L_Func.GF_RollbackTrans()
            GoTo SYSTEM_ERROR
        End If

        'TPD011(INSERT文)
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPD011 VALUES("
        strSQL = strSQL & "'" & RSet(SEATID, 5) & "', "          '座席番号
        strSQL = strSQL & OrderNo & ", "                                               'オーダー連番
        strSQL = strSQL & "'" & TERMID & "', "                                         '端末識別ID
        strSQL = strSQL & "'" & Trim$(Me.ViewState("OPEN_GOODSCD")) & "', "             '商品ID
        strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                          '商品選択日時
        strSQL = strSQL & "0, "                                                         '注文受付日時
        strSQL = strSQL & "0, "                                                         'ステーション配信日時
        strSQL = strSQL & "0, "                                                         '数量
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置１
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ１
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ１
        strSQL = strSQL & "0, "                                                         'SCP数量１
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置２
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ２
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ２
        strSQL = strSQL & "0, "                                                         'SCP数量２
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置３
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ３
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ３
        strSQL = strSQL & "0, "                                                         'SCP数量３
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置４
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ４
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ４
        strSQL = strSQL & "0, "                                                         'SCP数量４
        strSQL = strSQL & "'0', "                                                       'オーダー種別
        strSQL = strSQL & "'0', "                                                       '商品分類
        strSQL = strSQL & "'00', "                                                      '注文フラグ
        strSQL = strSQL & "'000.000.000.000', "                                         '厨房端末識別ID
        strSQL = strSQL & "0, "                                                         'お通し人数
        strSQL = strSQL & "'0', "                                                       '出力先プリンタ
        strSQL = strSQL & "'CNWG001', "                                                  '更新者
        strSQL = strSQL & "GETDATE())"                                                  '更新日

        If Not L_Func.GF_BeginTrans Then
            GoTo SYSTEM_ERROR
        End If

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Function
        End If

        If Not L_Func.GF_CommitTrans Then
            Call L_Func.GF_RollbackTrans()
            GoTo SYSTEM_ERROR
        End If

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG020(LF_SetSQLTPD010)")
        Exit Function
    End Function

    Private Function LF_GetTermID(ByVal SEATID As String) As String
        Dim strSQL As String        '' SQL実行文字列
        Dim objDataSet As DataSet   '' DataSetオブジェクト
        Dim objDataRow As DataRow = Nothing   '' DataRowオブジェクト

        LF_GetTermID = ""

        strSQL = ""
        strSQL = strSQL & "SELECT TERMID"
        strSQL = strSQL & " FROM TPM050"
        strSQL = strSQL & " WHERE SEATID = '" & RSet(SEATID, 5) & "'"
        strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCA'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCB') "
        strSQL = strSQL & " ORDER BY TERMID"

        objDataSet = New DataSet()
        If Not L_Func.GF_GetData(strSQL, objDataSet) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetTermID-1)")
            Exit Function
        End If

        If objDataSet.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objDataSet, 0, objDataRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetTermID-2)")
            Exit Function
        End If

        LF_GetTermID = Trim$(objDataRow("TERMID"))
    End Function

    Private Function LF_GetOrderNo(ByVal strSEATID As String) As Long
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing

        LF_GetOrderNo = 0

        strSQL = ""
        strSQL = strSQL & "SELECT ORDERNO"
        strSQL = strSQL & "  FROM TPD010"
        strSQL = strSQL & " WHERE SEATID ='" & RSet(strSEATID, 5) & "'"
        strSQL = strSQL & " ORDER BY SELECTTIME DESC"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetOrderNo_1)")
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not L_Func.GF_GetRows(objData, 0, objRow) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_GetOrderNo_3)")
            Exit Function
        End If

        LF_GetOrderNo = CLng(objRow("ORDERNO")) + 1
    End Function

    Public Function GF_CheckCALL() As Object

        GF_CheckCALL = Nothing

        Dim strSQL As String
        Dim strALERT As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim intcnt As Integer = 0

        strALERT = ""

        strSQL = ""
        strSQL = strSQL & "SELECT ORDERSTATUS, POSITION FROM TPM050"
        strSQL = strSQL & " WHERE TERMKIND IN ('TCA', 'TCB', 'TCO')"

        If Not L_Func.GF_GetData(strSQL, objData) Then
            Response.Redirect("./TP2990.html?CNWG020(GF_CheckCALL-1)")
            Exit Function
        End If

        For intcnt = 0 To objData.Tables("com").Rows.Count - 1
            If Not L_Func.GF_GetRows(objData, intcnt, objRow) Then
                Exit Function
            End If

            If objRow("ORDERSTATUS") = "6" Or objRow("ORDERSTATUS") = "7" Then
                Select Case objRow("POSITION").ToString
                    Case "11"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "12"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "13"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "14"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "15"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "16"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "17"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "18"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "19"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "20"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "21"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "22"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "23"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "24"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "25"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "26"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "27"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "28"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "29"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "30"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "31"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "32"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "33"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "34"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "35"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "36"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "37"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "38"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "39"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "40"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "41"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "42"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "43"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "44"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "45"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "46"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "47"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "48"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "49"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "50"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "51"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "52"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "53"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "54"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "55"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "56"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "57"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "58"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "59"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "60"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "61"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "62"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "63"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "64"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "65"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "66"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "67"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "68"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "69"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "70"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "71"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "72"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "73"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "74"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "75"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "76"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "77"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "78"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "79"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "70"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "81"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "82"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "83"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "84"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "85"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "86"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "87"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "88"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "89"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case "80"
                        strALERT = strALERT & " fAlert(" & objRow("POSITION") & ");"
                    Case Else

                End Select
            End If

        Next

        Response.Write(strALERT)

    End Function

    Private Function LF_updTPD011(ByVal SEATID As String) As Object

        LF_updTPD011 = Nothing

        Dim strSQL As String
        Dim objData As New DataSet()

        strSQL = ""
        strSQL = strSQL & "UPDATE TPD011 SET ORDERFLG = '11'"
        strSQL = strSQL & " WHERE GOODSCD IN(" & Me.ViewState("CALL_GOODSCD") & ", " & Me.ViewState("REG_GOODSCD") & ")"
        strSQL = strSQL & "   AND TRANSTIME <> '0'"
        strSQL = strSQL & "   AND ORDERFLG NOT IN('11', '12')"
        strSQL = strSQL & "   AND KCPNO = '" & Me.ViewState("ESPRO_KCPNO") & "'"
        strSQL = strSQL & "   AND SEATID = '" & SEATID & "'"

        If Not L_Func.GF_BeginTrans Then
            GoTo SYSTEM_ERROR
        End If

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Function
        End If

        If Not L_Func.GF_CommitTrans Then
            Call L_Func.GF_RollbackTrans()
            GoTo SYSTEM_ERROR
        End If
SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG020(LF_updTPD011)")
    End Function

    Private Function LF_updTPM050(ByVal SEATID As String, ByVal ORDERSTAUTS As String) As Object

        LF_updTPM050 = Nothing

        Dim strSQL As String
        Dim objData As New DataSet()

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050"
        If ORDERSTAUTS = "6" Then
            strSQL = strSQL & "   SET ORDERSTATUS = '8'"
        ElseIf ORDERSTAUTS = "7" Then
            strSQL = strSQL & "   SET ORDERSTATUS = '9'"
        Else
            Exit Function
        End If

        strSQL = strSQL & " WHERE SEATID = '" & RSet(SEATID, 5) & "'"

        strSQL = strSQL & " AND TERMKIND IN ('TC0', 'TCA', 'TCB')"

        If Not L_Func.GF_BeginTrans Then
            GoTo SYSTEM_ERROR
        End If

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Function
        End If

        If Not L_Func.GF_CommitTrans Then
            Call L_Func.GF_RollbackTrans()
            GoTo SYSTEM_ERROR
        End If

        Exit Function
SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG020(LF_updTPM050")
    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：客席ボタン不可用、透明画像出力処理
    ' --------------------------------------------------------------------------------
    Public Sub ClearWrite()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim MyTermKind As String = Nothing

        '-----------------------------
        '自端末TERMKIND取得
        '-----------------------------
        If Not LF_GetTermKind(Request.UserHostAddress, MyTermKind) Then
            Response.Redirect("./TP2990.html?CNWG020(LF_BTN_WRITE-1)")
            Exit Sub
        End If

        If MyTermKind = "TCQ" Then
            If L_Func.GF_GetAppInfo("SEAT_ENABLE") = 0 Then
                Response.Write("<div style=""Z-INDEX: 500; LEFT: 0px; POSITION: absolute; TOP: 50px""><img src=""./gif/SVGA64.gif"" width=1000 height=615></div>")
            End If
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：自端末TERMKIND取得
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTermKind(ByVal pIPAddr As String, ByRef pTermNo As String) As Boolean

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing

        '------------------------------
        '初期値設定
        '------------------------------
        LF_GetTermKind = False

        '------------------------------
        ' 自端末番号取得処理
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM050.TERMKIND"
        strSQL = strSQL & "  FROM TPM050"
        strSQL = strSQL & " WHERE TPM050.TERMID   = '" & pIPAddr & "'"
        If Not L_Func.GF_GetData(strSQL, objData) Then
            Exit Function
        End If
        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If
        If Not L_Func.GF_GetRows(objData, 0, objRows) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        pTermNo = Trim$(objRows("TERMKIND"))
        LF_GetTermKind = True

    End Function
    Private Sub call1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles call1.Click
        Call LS_Update_TPD500(call1.Text, "3", orderstatus1.Text)
    End Sub
    Private Sub call2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles call2.Click
        Call LS_Update_TPD500(call2.Text, "3", orderstatus2.Text)
    End Sub
    Private Sub call3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles call3.Click
        Call LS_Update_TPD500(call3.Text, "3", orderstatus3.Text)
    End Sub
    Private Sub call4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles call4.Click
        Call LS_Update_TPD500(call4.Text, "3", orderstatus4.Text)
    End Sub
    Private Sub call5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles call5.Click
        Call LS_Update_TPD500(call5.Text, "3", orderstatus5.Text)
    End Sub
    Private Sub call6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles call6.Click
        Call LS_Update_TPD500(call6.Text, "3", orderstatus6.Text)
    End Sub
    Private Sub LS_Update_TPD500(ByVal SEATID As String, ByVal ORDERFLG As String, Optional ByVal ORDERTIME As String = "")
        Dim strSQL As String
        strSQL = ""
        strSQL = strSQL & "UPDATE TPD500 SET"
        strSQL = strSQL & " TRANSTIME = '" & Format$(Now, "yyyyMMddHHmmss") & "',"
        'strSQL = strSQL & " ORDERSTATUS = '1',"
        strSQL = strSQL & " UPDID = 'CNWG001',"
        strSQL = strSQL & " UPDYMD = '" & Now & "'"
        strSQL = strSQL & " WHERE TRANSTIME = '0'"

        If ORDERTIME <> "" Then
            strSQL = strSQL & "   AND ORDERTIME = '" & ORDERTIME & "'"
        Else
            strSQL = strSQL & "   AND SEATID = '" & RSet(SEATID, 5) & "'"
        End If

        If ORDERFLG = "1" Then
            '客席　呼出消し込み
            strSQL = strSQL & "   AND ORDERFLG = '01'"
        ElseIf ORDERFLG = "2" Then
            '客席　会計消し込み
            strSQL = strSQL & "   AND ORDERFLG = '02'"
        ElseIf ORDERFLG = "3" Then
            '厨房　消し込み
            strSQL = strSQL & "   AND ORDERFLG IN ('11', '12')"
        End If
        strSQL = strSQL & "   AND ORDERSTATUS IN ('0', '1', '4')"

        If Not Session("TP").GF_BeginTrans Then
            Exit Sub
        End If
        If Not Session("TP").GF_UpdData(strSQL) Then
            Call Session("TP").GF_RollbackTrans()
            Exit Sub
        End If
        If Not Session("TP").GF_CommitTrans Then
            Call Session("TP").GF_RollbackTrans()
            Exit Sub
        End If
        Call LF_SetDefaultForm()
        Call LF_SetForm("0")
    End Sub
    Private Function LS_DispCustomer(ByVal strSEATID As String) As Boolean

        Dim strSQL As String
        Dim objData As New DataSet()

        LS_DispCustomer = False

        strSQL = ""
        strSQL = strSQL & "SELECT SEATID, ORDERFLG FROM TPD500"
        strSQL = strSQL & " WHERE SEATID = '" & RSet(strSEATID, 5) & "'"
        strSQL = strSQL & "   AND ORDERFLG = '01'"
        strSQL = strSQL & "   AND TRANSTIME = '0'"
        strSQL = strSQL & "   AND ORDERSTATUS IN ('0', '2')"
        strSQL = strSQL & " ORDER BY ORDERTIME"

        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        Else
            LS_DispCustomer = True
        End If

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG010(LS_DispCustomer)")
        Exit Function
    End Function
    Private Sub LS_DispStaff()

        Dim strSQL As String
        Dim i As Integer = 0
        Dim objData As New DataSet()
        Dim objRow As DataRow

        strSQL = ""
        strSQL = strSQL & "SELECT SEATID, ORDERFLG, ORDERTIME FROM TPD500"
        strSQL = strSQL & " WHERE ORDERFLG IN ('11', '12')"
        strSQL = strSQL & "   AND TRANSTIME = '0'"
        strSQL = strSQL & "   AND ORDERSTATUS IN ('0', '2')"
        strSQL = strSQL & " ORDER BY ORDERTIME"

        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Exit Sub
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Sub
        End If

        objRow = Nothing

        For i = 0 To objData.Tables("com").Rows.Count - 1

            If Not Session("TP").GF_GetRows(objData, i, objRow) Then
                GoTo SYSTEM_ERROR
            End If

            Select Case i
                Case 0
                    call1.Visible = True
                    call1.Text = Trim$(objRow("SEATID"))
                    call1.ForeColor = Color.Black
                    orderstatus1.Text = Trim$(objRow("ORDERTIME"))
                    If objRow("ORDERFLG") = "12" Then
                        call1.Text = "TO"
                        call1.ForeColor = Color.Red
                    End If
                Case 1
                    call2.Visible = True
                    call2.Text = Trim$(objRow("SEATID"))
                    call2.ForeColor = Color.Black
                    orderstatus2.Text = Trim$(objRow("ORDERTIME"))
                    If objRow("ORDERFLG") = "12" Then
                        call2.Text = "TO"
                        call2.ForeColor = Color.Red
                    End If
                Case 2
                    call3.Visible = True
                    call3.Text = Trim$(objRow("SEATID"))
                    call3.ForeColor = Color.Black
                    orderstatus3.Text = Trim$(objRow("ORDERTIME"))
                    If objRow("ORDERFLG") = "12" Then
                        call3.Text = "TO"
                        call3.ForeColor = Color.Red
                    End If
                Case 3
                    call4.Visible = True
                    call4.Text = Trim$(objRow("SEATID"))
                    call4.ForeColor = Color.Black
                    orderstatus4.Text = Trim$(objRow("ORDERTIME"))
                    If objRow("ORDERFLG") = "12" Then
                        call4.Text = "TO"
                        call4.ForeColor = Color.Red
                    End If
                Case 4
                    call5.Visible = True
                    call5.Text = Trim$(objRow("SEATID"))
                    call5.ForeColor = Color.Black
                    orderstatus5.Text = Trim$(objRow("ORDERTIME"))
                    If objRow("ORDERFLG") = "12" Then
                        call5.Text = "TO"
                        call5.ForeColor = Color.Red
                    End If
                Case 5
                    call6.Visible = True
                    call6.Text = Trim$(objRow("SEATID"))
                    call6.ForeColor = Color.Black
                    orderstatus6.Text = Trim$(objRow("ORDERTIME"))
                    If objRow("ORDERFLG") = "12" Then
                        call6.Text = "TO"
                        call6.ForeColor = Color.Red
                    End If
                Case Else
                    Exit Sub
            End Select

        Next

        Exit Sub

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWC010(LS_GetTPD500)")
        Exit Sub
    End Sub

    '' **************************************************
    ''	機能概要：ORDERSTATUSを取得する。
    ''	引	  数：
    ''	戻 り 値：ORDERSTATUS
    '' **************************************************
    Private Function GetOrderStatus(ByVal SEATID As String) As String
        Dim strSQL As String = Nothing '' SQL実行文字列
        Dim objData As DataSet '' キャッシュ情報
        Dim objRow As DataRow = Nothing '' 指定行情報

        GetOrderStatus = ""
        '' ------------------------------
        '' ORDERSTATUS取得
        '' ------------------------------
        strSQL = "Select ORDERSTATUS"
        strSQL = strSQL & " FROM TPM050"
        strSQL = strSQL & " WHERE  SEATID = '" & RSet(SEATID, 5) & "'"
        strSQL = strSQL & " AND    TERMKIND IN ('TC0','TCA','TCB') "

        objData = New DataSet()
        If Not Session("TP").GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If Not Session("TP").GF_GetRows(objData, 0, objRow) Then
            Exit Function
        End If

        GetOrderStatus = Trim$(objRow("ORDERSTATUS"))
    End Function

    Private Sub LF_Seatcancel(ByVal SEATID As String)

        Dim strSQL As String
        Dim VtermID As String

        '自端末のIPアドレス取得
        VtermID = L_Func.GF_GetRealTermID_SEATID(SEATID)

        '固定席・開局、座席設定同時に行う場合は処理対象外
        If L_Func.GF_GetSeatFlg(VtermID) = "F" And L_Func.GF_GetAppInfo2("FIXED_SEAT_OPENFLG") = "0" Then
            Exit Sub
        End If

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM051"
        strSQL = strSQL & "   SET TPM051.VIRTUALTERMID = ' ',"
        strSQL = strSQL & "       TPM051.UPDID         = 'CNWG020',"
        strSQL = strSQL & "       TPM051.UPDYMD        = '" & Now() & "'"
        strSQL = strSQL & " WHERE REALTERMID ='" & VtermID & "'"


        If Not Session("TP").GF_BeginTrans Then
            Exit Sub
        End If
        If Not Session("TP").GF_UpdData(strSQL) Then
            Call Session("TP").GF_RollbackTrans()
            Exit Sub
        End If
        If Not Session("TP").GF_CommitTrans Then
            Call Session("TP").GF_RollbackTrans()
            Exit Sub
        End If

    End Sub

    Private Function LF_SetSQLTPM050_C(ByVal pSeatID As String) As Object

        LF_SetSQLTPM050_C = Nothing

        Dim strSQL As String

        strSQL = ""
        strSQL = strSQL & "UPDATE TPM050"
        strSQL = strSQL & " SET ORDERSTATUS = '2',"                     '空席状態
        strSQL = strSQL & "     SPMENU      = '000',"                   '指定メニューＩＤ　
        strSQL = strSQL & "     SPMENU2     = '000',"                   '指定メニューＩＤ　
        strSQL = strSQL & "     HISTORYFLG  = '0',"                     'ヒストリーフラグ　
        strSQL = strSQL & "     UPDID       = 'CNWG001',"               '更新者
        strSQL = strSQL & "     UPDYMD      = GETDATE()"                '更新日
        strSQL = strSQL & " WHERE SEATID = '" & RSet(pSeatID, 5) & "'"
        strSQL = strSQL & "   AND ( TERMKIND = 'TC0'"
        strSQL = strSQL & "   OR    TERMKIND = 'TCA' "
        strSQL = strSQL & "   OR    TERMKIND = 'TCB' )"

        If Not L_Func.GF_BeginTrans Then
            GoTo SYSTEM_ERROR
        End If

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Function
        End If

        If Not L_Func.GF_CommitTrans Then
            Call L_Func.GF_RollbackTrans()
            GoTo SYSTEM_ERROR
        End If

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWG020(LF_SetSQLTPM050)")
        Exit Function
    End Function

    Private Sub btn_CLOSURE_Click()

        Dim strHTML As String
        Dim strMenuID As String = Nothing
        Dim strGoodsCD As String = Nothing

        strHTML = ""
        strHTML = "<iframe src=""CNWG080.aspx"" id=""F_CNWG020"" height=""748"" width=""1020"" align=""middle"" style=""Z-INDEX: 600; LEFT: 0px; POSITION: absolute; TOP: 0px"" frameBorder=""1"" scrolling=""no""></iframe>"

        Response.Write(strHTML)
    End Sub

    'Private Sub btn_release_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_release.Click

    '    Dim strHTML As String

    '    strHTML = ""
    '    strHTML = "<iframe src=""CNWG100.aspx"" id=""F_CNWG020"" height=""768"" width=""1024"" align=""middle"" style=""Z-INDEX: 600; LEFT: 0px; POSITION: absolute; TOP: 0px"" frameBorder=""1"" scrolling=""no""></iframe>"

    '    Response.Write(strHTML)
    'End Sub


    Private Sub btn_Release_Click()

        Dim strHTML As String

        strHTML = ""
        strHTML = "<iframe src=""CNWG100.aspx"" id=""F_CNWG020"" height=""768"" width=""1024"" align=""middle"" style=""Z-INDEX: 600; LEFT: 0px; POSITION: absolute; TOP: 0px"" frameBorder=""1"" scrolling=""no""></iframe>"

        Response.Write(strHTML)
    End Sub

    Protected Sub btn_table14_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_table14.Click

    End Sub

    Private Function LF_SetSQLTPD010_C(ByVal pTERMID As String, ByVal pORDERNO As Long, Optional ByVal pSeatID As String = "") As Object

        LF_SetSQLTPD010_C = Nothing

        Dim strSQL As String
        Dim datNow As Date


        datNow = Now

        If Not L_Func.GF_BeginTrans Then
            GoTo SYSTEM_ERROR
        End If

        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPD010 VALUES("

        If Len(Trim$(pSeatID)) = 0 Then
            strSQL = strSQL & "'" & RSet(Request.QueryString("SEATID"), 5) & "', "                  '座席番号
        Else
            strSQL = strSQL & "'" & RSet(pSeatID, 5) & "', "
        End If

        strSQL = strSQL & pORDERNO & ", "                                               'オーダー連番
        strSQL = strSQL & "'" & pTERMID & "', "                                         '端末識別ID
        'お会計処理 商品ID
        strSQL = strSQL & "'" & Trim$(Me.ViewState("REG_GOODSCD")) & "', "          'コードをTPM090から取得
        strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","
        'お会計処理
        strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","
        strSQL = strSQL & "0,"                                                       ' お会計処理時、配信日時を設定しない
        strSQL = strSQL & "0, "                                                         '数量
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置１
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ１
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ１
        strSQL = strSQL & "0, "                                                         'SCP数量１
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置２
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ２
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ２
        strSQL = strSQL & "0, "                                                         'SCP数量２
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置３
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ３
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ３
        strSQL = strSQL & "0, "                                                         'SCP数量３
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置４
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ４
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ４
        strSQL = strSQL & "0, "                                                         'SCP数量４
        strSQL = strSQL & "'0', "                                                       'オーダー種別
        strSQL = strSQL & "'0', "                                                       '商品分類
        strSQL = strSQL & "'12', "                                                      '注文フラグ
        strSQL = strSQL & "'000.000.000.000', "                                         '厨房端末識別ID
        'お会計処理 'お通し人数
        strSQL = strSQL & "0, "
        strSQL = strSQL & "'CNWG001', "                                                    '更新者
        strSQL = strSQL & "GETDATE())"                                                    '更新日

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Function
        End If

        'TPD011(INSERT文)
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPD011 VALUES("
        strSQL = strSQL & "'" & RSet(Request.QueryString("SEATID"), 5) & "', "          '座席番号                                      
        'お会計処理 オーダー連番
        strSQL = strSQL & pORDERNO & ", "
        strSQL = strSQL & "'" & pTERMID & "', "                                         '端末識別ID
        'お会計処理 商品ID
        strSQL = strSQL & "'" & Trim$(Me.ViewState("REG_GOODSCD")) & "', "          'コードをTPM090から取得
        strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                          '商品選択日時
        'お会計処理
        strSQL = strSQL & Format$(Now, "yyyyMMddHHmmss") & ","                      '注文受付日時
        strSQL = strSQL & "0,"                                                      'ステーション配信日時
        strSQL = strSQL & "0, "                                                         '数量
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置１
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ１
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ１
        strSQL = strSQL & "0, "                                                         'SCP数量１
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置２
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ２
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ２
        strSQL = strSQL & "0, "                                                         'SCP数量２
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置３
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ３
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ３
        strSQL = strSQL & "0, "                                                         'SCP数量３
        strSQL = strSQL & "'00', "                                                      '指示ステータス位置４
        strSQL = strSQL & "'000', "                                                     'SCPｺｰﾄﾞ４
        strSQL = strSQL & "'0000', "                                                    'SCPﾒﾆｭｰ４
        strSQL = strSQL & "0, "                                                         'SCP数量４
        strSQL = strSQL & "'0', "                                                       'オーダー種別
        strSQL = strSQL & "'0', "                                                       '商品分類
        strSQL = strSQL & "'12', "                                                      '注文フラグ
        strSQL = strSQL & "'000.000.000.000', "                                         '厨房端末識別ID
        'お会計処理 お通し人数
        strSQL = strSQL & "0, "
        strSQL = strSQL & "'0', "                                                       '出力先プリンタ
        strSQL = strSQL & "'CNWG001', "                                                  '更新者
        strSQL = strSQL & "GETDATE())"                                                  '更新日

        If Not L_Func.GF_UpdData(strSQL) Then
            Call L_Func.GF_RollbackTrans()
            Exit Function
        End If

        If Not L_Func.GF_CommitTrans Then
            Call L_Func.GF_RollbackTrans()
            GoTo SYSTEM_ERROR
        End If

        Exit Function

SYSTEM_ERROR:
        Response.Redirect("./TP2990.html?CNWT401(LF_SetSQLTPD010)")
        Exit Function
    End Function

    Public Sub getFGRefreshable()
        If Request.QueryString("fgRefreshable") <> "" Then
            Response.Write(Request.QueryString("fgRefreshable"))
        Else
            Response.Write("true")
        End If
    End Sub



End Class
