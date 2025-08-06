using FinanceApp.Interfaces;
using FinanceApp.Models;
using System;

namespace FinanceApp.Processors
{
    public class MobileMoneyProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine($"[Mobile Money] Sent {transaction.Amount:C} for {transaction.Category}");
        }
    }
}
