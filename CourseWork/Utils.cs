using System;

namespace CourseWork
{
    public class Utils
    {
        public static int GetRandom(int range)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int value = rnd.Next(range);
            return value;
        }
        
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
                    Console.WriteLine("Player chose Yes!\n");
                }
                else if (answer == "N")
                {

                    Console.Write("Player chose No!\n");
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
        
    }
    
}