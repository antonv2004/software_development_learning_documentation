using classes_and_objects;

// Create an object
Bankaccount account = new Bankaccount();
account.Balance = 2500;
account.User = "Anton";

account.Deposit(250);
account.Withdraw(250);
