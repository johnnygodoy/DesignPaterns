using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.Lanvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.App
{
    internal class Application
    {
        private IArcraft aircraft; 
        private ILandvehicle vehicle;
        public Application(ITransportFactory factory)
        {
            aircraft = factory.CreateTransportAircraft();
            vehicle = factory.CreateTransportVehicle();            
        }

        public void StartRoute()
        {
            vehicle.StartRoute();
            aircraft.StartRoute();
        }
    }
}
