using System;

namespace TableauBulle
{
    class Program
    {
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
        static void Main(string[] args)
        {
            Random generateurDeNombreAleatoires = new Random();
            
            int[] tableauNonTrier = new int[generateurDeNombreAleatoires.Next(5, 50)];
            for (int compteur = 0; compteur < tableauNonTrier.Length; compteur++)
            {
                tableauNonTrier[compteur] = generateurDeNombreAleatoires.Next(0, tableauNonTrier.Length*10);
            }





            Console.Write("Tableau Non Trié: ");
            AffichageDuTableau(tableauNonTrier);




            int[] tableauTrier = tableauNonTrier;
            for (int compteur = 0; compteur < tableauNonTrier.Length-1; compteur++)
            {
                if (tableauTrier[compteur] > tableauTrier[compteur + 1])
                {
                    int temp = tableauTrier[compteur];
                    tableauTrier[compteur] = tableauTrier[compteur + 1];
                    tableauTrier[compteur + 1] = temp;
                    compteur = -1;
                }
            }





            Console.Write("Tableau Trié: ");
            AffichageDuTableau(tableauTrier);
        }
    }
}
