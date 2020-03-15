using System;

namespace GuessTheNumber
{
    public class Program
    {
        int theNumber;
        int max;     

        public Program()
        {
            Random rand = new Random();
             max = 100;
             theNumber = Math.Abs(rand.Next() % (max + 1));
        }

        public void play()
        {
            while(true)
            {
                string input = Console.ReadLine();
                int move = Convert.ToInt32(input);

                if (move > theNumber)
                {
                    Console.WriteLine("Your number is pretty big");
                }
                else if (move < theNumber)
                {
                    Console.WriteLine("Your number is pretty small");
                }
                else
                {
                    Console.WriteLine("You got it");
                    break;
                }
            }

        }       
        public static void Main(string[] args)
        {
            Program guessGame = new Program();
            Console.WriteLine($"Welcome to my game. Try and guess in between 0 and 100. Just type a number to get started");
            guessGame.play();
        }
    }
}
