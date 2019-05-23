using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Thanks for all the fish!";
            string[] words = str.Split(' ');
            Array.Sort(words);
            string sorted = string.Join("X", words);
            Console.WriteLine(sorted);
            Console.ReadKey();
        }
    }
}
