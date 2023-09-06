using Microsoft.EntityFrameworkCore;

namespace MovieStore.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            {}
        
        
    }
}