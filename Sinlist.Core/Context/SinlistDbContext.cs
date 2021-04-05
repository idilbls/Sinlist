using Microsoft.EntityFrameworkCore;
using Sinlist.Core.Entities.Lists;

namespace Sinlist.Core.Context
{
    public class SinlistDbContext : DbContext
    {
        public SinlistDbContext(DbContextOptions<SinlistDbContext> options) : base(options)
        {

        }
        public DbSet<List> Lists { get; set; }
        public DbSet<ListItem> ListItems { get; set; }
    }
}