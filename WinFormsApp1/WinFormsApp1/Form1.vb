Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Double = InputBox("geef een waarde")
        Dim j As Integer = InputBox("geef een 2e waarde")
        Dim som
        som = j + i

        Label1.Text = i
        TextBox1.Text = i

        MsgBox(som & " " & som)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim myform As New Form2
        myform.Show()
        Me.Close()
    End Sub
End Class
