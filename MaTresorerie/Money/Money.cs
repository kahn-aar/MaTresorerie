using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaTresorerie.Money
{
    public class Money
    {
        public long argent { get ; set;}
        private String devise { get; set; }
        private String deviseRaccourcis { get; set; }

        public Money(int prix, String devise, String raccourcis)
        {
            this.argent = prix;
            this.devise = devise;
            this.deviseRaccourcis = raccourcis;
        }

        public override String ToString()
        {
            return argent.ToString() + " " + deviseRaccourcis;
        }
    }

}
