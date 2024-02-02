Imports System.Linq.Expressions
Imports Avalonia.Controls
Imports FluentValidation.Results
Imports TodoApp.Core

Public Class AvaloniaValidationProvider
    Implements IValidationProvider

    Private ReadOnly _l As Label

    Public Sub New(l As Label)
        _l = l
    End Sub

    Public Sub Validate(result As ValidationResult) Implements IValidationProvider.Validate
        _l.Content = ""
        For Each e As ValidationFailure In result.Errors
            _l.Content = e.ErrorMessage
        Next
    End Sub
End Class