using System;
using System.Collections.Generic;
using System.Text;

namespace skiplist1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool F = true;
            skipList skipList = new skipList(4, 20);
            Console.ReadKey();
            Console.WriteLine("Function list(The default list:length:20,level:4):");
            Console.WriteLine("Create a new skipList------------------------1");
            Console.WriteLine("Add a node-----------------------------------2");
            Console.WriteLine("Delete a single node-------------------------3");
            Console.WriteLine("Delete whole line nodes----------------------4");
            Console.WriteLine("Find a node----------------------------------5");
            Console.WriteLine("Print the skipList---------------------------6");
            Console.WriteLine("Quit-----------------------------------------7");
            while (F)
            {
                Console.Write("Please choose function :");
                int Function_num = int.Parse(Console.ReadLine());
                switch (Function_num)
                {
                    case 1:
                        Console.Write("Input the length:");
                        int length = int.Parse(Console.ReadLine());
                        Console.Write("Input teh level:");
                        int level = int.Parse(Console.ReadLine());
                        skipList = new skipList(level, length);
                        break;
                    case 2:
                        Console.Write("Input the value:");
                        string value = Console.ReadLine();
                        Console.Write("Input the key:");
                        int key = int.Parse(Console.ReadLine());
                        Console.Write("Input the level:");
                        int Level = int.Parse(Console.ReadLine());
                        skipList.Add(value, key, Level);
                        break;
                    case 3:
                        Console.Write("Input the value:");
                        string value_delete = Console.ReadLine();
                        Console.Write("Input the level:");
                        int level_deletel = int.Parse(Console.ReadLine());
                        Console.WriteLine(skipList.singleDelete(value_delete, level_deletel) + "        deleted");
                        break;
                    case 4:
                        Console.Write("Input the value:");
                        string Value_delete = Console.ReadLine();
                        skipList.wholeDelete(Value_delete);
                        break;
                    case 5:
                        Console.Write("Input the value:");
                        string value_find = Console.ReadLine();
                        skipList.Find(value_find);
                        break;
                    case 6:
                        skipList.Print();
                        break;
                    case 7:
                        F = false;
                        break;
                    case 8:
                        Console.WriteLine("Please input the key:");
                        int Kkey = int.Parse(Console.ReadLine());
                        skipList.keyFind(Kkey);
                        break;
                    default:
                        Console.WriteLine("Wrong Input!");
                        break;
                }

            }

        }
    }
}