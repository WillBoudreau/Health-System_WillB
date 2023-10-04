using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_WillB
{
    internal class Program
    {
       
         static void Main(string[] args)
        { 
            //int variables 
            int lives;
            int xp;
            int level;
            //float variables
            float health = 100f;
            float shield;
            float healthUp;
            float shieldUp;
            float damage;
           
            // Introduction
            Console.WriteLine("From Will's Studio");
            Console.WriteLine("------------------");
            Console.ReadKey();
            Console.WriteLine("Brings to you:");
            Console.WriteLine("---------------");
            Console.ReadKey();
            Console.WriteLine("Cave Explorers");
            Console.WriteLine("--------------");
            Console.WriteLine("Enter you name here: ");
            string username = Console.ReadLine();
            Console.WriteLine("Hello! " + username);
            Console.WriteLine("Press any key to begin (NOT ALT + F4 or ESC)");
            Console.ReadKey();
        }
        static void Level_selec()
        {
            Console.WriteLine();
        }
    }
}

