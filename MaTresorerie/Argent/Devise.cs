using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaTresorerie.Argent
{
    public class Devise
    {
        public String nom { get; set; }
        public String nomCourt { get; set; }

        public Devise(String nom, String nomCourt)
        {
            this.nom = nom;
            this.nomCourt = nomCourt;
        }
    }
}
