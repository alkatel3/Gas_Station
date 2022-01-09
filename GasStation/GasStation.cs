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
        private static bool DoReading=true;
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
            if (DoReading)
            {
                ReadFromListStationAsync();
                DoReading = false;
                foreach(var station in StationList)
                {
                    station.InformationForOwner();
                }
            }
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
            //using (StreamReader reader = new StreamReader("GasStationList.txt"))
            //{
            //    string result = await reader.ReadToEndAsync();  // асинхронное чтение из файла
            //    MessageBox.Show(result);
            //}
            BaseForm.listBox1.Items.Add(
                $"{this.NameGasStation}\t\t\t\t" +
                $"{this.FuelInGasStation}\t\t\t\t" +
                $"{this.PriceFuel:#,##}");
            BaseForm.listBox2.Items.Add(
                $"{this.NameGasStation}\t\t\t\t" +
                $"{this.MaxFuel-FuelInGasStation}\t\t\t\t" +
                $"{this.PriceFuel/MarkUp:#.##}");

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
                station.FullingListBoxs(index);
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
                station.FullingListBoxs(index);
                MessageBox.Show($"Get {(deliveryFuel * station.PriceFuel / station.MarkUp):#.##}");
            }
            else
            {
               MessageBox.Show("Choose other station");
            }
        }
        private void FullingListBoxs( int index)
        {
            BaseForm.listBox1.Items[index] =
                $"{NameGasStation}\t\t\t\t" +
                $"{FuelInGasStation}\t\t\t\t" +
                $"{PriceFuel:#.##}";
            BaseForm.listBox2.Items[index] =
            $"{NameGasStation}\t\t\t\t" +
            $"{MaxFuel - FuelInGasStation}\t\t\t\t" +
            $"{PriceFuel/MarkUp:#.##}";
        }
        private async void ReadFromListStationAsync()
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
                }
            }
        }
    }
}
