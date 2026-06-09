namespace MoneyTransactions
{
public class Program
{
    public static void Main()
    {
        Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        string[] input = Console.ReadLine().Split(',');

        foreach (string acc in input)
        {
            string[] data = acc.Split('-');
            int id = int.Parse(data[0]);
            double balance = double.Parse(data[1]);

            accounts.Add(id, new BankAccount(id, balance));
        }

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] arguments = command.Split();
            string action = arguments[0];

            try
            {
                if (action != "Deposit" && action != "Withdraw")
                {
                    throw new ArgumentException();
                }

                int accountId = int.Parse(arguments[1]);
                double sum = double.Parse(arguments[2]);

                if (!accounts.ContainsKey(accountId))
                {
                    throw new KeyNotFoundException();
                }

                BankAccount currentAccount = accounts[accountId];

                if (action == "Deposit")
                {
                    currentAccount.Deposit(sum);
                }
                else if (action == "Withdraw")
                {
                    currentAccount.Withdraw(sum);
                }

                Console.WriteLine($"Account {accountId} has new balance: {currentAccount.Balance:F2}");
            }
            catch (Exception ex)
            {
                Type exceptionType = ex.GetType();

                if (exceptionType == typeof(ArgumentException))
                {
                    Console.WriteLine("Invalid command!");
                }
                else if (exceptionType == typeof(KeyNotFoundException))
                {
                    Console.WriteLine("Invalid account!");
                }
                else if (exceptionType == typeof(InvalidOperationException))
                {
                    Console.WriteLine("Insufficient balance!");
                }
            }
            finally
            {
                Console.WriteLine("Enter another command");
            }
        }
    }
}

public class BankAccount
{
    public int AccountNumber { get; set; }
    public double Balance { get; set; }

    public BankAccount(int accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public void Deposit(double sum)
    {
        Balance += sum;
    }

    public void Withdraw(double sum)
    {
        if (Balance < sum)
        {
            throw new InvalidOperationException();
        }

        Balance -= sum;
    }
}
}
