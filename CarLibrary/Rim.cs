namespace CarLibrary
{
    using System;

    public class Rim : IRim
    {
        public string Manufacturer { get; }

        public int SizeInInch { get; }

        public Rim(string manufacturer, int sizeInInch)
        {
            SizeInInch = sizeInInch;
            Manufacturer = manufacturer;
        }

        public void Dispose()
        {
        }
    }
}
