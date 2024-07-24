
// LINQ query with primitive types

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // LINQ query to get even numbers
            var evenNumbers = from num in numbers   // Initialization
                              where num % 2 == 0   // Condition
                              select num;           // Selection

            // Execute the query and print result
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

/* ************************************************* */

// LINQ query with Object types

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name = "Keyboard", Price = 200 },
                new Product { Id = 2, Name = "Mouse", Price = 300 },
                new Product { Id = 3, Name = "Monitor", Price = 530 },
                new Product { Id = 4, Name = "Headphones", Price = 320 },
                new Product { Id = 5, Name = "Speakers", Price = 600 }
            };

            var expensiveProducts = from product in products
                                    where product.Price > 500
                                    select product;

            // Execute the query and print the results
            foreach (var product in expensiveProducts)
            {
                Console.WriteLine($"{product.Name} - {product.Price}");
            }

            Console.ReadKey();
        }
    }
}

/* ************************************************* */

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CityId { get; set; }
    }

    class City
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

                List<Customer> customers = new List<Customer>()
                {
                    new Customer { Id = 1, Name = "King Kochhar", CityId = 1 },
                    new Customer { Id = 2, Name = "Roger Lee", CityId = 2 },
                    new Customer { Id = 3, Name = "John Smith", CityId = 1 }
                };

                List<City> cities = new List<City>()
                {
                    new City { Id = 1, Name = "New York" },
                    new City { Id = 1, Name = "Los Angeles" },
                    new City { Id = 1, Name = "Chicago" },
                };

                // LINW query to join customers and cities
                var query = from customer in customers
                            join city in cities
                            on customer.Id equals city.Id
                            select new
                            {
                                CustomerName = customer.Name,
                                CityName = city.Name,
                            };

                // Execute the query and print the result
                Console.WriteLine("Customer Details with their city:");
                foreach (var result in query)
                {
                    Console.WriteLine($"{result.CustomerName} = {result.CityName}");
                }

                Console.ReadKey();
        }
    }
}