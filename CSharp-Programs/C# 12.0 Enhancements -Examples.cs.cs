
// 1. Primary Constructors for Records

using coreConsoleBasicApp;
using System.Collections;
using System.Reflection;
using System.Text;

namespace coreConsoleBasicApp
{
    // Record Initialization (Before C# 12)
    public record Person
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    // With Primary Constructor (C# 12)
    public record Person1(string FirstName, string LastName);
    public record Person2(string FirstName = "John", string LastName = "Smith");

    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Bhawna", "Gunwani");
            var person1 = new Person1("Gautam", "Bhallaa");
            var person2 = new Person2();

            Console.WriteLine(person);
            Console.WriteLine(person1);
            Console.WriteLine(person2);

            Console.ReadKey();

        }

    }
}

/* ***************************************** */

// 1. Primary Constructors for Records

using coreConsoleBasicApp;
using System.Collections;
using System.Reflection;
using System.Text;

namespace coreConsoleBasicApp
{
    // Record Initialization (Before C# 12)
    public record Person
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"First Name : {FirstName}, Last Name : {LastName}"; 
        }
    }

    // With Primary Constructor (C# 12)
    public record Person1(string FirstName, string LastName)
    {
        public override string ToString()
        {
            return $"First Name : {FirstName}, Last Name : {LastName}";
        }
    }
    public record Person2(string FirstName = "John", string LastName = "Smith")
    {
        public override string ToString()
        {
            return $"First Name : {FirstName}, Last Name : {LastName}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Bhawna", "Gunwani");
            var person1 = new Person1("Gautam", "Bhallaa");
            var person2 = new Person2();

            Console.WriteLine(person);
            Console.WriteLine(person1);
            Console.WriteLine(person2);

            Console.ReadKey();

        }

    }
}

/* ***************************************** */

// 2. Collection Literals

using coreConsoleBasicApp;
using System.Collections;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace coreConsoleBasicApp
{

    internal class Program
    {

        public static string[] GetNames() => ["Kartik", "Gautam", "Shreya"];
        static void Main(string[] args)
        {
            // Pre C# 12
            var numbers = new[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(string.Join(", ", numbers)); ;

            // C# 12 
            int[] numbers1 = [1, 2, 3, 4, 5, 6, 7];
            int[] spreadNumbers = [.. numbers, 8, 9, 10];

            IEnumerable<int> integers = [10, 20];

            string[] names = ["Kartik", "Gautam", "Shreya"];
            string[] moreNames = ["Kartik New", "Gautam New", "Shreya New"];

            bool includeMoreNames = true;

            string[] allNames = [.. names, .. includeMoreNames ? moreNames : []];

            string[] allNamesAgain = [.. names, .. includeMoreNames switch { true => moreNames = [] }];

            Dictionary<int, string> namesById = new Dictionary<int, string>()
            {
                [1] = "Bhawna",
                [2] = "Gunwani"
            };

            Dictionary<int, string> namesById1 = new()
            {
                [1] = "Bhawna",
                [2] = "Gunwani"
            };

            var namesById2 = new Dictionary<int, string>()
            {
                [1] = "Bhawna",
                [2] = "Gunwani"
            };


            Console.ReadKey();

        }

    }
}

/* ***************************************** */

// 3. Lambda Expression Improvments

using coreConsoleBasicApp;
using System;
using System.Collections;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace coreConsoleBasicApp
{
    class Employee
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }

    internal class Program
    {

        static void Main(string[] args)
        {


            var employees = new List<Employee>()
            {
                new Employee() { Name = "Gautam", Age = 23, Salary = 12000},
                new Employee() { Name = "Shreya", Age = 40, Salary = 32000},
                new Employee() { Name = "Sumit", Age = 35, Salary = 40000}
            };

            var highEarners = employees.Where(e => e.Salary > 25000);
            foreach (var employee in highEarners)
                Console.WriteLine($"{employee.Name}, {employee.Salary}"); 

            // Delegate Lambda Expression
            Func<int, int> square = x => x * x;
            var result = square(5);
            Console.WriteLine(result);

            
            Console.ReadKey();

        }

    }
}
/* ***************************************** */

// 4. Required Members

using coreConsoleBasicApp;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace coreConsoleBasicApp
{
    class User
    {
        // Required Members
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [SetsRequiredMembers]
        public User(string firstName)
        { 
            if(firstName == null) throw new ArgumentNullException(nameof(firstName));
            FirstName = firstName;
        }
    }
    class Person
    {
        // Required Members
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        // Optional Member
        public int Age { get; set; }

        [SetsRequiredMembers]
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() => $"Welcome {FirstName} {LastName}!";
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            var person1 = new Person("John", "Smith")
            {
                Age = 30
            };

            var user1 = new User("Kartik")
            {
                LastName = "Sharma"
            };

            Console.WriteLine(person1);

            Console.ReadKey();

        }

    }
}

/* ***************************************** */

// 5. Improved Pattern Matching

using coreConsoleBasicApp;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace coreConsoleBasicApp
{
    class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }

    internal class Program
    {
        static void PrintValues(int[] items)
        {
            switch (items)
            {
                case [1, 2, 3]:
                    Console.WriteLine("List Contains 1,2 and 3");
                    break;

                case [1, .., 3]:
                    Console.WriteLine("List starts with 1 and ends with 3");
                    break;

                case [.., 3]:
                    Console.WriteLine("List ends with 3");
                    break;

                case []:
                    Console.WriteLine("List is Empty.");
                    break;

                default:
                    Console.WriteLine("List doesnt match any pattern.");
                    break;
            }
        }

        static void Welcome(Person person)
        {
            switch(person)
            {
                case { FirstName: "John", LastName: "Smith" }:
                    Console.WriteLine("Welcome John Smith!");
                    break;

                case { FirstName: "John" }:
                    Console.WriteLine("Welcome John!");
                    break;

                case { LastName: "Smith" }:
                    Console.WriteLine("Welcome Smith!");
                    break;

                default:
                    Console.WriteLine("Welcome Annonymous!");
                    break;
            }
        }

        static void ProcessTuple((int, string) tuple)
        {
            switch(tuple)
            {
                case (1, "One"):
                    Console.WriteLine("Matched Tuple (1, 'One')");
                    break;

                case (1, _):
                    Console.WriteLine("Matched Tuple with First Item 1");
                    break;

                case (_, "One"):
                    Console.WriteLine("Matchec Tuple ending with 'One'");
                    break;

                default:
                    Console.WriteLine("No Matched Tuple");
                    break;
            }
        }


        static void Main(string[] args)
        {
            
            PrintValues(new[] { 1, 2, 3 });
            PrintValues(new[] { 1, 4, 3 });
            PrintValues(new[] { 2 ,3 });
            PrintValues(Array.Empty<int>());
            PrintValues(new[] { 4,5,6 });

            Console.WriteLine();

            Welcome(new Person() { FirstName = "John", LastName = "Smith" });
            Welcome(new Person() { FirstName = "John" });
            Welcome(new Person() { LastName = "Smith" });
            Welcome(new Person() { FirstName = "Alex" });

            Console.WriteLine();

            ProcessTuple((1, "One"));
            ProcessTuple((1, "Two"));
            ProcessTuple((2, "One"));
            ProcessTuple((2, "Two"));

            Console.ReadKey();

        }

    }
}

/* ***************************************** */

// 6. Default Interface Implementation

using coreConsoleBasicApp;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace coreConsoleBasicApp
{

    public interface ILogger
    {
        // Default Implementation for Logging
        void Log(string message)
        {
            Console.WriteLine($"Log Message: {message}");
        }
        // Abstract Method
        void LogError(string errorMessage);
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Console Log Message: {message}");
        }
        public void LogError(string errorMessage)
        {
            Console.WriteLine($"Console Log Error: {errorMessage}");
        }
    }

    class FileLogger : ILogger
    {
        public void LogError(string errorMessage)
        {
            Console.WriteLine($"File Log Error: {errorMessage}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            ILogger fileLogger = new FileLogger();

            consoleLogger.Log("This is a log message");
            consoleLogger.LogError("This is an console error message");

            fileLogger.Log("This is a log message");
            fileLogger.LogError("This is an file error message");


            Console.ReadKey();

        }

    }
}

/* ***************************************** */

// 7. Nullable Reference Types Enhancements

// Nullable Attributes, Nullable Static Values, Nullable Values
// NullReferenceException

using coreConsoleBasicApp;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;



namespace coreConsoleBasicApp
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
    public class NotNullAttribute : Attribute { }
    class Person
    {
        [NotNull]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Person([NotNull]string? firstName, string? lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class ApplicationSettings
    {
        public string? ConnectionString { get; set; } = null;
        public string? RequiredApiSettting { get; set; } = "Default";

        public ApplicationSettings(string? connectionString, string requiredApiSettting)
        {
            ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            RequiredApiSettting = requiredApiSettting;
        }
    }

    internal class Program
    {
        public static string? GetName()
        {
            // This function might return null
            return "John";
        }

        static void Main(string[] args)
        {
            string? name = GetName();
            if(name != null)
            {
                // Static Analysis to recognize that 'name' is not null here.
                Console.WriteLine(name.ToUpper());
            }

            var settings = new ApplicationSettings("ConnectionString", "ImportantSettring");
            Console.WriteLine(settings.ConnectionString);
            Console.WriteLine(settings.RequiredApiSettting);

            settings.ConnectionString = null;

            var invalidSettings = new ApplicationSettings(null, "ImportantSetting");

            Console.ReadKey();

        }

    }
}

/* ***************************************** */

// 8. Interpolation Enhancements.

using coreConsoleBasicApp;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;



namespace coreConsoleBasicApp
{

    internal class Program
    {

        static void Main(string[] args)
        {

            bool isPremiumUser = true;
            string username = "gautam";

            // Conditional Interpolation
            string message = $"User: {username}, Status: {(isPremiumUser ? "Premium" : "Standard")}";
            Console.WriteLine(message);

            double price = 1234.56789;
            int quantity = 99;

            string formattedString = $"Price: {price:C2}, Quantity: {quantity:D4}";
            Console.WriteLine(formattedString);


        }

    }
}

/* ***************************************** */