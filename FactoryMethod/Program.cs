﻿using FactoryMethod.Factories;
using FactoryMethod.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport transport = null;

            if (args.Length > 0 && args[0] == "--uber")
            {
               transport = new CarTransport();
            }
            else if (args.Length > 0 && args[0] == "--log")
            {
                transport = new MotorcycleTransport();
            }
            else if ((args.Length > 0 && args[0] == "--uberEats"))
            {
                transport = new BikeTransport();
            }
            else
            {
                Console.WriteLine("Selecione o tipo de serviço.");
            }

            if (transport != null)
            {
                transport.StartTransport();
            }

            Console.ReadLine();
        }
    }
}
