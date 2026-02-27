using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SfDataGridDemo
{
    public partial class InlineForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public OrderInfo RowData { get; set; }
        public InlineForm()
        {
            InitializeComponent();
        }

        public InlineForm(OrderInfo rowData)
        {
            InitializeComponent();
            if (rowData == null)
                rowData = new OrderInfo();
            RowData = rowData;
            var data = rowData as OrderInfo;
            this.orderIdTextBox.Text = data.OrderID.ToString();
            this.customerIdTextBox.Text = data.CustomerID;
            this.productNameTextBox.Text = data.ProductName;
            this.quantityTextBox.Text = data.Quantity.ToString();
            this.unitPriceTextBox.Text = data.UnitPrice.ToString();
            this.shipCountryTextBox.Text = data.ShipCountry;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var data = RowData as OrderInfo;
            if (data == null)
                data = new OrderInfo();
            data.OrderID = string.IsNullOrEmpty(this.orderIdTextBox.Text) ? 0 : int.Parse(this.orderIdTextBox.Text);
            data.CustomerID = string.IsNullOrEmpty(this.customerIdTextBox.Text) ? string.Empty : this.customerIdTextBox.Text;
            data.ProductName = string.IsNullOrEmpty(this.productNameTextBox.Text) ? string.Empty : this.productNameTextBox.Text;
            data.Quantity = string.IsNullOrEmpty(this.quantityTextBox.Text) ? 0 : int.Parse(this.quantityTextBox.Text);
            data.UnitPrice = string.IsNullOrEmpty(this.unitPriceTextBox.Text) ? 0 : double.Parse(this.unitPriceTextBox.Text);
            data.ShipCountry = string.IsNullOrEmpty(this.shipCountryTextBox.Text) ? string.Empty : this.shipCountryTextBox.Text;
            RowData = data;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            RowData = null;
            this.Close();
        }
    }
}
