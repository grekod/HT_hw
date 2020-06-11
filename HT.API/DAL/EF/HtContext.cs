using Microsoft.EntityFrameworkCore;

namespace HT.API.DAL.EF
{
    public class HtContext : DbContext
    {

        public HtContext(DbContextOptions<HtContext> options) : base(options)
        {}

        public DbSet<Memory> Memories {get; set;}
    }
}