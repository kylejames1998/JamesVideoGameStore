using JamesVIdeoGameStore.Models;
using Microsoft.EntityFrameworkCore;

namespace JamesVIdeoGameStore.Data
{
    public class JamesVGSContext : DbContext
    {
        public JamesVGSContext(DbContextOptions<JamesVGSContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
