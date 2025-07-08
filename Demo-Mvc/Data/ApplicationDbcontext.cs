using DemoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_Mvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Person> Person { get; set; }
    }
}