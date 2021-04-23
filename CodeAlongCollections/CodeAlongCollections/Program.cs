using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAlongCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            //Lists
/*                        List<string> cities = new List<string>
                        {
                            "Detroit", "Westland", "Vancouver", "Austin", "Charlevoix"
                        };

                        List<string> states = new List<string>();
                        foreach(string city in cities)
                        {
                            Console.Write($"Where is {city} located? ");
                            states.Add(Console.ReadLine());
                        }

                        for (int i = 0; i < cities.Count; i++)
                        {
                            Console.WriteLine($"{cities[i]}, {states[i]}");
                        }*/

            //Dictionaries
                        /*Dictionary<string, bool> starWarsChars = new Dictionary<string, bool>
                        {
                            { "Yoda", true },
                            { "Admiral Ackbar", false },
                            { "JarJar", false },
                            { "Salacious B. Crumb", false },
                            { "Anakin Skywalker", true },
                            { "Darth Revan", true },
                            { "Porgs", false }
                        };
                        foreach (KeyValuePair<string, bool> kvp in starWarsChars)
                        {
                            PrintCharacters(kvp);
                        }*/

            //Exercise

            bool checker = true;
            int spaces = 0;
            string phrase;
            StringBuilder text = new StringBuilder();
            Dictionary<string, List<string>> matesAndMeals = new Dictionary<string, List<string>>();
            List<string> names = new List<string>
            {
                "Anthony", "Ryan", "Shelly", "Anna"
            };

            for (int i = 0; i < names.Count; i++)
            {
                if (i == names.Count - 1)
                {
                    checker = false;
                }
                if (names[i].Length > spaces)
                {
                    spaces = names[i].Length;
                }

                    matesAndMeals.Add(names[i], GetFavoriteFoods(names[i], checker));
                
            }
            phrase = "{0, " + ((spaces + 1) * -1).ToString() + "} likes:\t";
            foreach (KeyValuePair<string, List<string>> kvp in matesAndMeals)
            {
                text.Append(String.Format(phrase, $"{kvp.Key}"));
                foreach (string meal in kvp.Value)
                {
                    text.Append(String.Format("{0} ", $"{meal}"));
                    //Console.WriteLine($"{kvp.Key} likes {meal}");
                }
                text.Append("\n");
            }
            Console.WriteLine(text);
        }

                public static void PrintCharacters (KeyValuePair<string, bool> kvp)
                {
                    if (kvp.Value)
                    {
                        Console.WriteLine($"{kvp.Key} has the force.");
                    }
                    else
                    {
                        Console.WriteLine($"{kvp.Key} does not have the force.");
                    }
                }

        public static List<string> GetFavoriteFoods(string name, bool check)
        {
            List<string> foods = new List<string>();
            Console.Write($"{name}, Enter a favorite food: ");
            bool checker = true;
            string text;
            while (checker)
            {
                text = Console.ReadLine();
                foods.Add(text);
                checker = ContinueEntry();
                if (checker)
                {
                    Console.Write("Enter next favorite food: ");
                }
                else if (check)
                {
                    Console.WriteLine("NEXT!\n");
                }
                else
                {
                    Console.WriteLine("That's it, Printing...\n\n");
                }
            }
            return foods;
        }

        public static bool ContinueEntry()
        {
            string text;
            while (true)
            {
                Console.Write("Would you like to continue? (Y/N)?: ");
                text = Console.ReadLine().Trim().ToLower();

                switch (text)
                {
                    case "y":
                    case "yes":
                        return true;


                    case "n":
                    case "no":
                        return false;


                    default:
                        Console.WriteLine("Invalid Entry.");
                        break;
                }
            }
        }

    } //end class
} //end package
