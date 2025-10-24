using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_Garage.Interfaces
{
    public class GPS : IOption
    {
        double Prix;
        public GPS(double prix)
        {
            Prix = prix;
        }

        public double getPrix()
        {
            return Prix;
        }
    }
}
