
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