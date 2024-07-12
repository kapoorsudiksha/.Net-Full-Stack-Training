
namespace coreConsoleBasicApp
{

    abstract class ABCBank
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to ABC Bank!");
        }
        public abstract void OpenAccount();
        public abstract void CloseAccount();
    }

    abstract class BankAccount : ABCBank
    {
        public abstract void Deposit();
        public abstract void Withdraw();
        public abstract void PrintAccountDetails();
    }

    class SavingAccount : BankAccount
    {
        public override void OpenAccount()
        {
            Console.WriteLine("Opening a Saving Account!");
        }

        public override void CloseAccount()
        {
            Console.WriteLine("Closing a Saving Account!");
        }

        public override void Deposit()
        {
            Console.WriteLine("Deposit in Saving Account!");
        }
        public override void PrintAccountDetails()
        {
            Console.WriteLine("Printing Saving Account Details Here!");
        }

        public override void Withdraw()
        {
            Console.WriteLine("Withdrawal from Saving Account!");
        }
    }
    class CurrentAccount : BankAccount
    {
        public override void OpenAccount()
        {
            Console.WriteLine("Opening a Current Account!");
        }

        public override void CloseAccount()
        {
            Console.WriteLine("Closing a Current Account!");
        }
        public override void Deposit()
        {
            Console.WriteLine("Deposit in Current Account!");
        }

        public override void PrintAccountDetails()
        {
            Console.WriteLine("Printing Current Account Details Here!");
        }

        public override void Withdraw()
        {
            Console.WriteLine("Withdrawal from Current Account!");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            // Error: Abstract Class can't be instantiated.
            // BankAccount account = new BankAccount();

            ABCBank.WelcomeMessage();

            Console.WriteLine();

            Console.WriteLine("Saving Account Transactions:");
            SavingAccount savingAccount = new SavingAccount();
            savingAccount.OpenAccount();    
            savingAccount.Deposit();
            savingAccount.Withdraw();
            savingAccount.PrintAccountDetails();
            savingAccount.CloseAccount();

            Console.WriteLine();

            Console.WriteLine("Current Account Transactions.");
            CurrentAccount currentAccount = new CurrentAccount();
            currentAccount.OpenAccount();
            currentAccount.Deposit();
            currentAccount.Withdraw();
            currentAccount.PrintAccountDetails();
            currentAccount.CloseAccount();


            
        }
    }
}


/* ******************************************************************** */

namespace coreConsoleBasicApp
{

    abstract class ABCBank
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to ABC Bank!");
        }
        public abstract void OpenAccount();
        public abstract void CloseAccount();
    }

    abstract class BankAccount : ABCBank
    {

        // Properties

        public string? AccountNumber { get; set; }
        public string? AccountHolderName { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, string accountHolderName, decimal balance)
        {
            this.AccountNumber = accountNumber;
            this.AccountHolderName = accountHolderName;
            this.Balance = balance;
        }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
        public abstract void PrintAccountDetails();
    }

    class SavingAccount : BankAccount
    {
        public SavingAccount(string accountNumber, string accountHolderName, decimal balance)
            :base(accountNumber, accountHolderName, balance) { }

        public override void OpenAccount()
        {
            Console.WriteLine("Opening a Saving Account!");
        }

        public override void CloseAccount()
        {
            Console.WriteLine("Closing a Saving Account!");
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. New Balance is {Balance}");
        }
        public override void PrintAccountDetails()
        {
            Console.WriteLine("Printing Saving Account Details Here!");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Name: {AccountHolderName}");
            Console.WriteLine($"Account Balance: {Balance}");
        }

        public override void Withdraw(decimal amount)
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
    }
    class CurrentAccount : BankAccount
    {
        public CurrentAccount(string accountNumber, string accountHolderName, decimal balance)
           : base(accountNumber, accountHolderName, balance) { }

        public override void OpenAccount()
        {
            Console.WriteLine("Opening a Current Account!");
        }

        public override void CloseAccount()
        {
            Console.WriteLine("Closing a Current Account!");
        }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. New Balance is {Balance}");
        }

        public override void PrintAccountDetails()
        {
            Console.WriteLine("Printing Current Account Details Here!");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Name: {AccountHolderName}");
            Console.WriteLine($"Account Balance: {Balance}");
        }

        public override void Withdraw(decimal amount)
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
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            // Error: Abstract Class can't be instantiated.
            // BankAccount account = new BankAccount();

            ABCBank.WelcomeMessage();

            Console.WriteLine();

            Console.WriteLine("Saving Account Transactions:");
            SavingAccount savingAccount = new SavingAccount("5101", "John Smith", 1000);
            savingAccount.OpenAccount();    
            savingAccount.Deposit(1000);
            savingAccount.Withdraw(500);
            savingAccount.PrintAccountDetails();
            savingAccount.CloseAccount();

            Console.WriteLine();

            Console.WriteLine("Current Account Transactions.");
            CurrentAccount currentAccount = new CurrentAccount("5102", "Kartik Sharma", 2000);
            currentAccount.OpenAccount();
            currentAccount.Deposit(10000);
            currentAccount.Withdraw(5000);
            currentAccount.PrintAccountDetails();
            currentAccount.CloseAccount();


            
        }
    }
}
