using Microsoft.EntityFrameworkCore;
using ExamensArbete.Models;

namespace ExamensArbete.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Person> People { get; set; } 
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gallery> galleries { get; set; }

        public DbSet<ContactUs> contactUs { get; set; }
        public DbSet<Category> categories { get; set; }
        //public DbSet<Author> Author { get; set; }
        public DbSet<Banner> banners { get; set; }
        public DbSet<Research> researches { get; set; }
        public DbSet<Language> languages { get; set; }
        public DbSet<Team> teams { get; set; }
        public DbSet<Sponsor> sponsors { get; set; }
        public DbSet<ExamensArbete.Models.Author> Authors { get; set; }

    }
}
