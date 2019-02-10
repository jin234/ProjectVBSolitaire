Public Class Form1

    Dim stage As Gamestage = New Gamestage

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        stage.Generate_Game()
        For Each i In stage.Deck
            MessageBox.Show(i)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
