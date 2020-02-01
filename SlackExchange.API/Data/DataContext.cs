using Microsoft.EntityFrameworkCore;
using SlackExchange.API.Models;

namespace SlackExchange.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Value> Values { get; set; }

        public DbSet<User> Users { get; set; }
    }
}