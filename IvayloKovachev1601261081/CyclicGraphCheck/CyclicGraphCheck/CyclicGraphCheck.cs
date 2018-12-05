using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicGraphCheck
{
    using System;

    public class CyclicGraphCheck
    {
        private const int VerticesCount = 14;

        private static readonly byte[,] Graph = new byte[VerticesCount, VerticesCount]
        {
            { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1 },
            { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
            { 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0 }
        };

        private static readonly bool[] Used = new bool[VerticesCount];
        private static bool isCyclicGraph = false;

        internal static void Main()
        {
            for (int i = 0; i < VerticesCount; i++)
            {
                if (!Used[i])
                {
                    Dfs(i, -1);
                }

                if (isCyclicGraph)
                {
                    return;
                }
            }
            
            Console.WriteLine("������ � ����� (�� ������� �����)!");
            
        }
       

        // ����������� Depth-First-Search
        private static void Dfs(int vertex, int parent)
        {
            Used[vertex] = true;
            for (int i = 0; i < VerticesCount; i++)
            {
                if (isCyclicGraph)
                {
                    return;
                }

                if (Graph[vertex, i] == 1)
                {
                    if (Used[i] && i != parent)
                    {
                        Console.WriteLine("������ � ��������!");
                        isCyclicGraph = true;
                        return;
                    }
                    else if (i != parent)
                    {
                        Dfs(i, vertex);

                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                    }
                }
            }
            
        }
        
    }
  
}
