using System;

namespace PairImpaire
{
    class Program
    {
        static void pairImpair(int[] tableauNb, out int[] tableauPair, out int[] tableauImpair)
        {
            tableauPair = new int[8];
            tableauImpair = new int[8];
            
            int i = 0;
            int y = 0;

            for (int n = 0; n < 8; n++)
            {
                if ((tableauNb[n] % 2) == 0)
                {
                    tableauPair[i] = tableauNb[n];
                    i++;
                }
                else
                {
                    tableauImpair[y] = tableauNb[n];
                    y++;
                }
            }
        }

        static void affichage(int[] tableauPair, int[] tableauImpair, out string resultatPair, out string resultatImpair)
        {
            resultatPair = "";
            resultatImpair = "";
            for (int n = 0; n < tableauPair.Length; n++)
            {
                resultatPair = resultatPair + "," + tableauPair[n];
                resultatImpair = resultatImpair +","+ tableauImpair[n];
            }
            Console.WriteLine("Les chiffres pair sont :");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(resultatPair.Substring(1,resultatPair.Length -1));
            Console.WriteLine("Les chiffres impair sont :");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(resultatImpair.Substring(1,resultatImpair.Length -1));
        }
        static void Main(string[] args)
        {
            
            int[] tableauNb = new int[8] { 8, 5, 3, 2, 7, 12, 15, 23 };
            int[] tableauPair;
            int[] tableauImpair;
            string resultatPair;
            string resultatImpair;
            pairImpair(tableauNb, out tableauPair, out tableauImpair);
            affichage(tableauPair, tableauImpair, out resultatPair, out resultatImpair);
            Console.ReadLine();

        }
    }
}
