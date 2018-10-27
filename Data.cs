using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AccountLogin
{
    static class Data
    {
        public static List<Employee> employees = new List<Employee>();
        
        public static void SaveData() {
            //TODO Set up proper data paths for this instead of copying it into the debug
            string path = @"DataStorage.txt";
            string text = System.IO.File.ReadAllText(path);
            try {
                using (StreamWriter outputFile = new StreamWriter(path)) {
                    foreach (Employee e in employees) {
                    string line = "";
                    line += e.Name + ","
                        + e.Type.ToString().ToLower() + ","
                        + e.JobTitle + ","
                        + e.PayRate.ToString().ToLower();

                    outputFile.WriteLine(line);
                    }
                    outputFile.Close();
                }
                
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                throw;
            }
            
            Console.WriteLine("File Saved");
            Console.ReadKey();
        }

        public static void LoadData() {
            using (StreamReader sr = new StreamReader("DataStorage.txt")) {
                
                string line;
                
                while ((line = sr.ReadLine()) != null) {
                    string[] values = line.Split(',');
                    string name = values[0];
                    Employee.EmployeeType type = GetType(values[1]);
                    string title = values[2];
                    float rate = float.Parse(values[3]);

                    Employee e = new Employee(name, type, title, rate);
                    e.GetDescription();
                    
                }
                Console.WriteLine("Data Loaded");
                Console.ReadKey();
            }
            
        }

        private static Employee.EmployeeType GetType(string type) {
            switch (type) {
                case "production":
                    return Employee.EmployeeType.Production;
                    
                case "office":
                    return Employee.EmployeeType.Office;
                    
                case "supervisor":
                    return Employee.EmployeeType.Supervisor;
                    
                case "manager":
                    return Employee.EmployeeType.Manager;
                    
                default:
                    return Employee.EmployeeType.Production;
            }
        }
    }
}