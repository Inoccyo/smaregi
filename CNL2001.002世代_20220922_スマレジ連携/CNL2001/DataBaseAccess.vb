Public Class DataBaseAccess

    '-------------------------------------------------------------------------------
    ' �N���X���ϐ���`
    '-------------------------------------------------------------------------------
    Private L_objConnect As SqlClient.SqlConnection  '�f�[�^�x�[�X�R�l�N�V����
    Private L_objTrans As SqlClient.SqlTransaction   '�f�[�^�x�[�X�g�����U�N�V����

    '-------------------------------------------------------------------------------
    ' �N���X���萔��`
    '-------------------------------------------------------------------------------

    '-------------------------------------------------------------------------------
    ' �O���ϐ���`
    '-------------------------------------------------------------------------------

    '-------------------------------------------------------------------------------
    ' �O���萔��`
    '-------------------------------------------------------------------------------

    '-------------------------------------------------------------------------------
    ' �\���̒�`
    '-------------------------------------------------------------------------------

    '-------------------------------------------------------------------------------
    ' �񋓑̒�`
    '-------------------------------------------------------------------------------

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�y���ʁz��������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Public Function SqlInitialize(ByVal connectionString As String, _
                                  Optional ByRef Msg As String = "") As Boolean

        If Not SqlDBConnect(connectionString, Msg) Then
            Return False
        End If

        Return True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�y���ʁz�c�a�ڑ�����
    ' �@�@�\�T�v�F�c�a�ڑ��������s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Public Function SqlDBConnect(ByVal connectionString As String, _
                                 Optional ByRef Msg As String = "") As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim ex As Exception
        '------------------------------
        ' �����l�ݒ�
        '------------------------------

        '------------------------------
        ' �c�a�T�[�o�ڑ�
        '------------------------------
        Try
            If L_objConnect IsNot Nothing AndAlso _
               L_objConnect.State = ConnectionState.Open Then
                '�ڑ��ς݂̏ꍇ�͍Đڑ����Ȃ�
                Return True
            End If

            L_objConnect = New SqlClient.SqlConnection()
            L_objConnect.ConnectionString = connectionString
            L_objConnect.Open()

        Catch ex
            Msg = ex.Message
            Return False
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        Return True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�y���ʁz�I������
    ' �@�@�\�T�v�F
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Public Function SqlFinalize(Optional ByRef Msg As String = "") As Boolean

        If Not SqlDBDisConnect(Msg) Then
            Return False
        End If

        Return True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�y���ʁz�c�a�ؒf����
    ' �@�@�\�T�v�F�c�a�ؒf�������s��
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Public Function SqlDBDisConnect(Optional ByRef Msg As String = "") As Boolean

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        Dim ex As Exception

        '------------------------------
        ' �c�a�T�[�o�ڑ�
        '------------------------------
        ' �ڑ�������̎擾
        Try

            '�f�[�^�x�[�X��ؒf
            L_objConnect.Close()
            L_objConnect.Dispose()

        Catch ex
            Msg = ex.Message
            Return False
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        Return True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�y���ʁz�c�a�ǂݍ��ݏ���(�f�[�^�Z�b�g����)
    ' �@�@�\�T�v�F���͈������A�f�[�^�e�[�u���𐶐����܂��B�܂��A���֐��̏o�͈�����
    ' �@�@�@�@�@�@sqlGetRows()�֐����g�p���邱�ƂŎQ�Ƃ��邱�Ƃ��ł��܂��B
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Public Function SqlGetData(ByVal pstrSQL As String, ByRef pobjData As DataTable, Optional ByRef Msg As String = "") As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim objAdapter As SqlClient.SqlDataAdapter
        Dim ex As Exception

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        pobjData = New DataTable

        '------------------------------
        ' �c�a���o����
        '------------------------------
        Try
            objAdapter = New SqlClient.SqlDataAdapter(pstrSQL, L_objConnect)
            objAdapter.SelectCommand.CommandTimeout = 3600
            objAdapter.Fill(pobjData)
        Catch ex
            Msg = ex.Message
            Return False
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        Return True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�y���ʁz�s�f�[�^�ԋp
    ' �@�@�\�T�v�F���͈����Ƃ��ė^������ DataSet �I�u�W�F�N�g���A�w��s�� DataRow
    ' �@�@�@�@�@�@�I�u�W�F�N�g�𐶐����A�ԋp���܂��B
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Public Function SqlGetRows(ByVal pobjData As DataSet, ByVal pRow As Long, ByRef pobjRows As DataRow, Optional ByRef Msg As String = "") As Boolean

        'Dim intCnt As Integer

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        SqlGetRows = False
        Dim ex As Exception

        '------------------------------
        ' �c�a���o����
        '------------------------------
        Try

            pobjRows = pobjData.Tables("com").Rows(pRow)

        Catch ex
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        SqlGetRows = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�g�����U�N�V�����J�n����
    ' �@�@�\�T�v�F�g�����U�N�V�����̊J�n��錾����
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F[True] ���� / [False] ���s
    ' �@���@�@���F2017.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Public Function SqlBeginTrans(Optional ByRef Msg As String = "") As Boolean

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        SqlBeginTrans = False
        Dim ex As Exception

        '------------------------------
        ' �g�����U�N�V�����J�n
        '------------------------------
        Try

            L_objTrans = L_objConnect.BeginTransaction(IsolationLevel.ReadUncommitted)

        Catch ex
            Msg = ex.Message
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        SqlBeginTrans = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�g�����U�N�V�����m�萧��
    ' �@�@�\�T�v�F�g�����U�N�V�������m�肷��
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F[True] ���� / [False] ���s
    ' �@���@�@���F2017.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Public Function SqlCommitTrans(Optional ByRef Msg As String = "") As Boolean

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        SqlCommitTrans = False
        Dim ex As Exception

        '------------------------------
        ' �g�����U�N�V�����m��
        '------------------------------
        Try

            If L_objTrans IsNot Nothing Then
                L_objTrans.Commit()
                L_objTrans.Dispose()
                L_objTrans = Nothing
            End If

        Catch ex
            Msg = ex.Message
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        SqlCommitTrans = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�g�����U�N�V�����j������
    ' �@�@�\�T�v�F�g�����U�N�V������j������
    ' �@���@�@���F�Ȃ�
    ' �@�� �� �l�F[True] ���� / [False] ���s
    ' �@���@�@���F2017.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Public Function SqlRollbackTrans(Optional ByRef Msg As String = "") As Boolean

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        SqlRollbackTrans = False
        Dim ex As Exception

        '------------------------------
        ' �g�����U�N�V�����j��
        '------------------------------
        Try

            If L_objTrans IsNot Nothing Then
                L_objTrans.Rollback()
                L_objTrans.Dispose()
                L_objTrans = Nothing
            End If
        Catch ex
            Msg = ex.Message
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        SqlRollbackTrans = True

    End Function

    ' --------------------------------------------------------------------------------
    ' �@�@�@�@�\�F�y���ʁz�c�a�X�V����
    ' �@�@�\�T�v�F�c�a�X�V�������s���܂�
    ' �@���@�@���F
    ' �@�� �� �l�F
    ' �@���@�@���F2017.02.01 �N���X�R�k�� �V�K�쐬
    ' --------------------------------------------------------------------------------
    Public Function SqlUpdData(ByVal pstrSQL As String, Optional ByRef Msg As String = "") As Boolean

        '------------------------------
        ' �����ϐ���`
        '------------------------------
        Dim cmd As SqlClient.SqlCommand = L_objConnect.CreateCommand
        Dim ex As Exception

        '------------------------------
        ' �����l�ݒ�
        '------------------------------
        SqlUpdData = False

        '------------------------------
        ' �X�V����
        '------------------------------
        Try
            If L_objTrans Is Nothing Then
                Msg = "�g�����U�N�V���������݂��Ȃ����߁A�X�V�͍s���܂���ł����B"
                Exit Function
            End If

            cmd.CommandText = pstrSQL
            cmd.Transaction = L_objTrans
            cmd.CommandTimeout = 3600
            cmd.ExecuteNonQuery()

        Catch ex
            Msg = ex.Message & " SQL=" & pstrSQL
            Exit Function
        End Try

        '------------------------------
        ' �ԋp�l�ݒ�
        '------------------------------
        SqlUpdData = True

    End Function

    Public Function strQuot(ByVal pstrSTR) As String

        If Replace(pstrSTR, "'", "''") Is Nothing Then
            Return ""
        Else
            Return Replace(pstrSTR, "'", "''")
        End If

    End Function

End Class
