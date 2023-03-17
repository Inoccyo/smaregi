Partial Class CNWG070
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------------------
        ' セッション状態確認
        '------------------------------
        If IsNothing(Session("TP")) Then
            L_Func = New TP2920()
            If Not L_Func.GF_Initialize() Then
                Response.Redirect("./TP2990.html?CNWG070(Page_Load-1)")
                Exit Sub
            End If
            Session("TP") = L_Func
        Else
            L_Func = Session("TP")
        End If

        L_BtnBack = False

        '------------------------------
        ' ポストバック時は処理対象外
        '------------------------------
        If IsPostBack Then
            Exit Sub
        End If

        btn_back.Attributes.Add("ONCLICK", "parent.fWinClose();")
        btn_Set.Attributes.Add("ONCLICK", "parent.fWinClose();")

    End Sub

    Private Sub btn_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Set.Click

        L_BtnBack = True

    End Sub

    '' **************************************************
    ''  機能概要：[0]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_0.Click
        Dim strNumber As String '' 人数テキストボックスの値

        strNumber = Trim$(txt_number.Text)

        '' ------------------------------
        '' ２桁までしか入力できません
        '' ------------------------------
        If Len(strNumber) > 1 Then
            Exit Sub
        End If

        If IsNumeric(strNumber) Then
            txt_number.Text = CStr(CLng(strNumber & "0"))
        Else
            txt_number.Text = "0"
        End If
    End Sub

    '' **************************************************
    ''  機能概要：[1]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_1.Click
        Dim strNumber As String '' 人数テキストボックスの値

        strNumber = Trim$(txt_number.Text)

        '' ------------------------------
        '' ２桁までしか入力できません
        '' ------------------------------
        If Len(strNumber) > 1 Then
            Exit Sub
        End If

        If IsNumeric(strNumber) Then
            txt_number.Text = CStr(CLng(strNumber & "1"))
        Else
            txt_number.Text = "1"
        End If
    End Sub

    '' **************************************************
    ''  機能概要：[2]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_2.Click
        Dim strNumber As String '' 人数テキストボックスの値

        strNumber = Trim$(txt_number.Text)

        '' ------------------------------
        '' ２桁までしか入力できません
        '' ------------------------------
        If Len(strNumber) > 1 Then
            Exit Sub
        End If

        If IsNumeric(strNumber) Then
            txt_number.Text = CStr(CLng(strNumber & "2"))
        Else
            txt_number.Text = "2"
        End If
    End Sub

    '' **************************************************
    ''  機能概要：[3]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_3.Click
        Dim strNumber As String '' 人数テキストボックスの値

        strNumber = Trim$(txt_number.Text)

        '' ------------------------------
        '' ２桁までしか入力できません
        '' ------------------------------
        If Len(strNumber) > 1 Then
            Exit Sub
        End If

        If IsNumeric(strNumber) Then
            txt_number.Text = CStr(CLng(strNumber & "3"))
        Else
            txt_number.Text = "3"
        End If
    End Sub

    '' **************************************************
    ''  機能概要：[4]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_4.Click
        Dim strNumber As String '' 人数テキストボックスの値

        strNumber = Trim$(txt_number.Text)

        '' ------------------------------
        '' ２桁までしか入力できません
        '' ------------------------------
        If Len(strNumber) > 1 Then
            Exit Sub
        End If

        If IsNumeric(strNumber) Then
            txt_number.Text = CStr(CLng(strNumber & "4"))
        Else
            txt_number.Text = "4"
        End If
    End Sub

    '' **************************************************
    ''  機能概要：[5]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_5.Click
        Dim strNumber As String '' 人数テキストボックスの値

        strNumber = Trim$(txt_number.Text)

        '' ------------------------------
        '' ２桁までしか入力できません
        '' ------------------------------
        If Len(strNumber) > 1 Then
            Exit Sub
        End If

        If IsNumeric(strNumber) Then
            txt_number.Text = CStr(CLng(strNumber & "5"))
        Else
            txt_number.Text = "5"
        End If
    End Sub

    '' **************************************************
    ''  機能概要：[6]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_6.Click
        Dim strNumber As String '' 人数テキストボックスの値

        strNumber = Trim$(txt_number.Text)

        '' ------------------------------
        '' ２桁までしか入力できません
        '' ------------------------------
        If Len(strNumber) > 1 Then
            Exit Sub
        End If

        If IsNumeric(strNumber) Then
            txt_number.Text = CStr(CLng(strNumber & "6"))
        Else
            txt_number.Text = "6"
        End If
    End Sub

    '' **************************************************
    ''  機能概要：[7]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_7.Click
        Dim strNumber As String '' 人数テキストボックスの値

        strNumber = Trim$(txt_number.Text)

        '' ------------------------------
        '' ２桁までしか入力できません
        '' ------------------------------
        If Len(strNumber) > 1 Then
            Exit Sub
        End If

        If IsNumeric(strNumber) Then
            txt_number.Text = CStr(CLng(strNumber & "7"))
        Else
            txt_number.Text = "7"
        End If
    End Sub

    '' **************************************************
    ''  機能概要：[8]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_8.Click
        Dim strNumber As String '' 人数テキストボックスの値

        strNumber = Trim$(txt_number.Text)

        '' ------------------------------
        '' ２桁までしか入力できません
        '' ------------------------------
        If Len(strNumber) > 1 Then
            Exit Sub
        End If

        If IsNumeric(strNumber) Then
            txt_number.Text = CStr(CLng(strNumber & "8"))
        Else
            txt_number.Text = "8"
        End If
    End Sub

    '' **************************************************
    ''  機能概要：[9]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_9.Click
        Dim strNumber As String '' 人数テキストボックスの値

        strNumber = Trim$(txt_number.Text)

        '' ------------------------------
        '' ２桁までしか入力できません
        '' ------------------------------
        If Len(strNumber) > 1 Then
            Exit Sub
        End If

        If IsNumeric(strNumber) Then
            txt_number.Text = CStr(CLng(strNumber & "9"))
        Else
            txt_number.Text = "9"
        End If
    End Sub

    '' **************************************************
    ''  機能概要：[C/AC]ボタン押下イベント
    ''  引    数：sender    (I)
    ''            e (I)
    ''  戻 り 値：
    '' **************************************************
    Private Sub btn_cls_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cls.Click
        txt_number.Text = ""
    End Sub

    '' **************************************************
    ''  機能概要：<body>にonLoadイベントを出力する。
    ''  引    数：
    ''  戻 り 値：
    '' **************************************************
    Public Sub OnInitBody()
        If L_BtnBack Then
            If Len(Request.QueryString("SMenu")) <> 0 And Len(txt_number.Text) <> 0 Then
                Response.Write("onLoad='parent.Form1.txt_number" & Request.QueryString("SMenu") & ".value = " & txt_number.Text & ";'")
            End If
        End If
    End Sub

End Class
