using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Details
{
    class Product
    {
        private string _productName;
        private string _serialNumber;
        private DateTime _purchaseDate;
        private double _cost;

        // Implement 4-Argument Constructor
        public Product(string _productName, string _serialNumber, DateTime _purchaseDate, double _cost)
        {
            this._productName = _productName;
            this._serialNumber = _serialNumber;
            this._purchaseDate = _purchaseDate;
            this._cost = _cost;

        }

        // Implement Properties

        public string ProductName
        {
            set
            {
                _productName = value;
            }
            get
            {
                return _productName;
            }
        }
        public string SerialNumber
        {
            set
            {
                _serialNumber = value;
            }
            get
            {
                return _serialNumber;
            }
        }
        public DateTime PurchaseDate
        {
            set
            {
                _purchaseDate = value;
            }
            get
            {
                return _purchaseDate;
            }
        }
        public double Cost
        {
            set
            {
                _cost = value;
            }
            get
            {
                return _cost;
            }

        }


        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", ProductName, SerialNumber, String.Format("{0:d}", PurchaseDate.ToString("dd-MM-yyyy")), Cost);
        }
    }
}
