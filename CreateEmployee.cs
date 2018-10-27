using System;
using System.Collections.Generic;
using System.Text;

namespace AccountLogin
{
    class CreateEmployee
    {
        public Employee Create() {
            Console.WriteLine("\n-------------------------- Create Employee ------------------------");

            Console.WriteLine("\nEnter Name");
            string name = Console.ReadLine();

            Console.WriteLine("\nEnter type: (Production, Office, Supervisor, Manager)");
            string type  = Console.ReadLine().ToLower();

            Employee.EmployeeType empType = Employee.EmployeeType.Production;
            bool isValid = false;
            //Production, Office, Supervisor, Manager
            while (!isValid) {
                switch (type) {
                    case "production":
                        empType = Employee.EmployeeType.Production;
                        isValid = true;
                        break;
                    case "office":
                        empType = Employee.EmployeeType.Office;
                        isValid = true;
                        break;
                    case "supervisor":
                        empType = Employee.EmployeeType.Supervisor;
                        isValid = true;
                        break;
                    case "manager":
                        empType = Employee.EmployeeType.Manager;
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("\nType not found, please reenter.");
                        type = Console.ReadLine().ToLower();
                        break;
                }
            }
            Console.WriteLine("\nEnter Title");
            string title = Console.ReadLine().ToUpper();
            //TODO capitalize this
            title.ToString().ToUpper();

            Console.WriteLine("\nEnter Pay Rate");
            float rate = float.Parse( Console.ReadLine());

            
            //TODO Add employee to a data file location
            return new Employee(name, empType, title, rate);
        }
            
            
    }
}
