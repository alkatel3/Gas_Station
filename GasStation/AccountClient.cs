using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GasStation
{
    class AccountClient
    {
        static List<AccountClient> AccountList = new();
        public string NameClient { get; private set; }
        private string Password;
        private byte AccrualBonuses = 100;//нарахування здійснюється як 1% від суми купленого палива,тобто для розрахунку треба: sum/100
        private double Bonus = 0;// при створенні акаунту сума бонусів дорівнює 0
        internal AccountClient(string nameClient, string password)
        {
            NameClient = nameClient;
            Password = password;
        }
        public void GetInformation()
        {
            MessageBox.Show(
                $"You account:\n" +
                $"Name: {NameClient}\n" +
                $"Password: {Password}\n" +
                $"Bonus: {Bonus} $");
        }
        public void SaveAccount()
        {
            AccountList.Add(this);
        }
        static public AccountClient FoundAccount(string AccountName, string AccountPassword)
        {
            var Accounts = from accounts in AccountList
                           where accounts.NameClient == AccountName
                           where accounts.Password == AccountPassword
                           select accounts;
            AccountClient account = Accounts.ToArray().Length == 1 ? Accounts.ToArray()[0] : null;
            return account;
        }



        public bool PasswordVerification(string password)
        {
            return Password == password;
        }
        public void UsingBonus(double sum)
        {
            if (Bonus <= sum)
            {
                sum -= Bonus;
                Bonus = 0;// в даному випадку всі бонуси йдуть на погашення суми
                Console.WriteLine($"To pay {sum} $");
            }
            else
            {
                Bonus -= sum;
                Console.WriteLine("To pay 0 $");
            }
            GetInformation();
        }
        public void AddingBonus(double sum)
        {
            Bonus += sum / AccrualBonuses;
            Console.WriteLine($"You are added {sum / AccrualBonuses} bonus");
            GetInformation();
        }
    }
}
