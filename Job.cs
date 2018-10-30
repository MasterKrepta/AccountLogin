using System;
using System.Collections.Generic;
using System.Text;


namespace AccountLogin
{
    class Job
    {
        #region Members
        private int _jobNum;
        private Product _product;
        private int _qty;
        private DateTime _startDate;
        private DateTime _endDate;
        private float _runTime;
        private string _machine;
        private float _salePrice;

        public int JobNum { get; set; }
        public Product Product { get; set; }
        public int Qty { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float RunTime { get; set; }
        public string Machine { get; set; }
        public float SalePrice { get; set; }


        #endregion

        public Job(int num, Product product, int qty, DateTime start, DateTime end, string machine) {
            this.JobNum = num;
            this.Product = product;
            //TODO make this a product referance
            this.Qty = qty;
            this.StartDate = start;
            this.EndDate = end;
            this.RunTime = (StartDate.Day + EndDate.Day);
            this.Machine = machine;
            this.SalePrice = Product.SalePrice * Qty; // TODO Replace this with the product cost

        }
        public void Description() {
            Console.WriteLine("Job num: " + JobNum);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Product To Be Made: " + Product.Name);
            Console.WriteLine("Quantity: " + Qty);
            Console.WriteLine("Run Time: " + RunTime);
            Console.WriteLine("Start Date: " + StartDate.ToShortDateString());
            Console.WriteLine("End Date: " + EndDate.ToShortDateString());
        }
    }
}
