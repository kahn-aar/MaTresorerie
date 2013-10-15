using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaTresorerie.utilisateurs
{
    class Utilisateur
    {
        public String nom { get; set; }
        public String motDePasse { get; set; }

        public List<Argent.Compte> listeDeComptes { get; private set; }

        public Utilisateur(String nom, String motDePasse)
        {
            this.nom = nom;
            this.motDePasse = motDePasse;
            listeDeComptes = new List<Argent.Compte>();
        }

        public void ajouterUnCompteEpargne(String titre, double taux)
        {
            Argent.Compte newCompte = new Argent.CompteEpargne(titre, new Argent.Money(0,  Argent.MoneyConstantes.EUROS), taux);
            listeDeComptes.Add(newCompte);
        }
    }
}
