using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class SqliteDataContext: DataContext
    {
        public SqliteDataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=datingapp.db");
    }
}