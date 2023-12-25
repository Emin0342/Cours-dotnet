namespace newWebAPI.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

// Ce fichier DTO sert a definir les champs de la table Book
// un DTO est un fichier qui sert a definir les champs d'une table


public class BookColorDTO
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int? ColorId { get; set; }
    public string Color { get; set; }
}