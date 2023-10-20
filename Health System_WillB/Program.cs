using System;
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
        static int lives;
        static int health;
        static int shield;
        static int shieldUP;
        static int level;
        static int xp;
        static int damage;
        static int xpmax;
        // string variables
        static string healthStatus;
        static void Main(string[] args)
        {
          UnitTestHealthSystem();
          UnitTestXPSystem();

            
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
            lives = 3;
            health = 100;
            shield = 100;
            ShowHUD();
            TakeDamage(10);
            ShowHUD();
            shield = 10;
            health = 100;
            lives = 3;
            ShowHUD();
            TakeDamage(50);
            ShowHUD();
            lives = 3;
            health = 50;
            shield = 0;
            ShowHUD();
            TakeDamage(10);
            ShowHUD();
            lives = 3;
            health = 10;
            shield = 0;
            ShowHUD();
            TakeDamage(25);
            ShowHUD();
            lives = 3;
            health = 100;
            shield = 5;
            ShowHUD();
            TakeDamage(110);
            ShowHUD();
            shield = 50;
            health = 50;
            lives = 3;
            ShowHUD();
            TakeDamage(-10);
            ShowHUD(); 
            shield = 50;
            health = 50;
            lives = 3;
            ShowHUD();
            RegenerateShield(-10);
            ShowHUD();
            shield = 0;
            health = 90;
            lives = 3;
            ShowHUD();
            Heal(5);
            ShowHUD();
            shield = 0;
            health = 90;
            lives = 3;
            ShowHUD();
            Heal(-5);
            ShowHUD();
            shield = 100;
            health = 100;
            lives = 3;
            ShowHUD();
            RegenerateShield(10);
            ShowHUD();
            shield = 0;
            health = 0;
            lives = 2;
            ShowHUD();
            Revive();
            ShowHUD();
            xp = 0;
            level = 1;
            ShowHUD();
            IncreaseXP(10);
            ShowHUD();
            xp = 0;
            level = 1;
            ShowHUD();
            IncreaseXP(105);
            ShowHUD();
            xp = 0;
            level = 2;
            ShowHUD();
            IncreaseXP(210);
            ShowHUD();
            xp = 0;
            level = 3;
            ShowHUD();
            IncreaseXP(315);
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
            Console.WriteLine("You are attacked by a monster!");
            Console.WriteLine("You are about to take " + damage + " Damage");
            if (damage < 0)
            {
                Console.WriteLine("Cannot do negative damage");
                damage = 0;
            }
            if (shield >= 0)
            {

                shield = shield - damage;
              
                if (shield < 0)
                {
                    health = health + shield;
                    
                    shield = 0;

                    if (health <= 0)
                    {
                        health = 0;
                        Console.WriteLine("---------------------");
                        healthStatus = ("You lose, try again");
                        Console.WriteLine(healthStatus);
                        Console.WriteLine("---------------------");
                    }

                    if (health > 0 && health < 10)
                    {
                        Console.WriteLine("----------------------");
                        healthStatus = ("Health Critical!");
                        Console.WriteLine(healthStatus);
                        Console.WriteLine("-----------------------");
                    }
                    if (health >= 10 && health < 20)
                    {
                        Console.WriteLine("-----------------------");
                        healthStatus = ("Health really low!");
                        Console.WriteLine(healthStatus);
                        Console.WriteLine("------------------------");
                    }
                    if (health >= 20 && health < 30)
                    {
                        Console.WriteLine("-------------------------");
                        healthStatus = ("Health low");
                        Console.WriteLine(healthStatus);
                        Console.WriteLine("-------------------------");

                    }
                    if (health >= 30 && health < 40)
                    {
                        Console.WriteLine("--------------------------");
                        healthStatus = ("Health getting low");
                        Console.WriteLine(healthStatus);
                        Console.WriteLine("--------------------------");
                    }
                    if (health >= 40 && health < 50)
                    {
                        Console.WriteLine("---------------------------");
                        healthStatus = ("Healh mid");
                        Console.WriteLine(healthStatus);
                        Console.WriteLine("---------------------------");

                    }
                    if (health >= 50 && health < 60)
                    {
                        Console.WriteLine("---------------------------");
                        healthStatus = ("Health not bad");
                        Console.WriteLine(healthStatus);
                        Console.WriteLine("---------------------------");

                    }
                    if (health >= 60 && health < 70)
                    {
                        Console.WriteLine("----------------------------");
                        healthStatus = ("Health okay");
                        Console.WriteLine(healthStatus);
                        Console.WriteLine("-----------------------------");

                    }
                    if (health >= 70 && health < 80)
                    {
                        Console.WriteLine("------------------------------");
                        healthStatus = ("Health good");
                        Console.WriteLine(healthStatus);
                        Console.WriteLine("-------------------------------");
                    }
                    if (health >= 80 && health < 90)
                    {
                        Console.WriteLine("--------------------------------");
                        healthStatus = ("Health great");
                        Console.WriteLine(healthStatus);
                        Console.WriteLine("---------------------------------");
                    }
                    if (health >= 90 && health <= 100)
                    {
                        Console.WriteLine("--------------------------------");
                        healthStatus = ("Health awesome!");
                        Console.WriteLine(healthStatus);
                        Console.WriteLine("---------------------------------");

                    }
                    if(health > 100)
                    {
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("Error, health over max: 100. Not possible at this time.");
                        health = 100;
                        Console.WriteLine("-------------------------------------");
                    }
                }

            }
            
        }
        static void IncreaseXP(int exp)
        {
            
            Console.WriteLine("You get " + exp + "xp");
            xpmax = 100;
            xp = xp + exp;
            while (xp >= xpmax)
            {
                xp = xp - xpmax;
                level += 1;
                xpmax += 100;
                if (level > 99)
                {
                    Console.WriteLine("Error max level reached, 99 is the max level for the player");
                    level = 99;
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
            if (health >= 100)
            {
                health = 100;
            }
            
        }
        static void RegenerateShield( int shieldUP)
        {   
            Console.WriteLine("You get " + shieldUP + "Shield");
           
            if (shieldUP <= 0)
            { 
                shieldUP = 0;
                Console.WriteLine("You cannot negatively raise you shield...");
               
            } 
            shield += shieldUP;
            if (shield >= 100)
            {
                shield = 100;
            } 
           

            
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