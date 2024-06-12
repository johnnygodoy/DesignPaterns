
namespace Builder.Components
{
    class Engine
    {
        private double power;
        public double Power
        {
            get => power; set => power = value;
        }

        public Engine(double power)
        {
            this.power = power;
        }       
    }
}
