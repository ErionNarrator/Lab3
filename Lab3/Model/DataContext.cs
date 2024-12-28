using Microsoft.EntityFrameworkCore;

namespace Lab3.Model;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<Tariff> Tariffs => Set<Tariff>();
    public DbSet<ReportСard> ReportСards => Set<ReportСard>();
    public DbSet<User> Users => Set<User>();
}