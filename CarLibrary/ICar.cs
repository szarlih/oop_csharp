namespace CarLibrary
{
    using System.Collections.Generic;

    interface ICar
    {
        int ProductionYear { get; }
        CarBrand Brand { get; }
    }
}
