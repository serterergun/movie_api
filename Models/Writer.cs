namespace imdb_api.Models;

public class Writer
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public int PersonId { get; set; }
    public Movie Movie { get; set; }
    public Person Person { get; set; }
   
}
