using Microsoft.EntityFrameworkCore;
using UserManagementDomain;

namespace UserManagementEF;

public class UserDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
}
