using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GraphComponent
    {
        /*
            -> Một đồ thị được gọi là liên thông ( connected ) nếu có đường đi giữa mọi cặp đỉnh phân biệt của đồ thị
            -> Nói cách khác là từ một đỉnh có thể có đường đi tới tất cả các đỉnh khác
            -> Directed or undirected same as meaning
         */
        /*
            -> Nếu xét về có hướng ( directed ) : sẽ có 2 khái niệm
            -> Liên thông mạnh ( strongly connected ) : Nếu có đường đi từ A -> B và từ B -> A với mọi cặp đỉnh A,B của G
            -> Liên thông yếu ( weakly connected ): Nếu có đường đi giữa 2 đỉnh bất kỳ của đồ thị vô hướng tương ứng với đồ thị đã cho. 
                Tức là hủy bỏ các hướng của các cạnh trong đồ thị
            -> Liên thông một phần (unilaterally connected): Nếu với mọi cặp đỉnh a, b bất kỳ, có ít nhất một đỉnh đến được đỉnh còn lại.
         */

        /* Vậy check G có liên thông không chỉ cần check value của mảng visited có đủ giá trị không ? Có đủ tức là có đường đi giữa tất cả các đỉnh thì liên thông*/

        private LinkedList<int>[] adjList;
        private int nVertex;
        static int c = 0;
        LinkedList<int>[] res = new LinkedList<int>[100];


        public LinkedList<int>[] AdjList { get; set; }
        public int NVertex { get; set; }

        public GraphComponent()
        {

        }

        public void ReadGraph()
        {

            NVertex = int.Parse(Console.ReadLine());
            AdjList = new LinkedList<int>[NVertex + 1];
            for (int i = 1; i < NVertex + 1 ; i++)
            {
                AdjList[i] = new LinkedList<int>();
                string tmp = Console.ReadLine();
                if (tmp.Trim().Length == 0 )
                {
                    continue;
                }
                string[] tokens = tmp.Split(' ');
                for (int j = 0; j < tokens.Length; j++)
                {
                    if (tokens[j] == " ")
                    {
                        continue;
                    }
                    AdjList[i].AddLast(int.Parse(tokens[j]));
                }
            }

        }

        

        public void WriteResult(string path, bool flag)
        {

            if (flag)
                Console.Write("YES");
            else
                Console.Write("NO");

        }



        public void DFS_Util(int v, bool[] visited)
        {
            visited[v] = true;
            //Console.Write(v + " ");
            res[c].AddLast(v);
            foreach (int x in AdjList[v - 1])
            {
                //if (x == null ) continue;
                if (visited[x] == false)
                    DFS_Util(x, visited);
            }
        }

        // DFS version
        public int CountConnectedComponents()
        {
            bool[] visited = new bool[NVertex + 1];
            int count = 0;
            for (int i = 1; i < NVertex + 1; i++)
                visited[i] = false;
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = new LinkedList<int>();
            }


            for (int i = 1; i < NVertex + 1; i++)
            {
                if (visited[i] == false)
                {
                    DFS_Util(i, visited);
                    c++;
                    count++;
                }
            }
            return count;
        }

        public int PrintAllConnectedComponents()
        {

            //Console.WriteLine(CountConnectedComponents());
            //foreach (LinkedList<int> x in res)
            //{
            //    foreach (int z in x)
            //    {
            //        Console.Write(z + " ");
            //    }
            //        Console.WriteLine();
            //}
            return CountConnectedComponents();
        }

        static bool[] visited;

        public void DFS_Visit(int s)
        {
          
            visited[s] = true;
            
            foreach(int v in AdjList[s])
            {
                //if (v > s) continue;
                if (visited[v] == false)
                    DFS_Visit(v);
            }
        }

        public bool CheckIsConnected()
        {
            bool[] visited = new bool[NVertex];
            int i = 1;
            for (int j = 0; j < NVertex; j++)
                visited[j] = false;
            Queue<int> q = new Queue<int>();
            q.Enqueue(i);
            visited[i] = true;

            while (q.Count != 0)
            {
                int u = q.Dequeue();

                foreach (int v in AdjList[u])
                {
                    if (visited[v]) continue;
                    visited[v] = true;
                }
            }
            for (int x = 1; x <= visited.Length - 1; x++)
            {
                if (visited[x] == false)
                    return false;
            }
            return true;
        }


    }

    
    class Program
    {
        static void Main(string[] args)
        {
            GraphComponent graphComponent = new GraphComponent();
            graphComponent.ReadGraph();
            if (graphComponent.CheckIsConnected())
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
        }
    }
}
