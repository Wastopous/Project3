using Microsoft.EntityFrameworkCore;
using Project3.Models;
namespace Project3.ViewModels;

public class YourDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "server=localhost;database=project3;user=root;password=1234;port=3306;"; 
        // "server=10.10.1.24;user=user_01;password=user01pro;database=pro1_16";
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        
    }

    public YourDbContext()
    {
        Database.EnsureCreated();
    }
    
    public DbSet<Company> Company { get; set; }
    public DbSet<Risk> Risk { get; set; }
    public DbSet<RiskCategory> RiskCategory { get; set; }
    public DbSet<Strategy> Strategy { get; set; }
    public DbSet<Impact> Impact { get; set; }
    public DbSet<RiskMitigation> RiskMitigation { get; set; }
    public DbSet<ThreatPrevention> ThreatPrevention { get; set; }
}