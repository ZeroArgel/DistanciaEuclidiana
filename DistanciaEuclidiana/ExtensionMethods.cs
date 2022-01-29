namespace DistanciaEuclidiana
{
    using System;
    public static class ExtensionMethods
    {
        // formula: d = R[(x2-x1)^2 + (y2-y1)^2] where R is square root
        public static double GetEuclideanDistance(this Points point1, Points point2) =>
            Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));

        public static void Show(this string message) => Console.WriteLine(message);
    }
}