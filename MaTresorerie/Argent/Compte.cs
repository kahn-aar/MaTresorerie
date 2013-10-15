using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaTresorerie.Argent
{
    class Compte
    {
        public String titre { get; set; }
        public Money solde { get; set; }
        

        public Compte(String titre, Money soldeInitial)
        {
            this.titre = titre;
            this.solde = soldeInitial;
        }

        public bool isDebiteur()
        {
            return solde.argent < 0;
        }

        public void acheter(Achats.Achat achats)
        {
            solde = solde - achats.prixTotal();
        }

        public override String ToString()
        {
            return "Le compte " + titre + " à un solde de " + solde.ToString();
        }
    }
}
