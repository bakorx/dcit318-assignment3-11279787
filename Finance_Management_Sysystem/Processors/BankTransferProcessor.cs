using System;
using FinanceApp.Models;
using FinanceApp.Interfaces;

namespace FinanceApp.Processors
{
    public class BankTransferProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine($"[Bank Transfer] Processed: {transaction.Description} - Amount: {transaction.Amount:C}");
        }
    }
}