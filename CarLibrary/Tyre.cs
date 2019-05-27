namespace CarLibrary
{
    internal class Tyre : IWheel
    {
        public string Manufacturer { get; }

        public string Model { get; }

        public double PressureInBar { get; }

        public int SizeInInch { get; }

        public Tyre(string manufacturer, string model, double pressureInBar, int size)
        {
            Manufacturer = manufacturer;
            Model = model;
            PressureInBar = pressureInBar;
            SizeInInch = size;
        }
    }
}
