Imports DevExpress.Web.ASPxTreeList
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Web

Namespace SearchHighlight.Models
	Public Class TreeListHighlightHelper
		Public Shared Function GetCellText(ByVal container As TreeListDataCellTemplateContainer, ByVal searchText As String) As String
			Dim cell_text As String = container.Text
			If searchText.Length > cell_text.Length Then
				Return cell_text
			End If
			If searchText <> "" Then
				Dim cell_text_lower As String = cell_text.ToLower()
				Dim serchText_lower As String = searchText.ToLower()

				Dim start_pos As Integer = cell_text_lower.IndexOf(serchText_lower)
				If start_pos >= 0 Then
					Dim builder As New StringBuilder()
					builder.Append(cell_text.Substring(0, start_pos))
					builder.Append(String.Format("<span class='highlight'>{0}</span>", cell_text.Substring(start_pos, searchText.Length)))
					builder.Append(cell_text.Substring(start_pos + searchText.Length))
					cell_text = builder.ToString()
				End If
			End If
			Return cell_text
		End Function

		Public Shared Sub CheckNode(ByVal node As TreeListNode, ByVal searchText As String)
			Dim node_value As Object = node.GetValue("FirstName")
			If node_value Is Nothing Then
				Return
			End If
			If node_value.ToString().ToLower().IndexOf(searchText.ToLower()) >= 0 Then
				node.MakeVisible()
			End If
		End Sub
	End Class
End Namespace