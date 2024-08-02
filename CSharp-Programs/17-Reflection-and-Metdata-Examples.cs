
Reflection and Metadata:

	- These are capabilities for inspecting and manipulating types and members at runtime.
	- Helps in Dynamic Type Discovery, Creating Libraries and Interact with Other Code.
	
Reflection:

	- Tells you information about assembles, modules and Types.
	
Metadata 

	- Tells you to about the program Code, like
		Types, Members, Assemblies and so on .
		
/* ****************************************************** */

// Using Reflection:

// Inspect Types and Members:

using System.Collections;
using System.Reflection;
using System.Text;

namespace coreConsoleBasicApp
{
    class Person
    {
        public string? Name { get; set; }
        private int Age { get; set; }
        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {this.Name}");
        }
        private void DisplayAge()
        {
            Console.WriteLine($"I am {this.Age} years old.");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);

            Console.WriteLine("Type Name : " + personType.FullName);

            Console.WriteLine();

            // Get and Display all Public Properties
            Console.WriteLine("Public Properties: ");
            foreach (PropertyInfo prop in personType.GetProperties())
            {
                Console.WriteLine($" - {prop.Name} : {prop.PropertyType.Name}");
            }

            Console.WriteLine();

            // Get and Display all private fields
            Console.WriteLine("Private Properties: ");
            foreach (PropertyInfo prop in personType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine($" - {prop.Name} : {prop.PropertyType.Name}");
            }

            Console.WriteLine();

            // Get and Invoke Public Method
            MethodInfo? introductMethod = personType.GetMethod("Introduce");
            object? personInstance = Activator.CreateInstance(personType, "Gautam", 23);
            introductMethod.Invoke(personInstance, null);


            // Attempt and Invoke Private Method
            MethodInfo? displayAgeMethod = personType.GetMethod("DisplayAge", BindingFlags.NonPublic | BindingFlags.Instance);
            displayAgeMethod.Invoke(personInstance, null);

        }

    }
}

/* ****************************************************** */

/* Using Attributes */

- A way to add Metadata to your code, which can be inspected using reflection.using coreConsoleBasicApp;
using System.Collections;
using System.Reflection;
using System.Text;

namespace coreConsoleBasicApp
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false)]
    public class CustomAttribute: Attribute
    {
        public string Description { get; set; }
        public CustomAttribute(string description)
        {
            Description = description;
        }
    }

    [Custom("This is a sample class.")]
    public class SampleClass
    {
        [Custom("This is a sample method.")]
        public void SampleMethod()
        {
            Console.WriteLine("Method Executed!");
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(SampleClass);    

            CustomAttribute classAttr = (CustomAttribute)Attribute.GetCustomAttribute(type, typeof(CustomAttribute));
            if(classAttr != null)
            {
                Console.WriteLine("Class Attribute: " + classAttr.Description);
            }

            MethodInfo method = type.GetMethod("SampleMethod");
            CustomAttribute methodAttr = (CustomAttribute)Attribute.GetCustomAttribute(method, typeof(CustomAttribute));
            if (methodAttr != null)
            {
                Console.WriteLine("Method Attribute: " + methodAttr.Description);
            }
        }

    }
}

