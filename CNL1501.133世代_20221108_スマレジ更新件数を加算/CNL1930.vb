' --------------------------------------------------------------------------------
' 　機　　能：店舗内情報システム - クライアントメンテツール／クラス定義
' 　機能概要：省略
' 　引　　数：なし
' 　戻 り 値：なし
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
' --------------------------------------------------------------------------------

' --------------------------------------------------------------------------------
' 　機　　能：フォルダ参照ダイアログ表示クラス
' 　機能概要：
' 　引　　数：
'　　　　　 ：
' 　戻 り 値：
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
' --------------------------------------------------------------------------------
Public Class BrowseFolder
    Inherits System.Windows.Forms.Design.FolderNameEditor
    Dim fb As New System.Windows.Forms.Design.FolderNameEditor.FolderBrowser()
    Public Function BrowseDialog(ByVal description As String, _
            ByVal owner As Form) As String

        fb.Description = description                                        ' 説明を指定
        ' 初期表示フォルダを指定
        fb.StartLocation = _
            System.Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder.Desktop

        'スタイルを指定
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
' 　機　　能：データグリッド・画像表示カラム定義クラス
' 　機能概要：
' 　引　　数：
'　　　　　 ：
' 　戻 り 値：
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
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
            fileName = CType(cellValue, String)                             ' 表示するファイル名の取得
            If Len(Trim$(fileName)) = 0 Then                                ' 描画画像ファイル名が取得できなかった場合
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
' 　機　　能：データグリッド・画像表示カラム定義クラス（編集操作禁止版）
' 　機能概要：
' 　引　　数：
'　　　　　 ：
' 　戻 り 値：
' 　履　　歴：2003.08.25 ソラン北陸 新規作成
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
            fileName = CType(cellValue, String)                             ' 表示するファイル名の取得
            If Len(Trim$(fileName)) = 0 Then                                ' 描画画像ファイル名が取得できなかった場合
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

            '画像ファイルが読み込まれていない時だけ読み込む
            If Not (_images.Contains(fileName)) AndAlso (Len(Trim$(fileName)) <> 0) Then
                '画像を読み込む
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

            '画像を読み込めなかった時
            Dim bmp As Bitmap = CType(_images(fileName), Bitmap)
            If Not (bmp Is Nothing) Then
                'boundsの大きさで画像を表示する
                '（セルの大きさに合わせて画像が表示される）
                g.DrawImage(_images(fileName), bounds)
                'g.DrawImage(bmp, bounds)
            Else
                '画像を読み込めなかったときは普通に表示
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

