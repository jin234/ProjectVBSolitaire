Public Class Gamestage
    Dim Full_Card As String = {"AC", "AD", "AH", "AS",}
    Dim _Row1() As String
    Dim _Row2() As String
    Dim _Row3() As String
    Dim _Row4() As String
    Dim _Row5() As String
    Dim _Row6() As String
    Dim _Row7() As String

    Dim _Deck() As String

    Dim _FillC() As String
    Dim _FillS() As String
    Dim _FillH() As String
    Dim _FillD() As String

    Public Sub New()

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

    Public Sub Random()


    End Sub

    Public Sub Move(PosA As String, PosB As String)


    End Sub

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
