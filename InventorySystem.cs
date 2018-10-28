using System;
using System.Collections.Generic;
using System.Text;

namespace AccountLogin
{
    static class InventorySystem {

        public static void Menu(){
            Console.Clear();
            
            Console.WriteLine("\n1) Query Product");
            Console.WriteLine("\n2) Add Product");
            Console.WriteLine("\n3) Remove Product");
            Console.WriteLine("\n4) List All Products");
            Console.WriteLine("\nQ) Quit");
            Console.WriteLine("\nSelect A Menu Option: ");
            SelectMenuOption();
        }

         static void SelectMenuOption() {
            string input = Console.ReadLine().ToLower();

            switch (input) {
                case "1":
                    Console.WriteLine("\n-------------------------- Query Inventory ------------------------");
                    Product p = ModifyInventory.FindProduct();
                    if (p == null) {
                        Console.WriteLine("\nProduct not found");
                    }
                    else {
                        p.GetProductDescription();
                    }
                    Console.ReadKey();
                    break;
                case "2":
                    Product newProduct = ModifyInventory.Create();
                    Data.Products.Add(newProduct);
                    break;
                case "3":
                    ModifyInventory.RemoveProduct();
                    Console.ReadKey();
                    break;
                case "4":
                    ListAllProducts();
                    Console.ReadKey();
                    break;
                case "q":
                    Console.WriteLine("\nGood Bye");
                    Data.SaveData();
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
        }

        private static void ListAllProducts() {
            Console.WriteLine("\n-------------------------- All Products ------------------------");
            foreach (Product p in Data.Products) {
                p.GetProductDescription();
                Console.WriteLine();
            }
            Console.WriteLine(Data.Products.Count + " Total Products ");
        }
    }
}
