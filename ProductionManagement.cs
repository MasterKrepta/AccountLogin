using System;
using System.Collections.Generic;
using System.Text;

namespace AccountLogin
{
    static class ProductionManagement
    {
        public static void DisplayMenu() {
            string input = "";
            while (input.ToLower() != "q") {
                Console.Clear();
                Console.WriteLine("\n-------------------------- Production Management ------------------------");
                Console.WriteLine("\n1) View Job Orders");
                Console.WriteLine("\n2) Create Job");
                Console.WriteLine("\n3) Complete Job");
                Console.WriteLine("\n4) View Profits");
                Console.WriteLine("\nQ) Quit");
                Console.WriteLine("\nSelect A Menu Option: ");
                SelectMenuOption(input = Console.ReadLine().ToLower());
            }
        }

        static void SelectMenuOption(string input) {


            switch (input) {
                case "1":
                    ListAllJobs();
                    Console.ReadKey();
                    break;
                case "2":
                    Job newJob =  CreateJob.Create();
                    Data.Jobs.Add(newJob);
                    Console.WriteLine("\nNew Job created.");
                    Console.ReadKey();
                    break;
                case "3":
                    ProfitManager.FinalizeJob();
                    Console.ReadKey();
                    break;
                case "4":
                    ProfitManager.CalculateProfit();
                    Console.ReadKey();
                    break;
                case "q":
                    MainMenu.DisplayMenu();
                    break;
            }
        }
        private static void ListAllJobs() {
            Console.WriteLine("\n-------------------------- All Products ------------------------");
            foreach (Job j in Data.Jobs) {
                j.Description();
                Console.WriteLine();
            }
            Console.WriteLine(Data.Jobs.Count + " Total Jobs ");
        }
    }
}
