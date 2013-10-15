using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaTresorerie.Argent
{
    class Devise
    {
        public String nom;
        public String nomCourt;

        public Devise(String nom, String nomCourt)
        {
            this.nom = nom;
            this.nomCourt = nomCourt;
        }
    }
}
