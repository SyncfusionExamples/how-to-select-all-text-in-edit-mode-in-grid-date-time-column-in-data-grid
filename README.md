# How to select all text in edit mode in GridDateTimeColumn in DataGrid(SfDataGrid)?	

## About the sample
This example illustrates how to select all text in edit mode in GridDateTimeColumn in DataGrid(SfDataGrid)?

By default, SfDataGrid  enters into edit mode in GridDateTimeColumn the entire text is not selected. You can achieve this by customizing the GridDateTimeCellRenderer.

```C#
this.sfDataGridSample.CellRenderers.Remove("DateTime"); this.sfDataGridSample.CellRenderers.Add("DateTime", new CustomDateTimeEdit(this.sfDataGridSample));

public class CustomDateTimeEdit : GridDateTimeCellRenderer
{
     public CustomDateTimeEdit(SfDataGrid dataGrid)
     {
        DataGrid = dataGrid;
     }

     /// <summary>
     /// Gets or sets to specify the datagrid.
     /// </summary>
     protected SfDataGrid DataGrid { get; set; }

     protected override void OnInitializeEditElement(DataColumnBase column, RowColumnIndex rowColumnIndex, SfDateTimeEdit uiElement)
     {
         base.OnInitializeEditElement(column, rowColumnIndex, uiElement);

         if (DataGrid.CurrentCell != null)
         {
            if (DataGrid.CurrentCell.CellRenderer != null)
            {
                var editingTextBox = (uiElement as SfDateTimeEdit).GetType().GetProperty("EditingTextBox", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                (editingTextBox.GetValue(uiElement) as RichTextBox).Focus();
                (editingTextBox.GetValue(uiElement) as RichTextBox).SelectAll();
            }
         }
     }
}
```

## Requirements to run the demo
Visual Studio 2015 and above versions
