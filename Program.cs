// See https://aka.ms/new-console-template for more information
using csharp_banca_oop;

Bank bancaSella = new Bank("Sella");

//------------ dati di servizio --------------//

Customer cliente1 = new Customer("Gino", "Rossi", "QWERTT12A34S678D", 1000);
bancaSella.customers.Add(cliente1);

Loan loan1 = new Loan(cliente1, 10000, 500, DateOnly.Parse("05/05/21"));
bancaSella.loans.Add(loan1);
Loan loan2 = new Loan(cliente1, 10000, 500, DateOnly.FromDateTime(DateTime.Now));
bancaSella.loans.Add(loan2);
Loan loan3 = new Loan(cliente1, 10000, 500, DateOnly.Parse("05/08/22"));
bancaSella.loans.Add(loan3);

//------------ dati di servizio --------------//

bancaSella.OpenBank();

