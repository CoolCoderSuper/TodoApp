Imports System.Collections.ObjectModel
Imports FluentValidation.Results

Public Class MainPresenter
    Inherits BindableObject

    Private ReadOnly _persistenceProvider As ITodoPersistenceProvider
    Private ReadOnly _validationProvider As IValidationProvider
    Private _todoContent As String
    Private _selectedTodo As Todo

    Public Sub New(persistenceProvider As ITodoPersistenceProvider, validationProvider As IValidationProvider)
        _persistenceProvider = persistenceProvider
        _validationProvider = validationProvider
        For Each todo As Todo In persistenceProvider.Load()
            TodoList.Add(todo)
        Next
    End Sub

    <Obsolete("For designer only", True)>
    Public Sub New()

    End Sub

    Public Property TodoList As New ObservableCollection(Of Todo)

    Public Property SelectedTodo As Todo
        Get
            Return _selectedTodo
        End Get
        Set
            RaiseAndSetIfChanged(_selectedTodo, Value)
            TodoContent = Value?.Content
        End Set
    End Property

    Public Property TodoContent As String
        Get
            Return _todoContent
        End Get
        Set
            RaiseAndSetIfChanged(_todoContent, Value)
            Dim validator As New MainValidator
            Dim result As ValidationResult = validator.Validate(Me)
            If result.IsValid Then
                SelectedTodo.Content = Value
            End If
            _validationProvider.Validate(result)
        End Set
    End Property

    Public Sub Create()
        TodoList.Add(New Todo)
    End Sub

    Public Sub Delete()
        TodoList.Remove(SelectedTodo)
    End Sub

    Public Sub Save()
        _persistenceProvider.Save(TodoList.ToList())
    End Sub
End Class