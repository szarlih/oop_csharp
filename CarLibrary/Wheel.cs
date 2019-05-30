namespace CarLibrary
{
    using System;

    public class Wheel : IWheel, IDisposable
    {
        public ITyre Tyre { get; }

        public IRim Rim { get; }

        public Wheel(ITyre tyre, IRim rim)
        {
            if (tyre.SizeInInch == rim.SizeInInch)
            {
                Tyre = tyre;
                Rim = rim;
            }
            else
            {
                throw new ArgumentException("Tyre not fit to rim!");
            }
        }

        public void Dispose()
        {
            Rim.Dispose();
        }
    }
}
