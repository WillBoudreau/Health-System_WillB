using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_WillB
{
    internal class Program
    {
            //int variables 
            static int lives;
            static int xp;
            static int level;
            //float variables
            static float health;
            static float shield;
            static float healthUp;
            static float shieldUp;
            static float damage;
            //string variables
            static string username;
         static void Main(string[] args)
        {


            // Introduction
            health = 100;
            shield = 100;
            lives = 3;
            level = 0;
            xp = 0;
            Console.WriteLine("From Will's Studio");
            Console.WriteLine("------------------");
            Console.ReadKey();
            Console.WriteLine("Brings to you:");
            Console.WriteLine("---------------");
            Console.ReadKey();
            Console.WriteLine("Cave Explorers");
            Console.WriteLine("--------------");
            Console.WriteLine("Enter you name here: ");
            username = Console.ReadLine();
            Console.WriteLine("Hello! " + username);
            Console.WriteLine("Press any key to begin (NOT ALT + F4 or ESC)");
            Console.ReadKey();
            ShowHUD();

        }
        static void Level_selec()
        {
            Console.WriteLine("");
        }
        static void ShowHUD()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("You have: " + health + " Health");
            Console.WriteLine("You have: " + shield + " Shield");
            Console.WriteLine("You have: " + lives + " Lives");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("You are at level: " + level);
            Console.WriteLine("You have: " + xp + " xp");
            Console.WriteLine("-------------------------------");
            Console.ReadKey();
        }
    }
}

