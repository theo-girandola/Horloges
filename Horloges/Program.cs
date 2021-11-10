using System;
using System.Reflection.Emit;

namespace Horloges
{
    class Program
    {
        static int[] Heures= {2, 4, 3, 9, 1, 7, 8, 6, 5, 12, 0, 11};
        static string[] HeuresEnLettres = { "DEUX\n", "QUATRE", "TROIS\n", "NEUF", "UNE", "SEPT\n", "HUIT", "SIX", "CINQ\n", "MIDI", "XMINUIT\n", "ONZE" };

        public static void Heure(int heure, int minute)
        {
            if (minute > 34)
            {
                heure++;
            }
            for (int compteur=0;compteur<Heures.Length;compteur++)
            if (heure ==Heures[compteur] )
            {
                Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(HeuresEnLettres[compteur]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(HeuresEnLettres[compteur]);
            }
         



        }
        public static void Minute(int minute)
        {

        }
        static void Main(string[] args)
        {
            int heure = DateTime.Now.Hour;
            if (heure > 12)
            {
                heure -= 12;
            }
            int minute = DateTime.Now.Minute;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("IL");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("N");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("EST");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("D");
            Heure(heure, minute);
            if(heure!=0  )
            {
                if (heure != 12)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("R");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("HEURES");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("R");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("HEURES");
                }
                
            }
        }
    }
}
