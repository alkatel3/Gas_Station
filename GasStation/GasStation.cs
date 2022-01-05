using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GasStation
{
    class GasStation
    {
        static List<GasStation> StationList = new();
        public string NameGasStation { get; private set; }
        private double FuelInGasStation;
        private double PriceFuel;
        private string Password;
        private double MaxFuel; //цим задається скільки максимум палива може містити заправка (об'єм бункера на паливо)
        private double MarkUp = 1.3; //ймовірна націнка власника заправки 30% тобто від закупівельну ціну множить на 1.3
        public GasStation(string nameGasStation, double fuelInGasStation,
            double maxFuel, double priceFuel, string personalPassword)

        {
            NameGasStation = nameGasStation;
            FuelInGasStation = fuelInGasStation;
            MaxFuel = maxFuel;
            PriceFuel = priceFuel;
            Password = personalPassword;
        }
         public void InformationForOwner()
        {
            MessageBox.Show(
                    $"Your station: {NameGasStation}\n" +
                    $"Password = {Password} \n" +
                    $"Fuel = {FuelInGasStation}\n" +
                    $"Max fuel = {MaxFuel} l.\n" +
                    $"Prise = {PriceFuel}$"
                    );
        }
        public void SaveStation()
        {
            StationList.Add(this);
        }
        static public GasStation FoundStation(string nameStation, string passwordStation)
        {
            var Stations = from stations in StationList
                           where stations.NameGasStation == nameStation
                           where stations.Password==passwordStation
                           select stations;
            GasStation station = Stations.ToArray().Length == 1 ? Stations.ToArray()[0] : null;
            return station;
        }
        //public string InformationForClient()
        //{
        //    return $"Name: {NameGasStation}\tFuel = {FuelInGasStation} l.\tPrise = {PriceFuel} $/l";
        //}
        //public double SellingFuel(double orderedFuel)
        //{
        //    if (orderedFuel <= FuelInGasStation)
        //    {
        //        FuelInGasStation -= orderedFuel;
        //        return orderedFuel * PriceFuel;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Choose other station");
        //        return 0;
        //    }
        //}
        //public string InformationForProvider()
        //{
        //    return $"Name: {NameGasStation}\t buy fuel for {PriceFuel / MarkUp} $ \t can buy {MaxFuel - FuelInGasStation} l ";
        //}
        //public double BuyFuel(double deliveryFuel)
        //{
        //    if (deliveryFuel + FuelInGasStation <= MaxFuel)
        //    {
        //        FuelInGasStation += deliveryFuel;
        //        Console.WriteLine($"Get {deliveryFuel * PriceFuel / MarkUp}");
        //        return 1;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Choose other station");
        //        return 0;
        //    }
        //}
        //static public GasStation ChooseGasStation(byte chooseWho, List<GasStation> GasStations)
        //{
        //    if (GasStations != null)
        //    {
        //        Console.WriteLine("Choose:\n(input number)\n");
        //        int i = 0; //задає номерацію списку
        //        foreach (var station in GasStations)
        //        {
        //            if (chooseWho == 2)
        //            {
        //                Console.WriteLine($"{++i}. {station.InformationForClient()}");
        //            }
        //            else if (chooseWho == 3)
        //            {
        //                Console.WriteLine($"{++i}. {station.InformationForProvider()}");
        //            }
        //        }
        //        Console.WriteLine("\n");
        //        int chooseNumberStation = Convert.ToInt32(Console.ReadLine());
        //        if (chooseNumberStation > 0 && chooseNumberStation <= i)
        //        {
        //            foreach (var station in GasStations)
        //            {
        //                if (GasStations.IndexOf(station) == chooseNumberStation - 1)
        //                {
        //                    return station;
        //                }
        //            }
        //        }
        //    }
        //    return null;
        //}
       
        
    }
}
