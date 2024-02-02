Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class BindableObject
    Implements INotifyPropertyChanged

    Public Sub RaiseAndSetIfChanged(Of T)(ByRef field As T, value As T, <CallerMemberName> Optional propertyName As String = "")
        If Not EqualityComparer(Of T).Default.Equals(field, value) Then
            field = value
            RaiseNotifyPropertyChanged(propertyName)
        End If
    End Sub

    Public Sub RaiseNotifyPropertyChanged(propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class