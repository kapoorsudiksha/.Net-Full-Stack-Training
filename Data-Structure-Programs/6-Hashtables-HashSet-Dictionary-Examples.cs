
// Hashtable in C#:


using System.Data;
using System.Collections;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            // Add key-values pairs
            hashtable.Add("Key1", "Value1");
            hashtable.Add("Key2", "Value2");
            hashtable.Add("Key3", "Value3");

            // Add Any key-value pairs
            hashtable.Add(4, "Value4");

            // Retrieve values
            Console.WriteLine(hashtable["Key1"]);
            Console.WriteLine(hashtable[4]);

            if(hashtable.ContainsKey("Key2"))
                Console.WriteLine("Key2 exists in the hash table.");

            foreach (DictionaryEntry entry in hashtable)
                Console.WriteLine($"{entry.Key}: {entry.Value}");

            Console.ReadKey();
        }
    }
}

/* ********************************************* */

// Dictionary in C#:

using System.Data;
using System.Collections;

namespace coreConsoleBasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            // Add key-value pairs
            dictionary.Add("Key1", "Value1");
            dictionary.Add("Key2", "Value2");
            dictionary.Add("Key3", "Value4");

            // Retrieve Values
            Console.WriteLine(dictionary["Key1"]);

            // Contains or Not
            if(dictionary.ContainsKey("Key2"))
                Console.WriteLine("Key2 exists in the dictionary.");

            // Iterate the Dictionary
            foreach (KeyValuePair<string, string> item in dictionary)
                Console.WriteLine($"{item.Key}: {item.Value}");

            Console.ReadKey();
        }
    }
}

Hashtable vs. Dictionary (Key Differences):

	- Type Safety
	- Performance
	- Namespance
	
/* ******************************************************** */

	Node
	Root
	Leaf
	SubTree
	Depth/Height


using System.Data;
using System.Collections;
using System.Xml.Linq;

namespace coreConsoleBasicApp
{

    class TreeNode
    {
        public int Value { get; set; }
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }
    
        public TreeNode(int value)
        {
            Value = value; 
            Left = null;
            Right = null;
        }
    
    }

    class BinaryTree
    {
        public TreeNode Root { get; set; }
        public BinaryTree()
        {
            Root = null;
        }

        // Insert a new Value
        public void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }

        public TreeNode InsertRec(TreeNode node, int value)
        {
            if (node == null)
            {
                node = new TreeNode(value);
                return node;
            }

            if (value < node.Value)
            {
                node.Left = InsertRec(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = InsertRec(node.Right, value);
            }
            return node;
        }

        public void InOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Console.Write(node.Value + " ");
                InOrderTraversal(node.Right);
            }
        }

        public void PostOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Console.Write(node.Value + " ");
            }
        }
        public void PreOrderTraversal(TreeNode root)
        {
            if (root != null)
            {
                Console.Write(root.Value + " ");
                PreOrderTraversal(root.Left);
                PreOrderTraversal(root.Right);
            }
        }

        public void LevelOrderTraversal()
        {
            if (Root == null) return;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(Root);
            while(queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                Console.Write(node.Value + " ");
                if (node.Left != null)
                    queue.Enqueue(node.Left);
                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }
            Console.WriteLine();
        }

        public int GetHeight(TreeNode node)
        {
            // Height of an Empty Tree is -1.
            if (node == null) return -1;    

            int leftHeight = GetHeight(node.Left);
            int rightHeight = GetHeight(node.Right);
            return Math.Max(leftHeight, rightHeight) + 1;
        }

        public int GetDepth(TreeNode node, int value, int currentDepth = 0) 
        {
            if (node == null) return -1;
            if (node.Value == value)
                return currentDepth;
            else if (value < node.Value)
                return GetDepth(node.Left, value, currentDepth + 1);
            else
                return GetDepth(node.Right, value, currentDepth + 1);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            BinaryTree tree = new BinaryTree();
            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(70);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(60);
            tree.Insert(80);

            Console.WriteLine("InOrder Traversal:");
            tree.InOrderTraversal(tree.Root);

            Console.WriteLine("\nPreOrder Traversal:");
            tree.PreOrderTraversal(tree.Root);
            
            Console.WriteLine("\nPostOrder Traversal:");
            tree.PostOrderTraversal(tree.Root);

            Console.WriteLine("\nLevelOrder Traversal:");
            tree.LevelOrderTraversal();

            Console.WriteLine("Height of the Tree: " + tree.GetHeight(tree.Root));

            Console.WriteLine("Depth of node with Value 20 : " + tree.GetDepth(tree.Root, 20));
            Console.WriteLine("Depth of node with Value 70 : " + tree.GetDepth(tree.Root, 70));
            Console.WriteLine("Depth of node with Value 50 : " + tree.GetDepth(tree.Root, 50));

            Console.ReadKey();
        }
    }
}