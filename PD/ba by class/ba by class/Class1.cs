using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ba_by_class
{
    internal class Class1
    {
        public Class1(ref int usercount)
        {
            signUp(usercount);
            usercount++;
        }

        public Class1(string name,String password , string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }


        public void signUp(int usercount)
        {
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Enter your role");
            role = Console.ReadLine();
        }

        

        public string name;
        public string password;
        public string role;
        //product info

    }

    internal class Class2
    {
        public string productNames;
        public string productPrices;
        public string productquantity;

        public Class2(ref int productcount)
        {
            addproduct();
            productcount++;
        }

        public Class2(string productNames, string productPrices, string productquantity)
        {
            this.productNames = productNames;
            this.productPrices = productPrices;
            this.productquantity = productquantity;
        }

        public Class2()
        {
            Console.WriteLine("Enter product name");
            productNames = Console.ReadLine();
            Console.WriteLine("Enter product price");
            productPrices = Console.ReadLine();
            Console.WriteLine("Enter product quantity");
            productquantity = Console.ReadLine();
        }

        public void addproduct()
        {
            Console.WriteLine("Enter product name");
            productNames = Console.ReadLine();
            Console.WriteLine("Enter product price");
            productPrices = Console.ReadLine();
            Console.WriteLine("Enter product quantity");
            productquantity = Console.ReadLine();
        }
    }

    internal class Class3
    {
        public string kartPname;
        public string kartPprice;
        public int kartPquantity;
        public int kartTotal;

        public Class3(Class2[] pro,ref int kartcount , int productCount)
        {
            //addkart(pro,productCount);
            kartcount++;
        }

        public Class3(Class2[] pro,int i,int q,int k)
        {
            kartPname = pro[i].productNames;
            kartPprice = pro[i].productPrices;
            kartPquantity = q;
            kartTotal = q * int.Parse(kartPprice);
            k++;
        }   
    }
}
