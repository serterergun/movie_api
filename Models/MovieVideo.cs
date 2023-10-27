namespace imdb_api.Models;

public class MovieVideo
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public int VideoId { get; set; }
    public Movie Movie { get; set; }
    public Video Video { get; set; }
}
