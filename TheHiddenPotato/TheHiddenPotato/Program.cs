using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theHiddenPotato
{
    class Program
    {


        public static int playerHealth = 200;
        public static int playerAttack = 20;
        public static bool playerFight = false;

        public static int Roll(int _start, int _end)
        {
            Random rnd = new Random();
            return rnd.Next(_start, _end);
        }

        // Determines if you encounter an enemy or not
        public static void ChanceOfEncounter(int _fnum, int _lNum)
        {
            int roll;
            int level;
            int health;
            int attack;


            roll = Roll(_fnum, _lNum);

            switch (roll)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    level = Roll(5, 11);
                    health = level * 20;
                    attack = level * 4;


                    GiantPotatoTroll enemy1 = new GiantPotatoTroll(level, health, attack);
                    battle(enemy1.name, enemy1.health, enemy1.strength);
                    break;
                case 11:
                case 12:
                    level = Roll(1, 5);
                    health = level * 2;
                    attack = level * 1;

                    spudBaby enemy2 = new spudBaby(level, health, attack);
                    battle(enemy2.name, enemy2.health, enemy2.strength);
                    break;
            }
        }

        public static void battle(string _enemy, int _health, int _attack)
        {
            playerFight = true;

            Console.WriteLine();
            Console.WriteLine("You have entered battle with a " + _enemy);
            Console.WriteLine("The enemies health is: " + _health);
            Console.WriteLine();

            int enemyHealth = _health;
            int enemyAttack = _attack;
            int flip = Roll(1, 3);

            while (playerFight)
            {
                if (enemyHealth > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Would you like to attack?");
                    string response = Console.ReadLine();

                    if (response.ToLower() == "yes")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You attacked the creature.");
                        enemyHealth -= playerAttack;

                        if (flip == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You were struck by the enemy.");
                            playerHealth -= enemyAttack;
                            Console.WriteLine("Your health is now: " + playerHealth);
                        }



                        if (enemyHealth > 0)
                        {
                            Console.WriteLine("The enemy health is now: " + enemyHealth);
                        }
                        else if (enemyHealth <= 0)
                        {
                            Console.WriteLine("You beat the enemy!!");
                        }

                    }
                    else if (response.ToLower() == "no")
                    {
                        Console.WriteLine("There is no running.");
                        continue;
                    }
                    else if (response.ToLower() != "yes" && response.ToLower() != "no")
                    {
                        Console.WriteLine("Please enter YES or NO.");
                    }
                }
                else if (enemyHealth <= 0)
                {
                    break;
                }

            }

        }

        // main game loop
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name explorer!!");
            Console.Write(">:");
            string playerName = Console.ReadLine();

            Console.WriteLine("Wellcome, " + playerName + "!");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Which direction would you like to go?");
                Console.WriteLine("You can go FORWARD, LEFT, or RIGHT.");
                Console.Write(">: ");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "forward")
                {
                    ChanceOfEncounter(1, 13);
                }
                else if (choice.ToLower() == "left")
                {
                    ChanceOfEncounter(1, 13);
                }
                else if (choice.ToLower() == "right")
                {
                    ChanceOfEncounter(1, 13);
                }
                else if (choice.ToLower() == "back")
                {
                    ChanceOfEncounter(1, 13);
                }
                else if (choice.ToLower() == "exit")
                {
                    break;
                }
            }
        }
    }
}
