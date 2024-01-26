Imports DevExpress.Mvvm
Imports OrgChartBindingExample.Model
Imports System.Collections.Generic

Namespace OrgChartBindingExample.ViewModels

    Public Class MainViewModel
        Inherits ViewModelBase

        Private _Contacts As IList(Of OrgChartBindingExample.Model.Contact)

        Public Property Contacts As IList(Of Contact)
            Get
                Return _Contacts
            End Get

            Protected Set(ByVal value As IList(Of Contact))
                _Contacts = value
            End Set
        End Property

        Public Sub New()
            If Not IsInDesignMode Then
                InitializeInRuntime()
            Else
                InitializeInDesingMode()
            End If
        End Sub

        Private Sub InitializeInRuntime()
            Contacts = New ContactContextInitializer().Generate()
        End Sub

        Private Sub InitializeInDesingMode()
            Contacts = New List(Of Contact)() From {New Contact("FirstName", "LastName") With {.Gender = Gender.Female, .Email = "email", .Phone = "(555)555-0000", .Address = "Address", .City = "City", .State = "AA", .Zip = "11111"}}
        End Sub
    End Class
End Namespace
