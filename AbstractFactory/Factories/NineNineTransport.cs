using AbstractFactory.Aircrafts;
using AbstractFactory.Lanvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class NineNineTransport : ITransportFactory
    {
        public IArcraft CreateTransportAircraft()
        {
            return new Helicopter();
        }

        public ILandvehicle CreateTransportVehicle()
        {
            return new Motorcycle();
        }
    }
}
