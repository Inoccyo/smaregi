' --------------------------------------------------------------------------------
' 　機　　能：CrossNavi - メインメニュー画面
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2003.10.27 ソラン北陸 新規作成
' --------------------------------------------------------------------------------

Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Http
Imports TP1901.ServiceCls

Public Class CNL2010
    Inherits System.Windows.Forms.Form

    Private Shared judge As Boolean '2016.04.25 田代             商品出力先判定用変数
    Public Shared Property L_judge() As Boolean '2016.04.25 田代 商品出力先判定用プロパティ
        Get
            Return judge
        End Get
        Set(ByVal value As Boolean)
            judge = value
        End Set
    End Property

    ' --------------------------------------------------------------------------------
    ' 　機　　能：フォーム読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub CNL2010_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSVHTTPUrl As String
        Dim strFlgTecDataImportPath As String

        Try
            '------------------------------
            ' フォーム名称設定
            '------------------------------
            Me.Text = GF_FormText(" - メインメニュー")

            '------------------------------
            ' オプション登録が有効の場合のみ「オプション登録」ボタン有効
            '------------------------------
            If GF_GetAppInfo("OPTIONWIN_TYPE") = "1" Then
                btn_menu05.Enabled = True
            Else
                btn_menu05.Enabled = False
            End If

            '------------------------------
            ' 定額メニューが有効の場合のみ「食べ飲み放題設定」ボタン有効
            '------------------------------
            If GF_GetAppInfo("PRICE_TYPE") = "1" Then
                btn_menu08.Enabled = True
            Else
                btn_menu08.Enabled = False
            End If

            '------------------------------
            ' 「プレビュー」ボタン　有効
            '------------------------------
            'btn_menu09.Visible = False

            If GF_GetAppInfo2("CNWP_PREVIEW_FLG") = "1" Then
                btn_preview.Enabled = True
            Else
                btn_preview.Enabled = False
            End If

            '------------------------------
            ' サーバ通信ポート ＯＰＥＮ
            '------------------------------
            Dim objChannel As New HttpChannel(0)                            ' HTTPチャンネルを用意する
            strSVHTTPUrl = "http://" & GF_GetAppInfo("SV_IPADDR") & ":" & GF_GetAppInfo("SV_HTTP_PORT") & "/tpuri"
            ChannelServices.RegisterChannel(objChannel, False)
            RemotingConfiguration.RegisterWellKnownClientType( _
                GetType(TP1901.ServiceCls), _
                strSVHTTPUrl)                                               ' リモートサーバーへの接続を用意する

            '------------------------------
            ' ボタン色設定処理
            '------------------------------
            Call LS_SetButtonColor()

            ' このフォームを MDI コンテナとして設定する
            Me.IsMdiContainer = True

            ' MDI 子フォームの新しいインスタンスを生成する
            Dim cFormChild As New CNL2020

            ' MDI 子フォームの親をこのフォームに設定する
            cFormChild.MdiParent = Me
            cFormChild.WindowState = FormWindowState.Maximized

            ' MDI 子フォームを表示する
            cFormChild.Show()

            '------------------------------
            ' 2015.9.29 OA) TECデータ取込 フラグファイルチェック
            '------------------------------
            If (GF_GetAppInfo("SYS_TYPE") = 2 And GF_GetAppInfo("OES_TOOL_VER") = 0 And GF_GetAppInfo("OES_TOOL_VER_CNL1501") = 0) Then
                strFlgTecDataImportPath = GF_GetAppInfo("AP_PATH") & "\" & "flg_tec_data_import"
                If System.IO.File.Exists(strFlgTecDataImportPath) Then
                    btn_menu11.Font = New Font("ＭＳ ゴシック", 11.25)
                    btn_menu11.Text = "各種設定"
                Else
                    btn_menu11.Font = New Font("ＭＳ ゴシック", 10)
                    btn_menu11.Text = "各種設定" & vbCrLf & "※TECデータ取込未実施"
                End If
            End If
        Catch
            GoTo SYSTEM_ERROR
        End Try

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("CNL2010_Load")

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：開店処理読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2011.11.08 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_menu01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu01.Click

        If ResetOpenWindow("CNL2020") Then
            ' MDI 子フォームの新しいインスタンスを生成する
            Dim cFormChild As New CNL2020

            ' MDI 子フォームの親をこのフォームに設定する
            cFormChild.MdiParent = Me
            cFormChild.WindowState = FormWindowState.Maximized

            ' MDI 子フォームを表示する
            cFormChild.Show()
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品登録読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2011.11.08 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_menu02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu02.Click

        If ResetOpenWindow("CNL1530", CNL1530.PROC_KIND.GooodsEdit) Then
            ' MDI 子フォームの新しいインスタンスを生成する
            Dim cFormChild As New CNL1530

            ' MDI 子フォームの親をこのフォームに設定する
            cFormChild.MdiParent = Me
            cFormChild.WindowState = FormWindowState.Maximized
            cFormChild.pProcKind = CNL1530.PROC_KIND.GooodsEdit

            ' MDI 子フォームを表示する
            cFormChild.Show()
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：商品配置読み込み時処理（ジャンル）
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2011.11.08 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_menu03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu03.Click

        If ResetOpenWindow("CNL2030") Then
            ' MDI 子フォームの新しいインスタンスを生成する
            Dim cFormChild As New CNL2030

            ' MDI 子フォームの親をこのフォームに設定する
            cFormChild.MdiParent = Me
            cFormChild.WindowState = FormWindowState.Maximized

            ' MDI 子フォームを表示する
            cFormChild.Show()
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：広告画像作成読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2011.11.08 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_menu04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu04.Click

        If ResetOpenWindow("CNL1560") Then
            ' MDI 子フォームの新しいインスタンスを生成する
            Dim cFormChild As New CNL1560

            ' MDI 子フォームの親をこのフォームに設定する
            cFormChild.MdiParent = Me
            cFormChild.WindowState = FormWindowState.Maximized

            ' MDI 子フォームを表示する
            cFormChild.Show()
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：オプション登録読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2011.11.08 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_menu05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu05.Click

        If ResetOpenWindow("CNL2060") Then
            ' MDI 子フォームの新しいインスタンスを生成する
            Dim cFormChild As New CNL2060

            ' MDI 子フォームの親をこのフォームに設定する
            cFormChild.MdiParent = Me
            cFormChild.WindowState = FormWindowState.Maximized

            ' MDI 子フォームを表示する
            cFormChild.Show()
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：おすすめ商品登録読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2011.11.08 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_menu06_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu06.Click

        If ResetOpenWindow("CNL1530", CNL1530.PROC_KIND.RecommendationEdit) Then
            ' MDI 子フォームの新しいインスタンスを生成する
            Dim cFormChild As New CNL1530

            ' MDI 子フォームの親をこのフォームに設定する
            cFormChild.MdiParent = Me
            cFormChild.WindowState = FormWindowState.Maximized
            cFormChild.pProcKind = CNL1530.PROC_KIND.RecommendationEdit

            ' MDI 子フォームを表示する
            cFormChild.Show()
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：品切れ登録読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2011.11.08 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_menu07_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu07.Click

        If ResetOpenWindow("CNL2080") Then
            ' MDI 子フォームの新しいインスタンスを生成する
            Dim cFormChild As New CNL2080

            ' MDI 子フォームの親をこのフォームに設定する
            cFormChild.MdiParent = Me
            cFormChild.WindowState = FormWindowState.Maximized

            ' MDI 子フォームを表示する
            cFormChild.Show()
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：食べ飲み放題設定読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.02.01 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_menu08_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu08.Click

        If ResetOpenWindow("CNL2140") Then
            ' MDI 子フォームの新しいインスタンスを生成する
            Dim cFormChild As New CNL2140

            ' MDI 子フォームの親をこのフォームに設定する
            cFormChild.MdiParent = Me
            cFormChild.WindowState = FormWindowState.Maximized

            ' MDI 子フォームを表示する
            cFormChild.Show()
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：放題設定読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2013.01.12 クレスコ北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_menu09_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu09.Click

        If ResetOpenWindow("CNL2110") Then
            ' MDI 子フォームの新しいインスタンスを生成する
            Dim cFormChild As New CNL2110

            ' MDI 子フォームの親をこのフォームに設定する
            cFormChild.MdiParent = Me
            cFormChild.WindowState = FormWindowState.Maximized

            ' MDI 子フォームを表示する
            cFormChild.Show()
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：閉店処理読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2011.11.08 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_menu10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu10.Click

        If ResetOpenWindow("CNL2120") Then
            ' MDI 子フォームの新しいインスタンスを生成する
            Dim cFormChild As New CNL2120

            ' MDI 子フォームの親をこのフォームに設定する
            cFormChild.MdiParent = Me
            cFormChild.WindowState = FormWindowState.Maximized

            ' MDI 子フォームを表示する
            cFormChild.Show()
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：各種設定読み込み時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2011.11.08 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub btn_menu11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu11.Click

        If ResetOpenWindow("CNL2130") Then
            ' MDI 子フォームの新しいインスタンスを生成する
            Dim cFormChild As New CNL2130

            ' MDI 子フォームの親をこのフォームに設定する
            cFormChild.MdiParent = Me
            cFormChild.WindowState = FormWindowState.Maximized

            ' MDI 子フォームを表示する
            cFormChild.Show()
        End If

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：子フォームクローズ処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2011.11.08 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Function ResetOpenWindow(Optional ByVal Id As String = "", Optional ByVal ProcKind As String = "") As Boolean

        '------------------------------
        ' 初期値設定
        '------------------------------
        ResetOpenWindow = False

        If Not (Me.ActiveMdiChild Is Nothing) And Not L_judge Then
            If Not (Me.ActiveMdiChild.Name.Equals(Id)) Then

                ' MDI 子フォームを閉じる
                Me.ActiveMdiChild.Close()

                '------------------------------
                ' 返却値設定
                '------------------------------
                ResetOpenWindow = True

            ElseIf Me.ActiveMdiChild.Name.Equals("CNL1530") And Id.Equals("CNL1530") Then

                If Not (CStr(DirectCast(Me.ActiveMdiChild, CNL1501.CNL1530).pProcKind).Equals(ProcKind)) Then
                    ' MDI 子フォームを閉じる
                    Me.ActiveMdiChild.Close()

                    '------------------------------
                    ' 返却値設定
                    '------------------------------
                    ResetOpenWindow = True
                End If

            End If
        ElseIf L_judge Then 'ADD 2016.04.25 田代   商品出力先が設定されていないならば
            Exit Function
        Else
            '------------------------------
            ' 返却値設定
            '------------------------------
            ResetOpenWindow = True
        End If

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：メニュー - [終了]押下時処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2011.11.08 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click

        'START 2016.04.25 田代
        If L_judge Then ' 商品出力先が設定されていないならば
            Exit Sub
        End If
        'END 2016.04.25 田代

        ResetOpenWindow()

        Me.Close()

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：ボタン色設定処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.08.25 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub LS_SetButtonColor()

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim objRows As DataRow = Nothing

        '------------------------------
        ' システム管理マスタ取得
        '------------------------------
        If Not LF_GetTPM040(objRows) Then
            GoTo SYSTEM_ERROR
        End If

        If Trim$(objRows("CLMODE")) = GC_TRUE Then
            '------------------------------
            ' ボタン色設定(システム稼動時)
            '------------------------------
            btn_menu01.BackColor = Color.LightSkyBlue
            btn_menu10.BackColor = Color.Violet
        Else
            '------------------------------
            ' ボタン色設定(システム停止時)
            '------------------------------
            btn_menu01.BackColor = Color.Violet
            btn_menu10.BackColor = Color.LightSkyBlue
        End If

        Exit Sub

SYSTEM_ERROR:
        Call GS_ErrorTerm("LS_SetButtonColor")
    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：システム管理マスタ 取得処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Function LF_GetTPM040(ByRef pRows As DataRow) As Boolean

        '------------------------------
        ' 内部変数定義
        '------------------------------
        Dim strSQL As String
        Dim objData As New DataSet()

        '------------------------------
        ' 初期値設定
        '------------------------------
        LF_GetTPM040 = False

        '------------------------------
        ' システム管理マスタ取得
        '------------------------------
        strSQL = ""
        strSQL = strSQL & "SELECT CLMODE"
        strSQL = strSQL & "  FROM TPM040"

        If Not GF_GetData(strSQL, objData) Then
            Exit Function
        End If

        If objData.Tables("com").Rows.Count = 0 Then
            Exit Function
        End If

        If Not GF_GetRows(objData, 0, pRows) Then
            Exit Function
        End If

        '------------------------------
        ' 返却値設定
        '------------------------------
        LF_GetTPM040 = True

    End Function

    ' --------------------------------------------------------------------------------
    ' 　機　　能：画面クローズ処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2003.10.27 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Private Sub CNL2010_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        'START 2016.04.25 田代
        If L_judge Then ' 商品出力先が設定されていないならば
            e.Cancel = True
            Exit Sub
        End If
        'END 2016.04.25 田代

        ResetOpenWindow()

    End Sub
    ' --------------------------------------------------------------------------------
    ' 　機　　能：プレビュー処理
    ' 　機能概要：
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2018.06.01  新規作成
    ' --------------------------------------------------------------------------------

    Private Sub btn_preview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_preview.Click

        'IEを格納する変数（オブジェクト型）
        Dim ie As Object
        'IEを起動
        'ie = CreateObject("InternetExplorer.Application")
        ie = New SHDocVw.InternetExplorer

        ie.Visible = True

        If GF_GetAppInfo2("MULTI_LING_USE") = 0 Then
            ie.Navigate2("http://192.168.194.201/CNWP001/CNWP010.aspx")
        Else
            ie.Navigate2("http://192.168.194.201/CNWP002/CNWP010.aspx")
        End If

        ie.AddressBar = False

        With ie
            .Top = -0          '上位置
            .Left = 0       '左位置
            '.Height = 783     '高さ★Win2012富士通サイズ
            '.Width = 1044    '幅★Win2012富士通サイズ
            .Height = 805     '高さ★Win2016ITTSサイズ
            .Width = 1040    '幅★Win2016ITTSサイズ
            .Resizable = True   'サイズ変更可否

        End With

        'Process.Start("http://192.168.194.201/CNWP002/CNWP010.aspx")
        'Process.Start("C:\inetpub\wwwroot\Preview")

    End Sub
End Class
