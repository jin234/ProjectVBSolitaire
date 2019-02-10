Public Class card

    Dim _CardName As String
    Dim _CardPicture As String
    Dim _CardPosition As String

    Public Sub New()
        CardName = ""
        CardPicture = ""
        CardPosition = ""
    End Sub

    Public Property CardName As String
        Get
            Return _CardName
        End Get
        Set(value As String)
            _CardName = value
        End Set
    End Property

    Public Property CardPicture As String
        Get
            Return _CardPicture
        End Get
        Set(value As String)
            _CardPicture = value
        End Set
    End Property

    Public Property CardPosition As String
        Get
            Return _CardPosition
        End Get
        Set(value As String)
            _CardPosition = value
        End Set
    End Property

    Public Sub movecard()

    End Sub


End Class
