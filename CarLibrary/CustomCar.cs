namespace CarLibrary
{
    using System.Collections.Generic;
    using System.Linq;

    public class CustomCar : ICar
    {
        private const int defaultTyreSize = 16;

        public int ProductionYear { get; }

        public CarBrand Brand { get; }

        private List<IWheel> Wheels { get; set; }

        public CustomCar()
        {
            Brand = new CarBrand();
            AddStandardPassengerCarWheels();
        }

        public int WheelsSizeInInch
        {
            get
            {
                return Wheels.First().TyreSizeInInch;
            }
        }

        public string WheelsRimManufacturer
        {
            get
            {
                return Wheels.First().RimManufacturer;
            }
        }

        public int WheelsCount
        {
            get
            {
                return Wheels.Count;
            }
        }

        private void AddStandardPassengerCarWheels()
        {
            Wheels = new List<IWheel>();

            for (int i = 0; i < 4; i++)
            {
                Wheels.Add(new Wheel("Nokian", "SuperWinterTyre", 2.4, defaultTyreSize, "Sparko"));
            }
        }
    }
}
