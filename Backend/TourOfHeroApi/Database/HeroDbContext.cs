using Microsoft.EntityFrameworkCore;
using TourOfHeroApi.Models;

namespace TourOfHeroApi.Database
{
    public class HeroDbContext :DbContext
    {
        public HeroDbContext(DbContextOptions<HeroDbContext> options) : base(options) { }

        public DbSet<Hero> Heroes { get; set; }
    }
}
