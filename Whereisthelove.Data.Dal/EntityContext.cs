using Microsoft.EntityFrameworkCore;
using System;
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
        public DbSet<DeathDate> DeathDates{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeathDate>().HasData(
                new DeathDate { Id = Guid.NewGuid(), Year = 2021 },
                new DeathDate { Id = Guid.NewGuid(), Year = 2020 },
                new DeathDate { Id = Guid.NewGuid(), Year = 2019 },
                new DeathDate { Id = Guid.NewGuid(), Year = 2018 },
                new DeathDate { Id = Guid.NewGuid(), Year = 2017 });
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
