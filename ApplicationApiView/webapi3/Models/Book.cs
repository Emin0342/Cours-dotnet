namespace newWebAPI.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

// Ce fichier est un model qui sert a definir les champs de la table Book
// un model est un fichier qui sert a definir les champs d'une table
// on a les champs suivant: Id, Title, Author, Genre, Price, PublishDate, Description, Remarks
// le ? sert a dire que le champs peut etre null

public class Book
{

    // on a un attribut Key qui sert a definir la cle primaire de la table
    [Key]
    // on a un attribut DatabaseGenerated qui sert a definir que la cle primaire est genere par la base de donnee
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    // on a un attribut Required qui sert a definir que le champs est obligatoire
    [Required]
    // on a un attribut MaxLength qui sert a definir la taille maximale du champs
    [MaxLength(200)]
    public int Id { get; set; }

    [Required (ErrorMessage = "Le titre est un champs obligatoire !")]
    [MaxLength(200)]

    public string? Title { get; set; }

    [Required (ErrorMessage = "L'auteur est un champs obligatoire !")]
    [MaxLength(200)]

    public string? Author { get; set; }

    [Required (ErrorMessage = "Le genre est un champs obligatoire !")]
    [MaxLength(200)]

    public string? Genre { get; set; }

    [Required  (ErrorMessage = "Le prix est un champs obligatoire !")]
    [MaxLength(200)]

    public decimal Price { get; set; }

    [Required (ErrorMessage = "La date de publication est un champs obligatoire !")]
    [MaxLength(200)]

    public DateTime PublishDate { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public int? colorId { get; set; } // ici on a un champs qui sert a faire la liaison avec le model Color

    [ForeignKey("colorId")] // ici on a un attribut qui sert a faire la liaison avec le model Color
    public Color Color { get; set; } // ici Color a un attribut qui sert a faire la liaison avec le model Color
    }
