namespace Bank200.Models
{
    public class CurrentAccount
    {
        public int AccountId { get; set; }
        public string CustomerNumber { get; set; }
        public int PositiveBalance { get; set; }

        public int Overdraft { get; set; }
    }
}
