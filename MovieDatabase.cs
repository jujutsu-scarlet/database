// MovieDatabase.cs
using System;
using System.Collections.Generic;

public class MovieDatabase {
    private List<Movie> movies;

    public MovieDatabase() {
        movies = new List<Movie>();
    }

    public void AddMovie(Movie movie) {
        movies.Add(movie);
    }

    public void DisplayMovies() {
        Console.WriteLine("Movies in the Database:");
        foreach (Movie movie in movies) {
            movie.DisplayMovieInfo();
        }
    }
}
