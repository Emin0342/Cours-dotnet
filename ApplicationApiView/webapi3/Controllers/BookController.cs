using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using newWebAPI.Models;
 using AutoMapper;
using Microsoft.AspNetCore.Cors;

namespace newWebAPI.Controllers;

// Ce fichier est un controller qui sert a definir les routes de l'api
// une routes sert a definir les actions que l'on peut faire sur l'api
// on a les routes suivant: Get, Get(id), Post, Put(id), Delete(id)

[ApiController]
[Route("api/[controller]")] // pour trouver dans l'url on definit le chemin d'acces --> localhost/port/api/controlleur
public class BookController : ControllerBase 
{
    private readonly AppDbContext _context; // ici on a une variable qui sert a faire le lien avec la base de donnée
    private readonly IMapper _mapper;
    public BookController(AppDbContext context, IMapper mapper) 
    {
        _context = context;
        _mapper = mapper;
    }

    // le get (le R(read) du CRUD qui sert a afficher TOUTES les donnés)
    [EnableCors("_myAllowSpecificOrigins")]
    [HttpGet] 
    [ProducesResponseType(201, Type = typeof(Book))] // ici on definit le type de donné que l'on veut
    [ProducesResponseType(400)]
    
    public async Task<IEnumerable<Book>> Get()  // ici on met en paramètre IEnumerable<Book> pour avoir toutes les données
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
    
    [HttpDelete("{id}")] // le delete (le D(delete) du CRUD qui sert a supprimer un champ
    public async Task<ActionResult<Book>> Delete(int id) // ici on a en parametre int id pour que l'utilisateur indique selon quel id il faut faire la suppression de champs
    {
        var book = await _context.Books.FindAsync(id); // on demande de trouver le livre selon l'id
        if (book == null) // si le livre n'existe pas
        {
            return NotFound(); // on renvoie une erreur
        }
        _context.Books.Remove(book); // sinon on supprime le livre
        await _context.SaveChangesAsync(); // et on met a jour si sa marche 
        return book; // on retourne le livre supprimer
    }


    // get de bookUpdateDTO pour obtenir les données de la table Book avec les champs de bookUpdateDTO

    [HttpGet("bookUpdateDTO/{id}")]
    public async Task<ActionResult<BookUpdateDTO>> GetBookUpdateDTO(int id) // ici on met en paramètre int id pour que l'utilisateur donne l'id pour -->
    {
        var book = await _context.Books.FindAsync(id); // --> avoir toutes les données de cet id la

        if (book == null) // si il n'y a aucun livre
        {
            return NotFound(); // on retourne une érreur
        }

        var bookUpdateDTO = new BookUpdateDTO // on a un objet bookUpdateDTO qui sert a definir les champs de la table Book
        {
            Title = book.Title, // on a les champs suivant: Title, Author, Genre
            Author = book.Author,
            Genre = book.Genre,
        };

        return bookUpdateDTO; // on retourne le livre en question
    }

    // utilisation de automapper pour faire le lien entre book et bookUpdateDTO

    [HttpGet("bookUpdateDTOMAPPER/{id}")]
    public async Task<ActionResult<BookUpdateDTO>> GetBookUpdateDTO2(int id) // ici on met en paramètre int id pour que l'utilisateur donne l'id pour -->
    {
        var book = await _context.Books.FindAsync(id); // --> avoir toutes les données de cet id la

        if (book == null) // si il n'y a aucun livre
        {
            return NotFound(); // on retourne une érreur
        }

        var bookUpdateDTO = new BookUpdateDTO(); // on a un objet bookUpdateDTO qui sert a definir les champs de la table Book

        bookUpdateDTO = _mapper.Map<BookUpdateDTO>(book); // on utilise automapper pour faire le lien entre book et bookUpdateDTO

        return bookUpdateDTO; // on retourne le livre en question
    }

}