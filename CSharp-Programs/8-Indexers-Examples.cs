 
 /* Indexers: */
 
 - The indexer in C# is a property of a class.
 - This allows us to access a member variable of a class using the features of an array.
 
/* ****************************************************** */

namespace coreConsoleBasicApp
{
    class Employee
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }
        public string? Location { get; set; }
        public string? Department { get; set; }
        public string? Gender { get; set; }

        // Creating the Indexer using Integer Index Position
        public object this[int index]
        {
            // Get Accessor is used for returning a value:
            get
            {
                if (index == 0)
                    return ID;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Salary;
                else if (index == 3)
                    return Location;
                else if (index == 4)
                    return Department;
                else if (index == 5)
                    return Gender;
                else
                    return null;
            }
            set
            {
                if (index == 0)
                    ID = Convert.ToInt32(value);
                else if (index == 1)
                    Name = value.ToString();
                else if (index == 2)
                    Salary = Convert.ToDouble(value);
                else if (index == 3)
                    Location = value.ToString();
                else if (index == 4)
                    Department = value.ToString();
                else if (index == 5)
                    Gender = value.ToString();
            }
        }


        public Employee( int ID, string Name, double Salary, string Location, string Department, string Gender )
        {
            this.ID = ID;
            this.Name = Name;
            this.Salary = Salary;
            this.Location = Location;    
            this.Department = Department;
            this.Gender = Gender;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(101, "King Kochhar", 12000, "Mumbai", "IT", "Male");

            // Accessing Employee Properties using Indexers
            Console.WriteLine("ID : " + employee[0]);
            Console.WriteLine("Name : " + employee[1]);
            Console.WriteLine("Salary : " + employee[2]);
            Console.WriteLine("Location : " + employee[3]);
            Console.WriteLine("Department : " + employee[4]);
            Console.WriteLine("Gender : " + employee[5]);

            // Set the Employee object using Indexer:
            employee[1] = "John Smith";
            employee[2] = 65000;
            employee[4] = "Sales";

            Console.WriteLine();

            // Accessing Employee Properties using Indexers
            Console.WriteLine("ID : " + employee[0]);
            Console.WriteLine("Name : " + employee[1]);
            Console.WriteLine("Salary : " + employee[2]);
            Console.WriteLine("Location : " + employee[3]);
            Console.WriteLine("Department : " + employee[4]);
            Console.WriteLine("Gender : " + employee[5]);
			
        }
    }
}

/* ****************************************************** */

namespace coreConsoleBasicApp
{
    class Employee
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }
        public string? Location { get; set; }
        public string? Department { get; set; }
        public string? Gender { get; set; }

        // Creating the Indexer using Integer Index Position
        public object this[string index]
        {
            // Get Accessor is used for returning a value:
            get
            {
                if (index == "ID")
                    return ID;
                else if (index == "Name")
                    return Name;
                else if (index == "Salary")
                    return Salary;
                else if (index == "Location")
                    return Location;
                else if (index == "Department")
                    return Department;
                else if (index == "Gender")
                    return Gender;
                else
                    return null;
            }
            set
            {
                if (index == "ID")
                    ID = Convert.ToInt32(value);
                else if (index == "Name")
                    Name = value.ToString();
                else if (index == "Salary")
                    Salary = Convert.ToDouble(value);
                else if (index == "Location")
                    Location = value.ToString();
                else if (index == "Department")
                    Department = value.ToString();
                else if (index == "Gender")
                    Gender = value.ToString();
            }
        }


        public Employee( int ID, string Name, double Salary, string Location, string Department, string Gender )
        {
            this.ID = ID;
            this.Name = Name;
            this.Salary = Salary;
            this.Location = Location;    
            this.Department = Department;
            this.Gender = Gender;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(101, "King Kochhar", 12000, "Mumbai", "IT", "Male");

            // Accessing Employee Properties using Indexers
            Console.WriteLine("ID : " + employee["ID"]);
            Console.WriteLine("Name : " + employee["Name"]);
            Console.WriteLine("Salary : " + employee["Salary"]);
            Console.WriteLine("Location : " + employee["Location"]);
            Console.WriteLine("Department : " + employee["Department"]);
            Console.WriteLine("Gender : " + employee["Gender"]);

            // Set the Employee object using Indexer:
            employee["Name"] = "John Smith";
            employee["Salary"] = 65000;
            employee["Department"] = "Sales";

            Console.WriteLine();

            // Accessing Employee Properties using Indexers
            Console.WriteLine("ID : " + employee["ID"]);
            Console.WriteLine("Name : " + employee["Name"]);
            Console.WriteLine("Salary : " + employee["Salary"]);
            Console.WriteLine("Location : " + employee["Location"]);
            Console.WriteLine("Department : " + employee["Department"]);
            Console.WriteLine("Gender : " + employee["Gender"]);


        }
    }
}

/* ****************************************************** */


namespace coreConsoleBasicApp
{
    class Employee
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }
        public string? Location { get; set; }
        public string? Department { get; set; }
        public string? Gender { get; set; }

        // Creating the Indexer using Integer Index Position
        public object this[string index]
        {
            // Get Accessor is used for returning a value:
            get
            {
                if (index.ToUpper() == "ID")
                    return ID;
                else if (index.ToUpper() == "NAME")
                    return Name;
                else if (index.ToUpper() == "SALARY")
                    return Salary;
                else if (index.ToUpper() == "LOCATION")
                    return Location;
                else if (index.ToUpper() == "DEPARTMENT")
                    return Department;
                else if (index.ToUpper() == "GENDER")
                    return Gender;
                else
                    return null;
            }
            set
            {
                if (index.ToUpper() == "ID")
                    ID = Convert.ToInt32(value);
                else if (index == "NAME")
                    Name = value.ToString();
                else if (index.ToUpper() == "SALARY")
                    Salary = Convert.ToDouble(value);
                else if (index.ToUpper() == "LOCATION")
                    Location = value.ToString();
                else if (index.ToUpper() == "DEPARTMENT")
                    Department = value.ToString();
                else if (index.ToUpper() == "GENDER")
                    Gender = value.ToString();
            }
        }


        public Employee( int ID, string Name, double Salary, string Location, string Department, string Gender )
        {
            this.ID = ID;
            this.Name = Name;
            this.Salary = Salary;
            this.Location = Location;    
            this.Department = Department;
            this.Gender = Gender;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(101, "King Kochhar", 12000, "Mumbai", "IT", "Male");

            // Accessing Employee Properties using Indexers
            Console.WriteLine("ID : " + employee["ID"]);
            Console.WriteLine("Name : " + employee["Name"]);
            Console.WriteLine("Salary : " + employee["Salary"]);
            Console.WriteLine("Location : " + employee["Location"]);
            Console.WriteLine("Department : " + employee["Department"]);
            Console.WriteLine("Gender : " + employee["Gender"]);

            // Set the Employee object using Indexer:
            employee["Name"] = "John Smith";
            employee["Salary"] = 65000;
            employee["Department"] = "Sales";

            Console.WriteLine();

            // Accessing Employee Properties using Indexers
            Console.WriteLine("ID : " + employee["ID"]);
            Console.WriteLine("Name : " + employee["Name"]);
            Console.WriteLine("Salary : " + employee["Salary"]);
            Console.WriteLine("Location : " + employee["Location"]);
            Console.WriteLine("Department : " + employee["Department"]);
            Console.WriteLine("Gender : " + employee["Gender"]);


        }
    }
}

/* ****************************************************** */

namespace coreConsoleBasicApp
{

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

    class Library
    {
        private List<Book> books = new List<Book>();

        // Indexer for accessing Books by ISBN
        public Book this[string isbn]
        {
            get
            {
                // Find the book by ISBN
                return books.Find(book => book.ISBN == isbn);
            }
            set
            {
                // Replace or add the book by ISBN
                Book? existingBook = books.Find(book => book.ISBN == isbn);
                if (existingBook != null)
                {
                    int index = books.IndexOf(existingBook);
                    books[index] = value;
                }
                else
                {
                    // Add the New Book
                    books.Add(value);
                }
            }
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           
            Library library = new Library();

            library.AddBook(new Book() { Title = "The Hobbit", Author = "Tolkien", ISBN = "123456" });
            library.AddBook(new Book() { Title = "Harry Potter", Author = "Rowling", ISBN = "246802" });
            library.AddBook(new Book() { Title = "MockingBird", Author = "Harper Lee", ISBN = "135791" });

            // Accessing books using the indexer:
            Console.WriteLine("Book Found By ISBN 123456: ");
            Book book = library["123456"];
            if(book != null)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }

            // Replacing a Book:
            library["246802"] = new Book() { Title = "Harry Pooter 22", Author = "Rowling", ISBN = " 246802" };
            // Accessing the Replaced Book
            Book book1 = library["246802"];
            if (book1 != null)
            {
                Console.WriteLine($"Title: {book1.Title}, Author: {book1.Author}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }

        }
    }
}