Imports System.IO
Imports System.Text.Json

Public Class JsonTodoPersistenceProvider
    Implements ITodoPersistenceProvider

    Public Function Load() As List(Of Todo) Implements ITodoPersistenceProvider.Load
        Dim dir As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CodingCool", "TodoApp")
        If Not Directory.Exists(dir) Then
            Directory.CreateDirectory(dir)
        End If
        Dim todoFile As String = Path.Combine(dir, "todo.json")
        If Not File.Exists(todoFile) Then
            File.WriteAllText(todoFile, "[]")
        End If
        Dim json As String = File.ReadAllText(todoFile)
        Return JsonSerializer.Deserialize(Of List(Of Todo))(json)
    End Function

    Public Sub Save(todos As List(Of Todo)) Implements ITodoPersistenceProvider.Save
        Dim dir As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CodingCool", "TodoApp")
        Dim todoFile As String = Path.Combine(dir, "todo.json")
        Dim json As String = JsonSerializer.Serialize(todos)
        File.WriteAllText(todoFile, json)
    End Sub
End Class