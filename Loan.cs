namespace csharp_banca_oop
{
    internal class Loan
    {
        Customer customer;
        public int Id { get; set; }
        public int LoanTotal { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }

        public Loan (Customer customer, int id, int loanTotal, DateTime startingDate, DateTime endingDate)
        {
            this.customer = customer;
            this.Id = id;
            this.LoanTotal = loanTotal;
            this.StartingDate = startingDate;
            this.EndingDate = endingDate;
        }   
    }
}