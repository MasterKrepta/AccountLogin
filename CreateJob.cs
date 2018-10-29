using System;
using System.Collections.Generic;
using System.Text;

namespace AccountLogin
{
    static class CreateJob
    {
        public static Job Create() {
            Console.WriteLine("\n-------------------------- Create Job ------------------------");
            //public Job(int num, string product, int qty, DateTime start, DateTime end, string machine) {
            int jobNum = Data.Jobs.Count + 1;
            Console.WriteLine("\nEnter Product to make: ");
            string product = Console.ReadLine().ToLower();
            Console.WriteLine("\nEnter Qty to make: ");
            int qty = int.Parse( Console.ReadLine().ToUpper());
            DateTime start = DateTime.Today;
            DateTime end = start.AddDays(7);
            Console.WriteLine("\nAssign Machine");
            string machine = Console.ReadLine();
            return new Job(jobNum, product, qty, start, end, machine);
        }
    }
}
