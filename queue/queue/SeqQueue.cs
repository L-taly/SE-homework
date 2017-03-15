using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    class SeqQueue<T> : IQueue<T>
    {
        private T[] data;
        private int[] KeyList;
        private int count;

        public SeqQueue(int size)
        {
            data = new T[size];
            KeyList = new int[size];
            count = 0;
        }
        public SeqQueue() : this(10)
        {

        }
        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Clear()
        {
            count = 0;
        }

        public T Dequeue()
        {
            if (count > 0)
            {
                T temp = data[count];
                count--;
                return temp;
            }
            else
            {
                Console.WriteLine("队列为空");
                return default(T);
            }
        }

        public void Enqueue(T item, int key)
        {
            if (count == data.Length)
            {
                Console.WriteLine("队列已满");
            }
            else
            {
                if (count == 0)
                {
                    KeyList[0] = key;
                    Console.WriteLine(KeyList[0]);
                    data[0] = item;
                    Console.WriteLine(data[0]);
                    count++;
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (key <= KeyList[i])
                        {
                            for (int j = count; j > i - 1; j--)
                            {
                                KeyList[j + 1] = KeyList[j];
                                data[j + 1] = data[j];
                            }
                            KeyList[i] = key;
                            data[i] = item;
                            break;
                        }
                        if (key > KeyList[i] && i == count - 1)
                        {
                            KeyList[count] = key;
                            data[count] = item;
                        }
                    }
                    count++;
                }
            }
        }

        public int GetLength()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public T Delete(T item)
        {
            int m = count;
            T x = default(T);
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(item))
                {
                    m = i;
                    x = data[m];
                }
                if (i == count - 1)
                {
                    return default(T);
                }
            }
            for (int i = m; i < count - 1; i++)
            {
                data[i] = data[i + 1];
                KeyList[i] = KeyList[i + 1];
            }
            return x;
        }
        public T Delete(int keylevel)
        {
            if (keylevel > count - 1)
            {
                return default(T);
            }
            T item = data[keylevel - 1];
            for (int i = keylevel; i < count - 1; i++)
            {
                data[i] = data[i + 1];
                KeyList[i] = KeyList[i + 1];
            }
            return item;
        }
        public int Find(T item)
        {
            /*for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;*/
            return data.ToList().IndexOf(item);
        }
        /*public int Find(int keynum)
        {
            for (int i = 0; i < count; i++)
            {
                if (KeyList[i] == keynum)
                {
                    return i;
                }
            }
            return -1;
        }*/
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(data[i] + "   ");
            }
            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                Console.Write(KeyList[i] + "   ");
            }
            Console.WriteLine();
            Console.Write("Length is ");
            Console.WriteLine(count);
        }
    }
}
