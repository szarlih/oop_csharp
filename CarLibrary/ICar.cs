namespace CarLibrary
{
    using System.Collections.Generic;

    public interface ICar
    {
        int ProductionYear { get; }
        CarBrand Brand { get; }
    }
}
