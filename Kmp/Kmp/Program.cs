using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kmp
{
    class Program
    {
        static void Main(string[] args)
        {
            string text_string, pattern_string;
            Console.Write("Please input the text string:");
            text_string = Console.ReadLine();
            Console.Write("Please input the pattern string:");
            pattern_string = Console.ReadLine();
            Console.WriteLine("Text string:" + text_string);
            Console.WriteLine("Pattern string:" + pattern_string);
            int len2 = pattern_string.Length;
            int[] M = new int[len2];
            M[0] = 0;
            for (int i = 1; i < len2; i++)
            {
                for (int j = 1; j <= (i + 1) / 2; j++)
                {
                    string prestr = pattern_string.Substring(0, 0 + j);
                    string poststr = pattern_string.Substring(i - j + 1, j);
                    if (prestr.Contains(poststr))
                    {
                        M[i] = j;
                    }
                }
            }
            int len1 = text_string.Length;
            int l = -1;
            for (int i = 0; i <= len1 - len2; i++)
            {
                int j = 0;
                while (text_string.Substring(i, j + 1) == pattern_string.Substring(0, j + 1))
                {
                    j++;
                    if (j + 1 == len2)
                    {
                        l = i;
                        break;
                    }
                }
                if (l != -1) { break; }
                else
                {
                    i = i + j - M[j];
                }
            }
            if (l == -1)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine("The matching position is:" + l);
            }
            Console.ReadKey();
        }
    }
}
