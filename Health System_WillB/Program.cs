﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Diagnostics;

namespace Health_System_WillB
{
    internal class Program
    {

        //int variables 
        static int lives = 3;
        static int health = 100;
        static int shield =10;
        static int level;
        static int xp;
        static int damage;
        static int xpmax;
        static int attack;
        static int monsterhealth;
        // string variables
        static string healthStatus;
        static void Main(string[] args)
        {
            //UnitTestHealthSystem();
            //UnitTestXPSystem();

            
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
            TakeDamage(60);
            ShowHUD();
           

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
        }
        static void TakeDamage(int damage)
        {
            if (damage < 0)
            {
                Console.WriteLine("Cannot do negative damage");
                damage = 0;
            }
            Console.WriteLine("You are attacked by a monster!");
            if( shield  > 0 ) 
            {
                shield -= damage;
                if( shield <= 0)
                {
                    shield = 0;
                    if (damage > shield)
                    {
                        health -= damage;
                    }
                }
            }
            else
            {
                health -= damage;
                if ( health < 0 ) 
                {  
                    health = 0;
                    Console.WriteLine("You lose, try again");
                  
                }
                
                if ( health >0 && health < 10) 
                {
                    Console.WriteLine("Health Critical!");
                    
                }
                if (health >= 10 && health < 20)
                {
                    Console.WriteLine("Health really low!");
                    
                }
                if (health >= 20 && health < 30)
                {
                    Console.WriteLine("Health low");
                    
                }
                if (health >= 30 && health < 40) 
                {
                    Console.WriteLine("Health getting low");
                    
                }
                if (health >= 40 && health < 50)
                {
                    Console.WriteLine("Healh mid");
                   
                }
                if (health >= 50 && health < 60)
                {
                    Console.WriteLine("Health not bad");
                    
                }
                if (health >= 60 &&  health < 70)
                {
                    Console.WriteLine("Health okay");
                    
                }
                if (health >= 70 && health < 80)
                {
                    Console.WriteLine("Health Good");
                    
                }
                if (health >= 80 && health < 90)
                {
                    Console.WriteLine("Health Great!");
                    
                }
                if (health >= 90 && health <= 100)
                {
                    Console.WriteLine("Health Awesome!");
                   
                }
            }
        }
        static void IncreaseXP(int xp)
        {
            xpmax = 100;
           Console.WriteLine("You get " + xp + "xp");
           while( xp < xpmax)
            {
                if( xp == xpmax)
                {
                    level += 1;
                    xpmax += 100;
                }
            }
        }
        static void Heal(int heal)
        {
            if (heal <= 0)
            { 
                heal = 0;
                Console.WriteLine("You cannot negatively heal...");
            }
            Console.WriteLine("You heal " + heal + " heal");
            health += heal;
            if (health > 100)
            {
                health = 100;
            }
            
        }
        static void RegenerateShield( int shield)
        {
            Console.WriteLine("Your shield regenarates");
            Console.WriteLine("Plus" + shield + " Shield");
        }
        static void Revive() 
        {
            health = 100;
            lives -= 1;
            xp = 0;
            shield = 100;
            level = 0;
            if (lives < 0)
            {
                Console.WriteLine("You lose");
            }
        }
        static void Playerattack()
        {
            Console.WriteLine("You fight back! with " + attack + " Attack");
            monsterhealth -= attack;
            Console.WriteLine("Monster health is at " + monsterhealth);
            Console.ReadKey();
            if (monsterhealth <= 0)
            {
                monsterhealth = 0;
                Console.WriteLine("You win!");
                Console.WriteLine("You get " + xp + "xp");
            }
            if (monsterhealth < 50)
            {
                damage += 10;
            }
        }
        static void UnitTestHealthSystem()
        {
            Debug.WriteLine("Unit testing Health System started...");

            // TakeDamage()

            // TakeDamage() - only shield
            shield = 100;
            health = 100;
            lives = 3;
            TakeDamage(10);
            Debug.Assert(shield == 90);
            Debug.Assert(health == 100);
            Debug.Assert(lives == 3);

            // TakeDamage() - shield and health
            shield = 10;
            health = 100;
            lives = 3;
            TakeDamage(50);
            Debug.Assert(shield == 0);
            Debug.Assert(health == 60);
            Debug.Assert(lives == 3);

            // TakeDamage() - only health
            shield = 0;
            health = 50;
            lives = 3;
            TakeDamage(10);
            Debug.Assert(shield == 0);
            Debug.Assert(health == 40);
            Debug.Assert(lives == 3);

            // TakeDamage() - health and lives
            shield = 0;
            health = 10;
            lives = 3;
            TakeDamage(25);
            Debug.Assert(shield == 0);
            Debug.Assert(health == 0);
            Debug.Assert(lives == 3);

            // TakeDamage() - shield, health, and lives
            shield = 5;
            health = 100;
            lives = 3;
            TakeDamage(110);
            Debug.Assert(shield == 0);
            Debug.Assert(health == 0);
            Debug.Assert(lives == 3);

            // TakeDamage() - negative input
            shield = 50;
            health = 50;
            lives = 3;
            TakeDamage(-10);
            Debug.Assert(shield == 50);
            Debug.Assert(health == 50);
            Debug.Assert(lives == 3);

            // Heal()

            // Heal() - normal
            shield = 0;
            health = 90;
            lives = 3;
            Heal(5);
            Debug.Assert(shield == 0);
            Debug.Assert(health == 95);
            Debug.Assert(lives == 3);

            // Heal() - already max health
            shield = 90;
            health = 100;
            lives = 3;
            Heal(5);
            Debug.Assert(shield == 90);
            Debug.Assert(health == 100);
            Debug.Assert(lives == 3);

            // Heal() - negative input
            shield = 50;
            health = 50;
            lives = 3;
            Heal(-10);
            Debug.Assert(shield == 50);
            Debug.Assert(health == 50);
            Debug.Assert(lives == 3);

            // RegenerateShield()

            // RegenerateShield() - normal
            shield = 50;
            health = 100;
            lives = 3;
            RegenerateShield(10);
            Debug.Assert(shield == 60);
            Debug.Assert(health == 100);
            Debug.Assert(lives == 3);

            // RegenerateShield() - already max shield
            shield = 100;
            health = 100;
            lives = 3;
            RegenerateShield(10);
            Debug.Assert(shield == 100);
            Debug.Assert(health == 100);
            Debug.Assert(lives == 3);

            // RegenerateShield() - negative input
            shield = 50;
            health = 50;
            lives = 3;
            RegenerateShield(-10);
            Debug.Assert(shield == 50);
            Debug.Assert(health == 50);
            Debug.Assert(lives == 3);

            // Revive()

            // Revive()
            shield = 0;
            health = 0;
            lives = 2;
            Revive();
            Debug.Assert(shield == 100);
            Debug.Assert(health == 100);
            Debug.Assert(lives == 1);

            Debug.WriteLine("Unit testing Health System completed.");
            Console.Clear();
        }
        static void UnitTestXPSystem()
        {
            Debug.WriteLine("Unit testing XP / Level Up System started...");

            // IncreaseXP()

            // IncreaseXP() - no level up; remain at level 1
            xp = 0;
            level = 1;
            IncreaseXP(10);
            Debug.Assert(xp == 10);
            Debug.Assert(level == 1);

            // IncreaseXP() - level up to level 2 (costs 100 xp)
            xp = 0;
            level = 1;
            IncreaseXP(105);
            Debug.Assert(xp == 5);
            Debug.Assert(level == 2);

            // IncreaseXP() - level up to level 3 (costs 200 xp)
            xp = 0;
            level = 2;
            IncreaseXP(210);
            Debug.Assert(xp == 10);
            Debug.Assert(level == 3);

            // IncreaseXP() - level up to level 4 (costs 300 xp)
            xp = 0;
            level = 3;
            IncreaseXP(315);
            Debug.Assert(xp == 15);
            Debug.Assert(level == 4);

            // IncreaseXP() - level up to level 5 (costs 400 xp)
            xp = 0;
            level = 4;
            IncreaseXP(499);
            Debug.Assert(xp == 99);
            Debug.Assert(level == 5);

            Debug.WriteLine("Unit testing XP / Level Up System completed.");
            Console.Clear();
        }

    }
}