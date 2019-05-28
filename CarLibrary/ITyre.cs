namespace CarLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ITyre
    {
        string TyreManufacturer { get; }

        string TyreModel { get; }

        int TyreSizeInInch { get; }

        double TyrePressureInBar { get; }
    }
}
