Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        AxScriptControl1.AddObject("txtInput", TextBox1)
        AxScriptControl1.ExecuteStatement(TextBox1.Text)
        PictureBox1.BackColor = Color.White
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
