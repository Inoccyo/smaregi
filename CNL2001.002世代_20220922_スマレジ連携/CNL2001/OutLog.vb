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
    ''' �R���X�g���N�^
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(ByVal outLogPath As String)

        Me._OutLogPath = outLogPath

    End Sub

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�y���ʁz���O�t�@�C���o��
    ' �@�@�\�T�v�F���O�t�@�C���o��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2006.12.01 �\�����k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Public Sub OutLog(ByVal Msg As String)

        Try
            If System.Configuration.ConfigurationManager.AppSettings("OutLogKbn").ToString() = "1" Then

                Dim writer As System.IO.StreamWriter
                writer = New System.IO.StreamWriter(_OutLogPath, True)
                writer.WriteLine(Now & "�@MESSAGE = " & Msg)
                writer.Close()

            End If

            '���̊֐��̂݁A�G���[�͖�������
        Catch

            Exit Sub

        End Try

    End Sub


End Class
