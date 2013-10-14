using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaTresorerie.Money
{
    struct Money
    {
        private int argent {get ; set;}
        private String devise { get; set; }
        private String deviseRaccourcis { get; set; }

        String toString()
        {
            return argent.ToString() + " " + deviseRaccourcis;
        }
    }

}
