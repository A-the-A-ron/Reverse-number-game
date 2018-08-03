using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Think of a number between 1 - 500,I'm going to try and guess it in 10 tries.");
            Console.WriteLine("If my guess is higher than your number, 'less'. If it is lower than your number say 'more'.");
            Console.WriteLine("If I get it right, type 'correct'.");
            Console.WriteLine("Are you ready? (y/n)");
            string a = Console.ReadLine();
            if (a != "n")
                do
                {
                    {
                        int myMax = 501;
                        int myMin = 1;
                        string guess = "";
                        int t = 0;
                        do
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(myMin, myMax);
                            {
                                string myString = number.ToString();
                                Console.WriteLine(myString);

                                guess = Console.ReadLine();

                                if (guess == "more")
                                {
                                    myMin = number + 1;
                                    t += 1;

                                }
                                else if (guess == "less")
                                {
                                    myMax = number;
                                    t += 1;
                                }
                                else if (guess == "correct")
                                {
                                    break;
                                }
                                if (t == 10)
                                {
                                    break;
                                }


                            }
                        } while (guess != "correct" || t != 10);
                        if (t == 10)
                        {
                            Console.WriteLine("I lost!");
                        }
                        else if (guess == "correct")
                        {
                            Console.WriteLine("I won!");
                        }
                        Console.WriteLine("would you like to play again? (y/n)");
                        a = Console.ReadLine();
                        if (a == "y")
                        {
                            Console.Clear();
                        }
                    }
                } while (a != "n");
            if (a == "n")
            {
                Console.WriteLine("Goodbye!");
                Console.ReadKey();
            }
        }
    }
}
