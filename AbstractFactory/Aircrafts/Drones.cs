using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    internal class Drones : IArcraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos a 5km, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("pegando a encomenda, ligando as hélices.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem...");
        }
    }
}
