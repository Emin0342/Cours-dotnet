namespace newWebAPI.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    // Ce fichier DTO sert a definir les champs de la table Book
    // un DTO est un fichier qui sert a definir les champs d'une table
    public class BookColorPostDTO
    {
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public decimal Price { get; set; }
    public DateTime PublishDate { get; set; }
    public string Description { get; set; }
    public string Remarks { get; set; }
    public int ColorId { get; set; }
    }
}

