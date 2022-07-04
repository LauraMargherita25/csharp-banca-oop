// See https://aka.ms/new-console-template for more information
using csharp_banca_oop;

Bank bancaSella = new Bank("Sella");

bancaSella.OpenBank();

//------------ dati di servizio --------------//

Customer cliente1 = new Customer("Gino", "Rossi", "QWERTT12A34S678D", 1000);
bancaSella.customers.Add(cliente1);

//------------ dati di servizio --------------//