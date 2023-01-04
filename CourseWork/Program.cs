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
            Console.WriteLine("What is your name?");
            string name = System.Console.ReadLine();
            bool confirmed = false;
            bool cheat = false;
            Console.Write("\nDo you want to see battleships? (Y/N): ");
            while (!confirmed)
            {
                Console.Write("\nPlease enter a selection: ");
                string answer = Console.ReadLine();
                if (answer == "Y")
                {
                    confirmed = true;
                    cheat = true;
                    Console.WriteLine("\nPlayer chose " + answer + " !");
                }
                else if (answer == "N")
                {
                    
                    Console.Write("\nPlayer chose not to see ships\n");
                    confirmed = true;
                    break;
                }
                else
                {
                    
                    Console.Write("\nPlease press enter Y/N... ");
                }
            }
            BattleshipBoard b = new BattleshipBoard();
            Player p = new Player(name, 0, 0 );
            
            p.GetGridBoard();
            
            while (p.GetHitCount() < 21)
            {
                b.DisplayBoard(p.GetGrid(), cheat);
                p.AskCoordinates();
            }
            p.SetGamesCount(p.GetGamesCount()+1);
            Console.WriteLine("Congratulations, " + p.GetUserName() + "! You Win!\r\n");
            Console.WriteLine("You missed: " + p.GetMissCount() + " times\r\n");
            Console.WriteLine("Thanks for playing BattleShip. Press enter to quit.");
            System.Console.ReadLine();
        }
    }
}