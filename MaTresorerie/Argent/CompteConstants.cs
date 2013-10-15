using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaTresorerie.Argent
{
    class CompteConstants
    {
        public const CompteEpargne LIVRET_A = new CompteEpargne("Livret A", new Money(0, MoneyConstantes.EUROS), 1.25);
    }
}
