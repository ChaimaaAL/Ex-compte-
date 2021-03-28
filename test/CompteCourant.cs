using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class CompteCourant : Compte 
    {
        private double découvert;

        public CompteCourant(MAD solde, Client prop, double dec) : base(solde, prop)
        {
            this.découvert = dec;
        }

        public override void Debiter(MAD mtt)
        {
            if (this.solde - mtt >= découvert)
            {
                this.solde -= mtt;
            }
            else {
                Console.Out.WriteLine("not done");
            }
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.Out.WriteLine("Le débit avec découvert " + solde);
        }

    }
}
