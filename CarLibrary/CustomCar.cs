﻿namespace CarLibrary
{
    using System.Collections.Generic;

    public class CustomCar : Car
    {
        private const int defaultTyreSize = 16;

        public CustomCar()
        {
            Brand = new CarBrand();
            AddStandardPassengerCarWheels();
        }

        private void AddStandardPassengerCarWheels()
        {
            Wheels = new List<IWheel>();

            for (int i = 0; i < 4; i++)
            {
                Wheels.Add(
                    new Wheel(
                        new Tyre("Nokian", "SuperWinterTyre", 2.4, defaultTyreSize), 
                        new Rim("Sparko", defaultTyreSize)));
            }
        }
    }
}
