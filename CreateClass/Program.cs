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
            Room randomRoom = new Room(42);
            Person potatoMan = new Employee(randomRoom, 10.05m, "Gardener", "János a krumpliember", DateTime.Now, "Male");
            Console.WriteLine(potatoMan.ToString());
            Console.ReadKey();
        }
    }
}
