﻿using System;
using System.Collections.Generic;

namespace CourseWork
{
    public class Patterns
    {
        public const int PatternsCount = 6;
        private static char[][,] _patterns  = new char[][,] {
            new char[,]{ 
            {' ','S',' ',' ',' ','S','S','S',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ','S','S',' ',' ',' ',' ',' ','S',' '},
            {' ',' ',' ',' ','S',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ','S',' ',' ','S',' ',' '},
            {'S',' ',' ',' ','S',' ',' ','S',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ','S',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ','S',' ',' '},
            {'S','S','S','S',' ',' ',' ','S',' ',' '},
            {' ',' ',' ',' ',' ','S',' ',' ',' ',' '}
        },
            new char[,]{ 
                {'S',' ',' ',' ',' ',' ',' ',' ',' ','S'},
                {'S',' ',' ','S','S','S','S','S',' ',' '},
                {'S',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ','S',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ','S',' '},
                {'S',' ',' ','S','S',' ',' ',' ','S',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ','S',' ',' ',' '},
                {' ','S','S','S','S',' ',' ',' ','S',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '}
            },            
            new char[,]{ 
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ','S',' ','S',' ',' ',' ',' ','S',' '},
                {' ','S',' ','S',' ','S',' ',' ','S',' '},
                {' ',' ',' ','S',' ','S',' ',' ','S',' '},
                {' ',' ',' ',' ',' ','S',' ',' ','S',' '},
                {' ','S',' ','S',' ','S',' ',' ','S',' '},
                {' ',' ',' ','S',' ',' ',' ',' ',' ',' '},
                {' ','S',' ','S',' ',' ','S',' ','S',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '}
            },
            new char[,]{ 
                {' ',' ',' ',' ','S','S',' ',' ',' ',' '},
                {' ',' ','S',' ',' ',' ',' ',' ','S',' '},
                {' ',' ','S',' ',' ','S',' ',' ','S',' '},
                {' ',' ','S',' ',' ',' ',' ',' ','S',' '},
                {'S',' ','S',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ','S',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ','S','S','S','S',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ','S'},
                {'S','S','S',' ',' ','S',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '}
            },
            new char[,]{ 
                {' ',' ',' ','S','S','S',' ',' ',' ',' '},
                {' ','S',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ','S',' ',' ',' ','S',' ','S',' ',' '},
                {' ',' ',' ',' ',' ','S',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ','S',' ',' ',' ','S'},
                {' ','S',' ',' ',' ','S',' ',' ',' ','S'},
                {' ',' ',' ',' ',' ','S',' ',' ',' ','S'},
                {' ',' ','S',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ','S','S','S','S',' '},
                {'S',' ',' ',' ',' ',' ',' ',' ',' ',' '}
            },
            new char[,]{ 
                {' ','S','S','S',' ','S',' ',' ',' ','S'},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ','S'},
                {'S',' ',' ',' ',' ',' ',' ',' ',' ','S'},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ','S'},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {'S',' ',' ',' ',' ',' ',' ',' ',' ','S'},
                {'S',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ','S'},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ','S'},
                {'S','S','S','S','S',' ','S',' ',' ','S'}
            }
        };
        private static int GetRandom(int range)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int value = rnd.Next(range);
            return value;
        }

        public static char[,] GetPattern()
        {
            int patternNumber = GetRandom(5) + 1;
            return _patterns[patternNumber];
        }
               
    }
}