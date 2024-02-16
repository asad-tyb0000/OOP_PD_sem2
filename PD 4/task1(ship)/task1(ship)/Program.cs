using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_ship_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serialnumber;
            int degree;
            float minute;
            string direction;
            menu();
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                addship(degree, minute, direction);
                Console.Clear();
                Console.WriteLine("Enter ship serial number: ");
                serialnumber = Console.ReadLine();
            }
           
        }

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add ship");
            Console.WriteLine("2. View ship position");
            Console.WriteLine("3. View ship serial number");
            Console.WriteLine("4. Change ship position");
            Console.WriteLine("5. Exit");
        }

        static void addship(int degree ,float minute , string direction )
        {
            Console.WriteLine("Enter ship degree: ");
            degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ship minute: ");
            minute = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter ship direction ( E , W , N , S ): ");
            direction = Console.ReadLine();
        }
    }
}
