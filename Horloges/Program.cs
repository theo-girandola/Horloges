using System;
using System.Reflection.Emit;
using System.Threading;
using System.ServiceProcess;

namespace Horloges
{
    class Program
    {
        static int[] Heures= {2, 4, 3, 9, 1, 7, 8, 6, 5, 12, 50, 0, 11};
        static string[] HeuresEnLettres = { "DEUX\n", "QUATRE", "TROIS\n", "NEUF", "UNE", "SEPT\n", "HUIT", "SIX", "CINQ\n", "MIDI", "X", "MINUIT\n", "ONZE" };
        


        public static void IlEst()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("IL");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("N");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("EST");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("D");
        }

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
       
        public static void HeuresAffich(int heure)
        {
            if (heure != 0)
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
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("R");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("HEURES");
            }
        }


        


        public static void MoinsMinute(int minute)
        {
            if (minute > 34)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nMOINS");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("O");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("\nMOINS");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("O");
            }
        }


        public static void EtQuartMinute(int minute)
        {
            if (minute > 34)
            {
                if (minute > 14 && minute < 20)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("ET");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("R");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("QUART");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("OES\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("ETRQUARTOES\n");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("ETRQUARTOES\n");
            }
        }

        public static void LeMinute(int minute)
        {
            if (minute > 34)
            {
                if (minute > 44 && minute < 50)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("LE");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("LE");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("LE");
            }
        }


        public static void CinqMinute(int minute)
        {
            if (minute > 4 && minute < 10 || minute > 54 && minute < 60 || minute >34 && minute < 40 || minute > 24 && minute < 30)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("CINQ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("CINQ");
            }
        }


        public static void DixMinute(int minute)
        {

            if (minute > 9 && minute < 15|| minute > 49 && minute < 55)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("DIX\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("DIX\n");
            }
        }
        public static void vingthMinute(int minute)
        {

            if (minute > 39 && minute < 45 || minute > 19 && minute < 25|| minute > 34 && minute < 40 || minute > 24 && minute < 30)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("VINGT");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("VINGT");
            }
        }
        public static void TiretMinute(int minute)
        {
            if (minute > 34 && minute < 40 || minute > 24 && minute < 30)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("-");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("-");
            }
        }
        public static void EtDemiMinute(int minute)
        {
            if (minute >29  && minute < 35)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("O\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("ET");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("S");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("DEMI");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("EPAN\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("O\nETSDEMIEPAN\n");
            }
        }

        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Clear();
                int heure = DateTime.Now.Hour;
                if (heure > 12)
                {
                    heure -= 12;
                }
                int minute = DateTime.Now.Minute;
                IlEst();
                Heure(heure, minute);
                HeuresAffich(heure);
                MoinsMinute(minute);
                LeMinute(minute);
                DixMinute(minute);
                EtQuartMinute(minute);
                vingthMinute(minute);
                TiretMinute(minute);
                CinqMinute(minute);
                EtDemiMinute(minute);
                DateTime date1= DateTime.Now;
                Console.WriteLine(date1);
                Thread.Sleep(1000);
                if (Console.ReadKey()!= null)
                {

                }
            }
            
        }
    }
}
