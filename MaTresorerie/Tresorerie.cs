using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaTresorerie.Argent;
using MaTresorerie.Objet;
using MaTresorerie.Achats;

namespace MaTresorerie
{
    class Tresorerie
    {
        public static void Main()
        {
            Compte compte = CompteConstants.LIVRET_A;
            Console.WriteLine(compte.ToString());
            Objet.Objet obj1 = new Objet.Objet(new Argent.Money(40, MoneyConstantes.EUROS), "lapin bleu");
            Objet.Objet obj2 = new Objet.Objet(new Argent.Money(20, MoneyConstantes.EUROS), "lapin rouge");
            Achat achat = new Achat();
            achat.achats.Add(obj1);
            achat.achats.Add(obj2);
            Console.WriteLine(achat.ToString());
            compte.acheter(achat);
            Console.WriteLine(compte.ToString());
        }
    }
}
