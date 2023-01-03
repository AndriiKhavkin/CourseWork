using System;
using System.Collections.Generic;

namespace CourseWork
{
    public class Patterns
    {
        public const int PatternsCount = 6;
        
        public static void PatternOne()
        {
            //1 of length 2
            Player.SetGrid(1, 2);
            Player.SetGrid(2, 2);
            //2 of length 3
            Player.SetGrid(4, 3);
            Player.SetGrid(4, 4);
            Player.SetGrid(4, 5);
 
            Player.SetGrid(5, 0);
            Player.SetGrid(6, 0);
            Player.SetGrid(7, 0);
            //1 of length 4
            Player.SetGrid(0, 8);
            Player.SetGrid(1, 8);
            Player.SetGrid(2, 8); 
            Player.SetGrid(3, 8);
            //1 of length 5
            Player.SetGrid(7, 4);
            Player.SetGrid(7, 5);
            Player.SetGrid(7, 6);
            Player.SetGrid(7, 7);
            Player.SetGrid(7, 8);
        }
        
        public static void PatternTwo()
        {
            //1 of length 2
            Player.SetGrid(4, 0);
            Player.SetGrid(5, 0);
            //2 of length 3
            Player.SetGrid(8, 1);
            Player.SetGrid(8, 2);
            Player.SetGrid(8, 3);
 
            Player.SetGrid(0, 8);
            Player.SetGrid(1, 8);
            Player.SetGrid(2, 8);
            //1 of length 4
            Player.SetGrid(4, 6);
            Player.SetGrid(5, 6);
            Player.SetGrid(6, 6); 
            Player.SetGrid(7, 6);
            //1 of length 5
            Player.SetGrid(2, 1);
            Player.SetGrid(2, 2);
            Player.SetGrid(2, 3);
            Player.SetGrid(2, 4);
            Player.SetGrid(2, 5);
        }
        
        public static void PatternThree()
        {
            //1 of length 2
            Player.SetGrid(3,5);
            Player.SetGrid(4,5);
            //2 of length 3
            Player.SetGrid(0, 0);
            Player.SetGrid(0, 1);
            Player.SetGrid(0, 2);
 
            Player.SetGrid(8, 3);
            Player.SetGrid(8, 4);
            Player.SetGrid(8, 5);
            //1 of length 4
            Player.SetGrid(1, 8);
            Player.SetGrid(2, 8);
            Player.SetGrid(3, 8); 
            Player.SetGrid(4, 8);
            //1 of length 5
            Player.SetGrid(3, 1);
            Player.SetGrid(4, 1);
            Player.SetGrid(5, 1);
            Player.SetGrid(6, 1);
            Player.SetGrid(7, 1);
        }
        
        public static void PatternFour()
        {
            //1 of length 2
            Player.SetGrid(0, 5);
            Player.SetGrid(0, 6);
            //2 of length 3
            Player.SetGrid(1, 0);
            Player.SetGrid(2, 0);
            Player.SetGrid(3, 0);
 
            Player.SetGrid(9, 7);
            Player.SetGrid(9, 8);
            Player.SetGrid(9, 9);
            //1 of length 4
            Player.SetGrid(9, 0);
            Player.SetGrid(9, 1);
            Player.SetGrid(9, 2); 
            Player.SetGrid(9, 3);
            //1 of length 5
            Player.SetGrid(0, 9);
            Player.SetGrid(1, 9);
            Player.SetGrid(2, 9);
            Player.SetGrid(3, 9);
            Player.SetGrid(4, 9);
        }
        
        public static void PatternFive()
        {
            //1 of length 2
            Player.SetGrid(1, 1);
            Player.SetGrid(1, 2);
            //2 of length 3
            Player.SetGrid(3, 2);
            Player.SetGrid(3, 3);
            Player.SetGrid(3, 4);
 
            Player.SetGrid(3, 5);
            Player.SetGrid(3, 6);
            Player.SetGrid(3, 7);
            //1 of length 4
            Player.SetGrid(5, 2);
            Player.SetGrid(5, 3);
            Player.SetGrid(5, 4); 
            Player.SetGrid(5, 5);
            //1 of length 5
            Player.SetGrid(8, 2);
            Player.SetGrid(8, 3);
            Player.SetGrid(8, 4);
            Player.SetGrid(8, 5);
            Player.SetGrid(8, 6);
        }
        
        public static void PatternSix()
        {
            //1 of length 2
            Player.SetGrid(1, 1);
            Player.SetGrid(1, 2);
            //2 of length 3
            Player.SetGrid(3, 0);
            Player.SetGrid(4, 0);
            Player.SetGrid(4, 0);
 
            Player.SetGrid(9, 4);
            Player.SetGrid(9, 5);
            Player.SetGrid(9, 6);
            //1 of length 4
            Player.SetGrid(5, 8);
            Player.SetGrid(6, 8);
            Player.SetGrid(7, 8); 
            Player.SetGrid(8, 8);
            //1 of length 5
            Player.SetGrid(5, 2);
            Player.SetGrid(5, 3);
            Player.SetGrid(5, 4);
            Player.SetGrid(5, 5);
            Player.SetGrid(5, 6);
        }
        
    }
}