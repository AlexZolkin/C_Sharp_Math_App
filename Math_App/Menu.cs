using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App
{
    class Menu
    {
        private static string strMenu = "Hello! There is my Math Program!\n" +
            "1. Display a list of even numbers\n" +
            "2. Display a sequence of perfect squares\n" + 
            "3. Exit\n";
        public static void Call()
        {
            do
            {
                switch (Menu_Show())
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Wrong input for choosing menu item ( 1, 2 or 3 )\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.WriteLine(Menu_First.First() +
                            "\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Menu_Second.Second();
                        break;
                    case 3:
                        return;
                }
                Console.Clear();
            } while (true);
        }
        private static int Menu_Show()
        {
            Console.WriteLine(strMenu);
            return Input.Read("Menu Item");
        }
       
    }
}
