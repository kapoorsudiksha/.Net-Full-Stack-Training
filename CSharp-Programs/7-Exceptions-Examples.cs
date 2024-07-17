
When we write an execute our code in .NET Framework then there is a possibility of two types of error occurances:

	- Compilation Errors
		- Syntactical Errors
			- When you miss-spelled the keywords
			- When you ommit the semi-colon and so on.
		- Sementic Errors
			- When expressions are valid.
			- Also knowns as Expressional Errors
	- Logical Errors 
			- When you don't get expected output but also don't get errors.
	- RunTime Errors
			- When the occurred at the execution time or runtime.
			- This may occur due to various reasons such as:
				- Wrong data into the variable
				- trying to open a file with no permission,
				- trying to connect to the database with wrong credentials and so on.
				
-- To handle runtime errors or Exceptions, we use Exception Handling:

Try-Catch Block:

	- try - enclosed the code that might throw an exception.
	- catch - to specify what happends when an exception is thrown.
	- finally - to execute cleanup code, regardless of whether an expection was thrown or not.
	
/* ****************************************************** */	

/* Demonstration: Exception Raised */
	
namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 100, num2 = 0, result = 0;

            result = num1 / num2;
            Console.WriteLine("Result : " + result);

            Console.ReadKey();
        }
    }
}

/* ****************************************************** */

/* Demonstration: Handling Exceptions Try, Catch and Finally Block */

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter First Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            try
            {
                result = num1 / num2;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception is thrown.");
                Console.WriteLine($"Exception: {ex.ToString()}");
                Console.WriteLine($"Exception Message: {ex.Message}");
                Console.WriteLine($"Exception Source: {ex.Source}");
                Console.WriteLine($"Exception StackTrace: {ex.StackTrace}");
                Console.WriteLine($"Exception HelpLink: {ex.HelpLink}");
            }
            finally
            {
                Console.WriteLine("Result : " + result);
            }
            
            Console.ReadKey();
        }
    }
}


/* ****************************************************** */

/* Demonstration: Handling Exceptions with Multiple Catch Block */

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter First Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            try
            {
                result = num1 / num2;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Exception is thrown - FormatException");
                Console.WriteLine($"Exception Message: {ex.Message}");  
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Exception is thrown - IndexOutOfRangeException");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception is thrown.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Result : " + result);
            }
            
            Console.ReadKey();
        }
    }
}

/* ****************************************************** */

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter First Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            try
            {
                result = num1 / num2;
            }
            finally
            {
                Console.WriteLine("Result : " + result);
            }
            
            Console.ReadKey();
        }
    }
}


/* ****************************************************** */

/* Demonstration: Handling Exception in Online Banking System Application: */

namespace coreConsoleBasicApp
{


    public class BankAccount
    {
        public string accountNumber;
        public decimal balance;

        public BankAccount(string accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            balance += amount;
            Console.WriteLine($"Deposited ${amount} into account {accountNumber}");
        }

        public void Withdraw(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            balance -= amount;
            Console.WriteLine($"Withdrawn ${amount} from account {accountNumber}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("12345", 0);
            try
            {
                account.Deposit(1000);
                account.Withdraw(500);
                account.Withdraw(800); // This will throw an exception.

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument Exception: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Invalid Operation Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Exception Occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"Account: {account.accountNumber}, Balance: {account.balance}");
            }

        }
    }
}

/* ****************************************************** */

/* Demonstration: Custom Exception Handling: */

namespace coreConsoleBasicApp
{

    // Custom Exception Class:

    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException() { }
        public InsufficientFundsException(string message) : base(message) { }
        public InsufficientFundsException(string message, Exception innerException) : base(message, innerException) { }

    }

    public class BankAccount
    {
        public string accountNumber;
        public decimal balance;

        public BankAccount(string accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            balance += amount;
            Console.WriteLine($"Deposited ${amount} into account {accountNumber}");
        }

        public void Withdraw(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > balance)
            {
                throw new InsufficientFundsException("Insufficient Funds");
            }
            balance -= amount;
            Console.WriteLine($"Withdrawn ${amount} from account {accountNumber}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("12345", 0);
            try
            {
                account.Deposit(1000);
                account.Withdraw(500);
                account.Withdraw(800); // This will throw an exception.

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument Exception: {ex.Message}");
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Insufficient Funds Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Exception Occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"Account: {account.accountNumber}, Balance: {account.balance}");
            }

        }
    }
}

/* ****************************************************** */
