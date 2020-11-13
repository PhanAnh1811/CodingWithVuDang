using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    class Program
    {
        static int[,] adjMatrix;
        static int nVertex;
        static int nEdge;
        static LinkedList<int>[] adjList;
        static LinkedList<Tuple<int,int>> edgeList;
        
        static void ReadData_AdjMatrix(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                nVertex = int.Parse(reader.ReadLine());
                adjMatrix = new int[nVertex, nVertex];
                for(int i = 0; i < nVertex; i++)
                {
                    string[] tokens = reader.ReadLine().Split();
                    for (int j = 0; j < nVertex; j++)
                        adjMatrix[i, j] = int.Parse(tokens[j]);
                }
            }
        }

        static void WriteData_AdjMatrix(string filePath)
        {
            using(StreamWriter writer=new StreamWriter(filePath))
            {
                writer.WriteLine(nVertex);
                for(int i = 0; i < nVertex; i++)
                {
                    for (int j = 0; j < nVertex; j++)
                        writer.Write(adjMatrix[i, j] + " ");
                    writer.WriteLine();
                }
            }
        }

        /*Bai 1. Bậc của đồ thị vô hướng*/
        static void FindAllDegree(string filePath)
        {
            using(StreamWriter writer=new StreamWriter(filePath))
            {
                writer.WriteLine(nVertex);
                for(int i = 0; i < nVertex; i++)
                {
                    int degree = 0;
                    for(int j = 0; j < nVertex; j++)
                    {
                        if (adjMatrix[i, j] == 1)
                            degree++;
                    }
                    writer.Write(degree + " ");
                }
            }
        }

        /*Bài 2. Bậc vào, bậc ra*/
        static void FindInAndOutDegree(string filePath)
        {
            using(StreamWriter writer=new StreamWriter(filePath))
            {
                writer.WriteLine(nVertex);
                for(int i = 0; i < nVertex; i++)
                {
                    int inDegree = 0, outDegree = 0;
                    for(int j = 0; j < nVertex; j++)
                    {
                        if (adjMatrix[j, i] > 0)
                            inDegree++;
                        if (adjMatrix[i, j] > 0)
                            outDegree++;
                    }
                    writer.WriteLine(inDegree + " " + outDegree);
                }
            }
        }

        /*Bài 3. Danh sách kề*/
        static void ReadData_AdjencyList(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                nVertex = int.Parse(reader.ReadLine());
                adjList = new LinkedList<int>[nVertex];
                for (int i = 0; i < nVertex; i++)
                {
                    string[] tokens = reader.ReadLine().Split();
                    adjList[i] = new LinkedList<int>();
                    for (int j = 0; j < tokens.Length; j++)
                    {
                        if (tokens[j] == " ") continue;
                        adjList[i].AddLast(int.Parse(tokens[j]) - 1);
                    }
                }

            }
        }
        static void WriteData_AdjencyList(string filePath)
        {
            using(StreamWriter writer=new StreamWriter(filePath))
            {
                writer.WriteLine(nVertex);
                foreach(var x in adjList)
                {
                    writer.Write(x.Count + " ");
                }
            }
        }


        static void ReadData_EdgeList(string path)
        {
            using(StreamReader sr = new StreamReader(path))
            {
                string[] tokens = sr.ReadLine().Split(' ');
                nVertex = int.Parse(tokens[0]);
                nEdge = int.Parse(tokens[1]);
                edgeList = new LinkedList<Tuple<int, int>>();
                for (int i = 0; i < nEdge; i++)
                {
                    tokens = sr.ReadLine().Split(' ');
                    int x = int.Parse(tokens[0]) - 1;
                    int y = int.Parse(tokens[1]) - 1;
                    edgeList.AddLast(new Tuple<int, int>(x, y));
                }

            }
            Console.WriteLine(edgeList);
        }
        static void Main(string[] args)
        {
            /*Bai 1*/
            //ReadData_AdjMatrix("BacDoThiVoHuong.INP.txt");
            //WriteData_AdjMatrix("BacDoThiVoHuong.OUT.txt");
            //FindAllDegree("BacDoThiVoHuong.OUT.txt");

            /*Bai 2*/
            //ReadData_AdjMatrix("BacVaoRa.INP.txt");
            //FindInAndOutDegree("BacVaoRa.OUT.txt");

            /*Bai 3*/
            ReadData_AdjencyList("DanhSachKe.INP.txt");
            WriteData_AdjencyList("DanhSachKe.OUT.txt");
            Console.WriteLine("Successful");
            ReadData_EdgeList("DANHSACHCANH.INP.txt");
        }
    }
}
