using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    public class BinaryTree
    {
        private BinaryTreeNode _head;
        private string cStr;
        public BinaryTreeNode Head
        {
            get { return _head; }
        }
        public BinaryTree (string constructStr)
        {
            cStr = constructStr;
            _head = new BinaryTreeNode(cStr[0]);
            Add(_head, 0);
        }

        private void Add(BinaryTreeNode parent, int index)
        {
            int leftIndex = 2 * index + 1;
            if(leftIndex < cStr.Length)
            {
                if (cStr[leftIndex] != '#')
                {
                    parent.Left = new BinaryTreeNode(cStr[leftIndex]);
                    Add(parent.Left, leftIndex);
                }
            }
            int rightIndex = 2 * index + 2;
            if(rightIndex < cStr.Length)
            {
                if (cStr[rightIndex] != '#')
                {
                    parent.Right = new BinaryTreeNode(cStr[rightIndex]);
                    Add(parent.Right, rightIndex);
                }
            }
        }
    }
}
