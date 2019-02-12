Imports System.Data
Imports System.Data.SqlClient

Public Class Gamestage
    Dim _debug_move As Boolean = False

    Dim Full_Card() As String = {"AC", "AD", "AH", "AS", "2C", "2D", "2H", "2S", "3C", "3D", "3H", "3S", "4C", "4D", "4H", "4S", "5C", "5D", "5H", "5S", "6C", "6D", "6H", "6S", "7C", "7D", "7H", "7S", "8C", "8D", "8H", "8S", "9C", "9D", "9H", "9S", "10C", "10D", "10H", "10S", "JC", "JD", "JH", "JS", "QC", "QD", "QH", "QS", "KC", "KD", "KH", "KS"}

    Dim PulledPool As New ArrayList

    Dim _Row1 As New ArrayList
    Dim _Row2 As New ArrayList
    Dim _Row3 As New ArrayList
    Dim _Row4 As New ArrayList
    Dim _Row5 As New ArrayList
    Dim _Row6 As New ArrayList
    Dim _Row7 As New ArrayList

    Dim _Deck As New ArrayList
    Dim _Deck_Open As New ArrayList

    Dim _Row8 As New ArrayList
    Dim _Row9 As New ArrayList
    Dim _Row10 As New ArrayList
    Dim _Row11 As New ArrayList

    Dim _Condition_cardselected As Boolean
    Dim _selected_card1() As String
    Dim _selected_card2() As String

    Dim _Game_Move As Integer
    Dim _Game_Step As Integer

    Public Property PulledPool1 As ArrayList
        Get
            Return PulledPool
        End Get
        Set(value As ArrayList)
            PulledPool = value
        End Set
    End Property

    Public Property Row1 As ArrayList
        Get
            Return _Row1
        End Get
        Set(value As ArrayList)
            _Row1 = value
        End Set
    End Property

    Public Property Row2 As ArrayList
        Get
            Return _Row2
        End Get
        Set(value As ArrayList)
            _Row2 = value
        End Set
    End Property

    Public Property Row3 As ArrayList
        Get
            Return _Row3
        End Get
        Set(value As ArrayList)
            _Row3 = value
        End Set
    End Property

    Public Property Row4 As ArrayList
        Get
            Return _Row4
        End Get
        Set(value As ArrayList)
            _Row4 = value
        End Set
    End Property

    Public Property Row5 As ArrayList
        Get
            Return _Row5
        End Get
        Set(value As ArrayList)
            _Row5 = value
        End Set
    End Property

    Public Property Row6 As ArrayList
        Get
            Return _Row6
        End Get
        Set(value As ArrayList)
            _Row6 = value
        End Set
    End Property

    Public Property Row7 As ArrayList
        Get
            Return _Row7
        End Get
        Set(value As ArrayList)
            _Row7 = value
        End Set
    End Property

    Public Property Deck As ArrayList
        Get
            Return _Deck
        End Get
        Set(value As ArrayList)
            _Deck = value
        End Set
    End Property

    Public Property Deck_Open As ArrayList
        Get
            Return _Deck_Open
        End Get
        Set(value As ArrayList)
            _Deck_Open = value
        End Set
    End Property

    Public Property Row8 As ArrayList
        Get
            Return _Row8
        End Get
        Set(value As ArrayList)
            _Row8 = value
        End Set
    End Property

    Public Property Row9 As ArrayList
        Get
            Return _Row9
        End Get
        Set(value As ArrayList)
            _Row9 = value
        End Set
    End Property

    Public Property Row10 As ArrayList
        Get
            Return _Row10
        End Get
        Set(value As ArrayList)
            _Row10 = value
        End Set
    End Property

    Public Property Row11 As ArrayList
        Get
            Return _Row11
        End Get
        Set(value As ArrayList)
            _Row11 = value
        End Set
    End Property

    Public Property Condition_cardselected1 As Boolean
        Get
            Return _Condition_cardselected
        End Get
        Set(value As Boolean)
            _Condition_cardselected = value
        End Set
    End Property

    Public Property Selected_card1 As String()
        Get
            Return _selected_card1
        End Get
        Set(value As String())
            _selected_card1 = value
        End Set
    End Property

    Public Property Selected_card2 As String()
        Get
            Return _selected_card2
        End Get
        Set(value As String())
            _selected_card2 = value
        End Set
    End Property

    Public Property Game_Move As Integer
        Get
            Return _Game_Move
        End Get
        Set(value As Integer)
            _Game_Move = value
        End Set
    End Property

    Public Property Game_Step As Integer
        Get
            Return _Game_Step
        End Get
        Set(value As Integer)
            _Game_Step = value
        End Set
    End Property

    Public Property Debug_move As Boolean
        Get
            Return _debug_move
        End Get
        Set(value As Boolean)
            _debug_move = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub Load()

    End Sub



    Public Sub Generate_Game()

        PulledPool.AddRange(Full_Card)

        Pull_from_Deck(1, "Row1", True)
        Pull_from_Deck(2, "Row2", True)
        Pull_from_Deck(3, "Row3", True)
        Pull_from_Deck(4, "Row4", True)
        Pull_from_Deck(5, "Row5", True)
        Pull_from_Deck(6, "Row6", True)
        Pull_from_Deck(7, "Row7", True)
        Pull_from_Deck(24, "Deck", False)
        Game_Move = 0
        Game_Step = 0

    End Sub

    Public Sub Pull_from_Deck(num As Integer, deck_name As String, cover As Boolean)
        Dim rng As New Random()

        Dim out As New ArrayList

        For i = 0 To num - 1
            Dim rannum As Integer = rng.Next(0, PulledPool.Count)
            If cover Then
                out.Add(PulledPool(rannum) + "F")
            Else
                out.Add(PulledPool(rannum))
            End If

            PulledPool.RemoveAt(rannum)
        Next

        If deck_name = "Row1" Then
            _Row1.AddRange(out)
        ElseIf deck_name = "Row2" Then
            _Row2.AddRange(out)
        ElseIf deck_name = "Row3" Then
            _Row3.AddRange(out)
        ElseIf deck_name = "Row4" Then
            _Row4.AddRange(out)
        ElseIf deck_name = "Row5" Then
            _Row5.AddRange(out)
        ElseIf deck_name = "Row6" Then
            _Row6.AddRange(out)
        ElseIf deck_name = "Row7" Then
            _Row7.AddRange(out)
        ElseIf deck_name = "Deck" Then
            _Deck.AddRange(out)
        End If

    End Sub

    Public Sub Move_card(count As Integer)

        Dim temp As String

        Dim row As String = Selected_card1(0)
        Dim location As Integer = Selected_card1(1) - 1

        For i = 0 To count - 1

            row = Selected_card1(0)

            If row = "R1" Then
                temp = Row1(location)
                Row1.RemoveAt(location)
            ElseIf row = "R2" Then
                temp = Row2(location)
                Row2.RemoveAt(location)
            ElseIf row = ("R3") Then
                temp = Row3(location)
                Row3.RemoveAt(location)
            ElseIf row = ("R4") Then
                temp = Row4(location)
                Row4.RemoveAt(location)
            ElseIf row = ("R5") Then
                temp = Row5(location)
                Row5.RemoveAt(location)
            ElseIf row = ("R6") Then
                temp = Row6(location)
                Row6.RemoveAt(location)
            ElseIf row = ("R7") Then
                temp = Row7(location)
                Row7.RemoveAt(location)
            ElseIf row = ("R8") Then
                temp = Row8(location)
                Row8.RemoveAt(location)
            ElseIf row = ("R9") Then
                temp = Row9(location)
                Row9.RemoveAt(location)
            ElseIf row = ("R10") Then
                temp = Row10(location)
                Row10.RemoveAt(location)
            ElseIf row = ("R11") Then
                temp = Row11(location)
                Row11.RemoveAt(location)
            ElseIf row = ("TD") Then
                temp = Deck_Open(location)
                Deck_Open.RemoveAt(location)
            End If

            row = Selected_card2(0)
            If row = "R1" Then
                Row1.Add(temp)
            ElseIf row = "R2" Then
                Row2.Add(temp)
            ElseIf row = ("R3") Then
                Row3.Add(temp)
            ElseIf row = ("R4") Then
                Row4.Add(temp)
            ElseIf row = ("R5") Then
                Row5.Add(temp)
            ElseIf row = ("R6") Then
                Row6.Add(temp)
            ElseIf row = ("R7") Then
                Row7.Add(temp)
            ElseIf row = ("R8") Then
                Row8.Add(temp)
            ElseIf row = ("R9") Then
                Row9.Add(temp)
            ElseIf row = ("R10") Then
                Row10.Add(temp)
            ElseIf row = ("R11") Then
                Row11.Add(temp)
            ElseIf row = ("TD") Then
                Deck_Open.Add(temp)
            End If

        Next

    End Sub

    Public Sub card_selected(card As String())


        Dim row As String = card(0)

        If _Condition_cardselected = False Then
            If row = "R1" And Row1.Count = 0 Then
                Exit Sub
            ElseIf row = "R2" And Row2.Count = 0 Then
                Exit Sub
            ElseIf row = "R3" And Row3.Count = 0 Then
                Exit Sub
            ElseIf row = "R4" And Row4.Count = 0 Then
                Exit Sub
            ElseIf row = "R5" And Row5.Count = 0 Then
                Exit Sub
            ElseIf row = "R6" And Row6.Count = 0 Then
                Exit Sub
            ElseIf row = "R7" And Row7.Count = 0 Then
                Exit Sub
            ElseIf row = "R8" And Row8.Count = 0 Then
                Exit Sub
            ElseIf row = "R9" And Row9.Count = 0 Then
                Exit Sub
            ElseIf row = "R10" And Row10.Count = 0 Then
                Exit Sub
            ElseIf row = "R11" And Row11.Count = 0 Then
                Exit Sub
            ElseIf row = "TD" And Deck_Open.Count = 0 Then
                Exit Sub
            End If

            _Condition_cardselected = True
            _selected_card1 = card
            Hilight_card(card, True)
        Else

            If _selected_card1(0) = card(0) And _selected_card1(1) = card(1) Then
                _Condition_cardselected = False
                _selected_card1(0) = ""
                _selected_card1(1) = ""

                Hilight_card(card, False)

            Else
                _selected_card2 = card
                Hilight_card(_selected_card1, False)
                If row = "R8" Or row = "R9" Or row = "R10" Or row = "R11" Then
                    If checkdeck() Or Debug_move Then

                        row_move()

                        Game_Step += 1
                        Game_Move += 1

                    End If
                Else
                    If checkmove() Or Debug_move Then

                        row_move()

                        Game_Step += 1
                        Game_Move += 1

                    End If

                End If
                _selected_card1(0) = ""
                _selected_card1(1) = ""
                _Condition_cardselected = False
            End If

        End If



    End Sub

    Public Sub row_move()

        Dim row As String = Selected_card1(0)

        Dim location As Integer = Selected_card1(1) - 1

        If row = "R1" Then
            Move_card(Row1.Count - location)
        ElseIf row = ("R2") Then
            Move_card(Row2.Count - location)
        ElseIf row = ("R3") Then
            Move_card(Row3.Count - location)
        ElseIf row = ("R4") Then
            Move_card(Row4.Count - location)
        ElseIf row = ("R5") Then
            Move_card(Row5.Count - location)
        ElseIf row = ("R6") Then
            Move_card(Row6.Count - location)
        ElseIf row = ("R7") Then
            Move_card(Row7.Count - location)
        Else
            Move_card(1)
        End If


    End Sub

    Private Function checkdeck() As Boolean


        Dim cardA As String
        Dim cardB As String

        Dim row As String = Selected_card1(0)
        Dim location As Integer = Selected_card1(1) - 1

        If row = "R1" Then
            cardA = Row1(location)
        ElseIf row = "R2" Then
            cardA = Row2(location)
        ElseIf row = ("R3") Then
            cardA = Row3(location)
        ElseIf row = ("R4") Then
            cardA = Row4(location)
        ElseIf row = ("R5") Then
            cardA = Row5(location)
        ElseIf row = ("R6") Then
            cardA = Row6(location)
        ElseIf row = ("R7") Then
            cardA = Row7(location)
        ElseIf row = ("R8") Then
            cardA = Row8(location)
        ElseIf row = ("R9") Then
            cardA = Row9(location)
        ElseIf row = ("R10") Then
            cardA = Row10(location)
        ElseIf row = ("R11") Then
            cardA = Row11(location)
        ElseIf row = ("TD") Then
            cardA = Deck_Open(location)
        End If

        row = Selected_card2(0)

        If row = "R1" And Row1.Count > 0 Then
            cardB = Row1(Row1.Count - 1)
        ElseIf row = "R2" And Row2.Count > 0 Then
            cardB = Row2(Row2.Count - 1)
        ElseIf row = ("R3") And Row3.Count > 0 Then
            cardB = Row3(Row3.Count - 1)
        ElseIf row = ("R4") And Row4.Count > 0 Then
            cardB = Row4(Row4.Count - 1)
        ElseIf row = ("R5") And Row5.Count > 0 Then
            cardB = Row5(Row5.Count - 1)
        ElseIf row = ("R6") And Row6.Count > 0 Then
            cardB = Row6(Row6.Count - 1)
        ElseIf row = ("R7") And Row7.Count > 0 Then
            cardB = Row7(Row7.Count - 1)
        ElseIf row = ("R8") And Row8.Count > 0 Then
            cardB = Row8(Row8.Count - 1)
        ElseIf row = ("R9") And Row9.Count > 0 Then
            cardB = Row9(Row9.Count - 1)
        ElseIf row = ("R10") And Row10.Count > 0 Then
            cardB = Row10(Row10.Count - 1)
        ElseIf row = ("R11") And Row11.Count > 0 Then
            cardB = Row11(Row11.Count - 1)
        ElseIf row = ("TD") And Deck_Open.Count > 0 Then
            cardB = Deck_Open(Deck_Open.Count - 1)
        End If

        If cardB = "" And card_to_num(cardA) = 1 Then
            Return True
        ElseIf cardB = "" Then
            Return False
        End If

        If CardCon(cardB, cardA) Then
            Return True
        Else
            Return False
        End If


    End Function

    Public Function checkmove()

        Dim cardA As String
        Dim cardB As String

        Dim row As String = Selected_card1(0)
        Dim location As Integer = Selected_card1(1) - 1

        If row = "R1" Then
            cardA = Row1(location)
        ElseIf row = "R2" Then
            cardA = Row2(location)
        ElseIf row = ("R3") Then
            cardA = Row3(location)
        ElseIf row = ("R4") Then
            cardA = Row4(location)
        ElseIf row = ("R5") Then
            cardA = Row5(location)
        ElseIf row = ("R6") Then
            cardA = Row6(location)
        ElseIf row = ("R7") Then
            cardA = Row7(location)
        ElseIf row = ("R8") Then
            cardA = Row8(location)
        ElseIf row = ("R9") Then
            cardA = Row9(location)
        ElseIf row = ("R10") Then
            cardA = Row10(location)
        ElseIf row = ("R11") Then
            cardA = Row11(location)
        ElseIf row = ("TD") Then
            cardA = Deck_Open(location)
        End If

        row = Selected_card2(0)

        If row = "R1" And Row1.Count > 0 Then
            cardB = Row1(Row1.Count - 1)
        ElseIf row = "R2" And Row2.Count > 0 Then
            cardB = Row2(Row2.Count - 1)
        ElseIf row = ("R3") And Row3.Count > 0 Then
            cardB = Row3(Row3.Count - 1)
        ElseIf row = ("R4") And Row4.Count > 0 Then
            cardB = Row4(Row4.Count - 1)
        ElseIf row = ("R5") And Row5.Count > 0 Then
            cardB = Row5(Row5.Count - 1)
        ElseIf row = ("R6") And Row6.Count > 0 Then
            cardB = Row6(Row6.Count - 1)
        ElseIf row = ("R7") And Row7.Count > 0 Then
            cardB = Row7(Row7.Count - 1)
        ElseIf row = ("R8") And Row8.Count > 0 Then
            cardB = Row8(Row8.Count - 1)
        ElseIf row = ("R9") And Row9.Count > 0 Then
            cardB = Row9(Row9.Count - 1)
        ElseIf row = ("R10") And Row10.Count > 0 Then
            cardB = Row10(Row10.Count - 1)
        ElseIf row = ("R11") And Row11.Count > 0 Then
            cardB = Row11(Row11.Count - 1)
        ElseIf row = ("TD") And Deck_Open.Count > 0 Then
            cardB = Deck_Open(Deck_Open.Count - 1)
        End If

        If cardB = "" And card_to_num(cardA) = 13 Then
            Return True
        ElseIf cardB = "" Then
            Return False
        End If

        If CardCon(cardA, cardB) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function CardCon(cardA As String, cardB As String)


        If card_to_num(cardA) - card_to_num(cardB) = -1 And card_to_char(cardA) = card_to_char(cardB) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function card_to_char(card As String)
        If card.Contains("A") Then
            Return "A"
        ElseIf card.Contains("J") Then
            Return "J"
        ElseIf card.Contains("Q") Then
            Return "J"
        ElseIf card.Contains("K") Then
            Return "J"
        End If

    End Function

    Public Function card_to_num(card As String)
        If card.Contains("A") Then
            Return 1
        ElseIf card.Contains("J") Then
            Return 11
        ElseIf card.Contains("Q") Then
            Return 12
        ElseIf card.Contains("K") Then
            Return 13

        End If
        If card.Length = 2 Then
            Return CInt(card.Substring(0, 1))
        End If
        If card.Length = 3 Then
            Return CInt(card.Substring(0, 2))
        End If

        Return 0
    End Function

    Public Sub Flip_card()

        If Row1.Count > 0 Then
            If Row1(Row1.Count - 1).Contains("F") Then
                Row1(Row1.Count - 1) = Row1(Row1.Count - 1).Replace("F", "")
            End If
        End If


        If Row2.Count > 0 Then
            If Row2(Row2.Count - 1).Contains("F") Then
                Row2(Row2.Count - 1) = Row2(Row2.Count - 1).Replace("F", "")
            End If
        End If


        If Row3.Count > 0 Then
            If Row3(Row3.Count - 1).Contains("F") Then
                Row3(Row3.Count - 1) = Row3(Row3.Count - 1).Replace("F", "")
            End If
        End If


        If Row4.Count > 0 Then
            If Row4(Row4.Count - 1).Contains("F") Then
                Row4(Row4.Count - 1) = Row4(Row4.Count - 1).Replace("F", "")
            End If
        End If


        If Row5.Count > 0 Then
            If Row5(Row5.Count - 1).Contains("F") Then
                Row5(Row5.Count - 1) = Row5(Row5.Count - 1).Replace("F", "")
            End If
        End If


        If Row6.Count > 0 Then
            If Row6(Row6.Count - 1).Contains("F") Then
                Row6(Row6.Count - 1) = Row6(Row6.Count - 1).Replace("F", "")
            End If
        End If


        If Row7.Count > 0 Then
            If Row7(Row7.Count - 1).Contains("F") Then
                Row7(Row7.Count - 1) = Row7(Row7.Count - 1).Replace("F", "")
            End If
        End If


        If Row8.Count > 0 Then
            If Row8(Row8.Count - 1).Contains("F") Then
                Row8(Row8.Count - 1) = Row8(Row8.Count - 1).Replace("F", "")
            End If
        End If


        If Row9.Count > 0 Then
            If Row9(Row9.Count - 1).Contains("F") Then
                Row9(Row9.Count - 1) = Row9(Row9.Count - 1).Replace("F", "")
            End If
        End If


        If Row10.Count > 0 Then
            If Row10(Row10.Count - 1).Contains("F") Then
                Row10(Row10.Count - 1) = Row10(Row10.Count - 1).Replace("F", "")
            End If
        End If


        If Row11.Count > 0 Then
            If Row11(Row11.Count - 1).Contains("F") Then
                Row11(Row11.Count - 1) = Row11(Row11.Count - 1).Replace("F", "")
            End If
        End If




    End Sub

    Public Sub Open_deck()
        If _Deck.Count = 0 Then
            _Deck.AddRange(_Deck_Open)
            _Deck_Open.Clear()
        Else
            _Deck_Open.Add(_Deck(0))
            _Deck.RemoveAt(0)
        End If
    End Sub


    Public Sub Hilight_card(card As String(), condition As Boolean)

        Dim location As Integer = card(1) - 1
        Dim row As String = card(0)

        If condition Then
            If row = ("R1") Then


                Dim temp As String
                temp = Row1(location)
                Row1.RemoveAt(location)
                Row1.Insert(location, temp + "WL")


            ElseIf row = ("R2") Then
                Dim temp As String
                temp = Row2(location)
                Row2.RemoveAt(location)
                Row2.Insert(location, temp + "WL")
            ElseIf row = ("R3") Then
                Dim temp As String
                temp = Row3(location)
                Row3.RemoveAt(location)
                Row3.Insert(location, temp + "WL")
            ElseIf row = ("R4") Then
                Dim temp As String
                temp = Row4(location)
                Row4.RemoveAt(location)
                Row4.Insert(location, temp + "WL")
            ElseIf row = ("R5") Then
                Dim temp As String
                temp = Row5(location)
                Row5.RemoveAt(location)
                Row5.Insert(location, temp + "WL")
            ElseIf row = ("R6") Then
                Dim temp As String
                temp = Row6(location)
                Row6.RemoveAt(location)
                Row6.Insert(location, temp + "WL")
            ElseIf row = ("R7") Then
                Dim temp As String
                temp = Row7(location)
                Row7.RemoveAt(location)
                Row7.Insert(location, temp + "WL")
            ElseIf row = ("R8") Then
                Dim temp As String
                temp = Row8(location)
                Row8.RemoveAt(location)
                Row8.Insert(location, temp + "WL")
            ElseIf row = ("R9") Then
                Dim temp As String
                temp = Row9(location)
                Row9.RemoveAt(location)
                Row9.Insert(location, temp + "WL")
            ElseIf row = ("R10") Then
                Dim temp As String
                temp = Row10(location)
                Row10.RemoveAt(location)
                Row10.Insert(location, temp + "WL")
            ElseIf row = ("R11") Then
                Dim temp As String
                temp = Row11(location)
                Row11.RemoveAt(location)
                Row11.Insert(location, temp + "WL")
            ElseIf row = ("TD") Then
                Dim temp As String
                temp = Deck_Open(location)
                Deck_Open.RemoveAt(location)
                Deck_Open.Insert(location, temp + "WL")
            End If
        Else
            If row = ("R1") Then
                Dim temp As String
                temp = Row1(location)
                Row1.RemoveAt(location)
                Row1.Insert(location, temp.Substring(0, temp.Length - 2))
            ElseIf row = ("R2") Then
                Dim temp As String
                temp = Row2(location)
                Row2.RemoveAt(location)
                Row2.Insert(location, temp.Substring(0, temp.Length - 2))
            ElseIf row = ("R3") Then
                Dim temp As String
                temp = Row3(location)
                Row3.RemoveAt(location)
                Row3.Insert(location, temp.Substring(0, temp.Length - 2))
            ElseIf row = ("R4") Then
                Dim temp As String
                temp = Row4(location)
                Row4.RemoveAt(location)
                Row4.Insert(location, temp.Substring(0, temp.Length - 2))
            ElseIf row = ("R5") Then
                Dim temp As String
                temp = Row5(location)
                Row5.RemoveAt(location)
                Row5.Insert(location, temp.Substring(0, temp.Length - 2))
            ElseIf row = ("R6") Then
                Dim temp As String
                temp = Row6(location)
                Row6.RemoveAt(location)
                Row6.Insert(location, temp.Substring(0, temp.Length - 2))
            ElseIf row = ("R7") Then
                Dim temp As String
                temp = Row7(location)
                Row7.RemoveAt(location)
                Row7.Insert(location, temp.Substring(0, temp.Length - 2))
            ElseIf row = ("R8") Then
                Dim temp As String
                temp = Row8(location)
                Row8.RemoveAt(location)
                Row8.Insert(location, temp.Substring(0, temp.Length - 2))
            ElseIf row = ("R9") Then
                Dim temp As String
                temp = Row9(location)
                Row9.RemoveAt(location)
                Row9.Insert(location, temp.Substring(0, temp.Length - 2))
            ElseIf row = ("R10") Then
                Dim temp As String
                temp = Row10(location)
                Row10.RemoveAt(location)
                Row10.Insert(location, temp.Substring(0, temp.Length - 2))
            ElseIf row = ("R11") Then
                Dim temp As String
                temp = Row11(location)
                Row11.RemoveAt(location)
                Row11.Insert(location, temp.Substring(0, temp.Length - 2))
            ElseIf row = ("TD") Then
                Dim temp As String
                temp = Deck_Open(location)
                Deck_Open.RemoveAt(location)
                Deck_Open.Insert(location, temp.Substring(0, temp.Length - 2))
            End If
        End If
    End Sub

    Public Function End_check()
        If (Row8.Count > 0 And Row9.Count > 0 And Row10.Count > 0 And Row11.Count > 0) Then
            If (Row8(Row8.Count - 1).contains("K") And Row9(Row9.Count - 1).contains("K") And Row10(Row10.Count - 1).contains("K") And Row11(Row11.Count - 1).contains("K")) Then
                Return True
            End If
        End If
        Return False
    End Function

End Class
