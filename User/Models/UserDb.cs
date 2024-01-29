using Microsoft.EntityFrameworkCore;

namespace User.Models
{
    public class UserDb : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string ConnectionString;
        public DbSet<Users> Users { get; set; }

        public UserDb(IConfiguration configuration)
        {
            _configuration = configuration;
            ConnectionString = _configuration["ConnectionString:DefaultConnection"];
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
    }
}
