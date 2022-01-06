using System;
using System.Collections.Generic;
using System.IO;
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
        private double DeliveryPrice;
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
            DeliveryPrice = PriceFuel / MarkUp;
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
            BaseForm.listBox1.Items.Add(
                $"{this.NameGasStation}\t\t\t\t" +
                $"{this.FuelInGasStation}\t\t\t\t" +
                $"{this.PriceFuel}");
            BaseForm.listBox2.Items.Add(
                $"{this.NameGasStation}\t\t\t\t" +
                $"{this.MaxFuel-FuelInGasStation}\t\t\t\t" +
                $"{this.MarkUp}");

        }
        static public GasStation FoundStation(string nameStation, string passwordStation)
        {
            var Stations = from stations in StationList
                           where stations.NameGasStation == nameStation
                           where stations.Password == passwordStation
                           select stations;
            GasStation station = Stations.ToArray().Length == 1 ? Stations.ToArray()[0] : null;
            return station;
        }
        static public GasStation FoundStation(int index)
        {
            return StationList[index];
        }
        public double SellingFuel(double orderedFuel)
        {
            if (orderedFuel <= FuelInGasStation)
            {
                FuelInGasStation -= orderedFuel;
                MessageBox.Show($"{orderedFuel * PriceFuel}");
                return orderedFuel * PriceFuel;
            }
            else
            {
                MessageBox.Show("Choose other station");
                return 0;
            }
        }



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
    }
}
