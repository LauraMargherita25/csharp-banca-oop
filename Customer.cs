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
    }
}