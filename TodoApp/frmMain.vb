Imports System.Collections.ObjectModel
Imports TodoApp.Core

Public Class frmMain
    Private _validation As WinFormsValidationProvider
    Private _presenter As MainPresenter

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        _validation = New WinFormsValidationProvider(ErrorProvider1)
        _presenter = New MainPresenter(New JsonTodoPersistenceProvider, _validation)
        _validation.Register(Function(p) p.TodoContent, txtNote)
        dgvTodo.DataSource = _presenter.TodoList
        dgvTodo.Columns("Id").Visible = False
        txtNote.DataBindings.Add("Text", _presenter, "TodoContent", False, DataSourceUpdateMode.OnPropertyChanged)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        _presenter.Create()
        dgvTodo.DataSource = New ObservableCollection(Of Todo)(_presenter.TodoList)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        _presenter.Save()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        _presenter.Delete()
    End Sub

    Private Sub dgvTodo_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTodo.SelectionChanged
        If dgvTodo.SelectedRows.Count = 0 Then
            Return
        End If
        _presenter.SelectedTodo = _presenter.TodoList(dgvTodo.SelectedRows(0).Index)
    End Sub
End Class