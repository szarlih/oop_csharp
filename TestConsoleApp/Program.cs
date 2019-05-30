
namespace TestConsoleApp
{
    using CarLibrary;
    using System;
    using System.Linq;
    using Autofac;

    class Program
    {
        static IContainer container;
        static void Main(string[] args)
        {
            LoadObjects();
            using (var scope = container.BeginLifetimeScope())
            {
                Console.WriteLine("Hello World!");

                CarBrand brand = container.Resolve<CarBrand>();

                CustomCar car = container.Resolve<CustomCar>();
                IRim rim = container.Resolve<Rim>();
                ITyre tyre = container.Resolve<ITyre>();

                IWheel wheel = container.Resolve<IWheel>(new TypedParameter(typeof(IRim), rim), new TypedParameter(typeof(ITyre), tyre));

                Console.WriteLine(car.Brand);
                Console.WriteLine("car have {0} {1}-inch wheels with {2} rims", car.WheelsCount, car.WheelsSizeInInch, car.WheelsRimManufacturer);

                var truck = new Truck();
                Console.WriteLine("truck have {0} {1}-inch wheels with {2} rims", truck.WheelsCount, truck.WheelsSizeInInch, truck.WheelsRimManufacturer);
                Console.ReadKey();
            }
        }

        private static void LoadObjects()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<CarBrand>();
            builder.RegisterType<CustomCar>();
            builder.RegisterType<Rim>()
                .WithParameter(
                    new NamedParameter("sizeInInch", 17))
                .WithParameter(
                    new NamedParameter("manufacturer", "NewManufacturer"));
            builder.RegisterType<Tyre>()
                .AsImplementedInterfaces()
                .WithParameter("manufacturer", "Sparko")
                .WithParameter("model", "TurboWinter")
                .WithParameter("sizeInInch", 17)
                .WithParameter("pressureInBar", 2.4);
            builder.RegisterType<Wheel>().AsImplementedInterfaces();

            container = builder.Build();
        }
    }
}
