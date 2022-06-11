using System;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SnakeandLadder();
        }
        public static void SnakeandLadder()
        {
            int StartPosition = 0;
            int PlayerPosition = 0;
            int CurrentPosition = 0;
            Console.WriteLine("Snake and Ladder Game Played with Single Palyer");
            Console.WriteLine("Start Position of the Player is : " + StartPosition);
            Console.WriteLine("Player Rolls the die");
            Console.WriteLine("........................");
            Random random = new Random();
            int die = random.Next(1,7);
            Console.WriteLine("The die Number is : "+die);
            Random rndm = new Random();
            int Option = rndm.Next(1,3);
            switch (Option)
            {
                case 0:
                    Console.WriteLine("Player Option is : No Play");
                    PlayerPosition = PlayerPosition;
                    break;

                case 1:
                    Console.WriteLine("Player Option is : Ladder");
                    PlayerPosition = PlayerPosition + die;
                    break;

                case 2:
                    Console.WriteLine("Player Option is : Snake");
                    PlayerPosition = PlayerPosition - die;
                    break;
            }
            CurrentPosition += PlayerPosition;
            Console.WriteLine("Current Position of the Player is : "+CurrentPosition);
        }
    }
}
