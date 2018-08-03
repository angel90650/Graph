using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class AdjacencyList
    {
        private List<int> [] list;
        private int numEdges;
        private int numVertices;
        private int size;

        public AdjacencyList(int size)
        {
            this.size = size;
            list = new List<int>[size];
            for(int i = 0; i < size; i++)
            {
                list[i] = new List<int>();
            }
            numEdges = 0;
            numVertices = 0;
        }

        public void AddEdge(int src, int dest)
        {
            if (src < size && dest < size)
            {
                if (list[src].Count == 0) numVertices++;
                if (list[dest].Count == 0) numVertices++;
                list[src].Add(dest);
                list[dest].Add(src);
                numEdges++;
            }
            else
            {
                throw new Exception("vectors are not within size of adjacency list");
            }
        }

        public void print()
        {
            Console.WriteLine("Printing Graph with " + numEdges + " edges and " + numVertices + " vertices");
            int src = 0;
            foreach(List<int> x in list)
            {
                if(x.Count != 0)
                {
                    foreach(int dest in x)
                    {
                        Console.WriteLine("Edge (" + src + " - " + dest + ")");
                    }
                }
                src++;
            }
        }
    }
}
