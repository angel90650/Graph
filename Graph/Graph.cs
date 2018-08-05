using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Graph
    {
        private List<int> [] list;
        private int numEdges;
        private int numVertices;
        private int size;

        public Graph(int size)
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
            if (src < size && dest < size && src >= 0 && dest >= 0)
            {
                if(list[src].Contains(dest))
                {
                    //Console.WriteLine("Already in the list :Edge (" + src + " - " + dest + ")");
                    return;
                }
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

        public void Print()
        {
            Console.WriteLine("Printing Graph with " + numEdges + " edges and " + numVertices + " vertices");
            int src = 0;
            foreach(List<int> x in list)
            {
                foreach (int dest in x)
                {
                    Console.WriteLine("Edge (" + src + " - " + dest + ")");
                }
                src++;
            }
        }
    }
}
