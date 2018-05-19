Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxGridView

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub gridView_CellEditorInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewEditorEventArgs)
		Dim grid As ASPxGridView = TryCast(sender, ASPxGridView)
		If e.Column.FieldName = "CategoryID" Then
			e.Editor.ReadOnly = Not grid.IsNewRowEditing
		End If
	End Sub

End Class