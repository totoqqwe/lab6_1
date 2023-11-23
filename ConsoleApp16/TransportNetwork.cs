using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class TransportNetwork
    {
        private List<Vehicle> vehicles;

        public TransportNetwork()
        {
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void MoveOnRoute(Route route)
        {
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle with capacity {vehicle.Capacity} is moving from {route.StartPoint} to {route.EndPoint}.");
                vehicle.Move();
            }
        }
    }
}
