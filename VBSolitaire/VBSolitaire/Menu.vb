Public Class MainMenu
    Dim Resetvalue As Integer = 0
    Dim Score As Gamestage = New Gamestage

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        MainGame.Show()
        Resetvalue = 1
    End Sub

    Public Property resetTime() As Integer
        Get
            If Resetvalue = 1 Then
                Return resetTime = 1
            ElseIf Resetvalue = 0 Then
                Return resetTime = 0
            End If
        End Get
        Set(ByVal value As Integer)
            resetTime = value
        End Set
    End Property

    Private Sub btnRe_Click(sender As Object, e As EventArgs) Handles btnRe.Click
        'DataGridView1.DataSource = Score.ShowData()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        MainGame.Show()
        Resetvalue = 0
    End Sub
End Class
