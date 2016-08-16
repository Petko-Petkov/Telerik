namespace MobilePhone
{
    public class Display
    {
        public double Size { get; set; }

        public double Colors { get; set; }



        public Display() : this(5.0, 16000000)
        {

        }

        public Display(double size) : this(size, 16000000)
        {
            this.Size = size;
        }

        public Display(double size, double colors)
        {
            this.Size = size;
            this.Colors = colors;
        }
    }
}
