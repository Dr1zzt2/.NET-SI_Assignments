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
            Employee potatoMan = new Employee(randomRoom, 10.05m, "Gardener", "János a krumpliember", DateTime.Now, "Male");
            Employee poMan2 = (Employee)potatoMan.Clone();
            poMan2.Room.Number = 112;
            Console.WriteLine(potatoMan.ToString());
            Console.WriteLine(poMan2.ToString());
            Console.ReadKey();
        }
    }
}
