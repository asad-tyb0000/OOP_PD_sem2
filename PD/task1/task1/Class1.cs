using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class calculator
    {
        public calculator(float a, float b, char c)
        {
            if (c == '+')
            {
                answer = a + b;
            }
            else if (c == '-')
            {
                answer = a - b;
            }
            else if (c == '*')
            {
                answer = a * b;
            }
            else if (c == '/')
            {
                answer = a / b;
            }
            else if (c == '%')
            {
                answer = a % b;
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }

        }
        public float answer;
    }
}
