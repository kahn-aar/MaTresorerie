using MaTresorerie.Money;
using System;

namespace MaTresorerie.Objet
{
    public class Objet
    {
        private Money.Money prix;
        private String nom;

        public Objet(Money.Money prix, String nom)
        {
            this.prix = prix;
            this.nom = nom;
        }

        public override String ToString()
        {
            return "l'objet " + nom + " vaut " + prix.ToString();
        }
    }
}
