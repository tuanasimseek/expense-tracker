namespace ExpenseTracker.Api.Models;

public class Expense
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;

    public int CategoryId { get; set; }      // Foreign key
    public Category? Category { get; set; }  // Navigation property
}