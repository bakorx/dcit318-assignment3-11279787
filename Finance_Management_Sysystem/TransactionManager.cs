using System;
using System.Collections.Generic;
using System.Linq;

public sealed class TransactionManager
{
    private List<ITransaction> transactions = new List<ITransaction>();

    public void AddTransaction(ITransaction transaction)
    {
        transactions.Add(transaction);
    }

    public decimal GetTotalIncome()
    {
        return transactions.Where(t => t.Type == "Income").Sum(t => t.Amount);
    }

    public decimal GetTotalExpenses()
    {
        return transactions.Where(t => t.Type == "Expense").Sum(t => t.Amount);
    }

    public void PrintSummary()
    {
        Console.WriteLine("All Transactions:");
        foreach (var t in transactions)
        {
            Console.WriteLine($"{t.Date.ToShortDateString()} - {t.Type}: ${t.Amount}");
        }

        Console.WriteLine($"\nTotal Income: ${GetTotalIncome()}");
        Console.WriteLine($"Total Expenses: ${GetTotalExpenses()}");
        Console.WriteLine($"Net Balance: ${GetTotalIncome() - GetTotalExpenses()}");
    }
}
