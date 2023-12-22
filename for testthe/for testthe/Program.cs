using System.ComponentModel.Design;

namespace for_testthe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] n = new int[10];
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i  = 0; i < n.Length; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }



        }
    }
}