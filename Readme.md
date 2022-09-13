<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128535020/22.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5116)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Grid View for ASP.NET WebForms - How to conditionally make cell editors read-only
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/128535020/)**
<!-- run online end -->

## Implementation Details

This example demonstrates how to set a grid cell editor's `ReadOnly` property based on the grid's state. The example application allows you to edit a field value in a new row, but the editor becomes read-only when you try to edit an existing row.

The ReadOnly property is set in the [ASPxGridView.CellEditorInitialize](http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_CellEditorInitializetopic) event handler based on the value of the [IsNewRowEditing](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridView.IsNewRowEditing) property.

```cs
protected void gridView_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e) {
	ASPxGridView grid = sender as ASPxGridView;
	if (e.Column.FieldName == "CategoryID")
		e.Editor.ReadOnly = !grid.IsNewRowEditing;
}
```

## Files to Look At

- [Default.aspx](./CS/Solution/Default.aspx) (VB: [Default.aspx](./VB/Solution/Default.aspx))
- [Default.aspx.cs](./CS/Solution/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Solution/Default.aspx.vb))

## Documentation

- [Edit Data](https://docs.devexpress.com/AspNet/3712/components/grid-view/concepts/edit-data)

## More Examples

-[Grid View for ASP.NET WebForms - How to assign calculated values to the Edit Form on the client and server sides](https://github.com/DevExpress-Examples/aspxgridview-set-edit-form-values)