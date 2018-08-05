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
            int size = 10000;
            Graph graph = new Graph(size);
            //graph.AddEdge(15, 4);
            //graph.AddEdge(0, 2);
            //graph.AddEdge(1, 4);
            //graph.AddEdge(3, 4);
            //graph.AddEdge(4, 5);
            //graph.AddEdge(8, 4);
            //graph.AddEdge(4, 2);
            for(int i = 0; i < size; i++)
            {
                for(int y = 0; y < size; y++)
                {
                    graph.AddEdge(i, y);
                }
            }
            //graph.Print();

            Console.ReadLine();
                
        }
    }
}
