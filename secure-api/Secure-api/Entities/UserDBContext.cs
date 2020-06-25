using Microsoft.EntityFrameworkCore;

namespace Secure_api.Entities
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {

        }

        public DbSet<Entities.User> Users { get; set; }
    }
}
