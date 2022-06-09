using System;

namespace NumberGuessingGame
{
    class Game
    {
        private int lowerNumber;
        private int upperNumber;
        private int number;
        private int guess;
        private int attemptNumber = 1;

        public Game(int lnum, int unum)
        {
            lowerNumber = lnum;
            upperNumber = unum;
            Console.Write($"{lowerNumber} is the lower limit && ");
            Console.WriteLine($"{upperNumber} is the upper limit");
            number = RandomNumber(lnum, unum);
            Console.WriteLine(number);
        }

        private int RandomNumber(int lnum, int unum)
        {

            System.Random Random = new System.Random();
            return Random.Next(lnum, unum);
        }
        // Loop to keep the game running
        public void gameLoop()
        {

            while (guess != number)
            {
                if (attemptNumber++ == 1) Console.WriteLine("Take a guess of the number I am thinking.");
                else if (guess > number) Console.WriteLine("Guess a little lower. Try Again !!!");
                else if (guess < number) Console.WriteLine("Guess a little higher. Try Again !!!");
                else if (guess == number)
                {
                    break;
                };
                guess = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("You won!!!! Congratulations.");


        }
    }

    public class MainClass
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the lower limit for the game");
            int lower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the lower limit for the game");
            int upper = Convert.ToInt32(Console.ReadLine());
            var newgame = new Game(lower, upper);
            Console.WriteLine("Game has been started");
            newgame.gameLoop();
        }
    }
}

