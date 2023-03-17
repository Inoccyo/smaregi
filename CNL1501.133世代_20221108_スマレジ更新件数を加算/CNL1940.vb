Imports System.Data.SqlServerCe
Imports System.Data.Odbc
Imports System.Data

Public Class DataAccess

    Public m_SqlConn As SqlServerCe.SqlCeConnection

    Public Sub CleateSqlConnection(ByVal dataConnectionString As String)

        Me.m_SqlConn = New SqlCeConnection(dataConnectionString)
        Me.m_SqlConn.Open()

    End Sub

    Public Sub CloseConnection()

        If Me.m_SqlConn IsNot Nothing AndAlso Me.m_SqlConn.State = ConnectionState.Open Then
            Me.m_SqlConn.Close()
        End If

    End Sub

    Public Function GetDataSql(ByVal sql As String) As Boolean '2019.08.29

        Dim sqlCom As New SqlCeCommand(sql, m_SqlConn)
        Dim sdr As SqlCeDataReader = Nothing

        '------------------------------
        ' 初期値設定
        '------------------------------
        GetDataSql = False

        Try
            sdr = sqlCom.ExecuteReader()

            While (sdr.Read())

                GetDataSql = True

            End While

        Catch ex As Exception
            Me.CloseConnection()
            Throw

        Finally
            sdr.Dispose()
            sdr.Close()

        End Try

    End Function

    Public Function UpdDataSql(ByVal sql As String, ByRef tran As SqlCeTransaction) As Boolean

        Dim sqlCom As New SqlCeCommand(sql, m_SqlConn)

        '------------------------------
        ' 初期値設定
        '------------------------------
        UpdDataSql = False

        sqlCom.Transaction = tran

        Try
            sqlCom.ExecuteNonQuery()

        Catch ex As Exception
            tran.Rollback()
            Me.CloseConnection()
            Throw

        Finally
            sqlCom.Dispose()

        End Try

        '------------------------------
        ' 返却値設定
        '------------------------------
        UpdDataSql = True

    End Function

End Class