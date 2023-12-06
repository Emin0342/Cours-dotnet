namespace newWebAPI.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

// Ce fichier DTO sert a definir les champs de la table Book
// un DTO est un fichier qui sert a definir les champs d'une table


public class BookUpdateDTO
{
    [Required(ErrorMessage = "Le titre est un champ obligatoire !")]
    [MaxLength(200)]
    public string? Title { get; set; }

    [Required(ErrorMessage = "L'auteur est un champ obligatoire !")]
    [MaxLength(200)]
    public string? Author { get; set; }

    [Required(ErrorMessage = "Le genre est un champ obligatoire !")]
    [MaxLength(200)]
    public string? Genre { get; set; }


}