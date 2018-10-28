using System;
using System.Collections.Generic;
using System.Text;

namespace AccountLogin
{
    class  MainMenu
    {

        public void Display() {
            Console.Clear();
            //TODO organize these more logicially - move employee stuff to a seperate menu option
            Console.WriteLine("\n1) Create Employee");
            Console.WriteLine("\n2) List Employees");
            Console.WriteLine("\n3) Change Employees");
            Console.WriteLine("\n4) Inventroy Manager");
            Console.WriteLine("\nQ) Quit");
            Console.WriteLine("\nSelect A Menu Option: ");
            SelectMenuOption();
        }

        void SelectMenuOption() {
            string input = Console.ReadLine().ToLower();

            switch (input) {
                case "1":
                    CreateEmployee.Create();
                    Console.WriteLine("\nNew employee created.");
                    Console.ReadKey();
                    break;
                case "2":
                    ListAllEmployees();
                    break;
                case "3":
                    ChangeEmployee.DisplayChangeMenu();
                    Console.ReadKey();
                    break;
                case "4":
                    InventorySystem.Menu();
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
                employee.GetEmployeeDescription();
                Console.WriteLine();
            }
            Console.WriteLine(Data.Employees.Count + " Total Employees ");
            Console.ReadKey();
        }
    }
}
