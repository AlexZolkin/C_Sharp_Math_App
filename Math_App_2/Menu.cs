using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App_2
{
    class Menu
    {
        private static string strMenu = "Hello! It is my Calculator!\n" + 
            "Example of number input: 17,8\nExample of operator input: /\n" +
            "Press any key to begin using it...";
        public static void Menu_F()
        {
            Console.WriteLine(strMenu);
            
            Console.ReadKey();
            while(true)
            {
                Menu_Show();
                string ans;
                Console.Clear();
                while(true)
                {
                    Console.Clear();
                    Console.WriteLine("\nDo you want to exit? Y/N");
                    ans = Console.ReadKey().KeyChar.ToString();
                    if (String.Compare(ans, "y", true) == 0) Environment.Exit(0);
                    else if (String.Compare(ans, "n", true) == 0) break;
                    else continue;
                    
                }
            }
        }
        private static void Menu_Show()
        {
            string buffer = "";
            double first = 0.0, second = 1.0;
            char calc_operator = '\0';
            Console.Clear();
            
            Console.WriteLine("Enter first number:");
            buffer = Input.Read("Digit");
            if (String.Compare(buffer, "fail") != 0) first = Convert.ToDouble(buffer);
            else return;
            Console.WriteLine("Enter operator:");
            buffer = Input.Read("Operator");
            if (String.Compare(buffer, "fail") != 0) calc_operator = Convert.ToChar(buffer);
            else return;
            Console.WriteLine("Enter second number:");
            buffer = Input.Read("Digit");
            if (String.Compare(buffer, "fail") != 0) second = Convert.ToDouble(buffer);
            else return;
            Console.Clear();
            Console.WriteLine(Calculate.Calculate_F(first, calc_operator, second));
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
