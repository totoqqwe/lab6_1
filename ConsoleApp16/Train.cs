using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Train : Vehicle
    {
        public Train()
        {
            Speed = 100;
            Capacity = 200;
        }

        public override void Move()
        {
            Console.WriteLine("Riding a train...");
        }
    }
}
