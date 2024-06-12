using AbstractFactory.Aircrafts;
using AbstractFactory.Lanvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    interface ITransportFactory
    {
        IArcraft CreateTransportAircraft();
        ILandvehicle CreateTransportVehicle();
    }
}
