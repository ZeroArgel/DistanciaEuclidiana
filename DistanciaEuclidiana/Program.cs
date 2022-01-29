namespace DistanciaEuclidiana
{
    using System.Collections.Generic;
    using System.Linq;
    internal static class Program
    {
        private static void Main()
        {
            var points = NewPoints().ToList();// Get new points.
            var combinations = GetResult(points).ToList();
            $"Points mapped: {combinations.Count}".Show();
            foreach (var point in points)
            {
                $"{point.PointName}({point.X}, {point.Y})".Show();
            }
            $"\nCombination able to: {combinations.Count}".Show();
            foreach (var combination in combinations)
            {
                $"D{combination.Name}: {combination.Distance}".Show();
            }
            $"\nSum all distances: {combinations.Sum(x => x.Distance)}".Show();
        }
        public static IEnumerable<Combinations> GetResult(List<Points> points)
        {
            var results = new List<Combinations>();
            foreach (var pointCurrent in points)
            {
                foreach (var point in points)
                {
                    var name = string.Concat(pointCurrent.PointName, point.PointName);
                    if (point.PointName == pointCurrent.PointName || results.Any(x => x.Name.ToUpper().Equals(name.ToUpper()))) 
                        continue;
                    
                    results.Add(new Combinations(name, pointCurrent.GetEuclideanDistance(point)));
                }
            }
            return results;
        }

        private static IEnumerable<Points> NewPoints() =>
            new List<Points>
            {
                new Points('A', -3, 1),
                new Points('B', 1, -2)
            };
    }
}