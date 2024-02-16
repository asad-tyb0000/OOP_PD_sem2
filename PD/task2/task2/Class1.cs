using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class calculator
    {
        public calculator(float a, float b, string c)
        {
            if (c == "+")
            {
                answer = a + b;
            }
            else if (c == "-")
            {
                answer = a - b;
            }
            else if (c == "*")
            {
                answer = a * b;
            }
            else if (c == "/")
            {
                answer = a / b;
            }
            else if (c == "%")
            {
                answer = a % b;
            }
            else if (c == "s")
            {
                answer = (float)Math.Sqrt(a);
            }
            else if (c == "l")
            {
                answer = (float)Math.Log(a);
            }
            else if (c == "e")
            {
                answer = (float)Math.Exp(a);
            }
            else if (c == "sin")
            {
                answer = (float)Math.Sin(a);
            }
            else if (c == "cos")
            {
                answer = (float)Math.Cos(a);
            }
            else if (c == "tan")
            {
                answer = (float)Math.Tan(a);
            }   
            else
            {
                Console.WriteLine("Invalid operator");
            }

        }
        public float answer;
    }
}
