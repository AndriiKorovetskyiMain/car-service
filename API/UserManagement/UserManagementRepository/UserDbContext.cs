using Microsoft.EntityFrameworkCore;
using UserManagementDomain;

namespace UserManagementRepository;

public class UserDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) {}
}