using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaTresorerie.Argent
{
    public class Money
    {
        public long argent { get ; set;}
        private String devise { get; set; }
        private String deviseRaccourcis { get; set; }
        
        public Money(long prix, String devise, String raccourcis)
        {
            this.argent = prix;
            this.devise = devise;
            this.deviseRaccourcis = raccourcis;
        }

        public static Money operator+(Money money1, Money money)
        {
            if (money1.devise.Equals(money.devise))
            {
                long prix = money1.argent + money.argent;
                return new Money(prix, money1.devise, money1.deviseRaccourcis);
            }
            else
            {
                throw new MoneyException();
            }
        }

        public static Money operator-(Money money1, Money money)
        {
            if (money1.devise.Equals(money.devise))
            {
                long prix = money1.argent - money.argent;
                return new Money(prix, money1.devise, money1.deviseRaccourcis);
            }
            else
            {
                throw new MoneyException();
            }
        }

        public override String ToString()
        {
            return argent.ToString() + " " + deviseRaccourcis;
        }
    }

}
