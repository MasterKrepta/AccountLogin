using System;
using System.Collections.Generic;
using System.Text;

namespace AccountLogin
{
    static class  MainMenu
    {
        public static void DisplayMenu() {
            string input = "";
            while (input.ToLower() != "q") {
                Console.Clear();
                Console.WriteLine("\n1) Employee Manager");
                Console.WriteLine("\n2) Inventroy Manager");
                Console.WriteLine("\n3) Production Manager");
                Console.WriteLine("\nQ) Quit");
                Console.WriteLine("\nSelect A Menu Option: ");
                SelectMenuOption(input = Console.ReadLine().ToLower());
            }
        }

        static void SelectMenuOption(string input) {
            switch (input) {
                case "1":
                    EmployeeManagement.DisplayMenu();
                    Console.ReadKey();
                    break;
                case "2":
                    InventorySystem.DisplayMenu();
                    Console.ReadKey();
                    break;
                case "3":
                    ProductionManagement.DisplayMenu();
                    Console.ReadKey();
                    break;
                case "q":
                    Console.WriteLine("\nGood Bye");
                    Data.SaveData();
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
        }

        private static void ListAllEmployees() {
            Console.WriteLine("\n-------------------------- All Employees ------------------------");
            foreach (Employee employee in Data.Employees) {
                employee.Description();
                Console.WriteLine();
            }
            Console.WriteLine(Data.Employees.Count + " Total Employees ");
            Console.ReadKey();
        }
    }
}
