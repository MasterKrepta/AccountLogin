using System;

namespace AccountLogin
{
    class Program
    {
        static void Main(string[] args) {
            Data.LoadData();
            Console.ReadKey();
            while (true) {
                MainMenu.DisplayMenu();
            }
        }
    }
}