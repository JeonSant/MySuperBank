// See https://aka.ms/new-console-template for more information
using BankyStuffLibrary;


var account = new BankAccount("Kendra", 10000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

account.MakeWithDrawal(120, DateTime.Now, "Hammock");
//Console.WriteLine(account.Balance);

account.MakeWithDrawal(50, DateTime.Now, "Xbox Game");
//Console.WriteLine(account.Balance);


Console.WriteLine(account.GetAccountHistory());
