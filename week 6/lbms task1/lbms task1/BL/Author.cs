using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lbms_task1
{
    internal class Author
    {
        private string AuthName;

        public Author()
        {
            AuthName = SetName();
        }

        public static string SetName()
        {
            string Name;
            Console.Write("Enter the name of the author:");
            return Name = Console.ReadLine();
        }

        public string GetName()
        {
            return AuthName;
        }


    }
}
