using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1[] books = new Class1[100];
            int i = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. Remove a book");
                Console.WriteLine("3. List all books");
                Console.WriteLine("4. Stock details");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice: ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Enter the book name: ");
                    string bookName = Console.ReadLine();
                    Console.WriteLine("Enter the author name: ");
                    string authorName = Console.ReadLine();
                    Console.WriteLine("Enter the price: ");
                    string price = Console.ReadLine();
                    Console.WriteLine("Enter the publication year: ");
                    string year = Console.ReadLine();
                    books[i] = new Class1(bookName, authorName, price, year);
                    i++;
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Enter the book name: ");
                    string bookNameR = Console.ReadLine();
                    for (int x = 0; x < i; x++)
                    {
                        if (books[x].name == bookNameR)
                        {
                            books[x] = null;
                            i--;
                        }
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("List of books: ");
                    Console.WriteLine("Name\tPrice\tYear\tAuthor");
                    for (int x = 0; x < i; x++)
                    {
                        Console.WriteLine(books[x].name + "\t" + books[x].price + "\t" + books[x].year + "\t" + books[x].author);
                    }
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Stock details: ");
                    Console.WriteLine("1. Edit stock details...");
                    Console.WriteLine("2. View stock details...");
                    Console.WriteLine("Enter your choice: ");
                    string choice2 = Console.ReadLine();
                    if (choice2 == "1")
                    {
                        Console.WriteLine("1. Buy books");
                        Console.WriteLine("2. Sell books");
                        Console.WriteLine("Enter your choice: ");
                        string choice3 = Console.ReadLine();
                        Console.WriteLine("Enter the book name: ");
                        string bookNameB = Console.ReadLine();
                        for (int x = 0; x < i; x++)
                        {
                            if (books[x].name == bookNameB)
                            {
                                Console.WriteLine("Enter the quantity: ");
                                string quantity = Console.ReadLine();
                                if(choice3 == "1")
                                {
                                    books[x].stock = books[x].stock + int.Parse(quantity);
                                }
                                else if (choice3 == "2")
                                {
                                    books[x].stock = books[x].stock - int.Parse(quantity);
                                }       
                            }
                            else
                            {
                                Console.WriteLine("Book not found");
                            }
                        }
                    }
                    else if (choice2 == "2")
                    {
                        for (int x = 0; x < i; x++)
                        {
                            Console.WriteLine("Name\tstock");
                            Console.WriteLine(books[x].name + "\t" + books[x].stock);
                        }
                    }
                }
                else if (choice == "5")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
