Imports Avalonia.Controls
Imports Avalonia.Markup.Xaml
Imports TodoApp.Core

Partial Public Class MainWindow
    Inherits Window

    Public Sub New()
        AvaloniaXamlLoader.Load(Me)
        Dim errorLabel As Label = FindControl(Of Label)("Error")
        DataContext = New MainPresenter(New JsonTodoPersistenceProvider, New AvaloniaValidationProvider(errorLabel))
    End Sub

End Class