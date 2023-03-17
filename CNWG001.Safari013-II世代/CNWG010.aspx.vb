Partial Class CNWG010
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
    Private Const SessionMsgName As String = "CNWG001.Msg"   '各画面のメッセージセッション変数名と同一である必要があります

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' ページを初期化する ユーザー コードをここに挿入します。
        If Request.QueryString("RELOAD") = "1" Then
            Session(SessionMsgName) = ""
        End If
    End Sub
End Class
