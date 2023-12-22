
namespace lists_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst = Console.ReadLine();
            List<int> result = OrderGroups(tekst);
            Result(result);
        }

        static List<int> OrderGroups(string tekst2)
        {
            string[] grupi = tekst2.Split('|');
            List<int> result = new List<int>();
            for (int i = grupi.Length - 1; i >= 0; i--)
            {
                int[] chisla = GetNums(grupi[i]);
                result.AddRange(chisla);
            }

            return result;
        }

        static int[] GetNums(string grupi2)
        {
            return grupi2
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

        static void Result(List<int> result)
        {
            Console.WriteLine(string.Join(" ", result));
        }

    }
}
