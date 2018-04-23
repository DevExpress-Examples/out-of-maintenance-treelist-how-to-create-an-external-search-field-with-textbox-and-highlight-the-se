@Functions
    Private Function GetSearchText() As String
        Return If(ViewData("SearchText") IsNot Nothing, ViewData("SearchText").ToString(), "")
    End Function

End Functions

@Html.DevExpress().TreeList(Sub(settings)
	settings.Name = "TreeList"
	settings.SettingsBehavior.DisablePartialUpdate = True
	settings.KeyFieldName = "EmployeeID"
	settings.ParentFieldName = "ReportsTo"
	settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "TreeListPartial"}
	settings.CustomActionRouteValues = New With {Key .Controller = "Home", Key .Action = "TreeListCustomPartial"}
	settings.Columns.Add(Sub(col)
		col.FieldName = "FirstName"
		col.SetDataCellTemplateContent(Sub(t) ViewContext.Writer.Write(SearchHighlight.Models.TreeListHighlightHelper.GetCellText(t, GetSearchText())))
	End Sub)
	settings.ClientSideEvents.BeginCallback = "onTreeListBeginCallback"
	settings.BeforeGetCallbackResult = Sub(s, e)
		If ViewData("IsNewSearch") Is Nothing Then
    Return
    End If
    Dim treeList As MVCxTreeList = CType(s, MVCxTreeList)
    Dim [iterator] As New TreeListNodeIterator(treeList.RootNode)
    Do While [iterator].Current IsNot Nothing
			SearchHighlight.Models.TreeListHighlightHelper.CheckNode([iterator].Current, GetSearchText())
			[iterator].GetNext()
		Loop
    End Sub
    End Sub).Bind(Model).GetHtml()