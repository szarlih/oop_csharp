namespace CarLibrary
{
    using System;

    internal class Wheel : IWheel
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
    }
}
