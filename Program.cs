using System;

namespace AccountLogin
{
    class Program
    {

        static void Main(string[] args) {

            MainMenu menu = new MainMenu();
            while (true) {
                menu.Display();
                menu.GetOption();
            }
            Employee e = new Employee("Frank Reynolds", Employee.EmployeeType.Manager, "Idea Man", 1000.50f);

            e.GetDescription();
            Console.ReadKey();
        }
    }
}
