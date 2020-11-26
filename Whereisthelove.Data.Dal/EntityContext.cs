using Microsoft.EntityFrameworkCore;
using Whereisthelove.Data.Domain.Entities;

namespace Whereisthelove.Data.Dal
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options) : base(options)
        {

        }
        public DbSet<ApplicationAdmin> ApplicationAdmins{ get; set; }
        public DbSet<People> Peoples{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
