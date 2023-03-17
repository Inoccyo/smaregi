Public Class OutLog

    Private _OutLogPath As String
    Public Property OutLogPath() As String
        Get
            Return _OutLogPath
        End Get
        Set(ByVal value As String)
            _OutLogPath = value
        End Set
    End Property


    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(ByVal outLogPath As String)

        Me._OutLogPath = outLogPath

    End Sub

    ' --------------------------------------------------------------------------------
    ' 　機　　能：【共通】ログファイル出力
    ' 　機能概要：ログファイル出力
    ' 　引　　数：
    ' 　戻 り 値：
    ' 　履　　歴：2006.12.01 ソラン北陸 新規作成
    ' --------------------------------------------------------------------------------
    Public Sub OutLog(ByVal Msg As String)

        Try
            If System.Configuration.ConfigurationManager.AppSettings("OutLogKbn").ToString() = "1" Then

                Dim writer As System.IO.StreamWriter
                writer = New System.IO.StreamWriter(_OutLogPath, True)
                writer.WriteLine(Now & "　MESSAGE = " & Msg)
                writer.Close()

            End If

            'この関数のみ、エラーは無視する
        Catch

            Exit Sub

        End Try

    End Sub


End Class
