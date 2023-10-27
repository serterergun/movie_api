namespace imdb_api.Models;

public class Video
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? URL { get; set; }
    public int MovieId { get; set; }
    public Movie Movie { get; set; }
}
