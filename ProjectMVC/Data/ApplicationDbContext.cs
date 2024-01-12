using Microsoft.EntityFrameworkCore;
using ProjectMVC.Models;

namespace ProjectMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().HasData(
                new Member { Id = 1, Name = "王小明", Mail = "wang@hotmail.com"},
                new Member { Id = 2, Name = "林小美", Mail = "lin@hotmail.com" },
                new Member { Id = 3, Name = "陳大旺", Mail = "chen@hotmail.com" }
            );
        }
    }
}
