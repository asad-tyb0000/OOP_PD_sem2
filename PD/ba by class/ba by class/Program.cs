using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ba_by_class
{
    internal class Program
    {
            public static string path = "D:\\Asad work\\semester 2\\OOP Lab\\week 3\\ba\\my.txt";
            public static string path1 = "D:\\Asad work\\semester 2\\OOP Lab\\week 3\\ba\\products.txt";
        static void Main(string[] args)
        {
            
            Class1[] data = new Class1[100];
            Class2[] pro = new Class2[10000];
            Class3[] kart = new Class3[10000];
            int userCount = 0;
            int productCount = 0;
            int kartcount = 0;
            while (true)
            {
                bool users = false;
                readData(data, ref userCount);
                readDataP(pro, ref productCount);
                Console.Clear();
                Console.WriteLine("1. SignUp");
                Console.WriteLine("2. SignIn");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    data[userCount] = new Class1(ref userCount);
                    Console.ReadKey();
                }
                else if(choice == 2)
                {
                    signIn(data, userCount, ref users);
                    Console.ReadKey();
                    if(users == true)
                    {
                        while(true)
                        {
                            Console.Clear();
                        sellerPage();
                        int choice1 = int.Parse(Console.ReadLine());
                        if(choice1 == 1)
                        {
                            pro[productCount] = new Class2(ref productCount);
                        }
                        else if (choice1 == 2)
                        {
                            for(int x = 0 ; x < productCount ; x++)
                            {
                                Console.WriteLine(x+1 + ". " + pro[x].productNames + " " + pro[x].productPrices + " " + pro[x].productquantity);
                                Console.ReadKey();
                            }
                        }
                        else if (choice1 == 3)
                        {
                            Console.WriteLine("Enter product name to remove");
                            string name = Console.ReadLine();
                            for (int i = 0; i <= productCount; i++)
                            {
                                if (pro[i].productNames == name)
                                {
                                    pro[i].productNames = null;
                                    pro[i].productPrices = null;
                                    pro[i].productquantity = null;
                                }
                            }
                            Console.ReadKey();
                        }
                        else if (choice1 == 4)
                        {
                            Console.WriteLine("Enter product name to update");
                            string name = Console.ReadLine();
                            for (int i = 0; i < userCount; i++)
                            {
                                if (pro[i].productNames == name)
                                {
                                    pro[i] = new Class2();
                                }
                            }
                        }
                        else if (choice1 == 5)
                        {
                            storeData(data, userCount);
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice");
                        }
                        }
                    }
                    else if(users == false)
                    {
                        while (true)
                        {
                            Console.Clear();
                        customerPage();
                        int choice2 = int.Parse(Console.ReadLine());
                        if (choice2 == 1)
                        {
                            for (int x = 0; x < productCount; x++)
                            {
                                Console.WriteLine(x + 1 + ". " + pro[x].productNames + " " + pro[x].productPrices + " " + pro[x].productquantity);
                            }
                        }
                        else if (choice2 == 2)
                        {
                            Console.WriteLine("Enter product name to buy");
                            string name = Console.ReadLine();
                            for (int i = 0; i <= productCount; i++)
                            {
                                if (pro[i].productNames == name)
                                {
                                    Console.WriteLine("Enter quantity");
                                    int quantity = int.Parse(Console.ReadLine());
                                    kart[0] = new Class3(pro,i,quantity,kartcount);
                                }
                            }
                        }
                        else if (choice == 3)
                        {
                            for(int x=0; x<kartcount; x++)
                            {
                                Console.WriteLine($"Product: {kart[x].kartPname}\t  price: {kart[x].kartTotal}");
                            }
                        }
                        else if (choice2 == 4)
                        {
                            storeData(data, userCount);
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice");
                        }
                        }
                    }
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    storeData(data, userCount);
                    storeDataP(pro, productCount);
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }
 


        static void signIn(Class1[] data, int userCount ,ref bool answer)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            for (int i = 0; i < userCount; i++)
            {
                if (data[i].name == name && data[i].password == password)
                {
                    Console.WriteLine("Welcome " + name);
                    if (data[i].role == "seller")
                    {
                        answer = true;
                    }
                    else if (data[i].role == "customer")
                    {
                        answer = false;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid credentials");
                    break;
                }
            }
        }   


        static void sellerPage()
        {
            Console.Clear();
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View Product");
            Console.WriteLine("3. Remove Product");
            Console.WriteLine("4. Update Product");
            Console.WriteLine("5. Exit");
        }

        static void customerPage()
        {
            Console.Clear();
            Console.WriteLine("1. View Product");
            Console.WriteLine("2. Buy Product");
            Console.WriteLine("3. Show kart");
            Console.WriteLine("4. Exit");
        }

        


        static void storeData(Class1[] data , int usercount)
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine("Name,Password,Role");
            for (int i = 0; i < usercount; i++)
            {
                file.WriteLine(data[i].name + "," + data[i].password + "," + data[i].role);
            }
            file.Close();
        }

        static void readData(Class1[] data, ref int usercount)
        {
            StreamReader file = null;
            try
            {
                file = new StreamReader(path);
            }
            catch (FileNotFoundException)
            {
                return;
            }
            file.ReadLine();
            string line = "";
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string name = parts[0];
                string password = parts[1];
                string role = parts[2];
                data[usercount] = new Class1(name,password,role);
                usercount++;
            }
            file.Close();
        }

        static void storeDataP(Class2[] data, int productcount)
        {
            StreamWriter file = new StreamWriter(path1);
            file.WriteLine("Name,Price,Quantity");
            for (int i = 0; i < productcount; i++)
            {
                file.WriteLine(data[i].productNames + "," + data[i].productPrices + "," + data[i].productquantity);
            }
            file.Close();
        }

        static void readDataP(Class2[] data, ref int productcount)
        {
            StreamReader file = null;
            try
            {
                file = new StreamReader(path1);
            }
            catch (FileNotFoundException)
            {
                return;
            }
            file.ReadLine();
            string line = "";
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string name = parts[0];
                string password = parts[1];
                string role = parts[2];
                data[productcount] = new Class2(name, password, role);
                productcount++;
            }
            file.Close();
        }
    }
}
