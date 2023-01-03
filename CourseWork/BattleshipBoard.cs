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

            return yn;
        }
        public void DisplayBoard(char[,] Board, bool cheatOn)
        {
            int Row;
            int Column;
 
            Console.WriteLine("  ¦ 0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("--+--------------------");
            for (Row = 0; Row <= 9; Row++)
            {
                Console.Write((Row).ToString() + " ¦ ");
                for (Column = 0; Column <= 9; Column++)
                {
                    if (!cheatOn && Board[Column, Row] == 'S')
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(Board[Column, Row] + " ");
                    }
                }
                Console.WriteLine();
            }
 
            Console.WriteLine("");
        }
    }
}