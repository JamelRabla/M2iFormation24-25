using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using personnage.Models;

namespace personnage.Data
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {
        }

        public DbSet<Personnage> Personnages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\perso;Database=Personnages;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Personnage>().HasData(new Personnage() {id = 1, Pseudo = "Fuziio", PointsDeVie = 100, Armure = 100, Degats = 10, DateCreation = DateTime.Now, Kills = 0});
        }
    }
}
