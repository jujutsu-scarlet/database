// Movie.cs
public class Movie {
    public string Title { get; private set; }
    public int Year { get; private set; }
    public string Genre { get; private set; }
    public List<Actor> Cast { get; private set; }

    public Movie(string title, int year, string genre) {
        Title = title;
        Year = year;
        Genre = genre;
        Cast = new List<Actor>();
    }

    public void AddActor(Actor actor) {
        Cast.Add(actor);
    }

    public void DisplayMovieInfo() {
        Console.WriteLine($"Title: {Title}, Year: {Year}, Genre: {Genre}");
        Console.WriteLine("Cast:");
        foreach (Actor actor in Cast) {
            Console.WriteLine($"- {actor.Name}");
        }
        Console.WriteLine();
    }
}
