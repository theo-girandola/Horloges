using System;
using System.Collections.Generic;
using System.Text;

namespace Tour_de_Hanoi
{
    class Program
    {
        static int nbDisque = 0;
        public static void NombreDeDisque()
        {
            Console.Write("Saisir un nombre de disque : ");
            nbDisque = Convert.ToInt32(Console.ReadLine());
            if (nbDisque <= 10 && nbDisque >= 3)
            {
                Tour1();
                
                Tour2();
                
                Tour3();
            }
            else
            {
                Console.WriteLine("Saisissez un nombre entre 3 et 10");
            }
        }
        static void Tour1()
        {
            int nbEgale = 0;
            int nbEscpace = nbDisque;
            int nbTirets = nbDisque * 2 + 1;
            for (int i=0; i < nbDisque; i++)
            {
                
                for (int cpt = 0; cpt < nbEscpace; cpt++)
                {
                    Console.Write(" ");
                    
                }              
                
                Console.Write("/");

                for (int cpt = 0; cpt < nbEgale; cpt++)
                {
                    Console.Write("=");
                }

                Console.Write("|");

                for (int cpt = 0; cpt < nbEgale; cpt++)
                {
                    Console.Write("=");
                }
                nbEgale++;
                nbEscpace--;

                Console.Write("\\\n");
                
                    

            }
            Console.Write(" ");
            for(int j = 0; j < nbTirets; j++)
            {
                Console.Write("-");
            }
            Console.Write("\n Tour1");
        }
        public static void Tour2()
        {
            Tourvide();
            Console.Write("\n Tour2");
        }
        public static void Tour3()
        {
            Tourvide();
            Console.Write("\n Tour3");
        }
        static void Tourvide()
        {
            int nbTirets = nbDisque * 2 + 1;
            int nbEscpace = nbDisque;
            Console.Write("\n");
            for (int i = 0; i < nbDisque; i++)
            {
                Console.Write("\n");
                for (int cpt = 0; cpt < nbEscpace; cpt++)
                {
                    Console.Write(" ");

                }
                Console.Write("|");
                for (int cpt = 0; cpt < nbEscpace; cpt++)
                {
                    Console.Write(" ");

                }
                
                
            }
            Console.Write("\n");
            for (int j = 0; j < nbTirets; j++)
            {
                Console.Write("-");
            }
        }




        static void Main(string[] args)
        {
            NombreDeDisque();
            Console.WriteLine("\n\nIndiquez un déplacement (ex : '1 2') pour jouer où juste la touche ENTREE pour quitter :");
            int TDepart =Convert.ToInt32(Console.ReadLine());
            int TArriver = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(TDepart);
            Console.WriteLine(TArriver);
        }
    }
}
