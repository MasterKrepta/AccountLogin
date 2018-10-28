using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AccountLogin
{
    static class Data
    {
        public static List<Employee> Employees = new List<Employee>();
        public static List<Product> Products = new List<Product>();
        
        public static void SaveData() {
            //TODO Set up proper data paths for this instead of copying it into the debug
            SaveEmployeeData();
            SaveInventoryData();
            Console.WriteLine("File Saved");
            Console.ReadKey();
        }

        private static void SaveInventoryData() {
            string path = @"InventoryStorage.txt";
            string text = System.IO.File.ReadAllText(path);
            try {
                using (StreamWriter outputFile = new StreamWriter(path)) {
                    foreach (Product p in Products) {
                        string line = "";
                        line += p.Name + ","
                            + p.Location + ","
                            + p.Cost.ToString().ToLower() + ","
                            + p.SalePrice.ToString().ToLower() +","
                            + p.QtyOnHand.ToString().ToLower();

                        outputFile.WriteLine(line);
                    }
                    outputFile.Close();
                }

            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        private static void SaveEmployeeData() {
            string path = @"DataStorage.txt";
            string text = System.IO.File.ReadAllText(path);
            try {
                using (StreamWriter outputFile = new StreamWriter(path)) {
                    foreach (Employee e in Employees) {
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
        }

        public static void LoadData() {
            LoadEmployeeData();
            LoadInventoryData();

        }

        private static void LoadInventoryData() {
            Products.Clear();
            using (StreamReader sr = new StreamReader("InventoryStorage.txt")) {

                string line;

                while ((line = sr.ReadLine()) != null) {

                 //   line += p.Name + ","
                 //+ p.Location + ","
                 //+ p.Cost.ToString().ToLower() + ","
                 //+ p.SalePrice.ToString().ToLower()
                 //+ p.QtyOnHand.ToString().ToLower();

                    string[] values = line.Split(',');

                    string name = values[0];
                    string loc = values[1];
                    float cost = float.Parse(values[2]);
                    float salePrice = float.Parse(values[3]);
                    int qty = int.Parse(values[4]);

                    Product p = new Product(name, loc, cost, salePrice, qty);
                    if (!Products.Contains(p)) {
                        Products.Add(p);
                    }
                    
                    //p.GetProductDescription();

                }
                Console.WriteLine("Data Loaded with " + Products.Count + " Products");
                
            }
        }

        private static void LoadEmployeeData() {
            Employees.Clear();
            using (StreamReader sr = new StreamReader("DataStorage.txt")) {

                string line;

                while ((line = sr.ReadLine()) != null) {
                    
                    string[] values = line.Split(',');
                    string name = values[0];
                    Employee.EmployeeType type = GetType(values[1]);
                    string title = values[2];
                    float rate = float.Parse(values[3]);

                    Employee e = new Employee(name, type, title, rate);
                    if (!Employees.Contains(e)) {
                        Employees.Add(e);
                    }
                    
                    //e.GetEmployeeDescription();

                }
                Console.WriteLine("Data Loaded with " + Employees.Count + " Employees");
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