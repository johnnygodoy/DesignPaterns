using Builder.Builders;
using Builder.Directors;
using Builder.Products;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();
            Director directors = new Director(builder);


            directors.ConstructSedanCar();

            Vehicle sedan = builder.GetVehicle();

            Console.WriteLine($"Criado um veículo do tipo {sedan.VehicleType}");

            directors.ConstructTruck();

            Vehicle truck = builder.GetVehicle();

            Console.WriteLine($"Criado um veículo do tipo {truck.VehicleType}");
                       
            directors.ConstructSUV();

            Vehicle suv = builder.GetVehicle();
            Console.WriteLine($"Criado um veículo do tipo {suv.VehicleType}");

            Console.ReadLine();

        }
    }
}