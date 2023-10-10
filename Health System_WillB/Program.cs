using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
        static float attack;
        static float monsterhealth;
        static float scoremultiplyer;
        static void Main(string[] args)
        {
            health = 100f;
            lives = 3;
            xp = 0;
            shield = 100f;
            level = 0;
            attack = 25;
            monsterhealth = 100;
            scoremultiplyer = 2.5f;
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
            Mission();
        }
         
        static void ShowHUD()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("You have " + health + " health");
            Console.WriteLine("You have " + shield + " shield");
            Console.WriteLine("You have " + lives + " lives");
            Console.WriteLine("You are at Level " + level);
            Console.WriteLine("You have " + xp + " xp");
            Console.WriteLine("-------------------------------");
            Console.ReadKey();
            Monster();
        }
        static void Damage(float damage)
        {
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
                    Console.WriteLine("You lose");
                    health = 0;
                }
                if ( health >0 && health < 10) 
                {
                    Console.WriteLine("Health Critical!");
                    ShowHUD();
                }
                if (health >= 10 && health < 20)
                {
                    Console.WriteLine("Health really low!");
                    ShowHUD();
                }
                if (health >= 20 && health < 30)
                {
                    Console.WriteLine("Health low");
                    ShowHUD();
                }
                if (health >= 30 && health < 40) 
                {
                    Console.WriteLine("Health getting low");
                    ShowHUD();
                }
                if (health >= 40 && health < 50)
                {
                    Console.WriteLine("Healh mid");
                    ShowHUD();
                }
                if (health >= 50 && health < 60)
                {
                    Console.WriteLine("Health not bad");
                    ShowHUD();
                }
                if (health >= 60 &&  health < 70)
                {
                    Console.WriteLine("Health okay");
                    ShowHUD();
                }
                if (health >= 70 && health < 80)
                {
                    Console.WriteLine("Health Good");
                    ShowHUD();
                }
                if (health >= 80 && health < 90)
                {
                    Console.WriteLine("Health Great!");
                    ShowHUD();
                }
                if (health >= 90 && health <= 100)
                {
                    Console.WriteLine("Health Awesome!");
                    ShowHUD();
                }
            }
        }
        static void Monster()
        {
            Console.WriteLine("You are attacked by a monster!");
            Damage(damage);
            Console.WriteLine("You fight back! with " + attack + " Attack");
            monsterhealth -= attack;
            Console.WriteLine("Monster health is at " + monsterhealth);
            Console.ReadKey();
            if (monsterhealth <= 0)
            {
                monsterhealth = 0;
                xp = xp * scoremultiplyer;
                Console.WriteLine("You win!");
                Console.WriteLine("You get " + xp + "xp");
            }
            ShowHUD();
        }
        static void Mission()
        {
                ShowHUD();
                Monster();
        }
        
         
    }
  
}

