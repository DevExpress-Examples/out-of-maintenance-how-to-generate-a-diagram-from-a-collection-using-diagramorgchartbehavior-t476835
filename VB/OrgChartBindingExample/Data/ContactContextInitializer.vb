Imports System.Collections.Generic
Imports System.IO

Namespace OrgChartBindingExample.Model

    Public Class ContactContextInitializer

        Public Function Generate() As List(Of Contact)
            Dim contacts As List(Of Contact) = New List(Of Contact)() From {New Contact("Carolyn", "Baker") With {.Gender = Gender.Female, .Email = "carolyn.baker@example.com", .Phone = "(555)349-3010", .Address = "1198 Theresa Cir", .City = "Whitinsville", .State = "MA", .Zip = "01582", .ParentId = 0}, New Contact("Amber", "Seaman") With {.Gender = Gender.Female, .Phone = "(555)698-4285", .Address = "28700 S Main St", .City = "Wilsonville", .State = "AL", .Zip = "35188", .ParentId = 0}, New Contact("Annie", "Vicars") With {.Gender = Gender.Female, .Email = "annie.vicars@example.com", .Phone = "(555)922-1349", .Address = "7267 New York Ave", .City = "Jersey City", .State = "NJ", .Zip = "07306", .ParentId = 1}, New Contact("Darlene", "Catto") With {.Gender = Gender.Female, .Email = "darlene.catto@example.com", .Phone = "(555)752-0582", .Address = "32125 4th St NW #210", .City = "Washington", .State = "DC", .Zip = "20001", .ParentId = 2}, New Contact("Angela", "Gross") With {.Gender = Gender.Female, .Email = "angela.gross@example.com", .Phone = "(555)247-1252", .Address = "8723 Chicago Ave", .City = "Nederland", .State = "TX", .Zip = "77620", .ParentId = 2}, New Contact("Edward", "Keck") With {.Gender = Gender.Male, .Email = "edward.keck@example.com", .Phone = "410-7042", .Address = "38202 Greens Rd", .City = "Humble", .State = "TX", .Zip = "77397", .ParentId = 4}, New Contact("Angela", "Walker") With {.Gender = Gender.Female, .Email = "angela.walker@example.com", .Phone = "555", .Address = "8913 Lakeshore Dr", .City = "Jacksons Gap", .State = "AL", .Zip = "36863", .ParentId = 4}, New Contact("Alice", "Martin") With {.Gender = Gender.Female, .Email = "alice.martin@example.com", .Phone = "(555)493-8440", .Address = "652 Avonwick Gate", .City = "Toronto", .State = "ON", .Zip = "33125", .ParentId = 4}, New Contact("Andrew", "Carter") With {.Gender = Gender.Male, .Email = "andrew.carter@example.com", .Phone = "(555)578-3946", .Address = "7121 Bailey St", .City = "Worcester", .State = "MA", .Zip = "01605", .ParentId = 5}, New Contact("George", "Morrison") With {.Gender = Gender.Male, .Email = "george.morrison@example.com", .Phone = "(555)468-3668", .Address = "7716 Country Woods Cir", .City = "Kissimmee", .State = "FL", .Zip = "34747", .ParentId = 5}}
            InitializePhotos(contacts)
            contacts.ForEach(Sub(x) x.Id = contacts.IndexOf(x))
            Return contacts
        End Function

        Private Sub InitializePhotos(ByVal contacts As IList(Of Contact))
            For Each contact As Contact In contacts
                contact.Photo = GetPhoto(contact)
            Next
        End Sub

        Private Function GetPhoto(ByVal name As String) As Byte()
            Return File.ReadAllBytes("..\..\Images\" & name)
        End Function

        Private Function GetPhoto(ByVal contact As Contact) As Byte()
            Return GetPhoto(contact.FirstName & contact.LastName & ".jpg")
        End Function
    End Class
End Namespace
