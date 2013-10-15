using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaTresorerie.Argent
{
    class CompteEpargne : Compte
    {
        public double taux { get; set; }

        public CompteEpargne(String titre, Money soldeInitial, double taux)
            : base(titre, soldeInitial)
        {
            this.taux = taux;
        }
    }
}
