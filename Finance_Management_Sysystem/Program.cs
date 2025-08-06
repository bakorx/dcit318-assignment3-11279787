using System;

class Program
{
    static void Main()
    {
        TransactionManager manager = new TransactionManager();

        // Add sample transactions
        manager.AddTransaction(new Transaction(1000, DateTime.Now.AddDays(-3), "Income"));
        manager.AddTransaction(new Transaction(500, DateTime.Now.AddDays(-2), "Expense"));
        manager.AddTransaction(new Transaction(200, DateTime.Now.AddDays(-1), "Income"));

        manager.PrintSummary();
    }
}
