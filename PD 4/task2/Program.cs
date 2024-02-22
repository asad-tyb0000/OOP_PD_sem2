using MagicalDuel.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalDuel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player mage1 = new Player("Elena", 110, 50, 10);
            Player mage2 = new Player("Derek", 100, 60, 20);

            Stats fireball = new Stats("fireball", 23, "a fiery magical attack", 1.2, 15, 5);
            mage1.learnSkill(fireball);
            Console.WriteLine(mage1.attack(mage2));

            Stats superbeam = new Stats("superbeam", 200, "an overpowered attack, pls nerf", 50, 50, 75);
            mage2.learnSkill(superbeam);
            Console.WriteLine(mage2.attack(mage1));

            Console.ReadKey();
        }
    }
}