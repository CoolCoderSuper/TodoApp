Public Interface ITodoPersistenceProvider
    Function Load() As List(Of Todo)
    Sub Save(todos As List(Of Todo))
End Interface
