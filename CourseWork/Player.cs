using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWork
{
    public class Player
    {
        public Player(string userName, int rating = 0, int gamesCount = 0)
        {
            UserName = userName;
            CurrentRating = rating < 1 ? 1 : rating;
            GamesCount = gamesCount;
        }
        
        private string UserName;
        private int CurrentRating;
        private int GamesCount;
        
        public int GetRating() { return CurrentRating;}
        public int GetGamesCount() { return GamesCount;}
        public void SetGamesCount(int Value) { GamesCount = Value < 0 ? 0 : Value;}
        public string GetUserName() { return UserName;}
        
        static char[,] _grid = new char[10, 10];
        public int HitCount = 0;
        public int MissCount = 0;
        int _x = 0;
        int _y = 0;
 
        public int GetHitCount()
        {
            return HitCount;
        }
        public int GetMissCount()
        {
            return MissCount;
        }
        public void AskCoordinates()
        {
            Console.WriteLine("Enter X");
            string line = Console.ReadLine();
            int value;
            if (int.TryParse(line, out value))
            {
                _x = value;
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }
 
            Console.WriteLine("Enter Y");
            line = Console.ReadLine();
            if (int.TryParse(line, out value))
            {
                _y = value;
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }
 
            try
            {
                if (_grid[_x, _y].Equals('S'))
                {
                    _grid[_x, _y] = 'H';
                    Console.Clear();
                    Console.WriteLine("Hit!\r\n");
                    HitCount += 1;
                }
                else
                {
                    _grid[_x, _y] = 'M';
                    Console.Clear();
                    Console.WriteLine("Miss!\r\n");
                    MissCount += 1;
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error: Please enter numbers between 0 and 9. (Inclusive)");
            }
        }
        
        
        public char[,] GetGrid()
        {
            return _grid;
        }
        public static void SetGrid(int q, int w)
        {
            _grid[q, w] = 'S';
        }
        private static int GetRandom(int range)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int value = rnd.Next(range);
            return value;
        }
        public void GetPattern()
        {
            int patternNumber = GetRandom(5) + 1;
            switch (patternNumber)
            {
                case 1:
                    Patterns.PatternOne();
                    break;
                case 2:
                    Patterns.PatternTwo();
                    break;
                case 3:
                    Patterns.PatternThree();
                    break;
                case 4:
                    Patterns.PatternFour();
                    break;
                case 5:
                    Patterns.PatternFive();
                    break;
                case 6:
                    Patterns.PatternSix();
                    break;
                default:
                    throw new ArgumentException($"Pattern number {patternNumber} does not exist.");
            }

        }
    }
}