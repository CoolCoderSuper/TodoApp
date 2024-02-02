Public Class Todo
    Inherits BindableObject

    Private _id As String
    Private _content As String

    Public Sub New()
        Id = Guid.NewGuid().ToString()
        Content = ""
    End Sub

    Public Sub New(id As String, content As String)
        Me.Id = id
        Me.Content = content
    End Sub

    Public Property Id As String
        Get
            Return _id
        End Get
        Set
            RaiseAndSetIfChanged(_id, Value)
        End Set
    End Property

    Public Property Content As String
        Get
            Return _content
        End Get
        Set
            RaiseAndSetIfChanged(_content, Value)
        End Set
    End Property
End Class