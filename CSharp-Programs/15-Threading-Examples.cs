
Threading in C#:

Multitasking means performing multiple tasks simultaneously.
Example, Windows Operating System

Multitasking refers to to the concurrent execution of multiple tasks or process on a computer system. Althout our system performs multiple tasks, though it has a single central processing Unit (CPU).

So, our OS uses the processes internally to execute multiple applications simultaneously.

Process:

A process is a part of the OS helps in executing the programs or application.
The processes internally uses a concept called Thread.

Thread:

	- A lightweight process.
	- responsible for executing the application code.
	- Every process has some logic or code and execute those codes, Thread comes into the picture.
	- Every Application is a single threaded application.
	- By default, the Main thread will execute our application code.
	
/* ************************************************** */

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Getting the main Thread (current thread)
            Thread mainThread = Thread.CurrentThread;

            // Properties of Main Thread
            Console.WriteLine("Thread Id : " + mainThread.ManagedThreadId);
            Console.WriteLine("Thread Name : " + mainThread.Name);
            Console.WriteLine("Is Background Thread : " + mainThread.IsBackground);
            Console.WriteLine("Is Alive :" + mainThread.IsAlive);
            Console.WriteLine("Thread State : " + mainThread.ThreadState);
            Console.WriteLine("Priority : " + mainThread.Priority);
            Console.WriteLine("Culture Info : " + mainThread.CurrentCulture);
            Console.WriteLine("UI Culture Info : " + mainThread.CurrentUICulture);

            Console.WriteLine("Lets Learn Threading in C#!");
            Console.ReadKey();
        }
    }
}

/* ************************************************** */

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Getting the main Thread (current thread)
            Thread mainThread = Thread.CurrentThread;

            // Properties of Main Thread
            Console.WriteLine("Thread Id : " + mainThread.ManagedThreadId);
            Console.WriteLine("Thread Name : " + mainThread.Name);
            Console.WriteLine("Is Background Thread : " + mainThread.IsBackground);
            Console.WriteLine("Is Alive :" + mainThread.IsAlive);
            Console.WriteLine("Thread State : " + mainThread.ThreadState);
            Console.WriteLine("Priority : " + mainThread.Priority);
            Console.WriteLine("Culture Info : " + mainThread.CurrentCulture);
            Console.WriteLine("UI Culture Info : " + mainThread.CurrentUICulture);

            // Starting a new thread to show interation with the main thread
            Thread workerThread = new Thread(new ThreadStart(workerThreadMethod));
            workerThread.Start();

            // Joining the worker thread to wait for its completion
            workerThread.Join();

            Console.WriteLine("Main Thread is Exiting..!!");

            Console.ReadKey();
        }

        static void workerThreadMethod()
        {
            Console.WriteLine("Worker Thread Started..");
            Thread.Sleep(2000); // Simulate some work
            Console.WriteLine("Worker Thread Finished..");
        }
    }
}

/* ************************************************** */

// Single Threaded Application:

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Method1();
            Method2();
            Method3();

            Console.ReadKey();
        }

        static void Method1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method 1 : " + i);
            }
        }

        static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method 2 : " + i);
                if(i == 4)
                {
                    Console.WriteLine("Fetching some data from API..");
                    Thread.Sleep(10000);
                    Console.WriteLine("Fetched the data successfully.");
                }
            }
        }

        static void Method3()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method 3 : " + i);
            }
        }
    }
}

/* ************************************************** */

// Multi Threaded Application:

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Main Thread Started..");

            // Creating Threads
            Thread t1 = new Thread(Method1);
            t1.Name = "Thread1";
            Thread t2 = new Thread(Method2) { Name = "Thread2" };
            Thread t3 = new Thread(Method3) { Name = "Thread3" };

            // Executing the threads
            t1.Start();
            t2.Start();
            t3.Start();


            Console.WriteLine("Main Thread Ended..");

            Console.ReadKey();
        }

        static void Method1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method 1 : " + i);
            }
        }

        static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method 2 : " + i);
                if(i == 2)
                {
                    Console.WriteLine("Fetching some data from API..");
                    Thread.Sleep(10000);
                    Console.WriteLine("Fetched the data successfully.");
                }
            }
        }

        static void Method3()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method 3 : " + i);
            }
        }
    }
}

/* ************************************************** */

// Life Cycle of a thread has several states:

Unstarted, Running, Wait/Sleep/Join, Stopped.

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Main Thread Starting..");

            // Create and start a new thread
            Thread workerThread = new Thread(workerThreadMethod);

            Console.WriteLine("Worker Thread State (Before Start): " + workerThread.ThreadState);

            workerThread.Start();

            Console.WriteLine("Worker Thread State (After Start): " + workerThread.ThreadState);

            workerThread.Join();

            Console.WriteLine("Worker Thread State (After Join): " + workerThread.ThreadState);

            Console.ReadKey();
        }

        static void workerThreadMethod()
        {
            Console.WriteLine("Worker Thread Started..");
            Thread.Sleep(2000); // Simulate some work
            Console.WriteLine("Worker Thread Finished..");
        }

    }
}

/* ************************************************** */

// Thread Life Cycle with Disposed Method also.

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Starting");

            // Creating and Starting a Timer Thread
            Timer timer = new Timer(UpdateTime, null, 0, 1000);

            // Allow the timer to run for 5 seconds before stopping
            Thread.Sleep(5000);

            // Dispose of the timer.
            timer.Dispose();

            Console.WriteLine("Main Thread Ending");

            Console.ReadKey();
        }

       static void UpdateTime(object state)
        {
            // This method will be called every second by the Timer
            Console.Clear();
            Console.WriteLine("Current Time : " + DateTime.Now.ToString("HH:mm:ss"));
        }

    }
}

/* ************************************************** */

// To Pass Data to Thread Function in Thread Safe Manner:

/* *************** */

// 1. Using Strongly Typed Objects

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    class ThreadData
    {
        public int Number { get; set; }
        public string Message { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadData data = new ThreadData() { Number = 101, Message = "Hello from Thread!" };
            
            // Start a new Thread and Pass the data
            Thread thread = new Thread(ThreadFunction);
            thread.Start(data);

            // Wait for the thread to complete
            thread.Join();

            Console.ReadKey();
        }

        static void ThreadFunction(object obj)
        {
            // Casting the object to the strongly typed data class
            ThreadData data = (ThreadData)obj;

            // Result
            Console.WriteLine($"Number: {data.Number}, Message: {data.Message}");
        }

    }
}

/* *************** */

// 2. Using ParameterizedThreadStart Delegate

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    class ThreadData
    {
        public int Number { get; set; }
        public string Message { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadData data = new ThreadData() { Number = 101, Message = "Hello from Thread!" };
            
            // Create a ThreadStart Delegate
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(ThreadFunction);

            // Start a new Thread and Pass the data
            Thread thread = new Thread(threadStart);
            thread.Start(data);

            // Wait for the thread to complete
            thread.Join();

            Console.ReadKey();
        }

        static void ThreadFunction(object obj)
        {
            // Casting the object to the strongly typed data class
            ThreadData data = (ThreadData)obj;

            // Result
            Console.WriteLine($"Number: {data.Number}, Message: {data.Message}");
        }

    }
}

/* *************** */

// 3. Using Task Parallel Library (TPL)

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    class TaskData
    {
        public int Number { get; set; }
        public string? Message { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskData data = new TaskData() { Number = 101, Message = "Hello from Task!" };

            // start a new task and pass the data

            Task.Run(() => TaskFunction(data)).Wait();

            Console.ReadKey();
        }

        static void TaskFunction(TaskData data)
        {
            // Result
            Console.WriteLine($"Number: {data.Number}, Message: {data.Message}");
        }

    }
}

/* *************** */

// 4. Using async and await with Task

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    class AsyncData
    {
        public int Number { get; set; }
        public string? Message { get; set; }
    }
    internal class Program
    {
        static async Task Main(string[] args)
        {
            AsyncData data = new AsyncData() { Number = 101, Message = "Hello from Async Task!" };

            // start a new task and pass the data

            await Task.Run(() => AsyncFunction(data));

            Console.ReadKey();
        }

        static void AsyncFunction(AsyncData data)
        {
            // Result
            Console.WriteLine($"Number: {data.Number}, Message: {data.Message}");
        }

    }
}

/* ************************************************** */

// To retrieve data from a Thread Function in C#:

/* ************************************************** */