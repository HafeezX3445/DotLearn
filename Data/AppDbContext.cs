using DotLearn.Models;
using Microsoft.EntityFrameworkCore;

namespace DotLearn.Data
{

    //https://github.com/bhrugen/MagicVilla_API.gitw t
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<TechConcept> TechConcepts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-VSB9AV14\\SQLEXPRESS;Database=DotLearn;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
