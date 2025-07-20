namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Name: ");
            string name = Console.ReadLine();
            
            Console.WriteLine($"{name} Please enter what operation you want to complete");
            Console.WriteLine("Press 1 to check your balance");
            Console.WriteLine("Press 2 to deposit money");
            Console.WriteLine("Press 3 to withdraw money");
            Console.WriteLine("Press 4 to quit");
            
            int operation  = int.Parse(Console.ReadLine());
            
            var Account = new BankAccount();
            for (int i = 0; i < operation; i++)
            {
                switch (operation)
                {
                    case 1:
                        Console.WriteLine($"Now your balance is: " + Account.GetBalance());
                        Console.WriteLine($"{name} Please enter what operation you want to complete");
                        operation  = int.Parse(Console.ReadLine());
                        i = 0;
                        break;
                    case 2:
                        Console.WriteLine("Enter amount you want to deposit");
                        double depositingAmmount = double.Parse(Console.ReadLine());
                        Account.Deposit(depositingAmmount);
                        Console.WriteLine($"Thank you for depositing {depositingAmmount}");
                        Console.WriteLine($"Now your balance is: " + Account.GetBalance());
                        Console.WriteLine($"{name} Please enter what operation you want to complete");
                        operation  = int.Parse(Console.ReadLine());
                        i = 0;
                        break;
                    case 3:
                        Console.WriteLine("Enter amount you want to withdraw");
                        double withdrawAmmount = double.Parse(Console.ReadLine());
                        
                        if (withdrawAmmount < Account.GetBalance())
                        {
                            Account.Withdraw(withdrawAmmount);
                        }
                        else
                        {
                            Console.WriteLine($"insufficient funds in your account: " +
                                              (Account.GetBalance() - withdrawAmmount));
                            Console.WriteLine($"{name} Please enter what operation you want to complete");
                            operation  = int.Parse(Console.ReadLine());
                            i = 0;
                        }

                        Console.WriteLine($"You withdrawed {withdrawAmmount}");
                        Console.WriteLine($"Now your balance is: " + Account.GetBalance());
                        Console.WriteLine($"{name} Please enter what operation you want to complete");
                        operation  = int.Parse(Console.ReadLine());
                        i = 0;
                        break;
                    case 4:
                        Console.WriteLine($"You has been logged off");
                        break;
                    default:
                        Console.WriteLine($"Please enter a valid option");
                        operation  = int.Parse(Console.ReadLine());
                        break;

                }

            }
        }
    }
}
