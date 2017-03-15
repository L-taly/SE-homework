using System;
using System.Collections.Generic;
using System.Text;

namespace skiplist1
{
    class skipList
    {
        private singleList[] wholeList;
        private int level;
        public skipList(int level, int length)
        {
            this.level = level;
            wholeList = new singleList[level];
            for (int i = 0; i < level; i++)
            {
                wholeList[i] = new singleList(length);
            }

        }
        public skipList() : this(4, 20)
        {

        }
        public void Add(string value, int key, int level)
        {
            Console.WriteLine("skiplist is OK");
            for (int i = 0; i < level; i++)
            {
                wholeList[i].Add(value, key);
            }
        }
        public string singleDelete(string value, int level)
        {
            wholeList[level - 1].Delete(value);
            return value;
        }
        public void wholeDelete(string value)
        {
            for (int i = 0; i < level; i++)
            {
                Console.WriteLine(wholeList[i].Delete(value) + "        deleted");
            }
        }
        public void Find(string value)
        {
            int j = 0;
            for (int i = level - 1; i >= 0; i--)
            {
                int n = wholeList[i].Find(value);

                if (n != -1)
                {
                    Console.WriteLine("Find " + value + " int leve " + i + " num " + n);
                    j = 1;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("None！");
            }
        }
        public void Print()
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write("Level " + i + " line list:");
                wholeList[i].Print();
                Console.WriteLine();
            }
        }
    }
}
