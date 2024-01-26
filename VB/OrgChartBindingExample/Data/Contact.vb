Imports DevExpress.Mvvm.DataAnnotations
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Namespace OrgChartBindingExample.Model

    Public Class Contact

        <[ReadOnly](True)>
        <Display(AutoGenerateField:=False)>
        Public Property Id As Integer

        <Display(GroupName:="General Info", AutoGenerateField:=False)>
        Public Property Gender As Gender

        <Display(GroupName:="General Info")>
        <Required>
        <MaxLength(25, ErrorMessage:="Value is too long")>
        Public Property FirstName As String

        <Display(GroupName:="General Info")>
        <Required>
        Public Property LastName As String

        <Display(GroupName:="General Info")>
        <DisplayFormat(NullDisplayText:="<empty>")>
        <CreditCard>
        Public Property CreditCardNumber As String

        <Display(GroupName:="Contacts")>
        <DisplayFormat(NullDisplayText:="<empty>")>
        <DataType(DataType.EmailAddress)>
        Public Property Email As String

        <Display(GroupName:="Contacts")>
        <DataType(DataType.PhoneNumber)>
        <DisplayFormat(NullDisplayText:="<empty>")>
        Public Property Phone As String

        <Display(GroupName:="Address")>
        <DisplayFormat(NullDisplayText:="<empty>")>
        Public Property Address As String

        <Display(GroupName:="Address")>
        <DisplayFormat(NullDisplayText:="<empty>")>
        <RegExMask(Mask:="\w{1,25}", UseAsDisplayFormat:=True, ShowPlaceHolders:=False)>
        Public Property City As String

        <Display(GroupName:="Address")>
        <DisplayFormat(NullDisplayText:="<empty>")>
        Public Property State As String

        <Display(GroupName:="Address")>
        <DisplayFormat(NullDisplayText:="<empty>")>
        Public Property Zip As String

        <Display(AutoGenerateField:=False)>
        <DisplayFormat(NullDisplayText:="<empty>")>
        Public Property Photo As Byte()

        <[ReadOnly](True)>
        <Display(AutoGenerateField:=False)>
        Public Property ParentId As Integer

        Public Sub New()
        End Sub

        Public Sub New(ByVal firstName As String, ByVal lastName As String)
            Me.FirstName = firstName
            Me.LastName = lastName
        End Sub
    End Class
End Namespace
