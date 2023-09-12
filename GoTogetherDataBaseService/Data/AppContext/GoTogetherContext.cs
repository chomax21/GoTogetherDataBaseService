using GoTogetherDataBaseService.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GoTogetherDataBaseService.Data.AppContext
{
    public class GoTogetherContext : DbContext
    {
        public GoTogetherContext(DbContextOptions<GoTogetherContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProperties> UserProperties { get; set; }   
    }
}
