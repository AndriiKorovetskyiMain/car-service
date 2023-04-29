using UserManagementDomain.Dto;

namespace UserManagementDomain.Services;

public interface IUserService
{
    User Create(UserDto userDto);
}