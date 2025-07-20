namespace BankEncapsulation;

public class BankAccount
{
    // A private field of type double named balance with a value of 0
    // Define a method named Deposit that will accept a double and store that value in the balance field
    //     Define a method named GetBalance that will return the amount stored in the balance field
    
    private double _balance = 0;
    
    public void Deposit(double amount)
    {
        _balance += amount;
    }
    public void Withdraw(double amount)
    {
        _balance -= amount;
    }

    public double GetBalance()
    {
        return _balance;
    }

}