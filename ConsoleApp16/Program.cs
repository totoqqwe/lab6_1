using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bus bus = new Bus();
            Train train = new Train();

            Route route = new Route
            {
                StartPoint = "City A",
                EndPoint = "City B"
            };

            TransportNetwork transportNetwork = new TransportNetwork();
            transportNetwork.AddVehicle(car);
            transportNetwork.AddVehicle(bus);
            transportNetwork.AddVehicle(train);

            transportNetwork.MoveOnRoute(route);
        }
    }
}
