namespace imdb_api.Models;

public class MovieImage
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public int ImageId { get; set; }
    public Movie Movie { get; set; }
    public Image Image { get; set; }
}
