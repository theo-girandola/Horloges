using System;
using System.Collections.Generic;
using System.Text;




namespace Hanoi
    {
        class Program
        {
            static List<string>[] Tige;
            static string sTige;
            static int nbRond;
            static int nbTige = 3;
            



            static void InitTige()
            {
                int i;
                Tige = new List<string>[nbTige];

                for (i = 0; i < nbTige; i++) Tige[i] = new List<string>();

                string s = "";

                for (int nbetoile = nbRond; nbetoile >= 1; nbetoile--)
                {
                    s = "|";
                    for (i = 0; i < nbetoile; i++) s = "=" + s + "=";
                    for (i = nbetoile; i < nbRond; i++) s = " " + s + " ";
                    Tige[0].Add(s);
                }
                sTige = "|";
                for (i = 0; i < nbRond; i++) sTige = " " + sTige + " ";

            }



            static void WriteTige()
            {
                string s;
                for (int i = nbRond - 1; i >= 0; i--)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (i < Tige[j].Count) s = Tige[j][i];
                        else s = sTige;
                        Console.Write(s);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            static void deplace(int deb, int fin)
            {
                
                string s = Tige[deb][Tige[deb].Count - 1]; // recupere l'element du haut
                Tige[deb].Remove(s);                     // le supprime
                Tige[fin].Add(s);                        // l'ajoute à la destination
            }


            static void Hanoi(int n, int deb, int fin, int aux)
            {

                if (n == 0) return;

                Hanoi(n - 1, deb, aux, fin);     // Faire Hanoi de n-1 de deb vers aux

                deplace(deb, fin);            // Deplacer celui qui reste de deb vers fin
                WriteTige();

                Hanoi(n - 1, aux, fin, deb);
            }// ReFaire Hanoi de n-1 de aux vers fin




            static void Main(string[] args)
            {
                Console.Write("Entrez le nombre d'anneaux voulu pour le jeu : ");
                nbRond = int.Parse(Console.ReadLine());     // nbre d'anneaux sur la premiere tige
                Console.WriteLine(" ");
                InitTige();
                WriteTige();
                Hanoi(nbRond, 0, 1, 2);
                
                Console.Read();
            }

        }
    }

