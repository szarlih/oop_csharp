namespace CarLibrary
{
    using System.Collections.Generic;

    public class Truck : Car
    {
        private const int defaultTyreSize = 22;

        public Truck()
        {
            Brand = new CarBrand();
            AddStandardPassengerCarWheels();
        }

        private void AddStandardPassengerCarWheels()
        {
            Wheels = new List<IWheel>();

            for (int i = 0; i < 6; i++)
            {
                Wheels.Add(
                    new Wheel(
                        new Tyre("Nokian", "SuperWinterTyre", 3.6, defaultTyreSize),
                        new Rim("Volvo", defaultTyreSize)));
            }
        }
    }
}
