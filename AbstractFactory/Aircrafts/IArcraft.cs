using System;

namespace AbstractFactory.Aircrafts
{
    internal interface IArcraft
    {
        void CheckWind();
        void StartRoute();
        void GetCargo();
    }
}
