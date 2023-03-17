' --------------------------------------------------------------------------------
' 　機　　能：店舗内情報システム - サーバメンテナンス(バックアップ／リカバリ)
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
' --------------------------------------------------------------------------------

Public Class CNL1600
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents trv_BKInfo As System.Windows.Forms.TreeView
    Friend WithEvents txt_Comment As System.Windows.Forms.TextBox
    Friend WithEvents tlb_Btn As System.Windows.Forms.ToolBar
    Friend WithEvents stb_Msg As System.Windows.Forms.StatusBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CNL1600))
        Me.stb_Msg = New System.Windows.Forms.StatusBar()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.trv_BKInfo = New System.Windows.Forms.TreeView()
        Me.tlb_Btn = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.txt_Comment = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'stb_Msg
        '
        Me.stb_Msg.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stb_Msg.Location = New System.Drawing.Point(0, 667)
        Me.stb_Msg.Name = "stb_Msg"
        Me.stb_Msg.ShowPanels = True
        Me.stb_Msg.Size = New System.Drawing.Size(1018, 24)
        Me.stb_Msg.TabIndex = 211
        Me.stb_Msg.Text = "StatusBar1"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'trv_BKInfo
        '
        Me.trv_BKInfo.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.trv_BKInfo.FullRowSelect = True
        Me.trv_BKInfo.ImageList = Me.ImageList1
        Me.trv_BKInfo.Location = New System.Drawing.Point(8, 64)
        Me.trv_BKInfo.Name = "trv_BKInfo"
        Me.trv_BKInfo.Nodes.AddRange(New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("９９月９９日（月）", 2, 2, New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("(13時20分)　コメントＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"), New System.Windows.Forms.TreeNode("(16時35分)"), New System.Windows.Forms.TreeNode("(20時54分)")}), New System.Windows.Forms.TreeNode("９９月９９日（火）", 2, 2, New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("#1 (15時40分)"), New System.Windows.Forms.TreeNode("#2 (退避データなし)", 1, 1), New System.Windows.Forms.TreeNode("#3 (退避データなし)", 1, 1)}), New System.Windows.Forms.TreeNode("９９月９９日（水）", 2, 2, New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("#1 (99時99分)"), New System.Windows.Forms.TreeNode("#2 (99時99分)"), New System.Windows.Forms.TreeNode("#3 (99時99分)")}), New System.Windows.Forms.TreeNode("９９月９９日（木）", 2, 2, New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("ノード16"), New System.Windows.Forms.TreeNode("ノード17"), New System.Windows.Forms.TreeNode("ノード18")}), New System.Windows.Forms.TreeNode("９９月９９日（金）", 2, 2, New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("ノード19"), New System.Windows.Forms.TreeNode("ノード20"), New System.Windows.Forms.TreeNode("ノード21")}), New System.Windows.Forms.TreeNode("９９月９９日（土）", 2, 2, New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("ノード22"), New System.Windows.Forms.TreeNode("ノード23"), New System.Windows.Forms.TreeNode("ノード24")}), New System.Windows.Forms.TreeNode("９９月９９日（日）", 2, 2, New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("ノード25"), New System.Windows.Forms.TreeNode("ノード26"), New System.Windows.Forms.TreeNode("ノード27")})})
        Me.trv_BKInfo.Size = New System.Drawing.Size(1000, 592)
        Me.trv_BKInfo.TabIndex = 2
        '
        'tlb_Btn
        '
        Me.tlb_Btn.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2})
        Me.tlb_Btn.ButtonSize = New System.Drawing.Size(150, 51)
        Me.tlb_Btn.Divider = False
        Me.tlb_Btn.Dock = System.Windows.Forms.DockStyle.None
        Me.tlb_Btn.DropDownArrows = True
        Me.tlb_Btn.ImageList = Me.ImageList2
        Me.tlb_Btn.Location = New System.Drawing.Point(8, 8)
        Me.tlb_Btn.Name = "tlb_Btn"
        Me.tlb_Btn.ShowToolTips = True
        Me.tlb_Btn.Size = New System.Drawing.Size(304, 52)
        Me.tlb_Btn.TabIndex = 0
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 0
        Me.ToolBarButton1.Text = "データを退避する"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 1
        Me.ToolBarButton2.Text = "退避データから、復元する"
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'txt_Comment
        '
        Me.txt_Comment.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Comment.Location = New System.Drawing.Point(320, 40)
        Me.txt_Comment.MaxLength = 100
        Me.txt_Comment.Name = "txt_Comment"
        Me.txt_Comment.Size = New System.Drawing.Size(688, 22)
        Me.txt_Comment.TabIndex = 1
        Me.txt_Comment.Text = "TextBox1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(320, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 236
        Me.Label1.Text = "コメント"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txt_Comment, Me.Label1, Me.tlb_Btn, Me.trv_BKInfo})
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 664)
        Me.Panel1.TabIndex = 237
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
        Me.MenuItem2.Text = "退避設定(&V)"
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
        'CNL1600
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1018, 691)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel1, Me.stb_Msg})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "CNL1600"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JCV05"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub JCV05_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' フォーム名称設定
        '------------------------------
        Me.Text = GF_FormText("- バックアップ・リカバリ画面")

        '------------------------------
        ' フォーム初期化処理
        '------------------------------
        txt_Comment.Text = ""
        Call GS_StatusSetup(stb_Msg)                                        ' ステータスバー初期化
        trv_BKInfo.HideSelection = False

        '------------------------------
        ' 初期表示処理
        '------------------------------
        Call LS_CreateBKTree()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：バックアップデータツリー 表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_CreateBKTree()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim lngChildCnt As Long
        Dim objRNode As TreeNode = Nothing
        Dim objCNode As TreeNode = Nothing
        Dim strRootTxt As String
        Dim strChildTxt As String
        Dim objFile As System.IO.StreamReader
        Dim strFileLine As String
        Dim strWork() As String
        Dim intImgIndex As Integer
        Dim strPathAry() As String
        Dim lngCnt As Long
        Dim strSubFlds() As String

        '------------------------------
        ' ツリーノード表示処理
        '------------------------------
        Try
            With trv_BKInfo
                .BeginUpdate()
                .Nodes.Clear()
            End With

            If System.IO.Directory.Exists(g_udtAppConfig.strBKPath) = False Then
                Call GF_Msg("", "バックアップパスが存在しないか、設定に誤りがあります。バックアップ・リカバリ処理を行えません。", MsgBoxStyle.OKOnly, MsgBoxStyle.Critical)
                With tlb_Btn
                    .Buttons(0).Enabled = False
                    .Buttons(1).Enabled = False
                End With
                txt_Comment.Enabled = False
                Exit Sub
            End If

            strPathAry = System.IO.Directory.GetDirectories(g_udtAppConfig.strBKPath)
            Array.Sort(strPathAry)
            For lngCnt = UBound(strPathAry) To 0 Step -1
                If System.IO.File.Exists(strPathAry(lngCnt) & "\" & GC_BKLOG_NM) = True Then
                    '------------------------------
                    ' 親ノード追加
                    '------------------------------
                    objFile = New System.IO.StreamReader(strPathAry(lngCnt) & "\" & GC_BKLOG_NM, System.Text.Encoding.Default)
                    strFileLine = objFile.ReadLine
                    objFile.Close()
                    strWork = Split(strFileLine, vbTab)
            ' 2014-05-12 2バイト文字制限解除
                    'strRootTxt = StrConv(Format$(CDate(strWork(0)), "yyyy"), VbStrConv.Wide) & "年" & _
                    '             StrConv(Format$(CDate(strWork(0)), "MM"), VbStrConv.Wide) & "月" & _
                    '             StrConv(Format$(CDate(strWork(0)), "dd"), VbStrConv.Wide) & "日（" & _
                    '             WeekdayName(Weekday(CDate(strWork(0))), False) & "）"
                    strRootTxt = Format$(CDate(strWork(0)), "yyyy") & "年" & _
                                 Format$(CDate(strWork(0)), "MM") & "月" & _
                                 Format$(CDate(strWork(0)), "dd") & "日（" & _
                                 WeekdayName(Weekday(CDate(strWork(0))), False) & "）"
                    objRNode = trv_BKInfo.Nodes.Add(strRootTxt)                     ' 親ノードを追加
                    With objRNode
                        .ImageIndex = 2
                        .SelectedImageIndex = 2
                        .Tag = ""
                    End With

                    '------------------------------
                    ' 子ノード追加
                    '------------------------------
                    strSubFlds = System.IO.Directory.GetDirectories(strPathAry(lngCnt))
                    Array.Sort(strSubFlds)
                    For lngChildCnt = UBound(strSubFlds) To 0 Step -1
                        If System.IO.File.Exists(strSubFlds(lngChildCnt) & "\" & GC_BKLOG_NM) = True Then
                            objFile = New System.IO.StreamReader(strSubFlds(lngChildCnt) & "\" & GC_BKLOG_NM, System.Text.Encoding.Default)
                            strFileLine = objFile.ReadLine
                            objFile.Close()
                            strWork = Split(strFileLine, vbTab)
            ' 2014-05-12 2バイト文字制限解除
                            'strChildTxt = "（" & _
                            '              StrConv(Format$(CDate(strWork(0)), "HH"), VbStrConv.Wide) & "時" & _
                            '              StrConv(Format$(CDate(strWork(0)), "mm"), VbStrConv.Wide) & "分）" & _
                            '              Space(4) & strWork(1)
                            strChildTxt = "（" & _
                                          Format$(CDate(strWork(0)), "HH") & "時" & _
                                          Format$(CDate(strWork(0)), "mm") & "分）" & _
                                          Space(4) & strWork(1)
                            intImgIndex = 0
                            objCNode = objRNode.Nodes.Add(strChildTxt)
                            With objCNode
                                .ImageIndex = intImgIndex
                                .SelectedImageIndex = intImgIndex
                                .Tag = strSubFlds(lngChildCnt)
                            End With
                        End If
                    Next
                End If
            Next

            With trv_BKInfo
                .ExpandAll()
                .EndUpdate()
            End With
        Catch
            GoTo SYSTEM_ERROR
        End Try
        Exit Sub

SYSTEM_ERROR:
        trv_BKInfo.EndUpdate()
        Call GS_ErrorTerm("LS_CreateBKTree")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ツールバー押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub tlb_Btn_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlb_Btn.ButtonClick

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objNode As TreeNode = Nothing
        Dim strQMsgID As String ' 開始前メッセージＩＤ
        Dim strSMsgID As String ' 処理中メッセージＩＤ
        Dim strEMsgID As String ' 処理完了メッセージＩＤ

        Select Case e.Button.Text
            Case tlb_Btn.Buttons.Item(0).Text                               ' バックアップ処理
                strQMsgID = "Q07"
                strSMsgID = "S02"
                strEMsgID = "S04"
            Case tlb_Btn.Buttons.Item(1).Text
                strQMsgID = "Q08"
                strSMsgID = "S03"
                strEMsgID = "S05"
                objNode = trv_BKInfo.SelectedNode
                If IsNothing(objNode) Then
                    Exit Sub
                Else
                    If IsNothing(objNode.Parent) Then
                        Exit Sub
                    Else
                        If objNode.ImageIndex <> 0 Then
                            Exit Sub
                        End If
                    End If
                End If
            Case Else
                Exit Sub
        End Select
        If GF_Msg(strQMsgID, "", MsgBoxStyle.OKCancel, MsgBoxStyle.Question) = MsgBoxResult.OK Then
            stb_Msg.Panels(0).Text = GF_GetMsg(strSMsgID)
            Me.Cursor = Cursors.WaitCursor
            If e.Button.Text = tlb_Btn.Buttons.Item(0).Text Then
                If Not GF_Backup(Trim$(txt_Comment.Text)) Then
                    GoTo SYSTEM_ERROR
                End If
            Else
                If Not GF_Recovery(objNode.Tag) Then
                    GoTo SYSTEM_ERROR
                End If
            End If
            Me.Cursor = Cursors.Default
            Call GF_Msg(strEMsgID, "", MsgBoxStyle.OKOnly, MsgBoxStyle.Information)
            stb_Msg.Panels(0).Text = ""
            Call LS_CreateBKTree()                                      ' ツリービュー再生成
        End If

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("ToolBar1_ButtonClick")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：保存日数/保存回数設定ウィンドウ表示処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォームクローズ時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub TP1060_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not LF_QueryQuit()
    End Sub

    Private Function LF_QueryQuit() As Boolean
        LF_QueryQuit = False
        'If MsgBox(GF_GetMsg("012"), MsgBoxStyle.YesNo + MsgBoxStyle.Question, g_udtAppConfig.strAppName) = MsgBoxResult.No Then
        '    Exit Function
        'End If
        LF_QueryQuit = True
    End Function

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim objForm As New CNL1601()
        objForm.ShowDialog()
        Call LS_CreateBKTree()                                      ' ツリービュー再生成
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Me.Close()
    End Sub
End Class
