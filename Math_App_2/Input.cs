using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App_2
{
    class Input
    {
        private static char[] operators = { '/', '*', '+', '-' };
        public static string Read(string type)
        {
            switch(type)
            {
                case "Digit":
                    return ReadDigit();
                case "Operator":
                    return ReadOperator();
            }
            return "";
        }
        private static string ReadDigit()
        {
            
            double k = 0.0;
            try
            {
                k = Convert.ToDouble(Console.ReadLine());
                
            }catch(FormatException)
            {
                Console.WriteLine("Wrong input, write number correctly\n" + 
                    "Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                return "fail";
            }
            return k.ToString();
        }
        private static string ReadOperator()
        {
            char k = '\0';
            try
            {
                k = Convert.ToChar(Console.ReadLine());
                for(int i=0;i<4;i++)
                {
                    if (k == operators[i]) return k.ToString();
                }
                Console.WriteLine("Wrong input, write operator correctly\n" +
                    "Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                return "fail";
            }catch
            {
                Console.WriteLine("Wrong input, write operator correctly\n" + 
                    "Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                return "fail";
            }
            return k.ToString();
        }
    }
}
