using Exercice04.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice04.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Dog> Dogs { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
