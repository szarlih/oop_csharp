namespace CarLibrary
{ 
    public interface ITyre
    {
        string Manufacturer { get; }

        string Model { get; }

        int SizeInInch { get; }

        double PressureInBar { get; }
    }
}
