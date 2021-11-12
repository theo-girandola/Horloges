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
                tableauNonTrier[compteur] = generateurDeNombreAleatoires.Next(0, tableauNonTrier.Length * 10);
            }





            Console.Write("Tableau Non Trié: ");
            AffichageDuTableau(tableauNonTrier);





            for (int i = tableauNonTrier.Length-2; i >= 0; i--)
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
    }
}
