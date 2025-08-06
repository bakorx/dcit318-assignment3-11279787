using FinanceApp.Interfaces;
using FinanceApp.Models;
using System;

namespace FinanceApp.Processors
{
    public class CryptoWalletProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine($"[Crypto Wallet] Paid {transaction.Amount:C} in crypto for {transaction.Category}");
        }
    }
}
