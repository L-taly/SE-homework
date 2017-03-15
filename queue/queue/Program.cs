using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Function List");
            Console.WriteLine("New Queue                    1");
            Console.WriteLine("Enqueue                      2");
            Console.WriteLine("Dequeue                      3");
            Console.WriteLine("Find                         4");
            Console.WriteLine("Delete                       5");
            Console.WriteLine("Print                        6");
            Console.WriteLine("Clear                        7");
            Console.WriteLine("Quit                         8");
            bool F = true;
            IQueue<string> queue = new SeqQueue<string>(10);
            while (F)
            {
                Console.Write("Choose Functiom:");
                int function_input = int.Parse(Console.ReadLine());

                switch (function_input)
                {
                    case 1:
                        Console.Write("Input the length:");
                        int n = int.Parse(Console.ReadLine());
                        queue = new SeqQueue<string>(n);
                        break;
                    case 2:
                        string value;
                        int k;
                        Console.WriteLine("Input Key:");
                        k = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input Value:");
                        value = Console.ReadLine();
                        queue.Enqueue(value, k);
                        Console.ReadKey();
                        break;
                    case 3:
                        queue.Dequeue();
                        break;
                    case 4:
                        Console.Write("Please input the value");
                        int answer = queue.Find(Console.ReadLine());
                        Console.WriteLine(answer);
                        break;
                    case 5:
                        Console.Write("Please input the value");
                        queue.Delete(Console.ReadLine());
                        break;
                    case 6:
                        queue.Print();
                        break;
                    case 7:
                        queue.Clear();
                        break;
                    case 8:
                        F = false;
                        break;
                    default:
                        Console.WriteLine("Wrong Input!");
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
