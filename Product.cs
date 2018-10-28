using System;
using System.Collections.Generic;
using System.Text;

namespace AccountLogin
{
    class Product
    {
        #region Member Vars
        private string _name;
        private string _location;
        private float _cost;
        private float _salePrice;
        private int _qtyOnHand;

        public string Name { get; set; }
        public string Location { get; set; }
        public float Cost { get; set; }
        public float SalePrice { get; set; }
        public int QtyOnHand { get; set; }
        #endregion

        public Product(string name, string loc, float cost, float salePrice, int qty) {
            this.Name = name;
            this.Location = loc;
            this.Cost = cost;
            this.SalePrice = salePrice;
            this.QtyOnHand = qty;
        }

        public void GetProductDescription() {
            Console.WriteLine("Product Name: " + Name);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Product Location: " + Location);
            Console.WriteLine("Cost: " + Cost);
            Console.WriteLine("Sales Price: " + SalePrice);
            Console.WriteLine("QTY on hand: " + QtyOnHand);
        }
    }
}
