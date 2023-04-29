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

    public void Delete(int id)
    {
        _userRepository.Delete(id);
    }
}