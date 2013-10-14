using System;
using System.Collections.Generic;
using System.Text;
using MaTresorerie.Argent;
using MaTresorerie.Objet;

namespace MaTresorerie.Achats
{
    class Achat
    {
        public List<MaTresorerie.Objet.Objet> achats;

        public Achat()
        {
            achats = new List<Objet.Objet>();
        }

        public Argent.Money prixTotal()
        {
            Argent.Money prix = new Money(0, "euros", MoneyConstantes.EUROS);
            foreach (MaTresorerie.Objet.Objet objet in achats)
            {
                prix = prix + objet.getPrix();
            }
            return prix;
        }

        public override String ToString() 
        {
            StringBuilder builder = new StringBuilder();
            foreach (MaTresorerie.Objet.Objet objet in achats)
            {
                builder.Append(objet.ToString() + "\n");
            }
            return builder.ToString() + " prix total " + prixTotal().ToString();
        }
    }
}
