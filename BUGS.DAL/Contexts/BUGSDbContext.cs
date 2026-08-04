using BUGS.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BUGS.DAL.Contexts;

public class BUGSDbContext : DbContext
{
    public DbSet<Contract> Contracts { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public BUGSDbContext() {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
    optionsBuilder.UseSqlite("Data Source=bugs.db");    
}