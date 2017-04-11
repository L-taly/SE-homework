using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    public class BinaryTreeNode
    {
        private object _data;
        private BinaryTreeNode _left;
        private BinaryTreeNode _right;
        public object Data
        {
            get { return _data; }
        }

        public BinaryTreeNode Left
        {
            get { return _left; }
            set { _left = value; }
        }

        public BinaryTreeNode Right
        {
            get { return _right; }
            set { _right = value; }
        }

        public BinaryTreeNode(object data)
        {
            _data = data;
        }

        public override string ToString()
        {
            return _data.ToString();
        }
    }
}
