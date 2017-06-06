using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App
{
    class Menu_Second
    {
        private static string strSecond_2 = "Want to Continue? Y/N\n";
        private static string strSecond_1 = "You've checked 2 menu item.\nPress any key to continue...";
        public static void Second()
        {
            Console.WriteLine(strSecond_1);
            Console.ReadKey();
            Console.Clear();
            string result;
            int k = 1;
            while (true)
            {
                if (Math.Pow(k, 0.5) % 2 == 0 || Math.Pow(k, 0.5) % 2 == 1)
                {
                    Console.Clear();
                    result = k + " ( " + k + " = " + Math.Pow(k,0.5) + "^2 )";
                    Console.WriteLine(result + "\n");
                    Console.WriteLine(strSecond_2);
                    switch(Input.Read("Answer"))
                    {
                        case 1:
                            k++;
                            continue;
                        case -1:
                            return;
                        case 0:
                            Console.Clear();
                            Console.WriteLine("Wrong answer ( Y or N )\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                    }
                }
                else k++;
            }
        }
    }
}
