namespace SafariParkApp
{
    public struct Point3D
    {
        public int x, y, z;

        public Point3D(int x, int y, int z = 0) // structs require their values all to be assigned, x y and z need to have values
        {
            this.x = x; // this.x looks at x in the scope around of this constructor
            this.y = y;
            this.z = z;
        }

        public int DistanceFromOrigin()
        {
            double calc = Math.Sqrt(x * x + y * y + z * z);
            return (int)calc;
        }
    }
}
