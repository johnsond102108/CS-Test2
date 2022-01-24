using System;

namespace PA1._1
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Please enter a minimum number.");
            int minNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a maximum number.");
            int maxNum = Convert.ToInt32(Console.ReadLine());
            maxNum = maxNum + 1;

            Console.WriteLine("You have 5 attempts. Number's between " + minNum + " and " + (maxNum - 1) + '.');
            Random rd = new Random();
            int numRoll = rd.Next(minNum, maxNum);

            int numGuess;
            int lives = 5;
            while (lives != 0)
            {
                Console.WriteLine("Please enter a number.");
                numGuess = Convert.ToInt32(Console.ReadLine());
                
                if (numGuess == numRoll)
                {
                    Console.WriteLine("You had " + lives + " attempts remaining. Put in a little effort next time, yeah?");
                    break;
                }
                else if(lives > 1)
                {
                    lives -= 1;
                    if(numGuess > numRoll)
                    {
                        Console.WriteLine("Have you tried lowering your expectations?");
                    }
                    else
                    {
                        Console.WriteLine("You can't reach the stars, but you can go a little higher.");
                    }
                }else
                {
                    Console.WriteLine("You failed. Have you tried typing an answer?");
                    break;
                }
            }
            return 0;
        }
    }
}
