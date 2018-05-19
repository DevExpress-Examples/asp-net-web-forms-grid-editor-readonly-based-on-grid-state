using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxGridView;

public partial class _Default: System.Web.UI.Page {

    protected void gridView_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewEditorEventArgs e) {
        ASPxGridView grid = sender as ASPxGridView;
        if (e.Column.FieldName == "CategoryID")
            e.Editor.ReadOnly = !grid.IsNewRowEditing;
    }

}