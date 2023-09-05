using GoTogetherDataBaseService.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GoTogetherDataBaseService.Data.AppContext
{
    public class GoTogetherContext : DbContext
    {
        public GoTogetherContext(DbContextOptions<GoTogetherContext> options) : base(options)
        {
        }

        DbSet<User> Users { get; set; }
        DbSet<UserProperties> userProperties { get; set; }
   
    }
}
