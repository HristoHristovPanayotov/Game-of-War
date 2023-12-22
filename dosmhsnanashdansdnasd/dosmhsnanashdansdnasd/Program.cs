using System;
using System.Collections.Generic;
using System.Linq;

namespace shipponglist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!").ToList();
            string[] commands = Console.ReadLine().Split();

            while (!(commands[0] == "Conclude" && commands[1] == "Purchasing!"))
            {
                switch (commands[0])
                {
                    case "Expedite":
                        if (!shoppingList.Contains(commands[1]))
                            shoppingList.Insert(0, commands[1]);
                        break;

                    case "Eliminate":
                        shoppingList.Remove(commands[1]);
                        break;

                    case "Rectify":
                        if (shoppingList.Contains(commands[1]))
                        {
                            shoppingList.Remove(commands[1]);
                            shoppingList.Add(commands[2]);
                        }
                        break;

                    case "Reajust":
                        if (shoppingList.Contains(commands[1]))
                        {
                            shoppingList.Remove(commands[1]);
                            shoppingList.Add(commands[1]);
                        }
                        break;
                }

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
