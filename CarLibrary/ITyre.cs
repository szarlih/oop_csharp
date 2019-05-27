namespace CarLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ITyre
    {
        string Manufacturer { get; }

        string Model { get; }

        int SizeInInch { get; }

        double PressureInBar { get; }
    }
}
