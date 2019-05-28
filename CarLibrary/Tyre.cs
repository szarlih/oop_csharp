namespace CarLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Tyre : ITyre
    {
        public string Manufacturer { get; }

        public string Model { get; }

        public double PressureInBar { get; }

        public int SizeInInch { get; }

        public Tyre(string manufacturer, string model, double pressureInBar, int sizeInInch)
        {
            SizeInInch = sizeInInch;
            Manufacturer = manufacturer;
            Model = model;
            PressureInBar = pressureInBar;
        }
    }
}
