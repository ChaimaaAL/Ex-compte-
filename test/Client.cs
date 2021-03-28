using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse;



        public Client(string nom, string prenom, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
        }

        public void Afficher()
        {
            Console.Out.WriteLine("Le nom du client est " + nom + " son prénom est " + prenom + " son adresse est " + adresse);
        }
    }
}
