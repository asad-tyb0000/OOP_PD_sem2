using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter first number: ");
                float num1 = float.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                float num2 = float.Parse(Console.ReadLine());
                Console.Write("Enter operator (+ ,- ,* ,/ ,%): ");
                char op = char.Parse(Console.ReadLine());
                calculator calc = new calculator(num1, num2, op);
                Console.WriteLine("Answer: " + calc.answer);
                Console.Write("Do you want to continue? (y/n)");
                string cont = Console.ReadLine();
                if (cont == "n")
                {
                    break;
                }
            }
        }
    }
}
