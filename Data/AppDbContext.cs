using Microsoft.EntityFrameworkCore; 
using APIResources.Models;
namespace APIResources.Data
{
    /// MAP
    public class AppDbContext : DbContext
    {
             public DbSet<Resource>  Resources {get;set;}

             protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             => optionsBuilder.UseSqlite(connectionString:"DataSource=app.db;Cache=Shared");

             
    }
}