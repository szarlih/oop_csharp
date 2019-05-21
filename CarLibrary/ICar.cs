namespace CarLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    interface ICar
    {
        int ProductionYear { get; }
        CarBrand Brand { get; }
    }
}
