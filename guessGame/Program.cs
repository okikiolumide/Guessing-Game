using System.Security.Cryptography;
using System;

namespace guessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables Declaration
            int menu;
            int num;
            Random rand = new Random();
            
            //Level Selector
            Console.WriteLine("Welcome to Olumide Guessing Game!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Kindly Select a difficulty level....");
            Console.WriteLine("");
            //Game Levels
            Console.WriteLine("Press 1 for Easy");
            Console.WriteLine("Press 2 for Medium");
            Console.WriteLine("Press 3 for Hard");
            Console.WriteLine("-----------------------------------");

            menu = int.Parse(Console.ReadLine());
            

            if (menu == 1)
            {
                Console.WriteLine("Level: Easy");
                        for (int e = 0; e <= 5; e++) // Loop for 6 guesses
                        {
                        Console.WriteLine("Guess a number from 1-10");
                        num = int.Parse(Console.ReadLine());

                        int rand_num = (rand.Next(1,11)); //Generates Random Number from 1-10
                            if (num == rand_num)
                            {
                                Console.WriteLine("You are right!!!!");
                                break;
                            }
                            else
                            {
                                int guess_left = 5 - e;
                                 Console.WriteLine("That was wrong.");
                                Console.WriteLine("---------------------");
                                Console.WriteLine("You have " + guess_left + "guess(es) left. Try Again!!!");
                            }
                        } 
             Console.WriteLine("---------------");
             Console.WriteLine("Game Over!");
                        
            }
            else if(menu == 2)
            {
                Console.WriteLine("Level: Medium");
                        for (int m = 0; m <= 3; m++)//loop for 4 guesses
                        {
                        Console.WriteLine("Guess a number from 1-20");
                        num = int.Parse(Console.ReadLine());

                        int rand_num = (rand.Next(1,21)); // Generates Random Number from 1-20
                            if (num == rand_num)
                            {
                                Console.WriteLine("You are right!!!!");
                                break;
                            }
                            else
                            {
                                int guess_left = 3 - m;
                                Console.WriteLine("That was wrong.");
                                Console.WriteLine("---------------------");
                                Console.WriteLine("You have " + guess_left + "guess(es) left. Try Again!!!"); // Displays Guesses remaining
                            }
                        
                        }
                Console.WriteLine("---------------");
                Console.WriteLine("Game Over!");
            }
            else if (menu == 3)
            {
                Console.WriteLine("Level: Hard");
                    for (int h = 0; h <= 2; h++) //loop for 3 guesses
                    {
                    Console.WriteLine("Guess a number from 1-50");
                    num = int.Parse(Console.ReadLine());

                    int rand_num = (rand.Next(1,51)); //Generates Random Number from 1-50
                        if (num == rand_num)
                        {
                            Console.WriteLine("You are right!!!!");
                            break;
                        }else
                        {
                            int guess_left = 2 - h;
                                Console.WriteLine("That was wrong.");
                                Console.WriteLine("---------------------");
                                Console.WriteLine("You have " + guess_left + "guess(es) left. Try Again!!!"); //Shows Guesses Left
                        }
                    }
                Console.WriteLine("---------------");
                Console.WriteLine("Game Over!");
            }
            else
            {
                Console.WriteLine("Invalid Level Entry. Try Again!!!");
            }




        }
    }
}
