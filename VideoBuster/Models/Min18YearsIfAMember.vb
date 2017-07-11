
Imports System.ComponentModel.DataAnnotations
Namespace Models
    Public Class Min18YearsIfAMember
        Inherits ValidationAttribute

        Protected Overrides Function isValid(value As Object, ValidationContext As ValidationContext) As ValidationResult
            Dim customer = DirectCast(ValidationContext.ObjectInstance, Customer)
            If customer.MembershipTypeid = 1 Then
                Return ValidationResult.Success
            End If
            If customer.Birthdate Is Nothing Then
                Return New ValidationResult("Birthday is required.")
            End If
            Dim age = DateTime.Today.Year - customer.Birthdate.Value.Year
            Return If((age >= 18), ValidationResult.Success, New ValidationResult("You need to be at least 18 years old"))
        End Function
    End Class
End Namespace
