
Stack:

Push - Adds an item to the top
Pop - Removes and returns the item at the top
Peek - Returns the item at the top of the stack without removing it.
Count - Returns the number of itesm in the stack.
Contains - Checks if a specific item exist in the stack.
Clear - Removes all items from the stack.

/* ******************************************************* */

// Stack Operations with Stack Class:

using System.Data;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            // Push the Items:
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine("Stack After Pushing the items: ");
            foreach (var item in stack)
                Console.Write(item + "\t");

            Console.WriteLine();

            Console.WriteLine($"Top Item: {stack.Peek()}");

            // Popping the item from stack.
            stack.Pop();

            Console.WriteLine("Stack After Popping the items: ");
            foreach (var item in stack)
                Console.Write(item + "\t");

            Console.WriteLine();

            // check if the stack contains the specific item:
            Console.WriteLine($"stack Containts 2 : {stack.Contains(2)}");
            Console.WriteLine($"stack Containts 2 : {stack.Contains(20)}");

            // Count and Clear the Stack
            Console.WriteLine("Stack count before clear : " + stack.Count);
            stack.Clear();
            Console.WriteLine("Stack count after clear : " + stack.Count);

            Console.ReadKey();

        }
    }
}

/* ******************************************************* */

// Building a Custom Array Class:


using System.Data;

namespace coreConsoleBasicApp
{
    public class Stack<T>
    {
        private T[] _array;
        private int _top;
        private const int InitialCapacity = 10; 

        public Stack() 
        {
            _array = new T[InitialCapacity];
            _top = -1;
        }

        // Push - To add an item to the top of the stack
        public void Push(T item)
        {
            if (_top == _array.Length - 1)
            {
                // Stack is full.
                // Resize the Array
            }
            _array[++_top] = item;
        }

        // Pop - To removes and returns the items at the top of the stack
        public T Pop()
        {
            if(IsEmpty())
                throw new InvalidOperationException("Stack is Empty.");

            T item = _array[_top];
            _array[_top--] = default(T);
            return item;
        }

        // Peek
        public T Peek()
        {
            if (_top == -1)
                throw new InvalidOperationException("Empty.");

            return _array[_top];
        }


        // IsEmpty
        public bool IsEmpty()
        {
            return _top == -1;
        }

        // Count
        public int Count()
        {
            return _top + 1;
        }

        // Resize
        public void ResizeArry()
        {
            /*Console.WriteLine(" Array sizeis : " + _array.Length);
            Array.Resize(ref _array, _array.Length * 2);
            Console.WriteLine("New Array sizeis : " + _array.Length);*/

            int newSize = _array.Length * 2;
            T[] newArray = new T[newSize];
            Array.Copy(_array, 0, newArray, 0, _array.Length);
            _array = newArray;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Popped Item is : " + stack.Pop());
            
            Console.WriteLine("Peeking Item is " + stack.Peek());

            Console.WriteLine("No of Items : " + stack.Count());

            if(stack.IsEmpty())
                Console.WriteLine("Stack is Empty.");
            else
                Console.WriteLine("Stack is not Empty.");

            // Clear the Stack
            while(!stack.IsEmpty())
                Console.WriteLine(stack.Pop());

            // Test Empty Stack.
            try
            {
                stack.Peek();
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine("Exception : " + e.Message);
            }

            Console.ReadKey();
        }
    }
}

/* ******************************************************* */

// Reverse a string using Stack:


using System.Data;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World!";
            string reversed = ReversString(input);
            Console.WriteLine("Original String : " + input);
            Console.WriteLine("Reversed String : " + reversed);

            Console.ReadKey();
        }

        private static string ReversString(string input)
        {
            Stack<char> chars = new Stack<char>();
            foreach (var ch in input)
                chars.Push(ch);

            char[] reversedArray = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
                reversedArray[i] = chars.Pop();

            return new string(reversedArray);
        }
    }
} 














