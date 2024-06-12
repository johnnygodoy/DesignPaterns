using System;


namespace AbstractFactory.Lanvehicles
{
    internal class Car : ILandvehicle
    {
        public void GetCargo()
        {
            
            Console.WriteLine("Pegamos os passageiros, estamos prontos!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto.");
        }
    }
}
