using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Bank
    {
        public string Name { get; set; }
        public List<Customer> customers;
        public List<Loan> loans;

        public Bank (string name)
        {
            this.Name = name;
            this.customers = new List<Customer>();
            this.loans = new List<Loan>();
        }

        internal void OpenBank()
        {
            Console.WriteLine("Benvenuto in Banca {0}", this.Name);
  
            string[] menu = { "Registra un nuovo cliente", "Cerca un cliente", };
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine("{0}.{1}", i + 1, menu[i]);
            }
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                this.AddNewCustomer();
            }
            else if(input == 2)
            {
                this.SearchCustomer();
            }
            else
            {
                Console.WriteLine("Scelta non valida");
            }
        }

        private void AddNewCustomer()
        {
            Console.WriteLine("Registra un nuovo cliente");

            Console.Write("Nome Cliente: ");
            string inputName = Console.ReadLine();
            Console.Write("Cognome Cliente: ");
            string inputSurname = Console.ReadLine();
            Console.Write("Codice Fiscale: ");
            string inputTaxCode = Console.ReadLine();
            Console.Write("Stipendio: ");
            int inputSalary = int.Parse(Console.ReadLine());

            Customer newCustomer = new Customer(inputName, inputSurname, inputTaxCode, inputSalary);
        }

        private void SearchCustomer()
        {
            Console.Clear();
            string input;
            bool notFound = true;


            do
            {
                Console.WriteLine("Ricerca cliente per cognome o codice fiscale");
                input = Console.ReadLine();
                foreach (Customer customer in customers)
                {
                    if (customer.Surname == input || customer.TaxCode == input)
                    {
                        notFound = false;
                       
                        customer.PrintCustomer();


                        string[] menu = { "Modifica i dati del cliente", "Aggiungi un nuovo prestito" };
                        for (int i = 0; i < menu.Length; i++)
                        {
                            Console.WriteLine("{0}.{1}", i + 1, menu[i]);
                        }


                        int menuInput = int.Parse(Console.ReadLine());
                        if (menuInput == 1)
                        {
                            customer.UpdateCustomerData();

                        }
                        else if (menuInput == 2)
                        {
                            this.AddNewLoan(customer);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nessun cliente trovato.Riprova!");
                    }
                }
            } while (notFound);
        }
        public void AddNewLoan(Customer customer)
        {
            Console.WriteLine("Compila il modulo per avviare un nuovo prestito");

            Console.Write("Totale prestito: ");
            int inputLoanTotal = int.Parse(Console.ReadLine());
            Console.Write("Rata mensile: ");
            int inputInstallment = int.Parse(Console.ReadLine());
            Console.Write("Data prima rata: ");
            DateOnly startingDate = DateOnly.Parse(Console.ReadLine());
            Loan newLoan = new Loan(customer, inputLoanTotal, inputInstallment, startingDate);
            loans.Add(newLoan);
            
            Console.Clear();
            Console.WriteLine("Apertura prestito andata a buon fine");
            newLoan.PrintLoan();
        }
    }
}
