using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Sinlist.EntityFrameworkCore.EntityFrameworkCore;

namespace Sinlist.EntityFrameworkCore
{
    public class BloggingContextFactory : IDesignTimeDbContextFactory<SinlistDbContext>
    {
        public SinlistDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SinlistDbContext>();
            optionsBuilder.UseSqlServer("server=.;database=SinlistDb;trusted_connection=true;");

            return new SinlistDbContext(optionsBuilder.Options);
        }
    }
}
