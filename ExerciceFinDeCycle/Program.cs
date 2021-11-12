using System;

namespace ExerciceFinDeCycle
{
    class Program
    {
        public static string[] menu;

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

        public static void item1()
        {
            Console.Clear();
            Console.WriteLine("oui c'est une horloge");
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
        static void Main(string[] args)
        {
            menu = new string[3];
            menu[0] = "] : Afiiche l'horloge";
            menu[1] = "] : Trie a bulle d'un tableau";
            menu[2] = "] : Quitter";

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
                    }
                }
            }

        }
    }
}
