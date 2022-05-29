using System;

namespace Kurs7_Labb1_MsUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            HamsterArt.HamsterWelcome();
            Bank.TransactionProcessTimer();
            StoreAndLoad.LoadTransactions();
            StoreAndLoad.LoadAccounts();
            StoreAndLoad.LoadUsers();
            Bank.Login();
        }
    }
}
