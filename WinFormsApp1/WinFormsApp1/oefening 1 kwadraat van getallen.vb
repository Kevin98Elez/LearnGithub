Public Class oefening_1_kwadraat_van_getallen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = InputBox("geef een waarde")
        Dim j As Integer = InputBox("geef een waarde")
        Dim kwadraat_1 = i ^ 2
        Dim kwadraat_2 = j ^ 2

        MsgBox(kwadraat_1 & " dit is het kwadraat van " & i)
        MsgBox(kwadraat_2 & " dit is het kwadraat van " & j)

    End Sub
End Class