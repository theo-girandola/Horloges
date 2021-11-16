using System;

namespace TourDeHanoi
{
    internal class Program
    {
        private const int LARGEUR_CONSOLE = 80;
        private const int NOMBRE_MINI_DISQUES = 3;
        private const int NOMBRE_MAXI_DISQUES = 10;
        static void Main(string[] args)
        {
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
    }
}