using Microsoft.EntityFrameworkCore;
using WebMvcMySQL.Models;

namespace WebMvcMySQL.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {

        }
        public DbSet<User> User { get; set; }
    }
}
