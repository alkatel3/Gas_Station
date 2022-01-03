using System;


namespace GasStation
{
    class AccountClient
    {
        public string NameClient { get; private set; }
        private string Password;
        private byte AccrualBonuses = 100;//нарахування здійснюється як 1% від суми купленого палива,тобто для розрахунку треба: sum/100
        private double Bonus = 0;// при створенні акаунту сума бонусів дорівнює 0
        internal AccountClient(string nameClient, string password)
        {
            NameClient = nameClient;
            Password = password;
            Console.WriteLine(GetInformation());
        }
        public string GetInformation()
        {
            return $"You account:\nName: {NameClient}\nPassword: {Password}\nBonus: {Bonus} $";
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
            Console.WriteLine(GetInformation());
        }
        public void AddingBonus(double sum)
        {
            Bonus += sum / AccrualBonuses;
            Console.WriteLine($"You are added {sum / AccrualBonuses} bonus");
            GetInformation();
        }
    }
}
