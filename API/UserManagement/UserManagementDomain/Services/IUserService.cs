using UserManagementDomain.Dto;

namespace UserManagementDomain.Services;

public interface IUserService
{
    User? GetById(int id);

    User Create(UserDto userDto);
    
    void Activate(int id);
    
    void Deactivate(int id);

    void Delete(int id);
}