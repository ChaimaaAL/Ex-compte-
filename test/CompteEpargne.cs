using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class CompteEpargne : Compte
    {
        private double tauxI;
        

        //public CompteEpargne() : base() { }

        public CompteEpargne(MAD solde, Client prop, double taux) : base(solde, prop)
        {
            if (taux > 0 && taux < 100)
            {
                this.tauxI = taux;
            }
            else
            {
                Console.Out.WriteLine("erreur");

            }
        }

        public void CalculInteret()
        {
            this.solde += this.solde * (this.tauxI / 100);
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.Out.WriteLine("Le taux d'ineteret du compte est " + tauxI);
        }
    }
}
