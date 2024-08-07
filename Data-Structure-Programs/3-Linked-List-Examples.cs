
Linked List:



(Singly)		Best	Average		Worst
Insertion		O(1)	O(1)		O(n)
Deletion		O(1)	O(1)		O(n)
Lookup/Search	O(1)	O(n)		O(n)

(Doubly)		Best	Average		Worst
Insertion		O(1)	O(1)		O(n)
Deletion		O(1)	O(1)		O(n)
Lookup/Search 	O(1)	O(n)		O(n)

/* **************************************************** */


namespace coreConsoleBasicApp
{

    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public LinkedList()
        {
            head = tail = null;
        }

        // Add a new Node at the end of the List
        public void Append(T data)
        {
            var newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }

        // Add a new Node at the beginning of the list
        public void Prepend(T data)
        {
            var newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }

        // Delete the first occurrence of the specific Data
        public void Delete(T data)
        {
            if (head == null)
                return;
            
            //itself holds --delete
            if (head.Data.Equals(data))
            {
                head = head.Next;
                if (head == null)
                    tail = null;    // List became Empty
                return;
            }

            //Search the data --delete  & track of the previous node
            Node<T> current = head;
            Node<T> previous = null;
            while (current != null && !current.Data.Equals(data))
            {
                previous = current;
                current = current.Next;
            }
            // If the data was not present in the list
            if (current == null)
                return;

            // Unlink the node from the list
            previous.Next = current.Next;
            if(current == tail)
                tail = previous;
        }

        // Print all elements in the list:
        public void PrintAll()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.Data + "\t");
                current = current.Next;
            }
            Console.WriteLine();
        }

        // Contains
        // Size
        // Reverse the List
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();

            // Append The elements:
            list.Append(1);
            list.Append(2);
            list.Append(3);

            // Print the List
            list.PrintAll();

            // Preappend an element
            list.Prepend(4);

            // Print the List
            list.PrintAll();

            // Delete an element
            list.Delete(2);

            // Print the List
            list.PrintAll();


            Console.ReadKey();

        }
    }
}