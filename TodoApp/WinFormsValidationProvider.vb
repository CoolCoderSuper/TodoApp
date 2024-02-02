Imports System.Linq.Expressions
Imports FluentValidation.Results
Imports TodoApp.Core

Public Class WinFormsValidationProvider
    Implements IValidationProvider

    Private ReadOnly _provider As ErrorProvider
    Private ReadOnly _controls As New Dictionary(Of String, Control)

    Public Sub New(provider As ErrorProvider)
        _provider = provider
    End Sub

    Public Sub Register(Of W)(source As Expression(Of Func(Of MainPresenter, W)), target As Control)
        Dim memberExpression As MemberExpression = source.Body
        _controls.Add(memberExpression.Member.Name, target)
    End Sub

    Public Sub Validate(result As ValidationResult) Implements IValidationProvider.Validate
        For Each control In _controls
            Dim res As ValidationFailure = result.Errors.FirstOrDefault(Function(e) e.PropertyName = control.Key)
            If res Is Nothing Then
                _provider.SetError(control.Value, "")
            Else
                _provider.SetError(control.Value, res.ErrorMessage)
            End If
        Next
    End Sub
End Class