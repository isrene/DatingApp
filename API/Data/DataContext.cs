using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class SqliteDataContext : DbContext
    {
        public SqliteDataContext(DbContextOptions options) : base(options)
        {
        
        }
        public DbSet<AppUser> Users { get; set; }
    }
}