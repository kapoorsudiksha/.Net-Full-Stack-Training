
Queue Operations:

Enqueue - To add an item to the end of the queue
Dequeue - Removes and returns the item from the beginining of the queue.
Peek - Returns the item at the beginning of the queue without revoing it.
Count - Returns the number of element in the queue.
Clear - Removes all elements from Queue.

/* *********************************** */ 

// Queue Operations:

using System.Data;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<int> queue = new Queue<int>();

            // Enque elements into the queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            // Display the element in the queue.
            foreach (var item in queue)
                Console.WriteLine(item);

            Console.WriteLine();

            // Deque Elements from the queue.
            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());

            Console.WriteLine();

            // Check if the queue is Empty of not:
            if (queue.Count == 0)
                Console.WriteLine("Queue is Empty.");

            Console.ReadKey();
        }
		
    }
}

/* ********************************************** */

// Reverse a queue using a stack.

	// Enque elements into a queue.
	// Transfer the elements from the queue to  stack
	// Transfer the elements back from the stack to the queue.
	

using System.Data;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            // Enque elements into the queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Stack<int> stack = new Stack<int>();
            // Display the element in the queue.
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            foreach (var item in stack)
                queue.Enqueue(item);

            Console.WriteLine();

            // Deque Elements from the queue.
            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());

            Console.WriteLine();

            // Check if the queue is Empty of not:
            if (queue.Count == 0)
                Console.WriteLine("Queue is Empty.");

            Console.ReadKey();
        }
    }
}

/* ********************************************** */