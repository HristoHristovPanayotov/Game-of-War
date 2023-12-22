namespace doamshna_rabota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> chisla = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<char> teksts = new List<char>();
            teksts.AddRange(Console.ReadLine());
            for (int i = 0; i < chisla.Count; ++i)
            {
                int suma = 0;
                while (chisla[i] != 0)
                {
                    suma += chisla[i] % 10;
                    chisla[i] /= 10;
                }
                int t = suma / teksts.Count;
                suma = suma - t * teksts.Count;
                Console.Write(teksts[suma]);
                teksts.RemoveAt(suma);
            }
        }
    }
}