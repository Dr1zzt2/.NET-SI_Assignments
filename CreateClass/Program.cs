using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person potatoMan = new Employee(10.05m, "Gardener", "János a krumpliember", DateTime.Now, "Male");
            Console.WriteLine(potatoMan.ToString());
            Console.ReadKey();
        }
    }
}
