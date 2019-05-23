using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Room
    {
        public int Number { get; private set; }

        public Room(int number)
        {
            Number = number;
        }
    }
}
