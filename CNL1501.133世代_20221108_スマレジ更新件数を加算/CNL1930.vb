' --------------------------------------------------------------------------------
' �@�@�@�@�\�F�X�ܓ����V�X�e�� - �N���C�A���g�����e�c�[���^�N���X��`
' �@�@�\�T�v�F�ȗ�
' �@���@�@���F�Ȃ�
' �@�� �� �l�F�Ȃ�
' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------

' --------------------------------------------------------------------------------
' �@�@�@�@�\�F�t�H���_�Q�ƃ_�C�A���O�\���N���X
' �@�@�\�T�v�F
' �@���@�@���F
'�@�@�@�@�@ �F
' �@�� �� �l�F
' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------
Public Class BrowseFolder
    Inherits System.Windows.Forms.Design.FolderNameEditor
    Dim fb As New System.Windows.Forms.Design.FolderNameEditor.FolderBrowser()
    Public Function BrowseDialog(ByVal description As String, _
            ByVal owner As Form) As String

        fb.Description = description                                        ' �������w��
        ' �����\���t�H���_���w��
        fb.StartLocation = _
            System.Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder.Desktop

        '�X�^�C�����w��
        fb.Style = _
            System.Windows.Forms.Design.FolderNameEditor.FolderBrowserStyles.RestrictToDomain

        If fb.ShowDialog(owner) = DialogResult.OK Then
            Return fb.DirectoryPath
        Else
            Return String.Empty
        End If

    End Function
End Class

' --------------------------------------------------------------------------------
' �@�@�@�@�\�F�f�[�^�O���b�h�E�摜�\���J������`�N���X
' �@�@�\�T�v�F
' �@���@�@���F
'�@�@�@�@�@ �F
' �@�� �� �l�F
' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------
Public Class DataGridImageTextBoxColumn
    Inherits DataGridTextBoxColumn

    Private _images As New Hashtable()
    Protected Overloads Overrides Sub Paint( _
            ByVal g As Graphics, _
            ByVal bounds As Rectangle, _
            ByVal source As CurrencyManager, _
            ByVal rowNum As Integer, _
            ByVal backBrush As Brush, _
            ByVal foreBrush As Brush, _
            ByVal alignToRight As Boolean _
            )
        Dim cellValue As Object = Me.GetColumnValueAtRow(source, rowNum)
        Dim fileName As String
        Dim objBitmap As Bitmap
        Dim objFileSys As System.IO.FileStream

        If (Not cellValue Is Nothing) Then
            fileName = CType(cellValue, String)                             ' �\������t�@�C�����̎擾
            If Len(Trim$(fileName)) = 0 Then                                ' �`��摜�t�@�C�������擾�ł��Ȃ������ꍇ
                fileName = ""
            End If

            Try
                If Not _images.Contains(fileName) Then
                    Try
                        objFileSys = New System.IO.FileStream(fileName, IO.FileMode.Open, IO.FileAccess.Read)
                        objBitmap = System.Drawing.Image.FromStream(objFileSys)
                        _images.Add(fileName, objBitmap.GetThumbnailImage(100, 100, Nothing, IntPtr.Zero))
                        objBitmap.Dispose()
                        objFileSys.Close()
                    Catch
                        _images.Add(fileName, Nothing)
                    End Try
                End If
                g.DrawImage(_images(fileName), bounds)
            Catch ex As Exception
                MyBase.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight)
            End Try
        End If
    End Sub

End Class

' --------------------------------------------------------------------------------
' �@�@�@�@�\�F�f�[�^�O���b�h�E�摜�\���J������`�N���X�i�ҏW����֎~�Łj
' �@�@�\�T�v�F
' �@���@�@���F
'�@�@�@�@�@ �F
' �@�� �� �l�F
' �@���@�@���F2003.08.25 �\�����k�� �V�K�쐬
' --------------------------------------------------------------------------------
Public Class DataGridImageTextBoxColumnNoEdit
    Inherits DataGridTextBoxColumn

    Private _images As New Hashtable()
    Protected Overloads Overrides Sub Paint( _
            ByVal g As Graphics, _
            ByVal bounds As Rectangle, _
            ByVal source As CurrencyManager, _
            ByVal rowNum As Integer, _
            ByVal backBrush As Brush, _
            ByVal foreBrush As Brush, _
            ByVal alignToRight As Boolean _
            )
        Dim cellValue As Object = Me.GetColumnValueAtRow(source, rowNum)
        Dim fileName As String
        Dim objBitmap As Bitmap
        Dim objFileSys As System.IO.FileStream

        If (Not cellValue Is Nothing) Then
            fileName = CType(cellValue, String)                             ' �\������t�@�C�����̎擾
            If Len(Trim$(fileName)) = 0 Then                                ' �`��摜�t�@�C�������擾�ł��Ȃ������ꍇ
                fileName = ""
            End If

            'Try
            '    If Not _images.Contains(fileName) Then
            '        Try
            '            objFileSys = New System.IO.FileStream(fileName, IO.FileMode.Open, IO.FileAccess.Read)
            '            objBitmap = System.Drawing.Image.FromStream(objFileSys)
            '            _images.Add(fileName, objBitmap.GetThumbnailImage(100, 100, Nothing, IntPtr.Zero))
            '            objBitmap.Dispose()
            '            objFileSys.Close()
            '        Catch
            '            _images.Add(fileName, Nothing)
            '        End Try
            '    End If
            '    g.DrawImage(_images(fileName), bounds)
            'Catch ex As Exception
            '    MyBase.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight)
            'End Try

            '�摜�t�@�C�����ǂݍ��܂�Ă��Ȃ��������ǂݍ���
            If Not (_images.Contains(fileName)) AndAlso (Len(Trim$(fileName)) <> 0) Then
                '�摜��ǂݍ���
                Try
                    objFileSys = New System.IO.FileStream(fileName, IO.FileMode.Open, IO.FileAccess.Read)
                    objBitmap = System.Drawing.Image.FromStream(objFileSys)
                    _images.Add(fileName, objBitmap.GetThumbnailImage(100, 100, Nothing, IntPtr.Zero))
                    objBitmap.Dispose()
                    objFileSys.Close()
                Catch
                    _images.Add(fileName, Nothing)
                End Try
            End If

            '�摜��ǂݍ��߂Ȃ�������
            Dim bmp As Bitmap = CType(_images(fileName), Bitmap)
            If Not (bmp Is Nothing) Then
                'bounds�̑傫���ŉ摜��\������
                '�i�Z���̑傫���ɍ��킹�ĉ摜���\�������j
                g.DrawImage(_images(fileName), bounds)
                'g.DrawImage(bmp, bounds)
            Else
                '�摜��ǂݍ��߂Ȃ������Ƃ��͕��ʂɕ\��
                MyBase.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight)
            End If
        End If
    End Sub

    Protected Overloads Overrides Sub Edit( _
        ByVal source As CurrencyManager, _
        ByVal rowNum As Integer, _
        ByVal bounds As Rectangle, _
        ByVal [readOnly] As Boolean, _
        ByVal instantText As String, _
        ByVal cellIsVisible As Boolean)
    End Sub
End Class

