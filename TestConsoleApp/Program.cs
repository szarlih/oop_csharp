
namespace TestConsoleApp
{
    using CarLibrary;
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            CarBrand brand = new CarBrand();

            CustomCar car = new CustomCar();
            Console.WriteLine(car.Brand);
            Console.WriteLine("car have {0} {1}-inch wheels", car.Wheels.Count, car.WheelsSizeInInch);
            Console.ReadKey();
        }
    }
}
