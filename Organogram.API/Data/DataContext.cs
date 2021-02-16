using ASP_React.Models;
using Microsoft.EntityFrameworkCore;

namespace Organogram.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ProductionUnit> ProdutionUnit { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Line> Lines { get; set; }

        // Generally, you don't need to configure the one-to-many relationship in entity framework 
        // because one-to-many relationship conventions cover all combinations. 
        // However, you may configure relationships using Fluent API at one place to make it more maintainable.
        // protected override void OnModelCreating(ModelBuilder builder)
        // {
            
        // }
    }
}