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
        private const int LARGEUR_CONSOLE = 80;
        private const int NOMBRE_MINI_DISQUES = 3;
        private const int NOMBRE_MAXI_DISQUES = 10;


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
        private static void EffacerLigne(int posY)
        {
            Console.SetCursorPosition(0, posY);
            Console.Write(new String(' ', LARGEUR_CONSOLE));
        }

        private static void AfficherTexte(int posX, int posY, string contenu)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write(contenu);
        }

        private static void AfficherTexteCommandeNonReconnueOuInterdite(int posX, int posY)
        {
            AfficherTexte(posX, posY, "Commande non reconnue ou interdite. Touche ENTREE pour continuer");
            Console.ReadLine();
        }

        private static int GetNombreDeDisques()
        {
            int nombreDeDisques = 0;
            do
            {
                EffacerLigne(3);
                AfficherTexte(0, 3, $"Nombre de disques (entre {NOMBRE_MINI_DISQUES} et {NOMBRE_MAXI_DISQUES} inclus) : ");
            }
            // On reste dans la boucle tant que la saisie n'est pas entier et si c'est un entier, il doit être compris entre 3 et 10
            while (!(int.TryParse(Console.ReadLine(), out nombreDeDisques) && nombreDeDisques >= NOMBRE_MINI_DISQUES && nombreDeDisques <= NOMBRE_MAXI_DISQUES));
            return nombreDeDisques;
        }

        private static void AfficherUnDisque(int posX, int posY, int tailleDuDisque, int nombreDeDisques)
        {
            string disque;

            if (tailleDuDisque == 0)
            {
                disque = "|";
            }
            else
            {
                disque = "/";
                for (int i = 1; i < tailleDuDisque; i++)
                {
                    disque += "=";
                }
                disque += "|";
                for (int i = 1; i < tailleDuDisque; i++)
                {
                    disque += "=";
                }
                disque += "\\";
            }
            AfficherTexte(posX + nombreDeDisques - tailleDuDisque, posY, disque);
        }

        private static void AfficherLaTour(int posX, int posY, int numeroDeLaTour, int[] tour)
        {
            int nombreDeDisques = tour.Length;
            for (int i = 0; i < nombreDeDisques; i++)
            {
                AfficherUnDisque(posX, posY + i, tour[i], nombreDeDisques);
            }
            AfficherTexte(posX, posY + nombreDeDisques, new string('-', nombreDeDisques * 2 + 1));
            AfficherTexte(posX, posY + nombreDeDisques + 1, "Tour n°" + numeroDeLaTour);
        }

        private static bool IsDisquesPresentsDansLaTour(int[] tour)
        {
            int somme = 0;

            foreach (int i in tour)
            {
                somme += i;
            }
            return (somme != 0);
        }

        private static bool IsPartieGagnee(int[] tour1, int[] tour2, int[] tour3)
        {
            if (IsDisquesPresentsDansLaTour(tour1))
            {
                return false;
            }
            else
            {
                return ((IsDisquesPresentsDansLaTour(tour2) && !IsDisquesPresentsDansLaTour(tour3)) || (!IsDisquesPresentsDansLaTour(tour2) && IsDisquesPresentsDansLaTour(tour3)));
            }
        }

        private static int GetDisqueAuSommet(int[] tour)
        {
            for (int i = 0; i < tour.Length; i++)
            {
                if (tour[i] != 0)
                {
                    return tour[i];
                }
            }
            return 0;
        }

        private static void AjouterDisqueAuSommet(int[] tour, int disque)
        {
            for (int i = tour.Length - 1; i > 0; i--)
            {
                if (tour[i] == 0)
                {
                    tour[i] = disque;
                    return;
                }
            }
        }

        private static void EnleverDisqueAuSommet(int[] tour)
        {
            for (int i = 0; i < tour.Length; i++)
            {
                if (tour[i] != 0)
                {
                    tour[i] = 0;
                    return;
                }
            }
        }

        private static void DeplacementDuDisque(int[] tourOrigine, int[] tourDestination)
        {
            int disqueAuSommetOrigine = GetDisqueAuSommet(tourOrigine);
            AjouterDisqueAuSommet(tourDestination, disqueAuSommetOrigine);
            EnleverDisqueAuSommet(tourOrigine);
        }

        private static bool IsDeplacementAutorise(int[] tourOrigine, int[] tourDestination)
        {
            if (GetDisqueAuSommet(tourOrigine) == 0)
            {
                return false;
            }
            else
            {
                if (GetDisqueAuSommet(tourDestination) == 0)
                {
                    return true;
                }
                else
                {
                    return GetDisqueAuSommet(tourDestination) > GetDisqueAuSommet(tourOrigine);
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
        public static void Hanoi()
        {
            Console.Clear();
            int nombreDeDisques;
            // Le premier élément du tableau correspond à son sommet de la tour ; le dernier élément du tableau correspond à la base de la tour
            int[] tour1, tour2, tour3;
            bool quitterLeJeu = false;
            bool gagne = false;

            AfficherTexte(0, 0, "TOURS DE HANOI");
            AfficherTexte(0, 1, "==============");

            nombreDeDisques = GetNombreDeDisques();

            // Construction des tours
            tour1 = new int[nombreDeDisques];
            tour2 = new int[nombreDeDisques];
            tour3 = new int[nombreDeDisques];
            for (int i = 1; i <= nombreDeDisques; i++)
            {
                tour1[i - 1] = i;
                tour2[i - 1] = 0;
                tour3[i - 1] = 0;
            }

            while (quitterLeJeu == false && gagne == false)
            {
                string saisie;

                // Afichage des tours
                Console.Clear();
                AfficherLaTour(0, 0, 1, tour1);
                AfficherLaTour(30, 0, 2, tour2);
                AfficherLaTour(60, 0, 3, tour3);
                AfficherTexte(0, nombreDeDisques + 3, "Indiquez un déplacement (ex : '1 2') pour jouer où juste la touche ENTREE pour quitter : ");
                saisie = Console.ReadLine();
                if (saisie == string.Empty)
                {
                    quitterLeJeu = true;
                }
                else
                {
                    string[] deplacement = saisie.Split(" ");

                    if (deplacement.Length == 2)
                    {
                        int origine;
                        int destination;

                        if (int.TryParse(deplacement[0], out origine) && int.TryParse(deplacement[1], out destination))
                        {
                            if (origine >= 1 && origine <= 3 && destination >= 1 && destination <= 3 && origine != destination)
                            {
                                bool deplacementAutorise = false;
                                int[] tourOrigine = new int[0];
                                int[] tourDestination = new int[0];

                                switch (true)
                                {
                                    case true when (origine == 1 && destination == 2):
                                        deplacementAutorise = IsDeplacementAutorise(tour1, tour2);
                                        tourOrigine = tour1;
                                        tourDestination = tour2;
                                        break;
                                    case true when (origine == 1 && destination == 3):
                                        deplacementAutorise = IsDeplacementAutorise(tour1, tour3);
                                        tourOrigine = tour1;
                                        tourDestination = tour3;
                                        break;
                                    case true when (origine == 2 && destination == 1):
                                        deplacementAutorise = IsDeplacementAutorise(tour2, tour1);
                                        tourOrigine = tour2;
                                        tourDestination = tour1;
                                        break;
                                    case true when (origine == 2 && destination == 3):
                                        deplacementAutorise = IsDeplacementAutorise(tour2, tour3);
                                        tourOrigine = tour2;
                                        tourDestination = tour3;
                                        break;
                                    case true when (origine == 3 && destination == 1):
                                        deplacementAutorise = IsDeplacementAutorise(tour3, tour1);
                                        tourOrigine = tour3;
                                        tourDestination = tour1;
                                        break;
                                    case true when (origine == 3 && destination == 2):
                                        deplacementAutorise = IsDeplacementAutorise(tour3, tour2);
                                        tourOrigine = tour3;
                                        tourDestination = tour2;
                                        break;
                                }

                                if (deplacementAutorise)
                                {
                                    DeplacementDuDisque(tourOrigine, tourDestination);
                                    gagne = IsPartieGagnee(tour1, tour2, tour3);
                                }
                                else
                                {
                                    AfficherTexte(0, nombreDeDisques + 5, "Déplacement non autorisé. Touche ENTREE pour continuer");
                                    Console.ReadLine();
                                }
                            }
                            else
                            {
                                AfficherTexteCommandeNonReconnueOuInterdite(0, nombreDeDisques + 5);
                            }
                        }
                        else
                        {
                            AfficherTexteCommandeNonReconnueOuInterdite(0, nombreDeDisques + 5);
                        }

                    }
                    else
                    {
                        AfficherTexteCommandeNonReconnueOuInterdite(0, nombreDeDisques + 5);
                    }
                }
            }
            if (gagne)
            {
                AfficherTexte(0, nombreDeDisques + 7, "BRAVO, C'EST GAGNE !");
            }
            else
            {
                AfficherTexte(0, nombreDeDisques + 7, "ESPECE DE LACHE !");

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
                Hanoi();
        }
        public static void item4()
        {
                Console.Clear();
                Environment.Exit(0);

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
