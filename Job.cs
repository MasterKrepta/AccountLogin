using System;
using System.Collections.Generic;
using System.Text;


namespace AccountLogin
{
    class Job
    {
        #region Members
        private int _jobNum;
        private string _product;
        private int _qty;
        private DateTime _startDate;
        private DateTime _endDate;
        private float _runTime;
        private string _machine;

        public int JobNum { get; set; }
        public string Product { get; set; }
        public int Qty { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float RunTime { get; set; }
        public string Machine { get; set; }


        #endregion

        public Job(int num, string product, int qty, DateTime start, DateTime end, string machine) {
            this.JobNum = num;
            this.Product = product;
            this.Qty = qty;
            this.StartDate = start;
            this.EndDate = end;
            this.RunTime = (EndDate.Day - StartDate.Day);
            this.Machine = machine;

        }
        public void Description() {
            Console.WriteLine("Job num: " + JobNum);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Product To Be Made: " + Product);
            Console.WriteLine("Quantity: " + Qty);
            Console.WriteLine("Run Time: " + RunTime);
            Console.WriteLine("Start Date: " + StartDate.ToShortDateString());
            Console.WriteLine("End Date: " + EndDate.ToShortDateString());
        }
    }
}
