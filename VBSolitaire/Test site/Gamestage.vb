Public Class Gamestage

    Dim Full_Card() As String = {"AC", "AD", "AH", "AS", "2C", "2D", "2H", "2S", "3C", "3D", "3H", "3S", "4C", "4D", "4H", "4S", "5C", "5D", "5H", "5S", "6C", "6D", "6H", "6S", "7C", "7D", "7H", "7S", "8C", "8D", "8H", "8S", "9C", "9D", "9H", "9S", "10C", "10D", "10H", "10S", "JC", "JD", "JH", "JS", "QC", "QD", "QH", "QS", "KC", "KD", "KH", "KS"}
    Dim PulledPool() As String
    Dim _Row1() As String
    Dim _Row2() As String
    Dim _Row3() As String
    Dim _Row4() As String
    Dim _Row5() As String
    Dim _Row6() As String
    Dim _Row7() As String

    Dim _Deck() As String
    Dim _Deck_Open() As String

    Dim _FillC() As String
    Dim _FillS() As String
    Dim _FillH() As String
    Dim _FillD() As String

    Public Sub New()

    End Sub

    Public Sub Load()

    End Sub

    Public Property Row1 As String()
        Get
            Return _Row1
        End Get
        Set(value As String())
            _Row1 = value
        End Set
    End Property

    Public Property Row2 As String()
        Get
            Return _Row2
        End Get

        Set(value As String())
            _Row2 = value
        End Set

    End Property

    Public Property Row3 As String()
        Get
            Return _Row3
        End Get
        Set(value As String())
            _Row3 = value
        End Set
    End Property

    Public Property Row4 As String()
        Get
            Return _Row4
        End Get
        Set(value As String())
            _Row4 = value
        End Set
    End Property

    Public Property Row5 As String()
        Get
            Return _Row5
        End Get
        Set(value As String())
            _Row5 = value
        End Set
    End Property

    Public Property Row6 As String()
        Get
            Return _Row6
        End Get
        Set(value As String())
            _Row6 = value
        End Set
    End Property

    Public Property Row7 As String()
        Get
            Return _Row7
        End Get
        Set(value As String())
            _Row7 = value
        End Set
    End Property

    Public Property Deck As String()
        Get
            Return _Deck
        End Get
        Set(value As String())
            _Deck = value
        End Set
    End Property

    Public Property Deck_Open As String()
        Get
            Return _Deck_Open
        End Get
        Set(value As String())
            _Deck_Open = value
        End Set
    End Property

    Public Property FillC As String()
        Get
            Return _FillC
        End Get
        Set(value As String())
            _FillC = value
        End Set
    End Property

    Public Property FillS As String()
        Get
            Return _FillS
        End Get
        Set(value As String())
            _FillS = value
        End Set
    End Property

    Public Property FillH As String()
        Get
            Return _FillH
        End Get
        Set(value As String())
            _FillH = value
        End Set
    End Property

    Public Property FillD As String()
        Get
            Return _FillD
        End Get
        Set(value As String())
            _FillD = value
        End Set
    End Property



    Public Sub Generate_Game()

        PulledPool = Full_Card

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

        Dim out(num) As String
        For Each i In out
            Dim rannum As Integer = rng.Next(0, PulledPool.Length() - 1)
            i = PulledPool(rannum)
            PulledPool = Filter(PulledPool, i, False)
        Next

        If deck_name = "Row1" Then
            _Row1 = out
        ElseIf deck_name = "Row2" Then
            _Row2 = out
        ElseIf deck_name = "Row3" Then
            _Row3 = out
        ElseIf deck_name = "Row4" Then
            _Row4 = out
        ElseIf deck_name = "Row5" Then
            _Row5 = out
        ElseIf deck_name = "Row6" Then
            _Row6 = out
        ElseIf deck_name = "Row7" Then
            _Row7 = out
        ElseIf deck_name = "Deck" Then
            _Deck = out
        End If

    End Sub

    Public Sub Move(PosA As String, PosB As String)



    End Sub

    Public Function checkmove(deck_name As String)

        Return True
        Return False
    End Function
    Public Sub Display()
        DisplayPerRow(1)
        DisplayPerRow(2)
        DisplayPerRow(3)
        DisplayPerRow(4)
        DisplayPerRow(5)
        DisplayPerRow(6)
        DisplayPerRow(7)
        DisplayDeck()
        DisplayDeckopen()
        DisplayFill("C")
        DisplayFill("S")
        DisplayFill("H")
        DisplayFill("D")

    End Sub

    Public Sub DisplayPerRow(Row As String)


    End Sub

    Public Sub DisplayDeck()


    End Sub

    Public Sub DisplayDeckopen()


    End Sub

    Public Sub DisplayFill(Row As String)


    End Sub

End Class
