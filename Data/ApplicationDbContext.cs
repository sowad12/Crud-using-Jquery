using Game.Model;
using Microsoft.EntityFrameworkCore;

namespace Game.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }
        public DbSet<GameModel> Games { get; set; }
    }
}
