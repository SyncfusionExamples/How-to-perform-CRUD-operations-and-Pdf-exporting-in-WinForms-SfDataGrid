using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGridConverter;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SfDataGridDemo
{
    public partial class Form1 : Form
    {
        OrderInfoCollection data;

        public Form1()
        {
            InitializeComponent();

            data = new OrderInfoCollection();
            sfDataGrid.DataSource = data.OrdersListDetails;
            sfDataGrid.AllowDeleting = true;
            sfDataGrid.AllowEditing = false;
            sfDataGrid.LiveDataUpdateMode = Syncfusion.Data.LiveDataUpdateMode.AllowDataShaping;
            sfDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "OrderID" });
            sfDataGrid.Columns.Add(new GridTextColumn() { MappingName = "CustomerID" });
            sfDataGrid.Columns.Add(new GridTextColumn() { MappingName = "ProductName" });
            sfDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "Quantity" });
            sfDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "UnitPrice" });
            sfDataGrid.Columns.Add(new GridTextColumn() { MappingName = "ShipCountry" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inlineForm = new InlineForm(null);
            inlineForm.StartPosition = FormStartPosition.CenterParent;
            inlineForm.ShowDialog();
            var sourceCollection = this.sfDataGrid.DataSource as ObservableCollection<OrderInfo>;
            if (inlineForm.RowData != null)
                sourceCollection.Add(inlineForm.RowData);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.sfDataGrid.SelectedItems.Count > 0)
            {
                this.sfDataGrid.DeleteSelectedRecords();
            }
            else
            {
                MessageBox.Show("Select the item to be deleted.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.sfDataGrid.SelectedItems.Count > 0)
            {
                var rowIndex = this.sfDataGrid.TableControl.ResolveToRowIndex(this.sfDataGrid.SelectedItem);
                var recordIndex = this.sfDataGrid.TableControl.ResolveToRecordIndex(rowIndex);
                var inlineForm = new InlineForm((OrderInfo)this.sfDataGrid.SelectedItem);
                inlineForm.StartPosition = FormStartPosition.CenterParent;
                inlineForm.ShowDialog();
                this.sfDataGrid.View.GetRecordAt(recordIndex).Data = inlineForm.RowData;
                this.sfDataGrid.View.Refresh();
            }
            else
            {
                MessageBox.Show("Select the item to be updated.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var document = this.sfDataGrid.ExportToPdf();
            string filePath = "Sample.pdf";
            document.Save(filePath);

            // Open the PDF file using the default viewer
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = filePath,
                UseShellExecute = true
            });

        }
    }
}
