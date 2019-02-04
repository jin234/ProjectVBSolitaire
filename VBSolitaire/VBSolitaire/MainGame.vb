Public Class MainGame
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim btnBacktoMain As New Menu
        btnBacktoMain.Show()
        Dim CloseGame As New Menu
        CloseGame.Owner = Me
        Me.Hide()
    End Sub

End Class