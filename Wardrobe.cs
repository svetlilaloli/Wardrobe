using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string currentLine = Console.ReadLine();
                int ind = currentLine.IndexOf('-');
                string colour = currentLine.Substring(0, ind - 1);
                string[] clothes = currentLine.Substring(ind + 3).Split(',');

                if (wardrobe.ContainsKey(colour))
                {
                    foreach (string clothing in clothes)
                    {
                        if (wardrobe[colour].ContainsKey(clothing))
                        {
                            wardrobe[colour][clothing]++;
                        }
                        else
                        {
                            wardrobe[colour].Add(clothing, 1);
                        }
                    }
                }
                else
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                    for (int j = 0; j < clothes.Length; j++)
                    {
                        wardrobe[colour].Add(clothes[j], 1);
                    }
                }
            }

            string[] item = Console.ReadLine().Split();
            string searchedColour = item[0];
            string searchedItem = item[1];

            foreach (var colour in wardrobe)
            {
                Console.WriteLine($"{colour.Key} clothes:");

                foreach (var clothing in colour.Value)
                {
                    if (colour.Key == searchedColour && clothing.Key == searchedItem)
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                    }
                }
            }
        }
    }
}
