using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Cardinal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            var words = File.ReadAllLines(@"..\..\..\words.txt").Select(x => x);
            var returnWords = new List<string>();

            char[,] array = new char[5, 5] { {'r', 'i', 'o', 't', 'f'},
                                        { 'e', 'l', 'c', 'u', 'p' },
                                        { 'p', 'r', 'a', 'l', 'u' },
                                        { 'l', 's', 'e', 's', 'o' },
                                        {'w', 'b', 'e', 'a', 'd' } };

            foreach (var word in words)
            {
                int latitude = -1;
                int longtude = -1;

                var coordinates = new List<string>();
                for (int i = 0; i <= 4; i++)
                {
                    for (int j = 0; j <= 4; j++)
                    {
                        if (array[i, j] == word[0])
                        {
                            latitude = i;
                            longtude = j;

                            coordinates.Add(latitude.ToString() + "," + longtude.ToString());
                        }
                    }
                }

                foreach (var cor in coordinates)
                {
                    var wordpointer = new List<string>();
                    latitude = int.Parse(cor.Split(",")[0]);
                    longtude = int.Parse(cor.Split(",")[1]);

                    if (latitude != -1)
                    {
                        for (int i = 1; i < word.Length; i++)
                        {
                            wordpointer.Add(latitude.ToString() + "," + longtude.ToString());
                            //top left
                            if (latitude == 0 && longtude == 0)
                            {
                                if (word[i] == array[latitude, longtude + 1])
                                {
                                    if (!wordpointer.Contains(latitude.ToString() + "," + (longtude + 1).ToString()))
                                    {
                                        longtude += 1;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude + 1, longtude + 1])
                                {
                                    if (!wordpointer.Contains((latitude + 1).ToString() + "," + (longtude + 1).ToString()))
                                    {
                                        longtude += 1;
                                        latitude += 1;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude + 1, longtude])
                                {
                                    if (!wordpointer.Contains((latitude + 1).ToString() + "," + longtude.ToString()))
                                    {
                                        latitude += 1;
                                        continue;
                                    }
                                }
                            }
                            //top
                            if (latitude == 0 && longtude > 0 && longtude != 4)
                            {
                                if (word[i] == array[latitude, longtude + 1])
                                {
                                    if (!wordpointer.Contains(latitude.ToString() + "," + (longtude + 1).ToString()))
                                    {
                                        longtude++;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude + 1, longtude + 1])
                                {
                                    if (!wordpointer.Contains((latitude + 1).ToString() + "," + (longtude + 1).ToString()))
                                    {
                                        longtude++;
                                        latitude++;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude + 1, longtude])
                                {
                                    if (!wordpointer.Contains((latitude + 1).ToString() + "," + longtude.ToString()))
                                    {
                                        latitude++;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude + 1, longtude - 1])
                                {
                                    if (!wordpointer.Contains((latitude + 1).ToString() + "," + (longtude - 1).ToString()))
                                    {
                                        latitude++;
                                        longtude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude, longtude - 1])
                                {
                                    if (!wordpointer.Contains(latitude.ToString() + "," + (longtude - 1).ToString()))
                                    {
                                        longtude--;
                                        continue;
                                    }
                                }
                            }

                            //bottom
                            if (latitude == 4 && longtude > 0 && longtude != 4)
                            {
                                if (word[i] == array[latitude, longtude + 1])
                                {
                                    if (!wordpointer.Contains(latitude.ToString() + "," + (longtude + 1).ToString()))
                                    {
                                        longtude++;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude - 1, longtude + 1])
                                {
                                    if (!wordpointer.Contains((latitude - 1).ToString() + "," + (longtude + 1).ToString()))
                                    {
                                        longtude++;
                                        latitude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude - 1, longtude])
                                {
                                    if (!wordpointer.Contains((latitude - 1).ToString() + "," + longtude.ToString()))
                                    {
                                        latitude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude - 1, longtude - 1])
                                {
                                    if (!wordpointer.Contains((latitude - 1).ToString() + "," + (longtude - 1).ToString()))
                                    {
                                        latitude--;
                                        longtude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude, longtude - 1])
                                {
                                    if (!wordpointer.Contains(latitude.ToString() + "," + (longtude - 1).ToString()))
                                    {
                                        longtude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude, longtude + 1])
                                {
                                    if (!wordpointer.Contains(latitude.ToString() + "," + (longtude + 1).ToString()))
                                    {
                                        longtude++;
                                        continue;
                                    }
                                }
                            }

                            //left side
                            if (latitude > 0 && latitude != 4 && longtude == 0)
                            {
                                if (word[i] == array[latitude, longtude + 1])
                                {
                                    if (!wordpointer.Contains(latitude.ToString() + "," + (longtude + 1).ToString()))
                                    {
                                        longtude++;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude - 1, longtude + 1])
                                {
                                    if (!wordpointer.Contains((latitude - 1).ToString() + "," + (longtude + 1).ToString()))
                                    {
                                        longtude++;
                                        latitude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude - 1, longtude])
                                {
                                    if (!wordpointer.Contains((latitude - 1).ToString() + "," + longtude.ToString()))
                                    {
                                        latitude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude + 1, longtude])
                                {
                                    if (!wordpointer.Contains((latitude + 1).ToString() + "," + longtude.ToString()))
                                    {
                                        latitude++;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude + 1, longtude + 1])
                                {
                                    if (!wordpointer.Contains((latitude + 1).ToString() + "," + (longtude + 1).ToString()))
                                    {
                                        longtude++;
                                        latitude++;
                                        continue;
                                    }
                                }

                                if (word[i] == array[latitude + 1, longtude])
                                {
                                    if (!wordpointer.Contains((latitude + 1).ToString() + "," + longtude.ToString()))
                                    {
                                        longtude++;
                                        continue;
                                    }
                                }
                            }

                            //right side
                            if (longtude == 4 && latitude > 0 && latitude != 4)
                            {
                                if (word[i] == array[latitude, longtude - 1])
                                {
                                    if (!wordpointer.Contains(latitude.ToString() + "," + (longtude - 1).ToString()))
                                    {
                                        longtude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude - 1, longtude - 1])
                                {
                                    if (!wordpointer.Contains((latitude - 1).ToString() + "," + (longtude - 1).ToString()))
                                    {
                                        longtude--;
                                        latitude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude - 1, longtude])
                                {
                                    if (!wordpointer.Contains((latitude - 1).ToString() + "," + longtude.ToString()))
                                    {
                                        latitude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude + 1, longtude])
                                {
                                    if (!wordpointer.Contains((latitude + 1).ToString() + "," + longtude.ToString()))
                                    {
                                        latitude++;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude + 1, longtude - 1])
                                {
                                    if (!wordpointer.Contains((latitude + 1).ToString() + "," + (longtude - 1).ToString()))
                                    {
                                        longtude--;
                                        latitude++;
                                        continue;
                                    }
                                }

                                if (word[i] == array[latitude + 1, longtude])
                                {
                                    if (!wordpointer.Contains((latitude + 1).ToString() + "," + longtude.ToString()))
                                    {
                                        longtude++;
                                        continue;
                                    }
                                }
                            }

                            //center
                            if (latitude > 0 && longtude > 0 && latitude < 4 && longtude < 4)
                            {
                                if (word[i] == array[latitude + 1, longtude + 1])
                                {
                                    if (!wordpointer.Contains((latitude + 1).ToString() + "," + (longtude + 1).ToString()))
                                    {
                                        longtude++;
                                        latitude++;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude - 1, longtude + 1])
                                {
                                    if (!wordpointer.Contains((latitude - 1).ToString() + "," + (longtude + 1).ToString()))
                                    {
                                        longtude++;
                                        latitude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude, longtude + 1])
                                {
                                    if (!wordpointer.Contains(latitude.ToString() + "," + (longtude + 1).ToString()))
                                    {
                                        longtude++;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude, longtude - 1])
                                {
                                    if (!wordpointer.Contains(latitude.ToString() + "," + (longtude - 1).ToString()))
                                    {
                                        longtude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude - 1, longtude - 1])
                                {
                                    if (!wordpointer.Contains((latitude - 1).ToString() + "," + (longtude - 1).ToString()))
                                    {
                                        longtude--;
                                        latitude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude - 1, longtude])
                                {
                                    if (!wordpointer.Contains((latitude - 1).ToString() + "," + longtude.ToString()))
                                    {
                                        latitude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude + 1, longtude])
                                {
                                    if (!wordpointer.Contains((latitude + 1).ToString() + "," + longtude.ToString()))
                                    {
                                        latitude++;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude + 1, longtude - 1])
                                {
                                    if (!wordpointer.Contains((latitude + 1).ToString() + "," + (longtude - 1).ToString()))
                                    {
                                        longtude--;
                                        latitude++;
                                        continue;
                                    }
                                }

                                if (word[i] == array[latitude + 1, longtude])
                                {
                                    if (!wordpointer.Contains((latitude + 1).ToString() + "," + longtude.ToString()))
                                    {
                                        longtude++;
                                        continue;
                                    }
                                }
                            }

                            //bottom right
                            if (latitude == 4 && longtude == 4)
                            {
                                if (word[i] == array[latitude, longtude - 1])
                                {
                                    if (!wordpointer.Contains(latitude.ToString() + "," + (longtude - 1).ToString()))
                                    {
                                        longtude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude - 1, longtude - 1])
                                {
                                    if (!wordpointer.Contains((latitude - 1).ToString() + "," + (longtude - 1).ToString()))
                                    {
                                        longtude--;
                                        latitude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude - 1, longtude])
                                {
                                    if (!wordpointer.Contains((latitude - 1).ToString() + "," + longtude.ToString()))
                                    {
                                        latitude--;
                                        continue;
                                    }
                                }
                            }

                            //top right
                            if (latitude == 0 && longtude == 4)
                            {
                                if (word[i] == array[latitude, longtude - 1])
                                {
                                    if (!wordpointer.Contains(latitude.ToString() + "," + (longtude - 1).ToString()))
                                    {
                                        longtude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude + 1, longtude - 1])
                                {
                                    if (!wordpointer.Contains((latitude + 1).ToString() + "," + (longtude - 1).ToString()))
                                    {
                                        longtude--;
                                        latitude++;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude + 1, longtude])
                                {
                                    if (!wordpointer.Contains((latitude + 1).ToString() + "," + longtude.ToString()))
                                    {
                                        latitude++;
                                        continue;
                                    }
                                }
                            }

                            //bottom left
                            if (latitude == 4 && longtude == 0)
                            {
                                if (word[i] == array[latitude, longtude + 1])
                                {
                                    if (!wordpointer.Contains(latitude.ToString() + "," + (longtude + 1).ToString()))
                                    {
                                        longtude++;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude - 1, longtude + 1])
                                {
                                    if (!wordpointer.Contains((latitude - 1).ToString() + "," + (longtude + 1).ToString()))
                                    {
                                        longtude++;
                                        latitude--;
                                        continue;
                                    }
                                }
                                if (word[i] == array[latitude - 1, longtude])
                                {
                                    if (!wordpointer.Contains((latitude - 1).ToString() + "," + longtude.ToString()))
                                    {
                                        latitude++;
                                        continue;
                                    }
                                }
                            }

                            break;
                        }

                        wordpointer.Add(latitude.ToString() + "," + longtude.ToString());

                        var wordGot = "";

                        foreach (var item in wordpointer.Distinct())
                        {
                            var indexes = new List<string>();
                            indexes = item.Split(",").ToList();

                            wordGot += array[int.Parse(indexes[0]), int.Parse(indexes[1])];
                        }

                        if (word == wordGot)
                        {
                            returnWords.Add(wordGot);
                        }
                    }
                }
            }

            foreach (var item in returnWords.Distinct())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========================");
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}