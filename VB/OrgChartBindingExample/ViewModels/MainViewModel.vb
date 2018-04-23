Imports OrgChartBindingExample.Model
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq

Namespace OrgChartBindingExample.ViewModels
	<POCOViewModel>
	Public Class MainViewModel

		Private privateContacts As IList(Of Contact)
		Public Overridable Property Contacts() As IList(Of Contact)
			Get
				Return privateContacts
			End Get
			Protected Set(ByVal value As IList(Of Contact))
				privateContacts = value
			End Set
		End Property

		Protected Sub New()

			If Not ViewModelBase.IsInDesignMode Then
				InitializeInRuntime()
			Else
				InitializeInDesingMode()
			End If
		End Sub
		Private Sub InitializeInRuntime()

			Contacts = (New ContactContextInitializer()).Generate()
		End Sub
		Private Sub InitializeInDesingMode()
			Contacts = New List(Of Contact)() From {
				New Contact("FirstName", "LastName") With {.Gender = Gender.Female, .Email = "email", .Phone = "(555)555-0000", .Address = "Address", .City = "City", .State = "AA", .Zip = "11111"}
			}
		End Sub
	End Class
End Namespace