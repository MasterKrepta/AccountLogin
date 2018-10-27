using System;
using System.Collections.Generic;
using System.Text;

namespace AccountLogin
{
    class  MainMenu
    {

        public void Display() {
            Console.Clear();
            Console.WriteLine("\n1) Create Employee");
            Console.WriteLine("\n2) List Employees");
            Console.WriteLine("\n3) Change Employees");
            Console.WriteLine("\n4) Quit");
            Console.WriteLine("\nSelect A Menu Option: ");

        }

        public void SelectMenuOption() {
            string input = Console.ReadLine().ToLower();

            switch (input) {
                case "1":
                    CreateEmployee cE = new CreateEmployee();
                    Employee e = cE.Create();
                    Console.WriteLine("\nNew employee created.");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("\n-------------------------- All Employees ------------------------");
                    foreach (Employee employee in Data.employees) {
                        employee.GetEmployeeDescription();
                        Console.WriteLine();
                    }
                    Console.WriteLine(Data.employees.Count + " Total Employees ");
                    Console.ReadKey();
                    break;
                case "3":
                    ChangeEmployee.DisplayChangeMenu();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine("\nGood Bye");
                    
                    Data.SaveData();
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
