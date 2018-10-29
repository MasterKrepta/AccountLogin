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
   
                Console.WriteLine("\nQ) Quit");
                Console.WriteLine("\nSelect A Menu Option: ");
                SelectMenuOption(input = Console.ReadLine().ToLower());
            }
        }

        static void SelectMenuOption(string input) {


            switch (input) {
                case "1":
           
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
