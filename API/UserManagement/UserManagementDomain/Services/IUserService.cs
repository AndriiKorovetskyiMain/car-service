using UserManagementDomain.Dto;

namespace UserManagementDomain.Services;

public interface IUserService
{
    User? GetById(int id);

    User Create(UserDto userDto);

    void Delete(int id);
}