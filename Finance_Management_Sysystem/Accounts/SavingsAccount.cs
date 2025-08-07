using System;
using FinanceApp.Models;

namespace FinanceApp.Accounts
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(string accountNumber, decimal initialBalance)
            : base(accountNumber, initialBalance)
        {
        }

        public override void ApplyTransaction(Transaction transaction)
        {
            base.ApplyTransaction(transaction);
            Console.WriteLine($"[Savings Account] Transaction Applied: {transaction.Description}, New Balance: {Balance:C}");
        }
    }
}