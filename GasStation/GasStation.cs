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
        private DateTime datetime;
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
            datetime = DateTime.Now;
            DeliveryPrice = PriceFuel / MarkUp;
        }
        public void InformationForOwner()
        {
            MessageBox.Show(
                    $"Your station: {NameGasStation}\n" +
                    $"Password = {Password} \n" +
                    $"Fuel = {FuelInGasStation}\n" +
                    $"Max fuel = {MaxFuel} l.\n" +
                    $"Prise = {PriceFuel}$\n" +
                    $"Date created = {datetime}"
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
        static public double SellingFuel(double orderedFuel,int index)
        {
            GasStation station = StationList[index];
            if (orderedFuel <= station.FuelInGasStation)
            {
                station.FuelInGasStation -= orderedFuel;
                BaseForm.listBox1.Items[index]= 
                $"{station.NameGasStation}\t\t\t\t" +
                $"{station.FuelInGasStation}\t\t\t\t" +
                $"{station.PriceFuel}";
                BaseForm.listBox2.Items[index] =
                $"{station.NameGasStation}\t\t\t\t" +
                $"{station.MaxFuel - station.FuelInGasStation}\t\t\t\t" +
                $"{station.MarkUp}";
                MessageBox.Show($"{orderedFuel * station.PriceFuel}");

                return orderedFuel * station.PriceFuel;
            }
            else
            {
                MessageBox.Show("Choose other station");
                return 0;
            }
        }
        public static void BuyFuel(double deliveryFuel, int index)
        {
            GasStation station = StationList[index];
            if (deliveryFuel + station.FuelInGasStation <= station.MaxFuel)
            {
                station.FuelInGasStation += deliveryFuel;
                BaseForm.listBox2.Items[index] =
                $"{station.NameGasStation}\t\t\t\t" +
                $"{station.MaxFuel - station.FuelInGasStation}\t\t\t\t" +
                $"{station.MarkUp}";
                BaseForm.listBox1.Items[index] =
                $"{station.NameGasStation}\t\t\t\t" +
                $"{station.FuelInGasStation}\t\t\t\t" +
                $"{station.PriceFuel}";
                MessageBox.Show($"Get {(deliveryFuel * station.PriceFuel / station.MarkUp).ToString("#.##")}");
            }
            else
            {
               MessageBox.Show("Choose other station");
            }
        }
    }
}
