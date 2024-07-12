
/* Demonstration: To Count the number of accounts created. (Static Variable and Static Method)*/

namespace coreConsoleBasicApp
{

    class BankAccount
    {
        public string? AccountNumber { get; set; }
        public decimal Balance { get; set; }

        // A variable to keep track of total accounts created.
        public static int totalAccountsCreated;

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            this.AccountNumber = accountNumber;
            this.Balance = initialBalance;
            // Increment total accounts created when a new instance is created.
            totalAccountsCreated++;
        }

        public static int GetTotalAccountsCreated()
        {
            return totalAccountsCreated;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            // Creating Bank Accounts:
            BankAccount account1 = new BankAccount("1234567890", 1000);
            BankAccount account2 = new BankAccount("9876543210", 2000);

            // Get Total Accounts Created:
            int totalAccounts = BankAccount.GetTotalAccountsCreated();
            Console.WriteLine($"Total Accounts Created: {totalAccounts}");
            Console.WriteLine(BankAccount.totalAccountsCreated);

            Console.ReadKey();
        }
    }
}

/* ********************************************************** */

namespace coreConsoleBasicApp
{

    class BankAccount
    {
        public string? AccountNumber { get; set; }
        public decimal Balance { get; set; }

        // Instance Method to deposit money into the account.
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. New Balance is {Balance}");
        }

        // Instance Method to withdraw money from the account.
        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. New Balance is {Balance}");
            }
            if (Balance < amount)
            {
                Console.WriteLine("Insufficient Balance.");
            }
        }

        // Static Method
        public static BankAccount createAccount(string accountNumber, decimal initalBalance)
        {
            var account = new BankAccount
            {
                AccountNumber = accountNumber,
                Balance = initalBalance
            };
            return account;
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount account1 = BankAccount.createAccount("1234567890", 1000);
            account1.Deposit(500);
            account1.Withdraw(200);

            Console.ReadKey();
        }
    }
}

/* ********************************************************** */

/* Demonstration: Static Method and Static Classes: */

namespace coreConsoleBasicApp
{
    class BankAccount
    {
        public string? AccountNumber { get; set; }
        public decimal Balance { get; set; }

        // Instance Method to deposit money into the account.
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. New Balance is {Balance}");
        }

        // Instance Method to withdraw money from the account.
        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. New Balance is {Balance}");
            }
            if (Balance < amount)
            {
                Console.WriteLine("Insufficient Balance.");
            }
        }

        // Static Method
        public static BankAccount createAccount(string accountNumber, decimal initalBalance)
        {
            var account = new BankAccount
            {
                AccountNumber = accountNumber,
                Balance = initalBalance
            };
            return account;
        }

    }

    static class BankUtilities
    {
        public static decimal CalculateInterest(decimal balance, decimal interestRate)
        {
            return balance * (interestRate / 100);
        }

        public static void LogTransaction(string? accountNumber, string transactionType, decimal amount)
        {
            string logMessage = $"{DateTime.Now}: Account {accountNumber} -  {transactionType},  ${amount}";
            Console.WriteLine(logMessage);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            // Creating a bank Account
            BankAccount account1 = BankAccount.createAccount("1234567890", 1000);
            
            // Deposit and Withdraw Operations
            account1.Deposit(500);
            account1.Withdraw(200);

            // Calculate Interest
            decimal interest = BankUtilities.CalculateInterest(account1.Balance, 5);
            Console.WriteLine($"Interest Earned: {interest}");

            // Logging a transaction
            BankUtilities.LogTransaction(account1.AccountNumber, "Withdrawal", 200);

            Console.ReadKey();
        }
    }
}


