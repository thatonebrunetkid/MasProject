using FileApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FileApi.DatabaseConnection
{
    public class MasDbContext : DbContext
    {

        public MasDbContext(DbContextOptions<MasDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Client> Client { get; set; }
        public DbSet<Policies> Policy2 { get; set; }
        public DbSet<Vehicle> Vehicle2 { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Model2> Model2 { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
