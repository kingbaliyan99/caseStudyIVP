using Microsoft.EntityFrameworkCore;

public class AppDbContext:DbContext{
    public AppDbContext(DbContextOptions <AppDbContext> options):base(options){

    }
    public DbSet<Equity>? Equities{ get; set; }
    public DbSet<Bond>? Bonds{ get; set; }
}