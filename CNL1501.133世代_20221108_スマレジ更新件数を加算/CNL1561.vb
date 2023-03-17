Public Class CNL1561
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
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_OK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lst_Menu As System.Windows.Forms.CheckedListBox
    Friend WithEvents txt_Select As System.Windows.Forms.TextBox
    Friend WithEvents btn_Select As System.Windows.Forms.Button
    Friend WithEvents lst_MenuHide As System.Windows.Forms.CheckedListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CNL1561))
        Me.btn_Cancel = New System.Windows.Forms.Button
        Me.btn_OK = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lst_Menu = New System.Windows.Forms.CheckedListBox
        Me.txt_Select = New System.Windows.Forms.TextBox
        Me.btn_Select = New System.Windows.Forms.Button
        Me.lst_MenuHide = New System.Windows.Forms.CheckedListBox
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(146, 431)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(104, 32)
        Me.btn_Cancel.TabIndex = 5
        Me.btn_Cancel.Text = "キャンセル"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_OK
        '
        Me.btn_OK.BackColor = System.Drawing.SystemColors.Control
        Me.btn_OK.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_OK.Location = New System.Drawing.Point(34, 431)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(104, 32)
        Me.btn_OK.TabIndex = 4
        Me.btn_OK.Text = "決定"
        Me.btn_OK.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(34, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "■ 商品を選択して下さい"
        '
        'lst_Menu
        '
        Me.lst_Menu.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lst_Menu.Location = New System.Drawing.Point(34, 72)
        Me.lst_Menu.Name = "lst_Menu"
        Me.lst_Menu.Size = New System.Drawing.Size(224, 328)
        Me.lst_Menu.TabIndex = 3
        '
        'txt_Select
        '
        Me.txt_Select.Location = New System.Drawing.Point(40, 40)
        Me.txt_Select.Name = "txt_Select"
        Me.txt_Select.Size = New System.Drawing.Size(152, 19)
        Me.txt_Select.TabIndex = 1
        '
        'btn_Select
        '
        Me.btn_Select.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Select.Location = New System.Drawing.Point(200, 40)
        Me.btn_Select.Name = "btn_Select"
        Me.btn_Select.Size = New System.Drawing.Size(64, 24)
        Me.btn_Select.TabIndex = 2
        Me.btn_Select.Text = "検索"
        Me.btn_Select.UseVisualStyleBackColor = False
        '
        'lst_MenuHide
        '
        Me.lst_MenuHide.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lst_MenuHide.Location = New System.Drawing.Point(264, 72)
        Me.lst_MenuHide.Name = "lst_MenuHide"
        Me.lst_MenuHide.Size = New System.Drawing.Size(16, 328)
        Me.lst_MenuHide.TabIndex = 6
        Me.lst_MenuHide.Visible = False
        '
        'CNL1561
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(292, 478)
        Me.Controls.Add(Me.lst_MenuHide)
        Me.Controls.Add(Me.btn_Select)
        Me.Controls.Add(Me.txt_Select)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lst_Menu)
        Me.Name = "CNL1561"
        Me.Text = "商品選択"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Public G_Menu As String
    Public G_Code As String

    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objItem As Object
        Dim lngCnt As Long

        '------------------------------
        ' 同時指定数チェック
        '------------------------------
        lngCnt = 0
        G_Menu = ""

        For Each objItem In lst_Menu.CheckedItems
            G_Menu = objItem
            G_Code = lst_MenuHide.Items.Item(lst_Menu.CheckedIndices(lngCnt))
            lngCnt = lngCnt + 1
        Next

        If lngCnt >= 2 Then
            Call GF_Msg("", "複数選択されています", MsgBoxStyle.OKOnly, MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        '------------------------------
        ' 親画面へ値返却
        '------------------------------
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub CNL1561_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim objForm As New CNL1560()
        Dim i As Integer

        LF_SetList()
        i = lst_MenuHide.FindStringExact(G_Code)
        If i > 0 Then
            lst_Menu.SetItemChecked(i, True)
        End If

    End Sub

    Private Function LF_SetList() As Object

        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim lngCnt As Long

        LF_SetList = Nothing

        strSQL = ""
        strSQL = strSQL & "SELECT GOODSNMJ, GOODSCD FROM TPM010"
        strSQL = strSQL & " WHERE PRICE <> 0"
        If Trim$(txt_Select.Text) <> "" Then
            strSQL = strSQL & " AND GOODSNMJ LIKE '%" & Trim$(txt_Select.Text) & "%'"
        End If

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count > 0 Then

            lst_Menu.Items.Clear()
            lst_MenuHide.Items.Clear()

            For lngCnt = 0 To objData.Tables("com").Rows.Count - 1
                If Not GF_GetRows(objData, lngCnt, objRow) Then
                    Exit Function
                End If
                lst_Menu.Items.Add(objRow("GOODSNMJ"))
                lst_MenuHide.Items.Add(objRow("GOODSCD"))

            Next
        End If

    End Function

    Private Sub btn_Select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Select.Click
        '-- 検索ボタンクリック

        LF_SetList()

    End Sub
End Class
