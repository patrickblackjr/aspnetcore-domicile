using Microsoft.EntityFrameworkCore;
using Domicile.API.Domain.Models;

namespace Domicile.API.Domain.Database.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().ToTable("Categories");
        }
    }
}