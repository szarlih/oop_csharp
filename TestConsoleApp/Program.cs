
namespace TestConsoleApp
{
    using CarLibrary;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            CarBrand marka = new CarBrand();

            CustomCar car = new CustomCar();
            Console.WriteLine(car.Brand);
        }
    }
}
