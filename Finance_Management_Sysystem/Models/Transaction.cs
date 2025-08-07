namespace FinanceApp.Models
{
    public record Transaction(int Id, DateTime Date, decimal Amount, string Description);
}