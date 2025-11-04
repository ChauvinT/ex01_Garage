using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_Garage.Classes
{
    public class MoteurElectrique : Moteur
    {
        public MoteurElectrique(string cylindre, double prix)
            : base(cylindre, prix)
        {

        }
        public override string ToString()
        {
            return $"Moteur ELECTRIQUE {base.Cylindre} ({base.Prix}€)";
        }
    }
}
