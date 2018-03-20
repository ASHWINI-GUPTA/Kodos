using Kodos.Models;
using Microsoft.EntityFrameworkCore;

namespace Kodos.Data
{
    public class SkiCardContext : DbContext
    {
        public SkiCardContext(DbContextOptions<SkiCardContext> options) : base(options)
        {
            
        }

        public DbSet<SkiCard> SkiCards { get; set; }
    }
}
