
// Generic Classes and Generic Methods

using System.Collections;

namespace coreConsoleBasicApp
{
    class Box<T>
    {
        // Private Member of T Type
        private T _value;
        public Box(T value)
        {
            _value = value;
        }
        public T getValue()
        {
            return _value;
        }
    }

    internal class Program
    {
        static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
        static void Main(string[] args)
        {
            Box<int> intBox = new Box<int>(100);
            Console.WriteLine($"Box<int> value: {intBox.getValue()}");

            Box<string> stringBox = new Box<string>("Hello World!");
            Console.WriteLine($"Box<string> value: {stringBox.getValue()}");

            Console.WriteLine("Values are equal? : " + AreEqual(100, 100));
            Console.WriteLine("Values are equal? : " + AreEqual("Hello", "Hello!"));

            Console.ReadKey();

        }
    }
}

/* ********************************************************************** */

// Repository Pattern with Generic Interface

using System.Collections;

namespace coreConsoleBasicApp
{
    class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }

    class Supplier
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
    }

    // Generic Repository Interface
    public interface IRepository<T>
    {
        T getById(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

    // Implement the generic Repository Interface
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly List<T> _entties;
        public Repository()
        {
            _entties = new List<T>();
        }

        public void Add(T entity)
        {
            _entties.Add(entity);
        }

        public void Delete(T entity)
        {
            _entties.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _entties;
        }

        public T getById(int id)
        {
            return _entties.FirstOrDefault(c => c.Id == id);
            //return _entties.Where();
        }

        public void Update(T entity)
        {
            // Update Here
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            
            IRepository<Customer> customerRepository = new Repository<Customer>();

            // Add New Customer
            Customer customer = new Customer { Id = 1, Name = "King Kochhar", Email = "king@example.com" };
            customerRepository.Add(customer);
            Customer customer1 = new Customer { Id = 2, Name = "John Smith", Email = "smith@example.com" };
            customerRepository.Add(customer1);

            // Get all Customers
            IEnumerable<Customer> customerList = customerRepository.GetAll();
            foreach (var item in customerList)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Email: {item.Email}");
            }

            Console.WriteLine();

            // ****************************************************************************** //

            IRepository<Supplier> supplierRepository = new Repository<Supplier>();

            // Add New Supplier
            Supplier supplier1 = new Supplier { Id = 1, Name = "King Kochhar", City = "Delhi" };
            supplierRepository.Add(supplier1);
            Supplier supplier2 = new Supplier { Id = 2, Name = "John Smith", City = "Mumbai" };
            supplierRepository.Add(supplier2);

            // Get all Suppliers
            IEnumerable<Supplier> supplierList = supplierRepository.GetAll();
            foreach (var item in supplierList)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Email: {item.City}");
            }

                Console.ReadKey();

        }
    }
}

/* ********************************************************************** */

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
    class Supplier
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
    }
    // Generic Repository Interface
    public interface IRepository<T>
    {
        //T getById(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        //void Update(T entity);
        //void Delete(T entity);
        T getById(Func<T, bool> predicate);
        void Update(T item, Func<T, bool> predicate);
        void Delete(Func<T, bool> predicate);
    }
    // Implement the generic Repository Interface
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly List<T> _entties;
        public Repository()
        {
            _entties = new List<T>();
        }
        public void Add(T entity)
        {
            _entties.Add(entity);
        }
        //public void Delete(T entity)
        //{
        //    _entties.Remove(entity);
        //}
        public IEnumerable<T> GetAll()
        {
            return _entties;
        }
        public T getById(Func<T, bool> entity)
        {
            return _entties.FirstOrDefault(entity);
        }
        // Update
        public void Update(T item, Func<T, bool> entity)
        {
            var existingItem = _entties.FirstOrDefault(entity);
            if (existingItem != null)
            {
                var index = _entties.IndexOf(existingItem);
                _entties[index] = item;
            }
        }
        // Delete
        public void Delete(Func<T, bool> entity)
        {
            var item = _entties.FirstOrDefault(entity);
            if (item != null)
            {
                _entties.Remove(item);
            }
        }
        //public T getById(int id)
        //{
        //    return _entties.FirstOrDefault();
        //}
        //public void Update(T entity)
        //{
        //    // Update Here
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //string filepath = @"C:\Haridata\iTracer\Myfile.txt";
            ////FileStream filestream=new FileStream(filepath, FileMode.Create);
            ////filestream.Close();
            //// Create a FileStream Instance with specific parameters
            //FileStream fileStream = new FileStream(filepath, FileMode.Append);

            //// Create the byte array that contains the string data
            //byte[] byteData = Encoding.Default.GetBytes("I am trying to save the data into the file.");

            //// Write the Byte Array into the File Stream Object
            //fileStream.Write(byteData, 0, byteData.Length);
            //fileStream.Close();
            //// Create a string variable to hold the file data
            //string data;

            //// Create a FileStream Instance with specific parameters
            //FileStream fileStream2 = new FileStream(filepath, FileMode.Open, FileAccess.Read);

            //// Create an instance of streamReader to do the read operation
            //StreamReader streamReader = new StreamReader(fileStream2);
            //// This will read all the characters from current position till end.
            //data = streamReader.ReadToEnd();

            //// Finall print the data
            //Console.WriteLine(data);

            //// Close the FileStream Object
            //fileStream2.Close();

            //Console.WriteLine("File has been created successfully.");
            //Console.ReadKey();
            IRepository<Customer> customerRepository = new Repository<Customer>();
            // Add New Customer
            Customer customer = new Customer { Id = 1, Name = "King Kochhar", Email = "king@example.com" };
            customerRepository.Add(customer);
            Customer customer1 = new Customer { Id = 2, Name = "John Smith", Email = "smith@example.com" };
            customerRepository.Add(customer1);
            // Get all Customers
            IEnumerable<Customer> customerList = customerRepository.GetAll();
            foreach (var item in customerList)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Email: {item.Email}");
            }
            // Read by Id
            var singlerow = customerRepository.getById(s => s.Id == 1);
            Console.WriteLine("\nSingle Customer:");
            Console.WriteLine($"ID: {singlerow.Id}, Name: {singlerow.Name}, Age: {singlerow.Email}");
            // Update
            var updatedCustomer = new Customer { Id = 1, Name = "Hari Doe", Email = "Hari@example.com" };
            customerRepository.Update(updatedCustomer, s => s.Id == 1);
            Console.WriteLine("\nUpdated Customer:");
            IEnumerable<Customer> customerList2 = customerRepository.GetAll();
            foreach (var Custome in customerList2)
            {
                Console.WriteLine($"ID: {Custome.Id}, Name: {Custome.Name}, Age: {Custome.Email}");
            }

            // Delete
            customerRepository.Delete(s => s.Id == 2);

            Console.WriteLine("\nStudents After Deletion:");
            IEnumerable<Customer> customerList3 = customerRepository.GetAll();
            foreach (var student in customerList3)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, email: {student.Email}");
            }

            Console.WriteLine();
            // ****************************************************************************** //
            IRepository<Supplier> supplierRepository = new Repository<Supplier>();
            // Add New Supplier
            Supplier supplier1 = new Supplier { Id = 1, Name = "King Kochhar", City = "Delhi" };
            supplierRepository.Add(supplier1);
            Supplier supplier2 = new Supplier { Id = 2, Name = "John Smith", City = "Mumbai" };
            supplierRepository.Add(supplier2);
            // Get all Suppliers
            IEnumerable<Supplier> supplierList = supplierRepository.GetAll();
            foreach (var item in supplierList)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Email: {item.City}");
            }
            Console.ReadKey();
        }
    }
}