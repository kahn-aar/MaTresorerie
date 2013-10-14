using MaTresorerie.Argent;
using System;

namespace MaTresorerie.Objet
{
    public class Objet
    {
        private Argent.Money prix;
        private String nom;

        public Argent.Money getPrix()
        {
            return this.prix;
        }

        public Objet(Argent.Money prix, String nom)
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
