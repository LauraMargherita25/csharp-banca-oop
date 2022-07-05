namespace csharp_banca_oop
{
    internal class Loan
    {
        public Customer customer { get; set; }
        public string Id { get; private set; }
        public int LoanTotal { get; set; }
        public int Installment { get; set; }
        public DateOnly StartingDate { get; set; }
        public string EndingDate { get; set; }

        public Loan (Customer customer, int loanTotal, int installment, DateOnly startingDate)
        {
            this.customer = customer;
            this.Id = new Random().Next(1, 100000000).ToString().PadLeft(8, '0'); ;
            this.LoanTotal = loanTotal;
            this.Installment = installment;
            this.StartingDate = startingDate;
            this.EndingDate = this.StartingDate.AddMonths(GetDurataLoan()).ToString("d");
        }   

        //public static void AddNewLoan(Customer customer)
        //{
        //    Console.WriteLine("Compila il modulo per avviare un nuovo prestito");

        //    Console.Write("Totale prestito: ");
        //    int inputLoanTotal = int.Parse(Console.ReadLine());
        //    Console.Write("Rata mensile: ");
        //    int inputInstallment = int.Parse(Console.ReadLine());
        //    Console.Write("Data prima rata: ");
        //    DateOnly startingDate = DateOnly.Parse(Console.ReadLine());
        //    Loan newLoan = new Loan(customer, inputLoanTotal, inputInstallment, DateOnly.FromDateTime(DateTime.Now));
            
        //    Console.Clear();
        //    Console.WriteLine("Apertura prestito andata a buon fine");
        //    newLoan.PrintLoan();    
        //}

        public void PrintLoan()
        {
            Console.WriteLine("id: {0}", this.Id);
            Console.WriteLine("Totale: {0}", this.LoanTotal);
            Console.WriteLine("Rata: {0}", this.Installment);
            Console.WriteLine("Numero rate: {0}", GetDurataLoan());
            Console.WriteLine("Data inizio: {0}", this.StartingDate);
            Console.WriteLine("Data fine: {0}", this.EndingDate);
        }

        private int GetDurataLoan()
        {
            return this.LoanTotal / this.Installment;
        }

        
    }
}