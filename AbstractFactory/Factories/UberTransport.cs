using AbstractFactory.Aircrafts;
using AbstractFactory.Lanvehicles;

namespace AbstractFactory.Factories
{
    class UberTransport : ITransportFactory
    {
        public IArcraft CreateTransportAircraft()
        {
            return new Airplane();
        }

        public ILandvehicle CreateTransportVehicle()
        {
            return new Car();
        }
    }
}
