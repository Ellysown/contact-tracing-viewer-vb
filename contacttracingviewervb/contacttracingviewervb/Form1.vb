Public Class Form1
    Private Sub Title_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub viewbtn_Click(sender As Object, e As EventArgs) Handles viewbtn.Click
        Dim Reader As System.IO.StreamReader
        Dim insertname As String
        insertname = namebox1.Text + ".txt"

        If System.IO.File.Exists("D:\School chuchu\ELECS 3\" + insertname) Then
            Reader = My.Computer.FileSystem.OpenTextFileReader("D:\School chuchu\ELECS 3\" + insertname)
            richtxtbx1.Text = Reader.ReadToEnd
        Else
            MessageBox.Show("File Does Not Exist!")
        End If

    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        MessageBox.Show("Thank you for your service!")
        Close()

    End Sub
End Class
