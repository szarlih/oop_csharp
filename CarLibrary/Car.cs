namespace CarLibrary
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Car : ICar
    {
        protected List<IWheel> Wheels { get; set; }

        public int ProductionYear { get; }

        public CarBrand Brand { get; protected set; }

        public int WheelsSizeInInch
        {
            get
            {
                return Wheels.First().Tyre.SizeInInch;
            }
        }

        public string WheelsRimManufacturer
        {
            get
            {
                return Wheels.First().Rim.Manufacturer;
            }
        }

        public int WheelsCount
        {
            get
            {
                return Wheels.Count;
            }
        }
    }
}
