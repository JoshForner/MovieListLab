using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MovieListLab
{
    class Movie
    {
        private string title;
        private string category;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public Movie()
        {
            title = "Default";
            category = "Default";
        }
        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }

        public static void AddToList(Dictionary<string, string> movies)
        {

            Movie alien = new Movie("Alien", "Sci-Fi");
            Movie sw = new Movie("Star Wars", "Sci-Fi");
            Movie sm = new Movie("Scary Movie", "Comedy");
            Movie sb = new Movie("Superbad", "Comedy");
            Movie dh = new Movie("Die Hard", "Action");
            Movie jb = new Movie("James Bond", "Action");
            Movie hp = new Movie("Harry Potter", "Fantasy");
            Movie lotr = new Movie("Lord of the Rings", "Fantasy");
            Movie sj = new Movie("Space Jam", "Family");
            Movie ts = new Movie("Toy Story", "Family");
            movies.Add(alien.Title, alien.Category);
            movies.Add(sw.Title, sw.Category);
            movies.Add(sm.Title, sm.Category);
            movies.Add(sb.Title, sb.Category);
            movies.Add(dh.Title, dh.Category);
            movies.Add(jb.Title, jb.Category);
            movies.Add(hp.Title, hp.Category);
            movies.Add(lotr.Title, lotr.Category);
            movies.Add(sj.Title, sj.Category);
            movies.Add(ts.Title, ts.Category);
            
            
        }

        public static string MovieType()
        {
            Console.Write("Enter the number of the category you would like: ");
            string choice = "";
            bool right = true;
            while (right)
            {
                choice = Console.ReadLine().ToLower();
                if (choice == "1")
                {
                    choice = "Family";
                    break;
                }
                if (choice == "2")
                {
                    choice = "Fantasy";
                    break;
                }
                if (choice == "3")
                {
                    choice = "Action";
                    break;
                }
                if (choice == "4")
                {
                    choice = "Sci-Fi";
                    break;
                }
                if (choice == "5")
                {
                    choice = "Comedy";
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("Please enter a valid number");
                Console.Write("Enter the number of the category you would like: ");
            }
            return choice;
        }
    }
}
