using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 20;
            AdjacencyList graph = new AdjacencyList(size);
            graph.AddEdge(15, 4);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 4);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 5);
            graph.AddEdge(8, 4);
            graph.AddEdge(4, 2);
            graph.print();

            Console.ReadLine();
                
        }
    }
}
