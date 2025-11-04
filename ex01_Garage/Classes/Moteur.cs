using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ex01_Garage.Classes
{
    public class Moteur
    {
        public enum TypeMoteur
        {
            DIESEL,
            ESSENCE,
            HYBRIDE,
            ELECTRIQUE
        }

        public TypeMoteur Type;
        public string Cylindre { get; set; }
        public double Prix { get; set; }
        public Moteur( string cylindre, double prix) { 
            Cylindre = cylindre;
            Prix = prix;
        }
    }
}
