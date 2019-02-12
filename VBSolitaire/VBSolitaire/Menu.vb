Public Class MainMenu

    Dim Score As Gamestage = New Gamestage

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        MainGame.Show()
    End Sub

    Private Sub btnRe_Click(sender As Object, e As EventArgs) Handles btnRe.Click
        'DataGridView1.DataSource = Score.ShowData()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        MainGame.Show()

    End Sub
End Class
