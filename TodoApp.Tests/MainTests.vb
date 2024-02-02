Imports FakeItEasy
Imports FluentAssertions
Imports FluentValidation.Results
Imports TodoApp.Core
Imports Xunit

Public Class MainTests
    Private ReadOnly _presenter As MainPresenter
    Private ReadOnly _persistence As ITodoPersistenceProvider
    Private ReadOnly _validation As IValidationProvider

    Public Sub New()
        _persistence = A.Fake(Of ITodoPersistenceProvider)()
        _validation = A.Fake(Of IValidationProvider)()
        A.CallTo(Function() _persistence.Load()).Returns(New List(Of Todo)())
        _presenter = New MainPresenter(_persistence, _validation)
    End Sub

    <Fact>
    Public Sub CreateTest()
        Dim c As Integer = _presenter.TodoList.Count
        _presenter.Create()
        _presenter.TodoList.Should().HaveCountGreaterThan(c)
    End Sub

    <Fact>
    Public Sub DeleteTest()
        Dim c As Integer = _presenter.TodoList.Count
        _presenter.Create()
        _presenter.SelectedTodo = _presenter.TodoList.Last()
        _presenter.SelectedTodo.Should().Be(_presenter.TodoList.Last())
        _presenter.Delete()
        _presenter.TodoList.Should().HaveCount(c)
    End Sub

    <Fact>
    Public Sub SelectionTest()
        _presenter.Create()
        _presenter.SelectedTodo = _presenter.TodoList.Last()
        _presenter.SelectedTodo.Should().Be(_presenter.TodoList.Last())
    End Sub

    <Fact>
    Public Sub ContentTest()
        _presenter.Create()
        _presenter.SelectedTodo = _presenter.TodoList.Last()
        _presenter.TodoContent = "test"
        _presenter.SelectedTodo.Content.Should().Be("test")
    End Sub

    <Fact>
    Public Sub SaveTest()
        _presenter.Create()
        _presenter.SelectedTodo = _presenter.TodoList.Last()
        _presenter.TodoContent = "test"
        _presenter.Save()
        A.CallTo(Sub() _persistence.Save(A(Of List(Of Todo)).Ignored)).MustHaveHappened()
    End Sub

    <Fact>
    Public Sub EmptyContentTest()
        _presenter.Create()
        _presenter.TodoList.Last().Content = "test"
        _presenter.SelectedTodo = _presenter.TodoList.Last()
        _presenter.TodoContent = ""
        A.CallTo(Sub() _validation.Validate(A(Of ValidationResult).Ignored)).WhenArgumentsMatch(Function(x) Not DirectCast(x.First(), ValidationResult).IsValid).MustHaveHappened()
    End Sub
End Class