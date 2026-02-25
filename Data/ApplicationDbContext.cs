using Microsoft.EntityFrameworkCore;
using SteadyFast.Models.Account;

namespace SteadyFast.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
