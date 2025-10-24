using ex01_Garage.Interfaces;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ex01_Garage.Classes.Moteur;

namespace ex01_Garage.Classes
{
    public class Vehicule : IOption
    {
        /*public enum Marque
        {
            RENO,
            PIGEOT,
            TROEN
        }*/

        public double Prix { get; set; }
        public string Nom { get; set; }
        public List<IOption> IOptions { get; } = new List<IOption>();
        protected Marque NomMarque;

        public Vehicule(double prix, string nom, List<IOption> ioptions , Marque nomMarque)
        {
            Prix = prix;
            Nom = nom;
            IOptions = ioptions;
            NomMarque = nomMarque;
        }

        public override string ToString()
        {
            return $"Nom : {Nom} / Prix : {Prix}";
        }

        public void AddOption(IOption opt)
        {
            if (opt == null) throw new ArgumentNullException();
            if (IOptions.Contains(opt)) return;
            IOptions.Add(opt);
        }
        public Marque GetMarque()
        {
            return NomMarque ;
        }
        public List<IOption> getOption()
        {
            return IOptions ;
        }
        public double getPrix() {
            return Prix ;
        }
        public void SetMoteur(Moteur moteur)
        {

        }
    }
}
