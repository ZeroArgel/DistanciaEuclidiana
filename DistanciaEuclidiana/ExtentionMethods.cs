namespace DistanciaEuclidiana
{
    public static class ExtentionMethods
    {
        public static int ToFactorial(this int n) => n == 0 ? 1 : n == 1 ? n : n * (n - 1).ToFactorial();
        public static int ToCombinations(this int elements, int groups) =>
            elements.ToFactorial() / ((elements - groups).ToFactorial() * groups.ToFactorial());
        public static bool ToCheckString(this string str, string str2)
        {
            var equal = 0;
            foreach (var chr in str)
            {
                foreach(var chr2 in str2)
                {
                    if (chr == chr2) equal++;
                }
            }
            return equal == str.Length;
        }
    }
}