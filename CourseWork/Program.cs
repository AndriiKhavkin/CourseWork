using System;
using System.Linq;
using System.Text;
using System.Threading;

namespace CourseWork
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.Title = "BattleShip!";
            Console. WriteLine("Welcome to BattleShip!\n"); 
            Console.WriteLine("What is your name player 1?");
            string name1 = System.Console.ReadLine();
            Console.WriteLine("What is your name player 2?");
            string name2 = System.Console.ReadLine();

            bool playAgain = true;
            bool cheat1 = false; 
            bool cheat2 = false;
            
            BattleshipBoard b1 = new BattleshipBoard();
            BattleshipBoard b2 = new BattleshipBoard();
            Player p1 = new Player(name1, 0, 0 );
            Bot p2 = new Bot(name2, 0, 0 );

            while (playAgain)
            {
                p1.SetHitCount(0);
                p2.SetHitCount(0);
                
                Console.Write("\nPlayer 1: " + p1.GetUserName() + " Do you want to see battleships? (Y/N): ");
                string answer1 = Console.ReadLine();
                cheat1 = Utils.YN(answer1);

                Console.Write("\nPlayer 2: " + p2.GetUserName() + " Do you want to see battleships? (Y/N): ");
                string answer2 = Console.ReadLine();
                cheat2 = Utils.YN(answer2);

                p1.GetGridBoard();
                Thread.Sleep(15);
                p2.GetGridBoard();

                while (p1.GetHitCount() < 21 && p2.GetHitCount() < 21)
                {
                    b1.DisplayBoard(p1.GetGrid(), p2.GetGrid(), cheat1, cheat2, p1, p2);
                    p1.AskCoordinates();
                    if (p1.GetHitCount() == 21)
                    {
                        Console.Write("Congratulations, " + p1.GetUserName() + "! You Win!\r\n");
                        Console.WriteLine("You missed: " + p1.GetMissCount() + " times\r\n");
                        break;
                    }

                    b2.DisplayBoard(p1.GetGrid(), p2.GetGrid(), cheat1, cheat2, p1, p2);
                    p2.AskCoordinates();
                }

                if (p2.GetHitCount() == 21)
                {
                    Console.Write("Congratulations, " + p2.GetUserName() + "! You Win!\r\n");
                    Console.WriteLine("You missed: " + p2.GetMissCount() + " times\r\n");
                }
                Console.WriteLine("Thanks for playing " + p2.GetUserName()+ "! You missed: " + p2.GetMissCount() + " times\r\n");
                p1.SetGamesCount(p1.GetGamesCount() + 1);
                p2.SetGamesCount(p2.GetGamesCount() + 1);
                Console.WriteLine("Thanks for playing BattleShip. Do you want to create new game? (Y/N)");
                string answer3 = Console.ReadLine();
                playAgain = Utils.YN(answer3);
            }
            
            Console.WriteLine("Thanks for playing BattleShip. Press any button to quit.");
            Console.ReadKey();
            Environment.Exit(-1);
        }
    }
}