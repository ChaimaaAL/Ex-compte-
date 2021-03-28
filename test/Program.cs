using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compte C1 = new Compte(new MAD(2000000), new Client("sam", "test", "dacc"));
            //Compte C2 = new Compte(new MAD(5000000), new Client("dacc", "testiii", "samm"));
            CompteEpargne C5 = new CompteEpargne(new MAD(50), new Client("idk", "tei", "sm"),4000);
            Console.WriteLine("Détails du compte après Interet: ");


            //Console.WriteLine("**********");

            MAD mtt = new MAD(400);
            C5.Debiter(mtt);
            C5.Afficher();
           

            //MAD somme = new MAD(400);
            //C2.Crediter(somme);
            //C2.Debiter(somme);
            //C2.Verser(C1, somme);
            //C1.Afficher();
            //Console.WriteLine("**********");
            //C2.Afficher();
            Console.ReadKey();
        }
    }
}
