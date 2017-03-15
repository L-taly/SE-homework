using System;
using System.Collections.Generic;
using System.Text;

namespace skiplist1
{
    class GraphNode
    {
        private int key;
        private string name;

        public int Key
        {
            set { key = value; }
            get { return key; }
        }

        public string Name
        {
            get { return name; }
        }

        public GraphNode()
        {

        }

        public GraphNode(string Name)
        {
            this.name = Name;
        }
    }
}
