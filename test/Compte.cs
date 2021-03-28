using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Compte
    {
        private readonly int numero;
        private static int no_cmpt = 0;
        private readonly Client prop;
        protected MAD solde;
        private static MAD plafond = new MAD(5000);

        public Compte(MAD solde, Client prop)
        {
            no_cmpt++;
            numero = no_cmpt;
            this.solde = solde;
            this.prop = prop;

        }


        public void Crediter(MAD somme)
        {
            if (somme >= new MAD(0))
            {
                this.solde = this.solde + somme;
                Console.Out.WriteLine("Done");
            }
        }

        public virtual void Debiter(MAD somme)
        {
            if (this.solde >= somme && plafond >= somme)
            {
                this.solde = this.solde - somme;
                Console.Out.WriteLine("Done");
            }
            else
            {
                Console.Out.WriteLine("Not Done");
            }
        }

        public void Verser(Compte c, MAD somme)
        {
            if (this.solde >= somme && plafond >= somme)
            {
                this.solde -= somme;
                c.solde += somme;
                Console.Out.WriteLine("Done");
            }
            else
            {
                Console.Out.WriteLine("Not Done");
            }
        }

        public virtual void Afficher()
        {
            Console.Out.WriteLine("Le numéro du compte est " + numero);
            Console.Out.WriteLine("Le solde du compte est ");
            solde.Afficher();
            Console.Out.WriteLine("Le propriétaire du compte est ");
            prop.Afficher();
        }
    }
}
