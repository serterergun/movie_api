namespace imdb_api.Models;

public class Movie
{
    public int Id { get; set; }

    public DateOnly ReleaseDate { get; set; }

    public int Length_Min { get; set; }

    public string? Description { get; set; }
}
