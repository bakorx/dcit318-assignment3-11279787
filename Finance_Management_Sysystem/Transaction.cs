public record Transaction(decimal Amount, DateTime Date, string Type) : ITransaction;
