using Microsoft.EntityFrameworkCore;
using UserManagementDomain;
using UserManagementDomain.Repository;

namespace UserManagementRepository;

public class UserRepository : IUserRepository
{
    private readonly UserDbContext _userDbContext;

    public UserRepository(UserDbContext userDbContext)
    {
        _userDbContext = userDbContext;
    }
    
    public User? GetById(int id)
    {
        return _userDbContext.Users.Find(id);
    }

    public void Create(User user)
    {
        _userDbContext.Users.Add(user);
        _userDbContext.SaveChanges();
    }

    public void Update(User user)
    {
        _userDbContext.Entry(user).State = EntityState.Modified;
        _userDbContext.SaveChanges();
    }

    public void Delete(int id)
    {
        var user = _userDbContext.Users.SingleOrDefault(u => u.Id == id);

        if (user is null) return;

        _userDbContext.Users.Remove(user);
        _userDbContext.SaveChanges();
    }
}