using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using newWebAPI.Models;

namespace newWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")] // pour trouver dans l'url on definit le chemin d'acces --> localhost/port/api/controlleur
public class BookController : ControllerBase 
{
    private readonly AppDbContext _context;

    public BookController(AppDbContext context)
    {
        _context = context;
    }

    // le get (le R(read) du CRUD qui sert a afficher TOUTES les donnés)
    [HttpGet] 
    public async Task<IEnumerable<Book>> Get() 
    {
        return await _context.Books.ToListAsync(); // retourne toutes les données
    }


    // le get (le R(read) du CRUD qui sert a afficher les données selon l'id 
    // on definir l'id et on a toutes les donnés que de cet id la
    [HttpGet("{id}")]

    public async Task<ActionResult<Book>> Get(int id) // ici on met en paramètre int id pour que l'utilisateur donne l'id pour -->
    {
        var book = await _context.Books.FindAsync(id); // --> avoir toutes les données de cet id la

        if (book == null) // si il n'y a aucun livre
        {
            return NotFound(); // on retourne une érreur
        }

        return book; // sinnon on retourne le livre en question
    }

    [HttpPost] // le post (le c(create) du CRUD qui sert a inserere un nouveaux champ 

    public async Task Post([FromBody]Book book)
    {
        _context.Books.Add(book); // ici demande a l'utilisateur de remplir les champs
        await _context.SaveChangesAsync(); // et on insert le champs
    }

    [HttpPut("{id}")] // le put (le U(update) du CRUD qui sert a mettre a jour un champ deja existant
    public async Task<ActionResult> PutBook(int id, [FromBody] Book book) // ici on a en parametre int id pour que l'utilisateur indique selon quel id il faut faire la mise a jour de champs
    {
        if (id != book.Id) // si le champ existe pas
        {
            return BadRequest(); // on renvoie une erreur
        }
        _context.Entry(book).State = EntityState.Modified;  // ici on demande de faire la modifcation
        await _context.SaveChangesAsync(); // et on met a jour si sa marche 
        return Ok();
    }
    
}