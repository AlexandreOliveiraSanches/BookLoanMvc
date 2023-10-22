namespace BookLoanMvc.Models
{
    public class LoansModel
    {
        public int Id { get; set; }
        public string Recipient { get; set; }
        public string Lender { get; set; }
        public string Book { get; set; }
        public DateTime LastUpdate { get; set; } = DateTime.Now;
    }
}
