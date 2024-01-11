// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    private static List<string> movies = new List<string>();

    static void Main()
    {
        Console.WriteLine("Movie Management Console App");

        while (true)
        {
            Console.WriteLine("\n1. Get all movies");
            Console.WriteLine("2. Get movie by title");
            Console.WriteLine("3. Add a movie");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GetAllMovies();
                    break;
                case "2":
                    Console.Write("Enter movie title: ");
                    string title = Console.ReadLine();
                    GetMovieByTitle(title);
                    break;
                case "3":
                    Console.Write("Enter movie title to add: ");
                    string newMovie = Console.ReadLine();
                    AddMovie(newMovie);
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void GetAllMovies()
    {
        Console.WriteLine("\nAll Movies:");
        foreach (var movie in movies)
        {
            Console.WriteLine(movie);
        }
    }

    private static void GetMovieByTitle(string title)
    {
        string movie = movies.Find(m => m.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (movie != null)
        {
            Console.WriteLine($"\nMovie found: {movie}");
        }
        else
        {
            Console.WriteLine($"\nMovie with title '{title}' not found.");
        }
    }

    private static void AddMovie(string newMovie)
    {
        movies.Add(newMovie);
        Console.WriteLine($"\n'{newMovie}' added to the list.");
    }
}

