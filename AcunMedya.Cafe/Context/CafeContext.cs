using AcunMedya.Cafe.Entities;

using Microsoft.EntityFrameworkCore;

namespace AcunMedya.Cafe.Context
{
    public class CafeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-493DFJA\\SQLEXPRESS; initial catalog=DbAcunMedyaCafe; integrated Security=true; TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
