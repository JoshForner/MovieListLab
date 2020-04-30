using System;
using System.Collections.Generic;

namespace MovieListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keeprunning = true;
            Console.WriteLine("Welcome to the movie list");
            while (keeprunning)
            {
                Dictionary<string, string> movies = new Dictionary<string, string>();
                List<string> categories = new List<string>() { "Family", "Fantasy", "Action", "Sci-Fi", "Comedy" };
                Movie.AddToList(movies);
                int i = 1;
                int j = 1;
                foreach (string category in categories)
                {
                    Console.WriteLine($"{i + ".",-3} {category,-2}");
                    i++;
                }
                Console.WriteLine();
                string choice = Movie.MovieType().Trim();
                Console.WriteLine();
                Console.WriteLine($"You selected the category {choice}. Here is the movies in that category.");
                foreach (KeyValuePair<string, string> movie in movies)
                {
                    if (movie.Value.ToLower() == choice.ToLower())
                    {
                        Console.WriteLine($"{j}. {movie.Key}");
                        j++;
                    }
                }
                Console.WriteLine();
                keeprunning = KeepRunning();
            }
        }
        public static bool KeepRunning()
        {
            Console.WriteLine("Do you wish to pick another category? y/n");
            string answer = Console.ReadLine().ToLower().Trim();
            if (answer == "y")
            {
                Console.WriteLine();
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine();
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("Please enter y or n");
                return KeepRunning();
            }
        }
    }
}
