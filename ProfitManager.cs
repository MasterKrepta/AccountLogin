using System;
using System.Collections.Generic;
using System.Text;

namespace AccountLogin
{
    static class ProfitManager
    {
        public static List<Job> FinalizedJobs = new List<Job>();
        public static float totalSales = 0;
        public static float totalMaterialCost = 0;
        public static void FinalizeJob() {
            Job job = FindJob();
            FinalizedJobs.Add(job);
            Data.Jobs.Remove(job);
            Console.WriteLine("\nJob Number: " + job.JobNum + " completed");
        }

        public static void CalculateProfit() {
            totalSales = 0;
            totalMaterialCost = 0;
            foreach (Job job in FinalizedJobs) {
                totalSales += job.SalePrice;
                totalMaterialCost += job.Product.Cost;
            }
            Console.WriteLine("\nTotal Sales: " + totalSales);
            Console.WriteLine("\nTotal Cost: " + totalMaterialCost);
            Console.WriteLine("\nTotal Profit: $" + (totalSales - totalMaterialCost));
        }

        public static Job FindJob() {
            Console.WriteLine("\nEnter Job number to find: ");
            string search = Console.ReadLine();

            foreach (Job  job in Data.Jobs) {
                if (job.JobNum.ToString() == search.ToUpper()) {
                    return job;
                }
            }
            Console.WriteLine("\nJob number not found");
            return null;
        }
    }
}