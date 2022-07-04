namespace csharp_banca_oop
{
    internal class Loan
    {
        Customer customer;
        public string Id { get; private set; }
        public int LoanTotal { get; set; }
        public int Installment { get; set; }
        public DateTime StartingDate { get; set; }
        public string EndingDate { get; set; }

        public Loan (Customer customer, int loanTotal, int installment, DateTime startingDate)
        {
            this.customer = customer;
            this.Id = new Random().Next(1, 100000000).ToString().PadLeft(8, '0'); ;
            this.LoanTotal = loanTotal;
            this.Installment = installment;
            this.StartingDate = startingDate;
            this.EndingDate = this.StartingDate.AddMonths(GetDurataLoan()).ToString("d");
        }   

        public static Loan AddNewLoan(Customer customer)
        {
            return new Loan(customer, 10000, 500, DateTime.Now);
        }

        public void PrintLoan()
        {
            Console.WriteLine("id: {0}", this.Id);
            Console.WriteLine("Totale: {0}", this.LoanTotal);
            Console.WriteLine("Rata: {0}", this.Installment);
            Console.WriteLine("Data inizio: {0}", this.StartingDate);
            Console.WriteLine("Data fine: {0}", this.EndingDate);
        }

        private int GetDurataLoan()
        {
            return this.LoanTotal / this.Installment;
        }

        
    }
}