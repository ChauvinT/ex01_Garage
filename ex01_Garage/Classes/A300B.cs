using ex01_Garage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_Garage.Classes
{
    public class A300B : Vehicule
    {
        public A300B(double prix, string nom, List<IOption> ioptions, Marque nomMarque)
        : base(prix, nom, ioptions, nomMarque)
        {

        }
    }
}
