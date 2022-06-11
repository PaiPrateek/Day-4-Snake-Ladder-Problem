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
            int DieCount = 0;
            Console.WriteLine("Snake and Ladder Game Played with Single Palyer");
            Console.WriteLine("Start Position of the Player is : " + StartPosition);
            Console.WriteLine("Player Rolls the die");
            Console.WriteLine("........................");
            while(CurrentPosition <= 100)
            {
                Console.WriteLine("........................");
                Console.WriteLine("Present Position of the Player is : " + CurrentPosition);
                Random random = new Random();
                int die = random.Next(1, 7);
                Console.WriteLine("The die Number is : " + die);
                Random rndm = new Random();
                int Option = rndm.Next(0, 3);
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
                        if (PlayerPosition < 0)
                        {
                            PlayerPosition = 0;
                        }
                        break;
                }
                CurrentPosition += PlayerPosition;
                DieCount++;

                if (CurrentPosition > 100)
                {
                    CurrentPosition--;
                }
            }
            Console.WriteLine("The number of times the dice was played to win the game: "+ DieCount);
            Console.WriteLine("Player Win the Game");
        }
    }
}
