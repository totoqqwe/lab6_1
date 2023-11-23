using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Car : Vehicle
    {
        public Car()
        {
            Speed = 60; 
            Capacity = 5; 
        }

        public override void Move()
        {
            Console.WriteLine("Driving a car...");
        }
    }
}
