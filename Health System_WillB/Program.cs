using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Health_System_WillB
{
    internal class Program
    {
        //int variables 
        static int lives, xp, health, shield, attack, level, monsterhealth, scoremultiplyer, damage, bossDamage, heal, score;
        // string variables
        static string healthStatus;
        static void Main(string[] args)
        {
            Revive();
            attack = 25;
            monsterhealth = 100;
            scoremultiplyer = 2;
            damage = 10;
            Console.WriteLine("From Will's Studio");
            Console.WriteLine("------------------");
            Console.ReadKey();
            Console.WriteLine("Brings to you:");
            Console.WriteLine("---------------");
            Console.ReadKey();
            Console.WriteLine("Cave Explorers");
            Console.WriteLine("--------------");
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
            Console.WriteLine("You have " + score + " score");
            Console.WriteLine("-------------------------------");
            Console.ReadKey();
            Monster();
        }
        static void TakeDamage(int damage)
        {
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
                    Console.WriteLine("You lose, try again");
                    health = 0;
                    lives -= 1;
                    if ( lives <= 0)
                    {
                        lives = 0;
                        Console.WriteLine("You lose, for real this time");

                    }
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
            TakeDamage(damage);
            Console.WriteLine("You take " + damage + " damage");
            Console.WriteLine("You fight back! with " + attack + " Attack");
            monsterhealth -= attack;
            Console.WriteLine("Monster health is at " + monsterhealth);
            Console.ReadKey();
            if (monsterhealth <= 0)
            {
                monsterhealth = 0;
                xp += 10;
                score += 100;
                Console.WriteLine("You win!");
                Console.WriteLine("You get " + xp + "xp");
            }
            ShowHUD();
        }
        static void MonsterBoss()
        {
            Console.WriteLine("Thud thud thud");
            Console.WriteLine("You have encountered a boss!");
            Console.WriteLine("----------------------------");
            Console.WriteLine("The boss deals " + bossDamage);
        }
        static void LevelUP(int level)
        {

        }
        static void Mission()
        {
                ShowHUD();
                Monster();
        }
        static void Heal(int heal)
        {

        }
        static void Revive() 
        {
            health = 100;
            lives = 3;
            xp = 0;
            shield = 100;
            level = 0;
        }
        
         
    }
}