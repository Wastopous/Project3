using Microsoft.EntityFrameworkCore;
using Project3.Models;

namespace Project3.ViewModels;

public class YourDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "server=sql12.freesqldatabase.com;database=sql12662721;user=sql12662721;password=DGEyGJsNjB;port=3306;"; 
        //string connectionString = "10.10.1.24;database=pro1_16;user=usep_01;password=user01pro;port=3306;";

        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

    // DbSet для ваших сущностей (например, Company)
    public DbSet<Company> Companies { get; set; }
    public DbSet<Risk> Risks { get; set; }
    public DbSet<RiskCategory> RiskCategories { get; set; }
    public DbSet<Strategy> Strategies { get; set; }
    public DbSet<Impact> Impacts { get; set; }
}

