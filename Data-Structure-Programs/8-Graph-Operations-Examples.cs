
Graph Data Structure:

	In this DS, Node can be connected to many other Nodes.
	
	In Graph, Traversal of Nodes can be done in DFS or BFS manner.
	
	DFS (Depth-First Search):
		We will be starting from one node & traversing in one branch covering all the nodes before coming to the next branch. (Here Varients can be PreOrder, InOrder, PostOrder)
	
	
	BFS (Breadth-First Search): 
		We will be covering all the nodes at the same level or at the same depth. 
		
/* ************************************************************* */


using System.Data;
using System.Collections;
using System.Xml.Linq;

namespace coreConsoleBasicApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int v, e;
            Console.Write("Enter Number of Vertices: ");
            int.TryParse(Console.ReadLine(), out v);

            Console.Write("Enter Number of Edges: ");
            int.TryParse(Console.ReadLine(), out e);

            int[] vertices = new int[v];
            int[,] edges = new int[v,v];
            bool[] visited = new bool[v];

            Console.WriteLine("Enter Edges: ");
            for (int i = 0; i < e; i++)
            {
                int s, d;
                string[] input = Console.ReadLine().Split(' ');
                int.TryParse(input[0], out s);
                int.TryParse(input[1], out d);
                edges[s, d] = 1;
                edges[d, s] = 1;
            }

            Console.WriteLine();

            // DFS:
            for (int i = 0; i < v; i++)
            {
                if (!visited[i])
                    DFS(edges, v, visited, i);
            }

            for (int i = 0; i < v; i++)
                visited[i] = false;
            {
                
            }

            Console.WriteLine();

            // BFS:
            for (int i = 0; i < v; i++)
            {
                if (!visited[i])
                    BFS(edges, v, visited, i);
            }


            Console.ReadKey();
        }

        private static void BFS(int[,] edges, int v, bool[] visited, int si)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(si);
            visited[si] = true;
            while (queue.Count != 0)
            {
                int currentVertex = queue.Dequeue();
                Console.Write(currentVertex + " ");
                for (int i = 0; i < v; i++)
                {
                    if (i == currentVertex)
                        continue;
                    if (!visited[i] && edges[currentVertex, i] == 1)
                    {
                        queue.Enqueue(i);
                        visited[i] = true;
                    }
                }
            }

        }

        private static void DFS(int[,] edges, int v, bool[] visited, int si)
        {
            visited[si] = true;
            Console.Write(si + " ");
            for (int i = 0; i < v; i++)
            {
                if(i == si)
                    continue;
                if (!visited[i] & edges[si, i] == 1)
                {
                    DFS(edges, v, visited, i);
                }
            }
        }
    }
}
		
	