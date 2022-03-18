using System;

namespace PairImpaire
{
    class Program
    {
        
        static void Main(string[] args)
        {
            structureProgramme mesOutils = new structureProgramme();

            int[] tableauNb = new int[8] { 8, 5, 3, 2, 7, 12, 15, 23 };
            int[] tableauPair;
            int[] tableauImpair;
            string resultatPair;
            string resultatImpair;
            mesOutils.pairImpair(tableauNb, out tableauPair, out tableauImpair);
            mesOutils.affichage(tableauPair, tableauImpair, out resultatPair, out resultatImpair);
            Console.ReadLine();

        }
    }
}
