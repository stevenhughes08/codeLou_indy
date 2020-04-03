using Microsoft.EntityFrameworkCore;
using suitcase.Models;

namespace suitcase.Data
{
public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options) {}
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<ActPerformer>().HasKey(t => new { t.PerformerId, t.ActId });
            modelBuilder.Entity<ActProp>().HasKey(t => new { t.PropId, t.ActId });
        }
    public DbSet<Act> Acts {get; set; }
    public DbSet<Performance> Performances {get; set;}
    public DbSet<Performer> Performers { get; set; }
    public DbSet<Prop> Props { get; set; }
    
}

}

