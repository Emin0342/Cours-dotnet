namespace newWebAPI.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

// Ce fichier est un model qui sert a definir les champs de la table Color
// un model est un fichier qui sert a definir les champs d'une table
// on a les champs suivant: Id, color
// le ? sert a dire que le champs peut etre null

// ce fichier fera la liaison avec le model book
// dans book on devra ajouter un champs colorId
// et on devra ajouter un attribut [ForeignKey("ColorId")] au champs colorId
// et on devra ajouter un attribut public Color Color { get; set; } au model book



public class Color
{

    // on a un attribut Key qui sert a definir la cle primaire de la table
    [Key]
    // on a un attribut DatabaseGenerated qui sert a definir que la cle primaire est genere par la base de donnee
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    // on a un attribut Required qui sert a definir que le champs est obligatoire
    [Required]
    // on a un attribut MaxLength qui sert a definir la taille maximale du champs
    [MaxLength(200)]
    public int colorId { get; set; }

    [Required (ErrorMessage = "La couleur est un champs obligatoire !")]
    [MaxLength(200)]

    public string? color { get; set; }

    public ICollection<Book> Books { get; set; }

}