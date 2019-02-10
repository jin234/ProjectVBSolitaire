Public Class MainGame

    Dim Stage As Gamestage = New Gamestage

    Dim Condition_cardselected As Boolean
    Dim selected_card1 As String
    Dim selected_card2 As String

    Private Sub MainGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Stage.Generate_Game()
        MessageBox.Show("init")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainMenu.Show()
    End Sub

    Private Sub Show_deck_Click(sender As Object, e As EventArgs) Handles Show_deck.Click

        Dim deck As String = ""
        For Each i In Stage.Deck
            deck += i + " "
        Next

        Dim deck_open As String = ""
        For Each i In Stage.Deck_Open
            deck_open += i + " "
        Next

        Dim Row1 As String = ""
        For Each i In Stage.Row1
            Row1 += i + " "
        Next

        Dim Row2 As String = ""
        For Each i In Stage.Row2
            Row2 += i + " "
        Next

        Dim Row3 As String = ""
        For Each i In Stage.Row3
            Row3 += i + " "
        Next

        Dim Row4 As String = ""
        For Each i In Stage.Row4
            Row4 += i + " "
        Next

        Dim Row5 As String = ""
        For Each i In Stage.Row5
            Row5 += i + " "
        Next

        Dim Row6 As String = ""
        For Each i In Stage.Row6
            Row6 += i + " "
        Next

        Dim Row7 As String = ""
        For Each i In Stage.Row7
            Row7 += i + " "
        Next

        MessageBox.Show(deck + vbNewLine + deck_open + vbNewLine + Row1 + vbNewLine + Row2 + vbNewLine + Row3 + vbNewLine + Row4 + vbNewLine + Row5 + vbNewLine + Row6 + vbNewLine + Row7)

    End Sub

    Private Sub display()
        MessageBox.Show("Updata Visual")
    End Sub




    Private Sub card_selected(card As String)
        If Condition_cardselected = False Then
            Condition_cardselected = True
            selected_card1 = card
            Hilight_card(card, True)
        Else
            If selected_card1 = card Then
                Condition_cardselected = False
                selected_card1 = ""
                Hilight_card(card, False)
            Else
                Move_card()
            End If
        End If
    End Sub

    Private Sub Move_card()

        MessageBox.Show("Move " + selected_card1 + " to " + selected_card2)
        Hilight_card(selected_card1, False)
    End Sub

    Private Sub Hilight_card(card As String, condition As Boolean)
        If condition Then
            MessageBox.Show("hilight " + card)
        Else
            MessageBox.Show("UN-hilight " + card)
        End If
        display()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Dim card As String = "R1_1"

        card_selected(card)

    End Sub



    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click

        Dim card As String = "R2_1"

        card_selected(card)

    End Sub

    Private Sub PictureBox39_Click(sender As Object, e As EventArgs) Handles PictureBox39.Click

        Dim card As String = "R2_2"

        card_selected(card)

    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles PictureBox38.Click

        Dim card As String = "R2_3"

        card_selected(card)

    End Sub

End Class