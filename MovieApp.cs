// MovieApp.cs
using System;

class MovieApp {
    static void Main() {
        MovieDatabase movieDatabase = new MovieDatabase();

        Actor actor1 = new Actor("Tom Hanks", 65);
        Actor actor2 = new Actor("Julia Roberts", 54);
        Actor actor3 = new Actor("Brad Pitt", 58);

        Movie movie1 = new Movie("Forrest Gump", 1994, "Drama");
        movie1.AddActor(actor1);
        movie1.AddActor(actor2);

        Movie movie2 = new Movie("Ocean's Eleven", 2001, "Crime");
        movie2.AddActor(actor2);
        movie2.AddActor(actor3);

        movieDatabase.AddMovie(movie1);
        movieDatabase.AddMovie(movie2);

        movieDatabase.DisplayMovies();
    }
}
