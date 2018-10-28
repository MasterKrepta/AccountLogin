using System;
using System.Collections.Generic;
using System.Text;


namespace AccountLogin
{
    static class  ChangeEmployee
    {
        public static void DisplayChangeMenu() {
            //TODO we need to get the employee once to prevent having to enter for each option
            if (Data.Employees.Count <= 0) {
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
                Console.WriteLine("\n3) Change Title");
                Console.WriteLine("\n4) Quit");
                Console.WriteLine("\nSelect A Menu Option: ");
                SelectMenuOption(e);

            }
            catch (Exception e) {
                Console.WriteLine("Sorry employee not found");
            }

        }

        private static Employee FindEmployee(string name) {
            foreach (Employee e in Data.Employees) {
                if (e.Name.ToLower() == name.ToLower())
                    return e;
            }
            return null;
        }

        public static void SelectMenuOption(Employee e) {
            string input = Console.ReadLine().ToLower();
            switch (input) {
                case "1":
                    Promote(e);
                    Console.ReadKey();
                    break;
                case "2":
                    GiveRaise(e);
                    Console.ReadKey();
                    break;
                case "3":
                    ChangeTitle(e);
                    Console.ReadKey();
                    break;
                case "4":
                    MainMenu menu = new MainMenu();
                    menu.Display();
                    break;
            }
        }

        public static void ChangeTitle(Employee e) {
            Console.Clear();
            Console.WriteLine("\n-------------------------- Change Title  ------------------------");

            //Display menu
            Console.WriteLine("\nEmployee: " + e.Name);
            Console.WriteLine("\nCurrent Job Title is: " + e.JobTitle + ". Enter new Job Title ");
            string newJobTitle = Console.ReadLine();
            if (newJobTitle != e.JobTitle) {
                Console.WriteLine("\nConfirm: Changing Job Title from " + e.JobTitle + " to " + newJobTitle + "?: Y/N)");
                if (Console.ReadLine().ToLower() == "y") {
                    e.JobTitle = newJobTitle;
                    Console.WriteLine("\nNew Title Accepted");
                    Console.WriteLine();
                    e.GetEmployeeDescription();

                }

            }
            else {
                Console.WriteLine("\nNew payrate is the same: Please Try again.");
                return;
            }
        }

        public static void Promote(Employee e) {
            Console.WriteLine("\n-------------------------- Promote Employee  ------------------------");
            bool isValid = false;
            Employee.EmployeeType newType = Employee.EmployeeType.Production;
            Console.WriteLine("\nEmployee: " + e.Name);
            Console.WriteLine("\nCurrent Department is " + e.Type + ". Enter new Department: ");
            string newDept = Console.ReadLine();
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
            if (e.Type == newType) {
                return;
            }
            e.Type = newType;
            Console.WriteLine("\nNew Department Selected");
        }

        public static void GiveRaise(Employee e) {
            Console.Clear();
            Console.WriteLine("\n-------------------------- Give Raise  ------------------------");

            //Display menu
            Console.WriteLine("\nEmployee: " + e.Name);
            Console.WriteLine("\nCurrent Pay is: " + e.PayRate + ". Enter new pay rate: ");
            float newPayRate = float.Parse(Console.ReadLine());
            if (newPayRate != e.PayRate) {
                Console.WriteLine("\nConfirm: Changing Pay rate from " + e.PayRate + " to " + newPayRate + "?: Y/N)");
                if (Console.ReadLine().ToLower() == "y") {
                    e.PayRate = newPayRate;
                    Console.WriteLine("\nNew Salary Accepted");
                }
                else {
                    Console.WriteLine("\nPlease Try again.");
                }

            }
            else {
                Console.WriteLine("\nNew payrate is the same: Please Try again.");
                return;
            }
            //while (Console.ReadLine().ToLower() != "y") {

            //}
        }
    }
}
