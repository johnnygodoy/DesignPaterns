using AbstractFactory.Aircrafts;
using AbstractFactory.Lanvehicles;
using System;


namespace AbstractFactory.Factories
{
    class LimeTransport : ITransportFactory
    {
        public IArcraft CreateTransportAircraft()
        {
            return new Drones();
        }

        public ILandvehicle CreateTransportVehicle()
        {
            return new Patinete();
        }
    }
}
