using System;

namespace Turn_Based_Combat
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHP = 100;
            int enemyHP = 100;

            int playerAttack = 5;
            int enemyAttack = 5;

            int healAmount = 5;

            Random random = new Random();

            while(playerHP > 0 && enemyHP > 0)
            {
                // Player turn
                Console.WriteLine("----- Player turn -----");
                Console.WriteLine(" Player HP: " + playerHP + " - Enemy HP: " + enemyHP "");
                Console.WriteLine("Enter 'a' to attack or 'h' to heal.");

                string choice = Console.ReadLine();

                if(choice == "a")
                {
                    enemyHP -= playerAttack;
                    Console.WriteLine("Player attack enemy and deals " + playerAttack + " damage");
                }
                else if(choice == "h")
                {
                    playerHP += healAmount;
                    Console.WriteLine("Player restores " + healAmount + " health Points!");
                }
                else
                {
                    Console.WriteLine("Enter valid input!");
                }

                // Enemy turn
                if(enemyHP > 0)
                {
                    Console.WriteLine("----- Enemy turn -----");
                    int enemyChoice = random.Next(0, 2);

                    if(enemyChoice == 0)
                    {
                        playerHP -= enemyAttack;
                        Console.WriteLine("Enemy attacks and deals " + enemyAttack + " damage!");
                    }
                    else
                    {
                        Console.WriteLine("Enemy restores " + healAmount + " health points!");
                    }
                }
            }

            if(playerHP > 0)
            {
                Console.WriteLine("Congratulations! You have won!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

        }
    }
}