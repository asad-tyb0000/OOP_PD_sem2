using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lbms_task1
{
    internal class Books
    {
        private string Name;
        private Author Author;
        
        public Books(string name)
        {
            Name = name;
            Author = new Author();
        }

        

        public string GetName()
        {
            return Name;
        }

        public void SetName()
        {
            Name = Console.ReadLine();
            Author.SetName();
        }

    }
}
