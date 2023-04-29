using Microsoft.EntityFrameworkCore;
using UserManagementDomain;

namespace UserManagementEF;

public class UserDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=CarService.UserManagement;TrustServerCertificate=True;User=sa;Password=Welcome1$;");
    }
}
