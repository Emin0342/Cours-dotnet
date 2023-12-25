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
    private readonly IMapper _mapper;
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
}