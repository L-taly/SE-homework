using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    public class MaltiTree
    {
        private object _name;
        private int _nodechildren;
        private int _level = -1;
        List<MaltiTree> _children;
        public MaltiTree()
        {
            _children = new List<MaltiTree>();
        }

        public object Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Nchildren
        {
            get { return _nodechildren; }
            set { _nodechildren = value; }
        }

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public List<MaltiTree> Children
        {
            get {return _children; }
            set { _children = value; }
        }
    }
}
