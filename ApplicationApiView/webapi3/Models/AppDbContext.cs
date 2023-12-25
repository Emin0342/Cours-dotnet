using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace newWebAPI.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var currentDir = Directory.GetCurrentDirectory();
            var dbPath = Path.Combine(currentDir, "Books4.db");
            Console.WriteLine($"using db at {dbPath}");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // permet de creer la base de donnees
        {
            modelBuilder.Entity<Color>().HasData( 
                new Color // on cree une nouvelle entite Color
                {
                    colorId = 1, // on lui donne un id
                    color = "red" // on lui donne un nom
                },
                new Color
                {
                    colorId = 2,
                    color = "blue"
                },
                new Color
                {
                    colorId = 3,
                    color = "green"
                });

            modelBuilder.Entity<Book>().HasData(
                new Book // on cree une nouvelle entite Book
                {
                    Id = 1, // on lui donne un id
                    Title = "Professional C# 6 and .NET Core 1.0", // on lui donne un titre
                    Author = "Christian Nagel", // on lui donne un auteur
                    Description = "A true masterclass in C# and .NET programming", // on lui donne une description
                    Genre = "Software", // on lui donne un genre
                    Price = 50, // on lui donne un prix
                    PublishDate = new DateTime(2016, 05, 09), // on lui donne une date de publication
                    colorId = 1 // on lui donne un id de couleur (ici id fait reference a l'id de la table Color)

                },
                new Book
                {
                    Id = 2,
                    Title = "Professional C# 7 and .NET Core 2.0",
                    Author = "Christian Nagel",
                    Description = "A true masterclass in C# and .NET programming",
                    Genre = "Software",
                    Price = 50,
                    PublishDate = new DateTime(2018, 04, 18),
                    colorId = 2
                },
                new Book
                {
                    Id = 3,
                    Title = "Professional C# 8 and .NET Core 3.0",
                    Author = "Christian Nagel",
                    Description = "A true masterclass in C# and .NET programming",
                    Genre = "Software",
                    Price = 50,
                    PublishDate = new DateTime(2019, 10, 30),
                    colorId = 3
                },
                new Book
                {
                    Id = 4,
                    Title = "Professional C# 9 and .NET 5",
                    Author = "Christian Nagel",
                    Description = "A true masterclass in C# and .NET programming",
                    Genre = "Software",
                    Price = 50,
                    PublishDate = new DateTime(2021, 01, 01),
                    colorId = 1
                },
                new Book
                {
                    Id = 5,
                    Title = "Beginning Visual C# 2019",
                    Author = "Perkins, Reid, and Hammer",
                    Description = "The perfect guide to Visual C#",
                    Genre = "Software",
                    Price = 45,
                    PublishDate = new DateTime(2020, 09, 23),
                    colorId = 2
                },
                new Book
                {
                    Id = 6,
                    Title = "Pro C# 7",
                    Author = "Andrew Troelsen",
                    Description = "The ultimate C# resource",
                    Genre = "Software",
                    Price = 50,
                    PublishDate = new DateTime(2017, 10, 01),
                    colorId = 3
                });

            modelBuilder.Entity<Book>() // on cree une nouvelle entite Book
            .HasOne(b => b.Color) // on lui dit qu'il a une couleur
            .WithMany(c => c.Books) // on lui dit qu'il a plusieurs livres
            .HasForeignKey(b => b.colorId);  // on lui dit qu'il a une cle etrangere qui est l'id de la couleur
        }

        public DbSet<Book> Books { get; set; } = default!; // on cree un dbset qui sert a definir la table Book
        public DbSet<Color> Color { get; set; } = default!; // on cree un dbset qui sert a definir la table Color 
        // un dbset est un fichier qui sert a definir une table de la base de donnee
    }
}