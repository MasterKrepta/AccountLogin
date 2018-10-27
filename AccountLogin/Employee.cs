using System;
using System.Collections.Generic;
using System.Text;

namespace AccountLogin
{
    class Employee
    {
        public enum EmployeeType { Production, Office, Supervisor, Manager};

        private string _name;
        private EmployeeType _type;
        private string _jobTitle;
        private float _payRate;

        public string Name { get; protected set; }
        public EmployeeType Type { get; protected set; }
        public float PayRate { get; protected set; }
        public string JobTitle { get; protected set; }

        public Employee(string name, EmployeeType type, string title, float rate) {
            this.Name = name;
            this.Type = type;
            this.JobTitle = title;
            this.PayRate = rate;
            Data.employees.Add(this);
        }

        public void GetDescription() {
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Employee Type: " + Type);
            Console.WriteLine("Title: " + JobTitle);
            Console.WriteLine("Pay Rate: $" + PayRate + " per hour");
        }
    }
}
