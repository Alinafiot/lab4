using System;

namespace lab4_task2_.BankAccount
{
    public class BankAccount
    {
        public static readonly Random random = new Random();
        public int Number { get; set; }
        public int Balance { get; set; }
        public bool IsBlocked { get; set; }

        public BankAccount()
        {
            Number = GenerateNumber();
            Balance = GenerateBalance();
            IsBlocked = GenerateStatus();
        }

        public int GenerateNumber()
        {
            return random.Next(100000, 999999);
        }

        public int GenerateBalance()
        {
            return random.Next(-1000, 1001);
        }

        public bool GenerateStatus()
        {
            return random.Next(2) == 1;
        }

        public virtual int GetTotalBalance()
        {
            return Balance;
        }

        public virtual int GetTotalNegativeBalance()
        {
            if (Balance < 0)
                return Balance;
            else
                return 0;
        }

        public virtual int GetTotalPositiveBalance()
        {
            if (Balance > 0)
                return Balance;
            else
                return 0;
        }

        public static int TotalBalance(BankAccount[] accounts)
        {
            int totalBalance = 0;
            foreach (var account in accounts)
            {
                totalBalance += account.GetTotalBalance();
            }
            return totalBalance;
        }

        public static int TotalNegativeBalance(BankAccount[] accounts)
        {
            int totalNegativeBalance = 0;
            foreach (var account in accounts)
            {
                totalNegativeBalance += account.GetTotalNegativeBalance();
            }
            return totalNegativeBalance;
        }

        public static int TotalPositiveBalance(BankAccount[] accounts)
        {
            int totalPositiveBalance = 0;
            foreach (var account in accounts)
            {
                totalPositiveBalance += account.GetTotalPositiveBalance();
            }
            return totalPositiveBalance;
        }

        public override string ToString()
        {
            return $"Number = {Number}, Balance = {Balance}, IsBlocked = {IsBlocked}";
        }
    }
}
