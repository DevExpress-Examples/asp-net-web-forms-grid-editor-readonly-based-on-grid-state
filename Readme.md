<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128535020/22.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5116)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# ASPxGridView - How to make field editors read-only/editable when editing or adding a row
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/128535020/)**
<!-- run online end -->


<p>This example demonstrates how to set the editor's ReadOnly property based on the grid's state. That is, it is possible to edit a field value while adding a new row, but this editor becomes ReadOnly on an attempt to edit the existing row.</p>
<p><br>It is used the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_CellEditorInitializetopic"><u>ASPxGridView.CellEditorInitialize</u></a> event to implement this scenario:<br>Starting with version 14.2:</p>


```cs
protected void gridView_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e) {
	ASPxGridView grid = sender as ASPxGridView;
	if (e.Column.FieldName == "CategoryID")
		e.Editor.ReadOnly = !grid.IsNewRowEditing;
}
```


<p>For older versions:</p>


```cs
protected void gridView_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewEditorEventArgs e) {
	ASPxGridView grid = sender as ASPxGridView;
	if (e.Column.FieldName == "CategoryID")
		e.Editor.ReadOnly = !grid.IsNewRowEditing;
}
```


<p> </p>

<br/>


