using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 game = new Class1();
                
            while (true)
            {
                Console.WriteLine("Welcome");
                Console.Write("Press any key to start the game!");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Shiritori");
                Console.WriteLine("The rules are simple: ");
                Console.WriteLine("1. You have to say a word that starts with the last letter of the previous word.");
                Console.WriteLine("2. You can't repeat a word that has already been said.");
                Console.WriteLine("So, let's start!");
                string[] array = new string[10000];
                int i = 0;
                
                    Console.Write("The first word is: ");
                    string word_1 = Console.ReadLine();
                    //if (game[0].check == true)
                    //{
                    //    game[0].score = game[0].score + 5;
                    //    i++;
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Game Over!");
                    //    Console.WriteLine("Your score is: " + game[0].score);
                    //    Console.ReadKey();
                    //    break;
                    //}
                    game.Play(word_1);
                
                //Console.WriteLine("Do you want to play again?");
                //Console.WriteLine("Press 'Y' for yes and 'N' for no.");
                //string choice = Console.ReadLine();
                //if (choice == "N")
                //{
                //    break;
                //}
                //else
                //{
                //    Console.Clear();
                //}
            }
        }
    }
}
