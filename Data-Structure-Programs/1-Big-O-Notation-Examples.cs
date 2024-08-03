
// Constant Time (Constant Big O Notation) - O(1)

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void log(int[] numbers)
        {
            // O(1) + O(1)
            // O(2)
            // Equivalent to O(1) Constant Big O Notation

            // O(1)
            Console.WriteLine(numbers[0]);
            // O(1)
            Console.WriteLine(numbers[1]);
        }
        static void Main(string[] args)
        {
            log([1, 2, 3, 4, 5]);
        }
    }
}

/* ************************************************ */

// Linear Time (Linear Big O Notation) - O(n)

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void log(int[] numbers)
        {
            // O(n) + O(1) + O(1) 
            // O(n) + O(2)
            // O(n) Linear Time (Linear Notation)

            Console.WriteLine();    // O(1)
            foreach (int number in numbers) // O(n)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();    // O(1)
        }

        static void print(int[] numbers)
        {
            // O(n) + O(n)
            // O(n) Linear Time (Linear Notation)

            foreach (int number in numbers) // O(n)
            {
                Console.WriteLine(number);
            }

            foreach (int number in numbers) // O(n)
            {
                Console.WriteLine(number);
            }

        }
        static void Main(string[] args)
        {
            log([1, 2, 3, 4, 5]);
            log([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        }
    }
}

/* ************************************************ */

// Linear Time (Linear Big O Notation) - O(n)

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void log(int[] numbers)
        {
            // O(n * n) => O(n^2)
            // O(n^2) Quadratic Time (Quadratic Notation)

            foreach (var first in numbers) // O(n)
            {
                foreach (var second in numbers) // O(n)
                {
                    Console.WriteLine(first + ", " + second);
                }
            }
        }

        static void print(int[] numbers)
        {
            // O(n + n^2)
            // O(n^2) - Quadratic Time

            foreach (var number in numbers) // O(n)
            {
                Console.WriteLine(number);
            }

            foreach (var first in numbers) // O(n)
            {
                foreach (var second in numbers) // O(n)
                {
                    Console.WriteLine(first + ", " + second);
                }
            }
        }


        static void Main(string[] args)
        {
            log([1, 2, 3, 4, 5]);
            log([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        }
    }
}

/* ************************************************ */

// Logarithmic Time (Logarithmic Big O Notation) - O(log n)

// Means, Do the half of the problem and solve.

// Examples - Binary Search,Balance Binary Search Trees, Heap OPerations

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static int BinarySearch(int[] sortedArray, int target)
        {
            // O(log n) - Logarithmic Notation

            int left = 0;
            int right = sortedArray.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (sortedArray[mid] == target)
                    return mid;
                else if (sortedArray[mid] < target)
                    left = mid + 1;
                else 
                    right = mid - 1;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(BinarySearch([1, 2, 3, 4, 5, 6], 3));
            Console.WriteLine(BinarySearch([1, 2, 3, 4, 5, 6], 5));
            Console.WriteLine(BinarySearch([1, 2, 3, 4, 5, 6], 8));

            Console.ReadKey();
        }
    }
}

/* ************************************************ */

// Exponential Time (Exponential Big O Notation) - O(log n)

// Examples - Recursive Calculation, Power Set Generation, Naive Approach (N-Queen Problem)

// Naive Recursive Approach has exponential Time COmplexity because the function makes two recursive calls for each number at least.


namespace coreConsoleBasicApp
{
    internal class Program
    {
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static int Factorial(int n)
        {
            if (n == 0)
                return 1; // O! = 1
            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine($"Fibonacci of {n} is {Fibonacci(n)}");

            Console.WriteLine($"Factorial of {n} is {Factorial(n)}");


            Console.ReadKey();
        }
    }
}

/* ************************************************ */

// O(n log n) - Divide and Conquar Approach

// Means, Problem size is divided into smaller subproblems and results are combined.

// Example, Merge Sort

	// Function 1 - To sort the array
	// Function 2 - To Combine two sorted arrays