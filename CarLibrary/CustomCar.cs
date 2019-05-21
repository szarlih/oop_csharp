namespace CarLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CustomCar : ICar
    {
        public int ProductionYear { get; }

        public CarBrand Brand { get; }

        public CustomCar()
        {
            Brand = new CarBrand();
        }
    }
}
