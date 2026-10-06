# How to perform CRUD operations and PDF exporting in WinForms Data Grid

This sample demonstrates how to perform CRUD operations such as add, delete, and update records in the [WinForms Data Grid](https://www.syncfusion.com/winforms-ui-controls/datagrid) control, and then export the grid data to a PDF document.

The sample project is available in the `SfDataGridDemo` folder and includes a `Data Grid` bound to an `ObservableCollection<OrderInfo>` along with a custom inline form for adding and editing records.

## Features

- Add a new record using a dialog form
- Delete the selected record from the Data Grid
- Update the selected record using a dialog form
- Export the Data Grid data to a PDF file

## Sample overview

The project uses the `Data Grid` control to display order information and exposes buttons for each operation:

- Add
- Delete
- Update
- Export to PDF

![CRUD Operation and Exporting](CRUD%20Operation%20and%20Exporting.gif)

## Project structure

- `SfDataGridDemo/SfDataGridDemo.sln` – Visual Studio solution file
- `SfDataGridDemo/SfDataGridDemo.csproj` – Project file
- `SfDataGridDemo/Form1.cs` – Main form and Data Grid logic
- `SfDataGridDemo/InlineForm.cs` – Add/edit dialog form
- `SfDataGridDemo/Model/Model.cs` – Data model
- `SfDataGridDemo/ViewModel/ViewModel.cs` – View model and sample data

## Requirements

- Visual Studio 2017 or later
- .NET Framework 4.8
- Syncfusion WinForms Data Grid and PDF packages

## How to run this sample

1. Open `SfDataGridDemo/SfDataGridDemo.sln` in Visual Studio.
2. Restore the NuGet packages required by the project.
3. Build the solution.
4. Run the application to see CRUD operations and PDF export in action.

## Key code snippets

### Add a record

```csharp
var inlineForm = new InlineForm(null);
inlineForm.StartPosition = FormStartPosition.CenterParent;
inlineForm.ShowDialog();

var sourceCollection = this.sfDataGrid.DataSource as ObservableCollection<OrderInfo>;
if (inlineForm.RowData != null)
{
    sourceCollection.Add(inlineForm.RowData);
}
```

### Delete a record

```csharp
if (this.sfDataGrid.SelectedItems.Count > 0)
{
    this.sfDataGrid.DeleteSelectedRecords();
}
```

### Update a record

```csharp
var rowIndex = this.sfDataGrid.TableControl.ResolveToRowIndex(this.sfDataGrid.SelectedItem);
var recordIndex = this.sfDataGrid.TableControl.ResolveToRecordIndex(rowIndex);
var inlineForm = new InlineForm((OrderInfo)this.sfDataGrid.SelectedItem);
inlineForm.StartPosition = FormStartPosition.CenterParent;
inlineForm.ShowDialog();

this.sfDataGrid.View.GetRecordAt(recordIndex).Data = inlineForm.RowData;
this.sfDataGrid.View.Refresh();
```

### Export to PDF

```csharp
var document = this.sfDataGrid.ExportToPdf();
string filePath = "Sample.pdf";
document.Save(filePath);

System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
{
    FileName = filePath,
    UseShellExecute = true
});
```

## Related links

- [WinForms DataGrid documentation](https://help.syncfusion.com/windowsforms/datagrid/overview)
- [WinForms Data Grid data manipulation](https://help.syncfusion.com/windowsforms/datagrid/datamanipulation)
- [Export to PDF in WinForms Data Grid](https://help.syncfusion.com/windowsforms/datagrid/exporttopdf)
