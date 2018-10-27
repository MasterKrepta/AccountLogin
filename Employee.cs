using System;
using System.Collections.Generic;
using System.Text;

namespace AccountLogin
{
    class Employee
    {
        public enum EmployeeType { Production, Office, Supervisor, Manager};

        #region Members
        private string _name;
        private EmployeeType _type;
        private string _jobTitle;
        private float _payRate;

        public string Name { get; protected set; }
        public EmployeeType Type { get; protected set; }
        public float PayRate { get; protected set; }
        public string JobTitle { get; protected set; }
        #endregion

        public Employee(string name, EmployeeType type, string title, float rate) {
            this.Name = name;
            this.Type = type;
            this.JobTitle = title;
            this.PayRate = rate;
            Data.employees.Add(this);
            //Data.SaveData();
        }

        public void GetDescription() {
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Employee Type: " + Type);
            Console.WriteLine("Title: " + JobTitle);
            Console.WriteLine("Pay Rate: $" + PayRate + " per hour");
        }

        public static void ChangeEmployee() {
            if (Data.employees.Count <= 0) {
                return;
            }

            Console.Clear();
            Console.WriteLine("\n-------------------------- Change Employee ------------------------");
            Console.WriteLine("\nSearch Employee");
            try {
                Employee e = FindEmployee(Console.ReadLine());
                Console.WriteLine(e.Name + " Has been found");
                //Display menu
                Console.WriteLine("\nSelect an option");

                Console.WriteLine("\n1) Promote");
                Console.WriteLine("\n2) Give Raise");
                Console.WriteLine("\n3) Quit");
                Console.WriteLine("\nSelect A Menu Option: ");
                e.SelectMenuOption();
                
            }
            catch (Exception e) {
                Console.WriteLine("Sorry employee not found");
            }
            
        }

        private static Employee FindEmployee(string name) {
            foreach (Employee e in Data.employees) {
                if (e.Name.ToLower() == name.ToLower())
                    return e;
            }
            return null;
        }

        public void SelectMenuOption() {
            string input = Console.ReadLine().ToLower();
            switch (input) {
                case "1":
                    Promote();
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("\nGive Raise.");
                    Console.ReadKey();
                    break;
                case "3":
                    MainMenu menu = new MainMenu();
                    menu.Display();
                    Console.ReadKey();
                    break;
            }
        }

        void Promote() {
            Console.WriteLine("\nSelect New Department");
            string newDept = Console.ReadLine();
            bool isValid = false;
            EmployeeType newType = EmployeeType.Production;

            //Production, Office, Supervisor, Manager
            while (!isValid) {
                switch (newDept) {
                    case "production":
                        newType = Employee.EmployeeType.Production;
                        isValid = true;
                        break;
                    case "office":
                        newType = Employee.EmployeeType.Office;
                        isValid = true;
                        break;
                    case "supervisor":
                        newType = Employee.EmployeeType.Supervisor;
                        isValid = true;
                        break;
                    case "manager":
                        newType = Employee.EmployeeType.Manager;
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("\nType not found, please reenter.");
                        //Type = Console.ReadLine().ToLower();
                        break;
                }
            }
            if (this.Type == newType) {
                return;
            }
            this.Type = newType;
            Console.WriteLine("\nNew Department Selected");
        }
    }
}
