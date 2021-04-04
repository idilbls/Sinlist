using Microsoft.EntityFrameworkCore;
using Sinlist.Core.Entities.Lists;

namespace Sinlist.EntityFrameworkCore.EntityFrameworkCore
{
    public class SinlistDbContext : DbContext
    {
        public SinlistDbContext(DbContextOptions<SinlistDbContext> options) : base(options)
        {
        }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<ListItem> ListItems { get; set; }
    }
}