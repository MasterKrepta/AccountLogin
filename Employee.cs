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

        public string Name { get;  set; }
        public EmployeeType Type { get;  set; }
        public float PayRate { get;  set; }
        public string JobTitle { get;  set; }
        #endregion

        public Employee(string name, EmployeeType type, string title, float rate) {
            this.Name = name;
            this.Type = type;
            this.JobTitle = title;
            this.PayRate = rate;
            Data.Employees.Add(this);
            //?Do we need to save here? I Am already saving at applicaiton close for safty.. this might be redudundent
            //Data.SaveData();
        }

        public void GetEmployeeDescription() {
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Employee Type: " + Type);
            Console.WriteLine("Title: " + JobTitle);
            Console.WriteLine("Pay Rate: $" + PayRate + " per hour");
        }

    }
}
