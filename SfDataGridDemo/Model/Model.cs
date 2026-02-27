using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public partial class OrderInfo : INotifyPropertyChanged
    {
        private int _OrderID;

        private DateTime _orderDate;

        private string _CustomerID;

        private double _unitPrice;

        private int _Quantity;

        private int _contactNumber;

        private string _product;

        private string _shipaddress;

        public OrderInfo()
        {

        }

        [Display(Name = "Order ID")]
        public int OrderID
        {
            get
            {
                return this._OrderID;
            }
            set
            {
                this._OrderID = value;
                this.OnPropertyChanged("OrderID");
            }
        }

        [Display(Name = "Customer ID")]
        public string CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                this._CustomerID = value;
                this.OnPropertyChanged("CustomerID");
            }
        }

        [Display(Name = "Product Name")]
        public string ProductName
        {
            get
            {
                return this._product;
            }
            set
            {
                this._product = value;
                this.OnPropertyChanged("ProductName");
            }
        }

        [Display(Name = "Order Date")]
        public DateTime OrderDate
        {
            get
            {
                return _orderDate;
            }
            set
            {
                _orderDate = value;
            }
        }

        [Range(typeof(int), "20", "60")]
        public int Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                _Quantity = value;
                OnPropertyChanged("Quantity");
            }
        }

        [DataType(DataType.Currency)]
        [Display(Name = "Unit Price")]
        public double UnitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
                OnPropertyChanged("UnitPrice");
            }
        }
  
        [Display(Name = "Contact Number")]
        public int ContactNumber
        {
            get
            {
                return this._contactNumber;
            }
            set
            {
                _contactNumber = value;
                OnPropertyChanged("ContactNumber");
            }
        }

        [Display(Name = "Ship Address")]
        public string ShipCountry
        {
            get
            {
                return this._shipaddress;
            }
            set
            {
                this._shipaddress = value;
                this.OnPropertyChanged("ShipCountry");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
