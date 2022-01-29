namespace DistanciaEuclidiana
{
    public class Points
    {
        public Points(char pointName, double x, double y)
        {
            PointName = pointName;
            X = x;
            Y = y;
        }
        public char PointName { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}