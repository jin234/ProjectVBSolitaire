Public Class Gamestage

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

    Dim _FillC As New ArrayList
    Dim _FillS As New ArrayList
    Dim _FillH As New ArrayList
    Dim _FillD As New ArrayList

    Dim _Condition_cardselected As Boolean
    Dim _selected_card1() As String
    Dim _selected_card2() As String

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

    Public Property FillC As ArrayList
        Get
            Return _FillC
        End Get
        Set(value As ArrayList)
            _FillC = value
        End Set
    End Property

    Public Property FillS As ArrayList
        Get
            Return _FillS
        End Get
        Set(value As ArrayList)
            _FillS = value
        End Set
    End Property

    Public Property FillH As ArrayList
        Get
            Return _FillH
        End Get
        Set(value As ArrayList)
            _FillH = value
        End Set
    End Property

    Public Property FillD As ArrayList
        Get
            Return _FillD
        End Get
        Set(value As ArrayList)
            _FillD = value
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

    Public Sub New()

    End Sub

    Public Sub Load()

    End Sub



    Public Sub Generate_Game()

        PulledPool.AddRange(Full_Card)

        Pull_from_Deck(1, "Row1")
        Pull_from_Deck(2, "Row2")
        Pull_from_Deck(3, "Row3")
        Pull_from_Deck(4, "Row4")
        Pull_from_Deck(5, "Row5")
        Pull_from_Deck(6, "Row6")
        Pull_from_Deck(7, "Row7")
        Deck = PulledPool
        'Pull_from_Deck(24, "Deck")

    End Sub

    Public Sub Pull_from_Deck(num As Integer, deck_name As String)
        Dim rng As New Random()

        Dim out As New ArrayList

        For i = 0 To num - 1
            Dim rannum As Integer = rng.Next(0, PulledPool.Count)
            out.Add(PulledPool(rannum))
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

    Public Sub Move_card()
        Dim temp As String
        Dim row As String = Selected_card1(0)
        Dim location As Integer = Selected_card1(1) - 1
        If row = "R1" Then
            temp = Row1(location)
            Row1.RemoveAt(location)
        ElseIf row = "R2" Then
            temp = Row1(location)
            Row2.RemoveAt(location)
        ElseIf row = ("R3") Then
            temp = Row1(location)
            Row3.RemoveAt(location)
        ElseIf row = ("R4") Then
            temp = Row1(location)
            Row4.RemoveAt(location)
        ElseIf row = ("R5") Then
            temp = Row1(location)
            Row5.RemoveAt(location)
        ElseIf row = ("R6") Then
            temp = Row1(location)
            Row6.RemoveAt(location)
        ElseIf row = ("R7") Then
            temp = Row1(location)
            Row7.RemoveAt(location)
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
        End If

    End Sub

    Public Sub card_selected(card As String())

        If _Condition_cardselected = False Then
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
                _Condition_cardselected = False
                Move_card()
                _selected_card1(0) = ""
                _selected_card1(1) = ""
            End If
        End If
    End Sub

    Public Function checkmove(deck_name As String)

        Return True
        Return False
    End Function

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
                Row2.Insert(location, temp.TrimEnd("WL"))
            ElseIf row = ("R3") Then
                Dim temp As String
                temp = Row3(location)
                Row3.RemoveAt(location)
                Row3.Insert(location, temp.TrimEnd("WL"))
            ElseIf row = ("R4") Then
                Dim temp As String
                temp = Row4(location)
                Row4.RemoveAt(location)
                Row4.Insert(location, temp.TrimEnd("WL"))
            ElseIf row = ("R5") Then
                Dim temp As String
                temp = Row5(location)
                Row5.RemoveAt(location)
                Row5.Insert(location, temp.TrimEnd("WL"))
            ElseIf row = ("R6") Then
                Dim temp As String
                temp = Row6(location)
                Row6.RemoveAt(location)
                Row6.Insert(location, temp.TrimEnd("WL"))
            ElseIf row = ("R7") Then
                Dim temp As String
                temp = Row7(location)
                Row7.RemoveAt(location)
                Row7.Insert(location, temp.TrimEnd("WL"))
            End If
        End If
    End Sub

End Class
