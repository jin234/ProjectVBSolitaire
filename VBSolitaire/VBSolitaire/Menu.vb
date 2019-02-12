Public Class MainMenu

    Dim Data As MainGame = New MainGame

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        Data.DeleteStep()
        MainGame.Show()
    End Sub

    Private Sub btnRe_Click(sender As Object, e As EventArgs) Handles btnRe.Click
        DataGridView1.DataSource = Data.ShowData()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        MainGame.Show()
    End Sub
End Class
