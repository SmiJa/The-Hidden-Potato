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
        public static int playerAttack = 30;
        public static bool playerFight = false;


        // Custom roll function
        public static int Roll(int _start, int _end)
        {
            Random rnd = new Random();
            return rnd.Next(_start, _end);
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
                    ChanceOfEncounter(1, 101);
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

                if (playerHealth <= 0)
                {
                    Console.WriteLine("Press any key to exit the game.");
                    Console.ReadKey();
                }
            }
        }


        // Determines if you encounter an enemy or not
        public static void ChanceOfEncounter(int _fnum, int _lNum)
        {
            int roll;
            int level;
            int health;
            int attack;
            int monsterSelect;


            roll = Roll(_fnum, _lNum);

            if (roll > 75)
            {
                monsterSelect = Roll(_fnum, _lNum);

                if (monsterSelect > 99)
                {
                    level = Roll(5, 11);
                    health = level * 20;
                    attack = level * 4;


                    GiantPotatoTroll enemy1 = new GiantPotatoTroll(level, health, attack);
                    battle(enemy1.name, enemy1.health, enemy1.strength);
                }
                else if (monsterSelect > 60)
                {
                    level = Roll(5, 11);
                    health = level * 20;
                    attack = level * 4;


                    yamBeast enemy2 = new yamBeast(level, health, attack);
                    battle(enemy2.name, enemy2.health, enemy2.strength);
                }
                else if (monsterSelect > 50)
                {
                    level = Roll(5, 11);
                    health = level * 20;
                    attack = level * 4;


                    Papas enemy3 = new Papas(level, health, attack);
                    battle(enemy3.name, enemy3.health, enemy3.strength);
                }
                else if (monsterSelect > 30)
                {
                    level = Roll(2, 9);
                    health = level * 4;
                    attack = level * 2;


                    totArmy enemy4 = new totArmy(level, health, attack);
                    battle(enemy4.name, enemy4.health, enemy4.strength);
                }
                else if (monsterSelect > 8)
                {
                    level = Roll(1, 5);
                    health = level * 2;
                    attack = level * 1;

                    spudBaby enemy5 = new spudBaby(level, health, attack);
                    battle(enemy5.name, enemy5.health, enemy5.strength);
                }
                
            }
        }


        /// <summary>
        /// Battle loop runs here.
        /// </summary>
        /// <param name="_enemy"></param>
        /// <param name="_health"></param>
        /// <param name="_attack"></param>
        public static void battle(string _enemy, int _health, int _attack)
        {
            playerFight = true;

            Console.WriteLine();
            Console.WriteLine("You have entered battle with a " + _enemy);
            Console.WriteLine();

            int enemyHealth = _health;
            int enemyAttack = _attack;

            while (playerFight)
            {
                

                if (enemyHealth > 0)
                {

                    int playerFlip = Roll(1, 101);
                    int enemyFlip = Roll(1, 101);


                    Console.WriteLine();
                    Console.WriteLine("Would you like to attack?");
                    string response = Console.ReadLine();
                    Console.WriteLine("-------------------------------------------");

                    // Fighting happens here
                    #region Actual fight
                    if (response.ToLower() == "yes")
                    {                      

                        if (playerFlip < 50)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You attacked the creature.");
                            enemyHealth -= playerAttack;
                        }
                        else if (playerFlip >= 50)
                        {
                            Console.WriteLine();
                            Console.WriteLine("The enemy blocked your attack.");
                        }
                        

                        // Enemy Strikes player
                        if (enemyFlip >= 70)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You were struck by the enemy.");
                            playerHealth -= enemyAttack;
                            Console.WriteLine("Your health is now: " + playerHealth);
                            Console.WriteLine("-------------------------------------------");

                            if (playerHealth <= 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("The Enemy has killed you.");
                                Console.WriteLine("Your adventure is now over.");
                                Console.WriteLine();
                                Console.WriteLine("-------------------------------------------");
                                Console.WriteLine();
                                break;
                            }
                        }
                        else if (enemyFlip < 70)
                        {
                            Console.WriteLine();
                            Console.WriteLine("The enemy has missed.");
                        }

                        // If enemy is dead
                        if (enemyHealth <= 0)
                        {
                            Console.WriteLine("You beat the enemy!!");
                            Console.WriteLine("-------------------------------------------");
                        }

                        

                    }
                    #endregion

                    // Check for other input
                    #region Other Responses
                    else if (response.ToLower() == "no")
                    {
                        Console.WriteLine("There is no running.");
                        continue;
                    }
                    else if (response.ToLower() != "yes" && response.ToLower() != "no")
                    {
                        Console.WriteLine("Please enter YES or NO.");
                    }
                    #endregion
                }
                else if (enemyHealth <= 0)
                {
                    break;
                }

            }

        }

    }
}
