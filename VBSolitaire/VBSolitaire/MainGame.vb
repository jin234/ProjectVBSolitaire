Public Class MainGame

    Dim Stage As Gamestage = New Gamestage

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

        MessageBox.Show(deck + vbNewLine + "----" + deck_open + vbNewLine + "----" + Row1 + vbNewLine + "----" + Row2 + vbNewLine + "----" + Row3 + vbNewLine + "----" + Row4 + vbNewLine + "----" + Row5 + vbNewLine + "----" + Row6 + vbNewLine + "----" + Row7)

    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Dim card As String = "R1_1"

        select_card(card)

    End Sub



    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click

        Dim card As String = "R2_1"

        select_card(card)

    End Sub

    Private Sub PictureBox39_Click(sender As Object, e As EventArgs) Handles PictureBox39.Click

        Dim card As String = "R2_2"

        select_card(card)

    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles PictureBox38.Click

        Dim card As String = "R2_3"



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Stage.Open_deck()
        Display()
    End Sub

    Public Sub select_card(card As String)

        Stage.card_selected(card)
        Display()

    End Sub

    Public Sub Display()
        DisplayDeck()
        DisplayDeckopen()

        DisplayPerRow(1)
        DisplayPerRow(2)
        DisplayPerRow(3)
        DisplayPerRow(4)
        DisplayPerRow(5)
        DisplayPerRow(6)
        DisplayPerRow(7)

        DisplayFill("C")
        DisplayFill("S")
        DisplayFill("H")
        DisplayFill("D")
        Label2.Text = "Updata Visual"

    End Sub

    Public Sub DisplayDeck()
        If Stage.Deck.Count = 0 Then
            PictureBox1.Image = Nothing
        Else
            PictureBox1.Image = My.Resources.Back
        End If

    End Sub

    Public Sub DisplayDeckopen()

        If Stage.Deck_Open.Count <> 0 Then

            If Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "10C" Then
                PictureBox2.Image = My.Resources._10C
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "10CWL" Then
                PictureBox2.Image = My.Resources._10CwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "10D" Then
                PictureBox2.Image = My.Resources._10D
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "10DWL" Then
                PictureBox2.Image = My.Resources._10DwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "10H" Then
                PictureBox2.Image = My.Resources._10H
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "10HWL" Then
                PictureBox2.Image = My.Resources._10HwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "10S" Then
                PictureBox2.Image = My.Resources._10S
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "10sWL" Then
                PictureBox2.Image = My.Resources._10SwL

            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "2C" Then
                PictureBox2.Image = My.Resources._2C
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "2CWL" Then
                PictureBox2.Image = My.Resources._2CwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "2D" Then
                PictureBox2.Image = My.Resources._2D
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "2DWL" Then
                PictureBox2.Image = My.Resources._2DwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "2H" Then
                PictureBox2.Image = My.Resources._2H
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "2HWL" Then
                PictureBox2.Image = My.Resources._2HwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "2S" Then
                PictureBox2.Image = My.Resources._2S
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "2sWL" Then
                PictureBox2.Image = My.Resources._2SwL

            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "3C" Then
                PictureBox2.Image = My.Resources._3C
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "3CWL" Then
                PictureBox2.Image = My.Resources._3CwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "3D" Then
                PictureBox2.Image = My.Resources._3D
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "3DWL" Then
                PictureBox2.Image = My.Resources._3DwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "3H" Then
                PictureBox2.Image = My.Resources._3H
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "3HWL" Then
                PictureBox2.Image = My.Resources._3HwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "3S" Then
                PictureBox2.Image = My.Resources._3S
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "3sWL" Then
                PictureBox2.Image = My.Resources._3SwL

            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "4C" Then
                PictureBox2.Image = My.Resources._4C
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "4CWL" Then
                PictureBox2.Image = My.Resources._4CwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "4D" Then
                PictureBox2.Image = My.Resources._4D
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "4DWL" Then
                PictureBox2.Image = My.Resources._4DwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "4H" Then
                PictureBox2.Image = My.Resources._4H
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "4HWL" Then
                PictureBox2.Image = My.Resources._4HwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "4S" Then
                PictureBox2.Image = My.Resources._4S
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "4sWL" Then
                PictureBox2.Image = My.Resources._4SwL

            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "5C" Then
                PictureBox2.Image = My.Resources._5C
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "5CWL" Then
                PictureBox2.Image = My.Resources._5CwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "5D" Then
                PictureBox2.Image = My.Resources._5D
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "5DWL" Then
                PictureBox2.Image = My.Resources._5DwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "5H" Then
                PictureBox2.Image = My.Resources._5H
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "5HWL" Then
                PictureBox2.Image = My.Resources._5HwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "5S" Then
                PictureBox2.Image = My.Resources._5S
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "5sWL" Then
                PictureBox2.Image = My.Resources._5SwL

            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "6C" Then
                PictureBox2.Image = My.Resources._6C
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "6CWL" Then
                PictureBox2.Image = My.Resources._6CwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "6D" Then
                PictureBox2.Image = My.Resources._6D
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "6DWL" Then
                PictureBox2.Image = My.Resources._6DwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "6H" Then
                PictureBox2.Image = My.Resources._6H
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "6HWL" Then
                PictureBox2.Image = My.Resources._6HwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "6S" Then
                PictureBox2.Image = My.Resources._6S
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "6sWL" Then
                PictureBox2.Image = My.Resources._6SwL

            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "7C" Then
                PictureBox2.Image = My.Resources._7C
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "7CWL" Then
                PictureBox2.Image = My.Resources._7CwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "7D" Then
                PictureBox2.Image = My.Resources._7D
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "7DWL" Then
                PictureBox2.Image = My.Resources._7DwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "7H" Then
                PictureBox2.Image = My.Resources._7H
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "7HWL" Then
                PictureBox2.Image = My.Resources._7HwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "7S" Then
                PictureBox2.Image = My.Resources._7S
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "7sWL" Then
                PictureBox2.Image = My.Resources._7SwL

            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "8C" Then
                PictureBox2.Image = My.Resources._8C
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "8CWL" Then
                PictureBox2.Image = My.Resources._8CwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "8D" Then
                PictureBox2.Image = My.Resources._8D
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "8DWL" Then
                PictureBox2.Image = My.Resources._8DwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "8H" Then
                PictureBox2.Image = My.Resources._8H
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "8HWL" Then
                PictureBox2.Image = My.Resources._8HwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "8S" Then
                PictureBox2.Image = My.Resources._8S
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "8sWL" Then
                PictureBox2.Image = My.Resources._8SwL

            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "9C" Then
                PictureBox2.Image = My.Resources._9C
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "9CWL" Then
                PictureBox2.Image = My.Resources._9CwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "9D" Then
                PictureBox2.Image = My.Resources._9D
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "9DWL" Then
                PictureBox2.Image = My.Resources._9DwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "9H" Then
                PictureBox2.Image = My.Resources._9H
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "9HWL" Then
                PictureBox2.Image = My.Resources._9HwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "9S" Then
                PictureBox2.Image = My.Resources._9S
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "9sWL" Then
                PictureBox2.Image = My.Resources._9SwL

            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "AC" Then
                PictureBox2.Image = My.Resources.AC
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "ACWL" Then
                PictureBox2.Image = My.Resources.ACwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "AD" Then
                PictureBox2.Image = My.Resources.AD
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "ADWL" Then
                PictureBox2.Image = My.Resources.ADwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "AH" Then
                PictureBox2.Image = My.Resources.AH
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "AHWL" Then
                PictureBox2.Image = My.Resources.AHwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "AS" Then
                PictureBox2.Image = My.Resources._AS
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "AsWL" Then
                PictureBox2.Image = My.Resources.ASwL

            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "JC" Then
                PictureBox2.Image = My.Resources.JC
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "JCWL" Then
                PictureBox2.Image = My.Resources.JCwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "JD" Then
                PictureBox2.Image = My.Resources.JD
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "JDWL" Then
                PictureBox2.Image = My.Resources.JDwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "JH" Then
                PictureBox2.Image = My.Resources.JH
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "JHWL" Then
                PictureBox2.Image = My.Resources.JHwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "JS" Then
                PictureBox2.Image = My.Resources.JS
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "JsWL" Then
                PictureBox2.Image = My.Resources.JSwL

            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "KC" Then
                PictureBox2.Image = My.Resources.KC
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "KCWL" Then
                PictureBox2.Image = My.Resources.KCwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "KD" Then
                PictureBox2.Image = My.Resources.KD
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "KDWL" Then
                PictureBox2.Image = My.Resources.KDwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "KH" Then
                PictureBox2.Image = My.Resources.KH
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "KHWL" Then
                PictureBox2.Image = My.Resources.KHwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "KS" Then
                PictureBox2.Image = My.Resources.KS
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "KsWL" Then
                PictureBox2.Image = My.Resources.KSwL

            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "QC" Then
                PictureBox2.Image = My.Resources.QC
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "QCWL" Then
                PictureBox2.Image = My.Resources.QCwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "QD" Then
                PictureBox2.Image = My.Resources.QD
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "QDWL" Then
                PictureBox2.Image = My.Resources.QDwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "QH" Then
                PictureBox2.Image = My.Resources.QH
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "QHWL" Then
                PictureBox2.Image = My.Resources.QHwL
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "QS" Then
                PictureBox2.Image = My.Resources.QS
            ElseIf Stage.Deck_Open(Stage.Deck_Open.Count - 1) = "QsWL" Then
                PictureBox2.Image = My.Resources.QSwL

            End If
        Else
            PictureBox2.Image = Nothing
        End If
    End Sub

    Public Sub DisplayPerRow(Row As Integer)
        If Row = 1 Then
            If Stage.Row1.Count <> 0 Then
                Dim count As Integer = 1
                If count < Stage.Row1.Count Then
                    pb3(Stage.Row1(0))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb4(Stage.Row1(1))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb5(Stage.Row1(2))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb6(Stage.Row1(3))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb7(Stage.Row1(4))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb8(Stage.Row1(5))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb9(Stage.Row1(6))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb10(Stage.Row1(7))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb11(Stage.Row1(8))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb12(Stage.Row1(9))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb13(Stage.Row1(10))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb14(Stage.Row1(11))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb15(Stage.Row1(12))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb16(Stage.Row1(13))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb17(Stage.Row1(14))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb18(Stage.Row1(15))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb19(Stage.Row1(16))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb20(Stage.Row1(17))
                    count += 1
                End If
                If count < Stage.Row1.Count Then
                    pb21(Stage.Row1(18))
                    count += 1
                End If

            End If

        ElseIf Row = 2 Then

        ElseIf Row = 3 Then

        ElseIf Row = 4 Then

        ElseIf Row = 5 Then

        ElseIf Row = 6 Then

        ElseIf Row = 7 Then

        End If
    End Sub

    Public Sub DisplayFill(Row As String)
        If Row = "C" Then

        ElseIf Row = "S" Then

        ElseIf Row = "H" Then

        ElseIf Row = "D" Then

        End If
    End Sub

    Public Sub pb3(card As String)
        If card = "10C" Then
            PictureBox3.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox3.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox3.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox3.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox3.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox3.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox3.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox3.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox3.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox3.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox3.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox3.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox3.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox3.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox3.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox3.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox3.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox3.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox3.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox3.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox3.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox3.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox3.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox3.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox3.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox3.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox3.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox3.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox3.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox3.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox3.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox3.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox3.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox3.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox3.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox3.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox3.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox3.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox3.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox3.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox3.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox3.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox3.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox3.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox3.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox3.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox3.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox3.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox3.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox3.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox3.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox3.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox3.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox3.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox3.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox3.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox3.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox3.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox3.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox3.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox3.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox3.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox3.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox3.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox3.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox3.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox3.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox3.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox3.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox3.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox3.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox3.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox3.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox3.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox3.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox3.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox3.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox3.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox3.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox3.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox3.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox3.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox3.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox3.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox3.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox3.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox3.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox3.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox3.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox3.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox3.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox3.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox3.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox3.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox3.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox3.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox3.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox3.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox3.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox3.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox3.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox3.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox3.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox3.Image = My.Resources.QSwL
        Else
            PictureBox3.Image = Nothing
            PictureBox3.Visible = False
        End If
    End Sub

    Public Sub pb4(card As String)
        If card = "10C" Then
            PictureBox4.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox4.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox4.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox4.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox4.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox4.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox4.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox4.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox4.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox4.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox4.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox4.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox4.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox4.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox4.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox4.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox4.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox4.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox4.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox4.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox4.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox4.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox4.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox4.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox4.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox4.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox4.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox4.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox4.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox4.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox4.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox4.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox4.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox4.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox4.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox4.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox4.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox4.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox4.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox4.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox4.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox4.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox4.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox4.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox4.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox4.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox4.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox4.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox4.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox4.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox4.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox4.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox4.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox4.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox4.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox4.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox4.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox4.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox4.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox4.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox4.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox4.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox4.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox4.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox4.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox4.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox4.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox4.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox4.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox4.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox4.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox4.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox4.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox4.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox4.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox4.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox4.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox4.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox4.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox4.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox4.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox4.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox4.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox4.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox4.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox4.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox4.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox4.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox4.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox4.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox4.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox4.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox4.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox4.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox4.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox4.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox4.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox4.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox4.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox4.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox4.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox4.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox4.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox4.Image = My.Resources.QSwL
        Else
            PictureBox4.Image = Nothing
            PictureBox4.Visible = False
        End If
    End Sub

    Public Sub pb5(card As String)
        If card = "10C" Then
            PictureBox5.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox5.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox5.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox5.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox5.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox5.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox5.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox5.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox5.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox5.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox5.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox5.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox5.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox5.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox5.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox5.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox5.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox5.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox5.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox5.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox5.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox5.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox5.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox5.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox5.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox5.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox5.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox5.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox5.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox5.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox5.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox5.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox5.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox5.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox5.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox5.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox5.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox5.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox5.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox5.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox5.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox5.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox5.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox5.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox5.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox5.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox5.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox5.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox5.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox5.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox5.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox5.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox5.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox5.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox5.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox5.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox5.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox5.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox5.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox5.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox5.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox5.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox5.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox5.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox5.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox5.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox5.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox5.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox5.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox5.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox5.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox5.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox5.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox5.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox5.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox5.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox5.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox5.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox5.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox5.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox5.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox5.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox5.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox5.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox5.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox5.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox5.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox5.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox5.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox5.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox5.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox5.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox5.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox5.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox5.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox5.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox5.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox5.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox5.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox5.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox5.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox5.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox5.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox5.Image = My.Resources.QSwL
        Else
            PictureBox5.Image = Nothing
            PictureBox5.Visible = False
        End If
    End Sub

    Public Sub pb6(card As String)
        If card = "10C" Then
            PictureBox6.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox6.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox6.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox6.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox6.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox6.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox6.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox6.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox6.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox6.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox6.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox6.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox6.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox6.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox6.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox6.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox6.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox6.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox6.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox6.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox6.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox6.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox6.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox6.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox6.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox6.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox6.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox6.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox6.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox6.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox6.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox6.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox6.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox6.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox6.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox6.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox6.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox6.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox6.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox6.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox6.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox6.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox6.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox6.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox6.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox6.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox6.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox6.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox6.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox6.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox6.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox6.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox6.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox6.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox6.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox6.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox6.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox6.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox6.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox6.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox6.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox6.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox6.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox6.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox6.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox6.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox6.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox6.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox6.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox6.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox6.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox6.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox6.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox6.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox6.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox6.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox6.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox6.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox6.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox6.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox6.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox6.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox6.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox6.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox6.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox6.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox6.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox6.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox6.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox6.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox6.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox6.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox6.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox6.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox6.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox6.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox6.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox6.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox6.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox6.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox6.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox6.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox6.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox6.Image = My.Resources.QSwL
        Else
            PictureBox6.Image = Nothing
            PictureBox6.Visible = False
        End If
    End Sub

    Public Sub pb7(card As String)
        If card = "10C" Then
            PictureBox7.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox7.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox7.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox7.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox7.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox7.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox7.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox7.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox7.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox7.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox7.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox7.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox7.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox7.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox7.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox7.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox7.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox7.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox7.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox7.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox7.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox7.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox7.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox7.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox7.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox7.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox7.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox7.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox7.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox7.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox7.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox7.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox7.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox7.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox7.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox7.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox7.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox7.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox7.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox7.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox7.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox7.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox7.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox7.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox7.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox7.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox7.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox7.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox7.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox7.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox7.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox7.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox7.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox7.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox7.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox7.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox7.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox7.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox7.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox7.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox7.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox7.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox7.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox7.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox7.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox7.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox7.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox7.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox7.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox7.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox7.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox7.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox7.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox7.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox7.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox7.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox7.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox7.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox7.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox7.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox7.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox7.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox7.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox7.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox7.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox7.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox7.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox7.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox7.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox7.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox7.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox7.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox7.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox7.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox7.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox7.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox7.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox7.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox7.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox7.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox7.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox7.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox7.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox7.Image = My.Resources.QSwL
        Else
            PictureBox7.Image = Nothing
            PictureBox7.Visible = False
        End If
    End Sub

    Public Sub pb8(card As String)
        If card = "10C" Then
            PictureBox8.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox8.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox8.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox8.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox8.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox8.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox8.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox8.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox8.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox8.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox8.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox8.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox8.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox8.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox8.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox8.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox8.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox8.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox8.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox8.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox8.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox8.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox8.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox8.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox8.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox8.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox8.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox8.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox8.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox8.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox8.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox8.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox8.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox8.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox8.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox8.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox8.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox8.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox8.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox8.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox8.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox8.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox8.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox8.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox8.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox8.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox8.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox8.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox8.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox8.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox8.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox8.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox8.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox8.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox8.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox8.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox8.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox8.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox8.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox8.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox8.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox8.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox8.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox8.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox8.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox8.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox8.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox8.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox8.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox8.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox8.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox8.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox8.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox8.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox8.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox8.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox8.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox8.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox8.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox8.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox8.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox8.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox8.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox8.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox8.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox8.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox8.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox8.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox8.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox8.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox8.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox8.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox8.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox8.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox8.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox8.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox8.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox8.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox8.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox8.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox8.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox8.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox8.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox8.Image = My.Resources.QSwL
        Else
            PictureBox8.Image = Nothing
            PictureBox8.Visible = False
        End If
    End Sub

    Public Sub pb9(card As String)
        If card = "10C" Then
            PictureBox9.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox9.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox9.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox9.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox9.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox9.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox9.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox9.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox9.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox9.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox9.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox9.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox9.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox9.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox9.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox9.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox9.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox9.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox9.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox9.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox9.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox9.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox9.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox9.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox9.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox9.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox9.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox9.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox9.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox9.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox9.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox9.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox9.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox9.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox9.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox9.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox9.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox9.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox9.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox9.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox9.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox9.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox9.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox9.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox9.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox9.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox9.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox9.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox9.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox9.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox9.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox9.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox9.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox9.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox9.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox9.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox9.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox9.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox9.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox9.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox9.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox9.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox9.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox9.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox9.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox9.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox9.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox9.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox9.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox9.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox9.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox9.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox9.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox9.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox9.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox9.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox9.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox9.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox9.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox9.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox9.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox9.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox9.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox9.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox9.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox9.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox9.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox9.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox9.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox9.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox9.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox9.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox9.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox9.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox9.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox9.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox9.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox9.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox9.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox9.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox9.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox9.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox9.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox9.Image = My.Resources.QSwL
        Else
            PictureBox9.Image = Nothing
            PictureBox9.Visible = False
        End If
    End Sub

    Public Sub pb10(card As String)
        If card = "10C" Then
            PictureBox10.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox10.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox10.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox10.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox10.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox10.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox10.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox10.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox10.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox10.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox10.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox10.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox10.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox10.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox10.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox10.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox10.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox10.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox10.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox10.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox10.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox10.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox10.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox10.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox10.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox10.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox10.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox10.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox10.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox10.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox10.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox10.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox10.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox10.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox10.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox10.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox10.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox10.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox10.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox10.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox10.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox10.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox10.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox10.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox10.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox10.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox10.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox10.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox10.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox10.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox10.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox10.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox10.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox10.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox10.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox10.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox10.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox10.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox10.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox10.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox10.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox10.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox10.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox10.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox10.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox10.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox10.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox10.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox10.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox10.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox10.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox10.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox10.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox10.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox10.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox10.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox10.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox10.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox10.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox10.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox10.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox10.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox10.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox10.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox10.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox10.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox10.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox10.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox10.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox10.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox10.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox10.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox10.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox10.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox10.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox10.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox10.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox10.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox10.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox10.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox10.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox10.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox10.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox10.Image = My.Resources.QSwL
        Else
            PictureBox10.Image = Nothing
            PictureBox10.Visible = False
        End If
    End Sub

    Public Sub pb11(card As String)
        If card = "10C" Then
            PictureBox11.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox11.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox11.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox11.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox11.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox11.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox11.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox11.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox11.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox11.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox11.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox11.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox11.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox11.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox11.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox11.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox11.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox11.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox11.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox11.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox11.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox11.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox11.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox11.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox11.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox11.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox11.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox11.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox11.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox11.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox11.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox11.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox11.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox11.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox11.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox11.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox11.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox11.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox11.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox11.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox11.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox11.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox11.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox11.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox11.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox11.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox11.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox11.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox11.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox11.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox11.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox11.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox11.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox11.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox11.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox11.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox11.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox11.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox11.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox11.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox11.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox11.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox11.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox11.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox11.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox11.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox11.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox11.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox11.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox11.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox11.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox11.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox11.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox11.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox11.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox11.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox11.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox11.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox11.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox11.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox11.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox11.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox11.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox11.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox11.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox11.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox11.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox11.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox11.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox11.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox11.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox11.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox11.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox11.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox11.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox11.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox11.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox11.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox11.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox11.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox11.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox11.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox11.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox11.Image = My.Resources.QSwL
        Else
            PictureBox11.Image = Nothing
            PictureBox11.Visible = False
        End If
    End Sub

    Public Sub pb12(card As String)
        If card = "10C" Then
            PictureBox12.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox12.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox12.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox12.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox12.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox12.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox12.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox12.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox12.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox12.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox12.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox12.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox12.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox12.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox12.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox12.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox12.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox12.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox12.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox12.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox12.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox12.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox12.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox12.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox12.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox12.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox12.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox12.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox12.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox12.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox12.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox12.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox12.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox12.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox12.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox12.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox12.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox12.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox12.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox12.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox12.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox12.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox12.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox12.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox12.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox12.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox12.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox12.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox12.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox12.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox12.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox12.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox12.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox12.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox12.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox12.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox12.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox12.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox12.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox12.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox12.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox12.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox12.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox12.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox12.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox12.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox12.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox12.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox12.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox12.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox12.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox12.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox12.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox12.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox12.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox12.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox12.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox12.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox12.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox12.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox12.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox12.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox12.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox12.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox12.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox12.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox12.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox12.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox12.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox12.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox12.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox12.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox12.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox12.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox12.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox12.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox12.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox12.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox12.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox12.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox12.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox12.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox12.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox12.Image = My.Resources.QSwL
        Else
            PictureBox12.Image = Nothing
            PictureBox12.Visible = False
        End If
    End Sub

    Public Sub pb13(card As String)
        If card = "10C" Then
            PictureBox13.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox13.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox13.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox13.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox13.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox13.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox13.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox13.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox13.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox13.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox13.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox13.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox13.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox13.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox13.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox13.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox13.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox13.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox13.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox13.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox13.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox13.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox13.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox13.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox13.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox13.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox13.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox13.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox13.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox13.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox13.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox13.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox13.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox13.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox13.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox13.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox13.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox13.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox13.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox13.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox13.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox13.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox13.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox13.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox13.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox13.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox13.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox13.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox13.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox13.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox13.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox13.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox13.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox13.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox13.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox13.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox13.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox13.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox13.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox13.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox13.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox13.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox13.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox13.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox13.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox13.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox13.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox13.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox13.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox13.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox13.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox13.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox13.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox13.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox13.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox13.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox13.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox13.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox13.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox13.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox13.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox13.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox13.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox13.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox13.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox13.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox13.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox13.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox13.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox13.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox13.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox13.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox13.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox13.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox13.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox13.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox13.Image = My.Resources.QC
        ElseIf card = "QCWL" Then

            PictureBox13.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox13.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox13.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox13.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox13.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox13.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox13.Image = My.Resources.QSwL
        Else
            PictureBox13.Image = Nothing
            PictureBox13.Visible = False
        End If
    End Sub

    Public Sub pb14(card As String)
        If card = "10C" Then
            PictureBox14.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox14.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox14.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox14.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox14.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox14.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox14.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox14.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox14.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox14.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox14.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox14.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox14.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox14.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox14.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox14.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox14.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox14.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox14.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox14.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox14.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox14.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox14.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox14.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox14.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox14.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox14.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox14.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox14.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox14.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox14.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox14.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox14.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox14.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox14.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox14.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox14.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox14.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox14.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox14.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox14.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox14.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox14.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox14.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox14.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox14.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox14.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox14.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox14.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox14.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox14.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox14.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox14.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox14.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox14.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox14.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox14.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox14.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox14.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox14.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox14.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox14.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox14.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox14.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox14.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox14.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox14.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox14.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox14.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox14.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox14.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox14.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox14.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox14.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox14.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox14.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox14.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox14.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox14.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox14.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox14.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox14.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox14.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox14.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox14.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox14.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox14.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox14.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox14.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox14.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox14.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox14.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox14.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox14.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox14.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox14.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox14.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox14.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox14.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox14.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox14.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox14.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox14.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox14.Image = My.Resources.QSwL
        Else
            PictureBox14.Image = Nothing
            PictureBox14.Visible = False
        End If
    End Sub

    Public Sub pb15(card As String)
        If card = "10C" Then
            PictureBox15.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox15.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox15.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox15.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox15.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox15.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox15.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox15.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox15.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox15.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox15.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox15.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox15.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox15.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox15.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox15.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox15.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox15.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox15.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox15.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox15.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox15.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox15.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox15.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox15.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox15.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox15.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox15.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox15.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox15.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox15.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox15.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox15.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox15.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox15.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox15.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox15.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox15.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox15.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox15.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox15.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox15.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox15.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox15.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox15.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox15.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox15.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox15.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox15.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox15.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox15.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox15.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox15.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox15.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox15.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox15.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox15.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox15.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox15.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox15.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox15.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox15.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox15.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox15.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox15.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox15.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox15.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox15.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox15.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox15.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox15.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox15.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox15.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox15.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox15.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox15.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox15.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox15.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox15.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox15.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox15.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox15.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox15.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox15.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox15.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox15.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox15.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox15.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox15.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox15.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox15.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox15.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox15.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox15.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox15.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox15.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox15.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox15.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox15.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox15.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox15.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox15.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox15.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox15.Image = My.Resources.QSwL
        Else
            PictureBox15.Image = Nothing
            PictureBox15.Visible = False
        End If
    End Sub

    Public Sub pb16(card As String)
        If card = "10C" Then
            PictureBox16.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox16.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox16.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox16.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox16.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox16.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox16.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox16.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox16.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox16.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox16.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox16.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox16.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox16.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox16.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox16.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox16.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox16.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox16.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox16.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox16.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox16.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox16.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox16.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox16.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox16.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox16.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox16.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox16.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox16.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox16.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox16.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox16.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox16.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox16.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox16.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox16.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox16.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox16.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox16.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox16.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox16.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox16.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox16.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox16.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox16.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox16.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox16.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox16.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox16.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox16.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox16.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox16.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox16.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox16.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox16.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox16.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox16.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox16.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox16.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox16.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox16.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox16.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox16.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox16.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox16.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox16.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox16.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox16.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox16.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox16.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox16.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox16.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox16.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox16.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox16.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox16.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox16.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox16.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox16.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox16.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox16.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox16.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox16.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox16.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox16.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox16.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox16.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox16.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox16.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox16.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox16.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox16.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox16.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox16.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox16.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox16.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox16.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox16.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox16.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox16.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox16.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox16.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox16.Image = My.Resources.QSwL
        Else
            PictureBox16.Image = Nothing
            PictureBox16.Visible = False
        End If
    End Sub

    Public Sub pb17(card As String)
        If card = "10C" Then
            PictureBox17.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox17.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox17.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox17.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox17.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox17.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox17.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox17.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox17.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox17.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox17.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox17.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox17.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox17.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox17.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox17.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox17.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox17.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox17.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox17.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox17.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox17.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox17.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox17.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox17.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox17.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox17.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox17.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox17.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox17.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox17.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox17.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox17.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox17.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox17.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox17.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox17.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox17.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox17.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox17.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox17.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox17.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox17.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox17.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox17.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox17.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox17.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox17.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox17.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox17.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox17.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox17.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox17.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox17.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox17.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox17.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox17.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox17.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox17.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox17.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox17.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox17.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox17.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox17.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox17.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox17.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox17.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox17.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox17.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox17.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox17.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox17.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox17.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox17.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox17.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox17.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox17.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox17.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox17.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox17.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox17.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox17.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox17.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox17.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox17.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox17.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox17.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox17.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox17.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox17.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox17.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox17.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox17.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox17.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox17.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox17.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox17.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox17.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox17.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox17.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox17.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox17.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox17.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox17.Image = My.Resources.QSwL
        Else
            PictureBox17.Image = Nothing
            PictureBox17.Visible = False
        End If
    End Sub

    Public Sub pb18(card As String)
        If card = "10C" Then
            PictureBox18.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox18.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox18.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox18.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox18.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox18.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox18.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox18.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox18.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox18.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox18.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox18.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox18.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox18.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox18.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox18.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox18.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox18.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox18.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox18.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox18.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox18.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox18.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox18.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox18.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox18.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox18.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox18.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox18.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox18.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox18.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox18.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox18.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox18.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox18.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox18.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox18.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox18.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox18.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox18.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox18.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox18.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox18.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox18.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox18.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox18.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox18.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox18.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox18.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox18.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox18.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox18.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox18.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox18.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox18.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox18.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox18.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox18.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox18.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox18.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox18.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox18.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox18.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox18.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox18.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox18.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox18.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox18.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox18.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox18.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox18.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox18.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox18.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox18.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox18.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox18.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox18.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox18.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox18.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox18.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox18.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox18.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox18.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox18.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox18.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox18.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox18.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox18.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox18.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox18.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox18.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox18.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox18.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox18.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox18.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox18.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox18.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox18.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox18.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox18.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox18.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox18.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox18.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox18.Image = My.Resources.QSwL
        Else
            PictureBox18.Image = Nothing
            PictureBox18.Visible = False
        End If
    End Sub

    Public Sub pb19(card As String)
        If card = "10C" Then
            PictureBox19.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox19.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox19.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox19.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox19.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox19.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox19.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox19.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox19.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox19.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox19.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox19.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox19.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox19.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox19.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox19.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox19.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox19.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox19.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox19.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox19.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox19.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox19.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox19.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox19.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox19.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox19.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox19.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox19.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox19.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox19.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox19.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox19.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox19.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox19.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox19.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox19.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox19.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox19.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox19.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox19.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox19.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox19.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox19.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox19.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox19.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox19.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox19.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox19.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox19.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox19.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox19.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox19.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox19.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox19.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox19.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox19.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox19.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox19.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox19.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox19.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox19.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox19.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox19.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox19.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox19.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox19.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox19.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox19.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox19.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox19.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox19.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox19.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox19.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox19.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox19.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox19.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox19.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox19.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox19.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox19.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox19.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox19.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox19.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox19.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox19.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox19.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox19.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox19.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox19.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox19.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox19.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox19.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox19.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox19.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox19.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox19.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox19.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox19.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox19.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox19.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox19.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox19.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox19.Image = My.Resources.QSwL
        Else
            PictureBox19.Image = Nothing
            PictureBox19.Visible = False
        End If
    End Sub

    Public Sub pb20(card As String)
        If card = "10C" Then
            PictureBox20.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox20.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox20.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox20.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox20.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox20.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox20.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox20.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox20.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox20.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox20.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox20.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox20.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox20.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox20.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox20.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox20.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox20.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox20.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox20.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox20.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox20.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox20.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox20.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox20.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox20.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox20.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox20.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox20.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox20.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox20.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox20.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox20.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox20.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox20.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox20.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox20.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox20.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox20.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox20.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox20.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox20.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox20.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox20.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox20.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox20.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox20.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox20.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox20.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox20.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox20.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox20.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox20.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox20.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox20.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox20.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox20.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox20.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox20.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox20.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox20.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox20.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox20.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox20.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox20.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox20.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox20.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox20.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox20.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox20.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox20.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox20.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox20.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox20.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox20.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox20.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox20.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox20.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox20.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox20.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox20.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox20.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox20.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox20.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox20.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox20.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox20.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox20.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox20.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox20.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox20.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox20.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox20.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox20.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox20.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox20.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox20.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox20.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox20.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox20.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox20.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox20.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox20.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox20.Image = My.Resources.QSwL
        Else
            PictureBox20.Image = Nothing
            PictureBox20.Visible = False
        End If
    End Sub

    Public Sub pb21(card As String)
        If card = "10C" Then
            PictureBox21.Image = My.Resources._10C
        ElseIf card = "10CWL" Then
            PictureBox21.Image = My.Resources._10CwL
        ElseIf card = "10D" Then
            PictureBox21.Image = My.Resources._10D
        ElseIf card = "10DWL" Then
            PictureBox21.Image = My.Resources._10DwL
        ElseIf card = "10H" Then
            PictureBox21.Image = My.Resources._10H
        ElseIf card = "10HWL" Then
            PictureBox21.Image = My.Resources._10HwL
        ElseIf card = "10S" Then
            PictureBox21.Image = My.Resources._10S
        ElseIf card = "10sWL" Then
            PictureBox21.Image = My.Resources._10SwL

        ElseIf card = "2C" Then
            PictureBox21.Image = My.Resources._2C
        ElseIf card = "2CWL" Then
            PictureBox21.Image = My.Resources._2CwL
        ElseIf card = "2D" Then
            PictureBox21.Image = My.Resources._2D
        ElseIf card = "2DWL" Then
            PictureBox21.Image = My.Resources._2DwL
        ElseIf card = "2H" Then
            PictureBox21.Image = My.Resources._2H
        ElseIf card = "2HWL" Then
            PictureBox21.Image = My.Resources._2HwL
        ElseIf card = "2S" Then
            PictureBox21.Image = My.Resources._2S
        ElseIf card = "2sWL" Then
            PictureBox21.Image = My.Resources._2SwL

        ElseIf card = "3C" Then
            PictureBox21.Image = My.Resources._3C
        ElseIf card = "3CWL" Then
            PictureBox21.Image = My.Resources._3CwL
        ElseIf card = "3D" Then
            PictureBox21.Image = My.Resources._3D
        ElseIf card = "3DWL" Then
            PictureBox21.Image = My.Resources._3DwL
        ElseIf card = "3H" Then
            PictureBox21.Image = My.Resources._3H
        ElseIf card = "3HWL" Then
            PictureBox21.Image = My.Resources._3HwL
        ElseIf card = "3S" Then
            PictureBox21.Image = My.Resources._3S
        ElseIf card = "3sWL" Then
            PictureBox21.Image = My.Resources._3SwL

        ElseIf card = "4C" Then
            PictureBox21.Image = My.Resources._4C
        ElseIf card = "4CWL" Then
            PictureBox21.Image = My.Resources._4CwL
        ElseIf card = "4D" Then
            PictureBox21.Image = My.Resources._4D
        ElseIf card = "4DWL" Then
            PictureBox21.Image = My.Resources._4DwL
        ElseIf card = "4H" Then
            PictureBox21.Image = My.Resources._4H
        ElseIf card = "4HWL" Then
            PictureBox21.Image = My.Resources._4HwL
        ElseIf card = "4S" Then
            PictureBox21.Image = My.Resources._4S
        ElseIf card = "4sWL" Then
            PictureBox21.Image = My.Resources._4SwL

        ElseIf card = "5C" Then
            PictureBox21.Image = My.Resources._5C
        ElseIf card = "5CWL" Then
            PictureBox21.Image = My.Resources._5CwL
        ElseIf card = "5D" Then
            PictureBox21.Image = My.Resources._5D
        ElseIf card = "5DWL" Then
            PictureBox21.Image = My.Resources._5DwL
        ElseIf card = "5H" Then
            PictureBox21.Image = My.Resources._5H
        ElseIf card = "5HWL" Then
            PictureBox21.Image = My.Resources._5HwL
        ElseIf card = "5S" Then
            PictureBox21.Image = My.Resources._5S
        ElseIf card = "5sWL" Then
            PictureBox21.Image = My.Resources._5SwL

        ElseIf card = "6C" Then
            PictureBox21.Image = My.Resources._6C
        ElseIf card = "6CWL" Then
            PictureBox21.Image = My.Resources._6CwL
        ElseIf card = "6D" Then
            PictureBox21.Image = My.Resources._6D
        ElseIf card = "6DWL" Then
            PictureBox21.Image = My.Resources._6DwL
        ElseIf card = "6H" Then
            PictureBox21.Image = My.Resources._6H
        ElseIf card = "6HWL" Then
            PictureBox21.Image = My.Resources._6HwL
        ElseIf card = "6S" Then
            PictureBox21.Image = My.Resources._6S
        ElseIf card = "6sWL" Then
            PictureBox21.Image = My.Resources._6SwL

        ElseIf card = "7C" Then
            PictureBox21.Image = My.Resources._7C
        ElseIf card = "7CWL" Then
            PictureBox21.Image = My.Resources._7CwL
        ElseIf card = "7D" Then
            PictureBox21.Image = My.Resources._7D
        ElseIf card = "7DWL" Then
            PictureBox21.Image = My.Resources._7DwL
        ElseIf card = "7H" Then
            PictureBox21.Image = My.Resources._7H
        ElseIf card = "7HWL" Then
            PictureBox21.Image = My.Resources._7HwL
        ElseIf card = "7S" Then
            PictureBox21.Image = My.Resources._7S
        ElseIf card = "7sWL" Then
            PictureBox21.Image = My.Resources._7SwL

        ElseIf card = "8C" Then
            PictureBox21.Image = My.Resources._8C
        ElseIf card = "8CWL" Then
            PictureBox21.Image = My.Resources._8CwL
        ElseIf card = "8D" Then
            PictureBox21.Image = My.Resources._8D
        ElseIf card = "8DWL" Then
            PictureBox21.Image = My.Resources._8DwL
        ElseIf card = "8H" Then
            PictureBox21.Image = My.Resources._8H
        ElseIf card = "8HWL" Then
            PictureBox21.Image = My.Resources._8HwL
        ElseIf card = "8S" Then
            PictureBox21.Image = My.Resources._8S
        ElseIf card = "8sWL" Then
            PictureBox21.Image = My.Resources._8SwL

        ElseIf card = "9C" Then
            PictureBox21.Image = My.Resources._9C
        ElseIf card = "9CWL" Then
            PictureBox21.Image = My.Resources._9CwL
        ElseIf card = "9D" Then
            PictureBox21.Image = My.Resources._9D
        ElseIf card = "9DWL" Then
            PictureBox21.Image = My.Resources._9DwL
        ElseIf card = "9H" Then
            PictureBox21.Image = My.Resources._9H
        ElseIf card = "9HWL" Then
            PictureBox21.Image = My.Resources._9HwL
        ElseIf card = "9S" Then
            PictureBox21.Image = My.Resources._9S
        ElseIf card = "9sWL" Then
            PictureBox21.Image = My.Resources._9SwL

        ElseIf card = "AC" Then
            PictureBox21.Image = My.Resources.AC
        ElseIf card = "ACWL" Then
            PictureBox21.Image = My.Resources.ACwL
        ElseIf card = "AD" Then
            PictureBox21.Image = My.Resources.AD
        ElseIf card = "ADWL" Then
            PictureBox21.Image = My.Resources.ADwL
        ElseIf card = "AH" Then
            PictureBox21.Image = My.Resources.AH
        ElseIf card = "AHWL" Then
            PictureBox21.Image = My.Resources.AHwL
        ElseIf card = "AS" Then
            PictureBox21.Image = My.Resources._AS
        ElseIf card = "AsWL" Then
            PictureBox21.Image = My.Resources.ASwL

        ElseIf card = "JC" Then
            PictureBox21.Image = My.Resources.JC
        ElseIf card = "JCWL" Then
            PictureBox21.Image = My.Resources.JCwL
        ElseIf card = "JD" Then
            PictureBox21.Image = My.Resources.JD
        ElseIf card = "JDWL" Then
            PictureBox21.Image = My.Resources.JDwL
        ElseIf card = "JH" Then
            PictureBox21.Image = My.Resources.JH
        ElseIf card = "JHWL" Then
            PictureBox21.Image = My.Resources.JHwL
        ElseIf card = "JS" Then
            PictureBox21.Image = My.Resources.JS
        ElseIf card = "JsWL" Then
            PictureBox21.Image = My.Resources.JSwL

        ElseIf card = "KC" Then
            PictureBox21.Image = My.Resources.KC
        ElseIf card = "KCWL" Then
            PictureBox21.Image = My.Resources.KCwL
        ElseIf card = "KD" Then
            PictureBox21.Image = My.Resources.KD
        ElseIf card = "KDWL" Then
            PictureBox21.Image = My.Resources.KDwL
        ElseIf card = "KH" Then
            PictureBox21.Image = My.Resources.KH
        ElseIf card = "KHWL" Then
            PictureBox21.Image = My.Resources.KHwL
        ElseIf card = "KS" Then
            PictureBox21.Image = My.Resources.KS
        ElseIf card = "KsWL" Then
            PictureBox21.Image = My.Resources.KSwL

        ElseIf card = "QC" Then
            PictureBox21.Image = My.Resources.QC
        ElseIf card = "QCWL" Then
            PictureBox21.Image = My.Resources.QCwL
        ElseIf card = "QD" Then
            PictureBox21.Image = My.Resources.QD
        ElseIf card = "QDWL" Then
            PictureBox21.Image = My.Resources.QDwL
        ElseIf card = "QH" Then
            PictureBox21.Image = My.Resources.QH
        ElseIf card = "QHWL" Then
            PictureBox21.Image = My.Resources.QHwL
        ElseIf card = "QS" Then
            PictureBox21.Image = My.Resources.QS
        ElseIf card = "QsWL" Then
            PictureBox21.Image = My.Resources.QSwL
        Else
            PictureBox21.Image = Nothing
            PictureBox21.Visible = False
        End If
    End Sub

End Class