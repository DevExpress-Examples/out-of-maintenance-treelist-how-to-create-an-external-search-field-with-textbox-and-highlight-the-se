Imports DevExpress.Web.ASPxTreeList
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace SearchHighlight.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function

		Private db As New Models.NORTHWNDEntities()
		Public Function TreeListPartial(ByVal SearchText As String) As ActionResult
			ViewData("SearchText") = SearchText
			Return PartialView("_TreeListPartial", db.Employees.ToList())
		End Function

		Public Function TreeListCustomPartial(ByVal SearchText As String, ByVal isNewSearch? As Boolean) As ActionResult
			ViewData("IsNewSearch") = isNewSearch
			ViewData("SearchText") = SearchText
			Return PartialView("_TreeListPartial", db.Employees.ToList())
		End Function
	End Class
End Namespace