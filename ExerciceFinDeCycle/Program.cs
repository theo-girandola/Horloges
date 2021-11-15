using System;
using System.Reflection.Emit;
using System.Threading;
using System.ServiceProcess;

namespace ExerciceFinDeCycle
{
    class Program
    {
        public static string[] menu;
        static int[] Heures = { 2, 4, 3, 9, 1, 7, 8, 6, 5, 12, 50, 0, 11 };
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
            for (int compteur = 0; compteur < Heures.Length; compteur++)
                if (heure == Heures[compteur])
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
            if (minute > 4 && minute < 10 || minute > 54 && minute < 60 || minute > 34 && minute < 40 || minute > 24 && minute < 30)
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

            if (minute > 9 && minute < 15 || minute > 49 && minute < 55)
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

            if (minute > 39 && minute < 45 || minute > 19 && minute < 25 || minute > 34 && minute < 40 || minute > 24 && minute < 30)
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
            if (minute > 29 && minute < 35)
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
        public static void AffichageDuTableau(int[] tableau)
        {
            for (int compteur = 0; compteur < tableau.Length; compteur++)
            {
                if (compteur == tableau.Length - 1)
                {
                    Console.WriteLine(tableau[compteur]);
                }
                else
                {
                    if (compteur == tableau.Length - 2)
                    {
                        Console.Write(tableau[compteur] + " et ");
                    }
                    else
                    {
                        Console.Write(tableau[compteur] + ", ");
                    }
                }
            }
        }
        public static void TriABulle()
        {
            Console.Clear();
            Random generateurDeNombreAleatoires = new Random();

            int[] tableauNonTrier = new int[generateurDeNombreAleatoires.Next(5, 50)];
            for (int compteur = 0; compteur < tableauNonTrier.Length; compteur++)
            {
                tableauNonTrier[compteur] = generateurDeNombreAleatoires.Next(0, tableauNonTrier.Length * 10);
            }
            Console.Write("Tableau Non Trié: ");
            AffichageDuTableau(tableauNonTrier);
            for (int i = tableauNonTrier.Length - 2; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (tableauNonTrier[j - 1] > tableauNonTrier[j])
                    {
                        int temp = tableauNonTrier[j - 1];
                        tableauNonTrier[j - 1] = tableauNonTrier[j];
                        tableauNonTrier[j] = temp;
                    }
                }
            }
            Console.Write("Tableau Trié: ");
            AffichageDuTableau(tableauNonTrier);
            if (Console.ReadKey() != null)
            {
                Console.Clear();
                MenuBase();
                
            }
        }


        public static void ShowItems(int selected)
        {
            int indexSelectionned = selected;
            Console.WriteLine("MENU PRINCIPAL\n\n");
            for (int compteur = 0; compteur < menu.Length; compteur++)
            {
                if (compteur == indexSelectionned)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("[");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("X");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("[");
                    Console.Write(" ");
                }
                Console.WriteLine(menu[compteur]);
            }
            Console.Write("\n\nSe déplacer avec les flèches haut et bas pour sélectionner l'item et valider par la touche ENTREE");



        }
        public static bool VerifierSiDansTab(int index)
        {
            if (index >= 0 && index < menu.Length)
            {
                return true;
            }
            else
            {
                return false;

            }


        }
        public static void Horloge()
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
                DateTime date1 = DateTime.Now;
                Console.WriteLine(date1);
                Thread.Sleep(1000);
                if (Console.KeyAvailable==true)
                {
                    break;
                    
                }
            }
        }

        public static void item1()
        {
            Horloge();
            Console.Clear();
            MenuBase();
        }
        public static void item2()
        {
            TriABulle();

        }
        public static void item3()
        {
            Console.Clear();
            Environment.Exit(0);
        }
        public static void item4()
        {
            TriABulle();

        }
        public static void MenuBase()
        {
            menu = new string[4];
            menu[0] = "] : Affiche l'horloge";
            menu[1] = "] : Tri à bulle d'un tableau";
            menu[2] = "] : Tour de Hanoi";
            menu[3] = "] : Quitter";

            int select = 0;
            ShowItems(select);

            ConsoleKey touche = Console.ReadKey(true).Key;

            while (touche != ConsoleKey.Enter)
            {

                if (touche == ConsoleKey.UpArrow)
                {
                    select--;
                    if (VerifierSiDansTab(select) == false)
                    {
                        select = menu.Length - 1;
                    }
                }
                if (touche == ConsoleKey.DownArrow)
                {
                    select++;

                    if (VerifierSiDansTab(select) == false)
                    {
                        select = 0;
                    }
                }

                Console.Clear();
                ShowItems(select);
                touche = Console.ReadKey(true).Key;
            }
            if (touche == ConsoleKey.Enter)
            {
                if (select == 0)
                {
                    item1();
                }
                else
                {
                    if (select == 1)
                    {
                        item2();
                    }
                    else
                    {
                        if (select == 2)
                        {
                            item3();
                        }
                        else
                        {
                            if (select == 3)
                            {
                                item4();
                            }
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            MenuBase();
            
                }
            }
           

        
   
}
