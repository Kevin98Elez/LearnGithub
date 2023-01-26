Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Double = TextBox1.Text
        Dim kwadraat_i = i ^ 2
        MsgBox(kwadraat_i & " dit is het kwadraat van " & i)
    End Sub

End Class
