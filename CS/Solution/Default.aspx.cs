using DevExpress.Web;
using System;

namespace Solution {
    public partial class Default : System.Web.UI.Page {
        protected void gridView_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e) {
            ASPxGridView grid = sender as ASPxGridView;
            if (e.Column.FieldName == "CategoryID")
                e.Editor.ReadOnly = !grid.IsNewRowEditing;
        }
    }
}