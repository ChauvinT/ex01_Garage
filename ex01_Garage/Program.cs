using ex01_Garage.Classes;
using ex01_Garage.Interfaces;

namespace ex01_Garage
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Garage garage = new Garage();

            Console.WriteLine(garage);


            Vehicule lag1 = new Lagouna(23123.0, "Lagouna", new List<IOption> { }, Marque.RENO);
            
            lag1.SetMoteur(new MoteurEssence("150 Chevaux", 10256d));

            lag1.AddOption(new GPS(113.5));

            lag1.AddOption(new SiegeChauffant(562.9));

            lag1.AddOption(new VitreElectrique(212.35));

            garage.AddVoiture(lag1);


            Vehicule A300B_2 = new A300B(28457.8, "A330B", new List<IOption> { }, Marque.PIGEOT);

            A300B_2.SetMoteur(new MoteurElectrique("1500 W", 1234d));

            A300B_2.AddOption(new Climatisation(347.3));

            A300B_2.AddOption(new BarreDeToit(29.9));

            A300B_2.AddOption(new SiegeChauffant(562.9));

            garage.AddVoiture(A300B_2);


            Vehicule d4_1 = new D4(25147.0, "04", new List<IOption> { }, Marque.TROEN);

            d4_1.SetMoteur(new MoteurDiesel("200 Hdi", 25684.80d));

            d4_1.AddOption(new BarreDeToit(29.9));

            d4_1.AddOption(new Climatisation(347.3));

            d4_1.AddOption(new GPS(113.5));

            garage.AddVoiture(d4_1);


            Vehicule lag2 = new Lagouna(23123.0, "Lagouna", new List<IOption> { }, Marque.RENO);

            lag2.SetMoteur(new MoteurDiesel("500 Hdi", 456987d));

            garage.AddVoiture(lag2);


            Vehicule A300B_1 = new A300B(28457.8, "A330B", new List<IOption> { }, Marque.PIGEOT);

            A300B_1.SetMoteur(new MoteurHybride("ESSENCE/Electrique", 12345.95d));

            A300B_1.AddOption(new VitreElectrique(212.35));

            A300B_1.AddOption(new BarreDeToit(29.9));

            garage.AddVoiture(A300B_1);


            Vehicule d4_2 = new D4(25147.0, "04", new List<IOption> { }, Marque.TROEN);

            d4_2.SetMoteur(new MoteurElectrique("100 KW", 1224d));

            d4_2.AddOption(new SiegeChauffant(562.9));

            d4_2.AddOption(new BarreDeToit(29.9));

            d4_2.AddOption(new Climatisation(347.34));

            d4_2.AddOption(new GPS(113.5));

            d4_2.AddOption(new VitreElectrique(212.35));

            garage.AddVoiture(d4_2);

            Console.WriteLine(garage);

        }

    }
}
