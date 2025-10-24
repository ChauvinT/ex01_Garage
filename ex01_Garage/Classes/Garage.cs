using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_Garage.Classes
{
    public class Garage
    {
        public List<Vehicule> Vehicules { get; } = new List<Vehicule>();
        public Garage() {}

        public void AddVoiture(Vehicule vehicule)
        {
            if (vehicule == null) throw new ArgumentNullException();
            if (Vehicules.Contains(vehicule)) return;
            Vehicules.Add(vehicule);
        }

        public override string ToString()
        {
            string response = "";

            foreach (Vehicule vehicule in Vehicules)
            {
                response = $"+ Voiture {vehicule.GetMarque()} : {vehicule.Nom} Moteur : ";
            }
            return response;
        }
    }
}
