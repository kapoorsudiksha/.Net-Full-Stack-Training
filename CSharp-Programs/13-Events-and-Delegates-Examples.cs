
Events and Delegates:

Events 

	- are the notifications.
	- provides a way to trigger notifications.
	- To notify the events we use Delegates, EventArgs and EventHandlers.
	
Delegates:

	- A Type Safe Function Pointer.
	- They hold the reference of a method or function and then call the method for execution.
	- Delegate Types:
	
		- Single Cast Delegate (Delegate with Single Method)
		- Multi Cast Delegate (Delegate with Multiple Methods)
	
	
/* ************************************************************** */

// Single Cast Delegate

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        // Declaring a Delegate
        public delegate void MyDelegate(string message);

        public static void PrintMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        public static void PrintUpperCaseMessage(string message)
        {
            Console.WriteLine("Message: " + message.ToUpper());
        }

        public static void PrintNumber(int number)
        {
            Console.WriteLine("Number: " + number);
        }

        static void Main(string[] args)
        {

            // Create a delegate instance pointing to the PrintMessage method
            MyDelegate del1 = new MyDelegate(Program.PrintMessage);

            // Invoke the delegate
            del1("Hello, PrintMessage!");

            // change the delegate to point to a different method
            del1 = Program.PrintUpperCaseMessage;
            del1("Hello, PrintUpperCaseMessage!");

            Console.ReadKey();
        }
    }
}

/* ************************************************************** */

// Multi Cast Delegate

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        // Declaring a Delegate
        public delegate void MyDelegate(string message);

        public static void PrintMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        public static void PrintUpperCaseMessage(string message)
        {
            Console.WriteLine("Message: " + message.ToUpper());
        }

        public static void PrintLowerCaseMessage(string message)
        {
            Console.WriteLine("Message: " + message.ToLower());
        }


        static void Main(string[] args)
        {

            MyDelegate? del = Program.PrintMessage;
            del += Program.PrintUpperCaseMessage;   // Add another method to the delegate.

            del("Hello Everyone!");


            del -= Program.PrintMessage;            // Remove an existing method from the delegate
            del -= Program.PrintUpperCaseMessage;   // Remove an existing method from the delegate

            del += Program.PrintLowerCaseMessage;   // Add another method to the delegate.

            del("Hello Folks!");

            Console.ReadKey();
        }
    }
}

/* ************************************************************** */

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        // Declaring a Delegate
        public delegate void MyDelegate(string message);
        public delegate int MathOperation(int num1, int num2);

        public static void PrintMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        public static void PrintUpperCaseMessage(string message)
        {
            Console.WriteLine("Message: " + message.ToUpper());
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2; 
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static void PrintLowerCaseMessage(string message)
        {
            Console.WriteLine("Message: " + message.ToLower());
        }


        static void Main(string[] args)
        {

            MyDelegate? del = Program.PrintMessage;
            del += Program.PrintUpperCaseMessage;   // Add another method to the delegate.
            del("Hello Everyone!");

            MathOperation operation = Program.Add;
            Console.WriteLine("Addition : " + operation(100,200));
            operation = Program.Multiply;
            Console.WriteLine("Multiplication : " + operation(100, 200));

            Console.ReadKey();
        }
    }
}

/* ************************************************************** */

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        public delegate double AdditionOneDelegate(int num1, float num2, double num3);
        public delegate void AdditionTwoDelegate(int num1, float num2, double num3);
        public delegate bool CheckLengthDelegate(string name);

        public static double AddNumberOne(int num1, float num2, double num3)
        {
            return num1 + num2 + num3;
        }

        public static void AddNumberTwo(int num1, float num2, double num3)
        {
            Console.WriteLine(num1 + num2 + num3);
        }

        public static bool CheckLength(string name)
        {
            if (name.Length > 5)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            AdditionOneDelegate obj1 = new AdditionOneDelegate(AddNumberOne);
            double result = obj1.Invoke(100, 210.25F, 320.45);
            Console.WriteLine(result);

            AdditionTwoDelegate obj2 = new AdditionTwoDelegate(AddNumberTwo);
            obj2.Invoke(1000, 2100.25F, 3200.45);

            CheckLengthDelegate obj3 = new CheckLengthDelegate(CheckLength);
            bool status = obj3.Invoke("Bhawna Gunwani");
            Console.WriteLine(status);

            Console.ReadKey();
        }
    }
}

/* ************************************************************** */

Generic Delegate: Func, Action, Predicate

Func: Takes one or more input parameters and return one out parameter. where the last parameter is the out parameter as it returns the value. This can take upto 16 parameters of different or same DT. But must return one type. Thus, Return type os mandatory.

Action: Takes one or more input parameters but returns nothing. Again this can take upto 16 parameters of different or same DT.

Predicate: This delegate is used to verify certain criteria or a condition of the method and returns the output as Boolean. It takes one parameter and alwasy return the value of the boolean type.


/* ************************************************************** */

// Generic Delegate:

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    internal class Program
    {

        // Func Generic Delegate
        public static double AddNumberOne(int num1, float num2, double num3)
        {
            return num1 + num2 + num3;
        }

        // Action Generic Delegate
        public static void AddNumberTwo(int num1, float num2, double num3)
        {
            Console.WriteLine(num1 + num2 + num3);
        }

        // Predicate Generic Delegate
        public static bool CheckLength(string name)
        {
            if (name.Length > 5)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {

            // Func Generic Delegate:
            Func<int, float, double, double> obj1 = new Func<int, float, double, double>(AddNumberOne);
            double result = obj1.Invoke(100, 210.25F, 320.45);
            Console.WriteLine(result);

            // Action Generic Delegate:
            Action<int, float, double> obj2 = new Action<int, float, double> (AddNumberTwo);
            obj2.Invoke(1000, 2100.25F, 3200.45);

            // Predicate Generic Delegate:
            Predicate<string> obj3 = new Predicate<string>(CheckLength);
            bool status = obj3.Invoke("Bhawna Gunwani");
            Console.WriteLine(status);

            Console.ReadKey();
        }
    }
}

/* ************************************************************** */

// Generic Delegate with Lambda Expression:

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    internal class Program
    {

        // Action Generic Delegate
        public static void AddNumberTwo(int num1, float num2, double num3)
        {
            Console.WriteLine(num1 + num2 + num3);
        }

        // Predicate Generic Delegate
        public static bool CheckLength(string name)
        {
            if (name.Length > 5)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {

            // Func Generic Delegate:
            Func<int, float, double, double> obj1 = (num1, num2, num3) =>
            {
                return num1 + num2 + num3;
            };
            double result = obj1.Invoke(100, 210.25F, 320.45);
            Console.WriteLine(result);

            // Action Generic Delegate:
            Action<int, float, double> obj2 = new Action<int, float, double> (AddNumberTwo);
            obj2.Invoke(1000, 2100.25F, 3200.45);

            // Predicate Generic Delegate:
            Predicate<string> obj3 = new Predicate<string>(CheckLength);
            bool status = obj3.Invoke("Bhawna Gunwani");
            Console.WriteLine(status);

            Console.ReadKey();
        }
    }
}

/* ************************************************************** */

// Real Time Example of Delegates

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    public delegate bool EligibleToPromotion(Employee EmployeeToPromotion);
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List<Employee> employees, EligibleToPromotion IsEmployeeEligible)
        {
            foreach (Employee employee in employees)
            {
                if (IsEmployeeEligible(employee))
                {
                    Console.WriteLine($"Employee {employee.Name} Promoted.");
                }
            }
        }
    }

    internal class Program
    {

        public static bool Promote(Employee employee) 
        {
            if (employee.Salary > 15000)
                return true;
            return false;
        }

        static void Main(string[] args)
        {

            Employee emp1 = new Employee() { Id = 1, Name = "King Kochhar", Gender = "Male", Experience = 6, Salary = 10000 };
            Employee emp2 = new Employee() { Id = 2, Name = "John Smith", Gender = "Male", Experience = 5, Salary = 20000 };
            Employee emp3 = new Employee() { Id = 3, Name = "Roger Lee", Gender = "Male", Experience = 7, Salary = 30000 };

            List<Employee> employees = new List<Employee>();
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            EligibleToPromotion eligibleToPromotion = new EligibleToPromotion(Program.Promote);
            Employee.PromoteEmployee(employees, eligibleToPromotion);

            Console.ReadKey();
        }
    }
}

/* ************************************************************** */

// Real Time Example of Delegates with Lambda Expressions

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    public delegate bool EligibleToPromotion(Employee EmployeeToPromotion);
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List<Employee> employees, EligibleToPromotion IsEmployeeEligible)
        {
            foreach (Employee employee in employees)
            {
                if (IsEmployeeEligible(employee))
                {
                    Console.WriteLine($"Employee {employee.Name} Promoted.");
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee() { Id = 1, Name = "King Kochhar", Gender = "Male", Experience = 6, Salary = 10000 };
            Employee emp2 = new Employee() { Id = 2, Name = "John Smith", Gender = "Male", Experience = 5, Salary = 20000 };
            Employee emp3 = new Employee() { Id = 3, Name = "Roger Lee", Gender = "Male", Experience = 7, Salary = 30000 };

            List<Employee> employees = new List<Employee>();
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            Employee.PromoteEmployee(employees, x => x.Salary > 15000);

            Console.ReadKey();
        }
    }
}

/* ************************************************************** */

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    public delegate void TemeratureChangedEventHandler(object sender, TemperatureChangedEventArgs e);
    public class TemperatureChangedEventArgs : EventArgs
    {
        public int NewTemperature { get; }
        public TemperatureChangedEventArgs(int newTemperature)
        {
            NewTemperature = newTemperature;
        }
    }

    // Publisher Class - Will Raise the event when the temperature changes

    public class TemperatureSenor
    {
        // Define an eent based on the delegate
        public event TemeratureChangedEventHandler TemeratureChanged;

        private int _temperature;

        public int Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    OnTemperatureChanged(new TemperatureChangedEventArgs(_temperature));

                }
            }
        }

        // Virtual Method to allow derived classes to override
        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            TemeratureChanged.Invoke(this, e);
        }

    }

    // Create Subscriber Class - This class will subscribe to the TemperatureChanged event and handle it.

    public class TemeratureDisplay
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Temperature Display: The New Temperature is {e.NewTemperature}");
        }
    }

    public class TemperatureLogger
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Temperature Logger: The New Temperature is {e.NewTemperature}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of the publisher and subscribers
            TemperatureSenor sensor = new TemperatureSenor();
            TemeratureDisplay display = new TemeratureDisplay();
            TemperatureLogger logger = new TemperatureLogger();

            // Subscribe the event handlers to the event.
            sensor.TemeratureChanged += display.OnTemperatureChanged;
            sensor.TemeratureChanged += logger.OnTemperatureChanged;

            // Change the temperature
            sensor.Temperature = 25;    // This will trigger both the event handlers

            // Change the temperature again
            sensor.Temperature = 30;    // This will trigger both the event handlers


            Console.ReadKey();
        }
    }
}