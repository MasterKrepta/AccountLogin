using System;

namespace AccountLogin
{
    class Program
    {

        static void Main(string[] args) {

            MainMenu menu = new MainMenu();
            Data.LoadData();
            while (true) {
                menu.Display();
                menu.SelectMenuOption();
            }

        }
    }
}
