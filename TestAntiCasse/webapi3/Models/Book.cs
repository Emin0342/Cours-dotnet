using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BooksAPI.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [MaxLength(200)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le titre est un champs obligatoire !")]
        [MaxLength(200)]
        public string? Title { get; set; }

        [Required(ErrorMessage = "L'auteur est un champs obligatoire !")]
        [MaxLength(200)]
        public int AuthorId { get; set; }

        public Author? Author { get; set; }

        [Required(ErrorMessage = "Le genre est un champs obligatoire !")]
        [MaxLength(200)]
        public string? Genre { get; set; }

        [Required(ErrorMessage = "Le prix est un champs obligatoire !")]
        [MaxLength(200)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "La date de publication est un champs obligatoire !")]
        [MaxLength(200)]
        public DateTime PublishDate { get; set; }

        public string? Description { get; set; }

        public string? Remarks { get; set; }
    }
}