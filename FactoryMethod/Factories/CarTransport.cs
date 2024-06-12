using FactoryMethod.Vehicles;


namespace FactoryMethod.Factories
{
    internal class CarTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Car();
        }
    }
}
