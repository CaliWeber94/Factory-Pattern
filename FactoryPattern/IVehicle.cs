using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Were building a new vehicle!");

        }
        
        
    }
}
