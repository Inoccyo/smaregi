Public Class CNL1582
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Title As System.Windows.Forms.TextBox
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_OK As System.Windows.Forms.Button
    Friend WithEvents lst_Menu As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Title = New System.Windows.Forms.TextBox()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.lst_Menu = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "■ 新しく作成するメニュー名を入力してください"
        '
        'txt_Title
        '
        Me.txt_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Title.Location = New System.Drawing.Point(24, 192)
        Me.txt_Title.Name = "txt_Title"
        Me.txt_Title.Size = New System.Drawing.Size(360, 22)
        Me.txt_Title.TabIndex = 2
        Me.txt_Title.Text = "txt_Title"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(336, 224)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(72, 32)
        Me.btn_Cancel.TabIndex = 4
        Me.btn_Cancel.Text = "キャンセル"
        '
        'btn_OK
        '
        Me.btn_OK.Location = New System.Drawing.Point(256, 224)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(72, 32)
        Me.btn_OK.TabIndex = 3
        Me.btn_OK.Text = "決定"
        '
        'lst_Menu
        '
        Me.lst_Menu.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lst_Menu.ItemHeight = 15
        Me.lst_Menu.Items.AddRange(New Object() {"定番メニュー１", "定番メニュー２", "定番メニュー３", "ランチメニュー１", "ランチメニュー２"})
        Me.lst_Menu.Location = New System.Drawing.Point(24, 40)
        Me.lst_Menu.Name = "lst_Menu"
        Me.lst_Menu.Size = New System.Drawing.Size(360, 124)
        Me.lst_Menu.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "■ コピー元のメニューを選択して下さい"
        '
        'CNL1582
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(424, 278)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.txt_Title, Me.btn_Cancel, Me.btn_OK, Me.lst_Menu, Me.Label1})
        Me.Name = "CNL1582"
        Me.Text = "CNL1582"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private L_Bmap As Bitmap

    Private Sub CNL1582_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim dtsData As New DataSet()
        Dim dtrData As DataRow = Nothing
        Dim lngCnt As Long

        Try
            '------------------------------
            ' フォーム初期化
            '------------------------------
            Me.Text = GF_FormText()
            lst_Menu.Items.Clear()
            txt_Title.Clear()
            '---20060531 張本 ADD 画像コピー用のビットマップ領域作成
            L_Bmap = New Bitmap(686, 500, System.Drawing.Imaging.PixelFormat.Format32bppRgb)

            '------------------------------
            ' 既存メニューレコード取得
            '------------------------------
            strSQL = ""
            strSQL = strSQL & "SELECT MENUID, MENUNM"
            strSQL = strSQL & "  FROM TPM170"
            strSQL = strSQL & " WHERE GROUPCD = '0000'"
            strSQL = strSQL & " GROUP BY MENUID, MENUNM"
            If Not GF_GetData(strSQL, dtsData) Then
                GoTo SYSTEM_ERROR
            End If
            While lngCnt < dtsData.Tables("com").Rows.Count
                If Not GF_GetRows(dtsData, lngCnt, dtrData) Then
                    GoTo SYSTEM_ERROR
                End If

                lst_Menu.Items.Add(Trim$(dtrData("MENUNM")) & _
                                         Space(100) & _
                                         vbTab & _
                                         Trim$(dtrData("MENUID")))
                lngCnt = lngCnt + 1
            End While
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL1582_Load")
    End Sub
    ' --------------------------------------------------------------------------------
    ' 　機　　能：決定ボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click

        Try
            '------------------------------
            ' 未入力チェック
            '------------------------------
            If lst_Menu.SelectedIndex = -1 Then
                Call GF_Msg("E08", "", MsgBoxStyle.OKOnly, MsgBoxStyle.Critical)
                lst_Menu.Select()
                Exit Sub
            End If
            If Len(Trim$(txt_Title.Text)) = 0 Then
                Call GF_Msg("E01", "", MsgBoxStyle.OKOnly, MsgBoxStyle.Critical)
                txt_Title.Select()
                Exit Sub
            End If

            ' 同一名称のメニューが既に存在している場合は、エラーメッセージを表示して、処理を中断させる
            Select Case LF_GetTPM170(Trim$(txt_Title.Text))
                Case CNL1920.FuncResult.CancelEnd
                    ' 存在するので、エラー 
                    Call GF_Msg("", "既に【" & Trim$(txt_Title.Text) & "】が存在するため、使用できません。" & vbCrLf & "他のメニュー名を入力して下さい。", MsgBoxStyle.OKOnly, MsgBoxStyle.Critical)
                    Exit Sub

                Case CNL1920.FuncResult.UnusualEnd
                    GoTo SYSTEM_ERROR
            End Select

            '------------------------------
            ' メニューレコード複写処理
            '------------------------------
            If Not LF_CopyMenu() Then
                GoTo SYSTEM_ERROR
            End If

            With Me
                .DialogResult = DialogResult.OK
                .Close()
            End With
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub
SYSTEM_ERROR:
        Call GS_ErrorTerm("btn_OK_Click")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：同一メニュー名称存在チェック処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM170(ByVal pMenuNM As String) As FuncResult

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM170 = CNL1920.FuncResult.UnusualEnd

        strSQL = ""
        strSQL = strSQL & "SELECT TPM170.MENUID"
        strSQL = strSQL & "  FROM TPM170"
        strSQL = strSQL & " WHERE TPM170.MENUNM = '" & pMenuNM & "'"
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        If objData.Tables("com").Rows.Count = 0 Then
            LF_GetTPM170 = CNL1920.FuncResult.NormalEnd
        Else
            LF_GetTPM170 = CNL1920.FuncResult.CancelEnd
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：キャンセルボタン押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        With Me
            .DialogResult = DialogResult.Cancel
            .Close()
        End With
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニューレコード複写処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_CopyMenu() As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()
        Dim objRow As DataRow = Nothing
        Dim lngCnt As Long
        Dim strNewID As String = Nothing
        Dim strGoodsCD1 As String = Nothing
        Dim strGoodsCD2 As String = Nothing
        Dim strGoodsNM As String
        Dim strWork() As String
        Dim strFileName As String
        Dim strMenuGrpID As String = "000"
        Dim strOldFileNM As String
        Dim strFlag As Integer
        Dim bmap As Bitmap

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_CopyMenu = False
        strFlag = 0

        strWork = Split(lst_Menu.Items.Item(lst_Menu.SelectedIndex), vbTab)

        ' 新規メニューＩＤ取得
        If Not GF_GetNewID2(strNewID) Then
            Exit Function
        End If

        ' サブメニュー商品コード採番
        ' --- ↓(2008.11.25) 皿勘定有時の飲み放題対応のため修正↓ ---
        'If Not GF_GetGoodsCD(strGoodsCD1, strGoodsCD2, 8000) Then
        If Not GF_GetGoodsCD(strGoodsCD1, strGoodsCD2, 7000) Then
        ' --- ↑(2008.11.25) 皿勘定有時の飲み放題対応のため修正↑ ---
            Exit Function
        End If

        ' サブメニュー商品コードを商品マスタ(TPM010)に登録
        strGoodsNM = "１" & Trim$(txt_Title.Text)
        If Not GF_InTPM010(strGoodsCD1, strGoodsNM) Then
            Exit Function
        End If
        strGoodsNM = "２" & Trim$(txt_Title.Text)
        If Not GF_InTPM010(strGoodsCD2, strGoodsNM) Then
            Exit Function
        End If

        ' コピー元情報取得
        strSQL = ""
        strSQL = strSQL & "SELECT * FROM TPM170"
        strSQL = strSQL & " WHERE MENUID = '" & strWork(1) & "'"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        lngCnt = 0
        While lngCnt < objData.Tables("com").Rows.Count

            If Not GF_GetRows(objData, lngCnt, objRow) Then
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM170 VALUES("
            strSQL = strSQL & "'" & strNewID & "',"                                 ' メニューＩＤ
            strSQL = strSQL & "'" & GF_RepQuo(Trim$(txt_Title.Text)) & "',"         ' メニュー名称
            strSQL = strSQL & "'" & objRow("MENUSTYLE") & "',"                      ' メニュー形態
            strSQL = strSQL & "'" & objRow("GROUPCD") & "',"                        ' 商品グループＩＤ
            strSQL = strSQL & "'" & objRow("DISPORDER") & "',"                      ' 表示順
            strSQL = strSQL & "'" & objRow("PRICEDISP") & "',"                      ' 単価表示有無
            strSQL = strSQL & "'" & objRow("GROUPKBN") & "',"                       ' 金額／グループ順区分
            strSQL = strSQL & "'" & objRow("ENABLED") & "',"                        ' 有効フラグ
            strSQL = strSQL & "0,"                                                  ' 飲み放題時間
            strSQL = strSQL & "'" & strGoodsCD1 & "',"                              ' サブメニュー１商品コード
            strSQL = strSQL & "'0',"                                                ' サブメニュー１有効フラグ
            strSQL = strSQL & "'" & strGoodsCD2 & "',"                              ' サブメニュー２商品コード
            strSQL = strSQL & "'0',"                                                ' サブメニュー１有効フラグ
            strSQL = strSQL & "'" & GC_UPDID & "',"
            strSQL = strSQL & "'" & Now & "')"

            If Not GF_UpdData(strSQL) Then
                Exit Function
            End If

            lngCnt = lngCnt + 1

        End While

        objData = New DataSet()

        strSQL = ""
        strSQL = strSQL & "SELECT * FROM TPM150"
        '---20060530 張本 ADD キー変更　strNewID START---
        strSQL = strSQL & " WHERE MENUID = '" & strWork(1) & "'"
        '---20060530 張本 ADD END---
        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        lngCnt = 0
        '---20060531 張本 ADD START 画像情報コピーと同時に画像もコピー---
        strOldFileNM = ""
        strFileName = ""
        strFileName = "MENU_" & strNewID & "_" & strMenuGrpID & "_" & Format$(Now, "yyyyMMddhhmmss") & ".jpg"
        '---20060531 張本 ADD END---

        While lngCnt < objData.Tables("com").Rows.Count
            If Not GF_GetRows(objData, lngCnt, objRow) Then
                Exit Function
            End If

            strSQL = ""
            strSQL = strSQL & "INSERT INTO TPM150 VALUES("
            strSQL = strSQL & "'" & strNewID & "',"
            strSQL = strSQL & "'" & Trim$(objRow("MENUGRPID")) & "',"
            strSQL = strSQL & Trim$(objRow("POSCNT")) & ","
            strSQL = strSQL & "'" & Trim$(objRow("TERMTYPE")) & "',"
            strSQL = strSQL & Trim$(objRow("POSX1")) & ","
            strSQL = strSQL & Trim$(objRow("POSY1")) & ","
            strSQL = strSQL & Trim$(objRow("POSX2")) & ","
            strSQL = strSQL & Trim$(objRow("POSY2")) & ","
            strSQL = strSQL & "'" & Trim$(objRow("GROUPCD")) & "',"
            '20060530 張本 ADD　コピー情報とコピー元情報の画像情報切り分けの為
            'strSQL = strSQL & "'" & Trim$(objRow("IMAGEFILE")) & "',"
            If Trim$(objRow("IMAGEFILE")) <> "" Then
                strFlag = 1
                strSQL = strSQL & "'" & strFileName & "',"
            End If
            strSQL = strSQL & "'" & GC_UPDID & "',"
            strSQL = strSQL & "'" & Now & "')"

            If Not GF_UpdData(strSQL) Then
                Exit Function
            End If

            lngCnt = lngCnt + 1

        End While

        '---20060531 張本 ADD START 画像情報コピーと同時に画像もコピー---

        '-- コピー元となる画像をコピーする
        If strFlag = 1 Then
            L_Bmap.Dispose()
            bmap = New Bitmap(GF_GetAppInfo("GROUP_PATH") & "\" & Trim$(objRow("IMAGEFILE")))
            L_Bmap = New Bitmap(bmap, 800, 600)

            '画像名称編集処理
            If Not LF_SaveImage(strFileName, strOldFileNM) Then
                Exit Function
            End If
        End If
        '---20060531 張本 ADD END---

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_CopyMenu = True

    End Function

    Private Sub txt_Title_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Title.TextChanged

        Try
            ' --- (2003.12.08) 半角文字を入力制限した ---
            Dim lngST As Long
            lngST = txt_Title.SelectionStart
            ' 2014-05-12 2バイト文字制限解除
            'txt_Title.Text = StrConv(txt_Title.Text, VbStrConv.Wide)
            If lngST >= 0 Then txt_Title.SelectionStart = lngST
            ' -------------------------------------------

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

    Private Function LF_SaveImage(ByVal pFileName As String, ByVal pOldfFileNM As String) As Boolean
        ' --------------------------------------------------------------------------------
        ' 　機　　能：編集画像保存処理
        ' --------------------------------------------------------------------------------

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_SaveImage = False

        Try
            '------------------------------
            ' エンコード方式の指定
            '------------------------------
            Dim myEncoderParameters As New System.Drawing.Imaging.EncoderParameters(1)
            Dim myEncoderParameter As New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 99)
            myEncoderParameters.Param(0) = myEncoderParameter

            '------------------------------
            ' 保存形式の指定
            '------------------------------
            Dim myImageCodecInfo As System.Drawing.Imaging.ImageCodecInfo
            myImageCodecInfo = GF_GetEncoderInfo("image/jpeg")
            Dim ext As String = myImageCodecInfo.FilenameExtension.Split(";"c)(0)
            ext = System.IO.Path.GetExtension(ext).ToLower()

            '------------------------------
            ' 保存処理
            '------------------------------
            Dim saveName As String
            saveName = System.IO.Path.ChangeExtension(GF_GetAppInfo("GROUP_PATH") & "\" & pFileName, ext)
            If Trim$(pOldfFileNM) <> "" Then
                pOldfFileNM = System.IO.Path.ChangeExtension(GF_GetAppInfo("GROUP_PATH") & "\" & pOldfFileNM, ext)
                If System.IO.File.Exists(pOldfFileNM) = True Then
                    System.IO.File.Delete(pOldfFileNM)
                End If
            End If
            L_Bmap.Save(saveName, myImageCodecInfo, myEncoderParameters)

        Catch
            Exit Function
        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_SaveImage = True

    End Function

End Class
