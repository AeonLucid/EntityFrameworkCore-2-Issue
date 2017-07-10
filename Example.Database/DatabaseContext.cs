using Example.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Example.Database
{
    public class DatabaseContext : DbContext
    {
        protected DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>(builder =>
            {
                builder.HasKey(x => x.Id);

                builder.Property(p => p.Id).ValueGeneratedOnAdd();

                builder.Property(x => x.Name)
                    .HasMaxLength(32)
                    .IsRequired();

                builder.Property(x => x.Password)
                    .HasMaxLength(32)
                    .IsRequired();
            });
        }
    }
}
