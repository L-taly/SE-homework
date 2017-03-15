using System;
using System.Collections.Generic;
using System.Text;

namespace skiplist1
{
    class singleList
    {
        private GraphNode[] nodeList;
        private int count;

        public singleList(int size)
        {
            nodeList = new GraphNode[size];
            count = 0;
        }

        public singleList() : this(20)
        {

        }
        public void Add(string value, int key)
        {
            Console.WriteLine("singlelist is OK");
            GraphNode node = new GraphNode(value);
            node.Key = key;
            if (count == 0)
            {
                nodeList[0] = node;
            }
            else
            {
                int f = 1;
                for (int i = 0; i < count; i++)
                {
                    if (node.Key < nodeList[i].Key)
                    {
                        f = 0;
                        for (int j = count - 1; j >= i; j--)
                        {
                            nodeList[j + 1] = nodeList[j];
                        }
                        nodeList[i] = node;
                        break;
                    }
                }
                if (f == 1)
                {
                    nodeList[count] = node;
                }

            }
            count++;
        }
        public GraphNode Delete(string value)
        {
            GraphNode newnode = new GraphNode();
            newnode = default(GraphNode);
            for (int i = 0; i < count; i++)
            {
                if (nodeList[i].Name == value)
                {
                    newnode = nodeList[i];
                    for (int j = i; j <= count - 2; j++)
                    {
                        nodeList[j] = nodeList[j + 1];
                    }
                    nodeList[count - 1] = default(GraphNode);
                    count--;
                    break;
                }
            }
            return newnode;
        }
        public int Find(string value)
        {
            for (int i = 0; i < count; i++)
            {
                if (nodeList[i].Name == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public void Print()
        {
            for (int i = 0; i < nodeList.Length; i++)
            {
                try
                {
                    string str = nodeList[i].Name;
                    Console.Write(str);
                }
                catch (Exception e)
                {
                    Console.Write("         ");
                }
            }
        }
        //public void Clear()
        //{
        //    nodeList = new singleList();
        //}
    }
}
