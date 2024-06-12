using System;

namespace AbstractFactory.Lanvehicles
{
    internal class Motorcycle : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega.");
          
        }
    }
}
