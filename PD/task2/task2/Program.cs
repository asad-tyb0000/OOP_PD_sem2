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
                Console.WriteLine("1. Enter Values!");
                Console.WriteLine("2. Use default values!");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                float num1 = 10F;
                float num2 = 10F;
                if (choice == 1)
                {
                    Console.Write("Enter first number: ");
                    num1 = float.Parse(Console.ReadLine());
                    Console.Write("Enter operator (+ ,- ,* ,/ ,%,square root( s ) , logarithm( l ) , exponent(e) , trig(sin,cos,tan): ");
                    string op = Console.ReadLine();
                    if (op != "s" && op != "l" && op != "e" && op != "sin" && op != "cos" && op != "tan")
                    {
                        Console.Write("Enter second number: ");
                        num2 = float.Parse(Console.ReadLine());
                        calculator calc = new calculator(num1, num2, op);
                        Console.WriteLine("Answer: " + calc.answer);
                    }
                    else
                    {
                        calculator calc = new calculator(num1, 0, op);
                        Console.WriteLine("Answer: " + calc.answer);
                    }
                }
                else if (choice == 2)
                {
                    Console.Write("Enter operator (+ ,- ,* ,/ ,%,square root( s ) , logarithm( l ) , exponent(e) , trig(sin,cos,tan): ");
                    string op = Console.ReadLine();
                    if (op != "s" && op != "l" && op != "e" && op != "sin" && op != "cos" && op != "tan")
                    {
                        calculator calc = new calculator(num1, num2, op);
                        Console.WriteLine("Answer: " + calc.answer);
                    }
                    else
                    {
                        calculator calc = new calculator(num1, 0, op);
                        Console.WriteLine("Answer: " + calc.answer);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
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
