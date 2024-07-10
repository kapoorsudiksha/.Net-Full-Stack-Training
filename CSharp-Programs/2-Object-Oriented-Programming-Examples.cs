

/* Demonstration: Classes and Objects: */

namespace coreOOPSConcepts
{
    class Product
    {
        // Data Members (Attributes)
        int id;
        string? name;
        double price;
        int quantity;

        // Special Method (Constructor)
        public Product()
        {
            id = 101;
            name = "Annonymous";
            price = 0.0;
            quantity = 1;
        }

        // Member Function (Behaviour)
        public void display()
        {
            Console.WriteLine("Product Details: ");
            Console.WriteLine($"Product Id: {id}");
            Console.WriteLine($"Product Name: {name}");
            Console.WriteLine($"Product Price: {price}");
            Console.WriteLine($"Product Quantity: {quantity}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // A reprentator of a class(object)

            // Creating a variable of Product Type
            // Creating a variable of UDDT
            Product product;
            // Creating an object of product type
            product = new Product();

            // Or, You can combine theses statements
            Product product1 = new Product();

            product.display();
            product1.display();

            Console.ReadKey();
        
        }
    }
}

/* ****************************************************** */

/* Demonstration: Classes and Objects with Constructors */

namespace coreOOPSConcepts
{
    class Product
    {
        // Data Members (Attributes)
        int id;
        string? name;
        double price;
        int quantity;

        // Default Constuctor (Paramter-Less Constructor)
        public Product()
        {
            this.id = 101;
            this.name = "Annonymous";
            this.price = 0.0;
            this.quantity = 1;
        }

        // Parameterized Constructor
        public Product(int id, string? name, double  price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        // Member Function (Behaviour)
        public void display()
        {
            Console.WriteLine("Product Details: ");
            Console.WriteLine($"Product Id: {this.id}");
            Console.WriteLine($"Product Name: {this.name}");
            Console.WriteLine($"Product Price: {this.price}");
            Console.WriteLine($"Product Quantity: {this.quantity}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Product product = new Product();
            Product product1 = new Product(102, "Product Two", 1200, 12);

            product.display();
            product1.display();

            Console.ReadKey();
        
        }
    }
}

/* ****************************************************** */

/* Demonstration: Classes and Objects with toString() Method */

namespace coreOOPSConcepts
{
    class Product
    {
        // Data Members (Attributes)
        int id;
        string? name;
        double price;
        int quantity;

        // Default Constuctor (Paramter-Less Constructor)
        public Product()
        {
            this.id = 101;
            this.name = "Annonymous";
            this.price = 0.0;
            this.quantity = 1;
        }

        // Parameterized Constructor
        public Product(int id, string? name, double  price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        // Member Function (Behaviour)
        public override string ToString()
        {
            return $"ID: {this.id}, Name: {this.name}, Price: {this.price}, Quantity: {this.quantity}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Product product = new Product();
            Product product1 = new Product(102, "Product Two", 1200, 12);

            Console.WriteLine(product);
            Console.WriteLine(product1);

            Console.ReadKey();
        
        }
    }
}

/* ****************************************************** */

/* Demonstration: Classes and Objects with Constructors Summarized Example */

namespace coreOOPSConcepts
{
    class Product
    {
        // Data Members (Attributes)
        int id;
        string? name;
        double price;
        int quantity;

        // Parameterized Constructor
        public Product(int id, string? name, double  price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        // Member Function (Behaviour)
        public override string ToString()
        {
            return $"ID: {this.id}, Name: {this.name}, Price: {this.price}, Quantity: {this.quantity}";
        }
    }

    class ShoppingCart
    {
        List<Product> products;
        public ShoppingCart()
        {
            this.products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void DisplayCart()
        {
            Console.WriteLine("Shopping Cart Contents: ");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            // Creating Products
            Product product1 = new Product(101, "Laptop", 1200, 12);
            Product product2 = new Product(102, "Smartphone", 800, 10);
            Product product3 = new Product(103, "Headphones", 150, 20);

            // Create Shopping Cart and Add Products
            ShoppingCart cart = new ShoppingCart();
            cart.AddProduct(product1);
            cart.AddProduct(product2);
            cart.AddProduct(product3);

            // Diplay Contents of Shopping Cart
            cart.DisplayCart();

            Console.ReadKey();
        
        }
    }
}

/* ****************************************************** */

/* Demonstration: Inheritance(IS-A Relationship) */

namespace coreOOPSConcepts
{
    class Customer
    {
        int customerId;
        string? customerName;
        string? customerEmail;
        
       public Customer()
        {
            customerId = 0;
            customerName = "Unknown";
            customerEmail = "example@example.com";
        }

        public Customer(int customerId, string? customerName, string? customerEmail)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Customer Id: {this.customerId}");
            Console.WriteLine($"Customer Name: {this.customerName}");
            Console.WriteLine($"Customer Email: {this.customerEmail}");
        }
    }

    class PremiumCustomer: Customer
    {
        double subscriptionFee;

        public PremiumCustomer(): base()
        {
            this.subscriptionFee = 99.99;
        }

        public PremiumCustomer(int customerId, string? customerName, string? customerEmail, double subscriptionFee): 
            base(customerId, customerName, customerEmail)
        {
            this.subscriptionFee = subscriptionFee;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Subscription Fee: {this.subscriptionFee}");
        }
    }

    class RegularCustomer: Customer
    {
        string? membershipLevel;
        public RegularCustomer() : base()
        {
            this.membershipLevel = "Standard";
        }

        public RegularCustomer(int customerId, string? customerName, string? customerEmail, string? membershipLevel):
            base(customerId, customerName, customerEmail)
        {
            this.membershipLevel=membershipLevel;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Membership Level: {this.membershipLevel}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            // PremiumCustomer premiumCustomer1 = new PremiumCustomer();
            PremiumCustomer premiumCustomer2 = new PremiumCustomer(1, "King Kochhar", "king@gmail.com", 149.99);

            // RegularCustomer regularCustomer1 = new RegularCustomer();
            RegularCustomer regularCustomer2 = new RegularCustomer(2, "John Smith", "john@gmail.com", "Gold");

            Console.WriteLine("Premimum Customer Details: ");
            // premiumCustomer1.DisplayInfo();
            premiumCustomer2.DisplayInfo();

            Console.WriteLine();

            Console.WriteLine("Regular Customer Details: ");
            // regularCustomer1.DisplayInfo();
            regularCustomer2.DisplayInfo();

            Console.ReadKey();
        
        }
    }
}

/* *********************************************************** */

/* Demonstration: Inheritance(IS-A Relationship) and Aggregation(HAS-A Relationship) */

namespace coreOOPSConcepts
{
    class Product
    {
        // Data Members (Attributes)
        int id;
        public string? name;
        double price;
        int quantity;

        // Parameterized Constructor
        public Product(int id, string? name, double price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        // Member Function (Behaviour)
        public override string ToString()
        {
            return $"ID: {this.id}, Name: {this.name}, Price: {this.price}, Quantity: {this.quantity}";
        }
    }

    class ShoppingCart
    {
        List<Product> products;
        public ShoppingCart()
        {
            this.products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void DisplayCart()
        {
            Console.WriteLine("Shopping Cart Contents: ");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }

    class User
    {
        int userId;
        protected string? userName;
        string? email;

        public User(int userId, string? userName, string? email)
        {
            this.userId = userId;
            this.userName = userName;
            this.email = email;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"User Id: {this.userId}");
            Console.WriteLine($"User Name: {this.userName}");
            Console.WriteLine($"User Email: {this.email}");
        }
    }

    class Customer: User
    {
        string? address;
        public ShoppingCart? cart;

        public Customer(int usesrId, string? username, string? email, string? address) :
            base(usesrId, username, email)
        {
            this.address = address;
            cart = new ShoppingCart();
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Address: {this.address}");
        }

        public void AddToCart(Product product)
        {
            cart.AddProduct(product);
            Console.WriteLine($"{userName} added {product.name} to the shopping cart.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer(1, "John", "john@example.com", "Civil Lines");

            // Display the Customer Details
            customer1.DisplayInfo();

            // Customer Adds the Products to the Shopping Cart
            Product product1 = new Product(101, "Laptop", 1200, 12);
            Product product2 = new Product(102, "Smartphone", 800, 10);
            Product product3 = new Product(103, "Headphones", 150, 20);
            customer1.AddToCart(product1); 
            customer1.AddToCart(product2);
            customer1.AddToCart(product3);

            // Display the Contents of the customer's Shopping Cart.
            customer1.cart?.DisplayCart();

            Console.ReadKey();
        
        }

    }
}

/* ****************************************************************** */

/* Demonstration: Method Overloading and Method Overriding */

namespace coreOOPSConcepts
{
    class Product
    {
        // Data Members (Attributes)
        int id;
        public string? name;
        double price;
        int quantity;

        // Parameterized Constructor
        public Product(int id, string? name, double price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        // Member Function (Behaviour)
        public override string ToString()
        {
            return $"ID: {this.id}, Name: {this.name}, Price: {this.price}, Quantity: {this.quantity}";
        }
    }

    class ShoppingCart
    {
        List<Product> products;
        public ShoppingCart()
        {
            this.products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void DisplayCart()
        {
            Console.WriteLine("Shopping Cart Contents: ");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }

    class User
    {
        int userId;
        protected string? userName;
        string? email;

        public User()
        {
            this.userId = 0;
            this.userName = "Unknown";
            this.email = "example@gmail.com";
        }

        public User(int userId, string? userName, string? email)
        {
            this.userId = userId;
            this.userName = userName;
            this.email = email;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"User Id: {this.userId}");
            Console.WriteLine($"User Name: {this.userName}");
            Console.WriteLine($"User Email: {this.email}");
        }
    }

    class Customer : User
    {
        string? address;
        public ShoppingCart? cart;

        public Customer() : base()
        {
            address = "Unknown";
            cart = new ShoppingCart();
        }

        public Customer(int usesrId, string? username, string? email, string? address) :
            base(usesrId, username, email)
        {
            this.address = address;
            cart = new ShoppingCart();
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Address: {this.address}");
        }

        public void AddToCart(Product product)
        {
            cart?.AddProduct(product);
            Console.WriteLine($"{userName} added {product.name} to the shopping cart.");
        }

        public void AddToCart(Product product, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                {
                    cart?.AddProduct(product);
                }
                Console.WriteLine($"{userName} added {product.name} to the shopping cart.");

            }
        }

    }

        class Program
        {
            static void Main(string[] args)
            {

                Customer customer1 = new Customer(1, "John", "john@example.com", "Civil Lines");

                // Display the Customer Details
                customer1.DisplayInfo();

                // Customer Adds the Products to the Shopping Cart
                Product product1 = new Product(101, "Laptop", 1200, 12);
                Product product2 = new Product(102, "Smartphone", 800, 10);
                Product product3 = new Product(103, "Headphones", 150, 20);
                customer1.AddToCart(product1);  // Adds 1 Laptop
                customer1.AddToCart(product2, 2);  // Adds 2 Smartphones
                customer1.AddToCart(product3);

                // Display the Contents of the customer's Shopping Cart.
                customer1.cart?.DisplayCart();

                Console.ReadKey();

            }

        }
    }

