namespace MoneyTrack
{
    public class Expense
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
    }
}