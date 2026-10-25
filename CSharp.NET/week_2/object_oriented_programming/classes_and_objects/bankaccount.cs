namespace classes_and_objects;

// Create a class
public class Bankaccount
{
    // Properties
    public decimal Balance { get; set; } // Getter: allows reading a value
                                            // Setter: allows changing a value
    public string User { get; set; }

    // Methods
    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine("{0} euros have been deposited into the account!", amount);
        Console.WriteLine("The new account balance is {0} euros!", Balance);
    }

    public void Withdraw(decimal amount)
    {
        Balance -= amount;
        Console.WriteLine("{0} euros have been withdrawn from the account.", amount);
        Console.WriteLine("The new account balance is {0} euros!", Balance);
    }
}
