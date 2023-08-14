using Microsoft.EntityFrameworkCore;

public class SqlServerContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=Magic1412;Database=test3;Trusted_Connection=True;TrustServerCertificate=true;");
    }
}