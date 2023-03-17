Public Class CNL1571
    Inherits System.Windows.Forms.Form

#Region " Windows フォーム デザイナで生成されたコード "

    Public Sub New()
        MyBase.New()

        ' この呼び出しは Windows フォーム デザイナで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後に初期化を追加します。

    End Sub

    ' Form は dispose をオーバーライドしてコンポーネント一覧を消去します。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    ' メモ : 以下のプロシージャは、Windows フォーム デザイナで必要です。
    ' Windows フォーム デザイナを使って変更してください。  
    ' コード エディタは使用しないでください。
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdo_FreeMsg As System.Windows.Forms.RadioButton
    Friend WithEvents lsv_MsgList As System.Windows.Forms.ListView
    Friend WithEvents txt_Msg1 As System.Windows.Forms.TextBox
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents btn_Del As System.Windows.Forms.Button
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_Del = New System.Windows.Forms.Button
        Me.btn_Add = New System.Windows.Forms.Button
        Me.txt_Msg1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lsv_MsgList = New System.Windows.Forms.ListView
        Me.rdo_FreeMsg = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.stb_Msg = New System.Windows.Forms.StatusBar
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_Del)
        Me.Panel1.Controls.Add(Me.btn_Add)
        Me.Panel1.Controls.Add(Me.txt_Msg1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lsv_MsgList)
        Me.Panel1.Controls.Add(Me.rdo_FreeMsg)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 400)
        Me.Panel1.TabIndex = 0
        '
        'btn_Del
        '
        Me.btn_Del.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Del.Location = New System.Drawing.Point(416, 344)
        Me.btn_Del.Name = "btn_Del"
        Me.btn_Del.Size = New System.Drawing.Size(120, 32)
        Me.btn_Del.TabIndex = 11
        Me.btn_Del.Text = "削　　除"
        '
        'btn_Add
        '
        Me.btn_Add.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Add.Location = New System.Drawing.Point(288, 344)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(120, 32)
        Me.btn_Add.TabIndex = 10
        Me.btn_Add.Text = "新規追加"
        '
        'txt_Msg1
        '
        Me.txt_Msg1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Msg1.Location = New System.Drawing.Point(288, 48)
        Me.txt_Msg1.Name = "txt_Msg1"
        Me.txt_Msg1.Size = New System.Drawing.Size(248, 22)
        Me.txt_Msg1.TabIndex = 5
        Me.txt_Msg1.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "■ メッセージの文言を編集します"
        '
        'lsv_MsgList
        '
        Me.lsv_MsgList.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lsv_MsgList.Location = New System.Drawing.Point(40, 96)
        Me.lsv_MsgList.Name = "lsv_MsgList"
        Me.lsv_MsgList.Size = New System.Drawing.Size(200, 280)
        Me.lsv_MsgList.TabIndex = 3
        Me.lsv_MsgList.UseCompatibleStateImageBehavior = False
        Me.lsv_MsgList.View = System.Windows.Forms.View.Details
        '
        'rdo_FreeMsg
        '
        Me.rdo_FreeMsg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdo_FreeMsg.Location = New System.Drawing.Point(40, 46)
        Me.rdo_FreeMsg.Name = "rdo_FreeMsg"
        Me.rdo_FreeMsg.Size = New System.Drawing.Size(176, 24)
        Me.rdo_FreeMsg.TabIndex = 2
        Me.rdo_FreeMsg.Text = "任意送信メッセージ"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "■ メッセージの種類を選択します"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4})
        Me.MenuItem1.Text = "ファイル(&F)"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "保存(&S)"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "終了(&E)"
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 401)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(576, 24)
        Me.stb_Msg.TabIndex = 2
        Me.stb_Msg.Text = "StatusBar1"
        '
        'CNL1571
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(576, 425)
        Me.Controls.Add(Me.stb_Msg)
        Me.Controls.Add(Me.Panel1)
        Me.Menu = Me.MainMenu1
        Me.Name = "CNL1571"
        Me.Text = "CNL1571"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private L_blnEdit As Boolean

    Private Structure typMsg
        Dim strMsgCD As String
        Dim strMsg As String
    End Structure

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub CNL1571_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' フォーム名称設定
        '------------------------------
        Me.Text = GF_FormText(" - 客席端末送信メッセージ編集")

        '------------------------------
        ' 初期化処理
        '------------------------------
        Call GS_StatusSetup(stb_Msg)                                        ' ステータスバー初期化

        '------------------------------
        ' 画面初期化
        '------------------------------
        Call LS_FormSetup()

        '------------------------------
        ' トランザクション開始
        '------------------------------
        L_blnEdit = False

        If Not GF_BeginTrans() Then
            GoTo SYSTEM_ERROR
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1571_Load")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_FormSetup()

        '------------------------------
        ' 初期値設定
        '------------------------------
        txt_Msg1.Clear()
        btn_Add.Enabled = True
        btn_Del.Enabled = True

        '------------------------------
        ' 画面初期値設定
        '------------------------------
        With lsv_MsgList
            .Clear()
            .HeaderStyle = ColumnHeaderStyle.None
            .Columns.Add("メッセージ内容", 196, HorizontalAlignment.Left)
            .MultiSelect = False
            .HideSelection = False
        End With

        '------------------------------
        ' メッセージリスト作成
        '------------------------------
        Call LS_FreeMsgList()

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_FormSetup")
    End Sub

    Private Sub CNL1571_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objRet As MsgBoxResult

        '------------------------------
        ' 更新処理確認
        '------------------------------
        If L_blnEdit Then
            objRet = GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNoCancel)
            Select Case objRet
                Case MsgBoxResult.Yes
                    '------------------------------
                    ' トランザクション確定
                    '------------------------------
                    If Not GF_CommitTrans() Then
                        GoTo SYSTEM_ERROR
                    End If

                Case MsgBoxResult.No
                    '------------------------------
                    ' トランザクション破棄
                    '------------------------------
                    If Not GF_RollbackTrans() Then
                        GoTo SYSTEM_ERROR
                    End If

                Case MsgBoxResult.Cancel
                    e.Cancel = True
            End Select
        Else
            '------------------------------
            ' トランザクション破棄
            '------------------------------
            If Not GF_RollbackTrans() Then
                GoTo SYSTEM_ERROR
            End If
        End If

        Exit Sub

SYSTEM_ERROR:
        '------------------------------
        ' トランザクション破棄
        '------------------------------
        Call GF_RollbackTrans()
        Call GS_ErrorTerm("CNL1571_Closing")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メッセージリスト作成処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_FreeMsgList()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngCnt As Long
        Dim objItem As ListViewItem

        '------------------------------
        ' メッセージ一覧取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT TPM030.CODEID,"
        strSQL = strSQL & "       TPM030.CODEVAL,"
        strSQL = strSQL & "       TPM030.CODENM"
        strSQL = strSQL & "  FROM TPM030 LEFT JOIN TPM120 ON TPM030.CODEID = TPM120.CODEID AND TPM030.CODEVAL = TPM120.CODEVAL AND TPM120.IMAGECD LIKE 'MA%'"
        strSQL = strSQL & " WHERE TPM030.CODEID  = 'SENDMSG2'"
        strSQL = strSQL & " ORDER BY TPM030.CODEVAL"

        If Not GF_GetData(strSQL, objData) Then
            GoTo SYSTEM_ERROR
        End If

        '------------------------------
        ' リストボックス設定
        '------------------------------
        lsv_MsgList.Items.Clear()
        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRows) Then
                GoTo SYSTEM_ERROR
            End If

            objItem = New ListViewItem()
            With objItem
                .Text = LF_N2S(objRows("CODENM"))
                .SubItems.Add(LF_N2S(objRows("CODEVAL")))
                .SubItems.Add(LF_N2S(objRows("CODENM")))
                .SubItems.Add("")
                .SubItems.Add("")
            End With
            lsv_MsgList.Items.Add(objItem)

            lngCnt = lngCnt + 1
        End While

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_FreeMsgList")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＮＵＬＬ値判定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_N2S(ByVal pObject As Object) As String

        LF_N2S = ""
        If IsDBNull(pObject) Then
            Exit Function
        Else
            LF_N2S = Trim$(pObject)
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メッセージリスト　選択メッセージ変更処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub lsv_MsgList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_MsgList.SelectedIndexChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim strNoImgCD(2) As String

        objCollection = lsv_MsgList.SelectedItems
        With objCollection
            If .Count = 0 Then
                Exit Sub
            End If

            If .Contains(.Item(0)) = False Then
                Exit Sub
            End If

            txt_Msg1.Text = RTrim$(.Item(0).SubItems(2).Text)
        End With

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：送信メッセージ文言変更処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub txt_Msg1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Msg1.TextChanged

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngST As Long
        Dim objCollection As ListView.SelectedListViewItemCollection

        '------------------------------
        ' イベント処理続行判定
        '------------------------------
        If txt_Msg1.Modified = False Then
            Exit Sub
        End If

        '------------------------------
        ' 半角入力禁止
        '------------------------------
        lngST = txt_Msg1.SelectionStart
            ' 2014-05-12 2バイト文字制限解除
        'txt_Msg1.Text = StrConv(txt_Msg1.Text, VbStrConv.Wide)
        If lngST >= 0 Then
            txt_Msg1.SelectionStart = lngST
        End If

        '------------------------------
        ' 入力長制約
        '------------------------------
        If GF_LenB(txt_Msg1.Text) > 40 Then
            txt_Msg1.Text = GF_MidB(txt_Msg1.Text, 1, 40)
            txt_Msg1.SelectionStart = GF_LenB(txt_Msg1.Text)
            Exit Sub
        End If

        '------------------------------
        ' 更新処理
        '------------------------------
        objCollection = lsv_MsgList.SelectedItems
        With objCollection
            If .Count = 0 Then
                Exit Sub
            End If

            If .Contains(.Item(0)) = False Then
                Exit Sub
            End If

            .Item(0).SubItems(2).Text = Trim$(txt_Msg1.Text)
            .Item(0).SubItems(0).Text = Trim$(txt_Msg1.Text)

            If Not LF_UpdTPM030(Trim$(.Item(0).SubItems(1).Text), RTrim$(.Item(0).SubItems(2).Text)) Then
                GoTo SYSTEM_ERROR
            End If
        End With

        L_blnEdit = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("txt_Msg1_TextChanged")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＴＰＭ０３０更新処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_UpdTPM030(ByVal pMsgCD As String, ByVal pMsgVal As String) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim strMsg As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_UpdTPM030 = False

        If Len(Trim$(pMsgVal)) = 0 Then
            strMsg = Space(40)
        Else
            strMsg = pMsgVal
        End If

        '------------------------------
        ' メッセージマスタ更新
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "UPDATE TPM030"
        strSQL = strSQL & "   SET CODENM  = '" & GF_RepQuo(strMsg) & "',"
        strSQL = strSQL & "       UPDID   = 'SYSTEM',"
        strSQL = strSQL & "       UPDYMD  = getdate()"
        strSQL = strSQL & " WHERE CODEID  = 'SENDMSG2'"
        strSQL = strSQL & "   AND CODEVAL = '" & pMsgCD & "'"

        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_UpdTPM030 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニュー - [保存]押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objRet As MsgBoxResult

        '------------------------------
        ' 更新処理確認
        '------------------------------
        If L_blnEdit Then
            objRet = GF_Msg("Q03", "", MsgBoxStyle.Question, MsgBoxStyle.YesNoCancel)
            Select Case objRet
                Case MsgBoxResult.Yes
                    If Not GF_CommitTrans() Then                            ' トランザクション確定
                        GoTo SYSTEM_ERROR
                    End If

                Case MsgBoxResult.No
                    If Not GF_RollbackTrans() Then                          ' トランザクション破棄
                        GoTo SYSTEM_ERROR
                    End If

            End Select

            If Not GF_BeginTrans() Then
                GoTo SYSTEM_ERROR
            End If
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GF_RollbackTrans()
        Call GS_ErrorTerm("MenuItem2_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニュー - [終了]押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Me.Close()
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：「新規追加」ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click

        If Not LF_InsTPM030() Then
            GoTo SYSTEM_ERROR
        End If

        Call LS_FreeMsgList()

        L_blnEdit = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Add_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：「削除」ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Del.Click

        If Not LF_DelTPM030() Then
            GoTo SYSTEM_ERROR
        End If

        Call LS_FreeMsgList()

        L_blnEdit = True

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_Del_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＴＰＭ０３０追加処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_InsTPM030() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRows As DataRow = Nothing
        Dim lngI As Long
        Dim strNewID As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_InsTPM030 = False

        '------------------------------
        ' 採番処理
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT CODEVAL"
        strSQL = strSQL & "  FROM TPM030"
        strSQL = strSQL & " WHERE CODEID = 'SENDMSG2'"
        strSQL = strSQL & " ORDER BY CODEVAL"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        strNewID = ""
        If objData.Tables("com").Rows.Count = 0 Then
            strNewID = "I00"
        Else
            If Not GF_GetRows(objData, objData.Tables("com").Rows.Count - 1, objRows) Then
                Exit Function
            End If

            If Mid(Trim$(objRows("CODEVAL")), 2) = "99" Then
                ' 空き番検索処理
                lngI = 0
                While lngI < objData.Tables("com").Rows.Count
                    If Not GF_GetRows(objData, lngI, objRows) Then
                        Exit Function
                    End If
                    If lngI <> CLng(Mid$(Trim$(objRows("CODEVAL")), 2)) Then
                        strNewID = "I" & Format$(lngI, "00")
                        Exit While
                    End If

                    lngI = lngI + 1
                End While

                If Len(Trim$(strNewID)) = 0 Then
                    Call GF_Msg("", "これ以上、メッセージを追加することができません", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                    LF_InsTPM030 = True
                    Exit Function
                End If
            Else
                strNewID = "I" & Format$(CLng(Mid(Trim$(objRows("CODEVAL")), 2)) + 1, "00")
            End If
        End If

        '------------------------------
        ' 新規メッセージレコード追加
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "INSERT INTO TPM030 VALUES("
        strSQL = strSQL & "       'SENDMSG2',"
        strSQL = strSQL & "       '" & strNewID & "',"
        strSQL = strSQL & "       '新規追加メッセージ',"
        strSQL = strSQL & "       'SYSTEM',"
        strSQL = strSQL & "       getdate())"

        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_InsTPM030 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ＴＰＭ０３０削除処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_DelTPM030() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objCollection As ListView.SelectedListViewItemCollection
        Dim strSQL As String

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_DelTPM030 = False

        '------------------------------
        ' イベント処理続行判定
        '------------------------------
        objCollection = lsv_MsgList.SelectedItems
        With objCollection
            If .Count = 0 Then Exit Function
            If .Contains(.Item(0)) = False Then Exit Function
        End With

        '------------------------------
        ' メッセージマスタ削除
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE"
        strSQL = strSQL & "  FROM TPM030"
        strSQL = strSQL & " WHERE TPM030.CODEID  = 'SENDMSG2'"
        strSQL = strSQL & "   AND TPM030.CODEVAL = '" & Trim$(objCollection.Item(0).SubItems(1).Text) & "'"

        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' イラスト関連付けマスタ削除
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "DELETE"
        strSQL = strSQL & "  FROM TPM120"
        strSQL = strSQL & " WHERE TPM120.CODEID  = 'SENDMSG2'"
        strSQL = strSQL & "   AND TPM120.CODEVAL = '" & Trim$(objCollection.Item(0).SubItems(1).Text) & "'"

        If Not GF_UpdData(strSQL) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_DelTPM030 = True

    End Function
End Class
