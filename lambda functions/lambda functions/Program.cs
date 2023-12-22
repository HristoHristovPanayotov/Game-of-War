namespace lambda_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numns = new int[] { 10, 20, 30, 40 };
            var nums2 = numns.Select(x => "num" + x);
            Console.WriteLine(String.Join(" ", nums2));

        }
    }
}