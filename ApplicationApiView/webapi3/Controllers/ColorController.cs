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

public class ColorController : ControllerBase 
{
    private readonly AppDbContext _context; // ici on a une variable qui sert a faire le lien avec la base de donnée
    private readonly IMapper _mapper; // ici on a une variable qui sert a faire le lien avec automapper
    public ColorController(AppDbContext context, IMapper mapper) 
    {
        _context = context;
        _mapper = mapper;
    }

    // le get (le R(read) du CRUD qui sert a afficher TOUTES les donnés)
    [EnableCors("_myAllowSpecificOrigins")]
    [HttpGet] 
    [ProducesResponseType(201, Type = typeof(ColorDTO))] 
    [ProducesResponseType(400)]
    public async Task<IEnumerable<ColorDTO>> Get() 
    {
        var colors = await _context.Color.ToListAsync();
        return _mapper.Map<List<ColorDTO>>(colors); 
    }

    // le post (le C(create) du CRUD qui sert a ajouter des données)
    [HttpPost] 

    public async Task<IActionResult> PostColor(ColorDTO colorDTO) // ici on a une variable qui sert a recuperer toutes les données de la table Book
    {
        var color = _mapper.Map<Color>(colorDTO); // on utilise automapper pour faire le lien entre book et bookNewDTO
        _context.Color.Add(color); // on ajoute les données dans la table Book
        await _context.SaveChangesAsync(); // on sauvegarde les données dans la base de donnée
        return Ok(color); // on retourne les données
    }


}