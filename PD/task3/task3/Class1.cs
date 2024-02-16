using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace task3
{
    internal class Class1
    {
        public string word1;
        public bool check;
        public int score = 0;
        public List<string> array;
        public Class1()
        {
            array = new List<string>();
        }
        public bool Play(string word1)
        {

            if( array.Count>0 )
            {
                for(int i = 0; i < array.Count; i++)
                {
                    if (word1 == array[i])
                    {
                        Console.WriteLine("You have already said this word!");
                        return false;
                        
                    }
                }
                string lastWord = array[array.Count - 1];
                if (word1[0] == lastWord[lastWord.Length-1])
                {
                    Console.WriteLine("Correct!");
                    array.Add(word1);
                    check = true;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                    check = false;
                }
            }
            else
            {
                array.Add(word1);
            }
            return check;
        }
    }
}