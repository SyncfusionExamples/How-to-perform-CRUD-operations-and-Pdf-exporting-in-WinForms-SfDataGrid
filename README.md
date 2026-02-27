# How-to-perform-CRUD-operations-and-Pdf-exporting-in-WinForms-SfDataGrid

The [Winforms DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid) (SfDatagrid) listens and responds to the CRUD operations such as add, delete and data update (property change) at runtime. DataGrid automatically refresh the UI when rows are added, deleted or cleared.

**C#**
```
//Adding the record

var inlineForm = new InlineForm(null);
inlineForm.StartPosition = FormStartPosition.CenterParent;
inlineForm.ShowDialog();
var sourceCollection = this.sfDataGrid.DataSource as ObservableCollection<OrderInfo>;
if (inlineForm.RowData != null)
{
    sourceCollection.Add(inlineForm.RowData);
}


//Deleting the record

if (this.sfDataGrid.SelectedItems.Count > 0)
{
    this.sfDataGrid.DeleteSelectedRecords();
}


//Updating the record

var rowIndex = this.sfDataGrid.TableControl.ResolveToRowIndex(this.sfDataGrid.SelectedItem);
var recordIndex = this.sfDataGrid.TableControl.ResolveToRecordIndex(rowIndex);
var inlineForm = new InlineForm((OrderInfo)this.sfDataGrid.SelectedItem);
inlineForm.StartPosition = FormStartPosition.CenterParent;
inlineForm.ShowDialog();
this.sfDataGrid.View.GetRecordAt(recordIndex).Data = inlineForm.RowData;
this.sfDataGrid.View.Refresh();
```

You can also export data to a PDF file. DataGrid also provides support for grouping, filtering, sorting, unbound rows and stacked headers while exporting.

**C#**
```
var document = this.sfDataGrid.ExportToPdf();
string filePath = "Sample.pdf";
document.Save(filePath);

// Open the PDF file using the default viewer
System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
{
    FileName = filePath,
    UseShellExecute = true
});
```

![CRUD Operation and Exporting](CRUD%20Operation%20and%20Exporting.gif)

Take a moment to peruse the [WinForms DataGrid - Data Manipulation](https://help.syncfusion.com/windowsforms/datagrid/datamanipulation) and [Export to PDF](https://help.syncfusion.com/windowsforms/datagrid/exporttopdf) documentation, to learn more about data manipulation and exporting with examples.