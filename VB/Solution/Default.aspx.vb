Imports DevExpress.Web
Imports System

Namespace Solution

    Public Partial Class [Default]
        Inherits Web.UI.Page

        Protected Sub gridView_CellEditorInitialize(ByVal sender As Object, ByVal e As ASPxGridViewEditorEventArgs)
            Dim grid As ASPxGridView = TryCast(sender, ASPxGridView)
            If Equals(e.Column.FieldName, "CategoryID") Then e.Editor.ReadOnly = Not grid.IsNewRowEditing
        End Sub
    End Class
End Namespace
