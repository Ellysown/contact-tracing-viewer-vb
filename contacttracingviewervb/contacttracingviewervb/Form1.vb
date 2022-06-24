Public Class Form1
    Private Sub Title_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub viewbtn_Click(sender As Object, e As EventArgs) Handles viewbtn.Click
        Dim Reader As System.IO.StreamReader

        Dim insertname As String
        insertname = namebox1.Text + ".txt"
        Reader = My.Computer.FileSystem.OpenTextFileReader("D:\School chuchu\ELECS 3\" + insertname)
        richtxtbx1.Text = Reader.ReadToEnd
    End Sub
End Class
