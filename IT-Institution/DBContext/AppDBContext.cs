using IT_Institution.Entities;
using Microsoft.EntityFrameworkCore;

namespace IT_Institution.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(a => a.Address)
                .WithOne(s => s.Student)
                .HasForeignKey<Address>(sId => sId.StudentId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
