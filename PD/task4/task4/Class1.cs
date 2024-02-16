using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Class1
    {
        public Class1(string bname,string bauthor, string bprice , string byear) 
        {
            name = bname;
            author = bauthor;
            price = bprice;
            year = byear;
        }

        public string name;
        public string author;
        public string price;
        public string year;
        public int stock = 0;
    }
}
