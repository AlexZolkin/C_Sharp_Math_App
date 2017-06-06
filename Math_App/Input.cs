using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App
{
    class Input
    {
        public static int Read(string type)
        {
            switch(type)
            {
                case "Digit":
                    return ReadDigit();
                case "Answer":
                    return ReadAns();
                case "Menu Item":
                    return ReadDigit_Menu();
            }
            return 0;
        }
        
        private static int ReadDigit_Menu()
        {
            int k = 0;
            try
            {
                k = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }
            if (k > 0 && k < 4) return k;
            else return 0;
        }
        private static int ReadDigit()
        {
            int k = 0;
            try
            {
                k = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + "/n");
            }
            return k;
        }
        private static int ReadAns()
        {
            string ans = Console.ReadLine();
            if (String.Compare("y", ans, true) == 0) return 1;
            else if (String.Compare("n", ans, true) == 0) return -1;
            else return 0;
        }
    }
}
