using Microsoft.EntityFrameworkCore;
using NFL.Models;

namespace NFL.Context
{
    public class EFContext : DbContext
    {
        public DbSet<Match> Matches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=.//../DB/nfl.db");
        }
    }
}
