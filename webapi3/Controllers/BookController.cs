using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using newWebAPI.Models;

namespace newWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private readonly AppDbContext _context;

    public BookController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<Book>> Get()
    {
        return await _context.Books.ToListAsync();
    }

    [HttpGet("{id}")]

    public async Task<ActionResult<Book>> Get(int id)
    {
        var book = await _context.Books.FindAsync(id);

        if (book == null)
        {
            return NotFound();
        }

        return book;
    }

    [HttpPost]

    public async Task Post([FromBody]Book book)
    {
        _context.Books.Add(book);
        await _context.SaveChangesAsync();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> PutBook(int id, [FromBody] Book book)
    {
        if (id != book.Id)
        {
            return BadRequest();
        }
        _context.Entry(book).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return Ok();
    }
    
}