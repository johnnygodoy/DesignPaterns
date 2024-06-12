using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicles
{
    internal class Car : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando os passageiros");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos o trajeto");
        }
    }
}
