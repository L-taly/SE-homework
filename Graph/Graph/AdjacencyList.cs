using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public class AdjacencyList<T>
    {
        List<Vertex<T>> items;
        bool Isdirected;
        bool value;

        public AdjacencyList() : this(10,false,false) { }
        public AdjacencyList(int capacity,bool directed, bool value)
        {
            items = new List<Vertex<T>>(capacity);
        }
        public void AddVertex(T item)
        {
            if (Contains(item))
            {
                throw new ArgumentException("插入重复定点");
            }
            items.Add(new Vertex<T>(item));
        }

        public void AddEdge(T from, T to)
        {
            Vertex<T> fromVer = Find(from);
            if(fromVer == null)
            {
                throw new ArgumentException("头顶点不存在");
            }
            Vertex<T> toVer = Find(to);
            if(toVer == null)
            {
                throw new ArgumentException("尾顶点不存在");
            }
            AddDirectedEdge(fromVer, toVer);
            AddDirectedEdge(toVer, fromVer);
        }

        public Vertex<T> Find(T item)
        {
            foreach (Vertex<T> v in items)
            {
                if (v.data.Equals(item))
                {
                    return v;
                }
            }
            return null;
        }

        public void AddDirectedEdge(Vertex<T> fromVer, Vertex<T> toVer)
        {
            if(fromVer.firstEdge == null)
            {
                fromVer.firstEdge = new Node(toVer);
            }
            else
            {
                Node tmp, node = fromVer.firstEdge;
                do
                {
                    if (node.adjvex.data.Equals(toVer.data))
                    {
                        throw new ArgumentException("添加了重复边");
                    }
                    tmp = node;
                    node = node.next;
                } while (node != null);
                tmp.next = new Node(toVer);
            }
        }

        public override string ToString()
        {
            string s = string.Empty;
            foreach(Vertex<T> v in items)
            {
                s += v.data.ToString() + ":";
                if (v.firstEdge != null)
                {
                    Node tmp = v.firstEdge;
                    while (tmp != null)
                    {
                        s += tmp.adjvex.data.ToString();
                        tmp = tmp.next;
                    }
                }
                s += "\r\n";
            }
            return base.ToString();
        }

        public bool Contains(T item)
        {
            foreach(Vertex<T> v in items)
            {
                if (v.data.Equals(items))
                {
                    return true;
                }
            }
            return false;
        }

        public class Node
        {
            public Vertex<T> adjvex;
            public Node next;
            public Node(Vertex<T> value)
            {
                adjvex = value;
            }
        }

        public class Vertex<TValue>
        {
            public TValue data;
            public Node firstEdge;
            public Boolean visited;
            public Vertex(TValue value)
            {
                data = value;
            }
        }
    }   
}
