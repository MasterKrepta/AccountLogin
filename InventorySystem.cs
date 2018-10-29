using System;
using System.Collections.Generic;
using System.Text;

namespace AccountLogin
{
    static class InventorySystem {

        public static void DisplayMenu(){
            string input = "";
            while (input.ToLower() != "q") {
                Console.Clear();
                Console.WriteLine("\n-------------------------- Inventory Management ------------------------");
                Console.WriteLine("\n1) Query Product");
                Console.WriteLine("\n2) Add Product");
                Console.WriteLine("\n3) Remove Product");
                Console.WriteLine("\n4) List All Products");
                Console.WriteLine("\nQ) Quit");
                Console.WriteLine("\nSelect A Menu Option: ");
                SelectMenuOption(input = Console.ReadLine().ToLower());
            }
        }

         static void SelectMenuOption(string input) {
            

            switch (input) {
                case "1":
                    Console.WriteLine("\n-------------------------- Query Inventory ------------------------");
                    Product p = ModifyInventory.FindProduct();
                    if (p == null) {
                        Console.WriteLine("\nProduct not found");
                    }
                    else {
                        p.Description();
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
                    MainMenu.DisplayMenu();
                    break;
            }
        }

        private static void ListAllProducts() {
            Console.WriteLine("\n-------------------------- All Products ------------------------");
            foreach (Product p in Data.Products) {
                p.Description();
                Console.WriteLine();
            }
            Console.WriteLine(Data.Products.Count + " Total Products ");
        }
    }
}
