namespace imdb_api.Models;

public class Movie
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Length_Min { get; set; }
    public string? Description { get; set; }
}
