using System.Data.Entity;

namespace Sadrnejad.com.Models
{
    public class SadrnejadcomEntities : DbContext
    {
        public SadrnejadcomEntities() 
        : base("SadrnejadcomEntities")
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}