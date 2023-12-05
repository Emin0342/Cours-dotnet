using Microsoft.AspNetCore.Mvc;
using webapi;

namespace webapi.Controllers;

[ApiController] // veut dire que cette classe sert a faire du web api
[Route("api/[controller]")] // permet de definir le chemin racine de toutes les routes de ce controller


// route de base pour accéder au controller
public class BooksController : ControllerBase
{
    private readonly ILogger<BooksController> _logger;

    private readonly AppDbContext _context;

    BooksController(AppDbContext context)
    {
        this._context = context;
    }

    public BooksController(ILogger<BooksController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Book> Get() /* */
    {
        // on fait un tableau de string pour les genres de livre
        string[] genres = new string[] { "Roman", "BD", "Manga", "Magazine" };
        string[] Author = new string[] { "Toto", "Tata", "Titi", "Tutu" };

        return Enumerable.Range(1, 5).Select(index => new Book
        {
            Id = index,
            Title = "Book " + index, 
            Author = Author[Random.Shared.Next(Author.Length)],
            Genre = genres[Random.Shared.Next(genres.Length)],
            Description = "description qui descriptione" + index,
            Price = Random.Shared.Next(10, 100),
            PublishDate = new DateTime(2021, 10, 12),
        })
        .ToArray();
    }
}