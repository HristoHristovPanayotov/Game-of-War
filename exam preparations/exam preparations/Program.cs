using System;

namespace Exam_Preparatiions

{
    class Program
    {
        static void Main(string[] args)
        {
            double energy = double.Parse(Console.ReadLine());
            int wins = 0;

            string command = Console.ReadLine();

            while (command != "End of battle")
            {
                double distance = double.Parse(command);

                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    energy -= distance; // Subtract energy before breaking the loop
                    break;
                }

                energy -= distance;
                wins++;

                if (wins % 3 == 0)
                {
                    energy += wins;
                }

                command = Console.ReadLine();
            }

            if (energy >= 0)
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
            }
            else
            {
                Console.WriteLine($"Aleksandar, please be careful");
            }
        }
    }
}
