using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicles
{
    internal class Bike :IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando a comida");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos o trajeto");
        }
    }
}
