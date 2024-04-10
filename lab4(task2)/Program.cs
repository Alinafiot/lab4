using lab4_task2_.BankAccount;
using System;

class Program
{
    static void Main(string[] args)
    {
        UAH uahAccount = new UAH();
        USD usdAccount = new USD();
        Credit creditAccount = new Credit();

        DisplayAccountInfo(uahAccount);
        DisplayAccountInfo(usdAccount);
        DisplayAccountInfo(creditAccount);

        BankAccount[] accounts = { uahAccount, usdAccount, creditAccount };

        int totalBalance = BankAccount.TotalBalance(accounts);
        int totalNegativeBalance = BankAccount.TotalNegativeBalance(accounts);
        int totalPositiveBalance = BankAccount.TotalPositiveBalance(accounts);

        Console.WriteLine($"Загальна сума по рахункам: {totalBalance}");
        Console.WriteLine($"Сума негативних балансів: {totalNegativeBalance}");
        Console.WriteLine($"Сума позитивних балансів: {totalPositiveBalance}");
    }

    static void DisplayAccountInfo(BankAccount account)
    {
        Console.WriteLine($"{account.GetType().Name} Account:");
        Console.WriteLine($"Номер рахунку: {account.Number}, Баланс: {account.Balance}, Статус рахунку: {(account.IsBlocked ? "заблокований" : "не заблокований")}");

        if (account is Credit creditAccount)
        {
            Console.WriteLine($"Сума кредиту: {creditAccount.SumOfCredit}");
        }
    }
}
