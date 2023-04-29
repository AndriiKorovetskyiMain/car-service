using Microsoft.EntityFrameworkCore;
using UserManagementDomain;
using UserManagementDomain.Repository;
using UserManagementEF;

namespace UserManagementRestApi.Repository;

public class UserRepository : IUserRepository
{
    private readonly UserDbContext _userDbContext;

    public UserRepository(UserDbContext userDbContext)
    {
        _userDbContext = userDbContext;
    }
    
    public User GetById(int id)
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

    public void Delete(User user)
    {
        _userDbContext.Users.Remove(user);
        _userDbContext.SaveChanges();
    }
}