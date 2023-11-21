using DoAnMonHTN.Models;
using Microsoft.EntityFrameworkCore;

namespace DoAnMonHTN.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Device> Device { get; set; }
        public DbSet<Logs> Logs { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{

        //}
    }
}
