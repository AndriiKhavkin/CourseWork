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
 
        public int GetHitCount() { return HitCount; }
        public void SetHitCount(int Value) { GamesCount = Value < 0 ? 0 : Value; }
        
        public int GetMissCount() { return MissCount; }

        public void CheckShip()
        {
            
        }
        public virtual void AskCoordinates()
        {
            Console.WriteLine("It is player " +  GetUserName() + " turn");
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

        public void Achievment()
        {
            if (GetMissCount()==0)
            {
                Console.Write("Congratulations, you managed to win without a single miss!");
                char slash = '\\' ;
                Console.Write("\n         . \n         " + slash +  "*" + slash + "\n         " + slash +  "  " + slash +  "      _-*|\n        _" +  slash + "    " + slash +  "_-*   |\n _____-*__________-*_______");
                
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
        // public void CheckShip(char[,] Board, int x, int y)
        // {
        //     bool cont = true;
        //     int n = 0;
        //     int ammount = 0;
        //     while (cont)
        //     {
        //         n++;
        //         if (Board[x,y]== 'H' && Board[x+n,y]== 'H')
        //         {
        //             ammount++;
        //         }  else break; 
        //     }
        //     while (cont)
        //     {
        //         n++;
        //         if (Board[x,y]== 'H' && Board[x-n,y]== 'H')
        //         {
        //             ammount++;
        //         }  else break; 
        //     } 
        //     while (cont)
        //     {
        //         n++;
        //         if (Board[x,y]== 'H' && Board[x,y+n]== 'H')
        //         {
        //             ammount++;
        //         }  else break; 
        //     }
        //     while (cont)
        //     {
        //         n++;
        //         if (Board[x,y]== 'H' && Board[x,y-n]== 'H')
        //         {
        //             ammount++;
        //         }  else break; 
        //     }
        //
        //     if (ammount==1)
        //     {
        //         Console.WriteLine("You have sunk single-deck ship!");
        //         Board[x, y--] = 'C';
        //         Board[x++, y--] = 'C';
        //         Board[x++, y] = 'C';
        //         Board[x++, y--] = 'C';
        //         Board[x, y++] = 'C';
        //         Board[x--, y++] = 'C';
        //         Board[x--, y] = 'C';
        //         Board[x--,y--] = 'C';
        //     }else if (ammount==2)
        //     {
        //         Console.WriteLine("You have sunk two-deck ship!");
        //     }else if (ammount==3)
        //     {
        //         Console.WriteLine("You have sunk three-deck ship!");
        //     }else if (ammount==4)
        //     {
        //         Console.WriteLine("You have sunk four-deck ship!");
        //     }else
        //     {
        //         Console.WriteLine("You have sunk five-deck ship!");
        //     }
        //     
        // }
    }
}