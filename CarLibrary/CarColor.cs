namespace CarLibrary
{
    using System.Drawing;

    class CarColor
    {
        private int code;

        int Code
        {
            get
            {
                return color.GetHashCode();
            }
        }
        string Name { get; }

        private Color color;

        public CarColor(string name, Color color)
        {
            Name = name;
            this.color = color;
        }
    }
}
