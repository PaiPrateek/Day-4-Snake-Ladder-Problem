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
            Console.WriteLine("Snake and Ladder Game Played with Single Palyer");
            Console.WriteLine("Start Position of the Player is : " + StartPosition);
            Console.WriteLine("Player Rolls the die");
            Console.WriteLine("........................");
            Random random = new Random();
            int die = random.Next(1,7);
            Console.WriteLine("The die Number is : "+die);
        }
    }
}
