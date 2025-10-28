using ex01_Garage.Interfaces;
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
            string options = "";
            double prixTotal = 0;

            List<IOption> lesOptions;
            foreach (Vehicule vehicule in Vehicules)
            {
                prixTotal = 0;
                lesOptions = vehicule.getOption();
                foreach (IOption option in lesOptions)
                {
                    if (options != ""){
                        options += ", ";
                    } 
                    options += $"{option.ToString()} ({option.getPrix()}€)";
                    prixTotal += option.getPrix();
                }
                prixTotal += vehicule.Prix;
                options = $"[{options}]";

                response = $"+ Voiture {vehicule.GetMarque()} : {vehicule.Nom} Moteur :  ({vehicule.Prix}€) {options} d'une valeur totale de {prixTotal} €";
            }
            return response;
        }
    }
}
