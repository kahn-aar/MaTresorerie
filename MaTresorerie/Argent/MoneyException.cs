using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaTresorerie.Argent
{
    public class MoneyException : Exception
    {
        public MoneyException() : base("Erreur, ce n'est pas la même devise") { }
    }
}
