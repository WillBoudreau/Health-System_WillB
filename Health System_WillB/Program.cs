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
        static float health = 100f;
        static float shield;
        static float healthUp;
        static float shieldUp;
        static float damage;
        static float attack;
        static float monsterhealth;
        // string varaibles
        static string responce;
        static void Main(string[] args)
        {
            health = 100f;
            lives = 3;
            xp = 0;
            shield = 100f;
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
            ShowHUD();
            Mission();
        }
         
        static void ShowHUD()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("You have " + health + " health");
            Console.WriteLine("You have " + shield + " shield");
            Console.WriteLine("You have " + lives + " lives");
            Console.WriteLine("You have " + xp + " xp");
            Console.WriteLine("-------------------------------");
            Console.ReadKey();
        }
        static void Damage(float damage)
        {
            monsterhealth = 100;
            damage = 10;
            if (monsterhealth < 50)
            {
                damage += 10;
            }
            if( shield  > 0 )
            {
                shield -= damage;
                if( shield <= 0)
                {
                    shield = 0;
                }
            }
            else
            {
                health -= damage;
                if ( health <= 0 ) 
                {
                    health = 0;
                }
            }
        }
        static void Monster()
        {
            Console.WriteLine("You are attacked by a monster!");
            Damage(damage);
        }
        static void Mission()
        {
            Console.WriteLine("Would you like to begin? Y/N");
            responce = Console.ReadLine();
            if (responce == "Y")
            {
                ShowHUD();
                Monster();
            }
            else
            {
                Console.WriteLine("Okay, see ya");
            }
        }
    }
}

