namespace CarLibrary
{
    internal class Wheel : IWheel
    {
        public string TyreManufacturer { get; }

        public string TyreModel { get; }

        public double TyrePressureInBar { get; }

        public int TyreSizeInInch { get; }

        public string RimManufacturer { get; }

        public int RimSizeInInch => TyreSizeInInch;

        public Wheel(string tyreManufacturer, string model, double pressureInBar, int tyreSize, string rimManufacturer)
        {
            TyreManufacturer = tyreManufacturer;
            TyreModel = model;
            TyrePressureInBar = pressureInBar;
            TyreSizeInInch = tyreSize;
            RimManufacturer = rimManufacturer;
        }
    }
}
