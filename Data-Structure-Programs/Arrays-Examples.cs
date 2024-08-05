
Array:

	10		20		30		40		50
	

	
(Unsorted)	BEST	AVERAGE		WORST
Lookup - 	O(1)	O(n)		O(n)
Insert - 	O(1)	O(1)		O(n)
Delete - 	O(1)	O(n)		O(n)


(Sorted)	BEST	AVERAGE		WORST
Lookup -
Insert -
Delete -

/* **************************************************** */


namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Single Dimensional Array:
            int[] singleDimArray = new int[5];

            // Initialize an array with Values
            int[] initializedArray = { 1, 2, 3, 4, 5 };

            // Multi-Dimensional Array
            int[,] multiDimensionalArray = new int[3,4];

            // Initialize Multi Dimensional Array
            int[,] MultiInitializedArray = { {  1, 2, 3, 4}, { 1, 2, 3, 5}, { 1, 2, 4, 5 } };

            // Jagged Array (An Array of Arrays)
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 1, 2, 3, 4 };
            jaggedArray[2] = new int[] { 1, 2, 3, 4 , 5, 6};

            // Accessing the elements
            Console.WriteLine(initializedArray[3]);
            Console.WriteLine(MultiInitializedArray[2,3]);
            Console.WriteLine(jaggedArray[2][1]);

            // Array Methods:

            // Sorting
            int[] numbers = { 5, 3, 8, 1, 2 };
            Array.Sort(numbers);
            Console.WriteLine(numbers.ToString());
            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine();

            // Searching
            int[] numbers1 = { 5, 3, 8, 1, 2 };
            int index = Array.IndexOf(numbers1, 8);
            Console.WriteLine(index);
            Console.WriteLine(numbers1[index]);

            Console.WriteLine();

            // Copying
            int[] sourceArray = { 5, 3, 8 };
            int[] destinationArray = new int[3];
            Array.Copy(sourceArray, destinationArray, sourceArray.Length);
            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine();

            // Clearing
            int[] numbers2 = { 5, 3, 8, 1, 2 };
            Array.Clear(numbers2, 1, 3);
            Console.WriteLine(string.Join(", ", numbers2));

            Console.WriteLine();

            // Resizing
            int[] numbers3 = [1, 2, 3];
            Array.Resize(ref numbers, 5);
            Console.WriteLine(string.Join(", ", numbers3));

            Console.WriteLine();

            // MultiDimensionalArray Iteration:
            int[,] MultiDimArray = { { 1, 2, 3, 4 }, { 1, 2, 3, 5 }, { 1, 2, 4, 5 } };
            for (int i = 0; i < MultiDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < MultiDimArray.GetLength(1); j++)
                {
                    Console.Write(MultiDimArray[i, j] + "\t") ;
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Jagged Array (An Array of Arrays)
            int[][] jaggedInitArray = new int[3][];
            jaggedInitArray[0] = new int[] { 1, 2 };
            jaggedInitArray[1] = new int[] { 1, 2, 3, 4 };
            jaggedInitArray[2] = new int[] { 1, 2, 3, 4, 5, 6 };
            foreach (var subArray in jaggedInitArray)
            {
                foreach (var item in subArray)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}

/* **************************************************** */

// Creating a Custom Array:

namespace coreConsoleBasicApp
{
    class CustomArray<T>
    {
        private T[] _array;
        private int _count;
        public CustomArray(int size)
        {
            if (size < 0)
                throw new ArgumentException("Size cannot be negative");
            _array = new T[size];
            _count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                    throw new IndexOutOfRangeException("Index is out of range.");
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= _array.Length)
                    throw new IndexOutOfRangeException("Index is out of range.");
                if (index >= _count)
                    _count = index + 1;
                _array[index] = value;
            }
        }

        // Property to get the length of the array
        public int Length
        {
            get { return _array.Length; }
        }

        public void Add(T item)
        {
            if (_count >= _array.Length)
                throw new InvalidOperationException("Array is Full.");
            _array[_count++] = item;
        }

        public void RemoveAt(int index)
        {
            if(index < 0 || index >= _count)
                throw new IndexOutOfRangeException("Index is out of Range.");
            for (int i = index; i < _count - 1; i++)
            {
                _array[i] = _array[i + 1];
            }
            _array[--_count] = default;
        }

        public void Clear()
        {
            for (int i = 0; i < _count; i++)
            {
                _array[i] = default;
            }
            _count = 0;
        }

        public void Print()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.Write(_array[i] + "\t");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomArray<int> customArray = new CustomArray<int>(5);

            Console.WriteLine("Length of Array : " + customArray.Length);

            // Adding Array Elements
            customArray.Add(1);
            customArray.Add(2);
            customArray.Add(3);

            // Printing Array Elements
            Console.WriteLine("Printing Array Elements: ");
            customArray.Print();

            // Remove element from Index 1:
            Console.WriteLine();
            customArray.RemoveAt(1);
            Console.WriteLine("Array Elements After Removal: ");
            customArray.Print();

            // Access the element using the indexer:
            Console.WriteLine();
            Console.WriteLine("Element at index 1 : " + customArray[10]);

            // Clear the Array: 
            Console.WriteLine();
            Console.WriteLine("Array Elements After Clearing: ");
            customArray.Print();

            Console.ReadKey();
        }
    }
}