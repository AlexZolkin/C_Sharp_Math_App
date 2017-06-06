using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App
{
    class Menu_First
    {
        private static string strFirst = "You've checked 1 menu item. Enter, how many" +
            " even numbers do you want to see: ";
        public static string First()
        {
            string result = "";
            Console.WriteLine(strFirst);
            int k = Input.Read("Digit");
            Console.Clear();
            for (int i = 0, s = 1; i < k * 2; i += 2, s++)
            {
                result += i;
                if (s % 5 == 0) result += "\n\n";
                else result += "\t";
            }
            return result;
        }
    }
}
