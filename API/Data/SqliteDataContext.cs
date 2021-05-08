using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class SqliteSqliteDataContext: SqliteDataContext
    {
        public SqliteSqliteDataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=datingapp.db");
    }
}