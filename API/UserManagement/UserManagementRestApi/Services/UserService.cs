using UserManagementDomain;
using UserManagementDomain.Dto;
using UserManagementDomain.Repository;
using UserManagementDomain.Services;

namespace UserManagementRestApi.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public User? GetById(int id)
    {
        var user = _userRepository.GetById(id);

        return user;
    }

    public IEnumerable<User> GetList(bool includeInactive = false)
    {
        var users = _userRepository.GetList(includeInactive);
        return users;
    }

    public User Create(UserDto userDto)
    {
        if (string.IsNullOrWhiteSpace(userDto.Username))
        {
            throw new ArgumentException("Username cannot be empty");
        }

        if (string.IsNullOrWhiteSpace(userDto.Password))
        {
            throw new ArgumentException("Password cannot be empty");
        }

        if (string.IsNullOrWhiteSpace(userDto.Email))
        {
            throw new ArgumentException("Email cannot be empty");
        }

        // create new User object using userDto data
        var user = new User
        {
            Username = userDto.Username, Password = userDto.Password, Email = userDto.Email, IsActive = true,
        };

        // save new user in the database using the repository
        _userRepository.Create(user);

        return user;
    }

    public void Activate(int id)
    {
        _userRepository.Activate(id);
    }
    
    public void Deactivate(int id)
    {
        _userRepository.Deactivate(id);
    }

    public void Delete(int id)
    {
        _userRepository.Delete(id);
    }
}