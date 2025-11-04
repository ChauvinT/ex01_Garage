using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_Garage.Interfaces
{
    public class Climatisation : IOption
    {
        double Prix;
        public Climatisation(double prix)
        {
            Prix = prix;
        }

        public double getPrix()
        {
            return Prix;
        }

        public override string ToString()
        {
            return "Climatisation";
        }
    }
}
