Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        MainGame.Show()
        Dim CloseMENU As New Menu
        CloseMENU.Owner = Me
        Me.Hide()
    End Sub

    'Private Sub Close_Owner(ByVal e As System.Windows.Forms.FormClosingEventArgs)
    '    e.Cancel = False
    '    Me.Owner.Close()
    'End Sub

End Class
