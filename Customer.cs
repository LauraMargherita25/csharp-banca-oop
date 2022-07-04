namespace csharp_banca_oop
{
    public class Customer
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
        }

        internal void PrintCustomer()
        {
            Console.Clear();
            Console.WriteLine("Cognome: {0}", this.Surname);
            Console.WriteLine("Nome: {0}", this.Name);
            Console.WriteLine("Cognome: {0}", this.TaxCode);

            Console.WriteLine();

            string[] menu = { "Modifica i dati del cliente", "Aggiungi un nuovo prestito" };
            for(int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine("{0}.{1}", i + 1, menu[i]);
            }
            int input = int.Parse(Console.ReadLine());
            if(input == 1)
            {
                this.UpdateUserData();

            } 
            //else if (input == 2)
            //{
            //    Loan.AddNewLoan();
            //}
            
        }

        private void UpdateUserData()
        {
            Console.Write("Cognome: ");
            this.Surname = Console.ReadLine();
            Console.Write("Nome: ");
            this.Name = Console.ReadLine();
            Console.Write("Codice fiscale: ");
            this.TaxCode = Console.ReadLine();

            this.PrintCustomer();
        }

        //private void AddNewLoan()
        //{
        //    Loan newLoan = new Loan(this.customer,)
        //}
    }
}