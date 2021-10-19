using Microsoft.EntityFrameworkCore;
using server;

namespace ConferencePlanner.GraphQL.Data
{
    public class ServerDbContext : DbContext
    {
        public ServerDbContext(DbContextOptions<ServerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Portfolio> Portfolios { get; set; }
    }
}
