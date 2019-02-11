Public Class MainMenu


    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        MainGame.Show()
    End Sub

    Private Sub btnRe_Click(sender As Object, e As EventArgs) Handles btnRe.Click
        'Showdata()'
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        MainGame.Show()
    End Sub
End Class
