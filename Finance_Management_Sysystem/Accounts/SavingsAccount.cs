using System;
using FinanceApp.Models;

namespace FinanceApp.Accounts
{
    public sealed class SavingsAccount : Account
    {
        public SavingsAccount(string accountNumber, decimal initialBalance)
            : base(accountNumber, initialBalance)
        {
        }

        public override void ApplyTransaction(Transaction transaction)
        {
            if (transaction.Amount > Balance)
            {
                Console.WriteLine("Insufficient funds for transaction.");
            }
            else
            {
                Balance -= transaction.Amount;
                Console.WriteLine($"[SavingsAccount] {transaction.Amount:C} deducted. New Balance: {Balance:C}");
            }
        }
    }
}
