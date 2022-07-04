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
            Name = name;
            Surname = surname;
            TaxCode = taxCode;
            Salary = salary;
        }
    }
}