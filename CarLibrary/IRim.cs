namespace CarLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IRim
    {
        string RimManufacturer { get; }
        int RimSizeInInch { get; }
    }
}
