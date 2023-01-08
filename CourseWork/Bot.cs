using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CourseWork
{
    public class Bot : Player
    {
        public Bot(string userName, int rating = 0, int gamesCount = 0) : base(userName, rating, gamesCount) { }
        
        
        char[,] _grid = new char[10, 10];
        
        int _x = 0;
        int _y = 0;
        public override void AskCoordinates()
        {
            Console.WriteLine("It is bot " +  GetUserName() + " turn");
            
            while (_grid[_x,_y] == 'H' || _grid[_x,_y] == 'M' )
            {
                _x = Utils.GetRandom(9);
                Thread.Sleep(10);
                _y = Utils.GetRandom(9);
            }
            
            Console.WriteLine("Bot chose [x,y]: [{0},{1}] " , _x, _y);
            Thread.Sleep(3000); 
            // Console.WriteLine("Enter X");
            // string line = Console.ReadLine();
            // int value;
            // if (int.TryParse(line, out value))
            // {
            //     _x = value;
            // }
            // else
            // {
            //     Console.WriteLine("Not an integer!");
            // }
            //
            // Console.WriteLine("Enter Y");
            // line = Console.ReadLine();
            // if (int.TryParse(line, out value))
            // {
            //     _y = value;
            // }
            // else
            // {
            //     Console.WriteLine("Not an integer!");
            // }
 
            try
            {
                if (_grid[_x, _y].Equals('S'))
                {
                    _grid[_x, _y] = 'H';
                    Console.Clear();
                    Console.WriteLine("Hit!\r\n");
                    //CheckShip( _grid,_x, _y);
                    HitCount += 1;
                }else if(_grid[_x, _y].Equals('H'))
                {
                    _grid[_x, _y] = 'H';
                    Console.Clear();
                    Console.WriteLine("You have already shoot down this ship!\r\n");
                }else
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