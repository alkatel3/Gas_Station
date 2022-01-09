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
            double maxFuel, double priceFuel, string personalPassword,DateTime dateTime)
        {
            NameGasStation = nameGasStation;
            FuelInGasStation = fuelInGasStation;
            MaxFuel = maxFuel;
            PriceFuel = priceFuel;
            Password = personalPassword;
            datetime = dateTime;
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
        public async void SaveStation()
        {
            StationList.Add(this);
            using (StreamWriter writer = new StreamWriter("GasStationList.txt", true))
            {
                await writer.WriteLineAsync(
                    $"{NameGasStation}\t\t" +
                    $"{FuelInGasStation}\t\t" +
                    $"{MaxFuel}\t\t" +
                    $"{PriceFuel}\t\t" +
                    $"{Password}\t\t" +
                    $"{datetime}");  // асинхронная запись в файл
            }
            AddingItemsToListBoxs();
            //BaseForm.listBox1.Items.Add(
            //    $"{this.NameGasStation}\t\t\t\t" +
            //    $"{this.FuelInGasStation}\t\t\t\t" +
            //    $"{this.PriceFuel:#,##}");
            //BaseForm.listBox2.Items.Add(
            //    $"{this.NameGasStation}\t\t\t\t" +
            //    $"{this.MaxFuel-FuelInGasStation}\t\t\t\t" +
            //    $"{this.PriceFuel/MarkUp:#.##}");

        }
        static public GasStation FoundStation(string nameStation)
        {
            var Stations = from stations in StationList
                           where stations.NameGasStation == nameStation
                           select stations;
            GasStation station = Stations.ToArray().Length == 1 ? Stations.ToArray()[0] : null;
            return station;
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
                station.ChangingListBoxs(index);
                MessageBox.Show($"{orderedFuel * station.PriceFuel}$");

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
                station.ChangingListBoxs(index);
                MessageBox.Show($"Get {(deliveryFuel * station.PriceFuel / station.MarkUp):#.##}");
            }
            else
            {
               MessageBox.Show("Choose other station");
            }
        }
        private void ChangingListBoxs(int index)
        {
            BaseForm.listBox1.Items[index] =
                $"{NameGasStation}\t\t\t\t" +
                $"{FuelInGasStation}\t\t\t\t" +
                $"{PriceFuel:#.##}";
            BaseForm.listBox2.Items[index] =
            $"{NameGasStation}\t\t\t\t" +
            $"{MaxFuel - FuelInGasStation}\t\t\t\t" +
            $"{PriceFuel / MarkUp:#.##}";

        }
        private void AddingItemsToListBoxs()
        {
            BaseForm.listBox1.Items.Add (
                $"{NameGasStation}\t\t\t\t" +
                $"{FuelInGasStation}\t\t\t\t" +
                $"{PriceFuel:#.##}");
            BaseForm.listBox2.Items.Add(
            $"{NameGasStation}\t\t\t\t" +
            $"{MaxFuel - FuelInGasStation}\t\t\t\t" +
            $"{PriceFuel / MarkUp:#.##}");

        }
        public static async void ReadFromListStationAsync()
        {
            GasStation station;
            using (StreamReader reader = new StreamReader("GasStationList.txt"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string result = await reader.ReadLineAsync();  // асинхронное чтение из файла
                    string[] gasStationParams = result.Split("\t\t");
                    station = new(
                        gasStationParams[0],
                        Double.Parse(gasStationParams[1]),
                        Double.Parse(gasStationParams[2]),
                        Double.Parse(gasStationParams[3]),
                        gasStationParams[4],
                        DateTime.Parse(gasStationParams[5]));
                    StationList.Add(station);
                    station.AddingItemsToListBoxs();
                }
            }
        }
        static async public void SaveAllStationAtFile()
        {
            using (StreamWriter writer = new StreamWriter("GasStationList.txt",false))
            {
                foreach (var station in StationList)
                {
                    await writer.WriteLineAsync(
                        $"{station.NameGasStation}\t\t" +
                        $"{station.FuelInGasStation}\t\t" +
                        $"{station.MaxFuel}\t\t" +
                        $"{station.PriceFuel}\t\t" +
                        $"{station.Password}\t\t" +
                        $"{station.datetime}");  // асинхронная запись в файл
                }
            }
        }
    }
}
