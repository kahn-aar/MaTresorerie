using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaTresorerie.Money
{
    class Compte
    {
        private String titre;
        private Money solde;
        private double taux;

        public Compte(String titre, Money soldeInitial, double taux)
        {
            this.titre = titre;
            this.solde = soldeInitial;
            this.taux = taux;
        }

        public bool isDebiteur()
        {
            return solde.argent < 0;
        }

        public override String ToString()
        {
            return "Le compte " + titre + " à un solde de " + solde.ToString() + " avec un taux de " + taux.ToString();
        }
    }
}
