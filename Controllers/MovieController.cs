using Microsoft.AspNetCore.Mvc;
using imdb_api.Models;
namespace imdb_api.Controllers;

[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase
{
    // private static readonly string[] Summaries = new[]
    // {
    //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    // };

    private readonly ILogger<MovieController> _logger;

    public MovieController(ILogger<MovieController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetMovie")]
    public IEnumerable<Movie> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Movie
        {
            Id = index,
            ReleaseDate = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Length_Min = index * 10,
            Description = $"Movie {index}"
        })
        .ToArray();
    }
}
