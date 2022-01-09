# Gas_Stations
This program implements a network of gas stations in the format Windows Forms and works for three parties: owner, client and provider

At this stage, this project is developing and has many shortcomings.

What about interesting moments? 

I use elementary reflection here to switch between forms.

        static public Form Show()
        {
            try
            {
                Type FormType = listForm[listForm.Count-1].GetType();
                ConstructorInfo[] constructors = FormType.GetConstructors();
                /*In this case, I use the fact that I know that my forms have only one
                constructor and they all do not accept any parameters. For versatility,
                you can use the possibilities of reflection and search for the right constructor,
                for example, cyclically*/
                Form form = (Form)constructors[0].Invoke(new Object[0]); 
                return form;
            }
            catch
            {
                Cansel();
                MessageBox.Show("You didn't choose any form");
                return new ChooseWho();
            }
        }

Also here I use primitive LINQ for search of the necessary client account or gas station.

        static public GasStation FoundStation(string nameStation, string passwordStation)
        {
            var Stations = from stations in StationList
                           where stations.NameGasStation == nameStation
                           where stations.Password == passwordStation
                           select stations;
            GasStation station = Stations.ToArray().Length == 1 ? Stations.ToArray()[0] : null;
            return station;
        }
        static public AccountClient FoundAccount(string AccountName, string AccountPassword)
        {
            var Accounts = from accounts in AccountList
                           where accounts.NameClient == AccountName
                           where accounts.Password == AccountPassword
                           select accounts;
            validAccount = Accounts.ToArray().Length == 1 ? Accounts.ToArray()[0] : null;
            return validAccount;
        }

I use the asynchronous WriteLineAsinc and ReadLineAsing methods to write and read
            using (StreamWriter writer = new StreamWriter("GasStationList.txt", true))
            {
                await writer.WriteLineAsync(
                    $"{NameGasStation}\t\t" +
                    $"{FuelInGasStation}\t\t" +
                    $"{MaxFuel}\t\t" +
                    $"{PriceFuel public static async void ReadFromListStationAsync()
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
