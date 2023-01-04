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
        
        char[,] _grid = new char[10, 10];
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
        
        public void GetGridBoard()
        {
            _grid = Patterns.GetPattern();
        }
      
    }
}