Imports FluentValidation

Public Class MainValidator
    Inherits AbstractValidator(Of MainPresenter)

    Public Sub New()
        RuleFor(Function(x) x.TodoContent).NotEmpty()
    End Sub
End Class
