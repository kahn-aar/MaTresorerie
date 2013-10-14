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
            Compte compte = new Compte("Livret A", new Argent.Money(1000, "euros", MoneyConstantes.EUROS), 1.25);
            Console.WriteLine(compte.ToString());
            Objet.Objet obj1 = new Objet.Objet(new Argent.Money(40, "euros", MoneyConstantes.EUROS), "lapin bleu");
            Objet.Objet obj2 = new Objet.Objet(new Argent.Money(20, "euros", MoneyConstantes.EUROS), "lapin rouge");
            Achat achat = new Achat();
            achat.achats.Add(obj1);
            achat.achats.Add(obj2);
            Console.WriteLine(achat.ToString());
            compte.acheter(achat);
            Console.WriteLine(compte.ToString());
        }
    }
}
