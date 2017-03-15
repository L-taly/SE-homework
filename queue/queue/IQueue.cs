using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    interface IQueue<T>
    {
        int Count { get; }
        int GetLength();
        bool IsEmpty();
        void Clear();
        void Enqueue(T item, int key);
        T Dequeue();
        T Delete(T item);
        T Delete(int keylevel);
        int Find(T item);
        //int Find(int keynum);
        void Print();
    }
}
