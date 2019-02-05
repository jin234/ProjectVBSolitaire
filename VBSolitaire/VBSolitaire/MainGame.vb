Public Class MainGame

    Dim Condition_cardselected As Boolean
    Dim selectedcard() As String
    Dim Stage As Gamestage = New Gamestage

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter
        cards.Random()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainMenu.Show()
    End Sub

    Private Sub display()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Condition_cardselected = False Then

            selectedcard = Stage.Row1
        End If
    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click

    End Sub


End Class