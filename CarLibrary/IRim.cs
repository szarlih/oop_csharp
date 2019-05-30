namespace CarLibrary
{
    using System;

    public interface IRim: IDisposable
    {
        string Manufacturer { get; }
        int SizeInInch { get; }
    }
}
