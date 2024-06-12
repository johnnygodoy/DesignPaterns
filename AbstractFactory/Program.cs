using AbstractFactory.App;
using AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static Application ConfigureApplication()
        {
            Application app;

            ITransportFactory transportFactory;

            string company = "Lime";

            if (company == "Uber")
            {
                transportFactory = new UberTransport();
            }
            else if (company == "Lime")
            {
                transportFactory = new LimeTransport();
            }
            else
            {
                transportFactory = new NineNineTransport();
            }

            app = new Application(transportFactory);

            return app;
        }
        static void Main(string[] args)
        {
            Application app = ConfigureApplication();

            app.StartRoute();

            Console.ReadLine();
        }
    }
}
