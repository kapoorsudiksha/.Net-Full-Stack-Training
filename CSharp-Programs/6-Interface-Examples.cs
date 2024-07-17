
/* Demonstration: Interfaces */

namespace coreConsoleBasicApp
{

    interface IBankAccount
    {
        public string AccountNumber { get; }
        public decimal Balance {  get; }

        void Deposit(decimal amount);     // By default Methods are public and abstract
        void Withdraw(decimal amount);
        void Transfer(IBankAccount destinationAccount, decimal amount);
    }

    public class CheckingAccount : IBankAccount
    {
        private string accountNumber;
        private decimal balance;

        public CheckingAccount(string accountNumber, decimal balance)
        {
           this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public string AccountNumber => accountNumber;
        public decimal Balance => balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited ${amount} into account {accountNumber}");
        }

        public void Withdraw(decimal amount)
        {
            if(balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn ${amount} from account {accountNumber}");
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }

        void IBankAccount.Transfer(IBankAccount destinationAccount, decimal amount)
        {
            if(balance >= amount)
            {
                balance -= amount;
                destinationAccount.Deposit(amount);
                Console.WriteLine($"Transferred ${amount} from account {accountNumber}");
            }
            else
            {
                Console.WriteLine("Insufficient Funds for Transfer.");
            }
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            // Error: Interfaces can't be instantiated.
            // IBankAccount bankAccount = new IBankAccount();

            IBankAccount account1 = new CheckingAccount("12345", 1000);
            IBankAccount account2 = new CheckingAccount("67890", 2000);

            // Deposit into Account1
            account1.Deposit(1000);
            // Withdraw from Account1
            account1.Withdraw(500);
            // Transfer from Account1 to Account2
            account1.Transfer(account2 , 500);

            // Output
            Console.WriteLine($"Account {account1.AccountNumber}, Balance: {account1.Balance}");
            Console.WriteLine($"Account {account2.AccountNumber}, Balance: {account2.Balance}");

        }
    }
}

/* ****************************************************** */

/* Demonstration: Implementing Multiple Inheritance using Interface */

namespace coreConsoleBasicApp
{

    interface IBankAccount
    {
        public string AccountNumber { get; }
        public decimal Balance {  get; }

        void Deposit(decimal amount);     // By default Methods are public and abstract
        void Withdraw(decimal amount);
    }

    interface ITransferable
    {
        void Transfer(IBankAccount destinationAccount, decimal amount);
    }

    public class CheckingAccount : IBankAccount, ITransferable
    {
        private string accountNumber;
        private decimal balance;

        public CheckingAccount(string accountNumber, decimal balance)
        {
           this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public string AccountNumber => accountNumber;
        public decimal Balance => balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited ${amount} into account {accountNumber}");
        }

        public void Withdraw(decimal amount)
        {
            if(balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn ${amount} from account {accountNumber}");
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }

        void ITransferable.Transfer(IBankAccount destinationAccount, decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                destinationAccount.Deposit(amount);
                Console.WriteLine($"Transferred ${amount} from account {accountNumber}");
            }
            else
            {
                Console.WriteLine("Insufficient Funds for Transfer.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Error: Interfaces can't be instantiated.
            // IBankAccount bankAccount = new IBankAccount();

            IBankAccount account1 = new CheckingAccount("12345", 1000);
            IBankAccount account2 = new CheckingAccount("67890", 2000);

            // Deposit into Account1
            account1.Deposit(1000);
            // Withdraw from Account1
            account1.Withdraw(500);
            // Transfer from Account1 to Account2
            ((ITransferable)account1).Transfer(account2 , 500);

            // Output
            Console.WriteLine($"Account {account1.AccountNumber}, Balance: {account1.Balance}");
            Console.WriteLine($"Account {account2.AccountNumber}, Balance: {account2.Balance}");
        }
    }
}
