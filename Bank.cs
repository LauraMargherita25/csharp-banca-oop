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
        private List<Customer> customers;
        private List<Loan> loans = new List<Loan>();

        public Bank (string name)
        {
            this.Name = name;
            this.customers = new List<Customer>();
            this.loans = new List<Loan>();
        }
    }
}
