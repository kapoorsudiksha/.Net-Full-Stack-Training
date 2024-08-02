
Memory Management in C#:

	1. Automatic Garbage Collection (Discussed)
	2. Managed vs.Unmanaged Memory (checked and Unchecked Keyword) - Pending
	3. Heap and Stack (Discussed)
	4. Finalizers and IDisposible
	
/* ***************************************************** */

Heap and Stack:

Heap 

	- Memory Used for dynamically allocated objects. 
	- The garbage collector manages this memory. 
	- The GC periodically reclaims memory used by object that are no longer accessibly.
	- Objects are created and stored in the heap when we use the 'new' keyword or when memory is allocated dynamically.

Stack 
	
	- Memoery used for static data like local variables and method call frames. 
	- This memory is managed autamically and has a LIFO structure (Last In, First Out).
	
/* ***************************************************** */

// Stack and Heap Memory:

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        // Class (Reference Type) - Allocated on the heap.
        class Person
        {
            public string? Name { get; set; }
            public Person(string? name)
            {
                this.Name = name; 
            }
        
        }

        static void SomeMethod()
        {
            int x = 10; 
            int y = x;
            //...
        }

        static void Main(string[] args)
        {

            // Stack Allocation 
            int age = 30; // 'age' is a value type, stored on the stack
            bool isValue = true;

            SomeMethod();   // Method Call Frame

            // Heap Allocation
            Person person1 = new Person("Alice");    // 'person' is a reference type, stored on the heap.
            Person person2 = person1;


            Console.ReadKey();

        }
    }
}

/* ***************************************************** */

// Checked and Unchecked Keywords:

	- In C#, we can manage memory through Managed and Unmanaged Code.
	- .NET Runtime Garbage Collector (GC) helps to manage memory for managed code (objects).
	- To manage the code, we use checked or unchecked keyword (context) are used to control whether ooberflow checked performed or not.
	
	Checked Context - Enables Overflow Checking
	Unchecked Context - Disables Overflow Checking
	
/* ***************************************************** */	
	
// Checked Keyword (Context):

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 2_000_000_000;    // 2 Billion
            int deposit = 1_000_000_000;    //  1 Billion

            try
            {
                int newBalance = checked(balance + deposit);
                Console.WriteLine($"New Balance: {newBalance}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Overflow Exception Detected: " + ex.Message);
            }
            

            // Console.WriteLine(int.MaxValue);    // 2147483647
            Console.ReadKey();
        }
    }
}

/* ***************************************************** */	

// Unchecked Keyword (Context):

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 2_000_000_000;    // 2 Billion
            int deposit = 1_000_000_000;    //  1 Billion

            try
            {
                int newBalance = unchecked(balance + deposit);
                Console.WriteLine($"New Balance: {newBalance}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Overflow Exception Detected: " + ex.Message);
            }
            

            // Console.WriteLine(int.MaxValue);    // 2147483647
            Console.ReadKey();
        }
    }
}

/* ***************************************************** */

Generation 0

	- Short-Lived Objects
	- Frequent Collection
	- Efficient - Collection process is fast because it takes only a small portion of heap.
	- Example: Small Objects, Objects that are used in methods, Temporary Variables

Generation 1

	- Buffer Generation - Servers a buffer b/w SL objects in Gen 0 and long lived objets in Gen 2.
	-Intermdiate Lifetime - Gen 1 is collected less frequently than Gen 0.
	- Examples, Objects that survive GC cycles but are not used for application lifetime.

Generation 2

	- Long lived objects
	- Least Frequently collected.
	- Examples, Static objects, objetcs tied to the application lifecycles

/* ***************************************************** */

// How GC cleans up the memory using IDisposable

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    public class ClassA : IDisposable
    {
        // To detect the redundent calls
        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // dispose managed objects
                }
                // free unmanaged resources and override a finalizer
                // set larget fields to null
                disposedValue = true;
            }
        }

        ~ClassA() { Dispose(false); }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
    public class ClassB 
    {
        // To detect the redundent calls
        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // dispose managed objects
                }
                // free unmanaged resources and override a finalizer
                // set larget fields to null
                disposedValue = true;
            }
        }

        ~ClassB() { Dispose(false); }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
    public class ClassC 
    {
        // To detect the redundent calls
        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // dispose managed objects
                }
                // free unmanaged resources and override a finalizer
                // set larget fields to null
                disposedValue = true;
            }
        }

        ~ClassC() { Dispose(false); }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for(int i = 0; i <= 1000000;i++)
            {
                ClassA classA = new ClassA();
                classA.Dispose();
                ClassB classB = new ClassB();
                classB.Dispose();
                ClassC classC = new ClassC();
                classC.Dispose();
            }

            Console.ReadKey();
        }
    }
}

/* ***************************************************** */







