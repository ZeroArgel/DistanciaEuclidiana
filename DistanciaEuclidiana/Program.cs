namespace DistanciaEuclidiana
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var points = NewPoints();// Get new points.
            foreach(var point in points)
            {
                Console.WriteLine($"{point.PointName}({point.X}, {point.Y})");
            }
            var combinations = GetResult(points);
            Console.WriteLine($"Combination able to: {combinations.Count()}");
            foreach(var combination in combinations)
            {
                Console.WriteLine($"D{combination.Name}: {combination.Distance}");
            }
            Console.WriteLine($"Sum all distances: {combinations.Sum(x => x.Distance)}");
        }
        public static IEnumerable<Combinations> GetResult(IEnumerable<Points> points)
        {
            var results = new List<Combinations>();
            var noCombinations = points.Count().ToCombinations(1);
            var initPosition = 0;
            while (true)
            {
                if (initPosition == points.Count()) break;

                var elementToJoin = points.ElementAt(initPosition);
                foreach (var element in points)
                {
                    var name = string.Concat(elementToJoin.PointName, element.PointName);
                    if (element.PointName != elementToJoin.PointName && 
                        !results.Any(x => x.Name.ToCheckString(name)))
                    {   
                        var distance = EuclideanDistance(elementToJoin, element);
                        results.Add(new Combinations(name, distance));
                    }   
                }
                initPosition++;
            }
            return results;
        }
        // formula: d = R[(x2-x1)^2 + (y2-y1)^2] where R is square root
        private static double EuclideanDistance(Points point1, Points point2) =>
            Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        private static IEnumerable<Points> NewPoints() =>
            new List<Points>()
            {
                new Points('A', -3, 1),
                new Points('B', 1, -2)
            };
    }
}