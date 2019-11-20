using Microsoft.EntityFrameworkCore;

namespace ArtGallery
{
    public class AppDbCntext : DbContext
    {
        public AppDbCntext(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<ArtWork> ArtWorks { get; set; }
    }
}