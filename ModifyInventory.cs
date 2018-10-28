using System;
using System.Collections.Generic;
using System.Text;

namespace AccountLogin
{
    static class ModifyInventory
    {
        public static Product FindProduct() {
            Console.WriteLine("\nEnter Product name to find: ");
            string search = Console.ReadLine();

            foreach (Product product in Data.Products) {
                if (product.Name == search.ToUpper()) {
                    return product;
                }
            }
            return null;
        }
        public static Product Create() {
            Console.WriteLine("\n-------------------------- Create Product ------------------------");
            Console.WriteLine("\nEnter Product Name");
            string name = Console.ReadLine().ToUpper();
            Console.WriteLine("\nEnter Inventory Location");
            string location  = Console.ReadLine().ToUpper();
            Console.WriteLine("\nEnter Material Cost");
            float cost = float.Parse( Console.ReadLine());
            Console.WriteLine("\nEnter Sales Price");
            float salePrice = float.Parse( Console.ReadLine());
            Console.WriteLine("\nEnter Qty on hand");
            int qty = int.Parse(Console.ReadLine());

            return new Product(name, location, cost, salePrice, qty);
        }

        public static void RemoveProduct() {
            Product p = FindProduct();
            string response;
            Console.WriteLine("\nAre you sure you want to remove: " + p.Name + "? (This change cannot be undone)");
            while (true) {
                response = Console.ReadLine();
                if (response.ToLower() == "y") {
                    break;
                } else if(response.ToLower() == "n") {
                    Console.WriteLine("\nRemoval Cancelled");
                    return;
                }  else {
                    Console.WriteLine("\nAre you sure you want to remove: " + p.Name + "? (This change cannot be undone)");
                }
            }
            Data.Products.Remove(p);
            Console.WriteLine("\n" + p.Name + " has been removed from the database.");
        }
    }
}