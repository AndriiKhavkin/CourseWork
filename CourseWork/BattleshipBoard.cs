using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWork
{
    public class BattleshipBoard
    {
        public static bool YN(string answer)
        {
            bool confirmed = false;
            bool yn = false;
            while (!confirmed)
            {
               
                if (answer == "Y")
                {
                    confirmed = true;
                    yn = true;
                    Console.WriteLine("Player chose to cheat!\n");
                }
                else if (answer == "N")
                {

                    Console.Write("Player chose not to see ships\n");
                    confirmed = true;
                    break;
                }
                else
                {
                    Console.Write("Please press enter Y/N... \n");
                    Console.Write("Please enter a selection: "); 
                    answer = Console.ReadLine();
                }
            }

            return yn;
        }
        public void DisplayBoard(char[,] Board1, char[,] Board2, bool cheatOn1, bool cheatOn2, Player p1, Player p2)
        {
            int Row;
            int Column;
            Console.WriteLine("\tPlayer 1: " + p1.GetUserName() + "\t\t\tPlayer 2: " + p2.GetUserName());
            Console.WriteLine("  ¦ 0 1 2 3 4 5 6 7 8 9\t\t  ¦ 0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("--+--------------------\t\t--+--------------------");
            for (Row = 0; Row <= 9; Row++)
            {
                Console.Write((Row).ToString() + " ¦ ");
                for (Column = 0; Column <= 9; Column++)
                {
                    if (!cheatOn1 && Board1[Column, Row] == 'S')
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(Board1[Column, Row] + " ");
                    }
                    Console.Write("");
                }
                Console.Write("\t");
                Console.Write((Row).ToString() + " ¦ ");
                for (Column = 0; Column <= 9; Column++)
                {
                    if (!cheatOn2 && Board2[Column, Row] == 'S')
                    {
                        Console.Write("  \t");
                    }
                    else
                    {
                        Console.Write(Board2[Column, Row] + " ");
                    }
                    
                }
                Console.WriteLine();
            }
 
            Console.WriteLine("");
        }
    }
}