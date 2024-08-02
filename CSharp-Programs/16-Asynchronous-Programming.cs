
Asynchronous Programming:

Callback 
Promises
Async/Await

Async/Await makes it easier to write code that performs non-blocking operations.
They are the part of the TAP (Task-Based Asynchronous Pattern).

/* ************************************************** */

using System.Collections;
using System.Text;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("Starting..");

            string result = await FetchDataFromWebAsync("https://jsonplaceholder.typicode.com/users/1");

            // Output the result:
            Console.WriteLine("Data Fetched: ");
            Console.WriteLine(result);

            Console.WriteLine("Done..!!");

            Console.ReadKey();
        }

        static async Task<string> FetchDataFromWebAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                // Await the asynchrounous Operation
                HttpResponseMessage responseMessage = await client.GetAsync(url);
                responseMessage.EnsureSuccessStatusCode();

                // Await the task of reading the content
                string responseBody = await responseMessage.Content.ReadAsStringAsync();
                
                return responseBody;
            }

        }

    }
}