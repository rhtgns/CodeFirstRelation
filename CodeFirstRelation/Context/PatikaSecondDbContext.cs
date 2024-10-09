using CodeFirstRelation.Context;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelation
{
    public class PatikaSecondDbContext :DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ROHATGUNES\\SQLEXPRESS0;database=PatikaCodeFirstDb2;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User ve Post arasındaki ilişkiyi tanımlama
            modelBuilder.Entity<User>()
                .HasMany(u => u.Posts)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
        }
    }
}
