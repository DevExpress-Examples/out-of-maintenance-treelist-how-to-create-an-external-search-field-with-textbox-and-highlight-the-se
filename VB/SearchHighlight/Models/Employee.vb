﻿Imports System.Collections.Generic
Imports System

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace SearchHighlight.Models

	Partial Public Class Employee
		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")>
		Public Sub New()
			Me.Employees1 = New HashSet(Of Employee)()
		End Sub

		Public Property EmployeeID() As Integer
		Public Property LastName() As String
		Public Property FirstName() As String
		Public Property Title() As String
		Public Property TitleOfCourtesy() As String
		Public Property BirthDate() As Date?
		Public Property HireDate() As Date?
		Public Property Address() As String
		Public Property City() As String
		Public Property Region() As String
		Public Property PostalCode() As String
		Public Property Country() As String
		Public Property HomePhone() As String
		Public Property Extension() As String
		Public Property Photo() As Byte()
		Public Property Notes() As String
		Public Property ReportsTo() As Integer?
		Public Property PhotoPath() As String

		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")>
		Public Overridable Property Employees1() As ICollection(Of Employee)
		Public Overridable Property Employee1() As Employee
	End Class
End Namespace
