using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Bus : Vehicle
    {
        public Bus()
        {
            Speed = 40;
            Capacity = 20;
        }

        public override void Move()
        {
            Console.WriteLine("Riding a bus...");
        }
    }
}
