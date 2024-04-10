using lab4_task2_.BankAccount;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
public class UAH : BankAccount
{
    public int CurseUAN { get; set; }

    public override string ToString()
    {
        return $"CurseUAN = {CurseUAN}";
    }

    public override int GetTotalBalance() => Balance + CurseUAN;

    public override int GetTotalNegativeBalance() => base.GetTotalNegativeBalance() + CurseUAN;

    public override int GetTotalPositiveBalance() => base.GetTotalPositiveBalance() + CurseUAN;
}

public class USD : BankAccount
{
    public int CurseUSD { get; set; }

    public override string ToString()
    {
        return $"CurseUSD  = {CurseUSD}";
    }

    public override  int GetTotalBalance() => Balance + CurseUSD;

    public override int GetTotalNegativeBalance() => base.GetTotalNegativeBalance() + CurseUSD;

    public override int GetTotalPositiveBalance() => base.GetTotalPositiveBalance() + CurseUSD;
}

public class Credit : BankAccount
{
    public int SumOfCredit { get; set; }

    public Credit()
    {
        SumOfCredit = GenerateCreditAmount();
    }

    public int GenerateCreditAmount()
    {
        Random random = new Random();
        return random.Next(1000, 11000);
    }

    public override string ToString()
    {
        return $"SumOfCredit  = {SumOfCredit}";
    }

    public override int GetTotalBalance() => Balance - SumOfCredit;

    public override int GetTotalNegativeBalance() => base.GetTotalNegativeBalance() - SumOfCredit;

    public override int GetTotalPositiveBalance() => base.GetTotalPositiveBalance() - SumOfCredit;
}
