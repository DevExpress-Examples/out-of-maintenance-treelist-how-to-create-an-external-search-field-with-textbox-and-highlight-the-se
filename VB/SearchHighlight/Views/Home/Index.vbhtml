@Code
    ViewBag.Title = "Index"
End Code
<style type="text/css">
    .highlight {
        background-color: #99FF66;
    }
    .inline-editor {
        float: left;
        margin-right: 1em;
    }
</style>

<h2>How to create an external search field with a TextBox and highlight the search text</h2>

<div style="margin-bottom: 1em;">
    @Html.DevExpress().TextBox(Sub(settings)
    settings.Name = "SearchText"
    settings.Properties.NullText = "Search ..."
    settings.Width = Unit.Pixel(120)
    settings.ControlStyle.CssClass = "inline-editor"
End Sub).GetHtml()
    @Html.DevExpress().Button(Sub(settings)
	settings.Name = "SearchButton"
	settings.Text = "Search"
	settings.ControlStyle.CssClass = "inline-editor"
	settings.ClientSideEvents.Click = "onSearchButtonClick"
End Sub).GetHtml()
    <div style="clear:both;"></div>
</div>


@Html.Action("TreeListPartial")