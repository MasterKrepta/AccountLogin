using System;
using System.Collections.Generic;
using System.Text;

namespace AccountLogin
{
    static class EmployeeManagement
    {
        public static void DisplayMenu() {
            string input = "";
            while (input.ToLower() != "q") {
                Console.Clear();
                Console.WriteLine("\n-------------------------- Employee Management ------------------------");
                Console.WriteLine("\n1) Create Employee");
                Console.WriteLine("\n2) List Employees");
                Console.WriteLine("\n3) Change Employees");
                Console.WriteLine("\nQ) Quit");
                Console.WriteLine("\nSelect A Menu Option: ");
                
                SelectMenuOption(input = Console.ReadLine().ToLower());
            }
            
        }

        static void SelectMenuOption(string input) {
            

            switch (input) {
                case "1":
                    Employee newEmployee = CreateEmployee.Create();
                    Console.WriteLine("\nNew employee created.");
                    Data.Employees.Add(newEmployee);
                    Console.ReadKey();
                    break;
                case "2":
                    ListAllEmployees();
                    break;
                case "3":
                    ChangeEmployee.DisplayChangeMenu();
                    Console.ReadKey();
                    break;
                
                case "q":
                    MainMenu.DisplayMenu();
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
