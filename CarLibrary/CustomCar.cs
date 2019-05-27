namespace CarLibrary
{
    using System.Collections.Generic;
    using System.Linq;

    public class CustomCar : ICar
    {
        private const int defaultTyreSize = 16;

        public int ProductionYear { get; }

        public CarBrand Brand { get; }

        public List<IWheel> Wheels { get; private set; }

        public CustomCar()
        {
            Brand = new CarBrand();
            AddStandardPassengerCarWheels();
        }

        public int WheelsSizeInInch
        {
            get
            {
                return Wheels.First().SizeInInch;
            }
        }

        private void AddStandardPassengerCarWheels()
        {
            Wheels = new List<IWheel>();

            for (int i = 0; i < 4; i++)
            {
                Wheels.Add(new Tyre("Nokian", "SuperWinterTyre", 2.4, defaultTyreSize));
            }
        }
    }
}
