using System;

namespace GestionDesTouches
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dat = DateTime.Now;
            Console.WriteLine("The time: {0:d} at {0:t}", dat);
            TimeZoneInfo tz = TimeZoneInfo.Local;
            Console.WriteLine("The time zone: {0}\n",
                              tz.IsDaylightSavingTime(dat) ?
                                 tz.DaylightName : tz.StandardName);
            Console.Write("Press <Enter> to exit... ");
            ConsoleKey touche = Console.ReadKey(true).Key;
            while (touche != ConsoleKey.Enter) 
            {
                
                if (touche == ConsoleKey.UpArrow)
                {
                    Console.WriteLine("haut");
                    
                }
                if (touche == ConsoleKey.DownArrow)
                {
                    Console.WriteLine("bas");
                }
                touche = Console.ReadKey(true).Key;
            }
        }
    }
}
