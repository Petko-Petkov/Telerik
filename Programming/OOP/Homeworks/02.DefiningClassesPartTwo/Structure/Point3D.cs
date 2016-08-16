namespace Structure
{
    public struct Point3D
    {
        private static readonly Point3D start = new Point3D(0, 0, 0);

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public static Point3D Start
        {
            get { return start; }
        }

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
