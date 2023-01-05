﻿using System;
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
            
            bool cheat1 = false; 
            bool cheat2 = false;
            
            BattleshipBoard b1 = new BattleshipBoard();
            BattleshipBoard b2 = new BattleshipBoard();
            Player p1 = new Player(name1, 0, 0 );
            Player p2 = new Player(name2, 0, 0 );
            
            Console.Write("\nPlayer 1: " + p1.GetUserName() +"Do you want to see battleships? (Y/N): ");
            string answer1 = Console.ReadLine();
            cheat1 = BattleshipBoard.YN(answer1);
            
            Console.Write("\nPlayer 2: " + p2.GetUserName() +"Do you want to see battleships? (Y/N): ");
            string answer2 = Console.ReadLine();
            cheat2 = BattleshipBoard.YN(answer2);
            
            p1.GetGridBoard();
            Thread.Sleep(5);
            p2.GetGridBoard();
            
            while (p1.GetHitCount() < 21 || p2.GetHitCount() < 21 )
            {
                b1.DisplayBoard(p1.GetGrid(), p2.GetGrid(), cheat1, cheat2, p1, p2);
                p1.AskCoordinates();
                if (p1.GetHitCount() < 21)
                {
                    Console.Write("Congratulations, " + p1.GetUserName() + "! You Win!\r\n");
                    break;
                }
                p2.AskCoordinates();
            }
            p1.SetGamesCount(p1.GetGamesCount()+1); 
            p2.SetGamesCount(p1.GetGamesCount()+1);
            
            Console.WriteLine("Congratulations, " + p1.GetUserName() + "! You Win!\r\n");
            Console.WriteLine("You missed: " + p1.GetMissCount() + " times\r\n");
            
            Console.WriteLine("Congratulations, " + p2.GetUserName() + "! You Win!\r\n");
            Console.WriteLine("You missed: " + p2.GetMissCount() + " times\r\n");
            
            Console.WriteLine("Thanks for playing BattleShip. Press enter to quit.");
            System.Console.ReadLine();
        }
    }
}