using Microsoft.EntityFrameworkCore;
using sol23.Models;

namespace sol23.Services;

public class SqlServerDbContext : DbContext
{
    public DbSet<Hero>? Heros { get; set; }

    public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : base(options)
    {

    }
}