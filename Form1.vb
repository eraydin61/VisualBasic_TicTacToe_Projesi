Public Class NewGameForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TwoPlayerForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AboutBox1.Show()
    End Sub
End Class
