using System;

namespace PA1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am thinking of a number between 0 and 100.");
            Random rd = new Random();
            int numRoll = rd.Next(0, 100);

            int numGuess;
            int lives = 5;
            while (lives != 0)
            {
                Console.WriteLine("Please guess a number.");
                
            }
        }
    }
}
