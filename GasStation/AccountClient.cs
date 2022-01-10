using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GasStation
{
    class AccountClient
    {
        static AccountClient validAccount=null;
        static List<AccountClient> AccountList = new();
        public string NameClient { get; private set; }
        private string Password;
        private byte AccrualBonuses = 100;//нарахування здійснюється як 1% від суми купленого палива,тобто для розрахунку треба: sum/100
        private double Bonus = 0;// при створенні акаунту сума бонусів дорівнює 0
        public AccountClient(string nameClient, string password)
        {
            NameClient = nameClient;
            Password = password;
        }
        private AccountClient(string nameClient, string password, double bonus)
        {
            NameClient = nameClient;
            Password = password;
            Bonus = bonus;
        }
        public void GetInformation()
        {
            MessageBox.Show(
                $"You account:\n" +
                $"Name: {NameClient}\n" +
                $"Password: {Password}\n" +
                $"Bonus: {Bonus} $");
        }
        public async void SaveAccount()
        {
            AccountList.Add(this);
            using (StreamWriter writer = new StreamWriter("AccountClientList.txt",true))
            {
                await writer.WriteLineAsync(
                    $"{NameClient}\t\t" +
                    $"{Password}\t\t" +
                    $"{Bonus}\t\t");  // асинхронная запись в файл
            }
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
        static public AccountClient GetValidAccount()
        {
            AccountClient account = validAccount;
            validAccount = null;
            return account;
        }
        public void AddingBonus(double sum)
        {
            Bonus += sum / AccrualBonuses;
            MessageBox.Show($"You are added {sum / AccrualBonuses} bonus");
            GetInformation();
        }



        public void UsingBonus(double sum)
        {
            if (Bonus <= sum)
            {
                sum -= Bonus;
                Bonus = 0;// в даному випадку всі бонуси йдуть на погашення суми
                MessageBox.Show($"To pay {sum} $");
            }
            else
            {
                Bonus -= sum;
                MessageBox.Show("To pay 0 $");
            }
            GetInformation();
        }
        public static async void ReadFromListAccountAsync()
        {
            AccountClient account;
            using (StreamReader reader = new StreamReader("AccountClientList.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string result = await reader.ReadLineAsync();  // асинхронное чтение из файла
                    string[] accountClient = result.Split("\t\t");
                    account = new(
                       accountClient[0],
                        accountClient[1],
                        Double.Parse(accountClient[2]));
                    AccountList.Add(account);
                }
            }
        }
        static async public void SaveAllAccountAtFile()
        {
            using (StreamWriter writer = new StreamWriter("AccountClientList.txt", false))
            {
                foreach (var account in AccountList)
                {
                    await writer.WriteLineAsync(
                        $"{account.NameClient}\t\t" +
                        $"{account.Password}\t\t" +
                        $"{account.Bonus}");  // асинхронная запись в файл
                }
            }
        }
    }
}
