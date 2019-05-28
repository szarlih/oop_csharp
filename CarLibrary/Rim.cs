namespace CarLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Rim : IRim
    {
        public string Manufacturer { get; }

        public int SizeInInch { get; }

        public Rim(string manufacturer, int sizeInInch)
        {
            SizeInInch = sizeInInch;
            Manufacturer = manufacturer;
        }
    }
}
