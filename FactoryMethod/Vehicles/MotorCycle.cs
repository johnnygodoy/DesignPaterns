﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicles
{
    internal class MotorCycle : IVehicle
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
