using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_Garage.Interfaces
{
    public class BarreDeToit : IOption
    {
        double Prix;
        public BarreDeToit(double prix)
        {
            Prix = prix;
        }

        public double getPrix()
        {
            return Prix;
        }

        public override string ToString()
        {
            return "Barre de toit";
        }
    }
}
