using Microsoft.EntityFrameworkCore;
// importation de la librairie EntityFrameworkCore

namespace webapi;

    public class AppDbContext : DbContext
    {

        private static readonly string path = Path.Combine(".." ,"LocalDatabse.db");
        // remplacer la connextion string par une connexion string valide, plus tard utiliser la config pour la connection string

        // comment trouver le server bdd, le nom de la bdd, le user et le password
        private static readonly string ConnectionString = ($"filename={path}");

        // Configurer EF8 pour utiliser le non SGBD

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // configurer EF pour utiliser Sqlite
            optionsBuilder.UseSqlite(ConnectionString);
        }

        // On va creer une propriete pour chaque table de la bdd

        // cette ligne veut dire : a partir de l'entité books on va creer une table dans la bdd qui s'appele books 
        public DbSet<Book> Books { get; set; }

    }
