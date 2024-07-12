
Properties in C#:

	- A property is also a member of a class
	- This helps to set and get the data from the data members.
	- We uses Accessors thats helps in setting and getting the data.
	- Different Types of Properties:
		- Read-Only Property
		- Write-Only Property
		- Read Write Property
		- Auto-Implemented Property

/* **************************************************** */

namespace coreConsoleBasicApp
{

    class Person
    {
        // Private Fields
        private string? name;
        private int age;

        public Person()
        {
            this.name = "Kartik Sharma";
            this.age = 18;
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}";
        }

        // Read-Only Property
        public string? Name
        {
            get { return name; }
        }

        // Write-Only Property
        public int Age
        {
            set
            {
                age = value;
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person);
            Console.WriteLine(person.Name);
            // person.Name = "Gautam Bhalla"; // Error: It is read-only.
            // Console.WriteLine(person.Age);      // Error: It is write-only.
            person.Age = 20;
            Console.WriteLine(person);

            Console.ReadKey();
        }
    }
}

/* ******************************************************* */

namespace coreConsoleBasicApp
{

    class Person
    {
        // Private Fields
        private string? name;
        private int age;
        private string? email;

        public Person()
        {
            this.name = "Kartik Sharma";
            this.age = 18;
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}";
        }

        // Read-Write Property
        public string? Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                name = value;
            }
        }

        // Read-Write Property
        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 0 || value > 150)
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 150.");
                age = value;
            }
        }
        public string? Email { get;  set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person);
            Console.WriteLine(person.Name);
            // person.Name = "Gautam Bhalla"; // Error: It is read-only.
            // Console.WriteLine(person.Age);      // Error: It is write-only.
            person.Age = 20;
            Console.WriteLine(person);

            Console.ReadKey();
        }
    }
}
