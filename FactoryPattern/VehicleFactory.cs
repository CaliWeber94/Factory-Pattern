using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string VehicleType)
        {
            switch (VehicleType)
            {
                case "two wheels":
                    return new Motorcycle();
                case "four wheels":
                    return new Car();
                default:
                    return new Car();
            }

        }
    }
}
