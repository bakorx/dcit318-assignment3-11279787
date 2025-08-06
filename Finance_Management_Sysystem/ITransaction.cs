public interface ITransaction
{
    decimal Amount { get; }
    DateTime Date { get; }
    string Type { get; } // "Income" or "Expense"
}
