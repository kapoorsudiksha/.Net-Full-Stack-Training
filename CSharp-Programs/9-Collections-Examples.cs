
Collections in C#: 

	- Collection is a group of records as a single unit.
	- Collections in C# are a set of predefined classes.
	- These classes are present in System.Collections namespace.
	- The Collections are reusable, more powerful and more effiecint.
	- Collections
		- Size can be increased dynamically.
		- We can insert an element at any position
		- It also provides the facility to remove the element from any position.

Collections:
	- Indexed Based
		Array and List
	- Key Value Pair 
		HashTable and SortedList
	- Prioritized Collection
		Stack(LIFO) and Queue(FIFO)
	- Specialized Collection
		String Collection and Hybrid Dictionaries
		
Types of Collections (Ways to work with COllections):

	- System.Collections Classes (Non-Generic Collections)
	
		ArrayList, Stack, Queue, Hashtable, SortedList
	
	- System.Collections.Generic Classes (Generic Collections)
	
		List<T>, Stack<T>, Queue<T>, HashSet<T>, Dictionary<T>, SortedList<T>, SortedSet<T>, SortedDictionary<T>, LinkedList<T>
	
	- System.Collections.Concurrent Classes
	
		BlockingCollection<T>, ConcurrentBag<T>, ConcurrentStack<T>, ConcurrentQueue<T>, ConcurrentDictionary<TKey, TValue>
		
/* ***************************************************************************************** */

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Arrays");

            // Declare and Initialize the Array
            // int[] numbersArray = new int[] { 1, 2, 3, 4 };
            int[] numbersArray = new int[4];
            numbersArray[0] = 1;
            numbersArray[1] = 2;
            numbersArray[2] = 3;
            numbersArray[3] = 4;

            // Accessing and Modifying elements in the Array
            Console.WriteLine($"Element at index 0 : {numbersArray[0]}");
            numbersArray[1] = 100;
            Console.WriteLine($"Element at index 1 : {numbersArray[1]}");

            // Iterate over the Array:
            Console.WriteLine("Iterating Over the Array");
            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.WriteLine(numbersArray[i]);
            }

            // Iterate over the Array:
            Console.WriteLine("Iterating Over the Array");
            foreach(int num in numbersArray)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();

        }
    }
}

/* ***************************************************************************************** */

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberofStudents = 5;

            int[] studentScores = new int[numberofStudents];

            Console.WriteLine("Enter the scores of 5 students: ");
            for (int i = 0; i < numberofStudents; i++)
            {
                Console.Write($"Score of Student {i + 1}: ");
                studentScores[i] = Convert.ToInt32(Console.ReadLine());
            }

            int totalScore = 0;
            for (int i = 0; i < numberofStudents; i++)
            {
                totalScore += studentScores[i];
            }
            double averageScore = (double) totalScore / numberofStudents;
            Console.WriteLine($"The Average score is {averageScore}");

            int highestScore = studentScores[0];
            int lowestScore = studentScores[0];
            for (int i = 0; i < numberofStudents; i++)
            {
                if (studentScores[i] > highestScore)
                {
                    highestScore = studentScores[i];
                }
                if (studentScores[i] < lowestScore)
                {
                    lowestScore = studentScores[i];
                }
            }

            Console.WriteLine($"The highest score is {highestScore}");
            Console.WriteLine($"The Lowest score is {lowestScore}");

            Console.ReadKey();

        }
    }
}

/* ***************************************************************************************** */

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initializing the List
            List<string> list = new List<string>() { "King", "Kochhar", "Sarah", "Bowling" };
            
            // Declaring and Assigning the List
            // List<string> list = new List<string>();
            list[2] = "Bhawna 2";
            list[3] = "Gautam";

            // Accessing and Modifying the elements in the list:
            Console.WriteLine($"Element at index 0 : {list[0]}");
            list[1] = "Bhawna 1";
            Console.WriteLine($"Element at index 0 : {list[1]}");

            // Adding and Removing Elements:
            list.Add("Kartik");

            //list.Remove("Bhawna 1");
            // list.RemoveAt(2);
            

            Console.WriteLine();

            // Iterate Over the List:
            Console.WriteLine("Iterating Over the List:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Number of Elements in List: {list.Count}");

            Console.ReadKey();

        }
    }
}

/* ***************************************************************************************** */

namespace coreConsoleBasicApp
{
    internal class Program
    {

        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Employee(int id, string name)
            {
                this.Id = id;
                this.Name = name;
            }
            public override string ToString()
            {
                return $"Id: {this.Id}, Name: {this.Name}";
            }
        }

        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();

            // Adding the Employees:
            employees.Add(new Employee(1, "Alice"));
            employees.Add(new Employee(2, "Bob"));
            employees.Add(new Employee(3, "Charlie"));
            employees.Add(new Employee(3, "Dennis"));
            employees.Add(new Employee(3, "David"));

            // Displaying all Employees
            Console.WriteLine("All Employees");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

            // Searching for an employee
            int searchId = 3;
            Employee? foundEmployee = employees.Find(emp => emp.Id == searchId);
            if (foundEmployee != null)
            {
                Console.WriteLine($"Employee found with Id {searchId}: {foundEmployee}");
            }
            else
            {
                Console.WriteLine($"No employee found with Id {searchId}");
            }

            // Removing an element BY Id
            int removeId = 2;
            Employee? employeeToRemove = employees.Find(emp => emp.Id == removeId);
            if (employeeToRemove != null)
            {
                employees.Remove(employeeToRemove);
                Console.WriteLine($"Employee with Id {removeId} has been removed.");
            }
            else
            {
                Console.WriteLine($"No employee found with Id {removeId}");
            }

            // Remove All Employee whose names start with 'D'
            int removeCount = employees.RemoveAll(emp => emp.Name.StartsWith('D'));
             Console.WriteLine($"Number of employees removed: {removeCount}");

            Console.WriteLine();

            // Displaying all Employees
            Console.WriteLine("All Employees");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }


            Console.ReadKey();

        }
    }
}

/* ***************************************************************************************** */

using System.Collections;

namespace coreConsoleBasicApp
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Hashtable employees = new Hashtable();

            employees.Add(1, "Kartik");
            employees.Add(2, "Gautam");
            employees.Add(3, "Sumit");
            employees.Add(4, "Kavya");

            Console.WriteLine("Employee with ID 1 : " + employees[1]);
            Console.WriteLine("Employee with ID 4 : " + employees[4]);

            // Removing a Key-Value Pair:
            employees.Remove(3);

            // Checking if a key exists:
            if(employees.ContainsKey(2))
                Console.WriteLine("Employee exist with ID 2.");
            else
                Console.WriteLine("Employee doesnt exist with ID 2.");

            // Iterating Over the HashTable
            Console.WriteLine("\nAll Employees:");
            foreach (DictionaryEntry entry in employees)
            {
                Console.WriteLine($"Id: {entry.Key}, Name: {entry.Value}");
            }


            Console.ReadKey();

        }
    }
}

/* ***************************************************************************************** */

using System.Collections;

namespace coreConsoleBasicApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> employees = new Dictionary<int, string>();

            // Adding key-value pairs to the Dictionary
            employees.Add(1, "Alice");
            employees.Add(2, "Bob");
            employees.Add(3, "Charlie");
            employees.Add(4, "Diana");

            Console.WriteLine("Employee wth Id 1: " + employees[1]);
            Console.WriteLine("Employee wth Id 3: " + employees[3]);

            // Removing a key-value Pair
            employees.Remove(2);
            Console.WriteLine("Removed Employee with Id 2");

            // Iterating over the Dictionary
            foreach (KeyValuePair<int, string> entry in employees)
            {
                Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
            }

            Console.ReadKey();

        }
    }
}

/* ***************************************************************************************** */


/* SortedList Example: */

using System.Collections;

namespace coreConsoleBasicApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            SortedList<int, string> studentGrades = new SortedList<int, string>();

            studentGrades.Add(101, "A");
            studentGrades.Add(102, "B");
            studentGrades.Add(103, "A-");
            studentGrades.Add(104, "B+");

            foreach (KeyValuePair<int, string> student in studentGrades)
            {
                Console.WriteLine($"The {student.Key}, Grade: {student.Value}");
            }

            Console.ReadKey();

        }
    }
}

/* ***************************************************************************************** */

/* Stack Example: */

using System.Collections;

namespace coreConsoleBasicApp
{
    internal class Program
    {

        class TextEditor
        {
            private string text;
            private Stack<string> history;

            public TextEditor()
            {
                text = string.Empty;
                history = new Stack<string>();
            }

            public void AddText(string newText)
            {
                history.Push(text);
                text += newText;
                Console.WriteLine($"Added: {newText}");
            }

            public void Undo()
            {
                if (history.Count > 0)
                {
                    text = history.Pop();
                    Console.WriteLine("Undo Operation Performed.");
                }
                else
                {
                    Console.WriteLine("No more actions to undo.");
                }
            }

            public string GetText()
            {
                return text;
            }
        }

        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();

            // Simulate User Actions
            editor.AddText("Hello");
            editor.AddText("Everyone");
            editor.AddText("Welcome");

            Console.WriteLine("Current Text: " + editor.GetText());

            editor.Undo();
            Console.WriteLine("After Undo: " + editor.GetText());

            editor.Undo();
            Console.WriteLine("After Undo: " + editor.GetText());

            editor.Undo();
            Console.WriteLine("After Undo: " + editor.GetText());

            editor.Undo();

            Console.ReadKey();

        }
    }
}