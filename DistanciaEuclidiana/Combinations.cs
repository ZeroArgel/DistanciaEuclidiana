namespace DistanciaEuclidiana
{
    public class Combinations
    {
        public Combinations() { }
        public Combinations(string name, double distance)
        {
            Name = name;
            Distance = distance;
        }
        public string Name { get; set; }
        public double Distance { get; set; }
    }
}