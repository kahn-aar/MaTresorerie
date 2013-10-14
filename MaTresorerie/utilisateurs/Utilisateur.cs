using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaTresorerie.utilisateurs
{
    class Utilisateur
    {
        public String nom;
        public String motDePasse;

        public List<Argent.Compte> listeDeComptes;

        public Utilisateur(String nom, String motDePasse)
        {
            this.nom = nom;
            this.motDePasse = motDePasse;
            listeDeComptes = new List<Argent.Compte>();
        }

        public void ajouterUnCompte(String titre, double taux)
        {
            Argent.Compte newCompte = new Argent.Compte(titre, new Argent.Money(0, "euros", Argent.MoneyConstantes.EUROS), taux);
            listeDeComptes.Add(newCompte);
        }
    }
}
