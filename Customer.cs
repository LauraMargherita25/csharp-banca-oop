namespace csharp_banca_oop
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TaxCode { get; set; }
        public int Salary { get; set; }

        public Customer (string name, string surname, string taxCode, int salary)
        {
            this.Name = name;
            this.Surname = surname;
            this.TaxCode = taxCode;
            this.Salary = salary;
            //this.loans = new List<Loan> ();
        }

        internal void PrintCustomer()
        {
            Console.WriteLine("Cognome: {0}", this.Surname);
            Console.WriteLine("Nome: {0}", this.Name);
            Console.WriteLine("Cognome: {0}", this.TaxCode);
        }

        internal void UpdateCustomerData()
        {
            Console.Write("Cognome: ");
            this.Surname = Console.ReadLine();
            Console.Write("Nome: ");
            this.Name = Console.ReadLine();
            Console.Write("Codice fiscale: ");
            this.TaxCode = Console.ReadLine();

            this.PrintCustomer();
        }

    }
}