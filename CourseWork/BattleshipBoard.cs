using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWork
{
    public class BattleshipBoard
    {
        private void WriteCell(char symbol)
        {
            if (symbol == ' ')
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan ;
                Console.Write("   ");
                Console.ResetColor(); 
                Console.Write("|");
            }else if(symbol == 'S'){
                Console.BackgroundColor = ConsoleColor.DarkGray ; 
                Console.ForegroundColor = ConsoleColor.Black ;
                Console.Write(" " + symbol + " ");
                Console.ResetColor(); 
                Console.Write("|");
            }else if (symbol == 'H')
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(" " + symbol + " ");
                Console.ResetColor();
                Console.Write("|");
            }else if (symbol == 'M')
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(" " + symbol + " ");
                Console.ResetColor();
                Console.Write("|");
            }else if (symbol == 'C')
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(" " + symbol + " ");
                Console.ResetColor();
                Console.Write("|");
            }
        }
        // public static bool YN(string answer)
        // {
        //     bool confirmed = false;
        //     bool yn = false;
        //     while (!confirmed)
        //     {
        //        
        //         if (answer == "Y")
        //         {
        //             confirmed = true;
        //             yn = true;
        //             Console.WriteLine("Player chose Yes!\n");
        //         }
        //         else if (answer == "N")
        //         {
        //
        //             Console.Write("Player chose No!\n");
        //             confirmed = true;
        //             break;
        //         }
        //         else
        //         {
        //             Console.Write("Please press enter Y/N... \n");
        //             Console.Write("Please enter a selection: "); 
        //             answer = Console.ReadLine();
        //         }
        //     }
        //
        //     return yn;
        // }
        public void DisplayBoard(char[,] Board1, char[,] Board2, bool cheatOn1, bool cheatOn2, Player p1, Bot p2)
        {
            int Row;
            int Column;
            Console.WriteLine("\t\tPlayer 1: " + p1.GetUserName() + "\t\t\t\t\tBot: " + p2.GetUserName());
            Console.WriteLine("  | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |\t\t  | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |");
            Console.WriteLine("--+----------------------------------------\t\t--+----------------------------------------");
            for (Row = 0; Row <= 9; Row++)
            {
                Console.Write((Row).ToString() + " |");
                for (Column = 0; Column <= 9; Column++)
                {
                    if (!cheatOn1 && Board1[Column, Row] == 'S')
                    {
                        //Console.Write("  |");
                        WriteCell(' ');
                    }
                    else
                    {
                        WriteCell(Board1[Column, Row]);
                        //Console.Write(" " + Board1[Column, Row] + " |");
                    }
                    Console.Write("");
                }
                Console.Write("\t\t");
                Console.Write((Row).ToString() + " |");
                for (Column = 0; Column <= 9; Column++)
                {
                    if (!cheatOn2 && Board2[Column, Row] == 'S')
                    {
                        //Console.Write("  |");
                        WriteCell(' ');
                    }
                    else
                    {
                        WriteCell(Board2[Column, Row]);
                        //Console.Write(" " + Board2[Column, Row] + " |");
                    }
                    
                }
                Console.Write("\n--+---------------------------------------\t\t--+---------------------------------------");
                Console.WriteLine();
            }
 
            Console.WriteLine("");
        }
    }
}