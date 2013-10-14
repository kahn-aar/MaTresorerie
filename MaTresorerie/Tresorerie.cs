using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaTresorerie.Money;

namespace MaTresorerie
{
    class Tresorerie
    {
        public static void Main()
        {
            Compte compte = new Compte("Livret A", new Money.Money(1000, "euros", MoneyConstantes.EUROS), 1.25);
            Console.WriteLine(compte.ToString());

        }
    }
}
