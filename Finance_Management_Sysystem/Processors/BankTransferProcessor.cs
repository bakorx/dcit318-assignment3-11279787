using FinanceApp.Interfaces;
using FinanceApp.Models;
using System;

namespace FinanceApp.Processors
{
    public class BankTransferProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine($"[Bank Transfer] Processed transaction of {transaction.Amount:C} for {transaction.Category}");
        }
    }
}
