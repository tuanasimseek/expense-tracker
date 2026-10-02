namespace ExpenseTracker.Api.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    // Bir kategoriye bağlı birden fazla harcama olabilir
    public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
}