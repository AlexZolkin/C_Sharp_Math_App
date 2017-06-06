using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_App_2
{
    class Calculate
    {
        public static string Calculate_F(double num1, char calc_operator, double num2)
        {
            switch(calc_operator)
            {
                case '/':
                    return num1 + " / " + num2 + " = " + num1 / num2 + "\n";
                case '*':
                    return num1 + " * " + num2 + " = " + num1 * num2 + "\n";
                case '+':
                    return num1 + " + " + num2 + " = " + num1 + num2 + "\n";
                case '-':
                    return num1 + " - " + num2 + " = " + (num1 - num2) + "\n";
            }
            
            return "";
        }
    }
}
