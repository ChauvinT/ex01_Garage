using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_Garage.Classes
{
    public class MoteurEssence : Moteur
    {
        public MoteurEssence( string cylindre, double prix)
            :base (cylindre, prix)
        {

        }
        public override string ToString()
        {
            return $"Moteur ESSENCE {base.Cylindre} ({base.Prix}€)";
        }
    }
}
